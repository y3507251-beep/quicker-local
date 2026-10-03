using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using GuvA3OiyFyyWpKJlb8c;
using HandyControl.Controls;
using Quicker.Actions.XActions.Storage;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Public.Forms;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI.Wpf;
using Quicker.View.Controls;
using Quicker.View.Forms;

namespace Quicker.Modules.Tables;

public class TableFieldEditWindow : System.Windows.Window, IComponentConnector, IMockModalWindow
{
	private readonly TableField x8it2zcgrKR;

	private readonly IList<TableField> YJOtuwFoHrS;

	[CompilerGenerated]
	private TableField jhFtutHwHJv;

	[CompilerGenerated]
	private bool? ojCtug1U3vH;

	internal Grid MainGrid;

	internal System.Windows.Controls.TextBox TxtFieldKey;

	internal System.Windows.Controls.TextBox TxtLabel;

	internal VarTypeSelector CbVarType;

	internal CheckBox ChkIsKey;

	internal CheckBox ChkIsUnique;

	internal CheckBox ChkAutoIncrement;

	internal CheckBox ChkAllowNull;

	internal CheckBox ChkIsSelectFlag;

	internal Row rowExpression;

	internal System.Windows.Controls.TextBox TxtExpression;

	internal System.Windows.Controls.ComboBox CbInputMethods;

	internal StackPanel pnlEditorInfo;

	internal Row rowHelp;

	internal TextBoxWithToolsControl TxtHelpText;

	internal Row PnlSelectItems;

	internal TextBoxWithToolsControl TxtSelectItems;

	internal Row PnlRange;

	internal System.Windows.Controls.TextBox TxtMin;

	internal System.Windows.Controls.TextBox TxtMax;

	internal Row PnlMaxLength;

	internal NumericUpDown TxtMaxLength;

	internal Row PnlPattern;

	internal System.Windows.Controls.TextBox TxtPattern;

	internal TextBoxWithToolsControl TxtDefaultValue;

	internal Row PnlTextTools;

	internal TextToolsSelectorControl TextToolsSelector;

	internal TextBoxWithToolsControl TxtVisibleExpression;

	internal CheckBox ChkIsRequired;

	internal CheckBox ChkShowInList;

	internal NumericUpDown NumColumnWidth;

	internal TextBoxWithToolsControl TxtExtraSettings;

	internal Button BtnSave;

	internal Button BtnCancel;

	private bool yHutuL1fMSg;

	private static TableFieldEditWindow vyLVnqQ2Jjk8cnu158FQ;

	public TableField ResultField
	{
		[CompilerGenerated]
		get
		{
			return jhFtutHwHJv;
		}
		[CompilerGenerated]
		private set
		{
			jhFtutHwHJv = value;
		}
	}

	public bool? Result
	{
		[CompilerGenerated]
		get
		{
			return ojCtug1U3vH;
		}
		[CompilerGenerated]
		set
		{
			ojCtug1U3vH = value;
		}
	}

	public TableFieldEditWindow(TableField editingField, IList<TableField> tableFields)
	{
		x8it2zcgrKR = editingField;
		YJOtuwFoHrS = tableFields;
		InitializeComponent();
		base.Loaded += iatt2TCtl0S;
		CbInputMethods.ItemsSource = Enum.GetValues(typeof(InputMethod));
		CbVarType.SetAllowedTypes(VarType.Integer, VarType.Number, VarType.Text, VarType.Boolean, VarType.DateTime);
	}

