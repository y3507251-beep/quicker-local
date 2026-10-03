using System;
using System.Data;
using System.Globalization;
using Dapper;

namespace Quicker.Domain.Services;

public class DateTimeHandler : SqlMapper.TypeHandler<DateTime>
{
	private static DateTimeHandler jBQyQEQNRBDRIPq8rS5n;

	public override void SetValue(IDbDataParameter parameter, DateTime value)
	{
		parameter.Value = DateTime.SpecifyKind(value, DateTimeKind.Unspecified);
	}

	public override DateTime Parse(object value)
	{
		if (!(value is DateTime value2))
		{
			string text = value as string;
			if (text != null)
			{
				if (text.EndsWith("Z", StringComparison.OrdinalIgnoreCase))
				{
					text = text.Substring(0, text.Length - 1);
				}
				return DateTime.Parse(text, CultureInfo.InvariantCulture, DateTimeStyles.None);
			}
			return Convert.ToDateTime(value, CultureInfo.InvariantCulture);
		}
		return DateTime.SpecifyKind(value2, DateTimeKind.Local);
	}

	internal static bool b7bECoQNgvF2qu14ukkb()
	{
		return jBQyQEQNRBDRIPq8rS5n == null;
	}
}
