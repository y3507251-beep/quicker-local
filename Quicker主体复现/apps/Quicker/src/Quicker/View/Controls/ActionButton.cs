using System;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using log4net;
using Quicker.Common;
using Quicker.Domain;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;
using Quicker.View.CircleMenu;
using t8SGKhhgLWTgeqjGcrq;

namespace Quicker.View.Controls;

public class ActionButton : Button
{
	private static readonly ILog UxpLKL00cOo;

	public static readonly DependencyProperty DefaultIconColorProperty;

	public static readonly DependencyProperty CornerRadiusProperty;

	public static readonly DependencyProperty LabelProperty;

	public static readonly DependencyProperty IconProperty;

	public static readonly DependencyProperty ShrinkTitleProperty;

	public static readonly DependencyProperty ButtonColorProperty;

	public static readonly DependencyProperty HoverColorProperty;

	public static readonly DependencyProperty EmptyHoverColorProperty;

	public static readonly DependencyProperty LabelColorProperty;

	public static readonly DependencyProperty InvalidButtonColorProperty;

	public static readonly DependencyProperty HideLabelIfHasIconProperty;

	public static readonly DependencyProperty DisplayModeProperty;

	public static readonly DependencyProperty EnableZoomEffectProperty;

	public static readonly DependencyProperty EnableShadowProperty;

	public static readonly DependencyProperty ShowKeyTipProperty;

	public static readonly DependencyProperty KeyTipProperty;

	public static readonly DependencyProperty KeyTipColorProperty;

	public static readonly DependencyProperty OverlayIconProperty;

	public static readonly DependencyProperty OverlayIconTooltipProperty;

	public static readonly DependencyProperty BadgeTextProperty;

	public static readonly DependencyProperty BadgeTextColorProperty;

	public static readonly DependencyProperty BadgeColorProperty;

	public static readonly DependencyProperty ShowNewVersionDotProperty;

	public static readonly DependencyProperty ShowNewVersionDotForCircleMenuProperty;

	public static readonly DependencyProperty IsEmptyProperty;

	public static readonly DependencyProperty IsSelectedProperty;

	private ActionItem utpLKv2eCKM;

	private static ActionButton nQfwWsFLYBPeMVudWh5g;

	public string DefaultIconColor
	{
		get
		{
			return (string)GetValue(DefaultIconColorProperty);
		}
		set
		{
			SetValue(DefaultIconColorProperty, value);
		}
	}

	public CornerRadius CornerRadius
	{
		get
		{
			return (CornerRadius)GetValue(CornerRadiusProperty);
		}
		set
		{
			SetValue(CornerRadiusProperty, value);
		}
	}

	public string Label
	{
		get
		{
			return (string)GetValue(LabelProperty);
		}
		set
		{
			SetValue(LabelProperty, value);
		}
	}

	public string Icon
	{
		get
		{
			return (string)GetValue(IconProperty);
		}
		set
		{
			SetValue(IconProperty, value);
		}
	}

	public Brush ButtonColor
	{
		get
		{
			return GetButtonColor(this);
		}
		set
		{
			SetButtonColor(this, value);
		}
	}

	public Brush HoverColor
	{
		get
		{
			return GetHoverColor(this);
		}
		set
		{
			SetHoverColor(this, value);
		}
	}

	public Brush EmptyHoverColor
	{
		get
		{
			return GetEmptyHoverColor(this);
		}
		set
		{
			SetEmptyHoverColor(this, value);
		}
	}

	public Brush LabelColor
	{
		get
		{
			return GetLabelColor(this);
		}
		set
		{
			SetLabelColor(this, value);
		}
	}

	public ActionButtonDisplayMode DisplayMode
	{
		get
		{
			return (ActionButtonDisplayMode)GetValue(DisplayModeProperty);
		}
		set
		{
			SetValue(DisplayModeProperty, value);
		}
	}

	public bool ShowKeyTip
	{
		get
		{
			return (bool)GetValue(ShowKeyTipProperty);
		}
		set
		{
			SetValue(ShowKeyTipProperty, value);
		}
	}

	public string KeyTip
	{
		get
		{
			return (string)GetValue(KeyTipProperty);
		}
		set
		{
			SetValue(KeyTipProperty, value);
		}
	}

	public string OverlayIcon
	{
		get
		{
			return (string)GetValue(OverlayIconProperty);
		}
		set
		{
			SetValue(OverlayIconProperty, value);
		}
	}

	public string OverlayIconTooltip
	{
		get
		{
			return (string)GetValue(OverlayIconTooltipProperty);
		}
		set
		{
			SetValue(OverlayIconTooltipProperty, value);
		}
	}

