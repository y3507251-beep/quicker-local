using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace Jitbit.Utils;

public class CsvExport
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass13_0
	{
		public Dictionary<string, object> rvEvP5DFbRC;

		public CsvExport UXPvPDcAlmc;

		public Func<string, bool> JMpvPdL0gCl;

		internal static _003C_003Ec__DisplayClass13_0 M5fKPdcndSydPPbdV0VD;

		internal bool ehfvPnjtCRA(string f)
		{
			return !rvEvP5DFbRC.ContainsKey(f);
		}

		internal string qGbvP4DEOog(string field)
		{
			return MakeValueCsvFriendly(rvEvP5DFbRC[field], UXPvPDcAlmc.hEuvv4SKoG);
		}

		internal static bool T7EZYGcnOfIaIZ1XKZDG()
		{
			return M5fKPdcndSydPPbdV0VD == null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CExportToLines_003Ed__13 : IEnumerable<string>, IEnumerator<string>, IDisposable, IEnumerable, IEnumerator
	{
		private int _003C_003E1__state;

		private string _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public CsvExport _003C_003E4__this;

		private bool includeHeader;

		public bool _003C_003E3__includeHeader;

		private List<Dictionary<string, object>>.Enumerator _003C_003E7__wrap1;

		internal static _003CExportToLines_003Ed__13 pJSu7XcnklhYZ9nxccYQ;

		string IEnumerator<string>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public _003CExportToLines_003Ed__13(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			int num = _003C_003E1__state;
			if (num == -3 || num == 3)
			{
				try
				{
				}
				finally
				{
					_003C_003Em__Finally1();
				}
			}
			_003C_003E7__wrap1 = default(List<Dictionary<string, object>>.Enumerator);
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
			try
			{
				int num = _003C_003E1__state;
				CsvExport csvExport = _003C_003E4__this;
				int num2 = default(int);
				int num3;
				switch (num)
				{
				default:
					return false;
				case 0:
					_003C_003E1__state = -1;
					num2 = 2;
					goto IL_0054;
				case 1:
					_003C_003E1__state = -1;
					goto IL_0060;
				case 2:
					_003C_003E1__state = -1;
					goto IL_00b9;
				case 3:
					{
						_003C_003E1__state = -3;
						break;
					}
					IL_0054:
					if (csvExport.CyKvSBwZsl)
					{
						_003C_003E2__current = "sep=" + csvExport.hEuvv4SKoG;
						_003C_003E1__state = 1;
						return true;
					}
					goto IL_0060;
					IL_0060:
					if (!includeHeader)
					{
						goto IL_00b9;
					}
					_003C_003E2__current = string.Join(csvExport.hEuvv4SKoG, csvExport.s2KvggOeTh.Select(csvExport.pbDLzb87Nf));
					_003C_003E1__state = 2;
					num3 = 1;
					if (BcbC4BcnabD9UonLpT9p())
					{
						goto IL_00a6;
					}
					goto IL_010d;
					IL_010d:
					return true;
					IL_00b9:
					_003C_003E7__wrap1 = csvExport.QsEvLfUGCm.GetEnumerator();
					_003C_003E1__state = -3;
					num3 = 0;
					if (!BcbC4BcnabD9UonLpT9p())
					{
						num3 = num2;
					}
					goto IL_00a6;
					IL_00a6:
					switch (num3)
					{
					case 2:
						break;
					case 1:
						goto IL_010d;
					default:
						goto end_IL_0013;
					}
					goto IL_0054;
					end_IL_0013:
					break;
				}
				if (!_003C_003E7__wrap1.MoveNext())
				{
					_003C_003Em__Finally1();
					_003C_003E7__wrap1 = default(List<Dictionary<string, object>>.Enumerator);
					return false;
				}
				_003C_003Ec__DisplayClass13_0 _003C_003Ec__DisplayClass13_ = new _003C_003Ec__DisplayClass13_0
				{
					UXPvPDcAlmc = csvExport,
					rvEvP5DFbRC = _003C_003E7__wrap1.Current
				};
				foreach (string item in csvExport.s2KvggOeTh.Where(_003C_003Ec__DisplayClass13_.JMpvPdL0gCl ?? (_003C_003Ec__DisplayClass13_.JMpvPdL0gCl = _003C_003Ec__DisplayClass13_.ehfvPnjtCRA)))
				{
					_003C_003Ec__DisplayClass13_.rvEvP5DFbRC[item] = null;
				}
				_003C_003E2__current = string.Join(csvExport.hEuvv4SKoG, csvExport.s2KvggOeTh.Select(_003C_003Ec__DisplayClass13_.qGbvP4DEOog));
				_003C_003E1__state = 3;
				return true;
			}
			catch
			{
				//try-fault
				((IDisposable)this).Dispose();
				throw;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
			_003C_003E1__state = -1;
			((IDisposable)_003C_003E7__wrap1/*cast due to .constrained prefix*/).Dispose();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			_003CExportToLines_003Ed__13 _003CExportToLines_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CExportToLines_003Ed__ = this;
			}
			else
			{
				_003CExportToLines_003Ed__ = new _003CExportToLines_003Ed__13(0)
				{
					_003C_003E4__this = _003C_003E4__this
				};
			}
			_003CExportToLines_003Ed__.includeHeader = _003C_003E3__includeHeader;
			return _003CExportToLines_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<string>)this).GetEnumerator();
		}

		internal static bool BcbC4BcnabD9UonLpT9p()
		{
			return pJSu7XcnklhYZ9nxccYQ == null;
		}
	}

	private readonly List<string> s2KvggOeTh = new List<string>();

	private readonly List<Dictionary<string, object>> QsEvLfUGCm = new List<Dictionary<string, object>>();

	private readonly string hEuvv4SKoG;

	private readonly bool CyKvSBwZsl;

	internal static CsvExport NB5GdKp5jx65Ubh5Eug;

	public object this[string field]
	{
		get
		{
			return vnCvwGJsN5()[field];
		}
		set
		{
			if (!s2KvggOeTh.Contains(field))
			{
				s2KvggOeTh.Add(field);
			}
			vnCvwGJsN5()[field] = value;
		}
	}

	[SpecialName]
	private Dictionary<string, object> vnCvwGJsN5()
	{
		return QsEvLfUGCm[QsEvLfUGCm.Count - 1];
	}

	public CsvExport(string columnSeparator = ",", bool includeColumnSeparatorDefinitionPreamble = true)
	{
		hEuvv4SKoG = columnSeparator;
		CyKvSBwZsl = includeColumnSeparatorDefinitionPreamble;
	}

	public void AddRow()
	{
		QsEvLfUGCm.Add(new Dictionary<string, object>());
	}

	public void AddRows<T>(IEnumerable<T> list)
	{
		if (!list.Any())
		{
			return;
		}
		foreach (T item in list)
		{
			AddRow();
			PropertyInfo[] properties = item.GetType().GetProperties();
			foreach (PropertyInfo propertyInfo in properties)
			{
				this[propertyInfo.Name] = propertyInfo.GetValue(item, null);
			}
		}
	}

	public static string MakeValueCsvFriendly(object value, string columnSeparator = ",")
	{
        string text = default;
		if (value == null)
		{
			return "";
		}
		if (value is INullable nullable && nullable.IsNull)
		{
			return "";
		}
		int num;
		if (!(value is DateTime { TimeOfDay: var timeOfDay }))
		{
			num = 0;
			if (neO0xLpYMHiqMh0SMlc())
			{
				goto IL_00af;
			}
			goto IL_00cd;
		}
		if (timeOfDay.TotalSeconds == 0.0)
		{
			return ((DateTime)(object)value).ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
		}
		return ((DateTime)(object)value).ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
		IL_00cd:
		switch (num)
		{
		case 1:
			goto IL_00dc;
		}
		goto IL_00af;
		IL_00af:
		text = default(string);
		while (true)
		{
			text = value.ToString().Trim();
			if (text.Length > 30000)
			{
				text = text.Substring(0, 30000);
			}
			if (!text.Contains(columnSeparator) && !text.Contains("\"") && !text.Contains("\n") && !text.Contains("\r"))
			{
				break;
			}
			text = "\"" + text.Replace("\"", "\"\"") + "\"";
			num = 1;
			if (!neO0xLpYMHiqMh0SMlc())
			{
				continue;
			}
			goto IL_00cd;
		}
		goto IL_00dc;
		IL_00dc:
		return text;
	}

	[IteratorStateMachine(typeof(_003CExportToLines_003Ed__13))]
	private IEnumerable<string> sqQLfT1X3l(bool bool_1 = false)
	{
		return new _003CExportToLines_003Ed__13(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__includeHeader = bool_1
		};
	}

	public string Export(bool includeHeader = false)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (string item in sqQLfT1X3l(includeHeader))
		{
			stringBuilder.AppendLine(item);
		}
		return stringBuilder.ToString();
	}

	public void ExportToFile(string path, bool includeHeader = false)
	{
		File.WriteAllLines(path, sqQLfT1X3l(includeHeader), Encoding.Default);
	}

	public byte[] ExportToBytes(bool includeHeader = false)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(Export(includeHeader));
		return Encoding.UTF8.GetPreamble().Concat(bytes).ToArray();
	}

	[CompilerGenerated]
	private string pbDLzb87Nf(string string_1)
	{
		return MakeValueCsvFriendly(string_1, hEuvv4SKoG);
	}

	internal static bool neO0xLpYMHiqMh0SMlc()
	{
		return NB5GdKp5jx65Ubh5Eug == null;
	}
}
