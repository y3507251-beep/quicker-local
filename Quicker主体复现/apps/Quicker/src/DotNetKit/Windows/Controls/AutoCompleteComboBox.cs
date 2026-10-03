using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using QgRgOKGpI8sIATMykx;
using TWDbmXQTE8XnOESNkb;
using vnZmoCCK9yQeNidkHR;

namespace DotNetKit.Windows.Controls;

public class AutoCompleteComboBox : ComboBox, IComponentConnector
{
	private struct RVvceIdjpqgBP4ROoEH : IDisposable
	{
		private readonly TextBox Hs6vE3hgmpC;

		private readonly int TZJvEf2Dkur;

		private readonly int iaNvEzRPHqV;

		private readonly string sjNvywCGPf0;

		internal static object tJqY2RcjCUOu0jEuIV1B;

		public void Dispose()
		{
			if (Hs6vE3hgmpC != null)
			{
				Hs6vE3hgmpC.Text = sjNvywCGPf0;
				Hs6vE3hgmpC.Select(TZJvEf2Dkur, iaNvEzRPHqV);
			}
		}

		public RVvceIdjpqgBP4ROoEH(TextBox textBox_1)
		{
			Hs6vE3hgmpC = textBox_1;
			TZJvEf2Dkur = textBox_1?.SelectionStart ?? 0;
			iaNvEzRPHqV = textBox_1?.SelectionLength ?? 0;
			sjNvywCGPf0 = textBox_1?.Text;
		}

