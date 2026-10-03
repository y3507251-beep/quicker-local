using System;
using System.Collections.Generic;

namespace CW.Win32;

public class CachedInteropObject : InteropObject
{
	private IDictionary<string, object> Up90lymtSH = new Dictionary<string, object>();

	private static CachedInteropObject qYP6w8G0D8UTha8Fwpb;

	public CachedInteropObject(string dllName)
		: base(dllName)
	{
	}

	public CachedInteropObject(IntPtr handle)
		: base(handle)
	{
	}

	public override T LoadMethod<T>(string name)
	{
		T val;
		if (!Up90lymtSH.TryGetValue(name, out var value))
		{
			val = base.LoadMethod<T>(name);
			Up90lymtSH[name] = val;
		}
		else
		{
			val = (T)value;
		}
		return val;
	}

	internal static bool mhLvs0G1kv6braMYYNi()
	{
		return qYP6w8G0D8UTha8Fwpb == null;
	}
}
