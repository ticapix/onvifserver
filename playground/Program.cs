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

		public static Uri serviceUri = new Uri ("http://localhost:8090/MyService/");

		public static ServiceHost createServiceHost ()
		{
			//Create ServiceHost
			ServiceHost host = new ServiceHost (typeof(MyCalculatorService.SimpleCalculator), serviceUri);
			//Add a service endpoint
			host.AddServiceEndpoint (typeof(MyCalculatorService.ISimpleCalculator), new WSHttpBinding (), "SimpleCalculator");
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
		public MyCalculatorServiceProxy(Binding binding, EndpointAddress remoteAddress) : 
			base(binding, remoteAddress)
		{
		}

		public int Add (int num1, int num2)
		{
			//Call base to do funtion
			return base.Channel.Add (num1, num2);
		}
	}
}

namespace playgound
{
	class Program
	{
		static void Main (string[] args)
		{
			ServiceHost service = MyCalculatorService.SimpleCalculator.createServiceHost ();

			Task.Factory.StartNew (() => {
				Uri serviceUri = new Uri(MyCalculatorService.SimpleCalculator.serviceUri, "SimpleCalculator");
				Binding binding = new WSHttpBinding();
				EndpointAddress address = new EndpointAddress(serviceUri);
				MyCalculatorService.ISimpleCalculator client = new MyCalculatorServiceProxy.MyCalculatorServiceProxy (binding, address);
				Console.WriteLine ("Sum of two numbers... 5+5 =" + client.Add(5,5));
			}).Wait ();
			service.Close ();
		}
	}
}
