using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Controls;
using oWrbknAkO1qAtBXgONY;
using Quicker.Modules.Wizard;
using Quicker.Modules.Wizard.Steps;
using Quicker.Settings.Pages.Basic;
using Quicker.Utilities;
using Quicker.View.UI;
using upLrfmibGdtSX9dWuOT;

namespace mmcmHlAD3xkvwaQf2Ut;

internal class krvQ8AAu3nWMBowhIM6
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec UkbveY8NIMA;

		public static Func<Control> Y4wveI1CMDM;

		public static Func<Control> St1veWmad9k;

		public static Func<Control> hV6vekQqRRq;

		public static Func<Control> dqsveGFK9yc;

		public static Func<Control> dhLves1UZbo;

		public static Func<Control> hsCveHNHJS3;

		internal static _003C_003Ec DWTda5cq2sdFLDX8tlBA;

		static _003C_003Ec()
		{
			UkbveY8NIMA = new _003C_003Ec();
		}

		internal Control jDYvecYteCQ()
		{
			return new PanelSettingsStep();
		}

		internal Control nuQveVPdkp5()
		{
			return new FunctionHotkeySettings();
		}

		internal Control XBEveZsn0Wf()
		{
			return new FunctionHotkeySettings();
		}

		internal Control kAnve9wPccu()
		{
			return new FunctionHotkeySettings();
		}

		internal Control PYsvehwCZ6O()
		{
			return new FunctionHotkeySettings();
		}

		internal Control SlTveePblsP()
		{
			return new FunctionHotkeySettings();
		}

		internal static void mR8usccqeH8yKGuSia0A()
		{
		}

		internal static bool C62E06cqAqBMFwARW8RG()
		{
			return DWTda5cq2sdFLDX8tlBA == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CShowSetupWizardAsync_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		private TaskAwaiter<string> _003C_003Eu__1;

		internal static object uZohRScqj05kOABiRTv5;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			try
			{
				TaskAwaiter<string> awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<string>);
					num = -1;
					_003C_003E1__state = -1;
				}
				else
				{
					awaiter = AppHelper.c8mLT6Z8gH6("/r?id=22").GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						int num2 = 0;
						if (!zGtkmXcqDfUdWlkVkN0P())
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
				string result = awaiter.GetResult();
				if (!string.IsNullOrEmpty(result))
				{
					T3uAzonLnY(result);
				}
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

		internal static bool zGtkmXcqDfUdWlkVkN0P()
		{
			return uZohRScqj05kOABiRTv5 == null;
		}
	}

	private static krvQ8AAu3nWMBowhIM6 Sb38RkHtWHUb1EB5pAo;

	public static void rbHAfxNQss(string string_0)
	{
		List<nRxYaRAHoWftqvfsDyQ> obj = new List<nRxYaRAHoWftqvfsDyQ>
		{
			new nRxYaRAHoWftqvfsDyQ
			{
				Title = "欢迎",
				IsSubStep = false,
				Content = "\r\n\r\n你好，很高兴遇到你！\r\n\r\n这是一个简短的入门教程，它包含这些内容：\r\n- 基础功能的使用；\r\n- 个别主要参数的设置；\r\n\r\n\r\n如果您对向导中的任何内容有疑问，请随时反馈到[网站讨论区](https://getquicker.net/QA)。\r\n"
			}
		};
		nRxYaRAHoWftqvfsDyQ nRxYaRAHoWftqvfsDyQ = new nRxYaRAHoWftqvfsDyQ();
		nRxYaRAHoWftqvfsDyQ.Title = "面板窗口";
		nRxYaRAHoWftqvfsDyQ.IsSubStep = false;
		nRxYaRAHoWftqvfsDyQ.yZcOC3rXKA(_003C_003Ec.Y4wveI1CMDM ?? (_003C_003Ec.Y4wveI1CMDM = _003C_003Ec.UkbveY8NIMA.jDYvecYteCQ));
		((ICollection<nRxYaRAHoWftqvfsDyQ>)obj).Add(nRxYaRAHoWftqvfsDyQ);
		nRxYaRAHoWftqvfsDyQ nRxYaRAHoWftqvfsDyQ2 = new nRxYaRAHoWftqvfsDyQ();
		nRxYaRAHoWftqvfsDyQ2.Title = "主要功能快捷键";
		nRxYaRAHoWftqvfsDyQ2.IsSubStep = false;
		nRxYaRAHoWftqvfsDyQ2.yZcOC3rXKA(_003C_003Ec.St1veWmad9k ?? (_003C_003Ec.St1veWmad9k = _003C_003Ec.UkbveY8NIMA.nuQveVPdkp5));
		((ICollection<nRxYaRAHoWftqvfsDyQ>)obj).Add(nRxYaRAHoWftqvfsDyQ2);
		nRxYaRAHoWftqvfsDyQ nRxYaRAHoWftqvfsDyQ3 = new nRxYaRAHoWftqvfsDyQ();
		nRxYaRAHoWftqvfsDyQ3.Title = "轮盘菜单";
		nRxYaRAHoWftqvfsDyQ3.IsSubStep = false;
		nRxYaRAHoWftqvfsDyQ3.yZcOC3rXKA(_003C_003Ec.hV6vekQqRRq ?? (_003C_003Ec.hV6vekQqRRq = _003C_003Ec.UkbveY8NIMA.XBEveZsn0Wf));
		((ICollection<nRxYaRAHoWftqvfsDyQ>)obj).Add(nRxYaRAHoWftqvfsDyQ3);
		nRxYaRAHoWftqvfsDyQ nRxYaRAHoWftqvfsDyQ4 = new nRxYaRAHoWftqvfsDyQ();
		nRxYaRAHoWftqvfsDyQ4.Title = "鼠标手势";
		nRxYaRAHoWftqvfsDyQ4.IsSubStep = false;
		nRxYaRAHoWftqvfsDyQ4.yZcOC3rXKA(_003C_003Ec.dqsveGFK9yc ?? (_003C_003Ec.dqsveGFK9yc = _003C_003Ec.UkbveY8NIMA.kAnve9wPccu));
		((ICollection<nRxYaRAHoWftqvfsDyQ>)obj).Add(nRxYaRAHoWftqvfsDyQ4);
		nRxYaRAHoWftqvfsDyQ nRxYaRAHoWftqvfsDyQ5 = new nRxYaRAHoWftqvfsDyQ();
		nRxYaRAHoWftqvfsDyQ5.Title = "左键辅助";
		nRxYaRAHoWftqvfsDyQ5.IsSubStep = false;
		nRxYaRAHoWftqvfsDyQ5.yZcOC3rXKA(_003C_003Ec.dhLves1UZbo ?? (_003C_003Ec.dhLves1UZbo = _003C_003Ec.UkbveY8NIMA.PYsvehwCZ6O));
		((ICollection<nRxYaRAHoWftqvfsDyQ>)obj).Add(nRxYaRAHoWftqvfsDyQ5);
		nRxYaRAHoWftqvfsDyQ nRxYaRAHoWftqvfsDyQ6 = new nRxYaRAHoWftqvfsDyQ();
		nRxYaRAHoWftqvfsDyQ6.Title = "上下文菜单";
		nRxYaRAHoWftqvfsDyQ6.IsSubStep = false;
		nRxYaRAHoWftqvfsDyQ6.yZcOC3rXKA(_003C_003Ec.hsCveHNHJS3 ?? (_003C_003Ec.hsCveHNHJS3 = _003C_003Ec.UkbveY8NIMA.SlTveePblsP));
		((ICollection<nRxYaRAHoWftqvfsDyQ>)obj).Add(nRxYaRAHoWftqvfsDyQ6);
		WizardWindow wizardWindow = new WizardWindow(obj);
		wizardWindow.ShowActivated = true;
		wizardWindow.Show();
		wizardWindow.Activate();
	}

	internal static void T3uAzonLnY(string string_0)
	{
		if (V1kWZri8vrLTHgNDH0k.A3gYBiH70UKJSIvqdr2.EkR2PG1vawD().skG2P14t6Ce() == (V1kWZri8vrLTHgNDH0k.hgh80BHm0o6IE7HTQRK)4)
		{
			AppHelper.TryOpenUrlOrFile(string_0);
			return;
		}
		WebViewBrowser webViewBrowser = new WebViewBrowser(string_0);
		webViewBrowser.Show();
		webViewBrowser.Activate();
	}

	[AsyncStateMachine(typeof(_003CShowSetupWizardAsync_003Ed__2))]
	internal static Task cm6Ow5ljga()
	{
		_003CShowSetupWizardAsync_003Ed__2 stateMachine = default(_003CShowSetupWizardAsync_003Ed__2);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	internal static bool g7MmKyHSGpNwgHXaaRj()
	{
		return Sb38RkHtWHUb1EB5pAo == null;
	}
}
