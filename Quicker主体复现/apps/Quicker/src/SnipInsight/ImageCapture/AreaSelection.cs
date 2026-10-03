using System;
using System.Drawing;
using System.Windows;
using jeaU1l2eVVj4W2gaVc;

namespace SnipInsight.ImageCapture;

public class AreaSelection
{
	private readonly SmartBoundaryDetection bBLgaKfCJT;

	private readonly ScreenProperties gnVg7wv7Ub;

	private IntPtr VSVgRop6DZ = IntPtr.Zero;

	private bool CVmgqshBhv;

	private System.Drawing.Point rAVgc8RZDP;

	private System.Drawing.Point MYCgVua1FR;

	private OO77uFW4jgnwuPwqBc.SX5yqVmkWqZQKeT9UhS AKFgZ7c6Vo;

	private static readonly int nEeg9NspRR;

	private static readonly int lONgh5JinB;

	private static AreaSelection kYukCMy32vhZZYgUmyi;

	public bool SelectingArea => CVmgqshBhv;

	public bool DraggingRight => MYCgVua1FR.X >= rAVgc8RZDP.X;

	public bool DraggingDown => MYCgVua1FR.Y >= rAVgc8RZDP.Y;

	public ScreenProperties ScreenProps => gnVg7wv7Ub;

	static AreaSelection()
	{
		int num = OO77uFW4jgnwuPwqBc.cIvt7If2Tl(92);
		nEeg9NspRR = OO77uFW4jgnwuPwqBc.cIvt7If2Tl(32) + num;
		lONgh5JinB = OO77uFW4jgnwuPwqBc.cIvt7If2Tl(33) + num;
	}

	public ScreenProperties.MonitorInformation GetMonitorInformation(IntPtr hMonitor)
	{
		return gnVg7wv7Ub.GetMonitorInformation(hMonitor);
	}

	public AreaSelection()
	{
		gnVg7wv7Ub = new ScreenProperties();
		bBLgaKfCJT = new SmartBoundaryDetection(gnVg7wv7Ub);
	}

	public void EndDragging()
	{
		CVmgqshBhv = false;
	}

	public void StartDragging(int x, int y)
	{
		CVmgqshBhv = true;
		rAVgc8RZDP = new System.Drawing.Point(x, y);
	}

	public void Dragging(int x, int y)
	{
		OO77uFW4jgnwuPwqBc.SX5yqVmkWqZQKeT9UhS sX5yqVmkWqZQKeT9UhS = default(OO77uFW4jgnwuPwqBc.SX5yqVmkWqZQKeT9UhS);
		MYCgVua1FR.X = x;
		MYCgVua1FR.Y = y;
		if (!CVmgqshBhv)
		{
			sX5yqVmkWqZQKeT9UhS = L7vgE4c59a(x, y);
			return;
		}
		sX5yqVmkWqZQKeT9UhS = DWVgysoB0H(x, y);
		if (!Cn8g8wCfUh(sX5yqVmkWqZQKeT9UhS))
		{
			int num = 0;
			if (!gPyE47yELoUWNyYKtOj())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			VSVgRop6DZ = IntPtr.Zero;
			AKFgZ7c6Vo = sX5yqVmkWqZQKeT9UhS;
		}
	}

