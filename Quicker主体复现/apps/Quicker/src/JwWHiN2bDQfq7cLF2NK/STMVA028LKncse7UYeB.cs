using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using log4net;

namespace JwWHiN2bDQfq7cLF2NK;

internal class STMVA028LKncse7UYeB : IEnumerable, IEnumerable<FileSystemInfo>
{
	[CompilerGenerated]
	private sealed class _003CGetEnumerator_003Ed__8 : IDisposable, IEnumerator, IEnumerator<FileSystemInfo>
	{
		private int _003C_003E1__state;

		private FileSystemInfo _003C_003E2__current;

		public STMVA028LKncse7UYeB _003C_003E4__this;

		private IEnumerator<FileSystemInfo> _003C_003E7__wrap1;

		private FileSystemInfo _003Cfile_003E5__3;

		private IEnumerator<FileSystemInfo> _003C_003E7__wrap3;

		internal static _003CGetEnumerator_003Ed__8 Ic16bicMfMeauEAFMf9s;

		FileSystemInfo IEnumerator<FileSystemInfo>.Current
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
		public _003CGetEnumerator_003Ed__8(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			int num = _003C_003E1__state;
			if ((uint)(num - -4) <= 1u || (uint)(num - 1) <= 3u)
			{
				try
				{
					if (num == -4 || num == 2)
					{
						try
						{
						}
						finally
						{
							_003C_003Em__Finally2();
						}
					}
				}
				finally
				{
					_003C_003Em__Finally1();
				}
			}
			_003C_003E7__wrap1 = null;
			_003Cfile_003E5__3 = null;
			_003C_003E7__wrap3 = null;
			_003C_003E1__state = -2;
			if (mKyd2ScMbiv3BZ2NpHo8())
			{
				switch (0)
				{
				}
			}
		}

		private bool MoveNext()
		{
			bool result = default(bool);
			try
			{
				int num = _003C_003E1__state;
				STMVA028LKncse7UYeB sTMVA028LKncse7UYeB = _003C_003E4__this;
				int num2;
				FileSystemInfo current;
				int num4 = default(int);
				STMVA028LKncse7UYeB sTMVA028LKncse7UYeB2 = default(STMVA028LKncse7UYeB);
				switch (num)
				{
				default:
					result = false;
					num2 = 6;
					if (Ic16bicMfMeauEAFMf9s != null)
					{
						goto IL_02ff;
					}
					goto IL_0365;
				case 0:
					_003C_003E1__state = -1;
					if (sTMVA028LKncse7UYeB.yxMtCvw1Mt5 != null && sTMVA028LKncse7UYeB.yxMtCvw1Mt5.Exists)
					{
						IEnumerable<FileSystemInfo> enumerable = new List<FileSystemInfo>();
						try
						{
							enumerable = sTMVA028LKncse7UYeB.yxMtCvw1Mt5.EnumerateFileSystemInfos("*", SearchOption.TopDirectoryOnly);
						}
						catch (UnauthorizedAccessException)
						{
							uZXtCLUX5gY.Warn("没有权限访问 '" + sTMVA028LKncse7UYeB.yxMtCvw1Mt5.FullName + "'. ");
							result = false;
							goto end_IL_0001;
						}
						catch (PathTooLongException)
						{
							uZXtCLUX5gY.Warn("路径太长，不支持。" + sTMVA028LKncse7UYeB.yxMtCvw1Mt5.FullName + ".");
							result = false;
							goto end_IL_0001;
						}
						catch (IOException ex3)
						{
							uZXtCLUX5gY.Warn("访问" + sTMVA028LKncse7UYeB.yxMtCvw1Mt5.FullName + " IO错误：" + ex3.Message + " ");
							result = false;
							goto end_IL_0001;
						}
						catch (Exception ex4)
						{
							uZXtCLUX5gY.Warn("访问" + sTMVA028LKncse7UYeB.yxMtCvw1Mt5.FullName + " 错误：" + ex4.Message + " ");
							result = false;
							goto end_IL_0001;
						}
						_003C_003E7__wrap1 = enumerable.GetEnumerator();
						_003C_003E1__state = -3;
						goto IL_01da;
					}
					result = false;
					num2 = 4;
					if (!mKyd2ScMbiv3BZ2NpHo8())
					{
						goto IL_02ff;
					}
					goto IL_0365;
				case 1:
					_003C_003E1__state = -3;
					goto IL_0311;
				case 3:
					_003C_003E1__state = -3;
					goto IL_03c4;
				case 4:
					_003C_003E1__state = -3;
					goto IL_03c4;
				case 2:
					goto IL_038b;
					IL_01da:
					if (_003C_003E7__wrap1.MoveNext())
					{
						_003Cfile_003E5__3 = _003C_003E7__wrap1.Current;
						if (_003Cfile_003E5__3.Attributes.HasFlag(FileAttributes.Directory))
						{
							if (!_003Cfile_003E5__3.Attributes.HasFlag(FileAttributes.Hidden) && !sTMVA028LKncse7UYeB.MAatCup6TjU.Contains(_003Cfile_003E5__3.Name))
							{
								num2 = 0;
								if (Ic16bicMfMeauEAFMf9s == null)
								{
									goto IL_0305;
								}
								goto IL_0365;
							}
							goto IL_03c4;
						}
						if (sTMVA028LKncse7UYeB.b0ltCSD8CFu == null)
						{
							int num3 = 0;
							while (num3 < sTMVA028LKncse7UYeB.wM3tC2ZpH6g.Count)
							{
								if (sTMVA028LKncse7UYeB.wM3tC2ZpH6g[num3] == "*")
								{
									goto end_IL_0013;
								}
								if (!_003Cfile_003E5__3.Name.EndsWith(sTMVA028LKncse7UYeB.wM3tC2ZpH6g[num3], StringComparison.OrdinalIgnoreCase))
								{
									num3++;
									continue;
								}
								goto IL_02f2;
							}
							goto IL_03c4;
						}
						if (!sTMVA028LKncse7UYeB.b0ltCSD8CFu.IsMatch(_003Cfile_003E5__3.Name))
						{
							goto IL_03c4;
						}
						_003C_003E2__current = _003Cfile_003E5__3;
						_003C_003E1__state = 3;
						result = true;
					}
					else
					{
						_003C_003Em__Finally1();
						_003C_003E7__wrap1 = null;
						result = false;
					}
					goto end_IL_0001;
					IL_02f2:
					num2 = 5;
					if (Ic16bicMfMeauEAFMf9s != null)
					{
						goto IL_02ff;
					}
					goto IL_0365;
					IL_03c4:
					_003Cfile_003E5__3 = null;
					goto IL_01da;
					IL_03aa:
					if (!_003C_003E7__wrap3.MoveNext())
					{
						_003C_003Em__Finally2();
						_003C_003E7__wrap3 = null;
						goto IL_03c4;
					}
					current = _003C_003E7__wrap3.Current;
					_003C_003E2__current = current;
					_003C_003E1__state = 2;
					result = true;
					goto end_IL_0001;
					IL_0365:
					switch (num2)
					{
					case 1:
						break;
					default:
						goto IL_032a;
					case 2:
						goto IL_038b;
					case 3:
						goto IL_0395;
					case 4:
						goto end_IL_0001;
					case 6:
						goto end_IL_0001;
					case 5:
						goto end_IL_0013;
					}
					goto IL_0305;
					IL_038b:
					_003C_003E1__state = -4;
					goto IL_03aa;
					IL_0305:
					if (sTMVA028LKncse7UYeB.aq4tCJWCh2j)
					{
						goto IL_0311;
					}
					_003C_003E2__current = _003Cfile_003E5__3;
					_003C_003E1__state = 1;
					result = true;
					goto end_IL_0001;
					IL_0311:
					if (sTMVA028LKncse7UYeB.bQ4tCN49H0J)
					{
						num2 = 0;
						if (Ic16bicMfMeauEAFMf9s == null)
						{
							goto IL_032a;
						}
						goto IL_0365;
					}
					goto IL_03c4;
					IL_02ff:
					num2 = num4;
					goto IL_0365;
					IL_032a:
					sTMVA028LKncse7UYeB2 = new STMVA028LKncse7UYeB((DirectoryInfo)_003Cfile_003E5__3, sTMVA028LKncse7UYeB.b0ltCSD8CFu, sTMVA028LKncse7UYeB.wM3tC2ZpH6g, sTMVA028LKncse7UYeB.MAatCup6TjU, true, sTMVA028LKncse7UYeB.aq4tCJWCh2j);
					num2 = 2;
					if (Ic16bicMfMeauEAFMf9s != null)
					{
						goto IL_0365;
					}
					goto IL_0395;
					IL_0395:
					_003C_003E7__wrap3 = sTMVA028LKncse7UYeB2.GetEnumerator();
					_003C_003E1__state = -4;
					goto IL_03aa;
					end_IL_0013:
					break;
				}
				_003C_003E2__current = _003Cfile_003E5__3;
				_003C_003E1__state = 4;
				result = true;
				end_IL_0001:;
			}
			catch
			{
				//try-fault
				((IDisposable)this).Dispose();
				throw;
			}
			return result;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
			_003C_003E1__state = -1;
			if (_003C_003E7__wrap1 != null)
			{
				_003C_003E7__wrap1.Dispose();
			}
		}

