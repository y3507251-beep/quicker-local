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
using Quicker.Domain;
using Quicker.Utilities;
using Quicker.Utilities.UI;
using Quicker.Utilities.UI.Wpf;
using Quicker.View;
using Quicker.View.ProfileManagement;

namespace Quicker.Modules.TextTools.Tools;

public class ProfileExeSelectWindow : Window, IComponentConnector, IMockModalWindow
{
	[CompilerGenerated]
	private string CvEtS6P5STo;

	[CompilerGenerated]
	private bool? zJ4tSXF73e3;

	internal ExeListControl ExeList;

	internal Button BtnOk;

	internal Button BtnCancel;

	private bool zTRtSmiGaHt;

	internal static ProfileExeSelectWindow G1tqiMQpZUlfGPbkowbZ;

	public string SelectedExe
	{
		[CompilerGenerated]
		get
		{
			return CvEtS6P5STo;
		}
		[CompilerGenerated]
		set
		{
			CvEtS6P5STo = value;
		}
	}

	public bool? Result
	{
		[CompilerGenerated]
		get
		{
			return zJ4tSXF73e3;
		}
		[CompilerGenerated]
		set
		{
			zJ4tSXF73e3 = value;
		}
	}

	public ProfileExeSelectWindow(string exe)
	{
		SelectedExe = exe;
		InitializeComponent();
		base.Loaded += KCZtSskEUjO;
		ExeList.Init(AppState.DataService, exe, AppState.AppServer, AppState.B2BtasP38AU());
		ExeList.SetSelectionMode();
	}

	private void KCZtSskEUjO(object sender, RoutedEventArgs e)
	{
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (!AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return new FakeWindowsPeer(this);
		}
		return base.OnCreateAutomationPeer();
	}

	private void smatSHaeuGC(object sender, RoutedEventArgs e)
	{
		EqgtS16BB4O();
	}

	private void EqgtS16BB4O()
	{
		ExeInfo selectedExe = ExeList.GetSelectedExe();
		if (selectedExe != null)
		{
			SelectedExe = selectedExe.Exe;
			this.ThNvuM5Q9GQ(true);
		}
		else
		{
			AppHelper.ShowWarning("尚未选择场景。");
		}
	}

	private void y8LtSbF71Rq(object sender, RoutedEventArgs e)
	{
		Close();
	}

	private void ExeList_ItemDoubleClicked(object sender, ExeChangedEventArgs e)
	{
		EqgtS16BB4O();
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!zTRtSmiGaHt)
		{
			zTRtSmiGaHt = true;
			Uri resourceLocator = new Uri("/Quicker;component/modules/texttools/tools/profileexeselectwindow.xaml", UriKind.Relative);
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
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			zTRtSmiGaHt = true;
			break;
		case 1:
			ExeList = (ExeListControl)target;
			break;
		case 2:
			BtnOk = (Button)target;
			BtnOk.Click += smatSHaeuGC;
			break;
		case 3:
			BtnCancel = (Button)target;
			BtnCancel.Click += y8LtSbF71Rq;
			break;
		}
	}

	internal static bool zqfaTDQp5XI1qJkPi3Lv()
	{
		return G1tqiMQpZUlfGPbkowbZ == null;
	}
}
