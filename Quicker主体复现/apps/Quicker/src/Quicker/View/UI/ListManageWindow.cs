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
using System.Windows.Input;
using System.Windows.Markup;
using Quicker.Domain;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.UI;
using Quicker.View.Controls;
using wlFuCLYjBIXKFesp7Vo;

namespace Quicker.View.UI;

public class ListManageWindow : Window, IComponentConnector, IStyleConnector, iTHRNJY2ZQQokysD4pN
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec nKpS4DUXa7p;

		public static Func<SimpleOperationItem, string> Wq0S4dRRcsC;

		public static Func<SimpleOperationItem, string> A9HS4oVh9go;

		public static Func<SimpleOperationItem, string> GViS4TUdQIe;

		internal static _003C_003Ec WATuFJWwX2dICnDvTqrU;

		static _003C_003Ec()
		{
			nKpS4DUXa7p = new _003C_003Ec();
		}

		internal string ABcS4nkeBoX(SimpleOperationItem x)
		{
			return x.OriginText;
		}

		internal string nUbS44JkRJO(SimpleOperationItem x)
		{
			return x.Name;
		}

		internal string rjCS45iPMlT(SimpleOperationItem x)
		{
			return x.Name;
		}

		internal static bool wmVI6DWw2ML9J6ROtOPB()
		{
			return WATuFJWwX2dICnDvTqrU == null;
		}
	}

	[CompilerGenerated]
	private bool XVpLPFjfw2c;

	[CompilerGenerated]
	private readonly SmartCollection<SimpleOperationItem> VGrLPUded3j = new SmartCollection<SimpleOperationItem>();

	[CompilerGenerated]
	private bool LabLPldVpQD;

	[CompilerGenerated]
	private string RYZLPiX60Hk;

	private IList<string> n0eLP3IfyoV;

	[CompilerGenerated]
	private CancellationTokenRegistration? O1BLPfcFipX;

	[CompilerGenerated]
	private Func<string, string> SZWLPz4438D;

	internal ListBox LbItems;

	internal Button BtnAdd;

	internal Button BtnEdit;

	internal Button BtnDelete;

	internal Button BtnOrderAZ;

	internal Button BtnOrderZA;

	internal Button BtnReset;

	internal MarkdownHintButton HintButton;

	internal Button BtnOk;

	internal Button BtnCancel;

	internal TextBlock LblNote;

	private bool EVLLEwU6IDe;

	private static ListManageWindow bo1hHdFEo9oVs7xZmTEy;

	public bool IsSuccess
	{
		[CompilerGenerated]
		get
		{
			return XVpLPFjfw2c;
		}
		[CompilerGenerated]
		private set
		{
			XVpLPFjfw2c = value;
		}
	}

	public SmartCollection<SimpleOperationItem> List
	{
		[CompilerGenerated]
		get
		{
			return VGrLPUded3j;
		}
	}

	public bool AllowAdd
	{
		get
		{
			return BtnAdd.IsVisible;
		}
		set
		{
			BtnAdd.Visibility = ((!value) ? Visibility.Collapsed : Visibility.Visible);
		}
	}

	public bool AllowEdit
	{
		get
		{
			return BtnEdit.IsVisible;
		}
		set
		{
			BtnEdit.Visibility = ((!value) ? Visibility.Collapsed : Visibility.Visible);
		}
	}

	public bool AllowDelete
	{
		get
		{
			return BtnDelete.IsVisible;
		}
		set
		{
			BtnDelete.Visibility = ((!value) ? Visibility.Collapsed : Visibility.Visible);
		}
	}

	public bool ParseData
	{
		[CompilerGenerated]
		get
		{
			return LabLPldVpQD;
		}
		[CompilerGenerated]
		set
		{
			LabLPldVpQD = value;
		}
	}

	public string Separator
	{
		[CompilerGenerated]
		get
		{
			return RYZLPiX60Hk;
		}
		[CompilerGenerated]
		set
		{
			RYZLPiX60Hk = value;
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

	public CancellationTokenRegistration? CancellationTokenRegistration
	{
		[CompilerGenerated]
		get
		{
			return O1BLPfcFipX;
		}
		[CompilerGenerated]
		set
		{
			O1BLPfcFipX = value;
		}
	}

	public Func<string, string> TitleDelegate
	{
		[CompilerGenerated]
		get
		{
			return SZWLPz4438D;
		}
		[CompilerGenerated]
		set
		{
			SZWLPz4438D = value;
		}
	}

	public IList<string> GetResult()
	{
		return List.Select(_003C_003Ec.Wq0S4dRRcsC ?? (_003C_003Ec.Wq0S4dRRcsC = _003C_003Ec.nKpS4DUXa7p.ABcS4nkeBoX)).ToList();
	}

	public ListManageWindow(IList<string> data)
	{
		InitializeComponent();
		n0eLP3IfyoV = data.ToList();
		base.Loaded += q4SLPpdWAe2;
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

	private void q4SLPpdWAe2(object sender, RoutedEventArgs e)
	{
		List.Reset(n0eLP3IfyoV.Select(ConvertLine));
		LbItems.ItemsSource = List;
	}

	public SimpleOperationItem ConvertLine(string line)
	{
		if (ParseData)
		{
			return AppHelper.ParseOperationItem(line, true, Separator);
		}
		return new SimpleOperationItem
		{
			Name = ((TitleDelegate == null) ? line : TitleDelegate(line)),
			Key = line,
			OriginText = line
		};
	}

	private void sLMLPBvc1lN(object sender, RoutedEventArgs e)
	{
		IsSuccess = true;
		Close();
	}

	private void jjFLPQ7JfxV(object sender, RoutedEventArgs e)
	{
		if (LbItems.SelectedItems.Count == 0)
		{
			AppHelper.ShowWarning("请先选中要删除的项。");
			return;
		}
		IList selectedItems = LbItems.SelectedItems;
		for (int num = selectedItems.Count - 1; num >= 0; num--)
		{
			List.Remove(selectedItems[num] as SimpleOperationItem);
		}
		int num2 = 0;
		if (!oytuOjFEfuivl1xIhq9M())
		{
			int num3 = default(int);
			num2 = num3;
		}
		switch (num2)
		{
		}
		LbItems.SelectedItems.Clear();
	}

	private void zdrLPjVBtrn(object sender, RoutedEventArgs e)
	{
		Close();
	}

	private void x59LPnflqBD(SimpleOperationItem simpleOperationItem_0)
	{
		string text = "";
		if (!string.IsNullOrEmpty(simpleOperationItem_0.Icon))
		{
			text = text + "[" + simpleOperationItem_0.Icon + "]";
		}
		text += simpleOperationItem_0.Name.Replace("(", "（").Replace(")", "）");
		if (!string.IsNullOrEmpty(simpleOperationItem_0.Description))
		{
			text = text + "(" + simpleOperationItem_0.Description + ")";
		}
		simpleOperationItem_0.OriginText = text + Separator + simpleOperationItem_0.Key;
	}

	private void d7DLP43Of2m(object sender, RoutedEventArgs e)
	{
		if (LbItems.SelectedItems.Count != 1)
		{
			AppHelper.ShowWarning("请选择要编辑的项。");
			return;
		}
		int selectedIndex = LbItems.SelectedIndex;
		int num;
		if (ParseData)
		{
			num = 1;
			if (bo1hHdFEo9oVs7xZmTEy == null)
			{
				goto IL_0043;
			}
			goto IL_0055;
		}
		goto IL_0083;
		IL_0043:
		bool? flag = default(bool?);
		UserInputWindow userInputWindow = default(UserInputWindow);
		switch (num)
		{
		case 1:
			break;
		default:
			if (flag == true)
			{
				List[selectedIndex] = ConvertLine(userInputWindow.TextValue);
			}
			return;
		}
		goto IL_0055;
		IL_0083:
		userInputWindow = new UserInputWindow("text", "", "", List[selectedIndex].OriginText);
		userInputWindow.Owner = this;
		userInputWindow.ShowLocation = ShowWindowLocation.CenterOwner;
		userInputWindow.Title = "编辑列表项";
		userInputWindow.IsRequired = true;
		flag = userInputWindow.ShowDialog();
		num = 0;
		if (!oytuOjFEfuivl1xIhq9M())
		{
			int num2 = default(int);
			num = num2;
		}
		goto IL_0043;
		IL_0055:
		if (List[selectedIndex].Key != List[selectedIndex].OriginText)
		{
			MenuItemEditor menuItemEditor = new MenuItemEditor(List[selectedIndex])
			{
				Owner = Window.GetWindow(this)
			};
			if (menuItemEditor.ShowDialog() == true)
			{
				SimpleOperationItem resultItem = menuItemEditor.ResultItem;
				x59LPnflqBD(resultItem);
				List[selectedIndex] = resultItem;
			}
			return;
		}
		goto IL_0083;
	}

	private void TYKLP5aQDVd(object sender, MouseButtonEventArgs e)
	{
		if (BtnEdit.IsVisible && e.ClickCount == 2)
		{
			e.Handled = true;
			AppHelper.TriggerButtonClick(BtnEdit);
		}
	}

	private void RbKLPDRL9Hj(object sender, RoutedEventArgs e)
	{
		List.Reset(n0eLP3IfyoV.Select(ConvertLine));
		LbItems.ItemsSource = List;
	}

	public void SetNote(string note)
	{
		LblNote.Text = note;
		if (!string.IsNullOrEmpty(note))
		{
			LblNote.Visibility = Visibility.Visible;
		}
		else
		{
			LblNote.Visibility = Visibility.Collapsed;
		}
	}

	private void sRmLPdtx8mo(object sender, RoutedEventArgs e)
	{
		List.Reset(List.OrderBy(_003C_003Ec.A9HS4oVh9go ?? (_003C_003Ec.A9HS4oVh9go = _003C_003Ec.nKpS4DUXa7p.nUbS44JkRJO)).ToList());
	}

	private void ms5LPoU3NI5(object sender, RoutedEventArgs e)
	{
		List.Reset(List.OrderByDescending(_003C_003Ec.GViS4TUdQIe ?? (_003C_003Ec.GViS4TUdQIe = _003C_003Ec.nKpS4DUXa7p.rjCS45iPMlT)).ToList());
	}

	private void w8RLPTynrOl(object sender, RoutedEventArgs e)
	{
		bool flag = pmWLPACAVJU(false);
		while (flag)
		{
			flag = pmWLPACAVJU(flag);
		}
	}

	private (SimpleOperationItem item, bool continueAdd) alZLPM97qCm(bool bool_3)
	{
		if (ParseData)
		{
			MenuItemEditor menuItemEditor = new MenuItemEditor(null);
			menuItemEditor.Owner = Window.GetWindow(this);
			if (menuItemEditor.ShowDialog() == true)
			{
				SimpleOperationItem resultItem = menuItemEditor.ResultItem;
				x59LPnflqBD(resultItem);
				return (item: resultItem, continueAdd: menuItemEditor.ContinueAdd);
			}
		}
		else
		{
			UserInputWindow userInputWindow = new UserInputWindow("text", "请输入要添加的内容", "", "");
			userInputWindow.Owner = this;
			userInputWindow.ShowLocation = ShowWindowLocation.CenterOwner;
			userInputWindow.Title = "添加列表项";
			userInputWindow.IsRequired = true;
			if (userInputWindow.ShowDialog() == true)
			{
				return (item: ConvertLine(userInputWindow.TextValue), continueAdd: false);
			}
		}
		return (item: null, continueAdd: false);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!EVLLEwU6IDe)
		{
			EVLLEwU6IDe = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/ui/listmanagewindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
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
		case 1:
			LbItems = (ListBox)target;
			break;
		default:
			EVLLEwU6IDe = true;
			break;
		case 3:
			BtnAdd = (Button)target;
			num = 1;
			if (!oytuOjFEfuivl1xIhq9M())
			{
				goto IL_0083;
			}
			goto IL_0087;
		case 4:
			BtnEdit = (Button)target;
			num = 0;
			if (bo1hHdFEo9oVs7xZmTEy != null)
			{
				goto IL_0083;
			}
			goto IL_0087;
		case 5:
			BtnDelete = (Button)target;
			BtnDelete.Click += jjFLPQ7JfxV;
			break;
		case 6:
			BtnOrderAZ = (Button)target;
			BtnOrderAZ.Click += sRmLPdtx8mo;
			break;
		case 7:
			BtnOrderZA = (Button)target;
			BtnOrderZA.Click += ms5LPoU3NI5;
			break;
		case 8:
			BtnReset = (Button)target;
			BtnReset.Click += RbKLPDRL9Hj;
			break;
		case 9:
			HintButton = (MarkdownHintButton)target;
			break;
		case 10:
			BtnOk = (Button)target;
			BtnOk.Click += sLMLPBvc1lN;
			break;
		case 11:
			BtnCancel = (Button)target;
			BtnCancel.Click += zdrLPjVBtrn;
			break;
		case 12:
			{
				LblNote = (TextBlock)target;
				break;
			}
			IL_0083:
			num = num2;
			goto IL_0087;
			IL_0087:
			switch (num)
			{
			default:
				BtnEdit.Click += d7DLP43Of2m;
				break;
			case 1:
				BtnAdd.Click += w8RLPTynrOl;
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
		if (connectionId == 2)
		{
			((Grid)target).PreviewMouseDown += TYKLP5aQDVd;
		}
	}

	[CompilerGenerated]
	private bool pmWLPACAVJU(bool bool_3)
	{
		(SimpleOperationItem, bool) tuple = alZLPM97qCm(bool_3);
		if (tuple.Item1 != null)
		{
			if (oytuOjFEfuivl1xIhq9M())
			{
				switch (0)
				{
				}
			}
			int selectedIndex = LbItems.SelectedIndex;
			if (selectedIndex < 0)
			{
				List.Add(tuple.Item1);
			}
			else
			{
				List.Insert(selectedIndex + 1, tuple.Item1);
			}
			int selectedIndex2 = List.IndexOf(tuple.Item1);
			LbItems.SelectedIndex = selectedIndex2;
			return tuple.Item2;
		}
		return false;
	}

	internal static bool oytuOjFEfuivl1xIhq9M()
	{
		return bo1hHdFEo9oVs7xZmTEy == null;
	}
}
