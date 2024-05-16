using LightGood.Data.Enum;
using LightGood.Models;
using LightGood.UserControls;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Data;

namespace LightGood.ViewModel
{
   public class PracticalCaseViewModel: ViewModelBase
   {
      public PracticalCaseViewModel()
      {
         #region thanh công cụ
         _AllTool = new List<ControlModel>()
         {
            //new ControlModel("Dịch giả Baidu", typeof(BaiduTranslate),DemoType.Tool),
            new ControlModel("Công cụ gỡ lỗi giao diện", typeof(HttpTool),DemoType.Tool,ControlState.InDev),
         };
         _SearchTool.Source = _AllTool;
         _SearchTool.View.Culture = new System.Globalization.CultureInfo("zh-CN");
         _SearchTool.View.Filter = (obj) => ((obj as ControlModel).Title + (obj as ControlModel).TitlePinyin).ToLower().Contains(SearchKey.ToLower());
         _SearchTool.View.SortDescriptions.Add(new SortDescription(nameof(ControlModel.Title), ListSortDirection.Ascending));
         #endregion

         #region Kiểm soát thực tế
         _AllControl = new List<ControlModel>()
         {
            new ControlModel("Menu Win10", typeof(SortGroup)),
            new ControlModel("tải lên hình ảnh", typeof(UploadPic)),
            new ControlModel("Kiểm soát video", typeof(VideoPlayer)),
            new ControlModel("Menu gấp", typeof(ExpanderMenu)),
            new ControlModel("Container điều hướng", typeof(NavigationPanel)),
            new ControlModel("Che phủ", typeof(CoverFlowDemo),DemoType.Demo,ControlState.New),
            new ControlModel("Mốc thời gian", typeof(TimeLine)),
            new ControlModel("mốc thời gian", typeof(TimeBarDemo),DemoType.Demo,ControlState.New),
            new ControlModel("Menu cây", typeof(TreeMenu)),
            new ControlModel("Bảng dữ liệu", typeof(DataGridDemo),DemoType.Demo),
            new ControlModel("Tab đa chức năng", typeof(MultiFunctionTabControl)),
            new ControlModel("Đúng -Plick menu", typeof(ContextMenuDemo),DemoType.Demo),
            new ControlModel("Khung bom phải", typeof(NoticeDemo)),
            new ControlModel("Hộp đựng chuyển tiếp", typeof(TransitioningContentControlDemo),DemoType.Demo),
            new ControlModel("Khung bom tin nhắn", typeof(MessageBoxDemo),DemoType.Demo,ControlState.New),
         };
         _SearchControl.Source= _AllControl;
         _SearchControl.View.Culture = new System.Globalization.CultureInfo("zh-CN");
         _SearchControl.View.Filter = (obj) => ((obj as ControlModel).Title+ (obj as ControlModel).TitlePinyin).ToLower().Contains(SearchKey.ToLower());
         _SearchControl.View.SortDescriptions.Add(new SortDescription(nameof(ControlModel.Title), ListSortDirection.Ascending));
         #endregion
      }

      private int _SelectedDemoType;
      /// <summary>
      /// Loại hiển thị danh sách hiện tại
      /// </summary>
      public int SelectedDemoType
      {
         get { return _SelectedDemoType; }
         set 
         {
            
            Set(ref _SelectedDemoType, value);
            if (value == 0)
               CurrentShowControl = _AllControl.First();
            else if (value == 1)
               CurrentShowTool = _AllTool.First();
            RaisePropertyChanged("IsShowCode");
            RaisePropertyChanged("SearchKey");
         }
      }

      #region Kiểm soát bản demo
      private IEnumerable<ControlModel> _AllControl;
      /// <summary>
      /// Tất cả các điều khiển
      /// </summary>
      public IEnumerable<ControlModel> AllControl
      {
         get { return _AllControl; }
         set { Set(ref _AllControl, value); }
      }

      private CollectionViewSource _SearchControl = new CollectionViewSource();
      /// <summary>
      /// Tất cả các điều khiển
      /// </summary>
      public CollectionViewSource SearchControl
      {
         get { return _SearchControl; }
         set
         {
            Set(ref _SearchControl, value);
         }
      }
      #endregion

