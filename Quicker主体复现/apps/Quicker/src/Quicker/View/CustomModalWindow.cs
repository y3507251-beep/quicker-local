using System.Runtime.CompilerServices;
using System.Windows;

namespace Quicker.View;

public class CustomModalWindow : Window
{
	[CompilerGenerated]
	private bool ItagQB8QyeJ;

	internal static CustomModalWindow HDQ47dQzfEAiTTGX08Rg;

	public bool IsSuccess
	{
		[CompilerGenerated]
		get
		{
			return ItagQB8QyeJ;
		}
		[CompilerGenerated]
		protected set
		{
			ItagQB8QyeJ = value;
		}
	}

	public void SetResultAndClose(bool isSuccess)
	{
		IsSuccess = isSuccess;
		Close();
	}

	internal static bool wwiIv2QzbjHysIpQgl9s()
	{
		return HDQ47dQzfEAiTTGX08Rg == null;
	}
}
