using GeoServices_Core_Commons.Helper;
using GeoXWrapperLib;

using GeoXWrapperTest.Model;
using Microsoft.AspNetCore.Mvc;

using GeoServices_Core_Commons.Core;

namespace GeoServices_Core_Web_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Function_3Controller : Controller
    {
        private Geo _geo;
        private AccessControlList _accessControl;
        private GeoService _geoService;

        public Function_3Controller(Geo geo, AccessControlList accessControlList, GeoService geoService)
        {
            _geo = geo;
            _accessControl = accessControlList.ReadKeyFile(true).Result;
            _geoService = geoService;
        }

        /// <summary>
        /// Specify a street segment by entering a street name (the “On Street”) and the two consecutive cross streets that define the segment. If you are only interested in information for one side of the street segment (a single Block Face), select the Side of Street from the dropdown list on the right side of the screen. The information returned includes information about the street segment, administrative districts for the left and/or right side of the segment, and the names of any additional cross streets that exist at the two endpoints of the segment.
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
        /// <param name="borough1">Borough of the on street. Borough codes are preferred, but abbreviations and full borough names are accepted. See remarks for acceptable inputs</param>
        /// <param name="onStreet">Street name to be used as the on-street for establishing a segment</param>
        /// <param name="sideOfStreet">Compass flag to choose the side of street/block face to get data for. Use of this parameter will convert your geocall to Function 3C. The four cardinal direction characters are accepted - "N", "E", "W", "S"</param>
        /// <param name="borough2">Borough of the 1st cross street. Borough codes are preferred, but abbreviations and full borough names are accepted. See remarks for acceptable inputs</param>
        /// <param name="firstCrossStreet">Street name of the 1st cross street. You may enter a named intersection here</param>
        /// <param name="borough3">Borough of the 2nd cross street. Borough codes are preferred, but abbreviations and full borough names are accepted. See remarks for acceptable inputs</param>
        /// <param name="secondCrossStreet">Street name of the 2nd cross street. You may enter a named intersection here</param>
        /// <param name="browseFlag">Browse flag to be used for normalizing the inputted street name. See remarks for acceptable inputs</param>
        /// <param name="displayFormat">Defaults to "true" for the beautified GOAT-like format. Use "false" for raw format to see the returned work areas</param>
        /// <returns>F3 geocall response</returns>
        /// <response code="200">Your geocall response. May be a hit, warning, or reject based on your input. `root` will be populated for raw format `displayFormat=false`, while `display` will be populated for goat-like format `displayFormat=true`</response>
        /// <response code="400">If required key parameter is missing</response>
        /// <response code="401">If key is invalid or deactivated</response>
        [HttpGet]
        public IActionResult Get(
            string key, 
            string borough1 = "", 
            string onStreet = "", 
            string sideOfStreet = "", 
            string borough2 = "", 
            string firstCrossStreet = "", 
            string borough3 = "", 
            string secondCrossStreet = "", 
            string browseFlag = "", 
            string displayFormat = "true"
        ){
            if (string.IsNullOrEmpty(key)) 
                return BadRequest("Please provide your API key as a parameter"); 
            else if (!_accessControl.Verify(key)) 
                return Unauthorized();

            return !string.IsNullOrWhiteSpace(sideOfStreet ?? string.Empty) ?
                     Ok(_geoService.Function3_F3C(
                            new FunctionInput { 
                                Key = key,
                                Borough1 = borough1,
                                OnStreet = onStreet,
                                SideOfStreet = sideOfStreet,
                                Borough2 = borough2,
                                FirstCrossStreet = firstCrossStreet,
                                Borough3 = borough3,
                                SecondCrossStreet = secondCrossStreet,
                                BrowseFlag = browseFlag,
                                DisplayFormat = displayFormat
                            }
                         )) : Ok(_geoService.Function3_F3(
                                new FunctionInput {
                                    Key = key,
                                    Borough1 = borough1,
                                    OnStreet = onStreet,
                                    SideOfStreet = sideOfStreet,
                                    Borough2 = borough2,
                                    FirstCrossStreet = firstCrossStreet,
                                    Borough3 = borough3,
                                    SecondCrossStreet = secondCrossStreet,
                                    BrowseFlag = browseFlag,
                                    DisplayFormat = displayFormat
                                }));
        }
    }
}
