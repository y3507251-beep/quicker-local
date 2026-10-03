using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using GuvA3OiyFyyWpKJlb8c;
using HandyControl.Controls;
using log4net;
using Quicker.Domain;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Modules.TextTools;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI.Wpf;
using Quicker.View.Controls;
using ViNASxihuuLY1Gg9m6p;
using wlFuCLYjBIXKFesp7Vo;

namespace Quicker.View;

public class UserInputWindow : HandyControl.Controls.Window, IComponentConnector, ITextControl, iTHRNJY2ZQQokysD4pN, IMockModalWindow
{
	private static readonly ILog jsNLgtApjI6;

	private readonly string b2SLggs8y2e;

	private readonly string o9YLgLOsHpY;

	private readonly string KO5LgvVETV5;

	private readonly string dHQLgSlQphI;

	public const string TYPE_TEXT = "text";

	public const string TYPE_MULTILINE = "multiline";

	public const string TYPE_NUMBER = "number";

	[CompilerGenerated]
	private double QxFLg2wm2Cs;

	[CompilerGenerated]
	private string bYZLgu7RGrF;

	[CompilerGenerated]
	private bool pLRLgNd7ZY8;

	[CompilerGenerated]
	private ShowWindowLocation? uyyLgJvbPJ9;

	[CompilerGenerated]
	private bool FpRLg0ZuFs8;

	[CompilerGenerated]
	private IntPtr MSwLgCQKt5D;

	[CompilerGenerated]
	private string l6aLgPRZpr0;

	[CompilerGenerated]
	private string aCvLgEqjcDF;

	[CompilerGenerated]
	private bool FTYLgyXVKQy;

	[CompilerGenerated]
	private ActionExecuteContext KGfLg8Rtusf;

	private int Wq1LgaCAcM7;

	private TextToolsReplaceMode? j0XLg7YwFWD;

	[CompilerGenerated]
	private bool? Nk9LgRlxU91;

	[CompilerGenerated]
	private CancellationTokenRegistration? RE2LgqKkvWo;

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

	internal Button BtnCancel;

	private bool TOeLgcaySpj;

	internal static UserInputWindow IoElLRF2O9xmBeENP77E;

	public double NumberValue
	{
		[CompilerGenerated]
		get
		{
			return QxFLg2wm2Cs;
		}
		[CompilerGenerated]
		set
		{
			QxFLg2wm2Cs = value;
		}
	}

	public string TextValue
	{
		[CompilerGenerated]
		get
		{
			return bYZLgu7RGrF;
		}
		[CompilerGenerated]
		set
		{
			bYZLgu7RGrF = value;
		}
	}

	public bool IsRequired
	{
		[CompilerGenerated]
		get
		{
			return pLRLgNd7ZY8;
		}
		[CompilerGenerated]
		set
		{
			pLRLgNd7ZY8 = value;
		}
	}

	public ShowWindowLocation? ShowLocation
	{
		[CompilerGenerated]
		get
		{
			return uyyLgJvbPJ9;
		}
		[CompilerGenerated]
		set
		{
			uyyLgJvbPJ9 = value;
		}
	}

	public bool CloseOnDeactivated
	{
		[CompilerGenerated]
		get
		{
			return FpRLg0ZuFs8;
		}
		[CompilerGenerated]
		set
		{
			FpRLg0ZuFs8 = value;
		}
	}

	public IntPtr HWnd
	{
		[CompilerGenerated]
		get
		{
			return MSwLgCQKt5D;
		}
		[CompilerGenerated]
		set
		{
			MSwLgCQKt5D = value;
		}
	}

	public string TextToolsStr
	{
		[CompilerGenerated]
		get
		{
			return l6aLgPRZpr0;
		}
		[CompilerGenerated]
		set
		{
			l6aLgPRZpr0 = value;
		}
	}

	public string ExtraSettingsStr
	{
		[CompilerGenerated]
		get
		{
			return aCvLgEqjcDF;
		}
		[CompilerGenerated]
		set
		{
			aCvLgEqjcDF = value;
		}
	}

