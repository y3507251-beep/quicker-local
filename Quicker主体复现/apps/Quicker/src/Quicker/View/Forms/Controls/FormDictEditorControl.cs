using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Markup;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Actions.X.Variables;
using Quicker.Public.Forms;
using Quicker.View.Controls;

namespace Quicker.View.Forms.Controls;

public class FormDictEditorControl : BaseFormFieldControl, IComponentConnector, IFormControl
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec CUZSo7aMSwQ;

		public static Func<KeyValuePair<string, object>, string> JFVSoRG3ra3;

		public static Func<KeyValuePair<string, object>, string> Us2Soq5o0Mc;

		public static Func<KeyValuePair<string, string>, string> RaLSocbFUXy;

		public static Func<KeyValuePair<string, string>, object> FICSoVnMVWx;

		public static Func<KeyValuePair<string, object>, string> PtsSoZmwljX;

		public static Func<KeyValuePair<string, object>, string> zYWSo9E6tnP;

		private static _003C_003Ec fn6oYTWs7tlGBbHmrulN;

		static _003C_003Ec()
		{
			CUZSo7aMSwQ = new _003C_003Ec();
		}

		internal string GI6SoCWlxqu(KeyValuePair<string, object> x)
		{
			return x.Key;
		}

		internal string EuUSoPE1cij(KeyValuePair<string, object> x)
		{
			return x.Value.ToString();
		}

		internal string GLwSoE5Na9J(KeyValuePair<string, string> x)
		{
			return x.Key;
		}

		internal object MIPSoy0NHdb(KeyValuePair<string, string> x)
		{
			return x.Value;
		}

		internal string AWXSo8OAruw(KeyValuePair<string, object> x)
		{
			return x.Key;
		}

		internal string XYISoaFCobI(KeyValuePair<string, object> x)
		{
			return x.Value.ToString();
		}

		internal static bool iCFmGPWs41ZeAJ68J7mQ()
		{
			return fn6oYTWs7tlGBbHmrulN == null;
		}
	}

	private FormField cVMLc61dH8G;

	private Dictionary<string, string> kiaLcXVxHVj;

	internal DictEditorControl Editor;

	private bool g5lLcmid01a;

	private static FormDictEditorControl dJ2xqrFKuEI8Tc2Te76O;

	public FormDictEditorControl()
	{
		InitializeComponent();
	}

	public void Init(FormField field, ActionVariable variable, IVariableContext context)
	{
		IDictionary<string, object> source = VariableHelper.ConvertToDict(context.IsVarExists(field.FieldKey) ? context.GetVarValue(field.FieldKey) : new Dictionary<string, object>());
		kiaLcXVxHVj = source.ToDictionary(_003C_003Ec.JFVSoRG3ra3 ?? (_003C_003Ec.JFVSoRG3ra3 = _003C_003Ec.CUZSo7aMSwQ.GI6SoCWlxqu), _003C_003Ec.Us2Soq5o0Mc ?? (_003C_003Ec.Us2Soq5o0Mc = _003C_003Ec.CUZSo7aMSwQ.EuUSoPE1cij));
		Editor.Data = kiaLcXVxHVj;
	}

	public object GetInputValue()
	{
		return Editor.Data.ToDictionary(_003C_003Ec.RaLSocbFUXy ?? (_003C_003Ec.RaLSocbFUXy = _003C_003Ec.CUZSo7aMSwQ.GLwSoE5Na9J), _003C_003Ec.FICSoVnMVWx ?? (_003C_003Ec.FICSoVnMVWx = _003C_003Ec.CUZSo7aMSwQ.MIPSoy0NHdb));
	}

	public (bool isValid, string message) Validate()
	{
		return (isValid: true, message: "");
	}

	public void SetFocus()
	{
		Editor.Focus();
	}

	public UIElement GetPrimaryElement()
	{
		return Editor;
	}

	public void SetInputWidth(double width)
	{
		Editor.Width = width;
	}

	public void UpdateValue(object value)
	{
		Dictionary<string, string> data = VariableHelper.ConvertToDict(value).ToDictionary(_003C_003Ec.PtsSoZmwljX ?? (_003C_003Ec.PtsSoZmwljX = _003C_003Ec.CUZSo7aMSwQ.AWXSo8OAruw), _003C_003Ec.zYWSo9E6tnP ?? (_003C_003Ec.zYWSo9E6tnP = _003C_003Ec.CUZSo7aMSwQ.XYISoaFCobI));
		Editor.Data = data;
	}

	public void SetReadOnly(bool isReadOnly)
	{
		Editor.IsEnabled = !isReadOnly;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!g5lLcmid01a)
		{
			g5lLcmid01a = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/forms/controls/formdicteditorcontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 1)
		{
			Editor = (DictEditorControl)target;
		}
		else
		{
			g5lLcmid01a = true;
		}
	}

	internal static bool Gjog8CFKoaMdIWJuhPk1()
	{
		return dJ2xqrFKuEI8Tc2Te76O == null;
	}
}
