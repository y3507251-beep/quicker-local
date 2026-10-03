using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Markup;
using GuvA3OiyFyyWpKJlb8c;
using Quicker.Domain;
using Quicker.Utilities;
using Quicker.Utilities.UI;
using Quicker.Utilities.UI.Wpf;
using Windows.Devices.Bluetooth;
using Windows.Devices.Enumeration;
using Windows.Foundation;

namespace Quicker.Modules.TextTools.Tools;

public class BluetoothDeviceSelectorWindow : Window, IComponentConnector, IMockModalWindow
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass23_0
	{
		public BluetoothDeviceSelectorWindow bnBvGhnJoFg;

		public DeviceWatcher mCTvGeiTTSF;

		public DeviceInformation aoivGYPFnt2;

		internal static _003C_003Ec__DisplayClass23_0 WexVlfcY66IdOT4XF8Km;

		internal void AfJvG9USbcf()
		{
			lock (bnBvGhnJoFg)
			{
				if (mCTvGeiTTSF == bnBvGhnJoFg.S4rtShqhQoW && bnBvGhnJoFg.I1ZtSC8sclL(aoivGYPFnt2.Id) == null)
				{
					if (aoivGYPFnt2.Name != string.Empty)
					{
						bnBvGhnJoFg.UAYtSZ9XI3s.Add(new BluetoothLEDeviceDisplay(aoivGYPFnt2));
					}
					else
					{
						bnBvGhnJoFg.MCwtS9B408J.Add(aoivGYPFnt2);
					}
				}
			}
		}

		internal static bool kOG9H7cYt8E4mdbVjA5W()
		{
			return WexVlfcY66IdOT4XF8Km == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass24_0
	{
		public BluetoothDeviceSelectorWindow UmQvGWBn9Gu;

		public DeviceWatcher Ff7vGkkVmLa;

		public DeviceInformationUpdate ra6vGGxH5FN;

		internal static _003C_003Ec__DisplayClass24_0 H73fLMcYTw0oYBg2kNAU;

		internal void AT4vGIqV4nS()
		{
			lock (UmQvGWBn9Gu)
			{
				if (Ff7vGkkVmLa != UmQvGWBn9Gu.S4rtShqhQoW)
				{
					return;
				}
				BluetoothLEDeviceDisplay bluetoothLEDeviceDisplay = UmQvGWBn9Gu.I1ZtSC8sclL(ra6vGGxH5FN.Id);
				if (bluetoothLEDeviceDisplay != null)
				{
					bluetoothLEDeviceDisplay.Update(ra6vGGxH5FN);
					return;
				}
				DeviceInformation val = UmQvGWBn9Gu.deDtSPP1EPg(ra6vGGxH5FN.Id);
				if (val == null)
				{
					return;
				}
				val.Update(ra6vGGxH5FN);
				if (val.Name != string.Empty)
				{
					UmQvGWBn9Gu.UAYtSZ9XI3s.Add(new BluetoothLEDeviceDisplay(val));
					UmQvGWBn9Gu.MCwtS9B408J.Remove(val);
					int num = 0;
					if (H73fLMcYTw0oYBg2kNAU != null)
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					}
				}
			}
		}

		static _003C_003Ec__DisplayClass24_0()
		{
		}

		internal static bool FnHMuBcYmQSsrUjp6Tjp()
		{
			return H73fLMcYTw0oYBg2kNAU == null;
		}

		internal static void V1tGDjcYCgTAGpMZ9q61()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass25_0
	{
		public BluetoothDeviceSelectorWindow DtJvGHF69tO;

		public DeviceWatcher ogivG1rcJPk;

		public DeviceInformationUpdate cl0vGbFC5dx;

		private static _003C_003Ec__DisplayClass25_0 BFIdjfcY7tw7gVhZO7K9;

		internal void u4IvGs7BKBu()
		{
			lock (DtJvGHF69tO)
			{
				if (ogivG1rcJPk == DtJvGHF69tO.S4rtShqhQoW)
				{
					BluetoothLEDeviceDisplay bluetoothLEDeviceDisplay = DtJvGHF69tO.I1ZtSC8sclL(cl0vGbFC5dx.Id);
					if (bluetoothLEDeviceDisplay != null)
					{
						DtJvGHF69tO.UAYtSZ9XI3s.Remove(bluetoothLEDeviceDisplay);
					}
					DeviceInformation val = DtJvGHF69tO.deDtSPP1EPg(cl0vGbFC5dx.Id);
					if (val != null)
					{
						DtJvGHF69tO.MCwtS9B408J.Remove(val);
					}
				}
			}
		}

		internal static bool Mph4CXcY4XHkmW90ic79()
		{
			return BFIdjfcY7tw7gVhZO7K9 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass26_0
	{
		public DeviceWatcher f2svGXYJm7G;

		public BluetoothDeviceSelectorWindow PHuvGm246As;

		internal static _003C_003Ec__DisplayClass26_0 LwIL9XcYHKAWkssPKGTa;

		internal void C4nvG6Wy7qZ()
		{
		}

		internal static bool gvSNh0cYzSgSt7DMl4tE()
		{
			return LwIL9XcYHKAWkssPKGTa == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass27_0
	{
		public DeviceWatcher zp4vGxFYXIW;

		public BluetoothDeviceSelectorWindow cIGvGrmdBwx;

		internal static _003C_003Ec__DisplayClass27_0 pkNURBc8Q6L52V4dfGZi;

		internal void g7QvGKEIBgK()
		{
		}

		internal static void fFSjYQc8Wk21JQDDqUtG()
		{
		}

		internal static bool lso0PRc8F40agkhrFSNm()
		{
			return pkNURBc8Q6L52V4dfGZi == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDeviceWatcher_Added_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public BluetoothDeviceSelectorWindow _003C_003E4__this;

		public DeviceWatcher sender;

		public DeviceInformation deviceInfo;

		private TaskAwaiter _003C_003Eu__1;

		internal static object xIYWZ2c8y2MHXFcJnskP;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			BluetoothDeviceSelectorWindow bluetoothDeviceSelectorWindow = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					_003C_003Ec__DisplayClass23_0 _003C_003Ec__DisplayClass23_ = new _003C_003Ec__DisplayClass23_0
					{
						bnBvGhnJoFg = _003C_003E4__this,
						mCTvGeiTTSF = sender,
						aoivGYPFnt2 = deviceInfo
					};
					awaiter = bluetoothDeviceSelectorWindow.Dispatcher.InvokeAsync(_003C_003Ec__DisplayClass23_.AfJvG9USbcf).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					int num2 = 0;
					if (!T5uejEc8p1RHweskY9Dv())
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
					num = -1;
					_003C_003E1__state = -1;
				}
				awaiter.GetResult();
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool T5uejEc8p1RHweskY9Dv()
		{
			return xIYWZ2c8y2MHXFcJnskP == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDeviceWatcher_EnumerationCompleted_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public DeviceWatcher sender;

		public BluetoothDeviceSelectorWindow _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object tqewACc82t7oiIrA1eLx;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			BluetoothDeviceSelectorWindow bluetoothDeviceSelectorWindow = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					_003C_003Ec__DisplayClass26_0 _003C_003Ec__DisplayClass26_ = new _003C_003Ec__DisplayClass26_0
					{
						f2svGXYJm7G = sender,
						PHuvGm246As = _003C_003E4__this
					};
					awaiter = bluetoothDeviceSelectorWindow.Dispatcher.InvokeAsync(_003C_003Ec__DisplayClass26_.C4nvG6Wy7qZ).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						int num2 = 0;
						if (tqewACc82t7oiIrA1eLx != null)
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
				}
				awaiter.GetResult();
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool hnEIqxc8ACc0yiLYyP6v()
		{
			return tqewACc82t7oiIrA1eLx == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDeviceWatcher_Removed_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public BluetoothDeviceSelectorWindow _003C_003E4__this;

		public DeviceWatcher sender;

		public DeviceInformationUpdate deviceInfoUpdate;

		private TaskAwaiter _003C_003Eu__1;

		private static object xgMmT0c8eFQRaw7tK9ik;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			BluetoothDeviceSelectorWindow bluetoothDeviceSelectorWindow = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					_003C_003Ec__DisplayClass25_0 _003C_003Ec__DisplayClass25_ = new _003C_003Ec__DisplayClass25_0
					{
						DtJvGHF69tO = _003C_003E4__this,
						ogivG1rcJPk = sender,
						cl0vGbFC5dx = deviceInfoUpdate
					};
					awaiter = bluetoothDeviceSelectorWindow.Dispatcher.InvokeAsync(_003C_003Ec__DisplayClass25_.u4IvGs7BKBu).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					if (xgMmT0c8eFQRaw7tK9ik != null)
					{
						switch (0)
						{
						}
					}
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
				}
				awaiter.GetResult();
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool Taau7fc8j6wGFWU4Xw0S()
		{
			return xgMmT0c8eFQRaw7tK9ik == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDeviceWatcher_Stopped_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public DeviceWatcher sender;

		public BluetoothDeviceSelectorWindow _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object D31jQIc83OuNQYLXEW62;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			BluetoothDeviceSelectorWindow bluetoothDeviceSelectorWindow = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					_003C_003Ec__DisplayClass27_0 _003C_003Ec__DisplayClass27_ = new _003C_003Ec__DisplayClass27_0
					{
						zp4vGxFYXIW = sender,
						cIGvGrmdBwx = _003C_003E4__this
					};
					awaiter = bluetoothDeviceSelectorWindow.Dispatcher.InvokeAsync(_003C_003Ec__DisplayClass27_.g7QvGKEIBgK).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
				}
				awaiter.GetResult();
				int num2 = 0;
				if (D31jQIc83OuNQYLXEW62 != null)
				{
					int num3 = default(int);
					num2 = num3;
				}
				switch (num2)
				{
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool jNRNGAc8EINBnCimSd3U()
		{
			return D31jQIc83OuNQYLXEW62 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDeviceWatcher_Updated_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public BluetoothDeviceSelectorWindow _003C_003E4__this;

		public DeviceWatcher sender;

		public DeviceInformationUpdate deviceInfoUpdate;

		private TaskAwaiter _003C_003Eu__1;

		internal static object whJS9ac802qhmbDBX6py;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			BluetoothDeviceSelectorWindow bluetoothDeviceSelectorWindow = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					_003C_003Ec__DisplayClass24_0 _003C_003Ec__DisplayClass24_ = new _003C_003Ec__DisplayClass24_0
					{
						UmQvGWBn9Gu = _003C_003E4__this,
						Ff7vGkkVmLa = sender,
						ra6vGGxH5FN = deviceInfoUpdate
					};
					int num2 = 0;
					if (!cfdF34c81qsQb2teXEkO())
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
					awaiter = bluetoothDeviceSelectorWindow.Dispatcher.InvokeAsync(_003C_003Ec__DisplayClass24_.AT4vGIqV4nS).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
				}
				awaiter.GetResult();
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool cfdF34c81qsQb2teXEkO()
		{
			return whJS9ac802qhmbDBX6py == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadBluetoothDevices_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public BluetoothDeviceSelectorWindow _003C_003E4__this;

		private TaskAwaiter<DeviceInformationCollection> _003C_003Eu__1;

		private static object JYyWqBc8BVtV6XFT5M7H;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			BluetoothDeviceSelectorWindow bluetoothDeviceSelectorWindow = _003C_003E4__this;
			try
			{
				TaskAwaiter<DeviceInformationCollection> awaiter;
				if (num != 0)
				{
					awaiter = DeviceInformation.FindAllAsync(BluetoothDevice.GetDeviceSelectorFromPairingState(true)).GetAwaiter<DeviceInformationCollection>();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					int num2 = 0;
					if (!NtcFmic8vc0sjJw7nxD6())
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
					_003C_003Eu__1 = default(TaskAwaiter<DeviceInformationCollection>);
					num = -1;
					_003C_003E1__state = -1;
				}
				IEnumerator<DeviceInformation> enumerator = ((IEnumerable<DeviceInformation>)awaiter.GetResult()).GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						DeviceInformation current = enumerator.Current;
						bluetoothDeviceSelectorWindow.UAYtSZ9XI3s.Add(new BluetoothLEDeviceDisplay(current));
					}
				}
				finally
				{
					if (num < 0)
					{
						enumerator?.Dispose();
					}
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool NtcFmic8vc0sjJw7nxD6()
		{
			return JYyWqBc8BVtV6XFT5M7H == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnLoaded_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public BluetoothDeviceSelectorWindow _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object K5ovjqc8OI7LdW7M2Cwl;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			BluetoothDeviceSelectorWindow bluetoothDeviceSelectorWindow = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_008a;
				}
				if (!bluetoothDeviceSelectorWindow.RbktSqL47lI)
				{
					awaiter = bluetoothDeviceSelectorWindow.FnDtS2r0ELC().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						if (K5ovjqc8OI7LdW7M2Cwl != null)
						{
							switch (0)
							{
							}
						}
						return;
					}
					goto IL_008a;
				}
				bluetoothDeviceSelectorWindow.AfdtSJxGK10();
				goto end_IL_000e;
				IL_008a:
				awaiter.GetResult();
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static _003COnLoaded_003Ed__7()
		{
		}

		internal static bool ckNRDkc8Jakb8ZvBBRig()
		{
			return K5ovjqc8OI7LdW7M2Cwl == null;
		}

		internal static void v3uDccc8aYttrqfiWJaP()
		{
		}
	}

	private readonly bool RbktSqL47lI;

	[CompilerGenerated]
	private BluetoothLEDeviceDisplay mKitScvttuy;

	[CompilerGenerated]
	private bool? cbhtSVDqhL5;

	private ObservableCollection<BluetoothLEDeviceDisplay> UAYtSZ9XI3s = new ObservableCollection<BluetoothLEDeviceDisplay>();

	private List<DeviceInformation> MCwtS9B408J = new List<DeviceInformation>();

	private DeviceWatcher S4rtShqhQoW;

	internal ListBox DeviceList;

	internal Button BtnOk;

	internal Button BtnCancel;

	private bool sthtSekVE20;

	internal static BluetoothDeviceSelectorWindow AN4AHpQpBfJDMUJKL8yT;

	public BluetoothLEDeviceDisplay SelectedDevice
	{
		[CompilerGenerated]
		get
		{
			return mKitScvttuy;
		}
		[CompilerGenerated]
		set
		{
			mKitScvttuy = value;
		}
	}

	public bool? Result
	{
		[CompilerGenerated]
		get
		{
			return cbhtSVDqhL5;
		}
		[CompilerGenerated]
		set
		{
			cbhtSVDqhL5 = value;
		}
	}

	public BluetoothDeviceSelectorWindow(bool forLeDevice)
	{
		RbktSqL47lI = forLeDevice;
		InitializeComponent();
		DeviceList.ItemsSource = UAYtSZ9XI3s;
		base.Loaded += r30tSSA4jHf;
		base.Closing += tlntSvVl0aB;
	}

	private void tlntSvVl0aB(object sender, CancelEventArgs e)
	{
		sfstS0wkAcl();
	}

	[AsyncStateMachine(typeof(_003COnLoaded_003Ed__7))]
	private void r30tSSA4jHf(object sender, RoutedEventArgs e)
	{
		_003COnLoaded_003Ed__7 stateMachine = default(_003COnLoaded_003Ed__7);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	[AsyncStateMachine(typeof(_003CLoadBluetoothDevices_003Ed__9))]
	private Task FnDtS2r0ELC()
	{
		_003CLoadBluetoothDevices_003Ed__9 stateMachine = default(_003CLoadBluetoothDevices_003Ed__9);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private void rVitSu855JC(object sender, RoutedEventArgs e)
	{
		tYxtSN6Mujc();
	}

	private void tYxtSN6Mujc()
	{
		if (DeviceList.SelectedItem == null)
		{
			AppHelper.ShowWarning("请选择一个设备");
			return;
		}
		SelectedDevice = DeviceList.SelectedItem as BluetoothLEDeviceDisplay;
		this.ThNvuM5Q9GQ(true);
	}

	private void AfdtSJxGK10()
	{
		int num = 1;
		while (true)
		{
			string[] array = new string[3] { "System.Devices.Aep.DeviceAddress", "System.Devices.Aep.IsConnected", "System.Devices.Aep.Bluetooth.Le.IsConnectable" };
			int num2 = 0;
			if (!PYfiG7QpvZuAOOkNCkGc())
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			string text = "(System.Devices.Aep.ProtocolId:=\"{bb7bb05e-5972-42b5-94fc-76eaa7084d49}\")";
			S4rtShqhQoW = DeviceInformation.CreateWatcher(text, (IEnumerable<string>)array, (DeviceInformationKind)5);
			DeviceWatcher s4rtShqhQoW = S4rtShqhQoW;
			(s4rtShqhQoW).Added += (TypedEventHandler<DeviceWatcher, DeviceInformation>)e4QtSEqK0NE;
			s4rtShqhQoW = S4rtShqhQoW;
			(s4rtShqhQoW).Updated += (TypedEventHandler<DeviceWatcher, DeviceInformationUpdate>)x3KtSyGFtTE;
			s4rtShqhQoW = S4rtShqhQoW;
			(s4rtShqhQoW).Removed += (TypedEventHandler<DeviceWatcher, DeviceInformationUpdate>)ptQtS8NLLLT;
			s4rtShqhQoW = S4rtShqhQoW;
			(s4rtShqhQoW).EnumerationCompleted += (TypedEventHandler<DeviceWatcher, object>)c6xtSaXqA6H;
			s4rtShqhQoW = S4rtShqhQoW;
			(s4rtShqhQoW).Stopped += (TypedEventHandler<DeviceWatcher, object>)xShtS7so3mD;
			UAYtSZ9XI3s.Clear();
			S4rtShqhQoW.Start();
			return;
		}
	}

	private void sfstS0wkAcl()
	{
		if (S4rtShqhQoW != null)
		{
			(S4rtShqhQoW).Added -= (TypedEventHandler<DeviceWatcher, DeviceInformation>)e4QtSEqK0NE;
			(S4rtShqhQoW).Updated -= (TypedEventHandler<DeviceWatcher, DeviceInformationUpdate>)x3KtSyGFtTE;
			(S4rtShqhQoW).Removed -= (TypedEventHandler<DeviceWatcher, DeviceInformationUpdate>)ptQtS8NLLLT;
			(S4rtShqhQoW).EnumerationCompleted -= (TypedEventHandler<DeviceWatcher, object>)c6xtSaXqA6H;
			(S4rtShqhQoW).Stopped -= (TypedEventHandler<DeviceWatcher, object>)xShtS7so3mD;
			S4rtShqhQoW.Stop();
			S4rtShqhQoW = null;
		}
	}

	private BluetoothLEDeviceDisplay I1ZtSC8sclL(string string_0)
	{
		foreach (BluetoothLEDeviceDisplay uAYtSZ9XI in UAYtSZ9XI3s)
		{
			if (uAYtSZ9XI.Id == string_0)
			{
				return uAYtSZ9XI;
			}
		}
		return null;
	}

	private DeviceInformation deDtSPP1EPg(string string_0)
	{
		foreach (DeviceInformation item in MCwtS9B408J)
		{
			if (item.Id == string_0)
			{
				return item;
			}
		}
		return null;
	}

	[AsyncStateMachine(typeof(_003CDeviceWatcher_Added_003Ed__23))]
	private void e4QtSEqK0NE(DeviceWatcher deviceWatcher_1, DeviceInformation deviceInformation_0)
	{
		_003CDeviceWatcher_Added_003Ed__23 stateMachine = default(_003CDeviceWatcher_Added_003Ed__23);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = deviceWatcher_1;
		stateMachine.deviceInfo = deviceInformation_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CDeviceWatcher_Updated_003Ed__24))]
	private void x3KtSyGFtTE(DeviceWatcher deviceWatcher_1, DeviceInformationUpdate deviceInformationUpdate_0)
	{
		_003CDeviceWatcher_Updated_003Ed__24 stateMachine = default(_003CDeviceWatcher_Updated_003Ed__24);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = deviceWatcher_1;
		stateMachine.deviceInfoUpdate = deviceInformationUpdate_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CDeviceWatcher_Removed_003Ed__25))]
	private void ptQtS8NLLLT(DeviceWatcher deviceWatcher_1, DeviceInformationUpdate deviceInformationUpdate_0)
	{
		_003CDeviceWatcher_Removed_003Ed__25 stateMachine = default(_003CDeviceWatcher_Removed_003Ed__25);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = deviceWatcher_1;
		stateMachine.deviceInfoUpdate = deviceInformationUpdate_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CDeviceWatcher_EnumerationCompleted_003Ed__26))]
	private void c6xtSaXqA6H(DeviceWatcher deviceWatcher_1, object object_0)
	{
		_003CDeviceWatcher_EnumerationCompleted_003Ed__26 stateMachine = default(_003CDeviceWatcher_EnumerationCompleted_003Ed__26);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = deviceWatcher_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CDeviceWatcher_Stopped_003Ed__27))]
	private void xShtS7so3mD(DeviceWatcher deviceWatcher_1, object object_0)
	{
		_003CDeviceWatcher_Stopped_003Ed__27 stateMachine = default(_003CDeviceWatcher_Stopped_003Ed__27);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = deviceWatcher_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void y13tSRhs5uw(object sender, RoutedEventArgs e)
	{
		Close();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!sthtSekVE20)
		{
			sthtSekVE20 = true;
			Uri resourceLocator = new Uri("/Quicker;component/modules/texttools/tools/bluetoothdeviceselectorwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			sthtSekVE20 = true;
			break;
		case 1:
			DeviceList = (ListBox)target;
			break;
		case 2:
			BtnOk = (Button)target;
			BtnOk.Click += rVitSu855JC;
			break;
		case 3:
			BtnCancel = (Button)target;
			BtnCancel.Click += y13tSRhs5uw;
			break;
		}
	}

	internal static bool PYfiG7QpvZuAOOkNCkGc()
	{
		return AN4AHpQpBfJDMUJKL8yT == null;
	}
}
