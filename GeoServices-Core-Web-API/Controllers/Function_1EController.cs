using GeoServices_Core_Commons.Core;
using GeoServices_Core_Commons.Core.Contract;
using GeoServices_Core_Commons.Helper;
using GeoXWrapperLib.Model;
using GeoXWrapperTest.Helper;
using GeoXWrapperTest.Model;
using GeoXWrapperTest.Model.Display;
using GeoXWrapperTest.Model.Response;
using Microsoft.AspNetCore.Mvc;

namespace GeoServices_Core_Web_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Function_1EController : Controller
    {
        private AccessControlList _accessControl;
        private IGeoService _geoService;
        public Function_1EController(AccessControlList accessControlList, IGeoService geoservice)
        {
            _accessControl = accessControlList.ReadKeyFile(true).Result;
            _geoService = geoservice;
        }

        /// <summary>
        /// Function 1E finds the street segment to which an address number or place name is assigned, returning information for that street segment. In addition to information about the street itself, it includes information on city services and political districts for the side of the street on which the address is located. The coordinates returned are for the interpolated location of the address on the street segment. The coordinates are offset from the centerline to the correct side of the street.
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
        /// <param name="borough">Borough of the address or place name input. Borough codes are preferred, but abbreviations and full borough names are accepted. See remarks for acceptable inputs. This may be omitted if zipcode is used</param>
        /// <param name="zipCode">5 digit zip code. This may be omitted if borough is used</param>
        /// <param name="addressNo">The address number for the input. May be omitted for place names, or if freeform input is being used in streetName</param>
        /// <param name="streetName">The street name or freeform (address number + street name) for the input</param>
        /// <param name="roadbed">The roadbed request switch. Enter "R" to get roadbed information. Defaults to "" (empty string) for generic street information</param>
        /// <param name="browseFlag">Browse flag to be used for normalizing the inputted street name. See remarks for acceptable inputs</param>
        /// <param name="unit">Unit number, ex. the suite or office number, etc</param>
        /// <param name="hns">Enter "true" or "y" to use Sort Format for your `addressNo` parameter. Defaults to normal format</param>
        /// <param name="displayFormat">Defaults to "true" for the beautified GOAT-like format. Use "false" for raw format to see the returned work areas</param>
        /// <returns>F1E geocall response</returns>
        /// <response code="200">Your geocall response. May be a hit, warning, or reject based on your input. `root` will be populated for raw format `displayFormat=false`, while `display` will be populated for goat-like format `displayFormat=true`</response>
        /// <response code="400">If required key parameter is missing</response>
        /// <response code="401">If key is invalid or deactivated</response>
        [HttpGet]
        public IActionResult Get(
            string key, 
            string borough = "", 
            string zipCode = "",
            string addressNo = "", 
            string streetName = "", 
            string roadbed = "", 
            string browseFlag = "", 
            string unit = "", 
            string hns = "n",
            string displayFormat = "true"
        ){
            if (string.IsNullOrEmpty(key)) 
                return BadRequest("Please provide your API key as a parameter"); 
            else if (!_accessControl.Verify(key))
                return Unauthorized();

            return Ok(_geoService.Function1E(
                new FunctionInput { 
                    Key = key,
                    Borough = borough,
                    ZipCode = zipCode,
                    AddressNo = addressNo,
                    StreetName = streetName,
                    Roadbed = roadbed,
                    BrowseFlag = browseFlag,
                    Unit = unit,
                    Hns = hns,
                    DisplayFormat = displayFormat
            }));
        }
    }
}
