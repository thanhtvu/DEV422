using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAppBlob.Controllers
{

    

    public class BlobController : Controller
    {


        // Client for interacting with Azure Blob Service storage
        private readonly BlobServiceClient blobServiceClient;

        private const string ContainerName = "files";

        // Constructor - initializes the controller with blob service client
        public BlobController (BlobServiceClient blobServiceClient)
        {
            this.blobServiceClient = blobServiceClient;

            // Initializes container whrn controller is created
            InitializeContainerAsync().GetAwaiter().GetResult();
        }


        // Creaate the blob container if it doesn't exist
        private async Task InitializeContainerAsync()
        {
            // Get reference to container
            var containerClient = blobServiceClient.GetBlobContainerClient(ContainerName);
            // create container if it doesn't exist, with public access level
            await containerClient.CreateIfNotExistsAsync(PublicAccessType.Blob);
        }



        // Action to display list of files on index page

        public async Task<IActionResult> Index()
        {

            // Get container reference
            var containerClient = blobServiceClient.GetBlobContainerClient(ContainerName);

            // get lists of blobs
            var blobs = containerClient.GetBlobsAsync();

            // Create list to store blob names
            var bloblist = new List<string>();

            await foreach (var blob in blobs)
            {
                bloblist.Add(blob.Name);
            }

            return View();
        }




        // Upload function
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            // Check if file is valid and selected
            if (file == null || file.Length == 0)
            {
                return BadRequest("No File selected");
            }

            //get the container reference
            var containerClient = blobServiceClient.GetBlobContainerClient(ContainerName);

            // get blob reference with the file name
            var blobClient = containerClient.GetBlobClient(file.FileName);

            // Upload file stream to blob storage

            using (var stream = file.OpenReadStream())
            {
                await blobClient.UploadAsync(stream, new BlobHttpHeaders
                {
                    ContentType = file.ContentType
                });
            }
            // redirect to index page after done uploading
            return RedirectToAction("Index");

        }


    }


}
