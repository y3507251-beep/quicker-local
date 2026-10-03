using System;
using System.Runtime.InteropServices;
using Linearstar.Windows.RawInput.Native;

namespace Linearstar.Windows.RawInput;

public class HidPreparsedDataPtr : SafeHandle
{
	private readonly GCHandle? MDNkxSb4Ax;

	internal static HidPreparsedDataPtr YC1poxqK5tRkK9swu47;

	public override bool IsInvalid => handle == IntPtr.Zero;

	public HidPreparsedDataPtr(HidPreparsedData handle)
		: base(IntPtr.Zero, true)
	{
		base.handle = HidPreparsedData.GetRawValue(handle);
	}

	public HidPreparsedDataPtr(byte[] preparsedData)
		: base(IntPtr.Zero, true)
	{
		MDNkxSb4Ax = GCHandle.Alloc(preparsedData, GCHandleType.Pinned);
		handle = MDNkxSb4Ax.Value.AddrOfPinnedObject();
	}

	protected override bool ReleaseHandle()
	{
		MDNkxSb4Ax?.Free();
		return true;
	}

	public static implicit operator HidPreparsedData(HidPreparsedDataPtr ptr)
	{
		return (HidPreparsedData)ptr.DangerousGetHandle();
	}

	internal static bool cDxotVqBUHXCjhvZuqa()
	{
		return YC1poxqK5tRkK9swu47 == null;
	}
}
