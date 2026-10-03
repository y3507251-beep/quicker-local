using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;
using HandyControl.Controls;
using Quicker.Common;
using Quicker.Domain;
using Quicker.Domain.Profiles;
using Quicker.Domain.Services;
using Quicker.Utilities.UI;

namespace Quicker.View;

public class EditProfileWindow : System.Windows.Window, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec r5CSK6vY1xJ;

		public static Func<ActionProfile, bool> d5rSKXoFgga;

		private static _003C_003Ec IwXc6VWYhqUGOQmtlkh1;

		static _003C_003Ec()
		{
			r5CSK6vY1xJ = new _003C_003Ec();
		}

		internal bool n52SKbVPsPZ(ActionProfile p)
		{
			return string.IsNullOrEmpty(p.AliasOfProfile);
		}

		internal static bool v8A2ccWYHGG5SA2RaGJu()
		{
			return IwXc6VWYhqUGOQmtlkh1 == null;
		}
	}

	private readonly ActionProfile I8sgMJun69g;

	private readonly ProfileManager PLSgM0FWKXa;

	private readonly DataService RhPgMCQ6hoI;

	internal TextBlock LblExe;

	internal HandyControl.Controls.TextBox TxtProfileName;

	internal TextBlock LblValidForMachines;

	internal StackPanel PnlValidForMachines;

	internal System.Windows.Controls.TextBox TxtValidForMachines;

	internal Button BtnAddCurrentMachine;

	internal Label LblAliasOfProfile;

	internal System.Windows.Controls.ComboBox LbProfiles;

	private bool WnvgMPLbqrr;

	private static EditProfileWindow RBUVAoFcrpRk4j44eJq3;

	public string ProfileName => TxtProfileName.Text;

	public string ValidForMachines => TxtValidForMachines.Text;

	public string AliasOfProfile
	{
		get
		{
			if (!string.IsNullOrEmpty(I8sgMJun69g.AliasOfProfile))
			{
				return (LbProfiles.SelectedItem as ActionProfile)?.Id;
			}
			return string.Empty;
		}
	}

	public EditProfileWindow(ActionProfile profile, DataService dataService, ProfileManager profileManager)
	{
		I8sgMJun69g = profile;
		RhPgMCQ6hoI = dataService;
		PLSgM0FWKXa = profileManager;
		InitializeComponent();
		base.Loaded += JS5gMSJjtu7;
	}

	private void JS5gMSJjtu7(object sender, RoutedEventArgs e)
	{
		LblExe.Text = I8sgMJun69g.ExeDisplayName;
		TxtProfileName.Text = I8sgMJun69g.Name;
		TxtValidForMachines.Text = I8sgMJun69g.Settings.ValidForMachines;
		if (RhPgMCQ6hoI.phyt6wLqU0M() == 1 && string.IsNullOrEmpty(I8sgMJun69g.Settings.ValidForMachines))
		{
			LblValidForMachines.Visibility = Visibility.Collapsed;
			PnlValidForMachines.Visibility = Visibility.Collapsed;
		}
		if (!string.IsNullOrEmpty(I8sgMJun69g.AliasOfProfile))
		{
			List<ActionProfile> source = PLSgM0FWKXa.GetProfiles(false).Where(_003C_003Ec.d5rSKXoFgga ?? (_003C_003Ec.d5rSKXoFgga = _003C_003Ec.r5CSK6vY1xJ.n52SKbVPsPZ)).ToList();
			ICollectionView defaultView = CollectionViewSource.GetDefaultView(source);
			defaultView.GroupDescriptions.Add(new PropertyGroupDescription("ExeDisplayName"));
			defaultView.SortDescriptions.Add(new SortDescription("ExeFile", ListSortDirection.Ascending));
			defaultView.SortDescriptions.Add(new SortDescription("ListOrder", ListSortDirection.Ascending));
			LbProfiles.ItemsSource = defaultView;
			LbProfiles.SelectedItem = source.FirstOrDefault(FvOgMNXC4xd);
			LblAliasOfProfile.Visibility = Visibility.Visible;
			int num = 0;
			if (RBUVAoFcrpRk4j44eJq3 != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			LbProfiles.Visibility = Visibility.Visible;
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

	private void E25gM2cmVN8(object sender, RoutedEventArgs e)
	{
		base.DialogResult = true;
	}

	private void VbYgMuDLM8B(object sender, RoutedEventArgs e)
	{
		if (string.IsNullOrEmpty(TxtValidForMachines.Text))
		{
			TxtValidForMachines.Text = Environment.MachineName;
			return;
		}
		System.Windows.Controls.TextBox txtValidForMachines = TxtValidForMachines;
		txtValidForMachines.Text = txtValidForMachines.Text + ";" + Environment.MachineName;
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!WnvgMPLbqrr)
		{
			WnvgMPLbqrr = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/profilemanagement/editprofilewindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			WnvgMPLbqrr = true;
			break;
		case 1:
			LblExe = (TextBlock)target;
			break;
		case 2:
			TxtProfileName = (HandyControl.Controls.TextBox)target;
			break;
		case 3:
		{
			LblValidForMachines = (TextBlock)target;
			int num = 0;
			if (RBUVAoFcrpRk4j44eJq3 != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			break;
		}
		case 4:
			PnlValidForMachines = (StackPanel)target;
			break;
		case 5:
			TxtValidForMachines = (System.Windows.Controls.TextBox)target;
			break;
		case 6:
			BtnAddCurrentMachine = (Button)target;
			BtnAddCurrentMachine.Click += VbYgMuDLM8B;
			break;
		case 7:
			LblAliasOfProfile = (Label)target;
			break;
		case 8:
			LbProfiles = (System.Windows.Controls.ComboBox)target;
			break;
		case 9:
			((Button)target).Click += E25gM2cmVN8;
			break;
		}
	}

	[CompilerGenerated]
	private bool FvOgMNXC4xd(ActionProfile actionProfile_1)
	{
		return actionProfile_1.Id == I8sgMJun69g.AliasOfProfile;
	}

	internal static bool hgpMTaFcNMW5Xo7ha9XW()
	{
		return RBUVAoFcrpRk4j44eJq3 == null;
	}
}
