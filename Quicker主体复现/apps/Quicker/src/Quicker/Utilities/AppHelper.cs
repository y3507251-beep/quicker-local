using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Reflection;
using System.Resources;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using cXuiZ7i2m2sRaR7QhhS;
using dkbgyyMixGueocCf9RC;
using eHGj15MUIx8QneCHitQ;
using EOqy55MyMeuU2apYyog;
using f5fV1EMjxQYCEGaKlWD;
using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Definitions;
using FlaUI.UIA3;
using gNDpGkYZYbhLdMnAyKv;
using IgQBbvXMVdsN7GVNUxX;
using JTIh7V5l65QV75A93Ly;
using lGFWOcimK6GZKnFIeLT;
using log4net;
using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;
using N3JZlujw68npkGqT5RD;
using Newtonsoft.Json;
using Ninject;
using Ninject.Parameters;
using nSudn7i77a3JpXIFA0G;
using PInvoke;
using qcrGlGMkgcYtX0leyxF;
using Quicker.Common;
using Quicker.Common.Entities;
using Quicker.Common.Vm;
using Quicker.Common.Vm.Account;
using Quicker.Common.Vm.Share;
using Quicker.Domain;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Extensions;
using Quicker.Domain.PowerKeys;
using Quicker.Domain.Services;
using Quicker.Modules.VersionUpdate;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Settings.Code;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Images;
using Quicker.Utilities.UI;
using Quicker.Utilities.UI.Behaviors;
using Quicker.Utilities.Win32;
using Quicker.View;
using Quicker.View.Controls;
using Quicker.View.Hotkeys;
using Quicker.View.PowerKeys;
using Quicker.View.TextCommands;
using Quicker.View.UI;
using Quicker.View.X;
using ToastNotifications.Core;
using ToastNotifications.Messages;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.UI.Notifications;
using WindowsInput;
using WindowsInput.Native;
using x6MHGwiYv06PXoBFlMe;

namespace Quicker.Utilities;

