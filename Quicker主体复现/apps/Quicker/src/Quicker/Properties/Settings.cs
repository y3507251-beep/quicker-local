using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Quicker.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.6.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance;

	internal static Settings otCuQKR6joj7RpdBdEY;

	public static Settings Default => defaultInstance;

	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	[UserScopedSetting]
	public string username
	{
		get
		{
			return (string)this["username"];
		}
		set
		{
			this["username"] = value;
		}
	}

	[DefaultSettingValue("True")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public bool UpdateSettings
	{
		get
		{
			return (bool)this["UpdateSettings"];
		}
		set
		{
			this["UpdateSettings"] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	public string notifiedVersion
	{
		get
		{
			return (string)this["notifiedVersion"];
		}
		set
		{
			this["notifiedVersion"] = value;
		}
	}

	[DefaultSettingValue("")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string LocalIp
	{
		get
		{
			return (string)this["LocalIp"];
		}
		set
		{
			this["LocalIp"] = value;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1.1.41.0")]
	public string PrevVersion
	{
		get
		{
			return (string)this["PrevVersion"];
		}
		set
		{
			this["PrevVersion"] = value;
		}
	}

	[DefaultSettingValue("slow")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string Channel
	{
		get
		{
			return (string)this["Channel"];
		}
		set
		{
			this["Channel"] = value;
		}
	}

	[DefaultSettingValue("False")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public bool UseSystemProxy
	{
		get
		{
			return (bool)this["UseSystemProxy"];
		}
		set
		{
			this["UseSystemProxy"] = value;
		}
	}

	[DefaultSettingValue("False")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public bool ToolboxOrderByUseCount
	{
		get
		{
			return (bool)this["ToolboxOrderByUseCount"];
		}
		set
		{
			this["ToolboxOrderByUseCount"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("False")]
	public bool EnableConnection
	{
		get
		{
			return (bool)this["EnableConnection"];
		}
		set
		{
			this["EnableConnection"] = value;
		}
	}

	[DefaultSettingValue("")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string ProxySettings
	{
		get
		{
			return (string)this["ProxySettings"];
		}
		set
		{
			this["ProxySettings"] = value;
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	[UserScopedSetting]
	public string EnableSimpleMode
	{
		get
		{
			return (string)this["EnableSimpleMode"];
		}
		set
		{
			this["EnableSimpleMode"] = value;
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	public string ThemeMode
	{
		get
		{
			return (string)this["ThemeMode"];
		}
		set
		{
			this["ThemeMode"] = value;
		}
	}

	static Settings()
	{
		defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}

	internal static bool oyWYTHRttDiorPmQBF9()
	{
		return otCuQKR6joj7RpdBdEY == null;
	}
}
