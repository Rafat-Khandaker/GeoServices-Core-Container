
using System.Text;

namespace GeoXWrapperLib.Model
{
    public class Wa2F1e : WA
    {
        private VsamKey1 m_gridkey1;
        private string m_cont_parity_ind;
        private string m_lo_hns;
        private string m_hi_hns;
        private string m_dcp_pref_lgc;
        private string m_lo_x_sts_cnt;
        private B5sc[] m_lo_x_sts = new B5sc[5];
        private string m_hi_x_sts_cnt;
        private B5sc[] m_hi_x_sts = new B5sc[5];
        private LionKey m_lion_key;
        private string m_spec_addr_flag;
        private string m_sos_ind;
        private string m_segment_len;
        private string m_x_coord;
        private string m_y_coord;
        private string m_z_coord;
        private string m_res_gss;
        private string m_mh_ri_flag;
        private string m_dot_st_light_contract_area;
        private ComDist m_com_dist;
        private string m_zip_code;
        private string m_ed;
        private string m_ad;
        private string m_split_ed;
        private string m_cd;
        private string m_sd;
        private string m_mc;
        private string m_co;
        private string m_health_center_dist;
        private string m_health_area;
        private string m_san_dist;
        private string m_san_sched;
        private string m_san_reg;
        private string m_san_recycle;
        private string m_police_boro_com;
        private string m_police_pct;
        private string m_fire_div;
        private string m_fire_bat;
        private string m_fire_co_type;
        private string m_fire_co_num;
        private string m_split_school_dist_flag;
        private string m_school_dist;
        private string m_dynamic_block;
        private string m_police_patrol_boro;
        private string m_feature_type;
        private string m_segment_type;
        private string m_alx;
        private string m_coincident_seg_cnt;
        private string m_filler_80ct;
        private string m_census_tract_1990;
        private string m_census_tract_2010;
        private string m_census_block_2010;
        private string m_census_block_suffix_2010;
        private string m_census_tract_2000;
        private string m_census_block_2000;
        private string m_census_block_suffix_2000;
        private string m_nta;
        private string m_dsny_snow_priority;
        private string m_san_org_pick_up;
        private string m_san_bulk;
        private string m_hurricane_zone;
        private string m_san_commercial_waste_zone;
        private string m_filler3;
        private string m_true_hns;
        private B7sc m_real_b7sc;
        private string m_segment_id;
        private string m_curve_flag;

        public Wa2F1e()
        {
            m_gridkey1 = new VsamKey1();
            m_cont_parity_ind = new string(' ', 1);
            m_lo_hns = new string(' ', 11);
            m_hi_hns = new string(' ', 11);
            m_dcp_pref_lgc = new string(' ', 2);
            m_lo_x_sts_cnt = new string(' ', 1);
            for (int i = 0; i <= 4; i++)
            {
                m_lo_x_sts[i] = new B5sc();
            }
            m_hi_x_sts_cnt = new string(' ', 1);
            for (int i = 0; i <= 4; i++)
            {
                m_hi_x_sts[i] = new B5sc();
            }
            m_lion_key = new LionKey();
            m_spec_addr_flag = new string(' ', 1);
            m_sos_ind = new string(' ', 1);
            m_segment_len = new string(' ', 5);
            m_x_coord = new string(' ', 7);
            m_y_coord = new string(' ', 7);
            m_z_coord = new string(' ', 7);
            m_res_gss = new string(' ', 1);
            m_mh_ri_flag = new string(' ', 1);
            m_dot_st_light_contract_area = new string(' ', 1);
            m_com_dist = new ComDist();
            m_zip_code = new string(' ', 5);
            m_ed = new string(' ', 3);
            m_ad = new string(' ', 2);
            m_split_ed = new string(' ', 1);
            m_cd = new string(' ', 2);
            m_sd = new string(' ', 2);
            m_mc = new string(' ', 2);
            m_co = new string(' ', 2);
            m_health_center_dist = new string(' ', 2);
            m_health_area = new string(' ', 4);
            m_san_dist = new string(' ', 3);
            m_san_sched = new string(' ', 2);
            m_san_reg = new string(' ', 5);
            m_san_recycle = new string(' ', 3);
            m_police_boro_com = new string(' ', 1);
            m_police_pct = new string(' ', 3);
            m_fire_div = new string(' ', 2);
            m_fire_bat = new string(' ', 2);
            m_fire_co_type = new string(' ', 1);
            m_fire_co_num = new string(' ', 3);
            m_split_school_dist_flag = new string(' ', 1);
            m_school_dist = new string(' ', 2);
            m_dynamic_block = new string(' ', 3);
            m_police_patrol_boro = new string(' ', 2);
            m_feature_type = new string(' ', 1);
            m_segment_type = new string(' ', 1);
            m_alx = new string(' ', 1);
            m_coincident_seg_cnt = new string(' ', 1);
            m_filler_80ct = new string(' ', 3);
            m_census_tract_1990 = new string(' ', 6);
            m_census_tract_2010 = new string(' ', 6);
            m_census_block_2010 = new string(' ', 4);
            m_census_block_suffix_2010 = new string(' ', 1);
            m_census_tract_2000 = new string(' ', 6);
            m_census_block_2000 = new string(' ', 4);
            m_census_block_suffix_2000 = new string(' ', 1);
            m_nta = new string(' ', 4);
            m_dsny_snow_priority = new string(' ', 1);
            m_san_org_pick_up = new string(' ', 5);
            m_san_bulk = new string(' ', 5);
            m_hurricane_zone = new string(' ', 2);
            m_san_commercial_waste_zone = new string(' ', 4);
            m_filler3 = new string(' ', 7);
            m_true_hns = new string(' ', 11);
            m_real_b7sc = new B7sc();
            m_segment_id = new string(' ', 7);
            m_curve_flag = new string(' ', 1);
        }

