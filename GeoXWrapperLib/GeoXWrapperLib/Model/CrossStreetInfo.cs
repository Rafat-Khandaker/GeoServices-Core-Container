using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace GeoXWrapperLib.Model
{
    public class CrossStreetInfo
    {
        private string m_mh_ri_flag;
        private string m_distance;
        private string m_gap_flag;
        private string m_node_num;
        private string m_xstr_cnt;
        private B7sc[] m_xstr_b7sc_list = new B7sc[5];

        /// <summary>
        /// Constructor for <c>CrossStreetInfo</c>
        /// </summary>
        public CrossStreetInfo()
        {
            m_mh_ri_flag = new string(' ', 1);
            m_distance = new string(' ', 5);
            m_gap_flag = new string(' ', 1);
            m_node_num = new string(' ', 7);
            m_xstr_cnt = new string(' ', 1);

            for (int i = 0; i < 5; i++)
            {
                m_xstr_b7sc_list[i] = new B7sc();
            }
        }

        /// <summary>
        /// Constructor for <c>CrossStreetInfo</c> with string input
        /// </summary>
        public CrossStreetInfo(string inString)
        {
            CrossStreetInfoFromString(inString);
        }

        /// <summary>
        /// <c>Clear</c> reinitializes the <c>CrossStreetInfo</c> object to spaces
        /// </summary>
        public void Clear()
        {
            CrossStreetInfoFromString(new string(' ', 55));
        }

        /// <summary>
        /// <c>ToString</c> converts a <c>CrossStreetInfo</c> object to a string
        /// </summary>
        public override string ToString()
        {
            return CrossStreetInfoToString();
        }

        /// <summary>
        /// <c>FromString</c> converts a string to a <c>CrossStreetInfo</c> object
        /// </summary>
        public void FromString(string inString)
        {
            CrossStreetInfoFromString(inString);
        }

        /// <summary>
        /// <c>ToXml</c> converts a <c>CrossStreetInfo</c> object to an XML document
        /// </summary>
        public void ToXml(ref XmlDocument indoc)
        {
            using (MemoryStream xmlStream = new MemoryStream())
            {
                XmlSerializer xmlFormatter = new XmlSerializer(typeof(CrossStreetInfo));
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
        /// <c>CrossStreetInfoToString</c> converts a <c>CrossStreetInfo</c> object to a string
        /// </summary>
        public string CrossStreetInfoToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(m_mh_ri_flag);
            sb.Append(m_distance);
            sb.Append(m_gap_flag);
            sb.Append(m_node_num);
            sb.Append(m_xstr_cnt);

            for (int i = 0; i < 5; i++)
            {
                sb.Append(m_xstr_b7sc_list[i].B7scToString());
            }

            return sb.ToString();
        }

        /// <summary>
        /// <c>CrossStreetInfoFromString</c> converts a string to a <c>CrossStreetInfo</c> object
        /// </summary>
        public void CrossStreetInfoFromString(string inString)
        {
            if (inString.Length >= 55)
            {
                m_mh_ri_flag = inString.Substring(0, 1);
                m_distance = inString.Substring(1, 5);
                m_gap_flag = inString.Substring(6, 1);
                m_node_num = inString.Substring(7, 7);
                m_xstr_cnt = inString.Substring(14, 1);

                for (int i = 0; i < 5; i++)
                {
                    m_xstr_b7sc_list[i] = new B7sc(inString.Substring(15 + (i * 8), 8));
                }
            }
        }

        /// <summary>
        /// <c>Display</c> creates a string of <c>CrossStreetInfo</c> field values separated by a character
        /// </summary>
        public string Display(char c)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(m_mh_ri_flag);
            sb.Append(c);
            sb.Append(m_distance);
            sb.Append(c);
            sb.Append(m_gap_flag);
            sb.Append(c);
            sb.Append(m_node_num);
            sb.Append(c);
            sb.Append(m_xstr_cnt);
            sb.Append(c);

            for (int i = 0; i < 5; i++)
            {
                sb.Append(m_xstr_b7sc_list[i].Display());
                sb.Append(c);
            }

            return sb.ToString();
        }

        /// <summary>
        /// <c>Display</c> creates a string of <c>CrossStreetInfo</c> field values separated by a dash
        /// </summary>
        public string Display()
        {
            return Display('-');
        }

        /// <summary>
        /// <c>Print</c> creates a string with <c>CrossStreetInfo</c> field names and values
        /// </summary>
        public string Print()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("mh_ri_flag = {0}{1}", m_mh_ri_flag, Environment.NewLine);
            sb.AppendFormat("distance = {0}{1}", m_distance, Environment.NewLine);
            sb.AppendFormat("gap_flag = {0}{1}", m_gap_flag, Environment.NewLine);
            sb.AppendFormat("node_num = {0}{1}", m_node_num, Environment.NewLine);
            sb.AppendFormat("xstr_cnt = {0}{1}", m_xstr_cnt, Environment.NewLine);

            for (int i = 0; i < 5; i++)
            {
                sb.AppendFormat("xstr_b7sc_list({0}) = {1}{2}", i, m_xstr_b7sc_list[i].Display(), Environment.NewLine);
            }

            return sb.ToString();
        }

        /// <value>Property for mh_ri_flag</value>
        public string mh_ri_flag
        {
            get { return m_mh_ri_flag; }
            set
            {
                m_mh_ri_flag = value.Length > 0 ? value.Substring(0, 1) : " ";
            }
        }

        /// <value>Property for distance</value>
        public string distance
        {
            get { return m_distance; }
            set
            {
                m_distance = value.Length > 5 ? value.Substring(0, 5) : value.PadRight(5, ' ');
            }
        }

        /// <value>Property for gap_flag</value>
        public string gap_flag
        {
            get { return m_gap_flag; }
            set
            {
                m_gap_flag = value.Length > 0 ? value.Substring(0, 1) : " ";
            }
        }

        /// <value>Property for node_num</value>
        public string node_num
        {
            get { return m_node_num; }
            set
            {
                m_node_num = value.Length > 7 ? value.Substring(0, 7) : value.PadRight(7, ' ');
            }
        }

        /// <value>Property for xstr_cnt</value>
        public string xstr_cnt
        {
            get { return m_xstr_cnt; }
            set
            {
                m_xstr_cnt = value.Length > 0 ? value.Substring(0, 1) : " ";
            }
        }

        /// <value>Property for xstr_b7sc_list() array</value>
        public B7sc[] xstr_b7sc_list
        {
            get { return m_xstr_b7sc_list; }
            set { m_xstr_b7sc_list = value; }
        }

        /// <value>Property for xstr_b7sc_list() item</value>
        public B7sc xstr_b7sc_list_item(int index) => m_xstr_b7sc_list[index];

        public void xstr_b7sc_list_item(int index, B7sc value) {
            m_xstr_b7sc_list[index] = value;
        }


}
}
