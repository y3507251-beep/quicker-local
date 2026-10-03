using System.Runtime.CompilerServices;
using Quicker.Annotations;

namespace Quicker.Modules.TextTools;

public class TextToolsContextHint
{
	[CompilerGenerated]
	private string zuttv7aQI14;

	[CompilerGenerated]
	private bool rpxtvRKVvEQ;

	internal static TextToolsContextHint JIE6OkQybXFflgpSZc7I;

	public string FileDialogFilter
	{
		[CompilerGenerated]
		get
		{
			return zuttv7aQI14;
		}
		[CompilerGenerated]
		set
		{
			zuttv7aQI14 = value;
		}
	}

	public bool OperationItemOnlyData
	{
		[CompilerGenerated]
		get
		{
			return rpxtvRKVvEQ;
		}
		[CompilerGenerated]
		set
		{
			rpxtvRKVvEQ = value;
		}
	}

	public void ApplyToContext([NotNull] TextToolContext context)
	{
		context.FileDialogFilter = FileDialogFilter;
		context.OperationItem_OnlyData = OperationItemOnlyData;
	}

	internal static bool kka6SDQyq5STIX41tdQk()
	{
		return JIE6OkQybXFflgpSZc7I == null;
	}
}
