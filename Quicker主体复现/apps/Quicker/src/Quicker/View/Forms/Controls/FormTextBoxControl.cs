using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using log4net;
using Quicker.Common;
using Quicker.Domain;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Actions.X.Variables;
using Quicker.Modules.TextTools;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Public.Forms;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.View.Controls;

namespace Quicker.View.Forms.Controls;

public class FormTextBoxControl : BaseFormFieldControl, IComponentConnector, ITextControl, IFormControl
{
	private static readonly ILog GXJLZtiLoaC;

	private FormField f70LZgYV1AO;

	private string LVxLZLKCMdG;

	private ActionVariable jO6LZvuLYSU;

	private IVariableContext KU2LZSavmma;

	private TextToolsReplaceMode? yReLZ2xcAgr;

	internal Grid GridWrapper;

	internal Grid TxtWrapper;

	internal TextBox TxtValue;

	internal TextToolsControl TextTools;

	internal IconControl ImgIcon;

	internal TextBlock TextActionTitle;

	private bool cOPLZuDHiEx;

	internal static FormTextBoxControl B9qmdsFvdFRY5f4bprSJ;

	public FormTextBoxControl()
	{
		InitializeComponent();
		TxtValue.TextChanged += Xh8LViAAkoP;
	}

	public void SetTextValue(string value)
	{
		TxtValue.Text = value;
	}

