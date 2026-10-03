using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using log4net;

namespace Quicker.Modules.Searching.Builtin;

public class EverythingAPI
{
	private enum rIA0VduvXkAdlKkFTBE
	{

	}

	[CompilerGenerated]
	private sealed class _003CSearch_003Ed__123 : IDisposable, IEnumerable, IEnumerator, IEnumerable<EverythingFileInfo>, IEnumerator<EverythingFileInfo>
	{
		private int _003C_003E1__state;

		private EverythingFileInfo _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private string keyWord;

		public string _003C_003E3__keyWord;

		private uint offset;

		public uint _003C_003E3__offset;

		private uint maxCount;

		public uint _003C_003E3__maxCount;

		private CancellationToken? cancellationToken;

		public CancellationToken? _003C_003E3__cancellationToken;

		private int querySerial;

		public int _003C_003E3__querySerial;

		private StringBuilder _003Cbuffer_003E5__2;

		private uint _003CresultNum_003E5__3;

		private uint _003Cidx_003E5__4;

		internal static _003CSearch_003Ed__123 XKDpLJcUi1wDrcy4gIhE;

		EverythingFileInfo IEnumerator<EverythingFileInfo>.Current
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
		public _003CSearch_003Ed__123(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			_003Cbuffer_003E5__2 = null;
			_003C_003E1__state = -2;
		}

