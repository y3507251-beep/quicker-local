using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using FontAwesome5;
using l9W6KWifMfNKrInJR4l;
using lGFWOcimK6GZKnFIeLT;
using log4net;
using nSudn7i77a3JpXIFA0G;
using PptRB0i5EX0bZPrKAwn;
using Quicker.Common;
using Quicker.Common.Entities;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Public.Entities;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Win32;

namespace Quicker.Domain.Actions.X.BuiltinRunners.File;

public class GetSelectedFilesStep : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec iieSV1DXF5c;

		public static Func<string, bool> VxISVbVx67I;

		public static Func<string, string> sraSV6IlDbX;

		public static Func<string, string> XKrSVXxuTLs;

		internal static _003C_003Ec vgy4pUWrz11DqDuMbV7W;

		static _003C_003Ec()
		{
			iieSV1DXF5c = new _003C_003Ec();
		}

		internal bool LFESVGlJ9HZ(string x)
		{
			return x.Contains("/");
		}

		internal string zk5SVs9rJWG(string x)
		{
			return x.Replace("/", "\\");
		}

		internal string vu0SVH9irmO(string x)
		{
			return Path.GetFileName(x);
		}

		internal static bool ODGOfdWNVTDCqFb4mIY0()
		{
			return vgy4pUWrz11DqDuMbV7W == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass50_0
	{
		public ActionStep EbkSVK3qr0S;

		public ActionExecuteContext I7MSVxsTGfq;

		public XAction EvxSVrFl3NQ;

		public GetSelectedFilesStep klWSVpXi9Kg;

		internal static _003C_003Ec__DisplayClass50_0 JlG1PuWNFvdGogCbVcg5;

		internal (bool isSuccess, string message, ActionStopFlag failReason) AAGSVmHVhOB()
		{
			string textParamValue = XActionHelper.GetTextParamValue(sFQgc0pj6S1, EbkSVK3qr0S, I7MSVxsTGfq);
			if (!(textParamValue == "getSelection"))
			{
				if (textParamValue == "setSelection")
				{
					klWSVpXi9Kg.XvYgctPTTo1(EbkSVK3qr0S, I7MSVxsTGfq, EvxSVrFl3NQ);
				}
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
			return Hnagcgk5Ukh(EbkSVK3qr0S, I7MSVxsTGfq, EvxSVrFl3NQ);
		}

		internal static bool LYQry2WNc7plx41Ner4y()
		{
			return JlG1PuWNFvdGogCbVcg5 == null;
		}
	}

	private static readonly ILog X26gcvpBtCT;

	[CompilerGenerated]
	private readonly IEnumerable<string> FnMgcSsvug9 = new string[6] { "selected", "files", "资源管理器", "获取选中的文件(夹)", "explorer", "hqxzwjlb" };

	[CompilerGenerated]
	private readonly string fHwgc2bRykN = $"fa:{EFontAwesomeIcon.Light_FolderTree}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> u0EgcuMraYd;

	[CompilerGenerated]
	private readonly string FjXgcNSD09j = "https://getquicker.net/KC/Help/Doc/getselectedfiles";

	[CompilerGenerated]
	private readonly bool PBEgcJc7yxC;

	private static readonly StepInParamDef sFQgc0pj6S1;

	public static readonly StepInParamDef _pathListParam;

	private static readonly StepInParamDef jWLgcChorPs;

	private static readonly StepInParamDef v0EgcPBObeG;

	private static readonly StepInParamDef yJ3gcEvsPaB;

	private static readonly StepInParamDef b4igcyVcskV;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> Vtsgc8FBVp9 = new StepInParamDef[6] { sFQgc0pj6S1, yJ3gcEvsPaB, v0EgcPBObeG, _pathListParam, b4igcyVcskV, jWLgcChorPs };

	private static readonly StepOutParamDef m61gcaeIWpg;

	private static readonly StepOutParamDef EHrgc72LGdj;

	private static readonly StepOutParamDef KMDgcRb49K5;

	private static readonly StepOutParamDef RcOgcqiAhB8;

	private static readonly StepOutParamDef oQAgccU3TVV;

	private static readonly StepOutParamDef WL4gcVght1W;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> jsKgcZnhCEj = new StepOutParamDef[6] { WL4gcVght1W, m61gcaeIWpg, EHrgc72LGdj, KMDgcRb49K5, RcOgcqiAhB8, oQAgccU3TVV };

	private static GetSelectedFilesStep hClwdmQtvKbOPig92NU8;

	public string Key => "sys:getSelectedFiles";

	public string Name => "获取选择的文件(夹)/选择特定文件";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return FnMgcSsvug9;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return fHwgc2bRykN;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.System;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return u0EgcuMraYd;
		}
	}

	public string Description => "获取资源管理器、桌面等位置选择的文件或文件夹的路径";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return FjXgcNSD09j;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return PBEgcJc7yxC;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return Vtsgc8FBVp9;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return jsKgcZnhCEj;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public static IList<string> FixPathChar(IList<string> pathList)
	{
		if (pathList.Any(_003C_003Ec.VxISVbVx67I ?? (_003C_003Ec.VxISVbVx67I = _003C_003Ec.iieSV1DXF5c.LFESVGlJ9HZ)))
		{
			return pathList.Select(_003C_003Ec.sraSV6IlDbX ?? (_003C_003Ec.sraSV6IlDbX = _003C_003Ec.iieSV1DXF5c.zk5SVs9rJWG)).ToList();
		}
		return pathList;
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass50_0 _003C_003Ec__DisplayClass50_ = new _003C_003Ec__DisplayClass50_0();
		_003C_003Ec__DisplayClass50_.EbkSVK3qr0S = step;
		_003C_003Ec__DisplayClass50_.I7MSVxsTGfq = context;
		_003C_003Ec__DisplayClass50_.EvxSVrFl3NQ = action;
		_003C_003Ec__DisplayClass50_.klWSVpXi9Kg = this;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass50_.I7MSVxsTGfq, _003C_003Ec__DisplayClass50_.EbkSVK3qr0S, _003C_003Ec__DisplayClass50_.EvxSVrFl3NQ, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass50_.AAGSVmHVhOB, (Action)null, (Action)null, b4igcyVcskV, WL4gcVght1W);
	}

	private void XvYgctPTTo1(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0)
	{
		IList<string> listParamValue = XActionHelper.GetListParamValue(_pathListParam, actionStep_0, actionExecuteContext_0);
		long integerParamValue = XActionHelper.GetIntegerParamValue(jWLgcChorPs, actionStep_0, actionExecuteContext_0);
		int num = NativeMethods.SetCurrentExplorerWindowSelectedFiles(listParamValue, (IntPtr)integerParamValue);
		XActionHelper.OutputResult(oQAgccU3TVV, actionStep_0, actionExecuteContext_0, num, xaction_0);
	}

	private static (bool isSuccess, string message, ActionStopFlag failReason) Hnagcgk5Ukh(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0)
	{
		int num = (int)XActionHelper.GetIntegerParamValue(yJ3gcEvsPaB, actionStep_0, actionExecuteContext_0);
		string textParamValue = XActionHelper.GetTextParamValue(v0EgcPBObeG, actionStep_0, actionExecuteContext_0);
		IList<string> list = new List<string>();
		ActionAssociation association = actionExecuteContext_0.Action.Association;
		if (association != null && association.IsFileProcessor)
		{
			ActionExtraContextData extraData = actionExecuteContext_0.ExtraData;
			if (extraData != null && extraData.Files.HasData())
			{
				actionExecuteContext_0.ActionLogger.LogInfo("从动作参数中获得了文件列表");
				list = actionExecuteContext_0.ExtraData.Files;
				list = FixPathChar(list);
				list = xjkIv1iq3Kqe7V2pm2d.t80vwkbu1qR(list, textParamValue);
				actionExecuteContext_0.ExtraData.Files = null;
				HWEgcLBjnUm(list, actionStep_0, actionExecuteContext_0, xaction_0);
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
		}
		(ExplorerSoftware, IntPtr, string, bool) tuple = ytnqhyiMNhGmytDmEj7.zwDvtNYUZmk(null);
		if (!AppState.HHxtaMaoqJr().AlwaysUseClipboardToGetSelectedFiles)
		{
			if (tuple.Item4 && tuple.Item1 == ExplorerSoftware.TotalCommander)
			{
				actionExecuteContext_0.ActionLogger?.LogInfo($"通过TC复制命令获得了{list.Count}个文件");
				list = d23lbji6LH2xdpIE1Qu.Ii0vtCTbFZR(tuple.Item2);
			}
			else if (tuple.Item4 && tuple.Item1 == ExplorerSoftware.XYplorer)
			{
				list = moAa3ciiBWM25Wu8vZH.GPjvtZ95Zgk(tuple.Item2);
			}
			else if (tuple.Item1 != ExplorerSoftware.DirectoryOpus && tuple.Item1 != ExplorerSoftware.OneCommander)
			{
				try
				{
					list = NativeMethods.GetSelectedFiles();
				}
				catch (Exception ex)
				{
					actionExecuteContext_0.ActionLogger?.LogWarning("通过Win32接口获取选中的文件失败：" + ex.Message);
					actionExecuteContext_0.ActionLogger?.LogInfo(ex.StackTrace);
				}
			}
			else
			{
				X26gcvpBtCT.Info("DO 和 OneCommander 不支持获取选中的文件接口。");
			}
		}
		if (list.HasData())
		{
			actionExecuteContext_0.ActionLogger?.LogInfo($"通过Win32接口获得了{list.Count}个文件");
		}
		else
		{
			int clipboardSequenceNumber = AppState.ClipboardSequenceNumber;
			AppHelper.SendCopyKeys();
			long num2 = AppHelper.fLiLTj0x4QY();
			while (AppHelper.fLiLTj0x4QY() < num2 + num)
			{
				if (AppState.ClipboardSequenceNumber == clipboardSequenceNumber)
				{
					Thread.Sleep(10);
					continue;
				}
				Thread.Sleep(10);
				break;
			}
			if (AppState.ClipboardSequenceNumber != clipboardSequenceNumber && ClipboardHelper.ContainsFileDropList())
			{
				list = new List<string>();
				StringEnumerator enumerator = ClipboardHelper.GetFileDropList().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						string current = enumerator.Current;
						list.Add(current);
					}
				}
				finally
				{
					if (enumerator is IDisposable disposable)
					{
						disposable.Dispose();
					}
				}
			}
			actionExecuteContext_0.ActionLogger?.LogInfo($"通过Ctrl+c获得了{list?.Count ?? 0}个文件");
		}
		if (list.HasData())
		{
			list = FixPathChar(list);
			list = xjkIv1iq3Kqe7V2pm2d.t80vwkbu1qR(list, textParamValue);
			HWEgcLBjnUm(list, actionStep_0, actionExecuteContext_0, xaction_0);
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}
		return (isSuccess: false, message: "获得的文件数量为0。", failReason: ActionStopFlag.OperationFailed);
	}

	private static void HWEgcLBjnUm(IList<string> ilist_2, ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0)
	{
		XActionHelper.OutputResult(m61gcaeIWpg, actionStep_0, actionExecuteContext_0, ilist_2, xaction_0);
		XActionHelper.OutputResult(EHrgc72LGdj, actionStep_0, actionExecuteContext_0, ilist_2?[0], xaction_0);
		if (XActionHelper.IsOutputParamSetted(KMDgcRb49K5.Key, actionStep_0))
		{
			XActionHelper.OutputResult(KMDgcRb49K5, actionStep_0, actionExecuteContext_0, ilist_2?.Select(_003C_003Ec.XKrSVXxuTLs ?? (_003C_003Ec.XKrSVXxuTLs = _003C_003Ec.iieSV1DXF5c.vu0SVH9irmO)).ToList(), xaction_0);
		}
		StepOutParamDef rcOgcqiAhB;
		object obj;
		if (XActionHelper.IsOutputParamSetted(RcOgcqiAhB8.Key, actionStep_0))
		{
			rcOgcqiAhB = RcOgcqiAhB8;
			if (ilist_2 == null)
			{
				obj = null;
			}
			else
			{
				obj = ilist_2.FirstOrDefault();
				if (obj != null)
				{
					goto IL_00a8;
				}
			}
			obj = "";
			goto IL_00a8;
		}
		goto IL_00b4;
		IL_00b4:
		XActionHelper.OutputResult(oQAgccU3TVV, actionStep_0, actionExecuteContext_0, ilist_2?.Count ?? 0, xaction_0);
		return;
		IL_00a8:
		XActionHelper.OutputResult(rcOgcqiAhB, actionStep_0, actionExecuteContext_0, Path.GetFileName((string)obj), xaction_0);
		goto IL_00b4;
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(sFQgc0pj6S1, step) + " " + XActionHelper.GetOutputParamDisplayString(m61gcaeIWpg, step);
	}

	static GetSelectedFilesStep()
	{
		X26gcvpBtCT = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		sFQgc0pj6S1 = new StepInParamDef
		{
			Key = "operation",
			Name = "操作类型",
			DefaultValue = "getSelection",
			VariableMode = ParamVariableMode.Input,
			Type = VarType.Enum,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("getSelection", "获取选择的文件"),
				new SelectionItem("setSelection", "设置选择的文件")
			},
			IsControlField = true
		};
		_pathListParam = new StepInParamDef
		{
			Key = "pathList",
			Name = "路径或文件名",
			Description = "要选中的路径或文件名。支持使用 “regex:表达式” “pinyin:筛选” 选择匹配的文件。",
			VariableMode = ParamVariableMode.Input,
			Type = VarType.Text,
			ValidForList = new string[1] { "setSelection" },
			IsMultiLine = true
		};
		jWLgcChorPs = new StepInParamDef
		{
			Key = "winHandle",
			Name = "指定窗口句柄",
			Description = "指定要操作的资源管理器窗口，留空时表示前台窗口。（仅支持资源管理器）",
			IsAdvanced = true,
			Type = VarType.Integer,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[1] { "setSelection" }
		};
		v0EgcPBObeG = new StepInParamDef
		{
			Key = "sortType",
			Name = "排序文件列表",
			Description = "获取多个文件时，根据需要可以对文件列表进行排序。仅支持文件。",
			DefaultValue = "Default",
			Type = VarType.Enum,
			VariableMode = ParamVariableMode.UseVarOrInput,
			SelectionItems = new SelectionItem[12]
			{
				new SelectionItem("Default", "默认（文件名自然排序）"),
				new SelectionItem("Origin", "原始（系统返回顺序）"),
				new SelectionItem("FileName", "文件名（字母顺序）"),
				new SelectionItem("FileNameNature", "文件名（自然顺序）"),
				new SelectionItem("FileSizeAsc", "文件大小（从小到大）"),
				new SelectionItem("FileSizeDesc", "文件大小（从大到小）"),
				new SelectionItem("CreationTimeDesc", "创建时间（从新到旧）"),
				new SelectionItem("CreationTimeAsc", "创建时间（从旧到新）"),
				new SelectionItem("LastAccessTimeDesc", "最后访问时间（从晚到早）"),
				new SelectionItem("LastAccessTimeAsc", "最后访问时间（从早到晚）"),
				new SelectionItem("LastWriteTimeDesc", "最后写入时间（从晚到早）"),
				new SelectionItem("LastWriteTimeAsc", "最后写入时间（从早到晚）")
			},
			ValidForList = new List<string> { "getSelection" }
		};
		yJ3gcEvsPaB = new StepInParamDef
		{
			Key = "waitMs",
			Name = "等待剪贴板时间",
			DefaultValue = 200,
			Description = "通过复制方式获取选择文件时，等待剪贴板变化的最长时间毫秒数。",
			Type = VarType.Integer,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "getSelection" }
		};
		b4igcyVcskV = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后中止动作",
			DefaultValue = true,
			Description = "获取失败后，是否停止后续动作的执行。",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		m61gcaeIWpg = new StepOutParamDef
		{
			Key = "files",
			Name = "路径列表",
			Description = "所有选中的文件和文件夹的路径列表",
			Type = VarType.List,
			ValidForList = new List<string> { "getSelection" }
		};
		EHrgc72LGdj = new StepOutParamDef
		{
			Key = "firstFile",
			Name = "首个路径",
			Description = "选择1个文件(夹)时，返回其路径；选择多个时，返回第一个的路径。",
			Type = VarType.Text,
			ValidForList = new List<string> { "getSelection" }
		};
		KMDgcRb49K5 = new StepOutParamDef
		{
			Key = "fileNames",
			Name = "文件(夹)名列表",
			Description = "所有选中的文件和文件夹的名称的列表（不包含所在路径）",
			Type = VarType.List,
			ValidForList = new List<string> { "getSelection" }
		};
		RcOgcqiAhB8 = new StepOutParamDef
		{
			Key = "firstFileName",
			Name = "首个文件(夹)名",
			Description = "选择1个文件(夹)时，返回其名称；选择多个时，返回第一个的名称。",
			Type = VarType.Text,
			ValidForList = new List<string> { "getSelection" }
		};
		oQAgccU3TVV = new StepOutParamDef
		{
			Key = "fileCount",
			Name = "文件个数",
			Description = "选择的文件个数",
			Type = VarType.Integer,
			ValidForList = new List<string> { "getSelection", "setSelection" }
		};
		WL4gcVght1W = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "是否成功获得文件列表",
			Type = VarType.Boolean
		};
	}

	internal static bool zndkYiQtdcWQeHlas7ZZ()
	{
		return hClwdmQtvKbOPig92NU8 == null;
	}
}