        // Constructor for the class that initializes from a string
        public Wa2F1e(string inString)
        {
            this.Wa2F1eFromString(inString);
        }

        // Clear method reinitializing the object to spaces
        public override void Clear()
        {
            this.Wa2F1eFromString(new string(' ', 300));
        }

        // ToString method
        public override string ToString()
        {
            return this.Wa2F1eToString();
        }

        // FromString method
        public override void FromString(string inString)
        {
            this.Wa2F1eFromString(inString);
        }

        // Method for converting Wa2F1e object to string
        public string Wa2F1eToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(m_gridkey1.VsamKey1ToString());
            sb.Append(m_cont_parity_ind);
            sb.Append(m_lo_hns);
            sb.Append(m_hi_hns);
            sb.Append(m_dcp_pref_lgc);
            sb.Append(m_lo_x_sts_cnt);

            for (int i = 0; i <= 4; i++)
            {
                sb.Append(m_lo_x_sts[i].B5scToString());
            }

            sb.Append(m_hi_x_sts_cnt);

            for (int i = 0; i <= 4; i++)
            {
                sb.Append(m_hi_x_sts[i].B5scToString());
            }

            sb.Append(m_lion_key.LionKeyToString());
            sb.Append(m_spec_addr_flag);
            sb.Append(m_sos_ind);
            sb.Append(m_segment_len);
            sb.Append(m_x_coord);
            sb.Append(m_y_coord);
            sb.Append(m_z_coord);
            sb.Append(m_res_gss);
            sb.Append(m_mh_ri_flag);
            sb.Append(m_dot_st_light_contract_area);
            sb.Append(m_com_dist.ComDistToString());
            sb.Append(m_zip_code);
            sb.Append(m_ed);
            sb.Append(m_ad);
            sb.Append(m_split_ed);
            sb.Append(m_cd);
            sb.Append(m_sd);
            sb.Append(m_mc);
            sb.Append(m_co);
            sb.Append(m_health_center_dist);
            sb.Append(m_health_area);
            sb.Append(m_san_dist);
            sb.Append(m_san_sched);
            sb.Append(m_san_reg);
            sb.Append(m_san_recycle);
            sb.Append(m_police_boro_com);
            sb.Append(m_police_pct);
            sb.Append(m_fire_div);
            sb.Append(m_fire_bat);
            sb.Append(m_fire_co_type);
            sb.Append(m_fire_co_num);
            sb.Append(m_split_school_dist_flag);
            sb.Append(m_school_dist);
            sb.Append(m_dynamic_block);
            //spo(2014-11-10): added police patrol borough 
            //                 replaces instruct_div location 
            //sb.Append(m_instruc_div);
            sb.Append(m_police_patrol_boro);
            sb.Append(m_feature_type);
            sb.Append(m_segment_type);
            sb.Append(m_alx);
            //spo (2007-07-17) added m_coincident_seg_cnt 
            sb.Append(m_coincident_seg_cnt);
            sb.Append(m_filler_80ct);
            sb.Append(m_census_tract_1990);
            //spo(2011-09-24):  Geosupport 11.0 added 2010 census and moved 2000 census fields
            sb.Append(m_census_tract_2010);
            sb.Append(m_census_block_2010);
            sb.Append(m_census_block_suffix_2010);
            sb.Append(m_census_tract_2000);
            sb.Append(m_census_block_2000);
            //spo(2008-06-04):  added new field, census_block_suffix_2000
            sb.Append(m_census_block_suffix_2000);
            //spo(2012-04-06):  added for Geosupport Version 11.3 / Release 12A 
            sb.Append(m_nta);
            //spo(2012-04-06):  added for Geosupport Version 11.3 / Release 12A 
            sb.Append(m_dsny_snow_priority);
            //spo(2014-02-28):  added for Geosupport Version 14.1 / Release 14A 
            sb.Append(m_san_org_pick_up);
            //njp(2014-09-29) renaming filler to Sanitation Bulk for version 16.4
            sb.Append(m_san_bulk);
            //spo(2014-02-28):  added for Geosupport Version 14.1 / Release 14A 
            sb.Append(m_hurricane_zone);
            //SPO(2022-08-31): Add new 4 byte DSNY Commercial Waste Zone for 22C
            sb.Append(m_san_commercial_waste_zone);
            sb.Append(m_filler3);
            sb.Append(m_true_hns);
            sb.Append(m_real_b7sc.B7scToString());
            sb.Append(m_segment_id);
            sb.Append(m_curve_flag);

