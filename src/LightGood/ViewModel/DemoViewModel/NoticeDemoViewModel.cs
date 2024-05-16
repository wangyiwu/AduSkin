using AduSkin.Controls;
using AduSkin.Controls.Metro;
using LightGood.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace LightGood.ViewModel
{
   public class NoticeDemoViewModel: ViewModelBase
   {
      #region Khung bom phải
      /// <summary>
      /// 命令Command
      /// </summary>
      public ICommand OpenMsg => new RelayCommand<string>((e) =>
      {
         switch (e)
         {
            case "Error":
               NoticeManager.NotificationShow.AddNotification(new NotificationModel()
               {
                  Title = "Đây là tiêu đề của thông báo lỗi",
                  Content = "Thông báo này sẽ không được đóng tự động, bạn cần nhấp vào nút Đóng",
                  NotificationType = EnumPromptType.Error
               });
               return;
            case "Success":
               NoticeManager.NotificationShow.AddNotification(new NotificationModel()
               {
                  Title = "Đây là tiêu đề của thông báo thành công",
                  Content = "Thông báo này sẽ không được đóng tự động.",
                  NotificationType = EnumPromptType.Success
               });
               return;
            case "Warm":
               NoticeManager.NotificationShow.AddNotification(new NotificationModel()
               {
                  Title = "Đây là tiêu đề của thông báo cảnh báo",
                  Content = "Thông báo này sẽ không được đóng tự động, bạn cần nhấp vào nút Đóng",
                  NotificationType = EnumPromptType.Warn
               });
               return;
            case "Info":
               NoticeManager.NotificationShow.AddNotification(new NotificationModel()
               {
                  Title = "Đây là tiêu đề của thông báo thông tin",
                  Content = "Thông báo này sẽ không được đóng tự động"
               });
               return;
            default:
               break;
         }
      });
      #endregion
   }
}
