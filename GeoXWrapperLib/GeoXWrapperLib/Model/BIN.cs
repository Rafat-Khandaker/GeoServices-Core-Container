using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace GeoXWrapperLib.Model
{
    public class BIN
    {
        private string m_boro;
        private string m_binnum;

        /// <summary>Constructor for BIN</summary>
        public BIN()
        {
            m_boro = new string(' ', 1);
            m_binnum = new string(' ', 6);
        }

        /// <summary>Constructor for BIN</summary>
        public BIN(string inString)
        {
            BINFromString(inString);
        }

        /// <summary>Clear reinitializes the BIN object to spaces</summary>
        public void Clear()
        {
            BINFromString(new string(' ', 7));
        }

        /// <summary>ToString converts a BIN object to a string</summary>
        public override string ToString()
        {
            return BINToString();
        }

        /// <summary>FromString converts a string to a BIN object</summary>
        public void FromString(string inString)
        {
            BINFromString(inString);
        }

        /// <summary>ToXml converts a BIN object to an XML document</summary>
        public void ToXml(ref XmlDocument indoc)
        {
            using (var xmlStream = new MemoryStream())
            {
                var xmlFormatter = new XmlSerializer(typeof(BIN));
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

        /// <summary>BINToString converts a BIN object to a string</summary>
        public string BINToString()
        {
            var sb = new StringBuilder();
            sb.Append(m_boro);
            sb.Append(m_binnum);

            return sb.ToString();
        }

        /// <summary>BINFromString converts a string to a BIN object</summary>
        public void BINFromString(string inString)
        {
            if (inString.Length >= 7)
            {
                m_boro = inString.Substring(0, 1);
                m_binnum = inString.Substring(1, 6);
            }
        }

        /// <summary>Display creates a string of BIN field values separated by a character</summary>
        public string Display(char c)
        {
            var sb = new StringBuilder();
            sb.Append(m_boro);
            sb.Append(c);
            sb.Append(m_binnum);

            return sb.ToString();
        }

        /// <summary>Display creates a string of BIN field values separated by a dash</summary>
        public string Display()
        {
            return Display('-');
        }

        /// <summary>Print creates a string with BIN field names and values</summary>
        public string Print()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("boro = {0}\n", m_boro);
            sb.AppendFormat("binnum = {0}\n", m_binnum);

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
                m_boro = " ";
                if (strlen > 0)
                {
                    m_boro = value.Substring(0, strlen);
                }
            }
        }

        /// <value>Property for binnum</value>
        public string binnum
        {
            get => m_binnum;
            set
            {
                int strlen = value.Length;
                if (strlen > 6) strlen = 6;
                m_binnum = "      ";
                if (strlen > 0)
                {
                    m_binnum = "000000";
                    m_binnum = m_binnum.Substring(0, 6 - strlen) + value.Substring(0, strlen);
                }
            }
        }
    }

}
