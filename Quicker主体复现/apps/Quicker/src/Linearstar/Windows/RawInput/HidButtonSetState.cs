using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Linearstar.Windows.RawInput.Native;

namespace Linearstar.Windows.RawInput;

public class HidButtonSetState : IEnumerable<HidButtonState>, IEnumerable
{
	[CompilerGenerated]
	private sealed class _003CGetEnumerator_003Ed__9 : IDisposable, IEnumerator<HidButtonState>, IEnumerator
	{
		private int _003C_003E1__state;

		private HidButtonState _003C_003E2__current;

		public HidButtonSetState _003C_003E4__this;

		private ushort _003Cusage_003E5__2;

		internal static _003CGetEnumerator_003Ed__9 T4KE3scdMFY0cAYuGR8V;

		HidButtonState IEnumerator<HidButtonState>.Current
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
		public _003CGetEnumerator_003Ed__9(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			HidButtonSetState hidButtonSetState = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 1:
			{
				_003C_003E1__state = -1;
				ushort num2 = _003Cusage_003E5__2;
				int num3 = 0;
				if (T4KE3scdMFY0cAYuGR8V != null)
				{
					int num4 = default(int);
					num3 = num4;
				}
				switch (num3)
				{
				}
				_003Cusage_003E5__2 = (ushort)(num2 + 1);
				break;
			}
			case 0:
				_003C_003E1__state = -1;
				_003Cusage_003E5__2 = hidButtonSetState.ButtonSet.UsageMin;
				break;
			}
			if (_003Cusage_003E5__2 > hidButtonSetState.ButtonSet.UsageMax)
			{
				return false;
			}
			_003C_003E2__current = new HidButtonState(new HidButton(hidButtonSetState.ButtonSet.N6wkshw39S, hidButtonSetState.ButtonSet.MjZkHLrnbg, _003Cusage_003E5__2), hidButtonSetState.eGEk1UHgFg, hidButtonSetState.U5qkb2dIuX);
			_003C_003E1__state = 1;
			return true;
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

		internal static bool lGQSDicdU7sLmeP1Fy19()
		{
			return T4KE3scdMFY0cAYuGR8V == null;
		}
	}

	private readonly byte[] eGEk1UHgFg;

	private readonly int U5qkb2dIuX;

	[CompilerGenerated]
	private readonly HidButtonSet Ipjk6U7NtC;

	internal static HidButtonSetState ItlvxgqDD1kAi6SnOHd;

	public HidButtonSet ButtonSet
	{
		[CompilerGenerated]
		get
		{
			return Ipjk6U7NtC;
		}
	}

	public ushort[] ActiveUsages
	{
		get
		{
			using HidPreparsedDataPtr hidPreparsedDataPtr = ButtonSet.N6wkshw39S.FwBkpWOFtC();
			return HidP.GetUsages(hidPreparsedDataPtr, HidPReportType.Input, ButtonSet.MjZkHLrnbg, eGEk1UHgFg, U5qkb2dIuX);
		}
	}

	internal HidButtonSetState(HidButtonSet buttonSet, byte[] report, int reportLength)
	{
		Ipjk6U7NtC = buttonSet;
		eGEk1UHgFg = report;
		U5qkb2dIuX = reportLength;
	}

	public override string ToString()
	{
		return string.Format("ButtonSet: {{{0}}}, Active: [{1}]", ButtonSet, string.Join(", ", ActiveUsages));
	}

	[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__9))]
	public IEnumerator<HidButtonState> GetEnumerator()
	{
		return new _003CGetEnumerator_003Ed__9(0)
		{
			_003C_003E4__this = this
		};
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	internal static bool l9RkOGq3Use0p8CuBXx()
	{
		return ItlvxgqDD1kAi6SnOHd == null;
	}
}
