using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using Quicker.Utilities.UI;

namespace Quicker.View.Controls;

public class FilterBoxControl : UserControl, IComponentConnector
{
	[CompilerGenerated]
	private EventHandler m_FilterChanged;

	[CompilerGenerated]
	private int eeuLxNJxvoP = 200;

	[CompilerGenerated]
	private bool cJXLxJq5xZ0;

	private DebounceDispatcher iKlLx0VUNMd;

	internal TextBox TxtFilter;

	internal TextBlock LblPlaceHolder;

	internal Button BtnFilter;

	private bool M3wLxCDQkKl;

	private static FilterBoxControl pt4AbmFuoJdJZ5ZEy38u;

	public int DebounceMs
	{
		[CompilerGenerated]
		get
		{
			return eeuLxNJxvoP;
		}
		[CompilerGenerated]
		set
		{
			eeuLxNJxvoP = value;
		}
	}

	public string FilterText => TxtFilter.Text;

	public bool OnlyTriggerOnEnter
	{
		[CompilerGenerated]
		get
		{
			return cJXLxJq5xZ0;
		}
		[CompilerGenerated]
		set
		{
			cJXLxJq5xZ0 = value;
		}
	}

	public string PlaceHolder
	{
		get
		{
			return LblPlaceHolder.Text;
		}
		set
		{
			LblPlaceHolder.Text = value;
		}
	}

	public event EventHandler FilterChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = this.m_FilterChanged;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_FilterChanged, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = this.m_FilterChanged;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_FilterChanged, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public FilterBoxControl()
	{
		InitializeComponent();
		TxtFilter.KeyDown += LUmLxgLDlI7;
		TxtFilter.LostFocus += mQgLxtWDJdP;
	}

	private void mQgLxtWDJdP(object sender, RoutedEventArgs e)
	{
		this.m_FilterChanged?.Invoke(this, EventArgs.Empty);
	}

	private void LUmLxgLDlI7(object sender, KeyEventArgs e)
	{
		if (e.Key == Key.Return)
		{
			this.m_FilterChanged?.Invoke(this, EventArgs.Empty);
		}
	}

	private void AwaLxLq5YPN(object sender, RoutedEventArgs e)
	{
		TxtFilter.Text = "";
		if (OnlyTriggerOnEnter)
		{
			this.m_FilterChanged?.Invoke(this, EventArgs.Empty);
		}
	}

	private void n5yLxvgvtJZ(object sender, TextChangedEventArgs e)
	{
		if (!OnlyTriggerOnEnter)
		{
			if (iKlLx0VUNMd == null)
			{
				iKlLx0VUNMd = new DebounceDispatcher();
			}
			iKlLx0VUNMd.Debounce(DebounceMs, ToILx2tCFZN);
		}
	}

	private void mHtLxSQtuWE(object sender, RoutedEventArgs e)
	{
		base.Dispatcher.InvokeAsync(OKELxuSMJ7x);
	}

	public void SetFocus()
	{
		TxtFilter.Focus();
	}

	public void SetImeState(string imeState)
	{
		AppImeHelper.SetImeState(TxtFilter, imeState);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!M3wLxCDQkKl)
		{
			M3wLxCDQkKl = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/controls/filterboxcontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num = 1;
		while (true)
		{
			switch (connectionId)
			{
			case 1:
				TxtFilter = (TextBox)target;
				TxtFilter.GotFocus += mHtLxSQtuWE;
				TxtFilter.TextChanged += n5yLxvgvtJZ;
				return;
			case 2:
				LblPlaceHolder = (TextBlock)target;
				return;
			case 3:
				BtnFilter = (Button)target;
				BtnFilter.Click += AwaLxLq5YPN;
				return;
			}
			int num2 = 0;
			if (!pa7Wi4FufnQKieIDngZW())
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			M3wLxCDQkKl = true;
			return;
		}
	}

	[CompilerGenerated]
	private void ToILx2tCFZN(object object_0)
	{
		this.m_FilterChanged?.Invoke(this, EventArgs.Empty);
	}

	[CompilerGenerated]
	private void OKELxuSMJ7x()
	{
		TxtFilter.SelectAll();
	}

	internal static bool pa7Wi4FufnQKieIDngZW()
	{
		return pt4AbmFuoJdJZ5ZEy38u == null;
	}

	internal static void UtIOW8FuqCw6So3fG8fv()
	{
	}
}
