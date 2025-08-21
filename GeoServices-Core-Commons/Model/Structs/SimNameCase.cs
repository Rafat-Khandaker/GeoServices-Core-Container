using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperTest.Model.Structs
{
    public readonly struct SimNameCase
    {
        public string Boro { get; }
        public string AddrNo { get; }
        public string BadStName { get; }

        public List<SimilarName> ExpectedSimNames { get; }

        public SimNameCase(string boro, string addrNo, string badStName, List<SimilarName> expectedSimNames)
        {
            Boro = boro;
            AddrNo = addrNo;
            BadStName = badStName;
            ExpectedSimNames = expectedSimNames;
        }

        public override string ToString() => $"{Boro} | {AddrNo} {BadStName}";
    }
}
