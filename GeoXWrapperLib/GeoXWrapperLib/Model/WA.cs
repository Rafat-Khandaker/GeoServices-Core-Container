using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace GeoXWrapperLib.Model
{
    public abstract class WA
    {
        // Abstract Methods
        public abstract void Clear();
        public abstract override string ToString();
        public abstract void FromString(string inString);
        public abstract string Display(char c);
        public abstract string Display();
        public abstract string Print();

        /// <summary>
        /// <c>StrToByteArray</c> converts a .NET string to a byte array.
        /// </summary>
        public static byte[] StrToByteArray(string str)
        {
            Encoding encoding = new ASCIIEncoding();
            return encoding.GetBytes(str);
        }

        /// <summary>
        /// <c>ByteArrayToStr</c> converts a byte array to a .NET string.
        /// </summary>
        public static string ByteArrayToStr(byte[] ba)
        {
            Encoding enc = new ASCIIEncoding();
            return enc.GetString(ba);
        }

        /// <summary>
        /// <c>ToXml</c> converts a <c>WA</c> object to an XML document.
        /// </summary>
        public void ToXml(ref XmlDocument indoc)
        {
            using (MemoryStream xmlStream = new MemoryStream())
            {
                XmlSerializer xmlFormatter = new XmlSerializer(this.GetType());

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
    }
}
