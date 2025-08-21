using GeoXWrapperLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperTest.Model.Display
{
    public class FBBDisplay
    {
        private readonly Wa1 _wa1;

        public FBBDisplay(Wa1 wa1) => _wa1 = wa1;

        public List<SndEntry> FunctionBBList
        {
            get
            {
                if (_wa1.out_b7sc_list.Length == 0)
                    return Enumerable.Empty<SndEntry>().ToList();

                return _wa1.out_b7sc_list
                    .Select((b7sc, i) => new SndEntry
                    {
                        out_boro_name1 = _wa1.out_boro_name1,
                        out_b7sc = b7sc.B7scToString(),
                        out_stname1 = _wa1.out_stname_list[i]
                    })
                    .ToList();
            }
        }

        public string in_func_code => _wa1.in_func_code;
        public string in_boro => _wa1.in_boro1;
        public string in_stname1 => _wa1.in_stname1;
        public string in_browse_flag => _wa1.in_browse_flag;
        public string out_grc => _wa1.out_grc;
        public string out_error_message => _wa1.out_error_message;
        public string out_reason_code => _wa1.out_reason_code;
        public string out_boro_name1 => _wa1.out_boro_name1;
    }
}
