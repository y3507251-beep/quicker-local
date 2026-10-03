using System.Collections;
using System.Collections.Generic;

namespace Quicker.Utilities;

public static class TypeChecker
{
	internal static object aR5t1kFY1ul0Gd38t1iU;

	public static bool IsList(this object o)
	{
		if (o == null)
		{
			return false;
		}
		if (o is IList && o.GetType().IsGenericType)
		{
			return o.GetType().GetGenericTypeDefinition().IsAssignableFrom(typeof(List<>));
		}
		return false;
	}

	public static bool IsDictionary(this object o)
	{
		if (o == null)
		{
			return false;
		}
		if (o is IDictionary && o.GetType().IsGenericType)
		{
			return o.GetType().GetGenericTypeDefinition().IsAssignableFrom(typeof(Dictionary<, >));
		}
		return false;
	}

	internal static bool yYaXQmFYKbNxHGSojNCG()
	{
		return aR5t1kFY1ul0Gd38t1iU == null;
	}
}
