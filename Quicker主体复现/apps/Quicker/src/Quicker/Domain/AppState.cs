using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using b1cqfYwMXvNpZCY2I0h;
using Ci3RULiH5a8Cgg0fIS5;
using Eig9SsjOuVOUIUYQlrX;
using GEs2Jejr6IXgOTY0tM8;
using HMdjedXPwaug8yh9mEq;
using Ninject;
using O2cJaejzKucHfiZGXB0;
using Quicker.Common;
using Quicker.Common.Entities;
using Quicker.Domain.Entities;
using Quicker.Domain.Floating;
using Quicker.Domain.Profiles;
using Quicker.Domain.Push;
using Quicker.Domain.Services;
using Quicker.Domain.Skining;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.UI;
using Quicker.Utilities.Win32;
using Quicker.View;
using t8SGKhhgLWTgeqjGcrq;
using ToastNotifications;

namespace Quicker.Domain;

public static class AppState
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec BpJvX8AdOsO;

		public static Action<System.Windows.Controls.ContextMenu> NeZvXaZ2Jcj;

		public static Action XFKvX7MZfk8;

		internal static _003C_003Ec gHgeJXc6FRRwqrbOZwpa;

		static _003C_003Ec()
		{
			BpJvX8AdOsO = new _003C_003Ec();
		}

		internal void FBlvXEpx1F5(System.Windows.Controls.ContextMenu x)
		{
			x.IsOpen = false;
		}

		internal void rV6vXyRhDVU()
		{
			Thread.Sleep(5000);
			GC.Collect();
		}

		internal static bool SZ0GKvc6c2M4P79BKNBM()
		{
			return gHgeJXc6FRRwqrbOZwpa == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass61_0
	{
		public List<System.Windows.Controls.ContextMenu> KHXvXqMHScJ;

		private static _003C_003Ec__DisplayClass61_0 syktk8c6y7YTdGRIKGTX;

		internal void uCevXRMGVcP()
		{
			KHXvXqMHScJ.ForEach(_003C_003Ec.NeZvXaZ2Jcj ?? (_003C_003Ec.NeZvXaZ2Jcj = _003C_003Ec.BpJvX8AdOsO.FBlvXEpx1F5));
		}

		internal static bool nUxfUec6p6WkHrC2ZDlU()
		{
			return syktk8c6y7YTdGRIKGTX == null;
		}
	}

	[CompilerGenerated]
	private static bool PK1t7GPVRkm;

	[CompilerGenerated]
	private static ITinyMessengerHub yQtt7scCuPD;

	[CompilerGenerated]
	private static Notifier wsst7HK5LcG;

	[CompilerGenerated]
	private static PopupWindow xXwt718rwvP;

	[CompilerGenerated]
	private static readonly IList<string> oYmt7b1yYaB;

	private static uint NG5t76rEI2g;

	[CompilerGenerated]
	private static DataService rDVt7XDrlwv;

	[CompilerGenerated]
	private static AppServer q4Ht7mfQxdn;

	[CompilerGenerated]
	private static ActiveWindowHook eMEt7KMJIry;

	[CompilerGenerated]
	private static ProfileManager QcGt7xc772a;

	[CompilerGenerated]
	private static IKernel KcKt7rILyUf;

	[CompilerGenerated]
	private static long YPut7pvAOGn;

	internal static readonly RecentActionMgr P7gt7BYmHZ0;

	[CompilerGenerated]
	private static readonly IList<System.Windows.Controls.ContextMenu> YMrt7QAA9NW;

	[CompilerGenerated]
	private static int vPet7jchCbE;

	[CompilerGenerated]
	private static string nT5t7nTRyVi;

	public static Stopwatch startupWatch;

	[CompilerGenerated]
	private static ActionEditMgr sK0t74EPQk2;

	[CompilerGenerated]
	private static int IaOt75XTjK0;

	[CompilerGenerated]
	private static ActionItem y7ut7DVCahi;

	[CompilerGenerated]
	private static ActionProfile KKUt7dr8NMF;

	[CompilerGenerated]
	private static bool gGxt7oITF39;

	[CompilerGenerated]
	private static MouseButtons vDkt7TmbJNQ;

	[CompilerGenerated]
	private static SkinInfo xe9t7MsF5IS;

	[CompilerGenerated]
	private static UIy1pYiDsLcf2l4joSP lyLt7AXxWnE;

	[CompilerGenerated]
	private static IntPtr Dxpt7OYfByK;

	private static long Hast7F24KW3;

	[CompilerGenerated]
	private static UsageCounter Opot7UUrqTI;

	private static int qast7lt0IQR;

	private static string J73t7ih4NuS;

	public static SQLDataMgr SQLDataMgr;

	private static string TCGt73IOo0m;

	private static int oEqt7fa9tBk;

	[CompilerGenerated]
	private static brgW8EX9ZVfZExh7q9t Tgmt7z5s1lt;

	[CompilerGenerated]
	private static TextFloatPanelMgr FaNtRwMJODL;

	[CompilerGenerated]
	private static bool oNttRtp4wBm;

	[CompilerGenerated]
	private static AutoRunService Jx6tRgO8ULM;

	[CompilerGenerated]
	private static PushClient ahktRLYmXMY;

	[CompilerGenerated]
	private static NotifyIconWrapper RAgtRvAfN5e;

	[CompilerGenerated]
	private static bool iI6tRS0bRTP;

	[CompilerGenerated]
	private static string E8wtR2NWKTe;

	[CompilerGenerated]
	private static readonly IList<IntPtr> r6ctRuPsmMj;

	[CompilerGenerated]
	private static long xHotRNaaTkB;

	[CompilerGenerated]
	private static long ComtRJdStRV;

	[CompilerGenerated]
	private static FloatButtonAndPanelManager YqNtR0X7xYT;

	[CompilerGenerated]
	private static bool ftftRPuxZqZ;

	[CompilerGenerated]
	private static WsnAlhjCfHjoVZXu241 miItREqyZBb;

	[CompilerGenerated]
	private static GjEIhFja8p2K53Rulg4 EJetRyfKOd0;

	[CompilerGenerated]
	private static long JUntR8RiGbg;

	[CompilerGenerated]
	private static string RJ8tRaMjXko;

	[CompilerGenerated]
	private static Guid oEDtR7B9JUF;

	[CompilerGenerated]
	private static long FLFtRRIiK3U;

	[CompilerGenerated]
	private static bool oIUtRqM4U28;

	[CompilerGenerated]
	private static bool MR5tRcrPJsu;

	[CompilerGenerated]
	private static bool D46tRVSYBr3;

	[CompilerGenerated]
	private static readonly Pnds5QjnQ0GJ2J2HHwg EMotRZEQTL2;

	[CompilerGenerated]
	private static hCyEQ4wY2DjoFMCBvTM Hm2tR9BgqBt;

	[CompilerGenerated]
	private static long I8ctRhmdWXh;

	[CompilerGenerated]
	private static long GeltReL7mRa;

	[CompilerGenerated]
	private static long s4TtRYtofQi;

	[CompilerGenerated]
	private static long n3ptRIf9QBQ;

	[CompilerGenerated]
	private static long d3ftRWpcxbi;

	[CompilerGenerated]
	private static string iKYtRkLAtSg;

	[CompilerGenerated]
	private static long MvStRGWsxU2;

	[CompilerGenerated]
	private static bool AHLtRsy8IEy;

	[CompilerGenerated]
	private static bool NxutRHvCnyi;

	private static object ArXCg5QEmRR8PuEBEHOZ;

	public static bool IsAutoRun
	{
		[CompilerGenerated]
		get
		{
			return PK1t7GPVRkm;
		}
		[CompilerGenerated]
		set
		{
			PK1t7GPVRkm = value;
		}
	}

	public static IList<string> ActionTags
	{
		[CompilerGenerated]
		get
		{
			return oYmt7b1yYaB;
		}
	}

	public static uint QuickerProcessId
	{
		get
		{
			if (NG5t76rEI2g == 0)
			{
				NG5t76rEI2g = NativeMethods.GetCurrentProcessId();
			}
			return NG5t76rEI2g;
		}
	}

	public static DataService DataService
	{
		[CompilerGenerated]
		get
		{
			return rDVt7XDrlwv;
		}
		[CompilerGenerated]
		set
		{
			rDVt7XDrlwv = value;
		}
	}

	public static UserPreference UserPreference => rDVt7XDrlwv.UserPreference;

	public static AppServer AppServer
	{
		[CompilerGenerated]
		get
		{
			return q4Ht7mfQxdn;
		}
		[CompilerGenerated]
		set
		{
			q4Ht7mfQxdn = value;
		}
	}

	public static long LastClipboardChangeTime
	{
		[CompilerGenerated]
		get
		{
			return YPut7pvAOGn;
		}
		[CompilerGenerated]
		private set
		{
			YPut7pvAOGn = value;
		}
	}

	public static int ClipboardSequenceNumber
	{
		get
		{
			return oEqt7fa9tBk;
		}
		set
		{
			oEqt7fa9tBk = value;
			LastClipboardChangeTime = AppHelper.fLiLTj0x4QY();
		}
	}

	public static bool HasOpenContextMenu => YMrt7QAA9NW.HasData();

	public static string CurrentProcessName
	{
		get
		{
			return TCGt73IOo0m;
		}
		set
		{
			TCGt73IOo0m = value;
		}
	}

	public static int CurrentProcessId
	{
		[CompilerGenerated]
		get
		{
			return vPet7jchCbE;
		}
		[CompilerGenerated]
		set
		{
			vPet7jchCbE = value;
		}
	}

	public static string CurrentExeName
	{
		get
		{
			return J73t7ih4NuS ?? "";
		}
		set
		{
			J73t7ih4NuS = value;
		}
	}

	public static string CurrentExePath
	{
		[CompilerGenerated]
		get
		{
			return nT5t7nTRyVi;
		}
		[CompilerGenerated]
		set
		{
			nT5t7nTRyVi = value;
		}
	}

	public static int UiThreadId
	{
		[CompilerGenerated]
		get
		{
			return IaOt75XTjK0;
		}
		[CompilerGenerated]
		set
		{
			IaOt75XTjK0 = value;
		}
	}

	public static ActionItem CuttingAction
	{
		[CompilerGenerated]
		get
		{
			return y7ut7DVCahi;
		}
		[CompilerGenerated]
		set
		{
			y7ut7DVCahi = value;
		}
	}

	public static ActionProfile CuttingActionProfile
	{
		[CompilerGenerated]
		get
		{
			return KKUt7dr8NMF;
		}
		[CompilerGenerated]
		set
		{
			KKUt7dr8NMF = value;
		}
	}

	public static bool EnableDetailedLogging
	{
		[CompilerGenerated]
		get
		{
			return gGxt7oITF39;
		}
		[CompilerGenerated]
		set
		{
			gGxt7oITF39 = value;
		}
	}

	public static MouseButtons LastClickMouseButton
	{
		[CompilerGenerated]
		get
		{
			return vDkt7TmbJNQ;
		}
		[CompilerGenerated]
		set
		{
			vDkt7TmbJNQ = value;
		}
	}

	public static SkinInfo SkinInfo
	{
		[CompilerGenerated]
		get
		{
			return xe9t7MsF5IS;
		}
		[CompilerGenerated]
		set
		{
			xe9t7MsF5IS = value;
		}
	}

	public static IntPtr MainWinHandle
	{
		[CompilerGenerated]
		get
		{
			return Dxpt7OYfByK;
		}
		[CompilerGenerated]
		set
		{
			Dxpt7OYfByK = value;
		}
	}

	public static long TickCount => AppHelper.fLiLTj0x4QY() - Hast7F24KW3;

	public static int EscCounter
	{
		get
		{
			return qast7lt0IQR;
		}
		set
		{
			qast7lt0IQR = value;
		}
	}

	public static TextFloatPanelMgr TextFloatPanelMgr
	{
		[CompilerGenerated]
		get
		{
			return FaNtRwMJODL;
		}
		[CompilerGenerated]
		set
		{
			FaNtRwMJODL = value;
		}
	}

	public static bool IsTestingMouse
	{
		[CompilerGenerated]
		get
		{
			return oNttRtp4wBm;
		}
		[CompilerGenerated]
		private set
		{
			oNttRtp4wBm = value;
		}
	}

	public static PushClient PushClient
	{
		[CompilerGenerated]
		get
		{
			return ahktRLYmXMY;
		}
		[CompilerGenerated]
		set
		{
			ahktRLYmXMY = value;
		}
	}

	public static NotifyIconWrapper NotifyIconWrapper
	{
		[CompilerGenerated]
		get
		{
			return RAgtRvAfN5e;
		}
		[CompilerGenerated]
		set
		{
			RAgtRvAfN5e = value;
		}
	}

	public static bool IsFirstStartInSameDay
	{
		[CompilerGenerated]
		get
		{
			return iI6tRS0bRTP;
		}
		[CompilerGenerated]
		set
		{
			iI6tRS0bRTP = value;
		}
	}

	public static string ExeBeforeShowConfigWindow
	{
		[CompilerGenerated]
		get
		{
			return E8wtR2NWKTe;
		}
		[CompilerGenerated]
		set
		{
			E8wtR2NWKTe = value;
		}
	}

	public static IList<IntPtr> ImageViewerWindows
	{
		[CompilerGenerated]
		get
		{
			return r6ctRuPsmMj;
		}
	}

	public static long LastMouseMoveTicks
	{
		[CompilerGenerated]
		get
		{
			return xHotRNaaTkB;
		}
		[CompilerGenerated]
		set
		{
			xHotRNaaTkB = value;
		}
	}

	public static long LastSystemResumeTime
	{
		[CompilerGenerated]
		get
		{
			return ComtRJdStRV;
		}
		[CompilerGenerated]
		set
		{
			ComtRJdStRV = value;
		}
	}

	public static long LastEscSendTick
	{
		[CompilerGenerated]
		get
		{
			return JUntR8RiGbg;
		}
		[CompilerGenerated]
		private set
		{
			JUntR8RiGbg = value;
		}
	}

	public static long SessionUnlockTime
	{
		[CompilerGenerated]
		get
		{
			return FLFtRRIiK3U;
		}
		[CompilerGenerated]
		set
		{
			FLFtRRIiK3U = value;
		}
	}

	public static bool IsAppLoaded
	{
		[CompilerGenerated]
		get
		{
			return oIUtRqM4U28;
		}
		[CompilerGenerated]
		set
		{
			oIUtRqM4U28 = value;
		}
	}

	public static bool IsWindowsLocked
	{
		[CompilerGenerated]
		get
		{
			return MR5tRcrPJsu;
		}
		[CompilerGenerated]
		set
		{
			MR5tRcrPJsu = value;
		}
	}

	public static bool IsComputerSuspended
	{
		[CompilerGenerated]
		get
		{
			return D46tRVSYBr3;
		}
		[CompilerGenerated]
		set
		{
			D46tRVSYBr3 = value;
		}
	}

	public static long LastQuickerGetSelectedTime
	{
		[CompilerGenerated]
		get
		{
			return I8ctRhmdWXh;
		}
		[CompilerGenerated]
		private set
		{
			I8ctRhmdWXh = value;
		}
	}

	public static long LastQuickerPasteTime
	{
		[CompilerGenerated]
		get
		{
			return GeltReL7mRa;
		}
		[CompilerGenerated]
		private set
		{
			GeltReL7mRa = value;
		}
	}

	public static long LastInputTime
	{
		[CompilerGenerated]
		get
		{
			return s4TtRYtofQi;
		}
		[CompilerGenerated]
		private set
		{
			s4TtRYtofQi = value;
		}
	}

	public static long LastMouseInputTime
	{
		[CompilerGenerated]
		get
		{
			return n3ptRIf9QBQ;
		}
		[CompilerGenerated]
		private set
		{
			n3ptRIf9QBQ = value;
		}
	}

	public static long LastKeyboardInputTime
	{
		[CompilerGenerated]
		get
		{
			return d3ftRWpcxbi;
		}
		[CompilerGenerated]
		private set
		{
			d3ftRWpcxbi = value;
		}
	}

	public static string AlwaysDebugActionId
	{
		[CompilerGenerated]
		get
		{
			return iKYtRkLAtSg;
		}
		[CompilerGenerated]
		set
		{
			iKYtRkLAtSg = value;
		}
	}

	public static long TriggerWindowHideTime
	{
		[CompilerGenerated]
		get
		{
			return MvStRGWsxU2;
		}
		[CompilerGenerated]
		set
		{
			MvStRGWsxU2 = value;
		}
	}

	public static bool IsGpuDisabled
	{
		[CompilerGenerated]
		get
		{
			return AHLtRsy8IEy;
		}
		[CompilerGenerated]
		set
		{
			AHLtRsy8IEy = value;
		}
	}

	public static bool LockFloatButtonPosition
	{
		[CompilerGenerated]
		get
		{
			return NxutRHvCnyi;
		}
		[CompilerGenerated]
		set
		{
			NxutRHvCnyi = value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal static ITinyMessengerHub Y2RtaqSv0AQ()
	{
		return yQtt7scCuPD;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void xgStac0L3cP(ITinyMessengerHub value)
	{
		yQtt7scCuPD = value;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static Notifier vVktaZmxU7S()
	{
		return wsst7HK5LcG;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void i5yta9e2I0t(Notifier value)
	{
		wsst7HK5LcG = value;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static PopupWindow HS2taepcAbc()
	{
		return xXwt718rwvP;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void c2BtaYRb15y(PopupWindow value)
	{
		xXwt718rwvP = value;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static ActiveWindowHook r4itaWBnyVQ()
	{
		return eMEt7KMJIry;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void Iqptak9JseT(ActiveWindowHook value)
	{
		eMEt7KMJIry = value;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static ProfileManager B2BtasP38AU()
	{
		return QcGt7xc772a;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void Jr9taHpXS6X(ProfileManager value)
	{
		QcGt7xc772a = value;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static IKernel dAntabrFWrV()
	{
		return KcKt7rILyUf;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void VV8ta6eYDoe(IKernel value)
	{
		KcKt7rILyUf = value;
	}

	[Obsolete("不再使用，改为使用事件处理")]
	public static void RegisterContextMenu(System.Windows.Controls.ContextMenu contextMenu)
	{
	}

	internal static void StGta80AIo8()
	{
		EventManager.RegisterClassHandler(typeof(global::System.Windows.Controls.ContextMenu), System.Windows.Controls.ContextMenu.OpenedEvent, new RoutedEventHandler(jSita70muTy));
		EventManager.RegisterClassHandler(typeof(System.Windows.Controls.ContextMenu), System.Windows.Controls.ContextMenu.ClosedEvent, new RoutedEventHandler(T27taattS6N));
	}

	private static void T27taattS6N(object sender, RoutedEventArgs e)
	{
		if (sender is System.Windows.Controls.ContextMenu item && YMrt7QAA9NW.Contains(item))
		{
			YMrt7QAA9NW.Remove(item);
		}
	}

	private static void jSita70muTy(object sender, RoutedEventArgs e)
	{
		if (sender is System.Windows.Controls.ContextMenu item)
		{
			YMrt7QAA9NW.Add(item);
		}
	}

	public static bool CloseAllContextMenus()
	{
		bool result = false;
		if (YMrt7QAA9NW.HasData())
		{
			_003C_003Ec__DisplayClass61_0 _003C_003Ec__DisplayClass61_ = new _003C_003Ec__DisplayClass61_0();
			_003C_003Ec__DisplayClass61_.KHXvXqMHScJ = YMrt7QAA9NW.ToList();
			YMrt7QAA9NW.Clear();
			AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass61_.uCevXRMGVcP);
			result = true;
		}
		return result;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static ActionEditMgr lWutartRfUY()
	{
		return sK0t74EPQk2;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void COBtapKhJtY(ActionEditMgr value)
	{
		sK0t74EPQk2 = value;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static UIy1pYiDsLcf2l4joSP v5FtaQ4hQfg()
	{
		return lyLt7AXxWnE;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void aeDtajUpah8(UIy1pYiDsLcf2l4joSP value)
	{
		lyLt7AXxWnE = value;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static UsageCounter Lista4qx2wK()
	{
		return Opot7UUrqTI;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void U1Lta5Cv1Ft(UsageCounter value)
	{
		Opot7UUrqTI = value;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static brgW8EX9ZVfZExh7q9t aXRtadMEfsj()
	{
		return Tgmt7z5s1lt;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void N6Ltao56yJF(brgW8EX9ZVfZExh7q9t value)
	{
		Tgmt7z5s1lt = value;
	}

	public static void IncreaseEscCounter()
	{
		Interlocked.Increment(ref qast7lt0IQR);
	}

	[SpecialName]
	internal static UserSettings HHxtaMaoqJr()
	{
		return rDVt7XDrlwv?.CpItmVISR7P();
	}

	[SpecialName]
	[CompilerGenerated]
	internal static AutoRunService e8GtaFtc06Z()
	{
		return Jx6tRgO8ULM;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void b4WtaUaqAg7(AutoRunService value)
	{
		Jx6tRgO8ULM = value;
	}

	public static void EndTestingMouse()
	{
		IsTestingMouse = false;
	}

	public static void BeginTestingMouse()
	{
		IsTestingMouse = true;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static FloatButtonAndPanelManager TKStaiOMyPb()
	{
		return YqNtR0X7xYT;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void L19ta3UhRbZ(FloatButtonAndPanelManager value)
	{
		YqNtR0X7xYT = value;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static bool sD1t7gME9aw()
	{
		return ftftRPuxZqZ;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void ahyt7LTMcOZ(bool value)
	{
		ftftRPuxZqZ = value;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static WsnAlhjCfHjoVZXu241 vjAt7Seco0Y()
	{
		return miItREqyZBb;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void eHot72UTS83(WsnAlhjCfHjoVZXu241 value)
	{
		miItREqyZBb = value;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static GjEIhFja8p2K53Rulg4 JIKt7NpAUuR()
	{
		return EJetRyfKOd0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void m8Ot7JmPc2k(GjEIhFja8p2K53Rulg4 value)
	{
		EJetRyfKOd0 = value;
	}

	public static void ScheduleGc()
	{
		Task.Run(_003C_003Ec.XFKvX7MZfk8 ?? (_003C_003Ec.XFKvX7MZfk8 = _003C_003Ec.BpJvX8AdOsO.rV6vXyRhDVU));
	}

	public static void RecordLastEscSendTick()
	{
		LastEscSendTick = AppHelper.fLiLTj0x4QY();
	}

	[SpecialName]
	[CompilerGenerated]
	internal static string VyZt7PZDFO1()
	{
		return RJ8tRaMjXko;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void K7At7EG7JcB(string value)
	{
		RJ8tRaMjXko = value;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static Guid y6Rt78JCICI()
	{
		return oEDtR7B9JUF;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void AWPt7aBJgwA(Guid value)
	{
		oEDtR7B9JUF = value;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static Pnds5QjnQ0GJ2J2HHwg HZUt7RIVqKK()
	{
		return EMotRZEQTL2;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static hCyEQ4wY2DjoFMCBvTM uICt7cXc7Qs()
	{
		return Hm2tR9BgqBt;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void Xbft7VsD93B(hCyEQ4wY2DjoFMCBvTM value)
	{
		Hm2tR9BgqBt = value;
	}

	[SpecialName]
	internal static bool xhbt79wekbs()
	{
		return xXwt718rwvP.ksKgTEQWlfo();
	}

	public static void LogQuickerGetSelected()
	{
		LastQuickerGetSelectedTime = AppHelper.fLiLTj0x4QY();
	}

	public static void LogQuickerPaste()
	{
		LastQuickerPasteTime = AppHelper.fLiLTj0x4QY();
	}

	internal static void jqKtaRtl9EB(bool bool_11)
	{
		LastInputTime = AppHelper.fLiLTj0x4QY();
		if (bool_11)
		{
			LastKeyboardInputTime = s4TtRYtofQi;
		}
		else
		{
			LastMouseInputTime = s4TtRYtofQi;
		}
	}

	public static void LogTriggerWindowHideTime()
	{
		TriggerWindowHideTime = AppHelper.fLiLTj0x4QY();
	}

	static AppState()
	{
		wsst7HK5LcG = null;
		oYmt7b1yYaB = new List<string>
		{
			"查询搜索", "翻译", "文本处理", "图片操作", "编程相关", "剪贴板相关", "Windows", "文件处理", "全局快捷键", "资源管理器",
			"组合操作", "功能增强", "应用内快捷键", "功能", "脚本", "启动", "网络服务", "OCR", "示例", "AI",
			"其他"
		};
		NG5t76rEI2g = 0u;
		P7gt7BYmHZ0 = new RecentActionMgr();
		YMrt7QAA9NW = new List<System.Windows.Controls.ContextMenu>();
		startupWatch = Stopwatch.StartNew();
		xe9t7MsF5IS = new SkinInfo();
		Hast7F24KW3 = AppHelper.fLiLTj0x4QY();
		J73t7ih4NuS = "";
		TCGt73IOo0m = "";
		r6ctRuPsmMj = new List<IntPtr>();
		EMotRZEQTL2 = new Pnds5QjnQ0GJ2J2HHwg();
		s4TtRYtofQi = AppHelper.fLiLTj0x4QY();
		n3ptRIf9QBQ = AppHelper.fLiLTj0x4QY();
		d3ftRWpcxbi = AppHelper.fLiLTj0x4QY();
		NxutRHvCnyi = false;
	}

	internal static bool C6tPaPQEsLcApgZQQ6eB()
	{
		return ArXCg5QEmRR8PuEBEHOZ == null;
	}
}
