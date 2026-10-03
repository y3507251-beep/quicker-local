using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;
using System.Web;
using Quicker.Common;
using Quicker.Domain.Actions.X.BuiltinRunners;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Actions.X.Variables;
using Quicker.Public.Actions;
using Quicker.Utilities;
using Quicker.Utilities.Ext;

namespace Quicker.Domain.Actions.Debugging;

public class HtmlActionLogger : IActionLogger
{
	private readonly string UX9t5D7XCFy = "";

	private readonly LimitLengthStringBuilder lOCt5dlc35T = new LimitLengthStringBuilder(10000, 102400000);

	private readonly ActionItem Swvt5o8crAC;

	private readonly ActionExecuteContext mjjt5TD9ctn;

	private Stopwatch Nsvt5MWcKDv = new Stopwatch();

	internal static HtmlActionLogger qYfRpAQffgrqASV0bfSM;

	public HtmlActionLogger(ActionItem action, ActionExecuteContext context)
	{
		Swvt5o8crAC = action;
		mjjt5TD9ctn = context;
		UX9t5D7XCFy = OIgt5moKpmW();
		Nsvt5MWcKDv.Start();
	}

	private string OIgt5moKpmW()
	{
		string path = "quicker_" + eDit5KvxaNL(Swvt5o8crAC.Title) + "_" + DateTime.Now.ToString("hhmmss-fff", CultureInfo.InvariantCulture) + "_log.html";
		return Path.Combine(Path.GetTempPath(), path);
	}

	private string eDit5KvxaNL(string string_1)
	{
		return string_1.ToValidFileName();
	}

	private void RSBt5xFb1wQ(string string_1)
	{
		lOCt5dlc35T.Append(string_1);
	}

	private void XLUt5r4pEYG(string string_1)
	{
		string text = HttpUtility.HtmlEncode(string_1);
		lOCt5dlc35T.Append(text);
	}

	public void AddRawContent(string contentHtml)
	{
		lOCt5dlc35T.Append(contentHtml);
	}

