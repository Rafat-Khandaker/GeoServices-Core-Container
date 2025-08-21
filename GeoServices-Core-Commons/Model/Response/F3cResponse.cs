using GeoXWrapperLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperTest.Model.Response
{
    public class F3cResponse
    {
        public Wa1 wa1 { get; }
        public Wa2F3ceas wa2f3ceas { get; }

        public F3cResponse(Wa1 wa1, Wa2F3ceas wa2f3ceas)
        {
            this.wa1 = wa1;
            this.wa2f3ceas = wa2f3ceas;
        }
    }
}