            return sb.ToString();
        }

        // Method for setting object properties from a string
        private void Wa2F1eFromString(string inString) => Wa2F1eFromString(inString);
        

        public override string Display(char c)
        {
            StringBuilder sb = new StringBuilder();
            int i;

            sb.Append(m_gridkey1.Display());
            sb.Append(c);
            sb.Append(m_cont_parity_ind);
            sb.Append(c);
            sb.Append(m_lo_hns);
            sb.Append(c);
            sb.Append(m_hi_hns);
            sb.Append(c);
            sb.Append(m_dcp_pref_lgc);
            sb.Append(c);
            sb.Append(m_lo_x_sts_cnt);
            sb.Append(c);

            for (i = 0; i <= 4; i++)
            {
                sb.Append(m_lo_x_sts[i].Display());
                sb.Append(c);
            }

            sb.Append(m_hi_x_sts_cnt);
            sb.Append(c);

            for (i = 0; i <= 4; i++)
            {
                sb.Append(m_hi_x_sts[i].Display());
                sb.Append(c);
            }

            sb.Append(m_lion_key.Display());
            sb.Append(c);
            sb.Append(m_spec_addr_flag);
            sb.Append(c);
            sb.Append(m_sos_ind);
            sb.Append(c);
            sb.Append(m_segment_len);
            sb.Append(c);
            sb.Append(m_x_coord);
            sb.Append(c);
            sb.Append(m_y_coord);
            sb.Append(c);
            sb.Append(m_z_coord);
            sb.Append(c);
            sb.Append(m_res_gss);
            sb.Append(c);
            sb.Append(m_mh_ri_flag);
            sb.Append(c);
            sb.Append(m_dot_st_light_contract_area);
            sb.Append(c);
            sb.Append(m_com_dist.Display());
            sb.Append(c);
            sb.Append(m_zip_code);
            sb.Append(c);
            sb.Append(m_ed);
            sb.Append(c);
            sb.Append(m_ad);
            sb.Append(c);
            sb.Append(m_split_ed);
            sb.Append(c);
            sb.Append(m_cd);
            sb.Append(c);
            sb.Append(m_sd);
            sb.Append(c);
            sb.Append(m_mc);
            sb.Append(c);
            sb.Append(m_co);
            sb.Append(c);
            sb.Append(m_health_center_dist);
            sb.Append(c);
            sb.Append(m_health_area);
            sb.Append(c);
            sb.Append(m_san_dist);
            sb.Append(c);
            sb.Append(m_san_sched);
            sb.Append(c);
            sb.Append(m_san_reg);
            sb.Append(c);
            sb.Append(m_san_recycle);
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
            sb.Append(m_split_school_dist_flag);
            sb.Append(c);
            sb.Append(m_school_dist);
            sb.Append(c);
            sb.Append(m_dynamic_block);
            sb.Append(c);

            //spo(2014-11-10): added police patrol borough 
            //                 replaces instruct_div location 
            //sb.Append(m_instruc_div);
            sb.Append(m_police_patrol_boro);
            sb.Append(c);
            sb.Append(m_feature_type);
            sb.Append(c);
            sb.Append(m_segment_type);
            sb.Append(c);
            sb.Append(m_alx);
            sb.Append(c);

            //spo (2007-07-17) added m_coincident_seg_cnt 
            sb.Append(m_coincident_seg_cnt);
            sb.Append(c);
            sb.Append(m_filler_80ct);
            sb.Append(c);
            sb.Append(m_census_tract_1990);
            sb.Append(c);

            //spo(2011-09-24):  Geosupport 11.0 added 2010 census and moved 2000 census fields
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

            //spo(2008-06-04):  added new field, census_block_suffix_2000
            sb.Append(m_census_block_suffix_2000);
            sb.Append(c);

            //spo(2012-04-06):  added for Geosupport Version 11.3 / Release 12A 
            sb.Append(m_nta);
            sb.Append(c);

            //spo(2012-04-06):  added for Geosupport Version 11.3 / Release 12A 
            sb.Append(m_dsny_snow_priority);
            sb.Append(c);

            //spo(2014-02-28):  added for Geosupport Version 14.1 / Release 14A 
            sb.Append(m_san_org_pick_up);
            sb.Append(c);

            //njp(2014-09-29) renaming filler to Sanitation Bulk for version 16.4
            sb.Append(m_san_bulk);
            sb.Append(c);

            //spo(2014-02-28):  added for Geosupport Version 14.1 / Release 14A 
            sb.Append(m_hurricane_zone);
            sb.Append(c);

            //SPO(2022-08-31): Add new 4 byte DSNY Commercial Waste Zone for 22C
            sb.Append(m_san_commercial_waste_zone);
            sb.Append(c);
            sb.Append(m_filler3);
            sb.Append(c);
            sb.Append(m_true_hns);
            sb.Append(c);
            sb.Append(m_real_b7sc.Display());
            sb.Append(c);
            sb.Append(m_segment_id);
            sb.Append(c);
            sb.Append(m_curve_flag);
            sb.Append(c);

            return sb.ToString();
        }


