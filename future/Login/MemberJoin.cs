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
    public partial class MemberJoin : Form
    {
        private MS_SQL Agent;
        private MemberInfoModel _Model;

        public class MemberInfoModel
        {
            public string UserID { get; set; }
            public string UserPW { get; set; }
            public string UserName { get; set; }
            public string UserSex { get; set; }
            public string UserBirthDay { get; set; }
            public string UserPhoneNumber { get; set; }
            public string UserCompany { get; set; }
            public string UserDepartment { get; set; }
            public string UserEmergencyPhone { get; set; }
            public string UserAddress { get; set; }
            public string UserEmail { get; set; }
            public MemberInfoModel(MemberJoin Parents)
            {
                this.UserID = Parents.txtUserID.Text;
                this.UserPW = Parents.txtUserPW.Text;
                this.UserName = Parents.txtUserName.Text;
                this.UserBirthDay = Parents.txtBirthDay.Text;
                this.UserSex = Parents.rdoMale.Checked == true ? "남자" : "여자";
                this.UserPhoneNumber = Parents.txtUserPhone.Text;
                this.UserEmergencyPhone = Parents.txt비상연락망.Text;
                this.UserEmail = Parents.txb메일.Text + "@" + Parents.cbo메일.Text;
            }
            public List<object> CreateMemberInfoParam()
            {
                List<object> Param = new List<object>();
                Param.Add(UserName);
                Param.Add(Security.Encrypt(UserPW, "DexHive"));
                Param.Add(UserID);
                Param.Add("Future");
                Param.Add("N");
                Param.Add("N");
                return Param;
            }

        }
        
        public MemberJoin(MS_SQL Agent)
        {
            this.Agent = Agent;
            InitializeComponent();
            InitializeEvent();
        }

        private void InitializeEvent()
        {
            this.btnPostPopup.Click += (object sender, EventArgs e) => { new PostPopup(new object[] { this, Agent }).ShowDialog(); };
            this.btnJoinOK.Click += (object sender, EventArgs e) => { OnActionMemberJoin(); };
        }

        private void OnActionMemberJoin()
        {
            try
            {
                _Model = new MemberInfoModel(this);
                _Model.CreateMemberInfoParam();
                Agent.ExecQuery(string.Format(SqlQuery.Insertlnfo, _Model.CreateMemberInfoParam().ToArray()));
                MessageBox.Show("회원가입 신청이 완료되었습니다.");
                this.Close();
            }
            catch(Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private class SqlQuery
        {
            public const string Insertlnfo = @"
            ---------------------------------------------------
            INSERT INTO USR_INFO(
            [USR_NAME]      ,[USR_PASSWORD]     ,[USR_USERID]
            ,[MASTERSITE]    ,[USR_YN]           ,[USR_REQ_YN]
            )VALUES
            (
             '{0}','{1}','{2}',
            '{3}','{4}','{5}'
            )
            ------------------------------------------------";
            
        }

        private void btnJoinOK_Click(object sender, EventArgs e)
        {

        }
    }
}
