using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using Quicker.Public.Actions;
using t8SGKhhgLWTgeqjGcrq;

namespace Quicker.Domain.Actions.X;

public static class VarTypeExt
{
	private static object nS9Mg7QbFtrU3ypcwhHR;

	[Obsolete]
	public static string ToCSharpTypeName(VarType quickerVarType)
	{
		return quickerVarType switch
		{
			VarType.Any => "object", 
			VarType.Text => "string", 
			VarType.Number => "double", 
			VarType.Boolean => "bool", 
			VarType.Image => "System.Drawing.Bitmap", 
			VarType.List => "List<string>", 
			VarType.DateTime => "DateTime", 
			VarType.Enum => "string", 
			VarType.Dict => "Dictionary<string, object>", 
			VarType.Form => "object", 
			VarType.Integer => "long", 
			VarType.Table => "System.Data.DataTable", 
			_ => "object", 
		};
	}

	public static VarType CSharpTypeToVarType(this Type type)
	{
		int num;
		if ((object)type != null)
		{
			if (!(type == typeof(int)))
			{
				num = 0;
				if (!LOmmKTQbcUey0BLmWdxI())
				{
					goto IL_0136;
				}
				goto IL_013a;
			}
			goto IL_01cf;
		}
		goto IL_01d2;
		IL_01d2:
		return VarType.Any;
		IL_01cf:
		return VarType.Integer;
		IL_0136:
		int num2 = default(int);
		num = num2;
		goto IL_013a;
		IL_013a:
		while (true)
		{
			switch (num)
			{
			case 1:
				return VarType.DateTime;
			}
			if (type == typeof(short) || type == typeof(long) || type == typeof(ushort) || type == typeof(uint) || type == typeof(ulong) || type == typeof(IntPtr) || type == typeof(UIntPtr) || type == typeof(byte))
			{
				break;
			}
			if (!(type == typeof(decimal)) && !(type == typeof(float)) && !(type == typeof(double)))
			{
				if (type == typeof(DateTime))
				{
					num = 1;
					if (LOmmKTQbcUey0BLmWdxI())
					{
						continue;
					}
					goto IL_0136;
				}
				goto IL_014c;
			}
			return VarType.Number;
		}
		goto IL_01cf;
		IL_014c:
		if (type == typeof(string))
		{
			return VarType.Text;
		}
		if (type == typeof(bool))
		{
			return VarType.Boolean;
		}
		if (typeof(Image).IsAssignableFrom(type))
		{
			return VarType.Image;
		}
		if (typeof(IList<string>).IsAssignableFrom(type))
		{
			return VarType.List;
		}
		if (typeof(IDictionary<string, object>).IsAssignableFrom(type))
		{
			return VarType.Dict;
		}
		if (type == typeof(DataTable))
		{
			return VarType.Table;
		}
		goto IL_01d2;
	}

	internal static bool LOmmKTQbcUey0BLmWdxI()
	{
		return nS9Mg7QbFtrU3ypcwhHR == null;
	}
}
