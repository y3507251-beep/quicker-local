using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using IOn6RhAJdTUbfGy6gwn;
using log4net;
using Quicker.Domain;
using Quicker.Public.Searching;
using Quicker.Public.Utilities.Pinyin;
using Quicker.Utilities;
using Quicker.Utilities.Win32;

namespace lskHK22VTco51slRGWB;

internal class ONgL3r2gY2UDTxHt94I : SearchPlugin, IContextMenuBuilder
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass30_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct gRZ3SoHto367X4JCYsk : IAsyncStateMachine
		{
			public int gvr27RCP9Sg;

			public AsyncVoidMethodBuilder iuv27qb5oR0;

			public _003C_003Ec__DisplayClass30_0 lou27cynPNc;

			private TaskAwaiter<bool> RPg27VyBrYM;

			private static object RLIlFiyL7aNDel12xr5g;

			private void MoveNext()
			{
				int num = gvr27RCP9Sg;
				_003C_003Ec__DisplayClass30_0 _003C_003Ec__DisplayClass30_ = lou27cynPNc;
				try
				{
					try
					{
						TaskAwaiter<bool> awaiter;
						if (num != 0)
						{
							awaiter = AppState.lWutartRfUY().CreateAndCopyActionForCommand(_003C_003Ec__DisplayClass30_.xuav6y72sOl, _003C_003Ec__DisplayClass30_.ioSv68IRyPU.Title, _003C_003Ec__DisplayClass30_.ioSv68IRyPU.Icon).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 0;
								gvr27RCP9Sg = 0;
								RPg27VyBrYM = awaiter;
								iuv27qb5oR0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								int num2 = 0;
								if (!KRqKkWyL4qOE9s5xQ8Hd())
								{
									int num3 = default(int);
									num2 = num3;
								}
								switch (num2)
								{
								}
								return;
							}
						}
						else
						{
							awaiter = RPg27VyBrYM;
							RPg27VyBrYM = default(TaskAwaiter<bool>);
							num = -1;
							gvr27RCP9Sg = -1;
						}
						awaiter.GetResult();
						AppHelper.ShowSuccess("已复制动作，请在面板上空白位置粘贴。");
					}
					catch (Exception ex)
					{
						u0KtEIVADvi.Warn("创建动作失败：" + ex.Message, ex);
						AppHelper.ShowWarning("创建动作失败：" + ex.Message);
					}
				}
				catch (Exception exception)
				{
					gvr27RCP9Sg = -2;
					iuv27qb5oR0.SetException(exception);
					return;
				}
				gvr27RCP9Sg = -2;
				iuv27qb5oR0.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				iuv27qb5oR0.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool KRqKkWyL4qOE9s5xQ8Hd()
			{
				return RLIlFiyL7aNDel12xr5g == null;
			}
		}

		[StructLayout(LayoutKind.Auto)]
		private struct WHGtfbHxBiXRcfXGrLC : IAsyncStateMachine
		{
			public int aro27ZQUWqr;

			public AsyncVoidMethodBuilder hiP279cIdbK;

			public _003C_003Ec__DisplayClass30_0 bfJ27hVSv5t;

			internal static object pTOVt1yLHdRwVBi3GTrq;

			private void MoveNext()
			{
				_003C_003Ec__DisplayClass30_0 _003C_003Ec__DisplayClass30_ = bfJ27hVSv5t;
				try
				{
					AppHelper.TryCopy(_003C_003Ec__DisplayClass30_.xuav6y72sOl, true);
				}
				catch (Exception exception)
				{
					aro27ZQUWqr = -2;
					hiP279cIdbK.SetException(exception);
					return;
				}
				aro27ZQUWqr = -2;
				hiP279cIdbK.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				hiP279cIdbK.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			static WHGtfbHxBiXRcfXGrLC()
			{
			}

			internal static bool xd3xvbyLzKHFydvyb2xm()
			{
				return pTOVt1yLHdRwVBi3GTrq == null;
			}

			internal static void edWKcvyuQhKubCtgCaJ5()
			{
			}
		}

		public string xuav6y72sOl;

		public SearchResultItem ioSv68IRyPU;

		private static _003C_003Ec__DisplayClass30_0 qcXjWjcxcZgINRCs6dg5;

		[AsyncStateMachine(typeof(gRZ3SoHto367X4JCYsk))]
		internal void LNbv6PxmA1l(object sender, RoutedEventArgs e)
		{
			gRZ3SoHto367X4JCYsk stateMachine = default(gRZ3SoHto367X4JCYsk);
			stateMachine.iuv27qb5oR0 = AsyncVoidMethodBuilder.Create();
			stateMachine.lou27cynPNc = this;
			stateMachine.gvr27RCP9Sg = -1;
			stateMachine.iuv27qb5oR0.Start(ref stateMachine);
		}

		[AsyncStateMachine(typeof(WHGtfbHxBiXRcfXGrLC))]
		internal void lKQv6EjXMDB(object sender, RoutedEventArgs e)
		{
			WHGtfbHxBiXRcfXGrLC stateMachine = default(WHGtfbHxBiXRcfXGrLC);
			stateMachine.hiP279cIdbK = AsyncVoidMethodBuilder.Create();
			stateMachine.bfJ27hVSv5t = this;
			stateMachine.aro27ZQUWqr = -1;
			stateMachine.hiP279cIdbK.Start(ref stateMachine);
		}

		internal static bool jEAXQbcxWXK5oQskjmsj()
		{
			return qcXjWjcxcZgINRCs6dg5 == null;
		}
	}

	private static readonly ILog u0KtEIVADvi;

	[CompilerGenerated]
	private readonly SearchPluginSettings aMItEWmGqaT = new SearchPluginSettings
	{
		IncludeInGlobalSearch = false,
		Triggers = new List<SearchTrigger>
		{
			new SearchTrigger
			{
				TriggerWord = "#"
			}
		},
		GlobalSearchWeight = 0.9,
		PluginId = "search.sys.windows.settings",
		MinGlobalTriggerLength = 2
	};

	[CompilerGenerated]
	private readonly PluginInfo pe4tEkpn0lR = new PluginInfo
	{
		Name = "Windows 设置",
		Description = "搜索Windows设置或控制面板",
		SearchContentName = "Win设置",
		Icon = "fa:Brands_Windows"
	};

	[CompilerGenerated]
	private readonly string ohQtEG9A43C = "search.sys.windows.settings";

	[CompilerGenerated]
	private readonly string hEntEsTgMee = "fa:Light_Cog";

	[CompilerGenerated]
	private readonly SearchResultOperationType zfetEHSX1wF = SearchResultOperationType.Execute;

	[CompilerGenerated]
	private readonly SearchResultOperationType R3RtE1Y0sj2;

	[CompilerGenerated]
	private readonly bool EJGtEbeRY9N = true;

	private string[] RvntE6nROSD = new string[0];

	internal static ONgL3r2gY2UDTxHt94I NVdiroQDJVsCmOaSs7LN;

	public override SearchPluginSettings DefaultSettings
	{
		[CompilerGenerated]
		get
		{
			return aMItEWmGqaT;
		}
	}

	public override PluginInfo PluginInfo
	{
		[CompilerGenerated]
		get
		{
			return pe4tEkpn0lR;
		}
	}

	public override string Id
	{
		[CompilerGenerated]
		get
		{
			return ohQtEG9A43C;
		}
	}

	public override string DefaultItemIcon
	{
		[CompilerGenerated]
		get
		{
			return hEntEsTgMee;
		}
	}

	public override SearchResultOperationType EnterSelectOperation
	{
		[CompilerGenerated]
		get
		{
			return zfetEHSX1wF;
		}
	}

	public override SearchResultOperationType CtrlEnterOperation
	{
		[CompilerGenerated]
		get
		{
			return R3RtE1Y0sj2;
		}
	}

	public override bool IsSupportHistory
	{
		[CompilerGenerated]
		get
		{
			return EJGtEbeRY9N;
		}
	}

	public override void ProcessResult(SearchResultItem searchResultItem_0, QueryContext queryContext_0)
	{
		throw new NotImplementedException();
	}

	public override void Init(SearchPluginInitContext searchPluginInitContext_0)
	{
		base.Init(searchPluginInitContext_0);
		RvntE6nROSD = "16位应用程序支持|工具程序|controlpanel|rundll32.exe shell32.dll,Control_RunDLL ntvdmcpl.dll\r\nBitLocker 驱动器加密|系统和安全性|controlpanel|control.exe -name Microsoft.BitLockerDriveEncryption\r\nInternet 属性|网络和 Internet|controlpanel|control.exe -name Microsoft.InternetOptions\r\nRemoteApp 和桌面连接|网络和 Internet|controlpanel|control.exe -name Microsoft.RemoteAppAndDesktopConnections\r\n设备 - USB|蓝牙和其他设备|winsettings|ms-settings:usb\r\n网络和 Internet - VPN|网络和 Internet|winsettings|ms-settings:network-vpn\r\nWindows Defender 防火墙|系统和安全性|controlpanel|control.exe -name Microsoft.WindowsFirewall\r\nWindows 安全中心|隐私和安全性|winsettings|ms-settings:windowsdefender\r\n帐户 - Windows 备份|帐户|winsettings|ms-settings:backup\r\nWindows 更新|Windows 更新|winsettings|ms-settings:windowsupdate\r\nWindows 预览体验计划|Windows 更新|winsettings|ms-settings:windowsinsider\r\nWindows网络诊断|工具程序|controlpanel|Rundll32.exe ndfapi,NdfRunDllDiagnoseIncident\r\n网络和 Internet - WLAN|网络和 Internet|winsettings|ms-settings:network-wifi\r\n网络和 Internet - WLAN - 管理已知网络|网络和 Internet|winsettings|ms-settings:network-wifisettings\r\n游戏 - Xbox Game Bar|游戏|winsettings|ms-settings:gaming-gamebar\r\n安全和维护|系统和安全性|controlpanel|control.exe -name Microsoft.ActionCenter\r\n备份和还原(Windows 7)|系统和安全性|controlpanel|control.exe -name Microsoft.BackupAndRestore\r\n个性化 - 背景|个性化|winsettings|ms-settings:personalization-background\r\n设备 - 笔和 Windows Ink|蓝牙和其他设备|winsettings|ms-settings:pen\r\n笔和触控|硬件和声音|controlpanel|TabletPC.cpl\r\n网络和 Internet - 网络拨号|网络和 Internet|winsettings|ms-settings:network-dialup\r\n查看按需寻找页面|Windows 更新|winsettings|ms-settings:windowsupdate-seekerondemand\r\n隐私和安全性 - 查找我的设备|隐私和安全性|winsettings|ms-settings:findmydevice\r\n隐私和安全性 - 常规|隐私和安全性|winsettings|ms-settings:privacy-general\r\n程序和功能|程序|controlpanel|control.exe -name Microsoft.ProgramsAndFeatures\r\n系统 - 触控|系统|winsettings|ms-settings:devices-touch\r\n系统 - 触控板|系统|winsettings|ms-settings:devices-touchpad\r\n个性化 - 触摸键盘|个性化|winsettings|ms-settings:personalization-touchkeyboard\r\n传递优化|Windows 更新|winsettings|ms-settings:delivery-optimization\r\n创建 VPN 连接|网络和 Internet|controlpanel|xwizard.exe RunWizard {7071EC75-663B-4bc1-A1FA-B97F3B917C55}\r\n创建密码重置盘|工具程序|controlpanel|rundll32.exe keymgr.dll,PRShowSaveWizardExW\r\n从网络安装程序|网络和 Internet|controlpanel|shell:::{26EE0668-A00A-44D7-9371-BEB064C98683}\\8\\::{15EAE92E-F17A-4431-9F28-805E482dAFD4}\r\n系统 - 存储|系统|winsettings|ms-settings:storagesense\r\n存储 - 保存新内容的地方|系统|winsettings|ms-settings:savelocations\r\n存储 - 存储感知|系统|winsettings|ms-settings:storagepolicies\r\n设备 - 打印机和扫描仪|蓝牙和其他设备|winsettings|ms-settings:printers\r\n网络和 Internet - 网络代理|网络和 Internet|winsettings|ms-settings:network-proxy\r\n帐户 - 登录选项|帐户|winsettings|ms-settings:signinoptions\r\n帐户 - 登录选项 - 动态锁定|帐户|winsettings|ms-settings:signinoptions-dynamiclock\r\n帐户 - 登录选项 - 人脸解锁|帐户|winsettings|ms-settings:signinoptions-launchfaceenrollment\r\n帐户 - 登录选项 - 指纹解锁|帐户|winsettings|ms-settings:signinoptions-launchfingerprintenrollment\r\n帐户 - 登录选项 - 安全钥匙|帐户|winsettings|ms-settings:signinoptions-launchsecuritykeyenrollment\r\n隐私和安全性 - 电话呼叫|隐私和安全性|winsettings|ms-settings:privacy-phonecalls\r\n电源 - 节电模式|系统|winsettings|ms-settings:batterysaver \r\n电源 - 睡眠|系统|winsettings|ms-settings:powersleep\r\n电源选项|系统和安全性|controlpanel|control.exe -name Microsoft.PowerOptions\r\n帐户 - 电子邮件和帐户|帐户|winsettings|ms-settings:emailandaccounts\r\n辅助功能 - 对比度主题|辅助功能|winsettings|ms-settings:easeofaccess-highcontrast\r\n多媒体属性、声音|硬件和声音|controlpanel|control.exe Mmsys.cpl\r\n系统 - 多任务处理|系统|winsettings|ms-settings:multitasking\r\n访问RemoteApp和桌面|网络和 Internet|controlpanel|xwizard.exe RunWizard {7940ACF8-60BA-4213-A7C3-F3B400EE266D}\r\n辅助功能 - 放大镜|辅助功能|winsettings|ms-settings:easeofaccess-magnifier\r\n网络和 Internet - 飞行模式|网络和 Internet|winsettings|ms-settings:network-airplanemode\r\n辅助功能|辅助功能|winsettings|ms-settings:easeofaccess\r\n高级共享设置|网络和 Internet|controlpanel|control.exe -name Microsoft.NetworkAndSharingCenter /page Advanced\r\n网络和 Internet - 高级网络设置|网络和 Internet|winsettings|ms-settings:network-advancedsettings\r\n高级选项|Windows 更新|winsettings|ms-settings:windowsupdate-options\r\n个性化|个性化|winsettings|ms-settings:personalization\r\n隐私和安全性 - 更改位置设置|隐私和安全性|controlpanel|control.exe -name Microsoft.LocationSettings\r\n更新历史记录|Windows 更新|winsettings|ms-settings:windowsupdate-history\r\n系统 - 关于|系统|winsettings|ms-settings:about\r\n管理存储空间|系统和安全性|controlpanel|control.exe -name Microsoft.StorageSpaces\r\n管理工具|系统和安全性|controlpanel|control.exe -name Microsoft.AdministrativeTools\r\n管理工作文件夹|系统和安全性|controlpanel|control.exe -name Microsoft.WorkFolders\r\n设备 - 滚轮|蓝牙和其他设备|winsettings|ms-settings:wheel\r\n系统 - 恢复|系统|winsettings|ms-settings:recovery\r\n隐私和安全性 - 活动历史记录|隐私和安全性|winsettings|ms-settings:privacy-activityhistory\r\n获取应用程序|程序|controlpanel|control.exe -name Microsoft.GetPrograms\r\n系统 - 激活|系统|winsettings|ms-settings:activation\r\n计划重启|Windows 更新|winsettings|ms-settings:windowsupdate-restartoptions\r\n系统 - 加密设备|系统|winsettings|ms-settings:deviceencryption\r\n帐户 - 家庭和其他用户 - 家庭组|帐户|winsettings|ms-settings:family-group\r\n帐户 - 家庭和其他用户 - 其他用户|帐户|winsettings|ms-settings:otherusers\r\n帐户 - 家庭和其他用户 - 展台|帐户|winsettings|ms-settings:assignedaccess\r\n系统 - 剪贴板|系统|winsettings|ms-settings:clipboard\r\n辅助功能 - 键盘|辅助功能|winsettings|ms-settings:easeofaccess-keyboard\r\n键盘 属性|硬件和声音|controlpanel|control.exe -name Microsoft.Keyboard\r\n辅助功能 - 讲述人|辅助功能|winsettings|ms-settings:easeofaccess-narrator\r\n系统 - 就近共享|系统|winsettings|ms-settings:crossdevice\r\n隐私和安全性 - 开发者选项|隐私和安全性|winsettings|ms-settings:developers\r\n个性化 - 开始|个性化|winsettings|ms-settings:personalization-start\r\n个性化 - 开始 - 文件夹|个性化|winsettings|ms-settings:personalization-start-places\r\n应用 - 可打开网站的应用|应用|winsettings|ms-settings:appsforwebsites\r\n可靠性监视程序|系统和安全性|controlpanel|control.exe -name Microsoft.ActionCenter /page pageReliabilityView\r\n应用 - 可选功能|应用|winsettings|ms-settings:optionalfeatures\r\n网络和 Internet - 可用网络(WIFI)|网络和 Internet|winsettings|ms-availablenetworks:\r\n应用 - 离线地图|应用|winsettings|ms-settings:maps\r\n帐户 - 连接工作或学校帐户|帐户|winsettings|ms-settings:workplace\r\n隐私和安全性 - 联系人|隐私和安全性|winsettings|ms-settings:privacy-contacts\r\n隐私和安全性 - 麦克风|隐私和安全性|winsettings|ms-settings:privacy-microphone\r\n隐私和安全性 - 墨迹书写和键入个性化|隐私和安全性|winsettings|ms-settings:privacy-speechtyping\r\n默认程序|应用|controlpanel|control.exe -name Microsoft.DefaultPrograms\r\n应用 - 默认应用|应用|winsettings|ms-settings:defaultapps\r\n辅助功能 - 目视控制|辅助功能|winsettings|ms-settings:easeofaccess-eyecontrol\r\n设备 - 你的手机|蓝牙和其他设备|winsettings|ms-settings:mobile-devices\r\n凭据管理器|用户帐户|controlpanel|control.exe -name Microsoft.CredentialManager\r\n屏幕保护程序设置|工具程序|controlpanel|rundll32.exe shell32.dll,Control_RunDLL desk.cpl,screensaver,@screensaver\r\n隐私和安全性 - 屏幕截图边框|隐私和安全性|winsettings|ms-settings:privacy-graphicscapturewithoutborder\r\n隐私和安全性 - 屏幕截图和应用|隐私和安全性|winsettings|ms-settings:privacy-graphicscaptureprogrammatic\r\n隐私和安全性 - 其他设备|隐私和安全性|winsettings|ms-settings:privacy-customdevices\r\n应用 - 自动启动|应用|winsettings|ms-settings:startupapps\r\n轻松使用设置中心|轻松使用|controlpanel|control.exe -name Microsoft.EaseOfAccessCenter\r\n区域设置|轻松访问|controlpanel|control.exe Intl.cpl\r\n区域与语言|时钟和区域|controlpanel|control.exe -name Microsoft.RegionAndLanguage\r\n隐私和安全性 - 任务|隐私和安全性|winsettings|ms-settings:privacy-tasks\r\n个性化 - 任务栏设置|个性化|winsettings|ms-settings:taskbar\r\n任务栏|个性化|controlpanel|control.exe -name Microsoft.Taskbar\r\n隐私和安全性 - 日历|隐私和安全性|winsettings|ms-settings:privacy-calendar\r\n时间和语言 - 日期和时间|时间和语言|winsettings|ms-settings:dateandtime\r\n日期和时间|时钟和区域|controlpanel|control.exe -name Microsoft.DateAndTime\r\n扫描仪和照相机|硬件和声音|controlpanel|control.exe -name Microsoft.ScannersAndCameras\r\n设备 - 蓝牙设备|蓝牙和其他设备|winsettings|ms-settings:bluetooth\r\n设备 - 已连接的设备|蓝牙和其他设备|winsettings|ms-settings:connecteddevices\r\n设备管理器|硬件和声音|controlpanel|control.exe -name Microsoft.DeviceManager\r\n设备和打印机|硬件和声音|controlpanel|control.exe -name Microsoft.DevicesAndPrinters\r\n设备和打印机|硬件和声音|controlpanel|control.exe -name Microsoft.Printers\r\n个性化 - 设备使用情况|个性化|winsettings|ms-settings:deviceusage\r\n设置连接或网络|网络和 Internet|controlpanel|xwizard.exe RunWizard {7071ECE0-663B-4bc1-A1FA-B97F3B917C55}\r\n设置筛选键|轻松使用|controlpanel|control.exe -name Microsoft.EaseOfAccessCenter /page pageFilterKeysSettings\r\n设置|设置|winsettings|ms-settings:\r\n游戏 - 摄像|游戏|winsettings|ms-settings:gaming-gamedvr\r\n生物识别设备|硬件和声音|controlpanel|control.exe -name Microsoft.BiometricDevices\r\n系统 - 声音|系统|winsettings|ms-settings:sound\r\n声音|硬件和声音|controlpanel|control.exe -name Microsoft.Sound\r\n系统 - 声音 - 所有声音设备|系统|winsettings|ms-settings:sound-devices\r\n系统 - 声音 - 音量合成器|系统|winsettings|ms-settings:apps-volume \r\n使计算机更易于查看|轻松使用|controlpanel|control.exe -name Microsoft.EaseOfAccessCenter /page pageEasierToSee\r\n使键盘更易于使用|轻松使用|controlpanel|control.exe -name Microsoft.EaseOfAccessCenter /page pageKeyboardEasierToUse\r\n使键盘更易于使用|轻松使用|controlpanel|control.exe -name Microsoft.EaseOfAccessCenter /page pageKeyboardEasierToUse\r\n使鼠标更易于使用|轻松使用|controlpanel|control.exe -name Microsoft.EaseOfAccessCenter /page pageEasierToClick\r\n使用没有鼠标或键盘的计算机|轻松使用|controlpanel|control.exe -name Microsoft.EaseOfAccessCenter /page pageNoMouseOrKeyboard\r\n使用没有显示的计算机|轻松使用|controlpanel|control.exe -name Microsoft.EaseOfAccessCenter /page pageNoVisual\r\n辅助功能 - 视觉效果|辅助功能|winsettings|ms-settings:easeofaccess-visualeffects\r\n隐私和安全性 - 视频|隐私和安全性|winsettings|ms-settings:privacy-videos\r\n应用 - 视频播放|应用|winsettings|ms-settings:videoplayback\r\n时间和语言 - 输入|时间和语言|winsettings|ms-settings:typing\r\n辅助功能 - 鼠标|辅助功能|winsettings|ms-settings:easeofaccess-mouse\r\n设备 - 鼠标和触控板|蓝牙和其他设备|winsettings|ms-settings:mousetouchpad\r\n鼠标 属性|硬件和声音|controlpanel|control.exe -name Microsoft.Mouse\r\n辅助功能 - 鼠标指针和触控|辅助功能|winsettings|ms-settings:easeofaccess-mousepointer\r\n网络和 Internet - 数据使用量|网络和 Internet|winsettings|ms-settings:datausage\r\n隐私和安全性 - 搜索 Windows|隐私和安全性|winsettings|ms-settings:search\r\n隐私和安全性 - 搜索权限|隐私和安全性|winsettings|ms-settings:search-permissions\r\n索引选项|系统和安全性|controlpanel|control.exe -name Microsoft.IndexingOptions\r\n个性化 - 锁屏界面|个性化|winsettings|ms-settings:lockscreen\r\n添加硬件|硬件和声音|controlpanel|control.exe -name Microsoft.AddHardware\r\n隐私和安全性 - 通话记录|隐私和安全性|winsettings|ms-settings:privacy-callhistory\r\n系统 - 通知|系统|winsettings|ms-settings:notifications\r\n隐私和安全性 - 通知|隐私和安全性|winsettings|ms-settings:privacy-notifications\r\n同步中心|系统和安全性|controlpanel|control.exe -name Microsoft.SyncCenter\r\n投放、投影|投放、投影|winsettings|ms-settings-connectabledevices:devicediscovery\r\n系统 - 投影到此电脑|系统|winsettings|ms-settings:project\r\n隐私和安全性 - 图片|隐私和安全性|winsettings|ms-settings:privacy-pictures\r\n脱机文件|网络和 Internet|controlpanel|control.exe -name Microsoft.OfflineFiles\r\n网络和 Internet|网络和 Internet|winsettings|ms-settings:network\r\n网络连接|网络和 Internet|controlpanel|control.exe netconnections\r\n网络与共享中心|网络和 Internet|controlpanel|control.exe -name Microsoft.NetworkAndSharingCenter\r\n网上邻居|网络和 Internet|controlpanel|shell:::{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}\r\n隐私和安全性 - 位置|隐私和安全性|winsettings|ms-settings:privacy-location\r\n辅助功能 - 文本大小|辅助功能|winsettings|ms-settings:easeofaccess-display\r\n辅助功能 - 文本光标|辅助功能|winsettings|ms-settings:easeofaccess-cursor\r\n文本转语音|轻松访问|controlpanel|control.exe -name Microsoft.TextToSpeech\r\n隐私和安全性 - 文档|隐私和安全性|winsettings|ms-settings:privacy-documents\r\n文件夹选项|外观和个性化|controlpanel|control.exe -name Microsoft.FolderOptions\r\n隐私和安全性 - 文件系统|隐私和安全性|winsettings|ms-settings:privacy-broadfilesystemaccess\r\n文件资源管理器选项（查看）|工具程序|controlpanel|rundll32.exe shell32.dll,Options_RunDLL 7\r\n问题报告|系统和安全性|controlpanel|control.exe -name Microsoft.ActionCenter /page pageProblems\r\n隐私和安全性 - 无线收发器|隐私和安全性|winsettings|ms-settings:privacy-radios\r\n系统恢复|系统和安全性|controlpanel|control.exe -name Microsoft.Recovery\r\n系统属性|硬件和声音|controlpanel|control.exe Sysdm.cpl\r\n隐私和安全性 - 下载文件夹|隐私和安全性|winsettings|ms-settings:privacy-downloadsfolder\r\n系统 - 屏幕(显示器)|系统|winsettings|ms-settings:display\r\n系统 - 屏幕 - 高级|系统|winsettings|ms-settings:display-advanced\r\n系统 - 屏幕 - 显示卡|系统|winsettings|ms-settings:display-advancedgraphics\r\n系统 - 屏幕 - 夜间模式|系统|winsettings|ms-settings:nightlight\r\n显示属性|硬件和声音|controlpanel|control.exe Desk.cpl\r\n隐私和安全性 - 相机|隐私和安全性|winsettings|ms-settings:privacy-webcam\r\n隐私和安全性 - 消息|隐私和安全性|winsettings|ms-settings:privacy-messaging\r\n修改环境变量|工具程序|controlpanel|rundll32.exe sysdm.cpl,EditEnvironmentVariables\r\n个性化 - 颜色|个性化|winsettings|ms-settings:colors\r\n颜色管理|外观和个性化|controlpanel|control.exe -name Microsoft.ColorManagement\r\n辅助功能 - 颜色滤镜|辅助功能|winsettings|ms-settings:easeofaccess-colorfilter\r\n网络和 Internet - 移动热点|网络和 Internet|winsettings|ms-settings:network-mobilehotspot\r\n系统 - 疑难解答|系统|winsettings|ms-settings:troubleshoot\r\n疑难解答|系统|controlpanel|control.exe -name Microsoft.Troubleshooting\r\n已安装更新|程序|controlpanel|control.exe -name Microsoft.ProgramsAndFeatures /page ::{D450A8A1-9568-45C7-9C0E-B4F9FB4537BD}\r\n网络和 Internet - 以太网|网络和 Internet|winsettings|ms-settings:network-ethernet\r\n隐私和安全性 - 音乐库|隐私和安全性|winsettings|ms-settings:privacy-musiclibrary\r\n辅助功能 - 音频|辅助功能|winsettings|ms-settings:easeofaccess-audio\r\n隐私和安全性|隐私和安全性|winsettings|ms-settings:privacy\r\n应用 - 应用和功能|应用|winsettings|ms-settings:appsfeatures\r\n隐私和安全性 - 应用诊断|隐私和安全性|winsettings|ms-settings:privacy-appdiagnostics\r\n用户配置文件|工具程序|controlpanel|rundll32.exe sysdm.cpl,EditUserProfiles\r\n用户帐户|用户帐户|controlpanel|control.exe -name Microsoft.UserAccounts\r\n用文本或视频替代声音|轻松使用|controlpanel|control.exe -name Microsoft.EaseOfAccessCenter /page pageEasierWithSounds\r\n游戏杆属性|硬件和声音|controlpanel|control.exe Joy.cpl\r\n游戏控制器|硬件和声音|controlpanel|control.exe -name Microsoft.GameControllers\r\n游戏 - 游戏模式|游戏|winsettings|ms-settings:gaming-gamemode\r\n语言和区域 - 键盘|时间和语言|winsettings|ms-settings:keyboard\r\n语言和区域 - 区域格式|时间和语言|winsettings|ms-settings:regionformatting\r\n语言和区域 - 区域语言|时间和语言|winsettings|ms-settings:regionlanguage\r\n语言和区域|时间和语言|controlpanel|control.exe -name Microsoft.Language\r\n语言和区域 - 微软拼音输入法|时间和语言|winsettings|ms-settings:regionlanguage-chsime-pinyin\r\n语言和区域 - 微软拼音 - 用户自定义短语|时间和语言|winsettings|ms-settings:regionlanguage-chsime-pinyin-udp\r\n语言和区域 - 微软拼音 - 专业词典|时间和语言|winsettings|ms-settings:regionlanguage-chsime-pinyin-domainlexicon\r\n辅助功能 - 语音|辅助功能|winsettings|ms-settings:easeofaccess-speechrecognition\r\n隐私和安全性 - 语音|隐私和安全性|winsettings|ms-settings:privacy-speech\r\n时间和语言 - 语音|时间和语言|winsettings|ms-settings:speech\r\n隐私和安全性 - 语音激活|隐私和安全性|winsettings|ms-settings:privacy-voiceactivation\r\n轻松使用 - 语音识别|轻松访问|controlpanel|control.exe -name Microsoft.SpeechRecognition\r\n系统 - 远程桌面设置|系统|winsettings|ms-settings:remotedesktop\r\n允许应用通过防火墙|系统和安全性|controlpanel|control.exe -name Microsoft.WindowsFirewall /page PageConfigureApps\r\n帐户 - 所有账户|帐户|winsettings|ms-settings:accounts\r\n隐私和安全性 - 帐户信息|隐私和安全性|winsettings|ms-settings:privacy-accountinfo\r\n帐户 - 你的帐户信息|帐户|winsettings|ms-settings:yourinfo\r\n设备 - 摄像头|蓝牙和其他设备|winsettings|ms-settings:camera\r\n隐私和安全性 - 诊断和反馈|隐私和安全性|winsettings|ms-settings:privacy-feedback\r\n个性化 - 主题|个性化|winsettings|ms-settings:themes\r\n系统 - 专注助手|系统|winsettings|ms-settings:quiethours\r\n设备 - 自动播放|蓝牙和其他设备|winsettings|ms-settings:autoplay\r\n自动播放|硬件和声音|controlpanel|control.exe -name Microsoft.AutoPlay\r\n自动启动|系统|controlpanel|taskmgr.exe /6 /Startup\r\n自动维护|系统和安全性|controlpanel|control.exe -name Microsoft.ActionCenter /page MaintenanceSettings\r\n隐私和安全性 - 自动文件下载|隐私和安全性|winsettings|ms-settings:privacy-automaticfiledownloads\r\n辅助功能 - 字幕|辅助功能|winsettings|ms-settings:easeofaccess-closedcaptioning\r\n个性化 - 字体|个性化|winsettings|ms-settings:fonts\r\n字体|外观和个性化|controlpanel|control.exe -name Microsoft.Fonts\r\n".Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
	}

	public override IList<SearchResultItem> DoSearch(QueryContext queryContext_0, CancellationToken cancellationToken_0)
	{
		List<SearchResultItem> list = new List<SearchResultItem>();
		bool flag = NativeMethods.IsOnWindows10OrLater();
		string string_ = "fa:Brands_Windows:#0086ff";
		string[] rvntE6nROSD = RvntE6nROSD;
		foreach (string text in rvntE6nROSD)
		{
			string[] array = text.Split(new char[1] { '|' }, 4);
			string string_2 = array[0];
			string text2 = array[2];
			string string_3 = array[3];
			if (flag || !(text2 == "winsettings"))
			{
				MultiFieldMatchResult multiFieldMatchResult = tkxn6HAKAgMT8gvXbyh.KwUidyksAU(string_2, 1.0, string_3, 0.5, true, queryContext_0);
				if (multiFieldMatchResult.Score > 0)
				{
					list.Add(AootEY6K8mc(text, string_, array, multiFieldMatchResult));
				}
			}
		}
		return list;
	}

	private SearchResultItem AootEY6K8mc(string string_2, string string_3, string[] string_4, MultiFieldMatchResult multiFieldMatchResult_0)
	{
		string title = string_4[0];
		string text = string_4[2];
		string text2 = string_4[3];
		bool flag = text == "controlpanel";
		return new SearchResultItem
		{
			Title = title,
			Description = text2,
			TextData = text2,
			SecondaryIcon = string_3,
			Icon = ((text == "winsettings") ? "fa:Light_Cog" : "shellicon:c:\\windows\\system32\\control.exe"),
			TitleMatchPositions = multiFieldMatchResult_0?.Result1?.GetMatchPositions(),
			DescriptionMatchPositions = multiFieldMatchResult_0?.Result2?.GetMatchPositions(),
			Score = (double)(multiFieldMatchResult_0?.Score ?? 0) * (flag ? 0.9 : 1.0),
			HistoryData = string_2
		};
	}

	public override SearchResultItem GetResultFromHistoryItem(SearchHistoryItem searchHistoryItem_0)
	{
		string historyData = searchHistoryItem_0.HistoryData;
		return AootEY6K8mc(historyData, null, historyData.Split(new char[1] { '|' }, 4), null);
	}

	public bool BuildContextMenu(SearchResultItem searchResultItem_0, ContextMenu contextMenu_0, Window window_0)
	{
		_003C_003Ec__DisplayClass30_0 _003C_003Ec__DisplayClass30_ = new _003C_003Ec__DisplayClass30_0();
		_003C_003Ec__DisplayClass30_.ioSv68IRyPU = searchResultItem_0;
		_003C_003Ec__DisplayClass30_.xuav6y72sOl = _003C_003Ec__DisplayClass30_.ioSv68IRyPU.TextData;
		if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass30_.xuav6y72sOl))
		{
			return false;
		}
		AppHelper.AddMenuItem(contextMenu_0.Items, "复制为动作", "创建一个动作并复制到剪贴板，可以在面板上空白位置粘贴。", "fa:Light_Copy:#007eff", _003C_003Ec__DisplayClass30_.LNbv6PxmA1l);
		AppHelper.AddMenuItem(contextMenu_0.Items, "复制命令", "复制当前命令到剪贴板", "fa:Light_Copy:#007eff", _003C_003Ec__DisplayClass30_.lKQv6EjXMDB);
		return true;
	}

	static ONgL3r2gY2UDTxHt94I()
	{
		u0KtEIVADvi = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool D7gkRfQDkp5ldgY1gOBt()
	{
		return NVdiroQDJVsCmOaSs7LN == null;
	}
}
