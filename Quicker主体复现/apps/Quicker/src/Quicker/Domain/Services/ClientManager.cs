using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using log4net;
using NAudio.CoreAudioApi;
using Quicker.Common;
using Quicker.Domain.Actions.Runtime;
using Quicker.Domain.Extensions;
using Quicker.Domain.Interfaces;
using Quicker.Domain.Messages;
using Quicker.Domain.Network;
using Quicker.Domain.Network.Messages;
using Quicker.Domain.Network.Messages.Recv;
using Quicker.Domain.Network.Messages.Send;
using Quicker.Domain.Profiles;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Win32;
using WindowsInput;
using WindowsInput.Native;

namespace Quicker.Domain.Services;

public class ClientManager : IDisposable, IMessageProcessor
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec EY6vTTAVtUI;

		public static Func<StateObject, bool> mNKvTMahxvT;

		internal static _003C_003Ec uaaeiuWp7UEg6mQCfptk;

		static _003C_003Ec()
		{
			EY6vTTAVtUI = new _003C_003Ec();
		}

		internal bool icKvToEIHiC(StateObject x)
		{
			return x.IsLoggedIn;
		}

		internal static bool riNhQjWp46Ao3D1omBtY()
		{
			return uaaeiuWp7UEg6mQCfptk == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass13_0
	{
		public ClientManager RIhvTOCCCBF;

		public PanelUpdateMessage d98vTF3Nhns;

		internal static _003C_003Ec__DisplayClass13_0 yCk6MvWpHdpu2OBRTtXT;

		internal void LjRvTAstvwp()
		{
			RIhvTOCCCBF.jqetQmOVOIA(d98vTF3Nhns.UpdateGlobal, d98vTF3Nhns.UpdateContext, Array.Empty<int>());
		}

		internal static bool rSVHruWpzU0qbIXWgFsg()
		{
			return yCk6MvWpHdpu2OBRTtXT == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass16_0
	{
		public ClientManager sxovTlkNgip;

		public PhotoMessage O6yvTistG4U;

		private static _003C_003Ec__DisplayClass16_0 ThvgWrWXQY7dLZ3KF7ru;

		internal void sREvTUrD3wC()
		{
			sxovTlkNgip.O5HtQGKE8Gn(O6yvTistG4U);
		}

		internal static bool aUj0ImWXFcXn8uG2w0dn()
		{
			return ThvgWrWXQY7dLZ3KF7ru == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass32_0
	{
		public ClientManager PnMvTf8WMxE;

		public UpdateButtonsMessage KyNvTzckik5;

		private static _003C_003Ec__DisplayClass32_0 HdkJicWXWxJdRxxSNKF6;

		internal void qWLvT3IA2qR(int btnIndex)
		{
			ButtonItem buttonItem = new ButtonItem
			{
				Index = btnIndex
			};
			ActionItem action = PnMvTf8WMxE.UlutQpZ01JG.GetAction(btnIndex);
			nBStQKie4eP(buttonItem, action);
			KyNvTzckik5.Buttons.Add(buttonItem);
		}

		internal static bool rJ0g4QWXy8lpTTCIllXH()
		{
			return HdkJicWXWxJdRxxSNKF6 == null;
		}
	}

	private static readonly ILog ALFtQx2A40s;

	private readonly ITinyMessengerHub coktQrewvWN;

	private readonly PanelState UlutQpZ01JG;

	private readonly DataService lFAtQBMSmP0;

	private readonly UsageCounter mVatQQiklRU;

	private readonly ConcurrentDictionary<StateObject, StateObject> ndDtQjnAFg0 = new ConcurrentDictionary<StateObject, StateObject>();

	private Socket SC2tQnitNMZ;

	private bool Q0mtQ4dyuYc;

	private MMDevice sKUtQ5gAF5R;

	private int pKOtQDatcrQ;

	internal static ClientManager QmbEnyQLeADV9k5t7Ap5;

	public ClientManager(ITinyMessengerHub hub, PanelState panelState, DataService dataService, UsageCounter usageCounter)
	{
		coktQrewvWN = hub;
		UlutQpZ01JG = panelState;
		lFAtQBMSmP0 = dataService;
		mVatQQiklRU = usageCounter;
		coktQrewvWN.Subscribe<PanelUpdateMessage>(epntQkJNjgw);
		coktQrewvWN.Subscribe<UserSettingsChangedMessage>(wD8tQW4hEO1);
		coktQrewvWN.Subscribe<AppCommandMessage>(LXrtQIMWy3R);
		coktQrewvWN.Subscribe<StateChangedMessage>(KJjtQYLqXUu);
	}

	private void KJjtQYLqXUu(StateChangedMessage stateChangedMessage_0)
	{
		if (stateChangedMessage_0.StateType == ChangedStateType.LockPanel)
		{
			jqetQmOVOIA(false, false, Array.Empty<int>());
		}
	}

	private void LXrtQIMWy3R(AppCommandMessage appCommandMessage_0)
	{
		if (appCommandMessage_0.Command == AppCommand.StartVoiceInput)
		{
			StartVoiceInput();
		}
		else
		{
			AppHelper.ShowWarning("不支持的命令：" + appCommandMessage_0.Command);
		}
	}

	private void wD8tQW4hEO1(UserSettingsChangedMessage userSettingsChangedMessage_0)
	{
		if (AppState.HHxtaMaoqJr().IsAppEnabled)
		{
			if (!Q0mtQ4dyuYc)
			{
				StartListening();
			}
			else if (AppState.HHxtaMaoqJr().Port != pKOtQDatcrQ)
			{
				StartListening();
			}
		}
		else if (Q0mtQ4dyuYc)
		{
			ShutDown();
		}
	}

	private void epntQkJNjgw(PanelUpdateMessage panelUpdateMessage_0)
	{
		_003C_003Ec__DisplayClass13_0 _003C_003Ec__DisplayClass13_ = new _003C_003Ec__DisplayClass13_0();
		_003C_003Ec__DisplayClass13_.RIhvTOCCCBF = this;
		_003C_003Ec__DisplayClass13_.d98vTF3Nhns = panelUpdateMessage_0;
		if (ndDtQjnAFg0.HasData())
		{
			Task.Run((Action)_003C_003Ec__DisplayClass13_.LjRvTAstvwp);
		}
	}

	public void StartListening()
	{
		try
		{
			ShutDown();
			if (x9pB5YQLjDpdWPalkqCp())
			{
				switch (0)
				{
				}
			}
			if (!lFAtQBMSmP0.CpItmVISR7P().IsAppEnabled)
			{
				return;
			}
			pKOtQDatcrQ = lFAtQBMSmP0.CpItmVISR7P().Port;
			IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Any, lFAtQBMSmP0.CpItmVISR7P().Port);
			SC2tQnitNMZ = new Socket(iPEndPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
			NativeMethods.MakeNotInheritable(SC2tQnitNMZ);
			SC2tQnitNMZ.Bind(iPEndPoint);
			SC2tQnitNMZ.Listen(100);
			SC2tQnitNMZ.BeginAccept(AcceptCallback, SC2tQnitNMZ);
			Q0mtQ4dyuYc = true;
			try
			{
				MMDeviceEnumerator mMDeviceEnumerator = new MMDeviceEnumerator();
				sKUtQ5gAF5R = mMDeviceEnumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
				sKUtQ5gAF5R.AudioEndpointVolume.OnVolumeNotification += OActQb6pKJf;
			}
			catch (Exception)
			{
			}
		}
		catch (Exception ex2)
		{
			AppHelper.ShowWarning("开启APP网络服务端口失败。" + ex2.Message);
		}
	}

	public void ProcessMessage(MessageBase message, StateObject client)
	{
		_003C_003Ec__DisplayClass16_0 _003C_003Ec__DisplayClass16_ = new _003C_003Ec__DisplayClass16_0();
		_003C_003Ec__DisplayClass16_.sxovTlkNgip = this;
		mVatQQiklRU.CountMobileMessage(message.MessageType);
		int num;
		UpdateVolumeMessage updateVolumeMessage = default(UpdateVolumeMessage);
		if (client != null && !client.IsLoggedIn && !(message is DeviceLoginMessage))
		{
			num = 0;
			if (!x9pB5YQLjDpdWPalkqCp())
			{
				int num2 = default(int);
				num = num2;
			}
		}
		else
		{
			if (message is ButtonClickedMessage buttonClickedMessage)
			{
				coktQrewvWN.NotifyButtonClick(this, buttonClickedMessage.ButtonIndex, null, ActionTrigger.App, false);
				return;
			}
			if (message is ToggleMuteMessage)
			{
				goto IL_017a;
			}
			updateVolumeMessage = message as UpdateVolumeMessage;
			if (updateVolumeMessage == null)
			{
				if (!(message is TextDataMessage textDataMessage))
				{
					if (!(message is CommandMessage commandMessage_))
					{
						if (!(message is DeviceLoginMessage deviceLoginMessage_))
						{
							_003C_003Ec__DisplayClass16_.O6yvTistG4U = message as PhotoMessage;
							if (_003C_003Ec__DisplayClass16_.O6yvTistG4U != null)
							{
								Task.Run((Action)_003C_003Ec__DisplayClass16_.sREvTUrD3wC);
							}
						}
						else
						{
							dHntQsHRi1t(deviceLoginMessage_, client);
						}
					}
					else
					{
						ncVtQHxpcqB(commandMessage_);
					}
					return;
				}
				try
				{
					InputSimulator.Instance.Keyboard.TextEntry(textDataMessage.Data);
					return;
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("发送文本失败了。" + ex.Message);
					return;
				}
			}
			num = 1;
			if (x9pB5YQLjDpdWPalkqCp())
			{
				goto IL_014f;
			}
		}
		switch (num)
		{
		default:
		{
			LoginStateMessage msg = new LoginStateMessage
			{
				IsLoggedIn = false
			};
			SendToClient(msg, client);
			return;
		}
		case 1:
			break;
		case 2:
			goto IL_017a;
		}
		goto IL_014f;
		IL_017a:
		try
		{
			FXFtQ6UcPhU();
			return;
		}
		catch (Exception ex2)
		{
			AppHelper.ShowWarning("切换静音失败了。" + ex2.Message);
			return;
		}
		IL_014f:
		try
		{
			g7KtQXNSdGp(updateVolumeMessage.MasterVolume);
		}
		catch (Exception ex3)
		{
			AppHelper.ShowWarning("调整音量失败了。" + ex3.Message);
		}
	}

	private void O5HtQGKE8Gn(PhotoMessage photoMessage_0)
	{
		byte[] buffer = Convert.FromBase64String(photoMessage_0.Data);
		string text = "";
		using (MemoryStream stream = new MemoryStream(buffer))
		{
			using Image image = Image.FromStream(stream);
			if (lFAtQBMSmP0.CpItmVISR7P().RecvImageCopyToClipboard || lFAtQBMSmP0.CpItmVISR7P().RecvImagePasteToWindow)
			{
				ClipboardHelper.SetImage(image);
			}
			string text2 = AppHelper.GetUserDataDir("Upload");
			if (!string.IsNullOrEmpty(lFAtQBMSmP0.CpItmVISR7P().RecvFileFolder))
			{
				text2 = lFAtQBMSmP0.CpItmVISR7P().RecvFileFolder;
				if (text2.Contains("%"))
				{
					text2 = Environment.ExpandEnvironmentVariables(text2);
				}
			}
			if (!Directory.Exists(text2))
			{
				Directory.CreateDirectory(text2);
			}
			string text3 = photoMessage_0.FileName;
			int num = 0;
			if (!x9pB5YQLjDpdWPalkqCp())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				if (text3.Length < 10)
				{
					text3 = Path.GetFileNameWithoutExtension(text3) + "_" + DateTime.Now.ToString("yyyyMMddHHmmss", CultureInfo.InvariantCulture) + Path.GetExtension(text3);
				}
				text = Path.Combine(text2, text3);
				try
				{
					using FileStream stream2 = new FileStream(text, FileMode.Create);
					image.Save(stream2, ImageFormat.Png);
				}
				catch (Exception ex)
				{
					MessageBoxHelper.Show("无法保存图片," + ex.Message, "Quicker", MessageBoxButton.OK, MessageBoxImage.Exclamation);
					return;
				}
				break;
			}
		}
		try
		{
			if (lFAtQBMSmP0.CpItmVISR7P().RecvImagePasteToWindow)
			{
				Thread.Sleep(100);
				InputSimulator.Instance.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_V, AppHelper.kPoLTdWFLA7());
			}
			if (!string.IsNullOrEmpty(lFAtQBMSmP0.CpItmVISR7P().RecvImageOpenWithProgram))
			{
				try
				{
					Process.Start(lFAtQBMSmP0.CpItmVISR7P().RecvImageOpenWithProgram, text);
				}
				catch (Exception ex2)
				{
					AppHelper.ShowWarning("无法使用指定的程序打开图片。路径：" + lFAtQBMSmP0.CpItmVISR7P()?.ToString() + " " + ex2.Message);
				}
			}
			if (lFAtQBMSmP0.CpItmVISR7P().RecvImageOpenWithDefaultProgram)
			{
				Process.Start(text);
			}
			if (lFAtQBMSmP0.CpItmVISR7P().RecvImageOpenFolder)
			{
				AppHelper.SelectFileInExplorer(text, true);
				int num3 = 0;
				if (QmbEnyQLeADV9k5t7Ap5 != null)
				{
					int num4 = default(int);
					num3 = num4;
				}
				switch (num3)
				{
				}
			}
		}
		catch (Exception ex3)
		{
			MessageBoxHelper.Show("Can not open file:" + text + " ex:" + ex3.Message, "Quicker", MessageBoxButton.OK, MessageBoxImage.Exclamation);
		}
	}

	private void dHntQsHRi1t(DeviceLoginMessage deviceLoginMessage_0, StateObject stateObject_0)
	{
		while (true)
		{
			if (string.IsNullOrEmpty(deviceLoginMessage_0.ConnectionCode))
			{
				if (QmbEnyQLeADV9k5t7Ap5 != null)
				{
					switch (0)
					{
					case 1:
						continue;
					}
				}
				if (string.IsNullOrEmpty(lFAtQBMSmP0.CpItmVISR7P().ConnectionCode))
				{
					goto IL_0063;
				}
			}
			if (!string.Equals(deviceLoginMessage_0.ConnectionCode, lFAtQBMSmP0.CpItmVISR7P().ConnectionCode, StringComparison.Ordinal))
			{
				break;
			}
			goto IL_0063;
			IL_0063:
			stateObject_0.IsLoggedIn = true;
			LoginStateMessage msg = new LoginStateMessage
			{
				IsLoggedIn = true,
				ErrorCode = 0
			};
			SendToClient(msg, stateObject_0);
			jqetQmOVOIA(true, true, null);
			SendVolumeState();
			CloseDuplicatedConnection(stateObject_0);
			return;
		}
		LoginStateMessage msg2 = new LoginStateMessage
		{
			IsLoggedIn = false,
			ErrorCode = 1,
			ErrorMessage = "错误的验证码"
		};
		SendToClient(msg2, stateObject_0);
	}

	private void ncVtQHxpcqB(CommandMessage commandMessage_0)
	{
		switch (commandMessage_0.Command)
		{
		case "RESEND_STATE":
			jqetQmOVOIA(true, true, null);
			SendVolumeState();
			break;
		case "CHANGE_PAGE":
			HP1tQ10dVWP(commandMessage_0.Data);
			break;
		case "LOCK_PANEL":
			coktQrewvWN.ToggleLockPanel(this);
			break;
		case "OPEN_MAINWIN":
			coktQrewvWN.NotifyRequestShowPanel(this);
			if (!x9pB5YQLjDpdWPalkqCp())
			{
				switch (0)
				{
				}
			}
			break;
		}
	}

	private void HP1tQ10dVWP(string string_0)
	{
		bool isGlobal = false;
		bool goLeft = false;
		switch (string_0)
		{
		default:
		{
			int num = 1;
			if (QmbEnyQLeADV9k5t7Ap5 != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			case 1:
				goto end_IL_0011;
			}
			goto case "DATA_GLOBAL_RIGHT";
		}
		case "DATA_GLOBAL_RIGHT":
			isGlobal = true;
			goLeft = false;
			break;
		case "DATA_CONTEXT_RIGHT":
			isGlobal = false;
			goLeft = false;
			break;
		case "DATA_CONTEXT_LEFT":
			isGlobal = false;
			goLeft = true;
			break;
		case "DATA_GLOBAL_LEFT":
			{
				isGlobal = true;
				goLeft = true;
				break;
			}
			end_IL_0011:
			break;
		}
		coktQrewvWN.RequestChangePage(this, isGlobal, goLeft);
	}

	public void ShutDown()
	{
		Q0mtQ4dyuYc = false;
		if (SC2tQnitNMZ != null)
		{
			try
			{
				SC2tQnitNMZ.Close();
				SC2tQnitNMZ = null;
			}
			catch (Exception)
			{
			}
		}
		if (ndDtQjnAFg0.Count > 0)
		{
			while (!ndDtQjnAFg0.IsEmpty)
			{
				KeyValuePair<StateObject, StateObject> keyValuePair = ndDtQjnAFg0.First();
				ndDtQjnAFg0.TryRemove(keyValuePair.Key, out var value);
				try
				{
					keyValuePair.Key.WorkSocket.Close();
				}
				catch (Exception)
				{
				}
			}
		}
		if (sKUtQ5gAF5R != null)
		{
			try
			{
				sKUtQ5gAF5R.AudioEndpointVolume.OnVolumeNotification -= OActQb6pKJf;
			}
			catch
			{
			}
		}
	}

	private void OActQb6pKJf(AudioVolumeNotificationData audioVolumeNotificationData_0)
	{
		SendVolumeState();
	}

	public void SendVolumeState()
	{
		VolumeStateMessage volumeStateMessage = new VolumeStateMessage();
		try
		{
			if (sKUtQ5gAF5R != null)
			{
				volumeStateMessage.Mute = sKUtQ5gAF5R.AudioEndpointVolume.Mute;
				volumeStateMessage.MasterVolume = Convert.ToInt32(100f * sKUtQ5gAF5R.AudioEndpointVolume.MasterVolumeLevelScalar);
			}
		}
		catch (Exception)
		{
			volumeStateMessage.Mute = true;
			volumeStateMessage.MasterVolume = 0;
		}
		SendToLogginedClients(volumeStateMessage);
	}

	private void FXFtQ6UcPhU()
	{
		if (sKUtQ5gAF5R != null)
		{
			try
			{
				sKUtQ5gAF5R.AudioEndpointVolume.Mute = !sKUtQ5gAF5R.AudioEndpointVolume.Mute;
			}
			catch (Exception)
			{
			}
		}
	}

	private void g7KtQXNSdGp(int int_1)
	{
		if (sKUtQ5gAF5R != null)
		{
			try
			{
				sKUtQ5gAF5R.AudioEndpointVolume.MasterVolumeLevelScalar = (float)int_1 / 100f;
			}
			catch (Exception)
			{
			}
		}
	}

	public void AcceptCallback(IAsyncResult ar)
	{
		Socket socket = (Socket)ar.AsyncState;
		if (!Q0mtQ4dyuYc)
		{
			return;
		}
		try
		{
			Socket socket2 = socket.EndAccept(ar);
			StateObject stateObject = new StateObject();
			stateObject.WorkSocket = socket2;
			stateObject.MessageProcessor = this;
			ndDtQjnAFg0[stateObject] = stateObject;
			socket2.BeginReceive(stateObject.recvBuffer, 0, StateObject.RecvBufferSize, SocketFlags.None, ReadCallback, stateObject);
			socket.BeginAccept(AcceptCallback, socket);
			coktQrewvWN.Publish(new AppConnectionMessage(this, true));
		}
		catch (Exception)
		{
		}
	}

	public void ReadCallback(IAsyncResult ar)
	{
		if (!Q0mtQ4dyuYc)
		{
			return;
		}
		StateObject stateObject = (StateObject)ar.AsyncState;
		Socket workSocket = stateObject.WorkSocket;
		try
		{
			int num = workSocket.EndReceive(ar);
			if (num > 0)
			{
				stateObject.ProcessData(num);
				workSocket.BeginReceive(stateObject.recvBuffer, 0, StateObject.RecvBufferSize, SocketFlags.None, ReadCallback, stateObject);
			}
			else
			{
				CloseClient(stateObject);
			}
		}
		catch (Exception)
		{
			CloseClient(stateObject);
		}
	}

	private void CloseClient(StateObject stateObj)
	{
		try
		{
			stateObj.WorkSocket.Close();
		}
		catch (Exception)
		{
		}
		try
		{
			if (ndDtQjnAFg0.ContainsKey(stateObj))
			{
				ndDtQjnAFg0.TryRemove(stateObj, out var value);
			}
		}
		catch (Exception)
		{
		}
		coktQrewvWN.Publish(new AppConnectionMessage(this, false));
	}

	public void SendToLogginedClients(MessageBase msg)
	{
		byte[] data = new NetPacket(msg).Build();
		foreach (StateObject key in ndDtQjnAFg0.Keys)
		{
			if (key != null && key.IsLoggedIn)
			{
				try
				{
					key.Send(data);
				}
				catch (Exception)
				{
				}
			}
		}
	}

	public void SendToClient(MessageBase msg, StateObject client)
	{
		try
		{
			NetPacket netPacket = new NetPacket(msg);
			client.Send(netPacket.Build());
		}
		catch (Exception ex)
		{
			ALFtQx2A40s.Warn("向APP发送数据异常。" + ex.Message, ex);
		}
	}

	public int GetClientCount()
	{
		return ndDtQjnAFg0.Keys.Count(_003C_003Ec.mNKvTMahxvT ?? (_003C_003Ec.mNKvTMahxvT = _003C_003Ec.EY6vTTAVtUI.icKvToEIHiC));
	}

	private void jqetQmOVOIA(bool bool_1, bool bool_2, IEnumerable<int> ienumerable_0)
	{
		_003C_003Ec__DisplayClass32_0 _003C_003Ec__DisplayClass32_ = new _003C_003Ec__DisplayClass32_0();
		_003C_003Ec__DisplayClass32_.PnMvTf8WMxE = this;
		_003C_003Ec__DisplayClass32_.KyNvTzckik5 = new UpdateButtonsMessage();
		_003C_003Ec__DisplayClass32_.KyNvTzckik5.Buttons = new List<ButtonItem>();
		_003C_003Ec__DisplayClass32_.KyNvTzckik5.ContextPageCount = UlutQpZ01JG.ContextProfileCount;
		_003C_003Ec__DisplayClass32_.KyNvTzckik5.ContextPageIndex = UlutQpZ01JG.ContextProfileIndex;
		_003C_003Ec__DisplayClass32_.KyNvTzckik5.GlobalPageCount = UlutQpZ01JG.GlobalProfileCount;
		_003C_003Ec__DisplayClass32_.KyNvTzckik5.GlobalPageIndex = UlutQpZ01JG.GlobalProfileIndex;
		_003C_003Ec__DisplayClass32_.KyNvTzckik5.IsContextPanelLocked = UlutQpZ01JG.LockContextPanel;
		_003C_003Ec__DisplayClass32_.KyNvTzckik5.ProfileName = UlutQpZ01JG.GetContextProfileName();
		AppHelper.ForEachButton(bool_1, bool_2, 4, _003C_003Ec__DisplayClass32_.qWLvT3IA2qR);
		if (ienumerable_0 != null)
		{
			foreach (int item in ienumerable_0)
			{
				ButtonItem buttonItem = new ButtonItem();
				buttonItem.Index = item;
				ActionItem action = UlutQpZ01JG.GetAction(item);
				nBStQKie4eP(buttonItem, action);
				_003C_003Ec__DisplayClass32_.KyNvTzckik5.Buttons.Add(buttonItem);
			}
		}
		SendToLogginedClients(_003C_003Ec__DisplayClass32_.KyNvTzckik5);
	}

	private static void nBStQKie4eP(ButtonItem buttonItem_0, ActionItem actionItem_0)
	{
		if (actionItem_0 != null)
		{
			buttonItem_0.Label = actionItem_0.Title;
			buttonItem_0.IsEnabled = actionItem_0.IsValid();
			if (string.IsNullOrEmpty(actionItem_0.Icon))
			{
				return;
			}
			if (actionItem_0.Icon.StartsWith("http", StringComparison.OrdinalIgnoreCase))
			{
				if (actionItem_0.Icon.StartsWith("http://", StringComparison.OrdinalIgnoreCase) && actionItem_0.Icon.Contains("aliyuncs"))
				{
					buttonItem_0.IconFileName = actionItem_0.Icon.Replace("http://", "https://");
					int num = 0;
					if (QmbEnyQLeADV9k5t7Ap5 != null)
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					}
				}
				else
				{
					buttonItem_0.IconFileName = actionItem_0.Icon;
				}
			}
			else if (File.Exists(actionItem_0.Icon))
			{
				string iconFileContent = Convert.ToBase64String(File.ReadAllBytes(actionItem_0.Icon));
				buttonItem_0.IconFileContent = iconFileContent;
			}
			else
			{
				buttonItem_0.IconFileName = actionItem_0.Icon;
			}
		}
		else
		{
			buttonItem_0.IsEnabled = false;
		}
	}

	public void CloseDuplicatedConnection(StateObject client)
	{
		try
		{
			IList<StateObject> list = new List<StateObject>();
			foreach (StateObject key in ndDtQjnAFg0.Keys)
			{
				if (client != key && key.WorkSocket != null && key.WorkSocket.Connected)
				{
					list.Add(key);
				}
			}
			foreach (StateObject item in list)
			{
				item.WorkSocket.Close();
			}
		}
		catch
		{
		}
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing)
		{
			SC2tQnitNMZ?.Dispose();
			SC2tQnitNMZ = null;
			if (sKUtQ5gAF5R != null)
			{
				sKUtQ5gAF5R.Dispose();
				sKUtQ5gAF5R = null;
			}
		}
	}

	public void Dispose()
	{
		Dispose(true);
		GC.SuppressFinalize(this);
	}

	public void StartVoiceInput()
	{
		CommandMessage msg = new CommandMessage
		{
			Command = "START_VOICE_INPUT"
		};
		SendToLogginedClients(msg);
	}

	static ClientManager()
	{
		ALFtQx2A40s = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool x9pB5YQLjDpdWPalkqCp()
	{
		return QmbEnyQLeADV9k5t7Ap5 == null;
	}
}
