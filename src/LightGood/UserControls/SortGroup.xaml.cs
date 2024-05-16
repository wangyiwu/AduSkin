using GalaSoft.MvvmLight.Command;
using LightGood.Models;
using LightGood.ViewModel;
using System.Windows.Controls;
using System.Windows.Input;
using AduSkin;

namespace LightGood.UserControls
{
   public partial class SortGroup : UserControl
   {
      public SortGroup()
      {
         InitializeComponent();
      }

      public ICommand ToGroup => new RelayCommand<ChatUserModel>((e) =>
      {
         SortGroupViewModel vm= this.DataContext as SortGroupViewModel;
         vm.IsOpenSortList = false;
         ListBoxContact.UpdateLayout();
         ListBoxContact.AnimateScrollIntoView(e);
      });
   }
}