        public override string Display() => this.Display('-');

        public override string Print()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("gridkey1 = {0}\r\n", m_gridkey1.Display());
            sb.AppendFormat("cont_parity_ind = {0}\r\n", m_cont_parity_ind);
            sb.AppendFormat("lo_hns = {0}\r\n", m_lo_hns);
            sb.AppendFormat("hi_hns = {0}\r\n", m_hi_hns);
            sb.AppendFormat("dcp_pref_lgc = {0}\r\n", m_dcp_pref_lgc);
            sb.AppendFormat("lo_x_sts_cnt = {0}\r\n", m_lo_x_sts_cnt);

            for (int i = 0; i <= 4; i++)
            {
                sb.AppendFormat("lo_x_sts({0}) = {1}\r\n", i, m_lo_x_sts[i].Display());
            }

            sb.AppendFormat("hi_x_sts_cnt = {0}\r\n", m_hi_x_sts_cnt);

            for (int i = 0; i <= 4; i++)
            {
                sb.AppendFormat("hi_x_sts({0}) = {1}\r\n", i, m_hi_x_sts[i].Display());
            }

            sb.AppendFormat("lion_key = {0}\r\n", m_lion_key.Display());
            sb.AppendFormat("spec_addr_flag = {0}\r\n", m_spec_addr_flag);
            sb.AppendFormat("sos_ind = {0}\r\n", m_sos_ind);
            sb.AppendFormat("segment_len = {0}\r\n", m_segment_len);
            sb.AppendFormat("x_coord = {0}\r\n", m_x_coord);
            sb.AppendFormat("y_coord = {0}\r\n", m_y_coord);
            sb.AppendFormat("z_coord = {0}\r\n", m_z_coord);
            sb.AppendFormat("res_gss = {0}\r\n", m_res_gss);
            sb.AppendFormat("mh_ri_flag = {0}\r\n", m_mh_ri_flag);
            sb.AppendFormat("dot_st_light_contract_area = {0}\r\n", m_dot_st_light_contract_area);
            sb.AppendFormat("com_dist = {0}\r\n", m_com_dist.Display());
            sb.AppendFormat("zip_code = {0}\r\n", m_zip_code);
            sb.AppendFormat("ed = {0}\r\n", m_ed);
            sb.AppendFormat("ad = {0}\r\n", m_ad);
            sb.AppendFormat("split_ed = {0}\r\n", m_split_ed);
            sb.AppendFormat("cd = {0}\r\n", m_cd);
            sb.AppendFormat("sd = {0}\r\n", m_sd);
            sb.AppendFormat("mc = {0}\r\n", m_mc);
            sb.AppendFormat("co = {0}\r\n", m_co);
            sb.AppendFormat("health_center_dist = {0}\r\n", m_health_center_dist);
            sb.AppendFormat("health_area = {0}\r\n", m_health_area);
            sb.AppendFormat("san_dist = {0}\r\n", m_san_dist);
            sb.AppendFormat("san_sched = {0}\r\n", m_san_sched);
            sb.AppendFormat("san_reg = {0}\r\n", m_san_reg);
            sb.AppendFormat("san_recycle = {0}\r\n", m_san_recycle);
            sb.AppendFormat("police_boro_com = {0}\r\n", m_police_boro_com);
            sb.AppendFormat("police_pct = {0}\r\n", m_police_pct);
            sb.AppendFormat("fire_div = {0}\r\n", m_fire_div);
            sb.AppendFormat("fire_bat = {0}\r\n", m_fire_bat);
            sb.AppendFormat("fire_co_type = {0}\r\n", m_fire_co_type);
            sb.AppendFormat("fire_co_num = {0}\r\n", m_fire_co_num);
            sb.AppendFormat("split_school_dist_flag = {0}\r\n", m_split_school_dist_flag);
            sb.AppendFormat("school_dist = {0}\r\n", m_school_dist);
            sb.AppendFormat("dynamic_block = {0}\r\n", m_dynamic_block);

            // Replaces instruct_div location
            sb.AppendFormat("instruc_div = {0}\r\n", m_police_patrol_boro);
            sb.AppendFormat("feature_type = {0}\r\n", m_feature_type);
            sb.AppendFormat("segment_type = {0}\r\n", m_segment_type);
            sb.AppendFormat("alx = {0}\r\n", m_alx);

            // Added m_coincident_seg_cnt
            sb.AppendFormat("coincident_seg_cnt = {0}\r\n", m_coincident_seg_cnt);
            sb.AppendFormat("filler_80ct = {0}\r\n", m_filler_80ct);
            sb.AppendFormat("census_tract_1990 = {0}\r\n", m_census_tract_1990);

