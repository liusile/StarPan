using System;
using System.Collections.Generic;
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

namespace StarPan
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

           
        }

        private void DockPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
            if (e.ClickCount==2)
            {
                SizeChange_MouseDown(null, null);
            }
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();  
        }

        private void SizeChange_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }
            else
            {
                this.WindowState = WindowState.Maximized;
            }
        }

        private void minFrm_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void FunctionBox_Click(object sender, RoutedEventArgs e)
        {
            FrameContent.Source = new Uri("SubPage/FunctionBoxPage.xaml", UriKind.Relative);
        }

        /// <summary>
        /// 我的网盘
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyPan_Click(object sender, RoutedEventArgs e)
        {
            FrameContent.Source = new Uri("SubPage/MyPanPage.xaml", UriKind.Relative);
        }
        
        private void FriendSharing_Click(object sender, RoutedEventArgs e)
        {
            FrameContent.Source = new Uri("SubPage/SharePage.xaml", UriKind.Relative);
        }

        private void DoloadList_Click(object sender, RoutedEventArgs e)
        {
            FrameContent.Source = new Uri("SubPage/TransferPage.xaml", UriKind.Relative);
        }
    }
}
