using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace GeoXWrapperLib.Model
{
    public class AddrRange_ap
    {
        private string m_lhnd;
        private string m_hhnd;
        private B7sc m_b7sc;
        private BIN m_bin;
        private string m_sos;
        private string m_addr_type;
        private string m_TPAD_bin_status;
        private string m_filler01;

        /// <summary>
        /// Default constructor for AddrRange_ap
        /// </summary>
        public AddrRange_ap()
        {
            m_lhnd = new string(' ', 16);
            m_hhnd = new string(' ', 16);
            m_b7sc = new B7sc();
            m_bin = new BIN();
            m_sos = new string(' ', 1);
            m_addr_type = new string(' ', 1);
            m_TPAD_bin_status = new string(' ', 1);
            m_filler01 = new string(' ', 3);
        }

        /// <summary>
        /// Constructor for AddrRange_ap that initializes from a string
        /// </summary>
        public AddrRange_ap(string inString)
        {
            AddrRange_apFromString(inString);
        }

        /// <summary>
        /// Clears the AddrRange_ap object by reinitializing its fields to spaces
        /// </summary>
        public void Clear()
        {
            AddrRange_apFromString(new string(' ', 53));
        }

        /// <summary>
        /// Converts the AddrRange_ap object to a string
        /// </summary>
        public override string ToString()
        {
            return AddrRange_apToString();
        }

        /// <summary>
        /// Converts a string to an AddrRange_ap object
        /// </summary>
        public void FromString(string inString)
        {
            AddrRange_apFromString(inString);
        }

        /// <summary>
        /// Converts the AddrRange_ap object to an XML document
        /// </summary>
        public void ToXml(ref XmlDocument indoc)
        {
            using (var xmlStream = new MemoryStream())
            {
                var xmlFormatter = new XmlSerializer(typeof(AddrRange_ap));
                try
                {
                    xmlFormatter.Serialize(xmlStream, this);
                    xmlStream.Position = 0;
                    indoc.Load(xmlStream);
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// Converts the AddrRange_ap object to a string
        /// </summary>
        public string AddrRange_apToString()
        {
            var sb = new StringBuilder();
            sb.Append(m_lhnd);
            sb.Append(m_hhnd);
            sb.Append(m_b7sc.B7scToString());
            sb.Append(m_bin.BINToString());
            sb.Append(m_sos);
            sb.Append(m_addr_type);
            sb.Append(m_TPAD_bin_status);
            sb.Append(m_filler01);
            return sb.ToString();
        }

        /// <summary>
        /// Converts a string to an AddrRange_ap object
        /// </summary>
        public void AddrRange_apFromString(string inString)
        {
            try { m_lhnd = inString.Substring(0, 16); } catch { m_lhnd = string.Empty; }
            try { m_hhnd = inString.Substring(16, 16); } catch { m_hhnd = string.Empty; }
            try { m_b7sc = new B7sc(inString.Substring(32, 8)); } catch { m_b7sc = new B7sc(); }
            try { m_bin = new BIN(inString.Substring(40, 7)); } catch { m_bin = new BIN(); }

            try { m_sos = inString.Substring(47, 1); } catch { m_sos = string.Empty; }
            try { m_addr_type = inString.Substring(48, 1); } catch { m_addr_type = string.Empty; }
            try { m_TPAD_bin_status = inString.Substring(49, 1); } catch { m_TPAD_bin_status = string.Empty; }
            try { m_filler01 = inString.Substring(50, 3); } catch { m_filler01 = string.Empty; }
        }

        /// <summary>
        /// Creates a string of AddrRange_ap field values separated by a character
        /// </summary>
        public string Display(char separator)
        {
            var sb = new StringBuilder();
            sb.Append(m_lhnd);
            sb.Append(separator);
            sb.Append(m_hhnd);
            sb.Append(separator);
            sb.Append(m_b7sc.Display());
            sb.Append(separator);
            sb.Append(m_bin.Display());
            sb.Append(separator);
            sb.Append(m_sos);
            sb.Append(separator);
            sb.Append(m_addr_type);
            sb.Append(separator);
            sb.Append(m_TPAD_bin_status);
            sb.Append(separator);
            sb.Append(m_filler01);
            sb.Append(separator);
            return sb.ToString();
        }

        /// <summary>
        /// Creates a string of AddrRange_ap field values separated by a dash
        /// </summary>
        public string Display()
        {
            return Display('-');
        }

        /// <summary>
        /// Creates a string with AddrRange_ap field names and values
        /// </summary>
        public string Print()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("lhnd = {0}{1}", m_lhnd, Environment.NewLine);
            sb.AppendFormat("hhnd = {0}{1}", m_hhnd, Environment.NewLine);
            sb.AppendFormat("b7sc = {0}{1}", m_b7sc.Display(), Environment.NewLine);
            sb.AppendFormat("bin = {0}{1}", m_bin.Display(), Environment.NewLine);
            sb.AppendFormat("sos = {0}{1}", m_sos, Environment.NewLine);
            sb.AppendFormat("addr_type = {0}{1}", m_addr_type, Environment.NewLine);
            sb.AppendFormat("TPAD_bin_status = {0}{1}", m_TPAD_bin_status, Environment.NewLine);
            sb.AppendFormat("filler01 = {0}{1}", m_filler01, Environment.NewLine);
            return sb.ToString();
        }

        public string lhnd
        {
            get { return m_lhnd; }
            set { m_lhnd = value.PadRight(16).Substring(0, 16); }
        }

        public string hhnd
        {
            get { return m_hhnd; }
            set { m_hhnd = value.PadRight(16).Substring(0, 16); }
        }

        public B7sc b7sc
        {
            get { return m_b7sc; }
            set { m_b7sc = value; }
        }

        public BIN bin
        {
            get { return m_bin; }
            set { m_bin = value; }
        }

        public string sos
        {
            get { return m_sos; }
            set { m_sos = value.PadRight(1).Substring(0, 1); }
        }

        public string addr_type
        {
            get { return m_addr_type; }
            set { m_addr_type = value.PadRight(1).Substring(0, 1); }
        }

        public string TPAD_bin_status
        {
            get { return m_TPAD_bin_status; }
            set { m_TPAD_bin_status = value.PadRight(1).Substring(0, 1); }
        }

        public string filler01
        {
            get { return m_filler01; }
            set { m_filler01 = value.PadRight(3).Substring(0, 3); }
        }
    }
}
