using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace GeoXWrapperLib.Model
{
    [Serializable]
    public class GeoConnCollection : CollectionBase
    {
        public GeoConnCollection() : base() { }

        public GeoConnCollection(string bstr) : base()
        {
            if (bstr == "GDE")
            {
                this.Add(new GeoConn("GDE"));
            }
            else
            {
                // Passed in ETX config file name to read
                this.ReadGeoConns(bstr);
            }
        }

        public GeoConn this[int index]
        {
            get { return (GeoConn)List[index]; }
            set { List[index] = value; }
        }

        public void Add(GeoConn aGeoConn)
        {
            List.Add(aGeoConn);
        }

        public void Insert(int index, GeoConn aGeoConn)
        {
            if (index >= Count || index < 0)
            {
                // MessageBox.Show("Index not valid");
            }
            else
            {
                List.Insert(index, aGeoConn);
            }
        }

        public void Remove(int index)
        {
            if (index >= Count || index < 0)
            {
                // MessageBox.Show("Index not valid");
            }
            else
            {
                List.RemoveAt(index);
            }
        }

        public void ReadGeoConns(string aFileName)
        {
            XPathDocument myXPathDocument = null;
            XPathNavigator myXPathNavigator = null;
            XPathNodeIterator myXPathNodeIterator = null;
            string myBroker = null;
            string myServer = null;
            int GeoConnCount = 0;

            try
            {
                myXPathDocument = new XPathDocument(aFileName);
            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error on XPathDocument: " + ex.Message);
                throw;
            }

            try
            {
                myXPathNavigator = myXPathDocument.CreateNavigator();
            }
            catch (Exception ex)
            {
                throw;
            }

            try
            {
                myXPathNodeIterator = myXPathNavigator.Select("//ArrayOfGeoConn/GeoConn");
            }
            catch (Exception ex)
            {
                throw;
            }

            if (myXPathNodeIterator.Count == 0)
            {
                throw new GeoConnsException("No GeoConns found in " + aFileName);
            }

            // Remove previous GeoConn objects if any
            this.Clear();

            while (myXPathNodeIterator.MoveNext())
            {
                if (myXPathNodeIterator.Current.HasChildren)
                {
                    myXPathNodeIterator.Current.MoveToFirstChild();
                    if (myXPathNodeIterator.Current.Name == "Broker")
                    {
                        myBroker = myXPathNodeIterator.Current.Value;
                        GeoConnCount++;
                    }

                    myXPathNodeIterator.Current.MoveToNext();
                    if (myXPathNodeIterator.Current.Name == "Server")
                    {
                        myServer = myXPathNodeIterator.Current.Value;
                    }

                    this.Add(new GeoConn(myBroker, myServer));
                }
            }

            if (GeoConnCount == 0)
            {
                throw new GeoConnsException("No GeoConn children found in " + aFileName);
            }
        }

        public void WriteXML(string aFileName)
        {
            // To serialize the workarea, you must first open a stream for writing.
            FileStream fsx = new FileStream(aFileName, FileMode.Create);
            // Construct an XMLFormatter and use it to serialize the data to the stream.
            XmlSerializer formatter = new XmlSerializer(typeof(GeoConnCollection));
            try
            {
                formatter.Serialize(fsx, this);
            }
            catch (Exception ex)
            {
                // MessageBox.Show("Failed to serialize XML. Reason: " + ex.Message);
                throw;
            }
            finally
            {
                fsx.Close();
            }
        }
    }
}
