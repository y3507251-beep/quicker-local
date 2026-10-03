using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using Cronos;
using Quicker.Utilities;
using Quicker.Utilities._3rd;

namespace Quicker.Settings.Pages.Basic.AutoTriggers;

public class CronEditor : UserControl, IComponentConnector
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass5_0
	{
		public TextBox vstvhFdOLim;

		public Action lKuvhUi72vu;

		private static _003C_003Ec__DisplayClass5_0 Rnln8kcbNLkf2Y1W5nx4;

		internal void fOsvhAwLwsq(Task t)
		{
			AppHelper.RunOnUiThread(false, lKuvhUi72vu ?? (lKuvhUi72vu = npYvhOYRWrZ));
		}

		internal void npYvhOYRWrZ()
		{
			vstvhFdOLim.Focus();
		}

		static _003C_003Ec__DisplayClass5_0()
		{
		}

		internal static bool CJi7Yhcb9EWC5VwYFRIF()
		{
			return Rnln8kcbNLkf2Y1W5nx4 == null;
		}

		internal static void Fn3qr4cbuHN3grEF6eD6()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CFindVisualChildren_003Ed__6<T> : IEnumerable<T>, IEnumerator<T>, IDisposable, IEnumerable, IEnumerator where T : DependencyObject
	{
		private int _003C_003E1__state;

		private T _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private DependencyObject rootObject;

		public DependencyObject _003C_003E3__rootObject;

		private int _003Ci_003E5__2;

		private DependencyObject _003Cchild_003E5__3;

		private IEnumerator<T> _003C_003E7__wrap3;

		private static object QVelTOcboKrjaGeeMn9L;

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
		public _003CFindVisualChildren_003Ed__6(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			int num = _003C_003E1__state;
			if (num == -3 || num == 2)
			{
				try
				{
				}
				finally
				{
					_003C_003Em__Finally1();
				}
			}
			_003Cchild_003E5__3 = null;
			_003C_003E7__wrap3 = null;
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			try
			{
				int num = _003C_003E1__state;
				int num2 = 1;
				if (!tSLjBDcbfn0Xfsx1EvrT())
				{
					int num3 = default(int);
					num2 = num3;
				}
				T current;
				switch (num2)
				{
				case 1:
					switch (num)
					{
					default:
						return false;
					case 0:
						break;
					case 1:
						goto IL_0063;
					case 2:
						goto IL_006c;
					}
					_003C_003E1__state = -1;
					if (rootObject != null)
					{
						_003Ci_003E5__2 = 0;
						goto IL_00aa;
					}
					goto IL_0129;
				default:
					goto IL_006c;
				case 2:
					{
						if (_003Cchild_003E5__3 is T)
						{
							_003C_003E2__current = (T)_003Cchild_003E5__3;
							_003C_003E1__state = 1;
							return true;
						}
						goto IL_00dc;
					}
					IL_006c:
					_003C_003E1__state = -3;
					goto IL_0074;
					IL_0063:
					_003C_003E1__state = -1;
					goto IL_00dc;
					IL_0129:
					return false;
					IL_00dc:
					_003C_003E7__wrap3 = FindVisualChildren<T>(_003Cchild_003E5__3).GetEnumerator();
					_003C_003E1__state = -3;
					goto IL_0074;
					IL_00aa:
					if (_003Ci_003E5__2 < VisualTreeHelper.GetChildrenCount(rootObject))
					{
						_003Cchild_003E5__3 = VisualTreeHelper.GetChild(rootObject, _003Ci_003E5__2);
						if (_003Cchild_003E5__3 == null)
						{
							goto IL_00dc;
						}
						goto case 2;
					}
					goto IL_0129;
					IL_0074:
					if (!_003C_003E7__wrap3.MoveNext())
					{
						_003C_003Em__Finally1();
						_003C_003E7__wrap3 = null;
						_003Cchild_003E5__3 = null;
						_003Ci_003E5__2++;
						goto IL_00aa;
					}
					current = _003C_003E7__wrap3.Current;
					_003C_003E2__current = current;
					_003C_003E1__state = 2;
					return true;
				}
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
			_003CFindVisualChildren_003Ed__6<T> _003CFindVisualChildren_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CFindVisualChildren_003Ed__ = this;
			}
			else
			{
				_003CFindVisualChildren_003Ed__ = new _003CFindVisualChildren_003Ed__6<T>(0);
			}
			_003CFindVisualChildren_003Ed__.rootObject = _003C_003E3__rootObject;
			return _003CFindVisualChildren_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<T>)this).GetEnumerator();
		}

		internal static bool tSLjBDcbfn0Xfsx1EvrT()
		{
			return QVelTOcboKrjaGeeMn9L == null;
		}
	}

	internal TabControl PartTab;

	internal TextBox TxtSeconds;

	internal TextBox TxtMinutes;

	internal TextBox TxtHour;

	internal TextBox TxtDayOfMonth;

	internal TextBox TxtMonth;

	internal TextBox TxtDayOfWeek;

	internal TextBlock TxtExpression;

	internal TextBlock LblTimeList;

	private bool eFjMp1VWgX;

	internal static CronEditor MCcrHOhLSw33ZnW8VPQ;

	public CronEditor()
	{
		InitializeComponent();
		TxtSeconds.LostFocus += Sf6Mm6JxO9;
		TxtMinutes.LostFocus += Sf6Mm6JxO9;
		TxtHour.LostFocus += Sf6Mm6JxO9;
		TxtDayOfMonth.LostFocus += Sf6Mm6JxO9;
		TxtMonth.LostFocus += Sf6Mm6JxO9;
		TxtDayOfWeek.LostFocus += Sf6Mm6JxO9;
		TxtSeconds.TextChanged += Sf6Mm6JxO9;
		TxtMinutes.TextChanged += Sf6Mm6JxO9;
		TxtHour.TextChanged += Sf6Mm6JxO9;
		TxtDayOfMonth.TextChanged += Sf6Mm6JxO9;
		TxtMonth.TextChanged += Sf6Mm6JxO9;
		TxtDayOfWeek.TextChanged += Sf6Mm6JxO9;
		TxtSeconds.Text = "";
		TxtMinutes.Text = "*";
		TxtHour.Text = "*";
		TxtDayOfMonth.Text = "*";
		TxtMonth.Text = "*";
		TxtDayOfWeek.Text = "*";
	}

	public void SetExpression(string expression)
	{
		TxtExpression.Text = expression;
		string[] array = expression.Split(' ');
		int num;
		if (array.Length == 5)
		{
			TxtSeconds.Text = "";
			TxtMinutes.Text = array[0];
			TxtHour.Text = array[1];
			TxtDayOfMonth.Text = array[2];
			num = 1;
			if (!ToB7pDhu9FZI5ujfuwf())
			{
				goto IL_00b6;
			}
		}
		else
		{
			if (array.Length != 6)
			{
				goto IL_0114;
			}
			TxtSeconds.Text = array[0];
			TxtMinutes.Text = array[1];
			TxtHour.Text = array[2];
			num = 0;
			if (MCcrHOhLSw33ZnW8VPQ != null)
			{
				goto IL_00b6;
			}
		}
		goto IL_00ba;
		IL_00ba:
		switch (num)
		{
		default:
			TxtDayOfMonth.Text = array[3];
			TxtMonth.Text = array[4];
			TxtDayOfWeek.Text = array[5];
			break;
		case 1:
			TxtMonth.Text = array[3];
			TxtDayOfWeek.Text = array[4];
			break;
		}
		goto IL_0114;
		IL_0114:
		cYoMKGJk0V();
		return;
		IL_00b6:
		int num2 = default(int);
		num = num2;
		goto IL_00ba;
	}

	private void Sf6Mm6JxO9(object sender, RoutedEventArgs e)
	{
		if (!(sender is TextBox textBox))
		{
			return;
		}
		if (string.IsNullOrEmpty(textBox.Text))
		{
			if (textBox.IsEither(TxtDayOfMonth, TxtDayOfWeek, TxtMonth))
			{
				textBox.Text = "*";
			}
			else
			{
				textBox.Text = "0";
			}
		}
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		if (!ToB7pDhu9FZI5ujfuwf())
		{
			goto IL_00ac;
		}
		goto IL_00b0;
		IL_00b0:
		do
		{
			switch (num)
			{
			default:
				if (string.IsNullOrWhiteSpace(TxtSeconds.Text))
				{
					break;
				}
				goto IL_0087;
			case 1:
				stringBuilder.Append(" ");
				break;
			}
			stringBuilder.Append(TxtMinutes.Text.Trim() + " ");
			stringBuilder.Append(TxtHour.Text.Trim() + " ");
			stringBuilder.Append(TxtDayOfMonth.Text.Trim() + " ");
			stringBuilder.Append(TxtMonth.Text.Trim() + " ");
			stringBuilder.Append(TxtDayOfWeek.Text.Trim() ?? "");
			string text = stringBuilder.ToString();
			TxtExpression.Text = text;
			cYoMKGJk0V();
			return;
			IL_0087:
			stringBuilder.Append(TxtSeconds.Text.Trim());
			num = 1;
		}
		while (ToB7pDhu9FZI5ujfuwf());
		goto IL_00ac;
		IL_00ac:
		int num2 = default(int);
		num = num2;
		goto IL_00b0;
	}

	public string GetExpression()
	{
		return TxtExpression.Text;
	}

	private void cYoMKGJk0V()
	{
		string text = TxtExpression.Text;
		bool flag = false;
		flag = text.Split(' ').Length == 6;
		try
		{
			CronFormat format = (flag ? CronFormat.IncludeSeconds : CronFormat.Standard);
			if (!ToB7pDhu9FZI5ujfuwf())
			{
				switch (0)
				{
				}
			}
			CronExpression cronExpression = CronExpression.Parse(text, format);
			StringBuilder stringBuilder = new StringBuilder();
			DateTimeOffset? dateTimeOffset = DateTimeOffset.Now;
			int num = 20;
			object obj;
			for (int i = 0; i < num && dateTimeOffset.HasValue; stringBuilder.AppendLine((string)obj), i++)
			{
				dateTimeOffset = cronExpression.GetNextOccurrence(dateTimeOffset.Value, TimeZoneInfo.Local);
				if (!dateTimeOffset.HasValue)
				{
					obj = null;
				}
				else
				{
					obj = dateTimeOffset.GetValueOrDefault().DateTime.ToString();
					if (obj != null)
					{
						continue;
					}
				}
				obj = "";
			}
			LblTimeList.Text = stringBuilder.ToString();
		}
		catch (Exception ex)
		{
			LblTimeList.Text = "出错了：" + ex.Message;
		}
	}

	private void mreMxgXpNB(object sender, SelectionChangedEventArgs e)
	{
		if (PartTab.SelectedItem is TabItem tabItem)
		{
			_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
			_003C_003Ec__DisplayClass5_.vstvhFdOLim = FindVisualChildren<TextBox>(tabItem.Header as DependencyObject).FirstOrDefault();
			if (_003C_003Ec__DisplayClass5_.vstvhFdOLim != null)
			{
				Task.Delay(50).ContinueWith(_003C_003Ec__DisplayClass5_.fOsvhAwLwsq);
			}
		}
	}

	[IteratorStateMachine(typeof(_003CFindVisualChildren_003Ed__6<>))]
	public static IEnumerable<T> FindVisualChildren<T>(DependencyObject rootObject) where T : DependencyObject
	{
		return new _003CFindVisualChildren_003Ed__6<T>(-2)
		{
			_003C_003E3__rootObject = rootObject
		};
	}

	private void HJWMrYaPan(object sender, KeyEventArgs e)
	{
		if ((e.Key == Key.Return || e.Key == Key.Tab) && PartTab.SelectedIndex < PartTab.Items.Count - 1)
		{
			PartTab.SelectedIndex++;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!eFjMp1VWgX)
		{
			eFjMp1VWgX = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/basic/autorun/croneditor.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			eFjMp1VWgX = true;
			break;
		case 1:
			((CronEditor)target).PreviewKeyDown += HJWMrYaPan;
			break;
		case 2:
			PartTab = (TabControl)target;
			PartTab.SelectionChanged += mreMxgXpNB;
			if (MCcrHOhLSw33ZnW8VPQ == null)
			{
				switch (0)
				{
				}
			}
			break;
		case 3:
			TxtSeconds = (TextBox)target;
			break;
		case 4:
			TxtMinutes = (TextBox)target;
			break;
		case 5:
			TxtHour = (TextBox)target;
			break;
		case 6:
			TxtDayOfMonth = (TextBox)target;
			break;
		case 7:
			TxtMonth = (TextBox)target;
			break;
		case 8:
			TxtDayOfWeek = (TextBox)target;
			break;
		case 9:
			TxtExpression = (TextBlock)target;
			break;
		case 10:
			LblTimeList = (TextBlock)target;
			break;
		}
	}

	internal static bool ToB7pDhu9FZI5ujfuwf()
	{
		return MCcrHOhLSw33ZnW8VPQ == null;
	}
}
