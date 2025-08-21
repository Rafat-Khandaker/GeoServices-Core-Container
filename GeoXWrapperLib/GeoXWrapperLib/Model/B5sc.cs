using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace GeoXWrapperLib.Model
{
    public class B5sc
    {
        private string m_boro;
        private string m_sc5;

        /// <summary>Constructor for B5sc</summary>
        public B5sc()
        {
            m_boro = new string(' ', 1);
            m_sc5 = new string(' ', 5);
        }

        /// <summary>Constructor for B5sc</summary>
        public B5sc(string inString)
        {
            B5scFromString(inString);
        }

        /// <summary>Clear reinitializes the B5sc object to spaces</summary>
        public void Clear()
        {
            B5scFromString(new string(' ', 6));
        }

        /// <summary>ToString converts a B5sc object to a string</summary>
        public override string ToString()
        {
            return B5scToString();
        }

        /// <summary>FromString converts a string to a B5sc object</summary>
        public void FromString(string inString)
        {
            B5scFromString(inString);
        }

        /// <summary>ToXml converts a B5sc object to an XML document</summary>
        public void ToXml(ref XmlDocument indoc)
        {
            using (var xmlStream = new MemoryStream())
            {
                var xmlFormatter = new XmlSerializer(typeof(B5sc));
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

        /// <summary>B5scToString converts a B5sc object to a string</summary>
        public string B5scToString()
        {
            var sb = new StringBuilder();
            sb.Append(m_boro);
            sb.Append(m_sc5);

            return sb.ToString();
        }

        /// <summary>B5scFromString converts a string to a B5sc object</summary>
        public void B5scFromString(string inString)
        {
            if (inString.Length >= 6)
            {
                try { m_boro = inString.Substring(0, 1); } catch { m_boro = string.Empty;  }
                try { m_sc5 = inString.Substring(1, 5); } catch { m_sc5 = string.Empty; }
            }
            else {
                m_boro = string.Empty;
                m_sc5 = string.Empty;
            }
        }

        /// <summary>Display creates a string of B5sc field values separated by a character</summary>
        public string Display(char c)
        {
            var sb = new StringBuilder();
            sb.Append(m_boro);
            sb.Append(c);
            sb.Append(m_sc5);

            return sb.ToString();
        }

        /// <summary>Display creates a string of B5sc field values separated by a dash</summary>
        public string Display()
        {
            return Display('-');
        }

        /// <summary>Print creates a string with B5sc field names and values</summary>
        public string Print()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("boro = {0}\n", m_boro);
            sb.AppendFormat("sc5 = {0}\n", m_sc5);

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
    }
}
