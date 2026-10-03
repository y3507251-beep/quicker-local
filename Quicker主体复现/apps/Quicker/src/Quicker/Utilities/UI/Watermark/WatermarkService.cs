using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Input;
using IeliWVi9GQPYQVRofrZ;

namespace Quicker.Utilities.UI.Watermark;

public static class WatermarkService
{
	[CompilerGenerated]
	private static class _003C_003EO
	{
		public static RoutedEventHandler Cq82yPQeVeU;

		public static KeyboardFocusChangedEventHandler DPE2yENyXsq;

		public static KeyboardFocusChangedEventHandler iSa2yyTQvSh;

		public static TextChangedEventHandler QOe2y8lef0i;

		public static ItemsChangedEventHandler Qsb2ya7FSlH;

		public static EventHandler jEG2y7Qyq2e;
	}

	public static readonly DependencyProperty WatermarkProperty;

	private static readonly Dictionary<object, ItemsControl> BMsvu73ijtN;

	private static object l1qGPGFzgTVW89PEHolD;

	public static object GetWatermark(DependencyObject d)
	{
		return d.GetValue(WatermarkProperty);
	}

	public static void SetWatermark(DependencyObject d, object value)
	{
		d.SetValue(WatermarkProperty, value);
	}

	private static void Bq8vuJ1TOjW(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
	{
		Control control = (Control)dependencyObject_0;
		control.Loaded += _003C_003EO.Cq82yPQeVeU ?? (_003C_003EO.Cq82yPQeVeU = ShYvuCRC9l1);
		if (dependencyObject_0 is ComboBox)
		{
			int num = 0;
			if (l1qGPGFzgTVW89PEHolD != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			control.GotKeyboardFocus += _003C_003EO.DPE2yENyXsq ?? (_003C_003EO.DPE2yENyXsq = wE2vu0jp5tU);
			control.LostKeyboardFocus += _003C_003EO.iSa2yyTQvSh ?? (_003C_003EO.iSa2yyTQvSh = ShYvuCRC9l1);
		}
		else if (dependencyObject_0 is TextBox)
		{
			control.GotKeyboardFocus += _003C_003EO.DPE2yENyXsq ?? (_003C_003EO.DPE2yENyXsq = wE2vu0jp5tU);
			control.LostKeyboardFocus += _003C_003EO.iSa2yyTQvSh ?? (_003C_003EO.iSa2yyTQvSh = ShYvuCRC9l1);
			((TextBox)control).TextChanged += _003C_003EO.QOe2y8lef0i ?? (_003C_003EO.QOe2y8lef0i = wE2vu0jp5tU);
		}
		if (dependencyObject_0 is ItemsControl && !(dependencyObject_0 is ComboBox))
		{
			ItemsControl itemsControl = (ItemsControl)dependencyObject_0;
			itemsControl.ItemContainerGenerator.ItemsChanged += _003C_003EO.Qsb2ya7FSlH ?? (_003C_003EO.Qsb2ya7FSlH = SxxvuEWg124);
			BMsvu73ijtN.Add(itemsControl.ItemContainerGenerator, itemsControl);
			DependencyPropertyDescriptor.FromProperty(ItemsControl.ItemsSourceProperty, itemsControl.GetType()).AddValueChanged(itemsControl, _003C_003EO.jEG2y7Qyq2e ?? (_003C_003EO.jEG2y7Qyq2e = RngvuPxRy2q));
		}
	}

	private static void wE2vu0jp5tU(object control_0Input, RoutedEventArgs routedEventArgs_0)
	{
        Control control_0 = (Control)control_0Input;
		Control control = control_0;
		if (mp4vuabRKQU(control))
		{
			HWGvu8B9VD5(control);
		}
		else
		{
			ugNvuyeYsjf(control);
		}
	}

	private static void ShYvuCRC9l1(object control_0Input, RoutedEventArgs routedEventArgs_0)
	{
        Control control_0 = (Control)control_0Input;
		Control control_1 = control_0;
		if (mp4vuabRKQU(control_1))
		{
			HWGvu8B9VD5(control_1);
		}
	}

	private static void RngvuPxRy2q(object itemsControl_0Input, EventArgs eventArgs_0)
	{
        ItemsControl itemsControl_0 = (ItemsControl)itemsControl_0Input;
		ItemsControl itemsControl = itemsControl_0;
		if (itemsControl.ItemsSource != null)
		{
			if (mp4vuabRKQU(itemsControl))
			{
				HWGvu8B9VD5(itemsControl);
			}
			else
			{
				ugNvuyeYsjf(itemsControl);
			}
		}
		else
		{
			HWGvu8B9VD5(itemsControl);
		}
	}

	private static void SxxvuEWg124(object sender, ItemsChangedEventArgs e)
	{
		if (BMsvu73ijtN.TryGetValue(sender, out var value))
		{
			if (mp4vuabRKQU(value))
			{
				HWGvu8B9VD5(value);
			}
			else
			{
				ugNvuyeYsjf(value);
			}
		}
	}

	private static void ugNvuyeYsjf(UIElement uielement_0)
	{
		int num = 1;
		while (true)
		{
			AdornerLayer adornerLayer = AdornerLayer.GetAdornerLayer(uielement_0);
			int num2 = 0;
			if (!rg4QvWFzPCmA3lxb47Vu())
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			if (adornerLayer == null)
			{
				return;
			}
			Adorner[] adorners = adornerLayer.GetAdorners(uielement_0);
			if (adorners == null)
			{
				return;
			}
			Adorner[] array = adorners;
			foreach (Adorner adorner in array)
			{
				if (adorner is Rvq3HeicUwD6VERTNqt)
				{
					adorner.Visibility = Visibility.Hidden;
					adornerLayer.Remove(adorner);
				}
			}
			return;
		}
	}

	private static void HWGvu8B9VD5(Control control_0)
	{
		AdornerLayer.GetAdornerLayer(control_0)?.Add(new Rvq3HeicUwD6VERTNqt(control_0, GetWatermark(control_0)));
	}

	private static bool mp4vuabRKQU(Control control_0)
	{
		if (control_0 is ComboBox)
		{
			return (control_0 as ComboBox).Text == string.Empty;
		}
		if (control_0 is TextBoxBase)
		{
			return (control_0 as TextBox).Text == string.Empty;
		}
		if (control_0 is ItemsControl)
		{
			return (control_0 as ItemsControl).Items.Count == 0;
		}
		return false;
	}

	static WatermarkService()
	{
		WatermarkProperty = DependencyProperty.RegisterAttached("Watermark", typeof(object), typeof(WatermarkService), new FrameworkPropertyMetadata(null, Bq8vuJ1TOjW));
		BMsvu73ijtN = new Dictionary<object, ItemsControl>();
	}

	internal static bool rg4QvWFzPCmA3lxb47Vu()
	{
		return l1qGPGFzgTVW89PEHolD == null;
	}

	internal static void UqqXaZFzt0oGwo9MyIUt()
	{
	}
}
