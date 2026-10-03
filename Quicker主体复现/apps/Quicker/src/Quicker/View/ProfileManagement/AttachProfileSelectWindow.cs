using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Markup;
using Quicker.Common;
using Quicker.Domain;
using Quicker.Domain.Profiles;
using Quicker.Public.Extensions;
using Quicker.Utilities.UI;

namespace Quicker.View.ProfileManagement;

public class AttachProfileSelectWindow : Window, IComponentConnector
{
	private readonly ProfileManager TVPLNKHFGW5;

	private readonly IList<string> K6fLNxl6yh3;

	[CompilerGenerated]
	private IList<string> c7tLNrn602x = new List<string>();

	internal ListBox LbProfiles;

	internal Button BtnAll;

	internal Button BtnOk;

	private bool MTVLNpHGACF;

	private static AttachProfileSelectWindow sHg9oeFDyanPQYC0aXv9;

	public IList<string> SelectedProfiles
	{
		[CompilerGenerated]
		get
		{
			return c7tLNrn602x;
		}
		[CompilerGenerated]
		private set
		{
			c7tLNrn602x = value;
		}
	}

	public AttachProfileSelectWindow(ProfileManager profileManager, IList<string> selectedProfiles)
	{
		TVPLNKHFGW5 = profileManager;
		K6fLNxl6yh3 = selectedProfiles;
		InitializeComponent();
		base.Loaded += S15LNblc0xa;
	}

	private void S15LNblc0xa(object sender, RoutedEventArgs e)
	{
		IList<ActionProfile> allProfilesByExe = TVPLNKHFGW5.GetAllProfilesByExe("common");
		LbProfiles.ItemsSource = allProfilesByExe;
		if (!K6fLNxl6yh3.HasData())
		{
			return;
		}
		foreach (ActionProfile item in allProfilesByExe)
		{
			if (K6fLNxl6yh3.Contains(item.Id))
			{
				LbProfiles.SelectedItems.Add(item);
			}
		}
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void gpiLN6xRcWI(object sender, RoutedEventArgs e)
	{
		SelectedProfiles.Clear();
		foreach (object selectedItem in LbProfiles.SelectedItems)
		{
			SelectedProfiles.Add((selectedItem as ActionProfile).Id);
		}
		base.DialogResult = true;
	}

	private void STeLNXhrXpS(object sender, RoutedEventArgs e)
	{
		LbProfiles.SelectedItems.Clear();
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!MTVLNpHGACF)
		{
			MTVLNpHGACF = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/profilemanagement/attachprofileselectwindow.xaml", UriKind.Relative);
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
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			MTVLNpHGACF = true;
			break;
		case 1:
			LbProfiles = (ListBox)target;
			break;
		case 2:
			BtnAll = (Button)target;
			BtnAll.Click += STeLNXhrXpS;
			break;
		case 3:
			BtnOk = (Button)target;
			BtnOk.Click += gpiLN6xRcWI;
			break;
		}
	}

	internal static bool gdlBrMFDpjMn6JLXPQQl()
	{
		return sHg9oeFDyanPQYC0aXv9 == null;
	}
}
