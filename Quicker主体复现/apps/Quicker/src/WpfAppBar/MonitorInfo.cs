using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using IPX7yRZnyyrui5B9FZ;

namespace WpfAppBar;

public sealed class MonitorInfo : IEquatable<MonitorInfo>
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass13_0
	{
		public List<MonitorInfo> X06vEskL5tt;

		private static _003C_003Ec__DisplayClass13_0 GCGVUdcjdQ85d448qhsF;

		internal bool Xd7vEGHNEBo(IntPtr hMonitor, IntPtr hdcMonitor, ref qalNllR8qMeP2UbUj1.nPsPMemzmBfsakHs52Q lprcMonitor, IntPtr dwData)
		{
			qalNllR8qMeP2UbUj1.rcNLaJdWJ4UNxK2tSfY rcNLaJdWJ4UNxK2tSfY_ = new qalNllR8qMeP2UbUj1.rcNLaJdWJ4UNxK2tSfY
			{
				u62vEO3GbHG = Marshal.SizeOf(typeof(qalNllR8qMeP2UbUj1.rcNLaJdWJ4UNxK2tSfY))
			};
			if (!qalNllR8qMeP2UbUj1.V5xJeshOyy(hMonitor, ref rcNLaJdWJ4UNxK2tSfY_))
			{
				throw new Win32Exception();
			}
			X06vEskL5tt.Add(new MonitorInfo(rcNLaJdWJ4UNxK2tSfY_));
			return true;
		}

		internal static bool vVZ0ZbcjOmuLlMiYR8LT()
		{
			return GCGVUdcjdQ85d448qhsF == null;
		}
	}

	[CompilerGenerated]
	private readonly Rect FWmJCd32mI;

	[CompilerGenerated]
	private readonly Rect tYQJPkPIvv;

	[CompilerGenerated]
	private readonly bool dOHJEXrHe9;

	[CompilerGenerated]
	private readonly string iwUJyR4boU;

	internal static MonitorInfo QvHv763EVrxvvdRDhCO;

	public Rect ViewportBounds
	{
		[CompilerGenerated]
		get
		{
			return FWmJCd32mI;
		}
	}

	public Rect WorkAreaBounds
	{
		[CompilerGenerated]
		get
		{
			return tYQJPkPIvv;
		}
	}

	public bool IsPrimary
	{
		[CompilerGenerated]
		get
		{
			return dOHJEXrHe9;
		}
	}

	public string DeviceId
	{
		[CompilerGenerated]
		get
		{
			return iwUJyR4boU;
		}
	}

	internal MonitorInfo(qalNllR8qMeP2UbUj1.rcNLaJdWJ4UNxK2tSfY mex)
	{
		FWmJCd32mI = (Rect)mex.eRevEF8oPlk;
		tYQJPkPIvv = (Rect)mex.MCKvEUbEObK;
		dOHJEXrHe9 = mex.iTQvEl4v8Mu.HasFlag((qalNllR8qMeP2UbUj1.MJASfDdAHSTfRd8b6o3)1);
		iwUJyR4boU = mex.CcPvEiuGi5L;
	}

	public static IEnumerable<MonitorInfo> GetAllMonitors()
	{
		_003C_003Ec__DisplayClass13_0 _003C_003Ec__DisplayClass13_ = new _003C_003Ec__DisplayClass13_0();
		_003C_003Ec__DisplayClass13_.X06vEskL5tt = new List<MonitorInfo>();
		qalNllR8qMeP2UbUj1.arURA5d21f8GXfeZaWi arURA5d21f8GXfeZaWi_ = _003C_003Ec__DisplayClass13_.Xd7vEGHNEBo;
		qalNllR8qMeP2UbUj1.AOmJYk1HKF(IntPtr.Zero, IntPtr.Zero, arURA5d21f8GXfeZaWi_, IntPtr.Zero);
		return _003C_003Ec__DisplayClass13_.X06vEskL5tt;
	}

	public override string ToString()
	{
		return DeviceId;
	}

	public override bool Equals(object obj)
	{
		return Equals(obj as MonitorInfo);
	}

	public override int GetHashCode()
	{
		return DeviceId.GetHashCode();
	}

	public bool Equals(MonitorInfo other)
	{
		return DeviceId == other?.DeviceId;
	}

	public static bool operator ==(MonitorInfo a, MonitorInfo b)
	{
		if ((object)a == b)
		{
			return true;
		}
		return a?.Equals(b) ?? false;
	}

	public static bool operator !=(MonitorInfo a, MonitorInfo b)
	{
		return !(a == b);
	}

	internal static bool BdfIQ83GtGZPAvp0B0c()
	{
		return (object)QvHv763EVrxvvdRDhCO == null;
	}
}
