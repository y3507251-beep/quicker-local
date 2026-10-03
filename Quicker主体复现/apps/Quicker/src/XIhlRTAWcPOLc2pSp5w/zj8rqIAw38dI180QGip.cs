using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using GVkGVl5Ci2QOrxD8FOU;
using ManagedShell.ShellFolders;
using NxArkNAjDilsy3A01yI;
using P9ImGWAAc7TOpg50ewA;
using Quicker.Utilities;

namespace XIhlRTAWcPOLc2pSp5w;

internal class zj8rqIAw38dI180QGip : IDisposable
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	internal struct _003C_003Ec__DisplayClass11_0
	{
		public string D75vc3FJMth;
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	internal struct _003C_003Ec__DisplayClass12_0
	{
		public zj8rqIAw38dI180QGip HgkvcfXOgxO;

		public string fY4vczYNluH;
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	internal struct _003C_003Ec__DisplayClass14_0
	{
		public List<string> qv6vVw0iKfv;
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	internal struct _003C_003Ec__DisplayClass15_0
	{
		public bool AyZvVtK7nj2;

		public List<string> lYqvVg9D0YJ;
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass8_0
	{
		public zj8rqIAw38dI180QGip bbXvVvdSFYk;

		public ItemCollection Gs4vVSDZOf6;

		public IList<KEaK5nA5w4pj7wbFuOW> z5QvV2T1hU3;

		internal static _003C_003Ec__DisplayClass8_0 CiFMO3cNqkM5CdOTrrpl;

		internal void z1KvVLQ9Nwn()
		{
			bbXvVvdSFYk.HV7QI7aJei(Gs4vVSDZOf6, z5QvV2T1hU3);
		}

		internal static bool nNdKMEcNiqZlrfXvcw9p()
		{
			return CiFMO3cNqkM5CdOTrrpl == null;
		}
	}

	private readonly IList<string> GMEQK6XLAQ;

	private readonly IntPtr JeHQxpOs7u;

	private bool aB0QrUt5vM;

	private IList<ShellItem> Kv3QpVOIc2 = new List<ShellItem>();

	private EqtTCe5xOs4YVatqr3K RwnQBj5Vc3;

	public EventHandler<uTX3b0A2Kw0VvQl1fb6> SY1QQ0V5H8;

	private static zj8rqIAw38dI180QGip A641PjtTgvvvAlQZe09;

	public zj8rqIAw38dI180QGip(string string_0, IntPtr intptr_1)
		: this(new string[1] { string_0 }, intptr_1)
	{
	}

	public zj8rqIAw38dI180QGip(IList<string> ilist_2, IntPtr intptr_1)
	{
		GMEQK6XLAQ = ilist_2;
		JeHQxpOs7u = intptr_1;
		if (ilist_2 != null && ilist_2.Count != 0)
		{
			foreach (string item in ilist_2)
			{
				if (!string.IsNullOrWhiteSpace(item))
				{
					Kv3QpVOIc2.Add(new ShellItem(item));
					continue;
				}
				throw new ArgumentException("pathList");
			}
			ShellFolder shellFolder_ = ((!Kv3QpVOIc2[0].ParentItem.IsFolder || !Kv3QpVOIc2[0].ParentItem.IsFileSystem) ? new ShellFolder(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), JeHQxpOs7u, false, false) : new ShellFolder(Kv3QpVOIc2[0].ParentItem.Path, JeHQxpOs7u, false, false));
			RwnQBj5Vc3 = new EqtTCe5xOs4YVatqr3K(Kv3QpVOIc2.ToArray(), shellFolder_, JeHQxpOs7u, null, false);
			return;
		}
		throw new ArgumentException("pathList");
	}

	public void IAyQ7lTDg5(ContextMenu contextMenu_0, ItemCollection itemCollection_0)
	{
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
		_003C_003Ec__DisplayClass8_.bbXvVvdSFYk = this;
		_003C_003Ec__DisplayClass8_.Gs4vVSDZOf6 = itemCollection_0;
		_003C_003Ec__DisplayClass8_.z5QvV2T1hU3 = RwnQBj5Vc3.zGIBpJPI5W(true);
		AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass8_.z1KvVLQ9Nwn);
	}

	public void Sw7QR3i5Jn()
	{
		RwnQBj5Vc3.XfKBmw1Xbp();
	}

	public IList<KEaK5nA5w4pj7wbFuOW> y3OQq2m1Uu()
	{
		return RwnQBj5Vc3.zGIBpJPI5W(false);
	}

	public void q9CQcqSxKL(string string_0)
	{
		_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_0_ = default(_003C_003Ec__DisplayClass11_0);
		_003C_003Ec__DisplayClass11_0_.D75vc3FJMth = string_0;
		if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass11_0_.D75vc3FJMth))
		{
			throw new ArgumentNullException("menuTitle");
		}
		KEaK5nA5w4pj7wbFuOW kEaK5nA5w4pj7wbFuOW = aguQ1Sm4C3(RwnQBj5Vc3.zGIBpJPI5W(false), ref _003C_003Ec__DisplayClass11_0_);
		if (kEaK5nA5w4pj7wbFuOW == null)
		{
			throw new Exception("未找到菜单项：" + _003C_003Ec__DisplayClass11_0_.D75vc3FJMth);
		}
		int num = eX1QWHUeXJ(kEaK5nA5w4pj7wbFuOW);
		if (num != 0)
		{
			throw Marshal.GetExceptionForHR(num);
		}
	}

	public void Ec9QVm0RcX(string string_0)
	{
		_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_0_ = default(_003C_003Ec__DisplayClass12_0);
		_003C_003Ec__DisplayClass12_0_.HgkvcfXOgxO = this;
		_003C_003Ec__DisplayClass12_0_.fY4vczYNluH = string_0;
		if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass12_0_.fY4vczYNluH))
		{
			throw new ArgumentNullException("verb");
		}
		IList<KEaK5nA5w4pj7wbFuOW> ilist_ = RwnQBj5Vc3.zGIBpJPI5W(false);
		KEaK5nA5w4pj7wbFuOW kEaK5nA5w4pj7wbFuOW = l8JQbRRsiU(ilist_, ref _003C_003Ec__DisplayClass12_0_);
		if (kEaK5nA5w4pj7wbFuOW == null)
		{
			throw new Exception("未找到菜单项：" + _003C_003Ec__DisplayClass12_0_.fY4vczYNluH);
		}
		int num = eX1QWHUeXJ(kEaK5nA5w4pj7wbFuOW);
		if (num != 0)
		{
			throw Marshal.GetExceptionForHR(num);
		}
	}

	private bool P1YQZSR3gV(string string_0, string string_1)
	{
		return string.Equals(string_0, string_1, StringComparison.OrdinalIgnoreCase);
	}

	public IList<string> TPiQ9pQUGL()
	{
		IList<KEaK5nA5w4pj7wbFuOW> ilist_ = RwnQBj5Vc3.zGIBpJPI5W(false);
		_003C_003Ec__DisplayClass14_0 _003C_003Ec__DisplayClass14_0_ = default(_003C_003Ec__DisplayClass14_0);
		_003C_003Ec__DisplayClass14_0_.qv6vVw0iKfv = new List<string>();
		mv7Q62Xk9k(ilist_, ref _003C_003Ec__DisplayClass14_0_);
		return _003C_003Ec__DisplayClass14_0_.qv6vVw0iKfv;
	}

	public IList<string> PGYQhEm7uM(bool bool_1)
	{
		_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_0_ = default(_003C_003Ec__DisplayClass15_0);
		_003C_003Ec__DisplayClass15_0_.AyZvVtK7nj2 = bool_1;
		IList<KEaK5nA5w4pj7wbFuOW> ilist_ = RwnQBj5Vc3.zGIBpJPI5W(false);
		_003C_003Ec__DisplayClass15_0_.lYqvVg9D0YJ = new List<string>();
		m6kQmmCL5i(ilist_, null, ref _003C_003Ec__DisplayClass15_0_);
		return _003C_003Ec__DisplayClass15_0_.lYqvVg9D0YJ;
	}

	private static bool m73QeqKQaf(string string_0, string string_1)
	{
		if (!string.Equals(string_0, string_1, StringComparison.OrdinalIgnoreCase))
		{
			return string.Equals(string_0.Replace("&", ""), string_1, StringComparison.OrdinalIgnoreCase);
		}
		return true;
	}

	private static string QnJQYlVJfq(KEaK5nA5w4pj7wbFuOW keaK5nA5w4pj7wbFuOW_0)
	{
		if (keaK5nA5w4pj7wbFuOW_0.Title.Contains("&"))
		{
			return keaK5nA5w4pj7wbFuOW_0.Title.Replace("&", "");
		}
		return keaK5nA5w4pj7wbFuOW_0.Title;
	}

	private void HV7QI7aJei(ItemCollection itemCollection_0, IList<KEaK5nA5w4pj7wbFuOW> ilist_2)
	{
		foreach (KEaK5nA5w4pj7wbFuOW item in ilist_2)
		{
			if (string.IsNullOrEmpty(item.Title))
			{
				itemCollection_0.Add(new Separator());
				continue;
			}
			MenuItem menuItem = g3YQsYKXed(item);
			itemCollection_0.Add(menuItem);
			if (item.Children.Count <= 0)
			{
				menuItem.Click += pnUQGDZuCI;
				continue;
			}
			foreach (KEaK5nA5w4pj7wbFuOW item2 in item.Children)
			{
				if (!string.IsNullOrEmpty(item2.Title))
				{
					MenuItem menuItem2 = g3YQsYKXed(item2);
					menuItem2.Click += pnUQGDZuCI;
					menuItem.Items.Add(menuItem2);
				}
				else
				{
					menuItem.Items.Add(new Separator());
				}
			}
		}
	}

	private int eX1QWHUeXJ(KEaK5nA5w4pj7wbFuOW keaK5nA5w4pj7wbFuOW_0)
	{
		return sJGQkOnNpa(keaK5nA5w4pj7wbFuOW_0.Id);
	}

	private int sJGQkOnNpa(int int_0)
	{
		string string_ = (File.Exists(GMEQK6XLAQ[0]) ? Path.GetDirectoryName(GMEQK6XLAQ[0]) : Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory));
		return RwnQBj5Vc3.uvHBd815k1((uint)int_0, string_);
	}

	private void pnUQGDZuCI(object sender, RoutedEventArgs e)
	{
		if (!((sender as MenuItem)?.Tag is KEaK5nA5w4pj7wbFuOW kEaK5nA5w4pj7wbFuOW))
		{
			return;
		}
		using zj8rqIAw38dI180QGip zj8rqIAw38dI180QGip2 = new zj8rqIAw38dI180QGip(GMEQK6XLAQ, JeHQxpOs7u);
		int num = zj8rqIAw38dI180QGip2.eX1QWHUeXJ(kEaK5nA5w4pj7wbFuOW);
		if (num != 0)
		{
			EventHandler<uTX3b0A2Kw0VvQl1fb6> sY1QQ0V5H = SY1QQ0V5H8;
			if (sY1QQ0V5H != null)
			{
				uTX3b0A2Kw0VvQl1fb6 uTX3b0A2Kw0VvQl1fb = new uTX3b0A2Kw0VvQl1fb6();
				uTX3b0A2Kw0VvQl1fb.OcxQnAhkoW(kEaK5nA5w4pj7wbFuOW);
				uTX3b0A2Kw0VvQl1fb.IsSuccess = false;
				uTX3b0A2Kw0VvQl1fb.HwxQowQB29(num);
				uTX3b0A2Kw0VvQl1fb.ErrorMessage = Marshal.GetExceptionForHR(num).Message;
				sY1QQ0V5H(this, uTX3b0A2Kw0VvQl1fb);
			}
		}
		else
		{
			EventHandler<uTX3b0A2Kw0VvQl1fb6> sY1QQ0V5H2 = SY1QQ0V5H8;
			if (sY1QQ0V5H2 != null)
			{
				uTX3b0A2Kw0VvQl1fb6 uTX3b0A2Kw0VvQl1fb2 = new uTX3b0A2Kw0VvQl1fb6();
				uTX3b0A2Kw0VvQl1fb2.OcxQnAhkoW(kEaK5nA5w4pj7wbFuOW);
				uTX3b0A2Kw0VvQl1fb2.IsSuccess = true;
				uTX3b0A2Kw0VvQl1fb2.HwxQowQB29(0);
				uTX3b0A2Kw0VvQl1fb2.ErrorMessage = string.Empty;
				sY1QQ0V5H2(this, uTX3b0A2Kw0VvQl1fb2);
			}
		}
	}

	private MenuItem g3YQsYKXed(KEaK5nA5w4pj7wbFuOW keaK5nA5w4pj7wbFuOW_0)
	{
		return new MenuItem
		{
			Header = keaK5nA5w4pj7wbFuOW_0.Title.Replace("&", "_"),
			Tag = keaK5nA5w4pj7wbFuOW_0,
			Icon = ((keaK5nA5w4pj7wbFuOW_0.aNnQ2WX7JV() == null) ? null : KYjQH8HP0v(keaK5nA5w4pj7wbFuOW_0.aNnQ2WX7JV()))
		};
	}

	private Image KYjQH8HP0v(BitmapSource bitmapSource_0)
	{
		if (bitmapSource_0 == null)
		{
			return null;
		}
		try
		{
			return new Image
			{
				Width = 16.0,
				Height = 16.0,
				Source = bitmapSource_0
			};
		}
		catch (Exception)
		{
		}
		return null;
	}

	protected virtual void Dispose(bool disposing)
	{
		if (aB0QrUt5vM)
		{
			return;
		}
		if (disposing)
		{
			foreach (ShellItem item in Kv3QpVOIc2)
			{
				item.Dispose();
			}
			Kv3QpVOIc2 = null;
			RwnQBj5Vc3.Dispose();
		}
		aB0QrUt5vM = true;
	}

	public void Dispose()
	{
		Dispose(true);
		GC.SuppressFinalize(this);
	}

	[CompilerGenerated]
	internal static KEaK5nA5w4pj7wbFuOW aguQ1Sm4C3(IList<KEaK5nA5w4pj7wbFuOW> ilist_2, ref _003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_0_0)
	{
		foreach (KEaK5nA5w4pj7wbFuOW item in ilist_2)
		{
			if (!m73QeqKQaf(item.Title, _003C_003Ec__DisplayClass11_0_0.D75vc3FJMth))
			{
				if (item.Children != null && item.Children.Count > 0)
				{
					KEaK5nA5w4pj7wbFuOW kEaK5nA5w4pj7wbFuOW = aguQ1Sm4C3(item.Children, ref _003C_003Ec__DisplayClass11_0_0);
					if (kEaK5nA5w4pj7wbFuOW != null)
					{
						return kEaK5nA5w4pj7wbFuOW;
					}
				}
				continue;
			}
			return item;
		}
		return null;
	}

	[CompilerGenerated]
	private KEaK5nA5w4pj7wbFuOW l8JQbRRsiU(IList<KEaK5nA5w4pj7wbFuOW> ilist_2, ref _003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_0_0)
	{
		foreach (KEaK5nA5w4pj7wbFuOW item in ilist_2)
		{
			if (!P1YQZSR3gV(item.Command, _003C_003Ec__DisplayClass12_0_0.fY4vczYNluH))
			{
				if (item.Children != null && item.Children.Count > 0)
				{
					KEaK5nA5w4pj7wbFuOW kEaK5nA5w4pj7wbFuOW = l8JQbRRsiU(item.Children, ref _003C_003Ec__DisplayClass12_0_0);
					if (kEaK5nA5w4pj7wbFuOW != null)
					{
						return kEaK5nA5w4pj7wbFuOW;
					}
				}
				continue;
			}
			return item;
		}
		return null;
	}

	[CompilerGenerated]
	internal static void mv7Q62Xk9k(IList<KEaK5nA5w4pj7wbFuOW> ilist_2, ref _003C_003Ec__DisplayClass14_0 _003C_003Ec__DisplayClass14_0_0)
	{
		foreach (KEaK5nA5w4pj7wbFuOW item in ilist_2)
		{
			if (!item.IsSeparator)
			{
				if (!string.IsNullOrEmpty(item.Title))
				{
					_003C_003Ec__DisplayClass14_0_0.qv6vVw0iKfv.Add(QnJQYlVJfq(item));
				}
				if (item.Children != null && item.Children.Count > 0)
				{
					mv7Q62Xk9k(item.Children, ref _003C_003Ec__DisplayClass14_0_0);
				}
			}
		}
	}

	[CompilerGenerated]
	internal static string C75QXxFJ6G(KEaK5nA5w4pj7wbFuOW keaK5nA5w4pj7wbFuOW_0, KEaK5nA5w4pj7wbFuOW keaK5nA5w4pj7wbFuOW_1, ref _003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_0_0)
	{
		if (_003C_003Ec__DisplayClass15_0_0.AyZvVtK7nj2)
		{
			return keaK5nA5w4pj7wbFuOW_0.Command;
		}
		if (keaK5nA5w4pj7wbFuOW_1 == null)
		{
			return QnJQYlVJfq(keaK5nA5w4pj7wbFuOW_0) + "(" + keaK5nA5w4pj7wbFuOW_0.Command + ")|" + keaK5nA5w4pj7wbFuOW_0.Command;
		}
		return QnJQYlVJfq(keaK5nA5w4pj7wbFuOW_1) + " - " + QnJQYlVJfq(keaK5nA5w4pj7wbFuOW_0) + "(" + keaK5nA5w4pj7wbFuOW_0.Command + ")|" + keaK5nA5w4pj7wbFuOW_0.Command;
	}

	[CompilerGenerated]
	internal static void m6kQmmCL5i(IList<KEaK5nA5w4pj7wbFuOW> ilist_2, KEaK5nA5w4pj7wbFuOW keaK5nA5w4pj7wbFuOW_0, ref _003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_0_0)
	{
		foreach (KEaK5nA5w4pj7wbFuOW item in ilist_2)
		{
			if (!item.IsSeparator)
			{
				if (!string.IsNullOrEmpty(item.Command))
				{
					_003C_003Ec__DisplayClass15_0_0.lYqvVg9D0YJ.Add(C75QXxFJ6G(item, keaK5nA5w4pj7wbFuOW_0, ref _003C_003Ec__DisplayClass15_0_0));
				}
				if (item.Children != null && item.Children.Count > 0)
				{
					m6kQmmCL5i(item.Children, item, ref _003C_003Ec__DisplayClass15_0_0);
				}
			}
		}
	}

	static zj8rqIAw38dI180QGip()
	{
	}

	internal static bool Iv04sxtmgvR7D0Uqsh4()
	{
		return A641PjtTgvvvAlQZe09 == null;
	}

	internal static void G4OFGYtCUQxrvjkfYBa()
	{
	}
}
