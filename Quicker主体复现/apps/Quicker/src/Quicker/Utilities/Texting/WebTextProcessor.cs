using System;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Quicker.Common.Vm;

namespace Quicker.Utilities.Texting;

public class WebTextProcessor
{

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCallUrlServiceAsync_003Ed__1 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public string url;

		public string textToProcess;

		private HttpClient _003Cclient_003E5__2;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		private TaskAwaiter<ApiResult<string>> _003C_003Eu__2;

		private static object gsdjrly3MKC3NM4ZGLe4;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			string data;
			try
			{
				if ((uint)num > 1u)
				{
					_003Cclient_003E5__2 = new HttpClient();
				}
				try
				{
					TaskAwaiter<ApiResult<string>> awaiter;
					TaskAwaiter<HttpResponseMessage> awaiter2;
					int num2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = _003C_003Eu__2;
							_003C_003Eu__2 = default(TaskAwaiter<ApiResult<string>>);
							num = -1;
							_003C_003E1__state = -1;
							goto IL_010f;
						}
						awaiter2 = _003Cclient_003E5__2.PostAsJsonAsync(url, new _003C_003Ef__AnonymousType48<string>(textToProcess)).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							num2 = 1;
							if (!WW7fdOy3UxxZtKCG9aCi())
							{
								goto IL_0093;
							}
							goto IL_0097;
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
					result.EnsureSuccessStatusCode();
					awaiter = result.Content.ReadAsAsync<ApiResult<string>>().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 1;
						_003C_003E1__state = 1;
						_003C_003Eu__2 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_010f;
					IL_0093:
					int num3 = default(int);
					num2 = num3;
					goto IL_0097;
					IL_010f:
					ApiResult<string> result2 = awaiter.GetResult();
					if (!result2.IsSuccess)
					{
						throw new InvalidOperationException("服务调用返回失败：" + result2.Message);
					}
					data = result2.Data;
					goto end_IL_0019;
					IL_0097:
					do
					{
						switch (num2)
						{
						case 1:
							break;
						default:
							return;
						}
						_003C_003Eu__1 = awaiter2;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						num2 = 0;
					}
					while (WW7fdOy3UxxZtKCG9aCi());
					goto IL_0093;
					end_IL_0019:;
				}
				finally
				{
					if (num < 0 && _003Cclient_003E5__2 != null)
					{
						((IDisposable)_003Cclient_003E5__2).Dispose();
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
			_003C_003Et__builder.SetResult(data);
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

		internal static bool WW7fdOy3UxxZtKCG9aCi()
		{
			return gsdjrly3MKC3NM4ZGLe4 == null;
		}
	}

	internal static WebTextProcessor sbguCOFPp4PVdubBTwFY;

	public static Task<string> CallCloudServiceAsync(string keyAndParams, string textToProcess)
	{
		return Task.FromException<string>(new InvalidOperationException("原厂云文本处理已删除，请使用本地文本处理步骤或自行配置的 URL 服务。"));
	}

	[AsyncStateMachine(typeof(_003CCallUrlServiceAsync_003Ed__1))]
	public static Task<string> CallUrlServiceAsync(string url, string textToProcess)
	{
		_003CCallUrlServiceAsync_003Ed__1 stateMachine = default(_003CCallUrlServiceAsync_003Ed__1);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine.url = url;
		stateMachine.textToProcess = textToProcess;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	internal static bool nlHNi2FPXAR9KoeBL9AL()
	{
		return sbguCOFPp4PVdubBTwFY == null;
	}
}
