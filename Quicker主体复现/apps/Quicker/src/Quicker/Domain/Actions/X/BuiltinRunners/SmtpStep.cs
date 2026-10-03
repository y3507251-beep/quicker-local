using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;
using FontAwesome5;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class SmtpStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass50_0
	{
		public ActionStep eFYv3YGETDw;

		public ActionExecuteContext k7Vv3IG38Ga;

		private static _003C_003Ec__DisplayClass50_0 QZv4LtWDj5jjw27qqH7K;

		internal (bool isSuccess, string message, ActionStopFlag failReason) h0xv3eF28tc()
		{
			string textParamValue = XActionHelper.GetTextParamValue(iuJtMGVaOXU, eFYv3YGETDw, k7Vv3IG38Ga);
			int port = Convert.ToInt32(XActionHelper.GetNumberParamValue(Vi8tMsOQPKo, eFYv3YGETDw, k7Vv3IG38Ga));
			bool booleanParamValue = XActionHelper.GetBooleanParamValue(quItMHjaiD9, eFYv3YGETDw, k7Vv3IG38Ga);
			string textParamValue2 = XActionHelper.GetTextParamValue(mE9tM15HOIO, eFYv3YGETDw, k7Vv3IG38Ga);
			string textParamValue3 = XActionHelper.GetTextParamValue(jgMtMbhVC8u, eFYv3YGETDw, k7Vv3IG38Ga);
			string textParamValue4 = XActionHelper.GetTextParamValue(BX6tM6ca6ah, eFYv3YGETDw, k7Vv3IG38Ga);
			string textParamValue5 = XActionHelper.GetTextParamValue(TgbtMXUJKdq, eFYv3YGETDw, k7Vv3IG38Ga);
			string textParamValue6 = XActionHelper.GetTextParamValue(PxCtMmt8fMD, eFYv3YGETDw, k7Vv3IG38Ga);
			string textParamValue7 = XActionHelper.GetTextParamValue(iOJtMKevdpO, eFYv3YGETDw, k7Vv3IG38Ga);
			string textParamValue8 = XActionHelper.GetTextParamValue(BY7tMxrefUE, eFYv3YGETDw, k7Vv3IG38Ga);
			string textParamValue9 = XActionHelper.GetTextParamValue(jcdtMr52CAT, eFYv3YGETDw, k7Vv3IG38Ga);
			string textParamValue10 = XActionHelper.GetTextParamValue(u36tMp9yPpB, eFYv3YGETDw, k7Vv3IG38Ga);
			string textParamValue11 = XActionHelper.GetTextParamValue(RmGtMBgQNPZ, eFYv3YGETDw, k7Vv3IG38Ga);
			bool booleanParamValue2 = XActionHelper.GetBooleanParamValue(r8WtMQe32lH, eFYv3YGETDw, k7Vv3IG38Ga);
			using (MailMessage mailMessage = new MailMessage(textParamValue4, textParamValue6, textParamValue9, textParamValue10))
			{
				if (!string.IsNullOrEmpty(textParamValue5))
				{
					mailMessage.Sender = new MailAddress(textParamValue4, textParamValue5, Encoding.UTF8);
				}
				if (!string.IsNullOrEmpty(textParamValue7))
				{
					mailMessage.CC.Add(textParamValue7);
				}
				if (!string.IsNullOrEmpty(textParamValue8))
				{
					mailMessage.Bcc.Add(textParamValue8);
				}
				if (!string.IsNullOrEmpty(textParamValue11))
				{
					string[] array = textParamValue11.Split(new char[2] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
					foreach (string text in array)
					{
						if (System.IO.File.Exists(text))
						{
							mailMessage.Attachments.Add(new Attachment(text));
							continue;
						}
						return (isSuccess: false, message: "Email附件文件不存在：" + text, failReason: ActionStopFlag.OperationFailed);
					}
				}
				mailMessage.IsBodyHtml = booleanParamValue2;
				using SmtpClient smtpClient = new SmtpClient(textParamValue);
				smtpClient.Port = port;
				smtpClient.EnableSsl = booleanParamValue;
				if (!string.IsNullOrEmpty(textParamValue2))
				{
					smtpClient.Credentials = new NetworkCredential
					{
						UserName = textParamValue2,
						Password = textParamValue3
					};
				}
				try
				{
					smtpClient.Send(mailMessage);
				}
				catch (Exception ex)
				{
					return (isSuccess: false, message: "发送邮件失败:" + ex.Message, failReason: ActionStopFlag.OperationFailed);
				}
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool CpCJfRWDD0OKthcZ0ioQ()
		{
			return QZv4LtWDj5jjw27qqH7K == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> RQ1tMeI8NSg = new string[1] { "email" };

	[CompilerGenerated]
	private readonly string I1utMYCJNFy = $"fa:{EFontAwesomeIcon.Light_EnvelopeOpenText}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> QBqtMI5ir1e;

	[CompilerGenerated]
	private readonly string O3stMWhIV41 = "https://getquicker.net/KC/Help/Doc/smtp";

	[CompilerGenerated]
	private readonly bool GcItMk01UG8;

	private static readonly StepInParamDef iuJtMGVaOXU;

	private static readonly StepInParamDef Vi8tMsOQPKo;

	private static readonly StepInParamDef quItMHjaiD9;

	private static readonly StepInParamDef mE9tM15HOIO;

	private static readonly StepInParamDef jgMtMbhVC8u;

	private static readonly StepInParamDef BX6tM6ca6ah;

	private static readonly StepInParamDef TgbtMXUJKdq;

	private static readonly StepInParamDef PxCtMmt8fMD;

	private static readonly StepInParamDef iOJtMKevdpO;

	private static readonly StepInParamDef BY7tMxrefUE;

	private static readonly StepInParamDef jcdtMr52CAT;

	private static readonly StepInParamDef u36tMp9yPpB;

	private static readonly StepInParamDef RmGtMBgQNPZ;

	private static readonly StepInParamDef r8WtMQe32lH;

	private static readonly StepInParamDef qcqtMjcXNCs;

	private static readonly StepOutParamDef PSntMnjTtri;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> xGBtM43k52m = new List<StepInParamDef>
	{
		iuJtMGVaOXU, Vi8tMsOQPKo, quItMHjaiD9, mE9tM15HOIO, jgMtMbhVC8u, BX6tM6ca6ah, TgbtMXUJKdq, PxCtMmt8fMD, iOJtMKevdpO, BY7tMxrefUE,
		jcdtMr52CAT, u36tMp9yPpB, RmGtMBgQNPZ, r8WtMQe32lH, qcqtMjcXNCs
	};

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> BAUtM5vyCpF = new List<StepOutParamDef> { PSntMnjTtri };

	internal static SmtpStep rX9YFeQiILTHBtNWFbJU;

	public string Key => "sys:smtp";

	public string Name => "SMTP发送邮件";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return RQ1tMeI8NSg;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return I1utMYCJNFy;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Network;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return QBqtMI5ir1e;
		}
	}

	public string Description => "使用SMTP协议发送邮件";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return O3stMWhIV41;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return GcItMk01UG8;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return xGBtM43k52m;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return BAUtM5vyCpF;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass50_0 _003C_003Ec__DisplayClass50_ = new _003C_003Ec__DisplayClass50_0();
		_003C_003Ec__DisplayClass50_.eFYv3YGETDw = step;
		_003C_003Ec__DisplayClass50_.k7Vv3IG38Ga = context;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass50_.k7Vv3IG38Ga, _003C_003Ec__DisplayClass50_.eFYv3YGETDw, action, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass50_.h0xv3eF28tc, (Action)null, (Action)null, qcqtMjcXNCs, PSntMnjTtri);
	}

	public string GetSummary(ActionStep step)
	{
		return "";
	}

	static SmtpStep()
	{
		iuJtMGVaOXU = new StepInParamDef
		{
			Key = "server",
			Name = "邮件服务器",
			DefaultValue = "",
			Description = "邮件服务器的域名或IP",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		Vi8tMsOQPKo = new StepInParamDef
		{
			Key = "port",
			Name = "端口",
			DefaultValue = 25,
			Description = "Smtp端口号",
			IsRequired = true,
			Type = VarType.Integer,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		quItMHjaiD9 = new StepInParamDef
		{
			Key = "useSsl",
			Name = "使用加密连接",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput,
			DefaultValue = false,
			Description = "是否使用TLS连接（通常为587端口）。"
		};
		mE9tM15HOIO = new StepInParamDef
		{
			Key = "account",
			Name = "帐号",
			DefaultValue = "",
			Description = "发信帐号",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		jgMtMbhVC8u = new StepInParamDef
		{
			Key = "password",
			Name = "密码",
			DefaultValue = "",
			Description = "发信帐号的密码",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		BX6tM6ca6ah = new StepInParamDef
		{
			Key = "sender",
			Name = "发信邮箱",
			DefaultValue = "",
			Description = "发信帐号所对应的Email地址",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		TgbtMXUJKdq = new StepInParamDef
		{
			Key = "senderName",
			Name = "发件人名称",
			DefaultValue = "",
			Description = "发件人的显示名称（可选）",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		PxCtMmt8fMD = new StepInParamDef
		{
			Key = "to",
			Name = "收件人",
			DefaultValue = "",
			Description = "收件人Email地址，多个的话使用小写逗号分隔。",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		iOJtMKevdpO = new StepInParamDef
		{
			Key = "cc",
			Name = "抄送",
			DefaultValue = "",
			Description = "抄送给的Email地址列表，多个的话使用小写逗号分隔。",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		BY7tMxrefUE = new StepInParamDef
		{
			Key = "bcc",
			Name = "密送",
			DefaultValue = "",
			Description = "密送给的Email地址列表，多个的话使用小写逗号分隔。",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		jcdtMr52CAT = new StepInParamDef
		{
			Key = "subject",
			Name = "邮件主题",
			DefaultValue = "",
			Description = "邮件的主题",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		u36tMp9yPpB = new StepInParamDef
		{
			Key = "content",
			Name = "邮件正文",
			Description = "邮件正文内容",
			Type = VarType.Text,
			IsMultiLine = true,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		RmGtMBgQNPZ = new StepInParamDef
		{
			Key = "attachList",
			Name = "附件",
			Description = "附件文件列表。多个时每行一个。",
			Type = VarType.Text,
			IsMultiLine = true,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		r8WtMQe32lH = new StepInParamDef
		{
			Key = "isHtml",
			Name = "内容为html",
			DefaultValue = false,
			Description = "邮件内容是否为HTML格式",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		qcqtMjcXNCs = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		PSntMnjTtri = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
	}

	internal static bool uwWOVYQi68nndVi1tF3a()
	{
		return rX9YFeQiILTHBtNWFbJU == null;
	}
}
