namespace Quicker.Common.Vm.Account;

public class UserLimitation
{
	public bool CanUseMobileApp { get; set; }

	public int MaxPcCount { get; set; }

	public int MaxExeCount { get; set; }

	public bool LockButton { get; set; }

	public int MaxPagePerExe { get; set; }

	public int MaxPageFileSize { get; set; }

	public int TotalPageFileSize { get; set; }

	public int MaxIconCount { get; set; }

	public bool EnableActionHistory { get; set; }

	public bool EnableActionHotKey { get; set; }

	public bool EnableStarter { get; set; }

	public bool EnableFloatButton { get; set; }

	public bool EnableSearching { get; set; }

    // 本地版没有会员分级。以下模型仅兼容旧数据格式，EXE 不再用它限制本地功能。
    // 数量和容量的 0 表示不设产品配额；实际容量由本机内存、磁盘和数据格式决定。
    public static UserLimitation Unrestricted { get; } = new UserLimitation
    {
        CanUseMobileApp = true,
        EnableActionHistory = true,
        EnableActionHotKey = true,
        EnableFloatButton = true,
        EnableSearching = true,
        EnableStarter = true,
        LockButton = false, // 不再锁定通用面板右上角按钮。
        MaxExeCount = 0,
        MaxIconCount = 0,
        MaxPagePerExe = 0,
        MaxPcCount = 0,
        MaxPageFileSize = 0,
        TotalPageFileSize = 0
    };

    // 保留旧属性名以兼容依赖程序集；不代表存在免费/付费两个版本。
    public static UserLimitation Free { get; set; } = Unrestricted;
}
