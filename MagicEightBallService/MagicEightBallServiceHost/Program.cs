using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using MagicEightBallService;

namespace MagicEightBallServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Console Based WCF Host * ****");
            using (ServiceHost host = new ServiceHost(typeof(MagicEightBallService.MagicEightBallService)))
            {
                host.Open();
                DisplayHostInfo(host);

                Console.WriteLine("The service is ready.");
                Console.WriteLine("Press the Enter key to terminate service.");
                Console.ReadLine();
            }
        }

        static void DisplayHostInfo(ServiceHost host)
        {
            Console.WriteLine("Host infor:");
            foreach (System.ServiceModel.Description.ServiceEndpoint se in host.Description.Endpoints)
            {
                Console.WriteLine($"address = {se.Address}");
                Console.WriteLine($"binding = {se.Binding.Name}");
                Console.WriteLine($"contract = {se.Contract.Name}");
            }
        }
    }
}
