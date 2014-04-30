using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // web reference(for web service)
            WebServiceWebReference.WebService ws =
                new WebServiceWebReference.WebService();
            string test = ws.HelloWorld();


            // service reference(for web service)
            WebServiceReference.WebServiceSoapClient client = new WebServiceReference.WebServiceSoapClient();
            client.Endpoint.Address = new System.ServiceModel.EndpointAddress(
                "http://localhost:56009/WebService.asmx");
            string test1 = client.HelloWorld();


            // web reference(for wcf service)
            WCFWebReference.WCFService wcf =
                new WCFWebReference.WCFService();
            wcf.DoWork();


            // service reference(for wcf service)
            WCFServiceReference.WCFServiceClient client2 = new WCFServiceReference.WCFServiceClient();
            client.Endpoint.Address = new System.ServiceModel.EndpointAddress(
                "http://localhost:56009/WCFService.svc");
            client2.DoWork();
        }
    }
}
