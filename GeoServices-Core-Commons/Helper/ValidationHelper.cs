
using System.Text.RegularExpressions;
using GeoXWrapperTest.Model;
using GeoXWrapperLib.Model;
using GeoXWrapperTest.Model.Enum;
using GeoXWrapperLib;
using DCP.Geosupport.DotNet.fld_def_lib;
using System.Collections;

namespace GeoXWrapperTest.Helper
{
    public static class ValidationHelper 
    {
        private static readonly Regex _houseNumRgx = new Regex(@"^[0-9a-zA-Z\s'?!;,:\-()\.\&\/]+$");
        private static readonly Regex _stNameRgx = new Regex(@"^[0-9a-zA-Z\s'?!;,:\-()\.\&\/]+$");

        private static readonly BoroAlias _manhattan = new BoroAlias("Manhattan", "MN", "1");
        private static readonly BoroAlias _newYork = new BoroAlias("New York", "NY", "1");
        private static readonly BoroAlias _bronx = new BoroAlias("Bronx", "BX", "2");
        private static readonly BoroAlias _brooklyn = new BoroAlias("Brooklyn", "BK", "3");
        private static readonly BoroAlias _queens = new BoroAlias("Queens", "QN", "4");
        private static readonly BoroAlias _statenIsland = new BoroAlias("Staten Island", "SI", "5");

        private static readonly fld_dict _fld = new fld_dict();

        public static string ValidateBoroInput(string boro)
        {
            if (string.IsNullOrWhiteSpace(boro))
                return string.Empty;
            else if (_manhattan.Match(boro) || _newYork.Match(boro))
                return "1";
            else if (_bronx.Match(boro))
                return "2";
            else if (_brooklyn.Match(boro))
                return "3";
            else if (_queens.Match(boro))
                return "4";
            else if (_statenIsland.Match(boro))
                return "5";
            else
                return boro;
        }

        public static List<AddressRangeApx> CreateAddressRangeList(IEnumerable<AddrRange_apx> addrXList)
        {
            if (!addrXList.Any())
                return Enumerable.Empty<AddressRangeApx>().ToList();

            List<AddressRangeApx> arlAp = new List<AddressRangeApx>();
            foreach (AddrRange_apx arApx in addrXList)
            {
                if (string.IsNullOrWhiteSpace(arApx.b7sc.sc5))
                    break;

                arlAp.Add(new AddressRangeApx
                {
                    type = arApx.addr_type,
                    type_meaning = AddressRange.NormalizedType(arApx.addr_type),
                    low_address_number = arApx.lhnd,
                    high_address_number = arApx.hhnd,
                    street_name = arApx.stname,
                    bin = arApx.bin.BINToString(),
                    b7sc = arApx.b7sc.B7scToString(),
                    //NOTE: FAP does not supply TPAD bin
                });
            }

            return arlAp;
        }

        public static List<AddressRange> CreateAddressRangeList(IEnumerable<AddrRangeX> addrXList, string tpad)
        {
            if (!addrXList.Any())
                return Enumerable.Empty<AddressRange>().ToList();

            List<AddressRange> arl = new List<AddressRange>();
            foreach (AddrRangeX arx in addrXList)
            {
                if (string.IsNullOrWhiteSpace(arx.b7sc.sc5))
                    break;

                arl.Add(new AddressRange
                {
                    type = arx.addr_type,
                    type_meaning = AddressRange.NormalizedType(arx.addr_type),
                    low_address_number = arx.lhnd,
                    high_address_number = arx.hhnd,
                    street_name = arx.stname,
                    bin = arx.bin.BINToString(),
                    b7sc = arx.b7sc.B7scToString(),
                    tpad_bin_status = InsEq(tpad, "y") || InsEq(tpad, "true")
                        ? _fld.get_get_short_def("TPAD_bin_status", arx.TPAD_bin_status)
                        : "N/A",
                });
            }

            return arl;
        }

