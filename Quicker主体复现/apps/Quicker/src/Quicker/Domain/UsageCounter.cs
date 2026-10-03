using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using IgQBbvXMVdsN7GVNUxX;
using J7BsCmjJgKtd6cIAc1p;
using log4net;
using Quicker.Common;
using Quicker.Common.Entities;
using Quicker.Domain.Services;
using Quicker.Utilities;

namespace Quicker.Domain;

public class UsageCounter
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003CPublicTimer_Tick_003Eb__45_0_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UsageCounter _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object Q1vbxGcITQeTyfO3FVqw;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			UsageCounter usageCounter = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = usageCounter.s4xt8Us8O49(false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						if (!S5cSuscImpPlVePixGmb())
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

		internal static bool S5cSuscImpPlVePixGmb()
		{
			return Q1vbxGcITQeTyfO3FVqw == null;
		}
	}

	private static readonly ILog cMwtau7RUYG;

	private readonly SQLDataMgr oVOtaNImM93;

	[CompilerGenerated]
	private UsageSession aEhtaJVxrsF = new UsageSession();

	[CompilerGenerated]
	private bool bJQta0C0xQi;

	[CompilerGenerated]
	private bool iJntaCUYagQ;

	private object aFjtaPDkwyN = new object();

	private long ymItaEWnx6R;

	private long fD0tayqmE4X;

	internal static UsageCounter rnnsGrQEILZ8LKOJ7B17;

	public UsageCounter(SQLDataMgr sqlDataMgr)
	{
		oVOtaNImM93 = sqlDataMgr;
		AppState.U1Lta5Cv1Ft(this);
		sPTt8OGGwuW();
	}

	[SpecialName]
	[CompilerGenerated]
	private UsageSession Od3t8fUs2EL()
	{
		return aEhtaJVxrsF;
	}

	[SpecialName]
	[CompilerGenerated]
	private void b0Ft8zF7IF7(UsageSession value)
	{
		aEhtaJVxrsF = value;
	}

	[SpecialName]
	[CompilerGenerated]
	private bool g3dtatPA69L()
	{
		return bJQta0C0xQi;
	}

	[SpecialName]
	[CompilerGenerated]
	private void wketag2wwHe(bool value)
	{
		bJQta0C0xQi = value;
	}

	[SpecialName]
	[CompilerGenerated]
	private bool Y5qtavZX7Xk()
	{
		return iJntaCUYagQ;
	}

	[SpecialName]
	[CompilerGenerated]
	private void hyrtaSLQjYl(bool value)
	{
		iJntaCUYagQ = value;
	}

	public void CountActionClick(ActionItem action)
	{
		if (action != null)
		{
			cQmt8Mey8ZZ(action.Id, action.TemplateId);
		}
	}

	public void CountOperation(string operation)
	{
		cQmt8Mey8ZZ(operation, null);
	}

	public void CountPopup()
	{
		Od3t8fUs2EL().PopupCount++;
	}

	public void CountCircleMenu()
	{
		CountOperation("be1ec1a6-bd93-4ba4-a9cd-d633147b24c9");
	}

	public void CountGesture()
	{
		CountOperation("dc2b8c82-1d9a-4992-a31b-4dc59d60e758");
	}

	public void CountPowerKey()
	{
		CountOperation("0bbac09b-0638-42cc-a1fc-89e54d46d2f1");
	}

	public void CountTextCommand()
	{
		CountOperation("a8653108-7119-4d22-af4a-b2011d8c1c34");
	}

	public void CountSelectPlus()
	{
		CountOperation("37d319ff-2556-43d7-ad8b-308b022daae8");
	}

	public void CountFloatButton()
	{
		CountOperation("c7afdc90-849f-45d9-9695-080c0c89c670");
	}

	public void CountFloatProfile()
	{
		CountOperation("05dc2fad-9ae0-4191-bdd7-700e60e161a8");
	}

	public void CountTextFloater()
	{
		CountOperation("69c1f6a5-5f18-49ec-8763-01fc39217307");
	}

	public void CountSearch()
	{
		CountOperation("56f7fc59-caaa-4deb-8c3a-2531b326808c");
	}

	public void CountDbClick()
	{
		CountOperation("49745cc1-52dc-46fd-ad2a-ba5a7f588368");
	}

	public void CountHotkeyWatcher()
	{
		CountOperation("0c0a7ed2-eeeb-4d8e-8a43-1cc068dc5cb0");
	}

	public void CountPushService()
	{
		CountOperation("f37a4b55-8e9f-43a6-8a4e-2b067cda9e13");
	}

	public void CountExternalLaunch()
	{
		CountOperation("8b8ba8cd-9dc1-46b8-9923-48a82e152df6");
	}

	public void CountHotkey()
	{
		CountOperation("f2c0f712-2966-46fe-be7b-e00850e79e99");
	}

	public void CountAutoRun()
	{
		CountOperation("b6235217-b17f-4d25-9206-73657977d01a");
	}

	public void CountEventTrigger()
	{
		CountOperation("f1ff1e30-86f7-4e9d-8336-5d0ba8af2524");
	}

	public void CountAdvancedMouseAction()
	{
		CountOperation("fb8cec84-b07c-4852-92f6-4bdcbc1860ba");
	}

	public void CountMobileMessage(int messageType)
	{
		if (Od3t8fUs2EL().MobileMessageCounts.ContainsKey(messageType))
		{
			Od3t8fUs2EL().MobileMessageCounts[messageType]++;
		}
		else
		{
			Od3t8fUs2EL().MobileMessageCounts[messageType] = 1;
		}
	}

	private void Reset()
	{
		b0Ft8zF7IF7(new UsageSession());
		wketag2wwHe(false);
		hyrtaSLQjYl(false);
		oVOtaNImM93.wcDtrLXGlFA(Od3t8fUs2EL());
	}

	private UsageSession NCot8T4Wlov()
	{
		return Od3t8fUs2EL();
	}

	private void cQmt8Mey8ZZ(string string_0, string string_1)
	{
		if (!string.IsNullOrEmpty(string_0))
		{
			wketag2wwHe(true);
			hyrtaSLQjYl(true);
			string key = (string.IsNullOrEmpty(string_1) ? string_0 : (string_0 + ":" + string_1));
			if (Od3t8fUs2EL().ActionClickCounts.ContainsKey(key))
			{
				Od3t8fUs2EL().ActionClickCounts[key]++;
			}
			else
			{
				Od3t8fUs2EL().ActionClickCounts[key] = 1;
			}
			Od3t8fUs2EL().LocalTime = DateTime.Now;
			int num = 0;
			if (rnnsGrQEILZ8LKOJ7B17 != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
	}

	private void Mpqt8ALCs8Q()
	{
		bool lockTaken = false;
		try
		{
			Monitor.TryEnter(aFjtaPDkwyN, 0, ref lockTaken);
			if (lockTaken)
			{
				oVOtaNImM93.wcDtrLXGlFA(Od3t8fUs2EL());
			}
		}
		catch (Exception ex)
		{
			cMwtau7RUYG.Warn("保存Usage到db出错：" + ex.Message, ex);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(aFjtaPDkwyN);
			}
		}
	}

	public void UpdateUpdateTime()
	{
		Od3t8fUs2EL().LastUpdateTimeUtc = AppHelper.GetUtcNowForDb();
	}

	private void sPTt8OGGwuW()
	{
		OeTcebjK6vK0y2ZOMOQ.pUhtkmFk1ed().fEBtkx60uw0(qNXt8Fv42R3);
	}

	private void qNXt8Fv42R3(object object_1, long long_2)
	{
		if (ymItaEWnx6R == 0L)
		{
			fD0tayqmE4X = long_2;
			ymItaEWnx6R = long_2;
			return;
		}
		if (long_2 - ymItaEWnx6R > 5000L)
		{
			ymItaEWnx6R = long_2;
			if (Y5qtavZX7Xk())
			{
				Mpqt8ALCs8Q();
				if (uYtgLvQE6drFAt4rPQmX())
				{
					switch (0)
					{
					}
				}
			}
			hyrtaSLQjYl(false);
		}
		if (long_2 - fD0tayqmE4X > AppState.DataService.w8Qtm66XINE() * 1000)
		{
			fD0tayqmE4X = long_2;
			if (g3dtatPA69L())
			{
				Task.Run((Func<Task>)FKWt8iNqQq6);
			}
		}
	}

	
	private Task s4xt8Us8O49(bool bool_2)
	{ Mpqt8ALCs8Q(); return Task.CompletedTask; }

	internal void loDt8lkCi0B()
	{ /* 使用统计保留在本地，不上传上次会话。 */ }

	static UsageCounter()
	{
		cMwtau7RUYG = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	[AsyncStateMachine(typeof(_003C_003CPublicTimer_Tick_003Eb__45_0_003Ed))]
	[CompilerGenerated]
	private Task FKWt8iNqQq6()
	{
		_003C_003CPublicTimer_Tick_003Eb__45_0_003Ed stateMachine = default(_003C_003CPublicTimer_Tick_003Eb__45_0_003Ed);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[CompilerGenerated]
	
	private Task rP3t83dAmG2()
	{ return Task.CompletedTask; }

	internal static bool uYtgLvQE6drFAt4rPQmX()
	{
		return rnnsGrQEILZ8LKOJ7B17 == null;
	}
}
