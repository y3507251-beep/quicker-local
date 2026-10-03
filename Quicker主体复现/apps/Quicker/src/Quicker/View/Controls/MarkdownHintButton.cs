using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using MdXaml;
using Quicker.Utilities;

namespace Quicker.View.Controls;

public class MarkdownHintButton : UserControl, IComponentConnector
{
	internal ToggleButton TogglePopupButton;

	internal MarkdownScrollViewer MdViewer;

	private bool L4gLxhD35sk;

	internal static MarkdownHintButton dBY9eRFuxTps6tymmyv8;

	public string MarkDownToolTip
	{
		get
		{
			return MdViewer.Markdown;
		}
		set
		{
			MdViewer.Markdown = value;
		}
	}

	public MarkdownHintButton()
	{
		InitializeComponent();
		AppHelper.AddGoToPageCommandBinding(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!L4gLxhD35sk)
		{
			L4gLxhD35sk = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/controls/markdownhintbutton.xaml", UriKind.Relative);
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
			L4gLxhD35sk = true;
			break;
		case 2:
			MdViewer = (MarkdownScrollViewer)target;
			break;
		case 1:
			TogglePopupButton = (ToggleButton)target;
			break;
		}
	}

	internal static bool yWSWkEFuIj2BcL6rFQmp()
	{
		return dBY9eRFuxTps6tymmyv8 == null;
	}

	internal static void vrmbVtFutm01WuFIEepw()
	{
	}
}
