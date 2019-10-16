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
    /// MyPanPage.xaml 的交互逻辑
    /// </summary>
    public partial class MyPanPage : Page
    {
        public MyPanPage()
        {
            InitializeComponent();

            List<Menus> menus = new List<Menus>()
            {
                new Menus{ Name="最近使用",Icon=@"..\image\clock.png",IconActive=@"..\image\clockActive.png"},
                new Menus{ Name="全部文件",Icon=@"..\image\book.png",IconActive=@"..\image\bookActive.png"},
                new Menus{ Name="图片",Icon=""},
                new Menus{ Name="视频",Icon=""},
                new Menus{ Name="文档",Icon=""},
                new Menus{ Name="音乐",Icon=""},
                new Menus{ Name="种子",Icon=""},
                new Menus{ Name="其它",Icon=""},
                new Menus{ Name="隐藏空间",Icon=@"..\image\lock.png",IconActive=@"..\image\lockActive.png"},
                new Menus{ Name="我的分享",Icon=@"..\image\share.png",IconActive=@"..\image\shareActive.png"},
                new Menus{ Name="回收站",Icon=@"..\image\back.png",IconActive=@"..\image\backActive.png"}
            };
            nemuBox.ItemsSource = menus;

            List<FileInfo> files = new List<FileInfo>
            {
                new FileInfo{ FileName="软件", FileSize=0, FileType=FileType.Folder, UpdateTime=DateTime.Now},
                new FileInfo{ FileName="深入浅出PhotoShop.xlsx", FileSize=0, FileType=FileType.Excel, UpdateTime=DateTime.Now},
                new FileInfo{ FileName="深入浅出PhotoShop.doc", FileSize=0, FileType=FileType.Word, UpdateTime=DateTime.Now},
                new FileInfo{ FileName="深入浅出PhotoShop.pdf", FileSize=0, FileType=FileType.PDF, UpdateTime=DateTime.Now},
                new FileInfo{ FileName="深入浅出PhotoShop.rar", FileSize=0, FileType=FileType.CompressedPKG, UpdateTime=DateTime.Now},
                 new FileInfo{ FileName="软件", FileSize=0, FileType=FileType.Folder, UpdateTime=DateTime.Now},
                new FileInfo{ FileName="深入浅出PhotoShop.xlsx", FileSize=0, FileType=FileType.Excel, UpdateTime=DateTime.Now},
                new FileInfo{ FileName="深入浅出PhotoShop.doc", FileSize=0, FileType=FileType.Word, UpdateTime=DateTime.Now},
                new FileInfo{ FileName="深入浅出PhotoShop.pdf", FileSize=0, FileType=FileType.PDF, UpdateTime=DateTime.Now},
                new FileInfo{ FileName="深入浅出PhotoShop.rar", FileSize=0, FileType=FileType.CompressedPKG, UpdateTime=DateTime.Now},
                 new FileInfo{ FileName="软件", FileSize=0, FileType=FileType.Folder, UpdateTime=DateTime.Now},
                new FileInfo{ FileName="深入浅出PhotoShop.xlsx", FileSize=0, FileType=FileType.Excel, UpdateTime=DateTime.Now},
                new FileInfo{ FileName="深入浅出PhotoShop.doc", FileSize=0, FileType=FileType.Word, UpdateTime=DateTime.Now},
                new FileInfo{ FileName="深入浅出PhotoShop.pdf", FileSize=0, FileType=FileType.PDF, UpdateTime=DateTime.Now},
                new FileInfo{ FileName="深入浅出PhotoShop.rar", FileSize=0, FileType=FileType.CompressedPKG, UpdateTime=DateTime.Now},
                 new FileInfo{ FileName="软件", FileSize=0, FileType=FileType.Folder, UpdateTime=DateTime.Now},
                new FileInfo{ FileName="深入浅出PhotoShop.xlsx", FileSize=0, FileType=FileType.Excel, UpdateTime=DateTime.Now},
                new FileInfo{ FileName="深入浅出PhotoShop.doc", FileSize=0, FileType=FileType.Word, UpdateTime=DateTime.Now},
                new FileInfo{ FileName="深入浅出PhotoShop.pdf", FileSize=0, FileType=FileType.PDF, UpdateTime=DateTime.Now},
                new FileInfo{ FileName="深入浅出PhotoShop.rar", FileSize=0, FileType=FileType.CompressedPKG, UpdateTime=DateTime.Now},
                 new FileInfo{ FileName="软件", FileSize=0, FileType=FileType.Folder, UpdateTime=DateTime.Now},
                new FileInfo{ FileName="深入浅出PhotoShop.xlsx", FileSize=0, FileType=FileType.Excel, UpdateTime=DateTime.Now},
                new FileInfo{ FileName="深入浅出PhotoShop.doc", FileSize=0, FileType=FileType.Word, UpdateTime=DateTime.Now},
                new FileInfo{ FileName="深入浅出PhotoShop.pdf", FileSize=0, FileType=FileType.PDF, UpdateTime=DateTime.Now},
                new FileInfo{ FileName="深入浅出PhotoShop.rar", FileSize=0, FileType=FileType.CompressedPKG, UpdateTime=DateTime.Now},
                 new FileInfo{ FileName="软件", FileSize=0, FileType=FileType.Folder, UpdateTime=DateTime.Now},
                new FileInfo{ FileName="深入浅出PhotoShop.xlsx", FileSize=0, FileType=FileType.Excel, UpdateTime=DateTime.Now},
                new FileInfo{ FileName="深入浅出PhotoShop.doc", FileSize=0, FileType=FileType.Word, UpdateTime=DateTime.Now},
                 new FileInfo{ FileName="软件", FileSize=0, FileType=FileType.Folder, UpdateTime=DateTime.Now},
                new FileInfo{ FileName="深入浅出PhotoShop.xlsx", FileSize=0, FileType=FileType.Excel, UpdateTime=DateTime.Now},
                new FileInfo{ FileName="深入浅出PhotoShop.doc", FileSize=0, FileType=FileType.Word, UpdateTime=DateTime.Now},
                new FileInfo{ FileName="深入浅出PhotoShop.pdf", FileSize=0, FileType=FileType.PDF, UpdateTime=DateTime.Now},
                new FileInfo{ FileName="深入浅出PhotoShop.rar", FileSize=0, FileType=FileType.CompressedPKG, UpdateTime=DateTime.Now},
                 new FileInfo{ FileName="软件", FileSize=0, FileType=FileType.Folder, UpdateTime=DateTime.Now},
                new FileInfo{ FileName="深入浅出PhotoShop.xlsx", FileSize=0, FileType=FileType.Excel, UpdateTime=DateTime.Now},
                new FileInfo{ FileName="深入浅出PhotoShop.doc", FileSize=0, FileType=FileType.Word, UpdateTime=DateTime.Now},
                new FileInfo{ FileName="深入浅出PhotoShop.pdf", FileSize=0, FileType=FileType.PDF, UpdateTime=DateTime.Now},
                new FileInfo{ FileName="深入浅出PhotoShop.rar", FileSize=0, FileType=FileType.CompressedPKG, UpdateTime=DateTime.Now},
                 new FileInfo{ FileName="软件", FileSize=0, FileType=FileType.Folder, UpdateTime=DateTime.Now},
                new FileInfo{ FileName="深入浅出PhotoShop.xlsx", FileSize=0, FileType=FileType.Excel, UpdateTime=DateTime.Now},
                new FileInfo{ FileName="深入浅出PhotoShop.doc", FileSize=0, FileType=FileType.Word, UpdateTime=DateTime.Now},
                new FileInfo{ FileName="深入浅出PhotoShop.pdf", FileSize=0, FileType=FileType.PDF, UpdateTime=DateTime.Now},
                new FileInfo{ FileName="深入浅出PhotoShop.rar", FileSize=0, FileType=FileType.CompressedPKG, UpdateTime=DateTime.Now},
                 new FileInfo{ FileName="软件", FileSize=0, FileType=FileType.Folder, UpdateTime=DateTime.Now},
                new FileInfo{ FileName="深入浅出PhotoShop.xlsx", FileSize=0, FileType=FileType.Excel, UpdateTime=DateTime.Now},
                new FileInfo{ FileName="深入浅出PhotoShop.doc", FileSize=0, FileType=FileType.Word, UpdateTime=DateTime.Now},
                new FileInfo{ FileName="深入浅出PhotoShop.pdf", FileSize=0, FileType=FileType.PDF, UpdateTime=DateTime.Now},
                new FileInfo{ FileName="深入浅出PhotoShop.rar", FileSize=0, FileType=FileType.CompressedPKG, UpdateTime=DateTime.Now},
                 new FileInfo{ FileName="软件", FileSize=0, FileType=FileType.Folder, UpdateTime=DateTime.Now},
                new FileInfo{ FileName="深入浅出PhotoShop.xlsx", FileSize=0, FileType=FileType.Excel, UpdateTime=DateTime.Now},
                new FileInfo{ FileName="深入浅出PhotoShop.doc", FileSize=0, FileType=FileType.Word, UpdateTime=DateTime.Now},
                new FileInfo{ FileName="深入浅出PhotoShop.pdf", FileSize=0, FileType=FileType.PDF, UpdateTime=DateTime.Now},
                new FileInfo{ FileName="深入浅出PhotoShop.rar", FileSize=0, FileType=FileType.CompressedPKG, UpdateTime=DateTime.Now},
                new FileInfo{ FileName="深入浅出PhotoShop.pdf", FileSize=0, FileType=FileType.PDF, UpdateTime=DateTime.Now},
                new FileInfo{ FileName="深入浅出PhotoShop.rar", FileSize=0, FileType=FileType.CompressedPKG, UpdateTime=DateTime.Now}
            };
            //文件集合
            FileList.ItemsSource = files;
        }
    }
}
