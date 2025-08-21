using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace GeoXWrapperLib.Model
{
    public class Sanborn
    {
        private string m_boro;
        private string m_volume;
        private string m_volume_suffix;
        private string m_page;
        private string m_page_suffix;

        // Constructor for Sanborn
        public Sanborn()
        {
            m_boro = new string(' ', 1);
            m_volume = new string(' ', 2);
            m_volume_suffix = new string(' ', 1);
            m_page = new string(' ', 3);
            m_page_suffix = new string(' ', 1);
        }

        // Constructor for Sanborn with an input string
        public Sanborn(string inString) => SanbornFromString(inString);
        

        // Clear reinitializes the Sanborn object to spaces
        public void Clear()
        {
            SanbornFromString(new string(' ', 8));
        }

        // ToString converts a Sanborn object to a string
        public override string ToString() => SanbornToString();
        

        // FromString converts a string to a Sanborn object
        public void FromString(string inString)
        {
            SanbornFromString(inString);
        }

        // ToXml converts a Sanborn object to an XML document
        public void ToXml(ref XmlDocument indoc)
        {
            using (MemoryStream xmlStream = new MemoryStream())
            {
                XmlSerializer xmlFormatter = new XmlSerializer(typeof(Sanborn));
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

        // SanbornToString converts a Sanborn object to a string
        public string SanbornToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(m_boro);
            sb.Append(m_volume);
            sb.Append(m_volume_suffix);
            sb.Append(m_page);
            sb.Append(m_page_suffix);
            return sb.ToString();
        }

        // SanbornFromString converts a string to a Sanborn object
        public void SanbornFromString(string inString)
        {
            boro = inString.Substring(0, 1);
            volume = inString.Substring(1, 2);
            volume_suffix = inString.Substring(3, 1);
            page = inString.Substring(4, 3);
            page_suffix = inString.Substring(7, 1);
        }

        // Display creates a string of Sanborn field values separated by a character
        public string Display(char c)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(m_boro);
            sb.Append(c);
            sb.Append(m_volume);
            sb.Append(c);
            sb.Append(m_volume_suffix);
            sb.Append(c);
            sb.Append(m_page);
            sb.Append(c);
            sb.Append(m_page_suffix);
            return sb.ToString();
        }

        // Display creates a string of Sanborn field values separated by a dash
        public string Display() => Display('-');
        

        // Print creates a string with Sanborn field names and values
        public string Print()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("boro = {0}{1}", m_boro, Environment.NewLine);
            sb.AppendFormat("volume = {0}{1}", m_volume, Environment.NewLine);
            sb.AppendFormat("volume_suffix = {0}{1}", m_volume_suffix, Environment.NewLine);
            sb.AppendFormat("page = {0}{1}", m_page, Environment.NewLine);
            sb.AppendFormat("page_suffix = {0}{1}", m_page_suffix, Environment.NewLine);
            return sb.ToString();
        }

        // Property for boro
        public string boro
        {
            get => m_boro; 
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_boro = " ";
                if (strlen > 0)
                    m_boro = value.Substring(0, strlen);
            }
        }

        // Property for volume
        public string volume
        {
            get => m_volume; 
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_volume = "  ";
                if (strlen > 0)
                    m_volume = value.Substring(0, strlen);
            }
        }

        // Property for volume_suffix
        public string volume_suffix
        {
            get => m_volume_suffix; 
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_volume_suffix = " ";
                if (strlen > 0)
                    m_volume_suffix = value.Substring(0, strlen);
            }
        }

        // Property for page
        public string page
        {
            get => m_page; 
            set
            {
                int strlen = value.Length;
                if (strlen > 3) strlen = 3;
                m_page = "   ";
                if (strlen > 0)
                    m_page = value.Substring(0, strlen);
            }
        }

        // Property for page_suffix
        public string page_suffix
        { 
            get => m_page_suffix; 
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_page_suffix = " ";
                if (strlen > 0)
                    m_page_suffix = value.Substring(0, strlen);
            }
        }
    }
}
