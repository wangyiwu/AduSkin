using AduSkin.Controls.Metro;
using System;
using System.IO;
using System.Windows;
namespace LightGood.Views
{
   /// <summary>
   /// AduSkinDemo.xaml Logic tương tác
   /// </summary>
   public partial class AduVideoDemo : AduWindow
   {
      public AduVideoDemo()
      {
         InitializeComponent();
      }

      private void AduWindow_Closed(object sender, EventArgs e)
      {
         if(videoPlayer.IsPlaying)
            this.videoPlayer.Stop();
      }
   }
}
