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
    public class Function_DController : Controller
    {
        private Geo _geo;
        private AccessControlList _accessControl;
        private GeoService _geoService;

        public Function_DController(Geo geo, AccessControlList accessControlList, GeoService geoService)
        {
            _geo = geo;
            _accessControl = accessControlList.ReadKeyFile(true).Result;
            _geoService = geoService;
        }

        /// <summary>
        /// Enter a street code (B5SC, B7SC, or B10SC) to get the associated street name and B10SC. If B5SC is entered, the Primary street name is returned, along with its B10SC. If B7SC is entered, the Principal street name is returned, along with its B10SC.
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
        /// <param name="boro">Borough of 1st street code. Borough codes are preferred, but abbreviations and full borough names are accepted. See remarks for acceptable inputs. This may be omitted if prepended to the `b10sc1` parameter</param>
        /// <param name="b10sc1">A 5/7/10 digit street code. The borough code may be prepended to this b10sc</param>
        /// <param name="boro2">Borough of 2nd street code. Borough codes are preferred, but abbreviations and full borough names are accepted. See remarks for acceptable inputs. This may be omitted if not needed, or if prepended to the `b10sc2` parameter</param>
        /// <param name="b10sc2">A 5/7/10 digit street code. The borough code may be prepended to this b10sc</param>
        /// <param name="boro3">Borough of 3rd street code. Borough codes are preferred, but abbreviations and full borough names are accepted. See remarks for acceptable inputs. This may be omitted if not needed, or if prepended to the `b10sc2` parameter</param>
        /// <param name="b10sc3">A 5/7/10 digit street code. The borough code may be prepended to this b10sc</param>
        /// <param name="streetNameLength">Normalizes the street names to the specified length as a string. Integers between "4" - "32" are accepted, but note that not all street names may be normalized under a certain length. If a street name has less characters than the provided SNL, then the return string will be right-padded with whitespace to reach the desired length</param>
        /// <param name="streetNameFormat">Normalize the output street name to be in compact format with "C." Defaults to sort format "S"</param>
        /// <param name="displayFormat">Defaults to "true" for the beautified GOAT-like format. Use "false" for raw format to see the returned work areas</param>
        /// <returns>FD geocall response</returns>
        /// <response code="200">Your geocall response. May be a hit, warning, or reject based on your input. `root` will be populated for raw format `displayFormat=false`, while `display` will be populated for goat-like format `displayFormat=true`</response>
        /// <response code="400">If required key parameter is missing</response>
        /// <response code="401">If key is invalid or deactivated</response>
        [HttpGet]
        public IActionResult Get(
            string key, 
            string boro = "", 
            string b10sc1 = "", 
            string boro2 = "", 
            string b10sc2 = "", 
            string boro3 = "", 
            string b10sc3 = "", 
            string streetNameLength = "32", 
            string streetNameFormat = "S",
            string displayFormat = "true"
        ){
            if (string.IsNullOrEmpty(key)) 
                return BadRequest("Please provide your API key as a parameter"); 
            else if (!_accessControl.Verify(key)) 
                return Unauthorized();

            return Ok(_geoService.FunctionD(
                new FunctionInput { 
                    Key = key,
                    Borough = boro,
                    B10SC1 = b10sc1,
                    Borough2 = boro2,
                    B10SC2 = b10sc2,
                    Borough3 = boro3,
                    B10SC3 = b10sc3,
                    StreetNameLength = streetNameLength,
                    StreetNameFormat = streetNameFormat,
                    DisplayFormat = displayFormat
            }));
        }
    }
}
