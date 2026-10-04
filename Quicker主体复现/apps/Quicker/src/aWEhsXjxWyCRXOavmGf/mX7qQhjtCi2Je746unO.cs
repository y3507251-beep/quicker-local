using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMdjedXPwaug8yh9mEq;
using Quicker.Common.QuickActions;
using Quicker.Domain;
using Quicker.Domain.Actions.Runtime;
using Quicker.Domain.Entities;
using Quicker.Domain.QuickActions;
using Quicker.Public.Extensions;
using Quicker.Utilities;

namespace aWEhsXjxWyCRXOavmGf;

internal static class mX7qQhjtCi2Je746unO
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec yC1vQsn99Sw;

		public static Func<KeyActionItem, string> PRwvQHhTiop;

		private static _003C_003Ec AelN4Vcsj0X5pENMZB1b;

		static _003C_003Ec()
		{
			yC1vQsn99Sw = new _003C_003Ec();
		}

		internal string s4YvQGLA7qh(KeyActionItem x)
		{
			return x.BindingProcessName;
		}

		internal static bool cZh772csDcxrEJasDCAK()
		{
			return AelN4Vcsj0X5pENMZB1b == null;
		}

		internal static void OSMXZvcsEQedXsVidVY9()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass12_0
	{
		public Keys LFTvQ6Lb94H;

		public Func<KeyActionItem, bool> rsuvQXHnKvk;

		internal static _003C_003Ec__DisplayClass12_0 nEbBldcsGgMqdKrkLc3b;

		internal void J7FvQ1SrJwa()
		{
			KeyActionItem keyActionItem = AppState.DataService.yQWt6ownR4Z("_global").KeyActionItems?.Where(rsuvQXHnKvk ?? (rsuvQXHnKvk = j2QvQbJDGe9)).OrderByDescending(_003C_003Ec.PRwvQHhTiop ?? (_003C_003Ec.PRwvQHhTiop = _003C_003Ec.yC1vQsn99Sw.s4YvQGLA7qh)).FirstOrDefault();
			if (keyActionItem != null)
			{
				QuickActionRunner.RunQuickActionAsync(AppState.AppServer, keyActionItem.DoubleClickAction, AppState.Y2RtaqSv0AQ(), AppState.AppServer, false, ActionTrigger.TriggerKey, string.Empty);
				AppState.v5FtaQ4hQfg().sVNvgq3htAy();
			}
		}

		internal bool j2QvQbJDGe9(KeyActionItem x)
		{
			if (x.Key == (int)LFTvQ6Lb94H && !x.IsDisabled)
			{
				return brgW8EX9ZVfZExh7q9t.EhutpR97mio(x.BindingProcessName, x.BlackList, AppState.CurrentProcessName, true);
			}
			return false;
		}

		internal static bool lG8W0Pcs02RWovfwDYtf()
		{
			return nEbBldcsGgMqdKrkLc3b == null;
		}
	}

	private static Keys OY2tGqIXsKH;

	[CompilerGenerated]
	private static Keys xgrtGclTxfH;

	[CompilerGenerated]
	private static long OtotGVNJdX3;

	private static bool[] pCdtGZUdcxk;

	internal static object anZVgkQkfTqdv0DvXEag;

	[SpecialName]
	[CompilerGenerated]
	private static void FZBtGyjywi5(Keys keys_2)
	{
		xgrtGclTxfH = keys_2;
	}

	[SpecialName]
	[CompilerGenerated]
	private static void ytPtG7qCaLj(long long_1)
	{
		OtotGVNJdX3 = long_1;
	}

	public static void Refresh()
	{
		Array.Clear(pCdtGZUdcxk, 0, pCdtGZUdcxk.Length);
		foreach (ExeSettings item in AppState.DataService.Q0ltmmbUTMB())
		{
			if (item == null || !item.KeyActionItems.HasData())
			{
				continue;
			}
			foreach (KeyActionItem keyActionItem in item.KeyActionItems)
			{
				if (!keyActionItem.IsDisabled && keyActionItem.DoubleClickAction != null && keyActionItem.DoubleClickAction.ActionType != QuickActionType.None)
				{
					pCdtGZUdcxk[keyActionItem.Key] = true;
				}
			}
		}
	}

	public static void fEutGCoo9fb(Keys keys_2, long? nullable_0 = null)
	{
		OY2tGqIXsKH = keys_2;
	}

	public static void SSQtGP00VJO(Keys keys_2, long? nullable_0 = null)
	{
		_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
		_003C_003Ec__DisplayClass12_.LFTvQ6Lb94H = keys_2;
		if (_003C_003Ec__DisplayClass12_.LFTvQ6Lb94H < (Keys)256 && pCdtGZUdcxk[(int)_003C_003Ec__DisplayClass12_.LFTvQ6Lb94H] && _003C_003Ec__DisplayClass12_.LFTvQ6Lb94H == OY2tGqIXsKH)
		{
			long num = nullable_0 ?? AppHelper.fLiLTj0x4QY();
			if (_003C_003Ec__DisplayClass12_.LFTvQ6Lb94H == xgrtGclTxfH && num - OtotGVNJdX3 < AppState.HHxtaMaoqJr().DoubleClickInterval && num - OtotGVNJdX3 > 20L)
			{
				Task.Run((Action)_003C_003Ec__DisplayClass12_.J7FvQ1SrJwa);
				ytPtG7qCaLj(0L);
			}
			else
			{
				ytPtG7qCaLj(num);
				FZBtGyjywi5(_003C_003Ec__DisplayClass12_.LFTvQ6Lb94H);
			}
		}
		else
		{
			ytPtG7qCaLj(0L);
			OY2tGqIXsKH = Keys.None;
		}
	}

	public static void Reset()
	{
		FZBtGyjywi5(Keys.None);
		OY2tGqIXsKH = Keys.None;
		ytPtG7qCaLj(0L);
	}

	static mX7qQhjtCi2Je746unO()
	{
		pCdtGZUdcxk = new bool[256];
	}

	internal static bool IMgSXlQkbZPIDHFciw2u()
	{
		return anZVgkQkfTqdv0DvXEag == null;
	}
}
