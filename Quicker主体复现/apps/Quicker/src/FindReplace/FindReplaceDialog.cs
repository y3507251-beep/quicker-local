using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using log4net;
using Quicker.Utilities;

namespace FindReplace;

public class FindReplaceDialog : Window, IComponentConnector
{
	private static readonly ILog DFMSaboHSs;

	private FindReplaceMgr alsS7WKEN3;

	internal TabControl tabMain;

	internal TabItem tabFind;

	internal TextBox txtFind;

	internal TabItem tabReplace;

	internal TextBox txtFind2;

	internal TextBox txtReplace;

	private bool LpwSRct7wN;

	private static FindReplaceDialog touJ0620WHTb1jtkPtc;

	public FindReplaceDialog(FindReplaceMgr theVM)
	{
		base.DataContext = (alsS7WKEN3 = theVM);
		InitializeComponent();
	}

	private void GYaS2CHDQX(object sender, RoutedEventArgs e)
	{
		fQeS06259R(klnSPKMuGE);
	}

	private void rhPSu0PfO4(object sender, RoutedEventArgs e)
	{
		fQeS06259R(f2qSEVLmKA);
	}

	private void rQiSN0XmRT(object sender, RoutedEventArgs e)
	{
		fQeS06259R(yHkSy6PaRS);
	}

	private void jpwSJPdY9L(object sender, RoutedEventArgs e)
	{
		fQeS06259R(hwES8jhurM);
	}

	private void fQeS06259R(Action action_0)
	{
		try
		{
			action_0();
		}
		catch (Exception ex)
		{
			string message = "遇到了一个错误！" + ex.Message;
			DFMSaboHSs.Warn(message, ex);
			AppHelper.ShowWarning(message, true);
		}
	}

	private void DAGSCMw0XK(object sender, KeyEventArgs e)
	{
		if (e.Key == Key.Escape)
		{
			Close();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!LpwSRct7wN)
		{
			LpwSRct7wN = true;
			Uri resourceLocator = new Uri("/Quicker;component/utilities/3rd/findreplace/findreplacedialog.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			LpwSRct7wN = true;
			break;
		case 1:
			((FindReplaceDialog)target).KeyDown += DAGSCMw0XK;
			break;
		case 2:
			tabMain = (TabControl)target;
			break;
		case 3:
			tabFind = (TabItem)target;
			break;
		case 4:
			txtFind = (TextBox)target;
			break;
		case 5:
			((Button)target).Click += rhPSu0PfO4;
			break;
		case 6:
			((Button)target).Click += GYaS2CHDQX;
			break;
		case 7:
			tabReplace = (TabItem)target;
			break;
		case 8:
			txtFind2 = (TextBox)target;
			break;
		case 9:
			txtReplace = (TextBox)target;
			break;
		case 10:
		{
			((Button)target).Click += rhPSu0PfO4;
			int num = 0;
			if (touJ0620WHTb1jtkPtc != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			break;
		}
		case 11:
			((Button)target).Click += rQiSN0XmRT;
			break;
		case 12:
			((Button)target).Click += jpwSJPdY9L;
			break;
		}
	}

	static FindReplaceDialog()
	{
		DFMSaboHSs = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	[CompilerGenerated]
	private void klnSPKMuGE()
	{
		alsS7WKEN3.FindPrevious();
	}

	[CompilerGenerated]
	private void f2qSEVLmKA()
	{
		alsS7WKEN3.FindNext(false);
	}

	[CompilerGenerated]
	private void yHkSy6PaRS()
	{
		alsS7WKEN3.Replace();
	}

	[CompilerGenerated]
	private void hwES8jhurM()
	{
		alsS7WKEN3.ReplaceAll(false);
	}

	internal static bool xTWwaE21lWSOofW6ikt()
	{
		return touJ0620WHTb1jtkPtc == null;
	}
}
