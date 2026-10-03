using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;

namespace Quicker.View.UI;

public class GoToLineUserControl : Border, IComponentConnector
{
	internal TextBox TxtLineNumber;

	internal Button BtnEnter;

	internal Button BtnCancel;

	private bool zqrL0UngVZy;

	internal static GoToLineUserControl eYYJ1hF3S81UxZ5O1kAJ;

	public GoToLineUserControl()
	{
		InitializeComponent();
		base.Loaded += EsHL0OyFO0i;
	}

	private void EsHL0OyFO0i(object sender, RoutedEventArgs e)
	{
		TxtLineNumber.Focus();
		TxtLineNumber.SelectAll();
	}

	private void pZKL0FFX5Oo(object sender, KeyEventArgs e)
	{
		if (e.Key == Key.Return)
		{
			BtnEnter.Command?.Execute(null);
		}
		else if (e.Key == Key.Escape)
		{
			BtnCancel.Command?.Execute(null);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!zqrL0UngVZy)
		{
			zqrL0UngVZy = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/ui/gotolineusercontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			zqrL0UngVZy = true;
			break;
		case 1:
			TxtLineNumber = (TextBox)target;
			TxtLineNumber.PreviewKeyDown += pZKL0FFX5Oo;
			break;
		case 2:
			BtnEnter = (Button)target;
			break;
		case 3:
			BtnCancel = (Button)target;
			break;
		}
	}

	internal static bool Och6CyF3w7YovvxLWhC8()
	{
		return eYYJ1hF3S81UxZ5O1kAJ == null;
	}
}
