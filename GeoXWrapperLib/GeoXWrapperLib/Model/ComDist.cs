using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace GeoXWrapperLib.Model
{
    public class ComDist
    {
        private string m_boro;
        private string m_district_number;

        /// <summary>
        /// Constructor for <c>ComDist</c>
        /// </summary>
        public ComDist()
        {
            m_boro = new string(' ', 1);
            m_district_number = new string(' ', 2);
        }

        /// <summary>
        /// Constructor for <c>ComDist</c> with string input
        /// </summary>
        public ComDist(string inString) => ComDistFromString(inString);
        

        /// <summary>
        /// <c>Clear</c> reinitializes the <c>ComDist</c> object to spaces
        /// </summary>
        public void Clear() => ComDistFromString(new string(' ', 3));
        

        /// <summary>
        /// <c>ToString</c> converts a <c>ComDist</c> object to a string
        /// </summary>
        public override string ToString() => ComDistToString();
        

        /// <summary>
        /// <c>FromString</c> converts a string to a <c>ComDist</c> object
        /// </summary>
        public void FromString(string inString)
        {
            ComDistFromString(inString);
        }

        /// <summary>
        /// <c>ToXml</c> converts a <c>ComDist</c> object to an XML document
        /// </summary>
        public void ToXml(ref XmlDocument indoc)
        {
            using (MemoryStream xmlStream = new MemoryStream())
            {
                XmlSerializer xmlFormatter = new XmlSerializer(typeof(ComDist));
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
        /// <c>ComDistToString</c> converts a <c>ComDist</c> object to a string
        /// </summary>
        public string ComDistToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(m_boro);
            sb.Append(m_district_number);
            return sb.ToString();
        }

        /// <summary>
        /// <c>ComDistFromString</c> converts a string to a <c>ComDist</c> object
        /// </summary>
        public void ComDistFromString(string inString)
        {
            if (inString.Length >= 3)
            {
                m_boro = inString.Substring(0, 1);
                m_district_number = inString.Substring(1, 2);
            }
        }

        /// <summary>
        /// <c>Display</c> creates a string of <c>ComDist</c> field values separated by a character
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
        /// <c>Display</c> creates a string of <c>ComDist</c> field values separated by a dash
        /// </summary>
        public string Display() => Display('-');
        

        /// <summary>
        /// <c>Print</c> creates a string with <c>ComDist</c> field names and values
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
            get => m_boro; 
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
            get => m_district_number; 
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_district_number = new string(' ', 2);
                if (strlen > 0)
                {
                    m_district_number = value.Substring(0, strlen);
                }
            }
        }
    }
}
