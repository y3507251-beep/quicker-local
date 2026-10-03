using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Quicker.Utilities.Win32;

public class ImpersonationToken
{
	public struct LUID_AND_ATTRIBUTES
	{
		public LUID Luid;

		public uint Attributes;

		public const uint SE_PRIVILEGE_ENABLED_BY_DEFAULT = 1u;

		public const uint SE_PRIVILEGE_ENABLED = 2u;

		public const uint SE_PRIVILEGE_REMOVED = 4u;

		public const uint SE_PRIVILEGE_USED_FOR_ACCESS = 2147483648u;
	}

	public struct LUID
	{
		public uint LowPart;

		public int HighPart;
	}

	public struct TOKEN_PRIVILEGES
	{
		public int PrivilegeCount;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
		public LUID_AND_ATTRIBUTES[] Privileges;
	}

	public struct PRIVILEGE_SET
	{
		public uint PrivilegeCount;

		public uint Control;

		public static uint PRIVILEGE_SET_ALL_NECESSARY;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
		public LUID_AND_ATTRIBUTES[] Privilege;

		internal static object Gs3weryEN7JEAtuE29L3;

		static PRIVILEGE_SET()
		{
			PRIVILEGE_SET_ALL_NECESSARY = 1u;
		}

		internal static void PIDsvgyEubjTvQKpgywc()
		{
		}

		internal static bool IKp6FlyE92vnNDFE3f7y()
		{
			return Gs3weryEN7JEAtuE29L3 == null;
		}
	}

	[Flags]
	public enum ProcessAccessFlags : uint
	{
		All = 0x1F0FFFu,
		Terminate = 1u,
		CreateThread = 2u,
		VirtualMemoryOperation = 8u,
		VirtualMemoryRead = 0x10u,
		VirtualMemoryWrite = 0x20u,
		DuplicateHandle = 0x40u,
		CreateProcess = 0x80u,
		SetQuota = 0x100u,
		SetInformation = 0x200u,
		QueryInformation = 0x400u,
		QueryLimitedInformation = 0x1000u,
		Synchronize = 0x100000u
	}

	public static uint SE_PRIVILEGE_ENABLED;

	public static uint STANDARD_RIGHTS_REQUIRED;

	public static uint STANDARD_RIGHTS_READ;

	public static uint TOKEN_ASSIGN_PRIMARY;

	public static uint TOKEN_DUPLICATE;

	public static uint TOKEN_IMPERSONATE;

	public static uint TOKEN_QUERY;

	public static uint TOKEN_QUERY_SOURCE;

	public static uint TOKEN_ADJUST_PRIVILEGES;

	public static uint TOKEN_ADJUST_GROUPS;

	public static uint TOKEN_ADJUST_DEFAULT;

	public static uint TOKEN_ADJUST_SESSIONID;

	public static uint TOKEN_READ;

	public static uint TOKEN_ALL_ACCESS;

	private static ImpersonationToken NPQadfFM33Ha2qEVa8L2;

