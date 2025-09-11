using DCP.Geosupport.DotNet.fld_def_lib;
using GeoServices_Core_Commons.Model.Enum;
using GeoXWrapperLib;
using GeoXWrapperLib.Model;
using GeoXWrapperTest.Model;
using System.Collections;

using System.Text.RegularExpressions;

namespace GeoServices_Core_Commons.Helper
{
    public class CommonFunctions
    {
        private readonly fld_dict _fld = new fld_dict();
        public delegate void DisplayFunction();

        private readonly BoroAlias _mn = new BoroAlias("manhattan", "mn", "1");
        private readonly BoroAlias _ny = new BoroAlias("new york", "ny", "1");

        private readonly BoroAlias _bx = new BoroAlias("bronx", "bx", "2");
        private readonly BoroAlias _bk = new BoroAlias("brooklyn", "bk", "3");
        private readonly BoroAlias _qn = new BoroAlias("queens", "qn", "4");
        private readonly BoroAlias _si = new BoroAlias("staten island", "si", "5");

        private bool InsEq(string a, string b) => string.Equals(a, b, StringComparison.OrdinalIgnoreCase);

        /// <summary>
        /// Controls which delegate to use based on displayFormat flag. Defaults to formatted response
        /// </summary>
        /// <param name="displayFormat">string indicating what response format to use</param>
        /// <param name="funcDisplay">Delegate for handling formatted/display data</param>
        /// <param name="funcRoot">Delegate for handling raw/root data</param>
        public void GetData(string displayFormat, DisplayFunction funcDisplay, DisplayFunction funcRoot)
        {
            if (InsEq(displayFormat, "Y") || InsEq(displayFormat, "YES") || InsEq(displayFormat, "T") || InsEq(displayFormat, "TRUE"))
                funcDisplay();
            else if (InsEq(displayFormat, "N") || InsEq(displayFormat, "NO") || InsEq(displayFormat, "F") || InsEq(displayFormat, "FALSE"))
                funcRoot();
            else
                funcDisplay();
        }

        private string DescribeKey(string typeKey)
        {
            switch (typeKey)
            {
                case "N":
                    return "Non-Addressable Place Name";
                case "A":
                    return "Addressable Place Name";
                case "B":
                    return "Non-Addressable Unnamed Building";
                case "F":
                    return "Vacant Street Frontage";
                case "G":
                    return "Name of NAP Complex";
                case "H":
                    return "Hyphenated Address Range";
                case "M":
                    return "Mixed Hyphenation Address Range";
                case "O":
                    return "Out of Sequence Address";
                case "Q":
                    return "Pseudo Address";
                case "R":
                    return "Real Address for Vanity Address";
                case "U":
                    return "Miscellaneous Structure";
                case "V":
                    return "Vanity Address";
                case "W":
                    return "Non-Addressable Building Frontage";
                case "X":
                    return "Constituent NAP of Complex";
                default:
                    return string.Empty;
            }
        }

        public Hashtable PopulateAddressRangeKeys(AddrRangeX[] addrXList)
        {
            Hashtable arHt = new Hashtable();

            for (int i = 0; i < addrXList.Length; i++)
            {
                string addrType = addrXList[i].addr_type.Trim();

                if (!string.IsNullOrWhiteSpace(addrType) && !arHt.ContainsKey(addrType))
                    arHt.Add(addrType, DescribeKey(addrType));
            }

            arHt.Add(string.Empty, "Ordinary Address Range");

            return arHt;
        }

        public List<AddressRange> PopulateAddressRangeList(AddrRangeX[] addrXList, string tpad)
        {
            List<AddressRange> arl = new List<AddressRange>();

            foreach (AddrRangeX arx in addrXList)
            {
                if (string.IsNullOrWhiteSpace(arx.b7sc.sc5))
                    break;

                arl.Add(new AddressRange
                {
                    type = arx.addr_type,
                    type_meaning = AddressRange.DescribeType(arx.addr_type),
                    low_address_number = arx.lhnd,
                    high_address_number = arx.hhnd,
                    street_name = arx.stname,
                    bin = arx.bin.BINToString(),
                    b7sc = arx.b7sc.B7scToString(),
                    tpad_bin_status = string.Equals(tpad, "Y", StringComparison.OrdinalIgnoreCase)
                        ? _fld.get_get_short_def("TPAD_bin_status", arx.TPAD_bin_status)
                        : "N/A",
                });
            }

            return arl;
        }

