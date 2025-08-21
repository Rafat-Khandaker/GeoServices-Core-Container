using GeoServices_Core_Commons.Helper;
using GeoXWrapperLib;
using GeoXWrapperLib.Model;
using GeoXWrapperTest.Model.Display;
using GeoXWrapperTest.Model;
using Microsoft.AspNetCore.Mvc;
using GeoXWrapperTest.Model.Response;

namespace GeoServices_Core_Web_API.Controllers
{
    public class Functon_NController : Controller
    {
        private Geo _geo;
        private AccessControlList _accessControl;

        public Functon_NController(Geo geo, AccessControlList accessControlList)
        {
            _geo = geo;
            _accessControl = accessControlList.ReadKeyFile(true).Result;
        }

        [HttpGet]
        public IActionResult Get(string key, string streetName = "", string streetNameLength = "32", string streetNameFormat = "S", string displayFormat = "true")
        {
            if (string.IsNullOrEmpty(key)) return BadRequest("Please provide your API key as a parameter"); else if (!_accessControl.Verify(key)) return Unauthorized();

            //work area setup
            //marshall validated inputs into wa1
            Wa1 wa1 = new Wa1
            {
                in_func_code = "N*",

                in_stname1 = streetName?.Replace(" and ", " & ") ?? string.Empty,
                in_snl = streetNameLength ?? string.Empty,
                in_stname_normalization = streetNameFormat ?? string.Empty
            };

            //geocall and finalize responses
            _geo.GeoCall(ref wa1);

            if (string.Equals(displayFormat, "false", StringComparison.OrdinalIgnoreCase))
            {
                GeocallResponse<FNDisplay, FNResponse> raw = new GeocallResponse<FNDisplay, FNResponse>
                {
                    display = null,
                    root = new FNResponse(wa1)
                };

                return Ok(raw);
            }
            else
            {
                GeocallResponse<FNDisplay, FNResponse> goatlike = new GeocallResponse<FNDisplay, FNResponse>
                {
                    display = new FNDisplay(wa1),
                    root = null
                };

                return Ok(goatlike);
            }
        }
    }
}
