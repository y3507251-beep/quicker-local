using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using GongSolutions.Wpf.DragDrop;
using IOn6RhAJdTUbfGy6gwn;
using KgHnJYYeIAVMZbA8Lyv;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;

namespace Quicker.View.X.Controls;

public class VariableListControl : UserControl, IComponentConnector, IStyleConnector
{
	public delegate void ProcessVarInfoChangeAction(ActionVariable oldVarInfo, ActionVariable newVarInfo);

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec KChSlSSl5ti;

		public static Func<ActionVariable, string> RZFSl25kW72;

		public static Comparison<ActionVariable> setSluInSZu;

		public static Func<ActionVariable, string> OufSlNxifJG;

		public static Func<string, bool> Lx0SlJToYb1;

		public static Func<string, string> zaPSl0N43Zo;

		public static Func<ActionVariable, bool> guZSlCsaldv;

		public static Func<ActionVariable, bool> AxwSlP7l5lG;

		public static Func<ActionVariable, bool> BQ7SlEtFqmR;

		internal static _003C_003Ec ksMdQkycoBjQxJtwY4I1;

		static _003C_003Ec()
		{
			KChSlSSl5ti = new _003C_003Ec();
		}

		internal string WYHSU3JNeuS(ActionVariable x)
		{
			return x.Key;
		}

		internal int zSuSUf0NKE0(ActionVariable a, ActionVariable b)
		{
			return string.Compare(a.Group + " " + a.Key, b.Group + " " + b.Key, StringComparison.Ordinal);
		}

		internal string zcmSUz2gCKd(ActionVariable x)
		{
			return x.Group;
		}

		internal bool oA2Slw7IWko(string x)
		{
			return !string.IsNullOrEmpty(x);
		}

		internal string RcrSltoDZn7(string x)
		{
			return x;
		}

		internal bool xU7Slgrfadl(ActionVariable x)
		{
			return x.SaveState;
		}

		internal bool fqeSlLHKsXt(ActionVariable x)
		{
			return x.IsInput;
		}

		internal bool rVfSlvVivZ8(ActionVariable x)
		{
			return x.IsOutput;
		}

		internal static bool LN171uycfYWV9WlJ9MjU()
		{
			return ksMdQkycoBjQxJtwY4I1 == null;
		}

