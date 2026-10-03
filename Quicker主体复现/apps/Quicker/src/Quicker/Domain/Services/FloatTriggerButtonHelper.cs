using System;
using System.Linq;
using System.Runtime.CompilerServices;
using HandyControl.Controls;
using Quicker.Utilities;
using Quicker.Utilities.UI.Behaviors;
using Quicker.View.UI;
using ViNASxihuuLY1Gg9m6p;

namespace Quicker.Domain.Services;

public static class FloatTriggerButtonHelper
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec muwvjVACm4s;

		public static Func<Sprite, bool> d9nvjZQdplh;

		private static _003C_003Ec dCaUwIcC9HdGL6FbC6we;

		static _003C_003Ec()
		{
			muwvjVACm4s = new _003C_003Ec();
		}

		internal bool j11vjcMd5Uj(Sprite x)
		{
			if (x.Tag is string a)
			{
				return string.Equals(a, d9etHcB3lK9, StringComparison.OrdinalIgnoreCase);
			}
			return false;
		}

		internal static bool k9killcCLnNIwuQiccLI()
		{
			return dCaUwIcC9HdGL6FbC6we == null;
		}
	}

	private static string d9etHcB3lK9;

	internal static object AJND3WQaMv2kBVpuTHx6;

	public static bool MoveToCursorPosition()
	{
		Sprite sprite = Dq1tHqfCylZ();
		if (sprite != null)
		{
			IHNRIiikxBwJdYmHpM3.p1AvvooEqum(sprite, ShowWindowLocation.WithMouse1);
			return true;
		}
		return false;
	}

	private static Sprite Dq1tHqfCylZ()
	{
		return AppHelper.FindRootWindows<Sprite>().FirstOrDefault(_003C_003Ec.d9nvjZQdplh ?? (_003C_003Ec.d9nvjZQdplh = _003C_003Ec.muwvjVACm4s.j11vjcMd5Uj));
	}

	public static bool CloseFloatButton()
	{
		Sprite sprite = Dq1tHqfCylZ();
		if (sprite != null)
		{
			sprite.Close();
			return true;
		}
		return false;
	}

	public static void ShowPanelFloatButton()
	{
		{
			Sprite sprite = Sprite.Show(new QuickerTriggerButton());
			sprite.Tag = $"PANEL_FLOAT_{AppHelper.fLiLTj0x4QY()}";
			sprite.SetValue(BlockQuickerHWndBehavior.IsEnabledProperty, true);
			IHNRIiikxBwJdYmHpM3.p1AvvooEqum(sprite, ShowWindowLocation.WithMouse2);
		}
	}

	public static void LogLastTriggerButtonId(string id)
	{
		d9etHcB3lK9 = id;
	}

	static FloatTriggerButtonHelper()
	{
		d9etHcB3lK9 = string.Empty;
	}

	internal static bool wXKdREQaUwkgjAH7T96q()
	{
		return AJND3WQaMv2kBVpuTHx6 == null;
	}
}