            // Geosupport 11.0 added 2010 census and moved 2000 census fields
            sb.AppendFormat("census_tract_2010 = {0}\r\n", m_census_tract_2010);
            sb.AppendFormat("census_block_2010 = {0}\r\n", m_census_block_2010);
            sb.AppendFormat("census_block_suffix_2010 = {0}\r\n", m_census_block_suffix_2010);
            sb.AppendFormat("census_tract_2000 = {0}\r\n", m_census_tract_2000);
            sb.AppendFormat("census_block_2000 = {0}\r\n", m_census_block_2000);

            // Added new field, census_block_suffix_2000
            sb.AppendFormat("census_block_suffix_2000 = {0}\r\n", m_census_block_suffix_2000);

            // Added for Geosupport Version 11.3 / Release 12A
            sb.AppendFormat("nta = {0}\r\n", m_nta);
            sb.AppendFormat("dsny_snow_priority = {0}\r\n", m_dsny_snow_priority);

            // Added for Geosupport Version 14.1 / Release 14A
            sb.AppendFormat("san_org_pick_up = {0}\r\n", m_san_org_pick_up);

            // Renaming filler to Sanitation Bulk for version 16.4
            sb.AppendFormat("san_bulk = {0}\r\n", m_san_bulk);

            // Added for Geosupport Version 14.1 / Release 14A
            sb.AppendFormat("hurricane_zone = {0}\r\n", m_hurricane_zone);

            // Add new 4 byte DSNY Commercial Waste Zone for 22C
            sb.AppendFormat("san_commercial_waste_zone = {0}\r\n", m_san_commercial_waste_zone);
            sb.AppendFormat("filler3 = {0}\r\n", m_filler3);
            sb.AppendFormat("true_hns = {0}\r\n", m_true_hns);
            sb.AppendFormat("real_b7sc = {0}\r\n", m_real_b7sc.Display());
            sb.AppendFormat("segment_id = {0}\r\n", m_segment_id);
            sb.AppendFormat("curve_flag = {0}\r\n", m_curve_flag);

            return sb.ToString();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            int i;

            sb.AppendLine();
            sb.AppendLine("****************************************************************************");
            sb.AppendLine("*****************************  Wa2F1e  **********************************");
            sb.AppendLine("****************************************************************************");

            sb.AppendLine();
            sb.AppendLine("**********  Key Information  **********");

            sb.AppendLine($"gridkey1 = {m_gridkey1.Display()}");
            sb.AppendLine($"cont_parity_ind = {m_cont_parity_ind}");
            sb.AppendLine($"lo_hns = {m_lo_hns}");
            sb.AppendLine($"hi_hns = {m_hi_hns}");

            sb.AppendLine();
            sb.AppendLine("**********  Geographic Information  **********");
            sb.AppendLine();

            sb.AppendLine($"dcp_pref_lgc = {m_dcp_pref_lgc}");
            sb.AppendLine();

            sb.AppendLine($"lo_x_sts_cnt = {m_lo_x_sts_cnt}");
            for (i = 0; i < 5; i++)
            {
                sb.AppendLine($"lo_x_sts({i}) = {m_lo_x_sts[i].Display()}");
            }

            sb.AppendLine();

            sb.AppendLine($"hi_x_sts_cnt = {m_hi_x_sts_cnt}");
            for (i = 0; i < 5; i++)
            {
                sb.AppendLine($"hi_x_sts({i}) = {m_hi_x_sts[i].Display()}");
            }

            sb.AppendLine();

            sb.AppendLine($"lion_key = {m_lion_key.Display()}");
            sb.AppendLine($"spec_addr_flag = {m_spec_addr_flag}");
            sb.AppendLine($"sos_ind = {m_sos_ind}");
            sb.AppendLine($"segment_len = {m_segment_len}");
            sb.AppendLine();
            sb.AppendLine($"x_coord = {m_x_coord}");
            sb.AppendLine($"y_coord = {m_y_coord}");
            sb.AppendLine($"z_coord = {m_z_coord}");
            sb.AppendLine();
            sb.AppendLine($"res_gss = {m_res_gss}");
            sb.AppendLine($"mh_ri_flag = {m_mh_ri_flag}");
            sb.AppendLine($"zip_code = {m_zip_code}");
            sb.AppendLine($"filler3 = {m_filler3}");
            sb.AppendLine($"true_hns = {m_true_hns}");
            sb.AppendLine($"real_b7sc = {m_real_b7sc.Display()}");
            sb.AppendLine($"segment_id = {m_segment_id}");
            sb.AppendLine($"curve_flag = {m_curve_flag}");
            sb.AppendLine($"dynamic_block = {m_dynamic_block}");
            sb.AppendLine($"feature_type = {m_feature_type}");
            sb.AppendLine($"segment_type = {m_segment_type}");
            sb.AppendLine($"alx = {m_alx}");
            sb.AppendLine($"coincident_seg_cnt = {m_coincident_seg_cnt}");

            sb.AppendLine();
            sb.AppendLine("**********  Election District Information  **********");
            sb.AppendLine();

            sb.AppendLine($"ed = {m_ed}");
            sb.AppendLine($"ad = {m_ad}");
            sb.AppendLine($"split_ed = {m_split_ed}");
            sb.AppendLine($"cd = {m_cd}");
            sb.AppendLine($"sd = {m_sd}");
            sb.AppendLine($"mc = {m_mc}");
            sb.AppendLine($"co = {m_co}");

