import (
  software.amazon.awssdk.services.s3,
  software.amazon.awssdk.services.s3.model,
  software.amazon.awssdk.services.s3.S3Client,
  software.amazon.awssdk.services.s3.S3AsyncClient
)

Region region = Region.US_WEST_2;

S3Client s3 = S3Client.builder()
  .region(region)
  .credentialsProvider(ProfileCredentialsProvider.create("profile_name"))
  .build();

s3.createBucket(new CreateBucketRequest(bucketname));