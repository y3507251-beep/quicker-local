using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using CsvHelper;
using CsvHelper.Configuration;
using FontAwesome5;
using j9PVNbXS3U4MP7j5Ps6;
using Newtonsoft.Json;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using Quicker.Actions.XActions.BuildinRunners.Office;
using Quicker.Actions.XActions.Storage;
using Quicker.Domain.Actions;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Modules.Tables;
using Quicker.Modules.TextTools;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities.Win32;
using SCyJThYoNMQE7IHLXbA;
using t8SGKhhgLWTgeqjGcrq;

namespace Quicker.Actions.XActions.BuildinRunners;

public class TableOperationStep : IStepRunner, IStepRunningInfo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec s06SI3Lt3Pf;

		public static PrepareHeaderForMatch w5JSIfipi1m;

		public static Func<DataRowView, DataRow> XgwSIzGMUrE;

		internal static _003C_003Ec YjOdo5WoaOPA7ZK6pmoe;

		static _003C_003Ec()
		{
			s06SI3Lt3Pf = new _003C_003Ec();
		}

		internal string p2qSIlh4fZ1(PrepareHeaderForMatchArgs args)
		{
			return args.Header.Trim();
		}

		internal DataRow egeSIi30CTn(DataRowView x)
		{
			return x.Row;
		}

		internal static bool Y5jOinWorZtAk4FGRK2P()
		{
			return YjOdo5WoaOPA7ZK6pmoe == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass78_0
	{
		public XAction aKCSWg5K3ZU;

		public ActionStep P6qSWLtkE7C;

		public ActionExecuteContext iVkSWvwLVL4;

		public TableOperationStep kNJSWS0CZqi;

		public Func<ActionVariable, bool> b3ASW26Sw5X;

		private static _003C_003Ec__DisplayClass78_0 VVsSi5Wo9tVtgA1FnlDG;

		internal (bool isSuccess, string message, ActionStopFlag failReason) H0QSWwHu5RA()
		{
			_003C_003Ec__DisplayClass78_1 _003C_003Ec__DisplayClass78_ = new _003C_003Ec__DisplayClass78_1();
			ActionVariable actionVariable = aKCSWg5K3ZU.Variables.FirstOrDefault(b3ASW26Sw5X ?? (b3ASW26Sw5X = UyHSWtAAMZ3));
			if (actionVariable == null)
			{
				return (isSuccess: false, message: "未能获取表格变量", failReason: ActionStopFlag.OperationFailed);
			}
			_003C_003Ec__DisplayClass78_.KI0SWJERISd = XActionHelper.GetTableParamValue(ubGg1bXJUv9, P6qSWLtkE7C, iVkSWvwLVL4);
			if (_003C_003Ec__DisplayClass78_.KI0SWJERISd == null)
			{
				return (isSuccess: false, message: "未能获取表格对象", failReason: ActionStopFlag.OperationFailed);
			}
			switch (XActionHelper.GetTextParamValue(o6wg16jsQ0R, P6qSWLtkE7C, iVkSWvwLVL4))
			{
			case "info":
				XActionHelper.OutputResultIfNeeded(rowsOutputParam, _003C_003Ec__DisplayClass78_.reASWuoB0OU, P6qSWLtkE7C, iVkSWvwLVL4, aKCSWg5K3ZU);
				XActionHelper.OutputResultIfNeeded(columnsOutputParam, _003C_003Ec__DisplayClass78_.B6qSWNR19Pu, P6qSWLtkE7C, iVkSWvwLVL4, aKCSWg5K3ZU);
				break;
			case "clear":
				_003C_003Ec__DisplayClass78_.KI0SWJERISd.Rows.Clear();
				break;
			case "manage":
			{
				if ((actionVariable.TableDef == null || !actionVariable.TableDef.Fields.HasData()) && _003C_003Ec__DisplayClass78_.KI0SWJERISd.Columns.Count == 0)
				{
					return (isSuccess: false, message: "无法获取列信息", failReason: ActionStopFlag.OperationFailed);
				}
				string textParamValue3 = XActionHelper.GetTextParamValue(oiEg1rZ9JU1, P6qSWLtkE7C, iVkSWvwLVL4);
				if (!string.IsNullOrEmpty(textParamValue3))
				{
					_003C_003Ec__DisplayClass78_.KI0SWJERISd.DefaultView.Sort = textParamValue3;
				}
				bool booleanParamValue = XActionHelper.GetBooleanParamValue(HTWg15uHRvN, P6qSWLtkE7C, iVkSWvwLVL4);
				(bool, string, ActionStopFlag) result = kNJSWS0CZqi.ivqg1WGj5u0(_003C_003Ec__DisplayClass78_.KI0SWJERISd, iVkSWvwLVL4, P6qSWLtkE7C, aKCSWg5K3ZU, actionVariable, booleanParamValue);
				if (!result.Item1)
				{
					return result;
				}
				break;
			}
			case "addRow":
			{
				(bool, string, ActionStopFlag) result4 = kNJSWS0CZqi.hs0g1kGWWWm(_003C_003Ec__DisplayClass78_.KI0SWJERISd, iVkSWvwLVL4, P6qSWLtkE7C, aKCSWg5K3ZU);
				if (!result4.Item1)
				{
					return result4;
				}
				break;
			}
			case "update":
			{
				(bool, string, ActionStopFlag) result6 = kNJSWS0CZqi.YkZg1q2JbOb(_003C_003Ec__DisplayClass78_.KI0SWJERISd, iVkSWvwLVL4, P6qSWLtkE7C, aKCSWg5K3ZU);
				if (!result6.Item1)
				{
					return result6;
				}
				break;
			}
			case "select":
			{
				(bool, string, ActionStopFlag) result5 = kNJSWS0CZqi.DtOg1IV8w4R(_003C_003Ec__DisplayClass78_.KI0SWJERISd, iVkSWvwLVL4, P6qSWLtkE7C, aKCSWg5K3ZU, actionVariable);
				if (!result5.Item1)
				{
					return result5;
				}
				return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
			}
			case "importCsv":
			{
				(bool, string, ActionStopFlag) result3 = kNJSWS0CZqi.CaJg1YjglmO(_003C_003Ec__DisplayClass78_.KI0SWJERISd, iVkSWvwLVL4, P6qSWLtkE7C, aKCSWg5K3ZU, actionVariable);
				if (!result3.Item1)
				{
					return result3;
				}
				break;
			}
			case "importJson":
			{
				(bool, string, ActionStopFlag) result2 = kNJSWS0CZqi.VVUg1effX68(_003C_003Ec__DisplayClass78_.KI0SWJERISd, iVkSWvwLVL4, P6qSWLtkE7C, aKCSWg5K3ZU, actionVariable);
				if (!result2.Item1)
				{
					return result2;
				}
				break;
			}
			case "deleteRows":
			{
				string textParamValue2 = XActionHelper.GetTextParamValue(bpjg1KFVK0E, P6qSWLtkE7C, iVkSWvwLVL4);
				DataRow[] array2 = _003C_003Ec__DisplayClass78_.KI0SWJERISd.Select(textParamValue2);
				XActionHelper.OutputResult(affectedRowCountParam, P6qSWLtkE7C, iVkSWvwLVL4, array2.Length, aKCSWg5K3ZU);
				int num2 = array2.Length;
				DataRow[] array3 = array2;
				foreach (DataRow row in array3)
				{
					_003C_003Ec__DisplayClass78_.KI0SWJERISd.Rows.Remove(row);
				}
				iVkSWvwLVL4.ActionLogger.LogInfo($"共删除了{num2}行");
				_003C_003Ec__DisplayClass78_.KI0SWJERISd.AcceptChanges();
				break;
			}
			case "importExcel":
			{
				(bool, string, ActionStopFlag) result7 = kNJSWS0CZqi.d8tg1V2OPVF(_003C_003Ec__DisplayClass78_.KI0SWJERISd, iVkSWvwLVL4, P6qSWLtkE7C, aKCSWg5K3ZU, actionVariable);
				if (!result7.Item1)
				{
					return result7;
				}
				break;
			}
			case "exportExcel":
				kNJSWS0CZqi.BmQg1cUXIS5(_003C_003Ec__DisplayClass78_.KI0SWJERISd, iVkSWvwLVL4, P6qSWLtkE7C, aKCSWg5K3ZU, actionVariable);
				break;
			case "export_text":
				kNJSWS0CZqi.IBtg19T4UVb(_003C_003Ec__DisplayClass78_.KI0SWJERISd, iVkSWvwLVL4, P6qSWLtkE7C, aKCSWg5K3ZU, actionVariable);
				break;
			case "deleteColumns":
			{
				string textParamValue = XActionHelper.GetTextParamValue(Xhog1x8GKpS, P6qSWLtkE7C, iVkSWvwLVL4);
				if (string.IsNullOrEmpty(textParamValue))
				{
					return (isSuccess: false, message: "未指定要删除的列", failReason: ActionStopFlag.OperationFailed);
				}
				int num = 0;
				if (textParamValue.Trim() == "*")
				{
					num = _003C_003Ec__DisplayClass78_.KI0SWJERISd.Columns.Count;
					_003C_003Ec__DisplayClass78_.KI0SWJERISd.Columns.Clear();
				}
				else if (textParamValue.StartsWithAny(true, "!", "！"))
				{
					string[] source = textParamValue.Substring(1).Split(new char[2] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
					foreach (DataColumn item in _003C_003Ec__DisplayClass78_.KI0SWJERISd.Columns.Cast<DataColumn>().ToList())
					{
						if (!source.Contains(item.ColumnName))
						{
							_003C_003Ec__DisplayClass78_.KI0SWJERISd.Columns.Remove(item);
							num++;
						}
					}
				}
				else
				{
					string[] array = textParamValue.Split(new char[2] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
					foreach (string name in array)
					{
						if (_003C_003Ec__DisplayClass78_.KI0SWJERISd.Columns.Contains(name))
						{
							_003C_003Ec__DisplayClass78_.KI0SWJERISd.Columns.Remove(name);
							num++;
						}
					}
				}
				_003C_003Ec__DisplayClass78_.KI0SWJERISd.AcceptChanges();
				iVkSWvwLVL4.ActionLogger.LogInfo($"共删除了{num}列");
				break;
			}
			}
			_003C_003Ec__DisplayClass78_.KI0SWJERISd.AcceptChanges();
			XActionHelper.OutputResult(rowCountParam, P6qSWLtkE7C, iVkSWvwLVL4, _003C_003Ec__DisplayClass78_.KI0SWJERISd.Rows.Count, aKCSWg5K3ZU);
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}

		internal bool UyHSWtAAMZ3(ActionVariable x)
		{
			return x.Key == P6qSWLtkE7C.InputParams[ubGg1bXJUv9.Key].VarKey;
		}

		internal static void EmoncoWoo9UPbK5RVS5E()
		{
		}

		internal static bool bmN7O4WoLMsrNHaSBi9k()
		{
			return VVsSi5Wo9tVtgA1FnlDG == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass78_1
	{
		public DataTable KI0SWJERISd;

		private static _003C_003Ec__DisplayClass78_1 qxVKbFWobHBQSQ0heL14;

		internal object reASWuoB0OU()
		{
			return KI0SWJERISd.Select();
		}

		internal object B6qSWNR19Pu()
		{
			return KI0SWJERISd.Columns;
		}

		internal static bool YZWqKTWoqiSFvUux1Owi()
		{
			return qxVKbFWobHBQSQ0heL14 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass81_0
	{
		public string mQZSWCvYOV4;

		internal static _003C_003Ec__DisplayClass81_0 wExyJ6WoltdejZmAeku7;

		internal bool qoRSW00CeFI(KeyValuePair<int, string> x)
		{
			return string.Equals(x.Value, mQZSWCvYOV4);
		}

		internal static bool Cou4o5WoZopEsAJi0Hht()
		{
			return wExyJ6WoltdejZmAeku7 == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass84_0
	{
		public DataTable jKcSWyJrpKN;

		public ActionStep qWYSW8e7f9w;

		public ActionExecuteContext fsVSWa1D0sQ;

		internal static _003C_003Ec__DisplayClass84_0 wqm06qWoYjtPXP9XAApg;

		internal object GNnSWPlYyhm()
		{
			return JsonConvert.SerializeObject(jKcSWyJrpKN, Formatting.Indented);
		}

		internal object CGrSWEHAvV1()
		{
			string text = XActionHelper.GetTextParamValue(FGZg1TFn6eO, qWYSW8e7f9w, fsVSWa1D0sQ);
			if (text.IsNullOrEmpty())
			{
				text = ",";
			}
			return jKcSWyJrpKN.FlnghWSaqEt(text);
		}

		static _003C_003Ec__DisplayClass84_0()
		{
		}

		internal static bool lDDlihWo8AlyAKUe8oHJ()
		{
			return wqm06qWoYjtPXP9XAApg == null;
		}

		internal static void xBlXd7WoPj3doaIjULqO()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass89_0
	{
		public DataColumn PLLSWRsob5Z;

		private static _003C_003Ec__DisplayClass89_0 SJcVdnWoMg7qntaD3OSp;

		internal bool haiSW7KlSm5(DataRow r)
		{
			decimal result;
			return decimal.TryParse(r[PLLSWRsob5Z].ToString(), out result);
		}

		internal static bool JkFrF1WoU8gDQwFRPTC3()
		{
			return SJcVdnWoMg7qntaD3OSp == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass91_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct I0JcNoknHuQmws2DOoq : IAsyncStateMachine
		{
			public int GM92VuBmHgn;

			public AsyncVoidMethodBuilder d7v2VNK9CYQ;

			public _003C_003Ec__DisplayClass91_0 X1v2VJenxDT;

			internal static object QQs3SfybNfx9F4eQJK9T;

			private void MoveNext()
			{
				_003C_003Ec__DisplayClass91_0 _003C_003Ec__DisplayClass91_ = X1v2VJenxDT;
				try
				{
					_003C_003Ec__DisplayClass91_1 _003C_003Ec__DisplayClass91_2 = new _003C_003Ec__DisplayClass91_1
					{
						ba2SWXPXGUw = _003C_003Ec__DisplayClass91_
					};
					int num = 0;
					if (QQs3SfybNfx9F4eQJK9T != null)
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					default:
						_003C_003Ec__DisplayClass91_2.L9LSW6e2QME = new TableManageWindow(_003C_003Ec__DisplayClass91_.xEoSWV1hRFT, _003C_003Ec__DisplayClass91_.PvkSWZeqfmx.TableDef, _003C_003Ec__DisplayClass91_.cUaSW9LRFaD, _003C_003Ec__DisplayClass91_.daQSWhAPLTS, _003C_003Ec__DisplayClass91_.BwcSWeH6fbY);
						_003C_003Ec__DisplayClass91_2.L9LSW6e2QME.Title = _003C_003Ec__DisplayClass91_.PxRSWYEQGxL;
						_003C_003Ec__DisplayClass91_2.L9LSW6e2QME.HelpText = _003C_003Ec__DisplayClass91_.SmxSWIVs2wO;
						_003C_003Ec__DisplayClass91_2.L9LSW6e2QME.V6hgjEnp8ZH(_003C_003Ec__DisplayClass91_.BwcSWeH6fbY.CancellationToken);
						_003C_003Ec__DisplayClass91_2.L9LSW6e2QME.WinSizeStr = _003C_003Ec__DisplayClass91_.OK5SWWW6KsY;
						_003C_003Ec__DisplayClass91_2.L9LSW6e2QME.Topmost = _003C_003Ec__DisplayClass91_.qmoSWkDaqi6;
						_003C_003Ec__DisplayClass91_2.L9LSW6e2QME.Closed += _003C_003Ec__DisplayClass91_2.le8SWb3JDuV;
						_003C_003Ec__DisplayClass91_2.L9LSW6e2QME.Show();
						_003C_003Ec__DisplayClass91_2.L9LSW6e2QME.Activate();
						break;
					}
				}
				catch (Exception exception)
				{
					GM92VuBmHgn = -2;
					d7v2VNK9CYQ.SetException(exception);
					return;
				}
				GM92VuBmHgn = -2;
				d7v2VNK9CYQ.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				d7v2VNK9CYQ.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			internal static bool ciDdU1yb9vq1iAEttZr2()
			{
				return QQs3SfybNfx9F4eQJK9T == null;
			}
		}

		public DataTable xEoSWV1hRFT;

		public ActionVariable PvkSWZeqfmx;

		public bool cUaSW9LRFaD;

		public GridSelectionMode daQSWhAPLTS;

		public ActionExecuteContext BwcSWeH6fbY;

		public string PxRSWYEQGxL;

		public string SmxSWIVs2wO;

		public string OK5SWWW6KsY;

		public bool qmoSWkDaqi6;

		public IList SA6SWGhFxrw;

		public bool MMmSWs016Q0;

		public bool nEsSWH70eWp;

		public ManualResetEvent bO9SW1u7SLy;

		internal static _003C_003Ec__DisplayClass91_0 nFwlyNWo6yVESJ4Notdr;

		[AsyncStateMachine(typeof(I0JcNoknHuQmws2DOoq))]
		internal void WhJSWqvXIob()
		{
			I0JcNoknHuQmws2DOoq stateMachine = default(I0JcNoknHuQmws2DOoq);
			stateMachine.d7v2VNK9CYQ = AsyncVoidMethodBuilder.Create();
			stateMachine.X1v2VJenxDT = this;
			stateMachine.GM92VuBmHgn = -1;
			stateMachine.d7v2VNK9CYQ.Start(ref stateMachine);
		}

		internal object R7pSWcU4tBp()
		{
			if (SA6SWGhFxrw != null)
			{
				return SA6SWGhFxrw.Cast<DataRowView>().Select(_003C_003Ec.XgwSIzGMUrE ?? (_003C_003Ec.XgwSIzGMUrE = _003C_003Ec.s06SI3Lt3Pf.egeSIi30CTn)).ToList();
			}
			return new List<DataRow>();
		}

		internal static bool MTd0X5Wotg6SgCAKV82L()
		{
			return nFwlyNWo6yVESJ4Notdr == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass91_1
	{
		public TableManageWindow L9LSW6e2QME;

		public _003C_003Ec__DisplayClass91_0 ba2SWXPXGUw;

		private static _003C_003Ec__DisplayClass91_1 cEpmXhWowuJmxU6HhNMa;

		internal void le8SWb3JDuV(object sender, EventArgs e)
		{
			ba2SWXPXGUw.SA6SWGhFxrw = L9LSW6e2QME.TheGrid.SelectedItems;
			ba2SWXPXGUw.MMmSWs016Q0 = true;
			ba2SWXPXGUw.nEsSWH70eWp = L9LSW6e2QME.Result == true;
			ba2SWXPXGUw.bO9SW1u7SLy.Set();
		}

		static _003C_003Ec__DisplayClass91_1()
		{
		}

		internal static bool fMLAIIWoTtXaMF4XpG9W()
		{
			return cEpmXhWowuJmxU6HhNMa == null;
		}

		internal static void SPsVVpWoC9fyQcwUEBTP()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass92_0
	{
		public DataRow NYoSWKhpcvq;

		internal static _003C_003Ec__DisplayClass92_0 nBNt7CWo7RfqbUUGKIvT;

		internal object ufsSWmH4RSu()
		{
			return NYoSWKhpcvq;
		}

		internal static bool IsKlffWo4MEGcSmSjkG1()
		{
			return nBNt7CWo7RfqbUUGKIvT == null;
		}
	}

	[CompilerGenerated]
	private readonly IEnumerable<string> UxPg1G2sM7i = new string[1] { "table" };

	[CompilerGenerated]
	private readonly string S4sg1sKtgIr = $"fa:{EFontAwesomeIcon.Light_Table}:#6aaded";

	[CompilerGenerated]
	private readonly IEnumerable<StepRunnerCategory> tMvg1Hmo7KG;

	[CompilerGenerated]
	private readonly string o8Mg11eTLcg = "https://getquicker.net/KC/Help/Doc/tableoperation";

	public const string TABLE_OP_GETINFO = "info";

	public const string TABLE_OP_ADDROW = "addRow";

	public const string TABLE_OP_UPDATE = "update";

	public const string TABLE_OP_MANAGE = "manage";

	public const string TABLE_OP_MANAGE_DATAGRID = "manage_datagrid";

	public const string TABLE_OP_SELECT = "select";

	public const string TABLE_OP_CLEAR = "clear";

	public const string TABLE_OP_DELETE_ROWS = "deleteRows";

	public const string TABLE_OP_DELETE_COLUMNS = "deleteColumns";

	public const string TABLE_OP_IMPORT_CSV = "importCsv";

	public const string TABLE_OP_IMPORT_JSON = "importJson";

	public const string TABLE_OP_IMPORT_EXCEL = "importExcel";

	public const string TABLE_OP_EXPORT_TEXT = "export_text";

	public const string TABLE_OP_EXPORT_EXCEL = "exportExcel";

	private static StepInParamDef ubGg1bXJUv9;

	private static readonly StepInParamDef o6wg16jsQ0R;

	private static readonly StepInParamDef Oheg1XQ7BVM;

	private static readonly StepInParamDef iDQg1m7PQOg;

	private static readonly StepInParamDef bpjg1KFVK0E;

	private static readonly StepInParamDef Xhog1x8GKpS;

	private static readonly StepInParamDef oiEg1rZ9JU1;

	private static readonly StepInParamDef zXSg1pXeaXB;

	private static readonly StepInParamDef kobg1BbTBCC;

	private static readonly StepInParamDef fN9g1QmhJ8v;

	private static readonly StepInParamDef oNQg1jJ09eY;

	private static readonly StepInParamDef dAJg1nIJuIX;

	private static readonly StepInParamDef Ewyg14oZT5k;

	private static readonly StepInParamDef HTWg15uHRvN;

	private static readonly StepInParamDef DZtg1DpiiGk;

	private static readonly StepInParamDef YXLg1dInfx6;

	private static readonly StepInParamDef GCLg1o5Wbo9;

	private static readonly StepInParamDef FGZg1TFn6eO;

	private static readonly StepInParamDef zLSg1M12kPf;

	private static readonly StepInParamDef EWwg1A5Qs5M;

	private static readonly StepInParamDef Hpog1O4gJP6;

	[CompilerGenerated]
	private readonly IList<StepInParamDef> VC6g1FsmEGh = new List<StepInParamDef>
	{
		ubGg1bXJUv9, o6wg16jsQ0R, Oheg1XQ7BVM, iDQg1m7PQOg, kobg1BbTBCC, fN9g1QmhJ8v, oNQg1jJ09eY, FGZg1TFn6eO, Ewyg14oZT5k, bpjg1KFVK0E,
		Xhog1x8GKpS, oiEg1rZ9JU1, zXSg1pXeaXB, dAJg1nIJuIX, HTWg15uHRvN, DZtg1DpiiGk, YXLg1dInfx6, GCLg1o5Wbo9, zLSg1M12kPf, EWwg1A5Qs5M,
		Hpog1O4gJP6
	};

	private static readonly StepOutParamDef H3ng1UarSvS;

	public static readonly StepOutParamDef rowCountParam;

	public static readonly StepOutParamDef affectedRowCountParam;

	public static readonly StepOutParamDef rowsOutputParam;

	public static readonly StepOutParamDef columnsOutputParam;

	public static readonly StepOutParamDef firstRow;

	public static readonly StepOutParamDef selectedRowsParam;

	public static readonly StepOutParamDef csvExportDataParam;

	public static readonly StepOutParamDef jsonExportDataParam;

	private static readonly StepOutParamDef HQHg1lS9UHw;

	[CompilerGenerated]
	private readonly IList<StepOutParamDef> Nupg1iEjhOc = new List<StepOutParamDef> { H3ng1UarSvS, HQHg1lS9UHw, rowsOutputParam, firstRow, selectedRowsParam, columnsOutputParam, csvExportDataParam, jsonExportDataParam, affectedRowCountParam, rowCountParam };

	internal static TableOperationStep jMPIZWQsY8Ht3r8g8w1W;

	public string Key => "sys:tableoperation";

	public string Name => "表格数据操作";

	public IEnumerable<string> KeyWords
	{
		[CompilerGenerated]
		get
		{
			return UxPg1G2sM7i;
		}
	}

	public string Icon
	{
		[CompilerGenerated]
		get
		{
			return S4sg1sKtgIr;
		}
	}

	public StepRunnerCategory Category => StepRunnerCategory.Compute;

	public IEnumerable<StepRunnerCategory> SecondaryCategories
	{
		[CompilerGenerated]
		get
		{
			return tMvg1Hmo7KG;
		}
	}

	public string Description => "表格变量的相关处理操作";

	public StepType StepType => StepType.Action;

	public string HelpLink
	{
		[CompilerGenerated]
		get
		{
			return o8Mg11eTLcg;
		}
	}

	public bool IsRisky => false;

	public bool IsProOnly => false;

	public IList<StepInParamDef> InputParams
	{
		[CompilerGenerated]
		get
		{
			return VC6g1FsmEGh;
		}
	}

	public IList<StepOutParamDef> OutputParams
	{
		[CompilerGenerated]
		get
		{
			return Nupg1iEjhOc;
		}
	}

	public bool ValidateParam(string paramData, out string message)
	{
		throw new NotImplementedException();
	}

	public void Execute(ActionStep step, ActionExecuteContext context, XAction action, string stepId)
	{
		_003C_003Ec__DisplayClass78_0 _003C_003Ec__DisplayClass78_ = new _003C_003Ec__DisplayClass78_0();
		_003C_003Ec__DisplayClass78_.aKCSWg5K3ZU = action;
		_003C_003Ec__DisplayClass78_.P6qSWLtkE7C = step;
		_003C_003Ec__DisplayClass78_.iVkSWvwLVL4 = context;
		_003C_003Ec__DisplayClass78_.kNJSWS0CZqi = this;
		XActionHelper.ExecuteCommonAction(_003C_003Ec__DisplayClass78_.iVkSWvwLVL4, _003C_003Ec__DisplayClass78_.P6qSWLtkE7C, _003C_003Ec__DisplayClass78_.aKCSWg5K3ZU, (Func<(bool isSuccess, string message, ActionStopFlag failReason)>)_003C_003Ec__DisplayClass78_.H0QSWwHu5RA, (Action)null, (Action)null, Hpog1O4gJP6, H3ng1UarSvS);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) YkZg1q2JbOb(DataTable dataTable_0, ActionExecuteContext actionExecuteContext_0, ActionStep actionStep_0, XAction xaction_0)
	{
		IDictionary<string, object> dictParamValue = XActionHelper.GetDictParamValue(Oheg1XQ7BVM, actionStep_0, actionExecuteContext_0);
		if (dictParamValue == null)
		{
			return (isSuccess: false, message: "数据为空", failReason: ActionStopFlag.OperationFailed);
		}
		string textParamValue = XActionHelper.GetTextParamValue(bpjg1KFVK0E, actionStep_0, actionExecuteContext_0);
		DataRow[] array = dataTable_0.Select(textParamValue);
		XActionHelper.OutputResult(affectedRowCountParam, actionStep_0, actionExecuteContext_0, array.Length, xaction_0);
		DataRow[] array2 = array;
		foreach (DataRow dataRow in array2)
		{
			foreach (KeyValuePair<string, object> item in dictParamValue)
			{
				if (dataTable_0.Columns.Contains(item.Key))
				{
					dataRow[item.Key] = item.Value;
				}
			}
		}
		dataTable_0.AcceptChanges();
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private void BmQg1cUXIS5(DataTable dataTable_0, ActionExecuteContext actionExecuteContext_0, ActionStep actionStep_0, XAction xaction_0, ActionVariable actionVariable_0)
	{
		DataTable dataTable = nCsg1hgdHO7(dataTable_0, actionExecuteContext_0, actionStep_0, actionVariable_0);
		XActionHelper.OutputResult(affectedRowCountParam, actionStep_0, actionExecuteContext_0, dataTable.Rows.Count, xaction_0);
		string text = XActionHelper.GetTextParamValue(kobg1BbTBCC, actionStep_0, actionExecuteContext_0).Trim();
		string textParamValue = XActionHelper.GetTextParamValue(fN9g1QmhJ8v, actionStep_0, actionExecuteContext_0);
		using FileStream stream = new FileStream(text, FileMode.Create, FileAccess.Write);
		IWorkbook workbook2;
		if (!text.EndsWith(".xlsx", StringComparison.OrdinalIgnoreCase))
		{
			IWorkbook workbook = new HSSFWorkbook();
			workbook2 = workbook;
		}
		else
		{
			IWorkbook workbook = new XSSFWorkbook();
			workbook2 = workbook;
		}
		IWorkbook workbook3 = workbook2;
		ISheet sheet = workbook3.CreateSheet(textParamValue.Or(dataTable.TableName).Or("Sheet1"));
		IRow row = sheet.CreateRow(0);
		int num = 0;
		ICellStyle cellStyle = workbook3.CreateCellStyle();
		IDataFormat dataFormat = workbook3.CreateDataFormat();
		cellStyle.DataFormat = dataFormat.GetFormat("yyyy-MM-dd hh:mm:ss");
		IDictionary<string, int> dictionary = new Dictionary<string, int>();
		IEnumerator enumerator = dataTable.Columns.GetEnumerator();
		int num2 = 0;
		if (jMPIZWQsY8Ht3r8g8w1W != null)
		{
			int num3 = default(int);
			num2 = num3;
		}
		switch (num2)
		{
		default:
			try
			{
				while (enumerator.MoveNext())
				{
					DataColumn dataColumn = (DataColumn)enumerator.Current;
					row.CreateCell(num).SetCellValue(dataColumn.ColumnName);
					dictionary.Add(dataColumn.ColumnName, num);
					num++;
				}
			}
			finally
			{
				if (enumerator is IDisposable disposable)
				{
					disposable.Dispose();
				}
			}
			break;
		case 1:
			break;
		}
		int num4 = 1;
		foreach (DataRow row2 in dataTable.Rows)
		{
			row = sheet.CreateRow(num4);
			foreach (DataColumn column2 in dataTable.Columns)
			{
				int column = dictionary[column2.ColumnName];
				ICell cell = row.CreateCell(column);
				object obj = row2[column2.ColumnName];
				if (obj == DBNull.Value)
				{
					continue;
				}
				if (column2.DataType == typeof(bool))
				{
					cell.SetCellValue(Convert.ToBoolean(obj));
					continue;
				}
				while (true)
				{
					if (!(column2.DataType == typeof(DateTime)))
					{
						if (!(column2.DataType == typeof(short)) && !(column2.DataType == typeof(int)) && !(column2.DataType == typeof(long)) && !(column2.DataType == typeof(ushort)) && !(column2.DataType == typeof(uint)) && !(column2.DataType == typeof(ulong)))
						{
							if (jMPIZWQsY8Ht3r8g8w1W == null)
							{
								switch (0)
								{
								case 1:
									break;
								default:
									goto IL_0307;
								case 2:
									goto IL_031f;
								}
								continue;
							}
							goto IL_0307;
						}
						goto IL_0381;
					}
					cell.SetCellValue(Convert.ToDateTime(obj));
					cell.CellStyle = cellStyle;
					break;
					IL_0307:
					if (!(column2.DataType == typeof(byte)))
					{
						goto IL_031f;
					}
					goto IL_0381;
					IL_031f:
					if (!(column2.DataType == typeof(sbyte)) && !(column2.DataType == typeof(double)) && !(column2.DataType == typeof(float)))
					{
						cell.SetCellValue(obj.ToString().ToShortString(32760));
						break;
					}
					goto IL_0381;
					IL_0381:
					cell.SetCellValue(Convert.ToDouble(obj));
					break;
				}
			}
			num4++;
		}
		workbook3.Write(stream);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) d8tg1V2OPVF(DataTable dataTable_0, ActionExecuteContext actionExecuteContext_0, ActionStep actionStep_0, XAction xaction_0, ActionVariable actionVariable_0)
	{
		string path = XActionHelper.GetTextParamValue(kobg1BbTBCC, actionStep_0, actionExecuteContext_0).Trim();
		path = path.PreProcessPath(true, true, false);
		string textParamValue = XActionHelper.GetTextParamValue(fN9g1QmhJ8v, actionStep_0, actionExecuteContext_0);
		int num = (int)XActionHelper.GetIntegerParamValue(oNQg1jJ09eY, actionStep_0, actionExecuteContext_0);
		FileStream fileStream = null;
		DataRow dataRow = null;
		IWorkbook workbook = null;
		ISheet sheet = null;
		IRow row = null;
		ICell cell = null;
		int num2 = num - 1;
		try
		{
			using (fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
			{
				if (path.EndsWithAny(true, ".xlsx", ".xlsm"))
				{
					workbook = new XSSFWorkbook((Stream)fileStream);
				}
				else
				{
					if (!path.EndsWith(".xls", StringComparison.OrdinalIgnoreCase))
					{
						return (isSuccess: false, message: "不支持读取此文件：" + path + "，仅支持.xslx,.xlsm,.xls文件。", failReason: ActionStopFlag.OperationFailed);
					}
					workbook = new HSSFWorkbook(fileStream);
				}
				sheet = (string.IsNullOrEmpty(textParamValue) ? workbook.GetSheetAt(0) : workbook.GetSheet(textParamValue));
				if (sheet == null)
				{
					return (isSuccess: false, message: "未找到数据表“" + textParamValue + "”", failReason: ActionStopFlag.OperationFailed);
				}
				int lastRowNum = sheet.LastRowNum;
				if (lastRowNum <= num2)
				{
					return (isSuccess: false, message: "表格中没有数据", failReason: ActionStopFlag.OperationFailed);
				}
				IRow row2 = sheet.GetRow(num2);
				if (row2 == null)
				{
					return (isSuccess: false, message: $"第{num2 + 1}行中没有内容。", failReason: ActionStopFlag.OperationFailed);
				}
				IDictionary<int, string> dictionary = new Dictionary<int, string>();
				for (int i = row2.FirstCellNum; i < row2.LastCellNum; i++)
				{
					cell = row2.GetCell(i);
					if (cell != null && cell.CellType != CellType.Blank && !string.IsNullOrWhiteSpace(cell.StringCellValue))
					{
						_003C_003Ec__DisplayClass81_0 _003C_003Ec__DisplayClass81_ = new _003C_003Ec__DisplayClass81_0();
						_003C_003Ec__DisplayClass81_.mQZSWCvYOV4 = cell.StringCellValue.Trim();
						if (dictionary.Any(_003C_003Ec__DisplayClass81_.qoRSW00CeFI))
						{
							_003C_003Ec__DisplayClass81_.mQZSWCvYOV4 = _003C_003Ec__DisplayClass81_.mQZSWCvYOV4 + "@" + i;
						}
						dictionary[i] = _003C_003Ec__DisplayClass81_.mQZSWCvYOV4;
					}
				}
				if (dictionary.Keys.Count == 0)
				{
					return (isSuccess: false, message: "未找到数据列", failReason: ActionStopFlag.OperationFailed);
				}
				if (dataTable_0.Columns.Count == 0)
				{
					foreach (KeyValuePair<int, string> item in dictionary)
					{
						dataTable_0.Columns.Add(item.Value, typeof(string));
					}
				}
				dictionary.Keys.Max();
				dictionary.Keys.Min();
				num2++;
				for (int j = num2; j <= lastRowNum; j++)
				{
					row = sheet.GetRow(j);
					if (row == null)
					{
						break;
					}
					dataRow = dataTable_0.NewRow();
					bool flag = false;
					foreach (KeyValuePair<int, string> item2 in dictionary)
					{
						string value = item2.Value;
						if (value == null || !dataTable_0.Columns.Contains(value))
						{
							continue;
						}
						cell = row.GetCell(item2.Key);
						if (cell != null && cell.CellType != CellType.Blank)
						{
							if (!string.IsNullOrEmpty(cell.ToString()))
							{
								flag = true;
							}
							e09g1ZQBOLs(cell, dataRow, dataTable_0, value);
						}
						else
						{
							dataRow[value] = "";
						}
					}
					if (flag)
					{
						dataTable_0.Rows.Add(dataRow);
						continue;
					}
					break;
				}
			}
			return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
		}
		finally
		{
			if (fileStream != null)
			{
				try
				{
					fileStream.Close();
				}
				catch (Exception)
				{
				}
			}
		}
	}

	private void e09g1ZQBOLs(ICell icell_0, DataRow dataRow_0, DataTable dataTable_0, string string_2)
	{
		if (icell_0.CellType == CellType.Blank)
		{
			dataRow_0[string_2] = "";
			return;
		}
		var (obj, value) = NPOIHelper.GetCellValue(icell_0);
		try
		{
			if (dataRow_0.Table.Columns[string_2].DataType == typeof(DateTime) && obj is double d)
			{
				dataRow_0[string_2] = DateTime.FromOADate(d);
			}
			else
			{
				dataRow_0[string_2] = obj;
			}
		}
		catch (Exception)
		{
			dataRow_0[string_2] = value;
		}
	}

	public static DateTime ConvertExcelDateToDateTime(double excelDate)
	{
		return DateTime.FromOADate(excelDate);
	}

	private void IBtg19T4UVb(DataTable dataTable_0, ActionExecuteContext actionExecuteContext_0, ActionStep actionStep_0, XAction xaction_0, ActionVariable actionVariable_0)
	{
		_003C_003Ec__DisplayClass84_0 _003C_003Ec__DisplayClass84_ = new _003C_003Ec__DisplayClass84_0();
		_003C_003Ec__DisplayClass84_.qWYSW8e7f9w = actionStep_0;
		_003C_003Ec__DisplayClass84_.fsVSWa1D0sQ = actionExecuteContext_0;
		_003C_003Ec__DisplayClass84_.jKcSWyJrpKN = nCsg1hgdHO7(dataTable_0, _003C_003Ec__DisplayClass84_.fsVSWa1D0sQ, _003C_003Ec__DisplayClass84_.qWYSW8e7f9w, actionVariable_0);
		XActionHelper.OutputResult(affectedRowCountParam, _003C_003Ec__DisplayClass84_.qWYSW8e7f9w, _003C_003Ec__DisplayClass84_.fsVSWa1D0sQ, _003C_003Ec__DisplayClass84_.jKcSWyJrpKN.Rows.Count, xaction_0);
		XActionHelper.OutputResultIfNeeded(jsonExportDataParam, _003C_003Ec__DisplayClass84_.GNnSWPlYyhm, _003C_003Ec__DisplayClass84_.qWYSW8e7f9w, _003C_003Ec__DisplayClass84_.fsVSWa1D0sQ, xaction_0);
		XActionHelper.OutputResultIfNeeded(csvExportDataParam, _003C_003Ec__DisplayClass84_.CGrSWEHAvV1, _003C_003Ec__DisplayClass84_.qWYSW8e7f9w, _003C_003Ec__DisplayClass84_.fsVSWa1D0sQ, xaction_0);
	}

	private static DataTable nCsg1hgdHO7(DataTable dataTable_0, ActionExecuteContext actionExecuteContext_0, ActionStep actionStep_0, ActionVariable actionVariable_0)
	{
		bool booleanParamValue = XActionHelper.GetBooleanParamValue(GCLg1o5Wbo9, actionStep_0, actionExecuteContext_0);
		string textParamValue = XActionHelper.GetTextParamValue(bpjg1KFVK0E, actionStep_0, actionExecuteContext_0);
		string textParamValue2 = XActionHelper.GetTextParamValue(oiEg1rZ9JU1, actionStep_0, actionExecuteContext_0);
		string textParamValue3 = XActionHelper.GetTextParamValue(zXSg1pXeaXB, actionStep_0, actionExecuteContext_0);
		object obj;
		if (textParamValue3 == null)
		{
			obj = null;
		}
		else
		{
			obj = textParamValue3.SplitToList(';', '；', ',', '，');
			if (obj != null)
			{
				goto IL_005a;
			}
		}
		obj = new string[0];
		goto IL_005a;
		IL_005a:
		string[] array = (string[])obj;
		try
		{
			if (!textParamValue.IsNullOrEmpty())
			{
				dataTable_0.DefaultView.RowFilter = textParamValue;
			}
			if (!textParamValue2.IsNullOrEmpty())
			{
				if (!BqpHPyQs8aJFCcRYNeoK())
				{
					switch (0)
					{
					}
				}
				dataTable_0.DefaultView.Sort = textParamValue2;
			}
			DataTable dataTable = (array.HasData() ? dataTable_0.DefaultView.ToTable(dataTable_0.TableName, false, array) : dataTable_0.DefaultView.ToTable());
			if (booleanParamValue && actionVariable_0 != null && actionVariable_0.TableDef?.Fields.HasData() == true)
			{
				dataTable = dataTable_0.Copy();
				foreach (TableField field in actionVariable_0.TableDef.Fields)
				{
					if (!field.Label.IsNullOrEmpty() && field.Label != field.FieldKey && dataTable.Columns.Contains(field.FieldKey))
					{
						dataTable.Columns[field.FieldKey].ColumnName = field.Label;
					}
				}
			}
			return dataTable;
		}
		finally
		{
			dataTable_0.DefaultView.RowFilter = "";
		}
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) VVUg1effX68(DataTable dataTable_0, ActionExecuteContext actionExecuteContext_0, ActionStep actionStep_0, XAction xaction_0, ActionVariable actionVariable_0)
	{
		string text = XActionHelper.GetTextParamValue(iDQg1m7PQOg, actionStep_0, actionExecuteContext_0);
		if (string.IsNullOrWhiteSpace(text))
		{
			return (isSuccess: false, message: "JSON内容为空。", failReason: ActionStopFlag.OperationFailed);
		}
		if (text[0] != '{' && text[0] != '[' && File.Exists(text))
		{
			text = File.ReadAllText(text, Encoding.UTF8);
		}
		if (XActionHelper.GetBooleanParamValue(Ewyg14oZT5k, actionStep_0, actionExecuteContext_0))
		{
			dataTable_0.Rows.Clear();
		}
		dataTable_0.mFighIebWbm(text);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) CaJg1YjglmO(DataTable dataTable_0, ActionExecuteContext actionExecuteContext_0, ActionStep actionStep_0, XAction xaction_0, ActionVariable actionVariable_0)
	{
		string textParamValue = XActionHelper.GetTextParamValue(iDQg1m7PQOg, actionStep_0, actionExecuteContext_0);
		string textParamValue2 = XActionHelper.GetTextParamValue(FGZg1TFn6eO, actionStep_0, actionExecuteContext_0);
		textParamValue2 = textParamValue2.Replace("\\t", "\t");
		bool booleanParamValue = XActionHelper.GetBooleanParamValue(Ewyg14oZT5k, actionStep_0, actionExecuteContext_0);
		if (string.IsNullOrWhiteSpace(textParamValue))
		{
			return (isSuccess: false, message: "CSV数据为空", failReason: ActionStopFlag.OperationFailed);
		}
		ImportCsv(dataTable_0, textParamValue2, textParamValue, booleanParamValue);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	public static void ImportCsv(DataTable table, string delimiter, string csvData, bool clearOldValue)
	{
		if (csvData.IndexOf('\n') == -1 && File.Exists(csvData))
		{
			csvData = File.ReadAllText(csvData, Encoding.Default);
		}
		if (clearOldValue)
		{
			table.Rows.Clear();
		}
		if (csvData.StartsWith("sep="))
		{
			delimiter = csvData[4].ToString();
			int num = csvData.IndexOf('\n');
			if (num > 0)
			{
				csvData = csvData.Substring(num + 1);
			}
		}
		CsvConfiguration csvConfiguration = new CsvConfiguration(CultureInfo.InvariantCulture)
		{
			PrepareHeaderForMatch = (_003C_003Ec.w5JSIfipi1m ?? (_003C_003Ec.w5JSIfipi1m = _003C_003Ec.s06SI3Lt3Pf.p2qSIlh4fZ1)),
			Delimiter = delimiter,
			BadDataFound = null
		};
		StringReader stringReader = default(StringReader);
		int num2;
		if (table.Columns.Count > 0)
		{
			stringReader = new StringReader(csvData);
			num2 = 0;
			if (jMPIZWQsY8Ht3r8g8w1W != null)
			{
				int num3 = default(int);
				num2 = num3;
			}
		}
		else
		{
			LoadCsvToDataTable(csvData, csvConfiguration, table);
			num2 = 0;
			if (BqpHPyQs8aJFCcRYNeoK())
			{
				goto IL_01b4;
			}
		}
		switch (num2)
		{
		default:
			try
			{
				using CsvReader csvReader = new CsvReader(stringReader, csvConfiguration);
				csvReader.Read();
				csvReader.ReadHeader();
				while (csvReader.Read())
				{
					DataRow dataRow = table.NewRow();
					foreach (DataColumn column in table.Columns)
					{
						dataRow[column.ColumnName] = csvReader.GetField(column.DataType, column.ColumnName);
					}
					table.Rows.Add(dataRow);
				}
				return;
			}
			finally
			{
				((IDisposable)stringReader)?.Dispose();
			}
		case 1:
			break;
		}
		goto IL_01b4;
		IL_01b4:
		foreach (DataColumn column2 in table.Columns)
		{
			column2.ReadOnly = false;
			if (column2.ColumnName.EndsWith(" "))
			{
				throw new InvalidDataException("列名 '" + column2.ColumnName + "' 中包含空格，请修正内容后重试。");
			}
		}
	}

	public static void LoadCsvToDataTable(string csvData, CsvConfiguration config, DataTable table)
	{
		using StringReader reader = new StringReader(csvData);
		using CsvReader csvReader = new CsvReader(reader, config);
		csvReader.Read();
		csvReader.ReadHeader();
		string[] headerRecord = csvReader.HeaderRecord;
		using DataTable dataTable = new DataTable();
		string[] array = headerRecord;
		foreach (string columnName in array)
		{
			dataTable.Columns.Add(columnName, typeof(string));
		}
		while (csvReader.Read())
		{
			DataRow dataRow = dataTable.NewRow();
			array = headerRecord;
			foreach (string text in array)
			{
				dataRow[text] = csvReader.GetField(text);
			}
			dataTable.Rows.Add(dataRow);
		}
		Dictionary<string, bool> dictionary = new Dictionary<string, bool>();
		IEnumerator enumerator = dataTable.Columns.GetEnumerator();
		int num = 0;
		if (jMPIZWQsY8Ht3r8g8w1W != null)
		{
			goto IL_01b5;
		}
		goto IL_01b9;
		IL_01b5:
		int num2 = default(int);
		num = num2;
		goto IL_01b9;
		IL_01b9:
		int num4 = default(int);
		do
		{
			switch (num)
			{
			default:
				try
				{
					while (enumerator.MoveNext())
					{
						_003C_003Ec__DisplayClass89_0 _003C_003Ec__DisplayClass89_ = new _003C_003Ec__DisplayClass89_0();
						_003C_003Ec__DisplayClass89_.PLLSWRsob5Z = (DataColumn)enumerator.Current;
						bool flag = dataTable.Rows.Cast<DataRow>().All(_003C_003Ec__DisplayClass89_.haiSW7KlSm5);
						dictionary[_003C_003Ec__DisplayClass89_.PLLSWRsob5Z.ColumnName] = flag;
						table.Columns.Add(_003C_003Ec__DisplayClass89_.PLLSWRsob5Z.ColumnName, flag ? typeof(decimal) : typeof(string));
					}
				}
				finally
				{
					if (enumerator is IDisposable disposable2)
					{
						disposable2.Dispose();
					}
				}
				break;
			case 1:
				try
				{
					while (enumerator.MoveNext())
					{
						DataRow dataRow2 = (DataRow)enumerator.Current;
						DataRow dataRow3 = table.NewRow();
						foreach (DataColumn column in dataTable.Columns)
						{
							if (dictionary[column.ColumnName])
							{
								if (decimal.TryParse(dataRow2[column].ToString(), out var result))
								{
									dataRow3[column.ColumnName] = result;
								}
								else
								{
									dataRow3[column.ColumnName] = DBNull.Value;
								}
								continue;
							}
							dataRow3[column.ColumnName] = dataRow2[column];
							int num3 = 0;
							if (!BqpHPyQs8aJFCcRYNeoK())
							{
								num3 = num4;
							}
							switch (num3)
							{
							}
						}
						table.Rows.Add(dataRow3);
					}
					return;
				}
				finally
				{
					if (enumerator is IDisposable disposable)
					{
						disposable.Dispose();
					}
				}
			}
			enumerator = dataTable.Rows.GetEnumerator();
			num = 1;
		}
		while (jMPIZWQsY8Ht3r8g8w1W == null);
		goto IL_01b5;
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) DtOg1IV8w4R(DataTable dataTable_0, ActionExecuteContext actionExecuteContext_0, ActionStep actionStep_0, XAction xaction_0, ActionVariable actionVariable_0)
	{
		string textParamValue = XActionHelper.GetTextParamValue(bpjg1KFVK0E, actionStep_0, actionExecuteContext_0);
		string textParamValue2 = XActionHelper.GetTextParamValue(oiEg1rZ9JU1, actionStep_0, actionExecuteContext_0);
		DataRow[] array = dataTable_0.Select(textParamValue, textParamValue2);
		XActionHelper.OutputResult(affectedRowCountParam, actionStep_0, actionExecuteContext_0, array.Length, xaction_0);
		XActionHelper.OutputResult(rowCountParam, actionStep_0, actionExecuteContext_0, array.Length, xaction_0);
		XActionHelper.OutputResult(rowsOutputParam, actionStep_0, actionExecuteContext_0, array, xaction_0);
		if (array.Length != 0 && XActionHelper.IsOutputParamSetted(firstRow.Key, actionStep_0))
		{
			XActionHelper.OutputResult(firstRow, actionStep_0, actionExecuteContext_0, array[0], xaction_0);
		}
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) ivqg1WGj5u0(DataTable dataTable_0, ActionExecuteContext actionExecuteContext_0, ActionStep actionStep_0, XAction xaction_0, ActionVariable actionVariable_0, bool bool_0)
	{
		_003C_003Ec__DisplayClass91_0 _003C_003Ec__DisplayClass91_ = new _003C_003Ec__DisplayClass91_0();
		_003C_003Ec__DisplayClass91_.xEoSWV1hRFT = dataTable_0;
		_003C_003Ec__DisplayClass91_.PvkSWZeqfmx = actionVariable_0;
		_003C_003Ec__DisplayClass91_.cUaSW9LRFaD = bool_0;
		_003C_003Ec__DisplayClass91_.BwcSWeH6fbY = actionExecuteContext_0;
		_003C_003Ec__DisplayClass91_.MMmSWs016Q0 = false;
		_003C_003Ec__DisplayClass91_.bO9SW1u7SLy = new ManualResetEvent(false);
		_003C_003Ec__DisplayClass91_.SA6SWGhFxrw = null;
		string textParamValue = XActionHelper.GetTextParamValue(dAJg1nIJuIX, actionStep_0, _003C_003Ec__DisplayClass91_.BwcSWeH6fbY);
		_003C_003Ec__DisplayClass91_.PxRSWYEQGxL = XActionHelper.GetTextParamValue(DZtg1DpiiGk, actionStep_0, _003C_003Ec__DisplayClass91_.BwcSWeH6fbY);
		_003C_003Ec__DisplayClass91_.SmxSWIVs2wO = XActionHelper.GetTextParamValue(YXLg1dInfx6, actionStep_0, _003C_003Ec__DisplayClass91_.BwcSWeH6fbY);
		_003C_003Ec__DisplayClass91_.OK5SWWW6KsY = XActionHelper.GetTextParamValue(zLSg1M12kPf, actionStep_0, _003C_003Ec__DisplayClass91_.BwcSWeH6fbY);
		_003C_003Ec__DisplayClass91_.qmoSWkDaqi6 = XActionHelper.GetBooleanParamValue(EWwg1A5Qs5M, actionStep_0, _003C_003Ec__DisplayClass91_.BwcSWeH6fbY);
		_003C_003Ec__DisplayClass91_.daQSWhAPLTS = GridSelectionMode.Cells;
		if (!string.IsNullOrWhiteSpace(textParamValue) && !Enum.TryParse<GridSelectionMode>(textParamValue, true, out _003C_003Ec__DisplayClass91_.daQSWhAPLTS))
		{
			return (isSuccess: false, message: "不支持的选择方式：" + textParamValue, failReason: ActionStopFlag.OperationFailed);
		}
		_003C_003Ec__DisplayClass91_.nEsSWH70eWp = false;
		AppHelper.RunOnUiThread(true, _003C_003Ec__DisplayClass91_.WhJSWqvXIob);
		_003C_003Ec__DisplayClass91_.bO9SW1u7SLy.WaitOne();
		XActionHelper.OutputResult(HQHg1lS9UHw, actionStep_0, _003C_003Ec__DisplayClass91_.BwcSWeH6fbY, _003C_003Ec__DisplayClass91_.nEsSWH70eWp, xaction_0);
		XActionHelper.OutputResultIfNeeded(selectedRowsParam, _003C_003Ec__DisplayClass91_.R7pSWcU4tBp, actionStep_0, _003C_003Ec__DisplayClass91_.BwcSWeH6fbY, xaction_0);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	private (bool isSuccess, string message, ActionStopFlag failReason) hs0g1kGWWWm(DataTable dataTable_0, ActionExecuteContext actionExecuteContext_0, ActionStep actionStep_0, XAction xaction_0)
	{
		_003C_003Ec__DisplayClass92_0 _003C_003Ec__DisplayClass92_ = new _003C_003Ec__DisplayClass92_0();
		IDictionary<string, object> dictParamValue = XActionHelper.GetDictParamValue(Oheg1XQ7BVM, actionStep_0, actionExecuteContext_0);
		if (dictParamValue == null)
		{
			return (isSuccess: false, message: "数据为空", failReason: ActionStopFlag.OperationFailed);
		}
		_003C_003Ec__DisplayClass92_.NYoSWKhpcvq = null;
		if (dataTable_0.Columns.Count == 0)
		{
			foreach (KeyValuePair<string, object> item in dictParamValue)
			{
				dataTable_0.Columns.Add(item.Key, (item.Value == null) ? typeof(string) : item.Value.GetType());
			}
			_003C_003Ec__DisplayClass92_.NYoSWKhpcvq = dataTable_0.NewRow();
			foreach (KeyValuePair<string, object> item2 in dictParamValue)
			{
				_003C_003Ec__DisplayClass92_.NYoSWKhpcvq[item2.Key] = item2.Value;
			}
			dataTable_0.Rows.Add(_003C_003Ec__DisplayClass92_.NYoSWKhpcvq);
		}
		else
		{
			_003C_003Ec__DisplayClass92_.NYoSWKhpcvq = dataTable_0.NewRow();
			foreach (KeyValuePair<string, object> item3 in dictParamValue)
			{
				if (dataTable_0.Columns.Contains(item3.Key))
				{
					_003C_003Ec__DisplayClass92_.NYoSWKhpcvq[item3.Key] = item3.Value;
				}
			}
			dataTable_0.Rows.Add(_003C_003Ec__DisplayClass92_.NYoSWKhpcvq);
		}
		XActionHelper.OutputResultIfNeeded(firstRow, _003C_003Ec__DisplayClass92_.ufsSWmH4RSu, actionStep_0, actionExecuteContext_0, xaction_0);
		return (isSuccess: true, message: "", failReason: ActionStopFlag.NoStop);
	}

	public string GetSummary(ActionStep step)
	{
		return XActionHelper.GetParamDisplayString(ubGg1bXJUv9, step) + " " + XActionHelper.GetParamDisplayString(o6wg16jsQ0R, step);
	}

	static TableOperationStep()
	{
		ubGg1bXJUv9 = new StepInParamDef
		{
			Key = "table",
			Name = "表格变量",
			Description = "要操作的表格变量",
			AllowInput = false,
			VariableMode = ParamVariableMode.UseVarOnly,
			Type = VarType.Table,
			IsRequired = true
		};
		o6wg16jsQ0R = new StepInParamDef
		{
			Key = "type",
			Name = "操作类型",
			Description = "",
			VariableMode = ParamVariableMode.Input,
			DefaultValue = "info",
			Type = VarType.Enum,
			IsControlField = true,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem("info", "获取信息"),
				new SelectionItem("addRow", "添加行"),
				new SelectionItem("update", "更新行"),
				new SelectionItem("manage", "查看或编辑数据"),
				new SelectionItem("select", "查询或筛选行(Select)"),
				new SelectionItem("clear", "清除所有行"),
				new SelectionItem("deleteRows", "删除符合条件的行"),
				new SelectionItem("deleteColumns", "删除列"),
				new SelectionItem("importCsv", "从CSV文本加载数据"),
				new SelectionItem("importJson", "从Json文本加载数据"),
				new SelectionItem("importExcel", "从Excel工作表加载数据"),
				new SelectionItem("export_text", "导出文本数据"),
				new SelectionItem("exportExcel", "导出Excel文件")
			}
		};
		Oheg1XQ7BVM = new StepInParamDef
		{
			Key = "rowData",
			Name = "行数据",
			Description = "包含行数据的词典；更新行时，仅包含要更新的列的内容。",
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Dict,
			ValidForList = new string[2] { "addRow", "update" },
			IsMultiLine = true
		};
		iDQg1m7PQOg = new StepInParamDef
		{
			Key = "dataText",
			Name = "文本数据",
			Description = "CSV/Json格式的文本内容",
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text,
			ValidForList = new string[2] { "importCsv", "importJson" },
			IsMultiLine = true
		};
		bpjg1KFVK0E = new StepInParamDef
		{
			Key = "filterExpression",
			Name = "筛选表达式",
			Description = "",
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text,
			ValidForList = new string[5] { "select", "exportExcel", "export_text", "deleteRows", "update" },
			IsMultiLine = false
		};
		Xhog1x8GKpS = new StepInParamDef
		{
			Key = "deleteColumns",
			Name = "要删除的列",
			Description = "可选。逗号','或分号';'隔开的列名，“*”表示删除所有列，“!列1,列2...”表示保留指定的列，删除其余的。",
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text,
			ValidForList = new string[1] { "deleteColumns" },
			IsMultiLine = false
		};
		oiEg1rZ9JU1 = new StepInParamDef
		{
			Key = "sort",
			Name = "排序",
			Description = "",
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text,
			ValidForList = new string[4] { "select", "exportExcel", "export_text", "manage" },
			IsMultiLine = false
		};
		zXSg1pXeaXB = new StepInParamDef
		{
			Key = "exportColumns",
			Name = "导出的列",
			Description = "可选。逗号','或分号';'隔开的列名。留空时导出所有列。",
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text,
			ValidForList = new string[2] { "exportExcel", "export_text" },
			IsMultiLine = false
		};
		kobg1BbTBCC = new StepInParamDef
		{
			Key = "excelFilePath",
			Name = "Excel文件路径",
			Description = "",
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text,
			ValidForList = new string[2] { "importExcel", "exportExcel" },
			IsMultiLine = false
		};
		fN9g1QmhJ8v = new StepInParamDef
		{
			Key = "sheetName",
			Name = "Excel工作表名",
			Description = "如果未指定，则取第一个工作表。工作表首行为标题行。",
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Text,
			ValidForList = new string[2] { "importExcel", "exportExcel" },
			IsMultiLine = false
		};
		oNQg1jJ09eY = new StepInParamDef
		{
			Key = "startRowNum",
			Name = "标题行号",
			Description = "标题行的行号（从1开始）。当前面有表头之类的内容时，行号会变大。",
			DefaultValue = 1,
			VariableMode = ParamVariableMode.UseVarOrInput,
			Type = VarType.Integer,
			ValidForList = new string[1] { "importExcel" },
			IsRequired = true
		};
		dAJg1nIJuIX = new StepInParamDef
		{
			Key = "gridSelectionMode",
			Name = "选择模式",
			Description = "注：单元格模式不支持返回选择的行。",
			VariableMode = ParamVariableMode.Input,
			DefaultValue = GridSelectionMode.Cells.ToString(),
			Type = VarType.Enum,
			SelectionItems = new List<SelectionItem>
			{
				new SelectionItem(GridSelectionMode.Cells.ToString(), "单元格(类似Excel)"),
				new SelectionItem(GridSelectionMode.OneRow.ToString(), "行：0行或1行"),
				new SelectionItem(GridSelectionMode.OneRowRequired.ToString(), "行：1行(必选)"),
				new SelectionItem(GridSelectionMode.Rows.ToString(), "行：0、1或多行"),
				new SelectionItem(GridSelectionMode.RowsRequired.ToString(), "行：一行或多行(必选)")
			},
			ValidForList = new string[1] { "manage" }
		};
		Ewyg14oZT5k = new StepInParamDef
		{
			Key = "clearOldRows",
			Name = "清除已有的行",
			DefaultValue = true,
			Description = "加载数据之前是否清除现有的行数据",
			Type = VarType.Boolean,
			ValidForList = new string[2] { "importCsv", "importJson" },
			VariableMode = ParamVariableMode.Input
		};
		HTWg15uHRvN = new StepInParamDef
		{
			Key = "isReadOnly",
			Name = "只读模式",
			DefaultValue = false,
			Description = "是否以只读模式打开",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new string[1] { "manage" }
		};
		DZtg1DpiiGk = new StepInParamDef
		{
			Key = "windowTitle",
			Name = "窗口标题",
			DefaultValue = "表格数据",
			Description = "",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new string[1] { "manage" }
		};
		YXLg1dInfx6 = new StepInParamDef
		{
			Key = "helpText",
			Name = "帮助文本",
			DefaultValue = "",
			Description = "",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new string[1] { "manage" }
		};
		GCLg1o5Wbo9 = new StepInParamDef
		{
			Key = "useColumnTitle",
			Name = "使用列标题而非列名作为导出数据的标题",
			DefaultValue = false,
			Description = "",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new string[2] { "exportExcel", "export_text" }
		};
		FGZg1TFn6eO = new StepInParamDef
		{
			Key = "csvDelimiter",
			Name = "CSV分隔符",
			DefaultValue = ",",
			Description = "导出或导入CSV数据时使用的字段分隔符。使用‘\\t’表示Tab。",
			Type = VarType.Text,
			VariableMode = ParamVariableMode.Input,
			ValidForList = new string[2] { "export_text", "importCsv" }
		};
		zLSg1M12kPf = new StepInParamDef
		{
			Key = "winSize",
			Name = "窗口尺寸/位置",
			Description = "设置选择窗口的最大尺寸，格式为：宽度,高度。支持像素数值或屏幕宽高百分比，详情请参考模块文档。",
			DefaultValue = "",
			Type = VarType.Text,
			IsRequired = false,
			VariableMode = ParamVariableMode.Input,
			IsAdvanced = true,
			TextTools = new List<TextToolType> { TextToolType.SelectLocationArea },
			ValidForList = new List<string> { "manage" }
		};
		EWwg1A5Qs5M = new StepInParamDef
		{
			Key = "topMost",
			Name = "是否置顶显示",
			Description = "是否置顶显示窗口",
			DefaultValue = false,
			IsRequired = false,
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.UseVarOrInput,
			IsAdvanced = true,
			ValidForList = new List<string> { "manage" }
		};
		Hpog1O4gJP6 = new StepInParamDef
		{
			Key = "stopIfFail",
			Name = "失败后停止",
			DefaultValue = true,
			Description = "失败后是否停止动作",
			Type = VarType.Boolean,
			VariableMode = ParamVariableMode.Input
		};
		H3ng1UarSvS = new StepOutParamDef
		{
			Key = "isSuccess",
			Name = "是否成功",
			Description = "操作是否成功",
			Type = VarType.Boolean
		};
		rowCountParam = new StepOutParamDef
		{
			Key = "rowCount",
			Name = "行数",
			Type = VarType.Integer,
			Description = "表格内的数据行数"
		};
		affectedRowCountParam = new StepOutParamDef
		{
			Key = "affectedRowCount",
			Name = "影响行数",
			Type = VarType.Integer,
			Description = "更新或删除、筛选的行数",
			ValidForList = new List<string> { "exportExcel", "export_text", "deleteRows", "update" }
		};
		rowsOutputParam = new StepOutParamDef
		{
			Key = "rows",
			Name = "行列表",
			Type = VarType.Object,
			Description = "符合条件的行的数组",
			ValidForList = new List<string> { "select", "info" }
		};
		columnsOutputParam = new StepOutParamDef
		{
			Key = "columns",
			Name = "列的列表",
			Type = VarType.Object,
			Description = "表格的列的信息列表(DataTable.Columns)",
			ValidForList = new List<string> { "info" }
		};
		firstRow = new StepOutParamDef
		{
			Key = "firstRow",
			Name = "第一行/结果行",
			Type = VarType.Object,
			Description = "第一个符合条件的行或新添加的行，可输出为词典对象",
			ValidForList = new List<string> { "select", "addRow" }
		};
		selectedRowsParam = new StepOutParamDef
		{
			Key = "selectedRows",
			Name = "选择的行列表",
			Type = VarType.Object,
			Description = "选择的所有行的列表",
			ValidForList = new List<string> { "manage" }
		};
		csvExportDataParam = new StepOutParamDef
		{
			Key = "csvExportData",
			Name = "CSV格式文本",
			Type = VarType.Text,
			ValidForList = new List<string> { "export_text" }
		};
		jsonExportDataParam = new StepOutParamDef
		{
			Key = "jsonExportData",
			Name = "Json格式文本",
			Type = VarType.Text,
			ValidForList = new List<string> { "export_text" }
		};
		HQHg1lS9UHw = new StepOutParamDef
		{
			Key = "isConfirmed",
			Name = "是否确认",
			Description = "是否点击了确认按钮",
			Type = VarType.Boolean,
			ValidForList = new List<string> { "manage" }
		};
	}

	internal static bool BqpHPyQs8aJFCcRYNeoK()
	{
		return jMPIZWQsY8Ht3r8g8w1W == null;
	}
}
