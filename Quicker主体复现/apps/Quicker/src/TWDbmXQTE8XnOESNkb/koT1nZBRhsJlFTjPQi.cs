using System;

namespace TWDbmXQTE8XnOESNkb;

internal sealed class koT1nZBRhsJlFTjPQi : IDisposable
{
	private IDisposable wdZJGByHvB;

	internal static koT1nZBRhsJlFTjPQi Oxp6fA3d0GeOh5H3GZA;

	public IDisposable Content
	{
		get
		{
			return wdZJGByHvB;
		}
		set
		{
			if (wdZJGByHvB != null)
			{
				wdZJGByHvB.Dispose();
			}
			wdZJGByHvB = value;
		}
	}

	public void Dispose()
	{
		Content = null;
	}

	internal static bool B6K7Tk3OePOCFAvWPev()
	{
		return Oxp6fA3d0GeOh5H3GZA == null;
	}
}
