using System;
using Quicker.Common.Vm.Account;

namespace Quicker.Domain.Services;

// 本地工作区身份，仅用于关联本机数据；不含登录凭据或服务器会员信息。
public sealed class LocalWorkspaceInfo
{
	public string Id { get; set; } = Guid.NewGuid().ToString();
	public string DisplayName { get; set; } = "本地用户";
	public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
	public bool Initialized { get; set; }

	internal UserInfo ToLegacyView()
	{
		// 暂时兼容已有界面的 UserInfo 数据绑定，启动与保存不进行认证。
		return new UserInfo
		{
			UserId = Id,
			UserName = DisplayName,
			NickName = DisplayName,
			RegTimeUtc = CreatedUtc,
			UserLimitation = UserLimitation.Unrestricted
		};
	}
}
