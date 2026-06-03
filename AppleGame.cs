using System;
using System.Windows.Forms;
using OPP_project.Source.UI; .

namespace AppleGame
{

    public static class AppleGame
    {
        // OLE 스레딩 모델을 Windows Forms에 맞게 설정하는 필수 보안 장치
        [STAThread]

        public static void Main()
        {
            // Windows Forms 환경을 초기화
            ApplicationConfiguration.Initialize();

            // 메인 메뉴 화면(MainMenuForm)을 화면에 띄우면서 게임을 시작!
            Application.Run(new MainMenuForm());
        }
    }
}