	public void BeginFile()
	{
		RSBt5xFb1wQ("<html lang='zh-CN'><head><title>");
		XLUt5r4pEYG(Swvt5o8crAC.Title + " " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
		RSBt5xFb1wQ("</title>");
		RSBt5xFb1wQ("\r\n<style>\r\n        body {\r\n            font-size: 14px;\r\n            padding: 10px;\r\n            color: #666;\r\n        }\r\n\r\n        .curr-time {\r\n            color: #A0A0A0;\r\n            display: inline-block;\r\n            margin-right: 5px;\r\n            font-size: 0.75em;\r\n            font-weight: normal;\r\n        }\r\n\r\n        .message-info {\r\n            color: #999999;\r\n        }\r\n\r\n        .message-warning {\r\n            color: chocolate;\r\n        }\r\n\r\n        .message-error {\r\n            color: red;\r\n        }\r\n\r\n        .message {\r\n            margin: 2px;\t\t\t\r\n\t\t\twhite-space: pre;\r\n            font-size:0.85em;\r\n        }\r\n\r\n        .step-group {\r\n            /*margin: 5px 0 5px 5px;\r\n            padding: 3px 0px 3px 10px;\r\n            border-left: 1px dashed #e0e0e0;*/\r\n        }\r\n        .group-btns{\r\n            margin: 0 0 0 5px;\r\n        }\r\n\r\n        .step {\r\n            margin: 5px 0px 5px 5px;\r\n            padding: 2px 0px 2px 5px;\r\n            border-left: 1px solid #e0e0e0;\r\n\t\t\twidth: fit-content;\r\n        }\r\n\r\n        .step.disabled{\r\n            opacity: 0.5;\r\n        }   \r\n\r\n        .step:hover {\r\n            border-left-color: rgb(255, 186, 62);\r\n        }\r\n\r\n        .step-content {\r\n            padding-left: 10px;\r\n        }\r\n\r\n        .step-header {\r\n            font-weight: bold;\r\n            color: #666;\r\n            cursor: pointer;\r\n            padding: 3px;\r\n\t\t\twhite-space: pre;\r\n        }\r\n\r\n        .step.collapsed .step-header {\r\n            background-color: #E0E0E0;\r\n        }\r\n        .step.collapsed .step-content{\r\n            display: none;\r\n        }\r\n\r\n        .step-header:hover{\r\n            background:#F8F8F8;\r\n        }\r\n\r\n        .step-note {\r\n            font-weight: normal;\r\n            display: inline-block;\r\n            font-size: 0.8em;\r\n            margin-left: 5px;\r\n\t\t\tvertical-align: top;\r\n        }\r\n\r\n        .input-name,\r\n        .output-name {\r\n            display: inline-block;\r\n            padding: 0 5px;\r\n        }\r\n\r\n        .step-input,\r\n        .step-output {\r\n            padding: 3px 5px;\r\n            font-size: 0.85em;\r\n            max-height: 3em;\r\n            white-space: no-wrap;;\r\n\t\t\toverflow:hidden;\r\n        }\r\n\r\n        .step-input:hover, .step-output:hover{\r\n                max-height: 300px;\r\n                overflow:auto;\r\n        }\r\n\r\n        \r\n\r\n        .input-value,\r\n        .output-value {\r\n            color: #B0B0B0;\r\n            font-size: 0.9em;\r\n\t\t\twhite-space: pre;\r\n        }\r\n\r\n        .value{\r\n            \r\n            overflow:auto;\r\n        }\r\n\r\n        .small{\r\n            font-size: 0.85em;\r\n        }\r\n        .step-id{\r\n            color:#e3a664;\r\n            font-weight:normal;\r\n            display:inline-block;\r\n            margin-right:4px;\r\n        }\r\n        .step-id:hover{\r\n            font-weight:bold;\r\n        }\r\n        .origin-input{\r\n            cursor:pointer;\r\n            opacity: 0.5;\r\n        }\r\n        .min-button{\r\n            background: white;\r\n            min-width: 30px;\r\n            border:1px solid #B0B0B0;\r\n            cursor:pointer;\r\n        }\r\n        .min-button:hover{\r\n            background-color:#F0F0F0;\r\n        }\r\n        .invisible-chars{\r\n            color:#be3615;\r\n            opacity:0.5;\r\n        }\r\n    </style>\r\n");
		RSBt5xFb1wQ("</head><body>");
		RSBt5xFb1wQ("<!--本功能部分代码由@Cesaryuan贡献，感谢！-->");
		RSBt5xFb1wQ("\r\n<div style='margin-bottom:10px;margin-left: 5px;'>\r\n        <button id='collapseAll'>折叠全部</button>\r\n        <button id='expandAll'>展开全部</button>\r\n</div>\r\n");
	}

	public void EndFile()
	{
		RSBt5xFb1wQ("\r\n<script>\r\n        var coll = document.getElementsByClassName('step-header');\r\n            var i;\r\n\r\n            for (i = 0; i < coll.length; i++)\r\n            {\r\n                coll[i].addEventListener('click', function() {\r\n                    // this.classList.toggle('active');\r\n                    var parent = this.parentElement;\r\n                    if (parent.classList.contains('collapsed'))\r\n                    {\r\n                        parent.classList.remove('collapsed');\r\n                    }\r\n                    else\r\n                    {\r\n                        parent.classList.add('collapsed');\r\n                    }\r\n                });\r\n            }\r\n\r\n        document.getElementById('collapseAll').addEventListener('click', function(){\r\n            var nodes = document.getElementsByClassName('step');\r\n            for(i =0; i<nodes.length; i++){\r\n                nodes[i].classList.add('collapsed');\r\n            }\r\n        });\r\n\r\n        document.getElementById('expandAll').addEventListener('click', function(){\r\n            var nodes = document.getElementsByClassName('step');\r\n            for(i =0; i<nodes.length; i++){\r\n                nodes[i].classList.remove('collapsed');\r\n            }\r\n        });\r\n\r\n        // 折叠所有子程序和内部节点\r\n         let spNodes = document.getElementsByClassName('sys_subprogram');\r\n            //for(i =0; i<spNodes.length; i++){\r\n            //    spNodes[i].classList.add('collapsed');                \r\n            //}\r\n            document.querySelectorAll('.sys_subprogram .step').forEach(ele => {ele.classList.add('collapsed')});\r\n        \r\n\r\n        function collapseGroup(evt){\r\n            var groupEle = evt.target.parentElement.parentElement;\r\n            groupEle.querySelectorAll('.step').forEach(ele => {ele.classList.add('collapsed')});\r\n        }   \r\n\r\n        function expandGroup(evt){\r\n             var groupEle = evt.target.parentElement.parentElement;\r\n            groupEle.querySelectorAll('.step').forEach(ele => {ele.classList.remove('collapsed')});\r\n        }\r\n\r\n        \r\n\r\n        \r\n            </script>\r\n                ");
        RSBt5xFb1wQ("<script>document.querySelectorAll('.step-id').forEach(function(el){el.addEventListener('click',function(e){window.location.href='quicker:findstep:" + Swvt5o8crAC.Id + ";;'+this.textContent;e.stopPropagation();});});document.querySelectorAll('.collapse-group').forEach(function(el){el.addEventListener('click',collapseGroup);});document.querySelectorAll('.expand-group').forEach(function(el){el.addEventListener('click',expandGroup);});</script>");
		RSBt5xFb1wQ("</body></html>");
	}

	public void BeginStepGroup(string note, int childCount)
	{
		RSBt5xFb1wQ("<div class='step-group'>");
		if (childCount > 1)
		{
			RSBt5xFb1wQ("<div class='group-btns'><button class='collapse-group min-button' title='折叠子节点'>-</button> <button class='expand-group min-button' title='展开子节点' >+</button></div>");
		}
		if (!string.IsNullOrEmpty(note))
		{
			RSBt5xFb1wQ("");
		}
	}

	public void EndStepGroup()
	{
		RSBt5xFb1wQ("</div>");
	}

	private static string c6Ut5pWw4n5(ActionStep actionStep_0)
	{
		StringBuilder stringBuilder = new StringBuilder(20);
		stringBuilder.Append("step ");
		stringBuilder.Append(actionStep_0.StepRunnerKey.Replace(":", "_"));
		if (actionStep_0.Disabled)
		{
			stringBuilder.Append(" disabled");
		}
		return stringBuilder.ToString();
	}

	public void BeginStep(ActionStep step, string stepId)
	{
		IStepRunner runner = StepRunnerRegistry.GetRunner(step.StepRunnerKey);
		if (runner == null)
		{
			LogError("您的Quicker版本太旧了，不支持此动作。步骤类型：" + step.StepRunnerKey);
			return;
		}
		string text = (string.IsNullOrEmpty(step.Note) ? runner.GetSummary(step) : step.Note);
		string text2 = runner.Name;
		if (runner is SubProgramStep)
		{
			text2 = text2 + "“" + SubProgramStep.GetSubProgramInfo(step).name + "”";
		}
		if (string.IsNullOrEmpty(text))
		{
			goto IL_00af;
		}
		text = text.Replace("\r\n", " ");
		int num = 0;
		if (qYfRpAQffgrqASV0bfSM != null)
		{
			int num2 = default(int);
			num = num2;
		}
		goto IL_0178;
		IL_00af:
		RSBt5xFb1wQ("<div class='" + c6Ut5pWw4n5(step) + "' title='" + stepId + " " + HttpUtility.HtmlEncode(text2) + "  " + HttpUtility.HtmlEncode(text) + "'>");
		RSBt5xFb1wQ("<div class='step-header'>");
		zhxt55Wy09k();
		Xiwt5QhBFJ9("span", "step-id", stepId);
		Xiwt5QhBFJ9("span", "step-title", text2);
		if (string.IsNullOrEmpty(step.Note))
		{
			Xiwt5QhBFJ9("span", "step-note", text);
			num = 0;
			if (!ACt4MLQfbujiQ6dbGXnr())
			{
				goto IL_0178;
			}
		}
		else
		{
			Xiwt5QhBFJ9("span", "step-note", text);
		}
		goto IL_01a4;
		IL_01a4:
		RSBt5xFb1wQ("</div>");
		RSBt5xFb1wQ("<div class='step-content'>");
		return;
		IL_0178:
		switch (num)
		{
		case 1:
			goto IL_01a4;
		}
		goto IL_00af;
	}

	public void EndStep()
	{
		RSBt5xFb1wQ("</div>");
		RSBt5xFb1wQ("</div>");
	}

	public void BeginRepeat(string note)
	{
		RSBt5xFb1wQ("<div class='step'>");
		RSBt5xFb1wQ("<div class='step-header'>");
		zhxt55Wy09k();
		Xiwt5QhBFJ9("span", "step-title", note);
		RSBt5xFb1wQ("</div>");
		RSBt5xFb1wQ("<div class='step-content'>");
	}

	public void EndRepeat()
	{
		RSBt5xFb1wQ("</div>");
		RSBt5xFb1wQ("</div>");
	}

	public void LogLoadState(string varKey, string value)
	{
		RSBt5xFb1wQ("<div class='step-input' >[状态]");
		Xiwt5QhBFJ9("span", "input-name", varKey, "变量名");
		DiNt5jExRGY("span", "value input-value", value, "参数值，点击取消高度限制");
		RSBt5xFb1wQ("</div>");
	}

	public void LogInput(StepInParamDef inputParam, object paramValue, string paramExpression, ActionStep step)
	{
		RSBt5xFb1wQ("<div class='step-input' >[in]");
		Xiwt5QhBFJ9("span", "input-name", inputParam.Name, "参数名");
		if (step.InputParams.ContainsKey(inputParam.Key))
		{
			if (!string.IsNullOrEmpty(step.InputParams[inputParam.Key].VarKey))
			{
				RSBt5xFb1wQ("<span class='value input-value origin-input' title='变量'>【变量 " + HttpUtility.HtmlEncode(step.InputParams[inputParam.Key].VarKey) + "】</span>");
			}
			else
			{
				RSBt5xFb1wQ("<span class='value input-value origin-input' title='" + HttpUtility.HtmlEncode(step.InputParams[inputParam.Key].Value) + "'>【值/表达式】</span>");
			}
		}
		else
		{
			RSBt5xFb1wQ("<span class='value input-value origin-input' title='无输入，使用默认值'>【无输入】</span>");
		}
		DiNt5jExRGY("span", "value input-value", paramValue, "参数值，点击取消高度限制");
		RSBt5xFb1wQ("</div>");
	}

	public void LogOutput(StepOutParamDef outputParam, string varName, object paramValue)
	{
		RSBt5xFb1wQ("<div class='step-output'>[out]");
		Xiwt5QhBFJ9("span", "output-name", outputParam?.Name + "=>" + varName);
		DiNt5jExRGY("span", "value output-value", paramValue);
		RSBt5xFb1wQ("</div>");
	}

	public void LogInfo(string message)
	{
		hoht5n3HGcu("div", "message message-info", message);
	}

	private void ibot5BKV1gl(string string_1)
	{
		hcit54B5dxi("div", "message message-info", string_1);
	}

	public void LogFileName()
	{
		ibot5BKV1gl("Log文件路径：" + UX9t5D7XCFy + " <a href='quicker:selectinexplorer:" + HttpUtility.UrlEncode(UX9t5D7XCFy) + "' title='在资源管理器中找到文件'>定位文件</a>&nbsp;<a href='quicker:copyfile:" + HttpUtility.UrlEncode(UX9t5D7XCFy) + "' title='将文件复制到剪贴板'>复制文件</a>&nbsp;<a href='quicker:uploaddebugfile:" + HttpUtility.UrlEncode(UX9t5D7XCFy) + "' title='上传到网络，并将网址复制到剪贴板。用于将调试文件快速分享给其他人。上传的文件将可以被任何人访问，请避免上传可能包含隐私信息的文件。'>上传并复制网址</a>");
	}

	public void LogWarning(string message)
	{
		hoht5n3HGcu("div", "message message-warning", message);
	}

	public void LogError(string message)
	{
		hoht5n3HGcu("div", "message message-error", message);
	}

	public void LogError(string message, Exception exception)
	{
		hoht5n3HGcu("div", "message message-error", "异常：" + message);
		Xiwt5QhBFJ9("div", "message message-info small", exception.StackTrace);
	}

	private void Xiwt5QhBFJ9(string string_1, string string_2, string string_3, string string_4 = "")
	{
		RSBt5xFb1wQ("<" + string_1 + " class='" + string_2 + "' title='" + HttpUtility.HtmlEncode(string_4) + "'>");
		XLUt5r4pEYG(string_3);
		RSBt5xFb1wQ("</" + string_1 + ">");
	}

	private void DiNt5jExRGY(string string_1, string string_2, object object_0, string string_3 = "")
	{
		RSBt5xFb1wQ("<" + string_1 + " class='" + string_2 + "' title='" + HttpUtility.HtmlEncode(string_3) + "'>");
		string text = ConvertValue(object_0);
		if (text.Length > 20000)
		{
			string text2 = Path.Combine(Path.GetTempPath(), "quicker_action_debug_" + Guid.NewGuid().ToString("N") + ".txt");
			if (!ACt4MLQfbujiQ6dbGXnr())
			{
				switch (0)
				{
				}
			}
			File.WriteAllText(text2, text);
			lOCt5dlc35T.Append("内容较多，已写入文件：<a href='file:///" + text2 + "'>" + text2 + "</a>");
		}
		else
		{
			string text3 = HttpUtility.HtmlEncode(text)?.Replace("⍀r", "<span class='invisible-chars'>\\r</span>").Replace("⍀n", "<span class='invisible-chars'>\\n</span>").Replace("⍀t", "<span class='invisible-chars'>\\t</span>");
			lOCt5dlc35T.Append(text3);
		}
		RSBt5xFb1wQ("</" + string_1 + ">");
	}

	public string ConvertValue(object paramValue)
	{
		if (paramValue != null)
		{
			if (paramValue is string input)
			{
				return input.ConvertInvisibleChars();
			}
			IList<string> list = paramValue as IList<string>;
			if (ACt4MLQfbujiQ6dbGXnr())
			{
				switch (0)
				{
				}
			}
			if (list != null)
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < list.Count; i++)
				{
					if (i > 0)
					{
						stringBuilder.AppendLine();
					}
					stringBuilder.Append($"{i}:{list[i]}".ConvertInvisibleChars());
				}
				return stringBuilder.ToString();
			}
			return VariableHelper.ConvertToType(VarType.Text, paramValue).ToString();
		}
		return "*NULL*";
	}

	private void hoht5n3HGcu(string string_1, string string_2, string string_3, string string_4 = "")
	{
		RSBt5xFb1wQ("<" + string_1 + " class='" + string_2 + "'  title='" + HttpUtility.HtmlEncode(string_4) + "'>");
		XLUt5r4pEYG(string_3);
		RSBt5xFb1wQ("</" + string_1 + ">");
	}

	private void hcit54B5dxi(string string_1, string string_2, string string_3)
	{
		RSBt5xFb1wQ("<" + string_1 + " class='" + string_2 + "'>");
		AddRawContent(string_3);
		RSBt5xFb1wQ("</" + string_1 + ">");
	}

	private void zhxt55Wy09k()
	{
		RSBt5xFb1wQ(string.Format("<span class='curr-time' title='{0}'>{1}</span>", DateTime.Now.ToString("HHmmss,fff", CultureInfo.InvariantCulture), Nsvt5MWcKDv.ElapsedMilliseconds));
	}

	public void Flush()
	{
		try
		{
			File.AppendAllText(UX9t5D7XCFy, lOCt5dlc35T.ToString(), Encoding.UTF8);
			lOCt5dlc35T.Clear();
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("写入动作日志异常：" + ex.Message);
		}
	}

	public void OpenLogFile()
	{
		Flush();
		try
		{
			Process.Start(UX9t5D7XCFy);
		}
		catch (Exception ex)
		{
			AppHelper.ShowWarning("打开日志文件出错：" + ex.Message);
		}
	}

	internal static bool ACt4MLQfbujiQ6dbGXnr()
	{
		return qYfRpAQffgrqASV0bfSM == null;
	}
}
