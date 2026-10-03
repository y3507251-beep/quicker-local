using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using IOn6RhAJdTUbfGy6gwn;
using log4net;
using Quicker.Common;
using Quicker.Common.Vm;
using Quicker.Domain;
using Quicker.Domain.Entities;
using Quicker.Domain.Exe;
using Quicker.Domain.Profiles;
using Quicker.Domain.Services;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;
using Quicker.Utilities.Win32;
using Quicker.View.Controls;

namespace Quicker.View.ProfileManagement;

public class ExeListControl : UserControl, IComponentConnector, IStyleConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec Ou8SjO8XVKU;

		public static Func<ExeSettings, string> syHSjFuAxXW;

		public static Func<ExeInfo, bool> LNISjUy6hgw;

		public static Func<ExeInfo, string> MenSjlq2FST;

		public static Func<ExeInfo, bool> mQ5Sji6WKN0;

		public static Func<ExeInfo, string> bF4Sj3iu3vM;

		public static Func<ExeInfo, bool> mx1Sjfy3hgd;

		public static Func<ExeInfo, string> g63SjzfWrKW;

		public static Func<ExeInfo, string> qCcSnwa2QfH;

		public static Func<ActionItem, bool> qArSntcPSeP;

		public static Func<ExeInfo, bool> hBtSngeFYJA;

		private static _003C_003Ec uy64fvW61BupkSuYsRHb;

		static _003C_003Ec()
		{
			Ou8SjO8XVKU = new _003C_003Ec();
		}

		internal string ATXSjjY9nBj(ExeSettings x)
		{
			return x.Exe.ToLower();
		}

		internal bool cPTSjnkbm2Q(ExeInfo x)
		{
			return x.Exe.StartsWith("#_");
		}

		internal string sjPSj4lOkaW(ExeInfo x)
		{
			return x.Name;
		}

		internal bool TuoSj5H4Ji4(ExeInfo x)
		{
			return x.Exe.StartsWith("@_");
		}

		internal string CiGSjDKwBL1(ExeInfo x)
		{
			return x.Name;
		}

		internal bool L4GSjdWZfAq(ExeInfo x)
		{
			return !x.Exe.StartsWithAny(false, "#_", "@_");
		}

		internal string aZjSjoAZKtZ(ExeInfo x)
		{
			return x.Name;
		}

		internal string k3bSjTb1Wkr(ExeInfo x)
		{
			return x.Exe;
		}

		internal bool JgeSjM6NlLm(ActionItem x)
		{
			return x.Row == 3;
		}

		internal bool cbPSjA9WpAv(ExeInfo x)
		{
			return x.AliasExeList.IndexOf(AppState.ExeBeforeShowConfigWindow, StringComparison.OrdinalIgnoreCase) >= 0;
		}

		internal static bool oETQAiW6KHCK757HR4J1()
		{
			return uy64fvW61BupkSuYsRHb == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass18_0
	{
		public string WhISnv0iLM9;

		internal static _003C_003Ec__DisplayClass18_0 oAY6AVW6vA1vdDInjQvl;

		internal bool qpuSnLEGNGJ(ExeInfo x)
		{
			return string.Equals(x.Exe, WhISnv0iLM9, StringComparison.OrdinalIgnoreCase);
		}

		internal static bool oslt3MW6dk2N7JRFb0Zv()
		{
			return oAY6AVW6vA1vdDInjQvl == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass21_0
	{
		public string dbcSn2aeRjg;

		private static _003C_003Ec__DisplayClass21_0 YQelDSW6JlQR0Wgkw9SB;

		internal bool QgWSnSu87CM(ExeInfo x)
		{
			return x.Exe == dbcSn2aeRjg;
		}

		internal static bool pfsZWEW6ks9ICRtsu5Jd()
		{
			return YQelDSW6JlQR0Wgkw9SB == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass35_0
	{
		public string DXfSnN7nour;

		private static _003C_003Ec__DisplayClass35_0 jIE6adW6rPbOuKQ2Sujw;

		internal bool fFkSnucK7gt(ExeInfo x)
		{
			return string.Equals(x.Exe, DXfSnN7nour, StringComparison.OrdinalIgnoreCase);
		}

		internal static bool VdC4TVW6NCWynv5Ergvr()
		{
			return jIE6adW6rPbOuKQ2Sujw == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnNewExeSettings_OnClick_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ExeListControl _003C_003E4__this;

		private ExeSettings _003CexeSettings_003E5__2;

		private ConfiguredTaskAwaitable<ExeFileVersionDto>.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object Jrv1h7W6LwJlwaaYaFPi;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ExeListControl exeListControl = _003C_003E4__this;
			try
			{
        CreateProfileDto dto = default;
				int num2;
				if (num != 0)
				{
					num2 = 0;
					if (Jrv1h7W6LwJlwaaYaFPi != null)
					{
						goto IL_00f1;
					}
					goto IL_0103;
				}
				goto IL_0029;
				IL_0029:
				NewExeSettingsWindow newExeSettingsWindow = default(NewExeSettingsWindow);
				try
				{
					ConfiguredTaskAwaitable<ExeFileVersionDto>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = exeListControl.SMaLNuSTcLD.SaveFileVersionInfo(newExeSettingsWindow.ExePathName).ConfigureAwait(true).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							if (H96EifW6uHZGwcI46n44())
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
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ExeFileVersionDto>.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
					}
					ExeFileVersionDto result = awaiter.GetResult();
					if (result != null)
					{
						_003CexeSettings_003E5__2.IconUrl = result.FileIconUrl;
					}
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("无法保存场景设置。" + ex.Message);
					goto end_IL_000e;
				}
				goto IL_0206;
				IL_0103:
				if (exeListControl.zXJLNLQ6gqe.Hb9tmk3OsJ7() || exeListControl.zXJLNLQ6gqe.LDPtXifl4Ca() < 10)
				{
					newExeSettingsWindow = new NewExeSettingsWindow(exeListControl.PncLN2iOaPH.Select(_003C_003Ec.qCcSnwa2QfH ?? (_003C_003Ec.qCcSnwa2QfH = _003C_003Ec.Ou8SjO8XVKU.k3bSjTb1Wkr)).ToList(), exeListControl.zXJLNLQ6gqe)
					{
						Owner = Window.GetWindow(exeListControl)
					};
					if (newExeSettingsWindow.ShowDialog() == true)
					{
						_003CexeSettings_003E5__2 = new ExeSettings
						{
							Exe = newExeSettingsWindow.LoweredExeFileName,
							Path = newExeSettingsWindow.ExePathName,
							Name = newExeSettingsWindow.ExeName,
							AliasExeList = newExeSettingsWindow.AliasExeList,
							UrlPattern = newExeSettingsWindow.UrlPattern
						};
						if (!_003CexeSettings_003E5__2.Exe.StartsWithAny(true, "#_", "@_") || _003CexeSettings_003E5__2.Exe.EndsWith(".exe", StringComparison.OrdinalIgnoreCase))
						{
							goto IL_0029;
						}
						goto IL_0206;
					}
				}
				else
				{
					AppHelper.ShowWarning("免费版可创建10个应用程序场景，已达到限额。请购买专业版后再使用此功能。");
				}
				goto end_IL_000e;
				IL_0206:
				exeListControl.SMaLNuSTcLD.SaveExeSettings(_003CexeSettings_003E5__2);
				dto = new CreateProfileDto
				{
					ExeFile = _003CexeSettings_003E5__2.Exe,
					ExeFilePathName = _003CexeSettings_003E5__2.Path,
					ProfileName = _003CexeSettings_003E5__2.Name
				};
				num2 = 0;
				if (!H96EifW6uHZGwcI46n44())
				{
					int num3 = default(int);
					num2 = num3;
				}
				goto IL_00f1;
				IL_00f1:
				switch (num2)
				{
				case 1:
					break;
				default:
				{
					exeListControl.SMaLNuSTcLD.AddProfile(dto);
					ExeInfo exeInfo = new ExeInfo
					{
						Exe = _003CexeSettings_003E5__2.Exe,
						Description = _003CexeSettings_003E5__2.Name,
						IconStr = _003CexeSettings_003E5__2.GetIconStr(),
						Name = _003CexeSettings_003E5__2.Name,
						AliasExeList = _003CexeSettings_003E5__2.AliasExeList.JoinToString(";")
					};
					exeListControl.PncLN2iOaPH.Add(exeInfo);
					exeListControl.LbExeList.SelectedItem = exeInfo;
					_003CexeSettings_003E5__2 = null;
					goto end_IL_000e;
				}
				}
				goto IL_0103;
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

		internal static bool H96EifW6uHZGwcI46n44()
		{
			return Jrv1h7W6LwJlwaaYaFPi == null;
		}
	}

	private DataService zXJLNLQ6gqe;

	private bool b8GLNvdtmAS;

	private string jiTLNS67ppq;

	[CompilerGenerated]
	private EventHandler<ExeChangedEventArgs> m_ExeChanged;

	[CompilerGenerated]
	private EventHandler<ExeChangedEventArgs> m_ItemDoubleClicked;

	private ObservableCollection<ExeInfo> PncLN2iOaPH = new ObservableCollection<ExeInfo>();

	private AppServer SMaLNuSTcLD;

	private ProfileManager FtGLNNmBh2U;

	private bool HL7LNJMtEN3;

	private bool xBOLN0MDo0Q;

	private static readonly ILog GaYLNC0EDIq;

	private bool gIyLNPJ3i7j;

	internal Grid GridFilter;

	internal SearchBoxControl SearchBox;

	internal ListBox LbExeList;

	internal Grid PnlButtons;

	internal Button BtnNewExeSettings;

	internal Button BtnEditExe;

	internal Button BtnDeleteExe;

	internal Button BtnGoToTop;

	private bool QSxLNEasykZ;

	internal static ExeListControl D1sHUYFjZHEa1wOati9O;

	public event EventHandler<ExeChangedEventArgs> ExeChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler<ExeChangedEventArgs> eventHandler = this.m_ExeChanged;
			EventHandler<ExeChangedEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ExeChangedEventArgs> value2 = (EventHandler<ExeChangedEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_ExeChanged, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<ExeChangedEventArgs> eventHandler = this.m_ExeChanged;
			EventHandler<ExeChangedEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ExeChangedEventArgs> value2 = (EventHandler<ExeChangedEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_ExeChanged, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<ExeChangedEventArgs> ItemDoubleClicked
	{
		[CompilerGenerated]
		add
		{
			EventHandler<ExeChangedEventArgs> eventHandler = this.m_ItemDoubleClicked;
			EventHandler<ExeChangedEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ExeChangedEventArgs> value2 = (EventHandler<ExeChangedEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_ItemDoubleClicked, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<ExeChangedEventArgs> eventHandler = this.m_ItemDoubleClicked;
			EventHandler<ExeChangedEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ExeChangedEventArgs> value2 = (EventHandler<ExeChangedEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_ItemDoubleClicked, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public ExeListControl()
	{
		InitializeComponent();
		base.Loaded += X63LuMGye3b;
	}

	public void Init(DataService dataService, string preSelectedExe, AppServer appServer, ProfileManager profileManager, bool forGestureOrCircleMenuSettings = false, bool hideGlobal = false)
	{
		zXJLNLQ6gqe = dataService;
		jiTLNS67ppq = preSelectedExe;
		SMaLNuSTcLD = appServer;
		FtGLNNmBh2U = profileManager;
		HL7LNJMtEN3 = forGestureOrCircleMenuSettings;
		xBOLN0MDo0Q = hideGlobal;
	}

	private void X63LuMGye3b(object sender, RoutedEventArgs e)
	{
		if (b8GLNvdtmAS)
		{
			return;
		}
		b8GLNvdtmAS = true;
		int num = 0;
		if (!Pj7NDEFj5S048wSHKLGl())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		xFTLuAd4Pcd();
		ICollectionView defaultView = CollectionViewSource.GetDefaultView(PncLN2iOaPH);
		defaultView.Filter = Filter;
		LbExeList.ItemsSource = defaultView;
		if (!string.IsNullOrEmpty(jiTLNS67ppq))
		{
			_003C_003Ec__DisplayClass18_0 _003C_003Ec__DisplayClass18_ = new _003C_003Ec__DisplayClass18_0();
			_003C_003Ec__DisplayClass18_.WhISnv0iLM9 = Path.GetFileName(jiTLNS67ppq).ToLowerInvariant();
			ExeInfo exeInfo = PncLN2iOaPH.FirstOrDefault(_003C_003Ec__DisplayClass18_.qpuSnLEGNGJ);
			if (exeInfo != null)
			{
				LbExeList.SelectedItem = exeInfo;
				LbExeList.ScrollIntoView(LbExeList.SelectedItem);
			}
		}
		if (LbExeList.SelectedItem == null)
		{
			LbExeList.SelectedIndex = 0;
		}
	}

	public ExeInfo GetSelectedExe()
	{
		return LbExeList.SelectedItem as ExeInfo;
	}

	public void SetSelectionMode()
	{
		PnlButtons.Visibility = Visibility.Collapsed;
		gIyLNPJ3i7j = true;
	}

	private void xFTLuAd4Pcd()
	{
		List<ExeSettings> list = zXJLNLQ6gqe.TxrtXFmcoEV().Values.OrderBy(_003C_003Ec.syHSjFuAxXW ?? (_003C_003Ec.syHSjFuAxXW = _003C_003Ec.Ou8SjO8XVKU.ATXSjjY9nBj)).ToList();
		if (!xBOLN0MDo0Q)
		{
			ExeInfo exeInfo = CommonExeInfo.Global;
			if (HL7LNJMtEN3)
			{
				exeInfo = AppHelper.Clone(exeInfo);
				exeInfo.Name = "全局";
			}
			PncLN2iOaPH.Add(exeInfo);
		}
		if (!HL7LNJMtEN3)
		{
			PncLN2iOaPH.Add(CommonExeInfo.Common);
		}
		PncLN2iOaPH.Add(CommonExeInfo.Taskbar);
		PncLN2iOaPH.Add(CommonExeInfo.Desktop);
		IList<ExeInfo> list2 = new List<ExeInfo>();
		foreach (ExeSettings item2 in list)
		{
			if (!CommonExeInfo.IsCommonExe(item2.Exe))
			{
				if (string.IsNullOrEmpty(item2.Name))
				{
					item2.Name = item2.Exe;
				}
				list2.Add(new ExeInfo(item2));
			}
		}
		foreach (ActionProfile value in zXJLNLQ6gqe.mP6tXA8VyNP().Values)
		{
			if (!string.IsNullOrEmpty(value.ExeFile) && value.ExeFile.EndsWith(".exe", StringComparison.OrdinalIgnoreCase))
			{
				_003C_003Ec__DisplayClass21_0 _003C_003Ec__DisplayClass21_ = new _003C_003Ec__DisplayClass21_0();
				_003C_003Ec__DisplayClass21_.dbcSn2aeRjg = value.ExeFile.ToLower(CultureInfo.InvariantCulture);
				if (!list2.Any(_003C_003Ec__DisplayClass21_.QgWSnSu87CM))
				{
					ExeInfo item = new ExeInfo
					{
						Name = ExeHelper.GetFileDescription(value.ExeFullpath),
						Exe = _003C_003Ec__DisplayClass21_.dbcSn2aeRjg,
						Path = value.ExeFullpath,
						Description = value.ExeDisplayName,
						IconStr = ExeFileIconHelper.GetExeFileIconStr(value.ExeFile, value.ExeFullpath)
					};
					list2.Add(item);
				}
			}
		}
		foreach (ExeInfo item3 in list2.Where(_003C_003Ec.LNISjUy6hgw ?? (_003C_003Ec.LNISjUy6hgw = _003C_003Ec.Ou8SjO8XVKU.cPTSjnkbm2Q)).OrderBy(_003C_003Ec.MenSjlq2FST ?? (_003C_003Ec.MenSjlq2FST = _003C_003Ec.Ou8SjO8XVKU.sjPSj4lOkaW)))
		{
			PncLN2iOaPH.Add(item3);
		}
		IEnumerator<ExeInfo> enumerator4 = list2.Where(_003C_003Ec.mQ5Sji6WKN0 ?? (_003C_003Ec.mQ5Sji6WKN0 = _003C_003Ec.Ou8SjO8XVKU.TuoSj5H4Ji4)).OrderBy(_003C_003Ec.bF4Sj3iu3vM ?? (_003C_003Ec.bF4Sj3iu3vM = _003C_003Ec.Ou8SjO8XVKU.CiGSjDKwBL1)).GetEnumerator();
		int num = 0;
		if (!Pj7NDEFj5S048wSHKLGl())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		try
		{
			while (enumerator4.MoveNext())
			{
				ExeInfo current4 = enumerator4.Current;
				PncLN2iOaPH.Add(current4);
			}
		}
		finally
		{
			enumerator4?.Dispose();
		}
		foreach (ExeInfo item4 in list2.Where(_003C_003Ec.mx1Sjfy3hgd ?? (_003C_003Ec.mx1Sjfy3hgd = _003C_003Ec.Ou8SjO8XVKU.L4GSjdWZfAq)).OrderBy(_003C_003Ec.g63SjzfWrKW ?? (_003C_003Ec.g63SjzfWrKW = _003C_003Ec.Ou8SjO8XVKU.aZjSjoAZKtZ)))
		{
			PncLN2iOaPH.Add(item4);
		}
	}

	[AsyncStateMachine(typeof(_003CBtnNewExeSettings_OnClick_003Ed__22))]
	private void dnDLuOu5D4c(object sender, RoutedEventArgs e)
	{
		_003CBtnNewExeSettings_OnClick_003Ed__22 stateMachine = default(_003CBtnNewExeSettings_OnClick_003Ed__22);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void desLuFsckQm(object sender, RoutedEventArgs e)
	{
		ExeInfo exeInfo_ = LbExeList.SelectedItem as ExeInfo;
		C9ELuUJJkZb(exeInfo_);
	}

	private void C9ELuUJJkZb(ExeInfo exeInfo_0)
	{
		ExeSettings exeSettings;
		EditExeSettingsWindow editExeSettingsWindow;
		int num;
		if (exeInfo_0 != null && (exeInfo_0.Exe.EndsWith(".exe", StringComparison.OrdinalIgnoreCase) || exeInfo_0.Exe.StartsWithAny(false, "#_", "@_")))
		{
			exeSettings = zXJLNLQ6gqe.yQWt6ownR4Z(exeInfo_0.Exe, true);
			editExeSettingsWindow = new EditExeSettingsWindow(exeSettings)
			{
				Owner = Window.GetWindow(this)
			};
			if (editExeSettingsWindow.ShowDialog() == true)
			{
				num = 0;
				if (Pj7NDEFj5S048wSHKLGl())
				{
					goto IL_008b;
				}
				goto IL_00fc;
			}
			return;
		}
		AppHelper.ShowInformation("此项不可编辑。");
		return;
		IL_00fc:
		switch (num)
		{
		case 1:
			exeInfo_0.AliasExeList = editExeSettingsWindow.AliasExeList.JoinToString(";");
			exeInfo_0.IconStr = exeSettings.GetIconStr();
			SMaLNuSTcLD.SaveExeSettings(exeSettings);
			exeInfo_0.Name = editExeSettingsWindow.ExeName;
			LbExeList.Items.Refresh();
			if (exeSettings.Exe.StartsWith("@_"))
			{
				AppState.vjAt7Seco0Y()?.PushActions(null);
			}
			return;
		}
		goto IL_008b;
		IL_008b:
		exeSettings.Name = editExeSettingsWindow.ExeName;
		exeSettings.Path = editExeSettingsWindow.Path;
		exeSettings.AliasExeList = editExeSettingsWindow.AliasExeList;
		exeSettings.UrlPattern = editExeSettingsWindow.UrlPattern;
		exeSettings.IconUrl = editExeSettingsWindow.IconUrl;
		exeInfo_0.Name = editExeSettingsWindow.ExeName;
		exeInfo_0.Path = editExeSettingsWindow.Path;
		num = 1;
		if (!Pj7NDEFj5S048wSHKLGl())
		{
			int num2 = default(int);
			num = num2;
		}
		goto IL_00fc;
	}

	private void HafLulHCvg3(object sender, SelectionChangedEventArgs e)
	{
		if (LbExeList.SelectedItem is ExeInfo exeInfo)
		{
			this.m_ExeChanged?.Invoke(this, new ExeChangedEventArgs
			{
				ExeInfo = exeInfo
			});
		}
	}

	private void ErFLuieKW1V(object sender, MouseButtonEventArgs e)
	{
		if (e.ClickCount >= 2)
		{
			ExeInfo exeInfo = LbExeList.SelectedItem as ExeInfo;
			if (gIyLNPJ3i7j)
			{
				this.m_ItemDoubleClicked?.Invoke(this, new ExeChangedEventArgs
				{
					ExeInfo = exeInfo
				});
			}
			else
			{
				C9ELuUJJkZb(exeInfo);
			}
		}
	}

	private void lmWLu3heMDN(object sender, RoutedEventArgs e)
	{
		if (!(Window.GetWindow(this) is ExeSettingsWindow))
		{
			if (MessageBoxHelper.Show(Window.GetWindow(this), "删除应用场景需要在【场景与动作管理】窗口中操作，\r\n是否立即打开该窗口？", "删除场景", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
			{
				ExeInfo exeInfo = LbExeList.SelectedItem as ExeInfo;
				AppState.HS2taepcAbc().ShowExeSettingsWindow(exeInfo?.Exe);
			}
			return;
		}
		int num;
		ContentPresenter contentPresenter = default(ContentPresenter);
		if (LbExeList.SelectedItem == null)
		{
			num = 0;
			if (Pj7NDEFj5S048wSHKLGl())
			{
				goto IL_01b8;
			}
		}
		else
		{
			ExeInfo exeInfo2 = LbExeList.SelectedItem as ExeInfo;
			if (CommonExeInfo.IsCommonExe(exeInfo2.Exe))
			{
				AppHelper.ShowInformation("不能删除此场景。");
				return;
			}
			if (FtGLNNmBh2U.GetAllProfilesByExe(exeInfo2.Exe).Count <= 0)
			{
				if (AppHelper.Confirm("请注意：\r\n此操作将会删除相关的手势、轮盘、左键辅助等相关规则，且无法恢复。\r\n您确认要删场景 " + exeInfo2.Name + "(" + exeInfo2.Exe + ") 么？"))
				{
					zXJLNLQ6gqe.Dxnt6OJIGNi(exeInfo2.Exe);
					LbExeList.SelectedIndex -= 1;
					PncLN2iOaPH.Remove(exeInfo2);
				}
				return;
			}
			AppHelper.ShowWarning("请先删除场景的所有动作页。", true);
			if (!(Window.GetWindow(this) is ExeSettingsWindow exeSettingsWindow) || exeSettingsWindow.ActionPages.LbProfiles.Items.Count <= 0)
			{
				return;
			}
			ListBoxItem dependencyObject_ = (ListBoxItem)exeSettingsWindow.ActionPages.LbProfiles.ItemContainerGenerator.ContainerFromIndex(0);
			contentPresenter = CAgLufAW9HK<ContentPresenter>(dependencyObject_);
			num = 1;
			if (!Pj7NDEFj5S048wSHKLGl())
			{
				int num2 = default(int);
				num = num2;
			}
		}
		switch (num)
		{
		case 1:
			if (contentPresenter.ContentTemplate.FindName("DropDownMenu", contentPresenter) is DropDownButton dropDownButton)
			{
				dropDownButton.OpenMenu();
			}
			return;
		}
		goto IL_01b8;
		IL_01b8:
		AppHelper.ShowInformation("请选择要删除的场景。");
	}

	private xAGc2yY6bUvfhybulVK CAgLufAW9HK<xAGc2yY6bUvfhybulVK>(DependencyObject dependencyObject_0) where xAGc2yY6bUvfhybulVK : DependencyObject
	{
		int num = 0;
		xAGc2yY6bUvfhybulVK val;
		while (true)
		{
			if (num < VisualTreeHelper.GetChildrenCount(dependencyObject_0))
			{
				DependencyObject child = VisualTreeHelper.GetChild(dependencyObject_0, num);
				if (child == null || !(child is xAGc2yY6bUvfhybulVK))
				{
					val = CAgLufAW9HK<xAGc2yY6bUvfhybulVK>(child);
					if (val != null)
					{
						break;
					}
					num++;
					continue;
				}
				return (xAGc2yY6bUvfhybulVK)child;
			}
			return null;
		}
		return val;
	}

	public void TriggerDeleteExe()
	{
		AppHelper.TriggerButtonClick(BtnDeleteExe);
	}

	private void uboLuzGRPSL(object sender, DragEventArgs e)
	{
		ExeInfo exeInfo = (sender as FrameworkElement).Tag as ExeInfo;
		e.Data.GetFormats();
		if (!e.Data.GetDataPresent(typeof(ActionProfile)))
		{
			return;
		}
		ActionProfile actionProfile = e.Data.GetData(typeof(ActionProfile)) as ActionProfile;
		if (Pj7NDEFj5S048wSHKLGl())
		{
			switch (0)
			{
			}
		}
		if (exeInfo.Exe == "_global" && actionProfile.ActionItems.Any(_003C_003Ec.qArSntcPSeP ?? (_003C_003Ec.qArSntcPSeP = _003C_003Ec.Ou8SjO8XVKU.JgeSjM6NlLm)))
		{
			AppHelper.ShowWarning("需清空末行动作后才可以转换为全局动作页");
		}
		else if (actionProfile != null && !actionProfile.IsDefaultGlobalProfile())
		{
			actionProfile.ExeFile = exeInfo.Exe;
			zXJLNLQ6gqe.xHZt6K2LJ8p(actionProfile);
			zXJLNLQ6gqe.xdNt6mQNakh(false);
			LbExeList.SelectedItem = exeInfo;
		}
		else
		{
			AppHelper.ShowWarning("默认全局动作页不支持更改应用程序");
		}
	}

	private void D8eLNwASnZ8(object sender, RoutedEventArgs e)
	{
		AppHelper.TriggerButtonClick(BtnEditExe);
	}

	private void BgFLNtnlNqD(object sender, RoutedEventArgs e)
	{
		if (LbExeList.SelectedItem is ExeInfo exeInfo)
		{
			ActionEditMgr.CreateLoadExePagesAction(exeInfo, true);
			AppHelper.ShowSuccess("已创建动作并写入剪贴板，请在动作页上右键粘贴到合适位置。");
		}
	}

	private bool Filter(object obj)
	{
		string searchText = SearchBox.SearchText;
		if (string.IsNullOrEmpty(searchText))
		{
			return true;
		}
		if (!(obj is ExeInfo exeInfo))
		{
			return false;
		}
		if (tkxn6HAKAgMT8gvXbyh.SgJi5c1l5A(exeInfo.Name, searchText) == null && exeInfo.Exe.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) < 0)
		{
			return exeInfo.AliasExeList?.Contains(searchText) ?? false;
		}
		return true;
	}

	private void SearchBoxControl_OnSearchTextChanged(object sender, RoutedEventArgs e)
	{
		CollectionViewSource.GetDefaultView(PncLN2iOaPH).Refresh();
	}

	public void TrySelectExe(string exeBeforeShowConfigWindow)
	{
		_003C_003Ec__DisplayClass35_0 _003C_003Ec__DisplayClass35_ = new _003C_003Ec__DisplayClass35_0();
		_003C_003Ec__DisplayClass35_.DXfSnN7nour = exeBeforeShowConfigWindow;
		if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass35_.DXfSnN7nour))
		{
			return;
		}
		try
		{
			ExeInfo exeInfo = PncLN2iOaPH?.FirstOrDefault(_003C_003Ec__DisplayClass35_.fFkSnucK7gt);
			if (exeInfo == null)
			{
				exeInfo = PncLN2iOaPH?.FirstOrDefault(_003C_003Ec.hBtSngeFYJA ?? (_003C_003Ec.hBtSngeFYJA = _003C_003Ec.Ou8SjO8XVKU.cbPSjA9WpAv));
			}
			if (exeInfo != null)
			{
				LbExeList.SelectedItem = exeInfo;
				LbExeList.ScrollIntoView(exeInfo);
			}
		}
		catch (Exception)
		{
		}
	}

	private void bBQLNge7vEM(object sender, RoutedEventArgs e)
	{
		LbExeList.SelectedIndex = 0;
		LbExeList.ScrollIntoView(LbExeList.SelectedItem);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!QSxLNEasykZ)
		{
			QSxLNEasykZ = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/profilemanagement/exelistcontrol.xaml", UriKind.Relative);
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
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 1:
			GridFilter = (Grid)target;
			break;
		case 2:
			SearchBox = (SearchBoxControl)target;
			break;
		case 3:
			LbExeList = (ListBox)target;
			LbExeList.SelectionChanged += HafLulHCvg3;
			break;
		default:
			QSxLNEasykZ = true;
			break;
		case 7:
			PnlButtons = (Grid)target;
			break;
		case 8:
		{
			BtnNewExeSettings = (Button)target;
			BtnNewExeSettings.Click += dnDLuOu5D4c;
			int num = 0;
			if (!Pj7NDEFj5S048wSHKLGl())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			break;
		}
		case 9:
			BtnEditExe = (Button)target;
			BtnEditExe.Click += desLuFsckQm;
			break;
		case 10:
			BtnDeleteExe = (Button)target;
			BtnDeleteExe.Click += lmWLu3heMDN;
			break;
		case 11:
			BtnGoToTop = (Button)target;
			BtnGoToTop.Click += bBQLNge7vEM;
			break;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 4:
			((StackPanel)target).Drop += uboLuzGRPSL;
			((StackPanel)target).MouseDown += ErFLuieKW1V;
			break;
		case 5:
			((MenuItem)target).Click += D8eLNwASnZ8;
			break;
		case 6:
			((MenuItem)target).Click += BgFLNtnlNqD;
			break;
		}
	}

	static ExeListControl()
	{
		GaYLNC0EDIq = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static void Eun8ALFj8yRuO5TDlpfe()
	{
	}

	internal static bool Pj7NDEFj5S048wSHKLGl()
	{
		return D1sHUYFjZHEa1wOati9O == null;
	}
}
