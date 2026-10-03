using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Actions.X.Variables;
using Quicker.Public.Forms;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.View.Controls;
using Xceed.Wpf.Toolkit;

namespace Quicker.View.Forms.Controls;

public class FormColorSelectorControl : BaseFormFieldControl, IComponentConnector, IFormControl
{
	private FormField iWjLV7ZuhxO;

	private ActionVariable a8SLVR97inf;

	private System.Windows.Media.Color? CnLLVq2oiZs;

	private bool S22LVcf5PPL;

	internal ColorPicker ThePicker;

	internal ScreenColorPickerControl ScreenColorPicker;

	internal Button BtnClear;

	private bool YepLVVU78vt;

	internal static FormColorSelectorControl Y3q7GRFBO8ijtW3CoTpN;

	public FormColorSelectorControl()
	{
		InitializeComponent();
		ThePicker.SelectedColorChanged += CMDLV8wSFos;
	}

	private void CMDLV8wSFos(object sender, RoutedPropertyChangedEventArgs<System.Windows.Media.Color?> e)
	{
		if (S22LVcf5PPL)
		{
			TriggerValueChange(iWjLV7ZuhxO);
		}
	}

	public void Init(FormField field, ActionVariable variable, IVariableContext context)
	{
		iWjLV7ZuhxO = field;
		a8SLVR97inf = variable;
		UpdateValue(context.TryGetValue(field.FieldKey, ""));
		S22LVcf5PPL = true;
	}

	public object GetInputValue()
	{
		System.Windows.Media.Color? selectedColor = ThePicker.SelectedColor;
		object obj;
		if (!selectedColor.HasValue)
		{
			obj = null;
		}
		else
		{
			obj = selectedColor.GetValueOrDefault().ToString();
			if (obj != null)
			{
				goto IL_0038;
			}
		}
		obj = "";
		goto IL_0038;
		IL_0038:
		return obj;
	}

	public (bool isValid, string message) Validate()
	{
		if (iWjLV7ZuhxO.IsRequired && !ThePicker.SelectedColor.HasValue)
		{
			return (isValid: false, message: "请选择颜色。");
		}
		return (isValid: true, message: "");
	}

	public void SetFocus()
	{
		ThePicker.Focus();
	}

	public UIElement GetPrimaryElement()
	{
		return ThePicker;
	}

	public void SetInputWidth(double width)
	{
		ThePicker.HorizontalAlignment = HorizontalAlignment.Left;
		ThePicker.Width = width;
	}

	public void UpdateValue(object obj)
	{
		string text = VariableHelper.LcfghRCibTg(obj);
		if (!string.IsNullOrEmpty(text))
		{
			try
			{
				System.Windows.Media.Color value = (System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString(text);
				CnLLVq2oiZs = value;
				ThePicker.SelectedColor = value;
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning(text + " 不是合法的颜色值." + ex.Message);
			}
		}
	}

	public void SetReadOnly(bool isReadOnly)
	{
		ThePicker.IsEnabled = !isReadOnly;
	}

	private void ScreenColorPicker_OnValueChanged(object sender, EventArgs e)
	{
		System.Drawing.Color? color = ScreenColorPicker.Color;
		ThePicker.SelectedColor = color.Value.ToMediaColor();
	}

	private void L1kLVaCl4jK(object sender, RoutedEventArgs e)
	{
		ThePicker.SelectedColor = null;
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!YepLVVU78vt)
		{
			YepLVVU78vt = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/forms/controls/formcolorselectorcontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			YepLVVU78vt = true;
			break;
		case 1:
			ThePicker = (ColorPicker)target;
			break;
		case 2:
			ScreenColorPicker = (ScreenColorPickerControl)target;
			break;
		case 3:
			BtnClear = (Button)target;
			BtnClear.Click += L1kLVaCl4jK;
			break;
		}
	}

	internal static bool rQBLYfFBJCCmBLNeAG96()
	{
		return Y3q7GRFBO8ijtW3CoTpN == null;
	}
}
