using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using IOn6RhAJdTUbfGy6gwn;
using log4net;
using Quicker.Common;
using Quicker.Domain;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.SubPrograms;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;
using WcdJQYXW9E2moeWW9Np;

namespace Quicker.View.X.Controls;

public class GlobalSubProgramListControl : UserControl, IComponentConnector, IStyleConnector
{
	[CompilerGenerated]
	private static class _003C_003EO
	{
		public static Predicate<object> sVESUdtvnu3;
	}

	private static readonly ILog b1BLXvVhPjd;

	private ListCollectionView ChnLXSrWUD6;

	public static int BindCount;

	private DebounceDispatcher ekfLX2cXn6l;

	internal TextBox TxtFilter;

	internal Button BtnClearFilter;

	internal ListBox LvSubprograms;

	internal ToggleButton BtnSortByEditTime;

	private bool BvgLXuGeC5j;

	internal static GlobalSubProgramListControl khhaK9F9j3PM9fWT6MyX;

	public GlobalSubProgramListControl()
	{
		InitializeComponent();
		base.Loaded += d7xL6BX9j1B;
		base.Unloaded += TE3L6j646nk;
		lu6L6QJjHC4();
	}

	private void d7xL6BX9j1B(object sender, RoutedEventArgs e)
	{
	}

	private void lu6L6QJjHC4()
	{
		ChnLXSrWUD6 = new ListCollectionViewEx(AppState.DataService.GlobalSubPrograms);
		ChnLXSrWUD6.Filter = Filter;
		int num = 0;
		if (!eXOS0TF9DJuUktrEej0u())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		BtnSortByEditTime.IsChecked = dDh7g7Xw7JyQPUTbYwJ.SortGlobalSpByLastEditTime;
		if (dDh7g7Xw7JyQPUTbYwJ.SortGlobalSpByLastEditTime)
		{
			ChnLXSrWUD6.CustomSort = new SortBySubProgramEditTime();
		}
		else
		{
			ChnLXSrWUD6.CustomSort = new SortBySubProgramName();
		}
		LvSubprograms.ItemsSource = ChnLXSrWUD6;
		BindCount++;
	}

	public void ClearBinding()
	{
		LvSubprograms.ItemsSource = null;
		if (ChnLXSrWUD6 != null)
		{
			ChnLXSrWUD6.Filter = _003C_003EO.sVESUdtvnu3 ?? (_003C_003EO.sVESUdtvnu3 = uCXL6nLHEE1);
			ChnLXSrWUD6.CustomSort = null;
			ChnLXSrWUD6.DetachFromSourceCollection();
			BindCount--;
		}
	}

	private void TE3L6j646nk(object sender, RoutedEventArgs e)
	{
	}

	private static bool uCXL6nLHEE1(object object_0)
	{
		return true;
	}

	private bool Filter(object obj)
	{
		if (string.IsNullOrEmpty(TxtFilter.Text))
		{
			return true;
		}
		string text = TxtFilter.Text;
		if (!(obj is SubProgram subProgram))
		{
			return false;
		}
		if (subProgram.Id == text)
		{
			return true;
		}
		return tkxn6HAKAgMT8gvXbyh.hSHinCpnSJ(text, subProgram.Name, subProgram.Description);
	}

	private void jV7L64qsN0B(object sender, MouseButtonEventArgs e)
	{
		if (e.ClickCount >= 2)
		{
			e.Handled = true;
			SubProgram subProgram_ = (sender as FrameworkElement).Tag as SubProgram;
			xWjL65dLsSd(subProgram_);
		}
	}

	private void xWjL65dLsSd(SubProgram subProgram_0)
	{
		AppState.lWutartRfUY().CreateOrEditGlobalSubProgram(subProgram_0);
	}

	private void R43L6DCwjDG(object sender, RoutedEventArgs e)
	{
		AppState.lWutartRfUY().CreateOrEditGlobalSubProgram(null);
	}

	private void idgL6dXKSRe(object sender, RoutedEventArgs e)
	{
		SubProgram subProgram_ = (sender as FrameworkElement).Tag as SubProgram;
		xWjL65dLsSd(subProgram_);
	}

