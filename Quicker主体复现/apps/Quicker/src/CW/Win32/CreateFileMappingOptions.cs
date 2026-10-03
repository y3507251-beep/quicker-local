using System;

namespace CW.Win32;

[Flags]
public enum CreateFileMappingOptions : uint
{
	None = 0u,
	PageReadOnly = 2u,
	PageReadWrite = 4u,
	PageWriteCopy = 8u,
	SecImage = 0x1000000u,
	SecReserve = 0x4000000u,
	SecCommit = 0x8000000u,
	SecNoCache = 0x10000000u
}
