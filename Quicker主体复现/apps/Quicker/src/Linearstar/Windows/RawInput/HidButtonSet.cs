using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Linearstar.Windows.RawInput.Native;

namespace Linearstar.Windows.RawInput;

public class HidButtonSet : IEnumerable<HidButton>, IEnumerable
{
	[CompilerGenerated]
	private sealed class _003CGetEnumerator_003Ed__20 : IDisposable, IEnumerator<HidButton>, IEnumerator
	{
		private int _003C_003E1__state;

		private HidButton _003C_003E2__current;

		public HidButtonSet _003C_003E4__this;

		private ushort _003Cusage_003E5__2;

		private static _003CGetEnumerator_003Ed__20 pbX08xcdRMXyFDfxWSoO;

		HidButton IEnumerator<HidButton>.Current
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
		public _003CGetEnumerator_003Ed__20(int _003C_003E1__state)
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
			HidButtonSet hidButtonSet = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 1:
				_003C_003E1__state = -1;
				_003Cusage_003E5__2++;
				break;
			case 0:
				_003C_003E1__state = -1;
				_003Cusage_003E5__2 = hidButtonSet.MjZkHLrnbg.Range.UsageMin;
				break;
			}
			if (_003Cusage_003E5__2 > hidButtonSet.MjZkHLrnbg.Range.UsageMax)
			{
				return false;
			}
			_003C_003E2__current = new HidButton(hidButtonSet.N6wkshw39S, hidButtonSet.MjZkHLrnbg, _003Cusage_003E5__2);
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

		internal static bool sICbl9cdgVHleBxHWjLe()
		{
			return pbX08xcdRMXyFDfxWSoO == null;
		}
	}

	internal readonly HidReader N6wkshw39S;

	internal readonly HidPButtonCaps MjZkHLrnbg;

	internal static HidButtonSet u56TAyqnHVkEhqkShqs;

	public int ReportId => MjZkHLrnbg.ReportID;

	public int ButtonCount => MjZkHLrnbg.Range.UsageMax - MjZkHLrnbg.Range.UsageMin + 1;

	public ushort UsagePage => MjZkHLrnbg.UsagePage;

	public ushort UsageMin => MjZkHLrnbg.Range.UsageMin;

	public ushort UsageMax => MjZkHLrnbg.Range.UsageMax;

	public HidUsageAndPage LinkUsageAndPage => new HidUsageAndPage(MjZkHLrnbg.LinkUsagePage, MjZkHLrnbg.LinkUsage);

	public int LinkCollection => MjZkHLrnbg.LinkCollection;

	internal HidButtonSet(HidReader reader, HidPButtonCaps buttonCaps)
	{
		N6wkshw39S = reader;
		MjZkHLrnbg = buttonCaps;
	}

	public HidButtonSetState GetStates(ArraySegment<byte> report)
	{
		return GetStates(report.ToArray(), report.Count);
	}

	public HidButtonSetState GetStates(byte[] report, int reportLength)
	{
		return new HidButtonSetState(this, report, reportLength);
	}

	public override string ToString()
	{
		return $"{ReportId}, {LinkCollection}, Link: {{{LinkUsageAndPage}}}, UsagePage: {{{UsagePage}}}, Count: {ButtonCount}";
	}

	[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__20))]
	public IEnumerator<HidButton> GetEnumerator()
	{
		return new _003CGetEnumerator_003Ed__20(0)
		{
			_003C_003E4__this = this
		};
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	internal static bool SCGPn0qelOmmtYGyjkf()
	{
		return u56TAyqnHVkEhqkShqs == null;
	}
}
