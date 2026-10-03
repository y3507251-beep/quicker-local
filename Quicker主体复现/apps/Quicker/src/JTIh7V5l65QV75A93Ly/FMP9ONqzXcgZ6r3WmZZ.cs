using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;
using dkbgyyMixGueocCf9RC;
using HandyControl.Controls;
using HandyControl.Data;
using Microsoft.Win32;
using Quicker;
using Quicker.Annotations;
using Quicker.Common.Entities;
using Quicker.Domain;
using Quicker.Utilities;

namespace JTIh7V5l65QV75A93Ly;

internal static class FMP9ONqzXcgZ6r3WmZZ
{
	[CompilerGenerated]
	private static class _003C_003EO
	{
		public static UserPreferenceChangedEventHandler d6CvRRf3mmn;
	}

	internal static object N6aZpfZGICC8poI3ZBN;

	internal static bool vOSH8m04RO()
	{
		using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize");
		object obj = registryKey?.GetValue("AppsUseLightTheme");
		if (obj == null)
		{
			return false;
		}
		return (int)obj <= 0;
	}

	private static void jcnHaDEQOH()
	{
		bool flag = vOSH8m04RO();
		App.Current.DKC12DNm22(flag ? SkinType.Dark : SkinType.Default);
	}

	internal static void sXXH7ZuLTN()
	{
		string text = AO7eLUM7kJyEdiOQu2O.ThemeMode;
		SystemEvents.UserPreferenceChanged -= _003C_003EO.d6CvRRf3mmn ?? (_003C_003EO.d6CvRRf3mmn = dtbHR75Edd);
		if (text == "auto")
		{
			SystemEvents.UserPreferenceChanged += _003C_003EO.d6CvRRf3mmn ?? (_003C_003EO.d6CvRRf3mmn = dtbHR75Edd);
		}
		eL7HqOR4DO(text);
	}

	private static void dtbHR75Edd(object sender, UserPreferenceChangedEventArgs e)
	{
		if (e.Category == UserPreferenceCategory.General && AO7eLUM7kJyEdiOQu2O.ThemeMode == "auto")
		{
			jcnHaDEQOH();
		}
	}

	private static void eL7HqOR4DO(string string_0)
	{
		try
		{
			string text = string_0.ToLower();
			int num = 0;
			if (!MErJlwZ0HL8IfmsGjEo())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			switch (text)
			{
			case "auto":
				jcnHaDEQOH();
				break;
			case "dark":
				App.Current.DKC12DNm22(SkinType.Dark);
				break;
			case "":
			case null:
			case "light":
			case "default":
				App.Current.DKC12DNm22(SkinType.Default);
				break;
			}
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning(ex.Message);
		}
	}

	internal static void bocHcD7FL8(string string_0)
	{
		AO7eLUM7kJyEdiOQu2O.ThemeMode = string_0;
		sXXH7ZuLTN();
	}

	internal static void epJHVfvYYD()
	{
		if (App.Current.Brm1CjxFTF() == SkinType.Dark)
		{
			bocHcD7FL8("light");
		}
		else
		{
			bocHcD7FL8("dark");
		}
	}

	[DllImport("DwmApi", EntryPoint = "DwmSetWindowAttribute")]
	private static extern int CCKHZeelE3(IntPtr intptr_0, int int_0, int[] int_1, int int_2);

	internal static void Y6sH9w6XPI(System.Windows.Window window_0, bool bool_0 = true)
	{
		int num = (bool_0 ? 1 : 0);
		if (window_0 != null && window_0.WindowStyle != WindowStyle.None && !(window_0 is HandyControl.Controls.Window))
		{
			IntPtr handle = new WindowInteropHelper(window_0).Handle;
			if (CCKHZeelE3(handle, 19, new int[1] { num }, 4) != 0)
			{
				CCKHZeelE3(handle, 20, new int[1] { num }, 4);
			}
		}
	}

	internal static void mY8HhxULkw()
	{
	}

	[CanBeNull]
	internal static UiSettings A4qHeQImJ6()
	{
		UserSettings userSettings = AppState.HHxtaMaoqJr();
		if (userSettings == null)
		{
			return null;
		}
		if (App.Current.n991yfUy4r() && userSettings.SwitchUiSettingsBasedOnTheme && userSettings.DarkUiSettings != null)
		{
			return userSettings.DarkUiSettings;
		}
		return userSettings.UiSettings ?? new UiSettings();
	}

	internal static bool D80HY8PEx7()
	{
		if (AppState.HHxtaMaoqJr().SwitchUiSettingsBasedOnTheme && App.Current.n991yfUy4r())
		{
			return AppState.HHxtaMaoqJr().DarkUiSettings != null;
		}
		return false;
	}

	static FMP9ONqzXcgZ6r3WmZZ()
	{
	}

	internal static bool MErJlwZ0HL8IfmsGjEo()
	{
		return N6aZpfZGICC8poI3ZBN == null;
	}

	internal static void lU2H7aZvLIrENJh5WxK()
	{
	}
}
