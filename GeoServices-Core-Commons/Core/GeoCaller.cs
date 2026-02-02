using GeoServices_Core_Commons.Core.Contract;
using GeoServices_Core_Commons.Model.Settings;
using GeoXWrapperLib;
using GeoXWrapperLib.Model;
using Microsoft.Extensions.Configuration;


namespace GeoServices_Core_Commons.Core
{
    public class GeoCaller : IGeoCaller
    {
        public Geo Geo { get; set; }
        private static Mutex Mutex { get; set; }
        private delegate void GeoCallFunction(bool x = false);

        private readonly IConfiguration Configuration; 
        private SafeHandleMutex Settings;


        public GeoCaller(Geo _geo, IConfiguration configuration)
        {
            Geo = _geo;
            Mutex = new Mutex();
            Configuration = configuration;

            Settings = new SafeHandleMutex
            {
                Lock = bool.Parse(Configuration["SafeHandle:MutexSettings:Lock"]),
                Wait = int.Parse(Configuration["SafeHandle:MutexSettings:Wait"]),
                Max = int.Parse(Configuration["SafeHandle:MutexSettings:Max"]),
                Sleep = int.Parse(Configuration["SafeHandle:Sleep"]),
                Retry = int.Parse(Configuration["SafeHandle:Retry"])
            };
        }

        private async Task SafeHanddle(GeoCallFunction geoCallfunction, int retry = 1, int max = 100)
        {
            try {
                if (Settings.Lock) {
                    if (Mutex.WaitOne(Settings.Wait) && max > 0)
                    {
                        await Task.Run(() => geoCallfunction());
                        Mutex.ReleaseMutex();
                    }
                    else if (max <= 0) 
                        geoCallfunction(true);
                    else 
                        await SafeHanddle(geoCallfunction, retry, --max);
                }
                else 
                        await Task.Run(() => geoCallfunction());
            }
            catch {

                if (retry < Settings.Retry)
                {
                    Thread.Sleep(Settings.Sleep);
                    await SafeHanddle(geoCallfunction, retry++);
                }
                else 
                    geoCallfunction(true);
            }
        }

        private void HandleError(ref Wa1 wa1)
        {
            wa1.out_grc = "XX";
            wa1.out_error_message = "Our Servers are a bit Overloaded. Please try again later!";
        }


        public async Task GeoCall(WA inwa1) => await SafeHanddle((error) => Geo.GeoCall(ref inwa1));
            

        public async Task GeoCall(Wa1 inwa1) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1); else HandleError(ref inwa1);});

        public async Task GeoCall(Wa1 inwa1, Wa2F1 inwa2) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); });
        public async Task GeoCall(Wa1 inwa1, Wa2F1ex inwa2) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); });

        public async Task GeoCall(Wa1 inwa1, Wa2F1a inwa2) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); });

        public async Task GeoCall(Wa1 inwa1, Wa2F1ax inwa2) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); });

        public async Task GeoCall(Wa1 inwa1, Wa2F1al inwa2) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); });

        public async Task GeoCall(Wa1 inwa1, Wa2F1al_TPAD inwa2) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); });

        public async Task GeoCall(Wa1 inwa1, Wa2F1e inwa2) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); });

        public async Task GeoCall(Wa1 inwa1, Wa2F1v inwa2) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); });

        public async Task GeoCall(Wa1 inwa1, Wa2F1b inwa2) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); });

        public async Task GeoCall(Wa1 inwa1, Wa2F2 inwa2) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); });


        public async Task GeoCall(Wa1 inwa1, Wa2F2w inwa2) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); });

        public async Task GeoCall(Wa1 inwa1, Wa2F3 inwa2) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); });

        public async Task GeoCall(Wa1 inwa1, Wa2F3as inwa2) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); });

        public async Task GeoCall(Wa1 inwa1, Wa2F3c inwa2) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); });

        public async Task GeoCall(Wa1 inwa1, Wa2F3cas inwa2) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); });

        public async Task GeoCall(Wa1 inwa1, Wa2F3x inwa2) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); });

        public async Task GeoCall(Wa1 inwa1, Wa2F3xas inwa2) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); });

        public async Task GeoCall(Wa1 inwa1, Wa2F3cx inwa2) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); });

        public async Task GeoCall(Wa1 inwa1, Wa2F3cxas inwa2) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); });

        public async Task GeoCall(Wa1 inwa1, Wa2F3e inwa2) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); });

        public async Task GeoCall(Wa1 inwa1, Wa2F3eas inwa2) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); });

        public async Task GeoCall(Wa1 inwa1, Wa2F3ce inwa2) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); });

        public async Task GeoCall(Wa1 inwa1, Wa2F3ceas inwa2) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); });

        public async Task GeoCall(Wa1 inwa1, Wa2F3s inwa2) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); });

        public async Task GeoCall(Wa1 inwa1, Wa2F5 inwa2) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); });

        public async Task GeoCall(Wa1 inwa1, Wa2F1p inwa2) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); });

        public async Task GeoCall(Wa1 inwa1, Wa2Fap inwa2) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1); });

        public async Task GeoCall(Wa1 inwa1, Wa2Fapx inwa2) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1);});

        public async Task GeoCall(Wa1 inwa1, Wa2Fhr inwa2) => await SafeHanddle((error) => { if (!error) Geo.GeoCall(ref inwa1, ref inwa2); else HandleError(ref inwa1);});

        public async Task GeoCall(WA inwa1, WA inwa2) => await SafeHanddle((error) => Geo.GeoCall(ref inwa1, ref inwa2));

        public async Task NYCcall(WA inwa1) => await SafeHanddle((error) => Geo.GeoCall(ref inwa1));

        public async Task NYCcall(WA inwa1, WA inwa2) => await SafeHanddle((error) => Geo.NYCcall(ref inwa1, ref inwa2));
    }
}
