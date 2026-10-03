using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Markup;
using CW;
using HandyControl.Controls;
using log4net;
using Quicker.Domain;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Modules.TextTools;
using Quicker.Public.Actions;
using Quicker.Public.Forms;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;
using Quicker.View.Controls;
using Quicker.View.X;

namespace Quicker.View.Forms;

public class EditFormFieldWindow : System.Windows.Window, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec TZxSdnYBEOy;

		public static Func<FormField, string> Sc0Sd4GIhVZ;

		public static Func<FormField, string> h2mSd52uLyh;

		public static Func<string, bool> rNvSdDP6jVT;

		private static _003C_003Ec QyjZi6WsdX433UM1JUsI;

		static _003C_003Ec()
		{
			TZxSdnYBEOy = new _003C_003Ec();
		}

		internal string j2MSdBg61Xm(FormField x)
		{
			return x.FieldKey;
		}

		internal string A97SdQxLfoc(FormField x)
		{
			return x.Group;
		}

		internal bool RylSdj1wDEb(string x)
		{
			return !x.IsNullOrEmpty();
		}

		internal static bool LipfLyWsOV8At6qDpUaq()
		{
			return QyjZi6WsdX433UM1JUsI == null;
		}

		internal static void O1FTN2Wsk9mQlx8D3oDp()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass12_0
	{
		public string zxrSdoUiNLE;

		private static _003C_003Ec__DisplayClass12_0 xvbL1bWsaff4kbCG0Hrv;

		internal bool SaaSddNLlJC(ActionVariable x)
		{
			return x.Key == zxrSdoUiNLE;
		}

		internal static void fSfqfnWs9ewDED2JTBqe()
		{
		}

		internal static bool s7yNrnWsr67SxFtRBKlR()
		{
			return xvbL1bWsaff4kbCG0Hrv == null;
		}
	}

	private static readonly ILog CNnLqcpt9MO;

	private readonly ObservableCollection<ActionVariable> aODLqV7q13v;

	private readonly IList<FormField> LQ3LqZBHaPE;

	private readonly FormField fQ3Lq9vgjBO;

	private VariableSelector JB4LqhtQIQE;

	[CompilerGenerated]
	private FormField rhvLqeHBdHa;

	internal Grid MainGrid;

	internal ContentControl PnlFields;

	internal TextBoxWithToolsControl TxtLabel;

	internal TextBoxWithToolsControl TxtHelpText;

	internal System.Windows.Controls.ComboBox TxtGroup;

	internal System.Windows.Controls.ComboBox CbInputMethods;

	internal TextBlock LblSelectItems;

	internal StackPanel PnlSelectItems;

	internal TextBoxWithToolsControl TxtSelectItems;

	internal TextBlock LblRange;

	internal StackPanel PnlRange;

	internal System.Windows.Controls.TextBox TxtMin;

	internal System.Windows.Controls.TextBox TxtMax;

	internal TextBlock LblPattern;

	internal StackPanel PnlPattern;

	internal System.Windows.Controls.TextBox TxtPattern;

	internal TextBlock LblMaxLength;

	internal StackPanel PnlMaxLength;

	internal NumericUpDown TxtMaxLength;

	internal TextBlock LblTextTools;

	internal StackPanel PnlTextTools;

	internal TextToolsSelectorControl TextToolsSelector;

	internal TextBlock LblImeState;

	internal TextBoxWithToolsControl TxtVisibleExpression;

	internal TextBlock LblInputWidth;

	internal System.Windows.Controls.TextBox TxtInputWidth;

	internal TextBlock LblExtraSettings;

	internal TextBoxWithToolsControl TxtExtraSettings;

	internal TextBlock LblOtherOptions;

	internal CheckBox ChkIsRequired;

	internal CheckBox ChkOnlyDate;

	internal CheckBox ChkReadOnly;

	internal Button BtnSave;

	internal Button BtnCancel;

	private bool xQ0LqYKvlNZ;

	private static EditFormFieldWindow hkZKYOF1ieXgMi20VHSA;

	public FormField ResultField
	{
		[CompilerGenerated]
		get
		{
			return rhvLqeHBdHa;
		}
		[CompilerGenerated]
		private set
		{
			rhvLqeHBdHa = value;
		}
	}

	public EditFormFieldWindow(ObservableCollection<ActionVariable> variables, IList<FormField> currentFields, FormField editingField)
	{
		aODLqV7q13v = variables;
		LQ3LqZBHaPE = currentFields;
		fQ3Lq9vgjBO = editingField;
		InitializeComponent();
		base.Loaded += Ve3LqPLi4mC;
		JB4LqhtQIQE = new VariableSelector(variables, VarType.Any, editingField?.FieldKey, true, new VarType[7]
		{
			VarType.Text,
			VarType.Boolean,
			VarType.Number,
			VarType.Integer,
			VarType.DateTime,
			VarType.List,
			VarType.Dict
		}, (fQ3Lq9vgjBO == null) ? currentFields.Select(_003C_003Ec.Sc0Sd4GIhVZ ?? (_003C_003Ec.Sc0Sd4GIhVZ = _003C_003Ec.TZxSdnYBEOy.j2MSdBg61Xm)).ToList() : null);
		JB4LqhtQIQE.SelectionChanged += ctvLq0sH68w;
		PnlFields.Content = JB4LqhtQIQE;
		CbInputMethods.ItemsSource = Enum.GetValues(typeof(InputMethod));
		TxtGroup.ItemsSource = currentFields.Select(_003C_003Ec.h2mSd52uLyh ?? (_003C_003Ec.h2mSd52uLyh = _003C_003Ec.TZxSdnYBEOy.A97SdQxLfoc)).Where(_003C_003Ec.rNvSdDP6jVT ?? (_003C_003Ec.rNvSdDP6jVT = _003C_003Ec.TZxSdnYBEOy.RylSdj1wDEb)).Distinct()
			.ToList();
		tsHLqJ8lnKa();
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void tsHLqJ8lnKa()
	{
		TxtLabel.SetVariables(aODLqV7q13v, false);
		TxtSelectItems.SetVariables(aODLqV7q13v, false);
		TxtHelpText.SetVariables(aODLqV7q13v, false);
		TxtVisibleExpression.SetVariables(aODLqV7q13v);
	}

	private void ctvLq0sH68w(object sender, EventArgs e)
	{
		Rc9LqCcBIW7();
		lI7LqaGlBc9();
		string selectedVariableKey = JB4LqhtQIQE.GetSelectedVariableKey();
		TxtLabel.Text = selectedVariableKey ?? "";
		_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
		_003C_003Ec__DisplayClass12_.zxrSdoUiNLE = JB4LqhtQIQE.GetSelectedVariableKey();
		ActionVariable actionVariable = aODLqV7q13v.FirstOrDefault(_003C_003Ec__DisplayClass12_.SaaSddNLlJC);
		TextBoxWithToolsControl txtHelpText = TxtHelpText;
		object obj;
		if (actionVariable == null)
		{
			obj = null;
		}
		else
		{
			obj = actionVariable.Desc;
			if (obj != null)
			{
				goto IL_007f;
			}
		}
		obj = "";
		goto IL_007f;
		IL_007f:
		txtHelpText.Text = (string)obj;
	}

	public static List<InputMethod> GetFieldAllowedInputMethods(VarType? varType)
	{
		List<InputMethod> list = null;
		if (varType.HasValue && varType != VarType.NA)
		{
			switch (varType.Value)
			{
			case VarType.Text:
				return new List<InputMethod>
				{
					InputMethod.TextBox,
					InputMethod.TextEditor,
					InputMethod.DropDown,
					InputMethod.EditableDropDown,
					InputMethod.EditableAutoCompleteDropDown,
					InputMethod.CheckComboBox,
					InputMethod.ColorPicker,
					InputMethod.PasswordBox,
					InputMethod.FontFamilySelector,
					InputMethod.DisplayText
				};
			case VarType.Boolean:
				return new List<InputMethod>
				{
					InputMethod.CheckBox,
					InputMethod.DisplayText
				};
			case VarType.List:
				return new List<InputMethod>
				{
					InputMethod.CheckComboBox,
					InputMethod.TextEditor,
					InputMethod.DisplayText
				};
			case VarType.DateTime:
				return new List<InputMethod>
				{
					InputMethod.DatePicker,
					InputMethod.DisplayText
				};
			case VarType.Dict:
				return new List<InputMethod>
				{
					InputMethod.DictEditor,
					InputMethod.DisplayText
				};
			default:
				return new List<InputMethod>();
			case VarType.Number:
			case VarType.Integer:
				return new List<InputMethod>
				{
					InputMethod.NumberBox,
					InputMethod.Slider,
					InputMethod.DropDown,
					InputMethod.TextBox,
					InputMethod.DisplayText
				};
			}
		}
		return new List<InputMethod> { InputMethod.Separator };
	}

	private void Rc9LqCcBIW7()
	{
		ActionVariable actionVariable;
		if (fQ3Lq9vgjBO != null)
		{
			actionVariable = aODLqV7q13v.FirstOrDefault(H0DLq7JZxvO);
			if (actionVariable == null)
			{
				goto IL_0032;
			}
		}
		else
		{
			actionVariable = JB4LqhtQIQE.GetSelectedVariable();
			if (actionVariable == null)
			{
				goto IL_0032;
			}
		}
		VarType? varType = actionVariable.Type;
		goto IL_0049;
		IL_0049:
		List<InputMethod> fieldAllowedInputMethods = GetFieldAllowedInputMethods(varType);
		int num = 0;
		if (hkZKYOF1ieXgMi20VHSA != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		CbInputMethods.ItemsSource = fieldAllowedInputMethods;
		if (fQ3Lq9vgjBO != null)
		{
			try
			{
				CbInputMethods.SelectedItem = fQ3Lq9vgjBO.InputMethod;
				return;
			}
			catch (Exception ex)
			{
				CNnLqcpt9MO.Warn("设置选中的选项出错：" + ex.Message, ex);
				return;
			}
		}
		if (CbInputMethods.Items.Count > 0)
		{
			CbInputMethods.SelectedIndex = 0;
		}
		return;
		IL_0032:
		varType = null;
		goto IL_0049;
	}

	private void Ve3LqPLi4mC(object sender, RoutedEventArgs e)
	{
		int num;
		if (fQ3Lq9vgjBO != null)
		{
			JB4LqhtQIQE.IsEnabled = false;
			TxtLabel.Text = fQ3Lq9vgjBO.Label;
			TxtHelpText.Text = fQ3Lq9vgjBO.HelpText;
			num = 0;
			if (hkZKYOF1ieXgMi20VHSA == null)
			{
				goto IL_0053;
			}
			goto IL_0192;
		}
		TxtMaxLength.Value = 0.0;
		Rc9LqCcBIW7();
		goto IL_01e1;
		IL_01a4:
		ChkReadOnly.IsChecked = fQ3Lq9vgjBO.ReadOnly;
		Rc9LqCcBIW7();
		goto IL_01e1;
		IL_0192:
		switch (num)
		{
		case 1:
			goto IL_01a4;
		}
		goto IL_0053;
		IL_0053:
		CbInputMethods.SelectedItem = fQ3Lq9vgjBO.InputMethod;
		TxtSelectItems.Text = fQ3Lq9vgjBO.SelectionItems;
		TxtMin.Text = fQ3Lq9vgjBO.MinValue;
		TxtMax.Text = fQ3Lq9vgjBO.MaxValue;
		TxtPattern.Text = fQ3Lq9vgjBO.Pattern;
		TxtMaxLength.Value = fQ3Lq9vgjBO.MaxLength;
		ChkIsRequired.IsChecked = fQ3Lq9vgjBO.IsRequired;
		TxtVisibleExpression.Text = fQ3Lq9vgjBO.VisibleExpression;
		TxtGroup.Text = fQ3Lq9vgjBO.Group;
		TxtInputWidth.Text = fQ3Lq9vgjBO.InputWidth;
		ChkOnlyDate.IsChecked = fQ3Lq9vgjBO.OnlyDate;
		TxtExtraSettings.Text = fQ3Lq9vgjBO.ExtraSettings;
		TextToolsSelector.SetSelectedToolsString(fQ3Lq9vgjBO.TextTools);
		num = 1;
		if (hkZKYOF1ieXgMi20VHSA != null)
		{
			int num2 = default(int);
			num = num2;
		}
		goto IL_0192;
		IL_01e1:
		TxtSelectItems.SetupTools(new List<TextToolType> { TextToolType.EditInCodeWindow });
	}

	private void m8LLqEDKdCj(object sender, RoutedEventArgs e)
	{
		if (LQ3LqZBHaPE.Any(PhfLqRlgToF))
		{
			AppHelper.ShowWarning("此变量已有记录。");
			return;
		}
		if (CbInputMethods.SelectedItem == null)
		{
			AppHelper.ShowWarning("请选择输入方式。");
			if (hkZKYOF1ieXgMi20VHSA != null)
			{
				switch (0)
				{
				}
			}
			return;
		}
		if (string.IsNullOrEmpty(TxtLabel.Text) && (InputMethod)CbInputMethods.SelectedItem != InputMethod.Separator)
		{
			AppHelper.ShowWarning("请填写字段标题。");
			return;
		}
		FormField obj = new FormField
		{
			FieldKey = JB4LqhtQIQE.GetSelectedVariableKey(),
			Label = TxtLabel.Text,
			HelpText = TxtHelpText.Text,
			InputMethod = (InputMethod)CbInputMethods.SelectedItem,
			SelectionItems = (PnlSelectItems.IsVisible ? TxtSelectItems.Text : ""),
			MinValue = (PnlRange.IsVisible ? TxtMin.Text : ""),
			MaxValue = (PnlRange.IsVisible ? TxtMax.Text : ""),
			Pattern = (PnlPattern.IsVisible ? TxtPattern.Text : ""),
			MaxLength = (PnlMaxLength.IsVisible ? ((int)TxtMaxLength.Value) : 0),
			IsRequired = (ChkIsRequired.IsVisible && ChkIsRequired.IsChecked == true),
			TextTools = ((!PnlTextTools.IsVisible) ? string.Empty : TextToolsSelector.GetSelectedToolsString()),
			VisibleExpression = TxtVisibleExpression.Text,
			Group = TxtGroup.Text
		};
		string text = TxtInputWidth.Text;
		object obj2;
		if (text == null)
		{
			obj2 = null;
		}
		else
		{
			obj2 = text.Trim();
			if (obj2 != null)
			{
				goto IL_021e;
			}
		}
		obj2 = "";
		goto IL_021e;
		IL_021e:
		obj.InputWidth = (string)obj2;
		obj.OnlyDate = ChkOnlyDate.IsChecked == true;
		obj.ExtraSettings = TxtExtraSettings.Text;
		obj.ReadOnly = ChkReadOnly.IsChecked == true;
		ResultField = obj;
		base.DialogResult = true;
	}

	private void RuILqyUgiAT(object sender, RoutedEventArgs e)
	{
		base.DialogResult = false;
	}

	private void G71Lq8d8tOA(object sender, SelectionChangedEventArgs e)
	{
		lI7LqaGlBc9();
	}

	private void lI7LqaGlBc9()
	{
		ActionVariable selectedVariable = JB4LqhtQIQE.GetSelectedVariable();
		if (selectedVariable != null)
		{
			InputMethod? obj = ((InputMethod?)CbInputMethods.SelectedItem).GetValueOrDefault();
			TextBlock lblSelectItems = LblSelectItems;
			Visibility visibility = (PnlSelectItems.Visibility = ((!obj.IsEither(InputMethod.DropDown, InputMethod.CheckComboBox, InputMethod.EditableDropDown, InputMethod.EditableAutoCompleteDropDown)) ? Visibility.Collapsed : Visibility.Visible));
			lblSelectItems.Visibility = visibility;
			TextBlock lblRange = LblRange;
			visibility = (PnlRange.Visibility = ((!selectedVariable.Type.IsEither(VarType.Number, VarType.Integer)) ? Visibility.Collapsed : Visibility.Visible));
			lblRange.Visibility = visibility;
			TextBlock lblPattern = LblPattern;
			visibility = (PnlPattern.Visibility = ((!obj.IsEither(InputMethod.TextBox, InputMethod.EditableDropDown, InputMethod.EditableAutoCompleteDropDown, InputMethod.TextEditor)) ? Visibility.Collapsed : Visibility.Visible));
			lblPattern.Visibility = visibility;
			TextBlock lblMaxLength = LblMaxLength;
			visibility = (PnlMaxLength.Visibility = ((!obj.IsEither(InputMethod.TextBox, InputMethod.PasswordBox)) ? Visibility.Collapsed : Visibility.Visible));
			lblMaxLength.Visibility = visibility;
			int num = 0;
			if (hkZKYOF1ieXgMi20VHSA != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			TextBlock lblTextTools = LblTextTools;
			visibility = (PnlTextTools.Visibility = ((!obj.IsEither(InputMethod.TextEditor, InputMethod.TextBox, InputMethod.EditableDropDown)) ? Visibility.Collapsed : Visibility.Visible));
			lblTextTools.Visibility = visibility;
			ChkIsRequired.Visibility = ((!obj.IsEither(InputMethod.TextEditor, InputMethod.DropDown, InputMethod.TextBox, InputMethod.NumberBox, InputMethod.CheckComboBox, InputMethod.EditableDropDown, InputMethod.EditableAutoCompleteDropDown, InputMethod.PasswordBox, InputMethod.FontFamilySelector)) ? Visibility.Collapsed : Visibility.Visible);
			ChkOnlyDate.Visibility = obj.IsEither(InputMethod.DatePicker).ToVisibility();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!xQ0LqYKvlNZ)
		{
			xQ0LqYKvlNZ = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/forms/editformfieldwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num;
		switch (connectionId)
		{
		default:
			xQ0LqYKvlNZ = true;
			break;
		case 1:
			MainGrid = (Grid)target;
			break;
		case 2:
			PnlFields = (ContentControl)target;
			break;
		case 3:
			TxtLabel = (TextBoxWithToolsControl)target;
			break;
		case 4:
			TxtHelpText = (TextBoxWithToolsControl)target;
			num = 1;
			if (g1vLEyF1l63WZwSG5rLN())
			{
				break;
			}
			goto IL_021b;
		case 5:
			TxtGroup = (System.Windows.Controls.ComboBox)target;
			break;
		case 6:
			CbInputMethods = (System.Windows.Controls.ComboBox)target;
			CbInputMethods.SelectionChanged += G71Lq8d8tOA;
			break;
		case 7:
			LblSelectItems = (TextBlock)target;
			break;
		case 8:
			PnlSelectItems = (StackPanel)target;
			break;
		case 9:
			TxtSelectItems = (TextBoxWithToolsControl)target;
			break;
		case 10:
			LblRange = (TextBlock)target;
			break;
		case 11:
			PnlRange = (StackPanel)target;
			break;
		case 12:
			TxtMin = (System.Windows.Controls.TextBox)target;
			break;
		case 13:
			TxtMax = (System.Windows.Controls.TextBox)target;
			break;
		case 14:
			LblPattern = (TextBlock)target;
			break;
		case 15:
			PnlPattern = (StackPanel)target;
			break;
		case 16:
			TxtPattern = (System.Windows.Controls.TextBox)target;
			break;
		case 17:
			LblMaxLength = (TextBlock)target;
			break;
		case 18:
			PnlMaxLength = (StackPanel)target;
			break;
		case 19:
			TxtMaxLength = (NumericUpDown)target;
			break;
		case 20:
			LblTextTools = (TextBlock)target;
			break;
		case 21:
			PnlTextTools = (StackPanel)target;
			break;
		case 22:
			TextToolsSelector = (TextToolsSelectorControl)target;
			break;
		case 23:
			LblImeState = (TextBlock)target;
			break;
		case 24:
			TxtVisibleExpression = (TextBoxWithToolsControl)target;
			break;
		case 25:
			LblInputWidth = (TextBlock)target;
			num = 0;
			if (hkZKYOF1ieXgMi20VHSA == null)
			{
				break;
			}
			goto IL_021b;
		case 26:
			TxtInputWidth = (System.Windows.Controls.TextBox)target;
			break;
		case 27:
			LblExtraSettings = (TextBlock)target;
			break;
		case 28:
			TxtExtraSettings = (TextBoxWithToolsControl)target;
			break;
		case 29:
			LblOtherOptions = (TextBlock)target;
			break;
		case 30:
			ChkIsRequired = (CheckBox)target;
			break;
		case 31:
			ChkOnlyDate = (CheckBox)target;
			break;
		case 32:
			ChkReadOnly = (CheckBox)target;
			break;
		case 33:
			BtnSave = (Button)target;
			BtnSave.Click += m8LLqEDKdCj;
			break;
		case 34:
			{
				BtnCancel = (Button)target;
				BtnCancel.Click += RuILqyUgiAT;
				break;
			}
			IL_021b:
			switch (num)
			{
			case 1:
				break;
			case 2:
				break;
			case 3:
				break;
			}
			break;
		}
	}

	static EditFormFieldWindow()
	{
		CNnLqcpt9MO = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	[CompilerGenerated]
	private bool H0DLq7JZxvO(ActionVariable actionVariable_0)
	{
		return actionVariable_0.Key == fQ3Lq9vgjBO.FieldKey;
	}

	[CompilerGenerated]
	private bool PhfLqRlgToF(FormField formField_2)
	{
		if (formField_2 != fQ3Lq9vgjBO && !string.IsNullOrEmpty(formField_2.FieldKey))
		{
			return formField_2.FieldKey == JB4LqhtQIQE.GetSelectedVariableKey();
		}
		return false;
	}

	internal static bool g1vLEyF1l63WZwSG5rLN()
	{
		return hkZKYOF1ieXgMi20VHSA == null;
	}
}
