using GeoXWrapperLib;
using GeoXWrapperTest.Helper;
using GeoXWrapperTest.Model;
using GeoXWrapperTest.Model.Display;
using GeoXWrapperTest.Model.Enum;
using GeoXWrapperTest.Model.Response;
using GeoXWrapperTest.Model.Structs;
using GeoXWrapperTest.Service;
using GeoXWrapperTest.Service.Contracts;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace GeoXWrapperTest
{
    [TestClass]
    public sealed class FunctionTests
    {
        private IServiceProvider ServiceProvider;

        IGeoService GeoService;

        [TestInitialize]
        public void TestInit()
        {
            // Setup the DI container   // Set up the Dependency Injection container
            ServiceProvider = new ServiceCollection()
                .AddSingleton<IGeoService, GeoService>()
                .AddSingleton<Geo, Geo>()
                .BuildServiceProvider();

            GeoService = ServiceProvider.GetService<IGeoService>();
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
                                                Unit = input.Unit
                                            }));

            

            var actual = Regex.Replace(result, @"[\r\t\n\s]+", "");
            var expected = Regex.Replace(output, @"[\r\t\n\s]+", "");

            // Uncomment for Debugging Unit Tests for Errors. Read Logs in Debug Folder
            using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Results_1A", append: true))
            {
                writer.WriteLine(actual);
                writer.WriteLine(expected);
            }
         

            Assert.AreEqual(actual, expected);
        }

        public static IEnumerable<object[]> F1B_AddrInputs => TestResponseHelper.Inputs_Generator(FunctionCode.F1B);

        [TestMethod]
        [DynamicData(nameof(F1B_AddrInputs), DynamicDataSourceType.Property)]
        public void Function1B(AddrInput input, string output)
        {
            var result = JsonSerializer.Serialize(
                                            GeoService.Function1B(new FunctionInput
                                            {
                                                Borough = input.Boro,
                                                AddressNo = input.AddrNo,
                                                StreetName = input.StName,
                                            }));



            var actual = Regex.Replace(result, @"[\r\t\n\s]+", "");
            var expected = Regex.Replace(output, @"[\r\t\n\s]+", "");

            
            // Uncomment for Debugging Unit Tests for Errors. Read Logs in Debug Folder
            using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory()+"\\Results_1B", append: true))
            {
                writer.WriteLine(actual);
                writer.WriteLine(expected);
            }
            

            Assert.AreEqual(actual, expected);
        }

        public static IEnumerable<object[]> F1E_AddrInputs => TestResponseHelper.Inputs_Generator(FunctionCode.F1E);

        [TestMethod]
        [DynamicData(nameof(F1E_AddrInputs), DynamicDataSourceType.Property)]
        public void Function1E(AddrInput input, string output)
        {
            var result = JsonSerializer.Serialize(
                                            GeoService.Function1E(new FunctionInput
                                            {
                                                Borough = input.Boro,
                                                AddressNo = input.AddrNo,
                                                StreetName = input.StName,
                                                ZipCode = input.Zip,
                                                Unit = input.Unit
                                            }));


            var actual = Regex.Replace(result, @"[\r\t\n\s]+", "");
            var expected = Regex.Replace(output, @"[\r\t\n\s]+", "");

           
            // Uncomment for Debugging Unit Tests for Errors. Read Logs in Debug Folder
            using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Results_1E", append: true))
            {
                writer.WriteLine(actual);
                writer.WriteLine(expected);
            }
        

            Assert.AreEqual(actual, expected);
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
                                                Unit = input.Unit
                                            }));


            var actual = Regex.Replace(result, @"[\r\t\n\s]+", "");
            var expected = Regex.Replace(output, @"[\r\t\n\s]+", "");


            // Uncomment for Debugging Unit Tests for Errors. Read Logs in Debug Folder
            using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Results_1L", append: true))
            {
                writer.WriteLine(actual);
                writer.WriteLine(expected);
            }


            Assert.AreEqual(actual, expected);
        }

        public static IEnumerable<object[]> F1N_AddrInputs => TestResponseHelper.Inputs_Generator(FunctionCode.F1N);

        [TestMethod]
        [DynamicData(nameof(F1N_AddrInputs), DynamicDataSourceType.Property)]
        public void Function1N(AddrInput input, string output)
        {
            var result = JsonSerializer.Serialize(
                                            GeoService.Function1N(new FunctionInput
                                            {
                                                Borough = input.Boro,
                                                AddressNo = input.AddrNo,
                                                StreetName = input.StName,
                                                StreetNameLength = input.StNameLength,
                                                ZipCode = input.Zip,
                                                Unit = input.Unit
                                            }));


            var actual = Regex.Replace(result, @"[\r\t\n\s]+", "");
            var expected = Regex.Replace(output, @"[\r\t\n\s]+", "");


            // Uncomment for Debugging Unit Tests for Errors. Read Logs in Debug Folder
            using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Results_1N", append: true))
            {
                writer.WriteLine(actual);
                writer.WriteLine(expected);
            }


            Assert.AreEqual(actual, expected);
        }

        public static IEnumerable<object[]> F1R_AddrInputs => TestResponseHelper.Inputs_Generator(FunctionCode.F1R);

        [TestMethod]
        [DynamicData(nameof(F1R_AddrInputs), DynamicDataSourceType.Property)]
        public void Function1R(AddrInput input, string output)
        {
            var result = JsonSerializer.Serialize(
                                            GeoService.Function1R(new FunctionInput
                                            {
                                                Borough = input.Boro,
                                                AddressNo = input.AddrNo,
                                                StreetName = input.StName,
                                                StreetNameLength = input.StNameLength,
                                                ZipCode = input.Zip,
                                                Unit = input.Unit
                                            }));


            var actual = Regex.Replace(result, @"[\r\t\n\s]+", "");
            var expected = Regex.Replace(output, @"[\r\t\n\s]+", "");


            // Uncomment for Debugging Unit Tests for Errors. Read Logs in Debug Folder
            using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Results_1R", append: true))
            {
                writer.WriteLine(actual);
                writer.WriteLine(expected);
            }


            Assert.AreEqual(actual, expected);
        }

        public static IEnumerable<object[]> F2Node_AddrInputs => TestResponseHelper.Inputs_Generator(FunctionCode.F2Node); 
 
        [TestMethod]
        [DynamicData(nameof(F2Node_AddrInputs), DynamicDataSourceType.Property)]
        public void Function2Node(AddrInput input, string output)
        {
            var result = JsonSerializer.Serialize(GeoService.Function2NodeId(new FunctionInput{ NodeId = input.NodeId }));

            var actual = Regex.Replace(result, @"[\r\t\n\s]+", "");
            var expected = Regex.Replace(output, @"[\r\t\n\s]+", "");


            // Uncomment for Debugging Unit Tests for Errors. Read Logs in Debug Folder
            using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Results_2Node", append: true))
            {
                writer.WriteLine(actual);
                writer.WriteLine(expected);
            }

            Assert.AreEqual(actual, expected);
        }

        public static IEnumerable<object[]> F2_IntrsctInput => TestResponseHelper.Inputs_Generator(FunctionCode.F2); 
 
        [TestMethod]
        [DynamicData(nameof(F2_IntrsctInput), DynamicDataSourceType.Property)]
        public void Function2(IntrsctInput input, string output)
        {
            var result = JsonSerializer.Serialize(GeoService.Function2(new FunctionInput
            {
                Borough1 = input.Boro,
                Street1 = input.St1,
                Borough2 = input.Boro,
                Street2 = input.St2
            }));

            var actual = Regex.Replace(result, @"[\r\t\n\s]+", "");
            var expected = Regex.Replace(output, @"[\r\t\n\s]+", "");


            // Uncomment for Debugging Unit Tests for Errors. Read Logs in Debug Folder
            using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Results_2", append: true))
            {
                writer.WriteLine(actual);
                writer.WriteLine(expected);
            }

            Assert.AreEqual(actual, expected);
        }

        public static IEnumerable<object[]> F3C_IntrsctInput => TestResponseHelper.Inputs_Generator(FunctionCode.F3C);

        [TestMethod]
        [DynamicData(nameof(F3C_IntrsctInput), DynamicDataSourceType.Property)]
        public void Function3C(CrossStreetInputs input, string output)
        {
            var result = JsonSerializer.Serialize(GeoService.Function3C(new FunctionInput
            {
                Borough1 = input.Borough1,
                OnStreet= input.OnStreet,
                FirstCrossStreet = input.FirstCrossStreet,
                SecondCrossStreet = input.SecondCrossStreet,
                CompassFlag = input.CompassDirection
            }));

            var actual = Regex.Replace(result, @"[\r\t\n\s]+", "");
            var expected = Regex.Replace(output, @"[\r\t\n\s]+", "");


            // Uncomment for Debugging Unit Tests for Errors. Read Logs in Debug Folder
            using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Results_3C", append: true))
            {
                writer.WriteLine(actual);
                writer.WriteLine(expected);
            }

            Assert.AreEqual(actual, expected);
        }

        public static IEnumerable<object[]> F3S_IntrsctInput => TestResponseHelper.Inputs_Generator(FunctionCode.F3S);

        [TestMethod]
        [DynamicData(nameof(F3S_IntrsctInput), DynamicDataSourceType.Property)]
        public void Function3S(CrossStreetInputs input, string output)
        {
            var result = JsonSerializer.Serialize(GeoService.Function3S(new FunctionInput
            {
                Borough = input.Borough1,
                OnStreet = input.OnStreet,
                FirstCrossStreet = input.FirstCrossStreet,
                SecondCrossStreet = input.SecondCrossStreet,
            }));

            var actual = Regex.Replace(result, @"[\r\t\n\s]+", "");
            var expected = Regex.Replace(output, @"[\r\t\n\s]+", "");


            // Uncomment for Debugging Unit Tests for Errors. Read Logs in Debug Folder
            using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Results_3S", append: true))
            {
                writer.WriteLine(actual);
                writer.WriteLine(expected);
            }

            Assert.AreEqual(actual, expected);
        }
        public static IEnumerable<object[]> F3_IntrsctInput => TestResponseHelper.Inputs_Generator(FunctionCode.F3);

        [TestMethod]
        [DynamicData(nameof(F3_IntrsctInput), DynamicDataSourceType.Property)]
        public void Function3(CrossStreetInputs input, string output)
        {
            var result = JsonSerializer.Serialize(GeoService.Function3(new FunctionInput
            {
                Borough1 = input.Borough1,
                OnStreet = input.OnStreet,
                Borough2 = input.Borough1,
                FirstCrossStreet = input.FirstCrossStreet,
                Borough3 = input.Borough1,
                SecondCrossStreet = input.SecondCrossStreet,
                CompassFlag = input.CompassDirection
            }));

            var actual = Regex.Replace(result, @"[\r\t\n\s]+", "");
            var expected = Regex.Replace(output, @"[\r\t\n\s]+", "");


            // Uncomment for Debugging Unit Tests for Errors. Read Logs in Debug Folder
            using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Results_3", append: true))
            {
                writer.WriteLine(actual);
                writer.WriteLine(expected);
            }

            Assert.AreEqual(actual, expected);
        }

        public static IEnumerable<object[]> F5_HighLowAddrInput => TestResponseHelper.Inputs_Generator(FunctionCode.F5);

        [TestMethod]
        [DynamicData(nameof(F5_HighLowAddrInput), DynamicDataSourceType.Property)]
        public void Function5(HighLowAddrInput input, string output)
        {
            var result = JsonSerializer.Serialize(GeoService.Function5(new FunctionInput
            {
                Borough = input.Borough,
                LowAddressNo = input.LowAddressNo,
                HighAddressNo = input.HighAddressNo,
                StreetName = input.StreetName,
            }));

            var actual = Regex.Replace(result, @"[\r\t\n\s]+", "");
            var expected = Regex.Replace(output, @"[\r\t\n\s]+", "");


            // Uncomment for Debugging Unit Tests for Errors. Read Logs in Debug Folder
            using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Results_5", append: true))
            {
                writer.WriteLine(actual);
                writer.WriteLine(expected);
            }

            Assert.AreEqual(actual, expected);
        }

        public static IEnumerable<object[]> FAP_AddrInputs => TestResponseHelper.Inputs_Generator(FunctionCode.FAP);

        [TestMethod]
        [DynamicData(nameof(FAP_AddrInputs), DynamicDataSourceType.Property)]
        public void FunctionAP(AddrInput input, string output)
        {
            var result = JsonSerializer.Serialize(GeoService.FunctionAP(new FunctionInput
            {
                Borough = input.Boro,
                AddressNo = input.AddrNo,
                StreetName = input.StName
            }));

            var actual = Regex.Replace(result, @"[\r\t\n\s]+", "");
            var expected = Regex.Replace(output, @"[\r\t\n\s]+", "");


            // Uncomment for Debugging Unit Tests for Errors. Read Logs in Debug Folder
            using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Results_AP", append: true))
            {
                writer.WriteLine(actual);
                writer.WriteLine(expected);
            }

            Assert.AreEqual(actual, expected);
        }

        public static IEnumerable<object[]> FBBL_BBLInputs => TestResponseHelper.Inputs_Generator(FunctionCode.FBBL);

        [TestMethod]
        [DynamicData(nameof(FBBL_BBLInputs), DynamicDataSourceType.Property)]
        public void FunctionBBL(BBLInput input, string output)
        {
            var result = JsonSerializer.Serialize(GeoService.FunctionBBL(new FunctionInput
            {
                Borough = input.Boro,
                Block = input.Block,
                Lot = input.Lot
            }));

            var actual = Regex.Replace(result, @"[\r\t\n\s]+", "");
            var expected = Regex.Replace(output, @"[\r\t\n\s]+", "");


            // Uncomment for Debugging Unit Tests for Errors. Read Logs in Debug Folder
            using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Results_BBL", append: true))
            {
                writer.WriteLine(actual);
                writer.WriteLine(expected);
            }

            Assert.AreEqual(actual, expected);
        }

        public static IEnumerable<object[]> FBB_AddrInputs => TestResponseHelper.Inputs_Generator(FunctionCode.FBB);

        [TestMethod]
        [DynamicData(nameof(FBB_AddrInputs), DynamicDataSourceType.Property)]
        public void FunctionBB(SndEntry input, string output)
        {
            var result = JsonSerializer.Serialize(GeoService.FunctionBB(new FunctionInput
            {
                Borough = input.out_boro_name1,
                StreetName = input.out_stname1
            }));

            var actual = Regex.Replace(result, @"[\r\t\n\s]+", "");
            var expected = Regex.Replace(output, @"[\r\t\n\s]+", "");


            // Uncomment for Debugging Unit Tests for Errors. Read Logs in Debug Folder
            using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Results_BB", append: true))
            {
                writer.WriteLine(actual);
                writer.WriteLine(expected);
            }

            Assert.AreEqual(actual, expected);
        }

        public static IEnumerable<object[]> FBF_AddrInputs => TestResponseHelper.Inputs_Generator(FunctionCode.FBF);

        [TestMethod]
        [DynamicData(nameof(FBF_AddrInputs), DynamicDataSourceType.Property)]
        public void FunctionBF(SndEntry input, string output)
        {
            var result = JsonSerializer.Serialize(GeoService.FunctionBF(new FunctionInput
            {
                Borough = input.out_boro_name1,
                StreetName = input.out_stname1
            }));

            var actual = Regex.Replace(result, @"[\r\t\n\s]+", "");
            var expected = Regex.Replace(output, @"[\r\t\n\s]+", "");


            // Uncomment for Debugging Unit Tests for Errors. Read Logs in Debug Folder
            using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Results_BF", append: true))
            {
                writer.WriteLine(actual);
                writer.WriteLine(expected);
            }

            Assert.AreEqual(actual, expected);
        }
        public static IEnumerable<object[]> FBIN_ShortBinInputs => TestResponseHelper.Inputs_Generator(FunctionCode.FBIN);

        [TestMethod]
        [DynamicData(nameof(FBIN_ShortBinInputs), DynamicDataSourceType.Property)]
        public void FunctionBIN(string input, string output)
        {
            var result = JsonSerializer.Serialize(GeoService.FunctionBIN(new FunctionInput{ Bin = input }));

            var actual = Regex.Replace(result, @"[\r\t\n\s]+", "");
            var expected = Regex.Replace(output, @"[\r\t\n\s]+", "");


            // Uncomment for Debugging Unit Tests for Errors. Read Logs in Debug Folder
            using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Results_BIN", append: true))
            {
                writer.WriteLine(actual);
                writer.WriteLine(expected);
            }

            Assert.AreEqual(actual, expected);
        }

        public static IEnumerable<object[]> FD_StCodeInputs => TestResponseHelper.Inputs_Generator(FunctionCode.FD);

        [TestMethod]
        [DynamicData(nameof(FD_StCodeInputs), DynamicDataSourceType.Property)]
        public void FunctionD(StCodeCase input, string output)
        {
            var result = JsonSerializer.Serialize(GeoService.FunctionD(new FunctionInput
            {
                B10SC1 = input.FullB10Sc1,
                B10SC2 = input.FullB10Sc2,
                B10SC3 = input.FullB10Sc3
            }));

            var actual = Regex.Replace(result, @"[\r\t\n\s]+", "");
            var expected = Regex.Replace(output, @"[\r\t\n\s]+", "");

            // Uncomment for Debugging Unit Tests for Errors. Read Logs in Debug Folder
            using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Results_D", append: true))
            {
                writer.WriteLine(actual);
                writer.WriteLine(expected);
            }

            Assert.AreEqual(actual, expected);
        }

        public static IEnumerable<object[]> FHR_AddrInputs => TestResponseHelper.Inputs_Generator(FunctionCode.FHR);

        [TestMethod]
        [DynamicData(nameof(FHR_AddrInputs), DynamicDataSourceType.Property)]
        public void FunctionHR(string output)
        {
            var result = JsonSerializer.Serialize(GeoService.FunctionHR());

            var actual = Regex.Replace(result, @"[\r\t\n\s]+", "");
            var expected = Regex.Replace(output, @"[\r\t\n\s]+", "");


            // Uncomment for Debugging Unit Tests for Errors. Read Logs in Debug Folder
            using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Results_HR", append: true))
            {
                writer.WriteLine(actual);
                writer.WriteLine(expected);
            }

            Assert.AreEqual(actual, expected);
        }

        public static IEnumerable<object[]> FN_AddrInputs => TestResponseHelper.Inputs_Generator(FunctionCode.FN);

        [TestMethod]
        [DynamicData(nameof(FN_AddrInputs), DynamicDataSourceType.Property)]
        public void FunctionN(AddrInput input, string output)
        {
            var result = JsonSerializer.Serialize(GeoService.FunctionN(new FunctionInput{
                StreetName = input.StName,
                StreetNameLength = input.StNameLength
            }));

            var actual = Regex.Replace(result, @"[\r\t\n\s]+", "");
            var expected = Regex.Replace(output, @"[\r\t\n\s]+", "");


            // Uncomment for Debugging Unit Tests for Errors. Read Logs in Debug Folder
            using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Results_N", append: true))
            {
                writer.WriteLine(actual);
                writer.WriteLine(expected);
            }

            Assert.AreEqual(actual, expected);
        }
    }
}
