namespace Quicker.Native.ShellMenu;

public enum MIIM : uint
{
	MIIM_STATE = 1u,
	MIIM_ID = 2u,
	MIIM_SUBMENU = 4u,
	MIIM_CHECKMARKS = 8u,
	MIIM_TYPE = 0x10u,
	MIIM_DATA = 0x20u,
	MIIM_STRING = 0x40u,
	MIIM_BITMAP = 0x80u,
	MIIM_FTYPE = 0x100u
}