        /// <summary>
        /// Use FD to get the normalized street name from a boro and sc5 code (ex. from a B10Sc)
        /// </summary>
        /// <param name="inBoro">Input boro code as string, '1'-'5' are valid boro codes</param>
        /// <param name="inStCode">Input street/sc5 code</param>
        /// <returns>The normalized street name</returns>
        public string GetStreetName(string inBoro, string inStCode)
        {
            Geo geoFd = new Geo();
            Wa1 wa1 = new Wa1
            {
                in_func_code = "D",
                in_platform_ind = "C",
                in_b10sc1 = new B10sc
                {
                    boro = inBoro,
                    sc5 = inStCode
                }
            };
            geoFd.GeoCall(ref wa1);

            return wa1.out_stname1;
        }

        /// <summary>
        /// Use FDG to get the normalized street name from a boro code, sc5 street code, and LGC (ex. from a B10Sc)
        /// </summary>
        /// <param name="inBoro">Input boro code as string, '1'-'5' are valid boro codes</param>
        /// <param name="inStCode">Input street/sc5 code</param>
        /// <param name="inLgc">Input LGC</param>
        /// <returns>The normalized street name</returns>
        public string GetStreetNameDG(string inBoro, string inStCode, string inLgc)
        {
            Geo geoDg = new Geo();
            Wa1 wa1 = new Wa1
            {
                in_func_code = "DG",
                in_platform_ind = "C",
                in_b10sc1 = new B10sc
                {
                    boro = inBoro,
                    sc5 = inStCode,
                    lgc = inLgc
                }
            };
            geoDg.GeoCall(ref wa1);

            return wa1.out_stname1;
        }

        /// <summary>
        /// Match an input borough string against any accepted name, abbreviation, or code
        /// </summary>
        /// <param name="boro">Input borough string</param>
        /// <returns>The matching borough code for the input. If all matches fail, the original input string is returned back</returns>
        public string ValidateBoroValue(string boro)
        {
            if (string.IsNullOrWhiteSpace(boro))
                return string.Empty;

            if (_mn.MatchAny(boro) || _ny.MatchAny(boro))
                return "1";
            else if (_bx.MatchAny(boro))
                return "2";
            else if (_bk.MatchAny(boro))
                return "3";
            else if (_qn.MatchAny(boro))
                return "4";
            else if (_si.MatchAny(boro))
                return "5";
            else
                return boro;
        }

        public string CheckGeoX(string input)
        {
            Regex rx = new Regex(@"^[0-9a-zA-Z\s'?!;,:\-()\.\&\/]+$");
            Match mch = rx.Match(input);
            return mch.Success ? input : string.Empty;
        }

        public string ExtractHouseNum(string input)
        {
            Geo geo = new Geo();
            Wa1 wa1Fd = new Wa1
            {
                in_func_code = "D",
                in_platform_ind = "C",
                in_hns = input
            };

            geo.GeoCall(ref wa1Fd);
            return CheckGeoX(wa1Fd.out_hnd);
        }

        public List<SimilarName> PopulateSimilarNames(Wa1 wa1)
        {
            B7sc[] b7scs = wa1.out_b7sc_list;
            string[] stNames = wa1.out_stname_list;

            if (b7scs.Length != stNames.Length)
                return Enumerable.Empty<SimilarName>().ToList();

            List<SimilarName> snl = new List<SimilarName>();
            for (int i = 0; i < b7scs.Length; i++)
            {
                string b7sc = b7scs[i].B7scToString();

                if (string.IsNullOrWhiteSpace(b7sc))
                    break;

                snl.Add(new SimilarName
                {
                    b7sc = b7sc,
                    streetName = stNames[i]
                });
            }

            return snl;
        }

