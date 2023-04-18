using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Microsoft.AspNetCore.Mvc;

namespace AWS.API.Controllers;

[ApiController]
[Route("[controller]")]
public class FileController : ControllerBase
{
    //creae client
    private readonly IAmazonS3 client;
    private const string bucketName = "deepak-demo-aws-tutorial"; //Bucket name of s3
    public FileController(IAmazonS3 client)
    {
        this.client = client;
    }


    [HttpPost]
    [Route("[action]")]
    public async Task<IActionResult> Post(IFormFile file)
    {
        //check if the bucket name is available or bucket is created
        var bucketExists = await AmazonS3Util.DoesS3BucketExistV2Async(client, bucketName);
        if (!bucketExists)
        {
            //create bucket
            var bucketRequest = new PutBucketRequest()
            {
                BucketName = bucketName,
                UseClientRegion = true
            };
            await client.PutBucketAsync(bucketRequest);
        }
        //create object to store
        //S3 Storage 
        var bucketObject = new PutObjectRequest()
        {
            BucketName = bucketName,
            Key = $"{DateTime.UtcNow:MMddyyyyhhmmss}{file.FileName}",
            InputStream = file.OpenReadStream(),
        };
        var response = await client.PutObjectAsync(bucketObject);

        return Ok(response.HttpStatusCode);
    }

    [HttpGet]
    [Route("[action]")]
    public async Task<IActionResult> GetFile(string fileName)
    {
        var response = await client.GetObjectAsync(bucketName, fileName);

        return File(response.ResponseStream, response.Headers.ContentType);
    }

    [HttpGet]
    [Route("[action]")]
    public async Task<IActionResult> GetFilesNames()
    {
        var request = new ListObjectsV2Request()
        {
            BucketName = bucketName
        };
        var response = await client.ListObjectsV2Async(request);
        var objects = response.S3Objects.Select(s => $"{s.Key} --- {s.StorageClass}");
        return Ok(objects);
    }

    [HttpGet]
    [Route("[action]")]
    public async Task<IActionResult> GetFilesUrl()
    {
        var request = new ListObjectsV2Request()
        {
            BucketName = bucketName
        };
        var response = await client.ListObjectsV2Async(request);
        var objects = response.S3Objects.Select(s =>
        {
            var resp = new GetPreSignedUrlRequest()
            {
                BucketName = bucketName,
                Key = s.Key,
                Expires = DateTime.UtcNow.AddSeconds(30)
            };
            return client.GetPreSignedURL(resp);
        });
        return Ok(objects);
    }

    [HttpDelete]
    [Route("[action]")]
    public async Task<IActionResult> DeleteFile(string fileName)
    {
        var response = await client.GetObjectAsync(bucketName, fileName);

        return File(response.ResponseStream, response.Headers.ContentType);
    }
}
