using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;

namespace WcfService.Configuration
{
    public class CustomConfigService
    {
        internal static void Configure<T>(ServiceConfiguration config, string classLocation, WebContentFormat typeContentMapper)
        {
            string basePath = string.Concat("http://localhost", classLocation);

            try
            {
                bool isHttps = basePath.ToUpper().StartsWith("HTTPS");
                ServiceEndpoint se = new ServiceEndpoint(ContractDescription.GetContract(typeof(T)), new CustomBinding(typeContentMapper, isHttps), new EndpointAddress(basePath));

                se.EndpointBehaviors.Add(new WebHttpBehavior { HelpEnabled = true });

                config.AddServiceEndpoint(se);
                config.Description.Behaviors.Add(new CustomServiceMetaDataBehavior());
                config.Description.Behaviors.Add(new CustomDebugBehavior());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}