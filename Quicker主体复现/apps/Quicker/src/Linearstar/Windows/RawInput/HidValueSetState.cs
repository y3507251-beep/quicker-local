using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Linearstar.Windows.RawInput;

public class HidValueSetState : IEnumerable, IEnumerable<HidValueState>
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec gHKv71aVF2P;

		public static Func<HidValueState, int> Nqhv7bbP9oV;

		public static Func<HidValueState, int?> Dfdv76neGP8;

		internal static _003C_003Ec u53TCCcdSer28NS8brll;

		static _003C_003Ec()
		{
			gHKv71aVF2P = new _003C_003Ec();
		}

		internal int rj0v7sare4R(HidValueState x)
		{
			return x.CurrentValue;
		}

		internal int? mfHv7H4AKhd(HidValueState x)
		{
			return x.ScaledValue;
		}

		internal static bool PLPoC0cdwZGkieGsBRWx()
		{
			return u53TCCcdSer28NS8brll == null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetEnumerator_003Ed__11 : IDisposable, IEnumerator, IEnumerator<HidValueState>
	{
		private int _003C_003E1__state;

		private HidValueState _003C_003E2__current;

		public HidValueSetState _003C_003E4__this;

		private ushort _003Cusage_003E5__2;

		internal static _003CGetEnumerator_003Ed__11 fNJ2XWcdmndTqZ4fUEtl;

		HidValueState IEnumerator<HidValueState>.Current
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
		public _003CGetEnumerator_003Ed__11(int _003C_003E1__state)
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
			HidValueSetState hidValueSetState = _003C_003E4__this;
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
				_003Cusage_003E5__2 = hidValueSetState.ValueSet.UsageMin;
				break;
			}
			if (_003Cusage_003E5__2 <= hidValueSetState.ValueSet.UsageMax)
			{
				_003C_003E2__current = new HidValueState(new HidValue(hidValueSetState.ValueSet.QBqkUydNb6, hidValueSetState.ValueSet.hYCkl4kmkT, _003Cusage_003E5__2), hidValueSetState.cxZkib8V1J, hidValueSetState.zQtk3ZDZlW);
				_003C_003E1__state = 1;
				return true;
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

		internal static bool NakhRqcdsEkWxcr73pYL()
		{
			return fNJ2XWcdmndTqZ4fUEtl == null;
		}
	}

	private readonly byte[] cxZkib8V1J;

	private readonly int zQtk3ZDZlW;

	[CompilerGenerated]
	private readonly HidValueSet ew8kfx2I2i;

	internal static HidValueSetState cFLVOIqi01TfRgIq0EO;

	public HidValueSet ValueSet
	{
		[CompilerGenerated]
		get
		{
			return ew8kfx2I2i;
		}
	}

	public int[] CurrentValues => this.Select(_003C_003Ec.Nqhv7bbP9oV ?? (_003C_003Ec.Nqhv7bbP9oV = _003C_003Ec.gHKv71aVF2P.rj0v7sare4R)).ToArray();

	public int?[] ScaledValues => this.Select(_003C_003Ec.Dfdv76neGP8 ?? (_003C_003Ec.Dfdv76neGP8 = _003C_003Ec.gHKv71aVF2P.mfHv7H4AKhd)).ToArray();

	internal HidValueSetState(HidValueSet valueSet, byte[] report, int reportLength)
	{
		ew8kfx2I2i = valueSet;
		cxZkib8V1J = report;
		zQtk3ZDZlW = reportLength;
	}

	public override string ToString()
	{
		return string.Format("ValueSet: {{{0}}}, CurrentValues: [{1}]", ValueSet, string.Join(", ", CurrentValues));
	}

	[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__11))]
	public IEnumerator<HidValueState> GetEnumerator()
	{
		return new _003CGetEnumerator_003Ed__11(0)
		{
			_003C_003E4__this = this
		};
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	internal static bool Jc8h2YqlxXJrZL9Hi7M()
	{
		return cFLVOIqi01TfRgIq0EO == null;
	}
}
