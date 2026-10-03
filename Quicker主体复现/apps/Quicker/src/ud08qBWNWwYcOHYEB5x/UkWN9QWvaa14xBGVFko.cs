using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.Win32;
using Quicker.Modules.TextTools;
using Quicker.Utilities;

namespace ud08qBWNWwYcOHYEB5x;

internal class UkWN9QWvaa14xBGVFko : BaseTextTool
{
	private static UkWN9QWvaa14xBGVFko Q1eag9QXGq8Kd7u82pIO;

	public UkWN9QWvaa14xBGVFko(TextToolContext textToolContext_1)
		: base(textToolContext_1)
	{
	}

	public override void OnMouseDown(object sender)
	{
		base.OnMouseDown(sender);
		AppHelper.RunOnUiThread(false, R32tSfWW6po);
	}

	[CompilerGenerated]
	private void R32tSfWW6po()
	{
		SaveFileDialog saveFileDialog = new SaveFileDialog
		{
			Filter = base.Context.FileDialogFilter,
			Title = "选择保存路径"
		};
		try
		{
			string allText = base.Context.TextControl.GetAllText();
			if (File.Exists(allText.Trim()) && Directory.Exists(Path.GetDirectoryName(allText.Trim())))
			{
				saveFileDialog.InitialDirectory = Path.GetDirectoryName(allText.Trim());
			}
		}
		catch
		{
		}
		if (((base.Context.ParentWindow == null) ? saveFileDialog.ShowDialog() : saveFileDialog.ShowDialog(base.Context.ParentWindow)) == true)
		{
			base.Context.ProcessSelectedTextFunc?.Invoke(saveFileDialog.FileName, true);
			return;
		}
		CancelSelection("");
		int num = 0;
		if (Q1eag9QXGq8Kd7u82pIO != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
	}

	internal static bool tNg3BcQX008QqLO2YqFY()
	{
		return Q1eag9QXGq8Kd7u82pIO == null;
	}
}