		internal static bool H0n54ycj7H043dwrMR91()
		{
			return tJqY2RcjCUOu0jEuIV1B == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003CComboBox_DropDownOpened_003Eb__32_0_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public AutoCompleteComboBox _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object comk5bcjh5BiIevifj3J;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			AutoCompleteComboBox autoCompleteComboBox = _003C_003E4__this;
			try
			{
				int num2;
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = _003C_003Eu__1;
						num2 = 0;
						if (!CxExKWcjHxIrGENY8p94())
						{
							goto IL_0068;
						}
						goto IL_0089;
					}
					awaiter = Task.Delay(100).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
				}
				awaiter.GetResult();
				awaiter = autoCompleteComboBox.Dispatcher.InvokeAsync(autoCompleteComboBox.leqJof37Ya).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = 1;
					_003C_003E1__state = 1;
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_0104;
				IL_0068:
				_003C_003Eu__1 = default(TaskAwaiter);
				num = -1;
				_003C_003E1__state = -1;
				num2 = 1;
				if (!CxExKWcjHxIrGENY8p94())
				{
					goto IL_0089;
				}
				goto IL_0104;
				IL_0089:
				switch (num2)
				{
				case 1:
					goto IL_0104;
				}
				goto IL_0068;
				IL_0104:
				awaiter.GetResult();
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool CxExKWcjHxIrGENY8p94()
		{
			return comk5bcjh5BiIevifj3J == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass28_0
	{
		public AutoCompleteComboBox ms2vyLV8aL2;

		public long D7QvyvS5sXD;

		public Action PSAvySFqo7l;

		internal static _003C_003Ec__DisplayClass28_0 shvcH0cDVTINlreEHJJR;

		internal void AbavytDRUkw(object state)
		{
			ms2vyLV8aL2.Dispatcher.InvokeAsync(PSAvySFqo7l ?? (PSAvySFqo7l = fTjvygFYtIP));
		}

		internal void fTjvygFYtIP()
		{
			if (ms2vyLV8aL2.hYUJiP41JB == D7QvyvS5sXD)
			{
				ms2vyLV8aL2.LTEJnhGYLN();
			}
		}

		internal static bool UI0HSecDQ52Yxpxf5YtL()
		{
			return shvcH0cDVTINlreEHJJR == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass30_0
	{
		public AutoCompleteComboBox SjcvyuPLUhD;

		public Predicate<object> IGRvyNXfrwF;

		internal static _003C_003Ec__DisplayClass30_0 bRSKajcDcHXMh6M63uU0;

		internal bool tWtvy25PSaw(object i)
		{
			if (!SjcvyuPLUhD.xNyJFWoaH6(i))
			{
				return false;
			}
			return IGRvyNXfrwF(i);
		}

		internal static bool cyWU4UcDW1hI9MgNrbIb()
		{
			return bRSKajcDcHXMh6M63uU0 == null;
		}
	}

	private readonly koT1nZBRhsJlFTjPQi PFMJAUWOjx = new koT1nZBRhsJlFTjPQi();

	private TextBox BijJOAECIm;

	private Predicate<object> xNyJFWoaH6;

	private static readonly DependencyProperty e3rJUBc62L;

	[CompilerGenerated]
	private bool zEnJlVQ0C7 = true;

	private long hYUJiP41JB;

	private string bgWJ32vQwD;

	private bool flFJfsGnBn;

	private static AutoCompleteComboBox MYP2E43ugP5nbiDunKa;

	public TextBox EditableTextBox => (TextBox)xgMMIvIMwQJoofV480.p7LJKkI8nb(this, "PART_EditableTextBox");

	public static DependencyProperty SettingProperty => e3rJUBc62L;

	public AutoCompleteComboBoxSetting Setting
	{
		get
		{
			return (AutoCompleteComboBoxSetting)GetValue(e3rJUBc62L);
		}
		set
		{
			SetValue(e3rJUBc62L, value);
		}
	}

	public bool AutoDropDown
	{
		[CompilerGenerated]
		get
		{
			return zEnJlVQ0C7;
		}
		[CompilerGenerated]
		set
		{
			zEnJlVQ0C7 = value;
		}
	}

	private string M5VJx6FJov(object object_0)
	{
		if (object_0 == null)
		{
			return string.Empty;
		}
		eS2paWt3SxbOgxJiGZ<string> eS2paWt3SxbOgxJiGZ = new eS2paWt3SxbOgxJiGZ<string>();
		eS2paWt3SxbOgxJiGZ.NqcJHDRfba(object_0, TextSearch.GetTextPath(this));
		return eS2paWt3SxbOgxJiGZ.Value ?? string.Empty;
	}

	protected override void OnItemsSourceChanged(IEnumerable oldValue, IEnumerable newValue)
	{
		base.OnItemsSourceChanged(oldValue, newValue);
		xNyJFWoaH6 = ((newValue is ICollectionView collectionView) ? collectionView.Filter : null);
	}

	[SpecialName]
	private AutoCompleteComboBoxSetting DumJTPYpg0()
	{
		return Setting ?? AutoCompleteComboBoxSetting.Default;
	}

	private static int RX7JrD6pqr<DHZRYHLP1GSfTiIO5O>(IEnumerable<DHZRYHLP1GSfTiIO5O> ienumerable_0, Predicate<DHZRYHLP1GSfTiIO5O> predicate_1, int int_0)
	{
		int num = 0;
		foreach (DHZRYHLP1GSfTiIO5O item in ienumerable_0)
		{
			if (predicate_1(item))
			{
				num++;
				if (num > int_0)
				{
					return num;
				}
			}
		}
		return num;
	}

	private void pK8JpbfZkp()
	{
		TextBox editableTextBox = EditableTextBox;
		editableTextBox?.Select(editableTextBox.SelectionStart + editableTextBox.SelectionLength, 0);
	}

	private void yv9JBQKr0n(Predicate<object> predicate_1)
	{
		TextBox editableTextBox = EditableTextBox;
		if (editableTextBox == null)
		{
			return;
		}
		using (new RVvceIdjpqgBP4ROoEH(editableTextBox))
		{
			using (base.Items.DeferRefresh())
			{
				base.Items.Filter = predicate_1;
			}
		}
	}

	private void rfEJQ44Tbd(Predicate<object> predicate_1, bool bool_2)
	{
		yv9JBQKr0n(predicate_1);
		if (AutoDropDown || bool_2)
		{
			base.IsDropDownOpen = true;
		}
		pK8JpbfZkp();
	}

	private void g2DJjTd08i()
	{
		Predicate<object> filter = GetFilter();
		rfEJQ44Tbd(filter, true);
	}

	private void LTEJnhGYLN()
	{
		string text = base.Text;
		if (text == bgWJ32vQwD)
		{
			return;
		}
		bgWJ32vQwD = text;
		int num = 0;
		if (!vJCZ3g3o92r1bROwmVT())
		{
			goto IL_009e;
		}
		goto IL_00a2;
		IL_00a2:
		Predicate<object> filter = default(Predicate<object>);
		int maxSuggestionCount = default(int);
		do
		{
			object obj;
			int num2;
			switch (num)
			{
			default:
				if (!string.IsNullOrEmpty(text))
				{
					if (base.SelectedItem == null || !(M5VJx6FJov(base.SelectedItem) == text))
					{
						using (new RVvceIdjpqgBP4ROoEH(EditableTextBox))
						{
							base.SelectedItem = null;
						}
						break;
					}
					return;
				}
				base.SelectedItem = null;
				using (base.Items.DeferRefresh())
				{
					base.Items.Filter = xNyJFWoaH6;
					return;
				}
			case 1:
				{
					IEnumerable itemsSource = base.ItemsSource;
					if (itemsSource == null)
					{
						obj = null;
					}
					else
					{
						obj = itemsSource.Cast<object>();
						if (obj != null)
						{
							goto IL_0102;
						}
					}
					obj = Enumerable.Empty<object>();
					goto IL_0102;
				}
				IL_0102:
				num2 = RX7JrD6pqr((IEnumerable<object>)obj, filter, maxSuggestionCount);
				if (0 < num2 && num2 <= maxSuggestionCount)
				{
					rfEJQ44Tbd(filter, false);
				}
				return;
			}
			filter = GetFilter();
			maxSuggestionCount = DumJTPYpg0().MaxSuggestionCount;
			num = 1;
		}
		while (MYP2E43ugP5nbiDunKa == null);
		goto IL_009e;
		IL_009e:
		int num3 = default(int);
		num = num3;
		goto IL_00a2;
	}

	private void zDZJ4cjfJR(object sender, TextChangedEventArgs e)
	{
		_003C_003Ec__DisplayClass28_0 _003C_003Ec__DisplayClass28_ = new _003C_003Ec__DisplayClass28_0();
		_003C_003Ec__DisplayClass28_.ms2vyLV8aL2 = this;
		_003C_003Ec__DisplayClass28_.D7QvyvS5sXD = ++hYUJiP41JB;
		AutoCompleteComboBoxSetting autoCompleteComboBoxSetting = DumJTPYpg0();
		if (autoCompleteComboBoxSetting.Delay <= TimeSpan.Zero)
		{
			LTEJnhGYLN();
		}
		else if (base.IsKeyboardFocusWithin)
		{
			PFMJAUWOjx.Content = new Timer(_003C_003Ec__DisplayClass28_.AbavytDRUkw, null, autoCompleteComboBoxSetting.Delay, Timeout.InfiniteTimeSpan);
		}
	}

	private void AaWJ5rp844(object sender, KeyEventArgs e)
	{
		if (Keyboard.Modifiers.HasFlag(ModifierKeys.Control) && e.Key == Key.Space)
		{
			g2DJjTd08i();
			e.Handled = true;
		}
		if (e.Key == Key.Down && !base.IsDropDownOpen)
		{
			int num = 0;
			if (!vJCZ3g3o92r1bROwmVT())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			g2DJjTd08i();
			e.Handled = true;
		}
		if (e.Key == Key.Back)
		{
			base.SelectedIndex = -1;
		}
	}

	private Predicate<object> GetFilter()
	{
		_003C_003Ec__DisplayClass30_0 _003C_003Ec__DisplayClass30_ = new _003C_003Ec__DisplayClass30_0();
		_003C_003Ec__DisplayClass30_.SjcvyuPLUhD = this;
		_003C_003Ec__DisplayClass30_.IGRvyNXfrwF = DumJTPYpg0().GetFilter(base.Text, M5VJx6FJov);
		if (xNyJFWoaH6 == null)
		{
			return _003C_003Ec__DisplayClass30_.IGRvyNXfrwF;
		}
		return _003C_003Ec__DisplayClass30_.tWtvy25PSaw;
	}

	public AutoCompleteComboBox()
	{
		InitializeComponent();
		AddHandler(TextBoxBase.TextChangedEvent, new TextChangedEventHandler(zDZJ4cjfJR));
	}

	private void xNaJD9yGbu(object sender, EventArgs e)
	{
		Task.Run((Func<Task>)GJCJdZmNLq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!flFJfsGnBn)
		{
			flFJfsGnBn = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/controls/autocompletecombobox/autocompletecombobox.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 1)
		{
			((AutoCompleteComboBox)target).PreviewKeyDown += AaWJ5rp844;
			((AutoCompleteComboBox)target).DropDownOpened += xNaJD9yGbu;
		}
		else
		{
			flFJfsGnBn = true;
		}
	}

	static AutoCompleteComboBox()
	{
		e3rJUBc62L = DependencyProperty.Register("Setting", typeof(AutoCompleteComboBoxSetting), typeof(AutoCompleteComboBox));
	}

	[CompilerGenerated]
	[AsyncStateMachine(typeof(_003C_003CComboBox_DropDownOpened_003Eb__32_0_003Ed))]
	private Task GJCJdZmNLq()
	{
		_003C_003CComboBox_DropDownOpened_003Eb__32_0_003Ed stateMachine = default(_003C_003CComboBox_DropDownOpened_003Eb__32_0_003Ed);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[CompilerGenerated]
	private void leqJof37Ya()
	{
		if (base.IsEditable && base.Template.FindName("PART_EditableTextBox", this) is TextBox textBox)
		{
			textBox.Focus();
			textBox.SelectionStart = textBox.Text.Length;
		}
	}

	internal static bool vJCZ3g3o92r1bROwmVT()
	{
		return MYP2E43ugP5nbiDunKa == null;
	}
}
