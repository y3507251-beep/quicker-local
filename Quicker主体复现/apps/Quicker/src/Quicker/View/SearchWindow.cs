using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media.Effects;
using System.Windows.Threading;
using BSpkSC2BMVITn7dofh0;
using elos7sWrlWq3d2dc6pr;
using FontAwesome5;
using FontAwesome5.WPF;
using HandyControl.Tools;
using JTIh7V5l65QV75A93Ly;
using log4net;
using nTcrhUWGhOwDpTXBUpF;
using PInvoke;
using qJZMmVWzO9EdYASqBDx;
using qlCEFf26DxbmIE2RAgM;
using Quicker.Common;
using Quicker.Common.Entities;
using Quicker.Domain;
using Quicker.Domain.Actions.Runtime;
using Quicker.Domain.Actions.X.BuiltinRunners.Sys;
using Quicker.Domain.Messages;
using Quicker.Domain.Searching.Actions;
using Quicker.Domain.Services;
using Quicker.Modules.Searching;
using Quicker.Modules.Searching.Builtin;
using Quicker.Public.Extensions;
using Quicker.Public.Searching;
using Quicker.Settings.Code;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.UI;
using Quicker.Utilities.Win32;
using Quicker.View.Controls;
using SnipInsight.Util;
using SWBMfZYGyc6L9yHIvKQ;
using vjGJX2WpUfGgQtNkVc7;
using WcdJQYXW9E2moeWW9Np;
using WindowsInput.Native;
using XVYgmtWxau9GCu4LbWf;
using Yf8A0Tj55ce1jngb1h3;

namespace Quicker.View;

