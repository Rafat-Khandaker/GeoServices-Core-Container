using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperTest.Model.Structs
{
    public struct StCodeCase
    {
        public string Boro1 { get; set; }
        public string B10Sc1 { get; set; }
        public string Boro2 { get; set; }
        public string B10Sc2 { get; set; }
        public string Boro3 { get; set; }
        public string B10Sc3 { get; set; }

        public List<StreetCode> ExpectedStCodes { get; set; }
        public List<string> ExpectedCompactStNames { get; set; }

        public string FullB10Sc1 => Boro1 + B10Sc1;
        public string FullB10Sc2 => Boro2 + B10Sc2;
        public string FullB10Sc3 => Boro3 + B10Sc3;

        public static string FailedTruncation => "********************************";
        public static int MinSnl => 4;
        public static int MaxSnl => 32;

        public StCodeCase(string boro1, string b10Sc1, string boro2, string b10Sc2, string boro3, string b10Sc3, List<StreetCode> expectedStCodes, List<string> expectedCompactStNames)
        {
            Boro1 = boro1;
            B10Sc1 = b10Sc1;
            Boro2 = boro2;
            B10Sc2 = b10Sc2;
            Boro3 = boro3;
            B10Sc3 = b10Sc3;

            ExpectedStCodes = expectedStCodes;
            ExpectedCompactStNames = expectedCompactStNames;
        }

        public override string ToString() => $"{FullB10Sc1} | {FullB10Sc2} | {FullB10Sc3}";
    }
}
