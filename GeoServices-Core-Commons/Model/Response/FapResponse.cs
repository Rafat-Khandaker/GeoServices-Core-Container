using GeoXWrapperLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperTest.Model.Response
{
    public class FapResponse
    {
        public Wa1 wa1 { get; }
        public Wa2Fapx wa2fapx { get; }

        public FapResponse(Wa1 wa1, Wa2Fapx wa2fapx)
        {
            this.wa1 = wa1;
            this.wa2fapx = wa2fapx;
        }
    }
}
