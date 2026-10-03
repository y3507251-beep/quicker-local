using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using HandyControl.Controls;
using log4net;
using Quicker.Domain;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Actions.X.Variables;
using Quicker.Domain.Forms;
using Quicker.Public.Extensions;
using Quicker.Public.Forms;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;
using Quicker.View.Controls;
using Quicker.View.Forms.Controls;
using ToastNotifications.Utilities;
using ViNASxihuuLY1Gg9m6p;
using wlFuCLYjBIXKFesp7Vo;
using Z.Expressions;

namespace Quicker.View.Forms;

public class FormWindow : HandyControl.Controls.Window, IComponentConnector, iTHRNJY2ZQQokysD4pN
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec NjeSdzfvQ8S;

		public static Func<FormField, string> rUCSownu1Ia;

		public static Func<FormFieldWrapper, bool> ejsSotXwDaI;

		internal static _003C_003Ec FVBA0OWsZyMT2MhVZOtV;

		static _003C_003Ec()
		{
			NjeSdzfvQ8S = new _003C_003Ec();
		}

		internal string mrgSd3Le3VY(FormField x)
		{
			return x.Group.Or(string.Empty);
		}

		internal bool p8ZSdfuHJTt(FormFieldWrapper x)
		{
			return x.IsShouldUpdate();
		}

		internal static bool XkkjgdWs5j2qbaUGdL0O()
		{
			return FVBA0OWsZyMT2MhVZOtV == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass60_0
	{
		public string qreSovaW5VT;

		private static _003C_003Ec__DisplayClass60_0 dZYMYOWs8RGctgHYo5J1;

		internal bool eL1SogKGjlZ(FormField x)
		{
			return x.Group.Or(string.Empty).Equals(qreSovaW5VT);
		}

		internal bool ifRSoLV1UUq(string x)
		{
			if (x.StartsWith(qreSovaW5VT) && x.Length > qreSovaW5VT.Length + 1)
			{
				return x[qreSovaW5VT.Length].IsEither(':', '：');
			}
			return false;
		}

		static _003C_003Ec__DisplayClass60_0()
		{
		}

		internal static bool GwLhRmWsR3F8BrwSm1nn()
		{
			return dZYMYOWs8RGctgHYo5J1 == null;
		}

		internal static void EMS6kdWsPjM4DjHPS3uM()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass62_0
	{
		public FormField KnYSo2hqDjN;

		private static _003C_003Ec__DisplayClass62_0 nrflYqWsM6GPuKA9r8mB;

		internal bool blMSoSrPMZ4(ActionVariable x)
		{
			return x.Key == KnYSo2hqDjN.FieldKey;
		}

		internal static bool NEWSk8WsU9fbxL6bOGha()
		{
			return nrflYqWsM6GPuKA9r8mB == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass80_0
	{
		public FormField NHeSoNkbDTl;

		internal static _003C_003Ec__DisplayClass80_0 Ysf1HuWsIwmEBfGdNtHK;

		internal bool xZ2SouSOUVE(ActionVariable x)
		{
			return x.Key == NHeSoNkbDTl.FieldKey;
		}

		internal static bool WMRLLyWs6s3gDFqIZXFF()
		{
			return Ysf1HuWsIwmEBfGdNtHK == null;
		}
	}

	private static readonly ILog AVjLc0INcNO;

	private readonly ActionExecuteContext WwZLcCn82Sw;

	private readonly XAction DrjLcPyXfqe;

	private readonly bool L3PLcEBAhOy;

	private ActionExecuteContext Qv3LcyDS7LP;

	private IDictionary<string, FormFieldWrapper> BGgLc8eu2Lk = new Dictionary<string, FormFieldWrapper>();

	private Form b5OLcaSyhvq;

	private IList<FrameworkElement> lceLc7eThSo = new List<FrameworkElement>();

	private bool l7oLcRCThPl;

	[CompilerGenerated]
	private bool tNgLcqjX8BC;

	[CompilerGenerated]
	private IDictionary<string, object> xcdLccbqbvK;

	[CompilerGenerated]
	private string CwJLcV9kmvT = "";

	[CompilerGenerated]
	private string EmHLcZVAG1s;

	[CompilerGenerated]
	private double MuELc9ylFaV;

	[CompilerGenerated]
	private string gErLchw7XbS;

	[CompilerGenerated]
	private ShowWindowLocation ExSLce1Q9sc = ShowWindowLocation.CenterScreen;

	[CompilerGenerated]
	private string aQiLcYC7X2a;

	[CompilerGenerated]
	private string AiZLcImOC0A;

	[CompilerGenerated]
	private CancellationTokenRegistration? CMtLcWXRydP;

	private bool axyLckG4inB;

	internal FormWindow TheWindow;

	internal System.Windows.Controls.TabControl TheTabs;

	internal System.Windows.Controls.ScrollViewer BodyScroll;

	internal StackPanel PnlFields;

	internal TextBlock LblHelp;

	internal Grid ButtonPanel;

	internal MarkdownHintButton HintButton;

	internal Button BtnOk;

	internal ToolBar PnlCustomButtons;

	internal Button BtnCancel;

	internal Button BtnReset;

	private bool cxkLcGJbBE6;

	private static FormWindow PWxgKkF1hwkkbYqPTgX0;

	public bool IsSuccess
	{
		[CompilerGenerated]
		get
		{
			return tNgLcqjX8BC;
		}
		[CompilerGenerated]
		private set
		{
			tNgLcqjX8BC = value;
		}
	}

	public IDictionary<string, object> Values
	{
		[CompilerGenerated]
		get
		{
			return xcdLccbqbvK;
		}
		[CompilerGenerated]
		private set
		{
			xcdLccbqbvK = value;
		}
	}

	public string ClickedConfirmButtonValue
	{
		[CompilerGenerated]
		get
		{
			return CwJLcV9kmvT;
		}
		[CompilerGenerated]
		set
		{
			CwJLcV9kmvT = value;
		}
	}

	public string PreSelectedGroup
	{
		[CompilerGenerated]
		get
		{
			return EmHLcZVAG1s;
		}
		[CompilerGenerated]
		set
		{
			EmHLcZVAG1s = value;
		}
	}

	public double DefaultInputWidth
	{
		[CompilerGenerated]
		get
		{
			return MuELc9ylFaV;
		}
		[CompilerGenerated]
		set
		{
			MuELc9ylFaV = value;
		}
	}

	public string SelectedGroup
	{
		[CompilerGenerated]
		get
		{
			return gErLchw7XbS;
		}
		[CompilerGenerated]
		set
		{
			gErLchw7XbS = value;
		}
	}

	public ShowWindowLocation Location
	{
		[CompilerGenerated]
		get
		{
			return ExSLce1Q9sc;
		}
		[CompilerGenerated]
		set
		{
			ExSLce1Q9sc = value;
		}
	}

	public string WindowSizeStr
	{
		[CompilerGenerated]
		get
		{
			return aQiLcYC7X2a;
		}
		[CompilerGenerated]
		set
		{
			aQiLcYC7X2a = value;
		}
	}

	public string HelpText
	{
		[CompilerGenerated]
		get
		{
			return AiZLcImOC0A;
		}
		[CompilerGenerated]
		set
		{
			AiZLcImOC0A = value;
		}
	}

	public string MarkdownHelp
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

	public bool EnableEnterSubmit
	{
		get
		{
			return BtnOk.IsDefault;
		}
		set
		{
			BtnOk.IsDefault = value;
		}
	}

	public CancellationTokenRegistration? CancellationTokenRegistration
	{
		[CompilerGenerated]
		get
		{
			return CMtLcWXRydP;
		}
		[CompilerGenerated]
		set
		{
			CMtLcWXRydP = value;
		}
	}

	[SpecialName]
	private bool SJ8LcNAw80D()
	{
		return TheTabs.Visibility == Visibility.Visible;
	}

	public FormWindow(string title, Form form, ActionExecuteContext context, XAction action, double titleColumnWidth, bool isForDict, string helpText, double defaultInputWidth)
	{
		WwZLcCn82Sw = context;
		DrjLcPyXfqe = action;
		L3PLcEBAhOy = isForDict;
		b5OLcaSyhvq = form;
		HelpText = helpText;
		DefaultInputWidth = defaultInputWidth;
		Ej9LqiGJXsS();
		FormFieldWrapper.SetLabelColWidth(this, (titleColumnWidth > 0.0) ? new GridLength(titleColumnWidth) : GridLength.Auto);
		InitializeComponent();
		if (!string.IsNullOrEmpty(title))
		{
			base.Title = title;
		}
		lJ5Lq5T5lHw(form);
		LblHelp.Text = HelpText;
		base.Loaded += D8nLqAYedEy;
		base.SourceInitialized += ahqLqMyrRU8;
		AppHelper.AddGoToPageCommandBinding(this);
		AddHandler(Keyboard.PreviewKeyDownEvent, new KeyEventHandler(X1ELqTsg3qi));
	}

	public void SetConfirmButtonTitle(string title)
	{
		BtnOk.Content = title;
	}

	public void SetCustomButtons(string customButtons)
	{
		string[] array = customButtons.SplitToList();
		int num2 = default(int);
		for (int i = 0; i < array.Length; i++)
		{
			string[] array2 = array[i].SplitToList('|');
			string tag = array2[0];
			if (array2.Length == 2)
			{
				tag = array2[1];
			}
			Button button = new Button();
			button.Content = array2[0];
			button.Style = FindResource("ButtonPrimary") as Style;
			button.Margin = new Thickness(10.0, 2.0, 0.0, 1.0);
			button.Tag = tag;
			button.Click += bMPLcLSuCZh;
			PnlCustomButtons.Items.Add(button);
			int num = 0;
			if (PWxgKkF1hwkkbYqPTgX0 != null)
			{
				num = num2;
			}
			switch (num)
			{
			}
		}
	}

	private void lJ5Lq5T5lHw(Form form_1)
	{
		if (form_1 != null && form_1.Fields.HasData())
		{
			List<string> list = form_1.Fields.Select(_003C_003Ec.rUCSownu1Ia ?? (_003C_003Ec.rUCSownu1Ia = _003C_003Ec.NjeSdzfvQ8S.mrgSd3Le3VY)).Distinct().ToList();
			if (list.Count() == 1)
			{
				if (PWxgKkF1hwkkbYqPTgX0 != null)
				{
					switch (0)
					{
					}
				}
				GJkLqdUuXn2(form_1);
			}
			else
			{
				uVXLqDiw0oB(form_1, list);
			}
			aD0LqfnEZGA(null);
		}
		else
		{
			AppHelper.ShowWarning("表单为空！");
		}
	}

	private void uVXLqDiw0oB(Form form_1, List<string> list_0)
	{
		BodyScroll.Visibility = Visibility.Collapsed;
		TheTabs.Visibility = Visibility.Visible;
		TheTabs.MouseWheel += UVOLqF3XuIp;
		TheTabs.SelectionChanged += oV0LqOeLKuT;
		using List<string>.Enumerator enumerator = list_0.GetEnumerator();
		while (enumerator.MoveNext())
		{
			_003C_003Ec__DisplayClass60_0 _003C_003Ec__DisplayClass60_ = new _003C_003Ec__DisplayClass60_0();
			_003C_003Ec__DisplayClass60_.qreSovaW5VT = enumerator.Current;
			System.Windows.Controls.TabItem tabItem = new System.Windows.Controls.TabItem();
			tabItem.Header = _003C_003Ec__DisplayClass60_.qreSovaW5VT.Or("其它");
			System.Windows.Controls.ScrollViewer scrollViewer = new System.Windows.Controls.ScrollViewer();
			scrollViewer.SetValue(ScrollViewerAttach.AutoHideProperty, false);
			StackPanel stackPanel = new StackPanel();
			stackPanel.Margin = new Thickness(15.0, 8.0, 15.0, 8.0);
			scrollViewer.Content = stackPanel;
			tabItem.Content = scrollViewer;
			TheTabs.Items.Add(tabItem);
			List<FormField> ilist_ = form_1.Fields.Where(_003C_003Ec__DisplayClass60_.eL1SogKGjlZ).ToList();
			xiOLqomRYO2(ilist_, stackPanel);
			if (string.IsNullOrEmpty(HelpText))
			{
				continue;
			}
			string text = HelpText;
			object obj;
			if (HelpText.StartsWith("//groups"))
			{
				string text2 = HelpText.SplitToList(true).FirstOrDefault(_003C_003Ec__DisplayClass60_.ifRSoLV1UUq);
				if (text2 == null)
				{
					obj = null;
				}
				else
				{
					obj = text2.Substring(_003C_003Ec__DisplayClass60_.qreSovaW5VT.Length + 1).Trim().Replace("\\r\\n", "\r\n");
					if (obj != null)
					{
						goto IL_019b;
					}
				}
				obj = "";
				goto IL_019b;
			}
			goto IL_019d;
			IL_019d:
			if (!string.IsNullOrEmpty(text))
			{
				TextBlock textBlock = new TextBlock();
				textBlock.Text = text;
				textBlock.Margin = new Thickness(10.0, 10.0, 10.0, 10.0);
				textBlock.Style = FindResource("HelpText") as Style;
				textBlock.Foreground = Brushes.DarkOrange;
				textBlock.HorizontalAlignment = HorizontalAlignment.Left;
				stackPanel.Children.Add(textBlock);
			}
			continue;
			IL_019b:
			text = (string)obj;
			goto IL_019d;
		}
	}

	private void GJkLqdUuXn2(Form form_1)
	{
		xiOLqomRYO2(form_1.Fields, PnlFields);
	}

	private void xiOLqomRYO2(IList<FormField> ilist_1, Panel panel_0)
	{
		using IEnumerator<FormField> enumerator = ilist_1.GetEnumerator();
		while (enumerator.MoveNext())
		{
			_003C_003Ec__DisplayClass62_0 _003C_003Ec__DisplayClass62_ = new _003C_003Ec__DisplayClass62_0();
			_003C_003Ec__DisplayClass62_.KnYSo2hqDjN = enumerator.Current;
			if (_003C_003Ec__DisplayClass62_.KnYSo2hqDjN.InputMethod != Quicker.Public.Forms.InputMethod.Separator && !string.IsNullOrEmpty(_003C_003Ec__DisplayClass62_.KnYSo2hqDjN.FieldKey))
			{
				ActionVariable actionVariable = null;
				if (L3PLcEBAhOy)
				{
					actionVariable = new ActionVariable
					{
						Type = _003C_003Ec__DisplayClass62_.KnYSo2hqDjN.DictVarType.GetValueOrDefault(),
						Key = _003C_003Ec__DisplayClass62_.KnYSo2hqDjN.FieldKey,
						Desc = _003C_003Ec__DisplayClass62_.KnYSo2hqDjN.Label
					};
				}
				else
				{
					actionVariable = DrjLcPyXfqe.Variables.FirstOrDefault(_003C_003Ec__DisplayClass62_.blMSoSrPMZ4);
					if (actionVariable == null)
					{
						AVjLc0INcNO.Warn("变量 " + _003C_003Ec__DisplayClass62_.KnYSo2hqDjN.FieldKey + " 不存在。");
						AppHelper.ShowWarning("变量 " + _003C_003Ec__DisplayClass62_.KnYSo2hqDjN.FieldKey + " 不存在。");
					}
				}
				FormFieldWrapper formFieldWrapper = new FormFieldWrapper();
				formFieldWrapper.ValueChanged += gg7Lq3uncA3;
				panel_0.Children.Add(formFieldWrapper);
				formFieldWrapper.Init(_003C_003Ec__DisplayClass62_.KnYSo2hqDjN, actionVariable, WwZLcCn82Sw, DefaultInputWidth);
				if (_003C_003Ec__DisplayClass62_.KnYSo2hqDjN.ReadOnly)
				{
					formFieldWrapper.SetReadOnly(true);
				}
				BGgLc8eu2Lk[_003C_003Ec__DisplayClass62_.KnYSo2hqDjN.FieldKey] = formFieldWrapper;
			}
			else
			{
				FrameworkElement frameworkElement = null;
				frameworkElement = (string.IsNullOrEmpty(_003C_003Ec__DisplayClass62_.KnYSo2hqDjN.Label) ? new Divider
				{
					Margin = new Thickness(0.0, 15.0, 0.0, 15.0)
				} : ((!(_003C_003Ec__DisplayClass62_.KnYSo2hqDjN.Label == "[]")) ? ((FrameworkElement)new Divider
				{
					Content = _003C_003Ec__DisplayClass62_.KnYSo2hqDjN.Label,
					Margin = new Thickness(0.0, 15.0, 0.0, 10.0),
					Padding = new Thickness(0.0, 0.0, 0.0, 0.0),
					HorizontalContentAlignment = HorizontalAlignment.Left,
					Foreground = Brushes.DarkGray,
					FontWeight = FontWeights.Bold
				}) : ((FrameworkElement)new Border
				{
					Height = 25.0
				})));
				frameworkElement.Tag = _003C_003Ec__DisplayClass62_.KnYSo2hqDjN;
				lceLc7eThSo.Add(frameworkElement);
				panel_0.Children.Add(frameworkElement);
			}
		}
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void X1ELqTsg3qi(object sender, KeyEventArgs e)
	{
		if (e.Key != Key.Tab || !SJ8LcNAw80D())
		{
			return;
		}
		if (Keyboard.Modifiers == (ModifierKeys.Control | ModifierKeys.Shift))
		{
			int num = 0;
			if (PWxgKkF1hwkkbYqPTgX0 != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (TheTabs.SelectedIndex > 0)
			{
				TheTabs.SelectedIndex--;
			}
			else
			{
				TheTabs.SelectedIndex = TheTabs.Items.Count - 1;
			}
			e.Handled = true;
		}
		if (Keyboard.Modifiers == ModifierKeys.Control)
		{
			if (TheTabs.SelectedIndex < TheTabs.Items.Count - 1)
			{
				TheTabs.SelectedIndex++;
			}
			else
			{
				TheTabs.SelectedIndex = 0;
			}
			e.Handled = true;
		}
	}

	private void ahqLqMyrRU8(object sender, EventArgs e)
	{
		IHNRIiikxBwJdYmHpM3.kf1vv4KqpuC(this, Location, WindowSizeStr, false);
		l7oLcRCThPl = true;
	}

	private void D8nLqAYedEy(object sender, RoutedEventArgs e)
	{
		if (!string.IsNullOrWhiteSpace(PreSelectedGroup) && SJ8LcNAw80D())
		{
			foreach (System.Windows.Controls.TabItem item in (IEnumerable)TheTabs.Items)
			{
				if (object.Equals(PreSelectedGroup, item.Header))
				{
					TheTabs.SelectedItem = item;
					break;
				}
			}
		}
		base.Dispatcher.InvokeAsync(MmWLcSReE0x);
	}

	private void oV0LqOeLKuT(object sender, SelectionChangedEventArgs e)
	{
		SelectedGroup = ((sender as System.Windows.Controls.TabControl)?.SelectedItem as System.Windows.Controls.TabItem)?.Header?.ToString();
	}

	private void UVOLqF3XuIp(object sender, MouseWheelEventArgs e)
	{
		if (!(sender is System.Windows.Controls.TabControl tabControl))
		{
			return;
		}
		System.Windows.Controls.Primitives.TabPanel tabPanel = tabControl.FindChild<System.Windows.Controls.Primitives.TabPanel>("headerPanel");
		if (PWxgKkF1hwkkbYqPTgX0 != null)
		{
			switch (0)
			{
			}
		}
		if (tabPanel == null || !tabPanel.IsMouseOver)
		{
			return;
		}
		if (e.Delta < 0)
		{
			if (tabControl.SelectedIndex + 1 < tabControl.Items.Count)
			{
				tabControl.SelectedItem = tabControl.Items[tabControl.SelectedIndex + 1];
			}
		}
		else if (tabControl.SelectedIndex - 1 > -1)
		{
			tabControl.SelectedItem = tabControl.Items[tabControl.SelectedIndex - 1];
		}
	}

	private void OKnLqUN9v2a(object sender, KeyEventArgs e)
	{
		if (e.Key == Key.Escape && AppHelper.fLiLTj0x4QY() - AppState.LastEscSendTick > 300L)
		{
			IsSuccess = false;
			Close();
		}
	}

	private void YvdLqlLLtcE(object sender, SizeChangedEventArgs e)
	{
		if (base.IsLoaded && l7oLcRCThPl)
		{
			System.Windows.Input.Mouse.GetPosition(this);
			if (base.SizeToContent != SizeToContent.Height || !(Math.Abs(base.ActualHeight - base.DesiredSize.Height) < 1.0))
			{
				base.SizeToContent = SizeToContent.Manual;
				ClearValue(FrameworkElement.MaxHeightProperty);
				base.MaxHeight = double.PositiveInfinity;
			}
		}
	}

	private void Ej9LqiGJXsS()
	{
		Qv3LcyDS7LP = new ActionExecuteContext(WwZLcCn82Sw, WwZLcCn82Sw.Action, null, null, false, WwZLcCn82Sw.Id);
		foreach (KeyValuePair<string, object> variable in WwZLcCn82Sw.GetVariables())
		{
			Qv3LcyDS7LP.SetVarValueWithoutConvert(variable.Key, variable.Value);
		}
	}

	private void gg7Lq3uncA3(object object_0, FormField formField_0)
	{
		if (!l7oLcRCThPl || axyLckG4inB || !BGgLc8eu2Lk.ContainsKey(formField_0.FieldKey))
		{
			return;
		}
		object inputValue = BGgLc8eu2Lk[formField_0.FieldKey].GetInputValue();
		string a = VariableHelper.LcfghRCibTg(Qv3LcyDS7LP.GetVarValue(formField_0.FieldKey));
		string b = VariableHelper.LcfghRCibTg(inputValue);
		if (string.Equals(a, b))
		{
			return;
		}
		try
		{
			axyLckG4inB = true;
			aD0LqfnEZGA(formField_0.FieldKey);
		}
		finally
		{
			axyLckG4inB = false;
		}
	}

	private void aD0LqfnEZGA(string string_5)
	{
		int num = 1;
		FormField current4 = default(FormField);
		FormFieldWrapper formFieldWrapper2 = default(FormFieldWrapper);
		int num4 = default(int);
		while (true)
		{
			IEnumerator<string> enumerator = BGgLc8eu2Lk.Keys.GetEnumerator();
			int num2 = 0;
			if (PWxgKkF1hwkkbYqPTgX0 != null)
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			try
			{
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					FormFieldWrapper formFieldWrapper = BGgLc8eu2Lk[current];
					if (formFieldWrapper.Visibility == Visibility.Visible)
					{
						try
						{
							object inputValue = formFieldWrapper.GetInputValue();
							Qv3LcyDS7LP.SetVarValueWithoutConvert(current, inputValue);
						}
						catch (Exception ex)
						{
							AVjLc0INcNO.Warn("表单读取值错误：" + ex.Message, ex);
						}
					}
					else
					{
						try
						{
							object inputValue2 = formFieldWrapper.GetInputValue();
							Qv3LcyDS7LP.SetVarValueWithoutConvert(current, inputValue2);
						}
						catch (Exception ex2)
						{
							AVjLc0INcNO.Warn("表单读取值错误：" + ex2.Message, ex2);
						}
					}
				}
			}
			finally
			{
				enumerator?.Dispose();
			}
			foreach (FormFieldWrapper value2 in BGgLc8eu2Lk.Values)
			{
				if (!string.IsNullOrWhiteSpace(value2.Field.VisibleExpression) && value2.Field.VisibleExpression.StartsWith("$="))
				{
					try
					{
						value2.Visibility = ((!IvfLqzVFJ4X(value2.Field.VisibleExpression, Qv3LcyDS7LP)) ? Visibility.Collapsed : Visibility.Visible);
					}
					catch (Exception exception)
					{
						AppHelper.ShowWarning("更新字段可见性出错：" + value2.Field.FieldKey + " \n表达式：" + value2.Field.VisibleExpression + "\n错误：" + exception.GetMessageWithInner());
					}
				}
				if (value2.Field.ExtraSettings.HasLineStartWith("refresh_help"))
				{
					value2.UpdateHelpText(Qv3LcyDS7LP);
				}
			}
			foreach (FrameworkElement item in lceLc7eThSo)
			{
				FormField formField = item.Tag as FormField;
				if (!string.IsNullOrWhiteSpace(formField?.VisibleExpression) && formField.VisibleExpression.StartsWith("$="))
				{
					try
					{
						item.Visibility = ((!IvfLqzVFJ4X(formField.VisibleExpression, Qv3LcyDS7LP)) ? Visibility.Collapsed : Visibility.Visible);
					}
					catch (Exception exception2)
					{
						AppHelper.ShowWarning("更新分割线可见性出错：" + formField.Label + " \n表达式：" + formField.VisibleExpression + "\n错误：" + exception2.GetMessageWithInner());
					}
				}
			}
			if (!BGgLc8eu2Lk.Values.Any(_003C_003Ec.ejsSotXwDaI ?? (_003C_003Ec.ejsSotXwDaI = _003C_003Ec.NjeSdzfvQ8S.p8ZSdfuHJTt)))
			{
				return;
			}
			using IEnumerator<FormField> enumerator4 = b5OLcaSyhvq.Fields.GetEnumerator();
			while (true)
			{
				int num3;
				if (enumerator4.MoveNext())
				{
					current4 = enumerator4.Current;
					if (current4.InputMethod == Quicker.Public.Forms.InputMethod.Separator || !BGgLc8eu2Lk.ContainsKey(current4.FieldKey) || current4.FieldKey == string_5)
					{
						continue;
					}
					formFieldWrapper2 = BGgLc8eu2Lk[current4.FieldKey];
					if (formFieldWrapper2 == null)
					{
						continue;
					}
					if (!current4.ExtraSettings.HasLineStartWith("compute:"))
					{
						goto IL_04e5;
					}
					if (!current4.ExtraSettings.HasLineStartWith("depd:") || string.IsNullOrEmpty(string_5))
					{
						goto IL_0409;
					}
					num3 = 1;
					if (PWxgKkF1hwkkbYqPTgX0 != null)
					{
						goto IL_03b4;
					}
				}
				else
				{
					num3 = 0;
					if (PWxgKkF1hwkkbYqPTgX0 != null)
					{
						goto IL_03b4;
					}
				}
				goto IL_03b6;
				IL_03b4:
				num3 = num4;
				goto IL_03b6;
				IL_04e5:
				if (formFieldWrapper2.IsShouldUpdate())
				{
					formFieldWrapper2.Update(Qv3LcyDS7LP);
				}
				continue;
				IL_0409:
				string text = current4.ExtraSettings.GetLineStartWith("compute:").Substring("compute:".Length).Trim();
				if (text.StartsWith("$="))
				{
					text = text.Substring(2);
				}
				try
				{
					object value = XActionHelper.cHBtDkjh5TG(text, Qv3LcyDS7LP);
					Qv3LcyDS7LP.SetVarValue(current4.FieldKey, value);
					formFieldWrapper2.UpdateValue(value);
					formFieldWrapper2.SetError(null, null);
				}
				catch (Exception exception3)
				{
					AVjLc0INcNO.Warn("计算字段 " + current4.Label + " 的值出错：" + exception3.GetMessageWithInner());
					formFieldWrapper2.SetError("计算错误", exception3.GetMessageWithInner());
				}
				goto IL_04e5;
				IL_03b6:
				switch (num3)
				{
				default:
					return;
				case 1:
					break;
				case 0:
					return;
				}
				if (!current4.ExtraSettings.GetLineStartWith("depd:").Substring("depd:".Length).SplitToList(',', '，', ';', '；')
					.Contains(string_5))
				{
					continue;
				}
				goto IL_0409;
			}
		}
	}

	private bool IvfLqzVFJ4X(string string_5, ActionExecuteContext actionExecuteContext_2)
	{
		return VariableHelper.ConvertToBoolean(XActionHelper.cHBtDkjh5TG(string_5.Substring(2), actionExecuteContext_2)) ?? true;
	}

	private bool j1LLcwq3lcn(string string_5, IDictionary<string, object> idictionary_2)
	{
		IDictionary<string, object> dictionary = new Dictionary<string, object>();
		foreach (KeyValuePair<string, object> item in idictionary_2)
		{
			string text = "v_" + item.Key;
			if (string_5.Contains("{" + item.Key + "}"))
			{
				string_5 = string_5.Replace("{" + item.Key + "}", text);
				object value = item.Value;
				if (item.Value is long num && num > -2147483648L && num < 2147483647L)
				{
					value = (int)num;
				}
				dictionary.Add(text, value);
			}
		}
		return Eval.Execute<bool>(string_5.Substring(2), dictionary);
	}

	private void VqILctHFhGT()
	{
		Values = new Dictionary<string, object>();
		bool flag = true;
		int num2 = default(int);
		foreach (string key in BGgLc8eu2Lk.Keys)
		{
			FormFieldWrapper formFieldWrapper = BGgLc8eu2Lk[key];
			int num = 0;
			if (PWxgKkF1hwkkbYqPTgX0 != null)
			{
				num = num2;
			}
			switch (num)
			{
			}
			if (formFieldWrapper.Visibility != Visibility.Visible)
			{
				continue;
			}
			if (formFieldWrapper.Validate().isValid)
			{
				try
				{
					object value = (formFieldWrapper.IsReadonly() ? Qv3LcyDS7LP.GetVarValue(key) : formFieldWrapper.GetInputValue());
					Values[key] = value;
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("字段 " + formFieldWrapper.Field.Label + " 的值不合法：" + ex.Message, true);
					flag = false;
					break;
				}
				continue;
			}
			flag = false;
			if (TheTabs.Visibility != Visibility.Visible)
			{
				break;
			}
			System.Windows.Controls.TabControl theTabs = TheTabs;
			foreach (System.Windows.Controls.TabItem item in (IEnumerable)theTabs.Items)
			{
				if (object.Equals(item.Header, formFieldWrapper.Field.Group))
				{
					theTabs.SelectedItem = item;
					break;
				}
			}
			break;
		}
		if (flag)
		{
			IsSuccess = true;
			Close();
		}
	}

	private void uvnLcg9Ep88(object sender, RoutedEventArgs e)
	{
		IsSuccess = false;
		Close();
	}

	private void bMPLcLSuCZh(object sender, RoutedEventArgs e)
	{
		int num = 1;
		while (true)
		{
			Button button = sender as Button;
			int num2 = 0;
			if (PWxgKkF1hwkkbYqPTgX0 != null)
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			if (!string.IsNullOrEmpty(button?.Tag as string))
			{
				ClickedConfirmButtonValue = button.Tag as string;
			}
			if (InputManager.Current.MostRecentInputDevice is KeyboardDevice)
			{
				BtnOk.Focus();
				AppHelper.RunOnUiThread(false, VqILctHFhGT);
			}
			else
			{
				VqILctHFhGT();
			}
			return;
		}
	}

	private void fdYLcvu1KHC(object sender, RoutedEventArgs e)
	{
		if (b5OLcaSyhvq == null)
		{
			return;
		}
		using (IEnumerator<FormField> enumerator = b5OLcaSyhvq.Fields.GetEnumerator())
		{
			int num2 = default(int);
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass80_0 _003C_003Ec__DisplayClass80_ = new _003C_003Ec__DisplayClass80_0();
				_003C_003Ec__DisplayClass80_.NHeSoNkbDTl = enumerator.Current;
				if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass80_.NHeSoNkbDTl.FieldKey) || _003C_003Ec__DisplayClass80_.NHeSoNkbDTl.InputMethod == Quicker.Public.Forms.InputMethod.Separator)
				{
					continue;
				}
				ActionVariable actionVariable = null;
				int num = 0;
				if (PWxgKkF1hwkkbYqPTgX0 != null)
				{
					num = num2;
				}
				switch (num)
				{
				}
				if (!L3PLcEBAhOy)
				{
					actionVariable = DrjLcPyXfqe.Variables.FirstOrDefault(_003C_003Ec__DisplayClass80_.xZ2SouSOUVE);
					if (actionVariable == null)
					{
						AVjLc0INcNO.Warn("变量 " + _003C_003Ec__DisplayClass80_.NHeSoNkbDTl.FieldKey + " 不存在。");
						AppHelper.ShowWarning("变量 " + _003C_003Ec__DisplayClass80_.NHeSoNkbDTl.FieldKey + " 不存在。");
						return;
					}
				}
				else
				{
					actionVariable = new ActionVariable
					{
						Type = _003C_003Ec__DisplayClass80_.NHeSoNkbDTl.DictVarType.GetValueOrDefault(),
						Key = _003C_003Ec__DisplayClass80_.NHeSoNkbDTl.FieldKey,
						Desc = _003C_003Ec__DisplayClass80_.NHeSoNkbDTl.Label
					};
				}
				BGgLc8eu2Lk[_003C_003Ec__DisplayClass80_.NHeSoNkbDTl.FieldKey].Init(_003C_003Ec__DisplayClass80_.NHeSoNkbDTl, actionVariable, WwZLcCn82Sw, DefaultInputWidth);
			}
		}
		aD0LqfnEZGA(null);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!cxkLcGJbBE6)
		{
			cxkLcGJbBE6 = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/forms/formwindow.xaml", UriKind.Relative);
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
		int num;
		switch (connectionId)
		{
		default:
			cxkLcGJbBE6 = true;
			return;
		case 1:
			TheWindow = (FormWindow)target;
			TheWindow.PreviewKeyDown += OKnLqUN9v2a;
			TheWindow.SizeChanged += YvdLqlLLtcE;
			return;
		case 2:
			TheTabs = (System.Windows.Controls.TabControl)target;
			return;
		case 3:
			BodyScroll = (System.Windows.Controls.ScrollViewer)target;
			return;
		case 4:
			PnlFields = (StackPanel)target;
			return;
		case 5:
			LblHelp = (TextBlock)target;
			num = 0;
			if (PWxgKkF1hwkkbYqPTgX0 == null)
			{
				return;
			}
			break;
		case 6:
			ButtonPanel = (Grid)target;
			return;
		case 7:
			HintButton = (MarkdownHintButton)target;
			return;
		case 8:
			BtnOk = (Button)target;
			BtnOk.Click += bMPLcLSuCZh;
			return;
		case 9:
			PnlCustomButtons = (ToolBar)target;
			return;
		case 10:
			BtnCancel = (Button)target;
			BtnCancel.Click += uvnLcg9Ep88;
			return;
		case 11:
			BtnReset = (Button)target;
			num = 1;
			if (!pcLq82F1HhyCsp9SwTts())
			{
				int num2 = default(int);
				num = num2;
			}
			break;
		}
		switch (num)
		{
		case 1:
			BtnReset.Click += fdYLcvu1KHC;
			break;
		}
	}

	static FormWindow()
	{
		AVjLc0INcNO = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	[CompilerGenerated]
	private void MmWLcSReE0x()
	{
		MoveFocus(new TraversalRequest(FocusNavigationDirection.First));
	}

	internal static bool pcLq82F1HhyCsp9SwTts()
	{
		return PWxgKkF1hwkkbYqPTgX0 == null;
	}
}
