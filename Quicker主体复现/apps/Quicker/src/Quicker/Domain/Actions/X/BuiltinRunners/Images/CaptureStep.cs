using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using c4LBdq5YohQFUgxFYw4;
using FontAwesome5;
using gNDpGkYZYbhLdMnAyKv;
using nVJdY15fbnHJJyC6ngN;
using Quicker.Common;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Modules.TextTools;
using Quicker.Public.Actions;
using Quicker.ScreenSelectLib;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Win32;
using Quicker.View.Hotkeys;
using WindowsInput;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Images;

public class CaptureStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass52_0
	{
		public ActionStep R7qSRo9j133;

		public ActionExecuteContext k1jSRT5LWZA;

		public CaptureStep hZxSRMtfRZ6;

		public XAction sHYSRAxQItT;

		private static _003C_003Ec__DisplayClass52_0 NDMAXIWaQ6mnvE5e6giX;

		internal (bool isSuccess, string message, ActionStopFlag failReason) mf5SRdf56ON()
		{
			long integerParamValue = XActionHelper.GetIntegerParamValue(uAEgab9u3c3, R7qSRo9j133, k1jSRT5LWZA);
			if (integerParamValue > 0L)
			{
				Thread.Sleep((int)integerParamValue);
			}
			if (integerParamValue < 200L)
			{
				long num = AppHelper.fLiLTj0x4QY() - AppState.TriggerWindowHideTime;
				if (num < 200L)
				{
					integerParamValue = 200L - num - integerParamValue;
					if (integerParamValue > 10L)
					{
						Thread.Sleep((int)integerParamValue);
					}
				}
			}
			Bitmap bitmap_ = null;
			Rectangle rectangle_ = Rectangle.Empty;
			bool flag = false;
			string textParamValue = XActionHelper.GetTextParamValue(Dj8gakb2wB5, R7qSRo9j133, k1jSRT5LWZA);
			switch (textParamValue)
			{
			default:
				return (isSuccess: false, message: "不支持的截图类型：" + textParamValue, failReason: ActionStopFlag.OperationFailed);
			case "windowBackground":
				hZxSRMtfRZ6.dgQgaq2eCET(R7qSRo9j133, k1jSRT5LWZA, sHYSRAxQItT, out bitmap_, out rectangle_);
				break;
			case "window":
				hZxSRMtfRZ6.soogac1R5rg(R7qSRo9j133, k1jSRT5LWZA, sHYSRAxQItT, out bitmap_, out rectangle_);
				break;
			case "fixed_area":
				hZxSRMtfRZ6.gZYgaZqxX4X(R7qSRo9j133, k1jSRT5LWZA, sHYSRAxQItT, out bitmap_, out rectangle_);
				break;
			case "primary_screen":
				hZxSRMtfRZ6.EOjgaRkfEeB(R7qSRo9j133, k1jSRT5LWZA, sHYSRAxQItT, out bitmap_, out rectangle_);
				break;
			case "full_screen":
				hZxSRMtfRZ6.rZQga9jPRgU(R7qSRo9j133, k1jSRT5LWZA, sHYSRAxQItT, out bitmap_, out rectangle_);
				break;
			case "select":
			{
				ActionAssociation association = k1jSRT5LWZA.Action.Association;
				if (association != null && association.IsImageProcessor)
				{
					ActionAssociation association2 = k1jSRT5LWZA.Action.Association;
					if (association2 != null && association2.ReturnImageFromFirstScreenShotStep && k1jSRT5LWZA.ExtraData != null && k1jSRT5LWZA.ExtraData.CaptureImage != null && !k1jSRT5LWZA.RootContext.HasImageParamUsed)
					{
						k1jSRT5LWZA.RootContext.HasImageParamUsed = true;
						bitmap_ = k1jSRT5LWZA.ExtraData.CaptureImage;
						rectangle_ = k1jSRT5LWZA.ExtraData.CaptureArea ?? Rectangle.Empty;
						flag = true;
						break;
					}
				}
				if (JowgaBM5y5d)
				{
					return (isSuccess: false, message: "正在进行截图操作！\r\n如果没有在截图，请在Quicker设置中去除第三方截图快捷键。", failReason: ActionStopFlag.OperationFailed);
				}
				JowgaBM5y5d = true;
				try
				{
					hZxSRMtfRZ6.KUFgaVPecxk(R7qSRo9j133, k1jSRT5LWZA, sHYSRAxQItT, out bitmap_, out rectangle_);
				}
				catch (Exception ex)
				{
					return (isSuccess: false, message: ex.Message, failReason: ActionStopFlag.UserCancel);
				}
				finally
				{
					JowgaBM5y5d = false;
				}
				break;
			}
			}
			if (bitmap_ != null)
			{
				if (!flag)
				{
					k1jSRT5LWZA.RegisterDisposable(bitmap_);
				}
				XActionHelper.OutputResult(k8lgaxsPPFs, R7qSRo9j133, k1jSRT5LWZA, bitmap_, sHYSRAxQItT);
				XActionHelper.OutputResult(xKKgar5BhHF, R7qSRo9j133, k1jSRT5LWZA, $"{rectangle_.Left},{rectangle_.Top},{rectangle_.Right},{rectangle_.Bottom}", sHYSRAxQItT);
				if (XActionHelper.GetBooleanParamValue(Lxmga6mQlrX, R7qSRo9j133, k1jSRT5LWZA))
				{
					int clipboardSequenceNumber = AppState.ClipboardSequenceNumber;
					ClipboardHelper.SetImage(bitmap_);
					AppHelper.WaitClipboardChange(clipboardSequenceNumber, 1000);
				}
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
			return (isSuccess: false, message: "已取消截图。", failReason: ActionStopFlag.UserCancel);
		}

		internal static bool FQUHC5WaFxCAyHwXRGAe()
		{
			return NDMAXIWaQ6mnvE5e6giX == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass56_0
	{
		public Rectangle? kQ1SRFEkdkJ;

		public qsQtMm5MtHtoYi1dcdV vciSRUPoM6u;

		private static _003C_003Ec__DisplayClass56_0 noo2ChWaWiKhoi4ywQ91;

		internal void uEPSRO8usT2()
		{
			SelectOptions options = ((!kQ1SRFEkdkJ.HasValue) ? null : new SelectOptions
			{
				PreSelectArea = kQ1SRFEkdkJ
			});
			vciSRUPoM6u = hUhANW5oHPgw7wvDYAd.Select(ScreenSelectType.Rectangle, true, options);
		}

		internal static bool CoD0mGWayMGHeQL7AUhX()
		{
			return noo2ChWaWiKhoi4ywQ91 == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> pJfgahdoKU9 = new string[4] { "snap", "crop", "capture", "截图" };

	[CompilerGenerated]
	private readonly string xUUgaeXd6Ik = $"fa:{EFontAwesomeIcon.Light_ExpandWide}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> NjKgaYgu4PJ;

	[CompilerGenerated]
	private readonly string RROgaI833Tq = "https://getquicker.net/KC/Help/Doc/screencapture";

	[CompilerGenerated]
	private readonly bool wAkgaWEofS3;

	private static readonly StepInParamDef Dj8gakb2wB5;

	private static readonly StepInParamDef abKgaGO4sqH;

	private static readonly StepInParamDef PqHgasVk7qG;

	private static readonly StepInParamDef v3NgaHyFsBw;

	private static readonly StepInParamDef y84ga1Wlplh;

	private static readonly StepInParamDef uAEgab9u3c3;

	private static readonly StepInParamDef Lxmga6mQlrX;

	private static readonly StepInParamDef B5vgaXbH6Wi;

	private static readonly StepOutParamDef MclgamfpAR4;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> dcWgaKhbfmL = new StepInParamDef[8] { Dj8gakb2wB5, abKgaGO4sqH, y84ga1Wlplh, uAEgab9u3c3, PqHgasVk7qG, v3NgaHyFsBw, Lxmga6mQlrX, B5vgaXbH6Wi };

	private static readonly StepOutParamDef k8lgaxsPPFs;

	private static readonly StepOutParamDef xKKgar5BhHF;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> hOPgapawYdA = new StepOutParamDef[3] { k8lgaxsPPFs, xKKgar5BhHF, MclgamfpAR4 };

	private static bool JowgaBM5y5d;

	private static CaptureStep H9bQ5xQI8ZELgajeu8y6;

	public string Key => "sys:screenCapture";

	public string Name => "屏幕截图";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return pJfgahdoKU9;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return xUUgaeXd6Ik;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Image;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return NjKgaYgu4PJ;
		}
	}

	public string Description => "截取屏幕区域";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return RROgaI833Tq;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return wAkgaWEofS3;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return dcWgaKhbfmL;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return hOPgapawYdA;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass52_0 _003C_003Ec__DisplayClass52_ = new _003C_003Ec__DisplayClass52_0();
		_003C_003Ec__DisplayClass52_.R7qSRo9j133 = step;
		_003C_003Ec__DisplayClass52_.k1jSRT5LWZA = context;
		_003C_003Ec__DisplayClass52_.hZxSRMtfRZ6 = this;
		_003C_003Ec__DisplayClass52_.sHYSRAxQItT = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass52_.k1jSRT5LWZA, _003C_003Ec__DisplayClass52_.R7qSRo9j133, _003C_003Ec__DisplayClass52_.sHYSRAxQItT, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass52_.mf5SRdf56ON, (Action)null, (Action)null, B5vgaXbH6Wi, MclgamfpAR4);
	}

	private void EOjgaRkfEeB(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0, out Bitmap bitmap_0, out Rectangle rectangle_0)
	{
		rectangle_0 = Screen.PrimaryScreen.Bounds;
		bitmap_0 = CaptureArea(rectangle_0);
	}

	private void dgQgaq2eCET(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0, out Bitmap bitmap_0, out Rectangle rectangle_0)
	{
		IntPtr intPtr = (IntPtr)XActionHelper.GetIntegerParamValue(y84ga1Wlplh, actionStep_0, actionExecuteContext_0);
		if (intPtr == IntPtr.Zero)
		{
			soogac1R5rg(actionStep_0, actionExecuteContext_0, xaction_0, out bitmap_0, out rectangle_0);
			return;
		}
		if (!NativeMethods.IsWindow(intPtr))
		{
			throw new InvalidDataException($"句柄{intPtr}不是一个窗口。");
		}
		NativeMethods.RECT windowRect = NativeMethods.GetWindowRect(intPtr);
		int num = windowRect.Right - windowRect.Left;
		int num2 = windowRect.Bottom - windowRect.Top;
		if (num > 0)
		{
			int num3 = 0;
			if (H9bQ5xQI8ZELgajeu8y6 != null)
			{
				int num4 = default(int);
				num3 = num4;
			}
			switch (num3)
			{
			}
			if (num2 > 0)
			{
				Bitmap bitmap = new Bitmap(num, num2, PixelFormat.Format32bppRgb);
				using (Graphics graphics = Graphics.FromImage(bitmap))
				{
					IntPtr hdc = graphics.GetHdc();
					if (NativeMethods.IsOnWindows10OrLater())
					{
						NativeMethods.PrintWindow(intPtr, hdc, 2);
					}
					else
					{
						NativeMethods.PrintWindow(intPtr, hdc, 0);
					}
					graphics.ReleaseHdc(hdc);
					graphics.Dispose();
				}
				bitmap.MakeTransparent(Color.Black);
				bitmap_0 = bitmap;
				rectangle_0 = new Rectangle(windowRect.Left, windowRect.Top, num, num2);
				return;
			}
		}
		throw new InvalidDataException("未能获得窗口位置。");
	}

	private void soogac1R5rg(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0, out Bitmap bitmap_0, out Rectangle rectangle_0)
	{
		IntPtr intPtr = (IntPtr)XActionHelper.GetIntegerParamValue(y84ga1Wlplh, actionStep_0, actionExecuteContext_0);
		if (intPtr == IntPtr.Zero)
		{
			intPtr = NativeMethods.GetForegroundWindow();
		}
		else if (!NativeMethods.IsWindow(intPtr))
		{
			int num = 0;
			if (H9bQ5xQI8ZELgajeu8y6 != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				throw new InvalidOperationException($"未找到窗口：{intPtr}");
			}
		}
		NativeMethods.RECT windowRectangle = NativeMethods.GetWindowRectangle(intPtr);
		Rectangle rectangle = new Rectangle(windowRectangle.Left, windowRectangle.Top, windowRectangle.Right - windowRectangle.Left, windowRectangle.Bottom - windowRectangle.Top);
		Bitmap bitmap = CaptureArea(rectangle);
		bitmap_0 = bitmap;
		rectangle_0 = rectangle;
	}

	private void KUFgaVPecxk(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0, out Bitmap bitmap_0, out Rectangle rectangle_0)
	{
		// 等待循环保留同一次截图的截止时间和取消计数。
		DateTime dateTime = default;
		int escCounter = 0;
		_003C_003Ec__DisplayClass56_0 _003C_003Ec__DisplayClass56_ = new _003C_003Ec__DisplayClass56_0();
		Bitmap bitmap = null;
		Rectangle rectangle = Rectangle.Empty;
		string textParamValue = XActionHelper.GetTextParamValue(PqHgasVk7qG, actionStep_0, actionExecuteContext_0);
		bool booleanParamValue = XActionHelper.GetBooleanParamValue(v3NgaHyFsBw, actionStep_0, actionExecuteContext_0);
		_003C_003Ec__DisplayClass56_.kQ1SRFEkdkJ = null;
		if (!string.IsNullOrEmpty(textParamValue))
		{
			if (!RectangleHelper.TryParseRectangleData(textParamValue, out var rectangle2, booleanParamValue))
			{
				throw new InvalidOperationException("不是合法的预选区域值：" + textParamValue);
			}
			_003C_003Ec__DisplayClass56_.kQ1SRFEkdkJ = rectangle2;
		}
		int clipboardSequenceNumber = default(int);
		if (AppState.DataService.CpItmVISR7P().EnableExternScreenCapture && !XActionHelper.IsOutputParamSetted(xKKgar5BhHF.Key, actionStep_0))
		{
			if (string.IsNullOrEmpty(AppState.DataService.CpItmVISR7P().ExternScreenCaptureHotkey))
			{
				throw new InvalidOperationException("未设定第三方截图工具快捷键。");
			}
			clipboardSequenceNumber = AppState.ClipboardSequenceNumber;
			Hotkey hotkey = new Hotkey(AppState.DataService.CpItmVISR7P().ExternScreenCaptureHotkey);
			InputSimulator.Instance.Keyboard.ModifiedKeyStroke(hotkey.GetModifierKeyCodes().ToList(), hotkey.Key, AppHelper.kPoLTdWFLA7());
			goto IL_0135;
		}
		goto IL_01ac;
		IL_0157:
		int num;
		if (clipboardSequenceNumber == AppState.ClipboardSequenceNumber && DateTime.Now < dateTime && escCounter == AppState.EscCounter)
		{
			Thread.Sleep(20);
			num = 0;
			if (!KCRHk8QIRRiioWyrfr97())
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_0195;
		}
		if (clipboardSequenceNumber != AppState.ClipboardSequenceNumber && ClipboardHelper.ContainsImage())
		{
			bitmap = new Bitmap(kWsP1bYRVsfaicfjr67.UyVL5sg3svP());
			goto IL_0244;
		}
		throw new InvalidOperationException("未在剪贴板发现图片，截图步骤失败。");
		IL_021f:
		bitmap = _003C_003Ec__DisplayClass56_.vciSRUPoM6u.Image;
		rectangle = _003C_003Ec__DisplayClass56_.vciSRUPoM6u.tyEmRRGGv3();
		goto IL_0244;
		IL_01d5:
		if (_003C_003Ec__DisplayClass56_.vciSRUPoM6u.tyEmRRGGv3().Width < 1 || _003C_003Ec__DisplayClass56_.vciSRUPoM6u.tyEmRRGGv3().Height < 1)
		{
			throw new Exception("截取的图片太小。");
		}
		goto IL_021f;
		IL_0135:
		DateTime now = DateTime.Now;
		dateTime = DateTime.Now.AddMilliseconds(20000.0);
		escCounter = AppState.EscCounter;
		goto IL_0157;
		IL_0244:
		bitmap_0 = bitmap;
		rectangle_0 = rectangle;
		return;
		IL_0195:
		switch (num)
		{
		case 3:
			break;
		default:
			goto IL_0157;
		case 2:
			goto IL_01ac;
		case 1:
			goto IL_01d5;
		}
		goto IL_0135;
		IL_01ac:
		_003C_003Ec__DisplayClass56_.vciSRUPoM6u = null;
		AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass56_.uEPSRO8usT2);
		if (_003C_003Ec__DisplayClass56_.vciSRUPoM6u != null && _003C_003Ec__DisplayClass56_.vciSRUPoM6u.IsSuccess)
		{
			if (_003C_003Ec__DisplayClass56_.vciSRUPoM6u.tyEmRRGGv3().Width < 1 || _003C_003Ec__DisplayClass56_.vciSRUPoM6u.tyEmRRGGv3().Height < 1)
			{
				num = 1;
				if (!KCRHk8QIRRiioWyrfr97())
				{
					goto IL_0195;
				}
				goto IL_01d5;
			}
			goto IL_021f;
		}
		throw new Exception("截图取消");
	}

	private void gZYgaZqxX4X(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0, out Bitmap bitmap_0, out Rectangle rectangle_0)
	{
		string textParamValue = XActionHelper.GetTextParamValue(abKgaGO4sqH, actionStep_0, actionExecuteContext_0);
		bool booleanParamValue = XActionHelper.GetBooleanParamValue(v3NgaHyFsBw, actionStep_0, actionExecuteContext_0);
		Rectangle rectangle = Rectangle.Empty;
		if (!RectangleHelper.TryParseRectangleData(textParamValue, out rectangle, booleanParamValue))
		{
			throw new InvalidOperationException("不是合法的区域值：" + textParamValue);
		}
		Bitmap bitmap = CaptureArea(rectangle);
		bitmap_0 = bitmap;
		rectangle_0 = rectangle;
	}

	public static Bitmap CaptureWindow(IntPtr handle)
	{
		NativeMethods.RECT windowRectangle = NativeMethods.GetWindowRectangle(handle);
		return CaptureArea(new Rectangle(windowRectangle.Left, windowRectangle.Top, windowRectangle.Right - windowRectangle.Left, windowRectangle.Bottom - windowRectangle.Top));
	}

	public static Bitmap CaptureArea(Rectangle rect)
	{
		Bitmap bitmap = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppRgb);
		using Graphics graphics = Graphics.FromImage(bitmap);
		graphics.CopyFromScreen(rect.Left, rect.Top, 0, 0, bitmap.Size);
		return bitmap;
	}

	private void rZQga9jPRgU(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0, out Bitmap bitmap_0, out Rectangle rectangle_0)
	{
		int num = 1;
		while (true)
		{
			Rectangle virtualScreen = SystemInformation.VirtualScreen;
			int num2 = 0;
			if (H9bQ5xQI8ZELgajeu8y6 != null)
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			int left = virtualScreen.Left;
			int top = SystemInformation.VirtualScreen.Top;
			int width = SystemInformation.VirtualScreen.Width;
			int height = SystemInformation.VirtualScreen.Height;
			Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format32bppRgb);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.CopyFromScreen(left, top, 0, 0, bitmap.Size);
			}
			rectangle_0 = SystemInformation.VirtualScreen;
			bitmap_0 = bitmap;
			return;
		}
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDirectValue(Dj8gakb2wB5, step) + " => " + XActionHelper.GetOutputParamDisplayString(k8lgaxsPPFs, step);
	}

	static CaptureStep()
	{
		Dj8gakb2wB5 = new StepInParamDef
		{
			Key = "type",
			Name = "截图类型",
			DefaultValue = "select",
			Description = "截取图片的屏幕区域类型",
			VariableMode = ParamVariableMode.Input,
			Type = VarType.Enum,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("select", "选择区域"),
				new SelectionItem("full_screen", "所有屏幕"),
				new SelectionItem("primary_screen", "主屏幕"),
				new SelectionItem("fixed_area", "固定区域"),
				new SelectionItem("window", "窗口 (屏幕可见内容)"),
				new SelectionItem("windowBackground", "窗口 (支持后台显示)")
			},
			IsControlField = true
		};
		abKgaGO4sqH = new StepInParamDef
		{
			Key = "area",
			Name = "截图区域",
			Description = "要截取的屏幕坐标位置（像素值），格式为：left,top,right,bottom。默认不包含右边和底边像素。",
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text,
			IsMultiLine = false,
			ValidForList = new List<string> { "fixed_area" },
			TextTools = new List<TextToolType> { TextToolType.SelectLocationArea },
			ReplaceMode = TextToolsReplaceMode.ReplaceAll
		};
		PqHgasVk7qG = new StepInParamDef
		{
			Key = "preSelectArea",
			Name = "预选截图区域",
			Description = "非必要请勿设置。预先选择的截图区域，格式为：left,top,right,bottom。默认不包含右边和底边像素。",
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text,
			IsMultiLine = false,
			ValidForList = new List<string> { "select" },
			TextTools = new List<TextToolType> { TextToolType.SelectLocationArea },
			ReplaceMode = TextToolsReplaceMode.ReplaceAll,
			IsAdvanced = true
		};
		v3NgaHyFsBw = new StepInParamDef
		{
			Key = "includeRightBottomBorder",
			Name = "预选截图区域包含右边和底边像素",
			Description = "包含时，当指定 0,0,2,2 的时候，截图的大小为3*3, 否则为2*2",
			VariableMode = ParamVariableMode.Input,
			Type = VarType.Boolean,
			DefaultValue = true,
			IsAdvanced = true,
			ValidForList = new List<string> { "fixed_area", "select" }
		};
		y84ga1Wlplh = new StepInParamDef
		{
			Key = "windowHandle",
			Name = "窗口句柄",
			Description = "要截取的窗口句柄数字。0或留空表示截取前台窗口。",
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Integer,
			DefaultValue = 0,
			IsMultiLine = false,
			ValidForList = new List<string> { "window", "windowBackground" },
			TextTools = new List<TextToolType> { TextToolType.SelectWindowHandle },
			ReplaceMode = TextToolsReplaceMode.ReplaceAll
		};
		uAEgab9u3c3 = new StepInParamDef
		{
			Key = "delay",
			Name = "截图前延迟时间",
			Description = "等待多少毫秒后开始截图",
			Type = VarType.Integer,
			DefaultValue = 0,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		Lxmga6mQlrX = new StepInParamDef
		{
			Key = "toClip",
			Name = "写入剪贴板",
			Description = "截屏图片是否写入到剪贴板中",
			Type = VarType.Boolean,
			DefaultValue = false,
			VariableMode = ParamVariableMode.Input
		};
		B5vgaXbH6Wi = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		MclgamfpAR4 = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		k8lgaxsPPFs = new StepOutParamDef
		{
			Key = "img",
			Name = "图片",
			Description = "截图的图片",
			Type = VarType.Image
		};
		xKKgar5BhHF = new StepOutParamDef
		{
			Key = "rect",
			Name = "截图区域",
			Description = "图片的截取区域(left,top,right,bottom)。",
			Type = VarType.Text
		};
	}

	internal static bool KCRHk8QIRRiioWyrfr97()
	{
		return H9bQ5xQI8ZELgajeu8y6 == null;
	}

	internal static void dkaaP0QItB5j0sArrL5V()
	{
	}
}
