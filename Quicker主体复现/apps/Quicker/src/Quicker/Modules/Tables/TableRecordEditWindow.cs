using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using GuvA3OiyFyyWpKJlb8c;
using HandyControl.Controls;
using Quicker.Actions.XActions.Storage;
using Quicker.Domain;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Actions.X.Variables;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Public.Forms;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI.Wpf;
using Quicker.View.Controls;
using Quicker.View.Forms.Controls;
using ViNASxihuuLY1Gg9m6p;
using Z.Expressions;

namespace Quicker.Modules.Tables;

public class TableRecordEditWindow : HandyControl.Controls.Window, IComponentConnector, IMockModalWindow
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec doUvs0teWFF;

		public static Func<KeyValuePair<string, object>, string> beVvsC38jeq;

		public static Func<KeyValuePair<string, object>, object> jSEvsPHZhck;

		public static Func<KeyValuePair<string, object>, string> zHUvsEE6AJ5;

		public static Func<KeyValuePair<string, object>, object> nXDvsyQWdg2;

		private static _003C_003Ec hQrihecREFGM8mOCXlQq;

		static _003C_003Ec()
		{
			doUvs0teWFF = new _003C_003Ec();
		}

		internal string KcKvs2bEuwl(KeyValuePair<string, object> x)
		{
			return x.Key;
		}

		internal object XtcvsuKMDal(KeyValuePair<string, object> x)
		{
			return x.Value;
		}

		internal string lp3vsNCqTYv(KeyValuePair<string, object> x)
		{
			return x.Key;
		}

		internal object kGWvsJoJ2sJ(KeyValuePair<string, object> x)
		{
			return x.Value;
		}

		internal static bool docfAWcRGyLevymDA1FC()
		{
			return hQrihecREFGM8mOCXlQq == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	internal struct _003C_003Ec__DisplayClass23_0
	{
		public Grid q69vs8evTPX;
	}

	private ActionExecuteContext rcBt2s11Zf9;

	private DataRow a03t2HN2NRa;

	private readonly ActionExecuteContext pn0t21YcM7g;

	private IDictionary<string, FormFieldWrapper> QDZt2bYMiBO = new Dictionary<string, FormFieldWrapper>();

	private TableDef uWOt26JxPHt;

	[CompilerGenerated]
	private IDictionary<string, object> p2rt2XPFCun;

	private readonly RecordEditMode mCKt2mJZNAl;

	private readonly DataTable GdSt2KGjBnV;

	[CompilerGenerated]
	private bool? ocpt2xn4nLW;

	internal TableRecordEditWindow TheWindow;

	internal StackPanel PnlFields;

	internal TextBlock LblHelp;

	internal Grid ButtonPanel;

	internal MarkdownHintButton HintButton;

	internal Button BtnSaveAndNew;

	internal Button BtnSave;

	internal Button BtnCancel;

	internal Button BtnReset;

	private bool VIst2rfDvyg;

	private static TableRecordEditWindow AcOaKaQXHhBXZfeg9bgq;

	public string HelpText
	{
		get
		{
			return LblHelp.Text;
		}
		set
		{
			LblHelp.Text = value;
		}
	}

	public string MarkdownHelp
	{
		set
		{
			if (!string.IsNullOrEmpty(value))
			{
				HintButton.MarkDownToolTip = value;
				HintButton.Visibility = Visibility.Visible;
			}
		}
	}

	public bool? Result
	{
		[CompilerGenerated]
		get
		{
			return ocpt2xn4nLW;
		}
		[CompilerGenerated]
		set
		{
			ocpt2xn4nLW = value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private IDictionary<string, object> yeBt2WjUxXR()
	{
		return p2rt2XPFCun;
	}

	[SpecialName]
	[CompilerGenerated]
	private void K8at2k3ochj(IDictionary<string, object> value)
	{
		p2rt2XPFCun = value;
	}

	public void SetReadonly()
	{
		BtnSave.Visibility = Visibility.Collapsed;
		BtnReset.Visibility = Visibility.Collapsed;
		base.Title += " (只读模式)";
		BtnCancel.IsDefault = true;
		BtnCancel.Style = TryFindResource("ButtonPrimary") as Style;
	}

	public TableRecordEditWindow(RecordEditMode mode, DataTable table, string title, TableDef tableDefDef, double titleColumnWidth, DataRow row, bool isReadonly, ActionExecuteContext actionExecuteContext)
	{
		mCKt2mJZNAl = mode;
		GdSt2KGjBnV = table;
		a03t2HN2NRa = row;
		pn0t21YcM7g = actionExecuteContext;
		InitializeComponent();
		if (mCKt2mJZNAl == RecordEditMode.Add)
		{
			if (row == null)
			{
				a03t2HN2NRa = GdSt2KGjBnV.NewRow();
				if (tableDefDef != null)
				{
					foreach (TableField field in tableDefDef.Fields)
					{
						if (!string.IsNullOrEmpty(field.DefaultValue))
						{
							a03t2HN2NRa[field.FieldKey] = field.DefaultValue;
						}
					}
				}
			}
		}
		else
		{
			BtnSaveAndNew.Visibility = Visibility.Collapsed;
			BtnSave.Content = "保存(_S)";
		}
		uWOt26JxPHt = tableDefDef;
		FormFieldWrapper.SetLabelColWidth(this, (titleColumnWidth > 0.0) ? new GridLength(titleColumnWidth) : GridLength.Auto);
		if (!string.IsNullOrEmpty(title))
		{
			base.Title = title;
		}
		hYdt2J8dP04(a03t2HN2NRa);
		oVut2E9GkI2(tableDefDef, isReadonly);
		base.Loaded += F49t2PSmEG7;
		base.SourceInitialized += YkVt2CEaJWg;
		if (isReadonly)
		{
			SetReadonly();
		}
		AppHelper.AddGoToPageCommandBinding(this);
	}

	private void hYdt2J8dP04(DataRow dataRow_1)
	{
		K8at2k3ochj(dataRow_1.ToDict());
		rcBt2s11Zf9 = rd3t20l8Gky();
	}

	private ActionExecuteContext rd3t20l8Gky()
	{
		ActionExecuteContext actionExecuteContext = new ActionExecuteContext(pn0t21YcM7g, pn0t21YcM7g?.Action, null, AppState.AppServer, false, pn0t21YcM7g?.Id ?? 0, null, pn0t21YcM7g?.CancellationToken);
		foreach (KeyValuePair<string, object> item in yeBt2WjUxXR())
		{
			actionExecuteContext.SetVarValueWithoutConvert(item.Key, item.Value);
		}
		return actionExecuteContext;
	}

	private void YkVt2CEaJWg(object sender, EventArgs e)
	{
		IHNRIiikxBwJdYmHpM3.z5HvvDbvaW2(this, ShowWindowLocation.CenterScreen);
	}

	private void F49t2PSmEG7(object sender, RoutedEventArgs e)
	{
		base.Dispatcher.InvokeAsync(Ks9t2YiReAG);
	}

	private void oVut2E9GkI2(TableDef tableDef_1, bool bool_1)
	{
		if (bool_1)
		{
			cvvt2yGfVEn(tableDef_1);
			return;
		}
		if (tableDef_1 != null && tableDef_1.Fields.HasData())
		{
			int num2 = default(int);
			foreach (TableField field in tableDef_1.Fields)
			{
				if (field.InputMethod != Quicker.Public.Forms.InputMethod.None)
				{
					ActionVariable actionVariable = AG5t286sDT9(field);
					if (actionVariable == null)
					{
						throw new InvalidOperationException("变量" + field.FieldKey + "不存在。");
					}
					FormFieldWrapper formFieldWrapper = new FormFieldWrapper();
					formFieldWrapper.ValueChanged += NsLt2ag8Ptg;
					PnlFields.Children.Add(formFieldWrapper);
					int num = 0;
					if (AcOaKaQXHhBXZfeg9bgq != null)
					{
						num = num2;
					}
					switch (num)
					{
					}
					formFieldWrapper.Init(field, actionVariable, rcBt2s11Zf9);
					QDZt2bYMiBO[field.FieldKey] = formFieldWrapper;
				}
			}
			CACt27vS7VV();
			return;
		}
		IEnumerator enumerator2 = a03t2HN2NRa.Table.Columns.GetEnumerator();
		int num3 = 0;
		if (AcOaKaQXHhBXZfeg9bgq != null)
		{
			int num4 = default(int);
			num3 = num4;
		}
		switch (num3)
		{
		}
		try
		{
			while (enumerator2.MoveNext())
			{
				DataColumn dataColumn = (DataColumn)enumerator2.Current;
				TableField tableField = new TableField
				{
					Label = dataColumn.ColumnName,
					FieldKey = dataColumn.ColumnName,
					InputMethod = Quicker.Public.Forms.InputMethod.TextBox,
					DictVarType = VarType.Text
				};
				if (daHsNdQXzU1sZqh3xLfn())
				{
					switch (0)
					{
					}
				}
				ActionVariable actionVariable2 = AG5t286sDT9(tableField);
				if (actionVariable2 != null)
				{
					FormFieldWrapper formFieldWrapper2 = new FormFieldWrapper();
					formFieldWrapper2.ValueChanged += NsLt2ag8Ptg;
					PnlFields.Children.Add(formFieldWrapper2);
					formFieldWrapper2.Init(tableField, actionVariable2, rcBt2s11Zf9);
					QDZt2bYMiBO[tableField.FieldKey] = formFieldWrapper2;
					continue;
				}
				throw new InvalidOperationException("变量" + tableField.FieldKey + "不存在。");
			}
		}
		finally
		{
			if (enumerator2 is IDisposable disposable)
			{
				disposable.Dispose();
			}
		}
	}

	private void cvvt2yGfVEn(TableDef tableDef_1)
	{
		_003C_003Ec__DisplayClass23_0 _003C_003Ec__DisplayClass23_0_ = default(_003C_003Ec__DisplayClass23_0);
		_003C_003Ec__DisplayClass23_0_.q69vs8evTPX = new Grid();
		_003C_003Ec__DisplayClass23_0_.q69vs8evTPX.Margin = new Thickness(10.0);
		_003C_003Ec__DisplayClass23_0_.q69vs8evTPX.ColumnDefinitions.Add(new ColumnDefinition
		{
			Width = new GridLength(1.0, GridUnitType.Auto)
		});
		_003C_003Ec__DisplayClass23_0_.q69vs8evTPX.ColumnDefinitions.Add(new ColumnDefinition
		{
			Width = new GridLength(10.0)
		});
		_003C_003Ec__DisplayClass23_0_.q69vs8evTPX.ColumnDefinitions.Add(new ColumnDefinition
		{
			Width = new GridLength(1.0, GridUnitType.Star)
		});
		PnlFields.Children.Add(_003C_003Ec__DisplayClass23_0_.q69vs8evTPX);
		if (tableDef_1 != null && tableDef_1.Fields.HasData())
		{
			int num = 0;
			{
				foreach (TableField field in tableDef_1.Fields)
				{
					object obj;
					if (!rcBt2s11Zf9.IsVarExists(field.FieldKey))
					{
						if (daHsNdQXzU1sZqh3xLfn())
						{
							switch (0)
							{
							}
						}
						obj = "";
					}
					else
					{
						obj = rcBt2s11Zf9.GetVarValue(field.FieldKey);
					}
					object obj2 = obj;
					string string_ = ((obj2 is string text) ? text : VariableHelper.LcfghRCibTg(obj2));
					fSJt2IGRe7k(num, field.Label, string_, ref _003C_003Ec__DisplayClass23_0_);
					num++;
					_003C_003Ec__DisplayClass23_0_.q69vs8evTPX.RowDefinitions.Add(new RowDefinition
					{
						Height = new GridLength(10.0)
					});
					num++;
				}
				return;
			}
		}
		int num2 = 0;
		if (AcOaKaQXHhBXZfeg9bgq == null)
		{
			switch (0)
			{
			}
		}
		int num4 = default(int);
		foreach (DataColumn column in a03t2HN2NRa.Table.Columns)
		{
			object obj3 = a03t2HN2NRa[column];
			string string_2 = ((obj3 is string text2) ? text2 : VariableHelper.LcfghRCibTg(obj3));
			fSJt2IGRe7k(num2, column.ColumnName, string_2, ref _003C_003Ec__DisplayClass23_0_);
			num2++;
			_003C_003Ec__DisplayClass23_0_.q69vs8evTPX.RowDefinitions.Add(new RowDefinition
			{
				Height = new GridLength(10.0)
			});
			int num3 = 0;
			if (AcOaKaQXHhBXZfeg9bgq != null)
			{
				num3 = num4;
			}
			switch (num3)
			{
			}
			num2++;
		}
	}

	private ActionVariable AG5t286sDT9(TableField tableField_0)
	{
		return new ActionVariable
		{
			Key = tableField_0.FieldKey,
			Type = tableField_0.QuickerVarType,
			Desc = tableField_0.HelpText,
			DefaultValue = tableField_0.DefaultValue
		};
	}

	private void NsLt2ag8Ptg(object object_0, FormField formField_0)
	{
		CACt27vS7VV();
	}

	private void CACt27vS7VV()
	{
		IDictionary<string, object> dictionary = new Dictionary<string, object>();
		try
		{
			dictionary = rcBt2s11Zf9.GetVariables().ToDictionary(_003C_003Ec.beVvsC38jeq ?? (_003C_003Ec.beVvsC38jeq = _003C_003Ec.doUvs0teWFF.KcKvs2bEuwl), _003C_003Ec.jSEvsPHZhck ?? (_003C_003Ec.jSEvsPHZhck = _003C_003Ec.doUvs0teWFF.XtcvsuKMDal));
		}
		catch (Exception)
		{
			dictionary = rcBt2s11Zf9.GetVariables().ToDictionary(_003C_003Ec.zHUvsEE6AJ5 ?? (_003C_003Ec.zHUvsEE6AJ5 = _003C_003Ec.doUvs0teWFF.lp3vsNCqTYv), _003C_003Ec.nXDvsyQWdg2 ?? (_003C_003Ec.nXDvsyQWdg2 = _003C_003Ec.doUvs0teWFF.kGWvsJoJ2sJ));
		}
		foreach (string key in QDZt2bYMiBO.Keys)
		{
			FormFieldWrapper formFieldWrapper = QDZt2bYMiBO[key];
			if (formFieldWrapper.IsVisible)
			{
				try
				{
					object inputValue = formFieldWrapper.GetInputValue();
					dictionary[key] = inputValue;
				}
				catch
				{
				}
			}
		}
		foreach (FormFieldWrapper value in QDZt2bYMiBO.Values)
		{
			if (!string.IsNullOrWhiteSpace(value.Field.VisibleExpression) && value.Field.VisibleExpression.StartsWith("$="))
			{
				try
				{
					value.Visibility = ((!eMRt2RG8Pab(value.Field.VisibleExpression, dictionary)) ? Visibility.Collapsed : Visibility.Visible);
				}
				catch (Exception exception)
				{
					AppHelper.ShowWarning("更新字段可见性出错：" + value.Field.FieldKey + " \n表达式：" + value.Field.VisibleExpression + "\n错误：" + exception.GetMessageWithInner());
				}
			}
			if (value.Field.ExtraSettings.HasLineStartWith("refresh_help"))
			{
				value.UpdateHelpText(rcBt2s11Zf9);
			}
		}
	}

	private bool eMRt2RG8Pab(string string_0, IDictionary<string, object> idictionary_2)
	{
		IDictionary<string, object> dictionary = new Dictionary<string, object>();
		foreach (KeyValuePair<string, object> item in idictionary_2)
		{
			string text = "v_" + item.Key;
			if (string_0.Contains("{" + item.Key + "}"))
			{
				string_0 = string_0.Replace("{" + item.Key + "}", text);
				object value = item.Value;
				if (item.Value is long num && num > -2147483648L && num < 2147483647L)
				{
					value = (int)num;
				}
				dictionary.Add(text, value);
			}
		}
		return Eval.Execute<bool>(string_0.Substring(2), dictionary);
	}

	private void acat2qGXlVh(object sender, RoutedEventArgs e)
	{
		Close();
	}

	private bool QI3t2cYZQ7w()
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		bool flag = true;
		int num2 = default(int);
		foreach (string key in QDZt2bYMiBO.Keys)
		{
			FormFieldWrapper formFieldWrapper = QDZt2bYMiBO[key];
			if (!formFieldWrapper.IsVisible || formFieldWrapper.IsReadonly())
			{
				continue;
			}
			if (formFieldWrapper.Validate().isValid)
			{
				int num = 0;
				if (AcOaKaQXHhBXZfeg9bgq != null)
				{
					num = num2;
				}
				switch (num)
				{
				default:
					try
					{
						object inputValue = formFieldWrapper.GetInputValue();
						dictionary[key] = inputValue;
					}
					catch (Exception ex)
					{
						AppHelper.ShowWarning("字段 " + formFieldWrapper.Field.Label + " 的值不合法：" + ex.Message, true);
						flag = false;
						break;
					}
					continue;
				}
			}
			else
			{
				flag = false;
			}
			break;
		}
		if (!flag)
		{
			return false;
		}
		try
		{
			a03t2HN2NRa.UpdateFromDict(dictionary);
		}
		catch (Exception ex2)
		{
			AppHelper.ShowWarning(ex2.Message);
			return false;
		}
		return true;
	}

	private void a1dt2VTDHeY(object sender, RoutedEventArgs e)
	{
		if (AppHelper.f7TLTAiCsTC())
		{
			BtnSave.Focus();
			AppHelper.RunOnUiThread(false, qyTt2ZXTLtY);
		}
		else
		{
			qyTt2ZXTLtY();
		}
	}

	private void qyTt2ZXTLtY()
	{
		if (!QI3t2cYZQ7w())
		{
			return;
		}
		try
		{
			if (mCKt2mJZNAl == RecordEditMode.Add)
			{
				GdSt2KGjBnV.Rows.Add(a03t2HN2NRa);
			}
			this.ThNvuM5Q9GQ(true);
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("保存失败！" + ex.Message);
		}
	}

	private void r3At29vI3In(object sender, RoutedEventArgs e)
	{
		if (uWOt26JxPHt != null)
		{
			rFZt2hjaxVx();
		}
	}

	private void rFZt2hjaxVx()
	{
		foreach (TableField field in uWOt26JxPHt.Fields)
		{
			if (field.InputMethod != Quicker.Public.Forms.InputMethod.None)
			{
				ActionVariable actionVariable = AG5t286sDT9(field);
				if (actionVariable == null)
				{
					throw new InvalidOperationException("变量" + field.FieldKey + "不存在。");
				}
				QDZt2bYMiBO[field.FieldKey].Init(field, actionVariable, rcBt2s11Zf9);
			}
		}
		CACt27vS7VV();
	}

	private void jPQt2e3Q1Vf(object sender, RoutedEventArgs e)
	{
		if (QI3t2cYZQ7w())
		{
			try
			{
				GdSt2KGjBnV.Rows.Add(a03t2HN2NRa);
				a03t2HN2NRa = GdSt2KGjBnV.NewRow();
				rFZt2hjaxVx();
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("保存失败！" + ex.Message);
			}
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!VIst2rfDvyg)
		{
			VIst2rfDvyg = true;
			Uri resourceLocator = new Uri("/Quicker;component/modules/tables/tablerecordeditwindow.xaml", UriKind.Relative);
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
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			VIst2rfDvyg = true;
			break;
		case 1:
			TheWindow = (TableRecordEditWindow)target;
			break;
		case 2:
			PnlFields = (StackPanel)target;
			break;
		case 3:
			LblHelp = (TextBlock)target;
			break;
		case 4:
		{
			ButtonPanel = (Grid)target;
			int num = 0;
			if (!daHsNdQXzU1sZqh3xLfn())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			break;
		}
		case 5:
			HintButton = (MarkdownHintButton)target;
			break;
		case 6:
			BtnSaveAndNew = (Button)target;
			BtnSaveAndNew.Click += jPQt2e3Q1Vf;
			break;
		case 7:
			BtnSave = (Button)target;
			BtnSave.Click += a1dt2VTDHeY;
			break;
		case 8:
			BtnCancel = (Button)target;
			BtnCancel.Click += acat2qGXlVh;
			break;
		case 9:
			BtnReset = (Button)target;
			BtnReset.Click += r3At29vI3In;
			break;
		}
	}

	[CompilerGenerated]
	private void Ks9t2YiReAG()
	{
		MoveFocus(new TraversalRequest(FocusNavigationDirection.First));
	}

	[CompilerGenerated]
	internal static void fSJt2IGRe7k(int int_0, string string_0, string string_1, ref _003C_003Ec__DisplayClass23_0 _003C_003Ec__DisplayClass23_0_0)
	{
		_003C_003Ec__DisplayClass23_0_0.q69vs8evTPX.RowDefinitions.Add(new RowDefinition());
		TextBlock textBlock = new TextBlock
		{
			Text = string_0
		};
		textBlock.FontWeight = FontWeights.Bold;
		Grid.SetColumn(textBlock, 0);
		int num = 0;
		if (AcOaKaQXHhBXZfeg9bgq != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		Grid.SetRow(textBlock, int_0);
		_003C_003Ec__DisplayClass23_0_0.q69vs8evTPX.Children.Add(textBlock);
		TextBlock element = new TextBlock
		{
			Text = string_1,
			TextWrapping = TextWrapping.Wrap
		};
		Grid.SetRow(element, int_0);
		Grid.SetColumn(element, 2);
		_003C_003Ec__DisplayClass23_0_0.q69vs8evTPX.Children.Add(element);
	}

	internal static bool daHsNdQXzU1sZqh3xLfn()
	{
		return AcOaKaQXHhBXZfeg9bgq == null;
	}

	internal static void nIb9WHQ2cOf77TyJhhPP()
	{
	}
}