	private void iatt2TCtl0S(object sender, RoutedEventArgs e)
	{
		if (x8it2zcgrKR != null)
		{
			TxtFieldKey.Text = x8it2zcgrKR.FieldKey;
			CbVarType.SelectedVarType = x8it2zcgrKR.QuickerVarType;
			TxtLabel.Text = x8it2zcgrKR.Label;
			ChkIsUnique.IsChecked = x8it2zcgrKR.IsUnique;
			ChkIsKey.IsChecked = x8it2zcgrKR.IsKey;
			goto IL_0093;
		}
		CbVarType.SelectedVarType = VarType.Text;
		goto IL_0265;
		IL_0265:
		TxtFieldKey.Focus();
		CWpt2lJpd3M();
		int num = 0;
		if (!zpXjHuQ2ks3LZxh3LJOg())
		{
			goto IL_00f1;
		}
		goto IL_00f5;
		IL_010b:
		TxtExpression.Text = x8it2zcgrKR.ComputeExpression;
		ChkShowInList.IsChecked = x8it2zcgrKR.ShowInList;
		TxtDefaultValue.Text = x8it2zcgrKR.DefaultValue;
		TxtHelpText.Text = x8it2zcgrKR.HelpText;
		CbInputMethods.SelectedItem = x8it2zcgrKR.InputMethod;
		TxtSelectItems.Text = x8it2zcgrKR.SelectionItems;
		TxtMin.Text = x8it2zcgrKR.MinValue;
		TxtMax.Text = x8it2zcgrKR.MaxValue;
		TxtPattern.Text = x8it2zcgrKR.Pattern;
		TxtMaxLength.Value = x8it2zcgrKR.MaxLength;
		ChkIsRequired.IsChecked = x8it2zcgrKR.IsRequired;
		TxtVisibleExpression.Text = x8it2zcgrKR.VisibleExpression;
		TextToolsSelector.SetSelectedToolsString(x8it2zcgrKR.TextTools);
		NumColumnWidth.Value = x8it2zcgrKR.ColumnWidth;
		TxtExtraSettings.Text = x8it2zcgrKR.ExtraSettings;
		goto IL_0265;
		IL_0093:
		ChkAllowNull.IsChecked = x8it2zcgrKR.AllowNull;
		ChkIsSelectFlag.IsChecked = x8it2zcgrKR.IsSelectFlag;
		ChkAutoIncrement.IsChecked = x8it2zcgrKR.AutoIncrement;
		num = 1;
		if (!zpXjHuQ2ks3LZxh3LJOg())
		{
			goto IL_00f1;
		}
		goto IL_00f5;
		IL_00f1:
		int num2 = default(int);
		num = num2;
		goto IL_00f5;
		IL_00f5:
		switch (num)
		{
		case 2:
			break;
		case 1:
			goto IL_010b;
		default:
			bmtt2FD2i1J();
			return;
		}
		goto IL_0093;
	}

	private void wcat2MGNRDC(object sender, RoutedEventArgs e)
	{
		if (TxtFieldKey.EnsureNotEmpty("列名"))
		{
			if (TxtFieldKey.Text.ContainsAny("/", "\\", "[", "]", ".", "{", "}", "(", ")", "?", ">", "<", " "))
			{
				AppHelper.ShowWarning("列名不可包含特殊字符。", true);
			}
			else if (TxtLabel.EnsureNotEmpty("标题"))
			{
				ResultField = new TableField
				{
					FieldKey = TxtFieldKey.Text,
					QuickerVarType = CbVarType.SelectedVarType,
					Label = TxtLabel.Text,
					IsKey = (ChkIsKey.IsChecked == true),
					IsUnique = (ChkIsUnique.IsChecked == true),
					IsSelectFlag = (ChkIsSelectFlag.IsChecked == true),
					AllowNull = (ChkAllowNull.IsChecked == true),
					AutoIncrement = (ChkAutoIncrement.IsChecked == true),
					ComputeExpression = TxtExpression.Text,
					ShowInList = (ChkShowInList.IsChecked == true),
					HelpText = TxtHelpText.Text,
					InputMethod = ((CbInputMethods.SelectedItem != null) ? ((InputMethod)CbInputMethods.SelectedItem) : InputMethod.None),
					SelectionItems = (PnlSelectItems.IsVisible ? TxtSelectItems.Text : ""),
					MinValue = (PnlRange.IsVisible ? TxtMin.Text : ""),
					MaxValue = (PnlRange.IsVisible ? TxtMax.Text : ""),
					Pattern = (PnlPattern.IsVisible ? TxtPattern.Text : ""),
					MaxLength = (PnlMaxLength.IsVisible ? ((int)TxtMaxLength.Value) : 0),
					IsRequired = (ChkIsRequired.IsVisible && ChkIsRequired.IsChecked == true),
					TextTools = (PnlTextTools.IsVisible ? TextToolsSelector.GetSelectedToolsString() : string.Empty),
					VisibleExpression = TxtVisibleExpression.Text,
					DefaultValue = TxtDefaultValue.Text,
					ColumnWidth = NumColumnWidth.Value,
					ExtraSettings = TxtExtraSettings.Text
				};
				this.ThNvuM5Q9GQ(true);
			}
		}
	}

	private void xG7t2AZGLRQ(object sender, RoutedEventArgs e)
	{
		Close();
	}

	private void T5Ht2OL2okm(object sender, RoutedEventArgs e)
	{
		if (string.IsNullOrWhiteSpace(TxtLabel.Text))
		{
			TxtLabel.Text = TxtFieldKey.Text;
		}
	}

