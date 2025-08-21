using GeoXWrapperLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperTest.Model.Response
{
    public class F1bResponse
    {
        public Wa1 wa1 { get; }
        public Wa2F1b wa2f1b { get; }

        public F1bResponse(Wa1 wa1, Wa2F1b wa2f1b)
        {
            this.wa1 = wa1;
            this.wa2f1b = wa2f1b;
        }

        public string out_b10sc1_toString => wa1.out_b10sc1.B10scToString();
        public string san_sched_toString => wa2f1b.wa2f1ex.san_sched;
        public string boe_preferred_b7sc_toString => wa2f1b.wa2f1ex.boe_preferred_b7sc.B7scToString();
        public string bbl_toString => wa2f1b.wa2f1ax.bbl.BBLToString();
        public string bin_toString => wa2f1b.wa2f1ax.bin.BINToString();
        public string out_TPAD_bin_toString => wa2f1b.wa2f1ax.TPAD_bin_status;
        public string out_bid_toString => wa2f1b.wa2f1ax.bid_id.B5scToString();
        public string out_b10sc1_sc5_toString => wa1.in_b10sc1.sc5;
        public string out_b10sc1_boro_toString => wa1.in_b10sc1.boro;
        public string nta_toString => wa2f1b.wa2f1ex.nta;
    }
}
