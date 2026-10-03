using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Quicker.Domain.Hotkeys;
using Quicker.Public.Extensions;

namespace Quicker.Domain.Services;

public class RegisteredHotkeyItem
{
	[CompilerGenerated]
	private string EXFtpU0wRnY;

	[CompilerGenerated]
	private int miytplZsopj;

	[CompilerGenerated]
	private IList<ActionHotKeyItem> AO8tpiNiwxF = new List<ActionHotKeyItem>();

	private static RegisteredHotkeyItem VRTwoCQ9gdDmklqUqTxs;

	public string KeyData
	{
		[CompilerGenerated]
		get
		{
			return EXFtpU0wRnY;
		}
		[CompilerGenerated]
		set
		{
			EXFtpU0wRnY = value;
		}
	}

	public int HotkeyId
	{
		[CompilerGenerated]
		get
		{
			return miytplZsopj;
		}
		[CompilerGenerated]
		set
		{
			miytplZsopj = value;
		}
	}

	public IList<ActionHotKeyItem> ActionHotKeyItems
	{
		[CompilerGenerated]
		get
		{
			return AO8tpiNiwxF;
		}
		[CompilerGenerated]
		private set
		{
			AO8tpiNiwxF = value;
		}
	}

	public RegisteredHotkeyItem()
	{
	}

	public RegisteredHotkeyItem(string keyData, int hotkeyId, params ActionHotKeyItem[] items)
	{
		KeyData = keyData;
		HotkeyId = hotkeyId;
		if (!items.HasData())
		{
			return;
		}
		foreach (ActionHotKeyItem actionHotKeyItem in items)
		{
			if (actionHotKeyItem != null)
			{
				ActionHotKeyItems.Add(actionHotKeyItem);
			}
		}
	}

	internal static bool ilJvZuQ9PHfhnS8WsFZe()
	{
		return VRTwoCQ9gdDmklqUqTxs == null;
	}
}
