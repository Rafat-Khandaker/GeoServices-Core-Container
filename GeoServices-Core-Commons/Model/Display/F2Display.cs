using DCP.Geosupport.DotNet.fld_def_lib;
using GeoServices_Core_Commons.Core;
using GeoServices_Core_Commons.Core.Contract;
using GeoXWrapperLib.Model;
using GeoXWrapperTest.Helper;

namespace GeoXWrapperTest.Model.Display
{
    public class F2Display 
    {
        private static readonly fld_dict _fld = new fld_dict();
        private readonly Wa1 _wa1;
        private readonly Wa2F2w _wa2f2w;
        private readonly Wa2F2 _wa2f2;
        IGeoCaller GeoCaller;
        ValidationHelper ValidationHelper;


        public F2Display(Wa1 wa1, Wa2F2w wa2f2w, IGeoCaller geoCaller, ValidationHelper validationHelper)
        {
            _wa1 = wa1;
            _wa2f2w = wa2f2w;

            _wa2f2 = _wa2f2w.wa2f2;
            GeoCaller = geoCaller;
            ValidationHelper = validationHelper;

        }

        public List<string> B7SCList { get; set; }
        public List<int> B7SCStartingPoints { get; set; }
        public List<string> CrossStreets { get; set; }
        public List<string> NodeList => string.Equals(_wa1.out_grc, "03", StringComparison.CurrentCulture)
          ? _wa2f2w.node_list.Where(node => !string.IsNullOrWhiteSpace(node)).ToList()
          : null;

        public List<SimilarName> SimilarNamesList => ValidationHelper.CreateSimilarNamesList(_wa1.out_b7sc_list, _wa1.out_stname_list);

        public List<int> StartingXStreets { get;  set; }
        public string combined_san1_boro_vol_page => !string.IsNullOrWhiteSpace(_wa2f2.sanborn1.SanbornToString())
       ? $"{_wa2f2.sanborn1.boro}/{_wa2f2.sanborn1.volume}{_wa2f2.sanborn1.volume_suffix}/{_wa2f2.sanborn1.page}{_wa2f2.sanborn1.page_suffix}"
       : string.Empty;

        public string combined_san2_boro_vol_page => !string.IsNullOrWhiteSpace(_wa2f2.sanborn2.SanbornToString())
            ? $"{_wa2f2.sanborn2.boro}/{_wa2f2.sanborn2.volume}{_wa2f2.sanborn2.volume_suffix}/{_wa2f2.sanborn2.page}{_wa2f2.sanborn2.page_suffix}"
            : string.Empty;
        public string in_boro1 => _wa1.in_boro1;
        public string in_boro2 => _wa1.in_boro2;
        public string in_browse_flag => _wa1.in_browse_flag;
        public string in_compass_dir => _wa1.in_compass_dir;

        public string in_func_code => _wa1.in_func_code;
        public string in_node => _wa1.in_node;

        public string in_stname1 => _wa1.in_stname1;
        public string in_stname2 => _wa1.in_stname2;
        public string out_ad => _wa2f2.ad;
        public string out_atomic_polygon => _wa2f2.atomic_polygon;
        public string out_boro_name1 => _wa1.out_boro_name1;
        public string out_cd => _wa2f2.cd;
        public string out_cd_eligible => _fld.get_get_short_def("cd_eligible", _wa2f2.cd_eligible);
        public string out_cdta_2020 => _wa2f2w.cdta_2020;
        public string out_census_block_2020 => _wa2f2w.census_block_2020;
        public string out_census_tract_2000 => string.IsNullOrWhiteSpace(_wa2f2.census_tract_2000.Substring(4, 2))
            ? _wa2f2.census_tract_2000
            : $"{_wa2f2.census_tract_2000.Substring(0, 4)}.{_wa2f2.census_tract_2000.Substring(4, 2)}";

        public string out_census_tract_2010 => string.IsNullOrWhiteSpace(_wa2f2.census_tract_2010.Substring(4, 2))
            ? _wa2f2.census_tract_2010
            : $"{_wa2f2.census_tract_2010.Substring(0, 4)}.{_wa2f2.census_tract_2010.Substring(4, 2)}";


