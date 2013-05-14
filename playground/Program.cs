using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculatorService
{
	[ServiceContract()]
		public interface ISimpleCalculator
	{
		[OperationContract()]
			int Add (int num1, int num2);
	}
}
namespace MyCalculatorService
{
	class SimpleCalculator : ISimpleCalculator
	{
		public int Add (int num1, int num2)
		{
			return num1 + num2;
		}
	}
}
namespace MyCalculatorServiceHost
{
	class Program
	{
		public static ServiceHost createServiceHost ()
		{
			//Create a URI to serve as the base address
			Uri httpUrl = new Uri ("http://localhost:8090/MyService/SimpleCalculator");
			//Create ServiceHost
			ServiceHost host 
					= new ServiceHost (typeof(MyCalculatorService.SimpleCalculator), httpUrl);
			//Add a service endpoint
			host.AddServiceEndpoint (typeof(MyCalculatorService.ISimpleCalculator)
				                        , new WSHttpBinding (), "");
			//Enable metadata exchange
			ServiceMetadataBehavior smb = new ServiceMetadataBehavior ();
			smb.HttpGetEnabled = true;
			host.Description.Behaviors.Add (smb);
			//Start the Service
			host.Open ();
			return host;
		}
	}
}
namespace MyCalculatorServiceProxy
{
	public class MyCalculatorServiceProxy : 
			//WCF create proxy for ISimpleCalculator using ClientBase
			ClientBase<MyCalculatorService.ISimpleCalculator>, MyCalculatorService.ISimpleCalculator
	{
		public MyCalculatorServiceProxy (Uri serviceUri)
		{
			base.Endpoint.Address = new EndpointAddress (serviceUri);
		}

		public int Add (int num1, int num2)
		{
			//Call base to do funtion
			return base.Channel.Add (num1, num2);
		}
	}
}
//
//<endpoint address ="http://localhost:8090/MyService/SimpleCalculator" 
//	binding ="wsHttpBinding"
//		contract ="MyCalculatorService.ISimpleCalculator">
//
//		</endpoint>
namespace MyCalculatorServiceClient
{
	class Program
	{
		private static Uri serviceUri = new Uri ("http://localhost:8090/MyService/SimpleCalculator");

		public static MyCalculatorService.ISimpleCalculator createClient ()
		{
			MyCalculatorServiceProxy.MyCalculatorServiceProxy proxy;
			proxy = new MyCalculatorServiceProxy.MyCalculatorServiceProxy (serviceUri);
			return proxy;
		}

		static void Main (string[] args)
		{
			var service = MyCalculatorServiceHost.Program.createServiceHost ();
			Console.WriteLine ("Service is host at " + DateTime.Now.ToString());

			Task.Factory.StartNew (() => {
				var client = MyCalculatorServiceClient.Program.createClient ();
				Console.WriteLine ("Client is running at " + DateTime.Now.ToString());
				Console.WriteLine ("Sum of two numbers... 5+5 =" + client.Add(5,5));
			}).Wait ();
			service.Close ();
		}
	}
}
