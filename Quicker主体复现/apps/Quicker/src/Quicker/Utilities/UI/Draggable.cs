using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Quicker.Utilities.UI;

public static class Draggable
{
	[CompilerGenerated]
	private static class _003C_003EO
	{
		public static MouseButtonEventHandler fXo2JU0fp8V;

		public static MouseButtonEventHandler HZD2JlfR4j0;

		public static MouseEventHandler kmg2Jiuw7ar;
	}

	public static readonly DependencyProperty IsEnabledProperty;

	private static Point N8tvtGbW4Rn;

	private static TranslateTransform aalvts2o05Y;

	private static bool Ri1vtHHlxIw;

	private static object MmUZb1Fs404KKdDemY3s;

	public static bool GetIsEnabled(DependencyObject obj)
	{
		return (bool)obj.GetValue(IsEnabledProperty);
	}

	public static void SetIsEnabled(DependencyObject obj, bool value)
	{
		obj.SetValue(IsEnabledProperty, value);
	}

	private static void YYKvtYLADIR(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
	{
		if (!(dependencyObject_0 is UIElement uIElement))
		{
			return;
		}
		if ((bool)dependencyPropertyChangedEventArgs_0.NewValue)
		{
			uIElement.MouseLeftButtonDown += _003C_003EO.fXo2JU0fp8V ?? (_003C_003EO.fXo2JU0fp8V = tkFvtILXVrZ);
			if (MmUZb1Fs404KKdDemY3s != null)
			{
				switch (0)
				{
				}
			}
			uIElement.MouseLeftButtonUp += _003C_003EO.HZD2JlfR4j0 ?? (_003C_003EO.HZD2JlfR4j0 = Sj7vtWIoR3W);
			uIElement.MouseMove += _003C_003EO.kmg2Jiuw7ar ?? (_003C_003EO.kmg2Jiuw7ar = V0tvtkqv4OG);
		}
		else
		{
			uIElement.MouseLeftButtonDown -= _003C_003EO.fXo2JU0fp8V ?? (_003C_003EO.fXo2JU0fp8V = tkFvtILXVrZ);
			uIElement.MouseLeftButtonUp -= _003C_003EO.HZD2JlfR4j0 ?? (_003C_003EO.HZD2JlfR4j0 = Sj7vtWIoR3W);
			uIElement.MouseMove -= _003C_003EO.kmg2Jiuw7ar ?? (_003C_003EO.kmg2Jiuw7ar = V0tvtkqv4OG);
		}
	}

	private static void tkFvtILXVrZ(object uielement_0Input, MouseButtonEventArgs mouseButtonEventArgs_0)
	{
        UIElement uielement_0 = (UIElement)uielement_0Input;
		if (mouseButtonEventArgs_0.Handled)
		{
			return;
		}
		UIElement uIElement = uielement_0;
		N8tvtGbW4Rn = mouseButtonEventArgs_0.GetPosition(Window.GetWindow(uIElement));
		aalvts2o05Y = (uIElement.RenderTransform as TranslateTransform) ?? new TranslateTransform(0.0, 0.0);
		N8tvtGbW4Rn.X -= aalvts2o05Y.X;
		N8tvtGbW4Rn.Y -= aalvts2o05Y.Y;
		if (nTZ5b1FshVyNu7lyk2AR())
		{
			switch (0)
			{
			}
		}
		Ri1vtHHlxIw = true;
		uIElement.CaptureMouse();
	}

	private static void Sj7vtWIoR3W(object uielement_0Input, MouseButtonEventArgs mouseButtonEventArgs_0)
	{
        UIElement uielement_0 = (UIElement)uielement_0Input;
		uielement_0.ReleaseMouseCapture();
		Ri1vtHHlxIw = false;
	}

	private static void V0tvtkqv4OG(object uielement_0Input, MouseEventArgs mouseEventArgs_0)
	{
        UIElement uielement_0 = (UIElement)uielement_0Input;
		if (!Ri1vtHHlxIw || !mouseEventArgs_0.LeftButton.HasFlag(MouseButtonState.Pressed))
		{
			return;
		}
		UIElement uIElement = uielement_0;
		Point position = mouseEventArgs_0.GetPosition(Window.GetWindow(uIElement));
		if (nTZ5b1FshVyNu7lyk2AR())
		{
			switch (0)
			{
			}
		}
		double x = position.X - N8tvtGbW4Rn.X;
		double y = position.Y - N8tvtGbW4Rn.Y;
		aalvts2o05Y.X = x;
		aalvts2o05Y.Y = y;
		uIElement.RenderTransform = aalvts2o05Y;
	}

	static Draggable()
	{
		IsEnabledProperty = DependencyProperty.RegisterAttached("IsEnabled", typeof(bool), typeof(Draggable), new PropertyMetadata(false, YYKvtYLADIR));
	}

	internal static bool nTZ5b1FshVyNu7lyk2AR()
	{
		return MmUZb1Fs404KKdDemY3s == null;
	}
}
