using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace CW.Win32.Shell;

public static class FileOperations
{
	internal struct cH3EJod7aAFnU9RSIus
	{
		public IntPtr rHlvyFrR64H;

		public FileOperationFunc HyJvyUSDRy4;

		[MarshalAs(UnmanagedType.LPTStr)]
		public string From;

		[MarshalAs(UnmanagedType.LPTStr)]
		public string To;

		public FileOperationOptions s9nvylUMy0w;

		public bool cbQvyieM1ZP;

		public IntPtr zAcvy3yS5sT;

		[MarshalAs(UnmanagedType.LPTStr)]
		public string rIbvyfHVYHY;
	}

	private struct kADPipdi40Beaf66fB2
	{
		[CompilerGenerated]
		private IntPtr Wqdv8yKZppm;

		[CompilerGenerated]
		private FileOperationFunc fwgv8886VXh;

		[CompilerGenerated]
		private FileOperationOptions QhCv8aGmnEq;

		[CompilerGenerated]
		private string[] ry3v87vDV4j;

		[CompilerGenerated]
		private string[] dqxv8RA8NuA;

		[CompilerGenerated]
		private string z7bv8qxOjk6;

		private static object f9tEIrcGDvFW2TWaWryy;

		public IntPtr Handle
		{
			[CompilerGenerated]
			readonly get
			{
				return Wqdv8yKZppm;
			}
			[CompilerGenerated]
			set
			{
				Wqdv8yKZppm = value;
			}
		}

		public string[] From
		{
			[CompilerGenerated]
			readonly get
			{
				return ry3v87vDV4j;
			}
			[CompilerGenerated]
			set
			{
				ry3v87vDV4j = value;
			}
		}

		public string[] To
		{
			[CompilerGenerated]
			readonly get
			{
				return dqxv8RA8NuA;
			}
			[CompilerGenerated]
			set
			{
				dqxv8RA8NuA = value;
			}
		}

		[SpecialName]
		[CompilerGenerated]
		public readonly FileOperationFunc B7Jv8t161BM()
		{
			return fwgv8886VXh;
		}

		[SpecialName]
		[CompilerGenerated]
		public void l3Vv8gNxeBX(FileOperationFunc fileOperationFunc_1)
		{
			fwgv8886VXh = fileOperationFunc_1;
		}

		[SpecialName]
		[CompilerGenerated]
		public readonly FileOperationOptions YX0v8vv2JRl()
		{
			return QhCv8aGmnEq;
		}

		[SpecialName]
		[CompilerGenerated]
		public void WZbv8SVMEwE(FileOperationOptions fileOperationOptions_1)
		{
			QhCv8aGmnEq = fileOperationOptions_1;
		}

		[SpecialName]
		[CompilerGenerated]
		public readonly string TRCv8CUNagu()
		{
			return z7bv8qxOjk6;
		}

		[SpecialName]
		[CompilerGenerated]
		public void rfKv8PADv2D(string string_3)
		{
			z7bv8qxOjk6 = string_3;
		}

		internal static bool tbDIwfcG3NoLIXNUmoL2()
		{
			return f9tEIrcGDvFW2TWaWryy == null;
		}
	}

	private static object h519OIK9n5J3ryHmnYD;

	[DllImport("Shell32.dll", CharSet = CharSet.Auto, EntryPoint = "SHFileOperation")]
	private static extern int KeCPDkkxAq(ref cH3EJod7aAFnU9RSIus cH3EJod7aAFnU9RSIus_0);

	private static void GysPdDgBCG(kADPipdi40Beaf66fB2 kADPipdi40Beaf66fB2_0)
	{
		cH3EJod7aAFnU9RSIus cH3EJod7aAFnU9RSIus_ = new cH3EJod7aAFnU9RSIus
		{
			rHlvyFrR64H = kADPipdi40Beaf66fB2_0.Handle,
			HyJvyUSDRy4 = kADPipdi40Beaf66fB2_0.B7Jv8t161BM(),
			From = string.Join("\0", kADPipdi40Beaf66fB2_0.From) + "\0",
			To = string.Join("\0", kADPipdi40Beaf66fB2_0.To) + "\0",
			s9nvylUMy0w = kADPipdi40Beaf66fB2_0.YX0v8vv2JRl(),
			cbQvyieM1ZP = false
		};
		int num = 0;
		if (!M1mGRmKLH9KnDwh2vSJ())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		cH3EJod7aAFnU9RSIus_.zAcvy3yS5sT = IntPtr.Zero;
		cH3EJod7aAFnU9RSIus_.rIbvyfHVYHY = kADPipdi40Beaf66fB2_0.TRCv8CUNagu();
		int num3 = KeCPDkkxAq(ref cH3EJod7aAFnU9RSIus_);
		if (num3 == 0)
		{
			if (cH3EJod7aAFnU9RSIus_.cbQvyieM1ZP)
			{
				throw new OperationCanceledException();
			}
			return;
		}
		throw new Win32Exception(num3);
	}

