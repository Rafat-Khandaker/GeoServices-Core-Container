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

        public GeoCaller(Geo _geoCaller)
        {
            Geo = _geoCaller;
        }

        private async void SafeHanddle(GeoCallFunction geoCallfunction, int retry = 1)
        {
            try {
                  await Task.Run(()=> geoCallfunction());
            }
            catch {

                if (retry < 3)
                {
                    Thread.Sleep(100);
                    SafeHanddle(geoCallfunction, retry++);
                }
                else return;
            }
        }

        public async void GeoCall(WA inwa1) => SafeHanddle(() => Geo.GeoCall(ref inwa1));

        public async void GeoCall(Wa1 inwa1) => SafeHanddle(() => Geo.GeoCall(ref inwa1));

        public async void GeoCall(Wa1 inwa1, Wa2F1 inwa2) => SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));
        public async void GeoCall(Wa1 inwa1, Wa2F1ex inwa2) => SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async void GeoCall(Wa1 inwa1, Wa2F1a inwa2) => SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async void GeoCall(Wa1 inwa1, Wa2F1ax inwa2) => SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async void GeoCall(Wa1 inwa1, Wa2F1al inwa2) => SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async void GeoCall(Wa1 inwa1, Wa2F1al_TPAD inwa2) => SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async void GeoCall(Wa1 inwa1, Wa2F1e inwa2) => SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async void GeoCall(Wa1 inwa1, Wa2F1v inwa2) => SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async void GeoCall(Wa1 inwa1, Wa2F1b inwa2) => SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async void GeoCall(Wa1 inwa1, Wa2F2 inwa2) => SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async void GeoCall(Wa1 inwa1, Wa2F2w inwa2) => SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async void GeoCall(Wa1 inwa1, Wa2F3 inwa2) => SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async void GeoCall(Wa1 inwa1, Wa2F3as inwa2) => SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async void GeoCall(Wa1 inwa1, Wa2F3c inwa2) => SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async void GeoCall(Wa1 inwa1, Wa2F3cas inwa2) => SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async void GeoCall(Wa1 inwa1, Wa2F3x inwa2) => SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async void GeoCall(Wa1 inwa1, Wa2F3xas inwa2) => SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async void GeoCall(Wa1 inwa1, Wa2F3cx inwa2) => SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async void GeoCall(Wa1 inwa1, Wa2F3cxas inwa2) => SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async void GeoCall(Wa1 inwa1, Wa2F3e inwa2) => SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async void GeoCall(Wa1 inwa1, Wa2F3eas inwa2) => SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async void GeoCall(Wa1 inwa1, Wa2F3ce inwa2) => SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async void GeoCall(Wa1 inwa1, Wa2F3ceas inwa2) => SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async void GeoCall(Wa1 inwa1, Wa2F3s inwa2) => SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async void GeoCall(Wa1 inwa1, Wa2F5 inwa2) => SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async void GeoCall(Wa1 inwa1, Wa2F1p inwa2) => SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async void GeoCall(Wa1 inwa1, Wa2Fap inwa2) => SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async void GeoCall(Wa1 inwa1, Wa2Fapx inwa2) => SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async void GeoCall(Wa1 inwa1, Wa2Fhr inwa2) => SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async void GeoCall(WA inwa1, WA inwa2) => SafeHanddle(() => Geo.GeoCall(ref inwa1, ref inwa2));

        public async void NYCcall(WA inwa1) => SafeHanddle(() => Geo.GeoCall(ref inwa1));

        public async void NYCcall(WA inwa1, WA inwa2) => SafeHanddle(() => Geo.NYCcall(ref inwa1, ref inwa2));
    }
}
