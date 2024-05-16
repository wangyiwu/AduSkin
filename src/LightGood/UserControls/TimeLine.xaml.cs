using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LightGood.UserControls
{
   public partial class TimeLine : UserControl
   {
      public TimeLine()
      {
         InitializeComponent();

         #region mốc thời gian
         ObservableCollection<Tuple<int, string, string>> listTimeLine = new ObservableCollection<Tuple<int, string, string>>();
         for (int i = 0; i < 5; i++)
         {
            listTimeLine.Add(new Tuple<int, string, string>(i, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "Ha ha ha ha"));
         }
         AduTimeLine.ItemsSource = listTimeLine;
         #endregion
      }
   }
}
