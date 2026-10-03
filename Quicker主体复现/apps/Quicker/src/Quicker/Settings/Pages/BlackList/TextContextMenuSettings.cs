using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Quicker.Common.Entities;

namespace Quicker.Settings.Pages.BlackList;

public class TextContextMenuSettings : SettingPage, IComponentConnector
{
	internal TextBox TxtTextSearchUrls;

	private bool zEY4cyuxPM;

	private static TextContextMenuSettings N0PBmnTfInmuoEjWQ4E;

	public TextContextMenuSettings()
	{
		InitializeComponent();
	}

	protected override void LoadDataToUi(UserSettings settings)
	{
		TxtTextSearchUrls.Text = settings.ContextMenuSettings.TextSearchUrls;
	}

	protected override bool SaveDataFromUi(UserSettings settings)
	{
		settings.ContextMenuSettings.TextSearchUrls = TxtTextSearchUrls.Text;
		return true;
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!zEY4cyuxPM)
		{
			zEY4cyuxPM = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/contextmenus/textcontextmenusettings.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 1)
		{
			TxtTextSearchUrls = (TextBox)target;
		}
		else
		{
			zEY4cyuxPM = true;
		}
	}

	internal static bool jNLEfvTbWTXMwUMpvUf()
	{
		return N0PBmnTfInmuoEjWQ4E == null;
	}
}
