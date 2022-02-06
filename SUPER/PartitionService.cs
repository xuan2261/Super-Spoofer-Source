using System.Collections.Specialized;
using System.Net;

namespace SUPER
{
	internal sealed class PartitionService
	{
		public static byte[] MainLoad(string string_0, NameValueCollection nameValueCollection_0)
		{
			using (WebClient webClient = new WebClient())
				return webClient.UploadValues(string_0, nameValueCollection_0);
		}
	}
}
