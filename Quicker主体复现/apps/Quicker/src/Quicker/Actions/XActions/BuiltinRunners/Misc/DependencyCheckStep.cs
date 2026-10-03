using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using ICSharpCode.SharpZipLib.Zip;
using IgQBbvXMVdsN7GVNUxX;
using log4net;
using Quicker.Common.Vm;
using Quicker.Common.Vm.Depd;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Utilities;
using Quicker.View;
using Semver;
using vWqIxxMqTcYJW8kXilN;

namespace Quicker.Actions.XActions.BuiltinRunners.Misc;

public class DependencyCheckStep : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec QLaSh9Nknrc;

		public static Func<string, SemVersion> YKFShhe5Rea;

		private static _003C_003Ec LDdyZLW9hL3xwIk0hOQx;

		static _003C_003Ec()
		{
			QLaSh9Nknrc = new _003C_003Ec();
		}

		internal SemVersion ENmShZ33AXl(string x)
		{
			return SemVersion.Parse(Path.GetFileName(x), SemVersionStyles.Any);
		}

		internal static bool vN5YJ2W9HihENFDumKlj()
		{
			return LDdyZLW9hL3xwIk0hOQx == null;
		}

		internal static void U2HA0cWLVccPwy0ZgQoq()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass47_0
	{
		public ActionStep q8HShYnZEDy;

		public ActionExecuteContext JSqShIypVnr;

		public XAction ubbShW778Li;

		public DependencyCheckStep TPjShkNAV3i;

		internal static _003C_003Ec__DisplayClass47_0 u29N5XWLQSq1LRsLsv3J;

		internal (bool isSuccess, string message, ActionStopFlag failReason) YeaShe2Pa3f()
		{
			_003C_003Ec__DisplayClass47_1 _003C_003Ec__DisplayClass47_ = new _003C_003Ec__DisplayClass47_1
			{
				MGESh1gHND6 = XActionHelper.GetTextParamValue(x7ageF7QKEU, q8HShYnZEDy, JSqShIypVnr).Trim()
			};
			if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass47_.MGESh1gHND6))
			{
				return (isSuccess: false, message: "未指定包名", failReason: ActionStopFlag.OperationFailed);
			}
			string textParamValue = XActionHelper.GetTextParamValue(rsIgeU3OAB2, q8HShYnZEDy, JSqShIypVnr);
			XActionHelper.GetTextParamValue(l0ugelQ4dlE, q8HShYnZEDy, JSqShIypVnr);
			(bool, string) tuple = gj2geBL7mcc(_003C_003Ec__DisplayClass47_.MGESh1gHND6, textParamValue);
			if (tuple.Item1)
			{
				XActionHelper.OutputResult(NMFgef8f8hF, q8HShYnZEDy, JSqShIypVnr, tuple.Item2, ubbShW778Li);
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
			_003C_003Ec__DisplayClass47_.mWyShHNCuXL = null;
			AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass47_.aYgShGqV57s);
			try
			{
				string result = TPjShkNAV3i.vy0geryFLoJ(_003C_003Ec__DisplayClass47_.MGESh1gHND6, textParamValue);
				XActionHelper.OutputResult(NMFgef8f8hF, q8HShYnZEDy, JSqShIypVnr, result, ubbShW778Li);
			}
			finally
			{
				if (_003C_003Ec__DisplayClass47_.mWyShHNCuXL != null)
				{
					AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass47_.XOjShsBBIwH);
				}
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool xDJe2lWLF7ywEvasu0D3()
		{
			return u29N5XWLQSq1LRsLsv3J == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass47_1
	{
		public Window mWyShHNCuXL;

		public string MGESh1gHND6;

		private static _003C_003Ec__DisplayClass47_1 CaFmgXWLWOTUJRPlZYYS;

		internal void aYgShGqV57s()
		{
			mWyShHNCuXL = new WaitWindow
			{
				InfoText = "正在下载和安装依赖包（" + MGESh1gHND6 + "），请稍等。"
			};
			mWyShHNCuXL.Show();
		}

		internal void XOjShsBBIwH()
		{
			try
			{
				if (mWyShHNCuXL.IsVisible)
				{
					mWyShHNCuXL?.Close();
					mWyShHNCuXL = null;
				}
			}
			catch (Exception ex)
			{
				GjCgeQe3ldX.Warn("关闭等待窗口出错。" + ex.Message, ex);
			}
		}

		internal static bool AZQ7nHWLy2joS4clMeop()
		{
			return CaFmgXWLWOTUJRPlZYYS == null;
		}
	}

	private static readonly ILog GjCgeQe3ldX;

	[CompilerGenerated]
	private readonly string BEsgejtnDLZ = "sys:dependencycheck";

	[CompilerGenerated]
	private readonly string p6ugencYndh = "检查和下载依赖";

	[CompilerGenerated]
	private readonly IEnumerable<string> RLTge4DRdOg = new string[0];

	[CompilerGenerated]
	private readonly string L3mge5AKnKA = "Steps/common_step.png";

	[CompilerGenerated]
	private readonly StepRunnerCategory iMGgeDAd1OQ = StepRunnerCategory.Flow;

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> kscgedHWT3a;

	[CompilerGenerated]
	private readonly string pPMgeoBnKhO = "检查和下载依赖的外部文件包。";

	[CompilerGenerated]
	private readonly StepType yJLgeT9eRZx;

	[CompilerGenerated]
	private readonly string bcNgeMt9dfq = "https://getquicker.net/KC/Help/Doc/dependencycheck";

	[CompilerGenerated]
	private readonly bool UWdgeA6Yyyl;

	[CompilerGenerated]
	private readonly bool PvIgeOGlhKN;

	private static readonly StepInParamDef x7ageF7QKEU;

	private static readonly StepInParamDef rsIgeU3OAB2;

	private static readonly StepInParamDef l0ugelQ4dlE;

	private static readonly StepInParamDef pQigeicpLd1;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> Q6Cge3bYZi0 = new List<StepInParamDef> { x7ageF7QKEU, rsIgeU3OAB2, pQigeicpLd1 };

	private static readonly StepOutParamDef NMFgef8f8hF;

	private static readonly StepOutParamDef h0LgezPPTRF;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> ebYgYwsm8rP = new List<StepOutParamDef> { h0LgezPPTRF, NMFgef8f8hF };

	private static DependencyCheckStep i9QIfeQT2BN0pIT1bvgF;

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return BEsgejtnDLZ;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return p6ugencYndh;
		}
	}

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return RLTge4DRdOg;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return L3mge5AKnKA;
		}
	}

	public StepRunnerCategory Category
	{
		[CompilerGenerated]
		get
		{
			return iMGgeDAd1OQ;
		}
	}

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return kscgedHWT3a;
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return pPMgeoBnKhO;
		}
	}

	public StepType StepType
	{
		[CompilerGenerated]
		get
		{
			return yJLgeT9eRZx;
		}
	}

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return bcNgeMt9dfq;
		}
	}

	public bool IsRisky
	{
		[CompilerGenerated]
		get
		{
			return UWdgeA6Yyyl;
		}
	}

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return PvIgeOGlhKN;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return Q6Cge3bYZi0;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return ebYgYwsm8rP;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass47_0 _003C_003Ec__DisplayClass47_ = new _003C_003Ec__DisplayClass47_0();
		_003C_003Ec__DisplayClass47_.q8HShYnZEDy = step;
		_003C_003Ec__DisplayClass47_.JSqShIypVnr = context;
		_003C_003Ec__DisplayClass47_.ubbShW778Li = action;
		_003C_003Ec__DisplayClass47_.TPjShkNAV3i = this;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass47_.JSqShIypVnr, _003C_003Ec__DisplayClass47_.q8HShYnZEDy, _003C_003Ec__DisplayClass47_.ubbShW778Li, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass47_.YeaShe2Pa3f, (Action)null, (Action)null, pQigeicpLd1, h0LgezPPTRF);
	}

	private string vy0geryFLoJ(string string_5, string string_6)
	{
		ApiResult<PackageInfoDto> result = aFIptTXYsUoTUF4v33R.OFstbsbGTsP(string_5, string_6).GetAwaiter().GetResult();
		if (!result.IsSuccess)
		{
			throw new InvalidDataException("获取包信息失败：" + result.Message);
		}
		PackageInfoDto data = result.Data;
		string text = E2w4SAMlovhlOvIpCdY.fKBLD6NAWdP(data.DownloadLinks.First(), 20.0, true, null, null, "quicker_package_" + string_5 + "_" + data.Version + ".zip");
		if (!string.IsNullOrEmpty(text))
		{
			if (data.FileSize > 0)
			{
				FileInfo fileInfo = new FileInfo(text);
				if (fileInfo.Length != data.FileSize)
				{
					File.Delete(text);
					throw new InvalidDataException($"下载的文件大小({fileInfo.Length})和原始大小({data.FileSize})不一致。已删除下载的文件。");
				}
			}
			string text2 = Path.Combine(gLGgepMlL2L(), string_5, data.Version);
			new FastZip().ExtractZip(text, text2, string.Empty);
			try
			{
				File.Delete(text);
			}
			catch (Exception ex)
			{
				GjCgeQe3ldX.Warn("删除下载的依赖包文件出错：" + ex.Message);
			}
			if (!string.IsNullOrEmpty(data.InstallCommand))
			{
				string text3 = data.InstallCommand.Replace("@package", text2);
				int num = 1;
				if (!d6DDOPQTAqngVSChkITQ())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				case 1:
					break;
				default:
					goto IL_01d5;
				}
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				processStartInfo.FileName = "cmd.exe";
				processStartInfo.Arguments = "/c " + text3;
				processStartInfo.UseShellExecute = true;
				if (data.RunAsAdmin)
				{
					processStartInfo.Verb = "runas";
				}
				Process.Start(processStartInfo);
			}
			return text2;
		}
		goto IL_01d5;
		IL_01d5:
		throw new InvalidDataException("下载文件失败。");
	}

	private static string gLGgepMlL2L()
	{
		return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Quicker", "_packages");
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(x7ageF7QKEU, step) + "  " + XActionHelper.GetParamDisplayString(rsIgeU3OAB2, step);
	}

	private static (bool isExists, string path) gj2geBL7mcc(string string_5, string string_6)
	{
		string path = Path.Combine(gLGgepMlL2L(), string_5);
		if (!Directory.Exists(path))
		{
			return (isExists: false, path: "");
		}
		IOrderedEnumerable<string> orderedEnumerable = Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly).OrderByDescending(_003C_003Ec.YKFShhe5Rea ?? (_003C_003Ec.YKFShhe5Rea = _003C_003Ec.QLaSh9Nknrc.ENmShZ33AXl));
		if (orderedEnumerable != null && orderedEnumerable.Any())
		{
			string text = orderedEnumerable.First();
			if (string.IsNullOrEmpty(string_6))
			{
				return (isExists: true, path: text);
			}
			SemVersion semVersion = SemVersion.Parse(Path.GetFileName(text), SemVersionStyles.Any);
			SemVersion other = SemVersion.Parse(string_6, SemVersionStyles.Any);
			if (semVersion.CompareSortOrderTo(other) >= 0)
			{
				return (isExists: true, path: text);
			}
			return (isExists: false, path: "");
		}
		return (isExists: false, path: "");
	}

	static DependencyCheckStep()
	{
		GjCgeQe3ldX = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		x7ageF7QKEU = new StepInParamDef
		{
			Key = "packageName",
			Name = "依赖包名",
			Description = "已经在官网上发布的依赖包的名称",
			DefaultValue = "",
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		rsIgeU3OAB2 = new StepInParamDef
		{
			Key = "packageVersion",
			Name = "依赖包版本",
			Description = "留空：表示任意版本即可；或写具体版本，表示最低版本。格式为1.2.3",
			DefaultValue = "",
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		l0ugelQ4dlE = new StepInParamDef
		{
			Key = "existenceRule",
			Name = "存在性验证",
			Description = "如果符合规则，表示依赖已存在，不需要再下载安装。留空表示验证目录。",
			DefaultValue = "",
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		pQigeicpLd1 = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		NMFgef8f8hF = new StepOutParamDef
		{
			Key = "packagePath",
			Name = "依赖包路径",
			Description = "解压缩后的依赖包路径",
			Type = VarType.Text
		};
		h0LgezPPTRF = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
	}

	internal static bool d6DDOPQTAqngVSChkITQ()
	{
		return i9QIfeQT2BN0pIT1bvgF == null;
	}
}
