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
    public partial class 정보 : Form
    {
        public MS_SQL 데이터베이스 { get; set; }
        public BottomMenuModel bottomMenu { get; set; }

        public 정보(MS_SQL 데이터베이스)
        {
            InitializeComponent();
            InitializeProperty();
            InitializeEvent();
            
            this.데이터베이스 = 데이터베이스;
            string sql = Position().ToString();
            DataTable 결과 = 데이터베이스.Select(sql);

            this.cbo분류.DataSource = 결과;
            this.cbo분류.DisplayMember = "분류";
            this.cbo분류.SelectedIndex = -1;
            this.dataGridView1.AllowUserToAddRows = false;

            정보조회();
        }

        private void InitializeProperty()
        {
            bottomMenu = new BottomMenuModel();
            bottomMenu.SubMenu = this.treeView1;
        }

        private void InitializeEvent()
        {
            this.btn검색.Click += Button2_Click;
            this.btn초기화.Click += Button4_Click;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //초기화버튼
            this.TXB이름.Text = string.Empty;
            this.TXB전화번호.Text = string.Empty;
            this.RBO여.Checked = false;
            this.RBO남.Checked = false;
            this.cbo분류.SelectedIndex = -1;
            this.treeView1.SelectedNode  =null;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string sql = Search().ToString();
            DataTable 결과 = 데이터베이스.Select(sql);
            this.dataGridView1.DataSource = 결과;
        }

        private void 정보조회()
        {                       
            string Query = @"--------------------------------------
                               SELECT 
                              * FROM  [정보]
               -------------------------------------------------- ";
            DataTable 결과 = 데이터베이스.Select(string.Format(Query));
            this.dataGridView1.DataSource = 결과;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable 반영표= this.dataGridView1.DataSource as DataTable;
            for (int Index = 0; Index < 반영표.Rows.Count; Index++)
            {
                if (반영표.Rows[Index].RowState == DataRowState.Modified)
                {
                    string Query = @"------------------------------------
                                    insert into [정보]
                                            ( [이름]
                                            ,[생년월일]
                                            ,[주소]
                                            ,[전화번호]
                                            ,[성별]
                                            ,[직업]
                                            ,[분류]
                                            ,[키]
                                            ,[몸무게]
                                            ,[혈액형]
                                            ,[특이사항])
                                        values
                                            ( 
                                             '{0}'
                                            ,'{1}'
                                            ,'{2}'
                                            ,'{3}'
                                            ,'{4}' 
                                            ,'{5}'
                                            ,'{6}'
                                            ,'{7}'
                                            ,'{8}'
                                            ,'{9}'
                                            ,'{10}')
                    ----------------------------------------------------";
                    string[] 준비물 = new string[11];
                    준비물[0] = 반영표.Rows[Index]["이름"].ToString();
                    준비물[1] = 반영표.Rows[Index]["생년월일"].ToString();
                    준비물[2] = 반영표.Rows[Index]["주소"].ToString();
                    준비물[3] = 반영표.Rows[Index]["전화번호"].ToString();
                    준비물[4] = 반영표.Rows[Index]["성별"].ToString();
                    준비물[5] = 반영표.Rows[Index]["직업"].ToString();
                    준비물[6] = 반영표.Rows[Index]["분류"].ToString();
                    준비물[7] = 반영표.Rows[Index]["키"].ToString();
                    준비물[8] = 반영표.Rows[Index]["몸무게"].ToString();
                    준비물[9] = 반영표.Rows[Index]["혈액형"].ToString();
                    준비물[10] = 반영표.Rows[Index]["특이사항"].ToString();

                    데이터베이스.ExecQuery(string.Format(Query, 준비물));
                    정보조회();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable 반영표 = this.dataGridView1.DataSource as DataTable;
            for (int Index = 0; Index < 반영표.Rows.Count; Index++)
            {
                if (반영표.Rows[Index].RowState == DataRowState.Added)
                {
                    string query = @"------------------------------------
                                   DELETE FROM [정보]
                                        WHERE 전화번호 = '{0}'
                    ----------------------------------------------------";
                    string[] 준비물 = new string[11];
                    준비물[0] = 반영표.Rows[Index]["이름"].ToString();
                    준비물[1] = 반영표.Rows[Index]["생년월일"].ToString();
                    준비물[2] = 반영표.Rows[Index]["주소"].ToString();
                    준비물[3] = 반영표.Rows[Index]["전화번호"].ToString();
                    준비물[4] = 반영표.Rows[Index]["성별"].ToString();
                    준비물[5] = 반영표.Rows[Index]["직업"].ToString();
                    준비물[6] = 반영표.Rows[Index]["분류"].ToString();
                    준비물[7] = 반영표.Rows[Index]["키"].ToString();
                    준비물[8] = 반영표.Rows[Index]["몸무게"].ToString();
                    준비물[9] = 반영표.Rows[Index]["혈액형"].ToString();
                    준비물[10] = 반영표.Rows[Index]["특이사항"].ToString();
                    데이터베이스.ExecQuery(string.Format(query, 준비물));
                }
            }
        }

        public string Search()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SELECT 이름");
            sb.AppendLine("      ,분류");
            sb.AppendLine("      ,전화번호");
            sb.AppendLine("      ,성별");
            sb.AppendLine("  FROM 정보");
            sb.AppendLine(" WHERE 1=1");

            if (this.TXB이름.Text != string.Empty)
            {
                sb.AppendLine("AND 이름 LIKE '%" + this.TXB이름.Text + "%'");
            }  
            if(this.TXB전화번호.Text!= string.Empty)
            {
                sb.AppendLine("AND 전화번호 LIKE '%" + this.TXB전화번호.Text + "%'");
            }
            if (this.cbo분류.SelectedIndex != -1)
            {
                sb.AppendLine("AND 분류 = '" + this.cbo분류.Text + "'");
            }

            string 결과 = this.RBO여.Checked ? "T" : "F";

            if (결과.Equals("T"))
            {
                sb.AppendLine("AND 성별 ='여'"); 
            }
            if (결과.Equals("F"))
            {
                sb.AppendLine("AND 성별 = '남'");
            }

            return sb.ToString();
        }

        public string Position()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SELECT 분류");
            sb.AppendLine(" FROM 정보");

            return sb.ToString();
        }


    }
}
