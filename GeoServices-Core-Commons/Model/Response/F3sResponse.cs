using GeoXWrapperLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperTest.Model.Response
{
    public class F3sResponse
    {
        public Wa1 wa1 { get; }
        public Wa2F3s wa2f3s { get; }

        public F3sResponse(Wa1 wa1, Wa2F3s wa2f3s)
        {
            this.wa1 = wa1;
            this.wa2f3s = wa2f3s;
        }
    }
}
