using DCP.Geosupport.DotNet.fld_def_lib;
using GeoXWrapperLib;
using GeoXWrapperLib.Model;
using GeoXWrapperTest.Helper;


namespace GeoXWrapperTest.Model.Display
{
    public class F1eDisplay
    {
        private static readonly fld_dict _fld = new fld_dict();
        private readonly Wa1 _wa1;
        private readonly Wa2F1ex _wa2f1ex;
        Geo GeoCaller;


        public F1eDisplay(Wa1 wa1, Wa2F1ex wa2f1ex, Geo geoCaller)
        {
            _wa1 = wa1;
            _wa2f1ex = wa2f1ex;
            GeoCaller = geoCaller;

        }

        #region Data Lists
        public List<LowHighB7SC> LowB7SCList => ValidationHelper.CreateB7ScList(_wa2f1ex.lo_x_b7sc_list, _wa2f1ex.lo_x_stname_list);
        public List<LowHighB7SC> HighB7SCList => ValidationHelper.CreateB7ScList(_wa2f1ex.hi_x_b7sc_list, _wa2f1ex.hi_x_stname_list);
        public List<SimilarName> SimilarNamesList => ValidationHelper.CreateSimilarNamesList(_wa1.out_b7sc_list, _wa1.out_stname_list);
        #endregion

        #region Orientation Left Column
        public string in_func_code => _wa1.in_func_code;
        public string in_boro => _wa1.in_boro1;
        public string in_hnd => _wa1.in_hnd;
        public string in_stname1 => _wa1.in_stname1;
        public string in_unit => _wa1.in_unit;
        public string in_zip_code => _wa1.in_zip_code;
        public string in_hns => _wa1.in_hns;
        public string in_browse_flag => _wa1.in_browse_flag;
        public string in_roadbed_request_switch => _wa1.in_tpad_switch;

        public string out_stname1 => _wa1.out_stname1;
        public string out_hnd => _wa1.out_hnd;
        public string out_hns => _wa1.out_hns;
        public string out_boro_name1 => _wa1.out_boro_name1;
        public string out_unit => _wa1.out_unit;

        public string out_grc => _wa1.out_grc;
        public string out_reason_code => _wa1.out_reason_code;
        public string out_error_message => _wa1.out_error_message;
        public string out_wa1_message => _wa1.out_error_message;

        public string out_x_coord => _wa2f1ex.x_coord.TrimStart('0');
        public string out_y_coord => _wa2f1ex.y_coord.TrimStart('0');
        public string out_latitude => _wa2f1ex.latitude;
        public string out_longitude => _wa2f1ex.longitude;
        public string out_com_dist => $"{_wa2f1ex.com_dist.boro}{_wa2f1ex.com_dist.district_number}";
        public string out_lion_key_face_code => _wa2f1ex.lion_key.face_code;
        public string out_lion_key_sequence_number => _wa2f1ex.lion_key.sequence_number;
        public string out_b10sc1 => _wa1.out_b10sc1.B10scToString();

        public string out_alx => string.IsNullOrWhiteSpace(_wa2f1ex.alx)
            ? "No Split/Change"
            : _fld.get_get_short_def("alx", _wa2f1ex.alx);

        public string out_traffic_dir => _wa2f1ex.traffic_dir;
        public string out_speed_limit => _wa2f1ex.speed_limit;
        public string out_coincident_seg_cnt => _wa2f1ex.coincident_seg_cnt;
        public string out_segment_type => _fld.get_get_short_def("segment_type", _wa2f1ex.segment_type.Trim());

        public string out_census_tract_2010 => string.IsNullOrWhiteSpace(_wa2f1ex.census_tract_2010.Substring(4, 2))
            ? _wa2f1ex.census_tract_2010
            : $"{_wa2f1ex.census_tract_2010.Substring(0, 4)}.{_wa2f1ex.census_tract_2010.Substring(4, 2)}";

