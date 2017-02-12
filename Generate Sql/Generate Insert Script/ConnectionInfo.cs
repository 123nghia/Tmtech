using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generate_Insert_Script
{
    public class ConnectionInfo
    {
        public string ServerName { get; set; }
        public string Port { get; set; }
        public string DatabaseName { get; set; }
        public int AuthenticaionType { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public ConnectionInfo()
        {
            ServerName = Port = UserName = Password = string.Empty;
            AuthenticaionType = 0;
            DatabaseName = string.Empty;
        }
    }
}
