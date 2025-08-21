using GeoXWrapperLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperTest.Model.Display
{
    public class F5Display
    {
        private readonly Wa1 _wa1;
        private readonly Wa2F5 _wa2f5;

        public F5Display(Wa1 wa1, Wa2F5 wa2f5)
        {
            _wa1 = wa1;
            _wa2f5 = wa2f5;
        }

        public string in_func_code => _wa1.in_func_code;
        public string in_boro => _wa1.in_boro1;
        public string in_high_house_number => _wa1.in_hnd;
        public string in_low_house_number => _wa1.in_low_hnd;
        public string in_stname => _wa1.in_stname1;
        public string in_b10sc1 => _wa1.in_b10sc1.B10scToString();

        public string out_grc => _wa1.out_grc;
        public string out_error_message => _wa1.out_error_message;

        public string out_high_grid_key => _wa2f5.gridkey1.VsamKey1ToString();
        public string out_low_grid_key => _wa2f5.lohns;
        public string out_stame => _wa1.out_stname1;
    }
}
