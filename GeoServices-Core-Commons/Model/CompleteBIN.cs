using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperTest.Model
{
    public class CompleteBIN : IEquatable<CompleteBIN>
    {
        public string bin { get; set; }
        public string tpad { get; set; }

        public override string ToString() => $"{bin} | {tpad}";

        public override bool Equals(object obj) => Equals(obj as CompleteBIN);
        public bool Equals(CompleteBIN other) => !(other is null) && bin == other.bin && tpad == other.tpad;

        public override int GetHashCode()
        {
            int hashCode = -1556539166;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(bin);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(tpad);
            return hashCode;
        }

        public static bool operator ==(CompleteBIN left, CompleteBIN right) => EqualityComparer<CompleteBIN>.Default.Equals(left, right);
        public static bool operator !=(CompleteBIN left, CompleteBIN right) => !(left == right);
    }
}
