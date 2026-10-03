using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace Quicker.Utilities.UI;

public class PointTargetInfo
{
	[CompilerGenerated]
	private Point Nghv2OpO9lO;

	[CompilerGenerated]
	private IntPtr UMJv2F6sU1Y;

	[CompilerGenerated]
	private uint jMpv2URu648;

	[CompilerGenerated]
	private string sYGv2l7ytfk = "";

	[CompilerGenerated]
	private string XJov2iVRNpo;

	[CompilerGenerated]
	private bool aqRv23G4kwi;

	[CompilerGenerated]
	private bool BUov2fbvqyx;

	[CompilerGenerated]
	private bool KuLv2zOp6VR;

	[CompilerGenerated]
	private bool yK6vuwxumA7;

	[CompilerGenerated]
	private bool tSNvut880J9;

	[CompilerGenerated]
	private bool wRFvug025qc;

	[CompilerGenerated]
	private bool njYvuLIcCiU;

	private static PointTargetInfo ESLo4yFH47RSrsA29mZb;

	public Point Point
	{
		[CompilerGenerated]
		get
		{
			return Nghv2OpO9lO;
		}
		[CompilerGenerated]
		set
		{
			Nghv2OpO9lO = value;
		}
	}

	public IntPtr HWnd
	{
		[CompilerGenerated]
		get
		{
			return UMJv2F6sU1Y;
		}
		[CompilerGenerated]
		set
		{
			UMJv2F6sU1Y = value;
		}
	}

	public uint Pid
	{
		[CompilerGenerated]
		get
		{
			return jMpv2URu648;
		}
		[CompilerGenerated]
		set
		{
			jMpv2URu648 = value;
		}
	}

	public string Exe
	{
		[CompilerGenerated]
		get
		{
			return sYGv2l7ytfk;
		}
		[CompilerGenerated]
		set
		{
			sYGv2l7ytfk = value;
		}
	}

	public string ExePath
	{
		[CompilerGenerated]
		get
		{
			return XJov2iVRNpo;
		}
		[CompilerGenerated]
		set
		{
			XJov2iVRNpo = value;
		}
	}

	public bool IsOnQuicker
	{
		[CompilerGenerated]
		get
		{
			return aqRv23G4kwi;
		}
		[CompilerGenerated]
		set
		{
			aqRv23G4kwi = value;
		}
	}

	public bool IsOnMainWindow
	{
		[CompilerGenerated]
		get
		{
			return BUov2fbvqyx;
		}
		[CompilerGenerated]
		set
		{
			BUov2fbvqyx = value;
		}
	}

	public bool IsOnImageViewer
	{
		[CompilerGenerated]
		get
		{
			return KuLv2zOp6VR;
		}
		[CompilerGenerated]
		set
		{
			KuLv2zOp6VR = value;
		}
	}

	public bool IsOnNonTriggerWindow
	{
		[CompilerGenerated]
		get
		{
			return yK6vuwxumA7;
		}
		[CompilerGenerated]
		set
		{
			yK6vuwxumA7 = value;
		}
	}

	public bool IsInBlackList
	{
		[CompilerGenerated]
		get
		{
			return tSNvut880J9;
		}
		[CompilerGenerated]
		set
		{
			tSNvut880J9 = value;
		}
	}

	public bool IsDisabledFullScreenWindow
	{
		[CompilerGenerated]
		get
		{
			return wRFvug025qc;
		}
		[CompilerGenerated]
		set
		{
			wRFvug025qc = value;
		}
	}

	public bool IsFullscreenWindow
	{
		[CompilerGenerated]
		get
		{
			return njYvuLIcCiU;
		}
		[CompilerGenerated]
		set
		{
			njYvuLIcCiU = value;
		}
	}

	public bool CanTrigger(PopupSource source)
	{
		switch (source)
		{
		case PopupSource.Keyboard:
			return !IsDisabledFullScreenWindow;
		case PopupSource.Mouse:
			if (!IsOnNonTriggerWindow && !IsInBlackList)
			{
				return !IsDisabledFullScreenWindow;
			}
			return false;
		default:
			if (!IsOnNonTriggerWindow)
			{
				return !IsInBlackList;
			}
			return false;
		}
	}

	static PointTargetInfo()
	{
	}

	internal static void yX7cgoFHzNIJncrM3WZx()
	{
	}

	internal static bool jA3AjsFHh4WkKXbegnJb()
	{
		return ESLo4yFH47RSrsA29mZb == null;
	}

	internal static void z9t1fhFzVD8vlrVYZPp3()
	{
	}
}
