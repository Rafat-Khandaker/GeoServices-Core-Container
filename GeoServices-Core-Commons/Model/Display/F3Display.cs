using DCP.Geosupport.DotNet.fld_def_lib;
using GeoXWrapperLib;
using GeoXWrapperLib.Model;
using GeoXWrapperTest.Helper;
using GeoXWrapperTest.Model.Abstract;
using GeoXWrapperTest.Model.Contracts;


namespace GeoXWrapperTest.Model.Display
{
    public class F3Display : AbstractF3Display
    {
        private static readonly fld_dict _fld = new fld_dict();
        private readonly Wa2F3eas _wa2f3eas;
        private readonly Wa2F3e _wa2f3e;
        private readonly SegSideB7sc _left;
        private readonly SegSideB7sc _right;
        Geo GeoCaller;

        public F3Display(Wa1 wa1, Wa2F3eas wa2f3eas, Geo geoCaller)
        {
            _wa1 = wa1;
            _wa2f3eas = wa2f3eas;

            _wa2f3e = _wa2f3eas.wa2f3e;
            _left = _wa2f3eas.wa2f3e.left_side;
            _right = _wa2f3eas.wa2f3e.right_side;

            GeoCaller = geoCaller;
        }

        public override List<string> AuxiliarySegmentIDList => _wa2f3eas.auxseg_id_list.Where(auxSegId => !string.IsNullOrWhiteSpace(auxSegId)).ToList();

        public override string out_from_node => _wa2f3e.from_node;
        public override string out_to_node => _wa2f3e.to_node;
        public override string out_lionkey => _wa2f3e.lionkey.LionKeyToString();
        public override string out_from_x_coord => _wa2f3e.from_x_coord.TrimStart('0');
        public override string out_from_y_coord => _wa2f3e.from_y_coord.TrimStart('0');
        public override string out_to_x_coord => _wa2f3e.to_x_coord.TrimStart('0');
        public override string out_to_y_coord => _wa2f3e.to_y_coord.TrimStart('0');
        public override string out_dot_street_light_contract_area => _wa2f3e.dot_street_light_contract_area;
        public override string out_segment_id => _wa2f3e.segment_id;
        public override string out_segment_len => _wa2f3e.segment_len.TrimStart('0');
        public override string out_physical_id => _wa2f3e.physical_id;
        public override string out_generic_id => _wa2f3e.generic_id;
        public override string out_loc_status => _wa2f3e.loc_status;
        public override string out_traffic_direction => _fld.get_get_short_def("traffic_direction", _wa2f3e.traffic_direction);
        public override string out_segment_type => _fld.get_get_short_def("segment_type", _wa2f3e.segment_type);
        public override string out_feature_type => _fld.get_get_short_def("feature_type", _wa2f3e.feature_type);
        public override string out_roadway_type => _fld.get_get_short_def("roadway_type", _wa2f3e.roadway_type.Trim());
        public override string out_right_of_way_type => _wa2f3e.right_of_way_type;
        public override string out_No_Traveling_lanes => _wa2f3e.No_Traveling_lanes;
        public override string out_No_Parking_lanes => _wa2f3e.No_Parking_lanes;
        public override string out_Total_Lanes => _wa2f3e.Total_Lanes;
        public override string out_street_width_min => _wa2f3e.street_width;
        public override string out_street_width_max => _wa2f3e.st_width_max;
        public override string out_speed_limit => _wa2f3e.speed_limit;
        public override string out_street_width_irregular => _wa2f3e.street_width_irregular;
        public override string out_boro_name1 => _wa1.out_boro_name1;
        //public override string out_boro_name2 => throw new System.NotImplementedException(); //FIXME unimplemented in original api
        //public override string out_boro_name3 => throw new System.NotImplementedException(); //FIXME unimplemented in original api
        public override string out_truck_route_type => _wa2f3e.truck_route_type;
        public override string out_pgb_flag => _wa2f3e.pgb_flag;

