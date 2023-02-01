using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTest2012.Models { 
    internal class DataBaseConnectContext
    {
        public static PathfinderModel ConnectContext { get; set; } = new PathfinderModel();
    }
}
