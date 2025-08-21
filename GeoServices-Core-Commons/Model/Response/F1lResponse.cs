using GeoXWrapperLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperTest.Model.Response
{
    public class F1lResponse
    {
        public Wa1 wa1 { get; }

        public F1lResponse(Wa1 wa1) => this.wa1 = wa1;
    }
}
