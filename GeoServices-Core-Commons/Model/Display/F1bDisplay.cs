using DCP.Geosupport.DotNet.fld_def_lib;
using GeoXWrapperLib;
using GeoXWrapperLib.Model;
using GeoXWrapperTest.Helper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperTest.Model.Display
{
    public class F1bDisplay 
    {
        private static readonly fld_dict _fld = new fld_dict();
        private readonly Wa1 _wa1;
        private readonly Wa2F1b _wa2f1b;

        //pointers to wa2f1b's sub-work areas for conveinence
        private Wa2F1ax _f1ax => _wa2f1b.wa2f1ax;
        private Wa2F1ex _f1ex => _wa2f1b.wa2f1ex;
        Geo GeoCaller;

    
        public F1bDisplay(Wa1 wa1, Wa2F1b wa2f1b, Geo geoCaller)
        {
            _wa1 = wa1;
            _wa2f1b = wa2f1b;
            GeoCaller = geoCaller;

        }

        #region Data Lists - Must Set in Function Controller
        public Dictionary<string,string> AddressRangeKeys => ValidationHelper.CreateAddressRangeKeys(_f1ax.addr_x_list);
        public List<LowHighB7SC> LowB7SCList => ValidationHelper.CreateB7ScList(_f1ex.lo_x_b7sc_list, _f1ex.lo_x_stname_list);
        public List<LowHighB7SC> HighB7SCList => ValidationHelper.CreateB7ScList(_f1ex.hi_x_b7sc_list, _f1ex.hi_x_stname_list);
        public List<SimilarName> SimilarNamesList => ValidationHelper.CreateSimilarNamesList(_wa1.out_b7sc_list, _wa1.out_stname_list);

        public List<AddressRange> AddressRangeList { get;  set; }
        public List<CompleteBIN> CompleteBINList { get;  set; }
        #endregion

        public string in_func_code => _wa1.in_func_code;
        public string in_boro => _wa1.in_boro1;
        public string in_hnd => _wa1.in_hnd;
        public string in_stname1 => _wa1.in_stname1;
        public string in_unit => _wa1.in_unit;
        public string in_zip_code => _wa1.in_zip_code;
        public string in_hns => _wa1.in_hns;
        public string in_browse_flag => _wa1.in_browse_flag;
        public string in_tpad_switch => _wa1.in_tpad_switch;
        public string in_roadbed_request_switch => _wa1.in_roadbed_request_switch;

        public string out_stname1 => _wa1.out_stname1;
        public string out_hnd => _wa1.out_hnd;
        public string out_hns => _wa1.out_hns;
        public string out_boro_name1 => _wa1.out_boro_name1;
        public string out_reason_code => _wa1.out_reason_code;
        public string out_reason_code2 => _wa1.out_reason_code2;

        public string out_unit => _wa1.out_unit;
        public string out_wa1_message => _wa1.out_error_message;
        public string out_grc => _wa1.out_grc;
        public string out_grc2 => _wa1.out_grc2;
        public string out_error_message => _wa1.out_error_message;
        public string out_error_message2 => _wa1.out_error_message2;
        public string out_x_coord => _f1ex.x_coord;
        public string out_y_coord => _f1ex.y_coord;
        public string out_from_node => _f1ex.from_node;
        public string out_to_node => _f1ex.to_node;
        public string out_latitude => _f1ex.latitude;
        public string out_longitude => _f1ex.longitude;
        public string out_lo_x_coord => _f1ex.lo_x_coord.TrimStart('0');
        public string out_lo_y_coord => _f1ex.lo_y_coord.TrimStart('0');
        public string out_hi_x_coord => _f1ex.hi_x_coord.TrimStart('0');
        public string out_hi_y_coord => _f1ex.hi_y_coord.TrimStart('0');
        public string out_com_dist => $"{_f1ex.com_dist.boro}{_f1ex.com_dist.district_number}";
        public string out_lion_key_face_code => _f1ex.lion_key.face_code;
        public string out_lion_key_sequence_number => _f1ex.lion_key.sequence_number;
        public string out_coincident_seg_cnt => _f1ex.coincident_seg_cnt;
        public string out_b10sc1 => _wa1.out_b10sc1.B10scToString();
        public string out_segment_id => _f1ex.segment_id;
        public string out_segment_len => _f1ex.segment_len;
        public string out_alx => _fld.get_get_short_def("alx", _f1ex.alx);
        public string out_segment_type => _fld.get_get_short_def("segment_type", _f1ex.segment_type.Trim());
        public string out_traffic_dir => _f1ex.traffic_dir;
        public string out_speed_limit => _f1ex.speed_limit;
        public string out_feature_type => _fld.get_get_short_def("feature_type", _f1ex.feature_type);
        public string out_roadway_type => _fld.get_get_short_def("roadway_type", _f1ex.roadway_type.Trim());
        public string out_right_of_way_type => _f1ex.right_of_way_type;
        public string out_physical_id => _f1ex.physical_id;
        public string out_generic_id => _f1ex.generic_id;
        public string out_spec_addr_flag => _fld.get_get_short_def("spec_addr_flag", _f1ex.spec_addr_flag);
        public string out_lo_hns => ValidationHelper.ValidateHouseNum(_f1ex.lo_hns, GeoCaller);
        public string out_hi_hns => ValidationHelper.ValidateHouseNum(_f1ex.hi_hns, GeoCaller);

        public string out_census_tract_2020 => string.IsNullOrWhiteSpace(_f1ex.census_tract_2020.Substring(4, 2))
            ? _f1ex.census_tract_2020
            : $"{_f1ex.census_tract_2020.Substring(0, 4)}.{_f1ex.census_tract_2020.Substring(4, 2)}";

        public string out_census_block_2020 => _f1ex.census_block_2020;
        public string out_census_block_suffix_2020 => _f1ex.census_block_suffix_2020;
        public string out_nta_2020 => _f1ex.nta_2020;
        public string out_cdta_2020 => _f1ex.cdta_2020;

        public string out_census_tract_2010 => string.IsNullOrWhiteSpace(_f1ex.census_tract_2010.Substring(4, 2))
            ? _f1ex.census_tract_2010
            : $"{_f1ex.census_tract_2010.Substring(0, 4)}.{_f1ex.census_tract_2010.Substring(4, 2)}";

        public string out_census_block_2010 => _f1ex.census_block_2010;

        public string out_census_tract_2000 => string.IsNullOrWhiteSpace(_f1ex.census_tract_2000.Substring(4, 2))
            ? _f1ex.census_tract_2000
            : $"{_f1ex.census_tract_2000.Substring(0, 4)}.{_f1ex.census_tract_2000.Substring(4, 2)}";

        public string out_census_block_2000 => _f1ex.census_block_2000;

        public string out_census_tract_1990 => string.IsNullOrWhiteSpace(_f1ex.census_tract_1990.Substring(4, 2))
            ? _f1ex.census_tract_1990
            : $"{_f1ex.census_tract_1990.Substring(0, 4)}.{_f1ex.census_tract_1990.Substring(4, 2)}";

        public string out_census_block_suffix_2000 => _f1ex.census_block_suffix_2000;
        public string out_census_block_suffix_2010 => _f1ex.census_block_suffix_2010;
        public string out_police_sector => _f1ex.police_sector;
        public string out_police_area => _f1ex.police_area;
        public string out_police_patrol_boro => _fld.get_get_long_def("police_patrol_boro", _f1ex.police_patrol_boro);
        public string out_police_pct => _f1ex.police_pct.TrimStart('0');
        public string out_fire_div => _f1ex.fire_div.TrimStart('0');
        public string out_fire_bat => _f1ex.fire_bat.TrimStart('0');
        public string out_fire_co => $"{_fld.get_get_short_def("fire_co_type", _f1ex.fire_co_type)} {_f1ex.fire_co_num.TrimStart('0')}";
        public string out_fire_co_str => _fld.get_get_short_def("fire_co_type", _f1ex.fire_co_type);
        public string out_health_area => $"{_f1ex.health_area.Substring(0, 2)}.{_f1ex.health_area.Substring(2, 2)}";
        public string out_health_center_dist => _f1ex.health_center_dist;
        public string out_dot_st_light_contract_area => _f1ex.dot_st_light_contract_area;
        public string out_san_dist_section => $"{_f1ex.san_dist} / {_f1ex.san_dist.Remove(0, 1)}{_f1ex.san_sched.Remove(1)}";
        public string out_san_sched => _f1ex.san_sched;
        public string out_san_reg => _f1ex.san_reg;
        public string out_san_recycle => _f1ex.san_recycle;
        public string out_san_org_pick_up => _f1ex.san_org_pick_up;
        public string out_school_dist => _f1ex.school_dist.TrimStart('0');
        public string out_dsny_snow_priority => _f1ex.dsny_snow_priority;
        public string out_dsny_snow_priority_str => _fld.get_get_short_def("dsny_snow_priority", _f1ex.dsny_snow_priority);
        public string out_hurricane_zone => _f1ex.hurricane_zone;
        public string out_san_commercial_waste_zone => _f1ex.san_commercial_waste_zone;
        public string out_puma_code => _f1ex.puma_code;
        public string out_puma_2020 => _f1ex.puma_2020;
        public string out_truck_route_type => _f1ex.truck_route_type;
        public string out_street_width_min => _f1ex.street_width;
        public string out_street_width_max => _f1ex.st_width_max;
        public string out_street_width_irregular => _f1ex.street_width_irregular;
        public string out_co => _f1ex.co.TrimStart('0');
        public string out_ad => _f1ex.ad;
        public string out_cd => _f1ex.cd;
        public string out_mc => _f1ex.mc.TrimStart('0');
        public string out_ed => _f1ex.ed;
        public string out_sd => _f1ex.sd;
        public string out_boe_preferred_b7sc => $"{_f1ex.boe_preferred_b7sc.ToString()} / {_f1ex.boe_preferred_stname}";
        public string out_individual_segment_length => _f1ex.individual_segment_length;
        public string out_condo_bill_scc => _f1ax.condo_bill_scc;
        public string out_nypd_id => _f1ex.nypd_id;
        public string out_fdny_id => _f1ex.fdny_id;

        public string out_bbl_block => _f1ax.bbl.block.TrimStart('0');
        public string out_bbl_lot => _f1ax.bbl.lot.TrimStart('0');
        public string out_bbl => _f1ax.bbl.BBLToString();
        public string out_num_of_blockfaces => _f1ax.num_of_blockfaces.TrimStart('0');
        public string out_sanborn_boro => _f1ax.sanborn.boro;
        public string out_sanborn_volume => $"{_f1ax.sanborn.volume}{_f1ax.sanborn.volume_suffix}";
        public string out_sanborn_page => $"{_f1ax.sanborn.page}{_f1ax.sanborn.page_suffix}";
        public string out_rpad_scc => _f1ax.rpad_scc;
        public string out_rpad_bldg_class => _f1ax.rpad_bldg_class;

        public string out_interior_flag => !string.IsNullOrWhiteSpace(_f1ax.interior_flag)
            ? _f1ax.interior_flag
            : "Not Interior Lot";

        public string out_irreg_flag => !string.IsNullOrWhiteSpace(_f1ax.irreg_flag)
            ? _f1ax.irreg_flag
            : "Not Irregular Lot";

        public string out_condo_num => !string.IsNullOrWhiteSpace(_f1ax.condo_num)
            ? _f1ax.condo_num
            : "N/A";

        public string out_coop_num => string.IsNullOrWhiteSpace(_f1ax.coop_num) || _f1ax.coop_num == "0000"
            ? "N/A"
            : _f1ax.coop_num;

        public string out_vacant_flag => _fld.get_get_short_def("vacant_flag", _f1ax.vacant_flag);
        public string out_condo_flag => _fld.get_get_short_def("condo_flag", _f1ax.condo_flag);

        public string out_low_bbl_condo => string.Equals(_f1ax.condo_flag, "C", StringComparison.OrdinalIgnoreCase)
            ? $"{_f1ax.condo_lo_bbl.boro} - {_f1ax.condo_lo_bbl.block} - {_f1ax.condo_lo_bbl.lot}"
            : "N/A";

        public string out_high_bbl_condo => string.Equals(_f1ax.condo_flag, "C", StringComparison.OrdinalIgnoreCase)
            ? $"{_f1ax.condo_hi_bbl.boro} - {_f1ax.condo_hi_bbl.block} - {_f1ax.condo_hi_bbl.lot}"
            : "N/A";

        public string out_condo_base_bbl => string.Equals(_f1ax.condo_flag, "C", StringComparison.OrdinalIgnoreCase) && !string.IsNullOrWhiteSpace(_f1ax.condo_base_bbl.block)
            ? $"{_f1ax.condo_base_bbl.boro} - {_f1ax.condo_base_bbl.block}  -  {_f1ax.condo_base_bbl.lot}"
            : "N/A";

        public string out_condo_billing_bbl => string.Equals(_f1ax.condo_flag, "C", StringComparison.OrdinalIgnoreCase)
            ? $"{_f1ax.condo_bill_bbl.boro} - {_f1ax.condo_bill_bbl.block}  -  {_f1ax.condo_bill_bbl.lot}"
            : "N/A";

        public string out_tax_map => _f1ax.dof_map.boro;
        public string out_tax_section => _f1ax.dof_map.section_volume.Remove(2, 2);
        public string out_tax_volume => _f1ax.dof_map.section_volume.Remove(0, 2);
        public string out_dcp_zoning_map => _f1ax.DCP_Zoning_Map;
        public string out_corner_code => _f1ax.corner_code;

        public string out_bid => string.IsNullOrWhiteSpace(_f1ax.bid_id.B5scToString())
            ? string.Empty
            : ValidationHelper.ReadStNameFd(_f1ax.bid_id.boro, _f1ax.bid_id.B5scToString().Remove(0, 1), GeoCaller);

        public string out_segment_azm => _f1ex.segment_azm;
        public string out_vanity_sos => _f1ex.vanity_sos;
        public string out_stroll_key => _f1ax.stroll_key;

        public string out_blockface_id => _f1ex.blockface_id;
        public string out_No_Traveling_lanes => _f1ex.No_Traveling_lanes;
        public string out_No_Parking_lanes => _f1ex.No_Parking_lanes;
        public string out_No_Total_Lanes => _f1ex.No_Total_Lanes;
        public string out_no_cross_street_calculation_flag => _f1ex.no_cross_street_calculation_flag;

        public string out_cd_eligible => _fld.get_get_short_def("cd_eligible", _f1ex.res_gss);
        public string out_curve_flag => _fld.get_get_short_def("curve_flag", _f1ex.curve_flag);
        public string out_lat_property => _f1ax.latitude;
        public string out_lon_property => _f1ax.longitude;
        public string out_valid_lgc_1 => _f1ex.valid_lgcs[0];
        public string out_valid_lgc_2 => _f1ex.valid_lgcs[1];
        public string out_valid_lgc_3 => _f1ex.valid_lgcs[2];
        public string out_valid_lgc_4 => _f1ex.valid_lgcs[3];

        public string out_bin => _f1ax.bin.BINToString();
        public string out_bin_status => _fld.get_get_short_def("TPAD_bin_status", _f1ax.TPAD_bin_status);
        public string out_TPAD_bin => _fld.get_get_short_def("TPAD_bin_status", _f1ax.TPAD_new_bin.ToString());
        public string out_TPAD_bin_status => _fld.get_get_short_def("TPAD_bin_status", _f1ax.TPAD_new_bin_status);
        public string out_TPAD_conflict_flag => _f1ax.TPAD_conflict_flag;

        public string out_num_of_bldgs => string.IsNullOrWhiteSpace(_f1ax.num_of_bldgs) || _f1ax.num_of_bldgs.TrimStart('0')?.Length == 0
            ? "0"
            : _f1ax.num_of_bldgs.TrimStart('0');

        public string out_from_dcp_preferred_lgcs1 => _f1ex.from_dcp_preferred_lgcs[0];
        public string out_from_dcp_preferred_lgcs2 => _f1ex.from_dcp_preferred_lgcs[1];
        public string out_from_dcp_preferred_lgcs3 => _f1ex.from_dcp_preferred_lgcs[2];
        public string out_from_dcp_preferred_lgcs4 => _f1ex.from_dcp_preferred_lgcs[3];
        public string out_from_dcp_preferred_lgcs5 => _f1ex.from_dcp_preferred_lgcs[4];
        public string out_to_dcp_preferred_lgcs1 => _f1ex.to_dcp_preferred_lgcs[0];
        public string out_to_dcp_preferred_lgcs2 => _f1ex.to_dcp_preferred_lgcs[1];
        public string out_to_dcp_preferred_lgcs3 => _f1ex.to_dcp_preferred_lgcs[2];
        public string out_to_dcp_preferred_lgcs4 => _f1ex.to_dcp_preferred_lgcs[3];
        public string out_to_dcp_preferred_lgcs5 => _f1ex.to_dcp_preferred_lgcs[4];
        public string out_from_additional_lgcs1 => _f1ex.from_additional_lgcs[0];
        public string out_from_additional_lgcs2 => _f1ex.from_additional_lgcs[1];
        public string out_from_additional_lgcs3 => _f1ex.from_additional_lgcs[2];
        public string out_from_additional_lgcs4 => _f1ex.from_additional_lgcs[3];
        public string out_from_additional_lgcs5 => _f1ex.from_additional_lgcs[4];
        public string out_to_additional_lgcs1 => _f1ex.to_additional_lgcs[0];
        public string out_to_additional_lgcs2 => _f1ex.to_additional_lgcs[1];
        public string out_to_additional_lgcs3 => _f1ex.to_additional_lgcs[2];
        public string out_to_additional_lgcs4 => _f1ex.to_additional_lgcs[3];
        public string out_to_additional_lgcs5 => _f1ex.to_additional_lgcs[4];
        public string out_x_coord_property => _f1ax.x_coord.TrimStart('0');
        public string out_y_coord_property => _f1ax.y_coord;
        public string out_atomic_polygon => _f1ex.dynamic_block;
        public string out_zip_code => _f1ex.zip_code;
        public string out_usps_city_name => _f1ex.USPS_city_name;
        public string out_segment_orientation => _f1ex.segment_orient;

        public string out_preferred_lgc => $"{_wa1.out_b10sc1.boro}{_wa1.out_b10sc1.sc5}{_f1ex.dcp_pref_lgc}";
        public string out_preferred_street_name => ValidationHelper.ReadStNameFdg(_wa1.out_b10sc1.boro, _wa1.out_b10sc1.sc5, _f1ex.dcp_pref_lgc, GeoCaller);
        public string out_bike_lane => _f1ex.bike_lane2;
        public string out_bike_traffic_direction => _fld.get_get_short_def("bike_traffic_direction", _f1ex.bike_traffic_direction);
        public string out_nta => $"{_f1ex.nta} / {_f1ex.nta_name}";
        public string out_boe_lgc_pointer => _f1ex.boe_lgc_pointer;

        public string out_san_bulk => _f1ex.san_bulk;

        public string out_sos_ind => _f1ex.lo_x_b7sc_list.Length > 0 && _f1ex.hi_x_b7sc_list.Length > 0
            ? $"Address is on the {ValidationHelper.ReadOrientation(_f1ex.sos_ind)} when facing from {_f1ex.lo_x_stname_list[0].Trim()} to {_f1ex.hi_x_stname_list[0].Trim()}"
            : string.Empty;
    }
}
