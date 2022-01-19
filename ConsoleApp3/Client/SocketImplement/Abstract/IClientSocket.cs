using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Client.SocketImplement.Abstract
{
    public interface IClientSocket
    {
        public void Connect();
        public string Receive();
        public void Send(byte[] data);
        public void Close();
    }
}
