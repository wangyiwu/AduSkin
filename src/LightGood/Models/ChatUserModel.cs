using AduSkin.Controls;
using GalaSoft.MvvmLight;

namespace LightGood.Models
{
   public class ChatUserModel:ViewModelBase
   {
      public string SortID { get; set; }

      public int Id { get; set; }

      public string Header { get; set; } = "pack://application:,,,/Resources/Img/Header/avt1.png";

      public string UserName { get; set; } = "Chào mừng đến với AduChat";

      public string Describe { get; set; } = "Theo đuổi sự tối thượng và luôn đạt tới sự hoàn hảo";

      public ContactType ContactType { get; set; } = ContactType.Single;

      private bool m_IsChecked;
      public bool IsChecked 
      {
         get
         {
            return m_IsChecked;
         }
         set
         {
            m_IsChecked = value;
            RaisePropertyChanged("IsChecked");
         }
      }
   }
}