	public bool SubmitWithReturn
	{
		[CompilerGenerated]
		get
		{
			return FTYLgyXVKQy;
		}
		[CompilerGenerated]
		set
		{
			FTYLgyXVKQy = value;
		}
	}

	public ActionExecuteContext ActionExecuteContext
	{
		[CompilerGenerated]
		get
		{
			return KGfLg8Rtusf;
		}
		[CompilerGenerated]
		set
		{
			KGfLg8Rtusf = value;
		}
	}

	public string HelpText
	{
		set
		{
			if (!string.IsNullOrEmpty(value))
			{
				HintButton.MarkDownToolTip = value;
				HintButton.Visibility = Visibility.Visible;
			}
		}
	}

	public bool? Result
	{
		[CompilerGenerated]
		get
		{
			return Nk9LgRlxU91;
		}
		[CompilerGenerated]
		set
		{
			Nk9LgRlxU91 = value;
		}
	}

	public CancellationTokenRegistration? CancellationTokenRegistration
	{
		[CompilerGenerated]
		get
		{
			return RE2LgqKkvWo;
		}
		[CompilerGenerated]
		set
		{
			RE2LgqKkvWo = value;
		}
	}

	public UserInputWindow(string valueType, string prompt, string pattern, string defaultValue)
	{
		b2SLggs8y2e = valueType;
		o9YLgLOsHpY = prompt;
		KO5LgvVETV5 = pattern;
		dHQLgSlQphI = defaultValue;
		InitializeComponent();
		base.Loaded += d5uLtAX1QM4;
		base.Deactivated += B1yLtMiH5ra;
		base.PreviewMouseDown += t82LtTBmQYG;
		base.PreviewMouseUp += A6ZLtooNCRl;
		AppHelper.AddGoToPageCommandBinding(this);
	}

	private void A6ZLtooNCRl(object sender, MouseButtonEventArgs e)
	{
		Wq1LgaCAcM7--;
	}

	private void t82LtTBmQYG(object sender, MouseButtonEventArgs e)
	{
		Wq1LgaCAcM7++;
	}

	[SpecialName]
	private bool eTPLtz2CLMw()
	{
		return Wq1LgaCAcM7 > 0;
	}

	private void B1yLtMiH5ra(object sender, EventArgs e)
	{
		if (CloseOnDeactivated && base.OwnedWindows.Count == 0 && !eTPLtz2CLMw())
		{
			this.ThNvuM5Q9GQ(false);
		}
	}

	private void d5uLtAX1QM4(object sender, RoutedEventArgs e)
	{
		int num;
		if (b2SLggs8y2e == "multiline")
		{
			base.ResizeMode = ResizeMode.CanResizeWithGrip;
			TxtData.Text = dHQLgSlQphI;
			num = 0;
			if (IoElLRF2O9xmBeENP77E != null)
			{
				goto IL_0052;
			}
		}
		else
		{
			TxtData.AcceptsReturn = false;
			num = 1;
			if (IoElLRF2O9xmBeENP77E != null)
			{
				goto IL_0052;
			}
		}
		goto IL_0056;
		IL_0056:
		switch (num)
		{
		default:
			TxtData.MinHeight = 50.0;
			TxtData.AcceptsReturn = true;
			if (!SubmitWithReturn)
			{
				LblTip.Text = "Ctrl+Enter/Alt+S 快速确认";
			}
			else
			{
				LblTip.Text = "Enter 快速确认, Shift+Enter换行";
			}
			break;
		case 1:
			TxtData.Text = dHQLgSlQphI.RemoveNewLine();
			LblTip.Text = "Enter 快速确认";
			break;
		}
		Activate();
		Focus();
		LblPrompt.Text = o9YLgLOsHpY;
		base.Dispatcher.InvokeAsync(ydFLtfkofFu);
		if (ShowLocation.HasValue)
		{
			UpdateLayout();
			IHNRIiikxBwJdYmHpM3.z5HvvDbvaW2(this, ShowLocation.Value);
		}
		else
		{
			IHNRIiikxBwJdYmHpM3.sE6vSvkrdZI(this);
		}
		HWnd = new WindowInteropHelper(this).Handle;
		fCcLtOy4q40();
		return;
		IL_0052:
		int num2 = default(int);
		num = num2;
		goto IL_0056;
	}

