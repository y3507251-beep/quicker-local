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
using System.Windows.Markup;
using Quicker.Domain;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.SubPrograms;
using Quicker.Utilities;
using Quicker.Utilities.UI;

namespace Quicker.View.X;

public class SubProgramEditWindow : Window, IComponentConnector
{
	private readonly SubProgram nk4LG81VSeO;

	private readonly IEnumerable<SubProgram> YRLLGabIfTn;

	internal TextBox TxtName;

	internal TextBox TxtNote;

	internal Button BtnOk;

	internal Button BtnCancel;

	private bool myILG7RZZDi;

	internal static SubProgramEditWindow CywrtuFk5EEQNh3KABk7;

	public string SubProgramName => TxtName.Text.Trim();

	public string SubProgramDesc => TxtNote.Text;

	public SubProgramEditWindow(SubProgram subProgram, IEnumerable<SubProgram> existingSubPrograms)
	{
		nk4LG81VSeO = subProgram;
		YRLLGabIfTn = existingSubPrograms;
		InitializeComponent();
		if (subProgram != null)
		{
			TxtName.Text = subProgram.Name;
			TxtNote.Text = subProgram.Description;
		}
		base.Loaded += vpGLGPUX6pV;
	}

	private void xkyLG0y8jIW(object sender, RoutedEventArgs e)
	{
		if (!TxtName.EnsureNotEmpty("名称"))
		{
			return;
		}
		if (nk4LG81VSeO == null && YRLLGabIfTn != null && YRLLGabIfTn.Any(afbLGyv92oH))
		{
			AppHelper.ShowWarning("已有同名子程序，请更换一个名称。");
		}
		else if ((nk4LG81VSeO == null || nk4LG81VSeO.Name != SubProgramName) && !SubProgramHelper.IsValidSubProgramName(SubProgramName))
		{
			AppHelper.ShowWarning("子程序名称中不能包含特殊字符或空格。", true);
			if (I9JV1yFkYEfAgHSTCSnp())
			{
				switch (0)
				{
				}
			}
		}
		else
		{
			base.DialogResult = true;
		}
	}

	private void M98LGCvZMkO(object sender, RoutedEventArgs e)
	{
		base.DialogResult = false;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!myILG7RZZDi)
		{
			myILG7RZZDi = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/x/subprogrameditwindow.xaml", UriKind.Relative);
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
			myILG7RZZDi = true;
			break;
		case 1:
			TxtName = (TextBox)target;
			break;
		case 2:
			TxtNote = (TextBox)target;
			break;
		case 3:
			BtnOk = (Button)target;
			BtnOk.Click += xkyLG0y8jIW;
			break;
		case 4:
			BtnCancel = (Button)target;
			if (I9JV1yFkYEfAgHSTCSnp())
			{
				switch (0)
				{
				}
			}
			BtnCancel.Click += M98LGCvZMkO;
			break;
		}
	}

	[CompilerGenerated]
	private void vpGLGPUX6pV(object sender, RoutedEventArgs e)
	{
		base.Dispatcher.InvokeAsync(dMULGEStgva);
	}

	[CompilerGenerated]
	private void dMULGEStgva()
	{
		TxtName.Focus();
	}

	[CompilerGenerated]
	private bool afbLGyv92oH(SubProgram subProgram_1)
	{
		return string.Equals(SubProgramName, subProgram_1.Name, StringComparison.OrdinalIgnoreCase);
	}

	internal static bool I9JV1yFkYEfAgHSTCSnp()
	{
		return CywrtuFk5EEQNh3KABk7 == null;
	}
}
