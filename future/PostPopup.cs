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
    public partial class PostPopup : Form
    {
        private MemberJoin M { get; set; }
        private MS_SQL Agent { get; set; }
        private string sAddress { get; set; }
        private string sCode { get; set; }
        private string sLocation { get; set; }

        public PostPopup(object[] Param)
        {
            InitializeProperty(Param);
            InitializeComponent();
            InitializeEvent();
        }

        private void InitializeEvent()
        {
            throw new NotImplementedException();
        }

        private void InitializeProperty(object[] param)
        {
            throw new NotImplementedException();
        }

        public PostPopup()
        {
            InitializeComponent();
        }
    }
}
