using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperTest.Model.Structs
{
    public readonly struct Grc03IntrsctCase
    {
        public IntrsctInput Input { get; }

        public List<string> ExpectedB7scs { get; }
        public List<int> ExpectedB7scStarts { get; }
        public List<string> ExpectedNodes { get; }
        public List<string> ExpectedCrxSts { get; }
        public List<int> ExpectedCrxStarts { get; }

        public Grc03IntrsctCase(IntrsctInput input, List<string> expectedB7scs, List<int> expectedB7scStarts, List<string> expectedNodes, List<string> expectedCrxSts, List<int> expectedCrxStarts)
        {
            Input = input;

            ExpectedB7scs = expectedB7scs;
            ExpectedB7scStarts = expectedB7scStarts;
            ExpectedNodes = expectedNodes;
            ExpectedCrxSts = expectedCrxSts;
            ExpectedCrxStarts = expectedCrxStarts;
        }
    }
}
