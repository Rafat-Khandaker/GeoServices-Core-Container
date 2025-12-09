using DCP.Geosupport.DotNet.fld_def_lib;
using GeoXWrapperLib.Model;
using GeoXWrapperTest.Helper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperTest.Model.Display
{
    public class F1aDisplay
    {
        private static readonly fld_dict _fld = new fld_dict();
        private readonly Wa1 _wa1;
        private readonly Wa2F1ax _wa2f1ax;
        ValidationHelper ValidationHelper;


        public F1aDisplay(Wa1 wa1, Wa2F1ax wa2f1ax, ValidationHelper validationHelper)
        {
            _wa1 = wa1;
            _wa2f1ax = wa2f1ax;
            ValidationHelper = validationHelper;
        }

        #region Data Lists - Must Set in Function Controller

        public Dictionary<string,string> AddressRangeKeys => ValidationHelper.CreateAddressRangeKeys(_wa2f1ax.addr_x_list);

        public List<AddressRange> AddressRangeList { get; set; }

        public List<SimilarName> SimilarNamesList => ValidationHelper.CreateSimilarNamesList(_wa1.out_b7sc_list, _wa1.out_stname_list);

        public List<CompleteBIN> CompleteBINList { get; set; }
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

        public string out_stname1 => _wa1.out_stname1;
        public string out_hnd => _wa1.out_hnd;
        public string out_hns => _wa1.out_hns;
        public string out_boro_name1 => _wa1.out_boro_name1;
        public string out_unit => _wa1.out_unit;

        public string out_grc => _wa1.out_grc;
        public string out_reason_code => string.Equals(_wa1.out_reason_code, "I", StringComparison.OrdinalIgnoreCase) ? "1" : _wa1.out_reason_code;
        public string out_error_message => _wa1.out_error_message;
        public string out_wa1_message => _wa1.out_error_message;

        public string out_bbl_block => _wa2f1ax.bbl.block.TrimStart('0');
        public string out_bbl_lot => _wa2f1ax.bbl.lot.TrimStart('0');
        public string out_bbl => _wa2f1ax.bbl.BBLToString();
        public string out_num_of_blockfaces => _wa2f1ax.num_of_blockfaces.TrimStart('0');
        public string out_sanborn_boro => _wa2f1ax.sanborn.boro;
        public string out_sanborn_volume => _wa2f1ax.sanborn.volume + _wa2f1ax.sanborn.volume_suffix;
        public string out_sanborn_page => _wa2f1ax.sanborn.page + _wa2f1ax.sanborn.page_suffix;
        public string out_x_coord_property => _wa2f1ax.x_coord.TrimStart('0');
        public string out_y_coord_property => _wa2f1ax.y_coord.TrimStart('0');
        public string out_lat_property => _wa2f1ax.latitude;
        public string out_lon_property => _wa2f1ax.longitude;
        public string out_vacant_flag => _fld.get_get_short_def("vacant_flag", _wa2f1ax.vacant_flag);

        public string out_low_bbl_condo => string.Equals(_wa2f1ax.condo_flag, "C", StringComparison.OrdinalIgnoreCase)
            ? $"{_wa2f1ax.condo_lo_bbl.boro} - {_wa2f1ax.condo_lo_bbl.block} - {_wa2f1ax.condo_lo_bbl.lot}"
            : "N/A";

        public string out_high_bbl_condo => string.Equals(_wa2f1ax.condo_flag, "C", StringComparison.OrdinalIgnoreCase)
            ? $"{_wa2f1ax.condo_hi_bbl.boro} - {_wa2f1ax.condo_hi_bbl.block} - {_wa2f1ax.condo_hi_bbl.lot}"
            : "N/A";

        public string out_condo_base_bbl => string.Equals(_wa2f1ax.condo_flag, "C", StringComparison.OrdinalIgnoreCase) && !string.IsNullOrWhiteSpace(_wa2f1ax.condo_base_bbl.block)
            ? $"{_wa2f1ax.condo_base_bbl.boro} - {_wa2f1ax.condo_base_bbl.block} - {_wa2f1ax.condo_base_bbl.lot}"
            : "N/A";

        public string out_condo_billing_bbl => string.Equals(_wa2f1ax.condo_flag, "C", StringComparison.OrdinalIgnoreCase)
            ? $"{_wa2f1ax.condo_bill_bbl.boro} - {_wa2f1ax.condo_bill_bbl.block} - {_wa2f1ax.condo_bill_bbl.lot}"
            : "N/A";

        public string out_bin => _wa2f1ax.bin.BINToString();

        public string out_TPAD_bin => string.Equals(_wa1.in_tpad_switch, "Y", StringComparison.OrdinalIgnoreCase) || string.Equals(_wa1.in_tpad_switch, "true", StringComparison.OrdinalIgnoreCase)
            ? _fld.get_get_short_def("TPAD_bin_status", _wa2f1ax.TPAD_new_bin.BINToString())
            : "N/A";

        public string out_corner_code => _wa2f1ax.corner_code;

        public string out_num_of_bldgs => string.IsNullOrWhiteSpace(_wa2f1ax.num_of_bldgs) || _wa2f1ax.num_of_bldgs.TrimStart('0')?.Length == 0
            ? "0"
            : _wa2f1ax.num_of_bldgs.TrimStart('0');

        public string out_bid { get; set; }

        public string out_rpad_scc => _wa2f1ax.rpad_scc;
        public string out_rpad_bldg_class => _wa2f1ax.rpad_bldg_class;

        public string out_interior_flag => !string.IsNullOrWhiteSpace(_wa2f1ax.interior_flag)
            ? _wa2f1ax.interior_flag
            : "Not Interior Lot";

        public string out_irreg_flag => !string.IsNullOrWhiteSpace(_wa2f1ax.irreg_flag)
            ? _wa2f1ax.irreg_flag
            : "Not Irregular Lot";

        public string out_condo_num => !string.IsNullOrWhiteSpace(_wa2f1ax.condo_num)
            ? _wa2f1ax.condo_num
            : "N/A";

        public string out_coop_num => string.IsNullOrWhiteSpace(_wa2f1ax.coop_num) || _wa2f1ax.coop_num == "0000"
            ? "N/A"
            : _wa2f1ax.coop_num;

        public string out_condo_flag => _fld.get_get_short_def("condo_flag", _wa2f1ax.condo_flag);
        public string out_tax_map => _wa2f1ax.dof_map.boro;
        public string out_tax_section => _wa2f1ax.dof_map.section_volume.Remove(2, 2);
        public string out_tax_volume => _wa2f1ax.dof_map.section_volume.Remove(0, 2);
        public string out_dcp_zoning_map => _wa2f1ax.DCP_Zoning_Map;

        public string out_bin_status => string.Equals(_wa1.in_tpad_switch, "Y", StringComparison.OrdinalIgnoreCase) || string.Equals(_wa1.in_tpad_switch, "true", StringComparison.OrdinalIgnoreCase)
            ? _fld.get_get_short_def("TPAD_bin_status", _wa2f1ax.TPAD_bin_status)
            : "N/A";

        public string out_TPAD_bin_status => string.Equals(_wa1.in_tpad_switch, "Y", StringComparison.OrdinalIgnoreCase) || string.Equals(_wa1.in_tpad_switch, "true", StringComparison.OrdinalIgnoreCase)
            ? _fld.get_get_short_def("TPAD_bin_status", _wa2f1ax.TPAD_new_bin_status)
            : "N/A";

        public string out_TPAD_conflict_flag => string.Equals(_wa1.in_tpad_switch, "Y", StringComparison.OrdinalIgnoreCase) || string.Equals(_wa1.in_tpad_switch, "true", StringComparison.OrdinalIgnoreCase)
            ? _wa2f1ax.TPAD_conflict_flag
            : "N/A";
    }
}
