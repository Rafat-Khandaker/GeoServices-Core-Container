using GeoXWrapperLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperTest.Model.Response
{
    public class F2Response
    {
        public Wa1 wa1 { get; }
        public Wa2F2w wa2f2w { get; }
        public F2Response() { }

        public F2Response(Wa1 wa1, Wa2F2w wa2f2w)
        {
            this.wa1 = wa1;
            this.wa2f2w = wa2f2w;
        }
    }
}
