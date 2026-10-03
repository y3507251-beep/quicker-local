using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using bpNbEZj0vTDod37Z02B;
using dkbgyyMixGueocCf9RC;
using JTIh7V5l65QV75A93Ly;
using Quicker.Common;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Public.Entities;
using Quicker.Utilities;
using Quicker.Utilities.Win32;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class GetSysInfoStep : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec PekStTtcadb;

		public static Func<object> pRZStMRlfcU;

		public static Func<object> muaStAnOkIw;

		public static Func<object> aw2StOMZ4PL;

		public static Func<object> OEDStFg6K1d;

		public static Func<object> HoeStUTCVrt;

		public static Func<object> aL9StlN2yfA;

		public static Func<object> k9PStiBqE4X;

		private static _003C_003Ec Ul0eZYWG2Q6qmQOhpp2o;

		static _003C_003Ec()
		{
			PekStTtcadb = new _003C_003Ec();
		}

		internal object vT8StjvJe1r()
		{
			return NativeMethods.IsForegroundFullScreen();
		}

		internal object K1NStnoQ0ds()
		{
			return uT4WJujEfNmOl8aWJJC.R4Xtk9rdT8k();
		}

		internal object CdSSt4dmkDV()
		{
			return !string.IsNullOrEmpty(AppState.HHxtaMaoqJr().BasicOcrSettings?.BaiduApiKey) && !string.IsNullOrEmpty(AppState.HHxtaMaoqJr().BasicOcrSettings?.BaiduSecretKey);
		}

		internal object WhmSt5waWlA()
		{
			return AppState.DataService.IsNetworkConnected();
		}

		internal object YELStDpFNog()
		{
			return AppHelper.ckeLTO9a8ni();
		}

		internal object P3HStdYM5UO()
		{
			return FMP9ONqzXcgZ6r3WmZZ.vOSH8m04RO();
		}

		internal object Hg5StoR1wmF()
		{
			bool num = App.Current.n991yfUy4r();
			string text = AO7eLUM7kJyEdiOQu2O.ThemeMode;
			string text2 = (num ? "dark" : "light");
			if (text == "auto")
			{
				return "auto_" + text2;
			}
			return text2;
		}

		internal static bool bSVvTIWGAQdy4OZIE5GF()
		{
			return Ul0eZYWG2Q6qmQOhpp2o == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass66_0
	{
		public ActionStep x3dStf3Iyp6;

		public ActionExecuteContext fIOStzXj2Yx;

		public XAction HicSgw119YV;

		internal static _003C_003Ec__DisplayClass66_0 DZoxGXWGjYJAWibSSQE2;

		internal (bool isSuccess, string message, ActionStopFlag failReason) sRwSt3PaboP()
		{
			XActionHelper.OutputResult(Mqqtih4OBob, x3dStf3Iyp6, fIOStzXj2Yx, Environment.MachineName, HicSgw119YV);
			XActionHelper.OutputResult(ErZtisZunkV, x3dStf3Iyp6, fIOStzXj2Yx, Environment.UserName, HicSgw119YV);
			XActionHelper.OutputResult(SnktiHOOrYL, x3dStf3Iyp6, fIOStzXj2Yx, Environment.UserDomainName, HicSgw119YV);
			XActionHelper.OutputResult(GkntikKq8uA, x3dStf3Iyp6, fIOStzXj2Yx, zEhtiR7k9WE() / 1000L, HicSgw119YV);
			XActionHelper.OutputResult(J5QtiGwTQsQ, x3dStf3Iyp6, fIOStzXj2Yx, AppState.IsWindowsLocked, HicSgw119YV);
			XActionHelper.OutputResult(O1vtie8Aft5, x3dStf3Iyp6, fIOStzXj2Yx, Environment.OSVersion.Version.ToString(), HicSgw119YV);
			XActionHelper.OutputResult(QPdtiYNepTW, x3dStf3Iyp6, fIOStzXj2Yx, NativeMethods.IsOnWindows10OrLater(), HicSgw119YV);
			XActionHelper.OutputResult(YE7tiIPtYhP, x3dStf3Iyp6, fIOStzXj2Yx, NativeMethods.IsOnWindows11(), HicSgw119YV);
			Version version = Assembly.GetExecutingAssembly().GetName().Version;
			int num = version.Major * 1000 * 1000 + version.Minor * 1000 + version.Build;
			XActionHelper.OutputResult(vuYtiKUkQFQ, x3dStf3Iyp6, fIOStzXj2Yx, num, HicSgw119YV);
			using Process process = Process.GetCurrentProcess();
			XActionHelper.OutputResult(sf1tixKKdjE, x3dStf3Iyp6, fIOStzXj2Yx, (DateTime.Now - process.StartTime).TotalSeconds, HicSgw119YV);
			XActionHelper.OutputResult(e81tircZWXP, x3dStf3Iyp6, fIOStzXj2Yx, fIOStzXj2Yx.ActionId, HicSgw119YV);
			XActionHelper.OutputResult(ykCtipI1EMF, x3dStf3Iyp6, fIOStzXj2Yx, fIOStzXj2Yx.ActionTitle, HicSgw119YV);
			StepOutParamDef zuNtiBmgCMh = GetSysInfoStep.zuNtiBmgCMh;
			ActionStep step = x3dStf3Iyp6;
			ActionExecuteContext context = fIOStzXj2Yx;
			ActionItem action = fIOStzXj2Yx.Action;
			object obj;
			if (action == null)
			{
				obj = null;
			}
			else
			{
				obj = action.TemplateId;
				if (obj != null)
				{
					goto IL_0253;
				}
			}
			obj = "";
			goto IL_0253;
			IL_05e2:
			object vCKti5X8D9o;
			object step2;
			object context2;
			object obj2;
			XActionHelper.OutputResult((StepOutParamDef)vCKti5X8D9o, (ActionStep)step2, (ActionExecuteContext)context2, obj2, HicSgw119YV);
			goto IL_05ee;
			IL_05ee:
			if (XActionHelper.IsOutputParamSetted(mRxtiDEfAtq.Key, x3dStf3Iyp6))
			{
				XActionHelper.OutputResult(mRxtiDEfAtq, x3dStf3Iyp6, fIOStzXj2Yx, fIOStzXj2Yx.ExtraData?.CaptureImage, HicSgw119YV);
				fIOStzXj2Yx.RootContext.HasImageParamUsed = true;
			}
			XActionHelper.OutputResult(UkJtiW5ERvA, x3dStf3Iyp6, fIOStzXj2Yx, AppState.IsAutoRun, HicSgw119YV);
			XActionHelper.OutputResultIfNeeded(YgttiM1GeCY, _003C_003Ec.aL9StlN2yfA ?? (_003C_003Ec.aL9StlN2yfA = _003C_003Ec.PekStTtcadb.P3HStdYM5UO), x3dStf3Iyp6, fIOStzXj2Yx, HicSgw119YV);
			XActionHelper.OutputResultIfNeeded(vwAtiArScbx, _003C_003Ec.k9PStiBqE4X ?? (_003C_003Ec.k9PStiBqE4X = _003C_003Ec.PekStTtcadb.Hg5StoR1wmF), x3dStf3Iyp6, fIOStzXj2Yx, HicSgw119YV);
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			IL_0253:
			XActionHelper.OutputResult(zuNtiBmgCMh, step, context, obj, HicSgw119YV);
			XActionHelper.OutputResult(gt8tiQ6PaCK, x3dStf3Iyp6, fIOStzXj2Yx, fIOStzXj2Yx.Action?.TemplateRevision ?? 0, HicSgw119YV);
			if (XActionHelper.IsOutputParamSetted(mlqti1wIT2G.Key, x3dStf3Iyp6))
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				foreach (DictionaryEntry environmentVariable in Environment.GetEnvironmentVariables())
				{
					dictionary[(string)environmentVariable.Key] = (string)environmentVariable.Value;
				}
				XActionHelper.OutputResult(mlqti1wIT2G, x3dStf3Iyp6, fIOStzXj2Yx, dictionary, HicSgw119YV);
			}
			if (XActionHelper.IsOutputParamSetted(OlItibIK2wI.Key, x3dStf3Iyp6))
			{
				XActionHelper.OutputResult(OlItibIK2wI, x3dStf3Iyp6, fIOStzXj2Yx, $"{Screen.PrimaryScreen.Bounds.Width},{Screen.PrimaryScreen.Bounds.Height}", HicSgw119YV);
			}
			XActionHelper.OutputResultIfNeeded(V5Sti6IXqWC, _003C_003Ec.pRZStMRlfcU ?? (_003C_003Ec.pRZStMRlfcU = _003C_003Ec.PekStTtcadb.vT8StjvJe1r), x3dStf3Iyp6, fIOStzXj2Yx, HicSgw119YV);
			XActionHelper.OutputResult(kHrtijlD4LD, x3dStf3Iyp6, fIOStzXj2Yx, AppState.AppServer.GetActionRunningCount(fIOStzXj2Yx.ActionId), HicSgw119YV);
			XActionHelper.OutputResult(yW5tinhIRCU, x3dStf3Iyp6, fIOStzXj2Yx, fIOStzXj2Yx.RootContext.IsDebugging, HicSgw119YV);
			XActionHelper.OutputResult(fq5ti4sDEmc, x3dStf3Iyp6, fIOStzXj2Yx, fIOStzXj2Yx.RootContext.ActionTrigger.ToString(), HicSgw119YV);
			XActionHelper.OutputResult(Q2stid5wCOG, x3dStf3Iyp6, fIOStzXj2Yx, true, HicSgw119YV);
			XActionHelper.OutputResultIfNeeded(arytiop3pVn, _003C_003Ec.muaStAnOkIw ?? (_003C_003Ec.muaStAnOkIw = _003C_003Ec.PekStTtcadb.K1NStnoQ0ds), x3dStf3Iyp6, fIOStzXj2Yx, HicSgw119YV);
			XActionHelper.OutputResultIfNeeded(bTwtiTtfRuI, _003C_003Ec.aw2StOMZ4PL ?? (_003C_003Ec.aw2StOMZ4PL = _003C_003Ec.PekStTtcadb.CdSSt4dmkDV), x3dStf3Iyp6, fIOStzXj2Yx, HicSgw119YV);
			XActionHelper.OutputResultIfNeeded(RiRtiX13vLe, _003C_003Ec.OEDStFg6K1d ?? (_003C_003Ec.OEDStFg6K1d = _003C_003Ec.PekStTtcadb.WhmSt5waWlA), x3dStf3Iyp6, fIOStzXj2Yx, HicSgw119YV);
			XActionHelper.OutputResultIfNeeded(USKtimD7BIy, _003C_003Ec.HoeStUTCVrt ?? (_003C_003Ec.HoeStUTCVrt = _003C_003Ec.PekStTtcadb.YELStDpFNog), x3dStf3Iyp6, fIOStzXj2Yx, HicSgw119YV);
			if (XActionHelper.IsOutputParamSetted(GetSysInfoStep.vCKti5X8D9o.Key, x3dStf3Iyp6))
			{
				vCKti5X8D9o = GetSysInfoStep.vCKti5X8D9o;
				step2 = x3dStf3Iyp6;
				context2 = fIOStzXj2Yx;
				ActionExtraContextData extraData = fIOStzXj2Yx.ExtraData;
				if (extraData == null)
				{
					obj2 = null;
				}
				else
				{
					obj2 = extraData.Text;
					if (obj2 != null)
					{
						goto IL_05e2;
					}
				}
				obj2 = string.Empty;
				goto IL_05e2;
			}
			goto IL_05ee;
		}

		internal static bool aDuoPxWGDqZ7gar0kiQH()
		{
			return DZoxGXWGjYJAWibSSQE2 == null;
		}
	}

	private static List<string> Yvotiq7u0MV;

	[CompilerGenerated]
	private readonly string rYEticeOBu0 = "fa:Light_Cog:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> KtjtiVcu7FT;

	[CompilerGenerated]
	private readonly string bPCtiZUnMH3 = "https://getquicker.net/KC/Help/Doc/getsysinfo";

	[CompilerGenerated]
	private readonly bool aa9ti9nA8A9;

	private static readonly StepOutParamDef Mqqtih4OBob;

	private static readonly StepOutParamDef O1vtie8Aft5;

	private static readonly StepOutParamDef QPdtiYNepTW;

	private static readonly StepOutParamDef YE7tiIPtYhP;

	private static readonly StepOutParamDef UkJtiW5ERvA;

	private static readonly StepOutParamDef GkntikKq8uA;

	private static readonly StepOutParamDef J5QtiGwTQsQ;

	private static readonly StepOutParamDef ErZtisZunkV;

	private static readonly StepOutParamDef SnktiHOOrYL;

	private static readonly StepOutParamDef mlqti1wIT2G;

	private static readonly StepOutParamDef OlItibIK2wI;

	private static readonly StepOutParamDef V5Sti6IXqWC;

	private static readonly StepOutParamDef RiRtiX13vLe;

	private static readonly StepOutParamDef USKtimD7BIy;

	private static readonly StepOutParamDef vuYtiKUkQFQ;

	private static readonly StepOutParamDef sf1tixKKdjE;

	private static readonly StepOutParamDef e81tircZWXP;

	private static readonly StepOutParamDef ykCtipI1EMF;

	private static readonly StepOutParamDef zuNtiBmgCMh;

	private static readonly StepOutParamDef gt8tiQ6PaCK;

	private static readonly StepOutParamDef kHrtijlD4LD;

	private static readonly StepOutParamDef yW5tinhIRCU;

	private static readonly StepOutParamDef fq5ti4sDEmc;

	private static readonly StepOutParamDef vCKti5X8D9o;

	private static readonly StepOutParamDef mRxtiDEfAtq;

	private static readonly StepOutParamDef Q2stid5wCOG;

	private static readonly StepOutParamDef arytiop3pVn;

	private static readonly StepOutParamDef bTwtiTtfRuI;

	private static readonly StepOutParamDef YgttiM1GeCY;

	private static readonly StepOutParamDef vwAtiArScbx;

	private static readonly IList<StepOutParamDef> XBftiOP9YCG;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> NeTtiFCCoDN = XBftiOP9YCG;

	internal static GetSysInfoStep IjTJ99Q5uO2rDei4d55n;

	public string Key => "sys:getSysInfo";

	public string Name => "获取系统或动作信息";

	public IEnumerable<string> KeyWords => Yvotiq7u0MV;

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return rYEticeOBu0;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.System;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return KtjtiVcu7FT;
		}
	}

	public string Description => "返回Windows系统信息。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return bPCtiZUnMH3;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return aa9ti9nA8A9;
		}
	}

	public IList<StepInParamDef> InputParams => Array.Empty<StepInParamDef>();

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return NeTtiFCCoDN;
		}
	}

	static GetSysInfoStep()
	{
		Yvotiq7u0MV = new List<string> { "xtxx", "系统信息" };
		Mqqtih4OBob = new StepOutParamDef
		{
			Key = "MachineName",
			Name = "机器名",
			Description = "",
			Type = VarType.Text
		};
		O1vtie8Aft5 = new StepOutParamDef
		{
			Key = "OsVersion",
			Name = "系统版本号",
			Description = "",
			Type = VarType.Text
		};
		QPdtiYNepTW = new StepOutParamDef
		{
			Key = "isWin10",
			Name = "是否为Win10或以上",
			Description = "",
			Type = VarType.Boolean
		};
		YE7tiIPtYhP = new StepOutParamDef
		{
			Key = "isWin11",
			Name = "是否为Win11",
			Description = "",
			Type = VarType.Boolean
		};
		UkJtiW5ERvA = new StepOutParamDef
		{
			Key = "isAutoRun",
			Name = "是否自动启动",
			Description = "是否开机自动启动Quicker",
			Type = VarType.Boolean
		};
		GkntikKq8uA = new StepOutParamDef
		{
			Key = "startupSeconds",
			Name = "系统正常运行秒数",
			Description = "可参考任务管理器中显示的正常运行时间。",
			Type = VarType.Number
		};
		J5QtiGwTQsQ = new StepOutParamDef
		{
			Key = "isLocked",
			Name = "Windows是否锁定",
			Description = "",
			Type = VarType.Boolean
		};
		ErZtisZunkV = new StepOutParamDef
		{
			Key = "userName",
			Name = "用户名",
			Description = "当前登录到电脑的用户名",
			Type = VarType.Text
		};
		SnktiHOOrYL = new StepOutParamDef
		{
			Key = "userDomainName",
			Name = "用户域名",
			Description = "当前用户的网络域名（DomainName）",
			Type = VarType.Text
		};
		mlqti1wIT2G = new StepOutParamDef
		{
			Key = "sysEnv",
			Name = "环境变量",
			Description = "",
			Type = VarType.Dict
		};
		OlItibIK2wI = new StepOutParamDef
		{
			Key = "primaryScreenRes",
			Name = "主屏分辨率",
			Description = "",
			Type = VarType.Text
		};
		V5Sti6IXqWC = new StepOutParamDef
		{
			Key = "isFullscreen",
			Name = "前台窗口是否为全屏状态",
			Description = "",
			Type = VarType.Boolean
		};
		RiRtiX13vLe = new StepOutParamDef
		{
			Key = "isNetworkConnected",
			Name = "是否联网",
			Description = "",
			Type = VarType.Boolean
		};
		USKtimD7BIy = new StepOutParamDef
		{
			Key = "lanIp",
			Name = "本机局域网IP",
			Description = "",
			Type = VarType.Text
		};
		vuYtiKUkQFQ = new StepOutParamDef
		{
			Key = "quickerVersion",
			Name = "Quicker版本",
			Description = "",
			Type = VarType.Integer
		};
		sf1tixKKdjE = new StepOutParamDef
		{
			Key = "runnedSeconds",
			Name = "Quicker启动秒数",
			Description = "Quicker启动后运行的秒数",
			Type = VarType.Number
		};
		e81tircZWXP = new StepOutParamDef
		{
			Key = "actionId",
			Name = "动作ID",
			Description = "当前运行的动作ID",
			Type = VarType.Text
		};
		ykCtipI1EMF = new StepOutParamDef
		{
			Key = "actionName",
			Name = "动作名称",
			Description = "当前运行的动作名称",
			Type = VarType.Text
		};
		zuNtiBmgCMh = new StepOutParamDef
		{
			Key = "sharedActionId",
			Name = "动作库ID",
			Description = "当前动作的动作库ID",
			Type = VarType.Text
		};
		gt8tiQ6PaCK = new StepOutParamDef
		{
			Key = "sharedActionRevision",
			Name = "动作版本号",
			Description = "当前安装的动作版本",
			Type = VarType.Integer
		};
		kHrtijlD4LD = new StepOutParamDef
		{
			Key = "actionCount",
			Name = "运行个数",
			Description = "当前动作运行中的实例个数(包含此实例)",
			Type = VarType.Integer
		};
		yW5tinhIRCU = new StepOutParamDef
		{
			Key = "isDebugging",
			Name = "是否调试运行",
			Description = "是否正在调试运行动作",
			Type = VarType.Boolean
		};
		fq5ti4sDEmc = new StepOutParamDef
		{
			Key = "trigger",
			Name = "触发方式",
			Description = "动作的触发方式",
			Type = VarType.Text
		};
		vCKti5X8D9o = new StepOutParamDef
		{
			Key = "textParam",
			Name = "文本上下文参数",
			Description = "传入动作的文本上下文参数",
			Type = VarType.Text
		};
		mRxtiDEfAtq = new StepOutParamDef
		{
			Key = "imageParam",
			Name = "图片上下文参数",
			Description = "传入动作的图片上下文参数",
			Type = VarType.Image
		};
		Q2stid5wCOG = new StepOutParamDef
		{
			Key = "isPro",
			Name = "本地完整功能可用",
			Description = "本地版恒为 true。保留旧参数键以兼容已有动作，不代表会员身份。",
			Type = VarType.Boolean
		};
		arytiop3pVn = new StepOutParamDef
		{
			Key = "unionId",
			Name = "UnionId",
			Description = "一个标识用户身份的字符串",
			Type = VarType.Text
		};
		bTwtiTtfRuI = new StepOutParamDef
		{
			Key = "hasBaiduAccount",
			Name = "已设置自有百度OCR帐号",
			Description = "已经在设置中添加了自有百度OCR帐号。",
			Type = VarType.Boolean
		};
		YgttiM1GeCY = new StepOutParamDef
		{
			Key = "isWinInDarkMode",
			Name = "Windows是否为深色模式",
			Description = "true表示深色模式，false表示浅色模式。",
			Type = VarType.Boolean
		};
		vwAtiArScbx = new StepOutParamDef
		{
			Key = "quickerThemeMode",
			Name = "Quicker主题模式",
			Description = "可能为：light/dark/auto_light/auto_dark。auto_light/auto_dark表示为跟随windows，当前为浅色或深色模式。",
			Type = VarType.Text
		};
		XBftiOP9YCG = new StepOutParamDef[30]
		{
			Mqqtih4OBob, ErZtisZunkV, SnktiHOOrYL, O1vtie8Aft5, QPdtiYNepTW, YE7tiIPtYhP, UkJtiW5ERvA, GkntikKq8uA, J5QtiGwTQsQ, mlqti1wIT2G,
			OlItibIK2wI, V5Sti6IXqWC, RiRtiX13vLe, USKtimD7BIy, vuYtiKUkQFQ, Q2stid5wCOG, arytiop3pVn, bTwtiTtfRuI, sf1tixKKdjE, e81tircZWXP,
			ykCtipI1EMF, zuNtiBmgCMh, gt8tiQ6PaCK, kHrtijlD4LD, yW5tinhIRCU, fq5ti4sDEmc, vCKti5X8D9o, mRxtiDEfAtq, YgttiM1GeCY, vwAtiArScbx
		};
		foreach (StepOutParamDef item in XBftiOP9YCG)
		{
			Yvotiq7u0MV.Add(item.Name);
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	[DllImport("kernel32.dll", EntryPoint = "GetTickCount64")]
	private static extern long zEhtiR7k9WE();

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass66_0 _003C_003Ec__DisplayClass66_ = new _003C_003Ec__DisplayClass66_0();
		_003C_003Ec__DisplayClass66_.x3dStf3Iyp6 = step;
		_003C_003Ec__DisplayClass66_.fIOStzXj2Yx = context;
		_003C_003Ec__DisplayClass66_.HicSgw119YV = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass66_.fIOStzXj2Yx, _003C_003Ec__DisplayClass66_.x3dStf3Iyp6, _003C_003Ec__DisplayClass66_.HicSgw119YV, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass66_.sRwSt3PaboP, (Action)null, (Action)null, (StepInParamDef)null, (StepOutParamDef)null);
	}

	public string GetSummary(ActionStep step)
	{
		return "";
	}

	internal static bool rqQdLcQ5oaoGR2yGU3R4()
	{
		return IjTJ99Q5uO2rDei4d55n == null;
	}

	internal static void ASNHVtQ55vfx312i0plR()
	{
	}
}
