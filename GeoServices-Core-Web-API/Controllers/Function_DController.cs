using GeoServices_Core_Commons.Helper;
using GeoXWrapperLib;
using GeoXWrapperLib.Model;
using GeoXWrapperTest.Model.Display;
using GeoXWrapperTest.Model;
using Microsoft.AspNetCore.Mvc;
using GeoXWrapperTest.Model.Response;

namespace GeoServices_Core_Web_API.Controllers
{
    public class Function_DController : Controller
    {
        private Geo _geo;
        private AccessControlList _accessControl;

        public Function_DController(Geo geo, AccessControlList accessControlList)
        {
            _geo = geo;
            _accessControl = accessControlList.ReadKeyFile(true).Result;
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
        public IActionResult Get(string key, string boro = "", string b10sc1 = "", string boro2 = "", string b10sc2 = "", string boro3 = "", string b10sc3 = "", string streetNameLength = "32", string streetNameFormat = "S",
            string displayFormat = "true")
        {
            if (string.IsNullOrEmpty(key)) return BadRequest("Please provide your API key as a parameter"); else if (!_accessControl.Verify(key)) return Unauthorized();

            //work area setup
            Wa1 wa1 = new Wa1()
            {
                in_platform_ind = "C",

                in_snl = streetNameLength ?? string.Empty,
                in_stname_normalization = streetNameFormat ?? string.Empty
            };

            //Func code validation
            //Note: only checking first b10sc as they should be the same length. If not, geo will return an error anyway
            if (!string.IsNullOrWhiteSpace(b10sc1))
            {
                int length = string.IsNullOrWhiteSpace(boro)
                    ? b10sc1.Trim().Length
                    : b10sc1.Trim().Length + 1; //if boro is present, it contributes one character to the string length

                if (length < 7)
                    wa1.in_func_code = "D";
                else if (length > 6 && length < 9)
                    wa1.in_func_code = "DG";
                else if (length > 8)
                    wa1.in_func_code = "DN";
            }

            //marshall validated inputs into wa1
            if (string.IsNullOrWhiteSpace(boro))
                wa1.in_b10sc1.B10scFromString(b10sc1.Trim());
            else
                wa1.in_b10sc1.B10scFromString(boro + b10sc1.Trim());

            if (string.IsNullOrWhiteSpace(boro2))
                wa1.in_b10sc2.B10scFromString(b10sc2.Trim());
            else
                wa1.in_b10sc2.B10scFromString(boro2 + b10sc2.Trim());

            if (string.IsNullOrWhiteSpace(boro3))
                wa1.in_b10sc3.B10scFromString(b10sc3.Trim());
            else
                wa1.in_b10sc3.B10scFromString(boro3 + b10sc3.Trim());

            //geocall and finalize responses
            _geo.GeoCall(ref wa1);

            if (string.Equals(displayFormat, "false", StringComparison.OrdinalIgnoreCase))
            {
                GeocallResponse<FDDisplay, FDResponse> raw = new GeocallResponse<FDDisplay, FDResponse>
                {
                    display = null,
                    root = new FDResponse(wa1)
                };

                return Ok(raw);
            }
            else
            {
                GeocallResponse<FDDisplay, FDResponse> goatlike = new GeocallResponse<FDDisplay, FDResponse>
                {
                    display = new FDDisplay(wa1),
                    root = null
                };

                return Ok(goatlike);
            }
        }
    }
}
