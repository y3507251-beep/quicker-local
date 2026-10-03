using System;
using System.Collections.Generic;
using System.Globalization;
using Quicker.Utilities._3rd;
using WindowsInput.Native;

namespace Quicker.Domain.Hotkeys;

public static class HotkeyHelper
{
	public static (IList<VirtualKeyCode> ctrlKeys, IList<VirtualKeyCode> normalKeys) DataToKeys(string config)
	{
		if (string.IsNullOrEmpty(config))
		{
			return (ctrlKeys: new List<VirtualKeyCode>(), normalKeys: new List<VirtualKeyCode>());
		}
		List<VirtualKeyCode> list = new List<VirtualKeyCode>();
		List<VirtualKeyCode> list2 = new List<VirtualKeyCode>();
		string[] array = config.Split('|');
		uint num = Convert.ToUInt32(array[0], CultureInfo.InvariantCulture);
		uint item = Convert.ToUInt32(array[1], CultureInfo.InvariantCulture);
		if ((num & 1) != 0)
		{
			list.Add(VirtualKeyCode.MENU);
		}
		if ((num & 2) != 0)
		{
			list.Add(VirtualKeyCode.CONTROL);
		}
		if ((num & 4) != 0)
		{
			list.Add(VirtualKeyCode.SHIFT);
		}
		if ((num & 8) != 0)
		{
			list.Add(VirtualKeyCode.LWIN);
		}
		list2.Add((VirtualKeyCode)item);
		return (ctrlKeys: list, normalKeys: list2);
	}

	public static string GetHotkeyData(IList<VirtualKeyCode> ctrlKeys, IList<VirtualKeyCode> keys)
	{
		if (ctrlKeys.Count == 0 && keys.Count == 0)
		{
			return string.Empty;
		}
		uint num = 0u;
		if (ctrlKeys.ContainsAny(VirtualKeyCode.MENU, VirtualKeyCode.LMENU, VirtualKeyCode.RMENU))
		{
			num++;
		}
		if (ctrlKeys.ContainsAny(VirtualKeyCode.CONTROL, VirtualKeyCode.LCONTROL, VirtualKeyCode.RCONTROL))
		{
			num += 2;
		}
		if (ctrlKeys.ContainsAny(VirtualKeyCode.SHIFT, VirtualKeyCode.LSHIFT, VirtualKeyCode.RSHIFT))
		{
			num += 4;
		}
		if (ctrlKeys.ContainsAny(VirtualKeyCode.LWIN, VirtualKeyCode.RWIN))
		{
			num += 8;
		}
		uint num2 = 0u;
		if (keys.Count > 0)
		{
			num2 = (uint)keys[0];
		}
		return $"{num}|{num2}";
	}
}
