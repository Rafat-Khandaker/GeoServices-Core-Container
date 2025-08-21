using GeoXWrapperLib.Model;
using GeoXWrapperTest.Model.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoXWrapperTest.Model
{
    public static class CaseSource
    {

        /// <summary>
        /// All address numbers in sort format must be 11 length
        /// </summary>
        public static int SortFmtLength => 11; //sort format must always be 11 chars

        /// <summary>
        /// Possible browse flag inputs
        /// </summary>
        public static IEnumerable<string> BrowseFlagInputs
        {
            get
            {
                yield return "P";
                yield return "F";
                yield return "R";
                yield return " ";
                yield return "PPP"; //GeoX only reads the first char
                yield return string.Empty;
                yield return null;
            }
        }

        /// <summary>
        /// Address Function data list test cases - contains inputs as well as expected Address Range Key dictionary, Address Range list, and Complete BINs list, as well as TPAD variants
        /// </summary>
        public static IEnumerable<ArBinCase> AddrRange_Bins_ListTests
        {
            get
            {
                //1 - 120 BROADWAY
                yield return new ArBinCase(
                    //inputs
                    boro: "1",
                    addrNo: "120",
                    stName: "broadway",
                    block: "47",
                    lot: "7501",
                    bin: "1001026",
                    //expected outputs
                    expectedAddrRangeKeys: new Dictionary<string, string>
                    {
                        ["N"] = "Non-Addressable Place Name",
                        ["X"] = "Constituent NAP of Complex",
                        [string.Empty] = "Ordinary Address Range"
                    },
                    expectedARL_NoTPAD: new List<AddressRange>
                    {
                        new AddressRange
                        {
                            b7sc = "11361001",
                            bin = "1001026",
                            high_address_number = "             124",
                            low_address_number = "             104",
                            street_name = "BROADWAY                        ",
                            tpad_bin_status = "N/A",
                            type = " ",
                            type_meaning = "Ordinary Address Range"
                        },
                        new AddressRange
                        {
                            b7sc = "11441001",
                            bin = "1001026",
                            high_address_number = "              84",
                            low_address_number = "              70",
                            street_name = "CEDAR STREET                    ",
                            tpad_bin_status = "N/A",
                            type = " ",
                            type_meaning = "Ordinary Address Range"
                        },
                        new AddressRange
                        {
                            b7sc = "12507696",
                            bin = "1001026",
                            high_address_number = "                ",
                            low_address_number = "                ",
                            street_name = "NYU BRENNAN CENTER FOR JUSTICE  ",
                            tpad_bin_status = "N/A",
                            type = "X",
                            type_meaning = "Constituent NAP of Complex"
                        },
                        new AddressRange
                        {
                            b7sc = "12710001",
                            bin = "1001026",
                            high_address_number = "              25",
                            low_address_number = "              15",
                            street_name = "NASSAU STREET                   ",
                            tpad_bin_status = "N/A",
                            type = " ",
                            type_meaning = "Ordinary Address Range"
                        },
                        new AddressRange
                        {
                            b7sc = "12887001",
                            bin = "1001026",
                            high_address_number = "              16",
                            low_address_number = "               2",
                            street_name = "PINE STREET                     ",
                            tpad_bin_status = "N/A",
                            type = " ",
                            type_meaning = "Ordinary Address Range"
                        },
                        new AddressRange
                        {
                            b7sc = "10110901",
                            bin = "1001026",
                            high_address_number = "                ",
                            low_address_number = "                ",
                            street_name = "EQUITABLE BUILDING              ",
                            tpad_bin_status = "N/A",
                            type = "N",
                            type_meaning = "Non-Addressable Place Name"
                        }
                    },
                    expectedARL_TPAD: new List<AddressRange>
                    {
                        new AddressRange
                        {
                            b7sc = "11361001",
                            bin = "1001026",
                            high_address_number = "             124",
                            low_address_number = "             104",
                            street_name = "BROADWAY                        ",
                            tpad_bin_status = "No activity",
                            type = " ",
                            type_meaning = "Ordinary Address Range"
                        },
                        new AddressRange
                        {
                            b7sc = "11441001",
                            bin = "1001026",
                            high_address_number = "              84",
                            low_address_number = "              70",
                            street_name = "CEDAR STREET                    ",
                            tpad_bin_status = "No activity",
                            type = " ",
                            type_meaning = "Ordinary Address Range"
                        },
                        new AddressRange
                        {
                            b7sc = "12507696",
                            bin = "1001026",
                            high_address_number = "                ",
                            low_address_number = "                ",
                            street_name = "NYU BRENNAN CENTER FOR JUSTICE  ",
                            tpad_bin_status = "No activity",
                            type = "X",
                            type_meaning = "Constituent NAP of Complex"
                        },
                        new AddressRange
                        {
                            b7sc = "12710001",
                            bin = "1001026",
                            high_address_number = "              25",
                            low_address_number = "              15",
                            street_name = "NASSAU STREET                   ",
                            tpad_bin_status = "No activity",
                            type = " ",
                            type_meaning = "Ordinary Address Range"
                        },
                        new AddressRange
                        {
                            b7sc = "12887001",
                            bin = "1001026",
                            high_address_number = "              16",
                            low_address_number = "               2",
                            street_name = "PINE STREET                     ",
                            tpad_bin_status = "No activity",
                            type = " ",
                            type_meaning = "Ordinary Address Range"
                        },
                        new AddressRange
                        {
                            b7sc = "10110901",
                            bin = "1001026",
                            high_address_number = "                ",
                            low_address_number = "                ",
                            street_name = "EQUITABLE BUILDING              ",
                            tpad_bin_status = "No activity",
                            type = "N",
                            type_meaning = "Non-Addressable Place Name"
                        }
                    },
                    expectedBins_NoTPAD: new List<CompleteBIN>
                    {
                        new CompleteBIN
                        {
                            bin = "1001026",
                            tpad = null
                        }
                    },
                    expectedBins_TPAD: new List<CompleteBIN>
                    {
                        new CompleteBIN
                        {
                            bin = "1001026",
                            tpad = "No activity"
                        }
                    }
                );
            }
        }

        /// <summary>
        /// Similar test cases for us in the Address Functions. Street name must be deliverately mispelled, but needs to be intelligible enough to trigger a pick up on potential similar names. Contains expected similar names list
        /// </summary>
        public static IEnumerable<SimNameCase> SimName_ListTests
        {
            get
            {
                //1 - 120 croadway
                yield return new SimNameCase(
                    boro: "1",
                    addrNo: "120",
                    badStName: "croadway",
                    expectedSimNames: new List<SimilarName>
                    {
                        new SimilarName
                        {
                            b7sc = "11615001",
                            streetName = "CROSBY STREET                   "
                        },
                        new SimilarName
                        {
                            b7sc = "19753001",
                            streetName = "CROSS BRONX EXPRESSWAY          "
                        },
                        new SimilarName
                        {
                            b7sc = "11616001",
                            streetName = "CROTON AQUEDUCT                 "
                        }
                    }
                );
            }
        }

        /// <summary>
        /// BBL inputs for use in FBL
        /// </summary>
        public static IEnumerable<BBLInput> BblInputs
        {
            get
            {
                yield return new BBLInput("1", "47", "7501"); //shorthand
                yield return new BBLInput("1", "00047", "7501");
                yield return new BBLInput("2", "02343", "0032");
                yield return new BBLInput("3", "01118", "0001");
                yield return new BBLInput("4", "01860", "0100");
                yield return new BBLInput("5", "00002", "0001");
            }
        }

        /// <summary>
        /// BIN inputs for use in FBN
        /// </summary>
        public static IEnumerable<string> BinInputs
        {
            get
            {
                yield return "1001026";
                yield return "2001019";
                yield return "3398156";
                yield return "4045999";
                yield return "5141706";
            }
        }

        /// <summary>
        /// "Shorthand" BIN inputs for FBN - no zero padding after the 0-index to bring the length up to 7
        /// </summary>
        public static IEnumerable<string> ShortBinInputs
        {
            get
            {
                yield return "11026";
                yield return "21019";
                yield return "445999";
            }
        }

        /// <summary>
        /// Street Code test cases for use in FD - inputs as well as expected lists
        /// </summary>
        public static IEnumerable<StCodeCase> StCodeTests
        {
            get
            {
                yield return new StCodeCase(
                    boro1: "1",
                    b10Sc1: "1361001010",
                    boro2: "1",
                    b10Sc2: "3405001010",
                    boro3: "1",
                    b10Sc3: "1061004010",
                    expectedStCodes: new List<StreetCode>
                    {
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
                    expectedCompactStNames: new List<string>
                    {
                        "BROADWAY                        ",
                        "WEST 14 STREET                  ",
                        "7 AVENUE                        "
                    }
                );
            }
        }

        /// <summary>
        /// Node Id inputs for use in F2Node
        /// </summary>
        public static IEnumerable<string> NodeIdInputs
        {
            get
            {
                yield return "0027962";
                yield return "9035638";
                yield return "9053084";
                yield return "9064070";
            }
        }

        public static IEnumerable<IntrsctInput> IntrsctInputs
        {
            get
            {
                yield return new IntrsctInput("1", "Broadway", "Stone St");
                yield return new IntrsctInput("2", "Morris Ave", "E 144th St");
                yield return new IntrsctInput("3", "Prospect Park West", "Prospect Park Southwest");
                yield return new IntrsctInput("4", "Main St", "Roosevelt Ave");
                yield return new IntrsctInput("5", "Seaview Ave", "Mason Ave");
            }
        }

        public static IEnumerable<IntrsctInput> NamedIntrsctInputs
        {
            get
            {
                yield return new IntrsctInput("1", "Riverside Drive", "W 95th St", namedAlt: "Shimon Peres Place");
                yield return new IntrsctInput("2", "Fordham Road", "Grand Concourse", namedAlt: "Big Pun Plaza");
                yield return new IntrsctInput("3", "Ocean Ave", "Ave V", namedAlt: "Rabbi Melvin I. Burg Way");
                yield return new IntrsctInput("4", "192nd st", "67th ave", namedAlt: "Sylvia Weprin Way");
                yield return new IntrsctInput("5", "Mark's Place", "Hyatt St", namedAlt: "Roberta Bobbie Jacobowitz Way");
            }
        }

        public static IEnumerable<IntrsctInput> CompassIntrsctInputs
        {
            get
            {
                yield return new IntrsctInput("1", "9 Ave", "W 207 St", compass: "N");
                yield return new IntrsctInput("2", "Castle Hill Ave", "E 177 St", compass: "N");
                yield return new IntrsctInput("3", "Commercial St", "Box St", compass: "E");
                yield return new IntrsctInput("4", "Hollis Ave", "205 St", compass: "S");
                yield return new IntrsctInput("5", "David Pl", "Dead End", compass: "W");
            }
        }

        public static IEnumerable<Grc03IntrsctCase> Grc03Tests
        {
            get
            {
                //MN - Manhattan Cruise Terminal Ramp & Bend
                yield return new Grc03IntrsctCase(
                    input: new IntrsctInput("1", "Manhattan Cruise Terminal Ramp", "Bend"),
                    expectedB7scs: new List<string>
                    {
                        "10000901",
                        "11311301",
                        "10000901",
                        "11311301",
                        "10000901",
                        "11311301",
                        "10000901",
                        "11311301",
                        "10000901",
                        "11311301",
                        "10000901",
                        "11311301"
                    },
                    expectedB7scStarts: new List<int> { 0, 2, 4, 6, 8, 10 },
                    expectedNodes: new List<string>
                    {
                        "0095337",
                        "9035637",
                        "9035638",
                        "9035645",
                        "9035646",
                        "9035657"
                    },
                    expectedCrxSts: new List<string>
                    {
                        "MANHATTAN CRUISE TERMINAL RAMP",
                        "BEND",
                        "MANHATTAN CRUISE TERMINAL RAMP",
                        "BEND",
                        "MANHATTAN CRUISE TERMINAL RAMP",
                        "BEND",
                        "MANHATTAN CRUISE TERMINAL RAMP",
                        "BEND",
                        "MANHATTAN CRUISE TERMINAL RAMP",
                        "BEND",
                        "MANHATTAN CRUISE TERMINAL RAMP",
                        "BEND"
                    },
                    expectedCrxStarts: new List<int> { 0, 2, 4, 6, 8, 10 }
                );

                //MN - Central Park Bow Bridge & Central Park Lake Shoreline
                yield return new Grc03IntrsctCase(
                    input: new IntrsctInput("1", "Central Park Bow Bridge", "Central Park Lake Shoreline"),
                    expectedB7scs: new List<string>
                    {
                        "10072617",
                        "10072601",
                        "13049719",
                        "13049701",
                        "10072619",
                        "13049705",
                        "13049701",
                        "10072620",
                        "10072601",
                        "13049705",
                        "13049701",
                        "10072620",
                        "10072605",
                        "13049705",
                        "13049701",
                        "10072620",
                        "10072605",
                        "13049705",
                        "13049701"
                    },
                    expectedB7scStarts: new List<int> { 0, 4, 7, 11, 15 },
                    expectedNodes: new List<string>
                    {
                        "9047555",
                        "9053082",
                        "9053084",
                        "9064069",
                        "9064070"
                    },
                    expectedCrxSts: new List<string>
                    {
                        "CENTRAL PARK POOL PATH,CENTRAL PARK PATH",
                        "CENTRAL PARK LOCH SHORELINE,BODY OF WATER",
                        "CENTRAL PARK BOW BRIDGE",
                        "CENTRAL PARK LAKE SHORELINE,BODY OF WATER",
                        "CENTRAL PARK BOW BRIDGE PATH,CENTRAL PARK PATH",
                        "CENTRAL PARK LAKE SHORELINE,BODY OF WATER",
                        "CENTRAL PARK BOW BRIDGE PATH,THE RAMBLE PATH",
                        "CENTRAL PARK LAKE SHORELINE,BODY OF WATER",
                        "CENTRAL PARK BOW BRIDGE PATH,THE RAMBLE PATH",
                        "CENTRAL PARK LAKE SHORELINE,BODY OF WATER"
                    },
                    expectedCrxStarts: new List<int> { 0, 2, 4, 6, 8 }
                );
            }
        }

        public static IEnumerable<StSegInput> SegmentInputs
        {
            get
            {
                throw new NotImplementedException(); // FIXME
            }
        }
    }
}
