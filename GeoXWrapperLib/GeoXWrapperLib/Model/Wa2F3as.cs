using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GeoXWrapperLib.Model
{
    public class Wa2F3as : WA
    {
        private Wa2F3 m_wa2f3;
        private string m_auxseg_filler;
        private string m_auxseg_count;
        private string[] m_auxseg_id_list = new string[70];

        /// <summary>Constructor for <c>Wa2F3as</c></summary>
        public Wa2F3as()
        {
            m_wa2f3 = new Wa2F3();
            m_auxseg_filler = new string(' ', 6);
            m_auxseg_count = new string(' ', 4);
            for (int i = 0; i < 70; i++)
            {
                m_auxseg_id_list[i] = new string(' ', 7);
            }
        }

        /// <summary>Constructor for <c>Wa2F3as</c></summary>
        public Wa2F3as(string inString) : this()
        {
            Wa2F3asFromString(inString);
        }

        /// <summary><c>Clear</c> reinitializes the <c>Wa2F3as</c> object to spaces</summary>
        public override void Clear() => Wa2F3asFromString(new string(' ', 950));

        /// <summary><c>ToString</c> converts a <c>Wa2F3as</c> object to a string</summary>
        public override string ToString() => Wa2F3asToString();

        /// <summary><c>FromString</c> converts a string to a <c>Wa2F3as</c> object</summary>
        public override void FromString(string inString) => Wa2F3asFromString(inString);

        /// <summary><c>Wa2F3asToString</c> converts a <c>Wa2F3as</c> object to a string</summary>
        public string Wa2F3asToString()
        {
            var sb = new StringBuilder();
            sb.Append(m_wa2f3.ToString());
            sb.Append(m_auxseg_filler);
            sb.Append(m_auxseg_count);
            foreach (var id in m_auxseg_id_list)
            {
                sb.Append(id);
            }
            return sb.ToString();
        }

        /// <summary><c>Wa2F3asFromString</c> converts a string to a <c>Wa2F3as</c> object</summary>
        public void Wa2F3asFromString(string inString)
        {
            m_wa2f3 = new Wa2F3(inString.Substring(0, 450));
            m_auxseg_filler = inString.Substring(450, 6);
            m_auxseg_count = inString.Substring(456, 4);
            for (int i = 0; i < 70; i++)
            {
                m_auxseg_id_list[i] = inString.Substring(460 + (i * 7), 7);
            }
        }

        /// <summary><c>Display</c> creates a string of <c>Wa2F3as</c> field values separated by a character</summary>
        public override string Display(char c)
        {
            var sb = new StringBuilder();
            sb.Append(m_wa2f3.Display());
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

        /// <summary><c>Display</c> creates a string of <c>Wa2F3as</c> field values separated by a dash</summary>
        public override string Display() => Display('-');

        /// <summary><c>Print</c> creates a string with <c>Wa2F3as</c> field names and values</summary>
        public override string Print()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("{0}{1}", m_wa2f3.Print(), Environment.NewLine);
            sb.AppendFormat("auxseg_filler = {0}{1}", m_auxseg_filler, Environment.NewLine);
            sb.AppendFormat("auxseg_count = {0}{1}", m_auxseg_count, Environment.NewLine);
            for (int i = 0; i < 70; i++)
            {
                sb.AppendFormat("auxseg_id_list({0}) = {1}{2}", i, m_auxseg_id_list[i], Environment.NewLine);
            }
            return sb.ToString();
        }

        /// <summary><c>Report</c> creates a string with <c>Wa2F3as</c> field names and values in a Report Format</summary>
        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("{0}", Environment.NewLine);
            sb.AppendFormat("{0}{1}", "****************************************************************************", Environment.NewLine);
            sb.AppendFormat("{0}{1}", "******************************  Wa2F3as  ***********************************", Environment.NewLine);
            sb.AppendFormat("{0}{1}", "****************************************************************************", Environment.NewLine);
            sb.AppendFormat("{0}{1}", m_wa2f3.Report(), Environment.NewLine);
            sb.AppendFormat("{0}{1}", Environment.NewLine + "**********  Auxiliary Segement Information  **********", Environment.NewLine + Environment.NewLine);
            sb.AppendFormat("auxseg_filler = {0}{1}", m_auxseg_filler, Environment.NewLine);
            sb.AppendFormat("auxseg_count = {0}{1}", m_auxseg_count, Environment.NewLine);
            for (int i = 0; i < 70; i++)
            {
                sb.AppendFormat("auxseg_id_list({0}) = {1}{2}", i, m_auxseg_id_list[i], Environment.NewLine);
            }
            return sb.ToString();
        }

        /// <value>Property for wa2f3</value>
        public Wa2F3 wa2f3
        {
            get => m_wa2f3;
            set => m_wa2f3 = value;
        }

        /// <value>Property for auxseg_filler</value>
        public string auxseg_filler
        {
            get => m_auxseg_filler;
            set
            {
                var strlen = value.Length;
                if (strlen > 6) strlen = 6;
                m_auxseg_filler = value.Substring(0, strlen);
            }
        }

        /// <value>Property for auxseg_count</value>
        public string auxseg_count
        {
            get => m_auxseg_count;
            set
            {
                var strlen = value.Length;
                if (strlen > 4) strlen = 4;
                m_auxseg_count = value.Substring(0, strlen);
            }
        }

        /// <value>Property for auxseg_id_list() array</value>
        [XmlArrayItem(typeof(string), ElementName = "auxseg_id")]
        public string[] auxseg_id_list
        {
            get => m_auxseg_id_list;
            set => m_auxseg_id_list = value;
        }

        /// <value>Property for auxseg_id_list() item</value>
        // Property for auxseg_id_list_item
        public string auxseg_id_list_item(int index) => m_auxseg_id_list[index];
        public void auxseg_id_list_item(int index, string value)
        {
            int strlen = value.Length;
            strlen = strlen > 7 ? 7 : strlen;
            m_auxseg_id_list[index] = new string(' ', 7);
            if (strlen > 0)
                m_auxseg_id_list[index] = value.Substring(0, strlen).PadRight(7);
        }


    }
}
