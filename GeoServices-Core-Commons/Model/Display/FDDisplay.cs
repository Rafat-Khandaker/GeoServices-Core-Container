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
    public class FDDisplay 
    {
        private readonly Wa1 _wa1;

        public FDDisplay(Wa1 wa1) => _wa1 = wa1;

        #region Data List
        public List<StreetCode> StreetCodeList
        {
            get
            {
                fld_dict fld = new fld_dict();
                List<StreetCode> scl = new List<StreetCode>();

                if (!string.IsNullOrWhiteSpace(_wa1.out_b10sc1.B10scToString()))
                {
                    scl.Add(new StreetCode
                    {
                        borough = ValidationHelper.ReadBoroName(_wa1.out_b10sc1.boro),
                        b10sc = _wa1.out_b10sc1,
                        b10sc_toString = _wa1.out_b10sc1.B10scToString(),
                        streetName = _wa1.out_stname1,
                        gft = fld.get_get_short_def("gft", _wa1.out_attr_bytes[0])
                    });
                }

                if (!string.IsNullOrWhiteSpace(_wa1.out_b10sc2.B10scToString()))
                {
                    scl.Add(new StreetCode
                    {
                        borough = ValidationHelper.ReadBoroName(_wa1.out_b10sc2.boro),
                        b10sc = _wa1.out_b10sc2,
                        b10sc_toString = _wa1.out_b10sc2.B10scToString(),
                        streetName = _wa1.out_stname2,
                        gft = fld.get_get_short_def("gft", _wa1.out_attr_bytes[1])
                    });
                }

                if (!string.IsNullOrWhiteSpace(_wa1.out_b10sc3.B10scToString()))
                {
                    scl.Add(new StreetCode
                    {
                        borough = ValidationHelper.ReadBoroName(_wa1.out_b10sc3.boro),
                        b10sc = _wa1.out_b10sc3,
                        b10sc_toString = _wa1.out_b10sc3.B10scToString(),
                        streetName = _wa1.out_stname3,
                        gft = fld.get_get_short_def("gft", _wa1.out_attr_bytes[2])
                    });
                }

                return scl;
            }
        }
        #endregion

        public string in_b10sc1 => _wa1.in_b10sc1.B10scToString();
        public string in_b10sc2 => _wa1.in_b10sc2.B10scToString();
        public string in_b10sc3 => _wa1.in_b10sc3.B10scToString();
        public string in_boro1 => _wa1.in_boro1;
        public string in_boro2 => _wa1.in_boro2;
        public string in_boro3 => _wa1.in_boro3;
        public string in_func_code => _wa1.in_func_code;
        public string in_snl => _wa1.in_snl;
        public string in_stname_normalization => _wa1.in_stname_normalization;
        public string out_error_message => _wa1.out_error_message;
        public string out_grc => _wa1.out_grc;
        public string out_reason_code => _wa1.out_reason_code;
    }
}
