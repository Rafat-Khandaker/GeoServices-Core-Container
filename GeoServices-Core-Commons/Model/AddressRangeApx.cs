using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperTest.Model
{
    public class AddressRangeApx
    {
        public string type { get; set; }
        public string type_meaning { get; set; }
        public string low_address_number { get; set; }
        public string high_address_number { get; set; }
        public string street_name { get; set; }
        public string bin { get; set; }
        public string b7sc { get; set; }

        public static string NormalizedType(string type)
        {
            switch (type.Trim())
            {
                case "":
                    return "Ordinary Address Range";
                case "N":
                    return "Non-Addressable Place Name";
                case "A":
                    return "Addressble Place Name";
                case "B":
                    return "Non-Addressable Unnamed Building";
                case "F":
                    return "Vacant Street Frontage";
                case "G":
                    return "Name of NAP Complex";
                case "H":
                    return "Hyphenated Address Range";
                case "M":
                    return "Mixed Hyphenation Address Range";
                case "O":
                    return "Out of Sequence Address";
                case "Q":
                    return "Pseudo Address";
                case "R":
                    return "Real Address for Vanity Address";
                case "U":
                    return "Miscellaneous Structure";
                case "V":
                    return "Vanity Address";
                case "W":
                    return "Non-Addressable Building Frontage";
                case "X":
                    return "Constituent NAP of Complex";
                default:
                    return string.Empty;
            }
        }

        public override bool Equals(object obj) => obj is AddressRangeApx apx && type == apx.type && type_meaning == apx.type_meaning && low_address_number == apx.low_address_number && high_address_number == apx.high_address_number && street_name == apx.street_name && bin == apx.bin && b7sc == apx.b7sc;

        public override int GetHashCode()
        {
            int hashCode = 554730628;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(type_meaning);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(low_address_number);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(high_address_number);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(street_name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(bin);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(b7sc);
            return hashCode;
        }
    }
}
