using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using CSScriptLibrary;
using DFK6LN7Z1wFZUIPV1pL;
using kdYE4iocjIn6rpkyuGS;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Actions.X.SubPrograms;
using Quicker.Public;
using Quicker.Public.Extensions;
using Quicker.Utilities.DataStructure;

namespace kUOHHboesKGXLZGeqkc;

internal class XqGiuUobZu5L8YTDYUu : ICustomWindowContext
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDataContextOnMapChanged_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public XqGiuUobZu5L8YTDYUu _003C_003E4__this;

		public IMapChangedEventArgs<string> eventArgs;

		private IEnumerator<string> _003C_003E7__wrap1;

		private TaskAwaiter<bool> _003C_003Eu__1;

		internal static object vom0SaWb1aG5mVjvydNW;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			XqGiuUobZu5L8YTDYUu xqGiuUobZu5L8YTDYUu = _003C_003E4__this;
			try
			{
				if (num == 0)
				{
					goto IL_0071;
				}
				if (xqGiuUobZu5L8YTDYUu.zcYg6KwXdgj())
				{
					if (vom0SaWb1aG5mVjvydNW != null)
					{
						switch (0)
						{
						}
					}
					xqGiuUobZu5L8YTDYUu.EATg6XdFpbc()[eventArgs.Key] = string.Empty;
					if (xqGiuUobZu5L8YTDYUu.JlMg6dBqTs1().HasData())
					{
						_003C_003E7__wrap1 = xqGiuUobZu5L8YTDYUu.JlMg6dBqTs1().GetEnumerator();
						goto IL_0071;
					}
				}
				goto end_IL_000e;
				IL_0071:
				try
				{
					if (num != 0)
					{
						goto IL_00cf;
					}
					TaskAwaiter<bool> awaiter = _003C_003Eu__1;
					int num2 = 0;
					if (vom0SaWb1aG5mVjvydNW != null)
					{
						goto IL_008b;
					}
					goto IL_0126;
					IL_00de:
					string current;
					string text;
					string string_ = current.Substring(text.Length);
					awaiter = k76Lmfo1B5RyIdJCx7F.YsegXyoCf1a(xqGiuUobZu5L8YTDYUu.Window, string_, xqGiuUobZu5L8YTDYUu, null, null, null).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_010d;
					IL_008b:
					_003C_003Eu__1 = default(TaskAwaiter<bool>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_010d;
					IL_010d:
					awaiter.GetResult();
					goto IL_00cf;
					IL_00cf:
					while (_003C_003E7__wrap1.MoveNext())
					{
						current = _003C_003E7__wrap1.Current;
						text = eventArgs.Key + ".change:";
						if (!current.StartsWith(text))
						{
							continue;
						}
						goto IL_00de;
					}
					num2 = 1;
					if (!fvjQsiWbKL07StIT2t30())
					{
						int num3 = default(int);
						num2 = num3;
					}
					goto IL_0126;
					IL_0126:
					switch (num2)
					{
					case 1:
						goto end_IL_0071;
					}
					goto IL_008b;
					end_IL_0071:;
				}
				finally
				{
					if (num < 0 && _003C_003E7__wrap1 != null)
					{
						_003C_003E7__wrap1.Dispose();
					}
				}
				_003C_003E7__wrap1 = null;
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

		internal static bool fvjQsiWbKL07StIT2t30()
		{
			return vom0SaWb1aG5mVjvydNW == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRunSpAsync_003Ed__47 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IDictionary<string, object>> _003C_003Et__builder;

		public string spName;

		public IDictionary<string, object> inputParams;

		public XqGiuUobZu5L8YTDYUu _003C_003E4__this;

		private TaskAwaiter<IDictionary<string, object>> _003C_003Eu__1;

		internal static object sOfe83Wbvw8dIFTYfxv4;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			XqGiuUobZu5L8YTDYUu xqGiuUobZu5L8YTDYUu = _003C_003E4__this;
			IDictionary<string, object> result;
			try
			{
				TaskAwaiter<IDictionary<string, object>> awaiter;
				if (num != 0)
				{
					if (!KF0RXNWbdpRd8u5I4pCb())
					{
						switch (0)
						{
						}
					}
					awaiter = SubProgramHelper.RunStandaloneSubprogram(spName, inputParams ?? new Dictionary<string, object>(), xqGiuUobZu5L8YTDYUu.W7dg64nQN4C(), xqGiuUobZu5L8YTDYUu.Window).GetAwaiter();
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
					_003C_003Eu__1 = default(TaskAwaiter<IDictionary<string, object>>);
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

		internal static bool KF0RXNWbdpRd8u5I4pCb()
		{
			return sOfe83Wbvw8dIFTYfxv4 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRunSpAsync_003Ed__48 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IDictionary<string, object>> _003C_003Et__builder;

		public string spName;

		public object inputParams;

		public XqGiuUobZu5L8YTDYUu _003C_003E4__this;

		private TaskAwaiter<IDictionary<string, object>> _003C_003Eu__1;

		private static object LlDqoPWbJOlt9Sj60Epf;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			XqGiuUobZu5L8YTDYUu xqGiuUobZu5L8YTDYUu = _003C_003E4__this;
			IDictionary<string, object> result;
			try
			{
				TaskAwaiter<IDictionary<string, object>> awaiter;
				if (num != 0)
				{
					awaiter = SubProgramHelper.RunStandaloneSubprogram(spName, inputParams.ToDictionary(), xqGiuUobZu5L8YTDYUu.W7dg64nQN4C(), xqGiuUobZu5L8YTDYUu.Window).GetAwaiter();
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
					_003C_003Eu__1 = default(TaskAwaiter<IDictionary<string, object>>);
					int num2 = 0;
					if (!MYsRhjWbktqKorw2gkyp())
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
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

		internal static bool MYsRhjWbktqKorw2gkyp()
		{
			return LlDqoPWbJOlt9Sj60Epf == null;
		}
	}

	[CompilerGenerated]
	private readonly dq4x8l7K0ljN23sem9d<string, object> Wf4g63uqVXI = new dq4x8l7K0ljN23sem9d<string, object>();

	[CompilerGenerated]
	private readonly IDictionary<string, ActionVariable> qSwg6fBT1pM = new Dictionary<string, ActionVariable>();

	[CompilerGenerated]
	private IList<KeyValuePair<string, string>> owog6zkyhUo = new List<KeyValuePair<string, string>>();

	[CompilerGenerated]
	private readonly IDictionary<string, string> PoWgXwmbjZ9 = new Dictionary<string, string>();

	[CompilerGenerated]
	private bool OgggXttcHIC;

	[CompilerGenerated]
	private string SkYgXgRoeuL = string.Empty;

	[CompilerGenerated]
	private string PjJgXLg16Gd;

	[CompilerGenerated]
	private ActionExecuteContext vSygXvJSU9o;

	[CompilerGenerated]
	private IList<string> gCagXST6nOm;

	[CompilerGenerated]
	private string onOgX2Scjoo;

	[CompilerGenerated]
	private MethodDelegate<bool> TMSgXuAnEk3;

	[CompilerGenerated]
	private Window JYQgXNoN4AS;

	private static XqGiuUobZu5L8YTDYUu UHf60FQCxMGLCiUSOWgF;

	public dq4x8l7K0ljN23sem9d<string, object> DataContext
	{
		[CompilerGenerated]
		get
		{
			return Wf4g63uqVXI;
		}
	}

	public string Result
	{
		[CompilerGenerated]
		get
		{
			return SkYgXgRoeuL;
		}
		[CompilerGenerated]
		set
		{
			SkYgXgRoeuL = value;
		}
	}

	public string ErrorMessage
	{
		[CompilerGenerated]
		get
		{
			return onOgX2Scjoo;
		}
		[CompilerGenerated]
		set
		{
			onOgX2Scjoo = value;
		}
	}

	public Window Window
	{
		[CompilerGenerated]
		get
		{
			return JYQgXNoN4AS;
		}
		[CompilerGenerated]
		set
		{
			JYQgXNoN4AS = value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public IDictionary<string, ActionVariable> bv0g6skIh4g()
	{
		return qSwg6fBT1pM;
	}

	[SpecialName]
	[CompilerGenerated]
	public IList<KeyValuePair<string, string>> j54g61YwXs2()
	{
		return owog6zkyhUo;
	}

	[SpecialName]
	[CompilerGenerated]
	public void Qw2g6bIB5xQ(IList<KeyValuePair<string, string>> ilist_2)
	{
		owog6zkyhUo = ilist_2;
	}

	public XqGiuUobZu5L8YTDYUu()
	{
		DataContext.MapChanged += KEOg6k7k1IS;
	}

	[AsyncStateMachine(typeof(_003CDataContextOnMapChanged_003Ed__11))]
	private void KEOg6k7k1IS(IObservableMap<string, object> iobservableMap_0, IMapChangedEventArgs<string> imapChangedEventArgs_0)
	{
		_003CDataContextOnMapChanged_003Ed__11 stateMachine = default(_003CDataContextOnMapChanged_003Ed__11);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.eventArgs = imapChangedEventArgs_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[SpecialName]
	[CompilerGenerated]
	public IDictionary<string, string> EATg6XdFpbc()
	{
		return PoWgXwmbjZ9;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool zcYg6KwXdgj()
	{
		return OgggXttcHIC;
	}

	[SpecialName]
	[CompilerGenerated]
	public void NO0g6xRti1h(bool bool_1)
	{
		OgggXttcHIC = bool_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public string IBGg6Qg16xN()
	{
		return PjJgXLg16Gd;
	}

	[SpecialName]
	[CompilerGenerated]
	public void ykOg6jtSoFG(string string_2)
	{
		PjJgXLg16Gd = string_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public ActionExecuteContext W7dg64nQN4C()
	{
		return vSygXvJSU9o;
	}

	[SpecialName]
	[CompilerGenerated]
	public void bgyg65HO2jc(ActionExecuteContext actionExecuteContext_1)
	{
		vSygXvJSU9o = actionExecuteContext_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public IList<string> JlMg6dBqTs1()
	{
		return gCagXST6nOm;
	}

	[SpecialName]
	[CompilerGenerated]
	public void L1Eg6o31xm8(IList<string> ilist_2)
	{
		gCagXST6nOm = ilist_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public MethodDelegate<bool> UUog6OJS9Ls()
	{
		return TMSgXuAnEk3;
	}

	[SpecialName]
	[CompilerGenerated]
	public void WEYg6F7Udil(MethodDelegate<bool> methodDelegate_1)
	{
		TMSgXuAnEk3 = methodDelegate_1;
	}

	[AsyncStateMachine(typeof(_003CRunSpAsync_003Ed__47))]
	public Task<IDictionary<string, object>> RunSpAsync(string spName, IDictionary<string, object> inputParams)
	{
		_003CRunSpAsync_003Ed__47 stateMachine = default(_003CRunSpAsync_003Ed__47);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IDictionary<string, object>>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.spName = spName;
		stateMachine.inputParams = inputParams;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CRunSpAsync_003Ed__48))]
	public Task<IDictionary<string, object>> RunSpAsync(string spName, object inputParams)
	{
		_003CRunSpAsync_003Ed__48 stateMachine = default(_003CRunSpAsync_003Ed__48);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IDictionary<string, object>>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.spName = spName;
		stateMachine.inputParams = inputParams;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public IDictionary<string, object> RunSp(string spName, IDictionary<string, object> inputParams)
	{
		return SubProgramHelper.RunStandaloneSubprogram(spName, inputParams ?? new Dictionary<string, object>(), W7dg64nQN4C(), Window).GetAwaiter().GetResult();
	}

	public IDictionary<string, object> RunSp(string spName, object inputParams)
	{
		return RunSp(spName, inputParams.ToDictionary());
	}

	internal static bool OchVkVQCIgwq71lw7Nql()
	{
		return UHf60FQCxMGLCiUSOWgF == null;
	}
}
