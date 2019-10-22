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

namespace StarPan.MyUserControl
{
    /// <summary>
    /// ImageButton.xaml 的交互逻辑
    /// </summary>
    public partial class ImageButton : UserControl
    {


        public string ImagSource
        {
            get { return (string)GetValue(ImagSourceProperty); }
            set { SetValue(ImagSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ImagSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImagSourceProperty =
            DependencyProperty.Register("ImagSource", typeof(string), typeof(ImageButton));



        public string ImageSourceActive
        {
            get { return (string)GetValue(ImageSourceActiveProperty); }
            set { SetValue(ImageSourceActiveProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ImageSourceActive.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageSourceActiveProperty =
            DependencyProperty.Register("ImageSourceActive", typeof(string), typeof(ImageButton));


        /// <summary>
        /// 定义依赖属性
        /// </summary>
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(ImageButton));

        /// <summary>
        /// 暴露内部控件属性
        /// </summary>
        public bool? IsChecked
        {
            get {
                return this.rdoBtn.IsChecked;
            } 
            set {
                this.rdoBtn.IsChecked = value;
            }
        }

        public ImageButton()
        {
            InitializeComponent();

            this.DataContext = this;
        }
    }
}
