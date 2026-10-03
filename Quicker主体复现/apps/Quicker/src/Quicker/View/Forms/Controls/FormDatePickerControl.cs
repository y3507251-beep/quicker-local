using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Markup;
using HandyControl.Controls;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Forms;

namespace Quicker.View.Forms.Controls;

public class FormDatePickerControl : BaseFormFieldControl, IComponentConnector, IFormControl
{
	private FormField cKKLVet8POo;

	[CompilerGenerated]
	private bool TowLVYAF1Ig;

	internal DatePicker TheDatePicker;

	internal DateTimePicker TheDateTimePicker;

	private bool MRHLVICA71Y;

	internal static FormDatePickerControl aQisb4FBaNiQM6vQA69r;

	public FormDatePickerControl()
	{
		InitializeComponent();
	}

	[SpecialName]
	[CompilerGenerated]
	private bool AcLLVZbIchF()
	{
		return TowLVYAF1Ig;
	}

	[SpecialName]
	[CompilerGenerated]
	private void LV3LV9OitWY(bool value)
	{
		TowLVYAF1Ig = value;
	}

	public void Init(FormField field, ActionVariable variable, IVariableContext context)
	{
		cKKLVet8POo = field;
		LV3LV9OitWY(field.OnlyDate);
		object value = context.TryGetValue(field.FieldKey, null);
		UpdateValue(value);
	}

	public object GetInputValue()
	{
		return AcLLVZbIchF() ? TheDatePicker.SelectedDate : TheDateTimePicker.SelectedDateTime;
	}

	public (bool isValid, string message) Validate()
	{
		if (cKKLVet8POo.IsRequired && ((AcLLVZbIchF() && !TheDatePicker.SelectedDate.HasValue) || (!AcLLVZbIchF() && !TheDateTimePicker.SelectedDateTime.HasValue)))
		{
			return (isValid: false, message: "请选择日期。");
		}
		return (isValid: true, message: "");
	}

	public void SetFocus()
	{
		if (AcLLVZbIchF())
		{
			TheDatePicker.Focus();
		}
		else
		{
			TheDateTimePicker.Focus();
		}
	}

	public UIElement GetPrimaryElement()
	{
		if (!AcLLVZbIchF())
		{
			return TheDateTimePicker;
		}
		return TheDatePicker;
	}

	public void SetInputWidth(double width)
	{
		if (AcLLVZbIchF())
		{
			TheDatePicker.HorizontalAlignment = HorizontalAlignment.Left;
			TheDatePicker.Width = width;
		}
		else
		{
			TheDateTimePicker.HorizontalAlignment = HorizontalAlignment.Left;
			TheDateTimePicker.Width = width;
		}
	}

	public void UpdateValue(object value)
	{
		DateTime? dateTime = null;
		if (value != null)
		{
			dateTime = Convert.ToDateTime(value);
		}
		int num;
		DateTime valueOrDefault;
		if (AcLLVZbIchF())
		{
			valueOrDefault = dateTime.GetValueOrDefault();
			if (!dateTime.HasValue)
			{
				valueOrDefault = DateTime.Now.Date;
				dateTime = valueOrDefault;
			}
			TheDatePicker.SelectedDate = dateTime;
			num = 0;
			if (aQisb4FBaNiQM6vQA69r != null)
			{
				goto IL_008f;
			}
			goto IL_0093;
		}
		valueOrDefault = dateTime.GetValueOrDefault();
		if (!dateTime.HasValue)
		{
			valueOrDefault = DateTime.Now;
			dateTime = valueOrDefault;
		}
		TheDateTimePicker.SelectedDateTime = dateTime;
		TheDateTimePicker.Visibility = Visibility.Visible;
		TheDatePicker.Visibility = Visibility.Collapsed;
		return;
		IL_0093:
		do
		{
			switch (num)
			{
			case 1:
				TheDatePicker.Language = XmlLanguage.GetLanguage("zh-CN");
				return;
			}
			TheDateTimePicker.Visibility = Visibility.Collapsed;
			TheDatePicker.Visibility = Visibility.Visible;
			num = 1;
		}
		while (aQisb4FBaNiQM6vQA69r == null);
		goto IL_008f;
		IL_008f:
		int num2 = default(int);
		num = num2;
		goto IL_0093;
	}

	public void SetReadOnly(bool isReadOnly)
	{
		TheDatePicker.IsEnabled = !isReadOnly;
		TheDateTimePicker.IsEnabled = !isReadOnly;
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!MRHLVICA71Y)
		{
			MRHLVICA71Y = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/forms/controls/formdatepickercontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			MRHLVICA71Y = true;
			break;
		case 2:
			TheDateTimePicker = (DateTimePicker)target;
			break;
		case 1:
			TheDatePicker = (DatePicker)target;
			break;
		}
	}

	internal static bool gHGsMCFBrBy8yvIBbit4()
	{
		return aQisb4FBaNiQM6vQA69r == null;
	}
}
