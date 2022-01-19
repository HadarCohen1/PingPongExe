using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace PingPong.Server.SocketImplement.Implemention
{
    public class SyncTcpSocket : ISocket
    {
        public IPEndPoint IPEndPoint;
        public string Data;
        public Socket Listener;
        public Socket Handler;
        private byte[] _bytes;

        public SyncTcpSocket(IPEndPoint iPEndPoint)
        {
            _bytes = new Byte[1024];
            IPEndPoint = iPEndPoint;
            Data = null;
            Listener = new Socket(IPEndPoint.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);
        }


        public void StartListening()
        {
            try
            {
                Listener.Bind(IPEndPoint);
                Listener.Listen();
                Handler = Listener.Accept();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public string Receive()
        {
            while (true)
            {
                _bytes = new byte[1024];
                int bytesRec = Handler.Receive(_bytes);
                Data += Encoding.ASCII.GetString(_bytes, 0, bytesRec);
                if (Data.IndexOf("<EOF>") > -1)
                {
                    break;
                }
            }
            return Data;
        }

        public void Send(byte[] data)
        {
            Handler.Send(data);
        }

        public void Close()
        {
            Handler.Shutdown(SocketShutdown.Both);
            Handler.Close();
        }
    }
}
