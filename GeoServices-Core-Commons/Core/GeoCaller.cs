using GeoServices_Core_Commons.Core.Contract;
using GeoXWrapperLib;
using GeoXWrapperLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GeoServices_Core_Commons.Core
{
    public class GeoCaller : IGeoCaller
    {
        public Geo Geo { get; set; }
        private static Mutex Mutex { get; set; }
        private delegate void GeoCallFunction(bool x = false);

        public GeoCaller(Geo _geo)
        {
            Geo = _geo;
            Mutex = new Mutex();
        }

        private async Task SafeHanddle(GeoCallFunction geoCallfunction, bool lockResource = false, int retry = 1, int max = 10)
        {
            try {
                if (lockResource) {
                    if (Mutex.WaitOne(10) && max > 0)
                    {
                        await Task.Run(() => geoCallfunction());
                        Mutex.ReleaseMutex();
                    }
                    else if (max <= 0) geoCallfunction(true);
                    else await SafeHanddle(geoCallfunction, lockResource, retry, max--);
                }
                else await Task.Run(() => geoCallfunction());
            }
            catch {

                if (retry < 3)
                {
                    Thread.Sleep(100);
                    await SafeHanddle(geoCallfunction, lockResource, retry++);
                }
                else geoCallfunction(true);
            }
        }

        private void HandleError(ref Wa1 wa1)
        {
            wa1.out_grc = "XX";
            wa1.out_error_message = "Our Servers are a bit Overloaded. Please try again later!";
        }


        public async Task GeoCall(WA inwa1, bool lockResource = false) => await SafeHanddle((error) => Geo.GeoCall(ref inwa1), lockResource);
            

        public async Task GeoCall(Wa1 inwa1, bool lockResource = false) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1); else HandleError(ref inwa1); } , lockResource);

        public async Task GeoCall(Wa1 inwa1, Wa2F1 inwa2, bool lockResource = false) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); }, lockResource);
        public async Task GeoCall(Wa1 inwa1, Wa2F1ex inwa2, bool lockResource = false) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); }, lockResource);

        public async Task GeoCall(Wa1 inwa1, Wa2F1a inwa2, bool lockResource = false) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); }, lockResource);

        public async Task GeoCall(Wa1 inwa1, Wa2F1ax inwa2, bool lockResource = false) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); }, lockResource);

        public async Task GeoCall(Wa1 inwa1, Wa2F1al inwa2, bool lockResource = false) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); }, lockResource);

        public async Task GeoCall(Wa1 inwa1, Wa2F1al_TPAD inwa2, bool lockResource = false) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); }, lockResource);

        public async Task GeoCall(Wa1 inwa1, Wa2F1e inwa2, bool lockResource = false) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); }, lockResource);

        public async Task GeoCall(Wa1 inwa1, Wa2F1v inwa2, bool lockResource = false) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); }, lockResource);

        public async Task GeoCall(Wa1 inwa1, Wa2F1b inwa2, bool lockResource = false) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); }, lockResource);

        public async Task GeoCall(Wa1 inwa1, Wa2F2 inwa2, bool lockResource = false) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); }, lockResource);


        public async Task GeoCall(Wa1 inwa1, Wa2F2w inwa2, bool lockResource = false) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); }, lockResource);

        public async Task GeoCall(Wa1 inwa1, Wa2F3 inwa2, bool lockResource = false) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); }, lockResource);

        public async Task GeoCall(Wa1 inwa1, Wa2F3as inwa2, bool lockResource = false) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); }, lockResource);

        public async Task GeoCall(Wa1 inwa1, Wa2F3c inwa2, bool lockResource = false) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); }, lockResource);

        public async Task GeoCall(Wa1 inwa1, Wa2F3cas inwa2, bool lockResource = false) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); }, lockResource);

        public async Task GeoCall(Wa1 inwa1, Wa2F3x inwa2, bool lockResource = false) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); }, lockResource);

        public async Task GeoCall(Wa1 inwa1, Wa2F3xas inwa2, bool lockResource = false) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); }, lockResource);

        public async Task GeoCall(Wa1 inwa1, Wa2F3cx inwa2, bool lockResource = false) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); }, lockResource);

        public async Task GeoCall(Wa1 inwa1, Wa2F3cxas inwa2, bool lockResource = false) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); }, lockResource);

        public async Task GeoCall(Wa1 inwa1, Wa2F3e inwa2, bool lockResource = false) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); }, lockResource);

        public async Task GeoCall(Wa1 inwa1, Wa2F3eas inwa2, bool lockResource = false) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); }, lockResource);

        public async Task GeoCall(Wa1 inwa1, Wa2F3ce inwa2, bool lockResource = false) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); }, lockResource);

        public async Task GeoCall(Wa1 inwa1, Wa2F3ceas inwa2, bool lockResource = false) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); }, lockResource);

        public async Task GeoCall(Wa1 inwa1, Wa2F3s inwa2, bool lockResource = false) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); }, lockResource);

        public async Task GeoCall(Wa1 inwa1, Wa2F5 inwa2, bool lockResource = false) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); }, lockResource);

        public async Task GeoCall(Wa1 inwa1, Wa2F1p inwa2, bool lockResource = false) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); }, lockResource);

        public async Task GeoCall(Wa1 inwa1, Wa2Fap inwa2, bool lockResource = false) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); }, lockResource);

        public async Task GeoCall(Wa1 inwa1, Wa2Fapx inwa2, bool lockResource = false) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1);}, lockResource);

        public async Task GeoCall(Wa1 inwa1, Wa2Fhr inwa2, bool lockResource = false) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1);}, lockResource);

        public async Task GeoCall(WA inwa1, WA inwa2, bool lockResource = false) => await SafeHanddle((error) => Geo.GeoCall(ref inwa1, ref inwa2), lockResource);

        public async Task NYCcall(WA inwa1, bool lockResource = false) => await SafeHanddle((error) => Geo.GeoCall(ref inwa1), lockResource);

        public async Task NYCcall(WA inwa1, WA inwa2, bool lockResource = false) => await SafeHanddle((error) => Geo.NYCcall(ref inwa1, ref inwa2), lockResource);
    }
}
