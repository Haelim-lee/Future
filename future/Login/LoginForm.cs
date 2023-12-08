using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace future
{
    public partial class LoginForm : Form
    {
        ComponentResourceManager resources = new ComponentResourceManager(typeof(LoginForm));
        private MS_SQL _Agent;
        public LoginForm(MS_SQL Agent)
        {
            _Agent = Agent;
            InitializeComponent();
            InitializeEvent();
        }

        private void InitializeEvent()
        {
            this.KeyDown += (object sender, KeyEventArgs e) => { if (e.KeyCode == Keys.Enter) OnActionLogin(); };
            this.btnJoin.Click += (object sender, EventArgs e) => { new MemberJoin(_Agent).ShowDialog(); };
            this.btnLogin.Click += (object sender, EventArgs e) => { OnActionLogin(); };
        }

        public class Message
        {
            public const string UserIDNotFound = "아이디가 존재하지 않습니다. ";
            public const string UserPWNotMatch = "비밀번호가 맞지 않습니다.";
            public const string ApprovalRequest = "아이디가 승인되지 않았씁니다 \n 승인 버튼을 클릭하여 승인을 기다려주시길 바랍니다 .";
            public const string RequestOk = "승인요청 되었습니다.";
            public const string RequestWaiting = "승인 대기중 입니다.자세한 사항은 관리자에게 문의 바랍니다.\r 관리자 : 010 - 7362 - 8147";
        }
        public class LoginModel
        {
            public const string getSelectUser = @"SELECT *FROM USR_INFO WHERE USR_USERID = '{0}'";
            public const string setUpdateUser = @"UPDATE USR_INFO SET USR_REQ_YN ='Y' WHERE USR_USERID = '{0}'";
        }
        private void OnActionLogin()
        {
            DataTable IDList = _Agent.Select(string.Format(LoginModel.getSelectUser, txtLoginID.Text));
            _Agent.Session = new UserSession();
            _Agent.Session.UserID = txtLoginID.Text;
            //!=같지않음 카운트 0이 
            if (IDList.Rows.Count != 0)
                if (IDList.Rows[0]["USR_PASSWORD"].ToString().Trim() == Security.Encrypt(txtPassword.Text, "DexHive")) OnActionApprovalRequest(IDList); //비번 검사
                else MessageBox.Show(Message.UserPWNotMatch);
            else MessageBox.Show(Message.UserIDNotFound);
        }

        private void OnActionApprovalRequest(DataTable IDList)
        {
            if (IDList.Rows[0]["USR_YN"].ToString().Trim() == "Y")
            {
                _Agent.Session.UserCode = IDList.Rows[0]["USR_CODE"].ToString();
                this.Close();
            }
            else if (IDList.Rows[0]["USR_REQ_YN"].ToString().Trim() == "N")
            {
                DialogResult = MessageBox.Show(Message.ApprovalRequest, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult == DialogResult.Yes)
                {
                    _Agent.ExecQuery(string.Format(LoginModel.setUpdateUser, txtLoginID.Text));
                    MessageBox.Show(Message.RequestOk);
                }
                Application.Exit();
            }
            else MessageBox.Show(Message.RequestWaiting, "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
