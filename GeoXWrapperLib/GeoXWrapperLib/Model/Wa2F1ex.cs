using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperLib.Model
{
    public class Wa2F1ex : WA
    {
        // -------------------------------------------------------
        //--Start of 1E data
        // -------------------------------------------------------
        // Private m_wa2f1e As wa2f1e;

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

        // -------------------------------------------------------
        //--Start of 1V data
        // -------------------------------------------------------
        private string[] m_valid_lgcs = new string[4];
        private string m_boe_lgc_pointer;
        private string m_segment_azm;
        private string m_segment_orient;
        private string m_lo_x_coord;
        private string m_lo_y_coord;
        private string m_lo_z_coord;
        private string m_hi_x_coord;
        private string m_hi_y_coord;
        private string m_hi_z_coord;
        private string m_curve_center_x_coord;
        private string m_curve_center_y_coord;
        private string m_curve_center_z_coord;
        private string m_circle_radius;
        private string m_secant_location;
        private string m_beta_angle;
        private string m_alpha_angle;
        private string m_from_node;
        private string m_to_node;
        private LionKey m_vanity_lion_key;
        private string m_vanity_sos;
        private string m_split_lo_hns;
        private string m_traffic_dir;
        private string m_turn_restrictions;
        private string m_gbicurv_fraction;
        private string m_roadway_type;
        private string m_physical_id;
        private string m_generic_id;
        private string m_nypd_id;
        private string m_fdny_id;
        private string m_bike_lane2;
        private string m_bike_traffic_direction;
        private string m_filler03;
        private string m_street_status;
        private string m_street_width;
        private string m_street_width_irregular;
        private string m_bike_lane;
        private string m_federal_classification_code;
        private string m_right_of_way_type;
        private string[] m_additional_valid_lgcs = new string[5];

        // -------------------------------------------------------
        //--Start of 1Ex data
        // -------------------------------------------------------
        private string m_legacy_segment_id;
        private string[] m_from_dcp_preferred_lgcs = new string[5];
        private string[] m_to_dcp_preferred_lgcs = new string[5];
        private string[] m_from_additional_lgcs = new string[5];
        private string[] m_to_additional_lgcs = new string[5];
        private string m_no_cross_street_calculation_flag;
        private string m_individual_segment_length;
        private string m_nta_name;
        private string m_USPS_city_name;
        private string m_latitude;
        private string m_longitude;
        private string m_seg_from_node;
        private string m_seg_to_node;
        private string m_seg_from_x_coord;
        private string m_seg_from_y_coord;
        private string m_seg_from_z_coord;
        private string m_seg_to_x_coord;
        private string m_seg_to_y_coord;
        private string m_seg_to_z_coord;
        private string m_blockface_id;
        private string m_No_Traveling_lanes;
        private string m_No_Parking_lanes;
        private string m_Total_Lanes;
        private string m_st_width_max;
        private string m_speed_limit;
        private string m_puma_code;
        private string m_police_sector;
        private string m_police_area;
        private string m_truck_route_type;
        private string m_census_tract_2020;
        private string m_census_block_2020;
        private string m_census_block_suffix_2020;
        private string m_nta_2020;
        private string m_cdta_2020;
        private string m_puma_2020;
        private string m_filler01;
        private string m_reason_code;
        private string m_reason_code_qualifier;
        private string m_warning_code;
        private string m_grc;
        private string m_lo_x_sts_cnt2;
        private B7sc[] m_lo_x_b7sc_list = new B7sc[5];
        private string m_hi_x_sts_cnt2;
        private B7sc[] m_hi_x_b7sc_list = new B7sc[5];
        private string[] m_lo_x_stname_list = new string[5];
        private string[] m_hi_x_stname_list = new string[5];
        private B7sc m_boe_preferred_b7sc;
        private string m_boe_preferred_stname;
        private string m_filler02;

        public Wa2F1ex()
        {
            // Start of 1E data
            m_gridkey1 = new VsamKey1();
            m_cont_parity_ind = new string(' ', 1);
            m_lo_hns = new string(' ', 11);
            m_hi_hns = new string(' ', 11);
            m_dcp_pref_lgc = new string(' ', 2);
            m_lo_x_sts_cnt = new string(' ', 1);
            for (int i = 0; i <= 4; i++)
            {
                try { m_lo_x_sts[i] = new B5sc(); } catch (Exception e) { continue; }
            }
            m_hi_x_sts_cnt = new string(' ', 1);
            for (int i = 0; i <= 4; i++)
            {
                try { m_hi_x_sts[i] = new B5sc(); } catch (Exception e) { continue; }            
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

            // Start of 1V data
            for (int i = 0; i <= 3; i++)
            {
                m_valid_lgcs[i] = new string(' ', 2);
            }
            m_boe_lgc_pointer = new string(' ', 1);
            m_segment_azm = new string(' ', 3);
            m_segment_orient = new string(' ', 1);
            m_lo_x_coord = new string(' ', 7);
            m_lo_y_coord = new string(' ', 7);
            m_lo_z_coord = new string(' ', 7);
            m_hi_x_coord = new string(' ', 7);
            m_hi_y_coord = new string(' ', 7);
            m_hi_z_coord = new string(' ', 7);
            m_curve_center_x_coord = new string(' ', 7);
            m_curve_center_y_coord = new string(' ', 7);
            m_curve_center_z_coord = new string(' ', 7);
            m_circle_radius = new string(' ', 7);
            m_secant_location = new string(' ', 1);
            m_beta_angle = new string(' ', 5);
            m_alpha_angle = new string(' ', 5);
            m_from_node = new string(' ', 7);
            m_to_node = new string(' ', 7);
            m_vanity_lion_key = new LionKey();
            m_vanity_sos = new string(' ', 1);
            m_split_lo_hns = new string(' ', 11);
            m_traffic_dir = new string(' ', 1);
            m_turn_restrictions = new string(' ', 10);
            m_gbicurv_fraction = new string(' ', 3);
            m_roadway_type = new string(' ', 2);
            m_physical_id = new string(' ', 7);
            m_generic_id = new string(' ', 7);
            m_nypd_id = new string(' ', 7);
            m_fdny_id = new string(' ', 7);
            m_bike_lane2 = new string(' ', 2);
            m_bike_traffic_direction = new string(' ', 2);
            m_filler03 = new string(' ', 3);
            m_street_status = new string(' ', 1);
            m_street_width = new string(' ', 3);
            m_street_width_irregular = new string(' ', 1);
            m_bike_lane = new string(' ', 2);
            m_federal_classification_code = new string(' ', 2);
            m_right_of_way_type = new string(' ', 1);
            for (int i = 0; i <= 4; i++)
            {
                m_additional_valid_lgcs[i] = new string(' ', 2);
            }

            // Start of 1Ex data
            m_legacy_segment_id = new string(' ', 7);
            for (int i = 0; i <= 4; i++)
            {
                m_from_dcp_preferred_lgcs[i] = new string(' ', 2);
            }
            for (int i = 0; i <= 4; i++)
            {
                m_to_dcp_preferred_lgcs[i] = new string(' ', 2);
            }
            for (int i = 0; i <= 4; i++)
            {
                m_from_additional_lgcs[i] = new string(' ', 2);
            }
            for (int i = 0; i <= 4; i++)
            {
                m_to_additional_lgcs[i] = new string(' ', 2);
            }
            m_no_cross_street_calculation_flag = new string(' ', 1);
            m_individual_segment_length = new string(' ', 5);
            m_nta_name = new string(' ', 75);
            m_USPS_city_name = new string(' ', 25);
            m_latitude = new string(' ', 9);
            m_longitude = new string(' ', 11);
            m_seg_from_node = new string(' ', 7);
            m_seg_to_node = new string(' ', 7);
            m_seg_from_x_coord = new string(' ', 7);
            m_seg_from_y_coord = new string(' ', 7);
            m_seg_from_z_coord = new string(' ', 7);
            m_seg_to_x_coord = new string(' ', 7);
            m_seg_to_y_coord = new string(' ', 7);
            m_seg_to_z_coord = new string(' ', 7);
            m_blockface_id = new string(' ', 10);
            m_No_Traveling_lanes = new string(' ', 2);
            m_No_Parking_lanes = new string(' ', 2);
            m_Total_Lanes = new string(' ', 2);
            m_st_width_max = new string(' ', 3);
            m_speed_limit = new string(' ', 2);
            m_puma_code = new string(' ', 5);
            m_police_sector = new string(' ', 4);
            m_police_area = new string(' ', 1);

            //--------------------------------------------------------------------------
            //// SPO(2019-07-18): Added new Truck_Route_Type field
            //--------------------------------------------------------------------------
            m_truck_route_type = new string(' ', 1);

            //m_filler01 = new string(' ', 255);
            //m_filler01 = new string(' ', 252);
            //m_filler01 = new string(' ', 250);
            //m_filler01 = new string(' ', 255);
            //m_filler01 = new string(' ', 241);
            //m_filler01 = new string(' ', 240);
            //------------------------------------------------------------------
            // SPO(2021-03-10): Add 21 bytes for new census 2020 fields 
            //------------------------------------------------------------------
            // m_census_tract_2020          6 bytes 
            // m_census_block_2020          4 bytes 
            // m_census_block_suffix_2020   1 byte 
            // m_nta_2020                   6 bytes (2 byte boro + 4 byte number)
            // m_cdta_2020                  4 bytes (2 byte boro + 2 byte number) 
            //------------------------------------------------------------------
            m_census_tract_2020 = new string(' ', 6);
            m_census_block_2020 = new string(' ', 4);
            m_census_block_suffix_2020 = new string(' ', 1);
            m_nta_2020 = new string(' ', 6);
            m_cdta_2020 = new string(' ', 4);
            //--------------------------------------------------------------------------
            //// SPO(2023-02-09): Added PUMA 2020 field 
            //--------------------------------------------------------------------------
            m_puma_2020 = new string(' ', 5);

            //m_filler01 = new string(' ', 239);
            //m_filler01 = new string(' ', 218);
            m_filler01 = new string(' ', 213);

            m_reason_code = new string(' ', 1);
            m_reason_code_qualifier = new string(' ', 1);
            m_warning_code = new string(' ', 2);
            m_grc = new string(' ', 2);
            m_lo_x_sts_cnt2 = new string(' ', 1);

            // Arrays are zero-based, so there are 5 entries below
            for (int i = 0; i < 5; i++)
            {
                m_lo_x_b7sc_list[i] = new B7sc();
            }

            m_hi_x_sts_cnt2 = new string(' ', 1);
            for (int i = 0; i < 5; i++)
            {
                m_hi_x_b7sc_list[i] = new B7sc();
            }

            for (int i = 0; i < 5; i++)
            {
                m_lo_x_stname_list[i] = new string(' ', 32);
            }

            for (int i = 0; i < 5; i++)
            {
                m_hi_x_stname_list[i] = new string(' ', 32);
            }

            m_boe_preferred_b7sc = new B7sc();
            m_boe_preferred_stname = new string(' ', 32);
            m_filler02 = new string(' ', 52);

        }

        public Wa2F1ex(string inString)
        {
            this.Wa2F1exFromString(inString);
        }

        // Clear method
        public override void Clear()
        {
            this.Wa2F1exFromString(new string(' ', 1500));
        }

        // ToString method
        public override string ToString()
        {
            return this.Wa2F1exToString();
        }

        // FromString method
        public override void FromString(string inString)
        {
            this.Wa2F1exFromString(inString);
        }

        // Wa2F1exToString method
        public string Wa2F1exToString()
        {
            StringBuilder sb = new StringBuilder();
            int i;

            // Start of 1V data
            sb.Append(m_gridkey1.VsamKey1ToString());
            sb.Append(m_cont_parity_ind);
            sb.Append(m_lo_hns);
            sb.Append(m_hi_hns);
            sb.Append(m_dcp_pref_lgc);
            sb.Append(m_lo_x_sts_cnt);

            for (i = 0; i <= 4; i++)
            {
                try { sb.Append(m_lo_x_sts[i].B5scToString()); } catch (Exception e) { continue; }  
            }

            sb.Append(m_hi_x_sts_cnt);

            for (i = 0; i <= 4; i++)
            {
                try { sb.Append(m_hi_x_sts[i].B5scToString()); } catch (Exception e) { continue; }
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

            // Added police patrol borough (2014-11-10)
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
            sb.Append(m_san_commercial_waste_zone);
            sb.Append(m_filler3);
            sb.Append(m_true_hns);
            sb.Append(m_real_b7sc.B7scToString());
            sb.Append(m_segment_id);
            sb.Append(m_curve_flag);

            // Start of 1V data continuation
            for (i = 0; i < 4; i++)
            {
                sb.Append(m_valid_lgcs[i]);
            }

            sb.Append(m_boe_lgc_pointer);
            sb.Append(m_segment_azm);
            sb.Append(m_segment_orient);
            sb.Append(m_lo_x_coord);
            sb.Append(m_lo_y_coord);
            sb.Append(m_lo_z_coord);
            sb.Append(m_hi_x_coord);
            sb.Append(m_hi_y_coord);
            sb.Append(m_hi_z_coord);
            sb.Append(m_curve_center_x_coord);
            sb.Append(m_curve_center_y_coord);
            sb.Append(m_curve_center_z_coord);
            sb.Append(m_circle_radius);
            sb.Append(m_secant_location);
            sb.Append(m_beta_angle);
            sb.Append(m_alpha_angle);
            sb.Append(m_from_node);
            sb.Append(m_to_node);
            sb.Append(m_vanity_lion_key.LionKeyToString());
            sb.Append(m_vanity_sos);
            sb.Append(m_split_lo_hns);
            sb.Append(m_traffic_dir);
            sb.Append(m_turn_restrictions);
            sb.Append(m_gbicurv_fraction);
            sb.Append(m_roadway_type);
            sb.Append(m_physical_id);
            sb.Append(m_generic_id);
            sb.Append(m_nypd_id);
            sb.Append(m_fdny_id);
            sb.Append(m_bike_lane2);
            sb.Append(m_bike_traffic_direction);
            sb.Append(m_filler03);
            sb.Append(m_street_status);
            sb.Append(m_street_width);
            sb.Append(m_street_width_irregular);
            sb.Append(m_bike_lane);
            sb.Append(m_federal_classification_code);
            sb.Append(m_right_of_way_type);

            // Arrays (zero-based) with 5 entries
            for (i = 0; i <= 4; i++)
            {
                sb.Append(m_additional_valid_lgcs[i]);
            }

            // Start of 1Ex data
            sb.Append(m_legacy_segment_id);

            for (i = 0; i <= 4; i++)
            {
                sb.Append(m_from_dcp_preferred_lgcs[i]);
            }

            for (i = 0; i <= 4; i++)
            {
                sb.Append(m_to_dcp_preferred_lgcs[i]);
            }

            for (i = 0; i <= 4; i++)
            {
                sb.Append(m_from_additional_lgcs[i]);
            }

            for (i = 0; i <= 4; i++)
            {
                sb.Append(m_to_additional_lgcs[i]);
            }

            sb.Append(m_no_cross_street_calculation_flag);
            sb.Append(m_individual_segment_length);
            sb.Append(m_nta_name);
            sb.Append(m_USPS_city_name);
            sb.Append(m_latitude);
            sb.Append(m_longitude);
            sb.Append(m_seg_from_node);
            sb.Append(m_seg_to_node);
            sb.Append(m_seg_from_x_coord);
            sb.Append(m_seg_from_y_coord);
            sb.Append(m_seg_from_z_coord);
            sb.Append(m_seg_to_x_coord);
            sb.Append(m_seg_to_y_coord);
            sb.Append(m_seg_to_z_coord);
            sb.Append(m_blockface_id);
            sb.Append(m_No_Traveling_lanes);
            sb.Append(m_No_Parking_lanes);
            sb.Append(m_Total_Lanes);
            sb.Append(m_st_width_max);

            // Added speed_limit (Release 17D)
            sb.Append(m_speed_limit);

            // Added puma_code (Geosupport version 18.1)
            sb.Append(m_puma_code);

            // Added police sector and area (Geosupport version 18.1)
            sb.Append(m_police_sector);
            sb.Append(m_police_area);

            // Added Truck_Route_Type
            sb.Append(m_truck_route_type);

            // Added Census 2020 fields
            sb.Append(m_census_tract_2020);
            sb.Append(m_census_block_2020);
            sb.Append(m_census_block_suffix_2020);
            sb.Append(m_nta_2020);
            sb.Append(m_cdta_2020);

            // Added PUMA 2020 field
            sb.Append(m_puma_2020);

            sb.Append(m_filler01);
            sb.Append(m_reason_code);
            sb.Append(m_reason_code_qualifier);
            sb.Append(m_warning_code);
            sb.Append(m_grc);
            sb.Append(m_lo_x_sts_cnt2);

            // Arrays (zero-based) with 5 entries for lo_x_b7sc_list and hi_x_b7sc_list
            for (i = 0; i <= 4; i++)
            {
                sb.Append(m_lo_x_b7sc_list[i].B7scToString());
            }

            sb.Append(m_hi_x_sts_cnt2);

            for (i = 0; i <= 4; i++)
            {
                sb.Append(m_hi_x_b7sc_list[i].B7scToString());
            }

            for (i = 0; i <= 4; i++)
            {
                sb.Append(m_lo_x_stname_list[i]);
            }

            for (i = 0; i <= 4; i++)
            {
                sb.Append(m_hi_x_stname_list[i]);
            }

            sb.Append(m_boe_preferred_b7sc.B7scToString());
            sb.Append(m_boe_preferred_stname);
            sb.Append(m_filler02);

            return sb.ToString();
        }
        public void Wa2F1exFromString(string inString)
        {
            int i;

            // -------------------------------------------------------
            // -- Start of 1E data
            // -------------------------------------------------------
            m_gridkey1 = new VsamKey1(inString.Substring(0, 21));
            m_cont_parity_ind = inString.Substring(21, 1);
            m_lo_hns = inString.Substring(22, 11);
            m_hi_hns = inString.Substring(33, 11);
            m_dcp_pref_lgc = inString.Substring(44, 2);
            m_lo_x_sts_cnt = inString.Substring(46, 1);

            for (i = 0; i <= 4; i++)
            {
                try { m_lo_x_sts[i] = new B5sc(inString.Substring(47 + (i * 6), 6)); } 
                catch (Exception e) {  m_lo_x_sts[i] = new B5sc(); }
            }

            m_hi_x_sts_cnt = inString.Substring(77, 1);

            for (i = 0; i <= 4; i++)
            {
                try { m_lo_x_sts[i] = new B5sc(inString.Substring(47 + (i * 6), 6)); } 
                catch (Exception e) { m_lo_x_sts[i] = new B5sc();  }
            }

            for (i = 0; i <= 4; i++)
            {
                try { m_hi_x_sts[i] = new B5sc(inString.Substring(78 + (i * 6), 6)); }
                catch (Exception e) { m_hi_x_sts[i] = new B5sc(); }
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
            m_police_patrol_boro = inString.Substring(208, 2);
            m_feature_type = inString.Substring(210, 1);
            m_segment_type = inString.Substring(211, 1);
            m_alx = inString.Substring(212, 1);
            m_coincident_seg_cnt = inString.Substring(213, 1);
            m_filler_80ct = inString.Substring(214, 3);
            m_census_tract_1990 = inString.Substring(217, 6);
            m_census_tract_2010 = inString.Substring(223, 6);
            m_census_block_2010 = inString.Substring(229, 4);
            m_census_block_suffix_2010 = inString.Substring(233, 1);
            m_census_tract_2000 = inString.Substring(234, 6);
            m_census_block_2000 = inString.Substring(240, 4);
            m_census_block_suffix_2000 = inString.Substring(244, 1);
            m_nta = inString.Substring(245, 4);
            m_dsny_snow_priority = inString.Substring(249, 1);
            m_san_org_pick_up = inString.Substring(250, 5);
            m_san_bulk = inString.Substring(255, 5);
            m_hurricane_zone = inString.Substring(260, 2);
            m_san_commercial_waste_zone = inString.Substring(262, 4);
            m_filler3 = inString.Substring(266, 7);
            m_true_hns = inString.Substring(273, 11);
            m_real_b7sc = new B7sc(inString.Substring(284, 8));
            m_segment_id = inString.Substring(292, 7);
            m_curve_flag = inString.Substring(299, 1);

            // -------------------------------------------------------
            // -- Start of 1V data
            // -------------------------------------------------------
            for (i = 0; i <= 3; i++)
            {
                try { m_valid_lgcs[i] = inString.Substring(300 + (i * 2), 2); } catch{ m_valid_lgcs[i] = string.Empty; }
            }

            m_boe_lgc_pointer = inString.Substring(308, 1);
            m_segment_azm = inString.Substring(309, 3);
            m_segment_orient = inString.Substring(312, 1);
            m_lo_x_coord = inString.Substring(313, 7);
            m_lo_y_coord = inString.Substring(320, 7);
            m_lo_z_coord = inString.Substring(327, 7);
            m_hi_x_coord = inString.Substring(334, 7);
            m_hi_y_coord = inString.Substring(341, 7);
            m_hi_z_coord = inString.Substring(348, 7);
            m_curve_center_x_coord = inString.Substring(355, 7);
            m_curve_center_y_coord = inString.Substring(362, 7);
            m_curve_center_z_coord = inString.Substring(369, 7);
            m_circle_radius = inString.Substring(376, 7);
            m_secant_location = inString.Substring(383, 1);
            m_beta_angle = inString.Substring(384, 5);
            m_alpha_angle = inString.Substring(389, 5);
            m_from_node = inString.Substring(394, 7);
            m_to_node = inString.Substring(401, 7);
            m_vanity_lion_key = new LionKey(inString.Substring(408, 10));
            m_vanity_sos = inString.Substring(418, 1);
            m_split_lo_hns = inString.Substring(419, 11);
            m_traffic_dir = inString.Substring(430, 1);
            m_turn_restrictions = inString.Substring(431, 10);
            m_gbicurv_fraction = inString.Substring(441, 3);
            m_roadway_type = inString.Substring(444, 2);
            m_physical_id = inString.Substring(446, 7);
            m_generic_id = inString.Substring(453, 7);
            m_nypd_id = inString.Substring(460, 7);
            m_fdny_id = inString.Substring(467, 7);
            m_bike_lane2 = inString.Substring(474, 2);
            m_bike_traffic_direction = inString.Substring(476, 2);
            m_filler03 = inString.Substring(478, 3);

            m_street_status = inString.Substring(481, 1);
            m_street_width = inString.Substring(482, 3);
            m_street_width_irregular = inString.Substring(485, 1);
            m_bike_lane = inString.Substring(486, 1);
            m_federal_classification_code = inString.Substring(487, 2);
            m_right_of_way_type = inString.Substring(489, 1);

            for (i = 0; i <= 4; i++)
            {
                try { m_additional_valid_lgcs[i] = inString.Substring(490 + (i * 2), 2); } 
                catch{  m_additional_valid_lgcs[i] = string.Empty; }
                
            }

            // -------------------------------------------------------
            // -- Start of 1Ex data
            // -------------------------------------------------------
            m_legacy_segment_id = inString.Substring(500, 7);

            for (i = 0; i <= 4; i++)
            {
                try { m_from_dcp_preferred_lgcs[i] = inString.Substring(507 + (i * 2), 2); }
                catch { m_from_dcp_preferred_lgcs[i] = string.Empty; }
            }

            for (i = 0; i <= 4; i++)
            {
                try { m_to_dcp_preferred_lgcs[i] = inString.Substring(517 + (i * 2), 2); } catch { m_to_dcp_preferred_lgcs[i] = string.Empty; }
            }

            for (i = 0; i <= 4; i++)
            {
                try { m_from_additional_lgcs[i] = inString.Substring(527 + (i * 2), 2); } catch { m_from_additional_lgcs[i] = string.Empty; }
            }

            for (i = 0; i <= 4; i++)
            {
                try { m_to_additional_lgcs[i] = inString.Substring(537 + (i * 2), 2); } catch { m_to_additional_lgcs[i] = string.Empty; }
            }

            m_no_cross_street_calculation_flag = inString.Substring(547, 1);
            m_individual_segment_length = inString.Substring(548, 5);

            // Geosupport Version 11.3 / Release 12A
            m_nta_name = inString.Substring(553, 75);

            // Geosupport Version 14.1 / Release 14A
            m_USPS_city_name = inString.Substring(628, 25);
            m_latitude = inString.Substring(653, 9);
            m_longitude = inString.Substring(662, 11);

            // Geosupport Version 15.3/Release 15C
            m_seg_from_node = inString.Substring(673, 7);
            m_seg_to_node = inString.Substring(680, 7);
            m_seg_from_x_coord = inString.Substring(687, 7);
            m_seg_from_y_coord = inString.Substring(694, 7);
            m_seg_from_z_coord = inString.Substring(701, 7);
            m_seg_to_x_coord = inString.Substring(708, 7);
            m_seg_to_y_coord = inString.Substring(715, 7);
            m_seg_to_z_coord = inString.Substring(722, 7);

            // Geosupport Version 16.1 changes
            m_blockface_id = inString.Substring(729, 10);
            m_No_Traveling_lanes = inString.Substring(739, 2);
            m_No_Parking_lanes = inString.Substring(741, 2);
            m_Total_Lanes = inString.Substring(743, 2);
            m_st_width_max = inString.Substring(745, 3);

            // Geosupport Version 17D
            m_speed_limit = inString.Substring(748, 2);

            // Geosupport Version 18.1
            m_puma_code = inString.Substring(750, 5);

            // Police sector and area for 2018 update
            m_police_sector = inString.Substring(755, 4);
            m_police_area = inString.Substring(759, 1);

            // Truck Route Type field
            m_truck_route_type = inString.Substring(760, 1);

            // Census 2020 fields
            m_census_tract_2020 = inString.Substring(761, 6);
            m_census_block_2020 = inString.Substring(767, 4);
            m_census_block_suffix_2020 = inString.Substring(771, 1);
            m_nta_2020 = inString.Substring(772, 6);
            m_cdta_2020 = inString.Substring(778, 4);

            // PUMA 2020 field
            m_puma_2020 = inString.Substring(782, 5);

            // Filler 01
            m_filler01 = inString.Substring(787, 213);

            // Reason codes
            m_reason_code = inString.Substring(1000, 1);
            m_reason_code_qualifier = inString.Substring(1001, 1);
            m_warning_code = inString.Substring(1002, 2);
            m_grc = inString.Substring(1004, 2);
            m_lo_x_sts_cnt2 = inString.Substring(1006, 1);

            // B7sc list (assuming B7sc class has a constructor accepting a string)
            for (i = 0; i <= 4; i++)
            {
                try { m_lo_x_b7sc_list[i] = new B7sc(inString.Substring(1007 + (i * 8), 8)); } catch { m_lo_x_b7sc_list[i] = new B7sc(); }
             }

            m_hi_x_sts_cnt2 = inString.Substring(1047, 1);

            // High B7sc list
            for (i = 0; i <= 4; i++)
            {
                try { m_hi_x_b7sc_list[i] = new B7sc(inString.Substring(1048 + (i * 8), 8)); } catch { m_hi_x_b7sc_list[i] = new B7sc(); }
            }

            // Street name lists
            for (i = 0; i <= 4; i++)
            {
                try { m_lo_x_stname_list[i] = inString.Substring(1088 + (i * 32), 32); } catch { m_lo_x_stname_list[i] = string.Empty; }               
            }

            for (i = 0; i <= 4; i++)
            {
                try { m_hi_x_stname_list[i] = inString.Substring(1248 + (i * 32), 32); } catch{ m_hi_x_stname_list[i] = string.Empty; }
            }

            // BOE Preferred B7sc and Stname
            m_boe_preferred_b7sc = new B7sc(inString.Substring(1408, 8));
            m_boe_preferred_stname = inString.Substring(1416, 32);

            // Filler 02
            m_filler02 = inString.Substring(1448, 52);

        }

        public override string Display(char c)
        {
            StringBuilder sb = new StringBuilder();

            // Start of 1E data
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

            // Added police patrol borough
            sb.Append(m_police_patrol_boro);
            sb.Append(c);
            sb.Append(m_feature_type);
            sb.Append(c);
            sb.Append(m_segment_type);
            sb.Append(c);
            sb.Append(m_alx);
            sb.Append(c);
            sb.Append(m_coincident_seg_cnt);
            sb.Append(c);
            sb.Append(m_filler_80ct);
            sb.Append(c);
            sb.Append(m_census_tract_1990);

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

            // Geosupport Version 11.3 / Release 12A 
            sb.Append(m_nta);
            sb.Append(c);
            sb.Append(m_dsny_snow_priority);
            sb.Append(c);
            sb.Append(m_san_org_pick_up);
            sb.Append(c);
            sb.Append(m_san_bulk);
            sb.Append(c);
            sb.Append(m_hurricane_zone);
            sb.Append(c);

            // DSNY Commercial Waste Zone for 22C
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

            // Start of 1V data
            for (int i = 0; i <= 3; i++)
            {
                sb.Append(m_valid_lgcs[i]);
                sb.Append(c);
            }

            sb.Append(m_boe_lgc_pointer);
            sb.Append(c);
            sb.Append(m_segment_azm);
            sb.Append(c);
            sb.Append(m_segment_orient);
            sb.Append(c);
            sb.Append(m_lo_x_coord);
            sb.Append(c);
            sb.Append(m_lo_y_coord);
            sb.Append(c);
            sb.Append(m_lo_z_coord);
            sb.Append(c);
            sb.Append(m_hi_x_coord);
            sb.Append(c);
            sb.Append(m_hi_y_coord);
            sb.Append(c);
            sb.Append(m_hi_z_coord);
            sb.Append(c);
            sb.Append(m_curve_center_x_coord);
            sb.Append(c);
            sb.Append(m_curve_center_y_coord);
            sb.Append(c);
            sb.Append(m_curve_center_z_coord);
            sb.Append(c);
            sb.Append(m_circle_radius);
            sb.Append(c);
            sb.Append(m_secant_location);
            sb.Append(c);
            sb.Append(m_beta_angle);
            sb.Append(c);
            sb.Append(m_alpha_angle);
            sb.Append(c);
            sb.Append(m_from_node);
            sb.Append(c);
            sb.Append(m_to_node);
            sb.Append(c);
            sb.Append(m_vanity_lion_key.Display());
            sb.Append(c);
            sb.Append(m_vanity_sos);
            sb.Append(c);
            sb.Append(m_split_lo_hns);
            sb.Append(c);
            sb.Append(m_traffic_dir);
            sb.Append(c);
            sb.Append(m_turn_restrictions);
            sb.Append(c);
            sb.Append(m_gbicurv_fraction);
            sb.Append(c);

            sb.Append(m_roadway_type);
            sb.Append(c);
            sb.Append(m_physical_id);
            sb.Append(c);
            sb.Append(m_generic_id);
            sb.Append(c);
            sb.Append(m_nypd_id);
            sb.Append(c);
            sb.Append(m_fdny_id);
            sb.Append(c);

            // Version 16.4 changes
            sb.Append(m_bike_lane2);
            sb.Append(c);
            sb.Append(m_bike_traffic_direction);
            sb.Append(c);
            sb.Append(m_filler03);
            sb.Append(c);
            sb.Append(m_street_status);
            sb.Append(c);
            sb.Append(m_street_width);
            sb.Append(c);
            sb.Append(m_street_width_irregular);
            sb.Append(c);
            sb.Append(m_bike_lane);
            sb.Append(c);
            sb.Append(m_federal_classification_code);
            sb.Append(c);
            sb.Append(m_right_of_way_type);
            sb.Append(c);

            for (int i = 0; i <= 4; i++)
            {
                sb.Append(m_additional_valid_lgcs[i]);
                sb.Append(c);
            }

            // Start of 1Ex data
            sb.Append(m_legacy_segment_id);
            sb.Append(c);

            for (int i = 0; i <= 4; i++)
            {
                sb.Append(m_from_dcp_preferred_lgcs[i]);
                sb.Append(c);
            }

            for (int i = 0; i <= 4; i++)
            {
                sb.Append(m_to_dcp_preferred_lgcs[i]);
                sb.Append(c);
            }

            for (int i = 0; i <= 4; i++)
            {
                sb.Append(m_from_additional_lgcs[i]);
                sb.Append(c);
            }

            for (int i = 0; i <= 4; i++)
            {
                sb.Append(m_to_additional_lgcs[i]);
                sb.Append(c);
            }

            sb.Append(m_no_cross_street_calculation_flag);
            sb.Append(c);
            sb.Append(m_individual_segment_length);
            sb.Append(c);

            sb.Append(m_nta_name);
            sb.Append(c);
            sb.Append(m_USPS_city_name);
            sb.Append(c);
            sb.Append(m_latitude);
            sb.Append(c);
            sb.Append(m_longitude);
            sb.Append(c);

            // Geosupport Version 15.3/Release 15C - Start
            sb.Append(m_seg_from_node);
            sb.Append(c);
            sb.Append(m_seg_to_node);
            sb.Append(c);
            sb.Append(m_seg_from_x_coord);
            sb.Append(c);
            sb.Append(m_seg_from_y_coord);
            sb.Append(c);
            sb.Append(m_seg_from_z_coord);
            sb.Append(c);
            sb.Append(m_seg_to_x_coord);
            sb.Append(c);
            sb.Append(m_seg_to_y_coord);
            sb.Append(c);
            sb.Append(m_seg_to_z_coord);
            sb.Append(c);
            // njp(2015-06-19): added for Geosupport Version 15.3/Release 15C - End
            sb.Append(m_blockface_id);
            sb.Append(c);
            sb.Append(m_No_Traveling_lanes);
            sb.Append(c);
            sb.Append(m_No_Parking_lanes);
            sb.Append(c);
            sb.Append(m_Total_Lanes);
            sb.Append(c);
            // jgt(2016-09-27) 16.4 changes.
            sb.Append(m_st_width_max);
            sb.Append(c);
            //------------------------------------------------------------------------
            // SPO(2017-09-29): Added new speed_limit 2 byte field for Release 17D
            //                 Requires that I reduce m_filler01 by 2 bytes
            //------------------------------------------------------------------------
            sb.Append(m_speed_limit);
            sb.Append(c);

            // SPO(2018-01-02): Added new 5 byte puma_code for Geosupport version 18.1 
            sb.Append(m_puma_code);
            sb.Append(c);

            // JGT(2018-07-16): Added 4 byte police sector and 1 byte police area 
            sb.Append(m_police_sector);
            sb.Append(c);
            sb.Append(m_police_area);
            sb.Append(c);

            //--------------------------------------------------------------------------
            // SPO(2019-07-18): Added new Truck_Route_Type field 
            //--------------------------------------------------------------------------
            sb.Append(m_truck_route_type);
            sb.Append(c);

            //--------------------------------------------------------------------------
            // SPO(2021-05-04): Added Census 2020 fields 
            //--------------------------------------------------------------------------
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
            //--------------------------------------------------------------------------
            // SPO(2023-02-09): Added PUMA 2020 field 
            //--------------------------------------------------------------------------
            sb.Append(m_puma_2020);
            sb.Append(c);

            sb.Append(m_filler01);
            sb.Append(c);
            sb.Append(m_reason_code);
            sb.Append(c);
            sb.Append(m_reason_code_qualifier);
            sb.Append(c);
            sb.Append(m_warning_code);
            sb.Append(c);
            sb.Append(m_grc);
            sb.Append(c);
            sb.Append(m_lo_x_sts_cnt2);
            sb.Append(c);

            for (int i = 0; i <= 4; i++)
            {
                sb.Append(m_lo_x_b7sc_list[i].Display());
                sb.Append(c);
            }

            sb.Append(m_hi_x_sts_cnt2);
            sb.Append(c);

            for (int i = 0; i <= 4; i++)
            {
                sb.Append(m_lo_x_b7sc_list[i].Display());
                sb.Append(c);
            }

            for (int i = 0; i <= 4; i++)
            {
                sb.Append(m_lo_x_stname_list[i]);
                sb.Append(c);
            }

            for (int i = 0; i <= 4; i++)
            {
                sb.Append(m_hi_x_stname_list[i]);
                sb.Append(c);
            }

            sb.Append(m_boe_preferred_b7sc.Display());
            sb.Append(c);
            sb.Append(m_boe_preferred_stname);
            sb.Append(c);
            sb.Append(m_filler02);
            sb.Append(c);

            return sb.ToString();

        }

        public override string Display()
        {
            return this.Display('-');
        }

        /// <summary>
        /// Creates a string with Wa2F1ex field names and values
        /// </summary>
        public override string Print()
        {
            StringBuilder sb = new StringBuilder();
            int i;

            // -------------------------------------------------------
            // -- Start of 1E data
            // -------------------------------------------------------
            // sb.AppendFormat("{0}{1}", m_wa2f1e.Print, Environment.NewLine);

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
            sb.AppendFormat("police_patrol_boro = {0}{1}", m_police_patrol_boro, Environment.NewLine);
            sb.AppendFormat("police_boro_com = {0}{1}", m_police_boro_com, Environment.NewLine);
            sb.AppendFormat("police_pct = {0}{1}", m_police_pct, Environment.NewLine);
            sb.AppendFormat("fire_div = {0}{1}", m_fire_div, Environment.NewLine);
            sb.AppendFormat("fire_bat = {0}{1}", m_fire_bat, Environment.NewLine);
            sb.AppendFormat("fire_co_type = {0}{1}", m_fire_co_type, Environment.NewLine);
            sb.AppendFormat("fire_co_num = {0}{1}", m_fire_co_num, Environment.NewLine);
            sb.AppendFormat("split_school_dist_flag = {0}{1}", m_split_school_dist_flag, Environment.NewLine);
            sb.AppendFormat("school_dist = {0}{1}", m_school_dist, Environment.NewLine);
            sb.AppendFormat("dynamic_block = {0}{1}", m_dynamic_block, Environment.NewLine);
            sb.AppendFormat("feature_type = {0}{1}", m_feature_type, Environment.NewLine);
            sb.AppendFormat("segment_type = {0}{1}", m_segment_type, Environment.NewLine);
            sb.AppendFormat("alx = {0}{1}", m_alx, Environment.NewLine);
            sb.AppendFormat("coincident_seg_cnt = {0}{1}", m_coincident_seg_cnt, Environment.NewLine);
            sb.AppendFormat("filler_80ct = {0}{1}", m_filler_80ct, Environment.NewLine);
            sb.AppendFormat("census_tract_1990 = {0}{1}", m_census_tract_1990, Environment.NewLine);
            sb.AppendFormat("census_tract_2010 = {0}{1}", m_census_tract_2010, Environment.NewLine);
            sb.AppendFormat("census_block_2010 = {0}{1}", m_census_block_2010, Environment.NewLine);
            sb.AppendFormat("census_block_suffix_2010 = {0}{1}", m_census_block_suffix_2010, Environment.NewLine);
            sb.AppendFormat("census_tract_2000 = {0}{1}", m_census_tract_2000, Environment.NewLine);
            sb.AppendFormat("census_block_2000 = {0}{1}", m_census_block_2000, Environment.NewLine);
            sb.AppendFormat("census_block_suffix_2000 = {0}{1}", m_census_block_suffix_2000, Environment.NewLine);
            sb.AppendFormat("nta = {0}{1}", m_nta, Environment.NewLine);
            sb.AppendFormat("dsny_snow_priority = {0}{1}", m_dsny_snow_priority, Environment.NewLine);
            sb.AppendFormat("san_org_pick_up = {0}{1}", m_san_org_pick_up, Environment.NewLine);
            sb.AppendFormat("san_bulk = {0}{1}", m_san_bulk, Environment.NewLine);
            sb.AppendFormat("hurricane_zone = {0}{1}", m_hurricane_zone, Environment.NewLine);
            sb.AppendFormat("san_commercial_waste_zone = {0}{1}", m_san_commercial_waste_zone, Environment.NewLine);
            sb.AppendFormat("filler3 = {0}{1}", m_filler3, Environment.NewLine);
            sb.AppendFormat("true_hns = {0}{1}", m_true_hns, Environment.NewLine);
            sb.AppendFormat("real_b7sc = {0}{1}", m_real_b7sc.Display(), Environment.NewLine);
            sb.AppendFormat("segment_id = {0}{1}", m_segment_id, Environment.NewLine);
            sb.AppendFormat("curve_flag = {0}{1}", m_curve_flag, Environment.NewLine);

            // -------------------------------------------------------
            // -- Start of 1V data
            // -------------------------------------------------------
            for (i = 0; i <= 3; i++)
            {
                sb.AppendFormat("valid_lgcs({0}) = {1}{2}", i, m_valid_lgcs[i], Environment.NewLine);
            }

            sb.AppendFormat("boe_lgc_pointer = {0}{1}", m_boe_lgc_pointer, Environment.NewLine);
            sb.AppendFormat("segment_azm = {0}{1}", m_segment_azm, Environment.NewLine);
            sb.AppendFormat("segment_orient = {0}{1}", m_segment_orient, Environment.NewLine);
            sb.AppendFormat("lo_x_coord = {0}{1}", m_lo_x_coord, Environment.NewLine);
            sb.AppendFormat("lo_y_coord = {0}{1}", m_lo_y_coord, Environment.NewLine);
            sb.AppendFormat("lo_z_coord = {0}{1}", m_lo_z_coord, Environment.NewLine);
            sb.AppendFormat("hi_x_coord = {0}{1}", m_hi_x_coord, Environment.NewLine);
            sb.AppendFormat("hi_y_coord = {0}{1}", m_hi_y_coord, Environment.NewLine);

            sb.AppendFormat("hi_z_coord = {0}{1}", m_hi_z_coord, Environment.NewLine);
            sb.AppendFormat("curve_center_x_coord = {0}{1}", m_curve_center_x_coord, Environment.NewLine);
            sb.AppendFormat("curve_center_y_coord = {0}{1}", m_curve_center_y_coord, Environment.NewLine);
            sb.AppendFormat("curve_center_z_coord = {0}{1}", m_curve_center_z_coord, Environment.NewLine);
            sb.AppendFormat("circle_radius = {0}{1}", m_circle_radius, Environment.NewLine);
            sb.AppendFormat("secant_location = {0}{1}", m_secant_location, Environment.NewLine);
            sb.AppendFormat("beta_angle = {0}{1}", m_beta_angle, Environment.NewLine);
            sb.AppendFormat("alpha_angle = {0}{1}", m_alpha_angle, Environment.NewLine);
            sb.AppendFormat("from_node = {0}{1}", m_from_node, Environment.NewLine);
            sb.AppendFormat("to_node = {0}{1}", m_to_node, Environment.NewLine);
            sb.AppendFormat("vanity_lion_key = {0}{1}", m_vanity_lion_key.Display(), Environment.NewLine);
            sb.AppendFormat("vanity_sos = {0}{1}", m_vanity_sos, Environment.NewLine);
            sb.AppendFormat("split_lo_hns = {0}{1}", m_split_lo_hns, Environment.NewLine);
            sb.AppendFormat("traffic_dir = {0}{1}", m_traffic_dir, Environment.NewLine);
            sb.AppendFormat("turn_restrictions = {0}{1}", m_turn_restrictions, Environment.NewLine);
            sb.AppendFormat("gbicurv_fraction = {0}{1}", m_gbicurv_fraction, Environment.NewLine);
            sb.AppendFormat("roadway_type = {0}{1}", m_roadway_type, Environment.NewLine);
            sb.AppendFormat("physical_id = {0}{1}", m_physical_id, Environment.NewLine);
            sb.AppendFormat("generic_id = {0}{1}", m_generic_id, Environment.NewLine);
            sb.AppendFormat("nypd_id = {0}{1}", m_nypd_id, Environment.NewLine);
            sb.AppendFormat("fdny_id = {0}{1}", m_fdny_id, Environment.NewLine);

            // 16.1 and 16.4 changes
            sb.AppendFormat("bike_lane_2 = {0}{1}", m_bike_lane2, Environment.NewLine);
            sb.AppendFormat("bike_traffic_direction = {0}{1}", m_bike_traffic_direction, Environment.NewLine);
            sb.AppendFormat("filler03 = {0}{1}", m_filler03, Environment.NewLine);
            sb.AppendFormat("street_status = {0}{1}", m_street_status, Environment.NewLine);
            sb.AppendFormat("street_width = {0}{1}", m_street_width, Environment.NewLine);
            sb.AppendFormat("street_width_irregular = {0}{1}", m_street_width_irregular, Environment.NewLine);
            sb.AppendFormat("bike_lane = {0}{1}", m_bike_lane, Environment.NewLine);
            sb.AppendFormat("federal_classification_code = {0}{1}", m_federal_classification_code, Environment.NewLine);
            sb.AppendFormat("right_of_way_type = {0}{1}", m_right_of_way_type, Environment.NewLine);

            for (i = 0; i <= 4; i++)
            {
                sb.AppendFormat("additional_valid_lgcs({0}) = {1}{2}", i, m_additional_valid_lgcs[i], Environment.NewLine);
            }

            // Start of 1Ex data
            sb.AppendFormat("legacy_segment_id = {0}{1}", m_legacy_segment_id, Environment.NewLine);
            for (i = 0; i <= 4; i++)
            {
                sb.AppendFormat("from_dcp_preferred_lgcs({0}) = {1}{2}", i, m_from_dcp_preferred_lgcs[i], Environment.NewLine);
            }
            for (i = 0; i <= 4; i++)
            {
                sb.AppendFormat("to_dcp_preferred_lgcs({0}) = {1}{2}", i, m_to_dcp_preferred_lgcs[i], Environment.NewLine);
            }
            for (i = 0; i <= 4; i++)
            {
                sb.AppendFormat("from_additional_lgcs({0}) = {1}{2}", i, m_from_additional_lgcs[i], Environment.NewLine);
            }
            for (i = 0; i <= 4; i++)
            {
                sb.AppendFormat("to_additional_lgcs({0}) = {1}{2}", i, m_to_additional_lgcs[i], Environment.NewLine);
            }

            sb.AppendFormat("no_cross_street_calculation_flag = {0}{1}", m_no_cross_street_calculation_flag, Environment.NewLine);
            sb.AppendFormat("individual_segment_length = {0}{1}", m_individual_segment_length, Environment.NewLine);

            // Added for Geosupport Version 11.3 / Release 12A
            sb.AppendFormat("nta_name = {0}{1}", m_nta_name, Environment.NewLine);

            // Added for Geosupport Version 14.1 / Release 14A
            sb.AppendFormat("USPS_city_name = {0}{1}", m_USPS_city_name, Environment.NewLine);
            sb.AppendFormat("latitude = {0}{1}", m_latitude, Environment.NewLine);
            sb.AppendFormat("longitude = {0}{1}", m_longitude, Environment.NewLine);

            // Geosupport Version 15.3/Release 15C
            sb.AppendFormat("segment_from_node = {0}{1}", m_seg_from_node, Environment.NewLine);
            sb.AppendFormat("segment_to_node = {0}{1}", m_seg_to_node, Environment.NewLine);
            sb.AppendFormat("segment_from_x_coordinates = {0}{1}", m_seg_from_x_coord, Environment.NewLine);
            sb.AppendFormat("segment_from_y_coordinates = {0}{1}", m_seg_from_y_coord, Environment.NewLine);
            sb.AppendFormat("segment_from_z_coordinates = {0}{1}", m_seg_from_z_coord, Environment.NewLine);
            sb.AppendFormat("segment_to_x_coordinates = {0}{1}", m_seg_to_x_coord, Environment.NewLine);
            sb.AppendFormat("segment_to_y_coordinates = {0}{1}", m_seg_to_y_coord, Environment.NewLine);
            sb.AppendFormat("segment_to_z_coordinates = {0}{1}", m_seg_to_z_coord, Environment.NewLine);

            // 16.1 changes
            sb.AppendFormat("blockface_id = {0}{1}", m_blockface_id, Environment.NewLine);
            sb.AppendFormat("No_Traveling_lanes = {0}{1}", m_No_Traveling_lanes, Environment.NewLine);
            sb.AppendFormat("No_Parking_lanes = {0}{1}", m_No_Parking_lanes, Environment.NewLine);
            sb.AppendFormat("Total_Lanes = {0}{1}", m_Total_Lanes, Environment.NewLine);

            // 16.4 changes
            sb.AppendFormat("Street_Width_Maximum = {0}{1}", m_st_width_max, Environment.NewLine);

            // Release 17D
            sb.AppendFormat("speed_limit = {0}{1}", m_speed_limit, Environment.NewLine);

            // Added for Geosupport version 18.1
            sb.AppendFormat("puma_code = {0}{1}", m_puma_code, Environment.NewLine);

            // Added 4 byte police sector and 1 byte police area
            sb.AppendFormat("police_sector = {0}{1}", m_police_sector, Environment.NewLine);
            sb.AppendFormat("police_area = {0}{1}", m_police_area, Environment.NewLine);

            // Truck_Route_Type
            sb.AppendFormat("truck_route_type = {0}{1}", m_truck_route_type, Environment.NewLine);

            // Census 2020 fields
            sb.AppendFormat("census_tract_2020 = {0}{1}", m_census_tract_2020, Environment.NewLine);
            sb.AppendFormat("census_block_2020 = {0}{1}", m_census_block_2020, Environment.NewLine);
            sb.AppendFormat("census_block_suffix_2020 = {0}{1}", m_census_block_suffix_2020, Environment.NewLine);
            sb.AppendFormat("nta_2020 = {0}{1}", m_nta_2020, Environment.NewLine);
            sb.AppendFormat("cdta_2020 = {0}{1}", m_cdta_2020, Environment.NewLine);

            // PUMA 2020 field
            sb.AppendFormat("puma_2020 = {0}{1}", m_puma_2020, Environment.NewLine);

            sb.AppendFormat("filler01 = {0}{1}", m_filler01, Environment.NewLine);
            sb.AppendFormat("reason_code = {0}{1}", m_reason_code, Environment.NewLine);
            sb.AppendFormat("reason_code_qualifier = {0}{1}", m_reason_code_qualifier, Environment.NewLine);
            sb.AppendFormat("warning_code = {0}{1}", m_warning_code, Environment.NewLine);
            sb.AppendFormat("grc = {0}{1}", m_grc, Environment.NewLine);
            sb.AppendFormat("lo_x_sts_cnt2 = {0}{1}", m_lo_x_sts_cnt2, Environment.NewLine);

            for (i = 0; i <= 4; i++)
            {
                sb.AppendFormat("lo_x_b7sc_list({0}) = {1}{2}", i, m_lo_x_b7sc_list[i].Display(), Environment.NewLine);
            }

            sb.AppendFormat("hi_x_sts_cnt2 = {0}{1}", m_hi_x_sts_cnt2, Environment.NewLine);

            for (i = 0; i <= 4; i++)
            {
                sb.AppendFormat("hi_x_b7sc_list({0}) = {1}{2}", i, m_hi_x_b7sc_list[i].Display(), Environment.NewLine);
            }

            for (i = 0; i <= 4; i++)
            {
                sb.AppendFormat("lo_x_stname_list({0}) = {1}{2}", i, m_lo_x_stname_list[i], Environment.NewLine);
            }

            for (i = 0; i <= 4; i++)
            {
                sb.AppendFormat("hi_x_stname_list({0}) = {1}{2}", i, m_hi_x_stname_list[i], Environment.NewLine);
            }

            sb.AppendFormat("boe_preferred_b7sc = {0}{1}", m_boe_preferred_b7sc.Display(), Environment.NewLine);
            sb.AppendFormat("boe_preferred_stname = {0}{1}", m_boe_preferred_stname, Environment.NewLine);
            sb.AppendFormat("filler02 = {0}{1}", m_filler02, Environment.NewLine);

            return sb.ToString();

        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine();
            sb.AppendLine("************************************************************************************************");
            sb.AppendLine("***************************************  Wa2F1ex  ********************************************");
            sb.AppendLine("************************************************************************************************");

            sb.AppendLine();
            sb.AppendLine("**********  Key Information  **********");
            sb.AppendLine();

            sb.AppendFormat("gridkey1 = {0}\r\n", m_gridkey1.Display());
            sb.AppendFormat("cont_parity_ind = {0}\r\n", m_cont_parity_ind);
            sb.AppendFormat("lo_hns = {0}\r\n", m_lo_hns);
            sb.AppendFormat("hi_hns = {0}\r\n", m_hi_hns);
            sb.AppendFormat("no_cross_street_calculation_flag = {0}\r\n", m_no_cross_street_calculation_flag);

            sb.AppendLine();
            sb.AppendLine("**********  Geographic Information  **********");
            sb.AppendLine();

            sb.AppendFormat("x_coord = {0}\r\n", m_x_coord);
            sb.AppendFormat("y_coord = {0}\r\n", m_y_coord);
            sb.AppendFormat("z_coord = {0}\r\n", m_z_coord);
            sb.AppendFormat("latitude = {0}\r\n", m_latitude);
            sb.AppendFormat("longitude = {0}\r\n", m_longitude);

            sb.AppendLine();

            sb.AppendFormat("from_node = {0}\r\n", m_from_node);
            sb.AppendFormat("to_node = {0}\r\n", m_to_node);

            sb.AppendLine();

            sb.AppendFormat("lo_x_coord = {0}\r\n", m_lo_x_coord);
            sb.AppendFormat("lo_y_coord = {0}\r\n", m_lo_y_coord);
            sb.AppendFormat("lo_z_coord = {0}\r\n", m_lo_z_coord);
            sb.AppendFormat("hi_x_coord = {0}\r\n", m_hi_x_coord);
            sb.AppendFormat("hi_y_coord = {0}\r\n", m_hi_y_coord);
            sb.AppendFormat("hi_z_coord = {0}\r\n", m_hi_z_coord);

            sb.AppendLine();

            sb.AppendFormat("segment_id = {0}\r\n", m_segment_id);
            sb.AppendFormat("individual_segment_length = {0}\r\n", m_individual_segment_length);

            sb.AppendLine();

            sb.AppendFormat("physical_id = {0}\r\n", m_physical_id);
            sb.AppendFormat("generic_id = {0}\r\n", m_generic_id);
            sb.AppendFormat("nypd_id = {0}\r\n", m_nypd_id);
            sb.AppendFormat("fdny_id = {0}\r\n", m_fdny_id);
            sb.AppendFormat("legacy_segment_id = {0}\r\n", m_legacy_segment_id);
            sb.AppendFormat("blockface_id = {0}\r\n", m_blockface_id);

            sb.AppendLine();

            sb.AppendFormat("segment_from_node = {0}\r\n", m_seg_from_node);
            sb.AppendFormat("segment_to_node = {0}\r\n", m_seg_to_node);
            sb.AppendFormat("segment_from_x_coordinates = {0}\r\n", m_seg_from_x_coord);
            sb.AppendFormat("segment_from_y_coordinates = {0}\r\n", m_seg_from_y_coord);
            sb.AppendFormat("segment_from_z_coordinates = {0}\r\n", m_seg_from_z_coord);
            sb.AppendFormat("segment_to_x_coordinates = {0}\r\n", m_seg_to_x_coord);
            sb.AppendFormat("segment_to_y_coordinates = {0}\r\n", m_seg_to_y_coord);
            sb.AppendFormat("segment_to_z_coordinates = {0}\r\n", m_seg_to_z_coord);

            sb.AppendLine();

            sb.AppendFormat("lion_key = {0}\r\n", m_lion_key.Display());
            sb.AppendFormat("spec_addr_flag = {0}\r\n", m_spec_addr_flag);
            sb.AppendFormat("sos_ind = {0}\r\n", m_sos_ind);
            sb.AppendFormat("segment_len = {0}\r\n", m_segment_len);

            sb.AppendLine();

            sb.AppendFormat("res_gss = {0}\r\n", m_res_gss);
            sb.AppendFormat("mh_ri_flag = {0}\r\n", m_mh_ri_flag);
            sb.AppendFormat("zip_code = {0}\r\n", m_zip_code);
            sb.AppendFormat("filler3 = {0}\r\n", m_filler3);
            sb.AppendFormat("true_hns = {0}\r\n", m_true_hns);
            sb.AppendFormat("real_b7sc = {0}\r\n", m_real_b7sc.Display());
            sb.AppendFormat("curve_flag = {0}\r\n", m_curve_flag);
            sb.AppendFormat("dynamic_block = {0}\r\n", m_dynamic_block);
            sb.AppendFormat("feature_type = {0}\r\n", m_feature_type);
            sb.AppendFormat("segment_type = {0}\r\n", m_segment_type);
            sb.AppendFormat("alx = {0}\r\n", m_alx);
            sb.AppendFormat("coincident_seg_cnt = {0}\r\n", m_coincident_seg_cnt);
            sb.AppendFormat("vanity_lion_key = {0}\r\n", m_vanity_lion_key.Display());
            sb.AppendFormat("vanity_sos = {0}\r\n", m_vanity_sos);
            sb.AppendFormat("split_lo_hns = {0}\r\n", m_split_lo_hns);
            sb.AppendFormat("traffic_dir = {0}\r\n", m_traffic_dir);
            sb.AppendFormat("turn_restrictions = {0}\r\n", m_turn_restrictions);
            sb.AppendFormat("gbicurv_fraction = {0}\r\n", m_gbicurv_fraction);
            sb.AppendFormat("roadway_type = {0}\r\n", m_roadway_type);

            // Added Truck Route Type Field
            sb.AppendFormat("truck_route_type = {0}\r\n", m_truck_route_type);

            sb.AppendLine();

            sb.AppendFormat("bike_lane_2 = {0}\r\n", m_bike_lane2);
            sb.AppendFormat("bike_traffic_direction = {0}\r\n", m_bike_traffic_direction);
            sb.AppendFormat("filler03 = {0}\r\n", m_filler03);
            sb.AppendFormat("street_status = {0}\r\n", m_street_status);
            sb.AppendFormat("street_width = {0}\r\n", m_street_width);
            sb.AppendFormat("street_width_irregular = {0}\r\n", m_street_width_irregular);
            sb.AppendFormat("bike_lane = {0}\r\n", m_bike_lane);
            sb.AppendFormat("federal_classification_code = {0}\r\n", m_federal_classification_code);
            sb.AppendFormat("right_of_way_type = {0}\r\n", m_right_of_way_type);
            sb.AppendFormat("No_Traveling_lanes = {0}\r\n", m_No_Traveling_lanes);
            sb.AppendFormat("No_Parking_lanes = {0}\r\n", m_No_Parking_lanes);
            sb.AppendFormat("Total_Lanes = {0}\r\n", m_Total_Lanes);
            sb.AppendFormat("Street_Width_Maximum = {0}\r\n", m_st_width_max);

            // Added speed limit field
            sb.AppendFormat("Speed_Limit = {0}\r\n", m_speed_limit);

            sb.AppendLine();
            sb.AppendLine("**********  Election District Information  **********");
            sb.AppendLine();

            sb.AppendFormat("ed = {0}\r\n", m_ed);
            sb.AppendFormat("ad = {0}\r\n", m_ad);
            sb.AppendFormat("split_ed = {0}\r\n", m_split_ed);
            sb.AppendFormat("cd = {0}\r\n", m_cd);
            sb.AppendFormat("sd = {0}\r\n", m_sd);
            sb.AppendFormat("mc = {0}\r\n", m_mc);
            sb.AppendFormat("co = {0}\r\n", m_co);

            sb.AppendLine();

            sb.AppendFormat("boe_preferred_b7sc = {0}\r\n", m_boe_preferred_b7sc.Display());
            sb.AppendFormat("boe_preferred_stname = {0}\r\n", m_boe_preferred_stname);

            sb.AppendLine();
            sb.AppendLine("**********  Other District Information  **********");
            sb.AppendLine();

            sb.AppendFormat("dot_st_light_contract_area = {0}\r\n", m_dot_st_light_contract_area);
            sb.AppendFormat("com_dist = {0}\r\n", m_com_dist.Display());
            sb.AppendFormat("nta_2020 = {0}\r\n", m_nta_2020);
            sb.AppendFormat("cdta_2020 = {0}\r\n", m_cdta_2020);

            // Added PUMA 2020 field
            sb.AppendFormat("puma_2020 = {0}\r\n", m_puma_2020);

            sb.AppendLine();
            sb.AppendFormat("nta_2010 = {0}\r\n", m_nta);
            sb.AppendFormat("nta_2010_name = {0}\r\n", m_nta_name);

            sb.AppendFormat("{0}", Environment.NewLine);
            sb.AppendFormat("USPS_city_name = {0}{1}", m_USPS_city_name, Environment.NewLine);
            sb.AppendFormat("{0}", Environment.NewLine);
            sb.AppendFormat("hurricane_zone = {0}{1}", m_hurricane_zone, Environment.NewLine);
            sb.AppendFormat("{0}", Environment.NewLine);
            sb.AppendFormat("split_school_dist_flag = {0}{1}", m_split_school_dist_flag, Environment.NewLine);
            sb.AppendFormat("school_dist = {0}{1}", m_school_dist, Environment.NewLine);

            // --SPO(2018-01-02): Added new 5 byte puma_code for Geosupport version 18.1
            sb.AppendFormat("puma_code = {0}{1}", m_puma_code, Environment.NewLine);
            sb.AppendFormat("{0}", Environment.NewLine);
            sb.AppendFormat("health_center_dist = {0}{1}", m_health_center_dist, Environment.NewLine);
            sb.AppendFormat("health_area = {0}{1}", m_health_area, Environment.NewLine);

            sb.AppendFormat("{0}{1}", Environment.NewLine + "**********  Sanitation Information  **********", Environment.NewLine + Environment.NewLine);

            sb.AppendFormat("san_dist = {0}{1}", m_san_dist, Environment.NewLine);
            sb.AppendFormat("san_sched = {0}{1}", m_san_sched, Environment.NewLine);
            sb.AppendFormat("san_reg = {0}{1}", m_san_reg, Environment.NewLine);
            sb.AppendFormat("san_recycle = {0}{1}", m_san_recycle, Environment.NewLine);
            sb.AppendFormat("dsny_snow_priority = {0}{1}", m_dsny_snow_priority, Environment.NewLine);
            sb.AppendFormat("san_org_pick_up = {0}{1}", m_san_org_pick_up, Environment.NewLine);
            sb.AppendFormat("san_bulk = {0}{1}", m_san_bulk, Environment.NewLine);

            // --SPO(2022-08-31): Add new 4 byte DSNY Commercial Waste Zone for 22C
            sb.AppendFormat("san_commercial_waste_zone = {0}{1}", m_san_commercial_waste_zone, Environment.NewLine);

            sb.AppendFormat("{0}{1}", Environment.NewLine + "**********  Police and Fire Information  **********", Environment.NewLine + Environment.NewLine);

            // --????????????????????????????????????????????????????????
            sb.AppendFormat("police_patrol_boro = {0}{1}", m_police_patrol_boro, Environment.NewLine);

            sb.AppendFormat("police_boro_com = {0}{1}", m_police_boro_com, Environment.NewLine);
            sb.AppendFormat("police_pct = {0}{1}", m_police_pct, Environment.NewLine);

            // --JGT(2018-07-16): Added 4 byte police sector and 1 byte police area 
            sb.AppendFormat("police_sector = {0}{1}", m_police_sector, Environment.NewLine);
            sb.AppendFormat("police_area = {0}{1}", m_police_area, Environment.NewLine);

            sb.AppendFormat("fire_div = {0}{1}", m_fire_div, Environment.NewLine);
            sb.AppendFormat("fire_bat = {0}{1}", m_fire_bat, Environment.NewLine);
            sb.AppendFormat("fire_co_type = {0}{1}", m_fire_co_type, Environment.NewLine);
            sb.AppendFormat("fire_co_num = {0}{1}", m_fire_co_num, Environment.NewLine);

            sb.AppendFormat("{0}{1}", Environment.NewLine + "**********  Census Information  **********", Environment.NewLine + Environment.NewLine);

            //--------------------------------------------------------------------------
            sb.AppendFormat("census_tract_2020 = {0}{1}", m_census_tract_2020, Environment.NewLine);
            sb.AppendFormat("census_block_2020 = {0}{1}", m_census_block_2020, Environment.NewLine);
            sb.AppendFormat("census_block_suffix_2020 = {0}{1}", m_census_block_suffix_2020, Environment.NewLine);
            sb.AppendFormat("{0}", Environment.NewLine);
            sb.AppendFormat("census_tract_2010 = {0}{1}", m_census_tract_2010, Environment.NewLine);
            sb.AppendFormat("census_block_2010 = {0}{1}", m_census_block_2010, Environment.NewLine);
            sb.AppendFormat("census_block_suffix_2010 = {0}{1}", m_census_block_suffix_2010, Environment.NewLine);
            sb.AppendFormat("{0}", Environment.NewLine);
            sb.AppendFormat("census_tract_2000 = {0}{1}", m_census_tract_2000, Environment.NewLine);
            sb.AppendFormat("census_block_2000 = {0}{1}", m_census_block_2000, Environment.NewLine);
            sb.AppendFormat("census_block_suffix_2000 = {0}{1}", m_census_block_suffix_2000, Environment.NewLine);
            sb.AppendFormat("{0}", Environment.NewLine);
            sb.AppendFormat("census_tract_1990 = {0}{1}", m_census_tract_1990, Environment.NewLine);
            sb.AppendFormat("{0}", Environment.NewLine);
            sb.AppendFormat("filler_80ct = {0}{1}", m_filler_80ct, Environment.NewLine);

            sb.AppendFormat("{0}{1}", Environment.NewLine + "**********  Valid LGCs for Input Street  **********", Environment.NewLine + Environment.NewLine);
            for (int i = 0; i <= 3; i++)
            {
                sb.AppendFormat("valid_lgcs({0}) = {1}{2}", i, m_valid_lgcs[i], Environment.NewLine);
            }
            sb.AppendFormat("dcp_pref_lgc = {0}{1}", m_dcp_pref_lgc, Environment.NewLine);
            sb.AppendFormat("boe_lgc_pointer = {0}{1}", m_boe_lgc_pointer, Environment.NewLine);
            for (int i = 0; i <= 4; i++)
            {
                sb.AppendFormat("additional_valid_lgcs({0}) = {1}{2}", i, m_additional_valid_lgcs[i], Environment.NewLine);
            }

            sb.AppendFormat("{0}{1}", Environment.NewLine + "**********   Information to Calculate XY for Input Address  **********", Environment.NewLine + Environment.NewLine);

            sb.AppendFormat("segment_azm = {0}{1}", m_segment_azm, Environment.NewLine);
            sb.AppendFormat("segment_orient = {0}{1}", m_segment_orient, Environment.NewLine);
            sb.AppendFormat("curve_center_x_coord = {0}{1}", m_curve_center_x_coord, Environment.NewLine);
            sb.AppendFormat("curve_center_y_coord = {0}{1}", m_curve_center_y_coord, Environment.NewLine);
            sb.AppendFormat("curve_center_z_coord = {0}{1}", m_curve_center_z_coord, Environment.NewLine);
            sb.AppendFormat("circle_radius = {0}{1}", m_circle_radius, Environment.NewLine);
            sb.AppendFormat("secant_location = {0}{1}", m_secant_location, Environment.NewLine);
            sb.AppendFormat("beta_angle = {0}{1}", m_beta_angle, Environment.NewLine);
            sb.AppendFormat("alpha_angle = {0}{1}", m_alpha_angle, Environment.NewLine);

            sb.AppendFormat("{0}{1}", Environment.NewLine + "**********  1EX GRC Information  **********", Environment.NewLine + Environment.NewLine);

            sb.AppendFormat("reason_code = {0}{1}", m_reason_code, Environment.NewLine);
            sb.AppendFormat("reason_code_qualifier = {0}{1}", m_reason_code_qualifier, Environment.NewLine);
            sb.AppendFormat("warning_code = {0}{1}", m_warning_code, Environment.NewLine);
            sb.AppendFormat("grc = {0}{1}", m_grc, Environment.NewLine);

            sb.AppendFormat("{0}", Environment.NewLine);

            sb.AppendFormat("{0}{1}", Environment.NewLine + "**********  Cross Streets Information  **********", Environment.NewLine + Environment.NewLine);

            sb.AppendFormat("lo_x_sts_cnt = {0}{1}", m_lo_x_sts_cnt, Environment.NewLine);
            for (int i = 0; i <= 4; i++)
            {
                sb.AppendFormat("lo_x_sts({0}) = {1}{2}", i, m_lo_x_sts[i].Display(), Environment.NewLine);
            }
            for (int i = 0; i <= 4; i++)
            {
                sb.AppendFormat("from_dcp_preferred_lgcs({0}) = {1}{2}", i, m_from_dcp_preferred_lgcs[i], Environment.NewLine);
            }
            for (int i = 0; i <= 4; i++)
            {
                sb.AppendFormat("from_additional_lgcs({0}) = {1}{2}", i, m_from_additional_lgcs[i], Environment.NewLine);
            }
            for (int i = 0; i <= 4; i++)
            {
                sb.AppendFormat("lo_x_stname_list({0}) = {1}{2}", i, m_lo_x_stname_list[i], Environment.NewLine);
            }

            sb.AppendFormat("lo_x_sts_cnt2 = {0}{1}", m_lo_x_sts_cnt2, Environment.NewLine);
            for (int i = 0; i <= 4; i++)
            {
                sb.AppendFormat("lo_x_b7sc_list({0}) = {1}{2}", i, m_lo_x_b7sc_list[i].Display(), Environment.NewLine);
            }

            sb.AppendFormat("{0}", Environment.NewLine);

            sb.AppendFormat("hi_x_sts_cnt = {0}{1}", m_hi_x_sts_cnt, Environment.NewLine);
            for (int i = 0; i <= 4; i++)
            {
                sb.AppendFormat("hi_x_sts({0}) = {1}{2}", i, m_hi_x_sts[i].Display(), Environment.NewLine);
            }
            for (int i = 0; i <= 4; i++)
            {
                sb.AppendFormat("to_dcp_preferred_lgcs({0}) = {1}{2}", i, m_to_dcp_preferred_lgcs[i], Environment.NewLine);
            }
            for (int i = 0; i <= 4; i++)
            {
                sb.AppendFormat("to_additional_lgcs({0}) = {1}{2}", i, m_to_additional_lgcs[i], Environment.NewLine);
            }
            for (int i = 0; i <= 4; i++)
            {
                sb.AppendFormat("hi_x_stname_list({0}) = {1}{2}", i, m_hi_x_stname_list[i], Environment.NewLine);
            }

            sb.AppendFormat("hi_x_sts_cnt2 = {0}{1}", m_hi_x_sts_cnt2, Environment.NewLine);
            for (int i = 0; i <= 4; i++)
            {
                sb.AppendFormat("hi_x_b7sc_list({0}) = {1}{2}", i, m_hi_x_b7sc_list[i].Display(), Environment.NewLine);
            }

            sb.AppendFormat("{0}", Environment.NewLine);

            sb.AppendFormat("{0}{1}", Environment.NewLine + "**********  Miscellaneous Filler Information  **********", Environment.NewLine + Environment.NewLine);

            sb.AppendFormat("filler01 = {0}{1}", m_filler01, Environment.NewLine);
            sb.AppendFormat("filler02 = {0}{1}", m_filler02, Environment.NewLine);

            sb.AppendFormat("{0}", Environment.NewLine);

            //------------------------------------------------------------------------
            //------------------------------------------------------------------------
            //------------------------------------------------------------------------
            //--SPO(2023_03_30): Testing techniques for creating GOAT-like display
            //------------------------------------------------------------------------
            //------------------------------------------------------------------------
            //------------------------------------------------------------------------

            // sb.AppendFormat("ed = {0}{1}", m_ed, Environment.NewLine);
            // sb.AppendFormat("ad = {0}{1}", m_ad, Environment.NewLine);
            // sb.AppendFormat("split_ed = {0}{1}", m_split_ed, Environment.NewLine);
            // sb.AppendFormat("cd = {0}{1}", m_cd, Environment.NewLine);
            // sb.AppendFormat("sd = {0}{1}", m_sd, Environment.NewLine);
            // sb.AppendFormat("mc = {0}{1}", m_mc, Environment.NewLine);
            // sb.AppendFormat("co = {0}{1}", m_co, Environment.NewLine);

            // sb.AppendFormat("{0}", Environment.NewLine);

            // sb.AppendFormat("boe_preferred_b7sc = {0}{1}", m_boe_preferred_b7sc.Display, Environment.NewLine);
            // sb.AppendFormat("boe_preferred_stname = {0}{1}", m_boe_preferred_stname, Environment.NewLine);

            sb.AppendFormat("{0}{1}{2}{3}{4}", Environment.NewLine, "****************************************  ",
                            "GOAT-Like Election District Information", "  ****************************************", Environment.NewLine + Environment.NewLine);

            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "City Council District:", m_co, "Municipal Court District:", m_mc, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "Assembly District:", m_ad, "Election District:", m_ed, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "Congressional District:", m_cd, "State Senate District:", m_sd, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "BOE Preferred B7SC:", m_boe_preferred_b7sc.Display(), "BOE Preferred Street Name:", m_boe_preferred_stname, Environment.NewLine);

            return sb.ToString();
        }

        public string GoatDisplay()
        {
            StringBuilder sb = new StringBuilder();
            int i;

            // Start of display block
            sb.AppendFormat("{0}", Environment.NewLine);
            sb.AppendFormat("{0}{1}", "**************************************************************************************************************", Environment.NewLine);
            sb.AppendFormat("{0}{1}", "***********************************************  GOAT:  Wa2F1ex  *********************************************", Environment.NewLine);
            sb.AppendFormat("{0}{1}", "**************************************************************************************************************", Environment.NewLine);

            // Geographic Information Section
            sb.AppendFormat("{0}{1}{2}{3}{4}", Environment.NewLine, "******************************************  ",
                            "Geographic Information", "  ******************************************", Environment.NewLine + Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "X,Y Coordinate:", m_x_coord + ", " + m_y_coord, "From Node:", m_from_node, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "Latitude, Longitude:", m_latitude + "," + m_longitude, "From X,Y Coordinate:", m_lo_x_coord + ", " + m_lo_y_coord, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "Community District:", m_com_dist.ToString(), "To Node:", m_to_node, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "LION Face Code:", m_lion_key.face_code, "To X,Y Coordinate:", m_hi_x_coord + ", " + m_hi_y_coord, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "LION Sequence Number:", m_lion_key.sequence_number, "Segment From Node:", m_seg_from_node, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "Street Code B10SC:", m_gridkey1.b5sc.ToString() + m_dcp_pref_lgc + "???", "Segment From X,Y Coordinate:", m_seg_from_x_coord + ", " + m_seg_from_y_coord, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "Alley/Cross Street Flag:", m_alx, "Segment To Node:", m_seg_to_node, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "Traffic Direction:", m_traffic_dir, "Segment To X,Y Coordinate:", m_seg_to_x_coord + ", " + m_seg_to_y_coord, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "Speed Limit:", m_speed_limit, "Segment ID/Length:", m_segment_id + "/" + m_segment_len, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "Coincident Segment Count:", m_coincident_seg_cnt, "Curve Flag:", m_curve_flag, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "Segment Type:", m_segment_type, "Feature Type:", m_feature_type, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "Right of Way Type:", m_right_of_way_type, "Roadway Type:", m_roadway_type, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "Number of Parking Lanes:", m_No_Parking_lanes, "Bike Lane:", m_bike_lane, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "Number of Travel Lanes:", m_No_Traveling_lanes, "Bike Lane Traffic Direction:", m_bike_traffic_direction, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "Total Number of Lanes:", m_Total_Lanes, "Street Width Min / Max:", m_street_width + " / " + m_st_width_max, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "Atomic Polygon:", m_dynamic_block, "Physical ID:", m_physical_id, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "Block Face ID:", m_blockface_id, "Generic ID:", m_generic_id, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "CD Eligibility:", m_res_gss, "Special Address:", m_spec_addr_flag, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "ZIP Code / USPS Preferred City Name:", m_zip_code + " / " + m_USPS_city_name, "DCP Preferred B7SC / Street Name:", m_gridkey1.b5sc.ToString() + m_dcp_pref_lgc + " / " + "street name????", Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "Low House Number (HNS):", m_lo_hns, "High House Number(HNS):", m_hi_hns, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "Truck Route Type:", m_truck_route_type, "        ", "      ", Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "Low End Cross Streets:", "     ", "High End Cross Streets:", "     ", Environment.NewLine);

            // Loop for formatted street names
            for (i = 0; i <= 4; i++)
            {
                // Change initial -30 to -28 to correct for 32-byte stname spacing 
                sb.AppendFormat("{0,-28} {1,-30} {2,-30} {3,-30}{4}", m_lo_x_b7sc_list[i].Display(), m_lo_x_stname_list[i], m_lo_x_b7sc_list[i].Display(), m_hi_x_stname_list[i], Environment.NewLine);
            }

            // City Service Information Section
            sb.AppendFormat("{0}{1}{2}{3}{4}", Environment.NewLine, "******************************************  ",
                            "City Service Information", "  ******************************************", Environment.NewLine + Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "Police Patrol Borough:", m_police_boro_com, "Sanitation District/Section:", m_san_dist + "/" + m_san_dist.Substring(1, 2) + m_san_sched.Substring(0, 1), Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "Police Precinct:", m_police_pct, "Sanitation Subsection:", m_san_sched, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "Police Sector:", m_police_sector, "Regular Sanitation Pickup:", m_san_reg, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "Police Service Area:", m_police_area, "Recycling Sanitation Pickup:", m_san_recycle, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "Fire Division:", m_fire_div, "Organics Recycling Pickup:", m_san_org_pick_up, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "Fire Battalion:", m_fire_bat, "Sanitation Bulk Pickup:", m_san_bulk, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "Fire Type/Company:", m_fire_co_type + "/" + m_fire_co_num, "DSNY Snow Priority:", m_dsny_snow_priority, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "Health Area:", m_health_area, "DSNY Commercial Waste Zone:", m_san_commercial_waste_zone, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "Health Center District:", m_health_center_dist, "Hurricane Evac Zone:", m_hurricane_zone, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "School District:", m_school_dist, "DOT Street Light Area:", m_dot_st_light_contract_area, Environment.NewLine);

            // SPO(2023-04-02): GOAT_VB needs to use Courier or other fixed space font
            sb.AppendFormat("{0}{1}{2}{3}{4}", Environment.NewLine, "******************************************  ",
                             "Census Geographic Information", "  ******************************************", Environment.NewLine + Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "2020 Census Tract:", m_census_tract_2020, "2020 CDTA:", m_cdta_2020, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "2020 Census Block:", m_census_block_2020, "2020 NTA:", m_nta_2020, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "2010 Census Tract:", m_census_tract_2010, "2020 NTA Name:", "Displayed Only in webGOAT", Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "2010 Census Block:", m_census_block_2010, "2020 PUMA Code:", m_puma_2020, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "2000 Census Tract:", m_census_tract_2000, "2010 PUMA Code:", m_puma_code, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "2000 Census Block:", m_census_block_2000, "2010 NTA:", m_nta, Environment.NewLine);

            // SPO(2023-03-30): GOAT_VB needs to use Courier or other fixed space font
            sb.AppendFormat("{0}{1}{2}{3}{4}", Environment.NewLine, "******************************************  ",
                             "Election District Information", "  ******************************************", Environment.NewLine + Environment.NewLine);

            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "City Council District:", m_co, "Municipal Court District:", m_mc, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "Assembly District:", m_ad, "Election District:", m_ed, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "Congressional District:", m_cd, "State Senate District:", m_sd, Environment.NewLine);
            sb.AppendFormat("{0,-30} {1,-30} {2,-30} {3,-30}{4}", "BOE Preferred B7SC:", m_boe_preferred_b7sc.Display(), "BOE Preferred Street Name:", m_boe_preferred_stname, Environment.NewLine);

            return sb.ToString();
        }

        public VsamKey1 gridkey1
        {
            get => m_gridkey1;
            set => m_gridkey1 = value;
        }

        public string cont_parity_ind
        {
            get => m_cont_parity_ind;
            set
            {
                int strlen = value.Length;
                strlen = strlen > 1 ? 1 : strlen;
                m_cont_parity_ind = value.Substring(0, strlen);
            }
        }

        public string lo_hns
        {
            get => m_lo_hns;
            set
            {
                int strlen = value.Length;
                strlen = strlen > 11 ? 11 : strlen;
                m_lo_hns = value.Substring(0, strlen);
            }
        }

        public string hi_hns
        {
            get => m_hi_hns;
            set
            {
                int strlen = value.Length;
                strlen = strlen > 11 ? 11 : strlen;
                m_hi_hns = value.Substring(0, strlen);
            }
        }

        public string dcp_pref_lgc
        {
            get => m_dcp_pref_lgc;
            set
            {
                int strlen = value.Length;
                strlen = strlen > 2 ? 2 : strlen;
                m_dcp_pref_lgc = value.Substring(0, strlen);
            }
        }

        public string lo_x_sts_cnt
        {
            get => m_lo_x_sts_cnt;
            set
            {
                int strlen = value.Length;
                strlen = strlen > 1 ? 1 : strlen;
                m_lo_x_sts_cnt = value.Substring(0, strlen);
            }
        }

        public B5sc[] lo_x_sts
        {
            get => m_lo_x_sts;
            set => m_lo_x_sts = value;
        }

        public B5sc lo_x_sts_item(int index) => m_lo_x_sts[index];

        public void lo_x_sts_item(int index, B5sc value) => m_lo_x_sts[index] = value;
        

        public string hi_x_sts_cnt
        {
            get => m_hi_x_sts_cnt;
            set
            {
                int strlen = value.Length;
                strlen = strlen > 1 ? 1 : strlen;
                m_hi_x_sts_cnt = value.Substring(0, strlen);
            }
        }

        public B5sc[] hi_x_sts
        {
            get => m_hi_x_sts;
            set => m_hi_x_sts = value;
        }

        public B5sc hi_x_sts_item(int index) => m_hi_x_sts[index];

        public void hi_x_sts_item(int index, B5sc value ) => m_hi_x_sts[index] = value;
        

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
                strlen = strlen > 1 ? 1 : strlen;
                m_spec_addr_flag = value.Substring(0, strlen);
            }
        }

        public string sos_ind
        {
            get => m_sos_ind;
            set
            {
                int strlen = value.Length;
                strlen = strlen > 1 ? 1 : strlen;
                m_sos_ind = value.Substring(0, strlen);
            }
        }

        public string segment_len
        {
            get => m_segment_len;
            set
            {
                int strlen = value.Length;
                strlen = strlen > 5 ? 5 : strlen;
                m_segment_len = value.Substring(0, strlen);
            }
        }

        public string x_coord
        {
            get => m_x_coord;
            set
            {
                int strlen = value.Length;
                strlen = strlen > 7 ? 7 : strlen;
                m_x_coord = value.Substring(0, strlen);
            }
        }

        public string y_coord
        {
            get => m_y_coord;
            set
            {
                int strlen = value.Length;
                strlen = strlen > 7 ? 7 : strlen;
                m_y_coord = value.Substring(0, strlen);
            }
        }

        public string z_coord
        {
            get => m_z_coord;
            set
            {
                int strlen = value.Length;
                strlen = strlen > 7 ? 7 : strlen;
                m_z_coord = value.Substring(0, strlen);
            }
        }

        public string res_gss
        {
            get => m_res_gss;
            set
            {
                int strlen = value.Length;
                strlen = strlen > 1 ? 1 : strlen;
                m_res_gss = value.Substring(0, strlen);
            }
        }

        public string mh_ri_flag
        {
            get => m_mh_ri_flag;
            set
            {
                int strlen = value.Length;
                strlen = strlen > 1 ? 1 : strlen;
                m_mh_ri_flag = value.Substring(0, strlen);
            }
        }

        public string dot_st_light_contract_area
        {
            get => m_dot_st_light_contract_area;
            set
            {
                int strlen = value.Length;
                strlen = strlen > 1 ? 1 : strlen;
                m_dot_st_light_contract_area = value.Substring(0, strlen);
            }
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

        public string ed
        {
            get => m_ed;
            set => m_ed = value.Length > 3 ? value.Substring(0, 3) : value;
        }

        public string ad
        {
            get => m_ad;
            set => m_ad = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        public string split_ed
        {
            get => m_split_ed;
            set => m_split_ed = value.Length > 1 ? value.Substring(0, 1) : value;
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

        public string health_center_dist
        {
            get => m_health_center_dist;
            set => m_health_center_dist = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        public string health_area
        {
            get => m_health_area;
            set => m_health_area = value.Length > 4 ? value.Substring(0, 4) : value;
        }

        public string san_dist
        {
            get => m_san_dist;
            set => m_san_dist = value.Length > 3 ? value.Substring(0, 3) : value;
        }

        public string san_sched
        {
            get => m_san_sched;
            set => m_san_sched = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        public string san_reg
        {
            get => m_san_reg;
            set => m_san_reg = value.Length > 5 ? value.Substring(0, 5) : value;
        }

        public string san_recycle
        {
            get => m_san_recycle;
            set => m_san_recycle = value.Length > 3 ? value.Substring(0, 3) : value;
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

        public string split_school_dist_flag
        {
            get => m_split_school_dist_flag;
            set => m_split_school_dist_flag = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string school_dist
        {
            get => m_school_dist;
            set => m_school_dist = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        public string dynamic_block
        {
            get => m_dynamic_block;
            set => m_dynamic_block = value.Length > 3 ? value.Substring(0, 3) : value;
        }

        public string police_patrol_boro
        {
            get => m_police_patrol_boro;
            set => m_police_patrol_boro = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        public string feature_type
        {
            get => m_feature_type;
            set => m_feature_type = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string segment_type
        {
            get => m_segment_type;
            set => m_segment_type = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string alx
        {
            get => m_alx;
            set => m_alx = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string coincident_seg_cnt
        {
            get => m_coincident_seg_cnt;
            set => m_coincident_seg_cnt = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string filler_80ct
        {
            get => m_filler_80ct;
            set => m_filler_80ct = value.Length > 3 ? value.Substring(0, 3) : value;
        }

        public string census_tract_1990
        {
            get => m_census_tract_1990;
            set => m_census_tract_1990 = value.Length > 6 ? value.Substring(0, 6) : value;
        }

        public string census_tract_2010
        {
            get => m_census_tract_2010;
            set => m_census_tract_2010 = value.Length > 6 ? value.Substring(0, 6) : value;
        }

        public string census_block_2010
        {
            get => m_census_block_2010;
            set => m_census_block_2010 = value.Length > 4 ? value.Substring(0, 4) : value;
        }

        public string census_block_suffix_2010
        {
            get => m_census_block_suffix_2010;
            set => m_census_block_suffix_2010 = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string census_tract_2000
        {
            get => m_census_tract_2000;
            set => m_census_tract_2000 = value.Length > 6 ? value.Substring(0, 6) : value;
        }

        public string census_block_2000
        {
            get => m_census_block_2000;
            set => m_census_block_2000 = value.Length > 4 ? value.Substring(0, 4) : value;
        }

        public string census_block_suffix_2000
        {
            get => m_census_block_suffix_2000;
            set => m_census_block_suffix_2000 = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string nta
        {
            get => m_nta;
            set => m_nta = value.Length > 4 ? value.Substring(0, 4) : value;
        }

        public string dsny_snow_priority
        {
            get => m_dsny_snow_priority;
            set => m_dsny_snow_priority = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string san_org_pick_up
        {
            get => m_san_org_pick_up;
            set => m_san_org_pick_up = value.Length > 5 ? value.Substring(0, 5) : value;
        }

        public string san_bulk
        {
            get => m_san_bulk;
            set => m_san_bulk = value.Length > 5 ? value.Substring(0, 5) : value;
        }

        public string hurricane_zone
        {
            get => m_hurricane_zone;
            set => m_hurricane_zone = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        public string san_commercial_waste_zone
        {
            get => m_san_commercial_waste_zone;
            set => m_san_commercial_waste_zone = value.Length > 4 ? value.Substring(0, 4) : value;
        }

        public string filler3
        {
            get => m_filler3;
            set => m_filler3 = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        public string true_hns
        {
            get => m_true_hns;
            set => m_true_hns = value.Length > 11 ? value.Substring(0, 11) : value;
        }

        public B7sc real_b7sc
        {
            get => m_real_b7sc;
            set => m_real_b7sc = value;
        }

        public string segment_id
        {
            get => m_segment_id;
            set => m_segment_id = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        public string curve_flag
        {
            get => m_curve_flag;
            set => m_curve_flag = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string[] valid_lgcs
        {
            get => m_valid_lgcs;
            set => m_valid_lgcs = value;
        }

        public string valid_lgcs_item(int index) => m_valid_lgcs[index];
        public void valid_lgcs_item(int index, string value)  => m_valid_lgcs[index] = value.Length > 2 ? value.Substring(0, 2) : value;

        public string boe_lgc_pointer
        {
            get => m_boe_lgc_pointer;
            set => m_boe_lgc_pointer = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string segment_azm
        {
            get => m_segment_azm;
            set => m_segment_azm = value.Length > 3 ? value.Substring(0, 3) : value;
        }

        public string segment_orient
        {
            get => m_segment_orient;
            set => m_segment_orient = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string lo_x_coord
        {
            get => m_lo_x_coord;
            set => m_lo_x_coord = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        public string lo_y_coord
        {
            get => m_lo_y_coord;
            set => m_lo_y_coord = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        public string lo_z_coord
        {
            get => m_lo_z_coord;
            set => m_lo_z_coord = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        public string hi_x_coord
        {
            get => m_hi_x_coord;
            set => m_hi_x_coord = value.Length > 7 ? value.Substring(0, 7) : value;
        }
        public string hi_y_coord
        {
            get => m_hi_y_coord;
            set => m_hi_y_coord = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        public string hi_z_coord
        {
            get => m_hi_z_coord;
            set => m_hi_z_coord = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        public string curve_center_x_coord
        {
            get => m_curve_center_x_coord;
            set => m_curve_center_x_coord = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        public string curve_center_y_coord
        {
            get => m_curve_center_y_coord;
            set => m_curve_center_y_coord = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        public string curve_center_z_coord
        {
            get => m_curve_center_z_coord;
            set => m_curve_center_z_coord = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        public string circle_radius
        {
            get => m_circle_radius;
            set => m_circle_radius = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        public string secant_location
        {
            get => m_secant_location;
            set => m_secant_location = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string beta_angle
        {
            get => m_beta_angle;
            set => m_beta_angle = value.Length > 5 ? value.Substring(0, 5) : value;
        }

        public string alpha_angle
        {
            get => m_alpha_angle;
            set => m_alpha_angle = value.Length > 5 ? value.Substring(0, 5) : value;
        }

        public string from_node
        {
            get => m_from_node;
            set => m_from_node = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        public string to_node
        {
            get => m_to_node;
            set => m_to_node = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        public LionKey vanity_lion_key
        {
            get => m_vanity_lion_key;
            set => m_vanity_lion_key = value;
        }

        public string vanity_sos
        {
            get => m_vanity_sos;
            set => m_vanity_sos = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string split_lo_hns
        {
            get => m_split_lo_hns;
            set => m_split_lo_hns = value.Length > 11 ? value.Substring(0, 11) : value;
        }

        public string traffic_dir
        {
            get => m_traffic_dir;
            set => m_traffic_dir = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string turn_restrictions
        {
            get => m_turn_restrictions;
            set => m_turn_restrictions = value.Length > 10 ? value.Substring(0, 10) : value;
        }

        public string gbicurv_fraction
        {
            get => m_gbicurv_fraction;
            set => m_gbicurv_fraction = value.Length > 3 ? value.Substring(0, 3) : value;
        }

        public string roadway_type
        {
            get => m_roadway_type;
            set => m_roadway_type = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        public string physical_id
        {
            get => m_physical_id;
            set => m_physical_id = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        public string generic_id
        {
            get => m_generic_id;
            set => m_generic_id = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        public string nypd_id
        {
            get => m_nypd_id;
            set => m_nypd_id = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        public string fdny_id
        {
            get => m_fdny_id;
            set => m_fdny_id = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        public string bike_lane2
        {
            get => m_bike_lane2;
            set => m_bike_lane2 = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        public string bike_traffic_direction
        {
            get => m_bike_traffic_direction;
            set => m_bike_traffic_direction = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        public string filler03
        {
            get => m_filler03;
            set => m_filler03 = value.Length > 5 ? value.Substring(0, 5) : value;
        }

        public string street_status
        {
            get => m_street_status;
            set => m_street_status = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string street_width
        {
            get => m_street_width;
            set => m_street_width = value.Length > 3 ? value.Substring(0, 3) : value;
        }

        public string street_width_irregular
        {
            get => m_street_width_irregular;
            set => m_street_width_irregular = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string bike_lane
        {
            get => m_bike_lane;
            set => m_bike_lane = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        public string federal_classification_code
        {
            get => m_federal_classification_code;
            set => m_federal_classification_code = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        public string right_of_way_type
        {
            get => m_right_of_way_type;
            set => m_right_of_way_type = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string[] additional_valid_lgcs
        {
            get => m_additional_valid_lgcs;
            set => m_additional_valid_lgcs = value;
        }

        public string additional_valid_lgcs_item(int index) => m_additional_valid_lgcs[index];
        public void additional_valid_lgcs_item(int index, string value) => m_additional_valid_lgcs[index] = value.Length > 2 ? value.Substring(0, 2) : value;

        public string legacy_segment_id
        {
            get => m_legacy_segment_id;
            set => m_legacy_segment_id = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        public string[] from_dcp_preferred_lgcs
        {
            get => m_from_dcp_preferred_lgcs;
            set => m_from_dcp_preferred_lgcs = value;
        }

        public string from_dcp_preferred_lgcs_item(int index)  => m_from_dcp_preferred_lgcs[index];
        public void from_dcp_preferred_lgcs_item(int index, string value)  => m_from_dcp_preferred_lgcs[index] = value.Length > 2 ? value.Substring(0, 2) : value;
        

        public string[] to_dcp_preferred_lgcs
        {
            get => m_to_dcp_preferred_lgcs;
            set => m_to_dcp_preferred_lgcs = value;
        }

        public string to_dcp_preferred_lgcs_item(int index) => m_to_dcp_preferred_lgcs[index];
        public void to_dcp_preferred_lgcs_item(int index, string value) => m_to_dcp_preferred_lgcs[index] = value.Length > 2 ? value.Substring(0, 2) : value;
        

        public string[] from_additional_lgcs
        {
            get => m_from_additional_lgcs;
            set => m_from_additional_lgcs = value;
        }

        public string from_additional_lgcs_item(int index) => m_from_additional_lgcs[index];
        public void from_additional_lgcs_item(int index, string value) => m_from_additional_lgcs[index] = value.Length > 2 ? value.Substring(0, 2) : value;
        

        public string[] to_additional_lgcs
        {
            get => m_to_additional_lgcs;
            set => m_to_additional_lgcs = value;
        }

        public string to_additional_lgcs_item(int index) => m_to_additional_lgcs[index];
        public void to_additional_lgcs_item(int index, string value) => m_to_additional_lgcs[index] = value.Length > 2 ? value.Substring(0, 2) : value;
        

        public string no_cross_street_calculation_flag
        {
            get => m_no_cross_street_calculation_flag;
            set => m_no_cross_street_calculation_flag = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string individual_segment_length
        {
            get => m_individual_segment_length;
            set => m_individual_segment_length = value.Length > 5 ? value.Substring(0, 5) : value;
        }

        public string nta_name
        {
            get => m_nta_name;
            set => m_nta_name = value.Length > 4 ? value.Substring(0, 4) : value;
        }

        public string USPS_city_name
        {
            get => m_USPS_city_name;
            set => m_USPS_city_name = value.Length > 25 ? value.Substring(0, 25) : value;
        }

        public string latitude
        {
            get => m_latitude;
            set => m_latitude = value.Length > 9 ? value.Substring(0, 9) : value;
        }

        public string longitude
        {
            get => m_longitude;
            set => m_longitude = value.Length > 11 ? value.Substring(0, 11) : value;
        }

        public string seg_from_node
        {
            get => m_seg_from_node;
            set => m_seg_from_node = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        public string seg_to_node
        {
            get => m_seg_to_node;
            set => m_seg_to_node = value.Length > 7 ? value.Substring(0, 7) : value;
        }
        public string seg_from_x_coord
        {
            get => m_seg_from_x_coord;
            set => m_seg_from_x_coord = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        public string seg_from_y_coord
        {
            get => m_seg_from_y_coord;
            set => m_seg_from_y_coord = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        public string seg_from_z_coord
        {
            get => m_seg_from_z_coord;
            set => m_seg_from_z_coord = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        public string seg_to_x_coord
        {
            get => m_seg_to_x_coord;
            set => m_seg_to_x_coord = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        public string seg_to_y_coord
        {
            get => m_seg_to_y_coord;
            set => m_seg_to_y_coord = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        public string seg_to_z_coord
        {
            get => m_seg_to_z_coord;
            set => m_seg_to_z_coord = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        public string blockface_id
        {
            get => m_blockface_id;
            set => m_blockface_id = value.Length > 10 ? value.Substring(0, 10) : value;
        }

        public string No_Traveling_lanes
        {
            get => m_No_Traveling_lanes;
            set => m_No_Traveling_lanes = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        public string No_Parking_lanes
        {
            get => m_No_Parking_lanes;
            set => m_No_Parking_lanes = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        public string No_Total_Lanes
        {
            get => m_Total_Lanes;
            set => m_Total_Lanes = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        public string st_width_max
        {
            get => m_st_width_max;
            set => m_st_width_max = value.Length > 3 ? value.Substring(0, 3) : value;
        }

        public string speed_limit
        {
            get => m_speed_limit;
            set => m_speed_limit = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        public string puma_code
        {
            get => m_puma_code;
            set => m_puma_code = value.Length > 5 ? value.Substring(0, 5) : value;
        }

        public string police_sector
        {
            get => m_police_sector;
            set => m_police_sector = value.Length > 4 ? value.Substring(0, 4) : value;
        }

        public string police_area
        {
            get => m_police_area;
            set => m_police_area = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string truck_route_type
        {
            get => m_truck_route_type;
            set => m_truck_route_type = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string census_tract_2020
        {
            get => m_census_tract_2020;
            set => m_census_tract_2020 = value.Length > 6 ? value.Substring(0, 6) : value;
        }

        public string census_block_2020
        {
            get => m_census_block_2020;
            set => m_census_block_2020 = value.Length > 4 ? value.Substring(0, 4) : value;
        }

        public string census_block_suffix_2020
        {
            get => m_census_block_suffix_2020;
            set => m_census_block_suffix_2020 = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string nta_2020
        {
            get => m_nta_2020;
            set => m_nta_2020 = value.Length > 6 ? value.Substring(0, 6) : value;
        }

        public string cdta_2020
        {
            get => m_cdta_2020;
            set => m_cdta_2020 = value.Length > 4 ? value.Substring(0, 4) : value;
        }

        public string puma_2020
        {
            get => m_puma_2020;
            set => m_puma_2020 = value.Length > 5 ? value.Substring(0, 5) : value;
        }

        public string filler01
        {
            get => m_filler01;
            set => m_filler01 = value.Length > 213 ? value.Substring(0, 213) : value; // Enforced length limit
        }

        public string reason_code
        {
            get => m_reason_code;
            set => m_reason_code = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string reason_code_qualifier
        {
            get => m_reason_code_qualifier;
            set => m_reason_code_qualifier = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string warning_code
        {
            get => m_warning_code;
            set => m_warning_code = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        public string grc
        {
            get => m_grc;
            set => m_grc = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        public string lo_x_sts_cnt2
        {
            get => m_lo_x_sts_cnt2;
            set => m_lo_x_sts_cnt2 = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public B7sc[] lo_x_b7sc_list
        {
            get => m_lo_x_b7sc_list;
            set => m_lo_x_b7sc_list = value;
        }

        public B7sc lo_x_b7sc_list_item(int index) => m_lo_x_b7sc_list[index];
        public void lo_x_b7sc_list_item(int index, B7sc value) => m_lo_x_b7sc_list[index] = value;
        

        public string hi_x_sts_cnt2
        {
            get => m_hi_x_sts_cnt2;
            set => m_hi_x_sts_cnt2 = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public B7sc[] hi_x_b7sc_list
        {
            get => m_hi_x_b7sc_list;
            set => m_hi_x_b7sc_list = value;
        }

        public B7sc hi_x_b7sc_list_item(int index)  => m_hi_x_b7sc_list[index];
        public void hi_x_b7sc_list_item(int index, B7sc value) => m_hi_x_b7sc_list[index] = value;
        

        public string[] lo_x_stname_list
        {
            get => m_lo_x_stname_list;
            set => m_lo_x_stname_list = value;
        }

        public string LoXStnameListItem(int index)  => m_lo_x_stname_list[index];

        public void LoXStnameListItem(int index, string value) {

            int strlen = value.Length;
            strlen = Math.Min(strlen, 32);
            m_lo_x_stname_list[index] = new string(' ', 32);
            if (strlen > 0)
                m_lo_x_stname_list[index] = value.Substring(0, strlen).PadRight(32, ' ');

        }

        public string[] hi_x_stname_list
        {
            get => m_hi_x_stname_list;
            set => m_hi_x_stname_list = value;
        }

        public string HiXStnameListItem(int index) => m_hi_x_stname_list[index];

        public void HiXStnameListItem(int index, string value){
            int strlen = Math.Min(value.Length, 32);
            m_hi_x_stname_list[index] = new string(' ', 32);
            if (strlen > 0)
                m_hi_x_stname_list[index] = value.Substring(0, strlen).PadRight(32, ' ');
        }

        public B7sc boe_preferred_b7sc
        {
            get => m_boe_preferred_b7sc;
            set => m_boe_preferred_b7sc = value;
        }

        public string boe_preferred_stname
        {
            get => m_boe_preferred_stname;
            set
            {
                int strlen = Math.Min(value.Length, 32);
                m_boe_preferred_stname = value.Substring(0, strlen).PadRight(32, ' ');
            }
        }

        public string filler02
        {
            get => m_filler02;
            set
            {
                int strlen = Math.Min(value.Length, 52);
                m_filler02 = value.Substring(0, strlen).PadRight(52, ' ');
            }
        }


    }
}