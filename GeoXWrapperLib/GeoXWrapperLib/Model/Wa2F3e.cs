using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperLib.Model
{
    public class Wa2F3e : WA
    {
        private string m_gridkey3e;
        private string m_b5sc_dup_flag;
        private string m_cont_parity_ind;
        private string m_loc_status;
        private string m_county_boundary;
        private string m_dcp_pref_lgc1;
        private string m_dcp_pref_lgc2;
        private string m_dcp_pref_lgc3;
        private string m_lo_x_sts_cnt;
        private B7sc[] m_lo_x_sts;
        private string m_hi_x_sts_cnt;
        private B7sc[] m_hi_x_sts;
        private string m_x_street_reversal_flag;
        private LionKey m_lionkey;
        private string m_generated_record_flag;
        private string m_segment_len;
        private string m_segment_azm;
        private string m_segment_orient;
        private string m_mh_ri_flag;
        private string m_from_node;
        private string m_to_node;
        private string m_dsny_snow_priority;
        private string m_segment_id;
        private string m_dot_street_light_contract_area;
        private string m_curve_flag;
        private string m_dog_leg;
        private string m_feature_type;
        private string m_segment_type;
        private string m_coincident_seg_cnt;

        // Additional fields
        private string[] m_on_street_valid_lgcs;
        private string[] m_from_street_valid_lgcs;
        private string[] m_to_street_valid_lgcs;
        private string m_traffic_direction;
        private string m_roadway_type;
        private string m_physical_id;
        private string m_generic_id;
        private string m_nypd_id;
        private string m_fdny_id;
        private string m_street_status;
        private string m_street_width;
        private string m_street_width_irregular;
        private string m_bike_lane;
        private string m_federal_classification_code;
        private string m_right_of_way_type;
        private string[] m_on_street_additional_valid_lgcs;
        private string m_legacy_segment_id;
        private string m_from_x_coord;
        private string m_from_y_coord;
        private string m_to_x_coord;
        private string m_to_y_coord;
        private string m_from_latitude;
        private string m_from_longitude;
        private string m_to_latitude;
        private string m_to_longitude;
        private string m_No_Traveling_lanes;
        private string m_No_Parking_lanes;
        private string m_Total_Lanes;
        private string m_bike_lane2;
        private string m_st_width_max;
        private string m_bike_traffic_direction;
        private string m_speed_limit;
        private string m_truck_route_type;
        private string m_pgb_flag;
        private string m_left_puma_2020;
        private string m_right_puma_2020;
        private string m_filler05;
        private string m_filler_reserved_for_3ce_sos;
        private SegSideB7sc m_left_side;
        private SegSideB7sc m_right_side;

        public Wa2F3e()
        {
            m_gridkey3e = new string(' ', 47);
            m_b5sc_dup_flag = new string(' ', 1);
            m_cont_parity_ind = new string(' ', 1);
            m_loc_status = new string(' ', 1);
            m_county_boundary = new string(' ', 1);
            m_dcp_pref_lgc1 = new string(' ', 2);
            m_dcp_pref_lgc2 = new string(' ', 2);
            m_dcp_pref_lgc3 = new string(' ', 2);
            m_lo_x_sts_cnt = new string(' ', 1);
            m_lo_x_sts = new B7sc[5];
            m_hi_x_sts_cnt = new string(' ', 1);
            m_hi_x_sts = new B7sc[5];
            m_x_street_reversal_flag = new string(' ', 1);
            m_lionkey = new LionKey();
            m_generated_record_flag = new string(' ', 1);
            m_segment_len = new string(' ', 5);
            m_segment_azm = new string(' ', 3);
            m_segment_orient = new string(' ', 1);
            m_mh_ri_flag = new string(' ', 1);
            m_from_node = new string(' ', 7);
            m_to_node = new string(' ', 7);
            m_dsny_snow_priority = new string(' ', 1);
            m_segment_id = new string(' ', 7);
            m_dot_street_light_contract_area = new string(' ', 1);
            m_curve_flag = new string(' ', 1);
            m_dog_leg = new string(' ', 1);
            m_feature_type = new string(' ', 1);
            m_segment_type = new string(' ', 1);
            m_coincident_seg_cnt = new string(' ', 1);

            // Initialize arrays
            m_on_street_valid_lgcs = new string[4];
            m_from_street_valid_lgcs = new string[4];
            m_to_street_valid_lgcs = new string[4];
            m_traffic_direction = new string(' ', 1);
            m_roadway_type = new string(' ', 2);
            m_physical_id = new string(' ', 7);
            m_generic_id = new string(' ', 7);
            m_nypd_id = new string(' ', 7);
            m_fdny_id = new string(' ', 7);
            m_street_status = new string(' ', 1);
            m_street_width = new string(' ', 3);
            m_street_width_irregular = new string(' ', 1);
            m_bike_lane = new string(' ', 1);
            m_federal_classification_code = new string(' ', 2);
            m_right_of_way_type = new string(' ', 1);
            m_on_street_additional_valid_lgcs = new string[5];
            m_legacy_segment_id = new string(' ', 7);
            m_from_x_coord = new string(' ', 7);
            m_from_y_coord = new string(' ', 7);
            m_to_x_coord = new string(' ', 7);
            m_to_y_coord = new string(' ', 7);
            m_from_latitude = new string(' ', 9);
            m_from_longitude = new string(' ', 11);
            m_to_latitude = new string(' ', 9);
            m_to_longitude = new string(' ', 11);
            m_No_Traveling_lanes = new string(' ', 2);
            m_No_Parking_lanes = new string(' ', 2);
            m_Total_Lanes = new string(' ', 2);
            m_bike_lane2 = new string(' ', 2);
            m_st_width_max = new string(' ', 3);
            m_bike_traffic_direction = new string(' ', 2);
            m_speed_limit = new string(' ', 2);
            m_truck_route_type = new string(' ', 1);

            m_pgb_flag = new string(' ', 3);
            m_left_puma_2020 = new string(' ', 5);
            m_right_puma_2020 = new string(' ', 5);
            m_filler05 = new string(' ', 124);
            m_filler_reserved_for_3ce_sos = new string(' ', 1);

            m_left_side = new SegSideB7sc();
            m_right_side = new SegSideB7sc();
        }
        public Wa2F3e(string inString) : this() => Wa2F3eFromString(inString);
        

        /// <summary>
        /// <c>Clear</c> reinitializes the <c>Wa2F3e</c> object to spaces
        /// </summary>
        public override void Clear() => Wa2F3eFromString(new string(' ', 1000));
        

        /// <summary>
        /// <c>ToString</c> converts a <c>Wa2F3e</c> object to a string
        /// </summary>
        public override string ToString() => Wa2F3eToString();
        

        /// <summary>
        /// <c>FromString</c> converts a string to a <c>Wa2F3e</c> object
        /// </summary>
        public override void FromString(string inString) => Wa2F3eFromString(inString);


        // Add the method Wa2F3eFromString and Wa2F3eToString as needed
        public void Wa2F3eFromString(string inString)
        {
            int i;

            m_gridkey3e = inString.Substring(0, 47);
            m_b5sc_dup_flag = inString.Substring(47, 1);
            m_cont_parity_ind = inString.Substring(48, 1);
            m_loc_status = inString.Substring(49, 1);
            m_county_boundary = inString.Substring(50, 1);
            m_dcp_pref_lgc1 = inString.Substring(51, 2);
            m_dcp_pref_lgc2 = inString.Substring(53, 2);
            m_dcp_pref_lgc3 = inString.Substring(55, 2);
            m_lo_x_sts_cnt = inString.Substring(57, 1);

            for (i = 0; i <= 4; i++)
            {
                try { m_lo_x_sts[i] = new B7sc(inString.Substring(58 + (i * 8), 8)); } catch { m_lo_x_sts[i] = new B7sc(); }
            }

            m_hi_x_sts_cnt = inString.Substring(98, 1);

            for (i = 0; i <= 4; i++)
            {
                try { m_hi_x_sts[i] = new B7sc(inString.Substring(99 + (i * 8), 8)); } catch { m_hi_x_sts[i] = new B7sc(); }     
            }

            m_x_street_reversal_flag = inString.Substring(139, 1);
            m_lionkey = new LionKey(inString.Substring(140, 10));
            m_generated_record_flag = inString.Substring(150, 1);
            m_segment_len = inString.Substring(151, 5);
            m_segment_azm = inString.Substring(156, 3);
            m_segment_orient = inString.Substring(159, 1);
            m_mh_ri_flag = inString.Substring(160, 1);

            m_from_node = inString.Substring(161, 7);
            m_to_node = inString.Substring(168, 7);

            m_dsny_snow_priority = inString.Substring(175, 1);
            m_segment_id = inString.Substring(176, 7);
            m_dot_street_light_contract_area = inString.Substring(183, 1);
            m_curve_flag = inString.Substring(184, 1);
            m_dog_leg = inString.Substring(185, 1);
            m_feature_type = inString.Substring(186, 1);
            m_segment_type = inString.Substring(187, 1);

            m_coincident_seg_cnt = inString.Substring(188, 1);

            for (i = 0; i <= 3; i++)
            {
                try { m_on_street_valid_lgcs[i] = inString.Substring(189 + (i * 2), 2); } catch { m_on_street_valid_lgcs[i] = string.Empty; }
            }

            for (i = 0; i <= 3; i++)
            {
                try { m_from_street_valid_lgcs[i] = inString.Substring(197 + (i * 2), 2); } catch { m_from_street_valid_lgcs[i] = string.Empty; }
            }

            for (i = 0; i <= 3; i++)
            {
                try { m_to_street_valid_lgcs[i] = inString.Substring(205 + (i * 2), 2); } catch { m_to_street_valid_lgcs[i] = string.Empty; }
            }

            m_traffic_direction = inString.Substring(213, 1);
            m_roadway_type = inString.Substring(214, 2);
            m_physical_id = inString.Substring(216, 7);
            m_generic_id = inString.Substring(223, 7);
            m_nypd_id = inString.Substring(230, 7);
            m_fdny_id = inString.Substring(237, 7);
            m_street_status = inString.Substring(244, 1);
            m_street_width = inString.Substring(245, 3);
            m_street_width_irregular = inString.Substring(248, 1);
            m_bike_lane = inString.Substring(249, 1);
            m_federal_classification_code = inString.Substring(250, 2);
            m_right_of_way_type = inString.Substring(252, 1);

            for (i = 0; i <= 4; i++)
            {
                try { m_on_street_additional_valid_lgcs[i] = inString.Substring(253 + (i * 2), 2); } catch { m_on_street_additional_valid_lgcs[i] = string.Empty; }
            }

            m_legacy_segment_id = inString.Substring(263, 7);

            m_from_x_coord = inString.Substring(270, 7);
            m_from_y_coord = inString.Substring(277, 7);
            m_to_x_coord = inString.Substring(284, 7);
            m_to_y_coord = inString.Substring(291, 7);

            m_from_latitude = inString.Substring(298, 9);
            m_from_longitude = inString.Substring(307, 11);
            m_to_latitude = inString.Substring(318, 9);
            m_to_longitude = inString.Substring(327, 11);

            m_No_Traveling_lanes = inString.Substring(338, 2);
            m_No_Parking_lanes = inString.Substring(340, 2);
            m_Total_Lanes = inString.Substring(342, 2);

            m_bike_lane2 = inString.Substring(344, 2);
            m_st_width_max = inString.Substring(346, 3);

            m_bike_traffic_direction = inString.Substring(349, 2);

            m_speed_limit = inString.Substring(351, 2);

            m_truck_route_type = inString.Substring(353, 1);

            // Spo (2022-05-31): New 3-byte PGB_Flag, shorten filler05 by 3
            m_pgb_flag = inString.Substring(354, 3);

            // Spo (2023-03-15): Added left and right puma 2020 fields
            m_left_puma_2020 = inString.Substring(357, 5);
            m_right_puma_2020 = inString.Substring(362, 5);

            // m_filler05 = inString.Substring(354, 137);
            // m_filler05 = inString.Substring(357, 134);
            m_filler05 = inString.Substring(367, 124);

            m_filler_reserved_for_3ce_sos = inString.Substring(491, 1);

            m_left_side = new SegSideB7sc(inString.Substring(492, 254));
            m_right_side = new SegSideB7sc(inString.Substring(746, 254));
        }


        public string Wa2F3eToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(m_gridkey3e);
            sb.Append(m_b5sc_dup_flag);
            sb.Append(m_cont_parity_ind);
            sb.Append(m_loc_status);
            sb.Append(m_county_boundary);
            sb.Append(m_dcp_pref_lgc1);
            sb.Append(m_dcp_pref_lgc2);
            sb.Append(m_dcp_pref_lgc3);
            sb.Append(m_lo_x_sts_cnt);

            for (int i = 0; i <= 4; i++)
            {
                if(m_lo_x_sts[i] != null)
                    sb.Append(m_lo_x_sts[i].B7scToString());
            }

            sb.Append(m_hi_x_sts_cnt);

            for (int i = 0; i <= 4; i++)
            {
                if (m_hi_x_sts[i] != null)
                    sb.Append(m_hi_x_sts[i].B7scToString());
            }

            sb.Append(m_x_street_reversal_flag);
            sb.Append(m_lionkey.LionKeyToString());
            sb.Append(m_generated_record_flag);
            sb.Append(m_segment_len);
            sb.Append(m_segment_azm);
            sb.Append(m_segment_orient);
            sb.Append(m_mh_ri_flag);

            // Spo (2007-07-17) added m_from_node & m_to_node
            sb.Append(m_from_node);
            sb.Append(m_to_node);

            // Spo (2012-04-06): Added for Geosupport Version 11.3 / Release 12A
            sb.Append(m_dsny_snow_priority);
            sb.Append(m_segment_id);
            sb.Append(m_dot_street_light_contract_area);
            sb.Append(m_curve_flag);
            sb.Append(m_dog_leg);
            sb.Append(m_feature_type);
            sb.Append(m_segment_type);

            // Spo (2007-07-18) added m_coincident_seg_cnt
            sb.Append(m_coincident_seg_cnt);

            // Spo (2011-09-25): Geosupport v 11.0 additional fields for extended work area
            for (int i = 0; i <= 3; i++)
            {
                sb.Append(m_on_street_valid_lgcs[i]);
            }

            for (int i = 0; i <= 3; i++)
            {
                sb.Append(m_from_street_valid_lgcs[i]);
            }

            for (int i = 0; i <= 3; i++)
            {
                sb.Append(m_to_street_valid_lgcs[i]);
            }

            sb.Append(m_traffic_direction);
            sb.Append(m_roadway_type);
            sb.Append(m_physical_id);
            sb.Append(m_generic_id);
            sb.Append(m_nypd_id);
            sb.Append(m_fdny_id);
            sb.Append(m_street_status);
            sb.Append(m_street_width);
            sb.Append(m_street_width_irregular);
            sb.Append(m_bike_lane);
            sb.Append(m_federal_classification_code);
            sb.Append(m_right_of_way_type);

            // Arrays are zero based so there are 5 entries below
            for (int i = 0; i <= 4; i++)
            {
                sb.Append(m_on_street_additional_valid_lgcs[i]);
            }

            sb.Append(m_legacy_segment_id);

            // Spo (2012-07-06): Added for Geosupport Version 11.4 / Release 12B
            sb.Append(m_from_x_coord);
            sb.Append(m_from_y_coord);
            sb.Append(m_to_x_coord);
            sb.Append(m_to_y_coord);

            // Njp (2015-06-19): Added for Geosupport Version 15.3/Release 15C - Start
            sb.Append(m_from_latitude);
            sb.Append(m_from_longitude);
            sb.Append(m_to_latitude);
            sb.Append(m_to_longitude);

            // Njp (2016-02-17) 16.1 changes.
            sb.Append(m_No_Traveling_lanes);
            sb.Append(m_No_Parking_lanes);
            sb.Append(m_Total_Lanes);

            // Jgt (2016-09-27) 16.4 changes.
            sb.Append(m_bike_lane2);
            sb.Append(m_st_width_max);

            // Njp (2016-12-12) 17.1 changes
            sb.Append(m_bike_traffic_direction);
            sb.Append(m_speed_limit);

            sb.Append(m_truck_route_type);

            // Spo (2022-05-31): New 3-byte PGB_Flag
            sb.Append(m_pgb_flag);

            // Spo (2023-03-15): Added left and right puma 2020 fields
            sb.Append(m_left_puma_2020);
            sb.Append(m_right_puma_2020);

            sb.Append(m_filler05);
            sb.Append(m_filler_reserved_for_3ce_sos);

            sb.Append(m_left_side.SegSideB7scToString());
            sb.Append(m_right_side.SegSideB7scToString());

            return sb.ToString();
        }

        public override string Display(char c)
        {
            StringBuilder sb = new StringBuilder();
            int i;

            sb.Append(m_gridkey3e);
            sb.Append(c);
            sb.Append(m_b5sc_dup_flag);
            sb.Append(c);
            sb.Append(m_cont_parity_ind);
            sb.Append(c);
            sb.Append(m_loc_status);
            sb.Append(c);
            sb.Append(m_county_boundary);
            sb.Append(c);
            sb.Append(m_dcp_pref_lgc1);
            sb.Append(c);
            sb.Append(m_dcp_pref_lgc2);
            sb.Append(c);
            sb.Append(m_dcp_pref_lgc3);
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

            sb.Append(m_x_street_reversal_flag);
            sb.Append(c);
            sb.Append(m_lionkey.Display());
            sb.Append(c);
            sb.Append(m_generated_record_flag);
            sb.Append(c);
            sb.Append(m_segment_len);
            sb.Append(c);
            sb.Append(m_segment_azm);
            sb.Append(c);
            sb.Append(m_segment_orient);
            sb.Append(c);
            sb.Append(m_mh_ri_flag);
            sb.Append(c);

            sb.Append(m_from_node);
            sb.Append(c);
            sb.Append(m_to_node);
            sb.Append(c);

            // Added for Geosupport Version 11.3 / Release 12A
            sb.Append(m_dsny_snow_priority);
            sb.Append(c);
            sb.Append(m_segment_id);
            sb.Append(c);
            sb.Append(m_dot_street_light_contract_area);
            sb.Append(c);
            sb.Append(m_curve_flag);
            sb.Append(c);
            sb.Append(m_dog_leg);
            sb.Append(c);
            sb.Append(m_feature_type);
            sb.Append(c);
            sb.Append(m_segment_type);
            sb.Append(c);

            sb.Append(m_coincident_seg_cnt);
            sb.Append(c);

            // Geosupport v 11.0 additional fields for extended work area
            for (i = 0; i <= 3; i++)
            {
                sb.Append(m_on_street_valid_lgcs[i]);
                sb.Append(c);
            }

            for (i = 0; i <= 3; i++)
            {
                sb.Append(m_from_street_valid_lgcs[i]);
                sb.Append(c);
            }

            for (i = 0; i <= 3; i++)
            {
                sb.Append(m_to_street_valid_lgcs[i]);
                sb.Append(c);
            }

            sb.Append(m_traffic_direction);
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

            // Arrays are zero based so there are 5 entries below
            for (i = 0; i <= 4; i++)
            {
                sb.Append(m_on_street_additional_valid_lgcs[i]);
                sb.Append(c);
            }

            sb.Append(m_legacy_segment_id);
            sb.Append(c);

            // Added for Geosupport Version 11.4 / Release 12B
            sb.Append(m_from_x_coord);
            sb.Append(c);
            sb.Append(m_from_y_coord);
            sb.Append(c);
            sb.Append(m_to_x_coord);
            sb.Append(c);
            sb.Append(m_to_y_coord);
            sb.Append(c);

            // Added for Geosupport Version 15.3/Release 15C
            sb.Append(c);
            sb.Append(m_from_latitude);
            sb.Append(c);
            sb.Append(m_from_longitude);
            sb.Append(c);
            sb.Append(m_to_latitude);
            sb.Append(c);
            sb.Append(m_to_longitude);
            sb.Append(c);

            // Geosupport 16.1 changes
            sb.Append(m_No_Traveling_lanes);
            sb.Append(c);
            sb.Append(m_No_Parking_lanes);
            sb.Append(c);
            sb.Append(m_Total_Lanes);
            sb.Append(c);

            // Geosupport 16.4 changes
            sb.Append(m_bike_lane2);
            sb.Append(c);
            sb.Append(m_st_width_max);
            sb.Append(c);

            // Geosupport 17.1 changes
            sb.Append(m_bike_traffic_direction);
            sb.Append(c);

            // Added new speed_limit field for Release 17D
            sb.Append(m_speed_limit);
            sb.Append(c);

            sb.Append(m_truck_route_type);
            sb.Append(c);

            // New 3-byte PGB_Flag, shorten filler05 by 3
            sb.Append(m_pgb_flag);
            sb.Append(c);

            // Added left and right puma 2020 fields
            sb.Append(m_left_puma_2020);
            sb.Append(c);
            sb.Append(m_right_puma_2020);
            sb.Append(c);

            // Added 2 new 5 byte puma_code for Geosupport version 18.1 
            sb.Append(m_filler05);
            sb.Append(c);

            sb.Append(m_filler_reserved_for_3ce_sos);
            sb.Append(c);

            sb.Append(m_left_side);
            sb.Append(c);
            sb.Append(m_right_side);
            sb.Append(c);

            return sb.ToString();
        }
        public override string Display()
        {
            return this.Display('-');
        }

        public override string Print()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("gridkey3e = {0}{1}", m_gridkey3e, Environment.NewLine);
            sb.AppendFormat("b5sc_dup_flag = {0}{1}", m_b5sc_dup_flag, Environment.NewLine);
            sb.AppendFormat("cont_parity_ind = {0}{1}", m_cont_parity_ind, Environment.NewLine);
            sb.AppendFormat("loc_status = {0}{1}", m_loc_status, Environment.NewLine);
            sb.AppendFormat("county_boundary = {0}{1}", m_county_boundary, Environment.NewLine);
            sb.AppendFormat("dcp_pref_lgc1 = {0}{1}", m_dcp_pref_lgc1, Environment.NewLine);
            sb.AppendFormat("dcp_pref_lgc2 = {0}{1}", m_dcp_pref_lgc2, Environment.NewLine);
            sb.AppendFormat("dcp_pref_lgc3 = {0}{1}", m_dcp_pref_lgc3, Environment.NewLine);
            sb.AppendFormat("lo_x_sts_cnt = {0}{1}", m_lo_x_sts_cnt, Environment.NewLine);

            for (int i = 0; i <= 4; i++)
            {
                sb.AppendFormat("lo_x_sts({0}) = {1}{2}", i, m_lo_x_sts[i].Display(), Environment.NewLine);
            }

            sb.AppendFormat("hi_x_sts_cnt = {0}{1}", m_hi_x_sts_cnt, Environment.NewLine);

            for (int i = 0; i <= 4; i++)
            {
                sb.AppendFormat("hi_x_sts({0}) = {1}{2}", i, m_hi_x_sts[i].Display(), Environment.NewLine);
            }

            sb.AppendFormat("x_street_reversal_flag = {0}{1}", m_x_street_reversal_flag, Environment.NewLine);
            sb.AppendFormat("lionkey = {0}{1}", m_lionkey.Display(), Environment.NewLine);
            sb.AppendFormat("generated_record_flag = {0}{1}", m_generated_record_flag, Environment.NewLine);
            sb.AppendFormat("segment_len = {0}{1}", m_segment_len, Environment.NewLine);
            sb.AppendFormat("segment_azm = {0}{1}", m_segment_azm, Environment.NewLine);
            sb.AppendFormat("segment_orient = {0}{1}", m_segment_orient, Environment.NewLine);
            sb.AppendFormat("mh_ri_flag = {0}{1}", m_mh_ri_flag, Environment.NewLine);

            sb.AppendFormat("from_node = {0}{1}", m_from_node, Environment.NewLine); 
            sb.AppendFormat("to_node = {0}{1}", m_to_node, Environment.NewLine);

            sb.AppendFormat("dsny_snow_priority = {0}{1}", m_dsny_snow_priority, Environment.NewLine);
            sb.AppendFormat("segment_id = {0}{1}", m_segment_id, Environment.NewLine);
            sb.AppendFormat("dot_street_light_contract_area = {0}{1}", m_dot_street_light_contract_area, Environment.NewLine);
            sb.AppendFormat("curve_flag = {0}{1}", m_curve_flag, Environment.NewLine);
            sb.AppendFormat("dog_leg = {0}{1}", m_dog_leg, Environment.NewLine);
            sb.AppendFormat("feature_type = {0}{1}", m_feature_type, Environment.NewLine);
            sb.AppendFormat("segment_type = {0}{1}", m_segment_type, Environment.NewLine);
            sb.AppendFormat("coincident_seg_cnt = {0}{1}", m_coincident_seg_cnt, Environment.NewLine);

            for (int i = 0; i <= 3; i++)
            {
                sb.AppendFormat("on_street_valid_lgcs({0}) = {1}{2}", i, m_on_street_valid_lgcs[i], Environment.NewLine);
            }

            for (int i = 0; i <= 3; i++)
            {
                sb.AppendFormat("from_street_valid_lgcs({0}) = {1}{2}", i, m_from_street_valid_lgcs[i], Environment.NewLine);
            }

            for (int i = 0; i <= 3; i++)
            {
                sb.AppendFormat("to_street_valid_lgcs({0}) = {1}{2}", i, m_to_street_valid_lgcs[i], Environment.NewLine);
            }

            sb.AppendFormat("traffic_direction = {0}{1}", m_traffic_direction, Environment.NewLine);
            sb.AppendFormat("roadway_type = {0}{1}", m_roadway_type, Environment.NewLine);
            sb.AppendFormat("physical_id = {0}{1}", m_physical_id, Environment.NewLine);
            sb.AppendFormat("generic_id = {0}{1}", m_generic_id, Environment.NewLine);
            sb.AppendFormat("nypd_id = {0}{1}", m_nypd_id, Environment.NewLine);
            sb.AppendFormat("fdny_id = {0}{1}", m_fdny_id, Environment.NewLine);
            sb.AppendFormat("street_status = {0}{1}", m_street_status, Environment.NewLine);
            sb.AppendFormat("street_width = {0}{1}", m_street_width, Environment.NewLine);
            sb.AppendFormat("street_width_irregular = {0}{1}", m_street_width_irregular, Environment.NewLine);
            sb.AppendFormat("bike_lane = {0}{1}", m_bike_lane, Environment.NewLine);
            sb.AppendFormat("federal_classification_code = {0}{1}", m_federal_classification_code, Environment.NewLine);
            sb.AppendFormat("right_of_way_type = {0}{1}", m_right_of_way_type, Environment.NewLine);

            for (int i = 0; i <= 4; i++)
            {
                sb.AppendFormat("on_street_additional_valid_lgcs({0}) = {1}{2}", i, m_on_street_additional_valid_lgcs[i], Environment.NewLine);
            }

            sb.AppendFormat("legacy_segment_id = {0}{1}", m_legacy_segment_id, Environment.NewLine);
            sb.AppendFormat("from_x_coord = {0}{1}", m_from_x_coord, Environment.NewLine);
            sb.AppendFormat("from_y_coord = {0}{1}", m_from_y_coord, Environment.NewLine);
            sb.AppendFormat("to_x_coord = {0}{1}", m_to_x_coord, Environment.NewLine);
            sb.AppendFormat("to_y_coord = {0}{1}", m_to_y_coord, Environment.NewLine);

            sb.AppendFormat("from_latitude = {0}{1}", m_from_latitude, Environment.NewLine);
            sb.AppendFormat("from_longitude = {0}{1}", m_from_longitude, Environment.NewLine);
            sb.AppendFormat("to_latitude = {0}{1}", m_to_latitude, Environment.NewLine);
            sb.AppendFormat("to_longitude = {0}{1}", m_to_longitude, Environment.NewLine);

            sb.AppendFormat("No_Traveling_lanes = {0}{1}", m_No_Traveling_lanes, Environment.NewLine);
            sb.AppendFormat("No_Parking_lanes = {0}{1}", m_No_Parking_lanes, Environment.NewLine);
            sb.AppendFormat("Total_Lanes = {0}{1}", m_Total_Lanes, Environment.NewLine);

            sb.AppendFormat("bike_lane2 = {0}{1}", m_bike_lane2, Environment.NewLine);
            sb.AppendFormat("street_width_maximum = {0}{1}", m_st_width_max, Environment.NewLine);

            sb.AppendFormat("bike_traffic_direction = {0}{1}", m_bike_traffic_direction, Environment.NewLine);

            sb.AppendFormat("speed_limit = {0}{1}", m_speed_limit, Environment.NewLine);
            sb.AppendFormat("truck_route_type = {0}{1}", m_truck_route_type, Environment.NewLine);

            sb.AppendFormat("pgb_flag = {0}{1}", m_pgb_flag, Environment.NewLine);

            sb.AppendFormat("left_puma_2020 = {0}{1}", m_left_puma_2020, Environment.NewLine);
            sb.AppendFormat("right_puma_2020 = {0}{1}", m_right_puma_2020, Environment.NewLine);

            sb.AppendFormat("filler05 = {0}{1}", m_filler05, Environment.NewLine);
            sb.AppendFormat("filler_reserved_for_3ce_sos = {0}{1}", m_filler_reserved_for_3ce_sos, Environment.NewLine);

            sb.AppendFormat("********************************************* {0}", Environment.NewLine);
            sb.AppendFormat("left_side (display) = {0}{1}", m_left_side.Display(), Environment.NewLine);
            sb.AppendFormat("********************************************* {0}", Environment.NewLine);
            sb.AppendFormat("left_side (print) = {0}", Environment.NewLine);
            sb.AppendFormat("{0}", m_left_side.Print());
            sb.AppendFormat("********************************************* {0}", Environment.NewLine);
            sb.AppendFormat("right_side (display) = {0}{1}", m_right_side.Display(), Environment.NewLine);
            sb.AppendFormat("********************************************* {0}", Environment.NewLine);
            sb.AppendFormat("right_side (print) = {0}", Environment.NewLine);
            sb.AppendFormat("{0}", m_right_side.Print());
            sb.AppendFormat("********************************************* {0}", Environment.NewLine);

            return sb.ToString();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            int i;

            sb.AppendLine();
            sb.AppendLine("****************************************************************************");
            sb.AppendLine("******************************  Wa2F3e  ************************************");
            sb.AppendLine("****************************************************************************");

            sb.AppendLine();
            sb.AppendLine("**********  Key Information  **********");
            sb.AppendLine();

            sb.AppendFormat("gridkey3e = {0}{1}", m_gridkey3e, Environment.NewLine);
            sb.AppendFormat("b5sc_dup_flag = {0}{1}", m_b5sc_dup_flag, Environment.NewLine);
            sb.AppendFormat("cont_parity_ind = {0}{1}", m_cont_parity_ind, Environment.NewLine);
            sb.AppendFormat("loc_status = {0}{1}", m_loc_status, Environment.NewLine);
            sb.AppendFormat("county_boundary = {0}{1}", m_county_boundary, Environment.NewLine);
            // SPO(2022-05-31): New 3-byte PGB_Flag, shorten filler05 by 3
            sb.AppendFormat("pgb_flag = {0}{1}", m_pgb_flag, Environment.NewLine);

            sb.AppendLine();

            sb.AppendFormat("dcp_pref_lgc1 = {0}{1}", m_dcp_pref_lgc1, Environment.NewLine);
            sb.AppendFormat("dcp_pref_lgc2 = {0}{1}", m_dcp_pref_lgc2, Environment.NewLine);
            sb.AppendFormat("dcp_pref_lgc3 = {0}{1}", m_dcp_pref_lgc3, Environment.NewLine);

            sb.AppendLine();

            for (i = 0; i < 4; i++)
            {
                sb.AppendFormat("on_street_valid_lgcs({0}) = {1}{2}", i, m_on_street_valid_lgcs[i], Environment.NewLine);
            }

            sb.AppendLine();

            for (i = 0; i < 5; i++)
            {
                sb.AppendFormat("on_street_additional_valid_lgcs({0}) = {1}{2}", i, m_on_street_additional_valid_lgcs[i], Environment.NewLine);
            }

            sb.AppendLine();
            sb.AppendLine("**********  Geographic Information  **********");
            sb.AppendLine();

            sb.AppendFormat("segment_id = {0}{1}", m_segment_id, Environment.NewLine);
            sb.AppendFormat("legacy_segment_id = {0}{1}", m_legacy_segment_id, Environment.NewLine);
            sb.AppendFormat("physical_id = {0}{1}", m_physical_id, Environment.NewLine);
            sb.AppendFormat("generic_id = {0}{1}", m_generic_id, Environment.NewLine);
            sb.AppendFormat("nypd_id = {0}{1}", m_nypd_id, Environment.NewLine);
            sb.AppendFormat("fdny_id = {0}{1}", m_fdny_id, Environment.NewLine);

            sb.AppendLine();

            sb.AppendFormat("from_node = {0}{1}", m_from_node, Environment.NewLine);
            sb.AppendFormat("to_node = {0}{1}", m_to_node, Environment.NewLine);

            sb.AppendLine();

            sb.AppendFormat("from_x_coord = {0}{1}", m_from_x_coord, Environment.NewLine);
            sb.AppendFormat("from_y_coord = {0}{1}", m_from_y_coord, Environment.NewLine);

            sb.AppendLine();

            sb.AppendFormat("to_x_coord = {0}{1}", m_to_x_coord, Environment.NewLine);
            sb.AppendFormat("to_y_coord = {0}{1}", m_to_y_coord, Environment.NewLine);

            sb.AppendLine();

            sb.AppendFormat("from_latitude = {0}{1}", m_from_latitude, Environment.NewLine);
            sb.AppendFormat("from_longitude = {0}{1}", m_from_longitude, Environment.NewLine);

            sb.AppendLine();

            sb.AppendFormat("to_latitude = {0}{1}", m_to_latitude, Environment.NewLine);
            sb.AppendFormat("to_longitude = {0}{1}", m_to_longitude, Environment.NewLine);

            sb.AppendLine();

            sb.AppendFormat("lionkey = {0}{1}", m_lionkey.Display(), Environment.NewLine);
            sb.AppendFormat("generated_record_flag = {0}{1}", m_generated_record_flag, Environment.NewLine);
            sb.AppendFormat("segment_len = {0}{1}", m_segment_len, Environment.NewLine);
            sb.AppendFormat("segment_azm = {0}{1}", m_segment_azm, Environment.NewLine);
            sb.AppendFormat("segment_orient = {0}{1}", m_segment_orient, Environment.NewLine);
            sb.AppendFormat("mh_ri_flag = {0}{1}", m_mh_ri_flag, Environment.NewLine);
            sb.AppendFormat("curve_flag = {0}{1}", m_curve_flag, Environment.NewLine);
            sb.AppendFormat("dog_leg = {0}{1}", m_dog_leg, Environment.NewLine);
            sb.AppendFormat("feature_type = {0}{1}", m_feature_type, Environment.NewLine);
            sb.AppendFormat("segment_type = {0}{1}", m_segment_type, Environment.NewLine);
            sb.AppendFormat("coincident_seg_cnt = {0}{1}", m_coincident_seg_cnt, Environment.NewLine);
            sb.AppendFormat("traffic_direction = {0}{1}", m_traffic_direction, Environment.NewLine);
            sb.AppendFormat("roadway_type = {0}{1}", m_roadway_type, Environment.NewLine);

            sb.AppendFormat("truck_route_type = {0}{1}", m_truck_route_type, Environment.NewLine);

            sb.AppendFormat("street_status = {0}{1}", m_street_status, Environment.NewLine);
            sb.AppendFormat("street_width = {0}{1}", m_street_width, Environment.NewLine);
            sb.AppendFormat("street_width_irregular = {0}{1}", m_street_width_irregular, Environment.NewLine);
            sb.AppendFormat("bike_lane = {0}{1}", m_bike_lane, Environment.NewLine);
            sb.AppendFormat("federal_classification_code = {0}{1}", m_federal_classification_code, Environment.NewLine);
            sb.AppendFormat("right_of_way_type = {0}{1}", m_right_of_way_type, Environment.NewLine);
            sb.AppendFormat("No_Traveling_lanes = {0}{1}", m_No_Traveling_lanes, Environment.NewLine);
            sb.AppendFormat("No_Parking_lanes = {0}{1}", m_No_Parking_lanes, Environment.NewLine);
            sb.AppendFormat("Total_Lanes = {0}{1}", m_Total_Lanes, Environment.NewLine);
            sb.AppendFormat("bike_lane2 = {0}{1}", m_bike_lane2, Environment.NewLine);
            sb.AppendFormat("street_width_maximum = {0}{1}", m_st_width_max, Environment.NewLine);
            sb.AppendFormat("bike_traffic_direction = {0}{1}", m_bike_traffic_direction, Environment.NewLine);
            // SPO(2017-09-29): Added new speed_limit 2 byte field for Release 17D
            sb.AppendFormat("speed_limit = {0}{1}", m_speed_limit, Environment.NewLine);

            sb.AppendLine();
            sb.AppendLine("**********  Other District Information  **********");

            // NSHAH(2019-07-05) Replaced m_filler_01 with m_dsny_snow_priority
            sb.AppendFormat("dsny_snow_priority = {0}{1}", m_dsny_snow_priority, Environment.NewLine);
            sb.AppendFormat("dot_street_light_contract_area = {0}{1}", m_dot_street_light_contract_area, Environment.NewLine);

            sb.AppendLine();
            sb.AppendLine("**********  Cross Streets Information  **********");

            sb.AppendFormat("x_street_reversal_flag = {0}{1}", m_x_street_reversal_flag, Environment.NewLine);

            sb.AppendLine();

            sb.AppendFormat("lo_x_sts_cnt = {0}{1}", m_lo_x_sts_cnt, Environment.NewLine);
            for (i = 0; i < 5; i++)
            {
                sb.AppendFormat("lo_x_sts({0}) = {1}{2}", i, m_lo_x_sts[i].Display(), Environment.NewLine);
            }

            sb.AppendLine();

            for (i = 0; i < 4; i++)
            {
                sb.AppendFormat("from_street_valid_lgcs({0}) = {1}{2}", i, m_from_street_valid_lgcs[i], Environment.NewLine);
            }

            sb.AppendLine();

            sb.AppendFormat("hi_x_sts_cnt = {0}{1}", m_hi_x_sts_cnt, Environment.NewLine);
            for (i = 0; i < 5; i++)
            {
                sb.AppendFormat("hi_x_sts({0}) = {1}{2}", i, m_hi_x_sts[i].Display(), Environment.NewLine);
            }

            sb.AppendLine();

            for (i = 0; i < 4; i++)
            {
                sb.AppendFormat("to_street_valid_lgcs({0}) = {1}{2}", i, m_to_street_valid_lgcs[i], Environment.NewLine);
            }

            sb.AppendLine();

            sb.AppendLine("*********************************************");
            sb.AppendLine("LEFT SIDE");
            sb.AppendLine("*********************************************");
            sb.AppendLine(m_left_side.Print());
            //------------------------------------------------------------------
            sb.AppendFormat("left_puma_2020 = {0}{1}", m_left_puma_2020, Environment.NewLine);

            sb.AppendLine();

            sb.AppendFormat("********************************************* {0}", Environment.NewLine);
            sb.AppendFormat("RIGHT SIDE {0}", Environment.NewLine);
            sb.AppendFormat("********************************************* {0}", Environment.NewLine);
            sb.AppendFormat("{0}", m_right_side.Print);
            sb.AppendFormat("right_puma_2020 = {0}{1}", m_right_puma_2020, Environment.NewLine);

            sb.AppendLine();

            sb.AppendLine();
            sb.AppendLine("**********  Miscellaneous Filler Information  **********");

            sb.AppendFormat("filler05 = {0}{1}", m_filler05, Environment.NewLine);
            sb.AppendLine();

            sb.AppendFormat("filler_reserved_for_3ce_sos = {0}{1}", m_filler_reserved_for_3ce_sos, Environment.NewLine);
            sb.AppendLine();

            return sb.ToString();
        }
        public string gridkey3e
        {
            get => m_gridkey3e;
            set
            {
                int strlen = value.Length > 47 ? 47 : value.Length;
                m_gridkey3e = value.Substring(0, strlen);
            }
        }

        public string cont_parity_ind
        {
            get => m_cont_parity_ind;
            set
            {
                int strlen = value.Length > 1 ? 1 : value.Length;
                m_cont_parity_ind = value.Substring(0, strlen);
            }
        }

        public string b5sc_dup_flag
        {
            get => m_b5sc_dup_flag;
            set
            {
                int strlen = value.Length > 1 ? 1 : value.Length;
                m_b5sc_dup_flag = value.Substring(0, strlen);
            }
        }

        public string loc_status
        {
            get => m_loc_status;
            set
            {
                int strlen = value.Length > 1 ? 1 : value.Length;
                m_loc_status = value.Substring(0, strlen);
            }
        }

        public string county_boundary
        {
            get => m_county_boundary;
            set
            {
                int strlen = value.Length > 1 ? 1 : value.Length;
                m_county_boundary = value.Substring(0, strlen);
            }
        }

        public string dcp_pref_lgc1
        {
            get => m_dcp_pref_lgc1;
            set
            {
                int strlen = value.Length > 2 ? 2 : value.Length;
                m_dcp_pref_lgc1 = value.Substring(0, strlen);
            }
        }

        public string dcp_pref_lgc2
        {
            get => m_dcp_pref_lgc2;
            set
            {
                int strlen = value.Length > 2 ? 2 : value.Length;
                m_dcp_pref_lgc2 = value.Substring(0, strlen);
            }
        }

        public string dcp_pref_lgc3
        {
            get => m_dcp_pref_lgc3;
            set
            {
                int strlen = value.Length > 2 ? 2 : value.Length;
                m_dcp_pref_lgc3 = value.Substring(0, strlen);
            }
        }

        public string lo_x_sts_cnt
        {
            get => m_lo_x_sts_cnt;
            set
            {
                int strlen = value.Length > 1 ? 1 : value.Length;
                m_lo_x_sts_cnt = value.Substring(0, strlen);
            }
        }

        public B7sc[] lo_x_sts
        {
            get => m_lo_x_sts;
            set => m_lo_x_sts = value;
        }

        public B7sc lo_x_sts_item(int index) => m_lo_x_sts[index];

        public void lo_x_sts_item(int index, B7sc value) => m_lo_x_sts[index] = value;
        

        public string hi_x_sts_cnt
        {
            get => m_hi_x_sts_cnt;
            set
            {
                int strlen = value.Length > 1 ? 1 : value.Length;
                m_hi_x_sts_cnt = value.Substring(0, strlen);
            }
        }

        public B7sc[] hi_x_sts
        {
            get => m_hi_x_sts;
            set => m_hi_x_sts = value;
        }

        public B7sc hi_x_sts_item(int index) => m_hi_x_sts[index];

        public void hi_x_sts_item(int index, B7sc value) => m_hi_x_sts[index] = value;
        

        public string x_street_reversal_flag
        {
            get => m_x_street_reversal_flag;
            set
            {
                int strlen = value.Length > 1 ? 1 : value.Length;
                m_x_street_reversal_flag = value.Substring(0, strlen);
            }
        }

        public LionKey lionkey
        {
            get => m_lionkey;
            set => m_lionkey = value;
        }

        public string generated_record_flag
        {
            get => m_generated_record_flag;
            set
            {
                int strlen = value.Length > 1 ? 1 : value.Length;
                m_generated_record_flag = value.Substring(0, strlen);
            }
        }

        public string segment_len
        {
            get => m_segment_len;
            set
            {
                int strlen = value.Length > 5 ? 5 : value.Length;
                m_segment_len = value.Substring(0, strlen);
            }
        }

        public string segment_azm
        {
            get => m_segment_azm;
            set
            {
                int strlen = value.Length > 3 ? 3 : value.Length;
                m_segment_azm = value.Substring(0, strlen);
            }
        }

        public string segment_orient
        {
            get => m_segment_orient;
            set
            {
                int strlen = value.Length > 1 ? 1 : value.Length;
                m_segment_orient = value.Substring(0, strlen);
            }
        }

        public string mh_ri_flag
        {
            get => m_mh_ri_flag;
            set
            {
                int strlen = value.Length > 1 ? 1 : value.Length;
                m_mh_ri_flag = value.Substring(0, strlen);
            }
        }

        public string from_node
        {
            get => m_from_node;
            set
            {
                int strlen = value.Length > 7 ? 7 : value.Length;
                m_from_node = value.Substring(0, strlen);
            }
        }

        public string to_node
        {
            get => m_to_node;
            set
            {
                int strlen = value.Length > 7 ? 7 : value.Length;
                m_to_node = value.Substring(0, strlen);
            }
        }

        public string dsny_snow_priority
        {
            get => m_dsny_snow_priority;
            set
            {
                int strlen = value.Length > 1 ? 1 : value.Length;
                m_dsny_snow_priority = value.Substring(0, strlen);
            }
        }

        public string segment_id
        {
            get => m_segment_id;
            set
            {
                int strlen = value.Length > 7 ? 7 : value.Length;
                m_segment_id = value.Substring(0, strlen);
            }
        }

        public string dot_street_light_contract_area
        {
            get => m_dot_street_light_contract_area;
            set
            {
                int strlen = value.Length > 1 ? 1 : value.Length;
                m_dot_street_light_contract_area = value.Substring(0, strlen);
            }
        }

        public string curve_flag
        {
            get => m_curve_flag;
            set
            {
                int strlen = value.Length > 1 ? 1 : value.Length;
                m_curve_flag = value.Substring(0, strlen);
            }
        }

        public string dog_leg
        {
            get => m_dog_leg;
            set
            {
                int strlen = value.Length > 1 ? 1 : value.Length;
                m_dog_leg = value.Substring(0, strlen);
            }
        }

        public string feature_type
        {
            get => m_feature_type;
            set
            {
                int strlen = value.Length > 1 ? 1 : value.Length;
                m_feature_type = value.Substring(0, strlen);
            }
        }

        public string segment_type
        {
            get => m_segment_type;
            set
            {
                int strlen = value.Length > 1 ? 1 : value.Length;
                m_segment_type = value.Substring(0, strlen);
            }
        }

        public string coincident_seg_cnt
        {
            get => m_coincident_seg_cnt;
            set => m_coincident_seg_cnt = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string[] on_street_valid_lgcs
        {
            get => m_on_street_valid_lgcs;
            set => m_on_street_valid_lgcs = value;
        }

        public string[] from_street_valid_lgcs
        {
            get => m_from_street_valid_lgcs;
            set => m_from_street_valid_lgcs = value;
        }

        public string[] to_street_valid_lgcs
        {
            get => m_to_street_valid_lgcs;
            set => m_to_street_valid_lgcs = value;
        }

        public string traffic_direction
        {
            get => m_traffic_direction;
            set => m_traffic_direction = value.Length > 2 ? value.Substring(0, 2) : value;
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
            set => m_bike_lane = value.Length > 1 ? value.Substring(0, 1) : value;
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

        public string[] on_street_additional_valid_lgcs
        {
            get => m_on_street_additional_valid_lgcs;
            set => m_on_street_additional_valid_lgcs = value;
        }

        public string on_street_additional_valid_lgcs_item(int index) => m_on_street_additional_valid_lgcs[index];

        public void on_street_additional_valid_lgcs_item(int index, string value) => m_on_street_additional_valid_lgcs[index] = value.Length > 2 ? value.Substring(0, 2) : value;
        

        public string legacy_segment_id
        {
            get => m_legacy_segment_id;
            set => m_legacy_segment_id = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        public string from_x_coord
        {
            get => m_from_x_coord;
            set => m_from_x_coord = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        public string from_y_coord
        {
            get => m_from_y_coord;
            set => m_from_y_coord = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        public string to_x_coord
        {
            get => m_to_x_coord;
            set => m_to_x_coord = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        public string to_y_coord
        {
            get => m_to_y_coord;
            set => m_to_y_coord = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        public string from_latitude
        {
            get => m_from_latitude;
            set => m_from_latitude = value.Length > 9 ? value.Substring(0, 9) : value;
        }

        public string from_longitude
        {
            get => m_from_longitude;
            set => m_from_longitude = value.Length > 11 ? value.Substring(0, 11) : value;
        }

        public string to_latitude
        {
            get => m_to_latitude;
            set => m_to_latitude = value.Length > 9 ? value.Substring(0, 9) : value;
        }

        public string to_longitude
        {
            get => m_to_longitude;
            set => m_to_longitude = value.Length > 11 ? value.Substring(0, 11) : value;
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

        public string Total_Lanes
        {
            get => m_Total_Lanes;
            set => m_Total_Lanes = value.Length > 2 ? value.Substring(0, 2) : value;
        }
        // jgt(2016-09-27) 16.4 changes.
        public string bike_lane2
        {
            get => m_bike_lane2;
            set => m_bike_lane2 = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        public string st_width_max
        {
            get => m_st_width_max;
            set => m_st_width_max = value.Length > 3 ? value.Substring(0, 3) : value;
        }

        // njp(2016-12-12) 17.1 changes
        public string bike_traffic_direction
        {
            get => m_bike_traffic_direction;
            set => m_bike_traffic_direction = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        // SPO(2017-09-29): Added new speed_limit 2 byte field for Release 17D
        // Requires that I reduce m_filler04 by 2 bytes
        public string speed_limit
        {
            get => m_speed_limit;
            set => m_speed_limit = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        public string truck_route_type
        {
            get => m_truck_route_type;
            set => m_truck_route_type = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        // SPO(2022-05-31): New 3-byte PGB_Flag, shorten filler05 by 3
        public string pgb_flag
        {
            get => m_pgb_flag;
            set => m_pgb_flag = value.Length > 3 ? value.Substring(0, 3) : value;
        }

        // spo(2023-03-15): added left and right puma 2020 fields
        public string left_puma_2020
        {
            get => m_left_puma_2020;
            set => m_left_puma_2020 = value.Length > 5 ? value.Substring(0, 5) : value;
        }

        public string right_puma_2020
        {
            get => m_right_puma_2020;
            set => m_right_puma_2020 = value.Length > 5 ? value.Substring(0, 5) : value;
        }

        public string filler05
        {
            get => m_filler05;
            set => m_filler05 = value.Length > 124 ? value.Substring(0, 124) : value;
        }

        public string filler_reserved_for_3ce_sos
        {
            get => m_filler_reserved_for_3ce_sos;
            set => m_filler_reserved_for_3ce_sos = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public SegSideB7sc left_side
        {
            get => m_left_side;
            set => m_left_side = value;
        }

        public SegSideB7sc right_side
        {
            get => m_right_side;
            set => m_right_side = value;
        }


    }

}
