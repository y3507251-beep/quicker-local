using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Linearstar.Windows.RawInput.Native;

namespace Linearstar.Windows.RawInput;

public class RawInputDigitizerData : RawInputHidData
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec nirv73W48ht;

		public static Func<HidButtonSetState, IEnumerable<HidButtonState>> xjXv7fnFNgs;

		public static Func<HidButtonState, int> OjOv7zk3XJY;

		public static Func<HidValueSetState, IEnumerable<HidValueState>> eRYvRwr6oMH;

		public static Func<HidValueState, int> J8IvRtrC9c3;

		public static Func<HidValueSetState, IEnumerable<HidValueState>> zYOvRg6lYA1;

		private static _003C_003Ec lI7EapcOARaMBlfhQWN0;

		static _003C_003Ec()
		{
			nirv73W48ht = new _003C_003Ec();
		}

		internal IEnumerable<HidButtonState> Yxpv7ObphKC(HidButtonSetState x)
		{
			return x;
		}

		internal int WBcv7Fq0odv(HidButtonState x)
		{
			return x.Button.LinkCollection;
		}

		internal IEnumerable<HidValueState> FaRv7UkoaBG(HidValueSetState x)
		{
			return x;
		}

		internal int FCdv7lVvF6X(HidValueState x)
		{
			return x.Value.LinkCollection;
		}

		internal IEnumerable<HidValueState> gAev7iddgxH(HidValueSetState x)
		{
			return x;
		}

		internal static bool sLYwdLcOnUmno173Zk6V()
		{
			return lI7EapcOARaMBlfhQWN0 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass3_0
	{
		public RawInputDigitizer tbivRuO785A;

		public ILookup<int, HidValueState> cWLvRNChcgU;

		internal static _003C_003Ec__DisplayClass3_0 hErtvkcOjEfmgEtqAxoP;

		internal bool laNvRLKNB0J(HidButtonState x)
		{
			return x.Button.LinkUsageAndPage != tbivRuO785A.UsageAndPage;
		}

		internal bool qRyvRv9MmO7(HidValueState x)
		{
			return x.Value.LinkUsageAndPage != tbivRuO785A.UsageAndPage;
		}

		internal bool hU0vRSmPtNB(HidValueState x)
		{
			if (x.Value.LinkUsageAndPage == tbivRuO785A.UsageAndPage)
			{
				return x.Value.UsageAndPage == RawInputDigitizer.UsageContactCount;
			}
			return false;
		}

		internal RawInputDigitizerContact hV1vR2g8WYP(IGrouping<int, HidButtonState> buttonStates)
		{
			return new RawInputDigitizerContact(buttonStates, cWLvRNChcgU[buttonStates.Key]);
		}

		internal static bool qkFMnMcODcGiJg8XdtUt()
		{
			return hErtvkcOjEfmgEtqAxoP == null;
		}
	}

	[CompilerGenerated]
	private readonly RawInputDigitizerContact[] eTPG64fXjB;

	internal static RawInputDigitizerData Loge3fij5p2wUN6XRQg;

	public RawInputDigitizerContact[] Contacts
	{
		[CompilerGenerated]
		get
		{
			return eTPG64fXjB;
		}
	}

	public RawInputDigitizerData(RawInputHeader header, RawHid hid)
		: base(header, hid)
	{
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
		_003C_003Ec__DisplayClass3_.tbivRuO785A = (RawInputDigitizer)base.Device;
		ILookup<int, HidButtonState> source = base.ButtonSetStates.SelectMany(_003C_003Ec.xjXv7fnFNgs ?? (_003C_003Ec.xjXv7fnFNgs = _003C_003Ec.nirv73W48ht.Yxpv7ObphKC)).Where(_003C_003Ec__DisplayClass3_.laNvRLKNB0J).ToLookup(_003C_003Ec.OjOv7zk3XJY ?? (_003C_003Ec.OjOv7zk3XJY = _003C_003Ec.nirv73W48ht.WBcv7Fq0odv));
		_003C_003Ec__DisplayClass3_.cWLvRNChcgU = base.ValueSetStates.SelectMany(_003C_003Ec.eRYvRwr6oMH ?? (_003C_003Ec.eRYvRwr6oMH = _003C_003Ec.nirv73W48ht.FaRv7UkoaBG)).Where(_003C_003Ec__DisplayClass3_.qRyvRv9MmO7).ToLookup(_003C_003Ec.J8IvRtrC9c3 ?? (_003C_003Ec.J8IvRtrC9c3 = _003C_003Ec.nirv73W48ht.FCdv7lVvF6X));
		int count = base.ValueSetStates.SelectMany(_003C_003Ec.zYOvRg6lYA1 ?? (_003C_003Ec.zYOvRg6lYA1 = _003C_003Ec.nirv73W48ht.gAev7iddgxH)).FirstOrDefault(_003C_003Ec__DisplayClass3_.hU0vRSmPtNB)?.CurrentValue ?? 1;
		eTPG64fXjB = source.Select(_003C_003Ec__DisplayClass3_.hV1vR2g8WYP).Take(count).ToArray();
	}

	internal static bool fqeS6NiDSKYVdgoTfOq()
	{
		return Loge3fij5p2wUN6XRQg == null;
	}
}
