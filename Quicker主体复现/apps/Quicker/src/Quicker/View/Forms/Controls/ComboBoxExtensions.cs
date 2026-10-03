using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using t8SGKhhgLWTgeqjGcrq;

namespace Quicker.View.Forms.Controls;

public static class ComboBoxExtensions
{
	[CompilerGenerated]
	private static class _003C_003EO
	{
		public static MouseWheelEventHandler NicSoJq5D4g;
	}

	public static readonly DependencyProperty DisableMouseWheelProperty;

	internal static object JuMTglFKvH6R4vklVqQo;

	private static void z0FLcsfG69M(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
	{
		if (!(dependencyObject_0 is ComboBox comboBox))
		{
			return;
		}
		object newValue = dependencyPropertyChangedEventArgs_0.NewValue;
		if (newValue is bool)
		{
			if ((bool)newValue)
			{
				comboBox.PreviewMouseWheel += _003C_003EO.NicSoJq5D4g ?? (_003C_003EO.NicSoJq5D4g = nKeLcHcAy2b);
			}
			else
			{
				comboBox.PreviewMouseWheel -= _003C_003EO.NicSoJq5D4g ?? (_003C_003EO.NicSoJq5D4g = nKeLcHcAy2b);
			}
		}
	}

	private static void nKeLcHcAy2b(object sender, MouseWheelEventArgs e)
	{
		if (sender is ComboBox { IsDropDownOpen: false })
		{
			e.Handled = true;
		}
	}

	public static void SetDisableMouseWheel(ComboBox comboBox, bool disable)
	{
		comboBox.SetValue(DisableMouseWheelProperty, disable);
	}

	public static bool GetDisableMouseWheel(ComboBox comboBox)
	{
		return (bool)comboBox.GetValue(DisableMouseWheelProperty);
	}

	static ComboBoxExtensions()
	{
		DisableMouseWheelProperty = DependencyProperty.RegisterAttached("DisableMouseWheel", typeof(bool), typeof(global::Quicker.View.Forms.Controls.ComboBoxExtensions), new PropertyMetadata(false, z0FLcsfG69M));
	}

	internal static bool U8JL3fFKdZOEmqvAdxwy()
	{
		return JuMTglFKvH6R4vklVqQo == null;
	}
}
