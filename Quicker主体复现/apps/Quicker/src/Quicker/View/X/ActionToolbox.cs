using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using dkbgyyMixGueocCf9RC;
using FontAwesome5;
using IOn6RhAJdTUbfGy6gwn;
using log4net;
using Newtonsoft.Json;
using qgnh0JiJCUj4XCaowwH;
using Quicker.Common;
using Quicker.Domain;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Pinyin;
using Quicker.Utilities.UI;

namespace Quicker.View.X;

public class ActionToolbox : UserControl, IComponentConnector, IStyleConnector, IToolBoxControl
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec w5WSMlKFm5y;

		public static Func<XToolboxItem, int> hWDSMiQunCF;

		public static Func<XToolboxItem, string> bP8SM3mnp0L;

		public static Action<XToolboxItem> MCUSMfDOGjc;

		public static Func<XToolboxItem, int> v2RSMzHGAG7;

		public static Func<XToolboxItem, string> OaVSAwele4C;

		public static Func<XToolboxItem, bool> GR1SAtebE3T;

		public static Func<XToolboxItem, int> Uo7SAgTOfSy;

		public static Func<XToolboxItem, string> rB4SALAuHXO;

		public static Func<StepInParamDef, bool> r9tSAv78ILQ;

		public static Comparison<KeyValuePair<string, int>> yqWSASl21Zb;

		private static _003C_003Ec wWgueWWHosJrXbS8XrAL;

		static _003C_003Ec()
		{
			w5WSMlKFm5y = new _003C_003Ec();
		}

		internal int JmcSM54nQih(XToolboxItem x)
		{
			return x.MatchScore;
		}

		internal string ey9SMD5GSVQ(XToolboxItem x)
		{
			return x.Name;
		}

		internal void YFNSMdrh8Lu(XToolboxItem x)
		{
			x.MatchScore = 0;
			x.MatchPositions = null;
		}

		internal int mY6SMo1xwT0(XToolboxItem x)
		{
			return x.UseCount;
		}

		internal string VY5SMT3pOYR(XToolboxItem x)
		{
			return x.NamePinyin;
		}

		internal bool lpXSMMi6vHC(XToolboxItem x)
		{
			return AppState.DataService.FavorBlocks.Contains(x.Key);
		}

		internal int t4LSMAI0QL8(XToolboxItem x)
		{
			return x.UseCount;
		}

		internal string x3uSMOjF7bj(XToolboxItem x)
		{
			return x.NamePinyin;
		}

		internal bool ApXSMFTqcqP(StepInParamDef x)
		{
			if (!x.IsControlField)
			{
				return false;
			}
			return x.SelectionItems.HasData();
		}

		internal int xf1SMUrBXaY(KeyValuePair<string, int> pair1, KeyValuePair<string, int> pair2)
		{
			return -pair1.Value.CompareTo(pair2.Value);
		}

		internal static bool wltQUqWHfCMxBmiRQGXy()
		{
			return wWgueWWHosJrXbS8XrAL == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass18_0
	{
		public string hkvSANgBp7Y;

		public ActionToolbox q4QSAJjDnbL;

		internal static _003C_003Ec__DisplayClass18_0 nweiWwWHis1sWeRUi6jB;

		internal bool fvcSA2xOxXW(XToolboxItem x)
		{
			if (TdcLIIotQYa(x, hkvSANgBp7Y))
			{
				if (q4QSAJjDnbL.FilterCategory.HasValue && (q4QSAJjDnbL.FilterCategory != StepRunnerCategory.Favor || !AppState.DataService.FavorBlocks.Contains(x.Key)))
				{
					if (x.StepRunner.Category != q4QSAJjDnbL.FilterCategory)
					{
						return x.StepRunner.SecondaryCategories?.Contains(q4QSAJjDnbL.FilterCategory.Value) ?? false;
					}
					return true;
				}
				return true;
			}
			return false;
		}

		internal bool cUuSAuKoJtT(XToolboxItem x)
		{
			if (q4QSAJjDnbL.FilterCategory != x.StepRunner.Category)
			{
				return x.StepRunner.SecondaryCategories?.Contains(q4QSAJjDnbL.FilterCategory.Value) ?? false;
			}
			return true;
		}

		internal static bool QgPYSCWHlgwmaHv1m1K2()
		{
			return nweiWwWHis1sWeRUi6jB == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass19_0
	{
		public string ItFSACbEeVw;

		internal static _003C_003Ec__DisplayClass19_0 SEvdhmWH8Zofh0CaTNSZ;

		internal bool pLRSA0l1IBm(SelectionItem x)
		{
			return string.Equals(x.Name, ItFSACbEeVw, StringComparison.OrdinalIgnoreCase);
		}

		internal static bool R5k0hLWHRZ30U8AslRaF()
		{
			return SEvdhmWH8Zofh0CaTNSZ == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass27_0
	{
		public ActionToolbox hJGSA8rNHpe;

		public XToolboxItem DNKSAafvDjl;

		internal static _003C_003Ec__DisplayClass27_0 Rv8JDHWHPkKhcofeLPXo;

		internal void VC0SAP6usJi(object sender, RoutedEventArgs e)
		{
			((ActionDesignerWindow)Window.GetWindow(hJGSA8rNHpe)).HighlightText(DNKSAafvDjl.Name);
		}

		internal void I2YSAEArnvl(object sender, RoutedEventArgs e)
		{
			AppState.DataService.FavorBlocks.Add(DNKSAafvDjl.Key);
			AppState.DataService.NEOtX7Edm6D();
			hJGSA8rNHpe.mMILIYgmTLP();
		}

		internal void ebcSAy7MvG8(object sender, RoutedEventArgs e)
		{
			AppState.DataService.FavorBlocks.Remove(DNKSAafvDjl.Key);
			AppState.DataService.NEOtX7Edm6D();
			hJGSA8rNHpe.mMILIYgmTLP();
		}

		internal static bool FTdmoKWHMh96UnLsEJZv()
		{
			return Rv8JDHWHPkKhcofeLPXo == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	internal struct _003C_003Ec__DisplayClass35_0
	{
		public IDictionary<string, int> tNcSA7PcPr0;
	}

	private readonly IList<XToolboxItem> qL3LIdFmTC6 = new List<XToolboxItem>();

	private SmartCollection<XToolboxItem> TJxLIoDXaRG = new SmartCollection<XToolboxItem>();

	[CompilerGenerated]
	private StepRunnerCategory? COXLITCMLxZ;

	[CompilerGenerated]
	private readonly ObservableCollection<TabItem> W9JLIMPhiUk = new ObservableCollection<TabItem>();

	private static IDictionary<string, int> bkoLIAqLrBA;

	private static readonly ILog NZFLIOZZUd1;

	[CompilerGenerated]
	private EventHandler m_ItemDoubleClicked;

	private DebounceDispatcher TmYLIF3agUn;

	private UIElement a2nLIUuP8CF;

	internal Grid ToolboxPanel;

	internal TextBox TxtFilter;

	internal Button BtnFilter;

	internal TabControl FilterTab;

	internal DropDownButton BtnMenu;

	internal ContextMenu MainContextMenu1;

	internal MenuItem MenuSortByName;

	internal MenuItem MenuSortByUsage;

	internal MenuItem MenuClearFavor;

	internal ListBox LbToolbox;

	private bool IiPLIlc8LUf;

	private static ActionToolbox FX7WPNFJEXIwi0X4oOB6;

	public StepRunnerCategory? FilterCategory
	{
		[CompilerGenerated]
		get
		{
			return COXLITCMLxZ;
		}
		[CompilerGenerated]
		set
		{
			COXLITCMLxZ = value;
		}
	}

	public ObservableCollection<TabItem> TabItems
	{
		[CompilerGenerated]
		get
		{
			return W9JLIMPhiUk;
		}
	}

	public bool IsSearchFocused => TxtFilter.IsKeyboardFocused;

	public event EventHandler ItemDoubleClicked
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = this.m_ItemDoubleClicked;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_ItemDoubleClicked, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = this.m_ItemDoubleClicked;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_ItemDoubleClicked, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	private static IDictionary<string, int> mEDLI9cGmZs()
	{
		if (bkoLIAqLrBA == null)
		{
			try
			{
				bkoLIAqLrBA = X4FLIp28pXj();
			}
			catch (Exception ex)
			{
				string message = "统计模块使用数量出错：" + ex.Message;
				NZFLIOZZUd1.Warn(message, ex);
				AppHelper.ShowWarning(message);
				bkoLIAqLrBA = new Dictionary<string, int>();
			}
		}
		return bkoLIAqLrBA;
	}

	public ActionToolbox()
	{
		InitializeComponent();
		base.Loaded += mjZLIeiCGcG;
		AppImeHelper.SetImeState(TxtFilter, AppState.HHxtaMaoqJr().ToolboxSearchImeState);
	}

	private void TjDLIhVxOGV()
	{
		TabItems.Add(new TabItem
		{
			Tooltip = "所有模块",
			Icon = EFontAwesomeIcon.Light_AlignJustify,
			Categories = null
		});
		TabItems.Add(new TabItem
		{
			Tooltip = "模块收藏夹",
			Icon = EFontAwesomeIcon.Light_Bookmark,
			Categories = new StepRunnerCategory[1] { StepRunnerCategory.Favor }
		});
		TabItems.Add(new TabItem
		{
			Tooltip = "基础",
			Icon = EFontAwesomeIcon.Light_Cog,
			Categories = new StepRunnerCategory[1]
		});
		TabItems.Add(new TabItem
		{
			Tooltip = "模拟输入",
			Icon = EFontAwesomeIcon.Light_Keyboard,
			Categories = new StepRunnerCategory[1] { StepRunnerCategory.Input }
		});
		TabItems.Add(new TabItem
		{
			Tooltip = "界面交互",
			Icon = EFontAwesomeIcon.Light_Window,
			Categories = new StepRunnerCategory[1] { StepRunnerCategory.Ui }
		});
		TabItems.Add(new TabItem
		{
			Tooltip = "文本处理",
			Icon = EFontAwesomeIcon.Light_Font,
			Categories = new StepRunnerCategory[1] { StepRunnerCategory.Text }
		});
		TabItems.Add(new TabItem
		{
			Tooltip = "图片处理",
			Icon = EFontAwesomeIcon.Light_Image,
			Categories = new StepRunnerCategory[1] { StepRunnerCategory.Image }
		});
		TabItems.Add(new TabItem
		{
			Tooltip = "剪贴板",
			Icon = EFontAwesomeIcon.Light_Clipboard,
			Categories = new StepRunnerCategory[1] { StepRunnerCategory.Clipboard }
		});
		TabItems.Add(new TabItem
		{
			Tooltip = "文件",
			Icon = EFontAwesomeIcon.Light_FileAlt,
			Categories = new StepRunnerCategory[1] { StepRunnerCategory.Files }
		});
		TabItems.Add(new TabItem
		{
			Tooltip = "系统",
			Icon = EFontAwesomeIcon.Brands_Windows,
			Categories = new StepRunnerCategory[1] { StepRunnerCategory.System }
		});
		TabItems.Add(new TabItem
		{
			Tooltip = "计算",
			Icon = EFontAwesomeIcon.Light_CalculatorAlt,
			Categories = new StepRunnerCategory[1] { StepRunnerCategory.Compute }
		});
		TabItems.Add(new TabItem
		{
			Tooltip = "程序流程",
			Icon = EFontAwesomeIcon.Light_CodeBranch,
			Categories = new StepRunnerCategory[1] { StepRunnerCategory.Flow }
		});
		int num = 0;
		if (FX7WPNFJEXIwi0X4oOB6 != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		TabItems.Add(new TabItem
		{
			Tooltip = "网络",
			Icon = EFontAwesomeIcon.Light_Globe,
			Categories = new StepRunnerCategory[1] { StepRunnerCategory.Network }
		});
		TabItems.Add(new TabItem
		{
			Tooltip = "第三方软件交互",
			Icon = EFontAwesomeIcon.Light_Cogs,
			Categories = new StepRunnerCategory[1] { StepRunnerCategory.SoftInteraction }
		});
		FilterTab.ItemsSource = TabItems;
		FilterTab.SelectedIndex = ((AppState.DataService.FavorBlocks.Count > 0) ? 1 : 2);
	}

	private void mjZLIeiCGcG(object sender, RoutedEventArgs e)
	{
		if (TabItems.Count > 0)
		{
			return;
		}
		foreach (IStepRunner allRunner in StepRunnerRegistry.GetAllRunners())
		{
			qL3LIdFmTC6.Add(new XToolboxItem
			{
				Key = allRunner.Key,
				Name = allRunner.Name,
				NamePinyin = XRlL56iKFaTMc4ji9eS.hM5vNnSWUWf(allRunner.Name),
				Icon = allRunner.Icon,
				Description = allRunner.Description,
				Group = BcULIGyW0bN(allRunner.Category),
				GroupIndex = (int)allRunner.Category,
				Link = allRunner.HelpLink,
				UseCount = (mEDLI9cGmZs().ContainsKey(allRunner.Key) ? mEDLI9cGmZs()[allRunner.Key] : 0),
				StepRunner = allRunner
			});
		}
		TjDLIhVxOGV();
		ViuLIWVKAiH();
		LbToolbox.ItemsSource = TJxLIoDXaRG;
	}

	private void mMILIYgmTLP()
	{
		_003C_003Ec__DisplayClass18_0 _003C_003Ec__DisplayClass18_ = new _003C_003Ec__DisplayClass18_0();
		_003C_003Ec__DisplayClass18_.q4QSAJjDnbL = this;
		_003C_003Ec__DisplayClass18_.hkvSANgBp7Y = TxtFilter.Text;
		int num = 1;
		if (FX7WPNFJEXIwi0X4oOB6 != null)
		{
			goto IL_00b6;
		}
		goto IL_00ba;
		IL_00b6:
		int num2 = default(int);
		num = num2;
		goto IL_00ba;
		IL_00ba:
		IOrderedEnumerable<XToolboxItem> range = default(IOrderedEnumerable<XToolboxItem>);
		do
		{
			IOrderedEnumerable<XToolboxItem> source;
			Func<XToolboxItem, string> keySelector;
			switch (num)
			{
			case 1:
			{
				if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass18_.hkvSANgBp7Y))
				{
					source = qL3LIdFmTC6.Where(_003C_003Ec__DisplayClass18_.fvcSA2xOxXW).OrderByDescending(_003C_003Ec.hWDSMiQunCF ?? (_003C_003Ec.hWDSMiQunCF = _003C_003Ec.w5WSMlKFm5y.JmcSM54nQih));
					keySelector = _003C_003Ec.bP8SM3mnp0L ?? (_003C_003Ec.bP8SM3mnp0L = _003C_003Ec.w5WSMlKFm5y.ey9SMD5GSVQ);
					break;
				}
				qL3LIdFmTC6.ForEach(_003C_003Ec.MCUSMfDOGjc ?? (_003C_003Ec.MCUSMfDOGjc = _003C_003Ec.w5WSMlKFm5y.YFNSMdrh8Lu));
				if (!FilterCategory.HasValue)
				{
					TJxLIoDXaRG.Reset((!AO7eLUM7kJyEdiOQu2O.ToolboxOrderByUseCount) ? qL3LIdFmTC6.OrderBy(_003C_003Ec.OaVSAwele4C ?? (_003C_003Ec.OaVSAwele4C = _003C_003Ec.w5WSMlKFm5y.VY5SMT3pOYR)) : qL3LIdFmTC6.OrderByDescending(_003C_003Ec.v2RSMzHGAG7 ?? (_003C_003Ec.v2RSMzHGAG7 = _003C_003Ec.w5WSMlKFm5y.mY6SMo1xwT0)));
					return;
				}
				IEnumerable<XToolboxItem> source2 = ((FilterCategory != StepRunnerCategory.Favor) ? qL3LIdFmTC6.Where(_003C_003Ec__DisplayClass18_.cUuSAuKoJtT) : qL3LIdFmTC6.Where(_003C_003Ec.GR1SAtebE3T ?? (_003C_003Ec.GR1SAtebE3T = _003C_003Ec.w5WSMlKFm5y.lpXSMMi6vHC)));
				source2 = ((!AO7eLUM7kJyEdiOQu2O.ToolboxOrderByUseCount) ? source2.OrderBy(_003C_003Ec.rB4SALAuHXO ?? (_003C_003Ec.rB4SALAuHXO = _003C_003Ec.w5WSMlKFm5y.x3uSMOjF7bj)) : source2.OrderByDescending(_003C_003Ec.Uo7SAgTOfSy ?? (_003C_003Ec.Uo7SAgTOfSy = _003C_003Ec.w5WSMlKFm5y.t4LSMAI0QL8)));
				TJxLIoDXaRG.Reset(source2);
				return;
			}
			default:
				TJxLIoDXaRG.Reset(range);
				return;
			}
			range = source.ThenBy(keySelector);
			num = 0;
		}
		while (ke2MG2FJGeWnIweLeQ5b());
		goto IL_00b6;
	}

	private static bool TdcLIIotQYa(XToolboxItem xtoolboxItem_0, string string_0)
	{
		int num = 1;
		while (true)
		{
			_003C_003Ec__DisplayClass19_0 _003C_003Ec__DisplayClass19_ = new _003C_003Ec__DisplayClass19_0();
			int num2 = 0;
			if (FX7WPNFJEXIwi0X4oOB6 != null)
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			_003C_003Ec__DisplayClass19_.ItFSACbEeVw = string_0;
			if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass19_.ItFSACbEeVw) && !string.IsNullOrEmpty(xtoolboxItem_0.Name))
			{
				IMatchResult matchResult = tkxn6HAKAgMT8gvXbyh.SgJi5c1l5A(xtoolboxItem_0.Name, _003C_003Ec__DisplayClass19_.ItFSACbEeVw);
				xtoolboxItem_0.MatchPositions = matchResult?.GetMatchPositions();
				xtoolboxItem_0.MatchScore = matchResult?.Score ?? 0;
				IStepRunner stepRunner = xtoolboxItem_0.StepRunner;
				StepInParamDef stepInParamDef = stepRunner.InputParams.FirstOrDefault(_003C_003Ec.r9tSAv78ILQ ?? (_003C_003Ec.r9tSAv78ILQ = _003C_003Ec.w5WSMlKFm5y.ApXSMFTqcqP));
				if (matchResult == null && !_003C_003Ec__DisplayClass19_.ItFSACbEeVw.ContainedInAny(xtoolboxItem_0.Name, xtoolboxItem_0.Description, xtoolboxItem_0.Key) && (stepRunner.KeyWords == null || !_003C_003Ec__DisplayClass19_.ItFSACbEeVw.EqualsAny(true, stepRunner.KeyWords?.ToArray())))
				{
					return stepInParamDef?.SelectionItems.Any(_003C_003Ec__DisplayClass19_.pLRSA0l1IBm) ?? false;
				}
				return true;
			}
			return true;
		}
	}

	private void ViuLIWVKAiH()
	{
		try
		{
			if (AO7eLUM7kJyEdiOQu2O.ToolboxOrderByUseCount)
			{
				MenuSortByName.IsChecked = false;
				MenuSortByUsage.IsChecked = true;
			}
			else
			{
				MenuSortByName.IsChecked = true;
				MenuSortByUsage.IsChecked = false;
			}
		}
		catch (Exception ex)
		{
			NZFLIOZZUd1.Warn("UpdateSort null:" + ex.Message, ex);
		}
	}

	private void Ym1LIke7mUv(object sender, MouseEventArgs e)
	{
		if (sender is FrameworkElement frameworkElement && e.LeftButton == MouseButtonState.Pressed && frameworkElement == a2nLIUuP8CF && frameworkElement.Tag is XToolboxItem data)
		{
			try
			{
				AppHelper.DoDragDropWrap(frameworkElement, data, DragDropEffects.Copy);
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("拖动异常：" + ex.Message);
			}
		}
	}

	private string BcULIGyW0bN(StepRunnerCategory stepRunnerCategory_0)
	{
		return stepRunnerCategory_0 switch
		{
			StepRunnerCategory.Basic => "常用", 
			StepRunnerCategory.Text => "文本处理", 
			StepRunnerCategory.Image => "图片处理", 
			StepRunnerCategory.Clipboard => "剪贴板", 
			StepRunnerCategory.Flow => "程序流程", 
			StepRunnerCategory.System => "系统", 
			StepRunnerCategory.Files => "文件", 
			StepRunnerCategory.Compute => "计算", 
			_ => stepRunnerCategory_0.ToString(), 
		};
	}

	private void oiaLIsFSmtV(object sender, RoutedEventArgs e)
	{
		TxtFilter.Text = "";
	}

	private void JK6LIHeGdgI(object sender, TextChangedEventArgs e)
	{
		if (TmYLIF3agUn == null)
		{
			TmYLIF3agUn = new DebounceDispatcher();
		}
		TmYLIF3agUn.Debounce(50, B02LIn1Eiem);
	}

	private void qjoLI1WbK2K(object sender, MouseButtonEventArgs e)
	{
		_003C_003Ec__DisplayClass27_0 _003C_003Ec__DisplayClass27_ = new _003C_003Ec__DisplayClass27_0();
		_003C_003Ec__DisplayClass27_.hJGSA8rNHpe = this;
		a2nLIUuP8CF = sender as FrameworkElement;
		_003C_003Ec__DisplayClass27_.DNKSAafvDjl = (sender as FrameworkElement).Tag as XToolboxItem;
		if (e.ChangedButton != MouseButton.Right)
		{
			return;
		}
		ContextMenu contextMenu = new ContextMenu();
		AppHelper.AddMenuItem(contextMenu.Items, "高亮步骤(_H)", "在步骤列表中高亮使用此模块的步骤", "fa:Light_Highlighter:#FF0000", _003C_003Ec__DisplayClass27_.VC0SAP6usJi);
		(sender as FrameworkElement).ContextMenu = contextMenu;
		int num = 0;
		if (!ke2MG2FJGeWnIweLeQ5b())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (!AppState.DataService.FavorBlocks.Contains(_003C_003Ec__DisplayClass27_.DNKSAafvDjl.Key))
		{
			AppHelper.AddMenuItem(contextMenu.Items, "添加到收藏夹", "将当前模块添加到收藏夹", "", _003C_003Ec__DisplayClass27_.I2YSAEArnvl);
		}
		else
		{
			AppHelper.AddMenuItem(contextMenu.Items, "从收藏夹移除", "将当前模块从收藏夹移除", "", _003C_003Ec__DisplayClass27_.ebcSAy7MvG8);
		}
	}

	private void f6rLIblQ5i2(object sender, SelectionChangedEventArgs e)
	{
		FilterCategory = (FilterTab.SelectedItem as TabItem)?.Categories?.FirstOrDefault();
		mMILIYgmTLP();
	}

	private void aF4LI65r83S(object sender, MouseButtonEventArgs e)
	{
		if (LbToolbox.SelectedItem != null)
		{
			this.m_ItemDoubleClicked?.Invoke(LbToolbox.SelectedItem, EventArgs.Empty);
		}
	}

	private void dhlLIX3rO75(object sender, RoutedEventArgs e)
	{
		string text = (sender as Button).Tag as string;
		if (!string.IsNullOrEmpty(text))
		{
			AppHelper.TryOpenUrlOrFile(text);
		}
		else
		{
			AppHelper.TryOpenUrlOrFile("https://www.yuque.com/quicker/help");
		}
	}

	private void v4XLImaDNr1(object sender, KeyboardFocusChangedEventArgs e)
	{
	}

	private void urvLIKI4LtX(object sender, RoutedEventArgs e)
	{
		base.Dispatcher.InvokeAsync(Q6wLI4GFVgE);
	}

	private void ypULIxEtSi1(object sender, RoutedEventArgs e)
	{
		int num = 1;
		while (true)
		{
			List<KeyValuePair<string, int>> list = mEDLI9cGmZs().ToList();
			int num2 = 0;
			if (!ke2MG2FJGeWnIweLeQ5b())
			{
				goto IL_003e;
			}
			goto IL_0042;
			IL_0042:
			while (true)
			{
				Comparison<KeyValuePair<string, int>> comparison;
				switch (num2)
				{
				default:
					comparison = _003C_003Ec.yqWSASl21Zb ?? (_003C_003Ec.yqWSASl21Zb = _003C_003Ec.w5WSMlKFm5y.xf1SMUrBXaY);
					goto IL_002c;
				case 1:
					break;
				case 2:
				{
					int num3 = 0;
					for (int i = 0; i < list.Count && i <= 20 && list[i].Value >= 5; i++)
					{
						if (!AppState.DataService.FavorBlocks.Contains(list[i].Key))
						{
							AppState.DataService.FavorBlocks.Add(list[i].Key);
							num3++;
						}
					}
					if (num3 > 0)
					{
						AppState.DataService.NEOtX7Edm6D();
						if (Dn5LIr1mW4X())
						{
							mMILIYgmTLP();
						}
					}
					AppHelper.ShowInformation($"共添加了 {num3} 项。");
					return;
				}
				}
				break;
				IL_002c:
				list.Sort(comparison);
				num2 = 2;
				if (ke2MG2FJGeWnIweLeQ5b())
				{
					continue;
				}
				goto IL_003e;
			}
			continue;
			IL_003e:
			num2 = num;
			goto IL_0042;
		}
	}

	private bool Dn5LIr1mW4X()
	{
		return FilterTab.SelectedIndex == 1;
	}

	private static IDictionary<string, int> X4FLIp28pXj()
	{
		_003C_003Ec__DisplayClass35_0 _003C_003Ec__DisplayClass35_0_ = default(_003C_003Ec__DisplayClass35_0);
		_003C_003Ec__DisplayClass35_0_.tNcSA7PcPr0 = new Dictionary<string, int>();
		foreach (ActionProfile item in AppState.DataService.mP6tXA8VyNP().Values.ToList())
		{
			foreach (ActionItem actionItem in item.ActionItems)
			{
				if (actionItem != null && actionItem.ActionType == ActionType.XAction && string.IsNullOrEmpty(actionItem.TemplateId))
				{
					try
					{
						bswLI5hqeHt(JsonConvert.DeserializeObject<XAction>(actionItem.Data), ref _003C_003Ec__DisplayClass35_0_);
					}
					catch (Exception ex)
					{
						NZFLIOZZUd1.Warn("统计动作" + actionItem.Title + "," + actionItem.Id + "的步骤使用次数出错：" + ex.Message);
					}
				}
			}
		}
		return _003C_003Ec__DisplayClass35_0_.tNcSA7PcPr0;
	}

	private void qjALIBw28Ey(object sender, RoutedEventArgs e)
	{
		AppState.DataService.FavorBlocks.Clear();
		AppState.DataService.NEOtX7Edm6D();
		mMILIYgmTLP();
	}

	private void R9vLIQ6ljUw(object sender, RoutedEventArgs e)
	{
		AO7eLUM7kJyEdiOQu2O.ToolboxOrderByUseCount = (sender as MenuItem).Tag as string == "UseCount";
		ViuLIWVKAiH();
		mMILIYgmTLP();
	}

	public void FocusSearch()
	{
		TxtFilter.Focus();
		TxtFilter.Text = "";
		FilterTab.SelectedIndex = 1;
	}

	private void FkxLIjvnE9p(object sender, KeyEventArgs e)
	{
		if ((e.Key == Key.H || (e.Key == Key.ImeProcessed && e.ImeProcessedKey == Key.H)) && LbToolbox.SelectedItem is XToolboxItem xToolboxItem)
		{
			((ActionDesignerWindow)Window.GetWindow(this))?.HighlightText(xToolboxItem.Name);
			e.Handled = true;
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!IiPLIlc8LUf)
		{
			IiPLIlc8LUf = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/x/controls/actiontoolbox.xaml", UriKind.Relative);
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
		int num;
		switch (connectionId)
		{
		default:
			IiPLIlc8LUf = true;
			break;
		case 1:
			ToolboxPanel = (Grid)target;
			break;
		case 2:
			TxtFilter = (TextBox)target;
			TxtFilter.GotFocus += urvLIKI4LtX;
			TxtFilter.TextChanged += JK6LIHeGdgI;
			num = 1;
			if (FX7WPNFJEXIwi0X4oOB6 == null)
			{
				break;
			}
			goto IL_012c;
		case 3:
			BtnFilter = (Button)target;
			BtnFilter.Click += oiaLIsFSmtV;
			break;
		case 4:
			FilterTab = (TabControl)target;
			FilterTab.SelectionChanged += f6rLIblQ5i2;
			break;
		case 5:
			BtnMenu = (DropDownButton)target;
			break;
		case 6:
			MainContextMenu1 = (ContextMenu)target;
			break;
		case 7:
			MenuSortByName = (MenuItem)target;
			MenuSortByName.Click += R9vLIQ6ljUw;
			num = 0;
			if (ke2MG2FJGeWnIweLeQ5b())
			{
				break;
			}
			goto IL_012c;
		case 8:
			MenuSortByUsage = (MenuItem)target;
			MenuSortByUsage.Click += R9vLIQ6ljUw;
			break;
		case 9:
			((MenuItem)target).Click += ypULIxEtSi1;
			break;
		case 10:
			MenuClearFavor = (MenuItem)target;
			MenuClearFavor.Click += qjALIBw28Ey;
			break;
		case 11:
			{
				LbToolbox = (ListBox)target;
				LbToolbox.MouseDoubleClick += aF4LI65r83S;
				LbToolbox.PreviewKeyDown += FkxLIjvnE9p;
				break;
			}
			IL_012c:
			switch (num)
			{
			case 1:
				break;
			}
			break;
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 13:
			((Button)target).Click += dhlLIX3rO75;
			break;
		case 12:
			((Grid)target).MouseDown += qjoLI1WbK2K;
			((Grid)target).MouseMove += Ym1LIke7mUv;
			break;
		}
	}

	static ActionToolbox()
	{
		bkoLIAqLrBA = null;
		NZFLIOZZUd1 = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	[CompilerGenerated]
	private void B02LIn1Eiem(object object_0)
	{
		if (!string.IsNullOrEmpty(TxtFilter.Text))
		{
			FilterTab.SelectedIndex = 0;
		}
		mMILIYgmTLP();
	}

	[CompilerGenerated]
	private void Q6wLI4GFVgE()
	{
		TxtFilter.SelectAll();
	}

	[CompilerGenerated]
	internal static void bswLI5hqeHt(IXProgram ixprogram_0, ref _003C_003Ec__DisplayClass35_0 _003C_003Ec__DisplayClass35_0_0)
	{
		if (ixprogram_0.SubPrograms.HasData())
		{
			foreach (SubProgram subProgram in ixprogram_0.SubPrograms)
			{
				bswLI5hqeHt(subProgram, ref _003C_003Ec__DisplayClass35_0_0);
			}
		}
		if (!ixprogram_0.Steps.HasData())
		{
			return;
		}
		foreach (ActionStep step in ixprogram_0.Steps)
		{
			ck2LIDTvbqC(step, ref _003C_003Ec__DisplayClass35_0_0);
		}
	}

	[CompilerGenerated]
	internal static void ck2LIDTvbqC(ActionStep actionStep_0, ref _003C_003Ec__DisplayClass35_0 _003C_003Ec__DisplayClass35_0_0)
	{
		if (_003C_003Ec__DisplayClass35_0_0.tNcSA7PcPr0.ContainsKey(actionStep_0.StepRunnerKey))
		{
			_003C_003Ec__DisplayClass35_0_0.tNcSA7PcPr0[actionStep_0.StepRunnerKey]++;
		}
		else
		{
			_003C_003Ec__DisplayClass35_0_0.tNcSA7PcPr0.Add(actionStep_0.StepRunnerKey, 1);
		}
		if (actionStep_0.IfSteps.HasData())
		{
			IEnumerator<ActionStep> enumerator = actionStep_0.IfSteps.GetEnumerator();
			if (ke2MG2FJGeWnIweLeQ5b())
			{
				switch (0)
				{
				}
			}
			try
			{
				while (enumerator.MoveNext())
				{
					ck2LIDTvbqC(enumerator.Current, ref _003C_003Ec__DisplayClass35_0_0);
				}
			}
			finally
			{
				enumerator?.Dispose();
			}
		}
		if (!actionStep_0.ElseSteps.HasData())
		{
			return;
		}
		foreach (ActionStep elseStep in actionStep_0.ElseSteps)
		{
			ck2LIDTvbqC(elseStep, ref _003C_003Ec__DisplayClass35_0_0);
		}
	}

	internal static bool ke2MG2FJGeWnIweLeQ5b()
	{
		return FX7WPNFJEXIwi0X4oOB6 == null;
	}
}