        /// <summary>
        /// Assemble the address range keys dictionary
        /// </summary>
        /// <param name="addrXList">The addr_x_list coming from wa2</param>
        /// <returns>Dictionary of k: address type flag as string, v: address type string</returns>
        public static Dictionary<string,string> CreateAddressRangeKeys(AddrRangeX[] addrXList)
        {
            var arHt = new Dictionary<string,string>();

            for (int i = 0; i < addrXList.Length; i++)
            {
                string addrType = addrXList[i].addr_type.Trim();

                if (!string.IsNullOrWhiteSpace(addrType) && !arHt.ContainsKey(addrType))
                    arHt.Add(addrType, DescribeKey(addrType));
            }

            arHt.Add(string.Empty, "Ordinary Address Range");

            return arHt;
        }

        private static string DescribeKey(string typeKey)
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
        /// <summary>
        /// Assemble similar names list
        /// </summary>
        /// <param name="outB7scList">WA1's out_b7sc_list</param>
        /// <param name="outStNameList">WA1's out_stname_list</param>
        /// <returns>List of SimilarName objects for with geocall error/warning data</returns>
        public static List<SimilarName> CreateSimilarNamesList(IEnumerable<B7sc> outB7scList, IEnumerable<string> outStNameList)
        {
            if (!outB7scList.Any() || !outStNameList.Any())
                return Enumerable.Empty<SimilarName>().ToList();

            List<B7sc> b7scs = outB7scList.ToList();
            List<string> stNames = outStNameList.ToList();

            if (b7scs.Count != stNames.Count)
                return Enumerable.Empty<SimilarName>().ToList();

            List<SimilarName> snl = new List<SimilarName>();
            for (int i = 0; i < b7scs.Count; i++)
            {
                if (string.IsNullOrWhiteSpace(b7scs[i].B7scToString()))
                    break;

                snl.Add(new SimilarName
                {
                    b7sc = b7scs[i].B7scToString(),
                    streetName = stNames[i]
                });
            }

            return snl;
        }
        public static string ReadBoroName(string boroCode)
        {
            switch (boroCode)
            {
                case "1":
                    return _manhattan.Name; //All 1's get folded into manhattan, no New York
                case "2":
                    return _bronx.Name;
                case "3":
                    return _brooklyn.Name;
                case "4":
                    return _queens.Name;
                case "5":
                    return _statenIsland.Name;
                default:
                    return string.Empty;
            }
        }
        public static List<CompleteBIN> CreateCompleteBINList(Wa1 wa1, Wa2F1ax wa2f1ax, string tpad, FunctionCode funcCode, Geo geoCaller)
        {
            string acceptedFunc;
            switch (funcCode)
            {
                case FunctionCode.F1A:
                case FunctionCode.F1B:
                    acceptedFunc = "1A";
                    break;
                case FunctionCode.FBBL:
                    acceptedFunc = "BL";
                    break;
                default:
                    acceptedFunc = null;
                    break;
            }

            if (string.IsNullOrEmpty(acceptedFunc))
            {
                return Enumerable.Empty<CompleteBIN>().ToList();
                //throw new ArgumentException("Complete BINs may only be returned from F1A/F1B and FBL");
            }

            bool usingTpad = InsEq(tpad, "y") || InsEq(tpad, "true");

            //if overflow flag is not "E" then we can simply derive the bins list from the existing addr_x_list. No need for secondary calls
            if (InsEq(wa2f1ax.addr_overflow_flag, " "))
            {
                return string.IsNullOrWhiteSpace(wa2f1ax.addr_x_list.FirstOrDefault()?.bin.BINToString())
                    ? Enumerable.Empty<CompleteBIN>().ToList() //if first is empty, they are all empty
                    : wa2f1ax.addr_x_list
                        .Where(arx => !string.IsNullOrWhiteSpace(arx.bin.BINToString())) //filter blanks
                        .GroupBy(arx => arx.bin.BINToString()) //we do not care for differences aside from bin string, so we group on bin string...
                        .Select(arxGroup => arxGroup.First()) //..and only grab the first of each group -> will be unique
                        .Select(arx => new CompleteBIN
                        {
                            bin = arx.bin.BINToString(),
                            tpad = usingTpad
                                ? _fld.get_get_short_def("TPAD_bin_status", arx.TPAD_bin_status)
                                : null //no input TPAD flag => no TPAD bin status
                        })
                        .ToList();
            }

            //If there is a char in the overflow flag, we will need to make secondary calls to the long wa2 to get additional bins
            List<CompleteBIN> bins = new List<CompleteBIN>();

            Wa1 wa1Copy = new Wa1();
            wa1Copy.Wa1FromString(wa1.Wa1ToString()); //hacky deep clone of wa1 so we don't inadverdently alter the original instance

            //alter the copy to prep it for the long WA2 flagged geocall -> we are looking for extra bins that may exist for special cases
            wa1Copy.in_func_code = acceptedFunc;
            wa1Copy.in_long_wa2_flag = "L";
            wa1Copy.in_mode_switch = string.Empty;
            wa1Copy.in_roadbed_request_switch = string.Empty;

            //Execute F1AL with or without the TPAD option input
            if (usingTpad)
            {
                Wa2F1al_TPAD wa2f1al_tpad = new Wa2F1al_TPAD();
                geoCaller.GeoCall(ref wa1Copy, ref wa2f1al_tpad);

                foreach (TPADLongWa2Info binTpad in wa2f1al_tpad.TPAD_list)
                {
                    if (string.IsNullOrWhiteSpace(binTpad.bin.BINToString()))
                        break; //blank means end of list

                    bins.Add(new CompleteBIN
                    {
                        bin = binTpad.bin.BINToString(),
                        tpad = _fld.get_get_short_def("TPAD_bin_status", binTpad.TPAD_bin_status)
                    });
                }
            }
            else
            {
                Wa2F1al wa2f1al = new Wa2F1al();
                geoCaller.GeoCall(ref wa1Copy, ref wa2f1al);

                foreach (BIN bin in wa2f1al.bin_list)
                {
                    if (string.IsNullOrWhiteSpace(bin.BINToString()))
                        break; //blank means end of list

                    bins.Add(new CompleteBIN
                    {
                        bin = bin.BINToString(),
                        tpad = null //no input TPAD flag => no TPAD bin status
                    });
                }
            }

            return bins;
        }

