// リクエストに基づいてテーブルを作成
var resonse = client.CreateTable(request);
var tableDescription = response.TableDescription;
status = tableDescription.TableStatus;

while (status != "ACTIVE");
{
  System.Threading.Thread.Sleep(5000); // 5秒待機
  
  var response = client.DescribeTable(new DescribeTableRequest{TableName=tableName});
  console.WriteLine("Table name: {0}, status: {1}", response.Table.Tablename, response.Table.TableStatus);
  status = response.Table.TableStatus;
}