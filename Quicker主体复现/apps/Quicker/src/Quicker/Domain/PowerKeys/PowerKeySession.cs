using System.Collections.Generic;
using System.Reflection;
using log4net;
using Quicker.Utilities;

namespace Quicker.Domain.PowerKeys;

public class PowerKeySession
{
	private static readonly ILog ATetVOT8RKA;

	private KeyboardState YJptVFdMABu = new KeyboardState();

	private IList<KeyDownItem> Y6ytVUOR3c2 = new List<KeyDownItem>(6);

	private int? FcJtVlhuQht;

	private long? GvitViYbyyS;

	private bool Yt8tV3KVA9W = true;

	private static PowerKeySession FN1SLDQKbLSwtnV1NbKa;

	private void UeYtVAC3Uyt(string string_0)
	{
	}

	public bool IsInSession()
	{
		return FcJtVlhuQht.HasValue;
	}

	public void StartSession(int key)
	{
		if (IsInSession())
		{
			string string_ = $"在session未关闭的时候开始了新的Session。key={key}";
			UeYtVAC3Uyt(string_);
		}
		FcJtVlhuQht = key;
		GvitViYbyyS = AppHelper.fLiLTj0x4QY();
		YJptVFdMABu.KeyDown(key);
		Y6ytVUOR3c2.Add(new KeyDownItem(key));
	}

	public bool IsKeyCaptured(int key)
	{
		return YJptVFdMABu.IsKeyDown(key);
	}

	public void OnKeyUp(int key)
	{
	}

	public void EndSession()
	{
		GvitViYbyyS = 0L;
		YJptVFdMABu.Reset();
		FcJtVlhuQht = null;
		Y6ytVUOR3c2.Clear();
	}

	static PowerKeySession()
	{
		ATetVOT8RKA = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool BGIW7XQKqFbNh3FtsSvE()
	{
		return FN1SLDQKbLSwtnV1NbKa == null;
	}
}
