using GeoServices_Core_Commons.Helper;
using GeoXWrapperLib;
using GeoXWrapperLib.Model;
using GeoXWrapperTest.Model.Display;
using GeoXWrapperTest.Model;
using Microsoft.AspNetCore.Mvc;
using GeoXWrapperTest.Model.Response;
using GeoXWrapperTest.Helper;
using GeoServices_Core_Commons.Core;

namespace GeoServices_Core_Web_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Function_3SController : Controller
    {
        private Geo _geo;
        private AccessControlList _accessControl;
        private GeoService _geoService;

        public Function_3SController(Geo geo, AccessControlList accessControlList, GeoService geoService)
        {
            _geo = geo;
            _accessControl = accessControlList.ReadKeyFile(true).Result;
            _geoService = geoService;
        }

        /// <summary>
        /// Specify a street stretch by entering a street name (the ‘On Street’) and two cross streets. If no cross streets are entered, the stretch is from the beginning of the street to its end. If a cross street intersects the ‘On Street’ exactly twice, you must supply a compass direction to determine which intersection you want selected. GOAT is unable to handle a cross street that intersects the ‘On Street’ more than twice.
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
        /// <param name="borough">Borough of the on street. Borough codes are preferred, but abbreviations and full borough names are accepted. See remarks for acceptable inputs</param>
        /// <param name="onStreet">Street name to be used as the on-street for establishing a segment. May be omitted if `b10sc1` parameter is used in its place</param>
        /// <param name="firstCrossStreet">Street name of the 1st cross street. You may enter a named intersection here. May be omitted if `b10sc2` parameter is used in its place</param>
        /// <param name="compassDir">1st compass flag for use to resolve situations where the on street and 1st cross street intersect more than once. The four cardinal direction characters are accepted - "N", "E", "W", "S"</param>
        /// <param name="secondCrossStreet">Street name of the 2nd cross street. You may enter a named intersection here. May be omitted if `b10sc3` parameter is used in its place</param>
        /// <param name="compassDir2">2nd compass flag for use to resolve situations where the on street and 1st cross street intersect more than once. The four cardinal direction characters are accepted - "N", "E", "W", "S"</param>
        /// <param name="b10sc1">The 10 digit street code that corresponds with the on street</param>
        /// <param name="b10sc2">The 10 digit street code that corresponds with the 1st cross street</param>
        /// <param name="b10sc3">The 10 digit street code that corresponds with the 2nd cross street</param>
        /// <param name="realStreetFlag"></param>
        /// <param name="roadbed">The roadbed request switch. Enter "R" to get roadbed information. Defaults to "" (empty string) for generic street information</param>
        /// <param name="displayFormat">Defaults to "true" for the beautified GOAT-like format. Use "false" for raw format to see the returned work areas</param>
        /// <returns>F3S geocall response</returns>
        /// <response code="200">Your geocall response. May be a hit, warning, or reject based on your input. `root` will be populated for raw format `displayFormat=false`, while `display` will be populated for goat-like format `displayFormat=true`</response>
        /// <response code="400">If required key parameter is missing</response>
        /// <response code="401">If key is invalid or deactivated</response>
        [HttpGet]
        public IActionResult Get(
            string key, 
            string borough = "",
            string onStreet = "", 
            string firstCrossStreet = "", 
            string compassDir = "", 
            string secondCrossStreet = "", 
            string compassDir2 = "", 
            string b10sc1 = "", 
            string b10sc2 = "", 
            string b10sc3 = "", 
            string realStreetFlag = "", 
            string roadbed = "", 
            string displayFormat = "true"
        ){
            if (string.IsNullOrEmpty(key)) 
                return BadRequest("Please provide your API key as a parameter"); 
            else if (!_accessControl.Verify(key)) 
                return Unauthorized();

            return Ok(_geoService.Function3S(
                new FunctionInput{
                    Key = key,
                    Borough = borough,
                    OnStreet = onStreet,
                    FirstCrossStreet = firstCrossStreet,
                    CompassDir = compassDir,
                    SecondCrossStreet = secondCrossStreet,
                    CompassDir2 = compassDir2,
                    B10SC1 = b10sc1,
                    B10SC2 = b10sc2,
                    B10SC3 = b10sc3,
                    RealStreetFlag = realStreetFlag,
                    Roadbed = roadbed,
                    DisplayFormat = displayFormat
            }));

         
        }
    }
}
