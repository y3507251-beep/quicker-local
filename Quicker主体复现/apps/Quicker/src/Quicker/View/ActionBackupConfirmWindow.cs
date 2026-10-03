using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Markup;
using Quicker.Domain;
using Quicker.Utilities;
using Quicker.Utilities.UI;

namespace Quicker.View;

public class ActionBackupConfirmWindow : Window, IComponentConnector
{
	public DateTime? LocalBackupExpireTime;

	public DateTime? NetworkBackupExpireTime = DateTime.MinValue;

	internal TextBlock LblComment;

	internal TextBox TxtNote;

	internal TextBlock LblAutoClear;

	internal RadioButton RbLocal31Days;

	internal RadioButton RbLocalLongTime;

	internal RadioButton RbNetNoStore;

	internal RadioButton RbNet7Days;

	internal RadioButton RbNet31Days;

	internal RadioButton RbNetNoDelete;

	internal Button BtnSave;

	internal Button BtnCancel;

	private bool bXSgQ4IZqe7;

	internal static ActionBackupConfirmWindow X1kYuHQzijnVapjdX4Os;

	public string Note
	{
		get
		{
			return TxtNote.Text;
		}
		set
		{
			TxtNote.Text = value;
		}
	}

	public ActionBackupConfirmWindow()
	{
		InitializeComponent();
		base.Loaded += x5mgQQpeC0a;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void x5mgQQpeC0a(object sender, RoutedEventArgs e)
	{
		Activate();
		AppHelper.RunOnUiThread(false, rG1gQniKYjg);
	}

	private void XNdgQjmaCIb(object sender, RoutedEventArgs e)
	{
		if (!TxtNote.EnsureNotEmpty("版本说明"))
		{
			return;
		}
		LocalBackupExpireTime = ((RbLocal31Days.IsChecked == true) ? new DateTime?(DateTime.UtcNow.AddDays(31.0)) : ((DateTime?)null));
		if (RbNetNoStore.IsChecked == true)
		{
			NetworkBackupExpireTime = DateTime.MinValue;
		}
		if (RbNet7Days.IsChecked == true)
		{
			NetworkBackupExpireTime = DateTime.UtcNow.AddDays(7.0);
		}
		if (RbNet31Days.IsChecked == true)
		{
			NetworkBackupExpireTime = DateTime.UtcNow.AddDays(31.0);
		}
		bool? isChecked = RbNetNoDelete.IsChecked;
		int num = 0;
		if (X1kYuHQzijnVapjdX4Os != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (isChecked == true)
		{
			NetworkBackupExpireTime = DateTime.MaxValue;
		}
		base.DialogResult = true;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!bXSgQ4IZqe7)
		{
			bXSgQ4IZqe7 = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/actions/actionbackupconfirmwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			bXSgQ4IZqe7 = true;
			break;
		case 1:
			LblComment = (TextBlock)target;
			break;
		case 2:
			TxtNote = (TextBox)target;
			break;
		case 3:
			LblAutoClear = (TextBlock)target;
			break;
		case 4:
			RbLocal31Days = (RadioButton)target;
			break;
		case 5:
			RbLocalLongTime = (RadioButton)target;
			break;
		case 6:
			RbNetNoStore = (RadioButton)target;
			break;
		case 7:
			RbNet7Days = (RadioButton)target;
			break;
		case 8:
			RbNet31Days = (RadioButton)target;
			break;
		case 9:
			RbNetNoDelete = (RadioButton)target;
			break;
		case 10:
			BtnSave = (Button)target;
			BtnSave.Click += XNdgQjmaCIb;
			break;
		case 11:
			BtnCancel = (Button)target;
			break;
		}
	}

	[CompilerGenerated]
	private void rG1gQniKYjg()
	{
		TxtNote.Focus();
	}

	internal static bool xJt9ADQzlQ6BjDe5KAMB()
	{
		return X1kYuHQzijnVapjdX4Os == null;
	}
}
