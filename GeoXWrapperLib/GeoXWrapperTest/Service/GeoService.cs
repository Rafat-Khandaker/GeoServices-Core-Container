using GeoXWrapperLib;
using GeoXWrapperLib.Model;
using GeoXWrapperTest.Helper;
using GeoXWrapperTest.Model;
using GeoXWrapperTest.Model.Display;
using GeoXWrapperTest.Model.Enum;
using GeoXWrapperTest.Model.Response;
using GeoXWrapperTest.Service.Contracts;



namespace GeoXWrapperTest.Service
{
    public class GeoService : IGeoService
    {
        Geo GeoCaller;

        public GeoService(Geo _geoCaller)
        {
            GeoCaller = _geoCaller;
        }

        public GeocallResponse<F1aDisplay, F1aResponse> Function1A(FunctionInput input)
        {
            Wa1 wa1 = new Wa1
            {
                in_func_code = "1A",
                in_platform_ind = "C",
                in_mode_switch = "X",
                in_b10sc1 = new B10sc { boro = ValidationHelper.ValidateBoroInput(input.Borough) },
                in_stname1 = input.StreetName?.Replace(" and ", " & ") ?? string.Empty,
                in_zip_code = input.ZipCode ?? string.Empty,
                in_unit = input.Unit?.Trim() ?? string.Empty,
                in_browse_flag = input.BrowseFlag ?? string.Empty,
                in_tpad_switch = input.TPad ?? string.Empty,
                in_hnd = string.Equals(input.Hns, "true", StringComparison.OrdinalIgnoreCase) || string.Equals(input.Hns, "y", StringComparison.OrdinalIgnoreCase) ? string.Empty : input.AddressNo ?? string.Empty,
                in_hns = string.Equals(input.Hns, "true", StringComparison.OrdinalIgnoreCase) || string.Equals(input.Hns, "y", StringComparison.OrdinalIgnoreCase) ? input.AddressNo ?? string.Empty : string.Empty,
            };

            Wa2F1ax wa2f1ax = new Wa2F1ax();

            GeoCaller.GeoCall(ref wa1, ref wa2f1ax);

            var _funcReadStNameFd = (string inBoro, string inStCode) =>
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

                GeoCaller.GeoCall(ref wa1);

                return wa1.out_stname1;
            };

            _funcReadStNameFd(wa2f1ax.bid_id.boro, wa2f1ax.bid_id.B5scToString().Remove(0, 1));


            return new GeocallResponse<F1aDisplay, F1aResponse>
            {
                display = null,
                root = new F1aResponse(wa1, wa2f1ax)
                {
                    AddressRangeList = ValidationHelper.CreateAddressRangeList(wa2f1ax.addr_x_list, wa1.in_tpad_switch),
                    CompleteBINList = ValidationHelper.CreateCompleteBINList(wa1, wa2f1ax, wa1.in_tpad_switch, FunctionCode.F1A, GeoCaller) //FIXME write test cases
                }
            };
        }



        public GeocallResponse<F1bDisplay, F1bResponse> Function1B(FunctionInput input)
        {
            Wa1 wa1 = new Wa1()
            {
                in_func_code = "1B",
                in_platform_ind = "C",

                in_b10sc1 = new B10sc { boro = ValidationHelper.ValidateBoroInput(input.Borough) },
                in_zip_code = input.ZipCode ?? string.Empty,
                in_stname1 = input.StreetName?.Replace(" and ", " & ") ?? string.Empty,
                in_roadbed_request_switch = input.RoadBed ?? string.Empty,
                in_browse_flag = input.BrowseFlag ?? string.Empty,
                in_tpad_switch = input.TPad ?? string.Empty,
                in_unit = input.Unit?.Trim() ?? string.Empty,
                in_hnd = input.AddressNo ?? string.Empty
            };

            Wa2F1b wa2f1b = new Wa2F1b();

            GeoCaller.GeoCall(ref wa1, ref wa2f1b);

            return new GeocallResponse<F1bDisplay, F1bResponse>
            {
                display = null,
                root = new F1bResponse(wa1, wa2f1b)
            };
        }

