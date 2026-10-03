using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using HandyControl.Controls;
using Quicker.Domain;
using Quicker.Domain.Services;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.UI;
using Quicker.Utilities.Win32;
using Quicker.View.Controls;

namespace Quicker.View;

public class NewExeSettingsWindow : System.Windows.Window, IComponentConnector
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass35_0
	{
		public NewExeSettingsWindow qqMSKKjWQeY;

		public WindowSelectedEventArgs WrKSKxC7wXO;

		private static _003C_003Ec__DisplayClass35_0 gCqlD8W8VWe3QSNXLb74;

		internal void b74SKmmi5D1()
		{
			UIHelper.AddExeOrProcess(qqMSKKjWQeY.TxtAliasExeList, WrKSKxC7wXO.ProcessName.ToLower() + ".exe", IntPtr.Zero);
		}

		internal static void OraHVMW8cXvEnM0LjYeT()
		{
		}

		internal static bool YfvPXwW8QOrSFAQjhvT1()
		{
			return gCqlD8W8VWe3QSNXLb74 == null;
		}
	}

	private readonly DataService I5vgMRXuOK6;

	private readonly string gYSgMq464GV;

	[CompilerGenerated]
	private readonly IList<string> zyZgMcaExEM;

	[CompilerGenerated]
	private string HbagMVD2uPE;

	[CompilerGenerated]
	private string KxIgMZRNgQ4;

	[CompilerGenerated]
	private string LZ3gM9f7b08;

	[CompilerGenerated]
	private bool mi2gMhaAtD3 = true;

	[CompilerGenerated]
	private string InOgMev4aTa;

	[CompilerGenerated]
	private IList<string> yg0gMYUuSxf;

	internal ExeSelectorControl ExeSelectorControl;

	internal TextBlock LblExeNameLabel;

	internal TextBlock LblExeName;

	internal System.Windows.Controls.TextBox TxtName;

	internal TextBlock LblRelatedSoftware;

	internal StackPanel PnlRelatedSoftware;

	internal HandyControl.Controls.TextBox TxtAliasExeList;

	internal TextBlock LblUrlPattern;

	internal StackPanel PnlUrlPattern;

	internal System.Windows.Controls.TextBox TxtUrlPattern;

	internal StackPanel PnlNoMore;

	internal Button BtnSave;

	internal Button BtnClose;

	private bool TYygMIvpjym;

	private static NewExeSettingsWindow xyeSKnFciTgg9OVAjKw0;

	public IList<string> CurrentExeList
	{
		[CompilerGenerated]
		get
		{
			return zyZgMcaExEM;
		}
	}

	public string ExePathName
	{
		[CompilerGenerated]
		get
		{
			return HbagMVD2uPE;
		}
		[CompilerGenerated]
		set
		{
			HbagMVD2uPE = value;
		}
	}

	public string LoweredExeFileName
	{
		[CompilerGenerated]
		get
		{
			return KxIgMZRNgQ4;
		}
		[CompilerGenerated]
		private set
		{
			KxIgMZRNgQ4 = value;
		}
	}

	public string ExeName
	{
		[CompilerGenerated]
		get
		{
			return LZ3gM9f7b08;
		}
		[CompilerGenerated]
		private set
		{
			LZ3gM9f7b08 = value;
		}
	}

	public bool ShowCustomItem
	{
		[CompilerGenerated]
		get
		{
			return mi2gMhaAtD3;
		}
		[CompilerGenerated]
		set
		{
			mi2gMhaAtD3 = value;
		}
	}

	public string UrlPattern
	{
		[CompilerGenerated]
		get
		{
			return InOgMev4aTa;
		}
		[CompilerGenerated]
		set
		{
			InOgMev4aTa = value;
		}
	}

	public IList<string> AliasExeList
	{
		[CompilerGenerated]
		get
		{
			return yg0gMYUuSxf;
		}
		[CompilerGenerated]
		set
		{
			yg0gMYUuSxf = value;
		}
	}

	public NewExeSettingsWindow(IList<string> currentExeList, DataService dataService, string preSelectExePathName = null)
	{
		I5vgMRXuOK6 = dataService;
		gYSgMq464GV = preSelectExePathName;
		InitializeComponent();
		base.Loaded += jlrgMEkT8CB;
		zyZgMcaExEM = currentExeList;
	}

	private void jlrgMEkT8CB(object sender, RoutedEventArgs e)
	{
		ExeSelectorControl.LoadRunningExeList(CurrentExeList, ShowCustomItem);
		if (!string.IsNullOrEmpty(gYSgMq464GV))
		{
			ExeSelectorControl.SelectExe(gYSgMq464GV);
		}
		if (!I5vgMRXuOK6.ructbfXlqnJ())
		{
			BtnSave.IsEnabled = false;
			PnlNoMore.Visibility = Visibility.Visible;
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

	private void peRgMyY3FeJ(object sender, RoutedEventArgs e)
	{
		ExePathName = ExeSelectorControl.SelectedExePathName;
		if (string.IsNullOrEmpty(ExePathName))
		{
			AppHelper.ShowWarning("请选择应用程序！");
			return;
		}
		if (string.IsNullOrEmpty(TxtName.Text))
		{
			AppHelper.ShowWarning("请输入应用名称。");
			return;
		}
		int num;
		if (ExePathName == "CUSTOM")
		{
			num = 1;
			if (!ugcy5HFcl7o5KhCeUhRF())
			{
				goto IL_009b;
			}
			goto IL_009f;
		}
		if (ExePathName == "URL")
		{
			LoweredExeFileName = "@_" + TxtName.Text.Trim().ToLower();
			UrlPattern = TxtUrlPattern.Text;
		}
		else
		{
			LoweredExeFileName = Path.GetFileName(ExeSelectorControl.SelectedExePathName).ToLowerInvariant();
		}
		goto IL_0113;
		IL_0113:
		if (CurrentExeList.Contains(LoweredExeFileName))
		{
			AppHelper.ShowWarning("此应用程序已经设置，请选择其他应用程序。");
			return;
		}
		ExeName = TxtName.Text;
		AliasExeList = TxtAliasExeList.Text?.Trim().SplitToList(';', ',', '；');
		base.DialogResult = true;
		return;
		IL_009b:
		int num2 = default(int);
		num = num2;
		goto IL_009f;
		IL_009f:
		while (true)
		{
			switch (num)
			{
			case 1:
				goto IL_0069;
			}
			break;
			IL_0069:
			LoweredExeFileName = "#_" + TxtName.Text.Trim().ToLower();
			num = 0;
			if (xyeSKnFciTgg9OVAjKw0 == null)
			{
				continue;
			}
			goto IL_009b;
		}
		goto IL_0113;
	}

	private void ExeSelectorControl_OnSelectedExeChanged(object sender, EventArgs e)
	{
		string selectedExePathName = ExeSelectorControl.SelectedExePathName;
		if (string.IsNullOrEmpty(selectedExePathName))
		{
			return;
		}
		LblUrlPattern.Visibility = Visibility.Collapsed;
		PnlUrlPattern.Visibility = Visibility.Collapsed;
		TxtName.IsEnabled = true;
		if (selectedExePathName.IsEither("CUSTOM", "URL"))
		{
			TextBlock lblExeNameLabel = LblExeNameLabel;
			LblExeName.Visibility = Visibility.Collapsed;
			lblExeNameLabel.Visibility = Visibility.Collapsed;
			TextBlock lblRelatedSoftware = LblRelatedSoftware;
			PnlRelatedSoftware.Visibility = Visibility.Collapsed;
			lblRelatedSoftware.Visibility = Visibility.Collapsed;
			goto IL_008a;
		}
		goto IL_019c;
		IL_019c:
		TextBlock lblExeNameLabel2 = LblExeNameLabel;
		LblExeName.Visibility = Visibility.Visible;
		lblExeNameLabel2.Visibility = Visibility.Visible;
		TextBlock lblRelatedSoftware2 = LblRelatedSoftware;
		PnlRelatedSoftware.Visibility = Visibility.Visible;
		lblRelatedSoftware2.Visibility = Visibility.Visible;
		goto IL_008a;
		IL_0182:
		int num;
		string text = default(string);
		while (true)
		{
			switch (num)
			{
			case 1:
				if (CurrentExeList.IndexOf(text) < 0)
				{
					LblExeName.Text = text;
					TxtName.Text = ExeHelper.GetFileDescription(selectedExePathName);
					TxtName.ToolTip = selectedExePathName;
					TxtName.Tag = selectedExePathName;
					if (string.Equals(text, "wps.exe", StringComparison.OrdinalIgnoreCase))
					{
						if (MessageBoxHelper.Show(this, "WPS是多进程应用。您希望WPS的表格、演示使用和文档一样的场景设置么？\n选择 “是” 可自动添加相关程序。", "添加场景", MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes)
						{
							return;
						}
						goto IL_0174;
					}
					IList<string> relatedExes = RelatedExeHelper.GetRelatedExes(text, true);
					if (!relatedExes.HasData() || !AppHelper.Confirm("是否添加此程序的相关程序？\n" + string.Join("\n", relatedExes)))
					{
						return;
					}
					{
						foreach (string item in relatedExes)
						{
							UIHelper.AddExeOrProcess(TxtAliasExeList, item, IntPtr.Zero);
						}
						return;
					}
				}
				AppHelper.ShowWarning("该应用已存在场景设置!");
				return;
			case 3:
				break;
			default:
				UIHelper.AddExeOrProcess(TxtAliasExeList, "et.exe", IntPtr.Zero);
				UIHelper.AddExeOrProcess(TxtAliasExeList, "wpp.exe", IntPtr.Zero);
				UIHelper.AddExeOrProcess(TxtAliasExeList, "wpspdf.exe", IntPtr.Zero);
				return;
			case 2:
				TxtName.Tag = "";
				TxtName.ToolTip = "请输入自定义应用名称";
				return;
			}
			break;
			IL_0174:
			num = 0;
			if (ugcy5HFcl7o5KhCeUhRF())
			{
				continue;
			}
			goto IL_0181;
		}
		goto IL_019c;
		IL_008a:
		if (selectedExePathName == "CUSTOM")
		{
			LblExeName.Text = "";
			TxtName.Text = "";
			num = 2;
			if (xyeSKnFciTgg9OVAjKw0 != null)
			{
				goto IL_0181;
			}
		}
		else
		{
			if (selectedExePathName == "URL")
			{
				LblExeName.Text = "";
				TxtName.Text = "";
				TxtName.Tag = "";
				TxtName.ToolTip = "请输入自定义应用名称";
				LblUrlPattern.Visibility = Visibility.Visible;
				PnlUrlPattern.Visibility = Visibility.Visible;
				return;
			}
			text = Path.GetFileName(selectedExePathName).ToLowerInvariant();
			num = 1;
			if (xyeSKnFciTgg9OVAjKw0 != null)
			{
				goto IL_0181;
			}
		}
		goto IL_0182;
		IL_0181:
		int num2 = default(int);
		num = num2;
		goto IL_0182;
	}

	private void QMygM8xrdMf(object sender, MouseButtonEventArgs e)
	{
		string text = TxtName.Tag as string;
		if (!string.IsNullOrEmpty(text))
		{
			AppHelper.SelectFileInExplorer(text, false);
		}
	}

	private void WindowSelector_OnWindowSelected(object sender, WindowSelectedEventArgs e)
	{
		_003C_003Ec__DisplayClass35_0 _003C_003Ec__DisplayClass35_ = new _003C_003Ec__DisplayClass35_0();
		_003C_003Ec__DisplayClass35_.qqMSKKjWQeY = this;
		_003C_003Ec__DisplayClass35_.WrKSKxC7wXO = e;
		AppHelper.RunAndIgnoreException(_003C_003Ec__DisplayClass35_.b74SKmmi5D1);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!TYygMIvpjym)
		{
			TYygMIvpjym = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/profilemanagement/newexesettingswindow.xaml", UriKind.Relative);
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
			TYygMIvpjym = true;
			break;
		case 2:
			LblExeNameLabel = (TextBlock)target;
			break;
		case 3:
			LblExeName = (TextBlock)target;
			LblExeName.PreviewMouseDown += QMygM8xrdMf;
			break;
		case 4:
			TxtName = (System.Windows.Controls.TextBox)target;
			break;
		case 5:
			LblRelatedSoftware = (TextBlock)target;
			break;
		case 6:
			PnlRelatedSoftware = (StackPanel)target;
			break;
		case 7:
			TxtAliasExeList = (HandyControl.Controls.TextBox)target;
			break;
		case 8:
			LblUrlPattern = (TextBlock)target;
			break;
		case 9:
			PnlUrlPattern = (StackPanel)target;
			break;
		case 10:
			TxtUrlPattern = (System.Windows.Controls.TextBox)target;
			break;
		case 11:
		{
			PnlNoMore = (StackPanel)target;
			int num = 0;
			if (!ugcy5HFcl7o5KhCeUhRF())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				return;
			case 1:
				break;
			}
			goto case 1;
		}
		case 1:
			ExeSelectorControl = (ExeSelectorControl)target;
			break;
		case 12:
			BtnSave = (Button)target;
			BtnSave.Click += peRgMyY3FeJ;
			break;
		case 13:
			BtnClose = (Button)target;
			break;
		}
	}

	internal static bool ugcy5HFcl7o5KhCeUhRF()
	{
		return xyeSKnFciTgg9OVAjKw0 == null;
	}
}
