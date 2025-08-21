using GeoXWrapperLib.Model;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace GeoXWrapperLib
{
    public class Geo
    {

        public delegate void nyc_geo_delegate(byte[] wa1, byte[] wa2 = null);

        public nyc_geo_delegate NYCgeo;


        public Geo(){
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                NYCgeo = WindowsNYCgeo;
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                NYCgeo = LinuxNYCgeo;
            }
        }

        private void LinuxNYCgeo(byte[] wa1, byte[] wa2 = null) {
            string wa1String = WA.ByteArrayToStr(wa1);
            string wa2String = WA.ByteArrayToStr(wa2);

            NYCgeo_Linux(wa1String, wa2String); 
        } 
        
        private void WindowsNYCgeo(byte[] wa1, byte[] wa2 = null){
            NYCgeo_Windows(wa1, wa2);
        }


        [DllImport("NYCgeo", EntryPoint="NYCgeo", CallingConvention = CallingConvention.StdCall)]
        public static extern void NYCgeo_Windows(byte[] wa1, byte[] wa2 = null);
       
        [DllImport("libNYCgeo", EntryPoint = "geo", CallingConvention = CallingConvention.Cdecl)]
        public static extern void NYCgeo_Linux( [MarshalAs(UnmanagedType.LPStr)] string ptr_wa1, [MarshalAs(UnmanagedType.LPStr)] string ptr_wa2 = null);

        // #Region "GDE calls"

        // Will handle 1 workarea call to GDE
        public void NYCcall(ref WA inwa1)
        {
            // Overloaded method with 1 workarea passed as class
            byte[] wa1_byte = WA.StrToByteArray(inwa1.ToString());
            NYCgeo(wa1_byte);
            inwa1.FromString(WA.ByteArrayToStr(wa1_byte));
        }

        public void NYCcall(ref WA inwa1, ref WA inwa2)
        {
            // Overloaded method with 2 workareas passed as class
            byte[] wa1_byte = WA.StrToByteArray(inwa1.ToString());  
            byte[] wa2_byte = WA.StrToByteArray(inwa2.ToString());

            NYCgeo(wa1_byte, wa2_byte);

            inwa1.FromString(WA.ByteArrayToStr(wa1_byte));
            inwa2.FromString(WA.ByteArrayToStr(wa2_byte));
        }

        // #End Region
        // #Region "EntireX calls"

        // Will handle 1 workarea call generically
        // If broker is GDE, it calls NYCcall
        // Otherwise, calls appropriate ETXlib geo call
        public void GeoCall(ref WA inwa1)
        {
            //*******************************************************************
            // Call to EntireX server
            //*******************************************************************
            StringBuilder wa1sb = new StringBuilder(inwa1.ToString());
            string error_class = null;
            string error_number = null;
            bool TryAgain = true;
            bool SuccessfulCall = false;

            // Below used to cause brief delay before retrying busy broker
            // DateTime loopstart;
            // DateTime loopend;
            // DateTime checktime;
            // long delay = 100;
            // long loopcount;

            byte[] wa1_byte = WA.StrToByteArray(inwa1.ToString());

            try
            {
                switch (inwa1.GetType().Name)
                {
                    case "Wa1":
                        NYCgeo(wa1_byte);
                        SuccessfulCall = true;
                        inwa1.FromString(WA.ByteArrayToStr(wa1_byte));
                        break;

                    default:
                        Console.WriteLine("Invalid wa1 passed");
                        return;
                }
            }
            catch (Exception ex)
            {
                switch (inwa1.GetType().Name)
                {
                    case "Wa1":
                        Wa1 cinwa1 = (Wa1)inwa1;
                        cinwa1.out_grc = "XX";
                        cinwa1.out_error_message = ex.Message;
                        inwa1 = cinwa1;
                        break;

                    default:
                        // Handle other cases if necessary
                        break;
                }
            }
        }
        // #Region "EntireX calls"

        // GeoCall for Wa1 type
        public void GeoCall(ref Wa1 inwa1)
        {
            byte[] wa1_byte = WA.StrToByteArray(inwa1.ToString());
            NYCgeo(wa1_byte);
            inwa1.FromString(WA.ByteArrayToStr(wa1_byte));
        }

        // GeoCall for Wa1 and Wa2F1 types
        public void GeoCall(ref Wa1 inwa1, ref Wa2F1 inwa2)
        {
            byte[] wa1_byte = WA.StrToByteArray(inwa1.ToString());
            byte[] wa2_byte = WA.StrToByteArray(inwa2.ToString());

            NYCgeo(wa1_byte, wa2_byte);

            inwa1.FromString(WA.ByteArrayToStr(wa1_byte));
            inwa2.FromString(WA.ByteArrayToStr(wa2_byte));
        }

        // GeoCall for Wa1 and Wa2F1ex types
        public void GeoCall(ref Wa1 inwa1, ref Wa2F1ex inwa2)
        {
            byte[] wa1_byte = WA.StrToByteArray(inwa1.ToString());
            byte[] wa2_byte = WA.StrToByteArray(inwa2.ToString());

            NYCgeo(wa1_byte, wa2_byte);

            inwa1.FromString(WA.ByteArrayToStr(wa1_byte));
            inwa2.FromString(WA.ByteArrayToStr(wa2_byte));
        }

        // GeoCall for Wa1 and Wa2F1a types
        public void GeoCall(ref Wa1 inwa1, ref Wa2F1a inwa2)
        {
            byte[] wa1_byte = WA.StrToByteArray(inwa1.ToString());
            byte[] wa2_byte = WA.StrToByteArray(inwa2.ToString());

            NYCgeo(wa1_byte, wa2_byte);

            inwa1.FromString(WA.ByteArrayToStr(wa1_byte));
            inwa2.FromString(WA.ByteArrayToStr(wa2_byte));
        }

        // GeoCall for Wa1 and Wa2F1ax types
        public void GeoCall(ref Wa1 inwa1, ref Wa2F1ax inwa2)
        {
            byte[] wa1_byte = WA.StrToByteArray(inwa1.ToString());
            byte[] wa2_byte = WA.StrToByteArray(inwa2.ToString());

            NYCgeo(wa1_byte, wa2_byte);

            inwa1.FromString(WA.ByteArrayToStr(wa1_byte));
            inwa2.FromString(WA.ByteArrayToStr(wa2_byte));
        }

        // GeoCall for Wa1 and Wa2F1al types
        public void GeoCall(ref Wa1 inwa1, ref Wa2F1al inwa2)
        {
            byte[] wa1_byte = WA.StrToByteArray(inwa1.ToString());
            byte[] wa2_byte = WA.StrToByteArray(inwa2.ToString());

            NYCgeo(wa1_byte, wa2_byte);

            inwa1.FromString(WA.ByteArrayToStr(wa1_byte));
            inwa2.FromString(WA.ByteArrayToStr(wa2_byte));
        }

        // GeoCall for Wa1 and Wa2F1al_TPAD types
        public void GeoCall(ref Wa1 inwa1, ref Wa2F1al_TPAD inwa2)
        {
            byte[] wa1_byte = WA.StrToByteArray(inwa1.ToString());
            byte[] wa2_byte = WA.StrToByteArray(inwa2.ToString());

            NYCgeo(wa1_byte, wa2_byte);

            inwa1.FromString(WA.ByteArrayToStr(wa1_byte));
            inwa2.FromString(WA.ByteArrayToStr(wa2_byte));
        }

        // GeoCall for Wa1 and Wa2F1e types
        public void GeoCall(ref Wa1 inwa1, ref Wa2F1e inwa2)
        {
            byte[] wa1_byte = WA.StrToByteArray(inwa1.ToString());
            byte[] wa2_byte = WA.StrToByteArray(inwa2.ToString());

            NYCgeo(wa1_byte, wa2_byte);

            inwa1.FromString(WA.ByteArrayToStr(wa1_byte));
            inwa2.FromString(WA.ByteArrayToStr(wa2_byte));
        }

        // GeoCall for Wa1 and Wa2F1v types
        public void GeoCall(ref Wa1 inwa1, ref Wa2F1v inwa2)
        {
            byte[] wa1_byte = WA.StrToByteArray(inwa1.ToString());
            byte[] wa2_byte = WA.StrToByteArray(inwa2.ToString());

            NYCgeo(wa1_byte, wa2_byte);

            inwa1.FromString(WA.ByteArrayToStr(wa1_byte));
            inwa2.FromString(WA.ByteArrayToStr(wa2_byte));
        }

        // GeoCall for Wa1 and Wa2F1w types
        public void GeoCall(ref Wa1 inwa1, ref Wa2F1w inwa2)
        {
            byte[] wa1_byte = WA.StrToByteArray(inwa1.ToString());
            byte[] wa2_byte = WA.StrToByteArray(inwa2.ToString());

            NYCgeo(wa1_byte, wa2_byte);

            inwa1.FromString(WA.ByteArrayToStr(wa1_byte));
            inwa2.FromString(WA.ByteArrayToStr(wa2_byte));
        }

        // GeoCall for Wa1 and Wa2F1b types
        public void GeoCall(ref Wa1 inwa1, ref Wa2F1b inwa2)
        {
            byte[] wa1_byte = WA.StrToByteArray(inwa1.ToString());
            byte[] wa2_byte = WA.StrToByteArray(inwa2.ToString());

            NYCgeo(wa1_byte, wa2_byte);

            inwa1.FromString(WA.ByteArrayToStr(wa1_byte));
            inwa2.FromString(WA.ByteArrayToStr(wa2_byte));
        }

        // GeoCall for Wa1 and Wa2F2 types
        public void GeoCall(ref Wa1 inwa1, ref Wa2F2 inwa2)
        {
            byte[] wa1_byte = WA.StrToByteArray(inwa1.ToString());
            byte[] wa2_byte = WA.StrToByteArray(inwa2.ToString());

            NYCgeo(wa1_byte, wa2_byte);

            inwa1.FromString(WA.ByteArrayToStr(wa1_byte));
            inwa2.FromString(WA.ByteArrayToStr(wa2_byte));
        }

        // GeoCall for Wa1 and Wa2F2w types
        public void GeoCall(ref Wa1 inwa1, ref Wa2F2w inwa2)
        {
            byte[] wa1_byte = WA.StrToByteArray(inwa1.ToString());
            byte[] wa2_byte = WA.StrToByteArray(inwa2.ToString());

            NYCgeo(wa1_byte, wa2_byte);

            inwa1.FromString(WA.ByteArrayToStr(wa1_byte));
            inwa2.FromString(WA.ByteArrayToStr(wa2_byte));
        }

        // GeoCall for Wa1 and Wa2F3 types
        public void GeoCall(ref Wa1 inwa1, ref Wa2F3 inwa2)
        {
            byte[] wa1_byte = WA.StrToByteArray(inwa1.ToString());
            byte[] wa2_byte = WA.StrToByteArray(inwa2.ToString());

            NYCgeo(wa1_byte, wa2_byte);

            inwa1.FromString(WA.ByteArrayToStr(wa1_byte));
            inwa2.FromString(WA.ByteArrayToStr(wa2_byte));
        }

        // GeoCall for Wa1 and Wa2F3as types
        public void GeoCall(ref Wa1 inwa1, ref Wa2F3as inwa2)
        {
            byte[] wa1_byte = WA.StrToByteArray(inwa1.ToString());
            byte[] wa2_byte = WA.StrToByteArray(inwa2.ToString());

            NYCgeo(wa1_byte, wa2_byte);

            inwa1.FromString(WA.ByteArrayToStr(wa1_byte));
            inwa2.FromString(WA.ByteArrayToStr(wa2_byte));
        }

        // GeoCall for Wa1 and Wa2F3c types
        public void GeoCall(ref Wa1 inwa1, ref Wa2F3c inwa2)
        {
            byte[] wa1_byte = WA.StrToByteArray(inwa1.ToString());
            byte[] wa2_byte = WA.StrToByteArray(inwa2.ToString());

            NYCgeo(wa1_byte, wa2_byte);

            inwa1.FromString(WA.ByteArrayToStr(wa1_byte));
            inwa2.FromString(WA.ByteArrayToStr(wa2_byte));
        }

        // #End Region
        // GeoCall for Wa1 and Wa2F3cas types
        public void GeoCall(ref Wa1 inwa1, ref Wa2F3cas inwa2)
        {
            // Convert inwa1 to byte array
            byte[] wa1_byte = WA.StrToByteArray(inwa1.ToString());

            // Convert inwa2 to byte array
            byte[] wa2_byte = WA.StrToByteArray(inwa2.ToString());

            // Call the NYCgeo with the byte arrays
            NYCgeo(wa1_byte, wa2_byte);

            // Convert the byte arrays back to strings and assign to inwa1 and inwa2
            inwa1.FromString(WA.ByteArrayToStr(wa1_byte));
            inwa2.FromString(WA.ByteArrayToStr(wa2_byte));
        }

        // GeoCall for Wa1 and Wa2F3x types
        public void GeoCall(ref Wa1 inwa1, ref Wa2F3x inwa2)
        {
            // Convert inwa1 to byte array
            byte[] wa1_byte = WA.StrToByteArray(inwa1.ToString());

            // Convert inwa2 to byte array
            byte[] wa2_byte = WA.StrToByteArray(inwa2.ToString());

            // Call the NYCgeo with the byte arrays
            NYCgeo(wa1_byte, wa2_byte);

            // Convert the byte arrays back to strings and assign to inwa1 and inwa2
            inwa1.FromString(WA.ByteArrayToStr(wa1_byte));
            inwa2.FromString(WA.ByteArrayToStr(wa2_byte));
        }

        // GeoCall for Wa1 and Wa2F3xas types
        public void GeoCall(ref Wa1 inwa1, ref Wa2F3xas inwa2)
        {
            // Convert inwa1 to byte array
            byte[] wa1_byte = WA.StrToByteArray(inwa1.ToString());

            // Convert inwa2 to byte array
            byte[] wa2_byte = WA.StrToByteArray(inwa2.ToString());

            // Call the NYCgeo with the byte arrays
            NYCgeo(wa1_byte, wa2_byte);

            // Convert the byte arrays back to strings and assign to inwa1 and inwa2
            inwa1.FromString(WA.ByteArrayToStr(wa1_byte));
            inwa2.FromString(WA.ByteArrayToStr(wa2_byte));
        }

        // GeoCall for Wa1 and Wa2F3cx types
        public void GeoCall(ref Wa1 inwa1, ref Wa2F3cx inwa2)
        {
            // Convert inwa1 to byte array
            byte[] wa1_byte = WA.StrToByteArray(inwa1.ToString());

            // Convert inwa2 to byte array
            byte[] wa2_byte = WA.StrToByteArray(inwa2.ToString());

            // Call the NYCgeo with the byte arrays
            NYCgeo(wa1_byte, wa2_byte);

            // Convert the byte arrays back to strings and assign to inwa1 and inwa2
            inwa1.FromString(WA.ByteArrayToStr(wa1_byte));
            inwa2.FromString(WA.ByteArrayToStr(wa2_byte));
        }

        // GeoCall for Wa1 and Wa2F3cxas types
        public void GeoCall(ref Wa1 inwa1, ref Wa2F3cxas inwa2)
        {
            // Convert inwa1 to byte array
            byte[] wa1_byte = WA.StrToByteArray(inwa1.ToString());

            // Convert inwa2 to byte array
            byte[] wa2_byte = WA.StrToByteArray(inwa2.ToString());

            // Call the NYCgeo with the byte arrays
            NYCgeo(wa1_byte, wa2_byte);

            // Convert the byte arrays back to strings and assign to inwa1 and inwa2
            inwa1.FromString(WA.ByteArrayToStr(wa1_byte));
            inwa2.FromString(WA.ByteArrayToStr(wa2_byte));
        }

        public void GeoCall(ref Wa1 inwa1, ref Wa2F3e inwa2)
        {
            GeoCallInternal(ref inwa1, inwa2);
        }

        public void GeoCall(ref Wa1 inwa1, ref Wa2F3eas inwa2)
        {
            GeoCallInternal(ref inwa1, inwa2);
        }

        public void GeoCall(ref Wa1 inwa1, ref Wa2F3ce inwa2)
        {
            GeoCallInternal(ref inwa1, inwa2);
        }

        public void GeoCall(ref Wa1 inwa1, ref Wa2F3ceas inwa2)
        {
            GeoCallInternal(ref inwa1, inwa2);
        }

        public void GeoCall(ref Wa1 inwa1, ref Wa2F3s inwa2)
        {
            GeoCallInternal(ref inwa1, inwa2);
        }

        public void GeoCall(ref Wa1 inwa1, ref Wa2F5 inwa2)
        {
            GeoCallInternal(ref inwa1, inwa2);
        }

        public void GeoCall(ref Wa1 inwa1, ref Wa2F1p inwa2)
        {
            GeoCallInternal(ref inwa1, inwa2);
        }

        public void GeoCall(ref Wa1 inwa1, ref Wa2Fap inwa2)
        {
            GeoCallInternal(ref inwa1, inwa2);
        }

        public void GeoCall(ref Wa1 inwa1, ref Wa2Fapx inwa2)
        {
            GeoCallInternal(ref inwa1, inwa2);
        }

        public void GeoCall(ref Wa1 inwa1, ref Wa2Fhr inwa2)
        {
            GeoCallInternal(ref inwa1,  inwa2);
        }

        // General method to handle all cases
        private void GeoCallInternal(ref Wa1 inwa1, object inwa2)
        {
            byte[] wa1_byte = StrToByteArray(inwa1.ToString());
            byte[] wa2_byte = StrToByteArray(inwa2.ToString());

            NYCgeo(wa1_byte, wa2_byte);

            inwa1.FromString(ByteArrayToStr(wa1_byte));
            ((WA)inwa2).FromString(ByteArrayToStr(wa2_byte));
        }

        // Converts string to byte array
        private byte[] StrToByteArray(string str) => Encoding.UTF8.GetBytes(str);

        // Converts byte array to string
        private string ByteArrayToStr(byte[] byteArray) => Encoding.UTF8.GetString(byteArray);

    // #End Region
        [Conditional("PPC")]
        public void GeoCall(ref WA inwa1, ref WA inwa2)
        {
            StringBuilder wa1sb = new StringBuilder(inwa1.ToString());
            StringBuilder wa2sb = new StringBuilder(inwa2.ToString());
            string error_class = null;
            string error_number = null;
            bool tryAgain = true;
            bool successfulCall = false;
            int retryCount = 0;

            //--------------------------------------------------------------------------------
            //--SPO(2024-07-01)  Try replacing inwa1 And inwa2 With Class name WA
            //--                 This seems to get rid of the warning 
            //--------------------------------------------------------------------------------

            byte[] wa1_byte = WA.StrToByteArray(inwa1.ToString());
            byte[] wa2_byte = WA.StrToByteArray(inwa2.ToString());

            try
            {
                NYCgeo(wa1_byte, wa2_byte);
                successfulCall = true;

                inwa1.FromString(WA.ByteArrayToStr(wa1_byte));
                inwa2.FromString(WA.ByteArrayToStr(wa2_byte));
            }
            catch (Exception ex)
            {
                switch (inwa1.GetType().Name)
                {
                    case "Wa1":
                        var cinwa1 = new Wa1();
                        cinwa1 = (Wa1)inwa1;
                        cinwa1.out_grc = "XX";
                        cinwa1.out_error_message = ex.Message;
                        inwa1 = cinwa1;
                        break;
                    default:
                        break;
                }
            }
        }

    }
}
