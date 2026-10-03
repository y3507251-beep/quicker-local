using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using FontAwesome5;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Modules.Searching.Builtin;
using Quicker.Public.Actions;

namespace Quicker.Domain.Actions.X.BuiltinRunners.File;

public class EverythingSearchStep : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec foPScEYsrDq;

		public static Func<EverythingFileInfo, string> OjOScyKEXB5;

		internal static _003C_003Ec Jkkl3bWrXvSRMNXb2Uww;

		static _003C_003Ec()
		{
			foPScEYsrDq = new _003C_003Ec();
		}

		internal string D9JScPXdeUT(EverythingFileInfo x)
		{
			return x.FilePath;
		}

		internal static bool c1a4l1Wr2ytOUU7O7rlr()
		{
			return Jkkl3bWrXvSRMNXb2Uww == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass47_0
	{
		public ActionStep plwScaCTMkf;

		public ActionExecuteContext qBVSc7IdPKH;

		public XAction Uw3ScR7xlmG;

		private static _003C_003Ec__DisplayClass47_0 BdOwEbWrnPqyFUgm4sCe;

		internal (bool isSuccess, string message, ActionStopFlag failReason) nOLSc8O4Sil()
		{
			string text = XActionHelper.GetTextParamValue(wwAgR7dvnA7, plwScaCTMkf, qBVSc7IdPKH);
			string textParamValue = XActionHelper.GetTextParamValue(m4WgRRWsNPN, plwScaCTMkf, qBVSc7IdPKH);
			string textParamValue2 = XActionHelper.GetTextParamValue(UulgRq6FqZo, plwScaCTMkf, qBVSc7IdPKH);
			bool booleanParamValue = XActionHelper.GetBooleanParamValue(Rc9gRVc7FgT, plwScaCTMkf, qBVSc7IdPKH);
			bool booleanParamValue2 = XActionHelper.GetBooleanParamValue(x2AgR9W2cJe, plwScaCTMkf, qBVSc7IdPKH);
			bool booleanParamValue3 = XActionHelper.GetBooleanParamValue(Jp0gRh1xukq, plwScaCTMkf, qBVSc7IdPKH);
			long integerParamValue = XActionHelper.GetIntegerParamValue(ToVgReHQ7D3, plwScaCTMkf, qBVSc7IdPKH);
			long integerParamValue2 = XActionHelper.GetIntegerParamValue(asYgRYOkY9m, plwScaCTMkf, qBVSc7IdPKH);
			bool booleanParamValue4 = XActionHelper.GetBooleanParamValue(uNKgRZhNPbZ, plwScaCTMkf, qBVSc7IdPKH);
			EverythingAPI everythingAPI = new EverythingAPI();
			if (booleanParamValue3)
			{
				everythingAPI.EnableRegex = booleanParamValue3;
			}
			if (booleanParamValue2)
			{
				everythingAPI.MatchCase = booleanParamValue2;
			}
			if (booleanParamValue)
			{
				everythingAPI.MatchWholeWord = booleanParamValue;
			}
			if (booleanParamValue4)
			{
				everythingAPI.MatchPath = booleanParamValue4;
			}
			if (integerParamValue2 != 1L)
			{
				everythingAPI.Sort = (uint)integerParamValue2;
			}
			if (string.IsNullOrWhiteSpace(text))
			{
				return (isSuccess: false, message: "要搜索的内容为空", failReason: ActionStopFlag.OperationFailed);
			}
			if (XActionHelper.GetBooleanParamValue(GW9gRcW90xJ, plwScaCTMkf, qBVSc7IdPKH))
			{
				text = "wfn:" + text;
			}
			if (!string.IsNullOrWhiteSpace(textParamValue))
			{
				text = ((!textParamValue.StartsWith("\"")) ? ("\"" + textParamValue.Trim() + "\" " + text) : (textParamValue.Trim() + " " + text));
			}
			if (!string.IsNullOrWhiteSpace(textParamValue2))
			{
				text = "ext:" + textParamValue2.Trim() + " " + text;
			}
			try
			{
				_003C_003Ec__DisplayClass47_1 _003C_003Ec__DisplayClass47_ = new _003C_003Ec__DisplayClass47_1
				{
					xoWScZNInBc = everythingAPI.Search(text, 0u, (uint)((integerParamValue < 0L) ? uint.MaxValue : integerParamValue)).ToList()
				};
				XActionHelper.OutputResultIfNeeded(xhBgRsumFiP, _003C_003Ec__DisplayClass47_.r73ScqHi6yW, plwScaCTMkf, qBVSc7IdPKH, Uw3ScR7xlmG);
				XActionHelper.OutputResultIfNeeded(VINgRGq3iG1, _003C_003Ec__DisplayClass47_.jTnSccYgshl, plwScaCTMkf, qBVSc7IdPKH, Uw3ScR7xlmG);
				XActionHelper.OutputResultIfNeeded(EpTgRHjcjjI, _003C_003Ec__DisplayClass47_.mu7ScV69VbK, plwScaCTMkf, qBVSc7IdPKH, Uw3ScR7xlmG);
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
			catch (Exception innerException)
			{
				if (Process.GetProcessesByName("everything").Length != 0 || Process.GetProcessesByName("everything64").Length != 0)
				{
					throw new Exception("Everything搜索失败，可能它尚未启动。", innerException);
				}
				return (isSuccess: false, message: "Everything未启动，请先启动Everything软件后再使用本动作。", failReason: ActionStopFlag.OperationFailed);
			}
			finally
			{
				everythingAPI.Reset();
			}
		}

		static _003C_003Ec__DisplayClass47_0()
		{
		}

		internal static void oAUVqaWrDDOFTxlQpffO()
		{
		}

		internal static bool BVI67yWrewMqHFZaZXtr()
		{
			return BdOwEbWrnPqyFUgm4sCe == null;
		}

		internal static void pGbcMOWr3pJ1neoFdtv8()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass47_1
	{
		public List<EverythingFileInfo> xoWScZNInBc;

		internal static _003C_003Ec__DisplayClass47_1 R0DFQoWrEoUDEevLLdes;

		internal object r73ScqHi6yW()
		{
			return xoWScZNInBc.Count();
		}

		internal object jTnSccYgshl()
		{
			return xoWScZNInBc.Select(_003C_003Ec.OjOScyKEXB5 ?? (_003C_003Ec.OjOScyKEXB5 = _003C_003Ec.foPScEYsrDq.D9JScPXdeUT)).ToList();
		}

		internal object mu7ScV69VbK()
		{
			return xoWScZNInBc;
		}

		internal static bool uZUYD3WrGFd3fGVBj1Vw()
		{
			return R0DFQoWrEoUDEevLLdes == null;
		}
	}

	[CompilerGenerated]
	private readonly string xgugRywBAmH = $"fa:{EFontAwesomeIcon.Light_Search}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> Ag5gR8piTB6;

	[CompilerGenerated]
	private readonly string eyXgRaR38Z3 = "https://getquicker.net/KC/Help/Doc/everythingsearch";

	private static readonly StepInParamDef wwAgR7dvnA7;

	private static readonly StepInParamDef m4WgRRWsNPN;

	private static readonly StepInParamDef UulgRq6FqZo;

	private static readonly StepInParamDef GW9gRcW90xJ;

	private static readonly StepInParamDef Rc9gRVc7FgT;

	private static readonly StepInParamDef uNKgRZhNPbZ;

	private static readonly StepInParamDef x2AgR9W2cJe;

	private static readonly StepInParamDef Jp0gRh1xukq;

	private static readonly StepInParamDef ToVgReHQ7D3;

	private static readonly StepInParamDef asYgRYOkY9m;

	private static readonly StepInParamDef nkVgRITX9ZR;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> HnXgRWZsFHW = new List<StepInParamDef>
	{
		wwAgR7dvnA7, m4WgRRWsNPN, UulgRq6FqZo, GW9gRcW90xJ, Rc9gRVc7FgT, uNKgRZhNPbZ, x2AgR9W2cJe, Jp0gRh1xukq, ToVgReHQ7D3, asYgRYOkY9m,
		nkVgRITX9ZR
	};

	private static readonly StepOutParamDef VJBgRkl9lZT;

	private static readonly StepOutParamDef VINgRGq3iG1;

	private static readonly StepOutParamDef xhBgRsumFiP;

	private static readonly StepOutParamDef EpTgRHjcjjI;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> UalgR1OlRIe = new List<StepOutParamDef> { VJBgRkl9lZT, VINgRGq3iG1, xhBgRsumFiP, EpTgRHjcjjI };

	internal static EverythingSearchStep SCrp8YQ6lVmJpGfQMkMA;

	public string Key => "sys:everythingsearch";

	public string Name => "使用Everything搜索文件";

	public IEnumerable<string> KeyWords => new List<string> { "file" };

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return xgugRywBAmH;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Files;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return Ag5gR8piTB6;
		}
	}

	public string Description => "调用Everything提供的接口搜索文件";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return eyXgRaR38Z3;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly => false;

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return HnXgRWZsFHW;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return UalgR1OlRIe;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass47_0 _003C_003Ec__DisplayClass47_ = new _003C_003Ec__DisplayClass47_0();
		_003C_003Ec__DisplayClass47_.plwScaCTMkf = step;
		_003C_003Ec__DisplayClass47_.qBVSc7IdPKH = context;
		_003C_003Ec__DisplayClass47_.Uw3ScR7xlmG = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass47_.qBVSc7IdPKH, _003C_003Ec__DisplayClass47_.plwScaCTMkf, _003C_003Ec__DisplayClass47_.Uw3ScR7xlmG, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass47_.nOLSc8O4Sil, (Action)null, (Action)null, nkVgRITX9ZR, VJBgRkl9lZT);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDirectValue(wwAgR7dvnA7, step);
	}

	static EverythingSearchStep()
	{
		wwAgR7dvnA7 = new StepInParamDef
		{
			Key = "search",
			Name = "搜索内容",
			Description = "要搜索的内容，格式与直接在everything软件中搜索时相同。",
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text
		};
		m4WgRRWsNPN = new StepInParamDef
		{
			Key = "folder",
			Name = "限定目录",
			Description = "可选。在指定目录下搜索（包含子目录）。",
			IsRequired = false,
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text
		};
		UulgRq6FqZo = new StepInParamDef
		{
			Key = "ext",
			Name = "扩展名",
			Description = "可选。半角分号分隔的扩展名列表。如“txt;docx;xslx;”",
			IsRequired = false,
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("bat;cmd;exe;msi;msp;scr;cpl", "可执行文件"),
				new SelectionItem("c;chm;cpp;csv;cxx;doc;docm;docx;dot;dotm;dotx;h;hpp;htm;html;hxx;ini;java;lua;mht;mhtml;odt;pdf;potx;potm;ppam;ppsm;ppsx;pps;ppt;pptm;pptx;rtf;sldm;sldx;thmx;txt;vsd;wpd;wps;wri;xlam;xls;xlsb;xlsm;xlsx;xltm;xltx;xml", "文档"),
				new SelectionItem("ani;bmp;gif;ico;jpe;jpeg;jpg;pcx;png;psd;tga;tif;tiff;webp;wmf", "图片"),
				new SelectionItem("3g2;3gp;3gp2;3gpp;amr;amv;asf;avi;bdmv;bik;d2v;divx;drc;dsa;dsm;dss;dsv;evo;f4v;flc;fli;flic;flv;hdmov;ifo;ivf;m1v;m2p;m2t;m2ts;m2v;m4b;m4p;m4v;mkv;mp2v;mp4;mp4v;mpe;mpeg;mpg;mpls;mpv2;mpv4;mov;mts;ogm;ogv;pss;pva;qt;ram;ratdvd;rm;rmm;rmvb;roq;rpm;smil;smk;swf;tp;tpr;ts;vob;vp6;webm;wm;wmp;wmv", "视频文件"),
				new SelectionItem("aac;ac3;aif;aifc;aiff;au;cda;dts;fla;flac;it;m1a;m2a;m3u;m4a;mid;midi;mka;mod;mp2;mp3;mpa;ogg;ra;rmi;spc;rmi;snd;umx;voc;wav;wma;xm", "音频文件")
			}
		};
		GW9gRcW90xJ = new StepInParamDef
		{
			Key = "matchWholeFilename",
			Name = "匹配完整文件名",
			Description = "匹配整个文件名。0表示否，1表示是。",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput,
			DefaultValue = 0
		};
		Rc9gRVc7FgT = new StepInParamDef
		{
			Key = "matchWholeWord",
			Name = "匹配整个单词",
			Description = "匹配整个单词。如 quicker.exe 将会匹配：quicker.exe, quicker.exe.config等。0表示否，1表示是。",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput,
			DefaultValue = 1
		};
		uNKgRZhNPbZ = new StepInParamDef
		{
			Key = "matchPath",
			Name = "匹配路径",
			Description = "匹配路径的不同部分，而不仅是文件名。",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput,
			DefaultValue = 0
		};
		x2AgR9W2cJe = new StepInParamDef
		{
			Key = "matchCase",
			Name = "匹配大小写",
			Description = "是否大小写敏感。0表示否，1表示是。",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput,
			DefaultValue = 0
		};
		Jp0gRh1xukq = new StepInParamDef
		{
			Key = "useRegex",
			Name = "使用正则匹配",
			Description = "是否使用正则匹配。0表示否，1表示是。",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput,
			DefaultValue = 0
		};
		ToVgReHQ7D3 = new StepInParamDef
		{
			Key = "maxCount",
			Name = "最大结果数量",
			Description = "-1表示不限制",
			IsRequired = true,
			DefaultValue = 100,
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Integer
		};
		asYgRYOkY9m = new StepInParamDef
		{
			Key = "sort",
			Name = "排序方式",
			Description = "",
			IsRequired = true,
			DefaultValue = 1,
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Enum,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("1", "名称顺序 NAME_ASCENDING"),
				new SelectionItem("2", "名称倒序 NAME_DESCENDING"),
				new SelectionItem("3", "路径顺序 PATH_ASCENDING"),
				new SelectionItem("4", "路径倒序 PATH_DESCENDING"),
				new SelectionItem("5", "大小顺序 SIZE_ASCENDING"),
				new SelectionItem("6", "大小倒序 SIZE_DESCENDING"),
				new SelectionItem("7", "扩展名顺序 EXTENSION_ASCENDING"),
				new SelectionItem("8", "扩展名倒序 EXTENSION_DESCENDING"),
				new SelectionItem("9", "类型名顺序 TYPE_NAME_ASCENDING"),
				new SelectionItem("10", "类型名倒序 TYPE_NAME_DESCENDING"),
				new SelectionItem("11", "创建时间顺序 DATE_CREATED_ASCENDING"),
				new SelectionItem("12", "创建时间倒序 DATE_CREATED_DESCENDING"),
				new SelectionItem("13", "修改时间顺序 DATE_MODIFIED_ASCENDING"),
				new SelectionItem("14", "修改时间倒序 DATE_MODIFIED_DESCENDING"),
				new SelectionItem("15", "属性顺序 ATTRIBUTES_ASCENDING"),
				new SelectionItem("16", "属性倒序 ATTRIBUTES_DESCENDING"),
				new SelectionItem("17", "文件列表文件名顺序 FILE_LIST_FILENAME_ASCENDING"),
				new SelectionItem("18", "文件列表文件名倒序 FILE_LIST_FILENAME_DESCENDING"),
				new SelectionItem("19", "运行次数顺序 RUN_COUNT_ASCENDING"),
				new SelectionItem("20", "运行次数倒序 RUN_COUNT_DESCENDING"),
				new SelectionItem("21", "最后变更时间顺序 DATE_RECENTLY_CHANGED_ASCENDING"),
				new SelectionItem("22", "最后变更时间倒序 DATE_RECENTLY_CHANGED_DESCENDING"),
				new SelectionItem("23", "最后访问时间顺序 DATE_ACCESSED_ASCENDING"),
				new SelectionItem("24", "最后访问时间倒序 DATE_ACCESSED_DESCENDING"),
				new SelectionItem("25", "最后运行时间顺序 DATE_RUN_ASCENDING"),
				new SelectionItem("26", "最后运行时间倒序 DATE_RUN_DESCENDING")
			}
		};
		nkVgRITX9ZR = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		VJBgRkl9lZT = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		VINgRGq3iG1 = new StepOutParamDef
		{
			Key = "pathList",
			Name = "路径列表",
			Type = VarType.List
		};
		xhBgRsumFiP = new StepOutParamDef
		{
			Key = "resultCount",
			Name = "结果个数",
			Type = VarType.Integer
		};
		EpTgRHjcjjI = new StepOutParamDef
		{
			Key = "rawResult",
			Name = "原始结果",
			Type = VarType.Object
		};
	}

	internal static bool nWsYUdQ6ZhBJUPlcPkrI()
	{
		return SCrp8YQ6lVmJpGfQMkMA == null;
	}
}
