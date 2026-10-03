using System.Runtime.CompilerServices;
using Quicker.Utilities._3rd;

namespace Quicker.Domain.Messages;

public class StateChangedMessage : TinyMessageBase
{
	[CompilerGenerated]
	private ChangedStateType hQLthQX0aOw;

	[CompilerGenerated]
	private object IMjthjLmV8Z;

	internal static StateChangedMessage uWd8SpQvc9SWFlks99HP;

	public ChangedStateType StateType
	{
		[CompilerGenerated]
		get
		{
			return hQLthQX0aOw;
		}
		[CompilerGenerated]
		set
		{
			hQLthQX0aOw = value;
		}
	}

	public object Value
	{
		[CompilerGenerated]
		get
		{
			return IMjthjLmV8Z;
		}
		[CompilerGenerated]
		set
		{
			IMjthjLmV8Z = value;
		}
	}

	public StateChangedMessage(object sender, ChangedStateType stateType, object value)
		: base(sender)
	{
		StateType = stateType;
		Value = value;
	}

	internal static bool LCeaaxQvWam8h7Ej3Eub()
	{
		return uWd8SpQvc9SWFlks99HP == null;
	}
}
