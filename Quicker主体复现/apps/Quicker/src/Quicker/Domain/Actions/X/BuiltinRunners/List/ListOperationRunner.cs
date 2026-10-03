using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using FontAwesome5;
using IOn6RhAJdTUbfGy6gwn;
using PptRB0i5EX0bZPrKAwn;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Utilities;

namespace Quicker.Domain.Actions.X.BuiltinRunners.List;

public class ListOperationRunner : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec fAfSyhPxWoI;

		public static Func<string, string> jaSSyeYKvu5;

		public static Func<string, string> Tc2SyYn2pRc;

		private static _003C_003Ec WOtOf7WO3kIuyRq52JBX;

		static _003C_003Ec()
		{
			fAfSyhPxWoI = new _003C_003Ec();
		}

		internal string rteSyZu3DIy(string q)
		{
			return q;
		}

		internal string RHcSy9C7fZK(string q)
		{
			return q;
		}

		internal static bool YuZIVMWOENrAeLoOPVGD()
		{
			return WOtOf7WO3kIuyRq52JBX == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass56_0
	{
		public ActionStep QbuSyWo6IsT;

		public ActionExecuteContext mdPSykmoANi;

		public XAction vycSyGAcmQH;

		private static _003C_003Ec__DisplayClass56_0 LpEhw2WO0XSddPfZ5LFM;

		internal (bool isSuccess, string message, ActionStopFlag failReason) vuLSyIqR8FJ()
		{
			_003C_003Ec__DisplayClass56_1 _003C_003Ec__DisplayClass56_ = new _003C_003Ec__DisplayClass56_1
			{
				nLUSyXhus4e = (XActionHelper.GetListParamValue(zfGg0BfU3Th, QbuSyWo6IsT, mdPSykmoANi) as List<string>)
			};
			if (_003C_003Ec__DisplayClass56_.nLUSyXhus4e == null)
			{
				return (isSuccess: false, message: "输入的数据不是列表。", failReason: ActionStopFlag.OperationFailed);
			}
			string textParamValue = XActionHelper.GetTextParamValue(wgSg0QrT6tv, QbuSyWo6IsT, mdPSykmoANi);
			int num = Convert.ToInt32(XActionHelper.GetIntegerParamValue(XMxg0njf29V, QbuSyWo6IsT, mdPSykmoANi));
			int count = Convert.ToInt32(XActionHelper.GetIntegerParamValue(NBQg04smkdc, QbuSyWo6IsT, mdPSykmoANi));
			_003C_003Ec__DisplayClass56_.ALBSy68biGk = XActionHelper.GetTextParamValue(mv5g05WUg8g, QbuSyWo6IsT, mdPSykmoANi);
			if (num < 0)
			{
				num = _003C_003Ec__DisplayClass56_.nLUSyXhus4e.Count - -num;
			}
			switch (textParamValue)
			{
			case "sub":
			{
				List<string> list2 = _003C_003Ec__DisplayClass56_.nLUSyXhus4e.Skip(num).Take(count).ToList();
				XActionHelper.OutputResult(b9tg0Av2UST, QbuSyWo6IsT, mdPSykmoANi, list2, vycSyGAcmQH);
				XActionHelper.OutputResult(LKNg0TsADJ0, QbuSyWo6IsT, mdPSykmoANi, list2.Count == 0, vycSyGAcmQH);
				XActionHelper.OutputResult(lSKg0MvbomG, QbuSyWo6IsT, mdPSykmoANi, list2.Count, vycSyGAcmQH);
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
			case "setAt":
				_003C_003Ec__DisplayClass56_.nLUSyXhus4e[num] = _003C_003Ec__DisplayClass56_.ALBSy68biGk;
				break;
			case "getAt":
			{
				string text2 = "";
				text2 = _003C_003Ec__DisplayClass56_.nLUSyXhus4e[num];
				XActionHelper.OutputResult(b9tg0Av2UST, QbuSyWo6IsT, mdPSykmoANi, text2, vycSyGAcmQH);
				break;
			}
			case "clear":
				_003C_003Ec__DisplayClass56_.nLUSyXhus4e.Clear();
				break;
			case "remove":
				_003C_003Ec__DisplayClass56_.nLUSyXhus4e.Remove(_003C_003Ec__DisplayClass56_.ALBSy68biGk);
				break;
			case "concat":
			{
				IList<string> listParamValue = XActionHelper.GetListParamValue(obsg0jGd7uF, QbuSyWo6IsT, mdPSykmoANi);
				List<string> list3 = _003C_003Ec__DisplayClass56_.nLUSyXhus4e.Concat(listParamValue).ToList();
				XActionHelper.OutputResult(b9tg0Av2UST, QbuSyWo6IsT, mdPSykmoANi, list3, vycSyGAcmQH);
				XActionHelper.OutputResult(LKNg0TsADJ0, QbuSyWo6IsT, mdPSykmoANi, list3.Count == 0, vycSyGAcmQH);
				XActionHelper.OutputResult(lSKg0MvbomG, QbuSyWo6IsT, mdPSykmoANi, list3.Count, vycSyGAcmQH);
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
			case "append":
				_003C_003Ec__DisplayClass56_.nLUSyXhus4e.Add(_003C_003Ec__DisplayClass56_.ALBSy68biGk);
				break;
			case "sortAsc":
			{
				List<string> result2 = _003C_003Ec__DisplayClass56_.nLUSyXhus4e.OrderBy(_003C_003Ec.jaSSyeYKvu5 ?? (_003C_003Ec.jaSSyeYKvu5 = _003C_003Ec.fAfSyhPxWoI.rteSyZu3DIy)).ToList();
				XActionHelper.OutputResult(b9tg0Av2UST, QbuSyWo6IsT, mdPSykmoANi, result2, vycSyGAcmQH);
				break;
			}
			case "reverse":
				_003C_003Ec__DisplayClass56_.nLUSyXhus4e.Reverse();
				break;
			case "indexOf":
			{
				int num2 = _003C_003Ec__DisplayClass56_.nLUSyXhus4e.IndexOf(_003C_003Ec__DisplayClass56_.ALBSy68biGk);
				XActionHelper.OutputResult(OYmg0F116IH, QbuSyWo6IsT, mdPSykmoANi, num2, vycSyGAcmQH);
				break;
			}
			case "insertAt":
				_003C_003Ec__DisplayClass56_.nLUSyXhus4e.Insert(num, _003C_003Ec__DisplayClass56_.ALBSy68biGk);
				break;
			case "distinct":
			{
				List<string> list = _003C_003Ec__DisplayClass56_.nLUSyXhus4e.Distinct().ToList();
				XActionHelper.OutputResult(b9tg0Av2UST, QbuSyWo6IsT, mdPSykmoANi, list, vycSyGAcmQH);
				XActionHelper.OutputResult(LKNg0TsADJ0, QbuSyWo6IsT, mdPSykmoANi, list.Count == 0, vycSyGAcmQH);
				XActionHelper.OutputResult(lSKg0MvbomG, QbuSyWo6IsT, mdPSykmoANi, list.Count, vycSyGAcmQH);
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
			case "sortDesc":
			{
				List<string> result4 = _003C_003Ec__DisplayClass56_.nLUSyXhus4e.OrderByDescending(_003C_003Ec.Tc2SyYn2pRc ?? (_003C_003Ec.Tc2SyYn2pRc = _003C_003Ec.fAfSyhPxWoI.RHcSy9C7fZK)).ToList();
				XActionHelper.OutputResult(b9tg0Av2UST, QbuSyWo6IsT, mdPSykmoANi, result4, vycSyGAcmQH);
				break;
			}
			case "removeAt":
				if (num >= 0)
				{
					_003C_003Ec__DisplayClass56_.nLUSyXhus4e.RemoveAt(num);
				}
				else
				{
					_003C_003Ec__DisplayClass56_.nLUSyXhus4e.RemoveAt(_003C_003Ec__DisplayClass56_.nLUSyXhus4e.Count + num);
				}
				break;
			case "filterByEnds":
			{
				_003C_003Ec__DisplayClass56_7 _003C_003Ec__DisplayClass56_7 = new _003C_003Ec__DisplayClass56_7();
				_003C_003Ec__DisplayClass56_7.pMkSyUjERXr = _003C_003Ec__DisplayClass56_;
				_003C_003Ec__DisplayClass56_7.dsvSyFKXg2m = _003C_003Ec__DisplayClass56_7.pMkSyUjERXr.nLUSyXhus4e.Where(_003C_003Ec__DisplayClass56_7.pMkSyUjERXr.fyKSybhU5aQ).ToList();
				XActionHelper.OutputResult(b9tg0Av2UST, QbuSyWo6IsT, mdPSykmoANi, _003C_003Ec__DisplayClass56_7.dsvSyFKXg2m, vycSyGAcmQH);
				XActionHelper.OutputResult(LKNg0TsADJ0, QbuSyWo6IsT, mdPSykmoANi, _003C_003Ec__DisplayClass56_7.dsvSyFKXg2m.Count == 0, vycSyGAcmQH);
				XActionHelper.OutputResult(lSKg0MvbomG, QbuSyWo6IsT, mdPSykmoANi, _003C_003Ec__DisplayClass56_7.dsvSyFKXg2m.Count, vycSyGAcmQH);
				XActionHelper.OutputResultIfNeeded(cLCg0O2RKBr, _003C_003Ec__DisplayClass56_7.TLqSyOoMu8r, QbuSyWo6IsT, mdPSykmoANi, vycSyGAcmQH);
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
			case "sortAscNature":
			{
				List<string> result3 = _003C_003Ec__DisplayClass56_.nLUSyXhus4e.OrderByLogical();
				XActionHelper.OutputResult(b9tg0Av2UST, QbuSyWo6IsT, mdPSykmoANi, result3, vycSyGAcmQH);
				break;
			}
			case "filterByRegex":
			{
				_003C_003Ec__DisplayClass56_3 _003C_003Ec__DisplayClass56_6 = new _003C_003Ec__DisplayClass56_3
				{
					yOwSyjAF2ZR = _003C_003Ec__DisplayClass56_
				};
				string textParamValue3 = XActionHelper.GetTextParamValue(BiKg0dPygh6, QbuSyWo6IsT, mdPSykmoANi);
				if (string.IsNullOrEmpty(textParamValue3))
				{
					return (isSuccess: false, message: "正则表达式为空！", failReason: ActionStopFlag.OperationFailed);
				}
				_003C_003Ec__DisplayClass56_6.obFSyBU8d1u = new Regex(textParamValue3);
				_003C_003Ec__DisplayClass56_6.XOcSyQqVZ1F = _003C_003Ec__DisplayClass56_6.yOwSyjAF2ZR.nLUSyXhus4e.Where(_003C_003Ec__DisplayClass56_6.vkxSyrwk3UC).ToList();
				XActionHelper.OutputResult(b9tg0Av2UST, QbuSyWo6IsT, mdPSykmoANi, _003C_003Ec__DisplayClass56_6.XOcSyQqVZ1F, vycSyGAcmQH);
				XActionHelper.OutputResult(LKNg0TsADJ0, QbuSyWo6IsT, mdPSykmoANi, _003C_003Ec__DisplayClass56_6.XOcSyQqVZ1F.Count == 0, vycSyGAcmQH);
				XActionHelper.OutputResult(lSKg0MvbomG, QbuSyWo6IsT, mdPSykmoANi, _003C_003Ec__DisplayClass56_6.XOcSyQqVZ1F.Count, vycSyGAcmQH);
				XActionHelper.OutputResultIfNeeded(cLCg0O2RKBr, _003C_003Ec__DisplayClass56_6.aBISypKT9F3, QbuSyWo6IsT, mdPSykmoANi, vycSyGAcmQH);
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
			case "filterByStarts":
			{
				_003C_003Ec__DisplayClass56_6 _003C_003Ec__DisplayClass56_5 = new _003C_003Ec__DisplayClass56_6();
				_003C_003Ec__DisplayClass56_5.C2hSyAksrBG = _003C_003Ec__DisplayClass56_;
				_003C_003Ec__DisplayClass56_5.FeQSyMkk23I = _003C_003Ec__DisplayClass56_5.C2hSyAksrBG.nLUSyXhus4e.Where(_003C_003Ec__DisplayClass56_5.C2hSyAksrBG.MH8Sy1v86g0).ToList();
				XActionHelper.OutputResult(b9tg0Av2UST, QbuSyWo6IsT, mdPSykmoANi, _003C_003Ec__DisplayClass56_5.FeQSyMkk23I, vycSyGAcmQH);
				XActionHelper.OutputResult(LKNg0TsADJ0, QbuSyWo6IsT, mdPSykmoANi, _003C_003Ec__DisplayClass56_5.FeQSyMkk23I.Count == 0, vycSyGAcmQH);
				XActionHelper.OutputResult(lSKg0MvbomG, QbuSyWo6IsT, mdPSykmoANi, _003C_003Ec__DisplayClass56_5.FeQSyMkk23I.Count, vycSyGAcmQH);
				XActionHelper.OutputResultIfNeeded(cLCg0O2RKBr, _003C_003Ec__DisplayClass56_5.evsSyT8e59S, QbuSyWo6IsT, mdPSykmoANi, vycSyGAcmQH);
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
			case "filterByDefault":
			{
				_003C_003Ec__DisplayClass56_4 _003C_003Ec__DisplayClass56_4 = new _003C_003Ec__DisplayClass56_4
				{
					PPZSy5L8g9X = _003C_003Ec__DisplayClass56_
				};
				string text = _003C_003Ec__DisplayClass56_4.PPZSy5L8g9X.ALBSy68biGk;
				bool booleanParamValue = XActionHelper.GetBooleanParamValue(SjSg0D2SaXt, QbuSyWo6IsT, mdPSykmoANi);
				if (string.IsNullOrEmpty(text))
				{
					_003C_003Ec__DisplayClass56_4.TRiSy4Ob1xI = _003C_003Ec__DisplayClass56_4.PPZSy5L8g9X.nLUSyXhus4e;
				}
				else
				{
					_003C_003Ec__DisplayClass56_4.TRiSy4Ob1xI = tkxn6HAKAgMT8gvXbyh.tRUijipiSD(_003C_003Ec__DisplayClass56_4.PPZSy5L8g9X.nLUSyXhus4e, text, booleanParamValue);
				}
				XActionHelper.OutputResult(b9tg0Av2UST, QbuSyWo6IsT, mdPSykmoANi, _003C_003Ec__DisplayClass56_4.TRiSy4Ob1xI, vycSyGAcmQH);
				XActionHelper.OutputResult(LKNg0TsADJ0, QbuSyWo6IsT, mdPSykmoANi, _003C_003Ec__DisplayClass56_4.TRiSy4Ob1xI.Count == 0, vycSyGAcmQH);
				XActionHelper.OutputResult(lSKg0MvbomG, QbuSyWo6IsT, mdPSykmoANi, _003C_003Ec__DisplayClass56_4.TRiSy4Ob1xI.Count, vycSyGAcmQH);
				XActionHelper.OutputResultIfNeeded(cLCg0O2RKBr, _003C_003Ec__DisplayClass56_4.mRhSyndqhvb, QbuSyWo6IsT, mdPSykmoANi, vycSyGAcmQH);
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
			case "removeByMatch":
			case "removeByNotMatch":
			{
				string textParamValue2 = XActionHelper.GetTextParamValue(BiKg0dPygh6, QbuSyWo6IsT, mdPSykmoANi);
				if (string.IsNullOrEmpty(textParamValue2))
				{
					return (isSuccess: false, message: "移除列表元素：正则表达式为空！", failReason: ActionStopFlag.OperationFailed);
				}
				_003C_003Ec__DisplayClass56_2 _003C_003Ec__DisplayClass56_3 = new _003C_003Ec__DisplayClass56_2
				{
					sUPSyxgt9jo = new Regex(textParamValue2)
				};
				if (textParamValue == "removeByMatch")
				{
					_003C_003Ec__DisplayClass56_.nLUSyXhus4e.RemoveAll(_003C_003Ec__DisplayClass56_3.DqTSymFm5Y3);
				}
				else
				{
					_003C_003Ec__DisplayClass56_.nLUSyXhus4e.RemoveAll(_003C_003Ec__DisplayClass56_3.v7eSyKSW2uG);
				}
				break;
			}
			case "filterByContains":
			{
				_003C_003Ec__DisplayClass56_5 _003C_003Ec__DisplayClass56_2 = new _003C_003Ec__DisplayClass56_5();
				_003C_003Ec__DisplayClass56_2.j5JSyo9iGDe = _003C_003Ec__DisplayClass56_;
				_003C_003Ec__DisplayClass56_2.WlHSydlrp96 = _003C_003Ec__DisplayClass56_2.j5JSyo9iGDe.nLUSyXhus4e.Where(_003C_003Ec__DisplayClass56_2.j5JSyo9iGDe.EdPSyH4wiup).ToList();
				XActionHelper.OutputResult(b9tg0Av2UST, QbuSyWo6IsT, mdPSykmoANi, _003C_003Ec__DisplayClass56_2.WlHSydlrp96, vycSyGAcmQH);
				XActionHelper.OutputResult(LKNg0TsADJ0, QbuSyWo6IsT, mdPSykmoANi, _003C_003Ec__DisplayClass56_2.WlHSydlrp96.Count == 0, vycSyGAcmQH);
				XActionHelper.OutputResult(lSKg0MvbomG, QbuSyWo6IsT, mdPSykmoANi, _003C_003Ec__DisplayClass56_2.WlHSydlrp96.Count, vycSyGAcmQH);
				XActionHelper.OutputResultIfNeeded(cLCg0O2RKBr, _003C_003Ec__DisplayClass56_2.heCSyDEqfFv, QbuSyWo6IsT, mdPSykmoANi, vycSyGAcmQH);
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
			case "removeAllByValue":
				_003C_003Ec__DisplayClass56_.nLUSyXhus4e.RemoveAll(_003C_003Ec__DisplayClass56_.zk5SysOqmIq);
				break;
			case "FileSizeAsc":
			case "FileSizeDesc":
			case "CreationTimeAsc":
			case "CreationTimeDesc":
			case "LastWriteTimeAsc":
			case "LastAccessTimeAsc":
			case "LastWriteTimeDesc":
			case "LastAccessTimeDesc":
			{
				List<string> result = xjkIv1iq3Kqe7V2pm2d.t80vwkbu1qR(_003C_003Ec__DisplayClass56_.nLUSyXhus4e, textParamValue);
				XActionHelper.OutputResult(b9tg0Av2UST, QbuSyWo6IsT, mdPSykmoANi, result, vycSyGAcmQH);
				break;
			}
			default:
				AppHelper.ShowWarning("不支持的列表操作类型：" + textParamValue);
				break;
			case "none":
				break;
			}
			XActionHelper.OutputResult(LKNg0TsADJ0, QbuSyWo6IsT, mdPSykmoANi, _003C_003Ec__DisplayClass56_.nLUSyXhus4e.Count == 0, vycSyGAcmQH);
			XActionHelper.OutputResult(lSKg0MvbomG, QbuSyWo6IsT, mdPSykmoANi, _003C_003Ec__DisplayClass56_.nLUSyXhus4e.Count, vycSyGAcmQH);
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool ejjQjsWO1e837JNRUNLQ()
		{
			return LpEhw2WO0XSddPfZ5LFM == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass56_1
	{
		public string ALBSy68biGk;

		public List<string> nLUSyXhus4e;

		internal static _003C_003Ec__DisplayClass56_1 aAoShoWOBHxuIu0quCex;

		internal bool zk5SysOqmIq(string x)
		{
			return string.Equals(x, ALBSy68biGk);
		}

		internal bool EdPSyH4wiup(string x)
		{
			return x.IndexOf(ALBSy68biGk, StringComparison.OrdinalIgnoreCase) >= 0;
		}

		internal bool MH8Sy1v86g0(string x)
		{
			return x.StartsWith(ALBSy68biGk, StringComparison.OrdinalIgnoreCase);
		}

		internal bool fyKSybhU5aQ(string x)
		{
			return x.EndsWith(ALBSy68biGk, StringComparison.OrdinalIgnoreCase);
		}

		internal static bool dDX8dlWOvBMDYiL0UHtW()
		{
			return aAoShoWOBHxuIu0quCex == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass56_2
	{
		public Regex sUPSyxgt9jo;

		internal static _003C_003Ec__DisplayClass56_2 p4TgXcWOJjct5ODWa2wr;

		internal bool DqTSymFm5Y3(string x)
		{
			return sUPSyxgt9jo.IsMatch(x);
		}

		internal bool v7eSyKSW2uG(string x)
		{
			return !sUPSyxgt9jo.IsMatch(x);
		}

		internal static bool PnroOxWOk2OJfl9YZiPG()
		{
			return p4TgXcWOJjct5ODWa2wr == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass56_3
	{
		public Regex obFSyBU8d1u;

		public List<string> XOcSyQqVZ1F;

		public _003C_003Ec__DisplayClass56_1 yOwSyjAF2ZR;

		private static _003C_003Ec__DisplayClass56_3 MgoEw8WOrv5Pr9mSbIID;

		internal bool vkxSyrwk3UC(string x)
		{
			return obFSyBU8d1u.IsMatch(x);
		}

		internal object aBISypKT9F3()
		{
			return yOwSyjAF2ZR.nLUSyXhus4e.Except(XOcSyQqVZ1F).ToList();
		}

		internal static bool QqYdKiWON8ILTl0RvbyP()
		{
			return MgoEw8WOrv5Pr9mSbIID == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass56_4
	{
		public IList<string> TRiSy4Ob1xI;

		public _003C_003Ec__DisplayClass56_1 PPZSy5L8g9X;

		internal static _003C_003Ec__DisplayClass56_4 PAhOSYWOLEGwGvvJGMHs;

		internal object mRhSyndqhvb()
		{
			return PPZSy5L8g9X.nLUSyXhus4e.Except(TRiSy4Ob1xI).ToList();
		}

		internal static bool JyRlBxWOuX48cSh9U4yg()
		{
			return PAhOSYWOLEGwGvvJGMHs == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass56_5
	{
		public List<string> WlHSydlrp96;

		public _003C_003Ec__DisplayClass56_1 j5JSyo9iGDe;

		internal static _003C_003Ec__DisplayClass56_5 jYAfIGWOfKRl64kFWo9x;

		internal object heCSyDEqfFv()
		{
			return j5JSyo9iGDe.nLUSyXhus4e.Except(WlHSydlrp96).ToList();
		}

		internal static bool cqTavOWObKmFsgpWH1am()
		{
			return jYAfIGWOfKRl64kFWo9x == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass56_6
	{
		public List<string> FeQSyMkk23I;

		public _003C_003Ec__DisplayClass56_1 C2hSyAksrBG;

		private static _003C_003Ec__DisplayClass56_6 rktglSWOi4rAKUOAgE3N;

		internal object evsSyT8e59S()
		{
			return C2hSyAksrBG.nLUSyXhus4e.Except(FeQSyMkk23I).ToList();
		}

		static _003C_003Ec__DisplayClass56_6()
		{
		}

		internal static bool uSB0ybWOl94gwrgdRCrx()
		{
			return rktglSWOi4rAKUOAgE3N == null;
		}

		internal static void ndgHJAWO51piodJujnBx()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass56_7
	{
		public List<string> dsvSyFKXg2m;

		public _003C_003Ec__DisplayClass56_1 pMkSyUjERXr;

		internal static _003C_003Ec__DisplayClass56_7 WT39S8WOYnljfZMoHyy4;

		internal object TLqSyOoMu8r()
		{
			return pMkSyUjERXr.nLUSyXhus4e.Except(dsvSyFKXg2m).ToList();
		}

		internal static bool AQGLvQWO827xrTHMpyLk()
		{
			return WT39S8WOYnljfZMoHyy4 == null;
		}
	}

	private static List<string> nC6g0mdTc8t;

	[CompilerGenerated]
	private readonly string nIOg0KVCJLC = $"fa:{EFontAwesomeIcon.Light_ListOl}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> joyg0x6SQVT;

	[CompilerGenerated]
	private readonly string N16g0rYngu4 = "https://getquicker.net/KC/Help/Doc/listoperations";

	[CompilerGenerated]
	private readonly bool eGwg0pIEgDf;

	private static readonly StepInParamDef zfGg0BfU3Th;

	private static readonly StepInParamDef wgSg0QrT6tv;

	private static readonly StepInParamDef obsg0jGd7uF;

	private static readonly StepInParamDef XMxg0njf29V;

	private static readonly StepInParamDef NBQg04smkdc;

	private static readonly StepInParamDef mv5g05WUg8g;

	private static readonly StepInParamDef SjSg0D2SaXt;

	private static readonly StepInParamDef BiKg0dPygh6;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> kSBg0omdOhv = new StepInParamDef[8] { zfGg0BfU3Th, wgSg0QrT6tv, obsg0jGd7uF, XMxg0njf29V, NBQg04smkdc, mv5g05WUg8g, SjSg0D2SaXt, BiKg0dPygh6 };

	private static readonly StepOutParamDef LKNg0TsADJ0;

	private static readonly StepOutParamDef lSKg0MvbomG;

	private static readonly StepOutParamDef b9tg0Av2UST;

	private static readonly StepOutParamDef cLCg0O2RKBr;

	private static readonly StepOutParamDef OYmg0F116IH;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> I8Fg0UnvHJf = new StepOutParamDef[5] { b9tg0Av2UST, LKNg0TsADJ0, lSKg0MvbomG, OYmg0F116IH, cLCg0O2RKBr };

	internal static ListOperationRunner GfL4gUQUjtFirffONISa;

	public string Key => "sys:listOperations";

	public string Name => "列表操作";

	public IEnumerable<string> KeyWords => nC6g0mdTc8t;

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return nIOg0KVCJLC;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Compute;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return joyg0x6SQVT;
		}
	}

	public string Description => "对列表变量进行添加、删除等操作";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return N16g0rYngu4;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return eGwg0pIEgDf;
		}
	}

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return kSBg0omdOhv;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return I8Fg0UnvHJf;
		}
	}

	static ListOperationRunner()
	{
		nC6g0mdTc8t = new List<string>();
		zfGg0BfU3Th = new StepInParamDef
		{
			Key = "list",
			Name = "列表",
			Description = "要操作的列表变量",
			DefaultValue = null,
			Type = VarType.List,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true
		};
		wgSg0QrT6tv = new StepInParamDef
		{
			Key = "type",
			Name = "操作类型",
			Description = "",
			VariableMode = ParamVariableMode.Input,
			DefaultValue = "none",
			Type = VarType.Enum,
			IsControlField = true,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("none", "无操作（仅用于获取列表信息）"),
				new SelectionItem("getAt", "读取某位置元素"),
				new SelectionItem("append", "添加元素到末尾"),
				new SelectionItem("insertAt", "插入元素"),
				new SelectionItem("setAt", "设置/更新某序号元素"),
				new SelectionItem("remove", "去除元素(指定值，有多个时去除第一个)"),
				new SelectionItem("removeAllByValue", "去除元素(指定值，有多个时去除全部)"),
				new SelectionItem("removeAt", "去除元素(指定位置)"),
				new SelectionItem("removeByMatch", "去除元素(匹配正则表达式的项)"),
				new SelectionItem("removeByNotMatch", "去除元素(不匹配正则表达式的项)"),
				new SelectionItem("clear", "清空列表"),
				new SelectionItem("sortAsc", "排序A-Z（输出到结果）"),
				new SelectionItem("sortDesc", "排序Z-A（输出到结果）"),
				new SelectionItem("sortAscNature", "自然排序A-Z（输出到结果）"),
				new SelectionItem("FileSizeAsc", "排序文件列表：文件大小（从小到大）"),
				new SelectionItem("FileSizeDesc", "排序文件列表：文件大小（从大到小）"),
				new SelectionItem("CreationTimeDesc", "排序文件列表：创建时间（从新到旧）"),
				new SelectionItem("CreationTimeAsc", "排序文件列表：创建时间（从旧到新）"),
				new SelectionItem("LastAccessTimeDesc", "排序文件列表：最后访问时间（从晚到早）"),
				new SelectionItem("LastAccessTimeAsc", "排序文件列表：最后访问时间（从早到晚）"),
				new SelectionItem("LastWriteTimeDesc", "排序文件列表：最后写入时间（从晚到早）"),
				new SelectionItem("LastWriteTimeAsc", "排序文件列表：最后写入时间（从早到晚）"),
				new SelectionItem("reverse", "倒置"),
				new SelectionItem("sub", "截取（输出到结果）"),
				new SelectionItem("concat", "拼接（输出到结果）"),
				new SelectionItem("distinct", "去除重复（输出到结果）"),
				new SelectionItem("indexOf", "获取值的序号"),
				new SelectionItem("filterByRegex", "筛选（正则,输出到结果）"),
				new SelectionItem("filterByDefault", "筛选（模糊匹配,输出到结果）"),
				new SelectionItem("filterByContains", "筛选（包含）"),
				new SelectionItem("filterByStarts", "筛选（开始）"),
				new SelectionItem("filterByEnds", "筛选（结束）")
			}
		};
		obsg0jGd7uF = new StepInParamDef
		{
			Key = "list2",
			Name = "列表2",
			Description = "要拼接的列表",
			DefaultValue = null,
			Type = VarType.List,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true,
			ValidForList = new string[1] { "concat" }
		};
		XMxg0njf29V = new StepInParamDef
		{
			Key = "pos",
			Name = "序号",
			Description = "目标元素的序号，从0开始。负值表示从后向前的第几个。",
			DefaultValue = 0,
			Type = VarType.Integer,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[5] { "getAt", "insertAt", "setAt", "removeAt", "sub" }
		};
		NBQg04smkdc = new StepInParamDef
		{
			Key = "length",
			Name = "长度",
			Description = "操作元素的数量",
			DefaultValue = 1,
			Type = VarType.Integer,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[1] { "sub" }
		};
		mv5g05WUg8g = new StepInParamDef
		{
			Key = "item",
			Name = "值",
			Description = "要插入或更新的值，或筛选关键词",
			DefaultValue = "",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[10] { "append", "insertAt", "setAt", "remove", "removeAllByValue", "indexOf", "filterByDefault", "filterByContains", "filterByStarts", "filterByEnds" }
		};
		SjSg0D2SaXt = new StepInParamDef
		{
			Key = "orderByScore",
			Name = "按匹配程度排序",
			Description = "筛选结果按匹配程度倒序排列",
			DefaultValue = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[1] { "filterByDefault" }
		};
		BiKg0dPygh6 = new StepInParamDef
		{
			Key = "pattern",
			Name = "正则表达式",
			Description = "要匹配的正则表达式。",
			DefaultValue = "",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			ValidForList = new string[3] { "removeByMatch", "removeByNotMatch", "filterByRegex" }
		};
		LKNg0TsADJ0 = new StepOutParamDef
		{
			Key = "isEmpty",
			Name = "是否为空",
			Description = "空返回true，非空返回false",
			Type = VarType.Boolean
		};
		lSKg0MvbomG = new StepOutParamDef
		{
			Key = "length",
			Name = "列表长度",
			Description = "列表包含的元素数量，截断或拼接后输出结果列表的长度",
			Type = VarType.Integer
		};
		b9tg0Av2UST = new StepOutParamDef
		{
			Key = "value",
			Name = "结果",
			Description = "操作后的输出（取的元素值、排序、切片或拼接后的列表等）",
			Type = VarType.Any,
			ValidForList = new string[20]
			{
				"getAt", "sortAsc", "sortAscNature", "sortDesc", "sub", "concat", "distinct", "filterByRegex", "filterByDefault", "filterByContains",
				"filterByStarts", "filterByEnds", "FileSizeAsc", "FileSizeDesc", "CreationTimeDesc", "CreationTimeAsc", "LastAccessTimeDesc", "LastAccessTimeAsc", "LastWriteTimeDesc", "LastWriteTimeAsc"
			}
		};
		cLCg0O2RKBr = new StepOutParamDef
		{
			Key = "filterOutItems",
			Name = "剩余项列表",
			Description = "不符合筛选条件的项的列表",
			Type = VarType.Any,
			ValidForList = new string[5] { "filterByRegex", "filterByDefault", "filterByContains", "filterByStarts", "filterByEnds" }
		};
		OYmg0F116IH = new StepOutParamDef
		{
			Key = "index",
			Name = "序号",
			Description = "值在列表里的序号，-1表示不存在",
			Type = VarType.Integer,
			ValidForList = new List<string> { "indexOf" }
		};
		foreach (SelectionItem selectionItem in wgSg0QrT6tv.SelectionItems)
		{
			nC6g0mdTc8t.Add(selectionItem.Name);
			nC6g0mdTc8t.Add(selectionItem.Value);
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass56_0 _003C_003Ec__DisplayClass56_ = new _003C_003Ec__DisplayClass56_0();
		_003C_003Ec__DisplayClass56_.QbuSyWo6IsT = step;
		_003C_003Ec__DisplayClass56_.mdPSykmoANi = context;
		_003C_003Ec__DisplayClass56_.vycSyGAcmQH = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass56_.mdPSykmoANi, _003C_003Ec__DisplayClass56_.QbuSyWo6IsT, _003C_003Ec__DisplayClass56_.vycSyGAcmQH, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass56_.vuLSyIqR8FJ, (Action)null, (Action)null, (StepInParamDef)null, (StepOutParamDef)null);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDirectValue(wgSg0QrT6tv, step) + " " + XActionHelper.GetParamDisplayString(zfGg0BfU3Th, step);
	}

	internal static bool IVe9trQUDixXJZlcOpiO()
	{
		return GfL4gUQUjtFirffONISa == null;
	}
}
