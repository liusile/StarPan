using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPan.Model
{
    public class FileInfo
    {
        public string FileName { get; set; }
        public DateTime UpdateTime { get; set; }
        public int FileSize { get; set; }
        public FileType FileType { get; set; }
    }
}
