using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Markup;
using Newtonsoft.Json;
using Quicker.Common.QuickActions;
using Quicker.Common.Vm.Share;
using Quicker.Domain;
using Quicker.Public.Extensions;
using Quicker.Utilities._3rd;
using Quicker.Utilities.UI;

namespace Quicker.View.TextCommands;

public class InstallTextCommandWindow : Window, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec BO8SBm74HgT;

		public static Func<TextCommand, bool> DXWSBKQmap1;

		public static Func<TextCommand, string> UxnSBx4F6N7;

		public static Func<string, string> nrbSBrEnFAN;

		private static _003C_003Ec QVCZagWx8Ftr4pokVnVJ;

		static _003C_003Ec()
		{
			BO8SBm74HgT = new _003C_003Ec();
		}

		internal bool ii4SBb9I5A6(TextCommand x)
		{
			return !string.IsNullOrEmpty(x.Group);
		}

		internal string KpjSB67LGPl(TextCommand x)
		{
			return x.Group;
		}

		internal string L1CSBXCex7H(string x)
		{
			return x;
		}

		internal static bool bZRfPVWxRBL1ZZ2aHEhx()
		{
			return QVCZagWx8Ftr4pokVnVJ == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass24_0
	{
		public TextCommand sDHSBBDaphD;

		internal static _003C_003Ec__DisplayClass24_0 nVCT3LWxP42qEw3lfiZG;

		internal bool E0iSBpPQD15(TextCommand x)
		{
			return string.Equals(x.CmdText, sDHSBBDaphD.CmdText, StringComparison.InvariantCultureIgnoreCase);
		}

		internal static bool RXXIOhWxM2Ofla0aF6uh()
		{
			return nVCT3LWxP42qEw3lfiZG == null;
		}
	}

	private readonly SharedTextCommandPackageDto tU0LSjNBUV8;

	private readonly IEnumerable<TextCommand> MtlLSncIVhm;

	[CompilerGenerated]
	private string WGSLS4ZZEQi;

	[CompilerGenerated]
	private IList<TextCommand> kG5LS5OXRYM;

	[CompilerGenerated]
	private SmartCollection<TextCommand> IGJLSDYimwe = new SmartCollection<TextCommand>();

	[CompilerGenerated]
	private SmartCollection<string> wsoLSdfIkRi;

	[CompilerGenerated]
	private readonly string tGlLSoleQhI = "-- 使用原有分组 --";

	internal TextBlock LblNote;

	internal ListView LvTextCommands;

	internal StackPanel PnlSelectGroup;

	internal ComboBox CbGroup;

	internal TextBlock LblInfo;

	internal Button BtnImport;

	internal Button BtnCancel;

	private bool AopLST9FAwL;

	private static InstallTextCommandWindow MEJhjPFeGAWyZhqldQId;

	public string GroupName
	{
		[CompilerGenerated]
		get
		{
			return WGSLS4ZZEQi;
		}
		[CompilerGenerated]
		set
		{
			WGSLS4ZZEQi = value;
		}
	}

	public IList<TextCommand> SelectedTextCommands
	{
		[CompilerGenerated]
		get
		{
			return kG5LS5OXRYM;
		}
		[CompilerGenerated]
		private set
		{
			kG5LS5OXRYM = value;
		}
	}

	public SmartCollection<TextCommand> TextCommands
	{
		[CompilerGenerated]
		get
		{
			return IGJLSDYimwe;
		}
		[CompilerGenerated]
		set
		{
			IGJLSDYimwe = value;
		}
	}

	public SmartCollection<string> CurrentGroups
	{
		[CompilerGenerated]
		get
		{
			return wsoLSdfIkRi;
		}
		[CompilerGenerated]
		set
		{
			wsoLSdfIkRi = value;
		}
	}

	public string UseCurrentGroupStr
	{
		[CompilerGenerated]
		get
		{
			return tGlLSoleQhI;
		}
	}

	public InstallTextCommandWindow(SharedTextCommandPackageDto dto, IEnumerable<TextCommand> _currentCommands)
	{
		tU0LSjNBUV8 = dto;
		MtlLSncIVhm = _currentCommands;
		InitializeComponent();
		base.Loaded += WAYLSKinFR1;
		LvTextCommands.ItemsSource = TextCommands;
		if (_currentCommands != null)
		{
			List<string> list = _currentCommands.Where(_003C_003Ec.DXWSBKQmap1 ?? (_003C_003Ec.DXWSBKQmap1 = _003C_003Ec.BO8SBm74HgT.ii4SBb9I5A6)).Select(_003C_003Ec.UxnSBx4F6N7 ?? (_003C_003Ec.UxnSBx4F6N7 = _003C_003Ec.BO8SBm74HgT.KpjSB67LGPl)).Distinct()
				.OrderBy(_003C_003Ec.nrbSBrEnFAN ?? (_003C_003Ec.nrbSBrEnFAN = _003C_003Ec.BO8SBm74HgT.L1CSBXCex7H))
				.ToList();
			list.Insert(0, UseCurrentGroupStr);
			CurrentGroups = new SmartCollection<string>(list);
			CbGroup.ItemsSource = CurrentGroups;
			CbGroup.SelectedIndex = 0;
		}
		else
		{
			base.Title = "预览文本指令包";
			LblNote.Visibility = Visibility.Collapsed;
			BtnImport.Visibility = Visibility.Collapsed;
			PnlSelectGroup.Visibility = Visibility.Collapsed;
			BtnCancel.Content = "关闭";
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

	private void WAYLSKinFR1(object sender, RoutedEventArgs e)
	{
		TextCommands.Reset(JsonConvert.DeserializeObject<IList<TextCommand>>(tU0LSjNBUV8.Data));
		LvTextCommands.SelectAll();
		rt2LSxWDl9q();
	}

	private void rt2LSxWDl9q()
	{
		if (MtlLSncIVhm == null)
		{
			return;
		}
		BtnImport.IsEnabled = false;
		if (LvTextCommands.SelectedItems.Count == 0)
		{
			LblInfo.Text = "请选择要导入的文本指令。";
			return;
		}
		IList<string> list = new List<string>();
		IEnumerator<TextCommand> enumerator = LvTextCommands.SelectedItems.Cast<TextCommand>().GetEnumerator();
		int num = 0;
		if (MEJhjPFeGAWyZhqldQId != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		try
		{
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass24_0 _003C_003Ec__DisplayClass24_ = new _003C_003Ec__DisplayClass24_0();
				_003C_003Ec__DisplayClass24_.sDHSBBDaphD = enumerator.Current;
				if (MtlLSncIVhm.Any(_003C_003Ec__DisplayClass24_.E0iSBpPQD15))
				{
					list.Add(_003C_003Ec__DisplayClass24_.sDHSBBDaphD.CmdText);
				}
			}
		}
		finally
		{
			enumerator?.Dispose();
		}
		if (list.HasData())
		{
			LblInfo.Text = "如下的文本指令您已使用：" + string.Join(",", list);
			BtnImport.IsEnabled = false;
		}
		else
		{
			LblInfo.Text = "";
			BtnImport.IsEnabled = true;
		}
	}

	private void kxnLSrTaF2k(object sender, RoutedEventArgs e)
	{
		Close();
	}

	private void EmaLSpQu6GY(object sender, RoutedEventArgs e)
	{
		GroupName = CbGroup.Text ?? "";
		SelectedTextCommands = LvTextCommands.SelectedItems.Cast<TextCommand>().ToList();
		{
			base.DialogResult = true;
		}
	}

	private void w5cLSB1Vgdb(object sender, SelectionChangedEventArgs e)
	{
		rt2LSxWDl9q();
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!AopLST9FAwL)
		{
			AopLST9FAwL = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/textcommands/installtextcommandwindow.xaml", UriKind.Relative);
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
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			AopLST9FAwL = true;
			break;
		case 1:
			LblNote = (TextBlock)target;
			break;
		case 2:
			LvTextCommands = (ListView)target;
			LvTextCommands.SelectionChanged += w5cLSB1Vgdb;
			break;
		case 3:
			PnlSelectGroup = (StackPanel)target;
			break;
		case 4:
			CbGroup = (ComboBox)target;
			break;
		case 5:
			LblInfo = (TextBlock)target;
			break;
		case 6:
			BtnImport = (Button)target;
			BtnImport.Click += EmaLSpQu6GY;
			break;
		case 7:
		{
			BtnCancel = (Button)target;
			BtnCancel.Click += kxnLSrTaF2k;
			int num = 0;
			if (MEJhjPFeGAWyZhqldQId != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			break;
		}
		}
	}

	static InstallTextCommandWindow()
	{
	}

	internal static bool NRrGfCFe0my7rkotN9ws()
	{
		return MEJhjPFeGAWyZhqldQId == null;
	}

	internal static void Vsu91hFeOlbvV1h0CRou()
	{
	}
}
