using System;
using System.Collections;
using System.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Quicker.Modules.Tables;

public class DataRowConverter : JsonConverter<DataRow>
{
	internal static DataRowConverter jQfGEYQXw7ZWgDPkQvoq;

	public override DataRow ReadJson(JsonReader reader, Type objectType, DataRow existingValue, bool hasExistingValue, JsonSerializer serializer)
	{
		throw new NotImplementedException($"{this} is only implemented for writing.");
	}

	public override void WriteJson(JsonWriter writer, DataRow row, JsonSerializer serializer)
	{
		if (row.Table == null)
		{
			throw new JsonSerializationException("no table");
		}
		DefaultContractResolver defaultContractResolver = serializer.ContractResolver as DefaultContractResolver;
		writer.WriteStartObject();
		IEnumerator enumerator = row.Table.Columns.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				DataColumn dataColumn = (DataColumn)enumerator.Current;
				object obj = row[dataColumn];
				if (serializer.NullValueHandling != NullValueHandling.Ignore || (obj != null && obj != DBNull.Value))
				{
					writer.WritePropertyName((defaultContractResolver != null) ? defaultContractResolver.GetResolvedPropertyName(dataColumn.ColumnName) : dataColumn.ColumnName);
					serializer.Serialize(writer, obj);
				}
			}
			int num = 0;
			if (jQfGEYQXw7ZWgDPkQvoq != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		finally
		{
			IDisposable disposable = enumerator as IDisposable;
			if (disposable != null)
			{
				disposable.Dispose();
			}
		}
		writer.WriteEndObject();
	}

	internal static bool aBPRRqQXTpi6kF8rKeh9()
	{
		return jQfGEYQXw7ZWgDPkQvoq == null;
	}
}