        public string out_census_block_2010 => _wa2f1ex.census_block_2010;
        public string out_No_Traveling_lane => _wa2f1ex.No_Traveling_lanes;
        public string out_No_Parking_lanes => _wa2f1ex.No_Parking_lanes;
        public string out_No_Total_Lanes => _wa2f1ex.No_Total_Lanes;
        public string out_atomic_polygon => _wa2f1ex.dynamic_block;

        public string out_census_tract_2000 => string.IsNullOrWhiteSpace(_wa2f1ex.census_tract_2000.Substring(4, 2))
            ? _wa2f1ex.census_tract_2000
            : $"{_wa2f1ex.census_tract_2000.Substring(0, 4)}.{_wa2f1ex.census_tract_2000.Substring(4, 2)}";

        public string out_census_block_2000 => _wa2f1ex.census_block_2000;
        public string out_cd_eligible => _fld.get_get_short_def("cd_eligible", _wa2f1ex.res_gss);
        public string out_curve_flag => _fld.get_get_short_def("curve_flag", _wa2f1ex.curve_flag);
        public string out_zip_code => _wa2f1ex.zip_code;
        public string out_usps_city_name => _wa2f1ex.USPS_city_name;
        public string out_preferred_lgc => $"{_wa1.out_b10sc1.boro}{_wa1.out_b10sc1.sc5}{_wa2f1ex.dcp_pref_lgc}";
        public string out_preferred_street_name => ValidationHelper.ReadStNameFdg(_wa1.out_b10sc1.boro, _wa1.out_b10sc1.sc5, _wa2f1ex.dcp_pref_lgc, GeoCaller);
        public string out_lo_hns => ValidationHelper.ValidateHouseNum(_wa2f1ex.lo_hns, GeoCaller);

        public string out_sos_ind => _wa2f1ex.lo_x_b7sc_list.Length > 0 && _wa2f1ex.hi_x_b7sc_list.Length > 0
            ? $"Address is on the {ValidationHelper.ReadOrientation(_wa2f1ex.sos_ind)} when facing from {_wa2f1ex.lo_x_stname_list[0].Trim()} to {_wa2f1ex.hi_x_stname_list[0].Trim()}"
            : string.Empty;

        public string cont_parity_ind => _wa2f1ex.cont_parity_ind;
        #endregion

        #region Orientation Right Column
        public string out_from_node => _wa2f1ex.from_node;
        public string out_lo_x_coord => _wa2f1ex.lo_x_coord.TrimStart('0');
        public string out_lo_y_coord => _wa2f1ex.lo_y_coord;
        public string out_to_node => _wa2f1ex.to_node;
        public string out_hi_x_coord => _wa2f1ex.hi_x_coord.TrimStart('0');
        public string out_hi_y_coord => _wa2f1ex.hi_y_coord;
        public string out_segment_id => _wa2f1ex.segment_id;
        public string out_segment_len => _wa2f1ex.segment_len.TrimStart('0');
        public string out_feature_type => _fld.get_get_short_def("feature_type", _wa2f1ex.feature_type);
        public string out_roadway_type => _fld.get_get_short_def("roadway_type", _wa2f1ex.roadway_type.Trim());
        public string out_right_of_way_type => _wa2f1ex.right_of_way_type;
        public string out_bike_lane => _wa2f1ex.bike_lane2;
        public string out_bike_traffic_direction => _fld.get_get_short_def("bike_traffic_direction", _wa2f1ex.bike_traffic_direction);
        public string out_street_width_min => _wa2f1ex.street_width;
        public string out_street_width_max => _wa2f1ex.st_width_max;
        public string out_physical_id => _wa2f1ex.physical_id;
        public string out_generic_id => _wa2f1ex.generic_id;
        public string out_blockface_id => _wa2f1ex.blockface_id;
        public string out_spec_addr_flag => _fld.get_get_short_def("spec_addr_flag", _wa2f1ex.spec_addr_flag);
        public string out_hi_hns => ValidationHelper.ValidateHouseNum(_wa2f1ex.hi_hns, GeoCaller);
        #endregion