	public static void Delete(string[] files)
	{
		Delete(files, FileOperationOptions.None, IntPtr.Zero, null);
	}

	public static void Delete(string[] files, FileOperationOptions options)
	{
		Delete(files, options, IntPtr.Zero, null);
	}

	public static void Delete(string[] files, FileOperationOptions options, IntPtr hwnd)
	{
		Delete(files, options, hwnd, null);
	}

	public static void Delete(string[] files, FileOperationOptions options, IntPtr hwnd, string progressTitle)
	{
		int num = 1;
		while (files == null)
		{
			int num2 = 0;
			if (h519OIK9n5J3ryHmnYD != null)
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			throw new ArgumentNullException();
		}
		if (files.Length == 0)
		{
			throw new ArgumentException();
		}
		kADPipdi40Beaf66fB2 kADPipdi40Beaf66fB2_ = default(kADPipdi40Beaf66fB2);
		kADPipdi40Beaf66fB2_.Handle = hwnd;
		kADPipdi40Beaf66fB2_.l3Vv8gNxeBX(FileOperationFunc.Delete);
		kADPipdi40Beaf66fB2_.WZbv8SVMEwE(options);
		kADPipdi40Beaf66fB2_.From = files;
		kADPipdi40Beaf66fB2_.To = null;
		kADPipdi40Beaf66fB2_.rfKv8PADv2D(progressTitle);
		GysPdDgBCG(kADPipdi40Beaf66fB2_);
	}

	public static void Move(string to, params string[] files)
	{
		Move(files, to, FileOperationOptions.None, IntPtr.Zero, null);
	}

	public static void Move(string[] files, string to, FileOperationOptions options)
	{
		Move(files, to, options, IntPtr.Zero, null);
	}

	public static void Move(string[] files, string to, FileOperationOptions options, IntPtr hwnd)
	{
		Move(files, to, options, hwnd, null);
	}

	public static void Move(string[] files, string to, FileOperationOptions options, IntPtr hwnd, string progressTitle)
	{
		if (files == null)
		{
			throw new ArgumentNullException();
		}
		if (files.Length == 0)
		{
			throw new ArgumentException();
		}
		kADPipdi40Beaf66fB2 kADPipdi40Beaf66fB2_ = default(kADPipdi40Beaf66fB2);
		kADPipdi40Beaf66fB2_.Handle = hwnd;
		kADPipdi40Beaf66fB2_.l3Vv8gNxeBX(FileOperationFunc.Move);
		if (h519OIK9n5J3ryHmnYD == null)
		{
			switch (0)
			{
			}
		}
		kADPipdi40Beaf66fB2_.WZbv8SVMEwE(options);
		kADPipdi40Beaf66fB2_.From = files;
		kADPipdi40Beaf66fB2_.To = new string[1] { to };
		kADPipdi40Beaf66fB2_.rfKv8PADv2D(progressTitle);
		GysPdDgBCG(kADPipdi40Beaf66fB2_);
	}

	public static void Copy(string to, params string[] files)
	{
		Copy(files, to, FileOperationOptions.None, IntPtr.Zero, null);
	}

	public static void Copy(string[] files, string to, FileOperationOptions options)
	{
		Copy(files, to, options, IntPtr.Zero, null);
	}

	public static void Copy(string[] files, string to, FileOperationOptions options, IntPtr hwnd)
	{
		Copy(files, to, options, hwnd, null);
	}

	public static void Copy(string[] files, string to, FileOperationOptions options, IntPtr hwnd, string progressTitle)
	{
		if (files == null)
		{
			throw new ArgumentNullException();
		}
		if (files.Length == 0)
		{
			throw new ArgumentException();
		}
		kADPipdi40Beaf66fB2 kADPipdi40Beaf66fB2_ = default(kADPipdi40Beaf66fB2);
		kADPipdi40Beaf66fB2_.Handle = hwnd;
		kADPipdi40Beaf66fB2_.l3Vv8gNxeBX(FileOperationFunc.Copy);
		kADPipdi40Beaf66fB2_.WZbv8SVMEwE(options);
		kADPipdi40Beaf66fB2_.From = files;
		kADPipdi40Beaf66fB2_.To = new string[1] { to };
		kADPipdi40Beaf66fB2_.rfKv8PADv2D(progressTitle);
		GysPdDgBCG(kADPipdi40Beaf66fB2_);
		if (h519OIK9n5J3ryHmnYD == null)
		{
			switch (0)
			{
			}
		}
	}

