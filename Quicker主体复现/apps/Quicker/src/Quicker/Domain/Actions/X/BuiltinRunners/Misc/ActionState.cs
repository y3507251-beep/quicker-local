using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Misc;

public class ActionState
{
	[CompilerGenerated]
	private string pqKgyAGY8Fp;

	[CompilerGenerated]
	private string rOfgyOcb3CO;

	[CompilerGenerated]
	private readonly IDictionary<string, string> K2wgyFk79nu = new ConcurrentDictionary<string, string>();

	private static ActionState vViOV1QxHq1pld51auyT;

	public string ActionId
	{
		[CompilerGenerated]
		get
		{
			return pqKgyAGY8Fp;
		}
		[CompilerGenerated]
		set
		{
			pqKgyAGY8Fp = value;
		}
	}

	public string IconUrl
	{
		[CompilerGenerated]
		get
		{
			return rOfgyOcb3CO;
		}
		[CompilerGenerated]
		set
		{
			rOfgyOcb3CO = value;
		}
	}

	public IDictionary<string, string> States
	{
		[CompilerGenerated]
		get
		{
			return K2wgyFk79nu;
		}
	}

	internal static bool wTOGUkQxzRCkrrTA949Q()
	{
		return vViOV1QxHq1pld51auyT == null;
	}
}
