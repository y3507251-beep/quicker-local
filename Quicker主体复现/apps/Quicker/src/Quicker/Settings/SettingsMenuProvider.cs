using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using FontAwesome5;
using IOn6RhAJdTUbfGy6gwn;
using Quicker.Settings.Code;
using Quicker.Settings.Pages;
using Quicker.Settings.Pages.About;
using Quicker.Settings.Pages.Basic;
using Quicker.Settings.Pages.BasicTriggers;
using Quicker.Settings.Pages.BlackList;
using Quicker.Settings.Pages.ContextMenus;
using Quicker.Settings.Pages.Panel;
using Quicker.Settings.Pages.Tools;
using Quicker.Settings.Pages.Triggers;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Pinyin;
using t8SGKhhgLWTgeqjGcrq;

namespace Quicker.Settings;

public static class SettingsMenuProvider
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec LqYvVyZRlbB;

		public static Func<SettingMenuItem, IEnumerable<SettingPageInfo>> WMjvV8Rk3v4;

		public static Func<KeyValuePair<SettingPageInfo, int>, int> D7TvVaEhdix;

		public static Func<KeyValuePair<SettingPageInfo, int>, SettingPageInfo> zsavV72Xigt;

		private static _003C_003Ec R8go7DcN8ZY2YtgI8ck7;

		static _003C_003Ec()
		{
			LqYvVyZRlbB = new _003C_003Ec();
		}

		internal IEnumerable<SettingPageInfo> TFwvVCxm4kK(SettingMenuItem x)
		{
			return x.Pages;
		}

		internal int YQqvVPXBf3C(KeyValuePair<SettingPageInfo, int> x)
		{
			return x.Value;
		}

		internal SettingPageInfo NmDvVEMlX5a(KeyValuePair<SettingPageInfo, int> x)
		{
			return x.Key;
		}

		internal static bool JpaIcqcNRTDIKEstYx3Q()
		{
			return R8go7DcN8ZY2YtgI8ck7 == null;
		}
	}

	private static readonly IList<SettingMenuItem> ay4j9Qhhmp;

	private static readonly IList<SettingMenuCategoryInfo> YrQjhLPsCy;

	internal static object vsqmEsSK8iL8t4telTq;

	public static IList<SettingMenuItem> MenuItems => ay4j9Qhhmp;

	public static IList<SettingMenuCategoryInfo> Categories => YrQjhLPsCy;

	public static IEnumerable<SettingPageInfo> AllPages => ay4j9Qhhmp.SelectMany(_003C_003Ec.WMjvV8Rk3v4 ?? (_003C_003Ec.WMjvV8Rk3v4 = _003C_003Ec.LqYvVyZRlbB.TFwvVCxm4kK));

	static SettingsMenuProvider()
	{
		ay4j9Qhhmp = new SmartCollection<SettingMenuItem>();
		YrQjhLPsCy = new List<SettingMenuCategoryInfo>();
		mcGjVtIcTA();
		S7BjZ6pQdP();
	}

	private static void mcGjVtIcTA()
	{
		YrQjhLPsCy.Add(new SettingMenuCategoryInfo
		{
			Category = SettingMenuCategory.Basic,
			Icon = EFontAwesomeIcon.Light_SlidersH,
			Title = "基础设置"
		});
		YrQjhLPsCy.Add(new SettingMenuCategoryInfo
		{
			Category = SettingMenuCategory.Features,
			Icon = EFontAwesomeIcon.Light_Shapes,
			Title = "辅助功能"
		});
		YrQjhLPsCy.Add(new SettingMenuCategoryInfo
		{
			Category = SettingMenuCategory.Others,
			Icon = EFontAwesomeIcon.Light_Tools,
			Title = "工具"
		});
	}

	private static void S7BjZ6pQdP()
	{
		ay4j9Qhhmp.Add(new SettingMenuItem
		{
			Icon = EFontAwesomeIcon.Light_Cog,
			Title = "常规",
			Description = "自动启动、鼠标挂钩、版本等",
			KeyWords = "",
			Category = SettingMenuCategory.Basic,
			Pages = new List<SettingPageInfo>
			{
				new SettingPageInfo
				{
					Id = SettingPageId.BasicInfo,
					Title = "常规",
					FullTitle = "常规选项设置",
					Icon = EFontAwesomeIcon.Light_Cog,
					Description = "常规选项设置",
					IsAdvanced = false,
					EditControl = typeof(BasicSettings),
					KeyWords = ""
				}
			}
		});
		ay4j9Qhhmp.Add(new SettingMenuItem
		{
			Icon = EFontAwesomeIcon.Light_RectanglePortrait,
			Title = "弹出面板",
			Description = "面板弹出方式及界面选项",
			KeyWords = "",
			Category = SettingMenuCategory.Basic,
			Pages = new List<SettingPageInfo>
			{
				new SettingPageInfo
				{
					Id = SettingPageId.PanelPopupSettings,
					Title = "弹出面板",
					Icon = EFontAwesomeIcon.Light_RocketLaunch,
					Description = "面板窗口的触发方式",
					IsAdvanced = false,
					EditControl = typeof(PanelPopupSettings)
				},
				new SettingPageInfo
				{
					Id = SettingPageId.PanelTriggerKeySettings,
					Title = "动作触发按键",
					Icon = EFontAwesomeIcon.Light_Keyboard,
					Description = "键盘方式弹出后，使用按键触发动作",
					IsAdvanced = false,
					EditControl = typeof(PanelTriggerKeySettings)
				}
			}
		});
		int num = 0;
		if (pWNUC9SBRn3D62VduNu())
		{
			goto IL_0479;
		}
		goto IL_138a;
		IL_0479:
		ay4j9Qhhmp.Add(new SettingMenuItem
		{
			Icon = EFontAwesomeIcon.Light_Keyboard,
			Title = "功能快捷键",
			Description = "Quicker功能快捷键",
			KeyWords = "",
			Category = SettingMenuCategory.Basic,
			Pages = new List<SettingPageInfo>
			{
				new SettingPageInfo
				{
					Id = SettingPageId.FunctionHotkeys,
					Title = "功能快捷键",
					Icon = EFontAwesomeIcon.Light_Keyboard,
					Description = "设置用于控制Quicker功能的快捷键",
					IsAdvanced = false,
					EditControl = typeof(FunctionHotkeySettings)
				}
			}
		});
		ay4j9Qhhmp.Add(new SettingMenuItem
		{
			Icon = EFontAwesomeIcon.Light_Ban,
			Title = "黑名单",
			Description = "在某些应用上停止使用Quicker",
			KeyWords = "",
			Category = SettingMenuCategory.Basic,
			Pages = new List<SettingPageInfo>
			{
				new SettingPageInfo
				{
					Id = SettingPageId.BlackListSettings,
					Title = "黑名单应用",
					Icon = EFontAwesomeIcon.Light_Ban,
					Description = "设定需要禁用Quicker的软件",
					IsAdvanced = false,
					EditControl = typeof(global::Quicker.Settings.Pages.BlackListSettings)
				}
			}
		});
		ay4j9Qhhmp.Add(new SettingMenuItem
		{
			Icon = EFontAwesomeIcon.Light_Tshirt,
			Title = "外观",
			Description = "颜色、字体等样式设置",
			KeyWords = "",
			Category = SettingMenuCategory.Basic,
			Pages = new List<SettingPageInfo>
			{
				new SettingPageInfo
				{
					Id = SettingPageId.UISettingsPage,
					Title = "面板窗口",
					FullTitle = "面板窗口外观",
					Icon = EFontAwesomeIcon.Light_Tshirt,
					Description = "外观设置",
					IsAdvanced = false,
					EditControl = typeof(UISettingsPage)
				}
			}
		});
		ay4j9Qhhmp.Add(new SettingMenuItem
		{
			Icon = EFontAwesomeIcon.Light_SlidersHSquare,
			Title = "模块功能选项",
			Description = "组合动作模块的控制选项",
			KeyWords = "",
			Category = SettingMenuCategory.Basic,
			Pages = new List<SettingPageInfo>
			{
				new SettingPageInfo
				{
					Id = SettingPageId.BlockOptions,
					Title = "组合动作模块选项",
					Icon = EFontAwesomeIcon.Light_SlidersHSquare,
					Description = "组合动作模块选项",
					IsAdvanced = false,
					EditControl = typeof(ActionBlockSettings)
				}
			}
		});
		ay4j9Qhhmp.Add(new SettingMenuItem
		{
			Icon = EFontAwesomeIcon.Light_PencilRuler,
			Title = "动作设计",
			Description = "动作设计相关功能设置",
			KeyWords = "",
			Category = SettingMenuCategory.Basic,
			Pages = new List<SettingPageInfo>
			{
				new SettingPageInfo
				{
					Id = SettingPageId.ActionDesignerSettingsPage,
					Title = "动作设计相关选项",
					Icon = EFontAwesomeIcon.Light_PencilRuler,
					Description = "动作设计选项",
					IsAdvanced = false,
					EditControl = typeof(ActionDesignerSettings)
				}
			}
		});
		ay4j9Qhhmp.Add(new SettingMenuItem
		{
			Icon = EFontAwesomeIcon.Light_Bicycle,
			Title = "常用辅助功能",
			Description = "常用辅助功能开关",
			KeyWords = "",
			Category = SettingMenuCategory.Basic,
			Pages = new List<SettingPageInfo>
			{
				new SettingPageInfo
				{
					Id = SettingPageId.HelperFunctionsSettingPage,
					Title = "常用辅助功能",
					Icon = EFontAwesomeIcon.Light_Bicycle,
					Description = "常用辅助功能开关",
					IsAdvanced = false,
					EditControl = typeof(HelperFunctionsSettingPage)
				}
			}
		});
		ay4j9Qhhmp.Add(new SettingMenuItem
		{
			Icon = EFontAwesomeIcon.Light_InfoCircle,
			Title = "关于Quicker",
			Description = "账户等相关信息",
			Category = SettingMenuCategory.Basic,
			Pages = new List<SettingPageInfo>
			{
				new SettingPageInfo
				{
					Id = SettingPageId.AboutSettingPage,
					Title = "关于Quicker",
					Icon = EFontAwesomeIcon.Light_UserCircle,
					Description = "基本信息",
					IsAdvanced = false,
					EditControl = typeof(global::Quicker.Settings.Pages.About.AboutSettingPage)
				},
				new SettingPageInfo
				{
					Id = SettingPageId.PrivacyPolicy,
					Title = "隐私声明",
					Icon = EFontAwesomeIcon.Light_UserShield,
					Description = "隐私声明",
					IsAdvanced = false,
					EditControl = typeof(PrivacyPolicy)
				},
				new SettingPageInfo
				{
					Id = SettingPageId.UsageStatisticsInfoPage,
					Title = "用量统计",
					Icon = EFontAwesomeIcon.Light_Calculator,
					Description = "用量统计",
					IsAdvanced = false,
					EditControl = typeof(UsageStatisticsInfoPage)
				}
			}
		});
		ay4j9Qhhmp.Add(new SettingMenuItem
		{
			Icon = EFontAwesomeIcon.Light_DotCircle,
			Title = "轮盘菜单",
			Description = "轮盘菜单相关设置",
			KeyWords = "",
			Category = SettingMenuCategory.Features,
			Pages = new List<SettingPageInfo>
			{
				new SettingPageInfo
				{
					Id = SettingPageId.CircleMenuSettingPage,
					Title = "轮盘菜单设置",
					Icon = EFontAwesomeIcon.Light_DotCircle,
					Description = "轮盘菜单功能和外观设置",
					IsAdvanced = false,
					EditControl = typeof(CircleMenuSettingPage)
				},
				new SettingPageInfo
				{
					Id = SettingPageId.CircleMenuManagePage,
					Title = "轮盘动作管理",
					FullTitle = "轮盘动作管理",
					Icon = EFontAwesomeIcon.Light_DotCircle,
					Description = "轮盘菜单操作触发管理",
					IsAdvanced = false,
					EditControl = typeof(CircleMenuManagePage)
				}
			}
		});
		ay4j9Qhhmp.Add(new SettingMenuItem
		{
			Icon = EFontAwesomeIcon.Light_WaveSine,
			Title = "鼠标手势",
			Description = "各Quicker功能的触发方式",
			KeyWords = "",
			Category = SettingMenuCategory.Features,
			Pages = new List<SettingPageInfo>
			{
				new SettingPageInfo
				{
					Id = SettingPageId.GesturesSettingPage,
					Title = "鼠标手势设置",
					Icon = EFontAwesomeIcon.Light_WaveSine,
					Description = "鼠标手势",
					IsAdvanced = false,
					EditControl = typeof(GesturesSettingPage)
				},
				new SettingPageInfo
				{
					Id = SettingPageId.GesturesManagePage,
					Title = "手势管理",
					Icon = EFontAwesomeIcon.Light_WaveSine,
					Description = "鼠标手势管理",
					IsAdvanced = false,
					EditControl = typeof(GesturesManagePage)
				}
			}
		});
		ay4j9Qhhmp.Add(new SettingMenuItem
		{
			Icon = EFontAwesomeIcon.Light_Mouse,
			Title = "左键辅助",
			Description = "鼠标左键+键盘或其它鼠标键",
			Category = SettingMenuCategory.Features,
			Pages = new List<SettingPageInfo>
			{
				new SettingPageInfo
				{
					Id = SettingPageId.LeftButtonPlusSettingPage,
					Title = "左键辅助",
					Icon = EFontAwesomeIcon.Light_Mouse,
					Description = "左键辅助",
					IsAdvanced = false,
					EditControl = typeof(global::Quicker.Settings.Pages.Triggers.LeftButtonPlusSettingPage)
				}
			}
		});
		ay4j9Qhhmp.Add(new SettingMenuItem
		{
			Icon = EFontAwesomeIcon.Light_Keyboard,
			Title = "快捷键 (动作)",
			Description = "动作快捷键",
			KeyWords = "",
			Category = SettingMenuCategory.Features,
			Pages = new List<SettingPageInfo>
			{
				new SettingPageInfo
				{
					Id = SettingPageId.ActionHotkeysSettingPage,
					Title = "动作快捷键",
					Icon = EFontAwesomeIcon.Light_Keyboard,
					Description = "动作快捷键",
					IsAdvanced = false,
					EditControl = typeof(ActionHotkeysSettingPage)
				},
				new SettingPageInfo
				{
					Id = SettingPageId.HotkeyWatcherSettingsPage,
					Title = "热键联动",
					Icon = EFontAwesomeIcon.Light_Keyboard,
					Description = "当在某个软件中使用快捷键时，也同时触发quicker中的一个操作。",
					IsAdvanced = false,
					EditControl = typeof(HotkeyWatchersSettingPage)
				}
			}
		});
		ay4j9Qhhmp.Add(new SettingMenuItem
		{
			Icon = EFontAwesomeIcon.Light_Keyboard,
			Title = "扩展热键",
			Description = "全局快捷键与扩展热键",
			Category = SettingMenuCategory.Features,
			Pages = new List<SettingPageInfo>
			{
				new SettingPageInfo
				{
					Id = SettingPageId.PowerKeysManagementPage,
					Title = "扩展热键",
					FullTitle = "扩展热键管理",
					Icon = EFontAwesomeIcon.Light_Keyboard,
					Description = "普通按键组合",
					IsAdvanced = false,
					EditControl = typeof(PowerKeysManagementPage)
				},
				new SettingPageInfo
				{
					Id = SettingPageId.PowerKeysSettingsPage,
					Title = "扩展热键参数设置",
					FullTitle = "扩展热键设置",
					Icon = EFontAwesomeIcon.Light_SlidersH,
					Description = "普通按键组合",
					IsAdvanced = false,
					EditControl = typeof(PowerKeysSettingsPage)
				}
			}
		});
		ay4j9Qhhmp.Add(new SettingMenuItem
		{
			Icon = EFontAwesomeIcon.Light_Keyboard,
			Title = "按键双击",
			Description = "双击按键执行动作",
			KeyWords = "",
			Category = SettingMenuCategory.Features,
			Pages = new List<SettingPageInfo>
			{
				new SettingPageInfo
				{
					Id = SettingPageId.KeyActionManagePage,
					Title = "按键双击",
					Icon = EFontAwesomeIcon.Light_AngleDoubleDown,
					Description = "设置按键双击触发",
					IsAdvanced = false,
					EditControl = typeof(KeyActionsSettingPage)
				}
			}
		});
		ay4j9Qhhmp.Add(new SettingMenuItem
		{
			Icon = EFontAwesomeIcon.Light_Ad,
			Title = "文本指令",
			Description = "通过字符组合触发操作",
			Category = SettingMenuCategory.Features,
			Pages = new List<SettingPageInfo>
			{
				new SettingPageInfo
				{
					Id = SettingPageId.TextCommandManagePage,
					Title = "文本指令管理",
					Icon = EFontAwesomeIcon.Light_Ad,
					Description = "文本指令管理",
					IsAdvanced = false,
					EditControl = typeof(global::Quicker.Settings.Pages.Tools.TextCommandManagePage)
				},
				new SettingPageInfo
				{
					Id = SettingPageId.TextCommandSettingPage,
					Title = "文本指令参数设置",
					Icon = EFontAwesomeIcon.Light_SlidersH,
					Description = "文本指令参数设置",
					IsAdvanced = false,
					EditControl = typeof(TextCommandSettingPage)
				}
			}
		});
		ay4j9Qhhmp.Add(new SettingMenuItem
		{
			Icon = EFontAwesomeIcon.Light_Search,
			Title = "搜索",
			Description = "Quicker搜索功能",
			Category = SettingMenuCategory.Features,
			Pages = new List<SettingPageInfo>
			{
				new SettingPageInfo
				{
					Id = SettingPageId.SearchSettings,
					Title = "搜索功能设置",
					Icon = EFontAwesomeIcon.Light_Search,
					Description = "搜索框功能设置",
					IsAdvanced = false,
					EditControl = typeof(global::Quicker.Settings.Pages.Basic.SearchSettingsPage)
				}
			}
		});
		ay4j9Qhhmp.Add(new SettingMenuItem
		{
			Icon = EFontAwesomeIcon.Light_Bars,
			Title = "上下文菜单",
			Description = "根据内容关联操作菜单",
			Category = SettingMenuCategory.Features,
			Pages = new List<SettingPageInfo>
			{
				new SettingPageInfo
				{
					Id = SettingPageId.ContextMenuGeneralSettings,
					Title = "上下文菜单基本参数设置",
					Icon = EFontAwesomeIcon.Light_SlidersH,
					Description = "上下文菜单的触发等基本参数设置",
					IsAdvanced = false,
					EditControl = typeof(ContextMenuGeneralSettings)
				},
				new SettingPageInfo
				{
					Id = SettingPageId.TextContextMenuSettings,
					Title = "文本上下文菜单",
					Icon = EFontAwesomeIcon.Light_Ad,
					Description = "文本内容的上下文菜单",
					IsAdvanced = false,
					EditControl = typeof(TextContextMenuSettings)
				},
				new SettingPageInfo
				{
					Id = SettingPageId.ImageContextMenuSettings,
					Title = "图片上下文菜单",
					Icon = EFontAwesomeIcon.Light_Image,
					Description = "图片内容的上下文菜单",
					IsAdvanced = false,
					EditControl = typeof(ImageContextMenuSettings)
				},
				new SettingPageInfo
				{
					Id = SettingPageId.FileContextMenuSettings,
					Title = "文件上下文菜单",
					Icon = EFontAwesomeIcon.Light_File,
					Description = "文件内容的上下文菜单",
					IsAdvanced = false,
					EditControl = typeof(global::Quicker.Settings.Pages.ContextMenus.FileContextMenuSettings)
				}
			}
		});
		ay4j9Qhhmp.Add(new SettingMenuItem
		{
			Icon = EFontAwesomeIcon.Light_AlarmClock,
			Title = "自动运行动作",
			Description = "启动Quicker后或定时运行动作",
			Category = SettingMenuCategory.Features,
			Pages = new List<SettingPageInfo>
			{
				new SettingPageInfo
				{
					Id = SettingPageId.AutoRunActions,
					Title = "自动运行动作",
					Icon = EFontAwesomeIcon.Light_Clock,
					Description = "启动后或定时运行动作",
					IsAdvanced = false,
					EditControl = typeof(AutoRunSettings)
				}
			}
		});
		ay4j9Qhhmp.Add(new SettingMenuItem
		{
			Icon = EFontAwesomeIcon.Light_Wind,
			Title = "事件触发",
			Description = "事件发生时触发操作",
			Category = SettingMenuCategory.Features,
			Pages = new List<SettingPageInfo>
			{
				new SettingPageInfo
				{
					Id = SettingPageId.EventTriggerSettingsPage,
					Title = "事件触发",
					Icon = EFontAwesomeIcon.Light_Wind,
					Description = "事件发生后自动运行动作",
					IsAdvanced = false,
					EditControl = typeof(EventTriggersSettingPage),
					HelpLink = "event-triggers"
				}
			}
		});
		ay4j9Qhhmp.Add(new SettingMenuItem
		{
			Icon = EFontAwesomeIcon.Light_MouseAlt,
			Title = "高级鼠标触发",
			Description = "组合各种鼠标操作",
			KeyWords = "组合各种鼠标操作",
			Category = SettingMenuCategory.Features,
			Pages = new List<SettingPageInfo>
			{
				new SettingPageInfo
				{
					Id = SettingPageId.MouseActionManagePage,
					Title = "高级鼠标触发",
					Icon = EFontAwesomeIcon.Light_SlidersH,
					Description = "高级鼠标触发",
					IsAdvanced = false,
					EditControl = typeof(MouseActionManagePage)
				},
				new SettingPageInfo
				{
					Id = SettingPageId.BasicTriggers,
					Title = "按键触发",
					Icon = EFontAwesomeIcon.Light_RocketLaunch,
					Description = "常规的鼠标按键触发设置",
					IsAdvanced = false,
					EditControl = typeof(BasicTriggersSettingPage)
				}
			}
		});
		ay4j9Qhhmp.Add(new SettingMenuItem
		{
			Icon = EFontAwesomeIcon.Light_ExpandWide,
			Title = "快速截图",
			Description = "一键截图、贴图、搜图",
			Category = SettingMenuCategory.Features,
			Pages = new List<SettingPageInfo>
			{
				new SettingPageInfo
				{
					Id = SettingPageId.QuickCaptureSettings,
					Title = "快速截图",
					Icon = EFontAwesomeIcon.Light_ExpandWide,
					Description = "设置快速截图功能",
					IsAdvanced = false,
					EditControl = typeof(global::Quicker.Settings.Pages.Basic.QuickScreenCaptureSettings)
				}
			}
		});
		goto IL_01a5;
		IL_01a5:
		ay4j9Qhhmp.Add(new SettingMenuItem
		{
			Icon = EFontAwesomeIcon.Light_MobileAlt,
			Title = "手机APP/WebSocket",
			Description = "设置手机APP连接与WebSocket服务选项",
			Category = SettingMenuCategory.Features,
			Pages = new List<SettingPageInfo>
			{
				new SettingPageInfo
				{
					Id = SettingPageId.AppSettings,
					Title = "App连接与WebSocket服务",
					Icon = EFontAwesomeIcon.Light_MobileAlt,
					Description = "设置手机APP连接与WebSocket服务选项",
					IsAdvanced = false,
					EditControl = typeof(AppSettings)
				}
			}
		});
		ay4j9Qhhmp.Add(new SettingMenuItem
		{
			Icon = EFontAwesomeIcon.Light_Tools,
			Title = "维护工具",
			Description = "工具",
			Category = SettingMenuCategory.Others,
			Pages = new List<SettingPageInfo>
			{
				new SettingPageInfo
				{
					Id = SettingPageId.BasicToolsSettingPage,
					Title = "工具",
					Icon = EFontAwesomeIcon.Light_Tools,
					Description = "工具",
					IsAdvanced = false,
					EditControl = typeof(BasicToolsSettingPage)
				}
			}
		});
		ay4j9Qhhmp.Add(new SettingMenuItem
		{
			Icon = EFontAwesomeIcon.Light_Sync,
			Title = "数据同步",
			Description = "数据同步日志与选项",
			Category = SettingMenuCategory.Others,
			Pages = new List<SettingPageInfo>
			{
				new SettingPageInfo
				{
					Id = SettingPageId.SyncSettingPage,
					Title = "数据同步",
					Icon = EFontAwesomeIcon.Light_Sync,
					Description = "数据同步",
					IsAdvanced = false,
					EditControl = typeof(SyncSettingPage)
				}
			}
		});
		ay4j9Qhhmp.Add(new SettingMenuItem
		{
			Icon = EFontAwesomeIcon.Light_ArrowUp,
			Title = "批量更新动作",
			Description = "更新所有动作",
			Category = SettingMenuCategory.Others,
			Pages = new List<SettingPageInfo>
			{
				new SettingPageInfo
				{
					Id = SettingPageId.UpdateActionsPage,
					Title = "批量更新动作",
					Icon = EFontAwesomeIcon.Light_ArrowUp,
					Description = "批量更新动作",
					IsAdvanced = false,
					EditControl = typeof(UpdateActionsPage)
				}
			}
		});
		ay4j9Qhhmp.Add(new SettingMenuItem
		{
			Icon = EFontAwesomeIcon.Light_Trash,
			Title = "动作回收站",
			Description = "找回删除的动作",
			Category = SettingMenuCategory.Others,
			Pages = new List<SettingPageInfo>
			{
				new SettingPageInfo
				{
					Id = SettingPageId.ActionRecycleBinSettingPage,
					Title = "动作回收站",
					Icon = EFontAwesomeIcon.Light_Trash,
					Description = "动作回收站",
					IsAdvanced = false,
					EditControl = typeof(ActionRecycleBinSettingPage)
				}
			}
		});
		num = 0;
		if (vsqmEsSK8iL8t4telTq != null)
		{
			return;
		}
		goto IL_138a;
		IL_138a:
		switch (num)
		{
		case 2:
			break;
		case 1:
			goto IL_0479;
		default:
			return;
		case 0:
			return;
		}
		goto IL_01a5;
	}

	public static int GetPageMatchScore(SettingPageInfo page, string filter)
	{
		IMatchResult matchResult = tkxn6HAKAgMT8gvXbyh.SgJi5c1l5A(page.FullTitle, filter);
		if (matchResult != null && matchResult.Score > 0)
		{
			return matchResult.Score;
		}
		string keyWords = page.KeyWords;
		if (keyWords != null && keyWords.Contains(filter))
		{
			return 100;
		}
		return 0;
	}

	public static IList<SettingPageInfo> SearchPage(string filter)
	{
		if (string.IsNullOrWhiteSpace(filter))
		{
			return null;
		}
		IDictionary<SettingPageInfo, int> dictionary = new Dictionary<SettingPageInfo, int>();
		foreach (SettingPageInfo allPage in AllPages)
		{
			int pageMatchScore = GetPageMatchScore(allPage, filter);
			if (pageMatchScore > 0)
			{
				dictionary.Add(allPage, pageMatchScore);
			}
		}
		return dictionary.OrderByDescending(_003C_003Ec.D7TvVaEhdix ?? (_003C_003Ec.D7TvVaEhdix = _003C_003Ec.LqYvVyZRlbB.YQqvVPXBf3C)).Select(_003C_003Ec.zsavV72Xigt ?? (_003C_003Ec.zsavV72Xigt = _003C_003Ec.LqYvVyZRlbB.NmDvVEMlX5a)).ToList();
	}

	internal static bool pWNUC9SBRn3D62VduNu()
	{
		return vsqmEsSK8iL8t4telTq == null;
	}
}
