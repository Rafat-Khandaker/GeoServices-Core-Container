using GeoXWrapperLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperTest.Model.Display
{
    public class FNDisplay
    {
        private readonly Wa1 _wa1;

        public FNDisplay(Wa1 wa1) => _wa1 = wa1;

        public string in_func_code => _wa1.in_func_code;
        public string in_snl => _wa1.in_snl;
        public string in_stname1 => _wa1.in_stname1;
        public string in_stname_normalization => _wa1.in_stname_normalization;
        public string out_error_message => _wa1.out_error_message;
        public string out_grc => _wa1.out_grc;
        public string out_reason_code => _wa1.out_reason_code;
        public string out_stname1 => _wa1.out_stname1;
    }
}
