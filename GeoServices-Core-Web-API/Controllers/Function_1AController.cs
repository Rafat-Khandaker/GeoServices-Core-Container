using GeoServices_Core_Commons.Core;
using GeoServices_Core_Commons.Helper;
using GeoXWrapperLib;
using GeoXWrapperLib.Model;
using GeoXWrapperTest.Helper;
using GeoXWrapperTest.Model;
using GeoXWrapperTest.Model.Display;
using GeoXWrapperTest.Model.Enum;
using GeoXWrapperTest.Model.Response;
using Microsoft.AspNetCore.Mvc;

namespace GeoServices_Core_Web_API.Controllers;

[ApiController]
[Route("[controller]")]
public class Function_1AController : ControllerBase
{
    private Geo _geo;
    private AccessControlList _accessControl;
    private GeoService _geoService;

    public Function_1AController(Geo geo, AccessControlList accessControlList, GeoService geoService) 
    {
        _geo = geo;
        _accessControl = accessControlList.ReadKeyFile(true).Result;
        _geoService = geoService;
    }

    /// <summary>
    /// Function 1A finds the tax lot to which an address or place name has been assigned. Enter an address or place name, e.g., �350 5 Avenue� or �Empire State Building�. Function 1A returns property level information for that tax lot, including buildings on the lot. The coordinates shown are for the tax lot centroid.
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
    /// <param name="tpad">Enter "true" or "y" to read from the TPAD file. Defaults to "" (empty string) which will not execute the read</param>
    /// <param name="browseFlag">Browse flag to be used for normalizing the inputted street name. See remarks for acceptable inputs</param>
    /// <param name="unit">Unit number, ex. the suite or office number, etc</param>
    /// <param name="hns">Enter "true" or "y" to use Sort Format for your `addressNo` parameter. Defaults to normal format</param>
    /// <param name="displayFormat">Defaults to "true" for the beautified GOAT-like format. Use "false" for raw format to see the returned work areas</param>
    /// <returns>F1A geocall response</returns>
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
            string tpad = "", 
            string browseFlag = "", 
            string unit = "", 
            string hns = "n",
            string displayFormat = "true"
        ){
        if (string.IsNullOrEmpty(key))  
            return BadRequest("Please provide your API key as a parameter");  
        else if (!_accessControl.Verify(key)) 
            return Unauthorized();

        return Ok(_geoService.Function1A(
            new FunctionInput
            {
                Key = key,
                Borough = borough,
                ZipCode = zipCode,
                AddressNo = addressNo,
                StreetName = streetName,
                TPad = tpad,
                BrowseFlag = browseFlag,
                Unit = unit,
                Hns = hns,
                DisplayFormat = displayFormat
            }));
    }

  
}