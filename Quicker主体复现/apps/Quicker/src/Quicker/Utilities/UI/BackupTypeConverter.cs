using System;
using System.Globalization;
using System.Windows.Data;
using Quicker.Domain.SQL.Entities;

namespace Quicker.Utilities.UI;

public class BackupTypeConverter : IValueConverter
{
	internal static BackupTypeConverter jlJrFgF4RHUbhCxmwfiN;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value == null)
		{
			return "";
		}
		ActionBackupType actionBackupType = ActionBackupType.NA;
		actionBackupType = ((!(value is ActionBackupType)) ? ((ActionBackupType)Enum.ToObject(typeof(ActionBackupType), value)) : ((ActionBackupType)value));
		return actionBackupType switch
		{
			ActionBackupType.EditComplete => "自动(编辑动作)", 
			ActionBackupType.Manual => "手动", 
			ActionBackupType.Deleting => "自动(删除动作)", 
			_ => actionBackupType.ToString(), 
		};
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	static BackupTypeConverter()
	{
	}

	internal static bool ipwsBuF4g8F9Y3CSMMb3()
	{
		return jlJrFgF4RHUbhCxmwfiN == null;
	}

	internal static void TETK6rF4MknmZwp4gHlU()
	{
	}
}
