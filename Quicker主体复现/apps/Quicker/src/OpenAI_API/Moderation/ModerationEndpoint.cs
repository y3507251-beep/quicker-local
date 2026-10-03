using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using OpenAI_API.Models;

namespace OpenAI_API.Moderation;

public class ModerationEndpoint : EndpointBase, IModerationEndpoint
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCallModerationAsync_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ModerationResult> _003C_003Et__builder;

		public string input;

		public ModerationEndpoint _003C_003E4__this;

		private TaskAwaiter<ModerationResult> _003C_003Eu__1;

		private static object X620Svc0za4cE88WqpoF;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ModerationEndpoint moderationEndpoint = _003C_003E4__this;
			ModerationResult result;
			try
			{
				TaskAwaiter<ModerationResult> awaiter;
				if (num != 0)
				{
					ModerationRequest request = new ModerationRequest(input, moderationEndpoint.DefaultModerationRequestArgs.Model);
					awaiter = moderationEndpoint.CallModerationAsync(request).GetAwaiter();
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
					_003C_003Eu__1 = default(TaskAwaiter<ModerationResult>);
					num = -1;
					_003C_003E1__state = -1;
					int num2 = 0;
					if (X620Svc0za4cE88WqpoF != null)
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

		internal static bool R1dAvyc1V2NJnCW7cJg5()
		{
			return X620Svc0za4cE88WqpoF == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCallModerationAsync_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ModerationResult> _003C_003Et__builder;

		public ModerationEndpoint _003C_003E4__this;

		public ModerationRequest request;

		private TaskAwaiter<ModerationResult> _003C_003Eu__1;

		private static object yrufhWc1FMLUiEm302xP;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ModerationEndpoint moderationEndpoint = _003C_003E4__this;
			ModerationResult result;
			try
			{
				TaskAwaiter<ModerationResult> awaiter;
				if (num != 0)
				{
					awaiter = moderationEndpoint.xm2qSnuXRK<ModerationResult>(null, request).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						if (yrufhWc1FMLUiEm302xP != null)
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
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
					_003C_003Eu__1 = default(TaskAwaiter<ModerationResult>);
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

		internal static bool LBI85Fc1cMDfqhP6o7oV()
		{
			return yrufhWc1FMLUiEm302xP == null;
		}
	}

	[CompilerGenerated]
	private ModerationRequest omAqelP4Yn = new ModerationRequest
	{
		Model = Model.TextModerationLatest
	};

	internal static ModerationEndpoint KnDAvNkQ2ntFftrSIPu;

	public ModerationRequest DefaultModerationRequestArgs
	{
		[CompilerGenerated]
		get
		{
			return omAqelP4Yn;
		}
		[CompilerGenerated]
		set
		{
			omAqelP4Yn = value;
		}
	}

	protected override string Endpoint => "moderations";

	internal ModerationEndpoint(OpenAIAPI api)
		: base(api)
	{
	}

	[AsyncStateMachine(typeof(_003CCallModerationAsync_003Ed__7))]
	public Task<ModerationResult> CallModerationAsync(string input)
	{
		_003CCallModerationAsync_003Ed__7 stateMachine = default(_003CCallModerationAsync_003Ed__7);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ModerationResult>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.input = input;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CCallModerationAsync_003Ed__8))]
	public Task<ModerationResult> CallModerationAsync(ModerationRequest request)
	{
		_003CCallModerationAsync_003Ed__8 stateMachine = default(_003CCallModerationAsync_003Ed__8);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ModerationResult>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.request = request;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	internal static bool XL6HYekFTR4lhp7bQpY()
	{
		return KnDAvNkQ2ntFftrSIPu == null;
	}
}
