using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Quicker.Utilities.UI;

public class PopupState
{
	private readonly IDictionary<MouseButtons, ButtonState> FM9v2EO8TMy = new Dictionary<MouseButtons, ButtonState>
	{
		{
			MouseButtons.Left,
			new ButtonState()
		},
		{
			MouseButtons.Right,
			new ButtonState()
		},
		{
			MouseButtons.Middle,
			new ButtonState()
		},
		{
			MouseButtons.XButton1,
			new ButtonState()
		},
		{
			MouseButtons.XButton2,
			new ButtonState()
		}
	};

	[CompilerGenerated]
	private bool hIpv2yDt4a6;

	[CompilerGenerated]
	private bool QMhv28rhVe8 = true;

	[CompilerGenerated]
	private PointTargetInfo WaLv2aOHSfR;

	internal static PopupState rGihDiFhzDrWJutaIaHY;

	public bool IsRightMoveProcessed
	{
		[CompilerGenerated]
		get
		{
			return hIpv2yDt4a6;
		}
		[CompilerGenerated]
		set
		{
			hIpv2yDt4a6 = value;
		}
	}

	public bool IsEnabled
	{
		[CompilerGenerated]
		get
		{
			return QMhv28rhVe8;
		}
		[CompilerGenerated]
		set
		{
			QMhv28rhVe8 = value;
		}
	}

	public PointTargetInfo MouseDownTargetInfo
	{
		[CompilerGenerated]
		get
		{
			return WaLv2aOHSfR;
		}
		[CompilerGenerated]
		set
		{
			WaLv2aOHSfR = value;
		}
	}

	public void Reset()
	{
		IsRightMoveProcessed = false;
	}

	public void MouseDownOnPanel(MouseButtons button)
	{
		if (FM9v2EO8TMy.ContainsKey(button))
		{
			FM9v2EO8TMy[button].IsDownOnPanel = true;
		}
	}

	public void CaptureMouseButtonDown(MouseButtons button)
	{
		if (FM9v2EO8TMy.ContainsKey(button))
		{
			FM9v2EO8TMy[button].IsMouseDownCaptured = true;
		}
	}

	public void ResetButton(MouseButtons button)
	{
		if (FM9v2EO8TMy.ContainsKey(button))
		{
			FM9v2EO8TMy[button].Reset();
		}
	}

	public bool IsMouseDownCaptured(MouseButtons button)
	{
		if (!FM9v2EO8TMy.ContainsKey(button))
		{
			return false;
		}
		return FM9v2EO8TMy[button].IsMouseDownCaptured;
	}

	internal static bool CwmdocFHVUpwqpJXMaqi()
	{
		return rGihDiFhzDrWJutaIaHY == null;
	}
}
