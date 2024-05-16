using AduSkin.Controls;
using LightGood.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace LightGood.ViewModel
{
   public class SortGroupViewModel:ViewModelBase
   {
      public SortGroupViewModel()
      {
         var tempContactList = new List<ChatUserModel>();
         ChatUserModel group = new ChatUserModel();
         group.ContactType = ContactType.Group;
         group.UserName = "Nhóm phát triển rung";
         group.Header = "pack://application:,,,/Resources/Img/Header/avt1.png";
         group.Describe = "Tìm UI phù hợp với bạn";
         tempContactList.Add(group);

         ChatUserModel Group1 = new ChatUserModel();
         Group1.ContactType = ContactType.Group;
         Group1.UserName = "Nhóm phát triển Aduskin";
         Group1.Header = "pack://application:,,,/Resources/Img/Header/avt1.png";
         Group1.Describe = "Diễn đàn phát triển";
         tempContactList.Add(Group1);

         ChatUserModel item = new ChatUserModel();
         item.UserName = "AduSkin";
         item.Header = "pack://application:,,,/Resources/Img/Header/avt1.png";
         item.Describe = "Theo đuổi sự hoàn hảo cuối cùng, Yongzhen";
         tempContactList.Add(item);

         ChatUserModel item1 = new ChatUserModel();
         item1.UserName = "Hàng ngàn Baidu";
         item1.Header = "pack://application:,,,/Resources/Img/Header/avt1.png";
         item1.Describe = "Theo đuổi sự hoàn hảo cuối cùng, Yongzhen";
         tempContactList.Add(item1);

         ChatUserModel item2 = new ChatUserModel();
         item2.UserName = "Wanli";
         item2.Header = "pack://application:,,,/Resources/Img/Header/avt1.png";
         item2.Describe = "Theo đuổi sự hoàn hảo cuối cùng, Yongzhen";
         tempContactList.Add(item2);

         ChatUserModel item3 = new ChatUserModel();
         item3.UserName = "một người";
         item3.Header = "pack://application:,,,/Resources/Img/Header/avt1.png";
         item3.Describe = "Theo đuổi sự hoàn hảo cuối cùng, Yongzhen";
         tempContactList.Add(item3);

         ChatUserModel item4 = new ChatUserModel();
         item4.UserName = "AduMusic";
         item4.Header = "pack://application:,,,/Resources/Img/Header/avt1.png";
         item4.Describe = "Theo đuổi sự hoàn hảo cuối cùng, Yongzhen";
         tempContactList.Add(item4);

         ChatUserModel item6 = new ChatUserModel();
         item6.UserName = "Quá khứ giống như một cơn gió";
         item6.Header = "pack://application:,,,/Resources/Img/Header/avt1.png";
         item6.Describe = "Mei Zizi";
         tempContactList.Add(item6);

         ChatUserModel item7 = new ChatUserModel();
         item7.UserName = "Mei Zizi";
         item7.Header = "pack://application:,,,/Resources/Img/Header/avt1.png";
         item7.Describe = "Không cần quá nhiều";
         tempContactList.Add(item7);

         contactList = Sort(tempContactList);
      }

      /// <summary>
      /// Loại
      /// </summary>
      /// <param name="Temps"></param>
      /// <returns></returns>
      public List<ChatUserModel> Sort(List<ChatUserModel> Temps)
      {
         return Temps;
      }

      private List<ChatUserModel> contactList;
      /// <summary>
      /// Danh sách liên hệ
      /// </summary>
      public ObservableCollection<ChatUserModel> ContactList
      {
         get
         {
            return new ObservableCollection<ChatUserModel>(contactList);
         }
      }
      /// <summary>
      /// Danh sách số sê -ri
      /// </summary>
      public ObservableCollection<ChatUserModel> SortID
      {
         get
         {
            return new ObservableCollection<ChatUserModel>(contactList.Where(a => a.ContactType == ContactType.SerialNumber));
         }
      }

      private ChatUserModel _CurrentChatUserModel;
      /// <summary>
      /// Số người dùng/nhóm/số tiếp theo được chọn
      /// </summary>
      public ChatUserModel CurrentChatUserModel
      {
         get { return _CurrentChatUserModel; }
         set
         {
            if (value.ContactType == ContactType.SerialNumber)
            {
               IsOpenSortList = true;
            }
            Set(ref _CurrentChatUserModel, value);
         }
      }

      private bool _IsOpenSortList = false;
      /// <summary>
      /// Hiển thị số sê -ri
      /// </summary>
      public bool IsOpenSortList
      {
         get { return _IsOpenSortList; }
         set { Set(ref _IsOpenSortList, value); }
      }
   }
}
