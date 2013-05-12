using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace server
{
    class Program
    {

		public static String serviceUri = "http://localhost:8000/Device";

        static void Main(string[] args)
        {
            var host = createListener(serviceUri);
			Console.WriteLine("Service initialized.");
			Console.WriteLine("Press the ENTER key to terminate service.");
			Console.WriteLine();
			Console.ReadLine();
			destroyListener (host);
        }

		public static ServiceHost createListener(String serviceUri)
        {
			Uri baseAddr = new Uri(serviceUri);
            ServiceHost localHost = new ServiceHost(typeof(server.Device), baseAddr);

            try
            {
                localHost.AddServiceEndpoint(typeof(Onvif.Devicemgmt.Device), new WSHttpBinding(), "CameraDevice");

                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                localHost.Description.Behaviors.Add(smb);
                localHost.Open();
            }
            catch (CommunicationException ex)
            {
                Console.WriteLine("Oops! Exception: {0}", ex.Message);
                localHost.Abort();
            }
			return localHost;
        }

		public static void destroyListener(ServiceHost localHost)
		{
			try
			{
				localHost.Close();
			}
			catch (CommunicationException ex)
			{
				Console.WriteLine("Oops! Exception: {0}", ex.Message);
				localHost.Abort();
			}
		}


    }
}
