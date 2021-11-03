using System;

namespace Singleton
{
    public class Server
    {
        public Guid Id { get; set; } //Para validar de que é o mesmo server
        public string Name { get; set; }
        public string IP { get; set; }
    }
}