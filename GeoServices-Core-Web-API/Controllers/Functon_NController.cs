using GeoServices_Core_Commons.Helper;

using GeoXWrapperTest.Model;
using Microsoft.AspNetCore.Mvc;
using GeoXWrapperTest.Model.Response;
using GeoServices_Core_Commons.Core;

namespace GeoServices_Core_Web_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Functon_NController : Controller
    {
        private AccessControlList _accessControl;
        private GeoService _geoService;

        public Functon_NController(AccessControlList accessControlList, GeoService geoService)
        {
            _accessControl = accessControlList.ReadKeyFile(true).Result;
            _geoService = geoService;
        }

        [HttpGet]
        public IActionResult Get(
            string key, 
            string streetName = "", 
            string streetNameLength = "32", 
            string streetNameFormat = "S", 
            string displayFormat = "true"
        ){
            if (string.IsNullOrEmpty(key)) 
                return BadRequest("Please provide your API key as a parameter"); 
            else if (!_accessControl.Verify(key)) 
                return Unauthorized();

            return Ok(_geoService.FunctionN(
                new FunctionInput {
                    Key = key,
                    StreetName = streetName,
                    StreetNameLength = streetNameLength,
                    StreetNameFormat = streetNameFormat,
                    DisplayFormat = displayFormat
                }));
        }
    }
}
