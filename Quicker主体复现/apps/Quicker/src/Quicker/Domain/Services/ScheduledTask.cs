using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cronos;

namespace Quicker.Domain.Services;

public class ScheduledTask
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass3_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct j9XPIKk5UeMOxjs8iG5 : IAsyncStateMachine
		{
			public int Ihy2RNwRrZd;

			public AsyncTaskMethodBuilder mD62RJf6Iyx;

			public _003C_003Ec__DisplayClass3_0 n0r2R0sOjsf;

			private DateTimeOffset? ccu2RCmODEb;

			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter Oj32RPVyqTh;

			private static object iNQPtYyuYQ5UjFPGobsB;

			private void MoveNext()
			{
				int num = Ihy2RNwRrZd;
				_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = n0r2R0sOjsf;
				try
				{
					if (num != 0)
					{
						goto IL_004f;
					}
					ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter = Oj32RPVyqTh;
					Oj32RPVyqTh = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					Ihy2RNwRrZd = -1;
					goto IL_00f1;
					IL_004f:
					TimeSpan timeSpan;
					if (!_003C_003Ec__DisplayClass3_.BIRv5hGuKAA.IsCancellationRequested)
					{
						ccu2RCmODEb = _003C_003Ec__DisplayClass3_.Db4v59v4pca.GetNextOccurrence(DateTimeOffset.Now.AddSeconds(0.5), TimeZoneInfo.Local);
						if (ccu2RCmODEb.HasValue)
						{
							timeSpan = ccu2RCmODEb.Value - DateTimeOffset.Now;
							goto IL_00b0;
						}
					}
					goto end_IL_000e;
					IL_00f1:
					awaiter.GetResult();
					timeSpan = ccu2RCmODEb.Value - DateTimeOffset.Now;
					goto IL_00b0;
					IL_00b0:
					if (timeSpan.TotalMilliseconds <= 0.0)
					{
						if (!_003C_003Ec__DisplayClass3_.BIRv5hGuKAA.IsCancellationRequested)
						{
							_003C_003Ec__DisplayClass3_.kWhv5e0d58J.DLwtxK4SI1d();
						}
						goto IL_004f;
					}
					awaiter = njdtxXZn3uf((long)timeSpan.TotalMilliseconds, _003C_003Ec__DisplayClass3_.BIRv5hGuKAA).ConfigureAwait(true).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						Ihy2RNwRrZd = 0;
						Oj32RPVyqTh = awaiter;
						mD62RJf6Iyx.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00f1;
					end_IL_000e:;
				}
				catch (Exception exception)
				{
					Ihy2RNwRrZd = -2;
					mD62RJf6Iyx.SetException(exception);
					return;
				}
				Ihy2RNwRrZd = -2;
				mD62RJf6Iyx.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				mD62RJf6Iyx.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			static j9XPIKk5UeMOxjs8iG5()
			{
			}

			internal static bool sOo19Ryu8mqPDP45ZrrZ()
			{
				return iNQPtYyuYQ5UjFPGobsB == null;
			}

			internal static void KqHuEuyugbJnppc5pyeY()
			{
			}
		}

		public CronExpression Db4v59v4pca;

		public CancellationToken BIRv5hGuKAA;

		public ScheduledTask kWhv5e0d58J;

		private static _003C_003Ec__DisplayClass3_0 K3DDR7WFdNhIF2QRfh7J;

		[AsyncStateMachine(typeof(j9XPIKk5UeMOxjs8iG5))]
		internal Task RXLv5Z8dAl0()
		{
			j9XPIKk5UeMOxjs8iG5 stateMachine = default(j9XPIKk5UeMOxjs8iG5);
			stateMachine.mD62RJf6Iyx = AsyncTaskMethodBuilder.Create();
			stateMachine.n0r2R0sOjsf = this;
			stateMachine.Ihy2RNwRrZd = -1;
			stateMachine.mD62RJf6Iyx.Start(ref stateMachine);
			return stateMachine.mD62RJf6Iyx.Task;
		}

		internal static bool kJx7maWFOlFhfi4J5CMh()
		{
			return K3DDR7WFdNhIF2QRfh7J == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDelay_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public long delay;

		public CancellationToken ct;

		private int _003CcurrentDelay_003E5__2;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object tDGTwkWFkOaS5hr0dMTl;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			try
			{
				if (num != 0)
				{
					int num2 = 0;
					if (tDGTwkWFkOaS5hr0dMTl != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
					goto IL_00c8;
				}
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter = _003C_003Eu__1;
				_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
				num = -1;
				_003C_003E1__state = -1;
				goto IL_0049;
				IL_00c8:
				if (delay > 0L && !ct.IsCancellationRequested)
				{
					_003CcurrentDelay_003E5__2 = (int)((delay > 2147483647L) ? int.MaxValue : delay);
					awaiter = Task.Delay(_003CcurrentDelay_003E5__2, ct).ConfigureAwait(true).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0049;
				}
				goto end_IL_0008;
				IL_0049:
				awaiter.GetResult();
				delay -= _003CcurrentDelay_003E5__2;
				goto IL_00c8;
				end_IL_0008:;
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

		internal static bool RAn4huWFajhu6r5Ly8AG()
		{
			return tDGTwkWFkOaS5hr0dMTl == null;
		}
	}

	private readonly string Eo7txm0yIcn;

	private readonly Action DLwtxK4SI1d;

	private static ScheduledTask C3NKfxQN10gubNVcOIOj;

	public ScheduledTask(string expression, Action callback)
	{
		Eo7txm0yIcn = expression.Trim();
		DLwtxK4SI1d = callback;
	}

	public void Start(CancellationToken ct)
	{
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
		_003C_003Ec__DisplayClass3_.BIRv5hGuKAA = ct;
		_003C_003Ec__DisplayClass3_.kWhv5e0d58J = this;
		CronFormat format = ((Eo7txm0yIcn.Split(' ').Length != 5) ? CronFormat.IncludeSeconds : CronFormat.Standard);
		_003C_003Ec__DisplayClass3_.Db4v59v4pca = CronExpression.Parse(Eo7txm0yIcn, format);
		Task.Factory.StartNew((Func<Task>)_003C_003Ec__DisplayClass3_.RXLv5Z8dAl0, _003C_003Ec__DisplayClass3_.BIRv5hGuKAA, TaskCreationOptions.LongRunning, TaskScheduler.Default);
	}

	[AsyncStateMachine(typeof(_003CDelay_003Ed__4))]
	private static Task njdtxXZn3uf(long long_0, CancellationToken cancellationToken_0)
	{
		_003CDelay_003Ed__4 stateMachine = default(_003CDelay_003Ed__4);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine.delay = long_0;
		stateMachine.ct = cancellationToken_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	internal static bool aO1MKdQNK5uCILf3alHo()
	{
		return C3NKfxQN10gubNVcOIOj == null;
	}
}
