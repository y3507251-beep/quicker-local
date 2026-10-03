using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Newtonsoft.Json;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Forms;
using Quicker.Utilities;
using Quicker.View.Forms;

namespace Quicker.View.X.Controls.ParamEditors;

public class FormParamEditor : BaseParamEditor, IComponentConnector
{
	private readonly bool iBGLmpR3edr;

	internal TextBlock LblFormInfo;

	internal Button BtnEditForm;

	private bool pe0LmBTUOKj;

	private static FormParamEditor hLlvExFLv7IZdV7UpnVo;

	public FormParamEditor(StepInParamDef paramDef, ActionStepParam actionStepParam, bool forDict)
		: base(paramDef, actionStepParam)
	{
		iBGLmpR3edr = forDict;
		InitializeComponent();
		TextBlock lblFormInfo = LblFormInfo;
		object obj;
		if (actionStepParam == null)
		{
			obj = null;
		}
		else
		{
			obj = actionStepParam.Value;
			if (obj != null)
			{
				goto IL_0030;
			}
		}
		obj = string.Empty;
		goto IL_0030;
		IL_0030:
		lblFormInfo.Tag = obj;
	}

	public override ActionStepParam GetParamValue()
	{
		return new ActionStepParam
		{
			Value = (string)LblFormInfo.Tag
		};
	}

	private void ee3LmrXaTCA(object sender, RoutedEventArgs e)
	{
		string value = LblFormInfo.Tag as string;
		Form editingForm = null;
		if (!string.IsNullOrEmpty(value))
		{
			try
			{
				editingForm = JsonConvert.DeserializeObject<Form>(value);
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("表单数据格式错误，不是合法的JSON：" + ex.Message);
				return;
			}
		}
		FormDesignerWindow formDesignerWindow = new FormDesignerWindow(((ActionStepEditorWindow)Window.GetWindow(this)).Variables, editingForm, iBGLmpR3edr)
		{
			Owner = Window.GetWindow(this)
		};
		if (hLlvExFLv7IZdV7UpnVo != null)
		{
			switch (0)
			{
			}
		}
		if (formDesignerWindow.ShowDialog() == true)
		{
			Form resultForm = formDesignerWindow.ResultForm;
			LblFormInfo.Tag = JsonConvert.SerializeObject(resultForm);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!pe0LmBTUOKj)
		{
			pe0LmBTUOKj = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/x/stepeditor/parameditors/formparameditor.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			pe0LmBTUOKj = true;
			break;
		case 2:
			BtnEditForm = (Button)target;
			BtnEditForm.Click += ee3LmrXaTCA;
			break;
		case 1:
			LblFormInfo = (TextBlock)target;
			break;
		}
	}

	internal static bool dKgIa1FLdEB8DKvMBThk()
	{
		return hLlvExFLv7IZdV7UpnVo == null;
	}
}
