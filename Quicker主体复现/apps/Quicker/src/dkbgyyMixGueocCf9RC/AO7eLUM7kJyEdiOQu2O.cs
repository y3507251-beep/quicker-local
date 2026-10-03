using System;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using GDJ8gQYQNj5vETZI5u5;
using log4net;
using Newtonsoft.Json;
using Quicker.Properties;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Ext;

namespace dkbgyyMixGueocCf9RC;

internal static class AO7eLUM7kJyEdiOQu2O
{
	private static readonly ILog dqqLMIK1Tr2;

	private static ProxySetting pFDLMWyL8Ar;

	internal static object tYkVPKFRK7OlifZ3ctkT;

	[Obsolete("使用ProxySettings")]
	public static bool UseSystemProxy
	{
		get
		{
			try
			{
				return Settings.Default.UseSystemProxy;
			}
			catch (Exception ex)
			{
				dqqLMIK1Tr2.Warn("访问系统配置出错。" + ex.Message, ex);
				return false;
			}
		}
		set
		{
			try
			{
				Settings.Default.UseSystemProxy = value;
				Settings.Default.Save();
			}
			catch (Exception exception)
			{
				string message = "保存配置信息出错！" + exception.GetMessageWithInner();
				dqqLMIK1Tr2.Warn(message);
				AppHelper.ShowWarning(message);
			}
		}
	}

	public static bool EnableSimpleMode
	{
		get
		{
			return false;
		}
		set
		{
			try
			{
				Settings.Default.EnableSimpleMode = ((!value) ? "0" : "1");
				Settings.Default.Save();
			}
			catch (Exception exception)
			{
				string message = "保存配置信息出错！" + exception.GetMessageWithInner();
				dqqLMIK1Tr2.Warn(message);
				AppHelper.ShowWarning(message);
			}
		}
	}

	public static bool ToolboxOrderByUseCount
	{
		get
		{
			try
			{
				return Settings.Default.ToolboxOrderByUseCount;
			}
			catch (Exception ex)
			{
				dqqLMIK1Tr2.Warn("访问系统配置出错。" + ex.Message, ex);
				return false;
			}
		}
		set
		{
			try
			{
				Settings.Default.ToolboxOrderByUseCount = value;
				Settings.Default.Save();
			}
			catch (Exception exception)
			{
				string message = "保存配置信息出错！" + exception.GetMessageWithInner();
				dqqLMIK1Tr2.Warn(message);
				AppHelper.ShowWarning(message);
			}
		}
	}

	public static bool EnableConnection
	{
		get
		{
			try
			{
				return Settings.Default.EnableConnection;
			}
			catch (Exception ex)
			{
				dqqLMIK1Tr2.Warn("访问系统配置出错。" + ex.Message, ex);
				return false;
			}
		}
		set
		{
			try
			{
				Settings.Default.EnableConnection = value;
				Settings.Default.Save();
			}
			catch (Exception exception)
			{
				string message = "保存配置信息出错！" + exception.GetMessageWithInner();
				dqqLMIK1Tr2.Warn(message);
				AppHelper.ShowWarning(message);
			}
		}
	}

	public static string ThemeMode
	{
		get
		{
			try
			{
				return Settings.Default.ThemeMode;
			}
			catch (Exception ex)
			{
				dqqLMIK1Tr2.Warn("访问系统配置出错。" + ex.Message, ex);
				return "";
			}
		}
		set
		{
			try
			{
				Settings.Default.ThemeMode = value;
				Settings.Default.Save();
			}
			catch (Exception exception)
			{
				string message = "保存配置信息出错！" + exception.GetMessageWithInner();
				dqqLMIK1Tr2.Warn(message);
				AppHelper.ShowWarning(message);
			}
		}
	}

	public static void IU7LML773eo()
	{
		if (Settings.Default.UpdateSettings)
		{
			Settings.Default.Upgrade();
			Settings.Default.UpdateSettings = false;
			if (!Settings.Default.username.IsNullOrWhiteSpace() && !Settings.Default.username.StartsWith("$$"))
			{
				Settings.Default.username = "$$" + rq9NeKYB7dbpc702LOx.Eo5L5dwn62U().knBL551eJpR(Settings.Default.username);
			}
			Settings.Default.Save();
			string fullPath = Path.GetFullPath(Path.Combine(ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath, "..\\..\\"));
			string[] directories = Directory.GetDirectories(fullPath);
			foreach (string text in directories)
			{
				if (text != fullPath + Assembly.GetEntryAssembly().GetName().Version.ToString())
				{
					Directory.Delete(text, true);
				}
			}
			int num = 0;
			if (tYkVPKFRK7OlifZ3ctkT != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				return;
			case 1:
				break;
			}
		}
		else if (Settings.Default.username.IsNullOrWhiteSpace() || Settings.Default.username.StartsWith("$$"))
		{
			return;
		}
		Settings.Default.username = "$$" + rq9NeKYB7dbpc702LOx.Eo5L5dwn62U().knBL551eJpR(Settings.Default.username);
		Settings.Default.Save();
	}

