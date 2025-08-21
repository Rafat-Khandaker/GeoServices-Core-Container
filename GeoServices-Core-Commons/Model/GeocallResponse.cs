using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperTest.Model
{
    public class GeocallResponse<X, Y>
    {
        public X display { get; set; }
        public Y root { get; set; }

    }
}
