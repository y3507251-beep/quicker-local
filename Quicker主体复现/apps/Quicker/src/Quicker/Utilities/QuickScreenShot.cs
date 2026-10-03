using System;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using gNDpGkYZYbhLdMnAyKv;
using log4net;
using Quicker.Common.Entities;
using Quicker.Domain;
using Quicker.Domain.Actions.Runtime;
using Quicker.Domain.Actions.X.BuiltinRunners.Images;
using Quicker.Domain.ContextMenus;
using Quicker.Public.Entities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Images;
using Quicker.View;

namespace Quicker.Utilities;

public static class QuickScreenShot
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass1_0
	{
		public Rectangle T7wSz5sKWBP;

		public Bitmap JwWSzDrSjBA;

		public string XYDSzdhPWP1;

		public Func<System.Drawing.Image> EUUSzoUSdWO;

		public Action XmcSzTlYHuI;

		internal static _003C_003Ec__DisplayClass1_0 lwxejdynvO11h8Y00FtU;

		internal void NYjSzjfyRl6()
		{
			Thread.Sleep(50);
			AppHelper.RunOnUiThread(false, XmcSzTlYHuI ?? (XmcSzTlYHuI = E0hSzn1Mwcy));
		}

		internal void E0hSzn1Mwcy()
		{
			System.Windows.Controls.ContextMenu contextMenu = new System.Windows.Controls.ContextMenu();
			ContentContextMenuService.BuildImageContextMenu(contextMenu.Items, EUUSzoUSdWO ?? (EUUSzoUSdWO = PdwSz4JuDRb), T7wSz5sKWBP);
			AppState.RegisterContextMenu(contextMenu);
			contextMenu.IsOpen = true;
		}

		internal System.Drawing.Image PdwSz4JuDRb()
		{
			return JwWSzDrSjBA;
		}

		internal static bool One9KTyndlJWko1sduNB()
		{
			return lwxejdynvO11h8Y00FtU == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass1_1
	{
		public BitmapSource Y1pSzAoCpVI;

		public _003C_003Ec__DisplayClass1_0 TcySzOy8kj9;

		private static _003C_003Ec__DisplayClass1_1 Rl1IojynkB6wVS8hx7HQ;

		internal void lt6SzMGG6t1()
		{
			ImageViewerWindow imageViewerWindow = new ImageViewerWindow(Y1pSzAoCpVI)
			{
				ImageFilePath = "",
				Location = ShowWindowLocation.Manual,
				Position = $"{TcySzOy8kj9.T7wSz5sKWBP.Left},{TcySzOy8kj9.T7wSz5sKWBP.Top},{TcySzOy8kj9.T7wSz5sKWBP.Left + TcySzOy8kj9.T7wSz5sKWBP.Width},{TcySzOy8kj9.T7wSz5sKWBP.Top + TcySzOy8kj9.T7wSz5sKWBP.Height}",
				InitialScale = 1.0,
				AutoCloseSeconds = 0.0,
				AutoCloseKey = "",
				QuickScreenShotBitmap = TcySzOy8kj9.JwWSzDrSjBA,
				QuickScreenShotArea = TcySzOy8kj9.T7wSz5sKWBP,
				IsForQuickScreenShot = true
			};
			int num = 0;
			if (Rl1IojynkB6wVS8hx7HQ != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			imageViewerWindow.ImageFilePath = TcySzOy8kj9.XYDSzdhPWP1;
			imageViewerWindow.Show();
		}

		internal static bool FnZs5MynaNY758dJMIN4()
		{
			return Rl1IojynkB6wVS8hx7HQ == null;
		}
	}

	private static readonly ILog vOLLoXuYqDN;

	internal static object GOU2tsF5U98Jvua87XDO;

	public static void CaptureAreaAndShow(Point ptStart, Point ptEnd)
	{
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
		_003C_003Ec__DisplayClass1_.T7wSz5sKWBP = new Rectangle(Math.Min(ptStart.X, ptEnd.X), Math.Min(ptStart.Y, ptEnd.Y), Math.Abs(ptEnd.X - ptStart.X) + 1, Math.Abs(ptEnd.Y - ptStart.Y) + 1);
		_003C_003Ec__DisplayClass1_.JwWSzDrSjBA = CaptureStep.CaptureArea(_003C_003Ec__DisplayClass1_.T7wSz5sKWBP);
		_003C_003Ec__DisplayClass1_.XYDSzdhPWP1 = "";
		ScreenShotSettings screenShotSettings = AppState.DataService.CpItmVISR7P().ScreenShotSettings;
		if (screenShotSettings != null && screenShotSettings.AutoSave)
		{
			string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "Quicker", "ScreenShot");
			try
			{
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				_003C_003Ec__DisplayClass1_.XYDSzdhPWP1 = Path.Combine(text, DateTime.Now.ToString("yyyyMMdd_hhMMss_fff") + ".png");
				_003C_003Ec__DisplayClass1_.JwWSzDrSjBA.Save(_003C_003Ec__DisplayClass1_.XYDSzdhPWP1);
			}
			catch (Exception exception)
			{
				vOLLoXuYqDN.Warn("保存图片文件出错：" + exception.GetMessageWithInner(), exception);
				AppHelper.ShowWarning("保存图片文件出错：" + exception.GetMessageWithInner());
			}
		}
		ScreenShotSettings screenShotSettings2 = AppState.DataService.CpItmVISR7P().ScreenShotSettings;
		if (screenShotSettings2 != null && screenShotSettings2.PinImage)
		{
			if (_003C_003Ec__DisplayClass1_.JwWSzDrSjBA.Width >= 2 && _003C_003Ec__DisplayClass1_.JwWSzDrSjBA.Height >= 2)
			{
				_003C_003Ec__DisplayClass1_1 _003C_003Ec__DisplayClass1_2 = new _003C_003Ec__DisplayClass1_1();
				_003C_003Ec__DisplayClass1_2.TcySzOy8kj9 = _003C_003Ec__DisplayClass1_;
				_003C_003Ec__DisplayClass1_2.Y1pSzAoCpVI = ImageHelper.BitmapToBitmapSource(_003C_003Ec__DisplayClass1_2.TcySzOy8kj9.JwWSzDrSjBA);
				AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass1_2.lt6SzMGG6t1);
			}
			else
			{
				AppHelper.ShowWarning("图片太小了，无法贴图。");
			}
		}
		ScreenShotSettings screenShotSettings3 = AppState.DataService.CpItmVISR7P().ScreenShotSettings;
		if (screenShotSettings3 != null && screenShotSettings3.AutoCopy)
		{
			try
			{
				DataObject dataObject = new DataObject();
				dataObject.SetImage(_003C_003Ec__DisplayClass1_.JwWSzDrSjBA);
				if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass1_.XYDSzdhPWP1) && File.Exists(_003C_003Ec__DisplayClass1_.XYDSzdhPWP1))
				{
					dataObject.SetFileDropList(new StringCollection { _003C_003Ec__DisplayClass1_.XYDSzdhPWP1 });
				}
				kWsP1bYRVsfaicfjr67.ogeL5X5groM(dataObject);
			}
			catch (Exception exception2)
			{
				vOLLoXuYqDN.Warn("复制到剪贴板出错：" + exception2.GetMessageWithInner(), exception2);
				AppHelper.ShowWarning("复制到剪贴板出错：" + exception2.GetMessageWithInner());
			}
		}
		ScreenShotSettings screenShotSettings4 = AppState.DataService.CpItmVISR7P().ScreenShotSettings;
		int num;
		if (screenShotSettings4 == null)
		{
			num = 1;
			if (GOU2tsF5U98Jvua87XDO == null)
			{
				goto IL_02b7;
			}
			goto IL_02d1;
		}
		object value = screenShotSettings4.AutoRunAction;
		goto IL_0285;
		IL_02d1:
		value = null;
		goto IL_0285;
		IL_028c:
		ScreenShotSettings screenShotSettings5 = AppState.DataService.CpItmVISR7P().ScreenShotSettings;
		if (screenShotSettings5 != null && screenShotSettings5.AutoShowMenu)
		{
			num = 0;
			if (!DmvnooF5xjSsNKr2DP4o())
			{
				goto IL_02b7;
			}
			goto IL_035a;
		}
		return;
		IL_02b7:
		switch (num)
		{
		case 2:
			break;
		case 1:
			goto IL_02d1;
		default:
			goto IL_035a;
		}
		goto IL_028c;
		IL_0285:
		if (!string.IsNullOrEmpty((string)value))
		{
			try
			{
				string actionIdOrNameOrTempplateId = AppState.DataService.CpItmVISR7P().ScreenShotSettings?.AutoRunAction;
				AppState.AppServer.ExecuteActionByIdOrName(actionIdOrNameOrTempplateId, null, false, false, false, "", ActionTrigger.QuickScreenShot, new ActionExtraContextData
				{
					CaptureArea = _003C_003Ec__DisplayClass1_.T7wSz5sKWBP,
					CaptureImage = _003C_003Ec__DisplayClass1_.JwWSzDrSjBA
				});
			}
			catch (Exception exception3)
			{
				AppHelper.ShowWarning("自动运行动作异常：" + exception3.GetMessageWithInner());
			}
		}
		goto IL_028c;
		IL_035a:
		Task.Run((Action)_003C_003Ec__DisplayClass1_.NYjSzjfyRl6);
	}

	static QuickScreenShot()
	{
		vOLLoXuYqDN = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool DmvnooF5xjSsNKr2DP4o()
	{
		return GOU2tsF5U98Jvua87XDO == null;
	}
}
