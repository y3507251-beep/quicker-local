using System.Runtime.CompilerServices;
using System.Windows;
using Quicker.Modules.TextTools;
using Quicker.Utilities;
using Quicker.View;

namespace dNlgvVW0FNl4oBCu3WH;

internal class jjsR3GWE5fePJDxKq3r : BaseTextTool
{
	private static jjsR3GWE5fePJDxKq3r MUIqQ3QXrmhccsruVI1C;

	public jjsR3GWE5fePJDxKq3r(TextToolContext textToolContext_1)
		: base(textToolContext_1)
	{
	}

	public override void OnMouseDown(object sender)
	{
		base.OnMouseDown(sender);
		AppHelper.RunOnUiThread(false, jl8t2timqjg);
	}

	[CompilerGenerated]
	private void jl8t2timqjg()
	{
		FaIconSelectorWindow faIconSelectorWindow = new FaIconSelectorWindow
		{
			Owner = base.Context.ParentWindow
		};
		faIconSelectorWindow.ShowActivated = true;
		if (faIconSelectorWindow.Owner != null)
		{
			if (oBXxS6QXNv1q5ERrpy2L())
			{
				switch (0)
				{
				}
			}
			if (faIconSelectorWindow.Owner.IsVisible)
			{
				goto IL_0052;
			}
		}
		faIconSelectorWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
		goto IL_0052;
		IL_0052:
		if (faIconSelectorWindow.ShowDialog() == true)
		{
			base.Context?.ProcessSelectedTextFunc("fa:" + faIconSelectorWindow.SelectedIcon, false);
		}
		else
		{
			CancelSelection("");
		}
	}

	internal static bool oBXxS6QXNv1q5ERrpy2L()
	{
		return MUIqQ3QXrmhccsruVI1C == null;
	}
}
