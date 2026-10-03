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
using Quicker.Public.Actions;
using Quicker.Public.Forms;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;
using Quicker.View.Controls;
using Quicker.View.X;

namespace Quicker.View.Forms;

public class EditFormFieldWindowForDict : System.Windows.Window, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec xFRSdxpYLtv;

		public static Func<FormField, string> qBjSdrneA1v;

		public static Func<string, bool> uBISdplOJos;

		internal static _003C_003Ec g4lB8GWsKkOPMl9TjURd;

		static _003C_003Ec()
		{
			xFRSdxpYLtv = new _003C_003Ec();
		}

		internal string PUxSdmCqvbR(FormField x)
		{
			return x.Group;
		}

		internal bool tnpSdKjqcfj(string x)
		{
			return !x.IsNullOrEmpty();
		}

		internal static bool BFxg4TWsBX1XoEo8KkPP()
		{
			return g4lB8GWsKkOPMl9TjURd == null;
		}
	}

	private static readonly ILog YURLqLmYxLA;

	private readonly IList<FormField> ihhLqvZLYO2;

	private readonly FormField qgbLqSxa3kf;

	private readonly ObservableCollection<VarTypeItem> oDoLq2FWkWk = new ObservableCollection<VarTypeItem>();

	[CompilerGenerated]
	private FormField TOeLquYvKuq;

	internal Grid MainGrid;

	internal System.Windows.Controls.TextBox TxtDictKey;

	internal System.Windows.Controls.ComboBox CbDictValueType;

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

	internal TextBlock LblOtherOptions;

	internal CheckBox ChkIsRequired;

	internal CheckBox ChkOnlyDate;

	internal CheckBox ChkReadOnly;

	internal TextBlock LblExtraSettings;

	internal TextBoxWithToolsControl TxtExtraSettings;

	internal Button BtnSave;

	internal Button BtnCancel;

	private bool qbDLqNoF9oc;

	internal static EditFormFieldWindowForDict hY0Vn4F1155dglbpl1HB;

	public FormField ResultField
	{
		[CompilerGenerated]
		get
		{
			return TOeLquYvKuq;
		}
		[CompilerGenerated]
		private set
		{
			TOeLquYvKuq = value;
		}
	}

	public EditFormFieldWindowForDict(IList<FormField> currentFields, FormField editingField)
	{
		ihhLqvZLYO2 = currentFields;
		qgbLqSxa3kf = editingField;
		InitializeComponent();
		base.Loaded += pBKLRUcpTZW;
		RQ5LRMCkwmm();
		CbDictValueType.ItemsSource = oDoLq2FWkWk;
		CbInputMethods.ItemsSource = Enum.GetValues(typeof(InputMethod));
		TxtGroup.ItemsSource = currentFields.Select(_003C_003Ec.qBjSdrneA1v ?? (_003C_003Ec.qBjSdrneA1v = _003C_003Ec.xFRSdxpYLtv.PUxSdmCqvbR)).Where(_003C_003Ec.uBISdplOJos ?? (_003C_003Ec.uBISdplOJos = _003C_003Ec.xFRSdxpYLtv.tnpSdKjqcfj)).Distinct()
			.ToList();
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void RQ5LRMCkwmm()
	{
		oDoLq2FWkWk.Add(new VarTypeItem
		{
			VarType = VarType.Text,
			Name = "文本",
			Description = "文本字符串"
		});
		oDoLq2FWkWk.Add(new VarTypeItem
		{
			VarType = VarType.Image,
			Name = "图片",
			Description = "图片内容"
		});
		oDoLq2FWkWk.Add(new VarTypeItem
		{
			VarType = VarType.Boolean,
			Name = "布尔",
			Description = "布尔（True/False）类型"
		});
		oDoLq2FWkWk.Add(new VarTypeItem
		{
			VarType = VarType.Number,
			Name = "数字",
			Description = "数字类型(小数数字)"
		});
		oDoLq2FWkWk.Add(new VarTypeItem
		{
			VarType = VarType.Integer,
			Name = "数字(整数)",
			Description = "数字类型(整数数字)"
		});
		oDoLq2FWkWk.Add(new VarTypeItem
		{
			VarType = VarType.DateTime,
			Name = "日期时间",
			Description = "日期和时间类型"
		});
		oDoLq2FWkWk.Add(new VarTypeItem
		{
			VarType = VarType.List,
			Name = "列表",
			Description = "文本列表，如选中的多个文件等"
		});
		oDoLq2FWkWk.Add(new VarTypeItem
		{
			VarType = VarType.Dict,
			Name = "词典",
			Description = "键-值对类型"
		});
		oDoLq2FWkWk.Add(new VarTypeItem
		{
			VarType = VarType.Table,
			Name = "表格",
			Description = "二维数据表(DataTable)"
		});
		if (hY0Vn4F1155dglbpl1HB == null)
		{
			switch (0)
			{
			}
		}
		oDoLq2FWkWk.Add(new VarTypeItem
		{
			VarType = VarType.Any,
			Name = "动态对象",
			Description = "任意的C#对象"
		});
	}

	private void AC1LRAhaoD5()
	{
	}

	private void ardLROuhlHS(object sender, EventArgs e)
	{
		i62LRF4sNBp();
		ROQLRf87Klf();
	}

	private void i62LRF4sNBp()
	{
		List<InputMethod> fieldAllowedInputMethods = EditFormFieldWindow.GetFieldAllowedInputMethods((CbDictValueType.SelectedItem as VarTypeItem)?.VarType);
		CbInputMethods.ItemsSource = fieldAllowedInputMethods;
		if (qgbLqSxa3kf != null)
		{
			try
			{
				CbInputMethods.SelectedItem = qgbLqSxa3kf.InputMethod;
				return;
			}
			catch (Exception ex)
			{
				YURLqLmYxLA.Warn("设置选中的选项出错：" + ex.Message, ex);
				return;
			}
		}
		if (CbInputMethods.Items.Count > 0)
		{
			CbInputMethods.SelectedIndex = 0;
		}
	}

	private void pBKLRUcpTZW(object sender, RoutedEventArgs e)
	{
		int num;
		if (qgbLqSxa3kf != null)
		{
			TxtDictKey.Text = qgbLqSxa3kf.FieldKey;
			CbDictValueType.SelectedItem = oDoLq2FWkWk.FirstOrDefault(JBELqwC9N7L);
			num = 0;
			if (!WPBjvUF1KR4wNLPnOR0q())
			{
				goto IL_00a6;
			}
			goto IL_00aa;
		}
		TxtMaxLength.Value = 0.0;
		i62LRF4sNBp();
		return;
		IL_00aa:
		do
		{
			switch (num)
			{
			case 1:
				TxtSelectItems.Text = qgbLqSxa3kf.SelectionItems;
				TxtMin.Text = qgbLqSxa3kf.MinValue;
				TxtMax.Text = qgbLqSxa3kf.MaxValue;
				TxtPattern.Text = qgbLqSxa3kf.Pattern;
				TxtMaxLength.Value = qgbLqSxa3kf.MaxLength;
				ChkIsRequired.IsChecked = qgbLqSxa3kf.IsRequired;
				TxtVisibleExpression.Text = qgbLqSxa3kf.VisibleExpression;
				TxtGroup.Text = qgbLqSxa3kf.Group;
				TxtInputWidth.Text = qgbLqSxa3kf.InputWidth;
				ChkOnlyDate.IsChecked = qgbLqSxa3kf.OnlyDate;
				TextToolsSelector.SetSelectedToolsString(qgbLqSxa3kf.TextTools);
				TxtExtraSettings.Text = qgbLqSxa3kf.ExtraSettings;
				ChkReadOnly.IsChecked = qgbLqSxa3kf.ReadOnly;
				i62LRF4sNBp();
				return;
			}
			TxtLabel.Text = qgbLqSxa3kf.Label;
			TxtHelpText.Text = qgbLqSxa3kf.HelpText;
			CbInputMethods.SelectedItem = qgbLqSxa3kf.InputMethod;
			num = 1;
		}
		while (WPBjvUF1KR4wNLPnOR0q());
		goto IL_00a6;
		IL_00a6:
		int num2 = default(int);
		num = num2;
		goto IL_00aa;
	}

	private void PnELRlsrCIV(object sender, RoutedEventArgs e)
	{
		if (!ihhLqvZLYO2.Any(AgBLqtIm9KC))
		{
			if (CbInputMethods.SelectedItem == null)
			{
				AppHelper.ShowWarning("请选择输入方式。");
				return;
			}
			if (string.IsNullOrEmpty(TxtLabel.Text) && (InputMethod)CbInputMethods.SelectedItem != InputMethod.Separator)
			{
				AppHelper.ShowWarning("请填写字段标题。");
				return;
			}
			ResultField = new FormField
			{
				FieldKey = TxtDictKey.Text,
				DictVarType = ((CbDictValueType.SelectedItem as VarTypeItem)?.VarType ?? VarType.NA),
				Label = TxtLabel.Text,
				HelpText = TxtHelpText.Text,
				InputMethod = (InputMethod)CbInputMethods.SelectedItem,
				SelectionItems = (PnlSelectItems.IsVisible ? TxtSelectItems.Text : ""),
				MinValue = (PnlRange.IsVisible ? TxtMin.Text : ""),
				MaxValue = (PnlRange.IsVisible ? TxtMax.Text : ""),
				Pattern = (PnlPattern.IsVisible ? TxtPattern.Text : ""),
				MaxLength = (PnlMaxLength.IsVisible ? ((int)TxtMaxLength.Value) : 0),
				IsRequired = (ChkIsRequired.IsVisible && ChkIsRequired.IsChecked == true),
				TextTools = (PnlTextTools.IsVisible ? TextToolsSelector.GetSelectedToolsString() : string.Empty),
				VisibleExpression = TxtVisibleExpression.Text,
				Group = TxtGroup.Text,
				InputWidth = TxtInputWidth.Text,
				OnlyDate = (ChkOnlyDate.IsChecked == true),
				ExtraSettings = TxtExtraSettings.Text,
				ReadOnly = (ChkReadOnly.IsChecked == true)
			};
			base.DialogResult = true;
			return;
		}
		AppHelper.ShowWarning("此键名已有记录。");
		if (hY0Vn4F1155dglbpl1HB == null)
		{
			switch (0)
			{
			}
		}
	}

	private void cEdLRiOUB9q(object sender, RoutedEventArgs e)
	{
		base.DialogResult = false;
	}

	private void W7dLR3hyA2o(object sender, SelectionChangedEventArgs e)
	{
		ROQLRf87Klf();
	}

	private void ROQLRf87Klf()
	{
		VarTypeItem varTypeItem = (VarTypeItem)CbDictValueType.SelectedItem;
		if (varTypeItem == null)
		{
			return;
		}
		InputMethod? obj = ((InputMethod?)CbInputMethods.SelectedItem).GetValueOrDefault();
		if (hY0Vn4F1155dglbpl1HB == null)
		{
			switch (0)
			{
			}
		}
		TextBlock lblSelectItems = LblSelectItems;
		Visibility visibility = (PnlSelectItems.Visibility = ((!obj.IsEither(InputMethod.DropDown, InputMethod.CheckComboBox, InputMethod.EditableDropDown, InputMethod.EditableAutoCompleteDropDown)) ? Visibility.Collapsed : Visibility.Visible));
		lblSelectItems.Visibility = visibility;
		TextBlock lblRange = LblRange;
		visibility = (PnlRange.Visibility = ((!varTypeItem.VarType.IsEither(VarType.Number, VarType.Integer)) ? Visibility.Collapsed : Visibility.Visible));
		lblRange.Visibility = visibility;
		TextBlock lblPattern = LblPattern;
		visibility = (PnlPattern.Visibility = ((!obj.IsEither(InputMethod.TextBox, InputMethod.EditableDropDown, InputMethod.EditableAutoCompleteDropDown, InputMethod.TextEditor)) ? Visibility.Collapsed : Visibility.Visible));
		lblPattern.Visibility = visibility;
		TextBlock lblMaxLength = LblMaxLength;
		visibility = (PnlMaxLength.Visibility = ((!obj.IsEither(InputMethod.TextBox, InputMethod.PasswordBox)) ? Visibility.Collapsed : Visibility.Visible));
		lblMaxLength.Visibility = visibility;
		TextBlock lblTextTools = LblTextTools;
		visibility = (PnlTextTools.Visibility = ((!obj.IsEither(InputMethod.TextEditor, InputMethod.TextBox, InputMethod.EditableDropDown)) ? Visibility.Collapsed : Visibility.Visible));
		lblTextTools.Visibility = visibility;
		ChkIsRequired.Visibility = ((!obj.IsEither(InputMethod.TextEditor, InputMethod.DropDown, InputMethod.TextBox, InputMethod.NumberBox, InputMethod.CheckComboBox, InputMethod.EditableDropDown, InputMethod.EditableAutoCompleteDropDown, InputMethod.PasswordBox, InputMethod.FontFamilySelector)) ? Visibility.Collapsed : Visibility.Visible);
		ChkOnlyDate.Visibility = obj.IsEither(InputMethod.DatePicker).ToVisibility();
	}

	private void CJqLRzBHdw8(object sender, SelectionChangedEventArgs e)
	{
		i62LRF4sNBp();
		ROQLRf87Klf();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!qbDLqNoF9oc)
		{
			qbDLqNoF9oc = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/forms/editformfieldwindowfordict.xaml", UriKind.Relative);
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
			qbDLqNoF9oc = true;
			break;
		case 1:
			MainGrid = (Grid)target;
			break;
		case 2:
			TxtDictKey = (System.Windows.Controls.TextBox)target;
			break;
		case 3:
			CbDictValueType = (System.Windows.Controls.ComboBox)target;
			CbDictValueType.SelectionChanged += CJqLRzBHdw8;
			break;
		case 4:
			TxtLabel = (TextBoxWithToolsControl)target;
			break;
		case 5:
			TxtHelpText = (TextBoxWithToolsControl)target;
			break;
		case 6:
			TxtGroup = (System.Windows.Controls.ComboBox)target;
			break;
		case 7:
			CbInputMethods = (System.Windows.Controls.ComboBox)target;
			CbInputMethods.SelectionChanged += W7dLR3hyA2o;
			break;
		case 8:
			LblSelectItems = (TextBlock)target;
			break;
		case 9:
			PnlSelectItems = (StackPanel)target;
			break;
		case 10:
			TxtSelectItems = (TextBoxWithToolsControl)target;
			num = 2;
			if (!WPBjvUF1KR4wNLPnOR0q())
			{
				goto IL_028f;
			}
			goto IL_0293;
		case 11:
			LblRange = (TextBlock)target;
			break;
		case 12:
			PnlRange = (StackPanel)target;
			break;
		case 13:
			TxtMin = (System.Windows.Controls.TextBox)target;
			break;
		case 14:
			TxtMax = (System.Windows.Controls.TextBox)target;
			break;
		case 15:
			LblPattern = (TextBlock)target;
			break;
		case 16:
			PnlPattern = (StackPanel)target;
			break;
		case 17:
			TxtPattern = (System.Windows.Controls.TextBox)target;
			break;
		case 18:
			LblMaxLength = (TextBlock)target;
			break;
		case 19:
			PnlMaxLength = (StackPanel)target;
			break;
		case 20:
			TxtMaxLength = (NumericUpDown)target;
			break;
		case 21:
			LblTextTools = (TextBlock)target;
			break;
		case 22:
			PnlTextTools = (StackPanel)target;
			break;
		case 23:
			TextToolsSelector = (TextToolsSelectorControl)target;
			break;
		case 24:
			LblImeState = (TextBlock)target;
			break;
		case 25:
			TxtVisibleExpression = (TextBoxWithToolsControl)target;
			break;
		case 26:
			LblInputWidth = (TextBlock)target;
			break;
		case 27:
			TxtInputWidth = (System.Windows.Controls.TextBox)target;
			break;
		case 28:
			LblOtherOptions = (TextBlock)target;
			num = 0;
			if (hY0Vn4F1155dglbpl1HB != null)
			{
				goto IL_028f;
			}
			goto IL_0293;
		case 29:
			ChkIsRequired = (CheckBox)target;
			break;
		case 30:
			ChkOnlyDate = (CheckBox)target;
			break;
		case 31:
			ChkReadOnly = (CheckBox)target;
			num = 1;
			if (hY0Vn4F1155dglbpl1HB != null)
			{
				goto IL_028f;
			}
			goto IL_0293;
		case 32:
			LblExtraSettings = (TextBlock)target;
			break;
		case 33:
			TxtExtraSettings = (TextBoxWithToolsControl)target;
			break;
		case 34:
			BtnSave = (Button)target;
			BtnSave.Click += PnELRlsrCIV;
			break;
		case 35:
			{
				BtnCancel = (Button)target;
				BtnCancel.Click += cEdLRiOUB9q;
				break;
			}
			IL_028f:
			num = num2;
			goto IL_0293;
			IL_0293:
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

	static EditFormFieldWindowForDict()
	{
		YURLqLmYxLA = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	[CompilerGenerated]
	private bool JBELqwC9N7L(VarTypeItem varTypeItem_0)
	{
		return qgbLqSxa3kf.DictVarType == varTypeItem_0.VarType;
	}

	[CompilerGenerated]
	private bool AgBLqtIm9KC(FormField formField_2)
	{
		if (formField_2 != qgbLqSxa3kf && !string.IsNullOrEmpty(formField_2.FieldKey))
		{
			return formField_2.FieldKey == TxtDictKey.Text;
		}
		return false;
	}

	internal static bool WPBjvUF1KR4wNLPnOR0q()
	{
		return hY0Vn4F1155dglbpl1HB == null;
	}
}
