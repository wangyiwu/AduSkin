using LightGood.Models;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace LightGood.UserControls
{
   /// <summary>
   /// TreeMenu.xaml 的交互逻辑
   /// </summary>
   public partial class TreeMenu : UserControl
   {
      public TreeMenu()
      {
         InitializeComponent();

         #region TreeView
         ObservableCollection<CompanyModel> TreeList = new ObservableCollection<CompanyModel>()
         {
                new CompanyModel()
                {
                    IsGrouping=true,
                    Name="công ty(3/3)",
                    Children=new ObservableCollection<CompanyModel>()
                    {
                        new CompanyModel(){
                            IsGrouping=true,
                            Name="phòng(2/3)",
                            Children=new ObservableCollection<CompanyModel>()
                            {
                                new CompanyModel(){
                                    IsGrouping=false,
                                    SurName="A",
                                    Name="AduSkin",
                                    Info="Theo đuổi sự cực đoan, để trở nên hoàn hảo,追求极致，臻于完美,追求极致，臻于完美！",
                                    State="在线"
                                },
                                new CompanyModel(){
                                    IsGrouping=false,
                                    SurName="A",
                                    Name="AduSkin",
                                    Info="Theo đuổi cực đoan, hãy hoàn hảo!",
                                    State="Trực tuyến"
                                },
                                new CompanyModel(){
                                    IsGrouping=false,
                                    SurName="A",
                                    Name="AduSkin",
                                    Info="Theo đuổi cực đoan, hãy hoàn hảo!",
                                    State="Đường kẻ"
                                }
                            }
                        },
                         new CompanyModel(){
                            IsGrouping=true,
                            Name="phòng(1/1)",
                            Children=new ObservableCollection<CompanyModel>()
                            {
                                new CompanyModel(){
                                    IsGrouping=false,
                                    SurName="A",
                                    Name="AduSkin",
                                    Info="Theo đuổi cực đoan, hãy hoàn hảo!",
                                    State="Trực tuyến"
                                }
                            }
                        }, new CompanyModel(){
                            IsGrouping=true,
                            Name="phòng(1/1)",
                            Children=new ObservableCollection<CompanyModel>()
                            {
                                new CompanyModel(){
                                    IsGrouping=false,
                                    SurName="A",
                                    Name="AduSkin",
                                    Info="Theo đuổi cực đoan, hãy hoàn hảo!",
                                    State="Trực tuyến"
                                }
                            }
                        }
                    }
                }

            };
         TreeViewCompany.ItemsSource = TreeList;
         #endregion
      }
   }
}
