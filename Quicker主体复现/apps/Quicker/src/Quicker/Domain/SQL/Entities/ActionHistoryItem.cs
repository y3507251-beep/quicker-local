using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Quicker.Common;

namespace Quicker.Domain.SQL.Entities;

public class ActionHistoryItem
{
	[CompilerGenerated]
	private string Q7ltVCwxYMW;

	[CompilerGenerated]
	private string v0EtVPwdShh;

	[CompilerGenerated]
	private DateTime rNMtVECj7DB;

	[CompilerGenerated]
	private DateTime TwctVyfXrxq;

	[CompilerGenerated]
	private ActionBackupType zmxtV82b4C9;

	[CompilerGenerated]
	private string tmBtVacVEIg;

	[CompilerGenerated]
	private string OIJtV7cYsr0;

	private static ActionHistoryItem WqUKOBQ1SFxWZNHx5idE;

	public string RowId
	{
		[CompilerGenerated]
		get
		{
			return Q7ltVCwxYMW;
		}
		[CompilerGenerated]
		set
		{
			Q7ltVCwxYMW = value;
		}
	}

	public string ActionId
	{
		[CompilerGenerated]
		get
		{
			return v0EtVPwdShh;
		}
		[CompilerGenerated]
		set
		{
			v0EtVPwdShh = value;
		}
	}

	public DateTime BackupTimeUtc
	{
		[CompilerGenerated]
		get
		{
			return rNMtVECj7DB;
		}
		[CompilerGenerated]
		set
		{
			rNMtVECj7DB = value;
		}
	}

	public DateTime ExpireTimeUtc
	{
		[CompilerGenerated]
		get
		{
			return TwctVyfXrxq;
		}
		[CompilerGenerated]
		set
		{
			TwctVyfXrxq = value;
		}
	}

	public ActionBackupType BackupType
	{
		[CompilerGenerated]
		get
		{
			return zmxtV82b4C9;
		}
		[CompilerGenerated]
		set
		{
			zmxtV82b4C9 = value;
		}
	}

	public string Note
	{
		[CompilerGenerated]
		get
		{
			return tmBtVacVEIg;
		}
		[CompilerGenerated]
		set
		{
			tmBtVacVEIg = value;
		}
	}

	public string Data
	{
		[CompilerGenerated]
		get
		{
			return OIJtV7cYsr0;
		}
		[CompilerGenerated]
		set
		{
			OIJtV7cYsr0 = value;
		}
	}

	public ActionItem GetAction()
	{
		if (string.IsNullOrEmpty(Data))
		{
			return null;
		}
		return JsonConvert.DeserializeObject<ActionItem>(Data);
	}

	internal static bool drpStcQ1w3sg8nwqQY3p()
	{
		return WqUKOBQ1SFxWZNHx5idE == null;
	}
}
