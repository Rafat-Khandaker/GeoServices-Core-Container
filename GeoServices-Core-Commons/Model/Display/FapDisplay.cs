using DCP.Geosupport.DotNet.fld_def_lib;
using GeoXWrapperLib.Model;
using GeoXWrapperTest.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperTest.Model.Display
{
    public class FapDisplay
    {
        private static readonly fld_dict _fld = new fld_dict();
        private readonly Wa1 _wa1;
        private readonly Wa2Fapx _wa2fapx;

        public FapDisplay(Wa1 wa1, Wa2Fapx wa2fapx)
        {
            _wa1 = wa1;
            _wa2fapx = wa2fapx;
        }

        #region Data Lists - must be get in function controller
        public List<AddressRangeApx> AddressRangeList => ValidationHelper.CreateAddressRangeList(_wa2fapx.addr_x_list);
        public List<SimilarName> SimilarNamesList => ValidationHelper.CreateSimilarNamesList(_wa1.out_b7sc_list, _wa1.out_stname_list);
        #endregion

        public string in_func_code => _wa1.in_func_code;
        public string in_boro => _wa1.in_boro1;
        public string in_hnd => _wa1.in_hnd;
        public string in_stname1 => _wa1.in_stname1;
        public string in_zip_code => _wa1.in_zip_code;
        public string in_hns => _wa1.in_hns;
        public string in_unit => _wa1.in_unit;

        public string out_stname1 => _wa1.out_stname1;
        public string out_hnd => _wa1.out_hnd;
        public string out_hns => _wa1.out_hns;
        public string out_boro_name1 => _wa1.out_boro_name1;
        public string out_reason_code => _wa1.out_reason_code;

        public string out_grc => _wa1.out_grc;
        public string out_error_message => _wa1.out_error_message;
        public string out_wa1_message => _wa1.out_error_message;
        public string out_bbl_block => _wa2fapx.bbl.block.TrimStart('0');
        public string out_bbl_lot => _wa2fapx.bbl.lot.TrimStart('0');
        public string out_bbl_bbl => _wa2fapx.bbl.BBLToString();
        public string out_x_coord => _wa2fapx.x_coord.TrimStart('0');
        public string out_y_coord => _wa2fapx.y_coord.TrimStart('0');
        public string out_bin => $"{_wa2fapx.bin.boro}{_wa2fapx.bin.binnum}";
        public string out_ap_id => _wa2fapx.ap_id.TrimStart('0');
        public string out_condo_lot => _fld.get_get_short_def("condo_flag", _wa2fapx.condo_flag);

        public string out_rpad_condo_num => string.Equals(_wa2fapx.condo_flag.Trim(), "C", StringComparison.OrdinalIgnoreCase)
            ? _wa2fapx.condo_num
            : "N/A";

        public string out_rpad_coop_num => string.IsNullOrWhiteSpace(_wa2fapx.coop_num) || (_wa2fapx.coop_num.Trim() == "0000")
            ? "N/A"
            : _wa2fapx.coop_num;

        public string out_low_bbl_condo => string.Equals(_wa2fapx.condo_flag.Trim(), "C", StringComparison.OrdinalIgnoreCase)
            ? $"{_wa2fapx.condo_lo_bbl.boro} - {_wa2fapx.condo_lo_bbl.block} - {_wa2fapx.condo_lo_bbl.lot}"
            : "N/A";

        public string out_high_bbl_condo => string.Equals(_wa2fapx.condo_flag.Trim(), "C", StringComparison.OrdinalIgnoreCase)
            ? $"{_wa2fapx.condo_hi_bbl.boro} - {_wa2fapx.condo_hi_bbl.block} - {_wa2fapx.condo_hi_bbl.lot}"
            : "N/A";

        public string out_latitude => _wa2fapx.latitude.TrimStart('0');
        public string out_longitude => _wa2fapx.longitude.TrimStart('0');

        public string out_num_of_bldgs => string.IsNullOrWhiteSpace(_wa2fapx.num_of_bldgs) || _wa2fapx.num_of_bldgs.All(c => Equals(c, '0'))
            ? "0"
            : _wa2fapx.num_of_bldgs.TrimStart('0');

        public string out_unit => _wa1.out_unit;
        public string out_unit_type => _wa1.out_units.unit_type;
        public string out_unit_identifier => _wa1.out_units.unit_identifier;
    }
}
