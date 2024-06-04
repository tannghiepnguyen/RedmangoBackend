﻿using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

namespace Redmango_API.Services;

public class BlobService : IBlobService
{
    private readonly BlobServiceClient _blobServiceClient;

    public BlobService(BlobServiceClient blobServiceClient)
    {
        _blobServiceClient = blobServiceClient;
    }
    public async Task<string> GetBlob(string blobName, string containerName)
    {
        BlobContainerClient blobContainerClient = _blobServiceClient.GetBlobContainerClient((containerName));
        BlobClient blobClient = blobContainerClient.GetBlobClient((blobName));
        return blobClient.Uri.AbsoluteUri;
    }

    public async Task<bool> DeleteBlob(string blobName, string containerName)
    {
        BlobContainerClient blobContainerClient = _blobServiceClient.GetBlobContainerClient((containerName));
        BlobClient blobClient = blobContainerClient.GetBlobClient((blobName));
        return await blobClient.DeleteIfExistsAsync();
    }

    public async Task<string> UploadBlob(string blobName, string containerName, IFormFile file)
    {
        BlobContainerClient blobContainerClient = _blobServiceClient.GetBlobContainerClient((containerName));
        BlobClient blobClient = blobContainerClient.GetBlobClient((blobName));
        var httpHeaders = new BlobHttpHeaders()
        {
            ContentType = file.ContentType
        };
        var result = await blobClient.UploadAsync(file.OpenReadStream(), httpHeaders);
        if (result != null)
        {
            return await GetBlob(blobName, containerName);
        }

        return "";
    }
}