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
    public class Function_BINController : Controller
    {
        private Geo _geo;
        private AccessControlList _accessControl;

        public Function_BINController(Geo geo, AccessControlList accessControlList)
        {
            _geo = geo;
            _accessControl = accessControlList.ReadKeyFile(true).Result;
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
        public IActionResult Get(string key, string bin = "", string tpad = "", string displayFormat = "true")
        {
            if (string.IsNullOrEmpty(key)) return BadRequest("Please provide your API key as a parameter"); else if (!_accessControl.Verify(key)) return Unauthorized();

            //work area setup
            Wa1 wa1 = new Wa1
            {
                in_mode_switch = "X",
                in_func_code = "BN",
                in_platform_ind = "C",

                in_tpad_switch = tpad ?? string.Empty
            };
            Wa2F1ax wa2f1ax = new Wa2F1ax();

            //marshall validated inputs into wa1
            string binTrimmed = bin?.Trim() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(binTrimmed))
            {
                wa1.in_bin.boro = string.Empty;
                wa1.in_bin.binnum = string.Empty;
            }
            else if (binTrimmed.Length == 7)
            {
                wa1.in_bin.BINFromString(binTrimmed);
            }
            else
            {
                wa1.in_bin.boro = binTrimmed.Substring(0, 1);
                wa1.in_bin.binnum = binTrimmed.Substring(1);
            }

            //geocall and finalize responses
            _geo.GeoCall(ref wa1, ref wa2f1ax);

            if (string.Equals(displayFormat, "false", StringComparison.OrdinalIgnoreCase))
            {
                GeocallResponse<FBNDisplay, FBNResponse> raw = new GeocallResponse<FBNDisplay, FBNResponse>
                {
                    display = null,
                    root = new FBNResponse(wa1, wa2f1ax)
                };

                return Ok(raw);
            }
            else
            {
                GeocallResponse<FBNDisplay, FBNResponse> goatlike = new GeocallResponse<FBNDisplay, FBNResponse>
                {
                    display = new FBNDisplay(wa1, wa2f1ax, _geo)
                    {
                        AddressRangeList = ValidationHelper.CreateAddressRangeList(wa2f1ax.addr_x_list, wa1.in_tpad_switch)
                    },
                    root = null
                };

                return Ok(goatlike);
            }
        }
    }
}
