using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperLib.Model
{
    
    public class Wa2F3sx : WA
    {
        private string m_f3skey;
        private string m_num_of_intersections;
        private CrossStreetInfoX[] m_xstr_list = new CrossStreetInfoX[431]; // Index from 0 to 430

        /// <summary>Constructor for <c>Wa2F3sx</c></summary>
        public Wa2F3sx()
        {
            m_f3skey = new string(' ', 21);
            m_num_of_intersections = new string(' ', 3);
            for (int i = 0; i <= 430; i++)
            {
                m_xstr_list[i] = new CrossStreetInfoX();
            }
        }

        /// <summary>Constructor for <c>Wa2F3sx</c></summary>
        public Wa2F3sx(string inString) => Wa2F3sxFromString(inString);

        /// <summary><c>Clear</c> reinitializes the <c>Wa2F3sx</c> object to spaces</summary>
        public override void Clear() => Wa2F3sxFromString(new string(' ', 32274));

        /// <summary><c>ToString</c> converts a <c>Wa2F3sx</c> object to a string </summary>
        public override string ToString() => Wa2F3sxToString();

        /// <summary><c>FromString</c> converts a string to a <c>Wa2F3sx</c> object</summary>
        public override void FromString(string inString) => Wa2F3sxFromString(inString);

        /// <summary><c>Wa2F3sxToString</c> converts a <c>Wa2F3sx</c> object to a string</summary>
        public string Wa2F3sxToString()
        {
            var sb = new StringBuilder();
            sb.Append(m_f3skey);
            sb.Append(m_num_of_intersections);
            for (int i = 0; i <= 430; i++)
            {
                sb.Append(m_xstr_list[i].CrossStreetInfoXToString());
            }
            return sb.ToString();
        }

        /// <summary><c>Wa2F3sxFromString</c> converts a string to a <c>Wa2F3sx</c> object</summary>
        public void Wa2F3sxFromString(string inString)
        {
            m_f3skey = inString.Substring(0, 21);
            m_num_of_intersections = inString.Substring(21, 3);
            for (int i = 0; i <= 430; i++)
            {
                m_xstr_list[i] = new CrossStreetInfoX(inString.Substring(24 + (i * 55), 55));
            }
        }

        /// <summary><c>Display</c> creates a string of <c>Wa2F3sx</c> field values separated by a character</summary>
        public override string Display(char c)
        {
            var sb = new StringBuilder();
            sb.Append(m_f3skey);
            sb.Append(c);
            sb.Append(m_num_of_intersections);
            sb.Append(c);
            for (int i = 0; i <= 430; i++)
            {
                sb.Append(m_xstr_list[i].Display());
                sb.Append(c);
            }
            return sb.ToString();
        }

        /// <summary><c>Display</c> creates a string of <c>Wa2F3sx</c> field values separated by a dash</summary>
        public override string Display() => Display('-');

        /// <summary><c>Print</c> creates a string with <c>Wa2F3sx</c> field names and values</summary>
        public override string Print()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("f3skey = {0}\n", m_f3skey);
            sb.AppendFormat("num_of_intersections = {0}\n", m_num_of_intersections);
            for (int i = 0; i <= 430; i++)
            {
                sb.AppendFormat("xstr_list({0}) = {1}\n", i, m_xstr_list[i].Display());
            }
            return sb.ToString();
        }

        /// <summary><c>Report</c> creates a string with <c>Wa2F3sx</c> field names and values in a Report Format</summary>
        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine("****************************************************************************");
            sb.AppendLine("******************************  Wa2F3sx  ***********************************");
            sb.AppendLine("*****************************************************************************");
            sb.AppendLine("\n**********  Key Information  **********");
            sb.AppendFormat("f3skey = {0}\n", m_f3skey);

            sb.AppendLine("\n**********  Number of Intersections  **********");
            sb.AppendFormat("num_of_intersections = {0}\n", m_num_of_intersections);

            sb.AppendLine("\n**********  Intersection Information  **********");
            sb.AppendLine("Distance\tNode ID\tGAP\tMHRI\tB7SC1\tB7SC2\tB7SC3\tB7SC4\tB7SC5\n");

            for (int i = 0; i <= 430; i++)
            {
                sb.AppendFormat("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\n",
                                m_xstr_list[i].distance, m_xstr_list[i].node_num, m_xstr_list[i].gap_flag,
                                m_xstr_list[i].mh_ri_flag,
                                m_xstr_list[i].xstr_b7sc_list[0].Display(), 
                                m_xstr_list[i].xstr_b7sc_list[1].Display(),
                                m_xstr_list[i].xstr_b7sc_list[2].Display(),
                                m_xstr_list[i].xstr_b7sc_list[3].Display(),
                                m_xstr_list[i].xstr_b7sc_list[4].Display());
            }

            return sb.ToString();
        }

        /// <summary><c>f3skey</c> Property</summary>
        public string f3skey
        {
            get => m_f3skey;
            set => m_f3skey = value.Length > 21 ? value.Substring(0, 21) : value;
        }

        /// <summary><c>num_of_intersections</c> Property</summary>
        public string num_of_intersections
        {
            get => m_num_of_intersections;
            set => m_num_of_intersections = value.Length > 3 ? value.Substring(0, 3) : value;
        }

        /// <summary><c>xstr_list</c> Property</summary>
        public CrossStreetInfoX[] xstr_list
        {
            get => m_xstr_list;
            set => m_xstr_list = value;
        }

        /// <summary><c>xstr_list_item</c> Property</summary>
        public CrossStreetInfoX xstr_list_item(int index) => m_xstr_list[index];
        public void xstr_list_item(int index, CrossStreetInfoX value) => m_xstr_list[index] = value;
        
    }
}
