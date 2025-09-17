﻿using GeoServices_Core_Commons.Helper;
using GeoXWrapperLib;
using GeoXWrapperLib.Model;
using GeoXWrapperTest.Model.Display;
using GeoXWrapperTest.Model;
using Microsoft.AspNetCore.Mvc;
using GeoXWrapperTest.Model.Response;
using GeoXWrapperTest.Helper;
using GeoServices_Core_Commons.Core;

namespace GeoServices_Core_Web_API.Controllers
{
    public class Function_APController : Controller
    {
        private Geo _geo;
        private AccessControlList _accessControl;
        private GeoService _geoService;

        public Function_APController(Geo geo, AccessControlList accessControlList, GeoService geoService)
        {
            _geo = geo;
            _accessControl = accessControlList.ReadKeyFile(true).Result;
            _geoService = geoService;
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
        public IActionResult Get(
            string key, 
            string borough = "", 
            string zipCode = "", 
            string addressNo = "", 
            string streetName = "", 
            string unit = "", 
            string hns = "", 
            string displayFormat = "true"
        ){
            if (string.IsNullOrEmpty(key)) 
                return BadRequest("Please provide your API key as a parameter"); 
            else if (!_accessControl.Verify(key)) 
                return Unauthorized();

            return Ok(_geoService.FunctionAP(
                new FunctionInput { 
                    Key = key,
                    Borough = borough,
                    ZipCode = zipCode,
                    AddressNo = addressNo,
                    StreetName = streetName,
                    Unit = unit,
                    Hns = hns,
                    DisplayFormat = displayFormat
            }));
        }
    }
}
