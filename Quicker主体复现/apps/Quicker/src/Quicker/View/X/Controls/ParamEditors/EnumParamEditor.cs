using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Utilities._3rd;

namespace Quicker.View.X.Controls.ParamEditors;

public class EnumParamEditor : BaseParamEditor, IComponentConnector
{
	internal ComboBox CbEnum;

	private bool TSyLmxjanvN;

	private static EnumParamEditor gNZBADFL1ODxVqFl6xLD;

	public EnumParamEditor(StepInParamDef paramDef, ActionStepParam actionStepParam)
		: base(paramDef, actionStepParam)
	{
		InitializeComponent();
		MdWLmXEVJPu();
	}

	private void MdWLmXEVJPu()
	{
		CbEnum.IsEditable = _paramDef.AllowInput;
		if (_paramDef.SelectionItems != null && _paramDef.SelectionItems.Count > 0)
		{
			CbEnum.ItemsSource = _paramDef.SelectionItems;
		}
		if (_paramData.Value == null)
		{
			return;
		}
		SelectionItem selectionItem = _paramDef.SelectionItems.FirstOrDefault(IynLmKJwahf);
		if (selectionItem != null)
		{
			CbEnum.SelectedItem = selectionItem;
		}
		else if (_paramDef.AllowInput)
		{
			if (!YWxhjgFLKUckU7OrJ6As())
			{
				switch (0)
				{
				}
			}
			CbEnum.Text = _paramData.Value;
		}
		else if (!string.IsNullOrEmpty(_paramData.Value))
		{
			SmartCollection<SelectionItem> smartCollection = new SmartCollection<SelectionItem>(_paramDef.SelectionItems);
			SelectionItem selectionItem2 = new SelectionItem(_paramData.Value, "【已过时】" + _paramData.Value);
			smartCollection.Add(selectionItem2);
			CbEnum.ItemsSource = smartCollection;
			CbEnum.SelectedItem = selectionItem2;
		}
	}

	private void lddLmmf8DcU(object sender, SelectionChangedEventArgs e)
	{
		NotifyValueChange();
	}

	public override ActionStepParam GetParamValue()
	{
		ActionStepParam actionStepParam = new ActionStepParam();
		SelectionItem obj = CbEnum.SelectedItem as SelectionItem;
		object obj2;
		if (obj == null)
		{
			obj2 = null;
		}
		else
		{
			obj2 = obj.Value;
			if (obj2 != null)
			{
				goto IL_0045;
			}
		}
		obj2 = (_paramDef.AllowInput ? CbEnum.Text : "");
		goto IL_0045;
		IL_0045:
		actionStepParam.Value = (string)obj2;
		return actionStepParam;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!TSyLmxjanvN)
		{
			TSyLmxjanvN = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/x/stepeditor/parameditors/enumparameditor.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 1)
		{
			CbEnum = (ComboBox)target;
			CbEnum.SelectionChanged += lddLmmf8DcU;
		}
		else
		{
			TSyLmxjanvN = true;
		}
	}

	[CompilerGenerated]
	private bool IynLmKJwahf(SelectionItem selectionItem_0)
	{
		return selectionItem_0.Value.Equals(_paramData.Value, StringComparison.OrdinalIgnoreCase);
	}

	internal static bool YWxhjgFLKUckU7OrJ6As()
	{
		return gNZBADFL1ODxVqFl6xLD == null;
	}
}