        public GeocallResponse<F1eDisplay, F1eResponse> Function1E(FunctionInput input)
        {
            Wa1 wa1 = new Wa1()
            {
                in_func_code = "1E",
                in_platform_ind = "C",
                in_mode_switch = "X",

                in_b10sc1 = new B10sc { boro = ValidationHelper.ValidateBoroInput(input.Borough) },
                in_zip_code = input.ZipCode ?? string.Empty,
                in_stname1 = input.StreetName?.Replace(" and ", " & ") ?? string.Empty,
                in_unit = input.Unit?.Trim() ?? string.Empty,
                in_browse_flag = input.BrowseFlag ?? string.Empty,
                in_roadbed_request_switch = input.RoadBed ?? string.Empty,
                in_hnd = input.AddressNo ?? string.Empty

            };
            Wa2F1ex wa2f1ex = new Wa2F1ex();

            GeoCaller.GeoCall(ref wa1, ref wa2f1ex);

            return new GeocallResponse<F1eDisplay, F1eResponse>
            {
                display = null,
                root = new F1eResponse(wa1, wa2f1ex)
            };
        }

        public GeocallResponse<F1lDisplay, F1lResponse> Function1L(FunctionInput input)
        {
            Wa1 wa1 = new Wa1
            {
                in_func_code = "1L",
                in_hnd = input.AddressNo ?? string.Empty
            };

            //geocall and finalize responses
            GeoCaller.GeoCall(ref wa1);

            return new GeocallResponse<F1lDisplay, F1lResponse>
            {
                display = null,
                root = new F1lResponse(wa1)
            };
        }

        public GeocallResponse<F1nDisplay, F1nResponse> Function1N(FunctionInput input)
        {
            Wa1 wa1 = new Wa1
            {
                in_func_code = "1N",

                in_boro1 = ValidationHelper.ValidateBoroInput(input.Borough),
                in_stname1 = input.StreetName?.Replace(" and ", " & ") ?? string.Empty,
                in_snl = input.StreetNameLength ?? "32",
                in_stname_normalization = input.StreetNameFormat ?? "S"
            };

            GeoCaller.GeoCall(ref wa1);

            return new GeocallResponse<F1nDisplay, F1nResponse>
            {
                display = null,
                root = new F1nResponse(wa1)
            };
        }

        public GeocallResponse<F1rDisplay, F1rResponse> Function1R(FunctionInput input)
        {
            Wa1 wa1 = new Wa1
            {
                in_func_code = "1R",
                in_hnd = input.AddressNo ?? string.Empty
            };

            GeoCaller.GeoCall(ref wa1);

            return new GeocallResponse<F1rDisplay, F1rResponse>
            {
                display = null,
                root = new F1rResponse(wa1)
            };

        }

        public GeocallResponse<F2Display, F2Response> Function2(FunctionInput input)
        {
            Wa1 wa1 = new Wa1
            {
                in_func_code = "2W",
                in_platform_ind = "C",
                in_xstreet_names_flag = "E",

                in_boro1 = ValidationHelper.ValidateBoroInput(input.Borough1),
                in_stname1 = input.Street1?.Replace(" and ", " & ") ?? string.Empty,
                in_boro2 = ValidationHelper.ValidateBoroInput(input.Borough2),
                in_stname2 = input.Street2?.Replace(" and ", " & ") ?? string.Empty,
                in_compass_dir = input.CompassFlag ?? string.Empty,
                in_browse_flag = input.BrowseFlag ?? string.Empty
            };
            Wa2F2w wa2f2w = new Wa2F2w();

            GeoCaller.GeoCall(ref wa1, ref wa2f2w);

            var goatlike = new GeocallResponse<F2Display, F2Response>
            {
                display = new F2Display(wa1, wa2f2w, GeoCaller),
                root = null
            };

            if (string.Equals(wa1.out_grc, "03", StringComparison.CurrentCulture))
            {
                //Note: Node list & similar names list are readonly properties
                F2Display f2Display = goatlike.display;

                //B7Sc list and starting points
                Dictionary<int, List<string>> b7scs = ValidationHelper.CreateNodeB7ScDictionary(wa2f2w.node_list, wa2f2w.node_b7scs);

                f2Display.B7SCStartingPoints = b7scs.Keys.ToList();
                f2Display.B7SCList = b7scs.Values
                    .SelectMany(b7sc => b7sc)
                    .ToList();

                //Cross streets list and starting points
                Dictionary<int, List<string>> crxSts = ValidationHelper.CreateCrossStreetDict(wa1.in_boro1, wa2f2w, GeoCaller);

                f2Display.StartingXStreets = crxSts.Keys.ToList();
                f2Display.CrossStreets = crxSts.Values
                    .SelectMany(crx => crx)
                    .ToList();
            }


            return goatlike;
        }

