using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GeoXWrapperLib.Model
{
    public class Wa2F3xas : WA
    {
        private Wa2F3x m_wa2f3x;
        private string m_auxseg_filler;
        private string m_auxseg_count;
        private string[] m_auxseg_id_list = new string[70];

        // Constructor for Wa2F3xas
        public Wa2F3xas()
        {
            m_wa2f3x = new Wa2F3x();
            m_auxseg_filler = new string(' ', 6);
            m_auxseg_count = new string(' ', 4);
            for (int i = 0; i < 70; i++)
            {
                m_auxseg_id_list[i] = new string(' ', 7);
            }
        }

        // Constructor for Wa2F3xas with input string
        public Wa2F3xas(string inString) : this()
        {
            Wa2F3xasFromString(inString);
        }

        // Clear method reinitializes the object to spaces
        public override void Clear() => Wa2F3xasFromString(new string(' ', 1500));

        // ToString method converts the object to a string
        public override string ToString() => Wa2F3xasToString();

        // FromString method converts a string to a Wa2F3xas object
        public override void FromString(string inString) => Wa2F3xasFromString(inString);

        // Converts Wa2F3xas object to a string
        public string Wa2F3xasToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(m_wa2f3x.ToString());
            sb.Append(m_auxseg_filler);
            sb.Append(m_auxseg_count);
            foreach (var id in m_auxseg_id_list)
            {
                sb.Append(id);
            }
            return sb.ToString();
        }

        // Converts string to a Wa2F3xas object
        public void Wa2F3xasFromString(string inString)
        {
            m_wa2f3x = new Wa2F3x(inString.Substring(0, 1000));
            m_auxseg_filler = inString.Substring(1000, 6);
            m_auxseg_count = inString.Substring(1006, 4);
            for (int i = 0; i < 70; i++)
            {
                try { m_auxseg_id_list[i] = inString.Substring(1010 + (i * 7), 7); } catch { m_auxseg_id_list[i] = string.Empty; }    
            }
        }

        // Display method creates a string of Wa2F3xas field values separated by a character
        public override string Display(char c)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(m_wa2f3x.Display());
            sb.Append(c).Append(m_auxseg_filler);
            sb.Append(c).Append(m_auxseg_count);
            sb.Append(c);
            foreach (var id in m_auxseg_id_list)
            {
                sb.Append(id).Append(c);
            }
            return sb.ToString();
        }

        // Display method creates a string of Wa2F3xas field values separated by a dash
        public override string Display() => Display('-');

        // Print method creates a string with Wa2F3xas field names and values
        public override string Print()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}{1}", m_wa2f3x.Print(), Environment.NewLine);
            sb.AppendFormat("auxseg_filler = {0}{1}", m_auxseg_filler, Environment.NewLine);
            sb.AppendFormat("auxseg_count = {0}{1}", m_auxseg_count, Environment.NewLine);
            for (int i = 0; i < 70; i++)
            {
                sb.AppendFormat("auxseg_id_list({0}) = {1}{2}", i, m_auxseg_id_list[i], Environment.NewLine);
            }
            return sb.ToString();
        }

        // Report method creates a string with Wa2F3xas field names and values in a Report format
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}", Environment.NewLine);
            sb.AppendFormat("{0}{1}", "****************************************************************************", Environment.NewLine);
            sb.AppendFormat("{0}{1}", "*****************************  Wa2F3xas  **********************************", Environment.NewLine);
            sb.AppendFormat("{0}{1}", "****************************************************************************", Environment.NewLine);

            sb.AppendFormat("{0}{1}", m_wa2f3x.Report(), Environment.NewLine);
            sb.AppendFormat("{0}{1}", Environment.NewLine + "**********  Auxiliary Segment Information  **********", Environment.NewLine + Environment.NewLine);
            sb.AppendFormat("auxseg_filler = {0}{1}", m_auxseg_filler, Environment.NewLine);
            sb.AppendFormat("auxseg_count = {0}{1}", m_auxseg_count, Environment.NewLine);

            for (int i = 0; i < 70; i++)
            {
                sb.AppendFormat("auxseg_id_list({0}) = {1}{2}", i, m_auxseg_id_list[i], Environment.NewLine);
            }
            return sb.ToString();
        }

        // Property for wa2f3x
        public Wa2F3x wa2f3x
        {
            get => m_wa2f3x;
            set => m_wa2f3x = value;
        }

        // Property for auxseg_filler
        public string auxseg_filler
        {
            get => m_auxseg_filler;
            set
            {
                int strlen = value.Length > 6 ? 6 : value.Length;
                m_auxseg_filler = value.Substring(0, strlen).PadRight(6);
            }
        }

        // Property for auxseg_count
        public string auxseg_count
        {
            get => m_auxseg_count;
            set
            {
                int strlen = value.Length > 4 ? 4 : value.Length;
                m_auxseg_count = value.Substring(0, strlen).PadRight(4);
            }
        }

        // Property for auxseg_id_list array
        [XmlArrayItem(typeof(string), ElementName = "auxseg_id")]
        public string[] auxseg_id_list
        {
            get => m_auxseg_id_list;
            set => m_auxseg_id_list = value;
        }

        // Property for auxseg_id_list item
        public string auxseg_id_list_item(int index) => m_auxseg_id_list[index];

        public void auxseg_id_list_item(int index, string value){
            int strlen = value.Length > 7 ? 7 : value.Length;
            m_auxseg_id_list[index] = value.Substring(0, strlen).PadRight(7);
        }


    }
}
