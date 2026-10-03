using System;
using System.IO;
using Quicker.Domain.Interfaces;

namespace Quicker.Domain.Services;

public class AppPathProvider : IAppPathProvider
{
	// 按用户要求读取原有本地动作和设置；账号清理及数据迁移暂不执行。
	public static string LocalDataRoot => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Quicker");

	private static AppPathProvider aVDdgpQ9L582CMfNyWkE;

	public string GetBasePath()
	{
		return LocalDataRoot;
	}

	public string GetDataSubFolder()
	{
		return Path.Combine(GetBasePath(), "data");
	}

	internal static bool zG21LPQ9uDses3AxGGFc()
	{
		return aVDdgpQ9L582CMfNyWkE == null;
	}
}
