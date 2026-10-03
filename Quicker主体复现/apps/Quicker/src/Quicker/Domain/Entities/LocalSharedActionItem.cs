using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Quicker.Common.Entities;
using Quicker.Common.Vm;

namespace Quicker.Domain.Entities;

public class LocalSharedActionItem
{
	[CompilerGenerated]
	private string TVptjmn7oFp;

	[CompilerGenerated]
	private int knCtjKcFK2x;

	[CompilerGenerated]
	private string b8EtjxRfU1c;

	[CompilerGenerated]
	private DateTime kjptjr6d7Qk;

	internal static LocalSharedActionItem jdbWOWQuFMBTDQ1mAYor;

	public string SharedActionId
	{
		[CompilerGenerated]
		get
		{
			return TVptjmn7oFp;
		}
		[CompilerGenerated]
		set
		{
			TVptjmn7oFp = value;
		}
	}

	public int Revision
	{
		[CompilerGenerated]
		get
		{
			return knCtjKcFK2x;
		}
		[CompilerGenerated]
		set
		{
			knCtjKcFK2x = value;
		}
	}

	public string Data
	{
		[CompilerGenerated]
		get
		{
			return b8EtjxRfU1c;
		}
		[CompilerGenerated]
		set
		{
			b8EtjxRfU1c = value;
		}
	}

	public DateTime InstallTimeUtc
	{
		[CompilerGenerated]
		get
		{
			return kjptjr6d7Qk;
		}
		[CompilerGenerated]
		set
		{
			kjptjr6d7Qk = value;
		}
	}

	public LocalSharedActionItem()
	{
	}

	public LocalSharedActionItem(SharedActionDto sharedAction)
	{
		SharedActionId = sharedAction.Id.ToString();
		Revision = sharedAction.Revision;
		if (sharedAction.UserLimitation >= ActionUserLimitation.ReadOnly)
		{
			Data = "READONLY{" + JsonConvert.SerializeObject(sharedAction);
		}
		else
		{
			Data = JsonConvert.SerializeObject(sharedAction);
		}
		InstallTimeUtc = DateTime.UtcNow;
	}

	internal static bool YUON5tQucVngf1wty4i9()
	{
		return jdbWOWQuFMBTDQ1mAYor == null;
	}
}
