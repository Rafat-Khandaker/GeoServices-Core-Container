using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperLib.Model
{
    public class Wa2F2 : WA
    {
        private string m_gridkey2 = new string(' ', 21);
        private string m_dup_intersect_cnt = new string(' ', 1);
        private string m_dcp_pref_lgc1 = new string(' ', 2);
        private string m_dcp_pref_lgc2 = new string(' ', 2);
        private string m_x_sts_cnt = new string(' ', 1);
        private B5sc[] m_x_sts = new B5sc[5];
        private string m_compass = new string(' ', 1);
        private string m_atomic_polygon = new string(' ', 3);
        private string m_filler01 = new string(' ', 2);
        private string m_lion_node_num = new string(' ', 7);
        private string m_x_coord = new string(' ', 7);
        private string m_y_coord = new string(' ', 7);
        private string m_z_coord = new string(' ', 7);
        private Sanborn m_sanborn1 = new Sanborn();
        private Sanborn m_sanborn2 = new Sanborn();
        private string m_mh_ri_flag = new string(' ', 1);
        private string m_dot_st_light_contract_area = new string(' ', 1);
        private ComDist m_com_dist = new ComDist();
        private string m_zip_code = new string(' ', 5);
        private string m_health_area = new string(' ', 4);
        private string m_police_boro_com = new string(' ', 1);
        private string m_police_pct = new string(' ', 3);
        private string m_fire_div = new string(' ', 2);
        private string m_fire_bat = new string(' ', 2);
        private string m_fire_co_type = new string(' ', 1);
        private string m_fire_co_num = new string(' ', 3);
        private string m_school_dist = new string(' ', 2);
        private string m_census_tract_2010 = new string(' ', 6);
        private string m_census_tract_1990 = new string(' ', 6);
        private string m_filler_level_codes = new string(' ', 10);
        private string m_police_patrol_boro = new string(' ', 2);
        private string m_ad = new string(' ', 2);
        private string m_cd = new string(' ', 2);
        private string m_sd = new string(' ', 2);
        private string m_mc = new string(' ', 2);
        private string m_co = new string(' ', 2);
        private string m_cd_eligible = new string(' ', 1);
        private string m_duplicate_intersection_distance = new string(' ', 5);
        private string m_census_tract_2000 = new string(' ', 6);
        private string m_health_center_dist = new string(' ', 2);
        private string m_san_dist = new string(' ', 3);
        private string m_san_sub_section = new string(' ', 2);
        private string m_police_sector = new string(' ', 4);
        private string m_census_tract_2020 = new string(' ', 6);
        private string m_filler02 = new string(' ', 2);

        public Wa2F2()
        {
            m_gridkey2 = new string(' ', 21);
            m_dup_intersect_cnt = new string(' ', 1);
            m_dcp_pref_lgc1 = new string(' ', 2);
            m_dcp_pref_lgc2 = new string(' ', 2);
            m_x_sts_cnt = new string(' ', 1);

            for (int i = 0; i <= 4; i++)
            {
                m_x_sts[i] = new B5sc();
            }

            m_compass = new string(' ', 1);
            m_atomic_polygon = new string(' ', 3);
            m_filler01 = new string(' ', 2);
            m_lion_node_num = new string(' ', 7);
            m_x_coord = new string(' ', 7);
            m_y_coord = new string(' ', 7);
            m_z_coord = new string(' ', 7);
            m_sanborn1 = new Sanborn();
            m_sanborn2 = new Sanborn();
            m_mh_ri_flag = new string(' ', 1);
            m_dot_st_light_contract_area = new string(' ', 1);
            m_com_dist = new ComDist();
            m_zip_code = new string(' ', 5);
            m_health_area = new string(' ', 4);
            m_police_boro_com = new string(' ', 1);
            m_police_pct = new string(' ', 3);
            m_fire_div = new string(' ', 2);
            m_fire_bat = new string(' ', 2);
            m_fire_co_type = new string(' ', 1);
            m_fire_co_num = new string(' ', 3);
            m_school_dist = new string(' ', 2);
            m_census_tract_2010 = new string(' ', 6);
            m_census_tract_1990 = new string(' ', 6);
            m_filler_level_codes = new string(' ', 10);
            m_police_patrol_boro = new string(' ', 2);
            m_ad = new string(' ', 2);
            m_cd = new string(' ', 2);
            m_sd = new string(' ', 2);
            m_mc = new string(' ', 2);
            m_co = new string(' ', 2);
            m_cd_eligible = new string(' ', 1);
            m_duplicate_intersection_distance = new string(' ', 5);
            m_census_tract_2000 = new string(' ', 6);
            m_health_center_dist = new string(' ', 2);
            m_san_dist = new string(' ', 3);
            m_san_sub_section = new string(' ', 2);
            m_police_sector = new string(' ', 4);
            m_census_tract_2020 = new string(' ', 6);
            m_filler02 = new string(' ', 2);

        }

        public Wa2F2(string inString) => Wa2F2FromString(inString);

        public override void Clear() => Wa2F2FromString(new string(' ', 200));

        public override string ToString() => Wa2F2ToString();

        public override void FromString(string inString) => Wa2F2FromString(inString);

        public string Wa2F2ToString()
        {
            var sb = new StringBuilder();
            sb.Append(m_gridkey2).Append(m_dup_intersect_cnt)
              .Append(m_dcp_pref_lgc1).Append(m_dcp_pref_lgc2)
              .Append(m_x_sts_cnt);

            foreach (var x in m_x_sts)
            {
                sb.Append(x.B5scToString());
            }

            sb.Append(m_compass).Append(m_atomic_polygon)
              .Append(m_filler01).Append(m_lion_node_num)
              .Append(m_x_coord).Append(m_y_coord)
              .Append(m_z_coord).Append(m_sanborn1.SanbornToString())
              .Append(m_sanborn2.SanbornToString())
              .Append(m_mh_ri_flag).Append(m_dot_st_light_contract_area)
              .Append(m_com_dist.ComDistToString()).Append(m_zip_code)
              .Append(m_health_area).Append(m_police_boro_com)
              .Append(m_police_pct).Append(m_fire_div).Append(m_fire_bat)
              .Append(m_fire_co_type).Append(m_fire_co_num)
              .Append(m_school_dist).Append(m_census_tract_2010)
              .Append(m_census_tract_1990).Append(m_filler_level_codes)
              .Append(m_police_patrol_boro).Append(m_ad).Append(m_cd)
              .Append(m_sd).Append(m_mc).Append(m_co)
              .Append(m_cd_eligible).Append(m_duplicate_intersection_distance)
              .Append(m_census_tract_2000).Append(m_health_center_dist)
              .Append(m_san_dist).Append(m_san_sub_section)
              .Append(m_police_sector).Append(m_census_tract_2020)
              .Append(m_filler02);

            return sb.ToString();
        }

        public void Wa2F2FromString(string inString)
        {
            m_gridkey2 = inString.Substring(0, 21);
            m_dup_intersect_cnt = inString.Substring(21, 1);
            m_dcp_pref_lgc1 = inString.Substring(22, 2);
            m_dcp_pref_lgc2 = inString.Substring(24, 2);
            m_x_sts_cnt = inString.Substring(26, 1);

            for (int i = 0; i < 5; i++)
            {
                try { m_x_sts[i] = new B5sc(inString.Substring(27 + (i * 6), 6)); } catch { m_x_sts[i] = new B5sc(); }
            }

            m_compass = inString.Substring(57, 1);
            m_atomic_polygon = inString.Substring(58, 3);
            m_filler01 = inString.Substring(61, 2);
            m_lion_node_num = inString.Substring(63, 7);
            m_x_coord = inString.Substring(70, 7);
            m_y_coord = inString.Substring(77, 7);
            m_z_coord = inString.Substring(84, 7);
            m_sanborn1 = new Sanborn(inString.Substring(91, 8));
            m_sanborn2 = new Sanborn(inString.Substring(99, 8));
            m_mh_ri_flag = inString.Substring(107, 1);
            m_dot_st_light_contract_area = inString.Substring(108, 1);
            m_com_dist = new ComDist(inString.Substring(109, 3));
            m_zip_code = inString.Substring(112, 5);
            m_health_area = inString.Substring(117, 4);
            m_police_boro_com = inString.Substring(121, 1);
            m_police_pct = inString.Substring(122, 3);
            m_fire_div = inString.Substring(125, 2);
            m_fire_bat = inString.Substring(127, 2);
            m_fire_co_type = inString.Substring(129, 1);
            m_fire_co_num = inString.Substring(130, 3);
            m_school_dist = inString.Substring(133, 2);
            m_census_tract_2010 = inString.Substring(135, 6);
            m_census_tract_1990 = inString.Substring(141, 6);
            m_filler_level_codes = inString.Substring(147, 10);
            m_police_patrol_boro = inString.Substring(157, 2);
            m_ad = inString.Substring(159, 2);
            m_cd = inString.Substring(161, 2);
            m_sd = inString.Substring(163, 2);
            m_mc = inString.Substring(165, 2);
            m_co = inString.Substring(167, 2);
            m_cd_eligible = inString.Substring(169, 1);
            m_duplicate_intersection_distance = inString.Substring(170, 5);
            m_census_tract_2000 = inString.Substring(175, 6);
            m_health_center_dist = inString.Substring(181, 2);
            m_san_dist = inString.Substring(183, 3);
            m_san_sub_section = inString.Substring(186, 2);
            m_police_sector = inString.Substring(188, 4);
            m_census_tract_2020 = inString.Substring(192, 6);
            m_filler02 = inString.Substring(198, 2);
        }

        public override string Display(char c)
        {
            var sb = new StringBuilder();

            sb.Append(m_gridkey2)
              .Append(c)
              .Append(m_dup_intersect_cnt)
              .Append(c)
              .Append(m_dcp_pref_lgc1)
              .Append(c)
              .Append(m_dcp_pref_lgc2)
              .Append(c)
              .Append(m_x_sts_cnt)
              .Append(c);

            for (int i = 0; i <= 4; i++)
            {
                sb.Append(m_x_sts[i].Display())
                  .Append(c);
            }

            sb.Append(m_compass)
              .Append(c)
              .Append(m_atomic_polygon)
              .Append(c)
              .Append(m_filler01)
              .Append(c)
              .Append(m_lion_node_num)
              .Append(c)
              .Append(m_x_coord)
              .Append(c)
              .Append(m_y_coord)
              .Append(c)
              .Append(m_z_coord)
              .Append(c)
              .Append(m_sanborn1.Display())
              .Append(c)
              .Append(m_sanborn2.Display())
              .Append(c)
              .Append(m_mh_ri_flag)
              .Append(c)
              .Append(m_dot_st_light_contract_area)
              .Append(c)
              .Append(m_com_dist.Display())
              .Append(c)
              .Append(m_zip_code)
              .Append(c)
              .Append(m_health_area)
              .Append(c)
              .Append(m_police_boro_com)
              .Append(c)
              .Append(m_police_pct)
              .Append(c)
              .Append(m_fire_div)
              .Append(c)
              .Append(m_fire_bat)
              .Append(c)
              .Append(m_fire_co_type)
              .Append(c)
              .Append(m_fire_co_num)
              .Append(c)
              .Append(m_school_dist)
              .Append(c)
              .Append(m_census_tract_2000)
              .Append(c)
              .Append(m_census_tract_1990)
              .Append(c)
              .Append(m_filler_level_codes)
              .Append(c)
              .Append(m_police_patrol_boro)
              .Append(c)
              .Append(m_ad)
              .Append(c)
              .Append(m_cd)
              .Append(c)
              .Append(m_sd)
              .Append(c)
              .Append(m_mc)
              .Append(c)
              .Append(m_co)
              .Append(c)
              .Append(m_cd_eligible)
              .Append(c)
              .Append(m_duplicate_intersection_distance)
              .Append(c)
              .Append(m_census_tract_2000)
              .Append(c)
              .Append(m_health_center_dist)
              .Append(c)
              .Append(m_san_dist)
              .Append(c)
              .Append(m_san_sub_section)
              .Append(c)
              .Append(m_police_sector)
              .Append(c)
              .Append(m_census_tract_2020)
              .Append(c)
              .Append(m_filler02);

            return sb.ToString();
        }

        public override string Display() =>  Display('-');

        public override string Print()
        {
            var sb = new StringBuilder();

            sb.AppendFormat("gridkey2 = {0}{1}", m_gridkey2, Environment.NewLine)
              .AppendFormat("dup_intersect_cnt = {0}{1}", m_dup_intersect_cnt, Environment.NewLine)
              .AppendFormat("dcp_pref_lgc1 = {0}{1}", m_dcp_pref_lgc1, Environment.NewLine)
              .AppendFormat("dcp_pref_lgc2 = {0}{1}", m_dcp_pref_lgc2, Environment.NewLine)
              .AppendFormat("x_sts_cnt = {0}{1}", m_x_sts_cnt, Environment.NewLine);

            for (int i = 0; i <= 4; i++)
                sb.AppendFormat("x_sts({0}) = {1}{2}", i, m_x_sts[i].Display(), Environment.NewLine);

            sb.AppendFormat("compass = {0}{1}", m_compass, Environment.NewLine)
              .AppendFormat("atomic_polygon = {0}{1}", m_atomic_polygon, Environment.NewLine)
              .AppendFormat("filler01 = {0}{1}", m_filler01, Environment.NewLine)
              .AppendFormat("lion_node_num = {0}{1}", m_lion_node_num, Environment.NewLine)
              .AppendFormat("x_coord = {0}{1}", m_x_coord, Environment.NewLine)
              .AppendFormat("y_coord = {0}{1}", m_y_coord, Environment.NewLine)
              .AppendFormat("z_coord = {0}{1}", m_z_coord, Environment.NewLine)
              .AppendFormat("sanborn1 = {0}{1}", m_sanborn1.Display(), Environment.NewLine)
              .AppendFormat("sanborn2 = {0}{1}", m_sanborn2.Display(), Environment.NewLine)
              .AppendFormat("mh_ri_flag = {0}{1}", m_mh_ri_flag, Environment.NewLine)
              .AppendFormat("dot_st_light_contract_area = {0}{1}", m_dot_st_light_contract_area, Environment.NewLine)
              .AppendFormat("com_dist = {0}{1}", m_com_dist.Display(), Environment.NewLine)
              .AppendFormat("zip_code = {0}{1}", m_zip_code, Environment.NewLine)
              .AppendFormat("health_area = {0}{1}", m_health_area, Environment.NewLine)
              .AppendFormat("police_boro_com = {0}{1}", m_police_boro_com, Environment.NewLine)
              .AppendFormat("police_pct = {0}{1}", m_police_pct, Environment.NewLine)
              .AppendFormat("fire_div = {0}{1}", m_fire_div, Environment.NewLine)
              .AppendFormat("fire_bat = {0}{1}", m_fire_bat, Environment.NewLine)
              .AppendFormat("fire_co_type = {0}{1}", m_fire_co_type, Environment.NewLine)
              .AppendFormat("fire_co_num = {0}{1}", m_fire_co_num, Environment.NewLine)
              .AppendFormat("school_dist = {0}{1}", m_school_dist, Environment.NewLine)
              .AppendFormat("census_tract_2010 = {0}{1}", m_census_tract_2010, Environment.NewLine)
              .AppendFormat("census_tract_1990 = {0}{1}", m_census_tract_1990, Environment.NewLine)
              .AppendFormat("filler_level_codes = {0}{1}", m_filler_level_codes, Environment.NewLine)
              .AppendFormat("police_patrol_boro = {0}{1}", m_police_patrol_boro, Environment.NewLine)
              .AppendFormat("ad = {0}{1}", m_ad, Environment.NewLine)
              .AppendFormat("cd = {0}{1}", m_cd, Environment.NewLine)
              .AppendFormat("sd = {0}{1}", m_sd, Environment.NewLine)
              .AppendFormat("mc = {0}{1}", m_mc, Environment.NewLine)
              .AppendFormat("co = {0}{1}", m_co, Environment.NewLine)
              .AppendFormat("cd_eligible = {0}{1}", m_cd_eligible, Environment.NewLine)
              .AppendFormat("duplicate_intersection_distance = {0}{1}", m_duplicate_intersection_distance, Environment.NewLine)
              .AppendFormat("census_tract_2000 = {0}{1}", m_census_tract_2000, Environment.NewLine)
              .AppendFormat("health_center_dist = {0}{1}", m_health_center_dist, Environment.NewLine)
              .AppendFormat("san_dist = {0}{1}", m_san_dist, Environment.NewLine)
              .AppendFormat("san_sub_section = {0}{1}", m_san_sub_section, Environment.NewLine)
              .AppendFormat("police_sector = {0}{1}", m_police_sector, Environment.NewLine)
              .AppendFormat("census_tract_2020 = {0}{1}", m_census_tract_2020, Environment.NewLine)
              .AppendFormat("filler02 = {0}{1}", m_filler02, Environment.NewLine);

            return sb.ToString();
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            int i;

            sb.AppendLine();
            sb.AppendLine("****************************************************************************");
            sb.AppendLine("******************************  Wa2F2  ***********************************");
            sb.AppendLine("****************************************************************************");

            sb.AppendLine();
            sb.AppendLine("**********  Key Information  **********");
            sb.AppendLine();

            sb.AppendFormat("gridkey2 = {0}{1}", m_gridkey2, Environment.NewLine);
            sb.AppendFormat("dup_intersect_cnt = {0}{1}", m_dup_intersect_cnt, Environment.NewLine);

            sb.AppendLine();

            sb.AppendFormat("dcp_pref_lgc1 = {0}{1}", m_dcp_pref_lgc1, Environment.NewLine);
            sb.AppendFormat("dcp_pref_lgc2 = {0}{1}", m_dcp_pref_lgc2, Environment.NewLine);

            sb.AppendLine();
            sb.AppendLine("**********  Geographic Information  **********");
            sb.AppendLine();

            sb.AppendFormat("compass = {0}{1}", m_compass, Environment.NewLine);
            sb.AppendFormat("atomic_polygon = {0}{1}", m_atomic_polygon, Environment.NewLine);
            sb.AppendFormat("lion_node_num = {0}{1}", m_lion_node_num, Environment.NewLine);

            sb.AppendLine();

            sb.AppendFormat("x_coord = {0}{1}", m_x_coord, Environment.NewLine);
            sb.AppendFormat("y_coord = {0}{1}", m_y_coord, Environment.NewLine);
            sb.AppendFormat("z_coord = {0}{1}", m_z_coord, Environment.NewLine);

            sb.AppendLine();

            sb.AppendFormat("sanborn1 = {0}{1}", m_sanborn1.Display(), Environment.NewLine);
            sb.AppendFormat("sanborn2 = {0}{1}", m_sanborn2.Display(), Environment.NewLine);
            sb.AppendFormat("mh_ri_flag = {0}{1}", m_mh_ri_flag, Environment.NewLine);

            sb.AppendLine();

            sb.AppendFormat("zip_code = {0}{1}", m_zip_code, Environment.NewLine);

            sb.AppendLine();
            sb.AppendLine("**********  Police and Fire Information  **********");
            sb.AppendLine();

            sb.AppendFormat("police_boro_com = {0}{1}", m_police_boro_com, Environment.NewLine);
            sb.AppendFormat("police_patrol_boro = {0}{1}", m_police_patrol_boro, Environment.NewLine);
            sb.AppendFormat("police_pct = {0}{1}", m_police_pct, Environment.NewLine);
            sb.AppendFormat("police_sector = {0}{1}", m_police_sector, Environment.NewLine);

            sb.AppendLine();

            sb.AppendFormat("fire_div = {0}{1}", m_fire_div, Environment.NewLine);
            sb.AppendFormat("fire_bat = {0}{1}", m_fire_bat, Environment.NewLine);
            sb.AppendFormat("fire_co_type = {0}{1}", m_fire_co_type, Environment.NewLine);
            sb.AppendFormat("fire_co_num = {0}{1}", m_fire_co_num, Environment.NewLine);

            sb.AppendLine();
            sb.AppendLine("**********  Census Information  **********");
            sb.AppendLine();

            sb.AppendFormat("census_tract_1990 = {0}{1}", m_census_tract_1990, Environment.NewLine);
            sb.AppendFormat("census_tract_2000 = {0}{1}", m_census_tract_2000, Environment.NewLine);
            sb.AppendFormat("census_tract_2010 = {0}{1}", m_census_tract_2010, Environment.NewLine);

            // Moved Census Tract 2020 to regular WA2F2 from WA2F2W
            sb.AppendFormat("census_tract_2020 = {0}{1}", m_census_tract_2020, Environment.NewLine);

            sb.AppendLine();
            sb.AppendLine("**********  Election District Information  **********");
            sb.AppendLine();

            sb.AppendFormat("ad = {0}{1}", m_ad, Environment.NewLine);
            sb.AppendFormat("cd = {0}{1}", m_cd, Environment.NewLine);
            sb.AppendFormat("sd = {0}{1}", m_sd, Environment.NewLine);
            sb.AppendFormat("mc = {0}{1}", m_mc, Environment.NewLine);
            sb.AppendFormat("co = {0}{1}", m_co, Environment.NewLine);

            sb.AppendLine();
            sb.AppendLine("**********  Other District Information  **********");
            sb.AppendLine();

            sb.AppendFormat("school_dist = {0}{1}", m_school_dist, Environment.NewLine);
            sb.AppendFormat("cd_eligible = {0}{1}", m_cd_eligible, Environment.NewLine);
            sb.AppendFormat("duplicate_intersection_distance = {0}{1}", m_duplicate_intersection_distance, Environment.NewLine);
            sb.AppendFormat("health_center_dist = {0}{1}", m_health_center_dist, Environment.NewLine);
            sb.AppendFormat("health_area = {0}{1}", m_health_area, Environment.NewLine);
            sb.AppendFormat("dot_st_light_contract_area = {0}{1}", m_dot_st_light_contract_area, Environment.NewLine);
            sb.AppendFormat("com_dist = {0}{1}", m_com_dist.Display(), Environment.NewLine);

            sb.AppendLine();
            sb.AppendLine("**********  Sanitation Information  **********");
            sb.AppendLine();

            sb.AppendFormat("san_dist = {0}{1}", m_san_dist, Environment.NewLine);
            sb.AppendFormat("san_sub_section = {0}{1}", m_san_sub_section, Environment.NewLine);

            sb.AppendLine();
            sb.AppendLine("**********  Intersecting Streets  **********");
            sb.AppendLine();

            sb.AppendFormat("x_sts_cnt = {0}{1}", m_x_sts_cnt, Environment.NewLine);
            for (i = 0; i <= 4; i++)
            {
                sb.AppendFormat("x_sts({0}) = {1}{2}", i, m_x_sts[i].Display(), Environment.NewLine);
            }

            sb.AppendLine();
            sb.AppendLine("**********  Miscellaneous Filler Information  **********");
            sb.AppendLine();

            sb.AppendFormat("filler01 = {0}{1}", m_filler01, Environment.NewLine);
            sb.AppendFormat("filler_level_codes = {0}{1}", m_filler_level_codes, Environment.NewLine);
            sb.AppendFormat("filler02 = {0}{1}", m_filler02, Environment.NewLine);

            return sb.ToString();
        }

        public string gridkey2
        {
            get => m_gridkey2;
            set => m_gridkey2 = value.Length > 21 ? value.Substring(0, 21) : value;
        }

        public string dup_intersect_cnt
        {
            get => m_dup_intersect_cnt;
            set => m_dup_intersect_cnt = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string dcp_pref_lgc1
        {
            get => m_dcp_pref_lgc1;
            set => m_dcp_pref_lgc1 = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        public string dcp_pref_lgc2
        {
            get => m_dcp_pref_lgc2;
            set => m_dcp_pref_lgc2 = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        public string x_sts_cnt
        {
            get => m_x_sts_cnt;
            set => m_x_sts_cnt = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public B5sc[] x_sts
        {
            get => m_x_sts;
            set => m_x_sts = value;
        }

        public B5sc x_sts_item(int index) => m_x_sts[index];
        public void x_sts_item(int index, B5sc value) => m_x_sts[index] = value;
        
        public string compass
        {
            get => m_compass;
            set => m_compass = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string atomic_polygon
        {
            get => m_atomic_polygon;
            set => m_atomic_polygon = value.Length > 3 ? value.Substring(0, 3) : value;
        }

        public string filler01
        {
            get => m_filler01;
            set => m_filler01 = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        public string lion_node_num
        {
            get => m_lion_node_num;
            set => m_lion_node_num = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        public string x_coord
        {
            get => m_x_coord;
            set => m_x_coord = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        public string y_coord
        {
            get => m_y_coord;
            set => m_y_coord = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        public string z_coord
        {
            get => m_z_coord;
            set => m_z_coord = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        public Sanborn sanborn1
        {
            get => m_sanborn1;
            set => m_sanborn1 = value;
        }

        public Sanborn sanborn2
        {
            get => m_sanborn2;
            set => m_sanborn2 = value;
        }

        public string mh_ri_flag
        {
            get => m_mh_ri_flag;
            set => m_mh_ri_flag = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string dot_st_light_contract_area
        {
            get => m_dot_st_light_contract_area;
            set => m_dot_st_light_contract_area = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public ComDist com_dist
        {
            get => m_com_dist;
            set => m_com_dist = value;
        }

        public string zip_code
        {
            get => m_zip_code;
            set => m_zip_code = value.Length > 5 ? value.Substring(0, 5) : value;
        }

        public string health_area
        {
            get => m_health_area;
            set => m_health_area = value.Length > 4 ? value.Substring(0, 4) : value;
        }

        public string police_boro_com
        {
            get => m_police_boro_com;
            set => m_police_boro_com = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string police_pct
        {
            get => m_police_pct;
            set => m_police_pct = value.Length > 3 ? value.Substring(0, 3) : value;
        }

        public string fire_div
        {
            get => m_fire_div;
            set => m_fire_div = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        public string fire_bat
        {
            get => m_fire_bat;
            set => m_fire_bat = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        public string fire_co_type
        {
            get => m_fire_co_type;
            set => m_fire_co_type = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string fire_co_num
        {
            get => m_fire_co_num;
            set => m_fire_co_num = value.Length > 3 ? value.Substring(0, 3) : value;
        }

        public string school_dist
        {
            get => m_school_dist;
            set => m_school_dist = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        public string census_tract_2010
        {
            get => m_census_tract_2010;
            set => m_census_tract_2010 = value.Length > 6 ? value.Substring(0, 6) : value;
        }

        public string census_tract_1990
        {
            get => m_census_tract_1990;
            set => m_census_tract_1990 = value.Length > 6 ? value.Substring(0, 6) : value;
        }

        public string filler_level_codes
        {
            get => m_filler_level_codes;
            set => m_filler_level_codes = value.Length > 10 ? value.Substring(0, 10) : value;
        }

        public string police_patrol_boro
        {
            get => m_police_patrol_boro;
            set => m_police_patrol_boro = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        public string ad
        {
            get => m_ad;
            set => m_ad = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        public string cd
        {
            get => m_cd;
            set => m_cd = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        public string sd
        {
            get => m_sd;
            set => m_sd = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        public string mc
        {
            get => m_mc;
            set => m_mc = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        public string co
        {
            get => m_co;
            set => m_co = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        public string cd_eligible
        {
            get => m_cd_eligible;
            set => m_cd_eligible = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string duplicate_intersection_distance
        {
            get => m_duplicate_intersection_distance;
            set => m_duplicate_intersection_distance = value.Length > 5 ? value.Substring(0, 5) : value;
        }

        public string census_tract_2000
        {
            get => m_census_tract_2000;
            set => m_census_tract_2000 = value.Length > 6 ? value.Substring(0, 6) : value;
        }

        public string health_center_dist
        {
            get => m_health_center_dist;
            set => m_health_center_dist = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        public string san_dist
        {
            get => m_san_dist;
            set => m_san_dist = value.Length > 3 ? value.Substring(0, 3) : value;
        }

        public string san_sub_section
        {
            get => m_san_sub_section;
            set => m_san_sub_section = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        public string police_sector
        {
            get => m_police_sector;
            set => m_police_sector = value.Length > 4 ? value.Substring(0, 4) : value;
        }

        public string census_tract_2020
        {
            get => m_census_tract_2020;
            set => m_census_tract_2020 = value.Length > 6 ? value.Substring(0, 6) : value;
        }

        public string filler02
        {
            get => m_filler02;
            set => m_filler02 = value.Length > 2 ? value.Substring(0, 2) : value;
        }

    }
}
