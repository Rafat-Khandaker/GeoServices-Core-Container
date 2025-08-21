using GeoXWrapperLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoXWrapperTest.Model;
using GeoXWrapperTest.Model.Display;
using GeoXWrapperTest.Model.Response;
using GeoXWrapperTest.Model.Contracts;

namespace GeoXWrapperTest.Service.Contracts
{
    public interface IGeoService
    {
        public GeocallResponse<F1aDisplay, F1aResponse> Function1A(FunctionInput input);

        public GeocallResponse<F1bDisplay, F1bResponse> Function1B(FunctionInput input);

        public GeocallResponse<F1eDisplay, F1eResponse> Function1E(FunctionInput input);
        public GeocallResponse<F1lDisplay, F1lResponse> Function1L(FunctionInput input);

        public GeocallResponse<F1nDisplay, F1nResponse> Function1N(FunctionInput input);

        public GeocallResponse<F1rDisplay, F1rResponse> Function1R(FunctionInput input);

        public GeocallResponse<F2Display, F2Response> Function2NodeId(FunctionInput input);

        public GeocallResponse<F2Display, F2Response> Function2(FunctionInput input);

        public GeocallResponse<F3cDisplay, F3cResponse> Function3C(FunctionInput input);
       
        public GeocallResponse<F3sDisplay, F3sResponse> Function3S(FunctionInput input);

        public GeocallResponse<F3Display, F3Response> Function3(FunctionInput input);
        public GeocallResponse<F5Display, F5Response> Function5(FunctionInput input);
        public GeocallResponse<FapDisplay, FapResponse> FunctionAP(FunctionInput input);
        public GeocallResponse<FBBLDisplay, FBBLResponse> FunctionBBL(FunctionInput input);
        public GeocallResponse<FBBDisplay, FBBResponse> FunctionBB(FunctionInput input);

        public GeocallResponse<FBNDisplay, FBNResponse> FunctionBIN(FunctionInput input);
        public GeocallResponse<FBFDisplay, FBFResponse> FunctionBF(FunctionInput input);

        public GeocallResponse<FDDisplay, FDResponse> FunctionD(FunctionInput input);

        public GeocallResponse<FHRDisplay, FHRResponse> FunctionHR();
        public GeocallResponse<FNDisplay, FNResponse> FunctionN(FunctionInput input);



    }
}