public class SearchWindow : Window, IComponentConnector, IStyleConnector, ISearchWindow
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec Oo2SxwlE8pf;

		public static Func<bs268GWtdlAMtSyu6IQ, bool> sw8SxtcGtWr;

		public static Func<bs268GWtdlAMtSyu6IQ, SearchPluginItem> l7dSxgAHEAl;

		public static Func<IGrouping<SearchPluginItem, bs268GWtdlAMtSyu6IQ>, ResultGroupItem> A5eSxLOWvme;

		public static Func<SearchPluginItem, string> f12SxvTrSe6;

		public static Func<SearchPluginItem, bool> XEMSxSFnH82;

		public static Func<SearchPlugin, string> qlFSx2SyRXL;

		public static Func<SearchPluginItem, bool> HagSxuHYTAf;

		public static Func<SearchPluginItem, string> JwASxNxpHHJ;

		public static Func<IGrouping<string, SearchPluginItem>, string> OghSxJ9qBhb;

		public static Func<SearchPluginItem, double> Uk7Sx04gJ7l;

		public static Func<SearchPluginItem, string> XZvSxCMaVNi;

		public static Func<SearchPlugin, string> t5ASxPd5qTq;

		private static _003C_003Ec nR3sd0W8K7PA4jwc8oAO;

		static _003C_003Ec()
		{
			Oo2SxwlE8pf = new _003C_003Ec();
		}

		internal bool mb1SKo0TMrh(bs268GWtdlAMtSyu6IQ x)
		{
			return x.Result.QueryContext != null;
		}

		internal SearchPluginItem jfCSKTk8xVh(bs268GWtdlAMtSyu6IQ x)
		{
			return x.Result.QueryContext.PluginItem;
		}

		internal ResultGroupItem v82SKMwEH25(IGrouping<SearchPluginItem, bs268GWtdlAMtSyu6IQ> x)
		{
			return new ResultGroupItem(x.Key, x.Count());
		}

		internal string rpoSKAnXt3r(SearchPluginItem x)
		{
			return x.Plugin.PluginInfo.Name;
		}

		internal bool QmMSKOXDy1q(SearchPluginItem x)
		{
			return x.IsGlobal;
		}

		internal string pj9SKF0VBep(SearchPlugin x)
		{
			return x.PluginInfo.Name;
		}

		internal bool OTZSKU4k3yo(SearchPluginItem x)
		{
			return !x.IsGlobal;
		}

		internal string bwxSKlZVQfd(SearchPluginItem x)
		{
			return x.TriggerWord;
		}

		internal string UcgSKiK6jHt(IGrouping<string, SearchPluginItem> x)
		{
			return x.Key;
		}

		internal double JcpSK31jgRd(SearchPluginItem x)
		{
			return x.Weight;
		}

		internal string rNkSKfIUb9u(SearchPluginItem x)
		{
			if (!string.IsNullOrEmpty(x.Condition))
			{
				return x.Plugin.PluginInfo.Name + "[" + x.Condition + "]";
			}
			return x.Plugin.PluginInfo.Name;
		}

		internal string AIXSKzN7PjR(SearchPlugin x)
		{
			return x.PluginInfo.Name;
		}

		internal static bool TdXRFmW8B9BNtWJ6LiqQ()
		{
			return nR3sd0W8K7PA4jwc8oAO == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass84_0
	{
		public IList<ResultGroupItem> rH9SxyeEKpl;

		public SearchWindow lfuSx8YXWCQ;

		private static _003C_003Ec__DisplayClass84_0 n83FpjW8O9KiBA9hYvV7;

		internal void qw3SxEO9mnB()
		{
			if (rH9SxyeEKpl != null)
			{
				lfuSx8YXWCQ.GRRgObs1r28.Reset(rH9SxyeEKpl);
			}
			else
			{
				lfuSx8YXWCQ.GRRgObs1r28.Clear();
			}
		}

		internal static bool iNCTeHW8JhgKsneRYQxI()
		{
			return n83FpjW8O9KiBA9hYvV7 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass87_0
	{
		public SearchPlugin h86Sx7LMB1d;

		internal static _003C_003Ec__DisplayClass87_0 NZPjscW8aArGHSFvMlJ5;

		internal bool OWSSxaGM0Ju(ResultGroupItem x)
		{
			return x.PluginItem.Plugin == h86Sx7LMB1d;
		}

		internal static bool sGmoc4W8r9AMbSGl7MnU()
		{
			return NZPjscW8aArGHSFvMlJ5 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass88_0
	{
		public SearchWindow NX5Sxc7RcnZ;

		public IList<SearchResultItem> EcfSxVn4Was;

		public Action PL2SxZsBgai;

		private static _003C_003Ec__DisplayClass88_0 jr5USbW89CU0GmnwZT8O;

		internal void vdtSxR9JuMC()
		{
			if (NX5Sxc7RcnZ.IsVisible)
			{
				NX5Sxc7RcnZ.HJ4gOH3pE5p.NWytNa29b4n(EcfSxVn4Was);
				NX5Sxc7RcnZ.Dispatcher.InvokeAsync(PL2SxZsBgai ?? (PL2SxZsBgai = fTISxqNRD1Y), DispatcherPriority.ApplicationIdle);
				NX5Sxc7RcnZ.kGDgAXLs1Dd();
			}
		}

		internal void fTISxqNRD1Y()
		{
			if (NX5Sxc7RcnZ.LbResults.Items.Count > 0)
			{
				NX5Sxc7RcnZ.LbResults.SelectedIndex = 0;
				try
				{
					NX5Sxc7RcnZ.LbResults.ScrollIntoView(NX5Sxc7RcnZ.LbResults.Items[0]);
				}
				catch (Exception ex)
				{
					U6AgO6LYFnp.Warn("选中列表项出错：" + ex.Message, ex);
				}
			}
		}

		internal static bool J1fAPUW8LZNhq9MOc5aj()
		{
			return jr5USbW89CU0GmnwZT8O == null;
		}
	}

	private readonly DataService UZ7gOGXeXki;

	private readonly ITinyMessengerHub ACAgOs6NcG6;

	private readonly EMIPQgWCYPF9pbC4aTX HJ4gOH3pE5p = new EMIPQgWCYPF9pbC4aTX();

	private ActionSearchHistory vq1gO11T3Ss = new ActionSearchHistory();

	private readonly SmartCollection<ResultGroupItem> GRRgObs1r28 = new SmartCollection<ResultGroupItem>();

	private static readonly ILog U6AgO6LYFnp;

	[CompilerGenerated]
	private string gc0gOXxr4hZ;

	[CompilerGenerated]
	private string At1gOmv7HGO;

	[CompilerGenerated]
	private IntPtr P8kgOKbojjV;

	private readonly DebounceDispatcher B0ngOxFWlQn = new DebounceDispatcher();

	private bool wwxgOrG9U7u;

	private bool bcngOpTjOhr;

	private int aGhgOBXu9O2;

	private int q8ugOQS3PRl;

	private bool ns1gOjQkYta;

	private kI86NbWLfJKJc0tGQJY kbhgOnLyLpY;

	private kI86NbWLfJKJc0tGQJY qHGgO4rI5JD;

	private kI86NbWLfJKJc0tGQJY SaDgO5dPUZZ;

	[CompilerGenerated]
	private IntPtr ubEgODAUkdW;

	private bool PpcgOdi8Lx8;

	private bool ejdgOoC7Ljb;

	public static readonly DependencyProperty SelectedActionProperty;

	public static readonly DependencyProperty ActionPlaceholderProperty;

	private readonly TinyMessageSubscriptionToken YpMgOThJBAi;

	private readonly TinyMessageSubscriptionToken xcJgOMDiygJ;

	private bs268GWtdlAMtSyu6IQ CqMgOAf1ygm;

	[CompilerGenerated]
	private bool P29gOO1oUPs;

	private CancellationTokenSource TI5gOFrU9yl = new CancellationTokenSource();

	private string USHgOUUQJ4N = "";

	private int NcwgOld0h4I;

	private Key? wDhgOiunwxU;

	private Window E0ygO3GNP64;

	private object elhgOfX0JMi;

	private System.Windows.Point wIVgOzJtWYD = new System.Windows.Point(0.0, 0.0);

	private khuggB2ZntAfW2CDU1r FkIgFwGCJhC = new khuggB2ZntAfW2CDU1r();

	private int ckDgFtVXpU8 = -1;

	internal SearchWindow TheWindow;

	internal System.Windows.Controls.ListBox LbResultGroups;

	internal DropShadowEffect VYkgFgSS3FI;

	internal DropShadowEffect t6xgFL28clQ;

	internal Grid FilterGrid;

	internal StackPanel PnlSelectedAction;

	internal IconControl SelectedActionIcon;

	internal TextBlock SelectedActionLabel;

	internal System.Windows.Controls.TextBox TxtSearch;

	internal System.Windows.Controls.MenuItem MenuInputKeywords;

	internal System.Windows.Controls.MenuItem MenuResetLocation;

	internal System.Windows.Controls.MenuItem MenuHelp;

	internal GridSplitter Splitter;

	internal System.Windows.Controls.Button BtnPin;

	internal SvgAwesome IconPin;

	internal System.Windows.Controls.ListBox LbResults;

	private bool A2ugFvR4KGB;

	internal static SearchWindow Nq8GNsFWpvk7Odp3OC3K;

	public string ActiveProcessBeforeShow
	{
		[CompilerGenerated]
		get
		{
			return gc0gOXxr4hZ;
		}
		[CompilerGenerated]
		set
		{
			gc0gOXxr4hZ = value;
		}
	}

	public string CurrentExeBeforeShow
	{
		[CompilerGenerated]
		get
		{
			return At1gOmv7HGO;
		}
		[CompilerGenerated]
		set
		{
			At1gOmv7HGO = value;
		}
	}

	public IntPtr ActiveWindowBeforeShow
	{
		[CompilerGenerated]
		get
		{
			return P8kgOKbojjV;
		}
		[CompilerGenerated]
		set
		{
			P8kgOKbojjV = value;
		}
	}

	public IntPtr WindowHandle
	{
		[CompilerGenerated]
		get
		{
			return ubEgODAUkdW;
		}
		[CompilerGenerated]
		private set
		{
			ubEgODAUkdW = value;
		}
	}

	public bool IsPinned
	{
		get
		{
			return PpcgOdi8Lx8;
		}
		set
		{
			PpcgOdi8Lx8 = value;
			IconPin.Icon = (PpcgOdi8Lx8 ? EFontAwesomeIcon.Solid_Thumbtack : EFontAwesomeIcon.Light_Thumbtack);
			IconPin.Rotation = ((!PpcgOdi8Lx8) ? 45 : 0);
		}
	}

	public ActionItem SelectedAction
	{
		get
		{
			return (ActionItem)GetValue(SelectedActionProperty);
		}
		set
		{
			SetValue(SelectedActionProperty, value);
		}
	}

	public string ActionPlaceholder
	{
		get
		{
			return (string)GetValue(ActionPlaceholderProperty);
		}
		set
		{
			SetValue(ActionPlaceholderProperty, value);
		}
	}

	public string SearchText
	{
		get
		{
			return TxtSearch.Text;
		}
		set
		{
			TxtSearch.Text = value ?? "";
		}
	}

	public bool ShouldSkipNextDeactivate()
	{
		return ejdgOoC7Ljb;
	}

	public void SetSkipNextDeactivate(bool doSkip = true)
	{
		ejdgOoC7Ljb = doSkip;
	}

	private static void uRtgA8rALu9(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
	{
		SearchWindow obj = dependencyObject_0 as SearchWindow;
		if (obj == null)
		{
			if (obj == null)
			{
				return;
			}
		}
		else
		{
			obj.ClearResultCollection();
			if (obj == null)
			{
				return;
			}
		}
		obj.SGlgAH1ZgZ7();
	}

	public SearchWindow(DataService dataService, ITinyMessengerHub hub, ActionEditMgr actionEditMgr)
	{
		UZ7gOGXeXki = dataService;
		ACAgOs6NcG6 = hub;
		SaDgO5dPUZZ = new yCRUTZWasRYl1TX9ia4(this);
		qHGgO4rI5JD = new iKTOkqWIMO3lqa4hFjM(this);
		kbhgOnLyLpY = SaDgO5dPUZZ;
		InitializeComponent();
		LbResults.ItemsSource = HJ4gOH3pE5p;
		LbResultGroups.ItemsSource = GRRgObs1r28;
		base.Loaded += y5RgAVLfc6l;
		base.Activated += afggA9ZKsVd;
		base.Deactivated += vpNgAhNAGi4;
		base.IsVisibleChanged += Dm3gAZq8i2Z;
		base.Closing += ShLgAewjMDq;
		base.Closed += pJvgARBaCd0;
		UIHelper.CreateUiBindings(this);
		TZbgAljdPp9();
		base.DataContext = this;
		double? num = dDh7g7Xw7JyQPUTbYwJ.SearchWindowWidth;
		if (num.HasValue)
		{
			base.Width = Math.Max(num.Value, 400.0);
		}
		DispatcherTinyMessageProxy proxy = new DispatcherTinyMessageProxy(base.Dispatcher);
		YpMgOThJBAi = hub.Subscribe<UserSettingsChangedMessage>(OZagAq5sovh, proxy);
		xcJgOMDiygJ = hub.Subscribe<ActionDeletedMessage>(UsEgAaXQY0t, proxy);
		fxNgAcg7HAf();
	}

	private void UsEgAaXQY0t(ActionDeletedMessage actionDeletedMessage_0)
	{
		if (IsPinned && kbhgOnLyLpY is yCRUTZWasRYl1TX9ia4)
		{
			tn0gA12P0JY();
		}
	}

	private void deJgA7pmwfo(object sender, SelectionChangedEventArgs e)
	{
		if (CqMgOAf1ygm != null)
		{
			CqMgOAf1ygm.dGctuTndNE2((bs268GWtdlAMtSyu6IQ.KU82POuUC1eXe0CyqSN)0);
		}
		CqMgOAf1ygm = LbResults.SelectedItem as bs268GWtdlAMtSyu6IQ;
		if (CqMgOAf1ygm != null)
		{
			CqMgOAf1ygm.pootudHkGRA((bs268GWtdlAMtSyu6IQ.KU82POuUC1eXe0CyqSN)0);
		}
	}

	private void pJvgARBaCd0(object sender, EventArgs e)
	{
		ACAgOs6NcG6.Unsubscribe<UserSettingsChangedMessage>(YpMgOThJBAi);
		ACAgOs6NcG6.Unsubscribe<UserSettingsChangedMessage>(xcJgOMDiygJ);
	}

	private void OZagAq5sovh(UserSettingsChangedMessage userSettingsChangedMessage_0)
	{
		fxNgAcg7HAf();
	}

	private void fxNgAcg7HAf()
	{
		LbResults.MaxHeight = (AppState.DataService.CpItmVISR7P().SearchSettings?.MaxVisibleItemCount ?? 8) * 53 + 1;
		UiSettings uiSettings = FMP9ONqzXcgZ6r3WmZZ.A4qHeQImJ6();
		if (uiSettings != null && uiSettings.HideLabelIfHasIcon)
		{
			SelectedActionLabel.Visibility = Visibility.Collapsed;
		}
	}

	private void y5RgAVLfc6l(object sender, RoutedEventArgs e)
	{
		OYkgAGwf5KC();
		WindowHandle = this.GetHandle();
	}

	private void Dm3gAZq8i2Z(object sender, DependencyPropertyChangedEventArgs e)
	{
		if (!base.IsVisible)
		{
			Ib1gAD4ehAN();
			HJ4gOH3pE5p.eootNqWdvcf();
			if (SelectedAction != null && !IsPinned)
			{
				SelectedAction = null;
			}
		}
	}

	private void afggA9ZKsVd(object sender, EventArgs e)
	{
		TxtSearch.Focus();
	}

	private void vpNgAhNAGi4(object sender, EventArgs e)
	{
		if (base.OwnedWindows.Count == 0)
		{
			if (!ShouldSkipNextDeactivate() && !IsPinned)
			{
				RequestHide();
			}
			else
			{
				SetSkipNextDeactivate(false);
			}
		}
	}

	private void ShLgAewjMDq(object sender, CancelEventArgs e)
	{
		e.Cancel = true;
		RequestHide();
	}

	private void gnEgAYeJiNK(object sender, System.Windows.Input.MouseEventArgs e)
	{
		if (e.LeftButton == MouseButtonState.Pressed)
		{
			Md6gAIvpxi8();
		}
	}

	private void Md6gAIvpxi8()
	{
		try
		{
			DragMove();
			dDh7g7Xw7JyQPUTbYwJ.SearchWindowLocation = new System.Windows.Point(base.Left, base.Top);
		}
		catch
		{
		}
	}

	private void cyEgAW57aty(object sender, RoutedEventArgs e)
	{
		dDh7g7Xw7JyQPUTbYwJ.SearchWindowLocation = null;
		dDh7g7Xw7JyQPUTbYwJ.SearchWindowWidth = null;
		base.Width = 800.0;
		aJ2gAskvRIE();
	}

	private void F6CgAktNvQ1(object sender, RoutedEventArgs e)
	{
		AppWindowManager.ShowSettingsWindow(SettingPageId.SearchSettings);
	}

	public void RequestShow(ActionItem startSearchAction = null, string searchText = "")
	{
		int num = 3;
		int num3 = default(int);
		int start = default(int);
		string prevQueryText = default(string);
		while (true)
		{
			int num2;
			if (searchText == null)
			{
				num2 = 2;
				if (Nq8GNsFWpvk7Odp3OC3K == null)
				{
					goto IL_00de;
				}
				goto IL_0127;
			}
			goto IL_012d;
			IL_00b1:
			ActionAssociation association = startSearchAction.Association;
			object obj;
			if (association == null)
			{
				obj = null;
			}
			else
			{
				obj = association.SearchBoxPlaceholder;
				if (obj != null)
				{
					goto IL_00cd;
				}
			}
			obj = "";
			goto IL_00cd;
			IL_012d:
			q8ugOQS3PRl++;
			EGigOWw9LBH(true);
			wwxgOrG9U7u = startSearchAction != null;
			ActionPlaceholder = $"开始搜索({(VirtualKeyCode)AppState.HHxtaMaoqJr().SearchSettings.HintTriggerKey}查看提示)...";
			AppState.Lista4qx2wK().CountSearch();
			cRngAKseB33();
			SelectedAction = startSearchAction;
			if (startSearchAction == null)
			{
				goto IL_000e;
			}
			if (string.IsNullOrEmpty(searchText) || !searchText.StartsWith("("))
			{
				goto IL_00b1;
			}
			num2 = 1;
			if (LxyC2yFWX6sxqaA2HGc2())
			{
				goto IL_00de;
			}
			goto IL_0127;
			IL_01ea:
			TxtSearch.CaretIndex = searchText.Length;
			break;
			IL_01ae:
			if (!string.Equals(SearchText, searchText))
			{
				SearchText = searchText ?? "";
			}
			else
			{
				tn0gA12P0JY();
			}
			if (num3 > 0)
			{
				TxtSearch.Select(start, num3);
				break;
			}
			goto IL_01ea;
			IL_00de:
			switch (num2)
			{
			case 1:
				break;
			case 2:
				goto IL_00fc;
			case 3:
				continue;
			default:
				goto IL_01aa;
			case 4:
				goto IL_01ea;
			}
			if (searchText.EndsWith(")"))
			{
				ActionPlaceholder = searchText.Substring(1, searchText.Length - 2);
				searchText = "";
				goto IL_000e;
			}
			goto IL_00b1;
			IL_0127:
			num2 = num;
			goto IL_00de;
			IL_000e:
			start = 0;
			num3 = 0;
			SearchSettings searchSettings = AppState.HHxtaMaoqJr().SearchSettings;
			if (searchSettings != null && searchSettings.LoadPrevSearchText)
			{
				prevQueryText = vq1gO11T3Ss.GetPrevQueryText(SelectedAction?.Id, searchText);
				if (!string.IsNullOrEmpty(prevQueryText))
				{
					start = searchText.Length;
					num3 = prevQueryText.Length - searchText.Length;
					num2 = 0;
					if (Nq8GNsFWpvk7Odp3OC3K == null)
					{
						goto IL_00de;
					}
					goto IL_01aa;
				}
			}
			goto IL_01ae;
			IL_01aa:
			searchText = prevQueryText;
			goto IL_01ae;
			IL_00fc:
			searchText = "";
			goto IL_012d;
			IL_00cd:
			ActionPlaceholder = (string)obj;
			goto IL_000e;
		}
		AppImeHelper.SetImeState(TxtSearch, AppState.HHxtaMaoqJr().SearchSettings?.ImeControl);
		OYkgAGwf5KC();
		Show();
		TxtSearch.Focus();
		Activate();
		base.Opacity = 1.0;
	}

	private void OYkgAGwf5KC()
	{
		System.Windows.Point? point;
		while (true)
		{
			point = dDh7g7Xw7JyQPUTbYwJ.SearchWindowLocation;
			if (Nq8GNsFWpvk7Odp3OC3K != null)
			{
				switch (0)
				{
				case 1:
					continue;
				}
			}
			break;
		}
		if (point.HasValue)
		{
			if (!base.IsLoaded && (SystemParameters.VirtualScreenLeft > point.Value.X || SystemParameters.VirtualScreenLeft + SystemParameters.VirtualScreenWidth < point.Value.X || SystemParameters.VirtualScreenTop > point.Value.Y || SystemParameters.VirtualScreenTop + SystemParameters.VirtualScreenHeight < point.Value.Y))
			{
				dDh7g7Xw7JyQPUTbYwJ.SearchWindowLocation = null;
				aJ2gAskvRIE();
			}
			else
			{
				base.Left = point.Value.X;
				base.Top = point.Value.Y;
			}
		}
		else
		{
			aJ2gAskvRIE();
		}
	}

	private void aJ2gAskvRIE()
	{
		System.Drawing.Point mousePosition = NativeMethods.GetMousePosition();
		Screen screen = Screen.FromPoint(mousePosition);
		double dpiScaleByPoint = DpiUtilities.GetDpiScaleByPoint(mousePosition);
		Rectangle workingArea = screen.WorkingArea;
		double num = (double)workingArea.Left + ((double)workingArea.Width - base.Width / dpiScaleByPoint) / 2.0;
		double num2 = (double)workingArea.Top + (double)workingArea.Height / 3.65 - 40.0;
		User32.SetWindowPos(this.GetHandle(), NativeMethods.HWND_TOP, (int)num, (int)num2, 0, 0, User32.SetWindowPosFlags.SWP_NOSIZE);
	}

	[SpecialName]
	[CompilerGenerated]
	private bool PubgOIxgneL()
	{
		return P29gOO1oUPs;
	}

	[SpecialName]
	[CompilerGenerated]
	private void EGigOWw9LBH(bool value)
	{
		P29gOO1oUPs = value;
	}

	public void RequestHide()
	{
		base.Opacity = 0.0;
		EGigOWw9LBH(false);
		TI5gOFrU9yl?.Cancel(false);
		base.Dispatcher.InvokeAsync(FCNgOyNXAfN, DispatcherPriority.Input);
	}

	private void SGlgAH1ZgZ7()
	{
		kbhgOnLyLpY = ((SelectedAction == null) ? SaDgO5dPUZZ : qHGgO4rI5JD);
	}

	private void tn0gA12P0JY()
	{
		TI5gOFrU9yl.Cancel();
		TI5gOFrU9yl = new CancellationTokenSource();
		CancellationToken token = TI5gOFrU9yl.Token;
		aGhgOBXu9O2++;
		string text = (USHgOUUQJ4N = SearchText);
		try
		{
			kbhgOnLyLpY.LEmMjgMin79(text, token, aGhgOBXu9O2, q8ugOQS3PRl);
		}
		catch (Exception ex)
		{
			U6AgO6LYFnp.Warn("搜索(" + text + ")出错:" + ex.Message, ex);
		}
	}

	public void ClearResults()
	{
		AppHelper.RunOnUiThread(false, OodgO8O6KN0);
	}

	private void PfXgAbDyt2t()
	{
		IntPtr intPtr = AppState.HZUt7RIVqKK().Tn4tkP4TX97(this.GetHandle());
		if (intPtr != IntPtr.Zero)
		{
			NativeMethods.SetForegroundWindow(intPtr);
		}
		else
		{
			NativeMethods.SetForegroundWindow(ActiveWindowBeforeShow);
		}
	}

	private void vlDgA6eQBB7(object sender, TextChangedEventArgs e)
	{
		if (bcngOpTjOhr)
		{
			return;
		}
		if (string.IsNullOrEmpty(SearchText))
		{
			if (Nq8GNsFWpvk7Odp3OC3K != null)
			{
				switch (0)
				{
				}
			}
			B0ngOxFWlQn.Debounce(0, UlkgOaUvMMw);
			return;
		}
		int interval = ((SelectedAction == null) ? 20 : 100);
		string uSHgOUUQJ4N = USHgOUUQJ4N;
		if (uSHgOUUQJ4N != null && uSHgOUUQJ4N.StartsWith(SearchText) && USHgOUUQJ4N.Length > SearchText.Length)
		{
			interval = 200;
		}
		B0ngOxFWlQn.Debounce(interval, bRngO7eAkpQ);
	}

	public void SetResults(IList<SearchResultItem> results, int querySerial)
	{
		if (querySerial == aGhgOBXu9O2)
		{
			PEdgAm9LHu0(results);
			NcwgOld0h4I = querySerial;
		}
	}

	public void SetResultGroups(IList<ResultGroupItem> groups)
	{
		_003C_003Ec__DisplayClass84_0 _003C_003Ec__DisplayClass84_ = new _003C_003Ec__DisplayClass84_0();
		_003C_003Ec__DisplayClass84_.rH9SxyeEKpl = groups;
		_003C_003Ec__DisplayClass84_.lfuSx8YXWCQ = this;
		AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass84_.qw3SxEO9mnB);
	}

	public void AddResultGroup(ResultGroupItem group)
	{
	}

	private void kGDgAXLs1Dd()
	{
		if (SelectedAction == null)
		{
			_003C_003Ec__DisplayClass87_0 _003C_003Ec__DisplayClass87_ = new _003C_003Ec__DisplayClass87_0();
			List<ResultGroupItem> list = HJ4gOH3pE5p.oK2tNVvFqBS().Where(_003C_003Ec.sw8SxtcGtWr ?? (_003C_003Ec.sw8SxtcGtWr = _003C_003Ec.Oo2SxwlE8pf.mb1SKo0TMrh)).GroupBy(_003C_003Ec.l7dSxgAHEAl ?? (_003C_003Ec.l7dSxgAHEAl = _003C_003Ec.Oo2SxwlE8pf.jfCSKTk8xVh))
				.Select(_003C_003Ec.A5eSxLOWvme ?? (_003C_003Ec.A5eSxLOWvme = _003C_003Ec.Oo2SxwlE8pf.v82SKMwEH25))
				.ToList();
			_003C_003Ec__DisplayClass87_.h86Sx7LMB1d = (LbResultGroups.SelectedItem as ResultGroupItem)?.PluginItem.Plugin;
			GRRgObs1r28.Reset(list);
			if (list.Count > 0)
			{
				LbResultGroups.SelectedItem = list.FirstOrDefault(_003C_003Ec__DisplayClass87_.OWSSxaGM0Ju);
				int num = 0;
				if (!LxyC2yFWX6sxqaA2HGc2())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
		}
		else
		{
			GRRgObs1r28.Clear();
		}
	}

	private void PEdgAm9LHu0(IList<SearchResultItem> ilist_0)
	{
		_003C_003Ec__DisplayClass88_0 _003C_003Ec__DisplayClass88_ = new _003C_003Ec__DisplayClass88_0();
		_003C_003Ec__DisplayClass88_.NX5Sxc7RcnZ = this;
		_003C_003Ec__DisplayClass88_.EcfSxVn4Was = ilist_0;
		AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass88_.vdtSxR9JuMC, DispatcherPriority.Normal);
	}

	public void ClearResultCollection()
	{
		HJ4gOH3pE5p.eootNqWdvcf();
		GRRgObs1r28.Clear();
		if (base.IsVisible)
		{
			TxtSearch.Focus();
		}
	}

	private void cRngAKseB33()
	{
		try
		{
			bcngOpTjOhr = true;
			TxtSearch.Text = "";
		}
		finally
		{
			bcngOpTjOhr = false;
		}
	}

	private void TxtSearch_OnPreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
	{
		ModifierKeys modifierKeys = JrJWiKYIEBcPm8FFZOl.Modifiers;
		if (modifierKeys.HasFlag(ModifierKeys.Control))
		{
			if (e.Key == Key.C)
			{
				if (TxtSearch.SelectedText.Length == 0)
				{
					gP9gAxCvnkD((LbResults.SelectedItem as bs268GWtdlAMtSyu6IQ)?.Result);
					e.Handled = true;
					return;
				}
			}
			else if (e.Key == Key.G)
			{
				UXxgAr2hy33((LbResults.SelectedItem as bs268GWtdlAMtSyu6IQ)?.Result);
				e.Handled = true;
				return;
			}
		}
		if (e.Key == Key.Escape)
		{
			RequestHide();
			goto IL_04b0;
		}
		if (e.Key == Key.Down)
		{
			yfMgORo0TuF();
			return;
		}
		int num;
		Key systemKey = default(Key);
		if (e.Key == Key.Up)
		{
			WRKgOqcRRaE();
			num = 0;
			if (Nq8GNsFWpvk7Odp3OC3K != null)
			{
				goto IL_0269;
			}
		}
		else
		{
			if (e.Key == Key.Next)
			{
				cmVgOcuI36P();
				return;
			}
			if (e.Key == Key.Prior)
			{
				YnEgOVLfZ05();
				return;
			}
			if (e.Key == Key.Home)
			{
				m1NgOZscO7h();
				return;
			}
			if (e.Key == Key.End)
			{
				IUSgO9MEArv();
				return;
			}
			if (e.Key == Key.Tab)
			{
				if (modifierKeys.HasFlag(ModifierKeys.Control))
				{
					SYOgApDEbWG();
					e.Handled = true;
				}
				else if (ohTgAMAvuIn())
				{
					e.Handled = true;
				}
				return;
			}
			if (e.Key == Key.Back)
			{
				if (!string.IsNullOrEmpty(SearchText) || SelectedAction == null || wwxgOrG9U7u)
				{
					return;
				}
				num = 7;
				if (!LxyC2yFWX6sxqaA2HGc2())
				{
					goto IL_03a5;
				}
			}
			else
			{
				if (e.Key == Key.System)
				{
					systemKey = e.SystemKey;
					if (systemKey > Key.D0)
					{
						goto IL_026f;
					}
					goto IL_03c0;
				}
				if (e.Key == Key.Space)
				{
					num = 8;
					if (!LxyC2yFWX6sxqaA2HGc2())
					{
						goto IL_0269;
					}
				}
				else
				{
					if (e.Key == Key.Apps || (e.Key == Key.Right && TxtSearch.CaretIndex == TxtSearch.Text.Length))
					{
						SearchResultItem searchResultItem = (LbResults.SelectedItem as bs268GWtdlAMtSyu6IQ)?.Result;
						if (searchResultItem != null)
						{
							umGgAdpbFhN(searchResultItem, true);
						}
						return;
					}
					if (e.Key == KeyInterop.KeyFromVirtualKey(AppState.HHxtaMaoqJr().SearchSettings.HintTriggerKey))
					{
						mvagAQHRheJ();
						return;
					}
					if (modifierKeys != ModifierKeys.Control)
					{
						return;
					}
					num = 5;
					if (!LxyC2yFWX6sxqaA2HGc2())
					{
						goto IL_0269;
					}
				}
			}
		}
		goto IL_02cb;
		IL_02fb:
		int num2 = 0;
		if (e.Key > Key.NumPad0 && e.Key <= Key.NumPad9)
		{
			num2 = (int)(e.Key - 75);
		}
		else
		{
			if (e.Key <= Key.D0 || e.Key > Key.D9)
			{
				return;
			}
			num2 = (int)(e.Key - 35);
		}
		if (LbResultGroups.Items.Count > num2)
		{
			if (LbResultGroups.SelectedItem == LbResultGroups.Items[num2])
			{
				LbResultGroups.SelectedItem = null;
			}
			else
			{
				LbResultGroups.SelectedItem = LbResultGroups.Items[num2];
			}
		}
		return;
		IL_02cb:
		switch (num)
		{
		case 6:
			break;
		default:
			return;
		case 2:
			return;
		case 3:
			return;
		case 5:
			goto IL_02fb;
		case 1:
			goto IL_03a5;
		case 4:
			goto IL_041a;
		case 7:
			SelectedAction = null;
			tn0gA12P0JY();
			return;
		case 8:
			if (!string.IsNullOrEmpty(SearchText) && SelectedAction == null && a9ygATI1SDZ())
			{
				e.Handled = true;
			}
			return;
		case 9:
			goto IL_04b0;
		}
		goto IL_026f;
		IL_04b0:
		SelectedAction = null;
		return;
		IL_026f:
		object obj2;
		if (systemKey <= Key.D9)
		{
			int num3 = (int)(systemKey - 35);
			if (num3 >= 0 && num3 < LbResults.Items.Count)
			{
				bs268GWtdlAMtSyu6IQ obj = LbResults.Items[num3] as bs268GWtdlAMtSyu6IQ;
				if (obj == null)
				{
					num = 0;
					if (Nq8GNsFWpvk7Odp3OC3K != null)
					{
						goto IL_02cb;
					}
					goto IL_03a5;
				}
				obj2 = obj.Result;
				goto IL_03ad;
			}
			goto IL_03b8;
		}
		goto IL_03c0;
		IL_03b8:
		e.Handled = true;
		return;
		IL_03ad:
		SearchResultItem searchResultItem_ = (SearchResultItem)obj2;
		lMTgA5nRUqS(searchResultItem_, SearchTriggerType.AltNumber);
		goto IL_03b8;
		IL_0269:
		int num4 = default(int);
		num = num4;
		goto IL_02cb;
		IL_041a:
		SearchResultItem searchResultItem_2 = default(SearchResultItem);
		lMTgA5nRUqS(searchResultItem_2, SearchTriggerType.AltNumber);
		goto IL_0423;
		IL_03a5:
		obj2 = null;
		goto IL_03ad;
		IL_0423:
		e.Handled = true;
		return;
		IL_03c0:
		if (systemKey > Key.NumPad0 && systemKey <= Key.NumPad9)
		{
			int num5 = (int)(systemKey - 75);
			if (num5 >= 0 && num5 < LbResults.Items.Count)
			{
				searchResultItem_2 = (LbResults.Items[num5] as bs268GWtdlAMtSyu6IQ)?.Result;
				num4 = 4;
				goto IL_041a;
			}
			goto IL_0423;
		}
		switch (systemKey)
		{
		case Key.Left:
		{
			ActionSearchHistoryItem prevItem = vq1gO11T3Ss.GetPrevItem();
			if (prevItem != null)
			{
				UfSgABNXXtc(prevItem);
			}
			break;
		}
		case Key.Right:
		{
			ActionSearchHistoryItem nextItem = vq1gO11T3Ss.GetNextItem();
			if (nextItem != null)
			{
				UfSgABNXXtc(nextItem);
			}
			else
			{
				SearchText = "";
			}
			break;
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

	private void gP9gAxCvnkD(SearchResultItem searchResultItem_0)
	{
		if (searchResultItem_0 == null || searchResultItem_0.TextData.IsNullOrEmpty())
		{
			return;
		}
		try
		{
			if (searchResultItem_0.TextDataType == "path")
			{
				if (!File.Exists(searchResultItem_0.TextData))
				{
					int num = 0;
					if (Nq8GNsFWpvk7Odp3OC3K != null)
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					}
					if (!Directory.Exists(searchResultItem_0.TextData))
					{
						return;
					}
				}
				if (JrJWiKYIEBcPm8FFZOl.Modifiers.HasFlag(ModifierKeys.Shift))
				{
					System.Windows.Clipboard.SetFileDropList(new StringCollection { searchResultItem_0.TextData });
					AppHelper.ShowSuccess("已复制文件(夹)：" + searchResultItem_0.TextData);
				}
				else
				{
					System.Windows.Clipboard.SetText(searchResultItem_0.TextData);
					AppHelper.ShowSuccess("已复制文本：" + searchResultItem_0.TextData);
				}
			}
			else
			{
				System.Windows.Clipboard.SetText(searchResultItem_0.TextData);
				AppHelper.ShowSuccess("已复制文本：" + searchResultItem_0.TextData.ToShortString(20));
			}
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("复制失败：" + ex.Message);
		}
	}

	private void UXxgAr2hy33(SearchResultItem searchResultItem_0)
	{
		if (searchResultItem_0 == null || searchResultItem_0.TextData.IsNullOrEmpty())
		{
			return;
		}
		if (!File.Exists(searchResultItem_0.TextData))
		{
			if (!Directory.Exists(searchResultItem_0.TextData))
			{
				return;
			}
			int num = 0;
			if (!LxyC2yFWX6sxqaA2HGc2())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		IntPtr intPtr = OpenWindowGetter.FindAllWindowsWithClassName("#32770", StringComparison.Ordinal).FirstOrDefault();
		if (!(intPtr != IntPtr.Zero))
		{
			return;
		}
		if (NativeMethods.GetWindowText(intPtr).ToLower().ContainsAny("open", "打开"))
		{
			UiAutomationStep.sW9gVXkNnxW(searchResultItem_0.TextData);
			return;
		}
		if (!File.Exists(searchResultItem_0.TextData))
		{
			string textDatum = searchResultItem_0.TextData;
		}
		else
		{
			Path.GetDirectoryName(searchResultItem_0.TextData);
		}
		UiAutomationStep.sW9gVXkNnxW(searchResultItem_0.TextData);
	}

	private void SYOgApDEbWG()
	{
		if (LbResultGroups.Items.Count > 1)
		{
			int selectedIndex = LbResultGroups.SelectedIndex;
			selectedIndex++;
			if (selectedIndex < 0)
			{
				selectedIndex = 0;
			}
			else if (selectedIndex >= LbResultGroups.Items.Count)
			{
				selectedIndex = 0;
			}
			LbResultGroups.SelectedIndex = selectedIndex;
			int num = 0;
			if (Nq8GNsFWpvk7Odp3OC3K != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
	}

	private void UfSgABNXXtc(ActionSearchHistoryItem actionSearchHistoryItem_0)
	{
		if (actionSearchHistoryItem_0 == null)
		{
			return;
		}
		if (actionSearchHistoryItem_0.SelectedActionId != SelectedAction?.Id)
		{
			if (string.IsNullOrEmpty(actionSearchHistoryItem_0.SelectedActionId))
			{
				SelectedAction = null;
			}
			else
			{
				(ActionItem, ActionProfile) actionById = UZ7gOGXeXki.GetActionById(actionSearchHistoryItem_0.SelectedActionId);
				if (actionById.Item1 != null)
				{
					SelectedAction = actionById.Item1;
					int num = 0;
					if (!LxyC2yFWX6sxqaA2HGc2())
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					}
				}
			}
		}
		TxtSearch.Text = actionSearchHistoryItem_0.QueryString;
		TxtSearch.CaretIndex = TxtSearch.Text.Length;
	}

	private void mvagAQHRheJ()
	{
		int num = 2;
		string title = default(string);
		string text = default(string);
		StringBuilder stringBuilder = default(StringBuilder);
		string text2 = default(string);
		while (true)
		{
			if (E0ygO3GNP64 == null)
			{
				goto IL_0008;
			}
			int num2 = 1;
			if (!LxyC2yFWX6sxqaA2HGc2())
			{
				num2 = num;
			}
			goto IL_002b;
			IL_0072:
			title = "搜索提示";
			stringBuilder = new StringBuilder(100);
			stringBuilder.AppendLine("全局搜索");
			stringBuilder.AppendLine();
			foreach (SearchPluginItem item in gIh8AyjqAySmmxFMtv4.ncrteB8LyB5().OrderBy(_003C_003Ec.f12SxvTrSe6 ?? (_003C_003Ec.f12SxvTrSe6 = _003C_003Ec.Oo2SxwlE8pf.rpoSKAnXt3r)).Where(_003C_003Ec.XEMSxSFnH82 ?? (_003C_003Ec.XEMSxSFnH82 = _003C_003Ec.Oo2SxwlE8pf.QmMSKOXDy1q)))
			{
				stringBuilder.Append(" ");
				stringBuilder.Append(item.Plugin.PluginInfo.Name ?? "");
				if (!LxyC2yFWX6sxqaA2HGc2())
				{
					switch (0)
					{
					}
				}
				if (Math.Abs(item.Weight - 1.0) > 0.001)
				{
					stringBuilder.Append($"({item.Weight})");
				}
				if (!string.IsNullOrEmpty(item.Condition))
				{
					stringBuilder.Append("[" + item.Condition + "]");
				}
				stringBuilder.AppendLine();
			}
			stringBuilder.AppendLine();
			stringBuilder.AppendLine();
			goto IL_01de;
			IL_01de:
			stringBuilder.AppendLine("搜索动作");
			stringBuilder.AppendLine();
			stringBuilder.AppendLine(" “le:”：最后编辑的动作");
			stringBuilder.AppendLine(" “li:”：最后安装的动作");
			stringBuilder.AppendLine();
			stringBuilder.AppendLine();
			stringBuilder.AppendLine("快捷键");
			stringBuilder.AppendLine();
			stringBuilder.AppendLine("Alt + ←：向前一条搜索历史");
			stringBuilder.AppendLine("Alt + →：向后一条搜索历史");
			stringBuilder.AppendLine("Ctrl + TAB：切换显示的结果组");
			text = stringBuilder.ToString();
			stringBuilder = new StringBuilder(100);
			stringBuilder.AppendLine("功能");
			stringBuilder.AppendLine("");
			foreach (SearchPlugin item2 in gIh8AyjqAySmmxFMtv4.UOeterPKajP().OrderBy(_003C_003Ec.qlFSx2SyRXL ?? (_003C_003Ec.qlFSx2SyRXL = _003C_003Ec.Oo2SxwlE8pf.pj9SKF0VBep)))
			{
				SearchPluginSettings searchPluginSettings = gIh8AyjqAySmmxFMtv4.shatee0g8di(item2);
				if (!searchPluginSettings.IsEnabled || !searchPluginSettings.Triggers.HasData())
				{
					continue;
				}
				stringBuilder.Append(item2.PluginInfo.Name + ":");
				if (LxyC2yFWX6sxqaA2HGc2())
				{
					switch (0)
					{
					}
				}
				foreach (SearchTrigger trigger in searchPluginSettings.Triggers)
				{
					stringBuilder.Append(" " + trigger.TriggerWord.Replace(' ', '⎵') + " ");
				}
				stringBuilder.AppendLine();
			}
			text2 = stringBuilder.ToString();
			stringBuilder = new StringBuilder(100);
			stringBuilder.AppendLine("触发词");
			stringBuilder.AppendLine("");
			foreach (IGrouping<string, SearchPluginItem> item3 in gIh8AyjqAySmmxFMtv4.ncrteB8LyB5().Where(_003C_003Ec.HagSxuHYTAf ?? (_003C_003Ec.HagSxuHYTAf = _003C_003Ec.Oo2SxwlE8pf.OTZSKU4k3yo)).GroupBy(_003C_003Ec.JwASxNxpHHJ ?? (_003C_003Ec.JwASxNxpHHJ = _003C_003Ec.Oo2SxwlE8pf.bwxSKlZVQfd))
				.OrderBy(_003C_003Ec.OghSxJ9qBhb ?? (_003C_003Ec.OghSxJ9qBhb = _003C_003Ec.Oo2SxwlE8pf.UcgSKiK6jHt)))
			{
				stringBuilder.Append(item3.Key.Replace(' ', '⎵'));
				stringBuilder.Append("：");
				stringBuilder.AppendLine(string.Join(",", item3.OrderByDescending(_003C_003Ec.Uk7Sx04gJ7l ?? (_003C_003Ec.Uk7Sx04gJ7l = _003C_003Ec.Oo2SxwlE8pf.JcpSK31jgRd)).Select(_003C_003Ec.XZvSxCMaVNi ?? (_003C_003Ec.XZvSxCMaVNi = _003C_003Ec.Oo2SxwlE8pf.rNkSKfIUb9u))));
			}
			break;
			IL_0008:
			BeGgAjZ18FG();
			num2 = 0;
			if (!LxyC2yFWX6sxqaA2HGc2())
			{
				goto IL_002b;
			}
			goto IL_0072;
			IL_002b:
			switch (num2)
			{
			case 1:
				break;
			case 2:
				continue;
			case 4:
				goto IL_0072;
			case 3:
				goto IL_01de;
			default:
				goto end_IL_0059;
			}
			if (E0ygO3GNP64.IsVisible)
			{
				E0ygO3GNP64.Show();
				return;
			}
			goto IL_0008;
			continue;
			end_IL_0059:
			break;
		}
		string text3 = stringBuilder.ToString();
		E0ygO3GNP64 = new PowerKeyHintWindow(title, new string[3] { text, text2, text3 }, ShowWindowLocation.CenterScreen, true);
		E0ygO3GNP64.Owner = this;
		E0ygO3GNP64.ShowActivated = false;
		E0ygO3GNP64.Show();
	}

	private void BeGgAjZ18FG()
	{
		if (E0ygO3GNP64 != null)
		{
			E0ygO3GNP64.Close();
			E0ygO3GNP64 = null;
		}
	}

	private void tblgAntsRdM(object sender, System.Windows.Input.KeyEventArgs e)
	{
		BeGgAjZ18FG();
	}

	private void byFgA45CyKQ(object sender, System.Windows.Input.KeyEventArgs e)
	{
		if (e.Key == Key.Return)
		{
			QKQgAoWj65v();
			e.Handled = true;
			if (Nq8GNsFWpvk7Odp3OC3K == null)
			{
				switch (0)
				{
				}
			}
		}
		else if (e.Key == Key.System)
		{
			switch (e.SystemKey)
			{
			case Key.Return:
				QKQgAoWj65v();
				e.Handled = true;
				break;
			case Key.LeftAlt:
			case Key.RightAlt:
				e.Handled = true;
				break;
			}
		}
	}

	private void lMTgA5nRUqS(SearchResultItem searchResultItem_0, SearchTriggerType searchTriggerType_0)
	{
		Ib1gAD4ehAN();
		kbhgOnLyLpY.FA5MjViPItw(searchResultItem_0, TxtSearch.Text, searchTriggerType_0, this);
	}

	private void Ib1gAD4ehAN()
	{
		if (!string.IsNullOrWhiteSpace(TxtSearch.Text))
		{
			vq1gO11T3Ss.AddHistory(SelectedAction?.Id, TxtSearch.Text, 0);
		}
	}

	private void umGgAdpbFhN(SearchResultItem searchResultItem_0, bool bool_6)
	{
		System.Windows.Controls.ContextMenu contextMenu = kbhgOnLyLpY.wZJMjMr3ySd(searchResultItem_0);
		if (contextMenu != null)
		{
			contextMenu.PlacementTarget = this;
			if (contextMenu.Items.Count > 0)
			{
				LbResults.ContextMenu = contextMenu;
				contextMenu.IsOpen = true;
				if (bool_6)
				{
					B3GgAOQ3T5b(contextMenu);
				}
				contextMenu.Closed += wKUgOeMEIhk;
			}
			else
			{
				LbResults.ContextMenu = null;
			}
		}
		else
		{
			LbResults.ContextMenu = null;
			int num = 0;
			if (!LxyC2yFWX6sxqaA2HGc2())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
	}

	private void QKQgAoWj65v()
	{
		SearchResultItem searchResultItem_ = (LbResults.SelectedItem as bs268GWtdlAMtSyu6IQ)?.Result;
		lMTgA5nRUqS(searchResultItem_, SearchTriggerType.Enter);
	}

	private bool a9ygATI1SDZ()
	{
		string text = TxtSearch.Text.Trim();
		if (!string.IsNullOrEmpty(text) && AppState.HHxtaMaoqJr().QuickRunItems.HasData())
		{
			int num2 = default(int);
			foreach (QuickRunItem quickRunItem in AppState.HHxtaMaoqJr().QuickRunItems)
			{
				if (quickRunItem.IsDisabled || !(quickRunItem.CmdText == text))
				{
					continue;
				}
				(ActionItem, string) tuple = UZ7gOGXeXki.QHmtXwg81eY(quickRunItem.Data);
				if (tuple.Item1 != null)
				{
					int num = 0;
					if (Nq8GNsFWpvk7Odp3OC3K != null)
					{
						num = num2;
					}
					switch (num)
					{
					}
					XhBgAAcXG4Y(tuple.Item1);
					return true;
				}
			}
		}
		return false;
	}

	private bool ohTgAMAvuIn()
	{
		if (SelectedAction != null)
		{
			SelectedAction = null;
			tn0gA12P0JY();
			return true;
		}
		SearchResultItem searchResultItem;
		ActionItem actionItem;
		int num;
		if (LbResults.SelectedItem != null)
		{
			searchResultItem = (LbResults.SelectedItem as bs268GWtdlAMtSyu6IQ)?.Result;
			if (searchResultItem != null)
			{
				actionItem = searchResultItem.Tag as ActionItem;
				num = 0;
				if (!LxyC2yFWX6sxqaA2HGc2())
				{
					goto IL_00e9;
				}
				goto IL_00ed;
			}
			AppHelper.ShowInformation("仅支持选择动作。");
		}
		goto IL_0129;
		IL_00e9:
		int num2 = default(int);
		num = num2;
		goto IL_00ed;
		IL_0129:
		return false;
		IL_00ed:
		while (true)
		{
			string prevQueryText;
			switch (num)
			{
			default:
			{
				if (actionItem == null)
				{
					break;
				}
				Ib1gAD4ehAN();
				gIh8AyjqAySmmxFMtv4.tuPteKqOI5r(searchResultItem, ActiveProcessBeforeShow);
				XhBgAAcXG4Y(actionItem);
				SearchSettings searchSettings = AppState.HHxtaMaoqJr().SearchSettings;
				if (searchSettings != null && searchSettings.LoadPrevSearchText)
				{
					prevQueryText = vq1gO11T3Ss.GetPrevQueryText(actionItem?.Id, "");
					if (!string.IsNullOrEmpty(prevQueryText))
					{
						goto IL_00cf;
					}
				}
				goto IL_011b;
			}
			case 1:
				{
					TxtSearch.Select(0, TxtSearch.Text.Length);
					goto IL_011b;
				}
				IL_011b:
				return true;
			}
			break;
			IL_00cf:
			TxtSearch.Text = prevQueryText;
			num = 1;
			if (LxyC2yFWX6sxqaA2HGc2())
			{
				continue;
			}
			goto IL_00e9;
		}
		goto IL_0129;
	}

	private void XhBgAAcXG4Y(ActionItem actionItem_0)
	{
		if (actionItem_0 == null)
		{
			ActionPlaceholder = "";
			return;
		}
		cRngAKseB33();
		SelectedAction = actionItem_0;
		ActionAssociation association = actionItem_0.Association;
		object obj;
		if (association == null)
		{
			obj = null;
		}
		else
		{
			obj = association.SearchBoxPlaceholder;
			if (obj != null)
			{
				goto IL_0038;
			}
		}
		obj = "";
		goto IL_0038;
		IL_0038:
		ActionPlaceholder = (string)obj;
		HJ4gOH3pE5p.eootNqWdvcf();
		ActionItem selectedAction = SelectedAction;
		if (selectedAction == null)
		{
			return;
		}
		ActionAssociation association2 = selectedAction.Association;
		bool? flag2;
		bool? flag;
		if (association2 == null)
		{
			flag = null;
			int num = 0;
			if (Nq8GNsFWpvk7Odp3OC3K != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			flag2 = flag;
		}
		else
		{
			flag2 = association2.EnableRealtimeSearch;
		}
		flag = flag2;
		if (flag == true)
		{
			tn0gA12P0JY();
		}
	}

	private void B3GgAOQ3T5b(System.Windows.Controls.ContextMenu contextMenu_0)
	{
		contextMenu_0.PlacementTarget = LbResults.ItemContainerGenerator.ContainerFromIndex(LbResults.SelectedIndex) as UIElement;
		contextMenu_0.Placement = PlacementMode.Bottom;
		contextMenu_0.PlacementRectangle = new Rect(200.0, 10.0, 0.0, 0.0);
	}

	private void q6EgAFeHbtl(object sender, MouseButtonEventArgs e)
	{
		ns1gOjQkYta = true;
	}

	private void PqygAUmQsJ6(object sender, MouseButtonEventArgs e)
	{
        ListBoxItem listBoxItem = default;
		if (!ns1gOjQkYta)
		{
			return;
		}
		SearchResultItem searchResultItem = (LbResults.SelectedItem as bs268GWtdlAMtSyu6IQ)?.Result;
		int num = 1;
		if (!LxyC2yFWX6sxqaA2HGc2())
		{
			goto IL_0034;
		}
		goto IL_00ac;
		IL_0034:
		if (searchResultItem == null)
		{
			return;
		}
		listBoxItem = default(ListBoxItem);
		if (e.ChangedButton != MouseButton.Left)
		{
			if (e.ChangedButton == MouseButton.Middle)
			{
				DependencyObject dependencyObject = LbResults.ContainerFromElement((DependencyObject)e.OriginalSource);
				if (dependencyObject != null && dependencyObject is FrameworkElement frameworkElement)
				{
					listBoxItem = frameworkElement as ListBoxItem;
					if (listBoxItem == null)
					{
						listBoxItem = UIHelper.FindParent<ListBoxItem>(frameworkElement);
					}
					if (listBoxItem != null)
					{
						num = 0;
						if (!LxyC2yFWX6sxqaA2HGc2())
						{
							int num2 = default(int);
							num = num2;
						}
						goto IL_00ac;
					}
					return;
				}
				return;
			}
			if (e.ChangedButton == MouseButton.Right)
			{
				umGgAdpbFhN(searchResultItem, false);
			}
			return;
		}
		lMTgA5nRUqS(searchResultItem, SearchTriggerType.Mouse);
		return;
		IL_00ac:
		switch (num)
		{
		case 1:
			break;
		default:
		{
			SearchResultItem searchResultItem2 = (listBoxItem.Content as bs268GWtdlAMtSyu6IQ)?.Result;
			if (searchResultItem2 != null)
			{
				SetSkipNextDeactivate(true);
				lMTgA5nRUqS(searchResultItem2, SearchTriggerType.Mouse);
			}
			return;
		}
		}
		goto IL_0034;
	}

	private void TZbgAljdPp9()
	{
		CommandManager.AddPreviewCanExecuteHandler(TxtSearch, bLBgAiasn6K);
		CommandManager.AddPreviewExecutedHandler(TxtSearch, UrqgA3tAYkO);
	}

	private void bLBgAiasn6K(object sender, CanExecuteRoutedEventArgs e)
	{
		if (e.Command != ApplicationCommands.Paste)
		{
			return;
		}
		try
		{
			if (System.Windows.Clipboard.ContainsFileDropList())
			{
				e.CanExecute = true;
				e.Handled = true;
			}
		}
		catch (Exception)
		{
		}
	}

	private void UrqgA3tAYkO(object sender, ExecutedRoutedEventArgs e)
	{
		if (e.Command != ApplicationCommands.Paste)
		{
			return;
		}
		try
		{
			if (System.Windows.Clipboard.ContainsFileDropList())
			{
				StringCollection fileDropList = System.Windows.Clipboard.GetFileDropList();
				string[] array = new string[fileDropList.Count];
				fileDropList.CopyTo(array, 0);
				TxtSearch.Text = fileDropList[0];
				e.Handled = true;
			}
		}
		catch
		{
		}
	}

	private void O3bgAfnUgYl(object sender, DragDeltaEventArgs e)
	{
		FilterGrid.ColumnDefinitions[4].Width = new GridLength(0.0);
		double val = base.Width + e.HorizontalChange;
		base.Width = Math.Max(400.0, val);
		dDh7g7Xw7JyQPUTbYwJ.SearchWindowWidth = base.Width;
	}

	private void r2UgAz2p6Mo(object sender, MouseButtonEventArgs e)
	{
		if (e.ChangedButton == MouseButton.Left && JrJWiKYIEBcPm8FFZOl.Modifiers == ModifierKeys.Control)
		{
			Md6gAIvpxi8();
		}
	}

	private void IZZgOwbUgER(object sender, MouseButtonEventArgs e)
	{
		if (SelectedAction != null)
		{
			ActionItem selectedAction = SelectedAction;
			(ActionItem, ActionProfile) actionById = UZ7gOGXeXki.GetActionById(selectedAction.Id);
			System.Windows.Controls.ContextMenu contextMenu = new System.Windows.Controls.ContextMenu();
			AppState.lWutartRfUY().CreateContextMenuForActionButton(contextMenu, selectedAction, actionById.Item2, selectedAction.Row, selectedAction.Col, Window.GetWindow(this), ActionTrigger.SearchWindow);
			contextMenu.IsOpen = true;
		}
	}

	private void p4OgOtfo8kI(object sender, RoutedEventArgs e)
	{
		if (sender is System.Windows.Controls.MenuItem { Tag: string tag })
		{
			TxtSearch.Text = (string.IsNullOrEmpty(TxtSearch.Text) ? tag : (tag + TxtSearch.Text));
			TxtSearch.SetCartPosToEnd();
		}
	}

	private void HgcgOgDXNit(object sender, RoutedEventArgs e)
	{
		AppHelper.OpenReidrectLink(23, "搜索界面帮助");
	}

	private void TgvgOLltmuL(object sender, MouseButtonEventArgs e)
	{
		if (e.ChangedButton == MouseButton.Left || e.ChangedButton == MouseButton.Right)
		{
			FkIgFwGCJhC.GTntqnJGe6L();
			elhgOfX0JMi = sender;
			wIVgOzJtWYD = e.GetPosition(this);
		}
	}

	private void QTRgOvrH4N9(object sender, MouseButtonEventArgs e)
	{
	}

	private void nKvgOSMOBMi(object sender, System.Windows.Input.MouseEventArgs e)
	{
		int num = 3;
		while (true)
		{
			FrameworkElement frameworkElement = sender as FrameworkElement;
			int num2 = 2;
			if (!LxyC2yFWX6sxqaA2HGc2())
			{
				goto IL_0053;
			}
			goto IL_01b4;
			IL_01b4:
			while (true)
			{
				switch (num2)
				{
				case 2:
					break;
				case 1:
					goto IL_005c;
				default:
					return;
				case 3:
					goto end_IL_01b4;
				case 0:
					return;
				}
				if (frameworkElement == null)
				{
					return;
				}
				if (!frameworkElement.IsMouseCaptured || !FkIgFwGCJhC.KxCtqDqNIbU())
				{
					if (e.RightButton != MouseButtonState.Pressed)
					{
						if (e.LeftButton == MouseButtonState.Pressed)
						{
							num2 = 1;
							if (LxyC2yFWX6sxqaA2HGc2())
							{
								continue;
							}
							goto IL_0053;
						}
						return;
					}
					goto IL_005c;
				}
				FkIgFwGCJhC.ueNtq4hCqtu(this);
				return;
				IL_005c:
				if (elhgOfX0JMi != sender || FkIgFwGCJhC.KxCtqDqNIbU())
				{
					return;
				}
				System.Windows.Point position = e.GetPosition(this);
				if (wIVgOzJtWYD.X == 0.0 || wIVgOzJtWYD.Y == 0.0 || (!(Math.Abs(position.X - wIVgOzJtWYD.X) > SystemParameters.MinimumHorizontalDragDistance) && !(Math.Abs(position.Y - wIVgOzJtWYD.Y) > SystemParameters.MinimumVerticalDragDistance)) || !(frameworkElement?.Tag is SearchResultItem searchResultItem))
				{
					return;
				}
				if (searchResultItem is ActionSearchResultItem actionSearchResultItem)
				{
					if (actionSearchResultItem.Tag is ActionItem actionItem_)
					{
						FkIgFwGCJhC.S0utq5GWhlA(actionItem_, this, new System.Windows.Point(FMP9ONqzXcgZ6r3WmZZ.A4qHeQImJ6().ButtonSize / 2.0, FMP9ONqzXcgZ6r3WmZZ.A4qHeQImJ6().ButtonSize / 2.0), AppState.AppServer, AppState.Y2RtaqSv0AQ(), AppState.lWutartRfUY(), AppState.DataService, AppState.TKStaiOMyPb(), "NO_BIND");
						frameworkElement.CaptureMouse();
						num2 = 0;
						if (Nq8GNsFWpvk7Odp3OC3K != null)
						{
							return;
						}
						continue;
					}
					return;
				}
				string text = searchResultItem.TextData;
				if (kbhgOnLyLpY is iKTOkqWIMO3lqa4hFjM iKTOkqWIMO3lqa4hFjM)
				{
					text = iKTOkqWIMO3lqa4hFjM.UOotN6gXydc(searchResultItem);
				}
				try
				{
					if (!string.IsNullOrEmpty(text))
					{
						if (File.Exists(text))
						{
							AppHelper.BeginDragFile(this, text);
						}
						else
						{
							AppHelper.BeginDragText(this, text);
						}
					}
					return;
				}
				catch (Exception ex)
				{
					U6AgO6LYFnp.Warn("拖动文件出错：" + ex.Message, ex);
					AppHelper.ShowWarning("拖动文件出错：" + ex.Message);
					return;
				}
				continue;
				end_IL_01b4:
				break;
			}
			continue;
			IL_0053:
			num2 = num;
			goto IL_01b4;
		}
	}

	private void pJ3gO2LHSlT(object sender, MouseButtonEventArgs e)
	{
	}

	private void mg2gOuh6fYo(object sender, MouseButtonEventArgs e)
	{
		try
		{
			if (sender is FrameworkElement frameworkElement && FkIgFwGCJhC.KxCtqDqNIbU())
			{
				FkIgFwGCJhC.GTntqnJGe6L();
				e.Handled = true;
				frameworkElement.ReleaseMouseCapture();
			}
		}
		finally
		{
			wIVgOzJtWYD = new System.Windows.Point(0.0, 0.0);
		}
	}

	private void LFPgONVHA0f(object sender, SelectionChangedEventArgs e)
	{
		if (LbResults.SelectedItems.Count == 0)
		{
			LbResults.SelectedIndex = ckDgFtVXpU8;
		}
		else
		{
			ckDgFtVXpU8 = LbResults.SelectedIndex;
		}
	}

	private void hnggOJI4JDc(object sender, RoutedEventArgs e)
	{
		AppHelper.ShowWarning("按钮点击了。");
	}

	private void L3wgO0QePhO(object sender, SelectionChangedEventArgs e)
	{
		HJ4gOH3pE5p.gS0tN7rS4T5((LbResultGroups.SelectedItem as ResultGroupItem)?.PluginItem);
		TxtSearch.Focus();
	}

	private void IDUgOC2ggM9(object sender, RoutedEventArgs e)
	{
		IsPinned = !IsPinned;
	}

	public void AfterActionSelected()
	{
		if (ShouldSkipNextDeactivate() || IsPinned)
		{
			PfXgAbDyt2t();
			return;
		}
		ClearResults();
		RequestHide();
	}

	private void omygOPwa4av(object sender, ContextMenuEventArgs e)
	{
		if (MenuInputKeywords.Items.Count == 0)
		{
			iRdgOES93Ri();
		}
	}

	private void iRdgOES93Ri()
	{
		System.Windows.Controls.MenuItem menuInputKeywords = MenuInputKeywords;
		int num2 = default(int);
		dZSAja2f6LA1pH5RUmY dZSAja2f6LA1pH5RUmY = default(dZSAja2f6LA1pH5RUmY);
		int num4 = default(int);
		foreach (SearchPlugin item in gIh8AyjqAySmmxFMtv4.UOeterPKajP().OrderBy(_003C_003Ec.t5ASxPd5qTq ?? (_003C_003Ec.t5ASxPd5qTq = _003C_003Ec.Oo2SxwlE8pf.AIXSKzN7PjR)))
		{
			SearchPluginSettings searchPluginSettings = gIh8AyjqAySmmxFMtv4.shatee0g8di(item);
			if (!searchPluginSettings.IsEnabled || !searchPluginSettings.Triggers.HasData())
			{
				continue;
			}
			int num = 0;
			if (!LxyC2yFWX6sxqaA2HGc2())
			{
				num = num2;
			}
			while (true)
			{
				switch (num)
				{
				default:
				{
					dZSAja2f6LA1pH5RUmY = item as dZSAja2f6LA1pH5RUmY;
					if (dZSAja2f6LA1pH5RUmY != null)
					{
						num = 1;
						if (LxyC2yFWX6sxqaA2HGc2())
						{
							continue;
						}
						goto case 1;
					}
					System.Windows.Controls.MenuItem menuItem;
					if (searchPluginSettings.Triggers.Count == 1)
					{
						SearchTrigger searchTrigger = searchPluginSettings.Triggers[0];
						menuItem = AppHelper.AddMenuItem(menuInputKeywords.Items, item.PluginInfo.Name + "   " + searchTrigger.TriggerWord.Replace(" ", "⎵"), "", item.PluginInfo.Icon, p4OgOtfo8kI);
						menuItem.Tag = searchTrigger.TriggerWord;
						break;
					}
					menuItem = AppHelper.AddMenuItem(menuInputKeywords.Items, item.PluginInfo.Name, "", item.PluginInfo.Icon, null);
					foreach (SearchTrigger trigger in searchPluginSettings.Triggers)
					{
						AppHelper.AddMenuItem(menuItem.Items, trigger.TriggerWord.Replace(" ", "⎵") + "    (" + trigger.Condition + ")", "", "", p4OgOtfo8kI).Tag = trigger.TriggerWord;
					}
					break;
				}
				case 1:
				{
					System.Windows.Controls.MenuItem menuItem = AppHelper.AddMenuItem(menuInputKeywords.Items, item.PluginInfo.Name, "", item.PluginInfo.Icon, null);
					foreach (SearchTrigger trigger2 in searchPluginSettings.Triggers)
					{
						AppHelper.AddMenuItem(menuItem.Items, trigger2.TriggerWord.Replace(" ", "⎵") + "   " + trigger2.Condition, "", "", p4OgOtfo8kI).Tag = trigger2.TriggerWord;
					}
					AppHelper.AddMenuSeparator(menuItem.Items);
					foreach (WebSearchEngine item2 in dZSAja2f6LA1pH5RUmY.j3GtJO2tWRB())
					{
						System.Windows.Controls.MenuItem menuItem2 = AppHelper.AddMenuItem(menuItem.Items, item2.TriggerWords.Replace(" ", "⎵") + "   " + item2.Name, "", "", p4OgOtfo8kI);
						if (searchPluginSettings.IncludeInGlobalSearch)
						{
							int num3 = 0;
							if (!LxyC2yFWX6sxqaA2HGc2())
							{
								num3 = num4;
							}
							switch (num3)
							{
							}
							menuItem2.Tag = item2.TriggerWords + " ";
						}
						else if (searchPluginSettings.Triggers.Count > 0)
						{
							menuItem2.Tag = searchPluginSettings.Triggers[0]?.ToString() + item2.TriggerWords + " ";
						}
					}
					break;
				}
				}
				break;
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!A2ugFvR4KGB)
		{
			A2ugFvR4KGB = true;
			Uri resourceLocator = new Uri("/Quicker;component/modules/searching/ui/searchwindow.xaml", UriKind.Relative);
			System.Windows.Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num;
		int num2 = default(int);
		switch (connectionId)
		{
		default:
			A2ugFvR4KGB = true;
			break;
		case 1:
			TheWindow = (SearchWindow)target;
			break;
		case 2:
			LbResultGroups = (System.Windows.Controls.ListBox)target;
			LbResultGroups.SelectionChanged += L3wgO0QePhO;
			break;
		case 3:
			VYkgFgSS3FI = (DropShadowEffect)target;
			break;
		case 4:
			t6xgFL28clQ = (DropShadowEffect)target;
			break;
		case 5:
			((Border)target).PreviewMouseDown += r2UgAz2p6Mo;
			num = 2;
			if (Nq8GNsFWpvk7Odp3OC3K != null)
			{
				goto IL_019c;
			}
			goto IL_0209;
		case 6:
			FilterGrid = (Grid)target;
			break;
		case 7:
			((Border)target).MouseMove += gnEgAYeJiNK;
			break;
		case 8:
			PnlSelectedAction = (StackPanel)target;
			PnlSelectedAction.MouseMove += gnEgAYeJiNK;
			PnlSelectedAction.PreviewMouseRightButtonUp += IZZgOwbUgER;
			break;
		case 9:
			SelectedActionIcon = (IconControl)target;
			break;
		case 10:
			SelectedActionLabel = (TextBlock)target;
			break;
		case 11:
			TxtSearch = (System.Windows.Controls.TextBox)target;
			TxtSearch.ContextMenuOpening += omygOPwa4av;
			TxtSearch.KeyDown += byFgA45CyKQ;
			num = 0;
			if (!LxyC2yFWX6sxqaA2HGc2())
			{
				goto IL_019c;
			}
			goto IL_0209;
		case 12:
			((System.Windows.Controls.MenuItem)target).Click += p4OgOtfo8kI;
			break;
		case 13:
			((System.Windows.Controls.MenuItem)target).Click += p4OgOtfo8kI;
			break;
		case 14:
			MenuInputKeywords = (System.Windows.Controls.MenuItem)target;
			break;
		case 15:
			((System.Windows.Controls.MenuItem)target).Click += F6CgAktNvQ1;
			num = 0;
			if (Nq8GNsFWpvk7Odp3OC3K == null)
			{
				break;
			}
			goto IL_0209;
		case 16:
			MenuResetLocation = (System.Windows.Controls.MenuItem)target;
			MenuResetLocation.Click += cyEgAW57aty;
			break;
		case 17:
			MenuHelp = (System.Windows.Controls.MenuItem)target;
			MenuHelp.Click += HgcgOgDXNit;
			break;
		case 18:
			Splitter = (GridSplitter)target;
			Splitter.DragDelta += O3bgAfnUgYl;
			break;
		case 19:
			BtnPin = (System.Windows.Controls.Button)target;
			BtnPin.Click += IDUgOC2ggM9;
			break;
		case 20:
			IconPin = (SvgAwesome)target;
			break;
		case 21:
			{
				LbResults = (System.Windows.Controls.ListBox)target;
				LbResults.MouseUp += PqygAUmQsJ6;
				LbResults.PreviewMouseDown += q6EgAFeHbtl;
				LbResults.SelectionChanged += LFPgONVHA0f;
				break;
			}
			IL_019c:
			num = num2;
			goto IL_0209;
			IL_0209:
			switch (num)
			{
			default:
				TxtSearch.PreviewKeyDown += TxtSearch_OnPreviewKeyDown;
				TxtSearch.PreviewKeyUp += tblgAntsRdM;
				TxtSearch.TextChanged += vlDgA6eQBB7;
				break;
			case 1:
				break;
			case 2:
				break;
			case 3:
				break;
			}
			break;
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 22)
		{
			((Border)target).PreviewMouseDown += TgvgOLltmuL;
			((Border)target).PreviewMouseMove += nKvgOSMOBMi;
			((Border)target).PreviewMouseRightButtonDown += QTRgOvrH4N9;
			((Border)target).PreviewMouseRightButtonUp += pJ3gO2LHSlT;
			((Border)target).PreviewMouseUp += mg2gOuh6fYo;
		}
	}

	static SearchWindow()
	{
		U6AgO6LYFnp = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		SelectedActionProperty = DependencyProperty.Register("SelectedAction", typeof(ActionItem), typeof(SearchWindow), new PropertyMetadata(null, uRtgA8rALu9));
		ActionPlaceholderProperty = DependencyProperty.Register("ActionPlaceholder", typeof(string), typeof(SearchWindow), new PropertyMetadata((object)null));
	}

	[CompilerGenerated]
	private void FCNgOyNXAfN()
	{
		if (PubgOIxgneL())
		{
			base.Opacity = 1.0;
			return;
		}
		GRRgObs1r28.Clear();
		Hide();
		BeGgAjZ18FG();
	}

	[CompilerGenerated]
	private void OodgO8O6KN0()
	{
		HJ4gOH3pE5p.eootNqWdvcf();
	}

	[CompilerGenerated]
	private void UlkgOaUvMMw(object object_1)
	{
		tn0gA12P0JY();
	}

	[CompilerGenerated]
	private void bRngO7eAkpQ(object object_1)
	{
		tn0gA12P0JY();
	}

	[CompilerGenerated]
	private void yfMgORo0TuF()
	{
		if (LbResults.SelectedIndex < LbResults.Items.Count - 1)
		{
			LbResults.SelectedIndex++;
		}
		else
		{
			LbResults.SelectedIndex = ((LbResults.Items.Count <= 0) ? (-1) : 0);
		}
		JAigOhnPbnN();
	}

	[CompilerGenerated]
	private void WRKgOqcRRaE()
	{
		if (LbResults.SelectedIndex > 0)
		{
			LbResults.SelectedIndex--;
		}
		else if (LbResults.SelectedIndex == 0)
		{
			LbResults.SelectedIndex = LbResults.Items.Count - 1;
		}
		JAigOhnPbnN();
	}

	[CompilerGenerated]
	private void cmVgOcuI36P()
	{
		int val = LbResults.Items.Count - LbResults.SelectedIndex - 1;
		int num = Math.Min(7, val);
		if (num > 0)
		{
			LbResults.SelectedIndex += num;
			JAigOhnPbnN();
		}
	}

	[CompilerGenerated]
	private void YnEgOVLfZ05()
	{
		int selectedIndex = LbResults.SelectedIndex;
		int num = Math.Min(7, selectedIndex);
		if (num > 0)
		{
			LbResults.SelectedIndex -= num;
			JAigOhnPbnN();
		}
	}

	[CompilerGenerated]
	private void m1NgOZscO7h()
	{
		if (HJ4gOH3pE5p.Count > 0)
		{
			LbResults.SelectedIndex = 0;
			JAigOhnPbnN();
		}
	}

	[CompilerGenerated]
	private void IUSgO9MEArv()
	{
		if (HJ4gOH3pE5p.Count > 0)
		{
			LbResults.SelectedIndex = LbResults.Items.Count - 1;
			JAigOhnPbnN();
		}
	}

	[CompilerGenerated]
	private void JAigOhnPbnN()
	{
		if (LbResults.SelectedIndex >= 0)
		{
			LbResults.ScrollIntoView(LbResults.SelectedItem);
		}
	}

	[CompilerGenerated]
	private void wKUgOeMEIhk(object sender, RoutedEventArgs e)
	{
		LbResults.ContextMenu = null;
	}

	internal static bool LxyC2yFWX6sxqaA2HGc2()
	{
		return Nq8GNsFWpvk7Odp3OC3K == null;
	}
}
