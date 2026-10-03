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
using System.Windows.Markup;
using HandyControl.Controls;
using Quicker.Domain;
using Quicker.Domain.Entities;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;
using Quicker.View.Controls;

namespace Quicker.View.ProfileManagement;

public class EditExeSettingsWindow : System.Windows.Window, IComponentConnector
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass26_0
	{
		public WindowSelectedEventArgs LmuSnqxw6L7;

		public EditExeSettingsWindow syoSnc8SCS7;

		internal static _003C_003Ec__DisplayClass26_0 AjvBnXW6wA2A15jGA6Es;

		internal void cYRSnRFwyh8()
		{
			try
			{
				Process process = LmuSnqxw6L7.Process;
				object obj;
				if (process == null)
				{
					obj = null;
				}
				else
				{
					ProcessModule mainModule = process.MainModule;
					if (mainModule == null)
					{
						obj = null;
					}
					else
					{
						obj = mainModule.ModuleName;
						if (obj != null)
						{
							goto IL_0042;
						}
					}
				}
				obj = LmuSnqxw6L7.ProcessName.ToLower() + ".exe";
				goto IL_0042;
				IL_0042:
				string exeOrProcessName = (string)obj;
				UIHelper.AddExeOrProcess(syoSnc8SCS7.TxtAliasExeList, exeOrProcessName, LmuSnqxw6L7.HWnd);
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning(ex.Message);
			}
		}

		internal static bool oIvfloW6TlprJTBpPoJF()
		{
			return AjvBnXW6wA2A15jGA6Es == null;
		}
	}

	private readonly ExeSettings SrQLNnxqyvU;

	[CompilerGenerated]
	private string b6XLN4naZ3F;

	[CompilerGenerated]
	private string O6bLN5drpgC;

	[CompilerGenerated]
	private IList<string> uC7LNDFNtLc;

	[CompilerGenerated]
	private string yKGLNd2S5oI;

	[CompilerGenerated]
	private string lZ3LNoFSFXf;

	internal TextBlock LblExeFile;

	internal TextBlock LblPathLabel;

	internal StackPanel PnlPath;

	internal TextBlock LblPath;

	internal Button BtnChangePathAndIcon;

	internal System.Windows.Controls.TextBox TxtExeName;

	internal TextBlock LblRelatedSoftware;

	internal StackPanel PnlRelatedSoftware;

	internal HandyControl.Controls.TextBox TxtAliasExeList;

	internal TextBlock LblUrlPattern;

	internal StackPanel PnlUrlPattern;

	internal System.Windows.Controls.TextBox TxtUrlPattern;

	internal TextBlock LblCustomIcon;

	internal StackPanel PnlCustomIcon;

	internal System.Windows.Controls.TextBox TxtIcon;

	private bool n8BLNT3oljj;

	internal static EditExeSettingsWindow AALtM5FDAWnlcHNIOELF;

	public string ExeName
	{
		[CompilerGenerated]
		get
		{
			return b6XLN4naZ3F;
		}
		[CompilerGenerated]
		set
		{
			b6XLN4naZ3F = value;
		}
	}

	public string Path
	{
		[CompilerGenerated]
		get
		{
			return O6bLN5drpgC;
		}
		[CompilerGenerated]
		set
		{
			O6bLN5drpgC = value;
		}
	}

	public IList<string> AliasExeList
	{
		[CompilerGenerated]
		get
		{
			return uC7LNDFNtLc;
		}
		[CompilerGenerated]
		set
		{
			uC7LNDFNtLc = value;
		}
	}

	public string UrlPattern
	{
		[CompilerGenerated]
		get
		{
			return yKGLNd2S5oI;
		}
		[CompilerGenerated]
		set
		{
			yKGLNd2S5oI = value;
		}
	}

	public string IconUrl
	{
		[CompilerGenerated]
		get
		{
			return lZ3LNoFSFXf;
		}
		[CompilerGenerated]
		set
		{
			lZ3LNoFSFXf = value;
		}
	}

	public EditExeSettingsWindow(ExeSettings exeSettings)
	{
		SrQLNnxqyvU = exeSettings;
		InitializeComponent();
		base.Loaded += IeWLNBJaYnY;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void IeWLNBJaYnY(object sender, RoutedEventArgs e)
	{
		LblExeFile.Text = SrQLNnxqyvU.Exe;
		TxtExeName.Text = SrQLNnxqyvU.Name;
		bool flag = SrQLNnxqyvU.Exe.EndsWith(".exe", StringComparison.OrdinalIgnoreCase);
		PnlPath.Visibility = ((!flag) ? Visibility.Collapsed : Visibility.Visible);
		StackPanel pnlCustomIcon = PnlCustomIcon;
		Visibility visibility = (LblCustomIcon.Visibility = (!flag).ToVisibility());
		pnlCustomIcon.Visibility = visibility;
		LblPath.Text = SrQLNnxqyvU.Path;
		TxtAliasExeList.Text = (SrQLNnxqyvU.AliasExeList.HasData() ? SrQLNnxqyvU.AliasExeList.JoinToString(";") : "");
		TxtUrlPattern.Text = SrQLNnxqyvU.UrlPattern;
		TextBlock lblUrlPattern = LblUrlPattern;
		visibility = (PnlUrlPattern.Visibility = SrQLNnxqyvU.Exe.StartsWith("@_").ToVisibility());
		lblUrlPattern.Visibility = visibility;
		TxtIcon.Text = SrQLNnxqyvU.IconUrl;
		int num = 0;
		if (!H5MJpiFDnvqfjWgViPcW())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
	}

	private void WrELNQ6R4To(object sender, RoutedEventArgs e)
	{
		if (TxtExeName.EnsureNotEmpty("名称"))
		{
			ExeName = TxtExeName.Text;
			Path = LblPath.Text;
			AliasExeList = TxtAliasExeList.Text?.Trim().SplitToList(';', ',', '；');
			UrlPattern = TxtUrlPattern.Text;
			IconUrl = TxtIcon.Text;
			base.DialogResult = true;
		}
	}

	private void kAuLNjZZkrT(object sender, RoutedEventArgs e)
	{
		(bool, string) tuple = AppHelper.ShowSelectFileDialog("*.exe|*.exe", ".exe", LblExeFile.Text, "", "请选择程序路径");
		if (tuple.Item1)
		{
			if (string.Equals(System.IO.Path.GetFileName(tuple.Item2), LblExeFile.Text, StringComparison.OrdinalIgnoreCase))
			{
				LblPath.Text = tuple.Item2;
			}
			else
			{
				AppHelper.ShowWarning("需要选择 " + LblExeFile.Text + " 文件的路径。");
			}
		}
	}

	private void WindowSelector_OnWindowSelected(object sender, WindowSelectedEventArgs e)
	{
		_003C_003Ec__DisplayClass26_0 _003C_003Ec__DisplayClass26_ = new _003C_003Ec__DisplayClass26_0();
		_003C_003Ec__DisplayClass26_.LmuSnqxw6L7 = e;
		_003C_003Ec__DisplayClass26_.syoSnc8SCS7 = this;
		AppHelper.RunAndIgnoreException(_003C_003Ec__DisplayClass26_.cYRSnRFwyh8);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!n8BLNT3oljj)
		{
			n8BLNT3oljj = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/profilemanagement/editexesettingswindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num;
		switch (connectionId)
		{
		default:
			n8BLNT3oljj = true;
			break;
		case 1:
			LblExeFile = (TextBlock)target;
			break;
		case 2:
			LblPathLabel = (TextBlock)target;
			num = 0;
			if (!H5MJpiFDnvqfjWgViPcW())
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_00b1;
		case 3:
			PnlPath = (StackPanel)target;
			break;
		case 4:
			LblPath = (TextBlock)target;
			break;
		case 5:
			BtnChangePathAndIcon = (Button)target;
			num = 0;
			if (AALtM5FDAWnlcHNIOELF != null)
			{
				goto IL_00b1;
			}
			goto IL_00bf;
		case 6:
			TxtExeName = (System.Windows.Controls.TextBox)target;
			break;
		case 7:
			LblRelatedSoftware = (TextBlock)target;
			break;
		case 8:
			PnlRelatedSoftware = (StackPanel)target;
			break;
		case 9:
			TxtAliasExeList = (HandyControl.Controls.TextBox)target;
			break;
		case 10:
			LblUrlPattern = (TextBlock)target;
			break;
		case 11:
			PnlUrlPattern = (StackPanel)target;
			break;
		case 12:
			TxtUrlPattern = (System.Windows.Controls.TextBox)target;
			break;
		case 13:
			LblCustomIcon = (TextBlock)target;
			break;
		case 14:
			PnlCustomIcon = (StackPanel)target;
			break;
		case 15:
			TxtIcon = (System.Windows.Controls.TextBox)target;
			break;
		case 16:
			{
				((Button)target).Click += WrELNQ6R4To;
				break;
			}
			IL_00b1:
			switch (num)
			{
			default:
				return;
			case 1:
				break;
			}
			goto IL_00bf;
			IL_00bf:
			BtnChangePathAndIcon.Click += kAuLNjZZkrT;
			break;
		}
	}

	internal static bool H5MJpiFDnvqfjWgViPcW()
	{
		return AALtM5FDAWnlcHNIOELF == null;
	}
}
