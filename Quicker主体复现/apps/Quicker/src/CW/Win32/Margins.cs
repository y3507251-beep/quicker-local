using System.Runtime.InteropServices;

namespace CW.Win32;

[StructLayout(LayoutKind.Sequential)]
public sealed class Margins
{
	private int ilxCwDiQuj;

	private int qmPCt39Klp;

	private int AdtCgvmF46;

	private int MJgCLdjLFo;

	private static Margins uyH55uG9mYXxd82K6xZ;

	public int Left
	{
		get
		{
			return ilxCwDiQuj;
		}
		set
		{
			ilxCwDiQuj = value;
		}
	}

	public int Right
	{
		get
		{
			return qmPCt39Klp;
		}
		set
		{
			qmPCt39Klp = value;
		}
	}

	public int Top
	{
		get
		{
			return AdtCgvmF46;
		}
		set
		{
			AdtCgvmF46 = value;
		}
	}

	public int Bottom
	{
		get
		{
			return MJgCLdjLFo;
		}
		set
		{
			MJgCLdjLFo = value;
		}
	}

	internal static bool zCvTxbGL2MUwwDW2ZCc()
	{
		return uyH55uG9mYXxd82K6xZ == null;
	}
}
