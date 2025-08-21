using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperLib.Model
{
    public class Wa2F1p : WA
    {
        private VsamKey1 m_gridkey1;
        private string m_cont_parity_ind;
        private string m_lo_hns;
        private string m_ped_rec;

        // Constructor for Wa2F1p
        public Wa2F1p()
        {
            m_gridkey1 = new VsamKey1(); 
            m_cont_parity_ind = new string(' ', 1);
            m_lo_hns = new string(' ', 11);
            m_ped_rec = new string(' ', 1884);
        }

        // Constructor for Wa2F1p
        public Wa2F1p(string inString) => Wa2F1pFromString(inString);

        // Clear reinitializes the Wa2F1p object to spaces
        public override void Clear() => Wa2F1pFromString(new string(' ', 1917));

        // ToString converts a Wa2F1p object to a string
        public override string ToString() => Wa2F1pToString();

        // FromString converts a string to a Wa2F1p object
        public override void FromString(string inString) => Wa2F1pFromString(inString);

        // Wa2F1pToString converts a Wa2F1p object to a string
        public string Wa2F1pToString()
        {
            var sb = new StringBuilder();
            sb.Append(m_gridkey1.VsamKey1ToString());
            sb.Append(m_cont_parity_ind);
            sb.Append(m_lo_hns);
            sb.Append(m_ped_rec);
            return sb.ToString();
        }

        // Wa2F1pFromString converts a string to a Wa2F1p object
        public void Wa2F1pFromString(string inString)
        {
            m_gridkey1 = new VsamKey1(inString.Substring(0, 21));
            m_cont_parity_ind = inString.Substring(21, 1);
            m_lo_hns = inString.Substring(22, 11);
            m_ped_rec = inString.Substring(33, 1884);
        }

        // Display creates a string of Wa2F1p field values separated by a character
        public override string Display(char c)
        {
            var sb = new StringBuilder();
            sb.Append(m_gridkey1.Display());
            sb.Append(c);
            sb.Append(m_cont_parity_ind);
            sb.Append(c);
            sb.Append(m_lo_hns);
            sb.Append(c);
            sb.Append(m_ped_rec);
            sb.Append(c);
            return sb.ToString();
        }

        // Display creates a string of Wa2F1p field values separated by a dash
        public override string Display() => Display('-');

        // Print creates a string with Wa2F1p field names and values
        public override string Print()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("gridkey1 = {0}\r\n", m_gridkey1.Display());
            sb.AppendFormat("cont_parity_ind = {0}\r\n", m_cont_parity_ind);
            sb.AppendFormat("lo_hns = {0}\r\n", m_lo_hns);
            sb.AppendFormat("ped_rec = {0}\r\n", m_ped_rec);
            return sb.ToString();
        }

        // Property for gridkey1
        public VsamKey1 gridkey1
        {
            get => m_gridkey1;
            set => m_gridkey1 = value;
        }

        // Property for cont_parity_ind
        public string cont_parity_ind
        {
            get => m_cont_parity_ind;
            set
            {
                int strlen = Math.Min(value.Length, 1);
                m_cont_parity_ind = value.Substring(0, strlen);
            }
        }

        // Property for lo_hns
        public string lo_hns
        {
            get => m_lo_hns;
            set
            {
                int strlen = Math.Min(value.Length, 11);
                m_lo_hns = value.Substring(0, strlen);
            }
        }

        // Property for ped_rec
        public string ped_rec
        {
            get => m_ped_rec;
            set
            {
                int strlen = Math.Min(value.Length, 1884);
                m_ped_rec = value.Substring(0, strlen);
            }
        }
    }
}
