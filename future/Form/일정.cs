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
    
    public partial class 일정 : Form
    {
        public MS_SQL 데이터베이스 { get; set; }
        public Button[] 날짜들 { get; set; }

        public 일정(MS_SQL 데이터베이스)
        {
            this.데이터베이스 = 데이터베이스;
            InitializeComponent();
            InitialzeProperty();
            InitialzeEvent();

        }

        private void InitialzeProperty()
        {
            BottomMenuModel bottomMenu = new BottomMenuModel();
            날짜들 = new Button[] { button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32, button33, button34, button35, button36, button37, button38, button39, button40 };
            this.lb메인월.Text = DateTime.Now.ToString("MM");
            this.lb메인월.Text.Substring(0, this.lb메인월.Text.Length - 1);
            this.LB메인년도.Text = DateTime.Now.Year.ToString();
        }

        

        private void InitialzeEvent()
        {
           
            foreach (Button 일자 in this.날짜들)
            {
                일자.Click += 일자_Click;
                일자.Click += (object sender, EventArgs e) => { 일자.BackColor = Color.Thistle; };//일정이추가되면 바뀌게 
            }
        }

        private void 일자_Click(object sender, EventArgs e)
        {
            일정추가 일정추가화면 = new 일정추가(this.데이터베이스);
            일정추가화면.Show();

         
        }

        private void button5_Click(object sender, EventArgs e)
        {
           string 월 = this.lb메인월.Text.Substring(0, this.lb메인월.Text.Length - 1);
           int 일자 = 1;
           int 당월일수 = DateTime.DaysInMonth(Convert.ToInt32(this.LB메인년도.Text), Convert.ToInt32(월));//여기 월이 0 이됨 오류 수정해야함
           int 당월첫날 = 0;
           
            DayOfWeek 요일 = DateTime.Parse(string.Format("{0}-{1}-01", LB메인년도.Text, 월)).DayOfWeek;
            
            this.lb메인월.Text = (Convert.ToInt32(월) + 1).ToString();
            if (this.lb메인월.Text== "13")
                this.lb메인월.Text = "1";
            
            switch (요일)
            {
                case DayOfWeek.Sunday: 당월첫날 = 0; break;
                case DayOfWeek.Monday: 당월첫날 = 1; break;
                case DayOfWeek.Tuesday: 당월첫날 = 2; break;
                case DayOfWeek.Wednesday: 당월첫날 = 3; break;
                case DayOfWeek.Thursday: 당월첫날 = 4; break;
                case DayOfWeek.Friday: 당월첫날 = 5; break;
                case DayOfWeek.Saturday: 당월첫날 = 6; break;
                default: break;
            }
           
            for (int i = 0; i < 35; i++)
                날짜들[i].Text = "";

            for (int i = 당월첫날; i < 35; i++)
            {
                if( 일자== 당월일수+1)break;
                날짜들[i].Text = (일자++).ToString();
            }
        }
       
        private void button4_Click(object sender, EventArgs e)
        {

            string 월 = this.lb메인월.Text;
            int 일자 = 1;
            int 당월일수 = DateTime.DaysInMonth(Convert.ToInt32(this.LB메인년도.Text), Convert.ToInt32(월));
            int 당월첫날 = 0;

            DayOfWeek 요일 = DateTime.Parse(string.Format("{0}-{1}-01", LB메인년도.Text, 월)).DayOfWeek;

            string 날짜 = this.lb메인월.Text.Substring(0, this.lb메인월.Text.Length - 1);

            if (this.lb메인월.Text == "0")
                this.lb메인월.Text = "12";

            switch (요일)
            {
                case DayOfWeek.Sunday: 당월첫날 = 0; break;
                case DayOfWeek.Monday: 당월첫날 = 1; break;
                case DayOfWeek.Tuesday: 당월첫날 = 2; break;
                case DayOfWeek.Wednesday: 당월첫날 = 3; break;
                case DayOfWeek.Thursday: 당월첫날 = 4; break;
                case DayOfWeek.Friday: 당월첫날 = 5; break;
                case DayOfWeek.Saturday: 당월첫날 = 6; break;
                default: break;
            }

            for (int i = 0; i < 35; i++)
                날짜들[i].Text = "";

            for (int i = 당월첫날; i < 35; i++)
            {
                if (일자 == 당월일수 + 1) break;
                날짜들[i].Text = (일자++).ToString();
            }
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 입력한 날 달력
            string 년도 = this.BTNtoday.Text;
            string 월 = this.TXB년도.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void 요일계산()
        {


            //if (DateTime.Compare(Da))
            //{
            //    string 월 = this.lb메인월.Text.Substring(0, this.lb메인월.Text.Length - 1);
            //    int 일자 = 1;
            //    int 당월일수 = DateTime.DaysInMonth(Convert.ToInt32(this.LB메인년도.Text), Convert.ToInt32(월));
            //    int 당월첫날 = 0;
            //    DayOfWeek 요일 = DateTime.Parse(string.Format("{0}-{1}-01", LB메인년도.Text, 월)).DayOfWeek;

            //    if (this.lb메인월.Text == "0")
            //        this.lb메인월.Text = "12";

            //    switch (요일)
            //    {
            //        case DayOfWeek.Sunday: 당월첫날 = 0; break;
            //        case DayOfWeek.Monday: 당월첫날 = 1; break;
            //        case DayOfWeek.Tuesday: 당월첫날 = 2; break;
            //        case DayOfWeek.Wednesday: 당월첫날 = 3; break;
            //        case DayOfWeek.Thursday: 당월첫날 = 4; break;
            //        case DayOfWeek.Friday: 당월첫날 = 5; break;
            //        case DayOfWeek.Saturday: 당월첫날 = 6; break;
            //        default: break;
            //    }

            //    for (int i = 0; i < 35; i++)
            //        날짜들[i].Text = "";

            //    for (int i = 당월첫날; i < 35; i++)
            //    {
            //        if (일자 == 당월일수 + 1) break;
            //        날짜들[i].Text = (일자++).ToString();
            //    }

               
            //}
            
        }
    }
}
