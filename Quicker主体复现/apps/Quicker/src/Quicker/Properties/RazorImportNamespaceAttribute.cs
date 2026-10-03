using System;
using System.Runtime.CompilerServices;

namespace Quicker.Properties;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public sealed class RazorImportNamespaceAttribute : Attribute
{
	[CompilerGenerated]
	private string GsLbHK5191;

	internal static RazorImportNamespaceAttribute wDCrtARvnAK79DnKP7P;

	[NotNull]
	public string Name
	{
		[CompilerGenerated]
		get
		{
			return GsLbHK5191;
		}
		[CompilerGenerated]
		private set
		{
			GsLbHK5191 = value;
		}
	}

	public RazorImportNamespaceAttribute([NotNull] string name)
	{
		Name = name;
	}

	internal static bool HeWi6pRd62ZUkcKkIsc()
	{
		return wDCrtARvnAK79DnKP7P == null;
	}
}