        public GeocallResponse<F2Display, F2Response> Function2NodeId(FunctionInput input)
        {
            Wa1 wa1 = new Wa1
            {
                in_func_code = "2W",
                in_platform_ind = "C",
                in_xstreet_names_flag = "E",

                in_node = input.NodeId ?? string.Empty
            };
            Wa2F2w wa2f2w = new Wa2F2w();

            //execute geocall and finalize response
            GeoCaller.GeoCall(ref wa1, ref wa2f2w);

            return new GeocallResponse<F2Display, F2Response>
            {
                display = new F2Display(wa1, wa2f2w, GeoCaller),
                root = null
            };
        }
        public GeocallResponse<F3cDisplay, F3cResponse> Function3C(FunctionInput input)
        {
            Wa1 wa1 = new Wa1
            {
                in_func_code = "3C",
                in_platform_ind = "C",
                in_auxseg_switch = "Y",
                in_mode_switch = "E",

                in_boro1 = ValidationHelper.ValidateBoroInput(input.Borough1),
                in_stname1 = input.OnStreet?.Replace(" and ", " & ") ?? string.Empty,
                in_compass_dir = input.CompassFlag ?? string.Empty,
                in_boro2 = ValidationHelper.ValidateBoroInput(input.Borough2),
                in_stname2 = input.FirstCrossStreet?.Replace(" and ", " & ") ?? string.Empty,
                in_boro3 = ValidationHelper.ValidateBoroInput(input.Borough3),
                in_stname3 = input.SecondCrossStreet?.Replace(" and ", " & ") ?? string.Empty,
                in_browse_flag = input.BrowseFlag ?? string.Empty
            };
            Wa2F3ceas wa2f3ceas = new Wa2F3ceas();

            GeoCaller.GeoCall(ref wa1, ref wa2f3ceas);

            return new GeocallResponse<F3cDisplay, F3cResponse>
            {
                display = new F3cDisplay(wa1, wa2f3ceas, GeoCaller)
                {
                    LowB7SCList = ValidationHelper.CreateB7ScList(wa2f3ceas.wa2f3ce.lo_x_sts, wa1.out_stname_list, wa2f3ceas.wa2f3ce.lo_x_sts_cnt, 0, GeoCaller),
                    HighB7SCList = ValidationHelper.CreateB7ScList(wa2f3ceas.wa2f3ce.hi_x_sts, wa1.out_stname_list, wa2f3ceas.wa2f3ce.hi_x_sts_cnt, 5, GeoCaller)
                },
                root = null
            };
        }

