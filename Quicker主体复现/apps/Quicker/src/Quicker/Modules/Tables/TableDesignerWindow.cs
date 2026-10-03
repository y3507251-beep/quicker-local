using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using EOqy55MyMeuU2apYyog;
using GuvA3OiyFyyWpKJlb8c;
using Quicker.Actions.XActions.Storage;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.UI.Wpf;

namespace Quicker.Modules.Tables;

public class TableDesignerWindow : Window, IComponentConnector, IStyleConnector, IMockModalWindow
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnAdd_Click_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TableDesignerWindow _003C_003E4__this;

		private TableFieldEditWindow _003Cdlg_003E5__2;

		private TaskAwaiter<bool?> _003C_003Eu__1;

		private static object zl96fAcRvbef1e14P7PW;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			TableDesignerWindow tableDesignerWindow = _003C_003E4__this;
			try
			{
				TaskAwaiter<bool?> awaiter;
				if (num != 0)
				{
					_003Cdlg_003E5__2 = new TableFieldEditWindow(null, tableDesignerWindow.EZ2t2DnVLQm)
					{
						Owner = tableDesignerWindow
					};
					awaiter = _003Cdlg_003E5__2.MjdLOXIjD10(true).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						if (!Vc5inNcRdGGgwG53Umem())
						{
							switch (0)
							{
							}
						}
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<bool?>);
					num = -1;
					_003C_003E1__state = -1;
				}
				if (awaiter.GetResult() == true)
				{
					tableDesignerWindow.EZ2t2DnVLQm.Add(_003Cdlg_003E5__2.ResultField);
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Cdlg_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003Cdlg_003E5__2 = null;
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

		internal static bool Vc5inNcRdGGgwG53Umem()
		{
			return zl96fAcRvbef1e14P7PW == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnEdit_Click_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public object sender;

		public TableDesignerWindow _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object VkWhqocRkVab7p8jCAjn;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			TableDesignerWindow tableDesignerWindow = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					if (gVpjNTcRac76sX9bfyEY())
					{
						switch (0)
						{
						}
					}
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_009d;
				}
				if ((sender as FrameworkElement)?.Tag is TableField tableField_)
				{
					awaiter = tableDesignerWindow.Hitt2QZPSRf(tableField_).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_009d;
				}
				goto end_IL_000e;
				IL_009d:
				awaiter.GetResult();
				end_IL_000e:;
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

		internal static bool gVpjNTcRac76sX9bfyEY()
		{
			return VkWhqocRkVab7p8jCAjn == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CEditItemAsync_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public TableField item;

		public TableDesignerWindow _003C_003E4__this;

		private TableFieldEditWindow _003Cdlg_003E5__2;

		private TaskAwaiter<bool?> _003C_003Eu__1;

		internal static object iOxy2xcRN3XYFj0idUDl;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			TableDesignerWindow tableDesignerWindow = _003C_003E4__this;
			try
			{
				TaskAwaiter<bool?> awaiter;
				if (num != 0)
				{
					_003Cdlg_003E5__2 = new TableFieldEditWindow(item, tableDesignerWindow.EZ2t2DnVLQm)
					{
						Owner = tableDesignerWindow
					};
					awaiter = _003Cdlg_003E5__2.MjdLOXIjD10(true).GetAwaiter();
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
					_003C_003Eu__1 = default(TaskAwaiter<bool?>);
					num = -1;
					_003C_003E1__state = -1;
				}
				if (awaiter.GetResult() == true)
				{
					tableDesignerWindow.EZ2t2DnVLQm.Replace(item, _003Cdlg_003E5__2.ResultField);
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Cdlg_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003Cdlg_003E5__2 = null;
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

		internal static bool JedQsKcR91EZU4X3XeSo()
		{
			return iOxy2xcRN3XYFj0idUDl == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CListViewItem_MouseDoubleClick_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public object sender;

		public TableDesignerWindow _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object BCZNYncRuT5RgEplLAHY;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			TableDesignerWindow tableDesignerWindow = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_00a7;
				}
				if (((ListViewItem)sender).DataContext is TableField tableField_)
				{
					awaiter = tableDesignerWindow.Hitt2QZPSRf(tableField_).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						int num2 = 0;
						if (!jm7yGxcRopMcEeANpVhS())
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
					goto IL_00a7;
				}
				goto end_IL_0010;
				IL_00a7:
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

		internal static bool jm7yGxcRopMcEeANpVhS()
		{
			return BCZNYncRuT5RgEplLAHY == null;
		}
	}

	private SmartCollection<TableField> EZ2t2DnVLQm = new SmartCollection<TableField>();

	[CompilerGenerated]
	private bool? RG6t2dVBZJR;

	internal ListView FieldGrid;

	internal Button BtnAdd;

	internal Button BtnSave;

	internal Button BtnCancel;

	private bool Pmvt2oOcokp;

	internal static TableDesignerWindow xTDLN2Q2KPb8YtSdMUa6;

	public bool? Result
	{
		[CompilerGenerated]
		get
		{
			return RG6t2dVBZJR;
		}
		[CompilerGenerated]
		set
		{
			RG6t2dVBZJR = value;
		}
	}

	public TableDef GetResult()
	{
		return new TableDef
		{
			Fields = EZ2t2DnVLQm.ToList()
		};
	}

	public TableDesignerWindow(TableDef def)
	{
		InitializeComponent();
		EZ2t2DnVLQm.Reset(def.Fields);
		FieldGrid.ItemsSource = EZ2t2DnVLQm;
	}

	[AsyncStateMachine(typeof(_003CBtnAdd_Click_003Ed__7))]
	private void te5t2pa44kH(object sender, RoutedEventArgs e)
	{
		_003CBtnAdd_Click_003Ed__7 stateMachine = default(_003CBtnAdd_Click_003Ed__7);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CBtnEdit_Click_003Ed__8))]
	private void cDmt2BpU8cH(object sender, RoutedEventArgs e)
	{
		_003CBtnEdit_Click_003Ed__8 stateMachine = default(_003CBtnEdit_Click_003Ed__8);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = sender;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CEditItemAsync_003Ed__9))]
	private Task Hitt2QZPSRf(TableField tableField_0)
	{
		_003CEditItemAsync_003Ed__9 stateMachine = default(_003CEditItemAsync_003Ed__9);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.item = tableField_0;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private void Gs6t2jdslwY(object sender, RoutedEventArgs e)
	{
		if ((sender as FrameworkElement)?.Tag is TableField tableField && AppHelper.Confirm("您确认要删除列‘" + tableField.FieldKey + "’么？"))
		{
			EZ2t2DnVLQm.Remove(tableField);
		}
	}

	private void IIvt2npoGHX(object sender, RoutedEventArgs e)
	{
		this.ThNvuM5Q9GQ(true);
	}

	private void iYCt24HYSiO(object sender, RoutedEventArgs e)
	{
		Close();
	}

	[AsyncStateMachine(typeof(_003CListViewItem_MouseDoubleClick_003Ed__13))]
	private void hcPt25u9v58(object sender, MouseButtonEventArgs e)
	{
		_003CListViewItem_MouseDoubleClick_003Ed__13 stateMachine = default(_003CListViewItem_MouseDoubleClick_003Ed__13);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = sender;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!Pmvt2oOcokp)
		{
			Pmvt2oOcokp = true;
			Uri resourceLocator = new Uri("/Quicker;component/modules/tables/tabledesignerwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num = 1;
		while (true)
		{
			switch (connectionId)
			{
			default:
			{
				int num2 = 0;
				if (!tQJXsnQ2BenIV0aktXQy())
				{
					num2 = num;
				}
				switch (num2)
				{
				case 1:
					goto end_IL_002e;
				}
				goto case 3;
			}
			case 2:
				FieldGrid = (ListView)target;
				return;
			case 3:
			case 4:
				Pmvt2oOcokp = true;
				return;
			case 5:
				BtnAdd = (Button)target;
				BtnAdd.Click += te5t2pa44kH;
				return;
			case 6:
				BtnSave = (Button)target;
				BtnSave.Click += IIvt2npoGHX;
				return;
			case 7:
				{
					BtnCancel = (Button)target;
					BtnCancel.Click += iYCt24HYSiO;
					return;
				}
				end_IL_002e:
				break;
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 1:
		{
			EventSetter eventSetter = new EventSetter();
			eventSetter.Event = Control.MouseDoubleClickEvent;
			eventSetter.Handler = new MouseButtonEventHandler(hcPt25u9v58);
			((Style)target).Setters.Add(eventSetter);
			break;
		}
		case 3:
			((Button)target).Click += cDmt2BpU8cH;
			break;
		case 4:
			((Button)target).Click += Gs6t2jdslwY;
			break;
		case 2:
			break;
		}
	}

	internal static bool tQJXsnQ2BenIV0aktXQy()
	{
		return xTDLN2Q2KPb8YtSdMUa6 == null;
	}
}
