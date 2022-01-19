using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PingPong.Client.SocketImplement.Abstract;
using System.Net;
using System.Net.Sockets;

namespace PingPong.Client.SocketImplement.Implemention
{
    public class ClientSyncSocket : IClientSocket
    {
        public IPEndPoint IPEndPoint;
        public Socket Sender;
        private byte[] _bytes;

        public ClientSyncSocket(IPEndPoint iPEndPoint)
        {
            _bytes = new byte[1024];
            IPEndPoint = iPEndPoint;
            Sender= new Socket(IPEndPoint.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);
        }

        public void Connect()
        {
            Sender.Connect(IPEndPoint);
        }

        public string Receive()
        {
            int bytesRec = Sender.Receive(_bytes);
            return Encoding.ASCII.GetString(_bytes, 0, bytesRec);
        }

        public void Send(byte[] data)
        {
            Sender.Send(data);
        }
        public void Close()
        {
            Sender.Close();
        }
    }
}
