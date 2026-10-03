using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using FontAwesome5;
using log4net;
using QPyExnjv1DDTjWlN0fZ;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Utilities;

namespace PtKu3CoDZRKU2gJOhGP;

internal class mdl19houn1koN1ScTOq : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass51_0
	{
		public ActionStep EEPSINiuSAI;

		public ActionExecuteContext dhQSIJDSdxR;

		public mdl19houn1koN1ScTOq aNCSI0sa1t4;

		public XAction JgXSICBcYko;

		private static _003C_003Ec__DisplayClass51_0 wf6UZZWuhyR289ECkh9I;

		internal (bool isSuccess, string message, ActionStopFlag failReason) TMlSIuGgeIF()
		{
			string textParamValue = XActionHelper.GetTextParamValue(UXwgHrmwuT4, EEPSINiuSAI, dhQSIJDSdxR);
			string textParamValue2 = XActionHelper.GetTextParamValue(gwPgHpq5glc, EEPSINiuSAI, dhQSIJDSdxR);
			if (!Directory.Exists(textParamValue2))
			{
				return (isSuccess: false, message: "文件夹" + textParamValue2 + "不存在!", failReason: ActionStopFlag.OperationFailed);
			}
			string textParamValue3 = XActionHelper.GetTextParamValue(OrngHB5GCcv, EEPSINiuSAI, dhQSIJDSdxR);
			string textParamValue4 = XActionHelper.GetTextParamValue(OAagHQQrWel, EEPSINiuSAI, dhQSIJDSdxR);
			bool booleanParamValue = XActionHelper.GetBooleanParamValue(V3egHjtJLo8, EEPSINiuSAI, dhQSIJDSdxR);
			NotifyFilters notifyFilters_ = NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.LastWrite;
			if (!string.IsNullOrWhiteSpace(textParamValue4))
			{
				notifyFilters_ = aNCSI0sa1t4.kOUgH1WlJOl(textParamValue4);
			}
			if (!(textParamValue == "wait"))
			{
				if (!(textParamValue == "callback"))
				{
					return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
				}
				return aNCSI0sa1t4.YWQgHbKD7ZD(textParamValue2, booleanParamValue, textParamValue3, notifyFilters_, dhQSIJDSdxR, EEPSINiuSAI, JgXSICBcYko);
			}
			return aNCSI0sa1t4.yDHgH6eGpCG(textParamValue2, booleanParamValue, textParamValue3, notifyFilters_, dhQSIJDSdxR, EEPSINiuSAI, JgXSICBcYko);
		}

		internal static bool XQsGWaWuHPRX7iMZY8sl()
		{
			return wf6UZZWuhyR289ECkh9I == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass54_0
	{
		public FileSystemWatcher TjISIEdUZSR;

		public string qRVSIyrjvie;

		public ActionExecuteContext WQISI8pyS3i;

		private static _003C_003Ec__DisplayClass54_0 oYVEJyWoVou8HkOoXW0J;

		internal void oRvSIPRIfPi()
		{
			TjISIEdUZSR = new FileSystemWatcher(qRVSIyrjvie);
		}

		internal static bool SiMcGgWoQArLUEJ9mLlM()
		{
			return oYVEJyWoVou8HkOoXW0J == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass54_1
	{
		public string Xt8SIRdOJGW;

		public _003C_003Ec__DisplayClass54_0 ALqSIqJZgft;

		internal static _003C_003Ec__DisplayClass54_1 MRpWICWocmpE50q8pVSU;

		internal bool OaeSIaOVvFj(SubProgram x)
		{
			return x.Name == Xt8SIRdOJGW;
		}

		internal void WCnSI7IWx21(object sender, FileSystemEventArgs e)
		{
			try
			{
				ALqSIqJZgft.WQISI8pyS3i.RunSp(Xt8SIRdOJGW, new Dictionary<string, object>
				{
					{
						"ChangeType",
						e.ChangeType.ToString()
					},
					{ "FullPath", e.FullPath },
					{ "Name", e.Name }
				});
			}
			catch (Exception ex)
			{
				string message = "文件(" + e.Name + ")创建回调出错：" + ex.Message;
				GDRgHiyifow.Warn(message, ex);
				AppHelper.ShowWarning(message);
			}
		}

		internal static void qFiiobWopQKBJ7LiopUP()
		{
		}

		internal static bool FSyjqrWoW2WiG0NLYFYp()
		{
			return MRpWICWocmpE50q8pVSU == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass54_2
	{
		public string xEjSIZrfnr9;

		public _003C_003Ec__DisplayClass54_0 HuSSI9gJZMD;

		internal static _003C_003Ec__DisplayClass54_2 qrWjDhWoXJ3Os69Ned91;

		internal bool xeKSIcA2RVR(SubProgram x)
		{
			return x.Name == xEjSIZrfnr9;
		}

		internal void eD9SIVTNjg1(object sender, FileSystemEventArgs e)
		{
			try
			{
				HuSSI9gJZMD.WQISI8pyS3i.RunSp(xEjSIZrfnr9, new Dictionary<string, object>
				{
					{
						"ChangeType",
						e.ChangeType.ToString()
					},
					{ "FullPath", e.FullPath },
					{ "Name", e.Name }
				});
			}
			catch (Exception ex)
			{
				string message = "文件(" + e.Name + ")删除回调出错：" + ex.Message;
				GDRgHiyifow.Warn(message, ex);
				AppHelper.ShowWarning(message);
			}
		}

		internal static bool Nr2l2iWo2sLLUvSfDAX7()
		{
			return qrWjDhWoXJ3Os69Ned91 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass54_3
	{
		public string a76SIY19gU2;

		public _003C_003Ec__DisplayClass54_0 uy5SIIiQqcm;

		internal static _003C_003Ec__DisplayClass54_3 rVWH88WonauVcapdcbGX;

		internal bool DdESIhvnTrN(SubProgram x)
		{
			return x.Name == a76SIY19gU2;
		}

		internal void byySIesQlPo(object sender, FileSystemEventArgs e)
		{
			try
			{
				uy5SIIiQqcm.WQISI8pyS3i.RunSp(a76SIY19gU2, new Dictionary<string, object>
				{
					{
						"ChangeType",
						e.ChangeType.ToString()
					},
					{ "FullPath", e.FullPath },
					{ "Name", e.Name }
				});
			}
			catch (Exception ex)
			{
				string message = "文件(" + e.Name + ")变更回调出错：" + ex.Message;
				GDRgHiyifow.Warn(message, ex);
				AppHelper.ShowWarning(message);
			}
		}

		internal static bool GDkI5fWoec7tLN3Nb7dk()
		{
			return rVWH88WonauVcapdcbGX == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass54_4
	{
		public string JepSIGLsi9V;

		public _003C_003Ec__DisplayClass54_0 ym9SIskMmsp;

		private static _003C_003Ec__DisplayClass54_4 qQBSDUWoDE5oVkrdPDGn;

		internal bool CQgSIW14g6F(SubProgram x)
		{
			return x.Name == JepSIGLsi9V;
		}

		internal void LOASIkfpXMb(object sender, RenamedEventArgs e)
		{
			try
			{
				ym9SIskMmsp.WQISI8pyS3i.RunSp(JepSIGLsi9V, new Dictionary<string, object>
				{
					{
						"ChangeType",
						e.ChangeType.ToString()
					},
					{ "FullPath", e.FullPath },
					{ "Name", e.Name },
					{ "OldFullPath", e.OldFullPath },
					{ "OldName", e.OldName }
				});
			}
			catch (Exception ex)
			{
				string message = "文件(" + e.Name + ")重命名回调出错：" + ex.Message;
				GDRgHiyifow.Warn(message, ex);
				AppHelper.ShowWarning(message);
			}
		}

		internal static bool ivtVwWWo3rZd93w7yWxX()
		{
			return qQBSDUWoDE5oVkrdPDGn == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass55_0
	{
		public FileSystemWatcher kBLSImvyPHB;

		public string Q0HSIK7GZx0;

		public WatcherChangeTypes Bn7SIxHxVxs;

		public string vVKSIrO7SLD;

		public bool bt3SIprS4KI;

		public string NnnSIBoulHf;

		public FileSystemEventHandler JLwSIQn7Swk;

		public FileSystemEventHandler exoSIj6LepA;

		public FileSystemEventHandler YTcSInuVY0Y;

		public RenamedEventHandler MwuSI4AxyWi;

		private static _003C_003Ec__DisplayClass55_0 BgWPjcWo0yH4HCkMwZx2;

		internal void mk1SIHeljGo()
		{
			kBLSImvyPHB = new FileSystemWatcher(Q0HSIK7GZx0);
		}

		internal void HlLSI1cEe4j(object sender, FileSystemEventArgs e)
		{
			Bn7SIxHxVxs = e.ChangeType;
			vVKSIrO7SLD = e.FullPath;
			bt3SIprS4KI = true;
		}

		internal void Sv4SIbyJnMC(object sender, FileSystemEventArgs e)
		{
			Bn7SIxHxVxs = e.ChangeType;
			vVKSIrO7SLD = e.FullPath;
			bt3SIprS4KI = true;
		}

		internal void MZMSI6KDKj4(object sender, FileSystemEventArgs e)
		{
			Bn7SIxHxVxs = e.ChangeType;
			vVKSIrO7SLD = e.FullPath;
			bt3SIprS4KI = true;
		}

		internal void GGiSIX6sxyy(object sender, RenamedEventArgs e)
		{
			Bn7SIxHxVxs = e.ChangeType;
			vVKSIrO7SLD = e.FullPath;
			NnnSIBoulHf = e.OldFullPath;
			bt3SIprS4KI = true;
		}

		internal static bool d5WGXOWo18WC3XeUO9oF()
		{
			return BgWPjcWo0yH4HCkMwZx2 == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> pHVgHX5CDgD = new string[1] { "" };

	[CompilerGenerated]
	private readonly string e6igHmTucih = $"fa:{EFontAwesomeIcon.Light_MonitorHeartRate}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> FwwgHKoEmqM;

	[CompilerGenerated]
	private readonly string UuEgHxXeeJR = "https://getquicker.net/KC/Help/Doc/filesystemwatch";

	public static StepInParamDef UXwgHrmwuT4;

	public static StepInParamDef gwPgHpq5glc;

	public static StepInParamDef OrngHB5GCcv;

	public static StepInParamDef OAagHQQrWel;

	private static readonly StepInParamDef V3egHjtJLo8;

	public static StepInParamDef NYxgHnHUI7J;

	public static StepInParamDef aHPgH4KgIE2;

	public static StepInParamDef zeygH5Dp4Wj;

	public static StepInParamDef qdagHDYKe1e;

	public static StepInParamDef ChjgHd4dJpj;

	public static StepInParamDef lQEgHo0b4N0;

	private static readonly StepInParamDef jYwgHTj2V71;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> UB0gHMpfSOr = new List<StepInParamDef>
	{
		UXwgHrmwuT4, gwPgHpq5glc, V3egHjtJLo8, OrngHB5GCcv, OAagHQQrWel, NYxgHnHUI7J, aHPgH4KgIE2, qdagHDYKe1e, zeygH5Dp4Wj, ChjgHd4dJpj,
		lQEgHo0b4N0, jYwgHTj2V71
	};

	private static readonly StepOutParamDef uIsgHAnK7Q5;

	private static readonly StepOutParamDef ONFgHOrFtRQ;

	private static readonly StepOutParamDef jaRgHFfH9wD;

	private static readonly StepOutParamDef tvKgHUibqc1;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> fikgHlZ8HCD = new List<StepOutParamDef> { uIsgHAnK7Q5, ONFgHOrFtRQ, jaRgHFfH9wD, tvKgHUibqc1 };

	private static readonly ILog GDRgHiyifow;

	internal static mdl19houn1koN1ScTOq Ow9cOjQsOW4pA9T4anRC;

	public string Key => "sys:fileSystemWatch";

	public string Name => "文件系统监控";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return pHVgHX5CDgD;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return e6igHmTucih;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.System;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return FwwgHKoEmqM;
		}
	}

	public string Description => "监控文件创建/变更/删除等事件。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return UuEgHxXeeJR;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly => false;

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return UB0gHMpfSOr;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return fikgHlZ8HCD;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass51_0 _003C_003Ec__DisplayClass51_ = new _003C_003Ec__DisplayClass51_0();
		_003C_003Ec__DisplayClass51_.EEPSINiuSAI = step;
		_003C_003Ec__DisplayClass51_.dhQSIJDSdxR = context;
		_003C_003Ec__DisplayClass51_.aNCSI0sa1t4 = this;
		_003C_003Ec__DisplayClass51_.JgXSICBcYko = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass51_.dhQSIJDSdxR, _003C_003Ec__DisplayClass51_.EEPSINiuSAI, _003C_003Ec__DisplayClass51_.JgXSICBcYko, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass51_.TMlSIuGgeIF, (Action)null, (Action)null, jYwgHTj2V71, uIsgHAnK7Q5);
	}

	private NotifyFilters kOUgH1WlJOl(string string_1)
	{
		NotifyFilters notifyFilters = (NotifyFilters)0;
		string[] array = string_1.SplitToList(',', '，', '；', ';', '|');
		for (int i = 0; i < array.Length; i++)
		{
			if (Enum.TryParse<NotifyFilters>(array[i], true, out var result))
			{
				notifyFilters |= result;
			}
		}
		return notifyFilters;
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) YWQgHbKD7ZD(string string_1, bool bool_0, string string_2, NotifyFilters notifyFilters_0, ActionExecuteContext actionExecuteContext_0, ActionStep actionStep_0, XAction xaction_0)
	{
		_003C_003Ec__DisplayClass54_0 _003C_003Ec__DisplayClass54_ = new _003C_003Ec__DisplayClass54_0();
		_003C_003Ec__DisplayClass54_.qRVSIyrjvie = string_1;
		_003C_003Ec__DisplayClass54_.WQISI8pyS3i = actionExecuteContext_0;
		_003C_003Ec__DisplayClass54_.TjISIEdUZSR = null;
		Eyj6tHjFG6nBtP2QVK1.EGItkvvs4RQ().Invoke(_003C_003Ec__DisplayClass54_.oRvSIPRIfPi);
		_003C_003Ec__DisplayClass54_.TjISIEdUZSR.Filter = string_2;
		_003C_003Ec__DisplayClass54_.TjISIEdUZSR.NotifyFilter = notifyFilters_0;
		_003C_003Ec__DisplayClass54_.TjISIEdUZSR.IncludeSubdirectories = bool_0;
		bool flag = false;
		_003C_003Ec__DisplayClass54_1 _003C_003Ec__DisplayClass54_2 = new _003C_003Ec__DisplayClass54_1();
		_003C_003Ec__DisplayClass54_2.ALqSIqJZgft = _003C_003Ec__DisplayClass54_;
		_003C_003Ec__DisplayClass54_2.Xt8SIRdOJGW = XActionHelper.GetTextParamValue(qdagHDYKe1e, actionStep_0, _003C_003Ec__DisplayClass54_2.ALqSIqJZgft.WQISI8pyS3i);
		if (!string.IsNullOrWhiteSpace(_003C_003Ec__DisplayClass54_2.Xt8SIRdOJGW))
		{
			IList<SubProgram> subPrograms = xaction_0.SubPrograms;
			if (subPrograms != null && !subPrograms.Any(_003C_003Ec__DisplayClass54_2.OaeSIaOVvFj))
			{
				return (isSuccess: false, message: "子程序" + _003C_003Ec__DisplayClass54_2.Xt8SIRdOJGW + "不存在！", failReason: ActionStopFlag.OperationFailed);
			}
			_003C_003Ec__DisplayClass54_2.ALqSIqJZgft.TjISIEdUZSR.Created += _003C_003Ec__DisplayClass54_2.WCnSI7IWx21;
			flag = true;
		}
		_003C_003Ec__DisplayClass54_2 _003C_003Ec__DisplayClass54_3 = new _003C_003Ec__DisplayClass54_2();
		_003C_003Ec__DisplayClass54_3.HuSSI9gJZMD = _003C_003Ec__DisplayClass54_;
		_003C_003Ec__DisplayClass54_3.xEjSIZrfnr9 = XActionHelper.GetTextParamValue(ChjgHd4dJpj, actionStep_0, _003C_003Ec__DisplayClass54_3.HuSSI9gJZMD.WQISI8pyS3i);
		if (!string.IsNullOrWhiteSpace(_003C_003Ec__DisplayClass54_3.xEjSIZrfnr9))
		{
			IList<SubProgram> subPrograms2 = xaction_0.SubPrograms;
			if (subPrograms2 != null && !subPrograms2.Any(_003C_003Ec__DisplayClass54_3.xeKSIcA2RVR))
			{
				return (isSuccess: false, message: "子程序" + _003C_003Ec__DisplayClass54_3.xEjSIZrfnr9 + "不存在！", failReason: ActionStopFlag.OperationFailed);
			}
			_003C_003Ec__DisplayClass54_3.HuSSI9gJZMD.TjISIEdUZSR.Deleted += _003C_003Ec__DisplayClass54_3.eD9SIVTNjg1;
			flag = true;
		}
		_003C_003Ec__DisplayClass54_3 _003C_003Ec__DisplayClass54_4 = new _003C_003Ec__DisplayClass54_3();
		_003C_003Ec__DisplayClass54_4.uy5SIIiQqcm = _003C_003Ec__DisplayClass54_;
		_003C_003Ec__DisplayClass54_4.a76SIY19gU2 = XActionHelper.GetTextParamValue(zeygH5Dp4Wj, actionStep_0, _003C_003Ec__DisplayClass54_4.uy5SIIiQqcm.WQISI8pyS3i);
		if (!string.IsNullOrWhiteSpace(_003C_003Ec__DisplayClass54_4.a76SIY19gU2))
		{
			IList<SubProgram> subPrograms3 = xaction_0.SubPrograms;
			if (subPrograms3 != null && !subPrograms3.Any(_003C_003Ec__DisplayClass54_4.DdESIhvnTrN))
			{
				return (isSuccess: false, message: "子程序" + _003C_003Ec__DisplayClass54_4.a76SIY19gU2 + "不存在！", failReason: ActionStopFlag.OperationFailed);
			}
			_003C_003Ec__DisplayClass54_4.uy5SIIiQqcm.TjISIEdUZSR.Changed += _003C_003Ec__DisplayClass54_4.byySIesQlPo;
			flag = true;
		}
		_003C_003Ec__DisplayClass54_4 _003C_003Ec__DisplayClass54_5 = new _003C_003Ec__DisplayClass54_4();
		_003C_003Ec__DisplayClass54_5.ym9SIskMmsp = _003C_003Ec__DisplayClass54_;
		_003C_003Ec__DisplayClass54_5.JepSIGLsi9V = XActionHelper.GetTextParamValue(lQEgHo0b4N0, actionStep_0, _003C_003Ec__DisplayClass54_5.ym9SIskMmsp.WQISI8pyS3i);
		if (!string.IsNullOrWhiteSpace(_003C_003Ec__DisplayClass54_5.JepSIGLsi9V))
		{
			IList<SubProgram> subPrograms4 = xaction_0.SubPrograms;
			if (subPrograms4 != null && !subPrograms4.Any(_003C_003Ec__DisplayClass54_5.CQgSIW14g6F))
			{
				return (isSuccess: false, message: "子程序" + _003C_003Ec__DisplayClass54_5.JepSIGLsi9V + "不存在！", failReason: ActionStopFlag.OperationFailed);
			}
			_003C_003Ec__DisplayClass54_5.ym9SIskMmsp.TjISIEdUZSR.Renamed += _003C_003Ec__DisplayClass54_5.LOASIkfpXMb;
			flag = true;
		}
		if (!flag)
		{
			return (isSuccess: false, message: "没有设置事件回调子程序。", failReason: ActionStopFlag.OperationFailed);
		}
		_003C_003Ec__DisplayClass54_.TjISIEdUZSR.EnableRaisingEvents = true;
		while (!_003C_003Ec__DisplayClass54_.WQISI8pyS3i.IsShouldStopAction())
		{
			CancellationToken? cancellationToken = _003C_003Ec__DisplayClass54_.WQISI8pyS3i.CancellationToken;
			if (cancellationToken.HasValue && cancellationToken.GetValueOrDefault().IsCancellationRequested)
			{
				break;
			}
			Thread.Sleep(1000);
		}
		_003C_003Ec__DisplayClass54_.TjISIEdUZSR.EnableRaisingEvents = false;
		_003C_003Ec__DisplayClass54_.TjISIEdUZSR.Dispose();
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) yDHgH6eGpCG(string string_1, bool bool_0, string string_2, NotifyFilters notifyFilters_0, ActionExecuteContext actionExecuteContext_0, ActionStep actionStep_0, XAction xaction_0)
	{
		_003C_003Ec__DisplayClass55_0 _003C_003Ec__DisplayClass55_ = new _003C_003Ec__DisplayClass55_0();
		_003C_003Ec__DisplayClass55_.Q0HSIK7GZx0 = string_1;
		_003C_003Ec__DisplayClass55_.kBLSImvyPHB = null;
		Eyj6tHjFG6nBtP2QVK1.EGItkvvs4RQ().Invoke(_003C_003Ec__DisplayClass55_.mk1SIHeljGo);
		_003C_003Ec__DisplayClass55_.kBLSImvyPHB.Filter = string_2;
		_003C_003Ec__DisplayClass55_.kBLSImvyPHB.NotifyFilter = notifyFilters_0;
		_003C_003Ec__DisplayClass55_.kBLSImvyPHB.IncludeSubdirectories = bool_0;
		double numberParamValue = XActionHelper.GetNumberParamValue(aHPgH4KgIE2, actionStep_0, actionExecuteContext_0);
		string[] array = XActionHelper.GetTextParamValue(NYxgHnHUI7J, actionStep_0, actionExecuteContext_0).ToLower().SplitToList(',', '，', ';');
		_003C_003Ec__DisplayClass55_.Bn7SIxHxVxs = WatcherChangeTypes.Changed;
		_003C_003Ec__DisplayClass55_.vVKSIrO7SLD = "";
		_003C_003Ec__DisplayClass55_.NnnSIBoulHf = "";
		_003C_003Ec__DisplayClass55_.bt3SIprS4KI = false;
		string[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			switch (array2[i])
			{
			case "renamed":
				_003C_003Ec__DisplayClass55_.kBLSImvyPHB.Renamed += _003C_003Ec__DisplayClass55_.MwuSI4AxyWi ?? (_003C_003Ec__DisplayClass55_.MwuSI4AxyWi = _003C_003Ec__DisplayClass55_.GGiSIX6sxyy);
				break;
			case "changed":
				_003C_003Ec__DisplayClass55_.kBLSImvyPHB.Changed += _003C_003Ec__DisplayClass55_.YTcSInuVY0Y ?? (_003C_003Ec__DisplayClass55_.YTcSInuVY0Y = _003C_003Ec__DisplayClass55_.MZMSI6KDKj4);
				break;
			case "deleted":
				_003C_003Ec__DisplayClass55_.kBLSImvyPHB.Deleted += _003C_003Ec__DisplayClass55_.exoSIj6LepA ?? (_003C_003Ec__DisplayClass55_.exoSIj6LepA = _003C_003Ec__DisplayClass55_.Sv4SIbyJnMC);
				break;
			case "created":
				_003C_003Ec__DisplayClass55_.kBLSImvyPHB.Created += _003C_003Ec__DisplayClass55_.JLwSIQn7Swk ?? (_003C_003Ec__DisplayClass55_.JLwSIQn7Swk = _003C_003Ec__DisplayClass55_.HlLSI1cEe4j);
				break;
			}
		}
		actionExecuteContext_0.ActionLogger.LogInfo("即将开始监控，事件可能同时发生，可能会导致动作log格式出错。");
		_003C_003Ec__DisplayClass55_.kBLSImvyPHB.EnableRaisingEvents = true;
		if (numberParamValue > 0.0)
		{
			double num = (double)AppHelper.fLiLTj0x4QY() + numberParamValue * 1000.0;
			while (!actionExecuteContext_0.IsShouldStopAction() && !_003C_003Ec__DisplayClass55_.bt3SIprS4KI && !((double)AppHelper.fLiLTj0x4QY() >= num))
			{
				Thread.Sleep(20);
			}
		}
		else
		{
			while (!actionExecuteContext_0.IsShouldStopAction() && !_003C_003Ec__DisplayClass55_.bt3SIprS4KI)
			{
				Thread.Sleep(20);
			}
		}
		_003C_003Ec__DisplayClass55_.kBLSImvyPHB.EnableRaisingEvents = false;
		_003C_003Ec__DisplayClass55_.kBLSImvyPHB.Dispose();
		if (!_003C_003Ec__DisplayClass55_.bt3SIprS4KI)
		{
			return (isSuccess: false, message: "等待超时", failReason: ActionStopFlag.OperationFailed);
		}
		XActionHelper.OutputResult(ONFgHOrFtRQ, actionStep_0, actionExecuteContext_0, _003C_003Ec__DisplayClass55_.vVKSIrO7SLD, xaction_0);
		XActionHelper.OutputResult(jaRgHFfH9wD, actionStep_0, actionExecuteContext_0, _003C_003Ec__DisplayClass55_.Bn7SIxHxVxs.ToString(), xaction_0);
		XActionHelper.OutputResult(tvKgHUibqc1, actionStep_0, actionExecuteContext_0, _003C_003Ec__DisplayClass55_.NnnSIBoulHf, xaction_0);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(UXwgHrmwuT4, step) + " " + XActionHelper.GetParamDisplayString(gwPgHpq5glc, step);
	}

	static mdl19houn1koN1ScTOq()
	{
		UXwgHrmwuT4 = new StepInParamDef
		{
			Key = "operation",
			Name = "操作类型",
			DefaultValue = "wait",
			Description = "时间数据来源",
			VariableMode = ParamVariableMode.Input,
			Type = VarType.Enum,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("wait", "等待事件发生"),
				new SelectionItem("callback", "持续监控（事件发生后调用子程序）")
			},
			IsControlField = true
		};
		gwPgHpq5glc = new StepInParamDef
		{
			Key = "path",
			Name = "文件夹路径",
			Type = VarType.Text,
			Description = "要监控的文件夹路径"
		};
		OrngHB5GCcv = new StepInParamDef
		{
			Key = "filter",
			Name = "文件筛选",
			Type = VarType.Text,
			DefaultValue = "*.*",
			Description = "筛选要监控的文件。可指定文件名（如foo.txt），或使用通配符（如*.txt）"
		};
		OAagHQQrWel = new StepInParamDef
		{
			Key = "notifyFilter",
			Name = "通知筛选",
			Type = VarType.Text,
			DefaultValue = "",
			Description = "可选，可选值请参考文档。留空表示默认设置(LastWrite,FileName,DirectoryName)。"
		};
		V3egHjtJLo8 = new StepInParamDef
		{
			Key = "includeSubdirectories",
			Name = "包含子文件夹",
			DefaultValue = true,
			Description = "",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		NYxgHnHUI7J = new StepInParamDef
		{
			Key = "waitEvents",
			Name = "等待的事件",
			Type = VarType.Text,
			DefaultValue = "created",
			Description = "",
			ValidForList = new string[1] { "wait" }
		};
		aHPgH4KgIE2 = new StepInParamDef
		{
			Key = "waitSeconds",
			Name = "等待秒数",
			Type = VarType.Number,
			DefaultValue = 0,
			Description = "最长等待时间。0表示不限时间。",
			ValidForList = new string[1] { "wait" }
		};
		zeygH5Dp4Wj = new StepInParamDef
		{
			Key = "changedCallback",
			Name = "[变更] 处理子程序",
			Type = VarType.Text,
			Description = "文件或文件夹变更时调用的子程序",
			ValidForList = new string[1] { "callback" }
		};
		qdagHDYKe1e = new StepInParamDef
		{
			Key = "createdCallback",
			Name = "[创建] 处理子程序",
			Type = VarType.Text,
			Description = "文件或文件创建时调用的子程序",
			ValidForList = new string[1] { "callback" }
		};
		ChjgHd4dJpj = new StepInParamDef
		{
			Key = "deletedCallback",
			Name = "[删除] 处理子程序",
			Type = VarType.Text,
			Description = "文件或文件被删除时调用的子程序",
			ValidForList = new string[1] { "callback" }
		};
		lQEgHo0b4N0 = new StepInParamDef
		{
			Key = "renamedCallback",
			Name = "[重命名] 处理子程序",
			Type = VarType.Text,
			Description = "文件或文件重命名时调用的子程序",
			ValidForList = new string[1] { "callback" }
		};
		jYwgHTj2V71 = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		uIsgHAnK7Q5 = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		ONFgHOrFtRQ = new StepOutParamDef
		{
			Key = "fullPath",
			Name = "变更的路径",
			Description = "发生变更的文件(夹)路径，或重命名后的新路径",
			Type = VarType.Text,
			ValidForList = new string[1] { "wait" }
		};
		jaRgHFfH9wD = new StepOutParamDef
		{
			Key = "changedType",
			Name = "变更类型",
			Description = "变更类型",
			Type = VarType.Text,
			ValidForList = new string[1] { "wait" }
		};
		tvKgHUibqc1 = new StepOutParamDef
		{
			Key = "oldFullPath",
			Name = "旧路径",
			Description = "重命名时的原始路径",
			Type = VarType.Text,
			ValidForList = new string[1] { "wait" }
		};
		GDRgHiyifow = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool idWB7BQsJQ4PK5hEUDS0()
	{
		return Ow9cOjQsOW4pA9T4anRC == null;
	}
}
