using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperTest.Model
{
    public class FunctionInput
    {
        public string Borough { get; set; } = "";
        public string ZipCode { get; set; } = "";
        public string AddressNo { get; set; } = "";
        public string LowAddressNo { get; set; } = string.Empty;
        public string HighAddressNo { get; set; } = string.Empty;
        public string StreetName { get; set; } = "";
        public string StreetNameLength { get; set; } = "32";
        public string StreetNameFormat { get; set; } = "S";
        public string TPad { get; set; } = "";
        public string BrowseFlag{ get; set; } = "";
        public string Unit { get; set; } = "";
        public string Hns { get; set; } = "n";
        public string NodeId { get; set; }
        public string RoadBed { get; set; } = "";
        public string CompassFlag { get; set; }
        public string Borough1 { get; set; }
        public string Street1 { get; set; }
        public string SideOfStreet { get; set; }
        public string Borough2 { get; set; }
        public string Street2 { get; set; }
        public string OnStreet { get; set; }
        public string FirstCrossStreet { get; set; }
        public string Borough3 { get; set; }
        public string SecondCrossStreet { get; set; }
        public string CompassDir { get; set; }
        public string CompassDir2 { get; set; }

        public string RealStreetFlag { get; set; }

        public string B10SC1 { get; set; }
        public string B10SC2 { get; set; }

        public string B10SC3 { get; set; }

        public string StCode { get; set; }

        public string Block { get; set; }
        public string Lot { get; set; }
        public string BBL { get; set; }

        public string Bin { get; set; }


    }
}
