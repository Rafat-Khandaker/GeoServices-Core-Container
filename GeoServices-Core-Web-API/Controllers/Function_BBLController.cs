using GeoServices_Core_Commons.Core;
using GeoServices_Core_Commons.Core.Contract;
using GeoServices_Core_Commons.Helper;
using GeoXWrapperTest.Helper;
using GeoXWrapperTest.Model;
using GeoXWrapperTest.Model.Display;
using GeoXWrapperTest.Model.Response;
using Microsoft.AspNetCore.Mvc;

namespace GeoServices_Core_Web_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Function_BBLController : Controller
    {
        private AccessControlList _accessControl;
        private IGeoService _geoService;

        public Function_BBLController( AccessControlList accessControlList, IGeoService geoService)
        {
            _accessControl = accessControlList.ReadKeyFile(true).Result;
            _geoService = geoService;
        }

        /// <summary>
        /// Enter a block and lot number to get tax lot and building information. Function BL also returns a list of up to twenty-one addresses that apply to the tax lot and a list of Building Identification Numbers (BINs) for buildings on the tax lot.
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
        /// <param name="block">Block number. This will internally be left padded with zeroes until it hits a length of 5</param>
        /// <param name="lot">Lot number. This will internally be left padded with zeroes until it hits a length of 4</param>
        /// <param name="bbl">10 digit complete BBL number, which is borough code + block number (left zero padded to a length of 5) + lot number (left zero padded to a length of 4)</param>
        /// <param name="tpad">Enter "true" or "y" to read from the TPAD file. Defaults to "" (empty string) which will not execute the read</param>
        /// <param name="displayFormat">Defaults to "true" for the beautified GOAT-like format. Use "false" for raw format to see the returned work areas</param>
        /// <returns>FBL geocall response</returns>
        /// <response code="200">Your geocall response. May be a hit, warning, or reject based on your input. `root` will be populated for raw format `displayFormat=false`, while `display` will be populated for goat-like format `displayFormat=true`</response>
        /// <response code="400">If required key parameter is missing</response>
        /// <response code="401">If key is invalid or deactivated</response>
        [HttpGet]
        public IActionResult Get(
            string key, 
            string borough = "", 
            string block = "", 
            string lot = "", 
            string bbl = "", 
            string tpad = "", 
            string displayFormat = "true"
        ){
            if (string.IsNullOrEmpty(key)) 
                return BadRequest("Please provide your API key as a parameter"); 
            else if (!_accessControl.Verify(key)) 
                return Unauthorized();

            return Ok(_geoService.FunctionBBL(
                new FunctionInput { 
                    Key = key,
                    Borough = borough,
                    Block = block,
                    Lot = lot,
                    BBL = bbl,
                    TPad = tpad,
                    DisplayFormat = displayFormat
            }));
        }
    }
}
