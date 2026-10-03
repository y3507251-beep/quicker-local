using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace CW.Win32.Shell;

public sealed class ShellLink : ComObject<IShellLink>
{
	private string nuoECVSM2E;

	internal static ShellLink wFrgl1vWAsqfYxjrxo1;

	public string CurrentFile => nuoECVSM2E;

	public string TargetPath
	{
		get
		{
			StringBuilder stringBuilder = new StringBuilder(260, 260);
			ShellLinkFindData pfd = default(ShellLinkFindData);
			base.Interface.GetPath(stringBuilder, stringBuilder.Capacity, ref pfd, 2u);
			return stringBuilder.ToString();
		}
		set
		{
			base.Interface.SetPath(value);
		}
	}

	public string WorkingDirectory
	{
		get
		{
			StringBuilder stringBuilder = new StringBuilder(260, 260);
			base.Interface.GetWorkingDirectory(stringBuilder, stringBuilder.Capacity);
			return stringBuilder.ToString();
		}
		set
		{
			base.Interface.SetWorkingDirectory(value);
		}
	}

	public string Arguments
	{
		get
		{
			StringBuilder stringBuilder = new StringBuilder(260, 260);
			base.Interface.GetArguments(stringBuilder, stringBuilder.Capacity);
			return stringBuilder.ToString();
		}
		set
		{
			base.Interface.SetArguments(value);
		}
	}

	public string Description
	{
		get
		{
			StringBuilder stringBuilder = new StringBuilder(260, 260);
			base.Interface.GetDescription(stringBuilder, stringBuilder.Capacity);
			return stringBuilder.ToString();
		}
		set
		{
			base.Interface.SetDescription(value);
		}
	}

	public string IconFile
	{
		get
		{
			int int_ = 0;
			string string_ = "";
			ziVENSBSGj(out string_, out int_);
			return string_;
		}
		set
		{
			int int_ = 0;
			string string_ = "";
			ziVENSBSGj(out string_, out int_);
			heFEJfoZB9(value, int_);
		}
	}

	public int IconIndex
	{
		get
		{
			int int_ = 0;
			string string_ = "";
			ziVENSBSGj(out string_, out int_);
			return int_;
		}
		set
		{
			int int_ = 0;
			string string_ = "";
			ziVENSBSGj(out string_, out int_);
			heFEJfoZB9(string_, value);
		}
	}

	public ShellLinkDisplayMode DisplayMode
	{
		get
		{
			int piShowCmd = 0;
			base.Interface.GetShowCmd(out piShowCmd);
			return (ShellLinkDisplayMode)piShowCmd;
		}
		set
		{
			base.Interface.SetShowCmd((int)value);
		}
	}

	public int HotKey
	{
		get
		{
			ushort pwHotkey = 0;
			base.Interface.GetHotkey(out pwHotkey);
			return pwHotkey;
		}
		set
		{
			base.Interface.SetHotkey((ushort)value);
		}
	}

	public ShellLink()
		: base(XLVEugZDnQ())
	{
		nuoECVSM2E = "";
	}

	private static IShellLink XLVEugZDnQ()
	{
		return (IShellLink)new ShellLinkObject();
	}

	public ShellLink(string linkFile)
		: this()
	{
		Load(linkFile);
	}

	private void ziVENSBSGj(out string string_1, out int int_0)
	{
		StringBuilder stringBuilder = new StringBuilder(260, 260);
		base.Interface.GetIconLocation(stringBuilder, stringBuilder.Capacity, out int_0);
		string_1 = stringBuilder.ToString();
	}

	private void heFEJfoZB9(string string_1, int int_0)
	{
		base.Interface.SetIconLocation(string_1, int_0);
	}

	private IPersistFile UpNE0iGAYH()
	{
		return base.Interface as IPersistFile;
	}

	public void Save()
	{
		Save(nuoECVSM2E);
	}

	public void Save(string linkFile)
	{
		(UpNE0iGAYH() ?? throw new COMException("IPersistFile僀儞僞乕僼僃僀僗傪庢摼偱偒傑偣傫偱偟偨丅")).Save(linkFile, true);
		nuoECVSM2E = linkFile;
	}

	public void Load(string linkFile)
	{
		Load(linkFile, IntPtr.Zero, ShellLinkResolveFlags.AnyMatch | ShellLinkResolveFlags.NoUI, 1);
	}

	public void Load(string linkFile, IntPtr hWnd, ShellLinkResolveFlags resolveFlags)
	{
		Load(linkFile, hWnd, resolveFlags, 1);
	}

	public void Load(string linkFile, IntPtr hWnd, ShellLinkResolveFlags resolveFlags, TimeSpan timeOut)
	{
		Load(linkFile, hWnd, resolveFlags, (int)timeOut.TotalMilliseconds);
	}

	public void Load(string linkFile, IntPtr hWnd, ShellLinkResolveFlags resolveFlags, int timeOutMilliseconds)
	{
		if (!File.Exists(linkFile))
		{
			throw new FileNotFoundException("僼傽僀儖偑尒偮偐傝傑偣傫丅", linkFile);
		}
		(UpNE0iGAYH() ?? throw new COMException("IPersistFile僀儞僞乕僼僃僀僗傪庢摼偱偒傑偣傫偱偟偨丅")).Load(linkFile, 0);
		uint num = (uint)resolveFlags;
		if ((resolveFlags & ShellLinkResolveFlags.NoUI) == ShellLinkResolveFlags.NoUI)
		{
			num |= (uint)(timeOutMilliseconds << 16);
		}
		base.Interface.Resolve(hWnd, num);
		nuoECVSM2E = linkFile;
	}

	internal static bool suypnBvy4GbBD7Hm9KF()
	{
		return wFrgl1vWAsqfYxjrxo1 == null;
	}
}
