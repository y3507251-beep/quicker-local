using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Windows;
using System.Windows.Threading;
using O2cJaejzKucHfiZGXB0;
using Quicker.Utilities;
using rmBQ8lwABdErnXWOmtu;
using WebSocketSharp.Net;

namespace iD3rL0wqHLyQDnFvopm;

internal class IlMn5dwlDHBK7IvLxep
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec B6svIgcCxk2;

		public static Func<KeyValuePair<string, OJglG3w5kKTlK1ZuwhJ>, bool> eQZvILGVFKu;

		public static Func<KeyValuePair<string, OJglG3w5kKTlK1ZuwhJ>, bool> zv9vIvg2EJ4;

		public static Func<KeyValuePair<string, OJglG3w5kKTlK1ZuwhJ>, string> JEjvISC2OBd;

		public static Func<OJglG3w5kKTlK1ZuwhJ, bool> rcQvI2w8hLr;

		private static _003C_003Ec wkonv3clfsHd3unlAqnI;

		static _003C_003Ec()
		{
			B6svIgcCxk2 = new _003C_003Ec();
		}

		internal bool JtQvYfWdPSE(KeyValuePair<string, OJglG3w5kKTlK1ZuwhJ> x)
		{
			return x.Value?.h3WfvG1TLx() ?? false;
		}

		internal bool ucJvYzEWZpQ(KeyValuePair<string, OJglG3w5kKTlK1ZuwhJ> x)
		{
			return x.Value.bsBfB7O8Gf();
		}

		internal string dmEvIwfWbWR(KeyValuePair<string, OJglG3w5kKTlK1ZuwhJ> x)
		{
			return x.Key + ":" + x.Value.DocumentRootPath;
		}

		internal bool RkVvItKqT1U(OJglG3w5kKTlK1ZuwhJ x)
		{
			return x.wYDfYIxloU() <= 0;
		}

		internal static bool QeHaHjclb88M7aVIShdj()
		{
			return wkonv3clfsHd3unlAqnI == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass5_0
	{
		public string mFZvIN3pdCg;

		internal static _003C_003Ec__DisplayClass5_0 K4IbD6cliwZAQGK5AKN7;

		internal NetworkCredential M7SvIuCW4DQ(IIdentity id)
		{
			if (id.Name == "quicker")
			{
				return new NetworkCredential("quicker", mFZvIN3pdCg);
			}
			return null;
		}

		internal static bool vvvh5EcllZZ7yAOa3FL6()
		{
			return K4IbD6cliwZAQGK5AKN7 == null;
		}
	}

	private DispatcherTimer gAG33lNyik;

	private IDictionary<string, OJglG3w5kKTlK1ZuwhJ> WP73fhDVe9 = new ConcurrentDictionary<string, OJglG3w5kKTlK1ZuwhJ>();

	private static IlMn5dwlDHBK7IvLxep sfI3zUGcdG;

	private static IlMn5dwlDHBK7IvLxep cJTVhPQQZ2Z0uYupjBc9;

	private IlMn5dwlDHBK7IvLxep()
	{
	}

	private void kwZ3MgeUCC(object sender, EventArgs e)
	{
		List<KeyValuePair<string, OJglG3w5kKTlK1ZuwhJ>> list = WP73fhDVe9.Where(_003C_003Ec.eQZvILGVFKu ?? (_003C_003Ec.eQZvILGVFKu = _003C_003Ec.B6svIgcCxk2.JtQvYfWdPSE)).ToList();
		foreach (KeyValuePair<string, OJglG3w5kKTlK1ZuwhJ> item in list)
		{
			Iok3AIp1Qv(item.Key);
		}
		List<KeyValuePair<string, OJglG3w5kKTlK1ZuwhJ>> list2 = list.Where(_003C_003Ec.zv9vIvg2EJ4 ?? (_003C_003Ec.zv9vIvg2EJ4 = _003C_003Ec.B6svIgcCxk2.ucJvYzEWZpQ)).ToList();
		if (list2.Count > 0)
		{
			AppHelper.ShowWindowsToastMessage("Quicker", "已关闭闲置的Web服务：\r\n" + string.Join("\r\n", list2.Select(_003C_003Ec.JEjvISC2OBd ?? (_003C_003Ec.JEjvISC2OBd = _003C_003Ec.B6svIgcCxk2.dmEvIwfWbWR))));
		}
		if (WP73fhDVe9.Values.All(_003C_003Ec.rcQvI2w8hLr ?? (_003C_003Ec.rcQvI2w8hLr = _003C_003Ec.B6svIgcCxk2.RkVvItKqT1U)))
		{
			gAG33lNyik.Stop();
		}
	}

	public void Iok3AIp1Qv(string string_0)
	{
		if (WP73fhDVe9.TryGetValue(string_0, out var value))
		{
			if (value.IsListening)
			{
				value.Stop();
			}
			WP73fhDVe9.Remove(string_0);
		}
	}

	public void A4w3ODOOTJ(string string_0, string string_1, int int_0, bool bool_0, string string_2, int int_1, string string_3, string string_4, string string_5, string string_6, string string_7, bool bool_1)
	{
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
		_003C_003Ec__DisplayClass5_.mFZvIN3pdCg = string_2;
		if (!Directory.Exists(string_1))
		{
			throw new InvalidDataException("路径 " + string_1 + " 不存在！");
		}
		Iok3AIp1Qv(string_0);
		OJglG3w5kKTlK1ZuwhJ oJglG3w5kKTlK1ZuwhJ = new OJglG3w5kKTlK1ZuwhJ(string_1, int_0, bool_0, int_1, string_3);
		oJglG3w5kKTlK1ZuwhJ.ActionId = string_6;
		oJglG3w5kKTlK1ZuwhJ.s6SfHhaHfO(string_4);
		oJglG3w5kKTlK1ZuwhJ.wjNf6FHWUA(string_5);
		int num = 1;
		if (cJTVhPQQZ2Z0uYupjBc9 != null)
		{
			goto IL_006c;
		}
		goto IL_008f;
		IL_008f:
		switch (num)
		{
		case 1:
			break;
		default:
			if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass5_.mFZvIN3pdCg))
			{
				oJglG3w5kKTlK1ZuwhJ.AuthenticationSchemes = AuthenticationSchemes.Digest;
				oJglG3w5kKTlK1ZuwhJ.Realm = "Quicker";
				oJglG3w5kKTlK1ZuwhJ.UserCredentialsFinder = _003C_003Ec__DisplayClass5_.M7SvIuCW4DQ;
			}
			if (bool_0)
			{
				GjEIhFja8p2K53Rulg4.c4ktsNLsAl0(oJglG3w5kKTlK1ZuwhJ);
			}
			oJglG3w5kKTlK1ZuwhJ.Start();
			WP73fhDVe9.Add(string_0, oJglG3w5kKTlK1ZuwhJ);
			if (int_1 > 0)
			{
				if (gAG33lNyik == null)
				{
					gAG33lNyik = new DispatcherTimer(TimeSpan.FromSeconds(10.0), DispatcherPriority.ApplicationIdle, kwZ3MgeUCC, Application.Current.Dispatcher);
				}
				gAG33lNyik.Start();
			}
			return;
		}
		goto IL_006c;
		IL_006c:
		oJglG3w5kKTlK1ZuwhJ.W0Ifr0jiqc(string_7);
		oJglG3w5kKTlK1ZuwhJ.JK6fQqVDrD(bool_1);
		num = 0;
		if (cJTVhPQQZ2Z0uYupjBc9 != null)
		{
			int num2 = default(int);
			num = num2;
		}
		goto IL_008f;
	}

	[SpecialName]
	public static IlMn5dwlDHBK7IvLxep fRm3lP2xqA()
	{
		if (sfI3zUGcdG == null)
		{
			sfI3zUGcdG = new IlMn5dwlDHBK7IvLxep();
		}
		return sfI3zUGcdG;
	}

	internal bool V7X3FMuZWW(string string_0)
	{
		if (WP73fhDVe9.TryGetValue(string_0, out var value))
		{
			return value.IsListening;
		}
		return false;
	}

	internal IList<string> bbV3Ug7KMi()
	{
		return WP73fhDVe9.Keys.ToList();
	}

	internal static bool vOHtnBQQ5mJhVf1wvmVM()
	{
		return cJTVhPQQZ2Z0uYupjBc9 == null;
	}
}
