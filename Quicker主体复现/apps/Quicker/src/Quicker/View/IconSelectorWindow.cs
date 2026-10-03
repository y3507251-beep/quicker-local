using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Navigation;
using IgQBbvXMVdsN7GVNUxX;
using log4net;
using Microsoft.Win32;
using Ninject;
using Ninject.Parameters;
using Quicker.Common.Vm;
using Quicker.Domain;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.UI;

namespace Quicker.View;

public class IconSelectorWindow : Window, IComponentConnector, IStyleConnector
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CBtnUpload_OnClick_003Ed__22 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public IconSelectorWindow _003C_003E4__this;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object vbmmOOWPFgJ8rJWZS17D;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			IconSelectorWindow iconSelectorWindow = _003C_003E4__this;
			try
			{
        string fileName = default;
				if (num == 0)
				{
					goto IL_0078;
				}
				int num2 = 0;
				if (!WR47dVWPcrY1UI2xZAEW())
				{
					int num3 = default(int);
					num2 = num3;
				}
				switch (num2)
				{
				}
				OpenFileDialog openFileDialog = new OpenFileDialog
				{
					FileName = "icon",
					DefaultExt = ".png",
					Filter = "所有支持的文件|*.png;*.ico;*.svg;*.exe|PNG 图片|*.png|Icon文件|*.ico|Exe 文件|*.exe|Svg图标|*.svg"
				};
				fileName = default(string);
				if (openFileDialog.ShowDialog() == true)
				{
					fileName = openFileDialog.FileName;
					goto IL_0078;
				}
				goto end_IL_0010;
				IL_0078:
				try
				{
					ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = iconSelectorWindow.IconManager.UploadIconImageFileAsync(fileName).ConfigureAwait(true).GetAwaiter();
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
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
						int num4 = 0;
						if (!WR47dVWPcrY1UI2xZAEW())
						{
							int num5 = default(int);
							num4 = num5;
						}
						switch (num4)
						{
						}
					}
					string result = awaiter.GetResult();
					iconSelectorWindow.IddgiWyDKuD(result);
				}
				catch (Exception ex)
				{
					x3kgix4gtoy.Warn("保存图标失败！" + ex.GetMessageWithInner(), ex);
					AppHelper.ShowWarning("无法保存图标！" + ex.Message);
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

		internal static bool WR47dVWPcrY1UI2xZAEW()
		{
			return vbmmOOWPFgJ8rJWZS17D == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDoQueryAsync_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public bool resetStart;

		public IconSelectorWindow _003C_003E4__this;

		private ConfiguredTaskAwaitable<ApiResult<IList<IconFileDto>>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object hBbdBDWPy3gwjHxxOaha;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			IconSelectorWindow iconSelectorWindow = _003C_003E4__this;
			try
			{
				if (num != 0 && resetStart)
				{
					iconSelectorWindow.qZtgiQVJT2f = 0;
					iconSelectorWindow.BtnGetMore.IsEnabled = false;
					iconSelectorWindow.Icons.Clear();
				}
				try
				{
					ConfiguredTaskAwaitable<ApiResult<IList<IconFileDto>>>.ConfiguredTaskAwaiter awaiter;
					int num2;
					if (num != 0)
					{
						awaiter = aFIptTXYsUoTUF4v33R.ORBt1x1qGAw(iconSelectorWindow.TxtKeyword.Text, iconSelectorWindow.qZtgiQVJT2f, iconSelectorWindow.XosgijMZQ6j + 1).ConfigureAwait(true).GetAwaiter();
						if (awaiter.IsCompleted)
						{
							goto IL_00e8;
						}
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num2 = 1;
						if (!l8GQJ6WPpbKbiBJhNEAL())
						{
							goto IL_00d7;
						}
					}
					else
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ApiResult<IList<IconFileDto>>>.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
						num2 = 0;
						if (!l8GQJ6WPpbKbiBJhNEAL())
						{
							goto IL_00d7;
						}
					}
					goto IL_00db;
					IL_00db:
					switch (num2)
					{
					case 1:
						return;
					}
					goto IL_00e8;
					IL_00d7:
					int num3 = default(int);
					num2 = num3;
					goto IL_00db;
					IL_00e8:
					ApiResult<IList<IconFileDto>> result = awaiter.GetResult();
					if (result.IsSuccess)
					{
						if (result.Data.Count != 0)
						{
							IEnumerator<IconFileDto> enumerator = result.Data.Take(iconSelectorWindow.XosgijMZQ6j).GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									IconFileDto current = enumerator.Current;
									iconSelectorWindow.Icons.Add(current);
								}
							}
							finally
							{
								if (num < 0)
								{
									enumerator?.Dispose();
								}
							}
							iconSelectorWindow.BtnGetMore.IsEnabled = result.Data.Count > iconSelectorWindow.XosgijMZQ6j;
							iconSelectorWindow.hOpgibAkksv();
						}
						else
						{
							AppHelper.ShowInformation("没有可用的图标。您可以上传本地图标。");
						}
					}
					else
					{
						AppHelper.ShowWarning("加载图标失败。" + result.Message);
					}
				}
				catch (Exception ex)
				{
					MessageBoxHelper.Show(iconSelectorWindow, "加载图标失败。" + ex.Message, "Quicker", MessageBoxButton.OK, MessageBoxImage.Exclamation);
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

		internal static bool l8GQJ6WPpbKbiBJhNEAL()
		{
			return hBbdBDWPy3gwjHxxOaha == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CMenuDelete_OnClick_003Ed__31 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public object sender;

		public IconSelectorWindow _003C_003E4__this;

		private IconFileDto _003CiconFile_003E5__2;

		private ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter _003C_003Eu__1;

		internal static object aPT4eqWPnoZ1tLFMPPGP;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			IconSelectorWindow iconSelectorWindow = _003C_003E4__this;
			try
			{
				if (num == 0)
				{
					goto IL_0056;
				}
				_003CiconFile_003E5__2 = (sender as FrameworkElement).Tag as IconFileDto;
				if (_003CiconFile_003E5__2 != null)
				{
					if (AppState.DataService.Hb9tmk3OsJ7())
					{
						goto IL_0056;
					}
					AppHelper.ShowWarning("此操作需要专业版支持。");
				}
				goto end_IL_000e;
				IL_0056:
				try
				{
					ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = aFIptTXYsUoTUF4v33R.biAt1rk3xe5(_003CiconFile_003E5__2.FileId).ConfigureAwait(true).GetAwaiter();
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
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable<ApiResult<string>>.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
					}
					ApiResult<string> result = awaiter.GetResult();
					if (!result.IsSuccess)
					{
						if (aPT4eqWPnoZ1tLFMPPGP != null)
						{
							switch (0)
							{
							}
						}
						AppHelper.ShowWarning("删除图标失败。" + result.Message);
					}
					else
					{
						iconSelectorWindow.Icons.Remove(_003CiconFile_003E5__2);
					}
				}
				catch (Exception exception)
				{
					x3kgix4gtoy.Warn("删除图标出错：" + exception.GetMessageWithInner(), exception);
					AppHelper.ShowWarning("删除图标出错：" + exception.GetMessageWithInner(), true);
				}
				end_IL_000e:;
			}
			catch (Exception exception2)
			{
				_003C_003E1__state = -2;
				_003CiconFile_003E5__2 = null;
				_003C_003Et__builder.SetException(exception2);
				return;
			}
			_003C_003E1__state = -2;
			_003CiconFile_003E5__2 = null;
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

		internal static bool pGBtTqWPefNOGih5pU9y()
		{
			return aPT4eqWPnoZ1tLFMPPGP == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003COnLoaded_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public IconSelectorWindow _003C_003E4__this;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

		private static object tXAUZSWPE0tj05ck0uXI;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			IconSelectorWindow iconSelectorWindow = _003C_003E4__this;
			try
			{
				if (num != 0)
				{
					iconSelectorWindow.TxtKeyword.Focus();
				}
				try
				{
					ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = iconSelectorWindow.awIgiYuc7nS(true).ConfigureAwait(true).GetAwaiter();
						int num2 = 0;
						if (tXAUZSWPE0tj05ck0uXI != null)
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
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
						_003C_003Eu__1 = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
					}
					awaiter.GetResult();
				}
				catch (Exception exception)
				{
					x3kgix4gtoy.Warn("加载图标出错。" + exception.GetMessageWithInner(), exception);
					AppHelper.ShowWarning("加载图标出错。" + exception.GetMessageWithInner(), true);
				}
			}
			catch (Exception exception2)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception2);
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

		internal static bool zofLisWPG8WehJf2W23F()
		{
			return tXAUZSWPE0tj05ck0uXI == null;
		}
	}

	private static readonly ILog x3kgix4gtoy;

	[CompilerGenerated]
	private IconManager yFJgirgOu7x;

	[CompilerGenerated]
	private string P7ggip5sjVA;

	[CompilerGenerated]
	private readonly ObservableCollection<IconFileDto> bbagiBqeDL0 = new ObservableCollection<IconFileDto>();

	private int qZtgiQVJT2f;

	private readonly int XosgijMZQ6j = 40;

	[CompilerGenerated]
	private bool sPMginrLaVe;

	internal IconSelectorWindow TheWindow;

	internal TextBox TxtKeyword;

	internal Button BtnClearKeyword;

	internal Button BtnSearch;

	internal Button BtnUpload;

	internal ListBox IconList;

	internal Button BtnGetMore;

	internal Button BtnOk;

	private bool HVVgi4Zkcft;

	private static IconSelectorWindow IVEbJPFpWQyd9f6Br9rQ;

	public IconManager IconManager
	{
		[CompilerGenerated]
		get
		{
			return yFJgirgOu7x;
		}
		[CompilerGenerated]
		private set
		{
			yFJgirgOu7x = value;
		}
	}

	public string SelectedIconUrl
	{
		[CompilerGenerated]
		get
		{
			return P7ggip5sjVA;
		}
		[CompilerGenerated]
		set
		{
			P7ggip5sjVA = value;
		}
	}

	public ObservableCollection<IconFileDto> Icons
	{
		[CompilerGenerated]
		get
		{
			return bbagiBqeDL0;
		}
	}

	public bool CanDelete
	{
		[CompilerGenerated]
		get
		{
			return sPMginrLaVe;
		}
		[CompilerGenerated]
		set
		{
			sPMginrLaVe = value;
		}
	}

	public IconSelectorWindow()
	{
		IconManager = AppState.dAntabrFWrV().Get<IconManager>(Array.Empty<IParameter>());
		InitializeComponent();
		IconList.ItemsSource = Icons;
		base.Loaded += VvmgiejNYnQ;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		if (AppState.HHxtaMaoqJr().EnableUiAutomation)
		{
			return base.OnCreateAutomationPeer();
		}
		return new FakeWindowsPeer(this);
	}

	[AsyncStateMachine(typeof(_003COnLoaded_003Ed__20))]
	private void VvmgiejNYnQ(object sender, RoutedEventArgs e)
	{
		_003COnLoaded_003Ed__20 stateMachine = default(_003COnLoaded_003Ed__20);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CDoQueryAsync_003Ed__21))]
	private Task awIgiYuc7nS(bool bool_2)
	{
		_003CDoQueryAsync_003Ed__21 stateMachine = default(_003CDoQueryAsync_003Ed__21);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.resetStart = bool_2;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CBtnUpload_OnClick_003Ed__22))]
	private void qLygiINmN8n(object sender, RoutedEventArgs e)
	{
		_003CBtnUpload_OnClick_003Ed__22 stateMachine = default(_003CBtnUpload_OnClick_003Ed__22);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void IddgiWyDKuD(string string_1)
	{
		SelectedIconUrl = string_1;
		base.DialogResult = true;
	}

	private void AH2gikOc3RJ(object sender, RoutedEventArgs e)
	{
		if (IconList.SelectedItem != null)
		{
			IconFileDto iconFileDto = IconList.SelectedItem as IconFileDto;
			IddgiWyDKuD(iconFileDto.Url);
		}
		else
		{
			MessageBoxHelper.Show(this, "请选择一个图标。");
		}
	}

	private void IPwgiG5ULOh(object sender, RoutedEventArgs e)
	{
		TxtKeyword.Text = "";
		awIgiYuc7nS(true);
	}

	private void Sjmgis9IDIJ(object sender, RoutedEventArgs e)
	{
		qZtgiQVJT2f = 0;
		BtnGetMore.IsEnabled = false;
		awIgiYuc7nS(true);
	}

	private void rqtgiHsiHr2(object sender, RoutedEventArgs e)
	{
		qZtgiQVJT2f += XosgijMZQ6j;
		awIgiYuc7nS(false);
	}

	private void S5ggi1evLUI(object sender, KeyEventArgs e)
	{
		if (e.Key == Key.Return)
		{
			e.Handled = true;
			awIgiYuc7nS(true);
		}
	}

	private void hOpgibAkksv()
	{
		IconList.SelectedIndex = IconList.Items.Count - 1;
		IconList.ScrollIntoView(IconList.SelectedItem);
	}

	private void znRgi6L0xJm(object sender, RequestNavigateEventArgs e)
	{
		try
		{
			Process.Start(e.Uri.ToString());
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("无法打开链接。" + ex.Message);
		}
	}

	[AsyncStateMachine(typeof(_003CMenuDelete_OnClick_003Ed__31))]
	private void jBigiX49H4e(object sender, RoutedEventArgs e)
	{
		_003CMenuDelete_OnClick_003Ed__31 stateMachine = default(_003CMenuDelete_OnClick_003Ed__31);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.sender = sender;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void fgFgimXDvkb(object sender, RoutedEventArgs e)
	{
		IconFileDto iconFileDto = (sender as FrameworkElement).Tag as IconFileDto;
		ClipboardHelper.SetText(iconFileDto.Url);
		AppHelper.ShowSuccess("已复制网址：" + iconFileDto.Url);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!HVVgi4Zkcft)
		{
			HVVgi4Zkcft = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/ui/iconselectorwindow.xaml", UriKind.Relative);
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
		switch (connectionId)
		{
		case 1:
			TheWindow = (IconSelectorWindow)target;
			break;
		case 2:
			TxtKeyword = (TextBox)target;
			TxtKeyword.KeyDown += S5ggi1evLUI;
			break;
		case 3:
			BtnClearKeyword = (Button)target;
			BtnClearKeyword.Click += IPwgiG5ULOh;
			break;
		case 4:
			BtnSearch = (Button)target;
			BtnSearch.Click += Sjmgis9IDIJ;
			break;
		case 5:
		{
			BtnUpload = (Button)target;
			int num = 0;
			if (IVEbJPFpWQyd9f6Br9rQ != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				BtnUpload.Click += qLygiINmN8n;
				break;
			}
			break;
		}
		case 6:
			IconList = (ListBox)target;
			break;
		default:
			HVVgi4Zkcft = true;
			break;
		case 9:
			BtnGetMore = (Button)target;
			BtnGetMore.Click += rqtgiHsiHr2;
			break;
		case 10:
			BtnOk = (Button)target;
			BtnOk.Click += AH2gikOc3RJ;
			break;
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IStyleConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 8:
			((MenuItem)target).Click += jBigiX49H4e;
			break;
		case 7:
			((MenuItem)target).Click += fgFgimXDvkb;
			break;
		}
	}

	static IconSelectorWindow()
	{
		x3kgix4gtoy = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool VyEEOcFpyQPDBZh7eghS()
	{
		return IVEbJPFpWQyd9f6Br9rQ == null;
	}
}
