using System;
using System.Net;
using System.Runtime.CompilerServices;

namespace Quicker.Modules.Searching.Builtin;

public class WebClientWithTimeout : WebClient
{
	[CompilerGenerated]
	private int AXrt0ENb4DN;

	internal static WebClientWithTimeout jOvKN0Qn5GBUvhr5lEEH;

	public int TimeoutMs
	{
		[CompilerGenerated]
		get
		{
			return AXrt0ENb4DN;
		}
		[CompilerGenerated]
		set
		{
			AXrt0ENb4DN = value;
		}
	}

	public WebClientWithTimeout(int timeoutMs)
	{
		TimeoutMs = timeoutMs;
	}

	protected override WebRequest GetWebRequest(Uri address)
	{
		WebRequest webRequest = base.GetWebRequest(address);
		webRequest.Timeout = TimeoutMs;
		return webRequest;
	}

	internal static bool mhvGt6QnYpoGr1RWsQ7O()
	{
		return jOvKN0Qn5GBUvhr5lEEH == null;
	}
}
