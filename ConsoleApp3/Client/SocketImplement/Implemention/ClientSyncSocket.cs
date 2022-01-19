using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PingPong.Client.SocketImplement.Abstract;

namespace PingPong.Client.SocketImplement.Implemention
{
    public class ClientSyncSocket : IClientSocket
    {
        public void Connect()
        {
            
        }

        public byte[] Receive()
        {
            throw new NotImplementedException();
        }

        public void Send(byte[] data)
        {
            throw new NotImplementedException();
        }
        public void Close()
        {
            throw new NotImplementedException();
        }
    }
}