	public void Init(FormField field, ActionVariable variable, IVariableContext context)
	{
		f70LZgYV1AO = field;
		jO6LZvuLYSU = variable;
		KU2LZSavmma = context;
		object obj;
		if (context.IsVarExists(field.FieldKey))
		{
			int num = 0;
			if (B9qmdsFvdFRY5f4bprSJ != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			obj = context.GetVarValue(field.FieldKey);
		}
		else
		{
			obj = "";
		}
		object obj2 = obj;
		LVxLZLKCMdG = Convert.ToString(obj2) ?? "";
		TxtValue.Text = LVxLZLKCMdG.RemoveNewLine();
		if (field.MaxLength > 0)
		{
			TxtValue.MaxLength = field.MaxLength;
		}
		yySLVfxObsY();
	}

	private void Xh8LViAAkoP(object sender, TextChangedEventArgs e)
	{
		if (f70LZgYV1AO.TextTools.ContainsAny(TextToolType.SelectActionId.ToString(), TextToolType.SelectActionName.ToString()))
		{
			CxdLV3LMwu5();
		}
		TriggerValueChange(f70LZgYV1AO);
	}

	private void CxdLV3LMwu5()
	{
		(ActionItem, string) tuple = AppState.DataService.QHmtXwg81eY(TxtValue.Text);
		if (tuple.Item1 != null)
		{
			ImgIcon.Icon = tuple.Item1.Icon;
			TextActionTitle.Text = tuple.Item1.Title;
			TextActionTitle.Foreground = (TryFindResource("PrimaryTextBrush") as Brush) ?? Brushes.DarkGray;
		}
		else
		{
			ImgIcon.Icon = null;
			TextActionTitle.Text = tuple.Item2;
			TextActionTitle.Foreground = Brushes.Red;
		}
	}

	private void yySLVfxObsY()
	{
		if (!string.IsNullOrEmpty(f70LZgYV1AO.TextTools))
		{
			TextTools.SetupTools(false, f70LZgYV1AO.TextTools.ParseToolsString(), this, new TextToolsContextHint(), null, KU2LZSavmma as ActionExecuteContext);
		}
		else
		{
			TextTools.SetupTools(false, Array.Empty<TextToolType>(), this, new TextToolsContextHint(), null, KU2LZSavmma as ActionExecuteContext);
		}
		if (!string.IsNullOrEmpty(f70LZgYV1AO.ExtraSettings))
		{
			string[] array = f70LZgYV1AO.ExtraSettings.SplitToList();
			try
			{
				iP0LVzKPqkw(array);
			}
			catch (Exception ex)
			{
				GXJLZtiLoaC.Warn("字段扩展设置解析出错：" + ex.Message + "。数据：" + f70LZgYV1AO.ExtraSettings, ex);
				AppHelper.ShowWarning("字段扩展设置解析出错：" + ex.Message);
			}
			yReLZ2xcAgr = TextToolsControl.Bu8tLMnxv81(array);
		}
	}

	internal void iP0LVzKPqkw(string[] string_1)
	{
		IList<TextToolItem> list = TextToolsControl.hgdtLTVZCx6(string_1);
		if (list.HasData())
		{
			TextTools.AddExtraTools(list);
		}
	}

	public object GetInputValue()
	{
		try
		{
			return VariableHelper.ConvertToType(jO6LZvuLYSU.Type, TxtValue.Text);
		}
		catch (Exception exception)
		{
			AppHelper.ShowWarning("转换格式出错：" + exception.GetMessageWithInner());
			return VariableHelper.ConvertVarDefaultValue(jO6LZvuLYSU.Type, "");
		}
	}

	public (bool isValid, string message) Validate()
	{
		if (f70LZgYV1AO.IsRequired && string.IsNullOrEmpty(TxtValue.Text))
		{
			return (isValid: false, message: "请输入内容。");
		}
		if (!string.IsNullOrEmpty(f70LZgYV1AO.Pattern) && !string.IsNullOrEmpty(TxtValue.Text))
		{
			try
			{
				if (!Regex.IsMatch(TxtValue.Text, f70LZgYV1AO.Pattern))
				{
					return (isValid: false, message: "内容格式不符合要求。");
				}
			}
			catch (Exception exception)
			{
				return (isValid: false, message: "匹配出错：" + exception.GetMessageWithInner());
			}
		}
		try
		{
			object value = VariableHelper.ConvertToType(jO6LZvuLYSU.Type, TxtValue.Text);
			bool flag = true;
			if (!string.IsNullOrEmpty(f70LZgYV1AO.MinValue))
			{
				switch (jO6LZvuLYSU.Type)
				{
				case VarType.DateTime:
					flag = Convert.ToDateTime(f70LZgYV1AO.MinValue) <= Convert.ToDateTime(value);
					break;
				case VarType.Number:
				case VarType.Integer:
					flag = Convert.ToDouble(f70LZgYV1AO.MinValue) <= Convert.ToDouble(value);
					break;
				}
			}
			if (!string.IsNullOrEmpty(f70LZgYV1AO.MaxValue))
			{
				switch (jO6LZvuLYSU.Type)
				{
				case VarType.DateTime:
					flag = Convert.ToDateTime(f70LZgYV1AO.MaxValue) >= Convert.ToDateTime(value);
					break;
				case VarType.Number:
				case VarType.Integer:
					flag = Convert.ToDouble(f70LZgYV1AO.MaxValue) >= Convert.ToDouble(value);
					break;
				}
			}
			if (!flag)
			{
				return (isValid: false, message: "输入的值不再许可范围内。(" + f70LZgYV1AO.MinValue + " - " + f70LZgYV1AO.MaxValue + ")");
			}
		}
		catch (Exception)
		{
			return (isValid: false, message: "输入内容的格式不正确。");
		}
		try
		{
			VariableHelper.ConvertToType(jO6LZvuLYSU.Type, TxtValue.Text);
		}
		catch (Exception ex2)
		{
			return (isValid: false, message: "输入内容不合法。" + ex2.Message);
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
		TxtWrapper.HorizontalAlignment = HorizontalAlignment.Left;
		TxtWrapper.Width = width;
	}

	public void UpdateValue(object value)
	{
		TxtValue.Text = Convert.ToString(value) ?? "";
	}

	public void SetReadOnly(bool isReadOnly)
	{
		TxtValue.IsReadOnly = isReadOnly;
	}

	private void gsgLZwEu6nL(object sender, TextSelectedEventArgs e)
	{
		TxtValue.Text = e.Value;
	}

	private void TextToolsControl_OnValueSelected(object sender, TextSelectedEventArgs e)
	{
		if (yReLZ2xcAgr.HasValue)
		{
			TextToolsControl.UpdateTextValueWithReplaceMode(this, yReLZ2xcAgr.Value, e.Value);
		}
		else if (e.IsFullContent)
		{
			TxtValue.Text = e.Value;
		}
		else if (string.IsNullOrEmpty(TxtValue.SelectedText))
		{
			TxtValue.Text = e.Value;
		}
		else
		{
			TxtValue.SelectedText = e.Value;
		}
	}

	public string GetAllText()
	{
		return TxtValue.Text;
	}

	public string GetSelectedText()
	{
		return TxtValue.SelectedText;
	}

	public IList<ActionVariable> GetActionVariables()
	{
		return null;
	}

	public void SetAllText(string text)
	{
		TxtValue.Text = text;
	}

	public void SetSelectedText(string text)
	{
		TxtValue.SelectedText = text;
	}

	public void MoveCaretToEnd()
	{
		TxtValue.CaretIndex = TxtValue.Text?.Length ?? 0;
		TxtValue.ScrollToEnd();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!cOPLZuDHiEx)
		{
			cOPLZuDHiEx = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/forms/controls/formtextboxcontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			cOPLZuDHiEx = true;
			break;
		case 1:
			GridWrapper = (Grid)target;
			break;
		case 2:
			TxtWrapper = (Grid)target;
			break;
		case 3:
			TxtValue = (TextBox)target;
			break;
		case 4:
			TextTools = (TextToolsControl)target;
			break;
		case 5:
			ImgIcon = (IconControl)target;
			break;
		case 6:
		{
			TextActionTitle = (TextBlock)target;
			int num = 0;
			if (B9qmdsFvdFRY5f4bprSJ != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			break;
		}
		}
	}

	static FormTextBoxControl()
	{
		GXJLZtiLoaC = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool T7fmqkFvOdfSUWOrOa21()
	{
		return B9qmdsFvdFRY5f4bprSJ == null;
	}
}
