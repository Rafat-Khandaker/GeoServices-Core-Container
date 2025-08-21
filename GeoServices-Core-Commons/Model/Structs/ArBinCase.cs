using GeoXWrapperTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperTest.Model.Structs
{
    public readonly struct ArBinCase
    {
        public string Boro { get; }
        public string AddrNo { get; }
        public string StName { get; }
        public string Block { get; }
        public string Lot { get; }
        public string BIN { get; }

        public Dictionary<string, string> ExpectedAddrRangeKeys { get; }
        public List<AddressRange> ExpectedARL_NoTPAD { get; }
        public List<AddressRange> ExpectedARL_TPAD { get; }
        public List<CompleteBIN> ExpectedBins_NoTPAD { get; }
        public List<CompleteBIN> ExpectedBins_TPAD { get; }

        public string CompleteBBL => $"{int.Parse(Boro):D1}{int.Parse(Block):D5}{int.Parse(Lot):D4}"; //"D" qualifier will add zero padding to the string representation of an int

        public ArBinCase(string boro, string addrNo, string stName, string block, string lot, string bin, Dictionary<string, string> expectedAddrRangeKeys, List<AddressRange> expectedARL_NoTPAD, List<AddressRange> expectedARL_TPAD, List<CompleteBIN> expectedBins_NoTPAD, List<CompleteBIN> expectedBins_TPAD)
        {
            Boro = boro;
            AddrNo = addrNo;
            StName = stName;
            Block = block;
            Lot = lot;
            BIN = bin;
            ExpectedAddrRangeKeys = expectedAddrRangeKeys;
            ExpectedARL_NoTPAD = expectedARL_NoTPAD;
            ExpectedARL_TPAD = expectedARL_TPAD;
            ExpectedBins_NoTPAD = expectedBins_NoTPAD;
            ExpectedBins_TPAD = expectedBins_TPAD;
        }

        public override string ToString() => $"{Boro} - {AddrNo} {StName} | BBL: {Boro}{Block}{Lot} | BIN: {BIN}";
    }
}
