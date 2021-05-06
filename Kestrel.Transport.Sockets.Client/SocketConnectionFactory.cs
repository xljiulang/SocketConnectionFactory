using Microsoft.AspNetCore.Connections;
using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets.Client
{
    [Obsolete("该类型已弃用，请使用services.AddSocketConnectionFactory()方法替代", error: true)]
    public class SocketConnectionFactory : IConnectionFactory
    {
        public ValueTask<ConnectionContext> ConnectAsync(EndPoint endpoint, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
