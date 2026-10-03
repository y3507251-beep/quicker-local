using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Media;
using CW;
using FontAwesome5;
using HandyControl.Tools;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.Wpf;
using Newtonsoft.Json;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Services;
using Quicker.Modules.TextTools;
using Quicker.Public.Actions;
using Quicker.Public.Entities;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Win32;
using Quicker.View.UI;
using SCyJThYoNMQE7IHLXbA;
using upLrfmibGdtSX9dWuOT;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Common;

public class WebView2Step : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec IYmS88wf6Bi;

		public static Func<string, string> qq7S8ahgkpo;

		public static Func<string, bool> k1YS87pa0v2;

		internal static _003C_003Ec d7D1G3WOHmAMX4j5ARE2;

		static _003C_003Ec()
		{
			IYmS88wf6Bi = new _003C_003Ec();
		}

		internal string b7jS8El4TZY(string x)
		{
			return x.Trim();
		}

		internal bool odGS8yZiixc(string x)
		{
			return !string.IsNullOrEmpty(x);
		}

		internal static bool y7toRbWOzo3Ze1tya4GX()
		{
			return d7D1G3WOHmAMX4j5ARE2 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass100_0
	{
		public string tlRS8qMWBPT;

		public WebView2Window plNS8cW9Gar;

		internal static _003C_003Ec__DisplayClass100_0 xkZ3DWWJQ0TqWlOtfrdW;

		internal void QUeS8RJSoh6()
		{
			foreach (WebView2Window item in AppHelper.FindRootWindows<WebView2Window>())
			{
				if (item.AutoCloseKey == tlRS8qMWBPT && item.IsLoaded)
				{
					plNS8cW9Gar = item;
					break;
				}
			}
		}

		internal static void c7OwnxWJWWXbuSxxeuZ1()
		{
		}

		internal static bool WAExMKWJFrant6cjDmQC()
		{
			return xkZ3DWWJQ0TqWlOtfrdW == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass102_0
	{
		public WebView2Window wwuS8HiQFEd;

		public string url;

		public ShowWindowLocation TrMS81hNFg9;

		public string ud7S8bov9Yk;

		public bool ppHS86sXkI6;

		public string mh0S8XsCcNB;

		public string BidS8m7pVyt;

		public string ncBS8KhnBOU;

		public string mNBS8xyVReX;

		public ActionExecuteContext HCrS8rVbDTH;

		public XAction bZVS8pPNgUM;

		public string VI3S8BBtgwq;

		public bool jbwS8Q2gDpy;

		public bool EcXS8jAgQG1;

		public string Il1S8n7PL3r;

		public bool RK1S84GkRQI;

		public string v2pS85TlMWS;

		public ActionStep tmoS8DPd4iE;

		public bool ck4S8d2eqcf;

		public bool PMPS8oIML7A;

		public string SERS8TR71wj;

		public bool CASS8M0jXgP;

		public bool v47S8AW00aT;

		public IntPtr QgCS8O543yt;

		public WebView2 IimS8FVuPu4;

		public EventHandler yy5S8UQg0vW;

		internal static _003C_003Ec__DisplayClass102_0 TT1DTLWJy2SgL6OYEVb9;

		internal void jEAS8VgeOtN()
		{
			wwuS8HiQFEd.Close();
			wwuS8HiQFEd = null;
		}

		internal void tNGS8Z1ekOE()
		{
			lQ5gCDODkUW(wwuS8HiQFEd);
			wwuS8HiQFEd.UpdateUrl(url);
		}

		internal void T0IS89oI1I0()
		{
			lQ5gCDODkUW(wwuS8HiQFEd);
			wwuS8HiQFEd.UpdateUrlAndPosition(url, TrMS81hNFg9, ud7S8bov9Yk);
		}

		internal void cP5S8h2RRNm()
		{
			lQ5gCDODkUW(wwuS8HiQFEd);
		}

		internal void ilgS8efrKEm(object sender, EventArgs e)
		{
			v47S8AW00aT = true;
		}

		internal void ok4S8YoZ4ZM()
		{
			QgCS8O543yt = wwuS8HiQFEd.GetHandle();
			IimS8FVuPu4 = wwuS8HiQFEd.WebView2;
		}

		internal object DS3S8Ik2Gvl()
		{
			return wwuS8HiQFEd?.CurrentUri;
		}

		internal object jsSS8WbqTpn()
		{
			return wwuS8HiQFEd?.DocTitle;
		}

		internal object PyCS8kqjoM9()
		{
			return wwuS8HiQFEd?.GetSourceCode();
		}

		internal object feCS8GJfFw9()
		{
			return wwuS8HiQFEd?.GetCookies();
		}

		internal object aw3S8sr5W6o()
		{
			return IimS8FVuPu4;
		}

		internal static bool Pb5W7UWJpMxwTAsdM3DM()
		{
			return TT1DTLWJy2SgL6OYEVb9 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass102_1
	{
		public Color? SvhS8iMP8E0;

		public Dictionary<string, string> Y9oS839f7j8;

		public _003C_003Ec__DisplayClass102_0 PtJS8fm3pid;

		private static _003C_003Ec__DisplayClass102_1 OCXs1jWJAgtRJkR0kQEW;

		internal void fRpS8lXiJEo()
		{
			PtJS8fm3pid.wwuS8HiQFEd = new WebView2Window(PtJS8fm3pid.ppHS86sXkI6, PtJS8fm3pid.mh0S8XsCcNB, PtJS8fm3pid.BidS8m7pVyt)
			{
				AutoCloseKey = PtJS8fm3pid.ncBS8KhnBOU,
				WindowSizeStr = PtJS8fm3pid.ud7S8bov9Yk,
				ScriptAfterLoaded = PtJS8fm3pid.mNBS8xyVReX,
				Context = PtJS8fm3pid.HCrS8rVbDTH,
				Action = PtJS8fm3pid.bZVS8pPNgUM,
				IconStr = PtJS8fm3pid.VI3S8BBtgwq,
				ShowToolbar = PtJS8fm3pid.jbwS8Q2gDpy,
				ClearCookies = PtJS8fm3pid.EcXS8jAgQG1,
				DefaultDownloadFolderPath = PtJS8fm3pid.Il1S8n7PL3r
			};
			if (PtJS8fm3pid.RK1S84GkRQI)
			{
				PtJS8fm3pid.wwuS8HiQFEd.WindowStyle = WindowStyle.None;
			}
			if (SvhS8iMP8E0.HasValue)
			{
				PtJS8fm3pid.wwuS8HiQFEd.Background = new SolidColorBrush(SvhS8iMP8E0.Value);
				PtJS8fm3pid.wwuS8HiQFEd.DefaultBgColor = SvhS8iMP8E0.Value.ToSystemDrawingColor();
			}
			PtJS8fm3pid.wwuS8HiQFEd.Url = PtJS8fm3pid.url;
			int num;
			if (!string.IsNullOrEmpty(PtJS8fm3pid.v2pS85TlMWS))
			{
				PtJS8fm3pid.wwuS8HiQFEd.Title = ((PtJS8fm3pid.v2pS85TlMWS.Length > 250) ? PtJS8fm3pid.v2pS85TlMWS.Substring(0, 250) : PtJS8fm3pid.v2pS85TlMWS);
				PtJS8fm3pid.wwuS8HiQFEd.PresetTitle = true;
				num = 1;
				if (OCXs1jWJAgtRJkR0kQEW != null)
				{
					goto IL_0279;
				}
				goto IL_027d;
			}
			goto IL_02a9;
			IL_0409:
			PtJS8fm3pid.QgCS8O543yt = PtJS8fm3pid.wwuS8HiQFEd.GetHandle();
			PtJS8fm3pid.IimS8FVuPu4 = PtJS8fm3pid.wwuS8HiQFEd.WebView2;
			return;
			IL_0279:
			int num2 = default(int);
			num = num2;
			goto IL_027d;
			IL_027d:
			switch (num)
			{
			case 1:
				break;
			default:
				PtJS8fm3pid.wwuS8HiQFEd.Activate();
				if (PtJS8fm3pid.RK1S84GkRQI)
				{
					goto case 2;
				}
				goto IL_0409;
			case 2:
				NativeMethods.SetForegroundWindow(PtJS8fm3pid.wwuS8HiQFEd.GetHandle());
				goto IL_0409;
			}
			goto IL_02a9;
			IL_02a9:
			PtJS8fm3pid.wwuS8HiQFEd.Location = PtJS8fm3pid.TrMS81hNFg9;
			PtJS8fm3pid.wwuS8HiQFEd.SetTopmost = XActionHelper.GetBooleanParamValue(mmmgPJ8LlJQ, PtJS8fm3pid.tmoS8DPd4iE, PtJS8fm3pid.HCrS8rVbDTH);
			PtJS8fm3pid.wwuS8HiQFEd.NoActivate = PtJS8fm3pid.ck4S8d2eqcf;
			PtJS8fm3pid.wwuS8HiQFEd.VirtualHostNameToFolderMappingsDict = Y9oS839f7j8;
			PtJS8fm3pid.wwuS8HiQFEd.ShowInTaskbar = XActionHelper.GetBooleanParamValue(JB0gP0DBkli, PtJS8fm3pid.tmoS8DPd4iE, PtJS8fm3pid.HCrS8rVbDTH);
			PtJS8fm3pid.wwuS8HiQFEd.EscClose = PtJS8fm3pid.PMPS8oIML7A;
			PtJS8fm3pid.wwuS8HiQFEd.CloseWhenLostFocus = XActionHelper.GetTextParamValue(RHYgPPGWgDU, PtJS8fm3pid.tmoS8DPd4iE, PtJS8fm3pid.HCrS8rVbDTH);
			PtJS8fm3pid.wwuS8HiQFEd.UserAgent = PtJS8fm3pid.SERS8TR71wj;
			if (PtJS8fm3pid.wwuS8HiQFEd.NoActivate)
			{
				PtJS8fm3pid.wwuS8HiQFEd.ShowActivated = false;
			}
			if (PtJS8fm3pid.CASS8M0jXgP)
			{
				PtJS8fm3pid.wwuS8HiQFEd.V6hgjEnp8ZH(PtJS8fm3pid.HCrS8rVbDTH.CancellationToken);
				PtJS8fm3pid.wwuS8HiQFEd.Closed += PtJS8fm3pid.yy5S8UQg0vW ?? (PtJS8fm3pid.yy5S8UQg0vW = PtJS8fm3pid.ilgS8efrKEm);
			}
			PtJS8fm3pid.wwuS8HiQFEd.Show();
			if (!PtJS8fm3pid.wwuS8HiQFEd.NoActivate)
			{
				num = 0;
				if (OCXs1jWJAgtRJkR0kQEW != null)
				{
					goto IL_0279;
				}
				goto IL_027d;
			}
			goto IL_0409;
		}

		internal static bool dlFFPiWJn4dQFuRIbKp5()
		{
			return OCXs1jWJAgtRJkR0kQEW == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass91_0
	{
		public ActionStep wnwSawKF8Cx;

		public ActionExecuteContext lTqSatqtSCv;

		public WebView2Step LVuSag1ea5j;

		public XAction jPGSaLbou2l;

		internal static _003C_003Ec__DisplayClass91_0 KQ1OiiWJ3PdrU1d2nB1Z;

		internal (bool isSuccess, string message, ActionStopFlag failReason) nfmS8zNSBS8()
		{
			_003C_003Ec__DisplayClass91_1 _003C_003Ec__DisplayClass91_ = new _003C_003Ec__DisplayClass91_1
			{
				Q5eSa2sOMlZ = this
			};
			string textParamValue = XActionHelper.GetTextParamValue(iBrgCOY5pay, wnwSawKF8Cx, lTqSatqtSCv);
			_003C_003Ec__DisplayClass91_.KthSaSQCXDY = XActionHelper.GetTextParamValue(WFXgPtyJE1V, wnwSawKF8Cx, lTqSatqtSCv);
			if (_003C_003Ec__DisplayClass91_.KthSaSQCXDY == "=")
			{
				_003C_003Ec__DisplayClass91_.KthSaSQCXDY = lTqSatqtSCv.ActionId;
			}
			switch (textParamValue)
			{
			case "Stop":
				return LVuSag1ea5j.Stop(_003C_003Ec__DisplayClass91_.KthSaSQCXDY, lTqSatqtSCv, wnwSawKF8Cx, jPGSaLbou2l);
			case "Close":
				AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass91_.QWqSav9648F);
				break;
			case "Reload":
				return LVuSag1ea5j.Reload(_003C_003Ec__DisplayClass91_.KthSaSQCXDY, lTqSatqtSCv, wnwSawKF8Cx, jPGSaLbou2l);
			case "SendMessage":
				return LVuSag1ea5j.SendMessage(_003C_003Ec__DisplayClass91_.KthSaSQCXDY, lTqSatqtSCv, wnwSawKF8Cx, jPGSaLbou2l);
			case "ExecuteScript":
				return LVuSag1ea5j.ExecuteScript(_003C_003Ec__DisplayClass91_.KthSaSQCXDY, lTqSatqtSCv, wnwSawKF8Cx, jPGSaLbou2l);
			case "CheckInstalled":
			{
				CoreWebView2Environment.GetAvailableBrowserVersionString(null, null);
				bool flag = V1kWZri8vrLTHgNDH0k.kthvSy0kT0j();
				XActionHelper.OutputResult(wWGgPVxESSo, wnwSawKF8Cx, lTqSatqtSCv, flag, jPGSaLbou2l);
				break;
			}
			case "MultiTab_OpenUrl":
				return LVuSag1ea5j.p4ngCj1JTAn(_003C_003Ec__DisplayClass91_.KthSaSQCXDY, lTqSatqtSCv, wnwSawKF8Cx, jPGSaLbou2l);
			case "CheckWindowState":
				return LVuSag1ea5j.CheckWindowState(_003C_003Ec__DisplayClass91_.KthSaSQCXDY, lTqSatqtSCv, wnwSawKF8Cx, jPGSaLbou2l);
			case "OpenUrl":
			case "OpenAndWaitLoad":
			case "OpenUrlAndWaitClose":
				return LVuSag1ea5j.O3PgC5aJUoh(textParamValue, _003C_003Ec__DisplayClass91_.KthSaSQCXDY, lTqSatqtSCv, wnwSawKF8Cx, jPGSaLbou2l);
			case "MultiColumn_OpenUrl":
				return LVuSag1ea5j.I7egCQMCJ0q(_003C_003Ec__DisplayClass91_.KthSaSQCXDY, lTqSatqtSCv, wnwSawKF8Cx, jPGSaLbou2l);
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool FsBjUjWJELbXHYlLePFN()
		{
			return KQ1OiiWJ3PdrU1d2nB1Z == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass91_1
	{
		public string KthSaSQCXDY;

		public _003C_003Ec__DisplayClass91_0 Q5eSa2sOMlZ;

		private static _003C_003Ec__DisplayClass91_1 Wm9HtaWJ0YTCCgP2jGlC;

		internal void QWqSav9648F()
		{
			Q5eSa2sOMlZ.LVuSag1ea5j.BOHgC4ZHqA8(KthSaSQCXDY)?.Close();
		}

		internal static bool NGJZWBWJ11fw8L6eat65()
		{
			return Wm9HtaWJ0YTCCgP2jGlC == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass92_0
	{
		public string QAdSa0Gme5P;

		public MultiColumnWebViewWindow daGSaCQTgEX;

		public IList<CommonOperationItem> xY7SaP0KlZc;

		public string v0tSaET95N8;

		public string bBBSaydDPvB;

		public string bBBSa8DB4Nf;

		public ShowWindowLocation DMUSaa4prUh;

		public string RcrSa70GNML;

		public bool HHrSaRbRTbD;

		public ActionExecuteContext v6ASaqsVjQK;

		internal static _003C_003Ec__DisplayClass92_0 j4EjRRWJBEPtQJVfPeOO;

		internal void xUFSau7YYL3()
		{
			foreach (MultiColumnWebViewWindow item in AppHelper.FindRootWindows<MultiColumnWebViewWindow>())
			{
				if (item.WindowId == QAdSa0Gme5P && item.IsLoaded)
				{
					daGSaCQTgEX = item;
					break;
				}
			}
		}

		internal void DxpSaNkFwtn()
		{
			daGSaCQTgEX.UpdateTabs(xY7SaP0KlZc);
		}

		internal void oB7SaJEOo8c()
		{
			daGSaCQTgEX = new MultiColumnWebViewWindow(xY7SaP0KlZc, v0tSaET95N8, bBBSaydDPvB);
			daGSaCQTgEX.Title = bBBSa8DB4Nf;
			daGSaCQTgEX.Location = DMUSaa4prUh;
			daGSaCQTgEX.WindowSizeStr = RcrSa70GNML;
			daGSaCQTgEX.SetTopmost = HHrSaRbRTbD;
			daGSaCQTgEX.WindowId = QAdSa0Gme5P;
			AppHelper.SetWindowIcon(daGSaCQTgEX, v6ASaqsVjQK.Action?.Icon, false);
			if (j4EjRRWJBEPtQJVfPeOO != null)
			{
				switch (0)
				{
				}
			}
			daGSaCQTgEX.Show();
			daGSaCQTgEX.Activate();
		}

		internal static bool hR0ByTWJvPpQmv7R82kr()
		{
			return j4EjRRWJBEPtQJVfPeOO == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass93_0
	{
		public string n4uSa9KPfA6;

		public MultiWebViewWindow X4SSahaj21g;

		public IList<CommonOperationItem> igPSaeqSufP;

		public string TydSaYh6RNc;

		public string EHoSaIIU6Zj;

		public string IZbSaWPgVRD;

		public ShowWindowLocation MflSakQEIYK;

		public string tJSSaGF5e14;

		public bool M5eSasBlvNI;

		public ActionExecuteContext mVMSaHt1H2B;

		private static _003C_003Ec__DisplayClass93_0 ycbrKWWJkwMZvtpq4YkX;

		internal void DXMSacG6JVv()
		{
			foreach (MultiWebViewWindow item in AppHelper.FindRootWindows<MultiWebViewWindow>())
			{
				if (item.WindowId == n4uSa9KPfA6 && item.IsLoaded)
				{
					X4SSahaj21g = item;
					break;
				}
			}
		}

		internal void nP7SaVxgiGe()
		{
			X4SSahaj21g.UpdateTabs(igPSaeqSufP);
		}

		internal void MchSaZQPcAY()
		{
			X4SSahaj21g = new MultiWebViewWindow(igPSaeqSufP, TydSaYh6RNc, EHoSaIIU6Zj);
			X4SSahaj21g.Title = IZbSaWPgVRD;
			X4SSahaj21g.Location = MflSakQEIYK;
			X4SSahaj21g.WindowSizeStr = tJSSaGF5e14;
			X4SSahaj21g.SetTopmost = M5eSasBlvNI;
			X4SSahaj21g.WindowId = n4uSa9KPfA6;
			if (ycbrKWWJkwMZvtpq4YkX == null)
			{
				switch (0)
				{
				}
			}
			AppHelper.SetWindowIcon(X4SSahaj21g, mVMSaHt1H2B.Action?.Icon, false);
			X4SSahaj21g.Show();
			X4SSahaj21g.Activate();
		}

		internal static bool kgWPt7WJapa3K9TVAHNa()
		{
			return ycbrKWWJkwMZvtpq4YkX == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass95_0
	{
		public WebView2Window UC0Sabe767K;

		internal static _003C_003Ec__DisplayClass95_0 KxYBgEWJuZtlOYeyOS5S;

		internal void wLZSa1qqkq2()
		{
			UC0Sabe767K.Stop();
		}

		internal static void YJixSmWJbIRDEqgOB37U()
		{
		}

		internal static bool P2Nc4nWJoMj0rDunGM3R()
		{
			return KxYBgEWJuZtlOYeyOS5S == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass96_0
	{
		public WebView2Window k83SaXFd6km;

		internal static _003C_003Ec__DisplayClass96_0 cYfE1MWJqRaMIKXDKjI0;

		internal void s6oSa6GL9HV()
		{
			k83SaXFd6km.Reload();
		}

		internal static bool AG0Nj8WJikr2EolJmfek()
		{
			return cYfE1MWJqRaMIKXDKjI0 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass97_0
	{
		public IntPtr rYvSajw3JJd;

		public WebView2Window zNFSanXchhD;

		private static _003C_003Ec__DisplayClass97_0 QLISQyWJZBOyp65o386j;

		internal void RNxSamqT5qd()
		{
			rYvSajw3JJd = zNFSanXchhD.GetHandle();
		}

		internal object I6OSaKQ6R2o()
		{
			return rYvSajw3JJd;
		}

		internal object SKGSaxGqbaq()
		{
			return zNFSanXchhD.WebView2;
		}

		internal object xd5Sar49eNf()
		{
			return zNFSanXchhD.GetLastLocation() ?? "";
		}

		internal object oRpSapa6fSQ()
		{
			return zNFSanXchhD.GetSourceCode();
		}

		internal object OLZSaBfsteU()
		{
			return zNFSanXchhD.GetCookies();
		}

		internal object lx5SaQBCVZb()
		{
			return zNFSanXchhD.CapturePreview();
		}

		internal static bool zXKA6QWJ5qxugbUmc76q()
		{
			return QLISQyWJZBOyp65o386j == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass98_0
	{
		public string OCrSa5xyWuh;

		internal static _003C_003Ec__DisplayClass98_0 YP7xWjWJ8yllEvDSBbBe;

		internal object C9jSa4326Hc()
		{
			return OCrSa5xyWuh;
		}

		internal static bool WXA2ViWJR3ynLUNbGQ1L()
		{
			return YP7xWjWJ8yllEvDSBbBe == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass99_0
	{
		public WebView2Window lMbSadnscoK;

		public string AumSao4RWsM;

		private static _003C_003Ec__DisplayClass99_0 SqbJ6hWJP3c9wwVJHfgu;

		internal void gK4SaDtokOg()
		{
			lMbSadnscoK.PostMessage(AumSao4RWsM);
		}

		internal static bool aMAdfCWJMIGJo0fL5CUT()
		{
			return SqbJ6hWJP3c9wwVJHfgu == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> odegCosn8Ah = new string[3] { "浏览器", "WebView2", "Edge" };

	[CompilerGenerated]
	private readonly string tWagCTpTQWf = $"fa:{EFontAwesomeIcon.Brands_Edge}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> PaBgCM8Vd6n;

	[CompilerGenerated]
	private readonly string a85gCAg0D2a = "https://getquicker.net/KC/Help/Doc/webview2";

	private static readonly StepInParamDef iBrgCOY5pay;

	private static readonly StepInParamDef m5lgCFhAvcp;

	private static readonly StepInParamDef xTGgCUxPBWo;

	private static readonly StepInParamDef qdkgClWA1pn;

	private static readonly StepInParamDef Dw3gCiZjQoX;

	private static readonly StepInParamDef N4ygC3IfW5x;

	private static readonly StepInParamDef IitgCf86IQB;

	private static readonly StepInParamDef m2rgCzdexpK;

	private static readonly StepInParamDef kUVgPw7fkYB;

	private static readonly StepInParamDef WFXgPtyJE1V;

	private static readonly StepInParamDef TVKgPguDPvN;

	private static readonly StepInParamDef DhkgPLZweZl;

	private static readonly StepInParamDef X9jgPvYM8lS;

	private static readonly StepInParamDef wCEgPSE6Z4j;

	private static readonly StepInParamDef qh4gP2Gl4ca;

	private static readonly StepInParamDef ANVgPuVWE8F;

	private static readonly StepInParamDef hBmgPNtAsg0;

	private static readonly StepInParamDef mmmgPJ8LlJQ;

	private static readonly StepInParamDef JB0gP0DBkli;

	private static readonly StepInParamDef g1PgPCarnii;

	private static readonly StepInParamDef RHYgPPGWgDU;

	private static readonly StepInParamDef TUDgPEcW5ty;

	private static readonly StepInParamDef CWlgPyqI5dx;

	private static readonly StepInParamDef L9qgP8iviQw;

	private static readonly StepInParamDef z53gPaG8A0n;

	private static readonly StepInParamDef OaxgP7fW5Mj;

	private static readonly StepInParamDef TI3gPRuMsZu;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> J6AgPqcDB2P = new List<StepInParamDef>
	{
		iBrgCOY5pay, m5lgCFhAvcp, xTGgCUxPBWo, qdkgClWA1pn, Dw3gCiZjQoX, N4ygC3IfW5x, IitgCf86IQB, m2rgCzdexpK, kUVgPw7fkYB, WFXgPtyJE1V,
		TVKgPguDPvN, DhkgPLZweZl, X9jgPvYM8lS, wCEgPSE6Z4j, qh4gP2Gl4ca, ANVgPuVWE8F, hBmgPNtAsg0, mmmgPJ8LlJQ, JB0gP0DBkli, g1PgPCarnii,
		RHYgPPGWgDU, TUDgPEcW5ty, CWlgPyqI5dx, z53gPaG8A0n, OaxgP7fW5Mj, L9qgP8iviQw, TI3gPRuMsZu
	};

	private static readonly StepOutParamDef QoLgPc8rbRM;

	private static readonly StepOutParamDef wWGgPVxESSo;

	private static readonly StepOutParamDef ztUgPZNKGKC;

	private static readonly StepOutParamDef wPJgP9QooMo;

	private static readonly StepOutParamDef tMYgPhiHQIy;

	private static readonly StepOutParamDef dmtgPeVP8O4;

	private static readonly StepOutParamDef vBAgPYvxqwr;

	private static readonly StepOutParamDef D8jgPIjSHZR;

	private static readonly StepOutParamDef NbagPWubX42;

	private static readonly StepOutParamDef lJTgPk4VK12;

	private static readonly StepOutParamDef fF4gPGa6avs;

	private static readonly StepOutParamDef GaWgPsualE0;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> l4igPHxYB1d = new List<StepOutParamDef>
	{
		QoLgPc8rbRM, wWGgPVxESSo, ztUgPZNKGKC, wPJgP9QooMo, tMYgPhiHQIy, dmtgPeVP8O4, vBAgPYvxqwr, D8jgPIjSHZR, NbagPWubX42, fF4gPGa6avs,
		GaWgPsualE0, lJTgPk4VK12
	};

	public const string DEFAULT_ARGS = " --enable-features=msWebView2EnableDraggableRegions";

	private static WebView2Step ipiBU7QUZphvnhCRKswP;

	public string Key => "sys:webview2";

	public string Name => "WebView2浏览器窗口";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return odegCosn8Ah;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return tWagCTpTQWf;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Ui;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return PaBgCM8Vd6n;
		}
	}

	public string Description => "基于微软Edge浏览器内核的组件，需要安装Edge最新预览版方可使用。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return a85gCAg0D2a;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly => false;

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return J6AgPqcDB2P;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return l4igPHxYB1d;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass91_0 _003C_003Ec__DisplayClass91_ = new _003C_003Ec__DisplayClass91_0();
		_003C_003Ec__DisplayClass91_.wnwSawKF8Cx = step;
		_003C_003Ec__DisplayClass91_.lTqSatqtSCv = context;
		_003C_003Ec__DisplayClass91_.LVuSag1ea5j = this;
		_003C_003Ec__DisplayClass91_.jPGSaLbou2l = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass91_.lTqSatqtSCv, _003C_003Ec__DisplayClass91_.wnwSawKF8Cx, _003C_003Ec__DisplayClass91_.jPGSaLbou2l, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass91_.nfmS8zNSBS8, (Action)null, (Action)null, TI3gPRuMsZu, QoLgPc8rbRM);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) I7egCQMCJ0q(string string_2, ActionExecuteContext actionExecuteContext_0, ActionStep actionStep_0, XAction xaction_0)
	{
		_003C_003Ec__DisplayClass92_0 _003C_003Ec__DisplayClass92_ = new _003C_003Ec__DisplayClass92_0();
		_003C_003Ec__DisplayClass92_.QAdSa0Gme5P = string_2;
		_003C_003Ec__DisplayClass92_.v6ASaqsVjQK = actionExecuteContext_0;
		IList<string> listParamValue = XActionHelper.GetListParamValue(xTGgCUxPBWo, actionStep_0, _003C_003Ec__DisplayClass92_.v6ASaqsVjQK);
		_003C_003Ec__DisplayClass92_.bBBSa8DB4Nf = XActionHelper.GetTextParamValue(IitgCf86IQB, actionStep_0, _003C_003Ec__DisplayClass92_.v6ASaqsVjQK);
		_003C_003Ec__DisplayClass92_.RcrSa70GNML = XActionHelper.GetTextParamValue(qh4gP2Gl4ca, actionStep_0, _003C_003Ec__DisplayClass92_.v6ASaqsVjQK);
		_003C_003Ec__DisplayClass92_.HHrSaRbRTbD = XActionHelper.GetBooleanParamValue(mmmgPJ8LlJQ, actionStep_0, _003C_003Ec__DisplayClass92_.v6ASaqsVjQK);
		_003C_003Ec__DisplayClass92_.v0tSaET95N8 = XActionHelper.GetTextParamValue(N4ygC3IfW5x, actionStep_0, _003C_003Ec__DisplayClass92_.v6ASaqsVjQK);
		_003C_003Ec__DisplayClass92_.bBBSaydDPvB = XActionHelper.GetTextParamValue(ANVgPuVWE8F, actionStep_0, _003C_003Ec__DisplayClass92_.v6ASaqsVjQK);
		string textParamValue = XActionHelper.GetTextParamValue(wCEgPSE6Z4j, actionStep_0, _003C_003Ec__DisplayClass92_.v6ASaqsVjQK);
		_003C_003Ec__DisplayClass92_.DMUSaa4prUh = ShowWindowLocation.CenterScreen;
		if (!Enum.TryParse<ShowWindowLocation>(textParamValue, out _003C_003Ec__DisplayClass92_.DMUSaa4prUh))
		{
			_003C_003Ec__DisplayClass92_.DMUSaa4prUh = ShowWindowLocation.CenterScreen;
		}
		_003C_003Ec__DisplayClass92_.daGSaCQTgEX = null;
		if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass92_.QAdSa0Gme5P))
		{
			AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass92_.xUFSau7YYL3);
		}
		_003C_003Ec__DisplayClass92_.xY7SaP0KlZc = iIggCnD4vxE(listParamValue);
		if (_003C_003Ec__DisplayClass92_.daGSaCQTgEX != null)
		{
			AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass92_.DxpSaNkFwtn);
		}
		else
		{
			AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass92_.oB7SaJEOo8c);
		}
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) p4ngCj1JTAn(string string_2, ActionExecuteContext actionExecuteContext_0, ActionStep actionStep_0, XAction xaction_0)
	{
		_003C_003Ec__DisplayClass93_0 _003C_003Ec__DisplayClass93_ = new _003C_003Ec__DisplayClass93_0();
		_003C_003Ec__DisplayClass93_.n4uSa9KPfA6 = string_2;
		_003C_003Ec__DisplayClass93_.mVMSaHt1H2B = actionExecuteContext_0;
		IList<string> listParamValue = XActionHelper.GetListParamValue(xTGgCUxPBWo, actionStep_0, _003C_003Ec__DisplayClass93_.mVMSaHt1H2B);
		_003C_003Ec__DisplayClass93_.IZbSaWPgVRD = XActionHelper.GetTextParamValue(IitgCf86IQB, actionStep_0, _003C_003Ec__DisplayClass93_.mVMSaHt1H2B);
		_003C_003Ec__DisplayClass93_.tJSSaGF5e14 = XActionHelper.GetTextParamValue(qh4gP2Gl4ca, actionStep_0, _003C_003Ec__DisplayClass93_.mVMSaHt1H2B);
		_003C_003Ec__DisplayClass93_.M5eSasBlvNI = XActionHelper.GetBooleanParamValue(mmmgPJ8LlJQ, actionStep_0, _003C_003Ec__DisplayClass93_.mVMSaHt1H2B);
		_003C_003Ec__DisplayClass93_.TydSaYh6RNc = XActionHelper.GetTextParamValue(N4ygC3IfW5x, actionStep_0, _003C_003Ec__DisplayClass93_.mVMSaHt1H2B);
		_003C_003Ec__DisplayClass93_.EHoSaIIU6Zj = XActionHelper.GetTextParamValue(ANVgPuVWE8F, actionStep_0, _003C_003Ec__DisplayClass93_.mVMSaHt1H2B);
		string textParamValue = XActionHelper.GetTextParamValue(wCEgPSE6Z4j, actionStep_0, _003C_003Ec__DisplayClass93_.mVMSaHt1H2B);
		_003C_003Ec__DisplayClass93_.MflSakQEIYK = ShowWindowLocation.CenterScreen;
		if (!Enum.TryParse<ShowWindowLocation>(textParamValue, out _003C_003Ec__DisplayClass93_.MflSakQEIYK))
		{
			_003C_003Ec__DisplayClass93_.MflSakQEIYK = ShowWindowLocation.CenterScreen;
		}
		_003C_003Ec__DisplayClass93_.X4SSahaj21g = null;
		if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass93_.n4uSa9KPfA6))
		{
			AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass93_.DXMSacG6JVv);
		}
		_003C_003Ec__DisplayClass93_.igPSaeqSufP = iIggCnD4vxE(listParamValue);
		if (_003C_003Ec__DisplayClass93_.X4SSahaj21g != null)
		{
			AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass93_.nP7SaVxgiGe);
		}
		else
		{
			AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass93_.MchSaZQPcAY);
		}
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private IList<CommonOperationItem> iIggCnD4vxE(IList<string> ilist_2)
	{
		return CommonOperationItem.ParseLines(ilist_2);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) Stop(string autoCloseKey, ActionExecuteContext context, ActionStep step, XAction action)
	{
		_003C_003Ec__DisplayClass95_0 _003C_003Ec__DisplayClass95_ = new _003C_003Ec__DisplayClass95_0();
		_003C_003Ec__DisplayClass95_.UC0Sabe767K = BOHgC4ZHqA8(autoCloseKey);
		if (_003C_003Ec__DisplayClass95_.UC0Sabe767K == null)
		{
			return (isSuccess: false, message: "", failReason: ActionStopFlag.OperationFailed);
		}
		AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass95_.wLZSa1qqkq2);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) Reload(string autoCloseKey, ActionExecuteContext context, ActionStep step, XAction action)
	{
		_003C_003Ec__DisplayClass96_0 _003C_003Ec__DisplayClass96_ = new _003C_003Ec__DisplayClass96_0();
		_003C_003Ec__DisplayClass96_.k83SaXFd6km = BOHgC4ZHqA8(autoCloseKey);
		if (_003C_003Ec__DisplayClass96_.k83SaXFd6km == null)
		{
			return (isSuccess: false, message: "", failReason: ActionStopFlag.OperationFailed);
		}
		AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass96_.s6oSa6GL9HV);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) CheckWindowState(string autoCloseKey, ActionExecuteContext context, ActionStep step, XAction action)
	{
		_003C_003Ec__DisplayClass97_0 _003C_003Ec__DisplayClass97_ = new _003C_003Ec__DisplayClass97_0();
		_003C_003Ec__DisplayClass97_.zNFSanXchhD = BOHgC4ZHqA8(autoCloseKey);
		if (_003C_003Ec__DisplayClass97_.zNFSanXchhD == null)
		{
			return (isSuccess: false, message: "未找到窗口", failReason: ActionStopFlag.OperationFailed);
		}
		for (int i = 0; i < 20; i++)
		{
			if (_003C_003Ec__DisplayClass97_.zNFSanXchhD.IsWebViewReady)
			{
				break;
			}
			Thread.Sleep(100);
		}
		_003C_003Ec__DisplayClass97_.rYvSajw3JJd = IntPtr.Zero;
		if (XActionHelper.IsOutputParamSetted(ztUgPZNKGKC.Key, step))
		{
			AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass97_.RNxSamqT5qd);
			XActionHelper.OutputResultIfNeeded(ztUgPZNKGKC, _003C_003Ec__DisplayClass97_.I6OSaKQ6R2o, step, context, action);
		}
		XActionHelper.OutputResultIfNeeded(wPJgP9QooMo, _003C_003Ec__DisplayClass97_.SKGSaxGqbaq, step, context, action);
		XActionHelper.OutputResultIfNeeded(tMYgPhiHQIy, _003C_003Ec__DisplayClass97_.xd5Sar49eNf, step, context, action);
		XActionHelper.OutputResult(dmtgPeVP8O4, step, context, _003C_003Ec__DisplayClass97_.zNFSanXchhD.CurrentUri, action);
		XActionHelper.OutputResult(GaWgPsualE0, step, context, _003C_003Ec__DisplayClass97_.zNFSanXchhD.IsNavigationCompleted, action);
		XActionHelper.OutputResult(vBAgPYvxqwr, step, context, _003C_003Ec__DisplayClass97_.zNFSanXchhD.DocTitle, action);
		XActionHelper.OutputResultIfNeeded(D8jgPIjSHZR, _003C_003Ec__DisplayClass97_.oRpSapa6fSQ, step, context, action);
		XActionHelper.OutputResultIfNeeded(NbagPWubX42, _003C_003Ec__DisplayClass97_.OLZSaBfsteU, step, context, action);
		XActionHelper.OutputResultIfNeeded(fF4gPGa6avs, _003C_003Ec__DisplayClass97_.lx5SaQBCVZb, step, context, action);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) ExecuteScript(string autoCloseKey, ActionExecuteContext context, ActionStep step, XAction action)
	{
		WebView2Window webView2Window = BOHgC4ZHqA8(autoCloseKey);
		if (webView2Window == null)
		{
			return (isSuccess: false, message: "未找到ID为" + autoCloseKey + "的窗口。", failReason: ActionStopFlag.OperationFailed);
		}
		_003C_003Ec__DisplayClass98_0 _003C_003Ec__DisplayClass98_ = new _003C_003Ec__DisplayClass98_0();
		string textParamValue = XActionHelper.GetTextParamValue(DhkgPLZweZl, step, context);
		_003C_003Ec__DisplayClass98_.OCrSa5xyWuh = "";
		if (!string.IsNullOrEmpty(textParamValue))
		{
			_003C_003Ec__DisplayClass98_.OCrSa5xyWuh = webView2Window.ExecuteScript(textParamValue);
		}
		if (!_003C_003Ec__DisplayClass98_.OCrSa5xyWuh.IsNullOrEmpty() && _003C_003Ec__DisplayClass98_.OCrSa5xyWuh.StartsWith("\""))
		{
			_003C_003Ec__DisplayClass98_.OCrSa5xyWuh = JsonConvert.DeserializeObject<string>(_003C_003Ec__DisplayClass98_.OCrSa5xyWuh);
		}
		XActionHelper.OutputResultIfNeeded(lJTgPk4VK12, _003C_003Ec__DisplayClass98_.C9jSa4326Hc, step, context, action);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) SendMessage(string autoCloseKey, ActionExecuteContext context, ActionStep step, XAction action)
	{
		_003C_003Ec__DisplayClass99_0 _003C_003Ec__DisplayClass99_ = new _003C_003Ec__DisplayClass99_0();
		_003C_003Ec__DisplayClass99_.lMbSadnscoK = BOHgC4ZHqA8(autoCloseKey);
		if (_003C_003Ec__DisplayClass99_.lMbSadnscoK == null)
		{
			return (isSuccess: false, message: "未找到ID为" + autoCloseKey + "的窗口。", failReason: ActionStopFlag.OperationFailed);
		}
		object paramValue = XActionHelper.GetParamValue(X9jgPvYM8lS, step, context, false, true);
		if (paramValue.IsDictionary())
		{
			_003C_003Ec__DisplayClass99_.AumSao4RWsM = JsonConvert.SerializeObject(paramValue);
		}
		else if (paramValue is string)
		{
			_003C_003Ec__DisplayClass99_.AumSao4RWsM = paramValue as string;
		}
		else
		{
			_003C_003Ec__DisplayClass99_.AumSao4RWsM = JsonConvert.SerializeObject(paramValue);
		}
		AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass99_.gK4SaDtokOg);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private WebView2Window BOHgC4ZHqA8(string string_2)
	{
		_003C_003Ec__DisplayClass100_0 _003C_003Ec__DisplayClass100_ = new _003C_003Ec__DisplayClass100_0();
		_003C_003Ec__DisplayClass100_.tlRS8qMWBPT = string_2;
		if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass100_.tlRS8qMWBPT))
		{
			throw new InvalidOperationException("要查找的窗口标识为空。");
		}
		_003C_003Ec__DisplayClass100_.plNS8cW9Gar = null;
		AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass100_.QUeS8RJSoh6);
		return _003C_003Ec__DisplayClass100_.plNS8cW9Gar;
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) O3PgC5aJUoh(string string_2, string string_3, ActionExecuteContext actionExecuteContext_0, ActionStep actionStep_0, XAction xaction_0)
	{
		_003C_003Ec__DisplayClass102_0 _003C_003Ec__DisplayClass102_ = new _003C_003Ec__DisplayClass102_0();
		_003C_003Ec__DisplayClass102_.ncBS8KhnBOU = string_3;
		_003C_003Ec__DisplayClass102_.HCrS8rVbDTH = actionExecuteContext_0;
		_003C_003Ec__DisplayClass102_.bZVS8pPNgUM = xaction_0;
		_003C_003Ec__DisplayClass102_.tmoS8DPd4iE = actionStep_0;
		_003C_003Ec__DisplayClass102_.CASS8M0jXgP = string_2.ContainedIn("OpenUrlAndWaitClose");
		bool flag = string_2 == "OpenAndWaitLoad";
		_003C_003Ec__DisplayClass102_.v47S8AW00aT = false;
		_003C_003Ec__DisplayClass102_.wwuS8HiQFEd = null;
		_003C_003Ec__DisplayClass102_.url = XActionHelper.GetTextParamValue(m5lgCFhAvcp, _003C_003Ec__DisplayClass102_.tmoS8DPd4iE, _003C_003Ec__DisplayClass102_.HCrS8rVbDTH);
		_003C_003Ec__DisplayClass102_.mh0S8XsCcNB = XActionHelper.GetTextParamValue(qdkgClWA1pn, _003C_003Ec__DisplayClass102_.tmoS8DPd4iE, _003C_003Ec__DisplayClass102_.HCrS8rVbDTH);
		string textParamValue = XActionHelper.GetTextParamValue(Dw3gCiZjQoX, _003C_003Ec__DisplayClass102_.tmoS8DPd4iE, _003C_003Ec__DisplayClass102_.HCrS8rVbDTH);
		_003C_003Ec__DisplayClass102_.v2pS85TlMWS = XActionHelper.GetTextParamValue(IitgCf86IQB, _003C_003Ec__DisplayClass102_.tmoS8DPd4iE, _003C_003Ec__DisplayClass102_.HCrS8rVbDTH);
		_003C_003Ec__DisplayClass102_.ud7S8bov9Yk = XActionHelper.GetTextParamValue(qh4gP2Gl4ca, _003C_003Ec__DisplayClass102_.tmoS8DPd4iE, _003C_003Ec__DisplayClass102_.HCrS8rVbDTH);
		_003C_003Ec__DisplayClass102_.ck4S8d2eqcf = XActionHelper.GetBooleanParamValue(g1PgPCarnii, _003C_003Ec__DisplayClass102_.tmoS8DPd4iE, _003C_003Ec__DisplayClass102_.HCrS8rVbDTH);
		_003C_003Ec__DisplayClass102_.mNBS8xyVReX = XActionHelper.GetTextParamValue(DhkgPLZweZl, _003C_003Ec__DisplayClass102_.tmoS8DPd4iE, _003C_003Ec__DisplayClass102_.HCrS8rVbDTH);
		_003C_003Ec__DisplayClass102_.PMPS8oIML7A = XActionHelper.GetBooleanParamValue(TUDgPEcW5ty, _003C_003Ec__DisplayClass102_.tmoS8DPd4iE, _003C_003Ec__DisplayClass102_.HCrS8rVbDTH);
		_003C_003Ec__DisplayClass102_.jbwS8Q2gDpy = XActionHelper.GetBooleanParamValue(CWlgPyqI5dx, _003C_003Ec__DisplayClass102_.tmoS8DPd4iE, _003C_003Ec__DisplayClass102_.HCrS8rVbDTH);
		_003C_003Ec__DisplayClass102_.VI3S8BBtgwq = XActionHelper.GetTextParamValue(m2rgCzdexpK, _003C_003Ec__DisplayClass102_.tmoS8DPd4iE, _003C_003Ec__DisplayClass102_.HCrS8rVbDTH);
		_003C_003Ec__DisplayClass102_.ppHS86sXkI6 = XActionHelper.GetBooleanParamValue(L9qgP8iviQw, _003C_003Ec__DisplayClass102_.tmoS8DPd4iE, _003C_003Ec__DisplayClass102_.HCrS8rVbDTH);
		_003C_003Ec__DisplayClass102_.SERS8TR71wj = XActionHelper.GetTextParamValue(N4ygC3IfW5x, _003C_003Ec__DisplayClass102_.tmoS8DPd4iE, _003C_003Ec__DisplayClass102_.HCrS8rVbDTH);
		string textParamValue2 = XActionHelper.GetTextParamValue(kUVgPw7fkYB, _003C_003Ec__DisplayClass102_.tmoS8DPd4iE, _003C_003Ec__DisplayClass102_.HCrS8rVbDTH);
		string textParamValue3 = XActionHelper.GetTextParamValue(z53gPaG8A0n, _003C_003Ec__DisplayClass102_.tmoS8DPd4iE, _003C_003Ec__DisplayClass102_.HCrS8rVbDTH);
		_003C_003Ec__DisplayClass102_.EcXS8jAgQG1 = XActionHelper.GetBooleanParamValue(OaxgP7fW5Mj, _003C_003Ec__DisplayClass102_.tmoS8DPd4iE, _003C_003Ec__DisplayClass102_.HCrS8rVbDTH);
		_003C_003Ec__DisplayClass102_.Il1S8n7PL3r = XActionHelper.GetTextParamValue(ANVgPuVWE8F, _003C_003Ec__DisplayClass102_.tmoS8DPd4iE, _003C_003Ec__DisplayClass102_.HCrS8rVbDTH);
		_003C_003Ec__DisplayClass102_.BidS8m7pVyt = XActionHelper.GetTextParamValue(hBmgPNtAsg0, _003C_003Ec__DisplayClass102_.tmoS8DPd4iE, _003C_003Ec__DisplayClass102_.HCrS8rVbDTH);
		_003C_003Ec__DisplayClass102_.RK1S84GkRQI = textParamValue3 == "none";
		string textParamValue4 = XActionHelper.GetTextParamValue(wCEgPSE6Z4j, _003C_003Ec__DisplayClass102_.tmoS8DPd4iE, _003C_003Ec__DisplayClass102_.HCrS8rVbDTH);
		_003C_003Ec__DisplayClass102_.TrMS81hNFg9 = ShowWindowLocation.CenterScreen;
		if (!Enum.TryParse<ShowWindowLocation>(textParamValue4, out _003C_003Ec__DisplayClass102_.TrMS81hNFg9))
		{
			_003C_003Ec__DisplayClass102_.TrMS81hNFg9 = ShowWindowLocation.CenterScreen;
		}
		string textParamValue5 = XActionHelper.GetTextParamValue(TVKgPguDPvN, _003C_003Ec__DisplayClass102_.tmoS8DPd4iE, _003C_003Ec__DisplayClass102_.HCrS8rVbDTH);
		if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass102_.ncBS8KhnBOU))
		{
			_003C_003Ec__DisplayClass102_.wwuS8HiQFEd = BOHgC4ZHqA8(_003C_003Ec__DisplayClass102_.ncBS8KhnBOU);
			if (_003C_003Ec__DisplayClass102_.wwuS8HiQFEd != null)
			{
				switch (textParamValue5)
				{
				case "BringToFront":
					AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass102_.cP5S8h2RRNm);
					if (flag)
					{
						LsfgCdrSFQM(_003C_003Ec__DisplayClass102_.wwuS8HiQFEd, _003C_003Ec__DisplayClass102_.HCrS8rVbDTH);
					}
					return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
				case "UpdateUrlAndPosition":
					AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass102_.T0IS89oI1I0);
					if (flag)
					{
						LsfgCdrSFQM(_003C_003Ec__DisplayClass102_.wwuS8HiQFEd, _003C_003Ec__DisplayClass102_.HCrS8rVbDTH);
					}
					return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
				case "UpdateUrl":
					AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass102_.tNGS8Z1ekOE);
					if (flag)
					{
						LsfgCdrSFQM(_003C_003Ec__DisplayClass102_.wwuS8HiQFEd, _003C_003Ec__DisplayClass102_.HCrS8rVbDTH);
					}
					return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
				case "RecreateWindow":
					AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass102_.jEAS8VgeOtN);
					break;
				case "SkipThisStep":
					_003C_003Ec__DisplayClass102_.HCrS8rVbDTH.ActionLogger.LogInfo("窗口存在已跳过步骤");
					return (isSuccess: true, message: "窗口存在已跳过步骤。", failReason: ActionStopFlag.NoStop);
				}
			}
		}
		_003C_003Ec__DisplayClass102_.QgCS8O543yt = IntPtr.Zero;
		_003C_003Ec__DisplayClass102_.IimS8FVuPu4 = null;
		if (_003C_003Ec__DisplayClass102_.wwuS8HiQFEd == null)
		{
			_003C_003Ec__DisplayClass102_1 _003C_003Ec__DisplayClass102_2 = new _003C_003Ec__DisplayClass102_1();
			_003C_003Ec__DisplayClass102_2.PtJS8fm3pid = _003C_003Ec__DisplayClass102_;
			bool flag2 = true;
			try
			{
				if (!string.IsNullOrEmpty(CoreWebView2Environment.GetAvailableBrowserVersionString(null, null)))
				{
					flag2 = false;
				}
			}
			catch
			{
			}
			if (flag2)
			{
				AppHelper.ShowWarning("未找到WebView2组件，您需要安装WebView2组件来使用此动作。", true);
				AppWindowManager.ShowWebViewInstaller();
				return (isSuccess: false, message: "缺少运行环境，请安装WebView2组件。", failReason: ActionStopFlag.OperationFailed);
			}
			_003C_003Ec__DisplayClass102_2.SvhS8iMP8E0 = null;
			if (!string.IsNullOrEmpty(textParamValue2))
			{
				_003C_003Ec__DisplayClass102_2.SvhS8iMP8E0 = Quicker.Utilities.Ext.ColorHelper.StringToColor(textParamValue2);
			}
			if (!_003C_003Ec__DisplayClass102_2.PtJS8fm3pid.mh0S8XsCcNB.Contains("msWebView2EnableDraggableRegions"))
			{
				_003C_003Ec__DisplayClass102_2.PtJS8fm3pid.mh0S8XsCcNB = _003C_003Ec__DisplayClass102_2.PtJS8fm3pid.mh0S8XsCcNB + " --enable-features=msWebView2EnableDraggableRegions";
			}
			_003C_003Ec__DisplayClass102_2.Y9oS839f7j8 = null;
			if (!string.IsNullOrEmpty(textParamValue))
			{
				_003C_003Ec__DisplayClass102_2.Y9oS839f7j8 = new Dictionary<string, string>();
				foreach (string item in textParamValue.Split('\r', '\n').Select(_003C_003Ec.qq7S8ahgkpo ?? (_003C_003Ec.qq7S8ahgkpo = _003C_003Ec.IYmS88wf6Bi.b7jS8El4TZY)).Where(_003C_003Ec.k1YS87pa0v2 ?? (_003C_003Ec.k1YS87pa0v2 = _003C_003Ec.IYmS88wf6Bi.odGS8yZiixc))
					.ToList())
				{
					int num = item.IndexOf('|');
					if (num >= 0)
					{
						string key = item.Substring(0, num);
						string text = item.Substring(num + 1);
						if (Directory.Exists(text))
						{
							_003C_003Ec__DisplayClass102_2.Y9oS839f7j8[key] = text;
							continue;
						}
						throw new DirectoryNotFoundException("虚拟主机映射的路径不存在：" + text);
					}
					throw new InvalidDataException("虚拟主机映射参数格式不正确。");
				}
			}
			AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass102_2.fRpS8lXiJEo);
			if (_003C_003Ec__DisplayClass102_2.PtJS8fm3pid.CASS8M0jXgP)
			{
				while (!_003C_003Ec__DisplayClass102_2.PtJS8fm3pid.v47S8AW00aT)
				{
					Thread.Sleep(50);
				}
			}
			else if (flag)
			{
				LsfgCdrSFQM(_003C_003Ec__DisplayClass102_2.PtJS8fm3pid.wwuS8HiQFEd, _003C_003Ec__DisplayClass102_2.PtJS8fm3pid.HCrS8rVbDTH);
			}
		}
		else
		{
			AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass102_.ok4S8YoZ4ZM);
		}
		WebView2Window webView2Window = _003C_003Ec__DisplayClass102_.wwuS8HiQFEd;
		object obj2;
		if (webView2Window == null)
		{
			obj2 = null;
		}
		else
		{
			obj2 = webView2Window.GetLastLocation();
			if (obj2 != null)
			{
				goto IL_0638;
			}
		}
		obj2 = "";
		goto IL_0638;
		IL_0638:
		string result = (string)obj2;
		if (string_2 == "OpenAndWaitLoad")
		{
			XActionHelper.OutputResultIfNeeded(dmtgPeVP8O4, _003C_003Ec__DisplayClass102_.DS3S8Ik2Gvl, _003C_003Ec__DisplayClass102_.tmoS8DPd4iE, _003C_003Ec__DisplayClass102_.HCrS8rVbDTH, _003C_003Ec__DisplayClass102_.bZVS8pPNgUM);
			XActionHelper.OutputResultIfNeeded(vBAgPYvxqwr, _003C_003Ec__DisplayClass102_.jsSS8WbqTpn, _003C_003Ec__DisplayClass102_.tmoS8DPd4iE, _003C_003Ec__DisplayClass102_.HCrS8rVbDTH, _003C_003Ec__DisplayClass102_.bZVS8pPNgUM);
			XActionHelper.OutputResultIfNeeded(D8jgPIjSHZR, _003C_003Ec__DisplayClass102_.PyCS8kqjoM9, _003C_003Ec__DisplayClass102_.tmoS8DPd4iE, _003C_003Ec__DisplayClass102_.HCrS8rVbDTH, _003C_003Ec__DisplayClass102_.bZVS8pPNgUM);
			XActionHelper.OutputResultIfNeeded(NbagPWubX42, _003C_003Ec__DisplayClass102_.feCS8GJfFw9, _003C_003Ec__DisplayClass102_.tmoS8DPd4iE, _003C_003Ec__DisplayClass102_.HCrS8rVbDTH, _003C_003Ec__DisplayClass102_.bZVS8pPNgUM);
		}
		XActionHelper.OutputResult(ztUgPZNKGKC, _003C_003Ec__DisplayClass102_.tmoS8DPd4iE, _003C_003Ec__DisplayClass102_.HCrS8rVbDTH, _003C_003Ec__DisplayClass102_.QgCS8O543yt, _003C_003Ec__DisplayClass102_.bZVS8pPNgUM);
		XActionHelper.OutputResultIfNeeded(wPJgP9QooMo, _003C_003Ec__DisplayClass102_.aw3S8sr5W6o, _003C_003Ec__DisplayClass102_.tmoS8DPd4iE, _003C_003Ec__DisplayClass102_.HCrS8rVbDTH, _003C_003Ec__DisplayClass102_.bZVS8pPNgUM);
		XActionHelper.OutputResult(tMYgPhiHQIy, _003C_003Ec__DisplayClass102_.tmoS8DPd4iE, _003C_003Ec__DisplayClass102_.HCrS8rVbDTH, result, _003C_003Ec__DisplayClass102_.bZVS8pPNgUM);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private static void lQ5gCDODkUW(WebView2Window webView2Window_0)
	{
		if (webView2Window_0.WindowState == WindowState.Minimized)
		{
			webView2Window_0.WindowState = WindowState.Normal;
		}
		if (webView2Window_0.NoActivate)
		{
			NativeMethods.SetWindowPos(webView2Window_0.GetHandle(), NativeMethods.HWND_TOP, 0, 0, 0, 0, SetWindowPosFlags.SWP_NOACTIVATE | SetWindowPosFlags.SWP_NOMOVE | SetWindowPosFlags.SWP_NOSIZE);
		}
		else
		{
			webView2Window_0.Activate();
		}
	}

	private void LsfgCdrSFQM(WebView2Window webView2Window_0, ActionExecuteContext actionExecuteContext_0)
	{
		while (webView2Window_0 != null && !webView2Window_0.IsNavigationCompleted && !actionExecuteContext_0.IsShouldStopAction())
		{
			Thread.Sleep(50);
		}
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDirectValue(iBrgCOY5pay, step) ?? "";
	}

	static WebView2Step()
	{
		iBrgCOY5pay = new StepInParamDef
		{
			Key = "type",
			Name = "操作类型",
			Description = "",
			Type = VarType.Enum,
			DefaultValue = "OpenUrl",
			SelectionItems = new SelectionItem[12]
			{
				new SelectionItem("OpenUrl", "打开网页"),
				new SelectionItem("OpenAndWaitLoad", "打开网页并等待加载完成"),
				new SelectionItem("OpenUrlAndWaitClose", "打开网页并等待窗口关闭"),
				new SelectionItem("SendMessage", "发送消息"),
				new SelectionItem("ExecuteScript", "执行脚本"),
				new SelectionItem("CheckWindowState", "获取窗口状态"),
				new SelectionItem("Close", "关闭窗口(如果尚未关闭)"),
				new SelectionItem("Reload", "重新加载/刷新"),
				new SelectionItem("Stop", "停止加载"),
				new SelectionItem("CheckInstalled", "检查是否安装WebView2"),
				new SelectionItem("MultiTab_OpenUrl", "【多标签】打开网址"),
				new SelectionItem("MultiColumn_OpenUrl", "【多列】打开网址")
			},
			VariableMode = ParamVariableMode.Input,
			IsControlField = true
		};
		m5lgCFhAvcp = new StepInParamDef
		{
			Key = "url",
			Name = "网址或HTML内容",
			Description = "网页地址/文件路径或html代码内容",
			DefaultValue = "",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true,
			ValidForList = new string[3] { "OpenUrl", "OpenAndWaitLoad", "OpenUrlAndWaitClose" },
			DefaultHighlightType = "HTML"
		};
		xTGgCUxPBWo = new StepInParamDef
		{
			Key = "urlList",
			Name = "网址列表",
			Description = "每行一个：网址，或“标题|网址”，或“[图标]标题|网址”格式。",
			DefaultValue = "",
			IsRequired = true,
			Type = VarType.List,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true,
			ValidForList = new string[2] { "MultiTab_OpenUrl", "MultiColumn_OpenUrl" }
		};
		qdkgClWA1pn = new StepInParamDef
		{
			Key = "additionalBrowserArguments",
			Name = "附加的浏览器参数",
			Description = "用于设置代理等用途",
			DefaultValue = "",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = false,
			ValidForList = new string[3] { "OpenUrl", "OpenAndWaitLoad", "OpenUrlAndWaitClose" }
		};
		Dw3gCiZjQoX = new StepInParamDef
		{
			Key = "virtualHostToFolder",
			Name = "虚拟主机映射",
			Description = "将文件夹映射为虚拟主机名。格式：主机名|文件夹路径。多个时，每行一个。\r\n在html中可以使用https://servername/path/to/file.png的格式访问文件。",
			DefaultValue = "",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true,
			ValidForList = new string[3] { "OpenUrl", "OpenAndWaitLoad", "OpenUrlAndWaitClose" }
		};
		N4ygC3IfW5x = new StepInParamDef
		{
			Key = "userAgent",
			Name = "User Agent",
			Description = "可选。自定义UserAgent",
			DefaultValue = "",
			IsRequired = false,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = false,
			ValidForList = new string[5] { "OpenUrl", "OpenAndWaitLoad", "OpenUrlAndWaitClose", "MultiTab_OpenUrl", "MultiColumn_OpenUrl" }
		};
		IitgCf86IQB = new StepInParamDef
		{
			Key = "title",
			Name = "窗口标题",
			Description = "窗口标题文字。未设置时，自动使用网页标题。",
			DefaultValue = "",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = false,
			ValidForList = new string[5] { "OpenUrl", "OpenAndWaitLoad", "OpenUrlAndWaitClose", "MultiTab_OpenUrl", "MultiColumn_OpenUrl" }
		};
		m2rgCzdexpK = new StepInParamDef
		{
			Key = "icon",
			Name = "窗口图标",
			Description = "显示在窗口左上角的图标。支持fa:内置图报名:#RRGGBB或图标网址。",
			DefaultValue = "",
			IsRequired = false,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = false,
			ValidForList = new string[3] { "OpenUrl", "OpenAndWaitLoad", "OpenUrlAndWaitClose" }
		};
		kUVgPw7fkYB = new StepInParamDef
		{
			Key = "defaultBgColor",
			Name = "默认背景色",
			Description = "可选。设置窗口的默认背景色。",
			DefaultValue = "",
			IsRequired = false,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = false,
			ValidForList = new string[3] { "OpenUrl", "OpenAndWaitLoad", "OpenUrlAndWaitClose" }
		};
		WFXgPtyJE1V = new StepInParamDef
		{
			Key = "autoCloseKey",
			Name = "窗口标识",
			Description = "(仅必要时使用)用于关闭之前打开的具有此标识的WebView2窗口。使用=表示当前动作ID。",
			DefaultValue = "=",
			Type = VarType.Text,
			IsRequired = false,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = false,
			InvalidForList = new string[1] { "CheckInstalled" }
		};
		TVKgPguDPvN = new StepInParamDef
		{
			Key = "modeForExists",
			Name = "如果窗口已存在",
			Description = "",
			Type = VarType.Enum,
			DefaultValue = "SkipThisStep",
			SelectionItems = new SelectionItem[5]
			{
				new SelectionItem("SkipThisStep", "跳过此步骤"),
				new SelectionItem("UpdateUrl", "更新网址"),
				new SelectionItem("UpdateUrlAndPosition", "更新网址和窗口位置"),
				new SelectionItem("RecreateWindow", "关闭并重建窗口"),
				new SelectionItem("BringToFront", "激活窗口")
			},
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "OpenUrl", "OpenAndWaitLoad" }
		};
		DhkgPLZweZl = new StepInParamDef
		{
			Key = "script",
			Name = "JS脚本",
			Description = "可选。",
			DefaultValue = "",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true,
			ValidForList = new List<string> { "OpenUrl", "OpenAndWaitLoad", "OpenUrlAndWaitClose", "ExecuteScript" },
			DefaultHighlightType = "JavaScript"
		};
		X9jgPvYM8lS = new StepInParamDef
		{
			Key = "sendMessage",
			Name = "消息内容",
			Description = "Json格式的消息内容。词典变量会自动转换成json。",
			DefaultValue = "",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true,
			ValidForList = new List<string> { "SendMessage" }
		};
		wCEgPSE6Z4j = new StepInParamDef
		{
			Key = "winLocation",
			Name = "窗口位置",
			Description = "在哪里显示选择窗口",
			Type = VarType.Enum,
			DefaultValue = ShowWindowLocation.CenterScreen.ToString(),
			SelectionItems = new SelectionItem[14]
			{
				new SelectionItem(ShowWindowLocation.WithMouse1.ToString(), "跟随鼠标（指针周围）"),
				new SelectionItem(ShowWindowLocation.WithMouse2.ToString(), "跟随鼠标（指针右下）"),
				new SelectionItem(ShowWindowLocation.CenterScreen.ToString(), "屏幕中间"),
				new SelectionItem(ShowWindowLocation.TopLeft.ToString(), "屏幕左上"),
				new SelectionItem(ShowWindowLocation.TopCenter.ToString(), "屏幕中上"),
				new SelectionItem(ShowWindowLocation.TopRight.ToString(), "屏幕右上"),
				new SelectionItem(ShowWindowLocation.LeftCenter.ToString(), "屏幕左中"),
				new SelectionItem(ShowWindowLocation.RightCenter.ToString(), "屏幕右中"),
				new SelectionItem(ShowWindowLocation.BottomLeft.ToString(), "屏幕左下"),
				new SelectionItem(ShowWindowLocation.BottomCenter.ToString(), "屏幕中下"),
				new SelectionItem(ShowWindowLocation.BottomRight.ToString(), "屏幕右下"),
				new SelectionItem(ShowWindowLocation.FullScreen.ToString(), "全屏"),
				new SelectionItem(ShowWindowLocation.Maximized.ToString(), "最大化"),
				new SelectionItem(ShowWindowLocation.Manual.ToString(), "自定义位置")
			},
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "OpenUrl", "OpenAndWaitLoad", "OpenUrlAndWaitClose", "MultiTab_OpenUrl", "MultiColumn_OpenUrl" }
		};
		qh4gP2Gl4ca = new StepInParamDef
		{
			Key = "winSize",
			Name = "窗口尺寸/位置",
			Description = "设置选择窗口的尺寸，格式为：宽度,高度。支持像素数值或屏幕宽高百分比，详情请参考模块文档。\n“窗口位置” 类型为 “自定义位置” 时用于指定显示位置，格式为：left,top,right,bottom",
			DefaultValue = "",
			Type = VarType.Text,
			IsRequired = false,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "OpenUrl", "OpenAndWaitLoad", "OpenUrlAndWaitClose", "MultiTab_OpenUrl", "MultiColumn_OpenUrl" },
			TextTools = new List<TextToolType> { TextToolType.SelectLocationArea }
		};
		ANVgPuVWE8F = new StepInParamDef
		{
			Key = "defaultDownloadFolderPath",
			Name = "默认下载文件夹",
			Description = "默认的文件下载存储目录",
			DefaultValue = "",
			Type = VarType.Text,
			IsRequired = false,
			IsAdvanced = true,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "OpenUrl", "OpenAndWaitLoad", "OpenUrlAndWaitClose", "MultiTab_OpenUrl", "MultiColumn_OpenUrl" },
			TextTools = new List<TextToolType> { TextToolType.SelectSingleFolder }
		};
		hBmgPNtAsg0 = new StepInParamDef
		{
			Key = "profileName",
			Name = "Profile",
			Description = "当需要同时登录一个网站的多个账号时，可以创建独立的Profile",
			DefaultValue = "",
			Type = VarType.Text,
			IsRequired = false,
			IsAdvanced = true,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "OpenUrl", "OpenAndWaitLoad", "OpenUrlAndWaitClose" },
			TextTools = new List<TextToolType> { TextToolType.SelectSingleFolder }
		};
		mmmgPJ8LlJQ = new StepInParamDef
		{
			Key = "topMost",
			Name = "置顶显示",
			DefaultValue = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "OpenUrl", "OpenAndWaitLoad", "OpenUrlAndWaitClose", "MultiTab_OpenUrl", "MultiColumn_OpenUrl" },
			IsAdvanced = true
		};
		JB0gP0DBkli = new StepInParamDef
		{
			Key = "showInTaskbar",
			Name = "显示任务栏图标",
			DefaultValue = true,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "OpenUrl", "OpenAndWaitLoad", "OpenUrlAndWaitClose" },
			IsAdvanced = true
		};
		g1PgPCarnii = new StepInParamDef
		{
			Key = "noActivate",
			Name = "不占用焦点",
			Description = "不占用焦点时也无法在窗口中输入文字",
			DefaultValue = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "OpenUrl", "OpenAndWaitLoad", "OpenUrlAndWaitClose" },
			IsAdvanced = true
		};
		RHYgPPGWgDU = new StepInParamDef
		{
			Key = "closeWhenLostFocus",
			Name = "失去焦点后",
			Description = "",
			DefaultValue = false,
			Type = VarType.Enum,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("false", "不执行操作"),
				new SelectionItem("true", "关闭窗口"),
				new SelectionItem("hide", "隐藏窗口"),
				new SelectionItem("minimize", "最小化窗口"),
				new SelectionItem("close_if_not_topmost", "如果未置顶，关闭窗口"),
				new SelectionItem("hide_if_not_topmost", "如果未置顶，隐藏窗口"),
				new SelectionItem("minimize_if_not_topmost", "如果未置顶，最小化窗口")
			},
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "OpenUrl", "OpenAndWaitLoad", "OpenUrlAndWaitClose" },
			IsAdvanced = true
		};
		TUDgPEcW5ty = new StepInParamDef
		{
			Key = "escCloseWindow",
			Name = "按Esc关闭窗口",
			Description = "",
			DefaultValue = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "OpenUrl", "OpenAndWaitLoad", "OpenUrlAndWaitClose" },
			IsAdvanced = true
		};
		CWlgPyqI5dx = new StepInParamDef
		{
			Key = "showToolbar",
			Name = "显示工具栏",
			Description = "",
			DefaultValue = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "OpenUrl", "OpenAndWaitLoad", "OpenUrlAndWaitClose" },
			IsAdvanced = true
		};
		L9qgP8iviQw = new StepInParamDef
		{
			Key = "addDevTool",
			Name = "添加DevTools桥",
			Description = "",
			DefaultValue = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "OpenUrl", "OpenAndWaitLoad", "OpenUrlAndWaitClose" },
			IsAdvanced = true
		};
		z53gPaG8A0n = new StepInParamDef
		{
			Key = "windowStyle",
			Name = "窗口风格",
			Description = "",
			DefaultValue = "normal",
			Type = VarType.Enum,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new List<string> { "OpenUrl", "OpenAndWaitLoad", "OpenUrlAndWaitClose" },
			IsAdvanced = true,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("normal", "正常"),
				new SelectionItem("none", "无边框")
			}
		};
		OaxgP7fW5Mj = new StepInParamDef
		{
			Key = "clearCookies",
			Name = "关闭窗口时清理Cookie",
			Description = "",
			DefaultValue = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "OpenUrl", "OpenAndWaitLoad", "OpenUrlAndWaitClose" },
			IsAdvanced = true
		};
		TI3gPRuMsZu = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		QoLgPc8rbRM = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功。获取窗口信息时，窗口是否存在。",
			Type = VarType.Boolean
		};
		wWGgPVxESSo = new StepOutParamDef
		{
			Key = "isInstalled",
			Name = "是否安装WebView2",
			Description = "",
			Type = VarType.Boolean,
			ValidForList = new List<string> { "CheckInstalled" }
		};
		ztUgPZNKGKC = new StepOutParamDef
		{
			Key = "hWnd",
			Name = "窗口句柄",
			Description = "",
			Type = VarType.Integer,
			ValidForList = new List<string> { "OpenUrl", "OpenAndWaitLoad", "CheckWindowState" }
		};
		wPJgP9QooMo = new StepOutParamDef
		{
			Key = "webView",
			Name = "WebView2对象",
			Description = "可用于在C#脚本中使用，需运行在UI线程中。注意避免循环引用。",
			Type = VarType.Object,
			ValidForList = new List<string> { "OpenUrl", "OpenAndWaitLoad", "CheckWindowState" }
		};
		tMYgPhiHQIy = new StepOutParamDef
		{
			Key = "lastLocation",
			Name = "窗口位置",
			Description = "返回窗口坐标范围。格式为：left,top,right,bottom",
			Type = VarType.Text,
			ValidForList = new List<string> { "OpenAndWaitLoad", "CheckWindowState", "OpenUrlAndWaitClose" }
		};
		dmtgPeVP8O4 = new StepOutParamDef
		{
			Key = "currUri",
			Name = "当前网址",
			Description = "浏览器当前网址",
			Type = VarType.Text,
			ValidForList = new List<string> { "OpenAndWaitLoad", "CheckWindowState" }
		};
		vBAgPYvxqwr = new StepOutParamDef
		{
			Key = "docTitle",
			Name = "网页标题",
			Description = "",
			Type = VarType.Text,
			ValidForList = new List<string> { "OpenAndWaitLoad", "CheckWindowState" }
		};
		D8jgPIjSHZR = new StepOutParamDef
		{
			Key = "sourceCode",
			Name = "网页代码",
			Description = "",
			Type = VarType.Text,
			ValidForList = new List<string> { "OpenAndWaitLoad", "CheckWindowState" }
		};
		NbagPWubX42 = new StepOutParamDef
		{
			Key = "cookies",
			Name = "Cookie",
			Description = "",
			Type = VarType.Text,
			ValidForList = new List<string> { "OpenAndWaitLoad", "CheckWindowState" }
		};
		lJTgPk4VK12 = new StepOutParamDef
		{
			Key = "scriptResult",
			Name = "脚本运行结果",
			Description = "json编码的脚本运行结果内容",
			Type = VarType.Text,
			ValidForList = new List<string> { "ExecuteScript" }
		};
		fF4gPGa6avs = new StepOutParamDef
		{
			Key = "previewImage",
			Name = "预览图",
			Description = "",
			Type = VarType.Image,
			ValidForList = new List<string> { "CheckWindowState" }
		};
		GaWgPsualE0 = new StepOutParamDef
		{
			Key = "isNavCompleted",
			Name = "导航是否已结束",
			Description = "是否已完成网页加载过程",
			Type = VarType.Boolean,
			ValidForList = new List<string> { "CheckWindowState" }
		};
	}

	internal static bool xOwcKlQU5DKXVPPpKadc()
	{
		return ipiBU7QUZphvnhCRKswP == null;
	}

	internal static void zVJZwVQURuuMlUHPlr7K()
	{
	}
}
