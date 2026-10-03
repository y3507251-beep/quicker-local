using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Media;
using bcybYUMWiG3W9kCqUoJ;
using FontAwesome5;
using GgthUOMMIWtpmNWHFuM;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Modules.TextTools;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Images;
using Quicker.Utilities.Win32;
using vJ31iUYJvlh2KmJJn6Y;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class SearchBmpStep : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec zssvf01JR2R;

		public static Func<Point, string> xORvfCu4Tia;

		public static Func<Point, string> mmMvfPsSTMK;

		public static Func<Point, string> GRxvfEH9Vaq;

		private static _003C_003Ec x7aF9xWDs0fTJ6MEuS1w;

		static _003C_003Ec()
		{
			zssvf01JR2R = new _003C_003Ec();
		}

		internal string CIQvfuhNCdD(Point x)
		{
			return x.ToValue();
		}

		internal string R5LvfNySEoT(Point x)
		{
			return x.ToValue();
		}

		internal string gUwvfJVdNlv(Point pt)
		{
			return pt.ToValue();
		}

		internal static void xuymNdWD4JOmJlhebfHU()
		{
		}

		internal static bool mDCqOqWDC1BpnNwEVMc6()
		{
			return x7aF9xWDs0fTJ6MEuS1w == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass59_0
	{
		public ActionStep RG3vf89LxlU;

		public ActionExecuteContext CkdvfacdQl5;

		public XAction eNDvf7ObGj9;

		internal static _003C_003Ec__DisplayClass59_0 I9r7tWWDhhP2EWf1hYJQ;

		internal (bool isSuccess, string message, ActionStopFlag failReason) HLmvfy9Xoh7()
		{
			Rectangle rectangle = Rectangle.Empty;
			string textParamValue = XActionHelper.GetTextParamValue(KjotA9XUxgq, RG3vf89LxlU, CkdvfacdQl5);
			int num = (int)XActionHelper.GetIntegerParamValue(ztCtAsSqt8d, RG3vf89LxlU, CkdvfacdQl5);
			int num2 = (int)XActionHelper.GetIntegerParamValue(dEJtAHoYLt5, RG3vf89LxlU, CkdvfacdQl5);
			int num3 = (int)XActionHelper.GetIntegerParamValue(f4atA6BCKRx, RG3vf89LxlU, CkdvfacdQl5);
			if (num3 < 0)
			{
				num3 = 0;
			}
			string textParamValue2 = XActionHelper.GetTextParamValue(mD2tAWZSZvl, RG3vf89LxlU, CkdvfacdQl5);
			maP9bQMwejOq3FEOUur maP9bQMwejOq3FEOUur = (maP9bQMwejOq3FEOUur)Enum.Parse(typeof(maP9bQMwejOq3FEOUur), textParamValue2);
			string textParamValue3 = XActionHelper.GetTextParamValue(WsdtAk8pOa2, RG3vf89LxlU, CkdvfacdQl5);
			int num4 = (int)XActionHelper.GetIntegerParamValue(CaDtA1FUS8F, RG3vf89LxlU, CkdvfacdQl5);
			if (maP9bQMwejOq3FEOUur == maP9bQMwejOq3FEOUur.Rect)
			{
				if (string.IsNullOrEmpty(textParamValue3))
				{
					return (isSuccess: false, message: "找图搜索的坐标范围未指定", failReason: ActionStopFlag.OperationFailed);
				}
				if (!RectangleHelper.TryParseRectangleData(textParamValue3, out rectangle, false))
				{
					return (isSuccess: false, message: "找图搜索的坐标范围为空或不合法：" + textParamValue3, failReason: ActionStopFlag.OperationFailed);
				}
			}
			switch (textParamValue)
			{
			default:
				return (isSuccess: false, message: "不支持的操作类型：" + textParamValue, failReason: ActionStopFlag.OperationFailed);
			case "locateByBitmapFile":
			case "locateByBitmapVar":
			{
				IList<Bitmap> list2 = new List<Bitmap>();
				IDictionary<Bitmap, string> dictionary = new Dictionary<Bitmap, string>();
				IList<string> list3 = null;
				try
				{
					if (textParamValue == "locateByBitmapFile")
					{
						CkdvfacdQl5.ActionLogger?.LogInfo("屏幕找图（文件）");
						string textParamValue5 = XActionHelper.GetTextParamValue(LXOtAhSlgyD, RG3vf89LxlU, CkdvfacdQl5);
						textParamValue5 = PathHelper.RemoveZeroWidthChar(textParamValue5);
						list3 = textParamValue5.SplitToList(true, "\r\n", "\r", "\n", ";");
						foreach (string item in list3)
						{
							if (System.IO.File.Exists(item))
							{
								Bitmap bitmap = new Bitmap(item);
								list2.Add(bitmap);
								dictionary.Add(bitmap, item);
							}
						}
						if (list2.Count == 0)
						{
							return (isSuccess: false, message: "指定的位图文件不存在:" + textParamValue5, failReason: ActionStopFlag.OperationFailed);
						}
					}
					else
					{
						CkdvfacdQl5.ActionLogger?.LogInfo("屏幕找图（变量）");
						string imgFilePath;
						Bitmap bitmap2 = Quicker.Utilities.Images.ImageConverter.ToBitmap(XActionHelper.GetImageParamValue(poWtAeSMrXh, RG3vf89LxlU, CkdvfacdQl5, out imgFilePath));
						if (bitmap2 == null)
						{
							return (isSuccess: false, message: "无法获取位图！", failReason: ActionStopFlag.OperationFailed);
						}
						list2.Add(bitmap2);
					}
					string textParamValue6 = XActionHelper.GetTextParamValue(EkrtAGLidqN, RG3vf89LxlU, CkdvfacdQl5);
					int int_ = (int)XActionHelper.GetIntegerParamValue(w9ntAbreVNf, RG3vf89LxlU, CkdvfacdQl5);
					bool booleanParamValue = XActionHelper.GetBooleanParamValue(TbqtAm6PTSU, RG3vf89LxlU, CkdvfacdQl5);
					if (!Enum.TryParse<BitmapLocatePosition>(textParamValue6, out var result))
					{
						CkdvfacdQl5.ActionLogger?.LogWarning("不支持的定位点类型：" + textParamValue6);
						CkdvfacdQl5.ShowWarning("不支持的定位点类型，已使用左上角定位：" + textParamValue6, RG3vf89LxlU);
						result = BitmapLocatePosition.TopLeft;
					}
					IList<Point> list4 = new List<Point>();
					int num6 = 0;
					for (int l = 0; l < num3 + 1; l++)
					{
						if (!CkdvfacdQl5.IsShouldStopAction())
						{
							if (l > 0)
							{
								Thread.Sleep(300);
							}
							foreach (Bitmap item2 in list2)
							{
								list4 = KuyJITMYeKp9cJP7KaT.IfmLomYdH25(item2, num, num2, maP9bQMwejOq3FEOUur, rectangle, CkdvfacdQl5, num4, result, int_, booleanParamValue);
								if (list4.HasData())
								{
									if (dictionary.TryGetValue(item2, out var value))
									{
										num6 = list3?.IndexOf(value) ?? 0;
									}
									break;
								}
							}
							if (list4.HasData())
							{
								break;
							}
							continue;
						}
						return (isSuccess: false, message: "操作已中止", failReason: CkdvfacdQl5.StopFlag);
					}
					if (list4.Count == 0)
					{
						return (isSuccess: false, message: "未在屏幕上找到匹配图片的位置。", failReason: ActionStopFlag.OperationFailed);
					}
					XActionHelper.OutputResult(_firstPointOutput, RG3vf89LxlU, CkdvfacdQl5, list4[0].ToValue(), eNDvf7ObGj9);
					XActionHelper.OutputResult(_imgIndexOutput, RG3vf89LxlU, CkdvfacdQl5, num6, eNDvf7ObGj9);
					XActionHelper.OutputResult(_AllPointsOutput, RG3vf89LxlU, CkdvfacdQl5, list4.Select(_003C_003Ec.GRxvfEH9Vaq ?? (_003C_003Ec.GRxvfEH9Vaq = _003C_003Ec.zssvf01JR2R.gUwvfJVdNlv)).ToList(), eNDvf7ObGj9);
				}
				finally
				{
					if (textParamValue == "locateByBitmapFile")
					{
						foreach (Bitmap item3 in list2)
						{
							item3.Dispose();
						}
					}
				}
				goto IL_0a18;
			}
			case "locateByColor":
			{
				System.Windows.Media.Color color = ColorHelper.StringToColor(XActionHelper.GetTextParamValue(inetAYg9IYj, RG3vf89LxlU, CkdvfacdQl5));
				Point? point2 = KuyJITMYeKp9cJP7KaT.QoZLox88Dnk(color.ToSystemDrawingColor(), maP9bQMwejOq3FEOUur, rectangle, CkdvfacdQl5, num4, num, num2);
				if (!point2.HasValue)
				{
					for (int k = 0; k < num3; k++)
					{
						if (!CkdvfacdQl5.IsShouldStopAction())
						{
							Thread.Sleep(300);
							point2 = KuyJITMYeKp9cJP7KaT.QoZLox88Dnk(color.ToSystemDrawingColor(), maP9bQMwejOq3FEOUur, rectangle, CkdvfacdQl5, num4, num, num2);
							if (point2.HasValue)
							{
								break;
							}
							continue;
						}
						return (isSuccess: false, message: "操作已中止", failReason: CkdvfacdQl5.StopFlag);
					}
				}
				if (point2.HasValue)
				{
					XActionHelper.OutputResult(_firstPointOutput, RG3vf89LxlU, CkdvfacdQl5, point2.Value.ToValue(), eNDvf7ObGj9);
					goto IL_0a18;
				}
				return (isSuccess: false, message: "未找到颜色", failReason: ActionStopFlag.OperationFailed);
			}
			case "locateByText":
				{
					bool bool_ = !XActionHelper.GetBooleanParamValue(JRytAXguSYH, RG3vf89LxlU, CkdvfacdQl5);
					string textParamValue4 = XActionHelper.GetTextParamValue(OFstAIi5YHW, RG3vf89LxlU, CkdvfacdQl5);
					if (string.IsNullOrEmpty(textParamValue4))
					{
						return (isSuccess: false, message: "未指定要查找的文字", failReason: ActionStopFlag.OperationFailed);
					}
					string[] array = textParamValue4.SplitToList();
					if (XActionHelper.IsOutputParamSetted(_AllPointsOutput.Key, RG3vf89LxlU))
					{
						if (array.Length > 1)
						{
							return (isSuccess: false, message: "输出所有匹配点时，只能找1行文字。", failReason: ActionStopFlag.OperationFailed);
						}
						Stopwatch stopwatch = Stopwatch.StartNew();
						string string_;
						IList<Point> list = dfsuXeYKgS8Je0MVxhj.wcOL5uQLUMe(textParamValue4, Array.Empty<string>(), maP9bQMwejOq3FEOUur, rectangle, CkdvfacdQl5, num, num2, bool_, out string_);
						CkdvfacdQl5.ActionLogger.LogInfo("第0次：" + string_);
						if (!list.HasData())
						{
							for (int i = 0; i < num3; i++)
							{
								if (!CkdvfacdQl5.IsShouldStopAction())
								{
									Thread.Sleep(300);
									list = dfsuXeYKgS8Je0MVxhj.wcOL5uQLUMe(textParamValue4, Array.Empty<string>(), maP9bQMwejOq3FEOUur, rectangle, CkdvfacdQl5, num, num2, bool_, out string_);
									CkdvfacdQl5.ActionLogger.LogInfo($"第{i + 1}次:{string_}");
									if (list.HasData())
									{
										break;
									}
									continue;
								}
								return (isSuccess: false, message: "操作已中止", failReason: CkdvfacdQl5.StopFlag);
							}
						}
						long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
						if (list.HasData() && !AppState.DataService.Hb9tmk3OsJ7())
						{
							Thread.Sleep((int)elapsedMilliseconds);
						}
						if (!list.HasData())
						{
							XActionHelper.OutputResult(_firstPointOutput, RG3vf89LxlU, CkdvfacdQl5, "", eNDvf7ObGj9);
							XActionHelper.OutputResult(_imgIndexOutput, RG3vf89LxlU, CkdvfacdQl5, -1, eNDvf7ObGj9);
							XActionHelper.OutputResult(_AllPointsOutput, RG3vf89LxlU, CkdvfacdQl5, list.Select(_003C_003Ec.mmMvfPsSTMK ?? (_003C_003Ec.mmMvfPsSTMK = _003C_003Ec.zssvf01JR2R.R5LvfNySEoT)).ToList(), eNDvf7ObGj9);
							return (isSuccess: false, message: "未找到文字。\r\n" + string_, failReason: ActionStopFlag.OperationFailed);
						}
						XActionHelper.OutputResult(_firstPointOutput, RG3vf89LxlU, CkdvfacdQl5, list.First().ToValue(), eNDvf7ObGj9);
						XActionHelper.OutputResult(_imgIndexOutput, RG3vf89LxlU, CkdvfacdQl5, 0, eNDvf7ObGj9);
						XActionHelper.OutputResult(_AllPointsOutput, RG3vf89LxlU, CkdvfacdQl5, list.Select(_003C_003Ec.xORvfCu4Tia ?? (_003C_003Ec.xORvfCu4Tia = _003C_003Ec.zssvf01JR2R.CIQvfuhNCdD)).ToList(), eNDvf7ObGj9);
					}
					else
					{
						Stopwatch stopwatch2 = Stopwatch.StartNew();
						var (point, num5) = dfsuXeYKgS8Je0MVxhj.FxmL5CoOUgu(array, maP9bQMwejOq3FEOUur, rectangle, CkdvfacdQl5, num4, num, num2, bool_, out var string_2);
						if (!point.HasValue)
						{
							for (int j = 0; j < num3; j++)
							{
								if (!CkdvfacdQl5.IsShouldStopAction())
								{
									Thread.Sleep(300);
									CkdvfacdQl5.ActionLogger.LogInfo($"第{j + 1}次");
									(point, num5) = dfsuXeYKgS8Je0MVxhj.FxmL5CoOUgu(array, maP9bQMwejOq3FEOUur, rectangle, CkdvfacdQl5, num4, num, num2, bool_, out string_2);
									if (point.HasValue)
									{
										break;
									}
									continue;
								}
								return (isSuccess: false, message: "操作已中止", failReason: CkdvfacdQl5.StopFlag);
							}
						}
						long elapsedMilliseconds2 = stopwatch2.ElapsedMilliseconds;
						if (point.HasValue && !AppState.DataService.Hb9tmk3OsJ7())
						{
							Thread.Sleep((int)elapsedMilliseconds2);
						}
						if (!point.HasValue)
						{
							XActionHelper.OutputResult(_firstPointOutput, RG3vf89LxlU, CkdvfacdQl5, "", eNDvf7ObGj9);
							XActionHelper.OutputResult(_imgIndexOutput, RG3vf89LxlU, CkdvfacdQl5, -1, eNDvf7ObGj9);
							return (isSuccess: false, message: "未找到文字。\r\n" + string_2, failReason: ActionStopFlag.OperationFailed);
						}
						XActionHelper.OutputResult(_firstPointOutput, RG3vf89LxlU, CkdvfacdQl5, point.Value.ToValue(), eNDvf7ObGj9);
						XActionHelper.OutputResult(_imgIndexOutput, RG3vf89LxlU, CkdvfacdQl5, num5, eNDvf7ObGj9);
					}
					goto IL_0a18;
				}
				IL_0a18:
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
		}

		internal static bool DZk1ECWDH7lre7kyGCqY()
		{
			return I9r7tWWDhhP2EWf1hYJQ == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> zkwtARD3MfQ = new string[6] { "找图", "查找位图", "图片", "找图定位", "bitmap", "屏幕找色" };

	[CompilerGenerated]
	private readonly string TkltAqEr5bv = $"fa:{EFontAwesomeIcon.Light_SearchLocation}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> te1tAc0gEst;

	[CompilerGenerated]
	private readonly string gSWtAVWUmFk = "https://getquicker.net/KC/Help/Doc/searchBmp";

	[CompilerGenerated]
	private readonly bool OTGtAZ1jYuD;

	public const int RETRY_DELAY_MS = 300;

	private static readonly StepInParamDef KjotA9XUxgq;

	private static readonly StepInParamDef LXOtAhSlgyD;

	private static readonly StepInParamDef poWtAeSMrXh;

	private static readonly StepInParamDef inetAYg9IYj;

	private static readonly StepInParamDef OFstAIi5YHW;

	private static readonly StepInParamDef mD2tAWZSZvl;

	private static readonly StepInParamDef WsdtAk8pOa2;

	private static readonly StepInParamDef EkrtAGLidqN;

	private static readonly StepInParamDef ztCtAsSqt8d;

	private static readonly StepInParamDef dEJtAHoYLt5;

	private static readonly StepInParamDef CaDtA1FUS8F;

	private static readonly StepInParamDef w9ntAbreVNf;

	private static readonly StepInParamDef f4atA6BCKRx;

	private static readonly StepInParamDef JRytAXguSYH;

	private static readonly StepInParamDef TbqtAm6PTSU;

	private static readonly StepInParamDef JGPtAKxbQyj;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> F8BtAxgjeDx = new StepInParamDef[16]
	{
		KjotA9XUxgq, LXOtAhSlgyD, poWtAeSMrXh, OFstAIi5YHW, inetAYg9IYj, mD2tAWZSZvl, WsdtAk8pOa2, EkrtAGLidqN, ztCtAsSqt8d, dEJtAHoYLt5,
		CaDtA1FUS8F, w9ntAbreVNf, f4atA6BCKRx, JRytAXguSYH, TbqtAm6PTSU, JGPtAKxbQyj
	};

	private static readonly StepOutParamDef vwttArj1Rwe;

	public static readonly StepOutParamDef _firstPointOutput;

	public static readonly StepOutParamDef _imgIndexOutput;

	public static readonly StepOutParamDef _AllPointsOutput;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> t0ItApISZFL = new StepOutParamDef[4] { vwttArj1Rwe, _firstPointOutput, _AllPointsOutput, _imgIndexOutput };

	internal static SearchBmpStep K2c3e5Ql0IKIa2uRZXIh;

	public string Key => "sys:searchBmp";

	public string Name => "屏幕找图/找色/找字";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return zkwtARD3MfQ;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return TkltAqEr5bv;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Image;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return te1tAc0gEst;
		}
	}

	public string Description => "在屏幕上查找图片里的内容出现的位置";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return gSWtAVWUmFk;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return OTGtAZ1jYuD;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return F8BtAxgjeDx;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return t0ItApISZFL;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass59_0 _003C_003Ec__DisplayClass59_ = new _003C_003Ec__DisplayClass59_0();
		_003C_003Ec__DisplayClass59_.RG3vf89LxlU = step;
		_003C_003Ec__DisplayClass59_.CkdvfacdQl5 = context;
		_003C_003Ec__DisplayClass59_.eNDvf7ObGj9 = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass59_.CkdvfacdQl5, _003C_003Ec__DisplayClass59_.RG3vf89LxlU, _003C_003Ec__DisplayClass59_.eNDvf7ObGj9, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass59_.HLmvfy9Xoh7, (Action)null, (Action)null, JGPtAKxbQyj, vwttArj1Rwe);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDirectValue(KjotA9XUxgq, step) + " " + XActionHelper.GetParamDisplayString(poWtAeSMrXh, step) + " " + XActionHelper.GetParamDisplayString(inetAYg9IYj, step) + " " + XActionHelper.GetParamDisplayString(LXOtAhSlgyD, step) + " ";
	}

	static SearchBmpStep()
	{
		KjotA9XUxgq = new StepInParamDef
		{
			Key = "type",
			Name = "类型",
			Description = "操作类型",
			IsRequired = true,
			Type = VarType.Enum,
			DefaultValue = "locateByBitmapFile",
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("locateByBitmapFile", "查找图片(文件)"),
				new SelectionItem("locateByBitmapVar", "查找图片(变量)"),
				new SelectionItem("locateByColor", "查找颜色"),
				new SelectionItem("locateByText", "查找文字")
			},
			IsControlField = true
		};
		LXOtAhSlgyD = new StepInParamDef
		{
			Key = "bmp",
			Name = "位图路径",
			Description = "需要在屏幕中查找的位图路径。位图必须和屏幕图像完全匹配，不能压缩。此时X、Y的值为相对于搜索位图的左上角的偏移。",
			IsRequired = true,
			Type = VarType.Text,
			DefaultValue = "",
			IsMultiLine = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[1] { "locateByBitmapFile" },
			TextTools = new List<TextToolType>
			{
				TextToolType.CaptureToFile,
				TextToolType.SelectMultiFile
			},
			ReplaceMode = TextToolsReplaceMode.AppendWithNewline,
			TextToolsContextHint = new TextToolsContextHint
			{
				FileDialogFilter = "*.png|*.png"
			}
		};
		poWtAeSMrXh = new StepInParamDef
		{
			Key = "bmpVar",
			Name = "位图变量",
			Description = "需要在屏幕中查找的位图。位图必须和屏幕图像完全匹配，不能压缩。此时X、Y的值为相对于搜索位图的左上角的偏移。",
			IsRequired = true,
			Type = VarType.Image,
			DefaultValue = "",
			VariableMode = ParamVariableMode.UseVar,
			ValidForList = new string[1] { "locateByBitmapVar" }
		};
		inetAYg9IYj = new StepInParamDef
		{
			Key = "color",
			Name = "颜色",
			Description = "要查找的颜色，如#FF0000",
			IsRequired = true,
			Type = VarType.Text,
			DefaultValue = "#FF0000",
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[1] { "locateByColor" },
			TextTools = new List<TextToolType>
			{
				TextToolType.ColorPicker,
				TextToolType.SelectColor
			}
		};
		OFstAIi5YHW = new StepInParamDef
		{
			Key = "searchText",
			Name = "文字",
			Description = "要查找的文字。可使用多行指定多组可选文字，找到任意一组即可。",
			IsRequired = false,
			Type = VarType.Text,
			IsMultiLine = true,
			DefaultValue = "",
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[1] { "locateByText" }
		};
		mD2tAWZSZvl = new StepInParamDef
		{
			Key = "bmpTargetType",
			Name = "查找范围",
			Description = "位图查找范围",
			Type = VarType.Enum,
			DefaultValue = maP9bQMwejOq3FEOUur.MainScreen.ToString(),
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem(maP9bQMwejOq3FEOUur.MainScreen.ToString(), "主屏幕"),
				new SelectionItem(maP9bQMwejOq3FEOUur.CurrentWindow.ToString(), "当前窗口"),
				new SelectionItem(maP9bQMwejOq3FEOUur.Rect.ToString(), "坐标范围"),
				new SelectionItem(maP9bQMwejOq3FEOUur.AllScreens.ToString(), "所有屏幕")
			},
			ValidForList = new List<string> { "locateByBitmapFile", "locateByBitmapVar", "locateByColor", "locateByText" }
		};
		WsdtAk8pOa2 = new StepInParamDef
		{
			Key = "searchRect",
			Name = "查找坐标范围",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			Description = "可选。当“查找范围”为“坐标范围”时有效，格式为：left,top,right,bottom",
			TextTools = new List<TextToolType> { TextToolType.SelectLocationArea },
			ReplaceMode = TextToolsReplaceMode.ReplaceAll
		};
		EkrtAGLidqN = new StepInParamDef
		{
			Key = "bmpPosition",
			Name = "定位位置",
			Description = "定位点相对位图的位置",
			Type = VarType.Enum,
			DefaultValue = "Center",
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("Center", "位图中间"),
				new SelectionItem("TopLeft", "左上角"),
				new SelectionItem("TopRight", "右上角"),
				new SelectionItem("BottomLeft", "左下角"),
				new SelectionItem("BottomRight", "右下角")
			},
			ValidForList = new List<string> { "locateByBitmapFile", "locateByBitmapVar" }
		};
		ztCtAsSqt8d = new StepInParamDef
		{
			Key = "x",
			Name = "X偏移",
			Description = "定位点水平坐标偏移量（正值向右）",
			IsRequired = true,
			Type = VarType.Integer,
			DefaultValue = 0,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		dEJtAHoYLt5 = new StepInParamDef
		{
			Key = "y",
			Name = "Y偏移",
			Description = "定位点垂直坐标偏移量（正值向下）",
			IsRequired = true,
			Type = VarType.Integer,
			DefaultValue = 0,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		CaDtA1FUS8F = new StepInParamDef
		{
			Key = "bmpColorError",
			Name = "颜色容差",
			Description = "匹配像素时允许每个颜色通道的偏差值0-100，0表示精确匹配，速度最快。",
			Type = VarType.Integer,
			DefaultValue = 10,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "locateByBitmapFile", "locateByBitmapVar", "locateByColor" }
		};
		w9ntAbreVNf = new StepInParamDef
		{
			Key = "maxFindCount",
			Name = "最大匹配",
			Description = "找图的最大匹配数量。将对每个查找到的目标执行附加动作。",
			Type = VarType.Integer,
			DefaultValue = 1,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "locateByBitmapFile", "locateByBitmapVar" }
		};
		f4atA6BCKRx = new StepInParamDef
		{
			Key = "retryCount",
			Name = "重试次数",
			Description = "未找到位图时的重试次数。每次重试间隔300ms。",
			Type = VarType.Integer,
			DefaultValue = 0,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "locateByBitmapFile", "locateByBitmapVar", "locateByColor", "locateByText" }
		};
		JRytAXguSYH = new StepInParamDef
		{
			Key = "ignoreWindowsOcr",
			Name = "跳过WindowsOCR引擎",
			DefaultValue = false,
			Description = "",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "locateByText" }
		};
		TbqtAm6PTSU = new StepInParamDef
		{
			Key = "ignoreBgColor",
			Name = "忽略背景色",
			DefaultValue = true,
			Description = "如果查找图片的4个顶点颜色一致，则认为是背景色，找图时忽略此颜色。",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "locateByBitmapFile", "locateByBitmapVar" }
		};
		JGPtAKxbQyj = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后中止动作",
			DefaultValue = true,
			Description = "获取位置失败后，是否停止后续动作的执行。",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		vwttArj1Rwe = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "",
			Type = VarType.Boolean
		};
		_firstPointOutput = new StepOutParamDef
		{
			Key = "firstPoint",
			Name = "第一个匹配点",
			Description = "第一个匹配点坐标，格式为：x坐标,y坐标",
			Type = VarType.Text
		};
		_imgIndexOutput = new StepOutParamDef
		{
			Key = "imgIndex",
			Name = "匹配序号",
			Description = "从多个图片或多组文字中查找时，返回匹配到的图片或文字组序号，从0开始。",
			Type = VarType.Integer,
			ValidForList = new string[2] { "locateByBitmapFile", "locateByText" }
		};
		_AllPointsOutput = new StepOutParamDef
		{
			Key = "allPoints",
			Name = "所有匹配点",
			Description = "所有的匹配点列表",
			Type = VarType.List,
			ValidForList = new string[3] { "locateByBitmapFile", "locateByBitmapVar", "locateByText" }
		};
	}

	internal static bool bsHSdOQl1mLWqyAYd2sf()
	{
		return K2c3e5Ql0IKIa2uRZXIh == null;
	}
}