        public GeocallResponse<F3sDisplay, F3sResponse> Function3S(FunctionInput input)
        {
            Wa1 wa1 = new Wa1
            {
                in_func_code = "3S",
                in_platform_ind = "C",

                in_stname1 = input.OnStreet?.Replace(" and ", " & ") ?? string.Empty,
                in_stname2 = input.FirstCrossStreet?.Replace(" and ", "&") ?? string.Empty,
                in_stname3 = input.SecondCrossStreet?.Replace(" and ", "&") ?? string.Empty,

                in_compass_dir = input.CompassDir ?? string.Empty,
                in_compass_dir2 = input.CompassDir2 ?? string.Empty,
                in_real_street_only = input.RealStreetFlag ?? string.Empty,
                in_roadbed_request_switch = input.RoadBed ?? string.Empty
            };
            Wa2F3s wa2f3s = new Wa2F3s();

            //marshall validated inputs into wa1
            if (string.IsNullOrEmpty(input.B10SC1))
            {
                wa1.in_b10sc1.boro = ValidationHelper.ValidateBoroInput(input.Borough);
            }
            else
            {
                wa1.in_b10sc1.B10scFromString(input.B10SC1 ?? string.Empty);
                wa1.in_b10sc2.B10scFromString(input.B10SC2 ?? string.Empty);
                wa1.in_b10sc3.B10scFromString(input.B10SC3 ?? string.Empty);
            }

            //geocall and finalize responses
            GeoCaller.GeoCall(ref wa1, ref wa2f3s);

            return new GeocallResponse<F3sDisplay, F3sResponse>
            {
                display = new F3sDisplay(wa1, wa2f3s, GeoCaller),
                root = null
            };
        }

        public GeocallResponse<F3Display, F3Response> Function3(FunctionInput input)
        {
            Wa1 wa1 = new Wa1
            {
                in_platform_ind = "C",
                in_auxseg_switch = "Y",
                in_mode_switch = "E",

                in_boro1 = ValidationHelper.ValidateBoroInput(input.Borough1),
                in_stname1 = input.OnStreet?.Replace(" and ", " & ") ?? string.Empty,
                in_compass_dir = input.SideOfStreet ?? string.Empty,
                in_boro2 = ValidationHelper.ValidateBoroInput(input.Borough2),
                in_stname2 = input.FirstCrossStreet?.Replace(" and ", " & ") ?? string.Empty,
                in_boro3 = ValidationHelper.ValidateBoroInput(input.Borough3),
                in_stname3 = input.SecondCrossStreet?.Replace(" and ", " & ") ?? string.Empty,
                in_browse_flag = input.BrowseFlag ?? string.Empty
            };

            wa1.in_func_code = "3";
            Wa2F3eas wa2f3eas = new Wa2F3eas();
            GeoCaller.GeoCall(ref wa1, ref wa2f3eas);

            return new GeocallResponse<F3Display, F3Response>
            {
                display = new F3Display(wa1, wa2f3eas, GeoCaller)
                {
                    LowB7SCList = ValidationHelper.CreateB7ScList(wa2f3eas.wa2f3e.lo_x_sts, wa1.out_stname_list, wa2f3eas.wa2f3e.lo_x_sts_cnt, 0, GeoCaller),
                    HighB7SCList = ValidationHelper.CreateB7ScList(wa2f3eas.wa2f3e.hi_x_sts, wa1.out_stname_list, wa2f3eas.wa2f3e.hi_x_sts_cnt, 5, GeoCaller),
                },
                root = null
            };
        }

        public GeocallResponse<F5Display, F5Response> Function5(FunctionInput input)
        {
            Wa1 wa1 = new Wa1
            {
                in_func_code = "5",
                in_platform_ind = "C",

                in_hnd = input.HighAddressNo ?? string.Empty,
                in_low_hnd = input.LowAddressNo ?? string.Empty
            };

            Wa2F5 wa2f5 = new Wa2F5();

            if (string.IsNullOrWhiteSpace(input.StCode))
            {
                wa1.in_b10sc1.Clear();
                wa1.in_boro1 = ValidationHelper.ValidateBoroInput(input.Borough);
                wa1.in_stname1 = input.StreetName?.Replace(" and ", " & ") ?? string.Empty;
            }
            else
            {
                wa1.in_b10sc1.Clear();
                wa1.in_b10sc1.B10scFromString(input.StCode ?? string.Empty);
                wa1.in_stname1 = string.Empty;
            }

            GeoCaller.GeoCall(ref wa1, ref wa2f5);

            return new GeocallResponse<F5Display, F5Response> 
            {
                display = new F5Display(wa1, wa2f5),
                root = null
            };
        }