            sb.AppendLine();
            sb.AppendLine("**********  Other District Information  **********");
            sb.AppendLine();

            sb.AppendLine($"dot_st_light_contract_area = {m_dot_st_light_contract_area}");
            sb.AppendLine();
            sb.AppendLine($"com_dist = {m_com_dist.Display()}");
            sb.AppendLine();
            sb.AppendLine($"nta = {m_nta}");
            sb.AppendLine();
            sb.AppendLine($"hurricane_zone = {m_hurricane_zone}");
            sb.AppendLine();
            sb.AppendLine($"split_school_dist_flag = {m_split_school_dist_flag}");
            sb.AppendLine($"school_dist = {m_school_dist}");
            sb.AppendLine($"instruc_div = {m_police_patrol_boro}");

            sb.AppendLine();
            sb.AppendLine($"health_center_dist = {m_health_center_dist}");
            sb.AppendLine($"health_area = {m_health_area}");

            sb.AppendLine();
            sb.AppendLine("**********  Sanitation Information  **********");
            sb.AppendLine();

            sb.AppendLine($"san_dist = {m_san_dist}");
            sb.AppendLine($"san_sched = {m_san_sched}");
            sb.AppendLine($"san_reg = {m_san_reg}");
            sb.AppendLine($"san_recycle = {m_san_recycle}");
            sb.AppendLine($"dsny_snow_priority = {m_dsny_snow_priority}");
            sb.AppendLine($"san_org_pick_up = {m_san_org_pick_up}");
            sb.AppendLine($"san_bulk = {m_san_bulk}");
            sb.AppendLine($"san_commercial_waste_zone = {m_san_commercial_waste_zone}");

            sb.AppendLine();
            sb.AppendLine("**********  Police and Fire Information  **********");
            sb.AppendLine();

            sb.AppendLine($"police_boro_com = {m_police_boro_com}");
            sb.AppendLine($"police_pct = {m_police_pct}");
            sb.AppendLine($"fire_div = {m_fire_div}");
            sb.AppendLine($"fire_bat = {m_fire_bat}");
            sb.AppendLine($"fire_co_type = {m_fire_co_type}");
            sb.AppendLine($"fire_co_num = {m_fire_co_num}");

            sb.AppendLine();
            sb.AppendLine("**********  Census Information  **********");
            sb.AppendLine();

            sb.AppendLine($"filler_80ct = {m_filler_80ct}");
            sb.AppendLine($"census_tract_1990 = {m_census_tract_1990}");
            sb.AppendLine($"census_tract_2010 = {m_census_tract_2010}");
            sb.AppendLine($"census_block_2010 = {m_census_block_2010}");
            sb.AppendLine($"census_block_suffix_2010 = {m_census_block_suffix_2010}");
            sb.AppendLine($"census_tract_2000 = {m_census_tract_2000}");
            sb.AppendLine($"census_block_2000 = {m_census_block_2000}");
            sb.AppendLine($"census_block_suffix_2000 = {m_census_block_suffix_2000}");

