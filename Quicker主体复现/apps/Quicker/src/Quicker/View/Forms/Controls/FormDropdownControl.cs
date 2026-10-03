using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using log4net;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Actions.X.Variables;
using Quicker.Public.Extensions;
using Quicker.Public.Forms;
using Quicker.Utilities;

namespace Quicker.View.Forms.Controls;

public class FormDropdownControl : BaseFormFieldControl, IComponentConnector, IFormControl, IUpdatableFieldControl
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass13_0
	{
		public string w4qSonaTYml;

		private static _003C_003Ec__DisplayClass13_0 xVA6F6WC0ORr8AwmiRR8;

		internal bool EB3SoQ0lOu9(SimpleOperationItem x)
		{
			return string.Equals(w4qSonaTYml, x.Key);
		}

		internal bool UAvSojbCOFk(SimpleOperationItem x)
		{
			return string.Equals(w4qSonaTYml, x.Key, StringComparison.OrdinalIgnoreCase);
		}

		internal static bool iiIueVWC1TEEVr2ILGAa()
		{
			return xVA6F6WC0ORr8AwmiRR8 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass17_0
	{
		public SimpleOperationItem kCiSo5tUEJK;

		private static _003C_003Ec__DisplayClass17_0 KurloWWCBZbCNl5jHWXu;

		internal bool qwgSo4UHg4r(SimpleOperationItem x)
		{
			return string.Equals(kCiSo5tUEJK.Key, x.Key);
		}

		internal static bool gSjGZvWCvN7MD0kJZEbH()
		{
			return KurloWWCBZbCNl5jHWXu == null;
		}
	}

	private static readonly ILog UIKLVMm2hNi;

	private List<SimpleOperationItem> jf9LVAG7lv5;

	private FormField keOLVOFc2h0;

	private ActionVariable L4NLVFyNhqt;

	private bool aSoLVUni947;

	internal ComboBox CbValue;

	private bool KGNLVluxNks;

	internal static FormDropdownControl sR7mBYFvGqnTgQR7sT08;

	public FormDropdownControl()
	{
		InitializeComponent();
	}

	public void Init(FormField field, ActionVariable variable, IVariableContext context)
	{
		keOLVOFc2h0 = field;
		L4NLVFyNhqt = variable;
		string text = field.SelectionItems;
		if (!string.IsNullOrEmpty(text))
		{
			text = XActionHelper.InterpolateOrEvalToString((ActionExecuteContext)context, text);
		}
		jf9LVAG7lv5 = AppHelper.StringToOperationItems(text, true);
		CbValue.ItemsSource = jf9LVAG7lv5;
		if (sR7mBYFvGqnTgQR7sT08 == null)
		{
			switch (0)
			{
			}
		}
		string obj = (context.IsVarExists(field.FieldKey) ? Convert.ToString(context.GetVarValue(field.FieldKey)) : "");
		UpdateValue(obj);
		aSoLVUni947 = true;
	}

	public object GetInputValue()
	{
		string value = wc1LVTL6ONo();
		return VariableHelper.ConvertToType(L4NLVFyNhqt.Type, value);
	}

	private string wc1LVTL6ONo()
	{
		if (CbValue.SelectedItem != null)
		{
			return ((SimpleOperationItem)CbValue.SelectedItem).Key;
		}
		return "";
	}

	public (bool isValid, string message) Validate()
	{
		try
		{
			if (keOLVOFc2h0.IsRequired && string.IsNullOrEmpty(wc1LVTL6ONo()))
			{
				return (isValid: false, message: "请选择选项。");
			}
			return (isValid: true, message: "");
		}
		catch (Exception ex)
		{
			return (isValid: false, message: "错误：" + ex.Message);
		}
	}

	public void SetFocus()
	{
		CbValue.Focus();
	}

	public UIElement GetPrimaryElement()
	{
		return CbValue;
	}

	public void SetInputWidth(double width)
	{
		CbValue.HorizontalAlignment = HorizontalAlignment.Left;
		CbValue.Width = width;
	}

	public void UpdateValue(object obj)
	{
		_003C_003Ec__DisplayClass13_0 _003C_003Ec__DisplayClass13_ = new _003C_003Ec__DisplayClass13_0();
		if (obj == null)
		{
			obj = "";
		}
		_003C_003Ec__DisplayClass13_.w4qSonaTYml = Convert.ToString(obj);
		try
		{
			SimpleOperationItem simpleOperationItem = jf9LVAG7lv5.FirstOrDefault(_003C_003Ec__DisplayClass13_.EB3SoQ0lOu9);
			if (simpleOperationItem == null)
			{
				simpleOperationItem = jf9LVAG7lv5.FirstOrDefault(_003C_003Ec__DisplayClass13_.UAvSojbCOFk);
			}
			CbValue.SelectedItem = simpleOperationItem;
		}
		catch (Exception ex)
		{
			UIKLVMm2hNi.Warn("设置选中的选项出错。" + ex.Message, ex);
		}
	}

	public void SetReadOnly(bool isReadOnly)
	{
		CbValue.IsReadOnly = isReadOnly;
	}

	private void CbValue_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		if (aSoLVUni947)
		{
			TriggerValueChange(keOLVOFc2h0);
		}
	}

	public bool IsShouldUpdate()
	{
		if (keOLVOFc2h0.SelectionItems != null && keOLVOFc2h0.SelectionItems.StartsWithAny(false, "$=", "$$"))
		{
			return keOLVOFc2h0.ExtraSettings.HasLineStartWith("refresh_items");
		}
		return false;
	}

	public void Update(IVariableContext context)
	{
		if (!IsShouldUpdate())
		{
			return;
		}
		_003C_003Ec__DisplayClass17_0 _003C_003Ec__DisplayClass17_ = new _003C_003Ec__DisplayClass17_0();
		_003C_003Ec__DisplayClass17_.kCiSo5tUEJK = CbValue.SelectedItem as SimpleOperationItem;
		string selectionItems = keOLVOFc2h0.SelectionItems;
		if (string.IsNullOrEmpty(selectionItems))
		{
			return;
		}
		selectionItems = XActionHelper.InterpolateOrEvalToString((ActionExecuteContext)context, selectionItems);
		jf9LVAG7lv5 = AppHelper.StringToOperationItems(selectionItems, true);
		CbValue.ItemsSource = jf9LVAG7lv5;
		if (_003C_003Ec__DisplayClass17_.kCiSo5tUEJK == null)
		{
			return;
		}
		SimpleOperationItem simpleOperationItem = jf9LVAG7lv5.FirstOrDefault(_003C_003Ec__DisplayClass17_.qwgSo4UHg4r);
		int num = 0;
		if (sR7mBYFvGqnTgQR7sT08 != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (simpleOperationItem != null)
		{
			CbValue.SelectedItem = simpleOperationItem;
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!KGNLVluxNks)
		{
			KGNLVluxNks = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/forms/controls/formdropdowncontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 1)
		{
			CbValue = (ComboBox)target;
			CbValue.SelectionChanged += CbValue_OnSelectionChanged;
		}
		else
		{
			KGNLVluxNks = true;
		}
	}

	static FormDropdownControl()
	{
		UIKLVMm2hNi = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool z8gS1KFv02ppsZAsDnao()
	{
		return sR7mBYFvGqnTgQR7sT08 == null;
	}
}
