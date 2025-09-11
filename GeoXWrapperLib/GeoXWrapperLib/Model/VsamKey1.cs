using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace GeoXWrapperLib.Model
{
    public class VsamKey1
    {
        private string m_record_type;
        private B5sc m_b5sc;
        private string m_parity;
        private string m_hi_hns;
        private string m_filler;

        // Constructor for VsamKey1
        public VsamKey1()
        {
            m_record_type = new string(' ', 2);
            m_b5sc = new B5sc();
            m_parity = new string(' ', 1);
            m_hi_hns = new string(' ', 11);
            m_filler = new string(' ', 1);
        }

        // Constructor for VsamKey1 with string input
        public VsamKey1(string inString) => VsamKey1FromString(inString);

        // Clear the object to spaces
        public void Clear() => VsamKey1FromString(new string(' ', 21));

        // Convert object to string
        public override string ToString() => VsamKey1ToString();

        // Convert string to object
        public void FromString(string inString) => VsamKey1FromString(inString);

        // Convert object to XML
        public void ToXml(ref XmlDocument indoc)
        {
            using (var xmlStream = new MemoryStream())
            {
                var xmlFormatter = new XmlSerializer(typeof(VsamKey1));
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

        // Convert object to string
        public string VsamKey1ToString() =>
            m_record_type + m_b5sc.B5scToString() + m_parity + m_hi_hns + m_filler;

        // Convert string to object
        public void VsamKey1FromString(string inString)
        {
            try { record_type = inString.Substring(0, 2); } catch (Exception e) { record_type = string.Empty; }
            try { b5sc = new B5sc(inString.Substring(2, 6)); } catch (Exception e) { b5sc = new B5sc(); }
            try { parity = inString.Substring(8, 1); } catch (Exception e) { parity = string.Empty; }
            try { hi_hns = inString.Substring(9, 11); } catch (Exception e) { hi_hns = string.Empty; }
            try { filler = inString.Substring(20, 1); } catch (Exception e) { filler = string.Empty; }
        }

        // Display fields with separator
        public string Display(char separator) =>
            m_record_type + separator + m_b5sc.Display() + separator + m_parity + separator + m_hi_hns + separator + m_filler;

        // Display fields with default separator '-'
        public string Display() => Display('-');

        // Print field names and values
        public string Print()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("record_type = {0}\n", m_record_type);
            sb.AppendFormat("b5sc = {0}\n", m_b5sc.Display());
            sb.AppendFormat("parity = {0}\n", m_parity);
            sb.AppendFormat("hi_hns = {0}\n", m_hi_hns);
            sb.AppendFormat("filler = {0}\n", m_filler);
            return sb.ToString();
        }

        // Property for b5sc
        public B5sc b5sc
        {
            get => m_b5sc;
            set => m_b5sc = value;
        }
        // Property for filler
        public string filler
        {
            get => m_filler;
            set
            {
                var strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_filler = " ";
                if (strlen > 0) m_filler = value.Substring(0, strlen);
            }
        }

        // Property for hi_hns
        public string hi_hns
        {
            get => m_hi_hns;
            set
            {
                var strlen = value.Length;
                if (strlen > 11) strlen = 11;
                m_hi_hns = new string(' ', 11);
                if (strlen > 0) m_hi_hns = value.Substring(0, strlen);
            }
        }
        // Property for parity
        public string parity
        {
            get => m_parity;
            set
            {
                var strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_parity = new string(' ', 1);
                if (strlen > 0) m_parity = value.Substring(0, strlen);
            }
        }

        // Property for record_type
        public string record_type
        {
            get => m_record_type;
            set
            {
                var strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_record_type = new string(' ', 2);
                if (strlen > 0) m_record_type = value.Substring(0, strlen);
            }
        }

    }
}
