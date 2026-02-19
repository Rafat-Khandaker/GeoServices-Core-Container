using Microsoft.Azure.Batch;
using Microsoft.Azure.Batch.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoServices_Core_Commons.Core.Contract
{
    public interface IBatchClientService
    {
        public string ContainerImageName { get; set; }
        public ContainerConfiguration ContainerConfiguration { get; set; }
        public ContainerRegistry ContainerRegistry { get; set; }

        public ImageReference ImageReference { get; set; }
        public VirtualMachineConfiguration VirtualMachineConfiguration { get; set; }
        public string VirtualMachinePoolId { get; set; }
        public string VirtualMachineSize { get; set; }

        public int VirtualMachineTargetDedicatedComputeNodes { get; set; }

        public BatchSharedKeyCredentials Credentials { get; set; }
        public BatchClient Client { get; set; }

        public BatchClientService BuildConfiguration();
        public BatchClientService OpenBatchClient();

        public Task<BatchClientService> CreateCloudTask(string jobId, CloudTask task);

        public Task<BatchClientService> CreatePool();
    }
}