        public GeocallResponse<FapDisplay, FapResponse> FunctionAP(FunctionInput input)
        {
            Wa1 wa1 = new Wa1()
            {
                in_func_code = "AP",
                in_platform_ind = "C",
                in_mode_switch = "X",

                in_b10sc1 = new B10sc { boro = ValidationHelper.ValidateBoroInput(input.Borough) },
                in_zip_code = input.ZipCode ?? string.Empty,
                in_stname1 = input.StreetName?.Replace(" and ", " & ") ?? string.Empty,
                in_unit = input.Unit ?? string.Empty
            };
            Wa2Fapx wa2fapx = new Wa2Fapx();

            if (string.Equals(input.Hns, "true", StringComparison.OrdinalIgnoreCase) || string.Equals(input.Hns, "y", StringComparison.OrdinalIgnoreCase))
            {
                wa1.in_hnd = string.Empty;
                wa1.in_hns = input.AddressNo ?? string.Empty;
            }
            else
            {
                wa1.in_hnd = input.AddressNo ?? string.Empty;
                wa1.in_hns = string.Empty;
            }

            //geocall and finalize response
            GeoCaller.GeoCall(ref wa1, ref wa2fapx);

            return new GeocallResponse<FapDisplay, FapResponse>
            {
                display = new FapDisplay(wa1, wa2fapx),
                root = null
            };
        }

        public GeocallResponse<FBBLDisplay, FBBLResponse> FunctionBBL(FunctionInput input)
        {
            Wa1 wa1 = new Wa1
            {
                in_mode_switch = "X",
                in_func_code = "BL",
                in_platform_ind = "C",

                in_tpad_switch = input.TPad ?? string.Empty
            };
            Wa2F1ax wa2f1ax = new Wa2F1ax();

            //marshall validated inputs into wa1
            if (string.IsNullOrWhiteSpace(input.BBL))
            {
                wa1.in_bbl.Clear();
                wa1.in_b10sc1.boro = ValidationHelper.ValidateBoroInput(input.Borough);
                wa1.in_bbl = new BBL
                {
                    block = input.Block ?? string.Empty,
                    lot = input.Lot ?? string.Empty
                };
            }
            else
            {
                wa1.in_bbl.Clear();
                wa1.in_bbl.BBLFromString(input.BBL);
            }

            //geocall and finalize responses
            GeoCaller.GeoCall(ref wa1, ref wa2f1ax);

            return new GeocallResponse<FBBLDisplay, FBBLResponse>
            {
                display = new FBBLDisplay(wa1, wa2f1ax, GeoCaller)
                {
                    AddressRangeList = ValidationHelper.CreateAddressRangeList(wa2f1ax.addr_x_list, wa1.in_tpad_switch),
                    CompleteBINList = ValidationHelper.CreateCompleteBINList(wa1, wa2f1ax, wa1.in_tpad_switch, FunctionCode.FBBL, GeoCaller),
                },
                root = null
            };
        }

        public GeocallResponse<FBBDisplay, FBBResponse> FunctionBB(FunctionInput input)
        {
            Wa1 wa1 = new Wa1
            {
                in_func_code = "BB",

                in_boro1 = ValidationHelper.ValidateBoroInput(input.Borough),
                in_stname1 = input.StreetName?.Replace(" and ", " & ") ?? string.Empty,
                in_browse_flag = input.BrowseFlag ?? string.Empty,
            };

            GeoCaller.GeoCall(ref wa1);

            return new GeocallResponse<FBBDisplay, FBBResponse>
            {
                display = new FBBDisplay(wa1),
                root = null
            };

        }

