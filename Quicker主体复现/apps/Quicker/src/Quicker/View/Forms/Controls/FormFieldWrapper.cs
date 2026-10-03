using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using log4net;
using MdXaml;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Extensions;
using Quicker.Public.Forms;
using Quicker.Utilities;

namespace Quicker.View.Forms.Controls;

public class FormFieldWrapper : BaseFormFieldControl, IComponentConnector, IUpdatableFieldControl
{
	private static readonly ILog njjLV1vB5HT;

	public static readonly DependencyProperty LabelHorizontalAlignmentProperty;

	public static readonly DependencyProperty LabelColWidthProperty;

	[CompilerGenerated]
	private FormField qTALVbsjvp3;

	internal FormFieldWrapper TheControl;

	internal Grid FieldGrid;

	internal Label LblLabel;

	internal StackPanel Wrapper;

	internal ContentControl PnlFieldEditor;

	internal TextBlock TxtError;

	internal TextBlock LblHelp;

	private bool CSHLV6BnVJx;

	private static FormFieldWrapper mTZXteFBLESg8S1NGFqX;

	public HorizontalAlignment LabelHorizontalAlignment
	{
		get
		{
			return (HorizontalAlignment)GetValue(LabelHorizontalAlignmentProperty);
		}
		set
		{
			SetValue(LabelHorizontalAlignmentProperty, value);
		}
	}

	public GridLength LabelColWidth
	{
		get
		{
			return (GridLength)GetValue(LabelColWidthProperty);
		}
		set
		{
			SetValue(LabelColWidthProperty, value);
		}
	}

	public FormField Field
	{
		[CompilerGenerated]
		get
		{
			return qTALVbsjvp3;
		}
		[CompilerGenerated]
		private set
		{
			qTALVbsjvp3 = value;
		}
	}

	public static void SetLabelHorizontalAlignment(DependencyObject element, HorizontalAlignment value)
	{
		element.SetValue(LabelHorizontalAlignmentProperty, value);
	}

	public static HorizontalAlignment GetLabelHorizontalAlignment(DependencyObject element)
	{
		return (HorizontalAlignment)element.GetValue(LabelHorizontalAlignmentProperty);
	}

	public static void SetLabelColWidth(DependencyObject element, GridLength value)
	{
		element.SetValue(LabelColWidthProperty, value);
	}

	public static GridLength GetLabelColWidth(DependencyObject element)
	{
		return (GridLength)element.GetValue(LabelColWidthProperty);
	}

	public FormFieldWrapper()
	{
		InitializeComponent();
	}

