using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Interop;
using System.Windows.Media.Imaging;
using C8IuHF5Ip1eAopkYaWg;
using log4net;
using ManagedShell.Common.Helpers;
using ManagedShell.Common.Logging;
using ManagedShell.Interop;
using ManagedShell.ShellFolders;
using ManagedShell.ShellFolders.Enums;
using ManagedShell.ShellFolders.Interfaces;
using P9ImGWAAc7TOpg50ewA;
using Quicker.Native.ShellMenu;

namespace GVkGVl5Ci2QOrxD8FOU;

internal class EqtTCe5xOs4YVatqr3K : ShellContextMenu
{
	public delegate bool hG0B2euykgOb8iotsFr(string command, ShellItem[] items, bool allFolders);

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass11_0
	{
		public string[] lt6vcDUmLHH;

		internal static _003C_003Ec__DisplayClass11_0 vrdQ4PcNWpl0ADkHi98j;

		internal bool OwHvc5CQ8Ff(KEaK5nA5w4pj7wbFuOW x)
		{
			return !lt6vcDUmLHH.Contains(x.Command);
		}

		internal static bool h8XbdmcNy9V3Z25m320i()
		{
			return vrdQ4PcNWpl0ADkHi98j == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass18_0
	{
		public EqtTCe5xOs4YVatqr3K dFlvcdEZdNC;

		public int qgNvcojEJLe;

		internal static _003C_003Ec__DisplayClass18_0 qijhYicNXJwqmqqEO3LZ;

		internal static bool A6k5oicN2FSSKvlT65TP()
		{
			return qijhYicNXJwqmqqEO3LZ == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass18_1
	{
		public MENUITEMINFO bxlvcMeg0qk;

		public _003C_003Ec__DisplayClass18_0 pI4vcA5kBjx;

		private static _003C_003Ec__DisplayClass18_1 OpafgxcNnxOWQghPlb0I;

		internal void KbavcTcmXpB(IntPtr indexPointer)
		{
			Marshal.WriteInt32(indexPointer, pI4vcA5kBjx.qgNvcojEJLe);
			try
			{
				if ((pI4vcA5kBjx.dFlvcdEZdNC.iContextMenu3 == null || pI4vcA5kBjx.dFlvcdEZdNC.iContextMenu3.HandleMenuMsg2(279u, bxlvcMeg0qk.hSubMenu, indexPointer, IntPtr.Zero) != 0L) && pI4vcA5kBjx.dFlvcdEZdNC.iContextMenu2 != null)
				{
					pI4vcA5kBjx.dFlvcdEZdNC.iContextMenu2.HandleMenuMsg(279u, bxlvcMeg0qk.hSubMenu, indexPointer);
				}
			}
			catch (Exception ex)
			{
				tYvBAuw3HU.Warn("Shell菜单调用异常：" + ex.Message, ex);
			}
		}

		internal static bool TxbB6jcNeoqX7k6Tpnax()
		{
			return OpafgxcNnxOWQghPlb0I == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass19_0
	{
		public EqtTCe5xOs4YVatqr3K aLxvcOBhUw0;

		public int wAivcFeuoVw;

		private static _003C_003Ec__DisplayClass19_0 SvZgKtcNGQVIEnlSsgsR;

		internal static bool IM2DW0cN01GFigUXkgrU()
		{
			return SvZgKtcNGQVIEnlSsgsR == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass19_1
	{
		public MENUITEMINFO gk5vcl5vle6;

		public _003C_003Ec__DisplayClass19_0 yrKvci4N4QV;

		private static _003C_003Ec__DisplayClass19_1 dOB6pncNK2sMfo2cHq7a;

		internal void rAPvcURYaVg(IntPtr indexPointer)
		{
			Marshal.WriteInt32(indexPointer, yrKvci4N4QV.wAivcFeuoVw);
			if ((yrKvci4N4QV.aLxvcOBhUw0.iContextMenu3 == null || yrKvci4N4QV.aLxvcOBhUw0.iContextMenu3.HandleMenuMsg2(279u, gk5vcl5vle6.hSubMenu, indexPointer, IntPtr.Zero) != 0L) && yrKvci4N4QV.aLxvcOBhUw0.iContextMenu2 != null)
			{
				yrKvci4N4QV.aLxvcOBhUw0.iContextMenu2.HandleMenuMsg(279u, gk5vcl5vle6.hSubMenu, indexPointer);
			}
		}

		internal static bool zI5b3LcNBPBHLB0YKabW()
		{
			return dOB6pncNK2sMfo2cHq7a == null;
		}
	}

	private readonly ShellItem[] UgABopNZxw;

	private readonly hG0B2euykgOb8iotsFr r19BTno7MZ;

	private bool XmJBM7jBnS;

	private static readonly log4net.ILog tYvBAuw3HU;

	internal static EqtTCe5xOs4YVatqr3K m5NyJot15dFk8sLmxdK;

	public EqtTCe5xOs4YVatqr3K(ShellItem[] shellItem_1, ShellFolder shellFolder_0, IntPtr intptr_0, hG0B2euykgOb8iotsFr hG0B2euykgOb8iotsFr_1, bool bool_1)
	{
		UgABopNZxw = shellItem_1;
		if (shellItem_1 != null && shellItem_1.Length >= 1)
		{
			lock (IconHelper.ComLock)
			{
				x = Cursor.Position.X;
				y = Cursor.Position.Y;
				r19BTno7MZ = hG0B2euykgOb8iotsFr_1;
				fjqBX9wtbE(shellItem_1, shellFolder_0, intptr_0, true, bool_1);
			}
		}
	}

	private void fjqBX9wtbE(ShellItem[] shellItem_1, ShellFolder shellFolder_0, IntPtr intptr_0, bool bool_1, bool bool_2)
	{
		try
		{
			CMF cMF = default(CMF);
			int num;
			if (KUBBrBQx3C(shellItem_1, shellFolder_0, intptr_0, out iContextMenuPtr, out iContextMenu))
			{
				cMF = (CMF)(0x84 | (((Control.ModifierKeys & Keys.Shift) != Keys.None) ? 256 : 0));
				num = 1;
				if (!NXZMaptKFAHW0GcZLYm())
				{
					goto IL_005a;
				}
			}
			else
			{
				ShellLogger.Error("ShellItemContextMenu: Error retrieving IContextMenu");
				num = 0;
				if (m5NyJot15dFk8sLmxdK != null)
				{
					goto IL_005a;
				}
			}
			goto IL_005b;
			IL_005a:
			int num2 = default(int);
			num = num2;
			goto IL_005b;
			IL_005b:
			switch (num)
			{
			case 1:
				if (bool_2)
				{
					cMF |= CMF.CANRENAME;
				}
				if (!bool_1)
				{
					cMF |= CMF.DEFAULTONLY;
				}
				nativeMenuPtr = ManagedShell.ShellFolders.Interop.CreatePopupMenu();
				iContextMenu.QueryContextMenu(nativeMenuPtr, 0u, 1u, 30000u, cMF);
				if (bool_1)
				{
					if (Marshal.QueryInterface(iContextMenuPtr, ref ManagedShell.ShellFolders.Interop.IID_IContextMenu2, out iContextMenu2Ptr) == 0 && iContextMenu2Ptr != IntPtr.Zero)
					{
						try
						{
							iContextMenu2 = (IContextMenu2)Marshal.GetTypedObjectForIUnknown(iContextMenu2Ptr, typeof(IContextMenu2));
						}
						catch (Exception ex)
						{
							ShellLogger.Error("ShellItemContextMenu: Error retrieving IContextMenu2 interface: " + ex.Message);
						}
					}
					if (Marshal.QueryInterface(iContextMenuPtr, ref ManagedShell.ShellFolders.Interop.IID_IContextMenu3, out iContextMenu3Ptr) == 0 && iContextMenu3Ptr != IntPtr.Zero)
					{
						try
						{
							iContextMenu3 = (IContextMenu3)Marshal.GetTypedObjectForIUnknown(iContextMenu3Ptr, typeof(IContextMenu3));
							break;
						}
						catch (Exception ex2)
						{
							ShellLogger.Error("ShellItemContextMenu: Error retrieving IContextMenu3 interface: " + ex2.Message);
							break;
						}
					}
				}
				else
				{
					uint menuDefaultItem = ManagedShell.ShellFolders.Interop.GetMenuDefaultItem(nativeMenuPtr, 0u, 0u);
					wbMBKjF03w(shellItem_1, menuDefaultItem, jxlBxeOOYq(UgABopNZxw));
				}
				break;
			case 0:
				break;
			}
		}
		catch (Exception ex3)
		{
			ShellLogger.Error("ShellItemContextMenu: Error building context menu: " + ex3.Message);
		}
	}

	public void Dispose()
	{
		DestroyHandle();
		FreeResources();
		ShellItem[] ugABopNZxw = UgABopNZxw;
		int num = 0;
		while (num < ugABopNZxw.Length)
		{
			ugABopNZxw[num].Dispose();
			num++;
			if (m5NyJot15dFk8sLmxdK != null)
			{
				switch (0)
				{
				}
			}
		}
	}

	public void XfKBmw1Xbp()
	{
		CreateHandle(new CreateParams());
		if (EnvironmentHelper.IsWindows10DarkModeSupported)
		{
			NativeMethods.AllowDarkModeForWindow(base.Handle, true);
		}
		uint uint_ = ManagedShell.ShellFolders.Interop.TrackPopupMenuEx(nativeMenuPtr, TPM.RETURNCMD, x, y, base.Handle, IntPtr.Zero);
		wbMBKjF03w(UgABopNZxw, uint_, jxlBxeOOYq(UgABopNZxw));
	}

	private void wbMBKjF03w(ShellItem[] shellItem_1, uint uint_0, bool bool_1)
	{
		if (uint_0 < 1 || uint_0 >= uint.MaxValue)
		{
			return;
		}
		string text = GetCommandString(iContextMenu, uint_0 - 1, true);
		string workingDir = null;
		int num = 0;
		if (!NXZMaptKFAHW0GcZLYm())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (string.IsNullOrEmpty(text))
		{
			text = uint_0.ToString();
		}
		if (r19BTno7MZ == null || !r19BTno7MZ(text, shellItem_1, bool_1))
		{
			if (shellItem_1.Length != 0 && shellItem_1[0].ParentItem != null && shellItem_1[0].ParentItem.IsFolder && shellItem_1[0].ParentItem.IsFileSystem)
			{
				workingDir = shellItem_1[0].ParentItem.Path;
			}
			InvokeCommand(iContextMenu, workingDir, uint_0 - 1, new System.Drawing.Point(x, y));
		}
	}

	private bool jxlBxeOOYq(ShellItem[] shellItem_1)
	{
		bool result = true;
		int num = 0;
		int num3 = default(int);
		while (num < shellItem_1.Length)
		{
			ShellItem shellItem = shellItem_1[num];
			if (shellItem.IsNavigableFolder && shellItem.IsFileSystem)
			{
				num++;
				int num2 = 0;
				if (m5NyJot15dFk8sLmxdK != null)
				{
					num2 = num3;
				}
				switch (num2)
				{
				}
				continue;
			}
			result = false;
			break;
		}
		return result;
	}

	protected bool KUBBrBQx3C(ShellItem[] shellItem_1, ShellFolder shellFolder_0, IntPtr intptr_0, out IntPtr intptr_1, out IContextMenu icontextMenu_0)
	{
		if (shellItem_1.Length < 1)
		{
			intptr_1 = IntPtr.Zero;
			icontextMenu_0 = null;
			return false;
		}
		IntPtr[] array = new IntPtr[shellItem_1.Length];
		for (int i = 0; i < shellItem_1.Length; i++)
		{
			array[i] = shellItem_1[i].RelativePidl;
		}
		if (shellFolder_0.ShellFolderInterface.GetUIObjectOf(intptr_0, (uint)array.Length, array, ref ManagedShell.ShellFolders.Interop.IID_IContextMenu, IntPtr.Zero, out intptr_1) == 0)
		{
			icontextMenu_0 = (IContextMenu)Marshal.GetTypedObjectForIUnknown(intptr_1, typeof(IContextMenu));
			return true;
		}
		intptr_1 = IntPtr.Zero;
		icontextMenu_0 = null;
		int num = 0;
		if (!NXZMaptKFAHW0GcZLYm())
		{
			int num2 = default(int);
			num = num2;
		}
		return num switch
		{
			_ => false, 
		};
	}

	public IList<KEaK5nA5w4pj7wbFuOW> zGIBpJPI5W(bool bool_1)
	{
		_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
		XmJBM7jBnS = true;
		IList<KEaK5nA5w4pj7wbFuOW> source = oEPB4oVbVm(nativeMenuPtr, bool_1);
		_003C_003Ec__DisplayClass11_.lt6vcDUmLHH = new string[1] { "Windows.ModernShare" };
		return source.Where(_003C_003Ec__DisplayClass11_.OwHvc5CQ8Ff).ToList();
	}

	private void ikHBBPZX4j()
	{
		XmJBM7jBnS = true;
		neoB5dlhi9(nativeMenuPtr);
	}

	[DllImport("user32.dll", EntryPoint = "GetMenuItemCount")]
	public static extern int MSvBQyXX7K(IntPtr intptr_0);

	[DllImport("user32.dll", EntryPoint = "GetMenuInfo")]
	public static extern bool J2CBj0kHxv(IntPtr intptr_0, ref MENUINFO menuinfo_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "GetMenuItemInfo")]
	public static extern bool XqjBnsgLYo(IntPtr intptr_0, int int_0, bool bool_1, ref MENUITEMINFO menuiteminfo_0);

	[HandleProcessCorruptedStateExceptions]
	private IList<KEaK5nA5w4pj7wbFuOW> oEPB4oVbVm(IntPtr intptr_0, bool bool_1)
	{
		_003C_003Ec__DisplayClass18_0 _003C_003Ec__DisplayClass18_ = new _003C_003Ec__DisplayClass18_0();
		_003C_003Ec__DisplayClass18_.dFlvcdEZdNC = this;
		if (intptr_0 == IntPtr.Zero)
		{
			return new List<KEaK5nA5w4pj7wbFuOW>();
		}
		int num = MSvBQyXX7K(intptr_0);
		List<KEaK5nA5w4pj7wbFuOW> list = new List<KEaK5nA5w4pj7wbFuOW>();
		_003C_003Ec__DisplayClass18_.qgNvcojEJLe = 0;
		while (_003C_003Ec__DisplayClass18_.qgNvcojEJLe < num)
		{
			_003C_003Ec__DisplayClass18_1 _003C_003Ec__DisplayClass18_2 = new _003C_003Ec__DisplayClass18_1();
			_003C_003Ec__DisplayClass18_2.pI4vcA5kBjx = _003C_003Ec__DisplayClass18_;
			uint num2 = I6BBDhVHZF(intptr_0, _003C_003Ec__DisplayClass18_2.pI4vcA5kBjx.qgNvcojEJLe, true) + 1;
			_003C_003Ec__DisplayClass18_2.bxlvcMeg0qk = default(MENUITEMINFO);
			_003C_003Ec__DisplayClass18_2.bxlvcMeg0qk.cbSize = (uint)Marshal.SizeOf(_003C_003Ec__DisplayClass18_2.bxlvcMeg0qk);
			_003C_003Ec__DisplayClass18_2.bxlvcMeg0qk.fMask = (MIIM)(0x46 | (bool_1 ? 128 : 0) | 1 | 0x100);
			_003C_003Ec__DisplayClass18_2.bxlvcMeg0qk.cch = num2;
			_003C_003Ec__DisplayClass18_2.bxlvcMeg0qk.dwTypeData = Marshal.AllocCoTaskMem((int)(num2 * 2));
			_003C_003Ec__DisplayClass18_2.bxlvcMeg0qk.hSubMenu = IntPtr.Zero;
			_003C_003Ec__DisplayClass18_2.bxlvcMeg0qk.hbmpItem = IntPtr.Zero;
			XqjBnsgLYo(intptr_0, _003C_003Ec__DisplayClass18_2.pI4vcA5kBjx.qgNvcojEJLe, true, ref _003C_003Ec__DisplayClass18_2.bxlvcMeg0qk);
			string text = Marshal.PtrToStringAuto(_003C_003Ec__DisplayClass18_2.bxlvcMeg0qk.dwTypeData);
			Marshal.FreeCoTaskMem(_003C_003Ec__DisplayClass18_2.bxlvcMeg0qk.dwTypeData);
			if (_003C_003Ec__DisplayClass18_2.bxlvcMeg0qk.wID < 30000)
			{
				int num3 = Convert.ToInt32(_003C_003Ec__DisplayClass18_2.bxlvcMeg0qk.wID);
				string value = string.Empty;
				if (!string.IsNullOrEmpty(text) && num3 > 0 && uint.TryParse(num3.ToString() ?? "", out var result))
				{
					value = GetCommandString(iContextMenu, result - 1, true);
				}
				if (_003C_003Ec__DisplayClass18_2.bxlvcMeg0qk.hSubMenu != IntPtr.Zero)
				{
					Marshal.AllocCoTaskMem(4).zZZBOTuNhV(_003C_003Ec__DisplayClass18_2.KbavcTcmXpB);
				}
				IntPtr hbmpItem = _003C_003Ec__DisplayClass18_2.bxlvcMeg0qk.hbmpItem;
				BitmapSource bitmapSource = null;
				if (bool_1 && hbmpItem != IntPtr.Zero)
				{
					try
					{
						bitmapSource = Imaging.CreateBitmapSourceFromHBitmap(hbmpItem, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
						if (bitmapSource.CanFreeze)
						{
							bitmapSource.Freeze();
						}
					}
					catch (Exception ex)
					{
						tYvBAuw3HU.Warn("生成菜单图标(" + text + ")异常：" + ex.Message, ex);
					}
					NativeMethods.DeleteObject(hbmpItem);
				}
				KEaK5nA5w4pj7wbFuOW kEaK5nA5w4pj7wbFuOW = new KEaK5nA5w4pj7wbFuOW();
				kEaK5nA5w4pj7wbFuOW.Command = value;
				kEaK5nA5w4pj7wbFuOW.Title = text;
				kEaK5nA5w4pj7wbFuOW.Id = num3;
				kEaK5nA5w4pj7wbFuOW.rhjQulJ71o(bitmapSource);
				kEaK5nA5w4pj7wbFuOW.Children = oEPB4oVbVm(_003C_003Ec__DisplayClass18_2.bxlvcMeg0qk.hSubMenu, bool_1);
				list.Add(kEaK5nA5w4pj7wbFuOW);
			}
			_003C_003Ec__DisplayClass18_.qgNvcojEJLe++;
		}
		return list;
	}

	private void neoB5dlhi9(IntPtr intptr_0)
	{
		_003C_003Ec__DisplayClass19_0 _003C_003Ec__DisplayClass19_ = new _003C_003Ec__DisplayClass19_0();
		_003C_003Ec__DisplayClass19_.aLxvcOBhUw0 = this;
		int num = MSvBQyXX7K(intptr_0);
		int num2 = 0;
		if (!NXZMaptKFAHW0GcZLYm())
		{
			goto IL_0163;
		}
		goto IL_0176;
		IL_0163:
		int num3 = default(int);
		num2 = num3;
		goto IL_0176;
		IL_0176:
		_003C_003Ec__DisplayClass19_1 _003C_003Ec__DisplayClass19_2 = default(_003C_003Ec__DisplayClass19_1);
		do
		{
			switch (num2)
			{
			case 1:
				if (_003C_003Ec__DisplayClass19_2.gk5vcl5vle6.wID < 30000)
				{
					Convert.ToInt64(_003C_003Ec__DisplayClass19_2.gk5vcl5vle6.wID);
					if (_003C_003Ec__DisplayClass19_2.gk5vcl5vle6.hSubMenu != IntPtr.Zero)
					{
						Marshal.AllocCoTaskMem(4).zZZBOTuNhV(_003C_003Ec__DisplayClass19_2.rAPvcURYaVg);
						neoB5dlhi9(_003C_003Ec__DisplayClass19_2.gk5vcl5vle6.hSubMenu);
					}
				}
				_003C_003Ec__DisplayClass19_.wAivcFeuoVw++;
				break;
			default:
				_003C_003Ec__DisplayClass19_.wAivcFeuoVw = 0;
				break;
			}
			if (_003C_003Ec__DisplayClass19_.wAivcFeuoVw < num)
			{
				_003C_003Ec__DisplayClass19_2 = new _003C_003Ec__DisplayClass19_1();
				_003C_003Ec__DisplayClass19_2.yrKvci4N4QV = _003C_003Ec__DisplayClass19_;
				_003C_003Ec__DisplayClass19_2.gk5vcl5vle6 = default(MENUITEMINFO);
				_003C_003Ec__DisplayClass19_2.gk5vcl5vle6.cbSize = (uint)Marshal.SizeOf(_003C_003Ec__DisplayClass19_2.gk5vcl5vle6);
				_003C_003Ec__DisplayClass19_2.gk5vcl5vle6.fMask = (MIIM)261u;
				_003C_003Ec__DisplayClass19_2.gk5vcl5vle6.cch = 0u;
				_003C_003Ec__DisplayClass19_2.gk5vcl5vle6.dwTypeData = IntPtr.Zero;
				_003C_003Ec__DisplayClass19_2.gk5vcl5vle6.hSubMenu = IntPtr.Zero;
				_003C_003Ec__DisplayClass19_2.gk5vcl5vle6.hbmpItem = IntPtr.Zero;
				XqjBnsgLYo(intptr_0, _003C_003Ec__DisplayClass19_2.yrKvci4N4QV.wAivcFeuoVw, true, ref _003C_003Ec__DisplayClass19_2.gk5vcl5vle6);
				num2 = 1;
				continue;
			}
			return;
		}
		while (m5NyJot15dFk8sLmxdK == null);
		goto IL_0163;
	}

	private uint I6BBDhVHZF(IntPtr intptr_0, int int_0, bool bool_1)
	{
		MENUITEMINFO menuiteminfo_ = default(MENUITEMINFO);
		menuiteminfo_.cbSize = Convert.ToUInt32(Marshal.SizeOf(menuiteminfo_));
		menuiteminfo_.fMask = MIIM.MIIM_TYPE;
		if (!XqjBnsgLYo(intptr_0, int_0, bool_1, ref menuiteminfo_))
		{
			throw new Win32Exception();
		}
		return menuiteminfo_.cch;
	}

	public int uvHBd815k1(uint uint_0, string string_0)
	{
		if (uint_0 >= 1 && uint_0 <= 30000)
		{
			if (!XmJBM7jBnS)
			{
				ikHBBPZX4j();
			}
			return InvokeCommand(iContextMenu, string_0, uint_0 - 1, Cursor.Position);
		}
		throw new ArgumentOutOfRangeException("selected", "错误的菜单序号");
	}

	static EqtTCe5xOs4YVatqr3K()
	{
		tYvBAuw3HU = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool NXZMaptKFAHW0GcZLYm()
	{
		return m5NyJot15dFk8sLmxdK == null;
	}

	internal static void pZS4QLta047s8VHkC76()
	{
	}
}
