using System.ServiceModel;
using System.ServiceModel.Channels;

namespace WcfService.Configuration
{
	public class CustomBinding : WebHttpBinding
	{
		private HttpTransportBindingElement transport;
		private WebMessageEncodingBindingElement encoding;

		public CustomBinding(WebContentFormat contentMapper, bool isHttps) : base()
		{
			this.ContentTypeMapper = new CustomContentMapper(contentMapper);
			this.TransferMode = TransferMode.Streamed;

			this.encoding = new WebMessageEncodingBindingElement();
			if (isHttps)
			{
				this.Security.Mode = WebHttpSecurityMode.Transport;
				this.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
				this.Security.Transport.ProxyCredentialType = HttpProxyCredentialType.None;

				this.transport = new HttpsTransportBindingElement { ManualAddressing = true, TransferMode = TransferMode.Streamed, AuthenticationScheme = System.Net.AuthenticationSchemes.None };
			}
			else
			{
				this.transport = new HttpTransportBindingElement { ManualAddressing = true, TransferMode = TransferMode.Streamed };
			}
		}

		public override BindingElementCollection CreateBindingElements()
		{
			BindingElementCollection elements = new BindingElementCollection();

			elements.Add(this.encoding);
			elements.Add(this.transport);

			return elements;
		}

		public override string Scheme
		{
			get { return this.transport.Scheme; }
		}
	}
}