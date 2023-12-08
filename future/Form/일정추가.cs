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
    public partial class 일정추가 : Form
    {
        public MS_SQL 데이터베이스 { get; set; }
        public BottomMenuModel bottomMenu { get; set; }
        public Button[] 날짜들 { get; set; } 
        public string []일정내용 { get; set; }


        public 일정추가(MS_SQL 데이터베이스)
        {
            InitializeComponent();
            InitialzeProperty();
            InitialzeEvent();
            this.데이터베이스 = 데이터베이스;
        }

        private void InitialzeEvent()
        {
          
        }

        private void InitialzeProperty()
        {
            bottomMenu = new BottomMenuModel();
            bottomMenu.Ctv = this.tabControl1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Query = @"------------------------------------
                                    INSERT INTO [일정]
                                            ([날짜]
                                            ,[내용]
                                            )
                                        VALUES
                                            (GETDATE() 
                                            ,'{0}')
            ----------------------------------------------------";
            데이터베이스.ExecQuery(string.Format(Query,TXB일정.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Query = @"----------------------------------------
                                    DELETE FROM [일정]
                                    WHERE 날짜 = (GETDATE())
              ----------------------------------------------------------";
            데이터베이스.ExecQuery(string.Format(Query, 일정내용[1]));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
