using StarPan.Model;
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

namespace StarPan.SubPage
{
    /// <summary>
    /// TransferPage.xaml 的交互逻辑
    /// </summary>
    public partial class TransferPage : Page
    {
        public TransferPage()
        {
            InitializeComponent();
            List<Menus> menus = new List<Menus>()
            {
                new Menus{ Name="正在下载",Icon=@"..\image\download.png",IconActive=@"..\image\downloadActive.png"},
                new Menus{ Name="正在上传",Icon=@"..\image\upload.png",IconActive=@"..\image\uploadActive.png"},
                new Menus{ Name="传输完成",Icon=@"..\image\complete.png",IconActive=@"..\image\completeActive.png"}
            };
            nemuBox.ItemsSource = menus;
            nemuBox.SelectedIndex = 0;
        }

        private void nemuBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var index = nemuBox.SelectedIndex;
            if (index == 0)
            {
                FrameContent.Source = new Uri("TransferPage_download.xaml", UriKind.Relative);
            }
            else if (index == 1)
            {
                FrameContent.Source = new Uri("TransferPage_upload.xaml", UriKind.Relative);
            }
            else if (index == 2)
            {
                FrameContent.Source = new Uri("TransferPage_completeload.xaml", UriKind.Relative);
            }


        }
    }
}
