using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Markup;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Actions.X.Variables;
using Quicker.Public.Forms;
using Quicker.Utilities;
using r6fXttYOOCBwqrE78JP;

namespace Quicker.View.Forms.Controls;

public class FormDisplayControl : BaseFormFieldControl, IComponentConnector, IFormControl, IReadonlyFormControl
{
	private object SLxLcKybBhm;

	internal fEekKvYnWpx9eRgF1Fj TxtBlock;

	private bool UMhLcxXprRF;

	internal static FormDisplayControl k1mx4IFKqyUcJS5QFrgj;

	public FormDisplayControl()
	{
		InitializeComponent();
	}

	public void Init(FormField field, ActionVariable variable, IVariableContext context)
	{
		SLxLcKybBhm = (context.IsVarExists(field.FieldKey) ? context.GetVarValue(field.FieldKey) : "");
		TxtBlock.Text = VariableHelper.LcfghRCibTg(SLxLcKybBhm);
	}

	public object GetInputValue()
	{
		return SLxLcKybBhm;
	}

	public (bool isValid, string message) Validate()
	{
		return (isValid: true, message: "not changed");
	}

	public void SetFocus()
	{
	}

	public UIElement GetPrimaryElement()
	{
		return TxtBlock;
	}

	public void SetInputWidth(double width)
	{
	}

	public void UpdateValue(object value)
	{
		TxtBlock.Text = VariableHelper.LcfghRCibTg(value);
	}

	public void SetReadOnly(bool isReadOnly)
	{
	}

	private void TxtBlock_OnSelectionChanged(object sender, EventArgs e)
	{
		try
		{
			string text = TxtBlock.UeWLrvSJ831();
			if (text != null && text.Length > 0)
			{
				AppHelper.TryCopy(text, true);
			}
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning(ex.Message);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!UMhLcxXprRF)
		{
			UMhLcxXprRF = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/forms/controls/formdisplaycontrol.xaml", UriKind.Relative);
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
			TxtBlock = (fEekKvYnWpx9eRgF1Fj)target;
		}
		else
		{
			UMhLcxXprRF = true;
		}
	}

	internal static bool k3XD3HFKiycfm3kFkMa1()
	{
		return k1mx4IFKqyUcJS5QFrgj == null;
	}
}