	public string BadgeText
	{
		get
		{
			return (string)GetValue(BadgeTextProperty);
		}
		set
		{
			SetValue(BadgeTextProperty, value);
		}
	}

	public Brush BadgeTextColor
	{
		get
		{
			return (Brush)GetValue(BadgeTextColorProperty);
		}
		set
		{
			SetValue(BadgeTextColorProperty, value);
		}
	}

	public Brush BadgeColor
	{
		get
		{
			return (Brush)GetValue(BadgeColorProperty);
		}
		set
		{
			SetValue(BadgeColorProperty, value);
		}
	}

	public bool ShowNewVersionDot
	{
		get
		{
			return (bool)GetValue(ShowNewVersionDotProperty);
		}
		set
		{
			SetValue(ShowNewVersionDotProperty, value);
		}
	}

	public bool ShowNewVersionDotForCircleMenu
	{
		get
		{
			return (bool)GetValue(ShowNewVersionDotForCircleMenuProperty);
		}
		set
		{
			SetValue(ShowNewVersionDotForCircleMenuProperty, value);
		}
	}

	public bool IsEmpty
	{
		get
		{
			return (bool)GetValue(IsEmptyProperty);
		}
		set
		{
			SetValue(IsEmptyProperty, value);
		}
	}

	public bool IsSelected
	{
		get
		{
			return (bool)GetValue(IsSelectedProperty);
		}
		set
		{
			SetValue(IsSelectedProperty, value);
		}
	}

	public ActionItem ActionItem
	{
		get
		{
			return utpLKv2eCKM;
		}
		set
		{
			utpLKv2eCKM = value;
			RefreshAction();
		}
	}

