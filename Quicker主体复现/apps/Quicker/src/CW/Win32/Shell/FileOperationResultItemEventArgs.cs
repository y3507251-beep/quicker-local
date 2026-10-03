using System.Runtime.CompilerServices;

namespace CW.Win32.Shell;

public class FileOperationResultItemEventArgs : FileOperationResultEventArgs
{
	[CompilerGenerated]
	private TransferSourceFlags I2KP6dUKXa;

	[CompilerGenerated]
	private IShellItem R1HPXSY97a;

	[CompilerGenerated]
	private string vUHPm2JHl4;

	[CompilerGenerated]
	private IShellItem DIpPKRFB2M;

	[CompilerGenerated]
	private IShellItem goOPxvmCQx;

	internal static FileOperationResultItemEventArgs EjSTehKGi7twXR5xEYP;

	public TransferSourceFlags TransferSourceFlags
	{
		[CompilerGenerated]
		get
		{
			return I2KP6dUKXa;
		}
		[CompilerGenerated]
		private set
		{
			I2KP6dUKXa = value;
		}
	}

	public IShellItem Item
	{
		[CompilerGenerated]
		get
		{
			return R1HPXSY97a;
		}
		[CompilerGenerated]
		private set
		{
			R1HPXSY97a = value;
		}
	}

	public string NewName
	{
		[CompilerGenerated]
		get
		{
			return vUHPm2JHl4;
		}
		[CompilerGenerated]
		private set
		{
			vUHPm2JHl4 = value;
		}
	}

	public IShellItem NewItem
	{
		[CompilerGenerated]
		get
		{
			return DIpPKRFB2M;
		}
		[CompilerGenerated]
		private set
		{
			DIpPKRFB2M = value;
		}
	}

	public IShellItem DestinationFolder
	{
		[CompilerGenerated]
		get
		{
			return goOPxvmCQx;
		}
		[CompilerGenerated]
		private set
		{
			goOPxvmCQx = value;
		}
	}

	public FileOperationResultItemEventArgs(int hresult, TransferSourceFlags flags, IShellItem item, string newName, IShellItem newItem, IShellItem destinationFolder)
		: base(hresult)
	{
		TransferSourceFlags = flags;
		Item = item;
		NewName = newName;
		NewItem = newItem;
		DestinationFolder = destinationFolder;
	}

	internal static bool h01F2eK0bi3ZgQ9UPQF()
	{
		return EjSTehKGi7twXR5xEYP == null;
	}
}
