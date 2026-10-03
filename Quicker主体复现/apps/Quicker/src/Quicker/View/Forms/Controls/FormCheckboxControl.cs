using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using log4net;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Forms;

namespace Quicker.View.Forms.Controls;

public class FormCheckboxControl : BaseFormFieldControl, IComponentConnector, IFormControl
{
	private FormField qN6LVSxQpBX;

	private static readonly ILog Bo1LV24dGEs;

	internal CheckBox ChkValue;

	private bool Lv4LVu9T5nK;

	internal static FormCheckboxControl WP8FVTFBX1PygaruAwKv;

	public FormCheckboxControl()
	{
		InitializeComponent();
	}

	public void Init(FormField field, ActionVariable variable, IVariableContext context)
	{
		qN6LVSxQpBX = field;
		string text = field.Label;
		if (text.IsExpressionOrInterpolation())
		{
			string text2 = text;
			try
			{
				text = XActionHelper.InterpolateOrEvalToString((ActionExecuteContext)context, text2);
			}
			catch (Exception ex)
			{
				Bo1LV24dGEs.Warn("字段 " + field.Label + " 帮助文本解析出错:" + ex.Message + " 原始表达式：" + text2, ex);
				text = "(解析出错)" + field.Label;
			}
		}
		ChkValue.Content = new AccessText
		{
			Text = text
		};
		object value = context.TryGetValue(field.FieldKey, false);
		UpdateValue(value);
	}

	public object GetInputValue()
	{
		return ChkValue.IsChecked;
	}

	public (bool isValid, string message) Validate()
	{
		if (qN6LVSxQpBX.IsRequired && ChkValue.IsChecked == false)
		{
			return (isValid: false, message: "必须选择此选项。");
		}
		return (isValid: true, message: "");
	}

	public void SetFocus()
	{
		ChkValue.Focus();
	}

	public UIElement GetPrimaryElement()
	{
		return ChkValue;
	}

	public void SetInputWidth(double width)
	{
		ChkValue.HorizontalAlignment = HorizontalAlignment.Left;
		ChkValue.Width = width;
	}

	public void UpdateValue(object value)
	{
		bool value2 = Convert.ToBoolean(value);
		ChkValue.IsChecked = value2;
	}

	public void SetReadOnly(bool isReadOnly)
	{
		ChkValue.IsEnabled = !isReadOnly;
	}

	private void e5oLVL3KMwk(object sender, RoutedEventArgs e)
	{
		TriggerValueChange(qN6LVSxQpBX);
	}

	private void PjkLVvH51mq(object sender, RoutedEventArgs e)
	{
		TriggerValueChange(qN6LVSxQpBX);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!Lv4LVu9T5nK)
		{
			Lv4LVu9T5nK = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/forms/controls/formcheckboxcontrol.xaml", UriKind.Relative);
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
			ChkValue = (CheckBox)target;
			ChkValue.Checked += e5oLVL3KMwk;
			ChkValue.Unchecked += PjkLVvH51mq;
		}
		else
		{
			Lv4LVu9T5nK = true;
		}
	}

	static FormCheckboxControl()
	{
		Bo1LV24dGEs = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool YMF1vHFB2pMtAHLpQFaR()
	{
		return WP8FVTFBX1PygaruAwKv == null;
	}
}
