using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperTest.Model.Structs
{
    public struct HighLowAddrInput
    {
        public string Borough { get; set; }
        public string LowAddressNo { get; set; }
        public string HighAddressNo { get; set; }
        public string StreetName { get; set; }

        public string StCode { get; set; }

        public HighLowAddrInput(string boro, string lowAddrNo, string highAddrNo, string stName) {
            Borough = boro;
            LowAddressNo = lowAddrNo;
            HighAddressNo = highAddrNo;
            StreetName = stName;
        }
    }
}
