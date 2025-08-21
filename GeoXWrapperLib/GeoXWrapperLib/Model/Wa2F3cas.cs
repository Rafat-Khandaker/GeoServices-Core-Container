using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GeoXWrapperLib.Model
{
    public class Wa2F3cas : WA
    {
        private Wa2F3c m_wa2f3c;
        // Added auxseg fields
        private string m_auxseg_filler;
        private string m_auxseg_count;
        private string[] m_auxseg_id_list = new string[70];

        /// <summary>Constructor for <c>Wa2F3cas</c></summary>
        public Wa2F3cas()
        {
            m_wa2f3c = new Wa2F3c();

            // Added auxseg fields
            m_auxseg_filler = new string(' ', 6);
            m_auxseg_count = new string(' ', 4);
            for (int i = 0; i < 70; i++)
            {
                m_auxseg_id_list[i] = new string(' ', 7);
            }
        }

        /// <summary>Constructor for <c>Wa2F3cas</c></summary>
        public Wa2F3cas(string inString)
        {
            Wa2F3casFromString(inString);
        }

        /// <summary><c>Clear</c> reinitializes the <c>Wa2F3cas</c> object to spaces</summary>
        public override void Clear()
        {
            Wa2F3casFromString(new string(' ', 800));
        }

        /// <summary><c>ToString</c> converts a <c>Wa2F3cas</c> object to a string </summary>
        public override string ToString()
        {
            return Wa2F3casToString();
        }

        /// <summary><c>FromString</c> converts a string to a <c>Wa2F3cas</c> object</summary>
        public override void FromString(string inString)
        {
            Wa2F3casFromString(inString);
        }

        /// <summary><c>Wa2F3casToString</c> converts a <c>Wa2F3cas</c> object to a string</summary>
        public string Wa2F3casToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(m_wa2f3c.ToString());

            // Added auxseg fields
            sb.Append(m_auxseg_filler);
            sb.Append(m_auxseg_count);
            foreach (var id in m_auxseg_id_list)
            {
                sb.Append(id);
            }

            return sb.ToString();
        }

        /// <summary><c>Wa2F3casFromString</c> converts a string to a <c>Wa2F3cas</c> object</summary>
        public void Wa2F3casFromString(string inString)
        {
            m_wa2f3c.FromString(inString.Substring(0, 300));

            // Added auxseg fields
            m_auxseg_filler = inString.Substring(300, 6);
            m_auxseg_count = inString.Substring(306, 4);
            for (int i = 0; i < 70; i++)
            {
                m_auxseg_id_list[i] = inString.Substring(310 + (i * 7), 7);
            }
        }

        /// <summary><c>Display</c>
        /// <para>Creates a string of <c>Wa2F3cas</c> field values separated by a character</para>
        /// </summary>
        public override string Display(char c)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(m_wa2f3c.Display());

            // Added auxseg fields
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

        /// <summary><c>Display</c>
        /// <para>Creates a string of <c>Wa2F3cas</c> field values separated by a dash</para>
        /// </summary>
        public override string Display()
        {
            return Display('-');
        }

        /// <summary><c>Print</c>
        /// <para>Creates a string with <c>Wa2F3cas</c> field names and values</para>
        /// </summary>
        public override string Print()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0}{1}", m_wa2f3c.Print(), Environment.NewLine);

            // Added auxseg fields
            sb.AppendFormat("auxseg_filler = {0}{1}", m_auxseg_filler, Environment.NewLine);
            sb.AppendFormat("auxseg_count = {0}{1}", m_auxseg_count, Environment.NewLine);
            for (int i = 0; i < 70; i++)
            {
                sb.AppendFormat("auxseg_id_list({0}) = {1}{2}", i, m_auxseg_id_list[i], Environment.NewLine);
            }

            return sb.ToString();
        }

        /// <summary><c>Report</c>
        /// <para>Creates a string with <c>Wa2F3cas</c> field names and values in a Report Format</para>
        /// </summary>
        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0}", Environment.NewLine);
            sb.AppendFormat("{0}{1}", "****************************************************************************", Environment.NewLine);
            sb.AppendFormat("{0}{1}", "******************************  Wa2F3cas  ********************************", Environment.NewLine);
            sb.AppendFormat("{0}{1}", "****************************************************************************", Environment.NewLine);

            sb.AppendFormat("{0}{1}", m_wa2f3c.Report(), Environment.NewLine);

            sb.AppendFormat("{0}{1}", Environment.NewLine + "**********  Auxiliary Segment Information  **********", Environment.NewLine + Environment.NewLine);

            sb.AppendFormat("auxseg_filler = {0}{1}", m_auxseg_filler, Environment.NewLine);
            sb.AppendFormat("auxseg_count = {0}{1}", m_auxseg_count, Environment.NewLine);

            for (int i = 0; i < 70; i++)
            {
                sb.AppendFormat("auxseg_id_list({0}) = {1}{2}", i, m_auxseg_id_list[i], Environment.NewLine);
            }

            return sb.ToString();
        }

        /// <value>Property for wa2f3c</value>
        public Wa2F3c wa2f3c
        {
            get => m_wa2f3c;
            set => m_wa2f3c = value;
        }

        // Added auxseg fields
        /// <value>Property for auxseg_filler</value>
        public string auxseg_filler
        {
            get => m_auxseg_filler;
            set
            {
                int strlen = value.Length;
                strlen = Math.Min(strlen, 6);
                m_auxseg_filler = value.Substring(0, strlen);
            }
        }

        // Added auxseg fields
        /// <value>Property for auxseg_count</value>
        public string auxseg_count
        {
            get => m_auxseg_count;
            set
            {
                int strlen = value.Length;
                strlen = Math.Min(strlen, 4);
                m_auxseg_count = value.Substring(0, strlen);
            }
        }

        // Added auxseg fields
        /// <value>Property for auxseg_id_list() array</value>
        [XmlArrayItem("auxseg_id", typeof(string))]
        public string[] auxseg_id_list
        {
            get => m_auxseg_id_list;
            set => m_auxseg_id_list = value;
        }

        // Added auxseg fields
        /// <value>Property for auxseg_id_list() item</value>
        public string auxseg_id_list_item(int index) => m_auxseg_id_list[index];

        public void auxseg_id_list_item(int index, string value)
        {

            int strlen = value.Length;
            strlen = Math.Min(strlen, 7);
            m_auxseg_id_list[index] = new string(' ', 7);

            if (strlen > 0)
            {
                m_auxseg_id_list[index] = value.Substring(0, strlen);
            }
        }
    }

}
