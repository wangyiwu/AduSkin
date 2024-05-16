using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace LightGood.UserControls
{
   public partial class CoverFlowDemo : UserControl
   {
      public CoverFlowDemo()
      {
         InitializeComponent();
         
         #region Vòng xoay
         ObservableCollection<Models.Carousel> list = new ObservableCollection<Models.Carousel>();
         for (int i = 0; i < 5; i++)
         {
            list.Add(new Models.Carousel()
            {
               imgpath = "../Resources/aduskin.png",
               name = "AduSkin",
               info = "Theo đuổi sự hoàn hảo cuối cùng, Yongzhen"
            });
         }
         this.CoverFlowMain.ItemsSource = list;
         CoverFlowMain.JumpTo(2);
         #endregion
      }
   }
}