        #region Census_2020 Fields
        public string out_census_tract_2020 => string.IsNullOrWhiteSpace(_wa2f1ex.census_tract_2020.Substring(4, 2))
            ? _wa2f1ex.census_tract_2020
            : $"{_wa2f1ex.census_tract_2020.Substring(0, 4)}.{_wa2f1ex.census_tract_2020.Substring(4, 2)}";

        public string out_census_block_2020 => _wa2f1ex.census_block_2020;
        public string out_nta_2020 => _wa2f1ex.nta_2020;
        public string out_cdta_2020 => _wa2f1ex.cdta_2020;
        #endregion 

        #region City Service
        public string out_police_sector => _wa2f1ex.police_sector;
        public string out_police_area => _wa2f1ex.police_area;
        public string out_police_patrol_boro => _fld.get_get_long_def("police_patrol_boro", _wa2f1ex.police_patrol_boro);
        public string out_police_pct => _wa2f1ex.police_pct.TrimStart('0');
        public string out_fire_div => _wa2f1ex.fire_div.TrimStart('0');
        public string out_fire_bat => _wa2f1ex.fire_bat.TrimStart('0');
        public string out_fire_co => $"{_fld.get_get_short_def("fire_co_type", _wa2f1ex.fire_co_type)} {_wa2f1ex.fire_co_num.TrimStart('0')}";
        public string out_fire_co_str => _fld.get_get_short_def("fire_co_type", _wa2f1ex.fire_co_type);
        public string out_health_area => $"{_wa2f1ex.health_area.Substring(0, 2)}.{_wa2f1ex.health_area.Substring(2, 2)}";
        public string out_health_center_dist => _wa2f1ex.health_center_dist;
        public string out_dot_st_light_contract_area => _wa2f1ex.dot_st_light_contract_area;
        public string out_school_dist => _wa2f1ex.school_dist.TrimStart('0');
        public string out_nta => $"{_wa2f1ex.nta} / {_wa2f1ex.nta_name}";
        public string out_san_dist_section => $"{_wa2f1ex.san_dist} / {_wa2f1ex.san_dist.Remove(0, 1)}{_wa2f1ex.san_sched.Remove(1)}";
        public string out_san_sched => _wa2f1ex.san_sched;
        public string out_san_reg => _wa2f1ex.san_reg;
        public string out_san_recycle => _wa2f1ex.san_recycle;
        public string out_san_org_pick_up => _wa2f1ex.san_org_pick_up;
        public string out_san_bulk => _wa2f1ex.san_bulk;
        public string out_dsny_snow_priority => _fld.get_get_short_def("dsny_snow_priority", _wa2f1ex.dsny_snow_priority);
        public string out_hurricane_zone => _wa2f1ex.hurricane_zone;
        public string out_san_commercial_waste_zone => _wa2f1ex.san_commercial_waste_zone;
        public string out_puma_code => _wa2f1ex.puma_code;
        public string out_puma_2020 => _wa2f1ex.puma_2020;
        public string out_truck_route_type => _wa2f1ex.truck_route_type;
        #endregion

        #region Political Information
        public string out_co => _wa2f1ex.co.TrimStart('0');
        public string out_ad => _wa2f1ex.ad;
        public string out_cd => _wa2f1ex.cd;
        public string out_boe_preferred_b7sc => $"{_wa2f1ex.boe_preferred_b7sc.ToString()} / {_wa2f1ex.boe_preferred_stname}";
        public string out_mc => _wa2f1ex.mc.TrimStart('0');
        public string out_ed => _wa2f1ex.ed;
        public string out_sd => _wa2f1ex.sd;
        #endregion
    }


}

