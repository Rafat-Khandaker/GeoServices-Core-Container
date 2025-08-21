using System.Collections.Generic;

namespace GeoXWrapperTest.Model
{
    public class SimilarName
    {
        public string b7sc { get; set; }
        public string streetName { get; set; }

        public override bool Equals(object obj) => obj is SimilarName name && b7sc == name.b7sc && streetName == name.streetName;

        public override int GetHashCode()
        {
            int hashCode = 1141810865;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(b7sc);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(streetName);
            return hashCode;
        }

        public override string ToString() => $"{nameof(b7sc)}: {b7sc} | {nameof(streetName)}: {streetName}";
    }
}