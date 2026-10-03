using System;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.Wpf;

namespace upLrfmibGdtSX9dWuOT;

internal static class V1kWZri8vrLTHgNDH0k
{
	public static class A3gYBiH70UKJSIvqdr2
	{
		internal static object RV1PcGyJpGTFnmIIoHHf;

		public static Eo8rWkHivjgssDn80CJ EkR2PG1vawD()
		{
			return new Eo8rWkHivjgssDn80CJ(srC2PsE8ibw());
		}

		private static string srC2PsE8ibw()
		{
			try
			{
				return CoreWebView2Environment.GetAvailableBrowserVersionString(null, null);
			}
			catch (Exception)
			{
				return "";
			}
		}

		internal static bool iZP2fmyJXbi9TDN3pCxG()
		{
			return RV1PcGyJpGTFnmIIoHHf == null;
		}
	}

	public class Eo8rWkHivjgssDn80CJ
	{
		[CompilerGenerated]
		private readonly string WOT2P6VwHL4;

		internal static Eo8rWkHivjgssDn80CJ FKWOLyyJA5wZI7Jg5Hmn;

		public string Version
		{
			[CompilerGenerated]
			get
			{
				return WOT2P6VwHL4;
			}
		}

		public Eo8rWkHivjgssDn80CJ(string string_1)
		{
			WOT2P6VwHL4 = string_1;
		}

		[SpecialName]
		public hgh80BHm0o6IE7HTQRK skG2P14t6Ce()
		{
			string text;
			while (true)
			{
				text = Version;
				if (!i79L9uyJnoJ0IYYeDM1u())
				{
					switch (0)
					{
					case 1:
						continue;
					}
				}
				break;
			}
			if (text.Contains("dev"))
			{
				return (hgh80BHm0o6IE7HTQRK)3;
			}
			if (text.Contains("beta"))
			{
				return (hgh80BHm0o6IE7HTQRK)1;
			}
			if (text.Contains("canary"))
			{
				return (hgh80BHm0o6IE7HTQRK)2;
			}
			if (!string.IsNullOrEmpty(text))
			{
				return (hgh80BHm0o6IE7HTQRK)0;
			}
			return (hgh80BHm0o6IE7HTQRK)4;
		}

		internal static bool i79L9uyJnoJ0IYYeDM1u()
		{
			return FKWOLyyJA5wZI7Jg5Hmn == null;
		}
	}

	public enum hgh80BHm0o6IE7HTQRK
	{

	}

	private static object yZfCHVF4uFIsji0Ym8Dt;

	public static bool kthvSy0kT0j()
	{
		return A3gYBiH70UKJSIvqdr2.EkR2PG1vawD().skG2P14t6Ce() != (hgh80BHm0o6IE7HTQRK)4;
	}

	public static string NoGvS8R8WYG()
	{
		return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Quicker", "WebView2");
	}

	public static CoreWebView2CreationProperties y0qvSaX2h6Z()
	{
		return new CoreWebView2CreationProperties
		{
			UserDataFolder = NoGvS8R8WYG(),
			AdditionalBrowserArguments = " --enable-features=msWebView2EnableDraggableRegions"
		};
	}

	public static string rBBvS7i0YGN(string string_0)
	{
		return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Quicker", $"WebView2_{string_0.GetHashCode()}");
	}

	internal static bool zZoEGuF4oNNrhoxCKesG()
	{
		return yZfCHVF4uFIsji0Ym8Dt == null;
	}
}
