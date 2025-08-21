using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperLib.Model
{
    public class Wa2F3s : WA
    {
        private string m_f3skey;
        private string m_num_of_intersections;
        private CrossStreetInfo[] m_xstr_list = new CrossStreetInfo[350];

        // Constructor for Wa2F3s
        public Wa2F3s()
        {
            m_f3skey = new string(' ', 21);
            m_num_of_intersections = new string(' ', 3);
            for (int i = 0; i < 350; i++)
            {
                m_xstr_list[i] = new CrossStreetInfo();
            }
        }

        // Constructor for Wa2F3s with input string
        public Wa2F3s(string inString) => Wa2F3sFromString(inString);

        // Clear method to reinitialize the object
        public override void Clear() => Wa2F3sFromString(new string(' ', 19274));

        // ToString method
        public override string ToString() => Wa2F3sToString();

        // FromString method
        public override void FromString(string inString) => Wa2F3sFromString(inString);

        // Converts Wa2F3s object to a string
        public string Wa2F3sToString()
        {
            var sb = new StringBuilder();
            sb.Append(m_f3skey);
            sb.Append(m_num_of_intersections);
            foreach (var xstr in m_xstr_list)
            {
                sb.Append(xstr.CrossStreetInfoToString());
            }
            return sb.ToString();
        }

        // Converts string to a Wa2F3s object
        public void Wa2F3sFromString(string inString)
        {
            m_f3skey = inString.Substring(0, 21);
            m_num_of_intersections = inString.Substring(21, 3);
            for (int i = 0; i < 350; i++)
            {
                try { m_xstr_list[i] = new CrossStreetInfo(inString.Substring(24 + (i * 55), 55)); } catch { m_xstr_list[i] = new CrossStreetInfo(); }
            }
        }

        // Display method with custom separator
        public override string Display(char c)
        {
            var sb = new StringBuilder();
            sb.Append(m_f3skey);
            sb.Append(c);
            sb.Append(m_num_of_intersections);
            sb.Append(c);
            foreach (var xstr in m_xstr_list)
            {
                sb.Append(xstr.Display());
                sb.Append(c);
            }
            return sb.ToString();
        }

        // Display method with dash separator
        public override string Display() => Display('-');

        // Print method
        public override string Print()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("f3skey = {0}{1}", m_f3skey, Environment.NewLine);
            sb.AppendFormat("num_of_intersections = {0}{1}", m_num_of_intersections, Environment.NewLine);
            for (int i = 0; i < 350; i++)
            {
                sb.AppendFormat("xstr_list({0}) = {1}{2}", i, m_xstr_list[i].Display(), Environment.NewLine);
            }
            return sb.ToString();
        }

        // Report method
        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine("****************************************************************************");
            sb.AppendLine("******************************  Wa2F3s  ***********************************");
            sb.AppendLine("****************************************************************************");
            sb.AppendLine("\r\n**********  Key Information  **********");
            sb.AppendFormat("f3skey = {0}{1}", m_f3skey, Environment.NewLine);
            sb.AppendLine("\r\n**********  Number of Intersections  **********");
            sb.AppendFormat("num_of_intersections = {0}{1}", m_num_of_intersections, Environment.NewLine);
            sb.AppendLine("\r\n**********  Intersection Information  **********");

            sb.AppendLine("Distance\tNode ID\tGAP\tMHRI\tB7SC1\tB7SC2\tB7SC3\tB7SC4\tB7SC5");
            foreach (var xstr in m_xstr_list)
            {
                sb.AppendFormat("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\r\n",
                                xstr.distance, xstr.node_num, xstr.gap_flag, xstr.mh_ri_flag,
                                xstr.xstr_b7sc_list[0].Display(), xstr.xstr_b7sc_list[1].Display(),
                                xstr.xstr_b7sc_list[2].Display(), xstr.xstr_b7sc_list[3].Display(),
                                xstr.xstr_b7sc_list[4].Display());
            }
            return sb.ToString();
        }

        // Property for f3skey
        public string f3skey
        {
            get => m_f3skey;
            set => m_f3skey = value.Length > 21 ? value.Substring(0, 21) : value;
        }

        // Property for num_of_intersections
        public string num_of_intersections
        {
            get => m_num_of_intersections;
            set => m_num_of_intersections = value.Length > 3 ? value.Substring(0, 3) : value;
        }

        // Property for xstr_list
        public CrossStreetInfo[] xstr_list
        {
            get => m_xstr_list;
            set => m_xstr_list = value;
        }

        // Property for xstr_list item
        public CrossStreetInfo xstr_list_item(int index)  => m_xstr_list[index];
        public void XstrListItem(int index, CrossStreetInfo value) => m_xstr_list[index] = value;
        
    }
}
