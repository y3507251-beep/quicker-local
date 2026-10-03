using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.BuiltinRunners.Misc;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Forms;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Public.Forms;
using Quicker.Utilities._3rd;

namespace KgHnJYYeIAVMZbA8Lyv;

internal class ofWPUJYbI0eTmcMC6L3
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass2_0
	{
		public ActionVariable AHGSOH4cxEn;

		public string FkoSO1l4GIo;

		public bool Y52SObJkDgo;

		private static _003C_003Ec__DisplayClass2_0 XvhhVRWzs7HWXSXDnIZb;

		internal bool KfxSOstQtfC(ActionStep step)
		{
			if (mOtLGdnmh3i(step, AHGSOH4cxEn, FkoSO1l4GIo))
			{
				Y52SObJkDgo = true;
				return false;
			}
			return true;
		}

		internal static bool cLTCgLWzCcEqwxmDhobx()
		{
			return XvhhVRWzs7HWXSXDnIZb == null;
		}
	}

	internal static ofWPUJYbI0eTmcMC6L3 JhfJEKFkCBjlpdJ1wS1J;

	internal static bool RlULGn8WKRY(IList<ActionStep> ilist_0, Func<ActionStep, bool> func_0)
	{
		foreach (ActionStep item in ilist_0)
		{
			if (func_0(item))
			{
				if (!item.IfSteps.HasData() || RlULGn8WKRY(item.IfSteps, func_0))
				{
					if (item.ElseSteps.HasData() && !RlULGn8WKRY(item.ElseSteps, func_0))
					{
						return false;
					}
					continue;
				}
				return false;
			}
			return false;
		}
		return true;
	}

	internal static bool MNFLG4dE4hj(string string_0, ActionVariable actionVariable_0, string string_1)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return false;
		}
		if (string_0.Contains(string_1) && (string_0.Contains("{" + actionVariable_0.Key + "}") || string_0.Contains("{" + actionVariable_0.Key + ".") || (actionVariable_0.Type.IsEither(VarType.Dict, VarType.List) && string_0.Contains("{" + actionVariable_0.Key + ".")) || (actionVariable_0.Type.IsEither(VarType.Dict, VarType.List) && string_0.Contains("{" + actionVariable_0.Key + "["))))
		{
			return true;
		}
		return false;
	}

	internal static bool U3iLG5Yq592(IXProgram ixprogram_0, ActionVariable actionVariable_0)
	{
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
		_003C_003Ec__DisplayClass2_.AHGSOH4cxEn = actionVariable_0;
		_003C_003Ec__DisplayClass2_.FkoSO1l4GIo = "{" + _003C_003Ec__DisplayClass2_.AHGSOH4cxEn.Key;
		if (QiQLGDtjdJd(ixprogram_0, _003C_003Ec__DisplayClass2_.AHGSOH4cxEn, _003C_003Ec__DisplayClass2_.FkoSO1l4GIo))
		{
			return true;
		}
		_003C_003Ec__DisplayClass2_.Y52SObJkDgo = false;
		RlULGn8WKRY(ixprogram_0.Steps, _003C_003Ec__DisplayClass2_.KfxSOstQtfC);
		return _003C_003Ec__DisplayClass2_.Y52SObJkDgo;
	}

	private static bool QiQLGDtjdJd(IXProgram ixprogram_0, ActionVariable actionVariable_0, string string_0)
	{
		foreach (ActionVariable variable in ixprogram_0.Variables)
		{
			if (variable == actionVariable_0)
			{
				continue;
			}
			if (!variable.IsInput || string.IsNullOrEmpty(variable.InputParamInfo?.VisibleExpression) || !MNFLG4dE4hj(variable.InputParamInfo.VisibleExpression, actionVariable_0, string_0))
			{
				while (true)
				{
					if (!variable.IsOutput || string.IsNullOrEmpty(variable.OutputParamInfo?.VisibleExpression) || !MNFLG4dE4hj(variable.OutputParamInfo.VisibleExpression, actionVariable_0, string_0))
					{
						if (string.IsNullOrEmpty(variable.DefaultValue))
						{
							break;
						}
						if (JhfJEKFkCBjlpdJ1wS1J == null)
						{
							switch (1)
							{
							default:
								continue;
							case 1:
								break;
							}
						}
						if (!MNFLG4dE4hj(variable.DefaultValue, actionVariable_0, string_0))
						{
							break;
						}
						return true;
					}
					return true;
				}
				continue;
			}
			return true;
		}
		return false;
	}

	internal static bool mOtLGdnmh3i(ActionStep actionStep_0, ActionVariable actionVariable_0, string string_0)
	{
		bool result;
		if (actionStep_0.StepRunnerKey == "sys:form" && actionStep_0.InputParams.ContainsKey(FormStep.FormDefParam.Key))
		{
			string value = actionStep_0.InputParams[FormStep.FormDefParam.Key].Value;
			if (!string.IsNullOrEmpty(value))
			{
				IEnumerator<FormField> enumerator = JsonConvert.DeserializeObject<Form>(value).Fields.GetEnumerator();
				int num = 0;
				if (!cRNV4XFk7ccW2TxDZ1DN())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				try
				{
					int num4 = default(int);
					while (enumerator.MoveNext())
					{
						FormField current = enumerator.Current;
						if (!(current.FieldKey == actionVariable_0.Key))
						{
							if (!MNFLG4dE4hj(current.SelectionItems, actionVariable_0, string_0) && !MNFLG4dE4hj(current.Label, actionVariable_0, string_0) && !MNFLG4dE4hj(current.HelpText, actionVariable_0, string_0) && !MNFLG4dE4hj(current.VisibleExpression, actionVariable_0, string_0))
							{
								continue;
							}
							result = true;
							int num3 = 0;
							if (!cRNV4XFk7ccW2TxDZ1DN())
							{
								num3 = num4;
							}
							switch (num3)
							{
							}
						}
						else
						{
							result = true;
						}
						goto IL_0264;
					}
				}
				finally
				{
					enumerator?.Dispose();
				}
			}
		}
		if (actionStep_0.InputParams == null)
		{
			goto IL_01e4;
		}
		using (IEnumerator<KeyValuePair<string, ActionStepParam>> enumerator2 = actionStep_0.InputParams.GetEnumerator())
		{
			int num6 = default(int);
			while (true)
			{
				if (!enumerator2.MoveNext())
				{
					int num5 = 0;
					if (JhfJEKFkCBjlpdJ1wS1J != null)
					{
						num5 = num6;
					}
					switch (num5)
					{
					}
					break;
				}
				KeyValuePair<string, ActionStepParam> current2 = enumerator2.Current;
				if (current2.Value == null)
				{
					continue;
				}
				if (!string.IsNullOrWhiteSpace(current2.Value.VarKey))
				{
					if (!(current2.Value.VarKey == actionVariable_0.Key))
					{
						continue;
					}
					result = true;
				}
				else
				{
					if (string.IsNullOrWhiteSpace(current2.Value.Value) || !MNFLG4dE4hj(current2.Value.Value, actionVariable_0, string_0))
					{
						continue;
					}
					result = true;
				}
				goto end_IL_013a;
			}
			goto IL_01e4;
			end_IL_013a:;
		}
		goto IL_0264;
		IL_0264:
		return result;
		IL_01e4:
		if (actionStep_0.OutputParams != null)
		{
			foreach (KeyValuePair<string, string> outputParam in actionStep_0.OutputParams)
			{
				if (string.IsNullOrWhiteSpace(outputParam.Value))
				{
					continue;
				}
				string text = outputParam.Value;
				int num7 = outputParam.Value.IndexOf(".");
				if (num7 > 0)
				{
					text = outputParam.Value.Substring(0, num7);
				}
				if (!(text == actionVariable_0.Key))
				{
					continue;
				}
				result = true;
				goto IL_0264;
			}
		}
		return false;
	}

	internal static bool cRNV4XFk7ccW2TxDZ1DN()
	{
		return JhfJEKFkCBjlpdJ1wS1J == null;
	}

	internal static void lpvEbIFay6T4nZZsKN7t()
	{
	}
}
