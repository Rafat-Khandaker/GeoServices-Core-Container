using GeoXWrapperLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperTest.Model.Response
{
    public class F1eResponse
    {
        public Wa1 wa1 { get; }
        public Wa2F1ex wa2f1ex { get; }

        public F1eResponse(Wa1 wa1, Wa2F1ex wa2f1ex)
        {
            this.wa1 = wa1;
            this.wa2f1ex = wa2f1ex;
        }
    }
}
