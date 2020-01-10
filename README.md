# SocketConnectionFactory
kestrel在.netcore3.1发布之后增加了SocketConnectionFactory类，该工厂用于创建基于Pipe操作的双工Tcp连接抽象ConnectionContext对象。
本项目将其代码剥离出来，以支持在.netcore3.1下使用SocketConnectionFactory。

### 如何使用
#### 1 注册工厂
```
services.AddSingleton<IConnectionFactory, SocketConnectionFactory>();
```

#### 2 连接、接收与发送
```
 var remoteEndPoint = new IPEndPoint(IPAddress.Loopback, 8888);
 var connection = await this.connectionFactory.ConnectAsync(remoteEndPoint);
 var readResult = await connection.Transport.Input.ReadAsync();
 var writeResult = await connection.Transport.Output.WriteAsync(new Byte[]{1,2,3});
```

### nuget
```
<PackageReference Include="Kestrel.Transport.Sockets.Client" Version="3.1.0" />
```
