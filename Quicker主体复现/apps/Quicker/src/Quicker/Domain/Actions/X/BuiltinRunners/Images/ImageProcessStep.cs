using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using FontAwesome5;
using Quicker.Domain.Actions.X.BuildinRunners.Images;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Utilities.Images;
using Quicker.Utilities.Win32;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Images;

public class ImageProcessStep : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec JF9SRB0bhlE;

		public static Func<string, int> OvXSRQGJYkM;

		private static _003C_003Ec gbjvPwWkCXSe5bgfB0xk;

		static _003C_003Ec()
		{
			JF9SRB0bhlE = new _003C_003Ec();
		}

		internal int diPSRpFQJI8(string x)
		{
			return Convert.ToInt32(x.Trim());
		}

		internal static void PY8Ef2WkhDjXaufpu10C()
		{
		}

		internal static bool HUemSyWk7iFNMOW7uaeD()
		{
			return gbjvPwWkCXSe5bgfB0xk == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass54_0
	{
		public ActionStep fq8SRnJPmVZ;

		public ActionExecuteContext DU1SR4xpfA1;

		public ImageProcessStep zQTSR5r6gi4;

		public XAction QhISRDqcHu6;

		internal static _003C_003Ec__DisplayClass54_0 KXsDkEWkHtSpybUG722A;

		internal (bool isSuccess, string message, ActionStopFlag failReason) qy4SRjmLHlq()
		{
			bool flag = XActionHelper.IsOutputParamSetted(ONngaaLeASL.Key, fq8SRnJPmVZ);
			string imgFilePath;
			object imageParamValue = XActionHelper.GetImageParamValue(vP1ga2JgpFo, fq8SRnJPmVZ, DU1SR4xpfA1, out imgFilePath);
			string textParamValue = XActionHelper.GetTextParamValue(TD7gau7Xx4s, fq8SRnJPmVZ, DU1SR4xpfA1);
			if (!(imageParamValue is Bitmap) && textParamValue != "Filters")
			{
				return (isSuccess: false, message: "变量不是位图对象。", failReason: ActionStopFlag.OperationFailed);
			}
			Bitmap bitmap = imageParamValue as Bitmap;
			Bitmap bitmap2 = null;
			switch (textParamValue)
			{
			case "Clone":
				bitmap2 = zQTSR5r6gi4.oMagawSJfCr(bitmap);
				goto IL_029f;
			case "Rotate":
			{
				int int_ = (int)XActionHelper.GetIntegerParamValue(_rotateTypeParam, fq8SRnJPmVZ, DU1SR4xpfA1);
				zQTSR5r6gi4.v1kg8ziOYbV(bitmap, int_, DU1SR4xpfA1);
				goto IL_029f;
			}
			case "Invert":
				if (!ImageProcessingHelper.Invert(bitmap))
				{
					return (isSuccess: false, message: "转反色图片失败", failReason: ActionStopFlag.OperationFailed);
				}
				goto IL_029f;
			case "Filters":
				bitmap2 = ImageProcessorHelper.ProcessImage(XActionHelper.GetTextParamValue(_filterParams, fq8SRnJPmVZ, DU1SR4xpfA1), bitmap, flag, DU1SR4xpfA1);
				goto IL_029f;
			case "GrayScale":
				if (!ImageProcessingHelper.GrayScale(bitmap))
				{
					return (isSuccess: false, message: "转灰度图片失败", failReason: ActionStopFlag.OperationFailed);
				}
				goto IL_029f;
			case "GenerateIco":
				return zQTSR5r6gi4.w4Pg8fEJqNp(bitmap, fq8SRnJPmVZ, DU1SR4xpfA1);
			case "resize_pixel":
			{
				int maxWidth = (int)XActionHelper.GetIntegerParamValue(jAogaJldr63, fq8SRnJPmVZ, DU1SR4xpfA1);
				int maxHeight = (int)XActionHelper.GetIntegerParamValue(UQcga0SwMfj, fq8SRnJPmVZ, DU1SR4xpfA1);
				bitmap2 = ImageProcessingHelper.ResizeByMaxWidthOrHeight(bitmap, maxWidth, maxHeight);
				goto IL_029f;
			}
			case "resize_percent":
			{
				double num = Convert.ToDouble(XActionHelper.GetNumberParamValue(Sr4gaNMpqd1, fq8SRnJPmVZ, DU1SR4xpfA1));
				if (num < 1.0)
				{
					return (isSuccess: false, message: $"缩放比例({num})不正确！", failReason: ActionStopFlag.OperationFailed);
				}
				bitmap2 = ImageProcessingHelper.ResizeByPercent(bitmap, num / 100.0);
				goto IL_029f;
			}
			default:
				{
					return (isSuccess: false, message: "不支持的操作类型：" + textParamValue, failReason: ActionStopFlag.OperationFailed);
				}
				IL_029f:
				if (bitmap2 != null)
				{
					XActionHelper.OutputResult(ONngaaLeASL, fq8SRnJPmVZ, DU1SR4xpfA1, bitmap2, QhISRDqcHu6);
				}
				else if (flag)
				{
					return (isSuccess: false, message: "未生成位图结果", failReason: ActionStopFlag.OperationFailed);
				}
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
		}

		internal static bool BVEUxaWkzq9fAmEymDCD()
		{
			return KXsDkEWkHtSpybUG722A == null;
		}
	}

	private readonly IList<string> t48gatF3kKt = new List<string>();

	[CompilerGenerated]
	private readonly string klPgagbZCPc = $"fa:{EFontAwesomeIcon.Light_Images}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> SZwgaL8PW4k;

	[CompilerGenerated]
	private readonly string GQxgavBRDnV = "https://getquicker.net/KC/Help/Doc/imgprocess";

	[CompilerGenerated]
	private readonly bool rMtgaSmikjp;

	private static readonly StepInParamDef vP1ga2JgpFo;

	private static readonly StepInParamDef TD7gau7Xx4s;

	private static readonly StepInParamDef Sr4gaNMpqd1;

	private static readonly StepInParamDef jAogaJldr63;

	private static readonly StepInParamDef UQcga0SwMfj;

	public static readonly StepInParamDef _rotateTypeParam;

	public static readonly StepInParamDef _filterParams;

	private static readonly StepInParamDef RFdgaClrc84;

	private static readonly StepInParamDef qM1gaPDEFFJ;

	private static readonly StepInParamDef riagaEjwETu;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> nAAgayPdnFE = new StepInParamDef[10] { vP1ga2JgpFo, TD7gau7Xx4s, Sr4gaNMpqd1, jAogaJldr63, UQcga0SwMfj, _rotateTypeParam, _filterParams, RFdgaClrc84, qM1gaPDEFFJ, riagaEjwETu };

	private static readonly StepOutParamDef bIUga8EBYHm;

	private static readonly StepOutParamDef ONngaaLeASL;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> A1Vga7eD3CO = new StepOutParamDef[2] { bIUga8EBYHm, ONngaaLeASL };

	internal static ImageProcessStep N5Vnl6QIuLx1FREEjN2d;

	public string Key => "sys:imgProcess";

	public string Name => "图片处理";

	public IEnumerable<string> KeyWords => t48gatF3kKt;

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return klPgagbZCPc;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Image;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return SZwgaL8PW4k;
		}
	}

	public string Description => "图片处理和变换";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return GQxgavBRDnV;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return rMtgaSmikjp;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return nAAgayPdnFE;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return A1Vga7eD3CO;
		}
	}

	public ImageProcessStep()
	{
		foreach (SelectionItem selectionItem in TD7gau7Xx4s.SelectionItems)
		{
			t48gatF3kKt.Add(selectionItem.Name);
			t48gatF3kKt.Add(selectionItem.Value);
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass54_0 _003C_003Ec__DisplayClass54_ = new _003C_003Ec__DisplayClass54_0();
		_003C_003Ec__DisplayClass54_.fq8SRnJPmVZ = step;
		_003C_003Ec__DisplayClass54_.DU1SR4xpfA1 = context;
		_003C_003Ec__DisplayClass54_.zQTSR5r6gi4 = this;
		_003C_003Ec__DisplayClass54_.QhISRDqcHu6 = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass54_.DU1SR4xpfA1, _003C_003Ec__DisplayClass54_.fq8SRnJPmVZ, _003C_003Ec__DisplayClass54_.QhISRDqcHu6, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass54_.qy4SRjmLHlq, (Action)null, (Action)null, riagaEjwETu, bIUga8EBYHm);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) w4Pg8fEJqNp(Bitmap bitmap_0, ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0)
	{
		string textParamValue = XActionHelper.GetTextParamValue(RFdgaClrc84, actionStep_0, actionExecuteContext_0);
		if (string.IsNullOrEmpty(textParamValue))
		{
			return (isSuccess: false, message: "文件路径不能为空", failReason: ActionStopFlag.OperationFailed);
		}
		if (Directory.Exists(textParamValue))
		{
			return (isSuccess: false, message: "文件路径不能是文件夹", failReason: ActionStopFlag.OperationFailed);
		}
		FileSystemHelper.EnsureFileFolderExists(textParamValue);
		List<int> sizes = XActionHelper.GetTextParamValue(qM1gaPDEFFJ, actionStep_0, actionExecuteContext_0).SplitToList(',', '，').Select(_003C_003Ec.OvXSRQGJYkM ?? (_003C_003Ec.OvXSRQGJYkM = _003C_003Ec.JF9SRB0bhlE.diPSRpFQJI8))
			.ToList();
		if (!ImageHelper.ConvertToIcon(bitmap_0, textParamValue, sizes))
		{
			return (isSuccess: false, message: "生成图标失败", failReason: ActionStopFlag.OperationFailed);
		}
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private void v1kg8ziOYbV(Bitmap bitmap_0, int int_0, ActionExecuteContext actionExecuteContext_0)
	{
		switch (int_0)
		{
		case 0:
			return;
		case 1:
		case 2:
		case 3:
		case 4:
		case 5:
		case 6:
		case 7:
			bitmap_0.RotateFlip((RotateFlipType)int_0);
			return;
		}
		if (int_0 == 99)
		{
			ExifRotate(bitmap_0, actionExecuteContext_0);
		}
	}

	public static void ExifRotate(Image img, ActionExecuteContext context)
	{
		if (!img.PropertyIdList.Contains(274))
		{
			context.ActionLogger.LogWarning("图片中不包含方向数据。");
			return;
		}
		int num = BitConverter.ToUInt16(img.GetPropertyItem(274).Value, 0);
		RotateFlipType rotateFlipType = RotateFlipType.RotateNoneFlipNone;
		int num2 = 0;
		if (!VvbVYjQIoFsQxJt7a7mR())
		{
			goto IL_007c;
		}
		goto IL_0080;
		IL_0080:
		do
		{
			switch (num2)
			{
			default:
				if (num != 3 && num != 4)
				{
					if (num != 5 && num != 6)
					{
						if (num != 7)
						{
							if (num != 8)
							{
								break;
							}
							goto IL_006f;
						}
						goto case 1;
					}
					rotateFlipType = RotateFlipType.Rotate90FlipNone;
					break;
				}
				rotateFlipType = RotateFlipType.Rotate180FlipNone;
				break;
			case 1:
				rotateFlipType = RotateFlipType.Rotate270FlipNone;
				break;
			}
			if (num == 2 || num == 4 || num == 5 || num == 7)
			{
				rotateFlipType |= RotateFlipType.RotateNoneFlipX;
			}
			if (rotateFlipType != RotateFlipType.RotateNoneFlipNone)
			{
				img.RotateFlip(rotateFlipType);
			}
			return;
			IL_006f:
			num2 = 1;
		}
		while (N5Vnl6QIuLx1FREEjN2d == null);
		goto IL_007c;
		IL_007c:
		int num3 = default(int);
		num2 = num3;
		goto IL_0080;
	}

	private Bitmap oMagawSJfCr(Bitmap bitmap_0)
	{
		Rectangle rect = new Rectangle(0, 0, bitmap_0.Width, bitmap_0.Height);
		PixelFormat pixelFormat = bitmap_0.PixelFormat;
		return bitmap_0.Clone(rect, pixelFormat);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDirectValue(TD7gau7Xx4s, step) ?? "";
	}

	static ImageProcessStep()
	{
		vP1ga2JgpFo = new StepInParamDef
		{
			Key = "img",
			Name = "图片",
			Description = "要转换的图片",
			IsRequired = true,
			Type = VarType.Image,
			VariableMode = ParamVariableMode.UseVar
		};
		TD7gau7Xx4s = new StepInParamDef
		{
			Key = "type",
			Name = "操作类型",
			DefaultValue = "resize_percent",
			Description = "对图片的转换操作类型",
			VariableMode = ParamVariableMode.Input,
			Type = VarType.Enum,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("resize_percent", "缩放图片(指定比例)"),
				new SelectionItem("resize_pixel", "缩小图片(指定像素)"),
				new SelectionItem("Clone", "复制图片"),
				new SelectionItem("Invert", "反色"),
				new SelectionItem("GrayScale", "灰度"),
				new SelectionItem("Rotate", "旋转"),
				new SelectionItem("Filters", "组合处理"),
				new SelectionItem("GenerateIco", "生成图标文件(.ico)")
			},
			IsControlField = true
		};
		Sr4gaNMpqd1 = new StepInParamDef
		{
			Key = "resizePercent",
			Name = "缩放比例",
			Description = "缩小或放大到原来的百分之多少",
			Type = VarType.Number,
			DefaultValue = 50,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "resize_percent" }
		};
		jAogaJldr63 = new StepInParamDef
		{
			Key = "maxWidth",
			Name = "最大宽度",
			Description = "最大宽度(像素数)，0表示自动",
			Type = VarType.Integer,
			DefaultValue = 0,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "resize_pixel" }
		};
		UQcga0SwMfj = new StepInParamDef
		{
			Key = "maxHeight",
			Name = "最大高度",
			Description = "最大高度(像素数)，0表示自动",
			Type = VarType.Integer,
			DefaultValue = 0,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "resize_pixel" }
		};
		_rotateTypeParam = new StepInParamDef
		{
			Key = "rotation",
			Name = "旋转方式",
			Description = "顺时针角度。0:不旋转, 1:90°, 2:180°, 3:270°, 其他值请参考模块文档。",
			Type = VarType.Integer,
			DefaultValue = 0,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "Rotate" }
		};
		_filterParams = new StepInParamDef
		{
			Key = "filterParams",
			Name = "处理参数",
			Description = "每行设定一个处理步骤，具体设置请参考文档",
			Type = VarType.Text,
			IsMultiLine = true,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "Filters" }
		};
		RFdgaClrc84 = new StepInParamDef
		{
			Key = "iconFilePath",
			Name = "图标文件保存路径",
			Description = "保存图标文件(.ico)的完整路径",
			Type = VarType.Text,
			IsMultiLine = false,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "GenerateIco" }
		};
		qM1gaPDEFFJ = new StepInParamDef
		{
			Key = "iconSize",
			Name = "图标大小",
			Description = "图标中的位图大小，单位为像素。多尺寸图标可用英文逗号风格",
			DefaultValue = "256,48,32,16",
			Type = VarType.Text,
			IsMultiLine = false,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "GenerateIco" }
		};
		riagaEjwETu = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		bIUga8EBYHm = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		ONngaaLeASL = new StepOutParamDef
		{
			Key = "result",
			Name = "结果图片",
			Description = "处理后的图片",
			Type = VarType.Image,
			ValidForList = new List<string> { "Clone", "resize_percent", "resize_pixel", "Filters" }
		};
	}

	internal static void boKETeQIbB5NX9sgeZ2l()
	{
	}

	internal static bool VvbVYjQIoFsQxJt7a7mR()
	{
		return N5Vnl6QIuLx1FREEjN2d == null;
	}
}
