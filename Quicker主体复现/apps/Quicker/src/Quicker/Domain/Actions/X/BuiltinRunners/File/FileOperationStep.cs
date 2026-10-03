using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using CW.Win32.Shell;
using FontAwesome5;
using JwWHiN2bDQfq7cLF2NK;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Win32;

namespace Quicker.Domain.Actions.X.BuiltinRunners.File;

public class FileOperationStep : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec aR5ScfNuCY1;

		public static Func<FileSystemInfo, string> VhxSczwHcqD;

		public static Func<FileSystemInfo, string> uv0SVwptk5l;

		internal static _003C_003Ec tk36jCWriCBgiBIUL6NO;

		static _003C_003Ec()
		{
			aR5ScfNuCY1 = new _003C_003Ec();
		}

		internal string CALSciLsXhP(FileSystemInfo x)
		{
			return x.FullName;
		}

		internal string TlOSc3NGd31(FileSystemInfo x)
		{
			return x.FullName;
		}

		internal static bool hkgGYWWrlrGkUClTOUdJ()
		{
			return tk36jCWriCBgiBIUL6NO == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass63_0
	{
		public ActionStep SqfSVgemMvF;

		public ActionExecuteContext Y4gSVLnPguU;

		public XAction TDFSVvHFCaV;

		public FileOperationStep oFpSVSGjYXB;

		private static _003C_003Ec__DisplayClass63_0 lcaiBGWr5PfPO9jXTGUq;

		internal (bool isSuccess, string message, ActionStopFlag failReason) Yp4SVtVAsRS()
		{
			_003C_003Ec__DisplayClass63_1 _003C_003Ec__DisplayClass63_ = new _003C_003Ec__DisplayClass63_1();
			string textParamValue = XActionHelper.GetTextParamValue(ikbgqktrwq9, SqfSVgemMvF, Y4gSVLnPguU);
			string textParamValue2 = XActionHelper.GetTextParamValue(an6gqG8sdnZ, SqfSVgemMvF, Y4gSVLnPguU);
			_003C_003Ec__DisplayClass63_.Xq9SVN1TwiV = XActionHelper.GetTextParamValue(gdigqsdFjvH, SqfSVgemMvF, Y4gSVLnPguU);
			bool booleanParamValue = XActionHelper.GetBooleanParamValue(J43gqHDJ9M5, SqfSVgemMvF, Y4gSVLnPguU);
			textParamValue2 = Environment.ExpandEnvironmentVariables(textParamValue2).Trim();
			textParamValue2 = PathHelper.RemoveZeroWidthChar(textParamValue2);
			_003C_003Ec__DisplayClass63_.Xq9SVN1TwiV = Environment.ExpandEnvironmentVariables(_003C_003Ec__DisplayClass63_.Xq9SVN1TwiV);
			if (textParamValue.EqualsAny(true, JoCgqK0TYj8.ValidForList.ToArray()))
			{
				XActionHelper.OutputResultIfNeeded(JoCgqK0TYj8, _003C_003Ec__DisplayClass63_.tBqSV2VJL3n, SqfSVgemMvF, Y4gSVLnPguU, TDFSVvHFCaV);
			}
			_003C_003Ec__DisplayClass63_.s0eSVJ0KBIM = "";
			oFpSVSGjYXB.EnsureNotEqual(textParamValue2, _003C_003Ec__DisplayClass63_.Xq9SVN1TwiV);
			switch (textParamValue)
			{
			case "rename":
				_003C_003Ec__DisplayClass63_.s0eSVJ0KBIM = oFpSVSGjYXB.sNYgq7pdCil(textParamValue2, _003C_003Ec__DisplayClass63_.Xq9SVN1TwiV, booleanParamValue, Y4gSVLnPguU);
				goto IL_0626;
			case "moveTo":
				oFpSVSGjYXB.sNYgq7pdCil(textParamValue2, _003C_003Ec__DisplayClass63_.Xq9SVN1TwiV, booleanParamValue, Y4gSVLnPguU);
				goto IL_0626;
			case "copyTo":
				_003C_003Ec__DisplayClass63_.s0eSVJ0KBIM = FileSystemHelper.CopyTo(textParamValue2, _003C_003Ec__DisplayClass63_.Xq9SVN1TwiV, booleanParamValue);
				goto IL_0626;
			case "recycle":
				return oFpSVSGjYXB.hGggqqyZakK(textParamValue2);
			case "makeDir":
				return oFpSVSGjYXB.n7HgqcEnBBB(textParamValue2);
			case "moveInto":
				FileSystemHelper.MoveIntoFolder(textParamValue2, _003C_003Ec__DisplayClass63_.Xq9SVN1TwiV, booleanParamValue, false);
				goto IL_0626;
			case "moveFile":
				return oFpSVSGjYXB.tHIgqZObmXf(textParamValue2, _003C_003Ec__DisplayClass63_.Xq9SVN1TwiV, booleanParamValue, Y4gSVLnPguU);
			case "enumDirs":
			{
				_003C_003Ec__DisplayClass63_2 _003C_003Ec__DisplayClass63_2 = new _003C_003Ec__DisplayClass63_2();
				string text = XActionHelper.GetTextParamValue(qkRgq1pMThc, SqfSVgemMvF, Y4gSVLnPguU);
				bool booleanParamValue3 = XActionHelper.GetBooleanParamValue(Remgqb90ZiL, SqfSVgemMvF, Y4gSVLnPguU);
				_003C_003Ec__DisplayClass63_2.U5dSVCapYoq = null;
				if (text.StartsWith("regex:"))
				{
					_003C_003Ec__DisplayClass63_2.U5dSVCapYoq = new Regex(text.Substring("regex:".Length), RegexOptions.Compiled);
					text = "*";
				}
				IList<string> list2 = Directory.GetDirectories(textParamValue2, text, booleanParamValue3 ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly).ToList();
				if (_003C_003Ec__DisplayClass63_2.U5dSVCapYoq != null)
				{
					list2 = list2.Where(_003C_003Ec__DisplayClass63_2.k1CSV0XyO6i).ToList();
				}
				XActionHelper.OutputResult(nosgqmyvTpV, SqfSVgemMvF, Y4gSVLnPguU, list2, TDFSVvHFCaV);
				goto IL_0626;
			}
			case "copyFile":
				return oFpSVSGjYXB.HtPgq95ew8g(textParamValue2, _003C_003Ec__DisplayClass63_.Xq9SVN1TwiV, booleanParamValue, Y4gSVLnPguU);
			case "copyInto":
				_003C_003Ec__DisplayClass63_.s0eSVJ0KBIM = FileSystemHelper.CopyInto(textParamValue2, _003C_003Ec__DisplayClass63_.Xq9SVN1TwiV, booleanParamValue);
				goto IL_0626;
			case "enumFiles":
			{
				string textParamValue3 = XActionHelper.GetTextParamValue(qkRgq1pMThc, SqfSVgemMvF, Y4gSVLnPguU);
				bool booleanParamValue2 = XActionHelper.GetBooleanParamValue(Remgqb90ZiL, SqfSVgemMvF, Y4gSVLnPguU);
				IList<string> list = null;
				if (textParamValue3.StartsWith("regex:"))
				{
					Regex regex_ = new Regex(textParamValue3.Substring("regex:".Length), RegexOptions.Compiled);
					list = new STMVA028LKncse7UYeB(new DirectoryInfo(textParamValue2), regex_, null, Array.Empty<string>(), booleanParamValue2, true).Select(_003C_003Ec.VhxSczwHcqD ?? (_003C_003Ec.VhxSczwHcqD = _003C_003Ec.aR5ScfNuCY1.CALSciLsXhP)).ToList();
				}
				else if (textParamValue3.Contains(';'))
				{
					string[] ilist_ = textParamValue3.SplitToList(";");
					list = new STMVA028LKncse7UYeB(new DirectoryInfo(textParamValue2), null, ilist_, Array.Empty<string>(), booleanParamValue2, true).Select(_003C_003Ec.uv0SVwptk5l ?? (_003C_003Ec.uv0SVwptk5l = _003C_003Ec.aR5ScfNuCY1.TlOSc3NGd31)).ToList();
				}
				else
				{
					list = Directory.GetFiles(textParamValue2, textParamValue3, booleanParamValue2 ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly).ToList();
				}
				XActionHelper.OutputResult(nosgqmyvTpV, SqfSVgemMvF, Y4gSVLnPguU, list, TDFSVvHFCaV);
				goto IL_0626;
			}
			case "deleteFile":
				return oFpSVSGjYXB.miogqVSlaZg(textParamValue2);
			case "createFile":
				return oFpSVSGjYXB.OO1gqRIwdHr(textParamValue2);
			case "recycleNoUi":
				return oFpSVSGjYXB.hGggqqyZakK(textParamValue2, true);
			case "moveIntoWithShell":
				FileSystemHelper.EnsureFolderExists(_003C_003Ec__DisplayClass63_.Xq9SVN1TwiV);
				FileOperations.Move(textParamValue2.SplitToList(), _003C_003Ec__DisplayClass63_.Xq9SVN1TwiV, FileOperationOptions.AllowUndo);
				goto IL_0626;
			case "deleteEmptyFolder":
				Directory.Delete(textParamValue2);
				goto IL_0626;
			case "copyIntoWithShell":
				FileSystemHelper.EnsureFolderExists(_003C_003Ec__DisplayClass63_.Xq9SVN1TwiV);
				FileOperations.Copy(textParamValue2.SplitToList(), _003C_003Ec__DisplayClass63_.Xq9SVN1TwiV, FileOperationOptions.AllowUndo);
				goto IL_0626;
			default:
				{
					return (isSuccess: false, message: "不支持的操作类型：" + textParamValue, failReason: ActionStopFlag.OperationFailed);
				}
				IL_0626:
				XActionHelper.OutputResultIfNeeded(JoCgqK0TYj8, _003C_003Ec__DisplayClass63_.EeKSVufLMX0, SqfSVgemMvF, Y4gSVLnPguU, TDFSVvHFCaV);
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
		}

		internal static bool RG3ddCWrYqPpfneYiiHl()
		{
			return lcaiBGWr5PfPO9jXTGUq == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass63_1
	{
		public string Xq9SVN1TwiV;

		public string s0eSVJ0KBIM;

		private static _003C_003Ec__DisplayClass63_1 l4ZU45WrRdl8u38oMxaj;

		internal object tBqSV2VJL3n()
		{
			return Xq9SVN1TwiV;
		}

		internal object EeKSVufLMX0()
		{
			return s0eSVJ0KBIM;
		}

		internal static bool KB5u9DWrgULX5v44dAro()
		{
			return l4ZU45WrRdl8u38oMxaj == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass63_2
	{
		public Regex U5dSVCapYoq;

		private static _003C_003Ec__DisplayClass63_2 RGbH4YWrMVIR9U0JZspW;

		internal bool k1CSV0XyO6i(string path)
		{
			return U5dSVCapYoq.IsMatch(Path.GetFileName(path));
		}

		internal static bool YroXXxWrUiGHS5fgGfmh()
		{
			return RGbH4YWrMVIR9U0JZspW == null;
		}
	}

	private static List<string> texgqhhu6vb;

	[CompilerGenerated]
	private readonly string Hpogqe8oMWJ = $"fa:{EFontAwesomeIcon.Light_Folders}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> zpDgqYf5aFB;

	[CompilerGenerated]
	private readonly string KJBgqIx8ibq = "https://getquicker.net/KC/Help/Doc/fileoperation";

	[CompilerGenerated]
	private readonly bool cNdgqWMXWgU;

	private static readonly StepInParamDef ikbgqktrwq9;

	private static readonly StepInParamDef an6gqG8sdnZ;

	private static readonly StepInParamDef gdigqsdFjvH;

	private static readonly StepInParamDef J43gqHDJ9M5;

	private static readonly StepInParamDef qkRgq1pMThc;

	private static readonly StepInParamDef Remgqb90ZiL;

	private static readonly StepInParamDef UjPgq6FdEgZ;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> JalgqXccQbU = new StepInParamDef[7] { ikbgqktrwq9, an6gqG8sdnZ, gdigqsdFjvH, qkRgq1pMThc, Remgqb90ZiL, J43gqHDJ9M5, UjPgq6FdEgZ };

	private static readonly StepOutParamDef nosgqmyvTpV;

	private static readonly StepOutParamDef JoCgqK0TYj8;

	private static readonly StepOutParamDef i2MgqxjmRow;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> hDdgqrlgFuM = new StepOutParamDef[3] { i2MgqxjmRow, nosgqmyvTpV, JoCgqK0TYj8 };

	internal static FileOperationStep zrC75OQtVaJEKWoFeN3E;

	public string Key => "sys:fileOperation";

	public string Name => "文件和目录操作";

	public IEnumerable<string> KeyWords => texgqhhu6vb;

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return Hpogqe8oMWJ;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Files;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return zpDgqYf5aFB;
		}
	}

	public string Description => "文件和目录操作。请确保路径是合法的。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return KJBgqIx8ibq;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return cNdgqWMXWgU;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return JalgqXccQbU;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return hDdgqrlgFuM;
		}
	}

	static FileOperationStep()
	{
		texgqhhu6vb = new List<string> { "文件夹", "wenjianjia" };
		ikbgqktrwq9 = new StepInParamDef
		{
			Key = "type",
			Name = "操作类型",
			Description = "操作类型",
			DefaultValue = "",
			IsRequired = true,
			Type = VarType.Enum,
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("copyInto", "复制到指定目录下"),
				new SelectionItem("copyIntoWithShell", "复制到指定目录下(Windows)"),
				new SelectionItem("copyTo", "复制为（指定结果名称或路径）"),
				new SelectionItem("moveInto", "移动到指定目录下"),
				new SelectionItem("moveIntoWithShell", "移动到指定目录下(Windows)"),
				new SelectionItem("rename", "移动/重命名为（指定结果名称或完整路径）"),
				new SelectionItem("deleteFile", "删除文件（不支持文件夹）"),
				new SelectionItem("deleteEmptyFolder", "删除空文件夹"),
				new SelectionItem("recycle", "移入回收站"),
				new SelectionItem("recycleNoUi", "移入回收站（安静模式，自动确认操作）"),
				new SelectionItem("makeDir", "创建文件夹"),
				new SelectionItem("createFile", "创建空文件"),
				new SelectionItem("enumFiles", "获取文件夹内的文件"),
				new SelectionItem("enumDirs", "获取文件夹内的子文件夹"),
				new SelectionItem("copyFile", "复制文件/文件夹（自动）【不建议使用】"),
				new SelectionItem("moveFile", "移动/重命名文件(夹)（自动）【不建议使用】")
			},
			IsControlField = true
		};
		an6gqG8sdnZ = new StepInParamDef
		{
			Key = "path",
			Name = "路径",
			Description = "要操作的文件或文件夹路径",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		gdigqsdFjvH = new StepInParamDef
		{
			Key = "dstPath",
			Name = "目标路径/名称",
			Description = "复制/移动的目标路径或新文件、文件名。详情请参考文档。",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "copyFile", "copyInto", "copyTo", "copyIntoWithShell", "moveIntoWithShell", "moveFile", "moveInto", "rename", "moveTo" }
		};
		J43gqHDJ9M5 = new StepInParamDef
		{
			Key = "overwrite",
			Name = "覆盖已有",
			DefaultValue = false,
			Description = "如果目标位置已存在文件，是否覆盖？",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "copyFile", "copyInto", "copyTo", "moveFile", "moveInto", "rename", "moveTo" }
		};
		qkRgq1pMThc = new StepInParamDef
		{
			Key = "searchPattern",
			Name = "搜索内容",
			Description = "筛选文件或目录名。可以包含通配符*和?，或“regex:正则表达式”。搜索文件时也可以为分号隔开的多个后缀名如.jpg;.png;.bmp",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			DefaultValue = "*",
			ValidForList = new List<string> { "enumFiles", "enumDirs" }
		};
		Remgqb90ZiL = new StepInParamDef
		{
			Key = "isAll",
			Name = "包含子目录",
			DefaultValue = false,
			Description = "包含子目录中的(否则只搜索顶层目录)",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "enumFiles", "enumDirs" }
		};
		UjPgq6FdEgZ = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后中止动作",
			DefaultValue = true,
			Description = "如果操作异常，是否终止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		nosgqmyvTpV = new StepOutParamDef
		{
			Key = "files",
			Name = "路径列表",
			Description = "搜索到的文件或文件夹列表",
			ValidForList = new string[2] { "enumFiles", "enumDirs" },
			Type = VarType.List
		};
		JoCgqK0TYj8 = new StepOutParamDef
		{
			Key = "resultPath",
			Name = "结果路径",
			Description = "结果文件路径",
			ValidForList = new string[3] { "copyTo", "rename", "copyInto" },
			Type = VarType.Text
		};
		i2MgqxjmRow = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		foreach (SelectionItem selectionItem in ikbgqktrwq9.SelectionItems)
		{
			texgqhhu6vb.Add(selectionItem.Name);
			texgqhhu6vb.Add(selectionItem.Value);
		}
	}

	public void EnsureNotEqual(string path1, string path2)
	{
		if (string.Equals(path1, path2, StringComparison.OrdinalIgnoreCase) && !string.IsNullOrEmpty(path1) && !string.IsNullOrEmpty(path2))
		{
			throw new InvalidDataException("两个路径不能相同。");
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass63_0 _003C_003Ec__DisplayClass63_ = new _003C_003Ec__DisplayClass63_0();
		_003C_003Ec__DisplayClass63_.SqfSVgemMvF = step;
		_003C_003Ec__DisplayClass63_.Y4gSVLnPguU = context;
		_003C_003Ec__DisplayClass63_.TDFSVvHFCaV = action;
		_003C_003Ec__DisplayClass63_.oFpSVSGjYXB = this;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass63_.Y4gSVLnPguU, _003C_003Ec__DisplayClass63_.SqfSVgemMvF, _003C_003Ec__DisplayClass63_.TDFSVvHFCaV, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass63_.Yp4SVtVAsRS, (Action)null, (Action)null, UjPgq6FdEgZ, i2MgqxjmRow);
	}

	private string sNYgq7pdCil(string string_2, string string_3, bool bool_1, ActionExecuteContext actionExecuteContext_0)
	{
		FileSystemHelper.EnsureFolderExists(Path.GetDirectoryName(string_3));
		return FileSystemHelper.RenameFileOrFolder(string_2, string_3, bool_1);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) OO1gqRIwdHr(string string_2)
	{
		if (!System.IO.File.Exists(string_2))
		{
			FileSystemHelper.EnsureFileFolderExists(string_2);
			System.IO.File.Create(string_2).Dispose();
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}
		return (isSuccess: false, message: "文件已存在：" + string_2, failReason: ActionStopFlag.OperationFailed);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) hGggqqyZakK(string string_2, bool bool_1 = false)
	{
		if (!System.IO.File.Exists(string_2) && !Directory.Exists(string_2))
		{
			if (string_2.Contains("\n"))
			{
				string[] array = string_2.SplitToList();
				for (int i = 0; i < array.Length; i++)
				{
					FileOperationApiWrapper.MoveToRecycleBin(array[i], bool_1);
				}
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
			return (isSuccess: false, message: "路径不存在", failReason: ActionStopFlag.OperationFailed);
		}
		FileOperationApiWrapper.MoveToRecycleBin(string_2, bool_1);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) n7HgqcEnBBB(string string_2)
	{
		if (!Directory.Exists(string_2))
		{
			Directory.CreateDirectory(string_2);
		}
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) miogqVSlaZg(string string_2)
	{
		if (System.IO.File.Exists(string_2))
		{
			System.IO.File.Delete(string_2);
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}
		return (isSuccess: false, message: "要删除的文件" + string_2 + "不存在。", failReason: ActionStopFlag.OperationFailed);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) tHIgqZObmXf(string string_2, string string_3, bool bool_1, ActionExecuteContext actionExecuteContext_0)
	{
		if (DoMoveFileDoMoveFile(string_2, string_3, bool_1, false).isSuccess)
		{
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}
		return (isSuccess: false, message: "", failReason: ActionStopFlag.OperationFailed);
	}

	public static (bool isSuccess, string message) DoMoveFileDoMoveFile(string path, string dstPath, bool overwrite, bool asSubFolder)
	{
		if (System.IO.File.Exists(path))
		{
			string text = dstPath;
			if (Directory.Exists(dstPath))
			{
				text = Path.Combine(dstPath, Path.GetFileName(path));
			}
			else if (!Path.HasExtension(dstPath))
			{
				Directory.CreateDirectory(dstPath);
				text = Path.Combine(dstPath, Path.GetFileName(path));
			}
			if (overwrite && System.IO.File.Exists(text))
			{
				System.IO.File.Delete(text);
			}
			System.IO.File.Move(path, text);
			return (isSuccess: true, message: "");
		}
		if (Directory.Exists(path))
		{
			string destDirName = dstPath;
			if (asSubFolder)
			{
				if (!Directory.Exists(dstPath))
				{
					Directory.CreateDirectory(dstPath);
				}
				destDirName = Path.Combine(dstPath, Path.GetFileName(path));
			}
			Directory.Move(path, destDirName);
			return (isSuccess: true, message: "");
		}
		return (isSuccess: false, message: "路径不存在：" + path);
	}

	public static (bool isSuccess, string message) MoveToFolder(string path, string dstPath, bool overwrite)
	{
		if (!Directory.Exists(dstPath))
		{
			Directory.CreateDirectory(dstPath);
		}
		if (System.IO.File.Exists(path))
		{
			string text = Path.Combine(dstPath, Path.GetFileName(path));
			if (overwrite && System.IO.File.Exists(text))
			{
				System.IO.File.Delete(text);
			}
			System.IO.File.Move(path, text);
			return (isSuccess: true, message: "");
		}
		if (Directory.Exists(path))
		{
			string destDirName = Path.Combine(dstPath, Path.GetFileName(path));
			Directory.Move(path, destDirName);
			return (isSuccess: true, message: "");
		}
		return (isSuccess: false, message: "路径不存在：" + path);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) HtPgq95ew8g(string string_2, string string_3, bool bool_1, ActionExecuteContext actionExecuteContext_0)
	{
		if (System.IO.File.Exists(string_2))
		{
			if (Directory.Exists(string_3))
			{
				string_3 = Path.Combine(string_3, Path.GetFileName(string_2));
			}
			else if (!Path.HasExtension(string_3))
			{
				Directory.CreateDirectory(string_3);
				string_3 = Path.Combine(string_3, Path.GetFileName(string_2));
			}
			if (actionExecuteContext_0.IsDebugging)
			{
				actionExecuteContext_0.ActionLogger?.LogInfo("复制文件：" + string_2 + " => " + string_3);
			}
			if (!bool_1 && System.IO.File.Exists(string_3))
			{
				return (isSuccess: false, message: "目标文件" + string_3 + "已经存在！", failReason: ActionStopFlag.OperationFailed);
			}
			System.IO.File.Copy(string_2, string_3, bool_1);
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}
		if (Directory.Exists(string_2))
		{
			if (actionExecuteContext_0.IsDebugging)
			{
				actionExecuteContext_0.ActionLogger?.LogInfo("复制文件夹：" + string_2 + " => " + string_3);
			}
			try
			{
				FileSystemHelper.DirectoryCopy(string_2, string_3, true, bool_1);
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
			catch (Exception ex)
			{
				return (isSuccess: false, message: ex.Message, failReason: ActionStopFlag.OperationFailed);
			}
		}
		return (isSuccess: false, message: "路径不存在：" + string_2, failReason: ActionStopFlag.OperationFailed);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDirectValue(ikbgqktrwq9, step) ?? "";
	}

	internal static bool e2owCwQtQ2BEWd3VtPQj()
	{
		return zrC75OQtVaJEKWoFeN3E == null;
	}
}
