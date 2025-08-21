using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoServices_Core_Commons.Model.Inputs
{
    public class F1aInput
    {
        public string Id { get; set; } = string.Empty;

        public string Boro { get; set; } = string.Empty;
        public string AddrNo { get; set; } = string.Empty;
        public string StName { get; set; } = string.Empty;

        //optional params
        public string ZipCode { get; set; } = string.Empty;
        public string TPAD { get; set; } = "n";
        public string BrowseFlag { get; set; } = string.Empty;
        public string Unit { get; set; } = string.Empty;
        public string HNS { get; set; } = "n";
    }
}