		internal static void JXrTtVycqKwAxk7SKtQG()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass17_0
	{
		public ActionVariable oQBSl8402sX;

		private static _003C_003Ec__DisplayClass17_0 LyRMqIyciTomVqo36LhP;

		internal bool p5mSlyvf5ia(ActionVariable x)
		{
			return x == oQBSl8402sX;
		}

		internal static bool Jgo7DQycla6JQVABWq2P()
		{
			return LyRMqIyciTomVqo36LhP == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass37_0
	{
		public string t8ISl7T8xGR;

		private static _003C_003Ec__DisplayClass37_0 OcXVSfyc5WRtRqWmQM8h;

		internal bool KXpSlanIPVY(ActionVariable v)
		{
			return v.Key == t8ISl7T8xGR;
		}

		internal static bool m9G9c0ycYoq03XfSnvqS()
		{
			return OcXVSfyc5WRtRqWmQM8h == null;
		}
	}

	private ICollectionView syLLmeQvMjk;

	private SmartCollection<ActionVariable> GIgLmYDHcKB;

	private XAction xVMLmI26Ix9;

	private object WRpLmWEvrTM;

	private bool C7YLmkTBM3Q;

	[CompilerGenerated]
	private ProcessVarInfoChangeAction c1aLmGgOGYO;

	[CompilerGenerated]
	private Action<string> fEqLmshIiqs;

	internal Button BtnNewVar;

	internal Button BtnClearVarible;

	internal Button BtnSortVariable;

	internal MenuItem SortByVarName;

	internal MenuItem SortByVarType;

	internal MenuItem SortByVarGroup;

	internal ToggleButton ToggleVariableFilter;

	internal Grid GridVariableFilter;

	internal TextBox TxtVarFilter;

	internal ListBox LbVariables;

	private bool jiELmHYfYsn;

	internal static VariableListControl Jw64e3F9mt4YY0cajyqb;

	public bool IsForSubProgram
	{
		get
		{
			return C7YLmkTBM3Q;
		}
		set
		{
			C7YLmkTBM3Q = value;
		}
	}

	public ProcessVarInfoChangeAction ProcessVarInfoChange
	{
		[CompilerGenerated]
		get
		{
			return c1aLmGgOGYO;
		}
		[CompilerGenerated]
		set
		{
			c1aLmGgOGYO = value;
		}
	}

	public Action<string> OnHightlightRequested
	{
		[CompilerGenerated]
		get
		{
			return fEqLmshIiqs;
		}
		[CompilerGenerated]
		set
		{
			fEqLmshIiqs = value;
		}
	}

	public VariableListControl()
	{
		InitializeComponent();
		LbVariables.SetValue(GongSolutions.Wpf.DragDrop.DragDrop.DropHandlerProperty, new ReorderDropTarget());
	}

	public void SetDataSource(SmartCollection<ActionVariable> variables, XAction xAction)
	{
		GIgLmYDHcKB = variables;
		xVMLmI26Ix9 = xAction;
		syLLmeQvMjk = CollectionViewSource.GetDefaultView(variables);
		syLLmeQvMjk.Filter = UBSLmtNwiED;
		LbVariables.ItemsSource = syLLmeQvMjk;
	}

	private bool UBSLmtNwiED(object object_1)
	{
		if (!string.IsNullOrEmpty(TxtVarFilter.Text) && TxtVarFilter.IsVisible)
		{
			ActionVariable actionVariable = (ActionVariable)object_1;
			if (!string.Equals(TxtVarFilter.Text, actionVariable.Group))
			{
				return tkxn6HAKAgMT8gvXbyh.hSHinCpnSJ(TxtVarFilter.Text, actionVariable.Key, actionVariable.Desc);
			}
			return true;
		}
		return true;
	}

	private void NFHLmgn0kPj(object sender, TextChangedEventArgs e)
	{
		syLLmeQvMjk.Refresh();
	}

	private void DuiLmL4wauJ(object sender, RoutedEventArgs e)
	{
		XActionUiHelper.ClearVariables(xVMLmI26Ix9, GIgLmYDHcKB, Window.GetWindow(this), false);
	}

	private void oTqLmvDQmB6(object sender, MouseButtonEventArgs e)
	{
		if (e.ClickCount == 2 && sender == WRpLmWEvrTM && (sender as FrameworkElement).Tag is ActionVariable actionVariable_)
		{
			SLpLmNFpr2H(actionVariable_);
		}
		WRpLmWEvrTM = sender;
	}

	private void wumLmSNP9yk(object sender, RoutedEventArgs e)
	{
		BtnSortVariable.ContextMenu.IsOpen = true;
	}

	private void ELbLm27u01n(object sender, RoutedEventArgs e)
	{
		CreateVariable(null);
	}

	public ActionVariable CreateVariable(VarType? varType)
	{
		return XActionUiHelper.CreateVariable(Window.GetWindow(this), GIgLmYDHcKB, null, IsForSubProgram);
	}

	private void QN9Lmut7IMK(object sender, RoutedEventArgs e)
	{
		_003C_003Ec__DisplayClass17_0 _003C_003Ec__DisplayClass17_ = new _003C_003Ec__DisplayClass17_0();
		_003C_003Ec__DisplayClass17_.oQBSl8402sX = (sender as Button).Tag as ActionVariable;
		if (_003C_003Ec__DisplayClass17_.oQBSl8402sX != null)
		{
			if (!ofWPUJYbI0eTmcMC6L3.U3iLG5Yq592(xVMLmI26Ix9, _003C_003Ec__DisplayClass17_.oQBSl8402sX))
			{
				GIgLmYDHcKB.Remove(GIgLmYDHcKB.First(_003C_003Ec__DisplayClass17_.p5mSlyvf5ia));
			}
			else
			{
				AppHelper.ShowWarning("变量 " + _003C_003Ec__DisplayClass17_.oQBSl8402sX.Key + " 已经被使用，不能删除。");
			}
		}
	}

	public void AddVariable(params ActionVariable[] varList)
	{
		foreach (ActionVariable item in varList)
		{
			GIgLmYDHcKB.Add(item);
		}
		LbVariables.UpdateLayout();
	}

	private void SLpLmNFpr2H(ActionVariable actionVariable_0)
	{
		VariableEditorWindow variableEditorWindow = new VariableEditorWindow(GIgLmYDHcKB, IsForSubProgram)
		{
			Owner = Window.GetWindow(this),
			EditingVariable = actionVariable_0
		};
		if (variableEditorWindow.ShowDialog() == true)
		{
			ActionVariable result = variableEditorWindow.Result;
			ProcessVarInfoChange(actionVariable_0, result);
			LbVariables.UpdateLayout();
			try
			{
				LbVariables.SelectedItem = result;
			}
			catch (Exception)
			{
			}
		}
	}

	private void xQfLmJiqdpu(object sender, RoutedEventArgs e)
	{
		ActionVariable actionVariable_ = (sender as Button).Tag as ActionVariable;
		SLpLmNFpr2H(actionVariable_);
	}

	private void LVbLm0EpB0X(object sender, RoutedEventArgs e)
	{
		ActionVariable actionVariable = (sender as FrameworkElement).Tag as ActionVariable;
		OnHightlightRequested("var:" + actionVariable.Key);
	}

	private void cqwLmCM8Qib(object sender, RoutedEventArgs e)
	{
		ActionVariable actionVariable = (sender as FrameworkElement).Tag as ActionVariable;
		OnHightlightRequested("to:" + actionVariable.Key);
	}

	private void KYfLmPoNjA6(object sender, RoutedEventArgs e)
	{
		if (ToggleVariableFilter.IsChecked == true)
		{
			TxtVarFilter.Focus();
		}
		else
		{
			TxtVarFilter.Text = "";
		}
	}

	private void TKDLmE6pRvX(object sender, RoutedEventArgs e)
	{
		if (LbVariables.SelectedItems.Count <= 1)
		{
			ClipboardHelper.SetText("{" + ((sender as FrameworkElement).Tag as ActionVariable)?.Key + "}");
			return;
		}
		List<string> values = LbVariables.SelectedItems.Cast<ActionVariable>().Select(_003C_003Ec.RZFSl25kW72 ?? (_003C_003Ec.RZFSl25kW72 = _003C_003Ec.KChSlSSl5ti.WYHSU3JNeuS)).ToList();
		ClipboardHelper.SetText(string.Join("\r\n", values));
	}

	private void RiSLmy2ZJhl(object sender, RoutedEventArgs e)
	{
		XActionUiHelper.SortVariableListByType(GIgLmYDHcKB);
	}

	private void obxLm8JwtS1(object sender, RoutedEventArgs e)
	{
		XActionUiHelper.SortVariableListByName(GIgLmYDHcKB);
	}

	private void jrhLmavrdeG(object sender, RoutedEventArgs e)
	{
		GIgLmYDHcKB.Sort(_003C_003Ec.setSluInSZu ?? (_003C_003Ec.setSluInSZu = _003C_003Ec.KChSlSSl5ti.zSuSUf0NKE0));
	}

	private void b2mLm7asEnI(object sender, DragEventArgs e)
	{
		ActionVariable actionVariable;
		int num;
		if (e.Data.GetDataPresent("GongSolutions.Wpf.DragDrop"))
		{
			actionVariable = e.Data.GetData("GongSolutions.Wpf.DragDrop") as ActionVariable;
			num = 0;
			if (UpfoswF9shU2lLjcft0s())
			{
				goto IL_003c;
			}
			goto IL_00ce;
		}
		AppHelper.ShowWarning("只支持拖放变量。");
		return;
		IL_00ce:
		ActionVariable actionVariable2 = default(ActionVariable);
		switch (num)
		{
		case 1:
		{
			VariableEditorWindow variableEditorWindow = new VariableEditorWindow(GIgLmYDHcKB, IsForSubProgram)
			{
				Owner = Window.GetWindow(this),
				EditingVariable = actionVariable2
			};
			if (variableEditorWindow.ShowDialog() == true)
			{
				GIgLmYDHcKB.Insert(GIgLmYDHcKB.IndexOf(actionVariable) + 1, variableEditorWindow.Result);
			}
			return;
		}
		}
		goto IL_003c;
		IL_003c:
		if (actionVariable != null)
		{
			_003C_003Ec__DisplayClass37_0 _003C_003Ec__DisplayClass37_ = new _003C_003Ec__DisplayClass37_0();
			actionVariable2 = AppHelper.Clone(actionVariable);
			_003C_003Ec__DisplayClass37_.t8ISl7T8xGR = actionVariable.Key + "_2";
			int num2 = 3;
			while (GIgLmYDHcKB.Any(_003C_003Ec__DisplayClass37_.KXpSlanIPVY))
			{
				_003C_003Ec__DisplayClass37_.t8ISl7T8xGR = actionVariable.Key + "_" + num2;
				num2++;
			}
			actionVariable2.Key = _003C_003Ec__DisplayClass37_.t8ISl7T8xGR;
			num = 1;
			if (Jw64e3F9mt4YY0cajyqb != null)
			{
				int num3 = default(int);
				num = num3;
			}
			goto IL_00ce;
		}
		AppHelper.ShowWarning("只支持拖放变量。");
	}

	private void o2pLmRZtt1C(object sender, ContextMenuEventArgs e)
	{
		ContextMenu contextMenu = (sender as Grid)?.ContextMenu;
		if (contextMenu == null)
		{
			return;
		}
		int num2 = default(int);
		foreach (MenuItem item in (IEnumerable)contextMenu.Items)
		{
			if (item.Name == "MenuTag")
			{
				item.Items.Clear();
				if (item.Items.Count != 0)
				{
					continue;
				}
				List<string> list = GIgLmYDHcKB.Select(_003C_003Ec.OufSlNxifJG ?? (_003C_003Ec.OufSlNxifJG = _003C_003Ec.KChSlSSl5ti.zcmSUz2gCKd)).Where(_003C_003Ec.Lx0SlJToYb1 ?? (_003C_003Ec.Lx0SlJToYb1 = _003C_003Ec.KChSlSSl5ti.oA2Slw7IWko)).Distinct()
					.OrderBy(_003C_003Ec.zaPSl0N43Zo ?? (_003C_003Ec.zaPSl0N43Zo = _003C_003Ec.KChSlSSl5ti.RcrSltoDZn7))
					.ToList();
				foreach (string item2 in list)
				{
					AppHelper.AddMenuItem(item.Items, item2, "", "", BefLmcQTK2m).Tag = item2;
				}
				if (list.Count > 0)
				{
					AppHelper.AddMenuSeparator(item.Items);
					AppHelper.AddMenuItem(item.Items, "删除", "去除变量标签", "fa:Light_Times:danger", BefLmcQTK2m).Tag = null;
				}
				AppHelper.AddMenuItem(item.Items, "新标签...", "创建新标签", "", balLmqQROHb);
				int num = 0;
				if (!UpfoswF9shU2lLjcft0s())
				{
					num = num2;
				}
				switch (num)
				{
				}
			}
			else if (item.Name == "MenuForSp" && !IsForSubProgram)
			{
				item.Visibility = Visibility.Collapsed;
			}
		}
	}

	private void balLmqQROHb(object sender, RoutedEventArgs e)
	{
		UserInputWindow userInputWindow = new UserInputWindow("text", "请输入分组名称", "", "");
		if (userInputWindow.ShowDialog() != true)
		{
			return;
		}
		string textValue = userInputWindow.TextValue;
		foreach (ActionVariable item in LbVariables.SelectedItems.Cast<ActionVariable>())
		{
			item.Group = textValue;
		}
	}

	private void BefLmcQTK2m(object sender, RoutedEventArgs e)
	{
		if (!(sender is MenuItem menuItem))
		{
			return;
		}
		string text = menuItem.Tag as string;
		foreach (ActionVariable item in LbVariables.SelectedItems.Cast<ActionVariable>())
		{
			item.Group = text;
		}
	}

	private void LlgLmVxfPpb(object sender, RoutedEventArgs e)
	{
		if (IsForSubProgram)
		{
			AppHelper.ShowWarning("子程序不支持此功能。");
			return;
		}
		List<ActionVariable> list = LbVariables.SelectedItems.Cast<ActionVariable>().ToList();
		if (!list.Any(_003C_003Ec.guZSlCsaldv ?? (_003C_003Ec.guZSlCsaldv = _003C_003Ec.KChSlSSl5ti.xU7Slgrfadl)))
		{
			foreach (ActionVariable item in list)
			{
				item.SaveState = true;
			}
			return;
		}
		foreach (ActionVariable item2 in list)
		{
			item2.SaveState = false;
		}
	}

	private void JE5LmZo7PtK(object sender, KeyEventArgs e)
	{
		if ((e.Key == Key.H || (e.Key == Key.ImeProcessed && e.ImeProcessedKey == Key.H)) && LbVariables.SelectedItem is ActionVariable actionVariable)
		{
			OnHightlightRequested("var:" + actionVariable.Key);
			e.Handled = true;
		}
	}

	private void kl0Lm9nKQwm(object sender, RoutedEventArgs e)
	{
		if (!IsForSubProgram)
		{
			AppHelper.ShowWarning("仅子程序支持此功能。");
			return;
		}
		List<ActionVariable> list = LbVariables.SelectedItems.Cast<ActionVariable>().ToList();
		if (!list.Any(_003C_003Ec.AxwSlP7l5lG ?? (_003C_003Ec.AxwSlP7l5lG = _003C_003Ec.KChSlSSl5ti.fqeSlLHKsXt)))
		{
			foreach (ActionVariable item in list)
			{
				item.IsInput = true;
			}
			return;
		}
		foreach (ActionVariable item2 in list)
		{
			item2.IsInput = false;
		}
	}

	private void noJLmhjo1X7(object sender, RoutedEventArgs e)
	{
		if (!IsForSubProgram)
		{
			AppHelper.ShowWarning("仅子程序支持此功能。");
			return;
		}
		List<ActionVariable> list = LbVariables.SelectedItems.Cast<ActionVariable>().ToList();
		if (!list.Any(_003C_003Ec.BQ7SlEtFqmR ?? (_003C_003Ec.BQ7SlEtFqmR = _003C_003Ec.KChSlSSl5ti.rVfSlvVivZ8)))
		{
			foreach (ActionVariable item in list)
			{
				item.IsOutput = true;
			}
			return;
		}
		foreach (ActionVariable item2 in list)
		{
			item2.IsOutput = false;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!jiELmHYfYsn)
		{
			jiELmHYfYsn = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/x/controls/variablelistcontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
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
			jiELmHYfYsn = true;
			return;
		case 1:
			BtnNewVar = (Button)target;
			BtnNewVar.Click += ELbLm27u01n;
			BtnNewVar.Drop += b2mLm7asEnI;
			num = 0;
			if (Jw64e3F9mt4YY0cajyqb == null)
			{
				return;
			}
			goto IL_01ab;
		case 2:
			BtnClearVarible = (Button)target;
			BtnClearVarible.Click += DuiLmL4wauJ;
			return;
		case 3:
			BtnSortVariable = (Button)target;
			BtnSortVariable.Click += wumLmSNP9yk;
			return;
		case 4:
			SortByVarName = (MenuItem)target;
			SortByVarName.Click += obxLm8JwtS1;
			return;
		case 5:
			SortByVarType = (MenuItem)target;
			SortByVarType.Click += RiSLmy2ZJhl;
			return;
		case 6:
			SortByVarGroup = (MenuItem)target;
			SortByVarGroup.Click += jrhLmavrdeG;
			return;
		case 7:
			ToggleVariableFilter = (ToggleButton)target;
			ToggleVariableFilter.Click += KYfLmPoNjA6;
			return;
		case 8:
			GridVariableFilter = (Grid)target;
			return;
		case 9:
			TxtVarFilter = (TextBox)target;
			TxtVarFilter.TextChanged += NFHLmgn0kPj;
			return;
		case 10:
			{
				LbVariables = (ListBox)target;
				num = 0;
				if (Jw64e3F9mt4YY0cajyqb == null)
				{
					break;
				}
				goto IL_01ab;
			}
			IL_01ab:
			switch (num)
			{
			case 1:
				return;
			}
			break;
		}
		LbVariables.PreviewKeyDown += JE5LmZo7PtK;
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 11:
			((Grid)target).ContextMenuOpening += o2pLmRZtt1C;
			((Grid)target).PreviewMouseDown += oTqLmvDQmB6;
			break;
		case 12:
			((MenuItem)target).Click += LVbLm0EpB0X;
			break;
		case 13:
			((MenuItem)target).Click += cqwLmCM8Qib;
			break;
		case 14:
			((MenuItem)target).Click += TKDLmE6pRvX;
			break;
		case 15:
		{
			((MenuItem)target).Click += LlgLmVxfPpb;
			int num = 0;
			if (!UpfoswF9shU2lLjcft0s())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			break;
		}
		case 16:
			((MenuItem)target).Click += kl0Lm9nKQwm;
			break;
		case 17:
			((MenuItem)target).Click += noJLmhjo1X7;
			break;
		case 18:
			((Button)target).Click += xQfLmJiqdpu;
			break;
		case 19:
			((Button)target).Click += QN9Lmut7IMK;
			break;
		}
	}

	internal static bool UpfoswF9shU2lLjcft0s()
	{
		return Jw64e3F9mt4YY0cajyqb == null;
	}
}
