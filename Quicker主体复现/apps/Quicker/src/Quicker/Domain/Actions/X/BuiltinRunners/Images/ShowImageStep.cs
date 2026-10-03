using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media.Imaging;
using FontAwesome5;
using GuvA3OiyFyyWpKJlb8c;
using HandyControl.Tools;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Modules.TextTools;
using Quicker.Public.Actions;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Images;
using Quicker.Utilities.Win32;
using Quicker.View;
using SCyJThYoNMQE7IHLXbA;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Images;

public class ShowImageStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass62_0
	{
		public ActionStep wPhSRin8VvJ;

		public ActionExecuteContext VfkSR3XK8IW;

		public XAction IyaSRfXIh6f;

		private static _003C_003Ec__DisplayClass62_0 IDLy9NWaXCi4cHUbPGYr;

		internal (bool isSuccess, string message, ActionStopFlag failReason) jgbSRlFjLJO()
		{
			_003C_003Ec__DisplayClass62_1 _003C_003Ec__DisplayClass62_ = new _003C_003Ec__DisplayClass62_1
			{
				UicSqVjEm4P = this,
				QA3SqvYgJEK = XActionHelper.GetTextParamValue(nAugaoOhSbc, wPhSRin8VvJ, VfkSR3XK8IW),
				OCiSqLpLkga = XActionHelper.GetTextParamValue(fXEgaOrwALS, wPhSRin8VvJ, VfkSR3XK8IW)
			};
			if (_003C_003Ec__DisplayClass62_.QA3SqvYgJEK == "closeWindow")
			{
				AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass62_.JRhSRzx1ry8);
				return (isSuccess: true, message: "关闭窗口", failReason: ActionStopFlag.NoStop);
			}
			if (_003C_003Ec__DisplayClass62_.QA3SqvYgJEK == "getState")
			{
				_003C_003Ec__DisplayClass62_2 _003C_003Ec__DisplayClass62_2 = new _003C_003Ec__DisplayClass62_2
				{
					kc0SqWS7xYq = _003C_003Ec__DisplayClass62_,
					wcbSqYOgIZB = IntPtr.Zero,
					Gt9SqIfpr2M = ""
				};
				AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass62_2.z4SSqZeTOZ5);
				XActionHelper.OutputResultIfNeeded(_isExistsParamDef, _003C_003Ec__DisplayClass62_2.VOMSq9b73wM, wPhSRin8VvJ, VfkSR3XK8IW, IyaSRfXIh6f);
				XActionHelper.OutputResultIfNeeded(_HWndOutParamDef, _003C_003Ec__DisplayClass62_2.rT6Sqhejojk, wPhSRin8VvJ, VfkSR3XK8IW, IyaSRfXIh6f);
				XActionHelper.OutputResultIfNeeded(_FinalPositionParamDef, _003C_003Ec__DisplayClass62_2.YrrSqetwnoc, wPhSRin8VvJ, VfkSR3XK8IW, IyaSRfXIh6f);
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
			if (_003C_003Ec__DisplayClass62_.QA3SqvYgJEK == "getImageWindows")
			{
				_003C_003Ec__DisplayClass62_3 _003C_003Ec__DisplayClass62_3 = new _003C_003Ec__DisplayClass62_3
				{
					J4TSqGqIHxN = new List<string>()
				};
				AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass62_3.Wk3SqkpwNe3);
				XActionHelper.OutputResult(_windowList, wPhSRin8VvJ, VfkSR3XK8IW, _003C_003Ec__DisplayClass62_3.J4TSqGqIHxN, IyaSRfXIh6f);
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
			_003C_003Ec__DisplayClass62_.YMxSqag2QRd = XActionHelper.GetBooleanParamValue(Rs5ga3HJ97D, wPhSRin8VvJ, VfkSR3XK8IW);
			_003C_003Ec__DisplayClass62_.jl4SqJ6qTeh = XActionHelper.GetBooleanParamValue(FOTgaf2J0fu, wPhSRin8VvJ, VfkSR3XK8IW);
			_003C_003Ec__DisplayClass62_.OFrSq0Svrvs = XActionHelper.GetBooleanParamValue(m3ogazxcWlC, wPhSRin8VvJ, VfkSR3XK8IW);
			_003C_003Ec__DisplayClass62_.tAPSqCcfDF2 = XActionHelper.GetBooleanParamValue(FLeg7wQMiOF, wPhSRin8VvJ, VfkSR3XK8IW);
			_003C_003Ec__DisplayClass62_.XYaSqqXPwnE = XActionHelper.GetBooleanParamValue(mMLg7teluk5, wPhSRin8VvJ, VfkSR3XK8IW);
			_003C_003Ec__DisplayClass62_.e2sSqEUICvg = XActionHelper.GetBooleanParamValue(xW2g7gvojVu, wPhSRin8VvJ, VfkSR3XK8IW);
			_003C_003Ec__DisplayClass62_.TDiSq8BqeFA = XActionHelper.GetTextParamValue(Jt7g7Lvhd5R, wPhSRin8VvJ, VfkSR3XK8IW);
			_003C_003Ec__DisplayClass62_.ugeSqyaf42O = XActionHelper.GetTextParamValue(ujXg7vBIQjf, wPhSRin8VvJ, VfkSR3XK8IW);
			_003C_003Ec__DisplayClass62_.M5ASqPiLy00 = XActionHelper.GetNumberParamValue(J2JgaU9YbeN, wPhSRin8VvJ, VfkSR3XK8IW);
			_003C_003Ec__DisplayClass62_.M5ASqPiLy00 = Math.Min(1.0, Math.Max(0.0, _003C_003Ec__DisplayClass62_.M5ASqPiLy00));
			string textParamValue = XActionHelper.GetTextParamValue(n4hgalL6jRu, wPhSRin8VvJ, VfkSR3XK8IW);
			_003C_003Ec__DisplayClass62_.CdpSqSM5AND = ShowWindowLocation.CenterScreen;
			if (!Enum.TryParse<ShowWindowLocation>(textParamValue, out _003C_003Ec__DisplayClass62_.CdpSqSM5AND))
			{
				_003C_003Ec__DisplayClass62_.CdpSqSM5AND = ShowWindowLocation.CenterScreen;
			}
			_003C_003Ec__DisplayClass62_.FWxSq25Wgfd = XActionHelper.GetTextParamValue(mQUgailC2UH, wPhSRin8VvJ, VfkSR3XK8IW);
			_003C_003Ec__DisplayClass62_.cr3Squh09sx = Convert.ToDouble(XActionHelper.GetNumberParamValue(oemgaAwtiEB, wPhSRin8VvJ, VfkSR3XK8IW));
			_003C_003Ec__DisplayClass62_.siKSqNEenV3 = Convert.ToDouble(XActionHelper.GetNumberParamValue(olRgaFrLxN4, wPhSRin8VvJ, VfkSR3XK8IW));
			_003C_003Ec__DisplayClass62_.z8QSq7tn5tJ = false;
			_003C_003Ec__DisplayClass62_.P1FSqcHIkjZ = IntPtr.Zero;
			_003C_003Ec__DisplayClass62_.VPiSqRJV1ZO = "";
			AppState.HS2taepcAbc().Dispatcher?.Invoke(_003C_003Ec__DisplayClass62_.i00SqwB8xP7);
			if (_003C_003Ec__DisplayClass62_.P1FSqcHIkjZ != IntPtr.Zero)
			{
				XActionHelper.OutputResultIfNeeded(_HWndOutParamDef, _003C_003Ec__DisplayClass62_.p0MSqt0ZOSD, wPhSRin8VvJ, VfkSR3XK8IW, IyaSRfXIh6f);
			}
			if (_003C_003Ec__DisplayClass62_.YMxSqag2QRd)
			{
				while (!_003C_003Ec__DisplayClass62_.z8QSq7tn5tJ)
				{
					if (!VfkSR3XK8IW.IsShouldStopAction())
					{
						Thread.Sleep(20);
						continue;
					}
					return (isSuccess: false, message: "", failReason: ActionStopFlag.UserCancel);
				}
				XActionHelper.OutputResultIfNeeded(_FinalPositionParamDef, _003C_003Ec__DisplayClass62_.ntsSqgUR2v9, wPhSRin8VvJ, VfkSR3XK8IW, IyaSRfXIh6f);
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool og88faWa2PrXoaRn867a()
		{
			return IDLy9NWaXCi4cHUbPGYr == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass62_1
	{
		public string OCiSqLpLkga;

		public string QA3SqvYgJEK;

		public ShowWindowLocation CdpSqSM5AND;

		public string FWxSq25Wgfd;

		public double cr3Squh09sx;

		public double siKSqNEenV3;

		public bool jl4SqJ6qTeh;

		public bool OFrSq0Svrvs;

		public bool tAPSqCcfDF2;

		public double M5ASqPiLy00;

		public bool e2sSqEUICvg;

		public string ugeSqyaf42O;

		public string TDiSq8BqeFA;

		public bool YMxSqag2QRd;

		public bool z8QSq7tn5tJ;

		public string VPiSqRJV1ZO;

		public bool XYaSqqXPwnE;

		public IntPtr P1FSqcHIkjZ;

		public _003C_003Ec__DisplayClass62_0 UicSqVjEm4P;

		private static _003C_003Ec__DisplayClass62_1 AjOG31WanTrUddgLRlNB;

		internal void JRhSRzx1ry8()
		{
			SKMgaQxFe03(OCiSqLpLkga);
		}

		internal void i00SqwB8xP7()
		{
			string text = null;
			BitmapSource bitmapSource = null;
			int num = 5;
			if (!VGh7tjWaes10WkDeSEQv())
			{
				goto IL_03a2;
			}
			goto IL_040f;
			IL_03a2:
			int num2 = default(int);
			num = num2;
			goto IL_040f;
			IL_040f:
			_003C_003Ec__DisplayClass62_4 _003C_003Ec__DisplayClass62_ = default(_003C_003Ec__DisplayClass62_4);
			BitmapImage bitmapImage = default(BitmapImage);
			string text2 = default(string);
			while (true)
			{
				switch (num)
				{
				case 7:
					if (bitmapSource != null)
					{
						_003C_003Ec__DisplayClass62_ = new _003C_003Ec__DisplayClass62_4
						{
							U92Sq1nZeV8 = this
						};
						if (!string.IsNullOrEmpty(OCiSqLpLkga))
						{
							SKMgaQxFe03(OCiSqLpLkga);
						}
						_003C_003Ec__DisplayClass62_.pYnSqHorRnW = new ImageViewerWindow(bitmapSource);
						_003C_003Ec__DisplayClass62_.pYnSqHorRnW.ImageFilePath = ((text == null || text.StartsWith("http", StringComparison.OrdinalIgnoreCase)) ? null : text);
						_003C_003Ec__DisplayClass62_.pYnSqHorRnW.Location = CdpSqSM5AND;
						_003C_003Ec__DisplayClass62_.pYnSqHorRnW.Position = FWxSq25Wgfd;
						_003C_003Ec__DisplayClass62_.pYnSqHorRnW.InitialScale = cr3Squh09sx;
						_003C_003Ec__DisplayClass62_.pYnSqHorRnW.AutoCloseSeconds = siKSqNEenV3;
						_003C_003Ec__DisplayClass62_.pYnSqHorRnW.AutoCloseKey = OCiSqLpLkga;
						_003C_003Ec__DisplayClass62_.pYnSqHorRnW.ShowDropShadow = jl4SqJ6qTeh;
						_003C_003Ec__DisplayClass62_.pYnSqHorRnW.ShowInTaskbar = OFrSq0Svrvs;
						goto case 6;
					}
					AppHelper.ShowWarning("没有要显示的图片。");
					return;
				case 6:
					_003C_003Ec__DisplayClass62_.pYnSqHorRnW.Topmost = tAPSqCcfDF2;
					_003C_003Ec__DisplayClass62_.pYnSqHorRnW.Opacity = M5ASqPiLy00;
					_003C_003Ec__DisplayClass62_.pYnSqHorRnW.CloseAfterLostFocus = e2sSqEUICvg;
					_003C_003Ec__DisplayClass62_.pYnSqHorRnW.CloseCallbackParam = ugeSqyaf42O;
					goto case 2;
				case 2:
					_003C_003Ec__DisplayClass62_.pYnSqHorRnW.ActionItem = UicSqVjEm4P.VfkSR3XK8IW.Action;
					_003C_003Ec__DisplayClass62_.pYnSqHorRnW.ActionContext = UicSqVjEm4P.VfkSR3XK8IW;
					if (!string.IsNullOrEmpty(TDiSq8BqeFA))
					{
						_003C_003Ec__DisplayClass62_.pYnSqHorRnW.ToolTip = TDiSq8BqeFA;
					}
					if (UicSqVjEm4P.VfkSR3XK8IW.ParentWindow.zmGvuiv40H0())
					{
						_003C_003Ec__DisplayClass62_.pYnSqHorRnW.Owner = UicSqVjEm4P.VfkSR3XK8IW.ParentWindow;
					}
					if (YMxSqag2QRd)
					{
						_003C_003Ec__DisplayClass62_.pYnSqHorRnW.Closed += _003C_003Ec__DisplayClass62_.bpxSqsTlI59;
						_003C_003Ec__DisplayClass62_.pYnSqHorRnW.V6hgjEnp8ZH(UicSqVjEm4P.VfkSR3XK8IW.CancellationToken);
					}
					_003C_003Ec__DisplayClass62_.pYnSqHorRnW.ShowActivated = !XYaSqqXPwnE;
					_003C_003Ec__DisplayClass62_.pYnSqHorRnW.Show();
					if (!XYaSqqXPwnE)
					{
						_003C_003Ec__DisplayClass62_.pYnSqHorRnW.Activate();
					}
					P1FSqcHIkjZ = new WindowInteropHelper(_003C_003Ec__DisplayClass62_.pYnSqHorRnW).Handle;
					num = 0;
					if (!VGh7tjWaes10WkDeSEQv())
					{
						continue;
					}
					return;
				case 5:
					if (QA3SqvYgJEK.Equals("var", StringComparison.OrdinalIgnoreCase))
					{
						string imgFilePath;
						Image imageParamValue = XActionHelper.GetImageParamValue(HqGgaMhBjan, UicSqVjEm4P.wPhSRin8VvJ, UicSqVjEm4P.VfkSR3XK8IW, out imgFilePath);
						text = imgFilePath;
						if (imageParamValue == null)
						{
							AppHelper.ShowWarning("图片不存在！");
							return;
						}
						if (imageParamValue is Bitmap)
						{
							bitmapSource = ImageHelper.BitmapToBitmapSource(imageParamValue as Bitmap);
						}
						else
						{
							using Bitmap bitmap = new Bitmap(imageParamValue);
							bitmapSource = ImageHelper.BitmapToBitmapSource(bitmap);
						}
					}
					else
					{
						if (QA3SqvYgJEK.Equals("file", StringComparison.OrdinalIgnoreCase))
						{
							break;
						}
						if (QA3SqvYgJEK.Equals("clipboard", StringComparison.OrdinalIgnoreCase))
						{
							goto case 3;
						}
					}
					goto case 7;
				case 3:
					if (Clipboard.ContainsImage())
					{
						bitmapSource = ImageHelper.BitmapToBitmapSource(ImageClipboardHelper.GetImageFromClipboard());
						goto case 7;
					}
					AppHelper.ShowWarning("剪贴板中没有图片！");
					return;
				case 4:
					bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
					bitmapImage.UriSource = new Uri(text2);
					bitmapImage.EndInit();
					if (bitmapImage.CanFreeze)
					{
						bitmapImage.Freeze();
					}
					bitmapSource = bitmapImage;
					goto case 7;
				default:
					return;
				case 1:
					AppHelper.ShowWarning("没有要显示的图片！");
					return;
				case 0:
					return;
				}
				text2 = XActionHelper.GetTextParamValue(bwkgaTQKmuw, UicSqVjEm4P.wPhSRin8VvJ, UicSqVjEm4P.VfkSR3XK8IW);
				text = text2;
				if (string.IsNullOrEmpty(text2))
				{
					num = 1;
					if (AjOG31WanTrUddgLRlNB != null)
					{
						break;
					}
					continue;
				}
				text2 = PathHelper.RemoveZeroWidthChar(text2);
				if (text2[1] == ':' && Path.IsPathRooted(text2) && System.IO.File.Exists(text2))
				{
					bitmapSource = ImageHelper.LoadBitmapImageFromFile(text2);
					num = 7;
					if (AjOG31WanTrUddgLRlNB != null)
					{
						break;
					}
					continue;
				}
				bitmapImage = new BitmapImage();
				bitmapImage.BeginInit();
				bitmapImage.CreateOptions = BitmapCreateOptions.IgnoreColorProfile;
				num = 4;
				if (!VGh7tjWaes10WkDeSEQv())
				{
					break;
				}
			}
			goto IL_03a2;
		}

		internal object p0MSqt0ZOSD()
		{
			return (long)P1FSqcHIkjZ;
		}

		internal object ntsSqgUR2v9()
		{
			return VPiSqRJV1ZO;
		}

		internal static void M7rENSWaDVLmnbLfZjeR()
		{
		}

		internal static bool VGh7tjWaes10WkDeSEQv()
		{
			return AjOG31WanTrUddgLRlNB == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass62_2
	{
		public IntPtr wcbSqYOgIZB;

		public string Gt9SqIfpr2M;

		public _003C_003Ec__DisplayClass62_1 kc0SqWS7xYq;

		internal static _003C_003Ec__DisplayClass62_2 aXaWHgWa0gpSPmDt1ewd;

		internal void z4SSqZeTOZ5()
		{
			Window window = WLcgajFZ1he(kc0SqWS7xYq.OCiSqLpLkga);
			if (window == null)
			{
				return;
			}
			wcbSqYOgIZB = window.GetHandle();
			ImageViewerWindow obj = window as ImageViewerWindow;
			object obj2;
			if (obj == null)
			{
				obj2 = null;
			}
			else
			{
				obj2 = obj.FinalPosition;
				if (obj2 != null)
				{
					goto IL_0040;
				}
			}
			obj2 = "";
			goto IL_0040;
			IL_0040:
			Gt9SqIfpr2M = (string)obj2;
		}

		internal object VOMSq9b73wM()
		{
			return wcbSqYOgIZB != IntPtr.Zero;
		}

		internal object rT6Sqhejojk()
		{
			return wcbSqYOgIZB;
		}

		internal object YrrSqetwnoc()
		{
			return Gt9SqIfpr2M;
		}

		internal static bool uhWiy2Wa1oUN2co8Qx7n()
		{
			return aXaWHgWa0gpSPmDt1ewd == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass62_3
	{
		public List<string> J4TSqGqIHxN;

		internal static _003C_003Ec__DisplayClass62_3 sKetUqWaB3FkmZx0bxlQ;

		internal void Wk3SqkpwNe3()
		{
			foreach (ImageViewerWindow item in AppHelper.FindRootWindows<ImageViewerWindow>())
			{
				J4TSqGqIHxN.Add(item.AutoCloseKey);
			}
		}

		internal static bool gFut10Wavp1sIrm066o6()
		{
			return sKetUqWaB3FkmZx0bxlQ == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass62_4
	{
		public ImageViewerWindow pYnSqHorRnW;

		public _003C_003Ec__DisplayClass62_1 U92Sq1nZeV8;

		private static _003C_003Ec__DisplayClass62_4 fJS9kPWaOysv4naqTUEf;

		internal void bpxSqsTlI59(object sender, EventArgs e)
		{
			U92Sq1nZeV8.z8QSq7tn5tJ = true;
			U92Sq1nZeV8.VPiSqRJV1ZO = pYnSqHorRnW.FinalPosition;
		}

		internal static bool OVFQr9WaJaCqMd5FHUUQ()
		{
			return fJS9kPWaOysv4naqTUEf == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> Qv1gan4O6vi = new string[3] { "位图", "picture", "bitmap" };

	[CompilerGenerated]
	private readonly string aRNga4Ffwag = $"fa:{EFontAwesomeIcon.Light_Images}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> Es8ga5qOYVu = new StepRunnerCategory[1] { StepRunnerCategory.Ui };

	[CompilerGenerated]
	private readonly string bjagaDSS98V = "https://getquicker.net/KC/Help/Doc/showImage";

	[CompilerGenerated]
	private readonly bool TAkgadF5JgG;

	private static readonly StepInParamDef nAugaoOhSbc;

	private static readonly StepInParamDef bwkgaTQKmuw;

	private static readonly StepInParamDef HqGgaMhBjan;

	private static readonly StepInParamDef oemgaAwtiEB;

	private static readonly StepInParamDef fXEgaOrwALS;

	private static readonly StepInParamDef olRgaFrLxN4;

	private static readonly StepInParamDef J2JgaU9YbeN;

	private static readonly StepInParamDef n4hgalL6jRu;

	private static readonly StepInParamDef mQUgailC2UH;

	private static readonly StepInParamDef Rs5ga3HJ97D;

	private static readonly StepInParamDef FOTgaf2J0fu;

	private static readonly StepInParamDef m3ogazxcWlC;

	private static readonly StepInParamDef FLeg7wQMiOF;

	private static readonly StepInParamDef mMLg7teluk5;

	private static readonly StepInParamDef xW2g7gvojVu;

	private static readonly StepInParamDef Jt7g7Lvhd5R;

	private static readonly StepInParamDef ujXg7vBIQjf;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> FaFg7SHuRVC = new StepInParamDef[17]
	{
		nAugaoOhSbc, bwkgaTQKmuw, HqGgaMhBjan, oemgaAwtiEB, J2JgaU9YbeN, fXEgaOrwALS, olRgaFrLxN4, n4hgalL6jRu, mQUgailC2UH, Rs5ga3HJ97D,
		FOTgaf2J0fu, m3ogazxcWlC, FLeg7wQMiOF, mMLg7teluk5, xW2g7gvojVu, Jt7g7Lvhd5R, ujXg7vBIQjf
	};

	public static readonly StepOutParamDef _isExistsParamDef;

	public static readonly StepOutParamDef _HWndOutParamDef;

	public static readonly StepOutParamDef _FinalPositionParamDef;

	public static readonly StepOutParamDef _windowList;

	[CompilerGenerated]
	private IList<StepOutParamDef> tbfg72iEvOF = new List<StepOutParamDef> { _isExistsParamDef, _HWndOutParamDef, _FinalPositionParamDef, _windowList };

	private static ShowImageStep EN3vZ8QImXjy9jT93o0E;

	public string Key => "sys:showImage";

	public string Name => "显示图片";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return Qv1gan4O6vi;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return aRNga4Ffwag;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Image;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return Es8ga5qOYVu;
		}
	}

	public string Description => "在屏幕上显示图片。输入文件路径/url或图片变量。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return bjagaDSS98V;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return TAkgadF5JgG;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return FaFg7SHuRVC;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return tbfg72iEvOF;
		}
		[CompilerGenerated]
		set
		{
			tbfg72iEvOF = value;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass62_0 _003C_003Ec__DisplayClass62_ = new _003C_003Ec__DisplayClass62_0();
		_003C_003Ec__DisplayClass62_.wPhSRin8VvJ = step;
		_003C_003Ec__DisplayClass62_.VfkSR3XK8IW = context;
		_003C_003Ec__DisplayClass62_.IyaSRfXIh6f = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass62_.VfkSR3XK8IW, _003C_003Ec__DisplayClass62_.wPhSRin8VvJ, _003C_003Ec__DisplayClass62_.IyaSRfXIh6f, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass62_.jgbSRlFjLJO, (Action)null, (Action)null, (StepInParamDef)null, (StepOutParamDef)null);
	}

	private static void SKMgaQxFe03(string string_2)
	{
		foreach (ImageViewerWindow item in AppHelper.FindRootWindows<ImageViewerWindow>())
		{
			if ((item.AutoCloseKey == string_2 || (string.IsNullOrEmpty(string_2) && item.AutoCloseKey.StartsWith("AUTO_", StringComparison.OrdinalIgnoreCase))) && item.IsLoaded)
			{
				try
				{
					item.Close();
				}
				catch (Exception exception)
				{
					AppHelper.ShowWarning("关闭前序窗口出错：" + exception.GetMessageWithInner());
				}
			}
		}
	}

	private static Window WLcgajFZ1he(string string_2)
	{
		foreach (ImageViewerWindow item in AppHelper.FindRootWindows<ImageViewerWindow>())
		{
			if (item.AutoCloseKey == string_2 && item.IsLoaded)
			{
				return item;
			}
		}
		return null;
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(nAugaoOhSbc, step) + " " + XActionHelper.GetParamDisplayString(bwkgaTQKmuw, step) + XActionHelper.GetParamDisplayString(HqGgaMhBjan, step);
	}

	static ShowImageStep()
	{
		nAugaoOhSbc = new StepInParamDef
		{
			Key = "source",
			Name = "操作/来源",
			DefaultValue = "var",
			Description = "图片来源类型",
			VariableMode = ParamVariableMode.Input,
			Type = VarType.Enum,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("file", "显示：图片文件或网络图片"),
				new SelectionItem("var", "显示：变量中的图片"),
				new SelectionItem("clipboard", "显示：剪贴板图片"),
				new SelectionItem("closeWindow", "关闭图片窗口"),
				new SelectionItem("getState", "获取图片窗口信息"),
				new SelectionItem("getImageWindows", "获取所有图片窗口标识")
			},
			IsControlField = true
		};
		bwkgaTQKmuw = new StepInParamDef
		{
			Key = "path",
			Name = "路径/网址",
			Description = "图片文件的路径或网址。",
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text,
			ValidForList = new List<string> { "file" }
		};
		HqGgaMhBjan = new StepInParamDef
		{
			Key = "imgVar",
			Name = "图片变量",
			Description = "从指定变量中加载图片",
			DefaultValue = "",
			IsRequired = true,
			Type = VarType.Image,
			VariableMode = ParamVariableMode.UseVar,
			ValidForList = new List<string> { "var" }
		};
		oemgaAwtiEB = new StepInParamDef
		{
			Key = "scale",
			Name = "初始缩放比例",
			Description = "可以为小数，1表示原始大小，-1表示对大图自动调整缩放比例",
			DefaultValue = 1,
			IsRequired = true,
			Type = VarType.Number,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "file", "var", "clipboard" }
		};
		fXEgaOrwALS = new StepInParamDef
		{
			Key = "autoCloseKey",
			Name = "唯一性标识",
			Description = "(仅必要时使用)自动关闭之前打开的具有此标识的图片窗口。",
			DefaultValue = "",
			Type = VarType.Text,
			IsRequired = false,
			VariableMode = ParamVariableMode.Input,
			IsMultiLine = false,
			ValidForList = new List<string> { "file", "var", "clipboard", "closeWindow", "getState" }
		};
		olRgaFrLxN4 = new StepInParamDef
		{
			Key = "autoCloseTime",
			Name = "自动关闭时间",
			Description = "几秒后自动关闭，可以为小数。0：不自动关闭。",
			DefaultValue = 0,
			IsRequired = true,
			Type = VarType.Number,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "file", "var", "clipboard" }
		};
		J2JgaU9YbeN = new StepInParamDef
		{
			Key = "opacity",
			Name = "不透明度",
			Description = "0-1之间的小数，1为完全不透明，0为完全透明。",
			DefaultValue = 1,
			IsRequired = true,
			Type = VarType.Number,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "file", "var", "clipboard" }
		};
		n4hgalL6jRu = new StepInParamDef
		{
			Key = "winLocation",
			Name = "显示位置",
			Description = "图片显示位置",
			Type = VarType.Enum,
			DefaultValue = ShowWindowLocation.Auto.ToString(),
			SelectionItems = new SelectionItem[11]
			{
				new SelectionItem(ShowWindowLocation.Auto.ToString(), "自动"),
				new SelectionItem(ShowWindowLocation.CenterScreen.ToString(), "屏幕中间"),
				new SelectionItem(ShowWindowLocation.TopLeft.ToString(), "屏幕左上"),
				new SelectionItem(ShowWindowLocation.TopCenter.ToString(), "屏幕中上"),
				new SelectionItem(ShowWindowLocation.TopRight.ToString(), "屏幕右上"),
				new SelectionItem(ShowWindowLocation.LeftCenter.ToString(), "屏幕左中"),
				new SelectionItem(ShowWindowLocation.RightCenter.ToString(), "屏幕右中"),
				new SelectionItem(ShowWindowLocation.BottomLeft.ToString(), "屏幕左下"),
				new SelectionItem(ShowWindowLocation.BottomCenter.ToString(), "屏幕中下"),
				new SelectionItem(ShowWindowLocation.BottomRight.ToString(), "屏幕右下"),
				new SelectionItem(ShowWindowLocation.Manual.ToString(), "自定义位置")
			},
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "file", "var", "clipboard" }
		};
		mQUgailC2UH = new StepInParamDef
		{
			Key = "winPosition",
			Name = "位置坐标",
			Description = "仅用于位置为“自定义位置”类型。格式为:left,top或left,top,right,bottom",
			Type = VarType.Text,
			DefaultValue = "",
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "file", "var", "clipboard" },
			TextTools = new List<TextToolType> { TextToolType.SelectLocationArea }
		};
		Rs5ga3HJ97D = new StepInParamDef
		{
			Key = "waitClose",
			Name = "等待图片关闭",
			Description = "是否等待图片关闭后再执行后续步骤",
			DefaultValue = false,
			IsRequired = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "file", "var", "clipboard" }
		};
		FOTgaf2J0fu = new StepInParamDef
		{
			Key = "showDropShadow",
			Name = "显示阴影",
			Description = "是否显示边框阴影",
			DefaultValue = true,
			IsRequired = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "file", "var", "clipboard" }
		};
		m3ogazxcWlC = new StepInParamDef
		{
			Key = "showTaskbarIcon",
			Name = "显示任务栏图标",
			Description = "是否显示任务栏图标",
			DefaultValue = true,
			IsRequired = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "file", "var", "clipboard" }
		};
		FLeg7wQMiOF = new StepInParamDef
		{
			Key = "topMost",
			Name = "是否置顶显示",
			Description = "是否置顶显示图片",
			DefaultValue = true,
			IsRequired = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "file", "var", "clipboard" }
		};
		mMLg7teluk5 = new StepInParamDef
		{
			Key = "noActivate",
			Name = "不激活窗口",
			Description = "图片窗口显示时不抢占焦点（无法通过Esc关闭）",
			DefaultValue = false,
			IsRequired = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "file", "var", "clipboard" }
		};
		xW2g7gvojVu = new StepInParamDef
		{
			Key = "closeWhenLostFocus",
			Name = "丢失焦点时自动关闭",
			Description = "",
			DefaultValue = false,
			IsRequired = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "file", "var", "clipboard" }
		};
		Jt7g7Lvhd5R = new StepInParamDef
		{
			Key = "tooltip",
			Name = "ToolTip提示文字",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true,
			ValidForList = new List<string> { "file", "var", "clipboard" },
			IsAdvanced = true
		};
		ujXg7vBIQjf = new StepInParamDef
		{
			Key = "closeCallbackParam",
			Name = "关闭窗口回调参数",
			Description = "关闭图片窗口时，运行当前动作，并传入指定参数。未指定参数时，不进行回调。",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = false,
			ValidForList = new List<string> { "file", "var", "clipboard" },
			IsAdvanced = true
		};
		_isExistsParamDef = new StepOutParamDef
		{
			Key = "isExists",
			Name = "是否存在",
			Description = "是否存在指定标识的窗口",
			Type = VarType.Boolean,
			ValidForList = new List<string> { "getState" }
		};
		_HWndOutParamDef = new StepOutParamDef
		{
			Key = "hwnd",
			Name = "窗口句柄",
			Description = "新创建的图片窗口的句柄",
			Type = VarType.Integer,
			ValidForList = new List<string> { "file", "var", "clipboard", "getState" }
		};
		_FinalPositionParamDef = new StepOutParamDef
		{
			Key = "finalPosition",
			Name = "最终贴图位置",
			Description = "移动窗口后的贴图位置格式为left,top,right,bottom。显示图片（开启“等待图片关闭” 选项）或获取当前打开的图片窗口信息时有效。",
			Type = VarType.Text,
			ValidForList = new List<string> { "file", "var", "clipboard", "getState" }
		};
		_windowList = new StepOutParamDef
		{
			Key = "windowIdList",
			Name = "窗口标识列表",
			Type = VarType.List,
			ValidForList = new string[1] { "getImageWindows" }
		};
	}

	internal static bool oSXtEgQIsgiBr88AH9ml()
	{
		return EN3vZ8QImXjy9jT93o0E == null;
	}

	internal static void MFetKTQIh09clLQsyDjM()
	{
	}
}