	private void bmtt2FD2i1J()
	{
		ChkAllowNull.IsEnabled = ChkIsUnique.IsChecked == false && ChkIsKey.IsChecked == false && ChkAutoIncrement.IsChecked == false;
		if (!ChkAllowNull.IsEnabled)
		{
			ChkAllowNull.IsChecked = false;
		}
		ChkIsSelectFlag.IsEnabled = ChkIsUnique.IsChecked == false && ChkIsKey.IsChecked == false && ChkAutoIncrement.IsChecked == false;
		if (!ChkIsSelectFlag.IsEnabled)
		{
			ChkIsSelectFlag.IsChecked = false;
		}
		rowExpression.Visibility = (ChkIsKey.IsChecked == false && ChkIsUnique.IsChecked == false && ChkAutoIncrement.IsChecked == false && ChkIsSelectFlag.IsChecked == false).ToVisibility();
		if (rowExpression.Visibility == Visibility.Collapsed)
		{
			TxtExpression.Text = "";
		}
		bool? isChecked = ChkIsSelectFlag.IsChecked;
		if (!zpXjHuQ2ks3LZxh3LJOg())
		{
			switch (0)
			{
			}
		}
		if (isChecked == true || !string.IsNullOrEmpty(TxtExpression.Text) || ChkAutoIncrement.IsChecked == true)
		{
			CbInputMethods.SelectedValue = InputMethod.None;
		}
	}

	private void IMat2UtlKlx(object sender, RoutedEventArgs e)
	{
		bmtt2FD2i1J();
	}

