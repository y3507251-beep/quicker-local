using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using Quicker.Common;
using Quicker.Domain;
using Quicker.Domain.Searching.Actions;
using Quicker.Domain.Services;
using Quicker.Public.Searching;
using Quicker.Utilities;
using Quicker.Utilities.UI;

namespace Quicker.View;

public class SearchActionWindow : Window, IComponentConnector, IStyleConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec CU6SXAxa0nV;

		public static Func<ActionSearchResult, int> vCWSXOESbU0;

		public static Func<ActionSearchResult, ActionSearchResultItem> NqhSXF2Xo2j;

		public static Func<ActionSearchResultItem, double> bfPSXUB1kCR;

		private static _003C_003Ec f08ALUWZCCBfq19mFFj6;

		static _003C_003Ec()
		{
			CU6SXAxa0nV = new _003C_003Ec();
		}

		internal int PeASXoWHbcr(ActionSearchResult x)
		{
			return x.Score;
		}

		internal ActionSearchResultItem L8sSXTjIhoC(ActionSearchResult x)
		{
			return new ActionSearchResultItem(null, x.Action, x.Profile, x.Score, x.IsDirectWord)
			{
				TitleMatchPositions = x.TitleMatchResult?.GetMatchPositions(),
				DescriptionMatchPositions = x.DescriptionMatchResult?.GetMatchPositions()
			};
		}

		internal double hwKSXMhua1i(ActionSearchResultItem x)
		{
			return x.Score;
		}

		internal static bool Vih2QQWZ7jREo11uVTrN()
		{
			return f08ALUWZCCBfq19mFFj6 == null;
		}
	}

	private readonly DataService x0Ug5VdSp89;

	[CompilerGenerated]
	private ActionItem chCg5ZQm6HX;

	private readonly DebounceDispatcher XYpg59uJ7CD = new DebounceDispatcher();

	internal TextBox TxtSearch;

	internal ListBox LbResults;

	internal Button BtnOk;

	internal Button BtnCancel;

	private bool twMg5hx3nDn;

	private static SearchActionWindow S8Za6MFQZpB4opfGXaS5;

	public ActionItem Result
	{
		[CompilerGenerated]
		get
		{
			return chCg5ZQm6HX;
		}
		[CompilerGenerated]
		private set
		{
			chCg5ZQm6HX = value;
		}
	}

	public SearchActionWindow(DataService dataService)
	{
		x0Ug5VdSp89 = dataService;
		InitializeComponent();
		base.Loaded += pTag5NEX9IW;
	}

	private void pTag5NEX9IW(object sender, RoutedEventArgs e)
	{
		Activate();
		Task.Delay(50).ContinueWith(R46g57ILb1E);
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void vFLg5J52Mo1(object sender, EventArgs e)
	{
	}

	public void ClearSearchText()
	{
		TxtSearch.Text = "";
	}

	private void ixVg50rvnCh(object sender, EventArgs e)
	{
		if (base.OwnedWindows.Count == 0)
		{
			Hide();
		}
	}

	private void hVeg5Ct3Uof(object sender, TextChangedEventArgs e)
	{
		if (string.IsNullOrEmpty(TxtSearch.Text))
		{
			ivCg5PbLtAn();
		}
		else
		{
			XYpg59uJ7CD.Debounce(100, iNPg5qB6SQf);
		}
	}

	private void ivCg5PbLtAn()
	{
		string text = TxtSearch.Text;
		if (string.IsNullOrEmpty(text))
		{
			SetResults(new List<ActionSearchResult>());
			return;
		}
		QueryContext queryContext = new QueryContext();
		queryContext.SetSearch(text, !AppState.HHxtaMaoqJr().MatchUpperCaseEqual);
		IEnumerable<ActionSearchResult> source = x0Ug5VdSp89.tyXtXtQLUHP(queryContext, false, false);
		SetResults(source.OrderByDescending(_003C_003Ec.vCWSXOESbU0 ?? (_003C_003Ec.vCWSXOESbU0 = _003C_003Ec.CU6SXAxa0nV.PeASXoWHbcr)).Take(10).ToList());
	}

	public void SetResults(IList<ActionSearchResult> results)
	{
		List<ActionSearchResultItem> itemsSource = results.Select(_003C_003Ec.NqhSXF2Xo2j ?? (_003C_003Ec.NqhSXF2Xo2j = _003C_003Ec.CU6SXAxa0nV.L8sSXTjIhoC)).OrderByDescending(_003C_003Ec.bfPSXUB1kCR ?? (_003C_003Ec.bfPSXUB1kCR = _003C_003Ec.CU6SXAxa0nV.hwKSXMhua1i)).ToList();
		LbResults.BeginInit();
		LbResults.ItemsSource = itemsSource;
		LbResults.EndInit();
		if (results.Count > 0)
		{
			LbResults.SelectedIndex = 0;
			LbResults.Visibility = Visibility.Visible;
		}
		else
		{
			LbResults.Visibility = Visibility.Collapsed;
		}
	}

	private void TxtSearch_OnPreviewKeyDown(object sender, KeyEventArgs e)
	{
		if (e.Key == Key.Escape)
		{
			Hide();
		}
		else if (e.Key == Key.Down)
		{
			if (LbResults.SelectedIndex < LbResults.Items.Count - 1)
			{
				LbResults.SelectedIndex++;
			}
		}
		else if (e.Key == Key.Up)
		{
			if (LbResults.SelectedIndex > 0)
			{
				LbResults.SelectedIndex--;
			}
		}
		else if (e.Key == Key.Return)
		{
			Pnxg5EyH9CC();
			int num = 0;
			if (!c3kdTTFQ5ZbH63po9pR2())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			e.Handled = true;
		}
	}

	private void Pnxg5EyH9CC()
	{
		if (LbResults.SelectedItem == null)
		{
			AppHelper.ShowWarning("请选择动作。");
			return;
		}
		ActionSearchResultItem actionSearchResultItem = LbResults.SelectedItem as ActionSearchResultItem;
		Result = actionSearchResultItem.Tag as ActionItem;
		base.DialogResult = true;
	}

	private void zYIg5y6L0Xu(object sender, RoutedEventArgs e)
	{
		Pnxg5EyH9CC();
	}

	private void b1cg58woUXk(object sender, KeyEventArgs e)
	{
	}

	private void zsRg5ailGro(object sender, MouseButtonEventArgs e)
	{
		if (e.ClickCount == 2)
		{
			Pnxg5EyH9CC();
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!twMg5hx3nDn)
		{
			twMg5hx3nDn = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/ui/searchactionwindow.xaml", UriKind.Relative);
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
		switch (connectionId)
		{
		case 1:
		{
			((SearchActionWindow)target).PreviewKeyDown += b1cg58woUXk;
			int num = 0;
			if (S8Za6MFQZpB4opfGXaS5 != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			break;
		}
		case 2:
			TxtSearch = (TextBox)target;
			TxtSearch.PreviewKeyDown += TxtSearch_OnPreviewKeyDown;
			TxtSearch.TextChanged += hVeg5Ct3Uof;
			break;
		case 3:
			LbResults = (ListBox)target;
			break;
		default:
			twMg5hx3nDn = true;
			break;
		case 5:
			BtnOk = (Button)target;
			BtnOk.Click += zYIg5y6L0Xu;
			break;
		case 6:
			BtnCancel = (Button)target;
			break;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 4)
		{
			((Grid)target).PreviewMouseLeftButtonDown += zsRg5ailGro;
		}
	}

	[CompilerGenerated]
	private void R46g57ILb1E(Task task_0)
	{
		AppHelper.RunOnUiThread(false, SOQg5RYVR6B);
	}

	[CompilerGenerated]
	private void SOQg5RYVR6B()
	{
		TxtSearch.Focus();
		TxtSearch.SelectAll();
	}

	[CompilerGenerated]
	private void iNPg5qB6SQf(object object_0)
	{
		ivCg5PbLtAn();
	}

	internal static bool c3kdTTFQ5ZbH63po9pR2()
	{
		return S8Za6MFQZpB4opfGXaS5 == null;
	}
}
