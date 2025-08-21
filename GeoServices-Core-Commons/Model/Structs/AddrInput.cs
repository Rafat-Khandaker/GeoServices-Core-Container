using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperTest.Model.Structs
{
    public struct AddrInput
    {
        public string Boro { get; set; }
        public string AddrNo { get; set; }
        public string SortFormatAddrNo { get; set; }
        public string StName { get; set; }
        public string StNameLength { get; set; }
        public string Zip { get; set; }
        public string Unit { get; set;  }
        public string NodeId { get; set; }
        public string Freeform => $"{AddrNo} {StName}";

        public AddrInput(string addrNo)
        {
            AddrNo = addrNo;
        }

        public AddrInput(string boro, string addrNo, string sortFormatAddrNo, string stName, string stNameLength, string zip, string unit, string nodeId)
        {
            Boro = boro;
            AddrNo = addrNo;
            SortFormatAddrNo = sortFormatAddrNo;
            StName = stName;
            StNameLength = stNameLength;
            Zip = zip;
            Unit = unit;
            NodeId = nodeId;
        }

        public override string ToString() => $"{Boro}/{Zip} | {AddrNo} [{SortFormatAddrNo}] {StName} - {Unit}";
    }
}
