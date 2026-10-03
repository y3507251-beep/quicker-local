using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace CW.Win32.Shell;

[Obsolete]
public static class ShellIcon
{
	private static object Jt1cE9BlMjMIvdZuWGv;

	public static Icon GetIcon(string path, IconSize size)
	{
		GetIcon(path, size, out var hIcon);
		if (hIcon != IntPtr.Zero)
		{
			using (Icon icon = Icon.FromHandle(hIcon))
			{
				Icon result = (Icon)icon.Clone();
				User32.DestroyIcon(icon.Handle);
				return result;
			}
		}
		return null;
	}

	public static Image GetIconImage(string path, IconSize size)
	{
		GetIcon(path, size, out var hIcon);
		if (hIcon != IntPtr.Zero)
		{
			Icon icon = Icon.FromHandle(hIcon);
			if (icon != null)
			{
				using (icon)
				{
					Image result = icon.ToBitmap();
					User32.DestroyIcon(icon.Handle);
					return result;
				}
			}
			return null;
		}
		return null;
	}

	public static Bitmap GetIconBitmap(string path, IconSize size)
	{
		GetIcon(path, size, out var hIcon);
		if (hIcon != IntPtr.Zero)
		{
			Icon icon = Icon.FromHandle(hIcon);
			if (icon != null)
			{
				using (icon)
				{
					Bitmap result = icon.ToBitmap();
					User32.DestroyIcon(icon.Handle);
					return result;
				}
			}
			return null;
		}
		return null;
	}

