using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using FontAwesome5;
using HtmlAgilityPack;
using Microsoft.Office.Interop.Excel;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using Quicker.Actions.XActions.BuildinRunners.Office;
using Quicker.Actions.XActions.StepRunners;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Actions.X.Variables;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Utilities.Win32;
using WkL871oNPBM2Fp8RtIf;

namespace Quicker.Domain.Actions.X.BuiltinRunners.Text;

public class HtmlExtractStep : BaseMultiOperationStep, IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec wukS21B7sWd;

		public static StepOperation.GetSummaryFunc xKNS2bpOiEG;

		public static StepOperation.GetSummaryFunc DJNS26JNhoY;

		public static Func<HtmlNode, bool> XorS2XdxrCk;

		public static Func<HtmlNode, string> Da3S2m2U11V;

		public static Func<HtmlNode, string> NEbS2KC0Ygt;

		public static Func<HtmlNode, string> lZ7S2xGkw7B;

		internal static _003C_003Ec socP1IWKlMRVC4aTU0l9;

		static _003C_003Ec()
		{
			wukS21B7sWd = new _003C_003Ec();
		}

		internal string uYNS2IqBZPi(ActionStep step)
		{
			return "提取文本内容 " + XActionHelper.GetParamDisplayString(pFIgStaN0kx, step);
		}

		internal string UkpS2WhkFlZ(ActionStep step)
		{
			return "提取表格内容 " + XActionHelper.GetParamDisplayString(pFIgStaN0kx, step);
		}

		internal bool nSsS2k9MjWg(HtmlNode x)
		{
			return x.Name.ToLower() != "table";
		}

		internal string uCGS2GQTSS4(HtmlNode x)
		{
			return x.InnerHtml?.Trim();
		}

		internal string R47S2syZCTv(HtmlNode node)
		{
			return node.InnerText?.Trim();
		}

		internal string tBiS2HnTqL5(HtmlNode node)
		{
			return node.OuterHtml?.Trim();
		}

		internal static bool wPyqpIWKZ1ldBIbBtb3V()
		{
			return socP1IWKlMRVC4aTU0l9 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass46_0
	{
		public string yYCS2pu5qA5;

		private static _003C_003Ec__DisplayClass46_0 LSFhpEWKRJLHZ9fxeTNb;

		internal string KntS2rZjcaf(HtmlNode node)
		{
			HtmlAttributeCollection attributes = node.Attributes;
			object obj;
			if (attributes == null)
			{
				obj = null;
			}
			else
			{
				HtmlAttribute htmlAttribute = attributes[yYCS2pu5qA5];
				if (htmlAttribute == null)
				{
					obj = null;
				}
				else
				{
					string value = htmlAttribute.Value;
					if (value == null)
					{
						obj = null;
					}
					else
					{
						obj = value.Trim();
						if (obj != null)
						{
							goto IL_0039;
						}
					}
				}
			}
			obj = "";
			goto IL_0039;
			IL_0039:
			return (string)obj;
		}

		internal static bool UdmyMWWKgi4CVSOF3LSk()
		{
			return LSFhpEWKRJLHZ9fxeTNb == null;
		}
	}

	[CompilerGenerated]
	private static class _003C_003Eo__43
	{
		public static CallSite<Func<CallSite, object, object>> Ir3S2BoBMZi;

		public static CallSite<Func<CallSite, object, bool, object>> LslS2Q0jIE4;

		public static CallSite<Func<CallSite, _Worksheet, object>> PuDS2jk42Cf;

		public static CallSite<Func<CallSite, object, object, object, object>> kMoS2nFyGiI;

		public static CallSite<Action<CallSite, object>> D9XS2421BFL;
	}

	[CompilerGenerated]
	private readonly string bcogviEEgdf = $"fa:{EFontAwesomeIcon.Brands_Html5}:#6aaded";

	[CompilerGenerated]
	private readonly string PLwgv3ARQ2N = "https://getquicker.net/KC/Help/Doc/htmlextract";

	[CompilerGenerated]
	private readonly bool zCqgvfjSo53;

	private static StepInParamDef akDgvzH1lfS;

	private static StepInParamDef lMegSw9oFHu;

	private static StepInParamDef pFIgStaN0kx;

	private static StepInParamDef uk6gSgwCmXs;

	private static StepInParamDef K4ogSL4SSe3;

	private static StepInParamDef JAYgSvVA6xm;

	private static StepInParamDef A21gSSot1CJ;

	private static readonly StepOutParamDef BqZgS2Bs85W;

	private static readonly StepOutParamDef Cm8gSuwpk6e;

	private static HtmlExtractStep NyHoYIQgaETtqJKM6QLO;

	public string Key => "sys:htmlExtract";

	public string Name => "提取HTML内容";

	public IEnumerable<string> KeyWords => new string[4] { "网页", "HTML", "提取", "xpath" };

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return bcogviEEgdf;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Network;

	public IEnumerable<StepRunnerCategory> SecondaryCategories => new StepRunnerCategory[1] { StepRunnerCategory.Text };

	public string Description => "从HTML代码中提取内容";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return PLwgv3ARQ2N;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly
	{
		[CompilerGenerated]
		get
		{
			return zCqgvfjSo53;
		}
	}

	public HtmlExtractStep()
	{
		SetupParams(new StepInParamDef[7] { akDgvzH1lfS, lMegSw9oFHu, pFIgStaN0kx, uk6gSgwCmXs, K4ogSL4SSe3, JAYgSvVA6xm, A21gSSot1CJ }, new StepOutParamDef[2] { BqZgS2Bs85W, Cm8gSuwpk6e });
		StepOperation operation = new StepOperation
		{
			Key = "extractText",
			Title = "提取文本内容",
			GetSummary = (_003C_003Ec.xKNS2bpOiEG ?? (_003C_003Ec.xKNS2bpOiEG = _003C_003Ec.wukS21B7sWd.uYNS2IqBZPi)),
			InputParams = { akDgvzH1lfS, lMegSw9oFHu, pFIgStaN0kx, uk6gSgwCmXs, K4ogSL4SSe3, JAYgSvVA6xm },
			OutputParams = { BqZgS2Bs85W, Cm8gSuwpk6e },
			Execute = RB3gvlxOVxx
		};
		AddOperation(operation, true);
		AddOperation(new StepOperation
		{
			Key = "extractTable",
			Title = "提取表格内容",
			GetSummary = (_003C_003Ec.DJNS26JNhoY ?? (_003C_003Ec.DJNS26JNhoY = _003C_003Ec.wukS21B7sWd.UkpS2WhkFlZ)),
			InputParams = { akDgvzH1lfS, lMegSw9oFHu, pFIgStaN0kx, A21gSSot1CJ },
			OutputParams = { Cm8gSuwpk6e },
			Execute = nHmgvAQTNes
		});
	}

	private StepExecuteResult nHmgvAQTNes(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0, string string_2)
	{
		HtmlNode htmlNode = EukgvUd3J2I(actionStep_0, actionExecuteContext_0, xaction_0);
		XActionHelper.OutputResult(Cm8gSuwpk6e, actionStep_0, actionExecuteContext_0, htmlNode, xaction_0);
		string text = XActionHelper.GetTextParamValue(pFIgStaN0kx, actionStep_0, actionExecuteContext_0);
		if (string.IsNullOrEmpty(text))
		{
			text = "//table";
		}
		HtmlNodeCollection htmlNodeCollection = htmlNode.SelectNodes(text);
		int num;
		if (htmlNodeCollection != null)
		{
			num = 0;
			if (NyHoYIQgaETtqJKM6QLO == null)
			{
				goto IL_004f;
			}
			goto IL_00be;
		}
		goto IL_0111;
		IL_010b:
		return StepExecuteResult.Success;
		IL_0111:
		return StepExecuteResult.Failed("未能提取到HTML表格");
		IL_00be:
		switch (num)
		{
		case 1:
			goto IL_010b;
		}
		goto IL_004f;
		IL_004f:
		if (htmlNodeCollection.Count != 0)
		{
			if (!htmlNodeCollection.Any(_003C_003Ec.XorS2XdxrCk ?? (_003C_003Ec.XorS2XdxrCk = _003C_003Ec.wukS21B7sWd.nSsS2k9MjWg)))
			{
				object paramVariableObject = XActionHelper.GetParamVariableObject(A21gSSot1CJ, actionStep_0, actionExecuteContext_0);
				if (paramVariableObject != null)
				{
					IList<kb843oovjq32W19GZWI.Vkhp7Nu33cm2VQqjACu> ilist_ = kb843oovjq32W19GZWI.rNkgxIxZvGF(true, htmlNodeCollection);
					if (paramVariableObject is ISheet isheet_)
					{
						OergvF1VohI(ilist_, isheet_);
						num = 1;
						if (!xVxl54QgrUk67LCFrPkj())
						{
							goto IL_00be;
						}
					}
					else
					{
						if (!(paramVariableObject is _Worksheet worksheet_))
						{
							throw new InvalidOperationException("不是合法的工作表对象。\n支持Excel读写模块或Excel对象模块输出的工作表对象。");
						}
						uJ8gvOnan8a(ilist_, worksheet_);
					}
					goto IL_010b;
				}
				return StepExecuteResult.Failed("未指定要写入的工作表对象。");
			}
			return StepExecuteResult.Failed("提取到的不是HTML表格元素。");
		}
		goto IL_0111;
	}

	private void uJ8gvOnan8a(IList<kb843oovjq32W19GZWI.Vkhp7Nu33cm2VQqjACu> ilist_2, _Worksheet _Worksheet_0)
	{
		int num = 0;
		foreach (kb843oovjq32W19GZWI.Vkhp7Nu33cm2VQqjACu item in ilist_2)
		{
			foreach (kb843oovjq32W19GZWI.joiUu3uEmf6U68YZLBP item2 in item.Rows)
			{
				int num2 = num + item2.bNISHkjLknn();
				foreach (kb843oovjq32W19GZWI.Wd8OdFu0NN5Y6L7GOe4 item3 in item2.QfiSHH9rdLE())
				{
					_Worksheet_0.Cells[num2, item3.wHdSHmdyL5F()] = item3.Content;
					if (item3.sZYSHdS9xxG())
					{
						((dynamic)_Worksheet_0.Cells[num2, item3.wHdSHmdyL5F()]).Font.Bold = true;
					}
					if (item3.pQKSH4hKEJO() > 1 || item3.WqYSHQvOXkQ() > 1)
					{
						_Worksheet_0.Range[(dynamic)_Worksheet_0.Cells[num2, item3.wHdSHmdyL5F()], (dynamic)_Worksheet_0.Cells[num2 + item3.pQKSH4hKEJO() - 1, item3.wHdSHmdyL5F() + item3.WqYSHQvOXkQ() - 1]].Merge();
					}
				}
			}
			num += item.Rows.Count + 2;
		}
	}

	private void OergvF1VohI(IList<kb843oovjq32W19GZWI.Vkhp7Nu33cm2VQqjACu> ilist_2, ISheet isheet_0)
	{
		ICellStyle cellStyle = isheet_0.Workbook.CreateCellStyle();
		IFont font = isheet_0.Workbook.CreateFont();
		font.IsBold = true;
		cellStyle.SetFont(font);
		int num = 0;
		foreach (kb843oovjq32W19GZWI.Vkhp7Nu33cm2VQqjACu item in ilist_2)
		{
			foreach (kb843oovjq32W19GZWI.joiUu3uEmf6U68YZLBP item2 in item.Rows)
			{
				int num2 = num + item2.bNISHkjLknn();
				foreach (kb843oovjq32W19GZWI.Wd8OdFu0NN5Y6L7GOe4 item3 in item2.QfiSHH9rdLE())
				{
					ICell cell = isheet_0.SetCellValue(num2, item3.wHdSHmdyL5F(), item3.Content);
					if (item3.sZYSHdS9xxG())
					{
						cell.CellStyle = cellStyle;
					}
					if (item3.pQKSH4hKEJO() > 1 || item3.WqYSHQvOXkQ() > 1)
					{
						isheet_0.AddMergedRegion(new CellRangeAddress(num2, num2 + item3.pQKSH4hKEJO() - 1, item3.wHdSHmdyL5F(), item3.wHdSHmdyL5F() + item3.WqYSHQvOXkQ() - 1));
					}
				}
			}
			num += item.Rows.Count + 2;
		}
	}

	private HtmlNode EukgvUd3J2I(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0)
	{
		object paramValue = XActionHelper.GetParamValue(akDgvzH1lfS, actionStep_0, actionExecuteContext_0, false, true);
		XActionHelper.GetTextParamValue(pFIgStaN0kx, actionStep_0, actionExecuteContext_0);
		HtmlNode htmlNode;
		if (paramValue is HtmlNode)
		{
			htmlNode = paramValue as HtmlNode;
		}
		else
		{
			string text = Convert.ToString(VariableHelper.ConvertToType(VarType.Text, paramValue));
			if (string.IsNullOrEmpty(text))
			{
				throw new InvalidDataException("源html为空。");
			}
			HtmlDocument htmlDocument = null;
			if (text.StartsWith("http", StringComparison.OrdinalIgnoreCase))
			{
				HtmlWeb htmlWeb = new HtmlWeb();
				string textParamValue = XActionHelper.GetTextParamValue(lMegSw9oFHu, actionStep_0, actionExecuteContext_0);
				if (!string.IsNullOrWhiteSpace(textParamValue))
				{
					if (string.Equals(textParamValue, "auto", StringComparison.OrdinalIgnoreCase))
					{
						HtmlDocument htmlDocument2 = new HtmlWeb().Load(text);
						htmlWeb.OverrideEncoding = htmlDocument2.Encoding;
					}
					else
					{
						htmlWeb.OverrideEncoding = Encoding.GetEncoding(textParamValue);
					}
				}
				htmlDocument = htmlWeb.Load(text);
			}
			else if (text.IsValidFilePath())
			{
				text = System.IO.File.ReadAllText(text);
				htmlDocument = new HtmlDocument();
				htmlDocument.LoadHtml(text);
			}
			else
			{
				htmlDocument = new HtmlDocument();
				htmlDocument.LoadHtml(text);
			}
			htmlNode = htmlDocument.DocumentNode;
		}
		if (htmlNode == null)
		{
			throw new InvalidDataException("源内容为空。");
		}
		return htmlNode;
	}

	private StepExecuteResult RB3gvlxOVxx(ActionStep actionStep_0, ActionExecuteContext actionExecuteContext_0, XAction xaction_0, string string_2)
	{
		_003C_003Ec__DisplayClass46_0 _003C_003Ec__DisplayClass46_ = new _003C_003Ec__DisplayClass46_0();
		HtmlNode htmlNode = EukgvUd3J2I(actionStep_0, actionExecuteContext_0, xaction_0);
		string textParamValue = XActionHelper.GetTextParamValue(pFIgStaN0kx, actionStep_0, actionExecuteContext_0);
		string textParamValue2 = XActionHelper.GetTextParamValue(uk6gSgwCmXs, actionStep_0, actionExecuteContext_0);
		string textParamValue3 = XActionHelper.GetTextParamValue(K4ogSL4SSe3, actionStep_0, actionExecuteContext_0);
		_003C_003Ec__DisplayClass46_.yYCS2pu5qA5 = XActionHelper.GetTextParamValue(JAYgSvVA6xm, actionStep_0, actionExecuteContext_0);
		XActionHelper.OutputResult(Cm8gSuwpk6e, actionStep_0, actionExecuteContext_0, htmlNode, xaction_0);
		int num;
		HtmlNode htmlNode2 = default(HtmlNode);
		HtmlNodeCollection htmlNodeCollection = default(HtmlNodeCollection);
		if (XActionHelper.IsOutputParamSetted(BqZgS2Bs85W.Key, actionStep_0) || XActionHelper.IsOutputParamSetted(BaseMultiOperationStep.YBvghAou5MC.Key, actionStep_0))
		{
			if (string.IsNullOrEmpty(textParamValue))
			{
				num = 5;
				if (NyHoYIQgaETtqJKM6QLO != null)
				{
					goto IL_024e;
				}
			}
			else if (string.IsNullOrEmpty(textParamValue2) || textParamValue2 == "single")
			{
				htmlNode2 = htmlNode.SelectSingleNode(textParamValue);
				if (htmlNode2 == null)
				{
					if (textParamValue != textParamValue.ToLower())
					{
						htmlNode2 = htmlNode.SelectSingleNode(textParamValue.ToLower());
					}
					if (htmlNode2 == null)
					{
						XActionHelper.OutputResult(BqZgS2Bs85W, actionStep_0, actionExecuteContext_0, "", xaction_0);
						return StepExecuteResult.Failed("节点不存在：" + textParamValue);
					}
				}
				if (textParamValue3 == "InnerHtml")
				{
					XActionHelper.OutputResult(BqZgS2Bs85W, actionStep_0, actionExecuteContext_0, htmlNode2.InnerHtml?.Trim(), xaction_0);
					goto IL_04dc;
				}
				num = 4;
				if (NyHoYIQgaETtqJKM6QLO != null)
				{
					goto IL_01d7;
				}
			}
			else
			{
				htmlNodeCollection = htmlNode.SelectNodes(textParamValue);
				if (htmlNodeCollection.HasData())
				{
					goto IL_036d;
				}
				num = 0;
				if (NyHoYIQgaETtqJKM6QLO != null)
				{
					goto IL_01d7;
				}
			}
			goto IL_01db;
		}
		goto IL_04dc;
		IL_024e:
		XActionHelper.OutputResult(BqZgS2Bs85W, actionStep_0, actionExecuteContext_0, htmlNode2, xaction_0);
		goto IL_04dc;
		IL_01d7:
		int num2 = default(int);
		num = num2;
		goto IL_01db;
		IL_01db:
		while (true)
		{
			switch (num)
			{
			case 4:
				break;
			default:
				goto end_IL_01db;
			case 3:
				goto IL_024e;
			case 5:
				return StepExecuteResult.Failed("XPath为空。");
			case 1:
			case 2:
			case 6:
				goto IL_04dc;
			}
			switch (textParamValue3)
			{
			case "Node":
				goto IL_024e;
			case "Attribute":
				goto IL_0263;
			case "OuterHtml":
				goto IL_0315;
			case "InnerText":
				goto IL_033b;
			}
			num = 1;
			if (NyHoYIQgaETtqJKM6QLO == null)
			{
				continue;
			}
			goto IL_01d7;
			IL_0315:
			XActionHelper.OutputResult(BqZgS2Bs85W, actionStep_0, actionExecuteContext_0, htmlNode2.OuterHtml?.Trim(), xaction_0);
			goto IL_04dc;
			IL_033b:
			XActionHelper.OutputResult(BqZgS2Bs85W, actionStep_0, actionExecuteContext_0, htmlNode2.InnerText?.Trim(), xaction_0);
			goto IL_04dc;
			continue;
			end_IL_01db:
			break;
		}
		if (textParamValue != textParamValue.ToLower())
		{
			htmlNodeCollection = htmlNode.SelectNodes(textParamValue.ToLower());
		}
		if (!htmlNodeCollection.HasData())
		{
			XActionHelper.OutputResult(BqZgS2Bs85W, actionStep_0, actionExecuteContext_0, "", xaction_0);
			return StepExecuteResult.Failed("节点不存在：" + textParamValue);
		}
		goto IL_036d;
		IL_036d:
		switch (textParamValue3)
		{
		case "Node":
			XActionHelper.OutputResult(BqZgS2Bs85W, actionStep_0, actionExecuteContext_0, htmlNodeCollection, xaction_0);
			break;
		case "Attribute":
			if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass46_.yYCS2pu5qA5))
			{
				XActionHelper.OutputResult(BqZgS2Bs85W, actionStep_0, actionExecuteContext_0, "", xaction_0);
				return StepExecuteResult.Failed("要提取的属性名称为空");
			}
			XActionHelper.OutputResult(BqZgS2Bs85W, actionStep_0, actionExecuteContext_0, htmlNodeCollection.Select(_003C_003Ec__DisplayClass46_.KntS2rZjcaf).ToList(), xaction_0);
			break;
		case "OuterHtml":
			XActionHelper.OutputResult(BqZgS2Bs85W, actionStep_0, actionExecuteContext_0, htmlNodeCollection.Select(_003C_003Ec.lZ7S2xGkw7B ?? (_003C_003Ec.lZ7S2xGkw7B = _003C_003Ec.wukS21B7sWd.tBiS2HnTqL5)).ToList(), xaction_0);
			break;
		case "InnerText":
			XActionHelper.OutputResult(BqZgS2Bs85W, actionStep_0, actionExecuteContext_0, htmlNodeCollection.Select(_003C_003Ec.NEbS2KC0Ygt ?? (_003C_003Ec.NEbS2KC0Ygt = _003C_003Ec.wukS21B7sWd.R47S2syZCTv)).ToList(), xaction_0);
			break;
		case "InnerHtml":
			XActionHelper.OutputResult(BqZgS2Bs85W, actionStep_0, actionExecuteContext_0, htmlNodeCollection.Select(_003C_003Ec.Da3S2m2U11V ?? (_003C_003Ec.Da3S2m2U11V = _003C_003Ec.wukS21B7sWd.uCGS2GQTSS4)).ToList(), xaction_0);
			break;
		}
		goto IL_04dc;
		IL_04dc:
		return StepExecuteResult.Success;
		IL_0263:
		if (string.IsNullOrEmpty(_003C_003Ec__DisplayClass46_.yYCS2pu5qA5))
		{
			XActionHelper.OutputResult(BqZgS2Bs85W, actionStep_0, actionExecuteContext_0, "", xaction_0);
			return StepExecuteResult.Failed("要提取的属性名称为空");
		}
		if (htmlNode2.HasAttributes && htmlNode2.Attributes.Contains(_003C_003Ec__DisplayClass46_.yYCS2pu5qA5))
		{
			XActionHelper.OutputResult(BqZgS2Bs85W, actionStep_0, actionExecuteContext_0, htmlNode2.Attributes[_003C_003Ec__DisplayClass46_.yYCS2pu5qA5].Value?.Trim(), xaction_0);
			goto IL_04dc;
		}
		XActionHelper.OutputResult(BqZgS2Bs85W, actionStep_0, actionExecuteContext_0, "", xaction_0);
		return StepExecuteResult.Failed("要提取的属性" + _003C_003Ec__DisplayClass46_.yYCS2pu5qA5 + "不存在");
	}

	static HtmlExtractStep()
	{
		akDgvzH1lfS = new StepInParamDef
		{
			Key = "source",
			Name = "源HTML",
			Description = "原始HTML内容，或网址，或根节点对象",
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text,
			DefaultValue = "",
			IsMultiLine = true,
			IsRequired = true
		};
		lMegSw9oFHu = new StepInParamDef
		{
			Key = "encoding",
			Name = "网页编码类型",
			Description = "通过网址加载内容时，使用指定的编码。留空时默认为UTF8。",
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text,
			DefaultValue = "",
			IsMultiLine = false,
			IsRequired = false,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("auto", "自动检测 (加载两次)"),
				new SelectionItem("gb2312", "GB2312编码"),
				new SelectionItem("utf-8", "UTF8编码")
			}
		};
		pFIgStaN0kx = new StepInParamDef
		{
			Key = "xpath",
			Name = "节点XPath",
			Description = "内容的XPath，详细说明请参考文档",
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text,
			DefaultValue = "",
			IsMultiLine = false,
			IsRequired = true
		};
		uk6gSgwCmXs = new StepInParamDef
		{
			Key = "selectTarget",
			Name = "提取方式",
			Description = "提取单个节点还是符合条件的所有节点。",
			Type = VarType.Enum,
			DefaultValue = "single",
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("single", "第一个符合条件的节点"),
				new SelectionItem("all", "所有符合条件的节点")
			}
		};
		K4ogSL4SSe3 = new StepInParamDef
		{
			Key = "returnType",
			Name = "提取内容类型",
			Description = "要提取的节点信息。",
			Type = VarType.Enum,
			DefaultValue = "InnerHtml",
			VariableMode = ParamVariableMode.Input,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("InnerHtml", "innerHtml 内部HTML"),
				new SelectionItem("InnerText", "innerText 内部文本"),
				new SelectionItem("OuterHtml", "outerHTML 节点全部HTML"),
				new SelectionItem("Attribute", "Attribute 节点的某个属性"),
				new SelectionItem("Node", "节点对象")
			}
		};
		JAYgSvVA6xm = new StepInParamDef
		{
			Key = "attribute",
			Name = "属性名称",
			Description = "仅在提取节点属性时有效。指定属性的名称。",
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text,
			DefaultValue = "",
			IsMultiLine = false,
			IsRequired = false
		};
		A21gSSot1CJ = new StepInParamDef
		{
			Key = "writeToSheet",
			Name = "写入工作表对象",
			Description = "将提取到的表格内容写入工作表对象中。",
			VariableMode = ParamVariableMode.UseVarOnly,
			Type = VarType.Object,
			IsMultiLine = false
		};
		BqZgS2Bs85W = new StepOutParamDef
		{
			Key = "value",
			Name = "提取值",
			Description = "提取的内容。请确保结果类型和变量类型匹配。",
			Type = VarType.Any
		};
		Cm8gSuwpk6e = new StepOutParamDef
		{
			Key = "rootNode",
			Name = "根节点",
			Description = "整个HTML源内容对应的HtmlNode节点对象，可用于后续处理使用。",
			Type = VarType.Any
		};
	}

	internal static bool xVxl54QgrUk67LCFrPkj()
	{
		return NyHoYIQgaETtqJKM6QLO == null;
	}
}
