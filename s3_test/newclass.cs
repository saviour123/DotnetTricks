using Amazon.Runtime.CredentialManagement;
using Amazon.S3;
using Amazon.S3.Model;
using System;
using System.Threading.Tasks;

namespace Amazon.DocSamples.S3
{
    class UploadObjectTest
    {
        private const string bucketName = "shalombucket";
        // Example creates two objects (for simplicity, we upload same file twice).
        // You specify key names for these objects.
        private const string keyName1 = "*** key name for first object created ***";
        private const string keyName2 = "*** key name for second object created ***";
        private const string filePath = @"*** file path ***";
        private static readonly RegionEndpoint bucketRegion = RegionEndpoint.EUWest1; 

        private static IAmazonS3 client;

        public static void Main()
        {
            var options = new CredentialProfileOptions{
                AccessKey = "AKIAIXAZZ67QITDQHCJA",
                SecretKey = "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"
            };

            client = new AmazonS3Client(bucketRegion);
            WritingAnObjectAsync().Wait();
        }

        static async Task WritingAnObjectAsync()
        {
            try
            {
                // 1. Put object-specify only key name for the new object.
                var putRequest1 = new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = keyName1,
                    ContentBody = "sample text"
                };

                PutObjectResponse response1 = await client.PutObjectAsync(putRequest1);

                // 2. Put the object-set ContentType and add metadata.
                var putRequest2 = new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = keyName2,
                    FilePath = filePath,
                    ContentType = "text/plain"
                };
                putRequest2.Metadata.Add("x-amz-meta-title", "someTitle");
            }
            catch (AmazonS3Exception e)
            {
                Console.WriteLine(
                        "Error encountered ***. Message:'{0}' when writing an object"
                        , e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(
                    "Unknown encountered on server. Message:'{0}' when writing an object"
                    , e.Message);
            }
        }
    }
}