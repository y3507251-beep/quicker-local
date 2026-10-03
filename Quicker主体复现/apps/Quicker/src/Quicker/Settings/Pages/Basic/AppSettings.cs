using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using HandyControl.Controls;
using Microsoft.Win32;
using Quicker.Common.Entities;
using Quicker.Utilities;

namespace Quicker.Settings.Pages.Basic;

public class AppSettings : SettingPage, IComponentConnector
{
	internal ToggleButton ChkEnableWebsocketServer;

	internal NumericUpDown TxtWebsocketPort;

	internal System.Windows.Controls.TextBox TxtWebsocketPassword;

	internal CheckBox ChkEnableWebsocketSecureConnection;

	internal ToggleButton ChkEnableAppConnect;

	internal NumericUpDown TxtPort;

	internal System.Windows.Controls.TextBox TxtConnectionCode;

	internal CheckBox ToggleShowVoiceInputButton;

	internal CheckBox ChkCopyRecvImageToClipboard;

	internal CheckBox ChkOpenInExplorer;

	internal CheckBox ChkOpenImageUseDefaultProgram;

	internal CheckBox ChkPasteImage;

	internal System.Windows.Controls.TextBox TxtSavePath;

	internal Button BtnSelectSavePath;

	internal System.Windows.Controls.TextBox TxtImageOpener;

	internal Button BtnSelectImageOpener;

	private bool CcuTG8EX9i;

	internal static AppSettings akoij077E5nYOe87d4M;

	public AppSettings()
	{
		InitializeComponent();
	}

	protected override void LoadDataToUi(UserSettings settings)
	{
		ChkEnableAppConnect.IsChecked = settings.IsAppEnabled;
		TxtPort.Value = settings.Port;
		TxtConnectionCode.Text = settings.ConnectionCode;
		ToggleShowVoiceInputButton.IsChecked = settings.ShowVoiceInputButtonOnTitleBar;
		ChkCopyRecvImageToClipboard.IsChecked = settings.RecvImageCopyToClipboard;
		ChkOpenInExplorer.IsChecked = settings.RecvImageOpenFolder;
		ChkOpenImageUseDefaultProgram.IsChecked = settings.RecvImageOpenWithDefaultProgram;
		ChkPasteImage.IsChecked = settings.RecvImagePasteToWindow;
		if (akoij077E5nYOe87d4M != null)
		{
			switch (0)
			{
			}
		}
		TxtImageOpener.Text = settings.RecvImageOpenWithProgram;
		TxtSavePath.Text = settings.RecvFileFolder;
		WebsocketServerSettings websocketServerSettings = settings.WebsocketServerSettings ?? new WebsocketServerSettings();
		ChkEnableWebsocketServer.IsChecked = websocketServerSettings.IsEnabled;
		TxtWebsocketPassword.Text = websocketServerSettings.Password;
		TxtWebsocketPort.Value = websocketServerSettings.Port;
		ChkEnableWebsocketSecureConnection.IsChecked = websocketServerSettings.EnableSecure;
	}

	protected override bool SaveDataFromUi(UserSettings settings)
	{
		settings.IsAppEnabled = ChkEnableAppConnect.IsChecked == true;
		settings.Port = (int)TxtPort.Value;
		int num = 0;
		if (akoij077E5nYOe87d4M != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
		{
			settings.ConnectionCode = TxtConnectionCode.Text;
			settings.ShowVoiceInputButtonOnTitleBar = ToggleShowVoiceInputButton.IsChecked == true;
			settings.RecvImageCopyToClipboard = ChkCopyRecvImageToClipboard.IsChecked == true;
			settings.RecvImageOpenFolder = ChkOpenInExplorer.IsChecked == true;
			settings.RecvImageOpenWithDefaultProgram = ChkOpenImageUseDefaultProgram.IsChecked == true;
			settings.RecvImagePasteToWindow = ChkPasteImage.IsChecked == true;
			settings.RecvImageOpenWithProgram = TxtImageOpener.Text;
			settings.RecvFileFolder = TxtSavePath.Text;
			WebsocketServerSettings websocketServerSettings = new WebsocketServerSettings();
			websocketServerSettings.IsEnabled = ChkEnableWebsocketServer.IsChecked == true;
			websocketServerSettings.Password = TxtWebsocketPassword.Text;
			websocketServerSettings.Port = (int)TxtWebsocketPort.Value;
			websocketServerSettings.EnableSecure = ChkEnableWebsocketSecureConnection.IsChecked == true;
			settings.WebsocketServerSettings = websocketServerSettings;
			return true;
		}
		}
	}

	private void O6RTWQknsN(object sender, RoutedEventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.DefaultExt = ".exe";
		openFileDialog.Filter = "exe文件|*.exe";
		if (openFileDialog.ShowDialog(System.Windows.Window.GetWindow(this)) == true)
		{
			TxtImageOpener.Text = openFileDialog.FileName;
		}
	}

	private void m6DTkevDsI(object sender, RoutedEventArgs e)
	{
		(bool, string) tuple = AppHelper.ShowSelectFolderDialog(TxtSavePath.Text, "请选择图片的保存路径");
		if (tuple.Item1)
		{
			TxtSavePath.Text = tuple.Item2;
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!CcuTG8EX9i)
		{
			CcuTG8EX9i = true;
			Uri resourceLocator = new Uri("/Quicker;component/settings/pages/basic/appsettings.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num;
		switch (connectionId)
		{
		default:
			CcuTG8EX9i = true;
			break;
		case 1:
			ChkEnableWebsocketServer = (ToggleButton)target;
			break;
		case 2:
			TxtWebsocketPort = (NumericUpDown)target;
			break;
		case 3:
			TxtWebsocketPassword = (System.Windows.Controls.TextBox)target;
			num = 1;
			if (akoij077E5nYOe87d4M != null)
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_00ff;
		case 4:
			ChkEnableWebsocketSecureConnection = (CheckBox)target;
			break;
		case 5:
			ChkEnableAppConnect = (ToggleButton)target;
			break;
		case 6:
			TxtPort = (NumericUpDown)target;
			break;
		case 7:
			TxtConnectionCode = (System.Windows.Controls.TextBox)target;
			break;
		case 8:
			ToggleShowVoiceInputButton = (CheckBox)target;
			break;
		case 9:
			ChkCopyRecvImageToClipboard = (CheckBox)target;
			break;
		case 10:
			ChkOpenInExplorer = (CheckBox)target;
			break;
		case 11:
			ChkOpenImageUseDefaultProgram = (CheckBox)target;
			num = 0;
			if (akoij077E5nYOe87d4M == null)
			{
				break;
			}
			goto IL_00ff;
		case 12:
			ChkPasteImage = (CheckBox)target;
			break;
		case 13:
			TxtSavePath = (System.Windows.Controls.TextBox)target;
			break;
		case 14:
			BtnSelectSavePath = (Button)target;
			BtnSelectSavePath.Click += m6DTkevDsI;
			break;
		case 15:
			TxtImageOpener = (System.Windows.Controls.TextBox)target;
			break;
		case 16:
			{
				BtnSelectImageOpener = (Button)target;
				BtnSelectImageOpener.Click += O6RTWQknsN;
				break;
			}
			IL_00ff:
			switch (num)
			{
			case 1:
				break;
			}
			break;
		}
	}

	internal static bool qvu2Tb74NnCt7nIvPde()
	{
		return akoij077E5nYOe87d4M == null;
	}
}
