using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace GeoXWrapperLib.Model
{
    public class LionKey
    {
        private string m_boro;
        private string m_face_code;
        private string m_sequence_number;

        // Constructor for LionKey
        public LionKey()
        {
            m_boro = new string(' ', 1);
            m_face_code = new string(' ', 4);
            m_sequence_number = new string(' ', 5);
        }

        // Constructor for LionKey with an input string
        public LionKey(string inString)
        {
            LionKeyFromString(inString);
        }

        // Clear reinitializes the LionKey object to spaces
        public void Clear()
        {
            LionKeyFromString(new string(' ', 10));
        }

        // ToString converts a LionKey object to a string
        public override string ToString()
        {
            return LionKeyToString();
        }

        // FromString converts a string to a LionKey object
        public void FromString(string inString)
        {
            LionKeyFromString(inString);
        }

        // ToXml converts a LionKey object to an XML document
        public void ToXml(ref XmlDocument indoc)
        {
            using (MemoryStream xmlStream = new MemoryStream())
            {
                XmlSerializer xmlFormatter = new XmlSerializer(typeof(LionKey));
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

        // LionKeyToString converts a LionKey object to a string
        public string LionKeyToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(m_boro);
            sb.Append(m_face_code);
            sb.Append(m_sequence_number);
            return sb.ToString();
        }

        // LionKeyFromString converts a string to a LionKey object
        public void LionKeyFromString(string inString)
        {
            boro = inString.Substring(0, 1);
            face_code = inString.Substring(1, 4);
            sequence_number = inString.Substring(5, 5);
        }

        // Display creates a string of LionKey field values separated by a character
        public string Display(char c)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(m_boro);
            sb.Append(c);
            sb.Append(m_face_code);
            sb.Append(c);
            sb.Append(m_sequence_number);
            return sb.ToString();
        }

        // Display creates a string of LionKey field values separated by a dash
        public string Display()
        {
            return Display('-');
        }

        // Print creates a string with LionKey field names and values
        public string Print()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("boro = {0}{1}", m_boro, Environment.NewLine);
            sb.AppendFormat("face_code = {0}{1}", m_face_code, Environment.NewLine);
            sb.AppendFormat("sequence_number = {0}{1}", m_sequence_number, Environment.NewLine);
            return sb.ToString();
        }

        // Property for boro
        public string boro
        {
            get { return m_boro; }
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_boro = " ";
                if (strlen > 0)
                    m_boro = value.Substring(0, strlen);
            }
        }

        // Property for face_code
        public string face_code
        {
            get { return m_face_code; }
            set
            {
                int strlen = value.Length;
                if (strlen > 4) strlen = 4;
                m_face_code = "    ";
                if (strlen > 0)
                    m_face_code = value.Substring(0, strlen);
            }
        }

        // Property for sequence_number
        public string sequence_number
        {
            get { return m_sequence_number; }
            set
            {
                int strlen = value.Length;
                if (strlen > 5) strlen = 5;
                m_sequence_number = "     ";
                if (strlen > 0)
                    m_sequence_number = value.Substring(0, strlen);
            }
        }
    }
}
