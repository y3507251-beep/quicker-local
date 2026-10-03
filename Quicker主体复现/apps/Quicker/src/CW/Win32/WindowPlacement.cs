namespace CW.Win32;

public struct WindowPlacement
{
	public long Length;

	public long Flags;

	public ShowWindowCommand Command;

	public Point MinPosition;

	public Point MaxPosition;

	public Rectangle NormalPosition;
}
