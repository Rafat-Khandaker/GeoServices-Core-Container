using GeoXWrapperLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperTest.Model.Display
{
    public class F1lDisplay
    {
        private readonly Wa1 _wa1;

        public F1lDisplay(Wa1 wa1) => _wa1 = wa1;

        public string in_func_code => _wa1.in_func_code;
        public string in_hnd => _wa1.in_hnd;
        public string out_error_message => _wa1.out_error_message;
        public string out_grc => _wa1.out_grc;
        public string out_hnd => _wa1.out_hnd;
        public string out_reason_code => _wa1.out_reason_code;
    }
}
