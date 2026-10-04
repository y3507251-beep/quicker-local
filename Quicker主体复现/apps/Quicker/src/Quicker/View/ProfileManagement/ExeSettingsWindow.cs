using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Markup;
using CommunityToolkit.Mvvm.Messaging;
using IgQBbvXMVdsN7GVNUxX;
using JTIh7V5l65QV75A93Ly;
using log4net;
using Quicker.Common.Vm;
using Quicker.Domain;
using Quicker.Domain.Entities;
using Quicker.Domain.Messages;
using Quicker.Domain.Profiles;
using Quicker.Domain.Services;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Theme;
using Quicker.Utilities.UI;
using Quicker.View.ExeSettingControls;
using Quicker.View.ProfileManagement.ExeSettingControls;
using t8SGKhhgLWTgeqjGcrq;

namespace Quicker.View.ProfileManagement;

public class ExeSettingsWindow : Window, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec fHkSn0Kjrgc;

		public static Func<ActionEditCompletedMessage, bool> RouSnCvQC0e;

		private static _003C_003Ec SuhOsFW6qQpNUJHI9v4r;

		static _003C_003Ec()
		{
			fHkSn0Kjrgc = new _003C_003Ec();
		}

		internal bool W3WSnJQMKkg(ActionEditCompletedMessage x)
		{
			return true;
		}

		internal static bool zcg9BrW6ildke4VQUHJA()
		{
			return SuhOsFW6qQpNUJHI9v4r == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass15_0
	{
		public ExeSettingsWindow g9nSnEH1gSA;

		public ActionEditCompletedMessage w3rSnyiKIcI;

		private static _003C_003Ec__DisplayClass15_0 FuD0BPW6ZFd5uZxSiwTD;

		internal void MaWSnPMWXWo()
		{
			g9nSnEH1gSA.ActionPages.OnActionEditCompletedMessage(w3rSnyiKIcI);
		}

		internal static bool etvFMGW652LdbE4Ic9hk()
		{
			return FuD0BPW6ZFd5uZxSiwTD == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass20_0
	{
		public ExeSettingsWindow IZ1SnaUYJC0;

		public ExeChangedEventArgs ufCSn7KZhd0;

		internal static _003C_003Ec__DisplayClass20_0 zFFstEW68XUXGegh04be;

		internal void m98Sn8XRFKE()
		{
			IZ1SnaUYJC0.BGHLNIpO5fw = IZ1SnaUYJC0.RGrLNZHRFiA.yQWt6ownR4Z(ufCSn7KZhd0.ExeInfo.Exe, true);
			IZ1SnaUYJC0.KcaLNk3irXk = IZ1SnaUYJC0.RGrLNZHRFiA.yQWt6ownR4Z("_global", true);
			if (string.Equals(ufCSn7KZhd0.ExeInfo.Exe, "common", StringComparison.OrdinalIgnoreCase))
			{
				IZ1SnaUYJC0.z29LNGdDw5X = IZ1SnaUYJC0.KcaLNk3irXk;
			}
			else
			{
				IZ1SnaUYJC0.z29LNGdDw5X = IZ1SnaUYJC0.BGHLNIpO5fw;
			}
		}

		internal static bool FDRXaLW6RIYWiIRgraOd()
		{
			return zFFstEW68XUXGegh04be == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CExeList_OnExeChanged_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ExeSettingsWindow _003C_003E4__this;

		public ExeChangedEventArgs e;

		private _003C_003Ec__DisplayClass20_0 _003C_003E8__1;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object Gi7MBVW6PPmpQfnbSK5Z;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ExeSettingsWindow exeSettingsWindow = _003C_003E4__this;
			try
			{
				int num2;
				if (num != 0)
				{
					num2 = 0;
					if (!OkDOd8W6MXyUSSibq1wC())
					{
						goto IL_0113;
					}
					goto IL_0117;
				}
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter = _003C_003Eu__1;
				_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
				num = -1;
				_003C_003E1__state = -1;
				goto IL_0185;
				IL_0185:
				awaiter.GetResult();
				exeSettingsWindow.BGHLNIpO5fw.EnsureDataValid();
				exeSettingsWindow.z29LNGdDw5X.EnsureDataValid();
				num2 = 2;
				if (Gi7MBVW6PPmpQfnbSK5Z != null)
				{
					goto IL_0113;
				}
				goto IL_0117;
				IL_0117:
				while (true)
				{
					TabItem obj;
					switch (num2)
					{
					case 2:
						exeSettingsWindow.KcaLNk3irXk.EnsureDataValid();
						exeSettingsWindow.ActionPages.SetExe(_003C_003E8__1.ufCSn7KZhd0.ExeInfo, exeSettingsWindow.BGHLNIpO5fw);
						exeSettingsWindow.SettingsTab.Visibility = Visibility.Visible;
						exeSettingsWindow.CircleMenuSettings.SetExe(exeSettingsWindow.z29LNGdDw5X, exeSettingsWindow.KcaLNk3irXk);
						exeSettingsWindow.GesturesSettingsControl.SetExe(exeSettingsWindow.z29LNGdDw5X, exeSettingsWindow.KcaLNk3irXk);
						if (!_003C_003E8__1.ufCSn7KZhd0.ExeInfo.Exe.EndsWith(".exe", StringComparison.OrdinalIgnoreCase) && !_003C_003E8__1.ufCSn7KZhd0.ExeInfo.Exe.Equals("desktop", StringComparison.OrdinalIgnoreCase))
						{
							goto IL_0106;
						}
						goto IL_0200;
					default:
						_003C_003E8__1 = new _003C_003Ec__DisplayClass20_0();
						_003C_003E8__1.IZ1SnaUYJC0 = _003C_003E4__this;
						_003C_003E8__1.ufCSn7KZhd0 = e;
						awaiter = Task.Run((Action)_003C_003E8__1.m98Sn8XRFKE).ConfigureAwait(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						break;
					case 1:
						{
							if (_003C_003E8__1.ufCSn7KZhd0.ExeInfo.Exe.Equals("taskbar", StringComparison.OrdinalIgnoreCase))
							{
								goto IL_0200;
							}
							goto IL_0237;
						}
						IL_0244:
						obj = exeSettingsWindow.SettingsTab.SelectedItem as TabItem;
						if (obj != null && obj.Visibility == Visibility.Collapsed)
						{
							exeSettingsWindow.SettingsTab.SelectedIndex = 0;
						}
						goto end_IL_0117;
						IL_0237:
						exeSettingsWindow.TabLeftButtonPlus.Visibility = Visibility.Collapsed;
						goto IL_0244;
						IL_0200:
						exeSettingsWindow.TabLeftButtonPlus.Visibility = Visibility.Visible;
						exeSettingsWindow.LeftButtonPlusSettingsControl.SetExe(exeSettingsWindow.z29LNGdDw5X, exeSettingsWindow.KcaLNk3irXk);
						goto IL_0244;
					}
					goto IL_0185;
					IL_0106:
					num2 = 1;
					if (Gi7MBVW6PPmpQfnbSK5Z == null)
					{
						continue;
					}
					goto IL_0113;
					continue;
					end_IL_0117:
					break;
				}
				goto end_IL_0010;
				IL_0113:
				int num3 = default(int);
				num2 = num3;
				goto IL_0117;
				end_IL_0010:;
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003E8__1 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003E8__1 = null;
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

		internal static bool OkDOd8W6MXyUSSibq1wC()
		{
			return Gi7MBVW6PPmpQfnbSK5Z == null;
		}
	}


	private readonly DataService RGrLNZHRFiA;

	private readonly ITinyMessengerHub mm3LN9aytOH;

	private readonly AppServer BAJLNhb010C;

	private readonly ProfileManager o0GLNeFdKSd;

	private readonly ActionEditMgr RRNLNYi5DJG;

	private ExeSettings BGHLNIpO5fw;

	private TinyMessageSubscriptionToken DomLNWTfmSu;


	private ExeSettings KcaLNk3irXk;

	private ExeSettings z29LNGdDw5X;

	private static readonly ILog XfsLNs3dEIb;


	internal ExeListControl ExeList;

	internal ActionPagesControl ActionPages;

	internal TabControl SettingsTab;

	internal TabItem TabCircleMenu;

	internal ExeCircleMenuSettingsControl CircleMenuSettings;

	internal TabItem TabGestures;

	internal ExeGesturesSettingsControl GesturesSettingsControl;

	internal TabItem TabLeftButtonPlus;

	internal ExeLeftButtonPlusSettingsControl LeftButtonPlusSettingsControl;

	private bool loJLN1PKPu6;

	private static ExeSettingsWindow KPaiZBFjhF63FvZw1RpA;


	public ExeSettingsWindow(DataService dataService, ITinyMessengerHub hub, AppServer appServer, ProfileManager profileManager, ActionEditMgr actionEditMgr, string exe)
	{
		RGrLNZHRFiA = dataService;
		mm3LN9aytOH = hub;
		BAJLNhb010C = appServer;
		o0GLNeFdKSd = profileManager;
		RRNLNYi5DJG = actionEditMgr;
		InitializeComponent();
		yj7LNafUBof();
		ExeList.Init(RGrLNZHRFiA, exe, BAJLNhb010C, o0GLNeFdKSd);
		ActionPages.Init(RGrLNZHRFiA, o0GLNeFdKSd, BAJLNhb010C, RRNLNYi5DJG);
		CircleMenuSettings.Init(RGrLNZHRFiA);
		GesturesSettingsControl.Init(RGrLNZHRFiA);
		base.Closed += LFrLNRwi5k8;
		base.Loaded += IpJLNcg7bAn;
		DomLNWTfmSu = hub.Subscribe(PhaLN72eeVs, _003C_003Ec.RouSnCvQC0e ?? (_003C_003Ec.RouSnCvQC0e = _003C_003Ec.fHkSn0Kjrgc.W3WSnJQMKkg));
		WeakReferenceMessenger.Default.Register<ThemeChangedMessage>(this, VxwLNV0Go96);
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (!AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return new FakeWindowsPeer(this);
		}
		return base.OnCreateAutomationPeer();
	}

	public void SwitchExe(string exe)
	{
		if (base.OwnedWindows.Count == 0)
		{
			ExeList.TrySelectExe(exe);
		}
	}

	private void yj7LNafUBof()
	{
		UIHelper.UpdateUiSkinCommon(this, FMP9ONqzXcgZ6r3WmZZ.A4qHeQImJ6(), false);
	}

	private void PhaLN72eeVs(ActionEditCompletedMessage actionEditCompletedMessage_0)
	{
		_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_0();
		_003C_003Ec__DisplayClass15_.g9nSnEH1gSA = this;
		_003C_003Ec__DisplayClass15_.w3rSnyiKIcI = actionEditCompletedMessage_0;
		AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass15_.MaWSnPMWXWo);
	}

	private void LFrLNRwi5k8(object sender, EventArgs e)
	{
		if (DomLNWTfmSu != null)
		{
			mm3LN9aytOH.Unsubscribe(DomLNWTfmSu);
			DomLNWTfmSu = null;
		}
		this.ClearAllBindings();
	}

	[AsyncStateMachine(typeof(_003CExeList_OnExeChanged_003Ed__20))]
	private void ExeList_OnExeChanged(object sender, ExeChangedEventArgs e)
	{
		_003CExeList_OnExeChanged_003Ed__20 stateMachine = default(_003CExeList_OnExeChanged_003Ed__20);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.e = e;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void ActionPages_OnAllProfilesDeleted(object sender, EventArgs e)
	{
	}

	private void ActionPages_OnExeSettingsChanged(object sender, ExeSettingsChangedEventArgs e)
	{
		BAJLNhb010C.SaveExeSettings(BGHLNIpO5fw);
	}

	private void CircleMenuSettings_OnDataChanged(object sender, EventArgs e)
	{
		BAJLNhb010C.SaveExeSettings(z29LNGdDw5X);
		mm3LN9aytOH.NotifyCommonDataUpdated(this, "user_mouseActions");
	}

	private void GesturesSettingsControl_OnDataChanged(object sender, EventArgs e)
	{
		BAJLNhb010C.SaveExeSettings(z29LNGdDw5X);
		mm3LN9aytOH.NotifyCommonDataUpdated(this, "user_mouseActions");
	}


	private void LeftButtonPlus_OnDataChanged(object sender, EventArgs e)
	{
		BAJLNhb010C.SaveExeSettings(z29LNGdDw5X);
		mm3LN9aytOH.NotifyCommonDataUpdated(this, "user_mouseActions");
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!loJLN1PKPu6)
		{
			loJLN1PKPu6 = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/profilemanagement/exesettingswindow.xaml", UriKind.Relative);
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
		switch (connectionId)
		{
		default:
			loJLN1PKPu6 = true;
			break;
		case 1:
			ExeList = (ExeListControl)target;
			break;
		case 2:
			ActionPages = (ActionPagesControl)target;
			break;
		case 4:
			SettingsTab = (TabControl)target;
			break;
		case 5:
			TabCircleMenu = (TabItem)target;
			break;
		case 6:
			CircleMenuSettings = (ExeCircleMenuSettingsControl)target;
			break;
		case 7:
			TabGestures = (TabItem)target;
			break;
		case 8:
			GesturesSettingsControl = (ExeGesturesSettingsControl)target;
			break;
		case 9:
			TabLeftButtonPlus = (TabItem)target;
			break;
		case 10:
			LeftButtonPlusSettingsControl = (ExeLeftButtonPlusSettingsControl)target;
			break;
		}
	}

	static ExeSettingsWindow()
	{
		XfsLNs3dEIb = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	[CompilerGenerated]
	private void IpJLNcg7bAn(object sender, RoutedEventArgs e)
	{
		if (base.Top < SystemParameters.WorkArea.Top || base.Height > SystemParameters.WorkArea.Height || base.Width > SystemParameters.WorkArea.Width)
		{
			ClearValue(FrameworkElement.MaxHeightProperty);
			base.WindowState = WindowState.Maximized;
		}
	}

	[CompilerGenerated]
	private void VxwLNV0Go96(object object_0, ThemeChangedMessage themeChangedMessage_0)
	{
		yj7LNafUBof();
	}

	internal static bool UihXG0FjHfXUouwknZeI()
	{
		return KPaiZBFjhF63FvZw1RpA == null;
	}
}
