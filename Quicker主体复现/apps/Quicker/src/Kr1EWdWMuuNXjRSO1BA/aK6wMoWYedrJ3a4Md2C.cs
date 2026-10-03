using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using log4net;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X.SubPrograms;
using Quicker.Domain.Actions.X.Variables;
using Quicker.Modules.TextTools;
using Quicker.Utilities;

namespace Kr1EWdWMuuNXjRSO1BA;

internal class aK6wMoWYedrJ3a4Md2C : BaseTextTool
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnMouseUp_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public aK6wMoWYedrJ3a4Md2C _003C_003E4__this;

		public object sender;

		private ConfiguredTaskAwaitable<IDictionary<string, object>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object kw06hFcYOEZghyPBQGwc;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			aK6wMoWYedrJ3a4Md2C aK6wMoWYedrJ3a4Md2C2 = _003C_003E4__this;
			try
			{
        Dictionary<string, object> dictionary = default;
				if (num == 0)
				{
					goto IL_0136;
				}
				aK6wMoWYedrJ3a4Md2C2.m6wtvnaQ4w5(sender);
				dictionary = default(Dictionary<string, object>);
				if (aK6wMoWYedrJ3a4Md2C2.Context.ActionExecuteContext != null)
				{
					dictionary = new Dictionary<string, object>
					{
						["text"] = aK6wMoWYedrJ3a4Md2C2.Context.TextControl.GetAllText(),
						["selected"] = aK6wMoWYedrJ3a4Md2C2.Context.TextControl.GetSelectedText(),
						["parent"] = aK6wMoWYedrJ3a4Md2C2.Context.ParentWindow
					};
					if (aK6wMoWYedrJ3a4Md2C2.gnItvDIe6Yp != null)
					{
						int num2 = 0;
						if (kw06hFcYOEZghyPBQGwc != null)
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
						IEnumerator<KeyValuePair<string, object>> enumerator = aK6wMoWYedrJ3a4Md2C2.gnItvDIe6Yp.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								KeyValuePair<string, object> current = enumerator.Current;
								try
								{
									dictionary.Add(current.Key, current.Value);
								}
								catch (Exception ex)
								{
									AppHelper.ShowWarning("添加参数" + current.Key + "出错，请检查是否和预置参数名称冲突。" + ex.Message);
								}
							}
						}
						finally
						{
							if (num < 0)
							{
								enumerator?.Dispose();
							}
						}
					}
					goto IL_0136;
				}
				AppHelper.ShowWarning("动作上下文为空，无法执行子程序。");
				goto end_IL_0010;
				IL_0136:
				try
				{
					ConfiguredTaskAwaitable<IDictionary<string, object>>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = aK6wMoWYedrJ3a4Md2C2.Context.ActionExecuteContext.RunSpAsync(aK6wMoWYedrJ3a4Md2C2.SCUtv5gklWV, dictionary).ConfigureAwait(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							int num4 = 0;
							if (kw06hFcYOEZghyPBQGwc != null)
							{
								int num5 = default(int);
								num4 = num5;
							}
							do
							{
								switch (num4)
								{
								default:
									goto IL_0184;
								case 1:
									break;
								}
								break;
								IL_0184:
								num = 0;
								_003C_003E1__state = 0;
								num4 = 1;
							}
							while (kw06hFcYOEZghyPBQGwc == null);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<IDictionary<string, object>>.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
					}
					IDictionary<string, object> result = awaiter.GetResult();
					if (result != null)
					{
						if (result.TryGetValue("output", out var value))
						{
							bool isFullContent = true;
							if (result.TryGetValue("isAll", out var value2))
							{
								isFullContent = VariableHelper.ConvertToBoolean(value2) == true;
							}
							aK6wMoWYedrJ3a4Md2C2.Context.ProcessSelectedTextFunc(VariableHelper.LcfghRCibTg(value), isFullContent);
						}
						else
						{
							AppHelper.ShowWarning("子程序未输出 output 变量。");
						}
					}
				}
				catch (SubProgramFailedException ex2)
				{
					if (ex2.StopFlag != ActionStopFlag.UserCancel)
					{
						NGbtv44IfXN.Warn("执行子程序 " + aK6wMoWYedrJ3a4Md2C2.SCUtv5gklWV + " 出错：" + ex2.Message, ex2);
						AppHelper.ShowWarning("执行子程序 " + aK6wMoWYedrJ3a4Md2C2.SCUtv5gklWV + " 出错：" + ex2.Message);
					}
				}
				catch (Exception ex3)
				{
					NGbtv44IfXN.Warn("执行子程序 " + aK6wMoWYedrJ3a4Md2C2.SCUtv5gklWV + " 出错：" + ex3.Message, ex3);
					AppHelper.ShowWarning("执行子程序 " + aK6wMoWYedrJ3a4Md2C2.SCUtv5gklWV + " 出错：" + ex3.Message);
				}
				end_IL_0010:;
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

		internal static bool ICPK24cYJELhetJD1Ata()
		{
			return kw06hFcYOEZghyPBQGwc == null;
		}
	}

	private static readonly ILog NGbtv44IfXN;

	private readonly string SCUtv5gklWV;

	private readonly IDictionary<string, object> gnItvDIe6Yp;

	internal static aK6wMoWYedrJ3a4Md2C iXDfo8QpcjGGiYZiHZji;

	public aK6wMoWYedrJ3a4Md2C(TextToolContext textToolContext_1, string string_1, IDictionary<string, object> idictionary_1)
		: base(textToolContext_1)
	{
		SCUtv5gklWV = string_1;
		gnItvDIe6Yp = idictionary_1;
	}

	[AsyncStateMachine(typeof(_003COnMouseUp_003Ed__4))]
	public override void OnMouseUp(object sender)
	{
		_003COnMouseUp_003Ed__4 stateMachine = default(_003COnMouseUp_003Ed__4);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = sender;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	static aK6wMoWYedrJ3a4Md2C()
	{
		NGbtv44IfXN = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	[DebuggerHidden]
	[CompilerGenerated]
	private void m6wtvnaQ4w5(object object_0)
	{
		base.OnMouseUp(object_0);
	}

	internal static bool axab6sQpWiRx77uTapdh()
	{
		return iXDfo8QpcjGGiYZiHZji == null;
	}
}
