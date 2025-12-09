using GeoXWrapperLib;
using GeoXWrapperLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoServices_Core_Commons.Core.Contract
{
    public interface IGeoCaller
    {
        public Geo Geo { get; set; }

        public Task NYCcall(WA inwa1, bool lockResource = false);
        public Task NYCcall(WA inwa1, WA inwa2, bool lockResource = false);
        public Task GeoCall(WA inwa1, bool lockResource = false);
        public Task GeoCall(Wa1 inwa1, bool lockResource = false);
        public Task GeoCall(Wa1 inwa1, Wa2F1 inwa2, bool lockResource = false);
        public Task GeoCall(Wa1 inwa1, Wa2F1ex inwa2, bool lockResource = false);
        public Task GeoCall(Wa1 inwa1, Wa2F1a inwa2, bool lockResource = false);
        public Task GeoCall(Wa1 inwa1, Wa2F1ax inwa2, bool lockResource = false);
        public Task GeoCall(Wa1 inwa1, Wa2F1al inwa2, bool lockResource = false);
        public Task GeoCall(Wa1 inwa1, Wa2F1al_TPAD inwa2, bool lockResource = false);
        public Task GeoCall(Wa1 inwa1, Wa2F1e inwa2, bool lockResource = false);
        public Task GeoCall(Wa1 inwa1, Wa2F1v inwa2, bool lockResource = false);
        public Task GeoCall(Wa1 inwa1, Wa2F1b inwa2, bool lockResource = false);
        public Task GeoCall(Wa1 inwa1, Wa2F2 inwa2, bool lockResource = false);
        public Task GeoCall(Wa1 inwa1, Wa2F2w inwa2, bool lockResource = false);
        public Task GeoCall(Wa1 inwa1, Wa2F3 inwa2, bool lockResource = false);
        public Task GeoCall(Wa1 inwa1, Wa2F3as inwa2, bool lockResource = false);
        public Task GeoCall(Wa1 inwa1, Wa2F3c inwa2, bool lockResource = false);
        public Task GeoCall(Wa1 inwa1, Wa2F3cas inwa2, bool lockResource = false);
        public Task GeoCall(Wa1 inwa1, Wa2F3x inwa2, bool lockResource = false);
        public Task GeoCall(Wa1 inwa1, Wa2F3xas inwa2, bool lockResource = false);
        public Task GeoCall(Wa1 inwa1, Wa2F3cx inwa2, bool lockResource = false);
        public Task GeoCall(Wa1 inwa1, Wa2F3cxas inwa2, bool lockResource = false);
        public Task GeoCall(Wa1 inwa1, Wa2F3e inwa2, bool lockResource = false);
        public Task GeoCall(Wa1 inwa1, Wa2F3eas inwa2, bool lockResource = false);
        public Task GeoCall(Wa1 inwa1, Wa2F3ce inwa2, bool lockResource = false);
        public Task GeoCall(Wa1 inwa1, Wa2F3ceas inwa2, bool lockResource = false);
        public Task GeoCall(Wa1 inwa1, Wa2F3s inwa2, bool lockResource = false);
        public Task GeoCall(Wa1 inwa1, Wa2F5 inwa2, bool lockResource = false);
        public Task GeoCall(Wa1 inwa1, Wa2F1p inwa2, bool lockResource = false);
        public Task GeoCall(Wa1 inwa1, Wa2Fap inwa2, bool lockResource = false);
        public Task GeoCall(Wa1 inwa1, Wa2Fapx inwa2, bool lockResource = false);
        public Task GeoCall(Wa1 inwa1, Wa2Fhr inwa2, bool lockResource = false);
        public Task GeoCall(WA inwa1, WA inwa2m, bool lockResource = false);
    }
}
