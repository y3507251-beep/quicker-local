using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using FontAwesome5;

namespace Quicker.Settings.Code;

public class SettingPageInfo
{
	[CompilerGenerated]
	private sealed class _003CFindVisualChildren_003Ed__38<T> : IEnumerable<T>, IEnumerator<T>, IDisposable, IEnumerable, IEnumerator where T : DependencyObject
	{
		private int _003C_003E1__state;

		private T _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private DependencyObject depObj;

		public DependencyObject _003C_003E3__depObj;

		private IEnumerator _003C_003E7__wrap1;

		private object _003Cchild_003E5__3;

		private IEnumerator<T> _003C_003E7__wrap3;

		internal static object C3IGYecN7cF2a03peBlV;

		T IEnumerator<T>.Current
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
		public _003CFindVisualChildren_003Ed__38(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			int num = _003C_003E1__state;
			if ((uint)(num - -4) <= 1u || (uint)(num - 1) <= 1u)
			{
				int num2 = 0;
				if (nySNSGcNhpdviWPdunpB() != null)
				{
					int num3 = default(int);
					num2 = num3;
				}
				switch (num2)
				{
				}
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
			_003C_003E7__wrap1 = null;
			_003Cchild_003E5__3 = null;
			_003C_003E7__wrap3 = null;
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			try
			{
				int num;
				T current;
				DependencyObject dependencyObject = default(DependencyObject);
				switch (_003C_003E1__state)
				{
				default:
					return false;
				case 0:
					_003C_003E1__state = -1;
					if (depObj != null)
					{
						_003C_003E7__wrap1 = LogicalTreeHelper.GetChildren(depObj).GetEnumerator();
						goto IL_00de;
					}
					goto IL_0169;
				case 1:
					_003C_003E1__state = -3;
					goto IL_00c3;
				case 2:
					{
						_003C_003E1__state = -4;
						goto IL_014a;
					}
					IL_0075:
					_003Cchild_003E5__3 = null;
					goto IL_007c;
					IL_00de:
					_003C_003E1__state = -3;
					goto IL_007c;
					IL_007c:
					if (_003C_003E7__wrap1.MoveNext())
					{
						_003Cchild_003E5__3 = _003C_003E7__wrap1.Current;
						if (_003Cchild_003E5__3 == null || !(_003Cchild_003E5__3 is T))
						{
							goto IL_00c3;
						}
						num = 3;
						if (!IyMNkacN4uVmsDMLV5kM())
						{
							break;
						}
						goto IL_00ef;
					}
					_003C_003Em__Finally1();
					_003C_003E7__wrap1 = null;
					goto IL_0169;
					IL_014a:
					if (!_003C_003E7__wrap3.MoveNext())
					{
						_003C_003Em__Finally2();
						_003C_003E7__wrap3 = null;
						goto IL_0075;
					}
					current = _003C_003E7__wrap3.Current;
					_003C_003E2__current = current;
					num = 1;
					if (nySNSGcNhpdviWPdunpB() != null)
					{
						int num2 = default(int);
						num = num2;
					}
					goto IL_00ef;
					IL_0169:
					return false;
					IL_00c3:
					dependencyObject = _003Cchild_003E5__3 as DependencyObject;
					num = 0;
					if (nySNSGcNhpdviWPdunpB() != null)
					{
						goto IL_00e9;
					}
					goto IL_00ef;
					IL_00ef:
					switch (num)
					{
					case 2:
						break;
					default:
						goto IL_00e9;
					case 1:
						_003C_003E1__state = 2;
						return true;
					case 3:
						goto end_IL_000b;
					}
					goto IL_00de;
					IL_00e9:
					if (dependencyObject == null)
					{
						goto IL_0075;
					}
					_003C_003E7__wrap3 = FindVisualChildren<T>(dependencyObject).GetEnumerator();
					_003C_003E1__state = -4;
					goto IL_014a;
					end_IL_000b:
					break;
				}
				_003C_003E2__current = (T)_003Cchild_003E5__3;
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
			if (_003C_003E7__wrap1 is IDisposable disposable)
			{
				disposable.Dispose();
			}
		}

		private void _003C_003Em__Finally2()
		{
			_003C_003E1__state = -3;
			if (_003C_003E7__wrap3 != null)
			{
				_003C_003E7__wrap3.Dispose();
			}
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			_003CFindVisualChildren_003Ed__38<T> _003CFindVisualChildren_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CFindVisualChildren_003Ed__ = this;
			}
			else
			{
				_003CFindVisualChildren_003Ed__ = new _003CFindVisualChildren_003Ed__38<T>(0);
			}
			_003CFindVisualChildren_003Ed__.depObj = _003C_003E3__depObj;
			return _003CFindVisualChildren_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<T>)this).GetEnumerator();
		}

