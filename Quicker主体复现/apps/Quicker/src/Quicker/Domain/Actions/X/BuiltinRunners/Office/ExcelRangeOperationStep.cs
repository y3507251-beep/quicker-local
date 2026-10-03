using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using FontAwesome5;
using Microsoft.CSharp.RuntimeBinder;
using Microsoft.Office.Interop.Excel;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Actions.X.Variables;
using Quicker.Public.Actions;
using Quicker.Utilities;
using Quicker.Utilities.Ext;
using t8SGKhhgLWTgeqjGcrq;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Office;

public class ExcelRangeOperationStep : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec GTrSJlh8OuV;

		public static Func<string, string> yxXSJiCoiij;

		public static Func<string, string> L3wSJ3OffFr;

		public static Func<string, string> WssSJfsT3yL;

		public static Func<string, string> zb7SJzgrXPg;

		public static Func<string, string> DUbS0wZXJku;

		public static Func<string, string> ddfS0tNGxkM;

		public static Func<string, object> pCNS0g6E88m;

		public static Func<string, object> dxXS0LQKU8I;

		public static Func<string, string> BEsS0voVbpF;

		public static Func<string, string> tkeS0SHInZW;

		public static Func<string, string> OfmS02wt2wj;

		internal static _003C_003Ec hfMg8IWv51e8PsWIVxfi;

		static _003C_003Ec()
		{
			GTrSJlh8OuV = new _003C_003Ec();
		}

		internal string FeQSJ44oyx4(string x)
		{
			return x.Trim();
		}

		internal string fPKSJ5oP3nU(string x)
		{
			return x.Trim();
		}

		internal string KoBSJDfUdwY(string x)
		{
			return x.Trim();
		}

		internal string d3dSJdJGxMM(string x)
		{
			return x.Trim();
		}

		internal string hcISJo50N4s(string x)
		{
			return x.Trim();
		}

		internal string bUTSJTvfy5I(string x)
		{
			return x.Trim();
		}

		internal object vhCSJMYDcpO(string x)
		{
			return Convert.ToInt32(x.Trim());
		}

		internal object ssWSJAAdOQZ(string x)
		{
			return Convert.ToInt32(x.Trim());
		}

		internal string PVpSJOf2G5M(string x)
		{
			return x.Trim();
		}

		internal string ob9SJFN9wck(string x)
		{
			return x.Trim();
		}

		internal string gr8SJUCf0FI(string x)
		{
			return x.Trim();
		}

		internal static bool o1t3qQWvYxZF9w3ulxvp()
		{
			return hfMg8IWv51e8PsWIVxfi == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass103_0
	{
		public string NqZS006fUDl;

		public Range gITS0ChjZtK;

		public Range qINS0PBU0Di;

		internal static _003C_003Ec__DisplayClass103_0 Ugu3syWvRmekiTFSnalu;

		internal void q0OS0uxq0c6(string s)
		{
			IList<int> list = s.StringToIntList(',');
			if (list.Count != 2)
			{
				throw new InvalidDataException("不支持的子范围：" + NqZS006fUDl);
			}
			qINS0PBU0Di = (dynamic)((dynamic)gITS0ChjZtK).Item[(object)list[0], (object)list[1]];
		}

		internal void cQPS0NVs2Yt(string s)
		{
			int num = Convert.ToInt32(s);
			qINS0PBU0Di = (dynamic)gITS0ChjZtK.Columns[num, Type.Missing];
		}

		internal void wJtS0JyFnJp(string s)
		{
			int num = Convert.ToInt32(s);
			qINS0PBU0Di = (dynamic)gITS0ChjZtK.Rows[num, Type.Missing];
		}

		internal static bool VNRIDCWvg0yHU3bbcZf0()
		{
			return Ugu3syWvRmekiTFSnalu == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass79_0
	{
		public ExcelRangeOperationStep TlfS0y2QoKS;

		public ActionStep JFKS08MQvy6;

		public ActionExecuteContext VFmS0aTG1mm;

		public XAction BAMS075YgSV;

		private static _003C_003Ec__DisplayClass79_0 HHL2ZFWvxBav3tga8TXK;

		internal (bool isSuccess, string message, ActionStopFlag failReason) QFSS0Er8tnI()
		{
			Range range_ = TlfS0y2QoKS.JN0gJvVh0uq(JFKS08MQvy6, VFmS0aTG1mm);
			string textParamValue = XActionHelper.GetTextParamValue(_operationParam, JFKS08MQvy6, VFmS0aTG1mm);
			switch (textParamValue)
			{
			case "Replace":
				TlfS0y2QoKS.AaagNDtNJSY(range_, JFKS08MQvy6, VFmS0aTG1mm);
				goto IL_01f2;
			case "SetValue":
				TlfS0y2QoKS.fU5gJLOVgbE(range_, JFKS08MQvy6, VFmS0aTG1mm);
				goto IL_01f2;
			case "SetStyle":
				TlfS0y2QoKS.Ec5gNUmMNSH(range_, JFKS08MQvy6, VFmS0aTG1mm);
				goto IL_01f2;
			case "SetFormula":
				TlfS0y2QoKS.rWZgJgcECye(range_, JFKS08MQvy6, VFmS0aTG1mm);
				goto IL_01f2;
			case "CallMethod":
				TlfS0y2QoKS.t6CgNdtcIjX(range_, JFKS08MQvy6, VFmS0aTG1mm);
				goto IL_01f2;
			case "SetCellSize":
				TlfS0y2QoKS.qsogN38jWHe(range_, JFKS08MQvy6, VFmS0aTG1mm);
				goto IL_01f2;
			case "GetRangeInfo":
				TlfS0y2QoKS.I4lgJwTihx4(range_, JFKS08MQvy6, VFmS0aTG1mm, BAMS075YgSV);
				goto IL_01f2;
			case "SetNumberFormat":
				TlfS0y2QoKS.iDTgJtBWTV6(range_, JFKS08MQvy6, VFmS0aTG1mm);
				goto IL_01f2;
			default:
				{
					return (isSuccess: false, message: "不支持的操作，可能Quicker版本太老了：" + textParamValue, failReason: ActionStopFlag.OperationFailed);
				}
				IL_01f2:
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
		}

		internal static bool G0wq9qWvIQ8SiaIU3tZa()
		{
			return HHL2ZFWvxBav3tga8TXK == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass81_0
	{
		public Range TDaSCSek7dd;

		public ExcelRangeOperationStep FbmSC2K2Wg3;

		public Action<string> XM8SCuhh3qN;

		public Action<string> ILySCNDkHIj;

		public Action<string> jJDSCJNhS9i;

		public Action<string> iveSC0o3QaE;

		public Action<string> u9lSCC2i4j6;

		public Action<string> zTnSCPcG3AY;

		public Action<string> FFNSCEL1Ahu;

		public Action<string> tlcSCyUsEAr;

		public Action<string> FAvSC8hMkYx;

		public Action<string> fkjSCavl6bd;

		public Action<string> UCcSC7SULG3;

		public Action<string> MyXSCRYDBNK;

		public Action<string> kYpSCqRb4ZQ;

		public Action<string> TLZSCcVTejs;

		public Action<string> csWSCVLFlOH;

		public Action<string> LsXSCZtloQG;

		public Action<string> Ll7SC9bEDGl;

		public Action<string> NdsSChg8mAA;

		public Action<string> m4eSCeCxAhd;

		public Action<string> AFPSCYfIaKf;

		public Action<string> f1fSCItClWC;

		public Action<string> qTYSCW35vsy;

		public Action<string> KyuSCkPZ4HO;

		public Action<string> sGVSCG3OscD;

		public Action<string> y8wSCssT9uZ;

		public Action<string> mdqSCHRMNNm;

		public Action<string> DK1SC1oDsPY;

		public Action<string> XklSCbBa4qR;

		public Action<string> GOBSC6mmRF8;

		public Action<string> A0rSCXUqyYc;

		public Action<string> aykSCmDyk5V;

		public Action<string> t54SCKyIIfW;

		public Action<string> PBnSCxHLBLv;

		public Action<string> JvnSCrTKspM;

		public Action<string> idcSCpaIWhW;

		public Action<string> B8LSCBQ2Iaq;

		public Action<string> DAHSCQ8Areg;

		public Action<string> oTFSCjWOSgB;

		public Action<string> M3qSCn4VrTA;

		public Action<string> mfoSC4uS0Q9;

		public Action<string> tr3SC5ty6fP;

		public Action<string> rb9SCDJQAQW;

		public Action<string> DGBSCd7mEfD;

		public Action<string> WsMSCo8Rgch;

		public Action<string> pE9SCTwK2Bu;

		public Action<string> CQ9SCMPtJPL;

		public Action<string> tHESCAtAkHA;

		public Action<string> SevSCOcnGvp;

		public Action<string> sArSCFbn7ch;

		private static _003C_003Ec__DisplayClass81_0 GnO965Wvtrx5HcfcM5tg;

		internal void RFhS0RqKo8S(string s)
		{
			TDaSCSek7dd.Activate();
		}

		internal void smsS0qTmKQs(string s)
		{
			TDaSCSek7dd.AddComment(s);
		}

		internal void LVvS0c68aHv(string s)
		{
			FbmSC2K2Wg3.qrygNA8DbhR(TDaSCSek7dd, s);
		}

		internal void K6FS0V7LI5M(string s)
		{
			TDaSCSek7dd.ApplyOutlineStyles();
		}

		internal void bsmS0Znigcf(string s)
		{
			FbmSC2K2Wg3.EGsgNFoCF0W(TDaSCSek7dd, s);
		}

		internal void jQWS095vjdL(string s)
		{
			TDaSCSek7dd.AutoFit();
		}

		internal void mFqS0h8H3GL(string s)
		{
			TDaSCSek7dd.AutoOutline();
		}

		internal void UX9S0egIGrS(string s)
		{
			TDaSCSek7dd.Calculate();
		}

		internal void cN2S0Y46yf0(string s)
		{
			TDaSCSek7dd.CalculateRowMajorOrder();
		}

		internal void G6MS0I0e3hK(string s)
		{
			TDaSCSek7dd.Clear();
		}

		internal void VJNS0W8OPU8(string s)
		{
			TDaSCSek7dd.ClearComments();
		}

		internal void UxPS0kYXXQo(string s)
		{
			TDaSCSek7dd.ClearContents();
		}

		internal void HHGS0GAp7LU(string s)
		{
			TDaSCSek7dd.ClearFormats();
		}

		internal void OM4S0sLMj16(string s)
		{
			TDaSCSek7dd.ClearHyperlinks();
		}

		internal void DujS0H905IG(string s)
		{
			TDaSCSek7dd.ClearNotes();
		}

		internal void G9KS01n7mnm(string s)
		{
			TDaSCSek7dd.ClearOutline();
		}

		internal void ynHS0bJrp3f(string s)
		{
			FbmSC2K2Wg3.Y4ggNMTWgaV(TDaSCSek7dd, s);
		}

		internal void VNfS06U5rpf(string s)
		{
			TDaSCSek7dd.Copy(string.IsNullOrWhiteSpace(s) ? Type.Missing : (((_Application)TDaSCSek7dd.Application)).Range[(object)s.Trim(), Type.Missing]);
		}

		internal void CAeS0XmQJuT(string s)
		{
			TDaSCSek7dd.Cut(string.IsNullOrWhiteSpace(s) ? Type.Missing : (((_Application)TDaSCSek7dd.Application)).Range[(object)s.Trim(), Type.Missing]);
		}

		internal void S04S0malwUZ(string s)
		{
			string[] array = s.Split(',').Select(_003C_003Ec.yxXSJiCoiij ?? (_003C_003Ec.yxXSJiCoiij = _003C_003Ec.GTrSJlh8OuV.FeQSJ44oyx4)).ToArray();
			if (array.Length != 2)
			{
				throw new InvalidDataException("复制图片");
			}
			TDaSCSek7dd.CopyPicture(AppHelper.ParseEnum(array[0], XlPictureAppearance.xlScreen), AppHelper.ParseEnum(array[1], XlCopyPictureFormat.xlPicture));
		}

		internal void TUKS0KjWiAZ(string s)
		{
			FbmSC2K2Wg3.TPOgNTjXqm1(TDaSCSek7dd, s);
		}

		internal void a9TS0xWe1XR(string s)
		{
			TDaSCSek7dd.Delete(string.IsNullOrEmpty(s) ? Type.Missing : Enum.Parse(typeof(XlDeleteShiftDirection), s));
		}

		internal void AbNS0rs6nQN(string s)
		{
			TDaSCSek7dd.Dirty();
		}

		internal void VXbS0peOaq1(string s)
		{
			FbmSC2K2Wg3.Uc6gNo5UWnR(TDaSCSek7dd, s);
		}

		internal void DqLS0B1nHP3(string s)
		{
			TDaSCSek7dd.FillDown();
		}

		internal void McXS0Q3daRR(string s)
		{
			TDaSCSek7dd.FillLeft();
		}

		internal void qIHS0jD7LY7(string s)
		{
			TDaSCSek7dd.FillRight();
		}

		internal void dL9S0nmNmtN(string s)
		{
			TDaSCSek7dd.FillUp();
		}

		internal void qwfS04sNGfN(string s)
		{
			TDaSCSek7dd.FunctionWizard();
		}

		internal void S04S05Wj6aM(string s)
		{
			string[] array = s.Split(',').Select(_003C_003Ec.L3wSJ3OffFr ?? (_003C_003Ec.L3wSJ3OffFr = _003C_003Ec.GTrSJlh8OuV.fPKSJ5oP3nU)).ToArray();
			TDaSCSek7dd.Insert(string.IsNullOrEmpty(array[0]) ? Type.Missing : ((object)AppHelper.ParseEnum<XlInsertShiftDirection>(array[0])), AppHelper.ParseEnum<XlInsertFormatOrigin>(array[1]));
		}

		internal void QAYS0DoL8EB(string s)
		{
			TDaSCSek7dd.InsertIndent(Convert.ToInt32(s));
		}

		internal void Xg7S0dvamLa(string s)
		{
			TDaSCSek7dd.Justify();
		}

		internal void NCoS0oKDtyo(string s)
		{
			TDaSCSek7dd.Merge(string.IsNullOrEmpty(s) ? Type.Missing : ((object)VariableHelper.StringToBool(s)));
		}

		internal void xPhS0TXvtGu(string s)
		{
			string[] array = s.Split(',').Select(_003C_003Ec.WssSJfsT3yL ?? (_003C_003Ec.WssSJfsT3yL = _003C_003Ec.GTrSJlh8OuV.KoBSJDfUdwY)).ToArray();
			TDaSCSek7dd.Parse(array[0], string.IsNullOrEmpty(array[1]) ? Type.Missing : (((_Application)TDaSCSek7dd.Application)).Range[(object)array[1], Type.Missing]);
		}

		internal void M1SS0MWDy7p(string s)
		{
			string[] array = s.Split(',').Select(_003C_003Ec.zb7SJzgrXPg ?? (_003C_003Ec.zb7SJzgrXPg = _003C_003Ec.GTrSJlh8OuV.d3dSJdJGxMM)).ToArray();
			if (array.Length != 4)
			{
				throw new InvalidDataException("PasteSpecial参数不正确。" + s);
			}
			TDaSCSek7dd.PasteSpecial(AppHelper.ParseEnum<XlPasteType>(array[0]), AppHelper.ParseEnum<XlPasteSpecialOperation>(array[1]), FbmSC2K2Wg3.GetBoolValue(array[2]), FbmSC2K2Wg3.GetBoolValue(array[3]));
		}

		internal void cWUS0AP8nOT(string s)
		{
			_003C_003Ec__DisplayClass81_1 _003C_003Ec__DisplayClass81_ = new _003C_003Ec__DisplayClass81_1
			{
				gHCSCiCJGCk = this,
				uJQSClURiKK = s.Split(',').Select(_003C_003Ec.DUbS0wZXJku ?? (_003C_003Ec.DUbS0wZXJku = _003C_003Ec.GTrSJlh8OuV.hcISJo50N4s)).ToArray()
			};
			if (_003C_003Ec__DisplayClass81_.uJQSClURiKK.Length != 8)
			{
				throw new InvalidDataException("PrintOut参数不正确。" + s);
			}
			AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass81_.hbJSCU0NrGs);
		}

		internal void YWYS0OKCUJQ(string s)
		{
			TDaSCSek7dd.PrintPreview(string.IsNullOrEmpty(s) ? Type.Missing : ((object)VariableHelper.StringToBool(s)));
		}

		internal void TniS0FMCxvj(string s)
		{
			string[] array = s.Split(',').Select(_003C_003Ec.ddfS0tNGxkM ?? (_003C_003Ec.ddfS0tNGxkM = _003C_003Ec.GTrSJlh8OuV.bUTSJTvfy5I)).ToArray();
			if (array.Length != 2)
			{
				throw new InvalidDataException("RemoveDuplicates参数不正确:" + s);
			}
			object[] columns = array[0].Split(new char[2] { ';', '；' }, StringSplitOptions.RemoveEmptyEntries).Select(_003C_003Ec.pCNS0g6E88m ?? (_003C_003Ec.pCNS0g6E88m = _003C_003Ec.GTrSJlh8OuV.vhCSJMYDcpO)).ToArray();
			TDaSCSek7dd.RemoveDuplicates(columns, AppHelper.ParseEnum(array[1], XlYesNoGuess.xlNo));
		}

		internal void WpeS0UaDam5(string s)
		{
			TDaSCSek7dd.RemoveSubtotal();
		}

		internal void yWNS0lhn92q(string s)
		{
			string[] array = s.Split(',');
			if (array.Length != 3)
			{
				throw new InvalidDataException("Replace参数不正确:" + s);
			}
			TDaSCSek7dd.Replace(array[0], array[1], Type.Missing, Type.Missing, FbmSC2K2Wg3.GetBoolValue(array[2]), Type.Missing, Type.Missing, Type.Missing);
		}

		internal void jCcS0iC23V6(string s)
		{
			TDaSCSek7dd.Select();
		}

		internal void f5rS03V7TUP(string s)
		{
			TDaSCSek7dd.SetPhonetic();
		}

		internal void KcsS0fm3ZpP(string s)
		{
			TDaSCSek7dd.Show();
		}

		internal void WY6S0zftEvG(string s)
		{
			TDaSCSek7dd.ShowDependents((!string.IsNullOrEmpty(s)) ? ((object)VariableHelper.StringToBool(s)) : Type.Missing);
		}

		internal void L4pSCwdpPMQ(string s)
		{
			TDaSCSek7dd.ShowErrors();
		}

		internal void mhUSCtLbK9F(string s)
		{
			TDaSCSek7dd.ShowPrecedents(string.IsNullOrEmpty(s) ? Type.Missing : ((object)VariableHelper.StringToBool(s)));
		}

		internal void oq1SCgstWmR(string s)
		{
			string[] array = s.Split(',');
			if (array.Length != 6)
			{
				throw new InvalidDataException("Subtotal参数不正确:" + s);
			}
			TDaSCSek7dd.Subtotal(Convert.ToInt32(array[0]), AppHelper.ParseEnum<XlConsolidationFunction>(array[1]), array[2].Split(new char[2] { ';', '；' }, StringSplitOptions.RemoveEmptyEntries).Select(_003C_003Ec.dxXS0LQKU8I ?? (_003C_003Ec.dxXS0LQKU8I = _003C_003Ec.GTrSJlh8OuV.ssWSJAAdOQZ)).ToArray(), FbmSC2K2Wg3.GetBoolValue(array[3], true), FbmSC2K2Wg3.GetBoolValue(array[4]), AppHelper.ParseEnum<XlSummaryRow>(array[5]));
		}

		internal void d0JSCLln2YG(string s)
		{
			TDaSCSek7dd.Ungroup();
		}

		internal void uyMSCvDBOdf(string s)
		{
			TDaSCSek7dd.UnMerge();
		}

		internal static bool cxiFlAWvSCwWIh4kHsBx()
		{
			return GnO965Wvtrx5HcfcM5tg == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass81_1
	{
		public string[] uJQSClURiKK;

		public _003C_003Ec__DisplayClass81_0 gHCSCiCJGCk;

		internal static _003C_003Ec__DisplayClass81_1 xCe59ZWvCqF5piAOdtgD;

		internal void hbJSCU0NrGs()
		{
			gHCSCiCJGCk.TDaSCSek7dd.PrintOut(string.IsNullOrEmpty(uJQSClURiKK[0]) ? Type.Missing : ((object)Convert.ToInt32(uJQSClURiKK[0])), string.IsNullOrEmpty(uJQSClURiKK[1]) ? Type.Missing : ((object)Convert.ToInt32(uJQSClURiKK[1])), string.IsNullOrEmpty(uJQSClURiKK[2]) ? Type.Missing : ((object)Convert.ToInt32(uJQSClURiKK[2])), gHCSCiCJGCk.FbmSC2K2Wg3.GetBoolValue(uJQSClURiKK[3]), string.IsNullOrEmpty(uJQSClURiKK[4]) ? Type.Missing : uJQSClURiKK[4], gHCSCiCJGCk.FbmSC2K2Wg3.GetBoolValue(uJQSClURiKK[5]), gHCSCiCJGCk.FbmSC2K2Wg3.GetBoolValue(uJQSClURiKK[6]), string.IsNullOrEmpty(uJQSClURiKK[7]) ? Type.Missing : uJQSClURiKK[7]);
		}

		static _003C_003Ec__DisplayClass81_1()
		{
		}

		internal static bool VqWsxpWv7kcotUesq6UZ()
		{
			return xCe59ZWvCqF5piAOdtgD == null;
		}

		internal static void KLpGRgWvhnGwMt948112()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass82_0
	{
		public Range w6rSCfB5JdQ;

		public string[] Pr9SCzjPJ3J;

		private static _003C_003Ec__DisplayClass82_0 mYkwQMWvHUUEMk66Hgqj;

		internal void FpBSC3GMIee()
		{
			w6rSCfB5JdQ.ExportAsFixedFormat(AppHelper.ParseEnum<XlFixedFormatType>(Pr9SCzjPJ3J[0]), Pr9SCzjPJ3J[1], 0, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
		}

		internal static bool QaGthnWvz80TiySu4k1b()
		{
			return mYkwQMWvHUUEMk66Hgqj == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass83_0
	{
		public Range J64SPtFvo7L;

		public string[] DqASPgtSVG4;

		public ExcelRangeOperationStep GYuSPLeyrWW;

		private static _003C_003Ec__DisplayClass83_0 Ok4fbmWdQTQfAqxBlAnH;

		internal void h84SPwgpUW8()
		{
			J64SPtFvo7L.DataSeries(string.IsNullOrWhiteSpace(DqASPgtSVG4[0]) ? null : ((object)AppHelper.ParseEnum<XlRowCol>(DqASPgtSVG4[0])), AppHelper.ParseEnum(DqASPgtSVG4[1], XlDataSeriesType.xlDataSeriesLinear), AppHelper.ParseEnum(DqASPgtSVG4[2], XlDataSeriesDate.xlDay), string.IsNullOrWhiteSpace(DqASPgtSVG4[3]) ? null : DqASPgtSVG4[3], string.IsNullOrWhiteSpace(DqASPgtSVG4[4]) ? null : DqASPgtSVG4[4], GYuSPLeyrWW.GetBoolValue(DqASPgtSVG4[5]));
		}

		internal static bool I29vnOWdFPMQ381CoBv3()
		{
			return Ok4fbmWdQTQfAqxBlAnH == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass89_0
	{
		public Range p3ESP9fHw7n;

		public ExcelRangeOperationStep kGHSPhqmSXf;

		public Action<string> WR8SPe8CdZm;

		public Action<string> bhESPY3q5LV;

		public Action<string> QmtSPIk822I;

		public Action<string> EfYSPWmBxfD;

		public Action<string> sZsSPkoivP8;

		public Action<string> tiESPGTOfEY;

		public Action<string> xGaSPshWvk8;

		public Action<string> QiySPHPsYsO;

		public Action<string> kTwSP1lNcpR;

		public Action<string> AJ2SPbQufc0;

		public Action<string> zOBSP6VssK8;

		public Action<string> VuTSPXL3kMY;

		public Action<string> QyVSPmmnY8t;

		public Action<string> D5ZSPKmVQID;

		public Action<string> um3SPxg8wtq;

		public Action<string> sgwSPr8gl8F;

		public Action<string> ymmSPpBo9ct;

		public Action<string> o3GSPBuSCFp;

		public Action<string> GLJSPQJaes1;

		internal static _003C_003Ec__DisplayClass89_0 XAWUutWdyEUjsr2waYA2;

		internal void aIhSPvHR11O(string value)
		{
			p3ESP9fHw7n.Style = value;
		}

		internal void g4GSPSiiuDU(string value)
		{
			p3ESP9fHw7n.Font.Name = value;
		}

		internal void jjXSP2MgdDH(string value)
		{
			p3ESP9fHw7n.Font.Size = Convert.ToInt32(value);
		}

		internal void PvqSPu0pL0g(string value)
		{
			p3ESP9fHw7n.Font.Bold = VariableHelper.StringToBool(value);
		}

		internal void MnGSPNjL9Vv(string value)
		{
			p3ESP9fHw7n.Font.Italic = VariableHelper.StringToBool(value);
		}

		internal void yRqSPJYZATB(string value)
		{
			p3ESP9fHw7n.Font.Shadow = VariableHelper.StringToBool(value);
		}

		internal void SA5SP0t9FZH(string value)
		{
			p3ESP9fHw7n.Font.Strikethrough = VariableHelper.StringToBool(value);
		}

		internal void NiPSPCVT9Nu(string value)
		{
			p3ESP9fHw7n.Font.Superscript = VariableHelper.StringToBool(value);
		}

		internal void KZ4SPPZgdka(string value)
		{
			p3ESP9fHw7n.Font.Subscript = VariableHelper.StringToBool(value);
		}

		internal void pt3SPEhCyWG(string value)
		{
			p3ESP9fHw7n.Font.FontStyle = value;
		}

		internal void XS3SPyydJQw(string value)
		{
			p3ESP9fHw7n.Font.Color = ColorTranslator.ToOle(ColorTranslator.FromHtml(value));
		}

		internal void BToSP8bIe68(string value)
		{
			p3ESP9fHw7n.Font.Underline = Enum.Parse(typeof(global::Microsoft.Office.Interop.Excel.XlUnderlineStyle), value);
		}

		internal void qxASPabWvQS(string value)
		{
			p3ESP9fHw7n.Interior.Color = ColorTranslator.ToOle(ColorTranslator.FromHtml(value));
		}

		internal void iIlSP7TKat3(string value)
		{
			kGHSPhqmSXf.bn1gNlItkli(p3ESP9fHw7n, value);
		}

		internal void KHqSPRNh8jT(string value)
		{
			p3ESP9fHw7n.ShrinkToFit = VariableHelper.StringToBool(value);
		}

		internal void PAmSPq5r177(string value)
		{
			p3ESP9fHw7n.VerticalAlignment = Enum.Parse(typeof(XlVAlign), value);
		}

		internal void va6SPcQv2CH(string value)
		{
			p3ESP9fHw7n.HorizontalAlignment = Enum.Parse(typeof(XlHAlign), value);
		}

		internal void rPMSPV5f9TQ(string value)
		{
			if (double.TryParse(value, out var result))
			{
				p3ESP9fHw7n.Orientation = result;
			}
			else
			{
				p3ESP9fHw7n.Orientation = Enum.Parse(typeof(XlOrientation), value);
			}
		}

		internal void DlnSPZIfKh2(string value)
		{
			p3ESP9fHw7n.WrapText = VariableHelper.StringToBool(value);
		}

		internal static bool evMrtSWdp0XYUTyjIZtY()
		{
			return XAWUutWdyEUjsr2waYA2 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass95_0
	{
		public Range avGSPoJOSSR;

		public ExcelRangeOperationStep V1ASPTI2sR3;

		private static _003C_003Ec__DisplayClass95_0 sBn9Y7Wd3LsEkPX4mWww;

		internal object f9ISPj6e27w()
		{
			return avGSPoJOSSR.Column;
		}

		internal object tHASPnT5FRS()
		{
			return avGSPoJOSSR.Row;
		}

		internal object p0OSP4LDV24()
		{
			return avGSPoJOSSR.Columns.Count;
		}

		internal object D9OSP5Tqge0()
		{
			return avGSPoJOSSR.Rows.Count;
		}

		internal object DfCSPD5j4xB()
		{
			return avGSPoJOSSR.Worksheet;
		}

		internal object uy4SPdwVPJR()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine($"Style={avGSPoJOSSR.Style}");
			if (string.IsNullOrEmpty((dynamic)avGSPoJOSSR.Font.Name))
			{
				stringBuilder.AppendLine("Font.Name=" + avGSPoJOSSR.Application.StandardFont);
			}
			else
			{
				stringBuilder.AppendLine($"Font.Name={avGSPoJOSSR.Font.Name}");
			}
			stringBuilder.AppendLine($"Font.Size={avGSPoJOSSR.Font.Size}");
			stringBuilder.AppendLine($"Font.Bold={(object)V1ASPTI2sR3.GetBoolValue((dynamic)avGSPoJOSSR.Font.Bold)}");
			if (_003C_003Eo__95.acLSEvmlF5y == null)
			{
				_003C_003Eo__95.acLSEvmlF5y = CallSite<Func<CallSite, ExcelRangeOperationStep, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName, "GetBoolValue", null, typeof(global::Quicker.Domain.Actions.X.BuiltinRunners.Office.ExcelRangeOperationStep), new CSharpArgumentInfo[2]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			stringBuilder.AppendLine($"Font.Italic={_003C_003Eo__95.acLSEvmlF5y.Target(_003C_003Eo__95.acLSEvmlF5y, V1ASPTI2sR3, avGSPoJOSSR.Font.Italic)}");
			int num = 0;
			if (!BQslY2WdEjLt7rMfoyAf())
			{
				goto IL_045f;
			}
			goto IL_0463;
			IL_0463:
			do
			{
				switch (num)
				{
				default:
					stringBuilder.AppendLine($"Font.Shadow={(object)V1ASPTI2sR3.GetBoolValue((dynamic)avGSPoJOSSR.Font.Shadow)}");
					stringBuilder.AppendLine($"Font.Strikethrough={(object)V1ASPTI2sR3.GetBoolValue((dynamic)avGSPoJOSSR.Font.Strikethrough)}");
					stringBuilder.AppendLine($"Font.Superscript={(object)V1ASPTI2sR3.GetBoolValue((dynamic)avGSPoJOSSR.Font.Superscript)}");
					if (_003C_003Eo__95.sYhSENJaT1H == null)
					{
						_003C_003Eo__95.sYhSENJaT1H = CallSite<Func<CallSite, ExcelRangeOperationStep, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName, "GetBoolValue", null, typeof(global::Quicker.Domain.Actions.X.BuiltinRunners.Office.ExcelRangeOperationStep), new CSharpArgumentInfo[2]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					break;
				case 1:
					stringBuilder.AppendLine($"Font.Color={(object)V1ASPTI2sR3.OleColorToRgb((dynamic)avGSPoJOSSR.Font.Color)}");
					stringBuilder.AppendLine($"Font.Underline={(object)V1ASPTI2sR3.GetEnumName<XlUnderlineStyle>((dynamic)avGSPoJOSSR.Font.Underline)}");
					stringBuilder.AppendLine($"Interior.Color={(object)V1ASPTI2sR3.OleColorToRgb((dynamic)avGSPoJOSSR.Interior.Color)}");
					stringBuilder.AppendLine($"ShrinkToFit={(object)V1ASPTI2sR3.GetBoolValue((dynamic)avGSPoJOSSR.ShrinkToFit)}");
					stringBuilder.AppendLine($"WrapText={(object)V1ASPTI2sR3.GetBoolValue((dynamic)avGSPoJOSSR.WrapText)}");
					stringBuilder.AppendLine($"HorizontalAlignment={(object)V1ASPTI2sR3.GetEnumName<XlHAlign>((dynamic)avGSPoJOSSR.HorizontalAlignment)}");
					stringBuilder.AppendLine($"VerticalAlignment={(object)V1ASPTI2sR3.GetEnumName<XlVAlign>((dynamic)avGSPoJOSSR.VerticalAlignment)}");
					if (_003C_003Eo__95.KtcSEakk18i == null)
					{
						_003C_003Eo__95.KtcSEakk18i = CallSite<Func<CallSite, ExcelRangeOperationStep, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName, "GetOrientationString", null, typeof(global::Quicker.Domain.Actions.X.BuiltinRunners.Office.ExcelRangeOperationStep), new CSharpArgumentInfo[2]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					stringBuilder.AppendLine($"Orientation={_003C_003Eo__95.KtcSEakk18i.Target(_003C_003Eo__95.KtcSEakk18i, V1ASPTI2sR3, avGSPoJOSSR.Orientation)}");
					stringBuilder.AppendLine($"//Borders.All={(object)V1ASPTI2sR3.GetEnumName<XlLineStyle>((dynamic)avGSPoJOSSR.Borders.LineStyle)},{(object)V1ASPTI2sR3.GetEnumName<XlBorderWeight>((dynamic)avGSPoJOSSR.Borders.Weight)},{(object)V1ASPTI2sR3.OleColorToRgb((dynamic)avGSPoJOSSR.Borders.Color)}");
					foreach (XlBordersIndex value in Enum.GetValues(typeof(XlBordersIndex)))
					{
						stringBuilder.AppendLine($"//Borders.{value}={V1ASPTI2sR3.GetEnumName<XlLineStyle>((dynamic)avGSPoJOSSR.Borders[value].LineStyle)},{V1ASPTI2sR3.GetEnumName<XlBorderWeight>((dynamic)avGSPoJOSSR.Borders[value].Weight)},{V1ASPTI2sR3.OleColorToRgb((dynamic)avGSPoJOSSR.Borders[value].Color)}");
					}
					return stringBuilder.ToString();
				}
				stringBuilder.AppendLine($"Font.Subscript={_003C_003Eo__95.sYhSENJaT1H.Target(_003C_003Eo__95.sYhSENJaT1H, V1ASPTI2sR3, avGSPoJOSSR.Font.Subscript)}");
				num = 1;
			}
			while (BQslY2WdEjLt7rMfoyAf());
			goto IL_045f;
			IL_045f:
			int num2 = default(int);
			num = num2;
			goto IL_0463;
		}

		static _003C_003Ec__DisplayClass95_0()
		{
		}

		internal static bool BQslY2WdEjLt7rMfoyAf()
		{
			return sBn9Y7Wd3LsEkPX4mWww == null;
		}

		internal static void LgOW92Wdd4IE4tGw0bVI()
		{
		}
	}

	[CompilerGenerated]
	private static class _003C_003Eo__103
	{
		public static CallSite<Func<CallSite, object, Range>> HAPSPMZfl12;

		public static CallSite<Func<CallSite, object, Range>> EhhSPAXbcF1;

		public static CallSite<Func<CallSite, object, Range>> H6SSPOFAvfM;

		public static CallSite<Func<CallSite, object, Range>> vbWSPFjQvhp;

		public static CallSite<Func<CallSite, object, Range>> vaPSPUQbyvY;

		public static CallSite<Func<CallSite, object, Range>> JybSPlXS0Bs;

		public static CallSite<Func<CallSite, object, Range>> pS8SPiV17UY;
	}

	[CompilerGenerated]
	private static class _003C_003Eo__95
	{
		public static CallSite<Action<CallSite, Type, StepOutParamDef, ActionStep, ActionExecuteContext, object, XAction>> l32SP3xDk7n;

		public static CallSite<Action<CallSite, Type, StepOutParamDef, ActionStep, ActionExecuteContext, object, XAction>> VQpSPfrkWIx;

		public static CallSite<Action<CallSite, Type, StepOutParamDef, ActionStep, ActionExecuteContext, object, XAction>> kHiSPzpJEj9;

		public static CallSite<Action<CallSite, Type, StepOutParamDef, ActionStep, ActionExecuteContext, object, XAction>> fN8SEwGKWBl;

		public static CallSite<Func<CallSite, Type, object, object>> N4PSEtLKfLO;

		public static CallSite<Func<CallSite, object, bool>> FJCSEgFJKUF;

		public static CallSite<Func<CallSite, ExcelRangeOperationStep, object, object>> eI2SELNprQp;

		public static CallSite<Func<CallSite, ExcelRangeOperationStep, object, object>> acLSEvmlF5y;

		public static CallSite<Func<CallSite, ExcelRangeOperationStep, object, object>> cblSESdwsEp;

		public static CallSite<Func<CallSite, ExcelRangeOperationStep, object, object>> f4pSE2nq1Fi;

		public static CallSite<Func<CallSite, ExcelRangeOperationStep, object, object>> TL8SEuIx3t3;

		public static CallSite<Func<CallSite, ExcelRangeOperationStep, object, object>> sYhSENJaT1H;

		public static CallSite<Func<CallSite, ExcelRangeOperationStep, object, object>> HLySEJ9EK7Z;

		public static CallSite<Func<CallSite, ExcelRangeOperationStep, object, object>> d7XSE00LUsc;

		public static CallSite<Func<CallSite, ExcelRangeOperationStep, object, object>> cIkSECM87ra;

		public static CallSite<Func<CallSite, ExcelRangeOperationStep, object, object>> sgFSEPafBFJ;

		public static CallSite<Func<CallSite, ExcelRangeOperationStep, object, object>> BPESEECrmvd;

		public static CallSite<Func<CallSite, ExcelRangeOperationStep, object, object>> NNCSEytLuNW;

		public static CallSite<Func<CallSite, ExcelRangeOperationStep, object, object>> kV7SE8l3LWM;

		public static CallSite<Func<CallSite, ExcelRangeOperationStep, object, object>> KtcSEakk18i;

		public static CallSite<Func<CallSite, ExcelRangeOperationStep, object, object>> PBNSE7SIT8R;

		public static CallSite<Func<CallSite, ExcelRangeOperationStep, object, object>> mMoSERmjYQ5;

		public static CallSite<Func<CallSite, ExcelRangeOperationStep, object, object>> SxZSEqErrQd;

		public static CallSite<Func<CallSite, ExcelRangeOperationStep, object, object>> GEVSEc06NxJ;

		public static CallSite<Func<CallSite, ExcelRangeOperationStep, object, object>> zHWSEVTIa7U;

		public static CallSite<Func<CallSite, ExcelRangeOperationStep, object, object>> nQVSEZrPrfq;
	}

	[CompilerGenerated]
	private static class _003C_003Eo__96<T>
	{
		public static CallSite<Func<CallSite, object, object, object>> _003C_003Ep__0;

		public static CallSite<Func<CallSite, object, bool>> _003C_003Ep__1;

		public static CallSite<Func<CallSite, Type, Type, object, object>> _003C_003Ep__2;

		public static CallSite<Func<CallSite, object, string>> _003C_003Ep__3;

		public static CallSite<Func<CallSite, object, object>> _003C_003Ep__4;

		public static CallSite<Func<CallSite, object, string>> _003C_003Ep__5;
	}

	[CompilerGenerated]
	private static class _003C_003Eo__97
	{
		public static CallSite<Func<CallSite, object, object>> HNKSE9YDQdN;

		public static CallSite<Func<CallSite, object, string>> rUfSEhlIIEu;
	}

	[CompilerGenerated]
	private static class _003C_003Eo__98
	{
		public static CallSite<Func<CallSite, object, int, object>> lMLSEeRKfct;

		public static CallSite<Func<CallSite, object, bool>> VSVSEYXnxWx;

		public static CallSite<Func<CallSite, Type, Type, object, object>> r6pSEIdMnTf;

		public static CallSite<Func<CallSite, object, string>> R0NSEWORw7N;

		public static CallSite<Func<CallSite, object, object>> QlfSEkyrHCT;

		public static CallSite<Func<CallSite, object, string>> S6ESEGptk2x;
	}

	[CompilerGenerated]
	private static class _003C_003Eo__99
	{
		public static CallSite<Func<CallSite, object, bool, object>> SMGSEsVR2ZD;

		public static CallSite<Func<CallSite, object, bool>> IQHSEHRFmEY;

		public static CallSite<Func<CallSite, object, object>> K3vSE1drGY4;

		public static CallSite<Func<CallSite, object, string>> KM2SEb3gQJ4;
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> NPBgJSNOQym = new List<string> { "office" };

	[CompilerGenerated]
	private readonly string MNZgJ2FC5Cn = $"fa:{EFontAwesomeIcon.Light_Table}:#6aaded";

	[CompilerGenerated]
	private readonly StepRunnerCategory LqygJuDk72p = StepRunnerCategory.SoftInteraction;

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> p4DgJNxWc4r;

	[CompilerGenerated]
	private readonly string bH3gJJNsULn = "https://getquicker.net/KC/Help/Doc/excelrange";

	public static StepInParamDef _rangeParam;

	public static StepInParamDef _subRangeParam;

	public static StepInParamDef _operationParam;

	public static StepInParamDef _valueParam;

	public static StepInParamDef _cellSizeParam;

	public static StepInParamDef _styleParam;

	public static StepInParamDef _methodsParam;

	private static readonly StepInParamDef SOggJ0pqCnC;

	private static readonly StepInParamDef tpDgJCl8psO;

	private static readonly StepInParamDef raLgJPgUlKT;

	private static readonly StepInParamDef lxwgJEkb90f;

	private static readonly StepInParamDef ByBgJyAFtOY;

	private static readonly StepInParamDef sSOgJ89MYga;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> qCvgJaopseR = new List<StepInParamDef>
	{
		_rangeParam, _subRangeParam, _operationParam, _valueParam, _cellSizeParam, _styleParam, _methodsParam, SOggJ0pqCnC, tpDgJCl8psO, raLgJPgUlKT,
		lxwgJEkb90f, ByBgJyAFtOY, sSOgJ89MYga
	};

	private static readonly StepOutParamDef ONAgJ73WxQq;

	private static readonly StepOutParamDef bvGgJRbLdgM;

	private static readonly StepOutParamDef KphgJqSJWQe;

	private static readonly StepOutParamDef F2ogJc9NmmU;

	private static readonly StepOutParamDef xaZgJVim1Qk;

	private static readonly StepOutParamDef yMrgJZseB99;

	private static readonly StepOutParamDef cjqgJ9C5FOE;

	private static readonly StepOutParamDef r6ngJhUJItX;

	private static readonly StepOutParamDef juugJeBBvS2;

	private static readonly StepOutParamDef eIJgJYshmtA;

	private static readonly StepOutParamDef sMagJInItwl;

	private static readonly StepOutParamDef E86gJWR6O7n;

	private static readonly StepOutParamDef nUlgJkaasch;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> QxIgJGi3mCc = new List<StepOutParamDef>
	{
		ONAgJ73WxQq, bvGgJRbLdgM, KphgJqSJWQe, F2ogJc9NmmU, xaZgJVim1Qk, yMrgJZseB99, cjqgJ9C5FOE, r6ngJhUJItX, juugJeBBvS2, eIJgJYshmtA,
		sMagJInItwl, E86gJWR6O7n, nUlgJkaasch
	};

	internal static ExcelRangeOperationStep ae8hywQMEDxhVBuA3ISw;

	public string Key => "sys:excelRange";

	public string Name => "Excel区域操作";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return NPBgJSNOQym;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return MNZgJ2FC5Cn;
		}
	}

	public StepRunnerCategory Category
	{
		[CompilerGenerated]
		get
		{
			return LqygJuDk72p;
		}
	}

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return p4DgJNxWc4r;
		}
	}

	public string Description => "操作Excel的某个区域或单元格";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return bH3gJJNsULn;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly => false;

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return qCvgJaopseR;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return QxIgJGi3mCc;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass79_0 _003C_003Ec__DisplayClass79_ = new _003C_003Ec__DisplayClass79_0();
		_003C_003Ec__DisplayClass79_.TlfS0y2QoKS = this;
		_003C_003Ec__DisplayClass79_.JFKS08MQvy6 = step;
		_003C_003Ec__DisplayClass79_.VFmS0aTG1mm = context;
		_003C_003Ec__DisplayClass79_.BAMS075YgSV = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass79_.VFmS0aTG1mm, _003C_003Ec__DisplayClass79_.JFKS08MQvy6, _003C_003Ec__DisplayClass79_.BAMS075YgSV, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass79_.QFSS0Er8tnI, (Action)null, (Action)null, sSOgJ89MYga, ONAgJ73WxQq);
	}

	private void AaagNDtNJSY(Range range_0, ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0)
	{
		string text = XActionHelper.GetTextParamValue(SOggJ0pqCnC, actionStep_0, actionExecuteContext_0);
		string text2 = XActionHelper.GetTextParamValue(tpDgJCl8psO, actionStep_0, actionExecuteContext_0);
		bool booleanParamValue = XActionHelper.GetBooleanParamValue(raLgJPgUlKT, actionStep_0, actionExecuteContext_0);
		bool booleanParamValue2 = XActionHelper.GetBooleanParamValue(lxwgJEkb90f, actionStep_0, actionExecuteContext_0);
		bool booleanParamValue3 = XActionHelper.GetBooleanParamValue(ByBgJyAFtOY, actionStep_0, actionExecuteContext_0);
		if (booleanParamValue)
		{
			text = AppHelper.UnescapeString(text);
		}
		if (booleanParamValue2)
		{
			text2 = AppHelper.UnescapeString(text2);
		}
		range_0.Replace(text, text2, Type.Missing, Type.Missing, booleanParamValue3, Type.Missing, Type.Missing, Type.Missing);
	}

	private void t6CgNdtcIjX(Range range_0, ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0)
	{
		_003C_003Ec__DisplayClass81_0 _003C_003Ec__DisplayClass81_ = new _003C_003Ec__DisplayClass81_0();
		_003C_003Ec__DisplayClass81_.TDaSCSek7dd = range_0;
		_003C_003Ec__DisplayClass81_.FbmSC2K2Wg3 = this;
		string[] array = XActionHelper.GetTextParamValue(_methodsParam, actionStep_0, actionExecuteContext_0).Split(new string[2] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
		string text = default(string);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			while (true)
			{
				int num2;
				if (num < array.Length)
				{
					text = array[num];
					if (text.StartsWith("//") || AppHelper.IfMatchThen(text, "Activate:", _003C_003Ec__DisplayClass81_.XM8SCuhh3qN ?? (_003C_003Ec__DisplayClass81_.XM8SCuhh3qN = _003C_003Ec__DisplayClass81_.RFhS0RqKo8S)))
					{
						goto IL_0b03;
					}
					num2 = 3;
					if (!wY4pnJQMGI6ClLXA7SXY())
					{
						goto IL_0923;
					}
				}
				else
				{
					num2 = 6;
					if (ae8hywQMEDxhVBuA3ISw != null)
					{
						goto IL_05b0;
					}
				}
				goto IL_0a03;
				IL_05b0:
				num2 = num3;
				goto IL_0a03;
				IL_0a03:
				while (true)
				{
					switch (num2)
					{
					case 5:
						break;
					case 3:
						goto IL_05b9;
					case 1:
						goto IL_079b;
					default:
						goto end_IL_0a03;
					case 4:
						goto IL_0a2a;
					case 2:
						goto end_IL_0b20;
					case 6:
						return;
					}
					goto IL_00a8;
					IL_079b:
					if (AppHelper.IfMatchThen(text, "PasteSpecial:", _003C_003Ec__DisplayClass81_.idcSCpaIWhW ?? (_003C_003Ec__DisplayClass81_.idcSCpaIWhW = _003C_003Ec__DisplayClass81_.M1SS0MWDy7p)) || AppHelper.IfMatchThen(text, "PrintOut:", _003C_003Ec__DisplayClass81_.B8LSCBQ2Iaq ?? (_003C_003Ec__DisplayClass81_.B8LSCBQ2Iaq = _003C_003Ec__DisplayClass81_.cWUS0AP8nOT)) || AppHelper.IfMatchThen(text, "PrintPreview:", _003C_003Ec__DisplayClass81_.DAHSCQ8Areg ?? (_003C_003Ec__DisplayClass81_.DAHSCQ8Areg = _003C_003Ec__DisplayClass81_.YWYS0OKCUJQ)) || AppHelper.IfMatchThen(text, "RemoveDuplicates:", _003C_003Ec__DisplayClass81_.oTFSCjWOSgB ?? (_003C_003Ec__DisplayClass81_.oTFSCjWOSgB = _003C_003Ec__DisplayClass81_.TniS0FMCxvj)) || AppHelper.IfMatchThen(text, "RemoveSubtotal:", _003C_003Ec__DisplayClass81_.M3qSCn4VrTA ?? (_003C_003Ec__DisplayClass81_.M3qSCn4VrTA = _003C_003Ec__DisplayClass81_.WpeS0UaDam5)) || AppHelper.IfMatchThen(text, "Replace:", _003C_003Ec__DisplayClass81_.mfoSC4uS0Q9 ?? (_003C_003Ec__DisplayClass81_.mfoSC4uS0Q9 = _003C_003Ec__DisplayClass81_.yWNS0lhn92q)) || AppHelper.IfMatchThen(text, "Select:", _003C_003Ec__DisplayClass81_.tr3SC5ty6fP ?? (_003C_003Ec__DisplayClass81_.tr3SC5ty6fP = _003C_003Ec__DisplayClass81_.jCcS0iC23V6)))
					{
						goto IL_0b03;
					}
					num2 = 0;
					if (wY4pnJQMGI6ClLXA7SXY())
					{
						continue;
					}
					goto IL_05b0;
					IL_05b9:
					if (AppHelper.IfMatchThen(text, "AddComment:", _003C_003Ec__DisplayClass81_.ILySCNDkHIj ?? (_003C_003Ec__DisplayClass81_.ILySCNDkHIj = _003C_003Ec__DisplayClass81_.smsS0qTmKQs)) || AppHelper.IfMatchThen(text, "AdvancedFilter:", _003C_003Ec__DisplayClass81_.jJDSCJNhS9i ?? (_003C_003Ec__DisplayClass81_.jJDSCJNhS9i = _003C_003Ec__DisplayClass81_.LVvS0c68aHv)) || AppHelper.IfMatchThen(text, "ApplyOutlineStyles:", _003C_003Ec__DisplayClass81_.iveSC0o3QaE ?? (_003C_003Ec__DisplayClass81_.iveSC0o3QaE = _003C_003Ec__DisplayClass81_.K6FS0V7LI5M)) || AppHelper.IfMatchThen(text, "AutoFill:", _003C_003Ec__DisplayClass81_.u9lSCC2i4j6 ?? (_003C_003Ec__DisplayClass81_.u9lSCC2i4j6 = _003C_003Ec__DisplayClass81_.bsmS0Znigcf)) || AppHelper.IfMatchThen(text, "AutoFit:", _003C_003Ec__DisplayClass81_.zTnSCPcG3AY ?? (_003C_003Ec__DisplayClass81_.zTnSCPcG3AY = _003C_003Ec__DisplayClass81_.jQWS095vjdL)) || AppHelper.IfMatchThen(text, "AutoOutline:", _003C_003Ec__DisplayClass81_.FFNSCEL1Ahu ?? (_003C_003Ec__DisplayClass81_.FFNSCEL1Ahu = _003C_003Ec__DisplayClass81_.mFqS0h8H3GL)) || AppHelper.IfMatchThen(text, "Calculate:", _003C_003Ec__DisplayClass81_.tlcSCyUsEAr ?? (_003C_003Ec__DisplayClass81_.tlcSCyUsEAr = _003C_003Ec__DisplayClass81_.UX9S0egIGrS)) || AppHelper.IfMatchThen(text, "CalculateRowMajorOrder:", _003C_003Ec__DisplayClass81_.FAvSC8hMkYx ?? (_003C_003Ec__DisplayClass81_.FAvSC8hMkYx = _003C_003Ec__DisplayClass81_.cN2S0Y46yf0)) || AppHelper.IfMatchThen(text, "Clear:", _003C_003Ec__DisplayClass81_.fkjSCavl6bd ?? (_003C_003Ec__DisplayClass81_.fkjSCavl6bd = _003C_003Ec__DisplayClass81_.G6MS0I0e3hK)))
					{
						goto IL_0b03;
					}
					goto IL_00a8;
					IL_00a8:
					if (AppHelper.IfMatchThen(text, "ClearComments:", _003C_003Ec__DisplayClass81_.UCcSC7SULG3 ?? (_003C_003Ec__DisplayClass81_.UCcSC7SULG3 = _003C_003Ec__DisplayClass81_.VJNS0W8OPU8)) || AppHelper.IfMatchThen(text, "ClearContents:", _003C_003Ec__DisplayClass81_.MyXSCRYDBNK ?? (_003C_003Ec__DisplayClass81_.MyXSCRYDBNK = _003C_003Ec__DisplayClass81_.UxPS0kYXXQo)) || AppHelper.IfMatchThen(text, "ClearFormats:", _003C_003Ec__DisplayClass81_.kYpSCqRb4ZQ ?? (_003C_003Ec__DisplayClass81_.kYpSCqRb4ZQ = _003C_003Ec__DisplayClass81_.HHGS0GAp7LU)) || AppHelper.IfMatchThen(text, "ClearHyperlinks:", _003C_003Ec__DisplayClass81_.TLZSCcVTejs ?? (_003C_003Ec__DisplayClass81_.TLZSCcVTejs = _003C_003Ec__DisplayClass81_.OM4S0sLMj16)) || AppHelper.IfMatchThen(text, "ClearNotes:", _003C_003Ec__DisplayClass81_.csWSCVLFlOH ?? (_003C_003Ec__DisplayClass81_.csWSCVLFlOH = _003C_003Ec__DisplayClass81_.DujS0H905IG)) || AppHelper.IfMatchThen(text, "ClearOutline:", _003C_003Ec__DisplayClass81_.LsXSCZtloQG ?? (_003C_003Ec__DisplayClass81_.LsXSCZtloQG = _003C_003Ec__DisplayClass81_.G9KS01n7mnm)) || AppHelper.IfMatchThen(text, "Consolidate:", _003C_003Ec__DisplayClass81_.Ll7SC9bEDGl ?? (_003C_003Ec__DisplayClass81_.Ll7SC9bEDGl = _003C_003Ec__DisplayClass81_.ynHS0bJrp3f)) || AppHelper.IfMatchThen(text, "Copy:", _003C_003Ec__DisplayClass81_.NdsSChg8mAA ?? (_003C_003Ec__DisplayClass81_.NdsSChg8mAA = _003C_003Ec__DisplayClass81_.VNfS06U5rpf)) || AppHelper.IfMatchThen(text, "Cut:", _003C_003Ec__DisplayClass81_.m4eSCeCxAhd ?? (_003C_003Ec__DisplayClass81_.m4eSCeCxAhd = _003C_003Ec__DisplayClass81_.CAeS0XmQJuT)) || AppHelper.IfMatchThen(text, "CopyPicture:", _003C_003Ec__DisplayClass81_.AFPSCYfIaKf ?? (_003C_003Ec__DisplayClass81_.AFPSCYfIaKf = _003C_003Ec__DisplayClass81_.S04S0malwUZ)) || AppHelper.IfMatchThen(text, "DataSeries:", _003C_003Ec__DisplayClass81_.f1fSCItClWC ?? (_003C_003Ec__DisplayClass81_.f1fSCItClWC = _003C_003Ec__DisplayClass81_.TUKS0KjWiAZ)) || AppHelper.IfMatchThen(text, "Delete:", _003C_003Ec__DisplayClass81_.qTYSCW35vsy ?? (_003C_003Ec__DisplayClass81_.qTYSCW35vsy = _003C_003Ec__DisplayClass81_.a9TS0xWe1XR)) || AppHelper.IfMatchThen(text, "Dirty:", _003C_003Ec__DisplayClass81_.KyuSCkPZ4HO ?? (_003C_003Ec__DisplayClass81_.KyuSCkPZ4HO = _003C_003Ec__DisplayClass81_.AbNS0rs6nQN)) || AppHelper.IfMatchThen(text, "ExportAsFixedFormat:", _003C_003Ec__DisplayClass81_.sGVSCG3OscD ?? (_003C_003Ec__DisplayClass81_.sGVSCG3OscD = _003C_003Ec__DisplayClass81_.VXbS0peOaq1)) || AppHelper.IfMatchThen(text, "FillDown:", _003C_003Ec__DisplayClass81_.y8wSCssT9uZ ?? (_003C_003Ec__DisplayClass81_.y8wSCssT9uZ = _003C_003Ec__DisplayClass81_.DqLS0B1nHP3)) || AppHelper.IfMatchThen(text, "FillLeft:", _003C_003Ec__DisplayClass81_.mdqSCHRMNNm ?? (_003C_003Ec__DisplayClass81_.mdqSCHRMNNm = _003C_003Ec__DisplayClass81_.McXS0Q3daRR)) || AppHelper.IfMatchThen(text, "FillRight:", _003C_003Ec__DisplayClass81_.DK1SC1oDsPY ?? (_003C_003Ec__DisplayClass81_.DK1SC1oDsPY = _003C_003Ec__DisplayClass81_.qIHS0jD7LY7)) || AppHelper.IfMatchThen(text, "FillUp:", _003C_003Ec__DisplayClass81_.XklSCbBa4qR ?? (_003C_003Ec__DisplayClass81_.XklSCbBa4qR = _003C_003Ec__DisplayClass81_.dL9S0nmNmtN)) || AppHelper.IfMatchThen(text, "FunctionWizard:", _003C_003Ec__DisplayClass81_.GOBSC6mmRF8 ?? (_003C_003Ec__DisplayClass81_.GOBSC6mmRF8 = _003C_003Ec__DisplayClass81_.qwfS04sNGfN)) || AppHelper.IfMatchThen(text, "Insert:", _003C_003Ec__DisplayClass81_.A0rSCXUqyYc ?? (_003C_003Ec__DisplayClass81_.A0rSCXUqyYc = _003C_003Ec__DisplayClass81_.S04S05Wj6aM)) || AppHelper.IfMatchThen(text, "InsertIndent:", _003C_003Ec__DisplayClass81_.aykSCmDyk5V ?? (_003C_003Ec__DisplayClass81_.aykSCmDyk5V = _003C_003Ec__DisplayClass81_.QAYS0DoL8EB)) || AppHelper.IfMatchThen(text, "Justify:", _003C_003Ec__DisplayClass81_.t54SCKyIIfW ?? (_003C_003Ec__DisplayClass81_.t54SCKyIIfW = _003C_003Ec__DisplayClass81_.Xg7S0dvamLa)) || AppHelper.IfMatchThen(text, "Merge:", _003C_003Ec__DisplayClass81_.PBnSCxHLBLv ?? (_003C_003Ec__DisplayClass81_.PBnSCxHLBLv = _003C_003Ec__DisplayClass81_.NCoS0oKDtyo)) || AppHelper.IfMatchThen(text, "Parse:", _003C_003Ec__DisplayClass81_.JvnSCrTKspM ?? (_003C_003Ec__DisplayClass81_.JvnSCrTKspM = _003C_003Ec__DisplayClass81_.xPhS0TXvtGu)))
					{
						goto IL_0b03;
					}
					num2 = 1;
					if (ae8hywQMEDxhVBuA3ISw == null)
					{
						continue;
					}
					goto IL_05b0;
					continue;
					end_IL_0a03:
					break;
				}
				goto IL_0923;
				IL_0923:
				if (AppHelper.IfMatchThen(text, "SetPhonetic:", _003C_003Ec__DisplayClass81_.rb9SCDJQAQW ?? (_003C_003Ec__DisplayClass81_.rb9SCDJQAQW = _003C_003Ec__DisplayClass81_.f5rS03V7TUP)) || AppHelper.IfMatchThen(text, "Show:", _003C_003Ec__DisplayClass81_.DGBSCd7mEfD ?? (_003C_003Ec__DisplayClass81_.DGBSCd7mEfD = _003C_003Ec__DisplayClass81_.KcsS0fm3ZpP)) || AppHelper.IfMatchThen(text, "ShowDependents:", _003C_003Ec__DisplayClass81_.WsMSCo8Rgch ?? (_003C_003Ec__DisplayClass81_.WsMSCo8Rgch = _003C_003Ec__DisplayClass81_.WY6S0zftEvG)) || AppHelper.IfMatchThen(text, "ShowErrors:", _003C_003Ec__DisplayClass81_.pE9SCTwK2Bu ?? (_003C_003Ec__DisplayClass81_.pE9SCTwK2Bu = _003C_003Ec__DisplayClass81_.L4pSCwdpPMQ)))
				{
					goto IL_0b03;
				}
				num2 = 2;
				if (ae8hywQMEDxhVBuA3ISw != null)
				{
					goto IL_0a03;
				}
				goto IL_0a2a;
				IL_0b03:
				num++;
				continue;
				IL_0a2a:
				if (!AppHelper.IfMatchThen(text, "ShowPrecedents:", _003C_003Ec__DisplayClass81_.CQ9SCMPtJPL ?? (_003C_003Ec__DisplayClass81_.CQ9SCMPtJPL = _003C_003Ec__DisplayClass81_.mhUSCtLbK9F)) && !AppHelper.IfMatchThen(text, "Subtotal:", _003C_003Ec__DisplayClass81_.tHESCAtAkHA ?? (_003C_003Ec__DisplayClass81_.tHESCAtAkHA = _003C_003Ec__DisplayClass81_.oq1SCgstWmR)) && !AppHelper.IfMatchThen(text, "Ungroup:", _003C_003Ec__DisplayClass81_.SevSCOcnGvp ?? (_003C_003Ec__DisplayClass81_.SevSCOcnGvp = _003C_003Ec__DisplayClass81_.d0JSCLln2YG)) && !AppHelper.IfMatchThen(text, "UnMerge:", _003C_003Ec__DisplayClass81_.sArSCFbn7ch ?? (_003C_003Ec__DisplayClass81_.sArSCFbn7ch = _003C_003Ec__DisplayClass81_.uyMSCvDBOdf)) && !text.StartsWith("//"))
				{
					throw new InvalidDataException("不支持的方法调用：" + text);
				}
				goto IL_0b03;
				continue;
				end_IL_0b20:
				break;
			}
		}
	}

	private void Uc6gNo5UWnR(Range range_0, string string_2)
	{
		_003C_003Ec__DisplayClass82_0 _003C_003Ec__DisplayClass82_ = new _003C_003Ec__DisplayClass82_0();
		_003C_003Ec__DisplayClass82_.w6rSCfB5JdQ = range_0;
		_003C_003Ec__DisplayClass82_.Pr9SCzjPJ3J = string_2.Split(',').Select(_003C_003Ec.BEsS0voVbpF ?? (_003C_003Ec.BEsS0voVbpF = _003C_003Ec.GTrSJlh8OuV.PVpSJOf2G5M)).ToArray();
		AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass82_.FpBSC3GMIee);
	}

	private void TPOgNTjXqm1(Range range_0, string string_2)
	{
		_003C_003Ec__DisplayClass83_0 _003C_003Ec__DisplayClass83_ = new _003C_003Ec__DisplayClass83_0();
		_003C_003Ec__DisplayClass83_.J64SPtFvo7L = range_0;
		_003C_003Ec__DisplayClass83_.GYuSPLeyrWW = this;
		_003C_003Ec__DisplayClass83_.DqASPgtSVG4 = string_2.Split(',').Select(_003C_003Ec.tkeS0SHInZW ?? (_003C_003Ec.tkeS0SHInZW = _003C_003Ec.GTrSJlh8OuV.ob9SJFN9wck)).ToArray();
		if (_003C_003Ec__DisplayClass83_.DqASPgtSVG4.Length != 12)
		{
			throw new InvalidDataException("DataSeries方法的参数不正确：" + string_2);
		}
		AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass83_.h84SPwgpUW8);
	}

	private void Y4ggNMTWgaV(Range range_0, string string_2)
	{
		string[] array = string_2.Split(',');
		if (array.Length != 5)
		{
			throw new InvalidDataException("Consolidate参数不合法：" + string_2);
		}
		string[] sources = array[0].Split(new char[1] { ';' }, StringSplitOptions.RemoveEmptyEntries).Select(_003C_003Ec.OfmS02wt2wj ?? (_003C_003Ec.OfmS02wt2wj = _003C_003Ec.GTrSJlh8OuV.gr8SJUCf0FI)).ToArray();
		range_0.Consolidate(sources, AppHelper.ParseEnum<XlConsolidationFunction>(array[1]), GetBoolValue(array[2]), GetBoolValue(array[3]), GetBoolValue(array[4]));
	}

	private void qrygNA8DbhR(Range range_0, string string_2)
	{
		string[] array = string_2.Split(new char[1] { ',' }, StringSplitOptions.None);
		if (array.Length != 4)
		{
			throw new InvalidDataException("AdvancedFilter参数不正确");
		}
		range_0.AdvancedFilter(AppHelper.ParseEnum<XlFilterAction>(array[0]), k8RgNOtFEGt(range_0, array[1]), k8RgNOtFEGt(range_0, array[2]), GetBoolValue(array[3]));
	}

	private Range k8RgNOtFEGt(Range range_0, string string_2)
	{
		if (string.IsNullOrWhiteSpace(string_2))
		{
			return null;
		}
		return ((dynamic)range_0.Application).Range[(object)string_2, Type.Missing];
	}

	private bool GetBoolValue(string value, bool defaultValue = false)
	{
		if (string.IsNullOrWhiteSpace(value))
		{
			return defaultValue;
		}
		return VariableHelper.StringToBool(value);
	}

	private void EGsgNFoCF0W(Range range_0, string string_2)
	{
		string[] array = string_2.Split(new char[1] { ',' }, StringSplitOptions.None);
		if (array.Length != 2)
		{
			throw new InvalidDataException("AutoFill参数个数不正确。");
		}
		Range destination = ((dynamic)range_0.Application).Range[(object)array[0].Trim(), Type.Missing];
		XlAutoFillType type = XlAutoFillType.xlFillDefault;
		if (!string.IsNullOrEmpty(array[1].Trim()))
		{
			type = (XlAutoFillType)Enum.Parse(typeof(global::Microsoft.Office.Interop.Excel.XlAutoFillType), array[1].Trim());
		}
		range_0.AutoFill(destination, type);
	}

	private void Ec5gNUmMNSH(Range range_0, ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0)
	{
		_003C_003Ec__DisplayClass89_0 _003C_003Ec__DisplayClass89_ = new _003C_003Ec__DisplayClass89_0();
		_003C_003Ec__DisplayClass89_.p3ESP9fHw7n = range_0;
		_003C_003Ec__DisplayClass89_.kGHSPhqmSXf = this;
		string[] array = XActionHelper.GetTextParamValue(_styleParam, actionStep_0, actionExecuteContext_0).Split(new string[2] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
		try
		{
			_003C_003Ec__DisplayClass89_.p3ESP9fHw7n.Application.ScreenUpdating = false;
			string[] array2 = array;
			int num2 = default(int);
			foreach (string text in array2)
			{
				if (text.StartsWith("//") || AppHelper.IfMatchThen(text, "Style=", _003C_003Ec__DisplayClass89_.WR8SPe8CdZm ?? (_003C_003Ec__DisplayClass89_.WR8SPe8CdZm = _003C_003Ec__DisplayClass89_.aIhSPvHR11O)) || AppHelper.IfMatchThen(text, "Font.Name=", _003C_003Ec__DisplayClass89_.bhESPY3q5LV ?? (_003C_003Ec__DisplayClass89_.bhESPY3q5LV = _003C_003Ec__DisplayClass89_.g4GSPSiiuDU)))
				{
					continue;
				}
				while (!AppHelper.IfMatchThen(text, "Font.Size=", _003C_003Ec__DisplayClass89_.QmtSPIk822I ?? (_003C_003Ec__DisplayClass89_.QmtSPIk822I = _003C_003Ec__DisplayClass89_.jjXSP2MgdDH)) && !AppHelper.IfMatchThen(text, "Font.Bold=", _003C_003Ec__DisplayClass89_.EfYSPWmBxfD ?? (_003C_003Ec__DisplayClass89_.EfYSPWmBxfD = _003C_003Ec__DisplayClass89_.PvqSPu0pL0g)) && !AppHelper.IfMatchThen(text, "Font.Italic=", _003C_003Ec__DisplayClass89_.sZsSPkoivP8 ?? (_003C_003Ec__DisplayClass89_.sZsSPkoivP8 = _003C_003Ec__DisplayClass89_.MnGSPNjL9Vv)) && !AppHelper.IfMatchThen(text, "Font.Shadow=", _003C_003Ec__DisplayClass89_.tiESPGTOfEY ?? (_003C_003Ec__DisplayClass89_.tiESPGTOfEY = _003C_003Ec__DisplayClass89_.yRqSPJYZATB)))
				{
					while (!AppHelper.IfMatchThen(text, "Font.Strikethrough=", _003C_003Ec__DisplayClass89_.xGaSPshWvk8 ?? (_003C_003Ec__DisplayClass89_.xGaSPshWvk8 = _003C_003Ec__DisplayClass89_.SA5SP0t9FZH)) && !AppHelper.IfMatchThen(text, "Font.Superscript=", _003C_003Ec__DisplayClass89_.QiySPHPsYsO ?? (_003C_003Ec__DisplayClass89_.QiySPHPsYsO = _003C_003Ec__DisplayClass89_.NiPSPCVT9Nu)) && !AppHelper.IfMatchThen(text, "Font.Subscript=", _003C_003Ec__DisplayClass89_.kTwSP1lNcpR ?? (_003C_003Ec__DisplayClass89_.kTwSP1lNcpR = _003C_003Ec__DisplayClass89_.KZ4SPPZgdka)) && !AppHelper.IfMatchThen(text, "Font.FontStyle=", _003C_003Ec__DisplayClass89_.AJ2SPbQufc0 ?? (_003C_003Ec__DisplayClass89_.AJ2SPbQufc0 = _003C_003Ec__DisplayClass89_.pt3SPEhCyWG)) && !AppHelper.IfMatchThen(text, "Font.Color=", _003C_003Ec__DisplayClass89_.zOBSP6VssK8 ?? (_003C_003Ec__DisplayClass89_.zOBSP6VssK8 = _003C_003Ec__DisplayClass89_.XS3SPyydJQw)) && !AppHelper.IfMatchThen(text, "Font.Underline=", _003C_003Ec__DisplayClass89_.VuTSPXL3kMY ?? (_003C_003Ec__DisplayClass89_.VuTSPXL3kMY = _003C_003Ec__DisplayClass89_.BToSP8bIe68)) && !AppHelper.IfMatchThen(text, "Interior.Color=", _003C_003Ec__DisplayClass89_.QyVSPmmnY8t ?? (_003C_003Ec__DisplayClass89_.QyVSPmmnY8t = _003C_003Ec__DisplayClass89_.qxASPabWvQS)) && !AppHelper.IfMatchThen(text, "Borders.", _003C_003Ec__DisplayClass89_.D5ZSPKmVQID ?? (_003C_003Ec__DisplayClass89_.D5ZSPKmVQID = _003C_003Ec__DisplayClass89_.iIlSP7TKat3)) && !AppHelper.IfMatchThen(text, "ShrinkToFit=", _003C_003Ec__DisplayClass89_.um3SPxg8wtq ?? (_003C_003Ec__DisplayClass89_.um3SPxg8wtq = _003C_003Ec__DisplayClass89_.KHqSPRNh8jT)) && !AppHelper.IfMatchThen(text, "VerticalAlignment=", _003C_003Ec__DisplayClass89_.sgwSPr8gl8F ?? (_003C_003Ec__DisplayClass89_.sgwSPr8gl8F = _003C_003Ec__DisplayClass89_.PAmSPq5r177)))
					{
						int num = 0;
						if (ae8hywQMEDxhVBuA3ISw != null)
						{
							num = num2;
						}
						switch (num)
						{
						case 2:
							break;
						case 1:
							continue;
						default:
							goto IL_03fb;
						}
						goto IL_00e1;
						IL_03fb:
						if (AppHelper.IfMatchThen(text, "HorizontalAlignment=", _003C_003Ec__DisplayClass89_.ymmSPpBo9ct ?? (_003C_003Ec__DisplayClass89_.ymmSPpBo9ct = _003C_003Ec__DisplayClass89_.va6SPcQv2CH)) || AppHelper.IfMatchThen(text, "Orientation=", _003C_003Ec__DisplayClass89_.o3GSPBuSCFp ?? (_003C_003Ec__DisplayClass89_.o3GSPBuSCFp = _003C_003Ec__DisplayClass89_.rPMSPV5f9TQ)) || AppHelper.IfMatchThen(text, "WrapText=", _003C_003Ec__DisplayClass89_.GLJSPQJaes1 ?? (_003C_003Ec__DisplayClass89_.GLJSPQJaes1 = _003C_003Ec__DisplayClass89_.DlnSPZIfKh2)) || text.StartsWith("//"))
						{
							break;
						}
						throw new InvalidDataException("不支持的格式设置：" + text);
					}
					break;
					IL_00e1:;
				}
			}
		}
		finally
		{
			_003C_003Ec__DisplayClass89_.p3ESP9fHw7n.Application.ScreenUpdating = true;
		}
	}

	private void bn1gNlItkli(Range range_0, string string_2)
	{
		string[] array = string_2.Split(new char[1] { '=' }, StringSplitOptions.RemoveEmptyEntries);
		if (array.Length != 2)
		{
			throw new InvalidDataException("边框数据格式不正确。" + string_2);
		}
		(XlLineStyle, XlBorderWeight, int) tuple = zl4gNimQpdf(array[1]);
		if (string.Equals(array[0], "all", StringComparison.OrdinalIgnoreCase))
		{
			range_0.Borders.LineStyle = tuple.Item1;
			range_0.Borders.Weight = tuple.Item2;
			range_0.Borders.Color = tuple.Item3;
			return;
		}
		XlBordersIndex index = (XlBordersIndex)Enum.Parse(typeof(XlBordersIndex), array[0]);
		Border border = ((dynamic)range_0.Borders).Item[index];
		border.LineStyle = tuple.Item1;
		border.Weight = tuple.Item2;
		border.Color = tuple.Item3;
		int num = 0;
		if (ae8hywQMEDxhVBuA3ISw != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
	}

	private static (XlLineStyle lineStyle, XlBorderWeight weight, int oleColor) zl4gNimQpdf(string string_2)
	{
		string[] array = string_2.Split(',');
		if (array.Length != 3)
		{
			throw new InvalidDataException("边框格式不合法，请参考文档。");
		}
		return (lineStyle: (XlLineStyle)Enum.Parse(typeof(XlLineStyle), array[0].Trim()), weight: (XlBorderWeight)Enum.Parse(typeof(XlBorderWeight), array[1].Trim()), oleColor: ColorTranslator.ToOle(ColorTranslator.FromHtml(array[2].Trim())));
	}

	private void qsogN38jWHe(Range range_0, ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0)
	{
		string textParamValue = XActionHelper.GetTextParamValue(_cellSizeParam, actionStep_0, actionExecuteContext_0);
		string[] array = textParamValue.Split(',');
		if (array.Length != 2)
		{
			throw new InvalidDataException("单元格尺寸数据不合法。当前值：" + textParamValue);
		}
		string text = array[0];
		if (string.Equals(text, "auto", StringComparison.OrdinalIgnoreCase))
		{
			range_0.EntireRow.AutoFit();
		}
		else if (string.Equals(text, "std", StringComparison.OrdinalIgnoreCase))
		{
			range_0.EntireRow.UseStandardHeight = true;
		}
		else if (text != "-")
		{
			range_0.RowHeight = Convert.ToDouble(text);
		}
		string text2 = array[1];
		if (string.Equals(text2, "auto", StringComparison.OrdinalIgnoreCase))
		{
			range_0.EntireColumn.AutoFit();
		}
		else if (string.Equals(text2, "std", StringComparison.OrdinalIgnoreCase))
		{
			range_0.EntireColumn.UseStandardWidth = true;
		}
		else if (text2 != "-")
		{
			range_0.ColumnWidth = Convert.ToDouble(text2);
			int num = 0;
			if (ae8hywQMEDxhVBuA3ISw != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
	}

	private void Rf4gNf4DSy2(Range range_0, ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0)
	{
		range_0.EntireColumn.AutoFit();
	}

	private void mejgNz4holc(Range range_0, ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0)
	{
		range_0.EntireRow.AutoFit();
	}

	private void I4lgJwTihx4(Range range_0, ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0)
	{
        int num4 = default;
        int num3 = default;
		_003C_003Ec__DisplayClass95_0 _003C_003Ec__DisplayClass95_ = new _003C_003Ec__DisplayClass95_0();
		_003C_003Ec__DisplayClass95_.avGSPoJOSSR = range_0;
		_003C_003Ec__DisplayClass95_.V1ASPTI2sR3 = this;
		object[,] array = default(object[,]);
		StringBuilder stringBuilder = default(StringBuilder);
		int num = default(int);
		int num2;
		if (XActionHelper.IsOutputParamSetted(bvGgJRbLdgM.Key, actionStep_0))
		{
			if (XActionHelper.GetOutputVariable(bvGgJRbLdgM.Key, actionStep_0, xaction_0).Type == VarType.Text)
			{
				array = ((dynamic)_003C_003Ec__DisplayClass95_.avGSPoJOSSR).Value[Type.Missing] as object[,];
				if (array != null)
				{
					stringBuilder = new StringBuilder();
					if (array != null)
					{
						num = array.GetLowerBound(0);
						goto IL_0391;
					}
					goto IL_03da;
				}
			}
			if (_003C_003Eo__95.l32SP3xDk7n == null)
			{
				_003C_003Eo__95.l32SP3xDk7n = CallSite<Action<CallSite, Type, StepOutParamDef, ActionStep, ActionExecuteContext, object, XAction>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "OutputResult", null, typeof(ExcelRangeOperationStep), new CSharpArgumentInfo[6]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
				}));
				num2 = 0;
				if (!wY4pnJQMGI6ClLXA7SXY())
				{
					goto IL_01f3;
				}
				goto IL_01f7;
			}
			goto IL_0304;
		}
		goto IL_049b;
		IL_04b5:
		XActionHelper.OutputResult(E86gJWR6O7n, actionStep_0, actionExecuteContext_0, _003C_003Ec__DisplayClass95_.avGSPoJOSSR, xaction_0);
		goto IL_04cb;
		IL_0215:
		XActionHelper.OutputResult(xaZgJVim1Qk, actionStep_0, actionExecuteContext_0, (dynamic)_003C_003Ec__DisplayClass95_.avGSPoJOSSR.NumberFormat, xaction_0);
		goto IL_02ed;
		IL_01f7:
		switch (num2)
		{
		case 3:
			break;
		default:
			goto IL_0304;
		case 2:
			goto IL_0346;
		case 4:
			goto IL_03c9;
		case 1:
			goto IL_04b5;
		}
		goto IL_0215;
		IL_0346:
		num3 = default(int);
		if (num3 > array.GetLowerBound(1))
		{
			stringBuilder.Append("\t");
		}
		StringBuilder stringBuilder2 = stringBuilder;
		object obj = array[num, num3];
		object obj2;
		if (obj == null)
		{
			obj2 = null;
		}
		else
		{
			obj2 = obj.ToString();
			if (obj2 != null)
			{
				goto IL_037d;
			}
		}
		obj2 = null;
		goto IL_037d;
		IL_037d:
		stringBuilder2.Append((string)obj2);
		num3++;
		goto IL_03c9;
		IL_02ed:
		if (XActionHelper.IsOutputParamSetted(yMrgJZseB99.Key, actionStep_0))
		{
			XActionHelper.OutputResult(yMrgJZseB99, actionStep_0, actionExecuteContext_0, ((dynamic)_003C_003Ec__DisplayClass95_.avGSPoJOSSR).Address[Type.Missing, Type.Missing, XlReferenceStyle.xlA1, Type.Missing, Type.Missing], xaction_0);
		}
		if (XActionHelper.IsOutputParamSetted(E86gJWR6O7n.Key, actionStep_0))
		{
			num2 = 1;
			if (!wY4pnJQMGI6ClLXA7SXY())
			{
				goto IL_01f3;
			}
			goto IL_01f7;
		}
		goto IL_04cb;
		IL_0391:
		num4 = default(int);
		if (num <= array.GetUpperBound(0))
		{
			if (num > array.GetLowerBound(0))
			{
				stringBuilder.Append("\n");
			}
			num3 = array.GetLowerBound(1);
			num4 = 4;
			goto IL_03c9;
		}
		goto IL_03da;
		IL_03da:
		XActionHelper.OutputResult(bvGgJRbLdgM, actionStep_0, actionExecuteContext_0, stringBuilder.ToString(), xaction_0);
		goto IL_049b;
		IL_049b:
		if (XActionHelper.IsOutputParamSetted(KphgJqSJWQe.Key, actionStep_0))
		{
			XActionHelper.OutputResult(KphgJqSJWQe, actionStep_0, actionExecuteContext_0, (dynamic)_003C_003Ec__DisplayClass95_.avGSPoJOSSR.Text, xaction_0);
		}
		if (XActionHelper.IsOutputParamSetted(F2ogJc9NmmU.Key, actionStep_0))
		{
			XActionHelper.OutputResult(F2ogJc9NmmU, actionStep_0, actionExecuteContext_0, (dynamic)_003C_003Ec__DisplayClass95_.avGSPoJOSSR.Formula, xaction_0);
		}
		if (XActionHelper.IsOutputParamSetted(xaZgJVim1Qk.Key, actionStep_0))
		{
			goto IL_0215;
		}
		goto IL_02ed;
		IL_03c9:
		if (num3 <= array.GetUpperBound(1))
		{
			goto IL_0346;
		}
		num++;
		goto IL_0391;
		IL_01f3:
		num2 = num4;
		goto IL_01f7;
		IL_04cb:
		XActionHelper.OutputResultIfNeeded(cjqgJ9C5FOE, _003C_003Ec__DisplayClass95_.f9ISPj6e27w, actionStep_0, actionExecuteContext_0, xaction_0);
		XActionHelper.OutputResultIfNeeded(r6ngJhUJItX, _003C_003Ec__DisplayClass95_.tHASPnT5FRS, actionStep_0, actionExecuteContext_0, xaction_0);
		XActionHelper.OutputResultIfNeeded(juugJeBBvS2, _003C_003Ec__DisplayClass95_.p0OSP4LDV24, actionStep_0, actionExecuteContext_0, xaction_0);
		XActionHelper.OutputResultIfNeeded(eIJgJYshmtA, _003C_003Ec__DisplayClass95_.D9OSP5Tqge0, actionStep_0, actionExecuteContext_0, xaction_0);
		XActionHelper.OutputResultIfNeeded(nUlgJkaasch, _003C_003Ec__DisplayClass95_.DfCSPD5j4xB, actionStep_0, actionExecuteContext_0, xaction_0);
		XActionHelper.OutputResultIfNeeded(sMagJInItwl, _003C_003Ec__DisplayClass95_.uy4SPdwVPJR, actionStep_0, actionExecuteContext_0, xaction_0);
		return;
		IL_0304:
		_003C_003Eo__95.l32SP3xDk7n.Target(_003C_003Eo__95.l32SP3xDk7n, typeof(global::Quicker.Domain.Actions.X.XActionHelper), bvGgJRbLdgM, actionStep_0, actionExecuteContext_0, ((dynamic)_003C_003Ec__DisplayClass95_.avGSPoJOSSR).Value[Type.Missing], xaction_0);
		goto IL_049b;
	}

	private string GetEnumName<T>(dynamic value)
	{
		if (value == null)
		{
			return string.Empty;
		}
		try
		{
			return Enum.GetName(typeof(T), value);
		}
		catch (Exception)
		{
			return value.ToString();
		}
	}

	private string OleColorToRgb(dynamic oleColor)
	{
		if (!(oleColor is double num))
		{
			return oleColor.ToString();
		}
		return ColorTranslator.ToHtml(ColorTranslator.FromOle((int)num));
	}

	private string GetOrientationString(dynamic orientation)
	{
		if (_003C_003Eo__98.VSVSEYXnxWx == null)
		{
			_003C_003Eo__98.VSVSEYXnxWx = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(global::Quicker.Domain.Actions.X.BuiltinRunners.Office.ExcelRangeOperationStep), new CSharpArgumentInfo[1] { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null) }));
		}
		if (!_003C_003Eo__98.VSVSEYXnxWx.Target(_003C_003Eo__98.VSVSEYXnxWx, (object)(orientation < -90)))
		{
			return orientation.ToString();
		}
		return Enum.GetName(typeof(global::Microsoft.Office.Interop.Excel.XlOrientation), orientation);
	}

	private string GetBoolValue(dynamic value)
	{
		if (value is bool)
		{
			if (value == true)
			{
				return "1";
			}
			return "0";
		}
		return value.ToString();
	}

	private void iDTgJtBWTV6(Range range_0, ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0)
	{
		string textParamValue = XActionHelper.GetTextParamValue(_valueParam, actionStep_0, actionExecuteContext_0);
		range_0.NumberFormat = textParamValue;
	}

	private void rWZgJgcECye(Range range_0, ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0)
	{
		string textParamValue = XActionHelper.GetTextParamValue(_valueParam, actionStep_0, actionExecuteContext_0);
		range_0.Formula = textParamValue;
	}

	private void fU5gJLOVgbE(Range range_0, ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0)
	{
		object paramValue = XActionHelper.GetParamValue(_valueParam, actionStep_0, actionExecuteContext_0);
		if (paramValue is IList<string> source)
		{
			((dynamic)range_0).Value[Type.Missing] = (object)source.ToArray();
		}
		else
		{
			((dynamic)range_0).Value[Type.Missing] = paramValue;
		}
	}

	private Range JN0gJvVh0uq(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0)
	{
		_003C_003Ec__DisplayClass103_0 _003C_003Ec__DisplayClass103_ = new _003C_003Ec__DisplayClass103_0();
		object paramValue = XActionHelper.GetParamValue(_rangeParam, actionStep_0, actionExecuteContext_0);
		_003C_003Ec__DisplayClass103_.NqZS006fUDl = XActionHelper.GetTextParamValue(_subRangeParam, actionStep_0, actionExecuteContext_0);
		_003C_003Ec__DisplayClass103_.gITS0ChjZtK = null;
		if (paramValue == null)
		{
			return ExcelHelper.GetActiveRange();
		}
		int num;
		if (paramValue is Range)
		{
			_003C_003Ec__DisplayClass103_.gITS0ChjZtK = paramValue as Range;
		}
		else if (paramValue is string text)
		{
			if (string.IsNullOrEmpty(text))
			{
				_003C_003Ec__DisplayClass103_.gITS0ChjZtK = ExcelHelper.GetActiveRange();
			}
			else
			{
				Worksheet activeSheet = ExcelHelper.GetActiveSheet();
				if (!text.Equals("used", StringComparison.InvariantCultureIgnoreCase))
				{
					_003C_003Ec__DisplayClass103_.gITS0ChjZtK = ((dynamic)activeSheet).Range[(object)text, Type.Missing];
					num = 4;
					if (!wY4pnJQMGI6ClLXA7SXY())
					{
						int num2 = default(int);
						num = num2;
					}
					goto IL_01bd;
				}
				_003C_003Ec__DisplayClass103_.gITS0ChjZtK = activeSheet.UsedRange;
			}
		}
		goto IL_01e3;
		IL_04f4:
		if (_003C_003Ec__DisplayClass103_.qINS0PBU0Di == null)
		{
			throw new InvalidDataException("未找到子范围：" + _003C_003Ec__DisplayClass103_.NqZS006fUDl);
		}
		return _003C_003Ec__DisplayClass103_.qINS0PBU0Di;
		IL_01bd:
		char c = default(char);
		string text2 = default(string);
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			case 4:
				goto end_IL_01bd;
			case 1:
				goto IL_0372;
			case 5:
				goto IL_0413;
			case 6:
				goto IL_0427;
			default:
				goto IL_0473;
			case 3:
				goto IL_049b;
			}
			if (c != 'L')
			{
				num = 0;
				if (!wY4pnJQMGI6ClLXA7SXY())
				{
					continue;
				}
			}
			else if (text2 == "LastColumn")
			{
				return (dynamic)_003C_003Ec__DisplayClass103_.gITS0ChjZtK.Columns[_003C_003Ec__DisplayClass103_.gITS0ChjZtK.Columns.Count, Type.Missing];
			}
			goto IL_0473;
			continue;
			end_IL_01bd:
			break;
		}
		goto IL_01e3;
		IL_049b:
		if (!AppHelper.IfMatchThen(_003C_003Ec__DisplayClass103_.NqZS006fUDl, "column:", _003C_003Ec__DisplayClass103_.cQPS0NVs2Yt) && !AppHelper.IfMatchThen(_003C_003Ec__DisplayClass103_.NqZS006fUDl, "row:", _003C_003Ec__DisplayClass103_.wJtS0JyFnJp))
		{
			return ((dynamic)_003C_003Ec__DisplayClass103_.gITS0ChjZtK).Range[(object)_003C_003Ec__DisplayClass103_.NqZS006fUDl, Type.Missing];
		}
		goto IL_04f4;
		IL_0383:
		return _003C_003Ec__DisplayClass103_.gITS0ChjZtK.Rows;
		IL_0473:
		_003C_003Ec__DisplayClass103_.qINS0PBU0Di = null;
		if (!AppHelper.IfMatchThen(_003C_003Ec__DisplayClass103_.NqZS006fUDl, "cell:", _003C_003Ec__DisplayClass103_.q0OS0uxq0c6))
		{
			goto IL_049b;
		}
		goto IL_04f4;
		IL_0372:
		if (text2 == "Rows")
		{
			goto IL_0383;
		}
		goto IL_0473;
		IL_0413:
		if (text2 == "ActiveCell")
		{
			goto IL_0421;
		}
		goto IL_0473;
		IL_0427:
		return _003C_003Eo__103.HAPSPMZfl12.Target(_003C_003Eo__103.HAPSPMZfl12, _003C_003Ec__DisplayClass103_.gITS0ChjZtK.Columns[1, Type.Missing]);
		IL_0421:
		return ExcelHelper.GetActiveCell();
		IL_01e3:
		while (true)
		{
			if (_003C_003Ec__DisplayClass103_.gITS0ChjZtK != null)
			{
				text2 = _003C_003Ec__DisplayClass103_.NqZS006fUDl;
				switch (text2)
				{
				case "FirstColumn":
					break;
				case "LastRow":
					return (dynamic)_003C_003Ec__DisplayClass103_.gITS0ChjZtK.Rows[_003C_003Ec__DisplayClass103_.gITS0ChjZtK.Rows.Count, Type.Missing];
				case "Columns":
					return _003C_003Ec__DisplayClass103_.gITS0ChjZtK.Columns;
				case "FullArea":
				case "":
					return _003C_003Ec__DisplayClass103_.gITS0ChjZtK;
				case "FirstRow":
					return (dynamic)_003C_003Ec__DisplayClass103_.gITS0ChjZtK.Rows[1, Type.Missing];
				case "EntireRow":
					return _003C_003Ec__DisplayClass103_.gITS0ChjZtK.EntireRow;
				case "Rows":
					goto end_IL_01e3;
				case "ActiveCell":
					goto IL_0421;
				case "EntireColumn":
					return _003C_003Ec__DisplayClass103_.gITS0ChjZtK.EntireColumn;
				default:
					goto IL_0473;
				}
				if (_003C_003Eo__103.HAPSPMZfl12 == null)
				{
					_003C_003Eo__103.HAPSPMZfl12 = CallSite<Func<CallSite, object, Range>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(global::Microsoft.Office.Interop.Excel.Range), typeof(ExcelRangeOperationStep)));
					num = 6;
					if (ae8hywQMEDxhVBuA3ISw != null)
					{
						continue;
					}
					goto IL_01bd;
				}
				goto IL_0427;
			}
			throw new InvalidOperationException("未找到区域！");
			continue;
			end_IL_01e3:
			break;
		}
		goto IL_0383;
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDirectValue(_operationParam, step) ?? "";
	}

	static ExcelRangeOperationStep()
	{
		_rangeParam = new StepInParamDef
		{
			Key = "range",
			Name = "区域",
			Description = "可以输入区域变量、留空(表示当前选择区域）、used(表示当前工作表的使用区域)或区域范围如A1:E9等，请参考文档。",
			DefaultValue = "",
			IsMultiLine = false,
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Object
		};
		_subRangeParam = new StepInParamDef
		{
			Key = "subRange",
			Name = "限定子范围",
			Description = "根据需要，将要操作的目标限定为一个子区域",
			IsRequired = true,
			Type = VarType.Enum,
			DefaultValue = "FullArea",
			VariableMode = ParamVariableMode.UseVarOrInput,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("FullArea", "整个区域"),
				new SelectionItem("FirstRow", "区域内的第一行"),
				new SelectionItem("FirstColumn", "区域内的第一列"),
				new SelectionItem("LastRow", "区域内最后一行"),
				new SelectionItem("LastColumn", "区域内最后一列"),
				new SelectionItem("ActiveCell", "活动单元格"),
				new SelectionItem("EntireRow", "整行(包含区域外)"),
				new SelectionItem("EntireColumn", "整列(包含区域外)"),
				new SelectionItem("Rows", "所有行(区域范围内)"),
				new SelectionItem("Columns", "所有列(区域范围内)")
			},
			IsControlField = false
		};
		_operationParam = new StepInParamDef
		{
			Key = "operation",
			Name = "操作类型",
			Description = "操作类型",
			IsRequired = true,
			Type = VarType.Enum,
			DefaultValue = "SetValue",
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("SetValue", "设置值"),
				new SelectionItem("SetFormula", "设置公式"),
				new SelectionItem("SetNumberFormat", "设置数值格式"),
				new SelectionItem("SetCellSize", "行高,列宽"),
				new SelectionItem("SetStyle", "设置格式"),
				new SelectionItem("CallMethod", "调用方法"),
				new SelectionItem("Replace", "替换内容"),
				new SelectionItem("GetRangeInfo", "获取区域信息")
			},
			IsControlField = true
		};
		_valueParam = new StepInParamDef
		{
			Key = "value",
			Name = "参数",
			Description = "要设置的内容",
			DefaultValue = "",
			IsMultiLine = false,
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Any,
			ValidForList = new string[3] { "SetValue", "SetFormula", "SetNumberFormat" }
		};
		_cellSizeParam = new StepInParamDef
		{
			Key = "cellSize",
			Name = "行高,列宽",
			Description = "-表示不改变，auto表示自动，数字表示具体值。如auto,auto表示自适应高度和宽度",
			DefaultValue = "",
			IsMultiLine = false,
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Any,
			ValidForList = new string[1] { "SetCellSize" }
		};
		_styleParam = new StepInParamDef
		{
			Key = "style",
			Name = "格式",
			Description = "要设置的格式内容。每行一个格式设置，请参考模块文档了解详细参数设置。",
			DefaultValue = "",
			IsMultiLine = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text,
			ValidForList = new string[1] { "SetStyle" }
		};
		_methodsParam = new StepInParamDef
		{
			Key = "methods",
			Name = "方法",
			Description = "要调用的方法，每行一个。格式请参考文档。",
			DefaultValue = "",
			IsMultiLine = true,
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text,
			ValidForList = new string[1] { "CallMethod" }
		};
		SOggJ0pqCnC = new StepInParamDef
		{
			Key = "replaceWhat",
			Name = "查找内容",
			Description = "要替换的内容",
			DefaultValue = "",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true,
			ValidForList = new List<string> { "Replace" }
		};
		tpDgJCl8psO = new StepInParamDef
		{
			Key = "replaceTo",
			Name = "替换为",
			Description = "替换成的内容",
			DefaultValue = "",
			IsRequired = true,
			Type = VarType.Text,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsMultiLine = true,
			ValidForList = new List<string> { "Replace" }
		};
		raLgJPgUlKT = new StepInParamDef
		{
			Key = "replaceEscapeWhat",
			Name = "转义“查找内容”",
			Description = "替换“查找内容”中的转义字符（\\r,\\n,\\t）",
			DefaultValue = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "Replace" }
		};
		lxwgJEkb90f = new StepInParamDef
		{
			Key = "replaceEscapeTo",
			Name = "转义“替换为”",
			Description = "替换“替换为”中的转义字符（\\r,\\n,\\t）",
			DefaultValue = true,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "Replace" }
		};
		ByBgJyAFtOY = new StepInParamDef
		{
			Key = "replaceMatchCase",
			Name = "区分大小写",
			DefaultValue = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new List<string> { "Replace" }
		};
		sSOgJ89MYga = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		ONAgJ73WxQq = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		bvGgJRbLdgM = new StepOutParamDef
		{
			Key = "value",
			Name = "值",
			Description = "单元格的值",
			Type = VarType.Any,
			ValidForList = new List<string> { "GetRangeInfo" }
		};
		KphgJqSJWQe = new StepOutParamDef
		{
			Key = "text",
			Name = "文本",
			Description = "单元格的显示文本",
			Type = VarType.Text,
			ValidForList = new List<string> { "GetRangeInfo" }
		};
		F2ogJc9NmmU = new StepOutParamDef
		{
			Key = "formula",
			Name = "公式",
			Description = "单元格的公式值",
			Type = VarType.Text,
			ValidForList = new List<string> { "GetRangeInfo" }
		};
		xaZgJVim1Qk = new StepOutParamDef
		{
			Key = "numberFormat",
			Name = "数值格式",
			Description = "单元格数值格式值",
			Type = VarType.Text,
			ValidForList = new List<string> { "GetRangeInfo" }
		};
		yMrgJZseB99 = new StepOutParamDef
		{
			Key = "address",
			Name = "位置引用",
			Description = "区域位置范围",
			Type = VarType.Text,
			ValidForList = new List<string> { "GetRangeInfo" }
		};
		cjqgJ9C5FOE = new StepOutParamDef
		{
			Key = "column",
			Name = "列号",
			Description = "左上角单元格从1开始的列数",
			Type = VarType.Integer,
			ValidForList = new List<string> { "GetRangeInfo" }
		};
		r6ngJhUJItX = new StepOutParamDef
		{
			Key = "row",
			Name = "行号",
			Description = "左上角单元格从1开始的行数",
			Type = VarType.Integer,
			ValidForList = new List<string> { "GetRangeInfo" }
		};
		juugJeBBvS2 = new StepOutParamDef
		{
			Key = "colNum",
			Name = "列数",
			Description = "区域包含的列数",
			Type = VarType.Integer,
			ValidForList = new List<string> { "GetRangeInfo" }
		};
		eIJgJYshmtA = new StepOutParamDef
		{
			Key = "rowNum",
			Name = "行数",
			Description = "区域包含的行数",
			Type = VarType.Integer,
			ValidForList = new List<string> { "GetRangeInfo" }
		};
		sMagJInItwl = new StepOutParamDef
		{
			Key = "style",
			Name = "格式信息",
			Description = "单元格的格式",
			Type = VarType.Text,
			ValidForList = new List<string> { "GetRangeInfo" }
		};
		E86gJWR6O7n = new StepOutParamDef
		{
			Key = "range",
			Name = "区域对象",
			Description = "Range对象",
			Type = VarType.Object,
			ValidForList = new List<string> { "GetRangeInfo" }
		};
		nUlgJkaasch = new StepOutParamDef
		{
			Key = "sheet",
			Name = "工作表对象",
			Description = "WorkSheet对象",
			Type = VarType.Object,
			ValidForList = new List<string> { "GetRangeInfo" }
		};
	}

	internal static bool wY4pnJQMGI6ClLXA7SXY()
	{
		return ae8hywQMEDxhVBuA3ISw == null;
	}

	internal static void kaJqx1QMLGShGS1r6Vou()
	{
	}
}
