using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace GeoXWrapperLib.Model
{
    public class AddrRange
    {
        private string m_lhnd;
        private string m_hhnd;
        private B7sc m_b7sc;
        private BIN m_bin;
        private string m_sos;
        private string m_addr_type;
        private string m_filler01;

        /// <summary>Constructor for AddrRange</summary>
        public AddrRange()
        {
            m_lhnd = new string(' ', 16);
            m_hhnd = new string(' ', 16);
            m_b7sc = new B7sc();
            m_bin = new BIN();
            m_sos = new string(' ', 1);
            m_addr_type = new string(' ', 1);
            m_filler01 = new string(' ', 4);
        }

        /// <summary>Constructor for AddrRange</summary>
        public AddrRange(string inString)
        {
            AddrRangeFromString(inString);
        }

        /// <summary>Clear reinitializes the AddrRange object to spaces</summary>
        public void Clear()
        {
            AddrRangeFromString(new string(' ', 53));
        }

        /// <summary>ToString converts an AddrRange object to a string</summary>
        public override string ToString()
        {
            return AddrRangeToString();
        }

        /// <summary>FromString converts a string to an AddrRange object</summary>
        public void FromString(string inString)
        {
            AddrRangeFromString(inString);
        }

        /// <summary>ToXml converts an AddrRange object to an XML document</summary>
        public void ToXml(ref XmlDocument indoc)
        {
            using (var xmlStream = new MemoryStream())
            {
                var xmlFormatter = new XmlSerializer(typeof(AddrRange));
                try
                {
                    xmlFormatter.Serialize(xmlStream, this);
                    xmlStream.Position = 0;
                    indoc.Load(xmlStream);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        /// <summary>AddrRangeToString converts an AddrRange object to a string</summary>
        public string AddrRangeToString()
        {
            var sb = new StringBuilder();
            sb.Append(m_lhnd);
            sb.Append(m_hhnd);
            sb.Append(m_b7sc.B7scToString());
            sb.Append(m_bin.BINToString());
            sb.Append(m_sos);
            sb.Append(m_addr_type);
            sb.Append(m_filler01);

            return sb.ToString();
        }

        /// <summary>AddrRangeFromString converts a string to an AddrRange object</summary>
        public void AddrRangeFromString(string inString)
        {
            if (inString.Length >= 53)
            {
                m_lhnd = inString.Substring(0, 16);
                m_hhnd = inString.Substring(16, 16);
                m_b7sc = new B7sc(inString.Substring(32, 8));
                m_bin = new BIN(inString.Substring(40, 7));
                m_sos = inString.Substring(47, 1);
                m_addr_type = inString.Substring(48, 1);
                m_filler01 = inString.Substring(49, 4);
            }
        }

        /// <summary>Display creates a string of AddrRange field values separated by a character</summary>
        public string Display(char c)
        {
            var sb = new StringBuilder();
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
            sb.Append(m_filler01);
            sb.Append(c);

            return sb.ToString();
        }

        /// <summary>Display creates a string of AddrRange field values separated by a dash</summary>
        public string Display()
        {
            return Display('-');
        }

        /// <summary>Print creates a string with AddrRange field names and values</summary>
        public string Print()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("lhnd = {0}\n", m_lhnd);
            sb.AppendFormat("hhnd = {0}\n", m_hhnd);
            sb.AppendFormat("b7sc = {0}\n", m_b7sc.Display());
            sb.AppendFormat("bin = {0}\n", m_bin.Display());
            sb.AppendFormat("sos = {0}\n", m_sos);
            sb.AppendFormat("addr_type = {0}\n", m_addr_type);
            sb.AppendFormat("filler01 = {0}\n", m_filler01);

            return sb.ToString();
        }

        /// <value>Property for lhnd</value>
        public string lhnd
        {
            get => m_lhnd;
            set
            {
                int strlen = value.Length;
                if (strlen > 16) strlen = 16;
                m_lhnd = new string(' ', 16);
                if (strlen > 0)
                {
                    m_lhnd = value.Substring(0, strlen);
                }
            }
        }

        /// <value>Property for hhnd</value>
        public string hhnd
        {
            get => m_hhnd;
            set
            {
                int strlen = value.Length;
                if (strlen > 16) strlen = 16;
                m_hhnd = new string(' ', 16);
                if (strlen > 0)
                {
                    m_hhnd = value.Substring(0, strlen);
                }
            }
        }

        /// <value>Property for b7sc</value>
        public B7sc b7sc
        {
            get => m_b7sc;
            set => m_b7sc = value;
        }

        /// <value>Property for bin</value>
        public BIN bin
        {
            get => m_bin;
            set => m_bin = value;
        }

        /// <value>Property for sos</value>
        public string sos
        {
            get => m_sos;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_sos = " ";
                if (strlen > 0)
                {
                    m_sos = value.Substring(0, strlen);
                }
            }
        }

        /// <value>Property for addr_type</value>
        public string addr_type
        {
            get => m_addr_type;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_addr_type = " ";
                if (strlen > 0)
                {
                    m_addr_type = value.Substring(0, strlen);
                }
            }
        }

        /// <value>Property for filler01</value>
        public string filler01
        {
            get => m_filler01;
            set
            {
                int strlen = value.Length;
                if (strlen > 4) strlen = 4;
                m_filler01 = "    ";
                if (strlen > 0)
                {
                    m_filler01 = value.Substring(0, strlen);
                }
            }
        }
    }
}