        public static string ValidateStName(string input) => _stNameRgx.Match(input).Success ? input : string.Empty;

        private static bool InsEq(string a, string b) => string.Equals(a, b, StringComparison.OrdinalIgnoreCase);

        readonly struct BoroAlias
        {
            public string Name { get; }
            public string Abbreviation { get; }
            public string Code { get; }

            public BoroAlias(string name, string abbreviation, string code)
            {
                Name = name;
                Abbreviation = abbreviation;
                Code = code;
            }

            /// <summary>
            /// Check wheter an input matches this BoroAlias
            /// </summary>
            /// <param name="input">Input borough string</param>
            /// <returns>True if input matches an accepted name, abbreviation, or code. False otherwise</returns>
            public bool Match(string input) => string.Equals(input, Name, StringComparison.OrdinalIgnoreCase) || string.Equals(input, Abbreviation, StringComparison.OrdinalIgnoreCase) || string.Equals(input, Code, StringComparison.OrdinalIgnoreCase);
        }

        private static string DescribeAddrKey(string key)
        {
            switch (key)
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
        public static List<LowHighB7SC> CreateB7ScList(IEnumerable<B7sc> xB7scList, IEnumerable<string> xStNameList)
        {
            if (!xB7scList.Any() || !xStNameList.Any())
                return Enumerable.Empty<LowHighB7SC>().ToList();

            List<B7sc> b7scs = xB7scList.ToList();
            List<string> stNames = xStNameList.ToList();

            if (b7scs.Count != stNames.Count)
                return Enumerable.Empty<LowHighB7SC>().ToList();

            List<LowHighB7SC> b7scList = new List<LowHighB7SC>();
            for (int i = 0; i < b7scs.Count; i++)
            {
                if (string.IsNullOrWhiteSpace(b7scs[i].B7scToString()))
                    break;

                b7scList.Add(new LowHighB7SC
                {
                    b7sc = b7scs[i].B7scToString(),
                    streetName = stNames[i]
                });
            }

            return b7scList;
        }


        public static List<LowHighB7SC> CreateB7ScList(IEnumerable<B7sc> xB7scList, IEnumerable<string> xStNameList, string length, int offset, Geo geoCaller)
        {
            if (!int.TryParse(length, out int len) || len == 0)
                return Enumerable.Empty<LowHighB7SC>().ToList();

            List<LowHighB7SC> b7scList = new List<LowHighB7SC>();
            List<B7sc> b7scs = xB7scList.ToList();
            List<string> stNames = xStNameList.ToList();

            for (int i = 0; i < len; i++)
            {
                b7scList.Add(new LowHighB7SC
                {
                    b7sc = ReadStCode1N(b7scs[i], stNames[i + offset], geoCaller),
                    streetName = stNames[i + offset]
                });
            }

            return b7scList;
        }

        public static string ValidateHouseNum(string input, Geo geoCaller)
        {
            Wa1 wa1Fd = new Wa1
            {
                in_func_code = "D",
                in_platform_ind = "C",
                in_hns = input
            };
            geoCaller.GeoCall(ref wa1Fd);

            return _houseNumRgx.Match(wa1Fd.out_hnd).Success
                ? wa1Fd.out_hnd
                : string.Empty;
        }

        public static string ReadStNameFdg(B10sc b10sc, string lgcs, Geo geoCaller)
        {
            Wa1 wa1Dg = new Wa1
            {
                in_func_code = "DG",
                in_platform_ind = "C",
                in_b10sc1 = new B10sc
                {
                    boro = b10sc.boro,
                    sc5 = b10sc.sc5,
                    lgc = lgcs
                }
            };
            geoCaller.GeoCall(ref wa1Dg);

            return !string.Equals(wa1Dg.out_stname1, new string('?', 32), StringComparison.CurrentCulture)
                ? ValidateStName(wa1Dg.out_stname1)
                : string.Empty;
        }

        public static string ReadStNameFdg(string inBoro, string inSc5, string inLgc, Geo geoCaller)
        {
            Wa1 wa1 = new Wa1
            {
                in_func_code = "DG",
                in_platform_ind = "C",
                in_b10sc1 = new B10sc
                {
                    boro = inBoro,
                    sc5 = inSc5,
                    lgc = inLgc
                }
            };
            geoCaller.GeoCall(ref wa1);

            return wa1.out_stname1;
        }

        public static string ReadStNameFd(string inBoro, string inStCode, Geo geoCaller)
        {
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
            geoCaller.GeoCall(ref wa1);

            return wa1.out_stname1;
        }

        private static string ReadStCode1N(B7sc b7sc, string st, Geo geoCaller)
        {
            Wa1 wa1F1n = new Wa1
            {
                in_func_code = "1N",
                in_platform_ind = "C",
                in_stname1 = st,
                in_b10sc1 = new B10sc
                {
                    boro = b7sc.boro
                }
            };
            geoCaller.GeoCall(ref wa1F1n);

            string boro = b7sc.boro.Trim().TrimStart('0');
            string sc5 = b7sc.sc5.Trim();
            string lgc = wa1F1n.out_b10sc1.lgc;

            return boro + sc5 + lgc;
        }

        public static string ReadOrientation(string sos)
        {
            switch (sos)
            {
                case "R":
                    return "right";
                case "L":
                    return "left";
                default:
                    return string.Empty;
            }
        }
        public static Dictionary<int, List<string>> CreateNodeB7ScDictionary(string[] nodes, B7sc[,,] b7scs)
        {
            Dictionary<int, List<string>> nodeB7Scs = new Dictionary<int, List<string>>();
            int currentKey = 0;

            for (int i = 0; i < nodes.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(nodes[i]))
                    continue;

                //traverse multi-dim array and add all b7sc's under this node
                List<string> b7scsForNode = new List<string>();
                for (int j = 0; j < b7scs.GetLength(1); j++)
                {
                    for (int k = 0; k < b7scs.GetLength(2); k++)
                    {
                        string currentB7sc = b7scs[i, j, k].B7scToString();

                        if (!string.IsNullOrWhiteSpace(currentB7sc))
                            b7scsForNode.Add(currentB7sc);
                    }
                }

                nodeB7Scs.Add(currentKey, b7scsForNode); //Add the starting point as key, and the list of b7sc's as value

                currentKey += b7scsForNode.Count; //next key/starting point is the sum of initial value + the count of b7sc's that were added in current iteration
            }

            return nodeB7Scs;
        }

