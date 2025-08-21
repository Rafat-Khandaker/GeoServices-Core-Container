using GeoXWrapperLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperTest.Model.Response
{
    public class FBNResponse
    {
        public Wa1 wa1 { get; }
        public Wa2F1ax wa2f1ax { get; }

        public FBNResponse(Wa1 wa1, Wa2F1ax wa2f1ax)
        {
            this.wa1 = wa1;
            this.wa2f1ax = wa2f1ax;
        }
    }
}
