using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using Microsoft.Win32;
using Quicker.Domain;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.UI;

namespace Quicker.View.Settings;

public class QuickTextEditorWindow : Window, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec gN1SQli878q;

		public static Func<QuickTextItem, bool> QRASQiJ60oA;

		public static Func<QuickTextItem, bool> y3gSQ3NrwsQ;

		public static Func<QuickTextItem, string> YxtSQf4qtD0;

		public static Func<QuickTextItem, bool> tdMSQzxNrrr;

		public static Func<QuickTextItem, string> h4YSjwQoWuJ;

		internal static _003C_003Ec wtumXfWIYwGnCipAp8m2;

		static _003C_003Ec()
		{
			gN1SQli878q = new _003C_003Ec();
		}

		internal bool elPSQMcmDSe(QuickTextItem x)
		{
			return !x.IsEmpty;
		}

		internal bool P4lSQA4lJrs(QuickTextItem x)
		{
			return !x.IsEmpty;
		}

		internal string p0dSQOPCg2W(QuickTextItem x)
		{
			return x.ToDataString();
		}

		internal bool skGSQFQFVeL(QuickTextItem x)
		{
			return !x.IsEmpty;
		}

		internal string zorSQUyVsef(QuickTextItem x)
		{
			return x.Title;
		}

		internal static bool zjWPP7WI8uCWHr4ukp3L()
		{
			return wtumXfWIYwGnCipAp8m2 == null;
		}
	}

	[CompilerGenerated]
	private readonly SmartCollection<QuickTextItem> L4QL244YnTf = new SmartCollection<QuickTextItem>();

	[CompilerGenerated]
	private string t8yL25mBN7K;

	[CompilerGenerated]
	private bool dwLL2D5CuDX;

	internal Button BtnNew;

	internal Button BtnOpen;

	internal Button BtnSort;

	internal Button BtnHelp;

	internal DataGrid TheGrid;

	private bool fNKL2dfEET0;

	internal static QuickTextEditorWindow KNTIIsFe4S5O6r5cN9pd;

	public SmartCollection<QuickTextItem> Items
	{
		[CompilerGenerated]
		get
		{
			return L4QL244YnTf;
		}
	}

	public string FilePath
	{
		[CompilerGenerated]
		get
		{
			return t8yL25mBN7K;
		}
		[CompilerGenerated]
		set
		{
			t8yL25mBN7K = value;
		}
	}

	public bool HasChanged
	{
		[CompilerGenerated]
		get
		{
			return dwLL2D5CuDX;
		}
		[CompilerGenerated]
		set
		{
			dwLL2D5CuDX = value;
		}
	}

	public QuickTextEditorWindow(string filePath = null)
	{
		InitializeComponent();
		TheGrid.CellEditEnding += TYFL2HL0w7j;
		TheGrid.ItemsSource = Items;
		Items.CollectionChanged += pTCL2GYDHsE;
		base.Closing += iOUL2kCtF3L;
		if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
		{
			try
			{
				FilePath = filePath;
				GbAL2KmpC9s();
				BtnNew.Visibility = Visibility.Collapsed;
				BtnOpen.Visibility = Visibility.Collapsed;
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("无法打开数据文件：" + filePath + "\r\n" + ex.Message);
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

	private void iOUL2kCtF3L(object sender, CancelEventArgs e)
	{
		if (!HasChanged)
		{
			return;
		}
		switch (MessageBoxHelper.Show(this, "数据已改变，是否要保存？", "文本片段管理", MessageBoxButton.YesNoCancel))
		{
		case MessageBoxResult.Yes:
			if (!aWeL2pKwVxr())
			{
				e.Cancel = true;
			}
			break;
		case MessageBoxResult.Cancel:
			e.Cancel = true;
			break;
		}
	}

	private void pTCL2GYDHsE(object sender, NotifyCollectionChangedEventArgs e)
	{
		kh1L2sjfT1h();
	}

	private void kh1L2sjfT1h()
	{
		RVaL21mMSZd();
		HasChanged = true;
		jNfL2BlIdyJ();
	}

	private void TYFL2HL0w7j(object sender, DataGridCellEditEndingEventArgs e)
	{
		if (e.EditAction == DataGridEditAction.Commit)
		{
			kh1L2sjfT1h();
		}
	}

	private void RVaL21mMSZd()
	{
	}

	private void VgAL2b2s57W(object sender, CanExecuteRoutedEventArgs e)
	{
		e.CanExecute = true;
	}

	private void P72L26x2YZK(object sender, ExecutedRoutedEventArgs e)
	{
		if (HasChanged)
		{
			MessageBoxResult messageBoxResult = MessageBoxHelper.Show(this, "数据已改变，是否要保存？", "文本片段管理", MessageBoxButton.YesNoCancel);
			switch (messageBoxResult)
			{
			case MessageBoxResult.Yes:
				if (!aWeL2pKwVxr())
				{
					return;
				}
				break;
			default:
			{
				int num = 0;
				if (KNTIIsFe4S5O6r5cN9pd != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				if (messageBoxResult == MessageBoxResult.Cancel)
				{
					return;
				}
				break;
			}
			case MessageBoxResult.No:
				break;
			}
		}
		Items.Clear();
		FilePath = "";
		HasChanged = true;
	}

	private void yf5L2XaooEX(object sender, CanExecuteRoutedEventArgs e)
	{
		e.CanExecute = true;
	}

	private void YIEL2mji8do(object sender, ExecutedRoutedEventArgs e)
	{
		if (HasChanged && Items.Any(_003C_003Ec.QRASQiJ60oA ?? (_003C_003Ec.QRASQiJ60oA = _003C_003Ec.gN1SQli878q.elPSQMcmDSe)))
		{
			switch (MessageBoxHelper.Show(this, "数据已改变，是否要保存？", "文本片段管理", MessageBoxButton.YesNoCancel))
			{
			case MessageBoxResult.Yes:
				if (!aWeL2pKwVxr())
				{
					return;
				}
				break;
			case MessageBoxResult.Cancel:
				return;
			}
		}
		OpenFileDialog openFileDialog = new OpenFileDialog();
		if (KNTIIsFe4S5O6r5cN9pd == null)
		{
			switch (0)
			{
			}
		}
		openFileDialog.Filter = "文本文件(*.txt)|*.txt";
		if (openFileDialog.ShowDialog() == true)
		{
			FilePath = openFileDialog.FileName;
			try
			{
				GbAL2KmpC9s();
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("打开文件出错，可能不是合法的文本片段数据文件。" + ex.Message);
			}
		}
	}

	private void GbAL2KmpC9s()
	{
		string[] array = File.ReadAllLines(FilePath);
		List<QuickTextItem> list = new List<QuickTextItem>();
		int num = 0;
		string[] array2 = array;
		int num2 = 0;
		int num4 = default(int);
		while (true)
		{
			if (num2 < array2.Length)
			{
				QuickTextItem quickTextItem = QuickTextItem.FromDataString(array2[num2]);
				if (quickTextItem == null)
				{
					num++;
					if (num > 1)
					{
						break;
					}
				}
				else
				{
					list.Add(quickTextItem);
				}
				num2++;
				continue;
			}
			Items.Reset(list);
			int num3 = 0;
			if (KNTIIsFe4S5O6r5cN9pd != null)
			{
				num3 = num4;
			}
			switch (num3)
			{
			}
			HasChanged = false;
			jNfL2BlIdyJ();
			return;
		}
		throw new Exception("数据文件格式不合法。");
	}

	private void RtrL2xXOnvl(object sender, CanExecuteRoutedEventArgs e)
	{
		e.CanExecute = HasChanged;
	}

	private void nu8L2rZZFI2(object sender, ExecutedRoutedEventArgs e)
	{
		aWeL2pKwVxr();
	}

	private bool aWeL2pKwVxr()
	{
		TheGrid.CommitEdit(DataGridEditingUnit.Row, true);
		if (string.IsNullOrEmpty(FilePath))
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Title = "保存文件";
			saveFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
			if (A96iLXFehoQYO38dVgu9())
			{
				switch (0)
				{
				}
			}
			saveFileDialog.DefaultExt = "txt";
			if (saveFileDialog.ShowDialog() != true)
			{
				return false;
			}
			FilePath = saveFileDialog.FileName;
		}
		try
		{
			File.WriteAllText(FilePath, pXqL2QDI0QI());
			HasChanged = false;
			jNfL2BlIdyJ();
			return true;
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning(ex.Message);
			return false;
		}
	}

	private void jNfL2BlIdyJ()
	{
		if (!string.IsNullOrEmpty(FilePath))
		{
			base.Title = FilePath;
		}
	}

	private string pXqL2QDI0QI()
	{
		return string.Join("\r\n", Items.Where(_003C_003Ec.y3gSQ3NrwsQ ?? (_003C_003Ec.y3gSQ3NrwsQ = _003C_003Ec.gN1SQli878q.P4lSQA4lJrs)).Select(_003C_003Ec.YxtSQf4qtD0 ?? (_003C_003Ec.YxtSQf4qtD0 = _003C_003Ec.gN1SQli878q.p0dSQOPCg2W)));
	}

	private void EA1L2jCSsMO(object sender, RoutedEventArgs e)
	{
		List<QuickTextItem> list = Items.Where(_003C_003Ec.tdMSQzxNrrr ?? (_003C_003Ec.tdMSQzxNrrr = _003C_003Ec.gN1SQli878q.skGSQFQFVeL)).OrderBy(_003C_003Ec.h4YSjwQoWuJ ?? (_003C_003Ec.h4YSjwQoWuJ = _003C_003Ec.gN1SQli878q.zorSQUyVsef)).ToList();
		list.Add(new QuickTextItem());
		Items.Reset(list);
		HasChanged = true;
		jNfL2BlIdyJ();
	}

	private void jHvL2nFC1LN(object sender, RoutedEventArgs e)
	{
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!fNKL2dfEET0)
		{
			fNKL2dfEET0 = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/settings/quicktexteditorwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			fNKL2dfEET0 = true;
			break;
		case 1:
			((CommandBinding)target).CanExecute += VgAL2b2s57W;
			if (KNTIIsFe4S5O6r5cN9pd == null)
			{
				switch (0)
				{
				}
			}
			((CommandBinding)target).Executed += P72L26x2YZK;
			break;
		case 2:
			((CommandBinding)target).CanExecute += yf5L2XaooEX;
			((CommandBinding)target).Executed += YIEL2mji8do;
			break;
		case 3:
			((CommandBinding)target).CanExecute += RtrL2xXOnvl;
			((CommandBinding)target).Executed += nu8L2rZZFI2;
			break;
		case 4:
			BtnNew = (Button)target;
			break;
		case 5:
			BtnOpen = (Button)target;
			break;
		case 6:
			BtnSort = (Button)target;
			BtnSort.Click += EA1L2jCSsMO;
			break;
		case 7:
			BtnHelp = (Button)target;
			BtnHelp.Click += jHvL2nFC1LN;
			break;
		case 8:
			TheGrid = (DataGrid)target;
			break;
		}
	}

	internal static bool A96iLXFehoQYO38dVgu9()
	{
		return KNTIIsFe4S5O6r5cN9pd == null;
	}
}
