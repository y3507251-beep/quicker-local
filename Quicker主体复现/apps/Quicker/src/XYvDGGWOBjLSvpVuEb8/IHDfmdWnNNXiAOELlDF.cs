using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.WindowsAPICodePack.Dialogs;
using Quicker.Modules.TextTools;
using Quicker.Utilities;

namespace XYvDGGWOBjLSvpVuEb8;

internal class IHDfmdWnNNXiAOELlDF : BaseTextTool
{
	private static IHDfmdWnNNXiAOELlDF mvGXAqQXB0LT8KEtQvHL;

	public IHDfmdWnNNXiAOELlDF(TextToolContext textToolContext_1)
		: base(textToolContext_1)
	{
	}

	public override void OnMouseDown(object sender)
	{
		base.OnMouseDown(sender);
		AppHelper.RunOnUiThread(false, n45tSzvqiyy);
	}

	[CompilerGenerated]
	private void n45tSzvqiyy()
	{
		string allText = base.Context.TextControl.GetAllText();
		CommonOpenFileDialog commonOpenFileDialog = new CommonOpenFileDialog
		{
			IsFolderPicker = true,
			Title = "请选择文件夹"
		};
		if (Directory.Exists(allText))
		{
			commonOpenFileDialog.InitialDirectory = allText;
		}
		if (((base.Context.ParentWindow == null) ? commonOpenFileDialog.ShowDialog() : commonOpenFileDialog.ShowDialog(base.Context.ParentWindow)) == CommonFileDialogResult.Ok)
		{
			int num = 0;
			if (!h62xKDQXvLhqIECA8SrH())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			base.Context.ProcessSelectedTextFunc?.Invoke(commonOpenFileDialog.FileName, true);
		}
		else
		{
			CancelSelection("");
		}
	}

	internal static bool h62xKDQXvLhqIECA8SrH()
	{
		return mvGXAqQXB0LT8KEtQvHL == null;
	}
}
