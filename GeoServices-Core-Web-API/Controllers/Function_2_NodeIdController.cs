using GeoServices_Core_Commons.Helper;
using GeoXWrapperLib;
using GeoXWrapperLib.Model;
using GeoXWrapperTest.Model.Display;
using GeoXWrapperTest.Model;
using Microsoft.AspNetCore.Mvc;
using GeoXWrapperTest.Model.Response;
using GeoServices_Core_Commons.Core;

namespace GeoServices_Core_Web_API.Controllers
{
    public class Function_2_NodeIdController : Controller
    {
        private Geo _geo;
        private AccessControlList _accessControl;
        private GeoService _geoService;

        public Function_2_NodeIdController(Geo geo, AccessControlList accessControlList, GeoService geoService)
        {
            _geo = geo;
            _accessControl = accessControlList.ReadKeyFile(true).Result;
            _geoService = geoService;
        }

        /// <summary>
        /// Enter two street names or a named intersection to get information on the intersection, including the names of any additional streets that are at the intersection. You may enter a node ID for an intersection rather than the street names. Given its exactitude in cases where the node ID is entered, Geoservice will prefer that parameter and disregard any entered borough and street name data. Function 2 also returns the administrative districts within which the intersection is located. If an intersection lies on a boundary of two or more districts of a particular type, only one of those districts is listed. If the streets intersect twice, the user must supply a Compass Direction. In the event that the streets intersect more than twice, Geoservice lists all Node IDs which must be entered into a Function 2Node call
        /// </summary>
        /// <param name="key">Your geoservice key, apply at https://geoservice.planning.nyc.gov/Register</param>
        /// <param name="nodeId">The node ID for an exact intersection. An F2 geocall where streets intersect more than once will return GRC03, and will provide a `NodeList` with acceptable inputs for your F2Node call.</param>
        /// <param name="displayFormat">Defaults to "true" for the beautified GOAT-like format. Use "false" for raw format to see the returned work areas</param>
        /// <returns>F2Node geocall response</returns>
        /// <response code="200">Your geocall response. May be a hit, warning, or reject based on your input. `root` will be populated for raw format `displayFormat=false`, while `display` will be populated for goat-like format `displayFormat=true`</response>
        /// <response code="400">If required key parameter is missing</response>
        /// <response code="401">If key is invalid or deactivated</response>
        [HttpGet]
        public IActionResult Get(
            string key, 
            string nodeId = "", 
            string displayFormat = "true"
         ){
            if (string.IsNullOrEmpty(key)) 
                return BadRequest("Please provide your API key as a parameter");
            else if (!_accessControl.Verify(key)) 
                return Unauthorized();

            return Ok(_geoService.Function2NodeId(
                new FunctionInput { 
                    Key = key, 
                    NodeId = nodeId, 
                    DisplayFormat = displayFormat 
                }));
        }
    }
}
