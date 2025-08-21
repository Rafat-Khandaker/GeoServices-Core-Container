using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperTest.Model.Structs
{
    public struct CrossStreetInputs
    {
        public string Borough1 { get; set; }
        public string OnStreet { get; set; }
        public string SideOfStreet { get; set; }
        public string Borough2 { get; set; }
        public string FirstCrossStreet { get; set; }
        public string Borough3 { get; set; }
        public string SecondCrossStreet { get; set; }
        public string CompassDirection { get; set; }
        public CrossStreetInputs(string boro, string onSt, string fstCrx, string scdCrx, string dir = null)
        {
            Borough1 = boro;
            OnStreet = onSt;
            CompassDirection = dir;
            Borough2 = boro;
            FirstCrossStreet = fstCrx;
            Borough3 = boro;
            SecondCrossStreet = scdCrx;

        }
    }
}
