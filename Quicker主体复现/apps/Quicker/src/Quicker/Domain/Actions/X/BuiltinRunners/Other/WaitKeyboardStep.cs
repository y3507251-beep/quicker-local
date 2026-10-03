using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using FfRbOxjQBTfIswDNnrx;
using FontAwesome5;
using K9HvgYjZL3faEPQWoqU;
using Quicker.Actions.XActions.StepRunners;
using Quicker.Common;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.PowerKeys;
using Quicker.Modules.TextTools;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.View;
using rWLkMnX3Bc6H4OlaITp;
using t8SGKhhgLWTgeqjGcrq;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Other;

public class WaitKeyboardStep : BaseMultiOperationStep, IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec bnfS9VDXQgP;

		public static StepOperation.GetSummaryFunc c6IS9ZesYN5;

		public static StepOperation.GetSummaryFunc a4FS99Z5q6C;

		internal static _003C_003Ec icsTx5W9kjQAVFJqMvG4;

		static _003C_003Ec()
		{
			bnfS9VDXQgP = new _003C_003Ec();
		}

		internal string uCYS9qR292t(ActionStep step)
		{
			return "等待按下 " + XActionHelper.GetParamDisplayString(WaitingKeysParam, step);
		}

		internal string syES9cf3OJ8(ActionStep step)
		{
			return "等待所有按键抬起";
		}

		internal static bool wAl8shW9a7AcfNc128Zu()
		{
			return icsTx5W9kjQAVFJqMvG4 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass39_0
	{
		public string QOXS9WQPP68;

		public ActionExecuteContext B5wS9kj78vQ;

		public HintWindow gYuS9GJ6Y3R;

		public ShowWindowLocation OeNS9souHyc;

		public bool rlRS9HNPvBH;

		public bool hfuS91Xi4hX;

		public string dAVS9bDi4Tb;

		public bool c20S96YD7AE;

		public OjxmG1XsQxaJxHk41nk vK5S9XbwCrw;

		public bool gE7S9mk2KWp;

		public Keys zlCS9KHvbtn;

		public int kWyS9xSFFrF;

		public int Rc6S9rE2euP;

		public EventHandler QZES9pRXHWR;

		public EventHandler yBnS9Bq2Xyh;

		private static _003C_003Ec__DisplayClass39_0 AyFfs9W9NHVwTerh6MGM;

		internal void QQpS9h8sLgb()
		{
			bool flag = true;
			if (!string.IsNullOrEmpty(QOXS9WQPP68))
			{
				flag = true;
			}
			else if (AppState.HHxtaMaoqJr().HideAllEmptyWaitKeyNotifyWindow)
			{
				flag = false;
			}
			else if (string.IsNullOrEmpty(B5wS9kj78vQ.RootContext.Action?.TemplateId))
			{
				flag = false;
			}
			else
			{
				if (B5wS9kj78vQ.RootContext.States.ContainsKey("HAS_SHOWN_WAIT_KEY_NOTIFY"))
				{
					flag = false;
					int num = 0;
					if (AyFfs9W9NHVwTerh6MGM != null)
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					case 1:
						break;
					default:
						goto IL_00b6;
					}
				}
				B5wS9kj78vQ.RootContext.States["HAS_SHOWN_WAIT_KEY_NOTIFY"] = true;
				flag = true;
			}
			goto IL_00b6;
			IL_00b6:
			if (flag)
			{
				gYuS9GJ6Y3R = new HintWindow(QOXS9WQPP68, OeNS9souHyc, rlRS9HNPvBH);
				gYuS9GJ6Y3R.Closed += QZES9pRXHWR ?? (QZES9pRXHWR = g1vS9eYdBEq);
				if (!string.IsNullOrEmpty(dAVS9bDi4Tb))
				{
					gYuS9GJ6Y3R.gCCg4pXgp7r(dAVS9bDi4Tb);
				}
				gYuS9GJ6Y3R.Show();
			}
			if (c20S96YD7AE)
			{
				ObkG8JjRVxQq4TEiAhL.rdOtk5sdP6o(vK5S9XbwCrw);
				vK5S9XbwCrw.GDog9lFutu6(yBnS9Bq2Xyh ?? (yBnS9Bq2Xyh = eErS9YFYCIh));
			}
		}

		internal void g1vS9eYdBEq(object sender, EventArgs e)
		{
			hfuS91Xi4hX = gYuS9GJ6Y3R.ClosedByUser;
		}

		internal void eErS9YFYCIh(object sender, EventArgs e)
		{
			gE7S9mk2KWp = true;
			zlCS9KHvbtn = vK5S9XbwCrw.chyg9TTOZAN();
			kWyS9xSFFrF = vK5S9XbwCrw.SXFg9OPWGY2();
			Rc6S9rE2euP = vK5S9XbwCrw.fUMg9XlnlcL();
		}

		internal void Y6jS9IRNMZW()
		{
			gYuS9GJ6Y3R?.Close();
		}

		internal static bool kTP0YfW99VNYoAyv9k1p()
		{
			return AyFfs9W9NHVwTerh6MGM == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> FbYg98pGiJd = new string[2] { "键盘", "keyboard" };

	[CompilerGenerated]
	private readonly string BNYg9awnTMi = $"fa:{EFontAwesomeIcon.Light_Keyboard}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> tt9g97Fkd1n = new List<StepRunnerCategory> { StepRunnerCategory.Input };

	[CompilerGenerated]
	private readonly string LBmg9RX0wUr = "https://getquicker.net/KC/Help/Doc/waitkeyboard";

	[CompilerGenerated]
	private readonly bool yfdg9q3fMxS;

	public static StepInParamDef WaitingKeysParam;

	public static StepInParamDef ModifierKeysParam;

	private static readonly StepInParamDef e6kg9cOvYec;

	public static StepInParamDef FilterEventParam;

	public static StepInParamDef WaitKeyUpParam;

	public static StepInParamDef IgnoreSimulatedEventParam;

	public static StepInParamDef HelpTextParam;

	private static readonly StepInParamDef e5yg9VvqW8o;

	private static readonly StepInParamDef gYNg9ZWP0ha;

	private static readonly StepInParamDef hcqg99JQ95q;

	public static StepOutParamDef KeyCodeOutput;

	public static StepOutParamDef KeyValueOutput;

	public static StepOutParamDef HoldTimeMsOutParamDef;

	private static WaitKeyboardStep fFU9PtQSS9S8hsdIZqyP;

	public string Key => "sys:waitKeyboard";

	public string Name => "等待按键";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return FbYg98pGiJd;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return BNYg9awnTMi;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Ui;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return tt9g97Fkd1n;
		}
	}

	public string Description => "等待用户按下某个按键";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return LBmg9RX0wUr;
		}
	}

	public bool IsRisky => true;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return yfdg9q3fMxS;
		}
	}

	public WaitKeyboardStep()
	{
		SetupParams(new StepInParamDef[10] { WaitingKeysParam, ModifierKeysParam, e6kg9cOvYec, FilterEventParam, WaitKeyUpParam, IgnoreSimulatedEventParam, HelpTextParam, e5yg9VvqW8o, gYNg9ZWP0ha, hcqg99JQ95q }, new StepOutParamDef[3] { KeyCodeOutput, KeyValueOutput, HoldTimeMsOutParamDef });
		StepOperation operation = new StepOperation
		{
			Key = "waitKeyDown",
			Title = "等待按下",
			GetSummary = (_003C_003Ec.c6IS9ZesYN5 ?? (_003C_003Ec.c6IS9ZesYN5 = _003C_003Ec.bnfS9VDXQgP.uCYS9qR292t)),
			InputParams = { WaitingKeysParam, ModifierKeysParam, e6kg9cOvYec, FilterEventParam, WaitKeyUpParam, IgnoreSimulatedEventParam, HelpTextParam, e5yg9VvqW8o, gYNg9ZWP0ha, hcqg99JQ95q },
			OutputParams = { KeyCodeOutput, KeyValueOutput, HoldTimeMsOutParamDef },
			Execute = Eu8g9ETfLYt
		};
		AddOperation(operation, true);
		AddOperation(new StepOperation
		{
			Key = "waitAllKeyUp",
			Title = "等待所有按键抬起",
			GetSummary = (_003C_003Ec.a4FS99Z5q6C ?? (_003C_003Ec.a4FS99Z5q6C = _003C_003Ec.bnfS9VDXQgP.syES9cf3OJ8)),
			InputParams = { e6kg9cOvYec },
			Execute = fVhg9PiuSw4
		});
	}

	private StepExecuteResult fVhg9PiuSw4(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0, string string_2)
	{
		double numberParamValue = XActionHelper.GetNumberParamValue(e6kg9cOvYec, actionStep_0, actionExecuteContext_0);
		long num = long.MaxValue;
		if (numberParamValue > 0.0)
		{
			num = AppHelper.fLiLTj0x4QY() + (int)(numberParamValue * 1000.0);
		}
		KeyboardState realKeyState = AppState.v5FtaQ4hQfg().dHavLMV7kRX().RealKeyState;
		int num3 = default(int);
		while (true)
		{
			if (realKeyState.IsAnyKeyDown())
			{
				if (AppHelper.fLiLTj0x4QY() <= num)
				{
					if (actionExecuteContext_0.IsShouldStopAction())
					{
						break;
					}
					Thread.Sleep(2);
					continue;
				}
				return StepExecuteResult.Failed("等待按键抬起超时。");
			}
			int num2 = 0;
			if (!Qlw4gNQSwGi50tjPD1g2())
			{
				num2 = num3;
			}
			return num2 switch
			{
				_ => StepExecuteResult.Success, 
			};
		}
		return StepExecuteResult.UserCanceled("用户取消");
	}

	private StepExecuteResult Eu8g9ETfLYt(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0, string string_2)
	{
        int num5 = default;
        string[] array = default;
        IList<Keys> list = default;
        bool flag = default;
        string textParamValue3 = default;
        int num3 = default;
        long num6 = default;
        Keys keys = default;
		_003C_003Ec__DisplayClass39_0 _003C_003Ec__DisplayClass39_ = new _003C_003Ec__DisplayClass39_0();
		_003C_003Ec__DisplayClass39_.B5wS9kj78vQ = actionExecuteContext_0;
		bool booleanParamValue = XActionHelper.GetBooleanParamValue(FilterEventParam, actionStep_0, _003C_003Ec__DisplayClass39_.B5wS9kj78vQ);
		bool booleanParamValue2 = XActionHelper.GetBooleanParamValue(WaitKeyUpParam, actionStep_0, _003C_003Ec__DisplayClass39_.B5wS9kj78vQ);
		bool booleanParamValue3 = XActionHelper.GetBooleanParamValue(IgnoreSimulatedEventParam, actionStep_0, _003C_003Ec__DisplayClass39_.B5wS9kj78vQ);
		int num = (int)(1000.0 * XActionHelper.GetNumberParamValue(e6kg9cOvYec, actionStep_0, _003C_003Ec__DisplayClass39_.B5wS9kj78vQ));
		string textParamValue = XActionHelper.GetTextParamValue(WaitingKeysParam, actionStep_0, _003C_003Ec__DisplayClass39_.B5wS9kj78vQ);
		string textParamValue2 = XActionHelper.GetTextParamValue(ModifierKeysParam, actionStep_0, _003C_003Ec__DisplayClass39_.B5wS9kj78vQ);
		int num2 = 1;
		if (!Qlw4gNQSwGi50tjPD1g2())
		{
			goto IL_0474;
		}
		goto IL_050f;
		IL_0474:
		_003C_003Ec__DisplayClass39_.QOXS9WQPP68 = XActionHelper.GetTextParamValue(HelpTextParam, actionStep_0, _003C_003Ec__DisplayClass39_.B5wS9kj78vQ);
		textParamValue3 = XActionHelper.GetTextParamValue(gYNg9ZWP0ha, actionStep_0, _003C_003Ec__DisplayClass39_.B5wS9kj78vQ);
		_003C_003Ec__DisplayClass39_.rlRS9HNPvBH = XActionHelper.GetBooleanParamValue(hcqg99JQ95q, actionStep_0, _003C_003Ec__DisplayClass39_.B5wS9kj78vQ);
		_003C_003Ec__DisplayClass39_.dAVS9bDi4Tb = XActionHelper.GetTextParamValue(e5yg9VvqW8o, actionStep_0, _003C_003Ec__DisplayClass39_.B5wS9kj78vQ);
		list = new DistinctList<Keys>();
		_003C_003Ec__DisplayClass39_.c20S96YD7AE = false;
		flag = false;
		array = default(string[]);
		num3 = default(int);
		if (!string.IsNullOrEmpty(textParamValue))
		{
			array = textParamValue.SplitToList(',', '，');
			num3 = 0;
			goto IL_03a9;
		}
		goto IL_03b6;
		IL_05bd:
		System.Windows.Application.Current.Dispatcher.Invoke(_003C_003Ec__DisplayClass39_.Y6jS9IRNMZW);
		goto IL_05d9;
		IL_03a9:
		keys = default(Keys);
		if (num3 < array.Length)
		{
			string text = array[num3];
			if (string.Equals(text, "wheel", StringComparison.OrdinalIgnoreCase))
			{
				flag = true;
				goto IL_03a3;
			}
			keys = KeyboardHelper.KeyFromValueOrName(text);
			list.Add(keys);
			if (!keys.ContainedIn(Keys.Control, Keys.ControlKey))
			{
				goto IL_031c;
			}
			list.Add(Keys.LControlKey);
			list.Add(Keys.RControlKey);
			goto IL_0386;
		}
		goto IL_03be;
		IL_01a3:
		int num4;
		num5 = default(int);
		if (((uint)num4 | (_003C_003Ec__DisplayClass39_.hfuS91Xi4hX ? 1u : 0u)) == 0)
		{
			num5 = 11;
			goto IL_01b6;
		}
		goto IL_020b;
		IL_020b:
		if (_003C_003Ec__DisplayClass39_.vK5S9XbwCrw != null)
		{
			ObkG8JjRVxQq4TEiAhL.fcEtkdSunDE(_003C_003Ec__DisplayClass39_.vK5S9XbwCrw);
		}
		num6 = default(long);
		if (!_003C_003Ec__DisplayClass39_.gE7S9mk2KWp && !_003C_003Ec__DisplayClass39_.hfuS91Xi4hX)
		{
			if (!flag || FqQNhnjBSUJyynWhRgo.PRBtGteJEgc() <= num6)
			{
				MouseButtons lastClickMouseButton = AppState.LastClickMouseButton;
				if (lastClickMouseButton <= MouseButtons.Right)
				{
					if (lastClickMouseButton != MouseButtons.Left)
					{
						if (lastClickMouseButton == MouseButtons.Right)
						{
							_003C_003Ec__DisplayClass39_.zlCS9KHvbtn = Keys.RButton;
							num2 = 5;
							if (fFU9PtQSS9S8hsdIZqyP != null)
							{
								goto IL_0474;
							}
							goto IL_050f;
						}
					}
					else
					{
						_003C_003Ec__DisplayClass39_.zlCS9KHvbtn = Keys.LButton;
					}
				}
				else
				{
					switch (lastClickMouseButton)
					{
					case MouseButtons.XButton2:
						_003C_003Ec__DisplayClass39_.zlCS9KHvbtn = Keys.XButton2;
						break;
					case MouseButtons.XButton1:
						_003C_003Ec__DisplayClass39_.zlCS9KHvbtn = Keys.XButton1;
						break;
					case MouseButtons.Middle:
						_003C_003Ec__DisplayClass39_.zlCS9KHvbtn = Keys.MButton;
						break;
					}
				}
				goto IL_05a6;
			}
			_003C_003Ec__DisplayClass39_.zlCS9KHvbtn = Keys.None;
			goto IL_0555;
		}
		goto IL_05b4;
		IL_05d9:
		XActionHelper.OutputResult(KeyCodeOutput, actionStep_0, _003C_003Ec__DisplayClass39_.B5wS9kj78vQ, _003C_003Ec__DisplayClass39_.zlCS9KHvbtn.ToString(), xaction_0);
		XActionHelper.OutputResult(KeyValueOutput, actionStep_0, _003C_003Ec__DisplayClass39_.B5wS9kj78vQ, _003C_003Ec__DisplayClass39_.kWyS9xSFFrF, xaction_0);
		if (booleanParamValue2)
		{
			XActionHelper.OutputResult(HoldTimeMsOutParamDef, actionStep_0, _003C_003Ec__DisplayClass39_.B5wS9kj78vQ, _003C_003Ec__DisplayClass39_.Rc6S9rE2euP, xaction_0);
		}
		if (_003C_003Ec__DisplayClass39_.hfuS91Xi4hX)
		{
			return StepExecuteResult.UserCanceled("用户取消");
		}
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		if (_003C_003Ec__DisplayClass39_.kWyS9xSFFrF != 0 && (_003C_003Ec__DisplayClass39_.gE7S9mk2KWp || flag2 || flag3))
		{
			return StepExecuteResult.Success;
		}
		return StepExecuteResult.Failed("等待按键超时");
		IL_01b6:
		long num7 = default(long);
		if (!(flag3 = flag && FqQNhnjBSUJyynWhRgo.PRBtGteJEgc() > num6) && AppHelper.fLiLTj0x4QY() < num7 && !_003C_003Ec__DisplayClass39_.B5wS9kj78vQ.IsShouldStopAction())
		{
			Thread.Sleep(5);
			goto IL_0200;
		}
		goto IL_020b;
		IL_03be:
		_003C_003Ec__DisplayClass39_.vK5S9XbwCrw = new OjxmG1XsQxaJxHk41nk
		{
			Keys = list
		};
		if (!string.IsNullOrEmpty(textParamValue2))
		{
			num5 = 12;
			goto IL_00a7;
		}
		goto IL_0404;
		IL_03b6:
		_003C_003Ec__DisplayClass39_.c20S96YD7AE = true;
		goto IL_03be;
		IL_00a7:
		if (textParamValue2.IndexOf("alt", StringComparison.OrdinalIgnoreCase) < 0)
		{
			goto IL_00ba;
		}
		num2 = 0;
		if (Qlw4gNQSwGi50tjPD1g2())
		{
			goto IL_0462;
		}
		goto IL_050f;
		IL_050f:
		switch (num2)
		{
		case 12:
			break;
		case 4:
			goto IL_0162;
		case 11:
			goto IL_01b6;
		case 6:
			goto IL_01f3;
		case 8:
			goto IL_031c;
		case 9:
			goto IL_03a3;
		case 3:
			goto IL_03b6;
		default:
			goto IL_0462;
		case 1:
			goto IL_0474;
		case 2:
			goto IL_0555;
		case 5:
		case 7:
			goto IL_05a6;
		case 10:
			goto IL_05bd;
		}
		goto IL_00a7;
		IL_00ba:
		if (textParamValue2.IndexOf("shift", StringComparison.OrdinalIgnoreCase) >= 0)
		{
			_003C_003Ec__DisplayClass39_.vK5S9XbwCrw.Shift = true;
		}
		if (textParamValue2.ToLower().ContainsAny("ctrl", "control"))
		{
			_003C_003Ec__DisplayClass39_.vK5S9XbwCrw.Ctrl = true;
		}
		if (textParamValue2.IndexOf("win", StringComparison.OrdinalIgnoreCase) >= 0)
		{
			_003C_003Ec__DisplayClass39_.vK5S9XbwCrw.Win = true;
		}
		goto IL_0404;
		IL_031c:
		if (keys.ContainedIn(Keys.Alt, Keys.Menu))
		{
			list.Add(Keys.LMenu);
			list.Add(Keys.RMenu);
		}
		else if (keys.ContainedIn(Keys.Shift, Keys.ShiftKey))
		{
			list.Add(Keys.LShiftKey);
			list.Add(Keys.RShiftKey);
		}
		goto IL_0386;
		IL_0386:
		if (keys.IsEither(Keys.LButton, Keys.MButton, Keys.RButton, Keys.XButton1, Keys.XButton2))
		{
			goto IL_03a3;
		}
		_003C_003Ec__DisplayClass39_.c20S96YD7AE = true;
		num2 = 9;
		if (fFU9PtQSS9S8hsdIZqyP != null)
		{
			num2 = num5;
		}
		goto IL_050f;
		IL_03a3:
		num3++;
		goto IL_03a9;
		IL_0555:
		_003C_003Ec__DisplayClass39_.kWyS9xSFFrF = 1000;
		goto IL_05b4;
		IL_0462:
		_003C_003Ec__DisplayClass39_.vK5S9XbwCrw.Alt = true;
		goto IL_00ba;
		IL_0404:
		_003C_003Ec__DisplayClass39_.vK5S9XbwCrw.kugg94ymTkB(booleanParamValue3);
		_003C_003Ec__DisplayClass39_.vK5S9XbwCrw.oUbg9QZJlfx(booleanParamValue);
		_003C_003Ec__DisplayClass39_.vK5S9XbwCrw.vOMg9r5ashP(booleanParamValue2);
		_003C_003Ec__DisplayClass39_.OeNS9souHyc = ShowWindowLocation.Auto;
		if (!string.IsNullOrEmpty(textParamValue3))
		{
			_003C_003Ec__DisplayClass39_.OeNS9souHyc = (ShowWindowLocation)Enum.Parse(typeof(global::Quicker.Domain.ShowWindowLocation), textParamValue3);
		}
		_003C_003Ec__DisplayClass39_.gYuS9GJ6Y3R = null;
		_003C_003Ec__DisplayClass39_.gE7S9mk2KWp = false;
		_003C_003Ec__DisplayClass39_.zlCS9KHvbtn = Keys.None;
		_003C_003Ec__DisplayClass39_.kWyS9xSFFrF = 0;
		_003C_003Ec__DisplayClass39_.Rc6S9rE2euP = 0;
		AppState.LastClickMouseButton = MouseButtons.None;
		num6 = FqQNhnjBSUJyynWhRgo.PRBtGteJEgc();
		goto IL_0162;
		IL_05b4:
		if (_003C_003Ec__DisplayClass39_.gYuS9GJ6Y3R != null)
		{
			goto IL_05bd;
		}
		goto IL_05d9;
		IL_05a6:
		_003C_003Ec__DisplayClass39_.kWyS9xSFFrF = (int)_003C_003Ec__DisplayClass39_.zlCS9KHvbtn;
		goto IL_05b4;
		IL_0162:
		_003C_003Ec__DisplayClass39_.hfuS91Xi4hX = false;
		AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass39_.QQpS9h8sLgb);
		num7 = long.MaxValue;
		if (num > 1)
		{
			num7 = AppHelper.fLiLTj0x4QY() + num;
		}
		flag2 = false;
		flag3 = false;
		goto IL_0200;
		IL_01f3:
		num4 = ((flag2 = taIg9ypIHZC(list)) ? 1 : 0);
		goto IL_01a3;
		IL_0200:
		if (_003C_003Ec__DisplayClass39_.gE7S9mk2KWp)
		{
			num4 = 1;
			goto IL_01a3;
		}
		num5 = 6;
		goto IL_01f3;
	}

	private bool taIg9ypIHZC(IList<Keys> ilist_2)
	{
		if (AppState.LastClickMouseButton != MouseButtons.None)
		{
			switch (AppState.LastClickMouseButton)
			{
			case MouseButtons.Right:
				return ilist_2.Contains(Keys.RButton);
			case MouseButtons.Left:
				return ilist_2.Contains(Keys.LButton);
			case MouseButtons.XButton2:
				return ilist_2.Contains(Keys.XButton2);
			case MouseButtons.XButton1:
				return ilist_2.Contains(Keys.XButton1);
			case MouseButtons.Middle:
				return ilist_2.Contains(Keys.MButton);
			}
		}
		return false;
	}

	static WaitKeyboardStep()
	{
		WaitingKeysParam = new StepInParamDef
		{
			Key = "waitingKeys",
			Name = "等待的按键",
			DefaultValue = "",
			Description = "可选，留空表示任意键盘按键。格式请参考文档。",
			Type = VarType.Text,
			IsMultiLine = false,
			VariableMode = ParamVariableMode.Input,
			TextTools = new List<TextToolType> { TextToolType.SelectKeyName },
			ReplaceMode = TextToolsReplaceMode.AppendWithComma
		};
		ModifierKeysParam = new StepInParamDef
		{
			Key = "modifierKeys",
			Name = "修饰键",
			DefaultValue = "",
			Description = "可选。逗号分隔的ctrl,shift,alt,win组合。仅用于等待组合快捷键。修饰键不会被拦截。",
			Type = VarType.Text,
			IsMultiLine = false,
			VariableMode = ParamVariableMode.Input
		};
		e6kg9cOvYec = new StepInParamDef
		{
			Key = "maxWaitSeconds",
			Name = "最长等待秒数",
			DefaultValue = 0,
			Description = "0为永久超时超过等待时间，则结束等待。",
			Type = VarType.Number,
			IsRequired = true,
			VariableMode = ParamVariableMode.Input
		};
		FilterEventParam = new StepInParamDef
		{
			Key = "filterEvent",
			Name = "拦截原始按键事件",
			Description = "避免按键输入到窗口中 (仅对键盘按键有效)",
			DefaultValue = true,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		WaitKeyUpParam = new StepInParamDef
		{
			Key = "waitKeyUp",
			Name = "等待按键抬起",
			Description = "等待按键抬起后再返回 (仅对键盘按键有效)",
			DefaultValue = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		IgnoreSimulatedEventParam = new StepInParamDef
		{
			Key = "ignoreSimulated",
			Name = "忽略模拟的按键",
			Description = "是否忽略（不检测）模拟的按键消息",
			DefaultValue = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		HelpTextParam = new StepInParamDef
		{
			Key = "help",
			Name = "提示信息",
			DefaultValue = "请按键...",
			Description = "等待按键时显示的提示文字",
			Type = VarType.Text,
			IsMultiLine = true,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		e5yg9VvqW8o = new StepInParamDef
		{
			Key = "fontfamily",
			Name = "字体名称",
			DefaultValue = "",
			Description = "可选。设置字体名称。如有多个字体，使用逗号分隔。",
			IsRequired = false,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsAdvanced = true
		};
		gYNg9ZWP0ha = new StepInParamDef
		{
			Key = "winLocation",
			Name = "提示窗口位置",
			Description = "在哪里显示提示窗口",
			Type = VarType.Enum,
			DefaultValue = ShowWindowLocation.TopCenter.ToString(),
			SelectionItems = new SelectionItem[9]
			{
				new SelectionItem(ShowWindowLocation.CenterScreen.ToString(), "屏幕中间"),
				new SelectionItem(ShowWindowLocation.TopLeft.ToString(), "屏幕左上"),
				new SelectionItem(ShowWindowLocation.TopCenter.ToString(), "屏幕中上"),
				new SelectionItem(ShowWindowLocation.TopRight.ToString(), "屏幕右上"),
				new SelectionItem(ShowWindowLocation.LeftCenter.ToString(), "屏幕左中"),
				new SelectionItem(ShowWindowLocation.RightCenter.ToString(), "屏幕右中"),
				new SelectionItem(ShowWindowLocation.BottomLeft.ToString(), "屏幕左下"),
				new SelectionItem(ShowWindowLocation.BottomCenter.ToString(), "屏幕中下"),
				new SelectionItem(ShowWindowLocation.BottomRight.ToString(), "屏幕右下")
			},
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		hcqg99JQ95q = new StepInParamDef
		{
			Key = "mouseThrough",
			Name = "鼠标穿透",
			Description = "鼠标是否可以穿透提示窗口点击下面的内容",
			Type = VarType.Boolean,
			DefaultValue = true,
			VariableMode = ParamVariableMode.Input
		};
		KeyCodeOutput = new StepOutParamDef
		{
			Key = "keyCode",
			Name = "键名",
			Description = "按键名，具体请参考模块文档。",
			Type = VarType.Text
		};
		KeyValueOutput = new StepOutParamDef
		{
			Key = "keyValue",
			Name = "键值",
			Description = "按键数值，具体请参考模块文档。",
			Type = VarType.Integer
		};
		HoldTimeMsOutParamDef = new StepOutParamDef
		{
			Key = "holdTimeMs",
			Name = "按下保持时间",
			Description = "按下保持时间，单位毫秒。仅支持键盘按键。",
			Type = VarType.Integer
		};
	}

	internal static bool Qlw4gNQSwGi50tjPD1g2()
	{
		return fFU9PtQSS9S8hsdIZqyP == null;
	}
}
