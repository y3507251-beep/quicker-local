using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Linearstar.Windows.RawInput.Native;

namespace Linearstar.Windows.RawInput;

public class HidValueSet : IEnumerable, IEnumerable<HidValue>
{
	[CompilerGenerated]
	private sealed class _003CGetEnumerator_003Ed__22 : IDisposable, IEnumerator<HidValue>, IEnumerator
	{
		private int _003C_003E1__state;

		private HidValue _003C_003E2__current;

		public HidValueSet _003C_003E4__this;

		private ushort _003Cusage_003E5__2;

		private static _003CGetEnumerator_003Ed__22 M8QqUDcdIjPaX13kZSjb;

		HidValue IEnumerator<HidValue>.Current
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
		public _003CGetEnumerator_003Ed__22(int _003C_003E1__state)
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
			HidValueSet hidValueSet = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 1:
			{
				_003C_003E1__state = -1;
				int num2 = 0;
				if (M8QqUDcdIjPaX13kZSjb != null)
				{
					int num3 = default(int);
					num2 = num3;
				}
				switch (num2)
				{
				}
				_003Cusage_003E5__2++;
				break;
			}
			case 0:
				_003C_003E1__state = -1;
				_003Cusage_003E5__2 = hidValueSet.hYCkl4kmkT.Range.UsageMin;
				break;
			}
			if (_003Cusage_003E5__2 > hidValueSet.hYCkl4kmkT.Range.UsageMax)
			{
				return false;
			}
			_003C_003E2__current = new HidValue(hidValueSet.QBqkUydNb6, hidValueSet.hYCkl4kmkT, _003Cusage_003E5__2);
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

		internal static bool s4MZ1Ucd6knVUmqLaIHK()
		{
			return M8QqUDcdIjPaX13kZSjb == null;
		}
	}

	internal readonly HidReader QBqkUydNb6;

	internal readonly HidPValueCaps hYCkl4kmkT;

	private static HidValueSet LrAAbIqfZncov7Gin5k;

	public int ReportId => hYCkl4kmkT.ReportID;

	public int ReportCount => hYCkl4kmkT.ReportCount;

	public int ValueCount => hYCkl4kmkT.Range.UsageMax - hYCkl4kmkT.Range.UsageMin + 1;

	public ushort UsagePage => hYCkl4kmkT.UsagePage;

	public ushort UsageMin => hYCkl4kmkT.Range.UsageMin;

	public ushort UsageMax => hYCkl4kmkT.Range.UsageMax;

	public HidUsageAndPage LinkUsageAndPage => new HidUsageAndPage(hYCkl4kmkT.LinkUsagePage, hYCkl4kmkT.LinkUsage);

	public int LinkCollection => hYCkl4kmkT.LinkCollection;

	internal HidValueSet(HidReader reader, HidPValueCaps valueCaps)
	{
		QBqkUydNb6 = reader;
		hYCkl4kmkT = valueCaps;
	}

	public HidValueSetState GetStates(ArraySegment<byte> report)
	{
		return GetStates(report.ToArray(), report.Count);
	}

	public HidValueSetState GetStates(byte[] report, int reportLength)
	{
		return new HidValueSetState(this, report, reportLength);
	}

	public override string ToString()
	{
		return $"{ReportId}, {LinkCollection}, Link: {{{LinkUsageAndPage}}}, UsagePage: {{{UsagePage}}}, Count: {ValueCount}";
	}

	[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__22))]
	public IEnumerator<HidValue> GetEnumerator()
	{
		return new _003CGetEnumerator_003Ed__22(0)
		{
			_003C_003E4__this = this
		};
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	internal static bool a8e4lfqbOIJn14LxE7s()
	{
		return LrAAbIqfZncov7Gin5k == null;
	}
}
