using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Ko4fe7AdlIHVfm4LNc6;
using log4net;
using qcrGlGMkgcYtX0leyxF;
using Quicker.Common.Entities;
using Quicker.Common.QuickActions;
using Quicker.Domain.Actions.Runtime;
using Quicker.Domain.Messages;
using Quicker.Public.Extensions;
using Quicker.Recorder;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;
using Quicker.Utilities.Win32;
using Quicker.View.Hotkeys;
using Quicker.View.TextCommands;
using SWBMfZYGyc6L9yHIvKQ;
using tPW96NMSpaXlHvSiZCX;
using WindowsInput.Native;

namespace Quicker.Domain.QuickActions;

public static class QuickActionRunner
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass2_0
	{
		public int O0ivmOUTP8P;

		public object a21vmFTg4hY;

		public IQuickActionItem hnbvmUnEJr0;

		public ITinyMessengerHub wDBvmlOAgba;

		public AppServer e5JvmihMxe2;

		public bool ewqvm3CTUxT;

		public ActionTrigger PWhvmf00AA1;

		public string qk5vmz13gIQ;

		public GroupCollection c8IvKwKnhI7;

		public PointTargetInfo PpkvKtMM4Tx;

		public bool dl3vKgbNERe;

		internal static _003C_003Ec__DisplayClass2_0 lPfj1Icth8uNDhRpx0n3;

		internal void CPWvmANursM()
		{
			if (O0ivmOUTP8P > 0)
			{
				Thread.Sleep(O0ivmOUTP8P);
			}
			try
			{
				a67tVdyjAf5(a21vmFTg4hY, hnbvmUnEJr0, wDBvmlOAgba, e5JvmihMxe2, ewqvm3CTUxT, PWhvmf00AA1, qk5vmz13gIQ, c8IvKwKnhI7, PpkvKtMM4Tx, dl3vKgbNERe);
				if (!string.IsNullOrEmpty(hnbvmUnEJr0.Message))
				{
					AppHelper.ShowInformation(hnbvmUnEJr0.Message);
				}
			}
			catch (Exception ex)
			{
				qm3tVT3cXmI.Warn("快捷操作运行失败:" + ex.Message, ex);
				AppHelper.ShowWarning("快捷操作运行失败:" + ex.Message);
			}
		}

		internal static bool SSRODhctHPHTY7X2EOex()
		{
			return lPfj1Icth8uNDhRpx0n3 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass3_0
	{
		public IQuickActionItem bL6vKSBPO7j;

		public AppServer qDrvK2NlDjp;

		public ITinyMessengerHub PHCvKufd5QT;

		public bool xdevKNkTWW7;

		internal static _003C_003Ec__DisplayClass3_0 E9C6mIcSW6febn1rdfDQ;

		internal void vqhvKLWwFQi()
		{
			string[] array = bL6vKSBPO7j.Data.Split('\n');
			string path = array[0];
			string text = ((array.Length > 1) ? array[1] : "");
			path = PathHelper.RemoveZeroWidthChar(path).Trim();
			if ((path != null && path.Contains("{cliptext}")) || (text != null && text.Contains("{cliptext}")))
			{
				string newString = ClipboardHelper.TryGetClipboardText(System.Windows.TextDataFormat.UnicodeText);
				text = AppHelper.ReplacePattern(text, "{cliptext}", newString);
				path = AppHelper.ReplacePattern(path, "{cliptext}", newString).Trim();
			}
			int num = 0;
			if (!PW7xJVcSyRGaflkf7jUF())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			try
			{
				ActionHelper.StartProcess(path, text, "", "", false, false, "");
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("启动进程出错：" + ex.Message);
			}
		}

		internal bool v5ZvKvCD206(QuickOperationItem x)
		{
			return string.Equals(x.Key, bL6vKSBPO7j.Data);
		}

		internal static bool PW7xJVcSyRGaflkf7jUF()
		{
			return E9C6mIcSW6febn1rdfDQ == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass3_1
	{
		public QuickOperationItem Wq7vK0Lost9;

		public _003C_003Ec__DisplayClass3_0 IJPvKCaM7QR;

		internal static _003C_003Ec__DisplayClass3_1 o4QqcAcSApxpDVwH5B9X;

		internal void dtqvKJvKcui()
		{
			Wq7vK0Lost9.Func(new QuickOperationContext
			{
				AppServer = IJPvKCaM7QR.qDrvK2NlDjp,
				Hub = IJPvKCaM7QR.PHCvKufd5QT,
				IsFromMouse = IJPvKCaM7QR.xdevKNkTWW7,
				QuickActionItem = IJPvKCaM7QR.bL6vKSBPO7j
			});
		}

		internal static void d3iSGKcSjLmfXX6Uhcex()
		{
		}

		internal static bool z8n2qTcSnsEdDRsyWSdm()
		{
			return o4QqcAcSApxpDVwH5B9X == null;
		}
	}

	private static readonly ILog qm3tVT3cXmI;

	internal static object f6H3ELQKdDtOeSg74KUG;

	public static void ExecuteTextCommand(object sender, TextCommand cmd, string input, UserSettings userSettings, ITinyMessengerHub hub, AppServer appServer, bool skipClearInput, bool isFromMouse, int matchLength)
	{
		GroupCollection groups = null;
		if (cmd.UseRegex && cmd.ExtractFirstMatchGroup)
		{
			Match match = Regex.Match(input, cmd.CmdText, RegexOptions.RightToLeft);
			if (match.Groups.Count <= 1)
			{
				AppHelper.ShowWarning("已匹配文本指令(" + cmd.CmdText + "),内容:" + input + "，但无法提取到匹配组。");
				return;
			}
			input = match.Groups[1].Value;
			groups = match.Groups;
		}
		bool flag = false;
		if (!skipClearInput && matchLength > 0)
		{
			int num2 = default(int);
			while (true)
			{
				if ((flag = QeCVqvMTGqyXjRSCuyP.hF7LF2kDefY()) && !JrJWiKYIEBcPm8FFZOl.Dg0LDSnOcIg(VirtualKeyCode.CAPITAL))
				{
					if (cmd.UseBackspaceWhenImeOpen)
					{
						SendKeys.SendWait("{BS " + matchLength + "}");
						int num = 0;
						if (!dRJqKXQKOBquZTJuhRf5())
						{
							num = num2;
						}
						switch (num)
						{
						case 2:
							break;
						case 1:
							goto IL_00f8;
						default:
							goto IL_0107;
						}
						continue;
					}
					goto IL_00f8;
				}
				SendKeys.SendWait("{BS " + matchLength + "}");
				break;
				IL_00f8:
				SendKeys.SendWait("{ESC}");
				AppState.RecordLastEscSendTick();
				goto IL_0107;
				IL_0107:
				if (AppState.HHxtaMaoqJr().TextCommandAutoDisableIme)
				{
					QeCVqvMTGqyXjRSCuyP.bc0LFuNtAhp(false);
				}
				break;
			}
		}
		Task task = RunQuickActionAsync(sender, cmd, hub, appServer, isFromMouse, ActionTrigger.TextCommand, input, groups);
		if (flag && AppState.HHxtaMaoqJr().TextCommandAutoDisableIme)
		{
			task.Wait();
			Thread.Sleep(50);
			QeCVqvMTGqyXjRSCuyP.bc0LFuNtAhp(true);
		}
	}

	public static Task RunQuickActionAsync(object sender, IQuickActionItem cmd, ITinyMessengerHub hub, AppServer appServer, bool isFromMouse, ActionTrigger actionTrigger, string inputText, GroupCollection groups = null, PointTargetInfo pointTargetInfo = null, bool enableDebugging = false, int delayMs = 0, bool inNewThread = true)
	{
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
		_003C_003Ec__DisplayClass2_.O0ivmOUTP8P = delayMs;
		_003C_003Ec__DisplayClass2_.a21vmFTg4hY = sender;
		_003C_003Ec__DisplayClass2_.hnbvmUnEJr0 = cmd;
		_003C_003Ec__DisplayClass2_.wDBvmlOAgba = hub;
		_003C_003Ec__DisplayClass2_.e5JvmihMxe2 = appServer;
		_003C_003Ec__DisplayClass2_.ewqvm3CTUxT = isFromMouse;
		_003C_003Ec__DisplayClass2_.PWhvmf00AA1 = actionTrigger;
		_003C_003Ec__DisplayClass2_.qk5vmz13gIQ = inputText;
		_003C_003Ec__DisplayClass2_.c8IvKwKnhI7 = groups;
		_003C_003Ec__DisplayClass2_.PpkvKtMM4Tx = pointTargetInfo;
		_003C_003Ec__DisplayClass2_.dl3vKgbNERe = enableDebugging;
		Action action = _003C_003Ec__DisplayClass2_.CPWvmANursM;
		if (inNewThread)
		{
			return GaZT3MMHZ3eZxDOySux.ReZLM3wimyT(action, "quick_action");
		}
		action();
		return null;
	}

	private static void a67tVdyjAf5(object object_0, IQuickActionItem iquickActionItem_0, ITinyMessengerHub itinyMessengerHub_0, AppServer appServer_0, bool bool_0, ActionTrigger actionTrigger_0, string string_0, GroupCollection groupCollection_0, PointTargetInfo pointTargetInfo_0, bool bool_1)
	{
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
		_003C_003Ec__DisplayClass3_.bL6vKSBPO7j = iquickActionItem_0;
		_003C_003Ec__DisplayClass3_.qDrvK2NlDjp = appServer_0;
		int num = 2;
		if (!dRJqKXQKOBquZTJuhRf5())
		{
			goto IL_011f;
		}
		goto IL_0123;
		IL_011f:
		int num2 = default(int);
		num = num2;
		goto IL_0123;
		IL_0123:
		_003C_003Ec__DisplayClass3_1 _003C_003Ec__DisplayClass3_2 = default(_003C_003Ec__DisplayClass3_1);
		string text = default(string);
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			default:
				if (_003C_003Ec__DisplayClass3_2.Wq7vK0Lost9 != null)
				{
					AppHelper.RunAndIgnoreException(_003C_003Ec__DisplayClass3_2.dtqvKJvKcui);
				}
				else
				{
					AppHelper.ShowWarning("不支持的操作类型!");
				}
				return;
			case 1:
				ClipboardHelper.SetHtml(_003C_003Ec__DisplayClass3_.bL6vKSBPO7j.Data, text);
				SendKeys.SendWait("^v");
				return;
			case 3:
				Task.Run((Action)_003C_003Ec__DisplayClass3_.vqhvKLWwFQi);
				return;
			case 4:
				return;
			}
			_003C_003Ec__DisplayClass3_.PHCvKufd5QT = itinyMessengerHub_0;
			_003C_003Ec__DisplayClass3_.xdevKNkTWW7 = bool_0;
			switch (_003C_003Ec__DisplayClass3_.bL6vKSBPO7j.ActionType)
			{
			default:
				return;
			case QuickActionType.PasteHtml:
				text = _003C_003Ec__DisplayClass3_.bL6vKSBPO7j.Data.HtmlToPlainText();
				text = D07tVohUk3q(text);
				num = 1;
				if (f6H3ELQKdDtOeSg74KUG == null)
				{
					continue;
				}
				break;
			case QuickActionType.RunOrOpen:
				if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass3_.bL6vKSBPO7j.Data))
				{
					num = 3;
					if (f6H3ELQKdDtOeSg74KUG == null)
					{
						continue;
					}
					break;
				}
				return;
			case QuickActionType.QuickerOperation:
				_003C_003Ec__DisplayClass3_2 = new _003C_003Ec__DisplayClass3_1();
				_003C_003Ec__DisplayClass3_2.IJPvKCaM7QR = _003C_003Ec__DisplayClass3_;
				_003C_003Ec__DisplayClass3_2.Wq7vK0Lost9 = QuickOperationItem.AllQuickerOperationItems.FirstOrDefault(_003C_003Ec__DisplayClass3_2.IJPvKCaM7QR.v5ZvKvCD206);
				num = 0;
				if (f6H3ELQKdDtOeSg74KUG == null)
				{
					continue;
				}
				break;
			case QuickActionType.Keystroke:
				if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass3_.bL6vKSBPO7j.Data))
				{
					new Hotkey(_003C_003Ec__DisplayClass3_.bL6vKSBPO7j.Data).SimulateInput();
				}
				else
				{
					AppHelper.ShowWarning("热键内容为空！");
				}
				return;
			case QuickActionType.SendKeys:
				SendKeys.SendWait(D07tVohUk3q(_003C_003Ec__DisplayClass3_.bL6vKSBPO7j.Data));
				return;
			case QuickActionType.PasteText:
				ActionHelper.SendTextToWindow(D07tVohUk3q(_003C_003Ec__DisplayClass3_.bL6vKSBPO7j.Data), true, false, 50, 0);
				return;
			case QuickActionType.InputText:
				ActionHelper.SendTextToWindow(D07tVohUk3q(_003C_003Ec__DisplayClass3_.bL6vKSBPO7j.Data), false, false, 0, 0);
				return;
			case QuickActionType.InputScript:
				D3mwCbAmx8tANGphaEi.ExecuteScript(D07tVohUk3q(_003C_003Ec__DisplayClass3_.bL6vKSBPO7j.Data));
				return;
			case QuickActionType.QuickerAction:
			{
				if (string.IsNullOrWhiteSpace(_003C_003Ec__DisplayClass3_.bL6vKSBPO7j.Data))
				{
					return;
				}
				(string, string) actionIdAndParam = _003C_003Ec__DisplayClass3_.bL6vKSBPO7j.Data.GetActionIdAndParam();
				string text2 = "";
				if (string.IsNullOrEmpty(actionIdAndParam.Item2))
				{
					if (!string.Equals(string_0, "*NULL*", StringComparison.OrdinalIgnoreCase))
					{
						text2 = string_0 ?? string.Empty;
					}
				}
				else if (string.Equals(actionIdAndParam.Item2, "*NULL*", StringComparison.OrdinalIgnoreCase))
				{
					text2 = "";
				}
				else
				{
					text2 = actionIdAndParam.Item2;
					if (!string.IsNullOrEmpty(string_0) && text2.Contains("%%"))
					{
						text2 = text2.Replace("%%", string_0);
					}
					if (groupCollection_0 != null && groupCollection_0.Count > 1)
					{
						for (int i = 1; i < groupCollection_0.Count; i++)
						{
							text2 = text2.Replace("{$" + i + "}", CommonExtensions.UrlEncode(groupCollection_0[i].Value));
						}
					}
				}
				_003C_003Ec__DisplayClass3_.PHCvKufd5QT.NotifyRunAction(object_0, actionIdAndParam.Item1, bool_1, false, actionTrigger_0, false, pointTargetInfo_0, text2);
				return;
			}
			case QuickActionType.PlayKeyMouseData:
				new RecordPlayer().Play(_003C_003Ec__DisplayClass3_.bL6vKSBPO7j.Data, 1.0, null);
				return;
			case QuickActionType.None:
			case (QuickActionType)8:
			case (QuickActionType)9:
			case (QuickActionType)10:
				return;
			}
			break;
		}
		goto IL_011f;
	}

	private static string D07tVohUk3q(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return string_0;
		}
		if (string_0.Contains("{cliptext}"))
		{
			string newString = ClipboardHelper.TryGetClipboardText(System.Windows.TextDataFormat.UnicodeText);
			string_0 = AppHelper.ReplacePattern(string_0, "{cliptext}", newString);
		}
		if (string_0.Contains("{selection}"))
		{
			int num = 0;
			if (f6H3ELQKdDtOeSg74KUG != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			try
			{
				string selectedText = AppHelper.GetSelectedText(1L);
				string_0 = AppHelper.ReplacePattern(string_0, "{selection}", selectedText);
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning(ex.Message);
			}
		}
		if (string_0.Contains("{0"))
		{
			string_0 = string.Format(string_0, DateTime.Now);
		}
		if (string_0.StartsWith("FILE:", StringComparison.OrdinalIgnoreCase))
		{
			string name = string_0.Substring("FILE:".Length);
			name = Environment.ExpandEnvironmentVariables(name);
			if (File.Exists(name))
			{
				return File.ReadAllText(name);
			}
			return string_0;
		}
		return string_0;
	}

	static QuickActionRunner()
	{
		qm3tVT3cXmI = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool dRJqKXQKOBquZTJuhRf5()
	{
		return f6H3ELQKdDtOeSg74KUG == null;
	}
}
