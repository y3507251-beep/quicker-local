using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using System.Windows.Media;
using Quicker.Public.Extensions;
using Quicker.Utilities;

namespace Quicker.Settings.Pages.Basic;

public class ProxySettingsControl : UserControl, IComponentConnector
{
	[CompilerGenerated]
	private EventHandler m_ProxySettingsChanged;

	public ProxySetting ProxySettings;

	[CompilerGenerated]
	private bool yJvT2YKTEg;

	internal ToggleButton BtnToggle;

	internal Popup ThePopup;

	internal RadioButton BtnNoProxy;

	internal RadioButton BtnUseSystemProxy;

	internal RadioButton BtnUseCustomProxy;

	internal TextBox TxtServer;

	internal TextBox TxtUsername;

	internal PasswordBox TxtPwd;

	internal Button BtnOk;

	private bool d1ETuYgeth;

	internal static ProxySettingsControl pcW3fs7EislLYhUDVaC;

	public bool ForLogin
	{
		[CompilerGenerated]
		get
		{
			return yJvT2YKTEg;
		}
		[CompilerGenerated]
		set
		{
			yJvT2YKTEg = value;
		}
	}

	public event EventHandler ProxySettingsChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = this.m_ProxySettingsChanged;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_ProxySettingsChanged, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = this.m_ProxySettingsChanged;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref this.m_ProxySettingsChanged, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public ProxySettingsControl()
	{
		InitializeComponent();
	}

	public void SetData(ProxySetting proxySetting)
	{
		proxySetting = ((proxySetting != null) ? AppHelper.Clone(proxySetting) : new ProxySetting
		{
			Mode = ProxyMode.Disable
		});
		int num;
		switch (proxySetting.Mode)
		{
		case ProxyMode.Disable:
			BtnNoProxy.IsChecked = true;
			goto default;
		case ProxyMode.System:
			BtnUseSystemProxy.IsChecked = true;
			num = 0;
			if (!ywo4dF7GU4Rd1IbHCEt())
			{
				goto IL_013c;
			}
			goto default;
		case ProxyMode.Custom:
			BtnUseCustomProxy.IsChecked = true;
			goto default;
		default:
			{
				TxtServer.Text = proxySetting.Server;
				TxtUsername.Text = proxySetting.Username;
				TxtPwd.Password = proxySetting.Password;
				ProxySettings = proxySetting;
				kUcTvuYM9S();
				if (ForLogin)
				{
					BtnToggle.Padding = new Thickness(3.0, 0.0, 3.0, 0.0);
					BtnToggle.MaxHeight = 20.0;
					BtnToggle.Margin = new Thickness(0.0, 0.0, 0.0, 0.0);
					BtnToggle.BorderThickness = new Thickness(0.0);
					BtnToggle.Foreground = Brushes.DodgerBlue;
					num = 1;
					if (ywo4dF7GU4Rd1IbHCEt())
					{
						break;
					}
					goto IL_013c;
				}
				break;
			}
			IL_013c:
			switch (num)
			{
			case 1:
				return;
			}
			goto default;
		}
	}

	private void kUcTvuYM9S()
	{
		if (ProxySettings != null && !ForLogin)
		{
			BtnToggle.Content = "代理服务器设置：" + ProxySettings.Mode.GetEnumDisplayName();
		}
	}

	private void e4TTS9PdhP(object sender, RoutedEventArgs e)
	{
		ProxySettings = new ProxySetting
		{
			Server = TxtServer.Text,
			Username = TxtUsername.Text,
			Password = TxtPwd.Password
		};
		int num;
		if (BtnNoProxy.IsChecked == true)
		{
			ProxySettings.Mode = ProxyMode.Disable;
		}
		else if (BtnUseSystemProxy.IsChecked == true)
		{
			ProxySettings.Mode = ProxyMode.System;
		}
		else if (BtnUseCustomProxy.IsChecked == true)
		{
			ProxySettings.Mode = ProxyMode.Custom;
			if (string.IsNullOrEmpty(TxtServer.Text))
			{
				AppHelper.ShowWarning("请输入代理服务器地址！");
				return;
			}
			num = 0;
			if (pcW3fs7EislLYhUDVaC != null)
			{
				goto IL_00d8;
			}
		}
		goto IL_00e5;
		IL_00d8:
		switch (num)
		{
		case 1:
			kUcTvuYM9S();
			this.m_ProxySettingsChanged?.Invoke(this, EventArgs.Empty);
			return;
		}
		goto IL_00e5;
		IL_00e5:
		ThePopup.IsOpen = false;
		num = 1;
		if (!ywo4dF7GU4Rd1IbHCEt())
		{
			int num2 = default(int);
			num = num2;
		}
		goto IL_00d8;
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!d1ETuYgeth)
		{
			d1ETuYgeth = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/basic/proxysettingscontrol.xaml", UriKind.Relative);
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
		case 1:
			BtnToggle = (ToggleButton)target;
			return;
		case 2:
			ThePopup = (Popup)target;
			return;
		case 3:
			BtnNoProxy = (RadioButton)target;
			return;
		case 4:
			BtnUseSystemProxy = (RadioButton)target;
			return;
		case 5:
			BtnUseCustomProxy = (RadioButton)target;
			return;
		case 6:
			TxtServer = (TextBox)target;
			return;
		case 7:
			TxtUsername = (TextBox)target;
			return;
		case 8:
			TxtPwd = (PasswordBox)target;
			return;
		case 9:
			BtnOk = (Button)target;
			BtnOk.Click += e4TTS9PdhP;
			return;
		}
		d1ETuYgeth = true;
		int num = 0;
		if (!ywo4dF7GU4Rd1IbHCEt())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
	}

	internal static bool ywo4dF7GU4Rd1IbHCEt()
	{
		return pcW3fs7EislLYhUDVaC == null;
	}
}
