using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using DotNetKit.Windows.Controls;
using log4net;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Extensions;
using Quicker.Public.Forms;
using Quicker.Utilities;
using Quicker.Utilities.Ext;

namespace Quicker.View.Forms.Controls;

public class FormEditWithAutoCompleteDropdownControl : BaseFormFieldControl, IComponentConnector, IFormControl, IUpdatableFieldControl
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass15_0
	{
		public string qu3SoeG6Oym;

		private static _003C_003Ec__DisplayClass15_0 GqQNwjWsHH4ifm7orK8f;

		internal bool f6YSohmrDig(string x)
		{
			return string.Equals(qu3SoeG6Oym, x);
		}

		internal static bool cJYKdtWszEJtr4rSgbaX()
		{
			return GqQNwjWsHH4ifm7orK8f == null;
		}
	}

	private static readonly ILog fXmLcpOUonY;

	private IList<string> cU5LcBAaFhO;

	private FormField g2OLcQ4lY1R;

	internal AutoCompleteComboBox CbValue;

	private bool v4sLcjc4K6g;

	private static FormEditWithAutoCompleteDropdownControl M45SrUFK5tpikl11hlm1;

	public FormEditWithAutoCompleteDropdownControl()
	{
		InitializeComponent();
	}

	public void Init(FormField field, ActionVariable variable, IVariableContext context)
	{
		g2OLcQ4lY1R = field;
		string text = field.SelectionItems;
		if (!string.IsNullOrEmpty(text))
		{
			try
			{
				text = XActionHelper.InterpolateOrEvalToString((ActionExecuteContext)context, text);
			}
			catch (Exception ex)
			{
				fXmLcpOUonY.Warn("字段" + field.Label + "初始化出错：" + ex.Message, ex);
				AppHelper.ShowWarning("字段" + field.Label + "初始化出错：" + ex.Message);
			}
		}
		else
		{
			text = "";
		}
		cU5LcBAaFhO = text.Split(new string[2] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
		CbValue.ItemsSource = cU5LcBAaFhO;
		object obj;
		if (!context.IsVarExists(field.FieldKey))
		{
			if (h1JwRTFKYpYhr3Eh8B4D())
			{
				switch (0)
				{
				}
			}
			obj = "";
		}
		else
		{
			obj = Convert.ToString(context.GetVarValue(field.FieldKey));
		}
		string text2 = (string)obj;
		CbValue.Text = text2;
	}

	public object GetInputValue()
	{
		return CbValue.Text;
	}

	public (bool isValid, string message) Validate()
	{
		if (g2OLcQ4lY1R.IsRequired && string.IsNullOrEmpty(GetInputValue() as string))
		{
			return (isValid: false, message: "请输入或选择内容。");
		}
		string text = GetInputValue() as string;
		if (!string.IsNullOrEmpty(g2OLcQ4lY1R.Pattern) && !string.IsNullOrEmpty(text))
		{
			try
			{
				if (!Regex.IsMatch(text, g2OLcQ4lY1R.Pattern))
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

	public void UpdateValue(object value)
	{
		CbValue.Text = Convert.ToString(value);
	}

	public void SetReadOnly(bool isReadOnly)
	{
		CbValue.IsReadOnly = isReadOnly;
	}

	private void CbValue_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		bool flag = CbValue.SelectedItem is SimpleOperationItem;
	}

	private void T5FLcr2ygQF(object sender, TextChangedEventArgs e)
	{
		TriggerValueChange(g2OLcQ4lY1R);
	}

	public bool IsShouldUpdate()
	{
		if (g2OLcQ4lY1R.SelectionItems != null && g2OLcQ4lY1R.SelectionItems.StartsWithAny(false, "$=", "$$"))
		{
			return g2OLcQ4lY1R.ExtraSettings.HasLineStartWith("refresh_items");
		}
		return false;
	}

	public void Update(IVariableContext context)
	{
		if (!IsShouldUpdate())
		{
			return;
		}
		_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_0();
		_003C_003Ec__DisplayClass15_.qu3SoeG6Oym = CbValue.SelectedItem as string;
		string selectionItems = g2OLcQ4lY1R.SelectionItems;
		if (string.IsNullOrEmpty(selectionItems))
		{
			return;
		}
		selectionItems = XActionHelper.InterpolateOrEvalToString((ActionExecuteContext)context, selectionItems);
		cU5LcBAaFhO = selectionItems.Split(new string[2] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
		CbValue.ItemsSource = cU5LcBAaFhO;
		if (_003C_003Ec__DisplayClass15_.qu3SoeG6Oym != null)
		{
			string text = cU5LcBAaFhO.FirstOrDefault(_003C_003Ec__DisplayClass15_.f6YSohmrDig);
			if (text != null)
			{
				CbValue.SelectedItem = text;
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!v4sLcjc4K6g)
		{
			v4sLcjc4K6g = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/forms/controls/formeditwithautocompletedropdowncontrol.xaml", UriKind.Relative);
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
		if (connectionId == 1)
		{
			CbValue = (AutoCompleteComboBox)target;
			CbValue.AddHandler(TextBoxBase.TextChangedEvent, new TextChangedEventHandler(T5FLcr2ygQF));
		}
		else
		{
			v4sLcjc4K6g = true;
		}
	}

	static FormEditWithAutoCompleteDropdownControl()
	{
		fXmLcpOUonY = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool h1JwRTFKYpYhr3Eh8B4D()
	{
		return M45SrUFK5tpikl11hlm1 == null;
	}
}
