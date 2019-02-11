using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebServer
{
    class SimpleWebServer
    {
        static void Main(string[] args)
        {
            IPAddress address = IPAddress.Parse("127.0.0.1");
            int port = 8080;
            TcpListener listener = new TcpListener(address, port);
            listener.Start();

            Console.WriteLine("Server started");
            Console.WriteLine("Listening to TCP clients at 127.0.0.1:{0}", port);

            var task = Task.Run(async () => await ConnectWithTcpClient(listener));
            task.Wait();
        }

        public static async Task ConnectWithTcpClient(TcpListener listener)
        {
            while (true)
            {
                Console.WriteLine("Waiting for client...");

                var client = await listener.AcceptTcpClientAsync();

                Console.WriteLine("Client connected");

                byte[] buffer = new byte[1024];
                await client.GetStream().ReadAsync(buffer, 0, buffer.Length);

                var message = Encoding.ASCII.GetString(buffer);
                Console.WriteLine(message.Trim('\0'));

                byte[] data = Encoding.UTF8.GetBytes("HTTP/1.1 200 OK\nContent-Type: text/plain\n\nHello from server");
                await client.GetStream().WriteAsync(data, 0, data.Length);

                Console.WriteLine("Closing connection");
                client.GetStream().Dispose();
            }
        }
    }
}
