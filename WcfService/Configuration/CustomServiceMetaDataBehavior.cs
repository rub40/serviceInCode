using System.ServiceModel.Description;

namespace WcfService.Configuration
{
    public class CustomServiceMetaDataBehavior : ServiceMetadataBehavior
    {
        public CustomServiceMetaDataBehavior(): base()
        {
            HttpGetEnabled = true;
            HttpsGetEnabled = true;
        }
    }
}