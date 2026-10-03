using System.Runtime.CompilerServices;
using Quicker.Utilities;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Misc;

public class ActionStateCacheItem
{
	private bool duIgPO0jVvm;

	[CompilerGenerated]
	private long wXogPFUm6xX;

	[CompilerGenerated]
	private ActionState SXegPUoVdRU;

	private static ActionStateCacheItem E4QSndQxQKdoQ7k75hAW;

	public bool HasModified => duIgPO0jVvm;

	public long ModifiedTicks
	{
		[CompilerGenerated]
		get
		{
			return wXogPFUm6xX;
		}
		[CompilerGenerated]
		private set
		{
			wXogPFUm6xX = value;
		}
	}

	public ActionState ActionState
	{
		[CompilerGenerated]
		get
		{
			return SXegPUoVdRU;
		}
		[CompilerGenerated]
		set
		{
			SXegPUoVdRU = value;
		}
	}

	public void SetModified()
	{
		duIgPO0jVvm = true;
		ModifiedTicks = AppHelper.fLiLTj0x4QY();
	}

	public void ClearModifiedFlag()
	{
		duIgPO0jVvm = false;
	}

	internal static bool imNIpRQxF1grbldqi0O7()
	{
		return E4QSndQxQKdoQ7k75hAW == null;
	}
}
