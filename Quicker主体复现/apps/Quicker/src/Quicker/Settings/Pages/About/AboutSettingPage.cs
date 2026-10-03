using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using bpNbEZj0vTDod37Z02B;
using gqB4IvX4JlYCSBb9knj;
using Quicker.Common.Entities;
using Quicker.Common.Vm.Account;
using Quicker.Domain;
using Quicker.Utilities;
using Quicker.Utilities.Win32;

namespace Quicker.Settings.Pages.About;

public class AboutSettingPage : SettingPage, IComponentConnector
{
	internal Image ImgIcon;

	internal TextBlock LblVersion;

	internal TextBlock TxtEmail;

	internal TextBlock TxtNickName;

	internal TextBlock TxtRegTime;

	internal TextBlock LblLevel;

	internal TextBlock LblExpireTime;

	internal Button BtnShowLic;

	private bool qxD4YApfwe;

	private static AboutSettingPage BNnqegTIpfiaNthqugH;

	public override bool ShowSaveButton => false;

	public AboutSettingPage()
	{
		InitializeComponent();
	}

	protected override void LoadDataToUi(UserSettings settings)
	{
		hiU6uvXya1n871DUbUU hiU6uvXya1n871DUbUU = uT4WJujEfNmOl8aWJJC.k25tkYhXNMI();
		TxtEmail.Text = hiU6uvXya1n871DUbUU.Email;
		TxtNickName.Text = hiU6uvXya1n871DUbUU.w0WtBecmG8Q();
		TextBlock txtRegTime = TxtRegTime;
		DateTime? dateTime = hiU6uvXya1n871DUbUU.Lk4tBnVvI08();
		object text;
		DateTime value = default(DateTime);
		if (!dateTime.HasValue)
		{
			text = null;
		}
		else
		{
			value = dateTime.GetValueOrDefault().ToLocalTime();
			text = value.ToString("yyyy-MM-dd");
		}
		txtRegTime.Text = (string)text;
		LblLevel.Text = (AppState.DataService.Hb9tmk3OsJ7() ? "专业版" : "免费版");
		int num;
		if (AppState.DataService.i0Ut6GjHZAN())
		{
			LblExpireTime.Text = "- （腾讯管家软件订阅)";
		}
		else if (AppState.DataService.i5UtmeRR9vT() == MemberLevel.Pro)
		{
			dateTime = AppState.DataService.cROtmIgHSGI();
			num = 1;
			if (BNnqegTIpfiaNthqugH != null)
			{
				goto IL_00fe;
			}
			goto IL_0147;
		}
		goto IL_0258;
		IL_0147:
		while (true)
		{
			switch (num)
			{
			case 1:
				if (!dateTime.HasValue)
				{
					break;
				}
				if (AppState.DataService.cROtmIgHSGI() < DateTime.Now.AddYears(30))
				{
					goto IL_00de;
				}
				goto case 2;
			default:
				if (dateTime < value)
				{
					LblExpireTime.Text = $"专业版已过期 {(int)(DateTime.UtcNow - AppState.DataService.cROtmIgHSGI().Value).TotalDays} 天 ";
					LblExpireTime.Foreground = Brushes.Red;
				}
				else
				{
					LblExpireTime.Text = AppState.DataService.cROtmIgHSGI()?.ToLocalTime().ToString("yyyy-MM-dd") + $" (剩余{(int)(AppState.DataService.cROtmIgHSGI().Value - DateTime.UtcNow).TotalDays}天)";
				}
				break;
			case 2:
				LblExpireTime.Text = "长期";
				break;
			}
			break;
			IL_00de:
			dateTime = AppState.DataService.cROtmIgHSGI();
			value = DateTime.UtcNow;
			num = 0;
			if (hteKkuT6ttOQT1uXLdu())
			{
				continue;
			}
			goto IL_00fe;
		}
		goto IL_0258;
		IL_0258:
		LblVersion.Text = AppHelper.GetCurrAppShortVersion();
		return;
		IL_00fe:
		int num2 = default(int);
		num = num2;
		goto IL_0147;
	}

	protected override bool SaveDataFromUi(UserSettings settings)
	{
		return true;
	}

	private void l3u4hI7Nn7(object sender, RoutedEventArgs e)
	{
		string fileName = Path.Combine(NativeMethods.GetAppBasePath(), "ComponentLicenses.txt");
		try
		{
			Process.Start(fileName);
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("打开文件出错：" + ex.Message);
		}
	}

	private void Qxt4exq5TN(object sender, MouseButtonEventArgs e)
	{
		if (sender is TextBlock textBlock)
		{
			try
			{
				Clipboard.SetText(textBlock.Text);
				AppHelper.ShowSuccess("已复制: " + textBlock.Text);
			}
			catch (Exception ex)
			{
				AppHelper.ShowWarning("复制出错：" + ex.Message + "\r\n请重试。");
			}
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!qxD4YApfwe)
		{
			qxD4YApfwe = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/about/aboutsettingpage.xaml", UriKind.Relative);
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
		switch (connectionId)
		{
		case 1:
			ImgIcon = (Image)target;
			return;
		case 2:
			LblVersion = (TextBlock)target;
			return;
		case 3:
			TxtEmail = (TextBlock)target;
			TxtEmail.PreviewMouseLeftButtonDown += Qxt4exq5TN;
			return;
		case 4:
			TxtNickName = (TextBlock)target;
			TxtNickName.PreviewMouseLeftButtonDown += Qxt4exq5TN;
			return;
		case 5:
			TxtRegTime = (TextBlock)target;
			return;
		case 6:
			LblLevel = (TextBlock)target;
			return;
		case 7:
			LblExpireTime = (TextBlock)target;
			return;
		case 8:
			BtnShowLic = (Button)target;
			BtnShowLic.Click += l3u4hI7Nn7;
			return;
		}
		qxD4YApfwe = true;
		if (BNnqegTIpfiaNthqugH != null)
		{
			switch (0)
			{
			}
		}
	}

	internal static bool hteKkuT6ttOQT1uXLdu()
	{
		return BNnqegTIpfiaNthqugH == null;
	}
}
