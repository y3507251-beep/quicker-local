using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Web;
using HtmlAgilityPack;

namespace Quicker.Utilities;

public static class WebSiteInfoHelper
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRetriveSiteInfoAsync_003Ed__0 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<WebsiteInfo> _003C_003Et__builder;

		public string url;

		private Uri _003Curi_003E5__2;

		private WebsiteInfo _003CsiteInfo_003E5__3;

		private HttpClient _003Cclient_003E5__4;

		private Exception _003C_003E7__wrap4;

		private int _003C_003E7__wrap5;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter _003C_003Eu__2;

		private Exception _003Cex_003E5__7;

		internal static object QOdqVyy3aaENPoxVvkh1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			WebsiteInfo result4;
			try
			{
        int num4 = default;
				if ((uint)num > 1u)
				{
					if (num == 2)
					{
						goto IL_0458;
					}
					if (string.IsNullOrEmpty(url))
					{
						throw new ArgumentNullException("url", "网址不能为空。");
					}
					_003Curi_003E5__2 = new Uri(url);
					_003CsiteInfo_003E5__3 = new WebsiteInfo();
					_003CsiteInfo_003E5__3.RootUrl = PijLA2o03R4(url);
					_003Cclient_003E5__4 = new HttpClient();
					_003Cclient_003E5__4.Timeout = TimeSpan.FromSeconds(2.0);
					_003C_003E7__wrap5 = 0;
				}
				try
				{
					ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter awaiter = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
					ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter awaiter2 = default(ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter);
					int num2 = default(int);
					if (num != 0)
					{
						if (num != 1)
						{
							awaiter = _003Cclient_003E5__4.GetStringAsync(new Uri(_003CsiteInfo_003E5__3.RootUrl)).ConfigureAwait(false).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 0;
								_003C_003E1__state = 0;
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_035d;
						}
						awaiter2 = _003C_003Eu__2;
						_003C_003Eu__2 = default(ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter);
						num2 = 5;
						goto IL_0134;
					}
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
					int num3 = 2;
					if (!X1akNUy3rdqNN3HdqwXY())
					{
						goto IL_01ae;
					}
					goto IL_03cf;
					IL_0354:
					num = -1;
					_003C_003E1__state = -1;
					goto IL_035d;
					IL_03cf:
					HtmlDocument htmlDocument = default(HtmlDocument);
					string result = default(string);
					HtmlNodeCollection htmlNodeCollection;
					switch (num3)
					{
					case 5:
						break;
					case 4:
						_003CsiteInfo_003E5__3.Title = _003Curi_003E5__2.Host;
						goto IL_01ca;
					case 2:
						goto IL_0354;
					default:
					{
						htmlDocument = new HtmlDocument();
						htmlDocument.LoadHtml(result);
						string text = htmlDocument.DocumentNode.SelectSingleNode("html/head/title")?.InnerText;
						if (string.IsNullOrEmpty(text))
						{
							goto case 4;
						}
						_003CsiteInfo_003E5__3.Title = HttpUtility.HtmlDecode(HttpUtility.UrlDecode(text));
						goto IL_01ca;
					}
					case 3:
						return;
					case 1:
						goto end_IL_0090;
						IL_01ca:
						htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes("//link[contains(@rel, 'icon') and not(contains(@rel, 'mask-icon')) ]");
						if (htmlNodeCollection != null && htmlNodeCollection.Any())
						{
							HtmlNode htmlNode = htmlNodeCollection.First();
							_003CsiteInfo_003E5__3.IconUrl = htmlNode.GetAttributeValue("href", null);
						}
						if (string.IsNullOrEmpty(_003CsiteInfo_003E5__3.IconUrl))
						{
							HtmlNodeCollection htmlNodeCollection2 = htmlDocument.DocumentNode.SelectNodes("//link[contains(@rel, 'apple-touch-icon')]");
							if (htmlNodeCollection2 != null && htmlNodeCollection2.Any())
							{
								HtmlNode htmlNode2 = htmlNodeCollection2.First();
								_003CsiteInfo_003E5__3.IconUrl = htmlNode2.GetAttributeValue("href", null);
							}
						}
						if (string.IsNullOrEmpty(_003CsiteInfo_003E5__3.IconUrl))
						{
							_003CsiteInfo_003E5__3.IconUrl = _003CsiteInfo_003E5__3.RootUrl + "/favicon.ico";
						}
						else if (_003CsiteInfo_003E5__3.IconUrl.StartsWith("//", StringComparison.OrdinalIgnoreCase))
						{
							_003CsiteInfo_003E5__3.IconUrl = new Uri(url).Scheme + ":" + _003CsiteInfo_003E5__3.IconUrl;
						}
						else if (_003CsiteInfo_003E5__3.IconUrl.StartsWith("/", StringComparison.Ordinal))
						{
							_003CsiteInfo_003E5__3.IconUrl = _003CsiteInfo_003E5__3.RootUrl + _003CsiteInfo_003E5__3.IconUrl;
						}
						awaiter2 = _003Cclient_003E5__4.GetStreamAsync(_003CsiteInfo_003E5__3.IconUrl).ConfigureAwait(false).GetAwaiter();
						if (awaiter2.IsCompleted)
						{
							goto IL_013d;
						}
						num = 1;
						_003C_003E1__state = 1;
						_003C_003Eu__2 = awaiter2;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_0134;
					IL_013d:
					Stream result2 = awaiter2.GetResult();
					_003CsiteInfo_003E5__3.IconImage = Image.FromStream(result2);
					if (_003CsiteInfo_003E5__3.IconImage != null && _003CsiteInfo_003E5__3.IconImage.Width > 64)
					{
						_003CsiteInfo_003E5__3.IconImage = IconHelper.ResizeImage(_003CsiteInfo_003E5__3.IconImage, 64, 64);
						num3 = 1;
						if (!X1akNUy3rdqNN3HdqwXY())
						{
							goto IL_01ae;
						}
						goto IL_03cf;
					}
					goto end_IL_0090;
					IL_0134:
					num = -1;
					_003C_003E1__state = -1;
					goto IL_013d;
					IL_035d:
					result = awaiter.GetResult();
					num3 = 0;
					if (!X1akNUy3rdqNN3HdqwXY())
					{
						goto IL_01ae;
					}
					goto IL_03cf;
					IL_01ae:
					num3 = num2;
					goto IL_03cf;
					end_IL_0090:;
				}
				catch (Exception ex)
				{
					_003C_003E7__wrap4 = ex;
					_003C_003E7__wrap5 = 1;
				}
				num4 = _003C_003E7__wrap5;
				int num5 = 1;
				if (QOdqVyy3aaENPoxVvkh1 == null)
				{
					goto IL_043e;
				}
				goto IL_0595;
				IL_0595:
				switch (num5)
				{
				case 1:
					break;
				default:
					goto IL_05a5;
				}
				goto IL_043e;
                IL_0458:
                throw _003Cex_003E5__7;
				IL_055a:
				_003C_003E7__wrap4 = null;
				if (string.IsNullOrEmpty(_003CsiteInfo_003E5__3.Title))
				{
					_003CsiteInfo_003E5__3.Title = _003Curi_003E5__2.Host;
					num5 = 0;
					if (X1akNUy3rdqNN3HdqwXY())
					{
						goto IL_0595;
					}
				}
				goto IL_05a5;
				IL_043e:
				if (num4 == 1)
				{
					_003Cex_003E5__7 = _003C_003E7__wrap4;
					goto IL_0458;
				}
				goto IL_055a;
				IL_05a5:
				result4 = _003CsiteInfo_003E5__3;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Curi_003E5__2 = null;
				_003CsiteInfo_003E5__3 = null;
				_003Cclient_003E5__4 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003Curi_003E5__2 = null;
			_003CsiteInfo_003E5__3 = null;
			_003Cclient_003E5__4 = null;
			_003C_003Et__builder.SetResult(result4);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool X1akNUy3rdqNN3HdqwXY()
		{
			return QOdqVyy3aaENPoxVvkh1 == null;
		}
	}

	internal static object oqFulgFg36ljlngw1DVw;

	[AsyncStateMachine(typeof(_003CRetriveSiteInfoAsync_003Ed__0))]
	public static Task<WebsiteInfo> RetriveSiteInfoAsync(string url)
	{
		_003CRetriveSiteInfoAsync_003Ed__0 stateMachine = default(_003CRetriveSiteInfoAsync_003Ed__0);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<WebsiteInfo>.Create();
		stateMachine.url = url;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private static string PijLA2o03R4(string string_0)
	{
		Uri uri = new Uri(string_0);
		if (uri.HostNameType != UriHostNameType.Dns)
		{
			throw new InvalidDataException("不支持的网址格式。");
		}
		return uri.Scheme + "://" + uri.Host;
	}

	private static bool HRpLAuiaUjx(string string_0)
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(string_0);
			webRequest.Method = "HEAD";
			return ((HttpWebResponse)webRequest.GetResponse()).StatusCode == HttpStatusCode.OK;
		}
		catch (Exception)
		{
			return false;
		}
	}

	internal static bool dxC5L3FgEr0g8IVejTTa()
	{
		return oqFulgFg36ljlngw1DVw == null;
	}
}
