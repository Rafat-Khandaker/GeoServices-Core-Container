using GeoServices_Core_Commons.Core;
using GeoServices_Core_Commons.Core.Contract;
using GeoServices_Core_Commons.Entity.Models;
using GeoServices_Core_Commons.Helper;
using GeoServices_Core_Commons.Model;
using GeoServices_Core_Commons.Model.Settings;
using GeoServices_Core_Web_API.Controllers;
using GeoXWrapperLib;
using GeoXWrapperLib.Model;
using GeoXWrapperTest.Helper;
using GeoXWrapperTest.Model;
using GeoXWrapperTest.Model.Display;
using GeoXWrapperTest.Model.Enum;
using GeoXWrapperTest.Model.Response;
using GeoXWrapperTest.Model.Structs;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Testing.Platform.Configurations;
using System.Diagnostics;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace GeoXWrapperTest
{
    [TestClass]
    public sealed class FunctionTests
    {
        private IServiceProvider ServiceProvider;

        IGeoService GeoService;
        AccessControlList AccessControl;
        Cryptographer CryptographerService;
        Microsoft.Extensions.Configuration.IConfiguration Configuration;

        [TestInitialize]
        public void TestInit()
        {

            Configuration = new ConfigurationBuilder()
                                    .SetBasePath(Directory.GetCurrentDirectory())
                                    .AddJsonFile("appsettings.json", optional: false)
                                    .Build();

            // Setup the DI container   // Set up the Dependency Injection container
            ServiceProvider = new ServiceCollection()
                .AddSingleton<Microsoft.Extensions.Configuration.IConfiguration>(Configuration)
                .AddSingleton<IGeoCaller, GeoCaller>()
                .AddSingleton<AccessControlList, AccessControlList>()
                .AddSingleton<Geo, Geo>()
                .AddSingleton<IGeoService, GeoService>()
                .AddSingleton<ValidationHelper, ValidationHelper>()
                .AddSingleton<Cryptographer, Cryptographer>()
                .BuildServiceProvider();

            GeoService = ServiceProvider.GetService<IGeoService>();
            AccessControl = ServiceProvider.GetService<AccessControlList>();
            CryptographerService = ServiceProvider.GetService<Cryptographer>();

            Directory.GetFiles(Directory.GetCurrentDirectory() + $"\\TestFunction").ToList().ForEach(f => File.Delete(f));

            TestResponseHelper.Debug_On = true; 

            

        }

        public static IEnumerable<object[]> F1A_AddrInputs => TestResponseHelper.Inputs_Generator(FunctionCode.F1A);

        [TestMethod]
        [DynamicData(nameof(F1A_AddrInputs), DynamicDataSourceType.Property)]
        public void Function1A(AddrInput input, string output)
        {
            var result = JsonSerializer.Serialize(
                                            GeoService.Function1A(new FunctionInput{
                                                Borough = input.Boro,
                                                AddressNo = input.AddrNo,
                                                StreetName = input.StName,
                                                ZipCode = input.Zip,
                                                Unit = input.Unit,
                                                DisplayFormat = "false"
                                            }));

            

            var actual = Regex.Replace(result, @"[\r\t\n\s]+", "");
            var expected = Regex.Replace(output, @"[\r\t\n\s]+", "");

            var actualHash = CryptographerService.HashString(actual);
            var expectedHash = CryptographerService.HashString(expected);

            // Uncomment for Debugging Unit Tests for Errors. Read Logs in Debug Folder
            using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Results_1A", append: true))
            {
                writer.WriteLine(actualHash+"|"+actual);
                writer.WriteLine(expectedHash+"|"+expected);
            }

            if (actualHash.Equals(expectedHash))
                Assert.AreEqual(actualHash, expectedHash);

            else
                Assert.IsTrue(TestResponseHelper.ValidateInputResults(new string[] { actualHash, actual }, new string[] { expectedHash, expected }, "Results_1A"));
        }

        public static IEnumerable<object[]> F1B_AddrInputs => TestResponseHelper.Inputs_Generator(FunctionCode.F1B);

        [TestMethod]
        [DynamicData(nameof(F1B_AddrInputs), DynamicDataSourceType.Property)]
        public void Function1B(AddrInput input, string output)
        {
            var result = JsonSerializer.Serialize(
                                            GeoService.Function1B(new FunctionInput{
                                                Borough = input.Boro,
                                                AddressNo = input.AddrNo,
                                                StreetName = input.StName,
                                                DisplayFormat = "false"
                                            }));



            var actual = Regex.Replace(result, @"[\r\t\n\s]+", "");
            var expected = Regex.Replace(output, @"[\r\t\n\s]+", "");

            var actualHash = CryptographerService.HashString(actual);
            var expectedHash = CryptographerService.HashString(expected);

            if (actualHash.Equals(expectedHash))
                Assert.AreEqual(actualHash, expectedHash);

            else
                Assert.IsTrue(TestResponseHelper.ValidateInputResults(new string[] { actualHash, actual }, new string[] { expectedHash, expected }, "Results_1B"));
        }

        public static IEnumerable<object[]> F1E_AddrInputs => TestResponseHelper.Inputs_Generator(FunctionCode.F1E);

        [TestMethod]
        [DynamicData(nameof(F1E_AddrInputs), DynamicDataSourceType.Property)]
        public void Function1E(AddrInput input, string output)
        {
            var result = JsonSerializer.Serialize(
                                            GeoService.Function1E(new FunctionInput{
                                                Borough = input.Boro,
                                                AddressNo = input.AddrNo,
                                                StreetName = input.StName,
                                                ZipCode = input.Zip,
                                                Unit = input.Unit,
                                                DisplayFormat = "false"
                                            }));


            var actual = Regex.Replace(result, @"[\r\t\n\s]+", "");
            var expected = Regex.Replace(output, @"[\r\t\n\s]+", "");

            var actualHash = CryptographerService.HashString(actual);
            var expectedHash = CryptographerService.HashString(expected);

            if (actualHash.Equals(expectedHash))
                Assert.AreEqual(actualHash, expectedHash);

            else
                Assert.IsTrue(TestResponseHelper.ValidateInputResults(new string[] { actualHash, actual }, new string[] { expectedHash, expected }, "Results_1E"));
        }

        public static IEnumerable<object[]> F1L_AddrInputs => TestResponseHelper.Inputs_Generator(FunctionCode.F1L);

        [TestMethod]
        [DynamicData(nameof(F1L_AddrInputs), DynamicDataSourceType.Property)]
        public void Function1L(AddrInput input, string output)
        {
            var result = JsonSerializer.Serialize(
                                            GeoService.Function1L(new FunctionInput
                                            {
                                                Borough = input.Boro,
                                                AddressNo = input.AddrNo,
                                                StreetName = input.StName,
                                                ZipCode = input.Zip,
                                                Unit = input.Unit,
                                                DisplayFormat = "false"
                                            }));


            var actual = Regex.Replace(result, @"[\r\t\n\s]+", "");
            var expected = Regex.Replace(output, @"[\r\t\n\s]+", "");

            var actualHash = CryptographerService.HashString(actual);
            var expectedHash = CryptographerService.HashString(expected);

            if (actualHash.Equals(expectedHash))
                Assert.AreEqual(actualHash, expectedHash);

            else
                Assert.IsTrue(TestResponseHelper.ValidateInputResults(new string[] { actualHash, actual }, new string[] { expectedHash, expected }, "Results_1L"));
        }

        public static IEnumerable<object[]> F1N_AddrInputs => TestResponseHelper.Inputs_Generator(FunctionCode.F1N);

        [TestMethod]
        [DynamicData(nameof(F1N_AddrInputs), DynamicDataSourceType.Property)]
        public void Function1N(AddrInput input, string output)
        {
            var result = JsonSerializer.Serialize(
                                            GeoService.Function1N(new FunctionInput{
                                                Borough = input.Boro,
                                                AddressNo = input.AddrNo,
                                                StreetName = input.StName,
                                                StreetNameLength = input.StNameLength,
                                                ZipCode = input.Zip,
                                                Unit = input.Unit,
                                                DisplayFormat = "false"
                                            }));


            var actual = Regex.Replace(result, @"[\r\t\n\s]+", "");
            var expected = Regex.Replace(output, @"[\r\t\n\s]+", "");

            var actualHash = CryptographerService.HashString(actual);
            var expectedHash = CryptographerService.HashString(expected);

            if (actualHash.Equals(expectedHash))
                Assert.AreEqual(actualHash, expectedHash);

            else
                Assert.IsTrue(TestResponseHelper.ValidateInputResults(new string[] { actualHash, actual }, new string[] { expectedHash, expected }, "Results_1N"));
        }

        public static IEnumerable<object[]> F1R_AddrInputs => TestResponseHelper.Inputs_Generator(FunctionCode.F1R);

        [TestMethod]
        [DynamicData(nameof(F1R_AddrInputs), DynamicDataSourceType.Property)]
        public void Function1R(AddrInput input, string output)
        {
            var result = JsonSerializer.Serialize(
                                            GeoService.Function1R(new FunctionInput{
                                                Borough = input.Boro,
                                                AddressNo = input.AddrNo,
                                                StreetName = input.StName,
                                                StreetNameLength = input.StNameLength,
                                                ZipCode = input.Zip,
                                                Unit = input.Unit,
                                                DisplayFormat = "true"
                                            }));


            var actual = Regex.Replace(result, @"[\r\t\n\s]+", "");
            var expected = Regex.Replace(output, @"[\r\t\n\s]+", "");

            var actualHash = CryptographerService.HashString(actual);
            var expectedHash = CryptographerService.HashString(expected);

            if (actualHash.Equals(expectedHash))
                Assert.AreEqual(actualHash, expectedHash);

            else
                Assert.IsTrue(TestResponseHelper.ValidateInputResults(new string[] { actualHash, actual }, new string[] { expectedHash, expected }, "Results_1R"));
        }

        public static IEnumerable<object[]> F2Node_AddrInputs => TestResponseHelper.Inputs_Generator(FunctionCode.F2Node); 
 
        [TestMethod]
        [DynamicData(nameof(F2Node_AddrInputs), DynamicDataSourceType.Property)]
        public void Function2Node(AddrInput input, string output)
        {
            var result = JsonSerializer.Serialize(
                                            GeoService.Function2NodeId(new FunctionInput{
                                                NodeId = input.NodeId,
                                                DisplayFormat = "true"
                                            }));


            var actual = Regex.Replace(result, @"[\r\t\n\s]+", "");
            var expected = Regex.Replace(output, @"[\r\t\n\s]+", "");

            var actualHash = CryptographerService.HashString(actual);
            var expectedHash = CryptographerService.HashString(expected);

            if (actualHash.Equals(expectedHash))
                Assert.AreEqual(actualHash, expectedHash);

            else
                Assert.IsTrue(TestResponseHelper.ValidateInputResults(new string[] { actualHash, actual }, new string[] { expectedHash, expected }, "Results_2Node"));
        }

        public static IEnumerable<object[]> F2_IntrsctInput => TestResponseHelper.Inputs_Generator(FunctionCode.F2); 
 
        [TestMethod]
        [DynamicData(nameof(F2_IntrsctInput), DynamicDataSourceType.Property)]
        public void Function2(IntrsctInput input, string output)
        {
            var result = JsonSerializer.Serialize(
                                            GeoService.Function2(new FunctionInput{
                                                Borough1 = input.Boro,
                                                Street1 = input.St1,
                                                Borough2 = input.Boro,
                                                Street2 = input.St2,
                                                DisplayFormat = "true"
                                            }));

            var actual = Regex.Replace(result, @"[\r\t\n\s]+", "");
            var expected = Regex.Replace(output, @"[\r\t\n\s]+", "");

            var actualHash = CryptographerService.HashString(actual);
            var expectedHash = CryptographerService.HashString(expected);

            if (actualHash.Equals(expectedHash))
                Assert.AreEqual(actualHash, expectedHash);

            else
                Assert.IsTrue(TestResponseHelper.ValidateInputResults(new string[] { actualHash, actual }, new string[] { expectedHash, expected }, "Results_2"));
        }

        public static IEnumerable<object[]> F3C_IntrsctInput => TestResponseHelper.Inputs_Generator(FunctionCode.F3C);

        [TestMethod]
        [DynamicData(nameof(F3C_IntrsctInput), DynamicDataSourceType.Property)]
        public void Function3C(CrossStreetInputs input, string output)
        {
            var result = JsonSerializer.Serialize(GeoService.Function3_F3C(new FunctionInput{
                                                    Borough1 = input.Borough1,
                                                    OnStreet= input.OnStreet,
                                                    FirstCrossStreet = input.FirstCrossStreet,
                                                    SecondCrossStreet = input.SecondCrossStreet,
                                                    SideOfStreet = input.CompassDirection,
                                                    CompassFlag = input.CompassDirection,
                                                    DisplayFormat = "true"
                                                }));

            var actual = Regex.Replace(result, @"[\r\t\n\s]+", "");
            var expected = Regex.Replace(output, @"[\r\t\n\s]+", "");

            var actualHash = CryptographerService.HashString(actual);
            var expectedHash = CryptographerService.HashString(expected);

            if (actualHash.Equals(expectedHash))
                Assert.AreEqual(actualHash, expectedHash);

            else
                Assert.IsTrue(TestResponseHelper.ValidateInputResults(new string[] { actualHash, actual }, new string[] { expectedHash, expected }, "Results_3C"));
        }

        public static IEnumerable<object[]> F3S_IntrsctInput => TestResponseHelper.Inputs_Generator(FunctionCode.F3S);

        [TestMethod]
        [DynamicData(nameof(F3S_IntrsctInput), DynamicDataSourceType.Property)]
        public void Function3S(CrossStreetInputs input, string output)
        {
            var result = JsonSerializer.Serialize(GeoService.Function3S(new FunctionInput{
                                                        Borough = input.Borough1,
                                                        OnStreet = input.OnStreet,
                                                        FirstCrossStreet = input.FirstCrossStreet,
                                                        SecondCrossStreet = input.SecondCrossStreet,
                                                        DisplayFormat = "true"
                                                    }));

            var actual = Regex.Replace(result, @"[\r\t\n\s]+", "");
            var expected = Regex.Replace(output, @"[\r\t\n\s]+", "");

            var actualHash = CryptographerService.HashString(actual);
            var expectedHash = CryptographerService.HashString(expected);

            // Uncomment for Debugging Unit Tests for Errors. Read Logs in Debug Folder

            if (actualHash.Equals(expectedHash))
                Assert.AreEqual(actualHash, expectedHash);

            else
                Assert.IsTrue(TestResponseHelper.ValidateInputResults(new string[] { actualHash, actual }, new string[] { expectedHash, expected }, "Results_3S"));
        }

        public static IEnumerable<object[]> F3_IntrsctInput => TestResponseHelper.Inputs_Generator(FunctionCode.F3);

        [TestMethod]
        [DynamicData(nameof(F3_IntrsctInput), DynamicDataSourceType.Property)]
        public void Function3(CrossStreetInputs input, string output)
        {
            var result = JsonSerializer.Serialize(GeoService.Function3_F3(new FunctionInput {
                Borough1 = input.Borough1,
                OnStreet = input.OnStreet,
                Borough2 = input.Borough1,
                FirstCrossStreet = input.FirstCrossStreet,
                Borough3 = input.Borough1,
                SecondCrossStreet = input.SecondCrossStreet,
                CompassFlag = input.CompassDirection,
                DisplayFormat = "true"
            }));

            var actual = Regex.Replace(result, @"[\r\t\n\s]+", "");
            var expected = Regex.Replace(output, @"[\r\t\n\s]+", "");

            var actualHash = CryptographerService.HashString(actual);
            var expectedHash = CryptographerService.HashString(expected);

            if (actualHash.Equals(expectedHash))
                Assert.AreEqual(actualHash, expectedHash);

            else
                Assert.IsTrue(TestResponseHelper.ValidateInputResults(new string[] { actualHash, actual } , new string[] { expectedHash, expected }, "Results_3_F3"));
        }

        public static IEnumerable<object[]> F5_HighLowAddrInput => TestResponseHelper.Inputs_Generator(FunctionCode.F5);

        [TestMethod]
        [DynamicData(nameof(F5_HighLowAddrInput), DynamicDataSourceType.Property)]
        public void Function5(HighLowAddrInput input, string output)
        {
            var result = JsonSerializer.Serialize(GeoService.Function5(new FunctionInput{
                                            Borough = input.Borough,
                                            LowAddressNo = input.LowAddressNo,
                                            HighAddressNo = input.HighAddressNo,
                                            StreetName = input.StreetName,
                                            DisplayFormat = "true"
                                        }));

            var actual = Regex.Replace(result, @"[\r\t\n\s]+", "");
            var expected = Regex.Replace(output, @"[\r\t\n\s]+", "");

            var actualHash = CryptographerService.HashString(actual);
            var expectedHash = CryptographerService.HashString(expected);

            if (actualHash.Equals(expectedHash))
                Assert.AreEqual(actualHash, expectedHash);

            else
                Assert.IsTrue(TestResponseHelper.ValidateInputResults(new string[] { actualHash, actual }, new string[] { expectedHash, expected }, "Results_5"));
        }

        public static IEnumerable<object[]> FAP_AddrInputs => TestResponseHelper.Inputs_Generator(FunctionCode.FAP);

        [TestMethod]
        [DynamicData(nameof(FAP_AddrInputs), DynamicDataSourceType.Property)]
        public void FunctionAP(AddrInput input, string output)
        {
            var result = JsonSerializer.Serialize(GeoService.FunctionAP(new FunctionInput{
                                                        Borough = input.Boro,
                                                        AddressNo = input.AddrNo,
                                                        StreetName = input.StName,
                                                        DisplayFormat = "true"
                                                    }));

            var actual = Regex.Replace(result, @"[\r\t\n\s]+", "");
            var expected = Regex.Replace(output, @"[\r\t\n\s]+", "");

            var actualHash = CryptographerService.HashString(actual);
            var expectedHash = CryptographerService.HashString(expected);

            if (actualHash.Equals(expectedHash))
                Assert.AreEqual(actualHash, expectedHash);

            else
                Assert.IsTrue(TestResponseHelper.ValidateInputResults(new string[] { actualHash, actual }, new string[] { expectedHash, expected }, "Results_AP"));
        }

        public static IEnumerable<object[]> FBBL_BBLInputs => TestResponseHelper.Inputs_Generator(FunctionCode.FBBL);

        [TestMethod]
        [DynamicData(nameof(FBBL_BBLInputs), DynamicDataSourceType.Property)]
        public void FunctionBBL( BBLInput input, string output)
        {
            var result = JsonSerializer.Serialize(GeoService.FunctionBBL(new FunctionInput{
                                                        Borough = input.Boro,
                                                        Block = input.Block,
                                                        Lot = input.Lot,
                                                        DisplayFormat = "true"
                                                    }));

            var actual = Regex.Replace(result, @"[\r\t\n\s]+", "");
            var expected = Regex.Replace(output, @"[\r\t\n\s]+", "");

            var actualHash = CryptographerService.HashString(actual);
            var expectedHash = CryptographerService.HashString(expected);

            if (actualHash.Equals(expectedHash))
                Assert.AreEqual(actualHash, expectedHash);

            else
                Assert.IsTrue(TestResponseHelper.ValidateInputResults(new string[] { actualHash, actual }, new string[] { expectedHash, expected }, "Results_BBL"));
        }

        public static IEnumerable<object[]> FBB_AddrInputs => TestResponseHelper.Inputs_Generator(FunctionCode.FBB);

        [TestMethod]
        [DynamicData(nameof(FBB_AddrInputs), DynamicDataSourceType.Property)]
        public void FunctionBB(SndEntry input, string output)
        {
            var result = JsonSerializer.Serialize(GeoService.FunctionBB(new FunctionInput{
                                                    Borough = input.out_boro_name1,
                                                    StreetName = input.out_stname1,
                                                    DisplayFormat = "true"
                                                }));

            var actual = Regex.Replace(result, @"[\r\t\n\s]+", "");
            var expected = Regex.Replace(output, @"[\r\t\n\s]+", "");

            var actualHash = CryptographerService.HashString(actual);
            var expectedHash = CryptographerService.HashString(expected);

            if (actualHash.Equals(expectedHash))
                Assert.AreEqual(actualHash, expectedHash);

            else
                Assert.IsTrue(TestResponseHelper.ValidateInputResults(new string[] { actualHash, actual }, new string[] { expectedHash, expected }, "Results_BB"));
        }
        public static IEnumerable<object[]> FBF_AddrInputs => TestResponseHelper.Inputs_Generator(FunctionCode.FBF);

        [TestMethod]
        [DynamicData(nameof(FBF_AddrInputs), DynamicDataSourceType.Property)]
        public void FunctionBF(SndEntry input, string output)
        {
            var result = JsonSerializer.Serialize(GeoService.FunctionBF(new FunctionInput{
                Borough = input.out_boro_name1,
                StreetName = input.out_stname1,
                DisplayFormat = "true"
            }));

            var actual = Regex.Replace(result, @"[\r\t\n\s]+", "");
            var expected = Regex.Replace(output, @"[\r\t\n\s]+", "");

            var actualHash = CryptographerService.HashString(actual);
            var expectedHash = CryptographerService.HashString(expected);

            if (actualHash.Equals(expectedHash))
                Assert.AreEqual(actualHash, expectedHash);

            else
                Assert.IsTrue(TestResponseHelper.ValidateInputResults(new string[] { actualHash, actual }, new string[] { expectedHash, expected }, "Results_BF"));
        }
        public static IEnumerable<object[]> FBIN_ShortBinInputs => TestResponseHelper.Inputs_Generator(FunctionCode.FBIN);

        [TestMethod]
        [DynamicData(nameof(FBIN_ShortBinInputs), DynamicDataSourceType.Property)]
        public void FunctionBIN(string input, string output)
        {
            var result = JsonSerializer.Serialize(GeoService.FunctionBIN(new FunctionInput{ 
                Bin = input,
                DisplayFormat = "true"
            }));

            var actual = Regex.Replace(result, @"[\r\t\n\s]+", "");
            var expected = Regex.Replace(output, @"[\r\t\n\s]+", "");

            var actualHash = CryptographerService.HashString(actual);
            var expectedHash = CryptographerService.HashString(expected);

            if (actualHash.Equals(expectedHash))
                Assert.AreEqual(actualHash, expectedHash);

            else
                Assert.IsTrue(TestResponseHelper.ValidateInputResults(new string[] { actualHash, actual }, new string[] { expectedHash, expected }, "Results_BIN"));
        }

        public static IEnumerable<object[]> FD_StCodeInputs => TestResponseHelper.Inputs_Generator(FunctionCode.FD);

        [TestMethod]
        [DynamicData(nameof(FD_StCodeInputs), DynamicDataSourceType.Property)]
        public void FunctionD(StCodeCase input, string output)
        {
            var result = JsonSerializer.Serialize(GeoService.FunctionD(new FunctionInput{
                                                        B10SC1 = input.FullB10Sc1,
                                                        B10SC2 = input.FullB10Sc2,
                                                        B10SC3 = input.FullB10Sc3,
                                                        DisplayFormat = "true"
                                                    }));

            var actual = Regex.Replace(result, @"[\r\t\n\s]+", "");
            var expected = Regex.Replace(output, @"[\r\t\n\s]+", "");

            var actualHash = CryptographerService.HashString(actual);
            var expectedHash = CryptographerService.HashString(expected);

            if (actualHash.Equals(expectedHash))
                Assert.AreEqual(actualHash, expectedHash);

            else
                Assert.IsTrue(TestResponseHelper.ValidateInputResults(new string[] { actualHash, actual }, new string[] { expectedHash, expected }, "Results_D"));
        }

        public static IEnumerable<object[]> FHR_AddrInputs => TestResponseHelper.Inputs_Generator(FunctionCode.FHR);

        [TestMethod]
        [DynamicData(nameof(FHR_AddrInputs), DynamicDataSourceType.Property)]
        public void FunctionHR(string output)
        {
            var result = JsonSerializer.Serialize(GeoService.FunctionHR(new FunctionInput { DisplayFormat = "true" }));

            var actual = Regex.Replace(result, @"[\r\t\n\s]+", "");
            var expected = Regex.Replace(output, @"[\r\t\n\s]+", "");

            var actualHash = CryptographerService.HashString(actual);
            var expectedHash = CryptographerService.HashString(expected);

            if (actualHash.Equals(expectedHash))
                Assert.AreEqual(actualHash, expectedHash);

            else
                Assert.IsTrue(TestResponseHelper.ValidateInputResults(new string[] { actualHash, actual }, new string[] { expectedHash, expected }, "Results_HR"));
        }

        public static IEnumerable<object[]> FN_AddrInputs => TestResponseHelper.Inputs_Generator(FunctionCode.FN);

        [TestMethod]
        [DynamicData(nameof(FN_AddrInputs), DynamicDataSourceType.Property)]
        public void FunctionN(AddrInput input, string output)
        {
            var result = JsonSerializer.Serialize(GeoService.FunctionN(new FunctionInput{
                StreetName = input.StName,
                StreetNameLength = input.StNameLength,
                DisplayFormat = "true"
            }));

            var actual = Regex.Replace(result, @"[\r\t\n\s]+", "");
            var expected = Regex.Replace(output, @"[\r\t\n\s]+", "");

            var actualHash = CryptographerService.HashString(actual);
            var expectedHash = CryptographerService.HashString(expected);

            if (actualHash.Equals(expectedHash))
                Assert.AreEqual(actualHash, expectedHash);

            else
                Assert.IsTrue(TestResponseHelper.ValidateInputResults(new string[] { actualHash, actual }, new string[] { expectedHash, expected }, "Results_N"));
        }

        public static List<object[]> ALL_Inputs => TestResponseHelper.Inputs_Generator(FunctionCode.ALL).ToList();

        [TestMethod]
        public void MultiThreadThreshTestAllFunctions()
        {
            var addr_input = (AddrInput)ALL_Inputs[0][0];
            var intrsct_input = (IntrsctInput)ALL_Inputs[1][0];
            var cross_street_input = (CrossStreetInputs)ALL_Inputs[2][0];
            var high_low_addr_input = (HighLowAddrInput)ALL_Inputs[3][0];
            var bbl_input = (BBLInput)ALL_Inputs[4][0];
            var snd_entry_input = (SndEntry)ALL_Inputs[5][0];
            var bin_input = (string)ALL_Inputs[6][0];

            var Function1A = new Function_1AController(AccessControl, GeoService);
            var Function1B = new Function_1BController(AccessControl, GeoService);
            var Function1E = new Function_1EController(AccessControl, GeoService);
            var Function1L = new Function_1LController(AccessControl, GeoService);
            var Function1N = new Function_1NController(AccessControl, GeoService);
            var Function1R = new Function_1RController(AccessControl, GeoService);
            var Function2NodeId = new Function_2_NodeIdController(AccessControl, GeoService);
            var Function2 = new Function_2Controller(AccessControl, GeoService);
            var Function3C = new Function_3CController(AccessControl, GeoService);
            var Function3S = new Function_3SController(AccessControl, GeoService);
            var Function5 = new Function_5Controller(AccessControl, GeoService);
            var FunctionAP = new Function_APController(AccessControl, GeoService);
            var FunctionBB = new Function_BBController(AccessControl, GeoService);
            var FunctionBBL = new Function_BBLController(AccessControl, GeoService);
            var FunctionBF = new Function_BFController(AccessControl, GeoService);
            var FunctionBIN = new Function_BINController(AccessControl, GeoService);
            var FunctionD = new Function_DController(AccessControl, GeoService);
            var FunctionHR = new Function_HRController(AccessControl, GeoService);
            var FunctionN = new Function_NController(AccessControl, GeoService);

            var mutexSettings = new SafeHandleMutex {
                Lock = bool.Parse(Configuration["SafeHandle:MutexSettings:Lock"]),
                Wait = int.Parse(Configuration["SafeHandle:MutexSettings:Wait"]),
                Max = int.Parse(Configuration["SafeHandle:MutexSettings:Max"]),
                Sleep = int.Parse(Configuration["SafeHandle:Sleep"]),
                Retry = int.Parse(Configuration["SafeHandle:Retry"])
            };

            var performanceLog =  new PerformanceLog();

            var thresh_hold = 100.00;

            var mutableCounter = new PassFailCounter{ pass = 0.00, fail = 0.00 };


            var stopWatch = Stopwatch.StartNew();

            while (thresh_hold > 0.00)
            {
                thresh_hold = thresh_hold - 1.00;
                Thread.Sleep(10);
                try
                {
                    Parallel.Invoke(
                            () => TestResponseHelper.IncrementTestCounter(ref mutableCounter, Function1A.Get("ivFXltO2g2W9OFlw", addr_input.Boro, addr_input.Zip, addr_input.AddrNo, addr_input.StName, string.Empty, string.Empty, addr_input.Unit, "n", "true")),
                            () => TestResponseHelper.IncrementTestCounter(ref mutableCounter, Function1B.Get("ivFXltO2g2W9OFlw", addr_input.Boro, addr_input.Zip, addr_input.AddrNo, addr_input.StName, string.Empty, string.Empty, addr_input.Unit, "n", "true")),
                            () => TestResponseHelper.IncrementTestCounter(ref mutableCounter, Function1E.Get("ivFXltO2g2W9OFlw", addr_input.Boro, addr_input.Zip, addr_input.AddrNo, addr_input.StName, string.Empty, string.Empty, addr_input.Unit, "n", "true")),
                            () => TestResponseHelper.IncrementTestCounter(ref mutableCounter, Function1L.Get("ivFXltO2g2W9OFlw", addr_input.AddrNo, "true")),
                            () => TestResponseHelper.IncrementTestCounter(ref mutableCounter, Function1N.Get("ivFXltO2g2W9OFlw", addr_input.Boro, addr_input.StName, addr_input.StNameLength)),
                            () => TestResponseHelper.IncrementTestCounter(ref mutableCounter, Function1R.Get("ivFXltO2g2W9OFlw", addr_input.AddrNo)),
                            () => TestResponseHelper.IncrementTestCounter(ref mutableCounter, Function2NodeId.Get("ivFXltO2g2W9OFlw", addr_input.NodeId)),
                            () => TestResponseHelper.IncrementTestCounter(ref mutableCounter, Function2.Get("ivFXltO2g2W9OFlw", intrsct_input.Boro, intrsct_input.St1, intrsct_input.Boro, intrsct_input.St2)),
                            () => TestResponseHelper.IncrementTestCounter(ref mutableCounter, Function3C.Get("ivFXltO2g2W9OFlw", addr_input.Boro, addr_input.Zip, addr_input.AddrNo, addr_input.StName, string.Empty, string.Empty, addr_input.Unit, "n", "true")),
                            () => TestResponseHelper.IncrementTestCounter(ref mutableCounter, Function3S.Get("ivFXltO2g2W9OFlw", addr_input.Boro, addr_input.Zip, addr_input.AddrNo, addr_input.StName, string.Empty, string.Empty, addr_input.Unit, "n", "true")),
                            () => TestResponseHelper.IncrementTestCounter(ref mutableCounter, Function5.Get("ivFXltO2g2W9OFlw", high_low_addr_input.Borough, high_low_addr_input.LowAddressNo, high_low_addr_input.HighAddressNo, high_low_addr_input.StreetName, high_low_addr_input.StCode)),
                            () => TestResponseHelper.IncrementTestCounter(ref mutableCounter, FunctionAP.Get("ivFXltO2g2W9OFlw", addr_input.Boro, addr_input.Zip, addr_input.AddrNo, addr_input.StName, addr_input.Unit)),
                            () => TestResponseHelper.IncrementTestCounter(ref mutableCounter, FunctionBB.Get("ivFXltO2g2W9OFlw", addr_input.Boro, addr_input.StName)),
                            () => TestResponseHelper.IncrementTestCounter(ref mutableCounter, FunctionBBL.Get("ivFXltO2g2W9OFlw", bbl_input.Boro, bbl_input.Block, bbl_input.Lot, bbl_input.Bbl)),
                            () => TestResponseHelper.IncrementTestCounter(ref mutableCounter, FunctionBF.Get("ivFXltO2g2W9OFlw", snd_entry_input.out_boro_name1, snd_entry_input.out_stname1)),
                            () => TestResponseHelper.IncrementTestCounter(ref mutableCounter, FunctionBIN.Get("ivFXltO2g2W9OFlw", bin_input)),
                            () => TestResponseHelper.IncrementTestCounter(ref mutableCounter, FunctionD.Get("ivFXltO2g2W9OFlw", addr_input.Boro, addr_input.Zip, addr_input.AddrNo, addr_input.StName, string.Empty, string.Empty, addr_input.Unit, "n", "true")),
                            () => TestResponseHelper.IncrementTestCounter(ref mutableCounter, FunctionHR.Get("ivFXltO2g2W9OFlw")),
                            () => TestResponseHelper.IncrementTestCounter(ref mutableCounter, FunctionN.Get("ivFXltO2g2W9OFlw", addr_input.StName))
                        );

                    performanceLog = new PerformanceLog() {
                                                    Mutex = bool.Parse(Configuration["SafeHandle:MutexSettings:Lock"]),
                                                    Wait = int.Parse(Configuration["SafeHandle:MutexSettings:Wait"]),
                                                    Max = int.Parse(Configuration["SafeHandle:MutexSettings:Max"]),
                                                    Sleep = int.Parse(Configuration["SafeHandle:Sleep"]),
                                                    Retry = int.Parse(Configuration["SafeHandle:Retry"])
                                                };
                 


                    TestResponseHelper.LogTestCounter(mutableCounter, stopWatch, thresh_hold, ref performanceLog);

                }
                catch (Exception e)
                {
                    TestResponseHelper.IncrementFailCounter(ref mutableCounter);
                }
            }

            stopWatch.Stop();


            Assert.IsTrue(true);

        }
    }
}
