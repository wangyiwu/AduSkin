using AduSkin.Controls.Metro;
using System.Windows;

namespace LightGood
{
   public partial class App : Application
   {
      public App()
      {
#if !NET45
         // start from net46 , you need to register text encoding provider first to use it!
         System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
#endif
      }

      protected override void OnStartup(StartupEventArgs e)
      {
         var splashScreen = new SplashScreen("Resources/aduskin.png");
         splashScreen.Show(true);
         base.OnStartup(e);
         //Hộp thông báo khởi tạo
         NoticeManager.Initialize();
      }
      protected override void OnExit(ExitEventArgs e)
      {
         NoticeManager.ExitNotification();
         base.OnExit(e);
      }
   }
}