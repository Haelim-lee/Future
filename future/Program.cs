using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace future
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MS_SQL 데이터베이스 = new MS_SQL();//데이터베이스 생성
            데이터베이스.Connet();

            //로그인 실행 
            LoginForm 로그인화면 = new LoginForm(데이터베이스);//로그인화면
            로그인화면.ShowDialog();
            // 메인 화면 실행
            Application.Run(new FutureMain(데이터베이스));
        }
    }
}
