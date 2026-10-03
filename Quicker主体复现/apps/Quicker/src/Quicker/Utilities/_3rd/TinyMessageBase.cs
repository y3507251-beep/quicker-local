using System;

namespace Quicker.Utilities._3rd;

public abstract class TinyMessageBase : ITinyMessage
{
	private readonly WeakReference xWuLzeZwXKt;

	private static TinyMessageBase pD9lyDFTUM5cMwvmEABj;

	public object Sender
	{
		get
		{
			if (xWuLzeZwXKt != null)
			{
				return xWuLzeZwXKt.Target;
			}
			return null;
		}
	}

	public TinyMessageBase(object sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		xWuLzeZwXKt = new WeakReference(sender);
	}

	internal static bool R9IOLLFTxsODEmIi65ue()
	{
		return pD9lyDFTUM5cMwvmEABj == null;
	}
}
