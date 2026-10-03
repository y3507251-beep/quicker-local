using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cuiliang.AliyunOssSdk.Request;
using Cuiliang.AliyunOssSdk.Utility;
using qdET65OxfuSfXTNffp;
using Quicker.Utilities.Ext;

namespace Cuiliang.AliyunOssSdk.Api.Base;

public abstract class BaseOssCommand<TResult>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CExecuteAsync_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<OssResult<TResult>> _003C_003Et__builder;

		public BaseOssCommand<TResult> _003C_003E4__this;

		public HttpClient client;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		private TaskAwaiter<OssResult<TResult>> _003C_003Eu__2;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			BaseOssCommand<TResult> baseOssCommand = _003C_003E4__this;
			OssResult<TResult> result2;
			try
			{
				try
				{
					TaskAwaiter<OssResult<TResult>> awaiter;
					TaskAwaiter<HttpResponseMessage> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = _003C_003Eu__2;
							_003C_003Eu__2 = default(TaskAwaiter<OssResult<TResult>>);
							num = -1;
							_003C_003E1__state = -1;
							goto IL_0137;
						}
						ServiceRequest serviceRequest = baseOssCommand.BuildRequest();
						serviceRequest.Headers["Date"] = zh4GdKnxb7gfeU5oTf.YoHSowUI1T(DateTime.UtcNow);
						if (baseOssCommand.RequestContext.OssCredential.UseToken)
						{
							serviceRequest.Headers["x-oss-security-token"] = baseOssCommand.RequestContext.OssCredential.SecurityToken;
						}
						awaiter2 = new ServiceCaller(baseOssCommand.RequestContext, client).CallServiceAsync(serviceRequest).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter2;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<HttpResponseMessage>);
						num = -1;
						_003C_003E1__state = -1;
					}
					HttpResponseMessage result = awaiter2.GetResult();
					awaiter = baseOssCommand.mm0NU9RxD5(result).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 1;
						_003C_003E1__state = 1;
						_003C_003Eu__2 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0137;
					IL_0137:
					result2 = awaiter.GetResult();
				}
				catch (Exception ex)
				{
					result2 = new OssResult<TResult>
					{
						IsSuccess = false,
						InnerException = ex,
						ErrorMessage = ex.GetMessageWithInner()
					};
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
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
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CParseResultAsync_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<OssResult<TResult>> _003C_003Et__builder;

		public HttpResponseMessage response;

		private TaskAwaiter<Stream> _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			OssResult<TResult> result;
			try
			{
				TaskAwaiter<Stream> awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<Stream>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_00d5;
				}
				if (response.Content?.Headers?.ContentLength > 0L)
				{
					awaiter = response.Content.ReadAsStreamAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00d5;
				}
				result = new OssResult<TResult>
				{
					IsSuccess = false,
					ErrorMessage = "ContentLength = 0"
				};
				goto end_IL_0007;
				IL_00d5:
				TResult successResult = SerializeHelper.Deserialize<TResult>(awaiter.GetResult());
				result = new OssResult<TResult>
				{
					IsSuccess = true,
					SuccessResult = successResult
				};
				end_IL_0007:;
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
	private struct _003CProcessResponseInternal_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<OssResult<TResult>> _003C_003Et__builder;

		public HttpResponseMessage response;

		public BaseOssCommand<TResult> _003C_003E4__this;

		private TaskAwaiter<OssResult<TResult>> _003C_003Eu__1;

		private TaskAwaiter<string> _003C_003Eu__2;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			BaseOssCommand<TResult> baseOssCommand = _003C_003E4__this;
			OssResult<TResult> result;
			try
			{
				TaskAwaiter<OssResult<TResult>> awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<OssResult<TResult>>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_01bd;
				}
				TaskAwaiter<string> awaiter2;
				if (num == 1)
				{
					awaiter2 = _003C_003Eu__2;
					_003C_003Eu__2 = default(TaskAwaiter<string>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_016f;
				}
				if (response.IsSuccessStatusCode)
				{
					awaiter = baseOssCommand.ParseResultAsync(response).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_01bd;
				}
				if (response.StatusCode == HttpStatusCode.NotModified)
				{
					result = new OssResult<TResult>
					{
						IsSuccess = false,
						ErrorMessage = "NOT_MODIFIED"
					};
				}
				else
				{
					HttpContent content = response.Content;
					if (content != null && content.Headers.ContentLength > 0L)
					{
						awaiter2 = response.Content.ReadAsStringAsync().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 1;
							_003C_003E1__state = 1;
							_003C_003Eu__2 = awaiter2;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_016f;
					}
					result = new OssResult<TResult>
					{
						IsSuccess = false,
						ErrorMessage = "STATUSCODE:" + response.StatusCode
					};
				}
				goto end_IL_000e;
				IL_016f:
				ErrorResult errorResult = SerializeHelper.Deserialize<ErrorResult>(awaiter2.GetResult());
				result = new OssResult<TResult>
				{
					IsSuccess = false,
					ErrorResult = errorResult,
					ErrorMessage = errorResult.Message
				};
				goto end_IL_000e;
				IL_01bd:
				result = awaiter.GetResult();
				end_IL_000e:;
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

	[CompilerGenerated]
	private RequestContext j9KNiWWvVp;

	private static object luo1xl3QFNDmeMNVkIx;

	protected RequestContext RequestContext
	{
		[CompilerGenerated]
		get
		{
			return j9KNiWWvVp;
		}
		[CompilerGenerated]
		private set
		{
			j9KNiWWvVp = value;
		}
	}

	public BaseOssCommand(RequestContext requestContext)
	{
		RequestContext = requestContext;
	}

	public abstract ServiceRequest BuildRequest();

	[AsyncStateMachine(typeof(BaseOssCommand<>._003CParseResultAsync_003Ed__6))]
	public virtual Task<OssResult<TResult>> ParseResultAsync(HttpResponseMessage response)
	{
		_003CParseResultAsync_003Ed__6 stateMachine = default(_003CParseResultAsync_003Ed__6);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<OssResult<TResult>>.Create();
		stateMachine.response = response;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(BaseOssCommand<>._003CExecuteAsync_003Ed__7))]
	public Task<OssResult<TResult>> ExecuteAsync(HttpClient client)
	{
		_003CExecuteAsync_003Ed__7 stateMachine = default(_003CExecuteAsync_003Ed__7);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<OssResult<TResult>>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.client = client;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(BaseOssCommand<>._003CProcessResponseInternal_003Ed__8))]
	private Task<OssResult<TResult>> mm0NU9RxD5(HttpResponseMessage httpResponseMessage_0)
	{
		_003CProcessResponseInternal_003Ed__8 stateMachine = default(_003CProcessResponseInternal_003Ed__8);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<OssResult<TResult>>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.response = httpResponseMessage_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	internal static bool TIbvJK3FNCKxpCh0XH1()
	{
		return luo1xl3QFNDmeMNVkIx == null;
	}
}