            return sb.ToString();
        }

        public VsamKey1 gridkey1
        {
            get => m_gridkey1;
            set => m_gridkey1 = value;
        }

        /// <summary>
        /// Property for cont_parity_ind
        /// </summary>
        public string cont_parity_ind
        {
            get => m_cont_parity_ind;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_cont_parity_ind = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for lo_hns
        /// </summary>
        public string lo_hns
        {
            get => m_lo_hns;
            set
            {
                int strlen = value.Length;
                if (strlen > 11) strlen = 11;
                m_lo_hns = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for hi_hns
        /// </summary>
        public string hi_hns
        {
            get => m_hi_hns;
            set
            {
                int strlen = value.Length;
                if (strlen > 11) strlen = 11;
                m_hi_hns = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for dcp_pref_lgc
        /// </summary>
        public string dcp_pref_lgc
        {
            get => m_dcp_pref_lgc;
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_dcp_pref_lgc = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for lo_x_sts_cnt
        /// </summary>
        public string lo_x_sts_cnt
        {
            get => m_lo_x_sts_cnt;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_lo_x_sts_cnt = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for lo_x_sts() array
        /// </summary>
        public B5sc[] lo_x_sts
        {
            get => m_lo_x_sts;
            set => m_lo_x_sts = value;
        }

        /// <summary>
        /// Property for lo_x_sts() item
        /// </summary>
        public B5sc lo_x_sts_item(int index) => m_lo_x_sts[index];

        public void lo_x_sts_item(int index, B5sc value) => m_lo_x_sts[index] = value;
        

        /// <summary>
        /// Property for hi_x_sts_cnt
        /// </summary>
        public string hi_x_sts_cnt
        {
            get => m_hi_x_sts_cnt;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_hi_x_sts_cnt = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for hi_x_sts() array
        /// </summary>
        public B5sc[] hi_x_sts
        {
            get => m_hi_x_sts;
            set => m_hi_x_sts = value;
        }

        /// <summary>
        /// Property for hi_x_sts() item
        /// </summary>
        public B5sc hi_x_sts_item(int index) => m_hi_x_sts[index];

        public B5sc hi_x_sts_item(int index, B5sc value) => m_hi_x_sts[index] = value;
        
        /// <summary>
        /// Property for lion_key
        /// </summary>
        public LionKey lion_key
        {
            get => m_lion_key;
            set => m_lion_key = value;
        }

        public string spec_addr_flag
        {
            get => m_spec_addr_flag;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_spec_addr_flag = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for sos_ind
        /// </summary>
        public string sos_ind
        {
            get => m_sos_ind;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_sos_ind = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for segment_len
        /// </summary>
        public string segment_len
        {
            get => m_segment_len;
            set
            {
                int strlen = value.Length;
                if (strlen > 5) strlen = 5;
                m_segment_len = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for x_coord
        /// </summary>
        public string x_coord
        {
            get => m_x_coord;
            set
            {
                int strlen = value.Length;
                if (strlen > 7) strlen = 7;
                m_x_coord = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for y_coord
        /// </summary>
        public string y_coord
        {
            get => m_y_coord;
            set
            {
                int strlen = value.Length;
                if (strlen > 7) strlen = 7;
                m_y_coord = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for z_coord
        /// </summary>
        public string z_coord
        {
            get => m_z_coord;
            set
            {
                int strlen = value.Length;
                if (strlen > 7) strlen = 7;
                m_z_coord = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for res_gss
        /// </summary>
        public string res_gss
        {
            get => m_res_gss;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_res_gss = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for mh_ri_flag
        /// </summary>
        public string mh_ri_flag
        {
            get => m_mh_ri_flag;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_mh_ri_flag = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for dot_st_light_contract_area
        /// </summary>
        public string dot_st_light_contract_area
        {
            get => m_dot_st_light_contract_area;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_dot_st_light_contract_area = value.Substring(0, strlen);
            }
        }

        public ComDist com_dist
        {
            get => m_com_dist;
            set => m_com_dist = value;
        }

        /// <summary>
        /// Property for zip_code
        /// </summary>
        public string zip_code
        {
            get => m_zip_code;
            set
            {
                int strlen = value.Length;
                if (strlen > 5) strlen = 5;
                m_zip_code = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for ed
        /// </summary>
        public string ed
        {
            get => m_ed;
            set
            {
                int strlen = value.Length;
                if (strlen > 3) strlen = 3;
                m_ed = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for ad
        /// </summary>
        public string ad
        {
            get => m_ad;
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_ad = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for split_ed
        /// </summary>
        public string split_ed
        {
            get => m_split_ed;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_split_ed = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for cd
        /// </summary>
        public string cd
        {
            get => m_cd;
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_cd = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for sd
        /// </summary>
        public string sd
        {
            get => m_sd;
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_sd = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for mc
        /// </summary>
        public string mc
        {
            get => m_mc;
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_mc = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for co
        /// </summary>
        public string co
        {
            get => m_co;
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_co = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for health_center_dist
        /// </summary>
        public string health_center_dist
        {
            get => m_health_center_dist;
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_health_center_dist = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for health_area
        /// </summary>
        public string health_area
        {
            get => m_health_area;
            set
            {
                int strlen = value.Length;
                if (strlen > 4) strlen = 4;
                m_health_area = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for san_dist
        /// </summary>
        public string san_dist
        {
            get => m_san_dist;
            set
            {
                int strlen = value.Length;
                if (strlen > 3) strlen = 3;
                m_san_dist = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for san_sched
        /// </summary>
        public string san_sched
        {
            get => m_san_sched;
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_san_sched = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for san_reg
        /// </summary>
        public string san_reg
        {
            get => m_san_reg;
            set
            {
                int strlen = value.Length;
                if (strlen > 5) strlen = 5;
                m_san_reg = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for san_recycle
        /// </summary>
        public string san_recycle
        {
            get => m_san_recycle;
            set
            {
                int strlen = value.Length;
                if (strlen > 3) strlen = 3;
                m_san_recycle = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for police_boro_com
        /// </summary>
        public string police_boro_com
        {
            get => m_police_boro_com;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_police_boro_com = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for police_pct
        /// </summary>
        public string police_pct
        {
            get => m_police_pct;
            set
            {
                int strlen = value.Length;
                if (strlen > 3) strlen = 3;
                m_police_pct = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for fire_div
        /// </summary>
        public string fire_div
        {
            get => m_fire_div;
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_fire_div = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for fire_bat
        /// </summary>
        public string fire_bat
        {
            get => m_fire_bat;
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_fire_bat = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for fire_co_type
        /// </summary>
        public string fire_co_type
        {
            get => m_fire_co_type;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_fire_co_type = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for fire_co_num
        /// </summary>
        public string fire_co_num
        {
            get => m_fire_co_num;
            set
            {
                int strlen = value.Length;
                if (strlen > 3) strlen = 3;
                m_fire_co_num = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for split_school_dist_flag
        /// </summary>
        public string split_school_dist_flag
        {
            get => m_split_school_dist_flag;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_split_school_dist_flag = value.Substring(0, strlen);
            }
        }

        public string school_dist
        {
            get => m_school_dist;
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_school_dist = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for dynamic_block
        /// </summary>
        public string dynamic_block
        {
            get => m_dynamic_block;
            set
            {
                int strlen = value.Length;
                if (strlen > 3) strlen = 3;
                m_dynamic_block = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for police_patrol_boro
        /// </summary>
        public string police_patrol_boro
        {
            get => m_police_patrol_boro;
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_police_patrol_boro = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for feature_type
        /// </summary>
        public string feature_type
        {
            get => m_feature_type;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_feature_type = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for segment_type
        /// </summary>
        public string segment_type
        {
            get => m_segment_type;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_segment_type = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for alx
        /// </summary>
        public string alx
        {
            get => m_alx;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_alx = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for coincident_seg_cnt
        /// </summary>
        public string coincident_seg_cnt
        {
            get => m_coincident_seg_cnt;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_coincident_seg_cnt = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for filler_80ct
        /// </summary>
        public string filler_80ct
        {
            get => m_filler_80ct;
            set
            {
                int strlen = value.Length;
                if (strlen > 3) strlen = 3;
                m_filler_80ct = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for census_tract_1990
        /// </summary>
        public string census_tract_1990
        {
            get => m_census_tract_1990;
            set
            {
                int strlen = value.Length;
                if (strlen > 6) strlen = 6;
                m_census_tract_1990 = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for census_tract_2010
        /// </summary>
        public string census_tract_2010
        {
            get => m_census_tract_2010;
            set
            {
                int strlen = value.Length;
                if (strlen > 6) strlen = 6;
                m_census_tract_2010 = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for census_block_2010
        /// </summary>
        public string census_block_2010
        {
            get => m_census_block_2010;
            set
            {
                int strlen = value.Length;
                if (strlen > 4) strlen = 4;
                m_census_block_2010 = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for census_block_suffix_2010
        /// </summary>
        public string census_block_suffix_2010
        {
            get => m_census_block_suffix_2010;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_census_block_suffix_2010 = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for census_tract_2000
        /// </summary>
        public string census_tract_2000
        {
            get => m_census_tract_2000;
            set
            {
                int strlen = value.Length;
                if (strlen > 6) strlen = 6;
                m_census_tract_2000 = value.Substring(0, strlen);
            }
        }

        public string census_block_2000
        {
            get => m_census_block_2000;
            set
            {
                int strlen = value.Length;
                if (strlen > 4) strlen = 4;
                m_census_block_2000 = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for census_block_suffix_2000
        /// </summary>
        public string census_block_suffix_2000
        {
            get => m_census_block_suffix_2000;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_census_block_suffix_2000 = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for nta
        /// </summary>
        public string nta
        {
            get => m_nta;
            set
            {
                int strlen = value.Length;
                if (strlen > 4) strlen = 4;
                m_nta = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for dsny_snow_priority
        /// </summary>
        public string dsny_snow_priority
        {
            get => m_dsny_snow_priority;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_dsny_snow_priority = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for san_org_pick_up
        /// </summary>
        public string san_org_pick_up
        {
            get => m_san_org_pick_up;
            set
            {
                int strlen = value.Length;
                if (strlen > 5) strlen = 5;
                m_san_org_pick_up = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for san_bulk
        /// </summary>
        public string san_bulk
        {
            get => m_san_bulk;
            set
            {
                int strlen = value.Length;
                if (strlen > 5) strlen = 5;
                m_san_bulk = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for hurricane_zone
        /// </summary>
        public string hurricane_zone
        {
            get => m_hurricane_zone;
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_hurricane_zone = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for san_commercial_waste_zone
        /// </summary>
        public string san_commercial_waste_zone
        {
            get => m_san_commercial_waste_zone;
            set
            {
                int strlen = value.Length;
                if (strlen > 4) strlen = 4;
                m_san_commercial_waste_zone = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for filler3
        /// </summary>
        public string filler3
        {
            get => m_filler3;
            set
            {
                int strlen = value.Length;
                if (strlen > 7) strlen = 7;
                m_filler3 = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for true_hns
        /// </summary>
        public string true_hns
        {
            get => m_true_hns;
            set
            {
                int strlen = value.Length;
                if (strlen > 11) strlen = 11;
                m_true_hns = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for real_b7sc
        /// </summary>
        public B7sc real_b7sc
        {
            get => m_real_b7sc;
            set => m_real_b7sc = value;
        }

        /// <summary>
        /// Property for segment_id
        /// </summary>
        public string segment_id
        {
            get => m_segment_id;
            set
            {
                int strlen = value.Length;
                if (strlen > 7) strlen = 7;
                m_segment_id = value.Substring(0, strlen);
            }
        }

        /// <summary>
        /// Property for curve_flag
        /// </summary>
        public string curve_flag
        {
            get => m_curve_flag;
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_curve_flag = value.Substring(0, strlen);
            }
        }


    }
}
