using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using CsvHelper;
using CsvHelper.Configuration;
using Newtonsoft.Json;
using Quicker.Actions.XActions.Storage;
using Quicker.Actions.XActions.Tables;
using Quicker.Domain.Actions.X;

namespace j9PVNbXS3U4MP7j5Ps6;

internal static class zsVr57XToYMFTdxtZho
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec kpKS9lqFDSh;

		public static Func<TableField, bool> YkbS9i7iHMF;

		private static _003C_003Ec RNdy52W98sIJ4E75xN9M;

		static _003C_003Ec()
		{
			kpKS9lqFDSh = new _003C_003Ec();
		}

		internal bool f60S9UKxhcq(TableField x)
		{
			return x.IsKey;
		}

		internal static bool NKqd7hW9RUgo240DPgKW()
		{
			return RNdy52W98sIJ4E75xN9M == null;
		}
	}

	internal static object JiHRHSQwDpX3hFTw3T4p;

	public static DataTable Xdighe7tCeS(string string_0)
	{
		return new DataTable();
	}

	internal static void aNOghYZ7hRs(DataTable dataTable_0, TableDef tableDef_0)
	{
		if (dataTable_0 == null)
		{
			throw new ArgumentNullException("table");
		}
		if (tableDef_0 == null)
		{
			throw new ArgumentNullException("tableDef");
		}
		IEnumerator<TableField> enumerator = tableDef_0.Fields.GetEnumerator();
		if (qE2JLnQw32PJJn1ta8s1())
		{
			switch (0)
			{
			}
		}
		try
		{
			while (enumerator.MoveNext())
			{
				TableField current = enumerator.Current;
				DataColumn dataColumn = new DataColumn();
				dataColumn.ColumnName = current.FieldKey;
				dataColumn.Caption = current.Label;
				dataColumn.DataType = VarTypeInfo.GetCSType(current.QuickerVarType);
				dataColumn.MaxLength = ((current.MaxLength <= 0) ? (-1) : current.MaxLength);
				dataColumn.Expression = current.ComputeExpression;
				dataColumn.Unique = current.IsUnique;
				dataColumn.AutoIncrement = current.AutoIncrement;
				if (current.AutoIncrement)
				{
					dataColumn.AutoIncrementSeed = 1L;
					if (JiHRHSQwDpX3hFTw3T4p == null)
					{
						switch (0)
						{
						}
					}
					dataColumn.AutoIncrementStep = 1L;
				}
				dataColumn.AllowDBNull = current.AllowNull;
				dataTable_0.Columns.Add(dataColumn);
			}
		}
		finally
		{
			enumerator?.Dispose();
		}
		int num = tableDef_0.Fields.Count(_003C_003Ec.YkbS9i7iHMF ?? (_003C_003Ec.YkbS9i7iHMF = _003C_003Ec.kpKS9lqFDSh.f60S9UKxhcq));
		if (num <= 0)
		{
			return;
		}
		DataColumn[] array = new DataColumn[num];
		int num2 = 0;
		foreach (TableField field in tableDef_0.Fields)
		{
			if (field.IsKey)
			{
				array[num2++] = dataTable_0.Columns[field.FieldKey];
			}
		}
		dataTable_0.PrimaryKey = array;
	}

	public static void mFighIebWbm(this DataTable dataTable_0, string string_0)
	{
		while (string.IsNullOrEmpty(string_0))
		{
			if (!qE2JLnQw32PJJn1ta8s1())
			{
				switch (0)
				{
				default:
					return;
				case 1:
					break;
				case 0:
					return;
				}
				continue;
			}
			return;
		}
		if (string_0.StartsWith("{"))
		{
			Dictionary<string, object>? obj = JsonConvert.DeserializeObject<Dictionary<string, object>>(string_0) ?? throw new InvalidDataException("无法解析json数据。");
			if (!dataTable_0.Columns.Contains("Key"))
			{
				dataTable_0.Columns.Add("Key");
			}
			if (!dataTable_0.Columns.Contains("Value"))
			{
				dataTable_0.Columns.Add("Value");
			}
			{
				foreach (KeyValuePair<string, object> item in obj)
				{
					DataRow dataRow = dataTable_0.NewRow();
					dataRow["Key"] = item.Key;
					dataRow["Value"] = item.Value;
					dataTable_0.Rows.Add(dataRow);
				}
				return;
			}
		}
		JsonSerializerSettings settings = new JsonSerializerSettings
		{
			Converters = new List<JsonConverter>
			{
				new CustomDataTableConverter()
			}
		};
		DataTable dataTable = JsonConvert.DeserializeObject<DataTable>(string_0, settings);
		if (dataTable != null)
		{
			if (dataTable_0.Columns.Count == 0)
			{
				dataTable_0.Merge(dataTable, true, MissingSchemaAction.Add);
			}
			else
			{
				dataTable_0.Merge(dataTable, true, MissingSchemaAction.Ignore);
			}
		}
	}

	public static string FlnghWSaqEt(this DataTable dataTable_0, string string_0 = ",")
	{
		CsvConfiguration configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
		{
			Delimiter = string_0
		};
		using StringWriter stringWriter = new StringWriter();
		using CsvWriter csvWriter = new CsvWriter(stringWriter, configuration);
		foreach (DataColumn column2 in dataTable_0.Columns)
		{
			csvWriter.WriteField(column2.ColumnName);
		}
		csvWriter.NextRecord();
		foreach (DataRow row in dataTable_0.Rows)
		{
			foreach (DataColumn column3 in dataTable_0.Columns)
			{
				csvWriter.WriteField(row[column3]);
			}
			csvWriter.NextRecord();
		}
		return stringWriter.ToString();
	}

	internal static bool qE2JLnQw32PJJn1ta8s1()
	{
		return JiHRHSQwDpX3hFTw3T4p == null;
	}
}
