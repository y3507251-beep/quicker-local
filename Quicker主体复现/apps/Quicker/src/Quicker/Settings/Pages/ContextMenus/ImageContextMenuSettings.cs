using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Quicker.Common.Entities;

namespace Quicker.Settings.Pages.ContextMenus;

public class ImageContextMenuSettings : SettingPage, IComponentConnector
{
	internal TextBox TxtImageSearchUrls;

	private bool ngl4ZqbHoQ;

	private static ImageContextMenuSettings vyZegHT5r8wrJshtNGy;

	public ImageContextMenuSettings()
	{
		InitializeComponent();
	}

	protected override void LoadDataToUi(UserSettings settings)
	{
		TxtImageSearchUrls.Text = settings.ContextMenuSettings.ImageSearchUrls;
	}

	protected override bool SaveDataFromUi(UserSettings settings)
	{
		settings.ContextMenuSettings.ImageSearchUrls = TxtImageSearchUrls.Text;
		return true;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!ngl4ZqbHoQ)
		{
			ngl4ZqbHoQ = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/contextmenus/imagecontextmenusettings.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 1)
		{
			TxtImageSearchUrls = (TextBox)target;
		}
		else
		{
			ngl4ZqbHoQ = true;
		}
	}

	internal static bool cW02RSTY77uMHNqP6ON()
	{
		return vyZegHT5r8wrJshtNGy == null;
	}
}
