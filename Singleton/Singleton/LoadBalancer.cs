using System;
using System.Collections.Generic;

namespace Singleton
{
    internal sealed class LoadBalancer
    {

        private static readonly LoadBalancer Instance = new LoadBalancer();

        private readonly List<Server> _servers;
        private readonly Random _random = new Random();

        private LoadBalancer()
        {
            _servers = new List<Server>
            {
                new Server{ Id = Guid.NewGuid(), Name = "ServerI", IP = "120.20.220.20"},
                new Server{ Id = Guid.NewGuid(), Name = "ServerII", IP = "120.20.220.21"},
                new Server{ Id = Guid.NewGuid(), Name = "ServerIII", IP = "120.20.220.22"},
                new Server{ Id = Guid.NewGuid(), Name = "ServerIV", IP = "120.20.220.23"},
                new Server{ Id = Guid.NewGuid(), Name = "ServerV", IP = "120.20.220.24"}
            };
        }

        public static LoadBalancer GetLoadBalancer()
        {
            return Instance;
        }

        public Server NextServer
        {
            get
            {
                var r = _random.Next(_servers.Count);
                return _servers[r];
            }
        }

    }
}
