using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using Quicker.Public.Actions;
using t8SGKhhgLWTgeqjGcrq;

namespace Quicker.Domain.Actions.X;

public class VarTypeInfo
{
	[CompilerGenerated]
	private string Nr2t5llXaa0;

	[CompilerGenerated]
	private Type DlNt5iIdC20;

	[CompilerGenerated]
	private ICollection<VarType> oD5t53TH7aR;

	private static IDictionary<VarType, VarTypeInfo> oE1t5fLA8IZ;

	internal static VarTypeInfo W46UkhQfHixA14jgdp8V;

	public string CSTypeName
	{
		[CompilerGenerated]
		get
		{
			return Nr2t5llXaa0;
		}
		[CompilerGenerated]
		set
		{
			Nr2t5llXaa0 = value;
		}
	}

	public Type CSType
	{
		[CompilerGenerated]
		get
		{
			return DlNt5iIdC20;
		}
		[CompilerGenerated]
		set
		{
			DlNt5iIdC20 = value;
		}
	}

	public ICollection<VarType> CanConvertFrom
	{
		[CompilerGenerated]
		get
		{
			return oD5t53TH7aR;
		}
		[CompilerGenerated]
		set
		{
			oD5t53TH7aR = value;
		}
	}

	public VarTypeInfo(Type csType, string csTypeName, ICollection<VarType> canConvertFrom)
	{
		CSType = csType;
		CSTypeName = csTypeName;
		CanConvertFrom = canConvertFrom;
	}

	public static Type GetCSType(VarType type)
	{
		return oE1t5fLA8IZ[type]?.CSType;
	}

	public static string GetCsTypeName(VarType type)
	{
		if (oE1t5fLA8IZ.TryGetValue(type, out var value))
		{
			if (value == null)
			{
				return "object";
			}
			return value.CSTypeName;
		}
		return "object";
	}

	static VarTypeInfo()
	{
		oE1t5fLA8IZ = new Dictionary<VarType, VarTypeInfo>
		{
			{
				VarType.Text,
				new VarTypeInfo(typeof(string), "string", new VarType[7]
				{
					VarType.Number,
					VarType.Boolean,
					VarType.Dict,
					VarType.Integer,
					VarType.List,
					VarType.Enum,
					VarType.Table
				})
			},
			{
				VarType.Number,
				new VarTypeInfo(typeof(double), "double", new VarType[1] { VarType.Integer })
			},
			{
				VarType.Integer,
				new VarTypeInfo(typeof(long), "long", new VarType[1] { VarType.Number })
			},
			{
				VarType.Boolean,
				new VarTypeInfo(typeof(bool), "bool", new VarType[1] { VarType.Integer })
			},
			{
				VarType.Image,
				new VarTypeInfo(typeof(Bitmap), "System.Drawing.Bitmap", new VarType[0])
			},
			{
				VarType.DateTime,
				new VarTypeInfo(typeof(DateTime), "DateTime", new VarType[1] { VarType.Integer })
			},
			{
				VarType.List,
				new VarTypeInfo(typeof(List<string>), "List<string>", new VarType[0])
			},
			{
				VarType.Enum,
				new VarTypeInfo(typeof(string), "string", new VarType[2]
				{
					VarType.Text,
					VarType.Integer
				})
			},
			{
				VarType.Dict,
				new VarTypeInfo(typeof(Dictionary<string, object>), "Dictionary<string, object>", new VarType[0])
			},
			{
				VarType.Form,
				new VarTypeInfo(typeof(object), "object", new VarType[0])
			},
			{
				VarType.Table,
				new VarTypeInfo(typeof(DataTable), "System.Data.DataTable", new VarType[0])
			},
			{
				VarType.Object,
				new VarTypeInfo(typeof(object), "object", new VarType[0])
			}
		};
	}

	internal static bool zk6ysGQfzFM07idfWcVo()
	{
		return W46UkhQfHixA14jgdp8V == null;
	}
}
