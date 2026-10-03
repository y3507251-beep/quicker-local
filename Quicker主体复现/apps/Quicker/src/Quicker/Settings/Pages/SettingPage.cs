using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Newtonsoft.Json;
using Quicker.Common.Entities;
using Quicker.Domain;
using Quicker.Domain.Messages;
using Quicker.Utilities;

namespace Quicker.Settings.Pages;

public abstract class SettingPage : UserControl
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass12_0
	{
		public bool FCcvVxKYUWW;

		public SettingPage nHZvVrbvEIm;

		private static _003C_003Ec__DisplayClass12_0 U2bbq5c904q2iKksBRsP;

		internal void lS1vVKIcPf4()
		{
			if (FCcvVxKYUWW)
			{
				AppState.DataService.ydot6rVZAkW();
			}
			nHZvVrbvEIm.ApplySettings();
		}

		internal static bool BwG4Kpc91OL8iuTV1CfV()
		{
			return U2bbq5c904q2iKksBRsP == null;
		}
	}

	private bool FJqnx8hwc8;

	private string aw6nrNqyNS = string.Empty;

	[CompilerGenerated]
	private readonly bool h1bnpXha5m = true;

	private static SettingPage E1mu0PwhuyrKrohYGCY;

	protected bool IsDataLoaded => FJqnx8hwc8;

	public virtual bool ShowSaveButton
	{
		[CompilerGenerated]
		get
		{
			return h1bnpXha5m;
		}
	}

	protected SettingsWindow2 ParentWindow => (SettingsWindow2)Window.GetWindow(this);

	protected override void OnInitialized(EventArgs e)
	{
		base.OnInitialized(e);
		base.Loaded += WE9nK9Uyah;
	}

	private void WE9nK9Uyah(object sender, RoutedEventArgs e)
	{
		aw6nrNqyNS = JsonConvert.SerializeObject(AppState.HHxtaMaoqJr());
		LoadDataToUi(AppState.HHxtaMaoqJr());
		FJqnx8hwc8 = true;
	}

	public void RestoreData()
	{
		if (string.IsNullOrEmpty(aw6nrNqyNS))
		{
			AppHelper.ShowWarning("数据为空！");
			return;
		}
		UserSettings settings = JsonConvert.DeserializeObject<UserSettings>(aw6nrNqyNS);
		LoadDataToUi(settings);
		SaveData();
	}

	protected abstract void LoadDataToUi(UserSettings settings);

	protected abstract bool SaveDataFromUi(UserSettings settings);

	public (bool isSuccess, bool changedSinceLoad) SaveData()
	{
		_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
		_003C_003Ec__DisplayClass12_.nHZvVrbvEIm = this;
		try
		{
			if (!SaveDataFromUi(AppState.HHxtaMaoqJr()))
			{
				return (isSuccess: false, changedSinceLoad: false);
			}
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("保存设置失败，请重试！如果持续出现，请联系我们获得支持。\r\n错误信息：" + ex.Message, true);
			return (isSuccess: false, changedSinceLoad: false);
		}
		string a = JsonConvert.SerializeObject(AppState.HHxtaMaoqJr());
		_003C_003Ec__DisplayClass12_.FCcvVxKYUWW = !string.Equals(a, aw6nrNqyNS, StringComparison.Ordinal);
		Task.Run((Action)_003C_003Ec__DisplayClass12_.lS1vVKIcPf4);
		return (isSuccess: true, changedSinceLoad: _003C_003Ec__DisplayClass12_.FCcvVxKYUWW);
	}

	protected virtual void ApplySettings()
	{
		AppState.Y2RtaqSv0AQ().NotifyUserSettingsChange(this);
	}

	public virtual bool OnUnloading()
	{
		return SaveData().isSuccess;
	}

	internal static bool iAbeWuwHU3cHQhc6sdE()
	{
		return E1mu0PwhuyrKrohYGCY == null;
	}
}
