using System;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace GeoXWrapperLib.Model;
public class B10sc
{
    private string m_boro;
    private string m_sc5;
    private string m_lgc;
    private string m_spv;

    /// <summary>Constructor for B10sc</summary>
    public B10sc()
    {
        m_boro = new string(' ', 1);
        m_sc5 = new string(' ', 5);
        m_lgc = new string(' ', 2);
        m_spv = new string(' ', 3);
    }

    /// <summary>Constructor for B10sc</summary>
    public B10sc(string inString)
    {
        B10scFromString(inString);
    }

    /// <summary>Clear reinitializes the B10sc object to spaces</summary>
    public void Clear()
    {
        B10scFromString(new string(' ', 11));
    }

    /// <summary>ToString converts a B10sc object to a string</summary>
    public override string ToString()
    {
        return B10scToString();
    }

    /// <summary>FromString converts a string to a B10sc object</summary>
    public void FromString(string inString)
    {
        B10scFromString(inString);
    }

    /// <summary>ToXml converts a B10sc object to an XML document</summary>
    public void ToXml(ref XmlDocument indoc)
    {
        using (var xmlStream = new MemoryStream())
        {
            var xmlFormatter = new XmlSerializer(typeof(B10sc));
            try
            {
                xmlFormatter.Serialize(xmlStream, this);
                xmlStream.Position = 0;
                indoc.Load(xmlStream);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

    /// <summary>B10scToString converts a B10sc object to a string</summary>
    public string B10scToString()
    {
        var sb = new StringBuilder();
        sb.Append(m_boro);
        sb.Append(m_sc5);
        sb.Append(m_lgc);
        sb.Append(m_spv);

        return sb.ToString();
    }

    /// <summary>B10scFromString converts a string to a B10sc object</summary>
    public void B10scFromString(string inString)
    {
        try { m_boro = inString.Substring(0, 1); } catch { m_boro = string.Empty; }
        try { m_sc5 = inString.Substring(1, 5); } catch { m_sc5 = string.Empty; }
        try { m_lgc = inString.Substring(6, 2); } catch { m_lgc = string.Empty; }
        try { m_spv = inString.Substring(8, 3); } catch { m_spv = string.Empty; }
    }

    /// <summary>Display creates a string of B10sc field values separated by a character</summary>
    public string Display(char c)
    {
        var sb = new StringBuilder();
        sb.Append(m_boro);
        sb.Append(c);
        sb.Append(m_sc5);
        sb.Append(c);
        sb.Append(m_lgc);
        sb.Append(c);
        sb.Append(m_spv);

        return sb.ToString();
    }

    /// <summary>Display creates a string of B10sc field values separated by a dash</summary>
    public string Display()
    {
        return Display('-');
    }

    /// <summary>Print creates a string with B10sc field names and values</summary>
    public string Print()
    {
        var sb = new StringBuilder();
        sb.AppendFormat("boro = {0}\n", m_boro);
        sb.AppendFormat("sc5 = {0}\n", m_sc5);
        sb.AppendFormat("lgc = {0}\n", m_lgc);
        sb.AppendFormat("spv = {0}\n", m_spv);

        return sb.ToString();
    }

    /// <value>Property for boro</value>
    public string boro
    {
        get
        {
            return m_boro;
        }
        set
        {
            int strlen = value.Length;
            if (strlen > 1)
                strlen = 1;

            m_boro = " ";
            if (strlen > 0)
            {
                // The equivalent of Mid for strings in C# is assigning a substring to a specific index.
                m_boro = value.Substring(0, strlen).PadRight(1, ' ');
            }
        }
    }


    /// <value>Property for sc5</value>
    public string sc5
    {
        get
        {
            return m_sc5;
        }
        set
        {
            int strlen = value.Length;
            if (strlen > 5)
                strlen = 5;

            m_sc5 = "00000";
            if (strlen > 0)
            {
                // The equivalent of Mid for strings in C# is assigning a substring to a specific index.
                m_sc5 = m_sc5.Substring(0, 5 - strlen) + value.Substring(0, strlen);
            }
        }
    }


    /// <value>Property for lgc</value>
    public string lgc
    {
        get
        {
            return m_lgc;
        }
        set
        {
            int strlen = value.Length;
            if (strlen > 2)
                strlen = 2;

            m_lgc = "00";
            if (strlen > 0)
            {
                // Replace Mid with Substring and adjust the string
                m_lgc = m_lgc.Substring(0, 2 - strlen) + value.Substring(0, strlen);
            }
        }
    }


    /// <value>Property for spv</value>
    public string spv
    {
        get
        {
            return m_spv;
        }
        set
        {
            int strlen = value.Length;
            if (strlen > 3)
                strlen = 3;

            m_spv = "000";
            if (strlen > 0)
            {
                // Replace Mid with Substring and adjust the string
                m_spv = m_spv.Substring(0, 3 - strlen) + value.Substring(0, strlen);
            }
        }
    }

}
