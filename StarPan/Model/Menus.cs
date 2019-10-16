using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPan.Model
{
    public class Menus
    {
        /// <summary>
        /// 菜单名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Icon
        /// </summary>
        public string Icon { get; internal set; }
        /// <summary>
        /// 菜单激活时的Icon
        /// </summary>
        public string IconActive { get; internal set; }
    }
}
