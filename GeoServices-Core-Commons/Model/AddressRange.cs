using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperTest.Model
{
    public class AddressRange : IEquatable<AddressRange>
    {
        public string type { get; set; }
        public string type_meaning { get; set; }
        public string low_address_number { get; set; }
        public string high_address_number { get; set; }
        public string street_name { get; set; }
        public string bin { get; set; }
        public string tpad_bin_status { get; set; }
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

        public override string ToString() => $"b7sc: {b7sc} | {low_address_number} to {high_address_number} {street_name} | bin: {bin}";

        public override bool Equals(object obj) => Equals(obj as AddressRange);
        public bool Equals(AddressRange other) => !(other is null) && type == other.type && type_meaning == other.type_meaning && low_address_number == other.low_address_number && high_address_number == other.high_address_number && street_name == other.street_name && bin == other.bin && tpad_bin_status == other.tpad_bin_status && b7sc == other.b7sc;

        public override int GetHashCode()
        {
            int hashCode = 405205733;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(type_meaning);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(low_address_number);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(high_address_number);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(street_name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(bin);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(tpad_bin_status);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(b7sc);
            return hashCode;
        }

        public static bool operator ==(AddressRange left, AddressRange right) => EqualityComparer<AddressRange>.Default.Equals(left, right);
        public static bool operator !=(AddressRange left, AddressRange right) => !(left == right);
    }
}
