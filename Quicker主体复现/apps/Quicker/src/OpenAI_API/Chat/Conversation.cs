using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using OpenAI_API.Models;

namespace OpenAI_API.Chat;

public class Conversation
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec o5jvaKK7C35;

		public static Func<ChatMessage, int> DCPvaxWoNZ7;

		public static Func<ChatMessage, int> NOkvarH1M5V;

		public static Func<ChatMessage, int> pLBvapZn9FQ;

		public static Func<ChatMessage, int> PS2vaBs3UBU;

		internal static _003C_003Ec Ei4tRkcK6xoFa1GTvP8t;

		static _003C_003Ec()
		{
			o5jvaKK7C35 = new _003C_003Ec();
		}

		internal int atlvabMrdiS(ChatMessage m)
		{
			return m.TextContent.Length;
		}

		internal int MjJva6yCij8(ChatMessage m)
		{
			return m.TextContent.Length;
		}

		internal int HSPvaXLilWG(ChatMessage m)
		{
			return m.TextContent.Length;
		}

		internal int b4Hvam5BoYw(ChatMessage m)
		{
			return m.TextContent.Length;
		}

		internal static bool TiKrfEcKtgGVkE0igWTU()
		{
			return Ei4tRkcK6xoFa1GTvP8t == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetResponseFromChatbotAsync_003Ed__29 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public Conversation _003C_003E4__this;

		private HttpRequestException _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

		private TaskAwaiter<ChatResult> _003C_003Eu__1;

		private TaskAwaiter<string> _003C_003Eu__2;

		private static object WfjrcTcKTNahnoOvlgw9;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			Conversation conversation = _003C_003E4__this;
			string result2;
			try
			{
				int num2;
				HttpRequestException ex2 = default(HttpRequestException);
				TaskAwaiter<string> awaiter = default(TaskAwaiter<string>);
				int num6 = default(int);
				string text;
				switch (num)
				{
				default:
					_003C_003E7__wrap2 = 0;
					num2 = 3;
					if (!bexprdcKmbcwIbuLa4on())
					{
						goto case 0;
					}
					goto IL_01a5;
				case 0:
				{
					try
					{
        ChatResult chatResult = default;
						TaskAwaiter<ChatResult> awaiter2;
						int num3;
						if (num != 0)
						{
							ChatRequest request = new ChatRequest(conversation.RequestParameters)
							{
								Messages = conversation.N5dV3qCpom.ToList()
							};
							awaiter2 = conversation.rLPVUPTpPA.CreateChatCompletionAsync(request, null).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = 0;
								_003C_003E1__state = 0;
								_003C_003Eu__1 = awaiter2;
								num3 = 0;
								if (WfjrcTcKTNahnoOvlgw9 != null)
								{
									goto IL_00e6;
								}
								goto IL_00e8;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default(TaskAwaiter<ChatResult>);
							num = -1;
							_003C_003E1__state = -1;
						}
						chatResult = (conversation.MostRecentApiResult = awaiter2.GetResult());
						if (chatResult.Choices.Count > 0)
						{
							num3 = 1;
							if (!bexprdcKmbcwIbuLa4on())
							{
								goto IL_00e6;
							}
							goto IL_00e8;
						}
						goto end_IL_003c;
						IL_00e6:
						int num4 = default(int);
						num3 = num4;
						goto IL_00e8;
						IL_00e8:
						switch (num3)
						{
						default:
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						case 1:
						{
							ChatMessage message = chatResult.Choices[0].Message;
							conversation.AppendMessage(message);
							result2 = message.TextContent;
							break;
						}
						}
						goto end_IL_000e;
						end_IL_003c:;
					}
					catch (HttpRequestException ex)
					{
						_003C_003E7__wrap1 = ex;
						_003C_003E7__wrap2 = 1;
					}
					int num5 = _003C_003E7__wrap2;
					if (num5 == 1)
					{
						ex2 = _003C_003E7__wrap1;
						if (ex2.Data.Contains("code") && !string.IsNullOrEmpty(ex2.Data["code"] as string))
						{
							num2 = 0;
							if (!bexprdcKmbcwIbuLa4on())
							{
								goto IL_01a5;
							}
							goto IL_01c7;
						}
						goto IL_0374;
					}
					goto IL_0377;
				}
				case 1:
					awaiter = _003C_003Eu__2;
					_003C_003Eu__2 = default(TaskAwaiter<string>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_039f;
				case 2:
					{
						awaiter = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter<string>);
						num = -1;
						_003C_003E1__state = -1;
						break;
					}
					IL_01a5:
					switch (num2)
					{
					case 3:
						break;
					default:
						goto IL_01c7;
					case 1:
						goto IL_030a;
					case 4:
						goto IL_0325;
					case 2:
						goto IL_039f;
					}
					goto case 0;
					IL_0325:
					num6++;
					goto IL_02fb;
					IL_0377:
					_003C_003E7__wrap1 = null;
					result2 = null;
					goto end_IL_000e;
					IL_039f:
					result2 = awaiter.GetResult();
					goto end_IL_000e;
					IL_0374:
					throw ex2;
					IL_01c7:
					if (!ex2.Data["code"].Equals("context_length_exceeded"))
					{
						goto IL_0374;
					}
					text = "The context length of this conversation is too long for the OpenAI API to handle.  Consider shortening the message history by handling the OnTruncationNeeded event and removing some of the messages in the argument.";
					if (ex2.Data.Contains("message"))
					{
						text = text + "  " + ex2.Data["message"].ToString();
					}
					if (conversation.sK3VfJhbaC != null)
					{
						int num7 = conversation.Messages.Sum(_003C_003Ec.DCPvaxWoNZ7 ?? (_003C_003Ec.DCPvaxWoNZ7 = _003C_003Ec.o5jvaKK7C35.atlvabMrdiS));
						conversation.sK3VfJhbaC(conversation, conversation.N5dV3qCpom);
						if (num7 > conversation.Messages.Sum(_003C_003Ec.NOkvarH1M5V ?? (_003C_003Ec.NOkvarH1M5V = _003C_003Ec.o5jvaKK7C35.MjJva6yCij8)))
						{
							awaiter = conversation.GetResponseFromChatbotAsync().GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 1;
								_003C_003E1__state = 1;
								_003C_003Eu__2 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_039f;
						}
						throw new ArgumentOutOfRangeException("OnTruncationNeeded was called but it did not reduce the message history length.  " + text, ex2);
					}
					if (conversation.AutoTruncateOnContextLengthExceeded)
					{
						num6 = 0;
						goto IL_02fb;
					}
					throw new ArgumentOutOfRangeException(text, ex2);
					IL_02fb:
					if (num6 < conversation.N5dV3qCpom.Count)
					{
						goto IL_030a;
					}
					goto IL_0377;
					IL_030a:
					if (conversation.N5dV3qCpom[num6].Role != ChatMessageRole.System)
					{
						conversation.N5dV3qCpom.RemoveAt(num6);
						awaiter = conversation.GetResponseFromChatbotAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 2;
							_003C_003E1__state = 2;
							_003C_003Eu__2 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						break;
					}
					goto IL_0325;
				}
				result2 = awaiter.GetResult();
				end_IL_000e:;
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

		internal static bool bexprdcKmbcwIbuLa4on()
		{
			return WfjrcTcKTNahnoOvlgw9 == null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CStreamResponseEnumerableFromChatbotAsync_003Ed__33 : IValueTaskSource<bool>, IAsyncEnumerable<string>, IAsyncEnumerator<string>, IAsyncStateMachine, IAsyncDisposable, IValueTaskSource
	{
		public int _003C_003E1__state;

		public AsyncIteratorMethodBuilder _003C_003Et__builder;

		public ManualResetValueTaskSourceCore<bool> _003C_003Ev__promiseOfValueOrEnd;

		private string _003C_003E2__current;

		private bool _003C_003Ew__disposeMode;

		private int _003C_003El__initialThreadId;

		public Conversation _003C_003E4__this;

		private StringBuilder _003CresponseStringBuilder_003E5__2;

		private ChatMessageRole _003CresponseRole_003E5__3;

		private IAsyncEnumerable<ChatResult> _003CresStream_003E5__4;

		private bool _003Cretrying_003E5__5;

		private IAsyncEnumerator<ChatResult> _003Cenumerator_003E5__6;

		private ValueTaskAwaiter<bool> _003C_003Eu__1;

		private ChatResult _003Cres_003E5__7;

		private static _003CStreamResponseEnumerableFromChatbotAsync_003Ed__33 T6uEqEcK7RG78MpenuaX;

		string IAsyncEnumerator<string>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public _003CStreamResponseEnumerableFromChatbotAsync_003Ed__33(int _003C_003E1__state)
		{
			_003C_003Et__builder = AsyncIteratorMethodBuilder.Create();
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			Conversation conversation = _003C_003E4__this;
			try
			{
				ValueTaskAwaiter<bool> awaiter = default(ValueTaskAwaiter<bool>);
				ChatRequest chatRequest = default(ChatRequest);
				int num2;
				int num3 = default(int);
				ChatMessage chatMessage = default(ChatMessage);
				_003CStreamResponseEnumerableFromChatbotAsync_003Ed__33 stateMachine;
				switch (num)
				{
				case -4:
					num = -1;
					_003C_003E1__state = -1;
					if (!_003C_003Ew__disposeMode)
					{
						goto IL_012d;
					}
					goto end_IL_000e;
				default:
					if (!_003C_003Ew__disposeMode)
					{
						num = -1;
						_003C_003E1__state = -1;
						chatRequest = null;
						_003CresponseStringBuilder_003E5__2 = new StringBuilder();
						goto IL_01ad;
					}
					goto end_IL_000e;
				case 1:
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ValueTaskAwaiter<bool>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_008f;
				case 0:
					{
						try
						{
							int num4;
							if (num != 0)
							{
								_003CresStream_003E5__4 = conversation.rLPVUPTpPA.StreamChatEnumerableAsync(chatRequest, null);
								_003Cenumerator_003E5__6 = _003CresStream_003E5__4.GetAsyncEnumerator(default(CancellationToken));
								_003C_003E2__current = null;
								awaiter = _003Cenumerator_003E5__6.MoveNextAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num = 0;
									_003C_003E1__state = 0;
									_003C_003Eu__1 = awaiter;
									stateMachine = this;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
									return;
								}
								num4 = 0;
								if (Vjm0opcK4T2yJShlR4eK())
								{
									goto IL_02a3;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default(ValueTaskAwaiter<bool>);
								num = -1;
								_003C_003E1__state = -1;
							}
							goto IL_02b0;
							IL_02b0:
							awaiter.GetResult();
							ChatResult current = _003Cenumerator_003E5__6.Current;
							num4 = 1;
							if (!Vjm0opcK4T2yJShlR4eK())
							{
								int num5 = default(int);
								num4 = num5;
							}
							goto IL_02a3;
							IL_02a3:
							switch (num4)
							{
							case 1:
								goto end_IL_01f3;
							}
							goto IL_02b0;
							end_IL_01f3:;
						}
						catch (HttpRequestException ex)
						{
							int num9 = default(int);
							if (ex.Data.Contains("code") && !string.IsNullOrEmpty(ex.Data["code"] as string) && ex.Data["code"].Equals("context_length_exceeded"))
							{
								string text = "The context length of this conversation is too long for the OpenAI API to handle.  Consider shortening the message history by handling the OnTruncationNeeded event and removing some of the messages in the argument.";
								if (ex.Data.Contains("message"))
								{
									text = text + "  " + ex.Data["message"].ToString();
								}
								if (conversation.sK3VfJhbaC != null)
								{
									int num6 = 0;
									if (!Vjm0opcK4T2yJShlR4eK())
									{
										int num7 = default(int);
										num6 = num7;
									}
									switch (num6)
									{
									default:
									{
										int num8 = conversation.Messages.Sum(_003C_003Ec.pLBvapZn9FQ ?? (_003C_003Ec.pLBvapZn9FQ = _003C_003Ec.o5jvaKK7C35.HSPvaXLilWG));
										conversation.sK3VfJhbaC(conversation, conversation.N5dV3qCpom);
										if (num8 <= conversation.Messages.Sum(_003C_003Ec.PS2vaBs3UBU ?? (_003C_003Ec.PS2vaBs3UBU = _003C_003Ec.o5jvaKK7C35.b4Hvam5BoYw)))
										{
											_003Cretrying_003E5__5 = false;
											throw new ArgumentOutOfRangeException("OnTruncationNeeded was called but it did not reduce the message history length.  " + text, ex);
										}
										_003Cretrying_003E5__5 = true;
										goto end_IL_02da;
									}
									case 1:
										break;
									}
									goto IL_045b;
								}
								if (conversation.AutoTruncateOnContextLengthExceeded)
								{
									num9 = 0;
									goto IL_0431;
								}
								_003Cretrying_003E5__5 = false;
								throw new ArgumentOutOfRangeException(text, ex);
							}
							throw ex;
							IL_045b:
							num9++;
							goto IL_0431;
							IL_0431:
							if (num9 < conversation.N5dV3qCpom.Count)
							{
								if (conversation.N5dV3qCpom[num9].Role == ChatMessageRole.System)
								{
									goto IL_045b;
								}
								conversation.N5dV3qCpom.RemoveAt(num9);
								_003Cretrying_003E5__5 = true;
							}
							end_IL_02da:;
						}
						goto IL_04a2;
					}
					IL_00d8:
					num2 = num3;
					goto IL_0192;
					IL_012d:
					conversation.MostRecentApiResult = _003Cres_003E5__7;
					_003Cres_003E5__7 = null;
					_003C_003E2__current = null;
					awaiter = _003Cenumerator_003E5__6.MoveNextAsync().GetAwaiter();
					if (awaiter.IsCompleted)
					{
						goto IL_008f;
					}
					num = 1;
					_003C_003E1__state = 1;
					num2 = 4;
					if (T6uEqEcK7RG78MpenuaX != null)
					{
						break;
					}
					goto IL_0192;
					IL_008f:
					if (awaiter.GetResult())
					{
						goto IL_009b;
					}
					if (_003CresponseRole_003E5__3 != null)
					{
						conversation.AppendMessage(_003CresponseRole_003E5__3, _003CresponseStringBuilder_003E5__2.ToString());
					}
					goto end_IL_000e;
					IL_009b:
					_003Cres_003E5__7 = _003Cenumerator_003E5__6.Current;
					num2 = 1;
					if (!Vjm0opcK4T2yJShlR4eK())
					{
						goto IL_00d8;
					}
					goto IL_0192;
					IL_0192:
					while (true)
					{
						switch (num2)
						{
						case 4:
							break;
						case 1:
							goto IL_00de;
						default:
							goto IL_0183;
						case 3:
							goto end_IL_0192;
						case 2:
							goto end_IL_0012;
						}
						_003C_003Eu__1 = awaiter;
						num2 = 2;
						if (T6uEqEcK7RG78MpenuaX == null)
						{
							continue;
						}
						goto IL_00d8;
						IL_0183:
						_003CresponseRole_003E5__3 = chatMessage.Role;
						goto IL_0118;
						IL_00de:
						chatMessage = _003Cres_003E5__7.Choices.FirstOrDefault()?.Delta;
						if (chatMessage != null)
						{
							if (chatMessage.Role != null)
							{
								num2 = 0;
								if (T6uEqEcK7RG78MpenuaX == null)
								{
									continue;
								}
								goto IL_00d8;
							}
							goto IL_0118;
						}
						goto IL_012d;
						IL_0118:
						string textContent = chatMessage.TextContent;
						if (string.IsNullOrEmpty(textContent))
						{
							goto IL_012d;
						}
						_003CresponseStringBuilder_003E5__2.Append(textContent);
						_003C_003E2__current = textContent;
						num = -4;
						_003C_003E1__state = -4;
						goto IL_0586;
						continue;
						end_IL_0192:
						break;
					}
					goto IL_01ad;
					IL_01ad:
					_003CresponseRole_003E5__3 = null;
					_003CresStream_003E5__4 = null;
					_003Cretrying_003E5__5 = true;
					_003Cenumerator_003E5__6 = null;
					goto IL_04a2;
					IL_04a2:
					if (_003Cretrying_003E5__5)
					{
						_003Cretrying_003E5__5 = false;
						chatRequest = new ChatRequest(conversation.RequestParameters)
						{
							Messages = conversation.N5dV3qCpom.ToList()
						};
						goto case 0;
					}
					if (_003CresStream_003E5__4 == null)
					{
						throw new Exception("The chat result stream is null, but it shouldn't be");
					}
					goto IL_009b;
					end_IL_0012:
					break;
				}
				stateMachine = this;
				_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
				return;
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003CresponseStringBuilder_003E5__2 = null;
				_003CresponseRole_003E5__3 = null;
				int num10 = 0;
				if (!Vjm0opcK4T2yJShlR4eK())
				{
					int num11 = default(int);
					num10 = num11;
				}
				switch (num10)
				{
				}
				_003CresStream_003E5__4 = null;
				_003Cenumerator_003E5__6 = null;
				_003Cres_003E5__7 = null;
				_003C_003E2__current = null;
				_003C_003Et__builder.Complete();
				_003C_003Ev__promiseOfValueOrEnd.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003CresponseStringBuilder_003E5__2 = null;
			_003CresponseRole_003E5__3 = null;
			_003CresStream_003E5__4 = null;
			_003Cenumerator_003E5__6 = null;
			_003Cres_003E5__7 = null;
			_003C_003E2__current = null;
			_003C_003Et__builder.Complete();
			_003C_003Ev__promiseOfValueOrEnd.SetResult(false);
			if (T6uEqEcK7RG78MpenuaX != null)
			{
				switch (0)
				{
				}
			}
			return;
			IL_0586:
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
		IAsyncEnumerator<string> IAsyncEnumerable<string>.GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			_003CStreamResponseEnumerableFromChatbotAsync_003Ed__33 result;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = -3;
				_003C_003Et__builder = AsyncIteratorMethodBuilder.Create();
				_003C_003Ew__disposeMode = false;
				result = this;
			}
			else
			{
				result = new _003CStreamResponseEnumerableFromChatbotAsync_003Ed__33(-3)
				{
					_003C_003E4__this = _003C_003E4__this
				};
			}
			return result;
		}

		[DebuggerHidden]
		ValueTask<bool> IAsyncEnumerator<string>.MoveNextAsync()
		{
			if (_003C_003E1__state == -2)
			{
				return default(ValueTask<bool>);
			}
			_003C_003Ev__promiseOfValueOrEnd.Reset();
			_003CStreamResponseEnumerableFromChatbotAsync_003Ed__33 stateMachine = this;
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
			_003CStreamResponseEnumerableFromChatbotAsync_003Ed__33 stateMachine = this;
			_003C_003Et__builder.MoveNext(ref stateMachine);
			return new ValueTask(this, _003C_003Ev__promiseOfValueOrEnd.Version);
		}

		internal static bool Vjm0opcK4T2yJShlR4eK()
		{
			return T6uEqEcK7RG78MpenuaX == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CStreamResponseFromChatbotAsync_003Ed__31 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Conversation _003C_003E4__this;

		public Action<string> resultHandler;

		private IAsyncEnumerator<string> _003C_003E7__wrap1;

		private object _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private ValueTaskAwaiter<bool> _003C_003Eu__1;

		private ValueTaskAwaiter _003C_003Eu__2;

		internal static object sI4wcDcBW1tD2ZKy62Bv;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			Conversation conversation = _003C_003E4__this;
			try
			{
        ValueTask valueTask = default;
				ValueTaskAwaiter awaiter;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = _003C_003Eu__2;
						_003C_003Eu__2 = default(ValueTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
						goto IL_0142;
					}
					_003C_003E7__wrap1 = conversation.StreamResponseEnumerableFromChatbotAsync().GetAsyncEnumerator(default(CancellationToken));
					_003C_003E7__wrap2 = null;
					_003C_003E7__wrap3 = 0;
				}
				try
				{
					if (num != 0)
					{
						goto IL_00b6;
					}
					ValueTaskAwaiter<bool> awaiter2 = _003C_003Eu__1;
					int num2 = 0;
					if (sI4wcDcBW1tD2ZKy62Bv != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
					_003C_003Eu__1 = default(ValueTaskAwaiter<bool>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_00d5;
					IL_00b6:
					awaiter2 = _003C_003E7__wrap1.MoveNextAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter2;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_00d5;
					IL_00d5:
					if (awaiter2.GetResult())
					{
						string current = _003C_003E7__wrap1.Current;
						resultHandler(current);
						goto IL_00b6;
					}
				}
				catch (Exception obj)
				{
					_003C_003E7__wrap2 = obj;
				}
				if (_003C_003E7__wrap1 == null)
				{
					goto IL_0149;
				}
				valueTask = _003C_003E7__wrap1.DisposeAsync();
				int num4 = 0;
				if (JVqaGpcByE0YYJE22ffo())
				{
					goto IL_0131;
				}
				goto IL_017c;
				IL_0131:
				awaiter = valueTask.GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = 1;
					_003C_003E1__state = 1;
					_003C_003Eu__2 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_0142;
				IL_0142:
				awaiter.GetResult();
				goto IL_0149;
				IL_01af:
				_003C_003E7__wrap1 = null;
				goto end_IL_000e;
				IL_017c:
				switch (num4)
				{
				case 1:
					goto IL_01af;
				}
				goto IL_0131;
				IL_0149:
				object obj2 = _003C_003E7__wrap2;
				if (obj2 != null)
				{
					ExceptionDispatchInfo.Capture((obj2 as Exception) ?? throw ((Exception)obj2)).Throw();
				}
				_003C_003E7__wrap2 = null;
				num4 = 0;
				if (!JVqaGpcByE0YYJE22ffo())
				{
					goto IL_017c;
				}
				goto IL_01af;
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

		internal static bool JVqaGpcByE0YYJE22ffo()
		{
			return sI4wcDcBW1tD2ZKy62Bv == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CStreamResponseFromChatbotAsync_003Ed__32 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Conversation _003C_003E4__this;

		public Action<int, string> resultHandler;

		private int _003Cindex_003E5__2;

		private IAsyncEnumerator<string> _003C_003E7__wrap2;

		private object _003C_003E7__wrap3;

		private int _003C_003E7__wrap4;

		private ValueTaskAwaiter<bool> _003C_003Eu__1;

		private ValueTaskAwaiter _003C_003Eu__2;

		internal static object AlncQicBXDRkri4BSQGO;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			Conversation conversation = _003C_003E4__this;
			try
			{
				if (num == 0)
				{
					goto IL_0075;
				}
				int num2;
				if (num != 1)
				{
					_003Cindex_003E5__2 = 0;
					_003C_003E7__wrap2 = conversation.StreamResponseEnumerableFromChatbotAsync().GetAsyncEnumerator(default(CancellationToken));
					_003C_003E7__wrap3 = null;
					num2 = 0;
					if (!bTdFnvcB2S5eUoeV0WxG())
					{
						goto IL_014e;
					}
					goto IL_015b;
				}
				ValueTaskAwaiter awaiter = _003C_003Eu__2;
				_003C_003Eu__2 = default(ValueTaskAwaiter);
				num = -1;
				_003C_003E1__state = -1;
				goto IL_013b;
				IL_013b:
				awaiter.GetResult();
				num2 = 0;
				if (AlncQicBXDRkri4BSQGO != null)
				{
					goto IL_014e;
				}
				goto IL_0192;
				IL_0192:
				object obj = _003C_003E7__wrap3;
				if (obj != null)
				{
					ExceptionDispatchInfo.Capture((obj as Exception) ?? throw ((Exception)obj)).Throw();
				}
				_003C_003E7__wrap3 = null;
				_003C_003E7__wrap2 = null;
				goto end_IL_000e;
				IL_014e:
				switch (num2)
				{
				case 1:
					goto IL_0192;
				}
				goto IL_015b;
				IL_015b:
				_003C_003E7__wrap4 = 0;
				goto IL_0075;
				IL_0075:
				try
				{
					if (num != 0)
					{
						goto IL_00c5;
					}
					ValueTaskAwaiter<bool> awaiter2 = _003C_003Eu__1;
					_003C_003Eu__1 = default(ValueTaskAwaiter<bool>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_00e4;
					IL_00c5:
					awaiter2 = _003C_003E7__wrap2.MoveNextAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter2;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_00e4;
					IL_00e4:
					if (awaiter2.GetResult())
					{
						string current = _003C_003E7__wrap2.Current;
						resultHandler(_003Cindex_003E5__2++, current);
						goto IL_00c5;
					}
				}
				catch (Exception obj2)
				{
					_003C_003E7__wrap3 = obj2;
				}
				if (_003C_003E7__wrap2 != null)
				{
					awaiter = _003C_003E7__wrap2.DisposeAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 1;
						_003C_003E1__state = 1;
						_003C_003Eu__2 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_013b;
				}
				goto IL_0192;
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

		internal static bool bTdFnvcB2S5eUoeV0WxG()
		{
			return AlncQicBXDRkri4BSQGO == null;
		}
	}

	private ChatEndpoint rLPVUPTpPA;

	[CompilerGenerated]
	private ChatRequest hYrVlcorW7;

	[CompilerGenerated]
	private ChatResult tNEVimJrk8;

	private List<ChatMessage> N5dV3qCpom;

	[CompilerGenerated]
	private EventHandler<List<ChatMessage>> sK3VfJhbaC;

	[CompilerGenerated]
	private bool Rs7Vz6niJc = true;

	internal static Conversation gnRmRorcrKIFn9fvY6b;

	public ChatRequest RequestParameters
	{
		[CompilerGenerated]
		get
		{
			return hYrVlcorW7;
		}
		[CompilerGenerated]
		private set
		{
			hYrVlcorW7 = value;
		}
	}

	public Model Model
	{
		get
		{
			return RequestParameters.Model;
		}
		set
		{
			RequestParameters.Model = value;
		}
	}

	public ChatResult MostRecentApiResult
	{
		[CompilerGenerated]
		get
		{
			return tNEVimJrk8;
		}
		[CompilerGenerated]
		private set
		{
			tNEVimJrk8 = value;
		}
	}

	public IList<ChatMessage> Messages => N5dV3qCpom;

	public bool AutoTruncateOnContextLengthExceeded
	{
		[CompilerGenerated]
		get
		{
			return Rs7Vz6niJc;
		}
		[CompilerGenerated]
		set
		{
			Rs7Vz6niJc = value;
		}
	}

	public event EventHandler<List<ChatMessage>> OnTruncationNeeded
	{
		[CompilerGenerated]
		add
		{
			EventHandler<List<ChatMessage>> eventHandler = sK3VfJhbaC;
			EventHandler<List<ChatMessage>> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<List<ChatMessage>> value2 = (EventHandler<List<ChatMessage>>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref sK3VfJhbaC, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<List<ChatMessage>> eventHandler = sK3VfJhbaC;
			EventHandler<List<ChatMessage>> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<List<ChatMessage>> value2 = (EventHandler<List<ChatMessage>>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref sK3VfJhbaC, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public Conversation(ChatEndpoint endpoint, Model model = null, ChatRequest defaultChatRequestArgs = null)
	{
		RequestParameters = new ChatRequest(defaultChatRequestArgs);
		if (model != null)
		{
			RequestParameters.Model = model;
		}
		if (RequestParameters.Model == null)
		{
			RequestParameters.Model = Model.DefaultChatModel;
		}
		N5dV3qCpom = new List<ChatMessage>();
		rLPVUPTpPA = endpoint;
		RequestParameters.NumChoicesPerMessage = 1;
		RequestParameters.Stream = false;
	}

	public void AppendMessage(ChatMessage message)
	{
		N5dV3qCpom.Add(message);
	}

	public void AppendMessage(ChatMessageRole role, string text, params ChatMessage.ImageInput[] images)
	{
		AppendMessage(new ChatMessage(role, text, images));
	}

	public void AppendUserInput(string text, params ChatMessage.ImageInput[] images)
	{
		AppendMessage(new ChatMessage(ChatMessageRole.User, text, images));
	}

	public void AppendUserInputWithName(string userName, string text, params ChatMessage.ImageInput[] images)
	{
		AppendMessage(new ChatMessage(ChatMessageRole.User, text, images)
		{
			Name = userName
		});
	}

	public void AppendSystemMessage(string content)
	{
		AppendMessage(new ChatMessage(ChatMessageRole.System, content));
	}

	public void AppendExampleChatbotOutput(string content)
	{
		AppendMessage(new ChatMessage(ChatMessageRole.Assistant, content));
	}

	[AsyncStateMachine(typeof(_003CGetResponseFromChatbotAsync_003Ed__29))]
	public Task<string> GetResponseFromChatbotAsync()
	{
		_003CGetResponseFromChatbotAsync_003Ed__29 stateMachine = default(_003CGetResponseFromChatbotAsync_003Ed__29);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[Obsolete("Conversation.GetResponseFromChatbot() has been renamed to GetResponseFromChatbotAsync to follow .NET naming guidelines.  Please update any references to GetResponseFromChatbotAsync().  This alias will be removed in a future version.", false)]
	public Task<string> GetResponseFromChatbot()
	{
		return GetResponseFromChatbotAsync();
	}

	[AsyncStateMachine(typeof(_003CStreamResponseFromChatbotAsync_003Ed__31))]
	public Task StreamResponseFromChatbotAsync(Action<string> resultHandler)
	{
		_003CStreamResponseFromChatbotAsync_003Ed__31 stateMachine = default(_003CStreamResponseFromChatbotAsync_003Ed__31);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.resultHandler = resultHandler;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CStreamResponseFromChatbotAsync_003Ed__32))]
	public Task StreamResponseFromChatbotAsync(Action<int, string> resultHandler)
	{
		_003CStreamResponseFromChatbotAsync_003Ed__32 stateMachine = default(_003CStreamResponseFromChatbotAsync_003Ed__32);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.resultHandler = resultHandler;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncIteratorStateMachine(typeof(_003CStreamResponseEnumerableFromChatbotAsync_003Ed__33))]
	public IAsyncEnumerable<string> StreamResponseEnumerableFromChatbotAsync()
	{
		return new _003CStreamResponseEnumerableFromChatbotAsync_003Ed__33(-2)
		{
			_003C_003E4__this = this
		};
	}

	internal static bool mkvLpZrWnbKNuPWJj1u()
	{
		return gnRmRorcrKIFn9fvY6b == null;
	}
}
