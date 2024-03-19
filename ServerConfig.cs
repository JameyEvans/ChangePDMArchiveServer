using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangePDMArchiveServer
{
    public class ServerConfig
    {
        public List<Server> Servers { get; set; }
        public List<string> VaultNames { get; set; }
    }
}
