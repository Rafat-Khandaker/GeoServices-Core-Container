using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperLib.Model
{
    public class Wa2F3x : WA
    {
        private string m_gridkey3 = new string(' ', 21);
        private string m_cont_parity_ind = new string(' ', 1);
        private string m_loc_status = new string(' ', 1);
        private string m_county_boundary = new string(' ', 1);
        private string m_dcp_pref_lgc1 = new string(' ', 2);
        private string m_dcp_pref_lgc2 = new string(' ', 2);
        private string m_dcp_pref_lgc3 = new string(' ', 2);
        private string m_lo_x_sts_cnt = new string(' ', 1);
        private B5sc[] m_lo_x_sts = new B5sc[5];
        private string m_hi_x_sts_cnt = new string(' ', 1);
        private B5sc[] m_hi_x_sts = new B5sc[5];
        private string m_x_street_reversal_flag = new string(' ', 1);
        private LionKey m_lionkey = new LionKey();
        private string m_generated_record_flag = new string(' ', 1);
        private string m_segment_len = new string(' ', 5);
        private string m_segment_azm = new string(' ', 3);
        private string m_segment_orient = new string(' ', 1);
        private string m_mh_ri_flag = new string(' ', 1);
        private string m_from_node = new string(' ', 7);
        private string m_to_node = new string(' ', 7);
        private string m_dsny_snow_priority = new string(' ', 1);
        private string m_filler01 = new string(' ', 4);
        private string m_segment_id = new string(' ', 7);
        private string m_dot_street_light_contract_area = new string(' ', 1);
        private string m_curve_flag = new string(' ', 1);
        private string m_dog_leg = new string(' ', 1);
        private string m_feature_type = new string(' ', 1);
        private string m_segment_type = new string(' ', 1);
        private string m_coincident_seg_cnt = new string(' ', 1);
        private string m_pgb_flag = new string(' ', 3);
        private string m_filler02 = new string(' ', 1);
        private SegSide m_left_side = new SegSide();
        private SegSide m_right_side = new SegSide();
        private string[] m_on_street_valid_lgcs = new string[4];
        private string[] m_from_street_valid_lgcs = new string[4];
        private string[] m_to_street_valid_lgcs = new string[4];
        private string m_left_health_center_dist = new string(' ', 2);
        private string m_right_health_center_dist = new string(' ', 2);
        private string m_filler03 = new string(' ', 1);
        private string m_traffic_direction = new string(' ', 1);
        private string m_roadway_type = new string(' ', 2);
        private string m_physical_id = new string(' ', 7);
        private string m_generic_id = new string(' ', 7);
        private string m_nypd_id = new string(' ', 7);
        private string m_fdny_id = new string(' ', 7);
        private string m_street_status = new string(' ', 1);
        private string m_street_width = new string(' ', 3);
        private string m_street_width_irregular = new string(' ', 1);
        private string m_bike_lane = new string(' ', 1);
        private string m_federal_classification_code = new string(' ', 2);
        private string m_right_of_way_type = new string(' ', 1);
        private string[] m_on_street_additional_valid_lgcs = new string[5];
        private string m_legacy_segment_id = new string(' ', 7);
        private string m_nta_name_left = new string(' ', 75);
        private string m_nta_name_right = new string(' ', 75);
        private string m_from_x_coord = new string(' ', 7);
        private string m_from_y_coord = new string(' ', 7);
        private string m_to_x_coord = new string(' ', 7);
        private string m_to_y_coord = new string(' ', 7);
        private string m_from_latitude = new string(' ', 9);
        private string m_from_longitude = new string(' ', 11);
        private string m_to_latitude = new string(' ', 9);
        private string m_to_longitude = new string(' ', 11);
        private string m_left_blockface_id = new string(' ', 10);
        private string m_right_blockface_id = new string(' ', 10);
        private string m_No_Traveling_lanes = new string(' ', 2);
        private string m_No_Parking_lanes = new string(' ', 2);
        private string m_Total_Lanes = new string(' ', 2);
        private string m_bike_lane2 = new string(' ', 2);
        private string m_st_width_max = new string(' ', 3);
        private string m_bike_traffic_direction = new string(' ', 2);
        private string m_speed_limit = new string(' ', 2);
        private string m_left_puma_code = new string(' ', 5);
        private string m_right_puma_code = new string(' ', 5);
        private string m_left_police_sector = new string(' ', 4);
        private string m_right_police_sector = new string(' ', 4);
        private string m_truck_route_type = new string(' ', 1);
        private string m_left_census_tract_2020 = new string(' ', 6);
        private string m_left_census_block_2020 = new string(' ', 4);
        private string m_left_census_block_suffix_2020 = new string(' ', 1);
        private string m_left_nta_2020 = new string(' ', 6);
        private string m_left_cdta_2020 = new string(' ', 4);
        private string m_right_census_tract_2020 = new string(' ', 6);
        private string m_right_census_block_2020 = new string(' ', 4);
        private string m_right_census_block_suffix_2020 = new string(' ', 1);
        private string m_right_nta_2020 = new string(' ', 6);
        private string m_right_cdta_2020 = new string(' ', 4);
        private string m_left_puma_2020 = new string(' ', 5);
        private string m_right_puma_2020 = new string(' ', 5);
        private string m_filler04 = new string(' ', 140);

        public Wa2F3x()
        {
            // Initialize arrays with default values
            for (int i = 0; i < 4; i++)
            {
                m_on_street_valid_lgcs[i] = new string(' ', 2);
                m_from_street_valid_lgcs[i] = new string(' ', 2);
                m_to_street_valid_lgcs[i] = new string(' ', 2);
            }

            // Initialize other default values
            m_left_health_center_dist = new string(' ', 2);
            m_right_health_center_dist = new string(' ', 2);
            m_filler03 = new string(' ', 1);
        }

        public Wa2F3x(string inString) : this()
        {
            Wa2F3xFromString(inString);
        }

        /// <summary>
        /// <c>Clear</c> reinitializes the <c>Wa2F3x</c> object to spaces.
        /// </summary>
        public override void Clear()
        {
            Wa2F3xFromString(new string(' ', 1000));
        }

        /// <summary>
        /// <c>ToString</c> converts a <c>Wa2F3x</c> object to a string.
        /// </summary>
        public override string ToString()
        {
            return Wa2F3xToString();
        }

        /// <summary>
        /// <c>FromString</c> converts a string to a <c>Wa2F3x</c> object.
        /// </summary>
        public override void FromString(string inString)
        {
            Wa2F3xFromString(inString);
        }

        /// <summary>
        /// <c>Wa2F3xToString</c> converts a <c>Wa2F3x</c> object to a string.
        /// </summary>
        public string Wa2F3xToString()
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
            sb.Append(m_curve_flag);
            sb.Append(m_dog_leg);
            sb.Append(m_feature_type);
            sb.Append(m_segment_type);
            sb.Append(m_coincident_seg_cnt);

            sb.Append(m_pgb_flag);
            sb.Append(m_filler02);

            sb.Append(m_left_side.SegSideToString());
            sb.Append(m_right_side.SegSideToString());

            // Arrays and fields handling
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
            sb.Append(m_nta_name_left);
            sb.Append(m_nta_name_right);
            sb.Append(m_from_x_coord);
            sb.Append(m_from_y_coord);
            sb.Append(m_to_x_coord);
            sb.Append(m_to_y_coord);

            sb.Append(m_from_latitude);
            sb.Append(m_from_longitude);
            sb.Append(m_to_latitude);
            sb.Append(m_to_longitude);

            sb.Append(m_left_blockface_id);
            sb.Append(m_right_blockface_id);
            sb.Append(m_No_Traveling_lanes);
            sb.Append(m_No_Parking_lanes);
            sb.Append(m_Total_Lanes);

            sb.Append(m_bike_lane2);
            sb.Append(m_st_width_max);
            sb.Append(m_bike_traffic_direction);

            sb.Append(m_speed_limit);
            sb.Append(m_left_puma_code);
            sb.Append(m_right_puma_code);

            sb.Append(m_left_police_sector);
            sb.Append(m_right_police_sector);

            sb.Append(m_truck_route_type);

            sb.Append(m_left_census_tract_2020);
            sb.Append(m_left_census_block_2020);
            sb.Append(m_left_census_block_suffix_2020);
            sb.Append(m_left_nta_2020);
            sb.Append(m_left_cdta_2020);

            sb.Append(m_right_census_tract_2020);
            sb.Append(m_right_census_block_2020);
            sb.Append(m_right_census_block_suffix_2020);
            sb.Append(m_right_nta_2020);
            sb.Append(m_right_cdta_2020);

            sb.Append(m_left_puma_2020);
            sb.Append(m_right_puma_2020);

            sb.Append(m_filler04);

            return sb.ToString();
        }

        public void Wa2F3xFromString(string inString)
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

            for (i = 0; i < 5; i++)
            {
                try { m_lo_x_sts[i] = new B5sc(inString.Substring(31 + (i * 6), 6)); } catch { m_lo_x_sts[i] = new B5sc(); }
            }

            m_hi_x_sts_cnt = inString.Substring(61, 1);

            for (i = 0; i < 5; i++)
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

            // spo (2007-07-17) added m_from_node & m_to_node
            m_from_node = inString.Substring(114, 7);
            m_to_node = inString.Substring(121, 7);

            // spo(2012-04-06): added for Geosupport Version 11.3 / Release 12A
            m_dsny_snow_priority = inString.Substring(128, 1);
            m_filler01 = inString.Substring(129, 4);
            m_segment_id = inString.Substring(133, 7);
            m_dot_street_light_contract_area = inString.Substring(140, 1);
            m_curve_flag = inString.Substring(141, 1);
            m_dog_leg = inString.Substring(142, 1);
            m_feature_type = inString.Substring(143, 1);
            m_segment_type = inString.Substring(144, 1);

            // spo (2007-07-17) added m_coincident_seg_cnt
            m_coincident_seg_cnt = inString.Substring(145, 1);

            // SPO(2022-05-31): New 3-byte PGB_Flag; Shorten m_filler02 by 3 bytes
            m_pgb_flag = inString.Substring(146, 3);

            m_filler02 = inString.Substring(149, 1);

            m_left_side = new SegSide(inString.Substring(150, 150));
            m_right_side = new SegSide(inString.Substring(300, 150));

            //----------------------------------------------------------------------------------
            // spo(2011-09-25): Geosupport v 11.0 additional fields for extended work area
            //----------------------------------------------------------------------------------
            for (i = 0; i < 4; i++)
            {
                try { m_on_street_valid_lgcs[i] = inString.Substring(450 + (i * 2), 2); } catch { m_on_street_valid_lgcs[i] = string.Empty; }
            }

            for (i = 0; i < 4; i++)
            {
                try { m_from_street_valid_lgcs[i] = inString.Substring(458 + (i * 2), 2); } catch { m_from_street_valid_lgcs[i] = string.Empty; }
            }

            for (i = 0; i < 4; i++)
            {
                try { m_to_street_valid_lgcs[i] = inString.Substring(466 + (i * 2), 2); } catch { m_to_street_valid_lgcs[i] = string.Empty; }
            }

            m_left_health_center_dist = inString.Substring(474, 2);
            m_right_health_center_dist = inString.Substring(476, 2);
            m_filler03 = inString.Substring(478, 1);
            m_traffic_direction = inString.Substring(479, 1);
            m_roadway_type = inString.Substring(480, 2);
            m_physical_id = inString.Substring(482, 7);
            m_generic_id = inString.Substring(489, 7);
            m_nypd_id = inString.Substring(496, 7);
            m_fdny_id = inString.Substring(503, 7);
            m_street_status = inString.Substring(510, 1);
            m_street_width = inString.Substring(511, 3);
            m_street_width_irregular = inString.Substring(514, 1);
            m_bike_lane = inString.Substring(515, 1);
            m_federal_classification_code = inString.Substring(516, 2);
            m_right_of_way_type = inString.Substring(518, 1);

            for (i = 0; i < 5; i++)
            {
                try { m_on_street_additional_valid_lgcs[i] = inString.Substring(519 + (i * 2), 2); } catch { m_on_street_additional_valid_lgcs[i] = string.Empty; }
            }

            m_legacy_segment_id = inString.Substring(529, 7);

            // spo(2012-04-06): added for Geosupport Version 11.3 / Release 12A
            m_nta_name_left = inString.Substring(536, 75);
            m_nta_name_right = inString.Substring(611, 75);

            // spo(2012-07-06): added for Geosupport Version 11.4 / Release 12B
            m_from_x_coord = inString.Substring(686, 7);
            m_from_y_coord = inString.Substring(693, 7);
            m_to_x_coord = inString.Substring(700, 7);
            m_to_y_coord = inString.Substring(707, 7);

            // njp(2015-06-19): added for Geosupport Version 15.3/Release 15C - Start
            m_from_latitude = inString.Substring(714, 9);
            m_from_longitude = inString.Substring(723, 11);
            m_to_latitude = inString.Substring(734, 9);
            m_to_longitude = inString.Substring(743, 11);
            // njp(2015-06-19): added for Geosupport Version 15.3/Release 15C - End

            // njp(2016-02-17) 16.1 changes.
            m_left_blockface_id = inString.Substring(754, 10);
            m_right_blockface_id = inString.Substring(764, 10);
            m_No_Traveling_lanes = inString.Substring(774, 2);
            m_No_Parking_lanes = inString.Substring(776, 2);
            m_Total_Lanes = inString.Substring(778, 2);

            // jgt(2016-09-27) 16.4 changes.
            m_bike_lane2 = inString.Substring(780, 2);
            m_st_width_max = inString.Substring(782, 3);

            // njp(2016-12-12) 17.1 changes
            m_bike_traffic_direction = inString.Substring(785, 2);

            //------------------------------------------------------------------------
            // SPO(2017-09-29): Added new speed_limit 2 byte field for Release 17D
            //                 Requires that I reduce m_filler04 by 2 bytes
            //------------------------------------------------------------------------
            m_speed_limit = inString.Substring(787, 2);

            // SPO(2018-01-03): Added 2 new 5 byte puma_code (left and right) for Geosupport version 18.1
            m_left_puma_code = inString.Substring(789, 5);
            m_right_puma_code = inString.Substring(794, 5);

            // JGT(2018-07-16): Added 4 byte left and right police sector
            m_left_police_sector = inString.Substring(799, 4);
            m_right_police_sector = inString.Substring(803, 4);

            m_truck_route_type = inString.Substring(807, 1);

            //------------------------------------------------------------------
            // spo(2021-05-04): Add 21 bytes for new census 2020 fields
            //------------------------------------------------------------------
            m_left_census_tract_2020 = inString.Substring(808, 6);
            m_left_census_block_2020 = inString.Substring(814, 4);
            m_left_census_block_suffix_2020 = inString.Substring(818, 1);
            m_left_nta_2020 = inString.Substring(819, 6);
            m_left_cdta_2020 = inString.Substring(825, 4);

            m_right_census_tract_2020 = inString.Substring(829, 6);
            m_right_census_block_2020 = inString.Substring(835, 4);
            m_right_census_block_suffix_2020 = inString.Substring(839, 1);
            m_right_nta_2020 = inString.Substring(840, 6);
            m_right_cdta_2020 = inString.Substring(846, 4);

            //--------------------------------------------------------------------
            // spo(2023-02-09): Add Left and Right Puma 2020 fields for 10 bytes
            //--------------------------------------------------------------------

            m_left_puma_2020 = inString.Substring(850, 5);
            m_right_puma_2020 = inString.Substring(855, 5);

            m_filler04 = inString.Substring(860, 140);

        }

        public override string Display(char c)
        {
            StringBuilder sb = new StringBuilder();
            int i;

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

            // spo (2007-07-17) added m_from_node & m_to_node
            sb.Append(m_from_node);
            sb.Append(c);
            sb.Append(m_to_node);
            sb.Append(c);

            //--spo(2012-04-06): added for Geosupport Version 11.3 / Release 12A
            sb.Append(m_dsny_snow_priority);
            sb.Append(c);
            sb.Append(m_filler01);
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

            // spo (2007-07-17) added m_coincident_seg_cnt
            sb.Append(m_coincident_seg_cnt);
            sb.Append(c);

            //--SPO(2022-05-31): New 3-byte PGB_Flag; Shorten m_filler02 by 3 bytes
            sb.Append(m_pgb_flag);
            sb.Append(c);

            sb.Append(m_filler02);
            sb.Append(c);
            sb.Append(m_left_side.Display());
            sb.Append(c);
            sb.Append(m_right_side.Display());
            sb.Append(c);

            //----------------------------------------------------------------------------------
            //--spo(2011-09-25):  Geosupport v 11.0 additional fields for extended work area 
            //----------------------------------------------------------------------------------
            // Arrays are zero based, so there are 4 entries below
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

            // Arrays are zero based so there are 5 entries below
            for (i = 0; i <= 4; i++)
            {
                sb.Append(m_on_street_additional_valid_lgcs[i]);
                sb.Append(c);
            }

            sb.Append(m_legacy_segment_id);
            sb.Append(c);

            //--spo(2012-04-06): added for Geosupport Version 11.3 / Release 12A
            sb.Append(m_nta_name_left);
            sb.Append(c);
            sb.Append(m_nta_name_right);
            sb.Append(c);

            //--spo(2012-07-06): added for Geosupport Version 11.4 / Release 12B
            sb.Append(m_from_x_coord);
            sb.Append(c);
            sb.Append(m_from_y_coord);
            sb.Append(c);
            sb.Append(m_to_x_coord);
            sb.Append(c);
            sb.Append(m_to_y_coord);

            //--njp(2015-06-19): added for Geosupport Version 15.3/Release 15C - Start
            sb.Append(c);
            sb.Append(m_from_latitude);
            sb.Append(c);
            sb.Append(m_from_longitude);
            sb.Append(c);
            sb.Append(m_to_latitude);
            sb.Append(c);
            sb.Append(m_to_longitude);

            //--njp(2015-06-19): added for Geosupport Version 15.3/Release 15C - End

            //--njp(2016-02-17) 16.1 changes.
            sb.Append(c);
            sb.Append(m_left_blockface_id);
            sb.Append(c);
            sb.Append(m_right_blockface_id);
            sb.Append(c);
            sb.Append(m_No_Traveling_lanes);
            sb.Append(c);
            sb.Append(m_No_Parking_lanes);
            sb.Append(c);
            sb.Append(m_Total_Lanes);
            sb.Append(c);

            //--jgt(2016-09-27) 16.4 changes.
            sb.Append(m_bike_lane2);
            sb.Append(c);
            sb.Append(m_st_width_max);
            sb.Append(c);

            //--njp(2016-12-12) 17.1 changes
            sb.Append(m_bike_traffic_direction);
            sb.Append(c);

            //------------------------------------------------------------------
            //--SPO(2017-09-29): Added new speed_limit 2 byte field for Release 17D
            //------------------------------------------------------------------
            sb.Append(m_speed_limit);
            sb.Append(c);

            //--SPO(2018-01-03): Added 2 new 5 byte puma_code (left and right) for Geosupport version 18.1
            sb.Append(m_left_puma_code);
            sb.Append(c);
            sb.Append(m_right_puma_code);
            sb.Append(c);
            sb.Append(m_left_police_sector);
            sb.Append(c);
            sb.Append(m_right_police_sector);
            sb.Append(c);

            sb.Append(m_truck_route_type);
            sb.Append(c);

            //------------------------------------------------------------------
            //--spo(2021-05-04): Add 21 bytes for new census 2020 fields
            //------------------------------------------------------------------
            sb.Append(m_left_census_tract_2020);
            sb.Append(c);
            sb.Append(m_left_census_block_2020);
            sb.Append(c);
            sb.Append(m_left_census_block_suffix_2020);
            sb.Append(c);
            sb.Append(m_left_nta_2020);
            sb.Append(c);
            sb.Append(m_left_cdta_2020);
            sb.Append(c);

            sb.Append(m_right_census_tract_2020);
            sb.Append(c);
            sb.Append(m_right_census_block_2020);
            sb.Append(c);
            sb.Append(m_right_census_block_suffix_2020);
            sb.Append(c);
            sb.Append(m_right_nta_2020);
            sb.Append(c);
            sb.Append(m_right_cdta_2020);
            sb.Append(c);

            //------------------------------------------------------------------
            //--spo(2023-03-15): added left and right puma 2020 fields
            //------------------------------------------------------------------
            sb.Append(m_left_puma_2020);
            sb.Append(c);
            sb.Append(m_right_puma_2020);
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
        /// <para>Creates a string with <c>Wa2F3x</c> field names and values</para>
        /// </summary>
        public override string Print()
        {
            StringBuilder sb = new StringBuilder();
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

            // Added m_from_node & m_to_node
            sb.AppendFormat("from_node = {0}{1}", m_from_node, Environment.NewLine);
            sb.AppendFormat("to_node = {0}{1}", m_to_node, Environment.NewLine);

            // Geosupport Version 11.3 / Release 12A 
            sb.AppendFormat("dsny_snow_priority = {0}{1}", m_dsny_snow_priority, Environment.NewLine);
            sb.AppendFormat("filler01 = {0}{1}", m_filler01, Environment.NewLine);
            sb.AppendFormat("segment_id = {0}{1}", m_segment_id, Environment.NewLine);
            sb.AppendFormat("dot_street_light_contract_area = {0}{1}", m_dot_street_light_contract_area, Environment.NewLine);
            sb.AppendFormat("curve_flag = {0}{1}", m_curve_flag, Environment.NewLine);
            sb.AppendFormat("dog_leg = {0}{1}", m_dog_leg, Environment.NewLine);
            sb.AppendFormat("feature_type = {0}{1}", m_feature_type, Environment.NewLine);
            sb.AppendFormat("segment_type = {0}{1}", m_segment_type, Environment.NewLine);

            // Added m_coincident_seg_cnt 
            sb.AppendFormat("coincident_seg_cnt = {0}{1}", m_coincident_seg_cnt, Environment.NewLine);

            // Geosupport Version 11.3 / Release 12A
            sb.AppendFormat("pgb_flag = {0}{1}", m_pgb_flag, Environment.NewLine);

            sb.AppendFormat("filler02 = {0}{1}", m_filler02, Environment.NewLine);

            // Enhanced Segside data
            sb.AppendFormat("********************************************* {0}", Environment.NewLine);
            sb.AppendFormat("left_side (display) = {0}{1}", m_left_side.Display(), Environment.NewLine);
            sb.AppendFormat("********************************************* {0}", Environment.NewLine);
            sb.AppendFormat("left_side (print) = {0}", Environment.NewLine);
            sb.AppendFormat("{0}", m_left_side.Print);
            sb.AppendFormat("********************************************* {0}", Environment.NewLine);
            sb.AppendFormat("right_side (display) = {0}{1}", m_right_side.Display(), Environment.NewLine);
            sb.AppendFormat("********************************************* {0}", Environment.NewLine);
            sb.AppendFormat("right_side (print) = {0}", Environment.NewLine);
            sb.AppendFormat("{0}", m_right_side.Print);
            sb.AppendFormat("********************************************* {0}", Environment.NewLine);

            // Geosupport v 11.0 additional fields
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

            // Geosupport Version 11.3 / Release 12A
            sb.AppendFormat("left_nta_name_2010 = {0}{1}", m_nta_name_left, Environment.NewLine);
            sb.AppendFormat("right_nta_name_2010 = {0}{1}", m_nta_name_right, Environment.NewLine);

            // Geosupport Version 11.4 / Release 12B
            sb.AppendFormat("from_x_coord = {0}{1}", m_from_x_coord, Environment.NewLine);
            sb.AppendFormat("from_y_coord = {0}{1}", m_from_y_coord, Environment.NewLine);
            sb.AppendFormat("to_x_coord = {0}{1}", m_to_x_coord, Environment.NewLine);
            sb.AppendFormat("to_y_coord = {0}{1}", m_to_y_coord, Environment.NewLine);

            // Geosupport Version 15.3 / Release 15C
            sb.AppendFormat("from_latitude = {0}{1}", m_from_latitude, Environment.NewLine);
            sb.AppendFormat("from_longitude = {0}{1}", m_from_longitude, Environment.NewLine);
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

            // --SPO(2017-09-29): Added new speed_limit 2 byte field for Release 17D
            sb.AppendFormat("speed_limit = {0}{1}", m_speed_limit, Environment.NewLine);

            sb.AppendLine();
            sb.AppendLine("**********  Other District Information  **********");
            sb.AppendLine();

            sb.AppendFormat("dsny_snow_priority = {0}{1}", m_dsny_snow_priority, Environment.NewLine);
            sb.AppendFormat("dot_street_light_contract_area = {0}{1}", m_dot_street_light_contract_area, Environment.NewLine);

            sb.AppendLine();
            sb.AppendLine("**********  Cross Streets Information  **********");
            sb.AppendLine();

            sb.AppendFormat("x_street_reversal_flag = {0}{1}", m_x_street_reversal_flag, Environment.NewLine);

            sb.AppendLine();

            sb.AppendFormat("lo_x_sts_cnt = {0}{1}", m_lo_x_sts_cnt, Environment.NewLine);
            for (i = 0; i <= 4; i++)
            {
                sb.AppendFormat("lo_x_sts({0}) = {1}{2}", i, m_lo_x_sts[i].Display(), Environment.NewLine);
            }

            sb.AppendLine();

            for (i = 0; i <= 3; i++)
            {
                sb.AppendFormat("from_street_valid_lgcs({0}) = {1}{2}", i, m_from_street_valid_lgcs[i], Environment.NewLine);
            }

            sb.AppendLine();

            sb.AppendFormat("hi_x_sts_cnt = {0}{1}", m_hi_x_sts_cnt, Environment.NewLine);
            for (i = 0; i <= 4; i++)
            {
                sb.AppendFormat("hi_x_sts({0}) = {1}{2}", i, m_hi_x_sts[i].Display(), Environment.NewLine);
            }

            sb.AppendLine();

            for (i = 0; i <= 3; i++)
            {
                sb.AppendFormat("to_street_valid_lgcs({0}) = {1}{2}", i, m_to_street_valid_lgcs[i], Environment.NewLine);
            }

            sb.AppendLine();

            // --spo(2016-05-10): Enhanced the presentation of Segside data
            sb.AppendLine("*********************************************");
            sb.AppendLine("LEFT SIDE");
            sb.AppendLine("*********************************************");
            sb.AppendLine(m_left_side.Print());

            sb.AppendLine();

            sb.AppendFormat("left_blockface_id = {0}{1}", m_left_blockface_id, Environment.NewLine);
            sb.AppendFormat("left_health_center_dist = {0}{1}", m_left_health_center_dist, Environment.NewLine);
            sb.AppendFormat("left_nta_name_2010 = {0}{1}", m_nta_name_left, Environment.NewLine);
            // SPO(2018-01-03): Added 2 new 5 byte puma_code (left and right) for Geosupport version 18.1
            sb.AppendFormat("left_puma_code = {0}{1}", m_left_puma_code, Environment.NewLine);
            sb.AppendFormat("left_police_sector = {0}{1}", m_left_police_sector, Environment.NewLine);
            // ------------------------------------------------------------------
            // SPO(2021-05-04): Add 21 bytes for new census 2020 fields
            // ------------------------------------------------------------------
            sb.AppendFormat("left_census_tract_2020 = {0}{1}", m_left_census_tract_2020, Environment.NewLine);
            sb.AppendFormat("left_census_block_2020 = {0}{1}", m_left_census_block_2020, Environment.NewLine);
            sb.AppendFormat("left_census_block_suffix_2020 = {0}{1}", m_left_census_block_suffix_2020, Environment.NewLine);
            sb.AppendFormat("left_nta_2020 = {0}{1}", m_left_nta_2020, Environment.NewLine);
            sb.AppendFormat("left_cdta_2020 = {0}{1}", m_left_cdta_2020, Environment.NewLine);
            sb.AppendFormat("left_puma_2020 = {0}{1}", m_left_puma_2020, Environment.NewLine);

            sb.AppendFormat("********************************************* {0}", Environment.NewLine);
            sb.AppendFormat("{0}", Environment.NewLine);

            sb.AppendFormat("********************************************* {0}", Environment.NewLine);
            sb.AppendFormat("RIGHT SIDE {0}", Environment.NewLine);
            sb.AppendFormat("********************************************* {0}", Environment.NewLine);
            sb.AppendFormat("{0}", m_right_side.Print);

            sb.AppendFormat("{0}", Environment.NewLine);

            sb.AppendFormat("right_blockface_id = {0}{1}", m_right_blockface_id, Environment.NewLine);
            sb.AppendFormat("right_health_center_dist = {0}{1}", m_right_health_center_dist, Environment.NewLine);
            sb.AppendFormat("right_nta_name_2010 = {0}{1}", m_nta_name_right, Environment.NewLine);
            // SPO(2018-01-03): Added 2 new 5 byte puma_code (left and right) for Geosupport version 18.1
            sb.AppendFormat("right_puma_code = {0}{1}", m_right_puma_code, Environment.NewLine);
            sb.AppendFormat("right_police_sector = {0}{1}", m_right_police_sector, Environment.NewLine);
            // ------------------------------------------------------------------
            // SPO(2021-05-04): Add 21 bytes for new census 2020 fields
            // ------------------------------------------------------------------
            sb.AppendFormat("right_census_tract_2020 = {0}{1}", m_right_census_tract_2020, Environment.NewLine);
            sb.AppendFormat("right_census_block_2020 = {0}{1}", m_right_census_block_2020, Environment.NewLine);
            sb.AppendFormat("right_census_block_suffix_2020 = {0}{1}", m_right_census_block_suffix_2020, Environment.NewLine);
            sb.AppendFormat("right_nta_2020 = {0}{1}", m_right_nta_2020, Environment.NewLine);
            sb.AppendFormat("right_cdta_2020 = {0}{1}", m_right_cdta_2020, Environment.NewLine);
            sb.AppendFormat("right_puma_2020 = {0}{1}", m_right_puma_2020, Environment.NewLine);

            sb.AppendFormat("********************************************* {0}", Environment.NewLine);

            sb.AppendFormat("{0}{1}", Environment.NewLine + "**********  Miscellaneous Filler Information  **********", Environment.NewLine + Environment.NewLine);

            sb.AppendFormat("filler01 = {0}{1}", m_filler01, Environment.NewLine);
            sb.AppendFormat("filler02 = {0}{1}", m_filler02, Environment.NewLine);
            sb.AppendFormat("filler03 = {0}{1}", m_filler03, Environment.NewLine);
            sb.AppendFormat("filler04 = {0}{1}", m_filler04, Environment.NewLine);

            sb.AppendFormat("{0}", Environment.NewLine);

            return sb.ToString();

        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            int i;

            sb.AppendLine();
            sb.AppendLine("****************************************************************************");
            sb.AppendLine("******************************  Wa2F3x  ***********************************");
            sb.AppendLine("****************************************************************************");

            sb.AppendLine();
            sb.AppendLine("**********  Key Information  **********");
            sb.AppendLine();

            sb.AppendFormat("gridkey3 = {0}{1}", m_gridkey3, Environment.NewLine);
            sb.AppendFormat("cont_parity_ind = {0}{1}", m_cont_parity_ind, Environment.NewLine);
            sb.AppendFormat("loc_status = {0}{1}", m_loc_status, Environment.NewLine);
            sb.AppendFormat("county_boundary = {0}{1}", m_county_boundary, Environment.NewLine);

            // --SPO(2022-05-31): New 3-byte PGB_Flag; Shorten m_filler02 by 3 bytes
            sb.AppendFormat("pgb_flag = {0}{1}", m_pgb_flag, Environment.NewLine);

            sb.AppendLine();

            sb.AppendFormat("dcp_pref_lgc1 = {0}{1}", m_dcp_pref_lgc1, Environment.NewLine);
            sb.AppendFormat("dcp_pref_lgc2 = {0}{1}", m_dcp_pref_lgc2, Environment.NewLine);
            sb.AppendFormat("dcp_pref_lgc3 = {0}{1}", m_dcp_pref_lgc3, Environment.NewLine);

            sb.AppendLine();

            for (i = 0; i <= 3; i++)
            {
                sb.AppendFormat("on_street_valid_lgcs({0}) = {1}{2}", i, m_on_street_valid_lgcs[i], Environment.NewLine);
            }

            sb.AppendLine();

            for (i = 0; i <= 4; i++)
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

            // --SPO(2017-09-29): Added new speed_limit 2 byte field for Release 17D
            sb.AppendFormat("speed_limit = {0}{1}", m_speed_limit, Environment.NewLine);

            sb.AppendLine();
            sb.AppendLine("**********  Other District Information  **********");
            sb.AppendLine();

            sb.AppendFormat("dsny_snow_priority = {0}{1}", m_dsny_snow_priority, Environment.NewLine);
            sb.AppendFormat("dot_street_light_contract_area = {0}{1}", m_dot_street_light_contract_area, Environment.NewLine);

            sb.AppendLine();
            sb.AppendLine("**********  Cross Streets Information  **********");
            sb.AppendLine();

            sb.AppendFormat("x_street_reversal_flag = {0}{1}", m_x_street_reversal_flag, Environment.NewLine);

            sb.AppendLine();

            sb.AppendFormat("lo_x_sts_cnt = {0}{1}", m_lo_x_sts_cnt, Environment.NewLine);
            for (i = 0; i <= 4; i++)
            {
                sb.AppendFormat("lo_x_sts({0}) = {1}{2}", i, m_lo_x_sts[i].Display(), Environment.NewLine);
            }

            sb.AppendLine();

            for (i = 0; i <= 3; i++)
            {
                sb.AppendFormat("from_street_valid_lgcs({0}) = {1}{2}", i, m_from_street_valid_lgcs[i], Environment.NewLine);
            }

            sb.AppendLine();

            sb.AppendFormat("hi_x_sts_cnt = {0}{1}", m_hi_x_sts_cnt, Environment.NewLine);
            for (i = 0; i <= 4; i++)
            {
                sb.AppendFormat("hi_x_sts({0}) = {1}{2}", i, m_hi_x_sts[i].Display(), Environment.NewLine);
            }

            sb.AppendLine();

            for (i = 0; i <= 3; i++)
            {
                sb.AppendFormat("to_street_valid_lgcs({0}) = {1}{2}", i, m_to_street_valid_lgcs[i], Environment.NewLine);
            }

            sb.AppendLine();

            // --spo(2016-05-10): Enhanced the presentation of Segside data
            sb.AppendLine("*********************************************");
            sb.AppendLine("LEFT SIDE");
            sb.AppendLine("*********************************************");
            sb.AppendLine(m_left_side.Print());
            sb.AppendLine(); // Newline equivalent to vbCrLf

            sb.AppendFormat("left_blockface_id = {0}{1}", m_left_blockface_id, Environment.NewLine);
            sb.AppendFormat("left_health_center_dist = {0}{1}", m_left_health_center_dist, Environment.NewLine);
            sb.AppendFormat("left_nta_name_2010 = {0}{1}", m_nta_name_left, Environment.NewLine);
            // SPO(2018-01-03): Added 2 new 5 byte puma_code (left and right) for Geosupport version 18.1
            sb.AppendFormat("left_puma_code = {0}{1}", m_left_puma_code, Environment.NewLine);
            sb.AppendFormat("left_police_sector = {0}{1}", m_left_police_sector, Environment.NewLine);
            // ------------------------------------------------------------------
            // SPO(2021-05-04): Add 21 bytes for new census 2020 fields
            // ------------------------------------------------------------------
            sb.AppendFormat("left_census_tract_2020 = {0}{1}", m_left_census_tract_2020, Environment.NewLine);
            sb.AppendFormat("left_census_block_2020 = {0}{1}", m_left_census_block_2020, Environment.NewLine);
            sb.AppendFormat("left_census_block_suffix_2020 = {0}{1}", m_left_census_block_suffix_2020, Environment.NewLine);
            sb.AppendFormat("left_nta_2020 = {0}{1}", m_left_nta_2020, Environment.NewLine);
            sb.AppendFormat("left_cdta_2020 = {0}{1}", m_left_cdta_2020, Environment.NewLine);
            sb.AppendFormat("left_puma_2020 = {0}{1}", m_left_puma_2020, Environment.NewLine);

            sb.AppendFormat("********************************************* {0}", Environment.NewLine);

            sb.AppendLine(); // Newline equivalent to vbCrLf

            sb.AppendFormat("********************************************* {0}", Environment.NewLine);
            sb.AppendFormat("RIGHT SIDE {0}", Environment.NewLine);
            sb.AppendFormat("********************************************* {0}", Environment.NewLine);
            sb.AppendFormat("{0}", m_right_side.Print());

            sb.AppendLine(); // Newline equivalent to vbCrLf

            sb.AppendFormat("right_blockface_id = {0}{1}", m_right_blockface_id, Environment.NewLine);
            sb.AppendFormat("right_health_center_dist = {0}{1}", m_right_health_center_dist, Environment.NewLine);
            sb.AppendFormat("right_nta_name_2010 = {0}{1}", m_nta_name_right, Environment.NewLine);
            // SPO(2018-01-03): Added 2 new 5 byte puma_code (left and right) for Geosupport version 18.1
            sb.AppendFormat("right_puma_code = {0}{1}", m_right_puma_code, Environment.NewLine);
            sb.AppendFormat("right_police_sector = {0}{1}", m_right_police_sector, Environment.NewLine);
            // ------------------------------------------------------------------
            // SPO(2021-05-04): Add 21 bytes for new census 2020 fields
            // ------------------------------------------------------------------
            sb.AppendFormat("right_census_tract_2020 = {0}{1}", m_right_census_tract_2020, Environment.NewLine);
            sb.AppendFormat("right_census_block_2020 = {0}{1}", m_right_census_block_2020, Environment.NewLine);
            sb.AppendFormat("right_census_block_suffix_2020 = {0}{1}", m_right_census_block_suffix_2020, Environment.NewLine);
            sb.AppendFormat("right_nta_2020 = {0}{1}", m_right_nta_2020, Environment.NewLine);
            sb.AppendFormat("right_cdta_2020 = {0}{1}", m_right_cdta_2020, Environment.NewLine);
            sb.AppendFormat("right_puma_2020 = {0}{1}", m_right_puma_2020, Environment.NewLine);

            sb.AppendFormat("********************************************* {0}", Environment.NewLine);

            sb.AppendLine(); // Newline equivalent to vbCrLf

            sb.AppendLine("**********  Miscellaneous Filler Information  **********");
            sb.AppendLine();

            sb.AppendFormat("filler01 = {0}{1}", m_filler01, Environment.NewLine);
            sb.AppendFormat("filler02 = {0}{1}", m_filler02, Environment.NewLine);
            sb.AppendFormat("filler03 = {0}{1}", m_filler03, Environment.NewLine);
            sb.AppendFormat("filler04 = {0}{1}", m_filler04, Environment.NewLine);

            sb.AppendLine(); // Newline equivalent to vbCrLf

            return sb.ToString();
        }

        public string gridkey3
        {
            get => m_gridkey3;
            set
            {
                int strlen = value.Length > 21 ? 21 : value.Length;
                m_gridkey3 = value.Substring(0, strlen);
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
                int strlen = value.Length > 1 ? 1 : value.Length;
                m_hi_x_sts_cnt = value.Substring(0, strlen);
            }
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

        public string filler01
        {
            get => m_filler01;
            set
            {
                int strlen = value.Length > 4 ? 4 : value.Length;
                m_filler01 = value.Substring(0, strlen);
            }
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

        public string curve_flag
        {
            get => m_curve_flag;
            set => m_curve_flag = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string dog_leg
        {
            get => m_dog_leg;
            set => m_dog_leg = value.Length > 1 ? value.Substring(0, 1) : value;
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

        public string coincident_seg_cnt
        {
            get => m_coincident_seg_cnt;
            set => m_coincident_seg_cnt = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string pgb_flag
        {
            get => m_pgb_flag;
            set => m_pgb_flag = value.Length > 3 ? value.Substring(0, 3) : value;
        }

        public string filler02
        {
            get => m_filler02;
            set => m_filler02 = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public SegSide left_side
        {
            get => m_left_side;
            set => m_left_side = value;
        }

        public SegSide right_side
        {
            get => m_right_side;
            set => m_right_side = value;
        }

        public string[] on_street_valid_lgcs
        {
            get => m_on_street_valid_lgcs;
            set => m_on_street_valid_lgcs = value;
        }

        public string on_street_valid_lgcs_item(int index) => m_on_street_valid_lgcs[index];
        public void on_street_valid_lgcs_item(int index, string value) => m_on_street_valid_lgcs[index] = value.Length > 2 ? value.Substring(0, 2) : value;
        

        public string[] from_street_valid_lgcs
        {
            get => m_from_street_valid_lgcs;
            set => m_from_street_valid_lgcs = value;
        }

        public string from_street_valid_lgcs_item(int index) => m_from_street_valid_lgcs[index];
        public void from_street_valid_lgcs_item(int index, string value) => m_from_street_valid_lgcs[index] = value.Length > 2 ? value.Substring(0, 2) : value;
        

        public string[] to_street_valid_lgcs
        {
            get => m_to_street_valid_lgcs;
            set => m_to_street_valid_lgcs = value;
        }

        public string to_street_valid_lgcs_item(int index) => m_to_street_valid_lgcs[index];
        public void to_street_valid_lgcs_item(int index, string value) => m_to_street_valid_lgcs[index] = value.Length > 2 ? value.Substring(0, 2) : value;
        

        public string left_health_center_dist
        {
            get => m_left_health_center_dist;
            set => m_left_health_center_dist = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        public string right_health_center_dist
        {
            get => m_right_health_center_dist;
            set => m_right_health_center_dist = value.Length > 2 ? value.Substring(0, 2) : value;
        }

        public string filler03
        {
            get => m_filler03;
            set => m_filler03 = value.Length > 1 ? value.Substring(0, 1) : value;
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
            set
            {
                int strlen = value.Length > 1 ? 1 : value.Length;
                m_street_width_irregular = value.Substring(0, strlen).PadRight(1);
            }
        }

        public string bike_lane
        {
            get => m_bike_lane;
            set
            {
                int strlen = value.Length > 1 ? 1 : value.Length;
                m_bike_lane = value.Substring(0, strlen).PadRight(1);
            }
        }

        public string federal_classification_code
        {
            get => m_federal_classification_code;
            set
            {
                int strlen = value.Length > 2 ? 2 : value.Length;
                m_federal_classification_code = value.Substring(0, strlen).PadRight(2);
            }
        }

        public string right_of_way_type
        {
            get => m_right_of_way_type;
            set
            {
                int strlen = value.Length > 1 ? 1 : value.Length;
                m_right_of_way_type = value.Substring(0, strlen).PadRight(1);
            }
        }

        public string[] on_street_additional_valid_lgcs
        {
            get => m_on_street_additional_valid_lgcs;
            set => m_on_street_additional_valid_lgcs = value;
        }

        public string on_street_additional_valid_lgcs_item(int index) => m_on_street_additional_valid_lgcs[index];

        public void on_street_additional_valid_lgcs_item(int index, string value)
        {
            int strlen = value.Length > 2 ? 2 : value.Length;
            m_on_street_additional_valid_lgcs[index] = value.Substring(0, strlen).PadRight(2);
        }
        

        public string legacy_segment_id
        {
            get => m_legacy_segment_id;
            set
            {
                int strlen = value.Length > 7 ? 7 : value.Length;
                m_legacy_segment_id = value.Substring(0, strlen).PadRight(7);
            }
        }

        public string nta_name_left
        {
            get => m_nta_name_left;
            set
            {
                int strlen = value.Length > 75 ? 75 : value.Length;
                m_nta_name_left = value.Substring(0, strlen).PadRight(75);
            }
        }

        public string nta_name_right
        {
            get => m_nta_name_right;
            set
            {
                int strlen = value.Length > 75 ? 75 : value.Length;
                m_nta_name_right = value.Substring(0, strlen).PadRight(75);
            }
        }

        public string from_x_coord
        {
            get => m_from_x_coord;
            set
            {
                int strlen = value.Length > 7 ? 7 : value.Length;
                m_from_x_coord = value.Substring(0, strlen).PadRight(7);
            }
        }

        public string from_y_coord
        {
            get => m_from_y_coord;
            set
            {
                int strlen = value.Length > 7 ? 7 : value.Length;
                m_from_y_coord = value.Substring(0, strlen).PadRight(7);
            }
        }

        public string to_x_coord
        {
            get => m_to_x_coord;
            set
            {
                int strlen = value.Length > 7 ? 7 : value.Length;
                m_to_x_coord = value.Substring(0, strlen).PadRight(7);
            }
        }

        public string to_y_coord
        {
            get => m_to_y_coord;
            set
            {
                int strlen = value.Length > 7 ? 7 : value.Length;
                m_to_y_coord = value.Substring(0, strlen).PadRight(7);
            }
        }

        public string from_latitude
        {
            get => m_from_latitude;
            set
            {
                int strlen = value.Length > 9 ? 9 : value.Length;
                m_from_latitude = value.Substring(0, strlen).PadRight(9);
            }
        }

        public string from_longitude
        {
            get => m_from_longitude;
            set
            {
                int strlen = value.Length > 11 ? 11 : value.Length;
                m_from_longitude = value.Substring(0, strlen).PadRight(11);
            }
        }

        public string to_latitude
        {
            get => m_to_latitude;
            set
            {
                int strlen = value.Length > 9 ? 9 : value.Length;
                m_to_latitude = value.Substring(0, strlen).PadRight(9);
            }
        }

        public string to_longitude
        {
            get => m_to_longitude;
            set
            {
                int strlen = value.Length > 11 ? 11 : value.Length;
                m_to_longitude = value.Substring(0, strlen).PadRight(11);
            }
        }

        public string left_blockface_id
        {
            get => m_left_blockface_id;
            set
            {
                int strlen = value.Length > 10 ? 10 : value.Length;
                m_left_blockface_id = value.Substring(0, strlen).PadRight(10);
            }
        }

        public string right_blockface_id
        {
            get => m_right_blockface_id;
            set => m_right_blockface_id = value.Length > 10 ? value.Substring(0, 10) : value;
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

        public string left_puma_code
        {
            get => m_left_puma_code;
            set => m_left_puma_code = value.Length > 5 ? value.Substring(0, 5) : value;
        }

        public string right_puma_code
        {
            get => m_right_puma_code;
            set => m_right_puma_code = value.Length > 5 ? value.Substring(0, 5) : value;
        }

        public string left_police_sector
        {
            get => m_left_police_sector;
            set => m_left_police_sector = value.Length > 4 ? value.Substring(0, 4) : value;
        }

        public string right_police_sector
        {
            get => m_right_police_sector;
            set => m_right_police_sector = value.Length > 4 ? value.Substring(0, 4) : value;
        }

        public string truck_route_type
        {
            get => m_truck_route_type;
            set => m_truck_route_type = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string left_census_tract_2020
        {
            get => m_left_census_tract_2020;
            set => m_left_census_tract_2020 = value.Length > 6 ? value.Substring(0, 6) : value;
        }

        public string left_census_block_2020
        {
            get => m_left_census_block_2020;
            set => m_left_census_block_2020 = value.Length > 4 ? value.Substring(0, 4) : value;
        }

        public string left_census_block_suffix_2020
        {
            get => m_left_census_block_suffix_2020;
            set => m_left_census_block_suffix_2020 = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string left_nta_2020
        {
            get => m_left_nta_2020;
            set => m_left_nta_2020 = value.Length > 6 ? value.Substring(0, 6) : value;
        }

        public string left_cdta_2020
        {
            get => m_left_cdta_2020;
            set => m_left_cdta_2020 = value.Length > 4 ? value.Substring(0, 4) : value;
        }

        public string right_census_tract_2020
        {
            get => m_right_census_tract_2020;
            set => m_right_census_tract_2020 = value.Length > 6 ? value.Substring(0, 6) : value;
        }

        public string right_census_block_2020
        {
            get => m_right_census_block_2020;
            set => m_right_census_block_2020 = value.Length > 4 ? value.Substring(0, 4) : value;
        }

        public string right_census_block_suffix_2020
        {
            get => m_right_census_block_suffix_2020;
            set => m_right_census_block_suffix_2020 = value.Length > 1 ? value.Substring(0, 1) : value;
        }

        public string right_nta_2020
        {
            get => m_right_nta_2020;
            set => m_right_nta_2020 = value.Length > 6 ? value.Substring(0, 6) : value;
        }

        public string right_cdta_2020
        {
            get => m_right_cdta_2020;
            set => m_right_cdta_2020 = value.Length > 4 ? value.Substring(0, 4) : value;
        }

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

        public string filler04
        {
            get => m_filler04;
            set => m_filler04 = value.Length > 140 ? value.Substring(0, 140) : value;
        }

    }

}