	public static void Rename(string from, string to)
	{
		Rename(from, to, FileOperationOptions.None, IntPtr.Zero, null);
	}

	public static void Rename(string from, string to, FileOperationOptions options)
	{
		Rename(from, to, options, IntPtr.Zero, null);
	}

	public static void Rename(string from, string to, FileOperationOptions options, IntPtr hwnd)
	{
		Rename(from, to, options, hwnd, null);
	}

	public static void Rename(string from, string to, FileOperationOptions options, IntPtr hwnd, string progressTitle)
	{
		if (from != null && to != null)
		{
			kADPipdi40Beaf66fB2 kADPipdi40Beaf66fB2_ = default(kADPipdi40Beaf66fB2);
			kADPipdi40Beaf66fB2_.Handle = hwnd;
			kADPipdi40Beaf66fB2_.l3Vv8gNxeBX(FileOperationFunc.Rename);
			kADPipdi40Beaf66fB2_.WZbv8SVMEwE(options);
			kADPipdi40Beaf66fB2_.From = new string[1] { from };
			if (h519OIK9n5J3ryHmnYD != null)
			{
				switch (0)
				{
				}
			}
			kADPipdi40Beaf66fB2_.To = new string[1] { to };
			kADPipdi40Beaf66fB2_.rfKv8PADv2D(progressTitle);
			GysPdDgBCG(kADPipdi40Beaf66fB2_);
			return;
		}
		throw new ArgumentNullException();
	}

	public static void CreateSymbolicLink(string linkToCreate, string target, SymbolicLinkKind kind)
	{
		if (!Kernel32.CreateSymbolicLink(linkToCreate, target, kind))
		{
			throw new Win32Exception();
		}
	}

	public static string GetShortPathName(string path)
	{
		int num = path.Length;
		StringBuilder stringBuilder;
		while (true)
		{
			if (num < 32767)
			{
				stringBuilder = new StringBuilder(num);
				if (Kernel32.GetShortPathName(path, stringBuilder, num) != 0)
				{
					break;
				}
				num *= 2;
				continue;
			}
			return null;
		}
		return stringBuilder.ToString();
	}

	public static string GetLongPathName(string path)
	{
		int num = path.Length + 256;
		StringBuilder stringBuilder;
		while (true)
		{
			if (num < 32767)
			{
				stringBuilder = new StringBuilder(num);
				if (Kernel32.GetLongPathName(path, stringBuilder, num) != 0)
				{
					break;
				}
				num *= 2;
				continue;
			}
			return null;
		}
		return stringBuilder.ToString();
	}

	public static bool Execute(string verb, string file)
	{
		return Execute(verb, file, null, null, ShowWindowCommand.ShowNormal, IntPtr.Zero);
	}

	public static bool Execute(string verb, string file, string parameter)
	{
		return Execute(verb, file, parameter, null, ShowWindowCommand.ShowNormal, IntPtr.Zero);
	}

	public static bool Execute(string verb, string file, string parameter, string directory)
	{
		return Execute(verb, file, parameter, directory, ShowWindowCommand.ShowNormal, IntPtr.Zero);
	}

	public static bool Execute(string verb, string file, string parameter, string directory, ShowWindowCommand nShow)
	{
		return Execute(verb, file, parameter, directory, nShow, IntPtr.Zero);
	}

	public static bool Execute(string verb, string file, string parameter, string directory, ShowWindowCommand nShow, IntPtr hwnd)
	{
		ShellExecuteInfo shinfo = new ShellExecuteInfo
		{
			Handle = hwnd,
			Verb = verb,
			File = file,
			Parameters = parameter,
			Directory = directory,
			Show = nShow
		};
		return Shell32.ShellExecuteEx(ref shinfo);
	}

	public static OLEError EmptyRecycleBin()
	{
		return EmptyRecycleBin(null, IntPtr.Zero, SHEmptyRecycleBinOptions.None);
	}

