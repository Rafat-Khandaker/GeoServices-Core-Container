using GeoXWrapperLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperTest.Model.Response
{
    public class FBBResponse
    {
        public Wa1 wa1 { get; }

        public FBBResponse(Wa1 wa1) => this.wa1 = wa1;
    }
}
