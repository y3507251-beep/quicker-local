using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Quicker.View.Forms.Controls;

public static class ComboBoxMouseWheelBehavior
{
	[CompilerGenerated]
	private static class _003C_003EO
	{
		public static MouseWheelEventHandler AcSSo0NVFM2;
	}

	public static readonly DependencyProperty EnableMouseWheelProperty;

	internal static object QoysXCFKrCt0MDykBQCv;

	public static bool GetEnableMouseWheel(DependencyObject obj)
	{
		return (bool)obj.GetValue(EnableMouseWheelProperty);
	}

	public static void SetEnableMouseWheel(DependencyObject obj, bool value)
	{
		obj.SetValue(EnableMouseWheelProperty, value);
	}

	private static void fNgLc1QEhRu(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
	{
		if (dependencyObject_0 is ComboBox comboBox)
		{
			if ((bool)dependencyPropertyChangedEventArgs_0.NewValue)
			{
				comboBox.PreviewMouseWheel += _003C_003EO.AcSSo0NVFM2 ?? (_003C_003EO.AcSSo0NVFM2 = isBLcbavbXm);
			}
			else
			{
				comboBox.PreviewMouseWheel -= _003C_003EO.AcSSo0NVFM2 ?? (_003C_003EO.AcSSo0NVFM2 = isBLcbavbXm);
			}
		}
	}

	private static void isBLcbavbXm(object sender, MouseWheelEventArgs e)
	{
		if (!(sender is ComboBox comboBox) || (!comboBox.IsFocused && Keyboard.Modifiers != ModifierKeys.Control))
		{
			return;
		}
		int num = comboBox.SelectedIndex;
		if (e.Delta > 0)
		{
			num--;
		}
		else if (e.Delta < 0)
		{
			num++;
		}
		if (num >= 0 && num < comboBox.Items.Count)
		{
			comboBox.SelectedIndex = num;
			int num2 = 0;
			if (!FtbEYKFKNhE84b1rYm8e())
			{
				int num3 = default(int);
				num2 = num3;
			}
			switch (num2)
			{
			}
		}
		e.Handled = true;
	}

	static ComboBoxMouseWheelBehavior()
	{
		EnableMouseWheelProperty = DependencyProperty.RegisterAttached("EnableMouseWheel", typeof(bool), typeof(ComboBoxMouseWheelBehavior), new UIPropertyMetadata(false, fNgLc1QEhRu));
	}

	internal static bool FtbEYKFKNhE84b1rYm8e()
	{
		return QoysXCFKrCt0MDykBQCv == null;
	}
}