      #region dụng cụ
      private IEnumerable<ControlModel> _AllTool;
      /// <summary>
      /// Tất cả các điều khiển
      /// </summary>
      public IEnumerable<ControlModel> AllTool
      {
         get { return _AllTool; }
         set { Set(ref _AllTool, value); }
      }

      private CollectionViewSource _SearchTool = new CollectionViewSource();
      /// <summary>
      /// Tất cả các điều khiển
      /// </summary>
      public CollectionViewSource SearchTool
      {
         get { return _SearchTool; }
         set
         {
            Set(ref _SearchTool, value);
         }
      }
      #endregion

      /// <summary>
      /// Hiển thị thanh trường hợp mã
      /// </summary>
      public bool IsShowCode => CurrentShowControl?.Type == DemoType.Demo && SelectedDemoType == 0;

      /// <summary>
      /// Chiều cao hiển thị trường hợp mã
      /// </summary>
      public double ShowCodeHeight
      {
         get 
         {
            if (CurrentShowControl?.Type == DemoType.Demo && SelectedDemoType == 0)
               return 40;
            else
               return 0;
         }
      }

      private string _CurrentShowCode;
      /// <summary>
      /// Mã trường hợp
      /// </summary>
      public string CurrentShowCode
      {
         get { return _CurrentShowCode; }
         set { Set(ref _CurrentShowCode, value); }
      }

      private ControlModel _CurrentShowControl;
      /// <summary>
      /// Điều khiển hiển thị hiện tại
      /// </summary>
      public ControlModel CurrentShowControl
      {
         get { return _CurrentShowControl; }
         set {
            Set(ref _CurrentShowControl, value);
            RaisePropertyChanged("Content");
            RaisePropertyChanged("Title");
            RaisePropertyChanged("IsShowCode");
            RaisePropertyChanged("ShowCodeHeight");
         }
      }

      private ControlModel _CurrentShowTool;
      /// <summary>
      /// Công cụ hiển thị hiện tại
      /// </summary>
      public ControlModel CurrentShowTool
      {
         get { return _CurrentShowTool; }
         set
         {
            Set(ref _CurrentShowTool, value);
            RaisePropertyChanged("Content");
            RaisePropertyChanged("Title");
            RaisePropertyChanged("IsShowCode");
            RaisePropertyChanged("ShowCodeHeight");
         }
      }

      private int _ShowCodeTypeIndex = 0;
      /// <summary>
      /// Loại mã hiển thị
      /// </summary>
      public int ShowCodeTypeIndex
      {
         get { return _ShowCodeTypeIndex; }
         set {
            Set(ref _ShowCodeTypeIndex, value);
            if (value == 0)
               CurrentShowCode = CurrentShowControl.XAML;
            else
               CurrentShowCode = CurrentShowControl.Code;
         }
      }

      /// <summary>
      /// Hiển thị điều khiển
      /// </summary>
      private UserControl _content;
      public UserControl Content
      {
         get {

            if (SelectedDemoType == 0)
            {
               if (CurrentShowControl == null)
                  return null;
               return (UserControl)Activator.CreateInstance(CurrentShowControl.Content);
            }
            else
            {
               if (CurrentShowControl == null)
                  return null;
               return (UserControl)Activator.CreateInstance(CurrentShowTool.Content);
            }
               
         }
         set { 
            Set(ref _content, value);
         }
      }
      /// <summary>
      /// tiêu đề
      /// </summary>
      private string _Title;
      public string Title
      {
         get {
            
            if (SelectedDemoType == 0)
            {
               if (CurrentShowControl == null)
                  return null;
               return CurrentShowControl.Title;
            }
            else
            {
               if (CurrentShowTool == null)
                  return null;
               return CurrentShowTool.Title;
            }
         }
         set { Set(ref _Title, value); }
      }
      /// <summary>
      /// Tìm kiếm từ khóa
      /// </summary>
      private string _SearchKey="";
      public string SearchKey
      {
         get {
            return _SearchKey; 
         }
         set
         {
            Set(ref _SearchKey, value);
            if (SelectedDemoType == 0)
               if (_SearchControl != null)
                  _SearchControl.View.Refresh();
            else if (SelectedDemoType == 1)
               if (_SearchTool != null)
                  _SearchTool.View.Refresh();
         }
      }
   }
}
