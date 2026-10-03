using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using kW0t3ooZQYAATcNC18E;

namespace xSOcTvoQP9NTnOElnZ2;

internal class Nxrh9MoBlq9v1djPPCQ : olb2LsoRc3yv3FKL3dU
{
	private readonly DataTable G7bgBqeJIgI;

	private static Nxrh9MoBlq9v1djPPCQ tK6PmZQhhCFZWG45ChaF;

	public override IEnumerable<object> Rows => G7bgBqeJIgI.Rows.Cast<object>();

	public Nxrh9MoBlq9v1djPPCQ(DataTable dataTable_1)
	{
		G7bgBqeJIgI = dataTable_1;
		base.Columns = new List<string>();
		foreach (DataColumn column in dataTable_1.Columns)
		{
			base.Columns.Add(column.ColumnName);
		}
	}

	public override object e3YMj7JO69O(object object_0, string string_0)
	{
		if (!(object_0 is DataRow dataRow))
		{
			throw new InvalidDataException("给定的Row不是DataRow对象");
		}
		return dataRow[string_0];
	}

	internal static bool POe7W7QhHOs6Zan6uAVg()
	{
		return tK6PmZQhhCFZWG45ChaF == null;
	}
}
