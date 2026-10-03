using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Markup;

namespace Quicker.View;

public class TestWindow : Window, IComponentConnector
{
	private bool EArgnuSNyNL;

	private static TestWindow T3XwuMFVvOtJtSNW0lv8;

	public TestWindow()
	{
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!EArgnuSNyNL)
		{
			EArgnuSNyNL = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/testwindow.xaml", UriKind.Relative);
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
		EArgnuSNyNL = true;
	}

	internal static bool CjnxWPFVdKd6pfdMNFgb()
	{
		return T3XwuMFVvOtJtSNW0lv8 == null;
	}
}
