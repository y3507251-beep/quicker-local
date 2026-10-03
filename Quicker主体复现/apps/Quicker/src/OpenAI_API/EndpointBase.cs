using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Authentication;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace OpenAI_API;

public abstract class EndpointBase
{
	internal class q2c9RsdDtjNyjbMVRfG
	{
		[CompilerGenerated]
		private GnLHsNdkxke0TA3wrJ6 Rgyv8AbZSLM;

		internal static q2c9RsdDtjNyjbMVRfG wb6uPEc0dV9rHWMsi8uI;

		[JsonProperty("error")]
		public GnLHsNdkxke0TA3wrJ6 Error
		{
			[CompilerGenerated]
			get
			{
				return Rgyv8AbZSLM;
			}
			[CompilerGenerated]
			set
			{
				Rgyv8AbZSLM = value;
			}
		}

		static q2c9RsdDtjNyjbMVRfG()
		{
		}

		internal static bool wKY74Ic0OE9xSRefh0qt()
		{
			return wb6uPEc0dV9rHWMsi8uI == null;
		}

		internal static void Vi7gfIc0kb5CCWgNhEwT()
		{
		}
	}

	internal class GnLHsNdkxke0TA3wrJ6
	{
		[CompilerGenerated]
		private string MtnvathFQKm;

		[CompilerGenerated]
		private string kArvag1dE4R;

		[CompilerGenerated]
		private string uK9vaLCYaek;

		[CompilerGenerated]
		private string Gp4vav3KVKM;

		internal static GnLHsNdkxke0TA3wrJ6 zWpQCcc0akwuAblwSvWg;

		[JsonProperty("message")]
		public string Message
		{
			[CompilerGenerated]
			get
			{
				return MtnvathFQKm;
			}
			[CompilerGenerated]
			set
			{
				MtnvathFQKm = value;
			}
		}

		[JsonProperty("type")]
		public string ErrorType
		{
			[CompilerGenerated]
			get
			{
				return kArvag1dE4R;
			}
			[CompilerGenerated]
			set
			{
				kArvag1dE4R = value;
			}
		}

		[JsonProperty("param")]
		public string Parameter
		{
			[CompilerGenerated]
			get
			{
				return uK9vaLCYaek;
			}
			[CompilerGenerated]
			set
			{
				uK9vaLCYaek = value;
			}
		}

		[JsonProperty("code")]
		public string cEpvaw5e22t
		{
			[CompilerGenerated]
			get
			{
				return Gp4vav3KVKM;
			}
			[CompilerGenerated]
			set
			{
				Gp4vav3KVKM = value;
			}
		}

		internal static bool ce8rdDc0rUGXDrhJ7xAc()
		{
			return zWpQCcc0akwuAblwSvWg == null;
		}

		internal static void wAH1NMc098M3VVh0Euwj()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CHttpDelete_003Ed__16<T> : IAsyncStateMachine where T : ApiResultBase
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

		public EndpointBase _003C_003E4__this;

		public string url;

		public object postData;

		private TaskAwaiter<T> _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			EndpointBase endpointBase = _003C_003E4__this;
			T result;
			try
			{
				TaskAwaiter<T> awaiter;
				if (num != 0)
				{
					awaiter = endpointBase.MK5qLGATgd<T>(url, HttpMethod.Delete, postData).GetAwaiter();
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
					_003C_003Eu__1 = default(TaskAwaiter<T>);
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
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CHttpGet_003Ed__14<T> : IAsyncStateMachine where T : ApiResultBase
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

		public EndpointBase _003C_003E4__this;

		public string url;

		private TaskAwaiter<T> _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			EndpointBase endpointBase = _003C_003E4__this;
			T result;
			try
			{
				TaskAwaiter<T> awaiter;
				if (num != 0)
				{
					awaiter = endpointBase.MK5qLGATgd<T>(url, HttpMethod.Get).GetAwaiter();
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
					_003C_003Eu__1 = default(TaskAwaiter<T>);
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
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CHttpGetContent_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public EndpointBase _003C_003E4__this;

		public string url;

		public HttpMethod verb;

		public object postData;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		private TaskAwaiter<string> _003C_003Eu__2;

		internal static object m3SXOac0isSmnCAVHUWc;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			EndpointBase endpointBase = _003C_003E4__this;
			string result;
			try
			{
				TaskAwaiter<string> awaiter;
				TaskAwaiter<HttpResponseMessage> awaiter2;
				int num2;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter<string>);
						num = -1;
						_003C_003E1__state = -1;
						goto IL_00fe;
					}
					awaiter2 = endpointBase.riCqwroXB0(url, verb, postData).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						num2 = 1;
						if (!JC9gCZc0l9fNPiT5iZO7())
						{
							int num3 = default(int);
							num2 = num3;
						}
						goto IL_00ae;
					}
				}
				else
				{
					awaiter2 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<HttpResponseMessage>);
					num = -1;
					_003C_003E1__state = -1;
					num2 = 0;
					if (!JC9gCZc0l9fNPiT5iZO7())
					{
						goto IL_00ae;
					}
				}
				goto IL_00bb;
				IL_00fe:
				result = awaiter.GetResult();
				goto end_IL_0010;
				IL_00bb:
				awaiter = awaiter2.GetResult().Content.ReadAsStringAsync().GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = 1;
					_003C_003E1__state = 1;
					_003C_003Eu__2 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_00fe;
				IL_00ae:
				switch (num2)
				{
				case 1:
					_003C_003Eu__1 = awaiter2;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
					return;
				}
				goto IL_00bb;
				end_IL_0010:;
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

