using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Cache;
using System.Net.Http;
using System.Net.Http.Handlers;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using IgQBbvXMVdsN7GVNUxX;
using log4net;
using MimeTypes;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Actions.X.Variables;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.View.Progress;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class HttpStep : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec ihNStCQKXcM;

		public static RemoteCertificateValidationCallback bc9StPpZlyE;

		public static Func<string, string[]> LQSStEbOxRw;

		public static Func<byte, char> kLvStyeN4CF;

		public static Func<byte, char> NDrSt8sQwiQ;

		public static Func<Cookie, string> LsDStaNq1Mg;

		private static _003C_003Ec CXGyuqWEYZZ1P8k1W90d;

		static _003C_003Ec()
		{
			ihNStCQKXcM = new _003C_003Ec();
		}

		internal bool PECSt2jwEwu(object httpRequestMessage, X509Certificate cert, X509Chain cetChain, SslPolicyErrors policyErrors)
		{
			return true;
		}

		internal string[] rIoStuvAhaK(string c)
		{
			return c.Split(new char[1] { '=' }, 2);
		}

		internal char jwTStNm5NKh(byte b)
		{
			return (char)b;
		}

		internal char EVYStJUOfZg(byte b)
		{
			return (char)b;
		}

		internal string yTCSt0V7f8r(Cookie x)
		{
			return x.Name + ": " + x.Value;
		}

		internal static bool nNQMFUWE8QB4u9ZAOUFj()
		{
			return CXGyuqWEYZZ1P8k1W90d == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass67_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct gRr3cnkUtwWQILnT0Pf : IAsyncStateMachine
		{
			public int Yn62c8kwPPt;

			public AsyncTaskMethodBuilder<(bool isSuccess, string message, ActionStopFlag failReason)> pv82ca6NAyW;

			public _003C_003Ec__DisplayClass67_0 rD52c7a7qWq;

			private _003C_003Ec__DisplayClass67_1 juG2cRAltrZ;

			private bool QRg2cq0lOrG;

			private string fC42ccH0HYZ;

			private CookieContainer wW02cVUxZFq;

			private HttpClient KwW2cZOeJH3;

			private HttpResponseMessage Il62c9WMlQf;

			private TaskAwaiter<HttpResponseMessage> Paw2chhVUGl;

			private Stream b042ceFCq6Y;

			private StreamReader BJr2cYjYTXU;

			private TaskAwaiter<Stream> yun2cIOQvgo;

			private TaskAwaiter<string> cb02cW6HKAs;

			private TaskAwaiter<IDictionary<string, object>> D7g2ckr8OML;

			private string YjG2cGhBIYS;

			private string XGs2cs0ElO3;

			private string HvH2cHoOOYj;

			private TaskAwaiter<byte[]> UaS2c1jrnI8;

			internal static object AOk1h2yfgIbit2KPykKI;

			private void MoveNext()
			{
				int num = Yn62c8kwPPt;
				_003C_003Ec__DisplayClass67_0 _003C_003Ec__DisplayClass67_ = rD52c7a7qWq;
				(bool, string, ActionStopFlag) result;
				try
				{
					bool booleanParamValue = default(bool);
					string textParamValue5 = default(string);
					double expireSeconds = default(double);
					bool booleanParamValue2 = default(bool);
					bool booleanParamValue3 = default(bool);
					bool booleanParamValue4 = default(bool);
					HttpRequestMessage httpRequestMessage = default(HttpRequestMessage);
					Uri uri = default(Uri);
					if ((uint)num > 7u)
					{
						juG2cRAltrZ = new _003C_003Ec__DisplayClass67_1();
						juG2cRAltrZ.jIESterNSK1 = _003C_003Ec__DisplayClass67_;
						juG2cRAltrZ.url = XActionHelper.GetTextParamValue(zoatlk5GMPv, _003C_003Ec__DisplayClass67_.g0JStRcGYTa, _003C_003Ec__DisplayClass67_.lmMStqpiK7a);
						string textParamValue = XActionHelper.GetTextParamValue(ntftlGPjA19, _003C_003Ec__DisplayClass67_.g0JStRcGYTa, _003C_003Ec__DisplayClass67_.lmMStqpiK7a);
						string textParamValue2 = XActionHelper.GetTextParamValue(sOmtlHpE9j0, _003C_003Ec__DisplayClass67_.g0JStRcGYTa, _003C_003Ec__DisplayClass67_.lmMStqpiK7a);
						string textParamValue3 = XActionHelper.GetTextParamValue(JAltlbqBDtv, _003C_003Ec__DisplayClass67_.g0JStRcGYTa, _003C_003Ec__DisplayClass67_.lmMStqpiK7a);
						string textParamValue4 = XActionHelper.GetTextParamValue(w0Atl6l2Gq5, _003C_003Ec__DisplayClass67_.g0JStRcGYTa, _003C_003Ec__DisplayClass67_.lmMStqpiK7a);
						booleanParamValue = XActionHelper.GetBooleanParamValue(hirtlmas0Jg, _003C_003Ec__DisplayClass67_.g0JStRcGYTa, _003C_003Ec__DisplayClass67_.lmMStqpiK7a);
						textParamValue5 = XActionHelper.GetTextParamValue(hUgtlBCSyns, _003C_003Ec__DisplayClass67_.g0JStRcGYTa, _003C_003Ec__DisplayClass67_.lmMStqpiK7a);
						expireSeconds = Convert.ToDouble(XActionHelper.GetNumberParamValue(KuBtlQDbTAJ, _003C_003Ec__DisplayClass67_.g0JStRcGYTa, _003C_003Ec__DisplayClass67_.lmMStqpiK7a));
						booleanParamValue2 = XActionHelper.GetBooleanParamValue(QLetlrY4MrL, _003C_003Ec__DisplayClass67_.g0JStRcGYTa, _003C_003Ec__DisplayClass67_.lmMStqpiK7a);
						booleanParamValue3 = XActionHelper.GetBooleanParamValue(XY4tlxoR900, _003C_003Ec__DisplayClass67_.g0JStRcGYTa, _003C_003Ec__DisplayClass67_.lmMStqpiK7a);
						string textParamValue6 = default(string);
						MemoryStream memoryStream = default(MemoryStream);
						string[] array = default(string[]);
						int i = default(int);
						IEnumerator<string[]> enumerator = default(IEnumerator<string[]>);
						int num4 = default(int);
						string textParamValue7 = default(string);
						string text7 = default(string);
						StreamContent streamContent = default(StreamContent);
						MultipartFormDataContent multipartFormDataContent = default(MultipartFormDataContent);
						string text8 = default(string);
						string text9 = default(string);
						string textParamValue8 = default(string);
						string text10 = default(string);
						string text13 = default(string);
						int num7 = default(int);
						string text15 = default(string);
						StreamContent streamContent2 = default(StreamContent);
						while (true)
						{
							IL_0129:
							booleanParamValue4 = XActionHelper.GetBooleanParamValue(BnNtlKuwmGD, _003C_003Ec__DisplayClass67_.g0JStRcGYTa, _003C_003Ec__DisplayClass67_.lmMStqpiK7a);
							QRg2cq0lOrG = XActionHelper.GetBooleanParamValue(aEktljUnTJ6, _003C_003Ec__DisplayClass67_.g0JStRcGYTa, _003C_003Ec__DisplayClass67_.lmMStqpiK7a);
							fC42ccH0HYZ = ((!QRg2cq0lOrG) ? "" : XActionHelper.GetTextParamValue(uDhtlnej2Zi, _003C_003Ec__DisplayClass67_.g0JStRcGYTa, _003C_003Ec__DisplayClass67_.lmMStqpiK7a));
							if (!QRg2cq0lOrG)
							{
								goto IL_018f;
							}
							goto IL_0857;
							IL_0c9e:
							if (string.IsNullOrEmpty(textParamValue6))
							{
								break;
							}
							httpRequestMessage.Content.Headers.Remove("Content-Type");
							goto IL_0cbe;
							IL_0cbe:
							httpRequestMessage.Content.Headers.TryAddWithoutValidation("Content-Type", textParamValue6);
							break;
							IL_0cd9:
							result = (false, "消息体格式不正确，请参考模块文档。", ActionStopFlag.OperationFailed);
							goto end_IL_000e;
							IL_0857:
							if (string.IsNullOrWhiteSpace(fC42ccH0HYZ))
							{
								throw new InvalidOperationException("请指定SSE流式响应处理子程序。");
							}
							goto IL_018f;
							IL_0b0e:
							if (!textParamValue3.Equals("BinaryFile", StringComparison.OrdinalIgnoreCase))
							{
								break;
							}
							_003C_003Ec__DisplayClass67_.lmMStqpiK7a.ActionLogger?.LogInfo("发送纯文件格式。");
							textParamValue6 = XActionHelper.GetTextParamValue(JLCtlXr37Bq, _003C_003Ec__DisplayClass67_.g0JStRcGYTa, _003C_003Ec__DisplayClass67_.lmMStqpiK7a);
							if (textParamValue4.StartsWith("FILE:", StringComparison.InvariantCultureIgnoreCase))
							{
								string text = textParamValue4.Substring("FILE:".Length);
								if (System.IO.File.Exists(text))
								{
									HttpContent httpContent = new StreamContent(new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read));
									httpContent.Headers.ContentType = new MediaTypeHeaderValue(MimeTypeMap.GetMimeType(text));
									httpRequestMessage.Content = httpContent;
									goto IL_0c9e;
								}
								result = (false, "文件不存在：" + textParamValue4, ActionStopFlag.OperationFailed);
							}
							else
							{
								if (!textParamValue4.StartsWith("IMG:", StringComparison.InvariantCultureIgnoreCase))
								{
									goto IL_0cd9;
								}
								string text2 = textParamValue4.Substring("IMG:".Length);
								if (!_003C_003Ec__DisplayClass67_.lmMStqpiK7a.IsVarExists(text2))
								{
									result = (false, "图片变量不存在：" + text2, ActionStopFlag.OperationFailed);
								}
								else
								{
									if (_003C_003Ec__DisplayClass67_.lmMStqpiK7a.GetVarValue(text2) is Image image)
									{
										memoryStream = new MemoryStream();
										image.Save(memoryStream, ImageFormat.Png);
										memoryStream.Position = 0L;
										goto IL_0c71;
									}
									result = (false, "图片变量内容为空或不是图片：" + text2, ActionStopFlag.OperationFailed);
								}
							}
							goto end_IL_000e;
							IL_018f:
							httpRequestMessage = new HttpRequestMessage(new HttpMethod(textParamValue), juG2cRAltrZ.url);
							uri = new Uri(juG2cRAltrZ.url);
							if (!string.IsNullOrEmpty(textParamValue2))
							{
								array = textParamValue2.Split(new char[2] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
								for (i = 0; i < array.Length; i++)
								{
									string text3 = array[i];
									int num2 = text3.IndexOf(':');
									if (num2 < 0)
									{
										continue;
									}
									string text4 = text3.Substring(0, num2);
									string value = ((text3.Length > num2 + 1) ? text3.Substring(num2 + 1) : string.Empty);
									try
									{
										httpRequestMessage.Headers.Add(text4, value);
									}
									catch (Exception ex)
									{
										_003C_003Ec__DisplayClass67_.lmMStqpiK7a.ActionLogger.LogWarning("请求头" + text4 + "可能不合法。" + ex.Message);
										if (!text4.StartsWith("content-", StringComparison.OrdinalIgnoreCase))
										{
											httpRequestMessage.Headers.TryAddWithoutValidation(text4, value);
										}
									}
								}
							}
							wW02cVUxZFq = new CookieContainer(200, 200, 10000);
							while (true)
							{
								IL_01df:
								object paramValue = XActionHelper.GetParamValue(Wogtl1eFQT1, _003C_003Ec__DisplayClass67_.g0JStRcGYTa, _003C_003Ec__DisplayClass67_.lmMStqpiK7a, false, true);
								if (!(paramValue is IDictionary<string, object> dictionary))
								{
									string text5 = VariableHelper.LcfghRCibTg(paramValue);
									if (!string.IsNullOrWhiteSpace(text5))
									{
										enumerator = text5.TrimEnd(';').Split(';').Select(_003C_003Ec.LQSStEbOxRw ?? (_003C_003Ec.LQSStEbOxRw = _003C_003Ec.ihNStCQKXcM.rIoStuvAhaK))
											.GetEnumerator();
										goto IL_0758;
									}
								}
								else
								{
									IEnumerator<KeyValuePair<string, object>> enumerator2 = dictionary.GetEnumerator();
									try
									{
										CookieContainer cookieContainer;
										Uri uri2;
										string key;
										object obj;
										for (; enumerator2.MoveNext(); cookieContainer.Add(uri2, new Cookie(key, (string)obj)))
										{
											KeyValuePair<string, object> current = enumerator2.Current;
											cookieContainer = wW02cVUxZFq;
											uri2 = uri;
											key = current.Key;
											object value2 = current.Value;
											if (value2 != null)
											{
												obj = value2.ToString().Replace(",", "%2C");
												if (obj != null)
												{
													continue;
												}
											}
											else
											{
												obj = null;
											}
											obj = "";
										}
									}
									finally
									{
										if (num < 0)
										{
											enumerator2?.Dispose();
										}
									}
								}
								goto IL_093c;
								IL_0758:
								try
								{
									while (enumerator.MoveNext())
									{
										string[] current2 = enumerator.Current;
										string name = current2[0].Trim();
										string text6 = ((current2.Length != 1) ? current2[1] : string.Empty);
										wW02cVUxZFq.Add(uri, new Cookie(name, text6.Replace(",", "%2C")));
										int num3 = 0;
										if (!M6oYihyfP8j4CkQ41gXo())
										{
											num3 = num4;
										}
										switch (num3)
										{
										}
									}
								}
								finally
								{
									if (num < 0)
									{
										enumerator?.Dispose();
									}
								}
								goto IL_093c;
								IL_093c:
								while (!textParamValue.EqualsAny(true, "GET", "OPTIONS", "HEAD") && !string.IsNullOrEmpty(textParamValue4))
								{
									while (true)
									{
										IL_027d:
										_003C_003Ec__DisplayClass67_.lmMStqpiK7a.ActionLogger?.LogInfo("非Get请求（" + textParamValue + "）, 处理请求体。");
										while (true)
										{
											int num5;
											if (textParamValue3.Equals("json", StringComparison.OrdinalIgnoreCase))
											{
												textParamValue7 = XActionHelper.GetTextParamValue(JLCtlXr37Bq, _003C_003Ec__DisplayClass67_.g0JStRcGYTa, _003C_003Ec__DisplayClass67_.lmMStqpiK7a);
												_003C_003Ec__DisplayClass67_.lmMStqpiK7a.ActionLogger?.LogInfo("发送JSON格式。");
												httpRequestMessage.Content = new StringContent(textParamValue4, Encoding.UTF8, textParamValue7.Or("application/json"));
												if (!string.IsNullOrEmpty(textParamValue7))
												{
													num5 = 0;
													if (M6oYihyfP8j4CkQ41gXo())
													{
														goto IL_03bb;
													}
													goto IL_0679;
												}
											}
											goto IL_06a2;
											IL_0afc:
											result = (false, "BODY参数为空。", ActionStopFlag.OperationFailed);
											goto end_IL_000e;
											IL_05b4:
											text7 = new string(Encoding.UTF8.GetBytes(text7).Select(_003C_003Ec.NDrSt8sQwiQ ?? (_003C_003Ec.NDrSt8sQwiQ = _003C_003Ec.ihNStCQKXcM.EVYStJUOfZg)).ToArray());
											streamContent.Headers.Add("Content-Disposition", text7);
											streamContent.Headers.ContentType = new MediaTypeHeaderValue(MimeTypeMap.GetMimeType(".png"));
											multipartFormDataContent.Add(streamContent, LxotlZC0N2l(text8), text9);
											goto IL_065d;
											IL_0a8d:
											if (!string.IsNullOrEmpty(textParamValue8) && !textParamValue8.Contains("charset"))
											{
												httpRequestMessage.Content.Headers.ContentType.CharSet = "";
											}
											goto end_IL_093c;
											IL_0663:
											if (i >= array.Length)
											{
												multipartFormDataContent.Headers.Remove("Content-Type");
												multipartFormDataContent.Headers.Add("Content-Type", "multipart/form-data; boundary=" + text10);
												httpRequestMessage.Content = multipartFormDataContent;
												goto end_IL_093c;
											}
											string text11 = array[i];
											int num6 = text11.IndexOf("=", StringComparison.OrdinalIgnoreCase);
											if (num6 < 0)
											{
												goto IL_0afc;
											}
											if (num6 >= text11.Length - 1)
											{
												num5 = 1;
												if (!M6oYihyfP8j4CkQ41gXo())
												{
													num5 = num7;
												}
												goto IL_03bb;
											}
											text8 = text11.Substring(0, num6);
											string text12 = text11.Substring(num6 + 1);
											if (text12.StartsWith("FILE:", StringComparison.OrdinalIgnoreCase))
											{
												text13 = text12.Substring("FILE:".Length);
												num5 = 3;
												if (M6oYihyfP8j4CkQ41gXo())
												{
													goto IL_03bb;
												}
												goto IL_0411;
											}
											if (!text12.StartsWith("IMG:", StringComparison.OrdinalIgnoreCase))
											{
												StringContent stringContent = new StringContent(text12);
												stringContent.Headers.Remove("Content-Type");
												multipartFormDataContent.Add(stringContent, LxotlZC0N2l(text8));
												goto IL_065d;
											}
											string text14 = text12.Substring("IMG:".Length);
											if (_003C_003Ec__DisplayClass67_.lmMStqpiK7a.IsVarExists(text14))
											{
												if (_003C_003Ec__DisplayClass67_.lmMStqpiK7a.GetVarValue(text14) is Image image2)
												{
													MemoryStream memoryStream2 = new MemoryStream();
													image2.Save(memoryStream2, ImageFormat.Png);
													memoryStream2.Position = 0L;
													streamContent = new StreamContent(memoryStream2);
													text9 = DateTime.Now.Ticks + ".png";
													text7 = "form-data; name=\"" + text8 + "\"; filename=\"" + text9 + "\"";
													goto IL_05b4;
												}
												result = (false, "图片变量内容为空或不是图片：" + text14, ActionStopFlag.OperationFailed);
											}
											else
											{
												result = (false, "图片变量不存在：" + text14, ActionStopFlag.OperationFailed);
											}
											goto end_IL_000e;
											IL_06a2:
											if (!textParamValue3.Equals("text", StringComparison.OrdinalIgnoreCase))
											{
												if (!textParamValue3.Equals("form", StringComparison.OrdinalIgnoreCase))
												{
													if (!textParamValue3.Equals("file", StringComparison.OrdinalIgnoreCase))
													{
														break;
													}
													goto IL_02b8;
												}
												_003C_003Ec__DisplayClass67_.lmMStqpiK7a.ActionLogger?.LogInfo("发送文本表单格式。");
												httpRequestMessage.Content = new StringContent(textParamValue4, Encoding.UTF8, "application/x-www-form-urlencoded");
												goto end_IL_093c;
											}
											textParamValue8 = XActionHelper.GetTextParamValue(JLCtlXr37Bq, _003C_003Ec__DisplayClass67_.g0JStRcGYTa, _003C_003Ec__DisplayClass67_.lmMStqpiK7a);
											_003C_003Ec__DisplayClass67_.lmMStqpiK7a.ActionLogger?.LogInfo("发送Text格式。");
											StringContent content = new StringContent(textParamValue4, Encoding.UTF8, textParamValue8.Or("text/plain"));
											httpRequestMessage.Content = content;
											num7 = 15;
											goto IL_0a8d;
											IL_03bb:
											switch (num5)
											{
											case 5:
												break;
											case 16:
												goto IL_01df;
											case 11:
												goto IL_027d;
											case 6:
												goto IL_02b8;
											case 3:
												goto IL_0411;
											case 4:
												goto IL_045f;
											case 18:
												goto IL_05b4;
											case 13:
												goto IL_065d;
											default:
												goto IL_0679;
											case 9:
												continue;
											case 8:
												goto IL_0758;
											case 12:
												goto IL_0857;
											case 17:
												goto IL_093c_2;
											case 15:
												goto IL_0a8d;
											case 1:
												goto IL_0afc;
											case 14:
												goto IL_0c71;
											case 10:
												goto IL_0cbe;
											case 7:
												goto IL_0cd9;
											case 2:
												goto end_IL_093c;
											}
											goto IL_0129;
											IL_045f:
											text15 = new string(Encoding.UTF8.GetBytes(text15).Select(_003C_003Ec.kLvStyeN4CF ?? (_003C_003Ec.kLvStyeN4CF = _003C_003Ec.ihNStCQKXcM.jwTStNm5NKh)).ToArray());
											streamContent2.Headers.Add("Content-Disposition", text15);
											streamContent2.Headers.ContentType = new MediaTypeHeaderValue(MimeTypeMap.GetMimeType(text13));
											multipartFormDataContent.Add(streamContent2, LxotlZC0N2l(text8), Path.GetFileName(text13));
											goto IL_065d;
											IL_065d:
											i++;
											goto IL_0663;
											IL_0411:
											if (System.IO.File.Exists(text13))
											{
												streamContent2 = new StreamContent(System.IO.File.OpenRead(text13));
												text15 = "form-data; name=\"" + text8 + "\"; filename=\"" + Path.GetFileName(text13) + "\"";
												goto IL_045f;
											}
											result = (false, "文件不存在：" + text13, ActionStopFlag.OperationFailed);
											goto end_IL_000e;
											IL_0679:
											if (!textParamValue7.Contains("charset"))
											{
												httpRequestMessage.Content.Headers.ContentType.CharSet = "";
											}
											goto IL_06a2;
											IL_02b8:
											_003C_003Ec__DisplayClass67_.lmMStqpiK7a.ActionLogger?.LogInfo("发送Multipart表单格式。");
											string[] array2 = textParamValue4.Split(new char[2] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
											if (array2.Length != 0)
											{
												text10 = "----quickerupload--" + DateTime.Now.Ticks.ToString(CultureInfo.InvariantCulture);
												multipartFormDataContent = new MultipartFormDataContent(text10);
												array = array2;
												i = 0;
												goto IL_0663;
											}
											result = (false, "BODY参数为空。", ActionStopFlag.OperationFailed);
											goto end_IL_000e;
										}
										break;
									}
									goto IL_0b0e;
									continue;
									end_IL_093c:
									break;
									IL_093c_2:;
								}
								break;
							}
							break;
							IL_0c71:
							StreamContent streamContent3 = new StreamContent(memoryStream);
							streamContent3.Headers.ContentType = new MediaTypeHeaderValue(MimeTypeMap.GetMimeType(".png"));
							httpRequestMessage.Content = streamContent3;
							goto IL_0c9e;
						}
					}
					try
					{
						ProgressMessageHandler progressMessageHandler = default(ProgressMessageHandler);
						if ((uint)num > 7u)
						{
							progressMessageHandler = null;
							KwW2cZOeJH3 = _003C_003Ec__DisplayClass67_.iJUStc2TLkV.CreateClient(!booleanParamValue, expireSeconds, wW02cVUxZFq, booleanParamValue3, booleanParamValue4, _003C_003Ec__DisplayClass67_.lmMStqpiK7a, out progressMessageHandler);
						}
						try
						{
							Dictionary<string, object> dictionary2 = default(Dictionary<string, object>);
							int num8;
							TaskAwaiter<Stream> awaiter = default(TaskAwaiter<Stream>);
							TaskAwaiter<string> awaiter2 = default(TaskAwaiter<string>);
							string textParamValue9 = default(string);
							Stream result3;
							string result5 = default(string);
							int num9 = default(int);
							IEnumerator<KeyValuePair<string, IEnumerable<string>>> enumerator5;
							Stream result7;
							Stream result8;
							switch (num)
							{
							default:
								juG2cRAltrZ.kyoSthAUPcT = 0;
								if (booleanParamValue2)
								{
									juG2cRAltrZ.kyoSthAUPcT = ProgressReportMgr.RequestProgressId();
									progressMessageHandler.HttpSendProgress += juG2cRAltrZ.JpEStZcla57;
									progressMessageHandler.HttpReceiveProgress += juG2cRAltrZ.tZrSt92K3Vu;
								}
								if (!string.IsNullOrWhiteSpace(textParamValue5))
								{
									KwW2cZOeJH3.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", textParamValue5);
								}
								Il62c9WMlQf = null;
								goto case 0;
							case 0:
								try
								{
									TaskAwaiter<HttpResponseMessage> awaiter4;
									if (num == 0)
									{
										awaiter4 = Paw2chhVUGl;
										Paw2chhVUGl = default(TaskAwaiter<HttpResponseMessage>);
										num = -1;
										Yn62c8kwPPt = -1;
									}
									else
									{
										awaiter4 = KwW2cZOeJH3.SendAsync(httpRequestMessage, HttpCompletionOption.ResponseHeadersRead, _003C_003Ec__DisplayClass67_.lmMStqpiK7a.CancellationToken ?? CancellationToken.None).GetAwaiter();
										if (!awaiter4.IsCompleted)
										{
											num = 0;
											Yn62c8kwPPt = 0;
											if (M6oYihyfP8j4CkQ41gXo())
											{
												switch (0)
												{
												}
											}
											Paw2chhVUGl = awaiter4;
											pv82ca6NAyW.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
											return;
										}
									}
									HttpResponseMessage result6 = awaiter4.GetResult();
									Il62c9WMlQf = result6;
									if (Il62c9WMlQf != null)
									{
										goto end_IL_0e11;
									}
									result = (false, "响应为空。", ActionStopFlag.OperationFailed);
									goto end_IL_0d1e;
									end_IL_0e11:;
								}
								finally
								{
									if (num < 0 && juG2cRAltrZ.kyoSthAUPcT > 0)
									{
										ProgressReportMgr.RemoveProgress(juG2cRAltrZ.kyoSthAUPcT);
									}
								}
								XActionHelper.OutputResult(WwbtlDJJdQX, _003C_003Ec__DisplayClass67_.g0JStRcGYTa, _003C_003Ec__DisplayClass67_.lmMStqpiK7a, (int)Il62c9WMlQf.StatusCode, _003C_003Ec__DisplayClass67_.L6SStV6L1r3);
								if (XActionHelper.IsOutputParamSetted(u2stldFjkUP.Key, _003C_003Ec__DisplayClass67_.g0JStRcGYTa))
								{
									dictionary2 = new Dictionary<string, object>();
									num8 = 0;
									if (M6oYihyfP8j4CkQ41gXo())
									{
										goto IL_1001;
									}
									goto IL_109f;
								}
								goto IL_12b4;
							case 1:
								awaiter = yun2cIOQvgo;
								yun2cIOQvgo = default(TaskAwaiter<Stream>);
								num = -1;
								Yn62c8kwPPt = -1;
								goto IL_145b;
							case 2:
							case 3:
								try
								{
									if ((uint)(num - 2) > 1u)
									{
										BJr2cYjYTXU = new StreamReader(b042ceFCq6Y);
									}
									try
									{
										TaskAwaiter<IDictionary<string, object>> awaiter5 = default(TaskAwaiter<IDictionary<string, object>>);
										if (num != 2)
										{
											if (num != 3)
											{
												goto IL_1540;
											}
											awaiter5 = D7g2ckr8OML;
											D7g2ckr8OML = default(TaskAwaiter<IDictionary<string, object>>);
											goto IL_152f;
										}
										awaiter2 = cb02cW6HKAs;
										cb02cW6HKAs = default(TaskAwaiter<string>);
										num = -1;
										Yn62c8kwPPt = -1;
										goto IL_15ba;
										IL_151c:
										int num10;
										switch (num10)
										{
										case 2:
											break;
										default:
											goto IL_1552;
										case 1:
											pv82ca6NAyW.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
											return;
										}
										goto IL_152f;
										IL_151a:
										int num11 = default(int);
										num10 = num11;
										goto IL_151c;
										IL_152f:
										num = -1;
										Yn62c8kwPPt = -1;
										goto IL_1538;
										IL_1540:
										if (!BJr2cYjYTXU.EndOfStream)
										{
											CancellationToken? cancellationToken = _003C_003Ec__DisplayClass67_.lmMStqpiK7a.CancellationToken;
											if (!cancellationToken.HasValue || !cancellationToken.GetValueOrDefault().IsCancellationRequested)
											{
												awaiter2 = BJr2cYjYTXU.ReadLineAsync().GetAwaiter();
												num10 = 0;
												if (!M6oYihyfP8j4CkQ41gXo())
												{
													goto IL_151a;
												}
												goto IL_151c;
											}
										}
										_003C_003Ec__DisplayClass67_.lmMStqpiK7a.ActionLogger.LogInfo("流式输出结束。");
										goto end_IL_1485;
										IL_1538:
										awaiter5.GetResult();
										goto IL_1540;
										IL_1552:
										if (!awaiter2.IsCompleted)
										{
											num = 2;
											Yn62c8kwPPt = 2;
											cb02cW6HKAs = awaiter2;
											pv82ca6NAyW.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
											return;
										}
										goto IL_15ba;
										IL_15ba:
										string result9 = awaiter2.GetResult();
										if (!string.IsNullOrWhiteSpace(result9))
										{
											Dictionary<string, object> inputParams = new Dictionary<string, object> { { "data", result9 } };
											awaiter5 = _003C_003Ec__DisplayClass67_.lmMStqpiK7a.RunSpAsync(fC42ccH0HYZ, inputParams).GetAwaiter();
											if (!awaiter5.IsCompleted)
											{
												num = 3;
												Yn62c8kwPPt = 3;
												D7g2ckr8OML = awaiter5;
												num10 = 1;
												if (AOk1h2yfgIbit2KPykKI != null)
												{
													goto IL_151a;
												}
												goto IL_151c;
											}
											goto IL_1538;
										}
										goto IL_1540;
										end_IL_1485:;
									}
									finally
									{
										if (num < 0 && BJr2cYjYTXU != null)
										{
											((IDisposable)BJr2cYjYTXU).Dispose();
										}
									}
								}
								finally
								{
									if (num < 0 && b042ceFCq6Y != null)
									{
										((IDisposable)b042ceFCq6Y).Dispose();
									}
								}
								b042ceFCq6Y = null;
								BJr2cYjYTXU = null;
								break;
							case 4:
								awaiter2 = cb02cW6HKAs;
								cb02cW6HKAs = default(TaskAwaiter<string>);
								num = -1;
								Yn62c8kwPPt = -1;
								goto IL_1681;
							case 5:
								goto IL_16da;
							case 6:
								awaiter = yun2cIOQvgo;
								yun2cIOQvgo = default(TaskAwaiter<Stream>);
								num = -1;
								Yn62c8kwPPt = -1;
								goto IL_17fd;
							case 7:
								{
									awaiter = yun2cIOQvgo;
									yun2cIOQvgo = default(TaskAwaiter<Stream>);
									num = -1;
									Yn62c8kwPPt = -1;
									goto IL_1882;
								}
								IL_0f64:
								textParamValue9 = XActionHelper.GetTextParamValue(N0htlsAe1ox, _003C_003Ec__DisplayClass67_.g0JStRcGYTa, _003C_003Ec__DisplayClass67_.lmMStqpiK7a);
								if (!string.IsNullOrEmpty(textParamValue9) && !textParamValue9.Equals("text", StringComparison.OrdinalIgnoreCase))
								{
									if (!textParamValue9.Equals("image", StringComparison.OrdinalIgnoreCase))
									{
										if (!textParamValue9.Equals("File", StringComparison.OrdinalIgnoreCase))
										{
											goto IL_1340;
										}
										awaiter = Il62c9WMlQf.Content.ReadAsStreamAsync().GetAwaiter();
										if (!awaiter.IsCompleted)
										{
											num = 7;
											Yn62c8kwPPt = 7;
											yun2cIOQvgo = awaiter;
											num8 = 4;
											if (!M6oYihyfP8j4CkQ41gXo())
											{
												goto IL_0fff;
											}
											goto IL_1001;
										}
										goto IL_1882;
									}
									awaiter = Il62c9WMlQf.Content.ReadAsStreamAsync().GetAwaiter();
									goto IL_12ea;
								}
								YjG2cGhBIYS = "";
								XGs2cs0ElO3 = Il62c9WMlQf.Content?.Headers?.ContentType?.CharSet;
								if (!string.IsNullOrEmpty(XGs2cs0ElO3) && (XGs2cs0ElO3.IndexOf("utf8", StringComparison.OrdinalIgnoreCase) >= 0 || XGs2cs0ElO3.IndexOf("utf-8", StringComparison.OrdinalIgnoreCase) >= 0))
								{
									Il62c9WMlQf.Content.Headers.ContentType.CharSet = Encoding.UTF8.WebName;
								}
								awaiter2 = Il62c9WMlQf.Content.ReadAsStringAsync().GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									goto IL_141a;
								}
								goto IL_1681;
								IL_16da:
								try
								{
									TaskAwaiter<byte[]> awaiter3;
									if (num != 5)
									{
										awaiter3 = Il62c9WMlQf.Content.ReadAsByteArrayAsync().GetAwaiter();
										if (!awaiter3.IsCompleted)
										{
											num = 5;
											Yn62c8kwPPt = 5;
											UaS2c1jrnI8 = awaiter3;
											pv82ca6NAyW.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
											return;
										}
									}
									else
									{
										awaiter3 = UaS2c1jrnI8;
										if (AOk1h2yfgIbit2KPykKI != null)
										{
											switch (0)
											{
											}
										}
										UaS2c1jrnI8 = default(TaskAwaiter<byte[]>);
										num = -1;
										Yn62c8kwPPt = -1;
									}
									byte[] result2 = awaiter3.GetResult();
									Encoding encoding = Encoding.GetEncoding(HvH2cHoOOYj);
									YjG2cGhBIYS = encoding.GetString(result2);
								}
								catch (Exception ex3)
								{
									_003C_003Ec__DisplayClass67_.lmMStqpiK7a.ActionLogger.LogWarning("转换编码出错：" + ex3.Message);
								}
								goto IL_17a3;
								IL_17fd:
								result3 = awaiter.GetResult();
								try
								{
									MemoryStream memoryStream3 = new MemoryStream();
									result3.CopyTo(memoryStream3);
									memoryStream3.Position = 0L;
									Image result4 = Image.FromStream(memoryStream3, true, false);
									XActionHelper.OutputResult(BWBtlMJOBpq, _003C_003Ec__DisplayClass67_.g0JStRcGYTa, _003C_003Ec__DisplayClass67_.lmMStqpiK7a, result4, _003C_003Ec__DisplayClass67_.L6SStV6L1r3);
								}
								finally
								{
									if (num < 0)
									{
										((IDisposable)result3)?.Dispose();
									}
								}
								break;
								IL_17aa:
								XActionHelper.OutputResult(e3QtlTvVQHj, _003C_003Ec__DisplayClass67_.g0JStRcGYTa, _003C_003Ec__DisplayClass67_.lmMStqpiK7a, YjG2cGhBIYS, _003C_003Ec__DisplayClass67_.L6SStV6L1r3);
								YjG2cGhBIYS = null;
								XGs2cs0ElO3 = null;
								break;
								IL_1681:
								result5 = awaiter2.GetResult();
								goto IL_168a;
								IL_12ea:
								if (!awaiter.IsCompleted)
								{
									num = 6;
									Yn62c8kwPPt = 6;
									yun2cIOQvgo = awaiter;
									pv82ca6NAyW.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_17fd;
								IL_141a:
								num = 4;
								Yn62c8kwPPt = 4;
								cb02cW6HKAs = awaiter2;
								pv82ca6NAyW.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
								IL_0fff:
								num8 = num9;
								goto IL_1001;
								IL_12b4:
								if (XActionHelper.IsOutputParamSetted(Q2AtloaMwJJ.Key, _003C_003Ec__DisplayClass67_.g0JStRcGYTa))
								{
									Uri requestUri = Il62c9WMlQf.RequestMessage.RequestUri;
									Dictionary<string, object> dictionary3 = new Dictionary<string, object>();
									if (Il62c9WMlQf.Headers.TryGetValues("set-cookie", out var values))
									{
										IEnumerator<string> enumerator3 = values.GetEnumerator();
										try
										{
											while (enumerator3.MoveNext())
											{
												string[] array3 = enumerator3.Current.Split(';')[0].Split('=');
												string key2 = array3[0];
												string value3 = array3[1];
												dictionary3[key2] = value3;
											}
										}
										finally
										{
											if (num < 0)
											{
												enumerator3?.Dispose();
											}
										}
									}
									try
									{
										IEnumerator<Cookie> enumerator4 = wW02cVUxZFq.GetCookies(new Uri(juG2cRAltrZ.url)).Cast<Cookie>().GetEnumerator();
										try
										{
											while (enumerator4.MoveNext())
											{
												Cookie current3 = enumerator4.Current;
												dictionary3[current3.Name] = current3.Value;
											}
										}
										finally
										{
											if (num < 0)
											{
												enumerator4?.Dispose();
											}
										}
									}
									catch (Exception)
									{
										IEnumerable<Cookie> source = wW02cVUxZFq.GetCookies(new Uri(juG2cRAltrZ.url)).Cast<Cookie>();
										_003C_003Ec__DisplayClass67_.lmMStqpiK7a.ActionLogger.LogWarning("Cookie重复了。" + string.Join("\r\n", source.Select(_003C_003Ec.LsDStaNq1Mg ?? (_003C_003Ec.LsDStaNq1Mg = _003C_003Ec.ihNStCQKXcM.yTCSt0V7f8r))));
										throw;
									}
									XActionHelper.OutputResult(Q2AtloaMwJJ, _003C_003Ec__DisplayClass67_.g0JStRcGYTa, _003C_003Ec__DisplayClass67_.lmMStqpiK7a, dictionary3, _003C_003Ec__DisplayClass67_.L6SStV6L1r3);
									num8 = 1;
									if (AOk1h2yfgIbit2KPykKI != null)
									{
										goto IL_1001;
									}
								}
								goto IL_1092;
								IL_1001:
								switch (num8)
								{
								case 2:
									break;
								case 1:
									goto IL_1092;
								default:
									goto IL_109f;
								case 3:
									goto IL_12ea;
								case 4:
									pv82ca6NAyW.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 6:
									pv82ca6NAyW.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 7:
									goto IL_1340;
								case 10:
									goto IL_141a;
								case 9:
									goto IL_1681;
								case 5:
									goto IL_168a;
								case 8:
									goto IL_16da;
								}
								goto IL_0f64;
								IL_17a3:
								HvH2cHoOOYj = null;
								goto IL_17aa;
								IL_109f:
								enumerator5 = Il62c9WMlQf.Headers.GetEnumerator();
								try
								{
									while (enumerator5.MoveNext())
									{
										KeyValuePair<string, IEnumerable<string>> current4 = enumerator5.Current;
										dictionary2.Add(current4.Key, current4.Value.FirstOrDefault());
									}
								}
								finally
								{
									if (num < 0)
									{
										enumerator5?.Dispose();
									}
								}
								XActionHelper.OutputResult(u2stldFjkUP, _003C_003Ec__DisplayClass67_.g0JStRcGYTa, _003C_003Ec__DisplayClass67_.lmMStqpiK7a, dictionary2, _003C_003Ec__DisplayClass67_.L6SStV6L1r3);
								goto IL_12b4;
								IL_1882:
								result7 = awaiter.GetResult();
								try
								{
									string text16 = Path.GetTempFileName();
									string extension = MimeTypeMap.GetExtension(Il62c9WMlQf.Content.Headers.ContentType.ToString(), false);
									if (!string.IsNullOrWhiteSpace(extension))
									{
										text16 = Path.ChangeExtension(text16, extension);
									}
									FileStream fileStream = System.IO.File.OpenWrite(text16);
									try
									{
										result7.CopyTo(fileStream);
										XActionHelper.OutputResult(e3QtlTvVQHj, _003C_003Ec__DisplayClass67_.g0JStRcGYTa, _003C_003Ec__DisplayClass67_.lmMStqpiK7a, text16, _003C_003Ec__DisplayClass67_.L6SStV6L1r3);
									}
									finally
									{
										if (num < 0)
										{
											((IDisposable)fileStream)?.Dispose();
										}
									}
								}
								finally
								{
									if (num < 0)
									{
										((IDisposable)result7)?.Dispose();
									}
								}
								break;
								IL_1092:
								if (!QRg2cq0lOrG)
								{
									goto IL_0f64;
								}
								_003C_003Ec__DisplayClass67_.lmMStqpiK7a.ActionLogger.LogInfo("开始流式输出。");
								awaiter = Il62c9WMlQf.Content.ReadAsStreamAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num = 1;
									Yn62c8kwPPt = 1;
									yun2cIOQvgo = awaiter;
									num8 = 6;
									if (AOk1h2yfgIbit2KPykKI != null)
									{
										goto IL_0fff;
									}
									goto IL_1001;
								}
								goto IL_145b;
								IL_1340:
								result = (false, "不支持的结果类型：" + textParamValue9 + "。", ActionStopFlag.OperationFailed);
								goto end_IL_0d1e;
								IL_168a:
								YjG2cGhBIYS = result5;
								if (string.IsNullOrWhiteSpace(XGs2cs0ElO3))
								{
									HvH2cHoOOYj = GetCharsetFromHtmlContent(YjG2cGhBIYS);
									if (!string.IsNullOrWhiteSpace(HvH2cHoOOYj) && !string.Equals(HvH2cHoOOYj, "utf-8", StringComparison.OrdinalIgnoreCase))
									{
										goto IL_16da;
									}
									goto IL_17a3;
								}
								goto IL_17aa;
								IL_145b:
								result8 = awaiter.GetResult();
								b042ceFCq6Y = result8;
								goto case 2;
							}
							Il62c9WMlQf = null;
							goto IL_193e;
							end_IL_0d1e:;
						}
						finally
						{
							if (num < 0 && KwW2cZOeJH3 != null)
							{
								((IDisposable)KwW2cZOeJH3).Dispose();
							}
						}
						goto end_IL_0cec;
						IL_193e:
						KwW2cZOeJH3 = null;
						XActionHelper.OutputResult(iNXtl5LEUNy, _003C_003Ec__DisplayClass67_.g0JStRcGYTa, _003C_003Ec__DisplayClass67_.lmMStqpiK7a, true, _003C_003Ec__DisplayClass67_.L6SStV6L1r3);
						goto IL_19f7;
						end_IL_0cec:;
					}
					catch (Exception ex5)
					{
						_003C_003Ec__DisplayClass67_.lmMStqpiK7a.ActionLogger?.LogInfo("StackTrace:" + ex5.StackTrace);
						if (ex5.InnerException != null)
						{
							_003C_003Ec__DisplayClass67_.lmMStqpiK7a.ActionLogger?.LogInfo("InnerException:" + ex5.InnerException.Message + "  " + ex5.InnerException.StackTrace);
						}
						result = (false, "发送网络请求出错：" + ex5.GetMessageWithInner(), ActionStopFlag.OperationFailed);
					}
					goto end_IL_000e;
					IL_19f7:
					result = (true, "", ActionStopFlag.NoStop);
					end_IL_000e:;
				}
				catch (Exception exception)
				{
					Yn62c8kwPPt = -2;
					juG2cRAltrZ = null;
					fC42ccH0HYZ = null;
					wW02cVUxZFq = null;
					pv82ca6NAyW.SetException(exception);
					return;
				}
				Yn62c8kwPPt = -2;
				juG2cRAltrZ = null;
				fC42ccH0HYZ = null;
				wW02cVUxZFq = null;
				pv82ca6NAyW.SetResult(result);
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				pv82ca6NAyW.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool M6oYihyfP8j4CkQ41gXo()
			{
				return AOk1h2yfgIbit2KPykKI == null;
			}
		}

		public ActionStep g0JStRcGYTa;

		public ActionExecuteContext lmMStqpiK7a;

		public HttpStep iJUStc2TLkV;

		public XAction L6SStV6L1r3;

		internal static _003C_003Ec__DisplayClass67_0 VTtiuKWEPESX1RXyMPEC;

		[AsyncStateMachine(typeof(gRr3cnkUtwWQILnT0Pf))]
		internal Task<(bool isSuccess, string message, ActionStopFlag failReason)> JnQSt7FqadP()
		{
			gRr3cnkUtwWQILnT0Pf stateMachine = default(gRr3cnkUtwWQILnT0Pf);
			stateMachine.pv82ca6NAyW = AsyncTaskMethodBuilder<(bool, string, ActionStopFlag)>.Create();
			stateMachine.rD52c7a7qWq = this;
			stateMachine.Yn62c8kwPPt = -1;
			stateMachine.pv82ca6NAyW.Start(ref stateMachine);
			return stateMachine.pv82ca6NAyW.Task;
		}

		static _003C_003Ec__DisplayClass67_0()
		{
		}

		internal static void bLywxDWExRcowh8xTSR4()
		{
		}

		internal static bool g6wXG6WEMGyfVMIwHqtv()
		{
			return VTtiuKWEPESX1RXyMPEC == null;
		}

		internal static void uLukSeWEImqqfBUCkiFo()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass67_1
	{
		public string url;

		public int kyoSthAUPcT;

		public _003C_003Ec__DisplayClass67_0 jIESterNSK1;

		internal static _003C_003Ec__DisplayClass67_1 GyIoW2WE6HLYnH9hYSst;

		internal void JpEStZcla57(object sender, HttpProgressEventArgs e)
		{
			int id = kyoSthAUPcT;
			string title = url;
			double percentage = ((e.TotalBytes > 0L) ? (100.0 * (double)e.BytesTransferred / (double)e.TotalBytes.Value) : 50.0);
			string text = e.BytesTransferred.ToReadableSize();
			long? totalBytes = e.TotalBytes;
			object obj;
			if (totalBytes.HasValue)
			{
				obj = totalBytes.GetValueOrDefault().ToReadableSize();
				if (obj != null)
				{
					goto IL_009d;
				}
			}
			else
			{
				obj = null;
			}
			obj = "-";
			goto IL_009d;
			IL_009d:
			ProgressReportMgr.UpdateProgress(id, "", title, percentage, "发送中：" + text + "/" + (string)obj, jIESterNSK1.lmMStqpiK7a.Id);
		}

		internal void tZrSt92K3Vu(object sender, HttpProgressEventArgs e)
		{
			int id = kyoSthAUPcT;
			string title = url;
			double percentage = ((e.TotalBytes > 0L) ? (100.0 * (double)e.BytesTransferred / (double)e.TotalBytes.Value) : 50.0);
			string text = e.BytesTransferred.ToReadableSize();
			long? totalBytes = e.TotalBytes;
			object obj;
			if (!totalBytes.HasValue)
			{
				obj = null;
			}
			else
			{
				obj = totalBytes.GetValueOrDefault().ToReadableSize();
				if (obj != null)
				{
					goto IL_009d;
				}
			}
			obj = "-";
			goto IL_009d;
			IL_009d:
			ProgressReportMgr.UpdateProgress(id, "", title, percentage, "下载中：" + text + "/" + (string)obj, jIESterNSK1.lmMStqpiK7a.Id);
		}

		internal static bool C91fRsWEtdBd5QZVG3sx()
		{
			return GyIoW2WE6HLYnH9hYSst == null;
		}
	}

	public const string STEP_KEY = "sys:http";

	[CompilerGenerated]
	private readonly IEnumerable<string> VM9tl9Z9qUG = new string[6] { "api", "webservice", "get", "post", "put", "patch" };

	[CompilerGenerated]
	private readonly string hOGtlhRRXX9 = "fa:Light_Cog:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> mSLtleXU8ox;

	[CompilerGenerated]
	private readonly string LKLtlYMNP4N = "https://getquicker.net/KC/Help/Doc/http";

	[CompilerGenerated]
	private readonly bool onDtlIQAUaK;

	private static readonly ILog F1jtlWX9SCC;

	private static readonly StepInParamDef zoatlk5GMPv;

	private static readonly StepInParamDef ntftlGPjA19;

	private static readonly StepInParamDef N0htlsAe1ox;

	private static readonly StepInParamDef sOmtlHpE9j0;

	private static readonly StepInParamDef Wogtl1eFQT1;

	private static readonly StepInParamDef JAltlbqBDtv;

	private static readonly StepInParamDef w0Atl6l2Gq5;

	private static readonly StepInParamDef JLCtlXr37Bq;

	private static readonly StepInParamDef hirtlmas0Jg;

	private static readonly StepInParamDef BnNtlKuwmGD;

	private static readonly StepInParamDef XY4tlxoR900;

	private static readonly StepInParamDef QLetlrY4MrL;

	private static readonly StepInParamDef mkgtlpdCkEy;

	private static readonly StepInParamDef hUgtlBCSyns;

	private static readonly StepInParamDef KuBtlQDbTAJ;

	private static readonly StepInParamDef aEktljUnTJ6;

	private static readonly StepInParamDef uDhtlnej2Zi;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> cMKtl4NSeFA = new StepInParamDef[17]
	{
		zoatlk5GMPv, ntftlGPjA19, sOmtlHpE9j0, Wogtl1eFQT1, JAltlbqBDtv, w0Atl6l2Gq5, JLCtlXr37Bq, N0htlsAe1ox, hUgtlBCSyns, KuBtlQDbTAJ,
		hirtlmas0Jg, QLetlrY4MrL, XY4tlxoR900, BnNtlKuwmGD, mkgtlpdCkEy, aEktljUnTJ6, uDhtlnej2Zi
	};

	private static readonly StepOutParamDef iNXtl5LEUNy;

	private static readonly StepOutParamDef WwbtlDJJdQX;

	private static readonly StepOutParamDef u2stldFjkUP;

	private static readonly StepOutParamDef Q2AtloaMwJJ;

	private static readonly StepOutParamDef e3QtlTvVQHj;

	private static readonly StepOutParamDef BWBtlMJOBpq;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> UVAtlA4KxH6 = new StepOutParamDef[6] { iNXtl5LEUNy, WwbtlDJJdQX, u2stldFjkUP, Q2AtloaMwJJ, e3QtlTvVQHj, BWBtlMJOBpq };

	internal static HttpStep DCQM2TQ5e3bdE22TK75g;

	public string Key => "sys:http";

	public string Name => "HTTP请求";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return VM9tl9Z9qUG;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return hOGtlhRRXX9;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Network;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return mSLtleXU8ox;
		}
	}

	public string Description => "发送HTTP请求，并获取返回结果";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return LKLtlYMNP4N;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return onDtlIQAUaK;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return cMKtl4NSeFA;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return UVAtlA4KxH6;
		}
	}

	private HttpClient CreateClient(bool allowRedirect, double expireSeconds, CookieContainer cookieContainer, bool skipVerify, bool forceProxy, ActionExecuteContext context, out ProgressMessageHandler progressMessageHandler)
	{
		WebRequestHandler webRequestHandler = new WebRequestHandler();
		progressMessageHandler = new ProgressMessageHandler(webRequestHandler);
		webRequestHandler.CachePolicy = new HttpRequestCachePolicy(HttpRequestCacheLevel.BypassCache);
		webRequestHandler.AllowAutoRedirect = allowRedirect;
		if (forceProxy)
		{
			(ProxyMode, string) tuple = AppHelper.ForceProxy(webRequestHandler);
			context.ActionLogger.LogInfo($"代理使用情况：{tuple.Item1}, {tuple.Item2}");
		}
		else
		{
			AppHelper.ApplyProxy(webRequestHandler);
		}
		webRequestHandler.CookieContainer = cookieContainer;
		webRequestHandler.AutomaticDecompression = DecompressionMethods.GZip;
		int num = 0;
		if (DCQM2TQ5e3bdE22TK75g != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
		{
			if (skipVerify)
			{
				webRequestHandler.ServerCertificateValidationCallback = _003C_003Ec.bc9StPpZlyE ?? (_003C_003Ec.bc9StPpZlyE = _003C_003Ec.ihNStCQKXcM.PECSt2jwEwu);
			}
			HttpClient httpClient = new HttpClient(progressMessageHandler);
			httpClient.Timeout = TimeSpan.FromSeconds(expireSeconds);
			httpClient.DefaultRequestHeaders.CacheControl = new CacheControlHeaderValue
			{
				NoCache = true
			};
			httpClient.DefaultRequestHeaders.ExpectContinue = false;
			return httpClient;
		}
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass67_0 _003C_003Ec__DisplayClass67_ = new _003C_003Ec__DisplayClass67_0();
		_003C_003Ec__DisplayClass67_.g0JStRcGYTa = step;
		_003C_003Ec__DisplayClass67_.lmMStqpiK7a = context;
		_003C_003Ec__DisplayClass67_.iJUStc2TLkV = this;
		_003C_003Ec__DisplayClass67_.L6SStV6L1r3 = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass67_.lmMStqpiK7a, _003C_003Ec__DisplayClass67_.g0JStRcGYTa, _003C_003Ec__DisplayClass67_.L6SStV6L1r3, (Func<Task<(bool isSuccess, string message, ActionStopFlag failReason)>>)_003C_003Ec__DisplayClass67_.JnQSt7FqadP, (Action)null, (Action)null, mkgtlpdCkEy, iNXtl5LEUNy);
	}

	private static string LxotlZC0N2l(string string_2)
	{
		if (string_2.StartsWith("\""))
		{
			return string_2;
		}
		return "\"" + string_2 + "\"";
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDirectValue(ntftlGPjA19, step) + " " + XActionHelper.GetParamDirectValue(zoatlk5GMPv, step);
	}

	public static string GetCharsetFromHtmlContent(string content)
	{
		Match match = Regex.Match(content, "charset=(?<charset>.+?)\"", RegexOptions.IgnoreCase);
		if (match.Success)
		{
			return match.Groups["charset"].Value.Trim('"', '\'', '>');
		}
		match = Regex.Match(content, "<meta[^>]*?charset=([^\"'>]*)");
		if (match.Success)
		{
			return match.Groups[1].Value;
		}
		return string.Empty;
	}

	static HttpStep()
	{
		F1jtlWX9SCC = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		zoatlk5GMPv = new StepInParamDef
		{
			Key = "url",
			Name = "网址",
			DefaultValue = "https://",
			Description = "要打开的网页地址",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		ntftlGPjA19 = new StepInParamDef
		{
			Key = "method",
			Name = "方法",
			Description = "Http请求的类型",
			DefaultValue = "GET",
			Type = VarType.Enum,
			IsRequired = true,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("GET"),
				new SelectionItem("POST"),
				new SelectionItem("PUT"),
				new SelectionItem("DELETE"),
				new SelectionItem("PATCH"),
				new SelectionItem("HEAD"),
				new SelectionItem("OPTIONS")
			},
			VariableMode = ParamVariableMode.Input,
			IsControlField = true
		};
		N0htlsAe1ox = new StepInParamDef
		{
			Key = "resultType",
			Name = "结果类型",
			Description = "Http请求的结果类型",
			DefaultValue = "Text",
			Type = VarType.Enum,
			IsRequired = true,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("Text", "文本"),
				new SelectionItem("Image", "图片"),
				new SelectionItem("File", "文件")
			},
			VariableMode = ParamVariableMode.Input,
			IsControlField = false
		};
		sOmtlHpE9j0 = new StepInParamDef
		{
			Key = "header",
			Name = "请求头",
			DefaultValue = "",
			Description = "发送的HttpHeader。每行一个header，格式为Name:Value",
			IsRequired = false,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true
		};
		Wogtl1eFQT1 = new StepInParamDef
		{
			Key = "cookie",
			Name = "Cookie",
			DefaultValue = "",
			Description = "请求的cookie内容",
			IsRequired = false,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = false
		};
		JAltlbqBDtv = new StepInParamDef
		{
			Key = "bodyType",
			Name = "请求体类型",
			Description = "Http 请求体的内容",
			DefaultValue = "JSON",
			Type = VarType.Enum,
			IsRequired = true,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("JSON"),
				new SelectionItem("FORM", "文本表单"),
				new SelectionItem("FILE", "MultiPart表单"),
				new SelectionItem("BinaryFile", "单个文件或图片变量（二进制）"),
				new SelectionItem("Text", "纯文本")
			},
			VariableMode = ParamVariableMode.Input,
			InvalidForList = new string[3] { "GET", "HEAD", "OPTIONS" }
		};
		w0Atl6l2Gq5 = new StepInParamDef
		{
			Key = "body",
			Name = "请求体",
			DefaultValue = "",
			Description = "Http 请求 BODY。格式要求详见模块帮助。",
			IsRequired = false,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true,
			InvalidForList = new string[3] { "GET", "HEAD", "OPTIONS" }
		};
		JLCtlXr37Bq = new StepInParamDef
		{
			Key = "contentType",
			Name = "内容类型",
			Description = "选填。上传内容的ContentType，适用于“单个文件或图片变量（二进制）”或“纯文本” 请求体类型。",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			InvalidForList = new string[3] { "GET", "HEAD", "OPTIONS" }
		};
		hirtlmas0Jg = new StepInParamDef
		{
			Key = "noAutoRedirect",
			Name = "禁止重定向",
			DefaultValue = false,
			Description = "是否禁止自动跳转",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		BnNtlKuwmGD = new StepInParamDef
		{
			Key = "forceProxy",
			Name = "强制使用代理",
			DefaultValue = false,
			Description = "即使系统设置中未启用代理，本步骤仍然使用代理访问。",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		XY4tlxoR900 = new StepInParamDef
		{
			Key = "skipCertVerify",
			Name = "忽略HTTPS证书验证",
			DefaultValue = false,
			Description = "",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		QLetlrY4MrL = new StepInParamDef
		{
			Key = "showProgress",
			Name = "显示进度条",
			DefaultValue = false,
			Description = "是否显示上传下载进度条",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		mkgtlpdCkEy = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		hUgtlBCSyns = new StepInParamDef
		{
			Key = "ua",
			Name = "UserAgent",
			DefaultValue = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Safari/537.36",
			Description = "",
			Type = VarType.Text,
			IsMultiLine = false,
			VariableMode = ParamVariableMode.Input
		};
		KuBtlQDbTAJ = new StepInParamDef
		{
			Key = "expireSeconds",
			Name = "超时时间",
			Description = "请求超时时间（秒数）",
			Type = VarType.Number,
			DefaultValue = 100,
			VariableMode = ParamVariableMode.Input
		};
		aEktljUnTJ6 = new StepInParamDef
		{
			Key = "useSSE",
			Name = "启用SSE流式响应",
			DefaultValue = false,
			Description = "调用AI接口时使用，通过子程序处理接收到的流式响应内容",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input,
			IsAdvanced = true
		};
		uDhtlnej2Zi = new StepInParamDef
		{
			Key = "sseSpName",
			Name = "SSE流式响应处理子程序",
			DefaultValue = "",
			Description = "用于处理接收到的流式响应消息，每次收到调用一次，通过data输入变量接收内容。",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.Input,
			IsAdvanced = true
		};
		iNXtl5LEUNy = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "是否操作成功",
			Type = VarType.Boolean
		};
		WwbtlDJJdQX = new StepOutParamDef
		{
			Key = "statusCode",
			Name = "状态码",
			Description = "返回的http请求状态码",
			Type = VarType.Integer
		};
		u2stldFjkUP = new StepOutParamDef
		{
			Key = "respHeaders",
			Name = "响应头",
			Description = "返回的HTTP响应Headers",
			Type = VarType.Dict
		};
		Q2AtloaMwJJ = new StepOutParamDef
		{
			Key = "respCookies",
			Name = "响应Cookies",
			Description = "返回的Cookies",
			Type = VarType.Dict
		};
		e3QtlTvVQHj = new StepOutParamDef
		{
			Key = "content",
			Name = "文本结果",
			Description = "返回的文本内容",
			Type = VarType.Text
		};
		BWBtlMJOBpq = new StepOutParamDef
		{
			Key = "imgResult",
			Name = "图片结果",
			Description = "返回的图片内容",
			Type = VarType.Image
		};
	}

	internal static bool J8Mw5YQ5jWtjvFBhxTRo()
	{
		return DCQM2TQ5e3bdE22TK75g == null;
	}
}
