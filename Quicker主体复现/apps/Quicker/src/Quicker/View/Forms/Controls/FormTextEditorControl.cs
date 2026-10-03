using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Markup;
using log4net;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Actions.X.Variables;
using Quicker.Modules.TextTools;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Public.Forms;
using Quicker.Utilities.Ext;
using Quicker.View.Controls;

namespace Quicker.View.Forms.Controls;

public class FormTextEditorControl : BaseFormFieldControl, IComponentConnector, ITextControl, IFormControl
{
	private static readonly ILog sGbLVjOWajc;

	private FormField gghLVny2qaA;

	private string taxLV4M8Aki;

	private ActionVariable uQ0LV50mQjl;

	private IVariableContext Lj0LVDy46jK;

	private bool us5LVdDwSls;

	internal TextBoxWithToolsControl TxtEditor;

	private bool QD8LVovhlZE;

	internal static FormTextEditorControl oC8ZU9FBHBhYjOSRJQbk;

	public FormTextEditorControl()
	{
		InitializeComponent();
		TxtEditor.LostFocus += FNGLVBfRaMg;
		TxtEditor.TextChanged += z5jLVpv5nb6;
	}

	private void z5jLVpv5nb6(object sender, EventArgs e)
	{
		if (us5LVdDwSls)
		{
			TriggerValueChange(gghLVny2qaA);
		}
	}

	private void FNGLVBfRaMg(object sender, RoutedEventArgs e)
	{
		if (taxLV4M8Aki != TxtEditor.Text)
		{
			TriggerValueChange(gghLVny2qaA);
		}
	}

	public void Init(FormField field, ActionVariable variable, IVariableContext context)
	{
		gghLVny2qaA = field;
		uQ0LV50mQjl = variable;
		Lj0LVDy46jK = context;
		object value = (context.IsVarExists(field.FieldKey) ? context.GetVarValue(field.FieldKey) : "");
		int num = 0;
		if (oC8ZU9FBHBhYjOSRJQbk != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		UpdateValue(value);
		us5LVdDwSls = field.ExtraSettings.HasLineStartWith("notify_on_change");
		double initialHeight = 40.0;
		string lineStartWith = field.ExtraSettings.GetLineStartWith("height:");
		if (!lineStartWith.IsNullOrWhiteSpace() && double.TryParse(lineStartWith.Substring("height:".Length), out var result))
		{
			initialHeight = Math.Max(20.0, result);
		}
		TxtEditor.SetInitialHeight(initialHeight);
		F5QLVQEeuVZ();
	}

	private void F5QLVQEeuVZ()
	{
		if (!string.IsNullOrEmpty(gghLVny2qaA.TextTools))
		{
			TxtEditor.SetupTools(gghLVny2qaA.TextTools.ParseToolsString(), null, Lj0LVDy46jK as ActionExecuteContext);
		}
		else
		{
			TxtEditor.SetupTools(new List<TextToolType>(), null, Lj0LVDy46jK as ActionExecuteContext);
		}
		if (!string.IsNullOrEmpty(gghLVny2qaA.ExtraSettings))
		{
			TxtEditor.ProcessExtraSettings(gghLVny2qaA.ExtraSettings);
		}
	}

	public object GetInputValue()
	{
		return VariableHelper.ConvertToType(uQ0LV50mQjl.Type, TxtEditor.Text);
	}

	public (bool isValid, string message) Validate()
	{
		if (gghLVny2qaA.IsRequired && string.IsNullOrEmpty(TxtEditor.Text))
		{
			return (isValid: false, message: "请输入内容。");
		}
		if (!string.IsNullOrEmpty(gghLVny2qaA.Pattern) && !string.IsNullOrEmpty(TxtEditor.Text))
		{
			try
			{
				if (!Regex.IsMatch(TxtEditor.Text, gghLVny2qaA.Pattern))
				{
					return (isValid: false, message: "内容格式不符合要求。");
				}
			}
			catch (Exception exception)
			{
				return (isValid: false, message: "匹配出错：" + exception.GetMessageWithInner());
			}
		}
		return (isValid: true, message: "");
	}

	public void SetFocus()
	{
		TxtEditor.Focus();
	}

	public UIElement GetPrimaryElement()
	{
		return TxtEditor;
	}

	public void SetInputWidth(double width)
	{
		TxtEditor.HorizontalAlignment = HorizontalAlignment.Left;
		TxtEditor.Width = width;
	}

	public void UpdateValue(object value)
	{
		taxLV4M8Aki = VariableHelper.ConvertToType(VarType.Text, value).ToString();
		TxtEditor.Text = taxLV4M8Aki;
	}

	public void SetReadOnly(bool isReadOnly)
	{
		TxtEditor.TxtEditor.IsReadOnly = isReadOnly;
	}

	public string GetAllText()
	{
		return TxtEditor.Text;
	}

	public string GetSelectedText()
	{
		return TxtEditor.TxtEditor.SelectedText;
	}

	public IList<ActionVariable> GetActionVariables()
	{
		return null;
	}

	public void SetAllText(string text)
	{
		TxtEditor.Text = text;
	}

	public void SetSelectedText(string text)
	{
		TxtEditor.TxtEditor.SelectedText = text;
	}

	public void MoveCaretToEnd()
	{
		TxtEditor.MoveCaretToEnd();
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!QD8LVovhlZE)
		{
			QD8LVovhlZE = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/forms/controls/formtexteditorcontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 1)
		{
			TxtEditor = (TextBoxWithToolsControl)target;
		}
		else
		{
			QD8LVovhlZE = true;
		}
	}

	static FormTextEditorControl()
	{
		sGbLVjOWajc = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool PUssmMFBzuKV1ITGEcK6()
	{
		return oC8ZU9FBHBhYjOSRJQbk == null;
	}
}
