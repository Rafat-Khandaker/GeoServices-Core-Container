using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace GeoServices_Batch_Trigger_Function_API
{
    public class UploadBatchFile
    {
        private readonly ILogger<UploadBatchFile> _logger;

        public UploadBatchFile(ILogger<UploadBatchFile> logger)
        {
            _logger = logger;
        }

        [FunctionName("UploadFile")]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            if (!req.Form.Files.Any())
                return new BadRequestObjectResult("No file provided");

            var file = req.Form.Files[0];

            var blobServiceClient = new BlobServiceClient(
                        Environment.GetEnvironmentVariable("BlobConnectionString"));

            var containerClient = blobServiceClient.GetBlobContainerClient("uploads");
            await containerClient.CreateIfNotExistsAsync();

            var blobClient = containerClient.GetBlobClient(file.FileName);

            using var stream = file.OpenReadStream();
            await blobClient.UploadAsync(stream, overwrite: true);

            return new OkObjectResult("File uploaded successfully");
        }
    }
}