	private void sa0L6ofYE0k(object sender, RoutedEventArgs e)
	{
		if (!(LvSubprograms.SelectedItem is SubProgram subProgram))
		{
			return;
		}
		string globalSubProgramIdentifier = SubProgramHelper.GetGlobalSubProgramIdentifier(subProgram);
		int num = 0;
		if (!eXOS0TF9DJuUktrEej0u())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (Window.GetWindow(this) is ActionDesignerWindow actionDesignerWindow && actionDesignerWindow.IsGlobalSubProgramUsedInCurrentAction(globalSubProgramIdentifier))
		{
			AppHelper.ShowWarning("子程序在当前动作中被使用了。", true);
			return;
		}
		(bool, string) tuple = AppState.DataService.JwotXbccdBP(globalSubProgramIdentifier);
		if (tuple.Item1)
		{
			AppHelper.ShowWarning("子程序已经被动作或子程序  " + tuple.Item2 + " 使用。", true);
		}
		else if (AppHelper.Confirm("您确认要删除子程序 " + subProgram.Name + " 么？"))
		{
			AppState.DataService.kittX1ycc6R(subProgram);
		}
	}

	private void UdaL6TbZHs3(object sender, RoutedEventArgs e)
	{
		if (LvSubprograms.SelectedItem is SubProgram subProgram)
		{
			AppState.lWutartRfUY().ShareSubProgram(subProgram, Window.GetWindow(this), true);
		}
	}

	private void ynZL6MGLaMt(object sender, RoutedEventArgs e)
	{
		base.Dispatcher.InvokeAsync(v7aLXgRJtJY);
	}

	private void ehAL6As2xRf(object sender, TextChangedEventArgs e)
	{
		if (ekfLX2cXn6l == null)
		{
			ekfLX2cXn6l = new DebounceDispatcher();
		}
		ekfLX2cXn6l.Debounce(100, hvXLXL7GjLP);
	}

	private void XiNL6OmRMbr()
	{
		if (LvSubprograms.ItemsSource == null)
		{
			lu6L6QJjHC4();
		}
		if (ChnLXSrWUD6 != null && AppState.DataService.GlobalSubPrograms != null)
		{
			try
			{
				ChnLXSrWUD6.Refresh();
			}
			catch (Exception ex)
			{
				b1BLXvVhPjd.Warn(ex);
				AppHelper.ShowWarning("程序异常：" + ex.GetMessageWithInner());
			}
		}
	}

	private void MADL6Fh3Hdg(object sender, RoutedEventArgs e)
	{
		TxtFilter.Text = "";
	}

	private void vwCL6UB8fkQ(object sender, RoutedEventArgs e)
	{
		if (LvSubprograms.SelectedItem is SubProgram subProgram)
		{
			i0bL6lOKqm8().HighlightText(subProgram.Id);
		}
	}

	private ActionDesignerWindow i0bL6lOKqm8()
	{
		return Window.GetWindow(this) as ActionDesignerWindow;
	}

	private void Q39L6intAPg(object sender, RoutedEventArgs e)
	{
		if (!(LvSubprograms.SelectedItem is SubProgram subProgram))
		{
			return;
		}
		string globalSubProgramIdentifier = SubProgramHelper.GetGlobalSubProgramIdentifier(subProgram);
		int num = 0;
		if (khhaK9F9j3PM9fWT6MyX != null)
		{
			goto IL_0099;
		}
		goto IL_009d;
		IL_009d:
		(IList<ActionItem>, IList<SubProgram>) tuple = default((IList<ActionItem>, IList<SubProgram>));
		StringBuilder stringBuilder = default(StringBuilder);
		IEnumerator<ActionItem> enumerator = default(IEnumerator<ActionItem>);
		do
		{
			switch (num)
			{
			default:
				tuple = AppState.DataService.qpbtX68Qs5r(globalSubProgramIdentifier);
				if (tuple.Item1.HasData() || tuple.Item2.HasData())
				{
					stringBuilder = new StringBuilder();
					if (!tuple.Item1.HasData())
					{
						break;
					}
					goto IL_0071;
				}
				AppHelper.ShowInformation("没有使用此子程序的动作。");
				return;
			case 1:
				try
				{
					while (enumerator.MoveNext())
					{
						ActionItem current = enumerator.Current;
						stringBuilder.Append("");
						stringBuilder.AppendLine(current.Title);
					}
				}
				finally
				{
					enumerator?.Dispose();
				}
				stringBuilder.AppendLine();
				break;
			}
			if (tuple.Item2.HasData())
			{
				stringBuilder.AppendLine("--使用此子程序的其它公共子程序--");
				foreach (SubProgram item in tuple.Item2)
				{
					stringBuilder.Append("");
					stringBuilder.AppendLine(item.Name);
				}
				stringBuilder.AppendLine();
			}
			AppHelper.ShowTextWindow("子程序使用情况", stringBuilder.ToString(), Window.GetWindow(this), false);
			return;
			IL_0071:
			stringBuilder.AppendLine("--使用此子程序的动作--");
			enumerator = tuple.Item1.GetEnumerator();
			num = 1;
		}
		while (eXOS0TF9DJuUktrEej0u());
		goto IL_0099;
		IL_0099:
		int num2 = default(int);
		num = num2;
		goto IL_009d;
	}

