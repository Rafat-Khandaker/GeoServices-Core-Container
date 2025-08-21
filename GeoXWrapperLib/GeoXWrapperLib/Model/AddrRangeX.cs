using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace GeoXWrapperLib.Model
{
    public class AddrRangeX
    {
        private string m_lhnd;
        private string m_hhnd;
        private B7sc m_b7sc;
        private BIN m_bin;
        private string m_sos;
        private string m_addr_type;
        private string m_TPAD_bin_status;
        private string m_stname;
        private string m_filler01;

        // Property for lhnd
        public string lhnd
        {
            get { return m_lhnd; }
            set
            {
                int strlen = value.Length;
                if (strlen > 16) strlen = 16;
                m_lhnd = new string(' ', 16);
                if (strlen > 0)
                {
                    m_lhnd = value.Substring(0, strlen).PadRight(16);
                }
            }
        }

        // Property for hhnd
        public string hhnd
        {
            get { return m_hhnd; }
            set
            {
                int strlen = value.Length;
                if (strlen > 16) strlen = 16;
                m_hhnd = new string(' ', 16);
                if (strlen > 0)
                {
                    m_hhnd = value.Substring(0, strlen).PadRight(16);
                }
            }
        }

        // Property for b7sc
        public B7sc b7sc
        {
            get { return m_b7sc; }
            set { m_b7sc = value; }
        }

        // Property for bin
        public BIN bin
        {
            get { return m_bin; }
            set { m_bin = value; }
        }

        // Property for sos
        public string sos
        {
            get { return m_sos; }
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_sos = new string(' ', 1);
                if (strlen > 0)
                {
                    m_sos = value.Substring(0, strlen);
                }
            }
        }

        // Property for addr_type
        public string addr_type
        {
            get { return m_addr_type; }
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_addr_type = new string(' ', 1);
                if (strlen > 0)
                {
                    m_addr_type = value.Substring(0, strlen);
                }
            }
        }

        // Property for TPAD_bin_status
        public string TPAD_bin_status
        {
            get { return m_TPAD_bin_status; }
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_TPAD_bin_status = new string(' ', 1);
                if (strlen > 0)
                {
                    m_TPAD_bin_status = value.Substring(0, strlen);
                }
            }
        }

        // Property for stname
        public string stname
        {
            get { return m_stname; }
            set
            {
                int strlen = value.Length;
                if (strlen > 32) strlen = 32;
                m_stname = new string(' ', 32);
                if (strlen > 0)
                {
                    m_stname = value.Substring(0, strlen).PadRight(32);
                }
            }
        }

        // Property for filler01
        public string filler01
        {
            get { return m_filler01; }
            set
            {
                int strlen = value.Length;
                if (strlen > 34) strlen = 34;
                m_filler01 = new string(' ', 34);
                if (strlen > 0)
                {
                    m_filler01 = value.Substring(0, strlen).PadRight(34);
                }
            }
        }

        // Default constructor
        public AddrRangeX()
        {
            m_lhnd = new string(' ', 16);
            m_hhnd = new string(' ', 16);
            m_b7sc = new B7sc();
            m_bin = new BIN();
            m_sos = new string(' ', 1);
            m_addr_type = new string(' ', 1);
            m_TPAD_bin_status = new string(' ', 1);
            m_stname = new string(' ', 32);
            m_filler01 = new string(' ', 34);
        }

        // Constructor with string input
        public AddrRangeX(string inString)
        {
            AddrRangeXFromString(inString);
        }

        // Clears the AddrRangeX object by resetting all values to spaces
        public void Clear()
        {
            AddrRangeXFromString(new string(' ', 116));
        }

        // Converts AddrRangeX object to string
        public override string ToString()
        {
            return AddrRangeXToString();
        }

        // Converts a string to an AddrRangeX object
        public void FromString(string inString)
        {
            AddrRangeXFromString(inString);
        }

        // Converts AddrRangeX object to XML document
        public void ToXml(ref XmlDocument indoc)
        {
            using (MemoryStream xmlStream = new MemoryStream())
            {
                XmlSerializer xmlFormatter = new XmlSerializer(typeof(AddrRangeX));
                try
                {
                    xmlFormatter.Serialize(xmlStream, this);
                    xmlStream.Position = 0;
                    indoc.Load(xmlStream);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        // Converts AddrRangeX object to a string representation
        public string AddrRangeXToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(m_lhnd);
            sb.Append(m_hhnd);
            sb.Append(m_b7sc.B7scToString());
            sb.Append(m_bin.BINToString());
            sb.Append(m_sos);
            sb.Append(m_addr_type);
            sb.Append(m_TPAD_bin_status);
            sb.Append(m_stname);
            sb.Append(m_filler01);

            return sb.ToString();
        }

        // Converts a string to an AddrRangeX object
        public void AddrRangeXFromString(string inString)
        {
            try { lhnd = inString.Substring(0, 16); } catch { lhnd = string.Empty; }
            try { hhnd = inString.Substring(16, 16); } catch { hhnd = string.Empty; }
            try { b7sc = new B7sc(inString.Substring(32, 8)); } catch { b7sc = new B7sc(); }
            try { bin = new BIN(inString.Substring(40, 7)); } catch { bin = new BIN(); }
            try { sos = inString.Substring(47, 1); } catch { sos = string.Empty; }
            try { addr_type = inString.Substring(48, 1); } catch { addr_type = string.Empty; }
            try { TPAD_bin_status = inString.Substring(49, 1); } catch { TPAD_bin_status = string.Empty; }
            try { stname = inString.Substring(50, 32); } catch { stname = string.Empty; }
            try { filler01 = inString.Substring(82, 34); } catch { filler01 = string.Empty; } 
        }

        // Creates a string of AddrRangeX field values separated by a specific character
        public string Display(char c)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(m_lhnd);
            sb.Append(c);
            sb.Append(m_hhnd);
            sb.Append(c);
            sb.Append(m_b7sc.Display());
            sb.Append(c);
            sb.Append(m_bin.Display());
            sb.Append(c);
            sb.Append(m_sos);
            sb.Append(c);
            sb.Append(m_addr_type);
            sb.Append(c);
            sb.Append(m_TPAD_bin_status);
            sb.Append(c);
            sb.Append(m_stname);
            sb.Append(c);
            sb.Append(m_filler01);
            sb.Append(c);

            return sb.ToString();
        }

        // Creates a string of AddrRangeX field values separated by a dash
        public string Display()
        {
            return Display('-');
        }

        // Creates a string with AddrRangeX field names and values
        public string Print()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("lhnd = {0}{1}", m_lhnd, Environment.NewLine);
            sb.AppendFormat("hhnd = {0}{1}", m_hhnd, Environment.NewLine);
            sb.AppendFormat("b7sc = {0}{1}", m_b7sc.Display(), Environment.NewLine);
            sb.AppendFormat("bin = {0}{1}", m_bin.Display(), Environment.NewLine);
            sb.AppendFormat("sos = {0}{1}", m_sos, Environment.NewLine);
            sb.AppendFormat("addr_type = {0}{1}", m_addr_type, Environment.NewLine);
            sb.AppendFormat("TPAD_bin_status = {0}{1}", m_TPAD_bin_status, Environment.NewLine);
            sb.AppendFormat("stname = {0}{1}", m_stname, Environment.NewLine);
            sb.AppendFormat("filler01 = {0}{1}", m_filler01, Environment.NewLine);

            return sb.ToString();
        }

       
    }
}
