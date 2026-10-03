using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using HandyControl.Controls;
using Quicker.Utilities.UI;

namespace Quicker.View.Controls;

public class SearchBoxControl : UserControl, IComponentConnector
{
	[CompilerGenerated]
	private RoutedEventHandler m_SearchTextChanged;

	public static readonly DependencyProperty SearchTextProperty;

	[CompilerGenerated]
	private int eVLLxUKS8vY;

	private DebounceDispatcher EpQLxlDuwWw;

	internal SearchBoxControl TheControl;

	internal HandyControl.Controls.TextBox TxtFilter;

	private bool SB9LxiwpIvc;

	private static SearchBoxControl elYR6ZFojxmwcLFZXtWN;

	public string SearchText
	{
		get
		{
			return (string)GetValue(SearchTextProperty);
		}
		set
		{
			SetValue(SearchTextProperty, value);
		}
	}

	public int DebounceMs
	{
		[CompilerGenerated]
		get
		{
			return eVLLxUKS8vY;
		}
		[CompilerGenerated]
		set
		{
			eVLLxUKS8vY = value;
		}
	}

	public event RoutedEventHandler SearchTextChanged
	{
		[CompilerGenerated]
		add
		{
			RoutedEventHandler routedEventHandler = this.m_SearchTextChanged;
			RoutedEventHandler routedEventHandler2;
			do
			{
				routedEventHandler2 = routedEventHandler;
				RoutedEventHandler value2 = (RoutedEventHandler)Delegate.Combine(routedEventHandler2, value);
				routedEventHandler = Interlocked.CompareExchange(ref this.m_SearchTextChanged, value2, routedEventHandler2);
			}
			while ((object)routedEventHandler != routedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			RoutedEventHandler routedEventHandler = this.m_SearchTextChanged;
			RoutedEventHandler routedEventHandler2;
			do
			{
				routedEventHandler2 = routedEventHandler;
				RoutedEventHandler value2 = (RoutedEventHandler)Delegate.Remove(routedEventHandler2, value);
				routedEventHandler = Interlocked.CompareExchange(ref this.m_SearchTextChanged, value2, routedEventHandler2);
			}
			while ((object)routedEventHandler != routedEventHandler2);
		}
	}

	public SearchBoxControl()
	{
		InitializeComponent();
		base.Unloaded += HijLxTDDZDJ;
	}

	private void HijLxTDDZDJ(object sender, RoutedEventArgs e)
	{
		EpQLxlDuwWw?.Cancel();
	}

	private void V7QLxMXNWqG(object sender, TextChangedEventArgs e)
	{
		if (DebounceMs > 0)
		{
			if (EpQLxlDuwWw == null)
			{
				EpQLxlDuwWw = new DebounceDispatcher();
			}
			EpQLxlDuwWw.Debounce(DebounceMs, QiILxF3yn4P);
		}
		else
		{
			IajLxAq6Y9t();
		}
	}

	private void IajLxAq6Y9t()
	{
		SearchText = TxtFilter.Text;
		this.m_SearchTextChanged?.Invoke(this, null);
	}

	public void SetFocus()
	{
		TxtFilter.Focus();
		TxtFilter.SelectAll();
	}

	private void QrELxOZriOR(object sender, RoutedEventArgs e)
	{
		TxtFilter.Clear();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!SB9LxiwpIvc)
		{
			SB9LxiwpIvc = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/controls/searchboxcontrol.xaml", UriKind.Relative);
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
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			SB9LxiwpIvc = true;
			break;
		case 1:
			TheControl = (SearchBoxControl)target;
			break;
		case 2:
			TxtFilter = (HandyControl.Controls.TextBox)target;
			TxtFilter.TextChanged += V7QLxMXNWqG;
			break;
		case 3:
			((Button)target).Click += QrELxOZriOR;
			break;
		}
	}

	static SearchBoxControl()
	{
		SearchTextProperty = DependencyProperty.Register("SearchText", typeof(string), typeof(SearchBoxControl), new PropertyMetadata((object)null));
	}

	[CompilerGenerated]
	private void QiILxF3yn4P(object object_0)
	{
		IajLxAq6Y9t();
	}

	internal static bool fv3frnFoDQIudT1AoPju()
	{
		return elYR6ZFojxmwcLFZXtWN == null;
	}
}
