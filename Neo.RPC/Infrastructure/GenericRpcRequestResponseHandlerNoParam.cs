﻿using System.Threading.Tasks;
using Neo.JsonRpc.Client;

namespace Neo.RPC.Infrastructure
{
    public class GenericRpcRequestResponseHandlerNoParam<TResponse> : RpcRequestResponseHandlerNoParam<TResponse>
    {
        public GenericRpcRequestResponseHandlerNoParam(IClient client, string methodName) : base(client, methodName)
        {
        }

        public new Task<TResponse> SendRequestAsync(object id = null)
        {
            return base.SendRequestAsync(id);
        }
    }
}
