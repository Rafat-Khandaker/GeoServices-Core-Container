using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GeoXWrapperLib.Model
{
    public class Wa2F3ceas : WA
    {
        private Wa2F3ce m_wa2f3ce;
        private string m_auxseg_filler;
        private string m_auxseg_count;
        private string[] m_auxseg_id_list = new string[70];

        // Constructor for Wa2F3ceas
        public Wa2F3ceas()
        {
            m_wa2f3ce = new Wa2F3ce();
            m_auxseg_filler = new string(' ', 6);
            m_auxseg_count = new string(' ', 4);
            for (int i = 0; i < 70; i++)
            {
                m_auxseg_id_list[i] = new string(' ', 7);
            }
        }

        // Constructor for Wa2F3ceas with input string
        public Wa2F3ceas(string inString) : this()
        {
            Wa2F3ceasFromString(inString);
        }

        // Clear method
        public override void Clear() => Wa2F3ceasFromString(new string(' ', 1350));

        // ToString method
        public override string ToString() => Wa2F3ceasToString();

        // FromString method
        public override void FromString(string inString) => Wa2F3ceasFromString(inString);

        // Converts Wa2F3ceas object to a string
        public string Wa2F3ceasToString()
        {
            var sb = new StringBuilder();
            sb.Append(m_wa2f3ce.ToString());
            sb.Append(m_auxseg_filler);
            sb.Append(m_auxseg_count);
            foreach (var id in m_auxseg_id_list)
                sb.Append(id);

            return sb.ToString();
        }

        // Converts string to a Wa2F3ceas object
        public void Wa2F3ceasFromString(string inString)
        {
            m_wa2f3ce.FromString(inString.Substring(0, 850));
            m_auxseg_filler = inString.Substring(850, 6);
            m_auxseg_count = inString.Substring(856, 4);

            using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Debug_Results_3c", append: true))
            {
                writer.WriteLine(inString);

                for (int i = 0; i < 70; i++)
                    try {
                        var test = inString.Substring(860 + (i * 7), 7);
                        writer.WriteLine(test);

                        m_auxseg_id_list[i] = test;
                    }
                    catch { m_auxseg_id_list[i] = string.Empty; }
            }
            //for (int i = 0; i < 70; i++)
            //    try { m_auxseg_id_list[i] = inString.Substring(860 + (i * 7), 7); } 
            //    catch { m_auxseg_id_list[i] = string.Empty; }
        }

        // Display method with a custom separator
        public override string Display(char c)
        {
            var sb = new StringBuilder();
            sb.Append(m_wa2f3ce.Display());
            sb.Append(c);
            sb.Append(m_auxseg_filler);
            sb.Append(c);
            sb.Append(m_auxseg_count);
            sb.Append(c);
            foreach (var id in m_auxseg_id_list)
            {
                sb.Append(id);
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
            sb.AppendFormat("{0}{1}", m_wa2f3ce.Print(), Environment.NewLine);
            sb.AppendFormat("auxseg_filler = {0}{1}", m_auxseg_filler, Environment.NewLine);
            sb.AppendFormat("auxseg_count = {0}{1}", m_auxseg_count, Environment.NewLine);
            for (int i = 0; i < 70; i++)
            {
                sb.AppendFormat("auxseg_id_list({0}) = {1}{2}", i, m_auxseg_id_list[i], Environment.NewLine);
            }
            return sb.ToString();
        }

        // Report method
        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine("****************************************************************************");
            sb.AppendLine("****************************  Wa2F3ceas  *********************************");
            sb.AppendLine("****************************************************************************");
            sb.AppendLine(m_wa2f3ce.Report());
            sb.AppendLine("**********  Auxiliary Segment Information  **********");
            sb.AppendLine();
            sb.AppendFormat("auxseg_filler = {0}{1}", m_auxseg_filler, Environment.NewLine);
            sb.AppendFormat("auxseg_count = {0}{1}", m_auxseg_count, Environment.NewLine);
            for (int i = 0; i < 70; i++)
            {
                sb.AppendFormat("auxseg_id_list({0}) = {1}{2}", i, m_auxseg_id_list[i], Environment.NewLine);
            }
            return sb.ToString();
        }

        // Property for wa2f3ce
        public Wa2F3ce wa2f3ce
        {
            get => m_wa2f3ce;
            set => m_wa2f3ce = value;
        }

        // Property for auxseg_filler
        public string auxseg_filler
        {
            get => m_auxseg_filler;
            set => m_auxseg_filler = value.Length > 6 ? value.Substring(0, 6) : value;
        }

        // Property for auxseg_count
        public string auxseg_count
        {
            get => m_auxseg_count;
            set => m_auxseg_count = value.Length > 4 ? value.Substring(0, 4) : value;
        }

        // Property for auxseg_id_list
        [XmlArrayItem(typeof(string), ElementName = "auxseg_id")]
        public string[] auxseg_id_list
        {
            get
            {
                return m_auxseg_id_list;
            }
            set
            {
                m_auxseg_id_list = value;
            }
        }

        
    }
}
