dynamodb = boto3.resource('dynamodb')

table = dynamodb.create_table(
  TableName='Notes',
  ...)

# テーブルが作成されるまで待機する
table.meta.client.get_waiter('table_exists').wait(TableName='Notes')

print(table.item_count)