using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using aqQpqiYgxsE6yEqgoVK;
using NHCECkYPh8wr2fjXET3;
using Quicker.Domain;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.View.Controls;
using vnG2vQYciQtB4uvepMJ;
using xrMRsqY47xNH06m5F9X;

namespace Quicker.View.X.Controls;

public class TreeActionToolboxControl : UserControl, IComponentConnector, IStyleConnector, IToolBoxControl
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec c9vSUrrGLJu;

		public static Func<StepInParamDef, bool> X72SUpq7gYj;

		private static _003C_003Ec OYOcu5yFJdll8PTNOF3O;

		static _003C_003Ec()
		{
			c9vSUrrGLJu = new _003C_003Ec();
		}

		internal bool b9ASUxmWkiO(StepInParamDef x)
		{
			if (x.IsControlField && x.Type == VarType.Enum)
			{
				return x.SelectionItems.HasData();
			}
			return false;
		}

		internal static bool ggPcdAyFkTUG0J0J58P4()
		{
			return OYOcu5yFJdll8PTNOF3O == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass13_0
	{
		public IStepRunner oEkSUQQCvNH;

		private static _003C_003Ec__DisplayClass13_0 sTFySfyFraMKNEyWxESq;

		internal bool YYHSUBvVpfS(EgciYaY9HWn2ihF4Vkw x)
		{
			return x.Key == oEkSUQQCvNH.Category.ToString();
		}

		internal static bool cijOayyFNH1qbyiI7K56()
		{
			return sTFySfyFraMKNEyWxESq == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass19_0
	{
		public TreeActionToolboxControl rtJSUni1uAw;

		public FlFLPuYyXT5lnwN12if M2ZSU4K9qGF;

		private static _003C_003Ec__DisplayClass19_0 cJk4GsyFLNC5yD8IwZgn;

		internal void R9DSUjJowTC(object sender, RoutedEventArgs e)
		{
			((ActionDesignerWindow)Window.GetWindow(rtJSUni1uAw))?.HighlightText(M2ZSU4K9qGF.Name);
		}

		internal static bool aODG0nyFulnHImYfeRsA()
		{
			return cJk4GsyFLNC5yD8IwZgn == null;
		}
	}

	public static readonly DependencyProperty FilterTextProperty;

	[CompilerGenerated]
	private EventHandler xYRLbm11mF6;

	[CompilerGenerated]
	private readonly SmartCollection<EgciYaY9HWn2ihF4Vkw> O3HLbKpWhoY = new SmartCollection<EgciYaY9HWn2ihF4Vkw>();

	private Point UmELbxEXwm4;

	private j3rMU8Y10uUmMXKlqvc xbaLbrMuXhE;

	internal TreeActionToolboxControl TheControl;

	internal FilterBoxControl FilterControl;

	internal Button BtnExpandAll;

	internal Button BtnCollapseAll;

	internal TreeView trvTools;

	private bool WRNLbpr7eYP;

	internal static TreeActionToolboxControl ulMuU0FNtWaJ55AixrxH;

	public string FilterText
	{
		get
		{
			return (string)GetValue(FilterTextProperty);
		}
		set
		{
			SetValue(FilterTextProperty, value);
		}
	}

	public event EventHandler NodeDoubleClicked
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = xYRLbm11mF6;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref xYRLbm11mF6, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = xYRLbm11mF6;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref xYRLbm11mF6, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	[SpecialName]
	internal j3rMU8Y10uUmMXKlqvc B2OLb1H9YuK()
	{
		if (trvTools.SelectedItem != null)
		{
			return (j3rMU8Y10uUmMXKlqvc)trvTools.SelectedItem;
		}
		return null;
	}

	[SpecialName]
	[CompilerGenerated]
	internal SmartCollection<EgciYaY9HWn2ihF4Vkw> B9QLb6WuW7s()
	{
		return O3HLbKpWhoY;
	}

	public TreeActionToolboxControl()
	{
		InitializeComponent();
		cnWLbeW1yHm();
		trvTools.ItemsSource = B9QLb6WuW7s();
		jJ9LbIMcx3c();
		FilterControl.SetImeState(AppState.HHxtaMaoqJr().ToolboxSearchImeState);
	}

	private void cnWLbeW1yHm()
	{
		using IEnumerator<IStepRunner> enumerator = StepRunnerRegistry.GetAllRunners().GetEnumerator();
		int num2 = default(int);
		while (enumerator.MoveNext())
		{
			_003C_003Ec__DisplayClass13_0 _003C_003Ec__DisplayClass13_ = new _003C_003Ec__DisplayClass13_0();
			_003C_003Ec__DisplayClass13_.oEkSUQQCvNH = enumerator.Current;
			EgciYaY9HWn2ihF4Vkw egciYaY9HWn2ihF4Vkw = B9QLb6WuW7s().FirstOrDefault(_003C_003Ec__DisplayClass13_.YYHSUBvVpfS);
			if (egciYaY9HWn2ihF4Vkw == null)
			{
				egciYaY9HWn2ihF4Vkw = new EgciYaY9HWn2ihF4Vkw
				{
					Key = _003C_003Ec__DisplayClass13_.oEkSUQQCvNH.Category.ToString(),
					Name = _003C_003Ec__DisplayClass13_.oEkSUQQCvNH.Category.GetEnumDisplayName()
				};
				int num = 0;
				if (ulMuU0FNtWaJ55AixrxH != null)
				{
					num = num2;
				}
				switch (num)
				{
				}
				B9QLb6WuW7s().Add(egciYaY9HWn2ihF4Vkw);
			}
			FlFLPuYyXT5lnwN12if flFLPuYyXT5lnwN12if = new FlFLPuYyXT5lnwN12if();
			flFLPuYyXT5lnwN12if.Key = _003C_003Ec__DisplayClass13_.oEkSUQQCvNH.Key;
			flFLPuYyXT5lnwN12if.Name = _003C_003Ec__DisplayClass13_.oEkSUQQCvNH.Name;
			flFLPuYyXT5lnwN12if.Description = _003C_003Ec__DisplayClass13_.oEkSUQQCvNH.Description;
			flFLPuYyXT5lnwN12if.Icon = _003C_003Ec__DisplayClass13_.oEkSUQQCvNH.Icon;
			flFLPuYyXT5lnwN12if.rGYLbMDN29a(_003C_003Ec__DisplayClass13_.oEkSUQQCvNH.KeyWords);
			FlFLPuYyXT5lnwN12if flFLPuYyXT5lnwN12if2 = flFLPuYyXT5lnwN12if;
			egciYaY9HWn2ihF4Vkw.Items.Add(flFLPuYyXT5lnwN12if2);
			if (!_003C_003Ec__DisplayClass13_.oEkSUQQCvNH.InputParams.HasData())
			{
				continue;
			}
			StepInParamDef stepInParamDef = _003C_003Ec__DisplayClass13_.oEkSUQQCvNH.InputParams.FirstOrDefault(_003C_003Ec.X72SUpq7gYj ?? (_003C_003Ec.X72SUpq7gYj = _003C_003Ec.c9vSUrrGLJu.b9ASUxmWkiO));
			if (stepInParamDef == null)
			{
				continue;
			}
			foreach (SelectionItem selectionItem in stepInParamDef.SelectionItems)
			{
				SmartCollection<j3rMU8Y10uUmMXKlqvc> smartCollection = flFLPuYyXT5lnwN12if2.Items;
				LNofqKYUdVwgyXju86h lNofqKYUdVwgyXju86h = new LNofqKYUdVwgyXju86h();
				lNofqKYUdVwgyXju86h.Key = selectionItem.Value;
				lNofqKYUdVwgyXju86h.Name = selectionItem.Name;
				lNofqKYUdVwgyXju86h.Description = selectionItem.Description;
				lNofqKYUdVwgyXju86h.Icon = "";
				lNofqKYUdVwgyXju86h.KG5L6kLn0II(_003C_003Ec__DisplayClass13_.oEkSUQQCvNH.Key);
				smartCollection.Add(lNofqKYUdVwgyXju86h);
			}
		}
	}

	private void c9XLbYmCI5c(object sender, RoutedEventArgs e)
	{
		if (e.OriginalSource is TreeViewItem treeViewItem && !e.Handled && treeViewItem.DataContext is EgciYaY9HWn2ihF4Vkw)
		{
			treeViewItem.IsExpanded = !treeViewItem.IsExpanded;
			treeViewItem.IsSelected = false;
			e.Handled = true;
		}
	}

	private void FilterBoxControl_OnFilterChanged(object sender, EventArgs e)
	{
		jJ9LbIMcx3c();
	}

	private void jJ9LbIMcx3c()
	{
		string filterText = FilterText;
		FilterText = FilterControl.FilterText;
		foreach (EgciYaY9HWn2ihF4Vkw item in B9QLb6WuW7s())
		{
			item.H0tLbB30vkB(FilterControl.FilterText);
		}
		if (string.IsNullOrEmpty(filterText) || !string.IsNullOrEmpty(FilterText))
		{
			return;
		}
		foreach (EgciYaY9HWn2ihF4Vkw item2 in B9QLb6WuW7s())
		{
			Rp2LbHqrDZX(item2, false);
		}
	}

	private void FGALbW0oRvJ(object sender, MouseButtonEventArgs e)
	{
		_003C_003Ec__DisplayClass19_0 _003C_003Ec__DisplayClass19_ = new _003C_003Ec__DisplayClass19_0();
		_003C_003Ec__DisplayClass19_.rtJSUni1uAw = this;
		if (!(sender is TreeViewItem))
		{
			return;
		}
		if (e.ChangedButton == MouseButton.Left)
		{
			if (e.ClickCount == 2)
			{
				int num = 0;
				if (ulMuU0FNtWaJ55AixrxH != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				if (!(((sender as TreeViewItem).DataContext as j3rMU8Y10uUmMXKlqvc) is EgciYaY9HWn2ihF4Vkw))
				{
					xYRLbm11mF6?.Invoke(this, EventArgs.Empty);
					e.Handled = true;
				}
			}
			else
			{
				UmELbxEXwm4 = e.GetPosition(trvTools);
				xbaLbrMuXhE = (sender as TreeViewItem).DataContext as j3rMU8Y10uUmMXKlqvc;
			}
		}
		else if (e.ChangedButton == MouseButton.Right)
		{
			ContextMenu contextMenu = new ContextMenu();
			_003C_003Ec__DisplayClass19_.M2ZSU4K9qGF = (sender as TreeViewItem).DataContext as FlFLPuYyXT5lnwN12if;
			if (_003C_003Ec__DisplayClass19_.M2ZSU4K9qGF != null)
			{
				AppHelper.AddMenuItem(contextMenu.Items, "高亮步骤(_H)", "在步骤列表中高亮使用此模块的步骤", "fa:Light_Highlighter:#FF0000", _003C_003Ec__DisplayClass19_.R9DSUjJowTC);
				(sender as FrameworkElement).ContextMenu = contextMenu;
			}
		}
	}

	private void wubLbkb8F6c(object sender, MouseEventArgs e)
	{
		if (e.LeftButton == MouseButtonState.Pressed && xbaLbrMuXhE != null && !(xbaLbrMuXhE is EgciYaY9HWn2ihF4Vkw))
		{
			Point position = e.GetPosition(trvTools);
			if (Math.Abs(position.X - UmELbxEXwm4.X) > SystemParameters.MinimumHorizontalDragDistance || Math.Abs(position.Y - UmELbxEXwm4.Y) > SystemParameters.MinimumVerticalDragDistance)
			{
				AppHelper.DoDragDropWrap(trvTools, xbaLbrMuXhE, DragDropEffects.Copy);
			}
		}
	}

	public void FocusSearch()
	{
		FilterControl.SetFocus();
	}

	private void LcFLbGdBb36(object sender, RoutedEventArgs e)
	{
		foreach (EgciYaY9HWn2ihF4Vkw item in B9QLb6WuW7s())
		{
			Rp2LbHqrDZX(item, true);
		}
	}

	private void cGnLbsNNiRN(object sender, RoutedEventArgs e)
	{
		foreach (EgciYaY9HWn2ihF4Vkw item in B9QLb6WuW7s())
		{
			Rp2LbHqrDZX(item, false);
		}
	}

	private void Rp2LbHqrDZX(j3rMU8Y10uUmMXKlqvc j3rMU8Y10uUmMXKlqvc_0, bool bool_1)
	{
		j3rMU8Y10uUmMXKlqvc_0.IsNodeExpanded = bool_1;
		if (!j3rMU8Y10uUmMXKlqvc_0.Items.HasData())
		{
			return;
		}
		foreach (j3rMU8Y10uUmMXKlqvc item in j3rMU8Y10uUmMXKlqvc_0.Items)
		{
			if (!bool_1 || item is EgciYaY9HWn2ihF4Vkw)
			{
				Rp2LbHqrDZX(item, bool_1);
			}
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!WRNLbpr7eYP)
		{
			WRNLbpr7eYP = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/x/controls/treeactiontoolboxcontrol.xaml", UriKind.Relative);
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
		switch (connectionId)
		{
		default:
			WRNLbpr7eYP = true;
			break;
		case 1:
			TheControl = (TreeActionToolboxControl)target;
			break;
		case 2:
			FilterControl = (FilterBoxControl)target;
			break;
		case 3:
			BtnExpandAll = (Button)target;
			BtnExpandAll.Click += LcFLbGdBb36;
			break;
		case 4:
		{
			BtnCollapseAll = (Button)target;
			BtnCollapseAll.Click += cGnLbsNNiRN;
			int num = 0;
			if (ulMuU0FNtWaJ55AixrxH != null)
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
			trvTools = (TreeView)target;
			trvTools.AddHandler(TreeViewItem.SelectedEvent, new RoutedEventHandler(c9XLbYmCI5c));
			break;
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 6)
		{
			EventSetter eventSetter = new EventSetter();
			eventSetter.Event = UIElement.PreviewMouseMoveEvent;
			eventSetter.Handler = new MouseEventHandler(wubLbkb8F6c);
			((Style)target).Setters.Add(eventSetter);
			eventSetter = new EventSetter();
			eventSetter.Event = UIElement.PreviewMouseDownEvent;
			eventSetter.Handler = new MouseButtonEventHandler(FGALbW0oRvJ);
			((Style)target).Setters.Add(eventSetter);
			int num = 0;
			if (!SJFPd0FNSlYex85mia7C())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
	}

	static TreeActionToolboxControl()
	{
		FilterTextProperty = DependencyProperty.Register("FilterText", typeof(string), typeof(TreeActionToolboxControl), new PropertyMetadata((object)null));
	}

	internal static bool SJFPd0FNSlYex85mia7C()
	{
		return ulMuU0FNtWaJ55AixrxH == null;
	}
}
