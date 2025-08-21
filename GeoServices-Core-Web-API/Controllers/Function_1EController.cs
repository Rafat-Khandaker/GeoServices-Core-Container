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
    public class Function_1EController : Controller
    {
        private Geo _geo;
        private AccessControlList _accessControl;

        public Function_1EController(Geo geo, AccessControlList accessControlList)
        {
            _geo = geo;
            _accessControl = accessControlList.ReadKeyFile(true).Result;
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
        public IActionResult Get(string key, string borough = "", string zipCode = "", string addressNo = "", string streetName = "", string roadbed = "", string browseFlag = "", string unit = "", string hns = "n",
            string displayFormat = "true")
        {
            if (string.IsNullOrEmpty(key)) return BadRequest("Please provide your API key as a parameter"); else if (!_accessControl.Verify(key)) return Unauthorized();

            //work area setup & marshall validated inputs into wa1
            Wa1 wa1 = new Wa1()
            {
                in_func_code = "1E",
                in_platform_ind = "C",
                in_mode_switch = "X",

                in_b10sc1 = new B10sc { boro = ValidationHelper.ValidateBoroInput(borough) },
                in_zip_code = zipCode ?? string.Empty,
                in_stname1 = streetName?.Replace(" and ", " & ") ?? string.Empty,
                in_unit = unit?.Trim() ?? string.Empty,
                in_browse_flag = browseFlag ?? string.Empty,
                in_roadbed_request_switch = roadbed ?? string.Empty
            };
            Wa2F1ex wa2f1ex = new Wa2F1ex();

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

            //geocall and finalize
            _geo.GeoCall(ref wa1, ref wa2f1ex);

            if (string.Equals(displayFormat, "false", StringComparison.OrdinalIgnoreCase))
            {
                GeocallResponse<F1eDisplay, F1eResponse> raw = new GeocallResponse<F1eDisplay, F1eResponse>
                {
                    display = null,
                    root = new F1eResponse(wa1, wa2f1ex)
                };

                return Ok(raw);
            }
            else
            {
                GeocallResponse<F1eDisplay, F1eResponse> goatlike = new GeocallResponse<F1eDisplay, F1eResponse>
                {
                    display = new F1eDisplay(wa1, wa2f1ex, _geo),
                    root = null
                };

                return Ok(goatlike);
            }
        }
    }
}
