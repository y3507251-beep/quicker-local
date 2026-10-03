using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quicker.Common.Entities;
using Quicker.Domain;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Public.Forms;
using Quicker.Utilities;
using Quicker.Utilities.Hooks;
using WindowsInput.Native;
using YDnFyFwG4PlN0Cedwny;

namespace zOiWIIwJdlJ0kZHdkY2;

internal class XwejR1wKkVTKEoL89HT : kWjRPcwItwkeAamARyg
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass12_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct i628hbHvq4VgyUNI2tS : IAsyncStateMachine
		{
			public int BbP2aZtc3A8;

			public AsyncTaskMethodBuilder Rtp2a9YtNyY;

			public _003C_003Ec__DisplayClass12_0 hbB2ahHCOCN;

			private TaskAwaiter hr82aemBrf9;

			internal static object TX832DyLcIkg3RGcIF99;

			private void MoveNext()
			{
				int num = BbP2aZtc3A8;
				_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = hbB2ahHCOCN;
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Delay(50).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							BbP2aZtc3A8 = 0;
							hr82aemBrf9 = awaiter;
							Rtp2a9YtNyY.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							if (TX832DyLcIkg3RGcIF99 == null)
							{
								switch (0)
								{
								}
							}
							return;
						}
					}
					else
					{
						awaiter = hr82aemBrf9;
						hr82aemBrf9 = default(TaskAwaiter);
						num = -1;
						BbP2aZtc3A8 = -1;
					}
					awaiter.GetResult();
					bool flag;
					if ((flag = KeyboardHelper.IsKeyLocked((VirtualKeyCode)_003C_003Ec__DisplayClass12_.Q1cvIDuuUlt.KeyCode)) != _003C_003Ec__DisplayClass12_.PALvIdRF47K)
					{
						Dictionary<string, object> idictionary_ = new Dictionary<string, object>
						{
							{
								"KeyCode",
								(_003C_003Ec__DisplayClass12_.Q1cvIDuuUlt.KeyCode == Keys.Capital) ? "CapsLock" : _003C_003Ec__DisplayClass12_.Q1cvIDuuUlt.KeyCode.ToString()
							},
							{
								"KeyValue",
								_003C_003Ec__DisplayClass12_.Q1cvIDuuUlt.KeyValue
							},
							{ "IsLocked", flag }
						};
						IEnumerator<CommonTriggerTask> enumerator = _003C_003Ec__DisplayClass12_.nlyvIo8d4yS.jpqtg8Grl0b.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								CommonTriggerTask current = enumerator.Current;
								int num2 = current.TryGetParamValue("Key", 0);
								if ((num2 == 0 || num2 == _003C_003Ec__DisplayClass12_.Q1cvIDuuUlt.KeyValue) && _003C_003Ec__DisplayClass12_.nlyvIo8d4yS.iJ2tguv8HCS(current, idictionary_) && current.SkipFurtherTasks)
								{
									break;
								}
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
				}
				catch (Exception exception)
				{
					BbP2aZtc3A8 = -2;
					Rtp2a9YtNyY.SetException(exception);
					return;
				}
				BbP2aZtc3A8 = -2;
				Rtp2a9YtNyY.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				Rtp2a9YtNyY.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool j8sYCByLWv8qbyDYovQi()
			{
				return TX832DyLcIkg3RGcIF99 == null;
			}
		}

		public HookKeyEventArgs Q1cvIDuuUlt;

		public bool PALvIdRF47K;

		public XwejR1wKkVTKEoL89HT nlyvIo8d4yS;

		private static _003C_003Ec__DisplayClass12_0 HaxI3McZuRb9RTQUyoW8;

		internal bool voVvI4OUiYC(CommonTriggerTask x)
		{
			int num = x.TryGetParamValue("Key", 0);
			if (num != 0)
			{
				return num == Q1cvIDuuUlt.KeyValue;
			}
			return true;
		}

		[AsyncStateMachine(typeof(i628hbHvq4VgyUNI2tS))]
		internal Task VhGvI5j10Nv()
		{
			i628hbHvq4VgyUNI2tS stateMachine = default(i628hbHvq4VgyUNI2tS);
			stateMachine.Rtp2a9YtNyY = AsyncTaskMethodBuilder.Create();
			stateMachine.hbB2ahHCOCN = this;
			stateMachine.BbP2aZtc3A8 = -1;
			stateMachine.Rtp2a9YtNyY.Start(ref stateMachine);
			return stateMachine.Rtp2a9YtNyY.Task;
		}

		internal static bool osF6QtcZoVevUekGKpxN()
		{
			return HaxI3McZuRb9RTQUyoW8 == null;
		}
	}

	[CompilerGenerated]
	private readonly IDictionary<string, string> lL7ttsMEHwd = new Dictionary<string, string> { { "KeyToggled", "按键锁定状态切换" } };

	private FormField XwLttH26M1w = new FormField
	{
		FieldKey = "Key",
		Label = "按键",
		DictVarType = VarType.Enum,
		HelpText = "关注的按键。",
		IsRequired = false,
		InputMethod = InputMethod.DropDown,
		SelectionItems = $"任意|0\r\nCapsLock|{20}\r\n{Keys.NumLock}|{144}\r\n{Keys.Scroll}|{145}\r\n",
		DefaultValue = 0
	};

	internal static XwejR1wKkVTKEoL89HT oqZmcTQcNskobDT8wUMZ;

	[SpecialName]
	[CompilerGenerated]
	protected override IDictionary<string, string> OVPM2wsWcIu()
	{
		return lL7ttsMEHwd;
	}

	public override IList<FormField> odUM2hmvkik(string string_1)
	{
		return new FormField[1] { XwLttH26M1w };
	}

	public override IList<ActionVariable> VrkM2LPKH4P(string string_1)
	{
		return new List<ActionVariable>
		{
			new ActionVariable
			{
				Key = "KeyCode",
				Desc = $"键名 CapsLock/NumLock/{Keys.Scroll}",
				Type = VarType.Text
			},
			new ActionVariable
			{
				Key = "KeyValue",
				Desc = "键值数字",
				Type = VarType.Integer
			},
			new ActionVariable
			{
				Key = "IsLocked",
				Desc = "是否锁定",
				Type = VarType.Boolean
			}
		};
	}

	public XwejR1wKkVTKEoL89HT()
		: base(new string[1] { "KeyToggled" })
	{
	}

	protected override void fb3M2Rxtx1E()
	{
		znPttkbyvk3();
		AppState.v5FtaQ4hQfg().uN4vLlBPsmq(HgYttGpuZTc);
	}

	protected override void C5rM2eDjuIN()
	{
		znPttkbyvk3();
	}

	private void znPttkbyvk3()
	{
		AppState.v5FtaQ4hQfg().bF0vLiBclyH(HgYttGpuZTc);
	}

	private void HgYttGpuZTc(object sender, HookKeyEventArgs e)
	{
		_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
		_003C_003Ec__DisplayClass12_.Q1cvIDuuUlt = e;
		_003C_003Ec__DisplayClass12_.nlyvIo8d4yS = this;
		if (jpqtg8Grl0b.Any(_003C_003Ec__DisplayClass12_.voVvI4OUiYC))
		{
			_003C_003Ec__DisplayClass12_.PALvIdRF47K = KeyboardHelper.IsKeyLocked((VirtualKeyCode)_003C_003Ec__DisplayClass12_.Q1cvIDuuUlt.KeyCode);
			Task.Run((Func<Task>)_003C_003Ec__DisplayClass12_.VhGvI5j10Nv);
		}
	}

	internal static bool pJW4v3Qc91dX4rTvJsqa()
	{
		return oqZmcTQcNskobDT8wUMZ == null;
	}
}
