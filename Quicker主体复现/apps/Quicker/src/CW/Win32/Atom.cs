using System;
using System.Runtime.CompilerServices;

namespace CW.Win32;

public class Atom : DisposableObject, IEquatable<Atom>
{
	[CompilerGenerated]
	private int VsS0UreLoe;

	private static Atom WkfmIwGDbLYIdeTKfsJ;

	public int Id
	{
		[CompilerGenerated]
		get
		{
			return VsS0UreLoe;
		}
		[CompilerGenerated]
		private set
		{
			VsS0UreLoe = value;
		}
	}

	public Atom(string str)
	{
		str.ThrowIfNull("str");
		int value = Kernel32.GlobalAddAtom(str);
		Id = value;
	}

	protected override void Dispose(bool disposing)
	{
		if (!base.IsDisposed)
		{
			Kernel32.GlobalDeleteAtom(Id);
		}
		base.Dispose(disposing);
	}

	public override int GetHashCode()
	{
		return Id;
	}

	public override bool Equals(object obj)
	{
		if (obj is Atom atom)
		{
			return Equals(atom);
		}
		return base.Equals(obj);
	}

	public bool Equals(Atom atom)
	{
		if (atom != null)
		{
			return Id == atom.Id;
		}
		return false;
	}

	internal static bool v4PKrRG399XDdhD741W()
	{
		return WkfmIwGDbLYIdeTKfsJ == null;
	}
}
