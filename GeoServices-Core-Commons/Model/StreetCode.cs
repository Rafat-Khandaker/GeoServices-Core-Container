using GeoXWrapperLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperTest.Model
{
    public class StreetCode
    {
        public string borough { get; set; }
        public B10sc b10sc { get; set; }
        public string b10sc_toString { get; set; }
        public string streetName { get; set; }
        public string gft { get; set; }

        public override bool Equals(object obj)
        {
            return obj is StreetCode code
                && borough == code.borough
                //&& EqualityComparer<B10sc>.Default.Equals(b10sc, code.b10sc) 
                && string.Equals(b10sc.B10scToString(), code.b10sc.B10scToString()) //NS 6-14-23, B10sc in GeoX lacks a proper Equals()/GetHashCode() so I am explicitly altering the VS generated Equals method here. GetHashCode() has been untouched
                && b10sc_toString == code.b10sc_toString
                && streetName == code.streetName
                && gft == code.gft;
        }

        public override int GetHashCode()
        {
            int hashCode = -428870807;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(borough);
            hashCode = hashCode * -1521134295 + EqualityComparer<B10sc>.Default.GetHashCode(b10sc);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(b10sc_toString);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(streetName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(gft);
            return hashCode;
        }
    }
}
