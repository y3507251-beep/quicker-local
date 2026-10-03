using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using Quicker.Utilities;
using wlFuCLYjBIXKFesp7Vo;

namespace SCyJThYoNMQE7IHLXbA;

internal static class rQGqkoYXY7Ss1mRdm0c
{
	[CompilerGenerated]
	private static class _003C_003EO
	{
		public static EventHandler ujaSXJsDIml;
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass0_0
	{
		public iTHRNJY2ZQQokysD4pN Rx2SXPkJIr0;

		public Action bu1SXE3fPif;

		internal static _003C_003Ec__DisplayClass0_0 tkou0aWlzQ6EOUSNxFw3;

		internal void x7RSX02bmjm()
		{
			AppHelper.RunOnUiThread(false, bu1SXE3fPif ?? (bu1SXE3fPif = fdXSXCqsSWX));
		}

		internal void fdXSXCqsSWX()
		{
			if (Rx2SXPkJIr0 is Window { IsLoaded: not false } window)
			{
				window.Close();
			}
		}

		static _003C_003Ec__DisplayClass0_0()
		{
		}

		internal static bool qeS6RRWZVWPGRgJVth5U()
		{
			return tkou0aWlzQ6EOUSNxFw3 == null;
		}

		internal static void mhYXQ4WZF4ODgldA5tmD()
		{
		}
	}

	internal static object cGj2gXFVQe7KlO96600v;

	public static void V6hgjEnp8ZH(this iTHRNJY2ZQQokysD4pN iTHRNJY2ZQQokysD4pN_0, CancellationToken? nullable_0)
	{
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
		_003C_003Ec__DisplayClass0_.Rx2SXPkJIr0 = iTHRNJY2ZQQokysD4pN_0;
		if (nullable_0.HasValue && !_003C_003Ec__DisplayClass0_.Rx2SXPkJIr0.CancellationTokenRegistration.HasValue && _003C_003Ec__DisplayClass0_.Rx2SXPkJIr0 is Window window)
		{
			_003C_003Ec__DisplayClass0_.Rx2SXPkJIr0.CancellationTokenRegistration = nullable_0.Value.Register(_003C_003Ec__DisplayClass0_.x7RSX02bmjm);
			window.Closed += _003C_003EO.ujaSXJsDIml ?? (_003C_003EO.ujaSXJsDIml = cIWgjySgcLP);
		}
	}

	private static void cIWgjySgcLP(object sender, EventArgs e)
	{
		(sender as Window).Closed -= _003C_003EO.ujaSXJsDIml ?? (_003C_003EO.ujaSXJsDIml = cIWgjySgcLP);
		(sender as iTHRNJY2ZQQokysD4pN)?.CancellationTokenRegistration?.Dispose();
	}

	internal static bool t3rclPFVFJiXF8rt892k()
	{
		return cGj2gXFVQe7KlO96600v == null;
	}
}
