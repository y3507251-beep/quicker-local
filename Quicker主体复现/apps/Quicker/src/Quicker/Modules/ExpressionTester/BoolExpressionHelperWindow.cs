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
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Threading;
using GuvA3OiyFyyWpKJlb8c;
using pqbejBAeefDNBsawE5C;
using Quicker.Domain;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.UI;
using Quicker.Utilities.UI.Wpf;

namespace Quicker.Modules.ExpressionTester;

public class BoolExpressionHelperWindow : Window, IComponentConnector, IStyleConnector, IMockModalWindow
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec SrWvexH4BQg;

		public static Func<ActionVariable, string> Fl9verxdFMB;

		private static _003C_003Ec bqi9yscqdgAu2Ie43fAw;

		static _003C_003Ec()
		{
			SrWvexH4BQg = new _003C_003Ec();
		}

		internal string WqVveKeecSU(ActionVariable x)
		{
			return x.Group + x.Key;
		}

		internal static void AJXWiHcqkr8XrjJ9e605()
		{
		}

		internal static bool htr6DFcqO4ibwVn41Ujo()
		{
			return bqi9yscqdgAu2Ie43fAw == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass20_0
	{
		public ActionVariable jnsveBNBy5T;

		public BoolExpressionHelperWindow zimveQArRnC;

		internal static _003C_003Ec__DisplayClass20_0 dj7GG9cqrWteZMTuHmeE;

		internal bool gPgvepYmQHa(VariableOperation x)
		{
			if (x.DkfUYr612m() == jnsveBNBy5T.Type)
			{
				if (zimveQArRnC.K5bFu4xyjY.HasValue)
				{
					return x.agcUBy7d3P() == zimveQArRnC.K5bFu4xyjY;
				}
				return true;
			}
			return false;
		}

		internal static void rqerCKcqLJYUulWIoYTb()
		{
		}

		internal static bool vB9USHcqNli7KAjS5UkQ()
		{
			return dj7GG9cqrWteZMTuHmeE == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass21_0
	{
		public z1Zs1sAbPOMnx22hak7 x;

		public BoolExpressionHelperWindow uICvenYyVvX;

		private static _003C_003Ec__DisplayClass21_0 X4C99YcquK6TXI1JaEQI;

		internal bool DkGvejrb9lF(ActionVariable v)
		{
			if (v != uICvenYyVvX.CbVariable.SelectedItem)
			{
				return v.Type.IsEither(x.kiOU3S23fe());
			}
			return false;
		}

		internal static bool KSUau6cqo6sDUURwFyEi()
		{
			return X4C99YcquK6TXI1JaEQI == null;
		}
	}

	private readonly ObservableCollection<ActionVariable> dCXF2SXMnR;

	private readonly VarType? K5bFu4xyjY;

	[CompilerGenerated]
	private string gSJFNWA9SQ;

	[CompilerGenerated]
	private bool YYNFJMKhYO;

	[CompilerGenerated]
	private bool? pvdF0pJ4xx;

	private SmartCollection<VariableOperation> gUoFCIqo5e = new SmartCollection<VariableOperation>();

	private IList<KeyValuePair<string, string>> dLXFPfEs3p = new List<KeyValuePair<string, string>>
	{
		new KeyValuePair<string, string>("&&", "“逻辑与”，并且(AND)。两侧的条件需同时满足。\n示例：{数字} > 0 && {数字} < 5"),
		new KeyValuePair<string, string>("||", "“逻辑或”，或者(OR)。两侧的条件有一个满足即可。\n示例：{选项} ==\"A\" || {选项} ==\"B\""),
		new KeyValuePair<string, string>("!", "“逻辑非”，逆转判断条件。\n示例：!{操作成功}"),
		new KeyValuePair<string, string>("( )", "小括号，组合多个条件。\n示例：({序号} ==1 || {序号} == 2 ||{序号} == 3) && {操作成功} ")
	};

	private SmartCollection<OperationParamItem> jSgFEOiime = new SmartCollection<OperationParamItem>();

	internal ComboBox CbVariable;

	internal ComboBox CbOperation;

	internal ItemsControl ParamItems;

	internal Button BtnSave;

	internal Button BtnInsert;

	internal ItemsControl OperatorItems;

	private bool BVgFyYcjKv;

	private static BoolExpressionHelperWindow YjVvSxzrrKnOV1i1PPo;

	public string ResultExpression
	{
		[CompilerGenerated]
		get
		{
			return gSJFNWA9SQ;
		}
		[CompilerGenerated]
		set
		{
			gSJFNWA9SQ = value;
		}
	}

	public bool Replace
	{
		[CompilerGenerated]
		get
		{
			return YYNFJMKhYO;
		}
		[CompilerGenerated]
		set
		{
			YYNFJMKhYO = value;
		}
	}

	public bool? Result
	{
		[CompilerGenerated]
		get
		{
			return pvdF0pJ4xx;
		}
		[CompilerGenerated]
		set
		{
			pvdF0pJ4xx = value;
		}
	}

	public BoolExpressionHelperWindow(IList<ActionVariable> actionVariables, VarType? targetVarType)
	{
		IEnumerable<ActionVariable> collection;
		if (actionVariables == null)
		{
			IEnumerable<ActionVariable> enumerable = new List<ActionVariable>();
			collection = enumerable;
		}
		else
		{
			IEnumerable<ActionVariable> enumerable = AppHelper.Clone(actionVariables).OrderBy(_003C_003Ec.Fl9verxdFMB ?? (_003C_003Ec.Fl9verxdFMB = _003C_003Ec.SrWvexH4BQg.WqVveKeecSU));
			collection = enumerable;
		}
		dCXF2SXMnR = new ObservableCollection<ActionVariable>(collection);
		dCXF2SXMnR.Add(new ActionVariable
		{
			Key = "quicker_in_param",
			Desc = "动作参数",
			Type = VarType.Text
		});
		K5bFu4xyjY = targetVarType;
		InitializeComponent();
		OperatorItems.ItemsSource = dLXFPfEs3p;
		CbVariable.ItemsSource = dCXF2SXMnR;
		CbOperation.ItemsSource = gUoFCIqo5e;
		ParamItems.ItemsSource = jSgFEOiime;
		base.Loaded += yh2OFGwVjC;
	}

	private void yh2OFGwVjC(object sender, RoutedEventArgs e)
	{
		base.Dispatcher.InvokeAsync(sdEFL9gQd1, DispatcherPriority.ApplicationIdle);
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void xH1OUTmUml(object sender, SelectionChangedEventArgs e)
	{
		if (CbVariable.SelectedItem == null)
		{
			gUoFCIqo5e.Clear();
			return;
		}
		ActionVariable actionVariable_ = CbVariable.SelectedItem as ActionVariable;
		nRjOlyWO21(actionVariable_);
	}

	private void nRjOlyWO21(ActionVariable actionVariable_0)
	{
		_003C_003Ec__DisplayClass20_0 _003C_003Ec__DisplayClass20_ = new _003C_003Ec__DisplayClass20_0();
		_003C_003Ec__DisplayClass20_.jnsveBNBy5T = actionVariable_0;
		_003C_003Ec__DisplayClass20_.zimveQArRnC = this;
		gUoFCIqo5e.Reset(VariableOperation.d6lUMXMwC2.Where(_003C_003Ec__DisplayClass20_.gPgvepYmQHa));
	}

	private void eiTOi36lv5(object sender, SelectionChangedEventArgs e)
	{
		if (CbOperation.SelectedItem == null)
		{
			jSgFEOiime.Clear();
			return;
		}
		VariableOperation variableOperation = CbOperation.SelectedItem as VariableOperation;
		if (!variableOperation.E32UXMkvKi().HasData())
		{
			jSgFEOiime.Clear();
		}
		else
		{
			jSgFEOiime.Reset(variableOperation.E32UXMkvKi().Select(coAFvpmdAl));
		}
	}

	private void P6sO3KnbXU(object sender, RoutedEventArgs e)
	{
		base.Dispatcher.InvokeAsync(Hb5FSFIeCb);
	}

	private void Ai8OfCq0qO(bool bool_2)
	{
		VariableOperation variableOperation = CbOperation.SelectedItem as VariableOperation;
		ActionVariable actionVariable = CbVariable.SelectedItem as ActionVariable;
		if (variableOperation != null)
		{
			int num = 0;
			if (!Bp1FYgzNWkhQRixaNVd())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (actionVariable != null)
			{
				ResultExpression = variableOperation.hFSU1udfpg().Replace("%%", "{" + actionVariable.Key + "}");
				if (jSgFEOiime.HasData())
				{
					foreach (OperationParamItem item in jSgFEOiime)
					{
						ResultExpression = ResultExpression.Replace("%" + item.Param.Key + "%", (item.SelectedVariable != null) ? ("{" + item.SelectedVariable.Key + "}") : ((item.Param.kiOU3S23fe().FirstOrDefault() == VarType.Text) ? ("\"" + EscapeInput(item.StringValue) + "\"") : item.StringValue));
					}
				}
				Replace = bool_2;
				this.ThNvuM5Q9GQ(true);
				return;
			}
		}
		AppHelper.ShowWarning("表单输入不完整。");
	}

	public string EscapeInput(string input)
	{
		foreach (KeyValuePair<string, string> item in new Dictionary<string, string>
		{
			{ "\\", "\\\\" },
			{ "\"", "\\\"" },
			{ "\n", "\\n" },
			{ "\r", "\\r" },
			{ "\t", "\\t" }
		})
		{
			input = input.Replace(item.Key, item.Value);
		}
		return input;
	}

	private void TJmOztR6pm(object sender, RoutedEventArgs e)
	{
		Ai8OfCq0qO(false);
	}

	private void tG5FwUT8G1(Action<(string aaa, int bbb)> action)
	{
	}

	private void EsBFt4SHwD(object sender, RoutedEventArgs e)
	{
		string resultExpression = (sender as Button).Tag as string;
		ResultExpression = resultExpression;
		Replace = false;
		this.ThNvuM5Q9GQ(true);
	}

	private void MK2Fgg4jUh(object sender, KeyEventArgs e)
	{
		if (e.Key == Key.Escape)
		{
			Close();
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!BVgFyYcjKv)
		{
			BVgFyYcjKv = true;
			Uri resourceLocator = new Uri("/Quicker;component/modules/expressiontester/boolexpressionhelperwindow.xaml", UriKind.Relative);
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
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 1:
			((BoolExpressionHelperWindow)target).KeyUp += MK2Fgg4jUh;
			return;
		case 2:
			CbVariable = (ComboBox)target;
			CbVariable.SelectionChanged += xH1OUTmUml;
			return;
		case 3:
			CbOperation = (ComboBox)target;
			CbOperation.SelectionChanged += eiTOi36lv5;
			return;
		case 4:
			ParamItems = (ItemsControl)target;
			return;
		case 6:
			BtnSave = (Button)target;
			BtnSave.Click += P6sO3KnbXU;
			return;
		case 7:
			BtnInsert = (Button)target;
			BtnInsert.Click += TJmOztR6pm;
			return;
		case 8:
			OperatorItems = (ItemsControl)target;
			return;
		}
		BVgFyYcjKv = true;
		if (YjVvSxzrrKnOV1i1PPo == null)
		{
			switch (0)
			{
			}
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 9:
			((Button)target).Click += EsBFt4SHwD;
			break;
		case 5:
			((ComboBox)target).SelectionChanged += xH1OUTmUml;
			break;
		}
	}

	[CompilerGenerated]
	private void sdEFL9gQd1()
	{
		CbVariable.IsDropDownOpen = true;
	}

	[CompilerGenerated]
	private OperationParamItem coAFvpmdAl(z1Zs1sAbPOMnx22hak7 z1Zs1sAbPOMnx22hak7_0)
	{
		_003C_003Ec__DisplayClass21_0 _003C_003Ec__DisplayClass21_ = new _003C_003Ec__DisplayClass21_0();
		_003C_003Ec__DisplayClass21_.uICvenYyVvX = this;
		_003C_003Ec__DisplayClass21_.x = z1Zs1sAbPOMnx22hak7_0;
		return new OperationParamItem
		{
			Param = _003C_003Ec__DisplayClass21_.x,
			StringValue = _003C_003Ec__DisplayClass21_.x.SampleValue,
			AvailableVariables = dCXF2SXMnR.Where(_003C_003Ec__DisplayClass21_.DkGvejrb9lF).ToList()
		};
	}

	[CompilerGenerated]
	private void Hb5FSFIeCb()
	{
		Ai8OfCq0qO(true);
	}

	internal static bool Bp1FYgzNWkhQRixaNVd()
	{
		return YjVvSxzrrKnOV1i1PPo == null;
	}
}
