using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace GeoXWrapperLib.Model
{
    public class FileInfo
    {
        private string m_recType;
        private string m_fileTag;
        private string m_fileDate;
        private string m_release;
        private string m_recCnt;

        /// <summary>Constructor for <c>FileInfo</c></summary>
        public FileInfo()
        {
            m_recType = new string(' ', 4);
            m_fileTag = new string(' ', 4);
            m_fileDate = new string(' ', 6);
            m_release = new string(' ', 4);
            m_recCnt = new string(' ', 8);
        }

        /// <summary>Constructor for <c>FileInfo</c></summary>
        public FileInfo(string inString)
        {
            FileInfoFromString(inString);
        }

        /// <summary><c>Clear</c> reinitializes the <c>FileInfo</c> object to spaces</summary>
        public void Clear()
        {
            FileInfoFromString(new string(' ', 26));
        }

        /// <summary><c>ToString</c> converts a <c>FileInfo</c> object to a string</summary>
        public override string ToString()
        {
            return FileInfoToString();
        }

        /// <summary><c>FromString</c> converts a string to a <c>FileInfo</c> object</summary>
        public void FromString(string inString)
        {
            FileInfoFromString(inString);
        }

        /// <summary><c>ToXml</c> converts a <c>FileInfo</c> object to an XML document</summary>
        public void ToXml(ref XmlDocument indoc)
        {
            using (MemoryStream xmlStream = new MemoryStream())
            {
                XmlSerializer xmlFormatter = new XmlSerializer(typeof(FileInfo));
                try
                {
                    xmlFormatter.Serialize(xmlStream, this);
                    xmlStream.Position = 0;
                    indoc.Load(xmlStream);
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        /// <summary><c>FileInfoToString</c> converts a <c>FileInfo</c> object to a string</summary>
        public string FileInfoToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(m_recType);
            sb.Append(m_fileTag);
            sb.Append(m_fileDate);
            sb.Append(m_release);
            sb.Append(m_recCnt);

            return sb.ToString();
        }

        /// <summary><c>FileInfoFromString</c> converts a string to a <c>FileInfo</c> object</summary>
        public void FileInfoFromString(string inString)
        {
            m_recType = inString.Substring(0, 4);
            m_fileTag = inString.Substring(4, 4);
            m_fileDate = inString.Substring(8, 6);
            m_release = inString.Substring(14, 4);
            m_recCnt = inString.Substring(18, 8);
        }

        /// <summary><c>Display</c> creates a string of <c>FileInfo</c> field values separated by a character</summary>
        public string Display(char c)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(m_recType);
            sb.Append(c);
            sb.Append(m_fileTag);
            sb.Append(c);
            sb.Append(m_fileDate);
            sb.Append(c);
            sb.Append(m_release);
            sb.Append(c);
            sb.Append(m_recCnt);

            return sb.ToString();
        }

        /// <summary><c>Display</c> creates a string of <c>FileInfo</c> field values separated by a dash</summary>
        public string Display()
        {
            return Display('-');
        }

        /// <summary><c>Print</c> creates a string with <c>FileInfo</c> field names and values</summary>
        public string Print()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("recType = {0}{1}", m_recType, Environment.NewLine);
            sb.AppendFormat("fileTag = {0}{1}", m_fileTag, Environment.NewLine);
            sb.AppendFormat("fileDate = {0}{1}", m_fileDate, Environment.NewLine);
            sb.AppendFormat("release = {0}{1}", m_release, Environment.NewLine);
            sb.AppendFormat("recCnt = {0}{1}", m_recCnt, Environment.NewLine);

            return sb.ToString();
        }

        /// <summary><value>Property for recType</value></summary>
        public string rec_type
        {
            get { return m_recType; }
            set
            {
                m_recType = value.Length > 4 ? value.Substring(0, 4) : value.PadRight(4, ' ');
            }
        }

        /// <summary><value>Property for fileTag</value></summary>
        public string file_tag
        {
            get { return m_fileTag; }
            set
            {
                m_fileTag = value.Length > 4 ? value.Substring(0, 4) : value.PadRight(4, ' ');
            }
        }

        /// <summary><value>Property for fileDate</value></summary>
        public string file_date
        {
            get { return m_fileDate; }
            set
            {
                m_fileDate = value.Length > 6 ? value.Substring(0, 6) : value.PadRight(6, ' ');
            }
        }

        /// <summary><value>Property for release</value></summary>
        public string release
        {
            get { return m_release; }
            set
            {
                m_release = value.Length > 4 ? value.Substring(0, 4) : value.PadRight(4, ' ');
            }
        }

        /// <summary><value>Property for recCnt</value></summary>
        public string rec_cnt
        {
            get { return m_recCnt; }
            set
            {
                m_recCnt = value.Length > 8 ? value.Substring(0, 8) : value.PadRight(8, ' ');
            }
        }
    }
}
