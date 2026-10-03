using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Media.Imaging;
using Cuiliang.AliyunOssSdk.Utility;
using iPl4WNAGGAsnX3Qcaq4;
using log4net;
using Microsoft.WindowsAPICodePack.Shell;
using pEvh96AzTBdjpSVb1d0;
using Quicker.Domain;
using Quicker.Domain.Actions.X.BuiltinRunners.File;
using Quicker.Domain.Actions.X.Variables;
using Quicker.Public.Entities;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Icons;
using ryVWieApdfyCAmpsKH7;
using SimpleHttp;
using ThumbnailGenerator;
using WebSocketSharp.Net;
using WebSocketSharp.Server;

namespace rmBQ8lwABdErnXWOmtu;

internal class OJglG3w5kKTlK1ZuwhJ : HttpServer
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	internal struct _003C_003Ec__DisplayClass37_0
	{
		public HttpRequestEventArgs GjOvIJyglBd;
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass44_0
	{
		public neOcDPAIpvKxjVetnhh kScvICyRAOO;

		private static _003C_003Ec__DisplayClass44_0 upjtQrclRcQsgXt5v4MI;

		internal string lJhvI05D2oS(string x)
		{
			return Path.Combine(kScvICyRAOO.KLa3N1bE9M(), x);
		}

		internal static bool uKSloeclgljwfTAXMaNf()
		{
			return upjtQrclRcQsgXt5v4MI == null;
		}
	}

	private static readonly ILog TXKfn489mV;

	private readonly string mspf4QqqyH;

	private string YuFf5w3SjU = string.Empty;

	private IList<RD5TUqALOWDKBn8SE4W> iXkfDZ1mxQ;

	[CompilerGenerated]
	private readonly int AaffdRYAFr;

	[CompilerGenerated]
	private long jbRfoAyEDA;

	[CompilerGenerated]
	private string CBsfTsGsLv;

	[CompilerGenerated]
	private string AHofMnuQmi;

	[CompilerGenerated]
	private string DeBfAF63N7;

	[CompilerGenerated]
	private bool h1bfOwJn02;

	private static OJglG3w5kKTlK1ZuwhJ FkrJGTQQ81vWwC7joCiC;

	public string ActionId
	{
		[CompilerGenerated]
		get
		{
			return DeBfAF63N7;
		}
		[CompilerGenerated]
		set
		{
			DeBfAF63N7 = value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public int wYDfYIxloU()
	{
		return AaffdRYAFr;
	}

	[SpecialName]
	[CompilerGenerated]
	public long wnKfW7xqtf()
	{
		return jbRfoAyEDA;
	}

	[SpecialName]
	[CompilerGenerated]
	private void qUefk3yOmc(long long_1)
	{
		jbRfoAyEDA = long_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public string ItVfsAyj5Y()
	{
		return CBsfTsGsLv;
	}

	[SpecialName]
	[CompilerGenerated]
	public void s6SfHhaHfO(string string_5)
	{
		CBsfTsGsLv = string_5;
	}

	[SpecialName]
	[CompilerGenerated]
	public string O3ofbt0MD0()
	{
		return AHofMnuQmi;
	}

	[SpecialName]
	[CompilerGenerated]
	public void wjNf6FHWUA(string string_5)
	{
		AHofMnuQmi = string_5;
	}

	[SpecialName]
	public string yA7fxiOEdu()
	{
		return YuFf5w3SjU;
	}

	[SpecialName]
	public void W0Ifr0jiqc(string string_5)
	{
		YuFf5w3SjU = string_5;
		if (!string.IsNullOrWhiteSpace(YuFf5w3SjU))
		{
			aHqfw9qwqb();
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public bool bsBfB7O8Gf()
	{
		return h1bfOwJn02;
	}

	[SpecialName]
	[CompilerGenerated]
	public void JK6fQqVDrD(bool bool_1)
	{
		h1bfOwJn02 = bool_1;
	}

	private void aHqfw9qwqb()
	{
		string[] array = YuFf5w3SjU.SplitToList();
		iXkfDZ1mxQ = new List<RD5TUqALOWDKBn8SE4W>();
		string[] array2 = array;
		foreach (string string_ in array2)
		{
			iXkfDZ1mxQ.Add(RD5TUqALOWDKBn8SE4W.p7j3kLC8Tu(string_));
		}
	}

	public OJglG3w5kKTlK1ZuwhJ(string string_5, int int_1, bool bool_1, int int_2, string string_6)
		: base(int_1, bool_1)
	{
		mspf4QqqyH = string_6;
		AaffdRYAFr = int_2;
		base.DocumentRootPath = string_5;
		base.OnGet += M6lfCXGoms;
		base.OnPost += QnPfSwvevr;
		base.OnHead += RUWfgHla44;
		base.OnPut += RUWfgHla44;
		base.OnDelete += RUWfgHla44;
		base.OnOptions += fk0ft2qSrJ;
		qkffLSfY4x();
	}

	private void fk0ft2qSrJ(object sender, HttpRequestEventArgs e)
	{
		SUCf0nuAHQ(e);
		e.Response.StatusCode = 200;
	}

	private void RUWfgHla44(object sender, HttpRequestEventArgs e)
	{
		SUCf0nuAHQ(e);
		if (iXkfDZ1mxQ == null || !Hcpf2EFb63(e))
		{
			e.Response.StatusCode = 404;
		}
	}

	private void qkffLSfY4x()
	{
		qUefk3yOmc(AppHelper.fLiLTj0x4QY());
	}

	public bool h3WfvG1TLx()
	{
		if (wYDfYIxloU() > 0)
		{
			return wYDfYIxloU() < (AppHelper.fLiLTj0x4QY() - wnKfW7xqtf()) / 1000L;
		}
		return false;
	}

	private void QnPfSwvevr(object sender, HttpRequestEventArgs e)
	{
		qkffLSfY4x();
		SUCf0nuAHQ(e);
		HttpListenerRequest request = e.Request;
		HttpListenerResponse response = e.Response;
		try
		{
			if (iXkfDZ1mxQ != null && Hcpf2EFb63(e))
			{
				return;
			}
			string absolutePath = request.Url.AbsolutePath;
			string path = Path.Combine(base.DocumentRootPath, absolutePath.Trim('/').UrlDecode());
			Dictionary<string, string> args = new Dictionary<string, string>();
			IList<HttpFile> list = request.ParseBody(args);
			int num = 0;
			if (FkrJGTQQ81vWwC7joCiC != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (list != null)
			{
				foreach (HttpFile item in list)
				{
					item.Save(Path.Combine(path, item.FileName), true);
				}
			}
			response.Redirect(e.Request.Url.ToString());
		}
		catch (Exception exception_)
		{
			rKJfRFQOqx(response, exception_);
		}
	}

	private bool Hcpf2EFb63(HttpRequestEventArgs httpRequestEventArgs_0)
	{
		_003C_003Ec__DisplayClass37_0 _003C_003Ec__DisplayClass37_0_ = default(_003C_003Ec__DisplayClass37_0);
		_003C_003Ec__DisplayClass37_0_.GjOvIJyglBd = httpRequestEventArgs_0;
		if (!iXkfDZ1mxQ.HasData())
		{
			return false;
		}
		IDictionary<string, object> dictionary = null;
		IDictionary<string, object> value = default(IDictionary<string, object>);
		Dictionary<string, string> dictionary2 = default(Dictionary<string, string>);
		int num2 = default(int);
		IList<HttpFile> list = default(IList<HttpFile>);
		int num4 = default(int);
		IList<string> list2 = default(IList<string>);
		string text4 = default(string);
		object obj = default(object);
		int num6 = default(int);
		foreach (RD5TUqALOWDKBn8SE4W item in iXkfDZ1mxQ)
		{
			if (!w80fe9Ug4l(item, ref _003C_003Ec__DisplayClass37_0_) || !blLfhAO11R(item, ref _003C_003Ec__DisplayClass37_0_))
			{
				continue;
			}
			int num;
			if (dictionary == null)
			{
				dictionary = new Dictionary<string, object>();
				dictionary["Path"] = _003C_003Ec__DisplayClass37_0_.GjOvIJyglBd.Request.Url.AbsolutePath;
				dictionary["QueryString"] = _003C_003Ec__DisplayClass37_0_.GjOvIJyglBd.Request.Url.Query;
				dictionary["QueryDict"] = _003C_003Ec__DisplayClass37_0_.GjOvIJyglBd.Request.QueryString.NameValueCollectionToDict();
				dictionary["Method"] = _003C_003Ec__DisplayClass37_0_.GjOvIJyglBd.Request.HttpMethod;
				if (_003C_003Ec__DisplayClass37_0_.GjOvIJyglBd.Request.HasEntityBody && !string.IsNullOrWhiteSpace(_003C_003Ec__DisplayClass37_0_.GjOvIJyglBd.Request.ContentType))
				{
					if (_003C_003Ec__DisplayClass37_0_.GjOvIJyglBd.Request.ContentType.StartsWith("application/x-www-form-urlencoded"))
					{
						string text = _003C_003Ec__DisplayClass37_0_.GjOvIJyglBd.Request.BodyAsString();
						value = text.QueryStringToDict();
						dictionary["Body"] = text;
						num = 0;
						if (FkrJGTQQ81vWwC7joCiC == null)
						{
							goto IL_01b0;
						}
						goto IL_01cf;
					}
					if (_003C_003Ec__DisplayClass37_0_.GjOvIJyglBd.Request.ContentType.StartsWith("multipart/form-data"))
					{
						dictionary2 = new Dictionary<string, string>();
						num2 = 3;
						goto IL_01e6;
					}
					string value2 = _003C_003Ec__DisplayClass37_0_.GjOvIJyglBd.Request.BodyAsString();
					dictionary["Body"] = value2;
				}
			}
			goto IL_0355;
			IL_01cb:
			num = num2;
			goto IL_01cf;
			IL_0252:
			string text2;
			string path = (string)text2;
			if (list != null)
			{
				foreach (HttpFile item2 in list)
				{
					string text3 = Path.Combine(path, item2.FileName);
					int num3 = 0;
					if (!a0YOSHQQR6KYGh9HV1cy())
					{
						num3 = num4;
					}
					switch (num3)
					{
					}
					item2.Save(text3, true);
					list2.Add(text3);
					if (!dictionary2.ContainsKey(item2.FieldName))
					{
						dictionary2[item2.FieldName] = text3;
					}
					else
					{
						dictionary2[item2.FieldName] = dictionary2[item2.FieldName] + ";" + text3;
					}
				}
			}
			dictionary["Form"] = dictionary2;
			dictionary["Files"] = list2;
			goto IL_0355;
			IL_01e6:
			list = _003C_003Ec__DisplayClass37_0_.GjOvIJyglBd.Request.ParseBody(dictionary2);
			list2 = new List<string>();
			text4 = Path.Combine(base.DocumentRootPath, _003C_003Ec__DisplayClass37_0_.GjOvIJyglBd.Request.Url.AbsolutePath.Trim('/').UrlDecode());
			if (Directory.Exists(text4))
			{
				num = 0;
				if (FkrJGTQQ81vWwC7joCiC != null)
				{
					goto IL_01cb;
				}
				goto IL_01cf;
			}
			text2 = base.DocumentRootPath;
			goto IL_0252;
			IL_0355:
			try
			{
				IDictionary<string, object> dictionary3 = AppState.AppServer.ExecuteActionSubProgram(ActionId, item.l3236LwAe5(), dictionary, new ActionExtraContextData
				{
					HttpRequestEventArgs = _003C_003Ec__DisplayClass37_0_.GjOvIJyglBd
				});
				if (dictionary3.ContainsKey("Processed") && Convert.ToBoolean(dictionary3["Processed"]))
				{
					return true;
				}
				if (dictionary3.ContainsKey("StatusCode"))
				{
					_003C_003Ec__DisplayClass37_0_.GjOvIJyglBd.Response.StatusCode = Convert.ToInt32(dictionary3["StatusCode"]);
				}
				else
				{
					_003C_003Ec__DisplayClass37_0_.GjOvIJyglBd.Response.StatusCode = 200;
				}
				string text5 = "text/html";
				if (dictionary3.ContainsKey("ContentType"))
				{
					text5 = dictionary3["ContentType"].ToString();
				}
				string text6 = "";
				if (dictionary3.ContainsKey("RespBody"))
				{
					text6 = dictionary3["RespBody"].ToString();
					_003C_003Ec__DisplayClass37_0_.GjOvIJyglBd.Response.ContentEncoding = Encoding.UTF8;
					_003C_003Ec__DisplayClass37_0_.GjOvIJyglBd.Response.AsText(text6, text5);
					goto IL_049c;
				}
				_003C_003Ec__DisplayClass37_0_.GjOvIJyglBd.Response.ContentType = text5;
				int num5 = 1;
				if (FkrJGTQQ81vWwC7joCiC != null)
				{
					goto IL_04c8;
				}
				goto IL_04cc;
				IL_049c:
				if (dictionary3.ContainsKey("Headers"))
				{
					obj = dictionary3["Headers"];
					num5 = 0;
					if (!a0YOSHQQR6KYGh9HV1cy())
					{
						goto IL_04c8;
					}
					goto IL_04cc;
				}
				goto end_IL_0355;
				IL_04cc:
				switch (num5)
				{
				case 1:
					break;
				default:
					if (obj != null)
					{
						foreach (KeyValuePair<string, object> item3 in VariableHelper.ConvertToDict(obj))
						{
							_003C_003Ec__DisplayClass37_0_.GjOvIJyglBd.Response.WithHeader(item3.Key, item3.Value.ToString());
						}
					}
					goto end_IL_0355;
				}
				goto IL_049c;
				IL_04c8:
				num5 = num6;
				goto IL_04cc;
				end_IL_0355:;
			}
			catch (Exception ex)
			{
				_003C_003Ec__DisplayClass37_0_.GjOvIJyglBd.Response.AsText("处理请求出错：" + ex.Message + "。" + ex.StackTrace, "text/plain");
				_003C_003Ec__DisplayClass37_0_.GjOvIJyglBd.Response.StatusCode = 500;
			}
			return true;
			IL_01cf:
			switch (num)
			{
			case 2:
				break;
			case 3:
				goto IL_01e6;
			default:
				goto IL_0248;
			case 1:
				goto IL_0355;
			}
			goto IL_01b0;
			IL_0248:
			text2 = text4;
			goto IL_0252;
			IL_01b0:
			dictionary["Form"] = value;
			num = 1;
			if (!a0YOSHQQR6KYGh9HV1cy())
			{
				goto IL_01cb;
			}
			goto IL_01cf;
		}
		return false;
	}

	private static string NADfuyx4ls(string string_5)
	{
		return "--" + string_5.Split(';')[1].Split('=')[1];
	}

	private static void d9VfNNhDid(Encoding encoding_0, string string_5, Stream stream_0)
	{
		byte[] bytes = encoding_0.GetBytes(string_5);
		int num = bytes.Length;
		using FileStream fileStream = new FileStream("data", FileMode.Create, FileAccess.Write);
		byte[] array = new byte[1024];
		int num2 = stream_0.Read(array, 0, 1024);
		int num3 = 0;
		if (FkrJGTQQ81vWwC7joCiC != null)
		{
			int num4 = default(int);
			num3 = num4;
		}
		while (true)
		{
			int num6;
			switch (num3)
			{
			case 1:
				num2 = stream_0.Read(array, num, 1024 - num) + num;
				goto IL_0052;
			default:
			{
				int num5 = -1;
				while (true)
				{
					if (num2 != 0)
					{
						num5 = AlufJSPRb0(array, num2, bytes);
						if (num5 >= 0)
						{
							break;
						}
						Array.Copy(array, num2 - num, array, 0, num);
						num2 = stream_0.Read(array, num, 1024 - num);
						continue;
					}
					throw new Exception("Start Boundaray Not Found");
				}
				for (int i = 0; i < 4; i++)
				{
					while (true)
					{
						if (num2 != 0)
						{
							num5 = Array.IndexOf(array, encoding_0.GetBytes("\n")[0], num5);
							if (num5 >= 0)
							{
								break;
							}
							num2 = stream_0.Read(array, 0, 1024);
							continue;
						}
						throw new Exception("Preamble not Found.");
					}
					num5++;
				}
				Array.Copy(array, num5, array, 0, num2 - num5);
				num2 -= num5;
				goto IL_0052;
			}
			case 2:
				{
					throw new Exception("End Boundaray Not Found");
				}
				IL_0052:
				num6 = AlufJSPRb0(array, num2, bytes);
				if (num6 < 0)
				{
					if (num2 > num)
					{
						fileStream.Write(array, 0, num2 - num);
						Array.Copy(array, num2 - num, array, 0, num);
						num3 = 1;
						if (FkrJGTQQ81vWwC7joCiC == null)
						{
							break;
						}
						goto case 1;
					}
					goto case 2;
				}
				if (num6 > 0)
				{
					fileStream.Write(array, 0, num6 - 2);
				}
				return;
			}
		}
	}

	private static int AlufJSPRb0(byte[] byte_0, int int_1, byte[] byte_1)
	{
		int num = 0;
		int num4 = default(int);
		while (true)
		{
			if (num <= int_1 - byte_1.Length)
			{
				bool flag = true;
				int num2 = 0;
				while (num2 < byte_1.Length && flag)
				{
					flag = byte_0[num + num2] == byte_1[num2];
					num2++;
					int num3 = 0;
					if (FkrJGTQQ81vWwC7joCiC != null)
					{
						num3 = num4;
					}
					switch (num3)
					{
					}
				}
				if (flag)
				{
					break;
				}
				num++;
				continue;
			}
			return -1;
		}
		return num;
	}

	private void SUCf0nuAHQ(HttpRequestEventArgs httpRequestEventArgs_0)
	{
		try
		{
			httpRequestEventArgs_0.Response.WithHeader("Access-Control-Allow-Origin", "*");
			httpRequestEventArgs_0.Response.WithHeader("Access-Control-Allow-Methods", "*");
			httpRequestEventArgs_0.Response.WithHeader("Access-Control-Allow-Headers", "*");
		}
		catch (Exception)
		{
		}
	}

	private void M6lfCXGoms(object sender, HttpRequestEventArgs e)
	{
		qkffLSfY4x();
		SUCf0nuAHQ(e);
		if (iXkfDZ1mxQ != null && Hcpf2EFb63(e))
		{
			return;
		}
		HttpListenerRequest request = e.Request;
		HttpListenerResponse response = e.Response;
		neOcDPAIpvKxjVetnhh neOcDPAIpvKxjVetnhh = new neOcDPAIpvKxjVetnhh(base.DocumentRootPath, request);
		neOcDPAIpvKxjVetnhh.Gsb37kIUoP(ItVfsAyj5Y());
		neOcDPAIpvKxjVetnhh.KYa3cM3nqT(O3ofbt0MD0());
		int num = 0;
		if (FkrJGTQQ81vWwC7joCiC != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		try
		{
			if (neOcDPAIpvKxjVetnhh.KY03yNrZpu())
			{
				OVxf8S9725(e);
				return;
			}
			bool bool_ = false;
			if (e.Request.QueryString.HasKeys())
			{
				if (e.Request.QueryString["thumb"] == "true")
				{
					ncBfZKkAZ4(neOcDPAIpvKxjVetnhh.KLa3N1bE9M(), response);
					return;
				}
				string text = e.Request.QueryString["downitem"];
				if (!string.IsNullOrWhiteSpace(text))
				{
					zO4fEEhDTl(e, neOcDPAIpvKxjVetnhh, text.SplitToList(';', ','));
					return;
				}
				bool_ = request.QueryString["download"] == "true";
			}
			if (neOcDPAIpvKxjVetnhh.Nwf3PAJF3m())
			{
				if (!string.IsNullOrWhiteSpace(mspf4QqqyH))
				{
					string text2 = Path.Combine(neOcDPAIpvKxjVetnhh.KLa3N1bE9M(), mspf4QqqyH);
					if (File.Exists(text2))
					{
						GbjfcGCl2O(e, text2, response, bool_);
						return;
					}
				}
				else
				{
					zDsfq9F8Tf(e, neOcDPAIpvKxjVetnhh);
					if (!a0YOSHQQR6KYGh9HV1cy())
					{
						return;
					}
					switch (0)
					{
					default:
						return;
					case 1:
						break;
					case 2:
						return;
					case 0:
						return;
					}
				}
				zDsfq9F8Tf(e, neOcDPAIpvKxjVetnhh);
			}
			else if (!File.Exists(neOcDPAIpvKxjVetnhh.KLa3N1bE9M()))
			{
				if (e.Request.Url.AbsolutePath == "/favicon.ico")
				{
					JT3fPvFNV7(e, neOcDPAIpvKxjVetnhh);
				}
				response.AsText("路径<code>" + neOcDPAIpvKxjVetnhh.KLa3N1bE9M() + "</code>不存在。<br> <a href='/'>返回根路径</a>");
			}
			else
			{
				GbjfcGCl2O(e, neOcDPAIpvKxjVetnhh.KLa3N1bE9M(), response, bool_);
			}
		}
		catch (Exception ex)
		{
			TXKfn489mV.Warn("HTTP请求处理出错。" + request.Url.ToString() + " 错误：" + ex.Message + " ", ex);
			rKJfRFQOqx(response, ex);
		}
	}

	private void JT3fPvFNV7(HttpRequestEventArgs httpRequestEventArgs_0, neOcDPAIpvKxjVetnhh neOcDPAIpvKxjVetnhh_0)
	{
		using Stream stream = Application.GetResourceStream(new Uri("pack://application:,,,/" + Assembly.GetEntryAssembly().GetName().Name + ";component/quicker.ico")).Stream;
		httpRequestEventArgs_0.Response.WithHeader("Cache-Control", "public, max-age=31536000");
		httpRequestEventArgs_0.Response.AsStream(httpRequestEventArgs_0.Request, stream, "image/x-icon");
	}

	private void zO4fEEhDTl(HttpRequestEventArgs httpRequestEventArgs_0, neOcDPAIpvKxjVetnhh neOcDPAIpvKxjVetnhh_0, string[] string_5)
	{
		_003C_003Ec__DisplayClass44_0 _003C_003Ec__DisplayClass44_ = new _003C_003Ec__DisplayClass44_0();
		_003C_003Ec__DisplayClass44_.kScvICyRAOO = neOcDPAIpvKxjVetnhh_0;
		try
		{
			if (string_5.Length == 1)
			{
				string text = Path.Combine(_003C_003Ec__DisplayClass44_.kScvICyRAOO.KLa3N1bE9M(), string_5[0]);
				if (File.Exists(text))
				{
					string text2 = Path.Combine(Path.GetTempPath(), string_5[0] + ".zip");
					ZipStep.ZipSingleFile(text, text2, null, 0, "", false);
					GbjfcGCl2O(httpRequestEventArgs_0, text2, httpRequestEventArgs_0.Response, true, true);
				}
				else if (Directory.Exists(text))
				{
					string text3 = Path.Combine(Path.GetTempPath(), string_5[0] + ".zip");
					ZipStep.ZipSingleDirectory(text, text3, null, 0, "", false);
					GbjfcGCl2O(httpRequestEventArgs_0, text3, httpRequestEventArgs_0.Response, true, true);
				}
			}
			else
			{
				string text4 = Path.Combine(Path.GetTempPath(), $"{KR7fyC7vc0(string_5).Or(Path.GetFileName(_003C_003Ec__DisplayClass44_.kScvICyRAOO.KLa3N1bE9M()))}_{DateTime.Now: yyyyMMdd_HHmmss}.zip");
				ZipStep.ZipMultipleFiles(string_5.Select(_003C_003Ec__DisplayClass44_.lJhvI05D2oS).ToList(), text4, _003C_003Ec__DisplayClass44_.kScvICyRAOO.KLa3N1bE9M(), string.Empty, 0, "", false);
				GbjfcGCl2O(httpRequestEventArgs_0, text4, httpRequestEventArgs_0.Response, true, true);
			}
		}
		catch (Exception exception_)
		{
			rKJfRFQOqx(httpRequestEventArgs_0.Response, exception_);
		}
	}

	private static string KR7fyC7vc0(IList<string> ilist_1)
	{
		if (!ilist_1.HasData())
		{
			return string.Empty;
		}
		if (ilist_1.Count == 1)
		{
			return Path.GetFileNameWithoutExtension(ilist_1[0]);
		}
		int num = 0;
		bool flag = true;
		for (num = 0; num < ilist_1[0].Length; num++)
		{
			char c = ilist_1[0][num];
			for (int i = 1; i < ilist_1.Count; i++)
			{
				if (ilist_1[i].Length != num)
				{
					if (ilist_1[i][num] != c)
					{
						flag = false;
						break;
					}
					continue;
				}
				flag = false;
				break;
			}
			if (!flag)
			{
				break;
			}
		}
		return ilist_1[0].Substring(0, num);
	}

	private static void OVxf8S9725(HttpRequestEventArgs httpRequestEventArgs_0)
	{
		string text = httpRequestEventArgs_0.Request.QueryString["ext"].Replace("/", "\\");
		if (string.IsNullOrWhiteSpace(text))
		{
			httpRequestEventArgs_0.Response.StatusCode = 204;
			return;
		}
		using Icon icon = FileSystemIconHelper.GetIconFromPath(text);
		if (icon != null)
		{
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using Bitmap bitmap = icon.ToBitmap();
				bitmap.Save(memoryStream, ImageFormat.Png);
				HttpListenerResponse response = httpRequestEventArgs_0.Response;
				response.ContentLength64 = memoryStream.Length;
				response.StatusCode = 200;
				response.ContentType = MimeHelper.GetMime(".png");
				response.WithHeader("Cache-Control", "public, max-age=31536000");
				if (a0YOSHQQR6KYGh9HV1cy())
				{
					switch (0)
					{
					}
				}
				memoryStream.Position = 0L;
				memoryStream.CopyTo(response.OutputStream);
				response.OutputStream.Flush();
				response.Close();
				return;
			}
		}
		httpRequestEventArgs_0.Response.StatusCode = 204;
	}

	public static void mAQfaj85un(Icon icon_0, Stream stream_0)
	{
		using MemoryStream memoryStream = new MemoryStream();
		icon_0.Save(memoryStream);
		IconBitmapDecoder iconBitmapDecoder = new IconBitmapDecoder(memoryStream, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.None);
		PngBitmapEncoder pngBitmapEncoder = new PngBitmapEncoder();
		pngBitmapEncoder.Frames.Add(iconBitmapDecoder.Frames[0]);
		pngBitmapEncoder.Save(stream_0);
	}

	public static Bitmap vyjf7BK7MT(Icon icon_0)
	{
		Bitmap bitmap = null;
		using MemoryStream memoryStream = new MemoryStream();
		icon_0.Save(memoryStream);
		IconBitmapDecoder iconBitmapDecoder = new IconBitmapDecoder(memoryStream, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.None);
		using MemoryStream stream = new MemoryStream();
		PngBitmapEncoder pngBitmapEncoder = new PngBitmapEncoder();
		pngBitmapEncoder.Frames.Add(iconBitmapDecoder.Frames[0]);
		pngBitmapEncoder.Save(stream);
		return (Bitmap)Image.FromStream(stream);
	}

	private static void rKJfRFQOqx(HttpListenerResponse httpListenerResponse_0, Exception exception_0)
	{
		httpListenerResponse_0.StatusCode = 500;
		byte[] bytes = Encoding.UTF8.GetBytes(exception_0.Message + "\r\n" + exception_0.StackTrace);
		httpListenerResponse_0.ContentLength64 = bytes.Length;
		httpListenerResponse_0.ContentEncoding = Encoding.UTF8;
		httpListenerResponse_0.ContentType = MimeHelper.GetMime("test.txt");
		httpListenerResponse_0.Close(bytes, true);
	}

	private void zDsfq9F8Tf(HttpRequestEventArgs httpRequestEventArgs_0, neOcDPAIpvKxjVetnhh neOcDPAIpvKxjVetnhh_0)
	{
		HttpListenerResponse response = httpRequestEventArgs_0.Response;
		string s = new Ul3JYWAa0WqW9EBQbgu(neOcDPAIpvKxjVetnhh_0, true, true, true).uwy3pZ7aDB();
		byte[] bytes = Encoding.UTF8.GetBytes(s);
		response.StatusCode = 200;
		response.ContentLength64 = bytes.Length;
		response.ContentEncoding = Encoding.UTF8;
		response.ContentType = "text/html";
		response.Close(bytes, true);
	}

	private static void GbjfcGCl2O(HttpRequestEventArgs httpRequestEventArgs_0, string string_5, HttpListenerResponse httpListenerResponse_0, bool bool_1, bool bool_2 = false)
	{
		if (!File.Exists(string_5))
		{
			httpListenerResponse_0.StatusCode = 404;
			return;
		}
		httpListenerResponse_0.gPVRXMIYBX(httpRequestEventArgs_0.Request, string_5, bool_1);
		try
		{
			if (bool_2)
			{
				File.Delete(string_5);
			}
		}
		catch (Exception)
		{
		}
	}

	public static bool HTffVBo04D()
	{
		return false;
	}

	private static void ncBfZKkAZ4(string string_5, HttpListenerResponse httpListenerResponse_0)
	{
		if (File.Exists(string_5))
		{
			using (Bitmap bitmap = WindowsThumbnailProvider.GetThumbnail(string_5, 32, 32, ThumbnailOptions.BiggerSizeOk))
			{
				if (bitmap != null)
				{
					Msaf9CWWLQ(httpListenerResponse_0, bitmap);
				}
				return;
			}
		}
		if (!Directory.Exists(string_5))
		{
			return;
		}
		using Bitmap bitmap2 = ShellObject.FromParsingName(string_5).Thumbnail.Bitmap;
		if (bitmap2 != null)
		{
			Msaf9CWWLQ(httpListenerResponse_0, bitmap2);
		}
	}

	private static void Msaf9CWWLQ(HttpListenerResponse httpListenerResponse_0, Image image_0)
	{
		using MemoryStream memoryStream = new MemoryStream();
		image_0.Save(memoryStream, ImageFormat.Png);
		httpListenerResponse_0.ContentLength64 = memoryStream.Length;
		httpListenerResponse_0.StatusCode = 200;
		memoryStream.Position = 0L;
		memoryStream.CopyTo(httpListenerResponse_0.OutputStream);
		httpListenerResponse_0.OutputStream.Flush();
		httpListenerResponse_0.Close();
	}

	static OJglG3w5kKTlK1ZuwhJ()
	{
		TXKfn489mV = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	[CompilerGenerated]
	internal static bool blLfhAO11R(RD5TUqALOWDKBn8SE4W rd5TUqALOWDKBn8SE4W_0, ref _003C_003Ec__DisplayClass37_0 _003C_003Ec__DisplayClass37_0_0)
	{
		if (!string.Equals(rd5TUqALOWDKBn8SE4W_0.Path, _003C_003Ec__DisplayClass37_0_0.GjOvIJyglBd.Request.Url.AbsolutePath, StringComparison.OrdinalIgnoreCase))
		{
			return Regex.IsMatch(_003C_003Ec__DisplayClass37_0_0.GjOvIJyglBd.Request.Url.AbsolutePath, rd5TUqALOWDKBn8SE4W_0.Path, RegexOptions.None);
		}
		return true;
	}

	[CompilerGenerated]
	internal static bool w80fe9Ug4l(RD5TUqALOWDKBn8SE4W rd5TUqALOWDKBn8SE4W_0, ref _003C_003Ec__DisplayClass37_0 _003C_003Ec__DisplayClass37_0_0)
	{
		foreach (string item in rd5TUqALOWDKBn8SE4W_0.qSG3H1RveP())
		{
			if (!(item == "*"))
			{
				if (string.Equals(item, _003C_003Ec__DisplayClass37_0_0.GjOvIJyglBd.Request.HttpMethod, StringComparison.OrdinalIgnoreCase))
				{
					return true;
				}
				continue;
			}
			return true;
		}
		return false;
	}

	internal static bool a0YOSHQQR6KYGh9HV1cy()
	{
		return FkrJGTQQ81vWwC7joCiC == null;
	}
}