	public static OLEError EmptyRecycleBin(string drive)
	{
		return EmptyRecycleBin(drive, IntPtr.Zero, SHEmptyRecycleBinOptions.None);
	}

	public static OLEError EmptyRecycleBin(string drive, IntPtr hwnd)
	{
		return EmptyRecycleBin(drive, hwnd, SHEmptyRecycleBinOptions.None);
	}

	public static OLEError EmptyRecycleBin(string drive, IntPtr hwnd, SHEmptyRecycleBinOptions options)
	{
		return Shell32.SHEmptyRecycleBin(hwnd, drive, options);
	}

	internal static ContextMenu mDUPoS5mcC(IntPtr intptr_0, string[] string_0)
	{
		ulong pchEaten = 0uL;
		ulong pdwAttributes = 0uL;
		string directoryName = Path.GetDirectoryName(string_0[0]);
		using ShellFolder shellFolder = ShellFolder.GetFolder(intptr_0, directoryName);
		IntPtr[] array = new IntPtr[string_0.Length];
		try
		{
			int num = 0;
			int num2 = 0;
			if (h519OIK9n5J3ryHmnYD != null)
			{
				int num3 = default(int);
				num2 = num3;
			}
			switch (num2)
			{
			default:
				foreach (string text in string_0)
				{
					string text2 = Path.GetFileName(text);
					if (string.IsNullOrEmpty(text2))
					{
						text2 = text;
					}
					shellFolder.Interface.ParseDisplayName(IntPtr.Zero, IntPtr.Zero, text2, ref pchEaten, out array[num], ref pdwAttributes);
					num++;
				}
				return shellFolder.GetUIObjectOf(array, intptr_0);
			}
		}
		finally
		{
			IntPtr[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				Marshal.FreeCoTaskMem(array2[i]);
			}
		}
	}

	public static bool ShowContextMenu(IntPtr handle, Point pos, params string[] files)
	{
		files.ThrowIfNull("files");
		using Win32MenuItem win32MenuItem = Win32MenuItem.CreatePopupMenu();
		using ContextMenu contextMenu = mDUPoS5mcC(handle, files);
		contextMenu.Interface.QueryContextMenu(win32MenuItem.Handle, 0u, 1u, 32767u, 0u);
		int num = win32MenuItem.Show(handle, pos, TrackPopupMenuOptions.ReturnCommand);
		if (num == 0)
		{
			int num2 = 0;
			if (h519OIK9n5J3ryHmnYD != null)
			{
				int num3 = default(int);
				num2 = num3;
			}
			return num2 switch
			{
				_ => false, 
			};
		}
		num--;
		contextMenu.InvokeCommand(num, handle, ShowWindowCommand.ShowNormal);
		return true;
	}

	public static void InvokeCommand(int cmdId, IntPtr hwnd, ShowWindowCommand nShow, params string[] files)
	{
		files.ThrowIfNull("files");
		using ContextMenu contextMenu = mDUPoS5mcC(hwnd, files);
		using Win32MenuItem win32MenuItem = Win32MenuItem.CreatePopupMenu();
		contextMenu.Interface.QueryContextMenu(win32MenuItem.Handle, 0u, 1u, 32767u, 0u);
		contextMenu.InvokeCommand(cmdId, hwnd, nShow);
	}

	public static void ShowProperty(IntPtr hwnd, params string[] files)
	{
		files.ThrowIfNull("files");
		InvokeCommand(19, hwnd, ShowWindowCommand.ShowNormal, files);
	}

	public static bool ExecuteDefaultAction(IntPtr hwnd, params string[] files)
	{
		files.ThrowIfNull("files");
		if (files.Length != 0)
		{
			using (Win32MenuItem win32MenuItem = Win32MenuItem.CreatePopupMenu())
			{
				using ContextMenu contextMenu = mDUPoS5mcC(hwnd, files);
				contextMenu.Interface.QueryContextMenu(win32MenuItem.Handle, 0u, 1u, 32767u, 0u);
				int defaultItem = win32MenuItem.GetDefaultItem(MenuFoundBy.Command, GetMenuDefaultItemOptions.Normal);
				if (defaultItem != -1)
				{
					defaultItem--;
					contextMenu.InvokeCommand(defaultItem, IntPtr.Zero, ShowWindowCommand.ShowNormal);
					return true;
				}
				return false;
			}
		}
		return false;
	}

	internal static bool M1mGRmKLH9KnDwh2vSJ()
	{
		return h519OIK9n5J3ryHmnYD == null;
	}
}
