using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace GeoXWrapperLib.Model
{
    public class B7sc
    {
        private string m_boro;
        private string m_sc5;
        private string m_lgc;

        /// <summary>Constructor for B7sc</summary>
        public B7sc()
        {
            m_boro = new string(' ', 1);
            m_sc5 = new string(' ', 5);
            m_lgc = new string(' ', 2);
        }

        /// <summary>Constructor for B7sc</summary>
        public B7sc(string inString)
        {
            B7scFromString(inString);
        }

        /// <summary>Clear reinitializes the B7sc object to spaces</summary>
        public void Clear()
        {
            B7scFromString(new string(' ', 8));
        }

        /// <summary>ToString converts a B7sc object to a string</summary>
        public override string ToString()
        {
            return B7scToString();
        }

        /// <summary>FromString converts a string to a B7sc object</summary>
        public void FromString(string inString)
        {
            B7scFromString(inString);
        }

        /// <summary>ToXml converts a B7sc object to an XML document</summary>
        public void ToXml(ref XmlDocument indoc)
        {
            using (var xmlStream = new MemoryStream())
            {
                var xmlFormatter = new XmlSerializer(typeof(B7sc));
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

        /// <summary>B7scToString converts a B7sc object to a string</summary>
        public string B7scToString()
        {
            var sb = new StringBuilder();
            sb.Append(m_boro);
            sb.Append(m_sc5);
            sb.Append(m_lgc);

            return sb.ToString();
        }

        /// <summary>B7scFromString converts a string to a B7sc object</summary>
        public void B7scFromString(string inString)
        {
            if (inString.Length >= 8)
            {
                m_boro = inString.Substring(0, 1);
                m_sc5 = inString.Substring(1, 5);
                m_lgc = inString.Substring(6, 2);
            }
        }

        /// <summary>Display creates a string of B7sc field values separated by a character</summary>
        public string Display(char c)
        {
            var sb = new StringBuilder();
            sb.Append(m_boro);
            sb.Append(c);
            sb.Append(m_sc5);
            sb.Append(c);
            sb.Append(m_lgc);

            return sb.ToString();
        }

        /// <summary>Display creates a string of B7sc field values separated by a dash</summary>
        public string Display()
        {
            return Display('-');
        }

        /// <summary>Print creates a string with B7sc field names and values</summary>
        public string Print()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("boro = {0}\n", m_boro);
            sb.AppendFormat("sc5 = {0}\n", m_sc5);
            sb.AppendFormat("lgc = {0}\n", m_lgc);

            return sb.ToString();
        }

        /// <value>Property for boro</value>
        public string boro
        {
            get => m_boro;
            set
            {
                var strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_boro = " ";
                if (strlen > 0)
                {
                    m_boro = value.Substring(0, strlen);
                }
            }
        }

        /// <value>Property for sc5</value>
        public string sc5
        {
            get => m_sc5;
            set
            {
                var strlen = value.Length;
                if (strlen > 5) strlen = 5;
                m_sc5 = "     ";
                if (strlen > 0)
                {
                    m_sc5 = new string('0', 5);
                    m_sc5 = m_sc5.Substring(0, 5 - strlen) + value.Substring(0, strlen);
                }
            }
        }

        /// <value>Property for lgc</value>
        public string lgc
        {
            get => m_lgc;
            set
            {
                var strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_lgc = "  ";
                if (strlen > 0)
                {
                    m_lgc = "00";
                    m_lgc = m_lgc.Substring(0, 2 - strlen) + value.Substring(0, strlen);
                }
            }
        }
    }
}
