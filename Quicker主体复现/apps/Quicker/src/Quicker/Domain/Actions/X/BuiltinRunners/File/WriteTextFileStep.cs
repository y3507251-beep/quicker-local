using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using FontAwesome5;
using log4net;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Properties;
using Quicker.Public.Actions;
using Quicker.Utilities;
using Quicker.Utilities.Win32;

namespace Quicker.Domain.Actions.X.BuiltinRunners.File;

public class WriteTextFileStep : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec krmSV5ZCwEe;

		public static Func<string, object> JsmSVDrEJR9;

		internal static _003C_003Ec lxRyCfWN2OM7qQ4XZmGk;

		static _003C_003Ec()
		{
			krmSV5ZCwEe = new _003C_003Ec();
		}

		internal object gOFSV4XULQb(string _)
		{
			return new object();
		}

		internal static bool GNYVbRWNAVfnVMR959vX()
		{
			return lxRyCfWN2OM7qQ4XZmGk == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass45_0
	{
		public ActionStep GdoSVouLh1Y;

		public ActionExecuteContext pj4SVTeR1PB;

		internal static _003C_003Ec__DisplayClass45_0 sgALJvWNeNPeeiKVJqo1;

		internal (bool isSuccess, string message, ActionStopFlag failReason) h6NSVdVfJhX()
		{
			string textParamValue = XActionHelper.GetTextParamValue(p2NgcDKI37y, GdoSVouLh1Y, pj4SVTeR1PB);
			if (string.IsNullOrEmpty(textParamValue))
			{
				return (isSuccess: false, message: "要写入的文件路径为空，请检查配置。", failReason: ActionStopFlag.OperationFailed);
			}
			textParamValue = PathHelper.RemoveZeroWidthChar(textParamValue);
			(bool, char) tuple = PathHelper.ValidatePath(textParamValue);
			if (!tuple.Item1)
			{
				object arg = tuple.Item2;
				int item = tuple.Item2;
				return (isSuccess: false, message: string.Format("路径含有非法字符：{0}({1})", arg, item.ToString("X4")), failReason: ActionStopFlag.OperationFailed);
			}
			if (Directory.Exists(textParamValue))
			{
				return (isSuccess: false, message: "输入的文件路径是一个目录，无法写入文件。", failReason: ActionStopFlag.OperationFailed);
			}
			string text = XActionHelper.GetTextParamValue(WmPgc54KZKJ, GdoSVouLh1Y, pj4SVTeR1PB);
			string textParamValue2 = XActionHelper.GetTextParamValue(gV4gcdQ73n9, GdoSVouLh1Y, pj4SVTeR1PB);
			bool booleanParamValue = XActionHelper.GetBooleanParamValue(hhagcTpbvNt, GdoSVouLh1Y, pj4SVTeR1PB);
			bool booleanParamValue2 = XActionHelper.GetBooleanParamValue(nSBgcMFJMTr, GdoSVouLh1Y, pj4SVTeR1PB);
			bool booleanParamValue3 = XActionHelper.GetBooleanParamValue(T0VgcoQDTnE, GdoSVouLh1Y, pj4SVTeR1PB);
			string textParamValue3 = XActionHelper.GetTextParamValue(tMugcAMjEvX, GdoSVouLh1Y, pj4SVTeR1PB);
			if (!string.IsNullOrEmpty(textParamValue3))
			{
				text = NormalizeNewlines(text, textParamValue3);
			}
			string text2 = (string.IsNullOrEmpty(textParamValue3) ? Environment.NewLine : textParamValue3);
			if (booleanParamValue2)
			{
				text += text2;
			}
			Encoding encoding = Encoding.UTF8;
			if (!string.IsNullOrWhiteSpace(textParamValue2))
			{
				if (textParamValue2.Equals("default", StringComparison.OrdinalIgnoreCase))
				{
					encoding = Encoding.Default;
				}
				else
				{
					try
					{
						encoding = Encoding.GetEncoding(textParamValue2);
					}
					catch (Exception ex)
					{
						pj4SVTeR1PB.ActionLogger?.LogWarning(CommonStrings.Common_Err_UnknownEncoding + textParamValue2 + ex.Message);
						AppHelper.ShowWarning(CommonStrings.Common_Err_UnknownEncoding + textParamValue2);
						encoding = Encoding.UTF8;
					}
				}
			}
			if (encoding is UTF8Encoding && !booleanParamValue3 && !textParamValue.EndsWith(".ps1", StringComparison.OrdinalIgnoreCase))
			{
				encoding = new UTF8Encoding(false);
			}
			try
			{
				FileSystemHelper.EnsureFileFolderExists(textParamValue);
				if (booleanParamValue)
				{
					string key = textParamValue.ToLower();
					lock (fFrgcpQgJK1.GetOrAdd(key, _003C_003Ec.JsmSVDrEJR9 ?? (_003C_003Ec.JsmSVDrEJR9 = _003C_003Ec.krmSV5ZCwEe.gOFSV4XULQb)))
					{
						if (System.IO.File.Exists(textParamValue))
						{
							System.IO.File.AppendAllText(textParamValue, text, encoding);
						}
						else
						{
							System.IO.File.WriteAllText(textParamValue, text, encoding);
						}
					}
				}
				else if (System.IO.File.Exists(textParamValue))
				{
					B6RgcxVbYNE(textParamValue, encoding, text);
				}
				else
				{
					System.IO.File.WriteAllText(textParamValue, text, encoding);
				}
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
			catch (Exception ex2)
			{
				string item2 = "写入文件" + textParamValue + "出错：" + ex2.Message;
				return (isSuccess: false, message: item2, failReason: ActionStopFlag.OperationFailed);
			}
		}

		internal static bool Tc7xELWNjytAQAKjsbbh()
		{
			return sgALJvWNeNPeeiKVJqo1 == null;
		}
	}

	private static readonly ILog jdpgcriGG3A;

	private static readonly ConcurrentDictionary<string, object> fFrgcpQgJK1;

	[CompilerGenerated]
	private readonly IEnumerable<string> AAqgcBcWoqU;

	[CompilerGenerated]
	private readonly string NBjgcQtrRZ3 = $"fa:{EFontAwesomeIcon.Light_FileEdit}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> YWwgcjEDOXG;

	[CompilerGenerated]
	private readonly string WAIgcnDoZV2 = "https://getquicker.net/KC/Help/Doc/writetextfile";

	[CompilerGenerated]
	private readonly bool eQTgc42p8ce;

	private static readonly StepInParamDef WmPgc54KZKJ;

	private static readonly StepInParamDef p2NgcDKI37y;

	private static readonly StepInParamDef gV4gcdQ73n9;

	private static readonly StepInParamDef T0VgcoQDTnE;

	private static readonly StepInParamDef hhagcTpbvNt;

	private static readonly StepInParamDef nSBgcMFJMTr;

	private static readonly StepInParamDef tMugcAMjEvX;

	private static readonly StepInParamDef erRgcO5SiKG;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> bE8gcFWfoL5 = new StepInParamDef[8] { WmPgc54KZKJ, p2NgcDKI37y, gV4gcdQ73n9, T0VgcoQDTnE, hhagcTpbvNt, nSBgcMFJMTr, tMugcAMjEvX, erRgcO5SiKG };

	private static readonly StepOutParamDef oZCgcULkowd;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> xSugclEKWAj = new List<StepOutParamDef> { oZCgcULkowd };

	private static WriteTextFileStep n9bmaKQtZQPtDtqYcNmO;

	public string Key => "sys:WriteTextFile";

	public string Name => "写入文本文件";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return AAqgcBcWoqU;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return NBjgcQtrRZ3;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Files;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return YWwgcjEDOXG;
		}
	}

	public string Description => "将内容写入文本文件";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return WAIgcnDoZV2;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return eQTgc42p8ce;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return bE8gcFWfoL5;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return xSugclEKWAj;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass45_0 _003C_003Ec__DisplayClass45_ = new _003C_003Ec__DisplayClass45_0();
		_003C_003Ec__DisplayClass45_.GdoSVouLh1Y = step;
		_003C_003Ec__DisplayClass45_.pj4SVTeR1PB = context;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass45_.pj4SVTeR1PB, _003C_003Ec__DisplayClass45_.GdoSVouLh1Y, action, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass45_.h6NSVdVfJhX, (Action)null, (Action)null, erRgcO5SiKG, oZCgcULkowd);
	}

	private static void B6RgcxVbYNE(string string_2, Encoding encoding_0, string string_3)
	{
		try
		{
			using FileStream fileStream = System.IO.File.OpenWrite(string_2);
			fileStream.Position = 0L;
			fileStream.SetLength(0L);
			using StreamWriter streamWriter = new StreamWriter(fileStream, encoding_0);
			streamWriter.Write(string_3);
			streamWriter.Flush();
		}
		catch (Exception ex)
		{
			jdpgcriGG3A.Warn("覆盖已有文件出错：" + ex.Message, ex);
			System.IO.File.WriteAllText(string_2, string_3, encoding_0);
		}
	}

	public static string NormalizeNewlines(string input, string newline = "\r\n")
	{
		if (string.IsNullOrEmpty(input))
		{
			return input;
		}
		return input.Replace("\r\n", "\n").Replace("\r", "\n").Replace("\n", newline);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(p2NgcDKI37y, step) ?? "";
	}

	static WriteTextFileStep()
	{
		jdpgcriGG3A = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		fFrgcpQgJK1 = new ConcurrentDictionary<string, object>();
		WmPgc54KZKJ = new StepInParamDef
		{
			Key = "content",
			Name = "内容",
			Description = "要写入文件的内容",
			DefaultValue = "",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true
		};
		p2NgcDKI37y = new StepInParamDef
		{
			Key = "filePath",
			Name = "文件路径",
			Description = "要写入的完整文件路径（包含文件名）",
			DefaultValue = "",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		gV4gcdQ73n9 = new StepInParamDef
		{
			Key = "encoding",
			Name = "文件编码",
			Description = "写入文件的编码格式",
			DefaultValue = Encoding.UTF8.WebName,
			IsRequired = true,
			Type = VarType.Enum,
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem(Encoding.UTF8.WebName, "UTF8"),
				new SelectionItem(Encoding.Unicode.WebName, "UTF-16 LE"),
				new SelectionItem(Encoding.BigEndianUnicode.WebName, "UTF-16 BE"),
				new SelectionItem(Encoding.ASCII.WebName, "ASCII"),
				new SelectionItem(Encoding.UTF7.WebName, "UTF7"),
				new SelectionItem(Encoding.UTF32.WebName, "UTF32"),
				new SelectionItem("default", "系统默认(" + Encoding.Default.WebName + ")")
			}
		};
		T0VgcoQDTnE = new StepInParamDef
		{
			Key = "addUtf8Bom",
			Name = "添加UTF-BOM",
			Description = "UTF8编码文件是否写入BOM标记",
			DefaultValue = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		hhagcTpbvNt = new StepInParamDef
		{
			Key = "appendMode",
			Name = "添加到文件末尾",
			Description = "如果文件已存在，则添加到文件的末尾",
			DefaultValue = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		nSBgcMFJMTr = new StepInParamDef
		{
			Key = "addNewLine",
			Name = "添加空行",
			Description = "在文件末尾添加空行",
			DefaultValue = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		tMugcAMjEvX = new StepInParamDef
		{
			Key = "newLineChars",
			Name = "统一换行字符",
			Description = "",
			DefaultValue = "",
			IsRequired = true,
			Type = VarType.Enum,
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("", "默认（不处理）"),
				new SelectionItem("\r\n", "\\r\\n", "Windows"),
				new SelectionItem("\r", "\\r ", "(Mac)"),
				new SelectionItem("\n", "\\n ", "(Linux)")
			}
		};
		erRgcO5SiKG = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		oZCgcULkowd = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
	}

	internal static bool n1JudhQt5KvpakXUVHrR()
	{
		return n9bmaKQtZQPtDtqYcNmO == null;
	}
}
