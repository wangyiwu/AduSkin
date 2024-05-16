using AduSkin.Utility.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
using System.Windows.Threading;

namespace LightGood.UserControls
{
   /// <summary>
   /// CommonControlCase.xaml Logic tương tác
   /// </summary>
   public partial class CommonControlCase : UserControl
   {
      public CommonControlCase()
      {
         InitializeComponent();

         color1.ColorChange += delegate
         {
            // Không liên kết màu thông qua XAML, bạn có thể nhận được thông báo
            BorderBrush = color1.CurrentColor.OpaqueSolidColorBrush;
         };

         ts.IsChecked = true;
         #region Kiểm soát ngày
         Calendar1.SelectedDate = Date3.SelectedDateTime = Date2.SelectedDateTime = Date1.SelectedDateTime = DateTime.Now;
         Date4.SelectedDateStart = Date5.SelectedDateStart = Date6.SelectedDateStart = DateTime.Now;
         Date4.SelectedDateEnd = Date5.SelectedDateEnd = Date6.SelectedDateEnd = DateTime.Now.AddDays(10);
         #endregion

         #region Hộp văn bản phong phú
         rt1.Clear();

         rt1.AddLine("Chế độ đọc");
         rt1.AddLine();
         rt1.AddLine("Thêm nội dung bình thường");
         rt1.AddLine("Thêm nội dung bình thường để nhấp vào", delegate { MessageBox.Show("Bạn đã nhấp vào tôi!"); });
         rt1.AddLine("Thêm nội dung màu tùy chỉnh", new RgbaColor(255, 0, 0, 255));
         rt1.AddLine("Thêm nội dung màu tùy chỉnh, nhấp vào", new RgbaColor(255, 0, 0, 255), delegate { MessageBox.Show("Bạn đã nhấp vào tôi!"); });

         rt3.Clear();

         rt3.AddLine("Nội dung Kiểm tra bổ sung (không thay đổi dòng)");
         rt3.AddLine("http://www.baidu.com", "http://www.baidu.com");
         rt3.AddLine("Khoảng cách giữa là thêm(\"  \");Phương pháp thêm hai không gian");
         rt3.AddLine();

         rt3.AddLine("Nội dung bình thường bổ sung");
         rt3.AddLine();
         rt3.Add("Bình thường 1");
         rt3.Add("   ");
         rt3.Add("Bình thường 2");
         rt3.Add("   ");
         rt3.Add("Bình thường 3");
         rt3.AddLine();

         rt3.AddLine("Bạn có thể nhấp vào nội dung bình thường");
         rt3.AddLine();
         rt3.Add("Bình thường 1", delegate { MessageBox.Show("Bạn đã nhấp vào tôi!"); });
         rt3.Add("   ");
         rt3.Add("Bình thường 2", delegate { MessageBox.Show("Bạn đã nhấp vào tôi!"); });
         rt3.Add("   ");
         rt3.Add("Bình thường 3", delegate { MessageBox.Show("Bạn đã nhấp vào tôi!"); });
         rt3.AddLine();

         rt3.AddLine("Thêm nội dung màu tùy chỉnh");
         rt3.AddLine();
         rt3.Add("Màu 1", new RgbaColor(255, 0, 0, 255));
         rt3.Add("   ");
         rt3.Add("Màu 2", new RgbaColor(0, 255, 0, 255));
         rt3.Add("   ");
         rt3.Add("Màu 3", new RgbaColor(0, 0, 255, 255));
         rt3.AddLine();

         rt3.AddLine("Thêm nội dung màu tùy chỉnh để nhấp vào");
         rt3.AddLine();
         rt3.Add("Màu 1", new RgbaColor(255, 0, 0, 255), delegate { MessageBox.Show("Bạn đã nhấp vào tôi!"); });
         rt3.Add("   ");
         rt3.Add("Màu 2", new RgbaColor(0, 255, 0, 255), delegate { MessageBox.Show("Bạn đã nhấp vào tôi!"); });
         rt3.Add("   ");
         rt3.Add("Màu 3", new RgbaColor(0, 0, 255, 255), delegate { MessageBox.Show("Bạn đã nhấp vào tôi!"); });
         rt3.AddLine();
         #endregion

         #region Thả cái hộp xuống
         site.ItemsSource = new List<string>() { "Thượng Hải", "Bắc Kinh", "Thành Đô" };
         size.ItemsSource = new List<string>() { "1080*1920", "768*1366", "760*1024" };
         subject.ItemsSource = new List<string>() { "Trung Quốc", "Toán học", "Tiếng Anh" };
         #endregion

         #region thanh tiến trình
         DispatcherTimer timer = new DispatcherTimer();
         timer.Tick += delegate
         {
            pb1.Value = pb1.Value + 1 > pb1.Maximum ? 0 : pb1.Value + 1;
            pb2.Value = pb2.Value + 1 > pb2.Maximum ? 0 : pb2.Value + 1;
            pb2.Title = pb2.Hint;
            pb2.Hint = null;
         };
         timer.Interval = new TimeSpan(0, 0, 0, 0, 20);
         timer.Start();
         #endregion
      }

      private void AduUpload_Click(object sender, RoutedEventArgs e)
      {

        }
    }
}
