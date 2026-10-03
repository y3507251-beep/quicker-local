using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using log4net;
using otp5BNwoOTeKCWhwo6K;
using Quicker.Common.Entities;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Public.Forms;
using Quicker.Utilities;
using Windows.Devices.Bluetooth;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using YDnFyFwG4PlN0Cedwny;

namespace Cf6JJSwcQUQTyf1yfiU;

internal class XIGHJKw1eE9po2LdeSn : kWjRPcwItwkeAamARyg
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec AjMvIRkbOic;

		public static Func<CommonTriggerTask, bool> TG4vIqHYvrw;

		internal static _003C_003Ec P3JTiKclwuRshlubSPsn;

		static _003C_003Ec()
		{
			AjMvIRkbOic = new _003C_003Ec();
		}

		internal bool NrFvI7PyRqs(CommonTriggerTask x)
		{
			return x.EventType.EqualsAny(false, "BluetoothDeviceConnected", "BluetoothDeviceDisconnected");
		}

		internal static bool cg4ekeclTSl5Wmoj9QcK()
		{
			return P3JTiKclwuRshlubSPsn == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass18_0
	{
		public DeviceInformation hn9vIVkJJB0;

		internal static _003C_003Ec__DisplayClass18_0 jw9ntMclsL8ndQafgjyc;

		internal bool tvBvIc8pBC8(CommonTriggerTask task)
		{
			return GFGFgbwXKocENyrCUx4.ibMflIV9C4(task.TryGetParamValue("DeviceName", ""), hn9vIVkJJB0.Name);
		}

		internal static bool MwutOcclCiyQqyHjNim1()
		{
			return jw9ntMclsL8ndQafgjyc == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass19_0
	{
		public string k8svI9Zuues;

		public Func<CommonTriggerTask, bool> RwCvIhZStwI;

		private static _003C_003Ec__DisplayClass19_0 FWKxqmcl4rlPNOGbIuLs;

		internal bool UrXvIZeQEpQ(CommonTriggerTask x)
		{
			return x.EventType == k8svI9Zuues;
		}

		internal static bool geECEoclh5mGtuNmmXyK()
		{
			return FWKxqmcl4rlPNOGbIuLs == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDeviceWatcher_Added_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public DeviceInformation deviceInfo;

		public DeviceWatcher sender;

		public XIGHJKw1eE9po2LdeSn _003C_003E4__this;

		private _003C_003Ec__DisplayClass18_0 _003C_003E8__1;

		private TaskAwaiter<BluetoothDevice> _003C_003Eu__1;

		private static object uQYuK1cZVCrvISVvSNvD;

		private void MoveNext()
		{
			//IL_0164: Unknown result type (might be due to invalid IL or missing references)
			//IL_016a: Invalid comparison between Unknown and I4
			int num = _003C_003E1__state;
			XIGHJKw1eE9po2LdeSn xIGHJKw1eE9po2LdeSn = _003C_003E4__this;
			try
			{
				if (num == 0)
				{
					goto IL_007f;
				}
				_003C_003E8__1 = new _003C_003Ec__DisplayClass18_0();
				_003C_003E8__1.hn9vIVkJJB0 = deviceInfo;
				if (sender == xIGHJKw1eE9po2LdeSn.FuVtw8mW93I && !_003C_003E8__1.hn9vIVkJJB0.Name.IsNullOrEmpty() && xIGHJKw1eE9po2LdeSn.jpqtg8Grl0b.Any(_003C_003E8__1.tvBvIc8pBC8))
				{
					goto IL_007f;
				}
				goto end_IL_0010;
				IL_007f:
				try
				{
					TaskAwaiter<BluetoothDevice> awaiter;
					if (num != 0)
					{
						int num2 = 0;
						if (!NfeA0jcZQp5xymfHFuly())
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
						awaiter = BluetoothDevice.FromIdAsync(_003C_003E8__1.hn9vIVkJJB0.Id).GetAwaiter<BluetoothDevice>();
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
						_003C_003Eu__1 = default(TaskAwaiter<BluetoothDevice>);
						num = -1;
						_003C_003E1__state = -1;
					}
					BluetoothDevice result = awaiter.GetResult();
					if (result != null)
					{
						xIGHJKw1eE9po2LdeSn.dgttwaKHPoX.Add(_003C_003E8__1.hn9vIVkJJB0.Id, result);
						BluetoothDevice val = result;
						(val).ConnectionStatusChanged += (TypedEventHandler<BluetoothDevice, object>)xIGHJKw1eE9po2LdeSn.KK5twSjXKL1;
						if ((int)result.ConnectionStatus == 1)
						{
							xIGHJKw1eE9po2LdeSn.a6DtwJKj6Qx(result, "BluetoothDeviceConnected");
						}
					}
				}
				catch (Exception ex)
				{
					oqHtwPTmc8s.Warn("获取蓝牙设备对象出错：name=" + _003C_003E8__1.hn9vIVkJJB0.Name + ", id=" + _003C_003E8__1.hn9vIVkJJB0.Id + " ex=" + ex.Message);
				}
				end_IL_0010:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003E8__1 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003E8__1 = null;
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

		internal static bool NfeA0jcZQp5xymfHFuly()
		{
			return uQYuK1cZVCrvISVvSNvD == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDeviceWatcher_Removed_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public XIGHJKw1eE9po2LdeSn _003C_003E4__this;

		public DeviceInformationUpdate args;

		private static object QXAo9DcZcNhZ9QguNwZh;

		private void MoveNext()
		{
			XIGHJKw1eE9po2LdeSn xIGHJKw1eE9po2LdeSn = _003C_003E4__this;
			try
			{
				if (xIGHJKw1eE9po2LdeSn.dgttwaKHPoX.ContainsKey(args.Id))
				{
					(xIGHJKw1eE9po2LdeSn.dgttwaKHPoX[args.Id]).ConnectionStatusChanged -= (TypedEventHandler<BluetoothDevice, object>)xIGHJKw1eE9po2LdeSn.KK5twSjXKL1;
					xIGHJKw1eE9po2LdeSn.dgttwaKHPoX.Remove(args.Id);
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

		internal static bool FfR0ZncZW3mCUkf3aFfe()
		{
			return QXAo9DcZcNhZ9QguNwZh == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDeviceWatcher_Updated_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		internal static object w20yCQcZXsHU0fXyvegd;

		private void MoveNext()
		{
			try
			{
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

		internal static bool sluH94cZ2icNMLBKZB3a()
		{
			return w20yCQcZXsHU0fXyvegd == null;
		}
	}

	private static readonly ILog oqHtwPTmc8s;

	[CompilerGenerated]
	private readonly IDictionary<string, string> nLJtwEWLUjb = new Dictionary<string, string>
	{
		{ "BluetoothDeviceConnected", "蓝牙设备连接" },
		{ "BluetoothDeviceDisconnected", "蓝牙设备断开" }
	};

	private FormField h9TtwyV1MPp = new FormField
	{
		FieldKey = "DeviceName",
		Label = "设备名",
		DictVarType = VarType.Text,
		HelpText = "蓝牙设备名，多个时使用分号隔开。也可使用“regex:正则表达式”进行正则匹配。",
		IsRequired = true,
		InputMethod = InputMethod.TextBox,
		TextTools = "SelectBluetoothDevice"
	};

	private DeviceWatcher FuVtw8mW93I;

	private IDictionary<string, BluetoothDevice> dgttwaKHPoX = new ConcurrentDictionary<string, BluetoothDevice>();

	internal static XIGHJKw1eE9po2LdeSn cGTBdVQFY2CPh35LHEpb;

	[SpecialName]
	[CompilerGenerated]
	protected override IDictionary<string, string> OVPM2wsWcIu()
	{
		return nLJtwEWLUjb;
	}

	public XIGHJKw1eE9po2LdeSn()
		: base(new string[2] { "BluetoothDeviceConnected", "BluetoothDeviceDisconnected" })
	{
	}

	public override IList<FormField> odUM2hmvkik(string string_1)
	{
		return new List<FormField> { h9TtwyV1MPp };
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
		BtrtwvGqbiG();
		if (jpqtg8Grl0b.Any(_003C_003Ec.TG4vIqHYvrw ?? (_003C_003Ec.TG4vIqHYvrw = _003C_003Ec.AjMvIRkbOic.NrFvI7PyRqs)))
		{
			FuVtw8mW93I = DeviceInformation.CreateWatcher(BluetoothDevice.GetDeviceSelector());
			DeviceWatcher fuVtw8mW93I = FuVtw8mW93I;
			(fuVtw8mW93I).Added += (TypedEventHandler<DeviceWatcher, DeviceInformation>)JCbtwN4WAy1;
			fuVtw8mW93I = FuVtw8mW93I;
			(fuVtw8mW93I).Updated += (TypedEventHandler<DeviceWatcher, DeviceInformationUpdate>)eWxtwCqlCIj;
			fuVtw8mW93I = FuVtw8mW93I;
			int num = 0;
			if (!H7jW25QF8be03qIHZF4P())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			(fuVtw8mW93I).Removed += (TypedEventHandler<DeviceWatcher, DeviceInformationUpdate>)LS5tw0HbPrK;
			fuVtw8mW93I = FuVtw8mW93I;
			(fuVtw8mW93I).EnumerationCompleted += (TypedEventHandler<DeviceWatcher, object>)TWjtw2x2cXK;
			fuVtw8mW93I = FuVtw8mW93I;
			(fuVtw8mW93I).Stopped += (TypedEventHandler<DeviceWatcher, object>)SDDtwuP1MFr;
			FuVtw8mW93I.Start();
		}
	}

	private void BtrtwvGqbiG()
	{
		if (FuVtw8mW93I != null)
		{
			FuVtw8mW93I.Stop();
			(FuVtw8mW93I).Added -= (TypedEventHandler<DeviceWatcher, DeviceInformation>)JCbtwN4WAy1;
			int num = 0;
			if (cGTBdVQFY2CPh35LHEpb != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			(FuVtw8mW93I).Updated -= (TypedEventHandler<DeviceWatcher, DeviceInformationUpdate>)eWxtwCqlCIj;
			(FuVtw8mW93I).Removed -= (TypedEventHandler<DeviceWatcher, DeviceInformationUpdate>)LS5tw0HbPrK;
			(FuVtw8mW93I).EnumerationCompleted -= (TypedEventHandler<DeviceWatcher, object>)TWjtw2x2cXK;
			(FuVtw8mW93I).Stopped -= (TypedEventHandler<DeviceWatcher, object>)SDDtwuP1MFr;
			FuVtw8mW93I = null;
		}
		foreach (BluetoothDevice value in dgttwaKHPoX.Values)
		{
			(value).ConnectionStatusChanged -= (TypedEventHandler<BluetoothDevice, object>)KK5twSjXKL1;
		}
		dgttwaKHPoX.Clear();
	}

	private void KK5twSjXKL1(BluetoothDevice bluetoothDevice_0, object object_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)bluetoothDevice_0.ConnectionStatus == 1)
		{
			a6DtwJKj6Qx(bluetoothDevice_0, "BluetoothDeviceConnected");
		}
		else
		{
			a6DtwJKj6Qx(bluetoothDevice_0, "BluetoothDeviceDisconnected");
		}
	}

	private void TWjtw2x2cXK(DeviceWatcher deviceWatcher_1, object object_0)
	{
	}

	private void SDDtwuP1MFr(DeviceWatcher deviceWatcher_1, object object_0)
	{
	}

	[AsyncStateMachine(typeof(_003CDeviceWatcher_Added_003Ed__18))]
	private void JCbtwN4WAy1(DeviceWatcher deviceWatcher_1, DeviceInformation deviceInformation_0)
	{
		_003CDeviceWatcher_Added_003Ed__18 stateMachine = default(_003CDeviceWatcher_Added_003Ed__18);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = deviceWatcher_1;
		stateMachine.deviceInfo = deviceInformation_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void a6DtwJKj6Qx(BluetoothDevice bluetoothDevice_0, string string_1)
	{
		_003C_003Ec__DisplayClass19_0 _003C_003Ec__DisplayClass19_ = new _003C_003Ec__DisplayClass19_0();
		_003C_003Ec__DisplayClass19_.k8svI9Zuues = string_1;
		if (AppHelper.fLiLTj0x4QY() - X5mtgai7GZ6 < 5000L)
		{
			return;
		}
		Dictionary<string, object> idictionary_ = new Dictionary<string, object> { { "DeviceName", bluetoothDevice_0.Name } };
		foreach (CommonTriggerTask item in jpqtg8Grl0b.Where(_003C_003Ec__DisplayClass19_.RwCvIhZStwI ?? (_003C_003Ec__DisplayClass19_.RwCvIhZStwI = _003C_003Ec__DisplayClass19_.UrXvIZeQEpQ)))
		{
			if (GFGFgbwXKocENyrCUx4.ibMflIV9C4(item.TryGetParamValue("DeviceName", ""), bluetoothDevice_0.Name) && iJ2tguv8HCS(item, idictionary_) && item.SkipFurtherTasks)
			{
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CDeviceWatcher_Removed_003Ed__20))]
	private void LS5tw0HbPrK(DeviceWatcher deviceWatcher_1, DeviceInformationUpdate deviceInformationUpdate_0)
	{
		_003CDeviceWatcher_Removed_003Ed__20 stateMachine = default(_003CDeviceWatcher_Removed_003Ed__20);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.args = deviceInformationUpdate_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CDeviceWatcher_Updated_003Ed__21))]
	private void eWxtwCqlCIj(DeviceWatcher deviceWatcher_1, DeviceInformationUpdate deviceInformationUpdate_0)
	{
		_003CDeviceWatcher_Updated_003Ed__21 stateMachine = default(_003CDeviceWatcher_Updated_003Ed__21);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	protected override void C5rM2eDjuIN()
	{
		BtrtwvGqbiG();
	}

	static XIGHJKw1eE9po2LdeSn()
	{
		oqHtwPTmc8s = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool H7jW25QF8be03qIHZF4P()
	{
		return cGTBdVQFY2CPh35LHEpb == null;
	}
}
