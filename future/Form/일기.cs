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
    public partial class 일기 : Form
    {
        public MS_SQL 데이터베이스 { get; set; }
        public string[] 노드내용 { get; set; }
        public BottomMenuModel BottomMenu { get; set; }

        public 일기(MS_SQL 데이터베이스)
        {
            InitializeComponent();
            InitializeProperty();
            InitializeEvent();
            this.데이터베이스 = 데이터베이스;
            this.일기조회();
        }

        private void InitializeProperty()
        {
            BottomMenu = new BottomMenuModel();
            BottomMenu.SubMenu = this.treeView1;
            BottomMenu.Ctv = this.컨텐츠관리자;
        }

        private void InitializeEvent()
        {
            this.BottomMenu.SubMenu.NodeMouseClick += SubMenu_NodeMouseClick;
        }

        private void SubMenu_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            this.노드내용 = e.Node.Text.Split(':');

            string Query = @"--------------------------------------
                             select * from 일기
                             where 제목='{0}'
             -------------------------------------------------- ";
            DataTable 결과 = 데이터베이스.Select(string.Format(Query, 노드내용[1]));
            txb일기내용.Text = 결과.Rows[0]["내용"].ToString();
        }

        private void 일기조회()
        {
            treeView1.Nodes.Clear();
            string Query = @"--------------------------------------
                             select * from 일기
             -------------------------------------------------- ";
            DataTable 결과 = 데이터베이스.Select(string.Format(Query, txb일기내용.Text));
            foreach (DataRow 행 in 결과.Rows)
            {
                treeView1.Nodes.Add(DateTime.Parse(행["날짜"].ToString()).ToShortDateString() + ":" + 행["제목"].ToString());

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Query = @"------------------------------------
                                    INSERT INTO [일기]
                                            ([날짜]
                                            ,[내용]
                                            ,[제목])
                                        VALUES
                                            (GETDATE() 
                                            ,'{0}'
                                            ,'{1}')
            ----------------------------------------------------";
            데이터베이스.ExecQuery(string.Format(Query, txb일기내용.Text, textBox2.Text));
            일기조회();
        }
        
        private void btDelete_Click(object sender, EventArgs e)
        {
            string Query = @"------------------------------------
                                DELETE FROM [일기]
                                 WHERE 제목 = '{0}'
                -------------------------------------------------";
            데이터베이스.ExecQuery(string.Format(Query, 노드내용[1]));
            this.일기조회();

        }
                       

    }
}