	internal OO77uFW4jgnwuPwqBc.SX5yqVmkWqZQKeT9UhS at1gPIhG5L()
	{
		if (Cn8g8wCfUh(AKFgZ7c6Vo) && VSVgRop6DZ != IntPtr.Zero)
		{
			OO77uFW4jgnwuPwqBc.SX5yqVmkWqZQKeT9UhS sX5yqVmkWqZQKeT9UhS = bBLgaKfCJT.qMwLHK8lBi(VSVgRop6DZ);
			double num = 1.0;
			OO77uFW4jgnwuPwqBc.PiZtqwy1Fc(VSVgRop6DZ, out var t3dZJumhW7xBWeT4alb_);
			bool flag = t3dZJumhW7xBWeT4alb_.EfmvP0TsvWl == (OO77uFW4jgnwuPwqBc.z3M151mdRe2Fa0CZ5hr)3;
			IntPtr intPtr = bBLgaKfCJT.UusL1BGewe(VSVgRop6DZ);
			if (intPtr != IntPtr.Zero)
			{
				ScreenProperties.MonitorInformation monitorInformation = gnVg7wv7Ub.GetMonitorInformation(intPtr);
				OO77uFW4jgnwuPwqBc.SX5yqVmkWqZQKeT9UhS n8UvPpT0YnJ = monitorInformation.N8UvPpT0YnJ;
				double scalingFactor = monitorInformation.scalingFactor;
				double scalingFactor2 = gnVg7wv7Ub.GetMonitorInformation(IntPtr.Zero).scalingFactor;
				num = scalingFactor / scalingFactor2;
				if (flag || (sX5yqVmkWqZQKeT9UhS.XD7vPLOJ5hE == n8UvPpT0YnJ.XD7vPLOJ5hE && sX5yqVmkWqZQKeT9UhS.wTivPvfjMFS == n8UvPpT0YnJ.wTivPvfjMFS && sX5yqVmkWqZQKeT9UhS.width == n8UvPpT0YnJ.DhUvPSLdZXQ - n8UvPpT0YnJ.XD7vPLOJ5hE && sX5yqVmkWqZQKeT9UhS.height == n8UvPpT0YnJ.dPwvP2kZV1u - n8UvPpT0YnJ.wTivPvfjMFS))
				{
					return new OO77uFW4jgnwuPwqBc.SX5yqVmkWqZQKeT9UhS
					{
						XD7vPLOJ5hE = (int)((double)n8UvPpT0YnJ.XD7vPLOJ5hE * num),
						DhUvPSLdZXQ = (int)((double)n8UvPpT0YnJ.DhUvPSLdZXQ * num),
						wTivPvfjMFS = (int)((double)n8UvPpT0YnJ.wTivPvfjMFS * num),
						dPwvP2kZV1u = (int)((double)n8UvPpT0YnJ.dPwvP2kZV1u * num)
					};
				}
			}
			OO77uFW4jgnwuPwqBc.dhktEuIdPr(VSVgRop6DZ, out var sx5yqVmkWqZQKeT9UhS_);
			Thickness thickness = new Thickness(Math.Min(Math.Max(nEeg9NspRR - 1, 0), (sX5yqVmkWqZQKeT9UhS.width - (sx5yqVmkWqZQKeT9UhS_.DhUvPSLdZXQ - sx5yqVmkWqZQKeT9UhS_.XD7vPLOJ5hE)) / 2), 0.0, Math.Min(Math.Max(nEeg9NspRR - 1, 0), (sX5yqVmkWqZQKeT9UhS.width - (sx5yqVmkWqZQKeT9UhS_.DhUvPSLdZXQ - sx5yqVmkWqZQKeT9UhS_.XD7vPLOJ5hE)) / 2), Math.Min(Math.Max(lONgh5JinB - 1, 0), sX5yqVmkWqZQKeT9UhS.height - (sx5yqVmkWqZQKeT9UhS_.dPwvP2kZV1u - sx5yqVmkWqZQKeT9UhS_.wTivPvfjMFS)));
			OO77uFW4jgnwuPwqBc.SX5yqVmkWqZQKeT9UhS result = default(OO77uFW4jgnwuPwqBc.SX5yqVmkWqZQKeT9UhS);
			int num2 = 1;
			if (kYukCMy32vhZZYgUmyi != null)
			{
				int num3 = default(int);
				num2 = num3;
			}
			do
			{
				switch (num2)
				{
				case 1:
					goto IL_0223;
				}
				break;
				IL_0223:
				result.XD7vPLOJ5hE = (int)(((double)sX5yqVmkWqZQKeT9UhS.XD7vPLOJ5hE + thickness.Left) * num);
				result.DhUvPSLdZXQ = (int)(((double)sX5yqVmkWqZQKeT9UhS.DhUvPSLdZXQ - thickness.Right) * num);
				num2 = 0;
			}
			while (gPyE47yELoUWNyYKtOj());
			result.wTivPvfjMFS = (int)(((double)sX5yqVmkWqZQKeT9UhS.wTivPvfjMFS + thickness.Top) * num);
			result.dPwvP2kZV1u = (int)(((double)sX5yqVmkWqZQKeT9UhS.dPwvP2kZV1u - thickness.Bottom) * num);
			return result;
		}
		return AKFgZ7c6Vo;
	}

	private OO77uFW4jgnwuPwqBc.SX5yqVmkWqZQKeT9UhS L7vgE4c59a(int int_2, int int_3)
	{
		VSVgRop6DZ = bBLgaKfCJT.GetTopElement(int_2, int_3);
		if (VSVgRop6DZ != IntPtr.Zero)
		{
			return bBLgaKfCJT.qMwLHK8lBi(VSVgRop6DZ);
		}
		return default(OO77uFW4jgnwuPwqBc.SX5yqVmkWqZQKeT9UhS);
	}

	private OO77uFW4jgnwuPwqBc.SX5yqVmkWqZQKeT9UhS DWVgysoB0H(int int_2, int int_3)
	{
		OO77uFW4jgnwuPwqBc.SX5yqVmkWqZQKeT9UhS result = default(OO77uFW4jgnwuPwqBc.SX5yqVmkWqZQKeT9UhS);
		if (int_2 < rAVgc8RZDP.X)
		{
			result.XD7vPLOJ5hE = int_2;
			result.DhUvPSLdZXQ = rAVgc8RZDP.X;
		}
		else
		{
			result.XD7vPLOJ5hE = rAVgc8RZDP.X;
			result.DhUvPSLdZXQ = int_2;
		}
		if (int_3 < rAVgc8RZDP.Y)
		{
			result.wTivPvfjMFS = int_3;
			result.dPwvP2kZV1u = rAVgc8RZDP.Y;
		}
		else
		{
			result.wTivPvfjMFS = rAVgc8RZDP.Y;
			result.dPwvP2kZV1u = int_3;
		}
		return result;
	}

	private static bool Cn8g8wCfUh(OO77uFW4jgnwuPwqBc.SX5yqVmkWqZQKeT9UhS sx5yqVmkWqZQKeT9UhS_1)
	{
		int num = sx5yqVmkWqZQKeT9UhS_1.DhUvPSLdZXQ - sx5yqVmkWqZQKeT9UhS_1.XD7vPLOJ5hE;
		int num2 = sx5yqVmkWqZQKeT9UhS_1.dPwvP2kZV1u - sx5yqVmkWqZQKeT9UhS_1.wTivPvfjMFS;
		if (num > 10 && num2 > 10)
		{
			return false;
		}
		return true;
	}

	internal static bool gPyE47yELoUWNyYKtOj()
	{
		return kYukCMy32vhZZYgUmyi == null;
	}
}
