using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using log4net;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.Wpf;
using Quicker.Utilities;
using upLrfmibGdtSX9dWuOT;

namespace Quicker.View.UI;

public class MultiTabWebViewItem : INotifyPropertyChanged
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CCoreWebView2_FaviconChanged_003Ed__56 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public MultiTabWebViewItem _003C_003E4__this;

		private TaskAwaiter<Stream> _003C_003Eu__1;

		private static object WNuXSrWm0RnNX6bd2FId;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MultiTabWebViewItem multiTabWebViewItem = _003C_003E4__this;
			try
			{
				try
				{
					TaskAwaiter<Stream> awaiter;
					if (num != 0)
					{
						awaiter = multiTabWebViewItem.WebView.CoreWebView2.GetFaviconAsync(CoreWebView2FaviconImageFormat.Png).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							int num2 = 0;
							if (WNuXSrWm0RnNX6bd2FId != null)
							{
								int num3 = default(int);
								num2 = num3;
							}
							switch (num2)
							{
							}
							return;
						}
					}
					else
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<Stream>);
						num = -1;
						_003C_003E1__state = -1;
					}
					Stream result = awaiter.GetResult();
					if (result != null && result.Length != 0L)
					{
						multiTabWebViewItem.Icon = BitmapFrame.Create(result);
					}
					else
					{
						multiTabWebViewItem.Icon = null;
					}
				}
				catch (Exception ex)
				{
					ptULaxoXLEv.Warn("设置图标出错：" + ex.Message + " uri:" + multiTabWebViewItem.WebView.CoreWebView2?.FaviconUri, ex);
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

		internal static bool mW1OQUWm1tTETqao9Zca()
		{
			return WNuXSrWm0RnNX6bd2FId == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CInitializeWebViewAsync_003Ed__64 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public MultiTabWebViewItem _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		internal static object K1OfgOWmB1UPQDCs5Uak;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MultiTabWebViewItem multiTabWebViewItem = _003C_003E4__this;
			try
			{
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						CoreWebView2CreationProperties coreWebView2CreationProperties = new CoreWebView2CreationProperties
						{
							UserDataFolder = V1kWZri8vrLTHgNDH0k.NoGvS8R8WYG()
						};
						if (!string.IsNullOrEmpty(multiTabWebViewItem.ProfileName))
						{
							coreWebView2CreationProperties.ProfileName = multiTabWebViewItem.ProfileName;
						}
						coreWebView2CreationProperties.AdditionalBrowserArguments = " --enable-features=msWebView2EnableDraggableRegions";
						int num2 = 0;
						if (!jPrkbjWmvQD5ygLy47Us())
						{
							int num3 = default(int);
							num2 = num3;
						}
						switch (num2)
						{
						}
						multiTabWebViewItem.WebView.CreationProperties = coreWebView2CreationProperties;
						awaiter = multiTabWebViewItem.WebView.EnsureCoreWebView2Async(null, null).GetAwaiter();
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
					}
					awaiter.GetResult();
				}
				catch (Exception ex)
				{
					ptULaxoXLEv.Warn("初始化Webview出错：" + ex.Message, ex);
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

		internal static bool jPrkbjWmvQD5ygLy47Us()
		{
			return K1OfgOWmB1UPQDCs5Uak == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CWebViewOnKeyDown_003Ed__30 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public KeyEventArgs e;

		public MultiTabWebViewItem _003C_003E4__this;

		private TaskAwaiter<string> _003C_003Eu__1;

		internal static object istpDBWmOPhuPORl8cjI;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MultiTabWebViewItem multiTabWebViewItem = _003C_003E4__this;
			try
			{
				if (num == 0 || (e.Key == Key.A && Keyboard.Modifiers == ModifierKeys.Control))
				{
					try
					{
						TaskAwaiter<string> awaiter;
						if (num != 0)
						{
							awaiter = multiTabWebViewItem.WebView.CoreWebView2.ExecuteScriptAsync("document.execCommand('selectAll')").GetAwaiter();
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
							_003C_003Eu__1 = default(TaskAwaiter<string>);
							num = -1;
							_003C_003E1__state = -1;
						}
						awaiter.GetResult();
						e.Handled = true;
					}
					catch (Exception ex)
					{
						AppHelper.ShowInformation(ex.Message);
					}
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

		internal static bool XOO5yVWmJ2gCCb9NrErM()
		{
			return istpDBWmOPhuPORl8cjI == null;
		}
	}

	private static readonly ILog ptULaxoXLEv;

	private string dLULarhTVey;

	private ImageSource xS4Lap8shKE;

	private WebView2 WqKLaBoDoLK;

	private string sqeLaQI9eBy;

	private string AsILajCglli;

	private string r9LLanCGMru;

	[CompilerGenerated]
	private bool cS7La4DZ273;

	[CompilerGenerated]
	private bool r5HLa5cETUR;

	[CompilerGenerated]
	private string xBPLaDOa2pq;

	[CompilerGenerated]
	private string tFNLad97q8J;

	public EventHandler HistoryChanged;

	public EventHandler GotFocus;

	[CompilerGenerated]
	private string YOnLao3AFYu;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	internal static MultiTabWebViewItem p09yo2F01NnMfi7FEE7C;

	public bool HasPresetTitle
	{
		[CompilerGenerated]
		get
		{
			return cS7La4DZ273;
		}
		[CompilerGenerated]
		private set
		{
			cS7La4DZ273 = value;
		}
	}

	public bool HasPresetIcon
	{
		[CompilerGenerated]
		get
		{
			return r5HLa5cETUR;
		}
		[CompilerGenerated]
		private set
		{
			r5HLa5cETUR = value;
		}
	}

	public string UserAgent
	{
		[CompilerGenerated]
		get
		{
			return xBPLaDOa2pq;
		}
		[CompilerGenerated]
		set
		{
			xBPLaDOa2pq = value;
		}
	}

	public string DefaultDownloadFolderPath
	{
		[CompilerGenerated]
		get
		{
			return tFNLad97q8J;
		}
		[CompilerGenerated]
		set
		{
			tFNLad97q8J = value;
		}
	}

	public string ProfileName
	{
		[CompilerGenerated]
		get
		{
			return YOnLao3AFYu;
		}
		[CompilerGenerated]
		set
		{
			YOnLao3AFYu = value;
		}
	}

	public string Title
	{
		get
		{
			return dLULarhTVey;
		}
		set
		{
			if (!(value == dLULarhTVey))
			{
				dLULarhTVey = value;
				OnPropertyChanged("Title");
			}
		}
	}

	public string DocumentTitle
	{
		get
		{
			return r9LLanCGMru;
		}
		set
		{
			if (!(value == r9LLanCGMru))
			{
				r9LLanCGMru = value;
				OnPropertyChanged("DocumentTitle");
				OnPropertyChanged("ToolTip");
			}
		}
	}

	public ImageSource Icon
	{
		get
		{
			return xS4Lap8shKE;
		}
		set
		{
			if (!object.Equals(value, xS4Lap8shKE))
			{
				xS4Lap8shKE = value;
				OnPropertyChanged("Icon");
			}
		}
	}

	public WebView2 WebView
	{
		get
		{
			return WqKLaBoDoLK;
		}
		private set
		{
			if (!object.Equals(value, WqKLaBoDoLK))
			{
				WqKLaBoDoLK = value;
				OnPropertyChanged("WebView");
			}
		}
	}

	public string StartUrl
	{
		get
		{
			return sqeLaQI9eBy;
		}
		set
		{
			if (!(value == sqeLaQI9eBy))
			{
				sqeLaQI9eBy = value;
				OnPropertyChanged("StartUrl");
			}
		}
	}

	public string Source
	{
		get
		{
			return AsILajCglli;
		}
		set
		{
			if (!(value == AsILajCglli))
			{
				AsILajCglli = value;
				OnPropertyChanged("Source");
				OnPropertyChanged("ToolTip");
			}
		}
	}

	public string ToolTip => Source + "\r\n" + DocumentTitle;

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	public MultiTabWebViewItem(string title, string url, string icon = null, string profileName = null)
	{
		Title = title;
		HasPresetTitle = !string.IsNullOrEmpty(title) && !title.StartsWith("http", StringComparison.OrdinalIgnoreCase);
		ProfileName = profileName;
		StartUrl = url;
		if (!string.IsNullOrEmpty(icon))
		{
			Icon = AppHelper.GetImageSourceFromIconString(icon);
			HasPresetIcon = true;
		}
		else
		{
			LoadDefaultFavicon();
		}
		WebView = new WebView2();
		AeOLa67QCTC();
		WebView.CoreWebView2InitializationCompleted += Nb4LaGkjL8A;
		WebView.GotFocus += SOHLakcheW8;
		WebView.KeyDown += HUuLaWkLtw1;
	}

	[AsyncStateMachine(typeof(_003CWebViewOnKeyDown_003Ed__30))]
	private void HUuLaWkLtw1(object sender, KeyEventArgs e)
	{
		_003CWebViewOnKeyDown_003Ed__30 stateMachine = default(_003CWebViewOnKeyDown_003Ed__30);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.e = e;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	private void SOHLakcheW8(object sender, RoutedEventArgs e)
	{
		GotFocus?.Invoke(this, EventArgs.Empty);
	}

	public void ShutDown()
	{
		if (WebView == null)
		{
			return;
		}
		WebView2 webView = WebView;
		WebView = null;
		try
		{
			if (webView.CoreWebView2 != null)
			{
				webView.CoreWebView2.FaviconChanged -= JZmLa1R3X9v;
				int num = 0;
				if (p09yo2F01NnMfi7FEE7C != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				webView.CoreWebView2.DocumentTitleChanged -= Oq4Lab63ZY8;
				webView.CoreWebView2.SourceChanged -= LuiLaHwxS9Z;
				webView.CoreWebView2.HistoryChanged -= maLLasg8Z4P;
				webView.CoreWebView2InitializationCompleted -= Nb4LaGkjL8A;
				webView.GotFocus -= SOHLakcheW8;
				webView.Dispose();
			}
		}
		catch (Exception ex)
		{
			ptULaxoXLEv.Warn("释放WebView出错：" + ex.Message, ex);
		}
	}

	private void Nb4LaGkjL8A(object sender, CoreWebView2InitializationCompletedEventArgs e)
	{
		if (WebView.CoreWebView2 == null)
		{
			ptULaxoXLEv.Warn("WebView.CoreWebView2 为NULL");
			return;
		}
		if (WebView.CoreWebView2.Profile == null)
		{
			ptULaxoXLEv.Warn("WebView.CoreWebView2.Profile 为NULL");
		}
		else
		{
			WebView.CoreWebView2.Profile.PreferredColorScheme = CoreWebView2PreferredColorScheme.Dark;
			if (!string.IsNullOrEmpty(DefaultDownloadFolderPath))
			{
				int num = 0;
				if (!zv1tIpF0KWiiS3WUGdfh())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				WebView.CoreWebView2.Profile.DefaultDownloadFolderPath = DefaultDownloadFolderPath;
			}
		}
		if (!string.IsNullOrEmpty(UserAgent))
		{
			WebView.CoreWebView2.Settings.UserAgent = UserAgent;
		}
		if (!HasPresetIcon)
		{
			WebView.CoreWebView2.FaviconChanged += JZmLa1R3X9v;
		}
		WebView.CoreWebView2.DocumentTitleChanged += Oq4Lab63ZY8;
		WebView.CoreWebView2.SourceChanged += LuiLaHwxS9Z;
		WebView.CoreWebView2.HistoryChanged += maLLasg8Z4P;
		WebView.Source = new Uri(StartUrl);
	}

	private void maLLasg8Z4P(object object_0, object object_1)
	{
		HistoryChanged?.Invoke(this, EventArgs.Empty);
		CommandManager.InvalidateRequerySuggested();
	}

	private void LuiLaHwxS9Z(object sender, CoreWebView2SourceChangedEventArgs e)
	{
		Source = WebView.CoreWebView2.Source;
	}

	[AsyncStateMachine(typeof(_003CCoreWebView2_FaviconChanged_003Ed__56))]
	private void JZmLa1R3X9v(object object_0, object object_1)
	{
		_003CCoreWebView2_FaviconChanged_003Ed__56 stateMachine = default(_003CCoreWebView2_FaviconChanged_003Ed__56);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	public void LoadDefaultFavicon()
	{
		Icon = AppHelper.GetImageSourceFromIconString(AppHelper.GetUrlFavicon(StartUrl));
	}

	private void Oq4Lab63ZY8(object object_0, object object_1)
	{
		if (!HasPresetTitle)
		{
			Title = WebView.CoreWebView2.DocumentTitle;
		}
		DocumentTitle = WebView.CoreWebView2.DocumentTitle;
	}

	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		this.m_PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
	{
		if (EqualityComparer<T>.Default.Equals(field, value))
		{
			return false;
		}
		field = value;
		OnPropertyChanged(propertyName);
		return true;
	}

	[AsyncStateMachine(typeof(_003CInitializeWebViewAsync_003Ed__64))]
	private void AeOLa67QCTC()
	{
		_003CInitializeWebViewAsync_003Ed__64 stateMachine = default(_003CInitializeWebViewAsync_003Ed__64);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	static MultiTabWebViewItem()
	{
		ptULaxoXLEv = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool zv1tIpF0KWiiS3WUGdfh()
	{
		return p09yo2F01NnMfi7FEE7C == null;
	}
}
