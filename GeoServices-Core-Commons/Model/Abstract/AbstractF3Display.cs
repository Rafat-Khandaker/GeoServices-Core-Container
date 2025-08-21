using GeoXWrapperLib.Model;
using GeoXWrapperTest.Helper;
using GeoXWrapperTest.Model.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperTest.Model.Abstract
{
    public abstract class AbstractF3Display 
    {
        protected Wa1 _wa1;

        #region Data Lists
        public abstract List<string> AuxiliarySegmentIDList { get; } //CHILD MUST OVERRIDE
        public List<LowHighB7SC> LowB7SCList { get;  set; }
        public List<LowHighB7SC> HighB7SCList { get;  set; }

        public List<SimilarName> SimilarNamesList => ValidationHelper.CreateSimilarNamesList(_wa1.out_b7sc_list, _wa1.out_stname_list);
        #endregion

        #region Fully Implemented Properties
        public string in_func_code => _wa1.in_func_code;
        public string in_boro => _wa1.in_boro1;
        public string in_stname1 => _wa1.in_stname1;
        public string in_boro2 => _wa1.in_boro2;
        public string in_stname2 => _wa1.in_stname2;
        public string in_boro3 => _wa1.in_boro3;
        public string in_stname3 => _wa1.in_stname3;
        public string in_compass_dir => _wa1.in_compass_dir;
        public string in_browse_flag => _wa1.in_browse_flag;

        public string out_grc => _wa1.out_grc;
        public string out_grc2 => _wa1.out_grc2;
        public string out_error_message => _wa1.out_error_message;
        public string out_reason_code => _wa1.out_reason_code;
        public string out_stname1 => _wa1.out_stname1;
        public string out_stname2 => _wa1.out_stname2;
        public string out_stname3 => _wa1.out_stname3;
        public string out_wa1_message => _wa1.out_error_message;
        public string out_zip_code => _wa1.in_zip_code;
        public bool out_compass => !string.IsNullOrWhiteSpace(_wa1.in_compass_dir);
        #endregion

        #region Implementing Classes Must Provide Overrides
        public abstract string out_from_node { get; }
        public abstract string out_to_node { get; }
        public abstract string out_lionkey { get; }
        public abstract string out_from_x_coord { get; }
        public abstract string out_from_y_coord { get; }
        public abstract string out_to_x_coord { get; }
        public abstract string out_to_y_coord { get; }
        public abstract string out_dot_street_light_contract_area { get; }
        public abstract string out_segment_id { get; }
        public abstract string out_segment_len { get; }
        public abstract string out_physical_id { get; }
        public abstract string out_generic_id { get; }
        public abstract string out_loc_status { get; }
        public abstract string out_traffic_direction { get; }
        public abstract string out_segment_type { get; }
        public abstract string out_feature_type { get; }
        public abstract string out_roadway_type { get; }
        public abstract string out_right_of_way_type { get; }
        public abstract string out_No_Traveling_lanes { get; }
        public abstract string out_No_Parking_lanes { get; }
        public abstract string out_Total_Lanes { get; }
        public abstract string out_street_width_min { get; }
        public abstract string out_street_width_max { get; }
        public abstract string out_speed_limit { get; }
        public abstract string out_street_width_irregular { get; }
        public abstract string out_boro_name1 { get; }
        //public abstract string out_boro_name2 { get; }
        //public abstract string out_boro_name3 { get; }
        public abstract string out_truck_route_type { get; }
        public abstract string out_pgb_flag { get; }

        public abstract string out_left_side_boro { get; }
        public abstract string out_left_side_comdist { get; }
        public abstract string out_left_side_comdist_boro { get; }
        public abstract string out_left_side_lhnd { get; }
        public abstract string out_left_side_hhnd { get; }
        public abstract string out_left_side_zip_code { get; }
        public abstract string out_left_side_census_tract_2020 { get; }
        public abstract string out_left_side_census_block_2020 { get; }
        public abstract string out_left_side_census_block_suffix_2020 { get; }
        public abstract string out_left_side_nta_2020 { get; }
        public abstract string out_left_side_cdta_2020 { get; }
        public abstract string out_left_side_census_tract_2010 { get; }
        public abstract string out_left_side_census_block_2010 { get; }
        public abstract string out_left_side_census_tract_2000 { get; }
        public abstract string out_left_side_census_block_2000 { get; }
        public abstract string out_left_side_police_sector { get; }
        public abstract string out_left_side_police_patrol_boro { get; }
        public abstract string out_left_side_police_pct { get; }
        public abstract string out_left_side_fire_div { get; }
        public abstract string out_left_side_fire_bat { get; }
        public abstract string out_left_side_fire_co { get; }
        public abstract string out_left_side_health_area { get; }
        public abstract string out_left_side_health_center_dist { get; }
        public abstract string out_left_side_puma_code { get; }
        public abstract string out_left_side_puma_2020 { get; }
        //public abstract string out_left_side_dot_street_light_contract_area { get; }
        public abstract string out_left_side_school_dist { get; }
        public abstract string out_left_side_iaei { get; }
        public abstract string out_left_side_blockface_id { get; }
        public abstract string out_left_side_nta { get; }
        public abstract string out_left_side_atomic_polygon { get; }
        public abstract string out_left_side_cd_eligibility { get; }

        public abstract string out_dsny_snow_priority { get; }

        public abstract string out_right_side_boro { get; }
        public abstract string out_right_side_comdist { get; }
        public abstract string out_right_side_comdist_boro { get; }
        public abstract string out_right_side_lhnd { get; }
        public abstract string out_right_side_hhnd { get; }
        public abstract string out_right_side_zip_code { get; }
        public abstract string out_right_side_census_tract_2020 { get; }
        public abstract string out_right_side_census_block_2020 { get; }
        public abstract string out_right_side_census_block_suffix_2020 { get; }
        public abstract string out_right_side_nta_2020 { get; }
        public abstract string out_right_side_cdta_2020 { get; }
        public abstract string out_right_side_census_tract_2010 { get; }
        public abstract string out_right_side_census_block_2010 { get; }
        public abstract string out_right_side_census_tract_2000 { get; }
        public abstract string out_right_side_census_block_2000 { get; }
        public abstract string out_right_side_police_patrol_boro { get; }
        public abstract string out_right_side_police_sector { get; }
        public abstract string out_right_side_police_pct { get; }
        public abstract string out_right_side_fire_div { get; }
        public abstract string out_right_side_fire_bat { get; }
        public abstract string out_right_side_fire_co { get; }
        public abstract string out_right_side_health_area { get; }
        public abstract string out_right_side_health_center_dist { get; }
        public abstract string out_right_side_puma_code { get; }
        public abstract string out_right_side_puma_2020 { get; }
        //public abstract string out_right_side_dot_street_light_contract_area { get; }
        public abstract string out_right_side_school_dist { get; }
        public abstract string out_right_side_iaei { get; }
        public abstract string out_right_side_blockface_id { get; }
        public abstract string out_right_side_nta { get; }
        public abstract string out_right_side_atomic_polygon { get; }
        public abstract string out_right_side_cd_eligibility { get; }

        public abstract string out_bike_lane { get; }
        public abstract string out_bike_traffic_direction { get; }
        public abstract string out_on_street_b7sc_name { get; }
        public abstract string out_from_latitude { get; }
        public abstract string out_from_longitude { get; }
        public abstract string out_to_latitude { get; }
        public abstract string out_to_longitude { get; }
        public abstract string out_curve_flag { get; }
        public abstract string out_curve_flag_direction { get; }
        public abstract string add_on_st_code_name { get; }
        public abstract string add_from_st_code_name { get; }
        public abstract string add_to_st_code_name { get; }
        public abstract string dcp_preferred_from_st_code_name { get; }
        public abstract string dcp_preferred_to_st_code_name { get; }
        public abstract string out_sos_ind { get; }

        public abstract string out_seg_side_comdist { get; }
        public abstract string out_seg_side_comdist_boro { get; }
        public abstract string out_seg_side_lhnd { get; }
        public abstract string out_seg_side_hhnd { get; }
        public abstract string out_seg_side_zip_code { get; }
        public abstract string out_seg_side_school_dist { get; }
        public abstract string out_seg_side_police_patrol_boro { get; }
        public abstract string out_seg_side_police_sector { get; }
        public abstract string out_seg_side_police_pct { get; }
        public abstract string out_seg_side_health_area { get; }
        public abstract string out_seg_side_health_center_dist { get; }
        public abstract string out_seg_side_puma_code { get; }
        public abstract string out_seg_side_puma_2020 { get; }
        public abstract string out_seg_side_nta { get; }
        public abstract string out_seg_side_boro { get; }
        public abstract string out_seg_side_census_tract_2020 { get; }
        public abstract string out_seg_side_census_block_2020 { get; }
        public abstract string out_seg_side_nta_2020 { get; }
        public abstract string out_seg_side_cdta_2020 { get; }
        public abstract string out_seg_side_census_tract_2010 { get; }
        public abstract string out_seg_side_census_block_2010 { get; }
        public abstract string out_seg_side_atomic_polygon { get; }
        public abstract string out_seg_side_census_tract_2000 { get; }
        public abstract string out_seg_side_census_block_2000 { get; }
        public abstract string out_seg_side_cd_eligibility { get; }
        public abstract string out_seg_side_fire_div { get; }
        public abstract string out_seg_side_fire_bat { get; }
        public abstract string out_seg_side_fire_co { get; }
        public abstract string out_seg_side_blockface_id { get; }
        #endregion
    }
}
