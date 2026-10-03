using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Threading;
using GuvA3OiyFyyWpKJlb8c;
using HandyControl.Controls;
using IOn6RhAJdTUbfGy6gwn;
using Quicker.Domain;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Pinyin;
using Quicker.Utilities.UI;
using Quicker.Utilities.UI.Wpf;
using Quicker.Utilities.Win32;
using Quicker.View.Controls;
using rlluYPmoa97LQl8MR84;
using ViNASxihuuLY1Gg9m6p;
using wlFuCLYjBIXKFesp7Vo;

namespace Quicker.View;

public class SelectOperationWindow : HandyControl.Controls.Window, IComponentConnector, IStyleConnector, iTHRNJY2ZQQokysD4pN, IMockModalWindow
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec E55SrXesDR6;

		public static Func<_003C_003Ef__AnonymousType57<IMatchResult, IMatchResult, SimpleOperationItem>, bool> kd5Srmby8VY;

		public static Func<_003C_003Ef__AnonymousType57<IMatchResult, IMatchResult, SimpleOperationItem>, int> boESrKJ9MZD;

		public static Func<_003C_003Ef__AnonymousType57<IMatchResult, IMatchResult, SimpleOperationItem>, SimpleOperationItem> QFkSrxgqxZZ;

		public static Func<_003C_003Ef__AnonymousType58<IMatchResult, SimpleOperationItem>, bool> vptSrrPZ70t;

		public static Func<_003C_003Ef__AnonymousType58<IMatchResult, SimpleOperationItem>, int> RBcSrp8kKIs;

		public static Func<_003C_003Ef__AnonymousType58<IMatchResult, SimpleOperationItem>, SimpleOperationItem> mcCSrBKPanQ;

		internal static _003C_003Ec a0eHYCWP92nZ1VBh8ZxY;

		static _003C_003Ec()
		{
			E55SrXesDR6 = new _003C_003Ec();
		}

		internal bool b9KSrGgh0n5(_003C_003Ef__AnonymousType57<IMatchResult, IMatchResult, SimpleOperationItem> x)
		{
			if (x.matchResult != null && x.matchResult.IsMatch)
			{
				return true;
			}
			if (x.matchResultDesc != null)
			{
				return x.matchResultDesc.IsMatch;
			}
			return false;
		}

		internal int TJXSrs0ejPc(_003C_003Ef__AnonymousType57<IMatchResult, IMatchResult, SimpleOperationItem> x)
		{
			return (x.matchResult?.Score ?? 0) + (x.matchResultDesc?.Score ?? 0);
		}

		internal SimpleOperationItem l73SrHmVvbX(_003C_003Ef__AnonymousType57<IMatchResult, IMatchResult, SimpleOperationItem> x)
		{
			x.item.MatchPositions = x.matchResult?.GetMatchPositions();
			return x.item;
		}

		internal bool ERiSr1crkUb(_003C_003Ef__AnonymousType58<IMatchResult, SimpleOperationItem> x)
		{
			if (x.matchResult != null)
			{
				return x.matchResult.IsMatch;
			}
			return false;
		}

		internal int BGxSrbTWNnb(_003C_003Ef__AnonymousType58<IMatchResult, SimpleOperationItem> x)
		{
			return x.matchResult.Score;
		}

		internal SimpleOperationItem r3USr6VmljY(_003C_003Ef__AnonymousType58<IMatchResult, SimpleOperationItem> x)
		{
			x.item.MatchPositions = x.matchResult.GetMatchPositions();
			return x.item;
		}

		internal static bool dOGUYxWPLQIjrwRKAyXl()
		{
			return a0eHYCWP92nZ1VBh8ZxY == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass102_0
	{
		public char euASrjOLQOy;

		public SelectOperationWindow FyrSrn5Wjhn;

		internal static _003C_003Ec__DisplayClass102_0 TQQ0slWPoXMe6J417cvp;

		internal void SiTSrQeSQFh()
		{
			FyrSrn5Wjhn.SmEg3KXkdBu(euASrjOLQOy.ToString() ?? "");
		}

		internal static bool L8hV31WPf6VxGEBmevLc()
		{
			return TQQ0slWPoXMe6J417cvp == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass102_1
	{
		public char OVsSr5kgyex;

		public SelectOperationWindow PK7SrDNP9Lm;

		internal static _003C_003Ec__DisplayClass102_1 AaptZcWPqwHg2e8uSFtd;

		internal void HaASr4pHf3P()
		{
			PK7SrDNP9Lm.SmEg3KXkdBu(OVsSr5kgyex.ToString() ?? "");
		}

		internal static bool nrib9hWPiFWVJX7mVT98()
		{
			return AaptZcWPqwHg2e8uSFtd == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass123_0
	{
		public string[] rmtSrotQDO8;

		internal static _003C_003Ec__DisplayClass123_0 Cbjbd1WPZNLLVsxNdUlF;

		internal _003C_003Ef__AnonymousType57<IMatchResult, IMatchResult, SimpleOperationItem> Ko8Srd3jTmc(SimpleOperationItem x)
		{
			return new _003C_003Ef__AnonymousType57<IMatchResult, IMatchResult, SimpleOperationItem>(JgbqhZmXYZ38IYyT8kD.uLlv0e2kYKg(x.Name, rmtSrotQDO8), x.Description.IsNullOrEmpty() ? null : JgbqhZmXYZ38IYyT8kD.uLlv0e2kYKg(x.Description, rmtSrotQDO8), x);
		}

		internal static bool frPqKJWP5Z7PxQCCSkIV()
		{
			return Cbjbd1WPZNLLVsxNdUlF == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass123_1
	{
		public string[] AhmSrMHBjw1;

		internal static _003C_003Ec__DisplayClass123_1 SQZ4EhWP81k6q0sQmN0K;

		internal _003C_003Ef__AnonymousType58<IMatchResult, SimpleOperationItem> lvFSrTKC5bL(SimpleOperationItem x)
		{
			return new _003C_003Ef__AnonymousType58<IMatchResult, SimpleOperationItem>(tkxn6HAKAgMT8gvXbyh.xNFi37iHdP(AhmSrMHBjw1, x.Name, x.Key, x.Description), x);
		}

		internal static bool j2J57sWPRm70Sb6LbWjy()
		{
			return SQZ4EhWP81k6q0sQmN0K == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass91_0
	{
		public string w4kSrOF7CW6;

		private static _003C_003Ec__DisplayClass91_0 mKSDj4WPP7kDIUDQW7lV;

		internal bool P87SrAOb0u5(SimpleOperationItem x)
		{
			return x.Key.Equals(w4kSrOF7CW6);
		}

		internal static bool JUn1xPWPMuXGP7s9pu48()
		{
			return mKSDj4WPP7kDIUDQW7lV == null;
		}
	}

	private readonly SmartCollection<SimpleOperationItem> cn9g3ibvTNd;

	private SmartCollection<SimpleOperationItem> YqZg332s4K7 = new SmartCollection<SimpleOperationItem>();

	private readonly bool dN5g3f6dZes;

	public static readonly DependencyProperty IndexColumnWidthProperty;

	public static readonly DependencyProperty ListIconSizeProperty;

	[CompilerGenerated]
	private string IK0g3z0pC8m;

	[CompilerGenerated]
	private string aONgfwlo5qo;

	[CompilerGenerated]
	private string wVlgft1c17G;

	[CompilerGenerated]
	private IList<string> n3igfgMiSKb;

	[CompilerGenerated]
	private bool wybgfLxKuvq;

	[CompilerGenerated]
	private ShowWindowLocation N6Ggfvf5wt5;

	[CompilerGenerated]
	private string VPwgfSkZiA8;

	[CompilerGenerated]
	private bool YUmgf2WvKqZ;

	[CompilerGenerated]
	private string siZgfuYcDfP;

	[CompilerGenerated]
	private double YURgfNx6Qda;

	[CompilerGenerated]
	private bool JuJgfJRAILB;

	[CompilerGenerated]
	private bool B5Rgf08iW9Z;

	[CompilerGenerated]
	private IntPtr e8rgfCXEjWB;

	[CompilerGenerated]
	private double W8ygfPcpLNJ = 12.0;

	[CompilerGenerated]
	private bool iEDgfE8qXe5;

	private readonly RoutedCommand kB9gfyEH5N9 = new RoutedCommand("Search", typeof(SelectOperationWindow));

	[CompilerGenerated]
	private IList<SimpleOperationItem> LhAgf8Vqv4Y;

	private DateTime? WGtgfa0hN5E;

	private DispatcherTimer FVfgf7ZpheC;

	private DebounceDispatcher ds7gfR2nRsj;

	[CompilerGenerated]
	private bool? XbFgfqtBKGd;

	[CompilerGenerated]
	private bool XbJgfc8QL3G;

	[CompilerGenerated]
	private CancellationTokenRegistration? VTJgfVMr65S;

	internal SelectOperationWindow SelectWindow;

	internal Grid GridFilter;

	internal System.Windows.Controls.TextBox TxtFilter;

	internal System.Windows.Controls.Button BtnClearFilter;

	internal System.Windows.Controls.ListBox LbOperations;

	internal TextBlock LblSelectedCount;

	internal TextBlock LblNote;

	internal System.Windows.Controls.Button BtnSelectAll;

	internal System.Windows.Controls.MenuItem MenuInvertSelection;

	internal MarkdownHintButton HintButton;

	internal DropDownButton BtnMenu;

	internal System.Windows.Controls.Button BtnOk;

	internal System.Windows.Controls.Button BtnCancel;

	internal System.Windows.Controls.ProgressBar ProgressBarAutoClose;

	private bool lb0gfZcGpK4;

	internal static SelectOperationWindow TfgWdSFpkwfoECN1FTqj;

	public SimpleOperationItem SelectedItem => LbOperations.SelectedItem as SimpleOperationItem;

	public int SelectedIndex
	{
		get
		{
			if (SelectedItem != null)
			{
				return SelectedItem.ItemIndex;
			}
			return -1;
		}
	}

	public GridLength IndexColumnWidth
	{
		get
		{
			return (GridLength)GetValue(IndexColumnWidthProperty);
		}
		set
		{
			SetValue(IndexColumnWidthProperty, value);
		}
	}

	public double ListIconSize
	{
		get
		{
			return (double)GetValue(ListIconSizeProperty);
		}
		set
		{
			SetValue(ListIconSizeProperty, value);
		}
	}

	public string WindowKey
	{
		[CompilerGenerated]
		get
		{
			return IK0g3z0pC8m;
		}
		[CompilerGenerated]
		set
		{
			IK0g3z0pC8m = value;
		}
	}

	public string ImeState
	{
		[CompilerGenerated]
		get
		{
			return aONgfwlo5qo;
		}
		[CompilerGenerated]
		set
		{
			aONgfwlo5qo = value;
		}
	}

	public string PreSelectedKey
	{
		[CompilerGenerated]
		get
		{
			return wVlgft1c17G;
		}
		[CompilerGenerated]
		set
		{
			wVlgft1c17G = value;
		}
	}

	public IList<string> PreSelectedItems
	{
		[CompilerGenerated]
		get
		{
			return n3igfgMiSKb;
		}
		[CompilerGenerated]
		set
		{
			n3igfgMiSKb = value;
		}
	}

	public bool IsMultiSelect
	{
		[CompilerGenerated]
		get
		{
			return wybgfLxKuvq;
		}
		[CompilerGenerated]
		set
		{
			wybgfLxKuvq = value;
		}
	}

	public ShowWindowLocation Location
	{
		[CompilerGenerated]
		get
		{
			return N6Ggfvf5wt5;
		}
		[CompilerGenerated]
		set
		{
			N6Ggfvf5wt5 = value;
		}
	}

	public string SelectedOperation
	{
		[CompilerGenerated]
		get
		{
			return VPwgfSkZiA8;
		}
		[CompilerGenerated]
		set
		{
			VPwgfSkZiA8 = value;
		}
	}

	public bool UseKeyboard
	{
		[CompilerGenerated]
		get
		{
			return YUmgf2WvKqZ;
		}
		[CompilerGenerated]
		set
		{
			YUmgf2WvKqZ = value;
		}
	}

	public string Note
	{
		set
		{
			LblNote.Text = (string.IsNullOrEmpty(value) ? "" : value.Replace("\\n", "\n"));
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

	public string MaxWindowSize
	{
		[CompilerGenerated]
		get
		{
			return siZgfuYcDfP;
		}
		[CompilerGenerated]
		set
		{
			siZgfuYcDfP = value;
		}
	}

	public double AutoCloseSeconds
	{
		[CompilerGenerated]
		get
		{
			return YURgfNx6Qda;
		}
		[CompilerGenerated]
		set
		{
			YURgfNx6Qda = value;
		}
	}

	public bool CloseOnDeactivated
	{
		[CompilerGenerated]
		get
		{
			return JuJgfJRAILB;
		}
		[CompilerGenerated]
		set
		{
			JuJgfJRAILB = value;
		}
	}

	public bool AllowOkWhenEmpty
	{
		[CompilerGenerated]
		get
		{
			return B5Rgf08iW9Z;
		}
		[CompilerGenerated]
		set
		{
			B5Rgf08iW9Z = value;
		}
	}

	public IntPtr Hwnd
	{
		[CompilerGenerated]
		get
		{
			return e8rgfCXEjWB;
		}
		[CompilerGenerated]
		set
		{
			e8rgfCXEjWB = value;
		}
	}

	public double ListFontSize
	{
		[CompilerGenerated]
		get
		{
			return W8ygfPcpLNJ;
		}
		[CompilerGenerated]
		set
		{
			W8ygfPcpLNJ = value;
		}
	}

	public bool HasPresetSize
	{
		[CompilerGenerated]
		get
		{
			return iEDgfE8qXe5;
		}
		[CompilerGenerated]
		set
		{
			iEDgfE8qXe5 = value;
		}
	}

	public IList<SimpleOperationItem> ExtraOperations
	{
		[CompilerGenerated]
		get
		{
			return LhAgf8Vqv4Y;
		}
		[CompilerGenerated]
		set
		{
			LhAgf8Vqv4Y = value;
		}
	}

	public string FilterContent
	{
		get
		{
			return TxtFilter.Text;
		}
		set
		{
			TxtFilter.Text = value;
		}
	}

	public bool? Result
	{
		[CompilerGenerated]
		get
		{
			return XbFgfqtBKGd;
		}
		[CompilerGenerated]
		set
		{
			XbFgfqtBKGd = value;
		}
	}

	public bool EnableQuickConfirm
	{
		[CompilerGenerated]
		get
		{
			return XbJgfc8QL3G;
		}
		[CompilerGenerated]
		set
		{
			XbJgfc8QL3G = value;
		}
	}

	public CancellationTokenRegistration? CancellationTokenRegistration
	{
		[CompilerGenerated]
		get
		{
			return VTJgfVMr65S;
		}
		[CompilerGenerated]
		set
		{
			VTJgfVMr65S = value;
		}
	}

	public IList<SimpleOperationItem> GetSelectedItems()
	{
		List<SimpleOperationItem> list = new List<SimpleOperationItem>();
		foreach (SimpleOperationItem item in cn9g3ibvTNd)
		{
			if (LbOperations.SelectedItems.Contains(item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public SelectOperationWindow(IList<SimpleOperationItem> operations, ShowWindowLocation location = ShowWindowLocation.WithMouse1, bool useKeyboard = true, bool isMultiSelect = false, bool showFilter = false, double fontSize = 0.0)
	{
		cn9g3ibvTNd = new SmartCollection<SimpleOperationItem>(operations);
		for (int i = 0; i < operations.Count; i++)
		{
			operations[i].ItemIndex = i;
		}
		if (fontSize > 3.0)
		{
			ListFontSize = fontSize;
		}
		tbWg3ZDoKAv();
		dN5g3f6dZes = showFilter;
		Location = location;
		UseKeyboard = useKeyboard;
		IsMultiSelect = isMultiSelect;
		InitializeComponent();
		LbOperations.FontSize = ListFontSize;
		if (isMultiSelect)
		{
			LbOperations.SelectionMode = System.Windows.Controls.SelectionMode.Multiple;
		}
		else
		{
			LbOperations.SelectionMode = System.Windows.Controls.SelectionMode.Single;
			LblSelectedCount.Visibility = Visibility.Collapsed;
		}
		base.Loaded += S8Ag38TYB9y;
		base.SourceInitialized += LqHg3y81AHN;
		base.Unloaded += OKMg3EHSPqx;
		if (UseKeyboard)
		{
			cn9g3ibvTNd.Count();
		}
		base.PreviewKeyDown += e1Og3e8CpCf;
		base.Deactivated += S7Ag391V6F8;
		Kgeg3c0JJRl();
		GridFilter.Visibility = ((!showFilter) ? Visibility.Collapsed : Visibility.Visible);
		AppHelper.AddGoToPageCommandBinding(this);
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void OKMg3EHSPqx(object sender, RoutedEventArgs e)
	{
		if (IsMultiSelect)
		{
			LbOperations.SetValue(ListBoxSelector.EnabledProperty, false);
		}
	}

	private void LqHg3y81AHN(object sender, EventArgs e)
	{
		if (!UseKeyboard)
		{
			NativeMethods.SetWindowNoActivate(this);
		}
		gj4g3BrhMNh();
		LbOperations.ItemsSource = YqZg332s4K7;
		BtnSelectAll.Visibility = ((!IsMultiSelect) ? Visibility.Collapsed : Visibility.Visible);
		int result2 = default(int);
		if (IsMultiSelect)
		{
			if (PreSelectedItems != null && PreSelectedItems.Count > 0)
			{
				if (PreSelectedItems[0].Equals("//byIndex", StringComparison.OrdinalIgnoreCase))
				{
					int num2 = default(int);
					for (int i = 1; i < PreSelectedItems.Count; i++)
					{
						if (int.TryParse(PreSelectedItems[i], out var result) && result < cn9g3ibvTNd.Count)
						{
							int num = 1;
							if (!LZJMyiFpaTGRVrCnwyKh())
							{
								num = num2;
							}
							switch (num)
							{
							case 1:
								break;
							default:
								goto IL_01b1;
							case 2:
								goto IL_01ce;
							}
							LbOperations.SelectedItems.Add(cn9g3ibvTNd[result]);
						}
					}
				}
				else
				{
					using IEnumerator<string> enumerator = PreSelectedItems.GetEnumerator();
					while (enumerator.MoveNext())
					{
						_003C_003Ec__DisplayClass91_0 _003C_003Ec__DisplayClass91_ = new _003C_003Ec__DisplayClass91_0();
						_003C_003Ec__DisplayClass91_.w4kSrOF7CW6 = enumerator.Current;
						SimpleOperationItem simpleOperationItem = cn9g3ibvTNd.FirstOrDefault(_003C_003Ec__DisplayClass91_.P87SrAOb0u5);
						if (simpleOperationItem != null)
						{
							LbOperations.SelectedItems.Add(simpleOperationItem);
						}
					}
				}
			}
		}
		else
		{
			SimpleOperationItem simpleOperationItem2 = cn9g3ibvTNd.FirstOrDefault(xhqg3Dx7lco);
			if (simpleOperationItem2 != null)
			{
				LbOperations.SelectedItem = simpleOperationItem2;
			}
			else
			{
				if (string.IsNullOrEmpty(PreSelectedKey))
				{
					goto IL_01b1;
				}
				if (int.TryParse(PreSelectedKey, out result2))
				{
					goto IL_01ce;
				}
			}
		}
		goto IL_01ef;
		IL_01b1:
		LbOperations.SelectedItem = null;
		goto IL_01ef;
		IL_01ce:
		if (result2 < LbOperations.Items.Count)
		{
			LbOperations.SelectedIndex = result2;
		}
		goto IL_01ef;
		IL_01ef:
		if (LbOperations.SelectedItems.Count > 0)
		{
			LbOperations.ScrollIntoView(LbOperations.SelectedItems[0]);
		}
		JL9g3RkWbyg();
	}

	private void S8Ag38TYB9y(object sender, RoutedEventArgs e)
	{
		AppImeHelper.SetImeState(TxtFilter, ImeState);
		if (IsMultiSelect)
		{
			LbOperations.SetValue(ListBoxSelector.EnabledProperty, true);
		}
		base.Dispatcher.InvokeAsync(HQxg3d6F06e);
		int num = 2;
		if (TfgWdSFpkwfoECN1FTqj != null)
		{
			goto IL_02c8;
		}
		goto IL_02c9;
		IL_02c9:
		System.Windows.Controls.ContextMenu contextMenu2 = default(System.Windows.Controls.ContextMenu);
		do
		{
			System.Windows.Controls.ContextMenu contextMenu;
			switch (num)
			{
			case 2:
				if (AutoCloseSeconds > 0.5)
				{
					WGtgfa0hN5E = DateTime.Now.AddSeconds(AutoCloseSeconds);
					FVfgf7ZpheC = new DispatcherTimer
					{
						Interval = new TimeSpan(0, 0, 0, 0, 100)
					};
					FVfgf7ZpheC.Tick += dwZg3kZXIk7;
					FVfgf7ZpheC.Start();
					base.PreviewMouseDown += W2jg3oj5uC4;
					base.PreviewKeyDown += M5yg3TmIvCI;
					ProgressBarAutoClose.Visibility = Visibility.Visible;
				}
				Hwnd = new WindowInteropHelper(this).Handle;
				if (ExtraOperations != null && ExtraOperations.Count > 0)
				{
					contextMenu = new System.Windows.Controls.ContextMenu();
					contextMenu2 = new System.Windows.Controls.ContextMenu();
					foreach (SimpleOperationItem extraOperation in ExtraOperations)
					{
						if (extraOperation.IsSeparator)
						{
							if (!LZJMyiFpaTGRVrCnwyKh())
							{
								switch (0)
								{
								}
							}
							contextMenu.Items.Add(new Separator());
						}
						else if (extraOperation.Name.StartsWith("[=]"))
						{
							if (extraOperation.Name == "[=]----")
							{
								contextMenu2.Items.Add(new Separator());
								continue;
							}
							(string, string, string) tuple = UIHelper.ExtractIconAndTitle(extraOperation.Name.Substring(3));
							AppHelper.AddMenuItem(contextMenu2.Items, tuple.Item2, tuple.Item3, tuple.Item1, Gl1g3W9ebkn).Tag = extraOperation.Key;
						}
						else
						{
							(string, string, string) tuple2 = UIHelper.ExtractIconAndTitle(extraOperation.Name);
							AppHelper.AddMenuItem(contextMenu.Items, tuple2.Item2, tuple2.Item3, tuple2.Item1, Gl1g3W9ebkn).Tag = extraOperation.Key;
						}
					}
					if (contextMenu.Items.Count > 0)
					{
						goto IL_02af;
					}
					goto case 1;
				}
				BtnMenu.Visibility = Visibility.Collapsed;
				break;
			case 1:
				if (contextMenu2.Items.Count > 0)
				{
					BtnMenu.Visibility = Visibility.Visible;
					BtnMenu.Menu = contextMenu2;
					break;
				}
				goto default;
			default:
				BtnMenu.Visibility = Visibility.Collapsed;
				break;
			}
			if (dN5g3f6dZes)
			{
				TxtFilter.Focus();
			}
			return;
			IL_02af:
			LbOperations.ContextMenu = contextMenu;
			num = 1;
		}
		while (TfgWdSFpkwfoECN1FTqj == null);
		goto IL_02c8;
		IL_02c8:
		int num2 = default(int);
		num = num2;
		goto IL_02c9;
	}

	private double vlqg3apeZkv(string string_4)
	{
		if (string_4.EndsWith("%"))
		{
			double num = double.Parse(string_4.TrimEnd('%'));
			double dpiScaleX = VisualTreeHelper.GetDpi(this).DpiScaleX;
			return (double)Screen.FromHandle(new WindowInteropHelper(this).Handle).WorkingArea.Width * num / dpiScaleX / 100.0;
		}
		return double.Parse(string_4);
	}

	private double H6sg37Nydag(string string_4)
	{
		if (string_4.EndsWith("%"))
		{
			double num = double.Parse(string_4.TrimEnd('%'));
			double dpiScaleX = VisualTreeHelper.GetDpi(this).DpiScaleX;
			return (double)Screen.FromHandle(new WindowInteropHelper(this).Handle).WorkingArea.Height * num / dpiScaleX / 100.0;
		}
		return double.Parse(string_4);
	}

	private void JL9g3RkWbyg()
	{
		if (Location == ShowWindowLocation.LastPosition)
		{
			UpdateLayout();
			snLg3qQgc26();
			return;
		}
		if (!HasPresetSize)
		{
			base.SizeToContent = SizeToContent.WidthAndHeight;
		}
		if (!string.IsNullOrEmpty(MaxWindowSize))
		{
			if (Location == ShowWindowLocation.Manual || MaxWindowSize.StartsWith("!"))
			{
				base.SizeToContent = SizeToContent.Manual;
				int num = 0;
				if (TfgWdSFpkwfoECN1FTqj != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
			IHNRIiikxBwJdYmHpM3.kf1vv4KqpuC(this, Location, MaxWindowSize, true);
		}
		UpdateLayout();
		if (string.IsNullOrEmpty(MaxWindowSize))
		{
			snLg3qQgc26();
		}
		IHNRIiikxBwJdYmHpM3.z5HvvDbvaW2(this, Location);
	}

	private void snLg3qQgc26()
	{
		if (base.SizeToContent == SizeToContent.WidthAndHeight || base.SizeToContent == SizeToContent.Height)
		{
			base.SizeToContent = SizeToContent.Manual;
			if (base.Height > 600.0)
			{
				base.Height = 600.0;
			}
		}
	}

	private void Kgeg3c0JJRl()
	{
		kB9gfyEH5N9.InputGestures.Add(new KeyGesture(Key.F, ModifierKeys.Control));
		CommandBinding commandBinding = new CommandBinding
		{
			Command = kB9gfyEH5N9
		};
		commandBinding.Executed += EPdg3VarZTC;
		base.CommandBindings.Add(commandBinding);
	}

	private void EPdg3VarZTC(object sender, ExecutedRoutedEventArgs e)
	{
		GridFilter.Visibility = Visibility.Visible;
		TxtFilter.Focus();
		TxtFilter.Text = "";
	}

	private void tbWg3ZDoKAv()
	{
		double pixels = (double)(cn9g3ibvTNd.Count.ToString().Length * 7 + 6) * ListFontSize / 12.0;
		IndexColumnWidth = new GridLength(pixels);
	}

	private void S7Ag391V6F8(object sender, EventArgs e)
	{
		if (CloseOnDeactivated)
		{
			this.ThNvuM5Q9GQ(false);
		}
	}

	private void a2Ag3hUhK6s(IList<SimpleOperationItem> ilist_2)
	{
		for (int i = 0; i < ilist_2.Count; i++)
		{
			ilist_2[i].LineNumber = i + 1;
		}
	}

	private void e1Og3e8CpCf(object sender, System.Windows.Input.KeyEventArgs e)
	{
		char c = MG2g3YIW6Bm(e.Key);
		Key key = e.Key;
		if (e.Key == Key.ImeProcessed)
		{
			c = MG2g3YIW6Bm(e.ImeProcessedKey);
			key = e.ImeProcessedKey;
		}
		if (Keyboard.Modifiers == ModifierKeys.Control)
		{
			if (key >= Key.D1 && key <= Key.D9)
			{
				_003C_003Ec__DisplayClass102_0 _003C_003Ec__DisplayClass102_ = new _003C_003Ec__DisplayClass102_0();
				_003C_003Ec__DisplayClass102_.FyrSrn5Wjhn = this;
				_003C_003Ec__DisplayClass102_.euASrjOLQOy = (char)(49 + (key - 35));
				base.Dispatcher.InvokeAsync(_003C_003Ec__DisplayClass102_.SiTSrQeSQFh);
				return;
			}
			if (key >= Key.NumPad1 && key <= Key.NumPad9)
			{
				_003C_003Ec__DisplayClass102_1 _003C_003Ec__DisplayClass102_2 = new _003C_003Ec__DisplayClass102_1();
				_003C_003Ec__DisplayClass102_2.PK7SrDNP9Lm = this;
				_003C_003Ec__DisplayClass102_2.OVsSr5kgyex = (char)(49 + (key - 75));
				base.Dispatcher.InvokeAsync(_003C_003Ec__DisplayClass102_2.HaASr4pHf3P);
				return;
			}
			if (key == Key.A && IsMultiSelect)
			{
				base.Dispatcher.InvokeAsync(w8Mg3MaSPq5);
				return;
			}
			if (key == Key.D && IsMultiSelect)
			{
				goto IL_0279;
			}
			if (key == Key.Back)
			{
				TxtFilter.Text = "";
				return;
			}
		}
		int num;
		if (dN5g3f6dZes && !TxtFilter.IsKeyboardFocused)
		{
			if (key == Key.Back)
			{
				if (TxtFilter.Text.Length > 0)
				{
					num = 1;
					if (!LZJMyiFpaTGRVrCnwyKh())
					{
						int num2 = default(int);
						num = num2;
					}
					goto IL_020e;
				}
			}
			else if (key == Key.Return)
			{
				if (LbOperations.Items.Count == 1)
				{
					if (LbOperations.SelectionMode != System.Windows.Controls.SelectionMode.Single)
					{
						LbOperations.SelectedItems.Clear();
						LbOperations.SelectedItems.Add(LbOperations.Items[0]);
						base.Dispatcher.InvokeAsync(bRqg3OZvCV9);
						return;
					}
					LbOperations.SelectedIndex = 0;
				}
			}
			else if (char.IsLetterOrDigit(c))
			{
				num = 0;
				if (TfgWdSFpkwfoECN1FTqj == null)
				{
					goto IL_020e;
				}
				goto IL_0227;
			}
		}
		if (!IsMultiSelect)
		{
			if ((key == Key.Return || key == Key.Space) && LbOperations.SelectedItem != null)
			{
				base.Dispatcher.InvokeAsync(LBXg3FiaM6h);
			}
			return;
		}
		goto IL_029b;
		IL_029b:
		if (key == Key.A && Keyboard.Modifiers == ModifierKeys.Control)
		{
			xZ7g3rJMwHB();
		}
		return;
		IL_0227:
		TxtFilter.Text += c;
		return;
		IL_0279:
		base.Dispatcher.InvokeAsync(RNag3AaId3T);
		return;
		IL_020e:
		switch (num)
		{
		case 1:
			TxtFilter.Text = TxtFilter.Text.Substring(0, TxtFilter.Text.Length - 1);
			return;
		case 2:
			goto IL_0279;
		case 4:
			return;
		case 3:
			goto IL_029b;
		}
		goto IL_0227;
	}

	private void SelectAll()
	{
		foreach (SimpleOperationItem item in YqZg332s4K7)
		{
			if (!LbOperations.SelectedItems.Contains(item))
			{
				LbOperations.SelectedItems.Add(item);
			}
		}
	}

	private char MG2g3YIW6Bm(Key key_0)
	{
		bool capsLock = Console.CapsLock;
		bool flag = Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift);
		bool flag2 = (capsLock && !flag) || (!capsLock && flag);
		int num2;
		switch (key_0)
		{
		default:
			num2 = 1;
			if (!LZJMyiFpaTGRVrCnwyKh())
			{
				int num = default(int);
				num2 = num;
			}
			goto IL_030b;
		case Key.Oem1:
			if (!flag)
			{
				return ';';
			}
			return ':';
		case Key.OemPlus:
			if (!flag)
			{
				return '=';
			}
			return '+';
		case Key.OemComma:
			if (!flag)
			{
				return ',';
			}
			return '<';
		case Key.OemMinus:
			if (!flag)
			{
				return '-';
			}
			return '_';
		case Key.OemPeriod:
			if (!flag)
			{
				return '.';
			}
			return '>';
		case Key.Oem2:
			if (!flag)
			{
				return '/';
			}
			return '?';
		case Key.Oem3:
			if (!flag)
			{
				return '`';
			}
			return '~';
		case Key.Oem4:
			if (!flag)
			{
				return '[';
			}
			return '{';
		case Key.Oem5:
			if (!flag)
			{
				return '\\';
			}
			return '|';
		case Key.Oem6:
			if (!flag)
			{
				return ']';
			}
			return '}';
		case Key.Oem7:
			if (!flag)
			{
				return '\'';
			}
			return '"';
		case Key.Tab:
			return '\t';
		case Key.Return:
			return '\n';
		case Key.Space:
			return ' ';
		case Key.D0:
			if (!flag)
			{
				return '0';
			}
			return ')';
		case Key.D1:
			if (!flag)
			{
				return '1';
			}
			return '!';
		case Key.D2:
			if (!flag)
			{
				return '2';
			}
			return '@';
		case Key.D3:
			if (!flag)
			{
				return '3';
			}
			return '#';
		case Key.D4:
			if (!flag)
			{
				return '4';
			}
			return '$';
		case Key.D5:
			if (!flag)
			{
				return '5';
			}
			return '%';
		case Key.D6:
			if (!flag)
			{
				return '6';
			}
			return '^';
		case Key.D7:
			if (!flag)
			{
				return '7';
			}
			return '&';
		case Key.D8:
			if (flag)
			{
				return '*';
			}
			return '8';
		case Key.D9:
			if (!flag)
			{
				num2 = 0;
				if (TfgWdSFpkwfoECN1FTqj != null)
				{
					goto IL_030b;
				}
				goto IL_0328;
			}
			return '(';
		case Key.A:
			if (!flag2)
			{
				return 'a';
			}
			return 'A';
		case Key.B:
			if (!flag2)
			{
				num2 = 2;
				if (LZJMyiFpaTGRVrCnwyKh())
				{
					goto IL_030b;
				}
				goto IL_0447;
			}
			return 'B';
		case Key.C:
			if (!flag2)
			{
				num2 = 2;
				if (TfgWdSFpkwfoECN1FTqj != null)
				{
					goto IL_030b;
				}
				goto IL_032e;
			}
			return 'C';
		case Key.D:
			if (!flag2)
			{
				return 'd';
			}
			return 'D';
		case Key.E:
			if (flag2)
			{
				return 'E';
			}
			return 'e';
		case Key.F:
			if (!flag2)
			{
				int num = 3;
				goto IL_0355;
			}
			return 'F';
		case Key.G:
			if (!flag2)
			{
				return 'g';
			}
			return 'G';
		case Key.H:
			if (!flag2)
			{
				return 'h';
			}
			return 'H';
		case Key.I:
			if (!flag2)
			{
				return 'i';
			}
			return 'I';
		case Key.J:
			if (!flag2)
			{
				return 'j';
			}
			return 'J';
		case Key.K:
			if (!flag2)
			{
				return 'k';
			}
			return 'K';
		case Key.L:
			if (!flag2)
			{
				return 'l';
			}
			return 'L';
		case Key.M:
			if (!flag2)
			{
				return 'm';
			}
			return 'M';
		case Key.N:
			if (!flag2)
			{
				return 'n';
			}
			return 'N';
		case Key.O:
			if (!flag2)
			{
				return 'o';
			}
			return 'O';
		case Key.P:
			if (!flag2)
			{
				return 'p';
			}
			return 'P';
		case Key.Q:
			if (!flag2)
			{
				return 'q';
			}
			return 'Q';
		case Key.R:
			if (!flag2)
			{
				return 'r';
			}
			return 'R';
		case Key.S:
			if (!flag2)
			{
				return 's';
			}
			return 'S';
		case Key.T:
			if (flag2)
			{
				return 'T';
			}
			goto IL_03e1;
		case Key.U:
			if (!flag2)
			{
				return 'u';
			}
			return 'U';
		case Key.V:
			if (!flag2)
			{
				return 'v';
			}
			return 'V';
		case Key.W:
			if (!flag2)
			{
				return 'w';
			}
			return 'W';
		case Key.X:
			if (!flag2)
			{
				return 'x';
			}
			return 'X';
		case Key.Y:
			if (!flag2)
			{
				return 'y';
			}
			return 'Y';
		case Key.Z:
			if (flag2)
			{
				return 'Z';
			}
			return 'z';
		case Key.NumPad0:
			return '0';
		case Key.NumPad1:
			return '1';
		case Key.NumPad2:
			return '2';
		case Key.NumPad3:
			return '3';
		case Key.NumPad4:
			return '4';
		case Key.NumPad5:
			return '5';
		case Key.NumPad6:
			return '6';
		case Key.NumPad7:
			return '7';
		case Key.NumPad8:
			return '8';
		case Key.NumPad9:
			return '9';
		case Key.Multiply:
			return '*';
		case Key.Add:
			return '+';
		case Key.LineFeed:
		case Key.Clear:
		case Key.Pause:
		case Key.Capital:
		case Key.KanaMode:
		case Key.JunjaMode:
		case Key.FinalMode:
		case Key.HanjaMode:
		case Key.Escape:
		case Key.ImeConvert:
		case Key.ImeNonConvert:
		case Key.ImeAccept:
		case Key.ImeModeChange:
		case Key.Prior:
		case Key.Next:
		case Key.End:
		case Key.Home:
		case Key.Left:
		case Key.Up:
		case Key.Right:
		case Key.Down:
		case Key.Select:
		case Key.Print:
		case Key.Execute:
		case Key.Snapshot:
		case Key.Insert:
		case Key.Delete:
		case Key.Help:
		case Key.LWin:
		case Key.RWin:
		case Key.Apps:
		case Key.Sleep:
		case Key.Separator:
		case Key.AbntC1:
		case Key.AbntC2:
			goto IL_0447;
		case Key.Subtract:
			return '-';
		case Key.Decimal:
			return '.';
		case Key.Divide:
			{
				return '/';
			}
			IL_0328:
			return '9';
			IL_030b:
			switch (num2)
			{
			case 2:
				return 'b';
			case 4:
				goto IL_032e;
			case 3:
				goto IL_0355;
			case 5:
				goto IL_03e1;
			case 1:
				goto IL_0447;
			}
			goto IL_0328;
			IL_0447:
			return '\0';
			IL_03e1:
			return 't';
			IL_0355:
			return 'f';
			IL_032e:
			return 'c';
		}
	}

	internal void zmFg3I8s7IB(string string_4)
	{
		try
		{
			LbOperations.FontFamily = new FontFamily(string_4);
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("设置字体名称(" + string_4 + ")失败：" + ex.Message);
		}
	}

	private void Gl1g3W9ebkn(object sender, RoutedEventArgs e)
	{
		object tag = (sender as System.Windows.Controls.MenuItem).Tag;
		object obj;
		if (tag == null)
		{
			obj = null;
		}
		else
		{
			obj = tag.ToString();
			if (obj != null)
			{
				goto IL_0025;
			}
		}
		obj = "";
		goto IL_0025;
		IL_0025:
		SelectedOperation = (string)obj;
		this.ThNvuM5Q9GQ(true);
	}

	private void dwZg3kZXIk7(object sender, EventArgs e)
	{
		DateTime now = DateTime.Now;
		DateTime? wGtgfa0hN5E = WGtgfa0hN5E;
		if (!(now > wGtgfa0hN5E))
		{
			double value = 100.0 - (WGtgfa0hN5E.Value - DateTime.Now).TotalSeconds / AutoCloseSeconds * 100.0;
			ProgressBarAutoClose.Value = value;
			return;
		}
		Nntg3Gn4LUw();
		int num = 0;
		if (TfgWdSFpkwfoECN1FTqj != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		IList selectedItems = LbOperations.SelectedItems;
		if (selectedItems != null && selectedItems.Count > 0)
		{
			AppHelper.TriggerButtonClick(BtnOk);
		}
		else
		{
			this.ThNvuM5Q9GQ(false);
		}
	}

	private void Nntg3Gn4LUw()
	{
		if (FVfgf7ZpheC != null)
		{
			FVfgf7ZpheC.Tick -= dwZg3kZXIk7;
			FVfgf7ZpheC.Stop();
			FVfgf7ZpheC = null;
			ProgressBarAutoClose.Visibility = Visibility.Collapsed;
		}
	}

	private void ostg3s5c4nT(object sender, RoutedEventArgs e)
	{
		if (!AllowOkWhenEmpty && LbOperations.SelectedItems.Count == 0)
		{
			bool closeOnDeactivated = CloseOnDeactivated;
			CloseOnDeactivated = false;
			MessageBoxHelper.Show(this, "您尚未选择选项。", "", MessageBoxButton.OK, MessageBoxImage.Exclamation);
			CloseOnDeactivated = closeOnDeactivated;
		}
		else
		{
			this.ThNvuM5Q9GQ(true);
		}
	}

	private void gNIg3H0C5m6(object sender, SelectionChangedEventArgs e)
	{
		if (IsMultiSelect)
		{
			LblSelectedCount.Text = $"已选择 {LbOperations.SelectedItems.Count} 项";
		}
	}

	private static bool j8ug31omO5h(Visual visual_0, Point point_0)
	{
		return VisualTreeHelper.GetDescendantBounds(visual_0).Contains(point_0);
	}

	private void kVMg3bOwFWv(object sender, MouseButtonEventArgs e)
	{
		if (LbOperations.SelectedItem != null)
		{
			this.ThNvuM5Q9GQ(true);
			e.Handled = true;
		}
	}

	private void Dirg364My4C(object sender, MouseButtonEventArgs e)
	{
		if (!base.IsVisible || !base.IsLoaded)
		{
			return;
		}
		if (IsMultiSelect)
		{
			if (e.ChangedButton == MouseButton.Left && e.ClickCount >= 2)
			{
				int num = 0;
				if (TfgWdSFpkwfoECN1FTqj != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				this.ThNvuM5Q9GQ(true);
			}
		}
		else if (EnableQuickConfirm && e.ChangedButton == MouseButton.Left && LbOperations.SelectedItem != null && !(e.OriginalSource is System.Windows.Controls.ScrollViewer))
		{
			this.ThNvuM5Q9GQ(true);
		}
	}

	private void Qqfg3XtPSam(object sender, MouseButtonEventArgs e)
	{
		if (IsMultiSelect && e.ClickCount >= 2)
		{
			e.Handled = true;
			SimpleOperationItem value = (sender as FrameworkElement).Tag as SimpleOperationItem;
			LbOperations.SelectedItems.Clear();
			LbOperations.SelectedItems.Add(value);
			this.ThNvuM5Q9GQ(true);
		}
	}

	private void RVtg3mbCI7R(object sender, TextCompositionEventArgs e)
	{
		if (UseKeyboard && !dN5g3f6dZes)
		{
			string text = e.TextComposition.Text;
			if (!string.IsNullOrWhiteSpace(text))
			{
				SmEg3KXkdBu(text);
				e.Handled = true;
			}
		}
	}

	private void SmEg3KXkdBu(string string_4)
	{
		try
		{
			int num;
			if (int.TryParse(string_4, out var result))
			{
				result--;
				SimpleOperationItem simpleOperationItem = YqZg332s4K7[result];
				if (result < 0 || result >= YqZg332s4K7.Count)
				{
					return;
				}
				if (!IsMultiSelect)
				{
					LbOperations.SelectedItem = simpleOperationItem;
					if (EnableQuickConfirm)
					{
						base.Dispatcher.InvokeAsync(lWig3UmnG5F);
					}
					return;
				}
				if (!LbOperations.SelectedItems.Contains(simpleOperationItem))
				{
					LbOperations.SelectedItems.Add(simpleOperationItem);
					return;
				}
				LbOperations.SelectedItems.Remove(simpleOperationItem);
				num = 1;
				if (TfgWdSFpkwfoECN1FTqj != null)
				{
					goto IL_00e8;
				}
			}
			else
			{
				if (!TxtFilter.Text.IsNullOrEmpty())
				{
					return;
				}
				EPdg3VarZTC(this, null);
				num = 0;
				if (!LZJMyiFpaTGRVrCnwyKh())
				{
					goto IL_00e8;
				}
			}
			goto IL_00ec;
			IL_00e8:
			int num2 = default(int);
			num = num2;
			goto IL_00ec;
			IL_00ec:
			switch (num)
			{
			case 1:
				return;
			}
			TxtFilter.Text = string_4;
			TxtFilter.CaretIndex = TxtFilter.Text.Length;
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("设置选项错误：" + ex.Message);
		}
	}

	private void yrhg3x9v1Mq(object sender, RoutedEventArgs e)
	{
		xZ7g3rJMwHB();
	}

	private void xZ7g3rJMwHB()
	{
		if (cn9g3ibvTNd.HasData())
		{
			if (LbOperations.SelectedItems.Contains(cn9g3ibvTNd[0]))
			{
				LbOperations.SelectedItems.Clear();
			}
			else
			{
				LbOperations.SelectAll();
			}
		}
	}

	private void ri7g3pVmCcL(object sender, TextChangedEventArgs e)
	{
		if (ds7gfR2nRsj == null)
		{
			ds7gfR2nRsj = new DebounceDispatcher();
		}
		ds7gfR2nRsj.Debounce(150, ebvg3lwhvK5);
	}

	private void gj4g3BrhMNh()
	{
		List<SimpleOperationItem> list = LbOperations.SelectedItems.Cast<SimpleOperationItem>().ToList();
		IEnumerator<SimpleOperationItem> enumerator = default(IEnumerator<SimpleOperationItem>);
		int num;
		IList<SimpleOperationItem> list2;
		_003C_003Ec__DisplayClass123_1 _003C_003Ec__DisplayClass123_2 = default(_003C_003Ec__DisplayClass123_1);
		if (TxtFilter.Text.IsNullOrWhiteSpace())
		{
			YqZg332s4K7.Reset(cn9g3ibvTNd);
			enumerator = YqZg332s4K7.GetEnumerator();
			num = 1;
			if (TfgWdSFpkwfoECN1FTqj == null)
			{
				goto IL_0292;
			}
		}
		else
		{
			string text = TxtFilter.Text;
			bool num2 = text.StartsWithAny(false, "!", "！");
			if (num2 && text.Length > 1)
			{
				text = text.Substring(1);
			}
			list2 = null;
			if (num2)
			{
				_003C_003Ec__DisplayClass123_0 _003C_003Ec__DisplayClass123_ = new _003C_003Ec__DisplayClass123_0();
				_003C_003Ec__DisplayClass123_.rmtSrotQDO8 = text.Split(new string[1] { " " }, StringSplitOptions.RemoveEmptyEntries);
				list2 = cn9g3ibvTNd.Select(_003C_003Ec__DisplayClass123_.Ko8Srd3jTmc).Where(_003C_003Ec.kd5Srmby8VY ?? (_003C_003Ec.kd5Srmby8VY = _003C_003Ec.E55SrXesDR6.b9KSrGgh0n5)).OrderByDescending(_003C_003Ec.boESrKJ9MZD ?? (_003C_003Ec.boESrKJ9MZD = _003C_003Ec.E55SrXesDR6.TJXSrs0ejPc))
					.Select(_003C_003Ec.QFkSrxgqxZZ ?? (_003C_003Ec.QFkSrxgqxZZ = _003C_003Ec.E55SrXesDR6.l73SrHmVvbX))
					.ToList();
				goto IL_0230;
			}
			_003C_003Ec__DisplayClass123_2 = new _003C_003Ec__DisplayClass123_1();
			_003C_003Ec__DisplayClass123_2.AhmSrMHBjw1 = TxtFilter.Text.Split(new string[1] { " " }, StringSplitOptions.RemoveEmptyEntries);
			num = 0;
			if (!LZJMyiFpaTGRVrCnwyKh())
			{
				int num3 = default(int);
				num = num3;
			}
		}
		switch (num)
		{
		case 1:
			goto IL_0292;
		}
		list2 = cn9g3ibvTNd.Select(_003C_003Ec__DisplayClass123_2.lvFSrTKC5bL).Where(_003C_003Ec.vptSrrPZ70t ?? (_003C_003Ec.vptSrrPZ70t = _003C_003Ec.E55SrXesDR6.ERiSr1crkUb)).OrderByDescending(_003C_003Ec.RBcSrp8kKIs ?? (_003C_003Ec.RBcSrp8kKIs = _003C_003Ec.E55SrXesDR6.BGxSrbTWNnb))
			.Select(_003C_003Ec.mcCSrBKPanQ ?? (_003C_003Ec.mcCSrBKPanQ = _003C_003Ec.E55SrXesDR6.r3USr6VmljY))
			.ToList();
		goto IL_0230;
		IL_02b9:
		a2Ag3hUhK6s(YqZg332s4K7);
		return;
		IL_0230:
		if (IsMultiSelect)
		{
			foreach (SimpleOperationItem item in list)
			{
				if (!list2.Contains(item))
				{
					item.MatchPositions = null;
					list2.Add(item);
				}
			}
		}
		YqZg332s4K7.Reset(list2);
		goto IL_02b9;
		IL_0292:
		try
		{
			while (enumerator.MoveNext())
			{
				enumerator.Current.MatchPositions = null;
			}
		}
		finally
		{
			enumerator?.Dispose();
		}
		goto IL_02b9;
	}

	private void cmyg3Qls5ca(object sender, RoutedEventArgs e)
	{
		TxtFilter.Text = "";
	}

	private void fILg3j5pbme(object sender, MouseButtonEventArgs e)
	{
		if (IsMultiSelect && LbOperations.SelectedItems.Count > 0)
		{
			e.Handled = true;
		}
	}

	private void p4Cg3n8wVvJ(object sender, System.Windows.Input.KeyEventArgs e)
	{
		if (e.Key == Key.Down)
		{
			if (IsMultiSelect)
			{
				TxtFilter.MoveFocus(new TraversalRequest(FocusNavigationDirection.Down));
			}
			else if (LbOperations.SelectedIndex < LbOperations.Items.Count - 1)
			{
				LbOperations.SelectedIndex++;
			}
		}
		else
		{
			if (e.Key != Key.Up || IsMultiSelect || LbOperations.Items.Count <= 0)
			{
				return;
			}
			if (LbOperations.SelectedIndex < 0)
			{
				int num = 0;
				if (TfgWdSFpkwfoECN1FTqj != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				LbOperations.SelectedIndex = LbOperations.Items.Count - 1;
			}
			else if (LbOperations.SelectedIndex > 0)
			{
				LbOperations.SelectedIndex--;
			}
		}
	}

	private void XrPg3432LgW(object sender, RoutedEventArgs e)
	{
		this.ThNvuM5Q9GQ(false);
	}

	private void wyAg35ewagr(object sender, RoutedEventArgs e)
	{
		if (!cn9g3ibvTNd.HasData())
		{
			return;
		}
		IList<SimpleOperationItem> selectedItems = GetSelectedItems();
		LbOperations.UnselectAll();
		foreach (SimpleOperationItem item in cn9g3ibvTNd)
		{
			if (!selectedItems.Contains(item))
			{
				LbOperations.SelectedItems.Add(item);
			}
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!lb0gfZcGpK4)
		{
			lb0gfZcGpK4 = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/ui/selectoperationwindow.xaml", UriKind.Relative);
			System.Windows.Application.LoadComponent(this, resourceLocator);
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
		int num2 = default(int);
		switch (connectionId)
		{
		case 1:
			SelectWindow = (SelectOperationWindow)target;
			break;
		case 2:
			GridFilter = (Grid)target;
			break;
		case 3:
			TxtFilter = (System.Windows.Controls.TextBox)target;
			TxtFilter.PreviewKeyDown += p4Cg3n8wVvJ;
			TxtFilter.TextChanged += ri7g3pVmCcL;
			break;
		case 4:
			BtnClearFilter = (System.Windows.Controls.Button)target;
			BtnClearFilter.Click += cmyg3Qls5ca;
			break;
		case 5:
			LbOperations = (System.Windows.Controls.ListBox)target;
			LbOperations.MouseDoubleClick += kVMg3bOwFWv;
			LbOperations.MouseUp += Dirg364My4C;
			LbOperations.PreviewMouseRightButtonDown += fILg3j5pbme;
			num = 0;
			if (TfgWdSFpkwfoECN1FTqj != null)
			{
				goto IL_018f;
			}
			goto IL_0193;
		default:
			lb0gfZcGpK4 = true;
			break;
		case 7:
			LblSelectedCount = (TextBlock)target;
			break;
		case 8:
			LblNote = (TextBlock)target;
			break;
		case 9:
			BtnSelectAll = (System.Windows.Controls.Button)target;
			BtnSelectAll.Click += yrhg3x9v1Mq;
			num = 0;
			if (TfgWdSFpkwfoECN1FTqj == null)
			{
				break;
			}
			goto IL_0193;
		case 10:
			MenuInvertSelection = (System.Windows.Controls.MenuItem)target;
			num = 1;
			if (TfgWdSFpkwfoECN1FTqj != null)
			{
				goto IL_018f;
			}
			goto IL_0193;
		case 11:
			HintButton = (MarkdownHintButton)target;
			break;
		case 12:
			BtnMenu = (DropDownButton)target;
			break;
		case 13:
			BtnOk = (System.Windows.Controls.Button)target;
			BtnOk.Click += ostg3s5c4nT;
			break;
		case 14:
			BtnCancel = (System.Windows.Controls.Button)target;
			BtnCancel.Click += XrPg3432LgW;
			break;
		case 15:
			{
				ProgressBarAutoClose = (System.Windows.Controls.ProgressBar)target;
				break;
			}
			IL_018f:
			num = num2;
			goto IL_0193;
			IL_0193:
			switch (num)
			{
			default:
				LbOperations.PreviewTextInput += RVtg3mbCI7R;
				LbOperations.SelectionChanged += gNIg3H0C5m6;
				break;
			case 1:
				MenuInvertSelection.Click += wyAg35ewagr;
				break;
			case 2:
				break;
			}
			break;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 6)
		{
			((Grid)target).MouseDown += Qqfg3XtPSam;
		}
	}

	static SelectOperationWindow()
	{
		IndexColumnWidthProperty = DependencyProperty.Register("IndexColumnWidth", typeof(GridLength), typeof(SelectOperationWindow), new PropertyMetadata(new GridLength(30.0)));
		ListIconSizeProperty = DependencyProperty.Register("ListIconSize", typeof(double), typeof(SelectOperationWindow), new PropertyMetadata(16.0));
	}

	[CompilerGenerated]
	private bool xhqg3Dx7lco(SimpleOperationItem simpleOperationItem_0)
	{
		return simpleOperationItem_0.Key.Equals(PreSelectedKey);
	}

	[CompilerGenerated]
	private void HQxg3d6F06e()
	{
		if (UseKeyboard)
		{
			Activate();
			LbOperations.Focus();
		}
		if (LbOperations.SelectedItem != null)
		{
			((ListBoxItem)LbOperations.ItemContainerGenerator.ContainerFromItem(LbOperations.SelectedItem))?.Focus();
		}
	}

	[CompilerGenerated]
	private void W2jg3oj5uC4(object sender, MouseButtonEventArgs e)
	{
		Nntg3Gn4LUw();
	}

	[CompilerGenerated]
	private void M5yg3TmIvCI(object sender, System.Windows.Input.KeyEventArgs e)
	{
		Nntg3Gn4LUw();
	}

	[CompilerGenerated]
	private void w8Mg3MaSPq5()
	{
		SelectAll();
	}

	[CompilerGenerated]
	private void RNag3AaId3T()
	{
		LbOperations.SelectedItems.Clear();
	}

	[CompilerGenerated]
	private void bRqg3OZvCV9()
	{
		this.ThNvuM5Q9GQ(true);
	}

	[CompilerGenerated]
	private void LBXg3FiaM6h()
	{
		this.ThNvuM5Q9GQ(true);
	}

	[CompilerGenerated]
	private void lWig3UmnG5F()
	{
		this.ThNvuM5Q9GQ(true);
	}

	[CompilerGenerated]
	private void ebvg3lwhvK5(object object_0)
	{
		gj4g3BrhMNh();
	}

	internal static bool LZJMyiFpaTGRVrCnwyKh()
	{
		return TfgWdSFpkwfoECN1FTqj == null;
	}
}
