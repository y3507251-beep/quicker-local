using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Quicker.Utilities;
using WindowsInput;
using WindowsInput.Native;

namespace Quicker.View.Hotkeys;

public class Hotkey
{
	[CompilerGenerated]
	private sealed class _003CGetModifierKeyCodes_003Ed__12 : IDisposable, IEnumerable, IEnumerator, IEnumerable<VirtualKeyCode>, IEnumerator<VirtualKeyCode>
	{
		private int _003C_003E1__state;

		private VirtualKeyCode _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public Hotkey _003C_003E4__this;

		internal static _003CGetModifierKeyCodes_003Ed__12 R2uy0kWUCwutL1oMZ8H6;

		VirtualKeyCode IEnumerator<VirtualKeyCode>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public _003CGetModifierKeyCodes_003Ed__12(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			Hotkey hotkey = _003C_003E4__this;
			int num2;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				if (!hotkey.Modifiers.HasFlag(ModifierKeys.Control))
				{
					goto IL_006d;
				}
				num2 = 0;
				if (!QGrYImWU700OuwI8tVCD())
				{
					int num3 = default(int);
					num2 = num3;
				}
				goto IL_010f;
			case 1:
				_003C_003E1__state = -1;
				goto IL_006d;
			case 2:
				_003C_003E1__state = -1;
				goto IL_009e;
			case 3:
				_003C_003E1__state = -1;
				goto IL_00cf;
			case 4:
				{
					_003C_003E1__state = -1;
					num2 = 1;
					if (QGrYImWU700OuwI8tVCD())
					{
						break;
					}
					goto IL_010f;
				}
				IL_009e:
				if (hotkey.Modifiers.HasFlag(ModifierKeys.Shift))
				{
					_003C_003E2__current = VirtualKeyCode.SHIFT;
					_003C_003E1__state = 3;
					return true;
				}
				goto IL_00cf;
				IL_010f:
				switch (num2)
				{
				default:
					_003C_003E2__current = VirtualKeyCode.CONTROL;
					_003C_003E1__state = 1;
					return true;
				case 1:
					break;
				}
				break;
				IL_006d:
				if (hotkey.Modifiers.HasFlag(ModifierKeys.Alt))
				{
					_003C_003E2__current = VirtualKeyCode.MENU;
					_003C_003E1__state = 2;
					return true;
				}
				goto IL_009e;
				IL_00cf:
				if (hotkey.Modifiers.HasFlag(ModifierKeys.Windows))
				{
					_003C_003E2__current = VirtualKeyCode.LWIN;
					_003C_003E1__state = 4;
					return true;
				}
				break;
			}
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator<VirtualKeyCode> IEnumerable<VirtualKeyCode>.GetEnumerator()
		{
			_003CGetModifierKeyCodes_003Ed__12 result;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				result = this;
			}
			else
			{
				result = new _003CGetModifierKeyCodes_003Ed__12(0)
				{
					_003C_003E4__this = _003C_003E4__this
				};
			}
			return result;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<VirtualKeyCode>)this).GetEnumerator();
		}

		internal static bool QGrYImWU700OuwI8tVCD()
		{
			return R2uy0kWUCwutL1oMZ8H6 == null;
		}
	}

	[CompilerGenerated]
	private readonly VirtualKeyCode UfFLvEwbfOj;

	[CompilerGenerated]
	private readonly ModifierKeys wV0LvyZAnOw;

	internal static Hotkey XXoPKWFnV9NN7UYFJAiJ;

	public VirtualKeyCode Key
	{
		[CompilerGenerated]
		get
		{
			return UfFLvEwbfOj;
		}
	}

	public ModifierKeys Modifiers
	{
		[CompilerGenerated]
		get
		{
			return wV0LvyZAnOw;
		}
	}

	public Hotkey(VirtualKeyCode key, ModifierKeys modifiers)
	{
		UfFLvEwbfOj = key;
		wV0LvyZAnOw = modifiers;
	}

	public Hotkey(string data)
	{
		string[] array = data.Split('|');
		if (array.Length != 2)
		{
			return;
		}
		try
		{
			wV0LvyZAnOw = (ModifierKeys)Enum.ToObject(typeof(ModifierKeys), Convert.ToUInt32(array[0], CultureInfo.InvariantCulture));
			UfFLvEwbfOj = (VirtualKeyCode)Convert.ToInt32(array[1], CultureInfo.InvariantCulture);
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("解析快捷键失败：" + data + " " + ex.Message);
		}
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (Modifiers.HasFlag(ModifierKeys.Control))
		{
			stringBuilder.Append("Ctrl + ");
		}
		if (Modifiers.HasFlag(ModifierKeys.Shift))
		{
			stringBuilder.Append("Shift + ");
		}
		if (Modifiers.HasFlag(ModifierKeys.Alt))
		{
			stringBuilder.Append("Alt + ");
		}
		if (!Modifiers.HasFlag(ModifierKeys.Windows))
		{
			if (XXoPKWFnV9NN7UYFJAiJ == null)
			{
				switch (0)
				{
				}
			}
		}
		else
		{
			stringBuilder.Append("Win + ");
		}
		stringBuilder.Append(KeyboardHelper.GetKeyName(Key));
		return stringBuilder.ToString();
	}

	public override bool Equals(object obj)
	{
		if (obj is Hotkey hotkey)
		{
			if (hotkey.Key == Key)
			{
				return hotkey.Modifiers == Modifiers;
			}
			return false;
		}
		return base.Equals(obj);
	}

	public string ToData()
	{
		return $"{(uint)Modifiers}|{(int)Key}";
	}

	public static string DataToString(string data)
	{
		if (string.IsNullOrEmpty(data))
		{
			return string.Empty;
		}
		return new Hotkey(data).ToString();
	}

	[IteratorStateMachine(typeof(_003CGetModifierKeyCodes_003Ed__12))]
	public IEnumerable<VirtualKeyCode> GetModifierKeyCodes()
	{
		return new _003CGetModifierKeyCodes_003Ed__12(-2)
		{
			_003C_003E4__this = this
		};
	}

	public void SimulateInput()
	{
		VirtualKeyCode[] modifierKeyCodes = GetModifierKeyCodes().ToArray();
		InputSimulator.Instance.Keyboard.ModifiedKeyStroke(modifierKeyCodes, Key, AppHelper.kPoLTdWFLA7());
	}

	internal static bool LmGHYVFnQ7M2qGfsBqjR()
	{
		return XXoPKWFnV9NN7UYFJAiJ == null;
	}
}
