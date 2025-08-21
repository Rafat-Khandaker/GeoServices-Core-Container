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
    public class Function_1NController : Controller
    {
        private Geo _geo;
        private AccessControlList _accessControl;

        public Function_1NController(Geo geo, AccessControlList accessControlList)
        {
            _geo = geo;
            _accessControl = accessControlList.ReadKeyFile(true).Result;
        }

        /// <summary>
        /// Enter a street name to get its normalized name and its B10SC street code
        /// </summary>
        /// <remarks>
        /// <para>
        /// Borough Codes: 
        /// | 1 - MN - MANHATTAN
        /// | 2 - BX - BRONX
        /// | 3 - BK - BROOKLYN
        /// | 4 - QN - QUEENS
        /// | 5 - SI - STATEN ISLAND
        /// | "" (empty string) - default value
        /// </para>
        /// </remarks>
        /// <param name="key">Your geoservice key, apply at https://geoservice.planning.nyc.gov/Register</param>
        /// <param name="borough">Borough of the address or place name input. Borough codes are preferred, but abbreviations and full borough names are accepted. See remarks for acceptable inputs</param>
        /// <param name="streetName">Street name input</param>
        /// <param name="streetNameLength">Normalizes the street names to the specified length as a string. Integers between "4" - "32" are accepted, but note that not all street names may be normalized under a certain length. If a street name has less characters than the provided SNL, then the return string will be right-padded with whitespace to reach the desired length. Defaults to "32"</param>
        /// <param name="streetNameFormat">Normalize the output street name to be in compact format with "C." Defaults to sort format, which can also be explicitly toggled with "S"</param>
        /// <param name="displayFormat">Defaults to "true" for the beautified GOAT-like format. Use "false" for raw format to see the returned work areas</param>
        /// <returns>F1N geocall response</returns>
        /// <response code="200">Your geocall response. May be a hit, warning, or reject based on your input. `root` will be populated for raw format `displayFormat=false`, while `display` will be populated for goat-like format `displayFormat=true`</response>
        /// <response code="400">If required key parameter is missing</response>
        /// <response code="401">If key is invalid or deactivated</response>
        [HttpGet]
        public IActionResult Get(string key, string borough = "", string streetName = "", string streetNameLength = "32", string streetNameFormat = "S", string displayFormat = "true")
        {
            if (string.IsNullOrEmpty(key)) return BadRequest("Please provide your API key as a parameter"); else if (!_accessControl.Verify(key)) return Unauthorized();

            //work area setup & marshall validated inputs into wa1
            Wa1 wa1 = new Wa1
            {
                in_func_code = "1N",

                in_boro1 = ValidationHelper.ValidateBoroInput(borough),
                in_stname1 = streetName?.Replace(" and ", " & ") ?? string.Empty,
                in_snl = streetNameLength ?? string.Empty,
                in_stname_normalization = streetNameFormat ?? string.Empty
            };

            //geocall and finalize responses
            _geo.GeoCall(ref wa1);

            if (string.Equals(displayFormat, "false", StringComparison.OrdinalIgnoreCase))
            {
                GeocallResponse<F1nDisplay, F1nResponse> raw = new GeocallResponse<F1nDisplay, F1nResponse>
                {
                    display = null,
                    root = new F1nResponse(wa1)
                };

                return Ok(raw);
            }
            else
            {
                GeocallResponse<F1nDisplay, F1nResponse> goatlike = new GeocallResponse<F1nDisplay, F1nResponse>
                {
                    display = new F1nDisplay(wa1),
                    root = null
                };

                return Ok(goatlike);
            }
        }
    }
}
