using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace GeoXWrapperLib.Model
{
    public class UNIT
    {
        private string m_unit_type;
        private string m_unit_identifier;

        /// <summary>Constructor for Unit</summary>
        public UNIT()
        {
            m_unit_type = new string(' ', 4);
            m_unit_identifier = new string(' ', 10);
        }

        /// <summary>Constructor for Unit</summary>
        public UNIT(string inString)
        {
            UnitFromString(inString);
        }

        /// <summary>Clear reinitializes the Unit object to spaces</summary>
        public void Clear()
        {
            UnitFromString(new string(' ', 14));
        }

        /// <summary>ToString converts a Unit object to a string</summary>
        public override string ToString()
        {
            return UnitToString();
        }

        /// <summary>FromString converts a string to a Unit object</summary>
        public void FromString(string inString)
        {
            UnitFromString(inString);
        }

        /// <summary>ToXml converts a Unit object to an XML document</summary>
        public void ToXml(ref XmlDocument indoc)
        {
            using (var xmlStream = new MemoryStream())
            {
                var xmlFormatter = new XmlSerializer(typeof(UNIT));
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

        /// <summary>UnitToString converts a Unit object to a string</summary>
        public string UnitToString()
        {
            var sb = new StringBuilder();
            sb.Append(m_unit_type);
            sb.Append(m_unit_identifier);
            return sb.ToString();
        }

        /// <summary>UnitFromString converts a string to a Unit object</summary>
        public void UnitFromString(string inString)
        {
            if (inString.Length >= 14)
            {
                m_unit_type = inString.Substring(0, 4);
                m_unit_identifier = inString.Substring(4, 10);
            }
        }

        /// <summary>Display creates a string of Unit field values separated by a character</summary>
        public string Display(char c)
        {
            var sb = new StringBuilder();
            sb.Append(m_unit_type);
            sb.Append(c);
            sb.Append(m_unit_identifier);
            return sb.ToString();
        }

        /// <summary>Display creates a string of Unit field values separated by a dash</summary>
        public string Display()
        {
            return Display('-');
        }

        /// <summary>Print creates a string with Unit field names and values</summary>
        public string Print()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("unit_type = {0}\n", m_unit_type);
            sb.AppendFormat("unit_identifier = {0}\n", m_unit_identifier);
            return sb.ToString();
        }

        /// <value>Property for unit_type</value>
        public string unit_type
        {
            get => m_unit_type;
            set
            {
                int strlen = value.Length;
                if (strlen > 4) strlen = 4;
                m_unit_type = "    ";
                if (strlen > 0)
                {
                    m_unit_type = value.Substring(0, strlen);
                }
            }
        }

        /// <value>Property for unit_identifier</value>
        public string unit_identifier
        {
            get => m_unit_identifier;
            set
            {
                int strlen = value.Length;
                if (strlen > 10) strlen = 10;
                m_unit_identifier = "          ";
                if (strlen > 0)
                {
                    m_unit_identifier = "          ";
                    m_unit_identifier = m_unit_identifier.Substring(0, 10 - strlen) + value.Substring(0, strlen);
                }
            }
        }
    }
}
