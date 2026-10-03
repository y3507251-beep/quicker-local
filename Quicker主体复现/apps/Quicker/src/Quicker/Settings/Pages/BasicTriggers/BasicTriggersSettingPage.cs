using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Markup;
using Quicker.Common.Entities;

namespace Quicker.Settings.Pages.BasicTriggers;

public class BasicTriggersSettingPage : SettingPage, IComponentConnector
{
	private bool b54DQR9SYN;

	internal static BasicTriggersSettingPage I4nYvxsARbbFMKLsX6v;

	public BasicTriggersSettingPage()
	{
		InitializeComponent();
	}

	protected override void LoadDataToUi(UserSettings settings)
	{
	}

	protected override bool SaveDataFromUi(UserSettings settings)
	{
		return true;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!b54DQR9SYN)
		{
			b54DQR9SYN = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/basictriggers/basictriggerssettingpage.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		b54DQR9SYN = true;
	}

	internal static bool F2YldpsnjXYBwANkvly()
	{
		return I4nYvxsARbbFMKLsX6v == null;
	}
}
