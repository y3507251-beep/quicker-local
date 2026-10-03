using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Markup;
using Quicker.Domain.Services;
using Quicker.Settings.Code;
using Quicker.Utilities;

namespace Quicker.View;

public class BuyQuickerWindow : Window, IComponentConnector
{
	private readonly SettingPageId? aZBgQFoTLEC;

	internal TextBlock TxtWrapper;

	internal Hyperlink LnkAboutThisFunction;

	internal TextBlock LnkText;

	internal Button BtnBuy;

	internal Button BtnOpenSetting;

	private bool rslgQUEDDWo;

	private static BuyQuickerWindow rIri0IQzUV1ef0hnaZ1f;

	public BuyQuickerWindow(string functionName, string functionHelpUrl, SettingPageId? settingPageId)
	{
		aZBgQFoTLEC = settingPageId;
		InitializeComponent();
		if (!string.IsNullOrEmpty(functionHelpUrl))
		{
			LnkText.Text = functionName;
			LnkAboutThisFunction.NavigateUri = new Uri(functionHelpUrl);
		}
		else
		{
			TxtWrapper.Text = functionName;
		}
		if (settingPageId.HasValue)
		{
			BtnOpenSetting.Visibility = Visibility.Visible;
		}
	}

	private void b4kgQAf4asm(object sender, RoutedEventArgs e)
	{
		AppHelper.TryOpenUrlOrFile("https://getquicker.net/Member/Buy");
	}

	private void R3ngQOxJr8v(object sender, RoutedEventArgs e)
	{
		AppWindowManager.ShowSettingsWindow(aZBgQFoTLEC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!rslgQUEDDWo)
		{
			rslgQUEDDWo = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/account/buyquickerwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			rslgQUEDDWo = true;
			break;
		case 1:
			TxtWrapper = (TextBlock)target;
			break;
		case 2:
			LnkAboutThisFunction = (Hyperlink)target;
			break;
		case 3:
			LnkText = (TextBlock)target;
			break;
		case 4:
		{
			BtnBuy = (Button)target;
			int num = 0;
			if (rIri0IQzUV1ef0hnaZ1f != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				BtnBuy.Click += b4kgQAf4asm;
				break;
			}
			break;
		}
		case 5:
			BtnOpenSetting = (Button)target;
			BtnOpenSetting.Click += R3ngQOxJr8v;
			break;
		}
	}

	static BuyQuickerWindow()
	{
	}

	internal static bool v6IhynQzxumbTWar6b4h()
	{
		return rIri0IQzUV1ef0hnaZ1f == null;
	}

	internal static void zF2H4mQztmi5GHRvPp4M()
	{
	}
}
