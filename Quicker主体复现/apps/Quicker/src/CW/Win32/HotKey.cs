using System;
using System.Runtime.CompilerServices;

namespace CW.Win32;

public class HotKey : DisposableObject
{
	[CompilerGenerated]
	private HotKeyModifiers iBgCKtRFTv;

	[CompilerGenerated]
	private Keys lLmCxnK2wI;

	[CompilerGenerated]
	private Atom NIPCrXkrbU;

	[CompilerGenerated]
	private HotKeyManager mHaCpaxpi9;

	internal EventHandler<HotKeyEventArgs> sGECBdjMop;

	internal static HotKey R3npaH0me0aCNBAOCes;

	public HotKeyModifiers Modifiers
	{
		[CompilerGenerated]
		get
		{
			return iBgCKtRFTv;
		}
		[CompilerGenerated]
		private set
		{
			iBgCKtRFTv = value;
		}
	}

	public Keys Keys
	{
		[CompilerGenerated]
		get
		{
			return lLmCxnK2wI;
		}
		[CompilerGenerated]
		private set
		{
			lLmCxnK2wI = value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal Atom OcdCHqFxJW()
	{
		return NIPCrXkrbU;
	}

	[SpecialName]
	[CompilerGenerated]
	private void L4vC1thYlM(Atom value)
	{
		NIPCrXkrbU = value;
	}

	[SpecialName]
	[CompilerGenerated]
	internal HotKeyManager SQ0C6p5xr8()
	{
		return mHaCpaxpi9;
	}

	[SpecialName]
	[CompilerGenerated]
	private void qY3CXkSl8q(HotKeyManager value)
	{
		mHaCpaxpi9 = value;
	}

	internal void IXTCk8l8Uw(HotKeyEventArgs hotKeyEventArgs_0)
	{
		sGECBdjMop?.Invoke(SQ0C6p5xr8(), hotKeyEventArgs_0);
	}

	internal HotKey(HotKeyManager manager, Atom atom, HotKeyModifiers mods, Keys keys)
	{
		qY3CXkSl8q(manager);
		Modifiers = mods;
		Keys = keys;
		L4vC1thYlM(atom);
	}

	protected override void Dispose(bool disposing)
	{
		if (!base.IsDisposed)
		{
			SQ0C6p5xr8().LmCCeARDss(this);
		}
		base.Dispose(disposing);
	}

	internal static bool Oj94X50sPW57rC2ADJn()
	{
		return R3npaH0me0aCNBAOCes == null;
	}
}
