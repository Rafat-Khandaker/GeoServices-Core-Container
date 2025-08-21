using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace GeoXWrapperLib.Model
{
    public class SegSideB7sc
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
        private string m_boro;
        private string m_census_tract_1990;
        private string m_census_tract_2010;
        private string m_census_block_2010;
        private string m_census_block_suffix_2010;
        private string m_census_tract_2000;
        private string m_census_block_2000;
        private string m_census_block_suffix_2000;
        private string m_nta;
        private string m_nta_name;
        private string m_puma_code;
        private string m_blockface_id;
        private string m_hcd;
        private string m_police_sector;
        private string m_census_tract_2020;
        private string m_census_block_2020;
        private string m_census_block_suffix_2020;
        private string m_nta_2020;
        private string m_cdta_2020;

        private string m_filler04;

        public ComDist comdist
        {
            get
            {
                return m_comdist;
            }
            set
            {
                m_comdist = value;
            }
        }

        public string lhnd
        {
            get
            {
                return m_lhnd;
            }
            set
            {
                int strlen = value.Length;
                if (strlen > 16) strlen = 16;
                m_lhnd = new string(' ', 16);
                if (strlen > 0)
                {
                    m_lhnd = value.Substring(0, strlen).PadRight(16);
                }
            }
        }

        public string hhnd
        {
            get
            {
                return m_hhnd;
            }
            set
            {
                int strlen = value.Length;
                if (strlen > 16) strlen = 16;
                m_hhnd = new string(' ', 16);
                if (strlen > 0)
                {
                    m_hhnd = value.Substring(0, strlen).PadRight(16);
                }
            }
        }

        public string alternate_lhnd
        {
            get
            {
                return m_alternate_lhnd;
            }
            set
            {
                int strlen = value.Length;
                if (strlen > 16) strlen = 16;
                m_alternate_lhnd = new string(' ', 16);
                if (strlen > 0)
                {
                    m_alternate_lhnd = value.Substring(0, strlen).PadRight(16);
                }
            }
        }

        public string alternate_hhnd
        {
            get
            {
                return m_alternate_hhnd;
            }
            set
            {
                int strlen = value.Length;
                if (strlen > 16) strlen = 16;
                m_alternate_hhnd = new string(' ', 16);
                if (strlen > 0)
                {
                    m_alternate_hhnd = value.Substring(0, strlen).PadRight(16);
                }
            }
        }

        public string iaei
        {
            get
            {
                return m_iaei;
            }
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_iaei = " ";
                if (strlen > 0)
                {
                    m_iaei = value.Substring(0, strlen).PadRight(1);
                }
            }
        }

        public string zip_code
        {
            get
            {
                return m_zip_code;
            }
            set
            {
                int strlen = value.Length;
                if (strlen > 5) strlen = 5;
                m_zip_code = "     ";
                if (strlen > 0)
                {
                    m_zip_code = value.Substring(0, strlen).PadRight(5);
                }
            }
        }

        public string health_area
        {
            get
            {
                return m_health_area;
            }
            set
            {
                int strlen = value.Length;
                if (strlen > 4) strlen = 4;
                m_health_area = "    ";
                if (strlen > 0)
                {
                    m_health_area = value.Substring(0, strlen).PadRight(4);
                }
            }
        }

        public string police_boro_com
        {
            get
            {
                return m_police_boro_com;
            }
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_police_boro_com = " ";
                if (strlen > 0)
                {
                    m_police_boro_com = value.Substring(0, strlen).PadRight(1);
                }
            }
        }

        public string police_pct
        {
            get
            {
                return m_police_pct;
            }
            set
            {
                int strlen = value.Length;
                if (strlen > 3) strlen = 3;
                m_police_pct = "   ";
                if (strlen > 0)
                {
                    m_police_pct = value.Substring(0, strlen).PadRight(3);
                }
            }
        }

        public string fire_div
        {
            get
            {
                return m_fire_div;
            }
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_fire_div = "  ";
                if (strlen > 0)
                {
                    m_fire_div = value.Substring(0, strlen).PadRight(2);
                }
            }
        }

        public string fire_bat
        {
            get
            {
                return m_fire_bat;
            }
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_fire_bat = "  ";
                if (strlen > 0)
                {
                    m_fire_bat = value.Substring(0, strlen).PadRight(2);
                }
            }
        }

        public string fire_co_type
        {
            get
            {
                return m_fire_co_type;
            }
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_fire_co_type = " ";
                if (strlen > 0)
                {
                    m_fire_co_type = value.Substring(0, strlen).PadRight(1);
                }
            }
        }

        public string fire_co_num
        {
            get
            {
                return m_fire_co_num;
            }
            set
            {
                int strlen = value.Length;
                if (strlen > 3) strlen = 3;
                m_fire_co_num = "   ";
                if (strlen > 0)
                {
                    m_fire_co_num = value.Substring(0, strlen).PadRight(3);
                }
            }
        }

        public string school_dist
        {
            get
            {
                return m_school_dist;
            }
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_school_dist = "  ";
                if (strlen > 0)
                {
                    m_school_dist = value.Substring(0, strlen).PadRight(2);
                }
            }
        }

        public string dynamic_block
        {
            get
            {
                return m_dynamic_block;
            }
            set
            {
                int strlen = value.Length;
                if (strlen > 3) strlen = 3;
                m_dynamic_block = "   ";
                if (strlen > 0)
                {
                    m_dynamic_block = value.Substring(0, strlen).PadRight(3);
                }
            }
        }

        public string ed
        {
            get
            {
                return m_ed;
            }
            set
            {
                int strlen = value.Length;
                if (strlen > 3) strlen = 3;
                m_ed = new string(' ', 3);
                if (strlen > 0)
                {
                    m_ed = value.Substring(0, strlen).PadRight(3);
                }
            }
        }

        public string ad
        {
            get
            {
                return m_ad;
            }
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_ad = new string(' ', 2);
                if (strlen > 0)
                {
                    m_ad = value.Substring(0, strlen).PadRight(2);
                }
            }
        }

        public string police_patrol_boro
        {
            get
            {
                return m_police_patrol_boro;
            }
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_police_patrol_boro = "  ";
                if (strlen > 0)
                {
                    m_police_patrol_boro = value.Substring(0, strlen).PadRight(2);
                }
            }
        }

        public string boro
        {
            get
            {
                return m_boro;
            }
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_boro = " ";
                if (strlen > 0)
                {
                    m_boro = value.Substring(0, strlen).PadRight(1);
                }
            }
        }

        public string census_tract_1990
        {
            get
            {
                return m_census_tract_1990;
            }
            set
            {
                int strlen = value.Length;
                if (strlen > 6) strlen = 6;
                m_census_tract_1990 = "      ";
                if (strlen > 0)
                {
                    m_census_tract_1990 = value.Substring(0, strlen).PadRight(6);
                }
            }
        }

        public string census_tract_2010
        {
            get
            {
                return m_census_tract_2010;
            }
            set
            {
                int strlen = value.Length;
                if (strlen > 6) strlen = 6;
                m_census_tract_2010 = "      ";
                if (strlen > 0)
                {
                    m_census_tract_2010 = value.Substring(0, strlen).PadRight(6);
                }
            }
        }

        public string census_block_2010
        {
            get
            {
                return m_census_block_2010;
            }
            set
            {
                int strlen = value.Length;
                if (strlen > 4) strlen = 4;
                m_census_block_2010 = "    ";
                if (strlen > 0)
                {
                    m_census_block_2010 = value.Substring(0, strlen).PadRight(4);
                }
            }
        }

        public string census_block_suffix_2010
        {
            get { return m_census_block_suffix_2010; }
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_census_block_suffix_2010 = " ";
                if (strlen > 0)
                {
                    m_census_block_suffix_2010 = value.Substring(0, strlen);
                }
            }
        }

        public string census_tract_2000
        {
            get { return m_census_tract_2000; }
            set
            {
                int strlen = value.Length;
                if (strlen > 6) strlen = 6;
                m_census_tract_2000 = "      ";
                if (strlen > 0)
                {
                    m_census_tract_2000 = value.Substring(0, strlen);
                }
            }
        }

        public string census_block_2000
        {
            get { return m_census_block_2000; }
            set
            {
                int strlen = value.Length;
                if (strlen > 4) strlen = 4;
                m_census_block_2000 = "    ";
                if (strlen > 0)
                {
                    m_census_block_2000 = value.Substring(0, strlen);
                }
            }
        }

        public string census_block_suffix_2000
        {
            get { return m_census_block_suffix_2000; }
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_census_block_suffix_2000 = " ";
                if (strlen > 0)
                {
                    m_census_block_suffix_2000 = value.Substring(0, strlen);
                }
            }
        }

        public string nta
        {
            get { return m_nta; }
            set
            {
                int strlen = value.Length;
                if (strlen > 4) strlen = 4;
                m_nta = new string(' ', 4);
                if (strlen > 0)
                {
                    m_nta = value.Substring(0, strlen);
                }
            }
        }

        public string nta_name
        {
            get { return m_nta_name; }
            set
            {
                int strlen = value.Length;
                if (strlen > 75) strlen = 75;
                m_nta_name = new string(' ', 75);
                if (strlen > 0)
                {
                    m_nta_name = value.Substring(0, strlen);
                }
            }
        }

        public string puma_code
        {
            get { return m_puma_code; }
            set
            {
                int strlen = value.Length;
                if (strlen > 5) strlen = 5;
                m_puma_code = "     ";
                if (strlen > 0)
                {
                    m_puma_code = value.Substring(0, strlen);
                }
            }
        }

        public string blockface_id
        {
            get { return m_blockface_id; }
            set
            {
                int strlen = value.Length;
                if (strlen > 10) strlen = 10;
                m_blockface_id = "     ";
                if (strlen > 0)
                {
                    m_blockface_id = value.Substring(0, strlen);
                }
            }
        }

        public string hcd
        {
            get { return m_hcd; }
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_hcd = "     ";
                if (strlen > 0)
                {
                    m_hcd = value.Substring(0, strlen);
                }
            }
        }

        public string police_sector
        {
            get { return m_police_sector; }
            set
            {
                int strlen = value.Length;
                if (strlen > 4) strlen = 4;
                m_police_sector = "     ";
                if (strlen > 0)
                {
                    m_police_sector = value.Substring(0, strlen);
                }
            }
        }

        public string census_tract_2020
        {
            get { return m_census_tract_2020; }
            set
            {
                int strlen = value.Length;
                if (strlen > 6) strlen = 6;
                m_census_tract_2020 = "      ";
                if (strlen > 0)
                {
                    m_census_tract_2020 = value.Substring(0, strlen);
                }
            }
        }

        public string census_block_2020
        {
            get { return m_census_block_2020; }
            set
            {
                int strlen = value.Length;
                if (strlen > 4) strlen = 4;
                m_census_block_2020 = "    ";
                if (strlen > 0)
                {
                    m_census_block_2020 = value.Substring(0, strlen);
                }
            }
        }

        public string census_block_suffix_2020
        {
            get { return m_census_block_suffix_2020; }
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_census_block_suffix_2020 = " ";
                if (strlen > 0)
                {
                    m_census_block_suffix_2020 = value.Substring(0, strlen);
                }
            }
        }

        public string nta_2020
        {
            get { return m_nta_2020; }
            set
            {
                int strlen = value.Length;
                if (strlen > 6) strlen = 6;
                m_nta_2020 = "      ";
                if (strlen > 0)
                {
                    m_nta_2020 = value.Substring(0, strlen);
                }
            }
        }

        public string cdta_2020
        {
            get { return m_cdta_2020; }
            set
            {
                int strlen = value.Length;
                if (strlen > 4) strlen = 4;
                m_cdta_2020 = "    ";
                if (strlen > 0)
                {
                    m_cdta_2020 = value.Substring(0, strlen);
                }
            }
        }

        public string filler04
        {
            get { return m_filler04; }
            set
            {
                int strlen = value.Length;
                if (strlen > 3) strlen = 3;
                m_filler04 = "   ";
                if (strlen > 0)
                {
                    m_filler04 = value.Substring(0, strlen);
                }
            }
        }



        public SegSideB7sc() => Initialize();
        

        public SegSideB7sc(string inString)
        {
            Initialize();
            SegSideB7scFromString(inString);
        }

        private void Initialize()
        {
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
            m_boro = new string(' ', 1);
            m_census_tract_1990 = new string(' ', 6);
            m_census_tract_2010 = new string(' ', 6);
            m_census_block_2010 = new string(' ', 4);
            m_census_block_suffix_2010 = new string(' ', 1);
            m_census_tract_2000 = new string(' ', 6);
            m_census_block_2000 = new string(' ', 4);
            m_census_block_suffix_2000 = new string(' ', 1);
            m_nta = new string(' ', 4);
            m_nta_name = new string(' ', 75);
            m_puma_code = new string(' ', 5);
            m_blockface_id = new string(' ', 10);
            m_hcd = new string(' ', 2);
            m_police_sector = new string(' ', 4);


            m_census_tract_2020 = new string(' ', 6);
            m_census_block_2020 = new string(' ', 4);
            m_census_block_suffix_2020 = new string(' ', 1);
            m_nta_2020 = new string(' ', 6);
            m_cdta_2020 = new string(' ', 4);

            m_filler04 = new string(' ', 3);
        }

        public void Clear() => SegSideB7scFromString(new string(' ', 254));
        public override string ToString() => SegSideB7scToString();
        public void FromString(string inString) => SegSideB7scFromString(inString);

        public void ToXml(ref XmlDocument indoc)
        {
            var xmlStream = new MemoryStream();
            var xmlFormatter = new XmlSerializer(typeof(SegSide));
            try
            {
                xmlFormatter.Serialize(xmlStream, this);
                xmlStream.Position = 0;
                indoc.Load(xmlStream);
            }
            catch (Exception ex) { throw ex; }
            finally { xmlStream.Close(); }
        }

        public string SegSideB7scToString()
        {
            var i = 0;
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
            //--spo(2011-09-24):  Geosupport 11.0 removed instruct_div and added ED, AD 
            sb.Append(m_ed);
            sb.Append(m_ad);
            //--spo(2014-11-10): added police patrol borough 
            //--                 replaces first 2 bytes of filler01 location 
            sb.Append(m_police_patrol_boro);
            //--spo(2012-04-06):  added for Geosupport Version 11.3 / Release 12A 
            sb.Append(m_boro);
            sb.Append(m_census_tract_1990);
            //--spo(2011-09-24):  Geosupport 11.0 added 2010 census and moved 2000 census fields
            sb.Append(m_census_tract_2010);
            sb.Append(m_census_block_2010);
            sb.Append(m_census_block_suffix_2010);
            sb.Append(m_census_tract_2000);
            sb.Append(m_census_block_2000);
            // spo(2008-06-04):  added new field, census_block_suffix_2000
            sb.Append(m_census_block_suffix_2000);
            //--spo(2012-04-06):  added for Geosupport Version 11.3 / Release 12A 
            sb.Append(m_nta);
            sb.Append(m_nta_name);
            sb.Append(m_puma_code);
            sb.Append(m_blockface_id);
            sb.Append(m_hcd);
            sb.Append(m_police_sector);

            //------------------------------------------------------------------
            //--spo(2021-05-04): Add 21 bytes for new census 2020 fields 
            //------------------------------------------------------------------
            sb.Append(m_census_tract_2020);
            sb.Append(m_census_block_2020);
            sb.Append(m_census_block_suffix_2020);
            sb.Append(m_nta_2020);
            sb.Append(m_cdta_2020);
            sb.Append(m_filler04);

            return sb.ToString();
        }

        public void SegSideB7scFromString(string inString)
        {
            // all fields have setters so use them

            m_comdist = new ComDist(inString.Substring(0, 3));
            m_lhnd = inString.Substring(3, 16);
            m_hhnd = inString.Substring(19, 16);
            m_alternate_lhnd = inString.Substring(35, 16);
            m_alternate_hhnd = inString.Substring(51, 16);
            m_iaei = inString.Substring(67, 1);
            m_zip_code = inString.Substring(68, 5);
            m_health_area = inString.Substring(73, 4);
            m_police_boro_com = inString.Substring(77, 1);
            m_police_pct = inString.Substring(78, 3);

            m_fire_div = inString.Substring(81, 2);
            m_fire_bat = inString.Substring(83, 2);
            m_fire_co_type = inString.Substring(85, 1);
            m_fire_co_num = inString.Substring(86, 3);

            m_school_dist = inString.Substring(89, 2);
            m_dynamic_block = inString.Substring(91, 3);

            // Geosupport 11.0 removed instruct_div and added ED, AD 
            m_ed = inString.Substring(94, 3);
            m_ad = inString.Substring(97, 2);

            // added police patrol borough 
            m_police_patrol_boro = inString.Substring(99, 2);

            // Geosupport Version 11.3 / Release 12A 
            m_boro = inString.Substring(101, 1);
            m_census_tract_1990 = inString.Substring(102, 6);

            // Geosupport 11.0 added 2010 census and moved 2000 census fields
            m_census_tract_2010 = inString.Substring(108, 6);
            m_census_block_2010 = inString.Substring(114, 4);
            m_census_block_suffix_2010 = inString.Substring(118, 1);
            m_census_tract_2000 = inString.Substring(119, 6);

            m_census_block_2000 = inString.Substring(125, 4);

            // added new field, census_block_suffix_2000
            m_census_block_suffix_2000 = inString.Substring(129, 1);
            nta = inString.Substring(130, 4);
            // Geosupport Version 11.3 / Release 12A 
            nta_name = inString.Substring(134, 75);
            m_puma_code = inString.Substring(209, 5);

            m_blockface_id = inString.Substring(214, 5);
            //m_blockface_id = inString.Substring(214, 10);  -- original logic with unit test errors 06/10/2025 R.K

            m_hcd = inString.Substring(224, 2);
            m_police_sector = inString.Substring(226, 4);

            // Add 21 bytes for new census 2020 fields 
            m_census_tract_2020 = inString.Substring(230, 6);
            m_census_block_2020 = inString.Substring(236, 4);
            m_census_block_suffix_2020 = inString.Substring(240, 1);
            m_nta_2020 = inString.Substring(241, 6);
            m_cdta_2020 = inString.Substring(247, 4);

            // filler04
            m_filler04 = inString.Substring(251, 3);
        }

        public string Display(char c)
        {
            StringBuilder sb = new StringBuilder();

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
            sb.Append(c);

            // Geosupport 11.0 removed instruct_div and added ED, AD 
            sb.Append(m_ed);
            sb.Append(c);
            sb.Append(m_ad);
            sb.Append(c);

            // Geosupport Version 11.3 / Release 12A - added police patrol borough 
            sb.Append(m_police_patrol_boro);
            sb.Append(c);

            // Geosupport Version 11.3 / Release 12A - added for census data
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

            // NJP 16.1 changes, added Geosupport Version 11.3 / Release 12A
            sb.Append(m_nta);
            sb.Append(c);
            sb.Append(m_nta_name);
            sb.Append(c);
            sb.Append(m_puma_code);
            sb.Append(c);
            sb.Append(m_blockface_id);
            sb.Append(c);
            sb.Append(m_hcd);
            sb.Append(c);
            sb.Append(m_police_sector);
            sb.Append(c);

            // Add 21 bytes for new census 2020 fields 
            sb.Append(m_census_tract_2020);
            sb.Append(c);
            sb.Append(m_census_block_2020);
            sb.Append(c);
            sb.Append(m_census_block_suffix_2020);
            sb.Append(c);
            sb.Append(m_nta_2020);
            sb.Append(c);
            sb.Append(m_cdta_2020);
            sb.Append(c);

            sb.Append(m_filler04);

            return sb.ToString();
        }

        public string Display() => this.Display('-');
        public string Print()
        {
            StringBuilder sb = new StringBuilder();

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

            // Geosupport 11.3 / Release 12A - added police patrol borough
            sb.AppendFormat("police_patrol_boro = {0}{1}", m_police_patrol_boro, Environment.NewLine);

            // Geosupport Version 11.3 / Release 12A - added for census data
            sb.AppendFormat("boro = {0}{1}", m_boro, Environment.NewLine);
            sb.AppendFormat("census_tract_1990 = {0}{1}", m_census_tract_1990, Environment.NewLine);

            // Geosupport 11.0 added 2010 census and moved 2000 census fields
            sb.AppendFormat("census_tract_2010 = {0}{1}", m_census_tract_2010, Environment.NewLine);
            sb.AppendFormat("census_block_2010 = {0}{1}", m_census_block_2010, Environment.NewLine);
            sb.AppendFormat("census_block_suffix_2010 = {0}{1}", m_census_block_suffix_2010, Environment.NewLine);
            sb.AppendFormat("census_tract_2000 = {0}{1}", m_census_tract_2000, Environment.NewLine);
            sb.AppendFormat("census_block_2000 = {0}{1}", m_census_block_2000, Environment.NewLine);
            sb.AppendFormat("census_block_suffix_2000 = {0}{1}", m_census_block_suffix_2000, Environment.NewLine);

            // Added for Geosupport Version 11.3 / Release 12A
            sb.AppendFormat("nta_2010 = {0}{1}", m_nta, Environment.NewLine);

            sb.AppendFormat("nta_name_2010 = {0}{1}", m_nta_name, Environment.NewLine);
            sb.AppendFormat("puma_code = {0}{1}", m_puma_code, Environment.NewLine);
            sb.AppendFormat("blockface_id = {0}{1}", m_blockface_id, Environment.NewLine);
            sb.AppendFormat("hcd = {0}{1}", m_hcd, Environment.NewLine);
            sb.AppendFormat("police_sector = {0}{1}", m_police_sector, Environment.NewLine);

            // Add 21 bytes for new census 2020 fields
            sb.AppendFormat("census_tract_2020 = {0}{1}", m_census_tract_2020, Environment.NewLine);
            sb.AppendFormat("census_block_2020 = {0}{1}", m_census_block_2020, Environment.NewLine);
            sb.AppendFormat("census_block_suffix_2020 = {0}{1}", m_census_block_suffix_2020, Environment.NewLine);
            sb.AppendFormat("nta_2020 = {0}{1}", m_nta_2020, Environment.NewLine);
            sb.AppendFormat("cdta_2020 = {0}{1}", m_cdta_2020, Environment.NewLine);

            sb.AppendFormat("filler04 = {0}{1}", m_filler04, Environment.NewLine);

            return sb.ToString();
        }



    }
}
