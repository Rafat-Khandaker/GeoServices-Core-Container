using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperLib.Model
{
    public class Wa2F3cx : WA
    {
        private string m_gridkey3;
        private string m_cont_parity_ind;
        private string m_loc_status;
        private string m_county_boundary;
        private string m_dcp_pref_lgc1;
        private string m_dcp_pref_lgc2;
        private string m_dcp_pref_lgc3;
        private string m_lo_x_sts_cnt;
        private B5sc[] m_lo_x_sts = new B5sc[5];
        private string m_hi_x_sts_cnt;
        private B5sc[] m_hi_x_sts = new B5sc[5];
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
        private string m_filler01;
        private string m_segment_id;
        private string m_dot_street_light_contract_area;
        private string m_sos_ind;
        private string m_curve_flag;
        private string m_feature_type;
        private string m_segment_type;
        private string m_coincident_seg_cnt;
        private string m_pgb_flag;
        private string m_filler02;
        private SegSide m_seg_side;
        private string[] m_on_street_valid_lgcs = new string[4];
        private string[] m_from_street_valid_lgcs = new string[4];
        private string[] m_to_street_valid_lgcs = new string[4];
        private string m_left_health_center_dist;
        private string m_right_health_center_dist;
        private string m_filler03;
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
        private string[] m_on_street_additional_valid_lgcs = new string[5];
        private string m_legacy_segment_id;
        private string m_nta_name;
        private string m_from_x_coord;
        private string m_from_y_coord;
        private string m_to_x_coord;
        private string m_to_y_coord;
        private string m_from_latitude;
        private string m_from_longitude;
        private string m_to_latitude;
        private string m_to_longitude;
        private string m_blockface_id;
        private string m_No_Traveling_lanes;
        private string m_No_Parking_lanes;
        private string m_Total_Lanes;
        private string m_bike_lane2;
        private string m_st_width_max;
        private string m_bike_traffic_direction;
        private string m_speed_limit;
        private string m_puma_code;
        private string m_police_sector;
        private string m_truck_route_type;
        private string m_census_tract_2020;
        private string m_census_block_2020;
        private string m_census_block_suffix_2020;
        private string m_nta_2020;
        private string m_cdta_2020;
        private string m_puma_2020;
        private string m_filler04;

        // Constructor for Wa2F3cx
        public Wa2F3cx() => Initialize();

        public Wa2F3cx(string inString) : base()
        {
            // Initialize fields first (default constructor)
            Initialize();

            // Call the method to populate the object from the provided string
            this.Wa2F3cxFromString(inString);
        }

        public void Initialize()
        {
            m_gridkey3 = new string(' ', 21);
            m_cont_parity_ind = new string(' ', 1);
            m_loc_status = new string(' ', 1);
            m_county_boundary = new string(' ', 1);
            m_dcp_pref_lgc1 = new string(' ', 2);
            m_dcp_pref_lgc2 = new string(' ', 2);
            m_dcp_pref_lgc3 = new string(' ', 2);
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
            m_filler01 = new string(' ', 4);
            m_segment_id = new string(' ', 7);
            m_dot_street_light_contract_area = new string(' ', 1);
            m_sos_ind = new string(' ', 1);
            m_curve_flag = new string(' ', 1);
            m_feature_type = new string(' ', 1);
            m_segment_type = new string(' ', 1);
            m_coincident_seg_cnt = new string(' ', 1);
            m_pgb_flag = new string(' ', 3);
            m_filler02 = new string(' ', 1);
            m_seg_side = new SegSide();

            for (int i = 0; i < 4; i++)
            {
                m_on_street_valid_lgcs[i] = new string(' ', 2);
                m_from_street_valid_lgcs[i] = new string(' ', 2);
                m_to_street_valid_lgcs[i] = new string(' ', 2);
            }

            m_left_health_center_dist = new string(' ', 2);
            m_right_health_center_dist = new string(' ', 2);
            m_filler03 = new string(' ', 1);
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

            for (int i = 0; i < 5; i++)
            {
                m_on_street_additional_valid_lgcs[i] = new string(' ', 2);
            }

            m_legacy_segment_id = new string(' ', 7);
            m_nta_name = new string(' ', 75);
            m_from_x_coord = new string(' ', 7);
            m_from_y_coord = new string(' ', 7);
            m_to_x_coord = new string(' ', 7);
            m_to_y_coord = new string(' ', 7);
            m_from_latitude = new string(' ', 9);
            m_from_longitude = new string(' ', 11);
            m_to_latitude = new string(' ', 9);
            m_to_longitude = new string(' ', 11);
            m_blockface_id = new string(' ', 10);
            m_No_Traveling_lanes = new string(' ', 2);
            m_No_Parking_lanes = new string(' ', 2);
            m_Total_Lanes = new string(' ', 2);
            m_bike_lane2 = new string(' ', 2);
            m_st_width_max = new string(' ', 3);
            m_bike_traffic_direction = new string(' ', 2);
            m_speed_limit = new string(' ', 2);
            m_puma_code = new string(' ', 5);
            m_police_sector = new string(' ', 4);
            m_truck_route_type = new string(' ', 1);
            m_census_tract_2020 = new string(' ', 6);
            m_census_block_2020 = new string(' ', 4);
            m_census_block_suffix_2020 = new string(' ', 1);
            m_nta_2020 = new string(' ', 6);
            m_cdta_2020 = new string(' ', 4);
            m_puma_2020 = new string(' ', 5);
            m_filler04 = new string(' ', 260);
        }

        /// <summary>
        /// Reinitializes the Wa2F3cx object to spaces.
        /// </summary>
        public override void Clear()
        {
            this.Wa2F3cxFromString(new string(' ', 850));
        }

        /// <summary>
        /// Converts a Wa2F3cx object to a string.
        /// </summary>
        /// <returns>A string representation of the object.</returns>
        public override string ToString()
        {
            return this.Wa2F3cxToString();
        }

        /// <summary>
        /// Converts a string to a Wa2F3cx object.
        /// </summary>
        /// <param name="inString">The string to convert.</param>
        public override void FromString(string inString)
        {
            this.Wa2F3cxFromString(inString);
        }

        /// <summary>
        /// Converts a Wa2F3cx object to a string.
        /// </summary>
        /// <returns>A string representation of the object.</returns>
        public string Wa2F3cxToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(m_gridkey3);
            sb.Append(m_cont_parity_ind);
            sb.Append(m_loc_status);
            sb.Append(m_county_boundary);
            sb.Append(m_dcp_pref_lgc1);
            sb.Append(m_dcp_pref_lgc2);
            sb.Append(m_dcp_pref_lgc3);
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

            sb.Append(m_x_street_reversal_flag);
            sb.Append(m_lionkey.LionKeyToString());
            sb.Append(m_generated_record_flag);
            sb.Append(m_segment_len);
            sb.Append(m_segment_azm);
            sb.Append(m_segment_orient);
            sb.Append(m_mh_ri_flag);
            sb.Append(m_from_node);
            sb.Append(m_to_node);
            sb.Append(m_dsny_snow_priority);
            sb.Append(m_filler01);
            sb.Append(m_segment_id);
            sb.Append(m_dot_street_light_contract_area);
            sb.Append(m_dot_street_light_contract_area);

            // Corrected error: moved m_curve_flag and m_sos_ind to proper positions
            sb.Append(m_sos_ind);
            sb.Append(m_curve_flag);
            sb.Append(m_feature_type);
            sb.Append(m_segment_type);
            sb.Append(m_coincident_seg_cnt);

            sb.Append(m_pgb_flag);

            sb.Append(m_filler02);
            sb.Append(m_seg_side.SegSideToString());

            // Additional Geosupport fields for extended work area
            for (int i = 0; i < 4; i++)
            {
                sb.Append(m_on_street_valid_lgcs[i]);
            }

            for (int i = 0; i < 4; i++)
            {
                sb.Append(m_from_street_valid_lgcs[i]);
            }

            for (int i = 0; i < 4; i++)
            {
                sb.Append(m_to_street_valid_lgcs[i]);
            }

            sb.Append(m_left_health_center_dist);
            sb.Append(m_right_health_center_dist);
            sb.Append(m_filler03);
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

            for (int i = 0; i < 5; i++)
            {
                sb.Append(m_on_street_additional_valid_lgcs[i]);
            }

            sb.Append(m_legacy_segment_id);
            sb.Append(m_nta_name);

            sb.Append(m_from_x_coord);
            sb.Append(m_from_y_coord);
            sb.Append(m_to_x_coord);
            sb.Append(m_to_y_coord);

            sb.Append(m_from_latitude);
            sb.Append(m_from_longitude);
            sb.Append(m_to_latitude);
            sb.Append(m_to_longitude);

            sb.Append(m_blockface_id);
            sb.Append(m_No_Traveling_lanes);
            sb.Append(m_No_Parking_lanes);
            sb.Append(m_Total_Lanes);
            sb.Append(m_bike_lane2);
            sb.Append(m_st_width_max);
            sb.Append(m_bike_traffic_direction);

            sb.Append(m_speed_limit);
            sb.Append(m_puma_code);
            sb.Append(m_police_sector);

            sb.Append(m_truck_route_type);

            sb.Append(m_census_tract_2020);
            sb.Append(m_census_block_2020);
            sb.Append(m_census_block_suffix_2020);
            sb.Append(m_nta_2020);
            sb.Append(m_cdta_2020);

            sb.Append(m_puma_2020);
            sb.Append(m_filler04);

            return sb.ToString();
        }

        // Assuming Wa2F3cxFromString() method and other classes (like B5sc, LionKey, SegSide) are defined elsewhere in the C# code.
        public void Wa2F3cxFromString(string inString)
        {
            int i;

            m_gridkey3 = inString.Substring(0, 21);
            m_cont_parity_ind = inString.Substring(21, 1);
            m_loc_status = inString.Substring(22, 1);
            m_county_boundary = inString.Substring(23, 1);
            m_dcp_pref_lgc1 = inString.Substring(24, 2);
            m_dcp_pref_lgc2 = inString.Substring(26, 2);
            m_dcp_pref_lgc3 = inString.Substring(28, 2);
            m_lo_x_sts_cnt = inString.Substring(30, 1);

            for (i = 0; i <= 4; i++)
            {
                try { m_lo_x_sts[i] = new B5sc(inString.Substring(31 + (i * 6), 6)); } catch { m_lo_x_sts[i] = new B5sc(); }
            }

            m_hi_x_sts_cnt = inString.Substring(61, 1);

            for (i = 0; i <= 4; i++)
            {
                try { m_hi_x_sts[i] = new B5sc(inString.Substring(62 + (i * 6), 6)); } catch { m_hi_x_sts[i] = new B5sc(); }
            }

            m_x_street_reversal_flag = inString.Substring(92, 1);
            m_lionkey = new LionKey(inString.Substring(93, 10));
            m_generated_record_flag = inString.Substring(103, 1);
            m_segment_len = inString.Substring(104, 5);
            m_segment_azm = inString.Substring(109, 3);
            m_segment_orient = inString.Substring(112, 1);
            m_mh_ri_flag = inString.Substring(113, 1);

            // added m_from_node & m_to_node
            m_from_node = inString.Substring(114, 7);
            m_to_node = inString.Substring(121, 7);

            // Geosupport Version 11.3 / Release 12A
            m_dsny_snow_priority = inString.Substring(128, 1);
            m_filler01 = inString.Substring(129, 4);
            m_segment_id = inString.Substring(133, 7);
            m_dot_street_light_contract_area = inString.Substring(140, 1);

            // Geosupport Version 12A (correcting error)
            m_sos_ind = inString.Substring(141, 1);
            m_curve_flag = inString.Substring(142, 1);
            m_feature_type = inString.Substring(143, 1);
            m_segment_type = inString.Substring(144, 1);
            m_coincident_seg_cnt = inString.Substring(145, 1);

            // New 3-byte PGB_Flag
            m_pgb_flag = inString.Substring(146, 3);

            m_filler02 = inString.Substring(149, 1);

            m_seg_side = new SegSide(inString.Substring(150, 150));

            // Additional fields for extended work area
            for (i = 0; i <= 3; i++)
            {
                try { m_on_street_valid_lgcs[i] = inString.Substring(300 + (i * 2), 2); } catch { m_on_street_valid_lgcs[i] = string.Empty; }
            }

            for (i = 0; i <= 3; i++)
            {
                try { m_from_street_valid_lgcs[i] = inString.Substring(308 + (i * 2), 2); } catch { m_from_street_valid_lgcs[i] = string.Empty; }
            }

            for (i = 0; i <= 3; i++)
            {
                try { m_to_street_valid_lgcs[i] = inString.Substring(316 + (i * 2), 2); } catch { m_to_street_valid_lgcs[i] = string.Empty; }
            }

            m_left_health_center_dist = inString.Substring(324, 2);
            m_right_health_center_dist = inString.Substring(326, 2);
            m_filler03 = inString.Substring(328, 1);
            m_traffic_direction = inString.Substring(329, 1);
            m_roadway_type = inString.Substring(330, 2);
            m_physical_id = inString.Substring(332, 7);
            m_generic_id = inString.Substring(339, 7);
            m_nypd_id = inString.Substring(346, 7);
            m_fdny_id = inString.Substring(353, 7);
            m_street_status = inString.Substring(360, 1);
            m_street_width = inString.Substring(361, 3);
            m_street_width_irregular = inString.Substring(364, 1);
            m_bike_lane = inString.Substring(365, 1);
            m_federal_classification_code = inString.Substring(366, 2);
            m_right_of_way_type = inString.Substring(368, 1);

            // Arrays are zero-based so there are 5 entries below
            for (i = 0; i <= 4; i++)
            {
                try { m_on_street_additional_valid_lgcs[i] = inString.Substring(369 + (i * 2), 2); } catch { m_on_street_additional_valid_lgcs[i] = string.Empty; }
            }

            m_legacy_segment_id = inString.Substring(379, 7);

            // Geosupport Version 11.3 / Release 12A
            m_nta_name = inString.Substring(386, 75);

            // Geosupport Version 11.4 / Release 12B
            m_from_x_coord = inString.Substring(461, 7);
            m_from_y_coord = inString.Substring(468, 7);
            m_to_x_coord = inString.Substring(475, 7);
            m_to_y_coord = inString.Substring(482, 7);

            // Geosupport Version 15.3 / Release 15C - Start
            m_from_latitude = inString.Substring(489, 9);
            m_from_longitude = inString.Substring(498, 11);
            m_to_latitude = inString.Substring(509, 9);
            m_to_longitude = inString.Substring(518, 11);
            // Geosupport Version 15.3 / Release 15C - End

            // Geosupport Version 16.1 changes.
            m_blockface_id = inString.Substring(529, 10);
            m_No_Traveling_lanes = inString.Substring(539, 2);
            m_No_Parking_lanes = inString.Substring(541, 2);
            m_Total_Lanes = inString.Substring(543, 2);

            // Geosupport Version 16.4 changes.
            m_bike_lane2 = inString.Substring(545, 2);
            m_st_width_max = inString.Substring(547, 3);

            // Geosupport Version 16.4 changes.
            m_bike_traffic_direction = inString.Substring(550, 2);

            // Geosupport Release 17D changes.
            m_speed_limit = inString.Substring(552, 2);

            // Geosupport Version 18.1 changes.
            m_puma_code = inString.Substring(554, 5);
            m_police_sector = inString.Substring(559, 4);

            m_truck_route_type = inString.Substring(563, 1);

            // Census 2020 fields.
            m_census_tract_2020 = inString.Substring(564, 6);
            m_census_block_2020 = inString.Substring(570, 4);
            m_census_block_suffix_2020 = inString.Substring(574, 1);
            m_nta_2020 = inString.Substring(575, 6);
            m_cdta_2020 = inString.Substring(581, 4);

            // Left and right puma 2020 fields.
            m_puma_2020 = inString.Substring(585, 5);

            m_filler04 = inString.Substring(590, 260);
        }

        public override string Display(char c)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(m_gridkey3);
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

            // Added m_from_node & m_to_node
            sb.Append(m_from_node);
            sb.Append(c);
            sb.Append(m_to_node);
            sb.Append(c);

            // Added for Geosupport Version 11.3 / Release 12A
            sb.Append(m_dsny_snow_priority);
            sb.Append(c);
            sb.Append(m_filler01);
            sb.Append(c);
            sb.Append(m_segment_id);
            sb.Append(c);
            sb.Append(m_dot_street_light_contract_area);
            sb.Append(c);

            // Correcting original error (wa2f3 m_curve_flag location change)
            sb.Append(m_sos_ind);
            sb.Append(c);
            sb.Append(m_curve_flag);
            sb.Append(c);
            sb.Append(m_feature_type);
            sb.Append(c);
            sb.Append(m_segment_type);
            sb.Append(c);
            sb.Append(m_coincident_seg_cnt);
            sb.Append(c);

            // New 3-byte PGB_Flag
            sb.Append(m_pgb_flag);
            sb.Append(c);

            sb.Append(m_filler02);
            sb.Append(c);
            sb.Append(m_seg_side.Display());
            sb.Append(c);

            // Geosupport v 11.0 additional fields for extended work area
            for (int i = 0; i <= 3; i++)
            {
                sb.Append(m_on_street_valid_lgcs[i]);
                sb.Append(c);
            }

            for (int i = 0; i <= 3; i++)
            {
                sb.Append(m_from_street_valid_lgcs[i]);
                sb.Append(c);
            }

            for (int i = 0; i <= 3; i++)
            {
                sb.Append(m_to_street_valid_lgcs[i]);
                sb.Append(c);
            }

            sb.Append(m_left_health_center_dist);
            sb.Append(c);
            sb.Append(m_right_health_center_dist);
            sb.Append(c);
            sb.Append(m_filler03);
            sb.Append(c);
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

            // Arrays are zero-based, so there are 5 entries below
            for (int i = 0; i <= 4; i++)
            {
                sb.Append(m_on_street_additional_valid_lgcs[i]);
                sb.Append(c);
            }

            sb.Append(m_legacy_segment_id);
            sb.Append(c);

            // Added for Geosupport Version 11.3 / Release 12A
            sb.Append(m_nta_name);
            sb.Append(c);

            // Added for Geosupport Version 11.4 / Release 12B
            sb.Append(m_from_x_coord);
            sb.Append(c);
            sb.Append(m_from_y_coord);
            sb.Append(c);
            sb.Append(m_to_x_coord);
            sb.Append(c);
            sb.Append(m_to_y_coord);

            // Added for Geosupport Version 15.3/Release 15C - Start
            sb.Append(c);
            sb.Append(m_from_latitude);
            sb.Append(c);
            sb.Append(m_from_longitude);
            sb.Append(c);
            sb.Append(m_to_latitude);
            sb.Append(c);
            sb.Append(m_to_longitude);
            // End of Geosupport Version 15.3/Release 15C

            // 16.1 changes
            sb.Append(c);
            sb.Append(m_blockface_id);
            sb.Append(c);
            sb.Append(m_No_Traveling_lanes);
            sb.Append(c);
            sb.Append(m_No_Parking_lanes);
            sb.Append(c);
            sb.Append(m_Total_Lanes);
            sb.Append(c);

            // 16.4 changes
            sb.Append(m_bike_lane2);
            sb.Append(c);
            sb.Append(m_st_width_max);
            sb.Append(c);

            // 17.1 changes
            sb.Append(m_bike_traffic_direction);
            sb.Append(c);

            // Added new speed_limit 2 byte field for Release 17D
            sb.Append(m_speed_limit);
            sb.Append(c);

            // Added new 5 byte puma_code for Geosupport version 18.1
            sb.Append(m_puma_code);
            sb.Append(c);

            // Added 4 byte police sector
            sb.Append(m_police_sector);
            sb.Append(c);

            sb.Append(m_truck_route_type);
            sb.Append(c);

            // Added 21 bytes for new census 2020 fields
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

            // Added left and right puma 2020 fields
            sb.Append(m_puma_2020);
            sb.Append(c);

            sb.Append(m_filler04);
            sb.Append(c);

            return sb.ToString();
        }

        public override string Display()
        {
            return this.Display('-');
        }

        /// <summary>
        /// <c>Print</c>
        /// <para>Creates a string with <c>Wa2F3cx</c> field names and values</para>
        /// </summary>
        public override string Print()
        {
            var sb = new StringBuilder();
            int i;

            sb.AppendFormat("gridkey3 = {0}{1}", m_gridkey3, Environment.NewLine);
            sb.AppendFormat("cont_parity_ind = {0}{1}", m_cont_parity_ind, Environment.NewLine);
            sb.AppendFormat("loc_status = {0}{1}", m_loc_status, Environment.NewLine);
            sb.AppendFormat("county_boundary = {0}{1}", m_county_boundary, Environment.NewLine);
            sb.AppendFormat("dcp_pref_lgc1 = {0}{1}", m_dcp_pref_lgc1, Environment.NewLine);
            sb.AppendFormat("dcp_pref_lgc2 = {0}{1}", m_dcp_pref_lgc2, Environment.NewLine);
            sb.AppendFormat("dcp_pref_lgc3 = {0}{1}", m_dcp_pref_lgc3, Environment.NewLine);
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
            sb.AppendFormat("x_street_reversal_flag = {0}{1}", m_x_street_reversal_flag, Environment.NewLine);
            sb.AppendFormat("lionkey = {0}{1}", m_lionkey.Display(), Environment.NewLine);
            sb.AppendFormat("generated_record_flag = {0}{1}", m_generated_record_flag, Environment.NewLine);
            sb.AppendFormat("segment_len = {0}{1}", m_segment_len, Environment.NewLine);
            sb.AppendFormat("segment_azm = {0}{1}", m_segment_azm, Environment.NewLine);
            sb.AppendFormat("segment_orient = {0}{1}", m_segment_orient, Environment.NewLine);
            sb.AppendFormat("mh_ri_flag = {0}{1}", m_mh_ri_flag, Environment.NewLine);

            //spo (2007-07-17) added m_from_node & m_to_node
            sb.AppendFormat("from_node = {0}{1}", m_from_node, Environment.NewLine);
            sb.AppendFormat("to_node = {0}{1}", m_to_node, Environment.NewLine);

            //--spo(2012-04-06):  added for Geosupport Version 11.3 / Release 12A 
            sb.AppendFormat("dsny_snow_priority = {0}{1}", m_dsny_snow_priority, Environment.NewLine);
            sb.AppendFormat("filler01 = {0}{1}", m_filler01, Environment.NewLine);
            sb.AppendFormat("segment_id = {0}{1}", m_segment_id, Environment.NewLine);
            sb.AppendFormat("dot_street_light_contract_area = {0}{1}", m_dot_street_light_contract_area, Environment.NewLine);

            sb.AppendFormat("sos_ind = {0}{1}", m_sos_ind, Environment.NewLine);
            sb.AppendFormat("curve_flag = {0}{1}", m_curve_flag, Environment.NewLine);
            sb.AppendFormat("feature_type = {0}{1}", m_feature_type, Environment.NewLine);
            sb.AppendFormat("segment_type = {0}{1}", m_segment_type, Environment.NewLine);

            //spo (2007-07-17) added m_coincident_seg_cnt 
            sb.AppendFormat("coincident_seg_cnt = {0}{1}", m_coincident_seg_cnt, Environment.NewLine);

            //--SPO(2022-06-21): New 3-byte PGB_Flag; Shorten m_filler04 by 3 bytes
            sb.AppendFormat("pgb_flag = {0}{1}", m_pgb_flag, Environment.NewLine);

            sb.AppendFormat("filler02 = {0}{1}", m_filler02, Environment.NewLine);

            // Enhanced the presentation of Segside data
            sb.AppendFormat("********************************************* {0}", Environment.NewLine);
            sb.AppendFormat("seg_side (display) = {0}{1}", m_seg_side.Display(), Environment.NewLine);
            sb.AppendFormat("********************************************* {0}", Environment.NewLine);
            sb.AppendFormat("seg_side (print) = {0}", Environment.NewLine);
            sb.AppendFormat("{0}", m_seg_side.Print);
            sb.AppendFormat("********************************************* {0}", Environment.NewLine);

            //--spo(2011-09-25): Geosupport v 11.0 additional fields for extended work area 
            for (i = 0; i <= 3; i++)
            {
                sb.AppendFormat("on_street_valid_lgcs({0}) = {1}{2}", i, m_on_street_valid_lgcs[i], Environment.NewLine);
            }
            for (i = 0; i <= 3; i++)
            {
                sb.AppendFormat("from_street_valid_lgcs({0}) = {1}{2}", i, m_from_street_valid_lgcs[i], Environment.NewLine);
            }
            for (i = 0; i <= 3; i++)
            {
                sb.AppendFormat("to_street_valid_lgcs({0}) = {1}{2}", i, m_to_street_valid_lgcs[i], Environment.NewLine);
            }
            sb.AppendFormat("left_health_center_dist = {0}{1}", m_left_health_center_dist, Environment.NewLine);
            sb.AppendFormat("right_health_center_dist = {0}{1}", m_right_health_center_dist, Environment.NewLine);
            sb.AppendFormat("filler03 = {0}{1}", m_filler03, Environment.NewLine);
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

            for (i = 0; i <= 4; i++)
            {
                sb.AppendFormat("on_street_additional_valid_lgcs({0}) = {1}{2}", i, m_on_street_additional_valid_lgcs[i], Environment.NewLine);
            }
            sb.AppendFormat("legacy_segment_id = {0}{1}", m_legacy_segment_id, Environment.NewLine);

            //--spo(2012-04-06): added for Geosupport Version 11.3 / Release 12A 
            sb.AppendFormat("nta_name = {0}{1}", m_nta_name, Environment.NewLine);

            //--spo(2012-07-06): added for Geosupport Version 11.4 / Release 12B 
            sb.AppendFormat("from_x_coord = {0}{1}", m_from_x_coord, Environment.NewLine);
            sb.AppendFormat("from_y_coord = {0}{1}", m_from_y_coord, Environment.NewLine);
            sb.AppendFormat("to_x_coord = {0}{1}", m_to_x_coord, Environment.NewLine);
            sb.AppendFormat("to_y_coord = {0}{1}", m_to_y_coord, Environment.NewLine);

            //--njp(2015-06-19): added for Geosupport Version 15.3/Release 15C - Start
            sb.AppendFormat("from_latitude = {0}{1}", m_from_latitude, Environment.NewLine);
            sb.AppendFormat("from_longitude = {0}{1}", m_from_longitude, Environment.NewLine);
            sb.AppendFormat("to_latitude = {0}{1}", m_to_latitude, Environment.NewLine);
            sb.AppendFormat("to_longitude = {0}{1}", m_to_longitude, Environment.NewLine);

            // njp(2015-06-19): added for Geosupport Version 15.3/Release 15C - End

            // njp(2016-02-17) 16.1 changes.
            sb.AppendFormat("blockface_id = {0}{1}", m_blockface_id, Environment.NewLine);
            sb.AppendFormat("No_Traveling_lanes = {0}{1}", m_No_Traveling_lanes, Environment.NewLine);
            sb.AppendFormat("No_Parking_lanes = {0}{1}", m_No_Parking_lanes, Environment.NewLine);
            sb.AppendFormat("Total_Lanes = {0}{1}", m_Total_Lanes, Environment.NewLine);

            // jgt(2016-09-27) 16.4 changes.
            sb.AppendFormat("Bike_Lane2 = {0}{1}", m_bike_lane2, Environment.NewLine);
            sb.AppendFormat("Street_Width_Maximum = {0}{1}", m_st_width_max, Environment.NewLine);

            // njp(2016-12-12) 17.1 changes
            sb.AppendFormat("Bike_Traffic_Direction = {0}{1}", m_bike_traffic_direction, Environment.NewLine);

            //------------------------------------------------------------------------
            // SPO(2017-09-29): Added new speed_limit 2 byte field for Release 17D
            // Requires that I reduce m_filler04 by 2 bytes
            //------------------------------------------------------------------------
            sb.AppendFormat("speed_limit = {0}{1}", m_speed_limit, Environment.NewLine);

            // SPO(2018-01-03): Added new 5 byte puma_code for Geosupport version 18.1
            sb.AppendFormat("puma_code = {0}{1}", m_puma_code, Environment.NewLine);
            sb.AppendFormat("police_sector = {0}{1}", m_police_sector, Environment.NewLine);

            sb.AppendFormat("truck_route_type = {0}{1}", m_truck_route_type, Environment.NewLine);

            //------------------------------------------------------------------
            // spo(2021-05-04): Add 21 bytes for new census 2020 fields
            //------------------------------------------------------------------
            sb.AppendFormat("census_tract_2020 = {0}{1}", m_census_tract_2020, Environment.NewLine);
            sb.AppendFormat("census_block_2020 = {0}{1}", m_census_block_2020, Environment.NewLine);
            sb.AppendFormat("census_block_suffix_2020 = {0}{1}", m_census_block_suffix_2020, Environment.NewLine);
            sb.AppendFormat("nta_2020 = {0}{1}", m_nta_2020, Environment.NewLine);
            sb.AppendFormat("cdta_2020 = {0}{1}", m_cdta_2020, Environment.NewLine);

            //------------------------------------------------------------------
            // spo(2023-03-15): added left and right puma 2020 fields
            //------------------------------------------------------------------
            sb.AppendFormat("puma_2020 = {0}{1}", m_puma_2020, Environment.NewLine);

            sb.AppendFormat("filler04 = {0}{1}", m_filler04, Environment.NewLine);

            return sb.ToString();

        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            int i;

            sb.AppendFormat("{0}", Environment.NewLine);
            sb.AppendFormat("{0}{1}", "****************************************************************************", Environment.NewLine);
            sb.AppendFormat("{0}{1}", "******************************  Wa2F3cx  *********************************", Environment.NewLine);
            sb.AppendFormat("{0}{1}", "****************************************************************************", Environment.NewLine);

            sb.AppendFormat("{0}{1}", Environment.NewLine + "**********  Key Information  **********", Environment.NewLine + Environment.NewLine);

            sb.AppendFormat("gridkey3 = {0}{1}", m_gridkey3, Environment.NewLine);
            sb.AppendFormat("cont_parity_ind = {0}{1}", m_cont_parity_ind, Environment.NewLine);
            sb.AppendFormat("loc_status = {0}{1}", m_loc_status, Environment.NewLine);
            sb.AppendFormat("county_boundary = {0}{1}", m_county_boundary, Environment.NewLine);

            // SPO(2022-06-21): New 3-byte PGB_Flag; Shorten m_filler02 by 3 bytes
            sb.AppendFormat("pgb_flag = {0}{1}", m_pgb_flag, Environment.NewLine);

            sb.AppendFormat("{0}", Environment.NewLine);

            sb.AppendFormat("dcp_pref_lgc1 = {0}{1}", m_dcp_pref_lgc1, Environment.NewLine);
            sb.AppendFormat("dcp_pref_lgc2 = {0}{1}", m_dcp_pref_lgc2, Environment.NewLine);
            sb.AppendFormat("dcp_pref_lgc3 = {0}{1}", m_dcp_pref_lgc3, Environment.NewLine);

            sb.AppendFormat("{0}", Environment.NewLine);

            for (i = 0; i <= 3; i++)
            {
                sb.AppendFormat("on_street_valid_lgcs({0}) = {1}{2}", i, m_on_street_valid_lgcs[i], Environment.NewLine);
            }

            sb.AppendFormat("{0}", Environment.NewLine);

            for (i = 0; i <= 4; i++)
            {
                sb.AppendFormat("on_street_additional_valid_lgcs({0}) = {1}{2}", i, m_on_street_additional_valid_lgcs[i], Environment.NewLine);
            }

            sb.AppendFormat("{0}{1}", Environment.NewLine + "**********  Geographic Information  **********", Environment.NewLine + Environment.NewLine);

            sb.AppendFormat("segment_id = {0}{1}", m_segment_id, Environment.NewLine);
            sb.AppendFormat("legacy_segment_id = {0}{1}", m_legacy_segment_id, Environment.NewLine);
            sb.AppendFormat("physical_id = {0}{1}", m_physical_id, Environment.NewLine);
            sb.AppendFormat("generic_id = {0}{1}", m_generic_id, Environment.NewLine);

            sb.AppendFormat("blockface_id = {0}{1}", m_blockface_id, Environment.NewLine);

            sb.AppendFormat("nypd_id = {0}{1}", m_nypd_id, Environment.NewLine);
            sb.AppendFormat("fdny_id = {0}{1}", m_fdny_id, Environment.NewLine);

            sb.AppendFormat("{0}", Environment.NewLine);

            sb.AppendFormat("from_node = {0}{1}", m_from_node, Environment.NewLine);
            sb.AppendFormat("to_node = {0}{1}", m_to_node, Environment.NewLine);

            sb.AppendFormat("{0}", Environment.NewLine);

            sb.AppendFormat("from_x_coord = {0}{1}", m_from_x_coord, Environment.NewLine);
            sb.AppendFormat("from_y_coord = {0}{1}", m_from_y_coord, Environment.NewLine);

            sb.AppendFormat("{0}", Environment.NewLine);

            sb.AppendFormat("to_x_coord = {0}{1}", m_to_x_coord, Environment.NewLine);
            sb.AppendFormat("to_y_coord = {0}{1}", m_to_y_coord, Environment.NewLine);

            sb.AppendFormat("{0}", Environment.NewLine);

            sb.AppendFormat("from_latitude = {0}{1}", m_from_latitude, Environment.NewLine);
            sb.AppendFormat("from_longitude = {0}{1}", m_from_longitude, Environment.NewLine);

            sb.AppendFormat("{0}", Environment.NewLine);

            sb.AppendFormat("to_latitude = {0}{1}", m_to_latitude, Environment.NewLine);
            sb.AppendFormat("to_longitude = {0}{1}", m_to_longitude, Environment.NewLine);

            sb.AppendFormat("{0}", Environment.NewLine);

            sb.AppendFormat("lionkey = {0}{1}", m_lionkey.Display(), Environment.NewLine);
            sb.AppendFormat("generated_record_flag = {0}{1}", m_generated_record_flag, Environment.NewLine);
            sb.AppendFormat("segment_len = {0}{1}", m_segment_len, Environment.NewLine);
            sb.AppendFormat("segment_azm = {0}{1}", m_segment_azm, Environment.NewLine);
            sb.AppendFormat("segment_orient = {0}{1}", m_segment_orient, Environment.NewLine);
            sb.AppendFormat("mh_ri_flag = {0}{1}", m_mh_ri_flag, Environment.NewLine);
            sb.AppendFormat("curve_flag = {0}{1}", m_curve_flag, Environment.NewLine);
            // sb.AppendFormat("dog_leg = {0}{1}", m_dog_leg, Environment.NewLine);
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

            sb.AppendFormat("{0}{1}", Environment.NewLine + "**********  Other District Information  **********", Environment.NewLine + Environment.NewLine);

            sb.AppendFormat("dsny_snow_priority = {0}{1}", m_filler01, Environment.NewLine);
            sb.AppendFormat("dot_street_light_contract_area = {0}{1}", m_dot_street_light_contract_area, Environment.NewLine);

            sb.AppendFormat("{0}", Environment.NewLine);

            sb.AppendFormat("left_health_center_dist = {0}{1}", m_left_health_center_dist, Environment.NewLine);
            sb.AppendFormat("right_health_center_dist = {0}{1}", m_right_health_center_dist, Environment.NewLine);

            sb.AppendFormat("{0}{1}", Environment.NewLine + "**********  Cross Streets Information  **********", Environment.NewLine + Environment.NewLine);

            sb.AppendFormat("x_street_reversal_flag = {0}{1}", m_x_street_reversal_flag, Environment.NewLine);

            sb.AppendFormat("{0}", Environment.NewLine);

            sb.AppendFormat("lo_x_sts_cnt = {0}{1}", m_lo_x_sts_cnt, Environment.NewLine);
            for (i = 0; i <= 4; i++)
            {
                sb.AppendFormat("lo_x_sts({0}) = {1}{2}", i, m_lo_x_sts[i].Display(), Environment.NewLine);
            }

            sb.AppendFormat("{0}", Environment.NewLine);

            for (i = 0; i <= 3; i++)
            {
                sb.AppendFormat("from_street_valid_lgcs({0}) = {1}{2}", i, m_from_street_valid_lgcs[i], Environment.NewLine);
            }

            sb.AppendFormat("{0}", Environment.NewLine);

            sb.AppendFormat("hi_x_sts_cnt = {0}{1}", m_hi_x_sts_cnt, Environment.NewLine);
            for (i = 0; i <= 4; i++)
            {
                sb.AppendFormat("hi_x_sts({0}) = {1}{2}", i, m_hi_x_sts[i].Display(), Environment.NewLine);
            }

            sb.AppendFormat("{0}", Environment.NewLine);

            for (i = 0; i <= 3; i++)
            {
                sb.AppendFormat("to_street_valid_lgcs({0}) = {1}{2}", i, m_to_street_valid_lgcs[i], Environment.NewLine);
            }

            sb.AppendFormat("{0}", Environment.NewLine);

            sb.AppendFormat("sos_ind = {0}{1}", m_sos_ind, Environment.NewLine);

            sb.AppendFormat("{0}", Environment.NewLine);

            // -----------------------------------------------------------------------
            // ---spo(2016-05-10):    Enhanced the presentation of Segside data 
            // ---                    Added Print version for easier reading 
            // -----------------------------------------------------------------------
            sb.AppendFormat("********************************************* {0}", Environment.NewLine);
            sb.AppendFormat("SEGMENT SIDE {0}", Environment.NewLine);
            sb.AppendFormat("********************************************* {0}", Environment.NewLine);
            sb.AppendFormat("{0}", m_seg_side.Print);

            sb.AppendFormat("{0}", Environment.NewLine);

            sb.AppendFormat("nta_name = {0}{1}", m_nta_name, Environment.NewLine);
            // SPO(2018-01-03): Added new 5 byte puma_code for Geosupport version 18.1 
            sb.AppendFormat("puma_code = {0}{1}", m_puma_code, Environment.NewLine);
            sb.AppendFormat("police_sector = {0}{1}", m_police_sector, Environment.NewLine);

            // ------------------------------------------------------------------
            // --spo(2021-05-04): Add 21 bytes for new census 2020 fields 
            // ------------------------------------------------------------------
            // --spo(2023-03-15): added left and right puma 2020 fields 
            // ------------------------------------------------------------------
            sb.AppendFormat("census_tract_2020 = {0}{1}", m_census_tract_2020, Environment.NewLine);
            sb.AppendFormat("census_block_2020 = {0}{1}", m_census_block_2020, Environment.NewLine);
            sb.AppendFormat("census_block_suffix_2020 = {0}{1}", m_census_block_suffix_2020, Environment.NewLine);
            sb.AppendFormat("nta_2020 = {0}{1}", m_nta_2020, Environment.NewLine);
            sb.AppendFormat("cdta_2020 = {0}{1}", m_cdta_2020, Environment.NewLine);
            sb.AppendFormat("puma_2020 = {0}{1}", m_puma_2020, Environment.NewLine);
            sb.AppendFormat("********************************************* {0}", Environment.NewLine);

            sb.AppendFormat("{0}", Environment.NewLine);

            sb.AppendFormat("{0}{1}", Environment.NewLine + "**********  Miscellaneous Filler Information  **********", Environment.NewLine + Environment.NewLine);

            sb.AppendFormat("filler01 = {0}{1}", m_filler01, Environment.NewLine);
            sb.AppendFormat("filler02 = {0}{1}", m_filler02, Environment.NewLine);
            sb.AppendFormat("filler03 = {0}{1}", m_filler03, Environment.NewLine);
            sb.AppendFormat("filler04 = {0}{1}", m_filler04, Environment.NewLine);

            sb.AppendFormat("{0}", Environment.NewLine);

            return sb.ToString();
        }

        public string gridkey3
        {
            get => m_gridkey3;
            set => m_gridkey3 = value.Length > 21 ? value.Substring(0, 21) : value;
        }

        public string cont_parity_ind
        {
            get => m_cont_parity_ind;
            set => m_cont_parity_ind = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string loc_status
        {
            get => m_loc_status;
            set => m_loc_status = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string county_boundary
        {
            get => m_county_boundary;
            set => m_county_boundary = value.Length > 1 ? value.Substring(0, 1) : value;
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

        public string dcp_pref_lgc3
        {
            get => m_dcp_pref_lgc3;
            set => m_dcp_pref_lgc3 = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        public string lo_x_sts_cnt
        {
            get => m_lo_x_sts_cnt;
            set => m_lo_x_sts_cnt = value.Length > 1 ? value.Substring(0, 1) : value;
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
            set => m_hi_x_sts_cnt = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public B5sc[] hi_x_sts
        {
            get => m_hi_x_sts;
            set => m_hi_x_sts = value;
        }

        public B5sc hi_x_sts_item(int index) => m_hi_x_sts[index];

        public void hi_x_sts_item(int index, B5sc value) => m_hi_x_sts[index] = value;

        public string x_street_reversal_flag
        {
            get => m_x_street_reversal_flag;
            set => m_x_street_reversal_flag = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public LionKey lionkey
        {
            get => m_lionkey;
            set => m_lionkey = value;
        }

        public string generated_record_flag
        {
            get => m_generated_record_flag;
            set => m_generated_record_flag = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string segment_len
        {
            get => m_segment_len;
            set => m_segment_len = value.Length > 5 ? value.Substring(0, 5) : value;
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

        public string mh_ri_flag
        {
            get => m_mh_ri_flag;
            set => m_mh_ri_flag = value.Length > 1 ? value.Substring(0, 1) : value;
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

        public string dsny_snow_priority
        {
            get => m_dsny_snow_priority;
            set => m_dsny_snow_priority = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string filler01
        {
            get => m_filler01;
            set => m_filler01 = value.Length > 4 ? value.Substring(0, 4) : value;
        }

        public string segment_id
        {
            get => m_segment_id;
            set => m_segment_id = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        public string dot_street_light_contract_area
        {
            get => m_dot_street_light_contract_area;
            set => m_dot_street_light_contract_area = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string sos_ind
        {
            get => m_sos_ind;
            set => m_sos_ind = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        // Property for curve_flag
        public string curve_flag
        {
            get => m_curve_flag;
            set => m_curve_flag = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        // Property for feature_type
        public string feature_type
        {
            get => m_feature_type;
            set => m_feature_type = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        // Property for segment_type
        public string segment_type
        {
            get => m_segment_type;
            set => m_segment_type = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        // Property for coincident_seg_cnt
        public string coincident_seg_cnt
        {
            get => m_coincident_seg_cnt;
            set => m_coincident_seg_cnt = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        // Property for pgb_flag
        public string pgb_flag
        {
            get => m_pgb_flag;
            set => m_pgb_flag = value.Length > 3 ? value.Substring(0, 3) : value;
        }

        // Property for filler02
        public string filler02
        {
            get => m_filler02;
            set => m_filler02 = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        // Property for seg_side
        public SegSide seg_side
        {
            get => m_seg_side;
            set => m_seg_side = value;
        }

        // Property for on_street_valid_lgcs
        public string[] on_street_valid_lgcs
        {
            get => m_on_street_valid_lgcs;
            set => m_on_street_valid_lgcs = value;
        }

        // Property for on_street_valid_lgcs_item
        public string on_street_valid_lgcs_item(int index) => m_on_street_valid_lgcs[index];

        public void on_street_valid_lgcs_item(int index, string value) => m_on_street_valid_lgcs[index] = value.Length > 2 ? value.Substring(0, 2) : value;
        

        // Property for from_street_valid_lgcs
        public string[] from_street_valid_lgcs
        {
            get => m_from_street_valid_lgcs;
            set => m_from_street_valid_lgcs = value;
        }

        // Property for from_street_valid_lgcs_item
        public string from_street_valid_lgcs_item(int index) => m_from_street_valid_lgcs[index];
        public void FromStreetValidLgcsItem(int index, string value) => m_from_street_valid_lgcs[index] = value.Length > 2 ? value.Substring(0, 2) : value;
        

        // Property for to_street_valid_lgcs
        public string[] to_street_valid_lgcs
        {
            get => m_to_street_valid_lgcs;
            set => m_to_street_valid_lgcs = value;
        }

        // Property for to_street_valid_lgcs_item
        public string to_street_valid_lgcs_item(int index) => m_to_street_valid_lgcs[index];
        public void to_street_valid_lgcs_item(int index, string value) => m_to_street_valid_lgcs[index] = value.Length > 2 ? value.Substring(0, 2) : value;
        
        // Property for left_health_center_dist
        public string left_health_center_dist
        {
            get => m_left_health_center_dist;
            set => m_left_health_center_dist = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        // Property for right_health_center_dist
        public string right_health_center_dist
        {
            get => m_right_health_center_dist;
            set => m_right_health_center_dist = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        // Property for filler03
        public string filler03
        {
            get => m_filler03;
            set => m_filler03 = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        // Property for traffic_direction
        public string traffic_direction
        {
            get => m_traffic_direction;
            set => m_traffic_direction = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        // Property for roadway_type
        public string roadway_type
        {
            get => m_roadway_type;
            set => m_roadway_type = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        // Property for physical_id
        public string physical_id
        {
            get => m_physical_id;
            set => m_physical_id = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        // Property for generic_id
        public string generic_id
        {
            get => m_generic_id;
            set => m_generic_id = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        // Property for nypd_id
        public string nypd_id
        {
            get => m_nypd_id;
            set => m_nypd_id = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        // Property for fdny_id
        public string fdny_id
        {
            get => m_fdny_id;
            set => m_fdny_id = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        // Property for street_status
        public string street_status
        {
            get => m_street_status;
            set => m_street_status = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        // Property for street_width
        public string street_width
        {
            get => m_street_width;
            set => m_street_width = value.Length > 3 ? value.Substring(0, 3) : value;
        }

        // Property for street_width_irregular
        public string street_width_irregular
        {
            get => m_street_width_irregular;
            set => m_street_width_irregular = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        // Property for bike_lane
        public string bike_lane
        {
            get => m_bike_lane;
            set => m_bike_lane = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        // Property for federal_classification_code
        public string federal_classification_code
        {
            get => m_federal_classification_code;
            set => m_federal_classification_code = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        // Property for right_of_way_type
        public string right_of_way_type
        {
            get => m_right_of_way_type;
            set => m_right_of_way_type = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        // Property for on_street_additional_valid_lgcs
        public string[] on_street_additional_valid_lgcs
        {
            get => m_on_street_additional_valid_lgcs;
            set => m_on_street_additional_valid_lgcs = value;
        }

        // Property for on_street_additional_valid_lgcs_item
        public string on_street_additional_valid_lgcs_item(int index) => m_on_street_additional_valid_lgcs[index];
        public void on_street_additional_valid_lgcs_item(int index, string value) => m_on_street_additional_valid_lgcs[index] = value.Length > 2 ? value.Substring(0, 2) : value;
        

        // Property for legacy_segment_id
        public string legacy_segment_id
        {
            get => m_legacy_segment_id;
            set => m_legacy_segment_id = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        // Property for nta_name
        public string nta_name
        {
            get => m_nta_name;
            set => m_nta_name = value.Length > 75 ? value.Substring(0, 75) : value;
        }

        // Property for from_x_coord
        public string from_x_coord
        {
            get => m_from_x_coord;
            set => m_from_x_coord = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        // Property for from_y_coord
        public string from_y_coord
        {
            get => m_from_y_coord;
            set => m_from_y_coord = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        // Property for to_x_coord
        public string to_x_coord
        {
            get => m_to_x_coord;
            set => m_to_x_coord = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        // Property for to_y_coord
        public string to_y_coord
        {
            get => m_to_y_coord;
            set => m_to_y_coord = value.Length > 7 ? value.Substring(0, 7) : value;
        }

        // Property for from_latitude
        public string from_latitude
        {
            get => m_from_latitude;
            set => m_from_latitude = value.Length > 9 ? value.Substring(0, 9) : value;
        }

        // Property for from_longitude
        public string from_longitude
        {
            get => m_from_longitude;
            set => m_from_longitude = value.Length > 11 ? value.Substring(0, 11) : value;
        }

        // Property for to_latitude
        public string to_latitude
        {
            get => m_to_latitude;
            set => m_to_latitude = value.Length > 9 ? value.Substring(0, 9) : value;
        }

        // Property for to_longitude
        public string to_longitude
        {
            get => m_to_longitude;
            set => m_to_longitude = value.Length > 11 ? value.Substring(0, 11) : value;
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

        public string Total_Lanes
        {
            get => m_Total_Lanes;
            set => m_Total_Lanes = value.Length > 2 ? value.Substring(0, 2) : value;
        }

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

        public string bike_traffic_direction
        {
            get => m_bike_traffic_direction;
            set => m_bike_traffic_direction = value.Length > 2 ? value.Substring(0, 2) : value;
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

        public string filler04
        {
            get => m_filler04;
            set => m_filler04 = value.Length > 260 ? value.Substring(0, 260) : value;
        }

    }
}


