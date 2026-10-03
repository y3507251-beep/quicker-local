using System;
using System.Globalization;
using System.Windows.Data;

namespace Quicker.Utilities.UI;

public class UtcTimeConverter : IValueConverter
{
	internal static UtcTimeConverter V2MgPxF44MQ1DBdb1SVd;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value == null)
		{
			return string.Empty;
		}
		DateTime dateTime;
		if (value is DateTime value2)
		{
			if (!E0GxjMF4hAOwUNbrFo7q())
			{
				switch (0)
				{
				}
			}
			dateTime = DateTime.SpecifyKind(value2, DateTimeKind.Utc).ToLocalTime();
		}
		else
		{
			dateTime = DateTime.Parse(value?.ToString(), CultureInfo.InvariantCulture).ToLocalTime();
		}
		if (dateTime.Date == DateTime.Now.Date)
		{
			return "今天 " + dateTime.ToString("HH:mm:ss", CultureInfo.InvariantCulture);
		}
		if (dateTime.Date == DateTime.Now.Date.AddDays(-1.0))
		{
			return "昨天 " + dateTime.ToString("HH:mm:ss", CultureInfo.InvariantCulture);
		}
		return dateTime.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	internal static bool E0GxjMF4hAOwUNbrFo7q()
	{
		return V2MgPxF44MQ1DBdb1SVd == null;
	}
}
