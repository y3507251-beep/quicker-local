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
using System.Windows.Navigation;
using Quicker.Common;
using Quicker.Domain;
using Quicker.Domain.Entities;
using Quicker.Domain.Profiles;
using Quicker.Domain.Services;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;
using Quicker.View.Controls;

namespace Quicker.View;

public class NewProfileWindow : Window, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec pevSrhlhmFK;

		public static Func<ActionProfile, bool> vBsSreiFAeQ;

		internal static _003C_003Ec puRiZJWPKElvNFiRod0t;

		static _003C_003Ec()
		{
			pevSrhlhmFK = new _003C_003Ec();
		}

		internal bool tkLSr9V9fH8(ActionProfile p)
		{
			return string.IsNullOrEmpty(p.AliasOfProfile);
		}

		internal static void Hm7vanWPdBYLe0ZCjacX()
		{
		}

		internal static bool fTwniTWPBBc6xiL9bK57()
		{
			return puRiZJWPKElvNFiRod0t == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass17_0
	{
		public int vyCSrY1DitZ;

		private static _003C_003Ec__DisplayClass17_0 rQmNj9WPOiQes1qvRK6L;

		internal static bool BrYEp8WPJy1fsfZTwDdi()
		{
			return rQmNj9WPOiQes1qvRK6L == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass17_1
	{
		public int BbWSrWKmXTn;

		public _003C_003Ec__DisplayClass17_0 iRtSrkP0hJi;

		private static _003C_003Ec__DisplayClass17_1 ol906JWPaQMkEgVbvX8g;

		internal bool KkXSrI4mDQU(ActionItem x)
		{
			if (x.Row == iRtSrkP0hJi.vyCSrY1DitZ)
			{
				return x.Col == BbWSrWKmXTn;
			}
			return false;
		}

		internal static bool a7aI4OWPrDw2JRP0xlFG()
		{
			return ol906JWPaQMkEgVbvX8g == null;
		}
	}

	private readonly DataService jsEg3SyMuri;

	private readonly ProfileManager JxFg32E9V1D;

	private readonly ExeInfo V5Wg3uAlvgZ;

	[CompilerGenerated]
	private ICollection<ActionProfile> JQ0g3NBMqBJ;

	private readonly IDictionary<int, ActionButton> yQ1g3JsvfFf = new Dictionary<int, ActionButton>();

	private IList<ActionItem> E7Lg30ywsdH = new List<ActionItem>();

	private readonly CreateProfileDto meVg3Ct3au0 = new CreateProfileDto();

	internal IconControl TheIconControl;

	internal TextBlock LblExeName;

	internal TextBlock LblExeFile;

	internal TextBox TxtProfileName;

	internal TextBlock LblValidForMachines;

	internal StackPanel PnlValidForMachines;

	internal TextBox TxtValidForMachines;

	internal Button BtnAddCurrentMachine;

	internal RadioButton BtnNoCopy;

	internal RadioButton BtnCopyLocalProfile;

	internal RadioButton BtnUseProfile;

	internal ComboBox LbProfiles;

	internal Canvas ButtonCavas;

	internal Button BtnOk;

	internal StackPanel PnlNoMore;

	private bool i08g3Pt75C0;

	internal static NewProfileWindow CHAiGxFp34RlP45txNqm;

	[SpecialName]
	[CompilerGenerated]
	private ICollection<ActionProfile> nBvg3gDCw3D()
	{
		return JQ0g3NBMqBJ;
	}

	[SpecialName]
	[CompilerGenerated]
	private void FcEg3LSXXEM(ICollection<ActionProfile> value)
	{
		JQ0g3NBMqBJ = value;
	}

	public NewProfileWindow(DataService dataService, ProfileManager profileManager, ExeInfo exeInfo)
	{
		jsEg3SyMuri = dataService;
		JxFg32E9V1D = profileManager;
		V5Wg3uAlvgZ = exeInfo;
		InitializeComponent();
		AppHelper.CreateButtonsOnCanvas(ButtonCavas, 4, 4, false, 72.0, 1.0, yQ1g3JsvfFf, 0.0, mgBg3tjUWKc);
		base.Loaded += joMgiMdGKj9;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	public CreateProfileDto GetData()
	{
		return meVg3Ct3au0;
	}

	private void vW5giTeSrrl(object sender, RoutedEventArgs e)
	{
		ActionButton actionButton = sender as ActionButton;
		if (actionButton.ActionItem != null && BtnCopyLocalProfile.IsChecked == true)
		{
			actionButton.IsSelected = !actionButton.IsSelected;
		}
	}

	private void joMgiMdGKj9(object sender, RoutedEventArgs e)
	{
        ICollectionView defaultView = default;
		FcEg3LSXXEM(JxFg32E9V1D.GetProfiles(true));
		LblValidForMachines.Visibility = Visibility.Collapsed;
		int num = 1;
		if (CHAiGxFp34RlP45txNqm != null)
		{
			goto IL_0150;
		}
		goto IL_0154;
		IL_0040:
		TheIconControl.Icon = V5Wg3uAlvgZ.IconStr;
		LblExeName.Text = V5Wg3uAlvgZ.Name;
		LblExeFile.Text = V5Wg3uAlvgZ.Exe;
		TxtProfileName.Text = V5Wg3uAlvgZ.Name + " #" + (JxFg32E9V1D.GetAllProfilesByExe(V5Wg3uAlvgZ.Exe).Count + 1);
		defaultView = CollectionViewSource.GetDefaultView(nBvg3gDCw3D().Where(_003C_003Ec.vBsSreiFAeQ ?? (_003C_003Ec.vBsSreiFAeQ = _003C_003Ec.pevSrhlhmFK.tkLSr9V9fH8)).ToList());
		defaultView.GroupDescriptions.Add(new PropertyGroupDescription("ExeDisplayName"));
		defaultView.SortDescriptions.Add(new SortDescription("ExeFile", ListSortDirection.Ascending));
		defaultView.SortDescriptions.Add(new SortDescription("ListOrder", ListSortDirection.Ascending));
		num = 0;
		if (CHAiGxFp34RlP45txNqm != null)
		{
			goto IL_0150;
		}
		goto IL_0154;
		IL_0150:
		int num2 = default(int);
		num = num2;
		goto IL_0154;
		IL_0154:
		switch (num)
		{
		case 1:
			break;
		default:
			LbProfiles.ItemsSource = defaultView;
			kiMgiO6xi4n();
			{
				PnlNoMore.Visibility = Visibility.Collapsed;
				BtnOk.IsEnabled = true;
			}
			return;
		}
		PnlValidForMachines.Visibility = Visibility.Collapsed;
		goto IL_0040;
	}

	private void VsWgiAJSg38(object sender, RoutedEventArgs e)
	{
		int num;
		if (!string.IsNullOrEmpty(TxtProfileName.Text))
		{
			meVg3Ct3au0.ProfileName = TxtProfileName.Text;
			meVg3Ct3au0.ExeFile = V5Wg3uAlvgZ.Exe.ToLower();
			meVg3Ct3au0.ExeFilePathName = V5Wg3uAlvgZ.Path;
			meVg3Ct3au0.ListOrder = 10;
			meVg3Ct3au0.AliasOfProfileId = "";
			meVg3Ct3au0.CopyOrMoveFromProfile = null;
			meVg3Ct3au0.CopyOrMoveActions = null;
			meVg3Ct3au0.ValidForMachines = TxtValidForMachines.Text;
			if (BtnNoCopy.IsChecked == true)
			{
				meVg3Ct3au0.AliasOfProfileId = "";
				goto IL_01f3;
			}
			if (BtnCopyLocalProfile.IsChecked == true)
			{
				if (LbProfiles.SelectedItem == null)
				{
					AppHelper.ShowWarning("请选择要复制或移动动作的动作页。");
					return;
				}
				meVg3Ct3au0.AliasOfProfileId = "";
				num = 3;
				if (CHAiGxFp34RlP45txNqm != null)
				{
					goto IL_013c;
				}
				goto IL_018e;
			}
			if (BtnUseProfile.IsChecked == true)
			{
				if (LbProfiles.SelectedItem == null)
				{
					AppHelper.ShowWarning("请选择要链接的动作页。");
					return;
				}
				if (!(LbProfiles.SelectedItem is ActionProfile actionProfile) || actionProfile.IsGlobalProfile())
				{
					AppHelper.ShowWarning("请选择其他动作页。");
					return;
				}
				meVg3Ct3au0.AliasOfProfileId = actionProfile.Id;
			}
			goto IL_027b;
		}
		MessageBoxHelper.Show(this, "名称不能为空！", "Quicker");
		return;
		IL_01f3:
		meVg3Ct3au0.CopyOrMoveFromProfile = null;
		meVg3Ct3au0.CopyOrMoveActions = null;
		goto IL_027b;
		IL_018e:
		IEnumerator<ActionButton> enumerator = default(IEnumerator<ActionButton>);
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 1:
				goto IL_0142;
			default:
				goto end_IL_018e;
			case 2:
				goto IL_01f3;
			}
			meVg3Ct3au0.IsMove = false;
			num = 1;
			if (CHAiGxFp34RlP45txNqm == null)
			{
				continue;
			}
			goto IL_013c;
			IL_0142:
			meVg3Ct3au0.CopyOrMoveFromProfile = LbProfiles.SelectedItem as ActionProfile;
			meVg3Ct3au0.CopyOrMoveActions = new List<ActionItem>();
			enumerator = yQ1g3JsvfFf.Values.GetEnumerator();
			num = 0;
			if (CHAiGxFp34RlP45txNqm == null)
			{
				continue;
			}
			goto IL_013c;
			continue;
			end_IL_018e:
			break;
		}
		try
		{
			while (enumerator.MoveNext())
			{
				ActionButton current = enumerator.Current;
				if (current.ActionItem != null && current.IsSelected)
				{
					meVg3Ct3au0.CopyOrMoveActions.Add(current.ActionItem);
				}
			}
		}
		finally
		{
			enumerator?.Dispose();
		}
		goto IL_027b;
		IL_013c:
		int num2 = default(int);
		num = num2;
		goto IL_018e;
		IL_027b:
		base.DialogResult = true;
	}

	private void kiMgiO6xi4n()
	{
		if (BtnNoCopy.IsChecked == true)
		{
			LbProfiles.IsEnabled = false;
			ButtonCavas.Visibility = Visibility.Collapsed;
		}
		else
		{
			ButtonCavas.Visibility = Visibility.Visible;
			bool? isChecked = BtnCopyLocalProfile.IsChecked;
			if (jb8cI7FpEeu0YQmMcSNv())
			{
				switch (0)
				{
				}
			}
			if (isChecked == true || BtnUseProfile.IsChecked == true)
			{
				LbProfiles.IsEnabled = true;
			}
		}
		DJjgii1TBIU();
	}

	private void XQPgiFVuRx3(IList<ActionItem> ilist_1)
	{
		_003C_003Ec__DisplayClass17_0 _003C_003Ec__DisplayClass17_ = new _003C_003Ec__DisplayClass17_0();
		_003C_003Ec__DisplayClass17_.vyCSrY1DitZ = 0;
		while (_003C_003Ec__DisplayClass17_.vyCSrY1DitZ < 4)
		{
			_003C_003Ec__DisplayClass17_1 _003C_003Ec__DisplayClass17_2 = new _003C_003Ec__DisplayClass17_1();
			_003C_003Ec__DisplayClass17_2.iRtSrkP0hJi = _003C_003Ec__DisplayClass17_;
			_003C_003Ec__DisplayClass17_2.BbWSrWKmXTn = 0;
			while (_003C_003Ec__DisplayClass17_2.BbWSrWKmXTn < 4)
			{
				int buttonIndex = AppHelper.GetButtonIndex(false, _003C_003Ec__DisplayClass17_2.iRtSrkP0hJi.vyCSrY1DitZ, _003C_003Ec__DisplayClass17_2.BbWSrWKmXTn);
				yQ1g3JsvfFf[buttonIndex].SetAction(ilist_1?.FirstOrDefault(_003C_003Ec__DisplayClass17_2.KkXSrI4mDQU));
				yQ1g3JsvfFf[buttonIndex].IsSelected = yQ1g3JsvfFf[buttonIndex].ActionItem != null && BtnCopyLocalProfile.IsChecked == true;
				_003C_003Ec__DisplayClass17_2.BbWSrWKmXTn++;
			}
			_003C_003Ec__DisplayClass17_.vyCSrY1DitZ++;
		}
	}

	private void R7ygiUNc7kr(object sender, RoutedEventArgs e)
	{
		kiMgiO6xi4n();
	}

	private void Cyigil0lyRJ(object sender, SelectionChangedEventArgs e)
	{
		DJjgii1TBIU();
	}

	private void DJjgii1TBIU()
	{
		if (LbProfiles.SelectedItem is ActionProfile actionProfile)
		{
			E7Lg30ywsdH = actionProfile.ActionItems;
			XQPgiFVuRx3(E7Lg30ywsdH);
		}
		else
		{
			E7Lg30ywsdH = new List<ActionItem>();
			XQPgiFVuRx3(E7Lg30ywsdH);
		}
	}

	private void uKAgi3JoBcP(object sender, RequestNavigateEventArgs e)
	{
		AppHelper.TryOpenUrlOrFile(e.Uri.AbsoluteUri);
		e.Handled = true;
	}

	private void IYMgifVYYI4(object sender, RoutedEventArgs e)
	{
		kiMgiO6xi4n();
	}

	private void JHAgizTwWiR(object sender, RoutedEventArgs e)
	{
		if (string.IsNullOrEmpty(TxtValidForMachines.Text))
		{
			TxtValidForMachines.Text = Environment.MachineName;
			return;
		}
		TextBox txtValidForMachines = TxtValidForMachines;
		txtValidForMachines.Text = txtValidForMachines.Text + ";" + Environment.MachineName;
	}

	private void eokg3wD4YrE(object sender, RoutedEventArgs e)
	{
		kiMgiO6xi4n();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!i08g3Pt75C0)
		{
			i08g3Pt75C0 = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/profilemanagement/newprofilewindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num;
		int num2 = default(int);
		switch (connectionId)
		{
		default:
			i08g3Pt75C0 = true;
			break;
		case 1:
			TheIconControl = (IconControl)target;
			break;
		case 2:
			LblExeName = (TextBlock)target;
			break;
		case 3:
			LblExeFile = (TextBlock)target;
			num = 1;
			if (CHAiGxFp34RlP45txNqm != null)
			{
				goto IL_01ac;
			}
			goto IL_01b0;
		case 4:
			TxtProfileName = (TextBox)target;
			break;
		case 5:
			LblValidForMachines = (TextBlock)target;
			break;
		case 6:
			PnlValidForMachines = (StackPanel)target;
			break;
		case 7:
			TxtValidForMachines = (TextBox)target;
			break;
		case 8:
			BtnAddCurrentMachine = (Button)target;
			BtnAddCurrentMachine.Click += JHAgizTwWiR;
			break;
		case 9:
			BtnNoCopy = (RadioButton)target;
			BtnNoCopy.Click += R7ygiUNc7kr;
			break;
		case 10:
			BtnCopyLocalProfile = (RadioButton)target;
			BtnCopyLocalProfile.Click += R7ygiUNc7kr;
			break;
		case 11:
			BtnUseProfile = (RadioButton)target;
			BtnUseProfile.Click += IYMgifVYYI4;
			break;
		case 12:
			LbProfiles = (ComboBox)target;
			LbProfiles.SelectionChanged += Cyigil0lyRJ;
			break;
		case 13:
			ButtonCavas = (Canvas)target;
			break;
		case 14:
			BtnOk = (Button)target;
			BtnOk.Click += VsWgiAJSg38;
			num = 0;
			if (!jb8cI7FpEeu0YQmMcSNv())
			{
				goto IL_01ac;
			}
			goto IL_01b0;
		case 15:
			{
				PnlNoMore = (StackPanel)target;
				break;
			}
			IL_01ac:
			num = num2;
			goto IL_01b0;
			IL_01b0:
			switch (num)
			{
			case 1:
				break;
			}
			break;
		}
	}

	[CompilerGenerated]
	private void mgBg3tjUWKc(ActionButton actionButton_0)
	{
		actionButton_0.PreviewMouseLeftButtonDown += vW5giTeSrrl;
		if (actionButton_0.ActionItem != null)
		{
			actionButton_0.IsSelected = !actionButton_0.IsSelected;
		}
	}

	static NewProfileWindow()
	{
	}

	internal static bool jb8cI7FpEeu0YQmMcSNv()
	{
		return CHAiGxFp34RlP45txNqm == null;
	}

	internal static void WfRa0IFpJ13ZWWV8qyNc()
	{
	}
}
