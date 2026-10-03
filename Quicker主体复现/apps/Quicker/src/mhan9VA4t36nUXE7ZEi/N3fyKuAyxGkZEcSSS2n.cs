using System;
using System.Diagnostics;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using CodeCompletionServer.Entities;
using log4net;
using Quicker.Domain;
using Quicker.Utilities.Ext;

namespace mhan9VA4t36nUXE7ZEi;

internal class N3fyKuAyxGkZEcSSS2n
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetCompletionAsync_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CompletionResponse> _003C_003Et__builder;

		public CompletionRequest request;

		public CancellationToken cancellationToken;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		private TaskAwaiter<CompletionResponse> _003C_003Eu__2;

		internal static object joVNFVciZqt4cJ5SaKiV;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			CompletionResponse result;
			try
			{
				try
				{
					if (num == 0)
					{
						goto IL_00af;
					}
					int num2 = 1;
					if (joVNFVciZqt4cJ5SaKiV != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					case 1:
						break;
					default:
						goto IL_00af;
					}
					TaskAwaiter<HttpResponseMessage> awaiter;
					if (num != 1)
					{
						awaiter = FwBlxwtjVU.PostAsJsonAsync(K8ilbk4F0T() + "GetCompletion", request, cancellationToken).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_00cd;
					}
					TaskAwaiter<CompletionResponse> awaiter2 = _003C_003Eu__2;
					_003C_003Eu__2 = default(TaskAwaiter<CompletionResponse>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_0125;
					IL_0125:
					result = awaiter2.GetResult();
					goto end_IL_0009;
					IL_00af:
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<HttpResponseMessage>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_00cd;
					IL_00cd:
					HttpResponseMessage result2 = awaiter.GetResult();
					if (result2.IsSuccessStatusCode)
					{
						awaiter2 = result2.Content.ReadAsAsync<CompletionResponse>().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 1;
							_003C_003E1__state = 1;
							_003C_003Eu__2 = awaiter2;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_0125;
					}
					result = null;
					end_IL_0009:;
				}
				catch (OperationCanceledException ex)
				{
					tEmlmlks8E.Info("获补全列表操作已取消。" + ex.Message);
					result = null;
				}
				catch (Exception exception)
				{
					tEmlmlks8E.Warn("获取补全数据出错：" + exception.GetMessageWithInner(), exception);
					result = null;
				}
			}
			catch (Exception exception2)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception2);
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

		internal static bool j5cGAuci5mPikoH5nwoa()
		{
			return joVNFVciZqt4cJ5SaKiV == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetItemDescriptionAsync_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ItemDescriptionResult> _003C_003Et__builder;

		public ItemDescriptionRequest request;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu__1;

		private TaskAwaiter<ItemDescriptionResult> _003C_003Eu__2;

		internal static object uuqa9IciguJcjmr4Kks7;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ItemDescriptionResult result;
			try
			{
				try
				{
					TaskAwaiter<HttpResponseMessage> awaiter;
					TaskAwaiter<ItemDescriptionResult> awaiter2;
					if (num != 0)
					{
						if (num != 1)
						{
							awaiter = FwBlxwtjVU.PostAsJsonAsync(K8ilbk4F0T() + "GetItemDescription", request).GetAwaiter();
							if (awaiter.IsCompleted)
							{
								goto IL_00c8;
							}
							int num2 = 0;
							if (uuqa9IciguJcjmr4Kks7 != null)
							{
								int num3 = default(int);
								num2 = num3;
							}
							switch (num2)
							{
							default:
								num = 0;
								_003C_003E1__state = 0;
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 1:
								break;
							}
						}
						awaiter2 = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter<ItemDescriptionResult>);
						num = -1;
						_003C_003E1__state = -1;
						goto IL_010e;
					}
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<HttpResponseMessage>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_00c8;
					IL_00c8:
					awaiter2 = awaiter.GetResult().Content.ReadAsAsync<ItemDescriptionResult>().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = 1;
						_003C_003E1__state = 1;
						_003C_003Eu__2 = awaiter2;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_010e;
					IL_010e:
					result = awaiter2.GetResult();
				}
				catch (OperationCanceledException ex)
				{
					tEmlmlks8E.Info("获取补全项提示操作已取消。(" + request.Text + ")" + ex.Message);
					result = null;
				}
				catch (Exception ex2)
				{
					tEmlmlks8E.Warn("获取补全项提示操作出错(" + request.Text + ")：" + ex2.Message, ex2);
					result = null;
				}
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

		internal static bool NTdE3PciPEqcTrT1l0YV()
		{
			return uuqa9IciguJcjmr4Kks7 == null;
		}
	}

	private static readonly ILog tEmlmlks8E;

	public static string RURlKYac4J;

	public static HttpClient FwBlxwtjVU;

	private static N3fyKuAyxGkZEcSSS2n kcDbYvQV91AJKWyMcClI;

	public static string K8ilbk4F0T()
	{
		if (string.IsNullOrWhiteSpace(AppState.DataService?.LocalSettings?.CodeCompletionServer))
		{
			throw new InvalidOperationException("未配置代码补全服务。原厂补全服务已删除，可在设置中指定自己的服务。");
		}
		string text = AppState.DataService?.LocalSettings?.CodeCompletionServer.TrimEnd();
		if (!text.EndsWith("/"))
		{
			return text + "/";
		}
		return text;
	}

	[AsyncStateMachine(typeof(_003CGetCompletionAsync_003Ed__4))]
	public static Task<CompletionResponse> RYkl6t8Icv(CompletionRequest completionRequest_0, CancellationToken cancellationToken_0)
	{
		_003CGetCompletionAsync_003Ed__4 stateMachine = default(_003CGetCompletionAsync_003Ed__4);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CompletionResponse>.Create();
		stateMachine.request = completionRequest_0;
		stateMachine.cancellationToken = cancellationToken_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CGetItemDescriptionAsync_003Ed__5))]
	public static Task<ItemDescriptionResult> iltlXtrqWw(ItemDescriptionRequest itemDescriptionRequest_0, CancellationToken cancellationToken_0)
	{
		_003CGetItemDescriptionAsync_003Ed__5 stateMachine = default(_003CGetItemDescriptionAsync_003Ed__5);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ItemDescriptionResult>.Create();
		stateMachine.request = itemDescriptionRequest_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	static N3fyKuAyxGkZEcSSS2n()
	{
		tEmlmlks8E = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		RURlKYac4J = null;
		FwBlxwtjVU = new HttpClient();
	}

	internal static bool KW15jNQVLi4f4rjfV0fc()
	{
		return kcDbYvQV91AJKWyMcClI == null;
	}
}
