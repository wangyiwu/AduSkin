using AduSkin.Controls;
using AduSkin.Controls.Metro;
using LightGood.Models;
using LightGood.UserControls;
using LightGood.ViewModel;
using LightGood.Views;
using AduSkin.Utility.Media;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace LightGood
{
   public partial class MainWindow : MetroWindow
   {
      public MainWindow()
      {
         InitializeComponent();
         this.Closed += delegate { Application.Current.Shutdown(); };
      }
   }
}