        public static Dictionary<int, List<string>> CreateCrossStreetDict(string boroCode, Wa2F2w wa2f2w, Geo geoCaller)
        {
            if (string.IsNullOrEmpty(ValidateBoroInput(boroCode)) || !wa2f2w.node_list.Any())
                return new Dictionary<int, List<string>>();

            Dictionary<int, List<string>> crxStDict = new Dictionary<int, List<string>>();
            int startKey = 0;
            const int ST_IDX_COUNT = 5;
            const int LGC_IDX_COUNT = 4;

            for (int nodeIdx = 0; nodeIdx < wa2f2w.node_list.Length; nodeIdx++)
            {
                #region FDL using all node B7Sc's -> Read normalized Street Names for nodes
                Wa1 wa1Dl = new Wa1
                {
                    in_func_code = "DL",
                    in_platform_ind = "C"
                };
                int outB7scNodeIdx = 0;
                List<int> stIndices = new List<int>();

                for (int stIdx = 0; stIdx < ST_IDX_COUNT; stIdx++)
                {
                    for (int lgcIdx = 0; lgcIdx < LGC_IDX_COUNT; lgcIdx++)
                    {
                        string currentB7sc = wa2f2w.node_b7scs_item(nodeIdx, stIdx, lgcIdx).B7scToString();

                        if (string.IsNullOrWhiteSpace(currentB7sc))
                            continue;

                        wa1Dl.out_b7sc_list[outB7scNodeIdx++].B7scFromString(currentB7sc);

                        stIndices.Add(stIdx);
                    }
                }

                geoCaller.GeoCall(ref wa1Dl);
                #endregion

                #region Combine Matching Street Names from the FDL Call
                List<string> stNames = new List<string>();
                HashSet<int> idxMatches = new HashSet<int>();

                if (stIndices.Count > 2)
                {
                    for (int i = 0; i < stIndices.Count - 1; i++)
                    {
                        if (stIndices[i] == stIndices[i + 1])
                            idxMatches.Add(i);
                    }
                }

                for (int i = 0; i < stIndices.Count; i++)
                {
                    string currentStName = wa1Dl.out_stname_list[i].Trim();
                    string nextStName = wa1Dl.out_stname_list[i + 1].Trim();

                    if (idxMatches.Contains(i) && !string.IsNullOrEmpty(nextStName))
                    {
                        stNames.Add($"{currentStName},{nextStName}");
                        i++; //skip ahead since we combined
                    }
                    else
                    {
                        stNames.Add(currentStName);
                    }
                }
                #endregion

                List<string> crxSts = new List<string>();
                if (stNames.Any())
                {
                    #region Use F1N to get B10Sc's
                    for (int i = 0; i < stNames.Count; i++)
                    {
                        string current = stNames[i];

                        if (i != stNames.Count - 1)
                        {
                            string next = stNames[i + 1];

                            if (current.Contains(",") && next.Contains(","))
                            {
                                Wa1 wa1_1n = new Wa1
                                {
                                    in_func_code = "1N",
                                    in_boro1 = ValidateBoroInput(boroCode),
                                    in_stname1 = current.Split(',')[0]
                                };
                                geoCaller.GeoCall(ref wa1_1n);
                                string stCode1 = wa1_1n.out_b10sc1.B10scToString().Substring(0, 6);

                                wa1_1n = new Wa1
                                {
                                    in_func_code = "1N",
                                    in_boro1 = ValidateBoroInput(boroCode),
                                    in_stname1 = next.Split(',')[0]
                                };
                                geoCaller.GeoCall(ref wa1_1n);
                                string stCode2 = wa1_1n.out_b10sc1.B10scToString().Substring(0, 6);

                                if (InsEq(stCode1, stCode2))
                                {
                                    crxSts.Add($"{current},{next}");
                                }
                                else
                                {
                                    crxSts.Add(current);
                                    crxSts.Add(next);
                                }

                                i++; //skip ahead since we combined the match
                            }
                            else
                            {
                                crxSts.Add(current);
                            }
                        }
                        else
                        {
                            crxSts.Add(current);
                        }
                    }
                    #endregion

                    crxStDict.Add(startKey, crxSts);
                    startKey += stNames.Count;
                }
            }

            return crxStDict;
        }

