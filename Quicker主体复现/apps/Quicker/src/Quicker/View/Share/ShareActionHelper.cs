using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Newtonsoft.Json;
using Quicker.Domain;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.BuiltinRunners;
using Quicker.Domain.Actions.X.BuiltinRunners.Text;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Public.Extensions;
using Quicker.Utilities;

namespace Quicker.View.Share;

public static class ShareActionHelper
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass1_0
	{
		public IDictionary<string, string> zxoSQjgWCY2;

		public XAction HU9SQnJEUHb;

		public List<SubProgram> XFiSQ4HMH34;

		private static _003C_003Ec__DisplayClass1_0 nlyIGDWIrWlP5cx6k8F6;

		internal string vXJSQpUBgJM(string identifier)
		{
			int num = 1;
			_003C_003Ec__DisplayClass1_1 _003C_003Ec__DisplayClass1_;
			_003C_003Ec__DisplayClass1_2 _003C_003Ec__DisplayClass1_2 = default(_003C_003Ec__DisplayClass1_2);
			while (true)
			{
				_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_1();
				int num2 = 0;
				if (nlyIGDWIrWlP5cx6k8F6 != null)
				{
					goto IL_0061;
				}
				goto IL_00f8;
				IL_00f8:
				switch (num2)
				{
				case 2:
					break;
				default:
					goto IL_0061;
				case 1:
					continue;
				}
				bool flag = HU9SQnJEUHb.SubPrograms.Any(_003C_003Ec__DisplayClass1_2.ROjSQd3r6Rk);
				goto IL_002d;
				IL_0061:
				if (!zxoSQjgWCY2.ContainsKey(identifier))
				{
					string text = identifier.Substring("%%".Length);
					_003C_003Ec__DisplayClass1_.JF3SQDAKyNx = AppState.DataService.GetGlobalSubProgram(text);
					if (_003C_003Ec__DisplayClass1_.JF3SQDAKyNx != null)
					{
						_003C_003Ec__DisplayClass1_.JF3SQDAKyNx = AppHelper.Clone(_003C_003Ec__DisplayClass1_.JF3SQDAKyNx);
						if (!(flag = HU9SQnJEUHb.SubPrograms.Any(_003C_003Ec__DisplayClass1_.GZKSQ5EqaTu)))
						{
							break;
						}
						_003C_003Ec__DisplayClass1_2 = new _003C_003Ec__DisplayClass1_2
						{
							wVrSQT4B7NA = _003C_003Ec__DisplayClass1_,
							FneSQoEEiVC = 0
						};
						goto IL_002d;
					}
					throw new InvalidDataException("未找到公共子程序：" + text);
				}
				return zxoSQjgWCY2[identifier];
				IL_002d:
				if (flag)
				{
					_003C_003Ec__DisplayClass1_2.FneSQoEEiVC++;
					num2 = 2;
					if (nlyIGDWIrWlP5cx6k8F6 != null)
					{
						num2 = num;
					}
					goto IL_00f8;
				}
				_003C_003Ec__DisplayClass1_2.wVrSQT4B7NA.JF3SQDAKyNx.Name = _003C_003Ec__DisplayClass1_2.wVrSQT4B7NA.JF3SQDAKyNx.Name + _003C_003Ec__DisplayClass1_2.FneSQoEEiVC;
				break;
			}
			HU9SQnJEUHb.SubPrograms.Add(_003C_003Ec__DisplayClass1_.JF3SQDAKyNx);
			zxoSQjgWCY2.Add(identifier, _003C_003Ec__DisplayClass1_.JF3SQDAKyNx.Name);
			return _003C_003Ec__DisplayClass1_.JF3SQDAKyNx.Name;
		}

		internal void tN4SQBgOtPm(ActionStep step)
		{
			if (step.Disabled)
			{
				return;
			}
			if (step.StepRunnerKey == "sys:subprogram")
			{
				string subProgramIdentifier = SubProgramStep.GetSubProgramIdentifier(step);
				if (subProgramIdentifier.StartsWith("%%", StringComparison.InvariantCulture))
				{
					step.InputParams[SubProgramStep.SubProgramNameParam.Key].Value = vXJSQpUBgJM(subProgramIdentifier);
				}
			}
			else
			{
				if (!(step.StepRunnerKey == "sys:showText") || !step.InputParams.ContainsKey(ShowTextStep.OperationInputParam.Key))
				{
					return;
				}
				string value = step.InputParams[ShowTextStep.OperationInputParam.Key].Value;
				if (string.IsNullOrEmpty(value) || !value.Contains("$sp$"))
				{
					return;
				}
				StringBuilder stringBuilder = new StringBuilder(value.Length);
				string[] array = value.Split(new string[3] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
				foreach (string text in array)
				{
					if (!text.Contains("$sp$"))
					{
						stringBuilder.AppendLine(text);
						continue;
					}
					string[] array2 = text.Split(new char[1] { '$' }, 4, StringSplitOptions.None);
					if (array2.Length == 4 && string.Equals(array2[2], "sp", StringComparison.OrdinalIgnoreCase))
					{
						while (true)
						{
							IL_017a:
							string text2 = array2[3].Split(new char[1] { '?' }, 2)[0];
							while (text2.StartsWith("%%", StringComparison.InvariantCulture))
							{
								if (!K4eWk5WINGiEBr5e6DlJ())
								{
									switch (1)
									{
									case 2:
										break;
									default:
										goto IL_017a;
									case 1:
										goto IL_0196;
									}
									continue;
								}
								goto IL_0196;
							}
							stringBuilder.AppendLine(text);
							break;
							IL_0196:
							stringBuilder.AppendLine(text.Replace("$sp$" + text2, "$sp$" + vXJSQpUBgJM(text2)));
							break;
						}
					}
					else
					{
						stringBuilder.AppendLine(text);
					}
				}
				step.InputParams[ShowTextStep.OperationInputParam.Key].Value = stringBuilder.ToString();
			}
		}

		internal bool EYESQQN36tg(SubProgram x)
		{
			return !XFiSQ4HMH34.Contains(x);
		}

		internal static bool K4eWk5WINGiEBr5e6DlJ()
		{
			return nlyIGDWIrWlP5cx6k8F6 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass1_1
	{
		public SubProgram JF3SQDAKyNx;

		internal static _003C_003Ec__DisplayClass1_1 GRkb3FWIbPWBfKfTJG7c;

		internal bool GZKSQ5EqaTu(SubProgram x)
		{
			return x.Name == JF3SQDAKyNx.Name;
		}

		internal static bool bCThhAWIqDlWuwHCETCX()
		{
			return GRkb3FWIbPWBfKfTJG7c == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass1_2
	{
		public int FneSQoEEiVC;

		public _003C_003Ec__DisplayClass1_1 wVrSQT4B7NA;

		private static _003C_003Ec__DisplayClass1_2 cpfLFZWIlI4rKtR8YvxH;

		internal bool ROjSQd3r6Rk(SubProgram x)
		{
			return x.Name == $"{wVrSQT4B7NA.JF3SQDAKyNx.Name}{FneSQoEEiVC}";
		}

		internal static bool QpcB8XWIZG7eEF0OPGH6()
		{
			return cpfLFZWIlI4rKtR8YvxH == null;
		}
	}

	internal static object y7kdDqFespbN3tNsT3BN;

	public static string EmbedGlobalSubPrograms(string actionData)
	{
		if (string.IsNullOrEmpty(actionData))
		{
			return actionData;
		}
		XAction? xAction = JsonConvert.DeserializeObject<XAction>(actionData);
		GhjL2WSbh0u(xAction);
		return JsonConvert.SerializeObject(xAction);
	}

	private static void GhjL2WSbh0u(XAction xaction_0)
	{
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
		_003C_003Ec__DisplayClass1_.HU9SQnJEUHb = xaction_0;
		_003C_003Ec__DisplayClass1_.zxoSQjgWCY2 = new Dictionary<string, string>();
		int num = 1;
		if (y7kdDqFespbN3tNsT3BN != null)
		{
			int num2 = default(int);
			num = num2;
		}
		List<SubProgram> list = default(List<SubProgram>);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			case 1:
				if (_003C_003Ec__DisplayClass1_.HU9SQnJEUHb.SubPrograms == null)
				{
					_003C_003Ec__DisplayClass1_.HU9SQnJEUHb.SubPrograms = new List<SubProgram>();
				}
				XActionHelper.TravelSteps(_003C_003Ec__DisplayClass1_.HU9SQnJEUHb.Steps, _003C_003Ec__DisplayClass1_.tN4SQBgOtPm);
				list = _003C_003Ec__DisplayClass1_.HU9SQnJEUHb.SubPrograms.ToList();
				_003C_003Ec__DisplayClass1_.XFiSQ4HMH34 = _003C_003Ec__DisplayClass1_.HU9SQnJEUHb.SubPrograms.ToList();
				num3 = 0;
				num4 = 10;
				goto IL_00a3;
			default:
				{
					if (num3 <= num4)
					{
						foreach (SubProgram item in list)
						{
							XActionHelper.TravelSteps(item.Steps, _003C_003Ec__DisplayClass1_.tN4SQBgOtPm);
						}
						list = _003C_003Ec__DisplayClass1_.HU9SQnJEUHb.SubPrograms.Where(_003C_003Ec__DisplayClass1_.EYESQQN36tg).ToList();
						_003C_003Ec__DisplayClass1_.XFiSQ4HMH34 = _003C_003Ec__DisplayClass1_.HU9SQnJEUHb.SubPrograms.ToList();
						goto IL_00a3;
					}
					throw new InvalidDataException($"无法成功转换公共子程序到内部子程序，重试次数已达{num4}次。");
				}
				IL_00a3:
				if (list.HasData())
				{
					num3++;
					num = 0;
					if (y7kdDqFespbN3tNsT3BN != null)
					{
						break;
					}
					goto default;
				}
				return;
			}
		}
	}

	internal static bool hM9QxvFeCvN5pDrh2VLs()
	{
		return y7kdDqFespbN3tNsT3BN == null;
	}
}
