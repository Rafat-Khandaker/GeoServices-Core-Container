using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperTest.Model
{
    public class LowHighB7SC
    {
        public string b7sc { get; set; }
        public string streetName { get; set; }

        public override bool Equals(object obj) => obj is LowHighB7SC sC && b7sc == sC.b7sc && streetName == sC.streetName;

        public override int GetHashCode()
        {
            int hashCode = 1141810865;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(b7sc);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(streetName);
            return hashCode;
        }
    }
}
