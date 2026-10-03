using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using EOqy55MyMeuU2apYyog;
using FontAwesome5;
using GuvA3OiyFyyWpKJlb8c;
using HandyControl.Tools;
using Quicker.Domain.Actions.X.BuiltinRunners.Misc;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Actions.X.Variables;
using Quicker.Modules.TextTools;
using Quicker.Public.Actions;
using Quicker.Public.Entities;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Win32;
using Quicker.View;
using SCyJThYoNMQE7IHLXbA;
using ViNASxihuuLY1Gg9m6p;

namespace Quicker.Domain.Actions.X.BuiltinRunners;

public class SelectStep : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec enVvffa4fty;

		public static Func<KeyValuePair<string, object>, SimpleOperationItem> D1ZvfzkMBv9;

		public static Func<SimpleOperationItem, string> gbCvzwV22jK;

		public static Func<CommonOperationItem, SimpleOperationItem> mflvztdGVbu;

		public static Func<SimpleOperationItem, string> bm6vzgQUphN;

		public static Func<SimpleOperationItem, string> X2mvzL82CfO;

		public static Func<object> qCMvzvT5VuY;

		internal static _003C_003Ec FwYLClW3leWVZiIjjxf7;

		static _003C_003Ec()
		{
			enVvffa4fty = new _003C_003Ec();
		}

		internal SimpleOperationItem WLcvfOlmKVr(KeyValuePair<string, object> pair)
		{
			SimpleOperationItem simpleOperationItem = new SimpleOperationItem();
			object value = pair.Value;
			object obj;
			if (value == null)
			{
				obj = null;
			}
			else
			{
				obj = value.ToString();
				if (obj != null)
				{
					goto IL_0022;
				}
			}
			obj = "";
			goto IL_0022;
			IL_0044:
			object obj2;
			simpleOperationItem.Name = (string)obj2;
			simpleOperationItem.Data = pair.Value;
			string key = pair.Key;
			object obj3;
			if (key == null)
			{
				obj3 = null;
			}
			else
			{
				obj3 = key.ToString();
				if (obj3 != null)
				{
					goto IL_0073;
				}
			}
			obj3 = "";
			goto IL_0073;
			IL_0073:
			simpleOperationItem.OriginText = (string)obj3;
			return simpleOperationItem;
			IL_0022:
			simpleOperationItem.Key = (string)obj;
			string key2 = pair.Key;
			if (key2 == null)
			{
				obj2 = null;
			}
			else
			{
				obj2 = key2.ToString();
				if (obj2 != null)
				{
					goto IL_0044;
				}
			}
			obj2 = "";
			goto IL_0044;
		}

		internal string HKHvfFFV1tS(SimpleOperationItem x)
		{
			return x.Name;
		}

		internal SimpleOperationItem L2LvfUe4GhD(CommonOperationItem x)
		{
			return new SimpleOperationItem
			{
				Key = x.Data,
				Name = x.Title,
				Data = x.Data,
				OriginText = x.Title,
				Icon = x.Icon,
				Description = x.Description
			};
		}

		internal string wB5vfl0pwSV(SimpleOperationItem x)
		{
			return x.Key;
		}

		internal string LFvvfiwtHcO(SimpleOperationItem x)
		{
			return x.OriginText;
		}

		internal object KpZvf3uGaZJ()
		{
			return "";
		}

		internal static bool Bw3DIHW3Zc5dl3ZIoDM5()
		{
			return FwYLClW3leWVZiIjjxf7 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass82_0
	{
		public ActionStep Sfmvz2OnuIT;

		public ActionExecuteContext wykvzuYkFB4;

		public XAction Xg6vzNfDDfv;

		internal static _003C_003Ec__DisplayClass82_0 HiIbcnW3gQp5c80KMnbx;

		internal (bool isSuccess, string message, ActionStopFlag failReason) rCrvzSywS51()
		{
			_003C_003Ec__DisplayClass82_1 _003C_003Ec__DisplayClass82_ = new _003C_003Ec__DisplayClass82_1
			{
				vWUvzx0RMkS = this
			};
			string textParamValue = XActionHelper.GetTextParamValue(JgStFaqBiK3, Sfmvz2OnuIT, wykvzuYkFB4);
			_003C_003Ec__DisplayClass82_.CsovzaR9NqT = textParamValue == "multi";
			_003C_003Ec__DisplayClass82_.dtFvzbPl405 = XActionHelper.GetTextParamValue(W21tF7UDgsN, Sfmvz2OnuIT, wykvzuYkFB4);
			_003C_003Ec__DisplayClass82_.BVevz6HVhyO = XActionHelper.GetTextParamValue(IBStFRDlAhg, Sfmvz2OnuIT, wykvzuYkFB4);
			_003C_003Ec__DisplayClass82_.pxrvzeLb0t3 = XActionHelper.GetTextParamValue(RfFtFpirf6H, Sfmvz2OnuIT, wykvzuYkFB4);
			_003C_003Ec__DisplayClass82_.IEZvzH8dE0S = XActionHelper.GetTextParamValue(wO4tFcZWuYB, Sfmvz2OnuIT, wykvzuYkFB4);
			string textParamValue2 = XActionHelper.GetTextParamValue(z7KtFZwyVkJ, Sfmvz2OnuIT, wykvzuYkFB4);
			_003C_003Ec__DisplayClass82_.Xl5vzKD2KTo = XActionHelper.GetBooleanParamValue(j6ctFshWylO, Sfmvz2OnuIT, wykvzuYkFB4);
			_003C_003Ec__DisplayClass82_.twGvz14O60Y = Convert.ToDouble(XActionHelper.GetNumberParamValue(OAGtFe6UO0q, Sfmvz2OnuIT, wykvzuYkFB4));
			_003C_003Ec__DisplayClass82_.WDEvzqCXMrV = XActionHelper.GetBooleanParamValue(CGttFI6WhaT, Sfmvz2OnuIT, wykvzuYkFB4);
			_003C_003Ec__DisplayClass82_.A5IvzkirJ79 = XActionHelper.GetTextParamValue(x21tFhY7AZQ, Sfmvz2OnuIT, wykvzuYkFB4);
			_003C_003Ec__DisplayClass82_.RysvzcTlfuj = XActionHelper.GetBooleanParamValue(CGYtFHVIgwh, Sfmvz2OnuIT, wykvzuYkFB4);
			_003C_003Ec__DisplayClass82_.n1HvzYA8rGw = XActionHelper.GetBooleanParamValue(w35tF10tQKY, Sfmvz2OnuIT, wykvzuYkFB4);
			_003C_003Ec__DisplayClass82_.I8HvzEWCwxJ = XActionHelper.GetTextParamValue(YPptF9dRwjP, Sfmvz2OnuIT, wykvzuYkFB4);
			_003C_003Ec__DisplayClass82_.cvivz9bdV59 = XActionHelper.GetTextParamValue(KU3tFksEw3c, Sfmvz2OnuIT, wykvzuYkFB4);
			_003C_003Ec__DisplayClass82_.B5bvzPcETJo = ShowWindowLocation.Auto;
			if (!string.IsNullOrEmpty(textParamValue2))
			{
				_003C_003Ec__DisplayClass82_.B5bvzPcETJo = (ShowWindowLocation)Enum.Parse(typeof(ShowWindowLocation), textParamValue2);
			}
			_003C_003Ec__DisplayClass82_.kAJvzIxP9bJ = XActionHelper.GetBooleanParamValue(SpMtFbGsfwS, Sfmvz2OnuIT, wykvzuYkFB4);
			_003C_003Ec__DisplayClass82_.WK4vz8Uk7Zy = !XActionHelper.GetBooleanParamValue(vGXtFYGpseR, Sfmvz2OnuIT, wykvzuYkFB4);
			_003C_003Ec__DisplayClass82_.saPvzRc73L3 = XActionHelper.GetNumberParamValue(kkGtFmrmSAa, Sfmvz2OnuIT, wykvzuYkFB4);
			_003C_003Ec__DisplayClass82_.QsMvzhxPDfa = XActionHelper.GetNumberParamValue(RDMtFxYFeMq, Sfmvz2OnuIT, wykvzuYkFB4);
			_003C_003Ec__DisplayClass82_.PSjvzW3T5Fq = XActionHelper.GetTextParamValue(mcAtFKplHkV, Sfmvz2OnuIT, wykvzuYkFB4);
			_003C_003Ec__DisplayClass82_.IBVvzsa7ocP = null;
			if (_003C_003Ec__DisplayClass82_.CsovzaR9NqT)
			{
				_003C_003Ec__DisplayClass82_.IBVvzsa7ocP = XActionHelper.GetListParamValue(OaCtFVw3DE7, Sfmvz2OnuIT, wykvzuYkFB4);
			}
			_003C_003Ec__DisplayClass82_.UTKvzCJfgyq = XActionHelper.GetTextParamValue(M5gtFrM2iZq, Sfmvz2OnuIT, wykvzuYkFB4);
			_003C_003Ec__DisplayClass82_.s3KvzysZm8G = null;
			object paramValue = XActionHelper.GetParamValue(qOhtFqoZfBT, Sfmvz2OnuIT, wykvzuYkFB4, false, true);
			if (paramValue is IDictionary<string, object> source)
			{
				_003C_003Ec__DisplayClass82_.s3KvzysZm8G = source.Select(_003C_003Ec.D1ZvfzkMBv9 ?? (_003C_003Ec.D1ZvfzkMBv9 = _003C_003Ec.enVvffa4fty.WLcvfOlmKVr)).OrderBy(_003C_003Ec.gbCvzwV22jK ?? (_003C_003Ec.gbCvzwV22jK = _003C_003Ec.enVvffa4fty.HKHvfFFV1tS)).ToList();
			}
			else if (paramValue is IList<CommonOperationItem> source2)
			{
				_003C_003Ec__DisplayClass82_.s3KvzysZm8G = source2.Select(_003C_003Ec.mflvztdGVbu ?? (_003C_003Ec.mflvztdGVbu = _003C_003Ec.enVvffa4fty.L2LvfUe4GhD)).ToList();
			}
			else
			{
				string items = VariableHelper.ConvertToType(VarType.Text, paramValue).ToString();
				_003C_003Ec__DisplayClass82_.s3KvzysZm8G = AppHelper.StringToOperationItems(items, true);
			}
			string textParamValue3 = XActionHelper.GetTextParamValue(syLtFXoTdgS, Sfmvz2OnuIT, wykvzuYkFB4);
			_003C_003Ec__DisplayClass82_.FCfvzVCWHBB = null;
			if (!string.IsNullOrEmpty(textParamValue3))
			{
				_003C_003Ec__DisplayClass82_.FCfvzVCWHBB = AppHelper.StringToOperationItems(textParamValue3, false, true);
			}
			string textParamValue4 = XActionHelper.GetTextParamValue(eLKtFWr0WPB, Sfmvz2OnuIT, wykvzuYkFB4);
			_003C_003Ec__DisplayClass82_.NWkvzZK4Iur = XActionHelper.GetTextParamValue(tpmtFGBJIFa, Sfmvz2OnuIT, wykvzuYkFB4);
			_003C_003Ec__DisplayClass82_.deGvz7qTGhT = false;
			switch (textParamValue4)
			{
			default:
				_003C_003Ec__DisplayClass82_.deGvz7qTGhT = _003C_003Ec__DisplayClass82_.s3KvzysZm8G.Count > 10;
				break;
			case "1":
				_003C_003Ec__DisplayClass82_.deGvz7qTGhT = true;
				break;
			case "0":
				_003C_003Ec__DisplayClass82_.deGvz7qTGhT = false;
				break;
			}
			if (!string.IsNullOrWhiteSpace(_003C_003Ec__DisplayClass82_.cvivz9bdV59))
			{
				_003C_003Ec__DisplayClass82_.deGvz7qTGhT = true;
			}
			if (!_003C_003Ec__DisplayClass82_.WK4vz8Uk7Zy & _003C_003Ec__DisplayClass82_.deGvz7qTGhT)
			{
				wykvzuYkFB4.ActionLogger.LogWarning("仅在启用键盘焦点时才支持筛选。");
				_003C_003Ec__DisplayClass82_.deGvz7qTGhT = false;
			}
			_003C_003Ec__DisplayClass82_.dk2vzX2tA52 = false;
			_003C_003Ec__DisplayClass82_.du5vzmnOvem = "";
			if (_003C_003Ec__DisplayClass82_.WK4vz8Uk7Zy)
			{
				Thread.Sleep(100);
			}
			if (!Guid.TryParse(wykvzuYkFB4.RootContext.ActionId, out _003C_003Ec__DisplayClass82_.WTAvzGYlPCs))
			{
				_003C_003Ec__DisplayClass82_.WTAvzGYlPCs = Guid.Empty;
			}
			AppHelper.ByuLTpc7Q9J(_003C_003Ec__DisplayClass82_.GO9vzJKcfMD).GetAwaiter().GetResult();
			if (_003C_003Ec__DisplayClass82_.WK4vz8Uk7Zy & _003C_003Ec__DisplayClass82_.Xl5vzKD2KTo)
			{
				Thread.Sleep(100);
			}
			if (_003C_003Ec__DisplayClass82_.dk2vzX2tA52 != true)
			{
				return (isSuccess: false, message: "用户取消", failReason: ActionStopFlag.UserCancel);
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static void Ndn95pW3UOX12k2qVeNs()
		{
		}

		internal static bool cQFtOEW3PDuTmrP2las8()
		{
			return HiIbcnW3gQp5c80KMnbx == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass82_1
	{
		[StructLayout(LayoutKind.Auto)]
		private struct FK1SrOkPGvC7eWq6eyD : IAsyncStateMachine
		{
			public int weD2qzjJWrr;

			public AsyncTaskMethodBuilder tpa2cwXqgYj;

			public _003C_003Ec__DisplayClass82_1 TJH2ctZUFD9;

			private _003C_003Ec__DisplayClass82_2 xMo2cgFIDIB;

			private IntPtr RO62cLmJ3Lq;

			private TaskAwaiter<bool?> wa92cvrUdqQ;

			private static object E7Qa0iyfvdEAZh7RMtdh;

			private void MoveNext()
			{
				int num = weD2qzjJWrr;
				_003C_003Ec__DisplayClass82_1 _003C_003Ec__DisplayClass82_ = TJH2ctZUFD9;
				try
				{
					int num2;
					if (num != 0)
					{
						xMo2cgFIDIB = new _003C_003Ec__DisplayClass82_2();
						xMo2cgFIDIB.mNrvzjEwsac = _003C_003Ec__DisplayClass82_;
						RO62cLmJ3Lq = NativeMethods.GetForegroundWindow();
						num2 = 0;
						if (E7Qa0iyfvdEAZh7RMtdh != null)
						{
							goto IL_009a;
						}
						goto IL_0644;
					}
					TaskAwaiter<bool?> awaiter = wa92cvrUdqQ;
					goto IL_0676;
					IL_0676:
					wa92cvrUdqQ = default(TaskAwaiter<bool?>);
					num = -1;
					weD2qzjJWrr = -1;
					num2 = 2;
					if (E7Qa0iyfvdEAZh7RMtdh != null)
					{
						goto IL_009a;
					}
					goto IL_0644;
					IL_0a9b:
					if (_003C_003Ec__DisplayClass82_.Xl5vzKD2KTo && RO62cLmJ3Lq != IntPtr.Zero)
					{
						if (_003C_003Ec__DisplayClass82_.vWUvzx0RMkS.wykvzuYkFB4.IsDebugging)
						{
							_003C_003Ec__DisplayClass82_.vWUvzx0RMkS.wykvzuYkFB4.ActionLogger?.LogInfo($"恢复焦点窗口到：{RO62cLmJ3Lq}");
						}
						AppHelper.SetForegroundWindow(RO62cLmJ3Lq);
					}
					else
					{
						IntPtr lastForegroundWindow = AppState.AppServer.GetLastForegroundWindow();
						if (lastForegroundWindow != xMo2cgFIDIB.xfDvzQe9M3k.Hwnd)
						{
							AppHelper.SetForegroundWindow(lastForegroundWindow);
						}
						else
						{
							AppHelper.SetForegroundWindow(AppState.AppServer.GetLastForegroundWindowNotOfQuicker());
						}
					}
					goto end_IL_0010;
					IL_009a:
					int num3 = default(int);
					num2 = num3;
					goto IL_0644;
					IL_0644:
					_003C_003Ec__DisplayClass82_3 _003C_003Ec__DisplayClass82_2 = default(_003C_003Ec__DisplayClass82_3);
					List<string> result = default(List<string>);
					while (true)
					{
						object obj;
						switch (num2)
						{
						case 9:
							break;
						case 8:
							AppHelper.SetWindowIcon(xMo2cgFIDIB.xfDvzQe9M3k, _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.wykvzuYkFB4?.Action?.Icon, true);
							if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass82_.PSjvzW3T5Fq))
							{
								xMo2cgFIDIB.xfDvzQe9M3k.zmFg3I8s7IB(_003C_003Ec__DisplayClass82_.PSjvzW3T5Fq);
							}
							ANAtF0BiRTy(_003C_003Ec__DisplayClass82_.vWUvzx0RMkS.wykvzuYkFB4, _003C_003Ec__DisplayClass82_.A5IvzkirJ79, _003C_003Ec__DisplayClass82_.WTAvzGYlPCs, xMo2cgFIDIB.xfDvzQe9M3k, _003C_003Ec__DisplayClass82_.I8HvzEWCwxJ);
							if (_003C_003Ec__DisplayClass82_.CsovzaR9NqT)
							{
								xMo2cgFIDIB.xfDvzQe9M3k.PreSelectedItems = _003C_003Ec__DisplayClass82_.IBVvzsa7ocP;
							}
							else
							{
								xMo2cgFIDIB.xfDvzQe9M3k.PreSelectedKey = _003C_003Ec__DisplayClass82_.IEZvzH8dE0S;
							}
							xMo2cgFIDIB.xfDvzQe9M3k.AutoCloseSeconds = _003C_003Ec__DisplayClass82_.twGvz14O60Y;
							xMo2cgFIDIB.xfDvzQe9M3k.UseKeyboard = _003C_003Ec__DisplayClass82_.WK4vz8Uk7Zy;
							if (_003C_003Ec__DisplayClass82_.vWUvzx0RMkS.wykvzuYkFB4.ParentWindow.zmGvuiv40H0())
							{
								xMo2cgFIDIB.xfDvzQe9M3k.Owner = _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.wykvzuYkFB4.ParentWindow;
							}
							xMo2cgFIDIB.xfDvzQe9M3k.Title = _003C_003Ec__DisplayClass82_.dtFvzbPl405.ToShortString(15);
							if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass82_.BVevz6HVhyO))
							{
								string text = _003C_003Ec__DisplayClass82_.dtFvzbPl405;
								if (text != null && text.Length > 15)
								{
									_003C_003Ec__DisplayClass82_.BVevz6HVhyO = _003C_003Ec__DisplayClass82_.dtFvzbPl405;
								}
							}
							if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass82_.BVevz6HVhyO))
							{
								goto IL_022f;
							}
							goto IL_0244;
						case 2:
						{
							bool? result2 = awaiter.GetResult();
							_003C_003Ec__DisplayClass82_.dk2vzX2tA52 = result2;
							if (_003C_003Ec__DisplayClass82_.dk2vzX2tA52 != true)
							{
								if (!XActionHelper.GetBooleanParamValue(DGftF6nax2t, _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.Sfmvz2OnuIT, _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.wykvzuYkFB4))
								{
									XActionHelper.OutputResult(OMKtF47mSEJ, _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.Sfmvz2OnuIT, _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.wykvzuYkFB4, new List<string>(), _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.Xg6vzNfDDfv);
									XActionHelper.OutputResult(WJ2tFQcPZEr, _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.Sfmvz2OnuIT, _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.wykvzuYkFB4, "", _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.Xg6vzNfDDfv);
									XActionHelper.OutputResult(vATtFjeWiho, _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.Sfmvz2OnuIT, _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.wykvzuYkFB4, -1, _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.Xg6vzNfDDfv);
									XActionHelper.OutputResultIfNeeded(yRetFDjaPSV, _003C_003Ec.qCMvzvT5VuY ?? (_003C_003Ec.qCMvzvT5VuY = _003C_003Ec.enVvffa4fty.KpZvf3uGaZJ), _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.Sfmvz2OnuIT, _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.wykvzuYkFB4, _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.Xg6vzNfDDfv);
									num2 = 9;
									if (R6jI4tyfd0tViKoHZGOE())
									{
										continue;
									}
									goto case 4;
								}
								goto IL_0955;
							}
							if (_003C_003Ec__DisplayClass82_.CsovzaR9NqT)
							{
								_003C_003Ec__DisplayClass82_2 = new _003C_003Ec__DisplayClass82_3();
								_003C_003Ec__DisplayClass82_2.HOevzDtxGse = xMo2cgFIDIB;
								_003C_003Ec__DisplayClass82_2.zPBvz5gQFpb = _003C_003Ec__DisplayClass82_2.HOevzDtxGse.xfDvzQe9M3k.GetSelectedItems();
								result = _003C_003Ec__DisplayClass82_2.zPBvz5gQFpb.Select(_003C_003Ec.bm6vzgQUphN ?? (_003C_003Ec.bm6vzgQUphN = _003C_003Ec.enVvffa4fty.wB5vfl0pwSV)).ToList();
								num2 = 1;
								if (E7Qa0iyfvdEAZh7RMtdh == null)
								{
									continue;
								}
								goto case 1;
							}
							SimpleOperationItem selectedItem = xMo2cgFIDIB.xfDvzQe9M3k.SelectedItem;
							if (selectedItem == null)
							{
								obj = null;
							}
							else
							{
								obj = selectedItem.Key;
								if (obj != null)
								{
									goto IL_07da;
								}
							}
							obj = "";
							goto IL_07da;
						}
						case 5:
							xMo2cgFIDIB.xfDvzQe9M3k.Note = _003C_003Ec__DisplayClass82_.BVevz6HVhyO;
							goto IL_0244;
						default:
						{
							NativeMethods.RECT? rECT = null;
							if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass82_.UTKvzCJfgyq))
							{
								SelectOperationWindow selectOperationWindow = AppHelper.FindRootWindows<SelectOperationWindow>().FirstOrDefault(_003C_003Ec__DisplayClass82_.aYivzrSShke ?? (_003C_003Ec__DisplayClass82_.aYivzrSShke = _003C_003Ec__DisplayClass82_.XLbvz0SEndJ));
								if (selectOperationWindow != null)
								{
									rECT = NativeMethods.GetWindowRectangle(selectOperationWindow.GetHandle());
									selectOperationWindow.Close();
									_003C_003Ec__DisplayClass82_.B5bvzPcETJo = ShowWindowLocation.Manual;
									_003C_003Ec__DisplayClass82_.I8HvzEWCwxJ = $"{rECT.Value.Left},{rECT.Value.Top},{rECT.Value.Right},{rECT.Value.Bottom}";
								}
							}
							xMo2cgFIDIB.xfDvzQe9M3k = new SelectOperationWindow(_003C_003Ec__DisplayClass82_.s3KvzysZm8G, _003C_003Ec__DisplayClass82_.B5bvzPcETJo, _003C_003Ec__DisplayClass82_.WK4vz8Uk7Zy, _003C_003Ec__DisplayClass82_.CsovzaR9NqT, _003C_003Ec__DisplayClass82_.deGvz7qTGhT, _003C_003Ec__DisplayClass82_.saPvzRc73L3)
							{
								CloseOnDeactivated = _003C_003Ec__DisplayClass82_.WDEvzqCXMrV,
								AllowOkWhenEmpty = _003C_003Ec__DisplayClass82_.RysvzcTlfuj,
								ExtraOperations = _003C_003Ec__DisplayClass82_.FCfvzVCWHBB,
								ImeState = _003C_003Ec__DisplayClass82_.NWkvzZK4Iur,
								FilterContent = _003C_003Ec__DisplayClass82_.cvivz9bdV59,
								ListIconSize = Math.Max(1.0, _003C_003Ec__DisplayClass82_.QsMvzhxPDfa),
								WindowKey = _003C_003Ec__DisplayClass82_.UTKvzCJfgyq,
								HelpText = _003C_003Ec__DisplayClass82_.pxrvzeLb0t3,
								EnableQuickConfirm = _003C_003Ec__DisplayClass82_.n1HvzYA8rGw,
								Topmost = _003C_003Ec__DisplayClass82_.kAJvzIxP9bJ
							};
							xMo2cgFIDIB.xfDvzQe9M3k.V6hgjEnp8ZH(_003C_003Ec__DisplayClass82_.vWUvzx0RMkS.wykvzuYkFB4.CancellationToken);
							num2 = 8;
							if (R6jI4tyfd0tViKoHZGOE())
							{
								continue;
							}
							goto case 8;
						}
						case 7:
							goto end_IL_0644;
						case 6:
							return;
						case 4:
							XActionHelper.OutputResult(IfNtFos0pJD, _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.Sfmvz2OnuIT, _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.wykvzuYkFB4, "", _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.Xg6vzNfDDfv);
							goto IL_0955;
						case 1:
							XActionHelper.OutputResult(OMKtF47mSEJ, _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.Sfmvz2OnuIT, _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.wykvzuYkFB4, result, _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.Xg6vzNfDDfv);
							goto case 3;
						case 3:
							{
								XActionHelper.OutputResultIfNeeded(yRetFDjaPSV, _003C_003Ec__DisplayClass82_2.k1tvzntmCqy, _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.Sfmvz2OnuIT, _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.wykvzuYkFB4, _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.Xg6vzNfDDfv);
								XActionHelper.OutputResultIfNeeded(eB5tFnh8T14, _003C_003Ec__DisplayClass82_2.DLPvz4HRM3q, _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.Sfmvz2OnuIT, _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.wykvzuYkFB4, _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.Xg6vzNfDDfv);
								goto IL_08d7;
							}
							IL_08d7:
							XActionHelper.OutputResult(MHLtF5mLeJb, _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.Sfmvz2OnuIT, _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.wykvzuYkFB4, xMo2cgFIDIB.xfDvzQe9M3k.SelectedOperation, _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.Xg6vzNfDDfv);
							XActionHelper.OutputResult(IfNtFos0pJD, _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.Sfmvz2OnuIT, _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.wykvzuYkFB4, xMo2cgFIDIB.xfDvzQe9M3k.FilterContent, _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.Xg6vzNfDDfv);
							goto IL_0955;
							IL_0955:
							_003C_003Ec__DisplayClass82_.vWUvzx0RMkS.wykvzuYkFB4.RootContext.States["LAST_SELECT_WINDOW_POSITION"] = new Point(xMo2cgFIDIB.xfDvzQe9M3k.Left, xMo2cgFIDIB.xfDvzQe9M3k.Top);
							_003C_003Ec__DisplayClass82_.vWUvzx0RMkS.wykvzuYkFB4.RootContext.States["LAST_SELECT_WINDOW_SIZE_KEY"] = new Size(xMo2cgFIDIB.xfDvzQe9M3k.ActualWidth, xMo2cgFIDIB.xfDvzQe9M3k.ActualHeight);
							if (_003C_003Ec__DisplayClass82_.WTAvzGYlPCs != Guid.Empty)
							{
								ActionStateWriter.WriteActionState(_003C_003Ec__DisplayClass82_.vWUvzx0RMkS.wykvzuYkFB4.RootContext.ActionId, "sys:select_window_location", $"{xMo2cgFIDIB.xfDvzQe9M3k.Left},{xMo2cgFIDIB.xfDvzQe9M3k.Top},{xMo2cgFIDIB.xfDvzQe9M3k.Width},{xMo2cgFIDIB.xfDvzQe9M3k.Height}");
							}
							if (_003C_003Ec__DisplayClass82_.WK4vz8Uk7Zy)
							{
								goto IL_0a9b;
							}
							goto end_IL_0010;
							IL_0244:
							if (AppState.HS2taepcAbc().IsVisible)
							{
								xMo2cgFIDIB.xfDvzQe9M3k.Topmost = true;
							}
							awaiter = xMo2cgFIDIB.xfDvzQe9M3k.MjdLOXIjD10(_003C_003Ec__DisplayClass82_.WK4vz8Uk7Zy).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 0;
								weD2qzjJWrr = 0;
								wa92cvrUdqQ = awaiter;
								tpa2cwXqgYj.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 6;
								return;
							}
							goto case 2;
							IL_07da:
							_003C_003Ec__DisplayClass82_.du5vzmnOvem = (string)obj;
							XActionHelper.OutputResult(WJ2tFQcPZEr, _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.Sfmvz2OnuIT, _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.wykvzuYkFB4, _003C_003Ec__DisplayClass82_.du5vzmnOvem, _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.Xg6vzNfDDfv);
							XActionHelper.OutputResult(vATtFjeWiho, _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.Sfmvz2OnuIT, _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.wykvzuYkFB4, xMo2cgFIDIB.xfDvzQe9M3k.SelectedIndex, _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.Xg6vzNfDDfv);
							XActionHelper.OutputResultIfNeeded(yRetFDjaPSV, xMo2cgFIDIB.xIPvzpmMQZT, _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.Sfmvz2OnuIT, _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.wykvzuYkFB4, _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.Xg6vzNfDDfv);
							XActionHelper.OutputResultIfNeeded(DDatFdcO7oC, xMo2cgFIDIB.MTVvzBOFG0X, _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.Sfmvz2OnuIT, _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.wykvzuYkFB4, _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.Xg6vzNfDDfv);
							goto IL_08d7;
						}
						XActionHelper.OutputResult(MHLtF5mLeJb, _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.Sfmvz2OnuIT, _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.wykvzuYkFB4, "", _003C_003Ec__DisplayClass82_.vWUvzx0RMkS.Xg6vzNfDDfv);
						num2 = 4;
						if (E7Qa0iyfvdEAZh7RMtdh == null)
						{
							continue;
						}
						goto IL_009a;
						IL_022f:
						num2 = 5;
						if (R6jI4tyfd0tViKoHZGOE())
						{
							continue;
						}
						goto IL_009a;
						continue;
						end_IL_0644:
						break;
					}
					goto IL_0676;
					end_IL_0010:;
				}
				catch (Exception exception)
				{
					weD2qzjJWrr = -2;
					xMo2cgFIDIB = null;
					tpa2cwXqgYj.SetException(exception);
					return;
				}
				weD2qzjJWrr = -2;
				xMo2cgFIDIB = null;
				tpa2cwXqgYj.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				tpa2cwXqgYj.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool R6jI4tyfd0tViKoHZGOE()
			{
				return E7Qa0iyfvdEAZh7RMtdh == null;
			}
		}

		public string UTKvzCJfgyq;

		public ShowWindowLocation B5bvzPcETJo;

		public string I8HvzEWCwxJ;

		public List<SimpleOperationItem> s3KvzysZm8G;

		public bool WK4vz8Uk7Zy;

		public bool CsovzaR9NqT;

		public bool deGvz7qTGhT;

		public double saPvzRc73L3;

		public bool WDEvzqCXMrV;

		public bool RysvzcTlfuj;

		public List<SimpleOperationItem> FCfvzVCWHBB;

		public string NWkvzZK4Iur;

		public string cvivz9bdV59;

		public double QsMvzhxPDfa;

		public string pxrvzeLb0t3;

		public bool n1HvzYA8rGw;

		public bool kAJvzIxP9bJ;

		public string PSjvzW3T5Fq;

		public string A5IvzkirJ79;

		public Guid WTAvzGYlPCs;

		public IList<string> IBVvzsa7ocP;

		public string IEZvzH8dE0S;

		public double twGvz14O60Y;

		public string dtFvzbPl405;

		public string BVevz6HVhyO;

		public bool? dk2vzX2tA52;

		public string du5vzmnOvem;

		public bool Xl5vzKD2KTo;

		public _003C_003Ec__DisplayClass82_0 vWUvzx0RMkS;

		public Func<SelectOperationWindow, bool> aYivzrSShke;

		internal static _003C_003Ec__DisplayClass82_1 gOYK7RW3xddRWQg9NBMK;

		[AsyncStateMachine(typeof(FK1SrOkPGvC7eWq6eyD))]
		internal Task GO9vzJKcfMD()
		{
			FK1SrOkPGvC7eWq6eyD stateMachine = default(FK1SrOkPGvC7eWq6eyD);
			stateMachine.tpa2cwXqgYj = AsyncTaskMethodBuilder.Create();
			stateMachine.TJH2ctZUFD9 = this;
			stateMachine.weD2qzjJWrr = -1;
			stateMachine.tpa2cwXqgYj.Start(ref stateMachine);
			return stateMachine.tpa2cwXqgYj.Task;
		}

		internal bool XLbvz0SEndJ(SelectOperationWindow x)
		{
			return x.WindowKey == UTKvzCJfgyq;
		}

		internal static bool sID3ceW3IuSe1YISnxtZ()
		{
			return gOYK7RW3xddRWQg9NBMK == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass82_2
	{
		public SelectOperationWindow xfDvzQe9M3k;

		public _003C_003Ec__DisplayClass82_1 mNrvzjEwsac;

		internal static _003C_003Ec__DisplayClass82_2 XOQcs7W3SwxOkYnYLOMZ;

		internal object xIPvzpmMQZT()
		{
			SimpleOperationItem selectedItem = xfDvzQe9M3k.SelectedItem;
			object obj;
			if (selectedItem == null)
			{
				obj = null;
			}
			else
			{
				obj = selectedItem.OriginText;
				if (obj != null)
				{
					goto IL_0020;
				}
			}
			obj = "";
			goto IL_0020;
			IL_0020:
			return obj;
		}

		internal object MTVvzBOFG0X()
		{
			return xfDvzQe9M3k.SelectedItem?.Name;
		}

		internal static bool tJ85iaW3wglUGsHS4stu()
		{
			return XOQcs7W3SwxOkYnYLOMZ == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass82_3
	{
		public IList<SimpleOperationItem> zPBvz5gQFpb;

		public _003C_003Ec__DisplayClass82_2 HOevzDtxGse;

		internal static _003C_003Ec__DisplayClass82_3 fAaGwFW3mGmUesDHSINq;

		internal object k1tvzntmCqy()
		{
			return zPBvz5gQFpb.Select(_003C_003Ec.X2mvzL82CfO ?? (_003C_003Ec.X2mvzL82CfO = _003C_003Ec.enVvffa4fty.LFvvfiwtHcO)).ToList();
		}

		internal object DLPvz4HRM3q()
		{
			List<string> list = new List<string>();
			foreach (SimpleOperationItem item in zPBvz5gQFpb)
			{
				list.Add(HOevzDtxGse.mNrvzjEwsac.s3KvzysZm8G.IndexOf(item).ToString());
			}
			return list;
		}

		internal static bool kVL3m7W3s7VKXDo9RB8M()
		{
			return fAaGwFW3mGmUesDHSINq == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> VZ4tFClPqPE = new string[3] { "选择", "选项", "select" };

	[CompilerGenerated]
	private readonly string V1dtFPPqEgx = $"fa:{EFontAwesomeIcon.Light_Ballot}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> DCTtFE0k9Zq = new StepRunnerCategory[1] { StepRunnerCategory.Ui };

	[CompilerGenerated]
	private readonly string LTEtFysOk8v = "https://getquicker.net/KC/Help/Doc/userselect";

	[CompilerGenerated]
	private readonly bool t1WtF8rw5jK;

	private static readonly StepInParamDef JgStFaqBiK3;

	private static readonly StepInParamDef W21tF7UDgsN;

	private static readonly StepInParamDef IBStFRDlAhg;

	private static readonly StepInParamDef qOhtFqoZfBT;

	private static readonly StepInParamDef wO4tFcZWuYB;

	private static readonly StepInParamDef OaCtFVw3DE7;

	private static readonly StepInParamDef z7KtFZwyVkJ;

	private static readonly StepInParamDef YPptF9dRwjP;

	private static readonly StepInParamDef x21tFhY7AZQ;

	private static readonly StepInParamDef OAGtFe6UO0q;

	private static readonly StepInParamDef vGXtFYGpseR;

	private static readonly StepInParamDef CGttFI6WhaT;

	private static readonly StepInParamDef eLKtFWr0WPB;

	private static readonly StepInParamDef KU3tFksEw3c;

	private static readonly StepInParamDef tpmtFGBJIFa;

	private static readonly StepInParamDef j6ctFshWylO;

	private static readonly StepInParamDef CGYtFHVIgwh;

	private static readonly StepInParamDef w35tF10tQKY;

	private static readonly StepInParamDef SpMtFbGsfwS;

	private static readonly StepInParamDef DGftF6nax2t;

	private static readonly StepInParamDef syLtFXoTdgS;

	private static readonly StepInParamDef kkGtFmrmSAa;

	private static readonly StepInParamDef mcAtFKplHkV;

	private static readonly StepInParamDef RDMtFxYFeMq;

	private static readonly StepInParamDef M5gtFrM2iZq;

	private static readonly StepInParamDef RfFtFpirf6H;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> iyxtFBSknA3 = new StepInParamDef[26]
	{
		JgStFaqBiK3, W21tF7UDgsN, IBStFRDlAhg, qOhtFqoZfBT, wO4tFcZWuYB, OaCtFVw3DE7, eLKtFWr0WPB, KU3tFksEw3c, tpmtFGBJIFa, syLtFXoTdgS,
		kkGtFmrmSAa, mcAtFKplHkV, RDMtFxYFeMq, OAGtFe6UO0q, z7KtFZwyVkJ, YPptF9dRwjP, x21tFhY7AZQ, vGXtFYGpseR, CGttFI6WhaT, j6ctFshWylO,
		CGYtFHVIgwh, w35tF10tQKY, SpMtFbGsfwS, M5gtFrM2iZq, RfFtFpirf6H, DGftF6nax2t
	};

	private static readonly StepOutParamDef WJ2tFQcPZEr;

	private static readonly StepOutParamDef vATtFjeWiho;

	private static readonly StepOutParamDef eB5tFnh8T14;

	private static readonly StepOutParamDef OMKtF47mSEJ;

	private static readonly StepOutParamDef MHLtF5mLeJb;

	private static readonly StepOutParamDef yRetFDjaPSV;

	private static readonly StepOutParamDef DDatFdcO7oC;

	private static readonly StepOutParamDef IfNtFos0pJD;

	private static readonly StepOutParamDef lHjtFToitKn;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> A3FtFMKgFe2 = new StepOutParamDef[9] { lHjtFToitKn, WJ2tFQcPZEr, vATtFjeWiho, eB5tFnh8T14, OMKtF47mSEJ, MHLtF5mLeJb, yRetFDjaPSV, DDatFdcO7oC, IfNtFos0pJD };

	internal static SelectStep XO2g2KQZe52YKPb9FQTR;

	public string Key => "sys:select";

	public string Name => "用户选择";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return VZ4tFClPqPE;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return V1dtFPPqEgx;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Basic;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return DCTtFE0k9Zq;
		}
	}

	public string Description => "请用户选择一个选项。";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return LTEtFysOk8v;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return t1WtF8rw5jK;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return iyxtFBSknA3;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return A3FtFMKgFe2;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass82_0 _003C_003Ec__DisplayClass82_ = new _003C_003Ec__DisplayClass82_0();
		_003C_003Ec__DisplayClass82_.Sfmvz2OnuIT = step;
		_003C_003Ec__DisplayClass82_.wykvzuYkFB4 = context;
		_003C_003Ec__DisplayClass82_.Xg6vzNfDDfv = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass82_.wykvzuYkFB4, _003C_003Ec__DisplayClass82_.Sfmvz2OnuIT, _003C_003Ec__DisplayClass82_.Xg6vzNfDDfv, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass82_.rCrvzSywS51, (Action)null, (Action)null, DGftF6nax2t, lHjtFToitKn);
	}

	private static void ANAtF0BiRTy(ActionExecuteContext actionExecuteContext_0, string string_2, Guid guid_0, SelectOperationWindow selectOperationWindow_0, string string_3)
	{
		if (string_2 == "0")
		{
			selectOperationWindow_0.MaxWindowSize = string_3;
			return;
		}
		Point? point = null;
		Size? size = null;
		string[] array = default(string[]);
		if (string_2.IsEither("4", "6", "2", "8") && !actionExecuteContext_0.RootContext.States.ContainsKey("LAST_SELECT_WINDOW_POSITION") && guid_0 != Guid.Empty)
		{
			(bool, string) tuple = ActionStateWriter.ReadActionStateValue(actionExecuteContext_0.RootContext.ActionId, "sys:select_window_location");
			if (tuple.Item1)
			{
				array = tuple.Item2.Split(',');
				goto IL_01bb;
			}
		}
		goto IL_0280;
		IL_019f:
		if (actionExecuteContext_0.RootContext.States.ContainsKey("LAST_SELECT_WINDOW_SIZE_KEY"))
		{
			goto IL_011d;
		}
		goto IL_0191;
		IL_011d:
		size = (Size)actionExecuteContext_0.RootContext.States["LAST_SELECT_WINDOW_SIZE_KEY"];
		goto IL_0191;
		IL_0191:
		if (point.HasValue && IHNRIiikxBwJdYmHpM3.oCPvvFN9wvL(point.Value))
		{
			selectOperationWindow_0.WindowStartupLocation = WindowStartupLocation.Manual;
			selectOperationWindow_0.Left = point.Value.X;
			selectOperationWindow_0.Top = point.Value.Y;
			selectOperationWindow_0.Location = ShowWindowLocation.LastPosition;
		}
		int num;
		if (size.HasValue)
		{
			if (!(string_2 == "2") && !(string_2 == "1"))
			{
				num = 0;
				if (XO2g2KQZe52YKPb9FQTR != null)
				{
					goto IL_00fb;
				}
				goto IL_00ff;
			}
			selectOperationWindow_0.Width = size.Value.Width;
			selectOperationWindow_0.SizeToContent = SizeToContent.Height;
		}
		else
		{
			selectOperationWindow_0.SizeToContent = SizeToContent.WidthAndHeight;
		}
		goto IL_033e;
		IL_02e5:
		selectOperationWindow_0.Width = size.Value.Width;
		goto IL_02fb;
		IL_033e:
		selectOperationWindow_0.MaxWindowSize = string_3;
		return;
		IL_01bb:
		if (array.Length == 4)
		{
			actionExecuteContext_0.RootContext.States["LAST_SELECT_WINDOW_POSITION"] = new Point(double.Parse(array[0]), double.Parse(array[1]));
			actionExecuteContext_0.RootContext.States["LAST_SELECT_WINDOW_SIZE_KEY"] = new Size(double.Parse(array[2]), double.Parse(array[3]));
		}
		goto IL_0280;
		IL_00ff:
		switch (num)
		{
		case 2:
			break;
		case 1:
			goto IL_019f;
		case 3:
			goto IL_01bb;
		default:
			goto IL_02a8;
		case 4:
			goto IL_02fb;
		}
		goto IL_011d;
		IL_0280:
		if (actionExecuteContext_0.RootContext.States.ContainsKey("LAST_SELECT_WINDOW_POSITION") && !string_2.IsEither("8", "7"))
		{
			point = (Point)actionExecuteContext_0.RootContext.States["LAST_SELECT_WINDOW_POSITION"];
			num = 1;
			if (XO2g2KQZe52YKPb9FQTR != null)
			{
				goto IL_00fb;
			}
			goto IL_00ff;
		}
		goto IL_019f;
		IL_02fb:
		selectOperationWindow_0.Height = size.Value.Height;
		selectOperationWindow_0.SizeToContent = SizeToContent.Manual;
		selectOperationWindow_0.HasPresetSize = true;
		goto IL_033e;
		IL_02a8:
		switch (string_2)
		{
		case "6":
		case "5":
		case "7":
		case "8":
			goto IL_02e5;
		}
		selectOperationWindow_0.SizeToContent = SizeToContent.WidthAndHeight;
		goto IL_033e;
		IL_00fb:
		int num2 = default(int);
		num = num2;
		goto IL_00ff;
	}

	public string GetSummary(ActionStep step)
	{
		return "选择的项 => " + XActionHelper.GetOutputParamDisplayString(WJ2tFQcPZEr, step) + XActionHelper.GetOutputParamDisplayString(OMKtF47mSEJ, step);
	}

	static SelectStep()
	{
		JgStFaqBiK3 = new StepInParamDef
		{
			Key = "type",
			Name = "类型",
			Description = "",
			DefaultValue = "single",
			Type = VarType.Enum,
			IsRequired = true,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("single", "单选"),
				new SelectionItem("multi", "多选")
			},
			VariableMode = ParamVariableMode.Input,
			IsControlField = true
		};
		W21tF7UDgsN = new StepInParamDef
		{
			Key = "prompt",
			Name = "窗口标题",
			Description = "",
			DefaultValue = "请选择",
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.Input
		};
		IBStFRDlAhg = new StepInParamDef
		{
			Key = "note",
			Name = "提示信息",
			Description = "",
			DefaultValue = "",
			Type = VarType.Text,
			IsRequired = false,
			VariableMode = ParamVariableMode.Input
		};
		qOhtFqoZfBT = new StepInParamDef
		{
			Key = "items",
			Name = "选项",
			Description = "每行一个选项，格式为 “文本” 或 “显示文本|值”。如需显示图标，格式请参考文档。",
			DefaultValue = "",
			Type = VarType.Text,
			IsRequired = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true
		};
		wO4tFcZWuYB = new StepInParamDef
		{
			Key = "defaultValue",
			Name = "默认值",
			Description = "预先选择的项",
			DefaultValue = "",
			Type = VarType.Text,
			IsRequired = false,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[1] { "single" }
		};
		OaCtFVw3DE7 = new StepInParamDef
		{
			Key = "defaultValueMulti",
			Name = "默认值",
			Description = "多选时默认选项，每行一个",
			DefaultValue = "",
			Type = VarType.Text,
			IsRequired = false,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[1] { "multi" }
		};
		z7KtFZwyVkJ = new StepInParamDef
		{
			Key = "winLocation",
			Name = "窗口位置",
			Description = "在哪里显示选择窗口",
			Type = VarType.Enum,
			DefaultValue = ShowWindowLocation.WithMouse1.ToString(),
			SelectionItems = new SelectionItem[12]
			{
				new SelectionItem(ShowWindowLocation.WithMouse1.ToString(), "跟随鼠标（指针周围）"),
				new SelectionItem(ShowWindowLocation.WithMouse2.ToString(), "跟随鼠标（指针右下）"),
				new SelectionItem(ShowWindowLocation.CenterScreen.ToString(), "屏幕中间"),
				new SelectionItem(ShowWindowLocation.TopLeft.ToString(), "屏幕左上"),
				new SelectionItem(ShowWindowLocation.TopCenter.ToString(), "屏幕中上"),
				new SelectionItem(ShowWindowLocation.TopRight.ToString(), "屏幕右上"),
				new SelectionItem(ShowWindowLocation.LeftCenter.ToString(), "屏幕左中"),
				new SelectionItem(ShowWindowLocation.RightCenter.ToString(), "屏幕右中"),
				new SelectionItem(ShowWindowLocation.BottomLeft.ToString(), "屏幕左下"),
				new SelectionItem(ShowWindowLocation.BottomCenter.ToString(), "屏幕中下"),
				new SelectionItem(ShowWindowLocation.BottomRight.ToString(), "屏幕右下"),
				new SelectionItem(ShowWindowLocation.Manual.ToString(), "自定义位置")
			},
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		YPptF9dRwjP = new StepInParamDef
		{
			Key = "maxWinSize",
			Name = "最大尺寸/位置坐标",
			Description = "可选。设置选择窗口的最大尺寸，格式为：宽度,高度。支持像素数值或屏幕宽高百分比，详情请参考模块文档。\n“窗口位置” 类型为 “自定义位置” 时用于指定显示位置，格式为：left,top,right,bottom",
			DefaultValue = "",
			Type = VarType.Text,
			IsRequired = false,
			VariableMode = ParamVariableMode.Input,
			TextTools = new List<TextToolType> { TextToolType.SelectLocationArea }
		};
		x21tFhY7AZQ = new StepInParamDef
		{
			Key = "keepLastPos",
			Name = "使用上次位置",
			Description = "重复显示选择窗口时，保持上次的显示位置。",
			DefaultValue = "1",
			IsRequired = false,
			Type = VarType.Enum,
			VariableMode = ParamVariableMode.UseVarOrInput,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("0", "不保持"),
				new SelectionItem("3", "保持本次运行的上次位置(左上角)"),
				new SelectionItem("1", "保持本次运行的上次位置+宽度"),
				new SelectionItem("5", "保持本次运行的上次位置+尺寸"),
				new SelectionItem("7", "保持本次运行的上次窗口尺寸"),
				new SelectionItem("4", "总是保持上次位置(左上角)"),
				new SelectionItem("2", "总是保持上次位置+宽度"),
				new SelectionItem("6", "总是保持上次位置+尺寸"),
				new SelectionItem("8", "总是保持上次窗口尺寸")
			}
		};
		OAGtFe6UO0q = new StepInParamDef
		{
			Key = "autoCloseSeconds",
			Name = "自动关闭",
			Description = "几秒后自动关闭选择窗口。0表示不自动关闭。",
			DefaultValue = 0,
			Type = VarType.Number,
			IsRequired = false,
			VariableMode = ParamVariableMode.Input,
			IsAdvanced = true
		};
		vGXtFYGpseR = new StepInParamDef
		{
			Key = "noKeyboard",
			Name = "不使用焦点",
			Description = "不抢占其他应用的焦点。此时无法使用键盘选择选项，只能用鼠标操作。",
			Type = VarType.Boolean,
			DefaultValue = false,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsAdvanced = true
		};
		CGttFI6WhaT = new StepInParamDef
		{
			Key = "closeOnDeactivated",
			Name = "失去焦点后关闭窗口（仅在使用焦点时有效）",
			Description = "",
			Type = VarType.Boolean,
			DefaultValue = false,
			VariableMode = ParamVariableMode.Input
		};
		eLKtFWr0WPB = new StepInParamDef
		{
			Key = "showFilter",
			Name = "启用筛选",
			Description = "是否显示筛选框。仅在且使用焦点时有效。",
			Type = VarType.Enum,
			DefaultValue = "auto",
			VariableMode = ParamVariableMode.UseVarOrInput,
			SelectionItems = new SelectionItem[3]
			{
				new SelectionItem("0", "不启用"),
				new SelectionItem("1", "启用"),
				new SelectionItem("auto", "自动(选项超过10个时启用)")
			}
		};
		KU3tFksEw3c = new StepInParamDef
		{
			Key = "filterContent",
			Name = "筛选内容",
			Description = "预先显示的筛选内容",
			Type = VarType.Text,
			DefaultValue = "",
			VariableMode = ParamVariableMode.UseVarOrInput
		};
		tpmtFGBJIFa = new StepInParamDef
		{
			Key = "imeState",
			Name = "输入法状态",
			DefaultValue = "NO_CONTROL",
			Description = "筛选框输入法状态",
			IsRequired = false,
			Type = VarType.Enum,
			VariableMode = ParamVariableMode.UseVarOrInput,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("NO_CONTROL", "不控制"),
				new SelectionItem("ON", "开启"),
				new SelectionItem("OFF", "关闭")
			},
			IsAdvanced = true
		};
		j6ctFshWylO = new StepInParamDef
		{
			Key = "restoreForeground",
			Name = "恢复活动窗口到弹出前",
			Description = "将前台窗口还原为弹窗前的活动窗口。否则将会还原到最后一个活动窗口上。",
			Type = VarType.Boolean,
			DefaultValue = true,
			VariableMode = ParamVariableMode.Input
		};
		CGYtFHVIgwh = new StepInParamDef
		{
			Key = "allowOkWhenEmpty",
			Name = "允许不选择任何选项时点击确定",
			Description = "",
			Type = VarType.Boolean,
			DefaultValue = false,
			VariableMode = ParamVariableMode.Input
		};
		w35tF10tQKY = new StepInParamDef
		{
			Key = "enableQuickConfirm",
			Name = "启用快速确认（点击选项后立即确认选择并关闭窗口）",
			Description = "",
			Type = VarType.Boolean,
			DefaultValue = true,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new string[1] { "single" }
		};
		SpMtFbGsfwS = new StepInParamDef
		{
			Key = "topMost",
			Name = "置顶显示",
			DefaultValue = true,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		DGftF6nax2t = new StepInParamDef
		{
			Key = "stopIfCancel",
			Name = "取消后停止",
			DefaultValue = true,
			Description = "取消选择后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		syLtFXoTdgS = new StepInParamDef
		{
			Key = "operations",
			Name = "右键/全局菜单",
			Description = "每行定义一个操作，具体格式请参考文档。",
			DefaultValue = "",
			Type = VarType.Text,
			IsRequired = false,
			VariableMode = ParamVariableMode.Input,
			IsMultiLine = true,
			IsAdvanced = true
		};
		kkGtFmrmSAa = new StepInParamDef
		{
			Key = "fontsize",
			Name = "字体大小",
			DefaultValue = 12,
			IsRequired = true,
			Type = VarType.Number,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsAdvanced = true
		};
		mcAtFKplHkV = new StepInParamDef
		{
			Key = "fontfamily",
			Name = "字体名称",
			DefaultValue = "",
			Description = "可选。设置字体名称。如有多个字体，使用逗号分隔。",
			IsRequired = false,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsAdvanced = true
		};
		RDMtFxYFeMq = new StepInParamDef
		{
			Key = "iconsize",
			Name = "图标大小",
			DefaultValue = 16,
			IsRequired = true,
			Type = VarType.Number,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsAdvanced = true
		};
		M5gtFrM2iZq = new StepInParamDef
		{
			Key = "windowKey",
			Name = "窗口标识",
			DefaultValue = "",
			Description = "再次运行动作时，可根据标识自动关闭前一个窗口并在该位置显示新窗口。",
			IsRequired = false,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsAdvanced = true
		};
		RfFtFpirf6H = new StepInParamDef
		{
			Key = "help",
			Name = "帮助按钮内容",
			Description = "点击弹出显示帮助内容，MarkDown格式",
			DefaultValue = "",
			Type = VarType.Text,
			IsRequired = false,
			IsMultiLine = true,
			IsAdvanced = true,
			VariableMode = ParamVariableMode.Input,
			DefaultHighlightType = "MarkDown"
		};
		WJ2tFQcPZEr = new StepOutParamDef
		{
			Key = "textValue",
			Name = "选择的项(值)",
			Description = "选中选项的值",
			Type = VarType.Text,
			ValidForList = new string[1] { "single" }
		};
		vATtFjeWiho = new StepOutParamDef
		{
			Key = "selectedIndex",
			Name = "索引号",
			Description = "选择的项在列表里的序号数字，从0开始。",
			Type = VarType.Integer,
			ValidForList = new string[1] { "single" }
		};
		eB5tFnh8T14 = new StepOutParamDef
		{
			Key = "selectedIndexList",
			Name = "索引号列表",
			Description = "所有选择的项的序号列表",
			Type = VarType.List,
			ValidForList = new string[1] { "multi" }
		};
		OMKtF47mSEJ = new StepOutParamDef
		{
			Key = "multiSelected",
			Name = "选择的项值列表",
			Description = "所有选择的项的值的列表",
			Type = VarType.List,
			ValidForList = new string[1] { "multi" }
		};
		MHLtF5mLeJb = new StepOutParamDef
		{
			Key = "extraOperation",
			Name = "选择的菜单",
			Description = "选择的右键菜单或全局菜单项的值",
			Type = VarType.Text
		};
		yRetFDjaPSV = new StepOutParamDef
		{
			Key = "selectedFullItems",
			Name = "选择的完整选项",
			Description = "选择选项的完整定义内容（不仅仅返回选项值）",
			Type = VarType.Any
		};
		DDatFdcO7oC = new StepOutParamDef
		{
			Key = "selectedItemTitle",
			Name = "选择的选项标题",
			Description = "所选中选项的标题",
			Type = VarType.Text,
			ValidForList = new string[1] { "single" }
		};
		IfNtFos0pJD = new StepOutParamDef
		{
			Key = "filterContent",
			Name = "筛选内容",
			Description = "最后使用的筛选词",
			Type = VarType.Text
		};
		lHjtFToitKn = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否确认",
			Description = "是否成功选择了选项/点击了保存按钮",
			Type = VarType.Boolean
		};
	}

	internal static bool Cy0yPdQZjQtwvNouPDhl()
	{
		return XO2g2KQZe52YKPb9FQTR == null;
	}
}
