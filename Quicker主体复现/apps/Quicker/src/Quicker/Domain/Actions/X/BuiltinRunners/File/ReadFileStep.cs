using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using FontAwesome5;
using log4net;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Modules.TextTools;
using Quicker.Properties;
using Quicker.Public.Actions;
using Quicker.Utilities;
using Quicker.Utilities.Images;
using Quicker.Utilities.Win32;

namespace Quicker.Domain.Actions.X.BuiltinRunners.File;

public class ReadFileStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass42_0
	{
		public ActionStep TUxSVQEIo2u;

		public ActionExecuteContext MZeSVjj7mAj;

		public XAction eDjSVn8g8PD;

		internal static _003C_003Ec__DisplayClass42_0 MH2NxTWNypu9QkI3c1Uj;

		internal (bool isSuccess, string message, ActionStopFlag failReason) cjnSVBSxalt()
		{
			string textParamValue = XActionHelper.GetTextParamValue(kTqgcG1cAwK, TUxSVQEIo2u, MZeSVjj7mAj);
			textParamValue = PathHelper.RemoveZeroWidthChar(textParamValue);
			if (textParamValue.Contains("%"))
			{
				textParamValue = Environment.ExpandEnvironmentVariables(textParamValue);
			}
			if (!System.IO.File.Exists(textParamValue))
			{
				return (isSuccess: false, message: "文件不存在：" + textParamValue, failReason: ActionStopFlag.OperationFailed);
			}
			string textParamValue2 = XActionHelper.GetTextParamValue(UtUgcsvxN4D, TUxSVQEIo2u, MZeSVjj7mAj);
			if (textParamValue2 == "image")
			{
				try
				{
					Image result = ImageHelper.ReadImageFromFileWithoutLock(textParamValue);
					XActionHelper.OutputResult(nOEgcXJSXuZ, TUxSVQEIo2u, MZeSVjj7mAj, result, eDjSVn8g8PD);
				}
				catch (Exception ex)
				{
					return (isSuccess: false, message: "打开图片 " + Path.GetFileName(textParamValue) + " 失败。" + ex.Message, failReason: ActionStopFlag.OperationFailed);
				}
			}
			else
			{
				if (!(textParamValue2 == "text"))
				{
					return (isSuccess: false, message: "不支持的操作类型：" + textParamValue2, failReason: ActionStopFlag.OperationFailed);
				}
				string textParamValue3 = XActionHelper.GetTextParamValue(iuYgcH6W0n7, TUxSVQEIo2u, MZeSVjj7mAj);
				Encoding encoding = Encoding.UTF8;
				if (!string.IsNullOrWhiteSpace(textParamValue3))
				{
					if (textParamValue3.Equals("default", StringComparison.OrdinalIgnoreCase))
					{
						encoding = Encoding.Default;
					}
					else if (textParamValue3 == "auto")
					{
						encoding = TxtFileEncoder.GetEncoding(textParamValue);
					}
					else
					{
						try
						{
							encoding = Encoding.GetEncoding(textParamValue3);
						}
						catch (Exception ex2)
						{
							MZeSVjj7mAj.ActionLogger?.LogWarning(CommonStrings.Common_Err_UnknownEncoding + textParamValue3 + ex2.Message);
							AppHelper.ShowWarning(CommonStrings.Common_Err_UnknownEncoding + textParamValue3);
							encoding = Encoding.UTF8;
						}
					}
				}
				if (new FileInfo(textParamValue).Length > 40000000L)
				{
					AppHelper.ShowWarning(Path.GetFileName(textParamValue) + " 文件较大，可能不是文本文件。");
				}
				try
				{
					string result2 = System.IO.File.ReadAllText(textParamValue, encoding);
					XActionHelper.OutputResult(UNPgc6OvSyH, TUxSVQEIo2u, MZeSVjj7mAj, result2, eDjSVn8g8PD);
				}
				catch (Exception ex3)
				{
					return (isSuccess: false, message: "读取文本文件 " + Path.GetFileName(textParamValue) + " 失败。" + ex3.Message, failReason: ActionStopFlag.OperationFailed);
				}
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool Dru7UAWNpQ18Wj0XYgYW()
		{
			return MH2NxTWNypu9QkI3c1Uj == null;
		}
	}

	private static readonly ILog pH0gchcOy7W;

	[CompilerGenerated]
	private readonly IEnumerable<string> UESgceIMcyY = new string[4] { "编码", "load", "图片", "tupian" };

	[CompilerGenerated]
	private readonly string wSIgcYqc60B = $"fa:{EFontAwesomeIcon.Light_FolderOpen}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> iqTgcIaErDP = new List<StepRunnerCategory> { StepRunnerCategory.Image };

	[CompilerGenerated]
	private readonly string mKggcWraiGf = "https://getquicker.net/KC/Help/Doc/readFile";

	[CompilerGenerated]
	private readonly bool s6XgcksZPEP;

	private static readonly StepInParamDef kTqgcG1cAwK;

	private static readonly StepInParamDef UtUgcsvxN4D;

	private static readonly StepInParamDef iuYgcH6W0n7;

	private static readonly StepInParamDef jYdgc1n4I8q;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> MwmgcbPFdAZ = new StepInParamDef[4] { kTqgcG1cAwK, UtUgcsvxN4D, iuYgcH6W0n7, jYdgc1n4I8q };

	private static readonly StepOutParamDef UNPgc6OvSyH;

	private static readonly StepOutParamDef nOEgcXJSXuZ;

	private static readonly StepOutParamDef BOqgcmuRT4e;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> SCsgcK6ANXE = new StepOutParamDef[3] { UNPgc6OvSyH, nOEgcXJSXuZ, BOqgcmuRT4e };

	internal static ReadFileStep muWwKuQtuSVF68jhSWiR;

	public string Key => "sys:readFile";

	public string Name => "读取文件";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return UESgceIMcyY;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return wSIgcYqc60B;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Files;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return iqTgcIaErDP;
		}
	}

	public string Description => "将读取的文本或图片内容写入变量。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return mKggcWraiGf;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return s6XgcksZPEP;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return MwmgcbPFdAZ;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return SCsgcK6ANXE;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass42_0 _003C_003Ec__DisplayClass42_ = new _003C_003Ec__DisplayClass42_0();
		_003C_003Ec__DisplayClass42_.TUxSVQEIo2u = step;
		_003C_003Ec__DisplayClass42_.MZeSVjj7mAj = context;
		_003C_003Ec__DisplayClass42_.eDjSVn8g8PD = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass42_.MZeSVjj7mAj, _003C_003Ec__DisplayClass42_.TUxSVQEIo2u, _003C_003Ec__DisplayClass42_.eDjSVn8g8PD, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass42_.cjnSVBSxalt, (Action)null, (Action)null, jYdgc1n4I8q, BOqgcmuRT4e);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(kTqgcG1cAwK, step) + " => " + XActionHelper.GetOutputParamDisplayString(UNPgc6OvSyH, step) + XActionHelper.GetOutputParamDisplayString(nOEgcXJSXuZ, step);
	}

	static ReadFileStep()
	{
		pH0gchcOy7W = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		kTqgcG1cAwK = new StepInParamDef
		{
			Key = "path",
			Name = "文件路径",
			Description = "要读取的文件的完整路径。",
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text,
			TextTools = new List<TextToolType> { TextToolType.SelectSingleFile },
			TextToolsContextHint = new TextToolsContextHint
			{
				FileDialogFilter = "任意文件|*.*|文本文件|*.txt|图片文件|*.png;*.jpg;*.jpeg;*.bmp;*.tiff"
			}
		};
		UtUgcsvxN4D = new StepInParamDef
		{
			Key = "type",
			Name = "格式",
			Description = "文件内容类型",
			IsRequired = true,
			VariableMode = ParamVariableMode.Input,
			Type = VarType.Enum,
			DefaultValue = "text",
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("text", "文本"),
				new SelectionItem("image", "图片")
			},
			IsControlField = true
		};
		iuYgcH6W0n7 = new StepInParamDef
		{
			Key = "encoding",
			Name = "文件编码",
			Description = "文件的编码格式",
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
				new SelectionItem("default", "系统默认(" + Encoding.Default.WebName + ")"),
				new SelectionItem("auto", "自动")
			},
			ValidForList = new List<string> { "text" }
		};
		jYdgc1n4I8q = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		UNPgc6OvSyH = new StepOutParamDef
		{
			Key = "txt",
			Name = "文本内容",
			Description = "读取的文本文件的内容",
			Type = VarType.Text,
			ValidForList = new List<string> { "text" }
		};
		nOEgcXJSXuZ = new StepOutParamDef
		{
			Key = "image",
			Name = "图片内容",
			Description = "读取的图片文件的内容",
			Type = VarType.Image,
			ValidForList = new List<string> { "image" }
		};
		BOqgcmuRT4e = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
	}

	internal static bool vPoX40QtoQ2m3j2mLFcN()
	{
		return muWwKuQtuSVF68jhSWiR == null;
	}
}
