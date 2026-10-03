using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Quicker.Modules.Searching.Plugins.Builtin;
using Quicker.Public.Extensions;
using Quicker.Utilities._3rd.Chrome;

namespace Rn3s242UWRarQxcDcxp;

internal class zNDBT324IHaUJUaYALP
{
	[CompilerGenerated]
	private sealed class _003CGetBookmarkItems_003Ed__1 : IDisposable, IEnumerable, IEnumerator, IEnumerable<BookmarkInfo>, IEnumerator<BookmarkInfo>
	{
		private int _003C_003E1__state;

		private BookmarkInfo _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private datameta meta;

		public datameta _003C_003E3__meta;

		private List<datameta>.Enumerator _003C_003E7__wrap1;

		private IEnumerator<BookmarkInfo> _003C_003E7__wrap2;

		internal static _003CGetBookmarkItems_003Ed__1 FJ77jjcU7OVDLfyu4511;

		BookmarkInfo IEnumerator<BookmarkInfo>.Current
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
		public _003CGetBookmarkItems_003Ed__1(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			int num = _003C_003E1__state;
			if ((uint)(num - -4) <= 1u || num == 2)
			{
				try
				{
					if (num == -4 || num == 2)
					{
						try
						{
						}
						finally
						{
							_003C_003Em__Finally2();
						}
					}
				}
				finally
				{
					_003C_003Em__Finally1();
				}
			}
			_003C_003E7__wrap1 = default(List<datameta>.Enumerator);
			_003C_003E7__wrap2 = null;
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			try
			{
				int num = _003C_003E1__state;
				if (FJ77jjcU7OVDLfyu4511 != null)
				{
					switch (1)
					{
					case 1:
						break;
					default:
						goto IL_005d;
					case 2:
						goto IL_0104;
					case 3:
						goto IL_012a;
					}
				}
				switch (num)
				{
				default:
					return false;
				case 0:
					break;
				case 1:
					goto IL_00a5;
				case 2:
					goto IL_00e1;
				}
				_003C_003E1__state = -1;
				if (meta == null)
				{
					return false;
				}
				goto IL_005d;
				IL_00e1:
				_003C_003E1__state = -4;
				goto IL_011d;
				IL_014b:
				return false;
				IL_011d:
				if (_003C_003E7__wrap2.MoveNext())
				{
					BookmarkInfo current = _003C_003E7__wrap2.Current;
					_003C_003E2__current = current;
					_003C_003E1__state = 2;
					return true;
				}
				goto IL_012a;
				IL_005d:
				if (meta.type == "url" && !string.IsNullOrEmpty(meta.url))
				{
					_003C_003E2__current = pA2tEJjYj2b(meta);
					_003C_003E1__state = 1;
					return true;
				}
				goto IL_00ac;
				IL_012a:
				_003C_003Em__Finally2();
				_003C_003E7__wrap2 = null;
				goto IL_00eb;
				IL_00eb:
				datameta current2 = default(datameta);
				if (_003C_003E7__wrap1.MoveNext())
				{
					current2 = _003C_003E7__wrap1.Current;
					goto IL_0104;
				}
				_003C_003Em__Finally1();
				_003C_003E7__wrap1 = default(List<datameta>.Enumerator);
				goto IL_014b;
				IL_0104:
				_003C_003E7__wrap2 = gEQtENY72DQ(current2).GetEnumerator();
				_003C_003E1__state = -4;
				goto IL_011d;
				IL_00a5:
				_003C_003E1__state = -1;
				goto IL_00ac;
				IL_00ac:
				if (meta.children.HasData())
				{
					_003C_003E7__wrap1 = meta.children.GetEnumerator();
					_003C_003E1__state = -3;
					goto IL_00eb;
				}
				goto IL_014b;
			}
			catch
			{
				//try-fault
				((IDisposable)this).Dispose();
				throw;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
			_003C_003E1__state = -1;
			((IDisposable)_003C_003E7__wrap1/*cast due to .constrained prefix*/).Dispose();
		}

		private void _003C_003Em__Finally2()
		{
			_003C_003E1__state = -3;
			if (_003C_003E7__wrap2 != null)
			{
				_003C_003E7__wrap2.Dispose();
			}
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator<BookmarkInfo> IEnumerable<BookmarkInfo>.GetEnumerator()
		{
			_003CGetBookmarkItems_003Ed__1 _003CGetBookmarkItems_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CGetBookmarkItems_003Ed__ = this;
			}
			else
			{
				_003CGetBookmarkItems_003Ed__ = new _003CGetBookmarkItems_003Ed__1(0);
			}
			_003CGetBookmarkItems_003Ed__.meta = _003C_003E3__meta;
			return _003CGetBookmarkItems_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<BookmarkInfo>)this).GetEnumerator();
		}