public static class AppHelper
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec PIS2tP1NWqa;

		public static Predicate<ActionItem> fln2tEVBRVW;

		public static Func<DictionaryEntry, string> r3B2ty1DlAV;

		public static Action<object> Lon2t8MKKHN;

		public static Func<HwndSource, Visual> sRG2taHrSgc;

		public static Func<FrameworkElement, DependencyObject> Upd2t7WJmik;

		public static Func<Popup, bool> dp82tRB1Xxm;

		public static Action DTk2tqL1xd6;

		public static Action b8B2tcI19EU;

		public static Action lBX2tVHepjF;

		public static Func<System.Windows.Window, bool> Mxd2tZTQYFT;

		public static Func<string, bool> EYT2t9L5Bts;

		public static ExecutedRoutedEventHandler OOD2thy60AW;

		public static ExecutedRoutedEventHandler FVU2teQJoWX;

		public static CanExecuteRoutedEventHandler fq32tYm9ubh;

		internal static _003C_003Ec xQQwKyyeJ7yIaPLrQqtf;

		static _003C_003Ec()
		{
			PIS2tP1NWqa = new _003C_003Ec();
		}

		internal bool zkG2wf8WHvN(ActionItem x)
		{
			return x == null;
		}

		internal string H862wz1ArGu(DictionaryEntry entry)
		{
			return (string)entry.Key;
		}

		internal void XUK2twcVT5p(object o)
		{
			NativeMethods.SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, (UIntPtr)uint.MaxValue, (UIntPtr)uint.MaxValue);
		}

		internal Visual Nup2ttcbrMd(HwndSource h)
		{
			return h.RootVisual;
		}

		internal DependencyObject Xuo2tgcIyxG(FrameworkElement f)
		{
			return f.Parent;
		}

		internal bool B8n2tLcmhUs(Popup p)
		{
			return p.IsOpen;
		}

		internal void w1q2tvaOxwV()
		{
			if (string.Equals("onenote", AppState.CurrentProcessName, StringComparison.OrdinalIgnoreCase) && PowerKeysService.IsLeftMouseButtonPressing())
			{
				InputSimulator.Instance.Keyboard.KeyPress(VirtualKeyCode.LMENU);
				Thread.Sleep(5);
				InputSimulator.Instance.Keyboard.KeyPress(VirtualKeyCode.VK_H);
				Thread.Sleep(1);
				InputSimulator.Instance.Keyboard.KeyPress(VirtualKeyCode.VK_C);
				return;
			}
			if (!string.IsNullOrWhiteSpace(AppState.DataService.CpItmVISR7P().CtrlInsertProcesses) && AppState.DataService.CpItmVISR7P().CtrlInsertProcesses.ListStringContains(";", AppState.CurrentProcessName))
			{
				InputSimulator.Instance.Keyboard.ModifiedKeyStroke(VirtualKeyCode.LCONTROL, VirtualKeyCode.INSERT, kPoLTdWFLA7());
				return;
			}
			InputSimulator.Instance.Keyboard.ModifiedKeyStroke(VirtualKeyCode.LCONTROL, VirtualKeyCode.VK_C, kPoLTdWFLA7());
			int num = 0;
			if (xQQwKyyeJ7yIaPLrQqtf != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}

		internal void JOp2tSKSde1()
		{
			if (string.IsNullOrWhiteSpace(AppState.DataService.CpItmVISR7P().CtrlInsertProcesses) || !AppState.DataService.CpItmVISR7P().CtrlInsertProcesses.ListStringContains(";", AppState.CurrentProcessName))
			{
				InputSimulator.Instance.Keyboard.ModifiedKeyStroke(VirtualKeyCode.LCONTROL, VirtualKeyCode.VK_V, kPoLTdWFLA7());
			}
			else
			{
				InputSimulator.Instance.Keyboard.ModifiedKeyStroke(VirtualKeyCode.LSHIFT, VirtualKeyCode.INSERT, kPoLTdWFLA7());
			}
		}

		internal void VKC2t26j3Gc()
		{
			try
			{
				AppState.SQLDataMgr.JoytxFfaSyO();
				(bool, long, long) tuple = AppState.SQLDataMgr.ShrinkFileAsync();
				MessageBoxHelper.Show("已成功释放数据库多余空间。\n原始大小：" + tuple.Item2.GetBytesReadable() + "\n当前大小：" + tuple.Item3.GetBytesReadable());
			}
			catch (Exception exception)
			{
				ShowWarning("缩减数据库大小出错：" + exception.GetMessageWithInner());
			}
		}

		internal bool Uuf2tu4LcbI(System.Windows.Window x)
		{
			return x.IsActive;
		}

		internal bool cyQ2tNSaSN1(string x)
		{
			return string.Equals(x, Environment.MachineName, StringComparison.OrdinalIgnoreCase);
		}

		internal void JwG2tJK1jsg(object sender, ExecutedRoutedEventArgs e)
		{
			TryOpenUrlOrFile((string)e.Parameter);
		}

		internal void oHn2t0wD4VO(object sender, ExecutedRoutedEventArgs e)
		{
			if (sender is System.Windows.Window window)
			{
				window.Close();
			}
		}

		internal void UwK2tCAUPDh(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = true;
		}

		internal static bool cfGZeCyekhR6DPLXHV7q()
		{
			return xQQwKyyeJ7yIaPLrQqtf == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass111_0
	{
		public string EQn2tWIPj7f;

		public string Ada2tkuZTaJ;

		public SettingPageId? Kfc2tGhjL08;

		public System.Windows.Window hkS2tsIRvc6;

		private static _003C_003Ec__DisplayClass111_0 ibsNgdyeuW3Rwrv1IHla;

		internal void Ybm2tIQVXnZ()
		{
			BuyQuickerWindow buyQuickerWindow = new BuyQuickerWindow(EQn2tWIPj7f, Ada2tkuZTaJ, Kfc2tGhjL08);
			buyQuickerWindow.Owner = hkS2tsIRvc6;
			buyQuickerWindow.ShowDialog();
		}

		internal static bool bSixGRyeoF5Euc9g8jOq()
		{
			return ibsNgdyeuW3Rwrv1IHla == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass117_0
	{
		public Action fTY2tbfEBOs;

		internal static _003C_003Ec__DisplayClass117_0 CRM7MLyeb5riUKi9UAbC;

		internal void zrg2tHwixMd()
		{
			try
			{
				fTY2tbfEBOs();
			}
			catch (Exception ex)
			{
				D0cLTzhCMW5.Warn("RunOnUiThread错误：" + ex.Message, ex);
				ShowWarning(ex.Message);
			}
		}

		internal void MDH2t1Bh29P()
		{
			try
			{
				fTY2tbfEBOs();
			}
			catch (Exception ex)
			{
				D0cLTzhCMW5.Warn("RunOnUiThread错误：" + ex.Message, ex);
				ShowWarning(ex.Message);
			}
		}

		internal static bool VCx5Nsyeq0TGixBtDT2r()
		{
			return CRM7MLyeb5riUKi9UAbC == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass123_0
	{
		public string XWX2tmCSsxA;

		public string epN2tKy4cMc;

		internal static _003C_003Ec__DisplayClass123_0 H6mDAyye5XvtZ8YVoxOa;

		internal void ciG2t6fnX5N()
		{
			TryOpenUrlOrFile("https://getquicker.net/changelog?type=Pc&prev=" + XWX2tmCSsxA + "&curr=" + epN2tKy4cMc);
		}

		internal void OWh2tXF3Msh()
		{
			ciG2t6fnX5N();
		}

		internal static bool m072ShyeYywKxEjFeJns()
		{
			return H6mDAyye5XvtZ8YVoxOa == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass132_0
	{
		public ActionItem dn62trBEajm;

		internal static _003C_003Ec__DisplayClass132_0 brAg6JyeRrkUhkjx9g9t;

		internal void sqs2txavwVG()
		{
			if (dn62trBEajm != null && dn62trBEajm.ActionType == ActionType.XAction)
			{
				ActionDesignerWindow actionDesignerWindow = new ActionDesignerWindow(null, dn62trBEajm, false, true);
				actionDesignerWindow.ShowActivated = true;
				actionDesignerWindow.Title = "预览动作:" + dn62trBEajm.Title;
				actionDesignerWindow.Show();
				actionDesignerWindow.Activate();
			}
			else
			{
				ActionEditorWindow actionEditorWindow = AppState.dAntabrFWrV().Get<ActionEditorWindow>(Array.Empty<IParameter>());
				actionEditorWindow.Owner = null;
				actionEditorWindow.IsReadonly = true;
				actionEditorWindow.EditingActionItem = dn62trBEajm;
				actionEditorWindow.ShowActivated = true;
				actionEditorWindow.Title = "预览动作:" + dn62trBEajm.Title;
				actionEditorWindow.Show();
				actionEditorWindow.Activate();
			}
		}

		internal static bool Sl69sAyegKN8Ml4Ihnpm()
		{
			return brAg6JyeRrkUhkjx9g9t == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass133_0
	{
		public ActionItem Gc92tBT5AFm;

		internal static _003C_003Ec__DisplayClass133_0 aEYpcvyeU00TQsPpCM3O;

		internal void Coy2tpJuDl0()
		{
			if (Gc92tBT5AFm != null && Gc92tBT5AFm.ActionType.ContainedIn(ActionType.XAction, ActionType.XSubProgram))
			{
				Gc92tBT5AFm.ActionType = ActionType.XAction;
				ActionDesignerWindow actionDesignerWindow = new ActionDesignerWindow(null, Gc92tBT5AFm, true, true);
				actionDesignerWindow.ShowActivated = true;
				actionDesignerWindow.Title = "预览子程序:" + Gc92tBT5AFm.Title;
				actionDesignerWindow.Show();
				actionDesignerWindow.Activate();
			}
			else
			{
				ShowWarning("不是合法的子程序。");
			}
		}

		internal static bool VhuesCyexxEAJ54qC3V8()
		{
			return aEYpcvyeU00TQsPpCM3O == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	internal struct _003C_003Ec__DisplayClass134_0
	{
		public AutomationElement DDe2tQnQOH6;
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass135_0
	{
		public bool hS02tn88YWC;

		public int YOq2t4iuIx7;

		public int OEC2t5din0s;

		public long uD02tDYWbsm;

		internal static _003C_003Ec__DisplayClass135_0 DgXK6gyemXhIeGHOMMh9;

		internal void BCE2tjyfBYL()
		{
			SendCopyKeys();
			for (int i = 0; i < uD02tDYWbsm + 1L; i++)
			{
				long num = fLiLTj0x4QY();
				while (fLiLTj0x4QY() < num + OEC2t5din0s)
				{
					hS02tn88YWC = AppState.ClipboardSequenceNumber != YOq2t4iuIx7;
					if (hS02tn88YWC)
					{
						break;
					}
					Thread.Sleep(5);
				}
				if (hS02tn88YWC)
				{
					break;
				}
			}
		}

		internal static bool BbvmX9yesJVY0s9OWbFR()
		{
			return DgXK6gyemXhIeGHOMMh9 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass142_0
	{
		public string VTM2tTYDrWp;

		public string WJx2tMbUytp;

		public string LF02tA6mfZE;

		public Action J9a2tO4fUTR;

		public double? lea2tFIcNX4;

		public TypedEventHandler<ToastNotification, object> pya2tUaIUtq;

		private static _003C_003Ec__DisplayClass142_0 v7i4jqye7ex3g86KYhR7;

		internal void yUT2tdNSK29()
		{
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Expected O, but got Unknown
			int num;
			int num2;
			if (!string.IsNullOrEmpty(VTM2tTYDrWp) && File.Exists(VTM2tTYDrWp))
			{
				num = ((!VTM2tTYDrWp.Contains(".svg")) ? 1 : 0);
				if (num != 0)
				{
					num2 = 1;
					goto IL_0035;
				}
			}
			else
			{
				num = 0;
			}
			num2 = 5;
			goto IL_0035;
			IL_0035:
			XmlDocument templateContent = ToastNotificationManager.GetTemplateContent((ToastTemplateType)num2);
			XmlNodeList elementsByTagName = templateContent.GetElementsByTagName("text");
			((IReadOnlyList<IXmlNode>)elementsByTagName)[0].AppendChild((IXmlNode)(object)templateContent.CreateTextNode(WJx2tMbUytp));
			((IReadOnlyList<IXmlNode>)elementsByTagName)[1].AppendChild((IXmlNode)(object)templateContent.CreateTextNode(LF02tA6mfZE));
			if (num != 0)
			{
				string text = "file:///" + VTM2tTYDrWp;
				XmlNodeList elementsByTagName2 = templateContent.GetElementsByTagName("image");
				if (elementsByTagName2 != null && ((IReadOnlyCollection<IXmlNode>)elementsByTagName2).Count > 0)
				{
					((IReadOnlyList<IXmlNode>)elementsByTagName2)[0].Attributes.GetNamedItem("src").NodeValue = text;
				}
			}
			ToastNotification val = new ToastNotification(templateContent);
			if (J9a2tO4fUTR != null)
			{
				ToastNotification val2 = val;
				int num3 = 0;
				if (v7i4jqye7ex3g86KYhR7 != null)
				{
					int num4 = default(int);
					num3 = num4;
				}
				switch (num3)
				{
				}
				(val2).Activated += pya2tUaIUtq ?? (pya2tUaIUtq = bMR2to9Lugg);
			}
			if (lea2tFIcNX4.HasValue)
			{
				val.ExpirationTime = DateTimeOffset.UtcNow.AddSeconds(lea2tFIcNX4.Value);
			}
			try
			{
				ToastNotificationManager.CreateToastNotifier("Quicker").Show(val);
			}
			catch (Exception ex)
			{
				string message = "创建Windows通知出错：" + ex.Message;
				D0cLTzhCMW5.Warn(message, ex);
				ShowWarning(message);
			}
		}

		internal void bMR2to9Lugg(ToastNotification sender, object args)
		{
			J9a2tO4fUTR();
		}

		internal static bool CkPwFbye49KMEXuHD2RT()
		{
			return v7i4jqye7ex3g86KYhR7 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass144_0
	{
		public System.Windows.Window MXv2ti9aoFQ;

		internal static _003C_003Ec__DisplayClass144_0 zHBYPWyjFp0vQnvT2Too;

		internal void qZ52tlp8qIK()
		{
			MXv2ti9aoFQ = System.Windows.Application.Current.Windows.OfType<System.Windows.Window>()?.SingleOrDefault(_003C_003Ec.Mxd2tZTQYFT ?? (_003C_003Ec.Mxd2tZTQYFT = _003C_003Ec.PIS2tP1NWqa.Uuf2tu4LcbI));
		}

		internal static bool jcPEBgyjchoFqOQm2YXi()
		{
			return zHBYPWyjFp0vQnvT2Too == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass161_0
	{
		public BitmapSource QpL2tfJ1bWt;

		public Bitmap i3X2tzueSb1;

		public string SVa2gwdv9rr;

		private static _003C_003Ec__DisplayClass161_0 lnLrwTyjyWkNjjAfqd7V;

		internal void xk92t3864oq()
		{
			ImageViewerWindow imageViewerWindow = new ImageViewerWindow(QpL2tfJ1bWt);
			imageViewerWindow.ImageFilePath = "";
			imageViewerWindow.Location = ShowWindowLocation.CenterScreen;
			imageViewerWindow.InitialScale = 1.0;
			imageViewerWindow.AutoCloseSeconds = 0.0;
			imageViewerWindow.AutoCloseKey = "";
			imageViewerWindow.QuickScreenShotBitmap = i3X2tzueSb1;
			imageViewerWindow.ToolTip = SVa2gwdv9rr;
			imageViewerWindow.IsForQuickScreenShot = false;
			imageViewerWindow.Show();
		}

		internal static bool GesK00yjpp9jCOREC4bQ()
		{
			return lnLrwTyjyWkNjjAfqd7V == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass172_0
	{
		public string k1P2ggFdNcy;

		private static _003C_003Ec__DisplayClass172_0 gOo0bayjAiOlhPvPI7nV;

		internal void BOc2gtH9r10()
		{
			AppState.v5FtaQ4hQfg().d9QvtdiYSo6(GetPointTargetInfo(null), true, k1P2ggFdNcy);
		}

		internal static bool OiYXRryjnp9BeUbKxgYJ()
		{
			return gOo0bayjAiOlhPvPI7nV == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass179_0
	{
		public ApiResult<SharedTextCommandPackageDto> uQA2gvqT4rm;

		internal static _003C_003Ec__DisplayClass179_0 ErNqi8yjjTf3gsQnJr34;

		internal void dkd2gLa8FLh()
		{
			InstallTextCommandWindow installTextCommandWindow = new InstallTextCommandWindow(uQA2gvqT4rm.Data, null);
			installTextCommandWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
			installTextCommandWindow.Owner = null;
			installTextCommandWindow.Show();
			installTextCommandWindow.Activate();
		}

		internal static bool eeWsNjyjDVVrbh1RAro6()
		{
			return ErNqi8yjjTf3gsQnJr34 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass180_0
	{
		public ApiResult<SharedPowerKeyDto> nY52g2WRfhC;

		internal static _003C_003Ec__DisplayClass180_0 JhCJfQyjEFuNcwyabjqA;

		internal void kF72gSHbrmm()
		{
			InstallPowerKeyWindow installPowerKeyWindow = new InstallPowerKeyWindow(null, nY52g2WRfhC.Data);
			installPowerKeyWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
			installPowerKeyWindow.Owner = null;
			installPowerKeyWindow.Show();
			installPowerKeyWindow.Activate();
		}

		internal static bool KOPchKyjGyYCO5QOQY3Z()
		{
			return JhCJfQyjEFuNcwyabjqA == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass185_0
	{
		public ProcessStartInfo Mmm2gNMc7vs;

		public string xBe2gJvb0sY;

		private static _003C_003Ec__DisplayClass185_0 bmFCWRyj1nRqjYLLwW5H;

		internal void NBT2gu7Tj4N()
		{
			try
			{
				Process.Start(Mmm2gNMc7vs);
			}
			catch (Exception ex)
			{
				D0cLTzhCMW5.Warn("启动程序(" + xBe2gJvb0sY + ")出错：" + ex.Message);
				ShowWarning(ex.Message ?? "");
			}
		}

		internal static bool c1d6KyyjK9jQwI1Sk78H()
		{
			return bmFCWRyj1nRqjYLLwW5H == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass187_0
	{
		public string UeX2gC4kHjC;

		public bool f8G2gPZVJnn;

		public bool Ijl2gEMJjHb;

		internal static _003C_003Ec__DisplayClass187_0 Avu8rQyjveTlPJjMw9kK;

		internal void VEE2g0nJxDw()
		{
			try
			{
				System.Windows.Forms.Clipboard.SetText(UeX2gC4kHjC);
				f8G2gPZVJnn = true;
				if (Ijl2gEMJjHb)
				{
					ShowSuccess("已复制：" + UeX2gC4kHjC.ToShortString(30));
				}
			}
			catch (Exception ex)
			{
				ShowWarning("复制出错：" + ex.Message);
			}
		}

		internal static bool SDCFQgyjdOadD21d7NYC()
		{
			return Avu8rQyjveTlPJjMw9kK == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass19_0
	{
		public string nlR2g81Wj68;

		private static _003C_003Ec__DisplayClass19_0 dkVnLFyjkqKUpR8ICR3O;

		internal void pNM2gycoSDK()
		{
			MessageBoxHelper.Show(nlR2g81Wj68, "Quicker", MessageBoxButton.OK, MessageBoxImage.Exclamation);
		}

		internal static bool ntVAnWyjasAabtwVqQII()
		{
			return dkVnLFyjkqKUpR8ICR3O == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass24_0
	{
		public Action GdU2g7ccmw9;

		internal static _003C_003Ec__DisplayClass24_0 xoVFH4yjNtn57OjFPKFA;

		internal void itk2gaTBwlU(NotificationBase b)
		{
			GdU2g7ccmw9();
		}

		internal static bool XhuTEryj9f1FwJkcuvJV()
		{
			return xoVFH4yjNtn57OjFPKFA == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass46_0
	{
		public bool XOG2gqHFNS1;

		public System.Windows.Window qOT2gc6QGrA;

		public string Q4X2gVoOBfN;

		public string IRT2gZa29Hc;

		public MessageBoxImage Nck2g9H9Yqi;

		internal static _003C_003Ec__DisplayClass46_0 HWPjlnyjufxSZB62g9pp;

		internal void cT22gRxeSpd()
		{
			XOG2gqHFNS1 = MessageBoxHelper.Show(qOT2gc6QGrA, Q4X2gVoOBfN, IRT2gZa29Hc.Or("Quicker"), MessageBoxButton.OKCancel, Nck2g9H9Yqi, MessageBoxResult.Yes) == MessageBoxResult.OK;
		}

		internal static bool nVq79Dyjo9t8hc6Zwyxi()
		{
			return HWPjlnyjufxSZB62g9pp == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass51_0
	{
		public string BAP2ge4k3eQ;

		private static _003C_003Ec__DisplayClass51_0 UKqlSPyjbKKvLyHxvIcD;

		internal bool MBT2ghYSikh(string str)
		{
			return str.EndsWith(BAP2ge4k3eQ);
		}

		internal static bool Ssbk1nyjqFkkelymB7Ws()
		{
			return UKqlSPyjbKKvLyHxvIcD == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass78_0
	{
		public int Q6M2gYoNAPx;

		private static _003C_003Ec__DisplayClass78_0 KIKdGMyjlndnqyLpI1jr;

		internal static bool vUwGAfyjZnreU6xQBFbP()
		{
			return KIKdGMyjlndnqyLpI1jr == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass78_1
	{
		public int bn22gWdHFxp;

		public _003C_003Ec__DisplayClass78_0 XRa2gkGh9fp;

		internal static _003C_003Ec__DisplayClass78_1 yRx9iyyjYRFGO0HN1Gq7;

		internal bool k6Y2gIVZGNp(ActionItem x)
		{
			if (x.Row == XRa2gkGh9fp.Q6M2gYoNAPx)
			{
				return x.Col == bn22gWdHFxp;
			}
			return false;
		}

		internal static bool TjnSCCyj8XPPxFKqw1n8()
		{
			return yRx9iyyjYRFGO0HN1Gq7 == null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CFindRootWindows_003Ed__109<T> : IEnumerable<T>, IEnumerator<T>, IDisposable, IEnumerable, IEnumerator where T : System.Windows.Window
	{
		private int _003C_003E1__state;

		private T _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private IEnumerator _003C_003E7__wrap1;

		internal static object dmjmeSyjgcNHGa73iVGS;

		T IEnumerator<T>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public _003CFindRootWindows_003Ed__109(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			int num = _003C_003E1__state;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					_003C_003Em__Finally1();
				}
			}
			_003C_003E7__wrap1 = null;
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			try
			{
				int num = _003C_003E1__state;
				if (num != 0)
				{
					if (num != 1)
					{
						return false;
					}
					goto IL_008d;
				}
				_003C_003E1__state = -1;
				_003C_003E7__wrap1 = System.Windows.Application.Current.Windows.GetEnumerator();
				_003C_003E1__state = -3;
				goto IL_0095;
				IL_0095:
				T val;
				do
				{
					if (_003C_003E7__wrap1.MoveNext())
					{
						val = _003C_003E7__wrap1.Current as T;
						continue;
					}
					_003C_003Em__Finally1();
					_003C_003E7__wrap1 = null;
					return false;
				}
				while (val == null);
				_003C_003E2__current = val;
				_003C_003E1__state = 1;
				int num2 = 1;
				if (!co6n5fyjPdwgcme5Lb0L())
				{
					int num3 = default(int);
					num2 = num3;
				}
				switch (num2)
				{
				case 1:
					return true;
				}
				goto IL_008d;
				IL_008d:
				_003C_003E1__state = -3;
				goto IL_0095;
			}
			catch
			{
				//try-fault
				((IDisposable)this).Dispose();
				throw;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
			_003C_003E1__state = -1;
			if (_003C_003E7__wrap1 is IDisposable disposable)
			{
				disposable.Dispose();
			}
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				return this;
			}
			return new _003CFindRootWindows_003Ed__109<T>(0);
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<T>)this).GetEnumerator();
		}

		internal static bool co6n5fyjPdwgcme5Lb0L()
		{
			return dmjmeSyjgcNHGa73iVGS == null;
		}
	}


	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CInputTextAsync_003Ed__184 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<(bool isSuccess, string text)> _003C_003Et__builder;

		public string title;

		public string prompt;

		public bool isRequired;

		public string defaultValue;

		public string pattern;

		public Func<string, string> validator;

		public System.Windows.Window parentWindow;

		private CommonInputWindow _003Cdlg_003E5__2;

		private TaskAwaiter<bool?> _003C_003Eu__1;

		private static object f3vxC0yjSyjAt4mlPWJQ;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			(bool, string) result;
			try
			{
				TaskAwaiter<bool?> awaiter;
				if (num != 0)
				{
					_003Cdlg_003E5__2 = new CommonInputWindow(title, prompt, isRequired, defaultValue, pattern, validator)
					{
						Owner = parentWindow
					};
					awaiter = _003Cdlg_003E5__2.MjdLOXIjD10(true).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<bool?>);
					num = -1;
					_003C_003E1__state = -1;
				}
				result = ((awaiter.GetResult() != true) ? (false, string.Empty) : (true, _003Cdlg_003E5__2.Text));
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Cdlg_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003Cdlg_003E5__2 = null;
			_003C_003Et__builder.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static _003CInputTextAsync_003Ed__184()
		{
		}

		internal static bool ABt9eoyjwJqg7Nwsmk4k()
		{
			return f3vxC0yjSyjAt4mlPWJQ == null;
		}

		internal static void IFWTPMyjmVNd7LXacuT6()
		{
		}
	}


	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRunOnUiThreadAsync_003Ed__118 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Func<Task> action;

		private TaskAwaiter _003C_003Eu__1;

		private static object G3Hh8byj4m0aAiIc37vL;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = System.Windows.Application.Current.Dispatcher.Invoke(action).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					if (WGEMPsyjh87oafew5q2t())
					{
						switch (0)
						{
						}
					}
					num = -1;
					_003C_003E1__state = -1;
				}
				awaiter.GetResult();
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool WGEMPsyjh87oafew5q2t()
		{
			return G3Hh8byj4m0aAiIc37vL == null;
		}
	}


	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CUploadImageAsync_003Ed__155 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<(bool isSuccess, string urlOrMessage)> _003C_003Et__builder;

		public string filePath;

		private TaskAwaiter<ApiResult<string>> _003C_003Eu__1;

		internal static object sQVcfEyDFAhOybUOT6RX;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			(bool, string) result;
			try
			{
				try
				{
					if (num == 0)
					{
						goto IL_00d0;
					}
					if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
					{
						FileInfo fileInfo = new FileInfo(filePath);
						if (!fileInfo.Name.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) && !fileInfo.Name.EndsWith(".png", StringComparison.OrdinalIgnoreCase))
						{
							result = (false, "仅支持jpg或png文件。");
						}
						else
						{
							if (fileInfo.Length <= 2048000L)
							{
								goto IL_00d0;
							}
							result = (false, $"文件大小超过限制（最大{2048000}字节）。");
						}
					}
					else
					{
						result = (false, "没有要上传的文件或文件不存在。");
						if (sQVcfEyDFAhOybUOT6RX == null)
						{
							switch (0)
							{
							case 0:
								break;
							}
						}
					}
					goto end_IL_0008;
					IL_00d0:
					try
					{
						TaskAwaiter<ApiResult<string>> awaiter;
						if (num != 0)
						{
							awaiter = aFIptTXYsUoTUF4v33R.GlYtbJkn8Qq(filePath, UserFileType.PanelBackground).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 0;
								_003C_003E1__state = 0;
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default(TaskAwaiter<ApiResult<string>>);
							num = -1;
							_003C_003E1__state = -1;
						}
						ApiResult<string> result2 = awaiter.GetResult();
						result = ((!result2.IsSuccess) ? (false, "上传文件出错：" + result2.Message) : (true, result2.Data));
					}
					catch (Exception exception)
					{
						result = (false, "上传文件出错：" + exception.GetMessageWithInner());
					}
					end_IL_0008:;
				}
				catch (Exception exception2)
				{
					result = (false, "上传文件出错：" + exception2.GetMessageWithInner());
				}
			}
			catch (Exception exception3)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception3);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool OAMFDcyDcJgmucLKGdUp()
		{
			return sQVcfEyDFAhOybUOT6RX == null;
		}
	}

	public const string APP_ID = "Quicker";

	private static readonly ILog D0cLTzhCMW5;

	public const double MSG_FONT_SIZE = 15.0;

	private static MessageOptions bStLMwNoecq;

	public static readonly List<string> ImageExtensions;

	private static readonly IDictionary<string, ImageSource> flbLMtwwPRg;

	private static readonly DebounceTimer vEgLMgfnEQg;

	public const string DEFAULT_USER_AGENT = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/110.0.0.0 Safari/537.36";

	private static object QZdXvbF8KvlbKCB4Qdo3;

	public static void OpenMainSite()
	{
		try
		{
			Process.Start("https://getquicker.net");
		}
		catch (Exception ex)
		{
			MessageBoxHelper.Show(ex.Message, "Quicker", MessageBoxButton.OK, MessageBoxImage.Exclamation);
		}
	}

	public static void OpenUserHome(string token = "")
	{
		TryOpenUrlOrFile(Quicker.Domain.Services.AppPathProvider.LocalDataRoot);
	}

	internal static Task tNBLTbaIvty(string string_0)
	{
		ShowWarning("原厂账号和云端页面已移除，请使用本地导入/导出。");
		return Task.CompletedTask;
	}

	internal static Task<string> c8mLT6Z8gH6(string string_0)
	{
		return Task.FromException<string>(new InvalidOperationException("本地版不生成原厂自动登录网址。"));
	}

	public static int GetButtonIndex(bool isGlobalProfile, int row, int column)
	{
		if (row > 999 || column > 999)
		{
			throw new InvalidOperationException("非法行列编号！");
		}
		return ((!isGlobalProfile) ? 1000000 : 0) + row * 1000 + column;
	}

	public static (bool isGlobal, int row, int column) GetButtonLocation(int buttonIndex)
	{
		bool item = IsGlobalButton(buttonIndex);
		int item2 = buttonIndex / 1000 % 1000;
		int item3 = buttonIndex % 1000;
		return (isGlobal: item, row: item2, column: item3);
	}

	public static bool IsGlobalButton(int btnIndex)
	{
		return btnIndex < 1000000;
	}

	public static void CreateButtonsForGrid(System.Windows.Controls.Grid grid, int rowCount, int colCount, bool isGlobal, IDictionary<int, ActionButton> buttonDict, Action<ActionButton> action)
	{
		for (int i = 0; i < rowCount; i++)
		{
			for (int j = 0; j < colCount; j++)
			{
				int buttonIndex = GetButtonIndex(isGlobal, i, j);
				ActionButton actionButton = new ActionButton();
				actionButton.ActionItem = null;
				actionButton.Tag = buttonIndex;
				actionButton.AllowDrop = true;
				action(actionButton);
				buttonDict.Add(buttonIndex, actionButton);
				System.Windows.Controls.Grid.SetRow(actionButton, i);
				System.Windows.Controls.Grid.SetColumn(actionButton, j);
				grid.Children.Add(actionButton);
			}
		}
	}

	public static void CreateButtonsOnCanvas(Canvas canvas, int rowCount, int colCount, bool isGlobal, double buttonSize, double space, IDictionary<int, ActionButton> buttonDict, double topSpace, Action<ActionButton> action)
	{
		for (int i = 0; i < rowCount; i++)
		{
			for (int j = 0; j < colCount; j++)
			{
				int buttonIndex = GetButtonIndex(isGlobal, i, j);
				ActionButton actionButton = new ActionButton();
				actionButton.ActionItem = null;
				actionButton.Tag = buttonIndex;
				actionButton.AllowDrop = true;
				actionButton.Height = buttonSize;
				actionButton.Width = buttonSize;
				actionButton.FocusVisualStyle = null;
				actionButton.Focusable = false;
				action(actionButton);
				buttonDict.Add(buttonIndex, actionButton);
				Canvas.SetLeft(actionButton, (double)j * (buttonSize + space));
				Canvas.SetTop(actionButton, (double)i * (buttonSize + space) + topSpace);
				canvas.Children.Add(actionButton);
			}
		}
	}

	public static void CreateToggleButtonsOnCavas(Canvas canvas, int rowCount, int colCount, bool isGlobal, double buttonSize, double space, IDictionary<int, System.Windows.Controls.Primitives.ToggleButton> buttonDict, Action<System.Windows.Controls.Primitives.ToggleButton> action)
	{
		for (int i = 0; i < rowCount; i++)
		{
			for (int j = 0; j < colCount; j++)
			{
				int buttonIndex = GetButtonIndex(isGlobal, i, j);
				System.Windows.Controls.Primitives.ToggleButton toggleButton = new System.Windows.Controls.Primitives.ToggleButton
				{
					Tag = buttonIndex,
					AllowDrop = true,
					Height = buttonSize,
					Width = buttonSize
				};
				buttonDict.Add(buttonIndex, toggleButton);
				action(toggleButton);
				Canvas.SetLeft(toggleButton, (double)j * (buttonSize + space) + space);
				Canvas.SetTop(toggleButton, (double)i * (buttonSize + space) + space);
				canvas.Children.Add(toggleButton);
			}
		}
	}

	public static void ForEachButton(this IDictionary<int, ActionButton> actionButtons, bool includeGlobal, bool includeContext, Action<int, ActionButton> action)
	{
		if (includeGlobal)
		{
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					int buttonIndex = GetButtonIndex(true, i, j);
					ActionButton arg = actionButtons[buttonIndex];
					action(buttonIndex, arg);
				}
			}
		}
		if (!includeContext)
		{
			return;
		}
		for (int k = 0; k < 4; k++)
		{
			for (int l = 0; l < 4; l++)
			{
				int buttonIndex2 = GetButtonIndex(false, k, l);
				ActionButton arg2 = actionButtons[buttonIndex2];
				action(buttonIndex2, arg2);
			}
		}
	}

	public static void ForEachButton(bool includeGlobal, bool includeContext, int columnCount, Action<int> action)
	{
		if (includeGlobal)
		{
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < columnCount; j++)
				{
					int buttonIndex = GetButtonIndex(true, i, j);
					action(buttonIndex);
				}
			}
		}
		if (!includeContext)
		{
			return;
		}
		for (int k = 0; k < 4; k++)
		{
			for (int l = 0; l < columnCount; l++)
			{
				int buttonIndex2 = GetButtonIndex(false, k, l);
				action(buttonIndex2);
			}
		}
	}

	public static string GetUserDataDir(string subFolder)
	{
		string text = Quicker.Domain.Services.AppPathProvider.LocalDataRoot;
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		if (!string.IsNullOrEmpty(subFolder))
		{
			text = Path.Combine(text, subFolder);
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
		}
		return text;
	}

	public static string GetUserDataDirWithoutCheck(string subFolder)
	{
        return Path.Combine(Quicker.Domain.Services.AppPathProvider.LocalDataRoot, subFolder ?? "");
    }

	public static bool IsDataFolderExists(string subfolder)
	{
        return Directory.Exists(GetUserDataDirWithoutCheck(subfolder));
    }

	public static void FixActionItemPosition(IList<ActionItem> actions)
	{
		if (actions == null)
		{
			return;
		}
		((List<ActionItem>)actions).RemoveAll(_003C_003Ec.fln2tEVBRVW ?? (_003C_003Ec.fln2tEVBRVW = _003C_003Ec.PIS2tP1NWqa.zkG2wf8WHvN));
		for (int i = 0; i < actions.Count; i++)
		{
			if (actions[i] != null)
			{
				if (actions[i].Col != 0 || actions[i].Row != 0)
				{
					break;
				}
				actions[i].Row = i / 4;
				actions[i].Col = i % 4;
			}
		}
	}

	public static void ShowWarning(string message, bool showPopup = false)
	{
		_003C_003Ec__DisplayClass19_0 _003C_003Ec__DisplayClass19_ = new _003C_003Ec__DisplayClass19_0();
		_003C_003Ec__DisplayClass19_.nlR2g81Wj68 = message;
		if (!showPopup && AppState.vVktaZmxU7S() != null)
		{
			try
			{
				AppState.vVktaZmxU7S().ShowWarning(_003C_003Ec__DisplayClass19_.nlR2g81Wj68, bStLMwNoecq);
				return;
			}
			catch (Exception ex)
			{
				D0cLTzhCMW5.Warn("ShowWarning异常：" + ex.Message, ex);
				System.Windows.Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new Action(_003C_003Ec__DisplayClass19_.pNM2gycoSDK));
				return;
			}
		}
		MessageBoxHelper.Show(_003C_003Ec__DisplayClass19_.nlR2g81Wj68, "Quicker", MessageBoxButton.OK, MessageBoxImage.Exclamation);
	}

	private static void NxTLTXpv1fg(NotificationBase notificationBase_0)
	{
		try
		{
			ClipboardHelper.SetText(notificationBase_0.Message);
		}
		catch
		{
		}
	}

	public static void ShowError(string message, bool showPopup = true)
	{
		if (showPopup)
		{
			MessageBoxHelper.Show(message, "Quicker", MessageBoxButton.OK, MessageBoxImage.Exclamation);
		}
		else
		{
			AppState.vVktaZmxU7S().ShowError(message, bStLMwNoecq);
		}
	}

	public static void ShowSuccess(string message)
	{
		AppState.vVktaZmxU7S().ShowSuccess(message, bStLMwNoecq);
	}

	public static void ShowInformation(string message, bool showPopup = false, Action callback = null)
	{
		_003C_003Ec__DisplayClass24_0 _003C_003Ec__DisplayClass24_ = new _003C_003Ec__DisplayClass24_0();
		_003C_003Ec__DisplayClass24_.GdU2g7ccmw9 = callback;
		if (QZdXvbF8KvlbKCB4Qdo3 == null)
		{
			switch (0)
			{
			}
		}
		if (!showPopup)
		{
			if (_003C_003Ec__DisplayClass24_.GdU2g7ccmw9 == null)
			{
				AppState.vVktaZmxU7S()?.ShowInformation(message, bStLMwNoecq);
				return;
			}
			MessageOptions displayOptions = new MessageOptions
			{
				FontSize = 15.0,
				UnfreezeOnMouseLeave = true,
				NotificationClickAction = _003C_003Ec__DisplayClass24_.itk2gaTBwlU
			};
			AppState.vVktaZmxU7S()?.ShowInformation(message, displayOptions);
		}
		else
		{
			MessageBoxHelper.Show(message, "Quicker");
		}
	}

	public static void ShowTextWindow(string title, string message, System.Windows.Window owner, bool topMost)
	{
		TextWindow textWindow = new TextWindow();
		textWindow.Title = title;
		textWindow.Topmost = topMost;
		textWindow.Owner = owner;
		textWindow.SetText(message);
		textWindow.Show();
		textWindow.Activate();
	}

	public static MessageBoxResult AskUser(string message)
	{
		return MessageBoxHelper.Show(message, "Quicker", MessageBoxButton.OKCancel, MessageBoxImage.Question);
	}

	public static string GetSystemIconUrl(string fileName)
	{
		return yyXIB9Yxgd6ACb7T4ig.j53dHOYtcRyb9edAMaZ.ercL5MLtTEv("https://files.getquicker.net/_system/" + fileName);
	}

	public static bool IsEqualSerialized(object a, object b)
	{
		if ((a == null && b != null) || (a != null && b == null))
		{
			return false;
		}
		string a2 = JsonConvert.SerializeObject(a);
		string b2 = JsonConvert.SerializeObject(b);
		return string.Equals(a2, b2, StringComparison.Ordinal);
	}

	public static string ReplacePattern(string data, string pattern, string newString)
	{
		if (string.IsNullOrEmpty(data))
		{
			return "";
		}
		int num = data.IndexOf(pattern, StringComparison.OrdinalIgnoreCase);
		if (num < 0)
		{
			return data;
		}
		return data.Substring(0, num) + newString + data.Substring(num + pattern.Length);
	}

	public static string CreateSharedActionLink(SharedActionDto resultData)
	{
		return "https://getquicker.net/Sharedaction?code=" + resultData.Id.ToString();
	}

	public static string CreateSharedActionLink(string sharedActionId)
	{
		return "https://getquicker.net/Sharedaction?code=" + sharedActionId;
	}

	public static void TryOpenUrlOrFile(string pathOrUrl)
	{
		if (string.IsNullOrEmpty(pathOrUrl))
		{
			return;
		}
		pathOrUrl = pathOrUrl.TrimStart();
		try
		{
			if (pathOrUrl.EndsWith(".txt", StringComparison.OrdinalIgnoreCase) && NativeMethods.IsOnWindows11() && Path.IsPathRooted(pathOrUrl) && File.Exists(pathOrUrl))
			{
				OpenTxtFile(pathOrUrl);
				return;
			}
			try
			{
				if (Path.IsPathRooted(pathOrUrl) && Directory.Exists(pathOrUrl) && !string.IsNullOrEmpty(AppState.HHxtaMaoqJr().CustomOpenFolderCommand))
				{
					OpenFolderWithCustomCommand(pathOrUrl);
					return;
				}
			}
			catch (Exception ex)
			{
				D0cLTzhCMW5.Warn("作为目录打开路径出错：" + ex.Message, ex);
			}
			if (Path.IsPathRooted(pathOrUrl))
			{
				int num = 0;
				if (QZdXvbF8KvlbKCB4Qdo3 != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				if (File.Exists(pathOrUrl))
				{
					string directoryName = Path.GetDirectoryName(pathOrUrl);
					Process.Start(new ProcessStartInfo(pathOrUrl)
					{
						WorkingDirectory = directoryName
					});
					return;
				}
			}
			Process.Start(pathOrUrl);
		}
		catch (Exception ex2)
		{
			if (!pathOrUrl.OrdinalStartWith("http", true))
			{
				if (!pathOrUrl.EndsWithAny(true, ".html", ".htm"))
				{
					ShowWarning("无法打开文件或网址(" + pathOrUrl + ")，请检查您的Windows默认浏览器设置。" + ex2.Message);
					return;
				}
				int num3 = 0;
				if (!xDPwstF8BfKD2AdC5jTu())
				{
					int num4 = default(int);
					num3 = num4;
				}
				switch (num3)
				{
				}
			}
			if (!Hg4LTmYw99N(pathOrUrl) && !dLpLTKKXhqG(pathOrUrl))
			{
				ShowWarning("无法打开文件或网址(" + pathOrUrl + ")，请检查您的Windows默认浏览器设置。" + ex2.Message);
			}
			else
			{
				ShowWarning("无法使用默认浏览器打开文件或网址(" + pathOrUrl + ")，已使用Edge或IE打开。\r\n请检查您的Windows默认浏览器设置。\r\n" + ex2.Message);
			}
		}
	}

	private static bool Hg4LTmYw99N(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return false;
		}
		if (string_0.StartsWith("http", StringComparison.OrdinalIgnoreCase))
		{
			try
			{
				Process.Start("microsoft-edge:" + string_0);
				return true;
			}
			catch
			{
				return false;
			}
		}
		try
		{
			Process.Start("msedge", string_0);
		}
		catch (Exception)
		{
			return false;
		}
		return false;
	}

	private static bool dLpLTKKXhqG(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return false;
		}
		if (string_0.StartsWith("http", StringComparison.OrdinalIgnoreCase))
		{
			try
			{
				Process.Start("iexplore.exe", string_0);
				return true;
			}
			catch
			{
				return false;
			}
		}
		return false;
	}

	public static void TriggerButtonClick(System.Windows.Controls.Button button)
	{
		button.RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Primitives.ButtonBase.ClickEvent));
	}

	public static bool IsValidEmail(string email)
	{
		return new Regex("^((([a-z]|\\d|[!#\\$%&'\\*\\+\\-\\/=\\?\\^_`{\\|}~]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])+(\\.([a-z]|\\d|[!#\\$%&'\\*\\+\\-\\/=\\?\\^_`{\\|}~]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])+)*)|((\\x22)((((\\x20|\\x09)*(\\x0d\\x0a))?(\\x20|\\x09)+)?(([\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x7f]|\\x21|[\\x23-\\x5b]|[\\x5d-\\x7e]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(\\\\([\\x01-\\x09\\x0b\\x0c\\x0d-\\x7f]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF]))))*(((\\x20|\\x09)*(\\x0d\\x0a))?(\\x20|\\x09)+)?(\\x22)))@((([a-z]|\\d|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(([a-z]|\\d|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])([a-z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])*([a-z]|\\d|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])))\\.)+(([a-z]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(([a-z]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])([a-z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])*([a-z]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])))\\.?$", RegexOptions.IgnoreCase).IsMatch(email);
	}

	internal static void ttpLTxjOp3r(ActionItem actionItem_0)
	{
		TryOpenUrlOrFile(CreateSharedActionLink(actionItem_0.SharedActionId));
	}

	public static void OpenSourceSharedActionUrl(ActionItem action)
	{
		TryOpenUrlOrFile(CreateSharedActionLink(action.TemplateId));
	}

	public static void OpenSharedActionUrl(string sharedActionId)
	{
		TryOpenUrlOrFile(CreateSharedActionLink(sharedActionId));
	}

	public static void OpenSourceSharedActionFeedbackUrl(ActionItem action)
	{
		TryOpenUrlOrFile("https://getquicker.net/Share/Actions/Topics?code=" + action.TemplateId);
	}

	public static bool IsVersionNotEquals(string serverVersion)
	{
		if (string.IsNullOrEmpty(serverVersion))
		{
			return false;
		}
		string currAppVersion = GetCurrAppVersion();
		return !string.Equals(serverVersion, currAppVersion, StringComparison.OrdinalIgnoreCase);
	}

	public static bool IsImageFile(string fileName)
	{
		return ImageExtensions.Contains(Path.GetExtension(fileName).ToUpperInvariant());
	}

	public static bool IsValidIconFile(string fileName)
	{
		if (!string.IsNullOrEmpty(fileName))
		{
			if (!fileName.EndsWith(".png", StringComparison.OrdinalIgnoreCase) && !fileName.EndsWith(".ico", StringComparison.OrdinalIgnoreCase))
			{
				return fileName.EndsWith(".svg", StringComparison.OrdinalIgnoreCase);
			}
			return true;
		}
		return false;
	}

	public static IList<string> GetIpList()
	{
		try
		{
			IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());
			IList<string> list = new List<string>();
			IPAddress[] addressList = hostEntry.AddressList;
			foreach (IPAddress iPAddress in addressList)
			{
				if (iPAddress.AddressFamily == AddressFamily.InterNetwork)
				{
					list.Add(iPAddress.ToString());
				}
			}
			return list;
		}
		catch (Exception ex)
		{
			ShowWarning("获取本机IP地址失败：" + ex.Message);
			return new List<string>();
		}
	}

	public static bool Confirm(string message, MessageBoxImage image = MessageBoxImage.Question, string title = null, System.Windows.Window owner = null)
	{
		_003C_003Ec__DisplayClass46_0 _003C_003Ec__DisplayClass46_ = new _003C_003Ec__DisplayClass46_0();
		_003C_003Ec__DisplayClass46_.qOT2gc6QGrA = owner;
		_003C_003Ec__DisplayClass46_.Q4X2gVoOBfN = message;
		_003C_003Ec__DisplayClass46_.IRT2gZa29Hc = title;
		_003C_003Ec__DisplayClass46_.Nck2g9H9Yqi = image;
		_003C_003Ec__DisplayClass46_.XOG2gqHFNS1 = false;
		try
		{
			RunOnUiThread(true, _003C_003Ec__DisplayClass46_.cT22gRxeSpd);
		}
		catch (Exception)
		{
			_003C_003Ec__DisplayClass46_.XOG2gqHFNS1 = System.Windows.MessageBox.Show(_003C_003Ec__DisplayClass46_.Q4X2gVoOBfN, _003C_003Ec__DisplayClass46_.IRT2gZa29Hc.Or("Quicker"), MessageBoxButton.OKCancel, _003C_003Ec__DisplayClass46_.Nck2g9H9Yqi, MessageBoxResult.Yes) == MessageBoxResult.OK;
		}
		return _003C_003Ec__DisplayClass46_.XOG2gqHFNS1;
	}

	public static T Clone<T>(T obj) where T : class
	{
		if (obj == null)
		{
			return null;
		}
		return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(obj));
	}

	public static ImageSource GetResourceImage(string file)
	{
		if (string.IsNullOrEmpty(file))
		{
			return null;
		}
		if (flbLMtwwPRg.ContainsKey(file))
		{
			return flbLMtwwPRg[file];
		}
		try
		{
			BitmapImage bitmapImage = ((!file.StartsWith("/", StringComparison.Ordinal)) ? new BitmapImage(new Uri("pack://application:,,,/" + Assembly.GetEntryAssembly().GetName().Name + ";component/Assets/" + file)) : new BitmapImage(new Uri("pack://application:,,,/" + Assembly.GetEntryAssembly().GetName().Name + ";component" + file)));
			if (bitmapImage.CanFreeze)
			{
				bitmapImage.Freeze();
			}
			flbLMtwwPRg[file] = bitmapImage;
			return bitmapImage;
		}
		catch (Exception)
		{
			D0cLTzhCMW5.Warn("无法加载图片资源：" + file);
			return null;
		}
	}

	public static string[] GetResourceNames()
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		string name = executingAssembly.GetName().Name + ".g.resources";
		using ResourceReader source = new ResourceReader(executingAssembly.GetManifestResourceStream(name));
		return source.Cast<DictionaryEntry>().Select(_003C_003Ec.r3B2ty1DlAV ?? (_003C_003Ec.r3B2ty1DlAV = _003C_003Ec.PIS2tP1NWqa.H862wz1ArGu)).ToArray();
	}

	public static string ReadResourceText(string name)
	{
		_003C_003Ec__DisplayClass51_0 _003C_003Ec__DisplayClass51_ = new _003C_003Ec__DisplayClass51_0();
		_003C_003Ec__DisplayClass51_.BAP2ge4k3eQ = name;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		string text = _003C_003Ec__DisplayClass51_.BAP2ge4k3eQ;
		text = executingAssembly.GetManifestResourceNames().Single(_003C_003Ec__DisplayClass51_.MBT2ghYSikh);
		using Stream stream = executingAssembly.GetManifestResourceStream(text);
		using StreamReader streamReader = new StreamReader(stream);
		return streamReader.ReadToEnd();
	}

	public static ImageSource GetStepIcon(IStepRunner stepRunner, Visual visualForDpi)
	{
		if (string.IsNullOrEmpty(stepRunner.Icon))
		{
			return GetResourceImage("Steps/common_step.png");
		}
		if (stepRunner.Icon.StartsWith("fa:", StringComparison.OrdinalIgnoreCase))
		{
			return FaIconHelper.GetImageSourceFromFaIcon(stepRunner.Icon, "#FF0000", 32.0, GetDpiScaling(visualForDpi));
		}
		return GetResourceImage(stepRunner.Icon);
	}

	public static ImageSource GetVarTypeIcon(VarType type)
	{
		if (type != VarType.NA && type != VarType.CreateVar)
		{
			return GetResourceImage($"Var/{type}.png");
		}
		return null;
	}

	public static string GetVarTypeIconStr(VarType type)
	{
		return type switch
		{
			VarType.NA => "", 
			VarType.CreateVar => "fa:Light_Plus:#39b54d", 
			_ => $"Var/{type}.png", 
		};
	}

	public static BitmapSource TryGetClipboardImage()
	{
		try
		{
			return ClipboardHelper.GetImage();
		}
		catch (Exception ex)
		{
			D0cLTzhCMW5.Warn("获取剪贴板图片失败。" + ex.Message, ex);
			return null;
		}
	}

	public static System.Drawing.Image ImageWpfToGDI(ImageSource image)
	{
		MemoryStream memoryStream = new MemoryStream();
		PngBitmapEncoder pngBitmapEncoder = new PngBitmapEncoder();
		pngBitmapEncoder.Frames.Add(BitmapFrame.Create(image as BitmapSource));
		pngBitmapEncoder.Save(memoryStream);
		memoryStream.Flush();
		return System.Drawing.Image.FromStream(memoryStream);
	}

	public static bool IsInUiThread()
	{
		return Dispatcher.FromThread(Thread.CurrentThread) != null;
	}

	public static bool ValidateNumberInput(System.Windows.Controls.TextBox txtBox, double? min, double? max)
	{
		if (string.IsNullOrEmpty(txtBox.Text))
		{
			txtBox.Focus();
			return false;
		}
		if (!double.TryParse(txtBox.Text, out var result))
		{
			txtBox.Focus();
			return false;
		}
		if (min.HasValue && result < min)
		{
			txtBox.Focus();
			return false;
		}
		if (max.HasValue && result > max)
		{
			txtBox.Focus();
			return false;
		}
		return true;
	}

	public static string GetShorterString(string str, int maxLength)
	{
		if (string.IsNullOrEmpty(str))
		{
			return string.Empty;
		}
		if (str.Length <= maxLength + 3)
		{
			return str;
		}
		return str.Substring(0, maxLength) + "...";
	}

	public static bool EnsureNotEmpty(this System.Windows.Controls.TextBox txt, string fieldName, bool showMsgBox = true)
	{
		if (string.IsNullOrEmpty(txt.Text))
		{
			if (showMsgBox)
			{
				MessageBoxHelper.Show("请输入 " + fieldName + "。", "Quicker");
			}
			txt.Focus();
			return false;
		}
		return true;
	}

	public static string GetLocalTimeString(DateTime? utcTime)
	{
		if (!utcTime.HasValue)
		{
			return "-";
		}
		return DateTime.SpecifyKind(utcTime.Value, DateTimeKind.Utc).ToLocalTime().ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
	}

	public static string GetSoftVersion()
	{
		return Assembly.GetExecutingAssembly().GetName().Version.ToString();
	}

	public static void SelectFileInExplorer(string filePathName, bool useExistingInstance)
	{
		if (!File.Exists(filePathName) && !Directory.Exists(filePathName) && filePathName.Contains("%"))
		{
			filePathName = Environment.ExpandEnvironmentVariables(filePathName);
		}
		try
		{
			if (!string.IsNullOrEmpty(AppState.HHxtaMaoqJr().CustomSelectInExplorerCommand))
			{
				if (xDPwstF8BfKD2AdC5jTu())
				{
					switch (0)
					{
					}
				}
				ExecuteText(AppState.HHxtaMaoqJr().CustomSelectInExplorerCommand.Replace("%path%", filePathName).Replace("%folder%", Path.GetDirectoryName(filePathName)).Replace("%file%", Path.GetFileName(filePathName)));
				return;
			}
			switch (AppState.HHxtaMaoqJr().DefaultExplorerSoftware)
			{
			default:
				SelectFileUsingWindowsExplorer(filePathName, useExistingInstance);
				break;
			case ExplorerSoftware.DirectoryOpus:
				cQCX97ioFnivYTCZNWb.RKnvtujdkvE(filePathName, useExistingInstance);
				break;
			case ExplorerSoftware.TotalCommander:
				d23lbji6LH2xdpIE1Qu.swUvtalkhAk(filePathName, useExistingInstance);
				break;
			case ExplorerSoftware.XYplorer:
				moAa3ciiBWM25Wu8vZH.BsUvtetS1KR(filePathName, useExistingInstance);
				break;
			case ExplorerSoftware.OneCommander:
				sDvXVkiWVWu4wUdiwlQ.mtyvwD0Wsw3(filePathName);
				break;
			}
		}
		catch (Exception ex)
		{
			D0cLTzhCMW5.Warn($"无法使用资源管理器定位文件。类型:{AppState.HHxtaMaoqJr().DefaultExplorerSoftware}, 路径：{filePathName}, 错误：{ex.Message}", ex);
			SelectFileUsingWindowsExplorer(filePathName, useExistingInstance);
		}
	}

	public static void SelectFileUsingWindowsExplorer(string filePathName, bool useExistingInstance)
	{
		if (useExistingInstance)
		{
			try
			{
				NativeMethods.OpenFolderAndSelectItem(Path.GetDirectoryName(filePathName), Path.GetFileName(filePathName));
				return;
			}
			catch (Exception ex)
			{
				ShowWarning("在资源管理器中打开文件失败。" + ex.Message);
				return;
			}
		}
		try
		{
			string arguments = "/select, \"" + filePathName + "\"";
			Process.Start("explorer.exe", arguments);
		}
		catch (Exception ex2)
		{
			ShowWarning("在资源管理器中打开文件失败。" + ex2.Message);
		}
	}

	public static double GetDpiScaling(Visual visual)
	{
		if (visual == null)
		{
			return 1.0;
		}
		PresentationSource presentationSource = PresentationSource.FromVisual(visual);
		if (presentationSource != null && presentationSource.CompositionTarget != null)
		{
			return presentationSource.CompositionTarget.TransformFromDevice.M11;
		}
		return 1.0;
	}

	public static void InsertTextToTextBox(this System.Windows.Controls.TextBox txtbox, string text)
	{
		if (txtbox.SelectedText.Length > 0)
		{
			txtbox.Text = txtbox.Text.Replace(txtbox.Text.Substring(txtbox.SelectionStart, txtbox.SelectionLength), text);
		}
		else
		{
			txtbox.Text = txtbox.Text.Insert(txtbox.CaretIndex, text);
		}
	}

	public static void SetCartPosToEnd(this System.Windows.Controls.TextBox txtbox)
	{
		txtbox.CaretIndex = txtbox.Text.Length;
	}

	public static ActionType GetBaseActionType(ActionType newActionType)
	{
		ActionType actionType = newActionType;
		if (newActionType != ActionType.OpenFile && newActionType != ActionType.OpenFolder && newActionType != ActionType.TempRunSoftware)
		{
			return newActionType;
		}
		return ActionType.RunProgram;
	}

	public static void FreeMemory(int delaySeconds)
	{
		vEgLMgfnEQg.Debounce(delaySeconds * 1000, _003C_003Ec.Lon2t8MKKHN ?? (_003C_003Ec.Lon2t8MKKHN = _003C_003Ec.PIS2tP1NWqa.XUK2twcVT5p));
	}

	public static System.Drawing.Point GetTopLeftScreenPositionBasedOnMouseAndVisualOffset(Visual visual, System.Windows.Point? offset)
	{
		double dpiScaling = GetDpiScaling(visual ?? AppState.HS2taepcAbc());
		System.Drawing.Point mousePosition = NativeMethods.GetMousePosition();
		System.Drawing.Point result = new System.Drawing.Point(mousePosition.X, mousePosition.Y);
		if (offset.HasValue)
		{
			result.X -= (int)(offset.Value.X / dpiScaling);
			result.Y -= (int)(offset.Value.Y / dpiScaling);
		}
		return result;
	}

	public static System.Drawing.Point GetTopLeftScreenPositionBasedOnVisualAndOffset(System.Drawing.Point pt, Visual visual, System.Windows.Point? offset)
	{
		double dpiScaling = GetDpiScaling(visual ?? AppState.HS2taepcAbc());
		System.Drawing.Point result = new System.Drawing.Point(pt.X, pt.Y);
		if (offset.HasValue)
		{
			result.X -= (int)(offset.Value.X / dpiScaling);
			result.Y -= (int)(offset.Value.Y / dpiScaling);
		}
		return result;
	}

	public static System.Windows.Point GetWpfPosition(Visual visual, System.Windows.Point pt)
	{
		double dpiScaling = GetDpiScaling(visual);
		return new System.Windows.Point(pt.X * dpiScaling, pt.Y * dpiScaling);
	}

	public static string UnescapeString(string str)
	{
		return str?.Replace("\\r", "\r").Replace("\\n", "\n").Replace("\\t", "\t");
	}

	public static System.Windows.Rect ToWpf(this Rectangle physicalRectangle, double dpiScaling)
	{
		return new System.Windows.Rect((double)physicalRectangle.X * dpiScaling, (double)physicalRectangle.Y * dpiScaling, (double)physicalRectangle.Width * dpiScaling, (double)physicalRectangle.Height * dpiScaling);
	}

	public static System.Windows.Point ToWpf(this System.Drawing.Point physicalPoint, double dpiScaling)
	{
		return new System.Windows.Point((double)physicalPoint.X * dpiScaling, (double)physicalPoint.Y * dpiScaling);
	}

	private static Rectangle z0QLTrFDjiG(Visual visual_0)
	{
		PresentationSource.FromVisual(visual_0);
		return Screen.FromPoint(NativeMethods.GetMousePosition()).WorkingArea;
	}

	public static (int, int) FindEmptyPosition(this ActionProfile profile)
	{
		int num = (profile.IsGlobalProfile() ? 3 : 4);
		_003C_003Ec__DisplayClass78_0 _003C_003Ec__DisplayClass78_ = new _003C_003Ec__DisplayClass78_0();
		_003C_003Ec__DisplayClass78_.Q6M2gYoNAPx = 0;
		while (_003C_003Ec__DisplayClass78_.Q6M2gYoNAPx < num)
		{
			_003C_003Ec__DisplayClass78_1 _003C_003Ec__DisplayClass78_2 = new _003C_003Ec__DisplayClass78_1();
			_003C_003Ec__DisplayClass78_2.XRa2gkGh9fp = _003C_003Ec__DisplayClass78_;
			_003C_003Ec__DisplayClass78_2.bn22gWdHFxp = 0;
			while (_003C_003Ec__DisplayClass78_2.bn22gWdHFxp < 4)
			{
				if (profile.ActionItems.FirstOrDefault(_003C_003Ec__DisplayClass78_2.k6Y2gIVZGNp) != null)
				{
					_003C_003Ec__DisplayClass78_2.bn22gWdHFxp++;
					continue;
				}
				return (_003C_003Ec__DisplayClass78_2.XRa2gkGh9fp.Q6M2gYoNAPx, _003C_003Ec__DisplayClass78_2.bn22gWdHFxp);
			}
			_003C_003Ec__DisplayClass78_.Q6M2gYoNAPx++;
		}
		return (-1, -1);
	}

	public static bool IsDemoUser(string email)
	{
		return "demo@getquicker.net".Equals(email?.Trim(), StringComparison.OrdinalIgnoreCase);
	}

	public static string GetAppExePath()
	{
		return Assembly.GetExecutingAssembly().Location;
	}

	public static string GetAppFolder()
	{
		return Path.GetDirectoryName(GetAppExePath());
	}

	public static List<SimpleOperationItem> StringToOperationItems(string items, bool extraIconAndTooltip, bool enableSeparator = false)
	{
		List<SimpleOperationItem> list = new List<SimpleOperationItem>();
		string text = "|";
		string[] array = items.SplitToList();
		foreach (string text2 in array)
		{
			if (string.IsNullOrEmpty(text2) || text2.StartsWith("////"))
			{
				continue;
			}
			if (text2 == "----" && enableSeparator)
			{
				list.Add(new SimpleOperationItem
				{
					IsSeparator = true
				});
				continue;
			}
			if (list.Count == 0 && text2.StartsWith("|="))
			{
				text = text2.Substring(2);
				if (string.IsNullOrEmpty(text))
				{
					throw new InvalidDataException("未正确指定分隔符");
				}
				continue;
			}
			SimpleOperationItem simpleOperationItem = null;
			simpleOperationItem = ParseOperationItem(text2, extraIconAndTooltip, text);
			if (simpleOperationItem != null)
			{
				simpleOperationItem.OriginText = text2;
				list.Add(simpleOperationItem);
			}
		}
		return list;
	}

	public static SimpleOperationItem ParseOperationItem(string text, bool extraIconAndTooltip, string splitter)
	{
		if (string.IsNullOrEmpty(text))
		{
			return new SimpleOperationItem
			{
				Key = text,
				Name = text,
				OriginText = text
			};
		}
		SimpleOperationItem simpleOperationItem;
		if (text.Contains(splitter))
		{
			string[] array = text.Split(new string[1] { splitter }, 2, StringSplitOptions.None);
			object obj;
			if (array.Length <= 1)
			{
				int num = 0;
				if (QZdXvbF8KvlbKCB4Qdo3 != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				obj = array[0];
			}
			else
			{
				obj = array[1];
			}
			string key = (string)obj;
			if (extraIconAndTooltip)
			{
				(string, string, string) tuple = UIHelper.ExtractIconAndTitle(array[0]);
				simpleOperationItem = new SimpleOperationItem
				{
					Key = key,
					Name = tuple.Item2,
					Icon = tuple.Item1,
					Description = tuple.Item3
				};
			}
			else
			{
				simpleOperationItem = new SimpleOperationItem
				{
					Key = array[1],
					Name = array[0]
				};
			}
		}
		else
		{
			simpleOperationItem = new SimpleOperationItem
			{
				Key = text,
				Name = text
			};
		}
		simpleOperationItem.OriginText = text;
		return simpleOperationItem;
	}

	public static IEnumerable<Popup> GetOpenPopups()
	{
		return PresentationSource.CurrentSources.OfType<HwndSource>().Select(_003C_003Ec.sRG2taHrSgc ?? (_003C_003Ec.sRG2taHrSgc = _003C_003Ec.PIS2tP1NWqa.Nup2ttcbrMd)).OfType<FrameworkElement>()
			.Select(_003C_003Ec.Upd2t7WJmik ?? (_003C_003Ec.Upd2t7WJmik = _003C_003Ec.PIS2tP1NWqa.Xuo2tgcIyxG))
			.OfType<Popup>()
			.Where(_003C_003Ec.dp82tRB1Xxm ?? (_003C_003Ec.dp82tRB1Xxm = _003C_003Ec.PIS2tP1NWqa.B8n2tLcmhUs));
	}

	public static PointTargetInfo GetPointTargetInfo(System.Drawing.Point? point = null)
	{
		PointTargetInfo pointTargetInfo = new PointTargetInfo
		{
			Point = (point.HasValue ? point.Value : NativeMethods.GetMousePosition())
		};
		pointTargetInfo.HWnd = NativeMethods.WindowFromPoint(pointTargetInfo.Point);
		NativeMethods.GetWindowThreadProcessId(pointTargetInfo.HWnd, out uint processId);
		pointTargetInfo.Pid = processId;
		try
		{
			pointTargetInfo.IsOnQuicker = processId == AppState.QuickerProcessId;
			if (pointTargetInfo.IsOnQuicker)
			{
				pointTargetInfo.IsOnMainWindow = AppState.MainWinHandle == pointTargetInfo.HWnd;
				pointTargetInfo.IsOnNonTriggerWindow = false;
				if (BlockQuickerHWndBehavior.IsWindowRegistered(pointTargetInfo.HWnd))
				{
					pointTargetInfo.IsOnNonTriggerWindow = true;
				}
				pointTargetInfo.IsOnImageViewer = AppState.ImageViewerWindows.Contains(pointTargetInfo.HWnd);
			}
			else
			{
				pointTargetInfo.IsOnNonTriggerWindow = false;
			}
			(string, string) tuple = tZZhZGM4HaKvySF2OqY.S25LOK4WqVA(processId);
			pointTargetInfo.Exe = tuple.Item1;
			pointTargetInfo.ExePath = tuple.Item2;
			pointTargetInfo.Exe = FixExeName(pointTargetInfo.Exe, pointTargetInfo.HWnd);
			pointTargetInfo.IsInBlackList = BlackListMgr.IsInBlackList(pointTargetInfo.Exe, pointTargetInfo.ExePath);
			pointTargetInfo.IsFullscreenWindow = BlackListMgr.IsForegroundFullScreen(pointTargetInfo.HWnd, pointTargetInfo.Exe);
			pointTargetInfo.IsDisabledFullScreenWindow = pointTargetInfo.IsFullscreenWindow && AppState.HHxtaMaoqJr().DisableOnFullscreenApp;
		}
		catch (Exception ex)
		{
			pointTargetInfo.IsInBlackList = true;
			D0cLTzhCMW5.Warn("获取鼠标位置窗口信息异常：" + ex.Message, ex);
			ShowWarning("获取鼠标位置窗口信息异常：" + ex.Message);
		}
		return pointTargetInfo;
	}

	public static bool IsContextMenuOrPopup(IntPtr hwnd)
	{
		HwndSource hwndSource = HwndSource.FromHwnd(hwnd);
		if (hwndSource != null)
		{
			return hwndSource.RootVisual?.GetType().Name == "PopupRoot";
		}
		return false;
	}

	public static string FixExeName(string originExeName, IntPtr infoHWnd)
	{
		string text = originExeName.ToLower();
		if (!(text == "msedgewebview2.exe") && !string.Equals(text, "iexplore.exe"))
		{
			if (!ProcessHelper.IsDesktopSoftwareByExe(text))
			{
				if (string.Equals(text, "explorer.exe", StringComparison.OrdinalIgnoreCase))
				{
					int num = 0;
					if (!xDPwstF8BfKD2AdC5jTu())
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					}
					(bool onDesktop, bool onExplorer, bool onTaskbar) explorerWindow = NativeMethods.GetExplorerWindow(NativeMethods.GetRootWindow(infoHWnd));
					bool item = explorerWindow.onDesktop;
					bool item2 = explorerWindow.onTaskbar;
					text = (item ? "desktop" : ((!item2) ? "explorer.exe" : "taskbar"));
				}
			}
			else
			{
				text = "desktop";
			}
			return text;
		}
		return tZZhZGM4HaKvySF2OqY.u1MLOxTPiyo((uint)NativeMethods.GetWindowProcessId(NativeMethods.GetRootWindow(infoHWnd)));
	}

	public static bool IsFarThan(System.Drawing.Point point, System.Windows.Forms.MouseEventArgs e, int pixel)
	{
		if (point.X >= e.X - pixel && point.X <= e.X + pixel && point.Y >= e.Y - pixel)
		{
			return point.Y > e.Y + pixel;
		}
		return true;
	}

	public static bool IsFarThan(System.Drawing.Point pt1, System.Drawing.Point pt2, int pixel)
	{
		if (Math.Abs(pt1.X - pt2.X) <= pixel)
		{
			return Math.Abs(pt1.Y - pt2.Y) > pixel;
		}
		return true;
	}

	public static bool IsFarThan(System.Windows.Point pt1, System.Windows.Point pt2, int pixel)
	{
		if (!(Math.Abs(pt1.X - pt2.X) > (double)pixel))
		{
			return Math.Abs(pt1.Y - pt2.Y) > (double)pixel;
		}
		return true;
	}

	public static DateTime GetUtcNowForDb()
	{
		return DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Local);
	}

	public static void AddMenuSeparator(ItemCollection items)
	{
		if (items.Count != 0 && !(items[items.Count - 1] is Separator))
		{
			items.Add(new Separator());
		}
	}

	public static System.Windows.Controls.MenuItem AddMenuItem(ItemCollection items, string header, string tooltip, string icon, RoutedEventHandler handler, int? insertPosition = null, string headerNote = null, ICommand command = null, double iconSize = 16.0, ImageSource iconImageSource = null)
	{
		System.Windows.Controls.MenuItem menuItem = new System.Windows.Controls.MenuItem
		{
			Header = (string.IsNullOrEmpty(headerNote) ? header : PpxLT3vj082(header, headerNote))
		};
		if (!string.IsNullOrEmpty(tooltip))
		{
			menuItem.ToolTip = tooltip;
		}
		if (!string.IsNullOrEmpty(icon))
		{
			menuItem.Icon = new IconControl
			{
				Icon = icon,
				Width = iconSize,
				Height = iconSize
			};
		}
		else if (iconImageSource != null)
		{
			menuItem.Icon = new System.Windows.Controls.Image
			{
				Source = iconImageSource,
				Width = iconSize,
				Height = iconSize
			};
		}
		else if (Math.Abs(iconSize - 16.0) > 0.1)
		{
			menuItem.Icon = new Border
			{
				Width = iconSize,
				Height = iconSize
			};
		}
		if (handler != null)
		{
			menuItem.Click += handler;
		}
		if (command != null)
		{
			menuItem.Command = command;
		}
		if (!insertPosition.HasValue)
		{
			items.Add(menuItem);
		}
		else
		{
			items.Insert(insertPosition.Value, menuItem);
		}
		return menuItem;
	}

	public static bool IsCanPasteIcon()
	{
		if (!ClipboardHelper.IsClipboardHasIconUrl() && !ClipboardHelper.ContainsImage())
		{
			return ClipboardHelper.IsClipboardHasIconFile();
		}
		return true;
	}

	public static void CopyActionId(ActionItem action)
	{
		ClipboardHelper.SetText(action.Id);
		ShowSuccess("动作ID已复制。");
	}

	public static void CopyActionUri(ActionItem action)
	{
		ClipboardHelper.SetText(action.GetUri());
		ShowSuccess("动作URI已复制。");
	}

	public static void CopyActionSourceUrl(ActionItem action)
	{
		string text = CreateSharedActionLink(action.TemplateId);
		ClipboardHelper.SetText(text);
		ShowSuccess("动作网址已复制：" + text + "。");
	}

	public static void CheckFolderActions(ICollection<ActionProfile> profiles)
	{
		IList<string> list = new List<string>();
		foreach (ActionProfile profile in profiles)
		{
			foreach (ActionItem actionItem in profile.ActionItems)
			{
				if (actionItem.ActionType == ActionType.Folder)
				{
					list.Add(profile.Name);
					break;
				}
			}
		}
		if (list.Count > 0)
		{
			TryOpenUrlOrFile("https://www.yuque.com/quicker/versions/remove-action-folder");
			ShowWarning("本版本不支持“动作目录”功能，您需要先清理目录动作。\n请参考刚刚打开的网页中的说明进行操作。\n\n存在此类动作的动作页有：\n " + string.Join("\n ", list));
		}
	}

	public static string GetCurrAppVersion()
	{
		return Assembly.GetExecutingAssembly().GetName().Version.ToString();
	}

	public static string GetCurrAppShortVersion()
	{
		return SoftVersionHelper.GetShortVersionString(GetCurrAppVersion());
	}

	public static int GetActionSizeKb(ActionItem action)
	{
		if (action == null)
		{
			return 0;
		}
		return 1 + ((!string.IsNullOrEmpty(action.Data)) ? (action.Data.Length / 1000) : 0);
	}

	public static (bool isSuccess, string pathName) ShowSaveFileDialog(string filter, string defaultExt, string defaultFileName, string initialDir, string title = null, int filterIndex = 1, bool topmost = false)
	{
		Microsoft.Win32.SaveFileDialog saveFileDialog = new Microsoft.Win32.SaveFileDialog
		{
			Filter = filter,
			InitialDirectory = initialDir,
			DefaultExt = defaultExt,
			FileName = defaultFileName,
			FilterIndex = filterIndex
		};
		if (!string.IsNullOrEmpty(title))
		{
			saveFileDialog.Title = title;
		}
		System.Windows.Window window = new System.Windows.Window
		{
			WindowStyle = WindowStyle.None,
			Width = 0.0,
			Height = 0.0,
			Topmost = topmost,
			ShowInTaskbar = false,
			AllowsTransparency = true,
			ResizeMode = ResizeMode.NoResize
		};
		window.Show();
		try
		{
			if (saveFileDialog.ShowDialog(window) == true)
			{
				return (isSuccess: true, pathName: saveFileDialog.FileName);
			}
			return (isSuccess: false, pathName: "");
		}
		finally
		{
			window.Close();
		}
	}

	public static (bool isSuccess, string pathName) ShowSelectFileDialog(string filter, string defaultExt, string defaultFileName, string initialDir, string title = null, int filterIndex = 1, bool topmost = false)
	{
		Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog
		{
			Filter = filter,
			InitialDirectory = initialDir,
			DefaultExt = defaultExt,
			FileName = defaultFileName,
			FilterIndex = filterIndex
		};
		if (!string.IsNullOrEmpty(title))
		{
			openFileDialog.Title = title;
		}
		System.Windows.Window window = new System.Windows.Window
		{
			WindowStyle = WindowStyle.None,
			Width = 0.0,
			Height = 0.0,
			Topmost = topmost,
			ShowInTaskbar = false,
			AllowsTransparency = true,
			ResizeMode = ResizeMode.NoResize
		};
		window.Show();
		try
		{
			if (openFileDialog.ShowDialog(window) == true)
			{
				return (isSuccess: true, pathName: openFileDialog.FileName);
			}
			return (isSuccess: false, pathName: "");
		}
		finally
		{
			window.Close();
		}
	}

	public static (bool isSuccess, string[] files) ShowSelectMultiFileDialog(string filter, string defaultExt, string defaultFileName, string initialDir, string title = null, int filterIndex = 1, bool topmost = false)
	{
		Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog
		{
			Filter = filter,
			InitialDirectory = initialDir,
			DefaultExt = defaultExt,
			FileName = defaultFileName,
			Multiselect = true,
			FilterIndex = filterIndex
		};
		if (!string.IsNullOrEmpty(title))
		{
			openFileDialog.Title = title;
		}
		System.Windows.Window window = new System.Windows.Window
		{
			WindowStyle = WindowStyle.None,
			Width = 0.0,
			Height = 0.0,
			Topmost = topmost,
			ShowInTaskbar = false
		};
		window.Show();
		try
		{
			if (openFileDialog.ShowDialog() == true)
			{
				return (isSuccess: true, files: openFileDialog.FileNames);
			}
			return (isSuccess: false, files: null);
		}
		finally
		{
			window.Close();
		}
	}

	public static (bool isSuccess, string pathName) ShowSelectFolderDialog(string initialDir, string title = null)
	{
		CommonOpenFileDialog commonOpenFileDialog = new CommonOpenFileDialog
		{
			IsFolderPicker = true
		};
		if (!string.IsNullOrEmpty(initialDir))
		{
			commonOpenFileDialog.InitialDirectory = initialDir;
		}
		if (!string.IsNullOrEmpty(title))
		{
			commonOpenFileDialog.Title = title;
		}
		if (commonOpenFileDialog.ShowDialog() == CommonFileDialogResult.Ok)
		{
			string fileName = commonOpenFileDialog.FileName;
			return (isSuccess: true, pathName: commonOpenFileDialog.FileName);
		}
		return (isSuccess: false, pathName: string.Empty);
	}

	public static string GetMemberLevelName(MemberLevel level)
	{
		return level switch
		{
			MemberLevel.Free => "免费版", 
			MemberLevel.OldFree => "免费版(老用户)", 
			MemberLevel.Basic => "基础版", 
			MemberLevel.Pro => "专业版", 
			_ => level.ToString(), 
		};
	}

	public static bool WaitClipboardChange(int oldNum, int maxMs)
	{
		int num = 0;
		while (true)
		{
			if (num < maxMs)
			{
				if (oldNum != AppState.ClipboardSequenceNumber)
				{
					break;
				}
				Thread.Sleep(2);
				num += 2;
				continue;
			}
			return false;
		}
		return true;
	}

	public static T FindRootWindow<T>() where T : System.Windows.Window
	{
		foreach (object window in System.Windows.Application.Current.Windows)
		{
			if (window is T result)
			{
				return result;
			}
		}
		return null;
	}

	[IteratorStateMachine(typeof(_003CFindRootWindows_003Ed__109<>))]
	public static IEnumerable<T> FindRootWindows<T>() where T : System.Windows.Window
	{
		return new _003CFindRootWindows_003Ed__109<T>(-2);
	}

	public static void ShowHotkeyLimitInfo(System.Windows.Window window)
	{
		ShowVersionLimitInfo(window, $"动作快捷键为专业版功能，免费版可设置 {AppState.DataService.p5LtX4pt458()} 个以便测试使用。", "");
	}

	public static void ShowVersionLimitInfo(System.Windows.Window parent, string linkText, string linkUrl, SettingPageId? settingPageId = null)
	{
		_003C_003Ec__DisplayClass111_0 _003C_003Ec__DisplayClass111_ = new _003C_003Ec__DisplayClass111_0();
		_003C_003Ec__DisplayClass111_.EQn2tWIPj7f = linkText;
		_003C_003Ec__DisplayClass111_.Ada2tkuZTaJ = linkUrl;
		_003C_003Ec__DisplayClass111_.Kfc2tGhjL08 = settingPageId;
		_003C_003Ec__DisplayClass111_.hkS2tsIRvc6 = parent;
		RunOnUiThread(false, _003C_003Ec__DisplayClass111_.Ybm2tIQVXnZ);
	}

	public static void ShowVersionLimitInfo(string functionName)
	{
		ShowWarning("“" + functionName + "” 为专业版功能，需购买后使用。\n如果您已购买专业版，请重启软件激活。");
	}

	public static void ExitApplication()
	{
		try
		{
			if (FindRootWindow<ActionDesignerWindow>() == null || Confirm("当前有正在编辑的动作，退出后将丢失修改。\n您确认要退出Quicker么？"))
			{
				AppState.ahyt7LTMcOZ(true);
				if (AppState.r4itaWBnyVQ() != null)
				{
					AppState.r4itaWBnyVQ().IsEnabled = false;
				}
				if (System.Windows.Application.Current != null)
				{
					System.Windows.Application.Current.Shutdown();
				}
			}
		}
		catch (Exception ex)
		{
			D0cLTzhCMW5.Warn("ExitApplication:" + ex.Message, ex);
		}
	}

	public static void EditInCodeEditor(System.Windows.Controls.TextBox textBox, XAction action = null)
	{
		CodeEditorWindow codeEditorWindow = new CodeEditorWindow(action?.Variables, true, null)
		{
			Owner = System.Windows.Window.GetWindow(textBox),
			Text = textBox.Text
		};
		codeEditorWindow.ShowDialog();
		textBox.Text = codeEditorWindow.Text;
	}

	public static bool IsOnQuicker()
	{
		NativeMethods.GetWindowThreadProcessId(NativeMethods.WindowFromPoint(NativeMethods.GetMousePosition()), out uint processId);
		return processId == AppState.QuickerProcessId;
	}

	public static void RunOnUiThread(bool waiteToComplete, Action acton, DispatcherPriority dispatcherPriority = DispatcherPriority.Send)
	{
		_003C_003Ec__DisplayClass117_0 _003C_003Ec__DisplayClass117_ = new _003C_003Ec__DisplayClass117_0();
		_003C_003Ec__DisplayClass117_.fTY2tbfEBOs = acton;
		if (Thread.CurrentThread.ManagedThreadId == AppState.UiThreadId)
		{
			try
			{
				_003C_003Ec__DisplayClass117_.fTY2tbfEBOs();
				return;
			}
			catch (Exception ex)
			{
				D0cLTzhCMW5.Warn("RunOnUiThread错误：" + ex.Message, ex);
				ShowWarning(ex.Message);
				return;
			}
		}
		if (waiteToComplete)
		{
			Dispatcher dispatcher = System.Windows.Application.Current.Dispatcher;
			if (dispatcher == null)
			{
				return;
			}
			dispatcher.Invoke(_003C_003Ec__DisplayClass117_.zrg2tHwixMd, dispatcherPriority);
			if (!xDPwstF8BfKD2AdC5jTu())
			{
				switch (0)
				{
				}
			}
		}
		else
		{
			System.Windows.Application.Current.Dispatcher?.InvokeAsync(_003C_003Ec__DisplayClass117_.MDH2t1Bh29P, dispatcherPriority);
		}
	}

	[AsyncStateMachine(typeof(_003CRunOnUiThreadAsync_003Ed__118))]
	internal static Task ByuLTpc7Q9J(Func<Task> func_0)
	{
		_003CRunOnUiThreadAsync_003Ed__118 stateMachine = default(_003CRunOnUiThreadAsync_003Ed__118);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine.action = func_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public static string CreateHelpLink(int redirectId, string title)
	{
		return string.Format("{0}/r?id={1}&title={2}", "https://getquicker.net", redirectId, title);
	}

	public static void OpenHelpRedirectLink(int redirectId, string title = "")
	{
		TryOpenUrlOrFile(CreateHelpLink(redirectId, title));
	}

	public static void OpenReidrectLink(int redirectId, string title = "")
	{
		TryOpenUrlOrFile(CreateHelpLink(redirectId, title));
	}

	public static void ExportAction(ActionItem action)
	{
		(bool, string) tuple = ShowSaveFileDialog("*.qka|*.qka", ".qka", action.Title + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".qka", "", "导出动作-" + action.Title);
		if (tuple.Item1)
		{
			try
			{
				XAction value = JsonConvert.DeserializeObject<XAction>(action.Data);
				File.WriteAllText(tuple.Item2, JsonConvert.SerializeObject(value, Formatting.Indented));
				SelectFileInExplorer(tuple.Item2, false);
			}
			catch (Exception ex)
			{
				ShowWarning("导出出错：" + ex.Message);
			}
		}
	}

	public static void OpenVersionInfoPage(string prevVersion, string currVersion)
	{
		_003C_003Ec__DisplayClass123_0 _003C_003Ec__DisplayClass123_ = new _003C_003Ec__DisplayClass123_0();
		_003C_003Ec__DisplayClass123_.XWX2tmCSsxA = prevVersion;
		_003C_003Ec__DisplayClass123_.epN2tKy4cMc = currVersion;
		if (NativeMethods.IsOnWindows10OrLater())
		{
			try
			{
				ShowWindowsToastMessage("已更新至" + SoftVersionHelper.GetShortVersionString(_003C_003Ec__DisplayClass123_.epN2tKy4cMc) + "版", "点击查看详细更新内容...", _003C_003Ec__DisplayClass123_.OWh2tXF3Msh);
				return;
			}
			catch (Exception ex)
			{
				D0cLTzhCMW5.Warn("无法显示系统通知。" + ex.Message, ex);
				_003C_003Ec__DisplayClass123_.ciG2t6fnX5N();
				return;
			}
		}
		_003C_003Ec__DisplayClass123_.ciG2t6fnX5N();
	}

	public static void SendWmCopyMessage()
	{
		NativeMethods.SendMessage(NativeMethods.GetForegroundWindow(), 769, IntPtr.Zero, IntPtr.Zero);
	}

	public static void SendCopyKeys()
	{
		AppState.LogQuickerGetSelected();
		RunAndIgnoreException(_003C_003Ec.DTk2tqL1xd6 ?? (_003C_003Ec.DTk2tqL1xd6 = _003C_003Ec.PIS2tP1NWqa.w1q2tvaOxwV));
	}

	public static void SendPasteKeys()
	{
		RunAndIgnoreException(_003C_003Ec.b8B2tcI19EU ?? (_003C_003Ec.b8B2tcI19EU = _003C_003Ec.PIS2tP1NWqa.JOp2tSKSde1));
	}

	public static void RunAndIgnoreException(Action action)
	{
		try
		{
			action();
		}
		catch (Exception ex)
		{
			D0cLTzhCMW5.Error(ex.Message, ex);
			ShowWarning(ex.GetMessageWithInner());
		}
	}

	public static bool RestartQuicker()
	{
		if (NIXLTne5eZt())
		{
			ShowWarning("请先关闭动作编辑窗口和文本窗口后再重启Quicker。");
			return false;
		}
		try
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = "cmd",
				Arguments = "/C start QuickerStarter.exe  start",
				WindowStyle = ProcessWindowStyle.Hidden,
				WorkingDirectory = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName)
			});
			return true;
		}
		catch (Exception exception)
		{
			D0cLTzhCMW5.Warn("重启Quicker出错：" + exception.GetMessageWithInner(), exception);
			ShowWarning("重启失败，请检查是否有未关闭的动作。错误：" + exception.GetMessageWithInner());
			return false;
		}
	}

	public static string CreateSharedSubProgramLink(SharedActionDto sharedSubProgram)
	{
		return "https://getquicker.net/subprogram?id=" + sharedSubProgram.Id.ToString();
	}

	public static string CreateSharedSubProgramLink(string id)
	{
		return "https://getquicker.net/subprogram?id=" + id;
	}

	public static void ShowRequireVersionWindow(string requireVersion)
	{
		if (MessageBoxHelper.Show("该动作需要Quicker " + requireVersion + ".0 版本，当前版本 " + GetCurrAppVersion() + "。请升级Quicker后再使用本动作。\r\n是否打开新版本下载网址？", "Quicker", MessageBoxButton.OKCancel, MessageBoxImage.Exclamation, MessageBoxResult.None) == MessageBoxResult.OK)
		{
			TryOpenUrlOrFile("https://getquicker.net/Help/Versions");
		}
	}

	public static void PreviewSharedAction(string sharedActionIdStr)
	{
		Guid guid = Guid.Parse(sharedActionIdStr);
		ApiResult<SharedActionDto> apiResult = null;
		try
		{
			apiResult = aFIptTXYsUoTUF4v33R.rh5t1oGDq2S(guid, 0, true).Result;
		}
		catch (Exception ex)
		{
			D0cLTzhCMW5.Warn("获取共享动作失败：" + ex.Message, ex);
			ShowWarning("获取共享动作失败！" + ex.Message);
			return;
		}
		if (apiResult.IsSuccess)
		{
			_003C_003Ec__DisplayClass132_0 _003C_003Ec__DisplayClass132_ = new _003C_003Ec__DisplayClass132_0();
			SharedActionDto data = apiResult.Data;
			_003C_003Ec__DisplayClass132_.dn62trBEajm = data.CreateActionItem(false);
			if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass132_.dn62trBEajm.MinQuickerVersion) && SoftVersionHelper.IsVersionNewer(_003C_003Ec__DisplayClass132_.dn62trBEajm.MinQuickerVersion, GetCurrAppVersion()))
			{
				ShowRequireVersionWindow(_003C_003Ec__DisplayClass132_.dn62trBEajm.MinQuickerVersion);
				return;
			}
			AppState.AWPt7aBJgwA(guid);
			if (!xDPwstF8BfKD2AdC5jTu())
			{
				switch (0)
				{
				}
			}
			RunOnUiThread(false, _003C_003Ec__DisplayClass132_.sqs2txavwVG);
		}
		else
		{
			ShowWarning("获取分享的动作失败。" + apiResult.Message);
		}
	}

	public static void PreviewSharedSubProgram(string id, int revision = 0)
	{
		ApiResult<SharedActionDto> apiResult = null;
		try
		{
			apiResult = aFIptTXYsUoTUF4v33R.rh5t1oGDq2S(Guid.Parse(id), 0, true).Result;
		}
		catch (Exception ex)
		{
			D0cLTzhCMW5.Warn("获取共享子程序失败：" + ex.Message, ex);
			ShowWarning("获取共享子程序失败！" + ex.Message);
			return;
		}
		if (apiResult.IsSuccess)
		{
			_003C_003Ec__DisplayClass133_0 _003C_003Ec__DisplayClass133_ = new _003C_003Ec__DisplayClass133_0();
			SharedActionDto data = apiResult.Data;
			_003C_003Ec__DisplayClass133_.Gc92tBT5AFm = data.CreateActionItem(false);
			RunOnUiThread(false, _003C_003Ec__DisplayClass133_.Coy2tpJuDl0);
		}
		else
		{
			ShowWarning("获取分享的子程序失败。" + apiResult.Message);
		}
	}

	private static (bool isSuccess, string text) S5SLTBq8NuO()
	{
		using UIA3Automation uIA3Automation = new UIA3Automation();
		_003C_003Ec__DisplayClass134_0 _003C_003Ec__DisplayClass134_0_ = default(_003C_003Ec__DisplayClass134_0);
		try
		{
			_003C_003Ec__DisplayClass134_0_.DDe2tQnQOH6 = uIA3Automation.FocusedElement();
		}
		catch
		{
			D0cLTzhCMW5.Info("无法获取焦点元素。");
			return (isSuccess: false, text: null);
		}
		if (_003C_003Ec__DisplayClass134_0_.DDe2tQnQOH6 == null)
		{
			D0cLTzhCMW5.Info("当前没有焦点元素。");
			return (isSuccess: false, text: null);
		}
		string text = QVZLTfUxAvT(ref _003C_003Ec__DisplayClass134_0_);
		if (string.IsNullOrEmpty(text))
		{
			D0cLTzhCMW5.Info("没有选定的文本。");
			return (isSuccess: false, text: null);
		}
		return (isSuccess: true, text: text);
	}

	public static string GetSelectedText(long repeatCount, System.Windows.TextDataFormat format = System.Windows.TextDataFormat.UnicodeText, int waitMs = 200, bool tryUiAuto = false)
	{
		int num = 3;
		string text = default(string);
		while (true)
		{
			_003C_003Ec__DisplayClass135_0 _003C_003Ec__DisplayClass135_ = new _003C_003Ec__DisplayClass135_0();
			int num2 = 2;
			if (xDPwstF8BfKD2AdC5jTu())
			{
				goto IL_001f;
			}
			goto IL_0125;
			IL_0125:
			num2 = num;
			goto IL_001f;
			IL_001f:
			while (true)
			{
				switch (num2)
				{
				case 3:
					break;
				case 2:
					_003C_003Ec__DisplayClass135_.OEC2t5din0s = waitMs;
					_003C_003Ec__DisplayClass135_.uD02tDYWbsm = repeatCount;
					num2 = 0;
					if (QZdXvbF8KvlbKCB4Qdo3 != null)
					{
						continue;
					}
					goto case 1;
				case 1:
					text = null;
					if (tryUiAuto && format.IsEither(System.Windows.TextDataFormat.UnicodeText, System.Windows.TextDataFormat.Text))
					{
						try
						{
							(bool, string) tuple = S5SLTBq8NuO();
							if (tuple.Item1)
							{
								return tuple.Item2;
							}
						}
						catch (Exception exception)
						{
							D0cLTzhCMW5.Warn("通过UIAutomation获取选中文字失败。", exception);
						}
					}
					_003C_003Ec__DisplayClass135_.YOq2t4iuIx7 = AppState.ClipboardSequenceNumber;
					_003C_003Ec__DisplayClass135_.hS02tn88YWC = false;
					DebugHelper.LogExecuteTime(_003C_003Ec__DisplayClass135_.BCE2tjyfBYL, "发送Ctrl+C");
					if (AppState.ClipboardSequenceNumber == _003C_003Ec__DisplayClass135_.YOq2t4iuIx7)
					{
						ClipboardHelper.LogHoldingClipboardProcess();
						throw new InvalidDataException("未能从剪贴板读取文本。");
					}
					goto IL_00b0;
				default:
					return text;
				}
				break;
				IL_00b0:
				for (int i = 0; i < 25; i++)
				{
					if (kWsP1bYRVsfaicfjr67.kuYL5eaZ4ok(format))
					{
						break;
					}
					Thread.Sleep(10);
				}
				if (kWsP1bYRVsfaicfjr67.kuYL5eaZ4ok(format))
				{
					text = ClipboardHelper.TryGetClipboardText(format);
					for (int j = 0; j < 10; j++)
					{
						if (!string.IsNullOrEmpty(text))
						{
							break;
						}
						Thread.Sleep(10);
						text = ClipboardHelper.TryGetClipboardText(format);
					}
					if (!string.IsNullOrEmpty(text))
					{
						num2 = 0;
						if (QZdXvbF8KvlbKCB4Qdo3 == null)
						{
							continue;
						}
						goto IL_0125;
					}
					throw new InvalidDataException($"获得的剪贴板文本为空({format})。");
				}
				throw new InvalidDataException($"剪贴板中没有 {format} 格式的内容。");
			}
		}
	}

	public static string SelectWindowInfo(IntPtr hWnd, System.Windows.Window parentWindow)
	{
		new StringBuilder(400);
		int length = 60;
		List<SimpleOperationItem> list = new List<SimpleOperationItem>();
		string text = NativeMethods.GetWindowTitle(hWnd) ?? "-";
		list.Add(new SimpleOperationItem
		{
			Name = ("标题：" + text).ToShortString(length),
			Key = text
		});
		list.Add(new SimpleOperationItem
		{
			Name = $"句柄：{hWnd}",
			Key = hWnd.ToString()
		});
		string text2 = NativeMethods.GetWindowClass(hWnd) ?? "-";
		list.Add(new SimpleOperationItem
		{
			Name = ("类名：" + text2).ToShortString(length),
			Key = text2
		});
		object obj = NativeMethods.GetWindowText(hWnd);
		int num;
		if (obj == null)
		{
			num = 1;
			if (!xDPwstF8BfKD2AdC5jTu())
			{
				goto IL_0179;
			}
			goto IL_018f;
		}
		goto IL_0245;
		IL_02dc:
		return null;
		IL_0245:
		string text3 = (string)obj;
		list.Add(new SimpleOperationItem
		{
			Name = ("文本：" + text3).ToShortString(length),
			Key = text3
		});
		IntPtr rootWindow = NativeMethods.GetRootWindow(hWnd);
		if (rootWindow != hWnd)
		{
			text = NativeMethods.GetWindowTitle(hWnd) ?? "-";
			list.Add(new SimpleOperationItem
			{
				Name = ("根窗口标题：" + text).ToShortString(length),
				Key = text
			});
			list.Add(new SimpleOperationItem
			{
				Name = $"根窗口句柄：{rootWindow}",
				Key = rootWindow.ToString()
			});
			text2 = NativeMethods.GetWindowClass(hWnd) ?? "-";
			list.Add(new SimpleOperationItem
			{
				Name = ("根窗口类名：" + text2).ToShortString(length),
				Key = text2
			});
		}
		Process processById = Process.GetProcessById(NativeMethods.GetWindowProcessId(hWnd));
		string text4 = processById.ProcessName ?? "-";
		list.Add(new SimpleOperationItem
		{
			Name = ("进程名：" + text4).ToShortString(length),
			Key = text4
		});
		ProcessModule mainModule = processById.MainModule;
		object obj2;
		if (mainModule == null)
		{
			obj2 = null;
		}
		else
		{
			obj2 = mainModule.FileName;
			if (obj2 != null)
			{
				goto IL_013d;
			}
		}
		obj2 = "-";
		goto IL_013d;
		IL_013d:
		string text5 = (string)obj2;
		list.Add(new SimpleOperationItem
		{
			Name = ("程序路径：" + text5).ToShortString(length),
			Key = text5
		});
		num = 0;
		if (xDPwstF8BfKD2AdC5jTu())
		{
			goto IL_0179;
		}
		goto IL_028d;
		IL_0179:
		switch (num)
		{
		case 1:
			break;
		default:
			goto IL_028d;
		case 2:
			goto IL_02dc;
		}
		goto IL_018f;
		IL_028d:
		SelectOperationWindow selectOperationWindow = new SelectOperationWindow(list, ShowWindowLocation.CenterOwner)
		{
			Title = "选择窗口信息",
			Owner = parentWindow
		};
		if (selectOperationWindow.ShowDialog() == true)
		{
			SimpleOperationItem selectedItem = selectOperationWindow.SelectedItem;
			if (selectedItem == null)
			{
				goto IL_02dc;
			}
			return selectedItem.Key;
		}
		return "";
		IL_018f:
		obj = "-";
		goto IL_0245;
	}

	public static void ExportActionsCsv()
	{
		try
		{
			(bool, string) tuple = ShowSaveFileDialog("CSV文件|*.csv", ".csv", "QuickerActions_" + DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".csv", Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "请选择保存位置");
			if (tuple.Item1)
			{
				AppState.DataService.OY0t6FeNKVk(tuple.Item2);
				SelectFileInExplorer(tuple.Item2, false);
			}
		}
		catch (Exception ex)
		{
			ShowWarning("出错了：" + ex.Message);
		}
	}

	public static void ShrinkDbFile()
	{
		Task.Run(_003C_003Ec.lBX2tVHepjF ?? (_003C_003Ec.lBX2tVHepjF = _003C_003Ec.PIS2tP1NWqa.VKC2t26j3Gc));
	}

	public static bool SetForegroundWindow(IntPtr hwnd)
	{
		return NativeMethods.SetForegroundWindow(hwnd);
	}

	public static void ChangeCursorPosition(System.Drawing.Point pt)
	{
		User32.SetCursorPos(pt.X, pt.Y);
		System.Windows.Forms.Cursor.Position = pt;
	}

	public static void MoveCursorTo(System.Drawing.Point pt, bool slowMove, CancellationToken? cancellationToken = null)
	{
		if (!slowMove)
		{
			ChangeCursorPosition(pt);
			return;
		}
		System.Drawing.Point position = System.Windows.Forms.Cursor.Position;
		if (pt == position)
		{
			return;
		}
		double num = Math.Sqrt((pt.X - position.X) * (pt.X - position.X) + (pt.Y - position.Y) * (pt.Y - position.Y)) / 5.0;
		double num2 = (double)(pt.X - position.X) * 1.0 / num;
		double num3 = (double)(pt.Y - position.Y) * 1.0 / num;
		int num4 = 1;
		while (true)
		{
			if ((double)num4 <= num)
			{
				if (!cancellationToken.HasValue || !cancellationToken.GetValueOrDefault().CanBeCanceled)
				{
					int x = position.X + (int)(num2 * (double)num4);
					int y = position.Y + (int)(num3 * (double)num4);
					ChangeCursorPosition(new System.Drawing.Point(x, y));
					Thread.SpinWait(200000);
					num4++;
					continue;
				}
				break;
			}
			ChangeCursorPosition(pt);
			break;
		}
	}

	public static void ShowWindowsToastMessage(string title, string message, Action callback = null, double? expireSeconds = null, string iconPath = null)
	{
		_003C_003Ec__DisplayClass142_0 _003C_003Ec__DisplayClass142_ = new _003C_003Ec__DisplayClass142_0();
		_003C_003Ec__DisplayClass142_.VTM2tTYDrWp = iconPath;
		_003C_003Ec__DisplayClass142_.WJx2tMbUytp = title;
		_003C_003Ec__DisplayClass142_.LF02tA6mfZE = message;
		_003C_003Ec__DisplayClass142_.J9a2tO4fUTR = callback;
		_003C_003Ec__DisplayClass142_.lea2tFIcNX4 = expireSeconds;
		if (!NativeMethods.IsOnWindows10OrLater())
		{
			ShowInformation(_003C_003Ec__DisplayClass142_.LF02tA6mfZE);
		}
		else
		{
			RunOnUiThread(true, _003C_003Ec__DisplayClass142_.yUT2tdNSK29);
		}
	}

	public static void FixMenuAlignProblem()
	{
		try
		{
			if (SystemParameters.MenuDropAlignment)
			{
				typeof(SystemParameters).GetField("_menuDropAlignment", BindingFlags.Static | BindingFlags.NonPublic).SetValue(null, false);
				bool menuDropAlignment = SystemParameters.MenuDropAlignment;
			}
		}
		catch (Exception ex)
		{
			D0cLTzhCMW5.Warn("设置菜单对齐出错：" + ex.Message, ex);
		}
	}

	public static System.Windows.Window GetQuickerActiveWindow()
	{
		_003C_003Ec__DisplayClass144_0 _003C_003Ec__DisplayClass144_ = new _003C_003Ec__DisplayClass144_0();
		_003C_003Ec__DisplayClass144_.MXv2ti9aoFQ = null;
		RunOnUiThread(true, _003C_003Ec__DisplayClass144_.qZ52tlp8qIK);
		return _003C_003Ec__DisplayClass144_.MXv2ti9aoFQ;
	}

	public static (string actionIdOrName, string actionParam) ParseActionIdNameAndParam(string uri)
	{
		int num = uri.IndexOf('?', 0);
		if (num > 0)
		{
			return rTYLTQIksTR(uri, num);
		}
		int num2 = uri.IndexOf(' ');
		if (num2 > 0)
		{
			return rTYLTQIksTR(uri, num2);
		}
		return (actionIdOrName: uri, actionParam: "");
	}

	private static (string actionIdOrName, string actionParam) rTYLTQIksTR(string string_0, int int_0)
	{
		string item = "";
		string item2 = string_0.Substring(0, int_0);
		if (string_0.Length > int_0 + 1)
		{
			item = string_0.Substring(int_0 + 1);
		}
		return (actionIdOrName: item2, actionParam: item);
	}

	public static bool IfMatchThen(string line, string prefix, Action<string> action)
	{
		if (line.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
		{
			action(line.Substring(prefix.Length));
			return true;
		}
		return false;
	}

	public static T ParseEnum<T>(string value, T defaultValue)
	{
		if (string.IsNullOrWhiteSpace(value))
		{
			return defaultValue;
		}
		return (T)Enum.Parse(typeof(T), value.Trim());
	}

	public static T ParseEnum<T>(string value)
	{
		return (T)Enum.Parse(typeof(T), value.Trim());
	}

	public static string PathToUri(string pathOrUrl)
	{
		if (string.IsNullOrEmpty(pathOrUrl))
		{
			return string.Empty;
		}
		if (pathOrUrl.Length < 2)
		{
			return pathOrUrl;
		}
		if (pathOrUrl[1] == ':')
		{
			return new Uri(pathOrUrl).AbsoluteUri;
		}
		return pathOrUrl;
	}

	public static bool IsLeftBtnDown()
	{
		if (!System.Windows.Forms.Control.MouseButtons.HasFlag(MouseButtons.Left))
		{
			return AppState.v5FtaQ4hQfg().EfhvLOJ9JGW();
		}
		return true;
	}

	public static string RemoveInvalidCharsFromFileName(string filename)
	{
		return string.Join("_", filename.Split(Path.GetInvalidFileNameChars()));
	}

	public static void LogErrorAndThrow(string message)
	{
		D0cLTzhCMW5.Error(message);
		throw new InvalidDataException(message);
	}

	public static string NormalizeWindowTitle(string title)
	{
		if (string.IsNullOrEmpty(title))
		{
			return title;
		}
		title = ((title.Length > 250) ? title.Substring(0, 250) : title);
		title = title.Replace("\r\n", "").Replace("\r", "").Replace("\n", "");
		return title;
	}

	[AsyncStateMachine(typeof(_003CUploadImageAsync_003Ed__155))]
	public static Task<(bool isSuccess, string urlOrMessage)> UploadImageAsync(string filePath, UserFileType userFileType)
	{
		_003CUploadImageAsync_003Ed__155 stateMachine = default(_003CUploadImageAsync_003Ed__155);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<(bool, string)>.Create();
		stateMachine.filePath = filePath;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public static bool SafePathExists(string maybePathString)
	{
		try
		{
			return File.Exists(maybePathString) || Directory.Exists(maybePathString);
		}
		catch
		{
			return false;
		}
	}

	public static void OpenFolderWithCustomCommand(string folderPath)
	{
		if (!RunHelper.Run(AppState.HHxtaMaoqJr().CustomOpenFolderCommand.Replace("%path%", folderPath.Trim()), out var pi))
		{
			try
			{
				Process.Start(folderPath);
				ShowWarning("使用自定义命令打开路径失败，已使用系统默认方式打开。");
			}
			catch (Exception ex)
			{
				ShowWarning("运行失败：" + folderPath + " 错误：" + ex.Message);
			}
		}
	}

	public static void ExecuteText(string text, bool runAsAdmin = false)
	{
		text = text.Trim();
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		string[] array = text.Split(new string[2] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
		int num2 = default(int);
		foreach (string text2 in array)
		{
			string text3 = text2;
			try
			{
				if (Path.IsPathRooted(text2) && Directory.Exists(text2.Trim()) && !string.IsNullOrEmpty(AppState.HHxtaMaoqJr().CustomOpenFolderCommand))
				{
					OpenFolderWithCustomCommand(text2.Trim());
					break;
				}
			}
			catch (Exception ex)
			{
				D0cLTzhCMW5.Warn("替换路径出错：" + ex.Message, ex);
			}
			if (runAsAdmin)
			{
				if (xDPwstF8BfKD2AdC5jTu())
				{
					switch (0)
					{
					}
				}
				try
				{
					ProcessStartInfo processStartInfo = new ProcessStartInfo();
					if (SafePathExists(text3))
					{
						processStartInfo.FileName = text3;
					}
					else
					{
						processStartInfo.FileName = "cmd.exe";
						processStartInfo.Arguments = "/c \"" + text3 + "\"";
					}
					processStartInfo.UseShellExecute = true;
					int num = 0;
					if (!xDPwstF8BfKD2AdC5jTu())
					{
						num = num2;
					}
					switch (num)
					{
					default:
						processStartInfo.Verb = "runas";
						Process.Start(processStartInfo);
						break;
					}
					break;
				}
				catch (Exception ex2)
				{
					D0cLTzhCMW5.Warn($"管理员身份运行命令出错，命令：{text3}, 错误：{ex2}", ex2);
				}
			}
			if (!RunHelper.Run(text3, out var pi))
			{
				try
				{
					ActionHelper.StartProcess(text2, null, null, "1", runAsAdmin, false, null);
				}
				catch (Exception ex3)
				{
					ShowWarning("运行失败：" + text2 + " 错误：" + ex3.Message);
				}
			}
		}
	}

	public static Task<bool> OpenUserHomeWithAutoLoginAsync()
	{
		OpenUserHome();
		return Task.FromResult(true);
	}

	public static bool IsMachineValid(string machineList)
	{
		if (string.IsNullOrEmpty(machineList))
		{
			return true;
		}
		if (machineList.IndexOf(Environment.MachineName, StringComparison.OrdinalIgnoreCase) >= 0)
		{
			return machineList.Split(new char[4] { ';', ',', '；', '，' }, StringSplitOptions.RemoveEmptyEntries).Any(_003C_003Ec.EYT2t9L5Bts ?? (_003C_003Ec.EYT2t9L5Bts = _003C_003Ec.PIS2tP1NWqa.cyQ2tNSaSN1));
		}
		return false;
	}

	public static void ShowBitmap(Bitmap bmp, string tooltip)
	{
		_003C_003Ec__DisplayClass161_0 _003C_003Ec__DisplayClass161_ = new _003C_003Ec__DisplayClass161_0();
		_003C_003Ec__DisplayClass161_.i3X2tzueSb1 = bmp;
		_003C_003Ec__DisplayClass161_.SVa2gwdv9rr = tooltip;
		_003C_003Ec__DisplayClass161_.QpL2tfJ1bWt = ImageHelper.BitmapToBitmapSource(_003C_003Ec__DisplayClass161_.i3X2tzueSb1);
		RunOnUiThread(false, _003C_003Ec__DisplayClass161_.xk92t3864oq);
	}

	internal static long fLiLTj0x4QY()
	{
		return DateTime.UtcNow.Ticks / 10000L;
	}

	internal static bool NIXLTne5eZt()
	{
		return FindRootWindows<ActionDesignerWindow>().Any();
	}

	internal static string mXLLT4tZBNH(string string_0)
	{
		string tempFileName = Path.GetTempFileName();
		return tempFileName.Substring(0, tempFileName.Length - 4) + string_0;
	}

	public static System.Windows.DragDropEffects BeginDragFile(DependencyObject dependencyObject, string file)
	{
		return BeginDragFiles(dependencyObject, new string[1] { file });
	}

	public static System.Windows.DragDropEffects BeginDragFiles(DependencyObject dependencyObject, string[] files)
	{
		System.Windows.DataObject data = new System.Windows.DataObject(System.Windows.DataFormats.FileDrop, files);
		return DoDragDropWrap(dependencyObject, data, System.Windows.DragDropEffects.Copy);
	}

	public static System.Windows.DragDropEffects BeginDragText(DependencyObject dependencyObject, string text)
	{
		System.Windows.DataObject data = new System.Windows.DataObject(System.Windows.DataFormats.UnicodeText, text);
		return DoDragDropWrap(dependencyObject, data, System.Windows.DragDropEffects.Copy);
	}

	public static System.Windows.DragDropEffects DoDragDropWrap(DependencyObject dragSource, object data, System.Windows.DragDropEffects allowedEffects)
	{
		try
		{
			return DragDrop.DoDragDrop(dragSource, data, allowedEffects);
		}
		catch (Exception ex)
		{
			D0cLTzhCMW5.Warn("无法启动拖动", ex);
			ShowWarning("无法启动拖动，可能Windows中存在未结束的拖动操作。错误：" + ex.Message);
		}
		return System.Windows.DragDropEffects.None;
	}

	public static void SendHotkey(string hotkeyData)
	{
		Hotkey hotkey = new Hotkey(hotkeyData);
		InputSimulator.Instance.Keyboard.ModifiedKeyStroke(hotkey.GetModifierKeyCodes().ToList(), hotkey.Key, kPoLTdWFLA7());
	}

	public static string GetUrlFavicon(string uriString)
	{
		if (!string.IsNullOrEmpty(uriString) && uriString.Length >= 11 && uriString.StartsWith("http"))
		{
			try
			{
				Uri uri = new Uri(uriString);
				return yyXIB9Yxgd6ACb7T4ig.j53dHOYtcRyb9edAMaZ.ercL5MLtTEv("https://helperservice.getquicker.cn/favicon/get/" + uri.Host);
			}
			catch (Exception ex)
			{
				D0cLTzhCMW5.Warn("获取网址" + uriString + "图标出错：" + ex.Message, ex);
			}
		}
		return string.Empty;
	}

	public static T RandomEnumValue<T>()
	{
		Array values = Enum.GetValues(typeof(T));
		return (T)values.GetValue(new Random().Next(values.Length));
	}

	public static void ShowCircleMenu(string exe = null)
	{
		_003C_003Ec__DisplayClass172_0 _003C_003Ec__DisplayClass172_ = new _003C_003Ec__DisplayClass172_0();
		_003C_003Ec__DisplayClass172_.k1P2ggFdNcy = exe;
		RunOnUiThread(false, _003C_003Ec__DisplayClass172_.BOc2gtH9r10);
	}

	public static void AddGoToPageCommandBinding(UIElement window)
	{
		window.CommandBindings.Add(new CommandBinding(NavigationCommands.GoToPage, _003C_003Ec.OOD2thy60AW ?? (_003C_003Ec.OOD2thy60AW = _003C_003Ec.PIS2tP1NWqa.JwG2tJK1jsg)));
	}

	public static void AddCloseCommandBinding(System.Windows.Window window)
	{
		CommandBinding commandBinding = new CommandBinding(ApplicationCommands.Close, _003C_003Ec.FVU2teQJoWX ?? (_003C_003Ec.FVU2teQJoWX = _003C_003Ec.PIS2tP1NWqa.oHn2t0wD4VO), _003C_003Ec.fq32tYm9ubh ?? (_003C_003Ec.fq32tYm9ubh = _003C_003Ec.PIS2tP1NWqa.UwK2tCAUPDh));
		window.CommandBindings.Add(commandBinding);
	}

	internal static void HP0LT5LCDOi()
	{
		try
		{
			Keys[] array = (Keys[])Enum.GetValues(typeof(Keys));
			foreach (Keys keys in array)
			{
				if (KeyboardHelper.IsKeyDown((VirtualKeyCode)keys))
				{
					InputSimulator.Instance.Keyboard.KeyUp((VirtualKeyCode)keys);
				}
			}
			AppState.v5FtaQ4hQfg().dHavLMV7kRX().RealKeyState.Reset();
			int num = 0;
			if (QZdXvbF8KvlbKCB4Qdo3 != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			CiNTbyM2WDubHspat0P.iBBLdEolQUM().Reset();
		}
		catch (Exception ex)
		{
			ShowWarning(ex.Message);
		}
	}

	internal static string fpULTDMjTQ3(string string_0)
	{
		return yyXIB9Yxgd6ACb7T4ig.j53dHOYtcRyb9edAMaZ.ercL5MLtTEv("https://helperservice.getquicker.cn/exeicon/get/" + Uri.EscapeDataString(string_0));
	}

	internal static int kPoLTdWFLA7()
	{
		int result = 10;
		if (AppState.HHxtaMaoqJr().DefaultModifiedKeyDownDelay > 0)
		{
			return AppState.HHxtaMaoqJr().DefaultModifiedKeyDownDelay;
		}
		string text = AppState.CurrentProcessName?.ToLower();
		switch (text)
		{
		default:
		{
			int num = 0;
			if (QZdXvbF8KvlbKCB4Qdo3 != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (!(text == "mstsc"))
			{
				return 0;
			}
			break;
		}
		case "wps":
		case "et":
		case "wpp":
		case "wpspdf":
			break;
		}
		return result;
	}

	internal static bool x8HLToI6dNE(string string_0)
	{
		return "|firefox|chrome|msedge|vivaldi|iexplore|sogouexplorer|360se|360chrome|QQBrowser|360ChromeX|".IndexOf("|" + string_0 + "|", StringComparison.OrdinalIgnoreCase) >= 0;
	}

	internal static void zD3LTTOpWv0(string string_0)
	{
		if (Guid.TryParse(string_0, out var result))
		{
			try
			{
				_003C_003Ec__DisplayClass179_0 _003C_003Ec__DisplayClass179_ = new _003C_003Ec__DisplayClass179_0();
				_003C_003Ec__DisplayClass179_.uQA2gvqT4rm = aFIptTXYsUoTUF4v33R.G5rt149qpF2(result).GetAwaiter().GetResult();
				if (_003C_003Ec__DisplayClass179_.uQA2gvqT4rm.IsSuccess)
				{
					RunOnUiThread(false, _003C_003Ec__DisplayClass179_.dkd2gLa8FLh);
				}
				else
				{
					ShowWarning(_003C_003Ec__DisplayClass179_.uQA2gvqT4rm.Message);
				}
				return;
			}
			catch (Exception ex)
			{
				ShowWarning(ex.Message);
				return;
			}
		}
		ShowWarning("参数不正确，不是合法的id。");
	}

	internal static void FBLLTMMEKQm(string string_0)
	{
		if (Guid.TryParse(string_0, out var result))
		{
			try
			{
				_003C_003Ec__DisplayClass180_0 _003C_003Ec__DisplayClass180_ = new _003C_003Ec__DisplayClass180_0();
				_003C_003Ec__DisplayClass180_.nY52g2WRfhC = aFIptTXYsUoTUF4v33R.RZ5t1QF4Cjb(result).GetAwaiter().GetResult();
				if (!_003C_003Ec__DisplayClass180_.nY52g2WRfhC.IsSuccess)
				{
					ShowWarning(_003C_003Ec__DisplayClass180_.nY52g2WRfhC.Message);
				}
				else
				{
					RunOnUiThread(false, _003C_003Ec__DisplayClass180_.kF72gSHbrmm);
				}
				return;
			}
			catch (Exception ex)
			{
				ShowWarning(ex.Message);
				return;
			}
		}
		ShowWarning("参数不正确，不是合法的id。");
	}

	internal static bool f7TLTAiCsTC()
	{
		return InputManager.Current.MostRecentInputDevice is KeyboardDevice;
	}

	internal static string ckeLTO9a8ni()
	{
		try
		{
			using Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.IP);
			socket.Connect("223.5.5.5", 65530);
			return (socket.LocalEndPoint as IPEndPoint).Address.ToString();
		}
		catch (Exception ex)
		{
			D0cLTzhCMW5.Warn("获取本地IP失败。" + ex.Message);
			return string.Empty;
		}
	}

	internal static int OLvLTFTFuIP()
	{
		TcpListener tcpListener = new TcpListener(IPAddress.Loopback, 0);
		tcpListener.Start();
		int port = ((IPEndPoint)tcpListener.LocalEndpoint).Port;
		tcpListener.Stop();
		return port;
	}

	[AsyncStateMachine(typeof(_003CInputTextAsync_003Ed__184))]
	internal static Task<(bool isSuccess, string text)> KPBLTUrDvVc(System.Windows.Window window_0, string string_0, string string_1, bool bool_0, string string_2, string string_3, Func<string, string> func_0)
	{
		_003CInputTextAsync_003Ed__184 stateMachine = default(_003CInputTextAsync_003Ed__184);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<(bool, string)>.Create();
		stateMachine.parentWindow = window_0;
		stateMachine.title = string_0;
		stateMachine.prompt = string_1;
		stateMachine.isRequired = bool_0;
		stateMachine.defaultValue = string_2;
		stateMachine.pattern = string_3;
		stateMachine.validator = func_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	internal static void G6sLTlBUsTs(string string_0, bool bool_0, string string_1)
	{
		_003C_003Ec__DisplayClass185_0 _003C_003Ec__DisplayClass185_ = new _003C_003Ec__DisplayClass185_0();
		_003C_003Ec__DisplayClass185_.xBe2gJvb0sY = string_0;
		_003C_003Ec__DisplayClass185_.Mmm2gNMc7vs = new ProcessStartInfo();
		_003C_003Ec__DisplayClass185_.Mmm2gNMc7vs.FileName = _003C_003Ec__DisplayClass185_.xBe2gJvb0sY;
		_003C_003Ec__DisplayClass185_.Mmm2gNMc7vs.UseShellExecute = true;
		_003C_003Ec__DisplayClass185_.Mmm2gNMc7vs.Verb = (bool_0 ? "runas" : null);
		Task.Run((Action)_003C_003Ec__DisplayClass185_.NBT2gu7Tj4N);
	}

	public static void Try(Action action, string successMsg, string failMessage)
	{
		try
		{
			action();
			if (!string.IsNullOrEmpty(successMsg))
			{
				ShowSuccess(successMsg);
			}
		}
		catch (Exception ex)
		{
			if (!string.IsNullOrEmpty(failMessage))
			{
				ShowWarning(failMessage + "\n" + ex.Message);
			}
		}
	}

	public static bool TryCopy(string data, bool showMsg)
	{
		_003C_003Ec__DisplayClass187_0 _003C_003Ec__DisplayClass187_ = new _003C_003Ec__DisplayClass187_0();
		_003C_003Ec__DisplayClass187_.UeX2gC4kHjC = data;
		_003C_003Ec__DisplayClass187_.Ijl2gEMJjHb = showMsg;
		if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass187_.UeX2gC4kHjC))
		{
			return false;
		}
		_003C_003Ec__DisplayClass187_.f8G2gPZVJnn = false;
		Action action = _003C_003Ec__DisplayClass187_.VEE2g0nJxDw;
		if (Thread.CurrentThread.GetApartmentState() == ApartmentState.MTA)
		{
			GaZT3MMHZ3eZxDOySux.UmrLMAuavWB(action).Wait(500);
		}
		else
		{
			action();
		}
		return _003C_003Ec__DisplayClass187_.f8G2gPZVJnn;
	}

	public static Process OpenFolderPath(string path)
	{
		if (Directory.Exists(path))
		{
			UserSettings userSettings = AppState.HHxtaMaoqJr();
			if (userSettings != null && !userSettings.CustomOpenFolderCommand.IsNullOrWhiteSpace())
			{
				OpenFolderWithCustomCommand(path);
				return null;
			}
		}
		return Process.Start(path);
	}

	public static string GetDownloadsPath()
	{
		return KnownFolders.GetPath(KnownFolder.Downloads);
	}

	public static void UpdateProxySettings()
	{
		ProxySetting proxySetting = AO7eLUM7kJyEdiOQu2O.w7cLMa3s1jT();
		try
		{
			if (proxySetting != null)
			{
				switch (proxySetting.Mode)
				{
				case ProxyMode.Disable:
				{
					WebRequest.DefaultWebProxy = null;
					int num = 0;
					if (QZdXvbF8KvlbKCB4Qdo3 != null)
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					case 0:
						break;
					}
					break;
				}
				case ProxyMode.System:
					WebRequest.DefaultWebProxy = WebRequest.GetSystemWebProxy();
					break;
				case ProxyMode.Custom:
					WebRequest.DefaultWebProxy = new WebProxy(new Uri(proxySetting.Server), true)
					{
						Credentials = new NetworkCredential(proxySetting.Username, proxySetting.Password)
					};
					break;
				}
			}
		}
		catch (Exception ex)
		{
			D0cLTzhCMW5.Warn("更新代理设置出错：" + ex.Message, ex);
		}
		aFIptTXYsUoTUF4v33R.NxZt1IVAPHv();
	}

	public static void ApplyProxy(WebRequestHandler handler)
	{
		ProxySetting proxySetting = AO7eLUM7kJyEdiOQu2O.w7cLMa3s1jT();
		if (proxySetting == null)
		{
			handler.Proxy = null;
		}
		else if (proxySetting.Mode == ProxyMode.System)
		{
			handler.UseProxy = true;
			handler.Proxy = WebRequest.GetSystemWebProxy();
		}
		else if (proxySetting.Mode == ProxyMode.Custom)
		{
			try
			{
				handler.UseProxy = true;
				WebProxy proxy = new WebProxy(new Uri(proxySetting.Server), true)
				{
					Credentials = new NetworkCredential(proxySetting.Username, proxySetting.Password)
				};
				handler.Proxy = proxy;
			}
			catch (Exception ex)
			{
				D0cLTzhCMW5.Warn("应用代理设置出错：" + ex.Message, ex);
				ShowWarning("应用代理设置出错：" + ex.Message);
			}
		}
	}

	public static (ProxyMode mode, string server) ForceProxy(WebRequestHandler handler)
	{
		ProxySetting proxySetting = AO7eLUM7kJyEdiOQu2O.w7cLMa3s1jT();
		if (proxySetting == null)
		{
			handler.Proxy = null;
			return (mode: ProxyMode.Disable, server: "");
		}
		if (!string.IsNullOrWhiteSpace(proxySetting.Server))
		{
			handler.UseProxy = true;
			WebProxy proxy = new WebProxy(new Uri(proxySetting.Server), true)
			{
				Credentials = new NetworkCredential(proxySetting.Username, proxySetting.Password)
			};
			handler.Proxy = proxy;
			return (mode: ProxyMode.Custom, server: proxySetting.Server);
		}
		handler.UseProxy = true;
		handler.Proxy = WebRequest.GetSystemWebProxy();
		WebProxy obj = handler.Proxy as WebProxy;
		object obj2;
		if (obj == null)
		{
			obj2 = null;
		}
		else
		{
			Uri address = obj.Address;
			if ((object)address == null)
			{
				obj2 = null;
			}
			else
			{
				obj2 = address.ToString();
				if (obj2 != null)
				{
					goto IL_00ac;
				}
			}
		}
		obj2 = "";
		goto IL_00ac;
		IL_00ac:
		return (mode: ProxyMode.System, server: (string)obj2);
	}

	public static void ApplyProxy(HttpClientHandler handler)
	{
		ProxySetting proxySetting = AO7eLUM7kJyEdiOQu2O.w7cLMa3s1jT();
		if (proxySetting == null)
		{
			handler.Proxy = null;
		}
		else if (proxySetting.Mode == ProxyMode.System)
		{
			handler.UseProxy = true;
			handler.Proxy = WebRequest.GetSystemWebProxy();
		}
		else if (proxySetting.Mode == ProxyMode.Custom)
		{
			try
			{
				handler.UseProxy = true;
				WebProxy proxy = new WebProxy(new Uri(proxySetting.Server), true)
				{
					Credentials = new NetworkCredential(proxySetting.Username, proxySetting.Password)
				};
				handler.Proxy = proxy;
			}
			catch (Exception ex)
			{
				D0cLTzhCMW5.Warn("应用代理设置出错：" + ex.Message, ex);
				ShowWarning("应用代理设置出错：" + ex.Message);
			}
		}
	}

	public static IWebProxy GetProxy()
	{
		ProxySetting proxySetting = AO7eLUM7kJyEdiOQu2O.w7cLMa3s1jT();
		if (proxySetting == null)
		{
			return null;
		}
		if (proxySetting.Mode == ProxyMode.System)
		{
			return WebRequest.GetSystemWebProxy();
		}
		if (proxySetting.Mode == ProxyMode.Custom)
		{
			try
			{
				return new WebProxy(new Uri(proxySetting.Server), true)
				{
					Credentials = new NetworkCredential(proxySetting.Username, proxySetting.Password)
				};
			}
			catch (Exception ex)
			{
				D0cLTzhCMW5.Warn("应用代理设置出错：" + ex.Message, ex);
				ShowWarning("应用代理设置出错：" + ex.Message);
			}
		}
		return null;
	}

	public static bool IsAdministrator()
	{
		WindowsIdentity current = WindowsIdentity.GetCurrent();
		if (current != null)
		{
			return new WindowsPrincipal(current).IsInRole(WindowsBuiltInRole.Administrator);
		}
		return false;
	}

	public static Process OpenTxtFile(string txtFile)
	{
		if (!NativeMethods.IsOnWindows11())
		{
			if (txtFile.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
			{
				return Process.Start(txtFile);
			}
			return Process.Start("notepad", txtFile);
		}
		try
		{
			Process process = Process.Start(new ProcessStartInfo(Path.Combine(Path.GetDirectoryName(GetAppExePath()), "quickerstarter.exe"))
			{
				Arguments = "openfile \"" + txtFile + "\""
			});
			if (process != null && process.WaitForExit(2000))
			{
				int? num = process?.ExitCode;
				int num2 = 0;
				if (QZdXvbF8KvlbKCB4Qdo3 != null)
				{
					int num3 = default(int);
					num2 = num3;
				}
				switch (num2)
				{
				}
				if (num > 0)
				{
					return Process.GetProcessById(num.Value);
				}
			}
			return null;
		}
		catch (Exception ex)
		{
			D0cLTzhCMW5.Warn("无法通过quickerstarter打开 " + txtFile + ":" + ex.Message, ex);
			try
			{
				nVGFy1jAXcXA9v3fxMY.yQQtYes02yS("notepad", txtFile, "");
			}
			catch (Exception ex2)
			{
				D0cLTzhCMW5.Warn("无法打开文本文件" + txtFile + ":" + ex2.Message, ex);
				ShowWarning("无法打开文本文件" + txtFile + ":" + ex.Message);
			}
		}
		return null;
	}

	private static string iXHLTixiBuk(string string_0)
	{
		string text = (string)Registry.GetValue("HKEY_CLASSES_ROOT\\" + string_0, "", "");
		if (!string.IsNullOrEmpty(text))
		{
			string text2 = (string)Registry.GetValue("HKEY_CLASSES_ROOT\\" + text + "\\shell\\open\\command", "", "");
			if (!string.IsNullOrEmpty(text2))
			{
				return text2;
			}
		}
		return null;
	}

	public static string GetTempPath()
	{
		string text = Path.Combine(Path.GetTempPath(), "Quicker");
		FileSystemHelper.EnsureFolderExists(text);
		return text;
	}

	public static ImageSource GetImageSourceFromIconString(string iconStr)
	{
		if (string.IsNullOrWhiteSpace(iconStr)) return null;
		if (iconStr.StartsWith("url:")) iconStr = iconStr.Substring(4);
		try
		{
		    var color = FMP9ONqzXcgZ6r3WmZZ.A4qHeQImJ6()?.DefaultIconColor ?? "#808080";
		    if (iconStr.StartsWith("fa:", StringComparison.OrdinalIgnoreCase))
		        return FaIconHelper.GetImageSourceFromFaIcon(iconStr, color, 48, 1);
		    if (iconStr.EndsWith(".svg", StringComparison.OrdinalIgnoreCase))
		    {
		        var drawing = CpRmjmYrY5NIYQiiVIA.tApqttYCLpKNRcDCrWi.o23L5iqGYrY(iconStr, color, CancellationToken.None).GetAwaiter().GetResult();
		        return drawing == null ? null : new DrawingImage(drawing);
		    }
		    return ImageCache.GetImageSource(iconStr, 48);
		}
		catch (Exception error) { D0cLTzhCMW5.Warn("加载本地图标失败：" + iconStr, error); return null; }
	}

	public static void SetWindowIcon(System.Windows.Window window, string iconStr, bool setOverlay)
	{
		if (!string.IsNullOrEmpty(iconStr))
		{
			try
			{
				ImageSource imageSourceFromIconString = GetImageSourceFromIconString(iconStr);
				window.Icon = imageSourceFromIconString;
			}
			catch (Exception ex)
			{
				D0cLTzhCMW5.Warn("设置图标出错：" + ex.Message, ex);
			}
		}
	}

	public static long ForceGCAndCompact()
	{
		GCSettings.LargeObjectHeapCompactionMode = GCLargeObjectHeapCompactionMode.CompactOnce;
		return GC.GetTotalMemory(true);
	}

	static AppHelper()
	{
		D0cLTzhCMW5 = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		bStLMwNoecq = new MessageOptions
		{
			FontSize = 15.0,
			UnfreezeOnMouseLeave = true,
			NotificationClickAction = NxTLTXpv1fg
		};
		ImageExtensions = new List<string> { ".JPG", ".JPEG", ".BMP", ".GIF", ".PNG", ".ICO", ".TIFF", ".TIF" };
		flbLMtwwPRg = new Dictionary<string, ImageSource>();
		vEgLMgfnEQg = new DebounceTimer();
	}

	[CompilerGenerated]
	internal static object PpxLT3vj082(string string_0, string string_1)
	{
		System.Windows.Controls.Grid grid = new System.Windows.Controls.Grid();
		grid.ColumnDefinitions.Add(new ColumnDefinition
		{
			Width = new GridLength(1.0, GridUnitType.Star)
		});
		grid.ColumnDefinitions.Add(new ColumnDefinition
		{
			Width = GridLength.Auto
		});
		grid.Children.Add(new TextBlock
		{
			Text = string_0
		});
		grid.Children.Add(new TextBlock
		{
			Text = string_1,
			Opacity = 0.5,
			Margin = new Thickness(10.0, 0.0, 0.0, 0.0)
		});
		grid.Children[1].SetValue(System.Windows.Controls.Grid.ColumnProperty, 1);
		return grid;
	}

	[CompilerGenerated]
	internal static string QVZLTfUxAvT(ref _003C_003Ec__DisplayClass134_0 _003C_003Ec__DisplayClass134_0_0)
	{
		if (_003C_003Ec__DisplayClass134_0_0.DDe2tQnQOH6.Patterns.Text.TryGetPattern(out var pattern) && pattern.SupportedTextSelection != SupportedTextSelection.None)
		{
			ITextRange[] selection = pattern.GetSelection();
			if (selection != null && selection.Length != 0)
			{
				return selection[0].GetText(int.MaxValue);
			}
		}
		if (_003C_003Ec__DisplayClass134_0_0.DDe2tQnQOH6.Patterns.Text2.TryGetPattern(out var pattern2) && pattern2.SupportedTextSelection != SupportedTextSelection.None)
		{
			ITextRange[] selection2 = pattern2.GetSelection();
			if (selection2 != null && selection2.Length != 0)
			{
				int num = 0;
				if (QZdXvbF8KvlbKCB4Qdo3 != null)
				{
					int num2 = default(int);
					num = num2;
				}
				return num switch
				{
					_ => selection2[0].GetText(int.MaxValue), 
				};
			}
		}
		if (_003C_003Ec__DisplayClass134_0_0.DDe2tQnQOH6.Patterns.TextEdit.TryGetPattern(out var pattern3) && pattern3.SupportedTextSelection != SupportedTextSelection.None)
		{
			ITextRange[] selection3 = pattern3.GetSelection();
			if (selection3 != null && selection3.Length != 0)
			{
				return selection3[0].GetText(int.MaxValue);
			}
		}
		return null;
	}

	internal static bool xDPwstF8BfKD2AdC5jTu()
	{
		return QZdXvbF8KvlbKCB4Qdo3 == null;
	}
}