	private void TsJL63L7Ity(object sender, RoutedEventArgs e)
	{
		if (LvSubprograms.SelectedItem is SubProgram subProgram)
		{
			i0bL6lOKqm8().CopyGlobalSubProgramToInternal(subProgram);
		}
	}

	private void F8vL6fMXgf7(object sender, KeyEventArgs e)
	{
		if (e.Key == Key.Return)
		{
			e.Handled = true;
		}
	}

	private void a3tL6zIPViR(object sender, RoutedEventArgs e)
	{
		if (BtnSortByEditTime.IsChecked == true)
		{
			ChnLXSrWUD6.CustomSort = new SortBySubProgramEditTime();
		}
		else
		{
			ChnLXSrWUD6.CustomSort = new SortBySubProgramName();
		}
		dDh7g7Xw7JyQPUTbYwJ.SortGlobalSpByLastEditTime = BtnSortByEditTime.IsChecked == true;
		ChnLXSrWUD6.Refresh();
	}

	private void SinLXw6YOG8(object sender, KeyEventArgs e)
	{
		if (e.Key == Key.H || (e.Key == Key.ImeProcessed && e.ImeProcessedKey == Key.H))
		{
			vwCL6UB8fkQ(sender, e);
			e.Handled = true;
		}
	}

	private void TqkLXtiP91p(object sender, RoutedEventArgs e)
	{
		if (LvSubprograms.SelectedItem is SubProgram subProgram)
		{
			AppHelper.TryCopy(SubProgramHelper.GetGlobalSubProgramIdentifier(subProgram), true);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!BvgLXuGeC5j)
		{
			BvgLXuGeC5j = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/x/controls/globalsubprogramlistcontrol.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		while (true)
		{
			switch (connectionId)
			{
			case 1:
				TxtFilter = (TextBox)target;
				TxtFilter.GotFocus += ynZL6MGLaMt;
				TxtFilter.PreviewKeyDown += F8vL6fMXgf7;
				TxtFilter.TextChanged += ehAL6As2xRf;
				return;
			case 2:
				BtnClearFilter = (Button)target;
				BtnClearFilter.Click += MADL6Fh3Hdg;
				return;
			case 3:
				LvSubprograms = (ListBox)target;
				LvSubprograms.PreviewKeyDown += SinLXw6YOG8;
				return;
			}
			if (khhaK9F9j3PM9fWT6MyX == null)
			{
				switch (0)
				{
				case 1:
					continue;
				}
			}
			switch (connectionId)
			{
			default:
				BvgLXuGeC5j = true;
				break;
			case 13:
				BtnSortByEditTime = (ToggleButton)target;
				BtnSortByEditTime.Click += a3tL6zIPViR;
				break;
			case 12:
				((Button)target).Click += R43L6DCwjDG;
				break;
			}
			return;
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 4:
		{
			((Grid)target).PreviewMouseDown += jV7L64qsN0B;
			int num = 0;
			if (khhaK9F9j3PM9fWT6MyX != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			break;
		}
		case 5:
			((MenuItem)target).Click += UdaL6TbZHs3;
			break;
		case 6:
			((MenuItem)target).Click += Q39L6intAPg;
			break;
		case 7:
			((MenuItem)target).Click += TsJL63L7Ity;
			break;
		case 8:
			((MenuItem)target).Click += TqkLXtiP91p;
			break;
		case 9:
			((MenuItem)target).Click += vwCL6UB8fkQ;
			break;
		case 10:
			((MenuItem)target).Click += sa0L6ofYE0k;
			break;
		case 11:
			((Button)target).Click += idgL6dXKSRe;
			break;
		}
	}

	static GlobalSubProgramListControl()
	{
		b1BLXvVhPjd = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		BindCount = 0;
	}

	[CompilerGenerated]
	private void v7aLXgRJtJY()
	{
		TxtFilter.SelectAll();
	}

	[CompilerGenerated]
	private void hvXLXL7GjLP(object object_0)
	{
		XiNL6OmRMbr();
	}

	internal static void sRovdkF9EDTTZZZ3bjTb()
	{
	}

	internal static bool eXOS0TF9DJuUktrEej0u()
	{
		return khhaK9F9j3PM9fWT6MyX == null;
	}
}
