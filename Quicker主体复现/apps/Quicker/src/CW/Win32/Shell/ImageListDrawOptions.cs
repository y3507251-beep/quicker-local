using System;

namespace CW.Win32.Shell;

[Flags]
public enum ImageListDrawOptions : uint
{
	Normal = 0u,
	Transparent = 1u,
	Blend25 = 2u,
	Selected = 4u,
	Mask = 0x10u,
	Image = 0x20u,
	RasterOperation = 0x40u,
	PreserveAlpha = 0x1000u,
	Scale = 0x2000u,
	DpiScale = 0x4000u,
	Async = 0x8000u
}
