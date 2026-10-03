using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;
using System.Windows.Markup;
using HandyControl.Controls;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Forms;

namespace Quicker.View.Forms.Controls;

public class FormPasswordControl : BaseFormFieldControl, IComponentConnector, IFormControl
{
	private FormField FASLVxuAQjP;

	internal PasswordBox ThePasswordBox;

	private bool wxELVrCNHWs;

	private static FormPasswordControl QR3qLJFBmE7WVGBM6gsF;

	public FormPasswordControl()
	{
		InitializeComponent();
	}

	public void Init(FormField field, ActionVariable variable, IVariableContext context)
	{
		FASLVxuAQjP = field;
		object obj = (context.IsVarExists(field.FieldKey) ? context.GetVarValue(field.FieldKey) : "");
		ThePasswordBox.Password = Convert.ToString(obj);
		ThePasswordBox.Focusable = true;
		if (field.MaxLength > 0)
		{
			ThePasswordBox.MaxLength = field.MaxLength;
		}
	}

	public object GetInputValue()
	{
		return ThePasswordBox.Password ?? "";
	}

	public (bool isValid, string message) Validate()
	{
		if (FASLVxuAQjP.IsRequired && string.IsNullOrEmpty(ThePasswordBox.Password))
		{
			return (isValid: false, message: "请输入内容。");
		}
		return (isValid: true, message: "");
	}

	public void SetFocus()
	{
		ThePasswordBox.MoveFocus(new TraversalRequest(FocusNavigationDirection.Down));
	}

	protected override void OnGotFocus(RoutedEventArgs e)
	{
		if (e.Source == this)
		{
			ThePasswordBox.MoveFocus(new TraversalRequest(FocusNavigationDirection.Down));
		}
		else
		{
			base.OnGotFocus(e);
		}
	}

	public UIElement GetPrimaryElement()
	{
		return ThePasswordBox;
	}

	public void SetInputWidth(double width)
	{
		ThePasswordBox.HorizontalAlignment = HorizontalAlignment.Left;
		ThePasswordBox.Width = width;
	}

	public void UpdateValue(object value)
	{
		ThePasswordBox.Password = Convert.ToString(value);
	}

	public void SetReadOnly(bool isReadOnly)
	{
		ThePasswordBox.IsEnabled = !isReadOnly;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!wxELVrCNHWs)
		{
			wxELVrCNHWs = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/forms/controls/formpasswordcontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 1)
		{
			ThePasswordBox = (PasswordBox)target;
		}
		else
		{
			wxELVrCNHWs = true;
		}
	}

	static FormPasswordControl()
	{
	}

	internal static bool AX3wJTFBsqvNnRYaln4a()
	{
		return QR3qLJFBmE7WVGBM6gsF == null;
	}

	internal static void dJN6AgFBhTdxuWr6FuGc()
	{
	}
}
