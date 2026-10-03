using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Markup;
using GuvA3OiyFyyWpKJlb8c;
using JTIh7V5l65QV75A93Ly;
using Quicker.Common.Entities;
using Quicker.Domain;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;

namespace Quicker.View.UI;

public class MenuItemEditor : Window, IComponentConnector
{
	[CompilerGenerated]
	private SimpleOperationItem aMnLCCuvvF7;

	internal TextBox TxtTitle;

	internal TextBox TxtIcon;

	internal Button BtnImgIcon;

	internal Button BtnFaIcon;

	internal TextBox TxtTooltip;

	internal TextBox TxtValue;

	internal CheckBox ChkContinue;

	internal Button BtnOk;

	internal Button BtnCancel;

	private bool L0vLCPOgmL0;

	internal static MenuItemEditor AXpkh1FEWtcCseJwQhVH;

	public SimpleOperationItem ResultItem
	{
		[CompilerGenerated]
		get
		{
			return aMnLCCuvvF7;
		}
		[CompilerGenerated]
		set
		{
			aMnLCCuvvF7 = value;
		}
	}

	public bool ContinueAdd
	{
		get
		{
			return ChkContinue.IsChecked == true;
		}
		set
		{
			ChkContinue.IsChecked = value;
		}
	}

	public MenuItemEditor(SimpleOperationItem item)
	{
		InitializeComponent();
		if (item != null)
		{
			TxtIcon.Text = item.Icon;
			TxtTitle.Text = item.Name;
			TxtTooltip.Text = item.Description;
			TxtValue.Text = item.Key;
		}
		ChkContinue.Visibility = (item == null).ToVisibility();
		base.Loaded += QlqLC2PmhKM;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void QlqLC2PmhKM(object sender, RoutedEventArgs e)
	{
		this.aJDvuAkk8hZ();
	}

	private void XFrLCuRFMKa(object sender, RoutedEventArgs e)
	{
		if (string.IsNullOrEmpty(TxtTitle.Text) && string.IsNullOrEmpty(TxtIcon.Text))
		{
			AppHelper.ShowWarning("请输入标题或图标。");
			return;
		}
		ResultItem = new SimpleOperationItem
		{
			Icon = TxtIcon.Text,
			Name = TxtTitle.Text,
			Description = TxtTooltip.Text,
			Key = TxtValue.Text
		};
		base.DialogResult = true;
	}

	private void wp9LCNAyWgl(object sender, RoutedEventArgs e)
	{
		base.DialogResult = false;
	}

	private void l48LCJ0e855(object sender, RoutedEventArgs e)
	{
		IconSelectorWindow iconSelectorWindow = new IconSelectorWindow();
		iconSelectorWindow.Owner = Window.GetWindow(this);
		if (iconSelectorWindow.ShowDialog() == true)
		{
			TxtIcon.Text = "url:" + iconSelectorWindow.SelectedIconUrl;
		}
	}

	private void kf5LC05fdbG(object sender, RoutedEventArgs e)
	{
		FaIconSelectorWindow faIconSelectorWindow = new FaIconSelectorWindow();
		faIconSelectorWindow.Owner = Window.GetWindow(this);
		bool flag = true;
		string text = FMP9ONqzXcgZ6r3WmZZ.A4qHeQImJ6().DefaultIconColor;
		if (!string.IsNullOrEmpty(TxtIcon.Text) && TxtIcon.Text.StartsWith("fa:", StringComparison.OrdinalIgnoreCase) && TxtIcon.Text.Contains(":#"))
		{
			text = TxtIcon.Text.Split(':')[2];
			flag = false;
			int num = 0;
			if (!wEWCEcFEyUyfkx7Ic2E8())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		faIconSelectorWindow.IconColor = text;
		UiSettings uiSettings = FMP9ONqzXcgZ6r3WmZZ.A4qHeQImJ6();
		faIconSelectorWindow.PanelColor = uiSettings.BackgroundColor;
		faIconSelectorWindow.ButtonColor = uiSettings.ButtonBgColor;
		faIconSelectorWindow.LabelColor = uiSettings.LabelColor;
		if (faIconSelectorWindow.ShowDialog() == true)
		{
			TxtIcon.Text = "fa:" + faIconSelectorWindow.SelectedIcon.ToString() + ((!flag) ? (":" + text) : "");
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!L0vLCPOgmL0)
		{
			L0vLCPOgmL0 = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/ui/menuitemeditor.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		while (true)
		{
			switch (connectionId)
			{
			case 1:
				TxtTitle = (TextBox)target;
				return;
			case 2:
				TxtIcon = (TextBox)target;
				return;
			case 3:
				BtnImgIcon = (Button)target;
				BtnImgIcon.Click += l48LCJ0e855;
				return;
			case 4:
				BtnFaIcon = (Button)target;
				BtnFaIcon.Click += kf5LC05fdbG;
				return;
			case 5:
				TxtTooltip = (TextBox)target;
				return;
			case 6:
				TxtValue = (TextBox)target;
				return;
			case 7:
				ChkContinue = (CheckBox)target;
				return;
			case 8:
				BtnOk = (Button)target;
				BtnOk.Click += XFrLCuRFMKa;
				return;
			case 9:
				BtnCancel = (Button)target;
				BtnCancel.Click += wp9LCNAyWgl;
				return;
			}
			if (!wEWCEcFEyUyfkx7Ic2E8())
			{
				switch (0)
				{
				case 1:
					continue;
				}
			}
			L0vLCPOgmL0 = true;
			return;
		}
	}

	internal static bool wEWCEcFEyUyfkx7Ic2E8()
	{
		return AXpkh1FEWtcCseJwQhVH == null;
	}
}
