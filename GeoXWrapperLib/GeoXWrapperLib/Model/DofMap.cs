using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace GeoXWrapperLib.Model
{
    public class DofMap
    {
        private string m_boro;
        private string m_sectionVolume;
        private string m_page;

        /// <summary>Constructor for <c>DofMap</c></summary>
        public DofMap()
        {
            m_boro = new string(' ', 1);
            m_sectionVolume = new string(' ', 4);
            m_page = new string(' ', 4);
        }

        /// <summary>Constructor for <c>DofMap</c></summary>
        public DofMap(string inString)
        {
            DofMapFromString(inString);
        }

        /// <summary><c>Clear</c> reinitializes the <c>DofMap</c> object to spaces</summary>
        public void Clear()
        {
            DofMapFromString(new string(' ', 9));
        }

        /// <summary><c>ToString</c> converts a <c>DofMap</c> object to a string</summary>
        public override string ToString()
        {
            return DofMapToString();
        }

        /// <summary><c>FromString</c> converts a string to a <c>DofMap</c> object</summary>
        public void FromString(string inString)
        {
            DofMapFromString(inString);
        }

        /// <summary><c>ToXml</c> converts a <c>DofMap</c> object to an XML document</summary>
        public void ToXml(ref XmlDocument indoc)
        {
            using (MemoryStream xmlStream = new MemoryStream())
            {
                XmlSerializer xmlFormatter = new XmlSerializer(typeof(DofMap));
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

        /// <summary><c>DofMapToString</c> converts a <c>DofMap</c> object to a string</summary>
        public string DofMapToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(m_boro);
            sb.Append(m_sectionVolume);
            sb.Append(m_page);

            return sb.ToString();
        }

        /// <summary><c>DofMapFromString</c> converts a string to a <c>DofMap</c> object</summary>
        public void DofMapFromString(string inString)
        {
            m_boro = inString.Substring(0, 1);
            m_sectionVolume = inString.Substring(1, 4);
            m_page = inString.Substring(5, 4);
        }

        /// <summary><c>Display</c> creates a string of <c>DofMap</c> field values separated by a character</summary>
        public string Display(char c)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(m_boro);
            sb.Append(c);
            sb.Append(m_sectionVolume);
            sb.Append(c);
            sb.Append(m_page);

            return sb.ToString();
        }

        /// <summary><c>Display</c> creates a string of <c>DofMap</c> field values separated by a dash</summary>
        public string Display()
        {
            return Display('-');
        }

        /// <summary><c>Print</c> creates a string with <c>DofMap</c> field names and values</summary>
        public string Print()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("boro = {0}{1}", m_boro, Environment.NewLine);
            sb.AppendFormat("section_volume = {0}{1}", m_sectionVolume, Environment.NewLine);
            sb.AppendFormat("page = {0}{1}", m_page, Environment.NewLine);

            return sb.ToString();
        }

        /// <summary><value>Property for boro</value></summary>
        public string boro
        {
            get { return m_boro; }
            set
            {
                m_boro = value.Length > 1 ? value.Substring(0, 1) : value.PadRight(1, ' ');
            }
        }

        /// <summary><value>Property for section_volume</value></summary>
        public string section_volume
        {
            get { return m_sectionVolume; }
            set
            {
                m_sectionVolume = value.Length > 4 ? value.Substring(0, 4) : value.PadRight(4, ' ');
            }
        }

        /// <summary><value>Property for page</value></summary>
        public string page
        {
            get { return m_page; }
            set
            {
                m_page = value.Length > 4 ? value.Substring(0, 4) : value.PadRight(4, ' ');
            }
        }
    }
}
