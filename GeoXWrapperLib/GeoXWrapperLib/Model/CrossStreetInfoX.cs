using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace GeoXWrapperLib.Model
{
    public class CrossStreetInfoX
    {
        private string m_mh_ri_flag;
        private string m_distance;
        private string m_gap_flag;
        private string m_node_num;
        private string m_segment_id;
        private string m_physical_id;
        private string m_generic_id;
        private string m_xstr_cnt;
        private B7sc[] m_xstr_b7sc_list = new B7sc[5];

        // Constructor for CrossStreetInfoX
        public CrossStreetInfoX()
        {
            m_mh_ri_flag = new string(' ', 1);
            m_distance = new string(' ', 5);
            m_gap_flag = new string(' ', 1);
            m_node_num = new string(' ', 7);
            m_segment_id = new string(' ', 7);
            m_physical_id = new string(' ', 7);
            m_generic_id = new string(' ', 7);
            m_xstr_cnt = new string(' ', 1);

            for (int i = 0; i < 5; i++)
            {
                m_xstr_b7sc_list[i] = new B7sc();
            }
        }

        // Constructor that takes a string to initialize the object
        public CrossStreetInfoX(string inString)
        {
            CrossStreetInfoXFromString(inString);
        }

        // Clears the object, reinitializing to spaces
        public void Clear()
        {
            CrossStreetInfoXFromString(new string(' ', 75));
        }

        // Converts the object to a string
        public override string ToString()
        {
            return CrossStreetInfoXToString();
        }

        // Converts a string to a CrossStreetInfoX object
        public void FromString(string inString)
        {
            CrossStreetInfoXFromString(inString);
        }

        // Converts the object to XML
        public void ToXml(ref XmlDocument indoc)
        {
            using (MemoryStream xmlStream = new MemoryStream())
            {
                XmlSerializer xmlFormatter = new XmlSerializer(typeof(CrossStreetInfoX));
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

        // Converts the object to a string representation
        public string CrossStreetInfoXToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(m_mh_ri_flag);
            sb.Append(m_distance);
            sb.Append(m_gap_flag);
            sb.Append(m_node_num);
            sb.Append(m_segment_id);
            sb.Append(m_physical_id);
            sb.Append(m_generic_id);
            sb.Append(m_xstr_cnt);

            foreach (var b7sc in m_xstr_b7sc_list)
            {
                sb.Append(b7sc.B7scToString());
            }

            return sb.ToString();
        }

        // Converts a string to a CrossStreetInfoX object
        public void CrossStreetInfoXFromString(string inString)
        {
            m_mh_ri_flag = inString.Substring(0, 1);
            m_distance = inString.Substring(1, 5);
            m_gap_flag = inString.Substring(6, 1);
            m_node_num = inString.Substring(7, 7);
            m_segment_id = inString.Substring(14, 7);
            m_physical_id = inString.Substring(21, 7);
            m_generic_id = inString.Substring(28, 7);
            m_xstr_cnt = inString.Substring(35, 1);

            for (int i = 0; i < 5; i++)
            {
                m_xstr_b7sc_list[i] = new B7sc(inString.Substring(36 + (i * 8), 8));
            }
        }

        // Display function to create a string with fields separated by a character
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
            sb.Append(m_segment_id);
            sb.Append(c);
            sb.Append(m_physical_id);
            sb.Append(c);
            sb.Append(m_generic_id);
            sb.Append(c);
            sb.Append(m_xstr_cnt);
            sb.Append(c);

            foreach (var b7sc in m_xstr_b7sc_list)
            {
                sb.Append(b7sc.Display());
                sb.Append(c);
            }

            return sb.ToString();
        }

        // Display function to create a string with fields separated by a dash
        public string Display()
        {
            return Display('-');
        }

        // Print function to create a string with field names and values
        public string Print()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("mh_ri_flag = {0}\n", m_mh_ri_flag);
            sb.AppendFormat("distance = {0}\n", m_distance);
            sb.AppendFormat("gap_flag = {0}\n", m_gap_flag);
            sb.AppendFormat("node_num = {0}\n", m_node_num);
            sb.AppendFormat("segment_id = {0}\n", m_segment_id);
            sb.AppendFormat("physical_id = {0}\n", m_physical_id);
            sb.AppendFormat("generic_id = {0}\n", m_generic_id);
            sb.AppendFormat("xstr_cnt = {0}\n", m_xstr_cnt);

            for (int i = 0; i < 5; i++)
            {
                sb.AppendFormat("xstr_b7sc_list({0}) = {1}\n", i.ToString(), m_xstr_b7sc_list[i].Display());
            }

            return sb.ToString();
        }

        // Properties
        public string mh_ri_flag
        {
            get => m_mh_ri_flag; 
            set { m_mh_ri_flag = value.PadRight(1, ' ').Substring(0, 1); }
        }

        public string distance
        {
            get => m_distance; 
            set { m_distance = value.PadRight(5, ' ').Substring(0, 5); }
        }

        public string gap_flag
        {
            get => m_gap_flag; 
            set { m_gap_flag = value.PadRight(1, ' ').Substring(0, 1); }
        }

        public string node_num
        {
            get => m_node_num; 
            set { m_node_num = value.PadRight(7, ' ').Substring(0, 7); }
        }

        public string segment_id
        {
            get => m_segment_id; 
            set { m_segment_id = value.PadRight(7, ' ').Substring(0, 7); }
        }

        public string physical_id
        { 
            get => m_physical_id; 
            set { m_physical_id = value.PadRight(7, ' ').Substring(0, 7); }
        }

        public string generic_id
        {
            get => m_generic_id; 
            set { m_generic_id = value.PadRight(7, ' ').Substring(0, 7); }
        }

        public string xstr_cnt
        {
            get => m_xstr_cnt; 
            set { m_xstr_cnt = value.PadRight(1, ' ').Substring(0, 1); }
        }

        public B7sc[] xstr_b7sc_list
        {
            get => m_xstr_b7sc_list; 
            set { m_xstr_b7sc_list = value; }
        }

        public B7sc xstr_b7sc_list_item(int index) => m_xstr_b7sc_list[index];

        public void xstr_b7sc_list_item(int index, B7sc value) {
            m_xstr_b7sc_list[index] = value;
        }

        
    }
}
