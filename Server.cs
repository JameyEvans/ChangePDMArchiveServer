using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ChangePDMArchiveServer
{
    public class Server
    {
        public bool IsReachable
        {
            get
            {
                return (Ping >= 0);
            }
        }
        public string Name { get; set; }
        public string Location { get; set; }
        public double Ping { get; set; }
        public List<string> Vaults { get; set; } = new List<string>();

        public string FormDisplay
        {
            get
            {
                return ToString();
            }
        }

        public Server(string name, string location, double ping = 0, List<string>? vaults = null)
        {
            Name = name;
            Location = location;
            Ping = ping;
            PingServer();
            if (vaults != null)
            {
                Vaults = vaults;
            }

        }

        public override string ToString()
        {
            if (IsReachable)
            {
                return $"{Name} ({Location} : {Ping} ms)";
            }
            else
            {
                return $"{Name} ({Location} : Unreachable)";
            }

        }

        public void PingServer()
        {
            Ping pingSender = new Ping();
            // Create a buffer of 32 bytes of data to be transmitted.
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes(data);

            // Wait 10 seconds for a reply.
            int timeout = 10000;

            // Set options for transmission:
            // The data can go through 64 gateways or routers
            // before it is destroyed, and the data packet
            // cannot be fragmented.
            PingOptions options = new PingOptions(64, true);
            try
            {
                PingReply reply = pingSender.Send(Name, timeout, buffer, options);

                if (reply.Status == IPStatus.Success)
                {
                    Ping = reply.RoundtripTime;

                }
                else
                {
                    Ping = -99;
                }

            }
            catch (Exception e)
            {
                Ping = -99;
            }


        }
    }
}
