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
    public class F1nDisplay
    {
        private static readonly fld_dict _fld = new fld_dict();
        private readonly Wa1 _wa1;

        public F1nDisplay(Wa1 wa1) => _wa1 = wa1;
        public List<SimilarName> SimilarNamesList => ValidationHelper.CreateSimilarNamesList(_wa1.out_b7sc_list, _wa1.out_stname_list);

        public string in_boro => _wa1.in_boro1;
        public string in_func_code => _wa1.in_func_code;
        public string in_snl => _wa1.in_snl;
        public string in_stname1 => _wa1.out_stname1;
        public string in_stname_normalization => _wa1.in_stname_normalization;
        public string out_b10sc1 => _wa1.out_b10sc1.B10scToString();
        public string out_boro_name1 => _wa1.out_boro_name1;
        public string out_error_message => _wa1.out_error_message;
        public string out_gft => _fld.get_get_short_def("gft", _wa1.out_attr_bytes[0]);
        public string out_grc => _wa1.out_grc;
        public string out_reason_code => _wa1.out_reason_code;
        public string out_stname1 => _wa1.out_stname1;
    }
}
