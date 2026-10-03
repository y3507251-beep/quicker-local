using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.WebSockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using GS4IZ5qOJRHAi0T3I07;
using IflySdk.Common;
using IflySdk.Enum;
using IflySdk.Interface;
using IflySdk.Model.Common;
using IflySdk.Model.IAT;
using IflySdk.Model.IAT.ResultNode;
using log4net;
using Newtonsoft.Json;
using Quicker.Utilities.Ext;
using wQ8udLqNcqtPvZ8KXIE;

namespace IflySdk;

public class ASRApi : IDisposable, IApi
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass32_0
	{
		public int bP9vaOdmy88;

		public int vymvaFKeC6N;

		internal static _003C_003Ec__DisplayClass32_0 YmqHsdcvVP2pB6OMmkAX;

		internal bool NfhvaAHynPM(ResultWPGSInfo p)
		{
			if (p.sn >= bP9vaOdmy88)
			{
				return p.sn <= vymvaFKeC6N;
			}
			return false;
		}

		internal static bool peqw33cvQSkqw2E7orC6()
		{
			return YmqHsdcvVP2pB6OMmkAX == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CConvertAudio_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ResultModel<string>> _003C_003Et__builder;

		public ASRApi _003C_003E4__this;

		public byte[] data;

		private ClientWebSocket _003C_003E7__wrap1;

		private TaskAwaiter _003C_003Eu__1;

		private int _003Ci_003E5__3;

		internal static object xsKvbicvcOx64xwS3RMm;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ASRApi aSRApi = _003C_003E4__this;
			ResultModel<string> result;
			try
			{
				try
				{
					if ((uint)num > 6u)
					{
						_003C_003E7__wrap1 = (aSRApi.xJJZ5eN0oH = new ClientWebSocket());
					}
					try
					{
						int num3;
						int num2 = default(int);
						TaskAwaiter awaiter;
						byte[] array = default(byte[]);
						FirstFrameData firstFrameData = default(FirstFrameData);
						LastFrameData lastFrameData = default(LastFrameData);
						ContinueFrameData continueFrameData;
						switch (num)
						{
						default:
							aSRApi.Status = ServiceStatus.Running;
							aSRApi.lK3Z4mAo8u = ApiAuthorization.BuildAuthUrl(aSRApi.tlKZloOyPy);
							awaiter = aSRApi.xJJZ5eN0oH.ConnectAsync(new Uri(aSRApi.lK3Z4mAo8u), CancellationToken.None).GetAwaiter();
							if (awaiter.IsCompleted)
							{
								goto IL_029d;
							}
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num3 = 0;
							if (!C3Li5VcvW5yyKPjTtnkG())
							{
								return;
							}
							goto IL_0443;
						case 0:
							awaiter = _003C_003Eu__1;
							num3 = 5;
							if (xsKvbicvcOx64xwS3RMm != null)
							{
								goto IL_0261;
							}
							goto IL_0443;
						case 1:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default(TaskAwaiter);
							num2 = 4;
							goto IL_03b3;
						case 2:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default(TaskAwaiter);
							num = -1;
							_003C_003E1__state = -1;
							goto IL_0349;
						case 3:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default(TaskAwaiter);
							num = -1;
							_003C_003E1__state = -1;
							goto IL_041d;
						case 4:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default(TaskAwaiter);
							num = -1;
							_003C_003E1__state = -1;
							goto IL_0174;
						case 5:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default(TaskAwaiter);
							num = -1;
							_003C_003E1__state = -1;
							goto IL_0538;
						case 6:
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default(TaskAwaiter);
								num = -1;
								_003C_003E1__state = -1;
								break;
							}
							IL_055a:
							if (aSRApi.zGjZM505C2.Status != TaskStatus.RanToCompletion)
							{
								awaiter = Task.Delay(10).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num = 5;
									_003C_003E1__state = 5;
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_0538;
							}
							awaiter = aSRApi.xJJZ5eN0oH.CloseAsync(WebSocketCloseStatus.NormalClosure, "NormalClosure", CancellationToken.None).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 6;
								_003C_003E1__state = 6;
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							break;
							IL_029d:
							awaiter.GetResult();
							if (aSRApi.xJJZ5eN0oH.State == WebSocketState.Open)
							{
								aSRApi.zGjZM505C2 = aSRApi.VL1ZrrdEjn(aSRApi.xJJZ5eN0oH);
								_003Ci_003E5__3 = 0;
								goto IL_018d;
							}
							throw new Exception("无法建立连接，可能凭据不正确。");
							IL_03bd:
							awaiter.GetResult();
							aSRApi.YL5ZnrXyiQ = FrameState.Continue;
							goto IL_0424;
							IL_0424:
							awaiter = Task.Delay(20).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 4;
								_003C_003E1__state = 4;
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0174;
							IL_018d:
							if (_003Ci_003E5__3 < data.Length)
							{
								array = aSRApi.awAZBWASwB(data, _003Ci_003E5__3, 1280);
								if (array == null || data.Length - _003Ci_003E5__3 < 1280)
								{
									aSRApi.YL5ZnrXyiQ = FrameState.Last;
								}
								switch (aSRApi.YL5ZnrXyiQ)
								{
								case FrameState.First:
									break;
								case FrameState.Last:
									goto IL_023d;
								case FrameState.Continue:
									goto IL_02d9;
								default:
									goto IL_0424;
								}
								firstFrameData = new FirstFrameData
								{
									common = aSRApi.JRqZiOnN7I,
									business = aSRApi.PydZfsaoW0,
									data = aSRApi.ujSZ3VnR8Q
								};
								num3 = 1;
								if (!C3Li5VcvW5yyKPjTtnkG())
								{
									goto IL_027e;
								}
								goto IL_0443;
							}
							goto IL_055a;
							IL_0538:
							awaiter.GetResult();
							goto IL_055a;
							IL_0261:
							lastFrameData.data.status = FrameState.Last;
							num3 = 8;
							if (!C3Li5VcvW5yyKPjTtnkG())
							{
								goto IL_027e;
							}
							goto IL_0443;
							IL_0287:
							_003C_003Eu__1 = default(TaskAwaiter);
							num = -1;
							_003C_003E1__state = -1;
							goto IL_029d;
							IL_0174:
							awaiter.GetResult();
							goto IL_017b;
							IL_02d9:
							continueFrameData = new ContinueFrameData
							{
								data = aSRApi.ujSZ3VnR8Q
							};
							continueFrameData.data.status = FrameState.Continue;
							continueFrameData.data.audio = System.Convert.ToBase64String(array);
							awaiter = aSRApi.xJJZ5eN0oH.SendAsync(new ArraySegment<byte>(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(continueFrameData))), WebSocketMessageType.Text, true, CancellationToken.None).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 2;
								_003C_003E1__state = 2;
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0349;
							IL_0349:
							awaiter.GetResult();
							goto IL_0424;
							IL_017b:
							_003Ci_003E5__3 += 1280;
							goto IL_018d;
							IL_023d:
							lastFrameData = new LastFrameData
							{
								data = aSRApi.ujSZ3VnR8Q
							};
							num3 = 2;
							if (!C3Li5VcvW5yyKPjTtnkG())
							{
								goto IL_0261;
							}
							goto IL_0443;
							IL_027e:
							num3 = num2;
							goto IL_0443;
							IL_0443:
							switch (num3)
							{
							case 3:
								break;
							case 2:
								goto IL_0261;
							case 5:
								goto IL_0287;
							case 1:
								goto IL_0355;
							case 4:
								goto IL_03b3;
							case 8:
								lastFrameData.data.audio = System.Convert.ToBase64String(array);
								awaiter = aSRApi.xJJZ5eN0oH.SendAsync(new ArraySegment<byte>(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(lastFrameData))), WebSocketMessageType.Text, true, CancellationToken.None).GetAwaiter();
								if (awaiter.IsCompleted)
								{
									goto IL_041d;
								}
								goto case 6;
							case 9:
							case 10:
								goto IL_0424;
							default:
								return;
							case 0:
								return;
							case 6:
								num = 3;
								_003C_003E1__state = 3;
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 7:
								goto IL_055a;
							}
							goto IL_017b;
							IL_041d:
							awaiter.GetResult();
							goto IL_0424;
							IL_03b3:
							num = -1;
							_003C_003E1__state = -1;
							goto IL_03bd;
							IL_0355:
							firstFrameData.data.status = FrameState.First;
							firstFrameData.data.audio = System.Convert.ToBase64String(array);
							awaiter = aSRApi.xJJZ5eN0oH.SendAsync(new ArraySegment<byte>(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(firstFrameData))), WebSocketMessageType.Text, true, CancellationToken.None).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 1;
								_003C_003E1__state = 1;
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_03bd;
						}
						awaiter.GetResult();
					}
					finally
					{
						if (num < 0 && _003C_003E7__wrap1 != null)
						{
							((IDisposable)_003C_003E7__wrap1).Dispose();
						}
					}
					_003C_003E7__wrap1 = null;
					StringBuilder stringBuilder = new StringBuilder();
					List<ResultWPGSInfo>.Enumerator enumerator = aSRApi.ipQZoxqLW9.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							ResultWPGSInfo current = enumerator.Current;
							stringBuilder.Append(current.data);
						}
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
						}
					}
					aSRApi.Status = ServiceStatus.Stopping;
					aSRApi.mEDZpdMCCP();
					result = new ResultModel<string>
					{
						Code = ResultCode.Success,
						Data = stringBuilder.ToString()
					};
					int num4 = 0;
					if (xsKvbicvcOx64xwS3RMm != null)
					{
						int num5 = default(int);
						num4 = num5;
					}
					switch (num4)
					{
					}
				}
				catch (Exception ex)
				{
					result = new ResultModel<string>
					{
						Code = ResultCode.Error,
						Message = ex.Message
					};
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool C3Li5VcvW5yyKPjTtnkG()
		{
			return xsKvbicvcOx64xwS3RMm == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDoFragmentAsr_003Ed__31 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ResultModel<string>> _003C_003Et__builder;

		public ASRApi _003C_003E4__this;

		public byte[] data;

		public FrameState state;

		private TaskAwaiter _003C_003Eu__1;

		private int _003Ci_003E5__2;

		internal static object O4bRCqcvnirehyuwbMIU;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ASRApi aSRApi = _003C_003E4__this;
			ResultModel<string> result = default(ResultModel<string>);
			try
			{
				int num3;
				object obj;
				int num2;
				TaskAwaiter awaiter = default(TaskAwaiter);
				Exception ex2;
				string text;
				int num7 = default(int);
				switch (num)
				{
				default:
					num2 = 0;
					num3 = 1;
					if (O4bRCqcvnirehyuwbMIU != null)
					{
						goto IL_08ec;
					}
					goto IL_08ed;
				case 0:
				case 1:
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
					try
					{
						int num4;
						int num5 = default(int);
						ContinueFrameData continueFrameData;
						byte[] array = default(byte[]);
						LastFrameData lastFrameData = default(LastFrameData);
						switch (num)
						{
						default:
							if (aSRApi.xJJZ5eN0oH == null && aSRApi.YL5ZnrXyiQ == FrameState.First)
							{
								aSRApi.xJJZ5eN0oH = new ClientWebSocket();
								goto IL_0625;
							}
							goto IL_078b;
						case 0:
							awaiter = _003C_003Eu__1;
							num4 = 7;
							if (!IXlZVvcveYXQyA1pKEDT())
							{
								goto IL_060d;
							}
							goto IL_0714;
						case 1:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default(TaskAwaiter);
							num = -1;
							_003C_003E1__state = -1;
							goto IL_050d;
						case 2:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default(TaskAwaiter);
							num = -1;
							_003C_003E1__state = -1;
							goto IL_058b;
						case 3:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default(TaskAwaiter);
							num = -1;
							_003C_003E1__state = -1;
							goto IL_0205;
						case 4:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default(TaskAwaiter);
							num = -1;
							_003C_003E1__state = -1;
							goto IL_0211;
						case 6:
							awaiter = _003C_003Eu__1;
							goto IL_0144;
						case 5:
							goto IL_0174;
							IL_060d:
							num4 = num5;
							goto IL_0714;
							IL_051d:
							continueFrameData = new ContinueFrameData
							{
								data = aSRApi.ujSZ3VnR8Q
							};
							continueFrameData.data.status = FrameState.Continue;
							continueFrameData.data.audio = System.Convert.ToBase64String(array);
							awaiter = aSRApi.xJJZ5eN0oH.SendAsync(new ArraySegment<byte>(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(continueFrameData))), WebSocketMessageType.Text, true, CancellationToken.None).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 2;
								_003C_003E1__state = 2;
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_058b;
							IL_078b:
							_003Ci_003E5__2 = 0;
							goto IL_022a;
							IL_022a:
							if (_003Ci_003E5__2 < data.Length)
							{
								array = null;
								goto IL_0240;
							}
							goto IL_0614;
							IL_0144:
							_003C_003Eu__1 = default(TaskAwaiter);
							num = -1;
							_003C_003E1__state = -1;
							goto IL_0159;
							IL_0614:
							if (state == FrameState.Last)
							{
								goto IL_0193;
							}
							goto IL_0842;
							IL_0193:
							if (aSRApi.zGjZM505C2.Status != TaskStatus.RanToCompletion)
							{
								awaiter = Task.Delay(10).GetAwaiter();
								if (awaiter.IsCompleted)
								{
									goto IL_01bd;
								}
								num = 5;
								_003C_003E1__state = 5;
								goto IL_01cf;
							}
							awaiter = aSRApi.xJJZ5eN0oH.CloseAsync(WebSocketCloseStatus.NormalClosure, "NormalClosure", CancellationToken.None).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 6;
								_003C_003E1__state = 6;
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0159;
							IL_050d:
							awaiter.GetResult();
							aSRApi.YL5ZnrXyiQ = FrameState.Continue;
							goto IL_0592;
							IL_01bd:
							awaiter.GetResult();
							goto IL_0193;
							IL_0159:
							awaiter.GetResult();
							num4 = 11;
							if (!IXlZVvcveYXQyA1pKEDT())
							{
								goto IL_060d;
							}
							goto IL_0714;
							IL_0592:
							awaiter = Task.Delay(20).GetAwaiter();
							if (awaiter.IsCompleted)
							{
								goto IL_0211;
							}
							num = 4;
							_003C_003E1__state = 4;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num4 = 0;
							if (!IXlZVvcveYXQyA1pKEDT())
							{
								goto IL_060d;
							}
							goto IL_0714;
							IL_01cf:
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num4 = 1;
							if (O4bRCqcvnirehyuwbMIU == null)
							{
								return;
							}
							goto IL_0714;
							IL_0714:
							switch (num4)
							{
							case 8:
								break;
							case 13:
								goto IL_0174;
							case 10:
								goto IL_01cf;
							case 12:
								if (!awaiter.IsCompleted)
								{
									num = 3;
									_003C_003E1__state = 3;
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_0205;
							case 6:
								goto IL_0240;
							case 4:
								goto IL_0592;
							case 5:
								goto IL_05dd;
							case 9:
								goto IL_0625;
							case 2:
								goto IL_062c;
							case 7:
								goto IL_06b6;
							case 3:
								lastFrameData.data.audio = System.Convert.ToBase64String(array);
								awaiter = aSRApi.xJJZ5eN0oH.SendAsync(new ArraySegment<byte>(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(lastFrameData))), WebSocketMessageType.Text, true, CancellationToken.None).GetAwaiter();
								goto case 12;
							default:
								return;
							case 0:
								return;
							case 11:
								goto IL_0842;
							case 1:
								return;
							}
							goto IL_0144;
							IL_06b6:
							_003C_003Eu__1 = default(TaskAwaiter);
							num = -1;
							_003C_003E1__state = -1;
							goto IL_0685;
							IL_0625:
							aSRApi.YL5ZnrXyiQ = FrameState.First;
							goto IL_062c;
							IL_062c:
							aSRApi.lK3Z4mAo8u = ApiAuthorization.BuildAuthUrl(aSRApi.tlKZloOyPy);
							ca0ZzJ8iZx.Info("语音识别，请求URL：" + aSRApi.lK3Z4mAo8u);
							awaiter = aSRApi.xJJZ5eN0oH.ConnectAsync(new Uri(aSRApi.lK3Z4mAo8u), CancellationToken.None).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 0;
								_003C_003E1__state = 0;
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
							goto IL_0685;
							IL_0685:
							awaiter.GetResult();
							if (aSRApi.xJJZ5eN0oH.State == WebSocketState.Open)
							{
								aSRApi.zGjZM505C2 = aSRApi.VL1ZrrdEjn(aSRApi.xJJZ5eN0oH);
								goto IL_078b;
							}
							throw new Exception("Connect to xfyun api server failed.");
							IL_0205:
							awaiter.GetResult();
							goto IL_0592;
							IL_0211:
							awaiter.GetResult();
							_003Ci_003E5__2 += 1280;
							goto IL_022a;
							IL_0842:
							result = new ResultModel<string>
							{
								Code = ResultCode.Success,
								Data = null
							};
							break;
							IL_0240:
							if (aSRApi.GTlZDmJD2K.Length == 0)
							{
								if (data.Length - _003Ci_003E5__2 < 1280)
								{
									if (state != FrameState.Last)
									{
										int num6 = data.Length - _003Ci_003E5__2;
										Array.Copy(data, _003Ci_003E5__2, aSRApi.GTlZDmJD2K.TFLhCoUf40(), 0, num6);
										aSRApi.GTlZDmJD2K.Length = num6;
									}
									else
									{
										array = aSRApi.awAZBWASwB(data, _003Ci_003E5__2, 1280);
										aSRApi.YL5ZnrXyiQ = FrameState.Last;
									}
								}
								else
								{
									array = aSRApi.awAZBWASwB(data, _003Ci_003E5__2, 1280);
									if (state == FrameState.Last && data.Length - _003Ci_003E5__2 == 1280)
									{
										aSRApi.YL5ZnrXyiQ = FrameState.Last;
										if (array == null)
										{
											array = new byte[1];
										}
									}
								}
							}
							else
							{
								if (data.Length + aSRApi.GTlZDmJD2K.Length <= 1280)
								{
									array = new byte[aSRApi.GTlZDmJD2K.Length + data.Length];
									Array.Copy(aSRApi.GTlZDmJD2K.TFLhCoUf40(), 0, array, 0, aSRApi.GTlZDmJD2K.Length);
									Array.Copy(data, _003Ci_003E5__2, array, aSRApi.GTlZDmJD2K.Length, data.Length);
									aSRApi.YL5ZnrXyiQ = FrameState.Last;
									_003Ci_003E5__2 = data.Length - 1280;
								}
								else
								{
									array = new byte[1280];
									Array.Copy(aSRApi.GTlZDmJD2K.TFLhCoUf40(), 0, array, 0, aSRApi.GTlZDmJD2K.Length);
									Array.Copy(data, _003Ci_003E5__2, array, aSRApi.GTlZDmJD2K.Length, 1280 - aSRApi.GTlZDmJD2K.Length);
									_003Ci_003E5__2 -= aSRApi.GTlZDmJD2K.Length;
								}
								aSRApi.GTlZDmJD2K.okwhN73WT3();
							}
							if (aSRApi.GTlZDmJD2K.Length == 0)
							{
								if (aSRApi.xJJZ5eN0oH.State == WebSocketState.Open)
								{
									switch (aSRApi.YL5ZnrXyiQ)
									{
									case FrameState.First:
										break;
									case FrameState.Continue:
										goto IL_051d;
									default:
										goto IL_0592;
									case FrameState.Last:
										goto IL_05dd;
									}
									FirstFrameData firstFrameData = new FirstFrameData
									{
										common = aSRApi.JRqZiOnN7I,
										business = aSRApi.PydZfsaoW0,
										data = aSRApi.ujSZ3VnR8Q
									};
									firstFrameData.data.status = FrameState.First;
									firstFrameData.data.audio = System.Convert.ToBase64String(array);
									awaiter = aSRApi.xJJZ5eN0oH.SendAsync(new ArraySegment<byte>(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(firstFrameData))), WebSocketMessageType.Text, true, CancellationToken.None).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num = 1;
										_003C_003E1__state = 1;
										_003C_003Eu__1 = awaiter;
										_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									}
									goto IL_050d;
								}
								throw new Exception("WebSocket已断开");
							}
							goto IL_0614;
							IL_0174:
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default(TaskAwaiter);
							num = -1;
							_003C_003E1__state = -1;
							goto IL_01bd;
							IL_05dd:
							lastFrameData = new LastFrameData
							{
								data = aSRApi.ujSZ3VnR8Q
							};
							lastFrameData.data.status = FrameState.Last;
							num4 = 3;
							if (!IXlZVvcveYXQyA1pKEDT())
							{
								goto IL_060d;
							}
							goto IL_0714;
							IL_058b:
							awaiter.GetResult();
							goto IL_0592;
						}
					}
					catch (Exception ex)
					{
						obj = ex;
						num2 = 1;
						goto IL_088c;
					}
					break;
				case 7:
					try
					{
						if (num != 7)
						{
							awaiter = aSRApi.xJJZ5eN0oH.CloseAsync(WebSocketCloseStatus.NormalClosure, "NormalClosure", CancellationToken.None).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 7;
								_003C_003E1__state = 7;
								if (O4bRCqcvnirehyuwbMIU != null)
								{
									switch (0)
									{
									}
								}
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default(TaskAwaiter);
							num = -1;
							_003C_003E1__state = -1;
						}
						awaiter.GetResult();
					}
					catch
					{
					}
					goto IL_09da;
				case 8:
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter);
						num = -1;
						_003C_003E1__state = -1;
						goto IL_09b8;
					}
					IL_08ed:
					switch (num3)
					{
					case 1:
						break;
					default:
						goto end_IL_000f;
					case 0:
						goto end_IL_000f;
					}
					goto case 0;
					IL_088c:
					if (num2 != 1)
					{
						break;
					}
					ex2 = (Exception)obj;
					text = ex2.Message.ToLower();
					if (!text.Contains("unable to read data from the transport connection") && !text.Contains("the remote party closed the websocket connection"))
					{
						result = new ResultModel<string>
						{
							Code = ResultCode.Error,
							Message = ex2.GetMessageWithInner()
						};
						num3 = 0;
						if (!IXlZVvcveYXQyA1pKEDT())
						{
							goto IL_08ec;
						}
						goto IL_08ed;
					}
					goto case 7;
					IL_09da:
					if (aSRApi.zGjZM505C2.Status != TaskStatus.RanToCompletion)
					{
						awaiter = Task.Delay(10).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 8;
							_003C_003E1__state = 8;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_09b8;
					}
					result = new ResultModel<string>
					{
						Code = ResultCode.Disconnect,
						Message = "服务器主动断开连接，可能是整个会话是否已经超过了60s、读取数据超时、静默检测超时等原因引起的。"
					};
					break;
					IL_09b8:
					awaiter.GetResult();
					goto IL_09da;
					IL_08ec:
					num3 = num7;
					goto IL_08ed;
					end_IL_000f:
					break;
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool IXlZVvcveYXQyA1pKEDT()
		{
			return O4bRCqcvnirehyuwbMIU == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CStartConvert_003Ed__29 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public ASRApi _003C_003E4__this;

		private Stopwatch _003Cstopwatch_003E5__2;

		private bool _003CisStart_003E5__3;

		private long _003ClastDataTimespan_003E5__4;

		private int _003CconnectOutTime_003E5__5;

		private int _003CsendDataOutTime_003E5__6;

		private pvPYfrqviDnkOJxaihx _003Cdata_003E5__7;

		private TaskAwaiter<ResultModel<string>> _003C_003Eu__1;

		internal static object CT1cdUcvK1dOPbZuGXud;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ASRApi aSRApi = _003C_003E4__this;
			try
			{
				try
				{
        ResultModel<string> result = default;
					TaskAwaiter<ResultModel<string>> awaiter = default(TaskAwaiter<ResultModel<string>>);
					int num2;
					if (num != 0)
					{
						if (num != 1)
						{
							_003Cstopwatch_003E5__2 = new Stopwatch();
							goto IL_022c;
						}
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<ResultModel<string>>);
						num2 = 2;
						if (CT1cdUcvK1dOPbZuGXud != null)
						{
							goto IL_0268;
						}
						goto IL_034f;
					}
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<ResultModel<string>>);
					num = -1;
					_003C_003E1__state = -1;
					goto IL_036e;
					IL_0362:
					result = default(ResultModel<string>);
					if (result.Code != ResultCode.Disconnect)
					{
						goto IL_031c;
					}
					aSRApi.YxSZOHh9qL?.Invoke(aSRApi, new ErrorEventArgs
					{
						Code = ResultCode.Disconnect,
						Message = result.Message,
						Exception = new Exception(result.Message)
					});
					goto IL_03f3;
					IL_036e:
					result = awaiter.GetResult();
					goto IL_0362;
					IL_02bb:
					if (aSRApi.Status == ServiceStatus.Running)
					{
						_003Cdata_003E5__7 = null;
						goto IL_028e;
					}
					goto IL_03f3;
					IL_031c:
					if (result.Code != ResultCode.Success)
					{
						string message = "识别出错（可能提供的凭据不正确）。" + result.Message;
						aSRApi.YxSZOHh9qL?.Invoke(aSRApi, new ErrorEventArgs
						{
							Code = ResultCode.Warning,
							Message = message,
							Exception = new Exception(message)
						});
					}
					if (!_003Cdata_003E5__7.rbi9OgTkVo())
					{
						_003Cdata_003E5__7 = null;
						goto IL_02bb;
					}
					goto IL_03f3;
					IL_022c:
					_003CisStart_003E5__3 = false;
					_003ClastDataTimespan_003E5__4 = 0L;
					num2 = 1;
					if (CT1cdUcvK1dOPbZuGXud != null)
					{
						goto IL_024f;
					}
					goto IL_0268;
					IL_024f:
					_003CconnectOutTime_003E5__5 = 60;
					num2 = 5;
					if (!H8qbcqcvBy6vbkPFd9pC())
					{
						int num3 = default(int);
						num2 = num3;
					}
					goto IL_0268;
					IL_03e0:
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
					IL_0268:
					switch (num2)
					{
					case 3:
						break;
					case 1:
						goto IL_024f;
					case 6:
						goto IL_028e;
					case 5:
						goto IL_02b4;
					case 4:
						goto IL_031c;
					case 2:
						goto IL_034f;
					default:
						goto IL_03e0;
					}
					goto IL_022c;
					IL_034f:
					num = -1;
					_003C_003E1__state = -1;
					goto IL_0359;
					IL_02b4:
					_003CsendDataOutTime_003E5__6 = 8;
					goto IL_02bb;
					IL_028e:
					object yaPZTYnwpw = ASRApi.yaPZTYnwpw;
					bool lockTaken = false;
					try
					{
						Monitor.Enter(yaPZTYnwpw, ref lockTaken);
						if (aSRApi.XmoZdbJwXQ.Count > 0)
						{
							_003Cdata_003E5__7 = aSRApi.XmoZdbJwXQ.Dequeue();
							_003ClastDataTimespan_003E5__4 = _003Cstopwatch_003E5__2.ElapsedMilliseconds;
						}
					}
					finally
					{
						if (num < 0 && lockTaken)
						{
							Monitor.Exit(yaPZTYnwpw);
						}
					}
					if (_003Cdata_003E5__7 == null)
					{
						if (_003Cstopwatch_003E5__2.ElapsedMilliseconds / 1000L <= _003CconnectOutTime_003E5__5 && (_003Cstopwatch_003E5__2.ElapsedMilliseconds - _003ClastDataTimespan_003E5__4) / 1000L <= _003CsendDataOutTime_003E5__6)
						{
							Thread.Sleep(1);
							goto IL_02bb;
						}
						_003Cdata_003E5__7 = new pvPYfrqviDnkOJxaihx(new byte[1], true);
					}
					if (!_003CisStart_003E5__3)
					{
						_003Cstopwatch_003E5__2.Start();
						_003CisStart_003E5__3 = true;
					}
					if (_003Cdata_003E5__7.rbi9OgTkVo() || _003Cstopwatch_003E5__2.ElapsedMilliseconds / 1000L > _003CconnectOutTime_003E5__5 || (_003Cstopwatch_003E5__2.ElapsedMilliseconds - _003ClastDataTimespan_003E5__4) / 1000L > _003CsendDataOutTime_003E5__6)
					{
						_003Cdata_003E5__7.Q719FXsUCF(true);
						if (_003Cdata_003E5__7.Data == null)
						{
							_003Cdata_003E5__7.Data = new byte[1];
						}
						awaiter = aSRApi.IAMZx6xv9N(_003Cdata_003E5__7.Data, FrameState.Last).GetAwaiter();
						if (awaiter.IsCompleted)
						{
							goto IL_036e;
						}
						num = 0;
						_003C_003E1__state = 0;
						_003C_003Eu__1 = awaiter;
						num2 = 0;
						if (!H8qbcqcvBy6vbkPFd9pC())
						{
							goto IL_0268;
						}
						goto IL_03e0;
					}
					if (_003Cdata_003E5__7.Data == null)
					{
						goto IL_02bb;
					}
					awaiter = aSRApi.IAMZx6xv9N(_003Cdata_003E5__7.Data).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 1;
						_003C_003E1__state = 1;
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_0359;
					IL_0359:
					result = awaiter.GetResult();
					goto IL_0362;
					IL_03f3:
					_003Cstopwatch_003E5__2.Stop();
					_003Cstopwatch_003E5__2 = null;
				}
				catch (Exception ex)
				{
					aSRApi.YxSZOHh9qL?.Invoke(aSRApi, new ErrorEventArgs
					{
						Code = ResultCode.Warning,
						Message = ex.Message,
						Exception = new Exception(ex.Message)
					});
				}
				finally
				{
					if (num < 0)
					{
						aSRApi.mEDZpdMCCP();
					}
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool H8qbcqcvBy6vbkPFd9pC()
		{
			return CT1cdUcvK1dOPbZuGXud == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CStartReceiving_003Ed__32 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ASRApi _003C_003E4__this;

		public ClientWebSocket client;

		private string _003Cmsg_003E5__2;

		private byte[] _003Carray_003E5__3;

		private TaskAwaiter<WebSocketReceiveResult> _003C_003Eu__1;

		private static object NwVjlucvkJZHxAIMUvAg;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ASRApi aSRApi = _003C_003E4__this;
			try
			{
				if (num != 0)
				{
					if (aSRApi.ipQZoxqLW9 != null)
					{
						aSRApi.ipQZoxqLW9.Clear();
					}
					_003Cmsg_003E5__2 = "";
				}
				TaskAwaiter<WebSocketReceiveResult> awaiter = default(TaskAwaiter<WebSocketReceiveResult>);
				StringBuilder stringBuilder = default(StringBuilder);
				ASRResult aSRResult = default(ASRResult);
				_003C_003Ec__DisplayClass32_0 _003C_003Ec__DisplayClass32_ = default(_003C_003Ec__DisplayClass32_0);
				int num3 = default(int);
				string text = default(string);
				WebSocketReceiveResult result = default(WebSocketReceiveResult);
				while (true)
				{
					try
					{
						WebSocketCloseStatus? closeStatus;
						int num2;
						if (num != 0)
						{
							if (client.CloseStatus != WebSocketCloseStatus.EndpointUnavailable && client.CloseStatus != WebSocketCloseStatus.InternalServerError)
							{
								closeStatus = client.CloseStatus;
								num2 = 4;
								if (NwVjlucvkJZHxAIMUvAg != null)
								{
									goto IL_00ed;
								}
								goto IL_00f1;
							}
							break;
						}
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<WebSocketReceiveResult>);
						num = -1;
						_003C_003E1__state = -1;
						goto IL_0164;
						IL_0223:
						stringBuilder = new StringBuilder();
						List<WsItem>.Enumerator enumerator = aSRResult.Data.result.ws.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								List<CwItem>.Enumerator enumerator2 = enumerator.Current.cw.GetEnumerator();
								try
								{
									while (enumerator2.MoveNext())
									{
										CwItem current = enumerator2.Current;
										if (!string.IsNullOrEmpty(current.w))
										{
											stringBuilder.Append(current.w);
										}
									}
								}
								finally
								{
									if (num < 0)
									{
										((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
									}
								}
							}
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
							}
						}
						if (aSRResult.Data.result.pgs == "apd")
						{
							aSRApi.ipQZoxqLW9.Add(new ResultWPGSInfo
							{
								sn = aSRResult.Data.result.sn,
								data = stringBuilder.ToString()
							});
						}
						else if (aSRResult.Data.result.pgs == "rpl")
						{
							_003C_003Ec__DisplayClass32_ = new _003C_003Ec__DisplayClass32_0();
							if (aSRResult.Data.result.rg == null || aSRResult.Data.result.rg.Count != 2)
							{
								continue;
							}
							goto IL_036c;
						}
						goto IL_03ff;
						IL_036c:
						_003C_003Ec__DisplayClass32_.bP9vaOdmy88 = aSRResult.Data.result.rg[0];
						_003C_003Ec__DisplayClass32_.vymvaFKeC6N = aSRResult.Data.result.rg[1];
						try
						{
							ResultWPGSInfo resultWPGSInfo = aSRApi.ipQZoxqLW9.Where(_003C_003Ec__DisplayClass32_.NfhvaAHynPM).SingleOrDefault();
							if (resultWPGSInfo == null)
							{
								continue;
							}
							resultWPGSInfo.sn = aSRResult.Data.result.sn;
							resultWPGSInfo.data = stringBuilder.ToString();
							goto IL_03ff;
						}
						catch
						{
						}
						continue;
						IL_04a4:
						_003Carray_003E5__3 = null;
						continue;
						IL_03ff:
						StringBuilder stringBuilder2 = new StringBuilder();
						List<ResultWPGSInfo>.Enumerator enumerator3 = aSRApi.ipQZoxqLW9.GetEnumerator();
						try
						{
							while (enumerator3.MoveNext())
							{
								ResultWPGSInfo current2 = enumerator3.Current;
								stringBuilder2.Append(current2.data);
							}
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)enumerator3/*cast due to .constrained prefix*/).Dispose();
							}
						}
						aSRApi.blpZFej8YA?.Invoke(aSRApi, stringBuilder2.ToString());
						if (aSRResult.Data.status != 2)
						{
							goto IL_04a4;
						}
						goto end_IL_003c;
						IL_00ed:
						num2 = num3;
						goto IL_00f1;
						IL_00f1:
						while (true)
						{
							switch (num2)
							{
							case 4:
								break;
							case 1:
								goto end_IL_00f1;
							case 5:
								goto IL_01a2;
							case 3:
								goto IL_01e4;
							default:
								goto IL_0223;
							case 2:
								goto IL_036c;
							}
							if (closeStatus == WebSocketCloseStatus.EndpointUnavailable)
							{
								goto end_IL_003c_2;
							}
							_003Carray_003E5__3 = new byte[4096];
							awaiter = client.ReceiveAsync(new ArraySegment<byte>(_003Carray_003E5__3), CancellationToken.None).GetAwaiter();
							num2 = 1;
							if (PivG2CcvaN5WkDtEhPKj())
							{
								continue;
							}
							goto IL_00ed;
							continue;
							end_IL_00f1:
							break;
						}
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_003C_003E1__state = 0;
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0164;
						IL_01a2:
						_003Cmsg_003E5__2 += text;
						if (!result.EndOfMessage)
						{
							continue;
						}
						aSRResult = JsonConvert.DeserializeObject<ASRResult>(_003Cmsg_003E5__2);
						_003Cmsg_003E5__2 = "";
						num3 = 3;
						goto IL_01e4;
						IL_0164:
						result = awaiter.GetResult();
						if (result.MessageType == WebSocketMessageType.Text)
						{
							if (result.Count <= 0)
							{
								continue;
							}
							text = Encoding.UTF8.GetString(_003Carray_003E5__3, 0, result.Count);
							goto IL_01a2;
						}
						goto IL_04a4;
						IL_01e4:
						if (aSRResult.Code == 0)
						{
							if (aSRResult.Data != null && aSRResult.Data.result != null && aSRResult.Data.result.ws != null)
							{
								goto IL_0223;
							}
							break;
						}
						throw new Exception($"Result error({aSRResult.Code}): {aSRResult.Message}");
						end_IL_003c:;
					}
					catch (WebSocketException)
					{
					}
					catch (Exception ex2)
					{
						if (!ex2.Message.ToLower().Contains("unable to read data from the transport connection"))
						{
							aSRApi.YxSZOHh9qL?.Invoke(aSRApi, new ErrorEventArgs
							{
								Code = ResultCode.Error,
								Message = ex2.Message,
								Exception = ex2
							});
						}
					}
					break;
					continue;
					end_IL_003c_2:
					break;
				}
			}
			catch (Exception exception)
			{
				_003C_003E1__state = -2;
				_003Cmsg_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003Cmsg_003E5__2 = null;
			_003C_003Et__builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		internal static bool PivG2CcvaN5WkDtEhPKj()
		{
			return NwVjlucvkJZHxAIMUvAg == null;
		}
	}

	private FrameState YL5ZnrXyiQ;

	private string lK3Z4mAo8u;

	private ClientWebSocket xJJZ5eN0oH;

	private readonly oRbDoMqnwyx1JpCDxtb GTlZDmJD2K = new oRbDoMqnwyx1JpCDxtb(1280);

	private readonly Queue<pvPYfrqviDnkOJxaihx> XmoZdbJwXQ = new Queue<pvPYfrqviDnkOJxaihx>();

	private readonly List<ResultWPGSInfo> ipQZoxqLW9 = new List<ResultWPGSInfo>();

	private static readonly object yaPZTYnwpw;

	private Task zGjZM505C2;

	private bool it4ZAQsJNK = true;

	[CompilerGenerated]
	private EventHandler<ErrorEventArgs> YxSZOHh9qL;

	[CompilerGenerated]
	private EventHandler<string> blpZFej8YA;

	[CompilerGenerated]
	private ServiceStatus rTqZUhlcyP = ServiceStatus.Stopped;

	private readonly AppSettings tlKZloOyPy;

	private readonly CommonParams JRqZiOnN7I;

	private readonly DataParams ujSZ3VnR8Q;

	private readonly BusinessParams PydZfsaoW0;

	private static readonly ILog ca0ZzJ8iZx;

	private static ASRApi Y5IBtRr5H78Tg4HXUqK;

	public ServiceStatus Status
	{
		[CompilerGenerated]
		get
		{
			return rTqZUhlcyP;
		}
		[CompilerGenerated]
		internal set
		{
			rTqZUhlcyP = value;
		}
	}

	public event EventHandler<ErrorEventArgs> OnError
	{
		[CompilerGenerated]
		add
		{
			EventHandler<ErrorEventArgs> eventHandler = YxSZOHh9qL;
			EventHandler<ErrorEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ErrorEventArgs> value2 = (EventHandler<ErrorEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref YxSZOHh9qL, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<ErrorEventArgs> eventHandler = YxSZOHh9qL;
			EventHandler<ErrorEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<ErrorEventArgs> value2 = (EventHandler<ErrorEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref YxSZOHh9qL, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<string> OnMessage
	{
		[CompilerGenerated]
		add
		{
			EventHandler<string> eventHandler = blpZFej8YA;
			EventHandler<string> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<string> value2 = (EventHandler<string>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref blpZFej8YA, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<string> eventHandler = blpZFej8YA;
			EventHandler<string> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<string> value2 = (EventHandler<string>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref blpZFej8YA, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public ASRApi(AppSettings settings, CommonParams common, DataParams data, BusinessParams business)
	{
		tlKZloOyPy = settings;
		JRqZiOnN7I = common;
		ujSZ3VnR8Q = data;
		PydZfsaoW0 = business;
	}

	[AsyncStateMachine(typeof(_003CConvertAudio_003Ed__26))]
	public Task<ResultModel<string>> ConvertAudio(byte[] data)
	{
		_003CConvertAudio_003Ed__26 stateMachine = default(_003CConvertAudio_003Ed__26);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ResultModel<string>>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.data = data;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public void Convert(byte[] data, bool isEnd = false)
	{
		if (Status == ServiceStatus.Stopping && data != null)
		{
			return;
		}
		if (isEnd)
		{
			Status = ServiceStatus.Stopping;
		}
		if (it4ZAQsJNK || Status == ServiceStatus.InnerStop)
		{
			Status = ServiceStatus.Running;
			it4ZAQsJNK = false;
			Task.Run((Action)g8wZQWflQX);
		}
		if (Status != ServiceStatus.Running && Status != ServiceStatus.Stopping)
		{
			return;
		}
		object obj = yaPZTYnwpw;
		int num = 0;
		if (Y5IBtRr5H78Tg4HXUqK != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		bool lockTaken = false;
		try
		{
			Monitor.Enter(obj, ref lockTaken);
			Queue<pvPYfrqviDnkOJxaihx> xmoZdbJwXQ = XmoZdbJwXQ;
			pvPYfrqviDnkOJxaihx pvPYfrqviDnkOJxaihx = new pvPYfrqviDnkOJxaihx();
			pvPYfrqviDnkOJxaihx.Data = data;
			pvPYfrqviDnkOJxaihx.Q719FXsUCF(isEnd);
			xmoZdbJwXQ.Enqueue(pvPYfrqviDnkOJxaihx);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(obj);
			}
		}
	}

	public bool Stop()
	{
		try
		{
			if (Status != ServiceStatus.Stopped)
			{
				Status = ServiceStatus.Stopping;
				Convert(null, true);
			}
			return true;
		}
		catch (Exception ex)
		{
			YxSZOHh9qL?.Invoke(this, new ErrorEventArgs
			{
				Code = ResultCode.Warning,
				Message = ex.Message,
				Exception = ex
			});
			return false;
		}
	}

	[AsyncStateMachine(typeof(_003CStartConvert_003Ed__29))]
	private void pQZZKTKqoY()
	{
		_003CStartConvert_003Ed__29 stateMachine = default(_003CStartConvert_003Ed__29);
		stateMachine._003C_003Et__builder = AsyncVoidMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(_003CDoFragmentAsr_003Ed__31))]
	private Task<ResultModel<string>> IAMZx6xv9N(byte[] byte_0, FrameState frameState_1 = FrameState.First)
	{
		_003CDoFragmentAsr_003Ed__31 stateMachine = default(_003CDoFragmentAsr_003Ed__31);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ResultModel<string>>.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.data = byte_0;
		stateMachine.state = frameState_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CStartReceiving_003Ed__32))]
	private Task VL1ZrrdEjn(ClientWebSocket clientWebSocket_1)
	{
		_003CStartReceiving_003Ed__32 stateMachine = default(_003CStartReceiving_003Ed__32);
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E4__this = this;
		stateMachine.client = clientWebSocket_1;
		stateMachine._003C_003E1__state = -1;
		stateMachine._003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private void mEDZpdMCCP()
	{
		YL5ZnrXyiQ = FrameState.First;
		lK3Z4mAo8u = null;
		xJJZ5eN0oH = null;
		zGjZM505C2 = null;
		GTlZDmJD2K.okwhN73WT3();
		ipQZoxqLW9.Clear();
		Status = ((Status == ServiceStatus.Stopping) ? ServiceStatus.Stopped : ServiceStatus.InnerStop);
		object obj = yaPZTYnwpw;
		int num = 0;
		if (Y5IBtRr5H78Tg4HXUqK != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		bool lockTaken = false;
		try
		{
			Monitor.Enter(obj, ref lockTaken);
			XmoZdbJwXQ.Clear();
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(obj);
			}
		}
	}

	private byte[] awAZBWASwB(byte[] byte_0, int int_0, int int_1)
	{
		if (int_0 >= 0 && int_0 <= byte_0.Length && int_1 >= 0)
		{
			byte[] array;
			if (int_0 + int_1 <= byte_0.Length)
			{
				int num = 0;
				if (!LYe2P6rY9bp2r5GRi24())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				array = new byte[int_1];
				Array.Copy(byte_0, int_0, array, 0, int_1);
			}
			else
			{
				array = new byte[byte_0.Length - int_0];
				Array.Copy(byte_0, int_0, array, 0, byte_0.Length - int_0);
			}
			return array;
		}
		return null;
	}

	public void Dispose()
	{
		try
		{
			zGjZM505C2?.Dispose();
			zGjZM505C2 = null;
			if (xJJZ5eN0oH == null || xJJZ5eN0oH.State != WebSocketState.Open)
			{
				return;
			}
			ClientWebSocket clientWebSocket = xJJZ5eN0oH;
			if (clientWebSocket != null)
			{
				clientWebSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "关闭", CancellationToken.None).Wait(100);
				if (!LYe2P6rY9bp2r5GRi24())
				{
					switch (0)
					{
					}
				}
			}
			xJJZ5eN0oH?.Dispose();
			xJJZ5eN0oH = null;
		}
		catch (Exception ex)
		{
			ca0ZzJ8iZx.Warn("释放资源出错：" + ex.Message);
		}
	}

	static ASRApi()
	{
		yaPZTYnwpw = new object();
		ca0ZzJ8iZx = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	[CompilerGenerated]
	private void g8wZQWflQX()
	{
		pQZZKTKqoY();
	}

	internal static bool LYe2P6rY9bp2r5GRi24()
	{
		return Y5IBtRr5H78Tg4HXUqK == null;
	}

	internal static void SG0gDIrPl1lkK77l3nl()
	{
	}
}
