using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Web;
using d91F2HX0Pk7LuKbowAc;
using j9PVNbXS3U4MP7j5Ps6;
using log4net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Python.Runtime;
using Quicker.Modules.Tables;
using Quicker.Public.Actions;
using Quicker.Public.Extensions;
using Quicker.Public.Searching;
using Quicker.Utilities;
using Quicker.Utilities._3rd;
using Quicker.Utilities.Images;

namespace Quicker.Domain.Actions.X.Variables;

public static class VariableHelper
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec XtvS94FViHj;

		public static Func<string, string> AJ2S95v9Ler;

		public static Func<object, string> BOgS9Drbemu;

		public static Func<object, string> KhiS9d7k7fD;

		internal static _003C_003Ec x1e7R8W9o2xJg5sF5yAO;

		static _003C_003Ec()
		{
			XtvS94FViHj = new _003C_003Ec();
		}

		internal string ng3S9Q97Eyy(string x)
		{
			return x.Trim('\r');
		}

		internal string ughS9jLiXu0(object x)
		{
			object obj;
			if (x != null)
			{
				obj = x.ToString();
				if (obj != null)
				{
					goto IL_0015;
				}
			}
			else
			{
				obj = null;
			}
			obj = "";
			goto IL_0015;
			IL_0015:
			return (string)obj;
		}

		internal string it3S9ndAgc5(object x)
		{
			return x?.ToString();
		}

		internal static bool zATt0yW9fgonWFHsadY6()
		{
			return x1e7R8W9o2xJg5sF5yAO == null;
		}
	}

	[CompilerGenerated]
	private static class _003C_003Eo__7
	{
		public static CallSite<Func<CallSite, object, object>> x50S9ohsp2m;

		public static CallSite<Func<CallSite, object, object>> QJkS9Tp2K4o;

		public static CallSite<Func<CallSite, object, object>> yXSS9MM4hT1;

		public static CallSite<Action<CallSite, Dictionary<string, object>, object, object>> zIZS9ANBGRw;

		public static CallSite<Func<CallSite, object, IEnumerable>> bZjS9OVtntp;
	}

	[CompilerGenerated]
	private static class _003C_003Eo__9
	{
		public static CallSite<Func<CallSite, object, object[]>> APCS9FTN6dr;
	}

	private static readonly ILog J2EghZw8O2p;

	private static string[] SCggh9UauZR;

	private static readonly string[] u0pghhQdPFH;

	internal static object MtRV2mQwnN8FiplUxHM0;

	public static bool IsAssignable(VarType fromType, VarType toType)
	{
		int num = 1;
		while (fromType != VarType.Any)
		{
			int num2 = 0;
			if (!STnJE6QweW8NN8qJ8SEd())
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			if (toType == VarType.Any)
			{
				break;
			}
			if ((fromType == VarType.Integer && toType == VarType.Number) || (fromType == VarType.Number && toType == VarType.Integer))
			{
				return true;
			}
			return toType switch
			{
				VarType.Text => fromType != VarType.Image, 
				VarType.Enum => fromType == VarType.Text, 
				VarType.List => fromType.IsEither(VarType.Text, VarType.Any, VarType.List), 
				VarType.Object => fromType.IsEither(VarType.Object, VarType.Any, VarType.Table, VarType.Image), 
				_ => toType == fromType, 
			};
		}
		return true;
	}

	public static bool StringToBool(string value)
	{
		return SCggh9UauZR.Contains(value.ToLowerInvariant());
	}

	public static object ConvertVarDefaultValue(VarType varType, string defaultValueStr)
	{
		switch (varType)
		{
		case VarType.Any:
			if (!string.IsNullOrEmpty(defaultValueStr))
			{
				return defaultValueStr;
			}
			goto default;
		case VarType.Text:
			return defaultValueStr;
		case VarType.Number:
		{
			if (!string.IsNullOrEmpty(defaultValueStr) && double.TryParse(defaultValueStr, out var result4))
			{
				return result4;
			}
			return 0;
		}
		case VarType.Boolean:
			if (!string.IsNullOrEmpty(defaultValueStr))
			{
				return ConvertToBoolean(defaultValueStr);
			}
			return false;
		case VarType.Image:
			if (!string.IsNullOrEmpty(defaultValueStr) && File.Exists(defaultValueStr))
			{
				return ImageHelper.ReadImageFromFileWithoutLock(defaultValueStr);
			}
			goto default;
		case VarType.List:
			if (!string.IsNullOrEmpty(defaultValueStr))
			{
				return ConvertToType(VarType.List, defaultValueStr);
			}
			return new List<string>();
		case VarType.DateTime:
			if (!string.IsNullOrEmpty(defaultValueStr))
			{
				if (double.TryParse(defaultValueStr, out var result2))
				{
					return DateTime.Now.AddDays(result2);
				}
				DateTime result3 = DateTime.Now;
				if (DateTime.TryParse(defaultValueStr, out result3))
				{
					return result3;
				}
			}
			return DateTime.Now;
		case VarType.Dict:
			if (!string.IsNullOrEmpty(defaultValueStr))
			{
				return ConvertToType(VarType.Dict, defaultValueStr);
			}
			return new Dictionary<string, object>();
		default:
			return null;
		case VarType.Integer:
		{
			if (!string.IsNullOrEmpty(defaultValueStr) && long.TryParse(defaultValueStr, out var result))
			{
				return result;
			}
			return 0;
		}
		case VarType.Table:
			return zsVr57XToYMFTdxtZho.Xdighe7tCeS(defaultValueStr);
		}
	}

	public static object ConvertToType(VarType type, object value)
	{
		if (value == null)
		{
			switch (type)
			{
			case VarType.Text:
				return string.Empty;
			case VarType.Boolean:
				return false;
			case VarType.List:
				return new List<string>();
			case VarType.DateTime:
				return DateTime.MinValue;
			case VarType.Dict:
				return new Dictionary<string, object>();
			default:
				return null;
			case VarType.Number:
			case VarType.Integer:
				return 0;
			case VarType.Table:
				return new DataTable();
			}
		}
		try
		{
			switch (type)
			{
			case VarType.Text:
				return LcfghRCibTg(value);
			case VarType.Number:
				return KeZghads0f1(value);
			case VarType.Boolean:
				return ConvertToBoolean(value);
			case VarType.List:
				return ConvertToList(value);
			case VarType.Dict:
				return ConvertToDict(value);
			default:
				return value;
			case VarType.Integer:
				return i1Xgh8pXfbv(value);
			case VarType.Table:
				if (value is DataTable result)
				{
					if (!STnJE6QweW8NN8qJ8SEd())
					{
						switch (0)
						{
						case 1:
							goto end_IL_0078;
						}
					}
					return result;
				}
				throw new InvalidOperationException("不支持转换为表格变量");
			case VarType.DateTime:
				break;
				end_IL_0078:
				break;
			}
			return nlXghqLe3Ux(value);
		}
		catch (Exception ex)
		{
			throw new InvalidCastException($"不支持的格式转换，目标类型：{type}  源对象：{value.GetType()}  {value} ex:{ex.Message}", ex);
		}
	}

	private static long i1Xgh8pXfbv(object object_0)
	{
		if (object_0 == null)
		{
			return 0L;
		}
		if (object_0 is long num)
		{
			return num;
		}
		if (object_0 is IntPtr)
		{
			return (long)(IntPtr)object_0;
		}
		if (object_0 is string text)
		{
			if (long.TryParse(text, out var result))
			{
				return result;
			}
			return Convert.ToInt64(FqwghVEafu7(text));
		}
		JValue jValue = object_0 as JValue;
		int num2 = 0;
		if (!STnJE6QweW8NN8qJ8SEd())
		{
			int num3 = default(int);
			num2 = num3;
		}
		return num2 switch
		{
			_ => jValue?.ToObject<long>() ?? Convert.ToInt64(object_0, CultureInfo.InvariantCulture), 
		};
	}

	public static IDictionary<string, object> ConvertToDict(object value)
	{
		if (value == null)
		{
			return new Dictionary<string, object>();
		}
		if (value is IDictionary<string, object> result)
		{
			return result;
		}
		if (value is JObject jObject)
		{
			return jObject.ToObject<IDictionary<string, object>>();
		}
		if (value is PyObject pyObject)
		{
			new List<string>();
			return JsonConvert.DeserializeObject<Dictionary<string, object>>(pyObject.ToString());
		}
		if (value.IsDictionary())
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			{
				foreach (dynamic item in (dynamic)value)
				{
					dictionary.Add(item.Key.ToString(), (object)item.Value);
				}
				return dictionary;
			}
		}
		if (value is string text)
		{
			if (!text.StartsWith("json:", StringComparison.OrdinalIgnoreCase) && (!text.Trim().StartsWith("{", StringComparison.Ordinal) || !text.Trim().EndsWith("}")))
			{
				string[] array = text.Split(new char[2] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
				IDictionary<string, object> dictionary2 = new Dictionary<string, object>();
				string[] allKeys;
				if (array.Length == 1 && array[0].IndexOf(':') < 0 && array[0].IndexOf('=') > 0)
				{
					NameValueCollection nameValueCollection = HttpUtility.ParseQueryString(text);
					allKeys = nameValueCollection.AllKeys;
					foreach (string text2 in allKeys)
					{
						dictionary2.Add(text2, nameValueCollection[text2]);
					}
					return dictionary2;
				}
				allKeys = array;
				int i = 0;
				string text3;
				while (true)
				{
					if (i < allKeys.Length)
					{
						string obj = allKeys[i];
						int num = obj.IndexOf(':');
						if (num >= 1)
						{
							text3 = obj.Substring(0, num);
							string value2 = obj.Substring(num + 1);
							if (dictionary2.ContainsKey(text3))
							{
								break;
							}
							dictionary2.Add(new KeyValuePair<string, object>(text3, value2));
							i++;
							continue;
						}
						throw new InvalidDataException("键值对数据不合法，每行的格式为  Key:Value");
					}
					return dictionary2;
				}
				throw new InvalidDataException("键 \"" + text3 + "\" 已存在！");
			}
			string value3 = (text.StartsWith("json:", StringComparison.OrdinalIgnoreCase) ? text.Substring("json:".Length) : text);
			if (!string.IsNullOrWhiteSpace(value3))
			{
				return JsonConvert.DeserializeObject<Dictionary<string, object>>(value3);
			}
			return new Dictionary<string, object>();
		}
		if (value is DataRow row)
		{
			return row.ToDict();
		}
		if (value.IsList())
		{
			throw new InvalidDataException("无法将列表转换为词典类型。");
		}
		try
		{
			return value.ToDictionary();
		}
		catch (Exception ex)
		{
			throw new InvalidDataException("无法转换为词典类型。" + ex.Message);
		}
	}

	private static double? KeZghads0f1(object object_0)
	{
		if (object_0 is double num)
		{
			return num;
		}
		if (object_0 is IntPtr)
		{
			return Convert.ToDouble((int)(IntPtr)object_0);
		}
		if (object_0 is string text)
		{
			if (double.TryParse(text, out var result))
			{
				return result;
			}
			return FqwghVEafu7(text);
		}
		if (object_0 is JValue jValue)
		{
			return jValue.ToObject<double>();
		}
		return Convert.ToDouble(object_0, CultureInfo.InvariantCulture);
	}

	public static IEnumerable<string> ConvertToList(object value)
	{
		if (value is List<string>)
		{
			return value as List<string>;
		}
		if (value is string text)
		{
			if (text.StartsWith("[") && text.EndsWith("]"))
			{
				try
				{
					return JsonConvert.DeserializeObject<List<string>>(text);
				}
				catch (Exception)
				{
				}
			}
			if (string.IsNullOrEmpty(text))
			{
				return new List<string>();
			}
			return text.Split('\n').Select(_003C_003Ec.AJ2S95v9Ler ?? (_003C_003Ec.AJ2S95v9Ler = _003C_003Ec.XtvS94FViHj.ng3S9Q97Eyy)).ToList();
		}
		if (value is IEnumerable)
		{
			return (value as IEnumerable).Cast<object>().Select(_003C_003Ec.BOgS9Drbemu ?? (_003C_003Ec.BOgS9Drbemu = _003C_003Ec.XtvS94FViHj.ughS9jLiXu0)).ToList();
		}
		if (!(value is PyObject pyObject))
		{
			throw new InvalidCastException();
		}
		return ((object[])(dynamic)pyObject).Select(_003C_003Ec.KhiS9d7k7fD ?? (_003C_003Ec.KhiS9d7k7fD = _003C_003Ec.XtvS94FViHj.it3S9ndAgc5)).ToList();
	}

	private static Type XNHgh7Xr1Ds(object object_0)
	{
		Type type = object_0.GetType().GetInterface(typeof(IEnumerable<>).Name);
		if (!(type != null))
		{
			return null;
		}
		return type.GetGenericArguments()[0];
	}

	public static bool IsSimple(this Type type)
	{
		return TypeDescriptor.GetConverter(type).CanConvertFrom(typeof(string));
	}

	internal static string LcfghRCibTg(object object_0)
	{
		if (object_0 == null)
		{
			return string.Empty;
		}
		if (object_0 is string result)
		{
			return result;
		}
		if (!(object_0 is IList<string>))
		{
			if (!object_0.IsDictionary() && !(object_0 is CustomSearchResult))
			{
				JValue jValue = object_0 as JValue;
				StringBuilder stringBuilder = default(StringBuilder);
				int num = default(int);
				IEnumerator enumerator = default(IEnumerator);
				DataRow dataRow = default(DataRow);
				int num3 = default(int);
				while (true)
				{
					if (jValue == null)
					{
						if (!(object_0 is JObject jObject))
						{
							if (!(object_0 is JArray jArray) || g2brLAXEYUViQhZJgAl.Fvqghyf4xeT(jArray))
							{
								int num2;
								if (object_0 is IEnumerable enumerable)
								{
									Type type = XNHgh7Xr1Ds(enumerable);
									if (!(type != null) || (!(type == typeof(JToken)) && !type.IsSimple()))
									{
										try
										{
											return JsonConvert.SerializeObject(enumerable, Formatting.Indented, new JsonSerializerSettings
											{
												ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
												Converters = new List<JsonConverter>
												{
													new DataRowConverter()
												}
											});
										}
										catch (Exception)
										{
											return object_0.ToString();
										}
									}
									stringBuilder = new StringBuilder();
									num = 0;
									enumerator = enumerable.GetEnumerator();
									num2 = 0;
									if (STnJE6QweW8NN8qJ8SEd())
									{
										goto IL_018f;
									}
								}
								else
								{
									if (object_0 is DateTime dateTime)
									{
										return dateTime.ToString("yyyy-MM-dd HH:mm:ss");
									}
									dataRow = object_0 as DataRow;
									if (dataRow == null)
									{
										break;
									}
									num2 = 0;
									if (!STnJE6QweW8NN8qJ8SEd())
									{
										num2 = num3;
									}
								}
								switch (num2)
								{
								case 2:
									continue;
								default:
									return JsonConvert.SerializeObject(dataRow.ToDict());
								case 1:
									break;
								}
								goto IL_018f;
							}
							return jArray.ToString();
						}
						return jObject.ToString();
					}
					return jValue.ToString();
					IL_018f:
					try
					{
						while (enumerator.MoveNext())
						{
							object current = enumerator.Current;
							if (num > 0)
							{
								stringBuilder.Append("\n");
							}
							stringBuilder.Append((current != null) ? current.ToString() : "");
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
					return stringBuilder.ToString();
				}
				if (object_0 is DataTable value)
				{
					return JsonConvert.SerializeObject(value);
				}
				if (object_0 is Image image)
				{
					return $"位图（{image.Width}x{image.Height} {image.RawFormat}）";
				}
				if (object_0.IsAnonymousType())
				{
					return JsonConvert.SerializeObject(object_0, Formatting.Indented);
				}
				return object_0.ToString().Or("对象：" + object_0.GetType().Name);
			}
			return JsonConvert.SerializeObject(object_0, Formatting.None);
		}
		return string.Join("\n", object_0 as IList<string>);
	}

	private static DateTime? nlXghqLe3Ux(object object_0)
	{
		if (object_0 is DateTime?)
		{
			return object_0 as DateTime?;
		}
		if (object_0 is JValue jValue)
		{
			return jValue.ToObject<DateTime>();
		}
		return Convert.ToDateTime(object_0, CultureInfo.InvariantCulture);
	}

	public static bool? ConvertToBoolean(object value)
	{
		if (value == null)
		{
			return false;
		}
		if (value is bool)
		{
			return (bool)value;
		}
		if (value is string text)
		{
			if (u0pghhQdPFH.Contains(text.ToLowerInvariant()))
			{
				return true;
			}
			if (long.TryParse(text, out var result))
			{
				return (ulong)result > 0uL;
			}
			return luNghcf0KVR(text);
		}
		if (value is int num)
		{
			return num != 0;
		}
		if (value is long num2)
		{
			return (ulong)num2 > 0uL;
		}
		if (value is double value2)
		{
			return Math.Abs(value2) > 1E-07;
		}
		if (value is JValue jValue)
		{
			return jValue.ToObject<bool>();
		}
		return Convert.ToBoolean(value);
	}

	private static bool luNghcf0KVR(string string_2)
	{
		if (string.IsNullOrWhiteSpace(string_2))
		{
			return false;
		}
		string_2 = string_2.Trim();
		if (string_2 != null)
		{
			int num;
			char c = default(char);
			bool result = default(bool);
			switch (string_2.Length)
			{
			default:
				num = 2;
				if (MtRV2mQwnN8FiplUxHM0 != null)
				{
					int num2 = default(int);
					num = num2;
				}
				goto IL_00bc;
			case 1:
				c = string_2[0];
				if (c != '0')
				{
					if (c != '1')
					{
						break;
					}
					goto IL_00a2;
				}
				goto case 0;
			case 4:
				c = string_2[0];
				if (c != 'T')
				{
					if (c != 't' || !(string_2 == "true"))
					{
						break;
					}
				}
				else if (!(string_2 == "True"))
				{
					break;
				}
				goto IL_00a2;
			case 5:
				c = string_2[0];
				num = 1;
				if (STnJE6QweW8NN8qJ8SEd())
				{
					goto IL_00bc;
				}
				goto IL_013a;
			case 0:
				return false;
			case 2:
			case 3:
				break;
				IL_00bc:
				switch (num)
				{
				case 1:
					break;
				case 2:
					goto end_IL_0022;
				default:
					goto IL_013a;
				}
				if (c != 'F')
				{
					if (c != 'f' || !(string_2 == "false"))
					{
						break;
					}
				}
				else if (!(string_2 == "False"))
				{
					break;
				}
				goto case 0;
				IL_013a:
				return result;
				IL_00a2:
				return true;
				end_IL_0022:
				break;
			}
		}
		try
		{
			return Convert.ToBoolean(XActionHelper.EvaluateExpression(string_2), CultureInfo.InvariantCulture);
		}
		catch (Exception ex)
		{
			J2EghZw8O2p.Error("计算布尔表达式 【" + string_2 + "】 出错：" + ex.Message, ex);
			return false;
		}
	}

	private static double FqwghVEafu7(string string_2)
	{
		if (string.IsNullOrWhiteSpace(string_2))
		{
			return 0.0;
		}
		if (double.TryParse(string_2, out var result))
		{
			return result;
		}
		return Convert.ToDouble(XActionHelper.EvaluateExpression(string_2), CultureInfo.InvariantCulture);
	}

	public static bool IsValidVarName(string varName)
	{
		return CodeDomProvider.CreateProvider("C#").IsValidIdentifier(varName);
	}

	static VariableHelper()
	{
		J2EghZw8O2p = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		SCggh9UauZR = new string[7] { "1", "yes", "ok", "true", "t", "是", "y" };
		u0pghhQdPFH = new string[8] { "1", "yes", "ok", "true", "t", "是", "y", "真" };
	}

	internal static bool STnJE6QweW8NN8qJ8SEd()
	{
		return MtRV2mQwnN8FiplUxHM0 == null;
	}
}
