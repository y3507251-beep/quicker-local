using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using log4net;
using Newtonsoft.Json;
using Quicker.Domain;
using Quicker.Domain.Services;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Tx7JHl2LkU52UwokyCJ;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace KpANinXqsG5PcsPtVpF;

internal class PKhsW5Xlli2epa94ZyO : WebSocketBehavior
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass18_0
	{
		public string N7rvjgI9sGK;

		private static _003C_003Ec__DisplayClass18_0 O7DJ3RcsUv8qF4txBlkF;

		internal void ic0vjtGwgKy()
		{
			AppHelper.SelectFileInExplorer(N7rvjgI9sGK, true);
		}

		internal static bool RlBqnMcsxnI6mis4uPUk()
		{
			return O7DJ3RcsUv8qF4txBlkF == null;
		}
	}

	private static readonly ILog ONNtsByxWOq;

	[CompilerGenerated]
	private string Bo4tsQ6wBy6;

	[CompilerGenerated]
	private string ofxtsjiqa2B;

	[CompilerGenerated]
	private int T3ytsnM7Afo;

	[CompilerGenerated]
	private bool z3Rts4eO7ro;

	internal static PKhsW5Xlli2epa94ZyO yu1gNPQaVMnc691ucSuQ;

	[SpecialName]
	[CompilerGenerated]
	internal string xh8tsGLIODv()
	{
		return Bo4tsQ6wBy6;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void Rlgtss2BLYU(string string_2)
	{
		Bo4tsQ6wBy6 = string_2;
	}

	[SpecialName]
	[CompilerGenerated]
	internal string SSYts150vHE()
	{
		return ofxtsjiqa2B;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void wgstsbfMrQ5(string string_2)
	{
		ofxtsjiqa2B = string_2;
	}

	[SpecialName]
	[CompilerGenerated]
	internal int TnbtsXiYanp()
	{
		return T3ytsnM7Afo;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void NgYtsmVn0Hx(int int_1)
	{
		T3ytsnM7Afo = int_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool N8XtsxJwQjk()
	{
		return z3Rts4eO7ro;
	}

	[SpecialName]
	[CompilerGenerated]
	public void RQAtsrWeajA(bool bool_1)
	{
		z3Rts4eO7ro = bool_1;
	}

	public PKhsW5Xlli2epa94ZyO()
	{
		base.IgnoreExtensions = true;
	}

	protected override void OnMessage(MessageEventArgs messageEventArgs_0)
	{
		int num = 2;
		_003C_003Ec__DisplayClass18_0 _003C_003Ec__DisplayClass18_ = default(_003C_003Ec__DisplayClass18_0);
		while (true)
		{
			int num2;
			if (messageEventArgs_0.IsText)
			{
				num2 = 1;
				if (!QCxEM8QaQDEJAqOiOqO5())
				{
					goto IL_0018;
				}
				goto IL_003a;
			}
			if (!messageEventArgs_0.IsBinary)
			{
				break;
			}
			if (!string.IsNullOrEmpty(SSYts150vHE()))
			{
				_003C_003Ec__DisplayClass18_ = new _003C_003Ec__DisplayClass18_0();
				if (messageEventArgs_0.RawData == null)
				{
					CSmtse70iaQ(TnbtsXiYanp(), false, "RawData为空");
					return;
				}
				_003C_003Ec__DisplayClass18_.N7rvjgI9sGK = QFYtsheNBm2(SSYts150vHE());
				File.WriteAllBytes(_003C_003Ec__DisplayClass18_.N7rvjgI9sGK, messageEventArgs_0.RawData);
				if (!(xh8tsGLIODv() == "PASTEIMAGE"))
				{
					goto IL_01d8;
				}
				ImageClipboardHelper.SetImageFromFile(_003C_003Ec__DisplayClass18_.N7rvjgI9sGK);
				AppHelper.SendPasteKeys();
				goto IL_020a;
			}
			ONNtsByxWOq.Warn("WebSocket：收到文件，但是没有文件名，所以无法保存。");
			CSmtse70iaQ(0, false, "没有收到文件名消息");
			break;
			IL_01d8:
			AppHelper.ShowWindowsToastMessage("Quicker", "从Websocket接收到文件，点击查看:\r\n" + SSYts150vHE(), _003C_003Ec__DisplayClass18_.ic0vjtGwgKy);
			goto IL_020a;
			IL_003a:
			switch (num2)
			{
			case 1:
				break;
			case 2:
				continue;
			default:
				ONNtsByxWOq.Warn("收到了不合法的WebSocket消息：" + messageEventArgs_0.Data);
				AppHelper.ShowWarning("收到了不合法的WebSocket消息。内容已写入log。");
				return;
			case 3:
				return;
			case 4:
				goto IL_01d8;
			}
			goto IL_0018;
			IL_0018:
			WebSocketMessageBase webSocketMessageBase = JsonConvert.DeserializeObject<WebSocketMessageBase>(messageEventArgs_0.Data);
			if (webSocketMessageBase == null)
			{
				num2 = 0;
				if (!QCxEM8QaQDEJAqOiOqO5())
				{
					num2 = num;
				}
				goto IL_003a;
			}
			if (!N8XtsxJwQjk())
			{
				if (webSocketMessageBase.MessageType != 5)
				{
					Close(CloseStatusCode.InvalidData, "需要登录。");
					return;
				}
				if (string.Equals(webSocketMessageBase.Data.ToString(), AppState.HHxtaMaoqJr().WebsocketServerSettings?.Password))
				{
					RQAtsrWeajA(true);
					u5VtsInLl9N();
				}
				else
				{
					R4ytsYxU1ix(new WebSocketResponse
					{
						ReplyTo = webSocketMessageBase.Serial,
						MessageType = 6,
						Message = "密码不正确",
						IsSuccess = false
					});
				}
			}
			if (webSocketMessageBase.MessageType != 2 && webSocketMessageBase.MessageType != 0)
			{
				if (webSocketMessageBase.MessageType != 4)
				{
				}
			}
			else
			{
				qcZts9Sootv(messageEventArgs_0);
			}
			break;
			IL_020a:
			CSmtse70iaQ(TnbtsXiYanp(), true, "ok", _003C_003Ec__DisplayClass18_.N7rvjgI9sGK);
			break;
		}
		base.OnMessage(messageEventArgs_0);
	}

	private bool qcZts9Sootv(MessageEventArgs messageEventArgs_0)
	{
		WebSocketRequest webSocketRequest = JsonConvert.DeserializeObject<WebSocketRequest>(messageEventArgs_0.Data);
		if (webSocketRequest != null)
		{
			try
			{
				WebSocketResponse webSocketResponse = new WebSocketResponse
				{
					ReplyTo = webSocketRequest.Serial,
					Data = "",
					IsSuccess = true,
					MessageType = 4
				};
				int num = 1;
				if (yu1gNPQaVMnc691ucSuQ != null)
				{
					goto IL_00ea;
				}
				int num2 = default(int);
				while (true)
				{
					switch (num)
					{
					case 1:
					{
						string text = webSocketRequest.Operation.ToUpperInvariant();
						if (string.IsNullOrEmpty(text))
						{
							text = "COPY";
						}
						if (text == "SENDFILE" || text == "PASTEIMAGE")
						{
							wgstsbfMrQ5(webSocketRequest.Data.ToString());
							Rlgtss2BLYU(text);
							NgYtsmVn0Hx(webSocketRequest.Serial);
							CSmtse70iaQ(webSocketRequest.Serial, true, "waiting for file...");
							num = 0;
							if (!QCxEM8QaQDEJAqOiOqO5())
							{
								num = num2;
							}
							continue;
						}
						string[] array = text.SplitToList(',', ';');
						string string_;
						object obj;
						for (int i = 0; i < array.Length; webSocketResponse.Data = CxPyBB2GbLo3XslgL6G.oP6thw9VUmy(string_, (string)obj, webSocketRequest.Action, webSocketRequest.Wait), i++)
						{
							string_ = array[i];
							object data = webSocketRequest.Data;
							if (data == null)
							{
								obj = null;
							}
							else
							{
								obj = data.ToString();
								if (obj != null)
								{
									continue;
								}
							}
							obj = string.Empty;
						}
						Send(webSocketResponse.ToCamelCaseJson());
						goto end_IL_00dd;
					}
					}
					goto IL_00ea;
					continue;
					end_IL_00dd:
					break;
				}
				goto end_IL_0015;
				IL_00ea:
				return true;
				end_IL_0015:;
			}
			catch (Exception ex)
			{
				ONNtsByxWOq.Warn("处理WebSocket消息出错。原始内容：" + messageEventArgs_0.Data + ", 错误：" + ex.Message, ex);
				CSmtse70iaQ(webSocketRequest.Serial, false, ex.Message);
			}
		}
		else
		{
			ONNtsByxWOq.Warn("无法解析请求消息。原始内容：" + messageEventArgs_0.Data);
			CSmtse70iaQ(webSocketRequest.Serial, false, "无法解析请求消息");
		}
		return false;
	}

	private string QFYtsheNBm2(string string_2)
	{
		string text = AppState.HHxtaMaoqJr().RecvFileFolder.Or(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Quicker", "_recv"));
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		return Path.Combine(text, DateTime.Now.ToString("yyyyMMdd_hhmmssfff_") + string_2);
	}

	private void CSmtse70iaQ(int int_1, bool bool_1, string string_2, string string_3 = null)
	{
		WebSocketResponse webSocketResponse_ = new WebSocketResponse
		{
			ReplyTo = int_1,
			IsSuccess = bool_1,
			MessageType = 4,
			Message = string_2,
			Data = string_3
		};
		R4ytsYxU1ix(webSocketResponse_);
	}

	private void R4ytsYxU1ix(WebSocketResponse webSocketResponse_0)
	{
		Send(webSocketResponse_0.ToCamelCaseJson());
	}

	protected override void OnClose(CloseEventArgs closeEventArgs_0)
	{
		ONNtsByxWOq.Info($"WebSocket::OnClose  code:{closeEventArgs_0.Code} reason:{closeEventArgs_0.Reason}");
		base.OnClose(closeEventArgs_0);
		if (N8XtsxJwQjk())
		{
			AppHelper.ShowWindowsToastMessage("Websocket客户端断开了", $"当前共连接了{AppState.JIKt7NpAUuR().QH6tsut5blZ()}个客户端。", null, 1.5);
		}
	}

	protected override void OnError(WebSocketSharp.ErrorEventArgs errorEventArgs_0)
	{
		ONNtsByxWOq.Warn("WebSocket::OnError  " + errorEventArgs_0.Message, errorEventArgs_0.Exception);
		base.OnError(errorEventArgs_0);
	}

	protected override void OnOpen()
	{
		base.OnOpen();
		if (string.IsNullOrWhiteSpace(AppState.DataService.CpItmVISR7P().WebsocketServerSettings?.Password))
		{
			u5VtsInLl9N();
		}
	}

	private void u5VtsInLl9N()
	{
		RQAtsrWeajA(true);
		R4ytsYxU1ix(new WebSocketResponse
		{
			ReplyTo = 0,
			MessageType = 6,
			Data = "",
			IsSuccess = true
		});
		AppHelper.ShowWindowsToastMessage("Websocket客户端已连接到Quicker", $"当前共连接了{AppState.JIKt7NpAUuR().QH6tsut5blZ()}个客户端。", null, 1.5);
	}

	public void Ij5tsW72qkf(string string_2)
	{
		Send(string_2);
	}

	public void Ja3tskQojKA(FileInfo fileInfo_0)
	{
		Send(fileInfo_0);
	}

	static PKhsW5Xlli2epa94ZyO()
	{
		ONNtsByxWOq = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool QCxEM8QaQDEJAqOiOqO5()
	{
		return yu1gNPQaVMnc691ucSuQ == null;
	}

	internal static void yQVwWrQaj2Yatix2Y9bW()
	{
	}
}
