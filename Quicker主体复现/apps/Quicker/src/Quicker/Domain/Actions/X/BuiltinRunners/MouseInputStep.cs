using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Media;
using bcybYUMWiG3W9kCqUoJ;
using ClickShow;
using FontAwesome5;
using GgthUOMMIWtpmNWHFuM;
using Quicker.Domain.Actions.Debugging;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Modules.TextTools;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Images;
using Quicker.Utilities.Win32;
using WindowsInput;
using WindowsInput.Native;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class MouseInputStep : IStepRunner, IStepRunningInfo
{
	public enum CursorEnum
	{
		UNKOWNCURSOR,
		AppStarting,
		Arrow,
		Cross,
		Default,
		IBeam,
		No,
		SizeAll,
		SizeNESW,
		SizeNS,
		SizeNWSE,
		SizeWE,
		UpArrow,
		WaitCursor,
		Help,
		HSplit,
		VSplit,
		NoMove2D,
		NoMoveHoriz,
		NoMoveVert,
		PanEast,
		PanNE,
		PanNorth,
		PanNW,
		PanSE,
		PanSouth,
		PanSW,
		PanWest,
		Hand
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec HvMSgxTn5Vi;

		public static Func<Point, string> O9eSgr4rZ4n;

		public static Func<object> OiaSgpFKnlS;

		internal static _003C_003Ec AsucRIWGSpZ46R9D2vy7;

		static _003C_003Ec()
		{
			HvMSgxTn5Vi = new _003C_003Ec();
		}

		internal string s2QSgmhVKDa(Point pt)
		{
			return pt.ToValue();
		}

		internal object lRRSgKqLiuP()
		{
			IntPtr cursorHandle = NativeMethods.GetCursorHandle();
			if (cursorHandle == IntPtr.Zero)
			{
				return "";
			}
			CursorEnum cursor = GetCursor(cursorHandle);
			if (cursor == CursorEnum.UNKOWNCURSOR)
			{
				return cursorHandle.ToString();
			}
			return cursor.ToString();
		}

		internal static bool d0GPxXWGwpQuYxEgRYXd()
		{
			return AsucRIWGSpZ46R9D2vy7 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass72_0
	{
		public ActionStep jnoSgQisLMy;

		public ActionExecuteContext r6rSgjQfV7Z;

		public MouseInputStep Dn0SgnbqtuR;

		public XAction R59Sg4OoZep;

		internal static _003C_003Ec__DisplayClass72_0 dKilsQWGmKTPPS19wYZX;

		internal (bool isSuccess, string message, ActionStopFlag failReason) sK9SgBrhErD()
		{
			string textParamValue = XActionHelper.GetTextParamValue(plDtfKIjpLZ, jnoSgQisLMy, r6rSgjQfV7Z);
			string textParamValue2 = XActionHelper.GetTextParamValue(oyhtfxS7FMN, jnoSgQisLMy, r6rSgjQfV7Z);
			int num = (int)XActionHelper.GetIntegerParamValue(LJ3tfpYtaC7, jnoSgQisLMy, r6rSgjQfV7Z);
			int num2 = (int)XActionHelper.GetIntegerParamValue(K5RtfB9iRI4, jnoSgQisLMy, r6rSgjQfV7Z);
			string text = "";
			bool flag = bVhtfUT0cAr.ValidForList.Contains(textParamValue) && XActionHelper.GetBooleanParamValue(bVhtfUT0cAr, jnoSgQisLMy, r6rSgjQfV7Z);
			_003C_003Ec__DisplayClass72_1 _003C_003Ec__DisplayClass72_1_ = default(_003C_003Ec__DisplayClass72_1);
			_003C_003Ec__DisplayClass72_1_.ziESg5PRaB1 = (flag ? new Point?(Cursor.Position) : ((Point?)null));
			if (vFPtfFjjKx0.ValidForList.Contains(textParamValue))
			{
				text = XActionHelper.GetTextParamValue(vFPtfFjjKx0, jnoSgQisLMy, r6rSgjQfV7Z);
			}
			_003C_003Ec__DisplayClass72_1_.vGISgDE2aCo = XActionHelper.GetBooleanParamValue(STvtfOkQ9Px, jnoSgQisLMy, r6rSgjQfV7Z);
			switch (textParamValue)
			{
			case "up":
				if (r6rSgjQfV7Z.IsDebugging)
				{
					r6rSgjQfV7Z.ActionLogger?.LogInfo("抬起鼠标按键：" + textParamValue2);
				}
				switch (textParamValue2)
				{
				default:
					r6rSgjQfV7Z.ActionLogger?.LogWarning("不支持的按键：" + textParamValue2);
					break;
				case "x2":
					InputSimulator.Instance.Mouse.XButtonUp(2);
					break;
				case "x1":
					InputSimulator.Instance.Mouse.XButtonUp(1);
					break;
				case "middle":
					InputSimulator.Instance.Mouse.MiddleButtonUp();
					break;
				case "right":
					InputSimulator.Instance.Mouse.RightButtonUp();
					break;
				case "left":
					InputSimulator.Instance.Mouse.LeftButtonUp();
					break;
				}
				goto IL_1387;
			case "move":
				Dn0SgnbqtuR.JXHtfWluQ1j(r6rSgjQfV7Z, num, num2, text, InputSimulator.Instance, _003C_003Ec__DisplayClass72_1_.vGISgDE2aCo);
				goto IL_1387;
			case "down":
				if (r6rSgjQfV7Z.IsDebugging)
				{
					r6rSgjQfV7Z.ActionLogger?.LogInfo("按下鼠标按键：" + textParamValue2);
				}
				switch (textParamValue2)
				{
				default:
					r6rSgjQfV7Z.ActionLogger?.LogWarning("不支持的按键：" + textParamValue2);
					break;
				case "x2":
					InputSimulator.Instance.Mouse.XButtonDown(2);
					break;
				case "x1":
					InputSimulator.Instance.Mouse.XButtonDown(1);
					break;
				case "middle":
					InputSimulator.Instance.Mouse.MiddleButtonDown();
					break;
				case "right":
					InputSimulator.Instance.Mouse.RightButtonDown();
					break;
				case "left":
					InputSimulator.Instance.Mouse.LeftButtonDown();
					break;
				}
				goto IL_1387;
			case "click":
				if (r6rSgjQfV7Z.IsDebugging)
				{
					r6rSgjQfV7Z.ActionLogger?.LogInfo("点击鼠标按键：" + textParamValue2);
				}
				switch (textParamValue2)
				{
				default:
					r6rSgjQfV7Z.ActionLogger?.LogWarning("不支持的按键：" + textParamValue2);
					break;
				case "x2":
					InputSimulator.Instance.Mouse.XButtonClick(2);
					break;
				case "x1":
					InputSimulator.Instance.Mouse.XButtonClick(1);
					break;
				case "middle":
					InputSimulator.Instance.Mouse.MiddleButtonClick();
					break;
				case "right":
					InputSimulator.Instance.Mouse.RightButtonClick();
					break;
				case "left":
					InputSimulator.Instance.Mouse.LeftButtonClick();
					break;
				}
				goto IL_1387;
			case "scroll":
				if (num != 0)
				{
					InputSimulator.Instance.Mouse.HorizontalScroll(num);
					r6rSgjQfV7Z.ActionLogger?.LogInfo($"水平滚动：{num}");
				}
				if (num2 != 0)
				{
					InputSimulator.Instance.Mouse.VerticalScroll(num2);
					r6rSgjQfV7Z.ActionLogger?.LogInfo($"垂直滚动：{num2}");
				}
				goto IL_1387;
			case "moveTo":
				if (r6rSgjQfV7Z.IsDebugging)
				{
					r6rSgjQfV7Z.ActionLogger?.LogInfo($"移动到：{num},{num2}");
				}
				ay3tfHuyfgj(new Point(num, num2), ref _003C_003Ec__DisplayClass72_1_);
				Dn0SgnbqtuR.Wp3tfG17jav(text, InputSimulator.Instance);
				goto IL_1387;
			case "ctrlUp":
				if (r6rSgjQfV7Z.IsDebugging)
				{
					r6rSgjQfV7Z.ActionLogger?.LogInfo("抬起Ctrl");
				}
				InputSimulator.Instance.Keyboard.KeyUp(VirtualKeyCode.LCONTROL);
				goto IL_1387;
			case "restore":
				Dn0SgnbqtuR.pmxtfkC4Ur5(r6rSgjQfV7Z, text, InputSimulator.Instance, _003C_003Ec__DisplayClass72_1_.vGISgDE2aCo);
				goto IL_1387;
			case "dbclick":
				if (r6rSgjQfV7Z.IsDebugging)
				{
					r6rSgjQfV7Z.ActionLogger?.LogInfo("双击鼠标按键：" + textParamValue2);
				}
				switch (textParamValue2)
				{
				default:
					r6rSgjQfV7Z.ActionLogger?.LogWarning("不支持的按键：" + textParamValue2);
					break;
				case "x2":
					InputSimulator.Instance.Mouse.XButtonDoubleClick(2);
					break;
				case "x1":
					InputSimulator.Instance.Mouse.XButtonDoubleClick(1);
					break;
				case "middle":
					InputSimulator.Instance.Mouse.MiddleButtonDoubleClick();
					break;
				case "right":
					InputSimulator.Instance.Mouse.RightButtonDoubleClick();
					break;
				case "left":
					InputSimulator.Instance.Mouse.LeftButtonDoubleClick();
					break;
				}
				goto IL_1387;
			case "shiftUp":
				if (r6rSgjQfV7Z.IsDebugging)
				{
					r6rSgjQfV7Z.ActionLogger?.LogInfo("抬起Shift");
				}
				InputSimulator.Instance.Keyboard.KeyUp(VirtualKeyCode.LSHIFT);
				goto IL_1387;
			case "moveToXy":
				ay3tfHuyfgj(PointExt.FromValue(XActionHelper.GetTextParamValue(Q7jtfQ48Nrs, jnoSgQisLMy, r6rSgjQfV7Z)), ref _003C_003Ec__DisplayClass72_1_);
				Dn0SgnbqtuR.Wp3tfG17jav(text, InputSimulator.Instance);
				goto IL_1387;
			case "ctrlDown":
				if (r6rSgjQfV7Z.IsDebugging)
				{
					r6rSgjQfV7Z.ActionLogger?.LogInfo("按下Ctrl");
				}
				InputSimulator.Instance.Keyboard.KeyDown(VirtualKeyCode.LCONTROL);
				goto IL_1387;
			case "shiftDown":
				if (r6rSgjQfV7Z.IsDebugging)
				{
					r6rSgjQfV7Z.ActionLogger?.LogInfo("按下Shift");
				}
				InputSimulator.Instance.Keyboard.KeyDown(VirtualKeyCode.LSHIFT);
				goto IL_1387;
			case "toWinBL":
			case "toWinBR":
			case "toWinTL":
			case "toWinTR":
			case "moveToWinXy":
			case "toWinCenter":
			{
				IntPtr intPtr = (IntPtr)XActionHelper.GetIntegerParamValue(kS5tfjboxit, jnoSgQisLMy, r6rSgjQfV7Z);
				if (intPtr == IntPtr.Zero)
				{
					intPtr = NativeMethods.GetForegroundWindow();
				}
				else if (!NativeMethods.IsWindow(intPtr))
				{
					return (isSuccess: false, message: $"窗口不存在，错误的窗口句柄值：{intPtr}。", failReason: ActionStopFlag.OperationFailed);
				}
				NativeMethods.RECT windowRectangle = NativeMethods.GetWindowRectangle(intPtr);
				int x = 0;
				int y = 0;
				switch (textParamValue)
				{
				case "moveToWinXy":
				{
					Point point = PointExt.FromValue(XActionHelper.GetTextParamValue(OD8tfn05rDB, jnoSgQisLMy, r6rSgjQfV7Z), new Rectangle(windowRectangle.Left, windowRectangle.Top, windowRectangle.Right - windowRectangle.Left, windowRectangle.Bottom - windowRectangle.Top));
					x = point.X;
					y = point.Y;
					break;
				}
				case "toWinCenter":
					x = windowRectangle.Left + (windowRectangle.Right - windowRectangle.Left) / 2 + num;
					y = windowRectangle.Top + (windowRectangle.Bottom - windowRectangle.Top) / 2 + num2;
					break;
				case "toWinBR":
					x = windowRectangle.Right + num;
					y = windowRectangle.Bottom + num2;
					break;
				case "toWinBL":
					x = windowRectangle.Left + num;
					y = windowRectangle.Bottom + num2;
					break;
				case "toWinTR":
					x = windowRectangle.Right + num;
					y = windowRectangle.Top + num2;
					break;
				case "toWinTL":
					x = windowRectangle.Left + num;
					y = windowRectangle.Top + num2;
					break;
				}
				Point point_ = new Point(x, y);
				ay3tfHuyfgj(point_, ref _003C_003Ec__DisplayClass72_1_);
				if (r6rSgjQfV7Z.IsDebugging)
				{
					r6rSgjQfV7Z.ActionLogger?.LogInfo("移动到窗口位置：" + XActionHelper.GetParamDirectValue(plDtfKIjpLZ, jnoSgQisLMy));
					r6rSgjQfV7Z.ActionLogger?.LogInfo($"窗口位置(left,top,right,bottom)：{windowRectangle.Left},{windowRectangle.Top},{windowRectangle.Right},{windowRectangle.Bottom}  偏移量：{num},{num2}  目标：{point_.X},{point_.Y}");
				}
				Dn0SgnbqtuR.Wp3tfG17jav(text, InputSimulator.Instance);
				goto IL_1387;
			}
			case "showIndicator":
				ClickIndicator.ShowIndicator(150.0, System.Windows.Media.Brushes.Red, Cursor.Position);
				goto IL_1387;
			case "getCaretPosition":
			{
				Point caretPosition = WindowHelper.GetCaretPosition();
				XActionHelper.OutputResult(_mouseLocationOutput, jnoSgQisLMy, r6rSgjQfV7Z, caretPosition.ToValue(), R59Sg4OoZep);
				XActionHelper.OutputResult(_mouseXOutput, jnoSgQisLMy, r6rSgjQfV7Z, caretPosition.X, R59Sg4OoZep);
				XActionHelper.OutputResult(_mouseYOutput, jnoSgQisLMy, r6rSgjQfV7Z, caretPosition.Y, R59Sg4OoZep);
				goto IL_1387;
			}
			case "locateByBitmap":
			case "locateByBitmapVar":
			{
				Rectangle rectangle = Rectangle.Empty;
				long num3 = XActionHelper.GetIntegerParamValue(cqjtfARpqm2, jnoSgQisLMy, r6rSgjQfV7Z);
				if (num3 < 1L)
				{
					num3 = 1L;
				}
				IList<Bitmap> list = new List<Bitmap>();
				try
				{
					if (textParamValue == "locateByBitmap")
					{
						r6rSgjQfV7Z.ActionLogger?.LogInfo("屏幕找图（文件）");
						string textParamValue3 = XActionHelper.GetTextParamValue(CIrtf4mb5cP, jnoSgQisLMy, r6rSgjQfV7Z);
						textParamValue3 = PathHelper.RemoveZeroWidthChar(textParamValue3);
						string[] array = textParamValue3.SplitToList(true, "\r\n", "\r", "\n", ";");
						foreach (string text2 in array)
						{
							if (System.IO.File.Exists(text2))
							{
								Bitmap item = new Bitmap(text2);
								list.Add(item);
							}
						}
						if (list.Count == 0)
						{
							return (isSuccess: false, message: "指定的位图文件不存在:" + textParamValue3, failReason: ActionStopFlag.OperationFailed);
						}
					}
					else
					{
						r6rSgjQfV7Z.ActionLogger?.LogInfo("屏幕找图（变量）");
						string imgFilePath;
						Bitmap bitmap = Quicker.Utilities.Images.ImageConverter.ToBitmap(XActionHelper.GetImageParamValue(Mcrtf5bGo4b, jnoSgQisLMy, r6rSgjQfV7Z, out imgFilePath));
						if (bitmap == null)
						{
							return (isSuccess: false, message: "无法获取位图！", failReason: ActionStopFlag.OperationFailed);
						}
						list.Add(bitmap);
					}
					string textParamValue4 = XActionHelper.GetTextParamValue(xsdtfDqeerE, jnoSgQisLMy, r6rSgjQfV7Z);
					if (textParamValue4 == "Rect")
					{
						string textParamValue5 = XActionHelper.GetTextParamValue(SjjtfdLF2ey, jnoSgQisLMy, r6rSgjQfV7Z);
						if (string.IsNullOrEmpty(textParamValue5))
						{
							return (isSuccess: false, message: "找图搜索的坐标范围未指定", failReason: ActionStopFlag.OperationFailed);
						}
						if (!RectangleHelper.TryParseRectangleData(textParamValue5, out rectangle, false))
						{
							return (isSuccess: false, message: "找图搜索的坐标范围为空或不合法：" + textParamValue5, failReason: ActionStopFlag.OperationFailed);
						}
					}
					int int_ = (int)XActionHelper.GetIntegerParamValue(PUgtfTYqN6V, jnoSgQisLMy, r6rSgjQfV7Z);
					string textParamValue6 = XActionHelper.GetTextParamValue(cZAtfoyUq20, jnoSgQisLMy, r6rSgjQfV7Z);
					int int_2 = (int)XActionHelper.GetIntegerParamValue(mb3tfMe50Bg, jnoSgQisLMy, r6rSgjQfV7Z);
					if (!Enum.TryParse<BitmapLocatePosition>(textParamValue6, out var result))
					{
						r6rSgjQfV7Z.ActionLogger?.LogWarning("不支持的定位点类型：" + textParamValue6);
						r6rSgjQfV7Z.ShowWarning("不支持的定位点类型，已使用左上角定位：" + textParamValue6, jnoSgQisLMy);
						result = BitmapLocatePosition.TopLeft;
					}
					IList<Point> list2 = new List<Point>();
					for (int j = 0; j < num3; j++)
					{
						if (!r6rSgjQfV7Z.IsShouldStopAction())
						{
							foreach (Bitmap item2 in list)
							{
								list2 = KuyJITMYeKp9cJP7KaT.IfmLomYdH25(item2, num, num2, textParamValue4.ToEnum<maP9bQMwejOq3FEOUur>(), rectangle, r6rSgjQfV7Z, int_, result, int_2, true);
								if (list2.HasData())
								{
									break;
								}
							}
							if (list2.HasData())
							{
								break;
							}
							Thread.Sleep(300);
							continue;
						}
						return (isSuccess: false, message: "操作已中止", failReason: r6rSgjQfV7Z.StopFlag);
					}
					if (list2.Count == 0)
					{
						return (isSuccess: false, message: "未在屏幕上找到匹配图片的位置。", failReason: ActionStopFlag.OperationFailed);
					}
					if (r6rSgjQfV7Z.IsDebugging)
					{
						r6rSgjQfV7Z.ActionLogger?.LogInfo($"共找到 {list2.Count} 个位置:" + string.Join(";", list2.Select(_003C_003Ec.O9eSgr4rZ4n ?? (_003C_003Ec.O9eSgr4rZ4n = _003C_003Ec.HvMSgxTn5Vi.s2QSgmhVKDa))));
					}
					foreach (Point item3 in list2)
					{
						ay3tfHuyfgj(item3, ref _003C_003Ec__DisplayClass72_1_);
						if (!string.IsNullOrEmpty(text))
						{
							Dn0SgnbqtuR.Wp3tfG17jav(text, InputSimulator.Instance);
							Thread.Sleep(50);
						}
					}
				}
				finally
				{
					if (textParamValue == "locateByBitmap")
					{
						foreach (Bitmap item4 in list)
						{
							item4.Dispose();
						}
					}
				}
				goto IL_1387;
			}
			case "getMouseOriginPosition":
				if (r6rSgjQfV7Z.TargetInfo != null)
				{
					XActionHelper.OutputResult(_mouseLocationOutput, jnoSgQisLMy, r6rSgjQfV7Z, r6rSgjQfV7Z.TargetInfo.Point.ToValue(), R59Sg4OoZep);
					XActionHelper.OutputResult(_mouseXOutput, jnoSgQisLMy, r6rSgjQfV7Z, r6rSgjQfV7Z.TargetInfo.Point.X, R59Sg4OoZep);
					XActionHelper.OutputResult(_mouseYOutput, jnoSgQisLMy, r6rSgjQfV7Z, r6rSgjQfV7Z.TargetInfo.Point.Y, R59Sg4OoZep);
					goto IL_1387;
				}
				return (isSuccess: false, message: "原始位置坐标为空", failReason: ActionStopFlag.OperationFailed);
			case "getMouseCurrentPosition":
			{
				Point mousePosition = NativeMethods.GetMousePosition();
				XActionHelper.OutputResult(_mouseLocationOutput, jnoSgQisLMy, r6rSgjQfV7Z, mousePosition.ToValue(), R59Sg4OoZep);
				XActionHelper.OutputResult(_mouseXOutput, jnoSgQisLMy, r6rSgjQfV7Z, mousePosition.X, R59Sg4OoZep);
				XActionHelper.OutputResult(_mouseYOutput, jnoSgQisLMy, r6rSgjQfV7Z, mousePosition.Y, R59Sg4OoZep);
				XActionHelper.OutputResultIfNeeded(_cursorTypeOutput, _003C_003Ec.OiaSgpFKnlS ?? (_003C_003Ec.OiaSgpFKnlS = _003C_003Ec.HvMSgxTn5Vi.lRRSgKqLiuP), jnoSgQisLMy, r6rSgjQfV7Z, R59Sg4OoZep);
				goto IL_1387;
			}
			default:
				{
					return (isSuccess: false, message: "不支持的操作类型：" + textParamValue, failReason: ActionStopFlag.OperationFailed);
				}
				IL_1387:
				pDstfsa2tL6(ref _003C_003Ec__DisplayClass72_1_);
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
		}

		internal static bool BMCDxNWGsB1xWOuhHVQl()
		{
			return dKilsQWGmKTPPS19wYZX == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	internal struct _003C_003Ec__DisplayClass72_1
	{
		public Point? ziESg5PRaB1;

		public bool vGISgDE2aCo;
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> bE0tf1k9CvE = new string[3] { "鼠标", "mouse", "click" };

	[CompilerGenerated]
	private readonly string ms2tfbO5r9s = $"fa:{EFontAwesomeIcon.Solid_MousePointer}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> qxctf65IC6u = new StepRunnerCategory[1] { StepRunnerCategory.Input };

	[CompilerGenerated]
	private readonly string eJxtfXUAtMl = "https://getquicker.net/KC/Help/Doc/mouse";

	[CompilerGenerated]
	private readonly bool yMEtfmgl5IY;

	private static readonly StepInParamDef plDtfKIjpLZ;

	private static readonly StepInParamDef oyhtfxS7FMN;

	private static readonly string[] wwYtfriwB1V;

	private static readonly StepInParamDef LJ3tfpYtaC7;

	private static readonly StepInParamDef K5RtfB9iRI4;

	private static readonly StepInParamDef Q7jtfQ48Nrs;

	private static readonly StepInParamDef kS5tfjboxit;

	private static readonly StepInParamDef OD8tfn05rDB;

	private static readonly StepInParamDef CIrtf4mb5cP;

	private static readonly StepInParamDef Mcrtf5bGo4b;

	private static readonly StepInParamDef xsdtfDqeerE;

	private static readonly StepInParamDef SjjtfdLF2ey;

	private static readonly StepInParamDef cZAtfoyUq20;

	private static readonly StepInParamDef PUgtfTYqN6V;

	private static readonly StepInParamDef mb3tfMe50Bg;

	private static readonly StepInParamDef cqjtfARpqm2;

	private static readonly StepInParamDef STvtfOkQ9Px;

	private static readonly StepInParamDef vFPtfFjjKx0;

	private static readonly StepInParamDef bVhtfUT0cAr;

	private static readonly StepInParamDef NgCtfltC4qx;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> QMPtfiyag5Q = new StepInParamDef[19]
	{
		plDtfKIjpLZ, kS5tfjboxit, oyhtfxS7FMN, CIrtf4mb5cP, Mcrtf5bGo4b, xsdtfDqeerE, SjjtfdLF2ey, cZAtfoyUq20, PUgtfTYqN6V, mb3tfMe50Bg,
		cqjtfARpqm2, LJ3tfpYtaC7, K5RtfB9iRI4, Q7jtfQ48Nrs, OD8tfn05rDB, STvtfOkQ9Px, vFPtfFjjKx0, bVhtfUT0cAr, NgCtfltC4qx
	};

	private static readonly StepOutParamDef yeftf34VxRO;

	public static readonly StepOutParamDef _mouseLocationOutput;

	public static readonly StepOutParamDef _mouseXOutput;

	public static readonly StepOutParamDef _mouseYOutput;

	public static readonly StepOutParamDef _cursorTypeOutput;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> UI5tff7wp3x = new StepOutParamDef[5] { yeftf34VxRO, _mouseLocationOutput, _mouseXOutput, _mouseYOutput, _cursorTypeOutput };

	private static MouseInputStep gK4Wl2QYZLkZk2Gr1hFK;

	public string Key => "sys:mouse";

	public string Name => "鼠标输入";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return bE0tf1k9CvE;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return ms2tfbO5r9s;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Basic;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return qxctf65IC6u;
		}
	}

	public string Description => "模拟鼠标输入";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return eJxtfXUAtMl;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return yMEtfmgl5IY;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return QMPtfiyag5Q;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return UI5tff7wp3x;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass72_0 _003C_003Ec__DisplayClass72_ = new _003C_003Ec__DisplayClass72_0();
		_003C_003Ec__DisplayClass72_.jnoSgQisLMy = step;
		_003C_003Ec__DisplayClass72_.r6rSgjQfV7Z = context;
		_003C_003Ec__DisplayClass72_.Dn0SgnbqtuR = this;
		_003C_003Ec__DisplayClass72_.R59Sg4OoZep = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass72_.r6rSgjQfV7Z, _003C_003Ec__DisplayClass72_.jnoSgQisLMy, _003C_003Ec__DisplayClass72_.R59Sg4OoZep, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass72_.sK9SgBrhErD, (Action)null, (Action)null, NgCtfltC4qx, yeftf34VxRO);
	}

	public static CursorEnum GetCursor(IntPtr hCursor)
	{
        int num2 = default;
		if (hCursor == Cursors.AppStarting.Handle)
		{
			return CursorEnum.AppStarting;
		}
		if (hCursor == Cursors.Arrow.Handle)
		{
			return CursorEnum.Arrow;
		}
		if (hCursor == Cursors.Cross.Handle)
		{
			return CursorEnum.Cross;
		}
		if (hCursor == Cursors.IBeam.Handle)
		{
			return CursorEnum.IBeam;
		}
		if (hCursor == Cursors.No.Handle)
		{
			return CursorEnum.No;
		}
		int num;
		if (hCursor == Cursors.SizeAll.Handle)
		{
			num = 0;
			if (!oJmscfQY5rXso9XmMkmf())
			{
				goto IL_013a;
			}
		}
		else
		{
			if (hCursor == Cursors.SizeNESW.Handle)
			{
				return CursorEnum.SizeNESW;
			}
			if (hCursor == Cursors.SizeNS.Handle)
			{
				return CursorEnum.SizeNS;
			}
			if (hCursor == Cursors.SizeNWSE.Handle)
			{
				return CursorEnum.SizeNWSE;
			}
			if (hCursor == Cursors.SizeWE.Handle)
			{
				return CursorEnum.SizeWE;
			}
			if (hCursor == Cursors.UpArrow.Handle)
			{
				return CursorEnum.UpArrow;
			}
			if (hCursor == Cursors.WaitCursor.Handle)
			{
				return CursorEnum.WaitCursor;
			}
			if (hCursor == Cursors.Help.Handle)
			{
				return CursorEnum.Help;
			}
			num = 1;
			if (gK4Wl2QYZLkZk2Gr1hFK != null)
			{
				goto IL_013a;
			}
		}
		goto IL_013e;
		IL_013e:
		num2 = default(int);
		switch (num)
		{
		default:
			return CursorEnum.SizeAll;
		case 1:
			if (hCursor == Cursors.HSplit.Handle)
			{
				return CursorEnum.HSplit;
			}
			if (hCursor == Cursors.VSplit.Handle)
			{
				return CursorEnum.VSplit;
			}
			if (hCursor == Cursors.NoMove2D.Handle)
			{
				return CursorEnum.NoMove2D;
			}
			if (hCursor == Cursors.NoMoveHoriz.Handle)
			{
				return CursorEnum.NoMoveHoriz;
			}
			if (hCursor == Cursors.NoMoveVert.Handle)
			{
				return CursorEnum.NoMoveVert;
			}
			if (hCursor == Cursors.PanEast.Handle)
			{
				return CursorEnum.PanEast;
			}
			if (hCursor == Cursors.PanNE.Handle)
			{
				return CursorEnum.PanNE;
			}
			if (hCursor == Cursors.PanNorth.Handle)
			{
				return CursorEnum.PanNorth;
			}
			if (hCursor == Cursors.PanNW.Handle)
			{
				return CursorEnum.PanNW;
			}
			if (hCursor == Cursors.PanSE.Handle)
			{
				return CursorEnum.PanSE;
			}
			if (hCursor == Cursors.PanSouth.Handle)
			{
				return CursorEnum.PanSouth;
			}
			if (hCursor == Cursors.PanSW.Handle)
			{
				return CursorEnum.PanSW;
			}
			if (hCursor == Cursors.PanWest.Handle)
			{
				return CursorEnum.PanWest;
			}
			if (hCursor == Cursors.Hand.Handle)
			{
				return CursorEnum.Hand;
			}
			if (!(hCursor == (IntPtr)65567))
			{
				num2 = 2;
				goto case 2;
			}
			goto IL_02b4;
		case 2:
			{
				if (!(hCursor == (IntPtr)65569))
				{
					if (!(hCursor == Cursors.Default.Handle))
					{
						return CursorEnum.UNKOWNCURSOR;
					}
					return CursorEnum.Default;
				}
				goto IL_02b4;
			}
			IL_02b4:
			return CursorEnum.Hand;
		}
		IL_013a:
		num = num2;
		goto IL_013e;
	}

	private void JXHtfWluQ1j(ActionExecuteContext actionExecuteContext_0, int int_0, int int_1, string string_3, InputSimulator inputSimulator_0, bool bool_1)
	{
		Point mousePosition = NativeMethods.GetMousePosition();
		Point pt = new Point(mousePosition.X + int_0, mousePosition.Y + int_1);
		AppHelper.MoveCursorTo(pt, bool_1);
		if (actionExecuteContext_0.IsDebugging)
		{
			actionExecuteContext_0.ActionLogger?.LogInfo($"移动距离{int_0},{int_1} 目标位置：{pt.X},{pt.Y}");
		}
		Wp3tfG17jav(string_3, inputSimulator_0);
	}

	private void pmxtfkC4Ur5(ActionExecuteContext actionExecuteContext_0, string string_3, InputSimulator inputSimulator_0, bool bool_1)
	{
		actionExecuteContext_0.ActionLogger.LogInfo("还原鼠标位置");
		if (actionExecuteContext_0.TargetInfo != null)
		{
			AppHelper.MoveCursorTo(actionExecuteContext_0.TargetInfo.Point, bool_1);
			if (actionExecuteContext_0.IsDebugging)
			{
				actionExecuteContext_0.ActionLogger?.LogInfo($"坐标：{actionExecuteContext_0.TargetInfo.Point.X},{actionExecuteContext_0.TargetInfo.Point.Y}");
			}
		}
		else
		{
			IActionLogger actionLogger = actionExecuteContext_0.ActionLogger;
			if (actionLogger != null)
			{
				actionLogger.LogWarning("原始位置坐标为空");
				int num = 0;
				if (gK4Wl2QYZLkZk2Gr1hFK != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
		}
		Wp3tfG17jav(string_3, inputSimulator_0);
	}

	private void Wp3tfG17jav(string string_3, InputSimulator inputSimulator_0)
	{
		switch (string_3)
		{
		case "middle":
			inputSimulator_0.Mouse.MiddleButtonClick();
			break;
		case "leftDbClick":
			inputSimulator_0.Mouse.LeftButtonDoubleClick();
			break;
		case "right":
			inputSimulator_0.Mouse.RightButtonClick();
			break;
		case "left":
			inputSimulator_0.Mouse.LeftButtonClick();
			break;
		}
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDirectValue(plDtfKIjpLZ, step) + "   " + XActionHelper.GetParamDisplayString(vFPtfFjjKx0, step);
	}

	static MouseInputStep()
	{
		plDtfKIjpLZ = new StepInParamDef
		{
			Key = "type",
			Name = "类型",
			Description = "操作类型",
			IsRequired = true,
			Type = VarType.Enum,
			DefaultValue = "restore",
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("restore", "还原鼠标位置"),
				new SelectionItem("move", "移动距离"),
				new SelectionItem("moveTo", "移动到(x,y分别指定)"),
				new SelectionItem("moveToXy", "移动到(x,y一同指定)"),
				new SelectionItem("click", "单击"),
				new SelectionItem("dbclick", "双击"),
				new SelectionItem("down", "按下"),
				new SelectionItem("up", "抬起"),
				new SelectionItem("scroll", "滚动"),
				new SelectionItem("ctrlDown", "按下Ctrl"),
				new SelectionItem("ctrlUp", "松开Ctrl"),
				new SelectionItem("shiftDown", "按下Shift"),
				new SelectionItem("shiftUp", "松开Shift"),
				new SelectionItem("toWinTL", "移动到窗口位置：相对于窗口左上角"),
				new SelectionItem("toWinTR", "移动到窗口位置：相对于窗口右上角"),
				new SelectionItem("toWinBL", "移动到窗口位置：相对于窗口左下角"),
				new SelectionItem("toWinBR", "移动到窗口位置：相对于窗口右下角"),
				new SelectionItem("toWinCenter", "移动到窗口位置：窗口中心"),
				new SelectionItem("moveToWinXy", "移动到窗口位置：xy一同指定"),
				new SelectionItem("locateByBitmap", "移动到位图位置(图片文件)"),
				new SelectionItem("locateByBitmapVar", "移动到位图位置(图片变量)"),
				new SelectionItem("getMouseOriginPosition", "获取鼠标位置(弹出面板前位置)"),
				new SelectionItem("getMouseCurrentPosition", "获取鼠标位置及指针类型(当前位置)"),
				new SelectionItem("showIndicator", "显示鼠标位置提示")
			},
			IsControlField = true
		};
		oyhtfxS7FMN = new StepInParamDef
		{
			Key = "btn",
			Name = "按钮",
			Description = "操作哪个按钮",
			IsRequired = true,
			Type = VarType.Enum,
			DefaultValue = "left",
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("left", "左键"),
				new SelectionItem("right", "右键"),
				new SelectionItem("middle", "中键"),
				new SelectionItem("x1", "X1"),
				new SelectionItem("x2", "X2")
			},
			ValidForList = new List<string> { "click", "dbclick", "down", "up" }
		};
		wwYtfriwB1V = new string[10] { "move", "moveTo", "scroll", "toWinTL", "toWinTR", "toWinBL", "toWinBR", "toWinCenter", "locateByBitmap", "locateByBitmapVar" };
		LJ3tfpYtaC7 = new StepInParamDef
		{
			Key = "x",
			Name = "X",
			Description = "水平方向的坐标/坐标偏移/移动距离(像素) 或 滚动数量（clicks。正值向右，负值向左）",
			IsRequired = true,
			Type = VarType.Integer,
			DefaultValue = 0,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = wwYtfriwB1V
		};
		K5RtfB9iRI4 = new StepInParamDef
		{
			Key = "y",
			Name = "Y",
			Description = "垂直方向的坐标/坐标偏移/移动距离 或 滚动数量（clicks。正值向前，负值向后）",
			IsRequired = true,
			Type = VarType.Integer,
			DefaultValue = 0,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = wwYtfriwB1V
		};
		Q7jtfQ48Nrs = new StepInParamDef
		{
			Key = "xy",
			Name = "坐标",
			Description = "格式为：x,y，如：100,200。也可以使用百分比表示，如：50%,50% 表示屏幕中心。",
			IsRequired = true,
			Type = VarType.Text,
			DefaultValue = "",
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "moveToXy" },
			TextTools = new List<TextToolType> { TextToolType.SelectLocationPoint }
		};
		kS5tfjboxit = new StepInParamDef
		{
			Key = "hWnd",
			Name = "窗口句柄",
			Description = "目标窗口的句柄。留空或 0 表示操作前台窗口。",
			DefaultValue = null,
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Integer,
			ValidForList = new string[6] { "toWinTL", "toWinTR", "toWinBL", "toWinBR", "toWinCenter", "moveToWinXy" }
		};
		OD8tfn05rDB = new StepInParamDef
		{
			Key = "xyForWin",
			Name = "相对坐标",
			Description = "格式为：x,y，如：100,200（相对于窗口左上角向右100，向下200）。也可以使用百分比表示，如：50%,50% 表示窗口中心。",
			IsRequired = true,
			Type = VarType.Text,
			DefaultValue = "",
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "moveToWinXy" },
			TextTools = new List<TextToolType> { TextToolType.SelectRelativePoint }
		};
		CIrtf4mb5cP = new StepInParamDef
		{
			Key = "bmp",
			Name = "位图路径",
			Description = "需要在屏幕中查找的位图路径。位图必须和屏幕图像完全匹配，不能压缩。此时X、Y的值为相对于搜索位图的左上角的偏移。",
			IsRequired = true,
			Type = VarType.Text,
			DefaultValue = "",
			IsMultiLine = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[1] { "locateByBitmap" },
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
		Mcrtf5bGo4b = new StepInParamDef
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
		xsdtfDqeerE = new StepInParamDef
		{
			Key = "bmpTargetType",
			Name = "查找范围",
			Description = "位图查找范围",
			Type = VarType.Enum,
			DefaultValue = "MainScreen",
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("MainScreen", "主屏幕"),
				new SelectionItem("CurrentWindow", "当前窗口"),
				new SelectionItem("Rect", "坐标范围"),
				new SelectionItem(maP9bQMwejOq3FEOUur.AllScreens.ToString(), "所有屏幕")
			},
			ValidForList = new List<string> { "locateByBitmap", "locateByBitmapVar" }
		};
		SjjtfdLF2ey = new StepInParamDef
		{
			Key = "searchRect",
			Name = "查找坐标范围",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			Description = "当“查找范围”为“坐标范围”时有效，格式为：left,top,right,bottom",
			ValidForList = new List<string> { "locateByBitmap", "locateByBitmapVar" },
			TextTools = new List<TextToolType> { TextToolType.SelectLocationArea },
			ReplaceMode = TextToolsReplaceMode.ReplaceAll
		};
		cZAtfoyUq20 = new StepInParamDef
		{
			Key = "bmpPosition",
			Name = "定位位置",
			Description = "查找到图片后，鼠标指针移动到的位置",
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
			ValidForList = new List<string> { "locateByBitmap", "locateByBitmapVar" }
		};
		PUgtfTYqN6V = new StepInParamDef
		{
			Key = "bmpColorError",
			Name = "颜色容差",
			Description = "匹配像素时允许每个颜色通道的偏差值0-100，0表示精确匹配，速度最快。",
			Type = VarType.Integer,
			DefaultValue = 10,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "locateByBitmap", "locateByBitmapVar" }
		};
		mb3tfMe50Bg = new StepInParamDef
		{
			Key = "maxFindCount",
			Name = "最大匹配数量",
			Description = "找图的最大匹配数量。将对每个查找到的目标执行附加动作。",
			Type = VarType.Integer,
			DefaultValue = 1,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "locateByBitmap", "locateByBitmapVar" }
		};
		cqjtfARpqm2 = new StepInParamDef
		{
			Key = "retryCount",
			Name = "重试次数",
			Description = "未找到位图时的重试次数。每次重试间隔300ms。",
			Type = VarType.Integer,
			DefaultValue = 1,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "locateByBitmap", "locateByBitmapVar" }
		};
		STvtfOkQ9Px = new StepInParamDef
		{
			Key = "slowMove",
			Name = "逐渐移动到目标",
			Description = "逐渐移动而不是直接移动到目标位置。",
			Type = VarType.Boolean,
			DefaultValue = false,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string>
			{
				"move", "moveTo", "toWinTL", "toWinTR", "toWinBL", "toWinBR", "toWinCenter", "locateByBitmap", "locateByBitmapVar", "moveToXy",
				"moveToWinXy"
			}
		};
		vFPtfFjjKx0 = new StepInParamDef
		{
			Key = "extAction",
			Name = "移动后操作",
			Description = "移动位置后，需要执行的动作",
			IsRequired = true,
			Type = VarType.Enum,
			DefaultValue = "none",
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("none", "无"),
				new SelectionItem("left", "左键单击"),
				new SelectionItem("leftDbClick", "左键双击"),
				new SelectionItem("right", "右键单击"),
				new SelectionItem("middle", "中键单击")
			},
			ValidForList = new List<string>
			{
				"restore", "move", "moveTo", "toWinTL", "toWinTR", "toWinBL", "toWinBR", "toWinCenter", "locateByBitmap", "locateByBitmapVar",
				"moveToXy", "moveToWinXy"
			}
		};
		bVhtfUT0cAr = new StepInParamDef
		{
			Key = "restoreMousePos",
			Name = "操作完成后恢复鼠标位置",
			DefaultValue = false,
			Description = "",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string>
			{
				"move", "moveTo", "toWinTL", "toWinTR", "toWinBL", "toWinBR", "toWinCenter", "locateByBitmap", "locateByBitmapVar", "moveToXy",
				"moveToWinXy"
			}
		};
		NgCtfltC4qx = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后中止动作",
			DefaultValue = true,
			Description = "获取位置失败后，是否停止后续动作的执行。",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "locateByBitmap", "locateByBitmapVar" }
		};
		yeftf34VxRO = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "找图定位是否成功",
			Description = "",
			Type = VarType.Boolean,
			ValidForList = new string[2] { "locateByBitmap", "locateByBitmapVar" }
		};
		_mouseLocationOutput = new StepOutParamDef
		{
			Key = "mouseLocation",
			Name = "鼠标位置",
			Description = "格式为X,Y的文本",
			Type = VarType.Text,
			ValidForList = new List<string> { "getMouseCurrentPosition", "getMouseOriginPosition", "getCaretPosition" }
		};
		_mouseXOutput = new StepOutParamDef
		{
			Key = "mouseX",
			Name = "鼠标位置X",
			Description = "鼠标位置X坐标",
			Type = VarType.Integer,
			ValidForList = new List<string> { "getMouseCurrentPosition", "getMouseOriginPosition", "getCaretPosition" }
		};
		_mouseYOutput = new StepOutParamDef
		{
			Key = "mouseY",
			Name = "鼠标位置Y",
			Description = "鼠标位置Y坐标",
			Type = VarType.Integer,
			ValidForList = new List<string> { "getMouseCurrentPosition", "getMouseOriginPosition", "getCaretPosition" }
		};
		_cursorTypeOutput = new StepOutParamDef
		{
			Key = "cursorType",
			Name = "光标类型",
			Description = "当前的鼠标指针形状类型",
			Type = VarType.Text,
			ValidForList = new string[1] { "getMouseCurrentPosition" }
		};
	}

	[CompilerGenerated]
	internal static void pDstfsa2tL6(ref _003C_003Ec__DisplayClass72_1 _003C_003Ec__DisplayClass72_1_0)
	{
		if (_003C_003Ec__DisplayClass72_1_0.ziESg5PRaB1.HasValue)
		{
			Cursor.Position = _003C_003Ec__DisplayClass72_1_0.ziESg5PRaB1.Value;
		}
	}

	[CompilerGenerated]
	internal static void ay3tfHuyfgj(Point point_0, ref _003C_003Ec__DisplayClass72_1 _003C_003Ec__DisplayClass72_1_0)
	{
		AppHelper.MoveCursorTo(point_0, _003C_003Ec__DisplayClass72_1_0.vGISgDE2aCo);
	}

	internal static bool oJmscfQY5rXso9XmMkmf()
	{
		return gK4Wl2QYZLkZk2Gr1hFK == null;
	}
}
