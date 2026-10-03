using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using OpenAI_API.Models;

namespace OpenAI_API.Completions;

public class CompletionEndpoint : EndpointBase, ICompletionEndpoint
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateAndFormatCompletion_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public CompletionRequest request;

		public CompletionEndpoint _003C_003E4__this;

		private string _003Cprompt_003E5__2;

		private TaskAwaiter<CompletionResult> _003C_003Eu__1;

		private static object UsnxBMcKpKW5Oh2ACmpq;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			CompletionEndpoint completionEndpoint = _003C_003E4__this;
			string result2;
			try
			{
				TaskAwaiter<CompletionResult> awaiter;
				if (num != 0)
				{
					int num2 = 0;
					if (!bP5qXlcKXqT8Z0uD0QPK())
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
					_003Cprompt_003E5__2 = request.Prompt;
					awaiter = completionEndpoint.CreateCompletionAsync(request).GetAwaiter();
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
					_003C_003Eu__1 = default(TaskAwaiter<CompletionResult>);
					num = -1;
					_003C_003E1__state = -1;
				}
				CompletionResult result = awaiter.GetResult();
				result2 = _003Cprompt_003E5__2 + result.ToString();
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Cprompt_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003Cprompt_003E5__2 = null;
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

		internal static bool bP5qXlcKXqT8Z0uD0QPK()
		{
			return UsnxBMcKpKW5Oh2ACmpq == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateCompletionAsync_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<CompletionResult> _003C_003Et__builder;

		public CompletionEndpoint _003C_003E4__this;

		public CompletionRequest request;

		private TaskAwaiter<CompletionResult> _003C_003Eu__1;

		private static object pidsQvcKAroJSfvRPDoB;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			CompletionEndpoint completionEndpoint = _003C_003E4__this;
			CompletionResult result;
			try
			{
				TaskAwaiter<CompletionResult> awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<CompletionResult>);
					num = -1;
					_003C_003E1__state = -1;
				}
				else
				{
					awaiter = completionEndpoint.xm2qSnuXRK<CompletionResult>(null, request).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						if (pidsQvcKAroJSfvRPDoB != null)
						{
							switch (0)
							{
							}
						}
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
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

		internal static bool hGo6P5cKntJneptjDspf()
		{
			return pidsQvcKAroJSfvRPDoB == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CGetCompletion_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public CompletionEndpoint _003C_003E4__this;

		public string prompt;

		private TaskAwaiter<CompletionResult> _003C_003Eu__1;

		private static object rrN5ZScKjaa0yM8gfWsP;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			CompletionEndpoint completionEndpoint = _003C_003E4__this;
			string result;
			try
			{
				TaskAwaiter<CompletionResult> awaiter;
				if (num != 0)
				{
					CompletionRequest request = new CompletionRequest(completionEndpoint.DefaultCompletionRequestArgs)
					{
						Prompt = prompt,
						NumChoicesPerPrompt = 1
					};
					awaiter = completionEndpoint.CreateCompletionAsync(request).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						if (!q6eoeqcKDrkDVagiaOgn())
						{
							switch (0)
							{
							}
						}
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<CompletionResult>);
					num = -1;
					_003C_003E1__state = -1;
				}
				result = awaiter.GetResult().ToString();
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

		internal static bool q6eoeqcKDrkDVagiaOgn()
		{
			return rrN5ZScKjaa0yM8gfWsP == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CStreamCompletionAsync_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CompletionEndpoint _003C_003E4__this;

		public CompletionRequest request;

		public Action<int, CompletionResult> resultHandler;

		private int _003Cindex_003E5__2;

		private IAsyncEnumerator<CompletionResult> _003C_003E7__wrap2;

		private object _003C_003E7__wrap3;

		private int _003C_003E7__wrap4;

		private ValueTaskAwaiter<bool> _003C_003Eu__1;

		private ValueTaskAwaiter _003C_003Eu__2;

		internal static object Kl2QblcKEisqXQlPPEF2;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			CompletionEndpoint completionEndpoint = _003C_003E4__this;
			try
			{
        ValueTaskAwaiter awaiter = default;
				if (num == 0)
				{
					goto IL_007d;
				}
				int num2;
				if (num != 1)
				{
					_003Cindex_003E5__2 = 0;
					_003C_003E7__wrap2 = completionEndpoint.StreamCompletionEnumerableAsync(request).GetAsyncEnumerator(default(CancellationToken));
					_003C_003E7__wrap3 = null;
					num2 = 0;
					if (Kl2QblcKEisqXQlPPEF2 != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					goto IL_0165;
				}
				awaiter = _003C_003Eu__2;
				_003C_003Eu__2 = default(ValueTaskAwaiter);
				num = -1;
				_003C_003E1__state = -1;
				goto IL_0198;
				IL_019f:
				object obj = _003C_003E7__wrap3;
				if (obj != null)
				{
					ExceptionDispatchInfo.Capture((obj as Exception) ?? throw ((Exception)obj)).Throw();
				}
				_003C_003E7__wrap3 = null;
				_003C_003E7__wrap2 = null;
				goto end_IL_000e;
				IL_007d:
				try
				{
					if (num != 0)
					{
						goto IL_00cd;
					}
					ValueTaskAwaiter<bool> awaiter2 = _003C_003Eu__1;
					_003C_003Eu__1 = default(ValueTaskAwaiter<bool>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_00ec;
					IL_00cd:
					awaiter2 = _003C_003E7__wrap2.MoveNextAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter2;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_00ec;
					IL_00ec:
					if (awaiter2.GetResult())
					{
						CompletionResult current = _003C_003E7__wrap2.Current;
						resultHandler(_003Cindex_003E5__2++, current);
						goto IL_00cd;
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
						num2 = 1;
						if (Kl2QblcKEisqXQlPPEF2 == null)
						{
							goto IL_0165;
						}
						goto IL_0172;
					}
					goto IL_0198;
				}
				goto IL_019f;
				IL_0172:
				_003C_003E7__wrap4 = 0;
				goto IL_007d;
				IL_0198:
				awaiter.GetResult();
				goto IL_019f;
				IL_0165:
				switch (num2)
				{
				case 1:
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_0172;
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

		internal static bool kUvAX4cKGyFAF8XABHxL()
		{
			return Kl2QblcKEisqXQlPPEF2 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CStreamCompletionAsync_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CompletionEndpoint _003C_003E4__this;

		public CompletionRequest request;

		public Action<CompletionResult> resultHandler;

		private IAsyncEnumerator<CompletionResult> _003C_003E7__wrap1;

		private object _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private ValueTaskAwaiter<bool> _003C_003Eu__1;

		private ValueTaskAwaiter _003C_003Eu__2;

		private static object lRcSPEcK1aOK3IM7sG0a;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			CompletionEndpoint completionEndpoint = _003C_003E4__this;
			try
			{
				if (num != 0)
				{
					if (num == 1)
					{
						goto IL_015a;
					}
					_003C_003E7__wrap1 = completionEndpoint.StreamCompletionEnumerableAsync(request).GetAsyncEnumerator(default(CancellationToken));
					_003C_003E7__wrap2 = null;
					_003C_003E7__wrap3 = 0;
				}
				try
				{
					if (num != 0)
					{
						goto IL_0084;
					}
					ValueTaskAwaiter<bool> awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ValueTaskAwaiter<bool>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_00a3;
					IL_0084:
					awaiter = _003C_003E7__wrap1.MoveNextAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00a3;
					IL_00a3:
					if (awaiter.GetResult())
					{
						CompletionResult current = _003C_003E7__wrap1.Current;
						resultHandler(current);
						goto IL_0084;
					}
					if (EQS0iZcKKCNTb5wxi9vX())
					{
						switch (0)
						{
						}
					}
				}
				catch (Exception obj)
				{
					_003C_003E7__wrap2 = obj;
				}
				ValueTaskAwaiter awaiter2;
				if (_003C_003E7__wrap1 != null)
				{
					awaiter2 = _003C_003E7__wrap1.DisposeAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = 1;
						_003C_003E1__state = 1;
						_003C_003Eu__2 = awaiter2;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_0176;
				}
				goto IL_017d;
				IL_017d:
				object obj2 = _003C_003E7__wrap2;
				if (obj2 != null)
				{
					int num2 = 1;
					if (lRcSPEcK1aOK3IM7sG0a != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					case 1:
						goto IL_018b;
					}
					goto IL_015a;
				}
				goto IL_01a2;
				IL_018b:
				ExceptionDispatchInfo.Capture((obj2 as Exception) ?? throw ((Exception)obj2)).Throw();
				goto IL_01a2;
				IL_0176:
				awaiter2.GetResult();
				goto IL_017d;
				IL_015a:
				awaiter2 = _003C_003Eu__2;
				_003C_003Eu__2 = default(ValueTaskAwaiter);
				num = -1;
				_003C_003E1__state = -1;
				goto IL_0176;
				IL_01a2:
				_003C_003E7__wrap2 = null;
				_003C_003E7__wrap1 = null;
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

		internal static bool EQS0iZcKKCNTb5wxi9vX()
		{
			return lRcSPEcK1aOK3IM7sG0a == null;
		}
	}

	[CompilerGenerated]
	private CompletionRequest pCpcjM4uoV = new CompletionRequest
	{
		Model = Model.DefaultModel
	};

	internal static CompletionEndpoint AM5ATQaKOFuX3iJx99F;

	public CompletionRequest DefaultCompletionRequestArgs
	{
		[CompilerGenerated]
		get
		{
			return pCpcjM4uoV;
		}
		[CompilerGenerated]
		set
		{
			pCpcjM4uoV = value;
		}
	}

	protected override string Endpoint => "completions";

	internal CompletionEndpoint(OpenAIAPI api)
		: base(api)
	{
	}

	[AsyncStateMachine(typeof(_003CCreateCompletionAsync_003Ed__7))]
	public Task<CompletionResult> CreateCompletionAsync(CompletionRequest request)
	{
		_003CCreateCompletionAsync_003Ed__7 stateMachine = default(_003CCreateCompletionAsync_003Ed__7);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<CompletionResult>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.request = request;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public Task<CompletionResult> CreateCompletionsAsync(CompletionRequest request, int numOutputs = 5)
	{
		request.NumChoicesPerPrompt = numOutputs;
		return CreateCompletionAsync(request);
	}

	public Task<CompletionResult> CreateCompletionAsync(string prompt, Model model = null, int? max_tokens = null, double? temperature = null, double? top_p = null, int? numOutputs = null, double? presencePenalty = null, double? frequencyPenalty = null, int? logProbs = null, bool? echo = null, params string[] stopSequences)
	{
		CompletionRequest request = new CompletionRequest(DefaultCompletionRequestArgs)
		{
			Prompt = prompt,
			Model = (model ?? ((Model)DefaultCompletionRequestArgs.Model)),
			MaxTokens = (max_tokens ?? DefaultCompletionRequestArgs.MaxTokens),
			Temperature = (temperature ?? DefaultCompletionRequestArgs.Temperature),
			TopP = (top_p ?? DefaultCompletionRequestArgs.TopP),
			NumChoicesPerPrompt = (numOutputs ?? DefaultCompletionRequestArgs.NumChoicesPerPrompt),
			PresencePenalty = (presencePenalty ?? DefaultCompletionRequestArgs.PresencePenalty),
			FrequencyPenalty = (frequencyPenalty ?? DefaultCompletionRequestArgs.FrequencyPenalty),
			Logprobs = (logProbs ?? DefaultCompletionRequestArgs.Logprobs),
			Echo = (echo ?? DefaultCompletionRequestArgs.Echo),
			MultipleStopSequences = (stopSequences ?? DefaultCompletionRequestArgs.MultipleStopSequences)
		};
		return CreateCompletionAsync(request);
	}

	public Task<CompletionResult> CreateCompletionAsync(params string[] prompts)
	{
		CompletionRequest request = new CompletionRequest(DefaultCompletionRequestArgs)
		{
			MultiplePrompts = prompts
		};
		return CreateCompletionAsync(request);
	}

	[AsyncStateMachine(typeof(_003CStreamCompletionAsync_003Ed__11))]
	public Task StreamCompletionAsync(CompletionRequest request, Action<int, CompletionResult> resultHandler)
	{
		_003CStreamCompletionAsync_003Ed__11 stateMachine = default(_003CStreamCompletionAsync_003Ed__11);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.request = request;
		stateMachine.resultHandler = resultHandler;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CStreamCompletionAsync_003Ed__12))]
	public Task StreamCompletionAsync(CompletionRequest request, Action<CompletionResult> resultHandler)
	{
		_003CStreamCompletionAsync_003Ed__12 stateMachine = default(_003CStreamCompletionAsync_003Ed__12);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.request = request;
		stateMachine.resultHandler = resultHandler;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public IAsyncEnumerable<CompletionResult> StreamCompletionEnumerableAsync(CompletionRequest request)
	{
		request = new CompletionRequest(request)
		{
			Stream = true
		};
		return HttpStreamingRequest<CompletionResult>(base.Url, HttpMethod.Post, request);
	}

	public IAsyncEnumerable<CompletionResult> StreamCompletionEnumerableAsync(string prompt, Model model = null, int? max_tokens = null, double? temperature = null, double? top_p = null, int? numOutputs = null, double? presencePenalty = null, double? frequencyPenalty = null, int? logProbs = null, bool? echo = null, params string[] stopSequences)
	{
		CompletionRequest request = new CompletionRequest(DefaultCompletionRequestArgs)
		{
			Prompt = prompt,
			Model = (model ?? ((Model)DefaultCompletionRequestArgs.Model)),
			MaxTokens = (max_tokens ?? DefaultCompletionRequestArgs.MaxTokens),
			Temperature = (temperature ?? DefaultCompletionRequestArgs.Temperature),
			TopP = (top_p ?? DefaultCompletionRequestArgs.TopP),
			NumChoicesPerPrompt = (numOutputs ?? DefaultCompletionRequestArgs.NumChoicesPerPrompt),
			PresencePenalty = (presencePenalty ?? DefaultCompletionRequestArgs.PresencePenalty),
			FrequencyPenalty = (frequencyPenalty ?? DefaultCompletionRequestArgs.FrequencyPenalty),
			Logprobs = (logProbs ?? DefaultCompletionRequestArgs.Logprobs),
			Echo = (echo ?? DefaultCompletionRequestArgs.Echo),
			MultipleStopSequences = (stopSequences ?? DefaultCompletionRequestArgs.MultipleStopSequences),
			Stream = true
		};
		return StreamCompletionEnumerableAsync(request);
	}

	[AsyncStateMachine(typeof(_003CCreateAndFormatCompletion_003Ed__15))]
	public Task<string> CreateAndFormatCompletion(CompletionRequest request)
	{
		_003CCreateAndFormatCompletion_003Ed__15 stateMachine = default(_003CCreateAndFormatCompletion_003Ed__15);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.request = request;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CGetCompletion_003Ed__16))]
	public Task<string> GetCompletion(string prompt)
	{
		_003CGetCompletion_003Ed__16 stateMachine = default(_003CGetCompletion_003Ed__16);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.prompt = prompt;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	internal static bool nY2dKHaBiBO3PCiRTTD()
	{
		return AM5ATQaKOFuX3iJx99F == null;
	}
}
