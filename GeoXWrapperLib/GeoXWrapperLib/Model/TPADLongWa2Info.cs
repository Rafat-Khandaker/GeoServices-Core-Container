using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace GeoXWrapperLib.Model
{
    public class TPADLongWa2Info
    {
        // Private fields
        private BIN m_bin;
        private string m_TPAD_bin_status;

        // Default constructor
        public TPADLongWa2Info()
        {
            m_bin = new BIN();
            m_TPAD_bin_status = new string(' ', 1);
        }

        // Constructor that takes a string
        public TPADLongWa2Info(string inString)
        {
            TPADLongWa2InfoFromString(inString);
        }

        // Clears the object by setting fields to spaces
        public void Clear()
        {
            TPADLongWa2InfoFromString(new string(' ', 8));
        }

        // Converts the object to a string
        public override string ToString()
        {
            return TPADLongWa2InfoToString();
        }

        // Converts a string to a TPADLongWa2Info object
        public void FromString(string inString)
        {
            TPADLongWa2InfoFromString(inString);
        }

        // Converts the object to an XML document
        public void ToXml(ref XmlDocument indoc)
        {
            using (MemoryStream xmlStream = new MemoryStream())
            {
                try
                {
                    var xmlFormatter = new XmlSerializer(typeof(TPADLongWa2Info));
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

        // Converts the object to a string
        public string TPADLongWa2InfoToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(m_bin.BINToString());
            sb.Append(m_TPAD_bin_status);

            return sb.ToString();
        }

        // Converts a string to the object
        public void TPADLongWa2InfoFromString(string inString)
        {
            m_bin = new BIN(inString.Substring(0, 7));
            m_TPAD_bin_status = inString.Substring(7, 1);
        }

        // Display function with a custom separator
        public string Display(char c)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(m_bin.Display());
            sb.Append(c);
            sb.Append(m_TPAD_bin_status);
            sb.Append(c);

            return sb.ToString();
        }

        // Display function with default separator "-"
        public string Display()
        {
            return Display('-');
        }

        // Prints the field names and values
        public string Print()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("bin = {0}{1}", m_bin.Display(), Environment.NewLine);
            sb.AppendFormat("TPAD_bin_status = {0}{1}", m_TPAD_bin_status, Environment.NewLine);

            return sb.ToString();
        }

        // Property for Bin
        public BIN bin
        {
            get { return m_bin; }
            set { m_bin = value; }
        }

        // Property for TPAD_bin_status
        public string TPAD_bin_status
        {
            get { return m_TPAD_bin_status; }
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_TPAD_bin_status = " ";
                if (strlen > 0)
                {
                    m_TPAD_bin_status = value.Substring(0, strlen);
                }
            }
        }
    }
}
