using GeoXWrapperLib;
using GeoXWrapperLib.Model;
using GeoXWrapperTest.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperTest.Model.Display
{
    public class F3sDisplay 
    {
        private readonly Wa1 _wa1;
        private readonly Wa2F3s _wa2f3s;
        Geo GeoCaller;

        public F3sDisplay(Wa1 wa1, Wa2F3s wa2f3s, Geo geoCaller)
        {
            _wa1 = wa1;
            _wa2f3s = wa2f3s;
            GeoCaller = geoCaller;

        }

        #region Data Lists - Must set in controller
        public List<CrxStInfoF3S> F3SList => ValidationHelper.CreateF3sIntrsctList(_wa2f3s.xstr_list, GeoCaller);
        public List<SimilarName> SimilarNamesList => ValidationHelper.CreateSimilarNamesList(_wa1.out_b7sc_list, _wa1.out_stname_list);
        #endregion

        public string in_func_code => _wa1.in_func_code;
        public string in_boro => _wa1.in_boro1;
        public string in_stname1 => _wa1.in_stname1;
        public string in_stname2 => _wa1.in_stname2;
        public string in_stname3 => _wa1.in_stname3;
        public string in_b10sc1 => _wa1.in_b10sc1.B10scToString();
        public string in_b10sc2 => _wa1.in_b10sc2.B10scToString();
        public string in_b10sc3 => _wa1.in_b10sc3.B10scToString();
        public string in_compass_dir => _wa1.in_compass_dir;
        public string in_compass_dir2 => _wa1.in_compass_dir2;
        public string in_real_street_only => _wa1.in_real_street_only;
        public string in_roadbed_request_switch => _wa1.in_roadbed_request_switch;

        public string out_boro_name1 => _wa1.out_boro_name1;
        public string out_stname1 => _wa1.out_stname1;
        public string out_stname2 => _wa1.out_stname2;
        public string out_stname3 => _wa1.out_stname3;
        public string out_grc => _wa1.out_grc;
        public string out_error_message => _wa1.out_error_message;
        public string out_wa1_message => _wa1.out_error_message;
        public string out_reason_code => _wa1.out_reason_code;
        public string out_number_of_intersections => _wa2f3s.num_of_intersections;
        public string out_total_street_distance
        {
            get
            {
                int total = 0;
                foreach (CrossStreetInfo crxStInfo in _wa2f3s.xstr_list)
                {
                    string gapFlag = crxStInfo.gap_flag.Trim();

                    if (int.TryParse(crxStInfo.distance, out int street_distance) && !string.Equals(gapFlag, "G", StringComparison.OrdinalIgnoreCase) && !string.Equals(gapFlag, "N", StringComparison.OrdinalIgnoreCase))
                    {
                        total += street_distance;
                    }
                }

                return $"{total:N0} feet";
            }
        }
    }
}