		internal static void n6aibxcUHisX0QEDT9tw()
		{
		}

		internal static bool SMws4AcU47XvrhfIufAg()
		{
			return FJ77jjcU7OVDLfyu4511 == null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CReadBookmarks_003Ed__0 : IDisposable, IEnumerable, IEnumerator, IEnumerable<BookmarkInfo>, IEnumerator<BookmarkInfo>
	{
		private int _003C_003E1__state;

		private BookmarkInfo _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private string file;

		public string _003C_003E3__file;

		private string browser;

		public string _003C_003E3__browser;

		private ChromeBookmarks _003Cbookmarks_003E5__2;

		private IEnumerator<BookmarkInfo> _003C_003E7__wrap2;

		internal static _003CReadBookmarks_003Ed__0 ytEHxgcUzZYvqDZRcTfY;

		BookmarkInfo IEnumerator<BookmarkInfo>.Current
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
		public _003CReadBookmarks_003Ed__0(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			switch (_003C_003E1__state)
			{
			case -3:
			case 1:
				try
				{
				}
				finally
				{
					_003C_003Em__Finally1();
				}
				break;
			case -4:
			case 2:
				try
				{
				}
				finally
				{
					_003C_003Em__Finally2();
				}
				break;
			}
			_003Cbookmarks_003E5__2 = null;
			_003C_003E7__wrap2 = null;
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			try
			{
				int num;
				BookmarkInfo current;
				BookmarkInfo current2 = default(BookmarkInfo);
				int num2 = default(int);
				switch (_003C_003E1__state)
				{
				default:
					return false;
				case 0:
				{
					_003C_003E1__state = -1;
					if (!File.Exists(file))
					{
						num = 1;
						if (!Q5RM1IcxVoHurISXZBHO())
						{
							goto IL_01a1;
						}
						goto IL_01a5;
					}
					string value = File.ReadAllText(file);
					_003Cbookmarks_003E5__2 = JsonConvert.DeserializeObject<ChromeBookmarks>(value);
					if (_003Cbookmarks_003E5__2?.roots?.bookmark_bar != null)
					{
						_003C_003E7__wrap2 = gEQtENY72DQ(_003Cbookmarks_003E5__2.roots.bookmark_bar).GetEnumerator();
						_003C_003E1__state = -3;
						goto IL_00b9;
					}
					goto IL_00d3;
				}
				case 1:
					_003C_003E1__state = -3;
					goto IL_00b9;
				case 2:
					{
						_003C_003E1__state = -4;
						goto IL_014c;
					}
					IL_00b9:
					if (!_003C_003E7__wrap2.MoveNext())
					{
						_003C_003Em__Finally1();
						_003C_003E7__wrap2 = null;
						goto IL_00d3;
					}
					current = _003C_003E7__wrap2.Current;
					current.BrowserProcName = browser;
					_003C_003E2__current = current;
					break;
					IL_014c:
					if (!_003C_003E7__wrap2.MoveNext())
					{
						_003C_003Em__Finally2();
						_003C_003E7__wrap2 = null;
						goto IL_0166;
					}
					current2 = _003C_003E7__wrap2.Current;
					num = 2;
					if (ytEHxgcUzZYvqDZRcTfY == null)
					{
						goto IL_01a5;
					}
					goto IL_01ce;
					IL_00d3:
					if (_003Cbookmarks_003E5__2?.roots?.other != null)
					{
						_003C_003E7__wrap2 = gEQtENY72DQ(_003Cbookmarks_003E5__2.roots.other).GetEnumerator();
						_003C_003E1__state = -4;
						goto IL_014c;
					}
					goto IL_0166;
					IL_0166:
					return false;
					IL_01a5:
					while (true)
					{
						switch (num)
						{
						case 2:
							break;
						default:
							_003C_003E2__current = current2;
							_003C_003E1__state = 2;
							return true;
						case 1:
							goto end_IL_01a5;
						case 3:
							goto end_IL_000b;
						}
						current2.BrowserProcName = browser;
						num = 0;
						if (ytEHxgcUzZYvqDZRcTfY == null)
						{
							continue;
						}
						goto IL_01a1;
						continue;
						end_IL_01a5:
						break;
					}
					goto IL_01ce;
					IL_01a1:
					num = num2;
					goto IL_01a5;
					IL_01ce:
					return false;
					end_IL_000b:
					break;
				}
				_003C_003E1__state = 1;
				return true;
			}
			catch
			{
				//try-fault
				((IDisposable)this).Dispose();
				throw;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
			_003C_003E1__state = -1;
			if (_003C_003E7__wrap2 != null)
			{
				_003C_003E7__wrap2.Dispose();
			}
		}

		private void _003C_003Em__Finally2()
		{
			_003C_003E1__state = -1;
			if (_003C_003E7__wrap2 != null)
			{
				_003C_003E7__wrap2.Dispose();
			}
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator<BookmarkInfo> IEnumerable<BookmarkInfo>.GetEnumerator()
		{
			_003CReadBookmarks_003Ed__0 _003CReadBookmarks_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CReadBookmarks_003Ed__ = this;
			}
			else
			{
				_003CReadBookmarks_003Ed__ = new _003CReadBookmarks_003Ed__0(0);
			}
			_003CReadBookmarks_003Ed__.file = _003C_003E3__file;
			_003CReadBookmarks_003Ed__.browser = _003C_003E3__browser;
			return _003CReadBookmarks_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<BookmarkInfo>)this).GetEnumerator();
		}

		static _003CReadBookmarks_003Ed__0()
		{
		}

		internal static bool Q5RM1IcxVoHurISXZBHO()
		{
			return ytEHxgcUzZYvqDZRcTfY == null;
		}

		internal static void J0DwWNcxFW05vv20eOvJ()
		{
		}
	}

