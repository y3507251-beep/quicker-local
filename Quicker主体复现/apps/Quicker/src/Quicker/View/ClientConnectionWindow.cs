using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using dkbgyyMixGueocCf9RC;
using log4net;
using QRCoder;
using Quicker.Domain;
using Quicker.Utilities;

namespace Quicker.View;

public class ClientConnectionWindow : Window, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec FtvSrv562nl;

		public static Func<string, SimpleOperationItem> Wm9SrSqhgpc;

		public static Func<string, SimpleOperationItem> IZ9Sr2YQyYs;

		internal static _003C_003Ec pJKey7WgZSc8avBDoKs3;

		static _003C_003Ec()
		{
			FtvSrv562nl = new _003C_003Ec();
		}

		internal SimpleOperationItem SyKSrgQJZs3(string x)
		{
			return new SimpleOperationItem
			{
				Data = x,
				Name = x,
				Icon = null,
				Description = null,
				Key = x
			};
		}

		internal SimpleOperationItem xIoSrL4h7yx(string x)
		{
			return new SimpleOperationItem
			{
				Data = x,
				Name = x,
				Icon = null,
				Description = null,
				Key = x
			};
		}

		internal static bool NGay3WWg5J5PLrrnOk12()
		{
			return pJKey7WgZSc8avBDoKs3 == null;
		}
	}

	private static readonly ILog e0UglkXZIL3;

	internal Label LblIp;

	internal Button BtnChange;

	internal Label LblPort;

	internal Label LblCode;

	internal System.Windows.Controls.Image ImgQrcode;

	private bool eabglGo8Ra5;

	internal static ClientConnectionWindow K6K3IBFyljQL6o9RRZRO;

	public ClientConnectionWindow()
	{
		InitializeComponent();
		base.Loaded += EN7gle6DA8K;
	}

	private void EN7gle6DA8K(object sender, RoutedEventArgs e)
	{
		UyhglYAvxeE();
	}

	private void UyhglYAvxeE()
	{
		int num = 1;
		int num4 = default(int);
		while (true)
		{
			IList<string> ipList = AppHelper.GetIpList();
			int num2 = 0;
			if (!mkXixNFyZn8dpW6wIg0r())
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			if (ipList.Count < 0)
			{
				MessageBoxHelper.Show(this, "无法获得您的电脑IP！", "Quicker", MessageBoxButton.OK, MessageBoxImage.Exclamation);
				return;
			}
			if (ipList.Count == 1)
			{
				string string_ = ipList[0];
				AO7eLUM7kJyEdiOQu2O.cSxLMPuIDlk("");
				S7jglI2RQFg(string_);
				return;
			}
			if (!string.IsNullOrEmpty(AO7eLUM7kJyEdiOQu2O.v6XLMCkb4SD()) && ipList.Contains(AO7eLUM7kJyEdiOQu2O.v6XLMCkb4SD()))
			{
				string string_ = AO7eLUM7kJyEdiOQu2O.v6XLMCkb4SD();
				BtnChange.Visibility = Visibility.Visible;
				S7jglI2RQFg(string_);
				return;
			}
			List<SimpleOperationItem> operations = ipList.Select(_003C_003Ec.Wm9SrSqhgpc ?? (_003C_003Ec.Wm9SrSqhgpc = _003C_003Ec.FtvSrv562nl.SyKSrgQJZs3)).ToList();
			try
			{
				SelectOperationWindow selectOperationWindow = new SelectOperationWindow(operations);
				selectOperationWindow.Owner = this;
				selectOperationWindow.Title = "请选择与手机在同一个局域网的IP地址";
				if (selectOperationWindow.ShowDialog() == true)
				{
					int num3 = 0;
					if (K6K3IBFyljQL6o9RRZRO != null)
					{
						num3 = num4;
					}
					switch (num3)
					{
					}
					string string_ = selectOperationWindow.SelectedItem.Data as string;
					AO7eLUM7kJyEdiOQu2O.cSxLMPuIDlk(string_);
					S7jglI2RQFg(string_);
				}
				else
				{
					Close();
				}
				return;
			}
			catch (Exception ex)
			{
				e0UglkXZIL3.Warn("显示IP选择窗口出现异常", ex);
				AppHelper.ShowWarning("显示IP选择窗口出现异常，请重试！" + ex.Message);
				return;
			}
		}
	}

	private void S7jglI2RQFg(string string_0)
	{
		LblIp.Content = "IP: " + string_0;
		LblPort.Content = "Port: " + AppState.DataService.CpItmVISR7P().Port;
		LblCode.Content = "验证码：" + AppState.DataService.CpItmVISR7P().ConnectionCode;
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(string_0);
		stringBuilder.Append('\n');
		int num = 0;
		if (K6K3IBFyljQL6o9RRZRO != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		stringBuilder.Append(AppState.DataService.CpItmVISR7P().Port);
		stringBuilder.Append('\n');
		stringBuilder.Append(AppState.DataService.CpItmVISR7P().ConnectionCode);
		Bitmap graphic = new QRCode(new QRCodeGenerator().CreateQrCode("PB:\n" + stringBuilder, QRCodeGenerator.ECCLevel.Q)).GetGraphic(4);
		ImgQrcode.Source = IconHelper.BitmapToImageSource(graphic);
	}

	private void YMRglW2ocKN(object sender, RoutedEventArgs e)
	{
		List<SimpleOperationItem> operations = AppHelper.GetIpList().Select(_003C_003Ec.IZ9Sr2YQyYs ?? (_003C_003Ec.IZ9Sr2YQyYs = _003C_003Ec.FtvSrv562nl.xIoSrL4h7yx)).ToList();
		try
		{
			SelectOperationWindow selectOperationWindow = new SelectOperationWindow(operations);
			selectOperationWindow.Owner = this;
			if (selectOperationWindow.ShowDialog() == true)
			{
				string string_ = selectOperationWindow.SelectedItem.Data as string;
				AO7eLUM7kJyEdiOQu2O.cSxLMPuIDlk(string_);
				S7jglI2RQFg(string_);
			}
		}
		catch (Exception ex)
		{
			e0UglkXZIL3.Warn("显示IP选择窗口出现异常", ex);
			AppHelper.ShowWarning("显示IP选择窗口出现异常，请重试！" + ex.Message);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!eabglGo8Ra5)
		{
			eabglGo8Ra5 = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/settings/clientconnectionwindow.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		default:
			eabglGo8Ra5 = true;
			break;
		case 1:
			LblIp = (Label)target;
			break;
		case 2:
			BtnChange = (Button)target;
			BtnChange.Click += YMRglW2ocKN;
			break;
		case 3:
			LblPort = (Label)target;
			break;
		case 4:
			LblCode = (Label)target;
			break;
		case 5:
		{
			ImgQrcode = (System.Windows.Controls.Image)target;
			int num = 0;
			if (!mkXixNFyZn8dpW6wIg0r())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			break;
		}
		}
	}

	static ClientConnectionWindow()
	{
		e0UglkXZIL3 = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool mkXixNFyZn8dpW6wIg0r()
	{
		return K6K3IBFyljQL6o9RRZRO == null;
	}
}