        /// <summary>
        /// Assemble the complete bins list
        /// </summary>
        /// <param name="wa1">Wa1 object loaded with user parameters</param>
        /// <param name="wa2f1ax">WA2F1AX object from a completed geocall</param>
        /// <param name="tpad">TPAD switch as string - "Y" or "N"</param>
        /// <param name="funcCode">Function code string</param>
        /// <returns>List of CompleteBIN objects with the geocall response data</returns>
        public List<CompleteBIN> PopulateCompleteBINList(Wa1 wa1, Wa2F1ax wa2f1ax, string tpad, string funcCode)
        {
            string acceptedFunc;
            switch (funcCode.ToUpper())
            {
                case "1A":
                case "1B":
                    acceptedFunc = "1A";
                    break;
                case "BL":
                    acceptedFunc = "BL";
                    break;
                default:
                    acceptedFunc = null;
                    break;
            }

            if (string.IsNullOrEmpty(acceptedFunc))
                return Enumerable.Empty<CompleteBIN>().ToList();

            //check overflow flag -> if " " then no need to do secondary lookups
            bool usingTpad = InsEq(tpad, "y") || InsEq(tpad, "true");
            if (wa2f1ax.addr_overflow_flag == " ")
            {
                return string.IsNullOrWhiteSpace(wa2f1ax.addr_x_list.FirstOrDefault()?.bin.BINToString())
                    ? Enumerable.Empty<CompleteBIN>().ToList() //if first is empty, they are all empty
                    : wa2f1ax.addr_x_list
                        .Where(arx => !string.IsNullOrWhiteSpace(arx.bin.BINToString())) //filter blanks
                        .GroupBy(arx => arx.bin.BINToString()) //we do not care for differences aside from bin string, so we group on bin string...
                        .Select(group => group.First()) //..and only grab the first of each group -> will be unique
                        .Select(arx => new CompleteBIN
                        {
                            bin = arx.bin.BINToString(),
                            tpad = usingTpad
                                ? _fld.get_get_short_def("TPAD_bin_status", arx.TPAD_bin_status)
                                : null //no input TPAD flag => no TPAD bin status
                        })
                        .ToList();
            }

            //else if "E" then you need to get the long tpad records to grab the ommitted bins from the wa2f1ax
            Geo geo = new Geo();
            List<CompleteBIN> bins = new List<CompleteBIN>();

            Wa1 wa1Copy = wa1;
            wa1Copy.in_func_code = funcCode;
            wa1Copy.in_long_wa2_flag = "L";
            wa1Copy.in_mode_switch = string.Empty;
            wa1Copy.in_roadbed_request_switch = string.Empty;

            if (usingTpad)
            {
                Wa2F1al_TPAD wa2f1al_tpad = new Wa2F1al_TPAD();
                geo.GeoCall(ref wa1Copy, ref wa2f1al_tpad);

                foreach (TPADLongWa2Info item in wa2f1al_tpad.TPAD_list)
                {
                    string binString = item.bin.BINToString();

                    if (string.IsNullOrWhiteSpace(binString))
                        break;

                    bins.Add(new CompleteBIN
                    {
                        bin = binString,
                        tpad = _fld.get_get_short_def("TPAD_bin_status", item.TPAD_bin_status)
                    });
                }
            }
            else
            {
                Wa2F1al wa2f1al = new Wa2F1al();
                geo.GeoCall(ref wa1Copy, ref wa2f1al);

                foreach (BIN bin in wa2f1al.bin_list)
                {
                    string binString = bin.BINToString();

                    if (string.IsNullOrWhiteSpace(binString))
                        break;

                    bins.Add(new CompleteBIN
                    {
                        bin = binString,
                        tpad = null
                    });
                }
            }

            return bins;
        }

