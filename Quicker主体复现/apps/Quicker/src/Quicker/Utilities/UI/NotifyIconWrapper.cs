using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using dkbgyyMixGueocCf9RC;
using HandyControl.Data;
using JTIh7V5l65QV75A93Ly;
using Quicker.Domain;
using Quicker.Domain.Actions;
using Quicker.Domain.Floating;
using Quicker.Domain.Messages;
using Quicker.Domain.Services;
using Quicker.View;
using Quicker.View.Tools;

namespace Quicker.Utilities.UI;

public class NotifyIconWrapper : IDisposable
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		[StructLayout(LayoutKind.Auto)]
		private struct ChEsgNhXhV7L00mKy8a : IAsyncStateMachine
		{
			public int CDF29I4maM6;

			public AsyncVoidMethodBuilder AC329WFuUkg;

			private static object NpmPYjyi5Lm72IEg3n53;

			private void MoveNext()
			{
				try
				{
					AppHelper.ExitApplication();
				}
				catch (Exception exception)
				{
					CDF29I4maM6 = -2;
					AC329WFuUkg.SetException(exception);
					return;
				}
				CDF29I4maM6 = -2;
				AC329WFuUkg.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				AC329WFuUkg.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool rOJtMUyiYWngr3X0AYil()
			{
				return NpmPYjyi5Lm72IEg3n53 == null;
			}
		}

		public static readonly _003C_003Ec Uxv2Eo8SJJo;

		public static EventHandler hq52ET9o6vW;

		public static RoutedEventHandler H5t2EMyLWIh;

		public static RoutedEventHandler qGd2EAtVkm2;

		public static RoutedEventHandler pfH2EOQAIya;

		public static RoutedEventHandler oGs2EF9rnOn;

		public static RoutedEventHandler Jmv2EUCO5MF;

		public static RoutedEventHandler IMY2El260TH;

		public static RoutedEventHandler Lep2EiOmJso;

		public static RoutedEventHandler RtL2E3CK8SQ;

		public static RoutedEventHandler iIB2EfTChRL;

		public static RoutedEventHandler AF52EzDVpG2;

		public static Func<Window, bool> cA32ywhjOD4;

		public static RoutedEventHandler jgF2yth7esk;

		public static RoutedEventHandler Q782ygYWwD1;

		public static RoutedEventHandler ljZ2yLDnCH7;

		public static RoutedEventHandler tWD2yvqsY0k;

		public static RoutedEventHandler wDV2yS0a2ir;

		public static RoutedEventHandler FYZ2y2bMOUT;

		public static RoutedEventHandler MJ82yu8CFPq;

		internal static _003C_003Ec OW2MCIykX9OGroPXX7NN;

		static _003C_003Ec()
		{
			Uxv2Eo8SJJo = new _003C_003Ec();
		}

		internal void dhD2EshV8iD(object sender, EventArgs e)
		{
			NotifyIcon obj = (NotifyIcon)sender;
			obj.Visible = false;
			obj.Dispose();
		}

		internal void k7F2EHL7YxP(object sender, RoutedEventArgs e)
		{
			AppState.HS2taepcAbc().TogglePopupWindow(PopupSource.Menu, null);
		}

		internal void F6C2E1pNI4k(object sender, RoutedEventArgs e)
		{
			AppWindowManager.ShowSettingsWindow(null);
			AppState.HS2taepcAbc().RequestHide();
		}

		internal void FFO2EbmICr8(object sender, RoutedEventArgs e)
		{
			AppState.HS2taepcAbc().ShowExeSettingsWindow(null);
			AppState.HS2taepcAbc().RequestHide();
		}

		internal void iLe2E6YX8UU(object sender, RoutedEventArgs e)
		{
			AppState.HS2taepcAbc().TogglePause();
		}

		internal void sVQ2EX09LQl(object sender, RoutedEventArgs e)
		{
			AppState.AppServer.ToggleTextFloatWindow();
		}

		internal void yve2EmqRmeI(object sender, RoutedEventArgs e)
		{
			AppState.TKStaiOMyPb().SetButtonViewMode(ViewMode.HideAll);
		}

		internal void lJq2EKnZ7Q0(object sender, RoutedEventArgs e)
		{
			AppState.TKStaiOMyPb().SetButtonViewMode(ViewMode.ByProcess);
		}

		internal void OLB2ExX7bwj(object sender, RoutedEventArgs e)
		{
			AppState.TKStaiOMyPb().SetButtonViewMode(ViewMode.ShowAll);
		}

		internal void vxy2ErfrKr7(object sender, RoutedEventArgs e)
		{
			AppState.LockFloatButtonPosition = !AppState.LockFloatButtonPosition;
		}

		internal void TdE2Ep0XsuZ(object sender, RoutedEventArgs e)
		{
			AppState.HS2taepcAbc().FaFgowjP8Gr();
		}

		internal void Fjp2EBwmJFH(object sender, RoutedEventArgs e)
		{
			Window window = System.Windows.Application.Current.Windows.OfType<Window>().FirstOrDefault(cA32ywhjOD4 ?? (cA32ywhjOD4 = Uxv2Eo8SJJo.AlT2EQgV32C));
			if (window != null && window.IsLoaded)
			{
				window.Show();
				window.Activate();
			}
			else
			{
				window = new WindowInfoWindow();
				window.Show();
			}
		}

		internal bool AlT2EQgV32C(Window w)
		{
			return w is WindowInfoWindow;
		}

		internal void DS42EjIO3qE(object sender, RoutedEventArgs e)
		{
			AppHelper.HP0LT5LCDOi();
			AppHelper.ShowSuccess("键盘状态已重置。");
		}

		internal void atE2EnRdQfe(object sender, RoutedEventArgs e)
		{
			FMP9ONqzXcgZ6r3WmZZ.bocHcD7FL8("light");
		}

		internal void PKi2E40wZ0A(object sender, RoutedEventArgs e)
		{
			FMP9ONqzXcgZ6r3WmZZ.bocHcD7FL8("dark");
		}

		internal void daQ2E5R8GE1(object sender, RoutedEventArgs e)
		{
			FMP9ONqzXcgZ6r3WmZZ.bocHcD7FL8("auto");
		}

		internal void MLs2ED7ym3b(object sender, RoutedEventArgs e)
		{
			if (AppHelper.RestartQuicker())
			{
				AppHelper.ExitApplication();
			}
		}

		[AsyncStateMachine(typeof(ChEsgNhXhV7L00mKy8a))]
		internal void j3x2EdOD75C(object sender, RoutedEventArgs e)
		{
			ChEsgNhXhV7L00mKy8a stateMachine = default(ChEsgNhXhV7L00mKy8a);
			stateMachine.AC329WFuUkg = AsyncVoidMethodBuilder.Create();
			stateMachine.CDF29I4maM6 = -1;
			stateMachine.AC329WFuUkg.Start(ref stateMachine);
		}

		internal static bool BynTmYyk2Jmcul6N6tcL()
		{
			return OW2MCIykX9OGroPXX7NN == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass25_0
	{
		public ActionExecuteContext W6Z2yJVOsTT;

		public NotifyIconWrapper Bts2y0TQshc;

		internal static _003C_003Ec__DisplayClass25_0 oxneK8yk3NVZvblRQTBD;

		internal void PVI2yNdF5vF(object sender, RoutedEventArgs e)
		{
			Bts2y0TQshc.xw9v2ntTblr.Stop(W6Z2yJVOsTT);
		}

		internal static bool ME22lhykEOKlPcywk82r()
		{
			return oxneK8yk3NVZvblRQTBD == null;
		}
	}

	private readonly PopupWindow CcEv2jNMVCd;

	private readonly RunningActionMgr xw9v2ntTblr;

	private readonly TextFloatPanelMgr gCgv24voNFb;

	private NotifyIcon jasv25CpHPw;

	private string b8vv2DE5rd7 = "quicker_white.ico";

	private string b4nv2d7ZOK3 = "quicker_disabled1.ico";

	private int xlKv2ojv07X = -1;

	private bool nkjv2TMUXfq = true;

	private MouseButtons O1Yv2Mg95Nc;

	private int q3Cv2AAgNE9;

	internal static NotifyIconWrapper d3DVklFH82tHMNxdtiyU;

	public void SetIconMode(int mode, bool updateIcon = true)
	{
		if (xlKv2ojv07X != mode)
		{
			xlKv2ojv07X = mode;
			FTav2G65bE3(mode);
			if (updateIcon)
			{
				RefreshIcon();
			}
		}
	}

	private void FTav2G65bE3(int int_2)
	{
		if (int_2 == 3)
		{
			if (Quicker.App.Current.n991yfUy4r())
			{
				int_2 = 1;
			}
			else
			{
				int_2 = 2;
				int num = 0;
				if (d3DVklFH82tHMNxdtiyU != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
		}
		switch (int_2)
		{
		default:
			b8vv2DE5rd7 = "quicker.ico";
			b4nv2d7ZOK3 = "quicker_disabled.ico";
			break;
		case 1:
			b8vv2DE5rd7 = "quicker_white.ico";
			b4nv2d7ZOK3 = "quicker_white_disabled.ico";
			break;
		case 2:
			b8vv2DE5rd7 = "quicker_black.ico";
			b4nv2d7ZOK3 = "quicker_white_disabled.ico";
			break;
		}
	}

	public void UpdateIconAfterThemeChange()
	{
		if (xlKv2ojv07X == 3)
		{
			FTav2G65bE3(xlKv2ojv07X);
			RefreshIcon();
		}
	}

	public NotifyIconWrapper(PopupWindow mainWindow, RunningActionMgr runningActionMgr, TextFloatPanelMgr textFloatPanelMgr)
	{
		CcEv2jNMVCd = mainWindow;
		xw9v2ntTblr = runningActionMgr;
		gCgv24voNFb = textFloatPanelMgr;
		if (AppState.HHxtaMaoqJr() != null)
		{
			SetIconMode(AppState.HHxtaMaoqJr().TrayIconType, false);
		}
		else
		{
			SetIconMode(0, false);
		}
		GYsv2sq0ykg();
		AppState.NotifyIconWrapper = this;
	}

	private void GYsv2sq0ykg()
	{
		jasv25CpHPw = new NotifyIcon();
		RefreshIcon();
		jasv25CpHPw.Text = "Quicker";
		jasv25CpHPw.MouseDown += fZav2XYN3lp;
		jasv25CpHPw.BalloonTipClosed += _003C_003Ec.hq52ET9o6vW ?? (_003C_003Ec.hq52ET9o6vW = _003C_003Ec.Uxv2Eo8SJJo.dhD2EshV8iD);
		jasv25CpHPw.DoubleClick += UeEv2bJR00K;
		jasv25CpHPw.Visible = true;
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "DestroyIcon")]
	private static extern bool BZhv2HEv5PD(IntPtr intptr_0);

	public void RefreshIcon()
	{
		string text = (nkjv2TMUXfq ? b8vv2DE5rd7 : b4nv2d7ZOK3);
		using Stream stream = System.Windows.Application.GetResourceStream(new Uri("pack://application:,,,/" + Assembly.GetEntryAssembly().GetName().Name + ";component/" + text)).Stream;
		Icon icon = new Icon(stream);
		if (q3Cv2AAgNE9 > 0)
		{
			vNnv21gsgUk(icon);
		}
		else
		{
			jasv25CpHPw.Icon = icon;
		}
	}

	private void vNnv21gsgUk(Icon icon_0)
	{
		using Bitmap bitmap = new Bitmap(32, 32);
		using Graphics graphics = Graphics.FromImage(bitmap);
		graphics.DrawIcon(icon_0, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
		float num = 20f;
		PointF pointF = new PointF((float)bitmap.Width - num, (float)bitmap.Height - num);
		graphics.FillEllipse(Brushes.OrangeRed, pointF.X, pointF.Y, num, num);
		string s = ((q3Cv2AAgNE9 > 9) ? "n" : q3Cv2AAgNE9.ToString());
		RectangleF layoutRectangle = new RectangleF(pointF.X + 2f, pointF.Y + 2f, num - 2f, num - 2f);
		Font font = new Font("Arial", 9f, System.Drawing.FontStyle.Bold);
		StringFormat stringFormat = new StringFormat();
		stringFormat.Alignment = StringAlignment.Center;
		stringFormat.LineAlignment = StringAlignment.Center;
		graphics.DrawString(s, font, Brushes.White, layoutRectangle, stringFormat);
		if (d3DVklFH82tHMNxdtiyU == null)
		{
			switch (0)
			{
			}
		}
		Icon icon = Icon.FromHandle(bitmap.GetHicon());
		jasv25CpHPw.Icon = icon;
		BZhv2HEv5PD(icon.Handle);
	}

	public void RefreshActionCount()
	{
		int num = xw9v2ntTblr.Count();
		if (num != q3Cv2AAgNE9)
		{
			q3Cv2AAgNE9 = num;
			RefreshIcon();
		}
	}

	private void UeEv2bJR00K(object sender, EventArgs e)
	{
		if (O1Yv2Mg95Nc != MouseButtons.Right && !CcEv2jNMVCd.TogglePause())
		{
			Task.Run((Action)XKbv2xVJBsa);
		}
	}

	public void UpdatePopupState(bool isEnabled)
	{
		nkjv2TMUXfq = isEnabled;
		RefreshIcon();
	}

	public void Release()
	{
		if (jasv25CpHPw != null)
		{
			jasv25CpHPw.Dispose();
			jasv25CpHPw = null;
		}
	}

	private static string cHYv26lQqEa(int int_2)
	{
		StringBuilder stringBuilder = new StringBuilder(20);
		if (int_2 > 3600)
		{
			stringBuilder.Append($"{int_2 / 3600}时");
			int_2 %= 3600;
		}
		if (int_2 > 60)
		{
			stringBuilder.Append($"{int_2 / 60}分");
			int_2 %= 60;
		}
		stringBuilder.Append($"{int_2}秒");
		if (OC70e0FHRbFlyMwdFwbk())
		{
			switch (0)
			{
			}
		}
		return stringBuilder.ToString();
	}

	private void fZav2XYN3lp(object sender, MouseEventArgs e)
	{
		O1Yv2Mg95Nc = e.Button;
		if (e.Button == MouseButtons.Left)
		{
			CcEv2jNMVCd.TogglePopupWindow(PopupSource.Menu, null);
		}
		else if (e.Button == MouseButtons.Right)
		{
			m0Nv2m88llM();
		}
	}

	private void m0Nv2m88llM()
	{
		System.Windows.Controls.ContextMenu contextMenu = new System.Windows.Controls.ContextMenu();
		contextMenu.Placement = PlacementMode.Mouse;
		int num;
		if (Quicker.App.Current.Brm1CjxFTF() != SkinType.Dark)
		{
			num = 1;
			if (d3DVklFH82tHMNxdtiyU == null)
			{
				goto IL_07a0;
			}
			goto IL_07af;
		}
		object obj = "#FFF";
		goto IL_003c;
		IL_07a0:
		switch (num)
		{
		case 1:
			break;
		default:
			goto IL_07ba;
		}
		goto IL_07af;
		IL_07ba:
		AppHelper.AddMenuItem(contextMenu.Items, "退出", "关闭Quicker软件", "fa:Light_SignOut:#FF0000", _003C_003Ec.MJ82yu8CFPq ?? (_003C_003Ec.MJ82yu8CFPq = _003C_003Ec.Uxv2Eo8SJJo.j3x2EdOD75C));
		contextMenu.IsOpen = true;
		return;
		IL_07af:
		obj = "#000";
		goto IL_003c;
		IL_003c:
		string text = (string)obj;
		AppHelper.AddMenuItem(contextMenu.Items, "显示面板窗口", "弹出面板窗口", "fa:Light_ArrowSquareUp:" + text, _003C_003Ec.H5t2EMyLWIh ?? (_003C_003Ec.H5t2EMyLWIh = _003C_003Ec.Uxv2Eo8SJJo.k7F2EHL7YxP));
		AppHelper.AddMenuItem(contextMenu.Items, "设置", "打开设置窗口", "fa:Light_Cog:" + text, _003C_003Ec.qGd2EAtVkm2 ?? (_003C_003Ec.qGd2EAtVkm2 = _003C_003Ec.Uxv2Eo8SJJo.F6C2E1pNI4k));
		AppHelper.AddMenuItem(contextMenu.Items, "场景与动作", "打开场景与动作管理窗口", "fa:Solid_Th:" + text, _003C_003Ec.pfH2EOQAIya ?? (_003C_003Ec.pfH2EOQAIya = _003C_003Ec.Uxv2Eo8SJJo.FFO2EbmICr8));
		AppHelper.AddMenuItem(contextMenu.Items, AppState.xhbt79wekbs() ? "暂停" : "恢复", "暂停和恢复Quicker触发", "fa:Light_Pause:" + text, _003C_003Ec.oGs2EF9rnOn ?? (_003C_003Ec.oGs2EF9rnOn = _003C_003Ec.Uxv2Eo8SJJo.iLe2E6YX8UU));
		AppHelper.AddMenuItem(contextMenu.Items, AppState.TextFloatPanelMgr.IsEnabled ? "关闭文本悬浮窗" : "开启文本悬浮窗", "", "fa:Solid_Circle:#B0B0B0", _003C_003Ec.Jmv2EUCO5MF ?? (_003C_003Ec.Jmv2EUCO5MF = _003C_003Ec.Uxv2Eo8SJJo.sVQ2EX09LQl));
		int num2 = AppState.TKStaiOMyPb().T8FtW9pjdDA();
		if (num2 > 0)
		{
			System.Windows.Controls.MenuItem menuItem = AppHelper.AddMenuItem(contextMenu.Items, $"悬浮按钮(共{num2}个)", "管理悬浮按钮", "fa:Light_UfoBeam:" + text, null);
			AppHelper.AddMenuItem(menuItem.Items, $"关闭所有悬浮按钮 (共{num2}个)", "", "fa:Light_Times:" + text, tLqv2pfpVwr);
			AppHelper.AddMenuSeparator(menuItem.Items);
			AppHelper.AddMenuItem(menuItem.Items, "隐藏全部", "隐藏所有悬浮按钮", "", _003C_003Ec.IMY2El260TH ?? (_003C_003Ec.IMY2El260TH = _003C_003Ec.Uxv2Eo8SJJo.yve2EmqRmeI)).IsChecked = AppState.TKStaiOMyPb().FloatViewMode == ViewMode.HideAll;
			AppHelper.AddMenuItem(menuItem.Items, "自动(按进程关联)", "按悬浮按钮的关联进程自动切换显示和隐藏", "", _003C_003Ec.Lep2EiOmJso ?? (_003C_003Ec.Lep2EiOmJso = _003C_003Ec.Uxv2Eo8SJJo.lJq2EKnZ7Q0)).IsChecked = AppState.TKStaiOMyPb().FloatViewMode == ViewMode.ByProcess;
			AppHelper.AddMenuItem(menuItem.Items, "显示全部", "显示所有悬浮按钮", "", _003C_003Ec.RtL2E3CK8SQ ?? (_003C_003Ec.RtL2E3CK8SQ = _003C_003Ec.Uxv2Eo8SJJo.OLB2ExX7bwj)).IsChecked = AppState.TKStaiOMyPb().FloatViewMode == ViewMode.ShowAll;
			AppHelper.AddMenuSeparator(menuItem.Items);
			AppHelper.AddMenuItem(menuItem.Items, "锁定位置", "禁止移动悬浮按钮位置，避免误触", "", _003C_003Ec.iIB2EfTChRL ?? (_003C_003Ec.iIB2EfTChRL = _003C_003Ec.Uxv2Eo8SJJo.vxy2ErfrKr7)).IsChecked = AppState.LockFloatButtonPosition;
		}
		AppHelper.AddMenuItem(contextMenu.Items, "键鼠录制工具", "录制键盘和鼠标操作并生成动作", "fa:Light_Video:" + text, _003C_003Ec.AF52EzDVpG2 ?? (_003C_003Ec.AF52EzDVpG2 = _003C_003Ec.Uxv2Eo8SJJo.TdE2Ep0XsuZ));
		AppHelper.AddMenuItem(contextMenu.Items, "窗口检查工具", "", "fa:Light_Window:" + text, _003C_003Ec.jgF2yth7esk ?? (_003C_003Ec.jgF2yth7esk = _003C_003Ec.Uxv2Eo8SJJo.Fjp2EBwmJFH));
		AppHelper.AddMenuItem(contextMenu.Items, "重新加载键鼠挂钩", "", "fa:Light_MousePointer:" + text, hUhv2BdpLIZ);
		AppHelper.AddMenuItem(contextMenu.Items, "重置键盘状态", "", "fa:Light_Keyboard:" + text, _003C_003Ec.Q782ygYWwD1 ?? (_003C_003Ec.Q782ygYWwD1 = _003C_003Ec.Uxv2Eo8SJJo.DS42EjIO3qE));
		System.Windows.Controls.MenuItem menuItem_ = AppHelper.AddMenuItem(contextMenu.Items, "中止动作", "", "fa:Light_MousePointer:#F03333", null);
		qlFv2KM450M(menuItem_);
		if (AppState.DataService.Hb9tmk3OsJ7())
		{
			System.Windows.Controls.MenuItem menuItem2 = AppHelper.AddMenuItem(contextMenu.Items, "切换主题模式", "", "fa:Light_Moon:" + text, null);
			string text2 = AO7eLUM7kJyEdiOQu2O.ThemeMode;
			Quicker.App.Current.Brm1CjxFTF().GetValueOrDefault();
			AppHelper.AddMenuItem(menuItem2.Items, "浅色", "", "", _003C_003Ec.ljZ2yLDnCH7 ?? (_003C_003Ec.ljZ2yLDnCH7 = _003C_003Ec.Uxv2Eo8SJJo.atE2EnRdQfe)).IsChecked = text2 == "light" || string.IsNullOrEmpty(text2);
			AppHelper.AddMenuItem(menuItem2.Items, "深色", "", "", _003C_003Ec.tWD2yvqsY0k ?? (_003C_003Ec.tWD2yvqsY0k = _003C_003Ec.Uxv2Eo8SJJo.PKi2E40wZ0A)).IsChecked = text2 == "dark";
			AppHelper.AddMenuItem(menuItem2.Items, "跟随Windows", "", "", _003C_003Ec.wDV2yS0a2ir ?? (_003C_003Ec.wDV2yS0a2ir = _003C_003Ec.Uxv2Eo8SJJo.daQ2E5R8GE1)).IsChecked = text2 == "auto";
		}
		AppHelper.AddMenuItem(contextMenu.Items, "重启Quicker", "退出并重新启动", "fa:Light_RedoAlt:#FF0000", _003C_003Ec.FYZ2y2bMOUT ?? (_003C_003Ec.FYZ2y2bMOUT = _003C_003Ec.Uxv2Eo8SJJo.MLs2ED7ym3b));
		num = 0;
		if (!OC70e0FHRbFlyMwdFwbk())
		{
			goto IL_07a0;
		}
		goto IL_07ba;
	}

	private void qlFv2KM450M(System.Windows.Controls.MenuItem menuItem_0)
	{
		menuItem_0.IsEnabled = xw9v2ntTblr.Count() > 0;
		menuItem_0.Items.Clear();
		int num = xw9v2ntTblr.Count();
		if (num > 0)
		{
			using IEnumerator<ActionExecuteContext> enumerator = xw9v2ntTblr.Items.GetEnumerator();
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass25_0 _003C_003Ec__DisplayClass25_ = new _003C_003Ec__DisplayClass25_0();
				_003C_003Ec__DisplayClass25_.Bts2y0TQshc = this;
				_003C_003Ec__DisplayClass25_.W6Z2yJVOsTT = enumerator.Current;
				AppHelper.AddMenuItem(menuItem_0.Items, _003C_003Ec__DisplayClass25_.W6Z2yJVOsTT.Action.Title + " 已运行" + cHYv26lQqEa((int)(DateTime.Now - _003C_003Ec__DisplayClass25_.W6Z2yJVOsTT.StartTime).TotalSeconds), _003C_003Ec__DisplayClass25_.W6Z2yJVOsTT.Action.Description, _003C_003Ec__DisplayClass25_.W6Z2yJVOsTT.Action.Icon, _003C_003Ec__DisplayClass25_.PVI2yNdF5vF);
			}
		}
		if (num < 2)
		{
			return;
		}
		menuItem_0.Items.Add(new Separator());
		System.Windows.Controls.MenuItem menuItem = new System.Windows.Controls.MenuItem();
		menuItem.Header = "全部";
		menuItem.Click += aSiv2QM1WUY;
		if (d3DVklFH82tHMNxdtiyU != null)
		{
			switch (0)
			{
			}
		}
		menuItem_0.Items.Add(menuItem);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing)
		{
			jasv25CpHPw?.Dispose();
		}
	}

	public void Dispose()
	{
		Dispose(true);
		GC.SuppressFinalize(this);
	}

	public void ShowMessage(int timeout, string title, string message, ToolTipIcon icon, Action clickCallback)
	{
		jasv25CpHPw.ShowBalloonTip(timeout, title, message, icon);
	}

	[CompilerGenerated]
	private void XKbv2xVJBsa()
	{
		Thread.Sleep(100);
		AppHelper.RunOnUiThread(false, sfpv2rbgLis);
	}

	[CompilerGenerated]
	private void sfpv2rbgLis()
	{
		CcEv2jNMVCd.Hide();
	}

	[CompilerGenerated]
	private void tLqv2pfpVwr(object sender, RoutedEventArgs e)
	{
		if (AppHelper.Confirm("您确认要清除所有悬浮动作或动作页么？"))
		{
			AppState.Y2RtaqSv0AQ().CloseFloatingButtons(this);
		}
	}

	[CompilerGenerated]
	private void hUhv2BdpLIZ(object sender, RoutedEventArgs e)
	{
		AppState.Y2RtaqSv0AQ().RequestReinstallHook(this);
	}

	[CompilerGenerated]
	private void aSiv2QM1WUY(object sender, RoutedEventArgs e)
	{
		xw9v2ntTblr.StopAll();
	}

	internal static bool OC70e0FHRbFlyMwdFwbk()
	{
		return d3DVklFH82tHMNxdtiyU == null;
	}
}
