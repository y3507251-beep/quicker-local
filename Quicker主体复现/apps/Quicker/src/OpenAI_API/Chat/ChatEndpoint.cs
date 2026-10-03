using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using OpenAI_API.Models;

namespace OpenAI_API.Chat;

public class ChatEndpoint : EndpointBase, IChatEndpoint
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec DvOvaYYSWh2;

		public static Func<string, ChatMessage> LCEvaIvS92F;

		internal static _003C_003Ec BItVLHcKvKwhtr1djBHl;

		static _003C_003Ec()
		{
			DvOvaYYSWh2 = new _003C_003Ec();
		}

		internal ChatMessage fl3vaewjsu8(string m)
		{
			return new ChatMessage(ChatMessageRole.User, m);
		}

		internal static bool VMZF1UcKd4lsW7SBWZ0u()
		{
			return BItVLHcKvKwhtr1djBHl == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateChatCompletionAsync_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ChatResult> _003C_003Et__builder;

		public ChatEndpoint _003C_003E4__this;

		public ChatRequest request;

		public IDictionary<string, object> extraProps;

		private TaskAwaiter<ChatResult> _003C_003Eu__1;

		internal static object vmvQOQcKJLCMdBpF1fuE;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ChatEndpoint chatEndpoint = _003C_003E4__this;
			ChatResult result;
			try
			{
				TaskAwaiter<ChatResult> awaiter;
				if (num != 0)
				{
					awaiter = chatEndpoint.xm2qSnuXRK<ChatResult>(null, request, extraProps).GetAwaiter();
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
					_003C_003Eu__1 = default(TaskAwaiter<ChatResult>);
					num = -1;
					_003C_003E1__state = -1;
					int num2 = 0;
					if (!NtlS8ScKkur9g1YVtVag())
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
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

		internal static bool NtlS8ScKkur9g1YVtVag()
		{
			return vmvQOQcKJLCMdBpF1fuE == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CStreamChatAsync_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ChatEndpoint _003C_003E4__this;

		public ChatRequest request;

		public IDictionary<string, object> extraProps;

		public Action<ChatResult> resultHandler;

		private IAsyncEnumerator<ChatResult> _003C_003E7__wrap1;

		private object _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private ValueTaskAwaiter<bool> _003C_003Eu__1;

		private ValueTaskAwaiter _003C_003Eu__2;

		internal static object ytZy0lcKr9H0yYjvcVqR;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ChatEndpoint chatEndpoint = _003C_003E4__this;
			try
			{
				if (num == 0)
				{
					goto IL_0083;
				}
				int num2;
				if (num != 1)
				{
					_003C_003E7__wrap1 = chatEndpoint.StreamChatEnumerableAsync(request, extraProps).GetAsyncEnumerator(default(CancellationToken));
					_003C_003E7__wrap2 = null;
					_003C_003E7__wrap3 = 0;
					num2 = 1;
					if (!a7sPIJcKNh1rmjixPGsl())
					{
						int num3 = default(int);
						num2 = num3;
					}
					goto IL_0192;
				}
				ValueTaskAwaiter awaiter = _003C_003Eu__2;
				_003C_003Eu__2 = default(ValueTaskAwaiter);
				num = -1;
				_003C_003E1__state = -1;
				goto IL_0151;
				IL_0192:
				switch (num2)
				{
				case 1:
					break;
				default:
					goto end_IL_000e;
				case 0:
					goto end_IL_000e;
				}
				goto IL_0083;
				IL_0158:
				object obj = _003C_003E7__wrap2;
				if (obj != null)
				{
					ExceptionDispatchInfo.Capture((obj as Exception) ?? throw ((Exception)obj)).Throw();
				}
				_003C_003E7__wrap2 = null;
				_003C_003E7__wrap1 = null;
				num2 = 0;
				if (ytZy0lcKr9H0yYjvcVqR != null)
				{
					goto IL_0192;
				}
				goto end_IL_000e;
				IL_0083:
				try
				{
					if (num != 0)
					{
						goto IL_00bf;
					}
					ValueTaskAwaiter<bool> awaiter2 = _003C_003Eu__1;
					_003C_003Eu__1 = default(ValueTaskAwaiter<bool>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_00de;
					IL_00bf:
					awaiter2 = _003C_003E7__wrap1.MoveNextAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						if (a7sPIJcKNh1rmjixPGsl())
						{
							switch (0)
							{
							}
						}
						_003C_003Eu__1 = awaiter2;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_00de;
					IL_00de:
					if (awaiter2.GetResult())
					{
						ChatResult current = _003C_003E7__wrap1.Current;
						resultHandler(current);
						goto IL_00bf;
					}
				}
				catch (Exception obj2)
				{
					_003C_003E7__wrap2 = obj2;
				}
				if (_003C_003E7__wrap1 != null)
				{
					awaiter = _003C_003E7__wrap1.DisposeAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 1;
						_003C_003E1__state = 1;
						_003C_003Eu__2 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0151;
				}
				goto IL_0158;
				IL_0151:
				awaiter.GetResult();
				goto IL_0158;
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

		internal static bool a7sPIJcKNh1rmjixPGsl()
		{
			return ytZy0lcKr9H0yYjvcVqR == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CStreamCompletionAsync_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ChatEndpoint _003C_003E4__this;

		public ChatRequest request;

		public IDictionary<string, object> extraProps;

		public Action<int, ChatResult> resultHandler;

		private int _003Cindex_003E5__2;

		private IAsyncEnumerator<ChatResult> _003C_003E7__wrap2;

		private object _003C_003E7__wrap3;

		private int _003C_003E7__wrap4;

		private ValueTaskAwaiter<bool> _003C_003Eu__1;

		private ValueTaskAwaiter _003C_003Eu__2;

		private static object W0Fo2PcKLrKbDAUIYhT7;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ChatEndpoint chatEndpoint = _003C_003E4__this;
			try
			{
				if (num == 0)
				{
					goto IL_008f;
				}
				int num2;
				if (num != 1)
				{
					_003Cindex_003E5__2 = 0;
					_003C_003E7__wrap2 = chatEndpoint.StreamChatEnumerableAsync(request, extraProps).GetAsyncEnumerator(default(CancellationToken));
					_003C_003E7__wrap3 = null;
					_003C_003E7__wrap4 = 0;
					num2 = 0;
					if (W0Fo2PcKLrKbDAUIYhT7 == null)
					{
						goto IL_0082;
					}
					goto IL_009c;
				}
				ValueTaskAwaiter awaiter = _003C_003Eu__2;
				_003C_003Eu__2 = default(ValueTaskAwaiter);
				num = -1;
				_003C_003E1__state = -1;
				goto IL_01a7;
				IL_01ae:
				object obj = _003C_003E7__wrap3;
				if (obj != null)
				{
					ExceptionDispatchInfo.Capture((obj as Exception) ?? throw ((Exception)obj)).Throw();
				}
				_003C_003E7__wrap3 = null;
				_003C_003E7__wrap2 = null;
				goto end_IL_000e;
				IL_01a7:
				awaiter.GetResult();
				goto IL_01ae;
				IL_008f:
				num2 = 1;
				if (W0Fo2PcKLrKbDAUIYhT7 == null)
				{
					goto IL_0082;
				}
				goto IL_009c;
				IL_009c:
				int num3 = default(int);
				num2 = num3;
				goto IL_0082;
				IL_0082:
				switch (num2)
				{
				case 1:
					goto IL_00a0;
				}
				goto IL_008f;
				IL_00a0:
				try
				{
					if (num != 0)
					{
						goto IL_00ef;
					}
					ValueTaskAwaiter<bool> awaiter2 = _003C_003Eu__1;
					_003C_003Eu__1 = default(ValueTaskAwaiter<bool>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_0125;
					IL_00ef:
					awaiter2 = _003C_003E7__wrap2.MoveNextAsync().GetAwaiter();
					if (W0Fo2PcKLrKbDAUIYhT7 == null)
					{
						switch (0)
						{
						}
					}
					if (!awaiter2.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter2;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_0125;
					IL_0125:
					if (awaiter2.GetResult())
					{
						ChatResult current = _003C_003E7__wrap2.Current;
						resultHandler(_003Cindex_003E5__2++, current);
						goto IL_00ef;
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
					goto IL_01a7;
				}
				goto IL_01ae;
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

		internal static bool wgaoLZcKuvbtWcaQJPsX()
		{
			return W0Fo2PcKLrKbDAUIYhT7 == null;
		}
	}

	[CompilerGenerated]
	private ChatRequest lDrVClf5ZK = new ChatRequest
	{
		Model = Model.DefaultChatModel
	};

	internal static ChatEndpoint FQlLuma8U1oukyuUKR9;

	public ChatRequest DefaultChatRequestArgs
	{
		[CompilerGenerated]
		get
		{
			return lDrVClf5ZK;
		}
		[CompilerGenerated]
		set
		{
			lDrVClf5ZK = value;
		}
	}

	protected override string Endpoint => "chat/completions";

	internal ChatEndpoint(OpenAIAPI api)
		: base(api)
	{
	}

	public Conversation CreateConversation(ChatRequest defaultChatRequestArgs = null)
	{
		return new Conversation(this, null, defaultChatRequestArgs ?? DefaultChatRequestArgs);
	}

	[AsyncStateMachine(typeof(_003CCreateChatCompletionAsync_003Ed__8))]
	public Task<ChatResult> CreateChatCompletionAsync(ChatRequest request, IDictionary<string, object> extraProps)
	{
		_003CCreateChatCompletionAsync_003Ed__8 stateMachine = default(_003CCreateChatCompletionAsync_003Ed__8);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ChatResult>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.request = request;
		stateMachine.extraProps = extraProps;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public Task<ChatResult> CreateChatCompletionAsync(ChatRequest request, int numOutputs = 5)
	{
		request.NumChoicesPerMessage = numOutputs;
		return CreateChatCompletionAsync(request, null);
	}

	public Task<ChatResult> CreateChatCompletionAsync(IList<ChatMessage> messages, Model model = null, double? temperature = null, double? top_p = null, int? numOutputs = null, int? max_tokens = null, double? frequencyPenalty = null, double? presencePenalty = null, IReadOnlyDictionary<string, float> logitBias = null, params string[] stopSequences)
	{
		ChatRequest request = new ChatRequest(DefaultChatRequestArgs)
		{
			Messages = messages,
			Model = (model ?? ((Model)DefaultChatRequestArgs.Model)),
			Temperature = (temperature ?? DefaultChatRequestArgs.Temperature),
			TopP = (top_p ?? DefaultChatRequestArgs.TopP),
			NumChoicesPerMessage = (numOutputs ?? DefaultChatRequestArgs.NumChoicesPerMessage),
			MultipleStopSequences = (stopSequences ?? DefaultChatRequestArgs.MultipleStopSequences),
			MaxTokens = (max_tokens ?? DefaultChatRequestArgs.MaxTokens),
			FrequencyPenalty = (frequencyPenalty ?? DefaultChatRequestArgs.FrequencyPenalty),
			PresencePenalty = (presencePenalty ?? DefaultChatRequestArgs.PresencePenalty),
			LogitBias = (logitBias ?? DefaultChatRequestArgs.LogitBias)
		};
		return CreateChatCompletionAsync(request, null);
	}

	public Task<ChatResult> CreateChatCompletionAsync(params ChatMessage[] messages)
	{
		ChatRequest request = new ChatRequest(DefaultChatRequestArgs)
		{
			Messages = messages
		};
		return CreateChatCompletionAsync(request, null);
	}

	public Task<ChatResult> CreateChatCompletionAsync(params string[] userMessages)
	{
		return CreateChatCompletionAsync(userMessages.Select(_003C_003Ec.LCEvaIvS92F ?? (_003C_003Ec.LCEvaIvS92F = _003C_003Ec.DvOvaYYSWh2.fl3vaewjsu8)).ToArray());
	}

	public Task<ChatResult> CreateChatCompletionAsync(string userMessage, params ChatMessage.ImageInput[] images)
	{
		ChatRequest chatRequest = new ChatRequest(DefaultChatRequestArgs);
		chatRequest.Model = Model.GPT4_Vision;
		chatRequest.Messages = new ChatMessage[1]
		{
			new ChatMessage(ChatMessageRole.User, userMessage, images)
		};
		ChatRequest request = chatRequest;
		return CreateChatCompletionAsync(request, null);
	}

	[AsyncStateMachine(typeof(_003CStreamCompletionAsync_003Ed__14))]
	public Task StreamCompletionAsync(ChatRequest request, Action<int, ChatResult> resultHandler, IDictionary<string, object> extraProps = null)
	{
		_003CStreamCompletionAsync_003Ed__14 stateMachine = default(_003CStreamCompletionAsync_003Ed__14);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.request = request;
		stateMachine.resultHandler = resultHandler;
		stateMachine.extraProps = extraProps;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CStreamChatAsync_003Ed__15))]
	public Task StreamChatAsync(ChatRequest request, Action<ChatResult> resultHandler, IDictionary<string, object> extraProps)
	{
		_003CStreamChatAsync_003Ed__15 stateMachine = default(_003CStreamChatAsync_003Ed__15);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.request = request;
		stateMachine.resultHandler = resultHandler;
		stateMachine.extraProps = extraProps;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public IAsyncEnumerable<ChatResult> StreamChatEnumerableAsync(ChatRequest request, IDictionary<string, object> extraProps)
	{
		request = new ChatRequest(request)
		{
			Stream = true
		};
		return HttpStreamingRequest<ChatResult>(base.Url, HttpMethod.Post, request, extraProps);
	}

	public IAsyncEnumerable<ChatResult> StreamChatEnumerableAsync(IList<ChatMessage> messages, Model model = null, double? temperature = null, double? top_p = null, int? numOutputs = null, int? max_tokens = null, double? frequencyPenalty = null, double? presencePenalty = null, IReadOnlyDictionary<string, float> logitBias = null, params string[] stopSequences)
	{
		ChatRequest request = new ChatRequest(DefaultChatRequestArgs)
		{
			Messages = messages,
			Model = (model ?? ((Model)DefaultChatRequestArgs.Model)),
			Temperature = (temperature ?? DefaultChatRequestArgs.Temperature),
			TopP = (top_p ?? DefaultChatRequestArgs.TopP),
			NumChoicesPerMessage = (numOutputs ?? DefaultChatRequestArgs.NumChoicesPerMessage),
			MultipleStopSequences = (stopSequences ?? DefaultChatRequestArgs.MultipleStopSequences),
			MaxTokens = (max_tokens ?? DefaultChatRequestArgs.MaxTokens),
			FrequencyPenalty = (frequencyPenalty ?? DefaultChatRequestArgs.FrequencyPenalty),
			PresencePenalty = (presencePenalty ?? DefaultChatRequestArgs.PresencePenalty),
			LogitBias = (logitBias ?? DefaultChatRequestArgs.LogitBias)
		};
		return StreamChatEnumerableAsync(request, null);
	}

	internal static bool Ix0u9saRNbOfW8kdi9R()
	{
		return FQlLuma8U1oukyuUKR9 == null;
	}
}
