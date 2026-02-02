using GeoServices_Core_Commons.Core;
using GeoServices_Core_Commons.Core.Contract;
using GeoServices_Core_Commons.Helper;
using GeoXWrapperTest.Model;
using GeoXWrapperTest.Model.Response;
using Microsoft.AspNetCore.Mvc;

namespace GeoServices_Core_Web_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Function_NController : Controller
    {
        private AccessControlList _accessControl;
        private IGeoService _geoService;

        public Function_NController(AccessControlList accessControlList, IGeoService geoService)
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
