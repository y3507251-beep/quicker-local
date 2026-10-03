using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using FontAwesome5;
using log4net;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Utilities.Images;
using Quicker.Utilities.Win32;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Images;

public class WriteImageFileStep : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec vdkSq6yiTCP;

		public static Func<ImageCodecInfo, bool> sVnSqXIaFHn;

		internal static _003C_003Ec qYaTrjWaamNHaw7I2erb;

		static _003C_003Ec()
		{
			vdkSq6yiTCP = new _003C_003Ec();
		}

		internal bool tKhSqbijgIc(ImageCodecInfo codec)
		{
			return codec.FormatID == ImageFormat.Jpeg.Guid;
		}

		internal static bool S8EbJaWaraDmOSkLG358()
		{
			return qYaTrjWaamNHaw7I2erb == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass40_0
	{
		public ActionStep eRiSqKcLQNN;

		public ActionExecuteContext li4SqxXMcjy;

		private static _003C_003Ec__DisplayClass40_0 oUxgTdWau5fUGPRCk4Yp;

		internal (bool isSuccess, string message, ActionStopFlag failReason) VZVSqmKpA5B()
		{
			object paramValue = XActionHelper.GetParamValue(RlPg7Eny4tl, eRiSqKcLQNN, li4SqxXMcjy);
			string textParamValue = XActionHelper.GetTextParamValue(ORLg7yR3UCu, eRiSqKcLQNN, li4SqxXMcjy);
			long integerParamValue = XActionHelper.GetIntegerParamValue(YFrg780a9Hx, eRiSqKcLQNN, li4SqxXMcjy);
			if (string.IsNullOrEmpty(textParamValue))
			{
				return (isSuccess: false, message: "要写入的文件路径为空，请检查配置。", failReason: ActionStopFlag.OperationFailed);
			}
			textParamValue = PathHelper.RemoveZeroWidthChar(textParamValue);
			(bool, char) tuple = PathHelper.ValidatePath(textParamValue);
			if (!tuple.Item1)
			{
				return (isSuccess: false, message: $"路径含有非法字符：{tuple.Item2}", failReason: ActionStopFlag.OperationFailed);
			}
			if (!(paramValue is Image))
			{
				return (isSuccess: false, message: "输入的内容不是图片，无法写入文件。", failReason: ActionStopFlag.OperationFailed);
			}
			if (Directory.Exists(textParamValue))
			{
				return (isSuccess: false, message: "输入的文件路径是一个目录，无法写入文件。", failReason: ActionStopFlag.OperationFailed);
			}
			try
			{
				FileSystemHelper.EnsureFileFolderExists(textParamValue);
				Image image = paramValue as Image;
				ImageFormat imageFormatByFileExt = ImageHelper.GetImageFormatByFileExt(textParamValue);
				if (imageFormatByFileExt.Equals(ImageFormat.Jpeg))
				{
					using EncoderParameters encoderParameters = new EncoderParameters(1);
					using EncoderParameter encoderParameter = new EncoderParameter(Encoder.Quality, integerParamValue);
					ImageCodecInfo encoder = ImageCodecInfo.GetImageDecoders().First(_003C_003Ec.sVnSqXIaFHn ?? (_003C_003Ec.sVnSqXIaFHn = _003C_003Ec.vdkSq6yiTCP.tKhSqbijgIc));
					encoderParameters.Param[0] = encoderParameter;
					image.Save(textParamValue, encoder, encoderParameters);
				}
				else
				{
					image.Save(textParamValue, imageFormatByFileExt);
				}
			}
			catch (Exception ex)
			{
				string item = "写入文件（" + textParamValue + "）出错，可能未指定完整的文件名：" + ex.Message;
				return (isSuccess: false, message: item, failReason: ActionStopFlag.OperationFailed);
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool QF5l5CWaotuc7FWHXBlT()
		{
			return oUxgTdWau5fUGPRCk4Yp == null;
		}
	}

	private static readonly ILog uG8g7uRX4ix;

	[CompilerGenerated]
	private readonly IEnumerable<string> ADDg7ND8vWv = new string[3] { "文件", "Image", "Bitmap" };

	[CompilerGenerated]
	private readonly string rLNg7JfQd1E = $"fa:{EFontAwesomeIcon.Light_FileImage}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> uhMg704L14t = new StepRunnerCategory[1] { StepRunnerCategory.Image };

	[CompilerGenerated]
	private readonly string e6hg7C8UKhD = "https://getquicker.net/KC/Help/Doc/writeimagefile";

	[CompilerGenerated]
	private readonly bool I2Jg7PtbAon;

	private static readonly StepInParamDef RlPg7Eny4tl;

	private static readonly StepInParamDef ORLg7yR3UCu;

	private static readonly StepInParamDef YFrg780a9Hx;

	private static readonly StepInParamDef tdag7aY9blX;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> iByg774EYwa = new StepInParamDef[4] { RlPg7Eny4tl, ORLg7yR3UCu, YFrg780a9Hx, tdag7aY9blX };

	private static readonly StepOutParamDef I2kg7RGh0rC;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> Spvg7qoDI3V = new List<StepOutParamDef> { I2kg7RGh0rC };

	private static WriteImageFileStep rKBVopQ6c8hJq4cJFkV3;

	public string Key => "sys:WriteImageFile";

	public string Name => "写入图片文件";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return ADDg7ND8vWv;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return rLNg7JfQd1E;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Files;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return uhMg704L14t;
		}
	}

	public string Description => "将图片内容写入文件";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return e6hg7C8UKhD;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return I2Jg7PtbAon;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return iByg774EYwa;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return Spvg7qoDI3V;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass40_0 _003C_003Ec__DisplayClass40_ = new _003C_003Ec__DisplayClass40_0();
		_003C_003Ec__DisplayClass40_.eRiSqKcLQNN = step;
		_003C_003Ec__DisplayClass40_.li4SqxXMcjy = context;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass40_.li4SqxXMcjy, _003C_003Ec__DisplayClass40_.eRiSqKcLQNN, action, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass40_.VZVSqmKpA5B, (Action)null, (Action)null, tdag7aY9blX, I2kg7RGh0rC);
	}

	public string GetSummary(ActionStep step)
	{
		return "写入文件：" + XActionHelper.GetParamDisplayString(ORLg7yR3UCu, step);
	}

	static WriteImageFileStep()
	{
		uG8g7uRX4ix = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		RlPg7Eny4tl = new StepInParamDef
		{
			Key = "content",
			Name = "图片",
			Description = "要写入文件的图片（变量）",
			DefaultValue = "",
			IsRequired = true,
			Type = VarType.Image,
			VariableMode = ParamVariableMode.UseVar
		};
		ORLg7yR3UCu = new StepInParamDef
		{
			Key = "filePath",
			Name = "文件路径",
			Description = "要写入的文件完整路径（包含文件名）",
			DefaultValue = "",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		YFrg780a9Hx = new StepInParamDef
		{
			Key = "quality",
			Name = "图片质量",
			Description = "保存为JPG格式时的图片质量参数。范围10-100。",
			DefaultValue = 95,
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		tdag7aY9blX = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		I2kg7RGh0rC = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
	}

	internal static bool UgIykGQ6WDeUckiNOYs3()
	{
		return rKBVopQ6c8hJq4cJFkV3 == null;
	}

	internal static void nDolGjQ6pArGmYTNTg9Z()
	{
	}
}
