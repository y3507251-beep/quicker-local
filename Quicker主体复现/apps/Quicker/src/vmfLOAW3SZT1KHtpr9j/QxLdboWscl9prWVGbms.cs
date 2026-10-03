using System.IO;
using Microsoft.Win32;
using Quicker.Modules.TextTools;
using Quicker.Public.Extensions;
using Quicker.Utilities.Ext;

namespace vmfLOAW3SZT1KHtpr9j;

internal class QxLdboWscl9prWVGbms : BaseTextTool
{
	private readonly bool TlTt2wfWvuG;

	private static QxLdboWscl9prWVGbms uNG5kHQXJM8hBcW0kmZF;

	public QxLdboWscl9prWVGbms(TextToolContext textToolContext_1, bool bool_2)
		: base(textToolContext_1)
	{
		TlTt2wfWvuG = bool_2;
	}

	public override void OnMouseDown(object sender)
	{
		base.OnMouseDown(sender);
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = base.Context.FileDialogFilter;
		if (uNG5kHQXJM8hBcW0kmZF == null)
		{
			switch (0)
			{
			}
		}
		openFileDialog.Multiselect = TlTt2wfWvuG;
		try
		{
			string text = base.Context.TextControl.GetAllText();
			if (TlTt2wfWvuG)
			{
				text = text.GetLastLine();
			}
			if (File.Exists(text.Trim()) && Directory.Exists(Path.GetDirectoryName(text.Trim())))
			{
				openFileDialog.InitialDirectory = Path.GetDirectoryName(text.Trim());
			}
		}
		catch
		{
		}
		if (((base.Context.ParentWindow == null) ? openFileDialog.ShowDialog() : openFileDialog.ShowDialog(base.Context.ParentWindow)) == true)
		{
			if (TlTt2wfWvuG)
			{
				base.Context.ProcessSelectedTextFunc?.Invoke(openFileDialog.FileNames.JoinToString(), true);
			}
			else
			{
				base.Context.ProcessSelectedTextFunc?.Invoke(openFileDialog.FileName, true);
			}
		}
		else
		{
			CancelSelection("");
		}
	}

	internal static bool mnkGK2QXkQmf7393vZNy()
	{
		return uNG5kHQXJM8hBcW0kmZF == null;
	}
}
