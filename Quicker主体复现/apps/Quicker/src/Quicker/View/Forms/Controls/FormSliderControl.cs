using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Public.Forms;

namespace Quicker.View.Forms.Controls;

public class FormSliderControl : BaseFormFieldControl, IComponentConnector, IFormControl
{
	private FormField OR9LVtsiI1u;

	internal Slider TheSlider;

	internal TextBox TxtValue;

	private bool Yt2LVgAJWuc;

	internal static FormSliderControl RHCGhRFKHGwpWwMTdQwF;

	public FormSliderControl()
	{
		InitializeComponent();
		TheSlider.ValueChanged += deFLcfrOf9f;
	}

	private void deFLcfrOf9f(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		TriggerValueChange(OR9LVtsiI1u);
	}

	public void Init(FormField field, ActionVariable variable, IVariableContext context)
	{
		OR9LVtsiI1u = field;
		object obj = context.TryGetValue(field.FieldKey, null);
		UpdateValue(obj);
		if (!string.IsNullOrEmpty(field.MaxValue))
		{
			TheSlider.Maximum = Convert.ToDouble(field.MaxValue);
			goto IL_0041;
		}
		goto IL_0084;
		IL_00ae:
		if (variable.Type == VarType.Integer)
		{
			TheSlider.TickFrequency = 1.0;
			TheSlider.SmallChange = 1.0;
			TheSlider.IsSnapToTickEnabled = true;
		}
		else
		{
			TheSlider.TickFrequency = 0.01;
			TheSlider.SmallChange = 0.01;
			TheSlider.IsSnapToTickEnabled = true;
		}
		return;
		IL_0041:
		if (!string.IsNullOrEmpty(field.MinValue))
		{
			TheSlider.Minimum = Convert.ToDouble(field.MinValue);
			int num = 0;
			if (!sBHtieFKzJmTMBFfjfnH())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			case 1:
				break;
			default:
				goto IL_00ae;
			}
			goto IL_0084;
		}
		TheSlider.Minimum = 0.0;
		goto IL_00ae;
		IL_0084:
		TheSlider.Maximum = 100.0;
		goto IL_0041;
	}

	public object GetInputValue()
	{
		return TheSlider.Value;
	}

	public (bool isValid, string message) Validate()
	{
		if (OR9LVtsiI1u.IsRequired)
		{
			return (isValid: false, message: "请输入值");
		}
		return (isValid: true, message: "");
	}

	public void SetFocus()
	{
		TheSlider.Focus();
	}

	public UIElement GetPrimaryElement()
	{
		return TheSlider;
	}

	public void SetInputWidth(double width)
	{
		TheSlider.HorizontalAlignment = HorizontalAlignment.Left;
		TheSlider.Width = width;
	}

	public void UpdateValue(object obj)
	{
		if (obj == null)
		{
			TheSlider.Value = 0.0;
			return;
		}
		try
		{
			double value = Convert.ToDouble(obj);
			TheSlider.Value = value;
		}
		catch (Exception)
		{
		}
	}

	public void SetReadOnly(bool isReadOnly)
	{
		TheSlider.IsEnabled = !isReadOnly;
		TxtValue.IsReadOnly = isReadOnly;
	}

	private void i01LczQCgtK(object sender, MouseWheelEventArgs e)
	{
		if (e.Delta > 0)
		{
			TheSlider.Value += TheSlider.SmallChange;
		}
		else
		{
			TheSlider.Value -= TheSlider.SmallChange;
		}
	}

	private void KItLVwIRO83(object sender, KeyEventArgs e)
	{
		if (e.Key == Key.Up)
		{
			TheSlider.Value += TheSlider.SmallChange;
		}
		else if (e.Key == Key.Down)
		{
			TheSlider.Value -= TheSlider.SmallChange;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!Yt2LVgAJWuc)
		{
			Yt2LVgAJWuc = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/forms/controls/formslidercontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			Yt2LVgAJWuc = true;
			break;
		case 2:
			TxtValue = (TextBox)target;
			TxtValue.MouseWheel += i01LczQCgtK;
			TxtValue.PreviewKeyDown += KItLVwIRO83;
			break;
		case 1:
			TheSlider = (Slider)target;
			break;
		}
	}

	static FormSliderControl()
	{
	}

	internal static bool sBHtieFKzJmTMBFfjfnH()
	{
		return RHCGhRFKHGwpWwMTdQwF == null;
	}

	internal static void ic54wuFBpx1sq6VWptxN()
	{
	}
}
