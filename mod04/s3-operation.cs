import Amazon.S3.Trainsfer
import Amazon.S3
import Amazon.S3.Model
import Amazon.S3.Encryption

AmazonS3Config S3Config = AmazonS3Config {
  ServiceURL = "s3.amazonaws.com",
  CommunicationProtocol = Amazon.S3.Model.Protocol.HTTP
};

AmazonS3Client s3Client = new AmazonS3Client(accesskey, secretKey, s3Config);

ListObjectsRequest request = new ListObjectsRequest();
console.writeLine($"Total buckets: {listResponse.Buckets.count}");
foreach(S3Bucket b in listResponse.Buckets) {
  console.writeLine(b.BucketName);
}