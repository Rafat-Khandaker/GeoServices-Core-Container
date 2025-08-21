using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperLib.Model
{
    public class Wa2F3eas : WA
    {
        private Wa2F3e m_wa2f3e;
        private string m_auxseg_filler;
        private string m_auxseg_count;
        private string[] m_auxseg_id_list = new string[70];

        // Constructor for Wa2F3eas
        public Wa2F3eas()
        {
            m_wa2f3e = new Wa2F3e();
            m_auxseg_filler = new string(' ', 6);
            m_auxseg_count = new string(' ', 4);
            for (int i = 0; i < 70; i++)
            {
                m_auxseg_id_list[i] = new string(' ', 7);
            }
        }

        // Constructor for Wa2F3eas with input string
        public Wa2F3eas(string inString) : this()
        {
            Wa2F3easFromString(inString);
        }

        // Clear method
        public override void Clear() => Wa2F3easFromString(new string(' ', 1500));

        // ToString method
        public override string ToString() => Wa2F3easToString();

        // FromString method
        public override void FromString(string inString) => Wa2F3easFromString(inString);

        // Converts Wa2F3eas object to a string
        public string Wa2F3easToString()
        {
            var sb = new StringBuilder();
            sb.Append(m_wa2f3e.ToString());
            sb.Append(m_auxseg_filler);
            sb.Append(m_auxseg_count);
            foreach (var id in m_auxseg_id_list)
            {
                sb.Append(id);
            }
            return sb.ToString();
        }

        // Converts string to a Wa2F3eas object
        public void Wa2F3easFromString(string inString)
        {
            m_wa2f3e = new Wa2F3e(inString.Substring(0, 1000));
            m_auxseg_filler = inString.Substring(1000, 6);
            m_auxseg_count = inString.Substring(1006, 4);
            for (int i = 0; i < 70; i++)
            {
                try { m_auxseg_id_list[i] = inString.Substring(1010 + (i * 7), 7); }
                catch { m_auxseg_id_list[i] = string.Empty; }
            }
        }

        // Display method with a custom separator
        public override string Display(char c)
        {
            var sb = new StringBuilder();
            sb.Append(m_wa2f3e.Display());
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
            sb.AppendFormat("{0}{1}", m_wa2f3e.Print(), Environment.NewLine);
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
            sb.AppendLine("*****************************  Wa2F3eas  **********************************");
            sb.AppendLine("****************************************************************************");
            sb.AppendLine(m_wa2f3e.Report());
            sb.AppendLine("**********  Auxiliary Segement Information  **********");
            sb.AppendLine();
            sb.AppendFormat("auxseg_filler = {0}{1}", m_auxseg_filler, Environment.NewLine);
            sb.AppendFormat("auxseg_count = {0}{1}", m_auxseg_count, Environment.NewLine);
            for (int i = 0; i < 70; i++)
            {
                sb.AppendFormat("auxseg_id_list({0}) = {1}{2}", i, m_auxseg_id_list[i], Environment.NewLine);
            }
            return sb.ToString();
        }

        // Property for wa2f3e
        public Wa2F3e wa2f3e
        {
            get => m_wa2f3e;
            set => m_wa2f3e = value;
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
        public string[] auxseg_id_list
        {
            get => m_auxseg_id_list;
            set => m_auxseg_id_list = value;
        }

        // Property for auxseg_id_list item
        public string this[int index]
        {
            get => m_auxseg_id_list[index];
            set
            {
                var strlen = value.Length > 7 ? 7 : value.Length;
                m_auxseg_id_list[index] = new string(' ', 7);
                if (strlen > 0)
                    m_auxseg_id_list[index] = value.Substring(0, strlen);
            }
        }
    }

}
