using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Quicker.Common.Entities;

namespace Quicker.Settings.Pages.ContextMenus;

public class FileContextMenuSettings : SettingPage, IComponentConnector
{
	internal TextBox TxtMoveToTargets;

	private bool eWO4V5ORvc;

	internal static FileContextMenuSettings X3I2gHTiJuYQDVbXBuC;

	public FileContextMenuSettings()
	{
		InitializeComponent();
	}

	protected override void LoadDataToUi(UserSettings settings)
	{
		TxtMoveToTargets.Text = settings.ContextMenuSettings.FileMoveTargets;
	}

	protected override bool SaveDataFromUi(UserSettings settings)
	{
		settings.ContextMenuSettings.FileMoveTargets = TxtMoveToTargets.Text;
		return true;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!eWO4V5ORvc)
		{
			eWO4V5ORvc = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/contextmenus/filecontextmenusettings.xaml", UriKind.Relative);
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
		if (connectionId == 1)
		{
			TxtMoveToTargets = (TextBox)target;
		}
		else
		{
			eWO4V5ORvc = true;
		}
	}

	internal static bool S8mCAgTltxAuZ0lsuUx()
	{
		return X3I2gHTiJuYQDVbXBuC == null;
	}
}
