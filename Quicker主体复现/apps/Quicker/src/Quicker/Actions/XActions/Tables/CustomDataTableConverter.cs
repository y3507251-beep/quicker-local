using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace Quicker.Actions.XActions.Tables;

public class CustomDataTableConverter : DataTableConverter
{
	private static CustomDataTableConverter HlLgYbQwvo2nbbBboC6F;

	public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
	{
		if (value == null)
		{
			writer.WriteNull();
			return;
		}
		DataTable obj = (DataTable)value;
		DefaultContractResolver defaultContractResolver = serializer.ContractResolver as DefaultContractResolver;
		writer.WriteStartArray();
		int num2 = default(int);
		foreach (DataRow row in obj.Rows)
		{
			writer.WriteStartObject();
			foreach (DataColumn column in row.Table.Columns)
			{
				object obj2 = row[column];
				if (serializer.NullValueHandling == NullValueHandling.Ignore)
				{
					int num = 0;
					if (!hvIVWBQwdkr9FJUUAfIj())
					{
						num = num2;
					}
					switch (num)
					{
					}
					if (obj2 == null || obj2 == DBNull.Value)
					{
						continue;
					}
				}
				writer.WritePropertyName((defaultContractResolver != null) ? defaultContractResolver.GetResolvedPropertyName(column.ColumnName) : column.ColumnName);
				serializer.Serialize(writer, obj2);
			}
			writer.WriteEndObject();
		}
		writer.WriteEndArray();
	}

	public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
	{
		if (reader.TokenType == JsonToken.Null)
		{
			return null;
		}
		DataTable dataTable = existingValue as DataTable;
		if (dataTable == null)
		{
			int num = 0;
			if (!hvIVWBQwdkr9FJUUAfIj())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			dataTable = ((objectType == typeof(DataTable)) ? new DataTable() : ((DataTable)Activator.CreateInstance(objectType)));
		}
		if (reader.TokenType == JsonToken.PropertyName)
		{
			dataTable.TableName = (string)reader.Value;
			reader.ReadAndAssert();
			if (reader.TokenType == JsonToken.Null)
			{
				return dataTable;
			}
		}
		if (reader.TokenType != JsonToken.StartArray)
		{
			throw new JsonSerializationException($"Unexpected JSON token when reading DataTable. Expected StartArray, got {reader.TokenType}.");
		}
		reader.ReadAndAssert();
		while (reader.TokenType != JsonToken.EndArray)
		{
			zh7ghk6aMKr(reader, dataTable, serializer);
			reader.ReadAndAssert();
		}
		return dataTable;
	}

	private static void zh7ghk6aMKr(JsonReader jsonReader_0, DataTable dataTable_0, JsonSerializer jsonSerializer_0)
	{
		DataRow dataRow = dataTable_0.NewRow();
		jsonReader_0.ReadAndAssert();
		int num2 = default(int);
		DataTable dataTable = default(DataTable);
		for (; jsonReader_0.TokenType == JsonToken.PropertyName; jsonReader_0.ReadAndAssert())
		{
			string text = (string)jsonReader_0.Value;
			jsonReader_0.ReadAndAssert();
			DataColumn dataColumn = dataTable_0.Columns[text];
			if (dataColumn == null)
			{
				goto IL_00a6;
			}
			goto IL_00c6;
			IL_0072:
			int num = num2;
			goto IL_0076;
			IL_00c6:
			if (dataColumn.DataType == typeof(DataTable))
			{
				if (jsonReader_0.TokenType == JsonToken.StartArray)
				{
					jsonReader_0.ReadAndAssert();
					num = 1;
					if (HlLgYbQwvo2nbbBboC6F != null)
					{
						goto IL_0072;
					}
					goto IL_0076;
				}
				goto IL_009d;
			}
			if (dataColumn.DataType.IsArray && dataColumn.DataType != typeof(byte[]))
			{
				if (jsonReader_0.TokenType == JsonToken.StartArray)
				{
					jsonReader_0.ReadAndAssert();
				}
				List<object> list = new List<object>();
				while (jsonReader_0.TokenType != JsonToken.EndArray)
				{
					list.Add(jsonReader_0.Value);
					jsonReader_0.ReadAndAssert();
				}
				Array array = Array.CreateInstance(dataColumn.DataType.GetElementType(), list.Count);
				((ICollection)list).CopyTo(array, 0);
				dataRow[text] = array;
				continue;
			}
			goto IL_017f;
			IL_0076:
			switch (num)
			{
			case 1:
				goto IL_009d;
			case 3:
				goto IL_00a6;
			case 2:
				goto IL_017f;
			}
			jsonReader_0.ReadAndAssert();
			goto IL_0091;
			IL_017f:
			object value = ((jsonReader_0.Value != null) ? (jsonSerializer_0.Deserialize(jsonReader_0, dataColumn.DataType) ?? DBNull.Value) : DBNull.Value);
			dataRow[text] = value;
			continue;
			IL_009d:
			dataTable = new DataTable();
			goto IL_0091;
			IL_0091:
			if (jsonReader_0.TokenType != JsonToken.EndArray)
			{
				zh7ghk6aMKr(jsonReader_0, dataTable, jsonSerializer_0);
				num = 0;
				if (HlLgYbQwvo2nbbBboC6F != null)
				{
					goto IL_0072;
				}
				goto IL_0076;
			}
			dataRow[text] = dataTable;
			continue;
			IL_00a6:
			Type dataType = eO4ghGhANCD(jsonReader_0);
			dataColumn = new DataColumn(text, dataType);
			dataTable_0.Columns.Add(dataColumn);
			goto IL_00c6;
		}
		dataRow.EndEdit();
		dataTable_0.Rows.Add(dataRow);
	}

	private static Type eO4ghGhANCD(JsonReader jsonReader_0)
	{
		JsonToken tokenType = jsonReader_0.TokenType;
		switch (tokenType)
		{
		case JsonToken.StartArray:
			jsonReader_0.ReadAndAssert();
			if (jsonReader_0.TokenType == JsonToken.StartObject)
			{
				return typeof(DataTable);
			}
			return eO4ghGhANCD(jsonReader_0).MakeArrayType();
		case JsonToken.Integer:
		case JsonToken.Float:
			return typeof(decimal);
		case JsonToken.Null:
		case JsonToken.Undefined:
		case JsonToken.EndArray:
			return typeof(string);
		default:
			throw new JsonSerializationException($"Unexpected JSON token when reading DataTable: {tokenType}");
		case JsonToken.String:
		case JsonToken.Boolean:
		case JsonToken.Date:
		case JsonToken.Bytes:
			return jsonReader_0.ValueType;
		}
	}

	public override bool CanConvert(Type valueType)
	{
		return typeof(DataTable).IsAssignableFrom(valueType);
	}

	internal static bool hvIVWBQwdkr9FJUUAfIj()
	{
		return HlLgYbQwvo2nbbBboC6F == null;
	}
}
