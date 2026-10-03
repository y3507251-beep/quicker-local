using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using EOqy55MyMeuU2apYyog;
using GuvA3OiyFyyWpKJlb8c;
using Quicker.Domain;
using Quicker.Public.Entities;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.UI;
using Quicker.Utilities.UI.Wpf;
using Quicker.View.OperationItemEditor;

namespace Quicker.View.UI;

public class OperationEditorWindow : Window, IComponentConnector, IStyleConnector, IMockModalWindow
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec rp4S4rtlv23;

		public static Func<CommonOperationItem, ObservableOperationItem> gN9S4pfl4C0;

		private static _003C_003Ec jb7sYwWS8UAq9oaXk9ZQ;

		static _003C_003Ec()
		{
			rp4S4rtlv23 = new _003C_003Ec();
		}

		internal ObservableOperationItem NywS4xSlTZE(CommonOperationItem x)
		{
			return new ObservableOperationItem(x);
		}

		internal static bool OMj508WSR18EADByuXLG()
		{
			return jb7sYwWS8UAq9oaXk9ZQ == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass8_0
	{
		public ObservableOperationItem HAOS4Qs7maI;

		public OperationEditorWindow Q39S4jD2Q8o;

		private static _003C_003Ec__DisplayClass8_0 W3ULFWWSPDZP7NN7T2Zq;

		internal void cARS4B3cfnC()
		{
			Q39S4jD2Q8o.vPZLC8qyjt3(HAOS4Qs7maI);
		}

		internal static bool TWW2XtWSMiJIqtGwajCt()
		{
			return W3ULFWWSPDZP7NN7T2Zq == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnEdit_Click_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public OperationEditorWindow _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object fFvdVWWSxSBl7Go8jBfF;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			OperationEditorWindow operationEditorWindow = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = operationEditorWindow.rEaLCZlFvrm().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						if (fFvdVWWSxSBl7Go8jBfF == null)
						{
							switch (0)
							{
							}
						}
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

		internal static bool gX5fNeWSIq2Mak8CLEvo()
		{
			return fFvdVWWSxSBl7Go8jBfF == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnNewChild_Click_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public OperationEditorWindow _003C_003E4__this;

		private OperationItemEditor _003Ceditor_003E5__2;

		private TaskAwaiter<bool?> _003C_003Eu__1;

		private static object krDb3wWStBAErCTYoyBh;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			OperationEditorWindow operationEditorWindow = _003C_003E4__this;
			try
			{
        int num3 = default;
				TaskAwaiter<bool?> awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<bool?>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_0135;
				}
				ObservableOperationItem selectedItem = operationEditorWindow.lO5LCH6hA2p.SelectedItem;
				bool flag;
				if (selectedItem != null)
				{
					TreeViewItem treeViewItem = FindTviFromObjectRecursive(operationEditorWindow.ItemsTree, selectedItem);
					if (treeViewItem != null)
					{
						treeViewItem.IsExpanded = true;
					}
					flag = false;
					goto IL_00a7;
				}
				AppHelper.ShowWarning("请选择父节点。");
				goto end_IL_0010;
				IL_00f3:
				int num2;
				switch (num2)
				{
				case 1:
					break;
				case 2:
					goto IL_0106;
				default:
					goto IL_012c;
				}
				goto IL_00a0;
				IL_012c:
				if (!awaiter.IsCompleted)
				{
					num = 0;
					_003C_003E1__state = 0;
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_0135;
				IL_00a0:
				if (flag)
				{
					goto IL_00a7;
				}
				goto end_IL_0010;
				IL_0106:
				flag = _003Ceditor_003E5__2.ContinueAdd;
				_003Ceditor_003E5__2 = null;
				num2 = 0;
				if (vFthHdWSSWNe6avdorEF())
				{
					goto IL_00a0;
				}
				goto IL_00f3;
				IL_0135:
				num3 = default(int);
				if (awaiter.GetResult() == true)
				{
					CommonOperationItem resultItem = _003Ceditor_003E5__2.ResultItem;
					operationEditorWindow.lO5LCH6hA2p.AddChild(resultItem);
					num3 = 2;
					goto IL_0106;
				}
				goto end_IL_0010;
				IL_00a7:
				_003Ceditor_003E5__2 = new OperationItemEditor(null, operationEditorWindow.IqtLCsMSVPb)
				{
					Owner = operationEditorWindow
				};
				_003Ceditor_003E5__2.ContinueAdd = flag;
				awaiter = _003Ceditor_003E5__2.MjdLOXIjD10(true).GetAwaiter();
				num2 = 0;
				if (!vFthHdWSSWNe6avdorEF())
				{
					num2 = num3;
				}
				goto IL_00f3;
				end_IL_0010:;
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

		internal static bool vFthHdWSSWNe6avdorEF()
		{
			return krDb3wWStBAErCTYoyBh == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnNewItem_Click_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public OperationEditorWindow _003C_003E4__this;

		private OperationItemEditor _003Ceditor_003E5__2;

		private TaskAwaiter<bool?> _003C_003Eu__1;

		internal static object xQBiN9WST7CjQ65qprsY;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			OperationEditorWindow operationEditorWindow = _003C_003E4__this;
			try
			{
        CommonOperationItem resultItem = default;
        _003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default;
				bool flag;
				if (num != 0)
				{
					flag = false;
					goto IL_0096;
				}
				TaskAwaiter<bool?> awaiter = _003C_003Eu__1;
				_003C_003Eu__1 = default(TaskAwaiter<bool?>);
				num = -1;
				_003C_003E1__state = -1;
				int num2 = 0;
				if (xQBiN9WST7CjQ65qprsY != null)
				{
					goto IL_0109;
				}
				goto IL_010d;
				IL_0109:
				int num3 = default(int);
				num2 = num3;
				goto IL_010d;
				IL_00cd:
				_003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
				resultItem = default(CommonOperationItem);
				if (awaiter.GetResult() == true)
				{
					_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0
					{
						Q39S4jD2Q8o = operationEditorWindow
					};
					resultItem = _003Ceditor_003E5__2.ResultItem;
					num2 = 1;
					if (!YpgFhoWSmZRXHiKRKQ2H())
					{
						goto IL_0109;
					}
					goto IL_010d;
				}
				goto end_IL_0010;
				IL_0096:
				_003Ceditor_003E5__2 = new OperationItemEditor(null, operationEditorWindow.IqtLCsMSVPb)
				{
					Owner = operationEditorWindow
				};
				awaiter = _003Ceditor_003E5__2.MjdLOXIjD10(true).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = 0;
					_003C_003E1__state = 0;
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_00cd;
				IL_010d:
				switch (num2)
				{
				case 1:
					break;
				default:
					goto IL_00cd;
				}
				_003C_003Ec__DisplayClass8_.HAOS4Qs7maI = operationEditorWindow.lO5LCH6hA2p.AddItem(resultItem);
				operationEditorWindow.Dispatcher.InvokeAsync(_003C_003Ec__DisplayClass8_.cARS4B3cfnC);
				flag = _003Ceditor_003E5__2.ContinueAdd;
				_003Ceditor_003E5__2 = null;
				if (flag)
				{
					goto IL_0096;
				}
				end_IL_0010:;
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

		internal static bool YpgFhoWSmZRXHiKRKQ2H()
		{
			return xQBiN9WST7CjQ65qprsY == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CEditSelectedItemAsync_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public OperationEditorWindow _003C_003E4__this;

		private OperationItemEditor _003Ceditor_003E5__2;

		private TaskAwaiter<bool?> _003C_003Eu__1;

		private static object jx7WwUWS7londwqLwp0b;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			OperationEditorWindow operationEditorWindow = _003C_003E4__this;
			try
			{
				TaskAwaiter<bool?> awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					int num2 = 0;
					if (jx7WwUWS7londwqLwp0b != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					do
					{
						switch (num2)
						{
						default:
							goto IL_00a7;
						case 1:
							break;
						}
						break;
						IL_00a7:
						_003C_003Eu__1 = default(TaskAwaiter<bool?>);
						num = -1;
						_003C_003E1__state = -1;
						num2 = 1;
					}
					while (jx7WwUWS7londwqLwp0b == null);
					goto IL_00d9;
				}
				if (operationEditorWindow.lO5LCH6hA2p.SelectedItem != null)
				{
					_003Ceditor_003E5__2 = new OperationItemEditor(operationEditorWindow.lO5LCH6hA2p.SelectedItem, operationEditorWindow.IqtLCsMSVPb)
					{
						Owner = operationEditorWindow
					};
					awaiter = _003Ceditor_003E5__2.MjdLOXIjD10(true).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00d9;
				}
				goto end_IL_0010;
				IL_00d9:
				if (awaiter.GetResult() == true)
				{
					_003Ceditor_003E5__2.ResultItem.CopyPropsTo(operationEditorWindow.lO5LCH6hA2p.SelectedItem);
					if (operationEditorWindow.ItemsTree.ItemContainerGenerator.ContainerFromItem(operationEditorWindow.lO5LCH6hA2p.SelectedItem) is TreeViewItem treeViewItem)
					{
						treeViewItem.IsExpanded = true;
					}
				}
				_003Ceditor_003E5__2 = null;
				end_IL_0010:;
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

		internal static bool rWavNCWS4xDQ53uwIRmO()
		{
			return jx7WwUWS7londwqLwp0b == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnItemMouseDoubleClick_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public object sender;

		public OperationEditorWindow _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private static object gnRZftWSHNgJp7hxUq3v;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			OperationEditorWindow operationEditorWindow = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					int num2 = 0;
					if (gnRZftWSHNgJp7hxUq3v != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
					goto IL_00a9;
				}
				if (!(sender is TreeViewItem) || ((TreeViewItem)sender).IsSelected)
				{
					awaiter = operationEditorWindow.rEaLCZlFvrm().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00a9;
				}
				goto end_IL_0010;
				IL_00a9:
				awaiter.GetResult();
				end_IL_0010:;
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

		internal static bool s8lKPIWSznNnPDP3RV95()
		{
			return gnRZftWSHNgJp7hxUq3v == null;
		}
	}

	private readonly bool IqtLCsMSVPb;

	private OperationEditorWindowVm lO5LCH6hA2p;

	[CompilerGenerated]
	private bool? KIeLC1xMR3U;

	internal TreeView ItemsTree;

	internal Button BtnExpandAll;

	internal Button BtnCollapseAll;

	internal Button BtnNewItem;

	internal Button BtnNewChild;

	internal Button BtnEdit;

	internal Button BtnDelete;

	internal Button BtnCopyText;

	internal Button BtnCopyJson;

	internal Button BtnSave;

	internal Button BtnCancel;

	private bool NacLCbqHrWg;

	internal static OperationEditorWindow XBPeYKFEjuxJ6fl1OE3t;

	public bool? Result
	{
		[CompilerGenerated]
		get
		{
			return KIeLC1xMR3U;
		}
		[CompilerGenerated]
		set
		{
			KIeLC1xMR3U = value;
		}
	}

	public IList<CommonOperationItem> ResultItems => lO5LCH6hA2p.GetItems();

	public OperationEditorWindow(bool onlyData, IList<CommonOperationItem> items)
	{
		IqtLCsMSVPb = onlyData;
		lO5LCH6hA2p = new OperationEditorWindowVm(onlyData);
		if (items.HasData())
		{
			lO5LCH6hA2p.Items.Reset(items.Select(_003C_003Ec.gN9S4pfl4C0 ?? (_003C_003Ec.gN9S4pfl4C0 = _003C_003Ec.rp4S4rtlv23.NywS4xSlTZE)));
		}
		base.DataContext = lO5LCH6hA2p;
		InitializeComponent();
		base.Loaded += IZdLCEaQRld;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void IZdLCEaQRld(object sender, RoutedEventArgs e)
	{
		OTLLCqobHsd();
	}

	private void G8iLCy1Ht39(object sender, RoutedPropertyChangedEventArgs<object> e)
	{
		lO5LCH6hA2p.SelectedItem = e.NewValue as ObservableOperationItem;
	}

	private void vPZLC8qyjt3(ObservableOperationItem observableOperationItem_0)
	{
		TreeViewItem treeViewItem = FindTviFromObjectRecursive(ItemsTree, observableOperationItem_0);
		if (treeViewItem != null)
		{
			treeViewItem.IsSelected = true;
		}
	}

	public static TreeViewItem FindTviFromObjectRecursive(ItemsControl ic, object o)
	{
		if (ic.ItemContainerGenerator.ContainerFromItem(o) is TreeViewItem result)
		{
			return result;
		}
		foreach (object item in (IEnumerable)ic.Items)
		{
			TreeViewItem treeViewItem = FindTviFromObjectRecursive(ic.ItemContainerGenerator.ContainerFromItem(item) as TreeViewItem, o);
			if (treeViewItem != null)
			{
				return treeViewItem;
			}
		}
		return null;
	}

	[AsyncStateMachine(typeof(_003CBtnNewItem_Click_003Ed__8))]
	private void a0wLCakM3jJ(object sender, RoutedEventArgs e)
	{
		_003CBtnNewItem_Click_003Ed__8 stateMachine = default(_003CBtnNewItem_Click_003Ed__8);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CBtnNewChild_Click_003Ed__9))]
	private void DhgLC7T4IKd(object sender, RoutedEventArgs e)
	{
		_003CBtnNewChild_Click_003Ed__9 stateMachine = default(_003CBtnNewChild_Click_003Ed__9);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void Of7LCRcfpEx(object sender, RoutedEventArgs e)
	{
		OTLLCqobHsd();
	}

	private void OTLLCqobHsd()
	{
		foreach (object item in (IEnumerable)ItemsTree.Items)
		{
			if (ItemsTree.ItemContainerGenerator.ContainerFromItem(item) is TreeViewItem treeViewItem)
			{
				treeViewItem.ExpandSubtree();
			}
		}
	}

	private void qXZLCcDhaet(object sender, RoutedEventArgs e)
	{
		foreach (object item in (IEnumerable)ItemsTree.Items)
		{
			if (ItemsTree.ItemContainerGenerator.ContainerFromItem(item) is TreeViewItem treeViewItem)
			{
				treeViewItem.IsExpanded = false;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CBtnEdit_Click_003Ed__13))]
	private void zi8LCVBko5s(object sender, RoutedEventArgs e)
	{
		_003CBtnEdit_Click_003Ed__13 stateMachine = default(_003CBtnEdit_Click_003Ed__13);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CEditSelectedItemAsync_003Ed__14))]
	private Task rEaLCZlFvrm()
	{
		_003CEditSelectedItemAsync_003Ed__14 stateMachine = default(_003CEditSelectedItemAsync_003Ed__14);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private void fbYLC9i575C(object sender, RoutedEventArgs e)
	{
		lVELChrvuEF(false);
	}

	private void lVELChrvuEF(bool bool_2)
	{
		if (lO5LCH6hA2p.SelectedItem != null)
		{
			if (bool_2 || AppHelper.Confirm("您确认要删除 " + lO5LCH6hA2p.SelectedItem.Title + " 么？"))
			{
				lO5LCH6hA2p.DeleteSelectedItem();
			}
		}
		else
		{
			AppHelper.ShowWarning("请选择要删除的节点。");
		}
	}

	private void jmQLCehl8EC(object sender, RoutedEventArgs e)
	{
		AppHelper.TryCopy(lO5LCH6hA2p.GetIndentTextData(), true);
	}

	private void jx3LCYuBh5H(object sender, RoutedEventArgs e)
	{
		AppHelper.TryCopy(lO5LCH6hA2p.GetJsonTextData(), true);
	}

	private void YBLLCIc3MbI(object sender, RoutedEventArgs e)
	{
		this.ThNvuM5Q9GQ(true);
	}

	private void BRXLCW5QGfJ(object sender, RoutedEventArgs e)
	{
		Close();
	}

	public string GetIndentTextData()
	{
		return lO5LCH6hA2p.GetIndentTextData();
	}

	[AsyncStateMachine(typeof(_003COnItemMouseDoubleClick_003Ed__28))]
	private void H0cLCk4TaR3(object sender, MouseButtonEventArgs e)
	{
		_003COnItemMouseDoubleClick_003Ed__28 stateMachine = default(_003COnItemMouseDoubleClick_003Ed__28);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = sender;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void bTMLCGGZx53(object sender, KeyEventArgs e)
	{
		if (e.Key == Key.Delete)
		{
			lVELChrvuEF(true);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!NacLCbqHrWg)
		{
			NacLCbqHrWg = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/operationitemeditor/operationeditorwindow.xaml", UriKind.Relative);
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
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num;
		int num2 = default(int);
		switch (connectionId)
		{
		case 1:
			ItemsTree = (TreeView)target;
			ItemsTree.PreviewKeyDown += bTMLCGGZx53;
			ItemsTree.SelectedItemChanged += G8iLCy1Ht39;
			break;
		default:
			NacLCbqHrWg = true;
			break;
		case 3:
			BtnExpandAll = (Button)target;
			BtnExpandAll.Click += Of7LCRcfpEx;
			break;
		case 4:
			BtnCollapseAll = (Button)target;
			BtnCollapseAll.Click += qXZLCcDhaet;
			break;
		case 5:
			BtnNewItem = (Button)target;
			BtnNewItem.Click += a0wLCakM3jJ;
			break;
		case 6:
			BtnNewChild = (Button)target;
			BtnNewChild.Click += DhgLC7T4IKd;
			num = 1;
			if (XBPeYKFEjuxJ6fl1OE3t != null)
			{
				goto IL_017c;
			}
			goto IL_0180;
		case 7:
			BtnEdit = (Button)target;
			BtnEdit.Click += zi8LCVBko5s;
			break;
		case 8:
			BtnDelete = (Button)target;
			BtnDelete.Click += fbYLC9i575C;
			break;
		case 9:
			BtnCopyText = (Button)target;
			num = 0;
			if (!ADSuYsFEDsXnB1YQOUp6())
			{
				goto IL_017c;
			}
			goto IL_0180;
		case 10:
			BtnCopyJson = (Button)target;
			BtnCopyJson.Click += jx3LCYuBh5H;
			break;
		case 11:
			BtnSave = (Button)target;
			BtnSave.Click += YBLLCIc3MbI;
			break;
		case 12:
			{
				BtnCancel = (Button)target;
				BtnCancel.Click += BRXLCW5QGfJ;
				break;
			}
			IL_017c:
			num = num2;
			goto IL_0180;
			IL_0180:
			switch (num)
			{
			default:
				BtnCopyText.Click += jmQLCehl8EC;
				break;
			case 1:
				break;
			}
			break;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 2)
		{
			EventSetter eventSetter = new EventSetter();
			eventSetter.Event = Control.MouseDoubleClickEvent;
			eventSetter.Handler = new MouseButtonEventHandler(H0cLCk4TaR3);
			((Style)target).Setters.Add(eventSetter);
		}
	}

	internal static bool ADSuYsFEDsXnB1YQOUp6()
	{
		return XBPeYKFEjuxJ6fl1OE3t == null;
	}
}
