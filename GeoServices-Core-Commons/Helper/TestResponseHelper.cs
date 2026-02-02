using GeoServices_Core_Commons.Entity;
using GeoServices_Core_Commons.Entity.Models;
using GeoServices_Core_Commons.Model;
using GeoServices_Core_Commons.Model.Settings;
using GeoXWrapperLib.Model;
using GeoXWrapperTest.Model;
using GeoXWrapperTest.Model.Enum;
using GeoXWrapperTest.Model.Structs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Configuration;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Reflection;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GeoXWrapperTest.Helper
{
    public static class TestResponseHelper
    {
        public static bool Debug_On { get; set; } = true;
        public static StreamWriter Writer { get; set; } = new StreamWriter(Directory.GetCurrentDirectory() + $"\\TestFunction\\PerformanceTest", append: true);

        public static IEnumerable<object[]> Inputs_Generator(FunctionCode code)
        {
            switch (code)
            {
                case FunctionCode.F1L:
                    {
                        yield return new object[] { new AddrInput(addrNo: "a120"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response1.json")) };
                        yield return new object[] { new AddrInput(addrNo: "*120"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response2.json")) };
                        yield return new object[] { new AddrInput(addrNo: "\\120"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response3.json")) };
                        yield return new object[] { new AddrInput(addrNo: "120*-*120"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response4.json")) };
                        yield return new object[] { new AddrInput(addrNo: "120a"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response5.json")) };
                        break;
                    }
                    ;
                case FunctionCode.F1R:
                    {
                        yield return new object[] { new AddrInput(addrNo: "a120"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response1.json")) };
                        yield return new object[] { new AddrInput(addrNo: "*120"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response2.json")) };
                        yield return new object[] { new AddrInput(addrNo: "\\120"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response3.json")) };
                        yield return new object[] { new AddrInput(addrNo: "120*-*120"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response4.json")) };
                        yield return new object[] { new AddrInput(addrNo: "120a"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response5.json")) };
                        break;
                    }
                    ;
                case FunctionCode.F2:
                    {
                        yield return new object[] { new IntrsctInput("1", "Broadway", "Stone St"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response1.json")) };
                        yield return new object[] { new IntrsctInput("2", "Morris Ave", "E 144th St"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response2.json")) };
                        yield return new object[] { new IntrsctInput("3", "Prospect Park West", "Prospect Park Southwest"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response3.json")) };
                        yield return new object[] { new IntrsctInput("4", "Main St", "Roosevelt Ave"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response4.json")) };
                        yield return new object[] { new IntrsctInput("5", "Seaview Ave", "Mason Ave"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response5.json")) };
                        break;
                    }
                    ;
                case FunctionCode.F3:
                    {
                        yield return new object[] { new CrossStreetInputs("1", "Broadway", "Duane St", "Reade St"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response1.json")) };
                        yield return new object[] { new CrossStreetInputs("2", "Park Ave", "E 144 St", "E 149 St"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response2.json")) };
                        yield return new object[] { new CrossStreetInputs("3", "Lafayette Ave", "St Felix St", "Ashland Pl"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response3.json")) };
                        yield return new object[] { new CrossStreetInputs("4", "Park Lane S", "Metropolitan Ave", "Park Lane"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response4.json")) };
                        yield return new object[] { new CrossStreetInputs("5", "Forest Hill Rd", "Dewhurst St", "Drysdale St"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response5.json")) };
                        break;
                    }
                    ;

                case FunctionCode.F3C:
                    {
                        yield return new object[] { new CrossStreetInputs("1", "Broadway", "Stone St", "Beaver St", "E"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response1.json")) };
                        yield return new object[] { new CrossStreetInputs("2", "E 181st St", "Daly Ave", "Vyse Ave", "N"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response2.json")) };
                        yield return new object[] { new CrossStreetInputs("3", "5th Ave", "30th St", "29th St", "N"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response3.json")) };
                        yield return new object[] { new CrossStreetInputs("4", "147th St", "68th Ave", "68th Rd", "E"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response4.json")) };
                        yield return new object[] { new CrossStreetInputs("5", "Nome Ave", "Purdue St", "Rockne St", "N"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response5.json")) };
                        break;
                    }
                    ;
                case FunctionCode.F3S:
                    {
                        yield return new object[] { new CrossStreetInputs("1", "Broadway", "Fulton St", "Pine St"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response1.json")) };
                        yield return new object[] { new CrossStreetInputs("2", "Park Ave", "E 144th St", "E 149 St"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response2.json")) };
                        yield return new object[] { new CrossStreetInputs("3", "Lafayette Ave", "St Felix St", "Ashland Pl"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response3.json")) };
                        yield return new object[] { new CrossStreetInputs("4", "Park Ln S", "Metropolitan Ave", "Myrtle Ave"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response4.json")) };
                        yield return new object[] { new CrossStreetInputs("5", "Forest Hill Rd", "Dewhurst St", "Drysdale St"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response5.json")) };
                        break;
                    }
                    ;

                case FunctionCode.F5:
                    {
                        yield return new object[] { new HighLowAddrInput("1", "104", "120", "Broadway"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response1.json")) };
                        yield return new object[] { new HighLowAddrInput("2", "100", "200", "E 178th st"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response2.json")) };
                        yield return new object[] { new HighLowAddrInput("3", "100", "200", "Flatbush Ave"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response3.json")) };
                        yield return new object[] { new HighLowAddrInput("4", "100", "200", "Hillside Ave"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response4.json")) };
                        yield return new object[] { new HighLowAddrInput("5", "100", "200", "Westwood Ave"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response5.json")) };

                        break;
                    }
                    ;

                case FunctionCode.FBBL:
                    {
                        yield return new object[] { new BBLInput("1", "47", "7501"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response1.json")) };
                        yield return new object[] { new BBLInput("2", "02343", "0032"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response2.json")) };
                        yield return new object[] { new BBLInput("3", "01118", "0001"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response3.json")) };
                        yield return new object[] { new BBLInput("4", "01860", "0100"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response4.json")) };
                        yield return new object[] { new BBLInput("5", "00002", "0001"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response5.json")) };
                        break;
                    }
                    ;

                case FunctionCode.FBB:
                    {
                        yield return new object[] { new SndEntry { out_b7sc = "11117003", out_boro_name1 = "1", out_stname1 = "BRIDLE PATH NORTH               " }, File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response1.json")) };
                        yield return new object[] { new SndEntry { out_b7sc = "11117004", out_boro_name1 = "1", out_stname1 = "BRIDLE PATH SOUTH               " }, File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response2.json")) };
                        yield return new object[] { new SndEntry { out_b7sc = "11117005", out_boro_name1 = "1", out_stname1 = "BRIDLE PATH WEST                " }, File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response3.json")) };
                        yield return new object[] { new SndEntry { out_b7sc = "11117006", out_boro_name1 = "1", out_stname1 = "BRIDLE PTH W OV   65 TRNVS EB EN" }, File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response4.json")) };
                        yield return new object[] { new SndEntry { out_b7sc = "11252516", out_boro_name1 = "1", out_stname1 = "BRINCKERHOFF HALL               " }, File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response5.json")) };
                        break;
                    }
                    ;

                case FunctionCode.FBF:
                    {
                        yield return new object[] { new SndEntry { out_b7sc = "11117003", out_boro_name1 = "1", out_stname1 = "BRIDLE PATH NORTH               " }, File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response1.json")) };
                        yield return new object[] { new SndEntry { out_b7sc = "11117004", out_boro_name1 = "1", out_stname1 = "BRIDLE PATH SOUTH               " }, File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response2.json")) };
                        yield return new object[] { new SndEntry { out_b7sc = "11117005", out_boro_name1 = "1", out_stname1 = "BRIDLE PATH WEST                " }, File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response3.json")) };
                        yield return new object[] { new SndEntry { out_b7sc = "11117006", out_boro_name1 = "1", out_stname1 = "BRIDLE PTH W OV   65 TRNVS EB EN" }, File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response4.json")) };
                        yield return new object[] { new SndEntry { out_b7sc = "11252516", out_boro_name1 = "1", out_stname1 = "BRINCKERHOFF HALL               " }, File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response5.json")) };
                        break;
                    }
                    ;
                case FunctionCode.FBIN:
                    {
                        yield return new object[] { "11026", File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response1.json")) };
                        yield return new object[] { "21019", File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response2.json")) };
                        yield return new object[] { "445999", File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response3.json")) };
                        yield return new object[] { "1001026", File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response4.json")) };
                        yield return new object[] { "2001019", File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response5.json")) };
                        break;
                    }
                    ;
                case FunctionCode.FD:
                    {
                        yield return new object[] {
                            new StCodeCase(
                            boro1: "1",
                            b10Sc1: "1361001010",
                            boro2: "1",
                            b10Sc2: "3405001010",
                            boro3: "1",
                            b10Sc3: "1061004010",
                            expectedStCodes: new List<StreetCode> {
                                new StreetCode
                                {
                                    b10sc = new B10sc
                                    {
                                        boro = "1",
                                        lgc = "01",
                                        sc5 = "13610",
                                        spv = "010"
                                    },
                                    b10sc_toString = "11361001010",
                                    borough = "Manhattan",
                                    gft = "Unhyphenated",
                                    streetName = "BROADWAY                        "
                                },
                                new StreetCode
                                {
                                    b10sc = new B10sc
                                    {
                                        boro = "1",
                                        lgc = "01",
                                        sc5 = "34050",
                                        spv = "010"
                                    },
                                    b10sc_toString = "13405001010",
                                    borough = "Manhattan",
                                    gft = "Unhyphenated",
                                    streetName = "WEST   14 STREET                "
                                },
                                new StreetCode
                                {
                                    b10sc = new B10sc
                                    {
                                        boro = "1",
                                        lgc = "04",
                                        sc5 = "10610",
                                        spv = "010"
                                    },
                                    b10sc_toString = "11061004010",
                                    borough = "Manhattan",
                                    gft = "Unhyphenated",
                                    streetName = "   7 AVENUE                     "
                                }
                            },
                            expectedCompactStNames: new List<string>{ "BROADWAY                        ","WEST 14 STREET                  ","7 AVENUE                        "}
                        ), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response1.json")) };

                        break;
                    }
                    ;

                case FunctionCode.FHR:
                    {
                        yield return new object[] { File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function" + ReturnFunctionCode(code), "Function" + ReturnFunctionCode(code) + "Response1.json")) };

                        break;
                    }
                    ;

                case FunctionCode.ALL:
                    yield return new object[] { new AddrInput(boro: "1", addrNo: "120", sortFormatAddrNo: "000120000AA", stName: "Broadway", stNameLength: "4", zip: "10271", unit: "30A", nodeId: "0027962") };
                    yield return new object[] { new IntrsctInput("1", "Broadway", "Stone St") };
                    yield return new object[] { new CrossStreetInputs("1", "Broadway", "Duane St", "Reade St") };
                    yield return new object[] { new HighLowAddrInput("1", "104", "120", "Broadway") };
                    yield return new object[] { new BBLInput("1", "47", "7501") };
                    yield return new object[] { new SndEntry { out_b7sc = "11117003", out_boro_name1 = "1", out_stname1 = "BRIDLE PATH NORTH" } };
                    yield return new object[] { "11026" };

                    break;

                default:
                    {
                        yield return new object[]
                        {
                            new AddrInput(
                                            boro: "1",
                                            addrNo: "120",
                                            sortFormatAddrNo: "000120000AA",
                                            stName: "Broadway",
                                            stNameLength: "4",
                                            zip: "10271",
                                            unit: "30A",
                                            nodeId: "0027962"
                                        ), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function"+ReturnFunctionCode(code), "Function"+ReturnFunctionCode(code)+"Response1.json"))

                        };

                        yield return new object[]
                        {
                            new AddrInput(
                                            boro: "2",
                                            addrNo: "500",
                                            sortFormatAddrNo: "000500000AA",
                                            stName: "Grand Concourse",
                                            stNameLength: "6",
                                            zip: "10451",
                                            unit: "123",
                                            nodeId: "0027963"
                                        ), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function"+ReturnFunctionCode(code), "Function"+ReturnFunctionCode(code)+"Response2.json"))

                        };

                        yield return new object[]
                        {
                            new AddrInput(
                                            boro: "3",
                                            addrNo: "620",
                                            sortFormatAddrNo: "000620000AA",
                                            stName: "Atlantic Ave",
                                            stNameLength: "32",
                                            zip: "11217",
                                            unit: "A",
                                            nodeId: "0027964"
                                        ), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function"+ReturnFunctionCode(code), "Function"+ReturnFunctionCode(code)+"Response3.json"))

                         };
                        yield return new object[]
                        {
                            new AddrInput(
                                            boro: "4",
                                            addrNo: "90-15",
                                            sortFormatAddrNo: "100090015AA",
                                            stName: "Queens Blvd",
                                            stNameLength: "33",
                                            zip: "11373",
                                            unit: "Z2",
                                            nodeId: "0027965"
                                        ), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function"+ReturnFunctionCode(code), "Function"+ReturnFunctionCode(code)+"Response4.json"))

                        };
                        yield return new object[]
                        {
                            new AddrInput(
                                            boro: "5",
                                            addrNo: "475",
                                            sortFormatAddrNo: "000475000AA",
                                            stName: "Seaview Ave",
                                            stNameLength: "99",
                                            zip: "10305",
                                            unit: "99",
                                            nodeId: "0027966"
                                        ), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Results", "Function"+ReturnFunctionCode(code), "Function"+ReturnFunctionCode(code)+"Response5.json"))

                        };

                        break;

                    }

            }
        }

        public static IEnumerable<object[]> AddrInput_Generator()
        {
            yield return new object[] { "a120", "" };
            yield return new object[] { "*120", "" };
            yield return new object[] { "\\120", "" };
            yield return new object[] { "120*-*120", "" };
            yield return new object[] { "120a", "" };

        }

        private static string ReturnFunctionCode(FunctionCode code)
        {
            switch (code)
            {
                case FunctionCode.F1A:
                    return "1A";
                case FunctionCode.F1B:
                    return "1B";
                case FunctionCode.F1E:
                    return "1E";
                case FunctionCode.F1L:
                    return "1L";
                case FunctionCode.F1R:
                    return "1R";
                case FunctionCode.F1N:
                    return "1N";
                case FunctionCode.F2:
                    return "2";
                case FunctionCode.F2Node:
                    return "2Node";
                case FunctionCode.F2W:
                    return "2W";
                case FunctionCode.F3:
                    return "3";
                case FunctionCode.F3C:
                    return "3C";
                case FunctionCode.F3S:
                    return "3S";
                case FunctionCode.F5:
                    return "5";
                case FunctionCode.FAP:
                    return "AP";
                case FunctionCode.FBBL:
                    return "BBL";
                case FunctionCode.FBB:
                    return "BB";
                case FunctionCode.FBIN:
                    return "BIN";
                case FunctionCode.FBF:
                    return "BF";
                case FunctionCode.FD:
                    return "D";
                case FunctionCode.FN:
                    return "N";
                case FunctionCode.FHR:
                    return "HR";
                case FunctionCode.ALL:
                    return "ALL";
                default:
                    return string.Empty;
            }
        }

        public static bool ValidateInputResults(string[] actualInputs, string[] expectedInputs, string functionFileName)
        {
            var falseSwitch = false;

            var actualInputParts = actualInputs[1].Substring(1, actualInputs[1].Length - 1).Split(",").ToList();
            var expectedInputsParts = expectedInputs[1].Substring(1, expectedInputs[1].Length - 1).Split(",").ToList();

            expectedInputsParts = expectedInputsParts.Where(w => w.Count(c => c == ':') > 1).Select(s =>
            {
                var indexes = new List<int>();
                for (int i = 0; i < s.Length; i++)
                    if (s.ToCharArray()[i] == ':')
                        indexes.Add(i);
                return s.Substring(indexes[indexes.Count - 2] + 1);
            }).ToList();

            List<string> actualInputParts_NonMatch;
            List<string> expectedInputParts_NonMatch;
            List<string[]> errorList = new List<string[]>();

            actualInputParts_NonMatch = actualInputParts.Where(a => !expectedInputsParts.Contains(a)).ToList();
            expectedInputParts_NonMatch = expectedInputsParts.Where(e => !actualInputParts.Contains(e)).ToList();

            expectedInputParts_NonMatch.ForEach((enm) =>
            {
                var enmparts = Regex.Replace(enm, @"[\[\]\{\}]", "").Split(':');
                var enmRightPart = Regex.Replace(enm, @"[\]\}]", "");
                var anmParts = string.Join(" ", actualInputParts_NonMatch.Where(anm => Regex.Replace(anm, @"[\[\]\{\}]", "").Contains(enmparts[0])).ToList());
                anmParts = Regex.Replace(anmParts, @"[\[\]\{\}]", "");
                try
                {
                    if (anmParts.Length == 0)
                    {
                        errorList.Add(new string[] { "ENEP", $"{{ {enmparts[0]} : {enmparts[1]} }}" });
                        falseSwitch = true;
                    }
                    else if (!actualInputParts.Contains(enmRightPart))
                    {
                        if (enmparts.Count() == 1 && !anmParts.Contains(enmparts[0]))
                        {
                            errorList.Add(new string[] { "ENMV", $"{{ Actual: {anmParts} , Expected: {enmparts[0]} }}" });
                            falseSwitch = true;
                        }
                        else if (!anmParts.Contains(enmparts[1]) && !string.IsNullOrWhiteSpace(enmparts[1]) && enmparts[1].Length > 0 && enmparts[1] != "[]" && enmparts[1] != @"""""" && enmparts[1] != @"""""}" && enmparts[1] != @"""""]")
                        {

                            if (!((anmParts.Split(":")[1].Length - enmparts[1].Length == 2 || anmParts.Split(":")[1].Length - enmparts[1].Length == -2) && (anmParts.Split(" ")[1].ToLower().Contains("th") || enmparts[1].ToLower().Contains("TH"))))
                            {
                                errorList.Add(new string[] { "ENMV", $"{{ Actual: {anmParts} , Expected: {enmparts[1]} }}" });
                                falseSwitch = true;
                            }
                        }
                        else if (!anmParts.Contains(enmparts[1]))
                        {
                            errorList.Add(new string[] { "WNMV", $"{{ Actual: {anmParts} , Expected: {enmparts[1]} }}" });
                        }
                    }
                }
                catch (Exception e)
                {
                    errorList.Add(new string[] { "Exceptions", $"{{ message:{e.Message}, stacktrace: {e.StackTrace}}}" });
                }
            });

            actualInputParts_NonMatch.Where(anm => !expectedInputParts_NonMatch.Contains(Regex.Replace(anm, @"[\[\]\{\}]", "").Split(":")[0]))
                                   .ToList()
                                    .ForEach(e => errorList.Add(new string[] { "WNCL", $"new: {e}" }));

            if (Debug_On)
            {
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + $"\\TestFunction\\{functionFileName}", append: true))
                {

                    writer.WriteLine(actualInputs[0] + "|" + actualInputs[1]);
                    writer.WriteLine(expectedInputs[0] + "|" + expectedInputs[1]);

                    writer.WriteLine("-------------- Error! No Existing Parameter in Actual ----------------------");
                    errorList.Where(e => e[0].Equals("ENEP")).ToList().ForEach(e => writer.WriteLine(e[1]));

                    writer.WriteLine("-------------- Error! No Matching Value in Actual ----------------------");
                    errorList.Where(e => e[0].Equals("ENMV")).ToList().ForEach(e => writer.WriteLine(e[1]));

                    writer.WriteLine("-------------- Warning! No Matching Value in Actual ----------------------");
                    errorList.Where(e => e[0].Equals("WNMV")).ToList().ForEach(e => writer.WriteLine(e[1]));

                    writer.WriteLine("-------------- Warning! Parameter Not Contained in Legacy ----------------------");
                    errorList.Where(e => e[0].Equals("WNCL")).ToList().ForEach(e => writer.WriteLine(e[1]));

                    writer.Write("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n");

                    writer.WriteLine("-------------- Error! Stacktrace ----------------------");
                    errorList.Where(e => e[0].Equals("Exceptions")).ToList().ForEach(e => writer.WriteLine(e[1]));

                    writer.Write("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n");
                }
            }

            return !falseSwitch;
        }

        public static void IncrementFailCounter(ref PassFailCounter pfCounter) => ++pfCounter.fail;

        public static void IncrementTestCounter(ref PassFailCounter pfCounter, IActionResult response)
        {
            if (response is OkObjectResult ok) ++pfCounter.pass; else ++pfCounter.fail;
        }

        public static void LogTestCounter(PassFailCounter pfCounter, Stopwatch stopWatch, double threshCounter, ref PerformanceLog log) {
            
                log.Pass = pfCounter.pass;
                log.Fail = pfCounter.fail;
                log.CallsPerSecond = threshCounter / stopWatch.Elapsed.TotalSeconds;
                log.CallsPerHour = threshCounter / stopWatch.Elapsed.TotalHours;
                log.DateTime = DateTime.Now;

                using (var context = new DatabaseContext().Build())
                {
                    try
                    {
                        context.PerformanceLogs.Add(log);
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Caught Error:\n{ex.Message}\n Retrying by Detatching Entities and saving individually modified..");
                        log.RequestMessage = ex.Message;
                    }

            }

            if (Debug_On)
            {
                Writer.Write($"\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n");
                Writer.Write($"Pass: {pfCounter.pass}\nFail: {pfCounter.fail}\nCallsPerSecond: {threshCounter/stopWatch.Elapsed.TotalSeconds}\nCallsPerHour: {threshCounter/stopWatch.Elapsed.TotalHours}");
                Writer.Write($"\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n");
            }
        }
    }
}
