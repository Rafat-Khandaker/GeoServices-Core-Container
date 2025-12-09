using GeoServices_Core_Commons.Core.Contract;
using GeoXWrapperLib;
using GeoXWrapperLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GeoServices_Core_Commons.Core
{
    public class GeoCaller : IGeoCaller
    {
        public Geo Geo { get; set; }

        public delegate void GeoCallFunction();

        public GeoCaller(Geo _geo)
        {
            Geo = _geo;
        }

        private async Task SafeHanddle(GeoCallFunction geoCallfunction, int retry = 1)
        {
            try {
                await Task.Run(()=> geoCallfunction());
            }
            catch {

                if (retry < 3)
                {
                    Thread.Sleep(100);
                    await SafeHanddle(geoCallfunction, retry++);
                }
                else return;
            }
        }

        public async Task GeoCall(WA inwa1) => await SafeHanddle(() => Geo.GeoCall(ref inwa1));
            

        public async Task GeoCall(Wa1 inwa1) => await SafeHanddle(() => Geo.GeoCall(ref inwa1));

        public async Task GeoCall(Wa1 inwa1, Wa2F1 inwa2) => await SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));
        public async Task GeoCall(Wa1 inwa1, Wa2F1ex inwa2) => await SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async Task GeoCall(Wa1 inwa1, Wa2F1a inwa2) => await SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async Task GeoCall(Wa1 inwa1, Wa2F1ax inwa2) => await SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async Task GeoCall(Wa1 inwa1, Wa2F1al inwa2) => await SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async Task GeoCall(Wa1 inwa1, Wa2F1al_TPAD inwa2) => await SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async Task GeoCall(Wa1 inwa1, Wa2F1e inwa2) => await SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async Task GeoCall(Wa1 inwa1, Wa2F1v inwa2) => await SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async Task GeoCall(Wa1 inwa1, Wa2F1b inwa2) => await SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async Task GeoCall(Wa1 inwa1, Wa2F2 inwa2) => await SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async Task GeoCall(Wa1 inwa1, Wa2F2w inwa2) => await SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async Task GeoCall(Wa1 inwa1, Wa2F3 inwa2) => await SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async Task GeoCall(Wa1 inwa1, Wa2F3as inwa2) => await SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async Task GeoCall(Wa1 inwa1, Wa2F3c inwa2) => await SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async Task GeoCall(Wa1 inwa1, Wa2F3cas inwa2) => await SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async Task GeoCall(Wa1 inwa1, Wa2F3x inwa2) => await SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async Task GeoCall(Wa1 inwa1, Wa2F3xas inwa2) => await SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async Task GeoCall(Wa1 inwa1, Wa2F3cx inwa2) => await SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async Task GeoCall(Wa1 inwa1, Wa2F3cxas inwa2) => await SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async Task GeoCall(Wa1 inwa1, Wa2F3e inwa2) => await SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async Task GeoCall(Wa1 inwa1, Wa2F3eas inwa2) => await SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async Task GeoCall(Wa1 inwa1, Wa2F3ce inwa2) => await SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async Task GeoCall(Wa1 inwa1, Wa2F3ceas inwa2) => await SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async Task GeoCall(Wa1 inwa1, Wa2F3s inwa2) => await SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async Task GeoCall(Wa1 inwa1, Wa2F5 inwa2) => await SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async Task GeoCall(Wa1 inwa1, Wa2F1p inwa2) => await SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async Task GeoCall(Wa1 inwa1, Wa2Fap inwa2) => await SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async Task GeoCall(Wa1 inwa1, Wa2Fapx inwa2) => await SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async Task GeoCall(Wa1 inwa1, Wa2Fhr inwa2) => await SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async Task GeoCall(WA inwa1, WA inwa2) => await SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async Task NYCcall(WA inwa1) => await SafeHanddle(() => Geo.GeoCall(ref inwa1));

        public async Task NYCcall(WA inwa1, WA inwa2) => await SafeHanddle(() => Geo.NYCcall(ref inwa1, ref inwa2));
    }
}
