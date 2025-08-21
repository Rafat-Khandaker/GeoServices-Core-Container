using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace GeoXWrapperLib.Model
{
    public class SegSide
    {
        private ComDist m_comdist;
        private string m_lhnd;
        private string m_hhnd;
        private string m_alternate_lhnd;
        private string m_alternate_hhnd;
        private string m_iaei;
        private string m_zip_code;
        private string m_health_area;
        private string m_police_boro_com;
        private string m_police_pct;
        private string m_fire_div;
        private string m_fire_bat;
        private string m_fire_co_type;
        private string m_fire_co_num;
        private string m_school_dist;
        private string m_dynamic_block;
        private string m_ed;
        private string m_ad;
        private string m_police_patrol_boro;
        private string m_filler01;
        private string m_boro;
        private string m_census_tract_1990;
        private string m_census_tract_2010;
        private string m_census_block_2010;
        private string m_census_block_suffix_2010;
        private string m_census_tract_2000;
        private string m_census_block_2000;
        private string m_census_block_suffix_2000;
        private string m_filler03;
        private string m_nta;
        private string m_filler02;

        public SegSide() {
            m_comdist = new ComDist();
            m_lhnd = new string(' ', 16);
            m_hhnd = new string(' ', 16);
            m_alternate_lhnd = new string(' ', 16);
            m_alternate_hhnd = new string(' ', 16);
            m_iaei = new string(' ', 1);
            m_zip_code = new string(' ', 5);
            m_health_area = new string(' ', 4);
            m_police_boro_com = new string(' ', 1);
            m_police_pct = new string(' ', 3);
            m_fire_div = new string(' ', 2);
            m_fire_bat = new string(' ', 2);
            m_fire_co_type = new string(' ', 1);
            m_fire_co_num = new string(' ', 3);
            m_school_dist = new string(' ', 2);
            m_dynamic_block = new string(' ', 3);
            m_ed = new string(' ', 3);
            m_ad = new string(' ', 2);
            m_police_patrol_boro = new string(' ', 2);
            m_filler01 = new string(' ', 1);
            m_boro = new string(' ', 1);
            m_census_tract_1990 = new string(' ', 6);
            m_census_tract_2010 = new string(' ', 6);
            m_census_block_2010 = new string(' ', 4);
            m_census_block_suffix_2010 = new string(' ', 1);
            m_census_tract_2000 = new string(' ', 6);
            m_census_block_2000 = new string(' ', 4);
            m_census_block_suffix_2000 = new string(' ', 1);
            m_filler03 = new string(' ', 7);
            m_nta = new string(' ', 4);
            m_filler02 = new string(' ', 8);
        }
        public SegSide(string inString)
        {
            this.Clear();  // Calls the parameterless constructor to initialize fields
            this.SegSideFromString(inString);
        }

        // Clear method to reinitialize the object
        public void Clear()
        {
            SegSideFromString(new string(' ', 150));
        }

        // ToString method
        public override string ToString()
        {
            return this.SegSideToString();
        }

        // FromString method that converts a string to a SegSide object
        public void FromString(string inString)
        {
            SegSideFromString(inString);
        }

        // ToXml method that converts the object to XML
        public void ToXml(ref XmlDocument indoc)
        {
            using (var xmlStream = new MemoryStream())
            {
                var xmlFormatter = new XmlSerializer(typeof(SegSide));
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

        // SegSideToString method that converts the object to a string
        public string SegSideToString()
        {
            var sb = new StringBuilder();

            sb.Append(m_comdist.ComDistToString());
            sb.Append(m_lhnd);
            sb.Append(m_hhnd);
            sb.Append(m_alternate_lhnd);
            sb.Append(m_alternate_hhnd);
            sb.Append(m_iaei);
            sb.Append(m_zip_code);
            sb.Append(m_health_area);
            sb.Append(m_police_boro_com);
            sb.Append(m_police_pct);
            sb.Append(m_fire_div);
            sb.Append(m_fire_bat);
            sb.Append(m_fire_co_type);
            sb.Append(m_fire_co_num);
            sb.Append(m_school_dist);
            sb.Append(m_dynamic_block);
            sb.Append(m_ed);
            sb.Append(m_ad);
            sb.Append(m_police_patrol_boro);
            sb.Append(m_filler01);
            sb.Append(m_boro);
            sb.Append(m_census_tract_1990);
            sb.Append(m_census_tract_2010);
            sb.Append(m_census_block_2010);
            sb.Append(m_census_block_suffix_2010);
            sb.Append(m_census_tract_2000);
            sb.Append(m_census_block_2000);
            sb.Append(m_census_block_suffix_2000);
            sb.Append(m_filler03);
            sb.Append(m_nta);
            sb.Append(m_filler02);

            return sb.ToString();
        }

        // SegSideFromString method that converts a string to a SegSide object
        
        public void SegSideFromString(string inString)
        {
            // All fields have setters, so use them

            comdist = new ComDist(inString.Substring(0, 3));
            lhnd = inString.Substring(3, 16);
            hhnd = inString.Substring(19, 16);
            alternate_lhnd = inString.Substring(35, 16);
            alternate_hhnd = inString.Substring(51, 16);
            iaei = inString.Substring(67, 1);
            zip_code = inString.Substring(68, 5);
            health_area = inString.Substring(73, 4);
            police_boro_com = inString.Substring(77, 1);
            police_pct = inString.Substring(78, 3);
            fire_div = inString.Substring(81, 2);
            fire_bat = inString.Substring(83, 2);
            fire_co_type = inString.Substring(85, 1);
            fire_co_num = inString.Substring(86, 3);
            school_dist = inString.Substring(89, 2);
            dynamic_block = inString.Substring(91, 3);

            // Geosupport 11.0 removed instruct_div and added ED, AD
            ed = inString.Substring(94, 3);
            ad = inString.Substring(97, 2);

            // Geosupport 11.0 added police patrol borough
            police_patrol_boro = inString.Substring(99, 2);
            filler01 = inString.Substring(101, 1);

            // Added for Geosupport Version 11.3 / Release 12A
            boro = inString.Substring(102, 1);
            census_tract_1990 = inString.Substring(103, 6);

            // Geosupport 11.0 added 2010 census and moved 2000 census fields
            census_tract_2010 = inString.Substring(109, 6);
            census_block_2010 = inString.Substring(115, 4);
            census_block_suffix_2010 = inString.Substring(119, 1);
            census_tract_2000 = inString.Substring(120, 6);

            census_block_2000 = inString.Substring(126, 4);
            census_block_suffix_2000 = inString.Substring(130, 1);

            // njp(2016-02-17) 16.1 changes.
            filler03 = inString.Substring(131, 7);

            // Added for Geosupport Version 11.3 / Release 12A
            nta = inString.Substring(138, 4);
            filler02 = inString.Substring(142, 8);
        }

        public string Display(char c)
        {
            var sb = new StringBuilder();

            sb.Append(m_comdist.Display());
            sb.Append(c);
            sb.Append(m_lhnd);
            sb.Append(c);
            sb.Append(m_hhnd);
            sb.Append(c);
            sb.Append(m_alternate_lhnd);
            sb.Append(c);
            sb.Append(m_alternate_hhnd);
            sb.Append(c);
            sb.Append(m_iaei);
            sb.Append(c);
            sb.Append(m_zip_code);
            sb.Append(c);
            sb.Append(m_health_area);
            sb.Append(c);
            sb.Append(m_police_boro_com);
            sb.Append(c);
            sb.Append(m_police_pct);
            sb.Append(c);
            sb.Append(m_fire_div);
            sb.Append(c);
            sb.Append(m_fire_bat);
            sb.Append(c);
            sb.Append(m_fire_co_type);
            sb.Append(c);
            sb.Append(m_fire_co_num);
            sb.Append(c);
            sb.Append(m_school_dist);
            sb.Append(c);
            sb.Append(m_dynamic_block);

            // Geosupport 11.0 removed instruct_div and added ED, AD
            sb.Append(m_ed);
            sb.Append(c);
            sb.Append(m_ad);
            sb.Append(c);

            // Geosupport 11.0 added police patrol borough
            sb.Append(m_police_patrol_boro);
            sb.Append(c);
            sb.Append(m_filler01);
            sb.Append(c);

            // Added for Geosupport Version 11.3 / Release 12A
            sb.Append(m_boro);
            sb.Append(c);
            sb.Append(m_census_tract_1990);
            sb.Append(c);

            // Geosupport 11.0 added 2010 census and moved 2000 census fields
            sb.Append(m_census_tract_2010);
            sb.Append(c);
            sb.Append(m_census_block_2010);
            sb.Append(c);
            sb.Append(m_census_block_suffix_2010);
            sb.Append(c);
            sb.Append(m_census_tract_2000);
            sb.Append(c);
            sb.Append(m_census_block_2000);
            sb.Append(c);
            sb.Append(m_census_block_suffix_2000);
            sb.Append(c);

            // njp(2016-02-17) 16.1 changes.
            sb.Append(m_filler03);
            sb.Append(c);

            // Added for Geosupport Version 11.3 / Release 12A
            sb.Append(m_nta);
            sb.Append(c);
            sb.Append(m_filler02);

            return sb.ToString();
        }

        public string Display()
        {
            return this.Display('-');
        }

        public string Print()
        {
            var sb = new StringBuilder();

            sb.AppendFormat("comdist = {0}{1}", m_comdist.Display(), Environment.NewLine);
            sb.AppendFormat("lhnd = {0}{1}", m_lhnd, Environment.NewLine);
            sb.AppendFormat("hhnd = {0}{1}", m_hhnd, Environment.NewLine);
            sb.AppendFormat("alternate_lhnd = {0}{1}", m_alternate_lhnd, Environment.NewLine);
            sb.AppendFormat("alternate_hhnd = {0}{1}", m_alternate_hhnd, Environment.NewLine);
            sb.AppendFormat("iaei = {0}{1}", m_iaei, Environment.NewLine);
            sb.AppendFormat("zip_code = {0}{1}", m_zip_code, Environment.NewLine);
            sb.AppendFormat("health_area = {0}{1}", m_health_area, Environment.NewLine);
            sb.AppendFormat("police_boro_com = {0}{1}", m_police_boro_com, Environment.NewLine);
            sb.AppendFormat("police_pct = {0}{1}", m_police_pct, Environment.NewLine);
            sb.AppendFormat("fire_div = {0}{1}", m_fire_div, Environment.NewLine);
            sb.AppendFormat("fire_bat = {0}{1}", m_fire_bat, Environment.NewLine);
            sb.AppendFormat("fire_co_type = {0}{1}", m_fire_co_type, Environment.NewLine);
            sb.AppendFormat("fire_co_num = {0}{1}", m_fire_co_num, Environment.NewLine);
            sb.AppendFormat("school_dist = {0}{1}", m_school_dist, Environment.NewLine);
            sb.AppendFormat("dynamic_block = {0}{1}", m_dynamic_block, Environment.NewLine);

            // Geosupport 11.0 removed instruct_div and added ED, AD
            sb.AppendFormat("ed = {0}{1}", m_ed, Environment.NewLine);
            sb.AppendFormat("ad = {0}{1}", m_ad, Environment.NewLine);

            // Geosupport 11.0 added police patrol borough
            sb.AppendFormat("police_patrol_boro = {0}{1}", m_police_patrol_boro, Environment.NewLine);
            sb.AppendFormat("filler01 = {0}{1}", m_filler01, Environment.NewLine);

            // Added for Geosupport Version 11.3 / Release 12A
            sb.AppendFormat("boro = {0}{1}", m_boro, Environment.NewLine);
            sb.AppendFormat("census_tract_1990 = {0}{1}", m_census_tract_1990, Environment.NewLine);

            // Geosupport 11.0 added 2010 census and moved 2000 census fields
            sb.AppendFormat("census_tract_2010 = {0}{1}", m_census_tract_2010, Environment.NewLine);
            sb.AppendFormat("census_block_2010 = {0}{1}", m_census_block_2010, Environment.NewLine);
            sb.AppendFormat("census_block_suffix_2010 = {0}{1}", m_census_block_suffix_2010, Environment.NewLine);
            sb.AppendFormat("census_tract_2000 = {0}{1}", m_census_tract_2000, Environment.NewLine);
            sb.AppendFormat("census_block_2000 = {0}{1}", m_census_block_2000, Environment.NewLine);
            sb.AppendFormat("census_block_suffix_2000 = {0}{1}", m_census_block_suffix_2000, Environment.NewLine);

            // njp(2016-02-17) 16.1 changes.
            sb.AppendFormat("filler03 = {0}{1}", m_filler03, Environment.NewLine);

            // Added for Geosupport Version 11.3 / Release 12A
            sb.AppendFormat("nta_2010 = {0}{1}", m_nta, Environment.NewLine);
            sb.AppendFormat("filler02 = {0}{1}", m_filler02, Environment.NewLine);

            return sb.ToString();
        }

        public ComDist comdist
        {
            get => m_comdist;
            set => m_comdist = value;
        }

        public string lhnd
        {
            get => m_lhnd;
            set => m_lhnd = new string(' ', 16).Substring(0, Math.Min(value.Length, 16)).PadRight(16);
        }

        public string hhnd
        {
            get => m_hhnd;
            set => m_hhnd = new string(' ', 16).Substring(0, Math.Min(value.Length, 16)).PadRight(16);
        }

        public string alternate_lhnd
        {
            get => m_alternate_lhnd;
            set => m_alternate_lhnd = new string(' ', 16).Substring(0, Math.Min(value.Length, 16)).PadRight(16);
        }

        public string alternate_hhnd
        {
            get => m_alternate_hhnd;
            set => m_alternate_hhnd = new string(' ', 16).Substring(0, Math.Min(value.Length, 16)).PadRight(16);
        }

        public string iaei
        {
            get => m_iaei;
            set => m_iaei = value.Substring(0, Math.Min(value.Length, 1));
        }

        public string zip_code
        {
            get => m_zip_code;
            set => m_zip_code = new string(' ', 5).Substring(0, Math.Min(value.Length, 5)).PadRight(5);
        }

        public string health_area
        {
            get => m_health_area;
            set => m_health_area = new string(' ', 4).Substring(0, Math.Min(value.Length, 4)).PadRight(4);
        }

        public string police_boro_com
        {
            get => m_police_boro_com;
            set => m_police_boro_com = value.Substring(0, Math.Min(value.Length, 1));
        }

        public string police_pct
        {
            get => m_police_pct;
            set => m_police_pct = value.Substring(0, Math.Min(value.Length, 3)).PadRight(3);
        }

        public string fire_div
        {
            get => m_fire_div;
            set => m_fire_div = value.Substring(0, Math.Min(value.Length, 2)).PadRight(2);
        }

        public string fire_bat
        {
            get => m_fire_bat;
            set => m_fire_bat = value.Substring(0, Math.Min(value.Length, 2)).PadRight(2);
        }

        public string fire_co_type
        {
            get => m_fire_co_type;
            set => m_fire_co_type = value.Substring(0, Math.Min(value.Length, 1)).PadRight(1);
        }

        public string fire_co_num
        {
            get => m_fire_co_num;
            set => m_fire_co_num = value.Substring(0, Math.Min(value.Length, 3)).PadRight(3);
        }

        public string school_dist
        {
            get => m_school_dist;
            set => m_school_dist = value.Substring(0, Math.Min(value.Length, 2)).PadRight(2);
        }

        public string dynamic_block
        {
            get => m_dynamic_block;
            set => m_dynamic_block = value.Substring(0, Math.Min(value.Length, 3)).PadRight(3);
        }

        public string ed
        {
            get => m_ed;
            set => m_ed = value.Substring(0, Math.Min(value.Length, 3)).PadRight(3);
        }

        public string ad
        {
            get => m_ad;
            set => m_ad = value.Substring(0, Math.Min(value.Length, 2)).PadRight(2);
        }

        public string police_patrol_boro
        {
            get => m_police_patrol_boro;
            set => m_police_patrol_boro = value.Substring(0, Math.Min(value.Length, 2)).PadRight(2);
        }

        public string filler01
        {
            get => m_filler01;
            set => m_filler01 = value.Substring(0, Math.Min(value.Length, 1)).PadRight(1);
        }

        public string boro
        {
            get => m_boro;
            set => m_boro = value.Substring(0, Math.Min(value.Length, 1)).PadRight(1);
        }

        public string census_tract_1990
        {
            get => m_census_tract_1990;
            set => m_census_tract_1990 = value.Substring(0, Math.Min(value.Length, 6)).PadRight(6);
        }

        public string census_tract_2010
        {
            get => m_census_tract_2010;
            set => m_census_tract_2010 = value.Substring(0, Math.Min(value.Length, 6)).PadRight(6);
        }

        public string census_block_2010
        {
            get => m_census_block_2010;
            set => m_census_block_2010 = value.Substring(0, Math.Min(value.Length, 4)).PadRight(4);
        }

        public string census_block_suffix_2010
        {
            get => m_census_block_suffix_2010;
            set => m_census_block_suffix_2010 = value.Substring(0, Math.Min(value.Length, 1)).PadRight(1);
        }

        public string census_tract_2000
        {
            get => m_census_tract_2000;
            set => m_census_tract_2000 = value.Substring(0, Math.Min(value.Length, 6)).PadRight(6);
        }

        public string census_block_2000
        {
            get => m_census_block_2000;
            set => m_census_block_2000 = value.Substring(0, Math.Min(value.Length, 4)).PadRight(4);
        }

        public string census_block_suffix_2000
        {
            get => m_census_block_suffix_2000;
            set => m_census_block_suffix_2000 = value.Substring(0, Math.Min(value.Length, 1)).PadRight(1);
        }

        public string filler03
        {
            get => m_filler03;
            set => m_filler03 = value.Substring(0, Math.Min(value.Length, 7)).PadRight(7);
        }

        public string nta
        {
            get => m_nta;
            set => m_nta = value.Substring(0, Math.Min(value.Length, 4)).PadRight(4);
        }

        public string filler02
        {
            get => m_filler02;
            set => m_filler02 = value.Substring(0, Math.Min(value.Length, 8)).PadRight(8);
        }

    }

}

