using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Interop;
using FontAwesome5;
using HandyControl.Tools;
using log4net;
using Newtonsoft.Json;
using Quicker.Actions.XActions.BuildinRunners.UI;
using Quicker.Actions.XActions.BuildinRunners.UI.CustomPanel;
using Quicker.Domain;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Actions.X.Variables;
using Quicker.Modules.TextTools;
using Quicker.Public.Actions;
using Quicker.Public.Entities;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using SCyJThYoNMQE7IHLXbA;
using ViNASxihuuLY1Gg9m6p;

namespace cyQvObokd4nyG7fqnfB;

internal class QFB8sioH69rXvIExprT : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass84_0
	{
		public ActionStep RDhSWr7BRIl;

		public ActionExecuteContext b5ZSWpJCUci;

		public QFB8sioH69rXvIExprT zLUSWBJlpmB;

		public XAction veXSWQIWZBq;

		internal static _003C_003Ec__DisplayClass84_0 SkgxByWoHYsNTfKCQJEZ;

		internal (bool isSuccess, string message, ActionStopFlag failReason) F64SWxtoxYG()
		{
			string textParamValue = XActionHelper.GetTextParamValue(fpdgb2Rl2am, RDhSWr7BRIl, b5ZSWpJCUci);
			_003C_003Ec__DisplayClass84_1 _003C_003Ec__DisplayClass84_ = new _003C_003Ec__DisplayClass84_1();
			switch (textParamValue)
			{
			default:
				return (isSuccess: false, message: "不支持的操作类型：" + textParamValue + "，可能您使用的Quicker版本过旧。", failReason: ActionStopFlag.OperationFailed);
			case "close_fixed_panel":
				_003C_003Ec__DisplayClass84_.KosSWnhFUm3 = U9Sg1zXUH5K(RDhSWr7BRIl, b5ZSWpJCUci);
				if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass84_.KosSWnhFUm3))
				{
					return (isSuccess: false, message: "未提供要关闭的操作窗的窗口标识。", failReason: ActionStopFlag.OperationFailed);
				}
				AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass84_.RxQSWjniZIN);
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			case "get_panel_info":
				return zLUSWBJlpmB.zl9g13IOVtc(RDhSWr7BRIl, b5ZSWpJCUci, veXSWQIWZBq);
			case "toggle_collapse":
				return zLUSWBJlpmB.Vf7g1fOcE0E(RDhSWr7BRIl, b5ZSWpJCUci);
			case "show_fixed_panel":
			case "show_fixed_panel_wait_close":
			{
				bool bool_ = textParamValue == "show_fixed_panel_wait_close";
				return zLUSWBJlpmB.OODgbwUjwuV(bool_, RDhSWr7BRIl, b5ZSWpJCUci, veXSWQIWZBq);
			}
			}
		}

		internal static bool zWe8VaWozoMDTqt1fbfF()
		{
			return SkgxByWoHYsNTfKCQJEZ == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass84_1
	{
		public string KosSWnhFUm3;

		internal static _003C_003Ec__DisplayClass84_1 figouBWfQ85OpwlIluRc;

		internal void RxQSWjniZIN()
		{
			if (string.IsNullOrEmpty(KosSWnhFUm3))
			{
				return;
			}
			foreach (CustomPanelWindow item in AppHelper.FindRootWindows<CustomPanelWindow>())
			{
				if (item.WindowId == KosSWnhFUm3)
				{
					item.Close();
				}
			}
		}

		internal static bool d4abRSWfFIHbSHAaCm3E()
		{
			return figouBWfQ85OpwlIluRc == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass85_0
	{
		public string QETSW5hVo1w;

		public bool r5ASWDHwQ84;

		public IntPtr DQnSWdcOh6d;

		public bool QIRSWoArCVC;

		public bool XVySWTCoy4j;

		public bool XAaSWM28bWF;

		public string EBpSWANmWao;

		private static _003C_003Ec__DisplayClass85_0 l1PEcjWfW5cMQnxivPRq;

		internal void On3SW4Oa4vX()
		{
			int num2 = default(int);
			foreach (CustomPanelWindow item in AppHelper.FindRootWindows<CustomPanelWindow>())
			{
				int num = 0;
				if (l1PEcjWfW5cMQnxivPRq != null)
				{
					num = num2;
				}
				switch (num)
				{
				}
				if (item.WindowId == QETSW5hVo1w && item.IsLoaded)
				{
					r5ASWDHwQ84 = true;
					DQnSWdcOh6d = new WindowInteropHelper(item).Handle;
					QIRSWoArCVC = item.IsShowContent;
					XVySWTCoy4j = item.IsVisible;
					XAaSWM28bWF = true;
					EBpSWANmWao = item.GetCurrentGroupName() ?? "";
					return;
				}
			}
		}

		internal static bool eKZi8eWfy9KsMxbuUp3G()
		{
			return l1PEcjWfW5cMQnxivPRq == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass86_0
	{
		public string wN6SWF9H3si;

		public bool nWESWUBTLLr;

		private static _003C_003Ec__DisplayClass86_0 P32L5AWf2nBP1FdT3tST;

		internal void SIPSWOsL6ZB()
		{
			foreach (CustomPanelWindow item in AppHelper.FindRootWindows<CustomPanelWindow>())
			{
				if (item.WindowId == wN6SWF9H3si && item.IsLoaded)
				{
					nWESWUBTLLr = true;
					if (item.EnableAutoCollapse)
					{
						item.EnableAutoCollapse = false;
					}
					item.IsOpen = !item.IsShowContent;
					break;
				}
			}
		}

		internal static bool VvrIdlWfAOpAe56Tdcm3()
		{
			return P32L5AWf2nBP1FdT3tST == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass89_0
	{
		public CustomPanelInfo xxGSkt0LY3h;

		public bool JLJSkgp8HZM;

		public CustomPanelWindow FMgSkL4GLvU;

		public ActionExecuteContext WKkSkv6o2Vg;

		public bool j1wSkS6UscM;

		public bool oceSk29XWkd;

		public string s9sSkuCICNg;

		public AutoResetEvent cUhSkNRTjh0;

		public IntPtr eCcSkJU5m8i;

		public EventHandler YsgSk0wLIEn;

		internal static _003C_003Ec__DisplayClass89_0 L7o1UZWfj3WV4fKa5wmi;

		internal void Oc0SWlnY6pI()
		{
			if (!string.IsNullOrEmpty(xxGSkt0LY3h.WindowId))
			{
				int num2 = default(int);
				foreach (CustomPanelWindow item in AppHelper.FindRootWindows<CustomPanelWindow>())
				{
					if (!(item.WindowId == xxGSkt0LY3h.WindowId) || !item.IsLoaded)
					{
						continue;
					}
					if (JLJSkgp8HZM)
					{
						int num = 0;
						if (L7o1UZWfj3WV4fKa5wmi != null)
						{
							num = num2;
						}
						switch (num)
						{
						}
						item.Close();
					}
					else
					{
						try
						{
							item.UpdateData(xxGSkt0LY3h);
						}
						catch (Exception ex)
						{
							yLVgbjQbZB5.Error("UpdateData出错：" + ex.Message, ex);
							AppHelper.ShowWarning("生成窗口内容出错：" + ex.Message);
						}
						FMgSkL4GLvU = item;
					}
				}
			}
			string value = default(string);
			int num3;
			if (FMgSkL4GLvU == null)
			{
				if (!xxGSkt0LY3h.SavePanelState)
				{
					goto IL_01ea;
				}
				string key = "custom_panel_state_" + xxGSkt0LY3h.WindowId;
				value = WKkSkv6o2Vg.ReadState(key, null);
				num3 = 1;
				if (!Qw32E2WfDADLYYvMYVtv())
				{
					int num4 = default(int);
					num3 = num4;
				}
			}
			else
			{
				if (!IHNRIiikxBwJdYmHpM3.TfXvvOk3NGv(FMgSkL4GLvU.Left, FMgSkL4GLvU.Top))
				{
					goto IL_0243;
				}
				FMgSkL4GLvU.Left = (SystemParameters.VirtualScreenLeft + SystemParameters.VirtualScreenWidth - FMgSkL4GLvU.Width) / 2.0;
				num3 = 0;
				if (L7o1UZWfj3WV4fKa5wmi != null)
				{
					goto IL_01a1;
				}
			}
			switch (num3)
			{
			case 1:
				goto IL_01cf;
			}
			goto IL_01a1;
			IL_0243:
			if (JLJSkgp8HZM)
			{
				FMgSkL4GLvU.Closed += YsgSk0wLIEn ?? (YsgSk0wLIEn = jfTSWir3yhn);
			}
			FMgSkL4GLvU.Show();
			eCcSkJU5m8i = FMgSkL4GLvU.GetHandle();
			return;
			IL_01ea:
			FMgSkL4GLvU = new CustomPanelWindow(xxGSkt0LY3h);
			FMgSkL4GLvU.FontSize = xxGSkt0LY3h.ItemFontSize;
			if (JLJSkgp8HZM)
			{
				FMgSkL4GLvU.V6hgjEnp8ZH(WKkSkv6o2Vg.CancellationToken);
			}
			if (j1wSkS6UscM)
			{
				FMgSkL4GLvU.ResizeMode = ResizeMode.NoResize;
			}
			goto IL_0243;
			IL_01cf:
			if (!string.IsNullOrEmpty(value))
			{
				xxGSkt0LY3h.PanelState = JsonConvert.DeserializeObject<CustomPanelState>(value);
			}
			goto IL_01ea;
			IL_01a1:
			FMgSkL4GLvU.Top = (SystemParameters.VirtualScreenTop + SystemParameters.VirtualScreenHeight - FMgSkL4GLvU.Height) / 2.0;
			goto IL_0243;
		}

		internal void jfTSWir3yhn(object sender, EventArgs e)
		{
			oceSk29XWkd = true;
			s9sSkuCICNg = FMgSkL4GLvU.GetCurrentGroupName();
			cUhSkNRTjh0.Set();
		}

		internal void vptSW3Sft79()
		{
			try
			{
				FMgSkL4GLvU.Close();
			}
			catch (Exception)
			{
			}
		}

		internal object rVVSWfcUjoA()
		{
			return s9sSkuCICNg;
		}

		internal object isfSWzjMT2v()
		{
			CommonOperationItem resultButtonItem = FMgSkL4GLvU.ResultButtonItem;
			object obj;
			if (resultButtonItem == null)
			{
				obj = null;
			}
			else
			{
				obj = resultButtonItem.Data;
				if (obj != null)
				{
					goto IL_0020;
				}
			}
			obj = "";
			goto IL_0020;
			IL_0020:
			return obj;
		}

		internal object vxVSkwVBxu3()
		{
			return FMgSkL4GLvU.ResultButtonItem;
		}

		internal static void kKbXf6WfEBYOOIityIeF()
		{
		}

		internal static bool Qw32E2WfDADLYYvMYVtv()
		{
			return L7o1UZWfj3WV4fKa5wmi == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> yJigbgqQUQK;

	[CompilerGenerated]
	private readonly string mCKgbLlkiIV = $"fa:{EFontAwesomeIcon.Light_Bars}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> C5fgbvQ86ZZ;

	[CompilerGenerated]
	private readonly string ImSgbSLgs5J = "https://getquicker.net/KC/Help/Doc/custompanel";

	private static readonly StepInParamDef fpdgb2Rl2am;

	private static readonly StepInParamDef APRgbuL1Xe8;

	private static readonly StepInParamDef eNigbNfe8xe;

	private static readonly StepInParamDef RswgbJCa72p;

	private static readonly StepInParamDef Sxlgb0vkEBq;

	private static readonly StepInParamDef hVigbCnD96S;

	private static readonly StepInParamDef QRegbPx5nBJ;

	private static readonly StepInParamDef AQggbEWkd31;

	private static readonly StepInParamDef WYPgby763iF;

	private static readonly StepInParamDef HRNgb8k6FmN;

	private static readonly StepInParamDef xVkgba5vcrR;

	private static readonly StepInParamDef oTPgb7iY8HG;

	private static readonly StepInParamDef xRvgbRvJQoe;

	private static readonly StepInParamDef SiUgbqO5570;

	private static readonly StepInParamDef t5YgbcqJlyk;

	private static readonly StepInParamDef oB0gbVWb75A;

	private static readonly StepInParamDef D8PgbZMXeD8;

	private static readonly StepInParamDef QUbgb9WmW80;

	private static readonly StepInParamDef ROggbhJhmfU;

	private static readonly StepInParamDef YfogbeeI9wZ;

	private static readonly StepInParamDef SIXgbYd2bbF;

	private static readonly StepInParamDef nLZgbILfEyq;

	private static readonly StepInParamDef i5pgbWl8xYp;

	private static readonly StepInParamDef m3GgbkkYlIE;

	private static readonly StepInParamDef fMLgbGV8lMx;

	private static readonly StepInParamDef mnpgbsWsuqQ;

	private static readonly StepInParamDef QWfgbHBapkn;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> Td2gb1Wngss = new List<StepInParamDef>
	{
		fpdgb2Rl2am, APRgbuL1Xe8, eNigbNfe8xe, i5pgbWl8xYp, Sxlgb0vkEBq, hVigbCnD96S, AQggbEWkd31, WYPgby763iF, HRNgb8k6FmN, xVkgba5vcrR,
		oTPgb7iY8HG, xRvgbRvJQoe, SiUgbqO5570, t5YgbcqJlyk, mnpgbsWsuqQ, oB0gbVWb75A, QRegbPx5nBJ, D8PgbZMXeD8, QUbgb9WmW80, ROggbhJhmfU,
		YfogbeeI9wZ, SIXgbYd2bbF, nLZgbILfEyq, m3GgbkkYlIE, fMLgbGV8lMx, QWfgbHBapkn
	};

	private static readonly StepOutParamDef mghgbbJEwCf;

	private static readonly StepOutParamDef Ctqgb6kuR8I;

	private static readonly StepOutParamDef EvXgbXwlWck;

	private static readonly StepOutParamDef hDNgbmEGItE;

	private static readonly StepOutParamDef p0FgbKJBeQf;

	private static readonly StepOutParamDef BrAgbxVnhw3;

	private static readonly StepOutParamDef eEygbrhvXTD;

	private static readonly StepOutParamDef AsbgbpDvkyu;

	private static readonly StepOutParamDef O3bgbBYx5Vd;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> by9gbQ0Byxk = new List<StepOutParamDef> { mghgbbJEwCf, p0FgbKJBeQf, BrAgbxVnhw3, eEygbrhvXTD, hDNgbmEGItE, EvXgbXwlWck, Ctqgb6kuR8I, AsbgbpDvkyu, O3bgbBYx5Vd };

	private static readonly ILog yLVgbjQbZB5;

	private static QFB8sioH69rXvIExprT CKrC9wQCeAf4cyABDIa2;

	public string Key => "sys:custompanel";

	public string Name => "自定义操作窗";

	public string Description => "自定义悬浮操作窗口，点击后直接执行操作，不隐藏。";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return yJigbgqQUQK;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return mCKgbLlkiIV;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Ui;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return C5fgbvQ86ZZ;
		}
	}

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return ImSgbSLgs5J;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly => false;

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return Td2gb1Wngss;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return by9gbQ0Byxk;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass84_0 _003C_003Ec__DisplayClass84_ = new _003C_003Ec__DisplayClass84_0();
		_003C_003Ec__DisplayClass84_.RDhSWr7BRIl = step;
		_003C_003Ec__DisplayClass84_.b5ZSWpJCUci = context;
		_003C_003Ec__DisplayClass84_.zLUSWBJlpmB = this;
		_003C_003Ec__DisplayClass84_.veXSWQIWZBq = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass84_.b5ZSWpJCUci, _003C_003Ec__DisplayClass84_.RDhSWr7BRIl, _003C_003Ec__DisplayClass84_.veXSWQIWZBq, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass84_.F64SWxtoxYG, (Action)null, (Action)null, QWfgbHBapkn, mghgbbJEwCf);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) zl9g13IOVtc(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0)
	{
		_003C_003Ec__DisplayClass85_0 _003C_003Ec__DisplayClass85_ = new _003C_003Ec__DisplayClass85_0();
		_003C_003Ec__DisplayClass85_.QETSW5hVo1w = U9Sg1zXUH5K(actionStep_0, actionExecuteContext_0);
		if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass85_.QETSW5hVo1w))
		{
			return (isSuccess: false, message: "未提供操作窗的窗口标识。", failReason: ActionStopFlag.OperationFailed);
		}
		_003C_003Ec__DisplayClass85_.r5ASWDHwQ84 = false;
		_003C_003Ec__DisplayClass85_.DQnSWdcOh6d = IntPtr.Zero;
		_003C_003Ec__DisplayClass85_.QIRSWoArCVC = false;
		_003C_003Ec__DisplayClass85_.XVySWTCoy4j = false;
		_003C_003Ec__DisplayClass85_.XAaSWM28bWF = false;
		_003C_003Ec__DisplayClass85_.EBpSWANmWao = "";
		AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass85_.On3SW4Oa4vX);
		if (!_003C_003Ec__DisplayClass85_.r5ASWDHwQ84)
		{
			return (isSuccess: false, message: "未找到指定的操作窗。", failReason: ActionStopFlag.OperationFailed);
		}
		XActionHelper.OutputResult(hDNgbmEGItE, actionStep_0, actionExecuteContext_0, _003C_003Ec__DisplayClass85_.XVySWTCoy4j, xaction_0);
		XActionHelper.OutputResult(Ctqgb6kuR8I, actionStep_0, actionExecuteContext_0, _003C_003Ec__DisplayClass85_.DQnSWdcOh6d, xaction_0);
		XActionHelper.OutputResult(EvXgbXwlWck, actionStep_0, actionExecuteContext_0, _003C_003Ec__DisplayClass85_.QIRSWoArCVC, xaction_0);
		XActionHelper.OutputResult(eEygbrhvXTD, actionStep_0, actionExecuteContext_0, _003C_003Ec__DisplayClass85_.EBpSWANmWao, xaction_0);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) Vf7g1fOcE0E(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0)
	{
		_003C_003Ec__DisplayClass86_0 _003C_003Ec__DisplayClass86_ = new _003C_003Ec__DisplayClass86_0();
		_003C_003Ec__DisplayClass86_.wN6SWF9H3si = U9Sg1zXUH5K(actionStep_0, actionExecuteContext_0);
		if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass86_.wN6SWF9H3si))
		{
			return (isSuccess: false, message: "未提供要关闭的操作窗的窗口标识。", failReason: ActionStopFlag.OperationFailed);
		}
		_003C_003Ec__DisplayClass86_.nWESWUBTLLr = false;
		AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass86_.SIPSWOsL6ZB);
		if (!_003C_003Ec__DisplayClass86_.nWESWUBTLLr)
		{
			return (isSuccess: false, message: "未找到指定的操作窗。", failReason: ActionStopFlag.OperationFailed);
		}
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private static string U9Sg1zXUH5K(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0)
	{
		string text = XActionHelper.GetTextParamValue(xRvgbRvJQoe, actionStep_0, actionExecuteContext_0);
		if (text == "=")
		{
			text = actionExecuteContext_0.ActionId;
		}
		return text;
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) OODgbwUjwuV(bool bool_0, ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0)
	{
		_003C_003Ec__DisplayClass89_0 _003C_003Ec__DisplayClass89_ = new _003C_003Ec__DisplayClass89_0();
		_003C_003Ec__DisplayClass89_.JLJSkgp8HZM = bool_0;
		_003C_003Ec__DisplayClass89_.WKkSkv6o2Vg = actionExecuteContext_0;
		string textParamValue = XActionHelper.GetTextParamValue(eNigbNfe8xe, actionStep_0, _003C_003Ec__DisplayClass89_.WKkSkv6o2Vg);
		IList<CommonOperationItem> list = TAcgbtAuTg1(actionStep_0, _003C_003Ec__DisplayClass89_.WKkSkv6o2Vg, APRgbuL1Xe8);
		if (list == null)
		{
			list = new List<CommonOperationItem>();
		}
		_003C_003Ec__DisplayClass89_.xxGSkt0LY3h = new CustomPanelInfo();
		_003C_003Ec__DisplayClass89_.xxGSkt0LY3h.Items = list;
		_003C_003Ec__DisplayClass89_.xxGSkt0LY3h.DefaultOperation = textParamValue;
		_003C_003Ec__DisplayClass89_.xxGSkt0LY3h.Context = _003C_003Ec__DisplayClass89_.WKkSkv6o2Vg;
		double numberParamValue = XActionHelper.GetNumberParamValue(RswgbJCa72p, actionStep_0, _003C_003Ec__DisplayClass89_.WKkSkv6o2Vg);
		string textParamValue2 = XActionHelper.GetTextParamValue(Sxlgb0vkEBq, actionStep_0, _003C_003Ec__DisplayClass89_.WKkSkv6o2Vg);
		if (string.IsNullOrEmpty(textParamValue2))
		{
			_003C_003Ec__DisplayClass89_.xxGSkt0LY3h.SpacingMargin = new Thickness(numberParamValue);
		}
		else
		{
			_003C_003Ec__DisplayClass89_.xxGSkt0LY3h.SpacingMargin = textParamValue2.ToThickness();
		}
		string textParamValue3 = XActionHelper.GetTextParamValue(hVigbCnD96S, actionStep_0, _003C_003Ec__DisplayClass89_.WKkSkv6o2Vg);
		if (!textParamValue3.IsNullOrWhiteSpace())
		{
			_003C_003Ec__DisplayClass89_.xxGSkt0LY3h.ButtonPadding = textParamValue3.ToThickness();
		}
		_003C_003Ec__DisplayClass89_.xxGSkt0LY3h.BackgroundColor = XActionHelper.GetTextParamValue(QRegbPx5nBJ, actionStep_0, _003C_003Ec__DisplayClass89_.WKkSkv6o2Vg);
		_003C_003Ec__DisplayClass89_.xxGSkt0LY3h.ButtonColor = XActionHelper.GetTextParamValue(D8PgbZMXeD8, actionStep_0, _003C_003Ec__DisplayClass89_.WKkSkv6o2Vg);
		_003C_003Ec__DisplayClass89_.xxGSkt0LY3h.ButtonBorderColor = XActionHelper.GetTextParamValue(QUbgb9WmW80, actionStep_0, _003C_003Ec__DisplayClass89_.WKkSkv6o2Vg);
		_003C_003Ec__DisplayClass89_.xxGSkt0LY3h.FontColor = XActionHelper.GetTextParamValue(ROggbhJhmfU, actionStep_0, _003C_003Ec__DisplayClass89_.WKkSkv6o2Vg);
		_003C_003Ec__DisplayClass89_.xxGSkt0LY3h.ColumnCount = (int)XActionHelper.GetIntegerParamValue(AQggbEWkd31, actionStep_0, _003C_003Ec__DisplayClass89_.WKkSkv6o2Vg);
		_003C_003Ec__DisplayClass89_.xxGSkt0LY3h.ColumnWidth = (int)XActionHelper.GetNumberParamValue(WYPgby763iF, actionStep_0, _003C_003Ec__DisplayClass89_.WKkSkv6o2Vg);
		_003C_003Ec__DisplayClass89_.xxGSkt0LY3h.GroupMode = XActionHelper.GetTextParamValue(HRNgb8k6FmN, actionStep_0, _003C_003Ec__DisplayClass89_.WKkSkv6o2Vg);
		_003C_003Ec__DisplayClass89_.xxGSkt0LY3h.SelectGroup = XActionHelper.GetTextParamValue(xVkgba5vcrR, actionStep_0, _003C_003Ec__DisplayClass89_.WKkSkv6o2Vg);
		_003C_003Ec__DisplayClass89_.xxGSkt0LY3h.WindowId = U9Sg1zXUH5K(actionStep_0, _003C_003Ec__DisplayClass89_.WKkSkv6o2Vg);
		_003C_003Ec__DisplayClass89_.xxGSkt0LY3h.WindowLocation = XActionHelper.GetTextParamValue(SiUgbqO5570, actionStep_0, _003C_003Ec__DisplayClass89_.WKkSkv6o2Vg);
		string text = XActionHelper.GetTextParamValue(t5YgbcqJlyk, actionStep_0, _003C_003Ec__DisplayClass89_.WKkSkv6o2Vg);
		_003C_003Ec__DisplayClass89_.j1wSkS6UscM = false;
		if (text.StartsWith("!"))
		{
			text = text.Substring(1);
			_003C_003Ec__DisplayClass89_.j1wSkS6UscM = true;
		}
		_003C_003Ec__DisplayClass89_.xxGSkt0LY3h.WindowSize = text;
		string textParamValue4 = XActionHelper.GetTextParamValue(oTPgb7iY8HG, actionStep_0, _003C_003Ec__DisplayClass89_.WKkSkv6o2Vg);
		if (textParamValue4.StartsWith("["))
		{
			(string, string, string) tuple = CommonOperationItem.ExtractIconAndTitle(textParamValue4);
			_003C_003Ec__DisplayClass89_.xxGSkt0LY3h.WindowTitle = tuple.Item2;
			_003C_003Ec__DisplayClass89_.xxGSkt0LY3h.WindowIcon = tuple.Item1;
		}
		else
		{
			_003C_003Ec__DisplayClass89_.xxGSkt0LY3h.WindowTitle = textParamValue4;
			_003C_003Ec__DisplayClass89_.xxGSkt0LY3h.WindowIcon = _003C_003Ec__DisplayClass89_.WKkSkv6o2Vg.Action.Icon;
		}
		_003C_003Ec__DisplayClass89_.xxGSkt0LY3h.ItemFontSize = XActionHelper.GetNumberParamValue(YfogbeeI9wZ, actionStep_0, _003C_003Ec__DisplayClass89_.WKkSkv6o2Vg);
		_003C_003Ec__DisplayClass89_.xxGSkt0LY3h.ItemIconSize = XActionHelper.GetNumberParamValue(SIXgbYd2bbF, actionStep_0, _003C_003Ec__DisplayClass89_.WKkSkv6o2Vg);
		_003C_003Ec__DisplayClass89_.xxGSkt0LY3h.HorizontalAlignment = HorizontalAlignment.Center;
		_003C_003Ec__DisplayClass89_.xxGSkt0LY3h.SavePanelState = XActionHelper.GetBooleanParamValue(mnpgbsWsuqQ, actionStep_0, _003C_003Ec__DisplayClass89_.WKkSkv6o2Vg);
		_003C_003Ec__DisplayClass89_.xxGSkt0LY3h.MenuItems = TAcgbtAuTg1(actionStep_0, _003C_003Ec__DisplayClass89_.WKkSkv6o2Vg, nLZgbILfEyq);
		_003C_003Ec__DisplayClass89_.xxGSkt0LY3h.ButtonMenuItems = TAcgbtAuTg1(actionStep_0, _003C_003Ec__DisplayClass89_.WKkSkv6o2Vg, i5pgbWl8xYp);
		_003C_003Ec__DisplayClass89_.xxGSkt0LY3h.InitBindingProcess = XActionHelper.GetTextParamValue(m3GgbkkYlIE, actionStep_0, _003C_003Ec__DisplayClass89_.WKkSkv6o2Vg);
		string textParamValue5 = XActionHelper.GetTextParamValue(fMLgbGV8lMx, actionStep_0, _003C_003Ec__DisplayClass89_.WKkSkv6o2Vg);
		if (textParamValue5 == "1")
		{
			_003C_003Ec__DisplayClass89_.xxGSkt0LY3h.InitAutoCollapse = true;
		}
		else if (textParamValue5 == "-1")
		{
			_003C_003Ec__DisplayClass89_.xxGSkt0LY3h.InitAutoCollapse = null;
		}
		else
		{
			_003C_003Ec__DisplayClass89_.xxGSkt0LY3h.InitAutoCollapse = false;
		}
		string textParamValue6 = XActionHelper.GetTextParamValue(oB0gbVWb75A, actionStep_0, _003C_003Ec__DisplayClass89_.WKkSkv6o2Vg);
		if (!string.IsNullOrEmpty(textParamValue6))
		{
			try
			{
				_003C_003Ec__DisplayClass89_.xxGSkt0LY3h.HorizontalAlignment = textParamValue6.ToEnum<HorizontalAlignment>();
			}
			catch (Exception)
			{
				return (isSuccess: false, message: "不是合法的对齐参数。(" + textParamValue6 + ")", failReason: ActionStopFlag.OperationFailed);
			}
		}
		_003C_003Ec__DisplayClass89_.oceSk29XWkd = false;
		_003C_003Ec__DisplayClass89_.FMgSkL4GLvU = null;
		_003C_003Ec__DisplayClass89_.eCcSkJU5m8i = IntPtr.Zero;
		_003C_003Ec__DisplayClass89_.cUhSkNRTjh0 = new AutoResetEvent(false);
		_003C_003Ec__DisplayClass89_.s9sSkuCICNg = "";
		AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass89_.Oc0SWlnY6pI);
		if (_003C_003Ec__DisplayClass89_.JLJSkgp8HZM)
		{
			while (!_003C_003Ec__DisplayClass89_.oceSk29XWkd && !_003C_003Ec__DisplayClass89_.WKkSkv6o2Vg.IsShouldStopAction())
			{
				_003C_003Ec__DisplayClass89_.cUhSkNRTjh0.WaitOne();
			}
			if (!_003C_003Ec__DisplayClass89_.oceSk29XWkd)
			{
				AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass89_.vptSW3Sft79);
			}
			else
			{
				XActionHelper.OutputResultIfNeeded(eEygbrhvXTD, _003C_003Ec__DisplayClass89_.rVVSWfcUjoA, actionStep_0, _003C_003Ec__DisplayClass89_.WKkSkv6o2Vg, xaction_0);
				if (XActionHelper.IsOutputParamSetted(p0FgbKJBeQf.Key, actionStep_0) || XActionHelper.IsOutputParamSetted(BrAgbxVnhw3.Key, actionStep_0))
				{
					XActionHelper.OutputResult(p0FgbKJBeQf, actionStep_0, _003C_003Ec__DisplayClass89_.WKkSkv6o2Vg, _003C_003Ec__DisplayClass89_.FMgSkL4GLvU.ResultData, xaction_0);
					XActionHelper.OutputResult(BrAgbxVnhw3, actionStep_0, _003C_003Ec__DisplayClass89_.WKkSkv6o2Vg, _003C_003Ec__DisplayClass89_.FMgSkL4GLvU.ResultItem, xaction_0);
					if (_003C_003Ec__DisplayClass89_.FMgSkL4GLvU.ResultItem == null)
					{
						return (isSuccess: false, message: "未选择操作项", failReason: ActionStopFlag.UserCancel);
					}
				}
				XActionHelper.OutputResultIfNeeded(AsbgbpDvkyu, _003C_003Ec__DisplayClass89_.isfSWzjMT2v, actionStep_0, _003C_003Ec__DisplayClass89_.WKkSkv6o2Vg, xaction_0);
				XActionHelper.OutputResultIfNeeded(O3bgbBYx5Vd, _003C_003Ec__DisplayClass89_.vxVSkwVBxu3, actionStep_0, _003C_003Ec__DisplayClass89_.WKkSkv6o2Vg, xaction_0);
			}
			if (_003C_003Ec__DisplayClass89_.WKkSkv6o2Vg.IsShouldStopAction())
			{
				return (isSuccess: false, message: "用户取消", failReason: ActionStopFlag.UserCancel);
			}
		}
		else
		{
			XActionHelper.OutputResult(Ctqgb6kuR8I, actionStep_0, _003C_003Ec__DisplayClass89_.WKkSkv6o2Vg, (long)_003C_003Ec__DisplayClass89_.eCcSkJU5m8i, xaction_0);
		}
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private static IList<CommonOperationItem> TAcgbtAuTg1(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, StepInParamDef stepInParamDef_26)
	{
		object paramValue = XActionHelper.GetParamValue(stepInParamDef_26, actionStep_0, actionExecuteContext_0, false, true);
		IList<CommonOperationItem> list = null;
		if (paramValue is IList<CommonOperationItem> result)
		{
			return result;
		}
		string text = VariableHelper.LcfghRCibTg(paramValue);
		if (string.IsNullOrWhiteSpace(text))
		{
			return null;
		}
		text = text.Trim();
		if (text.StartsWith("[") && text.EndsWith("]"))
		{
			return JsonConvert.DeserializeObject<IList<CommonOperationItem>>(text);
		}
		return CommonOperationItem.ParseLinesWithSubItems(text, true);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(fpdgb2Rl2am, step) ?? "";
	}

	static QFB8sioH69rXvIExprT()
	{
		fpdgb2Rl2am = new StepInParamDef
		{
			Key = "operation",
			Name = "操作类型",
			Description = "",
			Type = VarType.Enum,
			DefaultValue = "show_fixed_panel_wait_close",
			SelectionItems = new SelectionItem[5]
			{
				new SelectionItem("show_fixed_panel", "显示操作窗"),
				new SelectionItem("show_fixed_panel_wait_close", "显示操作窗并等待关闭"),
				new SelectionItem("close_fixed_panel", "关闭操作窗"),
				new SelectionItem("toggle_collapse", "切换展开状态"),
				new SelectionItem("get_panel_info", "获取操作窗状态")
			},
			VariableMode = ParamVariableMode.Input,
			IsControlField = true
		};
		APRgbuL1Xe8 = new StepInParamDef
		{
			Key = "operationData",
			Name = "操作项定义",
			Description = "可以为Json/菜单文本格式/IList<CommonOperationItem>对象，详情请参考文档",
			IsMultiLine = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsRequired = true,
			ValidForList = new string[2] { "show_fixed_panel", "show_fixed_panel_wait_close" },
			TextTools = new List<TextToolType> { TextToolType.OperationItemEditor },
			TextToolsContextHint = new TextToolsContextHint
			{
				OperationItemOnlyData = false
			}
		};
		eNigbNfe8xe = new StepInParamDef
		{
			Key = "defaultOperation",
			Name = "默认Operation",
			Description = "默认的Operation值或参数组合。提供此值时，操作项可以直接通过“[图标]标题(提示)|data”的形式定义。",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.Input,
			IsMultiLine = false,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("copy", "复制"),
				new SelectionItem("paste", "粘贴"),
				new SelectionItem("pastefile", "粘贴文件"),
				new SelectionItem("pasteimage", "粘贴图片"),
				new SelectionItem("inputtext", "键入文本"),
				new SelectionItem("run", "执行命令"),
				new SelectionItem("sendkeys", "模拟按键B"),
				new SelectionItem("action", "执行动作"),
				new SelectionItem("selectfile", "定位文件"),
				new SelectionItem("inputscript", "多步骤输入"),
				new SelectionItem("sp", "执行子程序")
			},
			ValidForList = new string[2] { "show_fixed_panel", "show_fixed_panel_wait_close" }
		};
		RswgbJCa72p = new StepInParamDef
		{
			Key = "spacing",
			Name = "按钮之间的间隔",
			Description = "",
			DefaultValue = 5,
			Type = VarType.Number,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsRequired = true,
			ValidForList = new string[2] { "show_fixed_panel", "show_fixed_panel_wait_close" },
			ReplaceMode = TextToolsReplaceMode.ReplaceAll
		};
		Sxlgb0vkEBq = new StepInParamDef
		{
			Key = "spacingStr",
			Name = "按钮之间的间隔",
			Description = "可选格式1：5 => 四个边都是5；格式2：10,5 => 左右10，上下5; ",
			DefaultValue = "5",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsRequired = true,
			ValidForList = new string[2] { "show_fixed_panel", "show_fixed_panel_wait_close" },
			ReplaceMode = TextToolsReplaceMode.ReplaceAll,
			FromOldField = "spacing"
		};
		hVigbCnD96S = new StepInParamDef
		{
			Key = "buttonPadding",
			Name = "按钮内边距",
			Description = "格式1：5 => 四个边都是5；格式2：10,5 => 左右10，上下5; 格式3：7,8,9,10 => 分别指定左上右下4边边距。",
			DefaultValue = "10,6",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsRequired = true,
			ValidForList = new string[2] { "show_fixed_panel", "show_fixed_panel_wait_close" },
			ReplaceMode = TextToolsReplaceMode.ReplaceAll
		};
		QRegbPx5nBJ = new StepInParamDef
		{
			Key = "bgColor",
			Name = "背景颜色",
			Description = "",
			DefaultValue = "",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsRequired = true,
			TextTools = new List<TextToolType> { TextToolType.ColorPickerArgb },
			ValidForList = new string[2] { "show_fixed_panel", "show_fixed_panel_wait_close" },
			ReplaceMode = TextToolsReplaceMode.ReplaceAll,
			IsAdvanced = true
		};
		AQggbEWkd31 = new StepInParamDef
		{
			Key = "columnCount",
			Name = "列数",
			Description = "按钮排列方式为固定列数时，指定列数。0表示自动。",
			DefaultValue = 2,
			Type = VarType.Integer,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsRequired = true,
			ValidForList = new string[2] { "show_fixed_panel", "show_fixed_panel_wait_close" }
		};
		WYPgby763iF = new StepInParamDef
		{
			Key = "columnWidth",
			Name = "列宽",
			Description = "固定列宽时使用。0表示自动列宽，-1表示不对齐宽度，各子项根据内容自动调整宽度。",
			DefaultValue = 0,
			Type = VarType.Integer,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsRequired = true,
			ValidForList = new string[2] { "show_fixed_panel", "show_fixed_panel_wait_close" }
		};
		HRNgb8k6FmN = new StepInParamDef
		{
			Key = "groupMode",
			Name = "分组方式",
			Description = "当包含子项时，第一级节点作为分组，第二级节点作为按钮。",
			DefaultValue = "heading",
			Type = VarType.Enum,
			SelectionItems = new SelectionItem[9]
			{
				new SelectionItem("heading", "标题分组"),
				new SelectionItem("expander", "可折叠的分组"),
				new SelectionItem("tab-top", "标签页-顶部"),
				new SelectionItem("tab-left", "标签页-左侧"),
				new SelectionItem("tab-right", "标签页-右侧"),
				new SelectionItem("tab-bottom", "标签页-底部"),
				new SelectionItem("headingLeft", "多行"),
				new SelectionItem("columns", "多列"),
				new SelectionItem("none", "不分组")
			},
			ValidForList = new string[2] { "show_fixed_panel", "show_fixed_panel_wait_close" }
		};
		xVkgba5vcrR = new StepInParamDef
		{
			Key = "selectGroup",
			Name = "选择标签分组",
			Description = "标签页分组时切换至设定的标签页标题，留空表示默认。",
			DefaultValue = "",
			Type = VarType.Text,
			ValidForList = new string[2] { "show_fixed_panel", "show_fixed_panel_wait_close" }
		};
		oTPgb7iY8HG = new StepInParamDef
		{
			Key = "title",
			Name = "操作窗标题",
			Description = "标题文字，或“[图标]标题”格式。",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsRequired = true,
			ValidForList = new string[2] { "show_fixed_panel", "show_fixed_panel_wait_close" }
		};
		xRvgbRvJQoe = new StepInParamDef
		{
			Key = "windowId",
			Name = "窗口标识",
			DefaultValue = "",
			Description = "如需单独的步骤关闭窗口，需使用标识查找窗口。可使用“=”表示当前动作ID。",
			IsMultiLine = false,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsRequired = true
		};
		SiUgbqO5570 = new StepInParamDef
		{
			Key = "winLocation",
			Name = "窗口位置",
			Description = "在哪里显示选择窗口",
			Type = VarType.Enum,
			DefaultValue = ShowWindowLocation.CenterScreen.ToString(),
			SelectionItems = new SelectionItem[15]
			{
				new SelectionItem(ShowWindowLocation.WithMouse1.ToString(), "跟随鼠标（指针周围）"),
				new SelectionItem(ShowWindowLocation.WithMouse2.ToString(), "跟随鼠标（指针右下）"),
				new SelectionItem(ShowWindowLocation.CenterScreen.ToString(), "屏幕中间"),
				new SelectionItem(ShowWindowLocation.TopLeft.ToString(), "屏幕左上"),
				new SelectionItem(ShowWindowLocation.TopCenter.ToString(), "屏幕中上"),
				new SelectionItem(ShowWindowLocation.TopRight.ToString(), "屏幕右上"),
				new SelectionItem(ShowWindowLocation.LeftCenter.ToString(), "屏幕左中"),
				new SelectionItem(ShowWindowLocation.RightCenter.ToString(), "屏幕右中"),
				new SelectionItem(ShowWindowLocation.BottomLeft.ToString(), "屏幕左下"),
				new SelectionItem(ShowWindowLocation.BottomCenter.ToString(), "屏幕中下"),
				new SelectionItem(ShowWindowLocation.BottomRight.ToString(), "屏幕右下"),
				new SelectionItem(ShowWindowLocation.FullScreen.ToString(), "全屏"),
				new SelectionItem(ShowWindowLocation.Maximized.ToString(), "最大化"),
				new SelectionItem(ShowWindowLocation.Manual.ToString(), "自定义位置"),
				new SelectionItem(ShowWindowLocation.Auto.ToString(), "系统默认")
			},
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsAdvanced = true,
			ValidForList = new string[2] { "show_fixed_panel", "show_fixed_panel_wait_close" }
		};
		t5YgbcqJlyk = new StepInParamDef
		{
			Key = "winSize",
			Name = "窗口尺寸/位置",
			Description = "设置选择窗口的最大尺寸，格式为：宽度,高度。支持像素数值或屏幕宽高百分比，详情请参考模块文档。\n“窗口位置” 类型为 “自定义位置” 时用于指定显示位置，格式为：left,top,right,bottom",
			DefaultValue = "",
			Type = VarType.Text,
			IsRequired = false,
			VariableMode = ParamVariableMode.Input,
			IsAdvanced = true,
			TextTools = new List<TextToolType> { TextToolType.SelectLocationArea },
			ValidForList = new List<string> { "show_fixed_panel", "show_fixed_panel_wait_close" }
		};
		oB0gbVWb75A = new StepInParamDef
		{
			Key = "horzAlign",
			Name = "按钮内容对齐方式",
			Description = "",
			Type = VarType.Enum,
			DefaultValue = HorizontalAlignment.Center.ToString(),
			SelectionItems = new SelectionItem[3]
			{
				new SelectionItem(HorizontalAlignment.Center.ToString(), "居中"),
				new SelectionItem(HorizontalAlignment.Left.ToString(), "左侧"),
				new SelectionItem(HorizontalAlignment.Right.ToString(), "右侧")
			},
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsAdvanced = true,
			ValidForList = new string[2] { "show_fixed_panel", "show_fixed_panel_wait_close" }
		};
		D8PgbZMXeD8 = new StepInParamDef
		{
			Key = "btnColor",
			Name = "按钮颜色",
			Description = "",
			DefaultValue = "",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsRequired = false,
			TextTools = new List<TextToolType> { TextToolType.ColorPickerArgb },
			ValidForList = new string[2] { "show_fixed_panel", "show_fixed_panel_wait_close" },
			IsAdvanced = true,
			ReplaceMode = TextToolsReplaceMode.ReplaceAll
		};
		QUbgb9WmW80 = new StepInParamDef
		{
			Key = "btnBorderColor",
			Name = "按钮边框颜色",
			Description = "",
			DefaultValue = "",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsRequired = false,
			TextTools = new List<TextToolType> { TextToolType.ColorPickerArgb },
			ValidForList = new string[2] { "show_fixed_panel", "show_fixed_panel_wait_close" },
			IsAdvanced = true,
			ReplaceMode = TextToolsReplaceMode.ReplaceAll
		};
		ROggbhJhmfU = new StepInParamDef
		{
			Key = "fontColor",
			Name = "字体颜色",
			Description = "",
			DefaultValue = "",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsRequired = false,
			TextTools = new List<TextToolType> { TextToolType.ColorPickerArgb },
			ValidForList = new string[2] { "show_fixed_panel", "show_fixed_panel_wait_close" },
			IsAdvanced = true,
			ReplaceMode = TextToolsReplaceMode.ReplaceAll
		};
		YfogbeeI9wZ = new StepInParamDef
		{
			Key = "fontsize",
			Name = "字体大小",
			Description = "",
			DefaultValue = 12,
			Type = VarType.Number,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsRequired = true,
			IsAdvanced = true,
			ValidForList = new string[2] { "show_fixed_panel", "show_fixed_panel_wait_close" }
		};
		SIXgbYd2bbF = new StepInParamDef
		{
			Key = "iconsize",
			Name = "图标大小",
			Description = "图标的宽度/高度像素数",
			DefaultValue = 16,
			Type = VarType.Number,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsRequired = true,
			IsAdvanced = true,
			ValidForList = new string[2] { "show_fixed_panel", "show_fixed_panel_wait_close" }
		};
		nLZgbILfEyq = new StepInParamDef
		{
			Key = "contextMenuData",
			Name = "窗口右键菜单",
			Description = "可以为Json/菜单文本格式/IList<CommonOperationItem>对象，详情请参考文档",
			IsMultiLine = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsRequired = true,
			ValidForList = new string[2] { "show_fixed_panel", "show_fixed_panel_wait_close" },
			TextTools = new List<TextToolType> { TextToolType.OperationItemEditor },
			TextToolsContextHint = new TextToolsContextHint
			{
				OperationItemOnlyData = false
			},
			IsAdvanced = true
		};
		i5pgbWl8xYp = new StepInParamDef
		{
			Key = "buttonContextMenuData",
			Name = "默认的按钮右键菜单",
			Description = "可以为Json/菜单文本格式/IList<CommonOperationItem>对象，详情请参考文档",
			IsMultiLine = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsRequired = true,
			ValidForList = new string[2] { "show_fixed_panel", "show_fixed_panel_wait_close" },
			TextTools = new List<TextToolType> { TextToolType.OperationItemEditor },
			TextToolsContextHint = new TextToolsContextHint
			{
				OperationItemOnlyData = false
			},
			IsAdvanced = true
		};
		m3GgbkkYlIE = new StepInParamDef
		{
			Key = "bindProc",
			Name = "自动关联到进程",
			Description = "要关联的进程名称，输入“-”禁用此功能。当该进程为前台时显示操作窗，否则自动隐藏。",
			IsMultiLine = false,
			Type = VarType.Enum,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsRequired = true,
			ValidForList = new string[2] { "show_fixed_panel", "show_fixed_panel_wait_close" },
			TextTools = new List<TextToolType> { TextToolType.SelectProcessName },
			IsAdvanced = true,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("-", "禁用此功能")
			}
		};
		fMLgbGV8lMx = new StepInParamDef
		{
			Key = "autoCollapse",
			Name = "自动折叠",
			DefaultValue = "0",
			Description = "",
			Type = VarType.Enum,
			VariableMode = ParamVariableMode.Input,
			IsAdvanced = true,
			ValidForList = new string[2] { "show_fixed_panel", "show_fixed_panel_wait_close" },
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("0", "关闭"),
				new SelectionItem("1", "开启"),
				new SelectionItem("-1", "禁用此功能")
			}
		};
		mnpgbsWsuqQ = new StepInParamDef
		{
			Key = "saveState",
			Name = "记忆位置等状态",
			DefaultValue = true,
			Description = "多次使用操作窗时，保持上一次所在位置和分组",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input,
			IsAdvanced = true,
			ValidForList = new string[2] { "show_fixed_panel", "show_fixed_panel_wait_close" }
		};
		QWfgbHBapkn = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		mghgbbJEwCf = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		Ctqgb6kuR8I = new StepOutParamDef
		{
			Key = "winHandle",
			Name = "窗口句柄",
			Description = "操作窗的窗口句柄",
			Type = VarType.Integer,
			ValidForList = new List<string> { "show_fixed_panel", "get_panel_info" }
		};
		EvXgbXwlWck = new StepOutParamDef
		{
			Key = "isWindowExpanded",
			Name = "窗口是否展开",
			Description = "",
			Type = VarType.Boolean,
			ValidForList = new List<string> { "get_panel_info" }
		};
		hDNgbmEGItE = new StepOutParamDef
		{
			Key = "isWindowVisible",
			Name = "窗口是否可见",
			Description = "可能会因为关联进程而隐藏",
			Type = VarType.Boolean,
			ValidForList = new List<string> { "get_panel_info" }
		};
		p0FgbKJBeQf = new StepOutParamDef
		{
			Key = "selectedItemData",
			Name = "选择的操作项数据",
			Description = "选择的操作项的data属性数据",
			Type = VarType.Text,
			ValidForList = new List<string> { "show_fixed_panel_wait_close" }
		};
		BrAgbxVnhw3 = new StepOutParamDef
		{
			Key = "selectedItem",
			Name = "选择的操作项",
			Description = "选择的操作项的CommonOperationItem对象",
			Type = VarType.Object,
			ValidForList = new List<string> { "show_fixed_panel_wait_close" }
		};
		eEygbrhvXTD = new StepOutParamDef
		{
			Key = "currentGroup",
			Name = "当前标签分组",
			Description = "当使用标签分组显示时，关闭窗口时所停留的标签分组名称。",
			Type = VarType.Object,
			ValidForList = new List<string> { "show_fixed_panel_wait_close", "get_panel_info" }
		};
		AsbgbpDvkyu = new StepOutParamDef
		{
			Key = "buttonItemData",
			Name = "按钮操作项数据",
			Description = "点击的是按钮的菜单时，所对应按钮的操作项Data数据",
			Type = VarType.Text,
			ValidForList = new List<string> { "show_fixed_panel_wait_close" }
		};
		O3bgbBYx5Vd = new StepOutParamDef
		{
			Key = "buttonItem",
			Name = "按钮操作项",
			Description = "点击的是按钮的菜单时，所对应按钮的CommonOperationItem对象",
			Type = VarType.Object,
			ValidForList = new List<string> { "show_fixed_panel_wait_close" }
		};
		yLVgbjQbZB5 = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool uUwkhTQCjc9x5s9i8LPt()
	{
		return CKrC9wQCeAf4cyABDIa2 == null;
	}

	internal static void A3ppoAQC3cgaWFHC3e2J()
	{
	}

	internal static void wN5CTyQCE6kBh8vLDYYR()
	{
	}
}