	public static void yULLMvpPECk(ILog ilog_1)
	{
		try
		{
			ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);
		}
		catch (ConfigurationErrorsException ex)
		{
			string filename = ex.Filename;
			ilog_1.Error("Cannot open config file", ex);
			if (File.Exists(filename))
			{
				ilog_1.Error(string.Format(CultureInfo.InvariantCulture, "Config file {0} content:\n{1}", filename, File.ReadAllText(filename)));
				File.Delete(filename);
				ilog_1.Error("Config file deleted");
				Settings.Default.Upgrade();
				return;
			}
			ilog_1.Error("Config file " + filename + " does not exist");
			int num = 0;
			if (tYkVPKFRK7OlifZ3ctkT != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
	}

	public static bool uoJLMS39E28(out string string_0)
	{
		string_0 = Settings.Default.username;
		string obj = string_0;
		if (obj != null && obj.StartsWith("$$"))
		{
			try
			{
				string_0 = rq9NeKYB7dbpc702LOx.Eo5L5dwn62U().aiWL5D2yNYB(string_0.Substring(2));
			}
			catch (Exception ex)
			{
				dqqLMIK1Tr2.Warn("解密Email出错：" + ex.Message);
			}
		}
		return true;
	}

	public static void ARbLM2BwuxL(string string_0)
	{
		try
		{
			Settings.Default.username = "$$" + rq9NeKYB7dbpc702LOx.Eo5L5dwn62U().knBL551eJpR(string_0);
			Settings.Default.Save();
		}
		catch (Exception exception)
		{
			string message = "保存配置信息出错！" + exception.GetMessageWithInner();
			dqqLMIK1Tr2.Warn(message);
			AppHelper.ShowWarning(message);
		}
	}

	private static string avZLMuEY9QZ(string string_0)
	{
		using SecureString input = string_0.ToSecureString();
		return input.EncryptString();
	}

	public static void Reset()
	{
		try
		{
			Settings.Default.Reset();
			Settings.Default.Save();
		}
		catch (Exception exception)
		{
			string message = "保存配置信息出错！" + exception.GetMessageWithInner();
			dqqLMIK1Tr2.Warn(message);
			AppHelper.ShowWarning(message);
		}
	}

	public static string pN3LMNMK07r()
	{
		return Settings.Default.notifiedVersion;
	}

	[SpecialName]
	public static string v6XLMCkb4SD()
	{
		return Settings.Default.LocalIp;
	}

	[SpecialName]
	public static void cSxLMPuIDlk(string string_0)
	{
		try
		{
			Settings.Default.LocalIp = string_0;
			Settings.Default.Save();
		}
		catch (Exception exception)
		{
			string message = "保存配置信息出错！" + exception.GetMessageWithInner();
			dqqLMIK1Tr2.Warn(message);
			AppHelper.ShowWarning(message);
		}
	}

	[SpecialName]
	public static ProxySetting w7cLMa3s1jT()
	{
		if (pFDLMWyL8Ar == null)
		{
			pFDLMWyL8Ar = X2xLMJ81aoy();
		}
		return pFDLMWyL8Ar;
	}

	[SpecialName]
	public static void I4ULM7Vyvra(ProxySetting proxySetting_1)
	{
		pFDLMWyL8Ar = proxySetting_1;
		try
		{
			Settings.Default.ProxySettings = ((pFDLMWyL8Ar == null) ? null : JsonConvert.SerializeObject(pFDLMWyL8Ar));
			Settings.Default.Save();
		}
		catch (Exception exception)
		{
			string message = "保存配置信息出错！" + exception.GetMessageWithInner();
			dqqLMIK1Tr2.Warn(message);
			AppHelper.ShowWarning(message);
		}
	}

	private static ProxySetting X2xLMJ81aoy()
	{
		try
		{
			string proxySettings = Settings.Default.ProxySettings;
			if (string.IsNullOrEmpty(proxySettings))
			{
				return PW5LM0On4u8();
			}
			ProxySetting proxySetting = JsonConvert.DeserializeObject<ProxySetting>(proxySettings);
			if (proxySetting != null)
			{
				return proxySetting;
			}
			return PW5LM0On4u8();
		}
		catch (Exception ex)
		{
			dqqLMIK1Tr2.Warn("访问系统配置出错。" + ex.Message, ex);
			return PW5LM0On4u8();
		}
	}

	static AO7eLUM7kJyEdiOQu2O()
	{
		dqqLMIK1Tr2 = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	[CompilerGenerated]
	internal static ProxySetting PW5LM0On4u8()
	{
		return new ProxySetting
		{
			Mode = (UseSystemProxy ? ProxyMode.System : ProxyMode.Disable)
		};
	}

	internal static bool lM28ZdFRBG0Yj1v4yJM8()
	{
		return tYkVPKFRK7OlifZ3ctkT == null;
	}
}