        public GeocallResponse<FBFDisplay, FBFResponse> FunctionBF(FunctionInput input)
        {
            Wa1 wa1 = new Wa1
            {
                in_func_code = "BF",

                in_boro1 = ValidationHelper.ValidateBoroInput(input.Borough),
                in_stname1 = input.StreetName?.Replace(" and ", " & ") ?? string.Empty,
                in_browse_flag = input.BrowseFlag ?? string.Empty
            };

            //geocall and finalize responses
            GeoCaller.GeoCall(ref wa1);

            return new GeocallResponse<FBFDisplay, FBFResponse>
            {
                display = new FBFDisplay(wa1),
                root = null
            };
        }
        public GeocallResponse<FBNDisplay, FBNResponse> FunctionBIN(FunctionInput input)
        {
            Wa1 wa1 = new Wa1
            {
                in_mode_switch = "X",
                in_func_code = "BN",
                in_platform_ind = "C",

                in_tpad_switch = input.TPad ?? string.Empty
            };
            Wa2F1ax wa2f1ax = new Wa2F1ax();

            //marshall validated inputs into wa1
            string binTrimmed = input.Bin?.Trim() ?? string.Empty;
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
            GeoCaller.GeoCall(ref wa1, ref wa2f1ax);

            return new GeocallResponse<FBNDisplay, FBNResponse>
            {
                display = new FBNDisplay(wa1, wa2f1ax, GeoCaller)
                {
                    AddressRangeList = ValidationHelper.CreateAddressRangeList(wa2f1ax.addr_x_list, wa1.in_tpad_switch)
                },
                root = null
            };
        }

        public GeocallResponse<FDDisplay, FDResponse> FunctionD(FunctionInput input)
        {
            Wa1 wa1 = new Wa1()
            {
                in_platform_ind = "C",

                in_snl = input.StreetNameLength ?? string.Empty,
                in_stname_normalization = input.StreetNameFormat ?? string.Empty
            };
            if (!string.IsNullOrWhiteSpace(input.B10SC1))
            {
                int length = string.IsNullOrWhiteSpace(input.Borough)
                    ? input.B10SC1.Trim().Length
                    : input.B10SC1.Trim().Length + 1; //if boro is present, it contributes one character to the string length

                if (length < 7)
                    wa1.in_func_code = "D";
                else if (length > 6 && length < 9)
                    wa1.in_func_code = "DG";
                else if (length > 8)
                    wa1.in_func_code = "DN";
            }

            if (string.IsNullOrWhiteSpace(input.Borough))
                wa1.in_b10sc1.B10scFromString(input.B10SC1.Trim());
            else
                wa1.in_b10sc1.B10scFromString(input.Borough + input.B10SC1.Trim());

            if (string.IsNullOrWhiteSpace(input.Borough2))
                wa1.in_b10sc2.B10scFromString(input.B10SC2.Trim());
            else
                wa1.in_b10sc2.B10scFromString(input.Borough2 + input.B10SC2.Trim());

            if (string.IsNullOrWhiteSpace(input.Borough3))
                wa1.in_b10sc3.B10scFromString(input.B10SC3.Trim());
            else
                wa1.in_b10sc3.B10scFromString(input.Borough3 + input.B10SC3.Trim());

            //geocall and finalize responses
            GeoCaller.GeoCall(ref wa1);
            
            return new GeocallResponse<FDDisplay, FDResponse>
            {
                display = new FDDisplay(wa1),
                root = null
            };
        }

        public GeocallResponse<FHRDisplay, FHRResponse> FunctionHR()
        {
            Wa1 wa1 = new Wa1
            {
                in_func_code = "HR"
            };
            Wa2Fhr wa2fhr = new Wa2Fhr();

            //geocall and finalize responses
            GeoCaller.GeoCall(ref wa1, ref wa2fhr);

            return new GeocallResponse<FHRDisplay, FHRResponse>
            {
                display = new FHRDisplay(wa1, wa2fhr),
                root = null
            }; 
        }

        public GeocallResponse<FNDisplay, FNResponse> FunctionN(FunctionInput input)
        {
            Wa1 wa1 = new Wa1
            {
                in_func_code = "N*",

                in_stname1 = input.StreetName?.Replace(" and ", " & ") ?? string.Empty,
                in_snl = input.StreetNameLength ?? string.Empty,
                in_stname_normalization = input.StreetNameFormat ?? string.Empty
            };

            GeoCaller.GeoCall(ref wa1);

            return new GeocallResponse<FNDisplay, FNResponse>
            {
                display = new FNDisplay(wa1),
                root = null
            };
        }
    }
}
