using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CW.Win32.Shell;

public class FileOperation : ComObject<IFileOperation>
{
	private static readonly Guid yqnPtl37VX;

	private static readonly Type KR6Pg10xGK;

	private static Guid OFRPL0e8Qa;

	private uint wAwPvNs9bZ;

	[CompilerGenerated]
	private IntPtr YnSPS9TgEc;

	private FileOperationProgressSink nDAP2Y122K;

	private FileOperationFlags iYDPux2Say;

	internal static FileOperation Xc0KZY17XcH776mEjTB;

	public IntPtr Owner
	{
		[CompilerGenerated]
		get
		{
			return YnSPS9TgEc;
		}
		[CompilerGenerated]
		set
		{
			YnSPS9TgEc = value;
		}
	}

	public FileOperationProgressSink ProgressSink => nDAP2Y122K;

	public bool IsOperationAborted => base.Interface.GetAnyOperationsAborted();

	public FileOperationFlags OperationFlags
	{
		get
		{
			return iYDPux2Say;
		}
		set
		{
			iYDPux2Say = value;
			base.Interface.SetOperationFlags(value);
		}
	}

	public FileOperation()
		: base((IFileOperation)Activator.CreateInstance(KR6Pg10xGK))
	{
		nDAP2Y122K = new FileOperationProgressSink();
		wAwPvNs9bZ = base.Interface.Advise(nDAP2Y122K.Interface);
	}

	public void Copy(string[] source, string destination)
	{
		ThrowIfDisposed();
		source.ThrowIfNull("source");
		destination.ThrowIfNull("destination");
		using ShellItemArray shellItemArray = ShellItemArray.FromFiles(source);
		using ShellItem shellItem = ShellItem.FromPath(destination);
		base.Interface.CopyItems(shellItemArray.Interface, shellItem.Interface);
		Marshal.ThrowExceptionForHR(base.Interface.PerformOperations());
	}

	public void Move(string[] source, string destination)
	{
		ThrowIfDisposed();
		source.ThrowIfNull("source");
		destination.ThrowIfNull("destination");
		using ShellItemArray shellItemArray = ShellItemArray.FromFiles(source);
		using ShellItem shellItem = ShellItem.FromPath(destination);
		base.Interface.MoveItems(shellItemArray.Interface, shellItem.Interface);
		Marshal.ThrowExceptionForHR(base.Interface.PerformOperations());
	}

	public void Delete(string[] source)
	{
		ThrowIfDisposed();
		source.ThrowIfNull("source");
		using ShellItemArray shellItemArray = ShellItemArray.FromFiles(source);
		base.Interface.DeleteItems(shellItemArray.Interface);
		Marshal.ThrowExceptionForHR(base.Interface.PerformOperations());
	}

	public void Rename(string source, string newName)
	{
		ThrowIfDisposed();
		source.ThrowIfNull("source");
		newName.ThrowIfNull("newName");
		using ShellItem shellItem = ShellItem.FromPath(source);
		base.Interface.RenameItem(shellItem.Interface, newName, null);
		Marshal.ThrowExceptionForHR(base.Interface.PerformOperations());
	}

	public void Create(string parent, string name, FileAttributes attr, string templateName = null)
	{
		using ShellItem shellItem = ShellItem.FromPath(parent);
		base.Interface.NewItem(shellItem.Interface, attr, name, templateName, null);
		Marshal.ThrowExceptionForHR(base.Interface.PerformOperations());
	}

	protected override void Dispose(bool disposing)
	{
		if (wAwPvNs9bZ != 0)
		{
			base.Interface.Unadvise(wAwPvNs9bZ);
			wAwPvNs9bZ = 0u;
		}
		base.Dispose(disposing);
	}

	static FileOperation()
	{
		yqnPtl37VX = new Guid("3ad05575-8857-4850-9277-11b85bdb8e09");
		KR6Pg10xGK = Type.GetTypeFromCLSID(yqnPtl37VX);
		OFRPL0e8Qa = typeof(IShellItem).GUID;
	}

	internal static bool Fn5SR814erb8mlk5im2()
	{
		return Xc0KZY17XcH776mEjTB == null;
	}
}
