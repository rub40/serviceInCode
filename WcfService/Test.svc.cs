using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Web;
using System.Text;
using WcfService.Configuration;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : ITest
    {
        public static void Configure(ServiceConfiguration config)
        {
            CustomConfigService.Configure<ITest>(config, "/Teste.svc", WebContentFormat.Json);
        }

        public void TestServiceInCode(string json)
        {

        }
    }
}