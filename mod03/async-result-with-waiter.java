waiter waiter = client.waiters().tableExists();

try {
  waiter.run(new WaiterParameters<>(new DescribeTableRequest(tableName));
} catch(waiterUnrecoverableException e) {
  // エラー処理
} catch(waiterTimeOutException e) {
  // エラー処理
} catch(DynamoDBException e) {
  // エラー処理
}