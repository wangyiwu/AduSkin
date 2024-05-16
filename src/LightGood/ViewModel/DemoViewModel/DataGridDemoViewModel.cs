using AduSkin.Controls.Data;
using LightGood.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightGood.ViewModel
{
   public class DataGridDemoViewModel:ViewModelBase
   {
      public DataGridDemoViewModel()
      {
         TotalContactList = new List<ChatUserModel>();
         ChatUserModel group = new ChatUserModel();
         group.UserName = "Nhóm phát triển Flutter";
         group.Header = "pack://application:,,,/Resources/Img/Header/avt1.png";
         group.Describe = "Tìm giao diện người dùng phù hợp với bạn";
         TotalContactList.Add(group);

         ChatUserModel Group1 = new ChatUserModel();
         Group1.UserName = "Nhóm phát triển AduSkin";
         Group1.Header = "pack://application:,,,/Resources/Img/Header/avt2.png";
         Group1.Describe = "Diễn đàn nhà phát triển";
         TotalContactList.Add(Group1);

         ChatUserModel item = new ChatUserModel();
         item.UserName = "AduSkin";
         item.Header = "pack://application:,,,/Resources/Img/Header/avt3.png";
         item.Describe = "Theo đuổi sự tối thượng và luôn đạt tới sự hoàn hảo";
         TotalContactList.Add(item);

         ChatUserModel item1 = new ChatUserModel();
         item1.UserName = "Thiên Bạch Đô";
         item1.Header = "pack://application:,,,/Resources/Img/Header/avt4.png";
         item1.Describe = "Theo đuổi sự tối thượng và luôn đạt tới sự hoàn hảo";
         TotalContactList.Add(item1);

         ChatUserModel item2 = new ChatUserModel();
         item2.UserName = "Một mình đi ngàn dặm";
         item2.Header = "pack://application:,,,/Resources/Img/Header/avt2.png";
         item2.Describe = "Theo đuổi sự tối thượng và luôn đạt tới sự hoàn hảo";
         TotalContactList.Add(item2);

         ChatUserModel item3 = new ChatUserModel();
         item3.UserName = "một người";
         item3.Header = "pack://application:,,,/Resources/Img/Header/avt2.png";
         item3.Describe = "Theo đuổi sự tối thượng và luôn đạt tới sự hoàn hảo";
         TotalContactList.Add(item3);

         ChatUserModel item4 = new ChatUserModel();
         item4.UserName = "AduMusic";
         item4.Header = "pack://application:,,,/Resources/Img/Header/avt2.png";
         item4.Describe = "Theo đuổi sự tối thượng và luôn đạt tới sự hoàn hảo";
         TotalContactList.Add(item4);

         ChatUserModel item6 = new ChatUserModel();
         item6.UserName = "Quá khứ như cơn gió";
         item6.Header = "pack://application:,,,/Resources/Img/Header/avt2.png";
         item6.Describe = "Xinh đẹp";
         TotalContactList.Add(item6);

         var index = 0;
         for (int i = 0; i < 100; i++)
         {
            ChatUserModel item7 = new ChatUserModel();
            item7.UserName = "Xinh đẹp";
            item7.Header = "pack://application:,,,/Resources/Img/Header/avt"+ (index+=1) + ".png";
            item7.Describe = "Không cần nhiều";
            TotalContactList.Add(item7);
            if (index >= 6)
            {
               index = 0;
            }
         }
         ContactList = new ObservableCollection<ChatUserModel>(TotalContactList.Skip((1 - 1) * 10).Take(10).ToList());
      }

      public List<ChatUserModel> TotalContactList;

      private ObservableCollection<ChatUserModel> contactList;
      /// <summary>
      ///danh sách liên lạc
      /// </summary>
      public ObservableCollection<ChatUserModel> ContactList
      {
         get { return contactList; }
         set { Set(ref contactList, value); }
      }

      private bool _IsAllChecked;
      /// <summary>
      /// chọn tất cả
      /// </summary>
      public bool IsAllChecked
      {
         get { return _IsAllChecked; }
         set
         {
            Set(ref _IsAllChecked, value);
            foreach (var item in ContactList)
               item.IsChecked = IsAllChecked;
         }
      }

      /// <summary>
      ///     Lệnh thay đổi số trang
      /// </summary>
      public RelayCommand<FunctionEventArgs<int>> PageUpdatedCmd =>
          new Lazy<RelayCommand<FunctionEventArgs<int>>>(() =>
              new RelayCommand<FunctionEventArgs<int>>(PageUpdated)).Value;

      /// <summary>
      ///     Số trang đã thay đổi
      /// </summary>
      private void PageUpdated(FunctionEventArgs<int> info)
      {
         ContactList = new ObservableCollection<ChatUserModel>(TotalContactList.Skip((info.Info - 1) * 10).Take(10).ToList());
      }
   }
}
