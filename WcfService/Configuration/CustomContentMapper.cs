using System.ServiceModel.Channels;

namespace WcfService.Configuration
{
	public class CustomContentMapper : WebContentTypeMapper
	{
		public WebContentFormat WebFormat = WebContentFormat.Default;
		public CustomContentMapper(WebContentFormat webContentformat)
		{
			WebFormat = webContentformat;
		}
		public override WebContentFormat GetMessageFormatForContentType(string contentType)
		{
			return WebFormat;
		}
	}
}
