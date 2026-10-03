using System;
using System.Collections.Generic;
using Quicker.Common;

namespace Quicker.Domain.Services;

public class ProfileContentChangeChecker
{
	private readonly IDictionary<string, string> yqltKQQG7pb = new Dictionary<string, string>();

	internal static ProfileContentChangeChecker i7ogU4QrIHy2kuHsjM3X;

	public void UpdateProfile(ActionProfile profile, string dataCode)
	{
		yqltKQQG7pb[profile.Id] = dataCode;
	}

	public bool IsProfileChanged(ActionProfile profile, string dataCode)
	{
		if (!yqltKQQG7pb.ContainsKey(profile.Id))
		{
			return true;
		}
		return !string.Equals(yqltKQQG7pb[profile.Id], dataCode, StringComparison.Ordinal);
	}

	public void RemoveProfile(ActionProfile profile)
	{
		if (yqltKQQG7pb.ContainsKey(profile.Id))
		{
			yqltKQQG7pb.Remove(profile.Id);
		}
	}

	public void RemoveProfile(string id)
	{
		if (yqltKQQG7pb.ContainsKey(id))
		{
			yqltKQQG7pb.Remove(id);
		}
	}

	static ProfileContentChangeChecker()
	{
	}

	internal static bool jpJ4aOQr6xshemmLCQcY()
	{
		return i7ogU4QrIHy2kuHsjM3X == null;
	}

	internal static void EFnAybQrSm5YRTcwWp4G()
	{
	}
}
