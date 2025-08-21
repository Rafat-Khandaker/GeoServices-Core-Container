using GeoServices_Core_Commons.Helper;
using GeoXWrapperLib;
using GeoXWrapperLib.Model;
using GeoXWrapperTest.Model.Display;
using GeoXWrapperTest.Model;
using Microsoft.AspNetCore.Mvc;
using GeoXWrapperTest.Model.Response;

namespace GeoServices_Core_Web_API.Controllers
{
    public class Function_2_NodeIdController : Controller
    {
        private Geo _geo;
        private AccessControlList _accessControl;

        public Function_2_NodeIdController(Geo geo, AccessControlList accessControlList)
        {
            _geo = geo;
            _accessControl = accessControlList.ReadKeyFile(true).Result;
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
        public IActionResult Get(string key, string nodeId = "", string displayFormat = "true")
        {
            if (string.IsNullOrEmpty(key)) return BadRequest("Please provide your API key as a parameter"); else if (!_accessControl.Verify(key)) return Unauthorized();

            //work area setup & marshall validated inputs into wa1
            Wa1 wa1 = new Wa1
            {
                in_func_code = "2W",
                in_platform_ind = "C",
                in_xstreet_names_flag = "E",

                in_node = nodeId ?? string.Empty
            };
            Wa2F2w wa2f2w = new Wa2F2w();

            //execute geocall and finalize response
            _geo.GeoCall(ref wa1, ref wa2f2w);

            if (string.Equals(displayFormat, "false", StringComparison.OrdinalIgnoreCase))
            {
                GeocallResponse<F2Display, F2Response> raw = new GeocallResponse<F2Display, F2Response>
                {
                    display = null,
                    root = new F2Response(wa1, wa2f2w)
                };

                return Ok(raw);
            }
            else
            {
                //there will be no data lists aside from the similar names list -> all of them deal with GRC03 exclusively, and there is no GRC03 for a F2Node
                GeocallResponse<F2Display, F2Response> goatlike = new GeocallResponse<F2Display, F2Response>
                {
                    display = new F2Display(wa1, wa2f2w, _geo),
                    root = null
                };

                return Ok(goatlike);
            }
        }
    }
}