	public void Init(FormField field, ActionVariable variable, IVariableContext context, double defaultInputWidth = 0.0)
	{
		Field = field;
		if (PnlFieldEditor.Content != null)
		{
			try
			{
				((IFormControl)PnlFieldEditor.Content).Init(field, variable, context);
				return;
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("初始化字段" + field.Label + "出错：" + ex.Message);
				return;
			}
		}
		string text = field.Label;
		if (text.IsExpressionOrInterpolation())
		{
			try
			{
				text = XActionHelper.InterpolateOrEvalToString((ActionExecuteContext)context, text);
			}
			catch (Exception ex2)
			{
				njjLV1vB5HT.Warn("字段 " + field.Label + " 标签解析出错:" + ex2.Message + " 原始表达式：" + text, ex2);
				text = "(解析出错)" + field.Label;
			}
		}
		LblLabel.Content = new AccessText
		{
			Text = text
		};
		int num = 1;
		if (mTZXteFBLESg8S1NGFqX != null)
		{
			goto IL_0197;
		}
		goto IL_019b;
		IL_0197:
		int num2 = default(int);
		num = num2;
		goto IL_019b;
		IL_019b:
		IFormControl formControl = default(IFormControl);
		while (true)
		{
			switch (num)
			{
			case 1:
				if (field.InputMethod == Quicker.Public.Forms.InputMethod.CheckBox)
				{
					LblLabel.Visibility = Visibility.Collapsed;
				}
				UpdateHelpText(context);
				formControl = null;
				switch (field.InputMethod)
				{
				case Quicker.Public.Forms.InputMethod.ColorPicker:
					break;
				case Quicker.Public.Forms.InputMethod.EditableAutoCompleteDropDown:
					goto IL_0183;
				default:
					throw new InvalidOperationException("不支持的输入方式：" + field.InputMethod);
				case Quicker.Public.Forms.InputMethod.DisplayText:
					goto IL_01e5;
				case Quicker.Public.Forms.InputMethod.TextEditor:
					goto IL_01ee;
				case Quicker.Public.Forms.InputMethod.DropDown:
					goto IL_01f7;
				case Quicker.Public.Forms.InputMethod.Slider:
					goto IL_0200;
				case Quicker.Public.Forms.InputMethod.CheckBox:
					goto IL_0209;
				case Quicker.Public.Forms.InputMethod.NumberBox:
					goto IL_0212;
				case Quicker.Public.Forms.InputMethod.CheckComboBox:
					goto IL_021b;
				case Quicker.Public.Forms.InputMethod.PasswordBox:
					goto IL_0224;
				case Quicker.Public.Forms.InputMethod.EditableDropDown:
					goto IL_022d;
				case Quicker.Public.Forms.InputMethod.FontFamilySelector:
					goto IL_0236;
				case Quicker.Public.Forms.InputMethod.DictEditor:
					goto IL_023f;
				case Quicker.Public.Forms.InputMethod.TextBox:
					goto IL_0248;
				case Quicker.Public.Forms.InputMethod.DatePicker:
					goto IL_0251;
				}
				formControl = new FormColorSelectorControl();
				num = 3;
				if (mTZXteFBLESg8S1NGFqX == null)
				{
					continue;
				}
				break;
			default:
				goto IL_0200;
			case 2:
				goto IL_0248;
			case 5:
				goto IL_0251;
			case 3:
			case 4:
				{
					if (formControl is BaseFormFieldControl baseFormFieldControl)
					{
						baseFormFieldControl.ValueChanged += ETeLVWNIlC5;
					}
					PnlFieldEditor.Content = formControl;
					try
					{
						formControl.Init(field, variable, context);
					}
					catch (Exception ex3)
					{
						AppHelper.ShowWarning("初始化字段" + field.Label + "出错：" + ex3.Message);
					}
					UIElement primaryElement = formControl.GetPrimaryElement();
					LblLabel.Target = primaryElement;
					double num3 = defaultInputWidth;
					if (!field.InputWidth.IsNullOrEmpty())
					{
						try
						{
							num3 = Convert.ToDouble(field.InputWidth);
						}
						catch (Exception)
						{
							AppHelper.ShowWarning(field.Label + " 字段的宽度设置不是合法的值(" + field.InputWidth + ")。");
						}
					}
					if (num3 > 1.0)
					{
						formControl.SetInputWidth(num3);
					}
					return;
				}
				IL_0183:
				formControl = new FormEditWithAutoCompleteDropdownControl();
				num = 4;
				if (mTZXteFBLESg8S1NGFqX == null)
				{
					continue;
				}
				break;
				IL_0251:
				formControl = new FormDatePickerControl();
				goto case 3;
				IL_0248:
				formControl = new FormTextBoxControl();
				goto case 3;
				IL_023f:
				formControl = new FormDictEditorControl();
				goto case 3;
				IL_0236:
				formControl = new FormFontFamilySelector();
				goto case 3;
				IL_022d:
				formControl = new FormEditWithDropdownControl();
				goto case 3;
				IL_0224:
				formControl = new FormPasswordControl();
				goto case 3;
				IL_021b:
				formControl = new FormCheckComboBoxControl();
				goto case 3;
				IL_0212:
				formControl = new FormNumberBox();
				goto case 3;
				IL_0209:
				formControl = new FormCheckboxControl();
				goto case 3;
				IL_0200:
				formControl = new FormSliderControl();
				goto case 3;
				IL_01f7:
				formControl = new FormDropdownControl();
				goto case 3;
				IL_01ee:
				formControl = new FormTextEditorControl();
				goto case 3;
				IL_01e5:
				formControl = new FormDisplayControl();
				goto case 3;
			}
			break;
		}
		goto IL_0197;
	}

