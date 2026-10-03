using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows;
using KgHnJYYeIAVMZbA8Lyv;
using Newtonsoft.Json;
using Quicker.Domain;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.BuiltinRunners.Misc;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Actions.X.Variables;
using Quicker.Domain.Forms;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Public.Forms;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Ext;

namespace Quicker.View.X;

public static class XActionUiHelper
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec craSOCasHcD;

		public static Func<KeyValuePair<string, string>, bool> GZHSOPa9Jki;

		public static Comparison<ActionVariable> NwvSOEulUDV;

		public static Comparison<ActionVariable> eMWSOy5H2hk;

		internal static _003C_003Ec eYxoQFWz99alQM73bTNA;

		static _003C_003Ec()
		{
			craSOCasHcD = new _003C_003Ec();
		}

		internal bool JGjSONRW70m(KeyValuePair<string, string> x)
		{
			return !string.IsNullOrEmpty(x.Value);
		}

		internal int tadSOJ0JLxo(ActionVariable a, ActionVariable b)
		{
			return a.Key.CompareTo(b.Key);
		}

		internal int GaHSO0daX8G(ActionVariable a, ActionVariable b)
		{
			return YXDLGpoNosX(a.Type).CompareTo(YXDLGpoNosX(b.Type));
		}

		internal static bool lTtfJ5WzLqsH4Vac8hrq()
		{
			return eYxoQFWz99alQM73bTNA == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass0_0
	{
		public string HBfSOagovhJ;

		private static _003C_003Ec__DisplayClass0_0 HT9lFpWzowdPSTUTeOoU;

		internal bool C2hSO8FH18C(ActionVariable x)
		{
			return x.Key == HBfSOagovhJ;
		}

		internal static bool LjLvBUWzfcCTbEkBFspv()
		{
			return HT9lFpWzowdPSTUTeOoU == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	internal struct _003C_003Ec__DisplayClass12_0
	{
		public ICollection<ActionVariable> KhqSO7o1ph2;

		public IList<string> u14SORwK17R;

		public IList<string> LVTSOqIYECA;
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass16_0
	{
		public string OqCSOVNdi8Z;

		internal static _003C_003Ec__DisplayClass16_0 nsy4aHWzZsC3ZWyOXsk7;

		internal bool vNdSOcyEZ1M(string x)
		{
			return x == OqCSOVNdi8Z;
		}

		internal static void kvaPEmWz8lwt1q20TRQm()
		{
		}

		internal static bool GHuWVOWz5dSZRXRyw3EK()
		{
			return nsy4aHWzZsC3ZWyOXsk7 == null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	internal struct _003C_003Ec__DisplayClass3_0
	{
		public string ALYSOZis80t;

		public string uOqSO92tAg3;

		public VarType EcUSOh3fNbH;
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass5_0
	{
		public ActionVariable tBOSOYZnEHm;

		private static _003C_003Ec__DisplayClass5_0 jQCuGbWzMTRF4rvw6nAE;

		internal bool CftSOe9Gm3b(ActionVariable x)
		{
			return x.Key == tBOSOYZnEHm.Key;
		}

		internal static bool LlMclsWzUS66e55bq4Rx()
		{
			return jQCuGbWzMTRF4rvw6nAE == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass5_1
	{
		public string qfbSOWPd0hD;

		private static _003C_003Ec__DisplayClass5_1 RckEu4Wz6h2MhIbc3Zyt;

		internal bool cr9SOI0jlLm(ActionVariable x)
		{
			return x.Key == qfbSOWPd0hD;
		}

		internal static bool HKxILuWztuCZ5Q03g9Jx()
		{
			return RckEu4Wz6h2MhIbc3Zyt == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass9_0
	{
		public ActionVariable NmESOGJZ4bX;

		private static _003C_003Ec__DisplayClass9_0 UYew8CWzwZZEaGx2LEZd;

		internal bool OfTSOkI6sPH(ActionVariable x)
		{
			return x == NmESOGJZ4bX;
		}

		internal static bool p9N9rLWzTobP4OGfOOnJ()
		{
			return UYew8CWzwZZEaGx2LEZd == null;
		}
	}

	internal static object P65H0wFkSx5MnxV5d6AQ;

	public static ActionVariable CreateVariable(Window owner, ICollection<ActionVariable> variables, VarType? varType, bool isSubProgram = false, string presetVarName = "", string presetVarDesc = "", bool isForOutput = false, bool allowExisting = false)
	{
		VariableEditorWindow variableEditorWindow = new VariableEditorWindow(variables, isSubProgram)
		{
			Owner = owner,
			AllowUseExistingVariable = allowExisting
		};
		if (varType == VarType.Enum)
		{
			varType = VarType.Text;
		}
		if (varType.HasValue && varType != VarType.Any && varType != VarType.CreateVar && varType != VarType.NA)
		{
			variableEditorWindow.PresetVarType = varType;
		}
		if (!string.IsNullOrEmpty(presetVarName))
		{
			_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
			_003C_003Ec__DisplayClass0_.HBfSOagovhJ = KQBLGr2PkTm(presetVarName);
			if (variables != null && !variables.Any(_003C_003Ec__DisplayClass0_.C2hSO8FH18C))
			{
				variableEditorWindow.TxtKey.Text = _003C_003Ec__DisplayClass0_.HBfSOagovhJ;
			}
		}
		variableEditorWindow.TxtDesc.Text = "";
		if (variableEditorWindow.ShowDialog() == true)
		{
			if (variables.Contains(variableEditorWindow.Result))
			{
				return variableEditorWindow.Result;
			}
			variables.Add(variableEditorWindow.Result);
			return variableEditorWindow.Result;
		}
		return null;
	}

	private static string KQBLGr2PkTm(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return "";
		}
		string_0 = string_0.Trim();
		if (string_0.StartsWith("var:", StringComparison.OrdinalIgnoreCase))
		{
			return string_0.Substring(4);
		}
		if (!VariableHelper.IsValidVarName(string_0))
		{
			return "_" + string_0;
		}
		return string_0;
	}

	public static void ReplaceSubProgramVisibleExpVars(IList<ActionVariable> variables, string oldVarName, string newVarName, VarType type)
	{
		foreach (ActionVariable variable in variables)
		{
			if (!(variable.Key == oldVarName))
			{
				if (!string.IsNullOrEmpty(variable.InputParamInfo?.VisibleExpression))
				{
					variable.InputParamInfo.VisibleExpression = ReplaceVarInText(variable.InputParamInfo.VisibleExpression, oldVarName, newVarName, type);
				}
				if (!string.IsNullOrEmpty(variable.OutputParamInfo?.VisibleExpression))
				{
					variable.OutputParamInfo.VisibleExpression = ReplaceVarInText(variable.OutputParamInfo.VisibleExpression, oldVarName, newVarName, type);
				}
			}
		}
	}

	public static void ReplaceStepsVar(IList<ActionStep> steps, string oldVarName, string newVarName, VarType type)
	{
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_0_ = default(_003C_003Ec__DisplayClass3_0);
		_003C_003Ec__DisplayClass3_0_.ALYSOZis80t = oldVarName;
		_003C_003Ec__DisplayClass3_0_.uOqSO92tAg3 = newVarName;
		_003C_003Ec__DisplayClass3_0_.EcUSOh3fNbH = type;
		if (steps == null)
		{
			return;
		}
		foreach (ActionStep step in steps)
		{
			if (step.StepRunnerKey == "sys:form")
			{
				if (step.InputParams.ContainsKey(FormStep.FormDefParam.Key))
				{
					string value = step.InputParams[FormStep.FormDefParam.Key].Value;
					if (!string.IsNullOrEmpty(value))
					{
						Form form = JsonConvert.DeserializeObject<Form>(value);
						foreach (FormField field in form.Fields)
						{
							if (field.FieldKey == _003C_003Ec__DisplayClass3_0_.ALYSOZis80t)
							{
								field.FieldKey = _003C_003Ec__DisplayClass3_0_.uOqSO92tAg3;
							}
							field.SelectionItems = gX3LGQa68Pa(field.SelectionItems, ref _003C_003Ec__DisplayClass3_0_);
							field.Label = gX3LGQa68Pa(field.Label, ref _003C_003Ec__DisplayClass3_0_);
							field.HelpText = gX3LGQa68Pa(field.HelpText, ref _003C_003Ec__DisplayClass3_0_);
							field.VisibleExpression = gX3LGQa68Pa(field.VisibleExpression, ref _003C_003Ec__DisplayClass3_0_);
						}
						step.InputParams[FormStep.FormDefParam.Key].Value = JsonConvert.SerializeObject(form);
					}
				}
			}
			else if (step.StepRunnerKey == "sys:csscript")
			{
				if (step.InputParams.ContainsKey("script"))
				{
					step.InputParams["script"].Value = Regex.Replace(step.InputParams["script"].Value ?? string.Empty, "(?<=context\\s*.\\s*GetVarValue\\s*\\(\\s*\"\\s*)" + _003C_003Ec__DisplayClass3_0_.ALYSOZis80t + "(?=\\s*\"\\s*\\))", _003C_003Ec__DisplayClass3_0_.uOqSO92tAg3);
					step.InputParams["script"].Value = Regex.Replace(step.InputParams["script"].Value ?? string.Empty, "(?<=context\\s*.\\s*SetVarValue\\s*\\(\\s*\"\\s*)" + _003C_003Ec__DisplayClass3_0_.ALYSOZis80t + "(?=\\s*\"\\s*,)", _003C_003Ec__DisplayClass3_0_.uOqSO92tAg3);
				}
			}
			else if (step.StepRunnerKey == "sys:pythonscript")
			{
				if (step.InputParams.ContainsKey("script"))
				{
					step.InputParams["script"].Value = Regex.Replace(step.InputParams["script"].Value ?? string.Empty, "(?<=quicker\\s*.\\s*context\\s*.\\s*GetVarValue\\s*\\(\\s*\"\\s*)" + _003C_003Ec__DisplayClass3_0_.ALYSOZis80t + "(?=\\s*\"\\s*\\))", _003C_003Ec__DisplayClass3_0_.uOqSO92tAg3);
					step.InputParams["script"].Value = Regex.Replace(step.InputParams["script"].Value ?? string.Empty, "(?<=quicker\\s*.\\s*context\\s*.\\s*SetVarValue\\s*\\(\\s*[\"']\\s*)" + _003C_003Ec__DisplayClass3_0_.ALYSOZis80t + "(?=\\s*[\"']\\s*,)", _003C_003Ec__DisplayClass3_0_.uOqSO92tAg3);
				}
			}
			else if (step.StepRunnerKey == "sys:jsscript")
			{
				if (step.InputParams.ContainsKey("script"))
				{
					step.InputParams["script"].Value = Regex.Replace(step.InputParams["script"].Value ?? string.Empty, "(?<=quickerGetVar\\s*\\(\\s*(\"|')\\s*)" + _003C_003Ec__DisplayClass3_0_.ALYSOZis80t + "(?=\\s*\\1\\s*\\))", _003C_003Ec__DisplayClass3_0_.uOqSO92tAg3);
					step.InputParams["script"].Value = Regex.Replace(step.InputParams["script"].Value ?? string.Empty, "(?<=quickerSetVar\\s*\\(\\s*(\"|')\\s*)" + _003C_003Ec__DisplayClass3_0_.ALYSOZis80t + "(?=\\s*\\1\\s*,)", _003C_003Ec__DisplayClass3_0_.uOqSO92tAg3);
				}
			}
			else if (step.StepRunnerKey == "sys:http" && step.InputParams.ContainsKey("body"))
			{
				step.InputParams["body"].Value = (step.InputParams["body"].Value ?? "").Replace("IMG:" + _003C_003Ec__DisplayClass3_0_.ALYSOZis80t, "IMG:" + _003C_003Ec__DisplayClass3_0_.uOqSO92tAg3);
			}
			IStepRunner runner = StepRunnerRegistry.GetRunner(step.StepRunnerKey);
			if (runner != null && runner.InputParams.HasData())
			{
				foreach (StepInParamDef inputParam in runner.InputParams)
				{
					if (inputParam.ReplaceVariable && step.InputParams.TryGetValue(inputParam.Key, out var value2) && value2 != null && !string.IsNullOrEmpty(value2.Value))
					{
						value2.Value = gX3LGQa68Pa(value2.Value, ref _003C_003Ec__DisplayClass3_0_);
					}
				}
			}
			if (step.InputParams != null)
			{
				foreach (KeyValuePair<string, ActionStepParam> inputParam2 in step.InputParams)
				{
					if (inputParam2.Value != null)
					{
						if (string.Equals(inputParam2.Value.VarKey, _003C_003Ec__DisplayClass3_0_.ALYSOZis80t, StringComparison.InvariantCulture))
						{
							inputParam2.Value.VarKey = _003C_003Ec__DisplayClass3_0_.uOqSO92tAg3;
						}
						else if (!string.IsNullOrWhiteSpace(inputParam2.Value.Value))
						{
							inputParam2.Value.Value = gX3LGQa68Pa(inputParam2.Value.Value, ref _003C_003Ec__DisplayClass3_0_);
						}
					}
				}
			}
			if (step.OutputParams != null)
			{
				foreach (KeyValuePair<string, string> item in step.OutputParams.Where(_003C_003Ec.GZHSOPa9Jki ?? (_003C_003Ec.GZHSOPa9Jki = _003C_003Ec.craSOCasHcD.JGjSONRW70m)).ToList())
				{
					if (string.Equals(item.Value, _003C_003Ec__DisplayClass3_0_.ALYSOZis80t, StringComparison.InvariantCulture))
					{
						step.OutputParams[item.Key] = _003C_003Ec__DisplayClass3_0_.uOqSO92tAg3;
					}
					else if (item.Value.StartsWith(_003C_003Ec__DisplayClass3_0_.ALYSOZis80t + "."))
					{
						string text = step.OutputParams[item.Key];
						step.OutputParams[item.Key] = _003C_003Ec__DisplayClass3_0_.uOqSO92tAg3 + text.Substring(_003C_003Ec__DisplayClass3_0_.ALYSOZis80t.Length);
					}
				}
			}
			if (step.IfSteps != null)
			{
				ReplaceStepsVar(step.IfSteps, _003C_003Ec__DisplayClass3_0_.ALYSOZis80t, _003C_003Ec__DisplayClass3_0_.uOqSO92tAg3, _003C_003Ec__DisplayClass3_0_.EcUSOh3fNbH);
			}
			if (step.ElseSteps != null)
			{
				ReplaceStepsVar(step.ElseSteps, _003C_003Ec__DisplayClass3_0_.ALYSOZis80t, _003C_003Ec__DisplayClass3_0_.uOqSO92tAg3, _003C_003Ec__DisplayClass3_0_.EcUSOh3fNbH);
			}
		}
	}

	public static string ReplaceVarInText(string text, string oldVarName, string newVarName, VarType type, bool skipCheck = false)
	{
		if (string.IsNullOrEmpty(text))
		{
			return text;
		}
		if (!skipCheck && !text.IsExpressionOrInterpolation())
		{
			return text;
		}
		string text2 = text;
		if (P65H0wFkSx5MnxV5d6AQ == null)
		{
			switch (0)
			{
			}
		}
		text2 = text2.Replace("{" + oldVarName + "}", "{" + newVarName + "}");
		if (type == VarType.List || type == VarType.Dict)
		{
			text2 = text2.Replace("{" + oldVarName + ".", "{" + newVarName + ".");
			text2 = text2.Replace("{" + oldVarName + "[", "{" + newVarName + "[");
		}
		return text2;
	}

	public static void ClearVariables(IXProgram action, SmartCollection<ActionVariable> variables, Window owner, bool isForSubProgram)
	{
		IList<ActionVariable> list = new List<ActionVariable>();
		using (IEnumerator<ActionVariable> enumerator = variables.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
				_003C_003Ec__DisplayClass5_.tBOSOYZnEHm = enumerator.Current;
				if (!list.Any(_003C_003Ec__DisplayClass5_.CftSOe9Gm3b))
				{
					list.Add(_003C_003Ec__DisplayClass5_.tBOSOYZnEHm);
				}
			}
		}
		variables.Reset(list);
		IList<string> notUsedVars = GetNotUsedVars(action, isForSubProgram);
		if (notUsedVars.Count == 0)
		{
			AppHelper.ShowInformation("没有可以清除的变量。");
			return;
		}
		int count = 10;
		string message = ((notUsedVars.Count > 10) ? ("您确认清除下面的变量么？\n  " + string.Join("\n  ", notUsedVars.Take(count)) + $"\n  ......\n等，共 {notUsedVars.Count} 个。") : ("您确认清除下面的变量么？\n  " + string.Join("\n  ", notUsedVars)));
		if (!AppHelper.Confirm(message))
		{
			return;
		}
		using IEnumerator<string> enumerator2 = notUsedVars.GetEnumerator();
		while (enumerator2.MoveNext())
		{
			_003C_003Ec__DisplayClass5_1 _003C_003Ec__DisplayClass5_2 = new _003C_003Ec__DisplayClass5_1();
			_003C_003Ec__DisplayClass5_2.qfbSOWPd0hD = enumerator2.Current;
			ActionVariable actionVariable = variables.FirstOrDefault(_003C_003Ec__DisplayClass5_2.cr9SOI0jlLm);
			if (actionVariable != null)
			{
				variables.Remove(actionVariable);
			}
		}
	}

	public static void SortVariableListByName(ObservableCollection<ActionVariable> variables)
	{
		variables.Sort(_003C_003Ec.NwvSOEulUDV ?? (_003C_003Ec.NwvSOEulUDV = _003C_003Ec.craSOCasHcD.tadSOJ0JLxo));
	}

	private static int YXDLGpoNosX(VarType varType_0)
	{
		return varType_0.GetAttributeOfType<DisplayAttribute>()?.GetOrder() ?? 200;
	}

	public static void SortVariableListByType(ObservableCollection<ActionVariable> variables)
	{
		variables.Sort(_003C_003Ec.eMWSOy5H2hk ?? (_003C_003Ec.eMWSOy5H2hk = _003C_003Ec.craSOCasHcD.GaHSO0daX8G));
	}

	public static void DeleteVariable(ActionVariable variable, ObservableCollection<ActionVariable> variableList, IXProgram action, Window owner)
	{
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
		_003C_003Ec__DisplayClass9_.NmESOGJZ4bX = variable;
		if (_003C_003Ec__DisplayClass9_.NmESOGJZ4bX != null)
		{
			if (ofWPUJYbI0eTmcMC6L3.U3iLG5Yq592(action, _003C_003Ec__DisplayClass9_.NmESOGJZ4bX))
			{
				AppHelper.ShowWarning("变量 " + _003C_003Ec__DisplayClass9_.NmESOGJZ4bX.Key + " 已经被使用，不能删除。", true);
			}
			else
			{
				variableList.Remove(variableList.First(_003C_003Ec__DisplayClass9_.OfTSOkI6sPH));
			}
		}
	}

	public static void ExportSubProgram(Window owner, SubProgram subProgram)
	{
		{
			(bool, string) tuple = AppHelper.ShowSaveFileDialog("*.qka|*.qka", ".qka", "子程序_" + AppHelper.RemoveInvalidCharsFromFileName(subProgram.Name) + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".qka", "", "导出子程序定义-" + subProgram.Name);
			if (tuple.Item1)
			{
				try
				{
					File.WriteAllText(tuple.Item2, JsonConvert.SerializeObject(subProgram, Formatting.Indented));
				}
				catch (Exception ex)
				{
					AppHelper.ShowWarning("导出出错：" + ex.Message);
				}
			}
		}
	}

	private static void ETwLGBR1OM5(IList<string> ilist_0, string string_0)
	{
		if (ilist_0 != null && !ilist_0.Contains(string_0))
		{
			ilist_0.Add(string_0);
		}
	}

	public static void AddUsedVarKeys(ICollection<ActionVariable> variables, IList<ActionStep> steps, IList<string> usedVarKeyList, IList<string> inputVarList = null, IList<string> outputVarList = null)
	{
		_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_0_ = default(_003C_003Ec__DisplayClass12_0);
		_003C_003Ec__DisplayClass12_0_.KhqSO7o1ph2 = variables;
		_003C_003Ec__DisplayClass12_0_.u14SORwK17R = usedVarKeyList;
		_003C_003Ec__DisplayClass12_0_.LVTSOqIYECA = inputVarList;
		foreach (ActionVariable item in _003C_003Ec__DisplayClass12_0_.KhqSO7o1ph2)
		{
			if (item.IsInput && !string.IsNullOrEmpty(item.InputParamInfo?.VisibleExpression))
			{
				tN6LGjahRKK(item.InputParamInfo.VisibleExpression, ref _003C_003Ec__DisplayClass12_0_);
			}
			if (item.IsOutput && !string.IsNullOrEmpty(item.OutputParamInfo?.VisibleExpression))
			{
				tN6LGjahRKK(item.OutputParamInfo.VisibleExpression, ref _003C_003Ec__DisplayClass12_0_);
			}
		}
		foreach (ActionStep step in steps)
		{
			if (step.StepRunnerKey == "sys:form" && step.InputParams.ContainsKey(FormStep.FormDefParam.Key))
			{
				string value = step.InputParams[FormStep.FormDefParam.Key].Value;
				if (!string.IsNullOrEmpty(value))
				{
					foreach (FormField field in JsonConvert.DeserializeObject<Form>(value).Fields)
					{
						ETwLGBR1OM5(_003C_003Ec__DisplayClass12_0_.u14SORwK17R, field.FieldKey);
						ETwLGBR1OM5(_003C_003Ec__DisplayClass12_0_.LVTSOqIYECA, field.FieldKey);
						ETwLGBR1OM5(outputVarList, field.FieldKey);
						tN6LGjahRKK(field.SelectionItems, ref _003C_003Ec__DisplayClass12_0_);
						tN6LGjahRKK(field.Label, ref _003C_003Ec__DisplayClass12_0_);
						tN6LGjahRKK(field.HelpText, ref _003C_003Ec__DisplayClass12_0_);
						tN6LGjahRKK(field.VisibleExpression, ref _003C_003Ec__DisplayClass12_0_);
					}
				}
			}
			if (step.InputParams != null)
			{
				foreach (KeyValuePair<string, ActionStepParam> inputParam in step.InputParams)
				{
					if (inputParam.Value == null)
					{
						continue;
					}
					if (!string.IsNullOrWhiteSpace(inputParam.Value.VarKey))
					{
						_003C_003Ec__DisplayClass12_0_.u14SORwK17R.AddIfDistinct(inputParam.Value.VarKey);
						ETwLGBR1OM5(_003C_003Ec__DisplayClass12_0_.LVTSOqIYECA, inputParam.Value.VarKey);
					}
					else
					{
						if (string.IsNullOrWhiteSpace(inputParam.Value.Value))
						{
							continue;
						}
						string value2 = inputParam.Value.Value;
						foreach (ActionVariable item2 in _003C_003Ec__DisplayClass12_0_.KhqSO7o1ph2)
						{
							if (value2.Contains("{" + item2.Key + "}") || (item2.Type.IsEither(VarType.Dict, VarType.List) && value2.Contains("{" + item2.Key + ".")) || (item2.Type.IsEither(VarType.Dict, VarType.List) && value2.Contains("{" + item2.Key + "[")))
							{
								ETwLGBR1OM5(_003C_003Ec__DisplayClass12_0_.u14SORwK17R, item2.Key);
								ETwLGBR1OM5(_003C_003Ec__DisplayClass12_0_.LVTSOqIYECA, item2.Key);
							}
						}
					}
				}
			}
			if (step.OutputParams != null)
			{
				foreach (KeyValuePair<string, string> outputParam in step.OutputParams)
				{
					if (!string.IsNullOrWhiteSpace(outputParam.Value))
					{
						string text = outputParam.Value;
						int num = outputParam.Value.IndexOf(".");
						if (num > 0)
						{
							text = outputParam.Value.Substring(0, num);
						}
						_003C_003Ec__DisplayClass12_0_.u14SORwK17R.AddIfDistinct(text);
						ETwLGBR1OM5(outputVarList, text);
					}
				}
			}
			if (step.IfSteps != null)
			{
				AddUsedVarKeys(_003C_003Ec__DisplayClass12_0_.KhqSO7o1ph2, step.IfSteps, _003C_003Ec__DisplayClass12_0_.u14SORwK17R, _003C_003Ec__DisplayClass12_0_.LVTSOqIYECA, outputVarList);
			}
			if (step.ElseSteps != null)
			{
				AddUsedVarKeys(_003C_003Ec__DisplayClass12_0_.KhqSO7o1ph2, step.ElseSteps, _003C_003Ec__DisplayClass12_0_.u14SORwK17R, _003C_003Ec__DisplayClass12_0_.LVTSOqIYECA, outputVarList);
			}
			List<string> list = _003C_003Ec__DisplayClass12_0_.u14SORwK17R.ToList();
			foreach (ActionVariable item3 in _003C_003Ec__DisplayClass12_0_.KhqSO7o1ph2)
			{
				if (string.IsNullOrEmpty(item3.DefaultValue) || !list.Contains(item3.Key))
				{
					continue;
				}
				foreach (ActionVariable item4 in _003C_003Ec__DisplayClass12_0_.KhqSO7o1ph2)
				{
					if (item3.DefaultValue.Contains("{" + item4.Key + "}"))
					{
						_003C_003Ec__DisplayClass12_0_.u14SORwK17R.AddIfDistinct(item4.Key);
					}
				}
			}
		}
	}

	public static IList<string> GetUsedVars(IXProgram action)
	{
		List<string> list = new List<string>();
		AddUsedVarKeys(action.Variables, action.Steps, list);
		return list;
	}

	public static IList<string> GetUsedVars(IList<ActionStep> steps, ICollection<ActionVariable> variables)
	{
		List<string> list = new List<string>();
		AddUsedVarKeys(variables, steps, list);
		return list;
	}

	public static IList<string> GetNotUsedVars(IXProgram action, bool isForSubProgram)
	{
		IList<string> list = new List<string>();
		foreach (ActionVariable variable in action.Variables)
		{
			if ((!isForSubProgram || (!variable.IsInput && !variable.IsOutput)) && !ofWPUJYbI0eTmcMC6L3.U3iLG5Yq592(action, variable))
			{
				list.Add(variable.Key);
			}
		}
		return list;
	}

	public static bool IsVarUsed(IXProgram action, string varKey)
	{
		_003C_003Ec__DisplayClass16_0 _003C_003Ec__DisplayClass16_ = new _003C_003Ec__DisplayClass16_0();
		_003C_003Ec__DisplayClass16_.OqCSOVNdi8Z = varKey;
		return GetUsedVars(action).Any(_003C_003Ec__DisplayClass16_.vNdSOcyEZ1M);
	}

	public static void ExpandOrCollapseAllNodes(ICollection<ActionStep> steps, bool collapse)
	{
		foreach (ActionStep step in steps)
		{
			if (step.StepType.IsEither(StepType.If, StepType.Loop))
			{
				step.Collapsed = collapse;
				if (step.IfSteps.HasData())
				{
					ExpandOrCollapseAllNodes(step.IfSteps, collapse);
				}
				if (step.ElseSteps.HasData())
				{
					ExpandOrCollapseAllNodes(step.ElseSteps, collapse);
				}
			}
		}
	}

	public static void ReplaceSpName(IList<ActionStep> actionSteps, string oldName, string newName)
	{
		if (!actionSteps.HasData())
		{
			return;
		}
		foreach (ActionStep actionStep in actionSteps)
		{
			if (actionStep.StepRunnerKey == "sys:subprogram" && string.Equals(actionStep.InputParams["subProgram"]?.Value, oldName))
			{
				actionStep.InputParams["subProgram"].Value = newName;
			}
			if (actionStep.IfSteps.HasData())
			{
				ReplaceSpName(actionStep.IfSteps, oldName, newName);
			}
			if (actionStep.ElseSteps.HasData())
			{
				ReplaceSpName(actionStep.ElseSteps, oldName, newName);
			}
		}
	}

	[CompilerGenerated]
	internal static string gX3LGQa68Pa(string string_0, ref _003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_0_0)
	{
		return ReplaceVarInText(string_0, _003C_003Ec__DisplayClass3_0_0.ALYSOZis80t, _003C_003Ec__DisplayClass3_0_0.uOqSO92tAg3, _003C_003Ec__DisplayClass3_0_0.EcUSOh3fNbH);
	}

	[CompilerGenerated]
	internal static void tN6LGjahRKK(string string_0, ref _003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_0_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return;
		}
		foreach (ActionVariable item in _003C_003Ec__DisplayClass12_0_0.KhqSO7o1ph2)
		{
			if (string_0.Contains("{" + item.Key + "}") || (item.Type.IsEither(VarType.Dict, VarType.List) && string_0.Contains("{" + item.Key + ".")) || (item.Type.IsEither(VarType.Dict, VarType.List) && string_0.Contains("{" + item.Key + "[")))
			{
				ETwLGBR1OM5(_003C_003Ec__DisplayClass12_0_0.u14SORwK17R, item.Key);
				ETwLGBR1OM5(_003C_003Ec__DisplayClass12_0_0.LVTSOqIYECA, item.Key);
			}
		}
	}

	static XActionUiHelper()
	{
	}

	internal static bool srfKtgFkwXZXNl60MiLd()
	{
		return P65H0wFkSx5MnxV5d6AQ == null;
	}

	internal static void mxC6ScFksV9EZaHKeQiq()
	{
	}
}
