using System.Runtime.InteropServices;

namespace Linearstar.Windows.RawInput.Native;

public struct RawInputMouseInfo
{
	private readonly int vGusDQUgAM;

	private readonly int AvKsdwtqX3;

	private readonly int C8isoLrojB;

	[MarshalAs(UnmanagedType.Bool)]
	private readonly bool vBSsTkxgms;

	public int Id => vGusDQUgAM;

	public int ButtonCount => AvKsdwtqX3;

	public int SampleRate => C8isoLrojB;

	public bool HasHorizontalWheel => vBSsTkxgms;
}
