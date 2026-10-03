using System.Runtime.CompilerServices;

namespace Quicker.Utilities.UI;

public class ButtonState
{
	private bool uCvv27IgxFS;

	[CompilerGenerated]
	private bool s3Ov2R55MTy;

	[CompilerGenerated]
	private MouseButtonStateValue noMv2q8jZka;

	private static ButtonState xATpf6FHcE3Qhjb5QrXp;

	public bool IsDownOnPanel
	{
		[CompilerGenerated]
		get
		{
			return s3Ov2R55MTy;
		}
		[CompilerGenerated]
		set
		{
			s3Ov2R55MTy = value;
		}
	}

	public bool IsMouseDownCaptured
	{
		get
		{
			return uCvv27IgxFS;
		}
		set
		{
			uCvv27IgxFS = value;
		}
	}

	public MouseButtonStateValue State
	{
		[CompilerGenerated]
		get
		{
			return noMv2q8jZka;
		}
		[CompilerGenerated]
		set
		{
			noMv2q8jZka = value;
		}
	}

	public void Reset()
	{
		IsMouseDownCaptured = false;
		State = MouseButtonStateValue.MouseUp;
		IsDownOnPanel = false;
	}

	internal static bool H3WQNPFHWGfiG8bYgju7()
	{
		return xATpf6FHcE3Qhjb5QrXp == null;
	}

	internal static void y8EsFcFHpUNjYBIWrSAM()
	{
	}
}