	private void fCcLtOy4q40()
	{
		TextTools.SetupTools(b2SLggs8y2e == "multiline", TextToolsStr.ParseToolsString(), this, new TextToolsContextHint(), null, ActionExecuteContext);
		if (string.IsNullOrEmpty(ExtraSettingsStr))
		{
			return;
		}
		string[] string_ = ExtraSettingsStr.SplitToList();
		try
		{
			IList<TextToolItem> list = TextToolsControl.hgdtLTVZCx6(string_);
			if (list.HasData())
			{
				TextTools.AddExtraTools(list);
			}
		}
		catch (Exception ex)
		{
			jsNLgtApjI6.Warn("字段扩展设置解析出错：" + ex.Message + "。数据：" + ExtraSettingsStr, ex);
			AppHelper.ShowWarning("扩展设置解析出错：" + ex.Message);
		}
		j0XLg7YwFWD = TextToolsControl.Bu8tLMnxv81(string_);
	}

	private void yAwLtFk6Diu(object sender, RoutedEventArgs e)
	{
		jnFLtUiFBdo();
	}

	private void jnFLtUiFBdo()
	{
		LblError.Text = "";
		int num;
		if (string.IsNullOrEmpty(TxtData.Text))
		{
			if (IsRequired)
			{
				LblError.Text = "不能为空！";
				return;
			}
			TextValue = string.Empty;
			NumberValue = 0.0;
			this.ThNvuM5Q9GQ(true);
			num = 0;
			if (!Sq1ABcF2JRuRnr0roBsg())
			{
				goto IL_0154;
			}
		}
		else
		{
			if (!string.IsNullOrEmpty(KO5LgvVETV5))
			{
				try
				{
					if (!Regex.IsMatch(TxtData.Text, KO5LgvVETV5))
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
			if (b2SLggs8y2e == "number")
			{
				double result = 0.0;
				if (!double.TryParse(TxtData.Text, out result))
				{
					LblError.Text = "请输入数字。";
					return;
				}
				TextValue = TxtData.Text;
				NumberValue = result;
				this.ThNvuM5Q9GQ(true);
				return;
			}
			TextValue = TxtData.Text;
			this.ThNvuM5Q9GQ(true);
			num = 1;
			if (IoElLRF2O9xmBeENP77E != null)
			{
				goto IL_0154;
			}
		}
		goto IL_0158;
		IL_0154:
		int num2 = default(int);
		num = num2;
		goto IL_0158;
		IL_0158:
		switch (num)
		{
		case 1:
			break;
		}
	}

	private void mqTLtljpLQg(object sender, KeyEventArgs e)
	{
		if (e.Key == Key.Return && (Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl)))
		{
			jnFLtUiFBdo();
			e.Handled = true;
			return;
		}
		if (!(b2SLggs8y2e == "multiline") || !SubmitWithReturn || e.Key != Key.Return)
		{
			goto IL_00e1;
		}
		int num = 1;
		if (Sq1ABcF2JRuRnr0roBsg())
		{
			goto IL_00c0;
		}
		goto IL_0116;
		IL_0116:
		string text = default(string);
		TxtData.Text = text;
		int caretIndex = default(int);
		TxtData.CaretIndex = caretIndex + Environment.NewLine.Length;
		e.Handled = true;
		return;
		IL_00c0:
		switch (num)
		{
		case 1:
			break;
		default:
			goto IL_0116;
		}
		if (!Keyboard.IsKeyDown(Key.LeftShift) && !Keyboard.IsKeyDown(Key.RightShift))
		{
			jnFLtUiFBdo();
			e.Handled = true;
			return;
		}
		goto IL_00e1;
		IL_00e1:
		if (!(b2SLggs8y2e == "multiline") || e.Key != Key.Return || (!Keyboard.IsKeyDown(Key.LeftShift) && !Keyboard.IsKeyDown(Key.RightShift)))
		{
			return;
		}
		caretIndex = TxtData.CaretIndex;
		text = TxtData.Text;
		if (string.IsNullOrEmpty(text))
		{
			text += Environment.NewLine;
			num = 0;
			if (Sq1ABcF2JRuRnr0roBsg())
			{
				goto IL_00c0;
			}
		}
		else
		{
			text = text.Insert(caretIndex, Environment.NewLine);
		}
		goto IL_0116;
	}

	public void SetFontFamily(string fontFamily)
	{
		try
		{
			TxtData.FontFamily = new FontFamily(fontFamily);
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("设置字体名称(" + fontFamily + ")失败：" + ex.Message);
		}
	}

	public void SetFontSize(double fontSize)
	{
		TxtData.FontSize = Math.Max(fontSize, 6.0);
	}

	public void SetHelplink(string helpLink)
	{
		if (string.IsNullOrEmpty(helpLink))
		{
			return;
		}
		string text;
		string uriString;
		if (helpLink.Contains("|"))
		{
			string[] array = helpLink.Split(new char[1] { '|' }, 2);
			text = array[0];
			uriString = array[1];
		}
		else
		{
			text = (uriString = helpLink);
		}
		try
		{
			LnkHelp.NavigateUri = new Uri(uriString);
			LnkHelp.Inlines.Add(text);
		}
		catch (Exception)
		{
			throw;
		}
	}

	private void FEFLtisw3Bp(object sender, TextSelectedEventArgs e)
	{
		TxtData.Text = e.Value;
	}

	private void TextToolsControl_OnValueSelected(object sender, TextSelectedEventArgs e)
	{
		if (j0XLg7YwFWD.HasValue)
		{
			TextToolsControl.UpdateTextValueWithReplaceMode(this, j0XLg7YwFWD.Value, e.Value);
		}
		else if (e.IsFullContent)
		{
			TxtData.Text = e.Value;
		}
		else
		{
			TxtData.SelectedText = e.Value;
		}
	}

	public string GetAllText()
	{
		return TxtData.Text;
	}

	public string GetSelectedText()
	{
		return TxtData.SelectedText;
	}

	public IList<ActionVariable> GetActionVariables()
	{
		return null;
	}

	public void SetAllText(string text)
	{
		TxtData.Text = text;
	}

	public void SetSelectedText(string text)
	{
		TxtData.SelectedText = text;
	}

	public void MoveCaretToEnd()
	{
		TxtData.CaretIndex = TxtData.Text.Length;
		TxtData.ScrollToEnd();
	}

	private void FAPLt3MIaWl(object sender, RoutedEventArgs e)
	{
		Close();
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!TOeLgcaySpj)
		{
			TOeLgcaySpj = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/ui/userinputwindow.xaml", UriKind.Relative);
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
		int num = 1;
		while (true)
		{
			switch (connectionId)
			{
			case 1:
				((UserInputWindow)target).PreviewKeyDown += mqTLtljpLQg;
				return;
			case 2:
				LblPrompt = (TextBlock)target;
				return;
			case 3:
				GridWrapper = (Grid)target;
				return;
			case 4:
				TxtData = (System.Windows.Controls.TextBox)target;
				return;
			case 5:
				TextTools = (TextToolsControl)target;
				return;
			case 6:
				LblError = (TextBlock)target;
				return;
			case 7:
				LblHelp = (TextBlock)target;
				return;
			case 8:
				LnkHelp = (Hyperlink)target;
				return;
			case 9:
				HintButton = (MarkdownHintButton)target;
				return;
			case 10:
				LblTip = (TextBlock)target;
				return;
			case 11:
				BtnOk = (Button)target;
				BtnOk.Click += yAwLtFk6Diu;
				return;
			case 12:
				BtnCancel = (Button)target;
				BtnCancel.Click += FAPLt3MIaWl;
				return;
			}
			int num2 = 0;
			if (IoElLRF2O9xmBeENP77E != null)
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			TOeLgcaySpj = true;
			return;
		}
	}

	static UserInputWindow()
	{
		jsNLgtApjI6 = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	[CompilerGenerated]
	private void ydFLtfkofFu()
	{
		TxtData.Focus();
	}

	internal static bool Sq1ABcF2JRuRnr0roBsg()
	{
		return IoElLRF2O9xmBeENP77E == null;
	}
}
