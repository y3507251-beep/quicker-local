using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Quicker.View;

namespace Quicker.Domain.Floating;

public class BtnSnapLinkMgr
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass1_0
	{
		public FloatButtonWindow nfYvBkFJm3p;

		internal static _003C_003Ec__DisplayClass1_0 PxhxarcmyQIeF7dqg9nu;

		internal bool GZhvBWOZSih(BtnSnapLink x)
		{
			return x.Secondary == nfYvBkFJm3p;
		}

		static _003C_003Ec__DisplayClass1_0()
		{
		}

		internal static bool TNKl4hcmpX3dG2cm4633()
		{
			return PxhxarcmyQIeF7dqg9nu == null;
		}

		internal static void B4Y0BUcm2ucd9nV0uSPE()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass3_0
	{
		public FloatButtonWindow hCwvBsAEtMo;

		private static _003C_003Ec__DisplayClass3_0 qcy1THcmA3qtyCX2EI3v;

		internal bool AFxvBGNtHlA(BtnSnapLink x)
		{
			if (x.Primary != hCwvBsAEtMo)
			{
				return x.Secondary == hCwvBsAEtMo;
			}
			return true;
		}

		internal static bool yhjKj9cmnHxYO3Sv5CiY()
		{
			return qcy1THcmA3qtyCX2EI3v == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass4_0
	{
		public FloatButtonWindow wylvB1Tj9vw;

		private static _003C_003Ec__DisplayClass4_0 b3j1BZcmjDwdspGZ4FIZ;

		internal bool pEuvBHNJdaH(BtnSnapLink x)
		{
			return x.Secondary == wylvB1Tj9vw;
		}

		internal static bool q1wj2dcmDciuXPt5H3Hh()
		{
			return b3j1BZcmjDwdspGZ4FIZ == null;
		}
	}

	private readonly List<BtnSnapLink> E3ItWvBkFFf = new List<BtnSnapLink>();

	private static BtnSnapLinkMgr Ca9wYHQJKaVpqrsaSKkd;

	public List<BtnSnapLink> Links => E3ItWvBkFFf;

	public void AddLink(SnapLinkType type, FloatButtonWindow primaryBtn, FloatButtonWindow secondaryBtn)
	{
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
		_003C_003Ec__DisplayClass1_.nfYvBkFJm3p = secondaryBtn;
		E3ItWvBkFFf.RemoveAll(_003C_003Ec__DisplayClass1_.GZhvBWOZSih);
		E3ItWvBkFFf.Add(new BtnSnapLink
		{
			LinkType = type,
			Primary = primaryBtn,
			Secondary = _003C_003Ec__DisplayClass1_.nfYvBkFJm3p
		});
		N3HtWLedBTq();
	}

	private void N3HtWLedBTq()
	{
	}

	public void RemoveButton(FloatButtonWindow btn)
	{
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
		_003C_003Ec__DisplayClass3_.hCwvBsAEtMo = btn;
		E3ItWvBkFFf.RemoveAll(_003C_003Ec__DisplayClass3_.AFxvBGNtHlA);
		N3HtWLedBTq();
	}

	public void RemoveButtonPrimaryLinks(FloatButtonWindow btn)
	{
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
		_003C_003Ec__DisplayClass4_.wylvB1Tj9vw = btn;
		E3ItWvBkFFf.RemoveAll(_003C_003Ec__DisplayClass4_.pEuvBHNJdaH);
		N3HtWLedBTq();
	}

	public void AddLink(BtnSnapLink snapLink)
	{
		RemoveButtonPrimaryLinks(snapLink.Secondary);
		E3ItWvBkFFf.Add(snapLink);
		N3HtWLedBTq();
	}

	public bool IsFollowing(FloatButtonWindow btnA, FloatButtonWindow btnB)
	{
		foreach (BtnSnapLink item in E3ItWvBkFFf)
		{
			if (Ca9wYHQJKaVpqrsaSKkd != null)
			{
				switch (0)
				{
				}
			}
			if (item.Primary == btnA)
			{
				if (item.Secondary == btnB)
				{
					return true;
				}
				if (IsFollowing(item.Secondary, btnB))
				{
					return true;
				}
			}
		}
		return false;
	}

	internal static bool KciWCRQJBLnU5X5VHgou()
	{
		return Ca9wYHQJKaVpqrsaSKkd == null;
	}
}
