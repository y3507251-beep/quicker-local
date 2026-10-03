using Newtonsoft.Json.Linq;

namespace d91F2HX0Pk7LuKbowAc;

internal static class g2brLAXEYUViQhZJgAl
{
	private static object PbAGE1QwXlLBJW24X0IQ;

	public static bool pV7ghE9Kcqi(JToken jtoken_0)
	{
		if (jtoken_0 == null)
		{
			return true;
		}
		switch (jtoken_0.Type)
		{
		default:
			return false;
		case JTokenType.Integer:
		case JTokenType.Float:
		case JTokenType.String:
		case JTokenType.Boolean:
		case JTokenType.Null:
		case JTokenType.Date:
		case JTokenType.Guid:
		case JTokenType.Uri:
		case JTokenType.TimeSpan:
			return true;
		}
	}

	public static bool Fvqghyf4xeT(JArray jarray_0)
	{
		if (jarray_0 != null && jarray_0.Count != 0)
		{
			foreach (JToken item in jarray_0)
			{
				if (!pV7ghE9Kcqi(item))
				{
					return false;
				}
			}
			return true;
		}
		return true;
	}

	internal static bool ggpeOWQw2pnwYD3UMnaS()
	{
		return PbAGE1QwXlLBJW24X0IQ == null;
	}
}
