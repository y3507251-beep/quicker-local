using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using FontAwesome5;
using log4net;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Utilities;
using Quicker.View;
using SCyJThYoNMQE7IHLXbA;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class ShowWaitWinStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass56_0
	{
		public List<SimpleOperationItem> IloSwVJyHGV;

		public ActionStep CsuSwZuqbRg;

		public ActionExecuteContext lkZSw9cfZ5u;

		public ActionExecuteContext y5JSwhLifro;

		public string i2dSweuXWlF;

		internal static _003C_003Ec__DisplayClass56_0 fT7mcSWE2W2NopqHp5W4;

		internal void PrBSwcwEDjV()
		{
			y5JSwhLifro.CloseWaitWin("");
		}

		internal static void yXZmMQWEeVpSaS10d8BJ()
		{
		}

		internal static bool OjivFpWEAMgsvjRONOXj()
		{
			return fT7mcSWE2W2NopqHp5W4 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass56_1
	{
		public string lfxSwInbVPU;

		public string GE9SwWyUWgH;

		public string xiVSwksP5bN;

		public string j2CSwGyYNWl;

		public string npgSwsfItcs;

		public string USOSwHiCYjN;

		public string rWVSw1CjwWN;

		public bool kw4SwbAQgi6;

		public double DEtSw6LdkGN;

		public _003C_003Ec__DisplayClass56_0 gxkSwXgAH4a;

		internal static _003C_003Ec__DisplayClass56_1 aCZPDGWED3KFZygRpaW1;

		internal void U4RSwYcvi9s()
		{
			ShowWindowLocation location = ShowWindowLocation.BottomRight;
			if (!string.IsNullOrEmpty(npgSwsfItcs))
			{
				location = (ShowWindowLocation)Enum.Parse(typeof(ShowWindowLocation), npgSwsfItcs);
			}
			double numberParamValue = XActionHelper.GetNumberParamValue(WMmtU17piyH, gxkSwXgAH4a.CsuSwZuqbRg, gxkSwXgAH4a.lkZSw9cfZ5u);
			double numberParamValue2 = XActionHelper.GetNumberParamValue(BJltUb0Md1y, gxkSwXgAH4a.CsuSwZuqbRg, gxkSwXgAH4a.lkZSw9cfZ5u);
			WaitUserWindow waitUserWindow = new WaitUserWindow(lfxSwInbVPU, GE9SwWyUWgH, xiVSwksP5bN, "", gxkSwXgAH4a.y5JSwhLifro, location, j2CSwGyYNWl, gxkSwXgAH4a.IloSwVJyHGV, numberParamValue, numberParamValue2, USOSwHiCYjN)
			{
				HelpText = rWVSw1CjwWN,
				StopActionWhenClosedByCross = kw4SwbAQgi6,
				AutoCloseSeconds = DEtSw6LdkGN
			};
			if (gxkSwXgAH4a.i2dSweuXWlF == "showAndWaitClose" || gxkSwXgAH4a.i2dSweuXWlF == "show")
			{
				waitUserWindow.V6hgjEnp8ZH(gxkSwXgAH4a.lkZSw9cfZ5u.CancellationToken);
			}
			AppHelper.SetWindowIcon(waitUserWindow, gxkSwXgAH4a.lkZSw9cfZ5u?.Action?.Icon, true);
			waitUserWindow.Show();
			if (USOSwHiCYjN == "AutoActivate")
			{
				waitUserWindow.Activate();
			}
			gxkSwXgAH4a.y5JSwhLifro.AddWaiteWindow("", waitUserWindow);
			if (aCZPDGWED3KFZygRpaW1 != null)
			{
				switch (0)
				{
				}
			}
		}

		internal static bool TCtxcPWE3iyWGF0dkyyF()
		{
			return aCZPDGWED3KFZygRpaW1 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass56_2
	{
		public WaitUserWindow KtwSwKYAF7e;

		public _003C_003Ec__DisplayClass56_1 ikVSwxEAxZ5;

		private static _003C_003Ec__DisplayClass56_2 zriTI5WE117GAkoZTQaJ;

		internal void aWbSwmU6mFY()
		{
			KtwSwKYAF7e.Update(ikVSwxEAxZ5.lfxSwInbVPU, ikVSwxEAxZ5.GE9SwWyUWgH, ikVSwxEAxZ5.xiVSwksP5bN, ikVSwxEAxZ5.j2CSwGyYNWl, ikVSwxEAxZ5.gxkSwXgAH4a.IloSwVJyHGV);
		}

		internal static bool QFRgPKWEKsuQxEsL80Gc()
		{
			return zriTI5WE117GAkoZTQaJ == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass56_3
	{
		public string wTdSwpxUulb;

		public string EoGSwB3M3VT;

		public string rSDSwQiSMxM;

		public string zOySwjSWnpg;

		public WaitUserWindow wl8SwntJDFq;

		public _003C_003Ec__DisplayClass56_0 tLwSw40OlNQ;

		internal static _003C_003Ec__DisplayClass56_3 F0K1YJWEvneUAvVwK5It;

		internal void WynSwr8D0qP()
		{
			try
			{
				wl8SwntJDFq.Update(wTdSwpxUulb, EoGSwB3M3VT, rSDSwQiSMxM, zOySwjSWnpg, tLwSw40OlNQ.IloSwVJyHGV);
			}
			catch (Exception ex)
			{
				FtWtUcF8Raq.Warn("更新窗口位置异常。" + ex.Message, ex);
			}
		}

		internal static bool F2p447WEdxP4Sn78yo6e()
		{
			return F0K1YJWEvneUAvVwK5It == null;
		}
	}

	private static readonly ILog FtWtUcF8Raq;

	[CompilerGenerated]
	private readonly IEnumerable<string> htYtUVaDFuR = new string[4] { "wait", "delay", "网页", "窗口" };

	[CompilerGenerated]
	private readonly string FoytUZePyb8 = $"fa:{EFontAwesomeIcon.Light_UserEdit}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> C6ltU9oROdu = new StepRunnerCategory[1] { StepRunnerCategory.Ui };

	[CompilerGenerated]
	private readonly string KkctUhW17h9 = "https://getquicker.net/KC/Help/Doc/showwaitwin";

	[CompilerGenerated]
	private readonly bool OHKtUeH5PvW;

	private static readonly StepInParamDef eJMtUY3JoOh;

	private static readonly StepInParamDef q2itUIVS8OU;

	private static readonly StepInParamDef AcqtUWuDsf2;

	private static readonly StepInParamDef jpJtUkRRJfR;

	private static readonly StepInParamDef ctKtUGobyZu;

	private static readonly StepInParamDef naTtUsrnLEo;

	private static readonly StepInParamDef KsQtUH2YP92;

	private static readonly StepInParamDef WMmtU17piyH;

	private static readonly StepInParamDef BJltUb0Md1y;

	private static readonly StepInParamDef c1QtU619RfK;

	private static readonly StepInParamDef wsntUX6nlQ7;

	private static readonly StepInParamDef QCZtUmAtYQe;

	private static readonly StepInParamDef VnytUKDFhIQ;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> fCwtUx22WD4 = new StepInParamDef[13]
	{
		eJMtUY3JoOh, q2itUIVS8OU, AcqtUWuDsf2, ctKtUGobyZu, naTtUsrnLEo, jpJtUkRRJfR, KsQtUH2YP92, BJltUb0Md1y, WMmtU17piyH, wsntUX6nlQ7,
		c1QtU619RfK, QCZtUmAtYQe, VnytUKDFhIQ
	};

	private static readonly StepOutParamDef nU7tUrSJYN0;

	private static readonly StepOutParamDef pBPtUpOuAdK;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> oxttUBYT6sA = new StepOutParamDef[2] { nU7tUrSJYN0, pBPtUpOuAdK };

	internal static ShowWaitWinStep mqBCCVQZlFI0GEFoolmf;

	public string Key => "sys:showWaitWin";

	public string Name => "显示等待窗口";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return htYtUVaDFuR;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return FoytUZePyb8;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Ui;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return C6ltU9oROdu;
		}
	}

	public string Description => "显示一个等待用户完成某个操作的提示窗口。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return KkctUhW17h9;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return OHKtUeH5PvW;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return fCwtUx22WD4;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return oxttUBYT6sA;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
        _003C_003Ec__DisplayClass56_2 _003C_003Ec__DisplayClass56_3 = default;
        _003C_003Ec__DisplayClass56_3 _003C_003Ec__DisplayClass56_4 = default;
		_003C_003Ec__DisplayClass56_0 _003C_003Ec__DisplayClass56_ = new _003C_003Ec__DisplayClass56_0();
		_003C_003Ec__DisplayClass56_.CsuSwZuqbRg = step;
		int num = 0;
		if (mqBCCVQZlFI0GEFoolmf != null)
		{
			goto IL_001f;
		}
		goto IL_00e5;
		IL_001f:
		_003C_003Ec__DisplayClass56_.lkZSw9cfZ5u = context;
		_003C_003Ec__DisplayClass56_.i2dSweuXWlF = XActionHelper.GetTextParamValue(eJMtUY3JoOh, _003C_003Ec__DisplayClass56_.CsuSwZuqbRg, _003C_003Ec__DisplayClass56_.lkZSw9cfZ5u);
		string textParamValue = XActionHelper.GetTextParamValue(KsQtUH2YP92, _003C_003Ec__DisplayClass56_.CsuSwZuqbRg, _003C_003Ec__DisplayClass56_.lkZSw9cfZ5u);
		_003C_003Ec__DisplayClass56_.IloSwVJyHGV = null;
		if (!string.IsNullOrEmpty(textParamValue))
		{
			_003C_003Ec__DisplayClass56_.IloSwVJyHGV = AppHelper.StringToOperationItems(textParamValue, false);
		}
		_003C_003Ec__DisplayClass56_.y5JSwhLifro = ((_003C_003Ec__DisplayClass56_.lkZSw9cfZ5u.ParentContext == null) ? _003C_003Ec__DisplayClass56_.lkZSw9cfZ5u : _003C_003Ec__DisplayClass56_.lkZSw9cfZ5u.RootContext);
		if (_003C_003Ec__DisplayClass56_.i2dSweuXWlF == "show")
		{
			goto IL_0107;
		}
		if (_003C_003Ec__DisplayClass56_.i2dSweuXWlF == "showAndWaitClose")
		{
			num = 1;
			if (!Nr8JtaQZZ6VP6BbWhUtC())
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_00e5;
		}
		goto IL_0313;
		IL_01bb:
		_003C_003Ec__DisplayClass56_1 _003C_003Ec__DisplayClass56_2 = default(_003C_003Ec__DisplayClass56_1);
		_003C_003Ec__DisplayClass56_2.j2CSwGyYNWl = XActionHelper.GetTextParamValue(naTtUsrnLEo, _003C_003Ec__DisplayClass56_2.gxkSwXgAH4a.CsuSwZuqbRg, _003C_003Ec__DisplayClass56_2.gxkSwXgAH4a.lkZSw9cfZ5u);
		_003C_003Ec__DisplayClass56_2.kw4SwbAQgi6 = XActionHelper.GetBooleanParamValue(c1QtU619RfK, _003C_003Ec__DisplayClass56_2.gxkSwXgAH4a.CsuSwZuqbRg, _003C_003Ec__DisplayClass56_2.gxkSwXgAH4a.lkZSw9cfZ5u);
		_003C_003Ec__DisplayClass56_2.USOSwHiCYjN = XActionHelper.GetTextParamValue(QCZtUmAtYQe, _003C_003Ec__DisplayClass56_2.gxkSwXgAH4a.CsuSwZuqbRg, _003C_003Ec__DisplayClass56_2.gxkSwXgAH4a.lkZSw9cfZ5u);
		_003C_003Ec__DisplayClass56_2.rWVSw1CjwWN = XActionHelper.GetTextParamValue(VnytUKDFhIQ, _003C_003Ec__DisplayClass56_2.gxkSwXgAH4a.CsuSwZuqbRg, _003C_003Ec__DisplayClass56_2.gxkSwXgAH4a.lkZSw9cfZ5u);
		_003C_003Ec__DisplayClass56_2.DEtSw6LdkGN = XActionHelper.GetNumberParamValue(wsntUX6nlQ7, _003C_003Ec__DisplayClass56_2.gxkSwXgAH4a.CsuSwZuqbRg, _003C_003Ec__DisplayClass56_2.gxkSwXgAH4a.lkZSw9cfZ5u);
		_003C_003Ec__DisplayClass56_2.gxkSwXgAH4a.y5JSwhLifro.WaiteUserWindowResult = string.Empty;
		_003C_003Ec__DisplayClass56_3 = default(_003C_003Ec__DisplayClass56_2);
		if (!_003C_003Ec__DisplayClass56_2.gxkSwXgAH4a.y5JSwhLifro.IsWaitWindowClosed(""))
		{
			_003C_003Ec__DisplayClass56_3 = new _003C_003Ec__DisplayClass56_2();
			_003C_003Ec__DisplayClass56_3.ikVSwxEAxZ5 = _003C_003Ec__DisplayClass56_2;
			_003C_003Ec__DisplayClass56_3.KtwSwKYAF7e = _003C_003Ec__DisplayClass56_3.ikVSwxEAxZ5.gxkSwXgAH4a.y5JSwhLifro.GetWaitWindow("");
			goto IL_02e8;
		}
		AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass56_2.U4RSwYcvi9s);
		goto IL_0313;
		IL_0107:
		_003C_003Ec__DisplayClass56_2 = new _003C_003Ec__DisplayClass56_1();
		_003C_003Ec__DisplayClass56_2.gxkSwXgAH4a = _003C_003Ec__DisplayClass56_;
		_003C_003Ec__DisplayClass56_2.lfxSwInbVPU = XActionHelper.GetTextParamValue(q2itUIVS8OU, _003C_003Ec__DisplayClass56_2.gxkSwXgAH4a.CsuSwZuqbRg, _003C_003Ec__DisplayClass56_2.gxkSwXgAH4a.lkZSw9cfZ5u);
		_003C_003Ec__DisplayClass56_2.GE9SwWyUWgH = XActionHelper.GetTextParamValue(AcqtUWuDsf2, _003C_003Ec__DisplayClass56_2.gxkSwXgAH4a.CsuSwZuqbRg, _003C_003Ec__DisplayClass56_2.gxkSwXgAH4a.lkZSw9cfZ5u);
		_003C_003Ec__DisplayClass56_2.npgSwsfItcs = XActionHelper.GetTextParamValue(ctKtUGobyZu, _003C_003Ec__DisplayClass56_2.gxkSwXgAH4a.CsuSwZuqbRg, _003C_003Ec__DisplayClass56_2.gxkSwXgAH4a.lkZSw9cfZ5u);
		_003C_003Ec__DisplayClass56_2.xiVSwksP5bN = XActionHelper.GetTextParamValue(jpJtUkRRJfR, _003C_003Ec__DisplayClass56_2.gxkSwXgAH4a.CsuSwZuqbRg, _003C_003Ec__DisplayClass56_2.gxkSwXgAH4a.lkZSw9cfZ5u);
		goto IL_01bb;
		IL_02e8:
		AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass56_3.aWbSwmU6mFY);
		return;
		IL_0313:
		_003C_003Ec__DisplayClass56_4 = default(_003C_003Ec__DisplayClass56_3);
		if (_003C_003Ec__DisplayClass56_.i2dSweuXWlF == "update")
		{
			_003C_003Ec__DisplayClass56_4 = new _003C_003Ec__DisplayClass56_3();
			goto IL_0330;
		}
		goto IL_0432;
		IL_050c:
		Thread.Sleep(40);
		goto IL_0513;
		IL_0330:
		_003C_003Ec__DisplayClass56_4.tLwSw40OlNQ = _003C_003Ec__DisplayClass56_;
		_003C_003Ec__DisplayClass56_4.wTdSwpxUulb = XActionHelper.GetTextParamValue(q2itUIVS8OU, _003C_003Ec__DisplayClass56_4.tLwSw40OlNQ.CsuSwZuqbRg, _003C_003Ec__DisplayClass56_4.tLwSw40OlNQ.lkZSw9cfZ5u);
		_003C_003Ec__DisplayClass56_4.EoGSwB3M3VT = XActionHelper.GetTextParamValue(AcqtUWuDsf2, _003C_003Ec__DisplayClass56_4.tLwSw40OlNQ.CsuSwZuqbRg, _003C_003Ec__DisplayClass56_4.tLwSw40OlNQ.lkZSw9cfZ5u);
		_003C_003Ec__DisplayClass56_4.rSDSwQiSMxM = XActionHelper.GetTextParamValue(jpJtUkRRJfR, _003C_003Ec__DisplayClass56_4.tLwSw40OlNQ.CsuSwZuqbRg, _003C_003Ec__DisplayClass56_4.tLwSw40OlNQ.lkZSw9cfZ5u);
		_003C_003Ec__DisplayClass56_4.zOySwjSWnpg = XActionHelper.GetTextParamValue(naTtUsrnLEo, _003C_003Ec__DisplayClass56_4.tLwSw40OlNQ.CsuSwZuqbRg, _003C_003Ec__DisplayClass56_4.tLwSw40OlNQ.lkZSw9cfZ5u);
		if (!_003C_003Ec__DisplayClass56_4.tLwSw40OlNQ.y5JSwhLifro.IsWaitWindowClosed(""))
		{
			_003C_003Ec__DisplayClass56_4.wl8SwntJDFq = _003C_003Ec__DisplayClass56_4.tLwSw40OlNQ.y5JSwhLifro.GetWaitWindow("");
			if (_003C_003Ec__DisplayClass56_4.wl8SwntJDFq != null)
			{
				AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass56_4.WynSwr8D0qP);
			}
			return;
		}
		goto IL_0432;
		IL_0432:
		if (_003C_003Ec__DisplayClass56_.i2dSweuXWlF == "check")
		{
			bool flag = _003C_003Ec__DisplayClass56_.y5JSwhLifro.IsWaitWindowClosed("");
			XActionHelper.OutputResult(nU7tUrSJYN0, _003C_003Ec__DisplayClass56_.CsuSwZuqbRg, _003C_003Ec__DisplayClass56_.lkZSw9cfZ5u, flag, action);
			XActionHelper.OutputResult(pBPtUpOuAdK, _003C_003Ec__DisplayClass56_.CsuSwZuqbRg, _003C_003Ec__DisplayClass56_.lkZSw9cfZ5u, _003C_003Ec__DisplayClass56_.y5JSwhLifro.WaiteUserWindowResult ?? string.Empty, action);
		}
		if (_003C_003Ec__DisplayClass56_.i2dSweuXWlF == "close")
		{
			AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass56_.PrBSwcwEDjV);
		}
		if (_003C_003Ec__DisplayClass56_.i2dSweuXWlF == "waitClose" || _003C_003Ec__DisplayClass56_.i2dSweuXWlF == "showAndWaitClose")
		{
			if (_003C_003Ec__DisplayClass56_.i2dSweuXWlF == "showAndWaitClose")
			{
				goto IL_050c;
			}
			goto IL_0513;
		}
		return;
		IL_0513:
		bool flag2 = _003C_003Ec__DisplayClass56_.y5JSwhLifro.IsWaitWindowClosed("");
		while (!flag2)
		{
			Thread.Sleep(20);
			if (flag2 = _003C_003Ec__DisplayClass56_.y5JSwhLifro.IsWaitWindowClosed(""))
			{
				XActionHelper.OutputResult(nU7tUrSJYN0, _003C_003Ec__DisplayClass56_.CsuSwZuqbRg, _003C_003Ec__DisplayClass56_.lkZSw9cfZ5u, flag2, action);
				XActionHelper.OutputResult(pBPtUpOuAdK, _003C_003Ec__DisplayClass56_.CsuSwZuqbRg, _003C_003Ec__DisplayClass56_.lkZSw9cfZ5u, _003C_003Ec__DisplayClass56_.y5JSwhLifro.WaiteUserWindowResult ?? string.Empty, action);
			}
		}
		return;
		IL_00e5:
		switch (num)
		{
		case 1:
			goto IL_0107;
		case 5:
			goto IL_01bb;
		case 4:
			goto IL_02e8;
		case 3:
			goto IL_0330;
		case 2:
			goto IL_050c;
		}
		goto IL_001f;
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDirectValue(eJMtUY3JoOh, step);
	}

	static ShowWaitWinStep()
	{
		FtWtUcF8Raq = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		eJMtUY3JoOh = new StepInParamDef
		{
			Key = "mode",
			Name = "操作",
			Description = "请选择操作类型",
			DefaultValue = "show",
			Type = VarType.Enum,
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new SelectionItem[6]
			{
				new SelectionItem("show", "显示窗口"),
				new SelectionItem("update", "更新窗口"),
				new SelectionItem("check", "检查是否关闭"),
				new SelectionItem("close", "关闭窗口(如果还开着的话)"),
				new SelectionItem("waitClose", "等待用户关闭"),
				new SelectionItem("showAndWaitClose", "显示窗口并等待用户关闭")
			},
			IsControlField = true
		};
		q2itUIVS8OU = new StepInParamDef
		{
			Key = "title",
			Name = "窗口标题",
			Description = "",
			DefaultValue = "完成后继续",
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new string[3] { "show", "update", "showAndWaitClose" }
		};
		AcqtUWuDsf2 = new StepInParamDef
		{
			Key = "prompt",
			Name = "提示文字",
			Description = "提示文字内容",
			DefaultValue = "请在完成操作后点下面的按钮",
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new string[3] { "show", "update", "showAndWaitClose" }
		};
		jpJtUkRRJfR = new StepInParamDef
		{
			Key = "btnText",
			Name = "默认按钮上的文字",
			Description = "默认按键仅用于关闭窗口。文字内容为空时隐藏默认按钮。",
			DefaultValue = "完成",
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[3] { "show", "update", "showAndWaitClose" }
		};
		ctKtUGobyZu = new StepInParamDef
		{
			Key = "winLocation",
			Name = "窗口位置",
			Description = "在哪里显示选择窗口",
			Type = VarType.Enum,
			DefaultValue = ShowWindowLocation.BottomRight.ToString(),
			SelectionItems = new SelectionItem[12]
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
				new SelectionItem(ShowWindowLocation.LastPosition.ToString(), "上次的位置")
			},
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[2] { "show", "showAndWaitClose" }
		};
		naTtUsrnLEo = new StepInParamDef
		{
			Key = "progress",
			Name = "进度条参数",
			Description = "请以 当前值/总数 的格式传入（可使用插值方式）。 比如：40/80",
			Type = VarType.Text,
			IsRequired = false,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new string[3] { "show", "update", "showAndWaitClose" }
		};
		KsQtUH2YP92 = new StepInParamDef
		{
			Key = "operations",
			Name = "附加操作按钮",
			Description = "每行定义一个按钮，格式为 “文本” 或 “显示文本|值”。显示在默认按钮的左侧。",
			DefaultValue = "",
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.Input,
			IsMultiLine = true,
			ValidForList = new string[3] { "show", "update", "showAndWaitClose" }
		};
		WMmtU17piyH = new StepInParamDef
		{
			Key = "iconSize",
			Name = "图标大小",
			Description = "按钮上图标的大小，单位为逻辑像素。",
			DefaultValue = 16,
			Type = VarType.Number,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = false,
			ValidForList = new string[3] { "show", "update", "showAndWaitClose" }
		};
		BJltUb0Md1y = new StepInParamDef
		{
			Key = "fontsize",
			Name = "文字大小",
			Description = "按钮上文字的大小，单位为逻辑像素。",
			DefaultValue = 12,
			Type = VarType.Number,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = false,
			ValidForList = new string[3] { "show", "update", "showAndWaitClose" }
		};
		c1QtU619RfK = new StepInParamDef
		{
			Key = "stopActionIfClose",
			Name = "关闭窗口时（点右上角x按钮）后停止动作",
			DefaultValue = true,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new string[2] { "show", "showAndWaitClose" }
		};
		wsntUX6nlQ7 = new StepInParamDef
		{
			Key = "autoCloseSeconds",
			Name = "自动关闭",
			Description = "几秒后自动关闭。0表示不自动关闭。",
			DefaultValue = 0,
			Type = VarType.Number,
			IsRequired = false,
			VariableMode = ParamVariableMode.Input,
			IsAdvanced = true,
			ValidForList = new string[2] { "show", "showAndWaitClose" }
		};
		QCZtUmAtYQe = new StepInParamDef
		{
			Key = "activateMode",
			Name = "激活模式",
			Description = "",
			Type = VarType.Enum,
			DefaultValue = "NotActivatable",
			SelectionItems = new SelectionItem[3]
			{
				new SelectionItem("NotActivatable", "不支持激活（不占用焦点，仅能使用鼠标操作）"),
				new SelectionItem("NotActivated", "支持激活，打开时不抢占焦点"),
				new SelectionItem("AutoActivate", "支持激活，打开时抢占焦点")
			},
			VariableMode = ParamVariableMode.Input,
			IsAdvanced = true,
			ValidForList = new List<string> { "show", "showAndWaitClose" }
		};
		VnytUKDFhIQ = new StepInParamDef
		{
			Key = "help",
			Name = "帮助按钮内容",
			Description = "点击弹出显示帮助内容，MarkDown格式",
			DefaultValue = "",
			Type = VarType.Text,
			IsRequired = false,
			IsMultiLine = true,
			IsAdvanced = true,
			VariableMode = ParamVariableMode.Input,
			DefaultHighlightType = "MarkDown",
			ValidForList = new List<string> { "show", "showAndWaitClose" }
		};
		nU7tUrSJYN0 = new StepOutParamDef
		{
			Key = "isClosed",
			Name = "是否已关闭",
			Description = "等待窗口是否已经关闭了",
			Type = VarType.Boolean,
			ValidForList = new string[1] { "check" }
		};
		pBPtUpOuAdK = new StepOutParamDef
		{
			Key = "selectedOperation",
			Name = "选择的按钮",
			Description = "选择的后续操作项",
			Type = VarType.Text,
			ValidForList = new string[3] { "check", "waitClose", "showAndWaitClose" }
		};
	}

	internal static bool Nr8JtaQZZ6VP6BbWhUtC()
	{
		return mqBCCVQZlFI0GEFoolmf == null;
	}
}