	public void UpdateHelpText(IVariableContext context)
	{
		FormField field = Field;
		string text = field.HelpText;
		if (text.IsExpressionOrInterpolation())
		{
			string text2 = text;
			try
			{
				text = XActionHelper.InterpolateOrEvalToString((ActionExecuteContext)context, text2);
			}
			catch (Exception ex)
			{
				njjLV1vB5HT.Warn("字段 " + field.Label + " 帮助文本解析出错:" + ex.Message + " 原始表达式：" + text2, ex);
				text = "(解析出错)" + text2;
			}
		}
		int num;
		if (!string.IsNullOrEmpty(text))
		{
			if (!text.StartsWith("MD:", StringComparison.Ordinal))
			{
				LblHelp.Text = text;
				LblHelp.Visibility = Visibility.Visible;
				return;
			}
			LblHelp.Visibility = Visibility.Collapsed;
			bool flag = false;
			foreach (object child in Wrapper.Children)
			{
				if (child is MarkdownScrollViewer markdownScrollViewer)
				{
					markdownScrollViewer.Markdown = text.Substring(3);
					flag = true;
				}
			}
			if (flag)
			{
				return;
			}
			num = 0;
			if (!BbE39mFBujNyo1UP9tdP())
			{
				goto IL_0155;
			}
		}
		else
		{
			LblHelp.Visibility = Visibility.Collapsed;
			num = 1;
			if (!BbE39mFBujNyo1UP9tdP())
			{
				goto IL_0155;
			}
		}
		goto IL_0159;
		IL_0159:
		switch (num)
		{
		case 1:
			return;
		}
		MarkdownScrollViewer markdownScrollViewer2 = new MarkdownScrollViewer();
		markdownScrollViewer2.MarkdownStyle = TryFindResource("MarkdownNoteStyle") as Style;
		Wrapper.Children.Add(markdownScrollViewer2);
		markdownScrollViewer2.Markdown = text.Substring(3);
		return;
		IL_0155:
		int num2 = default(int);
		num = num2;
		goto IL_0159;
	}

	private void ETeLVWNIlC5(object object_0, FormField formField_1)
	{
		TriggerValueChange(formField_1);
	}

	public object GetInputValue()
	{
		return (PnlFieldEditor.Content as IFormControl)?.GetInputValue();
	}

	public bool IsReadonly()
	{
		return PnlFieldEditor.Content is IReadonlyFormControl;
	}

	public (bool isValid, string message) Validate()
	{
		if (PnlFieldEditor.Content is IFormControl formControl)
		{
			(bool, string) result = formControl.Validate();
			if (result.Item1)
			{
				TxtError.Visibility = Visibility.Collapsed;
			}
			else
			{
				TxtError.Visibility = Visibility.Visible;
				TxtError.Text = result.Item2;
			}
			return result;
		}
		return (isValid: true, message: "");
	}

	public void SetFocus()
	{
		(PnlFieldEditor.Content as IFormControl)?.SetFocus();
	}

	public UIElement GetPrimaryElement()
	{
		return (PnlFieldEditor.Content as IFormControl)?.GetPrimaryElement();
	}

	public void SetInputWidth(double width)
	{
		(PnlFieldEditor.Content as IFormControl)?.SetInputWidth(width);
	}

