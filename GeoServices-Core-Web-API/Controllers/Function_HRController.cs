using GeoServices_Core_Commons.Helper;
using GeoXWrapperLib;
using GeoXWrapperLib.Model;
using GeoXWrapperTest.Model.Display;
using GeoXWrapperTest.Model;
using Microsoft.AspNetCore.Mvc;
using GeoXWrapperTest.Model.Response;

namespace GeoServices_Core_Web_API.Controllers
{
    public class Function_HRController : Controller
    {
        private Geo _geo;
        private AccessControlList _accessControl;

        public Function_HRController(Geo geo, AccessControlList accessControlList)
        {
            _geo = geo;
            _accessControl = accessControlList.ReadKeyFile(true).Result;
        }

        /// <summary>
        /// Function HR returns the version data for Geoservice files. Displays creation date, Geosupport release cycle, and number of records
        /// </summary>
        /// <param name="key">Your geoservice key, apply at https://geoservice.planning.nyc.gov/Register</param>
        /// <param name="displayFormat">Defaults to "true" for the beautified GOAT-like format. Use "false" for raw format to see the returned work areas</param>
        /// <returns>FHR geocall response</returns>
        /// <response code="200">Your geocall response. May be a hit, warning, or reject based on your input. `root` will be populated for raw format `displayFormat=false`, while `display` will be populated for goat-like format `displayFormat=true`</response>
        /// <response code="400">If required key parameter is missing</response>
        /// <response code="401">If key is invalid or deactivated</response>
        [HttpGet]
        public IActionResult Get(string key, string displayFormat = "true")
        {
            if (string.IsNullOrEmpty(key)) return BadRequest("Please provide your API key as a parameter"); else if (!_accessControl.Verify(key)) return Unauthorized();

            //work area setup
            Wa1 wa1 = new Wa1
            {
                in_func_code = "HR"
            };
            Wa2Fhr wa2fhr = new Wa2Fhr();

            //geocall and finalize responses
            _geo.GeoCall(ref wa1, ref wa2fhr);

            if (string.Equals(displayFormat, "false", StringComparison.OrdinalIgnoreCase))
            {
                GeocallResponse<FHRDisplay, FHRResponse> raw = new GeocallResponse<FHRDisplay, FHRResponse>
                {
                    display = null,
                    root = new FHRResponse(wa1, wa2fhr)
                };

                return Ok(raw);
            }
            else
            {
                GeocallResponse<FHRDisplay, FHRResponse> goatlike = new GeocallResponse<FHRDisplay, FHRResponse>
                {
                    display = new FHRDisplay(wa1, wa2fhr),
                    root = null
                };

                return Ok(goatlike);
            }
        }
    }
}