        public static List<CrxStInfoF3S> CreateF3sIntrsctList(IEnumerable<CrossStreetInfo> crxStList, Geo geoCaller)
        {
            if (!crxStList.Any())
                return Enumerable.Empty<CrxStInfoF3S>().ToList();

            Wa1 wa1_dl = new Wa1
            {
                in_func_code = "DL",
                in_platform_ind = "C"
            };

            List<CrxStInfoF3S> f3sList = new List<CrxStInfoF3S>();

            foreach (CrossStreetInfo crxStInfo in crxStList.ToList())
            {
                if (string.IsNullOrWhiteSpace(crxStInfo.node_num))
                    break;

                //Use FDL to find intersecting streets
                for (int i = 0; i < 5; i++)
                {
                    wa1_dl.out_b7sc_list[i] = crxStInfo.xstr_b7sc_list[i];
                }
                geoCaller.GeoCall(ref wa1_dl);

                CrxStInfoF3S f3sCrxSt = new CrxStInfoF3S
                {
                    out_intersecting_street = wa1_dl.out_stname_list[0].Trim(),
                    out_second_intersecting_street = wa1_dl.out_stname_list[1].Trim(),
                    out_third_intersecting_street = wa1_dl.out_stname_list[2].Trim(),
                    out_fourth_intersecting_street = wa1_dl.out_stname_list[3].Trim(),
                    out_fifth_intersecting_street = wa1_dl.out_stname_list[4].Trim(),
                    out_xstr_cnt = crxStInfo.xstr_cnt, //intersecting st count
                    out_distance = string.IsNullOrWhiteSpace(crxStInfo.distance.TrimStart('0'))
                        ? "0"
                        : crxStInfo.distance.TrimStart('0'),
                    out_node_num = crxStInfo.node_num
                };

                //stringified gap flag
                string flagCode = string.Empty;
                switch (crxStInfo.gap_flag)
                {
                    case "C":
                        flagCode = "Combined Seg";
                        break;
                    case "G":
                        flagCode = "Gap";
                        break;
                    case "D":
                        flagCode = "Dog Leg";
                        break;
                    case "N":
                        flagCode = "New";
                        break;
                }
                f3sCrxSt.out_gap_flag = flagCode;

                //final processing on out_intersecting_street
                f3sCrxSt.out_intersecting_street = string.IsNullOrWhiteSpace(f3sCrxSt.out_intersecting_street) && !string.IsNullOrWhiteSpace(f3sCrxSt.out_distance)
                    ? "NON STREET FEATURE"
                    : f3sCrxSt.out_intersecting_street;

                f3sList.Add(f3sCrxSt);
            }

            return f3sList;
        }
    }
}
