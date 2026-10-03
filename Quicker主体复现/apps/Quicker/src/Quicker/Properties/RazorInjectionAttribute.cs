using System;
using System.Runtime.CompilerServices;

namespace Quicker.Properties;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public sealed class RazorInjectionAttribute : Attribute
{
	[CompilerGenerated]
	private string sWdb6qvVX4;

	[CompilerGenerated]
	private string aXlbXFB2Si;

	internal static RazorInjectionAttribute MmcOPaRJqFj1CLwL1Zd;

	[NotNull]
	public string Type
	{
		[CompilerGenerated]
		get
		{
			return sWdb6qvVX4;
		}
		[CompilerGenerated]
		private set
		{
			sWdb6qvVX4 = value;
		}
	}

	[NotNull]
	public string FieldName
	{
		[CompilerGenerated]
		get
		{
			return aXlbXFB2Si;
		}
		[CompilerGenerated]
		private set
		{
			aXlbXFB2Si = value;
		}
	}

	public RazorInjectionAttribute([NotNull] string type, [NotNull] string fieldName)
	{
		Type = type;
		FieldName = fieldName;
	}

	internal static bool F0kX7vRkBwCUmGwkbpF()
	{
		return MmcOPaRJqFj1CLwL1Zd == null;
	}
}
