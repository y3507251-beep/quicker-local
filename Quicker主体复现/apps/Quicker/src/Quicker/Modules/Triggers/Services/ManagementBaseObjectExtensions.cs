using System.Management;

namespace Quicker.Modules.Triggers.Services;

public static class ManagementBaseObjectExtensions
{
	internal static object NkWGqpQcSOZr5yvS4Qb1;

	public static string TryGetProperty(this ManagementBaseObject wmiObj, string propertyName)
	{
		try
		{
			object propertyValue = wmiObj.GetPropertyValue(propertyName);
			return (propertyValue != null) ? propertyValue.ToString() : string.Empty;
		}
		catch (ManagementException)
		{
			return string.Empty;
		}
	}

	internal static bool g7cgjBQcwpGdVjZ7nbTu()
	{
		return NkWGqpQcSOZr5yvS4Qb1 == null;
	}
}