	private static zNDBT324IHaUJUaYALP FARHajQDANFgQ4MkS1Yw;

	[IteratorStateMachine(typeof(_003CReadBookmarks_003Ed__0))]
	public static IEnumerable<BookmarkInfo> TBDtEuNInUZ(string string_0, string string_1)
	{
		return new _003CReadBookmarks_003Ed__0(-2)
		{
			_003C_003E3__file = string_0,
			_003C_003E3__browser = string_1
		};
	}

	[IteratorStateMachine(typeof(_003CGetBookmarkItems_003Ed__1))]
	private static IEnumerable<BookmarkInfo> gEQtENY72DQ(datameta datameta_0)
	{
		return new _003CGetBookmarkItems_003Ed__1(-2)
		{
			_003C_003E3__meta = datameta_0
		};
	}

	private static BookmarkInfo pA2tEJjYj2b(datameta datameta_0)
	{
		return new BookmarkInfo
		{
			Title = datameta_0.name,
			Url = datameta_0.url,
			Id = datameta_0.id,
			DateAdded = datameta_0.date_added,
			DateLastUsed = datameta_0.date_last_used
		};
	}

	internal static bool l5J70XQDncmVZMFcTW7Z()
	{
		return FARHajQDANFgQ4MkS1Yw == null;
	}
}
