using GeoXWrapperLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperTest.Model.Response
{
    public class F5Response 
    {
        public Wa1 wa1 { get; }
        public Wa2F5 wa2f5 { get; }

        public F5Response(Wa1 wa1, Wa2F5 wa2f5)
        {
            this.wa1 = wa1;
            this.wa2f5 = wa2f5;
        }
    }
}
