using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CW.Win32.Shell;

public class FileOperationResultEventArgs : CancelEventArgs
{
	[CompilerGenerated]
	private int PLrPkube34;

	internal static FileOperationResultEventArgs pJFGNEKDbLCXJmMDfkM;

	public int HResult
	{
		[CompilerGenerated]
		get
		{
			return PLrPkube34;
		}
		[CompilerGenerated]
		private set
		{
			PLrPkube34 = value;
		}
	}

	public FileOperationResultEventArgs(int hresult)
	{
		HResult = hresult;
	}

	internal static bool QtUJSUK3w8RQXdcix2P()
	{
		return pJFGNEKDbLCXJmMDfkM == null;
	}
}
