using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Cache;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using IgQBbvXMVdsN7GVNUxX;
using log4net;
using Newtonsoft.Json;
using Okhk4Jopsf6TX1dhiKV;
using OpenAI_API;
using OpenAI_API.Chat;
using OpenAI_API.Completions;
using OpenAI_API.Models;
using Quicker.Actions.XActions.BuildinRunners.Network.Ai;
using Quicker.Domain;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Win32;
using Quicker.View;
using WindowsInput;

namespace DteyAGXxRTw4WY0S75h;

internal class H4rLbTXtxuZjM4Su8vo : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec PU4SeLgE75K;

		public static Func<ChatMessage.ContentItem, bool> n3eSevWLsCk;

		private static _003C_003Ec ryg0SiWLNNWMwmowjvJF;

		static _003C_003Ec()
		{
			PU4SeLgE75K = new _003C_003Ec();
		}

		internal bool bbVSegp9BFU(ChatMessage.ContentItem x)
		{
			if (x.Text == null)
			{
				return x.Image != null;
			}
			return true;
		}

		internal static bool IZJCYfWL9pwUosPRGtgZ()
		{
			return ryg0SiWLNNWMwmowjvJF == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass73_0
	{
		public ActionStep EVvSe2W7Xjt;

		public ActionExecuteContext brhSeucyD7m;

		public H4rLbTXtxuZjM4Su8vo F4sSeNfcfJp;

		public XAction HxXSeJdEEZr;

		private static _003C_003Ec__DisplayClass73_0 mlZ05jWLunmkmHGhqG8c;

		internal (bool isSuccess, string message, ActionStopFlag failReason) aslSeSkKxYi()
		{
			_003C_003Ec__DisplayClass73_1 _003C_003Ec__DisplayClass73_ = new _003C_003Ec__DisplayClass73_1
			{
				pwXSePFx2u7 = this
			};
			string text = XActionHelper.GetTextParamValue(fXSgIco5HUS, EVvSe2W7Xjt, brhSeucyD7m);
			if (!string.IsNullOrWhiteSpace(text))
			{
                if (text == "p1" || text == "quicker")
                    throw new ArgumentException("原厂 AI 代理已删除，请填写自己使用的 API 地址和密钥。");
				if (!text.StartsWith("http", StringComparison.OrdinalIgnoreCase))
				{
					throw new ArgumentException("API网址格式不正确。请以https://或http://开始。");
				}
				if (!text.Contains("{1}"))
				{
					text = text.TrimEnd('/') + "/{0}/{1}";
					brhSeucyD7m.ActionLogger.LogInfo("补全了API网址模板，结果为：" + text);
				}
			}
			string textParamValue = XActionHelper.GetTextParamValue(mAagIV0eQa4, EVvSe2W7Xjt, brhSeucyD7m);
			if (string.IsNullOrWhiteSpace(textParamValue))
			{
				return (isSuccess: false, message: "未提供API Key", failReason: ActionStopFlag.OperationFailed);
			}
			string textParamValue2 = XActionHelper.GetTextParamValue(nxkgIZjTFGb, EVvSe2W7Xjt, brhSeucyD7m);
			bool booleanParamValue = XActionHelper.GetBooleanParamValue(xnEgImpYiUY, EVvSe2W7Xjt, brhSeucyD7m);
			double numberParamValue = XActionHelper.GetNumberParamValue(kMXgIHlqTjb, EVvSe2W7Xjt, brhSeucyD7m);
			using HttpClient httpClient = F4sSeNfcfJp.AfZgI0kUSiG(booleanParamValue, textParamValue, textParamValue2, brhSeucyD7m, (int)numberParamValue);
			_003C_003Ec__DisplayClass73_.scnSe0m4VBT = new OpenAIAPI(new APIAuthentication(textParamValue, textParamValue2), httpClient);
			if (!string.IsNullOrWhiteSpace(text))
			{
				_003C_003Ec__DisplayClass73_.scnSe0m4VBT.ApiUrlFormat = text;

			}
			string textParamValue3 = XActionHelper.GetTextParamValue(IvQgIRYfDkT, EVvSe2W7Xjt, brhSeucyD7m);
			string textParamValue4 = XActionHelper.GetTextParamValue(uZKgIqEoF86, EVvSe2W7Xjt, brhSeucyD7m);
			object paramValue = XActionHelper.GetParamValue(etegIYA7r8K, EVvSe2W7Xjt, brhSeucyD7m);
			string text2 = paramValue as string;
			if (text2 != null)
			{
				if (string.IsNullOrWhiteSpace(text2))
				{
					return (isSuccess: false, message: "未提供Prompt", failReason: ActionStopFlag.OperationFailed);
				}
			}
			else
			{
				text2 = null;
			}
			string textParamValue5 = XActionHelper.GetTextParamValue(IBkgI9FrsyK, EVvSe2W7Xjt, brhSeucyD7m);
			string text3 = XActionHelper.GetTextParamValue(SCYgIIjkPWU, EVvSe2W7Xjt, brhSeucyD7m);
			if (string.IsNullOrWhiteSpace(text3))
			{
				text3 = null;
			}
			long integerParamValue = XActionHelper.GetIntegerParamValue(PmBgIWKADX8, EVvSe2W7Xjt, brhSeucyD7m);
			double numberParamValue2 = XActionHelper.GetNumberParamValue(njEgIkZGi6u, EVvSe2W7Xjt, brhSeucyD7m);
			double numberParamValue3 = XActionHelper.GetNumberParamValue(RFvgIGucxnQ, EVvSe2W7Xjt, brhSeucyD7m);
			long integerParamValue2 = XActionHelper.GetIntegerParamValue(WcPgIsMqN4Q, EVvSe2W7Xjt, brhSeucyD7m);
			bool booleanParamValue2 = XActionHelper.GetBooleanParamValue(FtAgI17IMoj, EVvSe2W7Xjt, brhSeucyD7m);
			string textParamValue6 = XActionHelper.GetTextParamValue(tw0gIX2XkVi, EVvSe2W7Xjt, brhSeucyD7m);
			textParamValue6 = ((textParamValue6.IsNullOrEmpty() || !(textParamValue6 != "<|endoftext|>")) ? "<|endoftext|>" : Regex.Unescape(textParamValue6));
			_003C_003Ec__DisplayClass73_.WCiSeCg3oBn = (booleanParamValue2 ? XActionHelper.GetTextParamValue(WYcgIbRIWMJ, EVvSe2W7Xjt, brhSeucyD7m) : "");
			if (_003C_003Ec__DisplayClass73_.WCiSeCg3oBn == "=")
			{
				_003C_003Ec__DisplayClass73_.WCiSeCg3oBn = brhSeucyD7m.ActionId;
			}
			object obj3;
			_003C_003Ec__DisplayClass73_2 _003C_003Ec__DisplayClass73_2;
			Guid result;
			object obj;
			object obj2;
			string text5;
			ChatMessage chatMessage;
			switch (textParamValue3)
			{
			default:
				return (isSuccess: false, message: "不支持的端点：" + textParamValue3 + ", 可能您使用的软件版本较旧。", failReason: ActionStopFlag.OperationFailed);
			case "edits":
			{
				_003C_003Ec__DisplayClass73_7 _003C_003Ec__DisplayClass73_3 = new _003C_003Ec__DisplayClass73_7
				{
					gBUSeBlmCkp = _003C_003Ec__DisplayClass73_,
					ba2SexVxFE9 = new CompletionRequest
					{
						Model = (textParamValue4.IsNullOrWhiteSpace() ? Model.ChatGPTTurbo : new Model(textParamValue4)),
						Temperature = numberParamValue2,
						MaxTokens = ((integerParamValue == 0L) ? ((int?)null) : new int?((int)integerParamValue)),
						TopP = numberParamValue3,
						StopSequence = textParamValue6,
						Prompt = text2,
						Suffix = text3
					}
				};
				if (!booleanParamValue2)
				{
					CompletionResult result2 = _003C_003Ec__DisplayClass73_3.gBUSeBlmCkp.scnSe0m4VBT.Completions.CreateCompletionAsync(_003C_003Ec__DisplayClass73_3.ba2SexVxFE9).GetAwaiter().GetResult();
					if (result2 == null)
					{
						return (isSuccess: false, message: "未能获得响应", failReason: ActionStopFlag.OperationFailed);
					}
					string text4 = result2.Completions[0].Text;
					XActionHelper.OutputResult(a54gIQuZ74p, EVvSe2W7Xjt, brhSeucyD7m, text4, HxXSeJdEEZr);
					XActionHelper.OutputResult(XRbgInkc6UJ, EVvSe2W7Xjt, brhSeucyD7m, result2.RawResponse, HxXSeJdEEZr);
					XActionHelper.OutputResult(KGdgI4KYAnA, EVvSe2W7Xjt, brhSeucyD7m, result2.Usage.PromptTokens, HxXSeJdEEZr);
					XActionHelper.OutputResult(D7ogI50kmHk, EVvSe2W7Xjt, brhSeucyD7m, result2.Usage.CompletionTokens, HxXSeJdEEZr);
					XActionHelper.OutputResult(diogIDAFm12, EVvSe2W7Xjt, brhSeucyD7m, result2.Usage.TotalTokens, HxXSeJdEEZr);
					XActionHelper.OutputResult(JrGgIdwySLX, EVvSe2W7Xjt, brhSeucyD7m, result2.Completions[0].FinishReason, HxXSeJdEEZr);
				}
				else
				{
					_003C_003Ec__DisplayClass73_3.N1ISepJMKOs = new AutoResetEvent(false);
					_003C_003Ec__DisplayClass73_3.ALWSercQRvJ = new StringBuilder();
					Task.Run((Func<Task>)_003C_003Ec__DisplayClass73_3.tDWSeKUcbB4);
					_003C_003Ec__DisplayClass73_3.N1ISepJMKOs.WaitOne(TimeSpan.FromSeconds(numberParamValue));
					XActionHelper.OutputResult(a54gIQuZ74p, EVvSe2W7Xjt, brhSeucyD7m, _003C_003Ec__DisplayClass73_3.ALWSercQRvJ.ToString(), HxXSeJdEEZr);
					XActionHelper.OutputResult(XRbgInkc6UJ, EVvSe2W7Xjt, brhSeucyD7m, "", HxXSeJdEEZr);
					XActionHelper.OutputResult(KGdgI4KYAnA, EVvSe2W7Xjt, brhSeucyD7m, 0, HxXSeJdEEZr);
					XActionHelper.OutputResult(D7ogI50kmHk, EVvSe2W7Xjt, brhSeucyD7m, 0, HxXSeJdEEZr);
					XActionHelper.OutputResult(diogIDAFm12, EVvSe2W7Xjt, brhSeucyD7m, 0, HxXSeJdEEZr);
					XActionHelper.OutputResult(JrGgIdwySLX, EVvSe2W7Xjt, brhSeucyD7m, "", HxXSeJdEEZr);
				}
				break;
			}
			case "completions":
			{
				_003C_003Ec__DisplayClass73_5 _003C_003Ec__DisplayClass73_5 = new _003C_003Ec__DisplayClass73_5
				{
					yJNSeb0k96H = _003C_003Ec__DisplayClass73_,
					jyASek4yVoB = new CompletionRequest
					{
						Model = (textParamValue4.IsNullOrWhiteSpace() ? Model.ChatGPTTurbo : new Model(textParamValue4)),
						Temperature = numberParamValue2,
						MaxTokens = ((integerParamValue == 0L) ? ((int?)null) : new int?((int)integerParamValue)),
						TopP = numberParamValue3,
						StopSequence = textParamValue6,
						Prompt = text2.Or(paramValue.ToString()),
						Suffix = text3
					}
				};
				if (!booleanParamValue2)
				{
					CompletionResult result6 = _003C_003Ec__DisplayClass73_5.yJNSeb0k96H.scnSe0m4VBT.Completions.CreateCompletionAsync(_003C_003Ec__DisplayClass73_5.jyASek4yVoB).GetAwaiter().GetResult();
					if (result6 == null)
					{
						return (isSuccess: false, message: "未能获得响应", failReason: ActionStopFlag.OperationFailed);
					}
					if (!result6.Successful)
					{
						Error error2 = result6.Error;
						if (error2 == null)
						{
							obj3 = null;
						}
						else
						{
							obj3 = error2.Message;
							if (obj3 != null)
							{
								goto IL_0815;
							}
						}
						obj3 = "服务端返回错误。";
						goto IL_0815;
					}
					string text8 = result6.Completions[0].Text;
					XActionHelper.OutputResult(a54gIQuZ74p, EVvSe2W7Xjt, brhSeucyD7m, text8, HxXSeJdEEZr);
					XActionHelper.OutputResult(XRbgInkc6UJ, EVvSe2W7Xjt, brhSeucyD7m, result6.RawResponse, HxXSeJdEEZr);
					XActionHelper.OutputResult(KGdgI4KYAnA, EVvSe2W7Xjt, brhSeucyD7m, result6.Usage.PromptTokens, HxXSeJdEEZr);
					XActionHelper.OutputResult(D7ogI50kmHk, EVvSe2W7Xjt, brhSeucyD7m, result6.Usage.CompletionTokens, HxXSeJdEEZr);
					XActionHelper.OutputResult(diogIDAFm12, EVvSe2W7Xjt, brhSeucyD7m, result6.Usage.TotalTokens, HxXSeJdEEZr);
					XActionHelper.OutputResult(JrGgIdwySLX, EVvSe2W7Xjt, brhSeucyD7m, result6.Completions[0].FinishReason, HxXSeJdEEZr);
					break;
				}
				_003C_003Ec__DisplayClass73_5.iTDSe1kCQW2 = new AutoResetEvent(false);
				_003C_003Ec__DisplayClass73_5.Uq8Sesllild = new StringBuilder();
				_003C_003Ec__DisplayClass73_5.pB0SeGdpaw3 = null;
				_003C_003Ec__DisplayClass73_5.GDpSeHpJS7f = null;
				Task.Run((Func<Task>)_003C_003Ec__DisplayClass73_5.kYNSeW9qMLc);
				_003C_003Ec__DisplayClass73_5.iTDSe1kCQW2.WaitOne(TimeSpan.FromSeconds(numberParamValue));
				if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass73_5.GDpSeHpJS7f))
				{
					return (isSuccess: false, message: _003C_003Ec__DisplayClass73_5.GDpSeHpJS7f, failReason: ActionStopFlag.OperationFailed);
				}
				if (_003C_003Ec__DisplayClass73_5.pB0SeGdpaw3 != null && !_003C_003Ec__DisplayClass73_5.pB0SeGdpaw3.Successful)
				{
					return (isSuccess: false, message: "服务器返回错误：" + _003C_003Ec__DisplayClass73_5.pB0SeGdpaw3.Error?.Message, failReason: ActionStopFlag.OperationFailed);
				}
				XActionHelper.OutputResult(a54gIQuZ74p, EVvSe2W7Xjt, brhSeucyD7m, _003C_003Ec__DisplayClass73_5.Uq8Sesllild.ToString(), HxXSeJdEEZr);
				XActionHelper.OutputResult(XRbgInkc6UJ, EVvSe2W7Xjt, brhSeucyD7m, "", HxXSeJdEEZr);
				XActionHelper.OutputResult(KGdgI4KYAnA, EVvSe2W7Xjt, brhSeucyD7m, 0, HxXSeJdEEZr);
				XActionHelper.OutputResult(D7ogI50kmHk, EVvSe2W7Xjt, brhSeucyD7m, 0, HxXSeJdEEZr);
				XActionHelper.OutputResult(diogIDAFm12, EVvSe2W7Xjt, brhSeucyD7m, 0, HxXSeJdEEZr);
				XActionHelper.OutputResult(JrGgIdwySLX, EVvSe2W7Xjt, brhSeucyD7m, "", HxXSeJdEEZr);
				break;
			}
			case "chat":
				{
					_003C_003Ec__DisplayClass73_2 = new _003C_003Ec__DisplayClass73_2
					{
						lsTSe7hnd8x = _003C_003Ec__DisplayClass73_,
						O2ySeyApyIx = new ChatRequest
						{
							Model = (textParamValue4.IsNullOrWhiteSpace() ? Model.ChatGPTTurbo : new Model(textParamValue4)),
							Temperature = numberParamValue2,
							MaxTokens = ((integerParamValue == 0L) ? ((int?)null) : new int?((int)integerParamValue)),
							TopP = numberParamValue3,
							NumChoicesPerMessage = (int)integerParamValue2,
							Messages = new List<ChatMessage>()
						}
					};
					if (!textParamValue6.Contains("\n"))
					{
						_003C_003Ec__DisplayClass73_2.O2ySeyApyIx.StopSequence = textParamValue6;
					}
					else
					{
						_003C_003Ec__DisplayClass73_2.O2ySeyApyIx.MultipleStopSequences = textParamValue6.SplitToList();
					}
					string textParamValue7 = XActionHelper.GetTextParamValue(FQUgIK5EhOr, EVvSe2W7Xjt, brhSeucyD7m);
					_003C_003Ec__DisplayClass73_2.O2ySeyApyIx.ResponseFormat = textParamValue7;
					_003C_003Ec__DisplayClass73_2.TugSe8afy8T = XActionHelper.GetDictParamValue(DTygIxP6HIb, EVvSe2W7Xjt, brhSeucyD7m);
					IDictionary<string, object> dictionary = _003C_003Ec__DisplayClass73_2.TugSe8afy8T;
					if (dictionary != null && dictionary.Keys.Count == 0)
					{
						_003C_003Ec__DisplayClass73_2.TugSe8afy8T = null;
					}
					string textParamValue8 = XActionHelper.GetTextParamValue(aCfgIhO4thC, EVvSe2W7Xjt, brhSeucyD7m);
					result = Guid.Empty;
					_003C_003Ec__DisplayClass73_2.MimSeaar1lI = null;
					if (!string.IsNullOrWhiteSpace(textParamValue8))
					{
						if (!Guid.TryParse(textParamValue8, out result))
						{
							return (isSuccess: false, message: "会话ID格式不正确，请使用GUID值。", failReason: ActionStopFlag.OperationFailed);
						}
						_003C_003Ec__DisplayClass73_2.MimSeaar1lI = xlQIwNoLIqrGfmPmjCj.qiVgQqqkuN4(result);
						if (_003C_003Ec__DisplayClass73_2.MimSeaar1lI == null)
						{
							_003C_003Ec__DisplayClass73_2.MimSeaar1lI = new ChatSession
							{
								Id = result,
								ActionId = brhSeucyD7m.ActionId,
								CreateTime = DateTime.Now,
								Messages = new List<ChatMessage>(),
								LastMessageTime = DateTime.Now
							};
						}
					}
					string textParamValue9 = XActionHelper.GetTextParamValue(B4LgIeAVust, EVvSe2W7Xjt, brhSeucyD7m);
					if (textParamValue9 == null)
					{
						obj = null;
					}
					else
					{
						obj = textParamValue9.Trim();
						if (obj != null)
						{
							goto IL_0cce;
						}
					}
					obj = "";
					goto IL_0cce;
				}
				IL_1129:
				return (isSuccess: false, message: (string)obj2, failReason: ActionStopFlag.OperationFailed);
				IL_0cce:
				text5 = (string)obj;
				if (!string.IsNullOrWhiteSpace(text5))
				{
					if (text5.StartsWith("["))
					{
						IList<ChatMessage> list = JsonConvert.DeserializeObject<IList<ChatMessage>>(text5);
						if (list == null)
						{
							return (isSuccess: false, message: "历史消息格式不正确", failReason: ActionStopFlag.OperationFailed);
						}
						foreach (ChatMessage item2 in list)
						{
							_003C_003Ec__DisplayClass73_2.O2ySeyApyIx.Messages.Add(item2);
						}
					}
					else
					{
						if (!int.TryParse(text5, out var result3))
						{
							return (isSuccess: false, message: "不支持的历史消息格式。 请使用JSON文本或整数。", failReason: ActionStopFlag.OperationFailed);
						}
						if (result == Guid.Empty)
						{
							return (isSuccess: false, message: "未设定会话ID时，不支持指定指定历史消息条数。", failReason: ActionStopFlag.OperationFailed);
						}
						if (_003C_003Ec__DisplayClass73_2.MimSeaar1lI != null)
						{
							_003C_003Ec__DisplayClass73_2.O2ySeyApyIx.Messages.AddRange(_003C_003Ec__DisplayClass73_2.MimSeaar1lI.Messages.TakeLast(result3));
						}
					}
				}
				if (!string.IsNullOrWhiteSpace(textParamValue5))
				{
					if (_003C_003Ec__DisplayClass73_2.O2ySeyApyIx.Messages.Count > 0)
					{
						brhSeucyD7m.ActionLogger.LogInfo("已有历史消息，不再发送系统提示。");
					}
					else
					{
						ChatMessage item = new ChatMessage(ChatMessageRole.System, textParamValue5);
						_003C_003Ec__DisplayClass73_2.O2ySeyApyIx.Messages.Add(item);
						_003C_003Ec__DisplayClass73_2.MimSeaar1lI?.Messages.Add(item);
					}
				}
				chatMessage = null;
				if (text2 != null)
				{
					text2 = text2.Trim();
					if (text2.StartsWith("[") && text2.EndsWith("]"))
					{
						IList<ChatMessage.ContentItem> list2 = JsonConvert.DeserializeObject<IList<ChatMessage.ContentItem>>(text2);
						chatMessage = ((list2 == null || !list2.All(_003C_003Ec.n3eSevWLsCk ?? (_003C_003Ec.n3eSevWLsCk = _003C_003Ec.PU4SeLgE75K.bbVSegp9BFU))) ? new ChatMessage(ChatMessageRole.User, text2) : new ChatMessage
						{
							Role = ChatMessageRole.User,
							ListContent = list2
						});
					}
					else
					{
						chatMessage = new ChatMessage(ChatMessageRole.User, text2);
					}
				}
				else
				{
					if (paramValue == null)
					{
						throw new ArgumentException("未提供提示内容");
					}
					chatMessage = new ChatMessage
					{
						Role = ChatMessageRole.User,
						ObjectContent = paramValue
					};
				}
				_003C_003Ec__DisplayClass73_2.O2ySeyApyIx.Messages.Add(chatMessage);
				_003C_003Ec__DisplayClass73_2.MimSeaar1lI?.Messages.Add(chatMessage);
				if (!booleanParamValue2)
				{
					ChatResult result4 = _003C_003Ec__DisplayClass73_2.lsTSe7hnd8x.scnSe0m4VBT.Chat.CreateChatCompletionAsync(_003C_003Ec__DisplayClass73_2.O2ySeyApyIx, _003C_003Ec__DisplayClass73_2.TugSe8afy8T).GetAwaiter().GetResult();
					if (result4 == null)
					{
						return (isSuccess: false, message: "未能获得响应", failReason: ActionStopFlag.OperationFailed);
					}
					if (!result4.Successful)
					{
						Error error = result4.Error;
						if (error == null)
						{
							obj2 = null;
						}
						else
						{
							obj2 = error.Message;
							if (obj2 != null)
							{
								goto IL_1129;
							}
						}
						obj2 = "服务端返回错误。";
						goto IL_1129;
					}
					string text6 = result4.Choices[0].Message.TextContent ?? "";
					string result5 = result4.Choices[0].Message.ReasoningContent ?? "";
					_003C_003Ec__DisplayClass73_2.MimSeaar1lI?.Messages.Add(new ChatMessage(ChatMessageRole.Assistant, text6));
					XActionHelper.OutputResult(a54gIQuZ74p, EVvSe2W7Xjt, brhSeucyD7m, text6, HxXSeJdEEZr);
					XActionHelper.OutputResult(IlfgIjrmjUO, EVvSe2W7Xjt, brhSeucyD7m, result5, HxXSeJdEEZr);
					XActionHelper.OutputResult(XRbgInkc6UJ, EVvSe2W7Xjt, brhSeucyD7m, result4.RawResponse, HxXSeJdEEZr);
					XActionHelper.OutputResult(KGdgI4KYAnA, EVvSe2W7Xjt, brhSeucyD7m, result4.Usage?.PromptTokens ?? 0, HxXSeJdEEZr);
					XActionHelper.OutputResult(D7ogI50kmHk, EVvSe2W7Xjt, brhSeucyD7m, result4.Usage?.CompletionTokens ?? 0, HxXSeJdEEZr);
					XActionHelper.OutputResult(diogIDAFm12, EVvSe2W7Xjt, brhSeucyD7m, result4.Usage?.TotalTokens ?? 0, HxXSeJdEEZr);
					XActionHelper.OutputResult(JrGgIdwySLX, EVvSe2W7Xjt, brhSeucyD7m, result4.Choices[0].FinishReason, HxXSeJdEEZr);
				}
				else
				{
					_003C_003Ec__DisplayClass73_3 _003C_003Ec__DisplayClass73_4 = new _003C_003Ec__DisplayClass73_3
					{
						KZISehstl5S = _003C_003Ec__DisplayClass73_2,
						Gg5Se9agt8O = new AutoResetEvent(false),
						KAqSeVemTYR = new StringBuilder(),
						IfNSecd1AZB = new StringBuilder(),
						tPPSeqXgSsV = null,
						xoFSeZZYUM1 = null
					};
					Task.Run((Func<Task>)_003C_003Ec__DisplayClass73_4.K9WSeRm9p97);
					_003C_003Ec__DisplayClass73_4.Gg5Se9agt8O.WaitOne(TimeSpan.FromSeconds(numberParamValue));
					if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass73_4.xoFSeZZYUM1))
					{
						return (isSuccess: false, message: _003C_003Ec__DisplayClass73_4.xoFSeZZYUM1, failReason: ActionStopFlag.OperationFailed);
					}
					if (_003C_003Ec__DisplayClass73_4.tPPSeqXgSsV != null && !_003C_003Ec__DisplayClass73_4.tPPSeqXgSsV.Successful)
					{
						return (isSuccess: false, message: "服务器返回错误：" + _003C_003Ec__DisplayClass73_4.tPPSeqXgSsV.Error?.Message, failReason: ActionStopFlag.OperationFailed);
					}
					string text7 = _003C_003Ec__DisplayClass73_4.KAqSeVemTYR.ToString();
					if (text7.Length > 0)
					{
						_003C_003Ec__DisplayClass73_4.KZISehstl5S.MimSeaar1lI?.Messages.Add(new ChatMessage(ChatMessageRole.Assistant, text7));
					}
					XActionHelper.OutputResult(a54gIQuZ74p, EVvSe2W7Xjt, brhSeucyD7m, text7, HxXSeJdEEZr);
					XActionHelper.OutputResult(XRbgInkc6UJ, EVvSe2W7Xjt, brhSeucyD7m, "", HxXSeJdEEZr);
					XActionHelper.OutputResult(IlfgIjrmjUO, EVvSe2W7Xjt, brhSeucyD7m, _003C_003Ec__DisplayClass73_4.IfNSecd1AZB.ToString(), HxXSeJdEEZr);
					XActionHelper.OutputResult(KGdgI4KYAnA, EVvSe2W7Xjt, brhSeucyD7m, 0, HxXSeJdEEZr);
					XActionHelper.OutputResult(D7ogI50kmHk, EVvSe2W7Xjt, brhSeucyD7m, 0, HxXSeJdEEZr);
					XActionHelper.OutputResult(diogIDAFm12, EVvSe2W7Xjt, brhSeucyD7m, 0, HxXSeJdEEZr);
					XActionHelper.OutputResult(JrGgIdwySLX, EVvSe2W7Xjt, brhSeucyD7m, "", HxXSeJdEEZr);
				}
				XActionHelper.OutputResultIfNeeded(fAbgITW2Ha2, _003C_003Ec__DisplayClass73_2.MovSeEFlM7G, EVvSe2W7Xjt, brhSeucyD7m, HxXSeJdEEZr);
				if (_003C_003Ec__DisplayClass73_2.MimSeaar1lI != null)
				{
					_003C_003Ec__DisplayClass73_2.MimSeaar1lI.LastMessageTime = DateTime.Now;
					xlQIwNoLIqrGfmPmjCj.Save(_003C_003Ec__DisplayClass73_2.MimSeaar1lI);
				}
				break;
				IL_0815:
				return (isSuccess: false, message: (string)obj3, failReason: ActionStopFlag.OperationFailed);
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool HFF2p3WLo5D4ZD9NNsKG()
		{
			return mlZ05jWLunmkmHGhqG8c == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass73_1
	{
		public OpenAIAPI scnSe0m4VBT;

		public string WCiSeCg3oBn;

		public _003C_003Ec__DisplayClass73_0 pwXSePFx2u7;

		private static _003C_003Ec__DisplayClass73_1 tQevEIWLbOKlo1j0Rrrg;

		static _003C_003Ec__DisplayClass73_1()
		{
		}

		internal static bool QnWvLVWLqImaOdKI6lYZ()
		{
			return tQevEIWLbOKlo1j0Rrrg == null;
		}

		internal static void TSg9kuWLlmLiKvSp4QYn()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass73_2
	{
		public ChatRequest O2ySeyApyIx;

		public IDictionary<string, object> TugSe8afy8T;

		public ChatSession MimSeaar1lI;

		public _003C_003Ec__DisplayClass73_1 lsTSe7hnd8x;

		private static _003C_003Ec__DisplayClass73_2 VRNdyCWLZaCNCxbu114h;

		internal object MovSeEFlM7G()
		{
			ChatSession chatSession = MimSeaar1lI;
			object obj;
			if (chatSession == null)
			{
				obj = null;
			}
			else
			{
				obj = chatSession.Messages;
				if (obj != null)
				{
					goto IL_0017;
				}
			}
			obj = null;
			goto IL_0017;
			IL_0017:
			return obj;
		}

		internal static bool rm0X89WL5FwlKCUaNZaw()
		{
			return VRNdyCWLZaCNCxbu114h == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass73_3
	{
		[StructLayout(LayoutKind.Auto)]
		private struct mSBJ01kFiNBI4ro3Omv : IAsyncStateMachine
		{
			public int htU2cpRPhG4;

			public AsyncTaskMethodBuilder AUf2cBmwHPw;

			public _003C_003Ec__DisplayClass73_3 Hxh2cQhs1ZG;

			private IntPtr FmQ2cjTmOwy;

			private bool lm52cnaufXB;

			private IAsyncEnumerator<ChatResult> iKG2c4qgVPs;

			private object LKK2c5XoMan;

			private int SvJ2cD5vnFG;

			private ValueTaskAwaiter<bool> UKa2cdDxNxk;

			private ValueTaskAwaiter D3Y2coO9Vy9;

			internal static object JNwCmYyb3JLD5QZnpWN0;

			private void MoveNext()
			{
				int num = htU2cpRPhG4;
				_003C_003Ec__DisplayClass73_3 _003C_003Ec__DisplayClass73_ = Hxh2cQhs1ZG;
				try
				{
					if ((uint)num > 1u)
					{
						FmQ2cjTmOwy = IntPtr.Zero;
					}
					try
					{
						ValueTaskAwaiter awaiter = default(ValueTaskAwaiter);
						int num2;
						if (num != 0)
						{
							if (num == 1)
							{
								awaiter = D3Y2coO9Vy9;
								D3Y2coO9Vy9 = default(ValueTaskAwaiter);
								num2 = 1;
								if (JNwCmYyb3JLD5QZnpWN0 != null)
								{
									int num3 = default(int);
									num2 = num3;
								}
								goto IL_04c0;
							}
							lm52cnaufXB = false;
							iKG2c4qgVPs = _003C_003Ec__DisplayClass73_.KZISehstl5S.lsTSe7hnd8x.scnSe0m4VBT.Chat.StreamChatEnumerableAsync(_003C_003Ec__DisplayClass73_.KZISehstl5S.O2ySeyApyIx, _003C_003Ec__DisplayClass73_.KZISehstl5S.TugSe8afy8T).GetAsyncEnumerator(default(CancellationToken));
							LKK2c5XoMan = null;
							SvJ2cD5vnFG = 0;
						}
						try
						{
							if (num != 0)
							{
								goto IL_03b8;
							}
							ValueTaskAwaiter<bool> awaiter2 = UKa2cdDxNxk;
							UKa2cdDxNxk = default(ValueTaskAwaiter<bool>);
							num = -1;
							htU2cpRPhG4 = -1;
							goto IL_03d7;
							IL_03b8:
							awaiter2 = iKG2c4qgVPs.MoveNextAsync().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = 0;
								htU2cpRPhG4 = 0;
								UKa2cdDxNxk = awaiter2;
								AUf2cBmwHPw.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_03d7;
							IL_03d7:
							if (awaiter2.GetResult())
							{
								int num5 = default(int);
								while (true)
								{
									ChatResult current = iKG2c4qgVPs.Current;
									_003C_003Ec__DisplayClass73_4 _003C_003Ec__DisplayClass73_2 = new _003C_003Ec__DisplayClass73_4
									{
										yUvSeIZ0m1c = _003C_003Ec__DisplayClass73_
									};
									int num4;
									if (current.Successful)
									{
										if (_003C_003Ec__DisplayClass73_.KZISehstl5S.lsTSe7hnd8x.pwXSePFx2u7.brhSeucyD7m.IsShouldStopAction())
										{
											break;
										}
										CancellationToken? cancellationToken = _003C_003Ec__DisplayClass73_.KZISehstl5S.lsTSe7hnd8x.pwXSePFx2u7.brhSeucyD7m.CancellationToken;
										if (cancellationToken.HasValue && cancellationToken.GetValueOrDefault().IsCancellationRequested)
										{
											break;
										}
										if (current.Choices != null && current.Choices.Count != 0)
										{
											_003C_003Ec__DisplayClass73_2.evmSeYeGQsm = current.Choices[0].Delta.TextContent;
											if (_003C_003Ec__DisplayClass73_2.evmSeYeGQsm.IsNullOrEmpty())
											{
												if (current.Choices[0].Delta.ReasoningContent.IsNullOrEmpty())
												{
													goto IL_03b8;
												}
												_003C_003Ec__DisplayClass73_2.evmSeYeGQsm = current.Choices[0].Delta.ReasoningContent;
												_003C_003Ec__DisplayClass73_.IfNSecd1AZB.Append(_003C_003Ec__DisplayClass73_2.evmSeYeGQsm);
												if (!lm52cnaufXB)
												{
													lm52cnaufXB = true;
													_003C_003Ec__DisplayClass73_2.evmSeYeGQsm = "<think>\r\n" + _003C_003Ec__DisplayClass73_2.evmSeYeGQsm;
												}
											}
											else
											{
												_003C_003Ec__DisplayClass73_.KAqSeVemTYR.Append(_003C_003Ec__DisplayClass73_2.evmSeYeGQsm);
												if (lm52cnaufXB)
												{
													lm52cnaufXB = false;
													_003C_003Ec__DisplayClass73_2.evmSeYeGQsm = "\r\n</think>\r\n" + _003C_003Ec__DisplayClass73_2.evmSeYeGQsm;
												}
											}
											if (_003C_003Ec__DisplayClass73_.KZISehstl5S.lsTSe7hnd8x.WCiSeCg3oBn == "INPUT_TEXT" && FmQ2cjTmOwy == IntPtr.Zero)
											{
												num4 = 1;
												if (JNwCmYyb3JLD5QZnpWN0 == null)
												{
													goto IL_02b6;
												}
												goto IL_02e8;
											}
											goto IL_02f3;
										}
										goto IL_03b8;
									}
									_003C_003Ec__DisplayClass73_.tPPSeqXgSsV = current;
									break;
									IL_0386:
									AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass73_2.R7XSeeYetyx);
									goto IL_039b;
									IL_02b6:
									switch (num4)
									{
									case 4:
										break;
									case 1:
										goto IL_02e8;
									case 3:
										continue;
									default:
										goto IL_0386;
									case 2:
										goto IL_039b;
									}
									goto IL_02d4;
									IL_02e8:
									FmQ2cjTmOwy = NativeMethods.GetForegroundWindow();
									goto IL_02f3;
									IL_02f3:
									if (!_003C_003Ec__DisplayClass73_.KZISehstl5S.lsTSe7hnd8x.WCiSeCg3oBn.IsNullOrWhiteSpace())
									{
										if (_003C_003Ec__DisplayClass73_.KZISehstl5S.lsTSe7hnd8x.WCiSeCg3oBn == "INPUT_TEXT")
										{
											goto IL_02d4;
										}
										goto IL_0386;
									}
									goto IL_039b;
									IL_02d4:
									if (!(NativeMethods.GetForegroundWindow() == FmQ2cjTmOwy))
									{
										num4 = 2;
										if (!iUFsHqybEPbDEQ6V0H6y())
										{
											num4 = num5;
										}
										goto IL_02b6;
									}
									_003C_003Ec__DisplayClass73_2.evmSeYeGQsm = _003C_003Ec__DisplayClass73_2.evmSeYeGQsm.Replace("\r", "");
									if (_003C_003Ec__DisplayClass73_2.evmSeYeGQsm.Length > 0)
									{
										InputSimulator.Instance.Keyboard.TextEntry(_003C_003Ec__DisplayClass73_2.evmSeYeGQsm);
									}
									goto IL_039b;
									IL_039b:
									if (_003C_003Ec__DisplayClass73_.KZISehstl5S.lsTSe7hnd8x.pwXSePFx2u7.brhSeucyD7m.IsShouldStopAction())
									{
										break;
									}
									goto IL_03b8;
								}
							}
						}
						catch (Exception lKK2c5XoMan)
						{
							LKK2c5XoMan = lKK2c5XoMan;
						}
						if (iKG2c4qgVPs == null)
						{
							goto IL_046f;
						}
						awaiter = iKG2c4qgVPs.DisposeAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 1;
							htU2cpRPhG4 = 1;
							D3Y2coO9Vy9 = awaiter;
							AUf2cBmwHPw.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_04a1;
						IL_046f:
						object obj = LKK2c5XoMan;
						if (obj != null)
						{
							ExceptionDispatchInfo.Capture((obj as Exception) ?? throw ((Exception)obj)).Throw();
						}
						LKK2c5XoMan = null;
						iKG2c4qgVPs = null;
						num2 = 0;
						if (!iUFsHqybEPbDEQ6V0H6y())
						{
							goto IL_04c0;
						}
						goto end_IL_0021;
						IL_04c0:
						switch (num2)
						{
						case 1:
							num = -1;
							htU2cpRPhG4 = -1;
							break;
						default:
							goto end_IL_0021;
						case 0:
							goto end_IL_0021;
						}
						goto IL_04a1;
						IL_04a1:
						awaiter.GetResult();
						goto IL_046f;
						end_IL_0021:;
					}
					catch (Exception ex)
					{
						_003C_003Ec__DisplayClass73_.xoFSeZZYUM1 = ex.GetMessageWithInner();
						E0fgI7MYkxy.Warn(ex.Message, ex);
					}
					finally
					{
						if (num < 0)
						{
							_003C_003Ec__DisplayClass73_.Gg5Se9agt8O.Set();
						}
					}
				}
				catch (Exception exception)
				{
					htU2cpRPhG4 = -2;
					AUf2cBmwHPw.SetException(exception);
					return;
				}
				htU2cpRPhG4 = -2;
				AUf2cBmwHPw.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				AUf2cBmwHPw.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool iUFsHqybEPbDEQ6V0H6y()
			{
				return JNwCmYyb3JLD5QZnpWN0 == null;
			}
		}

		public ChatResult tPPSeqXgSsV;

		public StringBuilder IfNSecd1AZB;

		public StringBuilder KAqSeVemTYR;

		public string xoFSeZZYUM1;

		public AutoResetEvent Gg5Se9agt8O;

		public _003C_003Ec__DisplayClass73_2 KZISehstl5S;

		internal static _003C_003Ec__DisplayClass73_3 Uctq3bWL8K5NhJAy3XWd;

		[AsyncStateMachine(typeof(mSBJ01kFiNBI4ro3Omv))]
		internal Task K9WSeRm9p97()
		{
			mSBJ01kFiNBI4ro3Omv stateMachine = default(mSBJ01kFiNBI4ro3Omv);
			stateMachine.AUf2cBmwHPw = AsyncTaskMethodBuilder.Create();
			stateMachine.Hxh2cQhs1ZG = this;
			stateMachine.htU2cpRPhG4 = -1;
			stateMachine.AUf2cBmwHPw.Start(ref stateMachine);
			return stateMachine.AUf2cBmwHPw.Task;
		}

		internal static bool FHRbMuWLRht7S3BnQe4X()
		{
			return Uctq3bWL8K5NhJAy3XWd == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass73_4
	{
		public string evmSeYeGQsm;

		public _003C_003Ec__DisplayClass73_3 yUvSeIZ0m1c;

		private static _003C_003Ec__DisplayClass73_4 BvC9hbWLPsFpVbK2cZP5;

		internal void R7XSeeYetyx()
		{
			foreach (TextWindow item in AppHelper.FindRootWindows<TextWindow>())
			{
				if (item.AutoCloseKey == yUvSeIZ0m1c.KZISehstl5S.lsTSe7hnd8x.WCiSeCg3oBn && item.IsLoaded)
				{
					item.FWqgU6u114f(evmSeYeGQsm);
				}
			}
		}

		internal static bool FsmIaAWLMo00xxkSKfCG()
		{
			return BvC9hbWLPsFpVbK2cZP5 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass73_5
	{
		[StructLayout(LayoutKind.Auto)]
		private struct op12GHkv64XL1ev22Hh : IAsyncStateMachine
		{
			public int Kum2cTgB4KO;

			public AsyncTaskMethodBuilder aKF2cMuU0Wa;

			public _003C_003Ec__DisplayClass73_5 OWH2cAr8FHZ;

			private IntPtr rPe2cOBStW6;

			private IAsyncEnumerator<CompletionResult> EhL2cFymS3C;

			private object vpJ2cUS3DqU;

			private int s622clgiO3v;

			private ValueTaskAwaiter<bool> x5W2ciNErrV;

			private ValueTaskAwaiter Nkh2c3EF1dt;

			private static object JRqAknyb1cje0pT1iUbr;

			private void MoveNext()
			{
				int num = Kum2cTgB4KO;
				_003C_003Ec__DisplayClass73_5 _003C_003Ec__DisplayClass73_ = OWH2cAr8FHZ;
				try
				{
					if ((uint)num > 1u)
					{
						rPe2cOBStW6 = IntPtr.Zero;
					}
					try
					{
						ValueTaskAwaiter awaiter = default(ValueTaskAwaiter);
						int num2;
						if (num != 0)
						{
							if (num == 1)
							{
								awaiter = Nkh2c3EF1dt;
								num2 = 0;
								if (!nbGGIoybKTiGPyHFQbFd())
								{
									int num3 = default(int);
									num2 = num3;
								}
								goto IL_029d;
							}
							EhL2cFymS3C = _003C_003Ec__DisplayClass73_.yJNSeb0k96H.scnSe0m4VBT.Completions.StreamCompletionEnumerableAsync(_003C_003Ec__DisplayClass73_.jyASek4yVoB).GetAsyncEnumerator(default(CancellationToken));
							vpJ2cUS3DqU = null;
							s622clgiO3v = 0;
						}
						try
						{
        _003C_003Ec__DisplayClass73_6 _003C_003Ec__DisplayClass73_2 = default;
							if (num != 0)
							{
								goto IL_0202;
							}
							ValueTaskAwaiter<bool> awaiter2 = x5W2ciNErrV;
							x5W2ciNErrV = default(ValueTaskAwaiter<bool>);
							num = -1;
							Kum2cTgB4KO = -1;
							goto IL_023a;
							IL_0202:
							awaiter2 = EhL2cFymS3C.MoveNextAsync().GetAwaiter();
							int num4 = 0;
							if (nbGGIoybKTiGPyHFQbFd())
							{
								goto IL_0194;
							}
							goto IL_0228;
							IL_023a:
							_003C_003Ec__DisplayClass73_2 = default(_003C_003Ec__DisplayClass73_6);
							if (awaiter2.GetResult())
							{
								CompletionResult current = EhL2cFymS3C.Current;
								_003C_003Ec__DisplayClass73_2 = new _003C_003Ec__DisplayClass73_6
								{
									mr7SemCG9ZH = _003C_003Ec__DisplayClass73_
								};
								if (current.Successful)
								{
									_003C_003Ec__DisplayClass73_2.LO1SeXMOn61 = current.Completions[0].Text;
									if (_003C_003Ec__DisplayClass73_2.LO1SeXMOn61.IsNullOrEmpty())
									{
										goto IL_0202;
									}
									if (_003C_003Ec__DisplayClass73_.yJNSeb0k96H.WCiSeCg3oBn == "INPUT_TEXT" && rPe2cOBStW6 == IntPtr.Zero)
									{
										rPe2cOBStW6 = NativeMethods.GetForegroundWindow();
									}
									_003C_003Ec__DisplayClass73_.Uq8Sesllild.Append(_003C_003Ec__DisplayClass73_2.LO1SeXMOn61);
									if (_003C_003Ec__DisplayClass73_.yJNSeb0k96H.WCiSeCg3oBn.IsNullOrWhiteSpace())
									{
										goto IL_01ea;
									}
									if (!(_003C_003Ec__DisplayClass73_.yJNSeb0k96H.WCiSeCg3oBn == "INPUT_TEXT"))
									{
										goto IL_01d5;
									}
									num4 = 1;
									if (nbGGIoybKTiGPyHFQbFd())
									{
										goto IL_0194;
									}
									goto IL_0228;
								}
								_003C_003Ec__DisplayClass73_.pB0SeGdpaw3 = current;
							}
							goto end_IL_008e;
							IL_0228:
							int num5 = default(int);
							num4 = num5;
							goto IL_0194;
							IL_01d5:
							AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass73_2.Od9Se6mVdxj);
							goto IL_01ea;
							IL_0194:
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_01d5;
							default:
								goto IL_0231;
							}
							if (NativeMethods.GetForegroundWindow() == rPe2cOBStW6)
							{
								InputSimulator.Instance.Keyboard.TextEntry(_003C_003Ec__DisplayClass73_2.LO1SeXMOn61);
							}
							goto IL_01ea;
							IL_0231:
							if (!awaiter2.IsCompleted)
							{
								num = 0;
								Kum2cTgB4KO = 0;
								x5W2ciNErrV = awaiter2;
								aKF2cMuU0Wa.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_023a;
							IL_01ea:
							if (!_003C_003Ec__DisplayClass73_.yJNSeb0k96H.pwXSePFx2u7.brhSeucyD7m.IsShouldStopAction())
							{
								goto IL_0202;
							}
							end_IL_008e:;
						}
						catch (Exception obj)
						{
							vpJ2cUS3DqU = obj;
						}
						if (EhL2cFymS3C != null)
						{
							num2 = 0;
							if (!nbGGIoybKTiGPyHFQbFd())
							{
								goto IL_029d;
							}
							goto IL_02c2;
						}
						goto IL_030d;
						IL_02c2:
						awaiter = EhL2cFymS3C.DisposeAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 1;
							Kum2cTgB4KO = 1;
							Nkh2c3EF1dt = awaiter;
							aKF2cMuU0Wa.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0306;
						IL_029d:
						switch (num2)
						{
						case 1:
							goto IL_02c2;
						}
						Nkh2c3EF1dt = default(ValueTaskAwaiter);
						num = -1;
						Kum2cTgB4KO = -1;
						goto IL_0306;
						IL_030d:
						object obj2 = vpJ2cUS3DqU;
						if (obj2 != null)
						{
							ExceptionDispatchInfo.Capture((obj2 as Exception) ?? throw ((Exception)obj2)).Throw();
						}
						vpJ2cUS3DqU = null;
						EhL2cFymS3C = null;
						goto end_IL_0021;
						IL_0306:
						awaiter.GetResult();
						goto IL_030d;
						end_IL_0021:;
					}
					catch (Exception exception)
					{
						_003C_003Ec__DisplayClass73_.GDpSeHpJS7f = exception.GetMessageWithInner();
					}
					finally
					{
						if (num < 0)
						{
							_003C_003Ec__DisplayClass73_.iTDSe1kCQW2.Set();
						}
					}
				}
				catch (Exception exception2)
				{
					Kum2cTgB4KO = -2;
					aKF2cMuU0Wa.SetException(exception2);
					return;
				}
				Kum2cTgB4KO = -2;
				aKF2cMuU0Wa.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				aKF2cMuU0Wa.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool nbGGIoybKTiGPyHFQbFd()
			{
				return JRqAknyb1cje0pT1iUbr == null;
			}
		}

		public CompletionRequest jyASek4yVoB;

		public CompletionResult pB0SeGdpaw3;

		public StringBuilder Uq8Sesllild;

		public string GDpSeHpJS7f;

		public AutoResetEvent iTDSe1kCQW2;

		public _003C_003Ec__DisplayClass73_1 yJNSeb0k96H;

		internal static _003C_003Ec__DisplayClass73_5 nT1axZWLxgRMyXgajBEc;

		[AsyncStateMachine(typeof(op12GHkv64XL1ev22Hh))]
		internal Task kYNSeW9qMLc()
		{
			op12GHkv64XL1ev22Hh stateMachine = default(op12GHkv64XL1ev22Hh);
			stateMachine.aKF2cMuU0Wa = AsyncTaskMethodBuilder.Create();
			stateMachine.OWH2cAr8FHZ = this;
			stateMachine.Kum2cTgB4KO = -1;
			stateMachine.aKF2cMuU0Wa.Start(ref stateMachine);
			return stateMachine.aKF2cMuU0Wa.Task;
		}

		internal static bool sdSuCyWLIbRVJEQe07nq()
		{
			return nT1axZWLxgRMyXgajBEc == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass73_6
	{
		public string LO1SeXMOn61;

		public _003C_003Ec__DisplayClass73_5 mr7SemCG9ZH;

		internal static _003C_003Ec__DisplayClass73_6 b8su8jWLtkJojQV7QbDg;

		internal void Od9Se6mVdxj()
		{
			foreach (TextWindow item in AppHelper.FindRootWindows<TextWindow>())
			{
				if (item.AutoCloseKey == mr7SemCG9ZH.yJNSeb0k96H.WCiSeCg3oBn && item.IsLoaded)
				{
					item.FWqgU6u114f(LO1SeXMOn61);
					break;
				}
			}
		}

		internal static bool glKqaYWLS0wRbOC9MCj8()
		{
			return b8su8jWLtkJojQV7QbDg == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass73_7
	{
		[StructLayout(LayoutKind.Auto)]
		private struct FBhsKdkNV3AmiC2alDc : IAsyncStateMachine
		{
			public int QSs2cfpRBDi;

			public AsyncTaskMethodBuilder WvR2czxpTl3;

			public _003C_003Ec__DisplayClass73_7 LXj2VwXEYbR;

			private IntPtr qAU2VtgGyiA;

			private IAsyncEnumerator<CompletionResult> iCM2Vgv2IiV;

			private object MTo2VLaLExL;

			private int L4t2VvI7Kgb;

			private ValueTaskAwaiter<bool> WSq2VScSkbK;

			private ValueTaskAwaiter T4U2V2MGeIe;

			private static object oxvpScybJN85BdW5FvDO;

			private void MoveNext()
			{
				int num = QSs2cfpRBDi;
				_003C_003Ec__DisplayClass73_7 _003C_003Ec__DisplayClass73_ = LXj2VwXEYbR;
				try
				{
					int num2;
					ValueTaskAwaiter awaiter = default(ValueTaskAwaiter);
					if (num != 0)
					{
						if (num != 1)
						{
							qAU2VtgGyiA = IntPtr.Zero;
							num2 = 0;
							if (!p3dQCsybk2OFPLRR9ytG())
							{
								goto IL_0047;
							}
						}
						else
						{
							awaiter = T4U2V2MGeIe;
							num2 = 1;
							if (oxvpScybJN85BdW5FvDO != null)
							{
								goto IL_0047;
							}
						}
						goto IL_0048;
					}
					goto IL_00b0;
					IL_02b3:
					object obj = MTo2VLaLExL;
					if (obj != null)
					{
						ExceptionDispatchInfo.Capture((obj as Exception) ?? throw ((Exception)obj)).Throw();
					}
					MTo2VLaLExL = null;
					iCM2Vgv2IiV = null;
					_003C_003Ec__DisplayClass73_.N1ISepJMKOs.Set();
					goto end_IL_000e;
					IL_02ac:
					awaiter.GetResult();
					goto IL_02b3;
					IL_00b0:
					try
					{
						if (num != 0)
						{
							goto IL_0208;
						}
						ValueTaskAwaiter<bool> awaiter2 = WSq2VScSkbK;
						WSq2VScSkbK = default(ValueTaskAwaiter<bool>);
						num = -1;
						QSs2cfpRBDi = -1;
						goto IL_0227;
						IL_0208:
						awaiter2 = iCM2Vgv2IiV.MoveNextAsync().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 0;
							QSs2cfpRBDi = 0;
							WSq2VScSkbK = awaiter2;
							WvR2czxpTl3.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_0227;
						IL_0227:
						if (awaiter2.GetResult())
						{
							while (true)
							{
								CompletionResult current = iCM2Vgv2IiV.Current;
								_003C_003Ec__DisplayClass73_8 _003C_003Ec__DisplayClass73_2 = new _003C_003Ec__DisplayClass73_8
								{
									ErUSeniDtIp = _003C_003Ec__DisplayClass73_,
									OVISejmE1D2 = current.Completions[0].Text
								};
								if (_003C_003Ec__DisplayClass73_2.OVISejmE1D2.IsNullOrEmpty())
								{
									break;
								}
								if (_003C_003Ec__DisplayClass73_.gBUSeBlmCkp.WCiSeCg3oBn == "INPUT_TEXT" && qAU2VtgGyiA == IntPtr.Zero)
								{
									qAU2VtgGyiA = NativeMethods.GetForegroundWindow();
								}
								_003C_003Ec__DisplayClass73_.ALWSercQRvJ.Append(_003C_003Ec__DisplayClass73_2.OVISejmE1D2);
								if (!_003C_003Ec__DisplayClass73_.gBUSeBlmCkp.WCiSeCg3oBn.IsNullOrWhiteSpace())
								{
									if (oxvpScybJN85BdW5FvDO != null)
									{
										switch (0)
										{
										case 1:
											goto IL_019a;
										case 2:
											goto IL_01dc;
										}
										continue;
									}
									goto IL_019a;
								}
								goto IL_01f1;
								IL_01dc:
								AppHelper.RunOnUiThread(false, _003C_003Ec__DisplayClass73_2.e4KSeQTHxxN);
								goto IL_01f1;
								IL_01f1:
								if (!_003C_003Ec__DisplayClass73_.gBUSeBlmCkp.pwXSePFx2u7.brhSeucyD7m.IsShouldStopAction())
								{
									break;
								}
								goto end_IL_00b0;
								IL_019a:
								if (!(_003C_003Ec__DisplayClass73_.gBUSeBlmCkp.WCiSeCg3oBn == "INPUT_TEXT"))
								{
									goto IL_01dc;
								}
								if (NativeMethods.GetForegroundWindow() == qAU2VtgGyiA)
								{
									InputSimulator.Instance.Keyboard.TextEntry(_003C_003Ec__DisplayClass73_2.OVISejmE1D2);
								}
								goto IL_01f1;
							}
							goto IL_0208;
						}
						end_IL_00b0:;
					}
					catch (Exception mTo2VLaLExL)
					{
						MTo2VLaLExL = mTo2VLaLExL;
					}
					if (iCM2Vgv2IiV != null)
					{
						awaiter = iCM2Vgv2IiV.DisposeAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 1;
							QSs2cfpRBDi = 1;
							T4U2V2MGeIe = awaiter;
							WvR2czxpTl3.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_02ac;
					}
					goto IL_02b3;
					IL_0047:
					int num3 = default(int);
					num2 = num3;
					goto IL_0048;
					IL_0048:
					switch (num2)
					{
					case 1:
						goto IL_0095;
					}
					iCM2Vgv2IiV = _003C_003Ec__DisplayClass73_.gBUSeBlmCkp.scnSe0m4VBT.Completions.StreamCompletionEnumerableAsync(_003C_003Ec__DisplayClass73_.ba2SexVxFE9).GetAsyncEnumerator(default(CancellationToken));
					MTo2VLaLExL = null;
					L4t2VvI7Kgb = 0;
					goto IL_00b0;
					IL_0095:
					T4U2V2MGeIe = default(ValueTaskAwaiter);
					num = -1;
					QSs2cfpRBDi = -1;
					goto IL_02ac;
					end_IL_000e:;
				}
				catch (Exception exception)
				{
					QSs2cfpRBDi = -2;
					WvR2czxpTl3.SetException(exception);
					return;
				}
				QSs2cfpRBDi = -2;
				WvR2czxpTl3.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				WvR2czxpTl3.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool p3dQCsybk2OFPLRR9ytG()
			{
				return oxvpScybJN85BdW5FvDO == null;
			}
		}

		public CompletionRequest ba2SexVxFE9;

		public StringBuilder ALWSercQRvJ;

		public AutoResetEvent N1ISepJMKOs;

		public _003C_003Ec__DisplayClass73_1 gBUSeBlmCkp;

		internal static _003C_003Ec__DisplayClass73_7 GdFwxgWLTksOjbprw6n3;

		[AsyncStateMachine(typeof(FBhsKdkNV3AmiC2alDc))]
		internal Task tDWSeKUcbB4()
		{
			FBhsKdkNV3AmiC2alDc stateMachine = default(FBhsKdkNV3AmiC2alDc);
			stateMachine.WvR2czxpTl3 = AsyncTaskMethodBuilder.Create();
			stateMachine.LXj2VwXEYbR = this;
			stateMachine.QSs2cfpRBDi = -1;
			stateMachine.WvR2czxpTl3.Start(ref stateMachine);
			return stateMachine.WvR2czxpTl3.Task;
		}

		static _003C_003Ec__DisplayClass73_7()
		{
		}

		internal static bool uOxqZWWLmCcrqKIDukqu()
		{
			return GdFwxgWLTksOjbprw6n3 == null;
		}

		internal static void CsYqPrWL7Qxdmjo99876()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass73_8
	{
		public string OVISejmE1D2;

		public _003C_003Ec__DisplayClass73_7 ErUSeniDtIp;

		private static _003C_003Ec__DisplayClass73_8 Wv13RQWL4HbuSW7kSoka;

		internal void e4KSeQTHxxN()
		{
			foreach (TextWindow item in AppHelper.FindRootWindows<TextWindow>())
			{
				if (item.AutoCloseKey == ErUSeniDtIp.gBUSeBlmCkp.WCiSeCg3oBn && item.IsLoaded)
				{
					item.FWqgU6u114f(OVISejmE1D2);
					break;
				}
			}
		}

		internal static void fqfmxAWLz1YXbmBRmDrq()
		{
		}

		internal static bool qPrqeCWLhh1snm850Cdc()
		{
			return Wv13RQWL4HbuSW7kSoka == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> lO9gICUZZIc = new string[1] { "ai" };

	[CompilerGenerated]
	private readonly string kI5gIPVvtkR = "Steps/common_step.png";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> X5DgIEDbB2w;

	[CompilerGenerated]
	private readonly string st8gIyLUiD3 = "https://getquicker.net/KC/Help/Doc/ai";

	[CompilerGenerated]
	private readonly bool oxLgI8QmNDs;

	[CompilerGenerated]
	private readonly bool FpXgIaZmc0q;

	private static readonly ILog E0fgI7MYkxy;

	private static readonly StepInParamDef IvQgIRYfDkT;

	private static readonly StepInParamDef uZKgIqEoF86;

	private static readonly StepInParamDef fXSgIco5HUS;

	private static readonly StepInParamDef mAagIV0eQa4;

	private static readonly StepInParamDef nxkgIZjTFGb;

	private static readonly StepInParamDef IBkgI9FrsyK;

	private static readonly StepInParamDef aCfgIhO4thC;

	private static readonly StepInParamDef B4LgIeAVust;

	private static readonly StepInParamDef etegIYA7r8K;

	private static readonly StepInParamDef SCYgIIjkPWU;

	private static readonly StepInParamDef PmBgIWKADX8;

	private static readonly StepInParamDef njEgIkZGi6u;

	private static readonly StepInParamDef RFvgIGucxnQ;

	private static readonly StepInParamDef WcPgIsMqN4Q;

	private static readonly StepInParamDef kMXgIHlqTjb;

	private static readonly StepInParamDef FtAgI17IMoj;

	private static readonly StepInParamDef WYcgIbRIWMJ;

	private static readonly StepInParamDef RM1gI619fIT;

	private static readonly StepInParamDef tw0gIX2XkVi;

	private static readonly StepInParamDef xnEgImpYiUY;

	private static readonly StepInParamDef FQUgIK5EhOr;

	private static readonly StepInParamDef DTygIxP6HIb;

	private static readonly StepInParamDef nE7gIre0eaD;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> A3KgIpGVMfp = new List<StepInParamDef>
	{
		IvQgIRYfDkT, uZKgIqEoF86, IBkgI9FrsyK, aCfgIhO4thC, B4LgIeAVust, etegIYA7r8K, mAagIV0eQa4, nxkgIZjTFGb, PmBgIWKADX8, njEgIkZGi6u,
		RFvgIGucxnQ, WcPgIsMqN4Q, FtAgI17IMoj, WYcgIbRIWMJ, tw0gIX2XkVi, fXSgIco5HUS, kMXgIHlqTjb, FQUgIK5EhOr, DTygIxP6HIb, xnEgImpYiUY,
		nE7gIre0eaD
	};

	private static readonly StepOutParamDef DI0gIBLb14f;

	private static readonly StepOutParamDef a54gIQuZ74p;

	private static readonly StepOutParamDef IlfgIjrmjUO;

	private static readonly StepOutParamDef XRbgInkc6UJ;

	private static readonly StepOutParamDef KGdgI4KYAnA;

	private static readonly StepOutParamDef D7ogI50kmHk;

	private static readonly StepOutParamDef diogIDAFm12;

	private static readonly StepOutParamDef JrGgIdwySLX;

	private static readonly StepOutParamDef e34gIoxh8Bc;

	private static readonly StepOutParamDef fAbgITW2Ha2;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> igjgIMIAQJa = new List<StepOutParamDef> { DI0gIBLb14f, a54gIQuZ74p, XRbgInkc6UJ, IlfgIjrmjUO, KGdgI4KYAnA, D7ogI50kmHk, diogIDAFm12, JrGgIdwySLX, fAbgITW2Ha2 };

	private static H4rLbTXtxuZjM4Su8vo ue8dV8QT87RkjeXmG5rB;

	public string Key => "sys:ai";

	public string Name => "AI 调用";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return lO9gICUZZIc;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return kI5gIPVvtkR;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Network;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return X5DgIEDbB2w;
		}
	}

	public string Description => "调用第三方AI服务";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return st8gIyLUiD3;
		}
	}

	public bool IsRisky
	{
		[CompilerGenerated]
		get
		{
			return oxLgI8QmNDs;
		}
	}

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return FpXgIaZmc0q;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return A3KgIpGVMfp;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return igjgIMIAQJa;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass73_0 _003C_003Ec__DisplayClass73_ = new _003C_003Ec__DisplayClass73_0();
		_003C_003Ec__DisplayClass73_.EVvSe2W7Xjt = step;
		_003C_003Ec__DisplayClass73_.brhSeucyD7m = context;
		_003C_003Ec__DisplayClass73_.F4sSeNfcfJp = this;
		_003C_003Ec__DisplayClass73_.HxXSeJdEEZr = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass73_.brhSeucyD7m, _003C_003Ec__DisplayClass73_.EVvSe2W7Xjt, _003C_003Ec__DisplayClass73_.HxXSeJdEEZr, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass73_.aslSeSkKxYi, (Action)null, (Action)null, nE7gIre0eaD, DI0gIBLb14f);
	}

	public string GetSummary(ActionStep step)
	{
		return "";
	}

	private HttpClient AfZgI0kUSiG(bool bool_2, string string_2, string string_3, ActionExecuteContext actionExecuteContext_0, int int_0 = 120)
	{
		WebRequestHandler webRequestHandler = new WebRequestHandler();
		webRequestHandler.CachePolicy = new HttpRequestCachePolicy(HttpRequestCacheLevel.BypassCache);
		if (bool_2)
		{
			(ProxyMode, string) tuple = AppHelper.ForceProxy(webRequestHandler);
			actionExecuteContext_0.ActionLogger.LogInfo($"强制代理使用情况：{tuple.Item1}, {tuple.Item2}");
		}
		else
		{
			AppHelper.ApplyProxy(webRequestHandler);
		}
		HttpClient httpClient = new HttpClient(webRequestHandler);
		httpClient.Timeout = TimeSpan.FromSeconds(int_0);
		httpClient.DefaultRequestHeaders.CacheControl = new CacheControlHeaderValue
		{
			NoCache = true
		};
		if (ue8dV8QT87RkjeXmG5rB != null)
		{
			switch (0)
			{
			}
		}
		httpClient.DefaultRequestHeaders.ExpectContinue = false;
		httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", string_2);
		httpClient.DefaultRequestHeaders.Add("api-key", string_2);
		httpClient.DefaultRequestHeaders.Add("User-Agent", "QuickerGptClient/" + AppHelper.GetSoftVersion());
		if (!string.IsNullOrEmpty(string_3))
		{
			httpClient.DefaultRequestHeaders.Add("OpenAI-Organization", string_3);
		}
		return httpClient;
	}

	static H4rLbTXtxuZjM4Su8vo()
	{
		E0fgI7MYkxy = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		IvQgIRYfDkT = new StepInParamDef
		{
			Key = "endpoint",
			Name = "接口端点",
			Description = "",
			DefaultValue = "chat",
			IsRequired = true,
			Type = VarType.Enum,
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("chat", "Chat"),
				new SelectionItem("completions", "Completions")
			},
			IsControlField = true
		};
		uZKgIqEoF86 = new StepInParamDef
		{
			Key = "model",
			Name = "模型",
			DefaultValue = "",
			Description = "适用于可能适用于不同的端点，请参考官方文档使用。",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.Input,
			IsAdvanced = false,
			SelectionItems = new List<SelectionItem>()
		};
		fXSgIco5HUS = new StepInParamDef
		{
			Key = "apiUrlFormat",
			Name = "API网址",
			DefaultValue = "",
			Description = "可选，使用自定义的API服务器时使用。请参考模块文档了解如何设置。",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.Input,
			IsAdvanced = true
		};
		mAagIV0eQa4 = new StepInParamDef
		{
			Key = "apiKey",
			Name = "APIKey",
			DefaultValue = "",
			Description = "",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.Input,
			IsAdvanced = true
		};
		nxkgIZjTFGb = new StepInParamDef
		{
			Key = "apiOrg",
			Name = "Orgnization",
			DefaultValue = "",
			Description = "可选",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.Input,
			IsAdvanced = true
		};
		IBkgI9FrsyK = new StepInParamDef
		{
			Key = "systemPrompt",
			Name = "系统提示",
			DefaultValue = "",
			Description = "告知AI所需要扮演的角色和要求。如“你是一个专业的翻译助手”。",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.Input,
			IsAdvanced = false,
			ValidForList = new string[1] { "chat" },
			IsMultiLine = false
		};
		aCfgIhO4thC = new StepInParamDef
		{
			Key = "sessionId",
			Name = "会话ID",
			DefaultValue = "",
			Description = "可选。每次会话请生成新的GUID格式会话ID，设置后将自动保存会话历史。",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.Input,
			IsAdvanced = false,
			ValidForList = new string[1] { "chat" },
			IsMultiLine = false
		};
		B4LgIeAVust = new StepInParamDef
		{
			Key = "historyMessages",
			Name = "历史消息",
			DefaultValue = "",
			Description = "可选。存放历史消息的json数组，格式请参考文档说明。设定会话ID后，也可直接写发送的历史会话条数。",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.Input,
			IsAdvanced = false,
			ValidForList = new string[1] { "chat" },
			IsMultiLine = true
		};
		etegIYA7r8K = new StepInParamDef
		{
			Key = "prompt",
			Name = "提示",
			DefaultValue = "",
			Description = "要为其生成补全的完整提示内容。",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.Input,
			IsAdvanced = false,
			IsMultiLine = true,
			ValidForList = new string[2] { "chat", "completions" }
		};
		SCYgIIjkPWU = new StepInParamDef
		{
			Key = "suffix",
			Name = "后缀提示",
			DefaultValue = "",
			Description = "后缀提示。出现在生成内容的末尾。",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.Input,
			IsAdvanced = false,
			IsMultiLine = true,
			ValidForList = new string[1] { "completions" }
		};
		PmBgIWKADX8 = new StepInParamDef
		{
			Key = "maxTokens",
			Name = "最大响应Token数",
			DefaultValue = 0,
			Description = "提示token数+最大响应token数不能超过模型限制。",
			Type = VarType.Integer,
			VariableMode = ParamVariableMode.Input,
			IsAdvanced = false
		};
		njEgIkZGi6u = new StepInParamDef
		{
			Key = "temperature",
			Name = "温度",
			DefaultValue = 0.2,
			Description = "像0.8这样的较高值会使输出更随机（发散/创造性），而像0.2这样的较低值会使其更加专注和确定性。",
			Type = VarType.Number,
			VariableMode = ParamVariableMode.Input,
			IsAdvanced = false
		};
		RFvgIGucxnQ = new StepInParamDef
		{
			Key = "topP",
			Name = "top_p",
			DefaultValue = 1,
			Type = VarType.Number,
			VariableMode = ParamVariableMode.Input,
			IsAdvanced = true,
			ValidForList = new string[2] { "chat", "completions" }
		};
		WcPgIsMqN4Q = new StepInParamDef
		{
			Key = "n",
			Name = "n",
			Description = "对每个问题生成几个结果，将会耗费更多token。",
			DefaultValue = 1,
			Type = VarType.Integer,
			VariableMode = ParamVariableMode.Input,
			IsAdvanced = true
		};
		kMXgIHlqTjb = new StepInParamDef
		{
			Key = "expireSeconds",
			Name = "超时秒数",
			Description = "最长等待秒数",
			DefaultValue = 120,
			Type = VarType.Number,
			VariableMode = ParamVariableMode.Input,
			IsAdvanced = true
		};
		FtAgI17IMoj = new StepInParamDef
		{
			Key = "stream",
			Name = "使用流式输出",
			Description = "即时输出结果，将结果输出到文本窗口，详见文档。此时将无法获得完整响应和token用量等信息。",
			DefaultValue = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsAdvanced = true
		};
		WYcgIbRIWMJ = new StepInParamDef
		{
			Key = "streamTo",
			Name = "流式输出窗口标识",
			Description = "一个预先使用非等待模式显示的文本窗口的标识，流式输出时将结果显示在该窗口中。",
			DefaultValue = "",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.Input,
			IsAdvanced = true
		};
		RM1gI619fIT = new StepInParamDef
		{
			Key = "logprobs",
			Name = "logprobs",
			DefaultValue = 0,
			Type = VarType.Integer,
			VariableMode = ParamVariableMode.Input,
			IsAdvanced = true
		};
		tw0gIX2XkVi = new StepInParamDef
		{
			Key = "stop",
			Name = "停止符stop",
			DefaultValue = "",
			Description = "遇到指定的内容时自动停止生成。可使用\\r,\\n,\\t等表示特殊字符。输入多行时，表示多个停止符。",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.Input,
			IsAdvanced = true,
			IsMultiLine = true
		};
		xnEgImpYiUY = new StepInParamDef
		{
			Key = "forceProxy",
			Name = "强制使用代理",
			DefaultValue = false,
			Description = "即使系统设置中未启用代理，本步骤仍然使用代理访问。",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input,
			IsAdvanced = true
		};
		FQUgIK5EhOr = new StepInParamDef
		{
			Key = "respFormat",
			Name = "响应格式",
			DefaultValue = "",
			Description = "留空，或使用“json_object”表示json格式响应，或json格式的完整的response_format内容。",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsAdvanced = true,
			IsMultiLine = true,
			ValidForList = new string[1] { "chat" },
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("", "文本"),
				new SelectionItem("json_object", "JSON对象")
			}
		};
		DTygIxP6HIb = new StepInParamDef
		{
			Key = "extraProps",
			Name = "附加参数",
			DefaultValue = "",
			Description = "用于添加额外的请求参数。请参考文档",
			Type = VarType.Dict,
			VariableMode = ParamVariableMode.Input,
			IsAdvanced = true,
			ValidForList = new string[1] { "chat" },
			IsMultiLine = true
		};
		nE7gIre0eaD = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		DI0gIBLb14f = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		a54gIQuZ74p = new StepOutParamDef
		{
			Key = "result",
			Name = "生成结果",
			Description = "生成的结果文本",
			Type = VarType.Text
		};
		IlfgIjrmjUO = new StepOutParamDef
		{
			Key = "reasoningContent",
			Name = "推理内容",
			Description = "推理模型的reasoning_content",
			Type = VarType.Text
		};
		XRbgInkc6UJ = new StepOutParamDef
		{
			Key = "rawResponse",
			Name = "原始响应内容",
			Description = "接口返回的原始响应内容",
			Type = VarType.Text
		};
		KGdgI4KYAnA = new StepOutParamDef
		{
			Key = "promptTokens",
			Name = "提示Token数",
			Description = "Prompt耗费的token数量",
			Type = VarType.Integer
		};
		D7ogI50kmHk = new StepOutParamDef
		{
			Key = "completionTokens",
			Name = "响应Token数",
			Description = "响应耗费的token数量",
			Type = VarType.Integer
		};
		diogIDAFm12 = new StepOutParamDef
		{
			Key = "totalTokens",
			Name = "总Token数",
			Description = "总耗费的token数量",
			Type = VarType.Integer
		};
		JrGgIdwySLX = new StepOutParamDef
		{
			Key = "finishReason",
			Name = "结束原因",
			Description = "",
			Type = VarType.Text
		};
		e34gIoxh8Bc = new StepOutParamDef
		{
			Key = "error",
			Name = "错误消息",
			Description = "发生错误时返回的消息内容",
			Type = VarType.Text
		};
		fAbgITW2Ha2 = new StepOutParamDef
		{
			Key = "historyMessages",
			Name = "历史消息",
			Description = "消息类型列表对象",
			Type = VarType.Object,
			ValidForList = new string[1] { "chat" }
		};
	}

	internal static bool rm8Q9UQTRt1adVwIA1u7()
	{
		return ue8dV8QT87RkjeXmG5rB == null;
	}
}
