using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.UI;
using Quicker.View.X.Nodes;

namespace Quicker.View.X;

public class ActionStepsWrapper : UserControl, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec rbhSMjMhi7F;

		public static Func<StepNode, ActionStep> eoGSMn7BlOE;

		public static Func<ActionStep, StepNode> kEwSM495Ndy;

		private static _003C_003Ec Xr5mA5WH1CYG3OA8lbj7;

		static _003C_003Ec()
		{
			rbhSMjMhi7F = new _003C_003Ec();
		}

		internal ActionStep EhWSMBeQ36Y(StepNode x)
		{
			return x.Step;
		}

		internal StepNode h9kSMQX8mab(ActionStep x)
		{
			return x.CreateNode();
		}

		internal static bool lE6bNjWHK2JisyxrJNit()
		{
			return Xr5mA5WH1CYG3OA8lbj7 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateStep_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ActionStepsWrapper _003C_003E4__this;

		public XToolboxItem item;

		public int? insertIndex;

		private TaskAwaiter _003C_003Eu__1;

		internal static object RUNeZ0WHvC4NwZ2uhslP;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionStepsWrapper actionStepsWrapper = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = actionStepsWrapper.ActionStepList.CreateStep(item.Key, insertIndex).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						int num2 = 0;
						if (RUNeZ0WHvC4NwZ2uhslP != null)
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
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

		internal static bool f8NwsYWHdZv9e9r7p35e()
		{
			return RUNeZ0WHvC4NwZ2uhslP == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCreateStep_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ActionStepsWrapper _003C_003E4__this;

		public string stepRunnerKey;

		public int? insertIndex;

		public string controlFieldKey;

		private TaskAwaiter _003C_003Eu__1;

		private static object zAtvxJWHkhVR9VSLUixF;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionStepsWrapper actionStepsWrapper = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = actionStepsWrapper.ActionStepList.CreateStep(stepRunnerKey, insertIndex, controlFieldKey).GetAwaiter();
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
					if (zAtvxJWHkhVR9VSLUixF != null)
					{
						switch (0)
						{
						}
					}
				}
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

		static _003CCreateStep_003Ed__23()
		{
		}

		internal static bool kPky1UWHa1h1ZVJQLUdq()
		{
			return zAtvxJWHkhVR9VSLUixF == null;
		}

		internal static void gttZTmWHNPxDhjIOAacx()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CFindVisualChildren_003Ed__27<T> : IEnumerable<T>, IEnumerator<T>, IDisposable, IEnumerable, IEnumerator where T : DependencyObject
	{
		private int _003C_003E1__state;

		private T _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private DependencyObject depObj;

		public DependencyObject _003C_003E3__depObj;

		private int _003Ci_003E5__2;

		private DependencyObject _003Cchild_003E5__3;

		private IEnumerator<T> _003C_003E7__wrap3;

		private static object lLovn5WH98hAi7ygXVxk;

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
		public _003CFindVisualChildren_003Ed__27(int _003C_003E1__state)
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
				int num = default(int);
				int num2;
				T current;
				int num3 = default(int);
				switch (_003C_003E1__state)
				{
				default:
					return false;
				case 0:
					_003C_003E1__state = -1;
					if (depObj != null)
					{
						_003Ci_003E5__2 = 0;
						goto IL_00a3;
					}
					goto IL_013a;
				case 1:
					_003C_003E1__state = -1;
					goto IL_00e5;
				case 2:
					{
						_003C_003E1__state = -3;
						goto IL_0128;
					}
					IL_0128:
					if (!_003C_003E7__wrap3.MoveNext())
					{
						_003C_003Em__Finally1();
						_003C_003E7__wrap3 = null;
						_003Cchild_003E5__3 = null;
						num = _003Ci_003E5__2;
						num2 = 2;
						if (!JGnT21WHLF2yX0iWu1Oh())
						{
							goto IL_009d;
						}
						goto IL_0112;
					}
					current = _003C_003E7__wrap3.Current;
					_003C_003E2__current = current;
					_003C_003E1__state = 2;
					return true;
					IL_00a3:
					if (_003Ci_003E5__2 < VisualTreeHelper.GetChildrenCount(depObj))
					{
						_003Cchild_003E5__3 = VisualTreeHelper.GetChild(depObj, _003Ci_003E5__2);
						if (_003Cchild_003E5__3 != null && _003Cchild_003E5__3 is T)
						{
							_003C_003E2__current = (T)_003Cchild_003E5__3;
							_003C_003E1__state = 1;
							return true;
						}
						goto IL_00e5;
					}
					goto IL_013a;
					IL_013a:
					return false;
					IL_009d:
					num2 = num3;
					goto IL_0112;
					IL_00e5:
					_003C_003E7__wrap3 = FindVisualChildren<T>(_003Cchild_003E5__3).GetEnumerator();
					_003C_003E1__state = -3;
					num2 = 1;
					if (!JGnT21WHLF2yX0iWu1Oh())
					{
						goto IL_009d;
					}
					goto IL_0112;
					IL_0112:
					while (true)
					{
						switch (num2)
						{
						case 2:
							break;
						default:
							goto end_IL_0112;
						case 1:
							goto IL_0128;
						}
						_003Ci_003E5__2 = num + 1;
						num2 = 0;
						if (JGnT21WHLF2yX0iWu1Oh())
						{
							continue;
						}
						goto IL_009d;
						continue;
						end_IL_0112:
						break;
					}
					goto IL_00a3;
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
			_003CFindVisualChildren_003Ed__27<T> _003CFindVisualChildren_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CFindVisualChildren_003Ed__ = this;
			}
			else
			{
				_003CFindVisualChildren_003Ed__ = new _003CFindVisualChildren_003Ed__27<T>(0);
			}
			_003CFindVisualChildren_003Ed__.depObj = _003C_003E3__depObj;
			return _003CFindVisualChildren_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<T>)this).GetEnumerator();
		}

		internal static bool JGnT21WHLF2yX0iWu1Oh()
		{
			return lLovn5WH98hAi7ygXVxk == null;
		}
	}

	public static readonly DependencyProperty ActionVariablesProperty;

	private FullyObservableCollection<StepNode> grULI7gtlGd = new FullyObservableCollection<StepNode>();

	[CompilerGenerated]
	private EventHandler m_StepChanged;

	private bool hdLLIRBxOsT;

	private DebounceDispatcher bbDLIqHQq8L = new DebounceDispatcher();

	private bool GvNLIcaKAmv;

	private object BdwLIVYTZI2;

	internal ScrollViewer ScrollViewer;

	internal StepListControl ActionStepList;

	private bool DCbLIZrTgvg;

	internal static ActionStepsWrapper wprAuRFJcw8WYKdpEGNB;

	public ObservableCollection<ActionVariable> ActionVariables
	{
		get
		{
			return (ObservableCollection<ActionVariable>)GetValue(ActionVariablesProperty);
		}
		set
		{
			SetValue(ActionVariablesProperty, value);
		}
	}

	public event EventHandler StepChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = this.m_StepChanged;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_StepChanged, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = this.m_StepChanged;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_StepChanged, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public ActionStepsWrapper()
	{
		InitializeComponent();
		RoutedCommand command = new RoutedCommand
		{
			InputGestures = { (InputGesture)new KeyGesture(Key.C, ModifierKeys.Control) }
		};
		base.CommandBindings.Add(new CommandBinding(command, MHfLIChRdne));
		RoutedCommand command2 = new RoutedCommand
		{
			InputGestures = { (InputGesture)new KeyGesture(Key.V, ModifierKeys.Control) }
		};
		base.CommandBindings.Add(new CommandBinding(command2, vTDLIPmNBsF));
		RoutedCommand command3 = new RoutedCommand
		{
			InputGestures = { (InputGesture)new KeyGesture(Key.X, ModifierKeys.Control) }
		};
		base.CommandBindings.Add(new CommandBinding(command3, BB7LI0SW06W));
		RoutedCommand command4 = new RoutedCommand
		{
			InputGestures = { (InputGesture)new KeyGesture(Key.G, ModifierKeys.Control) }
		};
		base.CommandBindings.Add(new CommandBinding(command4, lqpLI28d2Gh));
		RoutedCommand command5 = new RoutedCommand
		{
			InputGestures = { (InputGesture)new KeyGesture(Key.I, ModifierKeys.Control) }
		};
		base.CommandBindings.Add(new CommandBinding(command5, kROLIvyi5mp));
		RoutedCommand command6 = new RoutedCommand
		{
			InputGestures = { (InputGesture)new KeyGesture(Key.I, ModifierKeys.Control | ModifierKeys.Shift) }
		};
		base.CommandBindings.Add(new CommandBinding(command6, TqtLIScJseL));
		RoutedCommand command7 = new RoutedCommand
		{
			InputGestures = { (InputGesture)new KeyGesture(Key.R, ModifierKeys.Control) }
		};
		base.CommandBindings.Add(new CommandBinding(command7, t2vLILxUd7n));
		RoutedCommand command8 = new RoutedCommand
		{
			InputGestures = { (InputGesture)new KeyGesture(Key.Up, ModifierKeys.Alt) }
		};
		base.CommandBindings.Add(new CommandBinding(command8, FkxLIgGQFRH));
		RoutedCommand command9 = new RoutedCommand
		{
			InputGestures = { (InputGesture)new KeyGesture(Key.Down, ModifierKeys.Alt) }
		};
		base.CommandBindings.Add(new CommandBinding(command9, nEMLItwWXJf));
		ActionStepList.SetSteps(grULI7gtlGd);
		grULI7gtlGd.CollectionChanged += dZeLIN0jORP;
		grULI7gtlGd.ItemPropertyChanged += dAKLIuJLbe9;
	}

	private void nEMLItwWXJf(object sender, ExecutedRoutedEventArgs e)
	{
		pPELIy0mbGs()?.AwxL1GKy4g5(1);
		e.Handled = true;
	}

	private void FkxLIgGQFRH(object sender, ExecutedRoutedEventArgs e)
	{
		pPELIy0mbGs()?.AwxL1GKy4g5(-1);
		e.Handled = true;
	}

	private void t2vLILxUd7n(object sender, ExecutedRoutedEventArgs e)
	{
		pPELIy0mbGs()?.bLhL1W9Hfvu("sys:repeat", true);
	}

	private void kROLIvyi5mp(object sender, ExecutedRoutedEventArgs e)
	{
		pPELIy0mbGs()?.bLhL1W9Hfvu("sys:if", true);
	}

	private void TqtLIScJseL(object sender, ExecutedRoutedEventArgs e)
	{
		pPELIy0mbGs()?.bLhL1W9Hfvu("sys:simpleIf", true);
	}

	private void lqpLI28d2Gh(object sender, ExecutedRoutedEventArgs e)
	{
		pPELIy0mbGs()?.tkcL1EowB31();
	}

	private void dAKLIuJLbe9(object sender, ItemPropertyChangedEventArgs e)
	{
		if (e.PropertyName == "Step")
		{
			ljbLIJF1vJB();
		}
	}

	private void dZeLIN0jORP(object sender, NotifyCollectionChangedEventArgs e)
	{
		ljbLIJF1vJB();
	}

	private void ljbLIJF1vJB()
	{
		if (!hdLLIRBxOsT)
		{
			bbDLIqHQq8L.Debounce(50, iuALIaYRNdY);
		}
	}

	public IList<ActionStep> GetSteps()
	{
		return grULI7gtlGd.Select(_003C_003Ec.eoGSMn7BlOE ?? (_003C_003Ec.eoGSMn7BlOE = _003C_003Ec.rbhSMjMhi7F.EhWSMBeQ36Y)).ToList();
	}

	public void SetSteps(IList<ActionStep> steps)
	{
		BdwLIVYTZI2 = null;
		try
		{
			hdLLIRBxOsT = true;
			grULI7gtlGd.Reset(steps?.Select(_003C_003Ec.kEwSM495Ndy ?? (_003C_003Ec.kEwSM495Ndy = _003C_003Ec.rbhSMjMhi7F.h9kSMQX8mab)));
		}
		finally
		{
			hdLLIRBxOsT = false;
		}
	}

	[AsyncStateMachine(typeof(_003CCreateStep_003Ed__22))]
	public Task CreateStep(XToolboxItem item, int? insertIndex)
	{
		_003CCreateStep_003Ed__22 stateMachine = default(_003CCreateStep_003Ed__22);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.item = item;
		stateMachine.insertIndex = insertIndex;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CCreateStep_003Ed__23))]
	public Task CreateStep(string stepRunnerKey, int? insertIndex, string controlFieldKey)
	{
		_003CCreateStep_003Ed__23 stateMachine = default(_003CCreateStep_003Ed__23);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.stepRunnerKey = stepRunnerKey;
		stateMachine.insertIndex = insertIndex;
		stateMachine.controlFieldKey = controlFieldKey;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private void BB7LI0SW06W(object sender, ExecutedRoutedEventArgs e)
	{
		pPELIy0mbGs()?.Cut();
	}

	private void MHfLIChRdne(object sender, ExecutedRoutedEventArgs e)
	{
		pPELIy0mbGs()?.Copy();
	}

	private void vTDLIPmNBsF(object sender, ExecutedRoutedEventArgs e)
	{
		if (BdwLIVYTZI2 != null)
		{
			pPELIy0mbGs()?.Paste();
		}
		else
		{
			ActionStepList.Paste();
		}
	}

	[IteratorStateMachine(typeof(_003CFindVisualChildren_003Ed__27<>))]
	public static IEnumerable<T> FindVisualChildren<T>(DependencyObject depObj) where T : DependencyObject
	{
		return new _003CFindVisualChildren_003Ed__27<T>(-2)
		{
			_003C_003E3__depObj = depObj
		};
	}

	private void sUuLIES4qIg(object sender, SelectionChangedEventArgs e)
	{
		if (GvNLIcaKAmv)
		{
			return;
		}
		GvNLIcaKAmv = true;
		if (BdwLIVYTZI2 != e.OriginalSource)
		{
			if (BdwLIVYTZI2 is ListBox listBox)
			{
				listBox.UnselectAll();
			}
			BdwLIVYTZI2 = e.OriginalSource;
		}
		GvNLIcaKAmv = false;
	}

	private StepListControl pPELIy0mbGs()
	{
		if (BdwLIVYTZI2 != null && BdwLIVYTZI2 is ListBox child)
		{
			StepListControl stepListControl = UIHelper.FindParent<StepListControl>(child);
			if (stepListControl != null)
			{
				return stepListControl;
			}
		}
		AppHelper.ShowInformation("未找到步骤列表");
		return null;
	}

	public void DoFilter(string keyWord)
	{
		string text = null;
		if (!string.IsNullOrWhiteSpace(keyWord))
		{
			int num = 0;
			if (!PlpQxVFJWpgZlj2iZWac())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (keyWord.StartsWith("step:"))
			{
				text = keyWord.Substring("step:".Length);
				keyWord = "";
			}
			else if (Regex.IsMatch(keyWord, "^\\d(\\.\\d)*$"))
			{
				text = keyWord;
			}
		}
		int num3 = 0;
		foreach (StepNode item in grULI7gtlGd)
		{
			item.DoFilter(keyWord, num3, text, (text != null) ? "" : null);
			num3++;
		}
	}

	public void ExpandAll()
	{
		foreach (StepNode item in grULI7gtlGd)
		{
			item.ExpandOrCollapse(false);
		}
	}

	public void CollapseAll()
	{
		foreach (StepNode item in grULI7gtlGd)
		{
			item.ExpandOrCollapse(true);
		}
	}

	public void ExpandByHighlight()
	{
		foreach (StepNode item in grULI7gtlGd)
		{
			item.ExpandOrCollapseByHighlight();
		}
	}

	private void xcgLI8vpCh8(object sender, KeyEventArgs e)
	{
		if (e.Key == Key.Home && (Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
		{
			ScrollViewer.ScrollToTop();
		}
		else if (e.Key == Key.End && (Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
		{
			ScrollViewer.ScrollToEnd();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!DCbLIZrTgvg)
		{
			DCbLIZrTgvg = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/x/controls/actionstepswrapper.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			DCbLIZrTgvg = true;
			break;
		case 1:
			((ActionStepsWrapper)target).PreviewKeyDown += xcgLI8vpCh8;
			break;
		case 2:
			ScrollViewer = (ScrollViewer)target;
			ScrollViewer.AddHandler(Selector.SelectionChangedEvent, new SelectionChangedEventHandler(sUuLIES4qIg));
			break;
		case 3:
			ActionStepList = (StepListControl)target;
			break;
		}
	}

	static ActionStepsWrapper()
	{
		ActionVariablesProperty = DependencyProperty.RegisterAttached("ActionVariables", typeof(ObservableCollection<ActionVariable>), typeof(ActionStepsWrapper), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
	}

	[CompilerGenerated]
	private void iuALIaYRNdY(object object_1)
	{
		this.m_StepChanged?.Invoke(this, EventArgs.Empty);
	}

	internal static bool PlpQxVFJWpgZlj2iZWac()
	{
		return wprAuRFJcw8WYKdpEGNB == null;
	}
}
