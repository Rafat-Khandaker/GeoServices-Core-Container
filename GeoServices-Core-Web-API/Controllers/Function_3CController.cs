using GeoServices_Core_Commons.Helper;
using GeoXWrapperLib;
using GeoXWrapperLib.Model;
using GeoXWrapperTest.Model.Display;
using GeoXWrapperTest.Model;
using Microsoft.AspNetCore.Mvc;
using GeoXWrapperTest.Helper;
using GeoXWrapperTest.Model.Response;

namespace GeoServices_Core_Web_API.Controllers
{
    public class Function_3CController : Controller
    {
        private Geo _geo;
        private AccessControlList _accessControl;

        public Function_3CController(Geo geo, AccessControlList accessControlList)
        {
            _geo = geo;
            _accessControl = accessControlList.ReadKeyFile(true).Result;
        }

        /// <summary>
        /// Specify a street segment by entering a street name (the “On Street”) and the two consecutive cross streets that define the segment. If you are only interested in information for one side of the street segment (a single Block Face), select the Side of Street from the dropdown list on the right side of the screen. The information returned includes information about the street segment, administrative districts for the left and/or right side of the segment, and the names of any additional cross streets that exist at the two endpoints of the segment.
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
        /// <param name="borough1">Borough of the on street. Borough codes are preferred, but abbreviations and full borough names are accepted. See remarks for acceptable inputs</param>
        /// <param name="onStreet">Street name to be used as the on-street for establishing a segment</param>
        /// <param name="sideOfStreet">Compass flag to choose the side of street/block face to get data for. This parameter is required to get a hit on F3C. The four cardinal direction characters are accepted - "N", "E", "W", "S"</param>
        /// <param name="borough2">Borough of the 1st cross street. Borough codes are preferred, but abbreviations and full borough names are accepted. See remarks for acceptable inputs</param>
        /// <param name="firstCrossStreet">Street name of the 1st cross street. You may enter a named intersection here</param>
        /// <param name="borough3">Borough of the 2nd cross street. Borough codes are preferred, but abbreviations and full borough names are accepted. See remarks for acceptable inputs</param>
        /// <param name="secondCrossStreet">Street name of the 2nd cross street. You may enter a named intersection here</param>
        /// <param name="browseFlag">Browse flag to be used for normalizing the inputted street name. See remarks for acceptable inputs</param>
        /// <param name="displayFormat">Defaults to "true" for the beautified GOAT-like format. Use "false" for raw format to see the returned work areas</param>
        /// <returns>F3C geocall response</returns>
        /// <response code="200">Your geocall response. May be a hit, warning, or reject based on your input. `root` will be populated for raw format `displayFormat=false`, while `display` will be populated for goat-like format `displayFormat=true`</response>
        /// <response code="400">If required key parameter is missing</response>
        /// <response code="401">If key is invalid or deactivated</response>
        [HttpGet]
        public IActionResult Get(string key, string borough1 = "", string onStreet = "", string sideOfStreet = "", string borough2 = "", string firstCrossStreet = "", string borough3 = "",
            string secondCrossStreet = "", string browseFlag = "", string displayFormat = "true")
        {
            if (string.IsNullOrEmpty(key)) return BadRequest("Please provide your API key as a parameter"); else if (!_accessControl.Verify(key)) return Unauthorized();

            //work area setup & marshall validated inputs into wa1
            Wa1 wa1 = new Wa1
            {
                in_func_code = "3C",
                in_platform_ind = "C",
                in_auxseg_switch = "Y",
                in_mode_switch = "E",

                in_boro1 = ValidationHelper.ValidateBoroInput(borough1),
                in_stname1 = onStreet?.Replace(" and ", " & ") ?? string.Empty,
                in_compass_dir = sideOfStreet ?? string.Empty,
                in_boro2 = ValidationHelper.ValidateBoroInput(borough2),
                in_stname2 = firstCrossStreet?.Replace(" and ", " & ") ?? string.Empty,
                in_boro3 = ValidationHelper.ValidateBoroInput(borough3),
                in_stname3 = secondCrossStreet?.Replace(" and ", " & ") ?? string.Empty,
                in_browse_flag = browseFlag ?? string.Empty
            };
            Wa2F3ceas wa2f3ceas = new Wa2F3ceas();

            //geocall and finalize response
            _geo.GeoCall(ref wa1, ref wa2f3ceas);

            if (string.Equals(displayFormat, "false", StringComparison.OrdinalIgnoreCase))
            {
                GeocallResponse<F3cDisplay, F3cResponse> raw = new GeocallResponse<F3cDisplay, F3cResponse>
                {
                    display = null,
                    root = new F3cResponse(wa1, wa2f3ceas)
                };

                return Ok(raw);
            }
            else
            {
                GeocallResponse<F3cDisplay, F3cResponse> goatlike = new GeocallResponse<F3cDisplay, F3cResponse>
                {
                    display = new F3cDisplay(wa1, wa2f3ceas, _geo)
                    {
                        LowB7SCList = ValidationHelper.CreateB7ScList(wa2f3ceas.wa2f3ce.lo_x_sts, wa1.out_stname_list, wa2f3ceas.wa2f3ce.lo_x_sts_cnt, 0, _geo),
                        HighB7SCList = ValidationHelper.CreateB7ScList(wa2f3ceas.wa2f3ce.hi_x_sts, wa1.out_stname_list, wa2f3ceas.wa2f3ce.hi_x_sts_cnt, 5, _geo)
                    },
                    root = null
                };

                return Ok(goatlike);
            }
        }
    }
}
