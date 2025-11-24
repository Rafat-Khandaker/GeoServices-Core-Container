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
    public class Function_BINController : Controller
    {
        private Geo _geo;
        private AccessControlList _accessControl;
        private GeoService _geoService;

        public Function_BINController(Geo geo, AccessControlList accessControlList, GeoService geoService)
        {
            _geo = geo;
            _accessControl = accessControlList.ReadKeyFile(true).Result;
            _geoService = geoService;
        }

        /// <summary>
        /// Enter a Building Identification Number (BIN) to get tax lot and building information. Function BN also returns a list of addresses that apply to the BIN.
        /// </summary>
        /// <param name="key">Your geoservice key, apply at https://geoservice.planning.nyc.gov/Register</param>
        /// <param name="bin">7 digit building identification number</param>
        /// <param name="tpad">Enter "true" or "y" to read from the TPAD file. Defaults to "" (empty string) which will not execute the read</param>
        /// <param name="displayFormat">Defaults to "true" for the beautified GOAT-like format. Use "false" for raw format to see the returned work areas</param>
        /// <returns>FBN geocall response</returns>
        /// <response code="200">Your geocall response. May be a hit, warning, or reject based on your input. `root` will be populated for raw format `displayFormat=false`, while `display` will be populated for goat-like format `displayFormat=true`</response>
        /// <response code="400">If required key parameter is missing</response>
        /// <response code="401">If key is invalid or deactivated</response>
        [HttpGet]
        public IActionResult Get(
            string key, 
            string bin = "", 
            string tpad = "", 
            string displayFormat = "true"
        ){
            if (string.IsNullOrEmpty(key)) 
                return BadRequest("Please provide your API key as a parameter"); 
            else if (!_accessControl.Verify(key)) 
                return Unauthorized();

            return Ok(_geoService.FunctionBIN(
                new FunctionInput { 
                    Key = key,
                    Bin = bin,
                    TPad = tpad,
                    DisplayFormat = displayFormat
            }));
        }
    }
}
