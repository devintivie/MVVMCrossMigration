using MvvmCross.Platforms.Wpf.Views;
using MvvmCross.ViewModels;
using MVVMCrossMigration.Core.ViewModels;
using System;
using System.Collections.Generic;
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

namespace MVVMCrossMigration.DesktopApp.Views
{
    //[MvxContentPresentation]
    /// <summary>
    /// Interaction logic for RootView.xaml
    /// </summary>
    public partial class RootView : MvxWpfView// : UserControl
    {
        public RootView()
        {
            InitializeComponent();
        }
    }
}
