using GeoXWrapperLib.Model;
using GeoXWrapperLib;
using GeoXWrapperTest.Model.Display;
using GeoXWrapperTest.Model;
using Microsoft.AspNetCore.Mvc;
using GeoXWrapperTest.Model.Response;
using GeoXWrapperTest.Helper;
using GeoServices_Core_Commons.Helper;
using GeoServices_Core_Commons.Core;

namespace GeoServices_Core_Web_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Function_2Controller : Controller
    {
        private AccessControlList _accessControl;
        private GeoService _geoService;

        public Function_2Controller(AccessControlList accessControlList, GeoService geoService)
        {
            _accessControl = accessControlList.ReadKeyFile(true).Result;
            _geoService = geoService;
        }

        /// <summary>
        /// Enter two street names or a named intersection to get information on the intersection, including the names of any additional streets that are at the intersection. You may enter a node ID for an intersection rather than the street names. Given its exactitude in cases where the node ID is entered, Geoservice will prefer that parameter and disregard any entered borough and street name data. Function 2 also returns the administrative districts within which the intersection is located. If an intersection lies on a boundary of two or more districts of a particular type, only one of those districts is listed. If the streets intersect twice, the user must supply a Compass Direction. In the event that the streets intersect more than twice, Geoservice lists all Node IDs which must be entered into a Function 2Node call
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
        /// <para>
        /// Browse Flags: 
        /// | "P" - Primary street Name
        /// | "F" - Principal street name
        /// | "R" - BOE preferred street name
        /// | "" (empty string) - default value, does not swap the output name with its known variant, only normalizes it
        /// </para>
        /// </remarks>
        /// <param name="key">Your geoservice key, apply at https://geoservice.planning.nyc.gov/Register</param>
        /// <param name="borough1">Borough of the 1st cross street. Borough codes are preferred, but abbreviations and full borough names are accepted. See remarks for acceptable inputs</param>
        /// <param name="street1">Street name of the 1st cross street. Enter a named intersection here, and then you may leave the `street2` parameter blank</param>
        /// <param name="borough2">Borough of the 2nd cross street. Borough codes are preferred, but abbreviations and full borough names are accepted. See remarks for acceptable inputs</param>
        /// <param name="street2">Street name of the 2nd cross street. When using a named intersection, you may leave this param blank</param>
        /// <param name="browseFlag">Browse flag to be used for normalizing the inputted street name. See remarks for acceptable inputs</param>
        /// <param name="compassFlag">Compass flag to choose the side of street to get data for. The four cardinal direction characters are accepted - "N", "E", "W", "S"</param>
        /// <param name="displayFormat">Defaults to "true" for the beautified GOAT-like format. Use "false" for raw format to see the returned work areas</param>
        /// <returns>F2 geocall response</returns>
        /// <response code="200">Your geocall response. May be a hit, warning, or reject based on your input. `root` will be populated for raw format `displayFormat=false`, while `display` will be populated for goat-like format `displayFormat=true`</response>
        /// <response code="400">If required key parameter is missing</response>
        /// <response code="401">If key is invalid or deactivated</response>
        [HttpGet]
        public IActionResult Get(
            string key, 
            string borough1 = "", 
            string street1 = "", 
            string borough2 = "", 
            string street2 = "", 
            string browseFlag = "", 
            string compassFlag = "", 
            string displayFormat = "true"
        ){
            if (string.IsNullOrEmpty(key)) 
                return BadRequest("Please provide your API key as a parameter"); 
            else if (!_accessControl.Verify(key)) 
                return Unauthorized();
            
            return Ok(_geoService.Function2(
                new FunctionInput { 
                    Key = key,
                    Borough1 = borough1,
                    Street1 = street1,
                    Borough2 = borough2,
                    Street2 = street2,
                    BrowseFlag = browseFlag,
                    CompassFlag = compassFlag,
                    DisplayFormat = displayFormat
            }));
        }
    }
}
