using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pippi_AsyncSocketLib;

namespace Pippi_AsyncSocketClient_5B
{
    class Program
    {
        static void Main(string[] args)
        {
            AsyncSocketClient mClient = new AsyncSocketClient();
            string ip = null;
            string port = null;

            Console.WriteLine("Inserisci Ip: " );
            ip = Console.ReadLine();
            Console.WriteLine("inserisci porta: ");
            port = Console.ReadLine();


            if (mClient.SerServerIPAddress(ip) && mClient.SetServerPort(port))
            {
                mClient.ConnettiAlServer();
                string messagio = "";
                while (messagio != "quit")
                {
                    messagio = Console.ReadLine();
                    mClient.invia(messagio);
                }
            }
            else
            {
                Console.WriteLine("Ip o Porta non validi.");
            }
            Console.ReadLine();
        }
    }
}
