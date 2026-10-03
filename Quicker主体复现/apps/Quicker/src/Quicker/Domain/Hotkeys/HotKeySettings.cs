using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using log4net;
using Newtonsoft.Json;

namespace Quicker.Domain.Hotkeys;

public class HotKeySettings
{
	private static readonly ILog ayWtcKrH8vI;

	[CompilerGenerated]
	private string haatcxpihSL;

	[CompilerGenerated]
	private string yZItcrTtNvf;

	[CompilerGenerated]
	private string yFKtcp9ur16;

	[CompilerGenerated]
	private string eyOtcBK46Ru;

	[CompilerGenerated]
	private string pNLtcQp4J9U;

	[CompilerGenerated]
	private string Fw6tcj68ltW;

	[CompilerGenerated]
	private string JmTtcnPekro;

	[CompilerGenerated]
	private string HVltc4UrpdQ;

	[CompilerGenerated]
	private string Qnitc57JKU2;

	[CompilerGenerated]
	private string dQBtcD9CCgC;

	[CompilerGenerated]
	private string bqbtcdwsrnM;

	[CompilerGenerated]
	private IList<ActionHotKeyItem> CWAtcoGNNoE = new List<ActionHotKeyItem>();

	internal static HotKeySettings R8IHTrQ1cU2tnqg3RZeS;

	public string KeysForPausePopup
	{
		[CompilerGenerated]
		get
		{
			return haatcxpihSL;
		}
		[CompilerGenerated]
		set
		{
			haatcxpihSL = value;
		}
	}

	public string KeysForOpenSettings
	{
		[CompilerGenerated]
		get
		{
			return yZItcrTtNvf;
		}
		[CompilerGenerated]
		set
		{
			yZItcrTtNvf = value;
		}
	}

	public string KeysForExeSettings
	{
		[CompilerGenerated]
		get
		{
			return yFKtcp9ur16;
		}
		[CompilerGenerated]
		set
		{
			yFKtcp9ur16 = value;
		}
	}

	public string KeysForAppStartVoiceInput
	{
		[CompilerGenerated]
		get
		{
			return eyOtcBK46Ru;
		}
		[CompilerGenerated]
		set
		{
			eyOtcBK46Ru = value;
		}
	}

	public string KeysForCancelRunningTasks
	{
		[CompilerGenerated]
		get
		{
			return pNLtcQp4J9U;
		}
		[CompilerGenerated]
		set
		{
			pNLtcQp4J9U = value;
		}
	}

	public string KeysForCloseAllFloatButtons
	{
		[CompilerGenerated]
		get
		{
			return Fw6tcj68ltW;
		}
		[CompilerGenerated]
		set
		{
			Fw6tcj68ltW = value;
		}
	}

	public string KeysForReloadMouseHook
	{
		[CompilerGenerated]
		get
		{
			return JmTtcnPekro;
		}
		[CompilerGenerated]
		set
		{
			JmTtcnPekro = value;
		}
	}

	public string KeysForSearch
	{
		[CompilerGenerated]
		get
		{
			return HVltc4UrpdQ;
		}
		[CompilerGenerated]
		set
		{
			HVltc4UrpdQ = value;
		}
	}

	public string KeysForRepeatLast
	{
		[CompilerGenerated]
		get
		{
			return Qnitc57JKU2;
		}
		[CompilerGenerated]
		set
		{
			Qnitc57JKU2 = value;
		}
	}

	public string KeysForDashboardWindow
	{
		[CompilerGenerated]
		get
		{
			return dQBtcD9CCgC;
		}
		[CompilerGenerated]
		set
		{
			dQBtcD9CCgC = value;
		}
	}

	public string KeysForToggleTextFloatWindow
	{
		[CompilerGenerated]
		get
		{
			return bqbtcdwsrnM;
		}
		[CompilerGenerated]
		set
		{
			bqbtcdwsrnM = value;
		}
	}

	public IList<ActionHotKeyItem> ActionHotkeys
	{
		[CompilerGenerated]
		get
		{
			return CWAtcoGNNoE;
		}
		[CompilerGenerated]
		set
		{
			CWAtcoGNNoE = value;
		}
	}

	public string ToData()
	{
		return JsonConvert.SerializeObject(this);
	}

	public static HotKeySettings FromData(string data)
	{
		if (string.IsNullOrEmpty(data))
		{
			return new HotKeySettings();
		}
		try
		{
			return JsonConvert.DeserializeObject<HotKeySettings>(data);
		}
		catch (Exception exception)
		{
			ayWtcKrH8vI.Warn("解析快捷键数据异常。", exception);
			return new HotKeySettings();
		}
	}

	static HotKeySettings()
	{
		ayWtcKrH8vI = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool wDXrqQQ1WDNCs1CaOZFj()
	{
		return R8IHTrQ1cU2tnqg3RZeS == null;
	}

	internal static void EGBln7Q1pb5wHLpnp4rg()
	{
	}
}