	private void r2aLVkXff31(object sender, KeyEventArgs e)
	{
		if (e.Key == Key.Tab && rf2LVsUuWUI())
		{
			TovLVGkasBx(e, FocusNavigationDirection.Down);
		}
		if (e.Key == Key.Tab && (Keyboard.Modifiers & ModifierKeys.Shift) == ModifierKeys.Shift)
		{
			TovLVGkasBx(e, FocusNavigationDirection.Up);
			e.Handled = true;
			if (BbE39mFBujNyo1UP9tdP())
			{
				switch (0)
				{
				}
			}
		}
		if (e.Key == Key.Up && rf2LVsUuWUI())
		{
			TovLVGkasBx(e, FocusNavigationDirection.Up);
		}
		else if (e.Key == Key.Down && rf2LVsUuWUI())
		{
			TovLVGkasBx(e, FocusNavigationDirection.Down);
		}
	}

	private static void TovLVGkasBx(KeyEventArgs keyEventArgs_0, FocusNavigationDirection focusNavigationDirection_0)
	{
		keyEventArgs_0.Handled = true;
		if (keyEventArgs_0.OriginalSource is UIElement uIElement)
		{
			uIElement.MoveFocus(new TraversalRequest(focusNavigationDirection_0));
		}
	}

	private static bool rf2LVsUuWUI()
	{
		return Keyboard.Modifiers == ModifierKeys.Control;
	}

	public bool IsShouldUpdate()
	{
		if (!Field.ExtraSettings.HasLineStartWith("compute:"))
		{
			return (PnlFieldEditor.Content as IUpdatableFieldControl)?.IsShouldUpdate() ?? false;
		}
		return true;
	}

	public void Update(IVariableContext context)
	{
		(PnlFieldEditor.Content as IUpdatableFieldControl)?.Update(context);
	}

	public void UpdateValue(object value)
	{
		(PnlFieldEditor.Content as IFormControl)?.UpdateValue(value);
	}

	public void SetReadOnly(bool isReadOnly)
	{
		(PnlFieldEditor.Content as IFormControl)?.SetReadOnly(isReadOnly);
	}

	public void SetError(string title, string errorMessage)
	{
		if (string.IsNullOrEmpty(title))
		{
			TxtError.Visibility = Visibility.Collapsed;
			return;
		}
		TxtError.Visibility = Visibility.Visible;
		TxtError.Text = title;
		TxtError.ToolTip = errorMessage;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!CSHLV6BnVJx)
		{
			CSHLV6BnVJx = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/forms/controls/formfieldwrapper.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			CSHLV6BnVJx = true;
			break;
		case 1:
			TheControl = (FormFieldWrapper)target;
			break;
		case 2:
			FieldGrid = (Grid)target;
			FieldGrid.PreviewKeyDown += r2aLVkXff31;
			if (!BbE39mFBujNyo1UP9tdP())
			{
				switch (0)
				{
				}
			}
			break;
		case 3:
			LblLabel = (Label)target;
			break;
		case 4:
			Wrapper = (StackPanel)target;
			break;
		case 5:
			PnlFieldEditor = (ContentControl)target;
			break;
		case 6:
			TxtError = (TextBlock)target;
			break;
		case 7:
			LblHelp = (TextBlock)target;
			break;
		}
	}

	static FormFieldWrapper()
	{
		njjLV1vB5HT = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		LabelHorizontalAlignmentProperty = DependencyProperty.RegisterAttached("LabelHorizontalAlignment", typeof(HorizontalAlignment), typeof(FormFieldWrapper), new FrameworkPropertyMetadata(HorizontalAlignment.Left, FrameworkPropertyMetadataOptions.Inherits));
		LabelColWidthProperty = DependencyProperty.RegisterAttached("LabelColWidth", typeof(GridLength), typeof(FormFieldWrapper), new FrameworkPropertyMetadata(GridLength.Auto, FrameworkPropertyMetadataOptions.Inherits));
	}

	internal static bool BbE39mFBujNyo1UP9tdP()
	{
		return mTZXteFBLESg8S1NGFqX == null;
	}

	internal static void qR7kc9FBf5R4wGgDCXyn()
	{
	}
}
