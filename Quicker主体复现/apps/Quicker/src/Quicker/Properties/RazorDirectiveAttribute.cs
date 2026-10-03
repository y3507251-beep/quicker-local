using System;
using System.Runtime.CompilerServices;

namespace Quicker.Properties;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public sealed class RazorDirectiveAttribute : Attribute
{
	[CompilerGenerated]
	private string KAubKiig0d;

	internal static RazorDirectiveAttribute MXbJPbRr0XfF28bMdl8;

	[NotNull]
	public string Directive
	{
		[CompilerGenerated]
		get
		{
			return KAubKiig0d;
		}
		[CompilerGenerated]
		private set
		{
			KAubKiig0d = value;
		}
	}

	public RazorDirectiveAttribute([NotNull] string directive)
	{
		Directive = directive;
	}

	internal static bool FMmXRQRNkU1fRHtch7F()
	{
		return MXbJPbRr0XfF28bMdl8 == null;
	}
}
