using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using PingPong.Server.Implemention;
using PingPong.Client.Implemention;
using PingPong.Server.SocketImplement.Implemention;
using PingPong.Client.SocketImplement.Implemention;
using PingPong.Input.Implemention;
using PingPong.Output.Implemention;

namespace PingPong
{
    class Class1
    {    
        public static void Main(String[] args)
        {
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11000);

            SyncTcpSocket serverSocket = new SyncTcpSocket(localEndPoint);
            TcpServer tcpServer = new TcpServer(serverSocket);

            ClientSyncSocket clientSocket = new ClientSyncSocket(localEndPoint);
            PingPongClient pingPongClient = new PingPongClient(clientSocket, new ConsoleInput(), new ConsoleOutput());

            tcpServer.StartListening();
            pingPongClient.StartClient();
        }
    }
}
