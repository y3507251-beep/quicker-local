using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;
using Quicker.Domain.Services;
using Quicker.Domain.SQL.Entities;
using Quicker.Utilities;

namespace Quicker.View.Actions.ActionHistoryControls;

public class LocalBackupItemsControl : UserControl, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec yqqSTJ47pEW;

		public static Func<ActionHistoryItem, string> Qp0ST0FU0RL;

		internal static _003C_003Ec GkAiaMWC5WsQWPLv3UtH;

		static _003C_003Ec()
		{
			yqqSTJ47pEW = new _003C_003Ec();
		}

		internal string xvdSTNwMXsm(ActionHistoryItem x)
		{
			return x.RowId;
		}

		internal static bool Es8SDDWCY9ge3tXffFC2()
		{
			return GkAiaMWC5WsQWPLv3UtH == null;
		}
	}

	private SQLDataMgr LFYL9xS5w7H;

	private string SngL9rYIMB2;

	private ICollectionView m11L9pWyLUq;

	internal Label LblSummary;

	internal CheckBox ChkShowAutoSaved;

	internal ListView LbHistory;

	internal Button BtnDeleteAll;

	internal Button BtnDelete;

	internal Button BtnSelect;

	internal Button BtnCancel;

	private bool wg7L9BTVy09;

	internal static LocalBackupItemsControl tM6rx1FdND5qtOM6hJtl;

	public LocalBackupItemsControl()
	{
		InitializeComponent();
	}

	public void Load(SQLDataMgr sqlDataMgr, string actionId)
	{
		LFYL9xS5w7H = sqlDataMgr;
		SngL9rYIMB2 = actionId;
		try
		{
			FDbL91BjlmD();
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("加载数据出错：" + ex.Message, true);
		}
	}

	private void FDbL91BjlmD()
	{
		IList<ActionHistoryItem> actionHistoryItemList = LFYL9xS5w7H.GetActionHistoryItemList(SngL9rYIMB2);
		m11L9pWyLUq = CollectionViewSource.GetDefaultView(actionHistoryItemList);
		m11L9pWyLUq.Filter = DDwL9KBCYdS;
		LbHistory.ItemsSource = m11L9pWyLUq;
		LblSummary.Content = $"共有 {actionHistoryItemList.Count} 个历史版本";
	}

	private void klYL9bXWPQN(object sender, RoutedEventArgs e)
	{
		m11L9pWyLUq.Refresh();
	}

	private void c6FL96iR2sd(object sender, RoutedEventArgs e)
	{
		if (LbHistory.SelectedItem == null)
		{
			AppHelper.ShowWarning("请选择要加载的版本。", true);
			return;
		}
		if (LbHistory.SelectedItems.Count > 1)
		{
			AppHelper.ShowWarning("只能选择1项。", true);
			return;
		}
		ActionHistoryItem actionHistoryItem = (ActionHistoryItem)LbHistory.SelectedItem;
		ActionHistoryItem actionHistoryItem2 = LFYL9xS5w7H.GetActionHistoryItem(actionHistoryItem.RowId);
		if (J19kF3Fd9CNwruRU2aEp())
		{
			switch (0)
			{
			}
		}
		if (actionHistoryItem2 != null)
		{
			((ActionHistoryWindow)Window.GetWindow(this)).SelectItem(actionHistoryItem2.GetAction());
		}
		else
		{
			AppHelper.ShowWarning("未能获得数据。");
		}
	}

	private void Y4tL9XFcAPm(object sender, RoutedEventArgs e)
	{
		List<ActionHistoryItem> list = LbHistory.SelectedItems.Cast<ActionHistoryItem>().ToList();
		if (list != null && list.Count != 0)
		{
			if (AppHelper.Confirm($"您确认删除 {list.Count()} 条记录么？"))
			{
				try
				{
					int num = LFYL9xS5w7H.DeleteActionHistory(list.Select(_003C_003Ec.Qp0ST0FU0RL ?? (_003C_003Ec.Qp0ST0FU0RL = _003C_003Ec.yqqSTJ47pEW.xvdSTNwMXsm)).ToList());
					FDbL91BjlmD();
					AppHelper.ShowInformation($"共删除 {num} 行");
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("删除出错：" + ex.Message + "。");
				}
			}
		}
		else
		{
			AppHelper.ShowWarning("请选择要删除的条目。");
		}
	}

	private void M0BL9muPiFn(object sender, RoutedEventArgs e)
	{
		if (AppHelper.Confirm("您确认删除全部记录么？"))
		{
			try
			{
				int num = LFYL9xS5w7H.DeleteActionHistoryAll(SngL9rYIMB2);
				FDbL91BjlmD();
				AppHelper.ShowInformation($"共删除 {num} 行");
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("删除出错：" + ex.Message + "。");
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!wg7L9BTVy09)
		{
			wg7L9BTVy09 = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/actions/actionhistorycontrols/localbackupitemscontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			wg7L9BTVy09 = true;
			break;
		case 1:
		{
			LblSummary = (Label)target;
			int num = 0;
			if (!J19kF3Fd9CNwruRU2aEp())
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
			ChkShowAutoSaved = (CheckBox)target;
			ChkShowAutoSaved.Click += klYL9bXWPQN;
			break;
		case 3:
			LbHistory = (ListView)target;
			break;
		case 4:
			BtnDeleteAll = (Button)target;
			BtnDeleteAll.Click += M0BL9muPiFn;
			break;
		case 5:
			BtnDelete = (Button)target;
			BtnDelete.Click += Y4tL9XFcAPm;
			break;
		case 6:
			BtnSelect = (Button)target;
			BtnSelect.Click += c6FL96iR2sd;
			break;
		case 7:
			BtnCancel = (Button)target;
			break;
		}
	}

	[CompilerGenerated]
	private bool DDwL9KBCYdS(object object_0)
	{
		if (ChkShowAutoSaved.IsChecked == true)
		{
			return true;
		}
		return (object_0 as ActionHistoryItem).BackupType == ActionBackupType.Manual;
	}

	internal static bool J19kF3Fd9CNwruRU2aEp()
	{
		return tM6rx1FdND5qtOM6hJtl == null;
	}
}
