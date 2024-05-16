using LightGood.Data.Enum;
using LightGood.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace LightGood.ViewModel
{
   public class AduSkinSupportViewModel : ViewModelBase
   {
      public AduSkinSupportViewModel()
      {
         AllSupports.Add(new SupportUser("Cư dân mạng không muốn tiết lộ tên của họ", "tencent://message/?uin=870856195&Site=&Menu=yes", "http://q.qlogo.cn/headimg_dl?bs=qq&dst_uin=870856195&spec=100","",new string[] { SupportType.Money.ToString()+": 100 nhân dân tệ" }));
         AllSupports.Add(new SupportUser("Sói ở cuối sa mạc dotnet9.com", "tencent://message/?uin=632871194&Site=&Menu=yes", "http://q.qlogo.cn/headimg_dl?bs=qq&dst_uin=632871194&spec=100", "", new string[] { SupportType.Skill.ToString(), SupportType.Extension.ToString() }));
         AllSupports.Add(new SupportUser("Đi xuyên qua", "tencent://message/?uin=2453966523&Site=&Menu=yes", "http://q.qlogo.cn/headimg_dl?bs=qq&dst_uin=2453966523&spec=100", "", new string[] { SupportType.Skill.ToString(), SupportType.Extension.ToString() }));
         AllSupports.Add(new SupportUser("Tom", "tencent://message/?uin=17379620&Site=&Menu=yes", "http://q.qlogo.cn/headimg_dl?bs=qq&dst_uin=17379620&spec=100", "", new string[] { SupportType.Skill.ToString(), SupportType.Extension.ToString(),SupportType.Money.ToString() + ": 350 nhân dân tệ" }));
         AllSupports.Add(new SupportUser("KING", "tencent://message/?uin=1061973727&Site=&Menu=yes", "http://q.qlogo.cn/headimg_dl?bs=qq&dst_uin=1061973727&spec=100", "", new string[] { SupportType.Skill.ToString()}));
         AllSupports.Add(new SupportUser("CJ", "tencent://message/?uin=836904362&Site=&Menu=yes", "http://q.qlogo.cn/headimg_dl?bs=qq&dst_uin=836904362&spec=100", "", new string[] { SupportType.Skill.ToString() }));
         AllSupports.Add(new SupportUser("FOX-Yu", "", "http://q.qlogo.cn/headimg_dl?bs=qq&dst_uin=435892115&spec=100", "", new string[] { SupportType.Money.ToString() + ": 88 Yuan" }));
         AllSupports.Add(new SupportUser("Cư dân mạng không muốn tiết lộ tên của họ", "", "http://q.qlogo.cn/headimg_dl?bs=qq&dst_uin=2603473237&spec=100", "", new string[] { SupportType.Money.ToString() + ": 300 nhân dân tệ" }));
         AllSupports.Add(new SupportUser("năm đó", "", "http://q.qlogo.cn/headimg_dl?bs=qq&dst_uin=407564418&spec=100", "", new string[] { SupportType.Money.ToString() + ": 100 nhân dân tệ" }));
         AllSupports.Add(new SupportUser("Không nhuộm", "", "http://q.qlogo.cn/headimg_dl?bs=qq&dst_uin=906247584&spec=100", "", new string[] { SupportType.Money.ToString() + ": 50 RMB" }));
         AllSupports.Add(new SupportUser("MiFaFa", "", "http://q.qlogo.cn/headimg_dl?bs=qq&dst_uin=2447786794&spec=100", "", new string[] { SupportType.Money.ToString() + ": 66 Yuan" }));
         AllSupports.Add(new SupportUser("Sóng nhỏ", "", "http://q.qlogo.cn/headimg_dl?bs=qq&dst_uin=2398387230&spec=100", "", new string[] { SupportType.Money.ToString() + ": 100 nhân dân tệ" }));
      }
      private ObservableCollection<SupportUser> _AllSupports =new ObservableCollection<SupportUser>();
      /// <summary>
      /// nhà tài trợ
      /// </summary>
      public ObservableCollection<SupportUser> AllSupports
      {
         get { return _AllSupports; }
         set { Set(ref _AllSupports, value); }
      }

      /// <summary>
      /// Lệnh
      /// </summary>
      public ICommand OpenDemo => new RelayCommand<string>((e) =>
      {
         switch (e)
         {
            case "Reward":
               IsOpenReward = true;
               return;
            default:
               break;
         }
      });

      private bool _IsOpenReward;
      /// <summary>
      /// Thuộc tính.
      /// </summary>
      public bool IsOpenReward
      {
         get { return _IsOpenReward; }
         set { Set(ref _IsOpenReward, value); }
      }
   }
}
