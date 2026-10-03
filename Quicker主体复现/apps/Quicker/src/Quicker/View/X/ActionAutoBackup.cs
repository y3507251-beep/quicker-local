using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using log4net;
using Quicker.Common;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Win32;

namespace Quicker.View.X;

public class ActionAutoBackup
{
	private static readonly ILog Uy6Lhr68CTA;

	[CompilerGenerated]
	private string D6XLhpXuR1b;

	[CompilerGenerated]
	private bool HnrLhBHdrap;

	internal static ActionAutoBackup ffeexRFOAGjTLlrJdPN5;

	public bool IsReady
	{
		[CompilerGenerated]
		get
		{
			return HnrLhBHdrap;
		}
		[CompilerGenerated]
		set
		{
			HnrLhBHdrap = value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private string VdaLhmQyuGG()
	{
		return D6XLhpXuR1b;
	}

	[SpecialName]
	[CompilerGenerated]
	private void MsxLhKnJuSy(string value)
	{
		D6XLhpXuR1b = value;
	}

	public ActionAutoBackup(ActionItem editingAction)
	{
		string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Quicker", "_actionBackups", DateTime.Now.ToString("yyyy"), DateTime.Now.ToString("MM"), DateTime.Now.ToString("dd"));
		string text = PathHelper.RemoveInvalidCharsFromFileName(editingAction?.Title?.Trim());
		MsxLhKnJuSy(Path.Combine(path, (string.IsNullOrEmpty(text) ? "未命名动作" : text) + "_" + DateTime.Now.ToString("HHmmss")));
	}

	public static string GetBackupFolder()
	{
		return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Quicker", "_actionBackups");
	}

	public void Save(string data, string prefix = "")
	{
		try
		{
			if (!Directory.Exists(VdaLhmQyuGG()))
			{
				Directory.CreateDirectory(VdaLhmQyuGG());
			}
			IsReady = true;
		}
		catch (Exception exception)
		{
			string message = "创建动作备份目录出错：" + exception.GetMessageWithInner();
			Uy6Lhr68CTA.Warn(message, exception);
			AppHelper.ShowWarning(message);
			return;
		}
		if (IsReady)
		{
			File.WriteAllText(Path.Combine(VdaLhmQyuGG(), prefix + DateTime.Now.ToString("HHmmss") + ".qka"), data);
		}
	}

	static ActionAutoBackup()
	{
		Uy6Lhr68CTA = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool I9v8j0FOnFbkfhiXUvHX()
	{
		return ffeexRFOAGjTLlrJdPN5 == null;
	}
}
