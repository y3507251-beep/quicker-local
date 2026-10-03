using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Quicker.Utilities._3rd;

public class ItemPropertyChangedEventArgs : PropertyChangedEventArgs
{
	[CompilerGenerated]
	private readonly int OLqLzalKbb5;

	private static ItemPropertyChangedEventArgs dw8WBNFTXLkLTLJIMF46;

	public int CollectionIndex
	{
		[CompilerGenerated]
		get
		{
			return OLqLzalKbb5;
		}
	}

	public ItemPropertyChangedEventArgs(int index, string name)
		: base(name)
	{
		OLqLzalKbb5 = index;
	}

	public ItemPropertyChangedEventArgs(int index, PropertyChangedEventArgs args)
		: this(index, args.PropertyName)
	{
	}

	internal static bool oIjUNFFT2MBHPxINpEUk()
	{
		return dw8WBNFTXLkLTLJIMF46 == null;
	}
}
