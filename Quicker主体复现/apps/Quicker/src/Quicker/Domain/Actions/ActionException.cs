using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Quicker.Common;

namespace Quicker.Domain.Actions;

[Serializable]
public class ActionException : Exception
{
	[CompilerGenerated]
	private ActionItem Q61tnNq6sll;

	internal static ActionException H1pHW0QuNGvY7UTkQiL8;

	public ActionItem Action
	{
		[CompilerGenerated]
		get
		{
			return Q61tnNq6sll;
		}
		[CompilerGenerated]
		set
		{
			Q61tnNq6sll = value;
		}
	}

	public ActionException(string message, ActionItem action)
		: base(message)
	{
		Action = action;
	}

	public ActionException()
	{
	}

	public ActionException(string message)
		: base(message)
	{
	}

	public ActionException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected ActionException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		: base(serializationInfo, streamingContext)
	{
	}

	internal static bool ppn7VqQu9CebSTbC02wS()
	{
		return H1pHW0QuNGvY7UTkQiL8 == null;
	}

	internal static void xbj6rQQuuLIK10fDiI97()
	{
	}
}