		private bool MoveNext()
		{
        string text = default;
        string highlightedFileName = default;
        DateTime modified = default;
        string fileName = default;
        long lpFileSize = default;
			int num = _003C_003E1__state;
			int num2;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				_003C_003E1__state = -1;
				num2 = 1;
				if (XKDpLJcUi1wDrcy4gIhE != null)
				{
					goto IL_022d;
				}
				goto IL_0231;
			}
			_003C_003E1__state = -1;
			if (string.IsNullOrEmpty(keyWord))
			{
				throw new ArgumentNullException("keyWord");
			}
			Everything_SetSearchW(keyWord);
			Everything_SetRequestFlags(8275u);
			Everything_SetOffset(offset);
			Everything_SetMax(maxCount);
			if (!Everything_QueryW(true))
			{
				return Everything_GetLastError() switch
				{
					1u => throw new MemoryErrorException(), 
					2u => throw new IPCErrorException(), 
					3u => throw new RegisterClassExException(), 
					4u => throw new CreateWindowException(), 
					5u => throw new CreateThreadException(), 
					6u => throw new InvalidIndexException(), 
					7u => throw new InvalidCallException(), 
					_ => false, 
				};
			}
			_003Cbuffer_003E5__2 = new StringBuilder(512);
			_003CresultNum_003E5__3 = Everything_GetNumResults();
			_003Cidx_003E5__4 = 0u;
			goto IL_00fc;
			IL_0231:
			uint num3 = default(uint);
			switch (num2)
			{
			case 1:
				num3 = _003Cidx_003E5__4 + 1;
				goto case 2;
			case 2:
				_003Cidx_003E5__4 = num3;
				goto IL_00fc;
			case 3:
				goto IL_02ca;
			}
			CancellationToken valueOrDefault = default(CancellationToken);
			if (valueOrDefault.IsCancellationRequested)
			{
				return false;
			}
			goto IL_0147;
			IL_0147:
			Everything_GetResultDateModified(_003Cidx_003E5__4, out var lpFileTime);
			lpFileSize = default(long);
			Everything_GetResultSize(_003Cidx_003E5__4, out lpFileSize);
			Everything_GetResultFullPathNameW(_003Cidx_003E5__4, _003Cbuffer_003E5__2, 512u);
			text = _003Cbuffer_003E5__2.ToString();
			fileName = default(string);
			highlightedFileName = default(string);
			modified = default(DateTime);
			if (!string.IsNullOrEmpty(text))
			{
				fileName = Marshal.PtrToStringUni(Everything_GetResultFileNameW(_003Cidx_003E5__4));
				highlightedFileName = Marshal.PtrToStringUni(Everything_GetResultHighlightedFileName(_003Cidx_003E5__4));
				try
				{
					modified = DateTime.FromFileTime(lpFileTime);
				}
				catch (Exception exception)
				{
					cwjtPjpgXvR.Warn($"转换文件时间信息出错({querySerial}:{keyWord})，文件:{text} 时间值:{lpFileTime}", exception);
					modified = DateTime.MinValue;
				}
				ref CancellationToken? reference = ref cancellationToken;
				if (!reference.HasValue)
				{
					num2 = 3;
					if (XKDpLJcUi1wDrcy4gIhE != null)
					{
						goto IL_022d;
					}
					goto IL_0231;
				}
				if (reference.GetValueOrDefault().IsCancellationRequested)
				{
					return false;
				}
				goto IL_02ca;
			}
			cwjtPjpgXvR.Warn($"everything返回数据异常({querySerial}:{keyWord})，预期结果数量：{_003CresultNum_003E5__3} 当前:{_003Cidx_003E5__4}");
			return false;
			IL_02ca:
			_003C_003E2__current = new EverythingFileInfo
			{
				FileName = fileName,
				HighlightedFileName = highlightedFileName,
				FilePath = text,
				Modified = modified,
				Size = lpFileSize
			};
			_003C_003E1__state = 1;
			return true;
			IL_00fc:
			if (_003Cidx_003E5__4 < _003CresultNum_003E5__3)
			{
				ref CancellationToken? reference2 = ref cancellationToken;
				if (!reference2.HasValue)
				{
					goto IL_0147;
				}
				valueOrDefault = reference2.GetValueOrDefault();
				num2 = 0;
				if (!SZLPcLcUlY1XskeELAfm())
				{
					goto IL_022d;
				}
				goto IL_0231;
			}
			return false;
			IL_022d:
			int num4 = default(int);
			num2 = num4;
			goto IL_0231;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator<EverythingFileInfo> IEnumerable<EverythingFileInfo>.GetEnumerator()
		{
			_003CSearch_003Ed__123 _003CSearch_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CSearch_003Ed__ = this;
			}
			else
			{
				_003CSearch_003Ed__ = new _003CSearch_003Ed__123(0);
			}
			_003CSearch_003Ed__.keyWord = _003C_003E3__keyWord;
			_003CSearch_003Ed__.offset = _003C_003E3__offset;
			_003CSearch_003Ed__.maxCount = _003C_003E3__maxCount;
			_003CSearch_003Ed__.cancellationToken = _003C_003E3__cancellationToken;
			_003CSearch_003Ed__.querySerial = _003C_003E3__querySerial;
			return _003CSearch_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<EverythingFileInfo>)this).GetEnumerator();
		}

		internal static bool SZLPcLcUlY1XskeELAfm()
		{
			return XKDpLJcUi1wDrcy4gIhE == null;
		}
	}

	private static readonly ILog cwjtPjpgXvR;

	public const int EVERYTHING_OK = 0;

	public const int EVERYTHING_ERROR_MEMORY = 1;

	public const int EVERYTHING_ERROR_IPC = 2;

	public const int EVERYTHING_ERROR_REGISTERCLASSEX = 3;

	public const int EVERYTHING_ERROR_CREATEWINDOW = 4;

	public const int EVERYTHING_ERROR_CREATETHREAD = 5;

	public const int EVERYTHING_ERROR_INVALIDINDEX = 6;

	public const int EVERYTHING_ERROR_INVALIDCALL = 7;

	public const int EVERYTHING_REQUEST_FILE_NAME = 1;

	public const int EVERYTHING_REQUEST_PATH = 2;

	public const int EVERYTHING_REQUEST_FULL_PATH_AND_FILE_NAME = 4;

	public const int EVERYTHING_REQUEST_EXTENSION = 8;

	public const int EVERYTHING_REQUEST_SIZE = 16;

	public const int EVERYTHING_REQUEST_DATE_CREATED = 32;

	public const int EVERYTHING_REQUEST_DATE_MODIFIED = 64;

	public const int EVERYTHING_REQUEST_DATE_ACCESSED = 128;

	public const int EVERYTHING_REQUEST_ATTRIBUTES = 256;

	public const int EVERYTHING_REQUEST_FILE_LIST_FILE_NAME = 512;

	public const int EVERYTHING_REQUEST_RUN_COUNT = 1024;

	public const int EVERYTHING_REQUEST_DATE_RUN = 2048;

	public const int EVERYTHING_REQUEST_DATE_RECENTLY_CHANGED = 4096;

	public const int EVERYTHING_REQUEST_HIGHLIGHTED_FILE_NAME = 8192;

	public const int EVERYTHING_REQUEST_HIGHLIGHTED_PATH = 16384;

	public const int EVERYTHING_REQUEST_HIGHLIGHTED_FULL_PATH_AND_FILE_NAME = 32768;

	public const int EVERYTHING_SORT_NAME_ASCENDING = 1;

	public const int EVERYTHING_SORT_NAME_DESCENDING = 2;

	public const int EVERYTHING_SORT_PATH_ASCENDING = 3;

	public const int EVERYTHING_SORT_PATH_DESCENDING = 4;

	public const int EVERYTHING_SORT_SIZE_ASCENDING = 5;

	public const int EVERYTHING_SORT_SIZE_DESCENDING = 6;

	public const int EVERYTHING_SORT_EXTENSION_ASCENDING = 7;

	public const int EVERYTHING_SORT_EXTENSION_DESCENDING = 8;

	public const int EVERYTHING_SORT_TYPE_NAME_ASCENDING = 9;

	public const int EVERYTHING_SORT_TYPE_NAME_DESCENDING = 10;

	public const int EVERYTHING_SORT_DATE_CREATED_ASCENDING = 11;

	public const int EVERYTHING_SORT_DATE_CREATED_DESCENDING = 12;

	public const int EVERYTHING_SORT_DATE_MODIFIED_ASCENDING = 13;

	public const int EVERYTHING_SORT_DATE_MODIFIED_DESCENDING = 14;

	public const int EVERYTHING_SORT_ATTRIBUTES_ASCENDING = 15;

	public const int EVERYTHING_SORT_ATTRIBUTES_DESCENDING = 16;

	public const int EVERYTHING_SORT_FILE_LIST_FILENAME_ASCENDING = 17;

	public const int EVERYTHING_SORT_FILE_LIST_FILENAME_DESCENDING = 18;

	public const int EVERYTHING_SORT_RUN_COUNT_ASCENDING = 19;

	public const int EVERYTHING_SORT_RUN_COUNT_DESCENDING = 20;

	public const int EVERYTHING_SORT_DATE_RECENTLY_CHANGED_ASCENDING = 21;

	public const int EVERYTHING_SORT_DATE_RECENTLY_CHANGED_DESCENDING = 22;

	public const int EVERYTHING_SORT_DATE_ACCESSED_ASCENDING = 23;

	public const int EVERYTHING_SORT_DATE_ACCESSED_DESCENDING = 24;

	public const int EVERYTHING_SORT_DATE_RUN_ASCENDING = 25;

	public const int EVERYTHING_SORT_DATE_RUN_DESCENDING = 26;

	private static EverythingAPI DbgAobQjknbKfsKC692T;

	public bool MatchPath
	{
		get
		{
			return Everything_GetMatchPath();
		}
		set
		{
			Everything_SetMatchPath(value);
		}
	}

	public bool MatchCase
	{
		get
		{
			return Everything_GetMatchCase();
		}
		set
		{
			Everything_SetMatchCase(value);
		}
	}

	public bool MatchWholeWord
	{
		get
		{
			return Everything_GetMatchWholeWord();
		}
		set
		{
			Everything_SetMatchWholeWord(value);
		}
	}

	public bool EnableRegex
	{
		get
		{
			return Everything_GetRegex();
		}
		set
		{
			Everything_SetRegex(value);
		}
	}

	public uint Sort
	{
		get
		{
			return Everything_GetSort();
		}
		set
		{
			Everything_SetSort(value);
		}
	}

	[DllImport("Everything64.dll", CharSet = CharSet.Unicode)]
	public static extern uint Everything_SetSearchW(string lpSearchString);

	[DllImport("Everything64.dll")]
	public static extern void Everything_SetMatchPath(bool bEnable);

	[DllImport("Everything64.dll")]
	public static extern void Everything_SetMatchCase(bool bEnable);

	[DllImport("Everything64.dll")]
	public static extern void Everything_SetMatchWholeWord(bool bEnable);

	[DllImport("Everything64.dll")]
	public static extern void Everything_SetRegex(bool bEnable);

	[DllImport("Everything64.dll")]
	public static extern void Everything_SetMax(uint dwMax);

	[DllImport("Everything64.dll")]
	public static extern void Everything_SetOffset(uint dwOffset);

	[DllImport("Everything64.dll")]
	public static extern bool Everything_GetMatchPath();

	[DllImport("Everything64.dll")]
	public static extern bool Everything_GetMatchCase();

	[DllImport("Everything64.dll")]
	public static extern bool Everything_GetMatchWholeWord();

	[DllImport("Everything64.dll")]
	public static extern bool Everything_GetRegex();

	[DllImport("Everything64.dll")]
	public static extern uint Everything_GetMax();

	[DllImport("Everything64.dll")]
	public static extern uint Everything_GetOffset();

	[DllImport("Everything64.dll")]
	public static extern string Everything_GetSearchW();

	[DllImport("Everything64.dll")]
	public static extern uint Everything_GetLastError();

	[DllImport("Everything64.dll")]
	public static extern bool Everything_QueryW(bool bWait);

	[DllImport("Everything64.dll")]
	public static extern void Everything_SortResultsByPath();

	[DllImport("Everything64.dll")]
	public static extern uint Everything_GetNumFileResults();

	[DllImport("Everything64.dll")]
	public static extern uint Everything_GetNumFolderResults();

	[DllImport("Everything64.dll")]
	public static extern uint Everything_GetNumResults();

	[DllImport("Everything64.dll")]
	public static extern uint Everything_GetTotFileResults();

	[DllImport("Everything64.dll")]
	public static extern uint Everything_GetTotFolderResults();

	[DllImport("Everything64.dll")]
	public static extern uint Everything_GetTotResults();

	[DllImport("Everything64.dll")]
	public static extern bool Everything_IsVolumeResult(uint nIndex);

	[DllImport("Everything64.dll")]
	public static extern bool Everything_IsFolderResult(uint nIndex);

	[DllImport("Everything64.dll")]
	public static extern bool Everything_IsFileResult(uint nIndex);

	[DllImport("Everything64.dll", CharSet = CharSet.Unicode)]
	public static extern void Everything_GetResultFullPathNameW(uint nIndex, StringBuilder lpString, uint nMaxCount);

	[DllImport("Everything64.dll")]
	public static extern void Everything_Reset();

	[DllImport("Everything64.dll", CharSet = CharSet.Unicode)]
	public static extern IntPtr Everything_GetResultFileNameW(uint nIndex);

	[DllImport("Everything64.dll")]
	public static extern void Everything_SetSort(uint dwSortType);

	[DllImport("Everything64.dll")]
	public static extern uint Everything_GetSort();

	[DllImport("Everything64.dll")]
	public static extern uint Everything_GetResultListSort();

	[DllImport("Everything64.dll")]
	public static extern void Everything_SetRequestFlags(uint dwRequestFlags);

	[DllImport("Everything64.dll")]
	public static extern uint Everything_GetRequestFlags();

	[DllImport("Everything64.dll")]
	public static extern uint Everything_GetResultListRequestFlags();

	[DllImport("Everything64.dll", CharSet = CharSet.Unicode)]
	public static extern string Everything_GetResultExtension(uint nIndex);

	[DllImport("Everything64.dll")]
	public static extern bool Everything_GetResultSize(uint nIndex, out long lpFileSize);

	[DllImport("Everything64.dll")]
	public static extern bool Everything_GetResultDateCreated(uint nIndex, out long lpFileTime);

	[DllImport("Everything64.dll")]
	public static extern bool Everything_GetResultDateModified(uint nIndex, out long lpFileTime);

	[DllImport("Everything64.dll")]
	public static extern bool Everything_GetResultDateAccessed(uint nIndex, out long lpFileTime);

	[DllImport("Everything64.dll")]
	public static extern uint Everything_GetResultAttributes(uint nIndex);

	[DllImport("Everything64.dll", CharSet = CharSet.Unicode)]
	public static extern string Everything_GetResultFileListFileName(uint nIndex);

	[DllImport("Everything64.dll")]
	public static extern uint Everything_GetResultRunCount(uint nIndex);

	[DllImport("Everything64.dll")]
	public static extern bool Everything_GetResultDateRun(uint nIndex, out long lpFileTime);

	[DllImport("Everything64.dll")]
	public static extern bool Everything_GetResultDateRecentlyChanged(uint nIndex, out long lpFileTime);

	[DllImport("Everything64.dll", CharSet = CharSet.Unicode)]
	public static extern IntPtr Everything_GetResultHighlightedFileName(uint nIndex);

	[DllImport("Everything64.dll", CharSet = CharSet.Unicode)]
	public static extern string Everything_GetResultHighlightedPath(uint nIndex);

	[DllImport("Everything64.dll", CharSet = CharSet.Unicode)]
	public static extern string Everything_GetResultHighlightedFullPathAndFileName(uint nIndex);

	[DllImport("Everything64.dll")]
	public static extern uint Everything_GetRunCountFromFileName(string lpFileName);

	[DllImport("Everything64.dll")]
	public static extern bool Everything_SetRunCountFromFileName(string lpFileName, uint dwRunCount);

	[DllImport("Everything64.dll")]
	public static extern uint Everything_IncRunCountFromFileName(string lpFileName);

	public void Reset()
	{
		Everything_Reset();
	}

	[IteratorStateMachine(typeof(_003CSearch_003Ed__123))]
	public IEnumerable<EverythingFileInfo> Search(string keyWord, uint offset, uint maxCount, CancellationToken? cancellationToken = null, int querySerial = 0)
	{
		return new _003CSearch_003Ed__123(-2)
		{
			_003C_003E3__keyWord = keyWord,
			_003C_003E3__offset = offset,
			_003C_003E3__maxCount = maxCount,
			_003C_003E3__cancellationToken = cancellationToken,
			_003C_003E3__querySerial = querySerial
		};
	}

	static EverythingAPI()
	{
		cwjtPjpgXvR = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
	}

	internal static void r5JrGBQjN3x2IhuNO9cF()
	{
	}

	internal static bool jkGkAOQjaIYkCN5GMHiE()
	{
		return DbgAobQjknbKfsKC692T == null;
	}
}
