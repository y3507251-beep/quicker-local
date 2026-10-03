using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using HandyControl.Controls;
using Quicker.View.Controls;
using Xceed.Wpf.Toolkit;

namespace Quicker.View;

public class ColorSelectorWindow : HandyControl.Controls.Window, IComponentConnector
{
	[CompilerGenerated]
	private Color? Ofhg4Ei9CSB;

	internal ColorCanvas TheColorCanvas;

	internal ScreenColorPickerControl ColorPickerControl;

	internal Button BtnOk;

	private bool rd9g4ykWmTN;

	internal static ColorSelectorWindow f5Uk9OFQFWGAMiOOt4x2;

	public Color? SelectedColor
	{
		[CompilerGenerated]
		get
		{
			return Ofhg4Ei9CSB;
		}
		[CompilerGenerated]
		private set
		{
			Ofhg4Ei9CSB = value;
		}
	}

	public ColorSelectorWindow(Color? preselectColor)
	{
		InitializeComponent();
		TheColorCanvas.SelectedColor = preselectColor;
	}

	private void L5Dg4C0xlI1(object sender, RoutedEventArgs e)
	{
		if (TheColorCanvas.SelectedColor.HasValue)
		{
			SelectedColor = TheColorCanvas.SelectedColor;
			Close();
		}
	}

	private void ScreenColorPickerControl_OnValueChanged(object sender, EventArgs e)
	{
		if (ColorPickerControl.Color.HasValue)
		{
			TheColorCanvas.SelectedColor = Color.FromRgb(ColorPickerControl.Color.Value.R, ColorPickerControl.Color.Value.G, ColorPickerControl.Color.Value.B);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!rd9g4ykWmTN)
		{
			rd9g4ykWmTN = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/colors/colorselectorwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			rd9g4ykWmTN = true;
			break;
		case 1:
			TheColorCanvas = (ColorCanvas)target;
			break;
		case 2:
			ColorPickerControl = (ScreenColorPickerControl)target;
			break;
		case 3:
			BtnOk = (Button)target;
			BtnOk.Click += L5Dg4C0xlI1;
			break;
		}
	}

	internal static bool gWAWW5FQcH5Jf3lP0SQQ()
	{
		return f5Uk9OFQFWGAMiOOt4x2 == null;
	}
}
