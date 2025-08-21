using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperTest.Model.Structs
{
    public struct IntrsctInput
    {
        public string Boro { get; set; }
        public string St1 { get; set;  }
        public string St2 { get; set;  }

        public string Compass { get; set; }
        public string NamedAlt { get; set;  }

        public IntrsctInput(string boro, string st1, string st2, string compass = "", string namedAlt = "")
        {
            Boro = boro;
            St1 = st1;
            St2 = st2;

            //Optionals
            Compass = compass;
            NamedAlt = namedAlt;
        }

        public override string ToString() => string.IsNullOrWhiteSpace(Compass)
            ? $"{Boro} | {St1} & {St2}"
            : $"{Boro} | {St1} & {St2} | {Compass}";
    }
}
