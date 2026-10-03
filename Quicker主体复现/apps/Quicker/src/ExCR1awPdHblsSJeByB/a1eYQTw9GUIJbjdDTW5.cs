using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using JiKpeXw42HYmp9ju8dU;
using log4net;
using otp5BNwoOTeKCWhwo6K;
using Quicker.Common.Entities;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Public.Forms;
using Quicker.Utilities;
using Windows.Devices.Bluetooth;
using Windows.Devices.Bluetooth.Advertisement;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using YDnFyFwG4PlN0Cedwny;

namespace ExCR1awPdHblsSJeByB;

internal class a1eYQTw9GUIJbjdDTW5 : kWjRPcwItwkeAamARyg
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass14_0
	{
		public string zxZvIY7qyeN;

		private static _003C_003Ec__DisplayClass14_0 a5siGYcZntD0ZRCRO7rW;

		internal bool nSNvIePyFFD(CommonTriggerTask task)
		{
			return GFGFgbwXKocENyrCUx4.ibMflIV9C4(task.TryGetParamValue("DeviceName", ""), zxZvIY7qyeN);
		}

		internal static bool WBhr8WcZeqyKrkhj8sPK()
		{
			return a5siGYcZntD0ZRCRO7rW == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CWatcherReceived_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public BluetoothLEAdvertisementWatcher sender;

		public a1eYQTw9GUIJbjdDTW5 _003C_003E4__this;

		public BluetoothLEAdvertisementReceivedEventArgs args;

		private TaskAwaiter<BluetoothLEDevice> _003C_003Eu__1;

		private static object F55wHecZDncgfPEILCo9;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			a1eYQTw9GUIJbjdDTW5 a1eYQTw9GUIJbjdDTW6 = _003C_003E4__this;
			try
			{
				if (num == 0 || sender == a1eYQTw9GUIJbjdDTW6.QRVtwZOY37f)
				{
					try
					{
        MIgO8rwy1Vm9NKEnOm1 value2 = default;
        long num2 = default;
        MIgO8rwy1Vm9NKEnOm1 value = default;
						TaskAwaiter<BluetoothLEDevice> awaiter;
						if (num == 0)
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default(TaskAwaiter<BluetoothLEDevice>);
							num = -1;
							_003C_003E1__state = -1;
							goto IL_01a2;
						}
						IList<ulong> cQLtwejDG7i = a1eYQTw9GUIJbjdDTW6.CQLtwejDG7i;
						bool lockTaken = false;
						try
						{
							Monitor.Enter(cQLtwejDG7i, ref lockTaken);
							if (!a1eYQTw9GUIJbjdDTW6.CQLtwejDG7i.Contains(args.BluetoothAddress))
							{
								goto end_IL_003c;
							}
							goto end_IL_0029;
							end_IL_003c:;
						}
						finally
						{
							if (num < 0 && lockTaken)
							{
								Monitor.Exit(cQLtwejDG7i);
							}
						}
						value = default(MIgO8rwy1Vm9NKEnOm1);
						num2 = default(long);
						int num3;
						if (args.RawSignalStrengthInDBm != -127)
						{
							if (a1eYQTw9GUIJbjdDTW6.tZJtwhqaN7F.TryGetValue(args.BluetoothAddress, out value))
							{
								num2 = AppHelper.fLiLTj0x4QY();
								if ((double)(num2 - value.hWItwIHVYpk()) > a1eYQTw9GUIJbjdDTW6.QRVtwZOY37f.SignalStrengthFilter.OutOfRangeTimeout?.TotalMilliseconds)
								{
									num3 = 2;
									if (!d96dtycZ3uxHbVG3eIap())
									{
										goto IL_0269;
									}
									goto IL_02c9;
								}
								goto IL_02d7;
							}
							awaiter = BluetoothLEDevice.FromBluetoothAddressAsync(args.BluetoothAddress).GetAwaiter<BluetoothLEDevice>();
							if (!awaiter.IsCompleted)
							{
								num = 0;
								_003C_003E1__state = 0;
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_01a2;
						}
						value2 = default(MIgO8rwy1Vm9NKEnOm1);
						if (a1eYQTw9GUIJbjdDTW6.tZJtwhqaN7F.TryGetValue(args.BluetoothAddress, out value2))
						{
							goto IL_027e;
						}
						goto end_IL_0029;
						IL_027e:
						a1eYQTw9GUIJbjdDTW6.HQQtwRI7kil(value2.DeviceName);
						goto end_IL_0029;
						IL_02d7:
						value.PUQtwWiOYMY(num2);
						goto end_IL_0029;
						IL_0269:
						switch (num3)
						{
						case 1:
							lockTaken = false;
							try
							{
								Monitor.Enter(cQLtwejDG7i, ref lockTaken);
								a1eYQTw9GUIJbjdDTW6.CQLtwejDG7i.Add(args.BluetoothAddress);
							}
							finally
							{
								if (num < 0 && lockTaken)
								{
									Monitor.Exit(cQLtwejDG7i);
								}
							}
							goto end_IL_0029;
						case 2:
							goto end_IL_0029;
						case 3:
							goto IL_02c9;
						}
						goto IL_027e;
						IL_02c9:
						a1eYQTw9GUIJbjdDTW6.Tl5twqZxYun(value.DeviceName);
						goto IL_02d7;
						IL_024f:
						cQLtwejDG7i = a1eYQTw9GUIJbjdDTW6.CQLtwejDG7i;
						num3 = 1;
						if (!d96dtycZ3uxHbVG3eIap())
						{
							int num4 = default(int);
							num3 = num4;
						}
						goto IL_0269;
						IL_01a2:
						BluetoothLEDevice result = awaiter.GetResult();
						if (result == null)
						{
							goto IL_024f;
						}
						DeviceInformation deviceInformation = result.DeviceInformation;
						if (string.IsNullOrEmpty((deviceInformation != null) ? deviceInformation.Name : null))
						{
							goto IL_024f;
						}
						_003C_003Ec__DisplayClass14_0 _003C_003Ec__DisplayClass14_ = new _003C_003Ec__DisplayClass14_0
						{
							zxZvIY7qyeN = result.DeviceInformation.Name
						};
						if (!a1eYQTw9GUIJbjdDTW6.jpqtg8Grl0b.Any(_003C_003Ec__DisplayClass14_.nSNvIePyFFD))
						{
							goto IL_024f;
						}
						MIgO8rwy1Vm9NKEnOm1 mIgO8rwy1Vm9NKEnOm = new MIgO8rwy1Vm9NKEnOm1();
						mIgO8rwy1Vm9NKEnOm.DeviceName = _003C_003Ec__DisplayClass14_.zxZvIY7qyeN;
						mIgO8rwy1Vm9NKEnOm.PUQtwWiOYMY(AppHelper.fLiLTj0x4QY());
						MIgO8rwy1Vm9NKEnOm1 value3 = mIgO8rwy1Vm9NKEnOm;
						a1eYQTw9GUIJbjdDTW6.tZJtwhqaN7F[args.BluetoothAddress] = value3;
						a1eYQTw9GUIJbjdDTW6.Tl5twqZxYun(_003C_003Ec__DisplayClass14_.zxZvIY7qyeN);
						end_IL_0029:;
					}
					catch (Exception ex)
					{
						URFtwYaBLrb.Warn("异常：" + ex.Message, ex);
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

		internal static bool d96dtycZ3uxHbVG3eIap()
		{
			return F55wHecZDncgfPEILCo9 == null;
		}
	}

	[CompilerGenerated]
	private readonly IDictionary<string, string> xmLtwV3iuyf = new Dictionary<string, string>
	{
		{ "BluetoothDeviceInRange", "蓝牙设备进入附近" },
		{ "BluetoothDeviceOutOfRange", "蓝牙设备离开附近" }
	};

	private BluetoothLEAdvertisementWatcher QRVtwZOY37f;

	private FormField T2mtw9dhPBo = new FormField
	{
		FieldKey = "DeviceName",
		Label = "设备名",
		DictVarType = VarType.Text,
		HelpText = "蓝牙设备名，多个时使用分号隔开。也可使用“regex:正则表达式”进行正则匹配。",
		IsRequired = true,
		InputMethod = InputMethod.TextBox,
		TextTools = "SelectBluetoothLEDevice"
	};

	private readonly IDictionary<ulong, MIgO8rwy1Vm9NKEnOm1> tZJtwhqaN7F = new ConcurrentDictionary<ulong, MIgO8rwy1Vm9NKEnOm1>();

	private readonly IList<ulong> CQLtwejDG7i = new List<ulong>();

	private static readonly ILog URFtwYaBLrb;

	internal static a1eYQTw9GUIJbjdDTW5 oGr77vQFxZnJwN2R96rF;

	[SpecialName]
	[CompilerGenerated]
	protected override IDictionary<string, string> OVPM2wsWcIu()
	{
		return xmLtwV3iuyf;
	}

	public a1eYQTw9GUIJbjdDTW5()
		: base(new string[2] { "BluetoothDeviceInRange", "BluetoothDeviceOutOfRange" })
	{
	}

	public override IList<FormField> odUM2hmvkik(string string_1)
	{
		return new List<FormField> { T2mtw9dhPBo };
	}

	public override IList<ActionVariable> VrkM2LPKH4P(string string_1)
	{
		return new List<ActionVariable>
		{
			new ActionVariable
			{
				Key = "DeviceName",
				Desc = "设备名称",
				Type = VarType.Text
			}
		};
	}

	protected override void fb3M2Rxtx1E()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		cq5twcOaNbw();
		QRVtwZOY37f = new BluetoothLEAdvertisementWatcher();
		QRVtwZOY37f.ScanningMode = (BluetoothLEScanningMode)0;
		QRVtwZOY37f.SignalStrengthFilter.InRangeThresholdInDBm = (short?)(short)(-70);
		QRVtwZOY37f.SignalStrengthFilter.OutOfRangeThresholdInDBm = (short?)(short)(-126);
		QRVtwZOY37f.SignalStrengthFilter.OutOfRangeTimeout = (TimeSpan?)TimeSpan.FromMilliseconds(20000.0);
		if (oGr77vQFxZnJwN2R96rF == null)
		{
			switch (0)
			{
			}
		}
		BluetoothLEAdvertisementWatcher qRVtwZOY37f = QRVtwZOY37f;
		(qRVtwZOY37f).Received += (TypedEventHandler<BluetoothLEAdvertisementWatcher, BluetoothLEAdvertisementReceivedEventArgs>)AsCtw7JYxU0;
		QRVtwZOY37f.Start();
	}

	[AsyncStateMachine(typeof(_003CWatcherReceived_003Ed__14))]
	private void AsCtw7JYxU0(BluetoothLEAdvertisementWatcher bluetoothLEAdvertisementWatcher_1, BluetoothLEAdvertisementReceivedEventArgs bluetoothLEAdvertisementReceivedEventArgs_0)
	{
		_003CWatcherReceived_003Ed__14 stateMachine = default(_003CWatcherReceived_003Ed__14);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = bluetoothLEAdvertisementWatcher_1;
		stateMachine.args = bluetoothLEAdvertisementReceivedEventArgs_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void HQQtwRI7kil(string string_1)
	{
		foreach (CommonTriggerTask item in jpqtg8Grl0b)
		{
			if (item.EventType == "BluetoothDeviceOutOfRange" && GFGFgbwXKocENyrCUx4.ibMflIV9C4(item.TryGetParamValue("DeviceName", ""), string_1) && iJ2tguv8HCS(item, new Dictionary<string, object> { { "DeviceName", string_1 } }) && item.SkipFurtherTasks)
			{
				break;
			}
		}
	}

	private void Tl5twqZxYun(string string_1)
	{
		if (AppHelper.fLiLTj0x4QY() - X5mtgai7GZ6 < 15000L)
		{
			return;
		}
		foreach (CommonTriggerTask item in jpqtg8Grl0b)
		{
			if (item.EventType == "BluetoothDeviceInRange" && GFGFgbwXKocENyrCUx4.ibMflIV9C4(item.TryGetParamValue("DeviceName", ""), string_1) && iJ2tguv8HCS(item, new Dictionary<string, object> { { "DeviceName", string_1 } }) && item.SkipFurtherTasks)
			{
				break;
			}
		}
	}

	private void cq5twcOaNbw()
	{
		if (QRVtwZOY37f != null)
		{
			(QRVtwZOY37f).Received -= (TypedEventHandler<BluetoothLEAdvertisementWatcher, BluetoothLEAdvertisementReceivedEventArgs>)AsCtw7JYxU0;
			QRVtwZOY37f.Stop();
			QRVtwZOY37f = null;
		}
		tZJtwhqaN7F.Clear();
	}

	protected override void C5rM2eDjuIN()
	{
		cq5twcOaNbw();
	}

	static a1eYQTw9GUIJbjdDTW5()
	{
		URFtwYaBLrb = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool U0xHKuQFINeQ4JqmyHiX()
	{
		return oGr77vQFxZnJwN2R96rF == null;
	}

	internal static void zCIlyaQFwSHBO9ZKFqYB()
	{
	}
}
