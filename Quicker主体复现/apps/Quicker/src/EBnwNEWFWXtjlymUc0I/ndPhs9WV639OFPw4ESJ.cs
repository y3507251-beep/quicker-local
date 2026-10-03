using System.Runtime.CompilerServices;
using Quicker.Common;
using Quicker.Domain;
using Quicker.Modules.TextTools;
using Quicker.Utilities;
using Quicker.View;

namespace EBnwNEWFWXtjlymUc0I;

internal class ndPhs9WV639OFPw4ESJ : BaseTextTool
{
	private readonly bool SJUtS3RZHPZ;

	private static ndPhs9WV639OFPw4ESJ Et10H2QXjwQJXDaFnP9o;

	public ndPhs9WV639OFPw4ESJ(TextToolContext textToolContext_1, bool bool_2)
		: base(textToolContext_1)
	{
		SJUtS3RZHPZ = bool_2;
	}

	public override void OnMouseDown(object sender)
	{
		base.OnMouseDown(sender);
		AppHelper.RunOnUiThread(false, KcItSiUBYxB);
	}

	[CompilerGenerated]
	private void KcItSiUBYxB()
	{
		SearchActionWindow searchActionWindow = new SearchActionWindow(AppState.DataService)
		{
			Owner = base.Context.ParentWindow
		};
		if (searchActionWindow.ShowDialog() == true)
		{
			ActionItem result = searchActionWindow.Result;
			base.Context.ProcessSelectedTextFunc?.Invoke(SJUtS3RZHPZ ? result.Id : result.Title, false);
		}
		else
		{
			CancelSelection("");
		}
	}

	internal static bool RGCJJbQXDOxZm5jV8xWF()
	{
		return Et10H2QXjwQJXDaFnP9o == null;
	}
}
