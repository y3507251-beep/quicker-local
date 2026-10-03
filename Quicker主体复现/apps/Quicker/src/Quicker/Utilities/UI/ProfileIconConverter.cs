using System;
using System.Globalization;
using System.Windows.Data;
using Quicker.Common;
using Quicker.Domain.Exe;
using Quicker.View.Controls;

namespace Quicker.Utilities.UI;

public class ProfileIconConverter : IValueConverter
{
	private static ProfileIconConverter dT26AhFh6aNPu7ZuRWtJ;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value != null)
		{
			ActionProfile actionProfile = value as ActionProfile;
			if (dT26AhFh6aNPu7ZuRWtJ == null)
			{
				switch (0)
				{
				}
			}
			if (actionProfile != null)
			{
				if (string.IsNullOrEmpty(actionProfile.ExeFile))
				{
					if (actionProfile.Name == "_global")
					{
						return ExeFileIconHelper.GetGlobalProfileImage();
					}
					return ExeFileIconHelper.GetCommonProfileImage();
				}
				return ExeFileIconHelper.GetExeFileIcon(actionProfile.ExeFile, actionProfile.ExeFullpath);
			}
			if (value is ProfileConfigItem profileConfigItem)
			{
				if (string.IsNullOrEmpty(profileConfigItem.ExeFile))
				{
					if (profileConfigItem.Name == "_global")
					{
						return ExeFileIconHelper.GetGlobalProfileImage();
					}
					return ExeFileIconHelper.GetCommonProfileImage();
				}
				return ExeFileIconHelper.GetExeFileIcon(profileConfigItem.ExeFile, profileConfigItem.ExeFullpath);
			}
		}
		return null;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	internal static bool IUSeJUFhtTnGycJyMPWT()
	{
		return dT26AhFh6aNPu7ZuRWtJ == null;
	}
}
