using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperTest.Model.Structs
{
    public struct BBLInput
    {
        public string Boro { get; set; }
        public string Block { get; set;  }
        public string Lot { get; set;  }

        public string Bbl => $"{int.Parse(Boro):D1}{int.Parse(Block):D5}{int.Parse(Lot):D4}";

        public BBLInput(string boro, string block, string lot)
        {
            Boro = boro;
            Block = block;
            Lot = lot;
        }

        public override string ToString() => Bbl;
    }
}
