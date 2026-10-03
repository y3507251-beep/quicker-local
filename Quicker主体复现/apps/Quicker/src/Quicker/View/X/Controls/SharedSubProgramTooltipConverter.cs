using System;
using System.Globalization;
using System.Windows.Data;
using Quicker.Common.Vm.SubPrograms;

namespace Quicker.View.X.Controls;

public class SharedSubProgramTooltipConverter : IValueConverter
{
	internal static SharedSubProgramTooltipConverter SmVUiXF9tG6G2YaSK54f;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value is SharedSubProgramListItemDto sharedSubProgramListItemDto)
		{
			return sharedSubProgramListItemDto.Description + "\r\n作者：" + sharedSubProgramListItemDto.UserNickName + "\r\n更新时间：" + sharedSubProgramListItemDto.LastUpdateTimeUtc?.ToLocalTime().ToString("yyyy-MM-dd HH:mm:ss");
		}
		return "";
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	internal static bool f2m7V4F9STexrjVbl0PK()
	{
		return SmVUiXF9tG6G2YaSK54f == null;
	}
}
