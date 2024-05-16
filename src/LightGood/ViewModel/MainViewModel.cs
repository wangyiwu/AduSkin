using LightGood.Data;
using LightGood.Models;
using LightGood.UserControls;
using LightGood.Views;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace LightGood.ViewModel
{
   public class MainViewModel : ViewModelBase
   {
      public MainViewModel()
      {

      }


      private int _SelectedModularIndex;
      /// <summary>
      /// Thuộc tính.
      /// </summary>
      public int SelectedModularIndex
      {
         get { return _SelectedModularIndex; }
         set { 
            Set(ref _SelectedModularIndex, value);
            if (value == 2)
               MainBackground = new SolidColorBrush(Color.FromRgb(28, 64, 139));
            else if (value == 3)
               MainBackground = new SolidColorBrush(Color.FromRgb(250, 251, 252));
            else
               MainBackground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
         }
      }

      private SolidColorBrush _MainBackground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
      /// <summary>
      /// Thuộc tính.
      /// </summary>
      public SolidColorBrush MainBackground
      {
         get { return _MainBackground; }
         set { Set(ref _MainBackground, value); }
      }
      /// <summary>
      /// Lệnh
      /// </summary>
      public ICommand OpenClick => new RelayCommand<string>((e) =>
      {
         switch (e)
         {
            case "AduSkinDemo":
               new AduSkinDemo().Show();
               return;
            default:
               break;
         }
      });

      /// <summary>
      /// Kiểm soát chung
      /// </summary>
      private UserControl _CommonControlCase = new CommonControlCase();
      public UserControl CommonControlCase
      {
         get { return _CommonControlCase; }
         set { Set(ref _CommonControlCase, value); }
      }
      /// <summary>
      /// Trường hợp thực tế
      /// </summary>
      private UserControl _PracticalCase = new PracticalCase();
      public UserControl PracticalCase
      {
         get { return _PracticalCase; }
         set { Set(ref _PracticalCase, value); }
      }
      /// <summary>
      /// Về
      /// </summary>
      private UserControl _AduSkinAbout = new AduSkinAbout();
      public UserControl AduSkinAbout
      {
         get { return _AduSkinAbout; }
         set { Set(ref _AduSkinAbout, value); }
      }
      /// <summary>
      /// Hỗ trợ và tài trợ
      /// </summary>
      private UserControl _AduSkinSupport = new AduSkinSupport();
      public UserControl AduSkinSupport
      {
         get { return _AduSkinSupport; }
         set { Set(ref _AduSkinSupport, value); }
      }
   }
}
