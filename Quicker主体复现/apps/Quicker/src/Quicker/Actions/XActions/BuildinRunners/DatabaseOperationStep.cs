using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Dapper;
using FontAwesome5;
using MySqlConnector;
using Org.BouncyCastle.Security;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Domain.Actions.X.Variables;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;

namespace Quicker.Actions.XActions.BuildinRunners;

public class DatabaseOperationStep : IStepRunner, IStepRunningInfo
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass55_0
	{
		public ActionStep W8FSIDp8D10;

		public ActionExecuteContext vLbSIdlNYa2;

		public DatabaseOperationStep ny1SIoqN0Wc;

		public XAction GI3SITIulkj;

		internal static _003C_003Ec__DisplayClass55_0 fAKOKvWoBA102W898GM1;

		internal (bool isSuccess, string message, ActionStopFlag failReason) nydSI54hoRe()
		{
			string textParamValue = XActionHelper.GetTextParamValue(Nymg1LJGLSJ, W8FSIDp8D10, vLbSIdlNYa2);
			string textParamValue2 = XActionHelper.GetTextParamValue(JNFg1v2ko42, W8FSIDp8D10, vLbSIdlNYa2);
			string textParamValue3 = XActionHelper.GetTextParamValue(nh8g1SABtjs, W8FSIDp8D10, vLbSIdlNYa2);
			object paramValue = XActionHelper.GetParamValue(NMdg12QJ3W3, W8FSIDp8D10, vLbSIdlNYa2);
			long integerParamValue = XActionHelper.GetIntegerParamValue(Q3Ig1uUCIYF, W8FSIDp8D10, vLbSIdlNYa2);
			int? commandTimeout = ((integerParamValue <= 0L) ? ((int?)null) : new int?((int)integerParamValue));
			string textParamValue4 = XActionHelper.GetTextParamValue(NkGg1N18q7s, W8FSIDp8D10, vLbSIdlNYa2);
			if (string.IsNullOrEmpty(textParamValue))
			{
				return (isSuccess: false, message: "需指定数据库类型", failReason: ActionStopFlag.OperationFailed);
			}
			if (string.IsNullOrWhiteSpace(textParamValue2))
			{
				return (isSuccess: false, message: "需指定连接字符串", failReason: ActionStopFlag.OperationFailed);
			}
			if (string.IsNullOrEmpty(textParamValue4))
			{
				return (isSuccess: false, message: "需指定操作类型", failReason: ActionStopFlag.OperationFailed);
			}
			object param = ny1SIoqN0Wc.d39gH3FhxoR(paramValue);
			using (IDbConnection cnn = ny1SIoqN0Wc.bZLgHff8N7E(textParamValue, textParamValue2))
			{
				switch (textParamValue4)
				{
				default:
					return (isSuccess: false, message: "不支持的操作类型：" + textParamValue4, failReason: ActionStopFlag.OperationFailed);
				case "Query":
				{
					int num2 = -1;
					bool flag = false;
					if (XActionHelper.IsOutputParamSetted(gbPg1yyFt59.Key, W8FSIDp8D10))
					{
						using IDataReader reader = cnn.ExecuteReader(textParamValue3, param, null, commandTimeout);
						flag = true;
						DataTable dataTable = new DataTable();
						dataTable.Load(reader);
						num2 = dataTable.Rows.Count;
						XActionHelper.OutputResult(gbPg1yyFt59, W8FSIDp8D10, vLbSIdlNYa2, dataTable, GI3SITIulkj);
					}
					IList<object> list = null;
					if (XActionHelper.IsOutputParamSetted(VhBg18sNnJY.Key, W8FSIDp8D10))
					{
						list = cnn.Query(textParamValue3, param, null, true, commandTimeout).ToList();
						flag = true;
						num2 = list.Count;
						XActionHelper.OutputResult(VhBg18sNnJY, W8FSIDp8D10, vLbSIdlNYa2, list, GI3SITIulkj);
					}
					if (XActionHelper.IsOutputParamSetted(W4ig1anTZ7E.Key, W8FSIDp8D10))
					{
						dynamic val = null;
						if (list == null)
						{
							val = cnn.QueryFirstOrDefault(textParamValue3, param, null, commandTimeout);
							flag = true;
							if (num2 < 0)
							{
								num2 = 1;
							}
						}
						else
						{
							val = list.FirstOrDefault();
						}
						if (val == null)
						{
							XActionHelper.OutputResult(W4ig1anTZ7E, W8FSIDp8D10, vLbSIdlNYa2, null, GI3SITIulkj);
						}
						else if (XActionHelper.GetOutputVariable(W4ig1anTZ7E.Key, W8FSIDp8D10, GI3SITIulkj).Type != VarType.Dict)
						{
							XActionHelper.OutputResult(W4ig1anTZ7E, W8FSIDp8D10, vLbSIdlNYa2, val, GI3SITIulkj);
						}
						else
						{
							dynamic val2 = CommonExtensions.ToDictionary(val);
							XActionHelper.OutputResult(W4ig1anTZ7E, W8FSIDp8D10, vLbSIdlNYa2, val2, GI3SITIulkj);
						}
					}
					if (XActionHelper.IsOutputParamSetted(BGog17lno4a.Key, W8FSIDp8D10))
					{
						if (num2 < 0)
						{
							list = cnn.Query(textParamValue3, param, null, true, commandTimeout).ToList();
							num2 = list.Count;
							flag = true;
						}
						XActionHelper.OutputResult(BGog17lno4a, W8FSIDp8D10, vLbSIdlNYa2, num2, GI3SITIulkj);
					}
					if (!flag)
					{
						return (isSuccess: false, message: "未执行查询，请检查是否选中了正确的执行方式，以及是否输出了结果到变量。", failReason: ActionStopFlag.OperationFailed);
					}
					break;
				}
				case "ExecuteScalar":
				{
					object result = cnn.ExecuteScalar(textParamValue3, param, null, commandTimeout);
					XActionHelper.OutputResult(lIeg1E6USYg, W8FSIDp8D10, vLbSIdlNYa2, result, GI3SITIulkj);
					break;
				}
				case "Execute":
				{
					int num = cnn.Execute(textParamValue3, param, null, commandTimeout);
					XActionHelper.OutputResult(Q9eg1PAGeKe, W8FSIDp8D10, vLbSIdlNYa2, num, GI3SITIulkj);
					break;
				}
				}
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal static bool v7Y9TyWovOk7Jw9CHtR6()
		{
			return fAKOKvWoBA102W898GM1 == null;
		}
	}

	[CompilerGenerated]
	private static class _003C_003Eo__55
	{
		public static CallSite<Func<CallSite, object, object, object>> Fh6SIMigTTc;

		public static CallSite<Func<CallSite, object, bool>> ecbSIAHDnLF;

		public static CallSite<Func<CallSite, Type, object, object>> m7bSIOWrAbT;

		public static CallSite<Action<CallSite, Type, StepOutParamDef, ActionStep, ActionExecuteContext, object, XAction>> R1pSIFw64Qw;

		public static CallSite<Action<CallSite, Type, StepOutParamDef, ActionStep, ActionExecuteContext, object, XAction>> Y1YSIUYoEqn;
	}

	public const string DbType_SqlServer = "sqlserver";

	public const string DbType_MySql = "mysql";

	public const string DbType_Sqlite = "sqlite";

	public const string DbType_OleDb = "oledb";

	public const string DbType_ODBC = "odbc";

	[CompilerGenerated]
	private readonly IEnumerable<string> k0TgHzdxkmS = new string[3] { "db", "database", "sql" };

	[CompilerGenerated]
	private readonly string LeMg1wd7d3y = $"fa:{EFontAwesomeIcon.Light_Database}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> ubqg1tctQZ8;

	[CompilerGenerated]
	private readonly string KHIg1g6MuFH = "https://getquicker.net/KC/Help/Doc/dboperation";

	private static readonly StepInParamDef Nymg1LJGLSJ;

	private static readonly StepInParamDef JNFg1v2ko42;

	private static readonly StepInParamDef nh8g1SABtjs;

	private static readonly StepInParamDef NMdg12QJ3W3;

	private static readonly StepInParamDef Q3Ig1uUCIYF;

	private static readonly StepInParamDef NkGg1N18q7s;

	private static readonly StepInParamDef Ewlg1JmTT87;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> dt9g106kln5 = new List<StepInParamDef> { Nymg1LJGLSJ, JNFg1v2ko42, nh8g1SABtjs, NMdg12QJ3W3, Q3Ig1uUCIYF, NkGg1N18q7s, Ewlg1JmTT87 };

	private static readonly StepOutParamDef xJbg1CxnHjA;

	private static readonly StepOutParamDef Q9eg1PAGeKe;

	private static readonly StepOutParamDef lIeg1E6USYg;

	private static readonly StepOutParamDef gbPg1yyFt59;

	private static readonly StepOutParamDef VhBg18sNnJY;

	private static readonly StepOutParamDef W4ig1anTZ7E;

	private static readonly StepOutParamDef BGog17lno4a;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> yDQg1Racpk3 = new List<StepOutParamDef> { xJbg1CxnHjA, Q9eg1PAGeKe, lIeg1E6USYg, gbPg1yyFt59, VhBg18sNnJY, W4ig1anTZ7E, BGog17lno4a };

	private static DatabaseOperationStep BItRYKQsLjLKXqreWd6r;

	public string Key => "sys:dboperation";

	public string Name => "数据库查询";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return k0TgHzdxkmS;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return LeMg1wd7d3y;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Compute;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return ubqg1tctQZ8;
		}
	}

	public string Description => "对数据库执行SQL语句并返回结果";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return KHIg1g6MuFH;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly => false;

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return dt9g106kln5;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return yDQg1Racpk3;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass55_0 _003C_003Ec__DisplayClass55_ = new _003C_003Ec__DisplayClass55_0();
		_003C_003Ec__DisplayClass55_.W8FSIDp8D10 = step;
		_003C_003Ec__DisplayClass55_.vLbSIdlNYa2 = context;
		_003C_003Ec__DisplayClass55_.ny1SIoqN0Wc = this;
		_003C_003Ec__DisplayClass55_.GI3SITIulkj = action;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass55_.vLbSIdlNYa2, _003C_003Ec__DisplayClass55_.W8FSIDp8D10, _003C_003Ec__DisplayClass55_.GI3SITIulkj, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass55_.nydSI54hoRe, (Action)null, (Action)null, Ewlg1JmTT87, xJbg1CxnHjA);
	}

	private object d39gH3FhxoR(object object_0)
	{
		if (object_0 == null)
		{
			return null;
		}
		if (object_0 is string value)
		{
			if (string.IsNullOrWhiteSpace(value))
			{
				return null;
			}
			try
			{
				return VariableHelper.ConvertToDict(value);
			}
			catch (Exception)
			{
				return object_0;
			}
		}
		if (object_0 is IDictionary<string, object> template)
		{
			return new DynamicParameters(template);
		}
		DataRow dataRow = object_0 as DataRow;
		if (!oOUhnVQsuv83vxYOLvMH())
		{
			switch (0)
			{
			}
		}
		if (dataRow != null)
		{
			return new DynamicParameters(dataRow.ToDict());
		}
		if (object_0.IsAnonymousType())
		{
			return new DynamicParameters(object_0.ToDictionary());
		}
		if (object_0 is DataTable table)
		{
			return table.ToObjectList();
		}
		return object_0;
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDirectValue(NkGg1N18q7s, step) + " " + XActionHelper.GetParamDisplayString(nh8g1SABtjs, step);
	}

	private IDbConnection bZLgHff8N7E(string string_2, string string_3)
	{
		if (string.IsNullOrEmpty(string_2))
		{
			throw new InvalidParameterException("数据库类型不能为空。");
		}
		if (string.IsNullOrEmpty(string_3))
		{
			throw new InvalidParameterException("连接字符串不能为空。");
		}
		switch (string_2)
		{
		default:
			throw new NotSupportedException("不支持的数据库类型：" + string_2 + "，可能您使用的Quicker版本较为古老。");
		case "oledb":
			if ((string_3.EndsWith(".mdb", StringComparison.OrdinalIgnoreCase) || string_3.EndsWith(".accdb")) && File.Exists(string_3))
			{
				string_3 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + string_3 + ";Persist Security Info=False;";
			}
			return new OleDbConnection(string_3);
		case "odbc":
			return new OdbcConnection(string_3);
		case "sqlserver":
			return new SqlConnection(string_3);
		case "sqlite":
			if (!string_3.StartsWith("Data", StringComparison.OrdinalIgnoreCase) && File.Exists(string_3))
			{
				string_3 = "Data Source=" + string_3 + ";Version=3;";
			}
			return new SQLiteConnection(string_3);
		case "mysql":
			return new MySqlConnection(string_3);
		}
	}

	static DatabaseOperationStep()
	{
		Nymg1LJGLSJ = new StepInParamDef
		{
			Key = "dbType",
			Name = "数据库连接类型",
			Description = "",
			VariableMode = ParamVariableMode.Input,
			DefaultValue = "",
			Type = VarType.Enum,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("sqlserver", "SQL Server"),
				new SelectionItem("mysql", "MySQL"),
				new SelectionItem("sqlite", "SQLite"),
				new SelectionItem("oledb", "OleDB"),
				new SelectionItem("odbc", "ODBC")
			}
		};
		JNFg1v2ko42 = new StepInParamDef
		{
			Key = "connectionString",
			Name = "连接字符串",
			Description = "Connection string",
			VariableMode = ParamVariableMode.UseVarOrInput,
			DefaultValue = "",
			Type = VarType.Text
		};
		nh8g1SABtjs = new StepInParamDef
		{
			Key = "sql",
			Name = "SQL语句",
			Description = "要执行的SQL语句内容",
			VariableMode = ParamVariableMode.UseVarOrInput,
			DefaultValue = "",
			Type = VarType.Text,
			IsMultiLine = true
		};
		NMdg12QJ3W3 = new StepInParamDef
		{
			Key = "sqlParam",
			Name = "参数",
			Description = "为SQL语句提供的参数",
			VariableMode = ParamVariableMode.UseVarOrInput,
			DefaultValue = "",
			Type = VarType.Object,
			IsMultiLine = true
		};
		Q3Ig1uUCIYF = new StepInParamDef
		{
			Key = "timeoutSeconds",
			Name = "超时秒数",
			Description = "留空或0表示默认。",
			VariableMode = ParamVariableMode.UseVarOrInput,
			DefaultValue = "",
			Type = VarType.Integer
		};
		NkGg1N18q7s = new StepInParamDef
		{
			Key = "operationType",
			Name = "执行方式",
			Description = "",
			VariableMode = ParamVariableMode.Input,
			DefaultValue = "Query",
			Type = VarType.Enum,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("Query", "Query：查询并返回结果数据"),
				new SelectionItem("Execute", "Execute：执行并返回影响的行数"),
				new SelectionItem("ExecuteScalar", "ExecuteScalar：执行并返回单个值(首行首列的值)")
			},
			IsControlField = true
		};
		Ewlg1JmTT87 = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		xJbg1CxnHjA = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		Q9eg1PAGeKe = new StepOutParamDef
		{
			Key = "rowsAffected",
			Name = "影响行数",
			Type = VarType.Integer,
			ValidForList = new List<string> { "Execute" }
		};
		lIeg1E6USYg = new StepOutParamDef
		{
			Key = "scalarResult",
			Name = "单值结果",
			Type = VarType.Any,
			ValidForList = new List<string> { "ExecuteScalar" }
		};
		gbPg1yyFt59 = new StepOutParamDef
		{
			Key = "dataTableResult",
			Name = "查询结果(表格)",
			Description = "获取表格类型的行结果",
			Type = VarType.Table,
			ValidForList = new List<string> { "Query" }
		};
		VhBg18sNnJY = new StepOutParamDef
		{
			Key = "listResult",
			Name = "查询结果(对象列表)",
			Description = "获得动态对象列表类型的结果",
			Type = VarType.Object,
			ValidForList = new List<string> { "Query" }
		};
		W4ig1anTZ7E = new StepOutParamDef
		{
			Key = "firstItem",
			Name = "首项结果",
			Description = "如果只需要返回结果的第一行，可以使用此项输出，支持词典或dynamic对象。没有结果时返回null。",
			Type = VarType.Object,
			ValidForList = new List<string> { "Query" }
		};
		BGog17lno4a = new StepOutParamDef
		{
			Key = "rowCount",
			Name = "结果行数",
			Description = "",
			Type = VarType.Integer,
			ValidForList = new List<string> { "Query" }
		};
	}

	internal static bool oOUhnVQsuv83vxYOLvMH()
	{
		return BItRYKQsLjLKXqreWd6r == null;
	}
}