		private void _003C_003Em__Finally2()
		{
			_003C_003E1__state = -3;
			if (_003C_003E7__wrap3 != null)
			{
				_003C_003E7__wrap3.Dispose();
			}
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		internal static bool mKyd2ScMbiv3BZ2NpHo8()
		{
			return Ic16bicMfMeauEAFMf9s == null;
		}
	}

	private static readonly ILog uZXtCLUX5gY;

	private readonly DirectoryInfo yxMtCvw1Mt5;

	private readonly Regex b0ltCSD8CFu;

	private readonly IList<string> wM3tC2ZpH6g;

	private readonly IList<string> MAatCup6TjU;

	private readonly bool bQ4tCN49H0J;

	private readonly bool aq4tCJWCh2j;

	private static STMVA028LKncse7UYeB KbpTbvQe08KtPWha0QCh;

	public STMVA028LKncse7UYeB(DirectoryInfo directoryInfo_1, Regex regex_1, IList<string> ilist_2, IList<string> ilist_3, bool bool_2, bool bool_3)
	{
		yxMtCvw1Mt5 = directoryInfo_1;
		b0ltCSD8CFu = regex_1;
		wM3tC2ZpH6g = ilist_2;
		MAatCup6TjU = ilist_3;
		bQ4tCN49H0J = bool_2;
		aq4tCJWCh2j = bool_3;
	}

	[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__8))]
	public IEnumerator<FileSystemInfo> GetEnumerator()
	{
		return new _003CGetEnumerator_003Ed__8(0)
		{
			_003C_003E4__this = this
		};
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	static STMVA028LKncse7UYeB()
	{
		uZXtCLUX5gY = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static bool oOVPtMQe1ZXAoK6B2Wt1()
	{
		return KbpTbvQe08KtPWha0QCh == null;
	}
}
