using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Threading;
using HandyControl.Controls;
using HandyControl.Data;
using IOn6RhAJdTUbfGy6gwn;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Utilities._3rd;
using Quicker.Utilities.UI;
using Quicker.View.X.Controls;

namespace Quicker.View.X.StepEditor.ParamEditors;

public class ParamVariableSelector : UserControl, IComponentConnector, IStyleConnector
{
	private ObservableCollection<ActionVariable> flbLsBHa7Oc;

	private StepInParamDef QwULsQTg1r1;

	private ActionStepParam kN5LsjwwZ9A;

	public Action<ParamVarMode, object> SelectionCallback;

	[CompilerGenerated]
	private ObservableCollection<VariableOrValueSelectItem> L4wLsnRBkdl;

	internal ListBox LbVariables;

	internal SearchBar VariableFilter;

	internal Button BtnNewVar;

	private bool UPcLs4O15ym;

	internal static ParamVariableSelector Q0aClOFavpurQJcJiHUG;

	[SpecialName]
	[CompilerGenerated]
	private ObservableCollection<VariableOrValueSelectItem> lnKLsx3v7kF()
	{
		return L4wLsnRBkdl;
	}

	[SpecialName]
	[CompilerGenerated]
	private void iQ2LsrCtnJJ(ObservableCollection<VariableOrValueSelectItem> value)
	{
		L4wLsnRBkdl = value;
	}

	public ParamVariableSelector()
	{
		InitializeComponent();
		base.Loaded += dJTLse5WOb0;
		base.IsVisibleChanged += e5ELshXmlMA;
	}

	private void e5ELshXmlMA(object sender, DependencyPropertyChangedEventArgs e)
	{
		if (base.IsVisible)
		{
			VariableFilter.Text = "";
			gfcLsIDrSw7();
			base.Dispatcher.InvokeAsync(DyCLsXPfkRR, DispatcherPriority.ApplicationIdle);
		}
	}

	private void dJTLse5WOb0(object sender, RoutedEventArgs e)
	{
	}

	private void QWSLsYjiW6e(object sender, FunctionEventArgs<string> e)
	{
		CollectionViewSource.GetDefaultView(LbVariables.ItemsSource).Refresh();
	}

	public void Init(ObservableCollection<ActionVariable> actionVariables, StepInParamDef paramDef, ActionStepParam paramData, ObservableCollection<VariableOrValueSelectItem> varAndEnumSelectItems)
	{
		flbLsBHa7Oc = actionVariables;
		QwULsQTg1r1 = paramDef;
		kN5LsjwwZ9A = paramData;
		iQ2LsrCtnJJ(varAndEnumSelectItems);
	}

	public void UpdateParamVarMode(ParamVarMode mode)
	{
		TryFindResource("ButtonDefault");
		TryFindResource("SelectedButton");
	}