		internal static bool JC9gCZc0l9fNPiT5iZO7()
		{
			return m3SXOac0isSmnCAVHUWc == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CHttpPost_003Ed__15<T> : IAsyncStateMachine where T : ApiResultBase
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

		public EndpointBase _003C_003E4__this;

		public string url;

		public object postData;

		public IDictionary<string, object> extraProps;

		private TaskAwaiter<T> _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			EndpointBase endpointBase = _003C_003E4__this;
			T result;
			try
			{
				TaskAwaiter<T> awaiter;
				if (num != 0)
				{
					awaiter = endpointBase.MK5qLGATgd<T>(url, HttpMethod.Post, postData, extraProps).GetAwaiter();
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
					_003C_003Eu__1 = default(TaskAwaiter<T>);
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
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CHttpPut_003Ed__17<T> : IAsyncStateMachine where T : ApiResultBase
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

		public EndpointBase _003C_003E4__this;

		public string url;

		public object postData;

		private TaskAwaiter<T> _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			EndpointBase endpointBase = _003C_003E4__this;
			T result;
			try
			{
				TaskAwaiter<T> awaiter;
				if (num != 0)
				{
					awaiter = endpointBase.MK5qLGATgd<T>(url, HttpMethod.Put, postData).GetAwaiter();
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
					_003C_003Eu__1 = default(TaskAwaiter<T>);
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
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CHttpRequest_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Stream> _003C_003Et__builder;

		public EndpointBase _003C_003E4__this;

		public string url;

		public HttpMethod verb;

		public object postData;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		private TaskAwaiter<Stream> _003C_003Eu__2;

		private static object Ndt6VGc0MuPl1w2ptpXJ;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			EndpointBase endpointBase = _003C_003E4__this;
			Stream result;
			try
			{
				TaskAwaiter<Stream> awaiter;
				TaskAwaiter<HttpResponseMessage> awaiter2;
				int num2;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter<Stream>);
						num = -1;
						_003C_003E1__state = -1;
						goto IL_011f;
					}
					awaiter2 = endpointBase.riCqwroXB0(url, verb, postData).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						num2 = 0;
						if (!fvlkBvc0UakHUIEU53ym())
						{
							int num3 = default(int);
							num2 = num3;
						}
						goto IL_00f8;
					}
				}
				else
				{
					awaiter2 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<HttpResponseMessage>);
					num = -1;
					_003C_003E1__state = -1;
				}
				awaiter = awaiter2.GetResult().Content.ReadAsStreamAsync().GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = 1;
					_003C_003E1__state = 1;
					_003C_003Eu__2 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					num2 = 1;
					if (Ndt6VGc0MuPl1w2ptpXJ == null)
					{
						return;
					}
					goto IL_00f8;
				}
				goto IL_011f;
				IL_00f8:
				switch (num2)
				{
				case 1:
					return;
				}
				_003C_003Eu__1 = awaiter2;
				_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
				return;
				IL_011f:
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

		internal static bool fvlkBvc0UakHUIEU53ym()
		{
			return Ndt6VGc0MuPl1w2ptpXJ == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CHttpRequest_003Ed__13<T> : IAsyncStateMachine where T : ApiResultBase
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

		public EndpointBase _003C_003E4__this;

		public string url;

		public HttpMethod verb;

		public object postData;

		public IDictionary<string, object> extraProps;

		private HttpResponseMessage _003Cresponse_003E5__2;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		private TaskAwaiter<string> _003C_003Eu__2;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			EndpointBase endpointBase = _003C_003E4__this;
			T result3;
			try
			{
				TaskAwaiter<HttpResponseMessage> awaiter;
				TaskAwaiter<string> awaiter2;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<HttpResponseMessage>);
					num = -1;
					_003C_003E1__state = -1;
				}
				else
				{
					if (num == 1)
					{
						awaiter2 = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter<string>);
						num = -1;
						_003C_003E1__state = -1;
						goto IL_00f9;
					}
					awaiter = endpointBase.riCqwroXB0(url, verb, postData, false, extraProps).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				HttpResponseMessage result = awaiter.GetResult();
				_003Cresponse_003E5__2 = result;
				awaiter2 = _003Cresponse_003E5__2.Content.ReadAsStringAsync().GetAwaiter();
				if (!awaiter2.IsCompleted)
				{
					num = 1;
					_003C_003E1__state = 1;
					_003C_003Eu__2 = awaiter2;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
					return;
				}
				goto IL_00f9;
				IL_00f9:
				string result2 = awaiter2.GetResult();
				T val = null;
				try
				{
					val = JsonConvert.DeserializeObject<T>(result2);
					val.RawResponse = result2;
					val.Organization = _003Cresponse_003E5__2.Headers.GetValues("Openai-Organization").FirstOrDefault();
					val.RequestId = _003Cresponse_003E5__2.Headers.GetValues("X-Request-ID").FirstOrDefault();
					val.ProcessingTime = TimeSpan.FromMilliseconds(int.Parse(_003Cresponse_003E5__2.Headers.GetValues("Openai-Processing-Ms").First()));
					val.OpenaiVersion = _003Cresponse_003E5__2.Headers.GetValues("Openai-Version").FirstOrDefault();
					if (string.IsNullOrEmpty(val.Model))
					{
						val.Model = _003Cresponse_003E5__2.Headers.GetValues("Openai-Model").FirstOrDefault();
					}
				}
				catch (Exception)
				{
				}
				result3 = val;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Cresponse_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003Cresponse_003E5__2 = null;
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
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CHttpRequestRaw_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<HttpResponseMessage> _003C_003Et__builder;

