using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Quicker.Common.QuickActions;
using Quicker.Domain.Exe;
using Quicker.Domain.PowerMouse;

namespace Quicker.Domain.Entities;

public class ExeSettings
{
	[CompilerGenerated]
	private string q6BtjqGlYBQ;

	[CompilerGenerated]
	private string xgmtjccuK95;

	[CompilerGenerated]
	private string yIutjV6SadG;

	[CompilerGenerated]
	private string eTttjZu138P;

	[CompilerGenerated]
	private string zQJtj9v6AXr;

	[CompilerGenerated]
	private IList<string> dsotjh96Pqp;

	[CompilerGenerated]
	private bool gfZtjeBfPOC;

	[CompilerGenerated]
	private bool JaXtjY7kJ1O;

	[CompilerGenerated]
	private IList<string> aEUtjIPLr8u;

	[CompilerGenerated]
	private bool wZHtjWamGAP;

	[CompilerGenerated]
	private IDictionary<string, string> B1qtjkRpuu8 = new Dictionary<string, string>();

	[CompilerGenerated]
	private IList<string> b7ntjGchETf;

	[CompilerGenerated]
	private bool lJKtjsFPy3P;

	[CompilerGenerated]
	private bool oKgtjHbhwVD;

	[CompilerGenerated]
	private IList<GestureAction> yBdtj1mKBhs = new List<GestureAction>();

	[CompilerGenerated]
	private IList<PowerKeyActionItem> P4Xtjb4vQGJ;

	[CompilerGenerated]
	private IList<KeyActionItem> pPetj6I2PwV;

	[CompilerGenerated]
	private IList<HotkeyWatcherItem> bkXtjXihmQe;

	internal static ExeSettings SmY7BaQLH3i8JCRyhQ8H;

	public string Exe
	{
		[CompilerGenerated]
		get
		{
			return q6BtjqGlYBQ;
		}
		[CompilerGenerated]
		set
		{
			q6BtjqGlYBQ = value;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return xgmtjccuK95;
		}
		[CompilerGenerated]
		set
		{
			xgmtjccuK95 = value;
		}
	}

	public string Path
	{
		[CompilerGenerated]
		get
		{
			return yIutjV6SadG;
		}
		[CompilerGenerated]
		set
		{
			yIutjV6SadG = value;
		}
	}

	public string UrlPattern
	{
		[CompilerGenerated]
		get
		{
			return eTttjZu138P;
		}
		[CompilerGenerated]
		set
		{
			eTttjZu138P = value;
		}
	}

	public string IconUrl
	{
		[CompilerGenerated]
		get
		{
			return zQJtj9v6AXr;
		}
		[CompilerGenerated]
		set
		{
			zQJtj9v6AXr = value;
		}
	}

	public IList<string> ProfileList
	{
		[CompilerGenerated]
		get
		{
			return dsotjh96Pqp;
		}
		[CompilerGenerated]
		set
		{
			dsotjh96Pqp = value;
		}
	}

	public bool DisableMiddleButton
	{
		[CompilerGenerated]
		get
		{
			return gfZtjeBfPOC;
		}
		[CompilerGenerated]
		set
		{
			gfZtjeBfPOC = value;
		}
	}

	public bool AttachAllCommonProfiles
	{
		[CompilerGenerated]
		get
		{
			return JaXtjY7kJ1O;
		}
		[CompilerGenerated]
		set
		{
			JaXtjY7kJ1O = value;
		}
	}

	public IList<string> AttachProfiles
	{
		[CompilerGenerated]
		get
		{
			return aEUtjIPLr8u;
		}
		[CompilerGenerated]
		set
		{
			aEUtjIPLr8u = value;
		}
	}

	public bool ReturnToFirstPage
	{
		[CompilerGenerated]
		get
		{
			return wZHtjWamGAP;
		}
		[CompilerGenerated]
		set
		{
			wZHtjWamGAP = value;
		}
	}

	public IDictionary<string, string> CircleMenuActions
	{
		[CompilerGenerated]
		get
		{
			return B1qtjkRpuu8;
		}
		[CompilerGenerated]
		set
		{
			B1qtjkRpuu8 = value;
		}
	}

	public IList<string> AliasExeList
	{
		[CompilerGenerated]
		get
		{
			return b7ntjGchETf;
		}
		[CompilerGenerated]
		set
		{
			b7ntjGchETf = value;
		}
	}

	public bool DisableCircleMenu
	{
		[CompilerGenerated]
		get
		{
			return lJKtjsFPy3P;
		}
		[CompilerGenerated]
		set
		{
			lJKtjsFPy3P = value;
		}
	}

	public bool DisableGesture
	{
		[CompilerGenerated]
		get
		{
			return oKgtjHbhwVD;
		}
		[CompilerGenerated]
		set
		{
			oKgtjHbhwVD = value;
		}
	}

	public IList<GestureAction> GestureActions
	{
		[CompilerGenerated]
		get
		{
			return yBdtj1mKBhs;
		}
		[CompilerGenerated]
		set
		{
			yBdtj1mKBhs = value;
		}
	}

	public IList<PowerKeyActionItem> LeftButtonPlusActions
	{
		[CompilerGenerated]
		get
		{
			return P4Xtjb4vQGJ;
		}
		[CompilerGenerated]
		set
		{
			P4Xtjb4vQGJ = value;
		}
	}

	public IList<KeyActionItem> KeyActionItems
	{
		[CompilerGenerated]
		get
		{
			return pPetj6I2PwV;
		}
		[CompilerGenerated]
		set
		{
			pPetj6I2PwV = value;
		}
	}

	public IList<HotkeyWatcherItem> HotkeyWatcherItems
	{
		[CompilerGenerated]
		get
		{
			return bkXtjXihmQe;
		}
		[CompilerGenerated]
		set
		{
			bkXtjXihmQe = value;
		}
	}

	public string GetIconStr()
	{
		if (string.IsNullOrEmpty(IconUrl))
		{
			return ExeFileIconHelper.GetExeFileIconStr(Exe, Path);
		}
		if (IconUrl.StartsWith("http", StringComparison.OrdinalIgnoreCase))
		{
			return "url:" + IconUrl;
		}
		return IconUrl;
	}

	public string GetCommonDataId()
	{
		return GetCommonDataId(Exe);
	}

	public static string GetCommonDataId(string exe)
	{
		return "exe:" + exe;
	}

	public void EnsureDataValid()
	{
		if (CircleMenuActions == null)
		{
			CircleMenuActions = new Dictionary<string, string>();
		}
	}

	internal static bool RlOGKVQLzpWLGVKmDtri()
	{
		return SmY7BaQLH3i8JCRyhQ8H == null;
	}
}
