using GeoXWrapperLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperTest.Model.Response
{
    public class F1aResponse
    {
        public Wa1 wa1 { get; }
        public Wa2F1ax wa2f1ax { get; }

        public F1aResponse(Wa1 wa1, Wa2F1ax wa2f1ax)
        {
            this.wa1 = wa1;
            this.wa2f1ax = wa2f1ax;
        }
        #region Data Lists
        public List<AddressRange> AddressRangeList { get; set; } //NOTE: must be set in function controller
        public List<CompleteBIN> CompleteBINList { get; set; } //NOTE: must be set in function controller

        //TODO 1-11-23 we may implement bins, keys, and sim names lists in root objects as well
        #endregion

        public string out_bin_toString => wa2f1ax.bin.BINToString();
        public string out_bbl_toString => wa2f1ax.bbl.BBLToString();
        public string out_b10sc_toString => wa1.out_b10sc1.B10scToString();
        public string out_business_area_toString => wa2f1ax.business_area.BusAreaToString();
        public string out_bid_toString => wa2f1ax.bid_id.B5scToString();
        public string out_dof_map_toString => wa2f1ax.dof_map.DofMapToString();
        public string out_sanborn_toString => wa2f1ax.sanborn.SanbornToString();
    }
}
