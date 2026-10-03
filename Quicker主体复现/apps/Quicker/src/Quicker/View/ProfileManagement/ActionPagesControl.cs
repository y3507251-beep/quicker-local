using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using JTIh7V5l65QV75A93Ly;
using Newtonsoft.Json;
using Quicker.Common;
using Quicker.Domain;
using Quicker.Domain.Actions.Runtime;
using Quicker.Domain.Entities;
using Quicker.Domain.Messages;
using Quicker.Domain.Profiles;
using Quicker.Domain.Services;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;
using Quicker.View.Controls;

namespace Quicker.View.ProfileManagement;

public class ActionPagesControl : UserControl, IComponentConnector, IStyleConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec qhsSjXcb7WA;

		public static Func<ActionProfile, bool> jWdSjmjblQa;

		public static Func<ActionProfile, bool> W2ESjKLu79m;

		public static Func<ActionProfile, string> qscSjxH7ZZO;

		private static _003C_003Ec Ox8LA6W6VkQh6R2gdRcS;

		static _003C_003Ec()
		{
			qhsSjXcb7WA = new _003C_003Ec();
		}

		internal bool wY1Sj11SpHq(ActionProfile x)
		{
			return x.IsDefaultProfile();
		}

		internal bool qETSjbxeFZu(ActionProfile x)
		{
			return x.IsDefaultGlobalProfile();
		}

		internal string z4uSj6mUB37(ActionProfile x)
		{
			return x.Id;
		}

		internal static bool L5Kk8rW6QkToMDSTE4cq()
		{
			return Ox8LA6W6VkQh6R2gdRcS == null;
		}

		internal static void sF9mAqW6cJh1eW0r0Ny7()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass35_0
	{
		public ActionButtonEventArgs<MouseButtonEventArgs> msGSjp6UGOU;

		internal static _003C_003Ec__DisplayClass35_0 gL232vW6WyEF5dpudXtm;

		internal void bj2SjrjSV3d(object sender, RoutedEventArgs e)
		{
			msGSjp6UGOU.Button.ContextMenu = null;
		}

		internal static bool kImqDmW6yu3OIhGFCFK1()
		{
			return gL232vW6WyEF5dpudXtm == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass39_0
	{
		public ActionEditCompletedMessage cSoSjQ8Tt60;

		private static _003C_003Ec__DisplayClass39_0 I5AtmIW6XHBGj2yMrSJB;

		internal bool MfoSjBncuVK(ActionProfile x)
		{
			return x.Id == cSoSjQ8Tt60.Profile.Id;
		}

		internal static bool PYgkScW62jDikqQGk9vY()
		{
			return I5AtmIW6XHBGj2yMrSJB == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnOpenToolboxWindow_OnClick_003Ed__44 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ActionPagesControl _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object XUMs7DW6eKrd0kDr7m7Y;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionPagesControl actionPagesControl = _003C_003E4__this;
			try
			{
        ConfiguredTaskAwaitable configuredTaskAwaitable = default;
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
				int num2;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num2 = 0;
					if (XUMs7DW6eKrd0kDr7m7Y != null)
					{
						goto IL_0138;
					}
					goto IL_0179;
				}
				configuredTaskAwaitable = default(ConfiguredTaskAwaitable);
				if (actionPagesControl.YbULuoDdahl != null)
				{
					configuredTaskAwaitable = actionPagesControl.YbULuoDdahl.SwitchExeAsync(actionPagesControl.CurrentExeInfo?.Exe, actionPagesControl.CurrentExeInfo?.IconStr).ConfigureAwait(true);
					num2 = 0;
					if (XUMs7DW6eKrd0kDr7m7Y != null)
					{
						int num3 = default(int);
						num2 = num3;
					}
					goto IL_0138;
				}
				actionPagesControl.YbULuoDdahl = new ToolboxWindow2(actionPagesControl.CurrentExeInfo?.Exe, actionPagesControl.CurrentExeInfo?.IconStr)
				{
					Left = Window.GetWindow(actionPagesControl).Left + actionPagesControl.ActualWidth,
					Top = Window.GetWindow(actionPagesControl).Top,
					Owner = Window.GetWindow(actionPagesControl)
				};
				actionPagesControl.YbULuoDdahl.Closed += actionPagesControl.rTLLupVsSgn;
				actionPagesControl.YbULuoDdahl.Show();
				actionPagesControl.YbULuoDdahl.Activate();
				goto end_IL_0010;
				IL_0138:
				switch (num2)
				{
				case 1:
					goto IL_0179;
				}
				awaiter = configuredTaskAwaitable.GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = 0;
					_003C_003E1__state = 0;
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_0183;
				IL_0179:
				num = -1;
				_003C_003E1__state = -1;
				goto IL_0183;
				IL_0183:
				awaiter.GetResult();
				actionPagesControl.YbULuoDdahl.Show();
				actionPagesControl.YbULuoDdahl.Activate();
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

		internal static bool JXnLSmW6jZ70vchu0dcD()
		{
			return XUMs7DW6eKrd0kDr7m7Y == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CProfilePanelControl_OnActionDropped_003Ed__36 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ActionPagesControl _003C_003E4__this;

		public ActionButtonEventArgs<DragEventArgs> e;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object NjIs2vW6EW0em2LKbA1u;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ActionPagesControl actionPagesControl = _003C_003E4__this;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
				if (num == 0)
				{
					int num2 = 0;
					if (!hsVUnPW6GYG8YrM3t6cB())
					{
						int num3 = default(int);
						num2 = num3;
					}
					switch (num2)
					{
					}
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_00eb;
				}
				if (!actionPagesControl.D3bLudaaNg5.IsEditing())
				{
					awaiter = actionPagesControl.D3bLudaaNg5.OnActionButtonDrop(e.Profile, e.Row, e.Col, e.OriginArgs, Window.GetWindow(actionPagesControl)).ConfigureAwait(false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_00eb;
				}
				AppHelper.ShowInformation("正在编辑动作时不可拖放。");
				goto end_IL_0010;
				IL_00eb:
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

		internal static bool hsVUnPW6GYG8YrM3t6cB()
		{
			return NjIs2vW6EW0em2LKbA1u == null;
		}
	}

	private DataService QhgLuBAMd0W;

	private ProfileManager olvLuQTrEJV;

	private AppServer U8aLujx6bBD;

	[CompilerGenerated]
	private EventHandler<ExeSettingsChangedEventArgs> m_ExeSettingsChanged;

	[CompilerGenerated]
	private EventHandler m_AllProfilesDeleted;

	[CompilerGenerated]
	private ExeInfo NelLunEGFOT;

	[CompilerGenerated]
	private ExeSettings b3MLu4uo0iS;

	private readonly SmartCollection<ActionProfile> c2DLu5RxnsY = new SmartCollection<ActionProfile>();

	private Point gUcLuDiiuAt;

	private ActionEditMgr D3bLudaaNg5;

	private ToolboxWindow2 YbULuoDdahl;

	internal IconControl TheIconControl;

	internal TextBlock LblExeName;

	internal TextBlock LblExeFile;

	internal ListBox LbProfiles;

	internal Button BtnAddPage;

	internal Button BtnAttachProfile;

	internal TextBlock LblAttachCount;

	internal CheckBox ChkReturnToFirstPage;

	internal Button BtnOpenAppSelector;

	internal Button BtnOpenToolboxWindow;

	internal Button BtnOpenShareBase;

	private bool eKwLuTX2smY;

	internal static ActionPagesControl xYOa2OFjkpgQwOpj5rj1;

	public ExeInfo CurrentExeInfo
	{
		[CompilerGenerated]
		get
		{
			return NelLunEGFOT;
		}
		[CompilerGenerated]
		set
		{
			NelLunEGFOT = value;
		}
	}

	public ExeSettings CurrentExeSettings
	{
		[CompilerGenerated]
		get
		{
			return b3MLu4uo0iS;
		}
		[CompilerGenerated]
		set
		{
			b3MLu4uo0iS = value;
		}
	}

	public event EventHandler<ExeSettingsChangedEventArgs> ExeSettingsChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler<ExeSettingsChangedEventArgs> eventHandler = this.m_ExeSettingsChanged;
			EventHandler<ExeSettingsChangedEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ExeSettingsChangedEventArgs> value2 = (EventHandler<ExeSettingsChangedEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_ExeSettingsChanged, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<ExeSettingsChangedEventArgs> eventHandler = this.m_ExeSettingsChanged;
			EventHandler<ExeSettingsChangedEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ExeSettingsChangedEventArgs> value2 = (EventHandler<ExeSettingsChangedEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_ExeSettingsChanged, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler AllProfilesDeleted
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = this.m_AllProfilesDeleted;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_AllProfilesDeleted, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = this.m_AllProfilesDeleted;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_AllProfilesDeleted, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public ActionPagesControl()
	{
		InitializeComponent();
	}

	public void Init(DataService dataService, ProfileManager profileManager, AppServer appServer, ActionEditMgr actionEditMgr)
	{
		SetValue(IconControl.DefaultIconColorProperty, FMP9ONqzXcgZ6r3WmZZ.A4qHeQImJ6().DefaultIconColor);
		QhgLuBAMd0W = dataService;
		olvLuQTrEJV = profileManager;
		U8aLujx6bBD = appServer;
		D3bLudaaNg5 = actionEditMgr;
		LbProfiles.ItemsSource = c2DLu5RxnsY;
		Style style = new Style(typeof(ListBoxItem));
		style.Setters.Add(new Setter(UIElement.AllowDropProperty, true));
		style.Setters.Add(new EventSetter(UIElement.PreviewMouseLeftButtonDownEvent, new MouseButtonEventHandler(wXLLuE28qU8)));
		style.Setters.Add(new EventSetter(UIElement.DropEvent, new DragEventHandler(B1uLuH07euu)));
		if (FoZTrcFjakhM7tN5ounR())
		{
			switch (0)
			{
			}
		}
		LbProfiles.ItemContainerStyle = style;
	}

	public void Refresh()
	{
		op1LuPHujgL();
	}

	public void SetExe(ExeInfo exeInfo, ExeSettings exeSettings)
	{
		Ensure.NotNull(exeSettings, "exeSettings");
		Ensure.NotNull(exeInfo, "exeInfo");
		CurrentExeInfo = exeInfo;
		CurrentExeSettings = exeSettings;
		AAtLueKxHPn();
		DebugHelper.LogExecuteTime(yYQLurny1dW, "列表更新耗时");
		BtnAttachProfile.IsEnabled = !string.Equals(CurrentExeSettings.Exe, "common", StringComparison.OrdinalIgnoreCase) && !string.Equals(CurrentExeSettings.Exe, "_global", StringComparison.OrdinalIgnoreCase) && !CurrentExeSettings.Exe.StartsWithAny(false, "@_", "#_");
	}

	private void op1LuPHujgL()
	{
		if (CurrentExeInfo != null)
		{
			TheIconControl.Icon = CurrentExeInfo.IconStr;
			LblExeName.Text = CurrentExeInfo.Name;
			LblExeFile.Text = CurrentExeInfo.Exe;
			c2DLu5RxnsY.Clear();
			IList<ActionProfile> allProfilesByExe = olvLuQTrEJV.GetAllProfilesByExe(CurrentExeInfo.Exe);
			c2DLu5RxnsY.Reset(allProfilesByExe);
		}
	}

	private void wXLLuE28qU8(object sender, MouseButtonEventArgs e)
	{
		gUcLuDiiuAt = e.GetPosition(null);
	}

	private void ovrLuyqkaXp(object sender, MouseEventArgs e)
	{
		Point position = e.GetPosition(null);
		Vector vector = gUcLuDiiuAt - position;
		if (e.LeftButton != MouseButtonState.Pressed || (!(Math.Abs(vector.X) > SystemParameters.MinimumHorizontalDragDistance) && !(Math.Abs(vector.Y) > SystemParameters.MinimumVerticalDragDistance)))
		{
			return;
		}
		ListBoxItem listBoxItem = hPyLu821TNG<ListBoxItem>((DependencyObject)e.OriginalSource);
		if (listBoxItem != null)
		{
			try
			{
				AppHelper.DoDragDropWrap(listBoxItem, listBoxItem.DataContext, DragDropEffects.Move);
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("无法开始拖动：" + ex.Message);
			}
		}
	}

	private t8HHRGYftdXNoldWqQc hPyLu821TNG<t8HHRGYftdXNoldWqQc>(DependencyObject dependencyObject_0) where t8HHRGYftdXNoldWqQc : DependencyObject
	{
		DependencyObject parent = VisualTreeHelper.GetParent(dependencyObject_0);
		if (parent == null)
		{
			return null;
		}
		if (parent is t8HHRGYftdXNoldWqQc result)
		{
			return result;
		}
		return hPyLu821TNG<t8HHRGYftdXNoldWqQc>(parent);
	}

	private void EvoLuauoqPy(object sender, RoutedEventArgs e)
	{
		ActionProfile actionProfile_ = (sender as FrameworkElement).Tag as ActionProfile;
		NGqLu749Duk(actionProfile_);
	}

	private void NGqLu749Duk(ActionProfile actionProfile_0)
	{
		if (actionProfile_0 == null)
		{
			return;
		}
		if (actionProfile_0.IsDefaultProfile() && QhgLuBAMd0W.mP6tXA8VyNP().Values.Count(_003C_003Ec.jWdSjmjblQa ?? (_003C_003Ec.jWdSjmjblQa = _003C_003Ec.qhsSjXcb7WA.wY1Sj11SpHq)) <= 1)
		{
			AppHelper.ShowInformation("默认通用动作页信息不可修改。");
			return;
		}
		if (actionProfile_0.IsDefaultGlobalProfile() && QhgLuBAMd0W.mP6tXA8VyNP().Values.Count(_003C_003Ec.W2ESjKLu79m ?? (_003C_003Ec.W2ESjKLu79m = _003C_003Ec.qhsSjXcb7WA.qETSjbxeFZu)) <= 1)
		{
			AppHelper.ShowInformation("默认全局动作页信息不可修改。");
			return;
		}
		EditProfileWindow editProfileWindow = new EditProfileWindow(actionProfile_0, QhgLuBAMd0W, olvLuQTrEJV)
		{
			Owner = Window.GetWindow(this)
		};
		int num = 0;
		if (!FoZTrcFjakhM7tN5ounR())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (editProfileWindow.ShowDialog() == true)
		{
			actionProfile_0.Name = editProfileWindow.ProfileName;
			actionProfile_0.Settings.ValidForMachines = editProfileWindow.ValidForMachines;
			actionProfile_0.ListOrder = 10;
			actionProfile_0.AliasOfProfile = editProfileWindow.AliasOfProfile;
			try
			{
				U8aLujx6bBD.SaveProfile(actionProfile_0, true);
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("保存动作页信息异常！" + ex.Message);
			}
			LbProfiles.Items.Refresh();
		}
	}

	private void iX5LuRV6ACI(object sender, RoutedEventArgs e)
	{
		if (!((sender as MenuItem).Tag is ActionProfile profile))
		{
			AppHelper.ShowWarning("动作页对象为空！");
			return;
		}
		ActionEditMgr.CreateSwitchProfileAction(profile, true);
		AppHelper.ShowInformation("已创建动作并写入剪贴板，请粘贴到合适位置。");
	}

	private void fRTLuqZ3dAR(object sender, RoutedEventArgs e)
	{
		if ((sender as MenuItem).Tag is ActionProfile actionProfile)
		{
			U8aLujx6bBD.RequestSwitchProfile(actionProfile.Id, false);
		}
		else
		{
			AppHelper.ShowWarning("动作页对象为空！");
		}
	}

	private void tsNLucToU0Q(object sender, RoutedEventArgs e)
	{
		ActionProfile actionProfile_ = (sender as MenuItem).Tag as ActionProfile;
		GjWLuVG4xWc(actionProfile_);
	}

	private void GjWLuVG4xWc(ActionProfile actionProfile_0)
	{
		if (!LH2LuZBXdkV(actionProfile_0))
		{
			MessageBoxHelper.Show(Window.GetWindow(this), "不能删除此动作页！", "Quicker", MessageBoxButton.OK, MessageBoxImage.Exclamation);
		}
		else
		{
			if (MessageBoxHelper.Show(Window.GetWindow(this), "您确认要删除动作页 " + actionProfile_0.Name + " 么？" + (actionProfile_0.ActionItems.HasData() ? $"页中还有 {actionProfile_0.ActionItems.Count} 个动作！" : ""), "Quicker", MessageBoxButton.OKCancel, MessageBoxImage.Exclamation) != MessageBoxResult.OK)
			{
				return;
			}
			try
			{
				U8aLujx6bBD.RemoveProfile(actionProfile_0);
				if (c2DLu5RxnsY.Contains(actionProfile_0))
				{
					c2DLu5RxnsY.Remove(actionProfile_0);
				}
				uebLub64g0u();
				if (c2DLu5RxnsY.Count == 0 && CurrentExeInfo.Exe.EndsWith(".exe", StringComparison.OrdinalIgnoreCase))
				{
					EventHandler eventHandler = this.m_AllProfilesDeleted;
					if (eventHandler != null)
					{
						eventHandler(this, EventArgs.Empty);
						if (FoZTrcFjakhM7tN5ounR())
						{
							switch (0)
							{
							}
						}
					}
				}
				if (actionProfile_0.ExeFile.StartsWith("@_"))
				{
					AppState.vjAt7Seco0Y().PushActions(null);
				}
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("删除动作页失败！" + ex.Message);
			}
		}
	}

	private bool LH2LuZBXdkV(ActionProfile actionProfile_0)
	{
		if (actionProfile_0 != null && !actionProfile_0.IsDefaultProfile() && !actionProfile_0.IsDefaultGlobalProfile())
		{
			return !D3bLudaaNg5.IsEditingProfile(actionProfile_0);
		}
		return false;
	}

	private void cqjLu9BSTC9(ActionButtonEventArgs<MouseButtonEventArgs> actionButtonEventArgs_0)
	{
		_003C_003Ec__DisplayClass35_0 _003C_003Ec__DisplayClass35_ = new _003C_003Ec__DisplayClass35_0();
		_003C_003Ec__DisplayClass35_.msGSjp6UGOU = actionButtonEventArgs_0;
		ActionItem originAction = _003C_003Ec__DisplayClass35_.msGSjp6UGOU.OriginAction;
		if (originAction == null || originAction.ActionType != ActionType.GoParent)
		{
			ContextMenu contextMenu = new ContextMenu();
			D3bLudaaNg5.BuildMenuForActionButton(contextMenu, originAction, _003C_003Ec__DisplayClass35_.msGSjp6UGOU.Profile, _003C_003Ec__DisplayClass35_.msGSjp6UGOU.Row, _003C_003Ec__DisplayClass35_.msGSjp6UGOU.Col, Window.GetWindow(this), ActionTrigger.Panel);
			if (contextMenu.Items.Count > 0)
			{
				_003C_003Ec__DisplayClass35_.msGSjp6UGOU.Button.ContextMenu = contextMenu;
				contextMenu.IsOpen = true;
				contextMenu.Closed += _003C_003Ec__DisplayClass35_.bj2SjrjSV3d;
				AppState.RegisterContextMenu(contextMenu);
			}
		}
	}

	[AsyncStateMachine(typeof(_003CProfilePanelControl_OnActionDropped_003Ed__36))]
	private void ProfilePanelControl_OnActionDropped(object sender, ActionButtonEventArgs<DragEventArgs> e)
	{
		_003CProfilePanelControl_OnActionDropped_003Ed__36 stateMachine = default(_003CProfilePanelControl_OnActionDropped_003Ed__36);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.e = e;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void ProfilePanelControl_OnActionDoubleClicked(object sender, ActionButtonEventArgs<MouseButtonEventArgs> e)
	{
		D3bLudaaNg5.EditAction(e.Profile, e.Row, e.Col, e.OriginAction, null);
	}

	private void ProfilePanelControl_OnActionButtonClicked(object sender, ActionButtonEventArgs<MouseButtonEventArgs> e)
	{
		if (!e.Profile.AliasOfProfile.IsNullOrEmpty())
		{
			AppHelper.ShowWarning("链接动作页作为其它动作页的快捷方式，不支持添加动作。");
		}
		else if (e.OriginArgs.ChangedButton == MouseButton.Right)
		{
			cqjLu9BSTC9(e);
		}
		else if (e.OriginArgs.ChangedButton == MouseButton.Left)
		{
			if (e.OriginAction == null)
			{
				cqjLu9BSTC9(e);
			}
			else if (e.OriginArgs.ClickCount >= 2)
			{
				e.OriginArgs.Handled = true;
				D3bLudaaNg5.EditAction(e.Profile, e.Row, e.Col, e.OriginAction, null);
			}
		}
	}

	public void OnActionEditCompletedMessage(ActionEditCompletedMessage actionEditCompletedMessage)
	{
		_003C_003Ec__DisplayClass39_0 _003C_003Ec__DisplayClass39_ = new _003C_003Ec__DisplayClass39_0();
		_003C_003Ec__DisplayClass39_.cSoSjQ8Tt60 = actionEditCompletedMessage;
		if (c2DLu5RxnsY.Any(_003C_003Ec__DisplayClass39_.MfoSjBncuVK))
		{
			op1LuPHujgL();
		}
	}

	private void uV2Luh0VWPJ(object sender, RoutedEventArgs e)
	{
		AttachProfileSelectWindow attachProfileSelectWindow = new AttachProfileSelectWindow(olvLuQTrEJV, CurrentExeSettings.AttachProfiles)
		{
			Owner = Window.GetWindow(this)
		};
		if (attachProfileSelectWindow.ShowDialog() == true)
		{
			CurrentExeSettings.AttachProfiles = attachProfileSelectWindow.SelectedProfiles;
			AAtLueKxHPn();
			this.m_ExeSettingsChanged?.Invoke(this, new ExeSettingsChangedEventArgs
			{
				ExeSettings = CurrentExeSettings
			});
		}
	}

	private void AAtLueKxHPn()
	{
		int num = 0;
		if (CurrentExeSettings?.AttachProfiles != null)
		{
			num = CurrentExeSettings.AttachProfiles.Count;
		}
		LblAttachCount.Text = num.ToString(CultureInfo.InvariantCulture);
		ChkReturnToFirstPage.IsChecked = CurrentExeSettings?.ReturnToFirstPage ?? false;
	}

	private void tULLuY48gTe(object sender, RoutedEventArgs e)
	{
		CurrentExeSettings.ReturnToFirstPage = ChkReturnToFirstPage.IsChecked == true;
		this.m_ExeSettingsChanged?.Invoke(this, new ExeSettingsChangedEventArgs
		{
			ExeSettings = CurrentExeSettings
		});
	}

	private void G8aLuIRkmrD(object sender, RoutedEventArgs e)
	{
		ActionEditMgr.ShowAppSelectorWindow(Window.GetWindow(this));
	}

	[AsyncStateMachine(typeof(_003CBtnOpenToolboxWindow_OnClick_003Ed__44))]
	private void kbyLuWIRNi5(object sender, RoutedEventArgs e)
	{
		_003CBtnOpenToolboxWindow_OnClick_003Ed__44 stateMachine = default(_003CBtnOpenToolboxWindow_OnClick_003Ed__44);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void JQELukGPXxo(object sender, RoutedEventArgs e)
	{
		AppServer.OpenShareBase(CurrentExeSettings?.Exe);
	}

	private void UYuLuG206S4(object sender, RoutedEventArgs e)
	{
		if (CurrentExeInfo == null)
		{
			AppHelper.ShowWarning("请在左侧选择应用！");
		}
		else
		{
			AmkLusfrhok(CurrentExeInfo);
		}
	}

	private void AmkLusfrhok(ExeInfo exeInfo_1)
	{
		if (exeInfo_1 == null)
		{
			return;
		}
		if (string.IsNullOrEmpty(exeInfo_1.Path))
		{
			exeInfo_1.Path = exeInfo_1.Exe;
		}
		NewProfileWindow newProfileWindow = new NewProfileWindow(QhgLuBAMd0W, olvLuQTrEJV, exeInfo_1)
		{
			Owner = Window.GetWindow(this)
		};
		if (newProfileWindow.ShowDialog() != true)
		{
			return;
		}
		try
		{
			CreateProfileDto data = newProfileWindow.GetData();
			data.ListOrder = (c2DLu5RxnsY.Count + 1) * 100;
			ActionProfile item = U8aLujx6bBD.AddProfile(data);
			if (LbProfiles.SelectedIndex >= 0)
			{
				c2DLu5RxnsY.Insert(LbProfiles.SelectedIndex + 1, item);
			}
			else
			{
				c2DLu5RxnsY.Add(item);
			}
			uebLub64g0u();
		}
		catch (Exception ex)
		{
			MessageBoxHelper.Show(Window.GetWindow(this), "无法创建动作页。" + ex.Message, "Quicker", MessageBoxButton.OK, MessageBoxImage.Exclamation);
		}
	}

	private void B1uLuH07euu(object sender, DragEventArgs e)
	{
		if (sender is ListBoxItem && e.Data.GetData(typeof(ActionProfile)) is ActionProfile actionProfile)
		{
			ActionProfile item = ((ListBoxItem)sender).DataContext as ActionProfile;
			int int_ = LbProfiles.Items.IndexOf(actionProfile);
			int int_2 = LbProfiles.Items.IndexOf(item);
			REdLu1I8WsP(actionProfile, int_, int_2);
			uebLub64g0u();
		}
	}

	private void REdLu1I8WsP(ActionProfile actionProfile_0, int int_0, int int_1)
	{
		if (int_0 < int_1)
		{
			c2DLu5RxnsY.Insert(int_1 + 1, actionProfile_0);
			c2DLu5RxnsY.RemoveAt(int_0);
			return;
		}
		int num = int_0 + 1;
		if (c2DLu5RxnsY.Count + 1 > num)
		{
			c2DLu5RxnsY.Insert(int_1, actionProfile_0);
			c2DLu5RxnsY.RemoveAt(num);
		}
	}

	private void uebLub64g0u()
	{
		if (CurrentExeSettings == null)
		{
			AppHelper.ShowWarning("CurrentExeSettings 为空");
			return;
		}
		CurrentExeSettings.ProfileList = c2DLu5RxnsY.Select(_003C_003Ec.qscSjxH7ZZO ?? (_003C_003Ec.qscSjxH7ZZO = _003C_003Ec.qhsSjXcb7WA.z4uSj6mUB37)).ToList();
		this.m_ExeSettingsChanged?.Invoke(this, new ExeSettingsChangedEventArgs
		{
			ExeSettings = CurrentExeSettings
		});
	}

	private void NX3Lu64gIC7(object sender, RoutedEventArgs e)
	{
		if (!((sender as MenuItem).Tag is ActionProfile actionProfile))
		{
			AppHelper.ShowWarning("对象为空。");
			return;
		}
		int num = (JsonConvert.SerializeObject(actionProfile).Length + 500) / 1000;
		DateTime? lastUpdateTimeUtc = actionProfile.LastUpdateTimeUtc;
		string text = "";
		int num2 = 0;
		if (xYOa2OFjkpgQwOpj5rj1 != null)
		{
			int num3 = default(int);
			num2 = num3;
		}
		switch (num2)
		{
		}
		if (lastUpdateTimeUtc.HasValue)
		{
			text = $"{DateTime.SpecifyKind(lastUpdateTimeUtc.Value, DateTimeKind.Utc).ToLocalTime()}";
		}
		string messageBoxText = "ID： " + actionProfile.Id + "\n最后修改： " + text + "\n" + $"大小： {num} KB";
		MessageBoxHelper.Show(Window.GetWindow(this), messageBoxText, "动作页信息");
	}

	private void BJvLuX4eXkw(object sender, RoutedEventArgs e)
	{
		if ((sender as MenuItem).Tag is ActionProfile actionProfile)
		{
			ClipboardHelper.SetText(actionProfile?.Id);
			AppHelper.ShowInformation("动作页ID已复制到剪贴板：" + actionProfile?.Id);
		}
	}

	private void bGLLumA6hvp(object sender, MouseWheelEventArgs e)
	{
		ScrollViewer descendantByType = LbProfiles.GetDescendantByType<ScrollViewer>();
		if (descendantByType == null)
		{
			return;
		}
		if (e.Delta < 0)
		{
			descendantByType.LineRight();
			descendantByType.LineRight();
			descendantByType.LineRight();
		}
		else
		{
			descendantByType.LineLeft();
			descendantByType.LineLeft();
			descendantByType.LineLeft();
			if (!FoZTrcFjakhM7tN5ounR())
			{
				switch (0)
				{
				}
			}
		}
		e.Handled = true;
	}

	private void r1BLuKPLSxJ(object sender, MouseButtonEventArgs e)
	{
		if (e.ClickCount == 2)
		{
			SetValue(ActionButton.ButtonColorProperty, Brushes.Gray);
		}
	}

	private void FE5LuxZTFm6(object sender, MouseButtonEventArgs e)
	{
		if (e.ClickCount == 2)
		{
			EvoLuauoqPy(sender, e);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!eKwLuTX2smY)
		{
			eKwLuTX2smY = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/profilemanagement/exesettingcontrols/actionpagescontrol.xaml", UriKind.Relative);
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
		int num;
		int num2 = default(int);
		switch (connectionId)
		{
		case 1:
			TheIconControl = (IconControl)target;
			break;
		case 2:
			LblExeName = (TextBlock)target;
			break;
		case 3:
			LblExeFile = (TextBlock)target;
			break;
		case 4:
			((TextBlock)target).PreviewMouseDown += r1BLuKPLSxJ;
			num = 1;
			if (xYOa2OFjkpgQwOpj5rj1 != null)
			{
				goto IL_0182;
			}
			goto IL_0186;
		case 5:
			LbProfiles = (ListBox)target;
			LbProfiles.PreviewMouseWheel += bGLLumA6hvp;
			break;
		default:
			eKwLuTX2smY = true;
			break;
		case 14:
			BtnAddPage = (Button)target;
			BtnAddPage.Click += UYuLuG206S4;
			break;
		case 15:
			BtnAttachProfile = (Button)target;
			BtnAttachProfile.Click += uV2Luh0VWPJ;
			break;
		case 16:
			LblAttachCount = (TextBlock)target;
			break;
		case 17:
			ChkReturnToFirstPage = (CheckBox)target;
			ChkReturnToFirstPage.Click += tULLuY48gTe;
			break;
		case 18:
			BtnOpenAppSelector = (Button)target;
			BtnOpenAppSelector.Click += G8aLuIRkmrD;
			num = 0;
			if (xYOa2OFjkpgQwOpj5rj1 != null)
			{
				goto IL_0182;
			}
			goto IL_0186;
		case 19:
			BtnOpenToolboxWindow = (Button)target;
			BtnOpenToolboxWindow.Click += kbyLuWIRNi5;
			break;
		case 20:
			{
				BtnOpenShareBase = (Button)target;
				BtnOpenShareBase.Click += JQELukGPXxo;
				break;
			}
			IL_0182:
			num = num2;
			goto IL_0186;
			IL_0186:
			switch (num)
			{
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
		switch (connectionId)
		{
		case 6:
			((Grid)target).PreviewMouseLeftButtonDown += FE5LuxZTFm6;
			break;
		case 7:
			((StackPanel)target).PreviewMouseMove += ovrLuyqkaXp;
			if (!FoZTrcFjakhM7tN5ounR())
			{
				switch (0)
				{
				}
			}
			break;
		case 8:
			((MenuItem)target).Click += NX3Lu64gIC7;
			break;
		case 9:
			((MenuItem)target).Click += BJvLuX4eXkw;
			break;
		case 10:
			((MenuItem)target).Click += EvoLuauoqPy;
			break;
		case 11:
			((MenuItem)target).Click += iX5LuRV6ACI;
			break;
		case 12:
			((MenuItem)target).Click += fRTLuqZ3dAR;
			break;
		case 13:
			((MenuItem)target).Click += tsNLucToU0Q;
			break;
		}
	}

	[CompilerGenerated]
	private void yYQLurny1dW()
	{
		op1LuPHujgL();
	}

	[CompilerGenerated]
	private void rTLLupVsSgn(object sender, EventArgs e)
	{
		YbULuoDdahl = null;
	}

	internal static bool FoZTrcFjakhM7tN5ounR()
	{
		return xYOa2OFjkpgQwOpj5rj1 == null;
	}

	internal static void XK6R6vFjNnZYSs6dpDf8()
	{
	}
}