	public static void GetIcon(string path, IconSize size, out IntPtr hIcon)
	{
		string extension = Path.GetExtension(path);
		hIcon = IntPtr.Zero;
		if (string.IsNullOrEmpty(extension))
		{
			if ((path.Length != 2 || !char.IsLetter(path, 0) || path[1] != ':') && (path.Length != 3 || !char.IsLetter(path, 0) || path[1] != ':' || path[2] != Path.DirectorySeparatorChar))
			{
				goto IL_02ae;
			}
			goto IL_02d2;
		}
		RegistryKey classesRoot = Registry.ClassesRoot;
		try
		{
			string text = yoAP3PqKvK(classesRoot, extension);
			string text2 = null;
			if (text != null)
			{
				RegistryKey registryKey = classesRoot.OpenSubKey(text, false);
				if (registryKey != null)
				{
					try
					{
						RegistryKey registryKey2 = registryKey.OpenSubKey("DefaultIcon", false);
						if (registryKey2 != null)
						{
							try
							{
								object value = registryKey2.GetValue("");
								if (value != null)
								{
									HZ5PfV6Pih(value.ToString(), path, out var intptr_, out var intptr_2);
									if (size == IconSize.Large)
									{
										hIcon = intptr_;
										User32.DestroyIcon(intptr_2);
									}
									else
									{
										hIcon = intptr_2;
										if (!CUMxK1BZ8n6A38aZ79O())
										{
											switch (0)
											{
											}
										}
										User32.DestroyIcon(intptr_);
									}
								}
							}
							finally
							{
								registryKey2.Close();
							}
						}
						if (hIcon == IntPtr.Zero)
						{
							if (text.Equals("exefile", StringComparison.OrdinalIgnoreCase))
							{
								jJfEwxLOTO(out var intptr_3, out var intptr_4);
								if (size == IconSize.Large)
								{
									hIcon = intptr_3;
									User32.DestroyIcon(intptr_4);
								}
								else
								{
									hIcon = intptr_4;
									if (Jt1cE9BlMjMIvdZuWGv != null)
									{
										switch (0)
										{
										}
									}
									User32.DestroyIcon(intptr_3);
								}
							}
							else
							{
								RegistryKey registryKey3 = registryKey.OpenSubKey("CLSID");
								if (registryKey3 != null)
								{
									try
									{
										object value = registryKey3.GetValue("");
										if (value != null)
										{
											text2 = value.ToString();
										}
									}
									finally
									{
										registryKey3.Close();
									}
								}
							}
						}
					}
					finally
					{
						registryKey.Close();
					}
				}
			}
			if (text2 != null)
			{
				RegistryKey registryKey4 = classesRoot.OpenSubKey("CLSID");
				int num = 0;
				if (!CUMxK1BZ8n6A38aZ79O())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				default:
					if (registryKey4 == null)
					{
						break;
					}
					try
					{
						RegistryKey registryKey5 = registryKey4.OpenSubKey(text2);
						if (registryKey5 == null)
						{
							break;
						}
						try
						{
							RegistryKey registryKey6 = registryKey5.OpenSubKey("DefaultIcon");
							if (registryKey6 == null)
							{
								break;
							}
							try
							{
								object value = registryKey6.GetValue("");
								if (value != null)
								{
									HZ5PfV6Pih(value.ToString(), path, out var intptr_5, out var intptr_6);
									if (size == IconSize.Large)
									{
										hIcon = intptr_5;
										User32.DestroyIcon(intptr_6);
									}
									else
									{
										hIcon = intptr_6;
										User32.DestroyIcon(intptr_5);
									}
								}
							}
							finally
							{
								registryKey6.Close();
							}
						}
						finally
						{
							registryKey5.Close();
						}
					}
					finally
					{
						registryKey4.Close();
					}
					break;
				}
			}
		}
		finally
		{
			classesRoot.Close();
		}
		goto IL_02db;
		IL_02d2:
		Q12Et63yxs(path, size, out hIcon);
		goto IL_02db;
		IL_02ae:
		mgaPznMQIx(out var intptr_7, out var intptr_8);
		if (size == IconSize.Large)
		{
			hIcon = intptr_7;
			User32.DestroyIcon(intptr_8);
		}
		else
		{
			hIcon = intptr_8;
			User32.DestroyIcon(intptr_7);
		}
		goto IL_02db;
		IL_02db:
		if (hIcon == IntPtr.Zero)
		{
			mgaPznMQIx(out var intptr_9, out var intptr_10);
			if (size == IconSize.Large)
			{
				hIcon = intptr_9;
				int num3 = 1;
				if (Jt1cE9BlMjMIvdZuWGv != null)
				{
					int num4 = default(int);
					num3 = num4;
				}
				switch (num3)
				{
				case 2:
					goto IL_02d2;
				case 1:
					User32.DestroyIcon(intptr_10);
					return;
				}
				goto IL_02ae;
			}
			hIcon = intptr_10;
			User32.DestroyIcon(intptr_9);
		}
	}

	private static string yoAP3PqKvK(RegistryKey registryKey_0, string string_0)
	{
		RegistryKey registryKey = registryKey_0.OpenSubKey(string_0, false);
		if (registryKey != null)
		{
			try
			{
				object value = registryKey.GetValue("");
				if (value != null)
				{
					return value.ToString();
				}
			}
			finally
			{
				registryKey.Close();
			}
		}
		return null;
	}

	private static void HZ5PfV6Pih(string string_0, string string_1, out IntPtr intptr_0, out IntPtr intptr_1)
	{
		int num = string_0.LastIndexOf(',');
		int result = 0;
		string text;
		if (num == -1)
		{
			text = string_0;
		}
		else if (int.TryParse(string_0.Substring(num + 1), out result))
		{
			text = string_0.Substring(0, num);
			int num2 = 0;
			if (!CUMxK1BZ8n6A38aZ79O())
			{
				int num3 = default(int);
				num2 = num3;
			}
			switch (num2)
			{
			}
		}
		else
		{
			text = string_0;
			result = 0;
		}
		text = Environment.ExpandEnvironmentVariables(text.Replace("%1", string_1));
		Shell32.ExtractIconEx(text, result, out intptr_0, out intptr_1, 1);
	}

	public static void GetUnknownIconImage(out Image largeIcon, out Image smallIcon)
	{
		int num = 1;
		while (true)
		{
			mgaPznMQIx(out var intptr_, out var intptr_2);
			int num2 = 0;
			if (Jt1cE9BlMjMIvdZuWGv != null)
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			if (intptr_ != IntPtr.Zero)
			{
				using Icon icon = Icon.FromHandle(intptr_);
				largeIcon = icon.ToBitmap();
				User32.DestroyIcon(intptr_);
			}
			else
			{
				largeIcon = null;
			}
			if (intptr_2 != IntPtr.Zero)
			{
				using (Icon icon2 = Icon.FromHandle(intptr_2))
				{
					smallIcon = icon2.ToBitmap();
					User32.DestroyIcon(intptr_2);
					return;
				}
			}
			smallIcon = null;
			return;
		}
	}

	public static Icon GetUnknownIconImage(IconSize size)
	{
		mgaPznMQIx(out var intptr_, out var intptr_2);
		if (size == IconSize.Small)
		{
			User32.DestroyIcon(intptr_);
			return Icon.FromHandle(intptr_2);
		}
		User32.DestroyIcon(intptr_2);
		return Icon.FromHandle(intptr_);
	}

	private static void mgaPznMQIx(out IntPtr intptr_0, out IntPtr intptr_1)
	{
		if (Environment.OSVersion.Version.Major < 6)
		{
			Shell32.ExtractIconEx("Shell32.dll", 0, out intptr_0, out intptr_1, 1);
		}
		else if (Environment.OSVersion.Version.Minor >= 1)
		{
			Shell32.ExtractIconEx("imageres.dll", 2, out intptr_0, out intptr_1, 1);
		}
		else
		{
			Shell32.ExtractIconEx("imageres.dll", 1, out intptr_0, out intptr_1, 1);
		}
	}

	public static void GetExecutableIconImage(out Image largeIcon, out Image smallIcon)
	{
		jJfEwxLOTO(out var intptr_, out var intptr_2);
		if (intptr_ != IntPtr.Zero)
		{
			using Icon icon = Icon.FromHandle(intptr_);
			largeIcon = icon.ToBitmap();
			User32.DestroyIcon(intptr_);
		}
		else
		{
			largeIcon = null;
		}
		if (intptr_2 != IntPtr.Zero)
		{
			Icon icon2 = Icon.FromHandle(intptr_2);
			if (Jt1cE9BlMjMIvdZuWGv != null)
			{
				switch (0)
				{
				}
			}
			try
			{
				smallIcon = icon2.ToBitmap();
				User32.DestroyIcon(intptr_2);
				return;
			}
			finally
			{
				((IDisposable)icon2)?.Dispose();
			}
		}
		smallIcon = null;
	}

	private static void jJfEwxLOTO(out IntPtr intptr_0, out IntPtr intptr_1)
	{
		if (Environment.OSVersion.Version.Major >= 6)
		{
			if (Environment.OSVersion.Version.Minor >= 1)
			{
				Shell32.ExtractIconEx("imageres.dll", 11, out intptr_0, out intptr_1, 1);
			}
			else
			{
				Shell32.ExtractIconEx("imageres.dll", 10, out intptr_0, out intptr_1, 1);
			}
		}
		else
		{
			Shell32.ExtractIconEx("Shell32.dll", 2, out intptr_0, out intptr_1, 1);
		}
	}

	private static IntPtr Q12Et63yxs(string string_0, IconSize iconSize_0, out IntPtr intptr_0)
	{
		SHFileInfo psfi = default(SHFileInfo);
		SHGetFileInfoOptions sHGetFileInfoOptions = SHGetFileInfoOptions.Icon;
		sHGetFileInfoOptions = ((iconSize_0 != IconSize.Small) ? (sHGetFileInfoOptions | SHGetFileInfoOptions.LargeIcon) : (sHGetFileInfoOptions | SHGetFileInfoOptions.SmallIcon));
		IntPtr result = Shell32.SHGetFileInfo(string_0, FileAttributes.Normal, ref psfi, Marshal.SizeOf(psfi), sHGetFileInfoOptions);
		intptr_0 = psfi.hIcon;
		return result;
	}

	public static Icon[] ExtractIcon(string path, int index)
	{
		Icon[] array = new Icon[2];
		Shell32.ExtractIconEx(path, index, out var largeIconHandle, out var smallIconHandle, 1);
		if (largeIconHandle != IntPtr.Zero)
		{
			Icon icon = Icon.FromHandle(largeIconHandle);
			Icon icon2 = icon;
			int num = 0;
			if (!CUMxK1BZ8n6A38aZ79O())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			try
			{
				array[0] = (Icon)icon.Clone();
				User32.DestroyIcon(largeIconHandle);
			}
			finally
			{
				((IDisposable)icon2)?.Dispose();
			}
		}
		if (largeIconHandle != IntPtr.Zero)
		{
			Icon icon3 = Icon.FromHandle(smallIconHandle);
			using (icon3)
			{
				array[1] = (Icon)icon3.Clone();
				User32.DestroyIcon(smallIconHandle);
			}
		}
		return array;
	}

	public static Image[] ExtractIconImage(string path, int index)
	{
		Image[] array = new Image[2];
		Shell32.ExtractIconEx(path, index, out var largeIconHandle, out var smallIconHandle, 1);
		if (largeIconHandle != IntPtr.Zero)
		{
			using Icon icon = Icon.FromHandle(largeIconHandle);
			array[0] = icon.ToBitmap();
			User32.DestroyIcon(largeIconHandle);
		}
		if (largeIconHandle != IntPtr.Zero)
		{
			using Icon icon2 = Icon.FromHandle(smallIconHandle);
			array[1] = icon2.ToBitmap();
			User32.DestroyIcon(smallIconHandle);
		}
		return array;
	}

	public static void ExtractIconImage(string path, int index, out Image largeIconImage, out Image smallIconImage)
	{
		largeIconImage = null;
		smallIconImage = null;
		Shell32.ExtractIconEx(path, index, out var largeIconHandle, out var smallIconHandle, 1);
		if (largeIconHandle != IntPtr.Zero)
		{
			using Icon icon = Icon.FromHandle(largeIconHandle);
			largeIconImage = icon.ToBitmap();
			User32.DestroyIcon(largeIconHandle);
		}
		if (largeIconHandle != IntPtr.Zero)
		{
			using (Icon icon2 = Icon.FromHandle(smallIconHandle))
			{
				smallIconImage = icon2.ToBitmap();
				User32.DestroyIcon(smallIconHandle);
			}
		}
	}

	internal static bool CUMxK1BZ8n6A38aZ79O()
	{
		return Jt1cE9BlMjMIvdZuWGv == null;
	}
}
