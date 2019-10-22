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
    /// SharePage.xaml 的交互逻辑
    /// </summary>
    public partial class SharePage : Page
    {
        public SharePage()
        {
            InitializeComponent();
            huihua_PreviewMouseLeftButtonDown(null, null);
        }


        private void huihua_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            FrameContent.Source = new Uri("SharePage_HuiHua.xaml", UriKind.Relative);
        }

        private void friend_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            FrameContent.Source = new Uri("SharePage_Friend.xaml", UriKind.Relative);
        }

        private void group_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            FrameContent.Source = new Uri("SharePage_Group.xaml", UriKind.Relative);
        }
    }
}
