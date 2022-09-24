# 低レベルAPI、バケットのオブジェクトを一覧表示
def listClient():
  s3client = boto3.client('s3')
  response = s3client.list_objects_v2(Bucket='mybucket')
  for content in response['Contents']:
    print(content['Key'],content['LastModified'])
    
# 高レベルAPI、バケットのオブジェクトを一覧表示
def listResource():
  s3resource = boto3.resource('s3')
  bucket = s3resource.Bucket('mybucket')
  for object in bucket.objects.all():
    print(object.key, object.last_modified)