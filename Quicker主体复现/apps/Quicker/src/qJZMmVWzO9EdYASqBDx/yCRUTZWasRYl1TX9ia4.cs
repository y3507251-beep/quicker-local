using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using log4net;
using qcrGlGMkgcYtX0leyxF;
using Quicker.Domain;
using Quicker.Domain.Actions.Runtime;
using Quicker.Modules.Searching;
using Quicker.Public.Entities;
using Quicker.Public.Extensions;
using Quicker.Public.Searching;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.View;
using vjGJX2WpUfGgQtNkVc7;
using WeCGyoWZb5VuoKl91Wh;
using Yf8A0Tj55ce1jngb1h3;

namespace qJZMmVWzO9EdYASqBDx;

internal class yCRUTZWasRYl1TX9ia4 : kI86NbWLfJKJc0tGQJY
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass3_0
	{
		public string RSXvHeZN4rY;

		public yCRUTZWasRYl1TX9ia4 UWGvHYCRuGB;

		public CancellationToken LTOvHIabfiD;

		public int BnvvHWfY0Mk;

		public int w9fvHk1bWOQ;

		private static _003C_003Ec__DisplayClass3_0 bDHel8cgtM5roDjGJLDV;

		internal void j7YvHhFK63V()
		{
			try
			{
				IList<SearchResultItem> results = gIh8AyjqAySmmxFMtv4.TystekJOcgU(RSXvHeZN4rY, UWGvHYCRuGB.qPitNriGxqJ, LTOvHIabfiD, BnvvHWfY0Mk, w9fvHk1bWOQ);
				if (!LTOvHIabfiD.IsCancellationRequested)
				{
					UWGvHYCRuGB.qPitNriGxqJ.SetResults(results, BnvvHWfY0Mk);
				}
			}
			catch (OperationCanceledException)
			{
			}
			catch (Exception ex2)
			{
				WGktNprHdnd.Warn("执行查询出错：" + ex2.Message, ex2);
			}
		}

		internal static bool uyAMwacgShjFirIw8JQo()
		{
			return bDHel8cgtM5roDjGJLDV == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass7_0
	{
		public SearchResultItem GtDvHsod2PZ;

		public string NhRvHHL4IJn;

		public SearchTriggerType WlOvH1vKViC;

		private static _003C_003Ec__DisplayClass7_0 oKj3RicgTA3gVffqLHDc;

		internal void WBFvHGj4kn9()
		{
			Thread.Sleep(150);
			if (GtDvHsod2PZ.SubmitAction != null)
			{
				GtDvHsod2PZ.SubmitAction();
			}
			else
			{
				gIh8AyjqAySmmxFMtv4.PyWteX4rdk9(GtDvHsod2PZ, NhRvHHL4IJn, WlOvH1vKViC);
			}
		}

		internal static bool kkRDjYcgmqpGowD9KYEe()
		{
			return oKj3RicgTA3gVffqLHDc == null;
		}
	}

	private readonly SearchWindow qPitNriGxqJ;

	private static readonly ILog WGktNprHdnd;

	private SearchResultItem Kp2tNBITrbs;

	internal static yCRUTZWasRYl1TX9ia4 eJAwbyQA8uWxBLOtiYYX;

	public yCRUTZWasRYl1TX9ia4(SearchWindow searchWindow_0)
	{
		qPitNriGxqJ = searchWindow_0;
	}

	public void LEmMjgMin79(string string_0, CancellationToken cancellationToken_0, int int_0, int int_1)
	{
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
		_003C_003Ec__DisplayClass3_.RSXvHeZN4rY = string_0;
		_003C_003Ec__DisplayClass3_.UWGvHYCRuGB = this;
		_003C_003Ec__DisplayClass3_.LTOvHIabfiD = cancellationToken_0;
		_003C_003Ec__DisplayClass3_.BnvvHWfY0Mk = int_0;
		_003C_003Ec__DisplayClass3_.w9fvHk1bWOQ = int_1;
		Task.Run((Action)_003C_003Ec__DisplayClass3_.j7YvHhFK63V, _003C_003Ec__DisplayClass3_.LTOvHIabfiD);
	}

	public void FA5MjViPItw(SearchResultItem searchResultItem_1, string string_0, SearchTriggerType searchTriggerType_0, SearchWindow searchWindow_0)
	{
		if (searchResultItem_1 == null)
		{
			if (string.IsNullOrWhiteSpace(string_0))
			{
				return;
			}
			try
			{
				string text = AppState.HHxtaMaoqJr().SearchSettings.DefaultSearchProcessor;
				if (string.IsNullOrEmpty(text))
				{
					text = "%s";
				}
				if (!text.Contains("%s"))
				{
					if (!text.Contains("%[s]"))
					{
						try
						{
							AppState.AppServer.ExecuteActionByIdOrName(text, null, false, false, false, string_0, ActionTrigger.SearchWindow, new ActionExtraContextData
							{
								Text = string_0
							});
							return;
						}
						catch (Exception ex)
						{
							AppHelper.ShowWarning("执行默认搜索动作出错：" + ex.Message);
							return;
						}
					}
					if (SBhPF7QARA6CwAtpY5J6())
					{
						switch (0)
						{
						}
					}
				}
				string text2 = text.Replace("%s", string_0, StringComparison.OrdinalIgnoreCase).Replace("%[s]", string_0.EscapeUriDataString());
				try
				{
					AppHelper.ExecuteText(text2);
					return;
				}
				catch (Exception ex2)
				{
					AppHelper.ShowWarning("执行出错：" + ex2.Message);
					return;
				}
			}
			catch (Exception ex3)
			{
				AppHelper.ShowWarning("执行命令(" + string_0 + ")出错：" + ex3.Message);
				return;
			}
		}
		MTltNxIbS6g(searchResultItem_1, string_0, searchTriggerType_0, searchWindow_0.ActiveProcessBeforeShow);
	}

	public ContextMenu wZJMjMr3ySd(SearchResultItem searchResultItem_1)
	{
		int num = 2;
		while (searchResultItem_1 != null)
		{
			int num2 = 1;
			if (SBhPF7QARA6CwAtpY5J6())
			{
				goto IL_0018;
			}
			goto IL_0041;
			IL_0018:
			if (searchResultItem_1.QueryContext == null)
			{
				break;
			}
			if (searchResultItem_1.QueryContext.PluginItem == null)
			{
				num2 = 0;
				if (!SBhPF7QARA6CwAtpY5J6())
				{
					num2 = num;
				}
				goto IL_0041;
			}
			Kp2tNBITrbs = searchResultItem_1;
			if (searchResultItem_1.QueryContext.PluginItem.Plugin is IRightClickHandler rightClickHandler && rightClickHandler.RightClickHandler(searchResultItem_1, qPitNriGxqJ).HasValue)
			{
				return null;
			}
			ContextMenu contextMenu = new ContextMenu();
			SearchPlugin plugin = searchResultItem_1.QueryContext.PluginItem.Plugin;
			if (plugin is IContextMenuBuilder contextMenuBuilder)
			{
				contextMenuBuilder.BuildContextMenu(searchResultItem_1, contextMenu, qPitNriGxqJ);
			}
			if (plugin is IContextMenuItemsProvider contextMenuItemsProvider)
			{
				IList<MenuItemInfo> contextMenuItems = contextMenuItemsProvider.GetContextMenuItems(searchResultItem_1);
				if (contextMenuItems.HasData())
				{
					foreach (MenuItemInfo item in contextMenuItems)
					{
						ItemCollection items = contextMenu.Items;
						string title = item.Title;
						string tooltip = item.Tooltip;
						string icon = item.Icon;
						ICommand command = item.Command;
						MenuItem menuItem = AppHelper.AddMenuItem(items, title, tooltip, icon, null, null, null, command);
						if (item.Tag != null)
						{
							menuItem.Tag = item.Tag;
						}
					}
				}
			}
			if (contextMenu.Items.Count == 0 && !string.IsNullOrEmpty(searchResultItem_1.TextData))
			{
				string textDataType = searchResultItem_1.TextDataType;
				Tm2cvBWRLSsbp7ULmAF.x5Mtum8HnTA(searchResultItem_1.TextData, contextMenu, qPitNriGxqJ);
			}
			if (contextMenu.Items.Count == 0)
			{
				return null;
			}
			return contextMenu;
			IL_0041:
			switch (num2)
			{
			case 1:
				break;
			case 2:
				continue;
			default:
				goto end_IL_0057;
			}
			goto IL_0018;
			continue;
			end_IL_0057:
			break;
		}
		return null;
	}

	private void MTltNxIbS6g(SearchResultItem searchResultItem_1, string string_0, SearchTriggerType searchTriggerType_0, string string_1)
	{
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
		_003C_003Ec__DisplayClass7_.GtDvHsod2PZ = searchResultItem_1;
		_003C_003Ec__DisplayClass7_.WlOvH1vKViC = searchTriggerType_0;
		_003C_003Ec__DisplayClass7_.NhRvHHL4IJn = string_0 ?? "";
		qPitNriGxqJ.AfterActionSelected();
		gIh8AyjqAySmmxFMtv4.tuPteKqOI5r(_003C_003Ec__DisplayClass7_.GtDvHsod2PZ, string_1);
		GaZT3MMHZ3eZxDOySux.ReZLM3wimyT(_003C_003Ec__DisplayClass7_.WBFvHGj4kn9, "search_result_item:" + _003C_003Ec__DisplayClass7_.GtDvHsod2PZ.Title);
	}

	static yCRUTZWasRYl1TX9ia4()
	{
		WGktNprHdnd = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool SBhPF7QARA6CwAtpY5J6()
	{
		return eJAwbyQA8uWxBLOtiYYX == null;
	}
}
