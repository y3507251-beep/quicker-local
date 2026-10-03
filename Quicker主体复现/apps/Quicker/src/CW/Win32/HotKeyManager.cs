using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace CW.Win32;

public class HotKeyManager : DisposableObject
{
	private IDictionary<int, HotKey> tgbCYpwBxf = new Dictionary<int, HotKey>();

	[CompilerGenerated]
	private IntPtr imdCI2UYSa;

	[CompilerGenerated]
	private EventHandler<HotKeyEventArgs> RHUCWqnTsm;

	private static HotKeyManager yJu2L40ST5GH6JmqjSx;

	public IntPtr Handle
	{
		[CompilerGenerated]
		get
		{
			return imdCI2UYSa;
		}
		[CompilerGenerated]
		set
		{
			imdCI2UYSa = value;
		}
	}

	public IEnumerable<HotKey> HotKeys => tgbCYpwBxf.Values;

	public event EventHandler<HotKeyEventArgs> HotKeyPressed
	{
		[CompilerGenerated]
		add
		{
			EventHandler<HotKeyEventArgs> eventHandler = RHUCWqnTsm;
			EventHandler<HotKeyEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<HotKeyEventArgs> value2 = (EventHandler<HotKeyEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref RHUCWqnTsm, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<HotKeyEventArgs> eventHandler = RHUCWqnTsm;
			EventHandler<HotKeyEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<HotKeyEventArgs> value2 = (EventHandler<HotKeyEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref RHUCWqnTsm, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public HotKeyManager(IntPtr hwnd)
	{
	}

	protected virtual void OnHotKeyPressed(HotKeyEventArgs e)
	{
		RHUCWqnTsm?.Invoke(this, e);
	}

	public HotKey Register(HotKeyModifiers mods, Keys key)
	{
		return Register(mods, key, null);
	}

	public HotKey Register(HotKeyModifiers mods, Keys key, EventHandler<HotKeyEventArgs> pressed)
	{
		ThrowIfDisposed();
		Atom atom = ks2ChAYGyk(mods, key);
		HotKey hotKey;
		if (User32.RegisterHotKey(Handle, atom.Id, mods, key))
		{
			hotKey = new HotKey(this, atom, mods, key);
			tgbCYpwBxf.Add(atom.Id, hotKey);
		}
		else
		{
			hotKey = tgbCYpwBxf[atom.Id];
		}
		if (pressed != null)
		{
			HotKey hotKey2 = hotKey;
			hotKey2.sGECBdjMop = (EventHandler<HotKeyEventArgs>)Delegate.Combine(hotKey2.sGECBdjMop, pressed);
		}
		return hotKey;
	}

	public void Unregister(HotKey hotkey)
	{
		ThrowIfDisposed();
		if (hotkey.SQ0C6p5xr8() != this)
		{
			throw new ArgumentException("hotkey");
		}
		hotkey.Dispose();
	}

	public void Unregister(HotKey hotkey, EventHandler<HotKeyEventArgs> pressed)
	{
		hotkey.sGECBdjMop = (EventHandler<HotKeyEventArgs>)Delegate.Remove(hotkey.sGECBdjMop, pressed);
	}

	public void Unregister(HotKeyModifiers mods, Keys key, EventHandler<HotKeyEventArgs> pressed)
	{
		using Atom atom = ks2ChAYGyk(mods, key);
		if (tgbCYpwBxf.TryGetValue(atom.Id, out var value))
		{
			HotKey hotKey = value;
			hotKey.sGECBdjMop = (EventHandler<HotKeyEventArgs>)Delegate.Remove(hotKey.sGECBdjMop, pressed);
		}
	}

	private Atom ks2ChAYGyk(HotKeyModifiers hotKeyModifiers_0, Keys keys_0)
	{
		return new Atom(Handle + "_" + hotKeyModifiers_0.ToString() + "_" + keys_0);
	}

	public IntPtr WndProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
	{
		if (msg == 786 && tgbCYpwBxf.TryGetValue(wParam.ToInt32(), out var value))
		{
			HotKeyEventArgs e = new HotKeyEventArgs(value);
			value.IXTCk8l8Uw(e);
			OnHotKeyPressed(e);
		}
		return IntPtr.Zero;
	}

	protected override void Dispose(bool disposing)
	{
		if (!base.IsDisposed)
		{
			HotKey[] array = HotKeys.ToArray();
			int num = 0;
			if (yJu2L40ST5GH6JmqjSx != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			foreach (HotKey hotkey in array)
			{
				Unregister(hotkey);
			}
		}
		base.Dispose(disposing);
	}

	internal void LmCCeARDss(HotKey hotKey_0)
	{
		User32.UnregisterHotKey(Handle, hotKey_0.OcdCHqFxJW().Id);
		tgbCYpwBxf.Remove(hotKey_0.OcdCHqFxJW().Id);
		hotKey_0.OcdCHqFxJW().Dispose();
	}

	internal static bool V4kMny0wgR69bJF7eq6()
	{
		return yJu2L40ST5GH6JmqjSx == null;
	}
}
