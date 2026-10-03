using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace LPAgent.Domain;

public class Command
{
	public const string CadSendCommand = "cad:sendcommand";

	public const string CadReadVariable = "cad:readvaraible";

	public const string RhinoRunScript = "rhino:runscript";

	public const string CSharpExec = "csharp:exec";

	public const string PsDoJavaScript = "dojavascript";

	public const string PsDoJavaScriptFile = "dojavascriptfile";

	public const string Runner_Cad = "cad";

	public const string Runner_Rhino = "rhino";

	public const string Runner_CSharp = "csharp";

	public const string Runner_Adobe = "adobe";

	public const string Runner_Office = "office";

	public const string Office_Op_ExecVbaCode = "exec_vba_code";

	public const string Office_Op_SetFormats = "set_formats";

	public const string Office_Op_MsoCmd = "mso";

	[CompilerGenerated]
	private string w5uWfOsHWe;

	[CompilerGenerated]
	private string U0bWz3B3ld;

	[CompilerGenerated]
	private string Di0kwRly6w;

	[CompilerGenerated]
	private string Jw1ktlFjm3;

	[CompilerGenerated]
	private int MHHkgf0MSt;

	[CompilerGenerated]
	private bool w2ukLf6rlC;

	[CompilerGenerated]
	private int wKVkvSPMJo = 10000;

	[CompilerGenerated]
	private string us8kSkMgfp;

	[CompilerGenerated]
	private IDictionary<string, string> lJYk2QrO6k;

	internal static Command zE4YTvbtUajlk58XYYr;

	[Obsolete("使用Runner、Operation")]
	public string Id
	{
		[CompilerGenerated]
		get
		{
			return w5uWfOsHWe;
		}
		[CompilerGenerated]
		set
		{
			w5uWfOsHWe = value;
		}
	}

	public string Runner
	{
		[CompilerGenerated]
		get
		{
			return U0bWz3B3ld;
		}
		[CompilerGenerated]
		set
		{
			U0bWz3B3ld = value;
		}
	}

	public string SubTarget
	{
		[CompilerGenerated]
		get
		{
			return Di0kwRly6w;
		}
		[CompilerGenerated]
		set
		{
			Di0kwRly6w = value;
		}
	}

	public string Operation
	{
		[CompilerGenerated]
		get
		{
			return Jw1ktlFjm3;
		}
		[CompilerGenerated]
		set
		{
			Jw1ktlFjm3 = value;
		}
	}

	public int Serial
	{
		[CompilerGenerated]
		get
		{
			return MHHkgf0MSt;
		}
		[CompilerGenerated]
		set
		{
			MHHkgf0MSt = value;
		}
	}

	public bool WaitResp
	{
		[CompilerGenerated]
		get
		{
			return w2ukLf6rlC;
		}
		[CompilerGenerated]
		set
		{
			w2ukLf6rlC = value;
		}
	}

	public int MaxWaitMs
	{
		[CompilerGenerated]
		get
		{
			return wKVkvSPMJo;
		}
		[CompilerGenerated]
		set
		{
			wKVkvSPMJo = value;
		}
	}

	public string Data
	{
		[CompilerGenerated]
		get
		{
			return us8kSkMgfp;
		}
		[CompilerGenerated]
		set
		{
			us8kSkMgfp = value;
		}
	}

	public IDictionary<string, string> Params
	{
		[CompilerGenerated]
		get
		{
			return lJYk2QrO6k;
		}
		[CompilerGenerated]
		set
		{
			lJYk2QrO6k = value;
		}
	}

	internal static bool iCkfiobSQJOYnlnyiao()
	{
		return zE4YTvbtUajlk58XYYr == null;
	}

	internal static void D1IQW7bTT58LAAuC0P0()
	{
	}
}
