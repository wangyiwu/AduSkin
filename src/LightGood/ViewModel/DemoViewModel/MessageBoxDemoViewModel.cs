using AduSkin.Controls.Metro;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows;
using System.Windows.Input;

namespace LightGood.ViewModel
{
   public class MessageBoxDemoViewModel : ViewModelBase
   {
      public ICommand OpenMessageBox => new RelayCommand<string>((e) =>
      {
         switch (e)
         {
            case "Khung bom thông thường":
               AduMessageBox.Show("Aduskin \n theo đuổi Ultimate, Yongzhen Perfect \n và tiến về phía trước với gió, một thiên thạch phía sau");
               break;
            case "Khung đạn thông thường 2":
               AduMessageBox.Show("Aduskin đang được làm đẹp!"," Tiêu đề Aduskin");
               break;
            case "Xác nhận hộp bom hủy":
               AduMessageBox.Show("Bạn có tiếp tục hỗ trợ Aduskin không!", "Tiêu đề Aduskin", MessageBoxButton.OKCancel);
               break;
            case "Xác nhận hộp hủy với biểu tượng":
               AduMessageBox.Show("Bạn có tiếp tục hỗ trợ Aduskin không!", "Tiêu đề Aduskin", MessageBoxButton.YesNo, MessageBoxImage.Asterisk);
               break;
            case "Khung máy bay ném bom tùy chỉnh":
               MessageBoxResult result = AduMessageBox.ShowYesNoCancel(
                "Bạn có tiếp tục hỗ trợ Aduskin không?",
                "Chào mừng bạn đến với Aduskin!",
                "mong",
                "Không ước",
                "Không sử dụng",
                MessageBoxImage.Exclamation);

               NoticeManager.NotificationShow.AddNotification(new NotificationModel()
               {
                  Title = "Kết quả trả lại",
                  Content = result.ToString()
               });
               break;
            default:
               break;
         }
      });
   }
}