        public List<LowHighB7SC> PopulateB7SC(B7sc[] b7scList, string[] stNames)
        {
            List<LowHighB7SC> b7scs = new List<LowHighB7SC>();
            for (int i = 0; i < b7scList.Length; i++)
            {
                string b7sc = b7scList[i].ToString();

                if (string.IsNullOrWhiteSpace(b7sc))
                    break;

                b7scs.Add(new LowHighB7SC
                {
                    b7sc = b7sc,
                    streetName = stNames[i]
                });
            }

            return b7scs;
        }

        public string BoroCodeFromName(string inName)
        {
            if (_mn.MatchName(inName) || _ny.MatchName(inName))
                return _mn.Code; //same as _ny.Code, "1"
            else if (_bx.MatchName(inName))
                return _bx.Code;
            else if (_bk.MatchName(inName))
                return _bk.Code;
            else if (_qn.MatchName(inName))
                return _qn.Code;
            else if (_si.MatchName(inName))
                return _si.Code;
            else
                return string.Empty;
        }

        public string BoroNameFromCode(string inCode)
        {
            if (_mn.MatchCode(inCode)) //"New York"/"NY" will fold into this as its the same boro code
                return _mn.Name;
            else if (_bx.MatchCode(inCode))
                return _bx.Name;
            else if (_bk.MatchCode(inCode))
                return _bk.Name;
            else if (_qn.MatchCode(inCode))
                return _qn.Name;
            else if (_si.MatchCode(inCode))
                return _si.Name;
            else
                return string.Empty;
        }

        public string FireCompanyParser(string fc) => (!string.IsNullOrWhiteSpace(fc)) ? _fld.get_get_short_def("fire_co_type", fc) : string.Empty;
    }

    public class AddressRange
    {
        public string type { get; set; }
        public string type_meaning { get; set; }
        public string low_address_number { get; set; }
        public string high_address_number { get; set; }
        public string street_name { get; set; }
        public string bin { get; set; }
        public string tpad_bin_status { get; set; }
        public string b7sc { get; set; }

        public static string DescribeType(string type)
        {
            switch (type.Trim())
            {
                case "":
                    return "Ordinary Address Range";
                case "N":
                    return "Non-Addressable Place Name";
                case "A":
                    return "Addressble Place Name";
                case "B":
                    return "Non-Addressable Unnamed Building";
                case "F":
                    return "Vacant Street Frontage";
                case "G":
                    return "Name of NAP Complex";
                case "H":
                    return "Hyphenated Address Range";
                case "M":
                    return "Mixed Hyphenation Address Range";
                case "O":
                    return "Out of Sequence Address";
                case "Q":
                    return "Pseudo Address";
                case "R":
                    return "Real Address for Vanity Address";
                case "U":
                    return "Miscellaneous Structure";
                case "V":
                    return "Vanity Address";
                case "W":
                    return "Non-Addressable Building Frontage";
                case "X":
                    return "Constituent NAP of Complex";
                default:
                    return string.Empty;
            }
        }
    }

    public class AddressRangeApx
    {
        public string type { get; set; }
        public string type_meaning { get; set; }
        public string low_address_number { get; set; }
        public string high_address_number { get; set; }
        public string street_name { get; set; }
        public string bin { get; set; }
        public string b7sc { get; set; }

        public string DescribeType()
        {
            switch (type.Trim())
            {
                case "":
                    return "Ordinary Address Range";
                case "N":
                    return "Non-Addressable Place Name";
                case "A":
                    return "Addressble Place Name";
                case "B":
                    return "Non-Addressable Unnamed Building";
                case "F":
                    return "Vacant Street Frontage";
                case "G":
                    return "Name of NAP Complex";
                case "H":
                    return "Hyphenated Address Range";
                case "M":
                    return "Mixed Hyphenation Address Range";
                case "O":
                    return "Out of Sequence Address";
                case "Q":
                    return "Pseudo Address";
                case "R":
                    return "Real Address for Vanity Address";
                case "U":
                    return "Miscellaneous Structure";
                case "V":
                    return "Vanity Address";
                case "W":
                    return "Non-Addressable Building Frontage";
                case "X":
                    return "Constituent NAP of Complex";
                default:
                    return string.Empty;
            }
        }
    } 
}