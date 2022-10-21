using System.ServiceModel.Description;

namespace WcfService.Configuration
{
    public class CustomDebugBehavior : ServiceDebugBehavior
    {
        public CustomDebugBehavior() : base()
        {
            IncludeExceptionDetailInFaults = false;
        }
    }
}