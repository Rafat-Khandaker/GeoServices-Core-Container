using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoServices_Core_Commons.Model.Settings
{
    public class SafeHandleMutex
    {
        public bool Lock { get; set; } = true;
        public int Wait { get; set; } = 10;
        public int Max { get; set; } = 1000;
        public int Sleep { get; set; } = 100;
        public int Retry { get; set; } = 3;
    }
}