	[DllImport("advapi32.dll", EntryPoint = "LookupPrivilegeValue")]
	private static extern bool OGULFPFVp9R(string string_0, string string_1, out LUID luid_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr OpenProcess(ProcessAccessFlags processAccess, bool bInheritHandle, int processId);

	public static IntPtr OpenProcess(Process proc, ProcessAccessFlags flags)
	{
		return OpenProcess(flags, false, proc.Id);
	}

	[DllImport("advapi32.dll", EntryPoint = "OpenProcessToken", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool SuNLFEfodP0(IntPtr intptr_0, uint uint_0, out IntPtr intptr_1);

	[DllImport("advapi32.dll")]
	public static extern bool DuplicateToken(IntPtr ExistingTokenHandle, int SECURITY_IMPERSONATION_LEVEL, ref IntPtr DuplicateTokenHandle);

	[DllImport("advapi32.dll", EntryPoint = "SetThreadToken", SetLastError = true)]
	private static extern bool K3LLFyvIl68(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("advapi32.dll", EntryPoint = "AdjustTokenPrivileges", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DNsLF80FLQ6(IntPtr intptr_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, ref TOKEN_PRIVILEGES token_PRIVILEGES_0, uint uint_0, ref TOKEN_PRIVILEGES token_PRIVILEGES_1, out uint uint_1);

	[DllImport("kernel32.dll", EntryPoint = "GetCurrentProcess", SetLastError = true)]
	private static extern IntPtr QfLLFaJAO0G();

	[DllImport("advapi32.dll", SetLastError = true)]
	public static extern bool PrivilegeCheck(IntPtr ClientToken, ref PRIVILEGE_SET RequiredPrivileges, out bool pfResult);

	public static bool IsPrivilegeEnabled(string Privilege)
	{
		LUID luid_ = default(LUID);
		IntPtr intPtr = QfLLFaJAO0G();
		if (!(intPtr == IntPtr.Zero))
		{
			if (!SuNLFEfodP0(intPtr, TOKEN_QUERY, out var intptr_))
			{
				return false;
			}
			if (!OGULFPFVp9R(null, Privilege, out luid_))
			{
				return false;
			}
			PRIVILEGE_SET RequiredPrivileges = new PRIVILEGE_SET
			{
				Privilege = new LUID_AND_ATTRIBUTES[1],
				Control = PRIVILEGE_SET.PRIVILEGE_SET_ALL_NECESSARY,
				PrivilegeCount = 1u
			};
			RequiredPrivileges.Privilege[0].Luid = luid_;
			RequiredPrivileges.Privilege[0].Attributes = 2u;
			if (!PrivilegeCheck(intptr_, ref RequiredPrivileges, out var pfResult))
			{
				int num = 0;
				if (NPQadfFM33Ha2qEVa8L2 != null)
				{
					int num2 = default(int);
					num = num2;
				}
				return num switch
				{
					_ => false, 
				};
			}
			return pfResult;
		}
		return false;
	}

	public static bool EnablePrivilege(string Privilege)
	{
		LUID luid_ = default(LUID);
		if (!SuNLFEfodP0(QfLLFaJAO0G(), TOKEN_QUERY | TOKEN_ADJUST_PRIVILEGES, out var intptr_))
		{
			return false;
		}
		if (!OGULFPFVp9R(null, Privilege, out luid_))
		{
			return false;
		}
		LUID_AND_ATTRIBUTES lUID_AND_ATTRIBUTES = new LUID_AND_ATTRIBUTES
		{
			Luid = luid_,
			Attributes = 2u
		};
		TOKEN_PRIVILEGES tOKEN_PRIVILEGES = new TOKEN_PRIVILEGES
		{
			PrivilegeCount = 1
		};
		int num = 0;
		if (NPQadfFM33Ha2qEVa8L2 != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
		{
			tOKEN_PRIVILEGES.Privileges = new LUID_AND_ATTRIBUTES[1];
			TOKEN_PRIVILEGES token_PRIVILEGES_ = tOKEN_PRIVILEGES;
			token_PRIVILEGES_.Privileges[0] = lUID_AND_ATTRIBUTES;
			TOKEN_PRIVILEGES token_PRIVILEGES_2 = default(TOKEN_PRIVILEGES);
			if (!DNsLF80FLQ6(intptr_, false, ref token_PRIVILEGES_, (uint)Marshal.SizeOf(token_PRIVILEGES_), ref token_PRIVILEGES_2, out var uint_))
			{
				return false;
			}
			return true;
		}
		}
	}

	public static bool ImpersonateProcessToken(int pid)
	{
		IntPtr intPtr = OpenProcess(ProcessAccessFlags.QueryInformation, true, pid);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		if (!SuNLFEfodP0(intPtr, TOKEN_IMPERSONATE | TOKEN_DUPLICATE, out var intptr_))
		{
			return false;
		}
		IntPtr DuplicateTokenHandle = default(IntPtr);
		if (!DuplicateToken(intptr_, 2, ref DuplicateTokenHandle))
		{
			return false;
		}
		if (!K3LLFyvIl68(IntPtr.Zero, DuplicateTokenHandle))
		{
			return false;
		}
		return true;
	}

	public static bool ImpersonateProcessToken(int pid, IntPtr threadHandle)
	{
		IntPtr intPtr = OpenProcess(ProcessAccessFlags.QueryInformation, true, pid);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		if (!SuNLFEfodP0(intPtr, TOKEN_IMPERSONATE | TOKEN_DUPLICATE, out var intptr_))
		{
			return false;
		}
		IntPtr DuplicateTokenHandle = default(IntPtr);
		if (!DuplicateToken(intptr_, 2, ref DuplicateTokenHandle))
		{
			return false;
		}
		if (!K3LLFyvIl68(threadHandle, DuplicateTokenHandle))
		{
			return false;
		}
		return true;
	}

	static ImpersonationToken()
	{
		SE_PRIVILEGE_ENABLED = 2u;
		STANDARD_RIGHTS_REQUIRED = 983040u;
		STANDARD_RIGHTS_READ = 131072u;
		TOKEN_ASSIGN_PRIMARY = 1u;
		TOKEN_DUPLICATE = 2u;
		TOKEN_IMPERSONATE = 4u;
		TOKEN_QUERY = 8u;
		TOKEN_QUERY_SOURCE = 16u;
		TOKEN_ADJUST_PRIVILEGES = 32u;
		TOKEN_ADJUST_GROUPS = 64u;
		TOKEN_ADJUST_DEFAULT = 128u;
		TOKEN_ADJUST_SESSIONID = 256u;
		TOKEN_READ = STANDARD_RIGHTS_READ | TOKEN_QUERY;
		TOKEN_ALL_ACCESS = STANDARD_RIGHTS_REQUIRED | TOKEN_ASSIGN_PRIMARY | TOKEN_DUPLICATE | TOKEN_IMPERSONATE | TOKEN_QUERY | TOKEN_QUERY_SOURCE | TOKEN_ADJUST_PRIVILEGES | TOKEN_ADJUST_GROUPS | TOKEN_ADJUST_DEFAULT | TOKEN_ADJUST_SESSIONID;
	}

	internal static bool wpCDQiFME78EBV5YOqIc()
	{
		return NPQadfFM33Ha2qEVa8L2 == null;
	}
}
