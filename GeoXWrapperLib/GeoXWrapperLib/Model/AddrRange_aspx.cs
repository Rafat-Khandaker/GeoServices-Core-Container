using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace GeoXWrapperLib.Model
{
    public class AddrRange_apx
    {
        private string m_lhnd;
        private string m_hhnd;
        private B7sc m_b7sc;
        private BIN m_bin;
        private string m_sos;
        private string m_addrType;
        private string m_filler01;
        private string m_stname;
        private string m_filler02;

        public AddrRange_apx()
        {
            m_lhnd = new string(' ', 16);
            m_hhnd = new string(' ', 16);
            m_b7sc = new B7sc();
            m_bin = new BIN();
            m_sos = new string(' ', 1);
            m_addrType = new string(' ', 1);
            m_filler01 = new string(' ', 1);
            m_stname = new string(' ', 32);
            m_filler02 = new string(' ', 34);
        }

        public AddrRange_apx(string inString)
        {
            AddrRange_apxFromString(inString);
        }

        public void Clear()
        {
            AddrRange_apxFromString(new string(' ', 116));
        }

        public override string ToString()
        {
            return AddrRange_apxToString();
        }

        public void FromString(string inString)
        {
            AddrRange_apxFromString(inString);
        }

        public void ToXml(ref XmlDocument indoc)
        {
            using (var xmlStream = new MemoryStream())
            {
                var xmlFormatter = new XmlSerializer(typeof(AddrRange_apx));
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

        public string AddrRange_apxToString()
        {
            var sb = new StringBuilder();
            sb.Append(m_lhnd);
            sb.Append(m_hhnd);
            sb.Append(m_b7sc.B7scToString());
            sb.Append(m_bin.BINToString());
            sb.Append(m_sos);
            sb.Append(m_addrType);
            sb.Append(m_filler01);
            sb.Append(m_stname);
            sb.Append(m_filler02);
            return sb.ToString();
        }

        public void AddrRange_apxFromString(string inString)
        {
            try { m_lhnd = inString.Substring(0, 16); } catch { m_lhnd = string.Empty; }
            try { m_hhnd = inString.Substring(16, 16); } catch { m_hhnd = string.Empty; }
            try { m_b7sc = new B7sc(inString.Substring(32, 8)); } catch { m_b7sc = new B7sc(); }
            try { m_bin = new BIN(inString.Substring(40, 7)); } catch { m_bin = new BIN(); }

            try { m_sos = inString.Substring(47, 1); } catch { m_sos = string.Empty; }
            try { m_addrType = inString.Substring(48, 1); } catch { m_addrType = string.Empty; }
            try { m_filler01 = inString.Substring(49, 1); } catch { m_filler01 = string.Empty; }
            try { m_stname = inString.Substring(50, 32); } catch { m_lhnd = string.Empty; }
            try { m_lhnd = inString.Substring(0, 16); } catch { m_lhnd = string.Empty; }
            try { m_lhnd = inString.Substring(0, 16); } catch { m_lhnd = string.Empty; }
            try { m_lhnd = inString.Substring(0, 16); } catch { m_lhnd = string.Empty; }
            try { m_lhnd = inString.Substring(0, 16); } catch { m_lhnd = string.Empty; }
            
        }

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
            sb.Append(m_addrType);
            sb.Append(separator);
            sb.Append(m_filler01);
            sb.Append(separator);
            sb.Append(m_stname);
            sb.Append(separator);
            sb.Append(m_filler02);
            sb.Append(separator);
            return sb.ToString();
        }

        public string Display()
        {
            return Display('-');
        }

        public string Print()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("lhnd = {0}{1}", m_lhnd, Environment.NewLine);
            sb.AppendFormat("hhnd = {0}{1}", m_hhnd, Environment.NewLine);
            sb.AppendFormat("b7sc = {0}{1}", m_b7sc.Display(), Environment.NewLine);
            sb.AppendFormat("bin = {0}{1}", m_bin.Display(), Environment.NewLine);
            sb.AppendFormat("sos = {0}{1}", m_sos, Environment.NewLine);
            sb.AppendFormat("addrType = {0}{1}", m_addrType, Environment.NewLine);
            sb.AppendFormat("filler01 = {0}{1}", m_filler01, Environment.NewLine);
            sb.AppendFormat("stname = {0}{1}", m_stname, Environment.NewLine);
            sb.AppendFormat("filler02 = {0}{1}", m_filler02, Environment.NewLine);
            return sb.ToString();
        }

        public string lhnd
        {
            get { return m_lhnd; }
            set
            {
                int length = Math.Min(value.Length, 16);
                m_lhnd = new string(' ', 16);
                if (length > 0)
                {
                    m_lhnd = value.Substring(0, length).PadRight(16, ' ');
                }
            }
        }

        public string hhnd
        {
            get { return m_hhnd; }
            set
            {
                int length = Math.Min(value.Length, 16);
                m_hhnd = new string(' ', 16);
                if (length > 0)
                {
                    m_hhnd = value.Substring(0, length).PadRight(16, ' ');
                }
            }
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
            set
            {
                int length = Math.Min(value.Length, 1);
                m_sos = new string(' ', 1);
                if (length > 0)
                {
                    m_sos = value.Substring(0, length).PadRight(1, ' ');
                }
            }
        }

        public string addr_type
        {
            get { return m_addrType; }
            set
            {
                int length = Math.Min(value.Length, 1);
                m_addrType = new string(' ', 1);
                if (length > 0)
                {
                    m_addrType = value.Substring(0, length).PadRight(1, ' ');
                }
            }
        }

        public string filler01
        {
            get { return m_filler01; }
            set
            {
                int length = Math.Min(value.Length, 1);
                m_filler01 = new string(' ', 1);
                if (length > 0)
                {
                    m_filler01 = value.Substring(0, length).PadRight(1, ' ');
                }
            }
        }

        public string stname
        {
            get { return m_stname; }
            set
            {
                int length = Math.Min(value.Length, 32);
                m_stname = new string(' ', 32);
                if (length > 0)
                {
                    m_stname = value.Substring(0, length).PadRight(32, ' ');
                }
            }
        }

        public string filler02
        {
            get { return m_filler02; }
            set
            {
                int length = Math.Min(value.Length, 34);
                m_filler02 = new string(' ', 34);
                if (length > 0)
                {
                    m_filler02 = value.Substring(0, length).PadRight(34, ' ');
                }
            }
        }
    }
}
