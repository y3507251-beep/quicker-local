using System.Runtime.CompilerServices;
using Quicker.Utilities._3rd;

namespace Quicker.Domain.Messages;

public class RequestChangePageMessage : TinyMessageBase
{
	[CompilerGenerated]
	private bool DputevtlmwD;

	[CompilerGenerated]
	private bool xp7teS3dnPh;

	internal static RequestChangePageMessage BTda5SQv4RQrmFyrF3lL;

	public bool IsGlobal
	{
		[CompilerGenerated]
		get
		{
			return DputevtlmwD;
		}
		[CompilerGenerated]
		set
		{
			DputevtlmwD = value;
		}
	}

	public bool GoLeft
	{
		[CompilerGenerated]
		get
		{
			return xp7teS3dnPh;
		}
		[CompilerGenerated]
		set
		{
			xp7teS3dnPh = value;
		}
	}

	public RequestChangePageMessage(object sender, bool isGlobal, bool goLeft)
		: base(sender)
	{
		IsGlobal = isGlobal;
		GoLeft = goLeft;
	}

	internal static bool zN6wL2QvhFllXsnIraCV()
	{
		return BTda5SQv4RQrmFyrF3lL == null;
	}
}
