using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using soLGR8XA95f82ljopSU;

namespace Quicker.Public;

public class CloudState
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CReadTextAsync_003Ed__1 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public string key;

		public double timeoutSeconds;

		private TaskAwaiter<(bool isSuccess, string dataOrErrMessage, string errorCode)> _003C_003Eu__1;

		private static object UuJ07PcrxYrY7Y2af2t8;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			string item;
			try
			{
				TaskAwaiter<(bool, string, string)> awaiter;
				if (num != 0)
				{
					awaiter = oHyR5LX5l5qeapYlxI6.zustHvQuASd(key, timeoutSeconds).GetAwaiter();
					if (UuJ07PcrxYrY7Y2af2t8 != null)
					{
						switch (0)
						{
						}
					}
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
					_003C_003Eu__1 = default(TaskAwaiter<(bool, string, string)>);
					num = -1;
					_003C_003E1__state = -1;
				}
				(bool, string, string) result = awaiter.GetResult();
				if (!result.Item1)
				{
					throw new Exception(result.Item2);
				}
				item = result.Item2;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(item);
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

		internal static bool jBclyAcrI5GKXgIBvYqe()
		{
			return UuJ07PcrxYrY7Y2af2t8 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSaveTextAsync_003Ed__0 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public string key;

		public string value;

		public double timeoutSeconds;

		private TaskAwaiter _003C_003Eu__1;

		private static object dvqX4PcrtMYG8CPHnMOI;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = oHyR5LX5l5qeapYlxI6.PmftHLHo6Ui(key, value, timeoutSeconds, null).GetAwaiter();
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
					int num2 = 0;
					if (!qVTc1GcrScR4PEvf6j3E())
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
				}
				awaiter.GetResult();
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

		internal static bool qVTc1GcrScR4PEvf6j3E()
		{
			return dvqX4PcrtMYG8CPHnMOI == null;
		}
	}

	private static CloudState JhyjnR6Hr1SXDIEWIoi;

	[AsyncStateMachine(typeof(_003CSaveTextAsync_003Ed__0))]
	public Task SaveTextAsync(string key, string value, double timeoutSeconds = 2.5)
	{
		_003CSaveTextAsync_003Ed__0 stateMachine = default(_003CSaveTextAsync_003Ed__0);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine.key = key;
		stateMachine.value = value;
		stateMachine.timeoutSeconds = timeoutSeconds;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CReadTextAsync_003Ed__1))]
	public Task<string> ReadTextAsync(string key, double timeoutSeconds = 2.5)
	{
		_003CReadTextAsync_003Ed__1 stateMachine = default(_003CReadTextAsync_003Ed__1);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine.key = key;
		stateMachine.timeoutSeconds = timeoutSeconds;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	internal static bool BPgKwU6zrr1x3Tmpvp3()
	{
		return JhyjnR6Hr1SXDIEWIoi == null;
	}
}
