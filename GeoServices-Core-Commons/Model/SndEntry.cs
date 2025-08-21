using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperTest.Model
{
    public class SndEntry
    {
        public string out_b7sc { get; set; }
        public string out_boro_name1 { get; set; }
        public string out_stname1 { get; set; }

        public override bool Equals(object obj) => obj is SndEntry entry && out_b7sc == entry.out_b7sc && out_boro_name1 == entry.out_boro_name1 && out_stname1 == entry.out_stname1;

        public override int GetHashCode()
        {
            int hashCode = -1740201591;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(out_b7sc);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(out_boro_name1);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(out_stname1);
            return hashCode;
        }
    }
}
