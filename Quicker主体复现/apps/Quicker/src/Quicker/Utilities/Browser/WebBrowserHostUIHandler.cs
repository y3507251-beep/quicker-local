using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Navigation;
using ImplPtM9tGQQ4H9uR7B;

namespace Quicker.Utilities.Browser;

public class WebBrowserHostUIHandler : ew0yN4McpJ9lA7pcNK7.bPAOSfD7nk63tmuHQbs
{
	[CompilerGenerated]
	private System.Windows.Controls.WebBrowser z1RLOZ3eWCr;

	[CompilerGenerated]
	private HostUIFlags FQxLO9fHCm4;

	[CompilerGenerated]
	private bool I82LOhkroqm;

	[CompilerGenerated]
	private bool kHTLOefecuX;

	internal static WebBrowserHostUIHandler gbSfbXFPAbcdkbKoBBIm;

	public System.Windows.Controls.WebBrowser Browser
	{
		[CompilerGenerated]
		get
		{
			return z1RLOZ3eWCr;
		}
		[CompilerGenerated]
		private set
		{
			z1RLOZ3eWCr = value;
		}
	}

	public HostUIFlags Flags
	{
		[CompilerGenerated]
		get
		{
			return FQxLO9fHCm4;
		}
		[CompilerGenerated]
		set
		{
			FQxLO9fHCm4 = value;
		}
	}

	public bool IsWebBrowserContextMenuEnabled
	{
		[CompilerGenerated]
		get
		{
			return I82LOhkroqm;
		}
		[CompilerGenerated]
		set
		{
			I82LOhkroqm = value;
		}
	}

	public bool ScriptErrorsSuppressed
	{
		[CompilerGenerated]
		get
		{
			return kHTLOefecuX;
		}
		[CompilerGenerated]
		set
		{
			kHTLOefecuX = value;
		}
	}

	public WebBrowserHostUIHandler(System.Windows.Controls.WebBrowser browser)
	{
		if (browser == null)
		{
			throw new ArgumentNullException("browser");
		}
		Browser = browser;
		browser.LoadCompleted += IFpLOcesflM;
		browser.Navigated += h1YLOqi8g2m;
		IsWebBrowserContextMenuEnabled = true;
		Flags |= HostUIFlags.ENABLE_REDIRECT_NOTIFICATION;
	}

	private void h1YLOqi8g2m(object sender, NavigationEventArgs e)
	{
		SetSilent(Browser, ScriptErrorsSuppressed);
	}

	private void IFpLOcesflM(object sender, NavigationEventArgs e)
	{
		if (Browser.Document is ew0yN4McpJ9lA7pcNK7.H4fbPSDuQvTpXXmkCnl h4fbPSDuQvTpXXmkCnl)
		{
			h4fbPSDuQvTpXXmkCnl.O1LMr3eKPi9(this);
		}
	}

	uint ew0yN4McpJ9lA7pcNK7.bPAOSfD7nk63tmuHQbs.bqxMIy7UrXj(int dwID, ew0yN4McpJ9lA7pcNK7.yl2kTVDdkMHht3UdNWE pt, object pcmdtReserved, object pdispReserved)
	{
		return IsWebBrowserContextMenuEnabled ? 1u : 0u;
	}

	uint ew0yN4McpJ9lA7pcNK7.bPAOSfD7nk63tmuHQbs.momMIQrNeiL(ref ew0yN4McpJ9lA7pcNK7.FWZHbFDi1fttK6luAra info)
	{
		info.aJO2SgbHqrt = (int)Flags;
		info.z0A2SLTPB26 = 0;
		return 0u;
	}

	uint ew0yN4McpJ9lA7pcNK7.bPAOSfD7nk63tmuHQbs.Aw3MIYkqqA8(int dwID, object activeObject, object commandTarget, object frame, object doc)
	{
		return 2147500033u;
	}

	uint ew0yN4McpJ9lA7pcNK7.bPAOSfD7nk63tmuHQbs.gv0MIJO1hfn()
	{
		return 2147500033u;
	}

	uint ew0yN4McpJ9lA7pcNK7.bPAOSfD7nk63tmuHQbs.WvrMIAl6nin()
	{
		return 2147500033u;
	}

	uint ew0yN4McpJ9lA7pcNK7.bPAOSfD7nk63tmuHQbs.EnableModeless(bool fEnable)
	{
		return 2147500033u;
	}

	uint ew0yN4McpJ9lA7pcNK7.bPAOSfD7nk63tmuHQbs.lKaMIBMgJSy(bool fActivate)
	{
		return 2147500033u;
	}

	uint ew0yN4McpJ9lA7pcNK7.bPAOSfD7nk63tmuHQbs.BXYMIuJ6TJr(bool fActivate)
	{
		return 2147500033u;
	}

	uint ew0yN4McpJ9lA7pcNK7.bPAOSfD7nk63tmuHQbs.ESvMIkQ9HQg(ew0yN4McpJ9lA7pcNK7.anQLCmDmGdeLDFK0nUI rect, object doc, bool fFrameWindow)
	{
		return 2147500033u;
	}

	uint ew0yN4McpJ9lA7pcNK7.bPAOSfD7nk63tmuHQbs.QQBMIXUiHEl(ref Message msg, ref Guid group, int nCmdID)
	{
		return 1u;
	}

	uint ew0yN4McpJ9lA7pcNK7.bPAOSfD7nk63tmuHQbs.bOIMIUFdJDy(string[] pbstrKey, int dw)
	{
		return 2147500033u;
	}

	uint ew0yN4McpJ9lA7pcNK7.bPAOSfD7nk63tmuHQbs.s2aMIdpE29p(object pDropTarget, out object ppDropTarget)
	{
		ppDropTarget = null;
		return 2147500033u;
	}

	uint ew0yN4McpJ9lA7pcNK7.bPAOSfD7nk63tmuHQbs.z40MI0gT57w(out object ppDispatch)
	{
		ppDispatch = Browser.ObjectForScripting;
		return 0u;
	}

	uint ew0yN4McpJ9lA7pcNK7.bPAOSfD7nk63tmuHQbs.HaUMIDJPKVN(int dwTranslate, string strURLIn, out string string_0)
	{
		string_0 = null;
		return 2147500033u;
	}

	uint ew0yN4McpJ9lA7pcNK7.bPAOSfD7nk63tmuHQbs.xNKMImsbnes(System.Runtime.InteropServices.ComTypes.IDataObject pDO, out System.Runtime.InteropServices.ComTypes.IDataObject ppDORet)
	{
		ppDORet = null;
		return 2147500033u;
	}

	public static void SetSilent(System.Windows.Controls.WebBrowser browser, bool silent)
	{
		if (browser.Document is ew0yN4McpJ9lA7pcNK7.rqK5HCDDIY5ocU8L5tT rqK5HCDDIY5ocU8L5tT)
		{
			Guid guidService = new Guid("0002DF05-0000-0000-C000-000000000046");
			Guid riid = new Guid("D30C1661-CDAF-11d0-8A3E-00C04FC9E26E");
			rqK5HCDDIY5ocU8L5tT.QueryService(ref guidService, ref riid, out var ppvObject);
			ppvObject?.GetType().InvokeMember("Silent", BindingFlags.Instance | BindingFlags.Public | BindingFlags.PutDispProperty, null, ppvObject, new object[1] { silent });
		}
	}

	internal static bool eKahu3FPnCGOeBu12iWJ()
	{
		return gbSfbXFPAbcdkbKoBBIm == null;
	}
}
