using GeoServices_Core_Commons.Helper;
using GeoXWrapperLib;
using GeoXWrapperLib.Model;
using GeoXWrapperTest.Model.Display;
using GeoXWrapperTest.Model;
using Microsoft.AspNetCore.Mvc;
using GeoXWrapperTest.Model.Response;
using GeoXWrapperTest.Helper;

namespace GeoServices_Core_Web_API.Controllers
{
    public class Function_APController : Controller
    {
        private Geo _geo;
        private AccessControlList _accessControl;

        public Function_APController(Geo geo, AccessControlList accessControlList)
        {
            _geo = geo;
            _accessControl = accessControlList.ReadKeyFile(true).Result;
        }

        /// <summary>
        /// Function AP finds the address point for a given address. Address points are point locations located approximately five feet inside the building along the corresponding street frontage. Address points do not exist for all administrative address ranges assigned to a building, but usually only reflect the posted address. For example, functions 1A, BL, and BN will return results for any address in the range 14 – 32 Reade Street, but function AP only recognizes the posted address of 22 Reade Street. Function AP returns the address point’s coordinates and identifier, as well as information on the tax lot and building associated with the address point.
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
        /// <param name="borough">Borough of the address or place name input. Borough codes are preferred, but abbreviations and full borough names are accepted. See remarks for acceptable inputs. This may be omitted if zipcode is used</param>
        /// <param name="zipCode">5 digit zip code. This may be omitted if borough is used</param>
        /// <param name="addressNo">The address number for the input. May be omitted for place names, or if freeform input is being used in streetName</param>
        /// <param name="streetName">The street name or freeform (address number + street name) for the input</param>
        /// <param name="unit">Unit number, ex. the suite or office number, etc</param>
        /// <param name="hns">Enter "true" or "y" to use Sort Format for your `addressNo` parameter. Defaults to normal format</param>
        /// <param name="displayFormat">Defaults to "true" for the beautified GOAT-like format. Use "false" for raw format to see the returned work areas</param>
        /// <returns>FAP geocal response</returns>
        /// <response code="200">Your geocall response. May be a hit, warning, or reject based on your input. `root` will be populated for raw format `displayFormat=false`, while `display` will be populated for goat-like format `displayFormat=true`</response>
        /// <response code="400">If required key parameter is missing</response>
        /// <response code="401">If key is invalid or deactivated</response>
        [HttpGet]
        public IActionResult Get(string key, string borough = "", string zipCode = "", string addressNo = "", string streetName = "", string unit = "", string hns = "", string displayFormat = "true")
        {
            if (string.IsNullOrEmpty(key)) return BadRequest("Please provide your API key as a parameter"); else if (!_accessControl.Verify(key)) return Unauthorized();

            //work area setup & marshall validated inputs into wa1
            Wa1 wa1 = new Wa1()
            {
                in_func_code = "AP",
                in_platform_ind = "C",
                in_mode_switch = "X",

                in_b10sc1 = new B10sc { boro = ValidationHelper.ValidateBoroInput(borough) },
                in_zip_code = zipCode ?? string.Empty,
                in_stname1 = streetName?.Replace(" and ", " & ") ?? string.Empty,
                in_unit = unit ?? string.Empty
            };
            Wa2Fapx wa2fapx = new Wa2Fapx();

            if (string.Equals(hns, "true", StringComparison.OrdinalIgnoreCase) || string.Equals(hns, "y", StringComparison.OrdinalIgnoreCase))
            {
                wa1.in_hnd = string.Empty;
                wa1.in_hns = addressNo ?? string.Empty;
            }
            else
            {
                wa1.in_hnd = addressNo ?? string.Empty;
                wa1.in_hns = string.Empty;
            }

            //geocall and finalize response
            _geo.GeoCall(ref wa1, ref wa2fapx);

            if (string.Equals(displayFormat, "false", StringComparison.OrdinalIgnoreCase))
            {
                GeocallResponse<FapDisplay, FapResponse> raw = new GeocallResponse<FapDisplay, FapResponse>
                {
                    display = null,
                    root = new FapResponse(wa1, wa2fapx)
                };

                return Ok(raw);
            }
            else
            {
                GeocallResponse<FapDisplay, FapResponse> goatlike = new GeocallResponse<FapDisplay, FapResponse>
                {
                    display = new FapDisplay(wa1, wa2fapx),
                    root = null
                };

                return Ok(goatlike);
            }
        }
    }
}
