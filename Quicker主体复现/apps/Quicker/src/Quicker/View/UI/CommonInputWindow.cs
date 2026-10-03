using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Markup;
using GuvA3OiyFyyWpKJlb8c;
using HandyControl.Controls;
using Quicker.Modules.TextTools;
using Quicker.Utilities;
using Quicker.Utilities.UI.Wpf;
using Quicker.View.Controls;

namespace Quicker.View.UI;

public class CommonInputWindow : HandyControl.Controls.Window, IComponentConnector, IMockModalWindow
{
	private readonly string xW7L0R2CDeb;

	[CompilerGenerated]
	private Func<string, string> gXLL0qJNjEA;

	[CompilerGenerated]
	private bool YPeL0cUHecZ;

	[CompilerGenerated]
	private bool? BC6L0VLhwmQ;

	internal TextBlock LblPrompt;

	internal Grid GridWrapper;

	internal System.Windows.Controls.TextBox TxtData;

	internal TextToolsControl TextTools;

	internal TextBlock LblError;

	internal TextBlock LblHelp;

	internal Hyperlink LnkHelp;

	internal MarkdownHintButton HintButton;

	internal TextBlock LblTip;

	internal Button BtnOk;

	private bool eWYL0Zn3AwN;

	private static CommonInputWindow YJVJLiF3oE9gVLYuSiKQ;

	public string Prompt
	{
		get
		{
			return LblPrompt.Text;
		}
		set
		{
			LblPrompt.Text = value;
		}
	}

	public string Text
	{
		get
		{
			return TxtData.Text;
		}
		set
		{
			TxtData.Text = value;
		}
	}

	public bool IsRequired
	{
		[CompilerGenerated]
		get
		{
			return YPeL0cUHecZ;
		}
		[CompilerGenerated]
		set
		{
			YPeL0cUHecZ = value;
		}
	}

	public bool? Result
	{
		[CompilerGenerated]
		get
		{
			return BC6L0VLhwmQ;
		}
		[CompilerGenerated]
		set
		{
			BC6L0VLhwmQ = value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private Func<string, string> ku0L08Nk028()
	{
		return gXLL0qJNjEA;
	}

	[SpecialName]
	[CompilerGenerated]
	private void W0OL0aVTad7(Func<string, string> value)
	{
		gXLL0qJNjEA = value;
	}

	public CommonInputWindow(string title, string prompt, bool required, string defaultValue = "", string pattern = "", Func<string, string> validator = null)
	{
		xW7L0R2CDeb = pattern;
		InitializeComponent();
		base.Title = title;
		Prompt = prompt;
		IsRequired = required;
		TxtData.Text = defaultValue ?? "";
		W0OL0aVTad7(validator);
		base.Loaded += y9DL0CkOhnr;
	}

	private void y9DL0CkOhnr(object sender, RoutedEventArgs e)
	{
		TxtData.Focus();
	}

	private void xIFL0PP5EYm(object sender, RoutedEventArgs e)
	{
		osKL0EsoCjF();
	}

	private void osKL0EsoCjF()
	{
		LblError.Text = "";
		if (string.IsNullOrEmpty(TxtData.Text))
		{
			if (IsRequired)
			{
				LblError.Text = "不能为空！";
			}
			else
			{
				this.ThNvuM5Q9GQ(true);
			}
			return;
		}
		if (!string.IsNullOrEmpty(xW7L0R2CDeb))
		{
			try
			{
				if (!Regex.IsMatch(TxtData.Text, xW7L0R2CDeb))
				{
					LblError.Text = "格式不符合要求。";
					return;
				}
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("无法验证格式！" + ex.Message);
				return;
			}
		}
		if (ku0L08Nk028() != null)
		{
			int num = 0;
			if (YJVJLiF3oE9gVLYuSiKQ != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			string text = ku0L08Nk028()(Text);
			if (!string.IsNullOrEmpty(text))
			{
				AppHelper.ShowWarning(text);
				return;
			}
		}
		this.ThNvuM5Q9GQ(true);
	}

	private void TextToolsControl_OnValueSelected(object sender, TextSelectedEventArgs e)
	{
		Text = e.Value;
	}

	private void hbxL0yWCkE0(object sender, RoutedEventArgs e)
	{
		Close();
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!eWYL0Zn3AwN)
		{
			eWYL0Zn3AwN = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/ui/commoninputwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			eWYL0Zn3AwN = true;
			break;
		case 1:
			LblPrompt = (TextBlock)target;
			break;
		case 2:
			GridWrapper = (Grid)target;
			break;
		case 3:
			TxtData = (System.Windows.Controls.TextBox)target;
			break;
		case 4:
			TextTools = (TextToolsControl)target;
			break;
		case 5:
			LblError = (TextBlock)target;
			break;
		case 6:
			LblHelp = (TextBlock)target;
			break;
		case 7:
			LnkHelp = (Hyperlink)target;
			break;
		case 8:
			HintButton = (MarkdownHintButton)target;
			break;
		case 9:
			LblTip = (TextBlock)target;
			break;
		case 10:
			BtnOk = (Button)target;
			if (YJVJLiF3oE9gVLYuSiKQ != null)
			{
				switch (0)
				{
				}
			}
			BtnOk.Click += xIFL0PP5EYm;
			break;
		case 11:
			((Button)target).Click += hbxL0yWCkE0;
			break;
		}
	}

	internal static bool WfrokfF3fVAphxuf4Qfx()
	{
		return YJVJLiF3oE9gVLYuSiKQ == null;
	}
}
