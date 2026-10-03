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

    // 开源，免费版的本地默认配置。
    // 这些是配置值，具体什么时候检查、如何限制，由使用这些配置的代码决定。
    public static UserLimitation Free { get; set; } = new UserLimitation
    {
        // 是否允许使用移动端：true 表示允许。
        CanUseMobileApp = true,

        // 是否启用动作历史：false 表示不启用。
        EnableActionHistory = true,

        // 是否启用动作快捷键：false 表示不启用。
        EnableActionHotKey = true,

        // 是否启用悬浮按钮：false 表示不启用。
        EnableFloatButton = true,

        // 是否启用搜索功能：false 表示不启用。
        EnableSearching = true,

        // 是否启用启动器功能：false 表示不启用。
        EnableStarter = true,

        // 是否开启按钮锁定标志：true 表示开启。
        // 具体锁定哪些按钮、如何锁定，需要查看使用该属性的代码。
        LockButton = true,

        // 程序配置数量上限：默认 12。
        MaxExeCount = 20,

        // 图标数量上限：默认 50。
        MaxIconCount = 100,

        // 每个程序的页面数量上限：默认 1。
        MaxPagePerExe = 2,

        // 电脑数量上限：默认 2。
        // 具体统计绑定电脑还是同时在线电脑，目前尚未确认。
        MaxPcCount = 2,

        // 单个页面文件的大小上限：默认 500000。
        // 大小单位目前尚未确认。
        MaxPageFileSize = 1000000,

        // 页面文件的总大小上限：默认 1000000。
        // 大小单位和计入范围目前尚未确认。
        TotalPageFileSize = 2000000
    };

}
