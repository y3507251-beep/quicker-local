using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Cuiliang.AliyunOssSdk.Request;

public class ServiceCaller
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCallServiceAsync_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<HttpResponseMessage> _003C_003Et__builder;

		public ServiceRequest serviceRequest;

		public ServiceCaller _003C_003E4__this;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		internal static object ppDmfhcewgMTQ9ZP8txp;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ServiceCaller serviceCaller = _003C_003E4__this;
			HttpResponseMessage result;
			try
			{
				HttpRequestMessage httpRequestMessage = default(HttpRequestMessage);
				int num2 = default(int);
				if (num != 0)
				{
					httpRequestMessage = new HttpRequestMessage(serviceRequest.HttpMethod, serviceRequest.BuildRequestUri(serviceCaller.t4u2VxEmye));
					if (serviceCaller.t4u2VxEmye.ClientConfiguration.ConnectionTimeout != -1)
					{
						serviceCaller.x5r2ZvawFh.Timeout = TimeSpan.FromMilliseconds(serviceCaller.t4u2VxEmye.ClientConfiguration.ConnectionTimeout);
					}
					if (!string.IsNullOrWhiteSpace(serviceCaller.t4u2VxEmye.ClientConfiguration.UserAgent))
					{
						serviceCaller.x5r2ZvawFh.DefaultRequestHeaders.UserAgent.TryParseAdd(serviceCaller.t4u2VxEmye.ClientConfiguration.UserAgent);
					}
					if (serviceRequest.RequestContentType != RequestContentType.None && (serviceRequest.HttpMethod == HttpMethod.Put || serviceRequest.HttpMethod == HttpMethod.Post))
					{
						if (serviceRequest.RequestContentType == RequestContentType.String)
						{
							httpRequestMessage.Content = new StringContent(serviceRequest.StringContent, Encoding.UTF8, serviceRequest.ContentMimeType);
						}
						else if (serviceRequest.RequestContentType == RequestContentType.Stream)
						{
							httpRequestMessage.Content = new StreamContent(serviceRequest.StreamContent);
							httpRequestMessage.Content.Headers.ContentType = MediaTypeHeaderValue.Parse(serviceRequest.ContentMimeType);
						}
					}
					if (serviceRequest.ContentMd5 != null && httpRequestMessage.Content != null)
					{
						num2 = 2;
						goto IL_01da;
					}
					goto IL_02f1;
				}
				TaskAwaiter<HttpResponseMessage> awaiter = _003C_003Eu__1;
				_003C_003Eu__1 = default(TaskAwaiter<HttpResponseMessage>);
				num = -1;
				_003C_003E1__state = -1;
				int num3 = 0;
				if (Cbt5ADceTWZZdH26wG20())
				{
					goto IL_01c4;
				}
				goto IL_02e8;
				IL_01da:
				httpRequestMessage.Content.Headers.ContentMD5 = serviceRequest.ContentMd5;
				goto IL_02f1;
				IL_02f1:
				IEnumerator<KeyValuePair<string, string>> enumerator = serviceRequest.Headers.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<string, string> current = enumerator.Current;
						if (!httpRequestMessage.Headers.TryAddWithoutValidation(current.Key, current.Value))
						{
							HttpContent content = httpRequestMessage.Content;
							if (content == null || !content.Headers.TryAddWithoutValidation(current.Key, current.Value))
							{
								throw new InvalidOperationException("不支持的header:" + current.Key);
							}
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
				SignatureHelper.SignRequest(serviceRequest, serviceCaller.t4u2VxEmye.OssCredential, httpRequestMessage);
				awaiter = serviceCaller.x5r2ZvawFh.SendAsync(httpRequestMessage, HttpCompletionOption.ResponseHeadersRead).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = 0;
					_003C_003E1__state = 0;
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					num3 = 1;
					if (ppDmfhcewgMTQ9ZP8txp == null)
					{
						goto IL_01c4;
					}
					goto IL_02e8;
				}
				goto IL_030a;
				IL_030a:
				result = awaiter.GetResult();
				goto end_IL_0010;
				IL_02e8:
				num3 = num2;
				goto IL_01c4;
				IL_01c4:
				switch (num3)
				{
				case 2:
					break;
				case 1:
					return;
				default:
					goto IL_030a;
				}
				goto IL_01da;
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

		internal static bool Cbt5ADceTWZZdH26wG20()
		{
			return ppDmfhcewgMTQ9ZP8txp == null;
		}
	}

	private RequestContext t4u2VxEmye;

	private readonly HttpClient x5r2ZvawFh;

	private static ServiceCaller Jh5CsDeETkosovc4pcE;

	public ServiceCaller(RequestContext requestContext, HttpClient client)
	{
		t4u2VxEmye = requestContext;
		x5r2ZvawFh = client;
	}

	[AsyncStateMachine(typeof(_003CCallServiceAsync_003Ed__3))]
	public Task<HttpResponseMessage> CallServiceAsync(ServiceRequest serviceRequest)
	{
		_003CCallServiceAsync_003Ed__3 stateMachine = default(_003CCallServiceAsync_003Ed__3);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<HttpResponseMessage>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.serviceRequest = serviceRequest;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	internal static bool XJWlTceGT5ahqufphtm()
	{
		return Jh5CsDeETkosovc4pcE == null;
	}
}