		internal static bool IyMNkacN4uVmsDMLV5kM()
		{
			return C3IGYecN7cF2a03peBlV == null;
		}

		internal static object nySNSGcNhpdviWPdunpB()
		{
			return C3IGYecN7cF2a03peBlV;
		}
	}

	private string N6EnvIb91s;

	private string yAxnSEdQEE;

	[CompilerGenerated]
	private SettingPageId aqyn220ptb;

	[CompilerGenerated]
	private string M4Vnu7MnBv;

	[CompilerGenerated]
	private string XxtnNcEuFC;

	[CompilerGenerated]
	private EFontAwesomeIcon GdEnJLqilo;

	[CompilerGenerated]
	private bool yxSn0CmJYL;

	[CompilerGenerated]
	private string EMnnCJyMEF;

	[CompilerGenerated]
	private string n4VnPvv16J;

	[CompilerGenerated]
	private Type bBjnEV8vKk;

	internal static SettingPageInfo OJB6nUwEMPMs8T91uyF;

	public SettingPageId Id
	{
		[CompilerGenerated]
		get
		{
			return aqyn220ptb;
		}
		[CompilerGenerated]
		set
		{
			aqyn220ptb = value;
		}
	}

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return M4Vnu7MnBv;
		}
		[CompilerGenerated]
		set
		{
			M4Vnu7MnBv = value;
		}
	}

	public string Title
	{
		[CompilerGenerated]
		get
		{
			return XxtnNcEuFC;
		}
		[CompilerGenerated]
		set
		{
			XxtnNcEuFC = value;
		}
	}

	public string FullTitle
	{
		get
		{
			if (!string.IsNullOrEmpty(yAxnSEdQEE))
			{
				return yAxnSEdQEE;
			}
			return Title;
		}
		set
		{
			yAxnSEdQEE = value;
		}
	}

	public EFontAwesomeIcon Icon
	{
		[CompilerGenerated]
		get
		{
			return GdEnJLqilo;
		}
		[CompilerGenerated]
		set
		{
			GdEnJLqilo = value;
		}
	}

	public bool IsAdvanced
	{
		[CompilerGenerated]
		get
		{
			return yxSn0CmJYL;
		}
		[CompilerGenerated]
		set
		{
			yxSn0CmJYL = value;
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return EMnnCJyMEF;
		}
		[CompilerGenerated]
		set
		{
			EMnnCJyMEF = value;
		}
	}

	public string KeyWords
	{
		[CompilerGenerated]
		get
		{
			return n4VnPvv16J;
		}
		[CompilerGenerated]
		set
		{
			n4VnPvv16J = value;
		}
	}

	public Type EditControl
	{
		[CompilerGenerated]
		get
		{
			return bBjnEV8vKk;
		}
		[CompilerGenerated]
		set
		{
			bBjnEV8vKk = value;
		}
	}

	private void Vk6nLddE94()
	{
		UserControl depObj = Activator.CreateInstance(EditControl) as UserControl;
		StringBuilder stringBuilder = new StringBuilder();
		foreach (TextBlock item in FindVisualChildren<TextBlock>(depObj))
		{
			stringBuilder.Append(item.Text);
			stringBuilder.Append(" ");
		}
		N6EnvIb91s = stringBuilder.ToString();
	}

	[IteratorStateMachine(typeof(_003CFindVisualChildren_003Ed__38<>))]
	public static IEnumerable<T> FindVisualChildren<T>(DependencyObject depObj) where T : DependencyObject
	{
		return new _003CFindVisualChildren_003Ed__38<T>(-2)
		{
			_003C_003E3__depObj = depObj
		};
	}

	public string GetUri()
	{
		return $"quicker://settings:{Id}";
	}

	internal static bool tF0fNGwG1EZK1v8vq1C()
	{
		return OJB6nUwEMPMs8T91uyF == null;
	}
}
