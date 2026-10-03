using System;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Runtime.CompilerServices;
using doOYFIfAng8uHfpsuw4;
using log4net;

namespace Quicker.Utilities.Win32.Monitor;

public class MonitorHelper
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass5_0
	{
		public byte HUi2N2b70a0;

		internal static _003C_003Ec__DisplayClass5_0 CARyWiyKSgK125LuIhms;

		internal bool Ap22NvkhwpG(byte x)
		{
			return x > HUi2N2b70a0 + 1;
		}

		internal bool Cwh2NSLKGEJ(byte x)
		{
			return x < HUi2N2b70a0 - 1;
		}

		internal static bool veqRSsyKwbaBQr5te8e7()
		{
			return CARyWiyKSgK125LuIhms == null;
		}
	}

	private static readonly ILog A6aLlsacb9M;

	private static long ASYLlHmUngl;

	private static MonitorHelper y669oYFU4glXNhfAYwbI;

	public static void IncreaseBrightness()
	{
		AdjustBrightness(0.05);
	}

	public static void DecreaseBrightness()
	{
		AdjustBrightness(-0.05);
	}

	public static void AdjustBrightness(double delta)
	{
		try
		{
			vTUu1Lf5xGyKvteAoVZ.eRomYBDakkgVLUlAlaj[] array = vTUu1Lf5xGyKvteAoVZ.GKALlR3TRWA(vTUu1Lf5xGyKvteAoVZ.VqOLl7WYkK7());
			vTUu1Lf5xGyKvteAoVZ.eRomYBDakkgVLUlAlaj[] array2 = array;
			foreach (vTUu1Lf5xGyKvteAoVZ.eRomYBDakkgVLUlAlaj eRomYBDakkgVLUlAlaj_ in array2)
			{
				double num = vTUu1Lf5xGyKvteAoVZ.sGILl9mBe7q(eRomYBDakkgVLUlAlaj_);
				num += delta;
				if (num > 1.0)
				{
					num = 1.0;
				}
				else if (num < 0.0)
				{
					num = 0.0;
				}
				vTUu1Lf5xGyKvteAoVZ.KwtLlhadrO1(eRomYBDakkgVLUlAlaj_, num);
			}
			vTUu1Lf5xGyKvteAoVZ.TyLLlqIut6g(array);
		}
		catch (Exception ex)
		{
			try
			{
				XccLlIgtyiX(delta);
			}
			catch (Exception ex2)
			{
				if (AppHelper.fLiLTj0x4QY() - ASYLlHmUngl > 5000L)
				{
					A6aLlsacb9M.Warn("调节亮度失败。ex=" + ex.Message + "  ex1=" + ex2.Message, ex);
					AppHelper.ShowWarning("调节亮度失败,可能您的设备不支持此功能。" + ex.Message);
					ASYLlHmUngl = AppHelper.fLiLTj0x4QY();
				}
			}
		}
	}

	private static void XccLlIgtyiX(double double_0)
	{
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
		byte[] source = VqgLlWx2ZgQ();
		_003C_003Ec__DisplayClass5_.HUi2N2b70a0 = fL8LlkQwobc();
		byte b = _003C_003Ec__DisplayClass5_.HUi2N2b70a0;
		b = ((!(double_0 > 0.0)) ? source.LastOrDefault(_003C_003Ec__DisplayClass5_.Cwh2NSLKGEJ) : source.FirstOrDefault(_003C_003Ec__DisplayClass5_.Ap22NvkhwpG));
		if (b != 0)
		{
			hmNLlGhUTLf(b);
		}
	}

	private static byte[] VqgLlWx2ZgQ()
	{
		ManagementScope scope = new ManagementScope("root\\WMI");
		SelectQuery query = new SelectQuery("WmiMonitorBrightness");
		using ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(scope, query);
		byte[] result = new byte[0];
		using ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
		try
		{
			using ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = managementObjectCollection.GetEnumerator();
			if (managementObjectEnumerator.MoveNext())
			{
				result = (byte[])((ManagementObject)managementObjectEnumerator.Current).GetPropertyValue("Level");
			}
		}
		catch (Exception)
		{
		}
		return result;
	}

	private static byte fL8LlkQwobc()
	{
		ManagementScope scope = new ManagementScope("root\\WMI");
		SelectQuery query = new SelectQuery("WmiMonitorBrightness");
		using ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(scope, query);
		using ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
		byte result = 0;
		using (ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = managementObjectCollection.GetEnumerator())
		{
			if (managementObjectEnumerator.MoveNext())
			{
				result = (byte)((ManagementObject)managementObjectEnumerator.Current).GetPropertyValue("CurrentBrightness");
			}
		}
		return result;
	}

	private static void hmNLlGhUTLf(byte byte_0)
	{
		ManagementScope scope = new ManagementScope("root\\WMI");
		SelectQuery query = new SelectQuery("WmiMonitorBrightnessMethods");
		using ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(scope, query);
		using ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
		using ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = managementObjectCollection.GetEnumerator();
		if (managementObjectEnumerator.MoveNext())
		{
			((ManagementObject)managementObjectEnumerator.Current).InvokeMethod("WmiSetBrightness", new object[2]
			{
				uint.MaxValue,
				byte_0
			});
		}
	}

	static MonitorHelper()
	{
		A6aLlsacb9M = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		ASYLlHmUngl = 0L;
	}

	internal static bool vrRXdTFUhU5l0DsfcO0D()
	{
		return y669oYFU4glXNhfAYwbI == null;
	}
}
