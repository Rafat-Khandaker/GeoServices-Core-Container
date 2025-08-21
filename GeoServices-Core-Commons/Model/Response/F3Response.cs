using GeoXWrapperLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperTest.Model.Response
{
    public class F3Response
    {
        public Wa1 wa1 { get; }
        public Wa2F3eas wa2f3eas { get; }

        public F3Response(Wa1 wa1, Wa2F3eas wa2f3eas)
        {
            this.wa1 = wa1;
            this.wa2f3eas = wa2f3eas;
        }
    }
}
