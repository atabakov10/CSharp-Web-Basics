using System.Net;
using System.Net.Sockets;
using System.Text;
using SUHttpServer;

var server = new HttpServer("127.0.0.1", 8080);
server.Start();