        #region Left Side
        public override string out_left_side_boro => _left.boro;
        public override string out_left_side_comdist => _left.comdist.district_number;
        public override string out_left_side_comdist_boro => _left.comdist.boro;
        public override string out_left_side_lhnd => _left.lhnd;
        public override string out_left_side_hhnd => _left.hhnd;
        public override string out_left_side_zip_code => _left.zip_code;
        public override string out_left_side_census_tract_2020 => !string.IsNullOrWhiteSpace(_left.census_tract_2020.Substring(4, 2))
            ? $"{_left.census_tract_2020.Substring(0, 4)}.{_left.census_tract_2020.Substring(4, 2)}"
            : _left.census_tract_2020;
        public override string out_left_side_census_block_2020 => _left.census_block_2020;
        public override string out_left_side_census_block_suffix_2020 => _left.census_block_suffix_2020;
        public override string out_left_side_nta_2020 => _left.nta_2020;
        public override string out_left_side_cdta_2020 => _left.cdta_2020;
        public override string out_left_side_census_tract_2010 => !string.IsNullOrWhiteSpace(_left.census_tract_2010.Substring(4, 2))
            ? $"{_left.census_tract_2010.Substring(0, 4)}.{_left.census_tract_2010.Substring(4, 2)}"
            : _left.census_tract_2010;
        public override string out_left_side_census_block_2010 => _left.census_block_2010;
        public override string out_left_side_census_tract_2000 => !string.IsNullOrWhiteSpace(_left.census_tract_2000.Substring(4, 2))
            ? $"{_left.census_tract_2000.Substring(0, 4)} . {_left.census_tract_2000.Substring(4, 2)}"
            : _left.census_tract_2000;
        public override string out_left_side_census_block_2000 => _left.census_block_2000;
        public override string out_left_side_police_sector => _left.police_sector;
        public override string out_left_side_police_patrol_boro => _left.police_patrol_boro;
        public override string out_left_side_police_pct => _left.police_pct.TrimStart('0');
        public override string out_left_side_fire_div => _left.fire_div.TrimStart('0');
        public override string out_left_side_fire_bat => _left.fire_bat.TrimStart('0');
        public override string out_left_side_fire_co
        {
            get
            {
                switch (_left.fire_co_type)
                {
                    case "L":
                        return $"Ladder {_left.fire_co_num.TrimStart('0')}";
                    case "E":
                        return $"Engine {_left.fire_co_num.TrimStart('0')}";
                    default:
                        return $"{_left.fire_co_type} {_left.fire_co_num.TrimStart('0')}";
                }
            }
        }
        public override string out_left_side_health_area => $"{_left.health_area.Substring(0, 2)}.{_left.health_area.Substring(2, 2)}";
        public override string out_left_side_health_center_dist => _left.hcd;
        public override string out_left_side_puma_code => _left.puma_code;
        public override string out_left_side_puma_2020 => _wa2f3e.left_puma_2020;
        //public override string out_left_side_dot_street_light_contract_area => throw new System.NotImplementedException(); //FIXME unimplemented in original API
        public override string out_left_side_school_dist => _left.school_dist.TrimStart('0');
        public override string out_left_side_iaei => _left.iaei;
        public override string out_left_side_blockface_id => _left.blockface_id;
        public override string out_left_side_nta => $"{_left.nta}: {_left.nta_name}";
        public override string out_left_side_atomic_polygon => _left.dynamic_block;
        public override string out_left_side_cd_eligibility => _fld.get_get_short_def("cd_eligible", _left.iaei);
        #endregion

        public override string out_dsny_snow_priority => _fld.get_get_short_def("dsny_snow_priority", _wa2f3e.dsny_snow_priority);

