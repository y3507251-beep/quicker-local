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
using System.Windows.Media;
using HandyControl.Controls;
using log4net;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Forms;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.View.Forms.Controls;
using Z.Expressions;

namespace Quicker.View.Forms;

public class DictFormControl : UserControl, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec iRBSdH02L3D;

		public static Func<KeyValuePair<string, object>, string> VYpSd1FF3oK;

		public static Func<KeyValuePair<string, object>, object> I8qSdb9adaA;

		public static Func<KeyValuePair<string, object>, string> s2dSd6SmYOT;

		public static Func<KeyValuePair<string, object>, object> l9hSdXn69HA;

		internal static _003C_003Ec XjVB1kWsEnUoWtCrUYR2;

		static _003C_003Ec()
		{
			iRBSdH02L3D = new _003C_003Ec();
		}

		internal string Mv3SdWqJNYW(KeyValuePair<string, object> x)
		{
			return x.Key;
		}

		internal object D22SdkaWZY0(KeyValuePair<string, object> x)
		{
			return x.Value;
		}

		internal string uEwSdGXuxFw(KeyValuePair<string, object> x)
		{
			return x.Key;
		}

		internal object M3ySdskhHSd(KeyValuePair<string, object> x)
		{
			return x.Value;
		}

		internal static void LMeLbNWs14ZdRCj5J8Kj()
		{
		}

		internal static bool tOHilNWsGghoZFc8ICSw()
		{
			return XjVB1kWsEnUoWtCrUYR2 == null;
		}
	}

	private static readonly ILog DuuLR5Mnl86;

	private IDictionary<string, FormFieldWrapper> lCSLRDROQ62 = new Dictionary<string, FormFieldWrapper>();

	private IList<FrameworkElement> k9eLRdG6fco = new List<FrameworkElement>();

	private readonly ActionExecuteContext xdWLRoXtMOP;

	internal StackPanel PnlFields;

	private bool R3LLRTs8GGZ;

	private static DictFormControl oqAtOOF1j5eR4eGXKSN9;

	public DictFormControl()
	{
		InitializeComponent();
		xdWLRoXtMOP = new ActionExecuteContext(null, null, null, false, 0);
		SetValue(FormFieldWrapper.LabelHorizontalAlignmentProperty, HorizontalAlignment.Right);
		SetValue(FormFieldWrapper.LabelColWidthProperty, new GridLength(50.0));
	}

	public void UpdateForm(IList<FormField> fields, IDictionary<string, object> dataDict)
	{
		PnlFields.Children.Clear();
		lCSLRDROQ62.Clear();
		xdWLRoXtMOP.CustomData.Clear();
		foreach (KeyValuePair<string, object> item in dataDict)
		{
			xdWLRoXtMOP.SetVarValueWithoutConvert(item.Key, item.Value);
		}
		kRELRQxsDUI(fields, PnlFields);
	}

	private void kRELRQxsDUI(IList<FormField> ilist_1, Panel panel_0)
	{
		foreach (FormField item in ilist_1)
		{
			if (item.InputMethod != InputMethod.Separator && !string.IsNullOrEmpty(item.FieldKey))
			{
				ActionVariable actionVariable = null;
				actionVariable = new ActionVariable
				{
					Type = item.DictVarType.GetValueOrDefault(),
					Key = item.FieldKey,
					Desc = item.Label
				};
				FormFieldWrapper formFieldWrapper = new FormFieldWrapper();
				formFieldWrapper.ValueChanged += sglLRjTZ48P;
				panel_0.Children.Add(formFieldWrapper);
				formFieldWrapper.Init(item, actionVariable, xdWLRoXtMOP);
				lCSLRDROQ62[item.FieldKey] = formFieldWrapper;
			}
			else
			{
				FrameworkElement frameworkElement = null;
				frameworkElement = (string.IsNullOrEmpty(item.Label) ? new Divider
				{
					Margin = new Thickness(0.0, 15.0, 0.0, 15.0)
				} : ((!(item.Label == "[]")) ? ((FrameworkElement)new Divider
				{
					Content = item.Label,
					Margin = new Thickness(0.0, 15.0, 0.0, 10.0),
					HorizontalContentAlignment = HorizontalAlignment.Left,
					Foreground = Brushes.DarkGray,
					LineStroke = Brushes.Beige,
					FontWeight = FontWeights.Bold
				}) : ((FrameworkElement)new Border
				{
					Height = 25.0
				})));
				frameworkElement.Tag = item;
				k9eLRdG6fco.Add(frameworkElement);
				panel_0.Children.Add(frameworkElement);
			}
		}
	}

	private void sglLRjTZ48P(object object_0, FormField formField_0)
	{
		WJ1LRnotLgp();
	}

	private void WJ1LRnotLgp()
	{
		IDictionary<string, object> dictionary = new Dictionary<string, object>();
		try
		{
			dictionary = xdWLRoXtMOP.GetVariables().ToDictionary(_003C_003Ec.VYpSd1FF3oK ?? (_003C_003Ec.VYpSd1FF3oK = _003C_003Ec.iRBSdH02L3D.Mv3SdWqJNYW), _003C_003Ec.I8qSdb9adaA ?? (_003C_003Ec.I8qSdb9adaA = _003C_003Ec.iRBSdH02L3D.D22SdkaWZY0));
		}
		catch (Exception ex)
		{
			DuuLR5Mnl86.Warn("更新可见性出错：" + ex.Message, ex);
			try
			{
				dictionary = xdWLRoXtMOP.GetVariables().ToDictionary(_003C_003Ec.s2dSd6SmYOT ?? (_003C_003Ec.s2dSd6SmYOT = _003C_003Ec.iRBSdH02L3D.uEwSdGXuxFw), _003C_003Ec.l9hSdXn69HA ?? (_003C_003Ec.l9hSdXn69HA = _003C_003Ec.iRBSdH02L3D.M3ySdskhHSd));
			}
			catch (Exception)
			{
				return;
			}
		}
		foreach (string key in lCSLRDROQ62.Keys)
		{
			FormFieldWrapper formFieldWrapper = lCSLRDROQ62[key];
			if (formFieldWrapper.Visibility == Visibility.Visible)
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
			else
			{
				try
				{
					object inputValue2 = formFieldWrapper.GetInputValue();
					dictionary[key] = inputValue2;
				}
				catch
				{
				}
			}
		}
		foreach (FormFieldWrapper value in lCSLRDROQ62.Values)
		{
			if (!string.IsNullOrWhiteSpace(value.Field.VisibleExpression) && value.Field.VisibleExpression.StartsWith("$="))
			{
				try
				{
					value.Visibility = ((!YxyLR4mxKQs(value.Field.VisibleExpression, dictionary)) ? Visibility.Collapsed : Visibility.Visible);
				}
				catch (Exception exception)
				{
					AppHelper.ShowWarning("更新字段可见性出错：" + value.Field.FieldKey + " \n表达式：" + value.Field.VisibleExpression + "\n错误：" + exception.GetMessageWithInner());
				}
			}
		}
		foreach (FrameworkElement item in k9eLRdG6fco)
		{
			FormField formField = item.Tag as FormField;
			if (!string.IsNullOrWhiteSpace(formField.VisibleExpression) && formField.VisibleExpression.StartsWith("$="))
			{
				try
				{
					item.Visibility = ((!YxyLR4mxKQs(formField.VisibleExpression, dictionary)) ? Visibility.Collapsed : Visibility.Visible);
				}
				catch (Exception exception2)
				{
					AppHelper.ShowWarning("更新分割线可见性出错：" + formField.Label + " \n表达式：" + formField.VisibleExpression + "\n错误：" + exception2.GetMessageWithInner());
				}
			}
		}
	}

	private bool YxyLR4mxKQs(string string_0, IDictionary<string, object> idictionary_1)
	{
		IDictionary<string, object> dictionary = new Dictionary<string, object>();
		foreach (KeyValuePair<string, object> item in idictionary_1)
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

	public (bool isValud, string message, IDictionary<string, object> data) GetValues()
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		foreach (string key in lCSLRDROQ62.Keys)
		{
			FormFieldWrapper formFieldWrapper = lCSLRDROQ62[key];
			if (formFieldWrapper.Visibility == Visibility.Visible)
			{
				(bool, string) tuple = formFieldWrapper.Validate();
				if (!tuple.Item1)
				{
					return (isValud: false, message: "字段 " + key + " 的值不合法：" + tuple.Item2, data: null);
				}
				try
				{
					object inputValue = formFieldWrapper.GetInputValue();
					dictionary[key] = inputValue;
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("字段 " + formFieldWrapper.Field.Label + " 的值不合法：" + ex.Message, true);
					break;
				}
			}
		}
		return (isValud: true, message: "", data: dictionary);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!R3LLRTs8GGZ)
		{
			R3LLRTs8GGZ = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/forms/dictformcontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 1)
		{
			PnlFields = (StackPanel)target;
		}
		else
		{
			R3LLRTs8GGZ = true;
		}
	}

	static DictFormControl()
	{
		DuuLR5Mnl86 = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool yJMfqJF1DnUvsNtmUcIc()
	{
		return oqAtOOF1j5eR4eGXKSN9 == null;
	}
}
