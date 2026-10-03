using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;

namespace Quicker.Utilities.UI;

public class DropDownButton : ToggleButton
{
	public Action<ContextMenu> LazyBuildMenuFunc;

	public static readonly DependencyProperty MenuProperty;

	internal static DropDownButton LactdxFzyS66BCRYnKDE;

	public ContextMenu Menu
	{
		get
		{
			return (ContextMenu)GetValue(MenuProperty);
		}
		set
		{
			SetValue(MenuProperty, value);
		}
	}

	public DropDownButton()
	{
		Binding binding = new Binding("Menu.IsOpen")
		{
			Source = this
		};
		SetBinding(ToggleButton.IsCheckedProperty, binding);
		base.DataContextChanged += clavuSV2Bpn;
	}

	private static void rpVvuv6Cufy(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
	{
		DropDownButton dropDownButton = (DropDownButton)dependencyObject_0;
		((ContextMenu)dependencyPropertyChangedEventArgs_0.NewValue).DataContext = dropDownButton.DataContext;
	}

	protected override void OnClick()
	{
		if (Menu == null)
		{
			Menu = new ContextMenu();
		}
		LazyBuildMenuFunc?.Invoke(Menu);
		OpenMenu();
	}

	public void OpenMenu()
	{
		if (Menu != null)
		{
			Menu.PlacementTarget = this;
			Menu.Placement = PlacementMode.Bottom;
			Menu.IsOpen = true;
		}
	}

	static DropDownButton()
	{
		MenuProperty = DependencyProperty.Register("Menu", typeof(ContextMenu), typeof(DropDownButton), new UIPropertyMetadata(null, rpVvuv6Cufy));
	}

	[CompilerGenerated]
	private void clavuSV2Bpn(object sender, DependencyPropertyChangedEventArgs e)
	{
		if (Menu != null)
		{
			Menu.DataContext = base.DataContext;
		}
	}

	internal static bool y8rNDvFzpAFNIIDV6u3v()
	{
		return LactdxFzyS66BCRYnKDE == null;
	}
}
