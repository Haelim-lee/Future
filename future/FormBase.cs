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
    public partial class FormBase : Form
    {
        public UserSession Session;
        public MS_SQL 데이터베이스 { get; set; }
        public FormBase()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopLevel = false;

            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }
       public void InitlailzeComponent()
       {
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "FormBase";
            this.ResumeLayout(false);
        }


    }
}
