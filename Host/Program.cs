using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF;
using System.ServiceModel;
using System.ServiceModel.Description;
using MyPhotosV2;
namespace HostWCF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lansare server WCF...");
            ServiceHost host = new ServiceHost(typeof(SMyPhoto),
           new Uri("http://localhost:8000/MyPhotos"));
            //  Console.WriteLine(host.Description.Endpoints.Count);
            foreach (ServiceEndpoint se in host.Description.Endpoints)
            {
                Console.WriteLine(se.ToString());
            }
            host.Open();
            Console.WriteLine("Server in executie. Se asteapta conexiuni...");
            Console.WriteLine("Apasati Enter pentru a opri serverul!");
            Console.ReadKey();
            host.Close();
        }
    }

}