		public string url;

		public EndpointBase _003C_003E4__this;

		public HttpMethod verb;

		public object postData;

		public IDictionary<string, object> extraProps;

		public bool streaming;

		private HttpResponseMessage _003Cresponse_003E5__2;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		private TaskAwaiter<string> _003C_003Eu__2;

		private static object ENkRI8c0SAck7WNcQ1EX;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			EndpointBase endpointBase = _003C_003E4__this;
			HttpResponseMessage result2;
			try
			{
				int num2;
				if (num != 0)
				{
					if (num == 1)
					{
						goto IL_0038;
					}
					if (!string.IsNullOrEmpty(url))
					{
						goto IL_0058;
					}
					num2 = 4;
					if (ENkRI8c0SAck7WNcQ1EX != null)
					{
						goto IL_0045;
					}
					goto IL_0090;
				}
				goto IL_01f7;
				IL_01f7:
				TaskAwaiter<HttpResponseMessage> awaiter = _003C_003Eu__1;
				_003C_003Eu__1 = default(TaskAwaiter<HttpResponseMessage>);
				num = -1;
				_003C_003E1__state = -1;
				goto IL_01d4;
				IL_00af:
				HttpRequestMessage httpRequestMessage = new HttpRequestMessage(verb, url);
				if (postData != null)
				{
					if (postData is HttpContent)
					{
						httpRequestMessage.Content = postData as HttpContent;
					}
					else
					{
						string text = "";
						if (extraProps != null && extraProps.Keys.Count != 0)
						{
							JObject jObject = JObject.FromObject(postData);
							IEnumerator<KeyValuePair<string, object>> enumerator = extraProps.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									KeyValuePair<string, object> current = enumerator.Current;
									jObject.Add(current.Key, JToken.FromObject(current.Value));
								}
							}
							finally
							{
								if (num < 0)
								{
									enumerator?.Dispose();
								}
							}
							text = JsonConvert.SerializeObject(jObject, H4aqNlHLTJ);
						}
						else
						{
							text = JsonConvert.SerializeObject(postData, H4aqNlHLTJ);
						}
						StringContent content = new StringContent(text, Encoding.UTF8, "application/json");
						httpRequestMessage.Content = content;
					}
				}
				HttpClient client = default(HttpClient);
				awaiter = client.SendAsync(httpRequestMessage, streaming ? HttpCompletionOption.ResponseHeadersRead : HttpCompletionOption.ResponseContentRead).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = 0;
					_003C_003E1__state = 0;
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_01d4;
				IL_01d4:
				HttpResponseMessage result = awaiter.GetResult();
				_003Cresponse_003E5__2 = result;
				if (!_003Cresponse_003E5__2.IsSuccessStatusCode)
				{
					goto IL_0038;
				}
				result2 = _003Cresponse_003E5__2;
				goto end_IL_0010;
				IL_0045:
				int num3 = default(int);
				num2 = num3;
				goto IL_0090;
				IL_0090:
				switch (num2)
				{
				case 4:
					break;
				case 3:
					goto IL_007a;
				case 1:
					goto IL_00af;
				default:
					goto IL_01f7;
				case 2:
					goto IL_0225;
				}
				url = endpointBase.Url;
				goto IL_0058;
				IL_0225:
				string text2;
				try
				{
					TaskAwaiter<string> awaiter2;
					if (num != 1)
					{
						awaiter2 = _003Cresponse_003E5__2.Content.ReadAsStringAsync().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 1;
							_003C_003E1__state = 1;
							int num4 = 0;
							if (!kMam2hc0wOBdgF9DPsku())
							{
								int num5 = default(int);
								num4 = num5;
							}
							switch (num4)
							{
							}
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
					text2 = awaiter2.GetResult();
				}
				catch (Exception ex)
				{
					text2 = "异常:" + ex.Message;
				}
				if (_003Cresponse_003E5__2.StatusCode == HttpStatusCode.Unauthorized)
				{
					throw new AuthenticationException("认证失败，可能APIKey无效: " + text2);
				}
				if (_003Cresponse_003E5__2.StatusCode == HttpStatusCode.InternalServerError)
				{
					throw new HttpRequestException("服务端内部错误，请重试。" + endpointBase.GetErrorMessage(text2, _003Cresponse_003E5__2, endpointBase.Endpoint, url));
				}
				HttpRequestException ex2 = new HttpRequestException(endpointBase.GetErrorMessage(text2, _003Cresponse_003E5__2, endpointBase.Endpoint, url));
				q2c9RsdDtjNyjbMVRfG q2c9RsdDtjNyjbMVRfG = JsonConvert.DeserializeObject<q2c9RsdDtjNyjbMVRfG>(text2);
				try
				{
					ex2.Data.Add("message", q2c9RsdDtjNyjbMVRfG.Error.Message);
					ex2.Data.Add("type", q2c9RsdDtjNyjbMVRfG.Error.ErrorType);
					ex2.Data.Add("param", q2c9RsdDtjNyjbMVRfG.Error.Parameter);
					ex2.Data.Add("code", q2c9RsdDtjNyjbMVRfG.Error.cEpvaw5e22t);
				}
				catch (Exception inner)
				{
					throw new HttpRequestException(ex2.Message, inner);
				}
				throw ex2;
				IL_0038:
				num2 = 2;
				if (ENkRI8c0SAck7WNcQ1EX != null)
				{
					goto IL_0045;
				}
				goto IL_0090;
				IL_007a:
				_003Cresponse_003E5__2 = null;
				text2 = null;
				num2 = 1;
				if (ENkRI8c0SAck7WNcQ1EX == null)
				{
					goto IL_0090;
				}
				goto IL_00af;
				IL_0058:
				if (verb == null)
				{
					verb = HttpMethod.Get;
				}
				client = endpointBase.GetClient();
				goto IL_007a;
				end_IL_0010:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Cresponse_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003Cresponse_003E5__2 = null;
			_003C_003Et__builder.SetResult(result2);
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

		internal static bool kMam2hc0wOBdgF9DPsku()
		{
			return ENkRI8c0SAck7WNcQ1EX == null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CHttpStreamingRequest_003Ed__18<T> : IAsyncEnumerable<T>, IAsyncEnumerator<T>, IValueTaskSource<bool>, IAsyncStateMachine, IAsyncDisposable, IValueTaskSource where T : ApiResultBase
	{
		public int _003C_003E1__state;

		public AsyncIteratorMethodBuilder _003C_003Et__builder;

		public ManualResetValueTaskSourceCore<bool> _003C_003Ev__promiseOfValueOrEnd;

		private T _003C_003E2__current;

		private bool _003C_003Ew__disposeMode;

		private int _003C_003El__initialThreadId;

		public EndpointBase _003C_003E4__this;

		private string url;

		public string _003C_003E3__url;

		private HttpMethod verb;

		public HttpMethod _003C_003E3__verb;

		private object postData;

		public object _003C_003E3__postData;

		private IDictionary<string, object> extraProps;

		public IDictionary<string, object> _003C_003E3__extraProps;

		private string _003Corganization_003E5__2;

		private string _003CrequestId_003E5__3;

		private TimeSpan _003CprocessingTime_003E5__4;

		private string _003CopenaiVersion_003E5__5;

		private string _003CmodelFromHeaders_003E5__6;

		private string _003CresultAsString_003E5__7;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		private Stream _003Cstream_003E5__8;

		private TaskAwaiter<Stream> _003C_003Eu__2;

		private StreamReader _003Creader_003E5__9;

		private string _003C_003E7__wrap9;

		private TaskAwaiter<string> _003C_003Eu__3;

		private static object AV7tKTc044sRbbdYSZ0r;

		T IAsyncEnumerator<T>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public _003CHttpStreamingRequest_003Ed__18(int _003C_003E1__state)
		{
			_003C_003Et__builder = AsyncIteratorMethodBuilder.Create();
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			EndpointBase endpointBase = _003C_003E4__this;
			try
			{
				TaskAwaiter<HttpResponseMessage> awaiter2;
				TaskAwaiter<Stream> awaiter;
				int num2;
				Stream result;
				HttpResponseMessage result2 = default(HttpResponseMessage);
				switch (num)
				{
				default:
					if (!_003C_003Ew__disposeMode)
					{
						num = -1;
						_003C_003E1__state = -1;
						_003C_003E2__current = null;
						awaiter2 = endpointBase.riCqwroXB0(url, verb, postData, true, extraProps).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter2;
							_003CHttpStreamingRequest_003Ed__18<T> stateMachine = this;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref stateMachine);
							return;
						}
						goto IL_00e4;
					}
					goto end_IL_000e;
				case 0:
					awaiter2 = _003C_003Eu__1;
					goto IL_0104;
				case 1:
					awaiter = _003C_003Eu__2;
					_003C_003Eu__2 = default(TaskAwaiter<Stream>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_0241;
				case -4:
				case 2:
				case 3:
					break;
					IL_00ba:
					num = -1;
					_003C_003E1__state = -1;
					num2 = 0;
					if (!t6kDnQc0hw0YksKuZpS9())
					{
						goto IL_00cf;
					}
					goto IL_00e4;
					IL_0241:
					result = awaiter.GetResult();
					_003Cstream_003E5__8 = result;
					break;
					IL_00e4:
					result2 = awaiter2.GetResult();
					_003Corganization_003E5__2 = null;
					num2 = 1;
					if (NHd6hMc0HTNwqliuqGe6() == null)
					{
						goto IL_00cf;
					}
					goto IL_0113;
					IL_00cf:
					switch (num2)
					{
					case 3:
						break;
					default:
						goto IL_00e4;
					case 2:
						goto IL_0104;
					case 1:
						goto IL_0113;
					}
					goto IL_00ba;
					IL_0113:
					_003CrequestId_003E5__3 = null;
					_003CprocessingTime_003E5__4 = TimeSpan.Zero;
					_003CopenaiVersion_003E5__5 = null;
					_003CmodelFromHeaders_003E5__6 = null;
					try
					{
						_003Corganization_003E5__2 = result2.Headers.GetValues("Openai-Organization").FirstOrDefault();
						_003CrequestId_003E5__3 = result2.Headers.GetValues("X-Request-ID").FirstOrDefault();
						_003CprocessingTime_003E5__4 = TimeSpan.FromMilliseconds(int.Parse(result2.Headers.GetValues("Openai-Processing-Ms").First()));
						_003CopenaiVersion_003E5__5 = result2.Headers.GetValues("Openai-Version").FirstOrDefault();
						_003CmodelFromHeaders_003E5__6 = result2.Headers.GetValues("Openai-Model").FirstOrDefault();
					}
					catch (Exception)
					{
					}
					_003CresultAsString_003E5__7 = "";
					_003C_003E2__current = null;
					awaiter = result2.Content.ReadAsStreamAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 1;
						_003C_003E1__state = 1;
						_003C_003Eu__2 = awaiter;
						_003CHttpStreamingRequest_003Ed__18<T> stateMachine = this;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
						return;
					}
					goto IL_0241;
					IL_0104:
					_003C_003Eu__1 = default(TaskAwaiter<HttpResponseMessage>);
					goto IL_00ba;
				}
				try
				{
					if (num != -4 && (uint)(num - 2) > 1u)
					{
						_003Creader_003E5__9 = new StreamReader(_003Cstream_003E5__8);
					}
					try
					{
        T val = default;
        string value = default;
						int num3;
						TaskAwaiter<string> awaiter3;
						if (num != -4)
						{
							if (num != 2)
							{
								if (num != 3)
								{
									goto IL_03c2;
								}
								awaiter3 = _003C_003Eu__3;
								num3 = 0;
								if (NHd6hMc0HTNwqliuqGe6() != null)
								{
									goto IL_038d;
								}
								goto IL_038f;
							}
							awaiter3 = _003C_003Eu__3;
							_003C_003Eu__3 = default(TaskAwaiter<string>);
							num = -1;
							_003C_003E1__state = -1;
							goto IL_04ef;
						}
						num = -1;
						_003C_003E1__state = -1;
						if (!_003C_003Ew__disposeMode)
						{
							goto IL_03c2;
						}
						goto end_IL_0270;
						IL_04ef:
						string result3 = awaiter3.GetResult();
						value = _003C_003E7__wrap9 + result3;
						_003C_003E7__wrap9 = null;
						val = JsonConvert.DeserializeObject<T>(value);
						goto IL_0517;
						IL_038f:
						switch (num3)
						{
						default:
							_003C_003Eu__3 = default(TaskAwaiter<string>);
							goto case 4;
						case 4:
							num = -1;
							_003C_003E1__state = -1;
							goto IL_02da;
						case 1:
							return;
						case 2:
							break;
						case 3:
							goto IL_04a0;
						}
						goto IL_048f;
						IL_02da:
						if ((value = awaiter3.GetResult()) != null)
						{
							_003CresultAsString_003E5__7 = _003CresultAsString_003E5__7 + value + Environment.NewLine;
							if (value.StartsWith("data:"))
							{
								value = value.Substring("data:".Length);
							}
							value = value.TrimStart();
							if (!(value == "[DONE]"))
							{
								if (value.StartsWith(":") || string.IsNullOrWhiteSpace(value))
								{
									goto IL_03c2;
								}
								val = null;
								try
								{
									val = JsonConvert.DeserializeObject<T>(value);
									val.Organization = _003Corganization_003E5__2;
									val.RequestId = _003CrequestId_003E5__3;
									val.ProcessingTime = _003CprocessingTime_003E5__4;
									val.OpenaiVersion = _003CopenaiVersion_003E5__5;
									if (string.IsNullOrEmpty(val.Model))
									{
										val.Model = _003CmodelFromHeaders_003E5__6;
									}
								}
								catch (Exception)
								{
								}
								goto IL_048f;
							}
							_003C_003Ew__disposeMode = true;
						}
						goto end_IL_0270;
						IL_0517:
						_003C_003E2__current = val;
						num = -4;
						_003C_003E1__state = -4;
						goto end_IL_0253;
						IL_04a0:
						_003C_003E2__current = null;
						awaiter3 = _003Creader_003E5__9.ReadToEndAsync().GetAwaiter();
						_003CHttpStreamingRequest_003Ed__18<T> stateMachine;
						if (!awaiter3.IsCompleted)
						{
							num = 2;
							_003C_003E1__state = 2;
							_003C_003Eu__3 = awaiter3;
							stateMachine = this;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref stateMachine);
							return;
						}
						goto IL_04ef;
						IL_03c2:
						_003C_003E2__current = null;
						awaiter3 = _003Creader_003E5__9.ReadLineAsync().GetAwaiter();
						if (awaiter3.IsCompleted)
						{
							goto IL_02da;
						}
						num = 3;
						_003C_003E1__state = 3;
						_003C_003Eu__3 = awaiter3;
						stateMachine = this;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter3, ref stateMachine);
						num3 = 1;
						if (NHd6hMc0HTNwqliuqGe6() != null)
						{
							goto IL_038d;
						}
						goto IL_038f;
						IL_048f:
						if (val == null)
						{
							_003C_003E7__wrap9 = value;
							goto IL_04a0;
						}
						goto IL_0517;
						IL_038d:
						int num4 = default(int);
						num3 = num4;
						goto IL_038f;
						end_IL_0270:;
					}
					finally
					{
						if (num == -1 && _003Creader_003E5__9 != null)
						{
							((IDisposable)_003Creader_003E5__9).Dispose();
						}
					}
					if (!_003C_003Ew__disposeMode)
					{
						_003Creader_003E5__9 = null;
					}
					goto IL_0572;
					end_IL_0253:;
				}
				finally
				{
					if (num == -1 && _003Cstream_003E5__8 != null)
					{
						((IDisposable)_003Cstream_003E5__8).Dispose();
					}
				}
				goto IL_0689;
				IL_0572:
				if (!_003C_003Ew__disposeMode)
				{
					_003Cstream_003E5__8 = null;
				}
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Corganization_003E5__2 = null;
				if (t6kDnQc0hw0YksKuZpS9())
				{
					switch (0)
					{
					}
				}
				_003CrequestId_003E5__3 = null;
				_003CopenaiVersion_003E5__5 = null;
				_003CmodelFromHeaders_003E5__6 = null;
				_003CresultAsString_003E5__7 = null;
				_003Cstream_003E5__8 = null;
				_003Creader_003E5__9 = null;
				_003C_003E7__wrap9 = null;
				_003C_003E2__current = null;
				_003C_003Et__builder.Complete();
				_003C_003Ev__promiseOfValueOrEnd.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003Corganization_003E5__2 = null;
			_003CrequestId_003E5__3 = null;
			_003CopenaiVersion_003E5__5 = null;
			_003CmodelFromHeaders_003E5__6 = null;
			_003CresultAsString_003E5__7 = null;
			_003Cstream_003E5__8 = null;
			int num5 = 0;
			if (!t6kDnQc0hw0YksKuZpS9())
			{
				int num6 = default(int);
				num5 = num6;
			}
			switch (num5)
			{
			}
			_003Creader_003E5__9 = null;
			_003C_003E7__wrap9 = null;
			_003C_003E2__current = null;
			_003C_003Et__builder.Complete();
			_003C_003Ev__promiseOfValueOrEnd.SetResult(false);
			return;
			IL_0689:
			_003C_003Ev__promiseOfValueOrEnd.SetResult(true);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		[DebuggerHidden]
		IAsyncEnumerator<T> IAsyncEnumerable<T>.GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			_003CHttpStreamingRequest_003Ed__18<T> _003CHttpStreamingRequest_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = -3;
				_003C_003Et__builder = AsyncIteratorMethodBuilder.Create();
				_003C_003Ew__disposeMode = false;
				_003CHttpStreamingRequest_003Ed__ = this;
			}
			else
			{
				_003CHttpStreamingRequest_003Ed__ = new _003CHttpStreamingRequest_003Ed__18<T>(-3)
				{
					_003C_003E4__this = _003C_003E4__this
				};
			}
			_003CHttpStreamingRequest_003Ed__.url = _003C_003E3__url;
			_003CHttpStreamingRequest_003Ed__.verb = _003C_003E3__verb;
			_003CHttpStreamingRequest_003Ed__.postData = _003C_003E3__postData;
			_003CHttpStreamingRequest_003Ed__.extraProps = _003C_003E3__extraProps;
			return _003CHttpStreamingRequest_003Ed__;
		}

		[DebuggerHidden]
		ValueTask<bool> IAsyncEnumerator<T>.MoveNextAsync()
		{
			if (_003C_003E1__state == -2)
			{
				return default(ValueTask<bool>);
			}
			_003C_003Ev__promiseOfValueOrEnd.Reset();
			_003CHttpStreamingRequest_003Ed__18<T> stateMachine = this;
			_003C_003Et__builder.MoveNext(ref stateMachine);
			short version = _003C_003Ev__promiseOfValueOrEnd.Version;
			if (_003C_003Ev__promiseOfValueOrEnd.GetStatus(version) == ValueTaskSourceStatus.Succeeded)
			{
				return new ValueTask<bool>(_003C_003Ev__promiseOfValueOrEnd.GetResult(version));
			}
			return new ValueTask<bool>(this, version);
		}

		[DebuggerHidden]
		bool IValueTaskSource<bool>.GetResult(short token)
		{
			return _003C_003Ev__promiseOfValueOrEnd.GetResult(token);
		}

		[DebuggerHidden]
		ValueTaskSourceStatus IValueTaskSource<bool>.GetStatus(short token)
		{
			return _003C_003Ev__promiseOfValueOrEnd.GetStatus(token);
		}

		[DebuggerHidden]
		void IValueTaskSource<bool>.OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags)
		{
			_003C_003Ev__promiseOfValueOrEnd.OnCompleted(continuation, state, token, flags);
		}

		[DebuggerHidden]
		void IValueTaskSource.GetResult(short token)
		{
			_003C_003Ev__promiseOfValueOrEnd.GetResult(token);
		}

		[DebuggerHidden]
		ValueTaskSourceStatus IValueTaskSource.GetStatus(short token)
		{
			return _003C_003Ev__promiseOfValueOrEnd.GetStatus(token);
		}

		[DebuggerHidden]
		void IValueTaskSource.OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags)
		{
			_003C_003Ev__promiseOfValueOrEnd.OnCompleted(continuation, state, token, flags);
		}

		[DebuggerHidden]
		ValueTask IAsyncDisposable.DisposeAsync()
		{
			if (_003C_003E1__state >= -1)
			{
				throw new NotSupportedException();
			}
			if (_003C_003E1__state == -2)
			{
				return default(ValueTask);
			}
			_003C_003Ew__disposeMode = true;
			_003C_003Ev__promiseOfValueOrEnd.Reset();
			_003CHttpStreamingRequest_003Ed__18<T> stateMachine = this;
			_003C_003Et__builder.MoveNext(ref stateMachine);
			return new ValueTask(this, _003C_003Ev__promiseOfValueOrEnd.Version);
		}

		internal static bool t6kDnQc0hw0YksKuZpS9()
		{
			return AV7tKTc044sRbbdYSZ0r == null;
		}

		internal static object NHd6hMc0HTNwqliuqGe6()
		{
			return AV7tKTc044sRbbdYSZ0r;
		}
	}

	protected readonly OpenAIAPI _Api;

	private static readonly JsonSerializerSettings H4aqNlHLTJ;

	internal static EndpointBase tZqcAyJU6hQeQpjaEo8;

	protected abstract string Endpoint { get; }

	protected string Url => string.Format(_Api.ApiUrlFormat, _Api.ApiVersion, Endpoint);

	internal EndpointBase(OpenAIAPI api)
	{
		_Api = api;
	}

	protected HttpClient GetClient()
	{
		return _Api.HttpClient;
	}

	protected string GetErrorMessage(string resultAsString, HttpResponseMessage response, string name, string description = "")
	{
		return string.Format("接口调用出错： {0} ({1}) HTTP状态码:{2}. 返回内容: {3}", name, description, response.StatusCode, resultAsString ?? "<no content>");
	}

	[AsyncStateMachine(typeof(_003CHttpRequestRaw_003Ed__10))]
	private Task<HttpResponseMessage> riCqwroXB0(string string_0 = null, HttpMethod httpMethod_0 = null, object object_0 = null, bool bool_0 = false, IDictionary<string, object> idictionary_0 = null)
	{
		_003CHttpRequestRaw_003Ed__10 stateMachine = default(_003CHttpRequestRaw_003Ed__10);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<HttpResponseMessage>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.url = string_0;
		stateMachine.verb = httpMethod_0;
		stateMachine.postData = object_0;
		stateMachine.streaming = bool_0;
		stateMachine.extraProps = idictionary_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CHttpGetContent_003Ed__11))]
	internal Task<string> bZVqtfnqdY(string string_0 = null, HttpMethod httpMethod_0 = null, object object_0 = null)
	{
		_003CHttpGetContent_003Ed__11 stateMachine = default(_003CHttpGetContent_003Ed__11);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.url = string_0;
		stateMachine.verb = httpMethod_0;
		stateMachine.postData = object_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CHttpRequest_003Ed__12))]
	internal Task<Stream> GFBqgDhZtW(string string_0 = null, HttpMethod httpMethod_0 = null, object object_0 = null)
	{
		_003CHttpRequest_003Ed__12 stateMachine = default(_003CHttpRequest_003Ed__12);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Stream>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.url = string_0;
		stateMachine.verb = httpMethod_0;
		stateMachine.postData = object_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CHttpRequest_003Ed__13<>))]
	private Task<EX9bViqyAKnFSppQRpq> MK5qLGATgd<EX9bViqyAKnFSppQRpq>(string string_0 = null, HttpMethod httpMethod_0 = null, object object_0 = null, IDictionary<string, object> idictionary_0 = null) where EX9bViqyAKnFSppQRpq : ApiResultBase
	{
		_003CHttpRequest_003Ed__13<EX9bViqyAKnFSppQRpq> stateMachine = default(_003CHttpRequest_003Ed__13<EX9bViqyAKnFSppQRpq>);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EX9bViqyAKnFSppQRpq>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.url = string_0;
		stateMachine.verb = httpMethod_0;
		stateMachine.postData = object_0;
		stateMachine.extraProps = idictionary_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CHttpGet_003Ed__14<>))]
	internal Task<dCEv5pq4mPfgp6RwSQP> voeqvITQWy<dCEv5pq4mPfgp6RwSQP>(string string_0 = null) where dCEv5pq4mPfgp6RwSQP : ApiResultBase
	{
		_003CHttpGet_003Ed__14<dCEv5pq4mPfgp6RwSQP> stateMachine = default(_003CHttpGet_003Ed__14<dCEv5pq4mPfgp6RwSQP>);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<dCEv5pq4mPfgp6RwSQP>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.url = string_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CHttpPost_003Ed__15<>))]
	internal Task<EGUfeQqU9Y1DJphu9U8> xm2qSnuXRK<EGUfeQqU9Y1DJphu9U8>(string string_0 = null, object object_0 = null, IDictionary<string, object> idictionary_0 = null) where EGUfeQqU9Y1DJphu9U8 : ApiResultBase
	{
		_003CHttpPost_003Ed__15<EGUfeQqU9Y1DJphu9U8> stateMachine = default(_003CHttpPost_003Ed__15<EGUfeQqU9Y1DJphu9U8>);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<EGUfeQqU9Y1DJphu9U8>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.url = string_0;
		stateMachine.postData = object_0;
		stateMachine.extraProps = idictionary_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CHttpDelete_003Ed__16<>))]
	internal Task<X81odEqgAV9mZGMvKOX> cbsq2d02C3<X81odEqgAV9mZGMvKOX>(string string_0 = null, object object_0 = null) where X81odEqgAV9mZGMvKOX : ApiResultBase
	{
		_003CHttpDelete_003Ed__16<X81odEqgAV9mZGMvKOX> stateMachine = default(_003CHttpDelete_003Ed__16<X81odEqgAV9mZGMvKOX>);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<X81odEqgAV9mZGMvKOX>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.url = string_0;
		stateMachine.postData = object_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CHttpPut_003Ed__17<>))]
	internal Task<PV8V3nqVSDO3BE5X3ST> zaYquDDwqA<PV8V3nqVSDO3BE5X3ST>(string string_0 = null, object object_0 = null) where PV8V3nqVSDO3BE5X3ST : ApiResultBase
	{
		_003CHttpPut_003Ed__17<PV8V3nqVSDO3BE5X3ST> stateMachine = default(_003CHttpPut_003Ed__17<PV8V3nqVSDO3BE5X3ST>);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<PV8V3nqVSDO3BE5X3ST>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.url = string_0;
		stateMachine.postData = object_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncIteratorStateMachine(typeof(_003CHttpStreamingRequest_003Ed__18<>))]
	protected IAsyncEnumerable<T> HttpStreamingRequest<T>(string url = null, HttpMethod verb = null, object postData = null, IDictionary<string, object> extraProps = null) where T : ApiResultBase
	{
		return new _003CHttpStreamingRequest_003Ed__18<T>(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__url = url,
			_003C_003E3__verb = verb,
			_003C_003E3__postData = postData,
			_003C_003E3__extraProps = extraProps
		};
	}

	static EndpointBase()
	{
		H4aqNlHLTJ = new JsonSerializerSettings
		{
			NullValueHandling = NullValueHandling.Ignore
		};
	}

	internal static void HX2I0eJ61MIR1K1ULFJ()
	{
	}

	internal static bool Mvoe8IJxOtOUWtFROSs()
	{
		return tZqcAyJU6hQeQpjaEo8 == null;
	}

	internal static void Y27oypJthE3kM0fgNyE()
	{
	}
}
