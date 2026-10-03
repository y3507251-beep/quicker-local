using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Quicker.Utilities;

namespace Quicker.View.UI;

public class ValidMachinesEditorControl : UserControl, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec oY6S5UexaUB;

		public static Func<string, bool> bZUS5lXCo33;

		private static _003C_003Ec turvGfWT36IXGpweA0nl;

		static _003C_003Ec()
		{
			oY6S5UexaUB = new _003C_003Ec();
		}

		internal bool kWqS5FaqVWn(string x)
		{
			return string.Equals(x, Environment.MachineName, StringComparison.OrdinalIgnoreCase);
		}

		internal static bool pLLlv7WTEvxQfk4yrtvR()
		{
			return turvGfWT36IXGpweA0nl == null;
		}
	}

	internal TextBox TxtBindingMachine;

	internal Button BtnAddCurrentMachine;

	private bool lEFLystEbWx;

	internal static ValidMachinesEditorControl eOmVLFFGgC5A2NHLCxja;

	public string Text
	{
		get
		{
			return TxtBindingMachine.Text;
		}
		set
		{
			TxtBindingMachine.Text = value;
		}
	}

	public ValidMachinesEditorControl()
	{
		InitializeComponent();
	}

	private void UUaLyGmQfOj(object sender, RoutedEventArgs e)
	{
		if (string.IsNullOrEmpty(TxtBindingMachine.Text))
		{
			TxtBindingMachine.Text = Environment.MachineName;
			return;
		}
		string[] array = TxtBindingMachine.Text.Split(new char[4] { ';', ',', '；', '，' }, StringSplitOptions.RemoveEmptyEntries);
		if (array.Any(_003C_003Ec.bZUS5lXCo33 ?? (_003C_003Ec.bZUS5lXCo33 = _003C_003Ec.oY6S5UexaUB.kWqS5FaqVWn)))
		{
			AppHelper.ShowInformation("您已添加当前主机。");
		}
		else
		{
			TxtBindingMachine.Text = string.Join(";", array) + ";" + Environment.MachineName;
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!lEFLystEbWx)
		{
			lEFLystEbWx = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/ui/validmachineseditorcontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			lEFLystEbWx = true;
			break;
		case 2:
			BtnAddCurrentMachine = (Button)target;
			BtnAddCurrentMachine.Click += UUaLyGmQfOj;
			break;
		case 1:
			TxtBindingMachine = (TextBox)target;
			break;
		}
	}

	internal static bool LJe2aNFGPxeboQD1nB8y()
	{
		return eOmVLFFGgC5A2NHLCxja == null;
	}
}
