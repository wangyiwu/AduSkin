using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AduSkin.Controls.Metro;
using Microsoft.Win32;

namespace LightGood.UserControls
{
   public partial class UploadPic : UserControl
   {
      public UploadPic()
      {
         InitializeComponent();
         this.DataContext = Capture;
      }
      public ObservableCollection<string> Capture = new ObservableCollection<string>();

      private void Delete_Click(object sender, RoutedEventArgs e)
      {
         Capture.Remove(((AduPathIconButton)sender).DataContext.ToString());
      }

      private void AduPathIconButton_Click(object sender, RoutedEventArgs e)
      {
         OpenFileDialog FileDialog = new OpenFileDialog();
         FileDialog.Multiselect = true;
         FileDialog.Filter = "hình ảnh|*.jpg;*.png;*.bmp;*.gif";
         if (FileDialog.ShowDialog() == true)
         {
            foreach (var item in FileDialog.FileNames)
            {
               if (!Capture.Contains(item))
               {
                  Capture.Add(item);
               }
               
            }
         }
      }
   }
}
