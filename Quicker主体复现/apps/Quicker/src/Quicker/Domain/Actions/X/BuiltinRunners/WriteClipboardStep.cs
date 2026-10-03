using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using FontAwesome5;
using gNDpGkYZYbhLdMnAyKv;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Properties;
using Quicker.Public.Actions;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Win32;
using Windows.ApplicationModel.DataTransfer;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class WriteClipboardStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass53_0
	{
		public ActionStep pbWSgkiP5qU;

		public ActionExecuteContext mAXSgGw0fpe;

		private static _003C_003Ec__DisplayClass53_0 qZk28gWGZipP2UJJhArc;

		internal (bool isSuccess, string message, ActionStopFlag failReason) IXHSgWTgqhq()
		{
			AppState.LogQuickerPaste();
			string textParamValue = XActionHelper.GetTextParamValue(kE4t3ArHiD8, pbWSgkiP5qU, mAXSgGw0fpe);
			string string_ = "";
			if (textParamValue == "custom")
			{
				string_ = XActionHelper.GetTextParamValue(i9mt3OZBcpZ, pbWSgkiP5qU, mAXSgGw0fpe);
			}
			int clipboardSequenceNumber = AppState.ClipboardSequenceNumber;
			if (!string.IsNullOrEmpty(textParamValue) && !textParamValue.Equals("auto", StringComparison.OrdinalIgnoreCase))
			{
				if (textParamValue.Equals("html", StringComparison.OrdinalIgnoreCase))
				{
					mAXSgGw0fpe.ActionLogger?.LogInfo("写入HTML类型。");
					string text = XActionHelper.GetTextParamValue(mVKt3lvlG4I, pbWSgkiP5qU, mAXSgGw0fpe);
					string textParamValue2 = XActionHelper.GetTextParamValue(Pf4t3U9QAqf, pbWSgkiP5qU, mAXSgGw0fpe);
					if (string.IsNullOrEmpty(text))
					{
						text = textParamValue2.HtmlToPlainText();
					}
					if (!ClipboardHelper.SetHtml(textParamValue2, text))
					{
						return (isSuccess: false, message: CommonStrings.WriteClipboardStep_Execute_NotSuccess, failReason: ActionStopFlag.OperationFailed);
					}
				}
				else if (textParamValue.Equals("image", StringComparison.OrdinalIgnoreCase))
				{
					mAXSgGw0fpe.ActionLogger?.LogInfo("写入图片类型。");
					string imgFilePath;
					Image imageParamValue = XActionHelper.GetImageParamValue(KW2t3io70qa, pbWSgkiP5qU, mAXSgGw0fpe, out imgFilePath);
					bool booleanParamValue = XActionHelper.GetBooleanParamValue(ScEt33qiPZe, pbWSgkiP5qU, mAXSgGw0fpe);
					if (imageParamValue == null)
					{
						return (isSuccess: false, message: "图片为空", failReason: ActionStopFlag.OperationFailed);
					}
					if (booleanParamValue)
					{
						kWsP1bYRVsfaicfjr67.P2nL5xQT1T2(imageParamValue);
					}
					else
					{
						ImageClipboardHelper.SetImage(imageParamValue);
					}
				}
				else if (textParamValue.Equals("text", StringComparison.OrdinalIgnoreCase))
				{
					mAXSgGw0fpe.ActionLogger?.LogInfo("写入文本类型。");
					if (!ClipboardHelper.SetText(XActionHelper.GetTextParamValue(mVKt3lvlG4I, pbWSgkiP5qU, mAXSgGw0fpe)))
					{
						return (isSuccess: false, message: CommonStrings.WriteClipboardStep_Execute_NotSuccess, failReason: ActionStopFlag.OperationFailed);
					}
				}
				else
				{
					switch (textParamValue)
					{
					case "csv":
						mAXSgGw0fpe.ActionLogger?.LogInfo("写入csv类型。");
						ClipboardHelper.E5uLoz3712g(XActionHelper.GetTextParamValue(mVKt3lvlG4I, pbWSgkiP5qU, mAXSgGw0fpe), TextDataFormat.CommaSeparatedValue);
						break;
					case "rtf":
						mAXSgGw0fpe.ActionLogger?.LogInfo("写入rtf类型。");
						ClipboardHelper.E5uLoz3712g(XActionHelper.GetTextParamValue(mVKt3lvlG4I, pbWSgkiP5qU, mAXSgGw0fpe), TextDataFormat.Rtf);
						break;
					case "custom":
					{
						using (MemoryStream object_ = XActionHelper.GetTextParamValue(mVKt3lvlG4I, pbWSgkiP5qU, mAXSgGw0fpe).ToMemoryStream())
						{
							kWsP1bYRVsfaicfjr67.F12L5bNlTL1(string_, object_);
						}
						break;
					}
					case "clear":
						mAXSgGw0fpe.ActionLogger?.LogInfo("清空剪贴板。");
						ClipboardHelper.Clear();
						break;
					case "clearHistory":
						ClearWindowsClipboardHistory();
						break;
					default:
						return (isSuccess: false, message: CommonStrings.WriteClipboardStep_Execute_Err_NotSupportType + textParamValue, failReason: ActionStopFlag.OperationFailed);
					}
				}
			}
			else
			{
				object paramValue = XActionHelper.GetParamValue(iTdt3FP6JcU, pbWSgkiP5qU, mAXSgGw0fpe);
				if (paramValue == null)
				{
					return (isSuccess: false, message: "要写入剪贴板的内容为NULL", failReason: ActionStopFlag.OperationFailed);
				}
				if (paramValue is Image image)
				{
					mAXSgGw0fpe.ActionLogger?.LogInfo("写入图片类型。");
					ImageClipboardHelper.SetImage(image);
				}
				else
				{
					mAXSgGw0fpe.ActionLogger?.LogInfo("写入文本类型。");
					string textParamValue3 = XActionHelper.GetTextParamValue(iTdt3FP6JcU, pbWSgkiP5qU, mAXSgGw0fpe);
					if (string.IsNullOrEmpty(textParamValue3))
					{
						return (isSuccess: false, message: "要写入剪贴板的文本为空。", failReason: ActionStopFlag.OperationFailed);
					}
					if (!ClipboardHelper.SetText(textParamValue3))
					{
						return (isSuccess: false, message: CommonStrings.WriteClipboardStep_Execute_NotSuccess, failReason: ActionStopFlag.OperationFailed);
					}
				}
			}
			if (!AppHelper.WaitClipboardChange(clipboardSequenceNumber, 2000))
			{
				return (isSuccess: false, message: "更新剪贴板失败了。", failReason: ActionStopFlag.OperationFailed);
			}
			string textParamValue4 = XActionHelper.GetTextParamValue(yMqt3fw75sG, pbWSgkiP5qU, mAXSgGw0fpe);
			if (!string.IsNullOrEmpty(textParamValue4))
			{
				AppHelper.ShowSuccess(textParamValue4);
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool K5O1FjWG5pKwwo91cnty()
		{
			return qZk28gWGZipP2UJJhArc == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> c9Qt3DBkMKh = new string[5] { "剪贴板", "clipboard", "写入", "复制", "copy" };

	[CompilerGenerated]
	private readonly string uRct3dDNQsA = $"fa:{EFontAwesomeIcon.Light_NotesMedical}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> LeEt3o5i8hQ = new StepRunnerCategory[2]
	{
		StepRunnerCategory.Text,
		StepRunnerCategory.Image
	};

	[CompilerGenerated]
	private readonly string Kfct3TEoKwE = "https://getquicker.net/KC/Help/Doc/writeClipboard";

	[CompilerGenerated]
	private readonly bool McCt3Mm2Tvl;

	private static readonly StepInParamDef kE4t3ArHiD8;

	private static readonly StepInParamDef i9mt3OZBcpZ;

	private static readonly StepInParamDef iTdt3FP6JcU;

	private static readonly StepInParamDef Pf4t3U9QAqf;

	private static readonly StepInParamDef mVKt3lvlG4I;

	private static readonly StepInParamDef KW2t3io70qa;

	private static readonly StepInParamDef ScEt33qiPZe;

	private static readonly StepInParamDef yMqt3fw75sG;

	private static readonly StepInParamDef mddt3zKfyAv;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> oGntfwjbwOv = new StepInParamDef[9] { kE4t3ArHiD8, i9mt3OZBcpZ, iTdt3FP6JcU, Pf4t3U9QAqf, mVKt3lvlG4I, KW2t3io70qa, ScEt33qiPZe, yMqt3fw75sG, mddt3zKfyAv };

	private static readonly StepOutParamDef DA5tftLFL8w;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> RZLtfghEWjU = new List<StepOutParamDef> { DA5tftLFL8w };

	internal static WriteClipboardStep VH9DwnQY2490hCwolxsk;

	public string Key => "sys:writeClipboard";

	public string Name => CommonStrings.WriteClipboardStep_Name;

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return c9Qt3DBkMKh;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return uRct3dDNQsA;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Clipboard;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return LeEt3o5i8hQ;
		}
	}

	public string Description => CommonStrings.WriteClipboardStep_Description;

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return Kfct3TEoKwE;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return McCt3Mm2Tvl;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return oGntfwjbwOv;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return RZLtfghEWjU;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass53_0 _003C_003Ec__DisplayClass53_ = new _003C_003Ec__DisplayClass53_0();
		_003C_003Ec__DisplayClass53_.pbWSgkiP5qU = step;
		_003C_003Ec__DisplayClass53_.mAXSgGw0fpe = context;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass53_.mAXSgGw0fpe, _003C_003Ec__DisplayClass53_.pbWSgkiP5qU, action, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass53_.IXHSgWTgqhq, (Action)null, (Action)null, mddt3zKfyAv, DA5tftLFL8w);
	}

	public string GetSummary(ActionStep step)
	{
		return string.Format(CultureInfo.InvariantCulture, CommonStrings.WriteClipboardStep_GetSummary_FormatStr, XActionHelper.GetParamDirectValue(kE4t3ArHiD8, step));
	}

	public static void ClearWindowsClipboardHistory()
	{
		if (NativeMethods.IsOnWindows10OrLater())
		{
			Windows.ApplicationModel.DataTransfer.Clipboard.ClearHistory();
		}
	}

	static WriteClipboardStep()
	{
		kE4t3ArHiD8 = new StepInParamDef
		{
			Key = "type",
			Name = CommonStrings.WriteClipboardStep_TypeParam_Name,
			Description = CommonStrings.WriteClipboardStep_TypeParam_Desc,
			IsRequired = true,
			Type = VarType.Enum,
			DefaultValue = "auto",
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("auto", CommonStrings.WriteClipboardStep_Type_Auto_Name),
				new SelectionItem("html", CommonStrings.WriteClipboardStep_Type_Html_Name),
				new SelectionItem("text", CommonStrings.WriteClipboardStep_Type_Text_Name),
				new SelectionItem("image", CommonStrings.WriteClipboardStep_Type_Image_Name),
				new SelectionItem("rtf", CommonStrings.WriteClipboardStep_Type_Rtf_Name),
				new SelectionItem("csv", CommonStrings.WriteClipboardStep_Type_Csv_Name),
				new SelectionItem("custom", "自定义格式"),
				new SelectionItem("clear", CommonStrings.WriteClipboardStep_Type_Clear_Name),
				new SelectionItem("clearHistory", "清空剪贴板历史(Win10+)")
			},
			IsControlField = true
		};
		i9mt3OZBcpZ = new StepInParamDef
		{
			Key = "customFormat",
			Name = "格式名",
			Description = "自定义的剪贴板格式名",
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new string[1] { "custom" }
		};
		iTdt3FP6JcU = new StepInParamDef
		{
			Key = "input",
			Name = CommonStrings.WriteClipboardStep__inputParam_Name,
			Description = CommonStrings.WriteClipboardStep__inputParam_Desc,
			Type = VarType.Any,
			IsRequired = true,
			IsMultiLine = true,
			VariableMode = ParamVariableMode.UseVar,
			ValidForList = new string[1] { "auto" }
		};
		Pf4t3U9QAqf = new StepInParamDef
		{
			Key = "html",
			Name = CommonStrings.WriteClipboardStep__htmlParam_Name,
			Description = CommonStrings.WriteClipboardStep__htmlParam_Desc,
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[1] { "html" },
			IsMultiLine = true
		};
		mVKt3lvlG4I = new StepInParamDef
		{
			Key = "text",
			Name = CommonStrings.WriteClipboardStep__textParam_Name,
			Description = CommonStrings.WriteClipboardStep__textParam_Desc,
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[5] { "html", "text", "rtf", "csv", "custom" },
			IsMultiLine = true
		};
		KW2t3io70qa = new StepInParamDef
		{
			Key = "imageVar",
			Name = CommonStrings.WriteClipboardStep__imgVarParam_Name,
			Description = CommonStrings.WriteClipboardStep__imgVarParam_Desc,
			Type = VarType.Image,
			IsRequired = false,
			VariableMode = ParamVariableMode.UseVar,
			ValidForList = new string[1] { "image" },
			IsMultiLine = false
		};
		ScEt33qiPZe = new StepInParamDef
		{
			Key = "fastMode",
			Name = "快速模式",
			DefaultValue = false,
			Description = "不需要处理图片中的透明通道时选择",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new string[1] { "image" }
		};
		yMqt3fw75sG = new StepInParamDef
		{
			Key = "successMsg",
			Name = "成功后提示",
			Description = "可选。写入成功后提示消息，如“XXX已写入剪贴板”。",
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.Input,
			IsMultiLine = true
		};
		mddt3zKfyAv = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		DA5tftLFL8w = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
	}

	internal static bool nUV6D4QYA3gPBQNDex9B()
	{
		return VH9DwnQY2490hCwolxsk == null;
	}
}
