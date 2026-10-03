using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using FontAwesome5;
using Quicker.Domain;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using W33wbKA34cSsSUeCj5U;
using WebSocketSharp;
using WebSocketSharp.Net;

namespace XPsRKmoMKOckGvOl4ux;

internal class nAT2RNoYewIg5cnslWi : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass54_0
	{
		public ActionStep fnESYvGEjsq;

		public ActionExecuteContext yIMSYS9LfGt;

		public nAT2RNoYewIg5cnslWi BsMSY2fcCr2;

		public XAction BMxSYu7LIgq;

		private static _003C_003Ec__DisplayClass54_0 U59nbTWuGnv0AhOurAyO;

		internal (bool isSuccess, string message, ActionStopFlag failReason) kCCSYLMFngw()
		{
			string textParamValue = XActionHelper.GetTextParamValue(FiBgGsI5DDG, fnESYvGEjsq, yIMSYS9LfGt);
			return textParamValue switch
			{
				"SendFileToClientBase64" => BsMSY2fcCr2.m67gGhMmIoM(yIMSYS9LfGt, fnESYvGEjsq, BMxSYu7LIgq, true), 
				"CloseClient" => BsMSY2fcCr2.CloseClient(yIMSYS9LfGt, fnESYvGEjsq, BMxSYu7LIgq), 
				"CreateClient" => BsMSY2fcCr2.CreateClient(yIMSYS9LfGt, fnESYvGEjsq, BMxSYu7LIgq), 
				"GetClientState" => BsMSY2fcCr2.GetClientState(yIMSYS9LfGt, fnESYvGEjsq, BMxSYu7LIgq), 
				"SendMsgToServer" => BsMSY2fcCr2.SendMessage(yIMSYS9LfGt, fnESYvGEjsq, BMxSYu7LIgq), 
				"SendTextToClient" => BsMSY2fcCr2.hRcgGeyiO0e(yIMSYS9LfGt, fnESYvGEjsq, BMxSYu7LIgq), 
				"SendFileToClient" => BsMSY2fcCr2.m67gGhMmIoM(yIMSYS9LfGt, fnESYvGEjsq, BMxSYu7LIgq, false), 
				_ => (isSuccess: false, message: "不支持的操作类型：" + textParamValue, failReason: ActionStopFlag.OperationFailed), 
			};
		}

		internal static void A0Q10pWuKvwsLwoI0n18()
		{
		}

		internal static bool j874alWu0BV2ywBmsssJ()
		{
			return U59nbTWuGnv0AhOurAyO == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> sbwgGIRWKw9;

	[CompilerGenerated]
	private readonly string qmhgGWswEm4 = $"fa:{EFontAwesomeIcon.Light_Plug}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> MlvgGkHP84a;

	[CompilerGenerated]
	private readonly string XEWgGGigTuo = "https://getquicker.net/KC/Help/Doc/websocket";

	private static readonly StepInParamDef FiBgGsI5DDG;

	private static readonly StepInParamDef XOZgGHk6xX1;

	private static readonly StepInParamDef iXIgG1x4ORZ;

	private static readonly StepInParamDef LVPgGb4if4Y;

	private static readonly StepInParamDef aNYgG6hkmBa;

	private static readonly StepInParamDef B2dgGX0obq2;

	private static readonly StepInParamDef zbhgGmfJPxC;

	private static readonly StepInParamDef ieDgGKQ277g;

	private static readonly StepInParamDef GvIgGxvJMIY;

	private static readonly StepInParamDef dyfgGrPZ39w;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> u4ogGpw5lys = new List<StepInParamDef> { FiBgGsI5DDG, XOZgGHk6xX1, iXIgG1x4ORZ, LVPgGb4if4Y, ieDgGKQ277g, aNYgG6hkmBa, zbhgGmfJPxC, B2dgGX0obq2, GvIgGxvJMIY, dyfgGrPZ39w };

	private static readonly StepOutParamDef g0vgGBU2LXO;

	private static readonly StepOutParamDef W58gGQDTt7X;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> mMVgGjNWIcH = new List<StepOutParamDef> { g0vgGBU2LXO, W58gGQDTt7X };

	private static nAT2RNoYewIg5cnslWi CrSYPLQmRvml2XYLi9K1;

	public string Key => "sys:websocket";

	public string Name => "Websocket";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return sbwgGIRWKw9;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return qmhgGWswEm4;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Network;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return MlvgGkHP84a;
		}
	}

	public string Description => "Websocket相关操作";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return XEWgGGigTuo;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly => false;

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return u4ogGpw5lys;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return mMVgGjNWIcH;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass54_0 _003C_003Ec__DisplayClass54_ = new _003C_003Ec__DisplayClass54_0();
		_003C_003Ec__DisplayClass54_.fnESYvGEjsq = step;
		_003C_003Ec__DisplayClass54_.yIMSYS9LfGt = context;
		_003C_003Ec__DisplayClass54_.BsMSY2fcCr2 = this;
		_003C_003Ec__DisplayClass54_.BMxSYu7LIgq = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass54_.yIMSYS9LfGt, _003C_003Ec__DisplayClass54_.fnESYvGEjsq, _003C_003Ec__DisplayClass54_.BMxSYu7LIgq, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass54_.kCCSYLMFngw, (Action)null, (Action)null, dyfgGrPZ39w, g0vgGBU2LXO);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) CloseClient(ActionExecuteContext context, ActionStep step, XAction action)
	{
		string textParamValue = XActionHelper.GetTextParamValue(iXIgG1x4ORZ, step, context);
		CgCbcpAs57A5JADwgZR.ROVlz9sJkA().nfxl3cktgi(textParamValue);
		return (isSuccess: true, message: string.Empty, failReason: ActionStopFlag.NoStop);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) GetClientState(ActionExecuteContext context, ActionStep step, XAction action)
	{
		string textParamValue = XActionHelper.GetTextParamValue(iXIgG1x4ORZ, step, context);
		bool flag = CgCbcpAs57A5JADwgZR.ROVlz9sJkA().F4SlfgM15E(textParamValue);
		XActionHelper.OutputResult(W58gGQDTt7X, step, context, flag, action);
		return (isSuccess: true, message: string.Empty, failReason: ActionStopFlag.NoStop);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) SendMessage(ActionExecuteContext context, ActionStep step, XAction action)
	{
		string textParamValue = XActionHelper.GetTextParamValue(iXIgG1x4ORZ, step, context);
		string textParamValue2 = XActionHelper.GetTextParamValue(ieDgGKQ277g, step, context);
		if (!CgCbcpAs57A5JADwgZR.ROVlz9sJkA().F4SlfgM15E(textParamValue))
		{
			return (isSuccess: false, message: "不存在客户端：" + textParamValue, failReason: ActionStopFlag.OperationFailed);
		}
		CgCbcpAs57A5JADwgZR.ROVlz9sJkA().SendMessage(textParamValue, textParamValue2);
		return (isSuccess: true, message: textParamValue2, failReason: ActionStopFlag.NoStop);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) CreateClient(ActionExecuteContext context, ActionStep step, XAction action)
	{
		string textParamValue = XActionHelper.GetTextParamValue(ieDgGKQ277g, step, context);
		string textParamValue2 = XActionHelper.GetTextParamValue(LVPgGb4if4Y, step, context);
		string textParamValue3 = XActionHelper.GetTextParamValue(iXIgG1x4ORZ, step, context);
		bool booleanParamValue = XActionHelper.GetBooleanParamValue(GvIgGxvJMIY, step, context);
		if (string.IsNullOrEmpty(textParamValue3))
		{
			return (isSuccess: false, message: "客户端ID不能为空。", failReason: ActionStopFlag.OperationFailed);
		}
		WebSocket webSocket = sERgGY5Ltmt(context, step);
		webSocket.Connect();
		if (webSocket.ReadyState != WebSocketState.Open)
		{
			Thread.Sleep(1);
			return (isSuccess: false, message: "无法连接到服务器：" + webSocket.Url.ToString(), failReason: ActionStopFlag.OperationFailed);
		}
		CgCbcpAs57A5JADwgZR.ROVlz9sJkA().IbRli5JPkF(textParamValue3, webSocket, context.ActionId, textParamValue2, booleanParamValue);
		if (!string.IsNullOrEmpty(textParamValue))
		{
			webSocket.Send(textParamValue);
		}
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) m67gGhMmIoM(ActionExecuteContext actionExecuteContext_0, ActionStep actionStep_0, XAction xaction_0, bool bool_0)
	{
		if (!AppState.JIKt7NpAUuR().IsRunning)
		{
			return (isSuccess: false, message: "WebSocket服务不在运行中。", failReason: ActionStopFlag.OperationFailed);
		}
		if (AppState.JIKt7NpAUuR().QH6tsut5blZ() == 0)
		{
			return (isSuccess: false, message: "没有连接的客户端。", failReason: ActionStopFlag.OperationFailed);
		}
		string textParamValue = XActionHelper.GetTextParamValue(ieDgGKQ277g, actionStep_0, actionExecuteContext_0);
		if (!File.Exists(textParamValue))
		{
			return (isSuccess: false, message: "文件不存在:" + textParamValue, failReason: ActionStopFlag.NoStop);
		}
		AppState.JIKt7NpAUuR().SendFileToClient(textParamValue, bool_0);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) hRcgGeyiO0e(ActionExecuteContext actionExecuteContext_0, ActionStep actionStep_0, XAction xaction_0)
	{
		if (!AppState.JIKt7NpAUuR().IsRunning)
		{
			return (isSuccess: false, message: "WebSocket服务不在运行中。", failReason: ActionStopFlag.OperationFailed);
		}
		if (AppState.JIKt7NpAUuR().QH6tsut5blZ() == 0)
		{
			return (isSuccess: false, message: "没有连接的客户端。", failReason: ActionStopFlag.OperationFailed);
		}
		string textParamValue = XActionHelper.GetTextParamValue(ieDgGKQ277g, actionStep_0, actionExecuteContext_0);
		AppState.JIKt7NpAUuR().a29tsE8r0iN(textParamValue);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private static WebSocket sERgGY5Ltmt(ActionExecuteContext actionExecuteContext_0, ActionStep actionStep_0)
	{
		int num = 2;
		string[] array2 = default(string[]);
		int num3 = default(int);
		string name = default(string);
		string value = default(string);
		while (true)
		{
			string textParamValue = XActionHelper.GetTextParamValue(XOZgGHk6xX1, actionStep_0, actionExecuteContext_0);
			string textParamValue2 = XActionHelper.GetTextParamValue(aNYgG6hkmBa, actionStep_0, actionExecuteContext_0);
			string textParamValue3 = XActionHelper.GetTextParamValue(B2dgGX0obq2, actionStep_0, actionExecuteContext_0);
			string textParamValue4 = XActionHelper.GetTextParamValue(zbhgGmfJPxC, actionStep_0, actionExecuteContext_0);
			WebSocket webSocket = new WebSocket(textParamValue);
			int num2 = 1;
			if (CrSYPLQmRvml2XYLi9K1 != null)
			{
				goto IL_00fc;
			}
			goto IL_0100;
			IL_0100:
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (!string.IsNullOrWhiteSpace(textParamValue2))
					{
						string[] array = textParamValue2.Split(new string[2] { "\r\n", "\n" }, StringSplitOptions.None);
						if (array.Length != 2)
						{
							throw new InvalidDataException("账号密码应该为两行");
						}
						webSocket.SetCredentials(array[0], array[1], false);
					}
					if (!string.IsNullOrWhiteSpace(textParamValue3))
					{
						webSocket.Origin = textParamValue3.Trim();
					}
					if (!string.IsNullOrWhiteSpace(textParamValue4))
					{
						array2 = textParamValue4.SplitToList();
						num3 = 0;
						goto IL_0087;
					}
					goto IL_017a;
				default:
					webSocket.SetCookie(new Cookie(name, value));
					num3++;
					goto IL_0087;
				case 2:
					break;
					IL_0087:
					if (num3 < array2.Length)
					{
						string[] array3 = array2[num3].Split(new char[1] { '=' }, 2);
						if (array3.Length == 2)
						{
							name = array3[0].Trim();
							if (array3.Length == 1)
							{
								goto IL_00e8;
							}
							value = array3[1];
							goto default;
						}
						throw new InvalidDataException("cookie格式不正确。每行为name=value格式");
					}
					goto IL_017a;
					IL_017a:
					return webSocket;
				}
				break;
				IL_00e8:
				value = string.Empty;
				num2 = 0;
				if (CrSYPLQmRvml2XYLi9K1 == null)
				{
					continue;
				}
				goto IL_00fc;
			}
			continue;
			IL_00fc:
			num2 = num;
			goto IL_0100;
		}
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(FiBgGsI5DDG, step) ?? "";
	}

	static nAT2RNoYewIg5cnslWi()
	{
		FiBgGsI5DDG = new StepInParamDef
		{
			Key = "operation",
			Name = "操作类型",
			Description = "",
			VariableMode = ParamVariableMode.Input,
			DefaultValue = "CreateClient",
			Type = VarType.Enum,
			IsControlField = true,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("CreateClient", "客户端：连接到Websocket服务"),
				new SelectionItem("SendMsgToServer", "客户端：向Websocket服务发送消息"),
				new SelectionItem("GetClientState", "客户端：获取连接状态"),
				new SelectionItem("CloseClient", "客户端：关闭连接"),
				new SelectionItem("SendTextToClient", "服务器：向连接的客户端发送文本"),
				new SelectionItem("SendFileToClient", "服务器：向连接的客户端发送文件(二进制方式)"),
				new SelectionItem("SendFileToClientBase64", "服务器：向连接的客户端发送文件(Base64方式)")
			}
		};
		XOZgGHk6xX1 = new StepInParamDef
		{
			Key = "server",
			Name = "服务器地址",
			Description = "",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = false,
			ValidForList = new string[1] { "CreateClient" }
		};
		iXIgG1x4ORZ = new StepInParamDef
		{
			Key = "clientId",
			Name = "连接ID",
			Description = "用于区分不同的客户端连接。连接相同id的客户端时，前一个连接会被自动关闭。",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = false,
			ValidForList = new string[4] { "CreateClient", "SendMsgToServer", "GetClientState", "CloseClient" }
		};
		LVPgGb4if4Y = new StepInParamDef
		{
			Key = "spName",
			Name = "消息处理子程序",
			Description = "使用子程序处理从websocket服务接收到的消息。详情请参考文档。",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = false,
			ValidForList = new string[1] { "CreateClient" }
		};
		aNYgG6hkmBa = new StepInParamDef
		{
			Key = "account",
			Name = "账号密码",
			Description = "支持Basic和Digest认证方式。多行填写。第一行写账号，第二行写密码。",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true,
			ValidForList = new string[1] { "CreateClient" }
		};
		B2dgGX0obq2 = new StepInParamDef
		{
			Key = "origin",
			Name = "Origin",
			Description = "仅需要时填写",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = false,
			ValidForList = new string[1] { "CreateClient" }
		};
		zbhgGmfJPxC = new StepInParamDef
		{
			Key = "cookie",
			Name = "Cookie",
			DefaultValue = "",
			Description = "请求的cookie内容",
			IsRequired = false,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = false,
			ValidForList = new string[1] { "CreateClient" }
		};
		ieDgGKQ277g = new StepInParamDef
		{
			Key = "content",
			Name = "消息内容",
			DefaultValue = "",
			Description = "文本内容。发送文件时为文件的完整路径。",
			IsRequired = false,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true,
			ValidForList = new string[5] { "CreateClient", "SendTextToClient", "SendFileToClient", "SendFileToClientBase64", "SendMsgToServer" }
		};
		GvIgGxvJMIY = new StepInParamDef
		{
			Key = "callbackOnClose",
			Name = "服务断开时通知动作(调用动作并传入参数:websocket__closed)",
			DefaultValue = true,
			Description = "是否等待服务器响应",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "CreateClient" }
		};
		dyfgGrPZ39w = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		g0vgGBU2LXO = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		W58gGQDTt7X = new StepOutParamDef
		{
			Key = "isConnected",
			Name = "是否连接",
			Description = "指定客户端是否连接到远程服务器",
			Type = VarType.Boolean,
			ValidForList = new List<string> { "GetClientState" }
		};
	}

	internal static bool XXrAdlQmgYkWJ69PUguo()
	{
		return CrSYPLQmRvml2XYLi9K1 == null;
	}
}
