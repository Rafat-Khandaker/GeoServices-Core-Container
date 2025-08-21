using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace GeoXWrapperLib.Model
{
    public class BusArea
    {
        private string m_boro;
        private string m_district_number;

        /// <summary>
        /// Constructor for <c>BusArea</c>
        /// </summary>
        public BusArea()
        {
            m_boro = new string(' ', 1);
            m_district_number = new string(' ', 4);
        }

        /// <summary>
        /// Constructor for <c>BusArea</c> with string input
        /// </summary>
        public BusArea(string inString)
        {
            BusAreaFromString(inString);
        }

        /// <summary>
        /// <c>Clear</c> reinitializes the <c>BusArea</c> object to spaces
        /// </summary>
        public void Clear()
        {
            BusAreaFromString(new string(' ', 5));
        }

        /// <summary>
        /// <c>ToString</c> converts a <c>BusArea</c> object to a string
        /// </summary>
        public override string ToString()
        {
            return BusAreaToString();
        }

        /// <summary>
        /// <c>FromString</c> converts a string to a <c>BusArea</c> object
        /// </summary>
        public void FromString(string inString)
        {
            BusAreaFromString(inString);
        }

        /// <summary>
        /// <c>ToXml</c> converts a <c>BusArea</c> object to an XML document
        /// </summary>
        public void ToXml(ref XmlDocument indoc)
        {
            using (MemoryStream xmlStream = new MemoryStream())
            {
                XmlSerializer xmlFormatter = new XmlSerializer(typeof(BusArea));
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

        /// <summary>
        /// <c>BusAreaToString</c> converts a <c>BusArea</c> object to a string
        /// </summary>
        public string BusAreaToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(m_boro);
            sb.Append(m_district_number);
            return sb.ToString();
        }

        /// <summary>
        /// <c>BusAreaFromString</c> converts a string to a <c>BusArea</c> object
        /// </summary>
        public void BusAreaFromString(string inString)
        {
            if (inString.Length >= 5)
            {
                m_boro = inString.Substring(0, 1);
                m_district_number = inString.Substring(1, 4);
            }
        }

        /// <summary>
        /// <c>Display</c> creates a string of <c>BusArea</c> field values separated by a character
        /// </summary>
        public string Display(char c)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(m_boro);
            sb.Append(c);
            sb.Append(m_district_number);
            return sb.ToString();
        }

        /// <summary>
        /// <c>Display</c> creates a string of <c>BusArea</c> field values separated by a dash
        /// </summary>
        public string Display()
        {
            return Display('-');
        }

        /// <summary>
        /// <c>Print</c> creates a string with <c>BusArea</c> field names and values
        /// </summary>
        public string Print()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("boro = {0}{1}", m_boro, Environment.NewLine);
            sb.AppendFormat("district_number = {0}{1}", m_district_number, Environment.NewLine);
            return sb.ToString();
        }

        /// <value>Property for boro</value>
        public string boro
        {
            get { return m_boro; }
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_boro = new string(' ', 1);
                if (strlen > 0)
                {
                    m_boro = value.Substring(0, strlen);
                }
            }
        }

        /// <value>Property for district_number</value>
        public string district_number
        {
            get { return m_district_number; }
            set
            {
                int strlen = value.Length;
                if (strlen > 4) strlen = 4;
                m_district_number = new string(' ', 4);
                if (strlen > 0)
                {
                    m_district_number = value.Substring(0, strlen);
                }
            }
        }
    }

}