        #region Right Side
        public override string out_right_side_boro => _right.boro;
        public override string out_right_side_comdist => _right.comdist.district_number;
        public override string out_right_side_comdist_boro => _right.comdist.boro;
        public override string out_right_side_lhnd => _right.lhnd;
        public override string out_right_side_hhnd => _right.hhnd;
        public override string out_right_side_zip_code => _right.zip_code;
        public override string out_right_side_census_tract_2020 => !string.IsNullOrWhiteSpace(_right.census_tract_2020.Substring(4, 2))
            ? $"{_right.census_tract_2020.Substring(0, 4)}.{_right.census_tract_2020.Substring(4, 2)}"
            : _right.census_tract_2020;
        public override string out_right_side_census_block_2020 => _right.census_block_2020;
        public override string out_right_side_census_block_suffix_2020 => _right.census_block_suffix_2020;
        public override string out_right_side_nta_2020 => _right.nta_2020;
        public override string out_right_side_cdta_2020 => _right.cdta_2020;
        public override string out_right_side_census_tract_2010 => !string.IsNullOrWhiteSpace(_right.census_tract_2010.Substring(4, 2))
            ? $"{_right.census_tract_2010.Substring(0, 4)}.{_right.census_tract_2010.Substring(4, 2)}"
            : _right.census_tract_2010;
        public override string out_right_side_census_block_2010 => _right.census_block_2010;
        public override string out_right_side_census_tract_2000 => !string.IsNullOrWhiteSpace(_right.census_tract_2000.Substring(4, 2))
            ? $"{_right.census_tract_2000.Substring(0, 4)} . {_right.census_tract_2000.Substring(4, 2)}"
            : _right.census_tract_2000;
        public override string out_right_side_census_block_2000 => _right.census_block_2000;
        public override string out_right_side_police_patrol_boro => _right.police_patrol_boro;
        public override string out_right_side_police_sector => _right.police_sector;
        public override string out_right_side_police_pct => _right.police_pct.TrimStart('0');
        public override string out_right_side_fire_div => _right.fire_div.TrimStart('0');
        public override string out_right_side_fire_bat => _right.fire_bat.TrimStart('0');
        public override string out_right_side_fire_co
        {
            get
            {
                switch (_right.fire_co_type)
                {
                    case "L":
                        return $"Ladder {_right.fire_co_num.TrimStart('0')}";
                    case "E":
                        return $"Engine {_right.fire_co_num.TrimStart('0')}";
                    default:
                        return $"{_right.fire_co_type} {_right.fire_co_num.TrimStart('0')}";
                }
            }
        }
        public override string out_right_side_health_area => $"{_right.health_area.Substring(0, 2)}.{_right.health_area.Substring(2, 2)}";
        public override string out_right_side_health_center_dist => _right.hcd;
        public override string out_right_side_puma_code => _right.puma_code;
        public override string out_right_side_puma_2020 => _wa2f3e.right_puma_2020;
        //public override string out_right_side_dot_street_light_contract_area => throw new System.NotImplementedException(); //FIXME unimplemented in original API
        public override string out_right_side_school_dist => _right.school_dist.TrimStart('0');
        public override string out_right_side_iaei => _right.iaei;
        public override string out_right_side_blockface_id => _right.blockface_id;
        public override string out_right_side_nta => $"{_right.nta}: {_right.nta_name}";
        public override string out_right_side_atomic_polygon => _right.dynamic_block;
        public override string out_right_side_cd_eligibility => _fld.get_get_short_def("cd_eligible", _right.iaei);
        #endregion

