using AduSkin.Controls.Metro;
using LightGood.Models;
using System.Collections.ObjectModel;

namespace LightGood.Views
{
   /// <summary>
   /// AduSkinDemo.xaml Logic tương tác
   /// </summary>
   public partial class AduSkinDemo : AduWindow
   {
      public AduSkinDemo()
      {
         InitializeComponent();

         DemoModel item5 = new DemoModel()
         {
            ID = 1,
            Name = " “ AduChat ” UI trò chuyện tối giản ",
            Cover = "http://r.photo.store.qq.com/psb?/V12WtbKq3d7FCg/o0OzX8R8r*a1G*b3VMqHXnuel.eKFqw2BTUoO7yn03U!/r/dE8BAAAAAAAA",
            Link = "",
            Likes = "99+",
            Shares = "99+",
            BlogDate = "November 3, 2019",
            Describe = "Dựa trên aduskin và siêng năng！",
         };
         DemoList.Add(item5);
         DemoModel item4 = new DemoModel()
         {
            ID = 1,
            Name = "“Maker Wallpaper” Hãy xem hình nền máy tính để bàn này được tạo cẩn thận cho bạn!",
            Cover = "https://qqadapt.qpic.cn/txdocpic/0/784b3a8183c2b0a49715fcaec57825ab/0?w=1353&h=864",
            Link = "",
            Likes = "99+",
            Shares = "99+",
            BlogDate = "November 1, 2019",
            Describe = "At Maker Wallpaper we’re passionate about breaking boundaries and setting a new bar for player expectations. We believe that all gamers deserve to share beautiful, immersive experiences regardless of which platform they play on.",
         };
         DemoList.Add(item4);
         DemoModel item3 = new DemoModel()
         {
            ID = 1,
            Name = "Shadow Tâm lý máy khách FM PC, nhiều tính năng mới đang chờ bạn khám phá!",
            Cover = "http://m.qpic.cn/psc?/V12WtbKq3d7FCg/45NBuzDIW489QBoVep5mcd*RuyMAAEPwPETX7aEl05kVsaPx4L9m2bWiIMCWbehhLJZXnN1BSqihQPiaMhMA*ZuiyYRfFCxKSD2.oekIFwI!/b&bo=CgX0AgoF9AIDORw!&rf=viewer_4",
            Link = "https://github.com/aduskin/Shadow-FM",
            Likes = "99+",
            Shares = "99+",
            BlogDate = "September 6, 2019",
            Describe = "Shadow 2.0 launched today with a bunch of fun new features. Most importantly - we’re now live on Steam so whether you and your friends play on a PC, Mac, iOS or Android, you can all Listen FM together.  Download link here: ",
         };
         DemoList.Add(item3);
         DemoModel item2 = new DemoModel()
         {
            ID = 1,
            Name = " “Super Evil” Một máy nghe nhạc độc đáo!",
            Cover = "http://r.photo.store.qq.com/psb?/V12WtbKq3d7FCg/SOxjPTd2KC2KWCr0oQVNkAx1nQlBs4KLpcUiVJZoeXs!/r/dMMAAAAAAAAA",
            Link = "",
            Likes = "99+",
            Shares = "99+",
            BlogDate = "August 1, 2019",
            Describe = "At Super Evil we’re passionate about breaking boundaries and setting a new bar for player expectations. We believe that all gamers deserve to share beautiful, immersive experiences regardless of which platform they play on.",
         };
         DemoList.Add(item2);
         DemoModel item1 = new DemoModel()
         {
            ID = 1,
            Name = "“AduMusic” QQ Music For WPF , Tôi không mong đợi bạn sẽ là một người chơi như vậy!",
            Cover = "http://b301.photo.store.qq.com/psb?/V12WtbKq4PLaCF/XRG14p7ndKsURVgQHY1NfIeYYwEaQ3euaDhKuStSpTU!/b/dC0BAAAAAAAA&bo=QgfKA0IHygMDCSw!&rf=viewer_4",
            Link = "https://github.com/aduskin/AduMusic",
            Likes = "99+",
            Shares = "99+",
            BlogDate = "December 6, 2018",
            Describe = "At Super Evil we’re passionate about breaking boundaries and setting a new bar for player expectations. We believe that all gamers deserve to share beautiful, immersive experiences regardless of which platform they play on.",
         };
         DemoList.Add(item1);
         DemoModel item = new DemoModel()
         {
            ID = 1,
            Name = "“HttpTool” Http Yêu cầu các công cụ để tạo điều kiện gỡ lỗi giao diện!",
            Cover = "http://r.photo.store.qq.com/psb?/V12WtbKq3d7FCg/pybEVyta4jzLubeIXR*cEzsBi0uQEhr14T1xMWjFHVM!/r/dIMAAAAAAAAA",
            Link = "https://github.com/aduskin/HttpTool",
            Likes = "99+",
            Shares = "99+",
            BlogDate = "May 6, 2019",
            Describe = "‘HttpTool’Các tham số hỗ trợ, tiêu đề yêu cầu, tải lên tệp, phù hợp để gỡ lỗi giao diện！",
         };

         DemoList.Add(item);

         Demos.ItemsSource = DemoList;
         Carousels.ItemsSource = DemoList;
      }
      public ObservableCollection<DemoModel> DemoList { get; set; } = new ObservableCollection<DemoModel>();
   }
}
