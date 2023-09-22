using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfAppMirea.Helper
{
    internal class NavigationData
    {
        public static Frame NavigateFooter { get; set; } = null; 
        public static Frame NavigateHeader { get; set; }
        public static Frame NavigatePage { get; set; }
    }
}
