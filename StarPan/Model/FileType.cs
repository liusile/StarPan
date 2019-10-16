using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPan.Model
{
    public enum FileType
    {
        /// <summary>
        /// 文件夹
        /// </summary>
        Folder,
        /// <summary>
        /// 压缩包
        /// </summary>
        CompressedPKG,
        /// <summary>
        /// Word文件
        /// </summary>
        Word,
        /// <summary>
        /// PDF文件
        /// </summary>
        PDF,
        /// <summary>
        /// Excel文件
        /// </summary>
        Excel
    }
}
