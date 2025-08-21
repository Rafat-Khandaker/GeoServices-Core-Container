using DCP.Geosupport.DotNet.fld_def_lib;
using GeoXWrapperLib;
using GeoXWrapperLib.Model;
using GeoXWrapperTest.Helper;
using GeoXWrapperTest.Model.Abstract;
using GeoXWrapperTest.Model.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperTest.Model.Display
{
    public class F3cDisplay : AbstractF3Display
    {
        private static readonly fld_dict _fld = new fld_dict();
        private readonly Wa2F3ceas _wa2f3ceas;
        private readonly Wa2F3ce _wa2f3ce;
        private readonly SegSideB7sc _segment;
        Geo GeoCaller;

        public F3cDisplay(Wa1 wa1, Wa2F3ceas wa2f3ceas, Geo geoCaller)
        {
            _wa1 = wa1;
            _wa2f3ceas = wa2f3ceas;

            _wa2f3ce = _wa2f3ceas.wa2f3ce;
            _segment = _wa2f3ceas.wa2f3ce.seg_side;

            GeoCaller = geoCaller;
        }

        public override List<string> AuxiliarySegmentIDList => _wa2f3ceas.auxseg_id_list.Where(auxSegId => !string.IsNullOrWhiteSpace(auxSegId)).ToList();

        public override string out_from_node => _wa2f3ce.from_node;
        public override string out_to_node => _wa2f3ce.to_node;
        public override string out_lionkey => _wa2f3ce.lionkey.LionKeyToString();
        public override string out_from_x_coord => _wa2f3ce.from_x_coord.TrimStart('0');
        public override string out_from_y_coord => _wa2f3ce.from_y_coord.TrimStart('0');
        public override string out_to_x_coord => _wa2f3ce.to_x_coord.TrimStart('0');
        public override string out_to_y_coord => _wa2f3ce.to_y_coord.TrimStart('0');
        public override string out_dot_street_light_contract_area => _wa2f3ce.dot_street_light_contract_area;
        public override string out_segment_id => _wa2f3ce.segment_id;
        public override string out_segment_len => _wa2f3ce.segment_len.TrimStart('0');
        public override string out_physical_id => _wa2f3ce.physical_id;
        public override string out_generic_id => _wa2f3ce.generic_id;
        public override string out_loc_status => _wa2f3ce.loc_status;
        public override string out_traffic_direction => _fld.get_get_short_def("traffic_direction", _wa2f3ce.traffic_direction);
        public override string out_segment_type => _fld.get_get_short_def("segment_type", _wa2f3ce.segment_type);
        public override string out_feature_type => _fld.get_get_short_def("feature_type", _wa2f3ce.feature_type);
        public override string out_roadway_type => _fld.get_get_short_def("roadway_type", _wa2f3ce.roadway_type.Trim());
        public override string out_right_of_way_type => _wa2f3ce.right_of_way_type;
        public override string out_No_Traveling_lanes => _wa2f3ce.No_Traveling_lanes;
        public override string out_No_Parking_lanes => _wa2f3ce.No_Parking_lanes;
        public override string out_Total_Lanes => _wa2f3ce.Total_Lanes;
        public override string out_street_width_min => _wa2f3ce.street_width;
        public override string out_street_width_max => _wa2f3ce.st_width_max;
        public override string out_speed_limit => _wa2f3ce.speed_limit;
        public override string out_street_width_irregular => _wa2f3ce.street_width_irregular;
        public override string out_boro_name1 => _wa1.out_boro_name1;
        //public override string out_boro_name2 => throw new System.NotImplementedException(); //FIXME unimplemented in original api
        //public override string out_boro_name3 => throw new System.NotImplementedException(); //FIXME unimplemented in original api
        public override string out_truck_route_type => _wa2f3ce.truck_route_type;
        public override string out_pgb_flag => _wa2f3ce.pgb_flag;

        #region Left Side - Always null for F3C
        public override string out_left_side_boro => null;
        public override string out_left_side_comdist => null;
        public override string out_left_side_comdist_boro => null;
        public override string out_left_side_lhnd => null;
        public override string out_left_side_hhnd => null;
        public override string out_left_side_zip_code => null;
        public override string out_left_side_census_tract_2020 => null;
        public override string out_left_side_census_block_2020 => null;
        public override string out_left_side_census_block_suffix_2020 => null;
        public override string out_left_side_nta_2020 => null;
        public override string out_left_side_cdta_2020 => null;
        public override string out_left_side_census_tract_2010 => null;
        public override string out_left_side_census_block_2010 => null;
        public override string out_left_side_census_tract_2000 => null;
        public override string out_left_side_census_block_2000 => null;
        public override string out_left_side_police_sector => null;
        public override string out_left_side_police_patrol_boro => null;
        public override string out_left_side_police_pct => null;
        public override string out_left_side_fire_div => null;
        public override string out_left_side_fire_bat => null;
        public override string out_left_side_fire_co => null;
        public override string out_left_side_health_area => null;
        public override string out_left_side_health_center_dist => null;
        public override string out_left_side_puma_code => null;
        public override string out_left_side_puma_2020 => null;
        //public override string out_left_side_dot_street_light_contract_area => throw new System.NotImplementedException(); //FIXME unimplemented in original API
        public override string out_left_side_school_dist => null;
        public override string out_left_side_iaei => null;
        public override string out_left_side_blockface_id => null;
        public override string out_left_side_nta => null;
        public override string out_left_side_atomic_polygon => null;
        public override string out_left_side_cd_eligibility => null;
        #endregion

        public override string out_dsny_snow_priority => _fld.get_get_short_def("dsny_snow_priority", _wa2f3ce.dsny_snow_priority);

        #region Right Side - Always null for F3C
        public override string out_right_side_boro => null;
        public override string out_right_side_comdist => null;
        public override string out_right_side_comdist_boro => null;
        public override string out_right_side_lhnd => null;
        public override string out_right_side_hhnd => null;
        public override string out_right_side_zip_code => null;
        public override string out_right_side_census_tract_2020 => null;
        public override string out_right_side_census_block_2020 => null;
        public override string out_right_side_census_block_suffix_2020 => null;
        public override string out_right_side_nta_2020 => null;
        public override string out_right_side_cdta_2020 => null;
        public override string out_right_side_census_tract_2010 => null;
        public override string out_right_side_census_block_2010 => null;
        public override string out_right_side_census_tract_2000 => null;
        public override string out_right_side_census_block_2000 => null;
        public override string out_right_side_police_patrol_boro => null;
        public override string out_right_side_police_sector => null;
        public override string out_right_side_police_pct => null;
        public override string out_right_side_fire_div => null;
        public override string out_right_side_fire_bat => null;
        public override string out_right_side_fire_co => null;
        public override string out_right_side_health_area => null;
        public override string out_right_side_health_center_dist => null;
        public override string out_right_side_puma_code => null;
        public override string out_right_side_puma_2020 => null;
        //public override string out_right_side_dot_street_light_contract_area => throw new System.NotImplementedException(); //FIXME unimplemented in original API
        public override string out_right_side_school_dist => null;
        public override string out_right_side_iaei => null;
        public override string out_right_side_blockface_id => null;
        public override string out_right_side_nta => null;
        public override string out_right_side_atomic_polygon => null;
        public override string out_right_side_cd_eligibility => null;
        #endregion

        public override string out_bike_lane => _wa2f3ce.bike_lane;
        public override string out_bike_traffic_direction => _fld.get_get_short_def("bike_traffic_direction", _wa2f3ce.bike_traffic_direction);
        public override string out_on_street_b7sc_name => $"{_wa1.out_b10sc1.boro.Trim().TrimStart('0')}{_wa1.out_b10sc1.sc5.Trim()}{_wa1.out_b10sc1.lgc} / {ValidationHelper.ValidateStName(_wa1.out_stname1)}";
        public override string out_from_latitude => _wa2f3ce.from_latitude;
        public override string out_from_longitude => _wa2f3ce.from_longitude;
        public override string out_to_latitude => _wa2f3ce.to_latitude;
        public override string out_to_longitude => _wa2f3ce.to_longitude;
        public override string out_curve_flag => !string.IsNullOrWhiteSpace(_wa2f3ce.curve_flag)
        ? _fld.get_get_short_def("curve_flag", _wa2f3ce.curve_flag)
            : "None";
        public override string out_curve_flag_direction => string.Equals(_wa2f3ce.curve_flag, "L", StringComparison.OrdinalIgnoreCase) ? "L" : "R";
        public override string add_on_st_code_name
        {
            get
            {
                string lastLgcs = _wa2f3ce.on_street_valid_lgcs.LastOrDefault(l => !string.IsNullOrWhiteSpace(l)) ?? string.Empty;
                string boro = _wa1.out_b10sc1.boro.Trim().TrimStart('0');
                string sc5 = _wa1.out_b10sc1.sc5.Trim();

                return $"{boro}{sc5}{lastLgcs} / {ValidationHelper.ReadStNameFdg(_wa1.out_b10sc1, lastLgcs, GeoCaller)}";
            }
        }
        public override string add_from_st_code_name
        {
            get
            {
                string lastLgcs = _wa2f3ce.on_street_valid_lgcs.LastOrDefault(l => !string.IsNullOrWhiteSpace(l)) ?? string.Empty;
                string boro = _wa1.in_b10sc2.boro.Trim().TrimStart('0');
                string sc5 = _wa1.in_b10sc2.sc5.Trim();

                return $"{boro}{sc5}{lastLgcs} / {ValidationHelper.ReadStNameFdg(_wa1.in_b10sc2, lastLgcs, GeoCaller)}";
            }
        }
        public override string add_to_st_code_name
        {
            get
            {
                string lastLgcs = _wa2f3ce.on_street_valid_lgcs.LastOrDefault(l => !string.IsNullOrWhiteSpace(l)) ?? string.Empty;
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
                string lgc3 = _wa2f3ce.dcp_pref_lgc3;
                string lgc2 = _wa2f3ce.dcp_pref_lgc2;

                string boro3 = b10sc3.boro.Trim().TrimStart('0');
                string boro2 = b10sc2.boro.Trim().TrimStart('0');
                string sc5_3 = b10sc3.sc5.Trim();
                string sc5_2 = b10sc2.sc5.Trim();

                return string.Equals(_wa2f3ce.x_street_reversal_flag, "R", StringComparison.OrdinalIgnoreCase)
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
                string lgc3 = _wa2f3ce.dcp_pref_lgc3;
                string lgc2 = _wa2f3ce.dcp_pref_lgc2;

                string boro3 = b10sc3.boro.Trim().TrimStart('0');
                string boro2 = b10sc2.boro.Trim().TrimStart('0');
                string sc5_3 = b10sc3.sc5.Trim();
                string sc5_2 = b10sc2.sc5.Trim();

                return string.Equals(_wa2f3ce.x_street_reversal_flag, "R", StringComparison.OrdinalIgnoreCase)
                    ? $"{boro2}{sc5_2}{lgc2} / {ValidationHelper.ReadStNameFdg(b10sc2, lgc2, GeoCaller).Trim()}"
                    : $"{boro3}{sc5_3}{lgc3} / {ValidationHelper.ReadStNameFdg(b10sc3, lgc3, GeoCaller).Trim()}";
            }
        }
        public override string out_sos_ind => _wa2f3ce.sos_ind;

        #region Segment Side
        public override string out_seg_side_comdist => _segment.comdist.district_number;
        public override string out_seg_side_comdist_boro => _segment.comdist.boro;
        public override string out_seg_side_lhnd => _segment.lhnd;
        public override string out_seg_side_hhnd => _segment.hhnd;
        public override string out_seg_side_zip_code => _segment.zip_code;
        public override string out_seg_side_school_dist => _segment.school_dist.TrimStart('0');
        public override string out_seg_side_police_patrol_boro => _segment.police_patrol_boro;
        public override string out_seg_side_police_sector => _segment.police_sector;
        public override string out_seg_side_police_pct => _segment.police_pct.TrimStart('0');
        public override string out_seg_side_health_area => $"{_segment.health_area.Substring(0, 2)}.{_segment.health_area.Substring(2, 2)}";
        public override string out_seg_side_health_center_dist => _segment.hcd;
        public override string out_seg_side_puma_code => _segment.puma_code;
        public override string out_seg_side_puma_2020 => _wa2f3ce.puma_2020;
        public override string out_seg_side_nta => $"{_segment.nta}: {_segment.nta_name}";
        public override string out_seg_side_boro => _segment.boro;
        public override string out_seg_side_census_tract_2020 => !string.IsNullOrWhiteSpace(_segment.census_tract_2020.Substring(4, 2))
            ? $"{_segment.census_tract_2020.Substring(0, 4)}.{_segment.census_tract_2020.Substring(4, 2)}"
            : _segment.census_tract_2020;
        public override string out_seg_side_census_block_2020 => _segment.census_block_2020;
        public override string out_seg_side_nta_2020 => _segment.nta_2020;
        public override string out_seg_side_cdta_2020 => _segment.cdta_2020;
        public override string out_seg_side_census_tract_2010 => !string.IsNullOrWhiteSpace(_segment.census_tract_2010.Substring(4, 2))
            ? $"{_segment.census_tract_2010.Substring(0, 4)}.{_segment.census_tract_2010.Substring(4, 2)}"
            : _segment.census_tract_2010;
        public override string out_seg_side_census_block_2010 => _segment.census_block_2010;
        public override string out_seg_side_atomic_polygon => _segment.dynamic_block;
        public override string out_seg_side_census_tract_2000 => !string.IsNullOrWhiteSpace(_segment.census_tract_2000.Substring(4, 2))
            ? $"{_segment.census_tract_2000.Substring(0, 4)}.{_segment.census_tract_2000.Substring(4, 2)}"
            : _segment.census_tract_2000;
        public override string out_seg_side_census_block_2000 => _segment.census_block_2000;
        public override string out_seg_side_cd_eligibility => _fld.get_get_short_def("cd_eligible", _segment.iaei);
        public override string out_seg_side_fire_div => _segment.fire_div.TrimStart('0');
        public override string out_seg_side_fire_bat => _segment.fire_bat.TrimStart('0');
        public override string out_seg_side_fire_co
        {
            get
            {
                switch (_segment.fire_co_type.ToUpper())
                {
                    case "L":
                        return $"Ladder {_segment.fire_co_num.TrimStart('0')}";
                    case "E":
                        return $"Engine {_segment.fire_co_num.TrimStart('0')}";
                    default:
                        return $"{_segment.fire_co_type} {_segment.fire_co_num.TrimStart('0')}";
                }
            }
        }
        public override string out_seg_side_blockface_id => _segment.blockface_id;
        #endregion
    }
}
