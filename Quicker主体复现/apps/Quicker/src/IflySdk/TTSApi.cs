using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using IflySdk.Common;
using IflySdk.Enum;
using IflySdk.Model.Common;
using IflySdk.Model.TTS;
using Newtonsoft.Json;

namespace IflySdk;

public class TTSApi
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CConvert_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ResultModel<byte[]>> _003C_003Et__builder;

		public TTSApi _003C_003E4__this;

		public string data;

		private string _003Cbase64Text_003E5__2;

		private ClientWebSocket _003Cws_003E5__3;

		private TaskAwaiter _003C_003Eu__1;

		private static object pM3hVecv9XvoRvfJUpHX;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			TTSApi tTSApi = _003C_003E4__this;
			ResultModel<byte[]> result;
			try
			{
				try
				{
					string uriString = default(string);
					if ((uint)num > 3u)
					{
						tTSApi.Status = ServiceStatus.Running;
						uriString = ApiAuthorization.BuildAuthUrl(tTSApi.iGF92CPp4x);
						if (string.IsNullOrEmpty(data))
						{
							throw new Exception("Convert data is null.");
						}
						_003Cbase64Text_003E5__2 = System.Convert.ToBase64String(Encoding.UTF8.GetBytes(data));
						if (_003Cbase64Text_003E5__2.Length > 8000)
						{
							throw new Exception("Convert string too long. No more than 4000 chinese characters.");
						}
						_003Cws_003E5__3 = new ClientWebSocket();
					}
					try
					{
						TaskAwaiter awaiter;
						int num2;
						TTSFrameData value;
						switch (num)
						{
						default:
							awaiter = _003Cws_003E5__3.ConnectAsync(new Uri(uriString), CancellationToken.None).GetAwaiter();
							if (awaiter.IsCompleted)
							{
								goto IL_00de;
							}
							goto IL_02b9;
						case 0:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default(TaskAwaiter);
							num = -1;
							_003C_003E1__state = -1;
							goto IL_00de;
						case 1:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default(TaskAwaiter);
							num = -1;
							_003C_003E1__state = -1;
							num2 = 0;
							if (pM3hVecv9XvoRvfJUpHX != null)
							{
								goto IL_01f0;
							}
							goto IL_0209;
						case 2:
							awaiter = _003C_003Eu__1;
							num2 = 1;
							if (!zjIrgFcvLEZhrd2FdFtg())
							{
								goto IL_01f0;
							}
							goto IL_0212;
						case 3:
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default(TaskAwaiter);
								num2 = 0;
								if (pM3hVecv9XvoRvfJUpHX != null)
								{
									goto IL_01f0;
								}
								goto IL_02a7;
							}
							IL_01f0:
							switch (num2)
							{
							case 1:
								goto IL_0212;
							case 2:
								goto IL_02a7;
							case 3:
								goto IL_02b9;
							case 4:
								goto end_IL_0083;
							}
							goto IL_0209;
							IL_02a7:
							num = -1;
							_003C_003E1__state = -1;
							goto IL_02b0;
							IL_0212:
							_003C_003Eu__1 = default(TaskAwaiter);
							num = -1;
							_003C_003E1__state = -1;
							goto IL_0247;
							IL_00de:
							awaiter.GetResult();
							tTSApi.j0j9wUpgI1(_003Cws_003E5__3);
							tTSApi.D0h9NYOxeM.text = _003Cbase64Text_003E5__2;
							value = new TTSFrameData
							{
								common = tTSApi.Y0c9umgkJK,
								business = tTSApi.Qij9J4Zd17,
								data = tTSApi.D0h9NYOxeM
							};
							awaiter = _003Cws_003E5__3.SendAsync(new ArraySegment<byte>(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(value))), WebSocketMessageType.Text, true, CancellationToken.None).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 1;
								_003C_003E1__state = 1;
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0209;
							IL_02b0:
							awaiter.GetResult();
							goto end_IL_0082;
							IL_0209:
							awaiter.GetResult();
							goto IL_0229;
							IL_0229:
							if (tTSApi.Status == ServiceStatus.Running)
							{
								awaiter = Task.Delay(10).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num = 2;
									_003C_003E1__state = 2;
									break;
								}
								goto IL_0247;
							}
							awaiter = _003Cws_003E5__3.CloseOutputAsync(WebSocketCloseStatus.NormalClosure, "NormalClosure", CancellationToken.None).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 3;
								_003C_003E1__state = 3;
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_02b0;
							IL_02b9:
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
							IL_0247:
							awaiter.GetResult();
							goto IL_0229;
							end_IL_0083:
							break;
						}
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
						end_IL_0082:;
					}
					finally
					{
						if (num < 0 && _003Cws_003E5__3 != null)
						{
							((IDisposable)_003Cws_003E5__3).Dispose();
						}
					}
					_003Cws_003E5__3 = null;
					result = new ResultModel<byte[]>
					{
						Code = ResultCode.Success,
						Data = ((tTSApi.AJc9gLFwYO == null) ? null : tTSApi.AJc9gLFwYO.ToArray())
					};
				}
				catch (Exception ex)
				{
					result = ((ex.InnerException == null || !(ex.InnerException is SocketException) || ((SocketException)ex.InnerException).SocketErrorCode != SocketError.ConnectionReset) ? new ResultModel<byte[]>
					{
						Code = ResultCode.Error,
						Message = ex.Message
					} : new ResultModel<byte[]>
					{
						Code = ResultCode.Error,
						Message = "服务器主动断开连接，可能是整个会话是否已经超过了60s、读取数据超时等原因引起的。"
					});
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

		internal static bool zjIrgFcvLEZhrd2FdFtg()
		{
			return pM3hVecv9XvoRvfJUpHX == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CStartReceiving_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TTSApi _003C_003E4__this;

		public ClientWebSocket client;

		private string _003Cmsg_003E5__2;

		private byte[] _003Carray_003E5__3;

		private TaskAwaiter<WebSocketReceiveResult> _003C_003Eu__1;

		internal static object UUpuoHcvbLLaQkk6GxD4;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			TTSApi tTSApi = _003C_003E4__this;
			try
			{
				if (num != 0)
				{
					if (tTSApi.AJc9gLFwYO != null)
					{
						tTSApi.AJc9gLFwYO.Clear();
					}
					_003Cmsg_003E5__2 = "";
				}
				TTSResult tTSResult = default(TTSResult);
				WebSocketReceiveResult result = default(WebSocketReceiveResult);
				while (true)
				{
					try
					{
						TaskAwaiter<WebSocketReceiveResult> awaiter;
						if (num != 0)
						{
							if (client.CloseStatus != WebSocketCloseStatus.EndpointUnavailable && client.CloseStatus != WebSocketCloseStatus.InternalServerError && client.CloseStatus != WebSocketCloseStatus.EndpointUnavailable)
							{
								_003Carray_003E5__3 = new byte[100000];
								awaiter = client.ReceiveAsync(new ArraySegment<byte>(_003Carray_003E5__3), CancellationToken.None).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num = 0;
									_003C_003E1__state = 0;
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_017a;
							}
							tTSApi.Status = ServiceStatus.Stopped;
							break;
						}
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<WebSocketReceiveResult>);
						int num2 = 0;
						if (UUpuoHcvbLLaQkk6GxD4 == null)
						{
							goto IL_0171;
						}
						goto IL_019b;
						IL_022f:
						if (tTSResult.Data.Status == 2)
						{
							tTSApi.Status = ServiceStatus.Stopped;
						}
						goto IL_0244;
						IL_0121:
						string text = Encoding.UTF8.GetString(_003Carray_003E5__3, 0, result.Count);
						_003Cmsg_003E5__2 += text;
						if (result.EndOfMessage)
						{
							tTSResult = JsonConvert.DeserializeObject<TTSResult>(_003Cmsg_003E5__2);
							num2 = 0;
							if (UUpuoHcvbLLaQkk6GxD4 == null)
							{
								goto IL_019b;
							}
							goto IL_01bd;
						}
						goto end_IL_0037;
						IL_0171:
						num = -1;
						_003C_003E1__state = -1;
						goto IL_017a;
						IL_01bd:
						_003Cmsg_003E5__2 = "";
						if (tTSResult.Code != 0)
						{
							throw new Exception("Result error: " + tTSResult.Message);
						}
						if (tTSResult.Data == null)
						{
							continue;
						}
						byte[] collection = System.Convert.FromBase64String(tTSResult.Data.Audio);
						tTSApi.AJc9gLFwYO.AddRange(collection);
						tTSApi.yV79Sr39dn?.Invoke(tTSApi, tTSResult.Data.Audio);
						goto IL_022f;
						IL_0244:
						_003Carray_003E5__3 = null;
						goto end_IL_0037;
						IL_017a:
						result = awaiter.GetResult();
						if (result.MessageType != WebSocketMessageType.Text)
						{
							goto IL_0244;
						}
						if (result.Count > 0)
						{
							goto IL_0121;
						}
						goto end_IL_0037;
						IL_019b:
						switch (num2)
						{
						case 3:
							break;
						case 1:
							goto IL_0171;
						default:
							goto IL_01bd;
						case 2:
							goto IL_022f;
						}
						goto IL_0121;
						end_IL_0037:;
					}
					catch (WebSocketException)
					{
						tTSApi.Status = ServiceStatus.Stopped;
						break;
					}
					catch (Exception ex2)
					{
						tTSApi.Status = ServiceStatus.Stopped;
						if (!ex2.Message.ToLower().Contains("unable to read data from the transport connection"))
						{
							tTSApi.Uuj9vdY3MP?.Invoke(tTSApi, new ErrorEventArgs
							{
								Code = ResultCode.Error,
								Message = ex2.Message,
								Exception = ex2
							});
						}
					}
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Cmsg_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003Cmsg_003E5__2 = null;
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

		internal static bool gnJPN1cvqhw9nFpf6o4g()
		{
			return UUpuoHcvbLLaQkk6GxD4 == null;
		}
	}

	private readonly List<byte> AJc9gLFwYO = new List<byte>();

	[CompilerGenerated]
	private ServiceStatus KhI9LcEcGA = ServiceStatus.Stopped;

	[CompilerGenerated]
	private EventHandler<ErrorEventArgs> Uuj9vdY3MP;

	[CompilerGenerated]
	private EventHandler<string> yV79Sr39dn;

	private readonly AppSettings iGF92CPp4x;

	private readonly CommonParams Y0c9umgkJK;

	private readonly DataParams D0h9NYOxeM;

	private readonly BusinessParams Qij9J4Zd17;

	private static TTSApi ejTJGmrMNAqbEll2ZSf;

	public ServiceStatus Status
	{
		[CompilerGenerated]
		get
		{
			return KhI9LcEcGA;
		}
		[CompilerGenerated]
		internal set
		{
			KhI9LcEcGA = value;
		}
	}

	public event EventHandler<ErrorEventArgs> OnError
	{
		[CompilerGenerated]
		add
		{
			EventHandler<ErrorEventArgs> eventHandler = Uuj9vdY3MP;
			EventHandler<ErrorEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ErrorEventArgs> value2 = (EventHandler<ErrorEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Uuj9vdY3MP, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<ErrorEventArgs> eventHandler = Uuj9vdY3MP;
			EventHandler<ErrorEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ErrorEventArgs> value2 = (EventHandler<ErrorEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Uuj9vdY3MP, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<string> OnMessage
	{
		[CompilerGenerated]
		add
		{
			EventHandler<string> eventHandler = yV79Sr39dn;
			EventHandler<string> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<string> value2 = (EventHandler<string>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref yV79Sr39dn, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<string> eventHandler = yV79Sr39dn;
			EventHandler<string> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<string> value2 = (EventHandler<string>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref yV79Sr39dn, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public TTSApi(AppSettings settings, CommonParams common, DataParams data, BusinessParams business)
	{
		iGF92CPp4x = settings;
		Y0c9umgkJK = common;
		D0h9NYOxeM = data;
		Qij9J4Zd17 = business;
	}

	[AsyncStateMachine(typeof(_003CConvert_003Ed__16))]
	public Task<ResultModel<byte[]>> Convert(string data)
	{
		_003CConvert_003Ed__16 stateMachine = default(_003CConvert_003Ed__16);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ResultModel<byte[]>>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.data = data;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CStartReceiving_003Ed__17))]
	private void j0j9wUpgI1(ClientWebSocket clientWebSocket_0)
	{
		_003CStartReceiving_003Ed__17 stateMachine = default(_003CStartReceiving_003Ed__17);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.client = clientWebSocket_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	internal static bool vrxOFsrUBYbiXUDsXAa()
	{
		return ejTJGmrMNAqbEll2ZSf == null;
	}
}
