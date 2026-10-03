using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Quicker.Modules.BrowserControl.Message;

public class BrowserContextMenuItem
{
	public const string ROOT_MENU_ID = "QUICKER_ROOT_MENU_ID";

	public const string MENU_ID_DEV_TOOLS = "dev_tools";

	public const string MENU_ID_COPY_SELECTOR = "copy_selector";

	[CompilerGenerated]
	private string h8ZtyT1jWvH;

	[CompilerGenerated]
	private string Q9XtyMh6dp2;

	[CompilerGenerated]
	private string SZItyAO18Mb;

	[CompilerGenerated]
	private IList<string> EmKtyOeGVgY;

	[CompilerGenerated]
	private IList<string> kjstyFxCXfi;

	[CompilerGenerated]
	private IList<string> a7ktyUQtcBg;

	[CompilerGenerated]
	private static readonly BrowserContextMenuItem kBJtylTcN9N;

	internal static BrowserContextMenuItem DdJKwsQ3PsH0BYgjYCRQ;

	public string Title
	{
		[CompilerGenerated]
		get
		{
			return h8ZtyT1jWvH;
		}
		[CompilerGenerated]
		set
		{
			h8ZtyT1jWvH = value;
		}
	}

	public string Id
	{
		[CompilerGenerated]
		get
		{
			return Q9XtyMh6dp2;
		}
		[CompilerGenerated]
		set
		{
			Q9XtyMh6dp2 = value;
		}
	}

	public string ParentId
	{
		[CompilerGenerated]
		get
		{
			return SZItyAO18Mb;
		}
		[CompilerGenerated]
		set
		{
			SZItyAO18Mb = value;
		}
	}

	public IList<string> Contexts
	{
		[CompilerGenerated]
		get
		{
			return EmKtyOeGVgY;
		}
		[CompilerGenerated]
		set
		{
			EmKtyOeGVgY = value;
		}
	}

	public IList<string> DocumentUrlPatterns
	{
		[CompilerGenerated]
		get
		{
			return kjstyFxCXfi;
		}
		[CompilerGenerated]
		set
		{
			kjstyFxCXfi = value;
		}
	}

	public IList<string> TargetUrlPatterns
	{
		[CompilerGenerated]
		get
		{
			return a7ktyUQtcBg;
		}
		[CompilerGenerated]
		set
		{
			a7ktyUQtcBg = value;
		}
	}

	public static BrowserContextMenuItem RootItem
	{
		[CompilerGenerated]
		get
		{
			return kBJtylTcN9N;
		}
	}

	static BrowserContextMenuItem()
	{
		kBJtylTcN9N = new BrowserContextMenuItem
		{
			Id = "QUICKER_ROOT_MENU_ID",
			Title = "Quicker",
			Contexts = new string[1] { "all" }
		};
	}

	internal static bool Y0WkkaQ3M2oEleqDCixS()
	{
		return DdJKwsQ3PsH0BYgjYCRQ == null;
	}
}
