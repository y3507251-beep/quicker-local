using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using DynamicExpresso;
using log4net;
using NCalc;
using Newtonsoft.Json;
using qcrGlGMkgcYtX0leyxF;
using Quicker.Common;
using Quicker.Domain.Actions.Debugging;
using Quicker.Domain.Actions.Runner;
using Quicker.Domain.Actions.X.BuiltinRunners.Images;
using Quicker.Domain.Actions.X.BuiltinRunners.Misc;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Actions.X.Variables;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;
using Quicker.Utilities.Images;
using Quicker.Utilities.Win32;
using Z.Expressions;
using Z.Expressions.Compiler.Shared;

namespace Quicker.Domain.Actions.X;

public static class XActionHelper
{
	[CompilerGenerated]
	private static class _003C_003EO
	{
		public static EvaluateFunctionHandler xVhvF8SucAW;
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass12_0
	{
		public EvalContext MOvvFRtGgr9;

		public IDictionary<string, object> WU9vFqVy6da;

		public string wtQvFcR5Og6;

		internal static _003C_003Ec__DisplayClass12_0 f4hFL0W2cPaZVQ1YlKSM;

		internal string StsvFaI6bpD(Match match)
		{
			_003C_003Ec__DisplayClass12_1 _003C_003Ec__DisplayClass12_1_ = default(_003C_003Ec__DisplayClass12_1);
			_003C_003Ec__DisplayClass12_1_.sOIvFVjyay0 = match.Value;
			string value = match.Groups[1].Value;
			int num2;
			string key2;
			int num3;
			if (!value.StartsWith(" ") && !value.EndsWith(" "))
			{
				if (WU9vFqVy6da.ContainsKey(value))
				{
					return CGstDIfH7gH(WU9vFqVy6da[value]);
				}
				if (value == "[cliptext]")
				{
					if (wtQvFcR5Og6 != null)
					{
						return wtQvFcR5Og6;
					}
					wtQvFcR5Og6 = ClipboardHelper.TryGetClipboardText(TextDataFormat.UnicodeText);
					return wtQvFcR5Og6;
				}
				if (value.EndsWith("="))
				{
					return VHHvF7pnRdt(value.Substring(0, value.Length - 1), ref _003C_003Ec__DisplayClass12_1_);
				}
				int num = value.IndexOf('[');
				if (num > 0)
				{
					string key = value.Substring(0, num);
					if (WU9vFqVy6da.ContainsKey(key))
					{
						goto IL_0206;
					}
				}
				num2 = value.IndexOf('.');
				if (num2 > 0)
				{
					key2 = value.Substring(0, num2);
					num3 = 1;
					if (f4hFL0W2cPaZVQ1YlKSM != null)
					{
						goto IL_0195;
					}
					goto IL_0199;
				}
				goto IL_0211;
			}
			return _003C_003Ec__DisplayClass12_1_.sOIvFVjyay0;
			IL_0211:
			return _003C_003Ec__DisplayClass12_1_.sOIvFVjyay0;
			IL_0199:
			string text = default(string);
			IList<string> list;
			IDictionary<string, object> dictionary = default(IDictionary<string, object>);
			while (true)
			{
				switch (num3)
				{
				case 1:
					break;
				default:
					goto IL_01aa;
				case 2:
					goto end_IL_0199;
				}
				text = value.Substring(num2 + 1);
				if (WU9vFqVy6da.ContainsKey(key2))
				{
					if (value.EndsWith(")") || value.EndsWith("]"))
					{
						return VHHvF7pnRdt(value, ref _003C_003Ec__DisplayClass12_1_);
					}
					object obj = WU9vFqVy6da[key2];
					list = obj as IList<string>;
					if (list != null)
					{
						goto IL_01c4;
					}
					dictionary = obj as IDictionary<string, object>;
					if (dictionary != null)
					{
						num3 = 0;
						if (f4hFL0W2cPaZVQ1YlKSM == null)
						{
							continue;
						}
						goto IL_0195;
					}
				}
				goto IL_0211;
				IL_01aa:
				if (dictionary.ContainsKey(text))
				{
					return dictionary[text].ToString();
				}
				goto IL_0211;
				continue;
				end_IL_0199:
				break;
			}
			goto IL_0206;
			IL_01c4:
			if (int.TryParse(text, out var result))
			{
				if (result >= list.Count)
				{
					throw new InvalidDataException("序号超过了列表长度：" + _003C_003Ec__DisplayClass12_1_.sOIvFVjyay0);
				}
				return list[result];
			}
			goto IL_0211;
			IL_0195:
			int num4 = default(int);
			num3 = num4;
			goto IL_0199;
			IL_0206:
			return VHHvF7pnRdt(value, ref _003C_003Ec__DisplayClass12_1_);
		}

		internal string VHHvF7pnRdt(string expression, ref _003C_003Ec__DisplayClass12_1 _003C_003Ec__DisplayClass12_1_0)
		{
			try
			{
				return MOvvFRtGgr9.Execute(expression, WU9vFqVy6da).ToString();
			}
			catch (Exception)
			{
				return _003C_003Ec__DisplayClass12_1_0.sOIvFVjyay0;
			}
		}

		internal static bool LisrdnW2WekbpJ0lwsqk()
		{
			return f4hFL0W2cPaZVQ1YlKSM == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	internal struct _003C_003Ec__DisplayClass12_1
	{
		public string sOIvFVjyay0;
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass26_0
	{
		public ActionStepParam u9xvF9XtKyS;

		private static _003C_003Ec__DisplayClass26_0 RHa1oYW2jjZ1kh6JBlHL;

		internal bool ncxvFZaGhwq(SelectionItem x)
		{
			return x.Value == u9xvF9XtKyS.Value;
		}

		internal static bool Q4PprDW2DcqMRIXfZEbH()
		{
			return RHa1oYW2jjZ1kh6JBlHL == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass28_0
	{
		public string jYOvFegh5hC;

		internal static _003C_003Ec__DisplayClass28_0 O2lhjMW2ESgaHrt7qxlu;

		internal bool QBUvFh24Z6N(ActionVariable x)
		{
			return x.Key == jYOvFegh5hC;
		}

		internal static bool zkDA19W2G5uaEuCuRAsf()
		{
			return O2lhjMW2ESgaHrt7qxlu == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass29_0
	{
		public ActionStepParam yaCvFIdK5Wg;

		internal static _003C_003Ec__DisplayClass29_0 LW88ByW219SXY1LILdY4;

		internal bool dvkvFYmbHIs(SelectionItem x)
		{
			return x.Value == yaCvFIdK5Wg.Value;
		}

		static _003C_003Ec__DisplayClass29_0()
		{
		}

		internal static bool EYyVKpW2K1PvVUZqLCB5()
		{
			return LW88ByW219SXY1LILdY4 == null;
		}

		internal static void SLX66rW2dtPSaF22xAT1()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass2_0
	{
		public ActionStep yZcvFk6fvB6;

		public StepInParamDef Uy4vFGBpnkU;

		public ActionExecuteContext r16vFsa2ewe;

		public string IZlvFHtIbpG;

		public bool ToNvF1pxeee;

		private static _003C_003Ec__DisplayClass2_0 o6j5McW2OSiBYr0jgwBR;

		internal object lI0vFW6fJe2()
		{
        object valueFromExpression = default;
        _003C_003Ec__DisplayClass2_3 _003C_003Ec__DisplayClass2_3 = default;
			if (!yZcvFk6fvB6.InputParams.ContainsKey(Uy4vFGBpnkU.Key) && (string.IsNullOrEmpty(Uy4vFGBpnkU.FromOldField) || !yZcvFk6fvB6.InputParams.ContainsKey(Uy4vFGBpnkU.FromOldField)))
			{
				return Uy4vFGBpnkU.DefaultValue;
			}
			_003C_003Ec__DisplayClass2_1 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_1
			{
				KluvFXWiEn0 = this,
				hVVvF6ySRVh = (yZcvFk6fvB6.InputParams.ContainsKey(Uy4vFGBpnkU.Key) ? yZcvFk6fvB6.InputParams[Uy4vFGBpnkU.Key] : yZcvFk6fvB6.InputParams[Uy4vFGBpnkU.FromOldField])
			};
			if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass2_.hVVvF6ySRVh.VarKey))
			{
				_003C_003Ec__DisplayClass2_2 _003C_003Ec__DisplayClass2_2 = new _003C_003Ec__DisplayClass2_2
				{
					AoZvFry8H7f = _003C_003Ec__DisplayClass2_
				};
				if (string.Equals("[cliptext]", _003C_003Ec__DisplayClass2_2.AoZvFry8H7f.hVVvF6ySRVh.VarKey, StringComparison.OrdinalIgnoreCase))
				{
					return ClipboardHelper.TryGetClipboardText(TextDataFormat.UnicodeText);
				}
				if (!r16vFsa2ewe.IsVarExists(_003C_003Ec__DisplayClass2_2.AoZvFry8H7f.hVVvF6ySRVh.VarKey))
				{
					throw new InvalidDataException("变量未定义：" + _003C_003Ec__DisplayClass2_2.AoZvFry8H7f.hVVvF6ySRVh.VarKey);
				}
				_003C_003Ec__DisplayClass2_2.KPkvFKv9uZq = (string)r16vFsa2ewe.GetVarValue(_003C_003Ec__DisplayClass2_2.AoZvFry8H7f.hVVvF6ySRVh.VarKey);
				if (!Uy4vFGBpnkU.SkipEval)
				{
					int num2 = default(int);
					while (true)
					{
						_003C_003Ec__DisplayClass2_2.DGqvFxghHKT = _003C_003Ec__DisplayClass2_2.KPkvFKv9uZq as string;
						if (_003C_003Ec__DisplayClass2_2.DGqvFxghHKT == null)
						{
							break;
						}
						ActionItem action = r16vFsa2ewe.Action;
						if (action == null || !action.EnableEvaluateVariable)
						{
							break;
						}
						int num;
						if (_003C_003Ec__DisplayClass2_2.DGqvFxghHKT.StartsWith("$$"))
						{
							num = 4;
							if (!G6nxVdW2J2Zv4Or6kdNC())
							{
								goto IL_0204;
							}
						}
						else
						{
							if (!_003C_003Ec__DisplayClass2_2.DGqvFxghHKT.StartsWith("$="))
							{
								break;
							}
							IZlvFHtIbpG = _003C_003Ec__DisplayClass2_2.DGqvFxghHKT;
							if (!fH0tD9flSpf(_003C_003Ec__DisplayClass2_2.DGqvFxghHKT))
							{
								_003C_003Ec__DisplayClass2_2.KPkvFKv9uZq = (string)GetValueFromExpression2(_003C_003Ec__DisplayClass2_2.DGqvFxghHKT.Substring(2), r16vFsa2ewe);
								break;
							}
							num = 1;
							if (!G6nxVdW2J2Zv4Or6kdNC())
							{
								goto IL_0204;
							}
						}
						goto IL_0208;
						IL_0208:
						switch (num)
						{
						case 3:
							break;
						case 1:
							goto IL_0247;
						case 4:
							goto IL_0261;
						case 2:
							goto IL_042d;
						default:
							goto IL_049b;
						}
						continue;
						IL_0261:
						IZlvFHtIbpG = _003C_003Ec__DisplayClass2_2.DGqvFxghHKT;
						_003C_003Ec__DisplayClass2_2.KPkvFKv9uZq = InterpolateStr(r16vFsa2ewe, _003C_003Ec__DisplayClass2_2.DGqvFxghHKT);
						break;
						IL_0247:
						GaZT3MMHZ3eZxDOySux.x1VLMFjodna(_003C_003Ec__DisplayClass2_2.ryTvFmIR5rD, true, "clipboardAccessInExpression");
						break;
						IL_0204:
						num = num2;
						goto IL_0208;
					}
				}
				ActionVariable actionVariable = r16vFsa2ewe.XProgram.Variables.FirstOrDefault(_003C_003Ec__DisplayClass2_2.AoZvFry8H7f.ktQvFbvDIOD);
				if (!ToNvF1pxeee && (actionVariable == null || actionVariable.Type != VarType.Any))
				{
					return VariableHelper.ConvertToType(Uy4vFGBpnkU.Type, _003C_003Ec__DisplayClass2_2.KPkvFKv9uZq);
				}
				return _003C_003Ec__DisplayClass2_2.KPkvFKv9uZq;
			}
			_003C_003Ec__DisplayClass2_3 = new _003C_003Ec__DisplayClass2_3();
			_003C_003Ec__DisplayClass2_3.B5CvFjUuMIk = _003C_003Ec__DisplayClass2_;
			_003C_003Ec__DisplayClass2_3.W7tvFBftIx8 = _003C_003Ec__DisplayClass2_3.B5CvFjUuMIk.hVVvF6ySRVh.Value;
			if (Uy4vFGBpnkU.SkipEval)
			{
				return _003C_003Ec__DisplayClass2_3.W7tvFBftIx8;
			}
			IZlvFHtIbpG = _003C_003Ec__DisplayClass2_3.W7tvFBftIx8;
			valueFromExpression = default(object);
			if (_003C_003Ec__DisplayClass2_3.W7tvFBftIx8 != null)
			{
				if (_003C_003Ec__DisplayClass2_3.W7tvFBftIx8.StartsWith("$$", StringComparison.OrdinalIgnoreCase))
				{
					_003C_003Ec__DisplayClass2_3.W7tvFBftIx8 = InterpolateStr(r16vFsa2ewe, _003C_003Ec__DisplayClass2_3.W7tvFBftIx8);
					IZlvFHtIbpG = _003C_003Ec__DisplayClass2_3.W7tvFBftIx8;
					if (_003C_003Ec__DisplayClass2_3.W7tvFBftIx8.StartsWith("$$", StringComparison.OrdinalIgnoreCase))
					{
						_003C_003Ec__DisplayClass2_3.W7tvFBftIx8 = InterpolateStr(r16vFsa2ewe, _003C_003Ec__DisplayClass2_3.W7tvFBftIx8);
						IZlvFHtIbpG = IZlvFHtIbpG + "\n" + _003C_003Ec__DisplayClass2_3.W7tvFBftIx8;
						return VariableHelper.ConvertToType(Uy4vFGBpnkU.Type, _003C_003Ec__DisplayClass2_3.W7tvFBftIx8);
					}
					if (_003C_003Ec__DisplayClass2_3.W7tvFBftIx8.StartsWith("$=", StringComparison.OrdinalIgnoreCase))
					{
						valueFromExpression = GetValueFromExpression2(_003C_003Ec__DisplayClass2_3.W7tvFBftIx8.Substring(2), r16vFsa2ewe);
						goto IL_042d;
					}
					return VariableHelper.ConvertToType(Uy4vFGBpnkU.Type, _003C_003Ec__DisplayClass2_3.W7tvFBftIx8);
				}
				if (_003C_003Ec__DisplayClass2_3.W7tvFBftIx8.StartsWith("$="))
				{
					_003C_003Ec__DisplayClass2_3.hiVvFQV3O7X = null;
					if (!fH0tD9flSpf(_003C_003Ec__DisplayClass2_3.W7tvFBftIx8))
					{
						goto IL_049b;
					}
					GaZT3MMHZ3eZxDOySux.x1VLMFjodna(_003C_003Ec__DisplayClass2_3.No7vFpkNWFZ, true, "clipboardAccessInExpression");
					goto IL_04ba;
				}
				if (ToNvF1pxeee)
				{
					return _003C_003Ec__DisplayClass2_3.W7tvFBftIx8;
				}
				return VariableHelper.ConvertToType(Uy4vFGBpnkU.Type, _003C_003Ec__DisplayClass2_3.W7tvFBftIx8);
			}
			return VariableHelper.ConvertToType(Uy4vFGBpnkU.Type, null);
			IL_04ba:
			if (ToNvF1pxeee)
			{
				return _003C_003Ec__DisplayClass2_3.hiVvFQV3O7X;
			}
			return VariableHelper.ConvertToType(Uy4vFGBpnkU.Type, _003C_003Ec__DisplayClass2_3.hiVvFQV3O7X);
			IL_049b:
			_003C_003Ec__DisplayClass2_3.hiVvFQV3O7X = GetValueFromExpression2(_003C_003Ec__DisplayClass2_3.W7tvFBftIx8.Substring(2), r16vFsa2ewe);
			goto IL_04ba;
			IL_042d:
			return VariableHelper.ConvertToType(Uy4vFGBpnkU.Type, valueFromExpression);
		}

		internal static bool G6nxVdW2J2Zv4Or6kdNC()
		{
			return o6j5McW2OSiBYr0jgwBR == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass2_1
	{
		public ActionStepParam hVVvF6ySRVh;

		public _003C_003Ec__DisplayClass2_0 KluvFXWiEn0;

		private static _003C_003Ec__DisplayClass2_1 REjvDwW2ueXG8YFqmyHQ;

		internal bool ktQvFbvDIOD(ActionVariable x)
		{
			return x.Key == hVVvF6ySRVh.VarKey;
		}

		internal static bool tCeA7TW2oVDstnVLA0JA()
		{
			return REjvDwW2ueXG8YFqmyHQ == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass2_2
	{
		public string KPkvFKv9uZq;

		public string DGqvFxghHKT;

		public _003C_003Ec__DisplayClass2_1 AoZvFry8H7f;

		private static _003C_003Ec__DisplayClass2_2 SxAbkSW2bZ6MQjvSDomy;

		internal void ryTvFmIR5rD()
		{
			KPkvFKv9uZq = (string)GetValueFromExpression2(DGqvFxghHKT.Substring(2), AoZvFry8H7f.KluvFXWiEn0.r16vFsa2ewe);
			Thread.Sleep(20);
		}

		internal static bool bdICgEW2qTLEwyUXVbjA()
		{
			return SxAbkSW2bZ6MQjvSDomy == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass2_3
	{
		public string W7tvFBftIx8;

		public object hiVvFQV3O7X;

		public _003C_003Ec__DisplayClass2_1 B5CvFjUuMIk;

		private static _003C_003Ec__DisplayClass2_3 I3cjQoW2lfetunABaxrK;

		internal void No7vFpkNWFZ()
		{
			hiVvFQV3O7X = GetValueFromExpression2(W7tvFBftIx8.Substring(2), B5CvFjUuMIk.KluvFXWiEn0.r16vFsa2ewe);
			Thread.Sleep(20);
		}

		internal static bool u9rVFaW2ZSsEjEbFuwvt()
		{
			return I3cjQoW2lfetunABaxrK == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass30_0
	{
		public string p2IvF44u2pH;

		private static _003C_003Ec__DisplayClass30_0 cjmpaWW28SKOvqsAr0bL;

		internal bool YqMvFnmpwyD(ActionVariable v)
		{
			if (!(v.Key == p2IvF44u2pH))
			{
				if (v.Type == VarType.Dict)
				{
					return p2IvF44u2pH.StartsWith(v.Key + ".");
				}
				return false;
			}
			return true;
		}

		internal static bool Ju8Y7GW2R1NdWl9Ygq1h()
		{
			return cjmpaWW28SKOvqsAr0bL == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass33_0
	{
		public string iTfvFD7skFr;

		private static _003C_003Ec__DisplayClass33_0 Mpsge7W2PVmE2p5lh1TL;

		internal bool sUevF59KJLU(ActionVariable v)
		{
			return v.Key == iTfvFD7skFr;
		}

		internal static bool VfALtEW2MeqSJoiXS2EA()
		{
			return Mpsge7W2PVmE2p5lh1TL == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	internal struct _003C_003Ec__DisplayClass38_0
	{
		public IList<IStepRunner> qcmvFddUwb5;
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass40_0
	{
		public ActionStep UUbvFMCPj4j;

		public string MiOvFAjZcZe;

		private static _003C_003Ec__DisplayClass40_0 ohoyH0W2t41Y3hwPidyo;

		internal bool GbVvFoX4x1e(KeyValuePair<string, ActionStepParam> p)
		{
			return MiOvFAjZcZe.ContainedInAny(p.Value?.Value, p.Value?.VarKey);
		}

		internal bool oXkvFTEFeD7(KeyValuePair<string, string> p)
		{
			return MiOvFAjZcZe.ContainedInAny(p.Value);
		}

		internal static bool ePUYS5W2S6KrbvSEBZqo()
		{
			return ohoyH0W2t41Y3hwPidyo == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass40_1
	{
		public string atSvFFS6WYN;

		public _003C_003Ec__DisplayClass40_0 dXdvFUEJSP7;

		private static _003C_003Ec__DisplayClass40_1 dr58c4W2TAAkUdc18u8h;

		internal bool MuSvFOIENvg(KeyValuePair<string, string> p)
		{
			if (!string.Equals(p.Value, atSvFFS6WYN, StringComparison.OrdinalIgnoreCase))
			{
				return p.Value?.StartsWith(atSvFFS6WYN + ".", StringComparison.OrdinalIgnoreCase) == true;
			}
			return true;
		}

		internal static bool i4KwSBW2mIpPWMxVw5WO()
		{
			return dr58c4W2TAAkUdc18u8h == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass40_2
	{
		public string pXjvFi7SHMh;

		public string bS8vF3HxKf0;

		public string CmYvFfOY1GV;

		public _003C_003Ec__DisplayClass40_1 yBavFzWiN4e;

		internal static _003C_003Ec__DisplayClass40_2 BDhsiYW2CbMnnCRGVBX3;

		internal bool pytvFlOcg1U(KeyValuePair<string, ActionStepParam> p)
		{
			if (!string.Equals(yBavFzWiN4e.atSvFFS6WYN, p.Value.VarKey, StringComparison.OrdinalIgnoreCase))
			{
				if (!string.IsNullOrEmpty(p.Value.Value))
				{
					if (!p.Value.Value.Contains(pXjvFi7SHMh) && !p.Value.Value.Contains(bS8vF3HxKf0))
					{
						if (yBavFzWiN4e.dXdvFUEJSP7.UUbvFMCPj4j.StepRunnerKey == "sys:form")
						{
							return p.Value.Value.Contains(CmYvFfOY1GV);
						}
						return false;
					}
					return true;
				}
				return false;
			}
			return true;
		}

		static _003C_003Ec__DisplayClass40_2()
		{
		}

		internal static bool p2tjU7W274vgjv91qFNl()
		{
			return BDhsiYW2CbMnnCRGVBX3 == null;
		}

		internal static void XuNm35W2hkyDYAyLAUZu()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass40_3
	{
		public string sXXvUgI32jm;

		public string KDjvULCCWVW;

		public string IdjvUv1RDHC;

		public _003C_003Ec__DisplayClass40_0 bTivUSdkuHD;

		internal static _003C_003Ec__DisplayClass40_3 yxqYQVW2HIdUWwRN2dw3;

		internal bool QA9vUwp0Jh2(KeyValuePair<string, string> p)
		{
			if (!string.Equals(p.Value, sXXvUgI32jm, StringComparison.OrdinalIgnoreCase))
			{
				return p.Value?.StartsWith(sXXvUgI32jm + ".", StringComparison.OrdinalIgnoreCase) == true;
			}
			return true;
		}

		internal bool QgNvUtkVlg8(KeyValuePair<string, ActionStepParam> p)
		{
			if (!string.IsNullOrEmpty(p.Value?.Value))
			{
				if (!p.Value.Value.Contains(KDjvULCCWVW))
				{
					if (bTivUSdkuHD.UUbvFMCPj4j.StepRunnerKey == "sys:form")
					{
						return p.Value.Value.Contains(IdjvUv1RDHC);
					}
					return false;
				}
				return true;
			}
			return false;
		}

		internal static bool HsGwlaW2zIwmtYvBb88U()
		{
			return yxqYQVW2HIdUWwRN2dw3 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	internal struct _003C_003Ec__DisplayClass43_0
	{
		public ActionExecuteContext QWGvU2rCXi1;
	}

	private static readonly ILog HqdtD65hOCq;

	private static Regex iQstDX9ZK7s;

	internal static object e2GxuLQbKGBiJI3uxoKe;

	public static object GetParamVariableObject(StepInParamDef paramDef, ActionStep step, ActionExecuteContext context, bool skipLogging = false)
	{
		if (!step.InputParams.ContainsKey(paramDef.Key))
		{
			return null;
		}
		ActionStepParam actionStepParam = step.InputParams[paramDef.Key];
		if (string.IsNullOrEmpty(actionStepParam.VarKey))
		{
			throw new InvalidDataException("未指定变量名，参数：" + paramDef.Name);
		}
		if (!context.IsVarExists(actionStepParam.VarKey))
		{
			throw new InvalidDataException("变量未定义：" + actionStepParam.VarKey);
		}
		object varValue = context.GetVarValue(actionStepParam.VarKey);
		if (context.IsDebugging && !skipLogging)
		{
			IActionLogger actionLogger = context.ActionLogger;
			if (actionLogger == null)
			{
				int num = 0;
				if (e2GxuLQbKGBiJI3uxoKe != null)
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
				actionLogger.LogInput(paramDef, varValue ?? "", "", step);
			}
		}
		return varValue;
	}

	public static object GetParamValue(StepInParamDef paramDef, ActionStep step, ActionExecuteContext context, bool skipLogging = false, bool skipConvert = false, bool skipLogContent = false)
	{
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
		_003C_003Ec__DisplayClass2_.yZcvFk6fvB6 = step;
		_003C_003Ec__DisplayClass2_.Uy4vFGBpnkU = paramDef;
		_003C_003Ec__DisplayClass2_.r16vFsa2ewe = context;
		_003C_003Ec__DisplayClass2_.ToNvF1pxeee = skipConvert;
		_003C_003Ec__DisplayClass2_.IZlvFHtIbpG = null;
		object obj = _003C_003Ec__DisplayClass2_.lI0vFW6fJe2();
		if (_003C_003Ec__DisplayClass2_.r16vFsa2ewe.IsDebugging)
		{
			int num = 0;
			if (!uSU7RnQbBJcJeubMH9C6())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (!skipLogging)
			{
				object paramValue = (skipLogContent ? "[略]" : obj);
				_003C_003Ec__DisplayClass2_.r16vFsa2ewe.ActionLogger?.LogInput(_003C_003Ec__DisplayClass2_.Uy4vFGBpnkU, paramValue, _003C_003Ec__DisplayClass2_.IZlvFHtIbpG, _003C_003Ec__DisplayClass2_.yZcvFk6fvB6);
			}
		}
		return obj;
	}

	private static bool fH0tD9flSpf(string string_0)
	{
		if (!string_0.Contains("Clipboard.") && !string_0.Contains("ClipApi()"))
		{
			return false;
		}
		return true;
	}

	public static bool IsInputParamDefined(StepInParamDef paramDef, ActionStep step)
	{
		if (step.InputParams.ContainsKey(paramDef.Key))
		{
			ActionStepParam actionStepParam = step.InputParams[paramDef.Key];
			if (!string.IsNullOrEmpty(actionStepParam.VarKey))
			{
				return true;
			}
			return !string.IsNullOrEmpty(actionStepParam.Value);
		}
		return true;
	}

	public static string GetTextParamValue(StepInParamDef paramDef, ActionStep step, ActionExecuteContext context)
	{
		object obj = VariableHelper.ConvertToType(VarType.Text, GetParamValue(paramDef, step, context, true, true));
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
				goto IL_0026;
			}
		}
		obj2 = "";
		goto IL_0026;
		IL_0026:
		string text = (string)obj2;
		if (context.IsDebugging)
		{
			context.ActionLogger?.LogInput(paramDef, text, null, step);
		}
		return text;
	}

	public static string[] GetOptionsLines(StepInParamDef paramDef, ActionStep step, ActionExecuteContext context)
	{
		string textParamValue = GetTextParamValue(paramDef, step, context);
		if (string.IsNullOrWhiteSpace(textParamValue))
		{
			return new string[0];
		}
		return textParamValue.Split(new string[2] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
	}

	public static IList<string> GetListParamValue(StepInParamDef paramDef, ActionStep step, ActionExecuteContext context)
	{
		IList<string> list = VariableHelper.ConvertToType(VarType.List, GetParamValue(paramDef, step, context, true)) as IList<string>;
		if (context.IsDebugging)
		{
			context.ActionLogger?.LogInput(paramDef, list, null, step);
		}
		return list;
	}

	public static IDictionary<string, object> GetDictParamValue(StepInParamDef paramDef, ActionStep step, ActionExecuteContext context)
	{
		IDictionary<string, object> dictionary = VariableHelper.ConvertToType(VarType.Dict, GetParamValue(paramDef, step, context, true)) as IDictionary<string, object>;
		if (context.IsDebugging)
		{
			context.ActionLogger?.LogInput(paramDef, dictionary, null, step);
		}
		return dictionary;
	}

	public static string InterpolateStr(ActionExecuteContext context, string str)
	{
		if (string.IsNullOrWhiteSpace(str))
		{
			return str;
		}
		if (str.Length > 2 && str.StartsWith("$$", StringComparison.OrdinalIgnoreCase))
		{
			string string_ = str.Substring(2);
			try
			{
				return Lp9tDhEhxSM(context, string_);
			}
			catch (Exception ex)
			{
				context.ActionLogger.LogWarning("新方法插值出错, 改为尝试旧方法。错误：" + ex.GetMessageWithInner());
				try
				{
					str = QpftDY4F8Ik(context, string_);
				}
				catch
				{
					throw ex;
				}
			}
		}
		return str;
	}

	private static string Lp9tDhEhxSM(ActionExecuteContext actionExecuteContext_0, string string_0)
	{
		IDictionary<string, object> variables = actionExecuteContext_0.GetVariables();
		return xsVtDenQtcm(string_0, variables, actionExecuteContext_0.GetEvalContext());
	}

	internal static string xsVtDenQtcm(string string_0, IDictionary<string, object> idictionary_0, EvalContext evalContext_0)
	{
		_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
		_003C_003Ec__DisplayClass12_.MOvvFRtGgr9 = evalContext_0;
		_003C_003Ec__DisplayClass12_.WU9vFqVy6da = idictionary_0;
		_003C_003Ec__DisplayClass12_.wtQvFcR5Og6 = null;
		return iQstDX9ZK7s.Replace(string_0, _003C_003Ec__DisplayClass12_.StsvFaI6bpD);
	}

	private static string QpftDY4F8Ik(ActionExecuteContext actionExecuteContext_0, string string_0)
	{
		using (IEnumerator<KeyValuePair<string, object>> enumerator = actionExecuteContext_0.GetVariables().GetEnumerator())
		{
			int num2 = default(int);
			while (enumerator.MoveNext())
			{
				while (true)
				{
					KeyValuePair<string, object> current = enumerator.Current;
					if (string_0.Contains("{" + current.Key + "}"))
					{
						string_0 = string_0.Replace("{" + current.Key + "}", CGstDIfH7gH(current.Value));
					}
					if (current.Value.IsList())
					{
						if (current.Value is IList<string> list)
						{
							if (string_0.Contains("{" + current.Key + "."))
							{
								for (int i = 0; i < list.Count; i++)
								{
									if (string_0.Contains($"{{{current.Key}.{i}}}"))
									{
										string_0 = string_0.Replace($"{{{current.Key}.{i}}}", list[i]);
									}
								}
								int num = 0;
								if (e2GxuLQbKGBiJI3uxoKe != null)
								{
									num = num2;
								}
								switch (num)
								{
								case 1:
									break;
								default:
									goto IL_0163;
								case 2:
									goto end_IL_010f;
								}
								continue;
							}
						}
						else if (actionExecuteContext_0 != null)
						{
							actionExecuteContext_0.ActionLogger.LogWarning("变量" + current.Key + "不是文本列表。");
						}
					}
					goto IL_0163;
					IL_0163:
					if (!current.Value.IsDictionary())
					{
						break;
					}
					if (!(current.Value is IDictionary<string, object> dictionary))
					{
						if (actionExecuteContext_0 != null)
						{
							actionExecuteContext_0.ActionLogger.LogWarning("变量" + current.Key + "不是词典。");
						}
					}
					else
					{
						if (!string_0.Contains("{" + current.Key + "."))
						{
							break;
						}
						foreach (KeyValuePair<string, object> item in dictionary)
						{
							if (string_0.Contains("{" + current.Key + "." + item.Key + "}"))
							{
								string_0 = string_0.Replace("{" + current.Key + "." + item.Key + "}", Convert.ToString(item.Value));
							}
						}
					}
					break;
					continue;
					end_IL_010f:
					break;
				}
			}
		}
		if (string_0.Contains("{[cliptext]}"))
		{
			string newValue = ClipboardHelper.TryGetClipboardText(TextDataFormat.UnicodeText);
			string_0 = string_0.Replace("{[cliptext]}", newValue);
		}
		return string_0;
	}

	public static bool IsExpressionOrInterpolation(this string value)
	{
		if (!string.IsNullOrEmpty(value))
		{
			if (!value.StartsWith("$=", StringComparison.Ordinal))
			{
				return value.StartsWith("$$", StringComparison.Ordinal);
			}
			return true;
		}
		return false;
	}

	public static string InterpolateOrEvalToString(ActionExecuteContext context, string data)
	{
		object obj2;
		if (data.StartsWith("$$"))
		{
			data = InterpolateStr(context, data);
		}
		else if (data.StartsWith("$="))
		{
			object obj = VariableHelper.ConvertToType(VarType.Text, GetValueFromExpression2(data.Substring(2), context));
			if (obj == null)
			{
				obj2 = null;
			}
			else
			{
				obj2 = obj.ToString();
				if (obj2 != null)
				{
					goto IL_004d;
				}
			}
			obj2 = "";
			goto IL_004d;
		}
		goto IL_004f;
		IL_004f:
		return data;
		IL_004d:
		data = (string)obj2;
		goto IL_004f;
	}

	private static string CGstDIfH7gH(object object_0)
	{
		if (object_0 == null)
		{
			return string.Empty;
		}
		if (object_0 is bool flag)
		{
			return flag.ToString(CultureInfo.InvariantCulture).ToLowerInvariant();
		}
		if (object_0 is IList<string> values)
		{
			return string.Join("\n", values);
		}
		if (object_0 is Dictionary<string, object>)
		{
			return Convert.ToString(VariableHelper.ConvertToType(VarType.Text, object_0));
		}
		return Convert.ToString(object_0, CultureInfo.CurrentCulture);
	}

	public static long GetIntegerParamValue(StepInParamDef paramDef, ActionStep step, ActionExecuteContext context)
	{
		return Convert.ToInt64(VariableHelper.ConvertToType(VarType.Integer, GetParamValue(paramDef, step, context)));
	}

	public static double GetNumberParamValue(StepInParamDef paramDef, ActionStep step, ActionExecuteContext context)
	{
		return Convert.ToDouble(VariableHelper.ConvertToType(VarType.Number, GetParamValue(paramDef, step, context)));
	}

	public static object GetValueFromExpression2(string expression, ActionExecuteContext context)
	{
		try
		{
			return cHBtDkjh5TG(expression, context);
		}
		catch (EvalException ex)
		{
			string message = $"解析表达式出错0:{ex.Message}\r\n动作名称：{context.Action.Title}\r\nevalEx.OriginalCode：{ex.OriginalCode}\r\nexpression：{expression}\r\n开始位置：{ex.StartPosition}\r\n附近代码：{ex.NearText}";
			HqdtD65hOCq.Warn(message, ex);
			context.ActionLogger.LogWarning("使用Z.Expressions解析表达式出错，尝试使用DynamicExpresso.");
			try
			{
				return MwWtDWQ3HKG(expression, context);
			}
			catch
			{
				throw new Exception($"解析表达式出错。\r\n内部错误：{ex.GetMessageWithInner()}\r\n原始表达式：{ex.OriginalCode}\r\n开始位置：{ex.StartPosition}\r\n附近代码：{ex.NearText}");
			}
		}
		catch (Exception ex2)
		{
			context.ActionLogger.LogWarning("使用Z.Expressions解析表达式出错，尝试使用DynamicExpresso. ");
			string message2 = "解析表达式出错1:" + ex2.Message + "\r\n动作名称：" + context.Action.Title + "\r\nexpression：" + expression;
			HqdtD65hOCq.Warn(message2, ex2);
			try
			{
				return MwWtDWQ3HKG(expression, context);
			}
			catch
			{
				throw new Exception("解析表达式出错。\r\n内部错误：" + ex2.GetMessageWithInner() + "\r\n原始表达式：" + expression);
			}
		}
	}

	private static object MwWtDWQ3HKG(string string_0, ActionExecuteContext actionExecuteContext_0)
	{
		Interpreter interpreter;
		while (true)
		{
			interpreter = new Interpreter();
			if (e2GxuLQbKGBiJI3uxoKe == null)
			{
				switch (0)
				{
				case 1:
					continue;
				}
			}
			break;
		}
		interpreter.Reference(typeof(Math));
		interpreter.Reference(typeof(Path));
		interpreter.Reference(typeof(Regex));
		interpreter.Reference(typeof(Enumerable));
		interpreter.EnableAssignment(AssignmentOperators.None);
		IList<Parameter> list = new List<Parameter>();
		int num = 0;
		int num3 = default(int);
		foreach (KeyValuePair<string, object> customDatum in actionExecuteContext_0.CustomData)
		{
			int num2 = 0;
			if (!uSU7RnQbBJcJeubMH9C6())
			{
				num2 = num3;
			}
			switch (num2)
			{
			}
			string text = "v_" + customDatum.Key;
			if (string_0.Contains("{" + customDatum.Key + "}"))
			{
				string_0 = string_0.Replace("{" + customDatum.Key + "}", text);
				if (customDatum.Value == null)
				{
					actionExecuteContext_0.ActionLogger.LogWarning("变量 " + customDatum.Key + " 的值为null，可能会造成表达式解析出错。");
				}
				list.Add(new Parameter(text, customDatum.Value));
			}
			num++;
		}
		return interpreter.Eval(string_0, list.ToArray());
	}

	internal static object cHBtDkjh5TG(string string_0, ActionExecuteContext actionExecuteContext_0)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		if (string_0.Contains("{[cliptext]}"))
		{
			string_0 = string_0.Replace("{[cliptext]}", "vv_cliptext");
			dictionary.Add("vv_cliptext", ClipboardHelper.TryGetClipboardText(TextDataFormat.UnicodeText));
		}
		foreach (KeyValuePair<string, object> customDatum in actionExecuteContext_0.CustomData)
		{
			string text = "v_" + customDatum.Key;
			if (string_0.Contains("{" + customDatum.Key + "}"))
			{
				string_0 = string_0.Replace("{" + customDatum.Key + "}", text);
				if (customDatum.Value == null)
				{
					actionExecuteContext_0.ActionLogger.LogWarning("变量 " + customDatum.Key + " 的值为null，可能会造成表达式解析出错。");
				}
				object value = customDatum.Value;
				if (customDatum.Value is long num && num > -2147483648L && num < 2147483647L)
				{
					value = (int)num;
				}
				dictionary.Add(text, value);
			}
		}
		dictionary.Add("_context", actionExecuteContext_0);
		return actionExecuteContext_0.GetEvalContext().Execute(string_0, dictionary);
	}

	public static bool GetBooleanParamValue(StepInParamDef paramDef, ActionStep step, ActionExecuteContext context)
	{
		try
		{
			return Convert.ToBoolean(VariableHelper.ConvertToType(VarType.Boolean, GetParamValue(paramDef, step, context)));
		}
		catch (Exception ex)
		{
			context.ActionLogger.LogWarning("解析布尔表达式(" + GetParamDirectValue(paramDef, step) + ")出错，已直接返回False。错误信息：" + ex.GetMessageWithInner());
			if (string.IsNullOrEmpty(context.Action.TemplateId))
			{
				HqdtD65hOCq.Warn("布尔表达式解析出错。表达式：" + GetParamDirectValue(paramDef, step) + " 错误：" + ex.Message, ex);
				AppHelper.ShowWarning("布尔表达式解析出错(已直接返回False)，请调试运行后根据提示修复。");
			}
			return false;
		}
	}

	public static object EvaluateExpression(string expression)
	{
		NCalc.Expression expression2 = new NCalc.Expression(expression);
		expression2.EvaluateFunction += _003C_003EO.xVhvF8SucAW ?? (_003C_003EO.xVhvF8SucAW = SnltDGoOLLh);
		return expression2.Evaluate();
	}

	private static void SnltDGoOLLh(string string_0, FunctionArgs functionArgs_0)
	{
		if (string_0 == "UnixTimestampToDateTime")
		{
			object value = functionArgs_0.Parameters[0].Evaluate();
			functionArgs_0.Result = UnixTimeStampToDateTime(Convert.ToDouble(value, CultureInfo.InvariantCulture));
		}
		if (string_0 == "Length")
		{
			object obj = functionArgs_0.Parameters[0].Evaluate();
			functionArgs_0.Result = Convert.ToString(obj, CultureInfo.InvariantCulture)?.Length ?? 0;
		}
		if (!(string_0 == "Random"))
		{
			return;
		}
		if (!functionArgs_0.Parameters.Any())
		{
			functionArgs_0.Result = new Random().Next();
		}
		else if (functionArgs_0.Parameters.Count() == 1)
		{
			functionArgs_0.Result = new Random().Next((int)functionArgs_0.Parameters[0].Evaluate());
			int num = 0;
			if (!uSU7RnQbBJcJeubMH9C6())
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
			functionArgs_0.Result = new Random().Next((int)functionArgs_0.Parameters[0].Evaluate(), (int)functionArgs_0.Parameters[1].Evaluate());
		}
	}

	public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
	{
		return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(unixTimeStamp).ToLocalTime();
	}

	public static string GetParamDisplayString(StepInParamDef paramDef, ActionStep step, int limitLength = 70)
	{
		if (paramDef == null)
		{
			return "错误：paramDef为空！";
		}
		if (step == null)
		{
			return "错误：step为空！";
		}
		if (step.InputParams == null)
		{
			return "错误：step.InputParams为空！";
		}
		if (!step.InputParams.ContainsKey(paramDef.Key))
		{
			return "";
		}
		_003C_003Ec__DisplayClass26_0 _003C_003Ec__DisplayClass26_ = new _003C_003Ec__DisplayClass26_0();
		_003C_003Ec__DisplayClass26_.u9xvF9XtKyS = step.InputParams[paramDef.Key];
		if (_003C_003Ec__DisplayClass26_.u9xvF9XtKyS == null)
		{
			return "param为空！";
		}
		if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass26_.u9xvF9XtKyS.VarKey))
		{
			return "{" + _003C_003Ec__DisplayClass26_.u9xvF9XtKyS.VarKey + "}";
		}
		if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass26_.u9xvF9XtKyS.Value))
		{
			string text = _003C_003Ec__DisplayClass26_.u9xvF9XtKyS.Value;
			if (paramDef.Type == VarType.Enum && paramDef.SelectionItems != null)
			{
				if (uSU7RnQbBJcJeubMH9C6())
				{
					switch (0)
					{
					}
				}
				SelectionItem selectionItem = paramDef.SelectionItems.FirstOrDefault(_003C_003Ec__DisplayClass26_.ncxvFZaGhwq);
				if (selectionItem != null)
				{
					text = selectionItem.Name;
				}
			}
			if (limitLength > 0)
			{
				return text.ToShortString(limitLength);
			}
			return text;
		}
		return _003C_003Ec__DisplayClass26_.u9xvF9XtKyS.Value;
	}

	public static bool IsOutputParamSetted(string outParamKey, ActionStep step)
	{
		if (step.OutputParams != null && step.OutputParams.ContainsKey(outParamKey))
		{
			return !string.IsNullOrEmpty(step.OutputParams[outParamKey]);
		}
		return false;
	}

	public static ActionVariable GetOutputVariable(string outParamKey, ActionStep step, IXProgram action)
	{
		_003C_003Ec__DisplayClass28_0 _003C_003Ec__DisplayClass28_ = new _003C_003Ec__DisplayClass28_0();
		if (step.OutputParams != null && step.OutputParams.ContainsKey(outParamKey) && !string.IsNullOrEmpty(step.OutputParams[outParamKey]))
		{
			_003C_003Ec__DisplayClass28_.jYOvFegh5hC = step.OutputParams[outParamKey];
			return action.Variables.FirstOrDefault(_003C_003Ec__DisplayClass28_.QBUvFh24Z6N);
		}
		return null;
	}

	public static string GetParamDirectValue(StepInParamDef paramDef, ActionStep step, bool showEnumName = true)
	{
		if (step.InputParams.ContainsKey(paramDef.Key))
		{
			_003C_003Ec__DisplayClass29_0 _003C_003Ec__DisplayClass29_ = new _003C_003Ec__DisplayClass29_0();
			_003C_003Ec__DisplayClass29_.yaCvFIdK5Wg = step.InputParams[paramDef.Key];
			if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass29_.yaCvFIdK5Wg.VarKey))
			{
				return "{" + _003C_003Ec__DisplayClass29_.yaCvFIdK5Wg.VarKey + "}";
			}
			if (paramDef.Type == VarType.Enum && paramDef.SelectionItems != null && showEnumName)
			{
				if (!uSU7RnQbBJcJeubMH9C6())
				{
					switch (0)
					{
					}
				}
				SelectionItem selectionItem = paramDef.SelectionItems.FirstOrDefault(_003C_003Ec__DisplayClass29_.dvkvFYmbHIs);
				if (selectionItem != null)
				{
					return selectionItem.Name;
				}
			}
			return _003C_003Ec__DisplayClass29_.yaCvFIdK5Wg.Value;
		}
		return "";
	}

	public static void OutputResult(StepOutParamDef paramDef, ActionStep step, ActionExecuteContext context, object result, XAction action, bool skipLogContent = false)
	{
		if (!IsOutputParamSetted(paramDef.Key, step))
		{
			return;
		}
		if (step.OutputParams == null)
		{
			if (context.IsDebugging)
			{
				context.ActionLogger.LogError("step.OutputParams为空！");
			}
			return;
		}
		IDictionary<string, string> outputParams = step.OutputParams;
		_003C_003Ec__DisplayClass30_0 _003C_003Ec__DisplayClass30_;
		int num;
		if (outputParams != null && outputParams.ContainsKey(paramDef.Key) && !string.IsNullOrEmpty(step.OutputParams[paramDef.Key]))
		{
			_003C_003Ec__DisplayClass30_ = new _003C_003Ec__DisplayClass30_0();
			num = 0;
			if (!uSU7RnQbBJcJeubMH9C6())
			{
				goto IL_0177;
			}
			goto IL_01fa;
		}
		return;
		IL_01fa:
		ActionVariable actionVariable = default(ActionVariable);
		object obj3 = default(object);
		do
		{
			IL_01fa_2:
			switch (num)
			{
			default:
				while (true)
				{
					_003C_003Ec__DisplayClass30_.p2IvF44u2pH = step.OutputParams[paramDef.Key];
					if (string.Equals(_003C_003Ec__DisplayClass30_.p2IvF44u2pH, "[cliptext]", StringComparison.OrdinalIgnoreCase))
					{
						break;
					}
					actionVariable = action.Variables.FirstOrDefault(_003C_003Ec__DisplayClass30_.YqMvFnmpwyD);
					if (actionVariable != null && actionVariable.Type == VarType.Dict && _003C_003Ec__DisplayClass30_.p2IvF44u2pH.StartsWith(actionVariable.Key + "."))
					{
						num = 3;
						if (!uSU7RnQbBJcJeubMH9C6())
						{
							continue;
						}
						goto IL_01fa_2;
					}
					goto IL_017d;
				}
				break;
			case 1:
				if (actionVariable != null && actionVariable.SaveState)
				{
					ActionStateWriter.WriteActionState(context.ActionId, XActionRunner.GetVarStateKey(actionVariable.Key), GetVariableActionStateValue(obj3));
				}
				return;
			case 2:
				return;
			case 3:
				{
					string key = _003C_003Ec__DisplayClass30_.p2IvF44u2pH.Substring(actionVariable.Key.Length + 1);
					Dictionary<string, object> dictionary = context.GetVarValue(actionVariable.Key) as Dictionary<string, object>;
					if (dictionary == null)
					{
						dictionary = new Dictionary<string, object>();
						context.SetVarValueWithoutConvert(actionVariable.Key, dictionary);
					}
					object obj = (dictionary[key] = VariableHelper.ConvertToType(paramDef.Type, result));
					if (context.IsRootContext && actionVariable.SaveState)
					{
						ActionStateWriter.WriteActionState(context.ActionId, XActionRunner.GetVarStateKey(actionVariable.Key), GetVariableActionStateValue(dictionary));
					}
					if (context.IsDebugging)
					{
						context.ActionLogger.LogOutput(paramDef, _003C_003Ec__DisplayClass30_.p2IvF44u2pH, skipLogContent ? "(略)" : obj);
					}
					return;
				}
				IL_017d:
				obj3 = VariableHelper.ConvertToType(actionVariable?.Type ?? paramDef.Type, result);
				context.SetVarValueWithoutConvert(step.OutputParams[paramDef.Key], obj3);
				if (context.IsDebugging)
				{
					context.ActionLogger.LogOutput(paramDef, step.OutputParams[paramDef.Key], skipLogContent ? "(略)" : obj3);
				}
				if (context.IsRootContext)
				{
					num = 1;
					if (uSU7RnQbBJcJeubMH9C6())
					{
						goto IL_01fa_2;
					}
					goto case 1;
				}
				return;
			}
			string text = Convert.ToString(VariableHelper.ConvertToType(VarType.Text, result));
			if (context.IsDebugging)
			{
				context.ActionLogger.LogOutput(paramDef, step.OutputParams[paramDef.Key], skipLogContent ? "(略)" : text);
			}
			ClipboardHelper.SetText(text);
			num = 2;
		}
		while (uSU7RnQbBJcJeubMH9C6());
		goto IL_0177;
		IL_0177:
		int num2 = default(int);
		num = num2;
		goto IL_01fa;
	}

	public static string GetVariableActionStateValue(object objValue)
	{
		if (objValue == null)
		{
			return string.Empty;
		}
		if (objValue is List<string>)
		{
			return JsonConvert.SerializeObject(objValue);
		}
		return Convert.ToString(VariableHelper.ConvertToType(VarType.Text, objValue));
	}

	public static void OutputResultIfNeeded(StepOutParamDef outParam, Func<object> func, ActionStep step, ActionExecuteContext context, XAction action)
	{
		if (IsOutputParamSetted(outParam.Key, step))
		{
			OutputResult(outParam, step, context, func(), action);
		}
	}

	public static void OutputResultToVariable(string varKey, object result, ActionExecuteContext context, XAction action)
	{
		_003C_003Ec__DisplayClass33_0 _003C_003Ec__DisplayClass33_ = new _003C_003Ec__DisplayClass33_0();
		_003C_003Ec__DisplayClass33_.iTfvFD7skFr = varKey;
		string text = default(string);
		int num;
		ActionVariable actionVariable = default(ActionVariable);
		object obj = default(object);
		if (string.Equals(_003C_003Ec__DisplayClass33_.iTfvFD7skFr, "[cliptext]", StringComparison.OrdinalIgnoreCase))
		{
			text = Convert.ToString(VariableHelper.ConvertToType(VarType.Text, result));
			if (!context.IsDebugging)
			{
				goto IL_00f5;
			}
			num = 0;
			if (!uSU7RnQbBJcJeubMH9C6())
			{
				goto IL_00e0;
			}
		}
		else
		{
			actionVariable = action.Variables.FirstOrDefault(_003C_003Ec__DisplayClass33_.sUevF59KJLU);
			obj = VariableHelper.ConvertToType(actionVariable?.Type ?? VarType.Text, result);
			context.SetVarValueWithoutConvert(_003C_003Ec__DisplayClass33_.iTfvFD7skFr, obj);
			if (context.IsDebugging)
			{
				context.ActionLogger.LogOutput(null, _003C_003Ec__DisplayClass33_.iTfvFD7skFr, obj);
			}
			if (!context.IsRootContext || actionVariable == null || !actionVariable.SaveState)
			{
				return;
			}
			num = 1;
			if (!uSU7RnQbBJcJeubMH9C6())
			{
				int num2 = default(int);
				num = num2;
			}
		}
		switch (num)
		{
		case 1:
			ActionStateWriter.WriteActionState(context.ActionId, XActionRunner.GetVarStateKey(actionVariable.Key), GetVariableActionStateValue(obj));
			return;
		}
		goto IL_00e0;
		IL_00e0:
		context.ActionLogger.LogOutput(null, _003C_003Ec__DisplayClass33_.iTfvFD7skFr, text);
		goto IL_00f5;
		IL_00f5:
		ClipboardHelper.SetText(text);
	}

	public static string GetOutputParamDisplayString(StepOutParamDef paramDef, ActionStep step)
	{
		if (paramDef == null)
		{
			return "";
		}
		Ensure.NotNull(paramDef, "paramDef");
		Ensure.NotNull(step, "step");
		return GetOutputParamDisplayString(paramDef.Key, step);
	}

	public static string GetOutputParamDisplayString(string paramKey, ActionStep step)
	{
		if (step.OutputParams == null)
		{
			return "!step.OutputParams为空";
		}
		if (step.OutputParams.ContainsKey(paramKey))
		{
			string text = step.OutputParams[paramKey];
			if (!string.IsNullOrEmpty(text))
			{
				return "{" + text + "}";
			}
			return "-";
		}
		return "";
	}

	public static void ExecuteCommonAction(ActionExecuteContext context, ActionStep step, XAction action, Func<(bool isSuccess, string message, ActionStopFlag failReason)> actionFunc, Action successAction, Action failAction, StepInParamDef stopIfErrorParam, StepOutParamDef isSuccessOutputParam)
	{
		bool flag = true;
		if (stopIfErrorParam != null)
		{
			flag = GetBooleanParamValue(stopIfErrorParam, step, context);
		}
		bool flag2 = false;
		ActionStopFlag actionStopFlag = ActionStopFlag.NoStop;
		string text;
		try
		{
			(flag2, text, actionStopFlag) = actionFunc();
		}
		catch (Exception exception)
		{
			flag2 = false;
			text = exception.GetMessageWithInner();
			context.ActionLogger?.LogError(text, exception);
		}
		if (isSuccessOutputParam != null)
		{
			OutputResult(isSuccessOutputParam, step, context, flag2, action);
			if (IsOutputParamSetted(StepOutParamDef.ErrorMessageOutputParam.Key, step))
			{
				OutputResult(StepOutParamDef.ErrorMessageOutputParam, step, context, text, action);
			}
		}
		if (flag2)
		{
			successAction?.Invoke();
			return;
		}
		context.ActionLogger?.LogWarning("步骤(" + step.StepRunnerKey + ")执行失败，原因：" + text);
		failAction?.Invoke();
		if (flag)
		{
			if (!actionStopFlag.IsEither(ActionStopFlag.UserCancel, ActionStopFlag.ForceStop) && !string.IsNullOrEmpty(text) && context.ParentContext == null && !context.HideWarning)
			{
				string text2 = "";
				ActionItem action2 = context.Action;
				if (action2 != null && !action2.TemplateId.IsNullOrEmpty())
				{
					text2 = $"v{context.Action?.TemplateRevision}";
				}
				HqdtD65hOCq.Warn("动作(" + context.Action?.Title + ")" + text2 + "运行失败：" + text);
				string message = text + "\r\n(----" + context.Action?.Title + text2 + ":" + step.StepRunnerName + "----)";
				context.ShowWarning(message, step);
			}
			context.StopAction((actionStopFlag == ActionStopFlag.NoStop) ? ActionStopFlag.OperationFailed : actionStopFlag, text);
			context.ErrorMessage = text + "(" + step.StepRunnerName + ")";
		}
		else
		{
			HqdtD65hOCq.Info("动作(" + context.Action?.Title + ")步骤运行失败并忽略：" + text);
		}
	}

	public static void ExecuteCommonAction(ActionExecuteContext context, ActionStep step, XAction action, Func<Task<(bool isSuccess, string message, ActionStopFlag failReason)>> asyncActionFunc, Action successAction, Action failAction, StepInParamDef stopIfErrorParam, StepOutParamDef isSuccessOutputParam)
	{
		bool flag = true;
		if (stopIfErrorParam != null)
		{
			flag = GetBooleanParamValue(stopIfErrorParam, step, context);
		}
		bool flag2 = false;
		ActionStopFlag actionStopFlag = ActionStopFlag.NoStop;
		string text;
		try
		{
			(flag2, text, actionStopFlag) = Task.Run(asyncActionFunc).GetAwaiter().GetResult();
		}
		catch (Exception exception)
		{
			flag2 = false;
			text = exception.GetMessageWithInner();
			context.ActionLogger?.LogError(text, exception);
		}
		if (isSuccessOutputParam != null)
		{
			OutputResult(isSuccessOutputParam, step, context, flag2, action);
			if (IsOutputParamSetted(StepOutParamDef.ErrorMessageOutputParam.Key, step))
			{
				OutputResult(StepOutParamDef.ErrorMessageOutputParam, step, context, text, action);
			}
		}
		if (flag2)
		{
			successAction?.Invoke();
			return;
		}
		context.ActionLogger?.LogWarning("步骤(" + step.StepRunnerKey + ")执行失败，原因：" + text);
		failAction?.Invoke();
		if (flag)
		{
			if (!actionStopFlag.IsEither(ActionStopFlag.UserCancel, ActionStopFlag.ForceStop) && !string.IsNullOrEmpty(text) && context.ParentContext == null && !context.HideWarning)
			{
				string text2 = "";
				ActionItem action2 = context.Action;
				if (action2 != null && !action2.TemplateId.IsNullOrEmpty())
				{
					text2 = $"v{context.Action?.TemplateRevision}";
				}
				HqdtD65hOCq.Warn("动作(" + context.Action?.Title + ")" + text2 + "运行失败：" + text);
				string message = text + "\r\n(----" + context.Action?.Title + text2 + ":" + step.StepRunnerName + "----)";
				context.ShowWarning(message, step);
			}
			context.StopAction((actionStopFlag == ActionStopFlag.NoStop) ? ActionStopFlag.OperationFailed : actionStopFlag, text);
			context.ErrorMessage = text + "(" + step.StepRunnerName + ")";
		}
		else
		{
			HqdtD65hOCq.Info("动作(" + context.Action?.Title + ")步骤运行失败并忽略：" + text);
		}
	}

	public static IList<IStepRunner> GetRiskySteps(XAction action)
	{
		_003C_003Ec__DisplayClass38_0 _003C_003Ec__DisplayClass38_0_ = default(_003C_003Ec__DisplayClass38_0);
		_003C_003Ec__DisplayClass38_0_.qcmvFddUwb5 = new List<IStepRunner>();
		if (action == null)
		{
			return _003C_003Ec__DisplayClass38_0_.qcmvFddUwb5;
		}
		eobtDHYPVkg(action.Steps, ref _003C_003Ec__DisplayClass38_0_);
		return _003C_003Ec__DisplayClass38_0_.qcmvFddUwb5;
	}

	public static bool HasProOnlyStep(XAction action)
	{
		if (action == null)
		{
			return false;
		}
		if (action.SubPrograms.HasData())
		{
			foreach (SubProgram subProgram in action.SubPrograms)
			{
				if (NcftD12y2d6(subProgram.Steps))
				{
					return true;
				}
			}
		}
		return NcftD12y2d6(action.Steps);
	}

	public static bool IsMatchFilter(ActionStep step, string filter)
	{
		_003C_003Ec__DisplayClass40_0 _003C_003Ec__DisplayClass40_ = new _003C_003Ec__DisplayClass40_0();
		_003C_003Ec__DisplayClass40_.UUbvFMCPj4j = step;
		_003C_003Ec__DisplayClass40_.MiOvFAjZcZe = filter;
		_003C_003Ec__DisplayClass40_3 _003C_003Ec__DisplayClass40_2 = default(_003C_003Ec__DisplayClass40_3);
		if (_003C_003Ec__DisplayClass40_.UUbvFMCPj4j != null && !string.IsNullOrEmpty(_003C_003Ec__DisplayClass40_.MiOvFAjZcZe))
		{
			int num;
			if (_003C_003Ec__DisplayClass40_.MiOvFAjZcZe.StartsWith("var:", StringComparison.OrdinalIgnoreCase))
			{
				num = 0;
				if (!uSU7RnQbBJcJeubMH9C6())
				{
					goto IL_0096;
				}
			}
			else
			{
				if (!_003C_003Ec__DisplayClass40_.MiOvFAjZcZe.StartsWith("to:"))
				{
					if (!_003C_003Ec__DisplayClass40_.MiOvFAjZcZe.ContainedInAny(_003C_003Ec__DisplayClass40_.UUbvFMCPj4j.Note) && !_003C_003Ec__DisplayClass40_.UUbvFMCPj4j.InputParams.Any(_003C_003Ec__DisplayClass40_.GbVvFoX4x1e) && !_003C_003Ec__DisplayClass40_.UUbvFMCPj4j.OutputParams.Any(_003C_003Ec__DisplayClass40_.oXkvFTEFeD7))
					{
						int num2 = 2;
						goto IL_02d7;
					}
					return true;
				}
				_003C_003Ec__DisplayClass40_2 = new _003C_003Ec__DisplayClass40_3();
				num = 1;
				if (e2GxuLQbKGBiJI3uxoKe != null)
				{
					int num2 = default(int);
					num = num2;
				}
			}
			switch (num)
			{
			case 1:
				goto IL_01ab;
			case 2:
				goto IL_02d7;
			}
			goto IL_0096;
		}
		return false;
		IL_02d7:
		return StepRunnerRegistry.GetRunner(_003C_003Ec__DisplayClass40_.UUbvFMCPj4j.StepRunnerKey)?.Name == _003C_003Ec__DisplayClass40_.MiOvFAjZcZe;
		IL_0096:
		_003C_003Ec__DisplayClass40_1 _003C_003Ec__DisplayClass40_3 = new _003C_003Ec__DisplayClass40_1();
		_003C_003Ec__DisplayClass40_3.dXdvFUEJSP7 = _003C_003Ec__DisplayClass40_;
		_003C_003Ec__DisplayClass40_3.atSvFFS6WYN = _003C_003Ec__DisplayClass40_3.dXdvFUEJSP7.MiOvFAjZcZe.Substring("var:".Length);
		if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass40_3.atSvFFS6WYN))
		{
			_003C_003Ec__DisplayClass40_2 _003C_003Ec__DisplayClass40_4 = new _003C_003Ec__DisplayClass40_2();
			_003C_003Ec__DisplayClass40_4.yBavFzWiN4e = _003C_003Ec__DisplayClass40_3;
			_003C_003Ec__DisplayClass40_4.pXjvFi7SHMh = "{" + _003C_003Ec__DisplayClass40_4.yBavFzWiN4e.atSvFFS6WYN + "}";
			_003C_003Ec__DisplayClass40_4.bS8vF3HxKf0 = "{" + _003C_003Ec__DisplayClass40_4.yBavFzWiN4e.atSvFFS6WYN + ".";
			_003C_003Ec__DisplayClass40_4.CmYvFfOY1GV = "\"" + _003C_003Ec__DisplayClass40_4.yBavFzWiN4e.atSvFFS6WYN + "\"";
			if (!_003C_003Ec__DisplayClass40_4.yBavFzWiN4e.dXdvFUEJSP7.UUbvFMCPj4j.InputParams.Any(_003C_003Ec__DisplayClass40_4.pytvFlOcg1U))
			{
				return _003C_003Ec__DisplayClass40_4.yBavFzWiN4e.dXdvFUEJSP7.UUbvFMCPj4j.OutputParams.Any(_003C_003Ec__DisplayClass40_4.yBavFzWiN4e.MuSvFOIENvg);
			}
			return true;
		}
		return false;
		IL_01ab:
		_003C_003Ec__DisplayClass40_2.bTivUSdkuHD = _003C_003Ec__DisplayClass40_;
		_003C_003Ec__DisplayClass40_2.sXXvUgI32jm = _003C_003Ec__DisplayClass40_2.bTivUSdkuHD.MiOvFAjZcZe.Substring("to:".Length);
		_003C_003Ec__DisplayClass40_2.KDjvULCCWVW = "etVarValue(\"" + _003C_003Ec__DisplayClass40_2.sXXvUgI32jm + "\")";
		_003C_003Ec__DisplayClass40_2.IdjvUv1RDHC = "\"" + _003C_003Ec__DisplayClass40_2.sXXvUgI32jm + "\"";
		if (!string.IsNullOrEmpty(_003C_003Ec__DisplayClass40_2.sXXvUgI32jm))
		{
			if (_003C_003Ec__DisplayClass40_2.bTivUSdkuHD.UUbvFMCPj4j.OutputParams.Any(_003C_003Ec__DisplayClass40_2.QA9vUwp0Jh2))
			{
				return true;
			}
			return _003C_003Ec__DisplayClass40_2.bTivUSdkuHD.UUbvFMCPj4j.InputParams.Any(_003C_003Ec__DisplayClass40_2.QgNvUtkVlg8);
		}
		return false;
	}

	public static bool IsStepExists(IEnumerable<ActionStep> steps, Func<ActionStep, bool> predictFunc)
	{
		if (steps == null)
		{
			return false;
		}
		foreach (ActionStep step in steps)
		{
			if (!predictFunc(step))
			{
				if (!step.IfSteps.HasData() || !IsStepExists(step.IfSteps, predictFunc))
				{
					if (step.ElseSteps.HasData() && IsStepExists(step.ElseSteps, predictFunc))
					{
						return true;
					}
					continue;
				}
				return true;
			}
			return true;
		}
		return false;
	}

	public static void TravelSteps(IEnumerable<ActionStep> steps, Action<ActionStep> processor)
	{
		if (steps == null)
		{
			return;
		}
		foreach (ActionStep step in steps)
		{
			processor(step);
			if (step.IfSteps.HasData())
			{
				TravelSteps(step.IfSteps, processor);
			}
			if (step.ElseSteps.HasData())
			{
				TravelSteps(step.ElseSteps, processor);
			}
		}
	}

	public static Image GetImageParamValue(StepInParamDef imageParam, ActionStep step, ActionExecuteContext context, out string imgFilePath)
	{
		_003C_003Ec__DisplayClass43_0 _003C_003Ec__DisplayClass43_0_ = default(_003C_003Ec__DisplayClass43_0);
		_003C_003Ec__DisplayClass43_0_.QWGvU2rCXi1 = context;
		imgFilePath = "";
		object paramValue = GetParamValue(imageParam, step, _003C_003Ec__DisplayClass43_0_.QWGvU2rCXi1, false, true);
		if (paramValue == null)
		{
			return null;
		}
		if (paramValue is Image result)
		{
			return result;
		}
		string text2;
		int num;
		if (paramValue is string text)
		{
			if (string.IsNullOrEmpty(text))
			{
				return null;
			}
			text2 = PathHelper.RemoveZeroWidthChar(text);
			if (text2.Length < 250)
			{
				num = 1;
				if (!uSU7RnQbBJcJeubMH9C6())
				{
					goto IL_0086;
				}
				goto IL_008a;
			}
			goto IL_00a2;
		}
		goto IL_00f9;
		IL_0086:
		int num2 = default(int);
		num = num2;
		goto IL_008a;
		IL_008a:
		switch (num)
		{
		case 1:
			break;
		default:
			return LDwtDb3CllR(ToBase64StringStep.Xj1g7pIqZBx(text2), ref _003C_003Ec__DisplayClass43_0_);
		}
		if (File.Exists(text2))
		{
			imgFilePath = text2;
			Image image = ImageHelper.ReadImageFromFileWithoutLock(text2);
			_003C_003Ec__DisplayClass43_0_.QWGvU2rCXi1.RegisterDisposable(image);
			return image;
		}
		goto IL_00a2;
		IL_00a2:
		if (text2.StartsWith("data:"))
		{
			num = 0;
			if (!uSU7RnQbBJcJeubMH9C6())
			{
				goto IL_0086;
			}
			goto IL_008a;
		}
		if (text2.IsBase64())
		{
			try
			{
				return LDwtDb3CllR(text2, ref _003C_003Ec__DisplayClass43_0_);
			}
			catch (Exception)
			{
			}
		}
		goto IL_00f9;
		IL_00f9:
		throw new InvalidDataException("参数(" + imageParam.Name + ")输入值不是图片对象，也无法转换为图片对象。");
	}

	internal static Bitmap NbwtDs1GvAM(StepInParamDef stepInParamDef_0, ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0)
	{
		string imgFilePath;
		Image imageParamValue = GetImageParamValue(stepInParamDef_0, actionStep_0, actionExecuteContext_0, out imgFilePath);
		if (imageParamValue == null)
		{
			return null;
		}
		if (imageParamValue is Bitmap result)
		{
			return result;
		}
		return new Bitmap(imageParamValue);
	}

	public static DataTable GetTableParamValue(StepInParamDef inParam, ActionStep step, ActionExecuteContext context)
	{
		if (!(GetParamVariableObject(inParam, step, context, true) is DataTable result))
		{
			throw new InvalidDataException("未能成功获取表格变量。");
		}
		return result;
	}

	static XActionHelper()
	{
		HqdtD65hOCq = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		iQstDX9ZK7s = new Regex("\\{([^}^{]+)\\}", RegexOptions.Compiled);
	}

	[CompilerGenerated]
	internal static void eobtDHYPVkg(IList<ActionStep> ilist_0, ref _003C_003Ec__DisplayClass38_0 _003C_003Ec__DisplayClass38_0_0)
	{
		if (!ilist_0.HasData())
		{
			return;
		}
		foreach (ActionStep item in ilist_0)
		{
			IStepRunner runner = StepRunnerRegistry.GetRunner(item.StepRunnerKey);
			if (runner != null && runner.IsRisky && !_003C_003Ec__DisplayClass38_0_0.qcmvFddUwb5.Contains(runner))
			{
				_003C_003Ec__DisplayClass38_0_0.qcmvFddUwb5.Add(runner);
			}
			eobtDHYPVkg(item.IfSteps, ref _003C_003Ec__DisplayClass38_0_0);
			eobtDHYPVkg(item.ElseSteps, ref _003C_003Ec__DisplayClass38_0_0);
		}
	}

	[CompilerGenerated]
	internal static bool NcftD12y2d6(IList<ActionStep> ilist_0)
	{
		if (!ilist_0.HasData())
		{
			return false;
		}
		foreach (ActionStep item in ilist_0)
		{
			IStepRunner runner = StepRunnerRegistry.GetRunner(item.StepRunnerKey);
			if (runner == null || !runner.IsProOnly)
			{
				if (!NcftD12y2d6(item.IfSteps))
				{
					if (NcftD12y2d6(item.ElseSteps))
					{
						return true;
					}
					continue;
				}
				return true;
			}
			return true;
		}
		return false;
	}

	[CompilerGenerated]
	internal static Bitmap LDwtDb3CllR(string string_0, ref _003C_003Ec__DisplayClass43_0 _003C_003Ec__DisplayClass43_0_0)
	{
		MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(string_0));
		Bitmap bitmap = new Bitmap(Image.FromStream(memoryStream));
		memoryStream.Close();
		_003C_003Ec__DisplayClass43_0_0.QWGvU2rCXi1.RegisterDisposable(bitmap);
		return bitmap;
	}

	internal static bool uSU7RnQbBJcJeubMH9C6()
	{
		return e2GxuLQbKGBiJI3uxoKe == null;
	}
}
