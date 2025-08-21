using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GeoXWrapperLib.Model
{
    public class Wa2F3cxas : WA
    {
        private Wa2F3cx m_wa2f3cx;
        private string m_auxseg_filler;
        private string m_auxseg_count;
        private string[] m_auxseg_id_list = new string[70];

        public Wa2F3cxas()
        {
            m_wa2f3cx = new Wa2F3cx();
            m_auxseg_filler = new string(' ', 6);
            m_auxseg_count = new string(' ', 4);
            for (int i = 0; i < 70; i++)
            {
                m_auxseg_id_list[i] = new string(' ', 7);
            }
        }

        public Wa2F3cxas(string inString) : this()
        {
            Wa2F3cxasFromString(inString);
        }

        public override void Clear() => Wa2F3cxasFromString(new string(' ', 1350));

        public override string ToString() => Wa2F3cxasToString();

        public override void FromString(string inString) => Wa2F3cxasFromString(inString);

        public string Wa2F3cxasToString()
        {
            var sb = new StringBuilder();
            sb.Append(m_wa2f3cx.ToString());
            sb.Append(m_auxseg_filler);
            sb.Append(m_auxseg_count);
            foreach (var auxsegId in m_auxseg_id_list)
            {
                sb.Append(auxsegId);
            }
            return sb.ToString();
        }

        public void Wa2F3cxasFromString(string inString)
        {
            m_wa2f3cx.FromString(inString.Substring(0, 850));
            m_auxseg_filler = inString.Substring(850, 6);
            m_auxseg_count = inString.Substring(856, 4);
            for (int i = 0; i < 70; i++)
            {
                try { m_auxseg_id_list[i] = inString.Substring(860 + (i * 7), 7); } catch { m_auxseg_id_list[i] = string.Empty ; }
            }
        }

        public override string Display(char c)
        {
            var sb = new StringBuilder();
            sb.Append(m_wa2f3cx.Display());
            sb.Append(c);
            sb.Append(m_auxseg_filler);
            sb.Append(c);
            sb.Append(m_auxseg_count);
            sb.Append(c);
            foreach (var auxsegId in m_auxseg_id_list)
            {
                sb.Append(auxsegId);
                sb.Append(c);
            }
            return sb.ToString();
        }

        public override string Display() => Display('-');

        public override string Print()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("{0}{1}", m_wa2f3cx.Print(), "\r\n");
            sb.AppendFormat("auxseg_filler = {0}{1}", m_auxseg_filler, "\r\n");
            sb.AppendFormat("auxseg_count = {0}{1}", m_auxseg_count, "\r\n");
            for (int i = 0; i < 70; i++)
            {
                sb.AppendFormat("auxseg_id_list({0}) = {1}{2}", i, m_auxseg_id_list[i], "\r\n");
            }
            return sb.ToString();
        }

        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("\r\n****************************************************************************\r\n");
            sb.AppendFormat("****************************  Wa2F3cxas  *********************************\r\n");
            sb.AppendFormat("****************************************************************************\r\n");
            sb.AppendFormat("{0}\r\n", m_wa2f3cx.Report());
            sb.AppendFormat("\r\n**********  Auxiliary Segment Information  **********\r\n\r\n");
            sb.AppendFormat("auxseg_filler = {0}\r\n", m_auxseg_filler);
            sb.AppendFormat("auxseg_count = {0}\r\n", m_auxseg_count);
            for (int i = 0; i < 70; i++)
            {
                sb.AppendFormat("auxseg_id_list({0}) = {1}\r\n", i, m_auxseg_id_list[i]);
            }
            return sb.ToString();
        }

        public Wa2F3cx wa2f3cx
        {
            get => m_wa2f3cx;
            set => m_wa2f3cx = value;
        }

        public string auxseg_filler
        {
            get => m_auxseg_filler;
            set => m_auxseg_filler = value.Length > 6 ? value.Substring(0, 6) : value;
        }

        public string auxseg_count
        {
            get => m_auxseg_count;
            set => m_auxseg_count = value.Length > 4 ? value.Substring(0, 4) : value;
        }

        [XmlArrayItem("auxseg_id")]
        public string[] auxseg_id_list
        {
            get => m_auxseg_id_list;
            set => m_auxseg_id_list = value;
        }

        public string AuxsegIdListItem(int index) => m_auxseg_id_list[index];

        public void AuxsegIdListItem(int index, string value)
        {
            m_auxseg_id_list[index] = new string(' ', 7);
            if (value.Length > 0)
            {
                m_auxseg_id_list[index] = value.Length > 7 ? value.Substring(0, 7) : value;
            }
        }
        
    }
}
