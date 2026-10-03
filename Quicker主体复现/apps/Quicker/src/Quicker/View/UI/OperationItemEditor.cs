using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using FontAwesome5.WPF;
using GuvA3OiyFyyWpKJlb8c;
using JTIh7V5l65QV75A93Ly;
using Quicker.Common.Entities;
using Quicker.Domain;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Entities;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;
using Quicker.Utilities.UI.Wpf;
using Quicker.View.Controls;
using Quicker.View.X;

namespace Quicker.View.UI;

public class OperationItemEditor : Window, IComponentConnector, IMockModalWindow
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec uEtS4E8Jnh7;

		public static Func<KeyValuePair<string, object>, string> saIS4yH8seQ;

		public static Func<KeyValuePair<string, object>, string> EW2S48ObTHE;

		public static Func<SubProgram, string> Bi2S4aFppO5;

		public static Func<KeyValuePair<string, string>, string> kACS47bddyE;

		public static Func<KeyValuePair<string, string>, object> ioKS4RGG9yu;

		public static Func<ActionVariable, bool> u33S4qwyIS9;

		public static Func<ActionVariable, string> dbtS4cm3F6l;

		private static _003C_003Ec oKAaVTWSV32T10jfwjdh;

		static _003C_003Ec()
		{
			uEtS4E8Jnh7 = new _003C_003Ec();
		}

		internal string aIWS42vatAv(KeyValuePair<string, object> x)
		{
			return x.Key;
		}

		internal string WxcS4uqLSg5(KeyValuePair<string, object> x)
		{
			return x.Value.ToString();
		}

		internal string XugS4NVG2cA(SubProgram x)
		{
			return x.Name;
		}

		internal string ydvS4Jdf330(KeyValuePair<string, string> x)
		{
			return x.Key;
		}

		internal object PBJS40WCfy5(KeyValuePair<string, string> x)
		{
			return x.Value;
		}

		internal bool n9CS4CAB3a4(ActionVariable x)
		{
			if (x.IsInput)
			{
				return !x.Key.IsEither("data", "_group", "_handle");
			}
			return false;
		}

		internal string J8LS4PW8iv5(ActionVariable x)
		{
			return x.Key;
		}

		internal static bool dmwxuWWSQHpkXYQ0sBks()
		{
			return oKAaVTWSV32T10jfwjdh == null;
		}

		internal static void RLAccfWSc5Ch20bNeDR7()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass24_0
	{
		public string hNiS4ZM4lTs;

		internal static _003C_003Ec__DisplayClass24_0 gIwv2kWSW0xCc4tikoDp;

		internal bool VU5S4Voc7yQ(SubProgram x)
		{
			return x.Name == hNiS4ZM4lTs;
		}

		static _003C_003Ec__DisplayClass24_0()
		{
		}

		internal static bool n4hfy3WSy89jBeMsbgkH()
		{
			return gIwv2kWSW0xCc4tikoDp == null;
		}

		internal static void g5mlegWS25LLw5oJkmDZ()
		{
		}
	}

	public static readonly DependencyProperty OnlyDataProperty;

	[CompilerGenerated]
	private CommonOperationItem ACnL0SOo8W5;

	[CompilerGenerated]
	private bool? q6SL0288aHp;

	internal OperationItemEditor TheWindow;

	internal TextBox TxtTitle;

	internal TextBox TxtIcon;

	internal IconControl PreviewIcon;

	internal Button BtnImgIcon;

	internal Button BtnFaIcon;

	internal Button BtnSelectColor;

	internal SvgAwesome IconEditColor;

	internal TextBox TxtTooltip;

	internal TextBox TxtValue;

	internal ComboBox CmbOperation;

	internal TextBox TxtAction;

	internal ComboBox CbSpList;

	internal TextBox TxtData;

	internal DictEditorControl ExtraDataEditor;

	internal CheckBox ChkContinue;

	internal Button BtnOk;

	internal Button BtnCancel;

	private bool RlIL0uhwt0c;

	internal static OperationItemEditor peeNHFF3nlNJlDiTZXk2;

	public bool OnlyData
	{
		get
		{
			return (bool)GetValue(OnlyDataProperty);
		}
		set
		{
			SetValue(OnlyDataProperty, value);
		}
	}

	public CommonOperationItem ResultItem
	{
		[CompilerGenerated]
		get
		{
			return ACnL0SOo8W5;
		}
		[CompilerGenerated]
		set
		{
			ACnL0SOo8W5 = value;
		}
	}

	public bool ContinueAdd
	{
		get
		{
			return ChkContinue.IsChecked == true;
		}
		set
		{
			ChkContinue.IsChecked = value;
		}
	}

	public bool? Result
	{
		[CompilerGenerated]
		get
		{
			return q6SL0288aHp;
		}
		[CompilerGenerated]
		set
		{
			q6SL0288aHp = value;
		}
	}

	public OperationItemEditor(IOperationItem item, bool onlyData)
	{
		OnlyData = onlyData;
		InitializeComponent();
		CmbOperation.ItemsSource = new ObservableCollection<SelectionItem>
		{
			new SelectionItem("copy", "复制文本"),
			new SelectionItem("paste", "粘贴文本"),
			new SelectionItem("sendkeys", "发送快捷键（模拟按键B）"),
			new SelectionItem("inputtext", "键入文本"),
			new SelectionItem("action", "运行动作"),
			new SelectionItem("run", "运行或打开(命令、路径或网址等）"),
			new SelectionItem("open", "打开文件或网址"),
			new SelectionItem("selectfile", "在资源管理器中定位文件"),
			new SelectionItem("inputscript", "多步骤输入"),
			new SelectionItem("sp", "执行子程序"),
			new SelectionItem("pastefile", "粘贴文件"),
			new SelectionItem("pasteimage", "粘贴图片"),
			new SelectionItem("none", "*空*")
		};
		if (item != null)
		{
			TxtIcon.Text = item.Icon;
			TxtTitle.Text = item.Title;
			TxtTooltip.Text = item.Description;
			if (OnlyData)
			{
				TxtValue.Text = item.Data;
			}
			else
			{
				CmbOperation.Text = item.Operation;
				TxtAction.Text = item.Action;
				TxtData.Text = item.Data;
				CbSpList.Text = item.SpName;
			}
			if (item.ExtraData.HasData())
			{
				ExtraDataEditor.Data = item.ExtraData.ToDictionary(_003C_003Ec.saIS4yH8seQ ?? (_003C_003Ec.saIS4yH8seQ = _003C_003Ec.uEtS4E8Jnh7.aIWS42vatAv), _003C_003Ec.EW2S48ObTHE ?? (_003C_003Ec.EW2S48ObTHE = _003C_003Ec.uEtS4E8Jnh7.WxcS4uqLSg5));
			}
		}
		ChkContinue.Visibility = (item == null).ToVisibility();
		base.Loaded += OuSLJ343XoK;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void OuSLJ343XoK(object sender, RoutedEventArgs e)
	{
		this.aJDvuAkk8hZ();
		if (base.Owner?.Owner?.Owner is ActionDesignerWindow { SubPrograms: var subPrograms } && subPrograms.HasData())
		{
			CbSpList.ItemsSource = subPrograms.Select(_003C_003Ec.Bi2S4aFppO5 ?? (_003C_003Ec.Bi2S4aFppO5 = _003C_003Ec.uEtS4E8Jnh7.XugS4NVG2cA));
		}
	}

	private void MLeLJf6wCJY(object sender, RoutedEventArgs e)
	{
		if (!TxtTitle.EnsureNotEmpty("标题"))
		{
			return;
		}
		ResultItem = new CommonOperationItem
		{
			Icon = TxtIcon.Text,
			Title = TxtTitle.Text,
			Description = TxtTooltip.Text
		};
		if (OnlyData)
		{
			ResultItem.Data = TxtValue.Text;
			goto IL_01bb;
		}
		ResultItem.Operation = CmbOperation.Text;
		ResultItem.Action = TxtAction.Text;
		int num = 0;
		if (qNceHFF3eNyLbB7X4SgQ())
		{
			goto IL_00b0;
		}
		goto IL_00d2;
		IL_00e2:
		ResultItem.SpName = CbSpList.Text;
		if (ResultItem.Operation == "sp")
		{
			if (string.IsNullOrEmpty(ResultItem.SpName))
			{
				AppHelper.ShowWarning("未填写子程序名称。");
				return;
			}
		}
		else if (ResultItem.Operation == "action" && string.IsNullOrEmpty(ResultItem.Action))
		{
			AppHelper.ShowWarning("未填写动作名称或id。");
			return;
		}
		ResultItem.ExtraData = ExtraDataEditor.Data.ToDictionary(_003C_003Ec.kACS47bddyE ?? (_003C_003Ec.kACS47bddyE = _003C_003Ec.uEtS4E8Jnh7.ydvS4Jdf330), _003C_003Ec.ioKS4RGG9yu ?? (_003C_003Ec.ioKS4RGG9yu = _003C_003Ec.uEtS4E8Jnh7.PBJS40WCfy5));
		goto IL_01bb;
		IL_01bb:
		this.ThNvuM5Q9GQ(true);
		return;
		IL_00b0:
		ResultItem.Data = TxtData.Text;
		num = 1;
		if (qNceHFF3eNyLbB7X4SgQ())
		{
			goto IL_00d2;
		}
		goto IL_00e2;
		IL_00d2:
		switch (num)
		{
		case 1:
			goto IL_00e2;
		}
		goto IL_00b0;
	}

	private void EKvLJzSnK5I(object sender, RoutedEventArgs e)
	{
		Close();
	}

	private void znEL0wUC26U(object sender, RoutedEventArgs e)
	{
		IconSelectorWindow iconSelectorWindow = new IconSelectorWindow();
		iconSelectorWindow.Owner = Window.GetWindow(this);
		if (iconSelectorWindow.ShowDialog() == true)
		{
			TxtIcon.Text = "url:" + iconSelectorWindow.SelectedIconUrl;
		}
	}

	private void mqSL0tWhEIT(object sender, RoutedEventArgs e)
	{
		FaIconSelectorWindow faIconSelectorWindow = new FaIconSelectorWindow();
		faIconSelectorWindow.Owner = Window.GetWindow(this);
		bool flag = true;
		string text = FMP9ONqzXcgZ6r3WmZZ.A4qHeQImJ6().DefaultIconColor;
		if (!string.IsNullOrEmpty(TxtIcon.Text) && TxtIcon.Text.StartsWith("fa:", StringComparison.OrdinalIgnoreCase) && TxtIcon.Text.Contains(":#"))
		{
			text = TxtIcon.Text.Split(':')[2];
			flag = false;
		}
		faIconSelectorWindow.IconColor = text;
		UiSettings uiSettings = FMP9ONqzXcgZ6r3WmZZ.A4qHeQImJ6();
		faIconSelectorWindow.PanelColor = uiSettings.BackgroundColor;
		faIconSelectorWindow.ButtonColor = uiSettings.ButtonBgColor;
		faIconSelectorWindow.LabelColor = uiSettings.LabelColor;
		if (faIconSelectorWindow.ShowDialog() == true)
		{
			int num = 0;
			if (peeNHFF3nlNJlDiTZXk2 != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			TxtIcon.Text = "fa:" + faIconSelectorWindow.SelectedIcon.ToString() + (flag ? "" : (":" + text));
		}
	}

	private void gETL0gg6e2n(object sender, RoutedEventArgs e)
	{
		ktYL0LHdeRt();
	}

	private void ktYL0LHdeRt()
	{
		try
		{
			string text = TxtIcon.Text;
			if (!text.StartsWith("fa:"))
			{
				AppHelper.ShowWarning("仅内置矢量图标可以设置颜色。");
				return;
			}
			string value = FMP9ONqzXcgZ6r3WmZZ.A4qHeQImJ6().DefaultIconColor;
			string[] array = text.Split(':');
			if (array.Length == 3)
			{
				value = array[2];
			}
			ColorSelectorWindow colorSelectorWindow = new ColorSelectorWindow((Color?)ColorConverter.ConvertFromString(value));
			colorSelectorWindow.Owner = Window.GetWindow(this);
			colorSelectorWindow.ShowDialog();
			if (colorSelectorWindow.SelectedColor.HasValue)
			{
				TxtIcon.Text = array[0] + ":" + array[1] + ":" + colorSelectorWindow.SelectedColor?.ToString();
			}
		}
		catch (Exception exception)
		{
			AppHelper.ShowWarning("错误：" + exception.GetMessageWithInner());
		}
	}

	private void rQ1L0vC25lg(object sender, SelectionChangedEventArgs e)
	{
		_003C_003Ec__DisplayClass24_0 _003C_003Ec__DisplayClass24_ = new _003C_003Ec__DisplayClass24_0();
		_003C_003Ec__DisplayClass24_.hNiS4ZM4lTs = CbSpList.SelectedItem as string;
		if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass24_.hNiS4ZM4lTs))
		{
			return;
		}
		ActionDesignerWindow actionDesignerWindow = base.Owner?.Owner?.Owner as ActionDesignerWindow;
		if (peeNHFF3nlNJlDiTZXk2 != null)
		{
			switch (0)
			{
			}
		}
		if (actionDesignerWindow != null)
		{
			SubProgram subProgram = actionDesignerWindow.SubPrograms.FirstOrDefault(_003C_003Ec__DisplayClass24_.VU5S4Voc7yQ);
			if (subProgram != null)
			{
				List<ActionVariable> source = subProgram.Variables.Where(_003C_003Ec.u33S4qwyIS9 ?? (_003C_003Ec.u33S4qwyIS9 = _003C_003Ec.uEtS4E8Jnh7.n9CS4CAB3a4)).ToList();
				ExtraDataEditor.UpdateKeys(source.Select(_003C_003Ec.dbtS4cm3F6l ?? (_003C_003Ec.dbtS4cm3F6l = _003C_003Ec.uEtS4E8Jnh7.J8LS4PW8iv5)));
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!RlIL0uhwt0c)
		{
			RlIL0uhwt0c = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/operationitemeditor/operationitemeditor.xaml", UriKind.Relative);
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
		int num;
		switch (connectionId)
		{
		default:
			RlIL0uhwt0c = true;
			break;
		case 1:
			TheWindow = (OperationItemEditor)target;
			break;
		case 2:
			TxtTitle = (TextBox)target;
			break;
		case 3:
			TxtIcon = (TextBox)target;
			break;
		case 4:
			PreviewIcon = (IconControl)target;
			break;
		case 5:
			BtnImgIcon = (Button)target;
			BtnImgIcon.Click += znEL0wUC26U;
			break;
		case 6:
			BtnFaIcon = (Button)target;
			BtnFaIcon.Click += mqSL0tWhEIT;
			break;
		case 7:
			BtnSelectColor = (Button)target;
			BtnSelectColor.Click += gETL0gg6e2n;
			break;
		case 8:
			IconEditColor = (SvgAwesome)target;
			break;
		case 9:
			TxtTooltip = (TextBox)target;
			break;
		case 10:
			TxtValue = (TextBox)target;
			num = 1;
			if (!qNceHFF3eNyLbB7X4SgQ())
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_018b;
		case 11:
			CmbOperation = (ComboBox)target;
			num = 0;
			if (qNceHFF3eNyLbB7X4SgQ())
			{
				break;
			}
			goto IL_018b;
		case 12:
			TxtAction = (TextBox)target;
			break;
		case 13:
			CbSpList = (ComboBox)target;
			CbSpList.SelectionChanged += rQ1L0vC25lg;
			num = 0;
			if (qNceHFF3eNyLbB7X4SgQ())
			{
				break;
			}
			goto IL_018b;
		case 14:
			TxtData = (TextBox)target;
			break;
		case 15:
			ExtraDataEditor = (DictEditorControl)target;
			break;
		case 16:
			ChkContinue = (CheckBox)target;
			break;
		case 17:
			BtnOk = (Button)target;
			BtnOk.Click += MLeLJf6wCJY;
			break;
		case 18:
			{
				BtnCancel = (Button)target;
				BtnCancel.Click += EKvLJzSnK5I;
				break;
			}
			IL_018b:
			switch (num)
			{
			case 1:
				break;
			case 2:
				break;
			}
			break;
		}
	}

	static OperationItemEditor()
	{
		OnlyDataProperty = DependencyProperty.Register("OnlyData", typeof(bool), typeof(OperationItemEditor), new PropertyMetadata(false));
	}

	internal static bool qNceHFF3eNyLbB7X4SgQ()
	{
		return peeNHFF3nlNJlDiTZXk2 == null;
	}
}