        public override string out_bike_lane => _wa2f3e.bike_lane;
        public override string out_bike_traffic_direction => _fld.get_get_short_def("bike_traffic_direction", _wa2f3e.bike_traffic_direction);
        public override string out_on_street_b7sc_name => $"{_wa1.out_b10sc1.boro.Trim().TrimStart('0')}{_wa1.out_b10sc1.sc5.Trim()}{_wa1.out_b10sc1.lgc} / {ValidationHelper.ValidateStName(_wa1.out_stname1)}";
        public override string out_from_latitude => _wa2f3e.from_latitude;
        public override string out_from_longitude => _wa2f3e.from_longitude;
        public override string out_to_latitude => _wa2f3e.to_latitude;
        public override string out_to_longitude => _wa2f3e.to_longitude;
        public override string out_curve_flag => !string.IsNullOrWhiteSpace(_wa2f3e.curve_flag)
        ? _fld.get_get_short_def("curve_flag", _wa2f3e.curve_flag)
            : "None";
        public override string out_curve_flag_direction => string.Equals(_wa2f3e.curve_flag, "L", StringComparison.OrdinalIgnoreCase) ? "L" : "R";
        public override string add_on_st_code_name
        {
            get
            {
                string lastLgcs = _wa2f3e.on_street_valid_lgcs.LastOrDefault(l => !string.IsNullOrWhiteSpace(l)) ?? string.Empty;
                string boro = _wa1.out_b10sc1.boro.Trim().TrimStart('0');
                string sc5 = _wa1.out_b10sc1.sc5.Trim();

                return $"{boro}{sc5}{lastLgcs} / {ValidationHelper.ReadStNameFdg(_wa1.out_b10sc1, lastLgcs, GeoCaller)}";
            }
        }
        public override string add_from_st_code_name
        {
            get
            {
                string lastLgcs = _wa2f3e.on_street_valid_lgcs.LastOrDefault(l => !string.IsNullOrWhiteSpace(l)) ?? string.Empty;
                string boro = _wa1.in_b10sc2.boro.Trim().TrimStart('0');
                string sc5 = _wa1.in_b10sc2.sc5.Trim();

                return $"{boro}{sc5}{lastLgcs} / {ValidationHelper.ReadStNameFdg(_wa1.in_b10sc2, lastLgcs, GeoCaller)}";
            }
        }
        public override string add_to_st_code_name
        {
            get
            {
                string lastLgcs = _wa2f3e.on_street_valid_lgcs.LastOrDefault(l => !string.IsNullOrWhiteSpace(l)) ?? string.Empty;
                string boro = _wa1.in_b10sc3.boro.Trim().TrimStart('0');
                string sc5 = _wa1.in_b10sc3.sc5.Trim();

                return $"{boro}{sc5}{lastLgcs} / {ValidationHelper.ReadStNameFdg(_wa1.in_b10sc3, lastLgcs, GeoCaller)}";
            }
        }
        public override string dcp_preferred_from_st_code_name
        {
            get
            {
                B10sc b10sc3 = _wa1.out_b10sc3;
                B10sc b10sc2 = _wa1.out_b10sc2;
                string lgc3 = _wa2f3e.dcp_pref_lgc3;
                string lgc2 = _wa2f3e.dcp_pref_lgc2;

                string boro3 = b10sc3.boro.Trim().TrimStart('0');
                string boro2 = b10sc2.boro.Trim().TrimStart('0');
                string sc5_3 = b10sc3.sc5.Trim();
                string sc5_2 = b10sc2.sc5.Trim();

                return string.Equals(_wa2f3e.x_street_reversal_flag, "R", StringComparison.OrdinalIgnoreCase)
                    ? $"{boro3}{sc5_3}{lgc3} / {ValidationHelper.ReadStNameFdg(b10sc3, lgc3, GeoCaller).Trim()}"
                    : $"{boro2}{sc5_2}{lgc2} / {ValidationHelper.ReadStNameFdg(b10sc2, lgc2, GeoCaller).Trim()}";
            }
        }
        public override string dcp_preferred_to_st_code_name
        {
            get
            {
                B10sc b10sc3 = _wa1.out_b10sc3;
                B10sc b10sc2 = _wa1.out_b10sc2;
                string lgc3 = _wa2f3e.dcp_pref_lgc3;
                string lgc2 = _wa2f3e.dcp_pref_lgc2;

                string boro3 = b10sc3.boro.Trim().TrimStart('0');
                string boro2 = b10sc2.boro.Trim().TrimStart('0');
                string sc5_3 = b10sc3.sc5.Trim();
                string sc5_2 = b10sc2.sc5.Trim();

                return string.Equals(_wa2f3e.x_street_reversal_flag, "R", StringComparison.OrdinalIgnoreCase)
                    ? $"{boro2}{sc5_2}{lgc2} / {ValidationHelper.ReadStNameFdg(b10sc2, lgc2, GeoCaller).Trim()}"
                    : $"{boro3}{sc5_3}{lgc3} / {ValidationHelper.ReadStNameFdg(b10sc3, lgc3, GeoCaller).Trim()}";
            }
        }
        public override string out_sos_ind => string.Empty; //F3C only

        #region Segment Side - Always null for F3
        public override string out_seg_side_comdist => null;
        public override string out_seg_side_comdist_boro => null;
        public override string out_seg_side_lhnd => null;
        public override string out_seg_side_hhnd => null;
        public override string out_seg_side_zip_code => null;
        public override string out_seg_side_school_dist => null;
        public override string out_seg_side_police_patrol_boro => null;
        public override string out_seg_side_police_sector => null;
        public override string out_seg_side_police_pct => null;
        public override string out_seg_side_health_area => null;
        public override string out_seg_side_health_center_dist => null;
        public override string out_seg_side_puma_code => null;
        public override string out_seg_side_puma_2020 => null;
        public override string out_seg_side_nta => null;
        public override string out_seg_side_boro => null;
        public override string out_seg_side_census_tract_2020 => null;
        public override string out_seg_side_census_block_2020 => null;
        public override string out_seg_side_nta_2020 => null;
        public override string out_seg_side_cdta_2020 => null;
        public override string out_seg_side_census_tract_2010 => null;
        public override string out_seg_side_census_block_2010 => null;
        public override string out_seg_side_atomic_polygon => null;
        public override string out_seg_side_census_tract_2000 => null;
        public override string out_seg_side_census_block_2000 => null;
        public override string out_seg_side_cd_eligibility => null;
        public override string out_seg_side_fire_div => null;
        public override string out_seg_side_fire_bat => null;
        public override string out_seg_side_fire_co => null;
        public override string out_seg_side_blockface_id => null;
        #endregion
    }
}