	static ActionButton()
	{
		UxpLKL00cOo = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		DefaultIconColorProperty = DependencyProperty.RegisterAttached("DefaultIconColor", typeof(string), typeof(ActionButton), new FrameworkPropertyMetadata("darkgray", FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.Inherits));
		CornerRadiusProperty = DependencyProperty.RegisterAttached("CornerRadius", typeof(CornerRadius), typeof(ActionButton), new FrameworkPropertyMetadata(default(CornerRadius), FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.Inherits));
		LabelProperty = DependencyProperty.Register("Label", typeof(string), typeof(ActionButton), new PropertyMetadata(null, NvCLKtJZMKO));
		IconProperty = DependencyProperty.Register("Icon", typeof(string), typeof(ActionButton), new PropertyMetadata(null, NvCLKtJZMKO));
		ShrinkTitleProperty = DependencyProperty.RegisterAttached("ShrinkTitle", typeof(bool), typeof(ActionButton), new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.Inherits));
		ButtonColorProperty = DependencyProperty.RegisterAttached("ButtonColor", typeof(Brush), typeof(ActionButton), new FrameworkPropertyMetadata(Brushes.White, FrameworkPropertyMetadataOptions.Inherits));
		HoverColorProperty = DependencyProperty.RegisterAttached("HoverColor", typeof(Brush), typeof(ActionButton), new FrameworkPropertyMetadata(Color.FromArgb(byte.MaxValue, 178, 242, byte.MaxValue).GetBrush(), FrameworkPropertyMetadataOptions.Inherits));
		EmptyHoverColorProperty = DependencyProperty.RegisterAttached("EmptyHoverColor", typeof(Brush), typeof(ActionButton), new FrameworkPropertyMetadata(Color.FromArgb(5, 0, 0, 0).GetBrush(), FrameworkPropertyMetadataOptions.Inherits));
		LabelColorProperty = DependencyProperty.RegisterAttached("LabelColor", typeof(Brush), typeof(ActionButton), new FrameworkPropertyMetadata(Brushes.Black, FrameworkPropertyMetadataOptions.Inherits));
		InvalidButtonColorProperty = DependencyProperty.RegisterAttached("InvalidButtonColor", typeof(Brush), typeof(ActionButton), new FrameworkPropertyMetadata(Color.FromArgb(50, 200, 200, 200).GetBrush(), FrameworkPropertyMetadataOptions.Inherits));
		HideLabelIfHasIconProperty = DependencyProperty.RegisterAttached("HideLabelIfHasIcon", typeof(bool), typeof(ActionButton), new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.Inherits, NvCLKtJZMKO));
		DisplayModeProperty = DependencyProperty.Register("DisplayMode", typeof(ActionButtonDisplayMode), typeof(ActionButton), new PropertyMetadata(ActionButtonDisplayMode.Both));
		EnableZoomEffectProperty = DependencyProperty.RegisterAttached("EnableZoomEffect", typeof(bool), typeof(ActionButton), new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.Inherits));
		EnableShadowProperty = DependencyProperty.RegisterAttached("EnableShadow", typeof(bool), typeof(ActionButton), new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.Inherits));
		ShowKeyTipProperty = DependencyProperty.RegisterAttached("ShowKeyTip", typeof(bool), typeof(ActionButton), new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.Inherits));
		KeyTipProperty = DependencyProperty.Register("KeyTip", typeof(string), typeof(ActionButton), new PropertyMetadata((object)null));
		KeyTipColorProperty = DependencyProperty.RegisterAttached("KeyTipColor", typeof(Brush), typeof(ActionButton), new FrameworkPropertyMetadata(Brushes.DarkOrange, FrameworkPropertyMetadataOptions.Inherits));
		OverlayIconProperty = DependencyProperty.Register("OverlayIcon", typeof(string), typeof(ActionButton), new PropertyMetadata((object)null));
		OverlayIconTooltipProperty = DependencyProperty.Register("OverlayIconTooltip", typeof(string), typeof(ActionButton), new PropertyMetadata((object)null));
		BadgeTextProperty = DependencyProperty.Register("BadgeText", typeof(string), typeof(ActionButton), new PropertyMetadata((object)null));
		BadgeTextColorProperty = DependencyProperty.Register("BadgeTextColor", typeof(Brush), typeof(ActionButton), new PropertyMetadata(Brushes.White));
		BadgeColorProperty = DependencyProperty.Register("BadgeColor", typeof(Brush), typeof(ActionButton), new PropertyMetadata(Brushes.Red));
		ShowNewVersionDotProperty = DependencyProperty.RegisterAttached("ShowNewVersionDot", typeof(bool), typeof(ActionButton), new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.Inherits));
		ShowNewVersionDotForCircleMenuProperty = DependencyProperty.RegisterAttached("ShowNewVersionDotForCircleMenu", typeof(bool), typeof(ActionButton), new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.Inherits));
		IsEmptyProperty = DependencyProperty.Register("IsEmpty", typeof(bool), typeof(global::Quicker.View.Controls.ActionButton), new PropertyMetadata(false));
		IsSelectedProperty = DependencyProperty.Register("IsSelected", typeof(bool), typeof(ActionButton), new PropertyMetadata(false));
		FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(ActionButton), new FrameworkPropertyMetadata(typeof(ActionButton)));
	}

	public ActionButton()
	{
		if (Application.Current.Dispatcher.CheckAccess())
		{
			Binding binding = new Binding("DefaultActionIconColor")
			{
				Source = AppState.SkinInfo
			};
			BindingOperations.SetBinding(this, DefaultIconColorProperty, binding);
		}
	}

	public ActionButton(bool bindIconColor)
	{
		if (bindIconColor && Application.Current.Dispatcher.CheckAccess())
		{
			Binding binding = new Binding("DefaultActionIconColor")
			{
				Source = AppState.SkinInfo
			};
			BindingOperations.SetBinding(this, DefaultIconColorProperty, binding);
		}
	}

	public void ClearIconColorBinding()
	{
		BindingOperations.ClearBinding(this, DefaultIconColorProperty);
	}

	private static void NvCLKtJZMKO(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
	{
		if (dependencyObject_0 is ActionButton actionButton)
		{
			actionButton.UpdateDisplayMode();
		}
	}

	public static void SetShrinkTitle(DependencyObject element, bool value)
	{
		element.SetValue(ShrinkTitleProperty, value);
	}

	public static bool GetShrinkTitle(DependencyObject element)
	{
		return (bool)element.GetValue(ShrinkTitleProperty);
	}

	public static void SetButtonColor(DependencyObject element, Brush value)
	{
		element.SetValue(ButtonColorProperty, value);
	}

	public static Brush GetButtonColor(DependencyObject element)
	{
		return (Brush)element.GetValue(ButtonColorProperty);
	}

	public static void SetHoverColor(DependencyObject element, Brush value)
	{
		element.SetValue(HoverColorProperty, value);
	}

	public static Brush GetHoverColor(DependencyObject element)
	{
		return (Brush)element.GetValue(HoverColorProperty);
	}

	public static void SetEmptyHoverColor(DependencyObject element, Brush value)
	{
		element.SetValue(EmptyHoverColorProperty, value);
	}

	public static Brush GetEmptyHoverColor(DependencyObject element)
	{
		return (Brush)element.GetValue(EmptyHoverColorProperty);
	}

	public static void SetLabelColor(DependencyObject element, Brush value)
	{
		element.SetValue(LabelColorProperty, value);
	}

	public static Brush GetLabelColor(DependencyObject element)
	{
		return (Brush)element.GetValue(LabelColorProperty);
	}

	public static void SetInvalidButtonColor(DependencyObject element, Brush value)
	{
		element.SetValue(InvalidButtonColorProperty, value);
	}

	public static Brush GetInvalidButtonColor(DependencyObject element)
	{
		return (Brush)element.GetValue(InvalidButtonColorProperty);
	}

	public static void SetHideLabelIfHasIcon(DependencyObject element, bool value)
	{
		element.SetValue(HideLabelIfHasIconProperty, value);
	}

	public static bool GetHideLabelIfHasIcon(DependencyObject element)
	{
		return (bool)element.GetValue(HideLabelIfHasIconProperty);
	}

	public void UpdateDisplayMode()
	{
		if (string.IsNullOrEmpty(Icon))
		{
			DisplayMode = ActionButtonDisplayMode.OnlyLabel;
		}
		else if (GetHideLabelIfHasIcon(this))
		{
			DisplayMode = ActionButtonDisplayMode.OnlyIcon;
		}
		else
		{
			DisplayMode = ActionButtonDisplayMode.Both;
		}
	}

	public static void SetEnableZoomEffect(DependencyObject element, bool value)
	{
		element.SetValue(EnableZoomEffectProperty, value);
	}

	public static bool GetEnableZoomEffect(DependencyObject element)
	{
		return (bool)element.GetValue(EnableZoomEffectProperty);
	}

	public static void SetEnableShadow(DependencyObject element, bool value)
	{
		element.SetValue(EnableShadowProperty, value);
	}

	public static bool GetEnableShadow(DependencyObject element)
	{
		return (bool)element.GetValue(EnableShadowProperty);
	}

	public static void SetKeyTipColor(DependencyObject element, Brush value)
	{
		element.SetValue(KeyTipColorProperty, value);
	}

	public static Brush GetKeyTipColor(DependencyObject element)
	{
		return (Brush)element.GetValue(KeyTipColorProperty);
	}

	public void SetAction(ActionItem action)
	{
		ActionItem = action;
	}

	public void RefreshAction()
	{
		int num = 1;
		while (true)
		{
			IsEmpty = utpLKv2eCKM == null;
			int num2 = 0;
			if (nQfwWsFLYBPeMVudWh5g != null)
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			default:
				Label = ActionItem?.Title?.Replace("\\n", "\n");
				Icon = ActionItem?.Icon;
				base.ToolTip = I7lLKgJZwm7(ActionItem);
				if (ActionItem != null && AppState.DataService.CpItmVISR7P().ShowActionNewVersionTip && AppState.DataService.T0DtXck0Jas(ActionItem) && !AppState.DataService.BV9tm7kpqII())
				{
					if (Window.GetWindow(this) is CircleMenuWindow)
					{
						ShowNewVersionDotForCircleMenu = true;
						break;
					}
					goto case 2;
				}
				ShowNewVersionDotForCircleMenu = false;
				ShowNewVersionDot = false;
				break;
			case 2:
				ShowNewVersionDot = true;
				break;
			case 3:
				break;
			}
			break;
		}
		ActionAdorn actionAdorn = AppState.DataService.QdntXhlJ6w2(ActionItem?.Id);
		if (actionAdorn != null)
		{
			if (!string.IsNullOrEmpty(actionAdorn.BadgeText))
			{
				BadgeText = actionAdorn.BadgeText;
				BadgeColor = ColorHelper.BrushFromColorString(actionAdorn.BadgeColor, Brushes.Red);
				BadgeTextColor = ColorHelper.BrushFromColorString(actionAdorn.BadgeTextColor, Brushes.White);
			}
			else
			{
				BadgeText = null;
			}
			if (!string.IsNullOrWhiteSpace(actionAdorn.OverlayIcon))
			{
				OverlayIcon = actionAdorn.OverlayIcon;
			}
			else
			{
				OverlayIcon = null;
			}
		}
		else
		{
			BadgeText = null;
			OverlayIcon = null;
		}
	}

	private string I7lLKgJZwm7(ActionItem actionItem_1)
	{
		if (actionItem_1 == null)
		{
			return null;
		}
		if (!string.IsNullOrEmpty(actionItem_1.Description))
		{
			string text = actionItem_1.Description.Replace("\\n", "\n");
			if (GetHideLabelIfHasIcon(this))
			{
				return actionItem_1.Title + "\n" + text;
			}
			if (string.Equals(actionItem_1.Title, text, StringComparison.OrdinalIgnoreCase))
			{
				return actionItem_1.Title;
			}
			return actionItem_1.Title + "\n" + text;
		}
		return actionItem_1.Title;
	}

	internal static bool PbySMiFL8Vh99GuUCFex()
	{
		return nQfwWsFLYBPeMVudWh5g == null;
	}
}
