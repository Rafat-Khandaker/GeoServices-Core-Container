using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperLib.Model
{
    public class Wa2F1 : WA
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
        private string m_filler3;
        private string m_true_hns;
        private B7sc m_real_b7sc;
        private string m_segment_id;
        private string m_curve_flag;

        public Wa2F1()
        {
            m_gridkey1 = new VsamKey1();
            m_cont_parity_ind = new string(' ', 1);
            m_lo_hns = new string(' ', 11);
            m_hi_hns = new string(' ', 11);
            m_dcp_pref_lgc = new string(' ', 2);
            m_lo_x_sts_cnt = new string(' ', 1);
            for (int i = 0; i < 5; i++)
            {
                m_lo_x_sts[i] = new B5sc();
            }
            m_hi_x_sts_cnt = new string(' ', 1);
            for (int i = 0; i < 5; i++)
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
            m_filler3 = new string(' ', 11);
            m_true_hns = new string(' ', 11);
            m_real_b7sc = new B7sc();
            m_segment_id = new string(' ', 7);
            m_curve_flag = new string(' ', 1);
        }
    

        public Wa2F1(string inString)
        {
            Wa2F1FromString(inString);
        }

        /// <summary>
        /// <c>Clear</c> reinitializes the <c>Wa2F1</c> object to spaces
        /// </summary>
        public override void Clear()
        {
            Wa2F1FromString(new string(' ', 300));
        }

        /// <summary>
        /// <c>ToString</c> converts a <c>Wa2F1</c> object to a string
        /// </summary>
        public override string ToString()
        {
            return Wa2F1ToString();
        }

        /// <summary>
        /// <c>FromString</c> converts a string to a <c>Wa2F1</c> object
        /// </summary>
        public override void FromString(string inString)
        {
            Wa2F1FromString(inString);
        }

        /// <summary>
        /// <c>Wa2F1ToString</c> converts a <c>Wa2F1</c> object to a string
        /// </summary>
        public string Wa2F1ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(m_gridkey1.VsamKey1ToString());
            sb.Append(m_cont_parity_ind);
            sb.Append(m_lo_hns);
            sb.Append(m_hi_hns);
            sb.Append(m_dcp_pref_lgc);
            sb.Append(m_lo_x_sts_cnt);

            for (int i = 0; i < 5; i++)
            {
                sb.Append(m_lo_x_sts[i].B5scToString());
            }

            sb.Append(m_hi_x_sts_cnt);

            for (int i = 0; i < 5; i++)
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
            sb.Append(m_police_patrol_boro);
            sb.Append(m_feature_type);
            sb.Append(m_segment_type);
            sb.Append(m_alx);
            sb.Append(m_coincident_seg_cnt);
            sb.Append(m_filler_80ct);
            sb.Append(m_census_tract_1990);
            sb.Append(m_census_tract_2010);
            sb.Append(m_census_block_2010);
            sb.Append(m_census_block_suffix_2010);
            sb.Append(m_census_tract_2000);
            sb.Append(m_census_block_2000);
            sb.Append(m_census_block_suffix_2000);
            sb.Append(m_nta);
            sb.Append(m_dsny_snow_priority);
            sb.Append(m_san_org_pick_up);
            sb.Append(m_san_bulk);
            sb.Append(m_hurricane_zone);
            sb.Append(m_filler3);
            sb.Append(m_true_hns);
            sb.Append(m_real_b7sc.B7scToString());
            sb.Append(m_segment_id);
            sb.Append(m_curve_flag);

            return sb.ToString();
        }

        public void Wa2F1FromString(string inString)
        {
            int i;

            m_gridkey1 = new VsamKey1(inString.Substring(0, 21));
            m_cont_parity_ind = inString.Substring(21, 1);
            m_lo_hns = inString.Substring(22, 11);
            m_hi_hns = inString.Substring(33, 11);
            m_dcp_pref_lgc = inString.Substring(44, 2);
            m_lo_x_sts_cnt = inString.Substring(46, 1);

            for (i = 0; i <= 4; i++)
            {
                m_lo_x_sts[i] = new B5sc(inString.Substring(47 + (i * 6), 6));
            }

            m_hi_x_sts_cnt = inString.Substring(77, 1);

            for (i = 0; i <= 4; i++)
            {
                m_hi_x_sts[i] = new B5sc(inString.Substring(78 + (i * 6), 6));
            }

            m_lion_key = new LionKey(inString.Substring(108, 10));
            m_spec_addr_flag = inString.Substring(118, 1);
            m_sos_ind = inString.Substring(119, 1);
            m_segment_len = inString.Substring(120, 5);
            m_x_coord = inString.Substring(125, 7);
            m_y_coord = inString.Substring(132, 7);
            m_z_coord = inString.Substring(139, 7);
            m_res_gss = inString.Substring(146, 1);
            m_mh_ri_flag = inString.Substring(147, 1);
            m_dot_st_light_contract_area = inString.Substring(148, 1);
            m_com_dist = new ComDist(inString.Substring(149, 3));
            m_zip_code = inString.Substring(152, 5);
            m_ed = inString.Substring(157, 3);
            m_ad = inString.Substring(160, 2);
            m_split_ed = inString.Substring(162, 1);
            m_cd = inString.Substring(163, 2);
            m_sd = inString.Substring(165, 2);
            m_mc = inString.Substring(167, 2);
            m_co = inString.Substring(169, 2);
            m_health_center_dist = inString.Substring(171, 2);
            m_health_area = inString.Substring(173, 4);
            m_san_dist = inString.Substring(177, 3);
            m_san_sched = inString.Substring(180, 2);
            m_san_reg = inString.Substring(182, 5);
            m_san_recycle = inString.Substring(187, 3);
            m_police_boro_com = inString.Substring(190, 1);
            m_police_pct = inString.Substring(191, 3);
            m_fire_div = inString.Substring(194, 2);
            m_fire_bat = inString.Substring(196, 2);
            m_fire_co_type = inString.Substring(198, 1);
            m_fire_co_num = inString.Substring(199, 3);
            m_split_school_dist_flag = inString.Substring(202, 1);
            m_school_dist = inString.Substring(203, 2);
            m_dynamic_block = inString.Substring(205, 3);

            //spo(2014-11-10): added police patrol borough
            // Replaces instruct_div location
            // m_instruc_div = inString.Substring(208, 2);
            m_police_patrol_boro = inString.Substring(208, 2);
            m_feature_type = inString.Substring(210, 1);
            m_segment_type = inString.Substring(211, 1);
            m_alx = inString.Substring(212, 1);

            //spo (2007-07-17) added m_coincident_seg_cnt
            m_coincident_seg_cnt = inString.Substring(213, 1);
            m_filler_80ct = inString.Substring(214, 3);
            m_census_tract_1990 = inString.Substring(217, 6);

            //spo(2011-09-24): Geosupport 11.0 added 2010 census and moved 2000 census fields
            m_census_tract_2010 = inString.Substring(223, 6);
            m_census_block_2010 = inString.Substring(229, 4);
            m_census_block_suffix_2010 = inString.Substring(233, 1);
            m_census_tract_2000 = inString.Substring(234, 6);
            m_census_block_2000 = inString.Substring(240, 4);
            m_census_block_suffix_2000 = inString.Substring(244, 1);

            //spo(2012-04-06): added for Geosupport Version 11.3 / Release 12A
            m_nta = inString.Substring(245, 4);

            //spo(2012-04-06): added for Geosupport Version 11.3 / Release 12A
            m_dsny_snow_priority = inString.Substring(249, 1);

            //spo(2014-02-28): added for Geosupport Version 14.1 / Release 14A
            m_san_org_pick_up = inString.Substring(250, 5);

            //njp(2014-09-29) renaming filler to Sanitation Bulk for version 16.4
            m_san_bulk = inString.Substring(255, 5);

            //spo(2014-02-28): added for Geosupport Version 14.1 / Release 14A
            m_hurricane_zone = inString.Substring(260, 2);
            m_filler3 = inString.Substring(262, 11);
            m_true_hns = inString.Substring(273, 11);
            m_real_b7sc = new B7sc(inString.Substring(284, 8));
            m_segment_id = inString.Substring(292, 7);
            m_curve_flag = inString.Substring(299, 1);
        }

        public override string Display(char c)
        {
            StringBuilder sb = new StringBuilder();

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

            for (int i = 0; i <= 4; i++)
            {
                sb.Append(m_lo_x_sts[i].Display());
                sb.Append(c);
            }

            sb.Append(m_hi_x_sts_cnt);
            sb.Append(c);

            for (int i = 0; i <= 4; i++)
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

            // Added police patrol borough (replaces instruct_div location)
            sb.Append(m_police_patrol_boro);
            sb.Append(c);
            sb.Append(m_feature_type);
            sb.Append(c);
            sb.Append(m_segment_type);
            sb.Append(c);
            sb.Append(m_alx);
            sb.Append(c);

            // Added m_coincident_seg_cnt
            sb.Append(m_coincident_seg_cnt);
            sb.Append(c);
            sb.Append(m_filler_80ct);
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

            // Added for Geosupport Version 11.3 / Release 12A
            sb.Append(m_nta);
            sb.Append(c);
            sb.Append(m_dsny_snow_priority);
            sb.Append(c);

            // Added for Geosupport Version 14.1 / Release 14A
            sb.Append(m_san_org_pick_up);
            sb.Append(c);

            // Renaming filler to Sanitation Bulk for version 16.4
            sb.Append(m_san_bulk);
            sb.Append(c);

            // Added for Geosupport Version 14.1 / Release 14A
            sb.Append(m_hurricane_zone);
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

            return sb.ToString();
        }

        public override string Display()
        {
            return this.Display('-');
        }

        /// <summary>
        /// <c>Print</c>
        /// <para>Creates a string with <c>Wa2F1</c> field names and values</para>
        /// </summary>
        public override string Print()
        {
            StringBuilder sb = new StringBuilder();
            int i;

            // Using Environment.NewLine instead of vbCrLf
            sb.AppendFormat("gridkey1 = {0}{1}", m_gridkey1.Display(), Environment.NewLine);
            sb.AppendFormat("cont_parity_ind = {0}{1}", m_cont_parity_ind, Environment.NewLine);
            sb.AppendFormat("lo_hns = {0}{1}", m_lo_hns, Environment.NewLine);
            sb.AppendFormat("hi_hns = {0}{1}", m_hi_hns, Environment.NewLine);
            sb.AppendFormat("dcp_pref_lgc = {0}{1}", m_dcp_pref_lgc, Environment.NewLine);
            sb.AppendFormat("lo_x_sts_cnt = {0}{1}", m_lo_x_sts_cnt, Environment.NewLine);

            for (i = 0; i <= 4; i++)
            {
                sb.AppendFormat("lo_x_sts({0}) = {1}{2}", i, m_lo_x_sts[i].Display(), Environment.NewLine);
            }

            sb.AppendFormat("hi_x_sts_cnt = {0}{1}", m_hi_x_sts_cnt, Environment.NewLine);

            for (i = 0; i <= 4; i++)
            {
                sb.AppendFormat("hi_x_sts({0}) = {1}{2}", i, m_hi_x_sts[i].Display(), Environment.NewLine);
            }

            sb.AppendFormat("lion_key = {0}{1}", m_lion_key.Display(), Environment.NewLine);
            sb.AppendFormat("spec_addr_flag = {0}{1}", m_spec_addr_flag, Environment.NewLine);
            sb.AppendFormat("sos_ind = {0}{1}", m_sos_ind, Environment.NewLine);
            sb.AppendFormat("segment_len = {0}{1}", m_segment_len, Environment.NewLine);
            sb.AppendFormat("x_coord = {0}{1}", m_x_coord, Environment.NewLine);
            sb.AppendFormat("y_coord = {0}{1}", m_y_coord, Environment.NewLine);
            sb.AppendFormat("z_coord = {0}{1}", m_z_coord, Environment.NewLine);
            sb.AppendFormat("res_gss = {0}{1}", m_res_gss, Environment.NewLine);
            sb.AppendFormat("mh_ri_flag = {0}{1}", m_mh_ri_flag, Environment.NewLine);
            sb.AppendFormat("dot_st_light_contract_area = {0}{1}", m_dot_st_light_contract_area, Environment.NewLine);
            sb.AppendFormat("com_dist = {0}{1}", m_com_dist.Display(), Environment.NewLine);
            sb.AppendFormat("zip_code = {0}{1}", m_zip_code, Environment.NewLine);
            sb.AppendFormat("ed = {0}{1}", m_ed, Environment.NewLine);
            sb.AppendFormat("ad = {0}{1}", m_ad, Environment.NewLine);
            sb.AppendFormat("split_ed = {0}{1}", m_split_ed, Environment.NewLine);
            sb.AppendFormat("cd = {0}{1}", m_cd, Environment.NewLine);
            sb.AppendFormat("sd = {0}{1}", m_sd, Environment.NewLine);
            sb.AppendFormat("mc = {0}{1}", m_mc, Environment.NewLine);
            sb.AppendFormat("co = {0}{1}", m_co, Environment.NewLine);
            sb.AppendFormat("health_center_dist = {0}{1}", m_health_center_dist, Environment.NewLine);
            sb.AppendFormat("health_area = {0}{1}", m_health_area, Environment.NewLine);
            sb.AppendFormat("san_dist = {0}{1}", m_san_dist, Environment.NewLine);
            sb.AppendFormat("san_sched = {0}{1}", m_san_sched, Environment.NewLine);
            sb.AppendFormat("san_reg = {0}{1}", m_san_reg, Environment.NewLine);
            sb.AppendFormat("san_recycle = {0}{1}", m_san_recycle, Environment.NewLine);
            sb.AppendFormat("police_boro_com = {0}{1}", m_police_boro_com, Environment.NewLine);
            sb.AppendFormat("police_pct = {0}{1}", m_police_pct, Environment.NewLine);
            sb.AppendFormat("fire_div = {0}{1}", m_fire_div, Environment.NewLine);
            sb.AppendFormat("fire_bat = {0}{1}", m_fire_bat, Environment.NewLine);
            sb.AppendFormat("fire_co_type = {0}{1}", m_fire_co_type, Environment.NewLine);
            sb.AppendFormat("fire_co_num = {0}{1}", m_fire_co_num, Environment.NewLine);
            sb.AppendFormat("split_school_dist_flag = {0}{1}", m_split_school_dist_flag, Environment.NewLine);
            sb.AppendFormat("school_dist = {0}{1}", m_school_dist, Environment.NewLine);
            sb.AppendFormat("dynamic_block = {0}{1}", m_dynamic_block, Environment.NewLine);

            // Added police patrol borough
            sb.AppendFormat("instruc_div = {0}{1}", m_police_patrol_boro, Environment.NewLine);
            sb.AppendFormat("feature_type = {0}{1}", m_feature_type, Environment.NewLine);
            sb.AppendFormat("segment_type = {0}{1}", m_segment_type, Environment.NewLine);
            sb.AppendFormat("alx = {0}{1}", m_alx, Environment.NewLine);

            // Added m_coincident_seg_cnt
            sb.AppendFormat("coincident_seg_cnt = {0}{1}", m_coincident_seg_cnt, Environment.NewLine);
            sb.AppendFormat("filler_80ct = {0}{1}", m_filler_80ct, Environment.NewLine);
            sb.AppendFormat("census_tract_1990 = {0}{1}", m_census_tract_1990, Environment.NewLine);

            // Geosupport 11.0 added 2010 census and moved 2000 census fields
            sb.AppendFormat("census_tract_2010 = {0}{1}", m_census_tract_2010, Environment.NewLine);
            sb.AppendFormat("census_block_2010 = {0}{1}", m_census_block_2010, Environment.NewLine);
            sb.AppendFormat("census_block_suffix_2010 = {0}{1}", m_census_block_suffix_2010, Environment.NewLine);
            sb.AppendFormat("census_tract_2000 = {0}{1}", m_census_tract_2000, Environment.NewLine);
            sb.AppendFormat("census_block_2000 = {0}{1}", m_census_block_2000, Environment.NewLine);
            sb.AppendFormat("census_block_suffix_2000 = {0}{1}", m_census_block_suffix_2000, Environment.NewLine);

            // Added for Geosupport Version 11.3 / Release 12A
            sb.AppendFormat("nta = {0}{1}", m_nta, Environment.NewLine);
            sb.AppendFormat("dsny_snow_priority = {0}{1}", m_dsny_snow_priority, Environment.NewLine);

            // Added for Geosupport Version 14.1 / Release 14A
            sb.AppendFormat("san_org_pick_up = {0}{1}", m_san_org_pick_up, Environment.NewLine);

            // Renaming filler to Sanitation Bulk for version 16.4
            sb.AppendFormat("san_bulk = {0}{1}", m_san_bulk, Environment.NewLine);

            // Added for Geosupport Version 14.1 / Release 14A
            sb.AppendFormat("hurricane_zone = {0}{1}", m_hurricane_zone, Environment.NewLine);
            sb.AppendFormat("filler3 = {0}{1}", m_filler3, Environment.NewLine);
            sb.AppendFormat("true_hns = {0}{1}", m_true_hns, Environment.NewLine);
            sb.AppendFormat("real_b7sc = {0}{1}", m_real_b7sc.Display(), Environment.NewLine);
            sb.AppendFormat("segment_id = {0}{1}", m_segment_id, Environment.NewLine);
            sb.AppendFormat("curve_flag = {0}{1}", m_curve_flag, Environment.NewLine);

            return sb.ToString();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            int i;

            sb.AppendFormat("{0}", Environment.NewLine);
            sb.AppendFormat("{0}{1}", "****************************************************************************", Environment.NewLine);
            sb.AppendFormat("{0}{1}", "******************************  Wa2F1  ***********************************", Environment.NewLine);
            sb.AppendFormat("{0}{1}", "****************************************************************************", Environment.NewLine);

            sb.AppendFormat("gridkey1 = {0}{1}", m_gridkey1.Display(), Environment.NewLine);
            sb.AppendFormat("cont_parity_ind = {0}{1}", m_cont_parity_ind, Environment.NewLine);
            sb.AppendFormat("lo_hns = {0}{1}", m_lo_hns, Environment.NewLine);
            sb.AppendFormat("hi_hns = {0}{1}", m_hi_hns, Environment.NewLine);
            sb.AppendFormat("dcp_pref_lgc = {0}{1}", m_dcp_pref_lgc, Environment.NewLine);
            sb.AppendFormat("lo_x_sts_cnt = {0}{1}", m_lo_x_sts_cnt, Environment.NewLine);

            for (i = 0; i <= 4; i++)
            {
                sb.AppendFormat("lo_x_sts({0}) = {1}{2}", i, m_lo_x_sts[i].Display(), Environment.NewLine);
            }

            sb.AppendFormat("hi_x_sts_cnt = {0}{1}", m_hi_x_sts_cnt, Environment.NewLine);

            for (i = 0; i <= 4; i++)
            {
                sb.AppendFormat("hi_x_sts({0}) = {1}{2}", i, m_hi_x_sts[i].Display(), Environment.NewLine);
            }

            sb.AppendFormat("lion_key = {0}{1}", m_lion_key.Display(), Environment.NewLine);
            sb.AppendFormat("spec_addr_flag = {0}{1}", m_spec_addr_flag, Environment.NewLine);
            sb.AppendFormat("sos_ind = {0}{1}", m_sos_ind, Environment.NewLine);
            sb.AppendFormat("segment_len = {0}{1}", m_segment_len, Environment.NewLine);
            sb.AppendFormat("x_coord = {0}{1}", m_x_coord, Environment.NewLine);
            sb.AppendFormat("y_coord = {0}{1}", m_y_coord, Environment.NewLine);
            sb.AppendFormat("z_coord = {0}{1}", m_z_coord, Environment.NewLine);
            sb.AppendFormat("res_gss = {0}{1}", m_res_gss, Environment.NewLine);
            sb.AppendFormat("mh_ri_flag = {0}{1}", m_mh_ri_flag, Environment.NewLine);
            sb.AppendFormat("dot_st_light_contract_area = {0}{1}", m_dot_st_light_contract_area, Environment.NewLine);
            sb.AppendFormat("com_dist = {0}{1}", m_com_dist.Display(), Environment.NewLine);
            sb.AppendFormat("zip_code = {0}{1}", m_zip_code, Environment.NewLine);
            sb.AppendFormat("ed = {0}{1}", m_ed, Environment.NewLine);
            sb.AppendFormat("ad = {0}{1}", m_ad, Environment.NewLine);
            sb.AppendFormat("split_ed = {0}{1}", m_split_ed, Environment.NewLine);
            sb.AppendFormat("cd = {0}{1}", m_cd, Environment.NewLine);
            sb.AppendFormat("sd = {0}{1}", m_sd, Environment.NewLine);
            sb.AppendFormat("mc = {0}{1}", m_mc, Environment.NewLine);
            sb.AppendFormat("co = {0}{1}", m_co, Environment.NewLine);
            sb.AppendFormat("health_center_dist = {0}{1}", m_health_center_dist, Environment.NewLine);
            sb.AppendFormat("health_area = {0}{1}", m_health_area, Environment.NewLine);
            sb.AppendFormat("san_dist = {0}{1}", m_san_dist, Environment.NewLine);
            sb.AppendFormat("san_sched = {0}{1}", m_san_sched, Environment.NewLine);
            sb.AppendFormat("san_reg = {0}{1}", m_san_reg, Environment.NewLine);
            sb.AppendFormat("san_recycle = {0}{1}", m_san_recycle, Environment.NewLine);
            sb.AppendFormat("police_boro_com = {0}{1}", m_police_boro_com, Environment.NewLine);
            sb.AppendFormat("police_pct = {0}{1}", m_police_pct, Environment.NewLine);
            sb.AppendFormat("fire_div = {0}{1}", m_fire_div, Environment.NewLine);
            sb.AppendFormat("fire_bat = {0}{1}", m_fire_bat, Environment.NewLine);
            sb.AppendFormat("fire_co_type = {0}{1}", m_fire_co_type, Environment.NewLine);
            sb.AppendFormat("fire_co_num = {0}{1}", m_fire_co_num, Environment.NewLine);
            sb.AppendFormat("split_school_dist_flag = {0}{1}", m_split_school_dist_flag, Environment.NewLine);
            sb.AppendFormat("school_dist = {0}{1}", m_school_dist, Environment.NewLine);
            sb.AppendFormat("dynamic_block = {0}{1}", m_dynamic_block, Environment.NewLine);

            // Added police patrol borough
            sb.AppendFormat("instruc_div = {0}{1}", m_police_patrol_boro, Environment.NewLine);
            sb.AppendFormat("feature_type = {0}{1}", m_feature_type, Environment.NewLine);
            sb.AppendFormat("segment_type = {0}{1}", m_segment_type, Environment.NewLine);
            sb.AppendFormat("alx = {0}{1}", m_alx, Environment.NewLine);

            // Added m_coincident_seg_cnt
            sb.AppendFormat("coincident_seg_cnt = {0}{1}", m_coincident_seg_cnt, Environment.NewLine);
            sb.AppendFormat("filler_80ct = {0}{1}", m_filler_80ct, Environment.NewLine);
            sb.AppendFormat("census_tract_1990 = {0}{1}", m_census_tract_1990, Environment.NewLine);

            // Geosupport 11.0 added 2010 census and moved 2000 census fields
            sb.AppendFormat("census_tract_2010 = {0}{1}", m_census_tract_2010, Environment.NewLine);
            sb.AppendFormat("census_block_2010 = {0}{1}", m_census_block_2010, Environment.NewLine);
            sb.AppendFormat("census_block_suffix_2010 = {0}{1}", m_census_block_suffix_2010, Environment.NewLine);
            sb.AppendFormat("census_tract_2000 = {0}{1}", m_census_tract_2000, Environment.NewLine);
            sb.AppendFormat("census_block_2000 = {0}{1}", m_census_block_2000, Environment.NewLine);
            sb.AppendFormat("census_block_suffix_2000 = {0}{1}", m_census_block_suffix_2000, Environment.NewLine);

            // Added for Geosupport Version 11.3 / Release 12A
            sb.AppendFormat("nta = {0}{1}", m_nta, Environment.NewLine);
            sb.AppendFormat("dsny_snow_priority = {0}{1}", m_dsny_snow_priority, Environment.NewLine);

            // Added for Geosupport Version 14.1 / Release 14A
            sb.AppendFormat("san_org_pick_up = {0}{1}", m_san_org_pick_up, Environment.NewLine);

            // Renaming filler to Sanitation Bulk for version 16.4
            sb.AppendFormat("san_bulk = {0}{1}", m_san_bulk, Environment.NewLine);

            // Added for Geosupport Version 14.1 / Release 14A
            sb.AppendFormat("hurricane_zone = {0}{1}", m_hurricane_zone, Environment.NewLine);
            sb.AppendFormat("filler3 = {0}{1}", m_filler3, Environment.NewLine);
            sb.AppendFormat("true_hns = {0}{1}", m_true_hns, Environment.NewLine);
            sb.AppendFormat("real_b7sc = {0}{1}", m_real_b7sc.Display(), Environment.NewLine);
            sb.AppendFormat("segment_id = {0}{1}", m_segment_id, Environment.NewLine);
            sb.AppendFormat("curve_flag = {0}{1}", m_curve_flag, Environment.NewLine);

            return sb.ToString();
        }

        public VsamKey1 gridkey1
        {
            get { return m_gridkey1; }
            set { m_gridkey1 = value; }
        }

        public string cont_parity_ind
        {
            get { return m_cont_parity_ind; }
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_cont_parity_ind = value.Substring(0, strlen);
            }
        }

        public string lo_hns
        {
            get { return m_lo_hns; }
            set
            {
                int strlen = value.Length;
                if (strlen > 11) strlen = 11;
                m_lo_hns = value.Substring(0, strlen);
            }
        }

        public string hi_hns
        {
            get { return m_hi_hns; }
            set
            {
                int strlen = value.Length;
                if (strlen > 11) strlen = 11;
                m_hi_hns = value.Substring(0, strlen);
            }
        }

        public string dcp_pref_lgc
        {
            get { return m_dcp_pref_lgc; }
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_dcp_pref_lgc = value.Substring(0, strlen);
            }
        }

        public string lo_x_sts_cnt
        {
            get { return m_lo_x_sts_cnt; }
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_lo_x_sts_cnt = value.Substring(0, strlen);
            }
        }

        public B5sc[] lo_x_sts
        {
            get { return m_lo_x_sts; }
            set { m_lo_x_sts = value; }
        }

        public B5sc lo_x_sts_item(int index) => m_lo_x_sts[index];
        public void lo_x_sts_item(int index, B5sc value) => m_lo_x_sts[index] = value;


        public string hi_x_sts_cnt
        {
            get { return m_hi_x_sts_cnt; }
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_hi_x_sts_cnt = value.Substring(0, strlen);
            }
        }

        public B5sc[] hi_x_sts
        {
            get { return m_hi_x_sts; }
            set { m_hi_x_sts = value; }
        }

        public B5sc hi_x_sts_item(int index) => m_hi_x_sts[index];

        public void hi_x_sts_item(int index, B5sc value) => m_hi_x_sts[index] = value;

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
            set { m_com_dist = value; }
        }

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

        public string mc
        {
            get { return m_mc; }
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_mc = value.Substring(0, strlen);
            }
        }

        // Property for co
        public string co
        {
            get { return m_co; }
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_co = value.Substring(0, strlen);
            }
        }

        // Property for health_center_dist
        public string health_center_dist
        {
            get { return m_health_center_dist; }
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_health_center_dist = value.Substring(0, strlen);
            }
        }

        // Property for health_area
        public string health_area
        {
            get { return m_health_area; }
            set
            {
                int strlen = value.Length;
                if (strlen > 4) strlen = 4;
                m_health_area = value.Substring(0, strlen);
            }
        }

        // Property for san_dist
        public string san_dist
        {
            get { return m_san_dist; }
            set
            {
                int strlen = value.Length;
                if (strlen > 3) strlen = 3;
                m_san_dist = value.Substring(0, strlen);
            }
        }

        // Property for san_sched
        public string san_sched
        {
            get { return m_san_sched; }
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_san_sched = value.Substring(0, strlen);
            }
        }

        // Property for san_reg
        public string san_reg
        {
            get { return m_san_reg; }
            set
            {
                int strlen = value.Length;
                if (strlen > 5) strlen = 5;
                m_san_reg = value.Substring(0, strlen);
            }
        }

        // Property for san_recycle
        public string san_recycle
        {
            get { return m_san_recycle; }
            set
            {
                int strlen = value.Length;
                if (strlen > 3) strlen = 3;
                m_san_recycle = value.Substring(0, strlen);
            }
        }

        // Property for police_boro_com
        public string police_boro_com
        {
            get { return m_police_boro_com; }
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_police_boro_com = value.Substring(0, strlen);
            }
        }

        // Property for police_pct
        public string police_pct
        {
            get { return m_police_pct; }
            set
            {
                int strlen = value.Length;
                if (strlen > 3) strlen = 3;
                m_police_pct = value.Substring(0, strlen);
            }
        }

        // Property for fire_div
        public string fire_div
        {
            get { return m_fire_div; }
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_fire_div = value.Substring(0, strlen);
            }
        }

        // Property for fire_bat
        public string fire_bat
        {
            get { return m_fire_bat; }
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_fire_bat = value.Substring(0, strlen);
            }
        }

        // Property for fire_co_type
        public string fire_co_type
        {
            get { return m_fire_co_type; }
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_fire_co_type = value.Substring(0, strlen);
            }
        }

        // Property for fire_co_num
        public string fire_co_num
        {
            get { return m_fire_co_num; }
            set
            {
                int strlen = value.Length;
                if (strlen > 3) strlen = 3;
                m_fire_co_num = value.Substring(0, strlen);
            }
        }

        // Property for split_school_dist_flag
        public string split_school_dist_flag
        {
            get { return m_split_school_dist_flag; }
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_split_school_dist_flag = value.Substring(0, strlen);
            }
        }

        // Property for school_dist
        public string school_dist
        {
            get { return m_school_dist; }
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_school_dist = value.Substring(0, strlen);
            }
        }

        // Property for dynamic_block
        public string dynamic_block
        {
            get { return m_dynamic_block; }
            set
            {
                int strlen = value.Length;
                if (strlen > 3) strlen = 3;
                m_dynamic_block = value.Substring(0, strlen);
            }
        }

        // Property for police_patrol_boro
        public string police_patrol_boro
        {
            get { return m_police_patrol_boro; }
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_police_patrol_boro = value.Substring(0, strlen);
            }
        }

        // Property for feature_type
        public string feature_type
        {
            get { return m_feature_type; }
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_feature_type = value.Substring(0, strlen);
            }
        }

        // Property for segment_type
        public string segment_type
        {
            get { return m_segment_type; }
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_segment_type = value.Substring(0, strlen);
            }
        }

        // Property for alx
        public string alx
        {
            get { return m_alx; }
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_alx = value.Substring(0, strlen);
            }
        }

        // Property for coincident_seg_cnt
        public string coincident_seg_cnt
        {
            get { return m_coincident_seg_cnt; }
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_coincident_seg_cnt = value.Substring(0, strlen);
            }
        }

        // Property for filler_80ct
        public string filler_80ct
        {
            get { return m_filler_80ct; }
            set
            {
                int strlen = value.Length;
                if (strlen > 3) strlen = 3;
                m_filler_80ct = value.Substring(0, strlen);
            }
        }

        // Property for census_tract_1990
        public string census_tract_1990
        {
            get { return m_census_tract_1990; }
            set
            {
                int strlen = value.Length;
                if (strlen > 6) strlen = 6;
                m_census_tract_1990 = value.Substring(0, strlen);
            }
        }

        // Property for census_tract_2010
        public string census_tract_2010
        {
            get { return m_census_tract_2010; }
            set
            {
                int strlen = value.Length;
                if (strlen > 6) strlen = 6;
                m_census_tract_2010 = value.Substring(0, strlen);
            }
        }

        // Property for census_block_2010
        public string census_block_2010
        {
            get { return m_census_block_2010; }
            set
            {
                int strlen = value.Length;
                if (strlen > 4) strlen = 4;
                m_census_block_2010 = value.Substring(0, strlen);
            }
        }

        // Property for census_block_suffix_2010
        public string census_block_suffix_2010
        {
            get { return m_census_block_suffix_2010; }
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_census_block_suffix_2010 = value.Substring(0, strlen);
            }
        }

        // Property for census_tract_2000
        public string census_tract_2000
        {
            get { return m_census_tract_2000; }
            set
            {
                int strlen = value.Length;
                if (strlen > 6) strlen = 6;
                m_census_tract_2000 = value.Substring(0, strlen);
            }
        }

        // Property for census_block_2000
        public string census_block_2000
        {
            get { return m_census_block_2000; }
            set
            {
                int strlen = value.Length;
                if (strlen > 4) strlen = 4;
                m_census_block_2000 = value.Substring(0, strlen);
            }
        }

        // Property for census_block_suffix_2000
        public string census_block_suffix_2000
        {
            get { return m_census_block_suffix_2000; }
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_census_block_suffix_2000 = value.Substring(0, strlen);
            }
        }

        // Property for nta
        public string nta
        {
            get { return m_nta; }
            set
            {
                int strlen = value.Length;
                if (strlen > 4) strlen = 4;
                m_nta = value.Substring(0, strlen);
            }
        }

        // Property for dsny_snow_priority
        public string dsny_snow_priority
        {
            get { return m_dsny_snow_priority; }
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_dsny_snow_priority = value.Substring(0, strlen);
            }
        }

        // Property for san_org_pick_up
        public string san_org_pick_up
        {
            get { return m_san_org_pick_up; }
            set
            {
                int strlen = value.Length;
                if (strlen > 5) strlen = 5;
                m_san_org_pick_up = value.Substring(0, strlen);
            }
        }

        // Property for san_bulk
        public string san_bulk
        {
            get { return m_san_bulk; }
            set
            {
                int strlen = value.Length;
                if (strlen > 5) strlen = 5;
                m_san_bulk = value.Substring(0, strlen);
            }
        }

        // Property for hurricane_zone
        public string hurricane_zone
        {
            get { return m_hurricane_zone; }
            set
            {
                int strlen = value.Length;
                if (strlen > 2) strlen = 2;
                m_hurricane_zone = value.Substring(0, strlen);
            }
        }

        // Property for filler3
        public string filler3
        {
            get { return m_filler3; }
            set
            {
                int strlen = value.Length;
                if (strlen > 11) strlen = 11;
                m_filler3 = value.Substring(0, strlen);
            }
        }

        // Property for true_hns
        public string true_hns
        {
            get { return m_true_hns; }
            set
            {
                int strlen = value.Length;
                if (strlen > 11) strlen = 11;
                m_true_hns = value.Substring(0, strlen);
            }
        }

        // Property for real_b7sc
        public B7sc real_b7sc
        {
            get { return m_real_b7sc; }
            set { m_real_b7sc = value; }
        }

        // Property for segment_id
        public string segment_id
        {
            get { return m_segment_id; }
            set
            {
                int strlen = value.Length;
                if (strlen > 7) strlen = 7;
                m_segment_id = value.Substring(0, strlen);
            }
        }

        // Property for curve_flag
        public string curve_flag
        {
            get { return m_curve_flag; }
            set
            {
                int strlen = value.Length;
                if (strlen > 1) strlen = 1;
                m_curve_flag = value.Substring(0, strlen);
            }
        }

    }
}