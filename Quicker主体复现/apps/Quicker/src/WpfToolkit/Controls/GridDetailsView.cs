using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;

namespace WpfToolkit.Controls;

public class GridDetailsView : GridView, IComponentConnector, IStyleConnector
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CContainer_PreviewMouseDown_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public MouseButtonEventArgs args;

		public object sender;

		public GridDetailsView _003C_003E4__this;

		private double _003CsourceHeight_003E5__2;

		private int _003Ci_003E5__3;

		private TaskAwaiter _003C_003Eu__1;

		private static object qHuivdcnNNtZ6NsvtKEA;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			GridDetailsView gridDetailsView = _003C_003E4__this;
			try
			{
				int num2;
				if (num != 0)
				{
					num2 = 0;
					if (!dnAAOYcn9O6VIu56Yy9F())
					{
						goto IL_010d;
					}
					goto IL_0111;
				}
				TaskAwaiter awaiter = _003C_003Eu__1;
				_003C_003Eu__1 = default(TaskAwaiter);
				num = -1;
				_003C_003E1__state = -1;
				goto IL_017b;
				IL_0159:
				if (_003Ci_003E5__3 >= 0)
				{
					if (gridDetailsView.lS9vakZBwM)
					{
						gridDetailsView.ERjvPsRDBY(_003CsourceHeight_003E5__2 / 20.0 * (double)_003Ci_003E5__3);
						if (_003Ci_003E5__3 == 0)
						{
							goto IL_0167;
						}
						awaiter = Task.Delay(15).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							num2 = 1;
							if (qHuivdcnNNtZ6NsvtKEA != null)
							{
								goto IL_010d;
							}
							goto IL_0111;
						}
						goto IL_017b;
					}
				}
				else
				{
					gridDetailsView.FsDvyON6qf = null;
					gridDetailsView.ExpandedItem = null;
					gridDetailsView.lS9vakZBwM = false;
				}
				goto end_IL_0010;
				IL_017b:
				awaiter.GetResult();
				goto IL_0167;
				IL_010d:
				int num3 = default(int);
				num2 = num3;
				goto IL_0111;
				IL_0111:
				while (true)
				{
					switch (num2)
					{
					default:
						if (args.LeftButton == MouseButtonState.Pressed)
						{
							object dataContext = ((FrameworkElement)sender).DataContext;
							if (dataContext != gridDetailsView.ExpandedItem)
							{
								gridDetailsView.ExpandedItem = dataContext;
								goto end_IL_0111;
							}
							goto IL_00f0;
						}
						goto end_IL_0111;
					case 2:
						if (gridDetailsView.E1cvCXwvsL() == double.PositiveInfinity)
						{
							gridDetailsView.ERjvPsRDBY(gridDetailsView.OmnvJieBrH());
						}
						_003CsourceHeight_003E5__2 = gridDetailsView.E1cvCXwvsL();
						_003Ci_003E5__3 = 20;
						break;
					case 1:
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0159;
					IL_00f0:
					gridDetailsView.APOv8nLbJ6 = false;
					gridDetailsView.lS9vakZBwM = true;
					num2 = 2;
					if (dnAAOYcn9O6VIu56Yy9F())
					{
						continue;
					}
					goto IL_010d;
					continue;
					end_IL_0111:
					break;
				}
				goto end_IL_0010;
				IL_0167:
				_003Ci_003E5__3--;
				goto IL_0159;
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

		internal static bool dnAAOYcn9O6VIu56Yy9F()
		{
			return qHuivdcnNNtZ6NsvtKEA == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CExpandedItemContainerRoot_Loaded_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public GridDetailsView _003C_003E4__this;

		public object sender;

		private double _003CtargetHeight_003E5__2;

		private int _003Ci_003E5__3;

		private TaskAwaiter _003C_003Eu__1;

		internal static object PrvKR8cno7io7Ac5fHFJ;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			GridDetailsView gridDetailsView = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter = default(TaskAwaiter);
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_0151;
				}
				gridDetailsView.lS9vakZBwM = false;
				if (gridDetailsView.FsDvyON6qf == null)
				{
					gridDetailsView.FsDvyON6qf = (FrameworkElement)sender;
					gridDetailsView.ERjvPsRDBY(0.0);
					_003CtargetHeight_003E5__2 = gridDetailsView.OmnvJieBrH();
					gridDetailsView.APOv8nLbJ6 = true;
					_003Ci_003E5__3 = 0;
					goto IL_00af;
				}
				gridDetailsView.FsDvyON6qf = (FrameworkElement)sender;
				gridDetailsView.ERjvPsRDBY(double.PositiveInfinity);
				goto end_IL_0010;
				IL_0151:
				awaiter.GetResult();
				goto IL_0131;
				IL_0148:
				if (!awaiter.IsCompleted)
				{
					num = 0;
					_003C_003E1__state = 0;
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_0151;
				IL_0112:
				int num2 = default(int);
				_003Ci_003E5__3 = num2 + 1;
				goto IL_00af;
				IL_0131:
				num2 = _003Ci_003E5__3;
				int num3 = 0;
				if (!NjWFbtcnf84NosEGvvBY())
				{
					goto IL_0112;
				}
				goto IL_011e;
				IL_00af:
				if (_003Ci_003E5__3 <= 20)
				{
					if (gridDetailsView.APOv8nLbJ6)
					{
						gridDetailsView.ERjvPsRDBY(_003CtargetHeight_003E5__2 / 20.0 * (double)_003Ci_003E5__3);
						if (_003Ci_003E5__3 != 20)
						{
							awaiter = Task.Delay(15).GetAwaiter();
							num3 = 1;
							if (PrvKR8cno7io7Ac5fHFJ != null)
							{
								int num4 = default(int);
								num3 = num4;
							}
							goto IL_011e;
						}
						goto IL_0131;
					}
				}
				else
				{
					gridDetailsView.ERjvPsRDBY(double.PositiveInfinity);
					gridDetailsView.APOv8nLbJ6 = false;
				}
				goto end_IL_0010;
				IL_011e:
				switch (num3)
				{
				case 2:
					break;
				default:
					goto IL_0112;
				case 1:
					goto IL_0148;
				}
				goto IL_00af;
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

		internal static bool NjWFbtcnf84NosEGvvBY()
		{
			return PrvKR8cno7io7Ac5fHFJ == null;
		}
	}

	public static readonly DependencyProperty ExpandedItemTemplateProperty;

	public static readonly DependencyProperty ExpandedItemProperty;

	private FrameworkElement FsDvyON6qf;

	private bool APOv8nLbJ6;

	private bool lS9vakZBwM;

	internal GridDetailsView uc;

	private bool Gjgv7WMAHv;

	private static GridDetailsView jyuspvpgKgU9UTwYFiJ;

	public DataTemplate ExpandedItemTemplate
	{
		get
		{
			return (DataTemplate)GetValue(ExpandedItemTemplateProperty);
		}
		set
		{
			SetValue(ExpandedItemTemplateProperty, value);
		}
	}

	public object ExpandedItem
	{
		get
		{
			return GetValue(ExpandedItemProperty);
		}
		private set
		{
			SetValue(ExpandedItemProperty, value);
		}
	}

	public GridDetailsView()
	{
		InitializeComponent();
	}

	protected override DependencyObject GetContainerForItemOverride()
	{
		FrameworkElement obj = (FrameworkElement)base.GetContainerForItemOverride();
		obj.PreviewMouseDown += Iakv2D2RSO;
		return obj;
	}

	[AsyncStateMachine(typeof(_003CContainer_PreviewMouseDown_003Ed__13))]
	private void Iakv2D2RSO(object sender, MouseButtonEventArgs e)
	{
		_003CContainer_PreviewMouseDown_003Ed__13 stateMachine = default(_003CContainer_PreviewMouseDown_003Ed__13);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = sender;
		stateMachine.args = e;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CExpandedItemContainerRoot_Loaded_003Ed__14))]
	private void NCXvu5A5hj(object sender, RoutedEventArgs e)
	{
		_003CExpandedItemContainerRoot_Loaded_003Ed__14 stateMachine = default(_003CExpandedItemContainerRoot_Loaded_003Ed__14);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = sender;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[SpecialName]
	private double OmnvJieBrH()
	{
		if (base.Orientation == Orientation.Vertical)
		{
			return FsDvyON6qf.DesiredSize.Height;
		}
		return FsDvyON6qf.DesiredSize.Width;
	}

	[SpecialName]
	private double E1cvCXwvsL()
	{
		if (base.Orientation == Orientation.Vertical)
		{
			return FsDvyON6qf.MaxHeight;
		}
		return FsDvyON6qf.MaxWidth;
	}

	[SpecialName]
	private void ERjvPsRDBY(double value)
	{
		if (base.Orientation == Orientation.Vertical)
		{
			FsDvyON6qf.MaxHeight = value;
		}
		else
		{
			FsDvyON6qf.MaxWidth = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!Gjgv7WMAHv)
		{
			Gjgv7WMAHv = true;
			Uri resourceLocator = new Uri("/Quicker;component/utilities/3rd/virtualwrappanel/griddetailsview.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 1)
		{
			uc = (GridDetailsView)target;
		}
		else
		{
			Gjgv7WMAHv = true;
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 2)
		{
			((StackPanel)target).Loaded += NCXvu5A5hj;
		}
	}

	static GridDetailsView()
	{
		ExpandedItemTemplateProperty = DependencyProperty.Register("ExpandedItemTemplate", typeof(DataTemplate), typeof(GridDetailsView), new FrameworkPropertyMetadata(null));
		ExpandedItemProperty = DependencyProperty.Register("ExpandedItem", typeof(object), typeof(GridDetailsView), new FrameworkPropertyMetadata(null));
	}

	internal static bool CbhQFwpP5nL50sTmbMe()
	{
		return jyuspvpgKgU9UTwYFiJ == null;
	}
}