	private void CbVarType_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		CWpt2lJpd3M();
	}

	private void CWpt2lJpd3M()
	{
		List<InputMethod> fieldAllowedInputMethods = EditFormFieldWindow.GetFieldAllowedInputMethods(CbVarType.SelectedVarType);
		fieldAllowedInputMethods.Insert(0, InputMethod.None);
		CbInputMethods.ItemsSource = fieldAllowedInputMethods;
		if (x8it2zcgrKR != null)
		{
			try
			{
				CbInputMethods.SelectedItem = x8it2zcgrKR.InputMethod;
				return;
			}
			catch (Exception)
			{
				return;
			}
		}
		if (CbInputMethods.Items.Count > 0)
		{
			CbInputMethods.SelectedIndex = 0;
		}
	}

	private void KDBt2iaHhTT(object sender, SelectionChangedEventArgs e)
	{
		YmSt232XwII();
	}

	private void YmSt232XwII()
	{
		InputMethod? inputMethod = ((InputMethod?)CbInputMethods.SelectedItem).GetValueOrDefault();
		if (inputMethod.HasValue)
		{
			InputMethod? inputMethod2 = inputMethod;
			if (!((inputMethod2.GetValueOrDefault() == InputMethod.None) & inputMethod2.HasValue))
			{
				pnlEditorInfo.Visibility = Visibility.Visible;
				VarType selectedVarType = CbVarType.SelectedVarType;
				Row pnlSelectItems = PnlSelectItems;
				Visibility visibility = (PnlSelectItems.Visibility = ((!inputMethod.IsEither(InputMethod.DropDown, InputMethod.CheckComboBox, InputMethod.EditableDropDown, InputMethod.EditableAutoCompleteDropDown)) ? Visibility.Collapsed : Visibility.Visible));
				pnlSelectItems.Visibility = visibility;
				Row pnlRange = PnlRange;
				visibility = (PnlRange.Visibility = ((!selectedVarType.IsEither(VarType.Number, VarType.Integer)) ? Visibility.Collapsed : Visibility.Visible));
				pnlRange.Visibility = visibility;
				PnlPattern.Visibility = ((!inputMethod.IsEither(InputMethod.TextBox, InputMethod.EditableDropDown, InputMethod.EditableAutoCompleteDropDown, InputMethod.TextEditor)) ? Visibility.Collapsed : Visibility.Visible);
				int num = 0;
				if (vyLVnqQ2Jjk8cnu158FQ != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				Row pnlMaxLength = PnlMaxLength;
				visibility = (PnlMaxLength.Visibility = ((!inputMethod.IsEither(InputMethod.TextBox, InputMethod.PasswordBox)) ? Visibility.Collapsed : Visibility.Visible));
				pnlMaxLength.Visibility = visibility;
				Row pnlTextTools = PnlTextTools;
				visibility = (PnlTextTools.Visibility = ((!inputMethod.IsEither(InputMethod.TextEditor, InputMethod.TextBox)) ? Visibility.Collapsed : Visibility.Visible));
				pnlTextTools.Visibility = visibility;
				ChkIsRequired.Visibility = ((!inputMethod.IsEither(InputMethod.TextEditor, InputMethod.DropDown, InputMethod.TextBox, InputMethod.NumberBox, InputMethod.CheckComboBox, InputMethod.EditableDropDown, InputMethod.EditableAutoCompleteDropDown, InputMethod.PasswordBox, InputMethod.FontFamilySelector)) ? Visibility.Collapsed : Visibility.Visible);
				return;
			}
		}
		pnlEditorInfo.Visibility = Visibility.Collapsed;
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!yHutuL1fMSg)
		{
			yHutuL1fMSg = true;
			Uri resourceLocator = new Uri("/Quicker;component/modules/tables/tablefieldeditwindow.xaml", UriKind.Relative);
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
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num;
		int num2 = default(int);
		switch (connectionId)
		{
		default:
			yHutuL1fMSg = true;
			break;
		case 1:
			MainGrid = (Grid)target;
			break;
		case 2:
			TxtFieldKey = (System.Windows.Controls.TextBox)target;
			TxtFieldKey.LostFocus += T5Ht2OL2okm;
			break;
		case 3:
			TxtLabel = (System.Windows.Controls.TextBox)target;
			break;
		case 4:
			CbVarType = (VarTypeSelector)target;
			break;
		case 5:
			ChkIsKey = (CheckBox)target;
			ChkIsKey.Click += IMat2UtlKlx;
			break;
		case 6:
			ChkIsUnique = (CheckBox)target;
			ChkIsUnique.Click += IMat2UtlKlx;
			break;
		case 7:
			ChkAutoIncrement = (CheckBox)target;
			ChkAutoIncrement.Click += IMat2UtlKlx;
			break;
		case 8:
			ChkAllowNull = (CheckBox)target;
			goto IL_02da;
		case 9:
			ChkIsSelectFlag = (CheckBox)target;
			ChkIsSelectFlag.Click += IMat2UtlKlx;
			break;
		case 10:
			rowExpression = (Row)target;
			break;
		case 11:
			TxtExpression = (System.Windows.Controls.TextBox)target;
			num = 4;
			if (!zpXjHuQ2ks3LZxh3LJOg())
			{
				goto IL_02ba;
			}
			goto IL_02be;
		case 12:
			CbInputMethods = (System.Windows.Controls.ComboBox)target;
			CbInputMethods.SelectionChanged += KDBt2iaHhTT;
			break;
		case 13:
			pnlEditorInfo = (StackPanel)target;
			num = 1;
			if (vyLVnqQ2Jjk8cnu158FQ != null)
			{
				goto IL_02ba;
			}
			goto IL_02be;
		case 14:
			rowHelp = (Row)target;
			break;
		case 15:
			TxtHelpText = (TextBoxWithToolsControl)target;
			break;
		case 16:
			PnlSelectItems = (Row)target;
			break;
		case 17:
			TxtSelectItems = (TextBoxWithToolsControl)target;
			break;
		case 18:
			PnlRange = (Row)target;
			break;
		case 19:
			TxtMin = (System.Windows.Controls.TextBox)target;
			break;
		case 20:
			TxtMax = (System.Windows.Controls.TextBox)target;
			break;
		case 21:
			PnlMaxLength = (Row)target;
			break;
		case 22:
			TxtMaxLength = (NumericUpDown)target;
			break;
		case 23:
			PnlPattern = (Row)target;
			num = 0;
			if (!zpXjHuQ2ks3LZxh3LJOg())
			{
				goto IL_02ba;
			}
			goto IL_02be;
		case 24:
			TxtPattern = (System.Windows.Controls.TextBox)target;
			break;
		case 25:
			TxtDefaultValue = (TextBoxWithToolsControl)target;
			break;
		case 26:
			PnlTextTools = (Row)target;
			num = 2;
			if (vyLVnqQ2Jjk8cnu158FQ != null)
			{
				goto IL_02ba;
			}
			goto IL_02be;
		case 27:
			TextToolsSelector = (TextToolsSelectorControl)target;
			break;
		case 28:
			TxtVisibleExpression = (TextBoxWithToolsControl)target;
			break;
		case 29:
			ChkIsRequired = (CheckBox)target;
			break;
		case 30:
			ChkShowInList = (CheckBox)target;
			break;
		case 31:
			NumColumnWidth = (NumericUpDown)target;
			break;
		case 32:
			TxtExtraSettings = (TextBoxWithToolsControl)target;
			break;
		case 33:
			BtnSave = (Button)target;
			BtnSave.Click += wcat2MGNRDC;
			break;
		case 34:
			{
				BtnCancel = (Button)target;
				BtnCancel.Click += xG7t2AZGLRQ;
				break;
			}
			IL_02ba:
			num = num2;
			goto IL_02be;
			IL_02be:
			switch (num)
			{
			default:
				return;
			case 1:
				return;
			case 2:
				return;
			case 3:
				break;
			case 4:
				return;
			}
			goto IL_02da;
			IL_02da:
			ChkAllowNull.Click += IMat2UtlKlx;
			break;
		}
	}

	internal static bool zpXjHuQ2ks3LZxh3LJOg()
	{
		return vyLVnqQ2Jjk8cnu158FQ == null;
	}
}
