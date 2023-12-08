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
    public partial class 목표 : Form
    {
        public MS_SQL 데이터베이스 { get; set; }
        public BottomMenuModel bottomMenu { get; set; }
        public string []목표내용 { get; set; }


        public 목표(MS_SQL  데이터베이스)
        {
            InitializeComponent();
            InitlalizeProperty();
            InitializeEvnet();
            this.데이터베이스 = 데이터베이스;
            this.목표조회();
        }

        private void 목표조회()
        {
            treeView1.Nodes.Clear();
            string Query = @"--------------------------------------
                             select * from 목표
             -------------------------------------------------- ";
            DataTable 결과 = 데이터베이스.Select(string.Format(Query, txb목표제목.Text));
            foreach (DataRow 행 in 결과.Rows)
            {
                treeView1.Nodes.Add(DateTime.Parse(행["날짜"].ToString()).ToShortDateString() + ":" + 행["제목"].ToString());

            }
        }

        private void InitlalizeProperty()
        {
            bottomMenu = new BottomMenuModel();
            bottomMenu.SubMenu = this.treeView1;
            bottomMenu.Ctv = this.tabControl1;
            
        }

        private void InitializeEvnet()
        {
            bottomMenu.SubMenu.NodeMouseClick += SubMenu_NodeMouseClick;
        }

        private void SubMenu_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            this.목표내용 = e.Node.Text.Split(':');

            string Query = @"--------------------------------------
                             select * from 목표
                             where 제목='{0}'
             -------------------------------------------------- ";
            DataTable 결과 = 데이터베이스.Select(string.Format(Query, 목표내용[1]));
            txb목표내용.Text = 결과.Rows[0]["내용"].ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Query = @"------------------------------------
                                    INSERT INTO [목표]
                                            ([날짜]
                                            ,[내용]
                                            ,[제목])
                                        VALUES
                                            (GETDATE() 
                                            ,'{0}'
                                            ,'{1}')
            ----------------------------------------------------";
            데이터베이스.ExecQuery(string.Format(Query, txb목표내용.Text, txb목표제목.Text));
            목표조회();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Query = @"------------------------------------
                                DELETE FROM [목표]
                                 WHERE 제목 = '{0}'
                -------------------------------------------------";
            데이터베이스.ExecQuery(string.Format(Query, 목표내용[1]));
            this.목표조회();
        }
    }
}
