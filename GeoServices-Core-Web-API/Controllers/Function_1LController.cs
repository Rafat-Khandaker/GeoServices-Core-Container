using GeoServices_Core_Commons.Helper;
using GeoXWrapperLib;
using GeoXWrapperLib.Model;
using GeoXWrapperTest.Model.Display;
using GeoXWrapperTest.Model;
using Microsoft.AspNetCore.Mvc;
using GeoXWrapperTest.Model.Response;

namespace GeoServices_Core_Web_API.Controllers
{
    public class Function_1LController : Controller
    {
        private Geo _geo;
        private AccessControlList _accessControl;

        public Function_1LController(Geo geo, AccessControlList accessControlList)
        {
            _geo = geo;
            _accessControl = accessControlList.ReadKeyFile(true).Result;
        }


        /// <summary>
        /// Enter a address number, which Function 1L will normalize so that it is valid for use in other functions. For example, “123 a” is normalized as “123A”.
        /// </summary>
        /// <param name="key">Your geoservice key, apply at https://geoservice.planning.nyc.gov/Register</param>
        /// <param name="addressNo">Address number to be normalized</param>
        /// <param name="displayFormat">Defaults to "true" for the beautified GOAT-like format. Use "false" for raw format to see the returned work areas</param>
        /// <returns>F1L geocall response</returns>
        /// <response code="200">Your geocall response. May be a hit, warning, or reject based on your input. `root` will be populated for raw format `displayFormat=false`, while `display` will be populated for goat-like format `displayFormat=true`</response>
        /// <response code="400">If required key parameter is missing</response>
        /// <response code="401">If key is invalid or deactivated</response>
        [HttpGet]
        public IActionResult Get(string key, string addressNo = "", string displayFormat = "true")
        {
            if (string.IsNullOrEmpty(key)) return BadRequest("Please provide your API key as a parameter"); else if (!_accessControl.Verify(key)) return Unauthorized();

            //work area setup
            //marshall validated inputs into wa1
            Wa1 wa1 = new Wa1
            {
                in_func_code = "1L",
                in_hnd = addressNo ?? string.Empty
            };

            //geocall and finalize responses
            _geo.GeoCall(ref wa1);

            if (string.Equals(displayFormat, "false", StringComparison.OrdinalIgnoreCase))
            {
                GeocallResponse<F1lDisplay, F1lResponse> raw = new GeocallResponse<F1lDisplay, F1lResponse>
                {
                    display = null,
                    root = new F1lResponse(wa1)
                };

                return Ok(raw);
            }
            else
            {
                GeocallResponse<F1lDisplay, F1lResponse> goatlike = new GeocallResponse<F1lDisplay, F1lResponse>
                {
                    display = new F1lDisplay(wa1),
                    root = null
                };

                return Ok(goatlike);
            }
        }
    }
}
