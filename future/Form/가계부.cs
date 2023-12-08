using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace future
{
    public partial class AccountBook : Form
    {
        public MS_SQL DB { get; set; }
        public BottomMenuModel BottomMenu { get; set; }


        public AccountBook(MS_SQL db)
        {
            InitializeComponent();
            this.DB = db;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            지출조회();
        }

        private void 지출조회()
        {
            string Query = @"--------------------------------------
                              SELECT 
                              * FROM [AccountBook]
	                          where ClassType = '지출'
               -------------------------------------------------- ";
            DataTable result = DB.Select(string.Format(Query));
            this.지출DataGridVeiw.DataSource = result;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            수입조회();
        }

        private void 수입조회()
        {
            string Query = @"--------------------------------------
                              SELECT 
                              * FROM [AccountBook]
	                          where ClassType = '수입'
               -------------------------------------------------- ";
            DataTable result = DB.Select(string.Format(Query));
            this.수입DataGridVeiw.DataSource = result;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //지츌입력
            string Query = @"------------------------------------------
                                  INSERT INTO [AccountBook]
                                            ([Date]
                                            ,[ClassType]
                                            ,[Amount]
                                            ,[Text]
                                            ,[divide])
                                        VALUES
                                            (GETDATE() 
                                            ,'지출'
                                            ,'{0}'
                                            ,'{1}'  
                                            ,'{2}')
              ----------------------------------------------------------";
           
            DB.ExecQuery(string.Format(Query, TXB지출금액.Text, TXB지출메모.Text, CBO지출분류.Text));
            지출조회();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //수입입력
            string Query = @"-------------------------------------------
                               INSERT INTO [AccountBook]
                                            ([Date]
                                            ,[ClassType]
                                            ,[Text]
                                            ,[Amount]
                                            ,[divide])
                                        VALUES
                                            (GETDATE() 
                                            ,'수입'
                                            ,'{0}'
                                            ,'{1}'  
                                            ,'{2}')
              ----------------------------------------------------------";
            DB.ExecQuery(string.Format(Query, TXB수입메모.Text, TXB수입금액.Text, CBO수입분류.Text));
            수입조회();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //지출삭제
            DataGridViewRow 선택된행 = 지출DataGridVeiw.CurrentRow;
            string 키값 = 선택된행.Cells["Guid"].Value.ToString();

            string Query = @"------------------------------------
                                DELETE FROM [AccountBook]
                                    WHERE Guid = '{0}'
                -------------------------------------------------";
            DB.ExecQuery(string.Format(Query, 키값));
            지출조회();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //수입삭제
            DataGridViewRow 선택된행 = 지출DataGridVeiw.CurrentRow;
            string 키값 = 선택된행.Cells["Guid"].Value.ToString();

            string Query = @"------------------------------------
                                DELETE FROM [AccountBook]
                                 WHERE Guid = '{0}'
                -------------------------------------------------";
            DB.ExecQuery(string.Format(Query,키값));
            수입조회();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //닫기버튼
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //월별조회
            string 년도 = this.cbo월별조회년도.Text;
            string 월 = this.cbo월별조회월.Text.Replace('월', ' ').Trim();

            string 시작일 = 년도 + "-" + 월.PadLeft(2, '0') + "-01";
            string 종료일 = 년도 + "-" + 월.PadLeft(2, '0') + "-" + DateTime.DaysInMonth(Convert.ToInt32(년도), Convert.ToInt32(월)).ToString().PadLeft(2, '0');

            string Query = @"--------------------------------------
                              SELECT 
                              * FROM [AccountBook]
                                WHERE Date BETWEEN '{0}' AND '{1}'
               -------------------------------------------------- ";
            DataTable 결과 = DB.Select(string.Format(Query, 시작일, 종료일));
            this.월별DatagridVeiw.DataSource = 결과;

            int 월수입계산값 = 0;
            int 월지출계산값 = 0;
            

            Query = @"--------------------------------------
                              SELECT 
                              * FROM AccountBook
            -------------------------------------------------- ";
            DataTable 결과값 = DB.Select(string.Format(Query));
            this.통계DataGridVeiw.DataSource = 결과값;

            foreach (DataRow 행 in 결과값.Rows)
            {
                if (행["ClassType"].ToString() == "수입")
                    월수입계산값 += Convert.ToInt32(행["Amount"].ToString());
                else
                    월지출계산값 += Convert.ToInt32(행["Amount"].ToString());
            }

            this.월수입.Text = 월수입계산값.ToString();
            this.월지출.Text = 월지출계산값.ToString();

            int 월합계값 = 월수입계산값 -= 월지출계산값;
            this.합계.Text = 월합계값.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            전체조회();
        }

        private void 전체조회()
        {
            int 수입계산값 = 0;
            int 지출계산값 = 0;

            string Query = @"--------------------------------------
                              SELECT 
                              * FROM AccountBook
               -------------------------------------------------- ";
            DataTable 결과 = DB.Select(string.Format(Query));
            this.통계DataGridVeiw.DataSource = 결과;

            foreach (DataRow 행 in 결과.Rows)
            {
                if (행["ClassType"].ToString() == "수입")
                    수입계산값 += Convert.ToInt32(행["Amount"].ToString());
                else
                    지출계산값 += Convert.ToInt32(행["Amount"].ToString());
            }

            this.통계수입총금액.Text = 수입계산값.ToString();
            this.통계지출총금액.Text = 지출계산값.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //지출수정
            DataGridViewRow 선택된행 = 지출DataGridVeiw.CurrentRow;
            DataTable dt = 지출DataGridVeiw.DataSource as DataTable;

            string ClassType = 선택된행.Cells["ClassType"].Value.ToString();
            string Text = 선택된행.Cells["Text"].Value.ToString();
            string Amount = 선택된행.Cells["Amount"].Value.ToString();
            string divide = 선택된행.Cells["divide"].Value.ToString();
            string 키값 = 선택된행.Cells["Guid"].Value.ToString();

            string Query = @"------------------------------------
                                  UPDAET [AccountBook]
                                    SET ClassType = '{0}'
                                    , Text = '{1}'
                                    , Amount = '{2}'
                                    , divide = '{3}'
                                    WHERE Guid = '{4}'
                -------------------------------------------------";
            DB.ExecQuery(string.Format(Query,ClassType,Text,Amount,divide,키값));
            지출조회();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //수입수정
            DataGridViewRow 선택된행 = 지출DataGridVeiw.CurrentRow;
            DataTable dt = 수입DataGridVeiw.DataSource as DataTable;

            string ClassType = 선택된행.Cells["ClassType"].Value.ToString();
            string Text = 선택된행.Cells["Text"].Value.ToString();
            string Amount = 선택된행.Cells["Amount"].Value.ToString();
            string divide = 선택된행.Cells["divide"].Value.ToString();
            string 키값 = 선택된행.Cells["Guid"].Value.ToString();

            string Query = @"-------------------------------------------
                                    UPDAET [AccountBook]
                                    SET ClassType = '{0}'
                                    , Text = '{1}'
                                    , Amount = '{2}'
                                    , divide = '{3}'
                                    WHERE Guid = '{4}'
            ------------------------------------------------------------";
            DB.ExecQuery(string.Format(Query, ClassType, Text, Amount, divide, 키값));
            수입조회();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // DateTimePicker 통계검색
            string 선택한Date = this.통계datetime.Value.ToShortDateString(); 

            string Query = @"---------------------------------------------
                                        SELECT 
                                        *FROM [AccountBook]
                                        WHERE Date = '{0}'
             ------------------------------------------------------------";
            DataTable 결과 = DB.Select(string.Format(Query,선택한Date));
            this.통계DataGridVeiw.DataSource = 결과;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //지출검색
            string sql = Search().ToString();
            DataTable 결과 = DB.Select(sql);
            this.지출DataGridVeiw.DataSource = 결과;

        }

        public string Search()
        {
            //지출검색Search
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SELECT ClassType");
            sb.AppendLine("      ,Text");
            sb.AppendLine("      ,Amount");
            sb.AppendLine("      ,Date");
            sb.AppendLine("      ,divide");
            sb.AppendLine("FROM AccountBook");
            sb.AppendLine("WHERE 1=1");


            if (this.TXB지출금액.Text != string.Empty)
            {
                sb.AppendLine("AND Amount LIKE '%" + this.TXB지출금액.Text +"%'");
            }
            if(this.CBO지출분류.SelectedIndex!= -1)
            {
                sb.AppendLine("AND divide LIKE '" + this.CBO지출분류.Text + "'");
            }
            if(this.TXB지출메모.Text!= string.Empty)
            {
                sb.AppendLine("AND Text LIKE '%" + this.TXB지출메모.Text + "'");
            }
            return sb.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //수입검색
            string sql = Search2().ToString();
            DataTable 결과 = DB.Select(sql);
            this.수입DataGridVeiw.DataSource = 결과;
        }

        private object Search2()
        {
            //수입검색Search
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SELECT ClassType");
            sb.AppendLine("      ,Text");
            sb.AppendLine("      ,Amount");
            sb.AppendLine("      ,Date");
            sb.AppendLine("      ,divide");
            sb.AppendLine("FROM AccountBook");
            sb.AppendLine("WHERE 1=1");
            
            if (this.TXB수입금액.Text != string.Empty)
            {
                sb.AppendLine("AND Amount LIKE '%" + this.TXB수입금액.Text + "%'");
            }
            if (this.CBO수입분류.SelectedIndex != -1)
            {
                sb.AppendLine("AND divide LIKE '" + this.CBO수입분류.Text + "'");
            }
            if (this.TXB수입메모.Text != string.Empty)
            {
                sb.AppendLine("AND Text LIKE '%" + this.TXB수입메모.Text + "'");
            }
            
            return sb.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //시작Amount수정
            int 수입계산값 = 0;
            int 지출계산값 = 0;
            int 시작Amount = 0;

            string Query = @"--------------------------------------
                              SELECT 
                              * FROM AccountBook
               -------------------------------------------------- ";
            DataTable 결과 = DB.Select(string.Format(Query));
            this.통계DataGridVeiw.DataSource = 결과;

            foreach (DataRow 행 in 결과.Rows)
            {
                if (행["ClassType"].ToString() == "수입")
                    수입계산값 += Convert.ToInt32(행["Amount"].ToString());
                else
                    지출계산값 += Convert.ToInt32(행["Amount"].ToString());
            }

            this.월수입.Text = 수입계산값.ToString();
            this.월지출.Text = 지출계산값.ToString();
            int 합계값 = 수입계산값 - 지출계산값;
            this.합계.Text = 합계값.ToString();
            this.시작금액.Text = 시작금액txb.Text;
            int 현재Amount값 = 시작Amount - 합계값;
            this.현재금액.Text = 현재Amount값.ToString();
        }
    }
}
