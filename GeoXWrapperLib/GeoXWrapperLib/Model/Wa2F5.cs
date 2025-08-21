using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperLib.Model
{
    public class Wa2F5 : WA
    {
        private VsamKey1 m_gridkey1;
        private string m_cont_parity_ind;
        private string m_lohns;
        private string m_filler01;

        /// <summary>Constructor for <c>Wa2F5</c></summary>
        public Wa2F5()
        {
            m_gridkey1 = new VsamKey1();
            m_cont_parity_ind = new string(' ', 1);
            m_lohns = new string(' ', 11);
            m_filler01 = new string(' ', 267);
        }

        /// <summary>Constructor for <c>Wa2F5</c></summary>
        public Wa2F5(string inString) => Wa2F5FromString(inString);

        /// <summary><c>Clear</c> reinitializes the <c>Wa2F5</c> object to spaces</summary>
        public override void Clear() => Wa2F5FromString(new string(' ', 300));

        /// <summary><c>ToString</c> converts a <c>Wa2F5</c> object to a string</summary>
        public override string ToString() => Wa2F5ToString();

        /// <summary><c>FromString</c> converts a string to a <c>Wa2F5</c> object</summary>
        public override void FromString(string inString) => Wa2F5FromString(inString);

        /// <summary><c>Wa2F5ToString</c> converts a <c>Wa2F5</c> object to a string</summary>
        public string Wa2F5ToString() =>
            $"{m_gridkey1.VsamKey1ToString()}{m_cont_parity_ind}{m_lohns}{m_filler01}";

        /// <summary><c>Wa2F5FromString</c> converts a string to a <c>Wa2F5</c> object</summary>
        public void Wa2F5FromString(string inString)
        {
            try { m_gridkey1 = new VsamKey1(inString.Substring(0, 21)); } catch { m_gridkey1 = new VsamKey1(); }
            try { m_cont_parity_ind = inString.Substring(21, 1); } catch { m_cont_parity_ind = string.Empty; }
            try { m_cont_parity_ind = inString.Substring(21, 1); } catch { m_cont_parity_ind = string.Empty; }
            try { m_lohns = inString.Substring(22, 11); } catch { m_lohns = string.Empty; }
            try { m_filler01 = inString.Substring(33, 267); } catch { m_filler01 = string.Empty; }
        }

        /// <summary><c>Display</c> creates a string of <c>Wa2F5</c> field values separated by a character</summary>
        public override string Display(char c) =>
            $"{m_gridkey1.Display()}{c}{m_cont_parity_ind}{c}{m_lohns}{c}{m_filler01}";

        /// <summary><c>Display</c> creates a string of <c>Wa2F5</c> field values separated by a dash</summary>
        public override string Display() => Display('-');

        /// <summary><c>Print</c> creates a string with <c>Wa2F5</c> field names and values</summary>
        public override string Print()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("gridkey1 = {0}{1}", m_gridkey1.Display(), Environment.NewLine);
            sb.AppendFormat("cont_parity_ind = {0}{1}", m_cont_parity_ind, Environment.NewLine);
            sb.AppendFormat("lohns = {0}{1}", m_lohns, Environment.NewLine);
            sb.AppendFormat("filler01 = {0}{1}", m_filler01, Environment.NewLine);
            return sb.ToString();
        }

        /// <summary><c>Report</c> creates a string with <c>Wa2F5</c> field names and values in a Report Format</summary>
        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendLine("****************************************************************************");
            sb.AppendLine("******************************  Wa2F5  ***********************************");
            sb.AppendLine("****************************************************************************");
            return sb.ToString();
        }

        /// <value>Property for gridkey1</value>
        public VsamKey1 gridkey1
        {
            get => m_gridkey1;
            set => m_gridkey1 = value;
        }

        /// <value>Property for cont_parity_ind</value>
        public string cont_parity_ind
        {
            get => m_cont_parity_ind;
            set => m_cont_parity_ind = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        /// <value>Property for lohns</value>
        public string lohns
        {
            get => m_lohns;
            set => m_lohns = value.Length > 11 ? value.Substring(0, 11) : value;
        }

        /// <value>Property for filler01</value>
        public string filler01
        {
            get => m_filler01;
            set => m_filler01 = value.Length > 267 ? value.Substring(0, 267) : value;
        }
    }

}
