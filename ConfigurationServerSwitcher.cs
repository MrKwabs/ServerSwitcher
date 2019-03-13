using Rocket.API;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ServerSwitcher
{
    public class ConfigurationServerSwitcher : IRocketPluginConfiguration
    {
        [XmlArrayItem(ElementName = "Server")]
        public List<Server> Servers;

        public void LoadDefaults()
        {
            Servers = new List<Server>()
            {
                new Server() { Name = "Server1", IP = "127.0.0.1", Port = 27015, Password = "password", Delay = 5f }
            };
        }
    }

    public class Server
    {
        public Server() { }

        public string Name;
        public string IP;
        public ushort Port;
        public string Password;
        public float Delay;
    }
}
