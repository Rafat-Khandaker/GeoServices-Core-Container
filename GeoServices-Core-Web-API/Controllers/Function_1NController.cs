using GeoServices_Core_Commons.Helper;
using GeoXWrapperLib;
using GeoXWrapperLib.Model;
using GeoXWrapperTest.Model.Display;
using GeoXWrapperTest.Model;
using Microsoft.AspNetCore.Mvc;
using GeoXWrapperTest.Helper;
using GeoXWrapperTest.Model.Response;
using GeoServices_Core_Commons.Core;

namespace GeoServices_Core_Web_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Function_1NController : Controller
    {
        private AccessControlList _accessControl;
        private GeoService _geoService;

        public Function_1NController(AccessControlList accessControlList, GeoService geoservice)
        {
            _accessControl = accessControlList.ReadKeyFile(true).Result;
            _geoService = geoservice;
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
        public IActionResult Get(
            string key, 
            string borough = "", 
            string streetName = "", 
            string streetNameLength = "32",
            string streetNameFormat = "S", 
            string displayFormat = "true"
        ){
            if (string.IsNullOrEmpty(key)) 
                return BadRequest("Please provide your API key as a parameter"); 
            else if (!_accessControl.Verify(key)) 
                return Unauthorized();

            return Ok(_geoService.Function1N(
                new FunctionInput {
                    Key = key,
                    Borough = borough,
                    StreetName = streetName,
                    StreetNameLength = streetNameLength,
                    StreetNameFormat = streetNameFormat,
                    DisplayFormat = displayFormat
            }));           
        }
    }
}
