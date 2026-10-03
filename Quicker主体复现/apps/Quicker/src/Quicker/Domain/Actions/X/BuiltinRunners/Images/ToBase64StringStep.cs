using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using FontAwesome5;
using MimeTypes;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Images;

public class ToBase64StringStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass42_0
	{
		public ActionStep OgpSqdFsCVA;

		public ActionExecuteContext mfvSqoTiyvl;

		public XAction OwtSqTxYgx9;

		private static _003C_003Ec__DisplayClass42_0 E8KDJuWa84YUKL1GqwuF;

		internal (bool isSuccess, string message, ActionStopFlag failReason) t4ESqD8FAOC()
		{
			string textParamValue = XActionHelper.GetTextParamValue(cmRg75F49p2, OgpSqdFsCVA, mfvSqoTiyvl);
			if (!string.IsNullOrEmpty(textParamValue) && !(textParamValue == "imgToBase64"))
			{
				if (!(textParamValue == "base64ToImg"))
				{
					return (isSuccess: false, message: "不支持的操作类型：" + textParamValue, failReason: ActionStopFlag.OperationFailed);
				}
				MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(Xj1g7pIqZBx(XActionHelper.GetTextParamValue(wp1g7domTG5, OgpSqdFsCVA, mfvSqoTiyvl))));
				Bitmap result = new Bitmap(Image.FromStream(memoryStream));
				memoryStream.Close();
				XActionHelper.OutputResult(Soxg7Ahu3vD, OgpSqdFsCVA, mfvSqoTiyvl, result, OwtSqTxYgx9);
			}
			else
			{
				bool booleanParamValue = XActionHelper.GetBooleanParamValue(oSgg7oh6Iag, OgpSqdFsCVA, mfvSqoTiyvl);
				string text = "";
				if (XActionHelper.GetParamValue(QGug7DTC3GK, OgpSqdFsCVA, mfvSqoTiyvl, false, true) is string text2 && System.IO.File.Exists(text2))
				{
					if (booleanParamValue)
					{
						text = "data:" + MimeTypeMap.GetMimeType(text2) + ";base64,";
					}
					byte[] inArray = System.IO.File.ReadAllBytes(text2);
					string result2 = text + Convert.ToBase64String(inArray);
					XActionHelper.OutputResult(CuKg7MtGERu, OgpSqdFsCVA, mfvSqoTiyvl, result2, OwtSqTxYgx9);
				}
				else
				{
					string imgFilePath;
					Image imageParamValue = XActionHelper.GetImageParamValue(QGug7DTC3GK, OgpSqdFsCVA, mfvSqoTiyvl, out imgFilePath);
					if (imageParamValue == null)
					{
						return (isSuccess: false, message: "变量不是位图对象。", failReason: ActionStopFlag.OperationFailed);
					}
					using MemoryStream memoryStream2 = new MemoryStream();
					if (imageParamValue.RawFormat.Equals(ImageFormat.Jpeg))
					{
						imageParamValue?.Save(memoryStream2, ImageFormat.Jpeg);
						if (booleanParamValue)
						{
							text = "data:image/jpeg;base64,";
						}
					}
					else
					{
						imageParamValue?.Save(memoryStream2, ImageFormat.Png);
						if (booleanParamValue)
						{
							text = "data:image/png;base64,";
						}
					}
					string result3 = text + Convert.ToBase64String(memoryStream2.ToArray());
					XActionHelper.OutputResult(CuKg7MtGERu, OgpSqdFsCVA, mfvSqoTiyvl, result3, OwtSqTxYgx9);
				}
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static void YD69cpWaP2j7v77Bsnid()
		{
		}

		internal static bool uO2IukWaR4YaGYFXfBhE()
		{
			return E8KDJuWa84YUKL1GqwuF == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass44_0
	{
		public ImageFormat qbTSqAfrOsn;

		internal static _003C_003Ec__DisplayClass44_0 YmVQm0WaMDR9fLw3DUVA;

		internal bool WUySqM14m5P(ImageCodecInfo codec)
		{
			return codec.FormatID == qbTSqAfrOsn.Guid;
		}

		internal static bool b0DmraWaUE977g4XfrnH()
		{
			return YmVQm0WaMDR9fLw3DUVA == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> aytg7BwyCKT = new string[3] { "Image", "Bitmap", "Base64" };

	[CompilerGenerated]
	private readonly string iZXg7Q2f09Z = $"fa:{EFontAwesomeIcon.Light_Image}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> ClIg7jiPsdv;

	[CompilerGenerated]
	private readonly string WDAg7nhyY9h = "https://getquicker.net/KC/Help/Doc/imgtobase64";

	[CompilerGenerated]
	private readonly bool fK7g74SYf25;

	private static readonly StepInParamDef cmRg75F49p2;

	private static readonly StepInParamDef QGug7DTC3GK;

	private static readonly StepInParamDef wp1g7domTG5;

	private static readonly StepInParamDef oSgg7oh6Iag;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> UgUg7TZTF7e = new StepInParamDef[4] { cmRg75F49p2, QGug7DTC3GK, oSgg7oh6Iag, wp1g7domTG5 };

	private static readonly StepOutParamDef CuKg7MtGERu;

	private static readonly StepOutParamDef Soxg7Ahu3vD;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> HKtg7O2uEk9 = new StepOutParamDef[2] { CuKg7MtGERu, Soxg7Ahu3vD };

	private static ToBase64StringStep qhf6pvQ6BsEHsuM7ifCo;

	public string Key => "sys:imgToBase64";

	public string Name => "图片/Base64 转换";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return aytg7BwyCKT;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return iZXg7Q2f09Z;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Image;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return ClIg7jiPsdv;
		}
	}

	public string Description => "图片和Base64转换";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return WDAg7nhyY9h;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return fK7g74SYf25;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return UgUg7TZTF7e;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return HKtg7O2uEk9;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass42_0 _003C_003Ec__DisplayClass42_ = new _003C_003Ec__DisplayClass42_0();
		_003C_003Ec__DisplayClass42_.OgpSqdFsCVA = step;
		_003C_003Ec__DisplayClass42_.mfvSqoTiyvl = context;
		_003C_003Ec__DisplayClass42_.OwtSqTxYgx9 = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass42_.mfvSqoTiyvl, _003C_003Ec__DisplayClass42_.OgpSqdFsCVA, _003C_003Ec__DisplayClass42_.OwtSqTxYgx9, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass42_.t4ESqD8FAOC, (Action)null, (Action)null, (StepInParamDef)null, (StepOutParamDef)null);
	}

	public static string GetMimeType(Image image)
	{
		return GetMimeType(image.RawFormat);
	}

	public static string GetMimeType(ImageFormat imageFormat)
	{
		_003C_003Ec__DisplayClass44_0 _003C_003Ec__DisplayClass44_ = new _003C_003Ec__DisplayClass44_0();
		_003C_003Ec__DisplayClass44_.qbTSqAfrOsn = imageFormat;
		return ImageCodecInfo.GetImageDecoders().FirstOrDefault(_003C_003Ec__DisplayClass44_.WUySqM14m5P)?.MimeType;
	}

	internal static string Xj1g7pIqZBx(string string_2)
	{
		string text = "base64,";
		int num = string_2.IndexOf(text);
		if (num < 0)
		{
			return string_2;
		}
		return string_2.Substring(num + text.Length);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDirectValue(cmRg75F49p2, step) ?? "";
	}

	static ToBase64StringStep()
	{
		cmRg75F49p2 = new StepInParamDef
		{
			Key = "type",
			Name = "操作类型",
			DefaultValue = "imgToBase64",
			Description = "转换操作类型",
			VariableMode = ParamVariableMode.Input,
			Type = VarType.Enum,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("imgToBase64", "图片或文件转Base64文本"),
				new SelectionItem("base64ToImg", "Base64文本转图片")
			},
			IsControlField = true
		};
		QGug7DTC3GK = new StepInParamDef
		{
			Key = "img",
			Name = "图片",
			Description = "要转换的图片（图片变量或文件路径）",
			IsRequired = true,
			Type = VarType.Image,
			VariableMode = ParamVariableMode.UseVar,
			ValidForList = new List<string> { "imgToBase64" }
		};
		wp1g7domTG5 = new StepInParamDef
		{
			Key = "base64",
			Name = "Base64编码",
			Description = "要转换的编码文本",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "base64ToImg" }
		};
		oSgg7oh6Iag = new StepInParamDef
		{
			Key = "addHeader",
			Name = "添加data头",
			DefaultValue = false,
			Description = "是否添加“data:image/png;base64,”头",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "imgToBase64" }
		};
		CuKg7MtGERu = new StepOutParamDef
		{
			Key = "code",
			Name = "Base64编码",
			Description = "Base64编码结果",
			Type = VarType.Text,
			ValidForList = new List<string> { "imgToBase64" }
		};
		Soxg7Ahu3vD = new StepOutParamDef
		{
			Key = "img",
			Name = "图片",
			Description = "转换输出的图片",
			Type = VarType.Image,
			ValidForList = new List<string> { "base64ToImg" }
		};
	}

	internal static bool DolxSyQ6v8OPSEcJU8ay()
	{
		return qhf6pvQ6BsEHsuM7ifCo == null;
	}
}