        public string out_census_tract_2020 => string.IsNullOrWhiteSpace(_wa2f2.census_tract_2020.Substring(4, 2))
            ? _wa2f2.census_tract_2020
            : $"{_wa2f2.census_tract_2020.Substring(0, 4)}.{_wa2f2.census_tract_2020.Substring(4, 2)}";
        public string out_co => _wa2f2.co.TrimStart('0');
        public string out_com_dist => _wa2f2.com_dist.boro + _wa2f2.com_dist.district_number;
        public string out_compass => _wa2f2.compass;
        public string out_dcp_pref_lgc1 => !String.IsNullOrEmpty(in_node)? "N/A" : $"{_wa1.out_b10sc1.boro}{_wa1.out_b10sc1.sc5}{_wa2f2.dcp_pref_lgc1}/ {ValidationHelper.ReadStNameFdg(_wa1.out_b10sc1.boro, _wa1.out_b10sc1.sc5, _wa2f2.dcp_pref_lgc1, GeoCaller)}";
        public string out_dcp_pref_lgc2 => !String.IsNullOrEmpty(in_node) ? "N/A" : $"{_wa1.out_b10sc2.boro}{_wa1.out_b10sc2.sc5}{_wa2f2.dcp_pref_lgc2}/ {ValidationHelper.ReadStNameFdg(_wa1.out_b10sc2.boro, _wa1.out_b10sc2.sc5, _wa2f2.dcp_pref_lgc2, GeoCaller)}";
        public string out_dot_st_light_contract_area => _wa2f2.dot_st_light_contract_area;
        public string out_error_message => _wa1.out_error_message;
        public string out_fire_bat => _wa2f2.fire_bat.TrimStart('0');
        public string out_fire_co => $"{_fld.get_get_short_def("fire_co_type", _wa2f2.fire_co_type)} {_wa2f2.fire_co_num.TrimStart('0')}";
        public string out_fire_co_str => _fld.get_get_short_def("fire_co_type", out_fire_co);
        public string out_fire_div => _wa2f2.fire_div.TrimStart('0');
        public string out_grc => _wa1.out_grc;
        public string out_health_area => $"{_wa2f2.health_area.Substring(0, 2)}.{_wa2f2.health_area.Substring(2, 2)}";
        public string out_health_center_dist => _wa2f2.health_center_dist;
        public string out_latitude => _wa2f2w.latitude;
        public string out_lion_node_num => _wa2f2.lion_node_num;
        public string out_longitude => _wa2f2w.longitude;
        public string out_mc => _wa2f2.mc.TrimStart('0');
        public string out_nta_2020 => _wa2f2w.nta_2020;
        public string out_police_patrol_boro => _wa2f2.police_patrol_boro;
        public string out_police_pct => _wa2f2.police_pct.TrimStart('0');
        public string out_police_sector => _wa2f2.police_sector;
        public string out_reason_code => _wa1.out_reason_code;
        public string out_san_dist_section => $"{_wa2f2.san_dist}/ {_wa2f2.san_dist.Substring(1, 2)}{_wa2f2.san_sub_section.Substring(0, 1)}";
        public string out_san_sub_section => _wa2f2.san_sub_section;
        public string out_sanborn1_boro => _wa2f2.sanborn1.boro;
        public string out_sanborn1_page => _wa2f2.sanborn1.page + _wa2f2.sanborn1.page_suffix;
        public string out_sanborn1_vol => _wa2f2.sanborn1.volume + _wa2f2.sanborn1.volume_suffix;
        public string out_sanborn2_boro => _wa2f2.sanborn2.boro;
        public string out_sanborn2_page => _wa2f2.sanborn2.page + _wa2f2.sanborn2.page_suffix;
        public string out_sanborn2_vol => _wa2f2.sanborn2.volume + _wa2f2.sanborn2.volume_suffix;
        public string out_school_dist => _wa2f2.school_dist.TrimStart('0');
        public string out_sd => _wa2f2.sd;

        public string out_stname1 => _wa1.out_stname1;
        public string out_stname2 => _wa1.out_stname2;

        public string out_wa1_message => _wa1.out_error_message;
        public string out_x_coord => _wa2f2.x_coord.TrimStart('0');
        public string out_y_coord => _wa2f2.y_coord.TrimStart('0');

        public string out_zip_code => _wa2f2.zip_code;

    }
}
