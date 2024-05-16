using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace LightGood.UserControls
{
   /// <summary>
   /// Carousel.xaml logic tương tác
   /// </summary>
   public partial class CarouselContainer : UserControl
   {
      public CarouselContainer()
      {
         InitializeComponent();

         #region carousel
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
         this.Carousels.ItemsSource = list;
         #endregion
      }
   }
}
