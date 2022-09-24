import boto3
import boto3.transfer

session = boto3.session.session(profile_name='staging')

current_region = session.region_name

resource = session.resources('s3')
bucket = resource.Bucket('notes-bucket')

bucket.create(
  CreateBucketConfiguration={
    'LocationConstraint': current_region
  }
)

resource.close