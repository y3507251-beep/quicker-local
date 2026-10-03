using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml;
using System.Xml.XPath;

namespace QCloud.COS;

public sealed class Client
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec yEMv7vwRVjF;

		public static Func<byte, string> N6Zv7S3qcxR;

		public static Func<byte, string> Sskv72u30fv;

		public static Func<KeyValuePair<string, string>, string> e6Lv7uayPKa;

		public static Func<KeyValuePair<string, IEnumerable<string>>, KeyValuePair<string, string>> nBnv7NCuaBD;

		public static Func<KeyValuePair<string, string>, string> v6Cv7J6lAyU;

		public static Func<KeyValuePair<string, string>, string> tQNv70PMPpY;

		public static Func<KeyValuePair<string, string>, string> J5Vv7CbmmxI;

		public static Func<KeyValuePair<string, string>, string> STFv7PtEpI8;

		public static Func<KeyValuePair<string, string>, string> sNZv7EYWw4v;

		public static Func<KeyValuePair<string, string>, string> kDnv7yuB0qs;

		internal static _003C_003Ec vndwy1cvtcDe8oOxRbr6;

		static _003C_003Ec()
		{
			yEMv7vwRVjF = new _003C_003Ec();
		}

		internal string QuuvaUk0Jwx(byte k)
		{
			return k.ToString("x2");
		}

		internal string WTkvalDCR8D(byte k)
		{
			return k.ToString("x2");
		}

		internal string oIVvaiQpI3t(KeyValuePair<string, string> k)
		{
			return k.Key;
		}

		internal KeyValuePair<string, string> Tbjva3JuCme(KeyValuePair<string, IEnumerable<string>> k)
		{
			return new KeyValuePair<string, string>(k.Key.ToLower(), Uri.EscapeDataString(k.Value.First()).ToLower());
		}

		internal string AXRvafq77yc(KeyValuePair<string, string> k)
		{
			return k.Key;
		}

		internal string aYtvazKrcgv(KeyValuePair<string, string> k)
		{
			return k.Key + "=" + k.Value;
		}

		internal string eIKv7wwMT3o(KeyValuePair<string, string> k)
		{
			return k.Key + "=" + k.Value;
		}

		internal string o57v7tpaj67(KeyValuePair<string, string> k)
		{
			return k.Key;
		}

		internal string moAv7gc675S(KeyValuePair<string, string> k)
		{
			return k.Key;
		}

		internal string Pwrv7LJ5nto(KeyValuePair<string, string> k)
		{
			return k.Key + "=" + k.Value;
		}

		internal static bool qmtfTKcvSQk0fViUi9JY()
		{
			return vndwy1cvtcDe8oOxRbr6 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass13_0
	{
		public NameValueCollection VAJv7aEpQJO;

		private static _003C_003Ec__DisplayClass13_0 ycjj0acvTR0yXtDc6bVV;

		internal KeyValuePair<string, string> V2tv78V6itk(string k)
		{
			return new KeyValuePair<string, string>(k.ToLower(), VAJv7aEpQJO[k].ToLower());
		}

		internal static bool YQPTcqcvmKayFAvPOeiR()
		{
			return ycjj0acvTR0yXtDc6bVV == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDeleteBucketAsync_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Client _003C_003E4__this;

		public string name;

		public string region;

		private HttpResponseMessage _003Cresp_003E5__2;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		private HttpMethod _003C_003E7__wrap2;

		private HttpStatusCode _003C_003E7__wrap3;

		private TaskAwaiter<string> _003C_003Eu__2;

		internal static object tLpxNOcvCO7FESA2RVf8;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			Client client = _003C_003E4__this;
			try
			{
				if (num != 0)
				{
					if (num == 1)
					{
						goto IL_00d7;
					}
					if (tLpxNOcvCO7FESA2RVf8 == null)
					{
						goto IL_0052;
					}
					switch (1)
					{
					case 1:
						goto IL_0052;
					}
				}
				TaskAwaiter<HttpResponseMessage> awaiter = _003C_003Eu__1;
				_003C_003Eu__1 = default(TaskAwaiter<HttpResponseMessage>);
				num = -1;
				_003C_003E1__state = -1;
				goto IL_00c7;
				IL_0052:
				string requestUri = new Bucket(client.EhUeL41Tud.AppId, name, region).Url + "/";
				HttpRequestMessage httpRequestMessage_ = new HttpRequestMessage(HttpMethod.Delete, requestUri);
				awaiter = client.pYfet5fdwx(httpRequestMessage_).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = 0;
					_003C_003E1__state = 0;
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_00c7;
				IL_00c7:
				HttpResponseMessage result = awaiter.GetResult();
				_003Cresp_003E5__2 = result;
				goto IL_00d7;
				IL_00d7:
				try
				{
        string result2 = default;
					TaskAwaiter<string> awaiter2;
					if (num == 1)
					{
						awaiter2 = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter<string>);
						num = -1;
						_003C_003E1__state = -1;
						goto IL_0168;
					}
					HttpStatusCode statusCode = _003Cresp_003E5__2.StatusCode;
					int num2;
					if (statusCode != HttpStatusCode.OK && statusCode != HttpStatusCode.NoContent)
					{
						_003C_003E7__wrap2 = HttpMethod.Delete;
						_003C_003E7__wrap3 = _003Cresp_003E5__2.StatusCode;
						awaiter2 = _003Cresp_003E5__2.Content.ReadAsStringAsync().GetAwaiter();
						if (awaiter2.IsCompleted)
						{
							goto IL_0168;
						}
						num2 = 0;
						if (tLpxNOcvCO7FESA2RVf8 == null)
						{
							goto IL_0180;
						}
						goto IL_018d;
					}
					goto end_IL_00d7;
					IL_0168:
					result2 = awaiter2.GetResult();
					num2 = 1;
					if (!x8J9cKcv7QvErFxlFhxk())
					{
						int num3 = default(int);
						num2 = num3;
					}
					goto IL_0180;
					IL_0180:
					switch (num2)
					{
					case 1:
						client.JgLh3FHMeL(_003C_003E7__wrap2, _003C_003E7__wrap3, result2);
						_003C_003E7__wrap2 = null;
						goto end_IL_00d7;
					}
					goto IL_018d;
					IL_018d:
					num = 1;
					_003C_003E1__state = 1;
					_003C_003Eu__2 = awaiter2;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
					return;
					end_IL_00d7:;
				}
				finally
				{
					if (num < 0 && _003Cresp_003E5__2 != null)
					{
						((IDisposable)_003Cresp_003E5__2).Dispose();
					}
				}
				_003Cresp_003E5__2 = null;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
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

		internal static bool x8J9cKcv7QvErFxlFhxk()
		{
			return tLpxNOcvCO7FESA2RVf8 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDeleteObjectAsync_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public string url;

		public Client _003C_003E4__this;

		private HttpResponseMessage _003Cresp_003E5__2;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		private HttpMethod _003C_003E7__wrap2;

		private HttpStatusCode _003C_003E7__wrap3;

		private TaskAwaiter<string> _003C_003Eu__2;

		private static object VWLC3KcvHmnwKdMUZtun;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			Client client = _003C_003E4__this;
			try
			{
				TaskAwaiter<HttpResponseMessage> awaiter;
				if (num != 0)
				{
					if (num == 1)
					{
						goto IL_008d;
					}
					HttpRequestMessage httpRequestMessage_ = new HttpRequestMessage(HttpMethod.Delete, url);
					awaiter = client.pYfet5fdwx(httpRequestMessage_).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<HttpResponseMessage>);
					num = -1;
					_003C_003E1__state = -1;
				}
				HttpResponseMessage result = awaiter.GetResult();
				_003Cresp_003E5__2 = result;
				goto IL_008d;
				IL_008d:
				try
				{
					TaskAwaiter<string> awaiter2;
					if (num == 1)
					{
						awaiter2 = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter<string>);
						num = -1;
						_003C_003E1__state = -1;
						goto IL_0163;
					}
					HttpStatusCode statusCode = _003Cresp_003E5__2.StatusCode;
					int num2;
					if (statusCode != HttpStatusCode.OK && statusCode != HttpStatusCode.NoContent)
					{
						_003C_003E7__wrap2 = HttpMethod.Put;
						_003C_003E7__wrap3 = _003Cresp_003E5__2.StatusCode;
						awaiter2 = _003Cresp_003E5__2.Content.ReadAsStringAsync().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 1;
							_003C_003E1__state = 1;
							_003C_003Eu__2 = awaiter2;
							num2 = 0;
							if (!FQmV4rcvzMqoE6Wkdu4t())
							{
								goto IL_0130;
							}
							goto IL_0132;
						}
						goto IL_0163;
					}
					goto end_IL_008d;
					IL_0163:
					string result2 = awaiter2.GetResult();
					client.JgLh3FHMeL(_003C_003E7__wrap2, _003C_003E7__wrap3, result2);
					_003C_003E7__wrap2 = null;
					goto end_IL_008d;
					IL_0130:
					int num3 = default(int);
					num2 = num3;
					goto IL_0132;
					IL_0132:
					do
					{
						switch (num2)
						{
						case 1:
							return;
						}
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						num2 = 1;
					}
					while (VWLC3KcvHmnwKdMUZtun == null);
					goto IL_0130;
					end_IL_008d:;
				}
				finally
				{
					if (num < 0 && _003Cresp_003E5__2 != null)
					{
						((IDisposable)_003Cresp_003E5__2).Dispose();
					}
				}
				_003Cresp_003E5__2 = null;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
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

		internal static bool FQmV4rcvzMqoE6Wkdu4t()
		{
			return VWLC3KcvHmnwKdMUZtun == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetObjectAsync_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Stream> _003C_003Et__builder;

		public string url;

		public Client _003C_003E4__this;

		private HttpResponseMessage _003Cresp_003E5__2;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		private HttpMethod _003C_003E7__wrap2;

		private HttpStatusCode _003C_003E7__wrap3;

		private TaskAwaiter<string> _003C_003Eu__2;

		private TaskAwaiter<Stream> _003C_003Eu__3;

		internal static object Jrsl6dcdQTFwWkPDIqCK;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			Client client = _003C_003E4__this;
			Stream result3;
			try
			{
				TaskAwaiter<HttpResponseMessage> awaiter3;
				TaskAwaiter<string> awaiter2;
				TaskAwaiter<Stream> awaiter = default(TaskAwaiter<Stream>);
				string result = default(string);
				HttpResponseMessage result2;
				switch (num)
				{
				default:
				{
					HttpRequestMessage httpRequestMessage_ = new HttpRequestMessage(HttpMethod.Get, url);
					awaiter3 = client.pYfet5fdwx(httpRequestMessage_).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter3;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
						return;
					}
					goto IL_0091;
				}
				case 0:
					awaiter3 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<HttpResponseMessage>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_0091;
				case 1:
				{
					int num3 = default(int);
					while (true)
					{
						awaiter2 = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter<string>);
						int num2 = 1;
						if (!Wup1q9cdFbKHVlvYG5Yu())
						{
							num2 = num3;
						}
						switch (num2)
						{
						case 1:
							goto end_IL_0118;
						case 2:
							goto IL_0169;
						case 3:
							goto IL_01db;
						}
						continue;
						end_IL_0118:
						break;
					}
					num = -1;
					_003C_003E1__state = -1;
					goto IL_0160;
				}
				case 2:
					{
						awaiter = _003C_003Eu__3;
						_003C_003Eu__3 = default(TaskAwaiter<Stream>);
						goto IL_01db;
					}
					IL_01db:
					num = -1;
					_003C_003E1__state = -1;
					break;
					IL_0185:
					awaiter = _003Cresp_003E5__2.Content.ReadAsStreamAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 2;
						_003C_003E1__state = 2;
						_003C_003Eu__3 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					break;
					IL_0160:
					result = awaiter2.GetResult();
					goto IL_0169;
					IL_0091:
					result2 = awaiter3.GetResult();
					_003Cresp_003E5__2 = result2;
					if (_003Cresp_003E5__2.StatusCode != HttpStatusCode.OK)
					{
						_003C_003E7__wrap2 = HttpMethod.Put;
						_003C_003E7__wrap3 = _003Cresp_003E5__2.StatusCode;
						awaiter2 = _003Cresp_003E5__2.Content.ReadAsStringAsync().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 1;
							_003C_003E1__state = 1;
							_003C_003Eu__2 = awaiter2;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_0160;
					}
					goto IL_0185;
					IL_0169:
					client.JgLh3FHMeL(_003C_003E7__wrap2, _003C_003E7__wrap3, result);
					_003C_003E7__wrap2 = null;
					goto IL_0185;
				}
				result3 = awaiter.GetResult();
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Cresp_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003Cresp_003E5__2 = null;
			_003C_003Et__builder.SetResult(result3);
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

		internal static bool Wup1q9cdFbKHVlvYG5Yu()
		{
			return Jrsl6dcdQTFwWkPDIqCK == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CListBucketsAsync_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Bucket[]> _003C_003Et__builder;

		public Client _003C_003E4__this;

		private HttpResponseMessage _003Cresp_003E5__2;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		private XmlDocument _003Cdoc_003E5__3;

		private HttpMethod _003C_003E7__wrap3;

		private HttpStatusCode _003C_003E7__wrap4;

		private TaskAwaiter<string> _003C_003Eu__2;

		private XmlDocument _003C_003E7__wrap5;

		internal static object MnJSZNcdWCgiPLur7tgd;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			Client client = _003C_003E4__this;
			Bucket[] result3;
			try
			{
				TaskAwaiter<HttpResponseMessage> awaiter;
				if (num != 0)
				{
					if ((uint)(num - 1) <= 1u)
					{
						goto IL_0088;
					}
					HttpRequestMessage httpRequestMessage_ = new HttpRequestMessage(HttpMethod.Get, "https://service.cos.myqcloud.com/");
					awaiter = client.pYfet5fdwx(httpRequestMessage_).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<HttpResponseMessage>);
					num = -1;
					_003C_003E1__state = -1;
					if (MnJSZNcdWCgiPLur7tgd != null)
					{
						switch (0)
						{
						}
					}
				}
				HttpResponseMessage result = awaiter.GetResult();
				_003Cresp_003E5__2 = result;
				goto IL_0088;
				IL_0088:
				try
				{
					TaskAwaiter<string> awaiter2;
					if (num != 1)
					{
						if (num == 2)
						{
							goto IL_0209;
						}
						if (_003Cresp_003E5__2.StatusCode == HttpStatusCode.OK)
						{
							goto IL_0149;
						}
						_003C_003E7__wrap3 = HttpMethod.Get;
						_003C_003E7__wrap4 = _003Cresp_003E5__2.StatusCode;
						awaiter2 = _003Cresp_003E5__2.Content.ReadAsStringAsync().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 1;
							_003C_003E1__state = 1;
							_003C_003Eu__2 = awaiter2;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter<string>);
						num = -1;
						_003C_003E1__state = -1;
					}
					string result2 = awaiter2.GetResult();
					client.JgLh3FHMeL(_003C_003E7__wrap3, _003C_003E7__wrap4, result2);
					_003C_003E7__wrap3 = null;
					goto IL_0149;
					IL_0149:
					_003Cdoc_003E5__3 = new XmlDocument();
					_003C_003E7__wrap5 = _003Cdoc_003E5__3;
					awaiter2 = _003Cresp_003E5__2.Content.ReadAsStringAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = 2;
						_003C_003E1__state = 2;
						_003C_003Eu__2 = awaiter2;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_01a4;
					IL_0209:
					awaiter2 = _003C_003Eu__2;
					_003C_003Eu__2 = default(TaskAwaiter<string>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_01a4;
					IL_01a4:
					int num3 = default(int);
					while (true)
					{
						result2 = awaiter2.GetResult();
						_003C_003E7__wrap5.LoadXml(result2);
						_003C_003E7__wrap5 = null;
						List<Bucket> list = new List<Bucket>();
						IEnumerator enumerator = _003Cdoc_003E5__3.DocumentElement.CreateNavigator().Select("//Buckets/Bucket").GetEnumerator();
						int num2 = 1;
						if (!ecjCiUcdyOB9PiYa1YOU())
						{
							num2 = num3;
						}
						switch (num2)
						{
						case 2:
							continue;
						case 1:
							try
							{
								while (enumerator.MoveNext())
								{
									XPathNavigator xPathNavigator = (XPathNavigator)enumerator.Current;
									string innerXml = xPathNavigator.SelectSingleNode("Name").InnerXml;
									int num4 = innerXml.LastIndexOf("-");
									Bucket item = new Bucket(innerXml.Substring(num4 + 1), innerXml.Substring(0, num4), xPathNavigator.SelectSingleNode("Location").InnerXml);
									list.Add(item);
								}
							}
							finally
							{
								if (num < 0 && enumerator is IDisposable disposable)
								{
									disposable.Dispose();
								}
							}
							result3 = list.ToArray();
							goto end_IL_01a4;
						}
						goto IL_0209;
						continue;
						end_IL_01a4:
						break;
					}
				}
				finally
				{
					if (num < 0 && _003Cresp_003E5__2 != null)
					{
						((IDisposable)_003Cresp_003E5__2).Dispose();
					}
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result3);
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

		internal static bool ecjCiUcdyOB9PiYa1YOU()
		{
			return MnJSZNcdWCgiPLur7tgd == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CPutBucketAsync_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Bucket> _003C_003Et__builder;

		public Client _003C_003E4__this;

		public string name;

		public string region;

		public Dictionary<string, string> headers;

		private Bucket _003Cbucket_003E5__2;

		private HttpResponseMessage _003Cresp_003E5__3;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		private TaskAwaiter<string> _003C_003Eu__2;

		private HttpMethod _003C_003E7__wrap3;

		private HttpStatusCode _003C_003E7__wrap4;

		private static object VndKtjcdnOhreJx7TeTw;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			Client client = _003C_003E4__this;
			Bucket result3;
			try
			{
				HttpRequestMessage httpRequestMessage = default(HttpRequestMessage);
				int num2;
				if (num != 0)
				{
					if ((uint)(num - 1) > 1u)
					{
						_003Cbucket_003E5__2 = new Bucket(client.EhUeL41Tud.AppId, name, region);
						string requestUri = _003Cbucket_003E5__2.Url + "/";
						httpRequestMessage = new HttpRequestMessage(HttpMethod.Put, requestUri);
						num2 = 0;
						if (xVYlwgcdefGyxuGGGGTe())
						{
							goto IL_0091;
						}
						goto IL_009e;
					}
					goto IL_0141;
				}
				TaskAwaiter<HttpResponseMessage> awaiter = _003C_003Eu__1;
				_003C_003Eu__1 = default(TaskAwaiter<HttpResponseMessage>);
				num = -1;
				_003C_003E1__state = -1;
				goto IL_011f;
				IL_0091:
				switch (num2)
				{
				case 1:
					goto IL_0141;
				}
				goto IL_009e;
				IL_011f:
				HttpResponseMessage result = awaiter.GetResult();
				_003Cresp_003E5__3 = result;
				num2 = 1;
				if (xVYlwgcdefGyxuGGGGTe())
				{
					goto IL_0091;
				}
				goto IL_0141;
				IL_0141:
				try
				{
					int num3;
					TaskAwaiter<string> awaiter2;
					if (num != 1)
					{
						if (num == 2)
						{
							awaiter2 = _003C_003Eu__2;
							num3 = 1;
							if (!xVYlwgcdefGyxuGGGGTe())
							{
								int num4 = default(int);
								num3 = num4;
							}
							goto IL_0242;
						}
						awaiter2 = _003Cresp_003E5__3.Content.ReadAsStringAsync().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 1;
							_003C_003E1__state = 1;
							_003C_003Eu__2 = awaiter2;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter<string>);
						num = -1;
						_003C_003E1__state = -1;
					}
					awaiter2.GetResult();
					if (_003Cresp_003E5__3.StatusCode != HttpStatusCode.OK)
					{
						_003C_003E7__wrap3 = HttpMethod.Put;
						_003C_003E7__wrap4 = _003Cresp_003E5__3.StatusCode;
						awaiter2 = _003Cresp_003E5__3.Content.ReadAsStringAsync().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 2;
							_003C_003E1__state = 2;
							_003C_003Eu__2 = awaiter2;
							num3 = 0;
							if (VndKtjcdnOhreJx7TeTw == null)
							{
								goto IL_0242;
							}
							goto IL_0253;
						}
						goto IL_027b;
					}
					goto IL_029f;
					IL_027b:
					string result2 = awaiter2.GetResult();
					client.JgLh3FHMeL(_003C_003E7__wrap3, _003C_003E7__wrap4, result2);
					_003C_003E7__wrap3 = null;
					goto IL_029f;
					IL_029f:
					result3 = _003Cbucket_003E5__2;
					goto end_IL_0141;
					IL_0242:
					switch (num3)
					{
					case 1:
						_003C_003Eu__2 = default(TaskAwaiter<string>);
						goto case 2;
					case 2:
						num = -1;
						_003C_003E1__state = -1;
						goto IL_027b;
					}
					goto IL_0253;
					IL_0253:
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
					return;
					end_IL_0141:;
				}
				finally
				{
					if (num < 0 && _003Cresp_003E5__3 != null)
					{
						((IDisposable)_003Cresp_003E5__3).Dispose();
					}
				}
				goto end_IL_000e;
				IL_009e:
				Dictionary<string, string> dictionary = headers;
				if (dictionary != null && dictionary.Count > 0)
				{
					Dictionary<string, string>.Enumerator enumerator = headers.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							KeyValuePair<string, string> current = enumerator.Current;
							httpRequestMessage.Headers.TryAddWithoutValidation(current.Key, current.Value);
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
						}
					}
				}
				awaiter = client.pYfet5fdwx(httpRequestMessage).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = 0;
					_003C_003E1__state = 0;
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_011f;
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Cbucket_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003Cbucket_003E5__2 = null;
			_003C_003Et__builder.SetResult(result3);
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

		internal static bool xVYlwgcdefGyxuGGGGTe()
		{
			return VndKtjcdnOhreJx7TeTw == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CPutObjectAsync_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Stream stream;

		public string contentType;

		public string charset;

		public string url;

		public IDictionary<string, string> headers;

		public Client _003C_003E4__this;

		private HttpResponseMessage _003Cresp_003E5__2;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		private HttpMethod _003C_003E7__wrap2;

		private HttpStatusCode _003C_003E7__wrap3;

		private TaskAwaiter<string> _003C_003Eu__2;

		internal static object a3AF2tcd3RxHu896ZFms;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			Client client = _003C_003E4__this;
			try
			{
				TaskAwaiter<HttpResponseMessage> awaiter;
				int num2;
				if (num != 0)
				{
					if (num == 1)
					{
						goto IL_014f;
					}
					if (stream == null)
					{
						throw new ArgumentNullException("content");
					}
					StreamContent streamContent = new StreamContent(stream);
					streamContent.Headers.ContentType = new MediaTypeHeaderValue(contentType)
					{
						CharSet = charset
					};
					HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Put, url)
					{
						Content = streamContent
					};
					IDictionary<string, string> dictionary = headers;
					if (dictionary != null && dictionary.Count > 0)
					{
						IEnumerator<KeyValuePair<string, string>> enumerator = headers.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								KeyValuePair<string, string> current = enumerator.Current;
								httpRequestMessage.Headers.TryAddWithoutValidation(current.Key, current.Value);
							}
						}
						finally
						{
							if (num < 0)
							{
								enumerator?.Dispose();
							}
						}
					}
					awaiter = client.pYfet5fdwx(httpRequestMessage).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num2 = 1;
						if (!SxYi82cdECjZlN2thvBq())
						{
							goto IL_015c;
						}
						goto IL_015d;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<HttpResponseMessage>);
					num = -1;
					_003C_003E1__state = -1;
				}
				HttpResponseMessage result = awaiter.GetResult();
				_003Cresp_003E5__2 = result;
				goto IL_014f;
				IL_015d:
				switch (num2)
				{
				default:
					try
					{
						TaskAwaiter<string> awaiter2;
						if (num == 1)
						{
							awaiter2 = _003C_003Eu__2;
							_003C_003Eu__2 = default(TaskAwaiter<string>);
							num = -1;
							_003C_003E1__state = -1;
							goto IL_021c;
						}
						if (_003Cresp_003E5__2.StatusCode != HttpStatusCode.OK)
						{
							_003C_003E7__wrap2 = HttpMethod.Put;
							_003C_003E7__wrap3 = _003Cresp_003E5__2.StatusCode;
							if (SxYi82cdECjZlN2thvBq())
							{
								switch (0)
								{
								}
							}
							awaiter2 = _003Cresp_003E5__2.Content.ReadAsStringAsync().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = 1;
								_003C_003E1__state = 1;
								_003C_003Eu__2 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_021c;
						}
						goto end_IL_016b;
						IL_021c:
						string result2 = awaiter2.GetResult();
						client.JgLh3FHMeL(_003C_003E7__wrap2, _003C_003E7__wrap3, result2);
						_003C_003E7__wrap2 = null;
						end_IL_016b:;
					}
					finally
					{
						if (num < 0 && _003Cresp_003E5__2 != null)
						{
							((IDisposable)_003Cresp_003E5__2).Dispose();
						}
					}
					_003Cresp_003E5__2 = null;
					break;
				case 1:
					return;
				}
				goto end_IL_000e;
				IL_015c:
				int num3 = default(int);
				num2 = num3;
				goto IL_015d;
				IL_014f:
				num2 = 0;
				if (a3AF2tcd3RxHu896ZFms != null)
				{
					goto IL_015c;
				}
				goto IL_015d;
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
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

		internal static bool SxYi82cdECjZlN2thvBq()
		{
			return a3AF2tcd3RxHu896ZFms == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSendAsync_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<HttpResponseMessage> _003C_003Et__builder;

		public HttpRequestMessage req;

		public Client _003C_003E4__this;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		private static object RxY86wcdBOWA2OeLrPMS;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			Client client = _003C_003E4__this;
			HttpResponseMessage result;
			try
			{
				TaskAwaiter<HttpResponseMessage> awaiter;
				if (num != 0)
				{
					int num2 = 0;
					if (RxY86wcdBOWA2OeLrPMS != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
					req.Headers.Host = req.RequestUri.Host;
					req.Headers.TryAddWithoutValidation("Authorization", client.xFSewM2evd(req));
					awaiter = client.LQTegQKUOZ.SendAsync(req).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<HttpResponseMessage>);
					num = -1;
					_003C_003E1__state = -1;
				}
				result = awaiter.GetResult();
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result);
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

		internal static bool QPa2WHcdvX2nsbGqpmXS()
		{
			return RxY86wcdBOWA2OeLrPMS == null;
		}
	}

	private readonly HttpClient LQTegQKUOZ;

	private readonly AppSettings EhUeL41Tud;

	internal static Client yZdtZM9ZNPBgARoNWiF;

	private Client()
	{
	}

	public Client(AppSettings conf, HttpClient backChannel = null)
	{
		EhUeL41Tud = conf;
		LQTegQKUOZ = backChannel ?? new HttpClient();
	}

	[AsyncStateMachine(typeof(_003CListBucketsAsync_003Ed__4))]
	public Task<Bucket[]> ListBucketsAsync()
	{
		_003CListBucketsAsync_003Ed__4 stateMachine = default(_003CListBucketsAsync_003Ed__4);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Bucket[]>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CPutBucketAsync_003Ed__5))]
	public Task<Bucket> PutBucketAsync(string name, string region, Dictionary<string, string> headers = null)
	{
		_003CPutBucketAsync_003Ed__5 stateMachine = default(_003CPutBucketAsync_003Ed__5);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Bucket>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.name = name;
		stateMachine.region = region;
		stateMachine.headers = headers;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CDeleteBucketAsync_003Ed__6))]
	public Task DeleteBucketAsync(string name, string region)
	{
		_003CDeleteBucketAsync_003Ed__6 stateMachine = default(_003CDeleteBucketAsync_003Ed__6);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.name = name;
		stateMachine.region = region;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CPutObjectAsync_003Ed__7))]
	public Task PutObjectAsync(string url, Stream stream, string contentType, string charset, IDictionary<string, string> headers = null)
	{
		_003CPutObjectAsync_003Ed__7 stateMachine = default(_003CPutObjectAsync_003Ed__7);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.url = url;
		stateMachine.stream = stream;
		stateMachine.contentType = contentType;
		stateMachine.charset = charset;
		stateMachine.headers = headers;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CGetObjectAsync_003Ed__8))]
	public Task<Stream> GetObjectAsync(string url)
	{
		_003CGetObjectAsync_003Ed__8 stateMachine = default(_003CGetObjectAsync_003Ed__8);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Stream>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.url = url;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CDeleteObjectAsync_003Ed__9))]
	public Task DeleteObjectAsync(string url)
	{
		_003CDeleteObjectAsync_003Ed__9 stateMachine = default(_003CDeleteObjectAsync_003Ed__9);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.url = url;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private void JgLh3FHMeL(HttpMethod httpMethod_0, HttpStatusCode httpStatusCode_0, string string_0)
	{
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(string_0);
		XPathNavigator xPathNavigator = xmlDocument.DocumentElement.CreateNavigator().SelectSingleNode("//Error");
		throw new RequestFailureException(httpMethod_0.ToString(), xPathNavigator.SelectSingleNode("Message").InnerXml)
		{
			HttpStatusCode = (int)httpStatusCode_0,
			ErrorCode = xPathNavigator.SelectSingleNode("Code").InnerXml,
			ResourceURL = xPathNavigator.SelectSingleNode("Resource").InnerXml,
			RequestId = xPathNavigator.SelectSingleNode("RequestId").InnerXml,
			TraceId = xPathNavigator.SelectSingleNode("TraceId").InnerXml
		};
	}

	private static string XKahfDlDXt(string string_0, string string_1)
	{
		return string.Concat(new HMACSHA1(Encoding.UTF8.GetBytes(string_0)).ComputeHash(Encoding.UTF8.GetBytes(string_1)).Select(_003C_003Ec.N6Zv7S3qcxR ?? (_003C_003Ec.N6Zv7S3qcxR = _003C_003Ec.yEMv7vwRVjF.QuuvaUk0Jwx)));
	}

	private static string EFThzVy08u(string string_0)
	{
		return string.Concat(SHA1.Create().ComputeHash(Encoding.UTF8.GetBytes(string_0)).Select(_003C_003Ec.Sskv72u30fv ?? (_003C_003Ec.Sskv72u30fv = _003C_003Ec.yEMv7vwRVjF.WTkvalDCR8D)));
	}

	private string xFSewM2evd(HttpRequestMessage httpRequestMessage_0)
	{
		_003C_003Ec__DisplayClass13_0 _003C_003Ec__DisplayClass13_ = new _003C_003Ec__DisplayClass13_0();
		_003C_003Ec__DisplayClass13_.VAJv7aEpQJO = HttpUtility.ParseQueryString(httpRequestMessage_0.RequestUri.Query);
		IOrderedEnumerable<KeyValuePair<string, string>> source = _003C_003Ec__DisplayClass13_.VAJv7aEpQJO.Cast<string>().Select(_003C_003Ec__DisplayClass13_.V2tv78V6itk).OrderBy(_003C_003Ec.e6Lv7uayPKa ?? (_003C_003Ec.e6Lv7uayPKa = _003C_003Ec.yEMv7vwRVjF.oIVvaiQpI3t));
		IOrderedEnumerable<KeyValuePair<string, string>> source2 = httpRequestMessage_0.Headers.Select(_003C_003Ec.nBnv7NCuaBD ?? (_003C_003Ec.nBnv7NCuaBD = _003C_003Ec.yEMv7vwRVjF.Tbjva3JuCme)).OrderBy(_003C_003Ec.v6Cv7J6lAyU ?? (_003C_003Ec.v6Cv7J6lAyU = _003C_003Ec.yEMv7vwRVjF.AXRvafq77yc));
		string string_ = httpRequestMessage_0.Method.ToString().ToLower() + "\n" + httpRequestMessage_0.RequestUri.LocalPath + "\n" + string.Join("&", source.Select(_003C_003Ec.tQNv70PMPpY ?? (_003C_003Ec.tQNv70PMPpY = _003C_003Ec.yEMv7vwRVjF.aYtvazKrcgv))) + "\n" + string.Join("&", source2.Select(_003C_003Ec.J5Vv7CbmmxI ?? (_003C_003Ec.J5Vv7CbmmxI = _003C_003Ec.yEMv7vwRVjF.eIKv7wwMT3o))) + "\n";
		DateTimeOffset now = DateTimeOffset.Now;
		string text = $"{now.ToUnixTimeSeconds()};{now.AddSeconds(30.0).ToUnixTimeSeconds()}";
		string string_2 = XKahfDlDXt(EhUeL41Tud.SecretKey, text);
		string string_3 = "sha1\n" + text + "\n" + EFThzVy08u(string_) + "\n";
		if (!hLkoLU95EkA4r451I1J())
		{
			switch (0)
			{
			}
		}
		string value = XKahfDlDXt(string_2, string_3);
		Dictionary<string, string> source3 = new Dictionary<string, string>
		{
			{ "q-sign-algorithm", "sha1" },
			{ "q-ak", EhUeL41Tud.SecretId },
			{ "q-sign-time", text },
			{ "q-key-time", text },
			{
				"q-header-list",
				string.Join(";", source2.Select(_003C_003Ec.STFv7PtEpI8 ?? (_003C_003Ec.STFv7PtEpI8 = _003C_003Ec.yEMv7vwRVjF.o57v7tpaj67)))
			},
			{
				"q-url-param-list",
				string.Join(";", source.Select(_003C_003Ec.sNZv7EYWw4v ?? (_003C_003Ec.sNZv7EYWw4v = _003C_003Ec.yEMv7vwRVjF.moAv7gc675S)))
			},
			{ "q-signature", value }
		};
		return string.Join("&", source3.Select(_003C_003Ec.kDnv7yuB0qs ?? (_003C_003Ec.kDnv7yuB0qs = _003C_003Ec.yEMv7vwRVjF.Pwrv7LJ5nto)));
	}

	[AsyncStateMachine(typeof(_003CSendAsync_003Ed__14))]
	private Task<HttpResponseMessage> pYfet5fdwx(HttpRequestMessage httpRequestMessage_0)
	{
		_003CSendAsync_003Ed__14 stateMachine = default(_003CSendAsync_003Ed__14);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<HttpResponseMessage>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.req = httpRequestMessage_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	internal static bool hLkoLU95EkA4r451I1J()
	{
		return yZdtZM9ZNPBgARoNWiF == null;
	}
}
