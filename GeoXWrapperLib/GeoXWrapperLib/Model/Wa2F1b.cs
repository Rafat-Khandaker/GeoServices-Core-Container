using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperLib.Model
{
    public class Wa2F1b : WA
    {
        private Wa2F1ex m_wa2f1ex;
        private Wa2F1ax m_wa2f1ax;

        // Constructor for Wa2F1b
        public Wa2F1b()
        {
            m_wa2f1ex = new Wa2F1ex();
            m_wa2f1ax = new Wa2F1ax();
        }

        // Constructor for Wa2F1b with input string
        public Wa2F1b(string inString)
        {
            Wa2F1bFromString(inString);
        }

        // Clear reinitializes the Wa2F1b object to spaces
        public override void Clear()
        {
            Wa2F1bFromString(new string(' ', 4300));
        }

        // ToString converts a Wa2F1b object to a string
        public override string ToString()
        {
            return Wa2F1bToString();
        }

        // FromString converts a string to a Wa2F1b object
        public override void FromString(string inString)
        {
            Wa2F1bFromString(inString);
        }

        // Wa2F1bToString converts a Wa2F1b object to a string
        public string Wa2F1bToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(m_wa2f1ex.ToString());
            sb.Append(m_wa2f1ax.ToString());
            return sb.ToString();
        }

        // Wa2F1bFromString converts a string to a Wa2F1b object
        public void Wa2F1bFromString(string inString)
        {
            if(inString.Length >= 1500)
                m_wa2f1ex.FromString(inString.Substring(0, 1500));
            if(inString.Length >= (1500 + 2800))
                m_wa2f1ax.FromString(inString.Substring(1500, 2800));
        }

        // Display creates a string of Wa2F1b field values separated by a character
        public override string Display(char c)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(m_wa2f1ex.Display());
            sb.Append(c);
            sb.Append(m_wa2f1ax.Display());
            return sb.ToString();
        }

        // Display creates a string of Wa2F1b field values separated by a dash
        public override string Display()
        {
            return Display('-');
        }

        // Print creates a string with Wa2F1b field names and values
        public override string Print()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}{1}", m_wa2f1ex.Print(), "\r\n");
            sb.AppendFormat("{0}{1}", m_wa2f1ax.Print(), "\r\n");
            return sb.ToString();
        }

        // Report creates a string with Wa2F1b field names and values in a Report Format
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\r\n");
            sb.AppendFormat("****************************************************************************\r\n");
            sb.AppendFormat("*****************************  Wa2F1b  **********************************\r\n");
            sb.AppendFormat("****************************************************************************\r\n");
            sb.AppendFormat("{0}\r\n", m_wa2f1ex.Report());
            sb.AppendFormat("{0}\r\n", m_wa2f1ax.Report());
            return sb.ToString();
        }

        // GoatDisplay creates a string with Wa2F1b field names and values in a Goat format
        public string GoatDisplay()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\r\n");
            sb.AppendFormat("****************************************************************************\r\n");
            sb.AppendFormat("*****************************  Wa2F1b  **********************************\r\n");
            sb.AppendFormat("****************************************************************************\r\n");
            sb.AppendFormat("{0}\r\n", m_wa2f1ex.GoatDisplay());
            sb.AppendFormat("{0}\r\n", m_wa2f1ax.GoatDisplay());
            return sb.ToString();
        }

        // Property for wa2f1ex
        public Wa2F1ex wa2f1ex
        {
            get => m_wa2f1ex;
            set => m_wa2f1ex = value;
        }

        // Property for wa2f1ax
        public Wa2F1ax wa2f1ax
        {
            get => m_wa2f1ax;
            set => m_wa2f1ax = value;
        }
    }
}
