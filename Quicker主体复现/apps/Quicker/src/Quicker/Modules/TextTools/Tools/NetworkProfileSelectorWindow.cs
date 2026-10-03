using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Markup;
using GuvA3OiyFyyWpKJlb8c;
using Quicker.Domain;
using Quicker.Utilities;
using Quicker.Utilities.UI;
using Quicker.Utilities.UI.Wpf;
using Windows.Networking.Connectivity;

namespace Quicker.Modules.TextTools.Tools;

public class NetworkProfileSelectorWindow : Window, IComponentConnector, IMockModalWindow
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnLoaded_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public NetworkProfileSelectorWindow _003C_003E4__this;

		private static object deYVr3cYM8wwrbAYQeQA;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			NetworkProfileSelectorWindow networkProfileSelectorWindow = _003C_003E4__this;
			try
			{
				try
				{
					IEnumerator<ConnectionProfile> enumerator = NetworkInformation.GetConnectionProfiles().GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							ConnectionProfile current = enumerator.Current;
							networkProfileSelectorWindow.b5ltSwSefIC.Add(current);
						}
					}
					finally
					{
						if (num < 0)
						{
							enumerator?.Dispose();
						}
					}
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("获取网络连接出错：" + ex.Message);
				}
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

		internal static bool tKllImcYUok1jXHWDIZG()
		{
			return deYVr3cYM8wwrbAYQeQA == null;
		}
	}

	private ObservableCollection<ConnectionProfile> b5ltSwSefIC = new ObservableCollection<ConnectionProfile>();

	[CompilerGenerated]
	private ConnectionProfile okBtStSe4Hh;

	[CompilerGenerated]
	private bool? L18tSggLwxT;

	internal ListBox DeviceList;

	internal Button BtnOk;

	internal Button BtnCancel;

	private bool z5YtSL1N8H9;

	private static NetworkProfileSelectorWindow NMA0kOQpGYauE0OyEn47;

	public ConnectionProfile SelectedProfile
	{
		[CompilerGenerated]
		get
		{
			return okBtStSe4Hh;
		}
		[CompilerGenerated]
		set
		{
			okBtStSe4Hh = value;
		}
	}

	public bool? Result
	{
		[CompilerGenerated]
		get
		{
			return L18tSggLwxT;
		}
		[CompilerGenerated]
		set
		{
			L18tSggLwxT = value;
		}
	}

	public NetworkProfileSelectorWindow()
	{
		InitializeComponent();
		DeviceList.ItemsSource = b5ltSwSefIC;
		base.Loaded += i2MtviJf8Ub;
		base.Closing += qAatvl0qFWj;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	private void qAatvl0qFWj(object sender, CancelEventArgs e)
	{
	}

	[AsyncStateMachine(typeof(_003COnLoaded_003Ed__8))]
	private void i2MtviJf8Ub(object sender, RoutedEventArgs e)
	{
		_003COnLoaded_003Ed__8 stateMachine = default(_003COnLoaded_003Ed__8);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void SX4tv3DKbjk(object sender, RoutedEventArgs e)
	{
		LP8tvfOitot();
	}

	private void LP8tvfOitot()
	{
		if (DeviceList.SelectedItem == null)
		{
			AppHelper.ShowWarning("请选择一个网络。");
			return;
		}
		object selectedItem = DeviceList.SelectedItem;
		SelectedProfile = (ConnectionProfile)((selectedItem is ConnectionProfile) ? selectedItem : null);
		this.ThNvuM5Q9GQ(true);
	}

	private void LdVtvz4xZkO(object sender, RoutedEventArgs e)
	{
		Close();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!z5YtSL1N8H9)
		{
			z5YtSL1N8H9 = true;
			Uri resourceLocator = new Uri("/Quicker;component/modules/texttools/tools/networkprofileselectorwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			z5YtSL1N8H9 = true;
			break;
		case 1:
			DeviceList = (ListBox)target;
			break;
		case 2:
			BtnOk = (Button)target;
			BtnOk.Click += SX4tv3DKbjk;
			break;
		case 3:
			BtnCancel = (Button)target;
			BtnCancel.Click += LdVtvz4xZkO;
			break;
		}
	}

	internal static bool sgvHp6Qp0074qnbRMM7S()
	{
		return NMA0kOQpGYauE0OyEn47 == null;
	}
}