	private void gfcLsIDrSw7()
	{
		if (LbVariables.ItemsSource != null)
		{
			return;
		}
		LbVariables.ItemsSource = lnKLsx3v7kF();
		((CollectionView)CollectionViewSource.GetDefaultView(LbVariables.ItemsSource)).Filter = t5BLsWHUJg0;
		if (kN5LsjwwZ9A != null && !string.IsNullOrEmpty(kN5LsjwwZ9A.VarKey))
		{
			LbVariables.SelectedItem = lnKLsx3v7kF().FirstOrDefault(xedLsKDJ74S);
		}
		else
		{
			if (!string.IsNullOrEmpty(kN5LsjwwZ9A.Value) && kN5LsjwwZ9A.Value.Length < 50)
			{
				VariableOrValueSelectItem variableOrValueSelectItem = lnKLsx3v7kF().FirstOrDefault(nhcLsmm9vQq);
				if (variableOrValueSelectItem != null)
				{
					LbVariables.SelectedItem = variableOrValueSelectItem;
				}
			}
			if (LbVariables.SelectedItem == null)
			{
				LbVariables.SelectedIndex = 0;
			}
		}
		if (LbVariables.SelectedItem != null)
		{
			LbVariables.ScrollIntoView(LbVariables.SelectedItem);
			int num = 0;
			if (Q0aClOFavpurQJcJiHUG != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
	}

	private bool t5BLsWHUJg0(object object_0)
	{
		string text = VariableFilter.Text;
		if (string.IsNullOrEmpty(text))
		{
			return true;
		}
		if (object_0 is VariableOrValueSelectItem { Key: not null } variableOrValueSelectItem)
		{
			return tkxn6HAKAgMT8gvXbyh.hSHinCpnSJ(text, variableOrValueSelectItem.Key, variableOrValueSelectItem.Desc, variableOrValueSelectItem.DisplayValue);
		}
		return false;
	}

	private void yufLskvLFIL(object sender, RoutedEventArgs e)
	{
		SelectionCallback?.Invoke(ParamVarMode.Input, "");
	}

	private void sO2LsGotiCb(object sender, RoutedEventArgs e)
	{
		SelectionCallback?.Invoke(ParamVarMode.CreateVariable, "");
	}

	private void kXLLssAXs7G(object sender, MouseButtonEventArgs e)
	{
		if (ItemsControl.ContainerFromElement(sender as ListBox, e.OriginalSource as DependencyObject) is ListBoxItem { DataContext: VariableOrValueSelectItem dataContext })
		{
			lqfLsHFqkuU(dataContext);
		}
	}

	private void lqfLsHFqkuU(VariableOrValueSelectItem variableOrValueSelectItem_0)
	{
		if (variableOrValueSelectItem_0.Key == null)
		{
			SelectionCallback?.Invoke(ParamVarMode.Input, "");
		}
		else if (variableOrValueSelectItem_0.IsVariable)
		{
			SelectionCallback?.Invoke(ParamVarMode.Variable, variableOrValueSelectItem_0.Key);
		}
		else
		{
			SelectionCallback?.Invoke(ParamVarMode.EnumValue, variableOrValueSelectItem_0.Key);
		}
	}

	private void UKuLs1sfIcl(object sender, RoutedEventArgs e)
	{
		SelectionCallback?.Invoke(ParamVarMode.Clear, "");
	}

	private void AfcLsbHBwuj(object sender, KeyEventArgs e)
	{
		int num = 2;
		while (true)
		{
			int num2;
			if (e.Key == Key.F)
			{
				num2 = 1;
				if (!N1uB0PFadDIvOQ16HCXA())
				{
					goto IL_0028;
				}
				goto IL_003b;
			}
			goto IL_0047;
			IL_0097:
			VariableOrValueSelectItem variableOrValueSelectItem = LbVariables.SelectedItem as VariableOrValueSelectItem;
			if (variableOrValueSelectItem == null)
			{
				CollectionView collectionView = (CollectionView)CollectionViewSource.GetDefaultView(LbVariables.ItemsSource);
				if (!collectionView.IsEmpty)
				{
					LbVariables.SelectedItem = collectionView.GetItemAt(0);
				}
			}
			if (!(LbVariables.SelectedItem is VariableOrValueSelectItem variableOrValueSelectItem_))
			{
				break;
			}
			lqfLsHFqkuU(variableOrValueSelectItem_);
			return;
			IL_0047:
			if (!e.Key.IsEither(Key.Up, Key.Down, Key.Home, Key.End))
			{
				if (e.Key != Key.Return)
				{
					break;
				}
				num2 = 0;
				if (!N1uB0PFadDIvOQ16HCXA())
				{
					num2 = num;
				}
				goto IL_0028;
			}
			ListControlHelper.NavigateByKey(LbVariables, e);
			e.Handled = true;
			return;
			IL_003b:
			if (Keyboard.IsKeyDown(Key.LeftCtrl))
			{
				VariableFilter.Focus();
				e.Handled = true;
				return;
			}
			goto IL_0047;
			IL_0028:
			switch (num2)
			{
			case 1:
				break;
			case 2:
				continue;
			default:
				goto IL_0097;
			}
			goto IL_003b;
		}
		if (e.Key == Key.Escape)
		{
			SelectionCallback?.Invoke(ParamVarMode.Cancel, "");
		}
	}

	private void PcuLs6Ov4pb(object sender, RequestBringIntoViewEventArgs e)
	{
		if (System.Windows.Input.Mouse.LeftButton == MouseButtonState.Pressed)
		{
			e.Handled = true;
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!UPcLs4O15ym)
		{
			UPcLs4O15ym = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/x/stepeditor/parameditors/paramcontrols/paramvariableselector.xaml", UriKind.Relative);
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
		while (true)
		{
			switch (connectionId)
			{
			default:
				if (Q0aClOFavpurQJcJiHUG != null)
				{
					switch (0)
					{
					case 1:
						goto end_IL_0021;
					}
				}
				goto case 3;
			case 1:
				((ParamVariableSelector)target).PreviewKeyDown += AfcLsbHBwuj;
				return;
			case 2:
				LbVariables = (ListBox)target;
				return;
			case 3:
				UPcLs4O15ym = true;
				return;
			case 4:
				VariableFilter = (SearchBar)target;
				VariableFilter.SearchStarted += QWSLsYjiW6e;
				return;
			case 5:
				{
					BtnNewVar = (Button)target;
					BtnNewVar.Click += sO2LsGotiCb;
					return;
				}
				end_IL_0021:
				break;
			}
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 3)
		{
			EventSetter eventSetter = new EventSetter();
			eventSetter.Event = UIElement.PreviewMouseLeftButtonUpEvent;
			eventSetter.Handler = new MouseButtonEventHandler(kXLLssAXs7G);
			((Style)target).Setters.Add(eventSetter);
			int num = 0;
			if (!N1uB0PFadDIvOQ16HCXA())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			eventSetter = new EventSetter();
			eventSetter.Event = FrameworkElement.RequestBringIntoViewEvent;
			eventSetter.Handler = new RequestBringIntoViewEventHandler(PcuLs6Ov4pb);
			((Style)target).Setters.Add(eventSetter);
		}
	}

	[CompilerGenerated]
	private void DyCLsXPfkRR()
	{
		VariableFilter.Focus();
	}

	[CompilerGenerated]
	private bool nhcLsmm9vQq(VariableOrValueSelectItem variableOrValueSelectItem_0)
	{
		if (variableOrValueSelectItem_0.Key == kN5LsjwwZ9A.Value)
		{
			return !variableOrValueSelectItem_0.IsVariable;
		}
		return false;
	}

	[CompilerGenerated]
	private bool xedLsKDJ74S(VariableOrValueSelectItem variableOrValueSelectItem_0)
	{
		if (variableOrValueSelectItem_0.Key == kN5LsjwwZ9A.VarKey)
		{
			return variableOrValueSelectItem_0.IsVariable;
		}
		return false;
	}

	internal static bool N1uB0PFadDIvOQ16HCXA()
	{
		return Q0aClOFavpurQJcJiHUG == null;
	}
}
