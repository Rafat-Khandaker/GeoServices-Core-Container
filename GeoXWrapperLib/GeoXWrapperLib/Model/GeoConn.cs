using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GeoXWrapperLib.Model
{
    public class GeoConn
    {
        private string m_BrokerString = null;
        private string m_ServerString = null;

        /// <summary>
        /// Constructor for GeoConn object
        /// </summary>
        public GeoConn()
        {
            m_BrokerString = new string(' ', 80);
            m_ServerString = new string(' ', 80);
            BrokerString = "GDE";
        }

        /// <summary>
        /// Constructor for GeoConn object with a broker string
        /// </summary>
        public GeoConn(string bstr)
        {
            BrokerString = bstr;
            ServerString = string.Empty;
        }

        /// <summary>
        /// Constructor for GeoConn object with a broker and server string
        /// </summary>
        public GeoConn(string bstr, string sstr)
        {
            BrokerString = bstr;
            ServerString = sstr;
        }

        /// <summary>
        /// Gets or sets the broker string
        /// </summary>
        [XmlElement("Broker")]
        public string BrokerString
        {
            get => m_BrokerString; 
            set { m_BrokerString = value; }
        }

        /// <summary>
        /// Gets or sets the server string
        /// </summary>
        [XmlElement("Server")]
        public string ServerString
        {
            get => m_ServerString; 
            set { m_ServerString = value; }
        }
    }
}
