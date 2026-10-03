using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Runtime.CompilerServices;
using log4net;
using otp5BNwoOTeKCWhwo6K;
using Quicker.Common.Entities;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Modules.Triggers.Services;
using Quicker.Public.Actions;
using Quicker.Public.Forms;
using YDnFyFwG4PlN0Cedwny;

namespace Tx9KyNwN0mDt2JKQRKC;

internal class CJaKC4wvor327sX3hhe : kWjRPcwItwkeAamARyg
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec pyJvIBH0WI7;

		public static Func<CommonTriggerTask, bool> iIWvIQuxjRq;

		internal static _003C_003Ec M9X2HTcZkI3xwTwOpFJR;

		static _003C_003Ec()
		{
			pyJvIBH0WI7 = new _003C_003Ec();
		}

		internal bool vr9vIp1epvB(CommonTriggerTask x)
		{
			return x.EventType == "DriveInserted";
		}

		internal static bool y7MIaScZaUQYeNQ6HNS9()
		{
			return M9X2HTcZkI3xwTwOpFJR == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass14_0
	{
		public string X0PvInwXix4;

		internal static _003C_003Ec__DisplayClass14_0 YcoIOpcZNdA4Eeai2X3U;

		internal bool wrIvIjU7Inm(DriveInfo x)
		{
			return x.Name.StartsWith(X0PvInwXix4, StringComparison.OrdinalIgnoreCase);
		}

		internal static bool D2QGawcZ9k2KjJ8ONrFk()
		{
			return YcoIOpcZNdA4Eeai2X3U == null;
		}
	}

	[CompilerGenerated]
	private readonly IDictionary<string, string> iIJtwU4MlpL = new Dictionary<string, string> { { "DriveInserted", "磁盘插入" } };

	private FormField HkLtwllPAy8 = new FormField
	{
		FieldKey = "DriveVolumeLabel",
		Label = "卷标",
		DictVarType = VarType.Text,
		HelpText = "可选。关注的挂接磁盘卷标，多个时使用分号隔开。也可使用“regex:正则表达式”进行正则匹配。",
		IsRequired = false,
		InputMethod = InputMethod.TextBox
	};

	private FormField CQatwigtspa = new FormField
	{
		FieldKey = "DriveLetter",
		Label = "盘符",
		DictVarType = VarType.Text,
		HelpText = "可选。盘符，多个时使用分号隔开，如F;G。",
		IsRequired = false,
		InputMethod = InputMethod.TextBox
	};

	private ManagementEventWatcher rjjtw3nfuxG;

	private static readonly ILog rVKtwf5Utuc;

	private static CJaKC4wvor327sX3hhe fcdkPaQcWuRn5OZDsmuq;

	[SpecialName]
	[CompilerGenerated]
	protected override IDictionary<string, string> OVPM2wsWcIu()
	{
		return iIJtwU4MlpL;
	}

	public CJaKC4wvor327sX3hhe()
		: base(new string[1] { "DriveInserted" })
	{
	}

	public override IList<FormField> odUM2hmvkik(string string_1)
	{
		return new List<FormField> { HkLtwllPAy8, CQatwigtspa };
	}

	public override IList<ActionVariable> VrkM2LPKH4P(string string_1)
	{
		return new List<ActionVariable>
		{
			new ActionVariable
			{
				Key = "DriveLetter",
				Desc = "盘符",
				Type = VarType.Text
			},
			new ActionVariable
			{
				Key = "VolumeLabel",
				Desc = "卷标",
				Type = VarType.Text
			},
			new ActionVariable
			{
				Key = "DriveType",
				Desc = "磁盘类型",
				Type = VarType.Text
			},
			new ActionVariable
			{
				Key = "RootDirectory",
				Desc = "根路径",
				Type = VarType.Text
			},
			new ActionVariable
			{
				Key = "TotalSize",
				Desc = "总大小",
				Type = VarType.Integer
			},
			new ActionVariable
			{
				Key = "TotalFreeSpace",
				Desc = "可用空间",
				Type = VarType.Integer
			},
			new ActionVariable
			{
				Key = "DriveFormat",
				Desc = "文件系统",
				Type = VarType.Text
			}
		};
	}

	protected override void fb3M2Rxtx1E()
	{
		e2xtwFMkYW3();
		rjjtw3nfuxG = new ManagementEventWatcher(new WqlEventQuery("SELECT * FROM Win32_VolumeChangeEvent  WHERE EventType = 2 or EventType = 3"));
		rjjtw3nfuxG.EventArrived += dqGtwOlZAsA;
		rjjtw3nfuxG.Start();
	}

	private void dqGtwOlZAsA(object sender, EventArrivedEventArgs e)
	{
		_003C_003Ec__DisplayClass14_0 _003C_003Ec__DisplayClass14_ = new _003C_003Ec__DisplayClass14_0();
		string text = e.NewEvent.TryGetProperty("EventType");
		_003C_003Ec__DisplayClass14_.X0PvInwXix4 = e.NewEvent.TryGetProperty("DriveName").First().ToString();
		if (!(text == "2"))
		{
			return;
		}
		DriveInfo driveInfo = DriveInfo.GetDrives().FirstOrDefault(_003C_003Ec__DisplayClass14_.wrIvIjU7Inm);
		if (driveInfo == null)
		{
			rVKtwf5Utuc.Error("未能获取磁盘" + _003C_003Ec__DisplayClass14_.X0PvInwXix4 + "的DriveInfo信息");
			return;
		}
		long num = 0L;
		long num2 = 0L;
		string value = "";
		string text2 = "";
		string value2 = "";
		string value3 = "";
		try
		{
			text2 = driveInfo.VolumeLabel;
			num = driveInfo.TotalSize;
			num2 = driveInfo.TotalFreeSpace;
			value = driveInfo.DriveFormat;
			value2 = driveInfo.RootDirectory.FullName;
			value3 = driveInfo.DriveType.ToString();
		}
		catch (Exception exception)
		{
			rVKtwf5Utuc.Warn("获取磁盘信息失败", exception);
		}
		int num4 = default(int);
		foreach (CommonTriggerTask item in jpqtg8Grl0b.Where(_003C_003Ec.iIWvIQuxjRq ?? (_003C_003Ec.iIWvIQuxjRq = _003C_003Ec.pyJvIBH0WI7.vr9vIp1epvB)))
		{
			string text3 = item.TryGetParamValue("DriveLetter", "");
			string text4 = item.TryGetParamValue("DriveVolumeLabel", "");
			if (!string.IsNullOrEmpty(text3))
			{
				int num3 = 0;
				if (!wnf2BVQcyGqpp7VTTVBM())
				{
					num3 = num4;
				}
				switch (num3)
				{
				}
				if (!GFGFgbwXKocENyrCUx4.ibMflIV9C4(text3, _003C_003Ec__DisplayClass14_.X0PvInwXix4))
				{
					continue;
				}
			}
			if (string.IsNullOrEmpty(text4) || GFGFgbwXKocENyrCUx4.ibMflIV9C4(text4, text2))
			{
				Dictionary<string, object> idictionary_ = new Dictionary<string, object>
				{
					{ "DriveLetter", _003C_003Ec__DisplayClass14_.X0PvInwXix4 },
					{ "VolumeLabel", text2 },
					{ "DriveType", value3 },
					{ "RootDirectory", value2 },
					{ "TotalSize", num },
					{ "TotalFreeSpace", num2 },
					{ "DriveFormat", value }
				};
				if (iJ2tguv8HCS(item, idictionary_) && item.SkipFurtherTasks)
				{
					break;
				}
			}
		}
	}

	protected override void C5rM2eDjuIN()
	{
		e2xtwFMkYW3();
	}

	private void e2xtwFMkYW3()
	{
		if (rjjtw3nfuxG != null)
		{
			rjjtw3nfuxG.Stop();
			rjjtw3nfuxG.EventArrived -= dqGtwOlZAsA;
			rjjtw3nfuxG.Dispose();
			rjjtw3nfuxG = null;
		}
	}

	static CJaKC4wvor327sX3hhe()
	{
		rVKtwf5Utuc = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool wnf2BVQcyGqpp7VTTVBM()
	{
		return fcdkPaQcWuRn5OZDsmuq == null;
	}
}
