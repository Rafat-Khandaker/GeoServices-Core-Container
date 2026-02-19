using GeoServices_Core_Commons.Core.Contract;
using Microsoft.Azure.Batch;
using Microsoft.Azure.Batch.Auth;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;



namespace GeoServices_Core_Commons.Core
{
    public class BatchClientService : IBatchClientService
    {
        public string ContainerImageName { get; set; }
        public ContainerConfiguration ContainerConfiguration { get;  set; }
        public ContainerRegistry ContainerRegistry { get; set; }

        public ImageReference ImageReference { get; set; }
        public VirtualMachineConfiguration VirtualMachineConfiguration { get; set; }
        public string VirtualMachinePoolId { get; set; }
        public string VirtualMachineSize { get; set; }

        public int VirtualMachineTargetDedicatedComputeNodes { get; set; }

        public BatchSharedKeyCredentials Credentials { get; set; }
        public BatchClient Client { get; set; }

        public BatchClientService() { }

        public BatchClientService BuildConfiguration() {
            Credentials = new BatchSharedKeyCredentials(
                Environment.GetEnvironmentVariable("BATCH_URL"),
                Environment.GetEnvironmentVariable("BATCH_ACCOUNT"),
                Environment.GetEnvironmentVariable("BATCH_KEY")
            );

            ContainerRegistry = new ContainerRegistry(
                registryServer: Environment.GetEnvironmentVariable("ACR_REGISTRY_SERVER"),
                userName: Environment.GetEnvironmentVariable("ACR_USERNAME"),
                password: Environment.GetEnvironmentVariable("ACR_PASSWORD")
            );

            ImageReference = new ImageReference(
                    publisher: Environment.GetEnvironmentVariable("ACR_IMAGE_PUBLISHER"),
                    offer: Environment.GetEnvironmentVariable("ACR_IMAGE_OFFER"),
                    sku: Environment.GetEnvironmentVariable("ACR_IMAGE_SKU"),
                    version: Environment.GetEnvironmentVariable("ACR_IMAGE_VERSION")
                );

            ContainerConfiguration = new ContainerConfiguration {
                ContainerImageNames = new List<string> { ContainerImageName },
                ContainerRegistries = new List<ContainerRegistry> { ContainerRegistry },
                Type = Microsoft.Azure.Batch.Protocol.Models.ContainerType.DockerCompatible
            };

            VirtualMachineConfiguration = new VirtualMachineConfiguration(
                imageReference: ImageReference,
                nodeAgentSkuId: Environment.GetEnvironmentVariable("ACR_IMAGE_NODE")
            ){
                ContainerConfiguration = ContainerConfiguration
            };
            return this;
        }

        public BatchClientService OpenBatchClient() {
            Client = BatchClient.Open(Credentials);
            return this;
        }
        public async Task<BatchClientService> CreateCloudTask(string jobId, CloudTask task)
        {
            await Client.JobOperations.AddTaskAsync(jobId, task);
            return this;
        }

        public async Task<BatchClientService> CreatePool()
        {
            var pool = Client.PoolOperations.CreatePool(
                    poolId: VirtualMachinePoolId,
                    virtualMachineSize: VirtualMachineSize,
                    virtualMachineConfiguration: VirtualMachineConfiguration,
                    targetDedicatedComputeNodes: VirtualMachineTargetDedicatedComputeNodes
                );

            await pool.CommitAsync();
            return this;
        }
    }
}
