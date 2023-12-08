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
    //폼켰다가 다른 폼 화면 안 바꿔짐^^^^^^^^~~~~~~~~~~~~~~~~~~~~~~
{
    public partial class FutureMain : Form
    {
        public MS_SQL 데이터베이스 { get; set; }
  
        public TopMenuModel TopMenu { get; set; }
       
        public FutureMain(MS_SQL 데이터베이스)
        {
            InitializeComponent();
            InitializePropery();
            InitializeEvent();
            
            this.데이터베이스 = 데이터베이스;
          
        }

        

        private void InitializeEvent()
        {
            TopMenu.일기.Click += 일기_Click;
            TopMenu.정보.Click += 정보_Click;
            TopMenu.일정.Click += 일정_Click;
            TopMenu.목표.Click += 목표_Click;
            TopMenu.가계부.Click += 가계부_Click;

        }

        private void 일정_Click(object sender, EventArgs e)
        {

            Screen.Controls.Clear();
            일정 일정화면 = new 일정(this.데이터베이스);
            일정화면.TopLevel = false;
            Screen.Controls.Add(일정화면);
            일정화면.Dock = DockStyle.Fill;
            일정화면.Show();
        }

        private void 가계부_Click(object sender, EventArgs e)
        {
            Screen.Controls.Clear();
            AccountBook 가계부화면 = new AccountBook(this.데이터베이스);
            가계부화면.TopLevel = false;
            Screen.Controls.Add(가계부화면);
            가계부화면.Dock = DockStyle.Fill;
            가계부화면.Show();
        }

        private void 목표_Click(object sender, EventArgs e)
        {
            Screen.Controls.Clear();
            목표 목표화면 = new 목표(this.데이터베이스);
            목표화면.TopLevel = false;
            Screen.Controls.Add(목표화면);
            목표화면.Dock = DockStyle.Fill;
            목표화면.Show();
        }

       

        private void InitializePropery()
        {
            TopMenu = new TopMenuModel();
            TopMenu.정보 = this.정보;
            TopMenu.목표 = this.목표;
            TopMenu.일기 = this.일기;
            TopMenu.가계부 = this.가계부;
            TopMenu.일정 = this.일정;

        }
        private void 정보_Click(object sender, EventArgs e)
        {
            Screen.Controls.Clear();
            정보 정보화면 = new 정보(this.데이터베이스);
            정보화면.TopLevel = false;
            Screen.Controls.Add(정보화면);
            정보화면.Dock = DockStyle.Fill;
            정보화면.Show();
            
        }

        private void 일기_Click(object sender, EventArgs e)
        {
            Screen.Controls.Clear();
            일기 일기화면 =new 일기(this.데이터베이스);
            일기화면.TopLevel = false;
            Screen.Controls.Add(일기화면);
            일기화면.Dock = DockStyle.Fill;
            일기화면.Show();
        }

   



        
    }
}
