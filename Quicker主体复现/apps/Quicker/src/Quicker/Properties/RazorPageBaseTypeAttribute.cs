using System;
using System.Runtime.CompilerServices;

namespace Quicker.Properties;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public sealed class RazorPageBaseTypeAttribute : Attribute
{
	[CompilerGenerated]
	private string dHVbpglY4I;

	[CompilerGenerated]
	private string keEbBKbjNJ;

	private static RazorPageBaseTypeAttribute qog1t2RLhlUyX2v9iA0;

	[NotNull]
	public string BaseType
	{
		[CompilerGenerated]
		get
		{
			return dHVbpglY4I;
		}
		[CompilerGenerated]
		private set
		{
			dHVbpglY4I = value;
		}
	}

	[CanBeNull]
	public string PageName
	{
		[CompilerGenerated]
		get
		{
			return keEbBKbjNJ;
		}
		[CompilerGenerated]
		private set
		{
			keEbBKbjNJ = value;
		}
	}

	public RazorPageBaseTypeAttribute([NotNull] string baseType)
	{
		BaseType = baseType;
	}

	public RazorPageBaseTypeAttribute([NotNull] string baseType, string pageName)
	{
		BaseType = baseType;
		PageName = pageName;
	}

	internal static void Bhfk73RfZWRsdmXXxBc()
	{
	}

	internal static bool S7OYD6RusZD8WpWBgQv()
	{
		return qog1t2RLhlUyX2v9iA0 == null;
	}
}
