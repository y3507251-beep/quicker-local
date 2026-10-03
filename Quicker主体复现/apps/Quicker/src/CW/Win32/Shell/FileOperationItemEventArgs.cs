using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CW.Win32.Shell;

public class FileOperationItemEventArgs : CancelEventArgs
{
	[CompilerGenerated]
	private TransferSourceFlags R3iPjZlXsG;

	[CompilerGenerated]
	private IShellItem hf8PndNCHb;

	[CompilerGenerated]
	private string seAP49C6rd;

	[CompilerGenerated]
	private IShellItem hsgP5IObPc;

	private static FileOperationItemEventArgs tfik44KKhH8o8X4JAUU;

	public TransferSourceFlags TransferSourceFlags
	{
		[CompilerGenerated]
		get
		{
			return R3iPjZlXsG;
		}
		[CompilerGenerated]
		private set
		{
			R3iPjZlXsG = value;
		}
	}

	public IShellItem Item
	{
		[CompilerGenerated]
		get
		{
			return hf8PndNCHb;
		}
		[CompilerGenerated]
		private set
		{
			hf8PndNCHb = value;
		}
	}

	public string NewName
	{
		[CompilerGenerated]
		get
		{
			return seAP49C6rd;
		}
		[CompilerGenerated]
		private set
		{
			seAP49C6rd = value;
		}
	}

	public IShellItem DestinationFolder
	{
		[CompilerGenerated]
		get
		{
			return hsgP5IObPc;
		}
		[CompilerGenerated]
		private set
		{
			hsgP5IObPc = value;
		}
	}

	public FileOperationItemEventArgs(TransferSourceFlags flags, IShellItem item, string newName, IShellItem destinationFolder)
	{
		TransferSourceFlags = flags;
		Item = item;
		NewName = newName;
		DestinationFolder = destinationFolder;
	}

	static FileOperationItemEventArgs()
	{
	}

	internal static bool RVfkApKBHd6A0986gEr()
	{
		return tfik44KKhH8o8X4JAUU == null;
	}

	internal static void IoQncCKdi4LhZEeDM2o()
	{
	}
}
