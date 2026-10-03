using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Markup;
using HandyControl.Controls;
using HandyControl.Data;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Public.Forms;

namespace Quicker.View.Forms.Controls;

public class FormNumberBox : BaseFormFieldControl, IComponentConnector, IFormControl
{
	private FormField WmiLVmD8gxl;

	internal NumericUpDown TxtValue;

	private bool Ff9LVKax54T;

	internal static FormNumberBox TdaBqiFBUo13BF6EFfEw;

	public FormNumberBox()
	{
		InitializeComponent();
		TxtValue.ValueChanged += Rp7LVXP9kgB;
	}

	private void Rp7LVXP9kgB(object sender, FunctionEventArgs<double> e)
	{
		if (WmiLVmD8gxl != null)
		{
			TriggerValueChange(WmiLVmD8gxl);
		}
	}

	public void Init(FormField field, ActionVariable variable, IVariableContext context)
	{
		WmiLVmD8gxl = field;
		object obj = context.TryGetValue(field.FieldKey, null);
		UpdateValue(obj);
		if (!string.IsNullOrEmpty(field.MaxValue))
		{
			TxtValue.Maximum = Convert.ToDouble(field.MaxValue);
		}
		if (!string.IsNullOrEmpty(field.MinValue))
		{
			TxtValue.Minimum = Convert.ToDouble(field.MinValue);
		}
		else
		{
			TxtValue.Minimum = double.MinValue;
		}
		if (variable.Type == VarType.Integer)
		{
			TxtValue.Increment = 1.0;
			TxtValue.DecimalPlaces = 0;
			int num = 0;
			if (!rucsSBFBx4hU5BwHAgrI())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		else
		{
			TxtValue.Increment = ((Math.Abs(TxtValue.Value) < 1.0) ? 0.1 : 1.0);
			TxtValue.DecimalPlaces = null;
		}
	}

	public object GetInputValue()
	{
		return TxtValue.Value;
	}

	public (bool isValid, string message) Validate()
	{
		if (!string.IsNullOrEmpty(WmiLVmD8gxl.MaxValue?.Trim()) && TxtValue.Value > Convert.ToDouble(WmiLVmD8gxl.MaxValue.Trim()))
		{
			return (isValid: false, message: "值太大，允许的最大值:" + WmiLVmD8gxl.MaxValue);
		}
		if (!string.IsNullOrEmpty(WmiLVmD8gxl.MinValue?.Trim()) && TxtValue.Value < Convert.ToDouble(WmiLVmD8gxl.MinValue.Trim()))
		{
			return (isValid: false, message: "值太小，允许的最小值:" + WmiLVmD8gxl.MinValue);
		}
		return (isValid: true, message: "");
	}

	public void SetFocus()
	{
		TxtValue.Focus();
	}

	public UIElement GetPrimaryElement()
	{
		return TxtValue;
	}

	public void SetInputWidth(double width)
	{
		TxtValue.HorizontalAlignment = HorizontalAlignment.Left;
		TxtValue.Width = width;
	}

	public void UpdateValue(object obj)
	{
		if (obj == null)
		{
			TxtValue.Value = 0.0;
			return;
		}
		try
		{
			double value = Convert.ToDouble(obj);
			TxtValue.Value = value;
		}
		catch (Exception)
		{
		}
	}

	public void SetReadOnly(bool isReadOnly)
	{
		TxtValue.IsReadOnly = isReadOnly;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!Ff9LVKax54T)
		{
			Ff9LVKax54T = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/forms/controls/formnumberbox.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 1)
		{
			TxtValue = (NumericUpDown)target;
		}
		else
		{
			Ff9LVKax54T = true;
		}
	}

	static FormNumberBox()
	{
	}

	internal static bool rucsSBFBx4hU5BwHAgrI()
	{
		return TdaBqiFBUo13BF6EFfEw == null;
	}

	internal static void zo6HYjFBT8j1t1hAbb0H()
	{
	}
}
