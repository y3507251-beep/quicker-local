using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using FontAwesome5;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Utilities.Images;
using Quicker.Utilities.Win32;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Images;

public class GetImageInfoStep : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec wW4SRYyfGM2;

		public static Func<ExifStuff.ExifPropertyData, string> SDNSRIPAk4c;

		public static Func<ExifStuff.ExifPropertyData, string> xA3SRWNq5Y5;

		public static Func<PropertyItem, string> Jc2SRk2HwYG;

		public static Func<PropertyItem, PropertyItem> mrDSRGHkWsZ;

		internal static _003C_003Ec A1g9AFWkPP7TBBpspLxv;

		static _003C_003Ec()
		{
			wW4SRYyfGM2 = new _003C_003Ec();
		}

		internal string gLxSRZgnMFj(ExifStuff.ExifPropertyData x)
		{
			return x.PropertyType.ToString();
		}

		internal string LkJSR9BtAuT(ExifStuff.ExifPropertyData x)
		{
			return x.DataString;
		}

		internal string Ru2SRhL8yCo(PropertyItem x)
		{
			return x.Id.ToString();
		}

		internal PropertyItem x1CSRe9yMsZ(PropertyItem x)
		{
			return x;
		}

		internal static bool YJcwLXWkMALkFILxSxI3()
		{
			return A1g9AFWkPP7TBBpspLxv == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass49_0
	{
		public ActionStep rRqSRHB82wx;

		public ActionExecuteContext HFASR13jCqR;

		public XAction TpoSRbVRndw;

		internal static _003C_003Ec__DisplayClass49_0 av4m1sWkxyMgIl9AulmC;

		internal (bool isSuccess, string message, ActionStopFlag failReason) KpUSRsfKVcX()
		{
			_003C_003Ec__DisplayClass49_1 _003C_003Ec__DisplayClass49_ = new _003C_003Ec__DisplayClass49_1
			{
				hnESRX4paPA = null
			};
			string textParamValue = XActionHelper.GetTextParamValue(CxVg8kDEyRS, rRqSRHB82wx, HFASR13jCqR);
			Image image;
			if (textParamValue == "var")
			{
				string imgFilePath;
				object imageParamValue = XActionHelper.GetImageParamValue(zCKg8sxnVxv, rRqSRHB82wx, HFASR13jCqR, out imgFilePath);
				if (imageParamValue == null)
				{
					return (isSuccess: false, message: "图片变量不是Image对象", failReason: ActionStopFlag.OperationFailed);
				}
				image = (Image)imageParamValue;
			}
			else
			{
				_003C_003Ec__DisplayClass49_.hnESRX4paPA = XActionHelper.GetTextParamValue(AjNg8Gss1cc, rRqSRHB82wx, HFASR13jCqR);
				_003C_003Ec__DisplayClass49_.hnESRX4paPA = PathHelper.RemoveZeroWidthChar(_003C_003Ec__DisplayClass49_.hnESRX4paPA);
				if (!System.IO.File.Exists(_003C_003Ec__DisplayClass49_.hnESRX4paPA))
				{
					return (isSuccess: false, message: "图片文件不存在：" + _003C_003Ec__DisplayClass49_.hnESRX4paPA, failReason: ActionStopFlag.OperationFailed);
				}
				image = ImageHelper.ReadImageFromFileWithoutLock(_003C_003Ec__DisplayClass49_.hnESRX4paPA);
			}
			if (image == null)
			{
				return (isSuccess: false, message: "图片对象为空", failReason: ActionStopFlag.OperationFailed);
			}
			bool booleanParamValue = XActionHelper.GetBooleanParamValue(Bkmg8HclFr0, rRqSRHB82wx, HFASR13jCqR);
			bool flag = false;
			int num = 0;
			PropertyItem propertyItem = null;
			int[] propertyIdList = image.PropertyIdList;
			if (propertyIdList != null && propertyIdList.Contains(274))
			{
				propertyItem = image.GetPropertyItem(274);
			}
			if (propertyItem != null)
			{
				int num2 = propertyItem.Value[0];
				if (booleanParamValue && (num2 == 6 || num2 == 8))
				{
					flag = true;
				}
				num = GetRotationAngle(num2);
			}
			XActionHelper.OutputResult(UCgg8mUYvOf, rRqSRHB82wx, HFASR13jCqR, num, TpoSRbVRndw);
			if (flag)
			{
				XActionHelper.OutputResult(xweg861qfHI, rRqSRHB82wx, HFASR13jCqR, image.Height, TpoSRbVRndw);
				XActionHelper.OutputResult(avLg8X51lFR, rRqSRHB82wx, HFASR13jCqR, image.Width, TpoSRbVRndw);
			}
			else
			{
				XActionHelper.OutputResult(xweg861qfHI, rRqSRHB82wx, HFASR13jCqR, image.Width, TpoSRbVRndw);
				XActionHelper.OutputResult(avLg8X51lFR, rRqSRHB82wx, HFASR13jCqR, image.Height, TpoSRbVRndw);
			}
			if (XActionHelper.IsOutputParamSetted(SyIg8xXXgaC.Key, rRqSRHB82wx))
			{
				Dictionary<string, string> result = ExifStuff.GetExifProperties(image).ToDictionary(_003C_003Ec.SDNSRIPAk4c ?? (_003C_003Ec.SDNSRIPAk4c = _003C_003Ec.wW4SRYyfGM2.gLxSRZgnMFj), _003C_003Ec.xA3SRWNq5Y5 ?? (_003C_003Ec.xA3SRWNq5Y5 = _003C_003Ec.wW4SRYyfGM2.LkJSR9BtAuT));
				XActionHelper.OutputResult(SyIg8xXXgaC, rRqSRHB82wx, HFASR13jCqR, result, TpoSRbVRndw);
			}
			if (XActionHelper.IsOutputParamSetted(aIVg8rL7oAc.Key, rRqSRHB82wx))
			{
				Dictionary<string, PropertyItem> result2 = image.PropertyItems.ToDictionary(_003C_003Ec.Jc2SRk2HwYG ?? (_003C_003Ec.Jc2SRk2HwYG = _003C_003Ec.wW4SRYyfGM2.Ru2SRhL8yCo), _003C_003Ec.mrDSRGHkWsZ ?? (_003C_003Ec.mrDSRGHkWsZ = _003C_003Ec.wW4SRYyfGM2.x1CSRe9yMsZ));
				XActionHelper.OutputResult(aIVg8rL7oAc, rRqSRHB82wx, HFASR13jCqR, result2, TpoSRbVRndw);
			}
			if (XActionHelper.IsOutputParamSetted(yRkg8Kkl68F.Key, rRqSRHB82wx))
			{
				try
				{
					PropertyItem propertyItem2 = null;
					if (image.PropertyIdList.Contains(36867))
					{
						propertyItem2 = image.GetPropertyItem(36867);
					}
					else if (image.PropertyIdList.Contains(306))
					{
						propertyItem2 = image.GetPropertyItem(306);
					}
					if (propertyItem2 != null)
					{
						DateTime dateTime = DateTime.ParseExact(Encoding.ASCII.GetString(propertyItem2.Value).Trim(default(char)), "yyyy:MM:dd HH:mm:ss", CultureInfo.InvariantCulture);
						XActionHelper.OutputResult(yRkg8Kkl68F, rRqSRHB82wx, HFASR13jCqR, dateTime, TpoSRbVRndw);
					}
					else if (_003C_003Ec__DisplayClass49_.hnESRX4paPA != null)
					{
						HFASR13jCqR.ActionLogger.LogWarning("照片中不存在拍摄时间信息，使用文件创建时间。");
						DateTime creationTime = new FileInfo(_003C_003Ec__DisplayClass49_.hnESRX4paPA).CreationTime;
						XActionHelper.OutputResult(yRkg8Kkl68F, rRqSRHB82wx, HFASR13jCqR, creationTime, TpoSRbVRndw);
					}
					else
					{
						HFASR13jCqR.ActionLogger.LogWarning("照片中不存在拍摄时间信息。");
						XActionHelper.OutputResult(yRkg8Kkl68F, rRqSRHB82wx, HFASR13jCqR, DateTime.MinValue, TpoSRbVRndw);
					}
				}
				catch (Exception ex)
				{
					HFASR13jCqR.ActionLogger.LogWarning("获取图片的拍摄时间出错。" + ex.Message);
					XActionHelper.OutputResult(yRkg8Kkl68F, rRqSRHB82wx, HFASR13jCqR, DateTime.MinValue, TpoSRbVRndw);
				}
			}
			if (textParamValue == "file")
			{
				XActionHelper.OutputResultIfNeeded(Q6ug8pm61XZ, _003C_003Ec__DisplayClass49_.ByTSR6FYunx, rRqSRHB82wx, HFASR13jCqR, TpoSRbVRndw);
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool sWH3U0WkICPGBphU9DKG()
		{
			return av4m1sWkxyMgIl9AulmC == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass49_1
	{
		public string hnESRX4paPA;

		private static _003C_003Ec__DisplayClass49_1 z1dXDDWktN8BYn6cUKSD;

		internal object ByTSR6FYunx()
		{
			return GetImageFormat(System.IO.File.ReadAllBytes(hnESRX4paPA));
		}

		internal static bool GyGCc1WkSNSrL8FQlddZ()
		{
			return z1dXDDWktN8BYn6cUKSD == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> qcng8eXbQMA;

	[CompilerGenerated]
	private readonly string NwDg8YBKBmW = $"fa:{EFontAwesomeIcon.Light_Image}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> K6Sg8IMQosa;

	[CompilerGenerated]
	private readonly string wLQg8WcXRgR = "https://getquicker.net/KC/Help/Doc/imageinfo";

	private static readonly StepInParamDef CxVg8kDEyRS;

	private static readonly StepInParamDef AjNg8Gss1cc;

	private static readonly StepInParamDef zCKg8sxnVxv;

	private static readonly StepInParamDef Bkmg8HclFr0;

	private static readonly StepInParamDef b3sg81ctWVE;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> slNg8bOwJkJ = new List<StepInParamDef> { CxVg8kDEyRS, AjNg8Gss1cc, zCKg8sxnVxv, Bkmg8HclFr0, b3sg81ctWVE };

	private static readonly StepOutParamDef xweg861qfHI;

	private static readonly StepOutParamDef avLg8X51lFR;

	private static readonly StepOutParamDef UCgg8mUYvOf;

	private static StepOutParamDef yRkg8Kkl68F;

	private static StepOutParamDef SyIg8xXXgaC;

	private static StepOutParamDef aIVg8rL7oAc;

	private static StepOutParamDef Q6ug8pm61XZ;

	private static readonly StepOutParamDef iBcg8Bhiurq;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> XsDg8QSZBib = new List<StepOutParamDef> { iBcg8Bhiurq, xweg861qfHI, avLg8X51lFR, UCgg8mUYvOf, yRkg8Kkl68F, SyIg8xXXgaC, aIVg8rL7oAc, Q6ug8pm61XZ };

	private static GetImageInfoStep XqO8kVQIjv5SR8P2EMjv;

	public string Key => "sys:imageinfo";

	public string Name => "读取图片信息";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return qcng8eXbQMA;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return NwDg8YBKBmW;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Image;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return K6Sg8IMQosa;
		}
	}

	public string Description => "获取图片的尺寸或exif信息";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return wLQg8WcXRgR;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly => false;

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return slNg8bOwJkJ;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return XsDg8QSZBib;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public static int GetRotationAngle(int orientationValue)
	{
		while (true)
		{
			if (orientationValue <= 3)
			{
				if (XqO8kVQIjv5SR8P2EMjv != null)
				{
					switch (0)
					{
					case 1:
						continue;
					}
				}
				switch (orientationValue)
				{
				case 3:
					return 180;
				case 1:
					return 0;
				}
			}
			else
			{
				switch (orientationValue)
				{
				case 8:
					return 270;
				case 6:
					return 90;
				}
			}
			break;
		}
		return 0;
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass49_0 _003C_003Ec__DisplayClass49_ = new _003C_003Ec__DisplayClass49_0();
		_003C_003Ec__DisplayClass49_.rRqSRHB82wx = step;
		_003C_003Ec__DisplayClass49_.HFASR13jCqR = context;
		_003C_003Ec__DisplayClass49_.TpoSRbVRndw = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass49_.HFASR13jCqR, _003C_003Ec__DisplayClass49_.rRqSRHB82wx, _003C_003Ec__DisplayClass49_.TpoSRbVRndw, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass49_.KpUSRsfKVcX, (Action)null, (Action)null, b3sg81ctWVE, iBcg8Bhiurq);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDirectValue(CxVg8kDEyRS, step) ?? "";
	}

	public static string GetImageFormat(byte[] bytes)
	{
		if (bytes[0] == byte.MaxValue && bytes[1] == 216)
		{
			return "JPEG";
		}
		int num;
		if (bytes[0] == 137 && bytes[1] == 80 && bytes[2] == 78)
		{
			num = 2;
			if (cxLqf9QIDJNZG1Ff30cJ())
			{
				goto IL_007b;
			}
			goto IL_00a4;
		}
		goto IL_00aa;
		IL_00d1:
		if (bytes[0] != 77 || bytes[1] != 77)
		{
			if (bytes[0] == 82 && bytes[1] == 73 && bytes[2] == 70 && bytes[3] == 70 && bytes[8] == 87 && bytes[9] == 69 && bytes[10] == 66 && bytes[11] == 80)
			{
				return "WebP";
			}
			if (bytes[0] == 1 && bytes[1] == 0 && bytes[2] == 0 && bytes[3] == 0)
			{
				return "EMF";
			}
			if (bytes[0] == 1 && bytes[1] == 0)
			{
				return "WMF";
			}
			return "Unknown";
		}
		goto IL_00df;
		IL_00aa:
		if (bytes[0] != 71)
		{
			goto IL_0044;
		}
		num = 0;
		if (XqO8kVQIjv5SR8P2EMjv == null)
		{
			goto IL_007b;
		}
		goto IL_00a4;
		IL_00c2:
		if (bytes[1] != 73)
		{
			goto IL_00d1;
		}
		goto IL_00df;
		IL_00df:
		return "TIFF";
		IL_0044:
		if (bytes[0] != 66 || bytes[1] != 77)
		{
			if (bytes[0] == 73)
			{
				num = 1;
				if (cxLqf9QIDJNZG1Ff30cJ())
				{
					goto IL_007b;
				}
				goto IL_00c2;
			}
			goto IL_00d1;
		}
		return "BMP";
		IL_00a4:
		int num2 = default(int);
		num = num2;
		goto IL_007b;
		IL_007b:
		switch (num)
		{
		case 2:
			goto IL_008e;
		case 1:
			goto IL_00c2;
		}
		if (bytes[1] == 73 && bytes[2] == 70)
		{
			return "GIF";
		}
		goto IL_0044;
		IL_008e:
		if (bytes[3] == 71)
		{
			return "PNG";
		}
		goto IL_00aa;
	}

	static GetImageInfoStep()
	{
		CxVg8kDEyRS = new StepInParamDef
		{
			Key = "sourceType",
			Name = "图片来源",
			Description = "",
			Type = VarType.Enum,
			DefaultValue = "var",
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("var", "图片变量"),
				new SelectionItem("file", "图片文件")
			},
			VariableMode = ParamVariableMode.Input,
			IsControlField = true
		};
		AjNg8Gss1cc = new StepInParamDef
		{
			Key = "bmpFile",
			Name = "文件路径",
			Description = "图片文件的完整路径",
			IsRequired = true,
			Type = VarType.Text,
			DefaultValue = "",
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[1] { "file" }
		};
		zCKg8sxnVxv = new StepInParamDef
		{
			Key = "bmpVar",
			Name = "图片变量",
			Description = "",
			IsRequired = true,
			Type = VarType.Image,
			DefaultValue = "",
			VariableMode = ParamVariableMode.UseVar,
			ValidForList = new string[1] { "var" }
		};
		Bkmg8HclFr0 = new StepInParamDef
		{
			Key = "autoRotate",
			Name = "计算旋转后的宽高",
			DefaultValue = false,
			Description = "如果Exif中包含旋转角度信息，则获取旋转后的宽高",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		b3sg81ctWVE = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		xweg861qfHI = new StepOutParamDef
		{
			Key = "width",
			Name = "宽度",
			Type = VarType.Integer
		};
		avLg8X51lFR = new StepOutParamDef
		{
			Key = "height",
			Name = "高度",
			Type = VarType.Integer
		};
		UCgg8mUYvOf = new StepOutParamDef
		{
			Key = "rotateDegree",
			Name = "旋转角度",
			Type = VarType.Integer
		};
		yRkg8Kkl68F = new StepOutParamDef
		{
			Key = "dateTimeOriginal",
			Name = "拍摄时间",
			Type = VarType.DateTime
		};
		SyIg8xXXgaC = new StepOutParamDef
		{
			Key = "exifData",
			Name = "Exif数据",
			Description = "转换为文本格式的exif数据（词典格式，请参考模块文档）",
			Type = VarType.Dict
		};
		aIVg8rL7oAc = new StepOutParamDef
		{
			Key = "rawExifData",
			Name = "原始属性数据",
			Description = "原始Exif数据(词典格式，请参考模块文档)",
			Type = VarType.Dict
		};
		Q6ug8pm61XZ = new StepOutParamDef
		{
			Key = "fileTypeFromData",
			Name = "内容图片格式",
			Description = "根据文件内容判断的文件格式（可能不准确），用于在无法根据扩展名得到图片格式的情况下使用。",
			Type = VarType.Text,
			ValidForList = new string[1] { "file" }
		};
		iBcg8Bhiurq = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
	}

	internal static bool cxLqf9QIDJNZG1Ff30cJ()
	{
		return XqO8kVQIjv5SR8P2EMjv == null;
	}
}
