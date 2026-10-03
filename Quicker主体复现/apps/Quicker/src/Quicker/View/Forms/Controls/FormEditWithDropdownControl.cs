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
using log4net;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Modules.TextTools;
using Quicker.Public.Extensions;
using Quicker.Public.Forms;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.View.Controls;

namespace Quicker.View.Forms.Controls;

public class FormEditWithDropdownControl : BaseFormFieldControl, IComponentConnector, ITextControl, IFormControl, IUpdatableFieldControl
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec MZGSoIjdtvD;

		public static Func<string, SimpleOperationItem> J5RSoWB3Un2;

		internal static _003C_003Ec U1HE8EWCQ6KJJIkcsr8v;

		static _003C_003Ec()
		{
			MZGSoIjdtvD = new _003C_003Ec();
		}

		internal SimpleOperationItem LMISoYdtmVx(string x)
		{
			return new SimpleOperationItem
			{
				Key = x,
				Name = x
			};
		}

		internal static bool yl8clMWCFnYWDZWpfTSA()
		{
			return U1HE8EWCQ6KJJIkcsr8v == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass27_0
	{
		public string WL0SoGnK4G8;

		private static _003C_003Ec__DisplayClass27_0 db7yccWCWOtGWEFOHbgu;

		internal bool RfkSokLWwc2(SimpleOperationItem x)
		{
			return string.Equals(WL0SoGnK4G8, x.Key);
		}

		internal static bool CKYFhnWCy2Vku0WGEEc3()
		{
			return db7yccWCWOtGWEFOHbgu == null;
		}
	}

	private static readonly ILog WF7LcdPEWuk;

	private SmartCollection<SimpleOperationItem> yHcLco8UA57 = new SmartCollection<SimpleOperationItem>();

	private FormField BoGLcT4to66;

	private IVariableContext q4aLcMTLtO0;

	private ActionVariable G1OLcAdsEYi;

	internal Grid GridWrapper;

	internal ComboBox CbValue;

	internal TextToolsControl TextTools;

	private bool brnLcOa6TTm;

	internal static FormEditWithDropdownControl r5DNNwFKxsTuItN1SmtG;

	public FormEditWithDropdownControl()
	{
		InitializeComponent();
	}

	public void Init(FormField field, ActionVariable variable, IVariableContext context)
	{
		BoGLcT4to66 = field;
		string selectionItems = field.SelectionItems;
		q4aLcMTLtO0 = context;
		G1OLcAdsEYi = variable;
		selectionItems = (string.IsNullOrEmpty(selectionItems) ? "" : XActionHelper.InterpolateOrEvalToString((ActionExecuteContext)context, selectionItems));
		LaMLcnCwdg9(selectionItems);
		CbValue.ItemsSource = yHcLco8UA57;
		string text = (context.IsVarExists(field.FieldKey) ? Convert.ToString(context.GetVarValue(field.FieldKey)) : "");
		CbValue.Text = text;
		yiZLc4ItC5x();
	}

	private void LaMLcnCwdg9(string string_0)
	{
		if (string_0.StartsWith("|="))
		{
			yHcLco8UA57.Reset(AppHelper.StringToOperationItems(string_0, true));
			{
				foreach (SimpleOperationItem item in yHcLco8UA57)
				{
					item.ToStringFromKey = true;
				}
				return;
			}
		}
		yHcLco8UA57.Reset(string_0.Split(new string[2] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries).Select(_003C_003Ec.J5RSoWB3Un2 ?? (_003C_003Ec.J5RSoWB3Un2 = _003C_003Ec.MZGSoIjdtvD.LMISoYdtmVx)).ToList());
	}

	private void yiZLc4ItC5x()
	{
		if (!string.IsNullOrEmpty(BoGLcT4to66.TextTools))
		{
			TextTools.SetupTools(false, BoGLcT4to66.TextTools.ParseToolsString(), this, new TextToolsContextHint(), null, q4aLcMTLtO0 as ActionExecuteContext);
		}
		else
		{
			TextTools.SetupTools(false, Array.Empty<TextToolType>(), this, new TextToolsContextHint(), null, q4aLcMTLtO0 as ActionExecuteContext);
		}
		if (!string.IsNullOrEmpty(BoGLcT4to66.ExtraSettings))
		{
			try
			{
				scwLc5c87GC();
			}
			catch (Exception ex)
			{
				WF7LcdPEWuk.Warn("字段扩展设置解析出错：" + ex.Message + "。数据：" + BoGLcT4to66.ExtraSettings, ex);
				AppHelper.ShowWarning("字段扩展设置解析出错：" + ex.Message);
			}
		}
	}

	internal void scwLc5c87GC()
	{
		IList<TextToolItem> list = TextToolsControl.hgdtLTVZCx6(BoGLcT4to66.ExtraSettings.SplitToList());
		if (list.HasData())
		{
			TextTools.AddExtraTools(list);
		}
	}

	public object GetInputValue()
	{
		return CbValue.Text;
	}

	public (bool isValid, string message) Validate()
	{
		if (BoGLcT4to66.IsRequired && string.IsNullOrEmpty(GetInputValue() as string))
		{
			return (isValid: false, message: "请输入或选择内容。");
		}
		string text = GetInputValue() as string;
		if (!string.IsNullOrEmpty(BoGLcT4to66.Pattern) && !string.IsNullOrEmpty(text))
		{
			try
			{
				if (!Regex.IsMatch(text, BoGLcT4to66.Pattern))
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
		GridWrapper.HorizontalAlignment = HorizontalAlignment.Left;
		GridWrapper.Width = width;
	}

	public void UpdateValue(object value)
	{
		CbValue.Text = ((value == null) ? "" : Convert.ToString(value));
	}

	public void SetReadOnly(bool isReadOnly)
	{
		CbValue.IsReadOnly = isReadOnly;
	}

	private void CbValue_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
	}

	private void eESLcDD9QKe(object sender, TextChangedEventArgs e)
	{
		TriggerValueChange(BoGLcT4to66);
	}

	private void TextToolsControl_OnValueSelected(object sender, TextSelectedEventArgs e)
	{
		CbValue.Text = e.Value;
	}

	public string GetAllText()
	{
		return CbValue.Text;
	}

	public string GetSelectedText()
	{
		return CbValue.Text;
	}

	public IList<ActionVariable> GetActionVariables()
	{
		return null;
	}

	public void SetAllText(string text)
	{
		CbValue.Text = text;
	}

	public void SetSelectedText(string text)
	{
		CbValue.Text = text;
	}

	public void MoveCaretToEnd()
	{
	}

	public bool IsShouldUpdate()
	{
		if (BoGLcT4to66.SelectionItems != null && BoGLcT4to66.SelectionItems.StartsWithAny(false, "$=", "$$"))
		{
			return BoGLcT4to66.ExtraSettings.HasLineStartWith("refresh_items");
		}
		return false;
	}

	public void Update(IVariableContext context)
	{
		if (!IsShouldUpdate())
		{
			return;
		}
		_003C_003Ec__DisplayClass27_0 _003C_003Ec__DisplayClass27_ = new _003C_003Ec__DisplayClass27_0();
		_003C_003Ec__DisplayClass27_.WL0SoGnK4G8 = CbValue.Text;
		string selectionItems = BoGLcT4to66.SelectionItems;
		if (string.IsNullOrEmpty(selectionItems))
		{
			return;
		}
		selectionItems = XActionHelper.InterpolateOrEvalToString((ActionExecuteContext)context, selectionItems);
		LaMLcnCwdg9(selectionItems);
		CbValue.ItemsSource = yHcLco8UA57;
		if (_003C_003Ec__DisplayClass27_.WL0SoGnK4G8 == null)
		{
			return;
		}
		SimpleOperationItem simpleOperationItem = yHcLco8UA57.FirstOrDefault(_003C_003Ec__DisplayClass27_.RfkSokLWwc2);
		if (simpleOperationItem != null)
		{
			CbValue.SelectedItem = simpleOperationItem;
			int num = 0;
			if (r5DNNwFKxsTuItN1SmtG != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!brnLcOa6TTm)
		{
			brnLcOa6TTm = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/forms/controls/formeditwithdropdowncontrol.xaml", UriKind.Relative);
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
			brnLcOa6TTm = true;
			break;
		case 1:
			GridWrapper = (Grid)target;
			break;
		case 2:
			CbValue = (ComboBox)target;
			CbValue.SelectionChanged += CbValue_OnSelectionChanged;
			CbValue.AddHandler(TextBoxBase.TextChangedEvent, new TextChangedEventHandler(eESLcDD9QKe));
			break;
		case 3:
			TextTools = (TextToolsControl)target;
			break;
		}
	}

	static FormEditWithDropdownControl()
	{
		WF7LcdPEWuk = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static void txTHAxFKtXUpe0anFwAL()
	{
	}

	internal static bool Ekd3YlFKIgDAJFArvNJ6()
	{
		return r5DNNwFKxsTuItN1SmtG == null;
	}
}
