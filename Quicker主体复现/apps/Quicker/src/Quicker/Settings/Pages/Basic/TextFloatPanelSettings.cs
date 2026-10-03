using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace Quicker.Settings.Pages.Basic;

public class TextFloatPanelSettings : UserControl, IComponentConnector
{
	private bool za5M0aXWFr;

	internal static TextFloatPanelSettings Ijnol64Tw2vvCksuAXn;

	public TextFloatPanelSettings()
	{
		InitializeComponent();
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!za5M0aXWFr)
		{
			za5M0aXWFr = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/basic/textfloatpanelsettings.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		za5M0aXWFr = true;
	}

	internal static bool U1bhxs4mgIGlW88rpPR()
	{
		return Ijnol64Tw2vvCksuAXn == null;
	}
}
