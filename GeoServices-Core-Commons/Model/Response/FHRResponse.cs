using GeoXWrapperLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperTest.Model.Response
{
    public class FHRResponse
    {
        public Wa1 wa1 { get; }
        public Wa2Fhr wa2fhr { get; }

        public FHRResponse(Wa1 wa1, Wa2Fhr wa2fhr)
        {
            this.wa1 = wa1;
            this.wa2fhr = wa2fhr;
        }
    }
}
