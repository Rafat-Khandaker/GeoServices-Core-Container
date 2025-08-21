using GeoServices_Core_Commons.Helper;
using GeoXWrapperLib;
using GeoXWrapperLib.Model;
using GeoXWrapperTest.Model.Display;
using GeoXWrapperTest.Model;
using Microsoft.AspNetCore.Mvc;
using GeoXWrapperTest.Helper;
using GeoXWrapperTest.Model.Response;

namespace GeoServices_Core_Web_API.Controllers
{
    public class Function_5Controller : Controller
    {
        private Geo _geo;
        private AccessControlList _accessControl;

        public Function_5Controller(Geo geo, AccessControlList accessControlList)
        {
            _geo = geo;
            _accessControl = accessControlList.ReadKeyFile(true).Result;
        }

        /// <summary>
        /// Retrieve a low and high GRID key
        /// </summary>
        /// <param name="key">Your geoservice key, apply at https://geoservice.planning.nyc.gov/Register</param>
        /// <param name="borough">Borough of the address or place name input. Borough codes are preferred, but abbreviations and full borough names are accepted. See remarks for acceptable inputs</param>
        /// <param name="lowAddressNo">Lower bound of the address number to search for</param>
        /// <param name="highAddressNo">Upper bound of the address number to search for</param>
        /// <param name="streetName">Street name to read the GRID keys for</param>
        /// <param name="stCode"></param>
        /// <param name="displayFormat">Defaults to "true" for the beautified GOAT-like format. Use "false" for raw format to see the returned work areas</param>
        /// <returns>F5 geocall response</returns>
        /// <response code="200">Your geocall response. May be a hit, warning, or reject based on your input. `root` will be populated for raw format `displayFormat=false`, while `display` will be populated for goat-like format `displayFormat=true`</response>
        /// <response code="400">If required key parameter is missing</response>
        /// <response code="401">If key is invalid or deactivated</response>
        [HttpGet]
        public IActionResult Get(string key, string borough = "", string lowAddressNo = "", string highAddressNo = "", string streetName = "", string stCode = "", string displayFormat = "true")
        {
            if (string.IsNullOrEmpty(key)) return BadRequest("Please provide your API key as a parameter"); else if (!_accessControl.Verify(key)) return Unauthorized();

            //work area setup & marshall validated inputs into wa1
            Wa1 wa1 = new Wa1
            {
                in_func_code = "5",
                in_platform_ind = "C",

                in_hnd = highAddressNo ?? string.Empty,
                in_low_hnd = lowAddressNo ?? string.Empty
            };
            Wa2F5 wa2f5 = new Wa2F5();

            if (string.IsNullOrWhiteSpace(stCode))
            {
                wa1.in_b10sc1.Clear();
                wa1.in_boro1 = ValidationHelper.ValidateBoroInput(borough);
                wa1.in_stname1 = streetName?.Replace(" and ", " & ") ?? string.Empty;
            }
            else
            {
                wa1.in_b10sc1.Clear();
                wa1.in_b10sc1.B10scFromString(stCode);
                wa1.in_stname1 = string.Empty;
            }

            //geocall and finalize responses
            _geo.GeoCall(ref wa1, ref wa2f5);

            if (string.Equals(displayFormat, "false", StringComparison.OrdinalIgnoreCase))
            {
                GeocallResponse<F5Display, F5Response> raw = new GeocallResponse<F5Display, F5Response>
                {
                    display = null,
                    root = new F5Response(wa1, wa2f5)
                };

                return Ok(raw);
            }
            else
            {
                GeocallResponse<F5Display, F5Response> goatlike = new GeocallResponse<F5Display, F5Response>
                {
                    display = new F5Display(wa1, wa2f5),
                    root = null
                };

                return Ok(goatlike);
            }
        }
    }
}
