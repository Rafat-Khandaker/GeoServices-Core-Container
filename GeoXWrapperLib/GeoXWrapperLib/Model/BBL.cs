using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperLib.Model
{
    using System;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;
    using System.IO;

    public class BBL
    {
        private string m_boro;
        private string m_block;
        private string m_lot;

        /// <summary>Constructor for BBL</summary>
        public BBL()
        {
            m_boro = new string(' ', 1);
            m_block = new string(' ', 5);
            m_lot = new string(' ', 4);
        }

        /// <summary>Constructor for BBL</summary>
        public BBL(string inString)
        {
            BBLFromString(inString);
        }

        /// <summary>Clear reinitializes the BBL object to spaces</summary>
        public void Clear()
        {
            BBLFromString(new string(' ', 10));
        }

        /// <summary>ToString converts a BBL object to a string</summary>
        public override string ToString()
        {
            return BBLToString();
        }

        /// <summary>FromString converts a string to a BBL object</summary>
        public void FromString(string inString)
        {
            BBLFromString(inString);
        }

        /// <summary>ToXml converts a BBL object to an XML document</summary>
        public void ToXml(ref XmlDocument indoc)
        {
            using (var xmlStream = new MemoryStream())
            {
                var xmlFormatter = new XmlSerializer(typeof(BBL));
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

        /// <summary>BBLToString converts a BBL object to a string</summary>
        public string BBLToString()
        {
            var sb = new StringBuilder();
            sb.Append(m_boro);
            sb.Append(m_block);
            sb.Append(m_lot);

            return sb.ToString();
        }

        /// <summary>BBLFromString converts a string to a BBL object</summary>
        public void BBLFromString(string inString)
        {
            if (inString.Length >= 10)
            {
                try { m_boro = inString.Substring(0, 1); } catch { m_boro = string.Empty; }
                try { m_block = inString.Substring(1, 5); } catch { m_block = string.Empty; }
                try { m_lot = inString.Substring(6, 4); } catch { m_lot = string.Empty; }
            }
        }

        /// <summary>Display creates a string of BBL field values separated by a character</summary>
        public string Display(char c)
        {
            var sb = new StringBuilder();
            sb.Append(m_boro);
            sb.Append(c);
            sb.Append(m_block);
            sb.Append(c);
            sb.Append(m_lot);

            return sb.ToString();
        }

        /// <summary>Display creates a string of BBL field values separated by a dash</summary>
        public string Display()
        {
            return Display('-');
        }

        /// <summary>Print creates a string with BBL field names and values</summary>
        public string Print()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("boro = {0}\n", m_boro);
            sb.AppendFormat("block = {0}\n", m_block);
            sb.AppendFormat("lot = {0}\n", m_lot);

            return sb.ToString();
        }

        /// <value>Property for block</value>
        public string block
        {
            get => m_block;
            set
            {
                int strlen = value.Length;
                if (strlen > 5) strlen = 5;
                m_block = "     ";
                if (strlen > 0)
                {
                    m_block = "00000";
                    m_block = m_block.Substring(0, 5 - strlen) + value.Substring(0, strlen);
                }
            }
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

        /// <value>Property for lot</value>
        public string lot
        {
            get => m_lot;
            set
            {
                int strlen = value.Length;
                if (strlen > 4) strlen = 4;
                m_lot = "    ";
                if (strlen > 0)
                {
                    m_lot = "0000";
                    m_lot = m_lot.Substring(0, 4 - strlen) + value.Substring(0, strlen);
                }
            }
        }
    }

}
