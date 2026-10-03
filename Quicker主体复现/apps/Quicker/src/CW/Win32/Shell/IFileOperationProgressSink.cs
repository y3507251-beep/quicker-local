using System.IO;
using System.Runtime.InteropServices;

namespace CW.Win32.Shell;

[ComImport]
[Guid("04b0f1a7-9490-44bc-96e1-4296a31252e2")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IFileOperationProgressSink
{
	void StartOperations();

	void FinishOperations(int hrResult);

	int PreRenameItem(TransferSourceFlags dwFlags, IShellItem psiItem, [MarshalAs(UnmanagedType.LPWStr)] string pszNewName);

	int PostRenameItem(TransferSourceFlags dwFlags, IShellItem psiItem, [MarshalAs(UnmanagedType.LPWStr)] string pszNewName, int hrRename, IShellItem psiNewlyCreated);

	int PreMoveItem(TransferSourceFlags dwFlags, IShellItem psiItem, IShellItem psiDestinationFolder, [MarshalAs(UnmanagedType.LPWStr)] string pszNewName);

	int PostMoveItem(TransferSourceFlags dwFlags, IShellItem psiItem, IShellItem psiDestinationFolder, [MarshalAs(UnmanagedType.LPWStr)] string pszNewName, int hrMove, IShellItem psiNewlyCreated);

	int PreCopyItem(TransferSourceFlags dwFlags, IShellItem psiItem, IShellItem psiDestinationFolder, [MarshalAs(UnmanagedType.LPWStr)] string pszNewName);

	int PostCopyItem(TransferSourceFlags dwFlags, IShellItem psiItem, IShellItem psiDestinationFolder, [MarshalAs(UnmanagedType.LPWStr)] string pszNewName, int hrCopy, IShellItem psiNewlyCreated);

	int PreDeleteItem(TransferSourceFlags dwFlags, IShellItem psiItem);

	int PostDeleteItem(TransferSourceFlags dwFlags, IShellItem psiItem, int hrDelete, IShellItem psiNewlyCreated);

	int PreNewItem(TransferSourceFlags dwFlags, IShellItem psiDestinationFolder, [MarshalAs(UnmanagedType.LPWStr)] string pszNewName);

	int PostNewItem(TransferSourceFlags dwFlags, IShellItem psiDestinationFolder, [MarshalAs(UnmanagedType.LPWStr)] string pszNewName, [MarshalAs(UnmanagedType.LPWStr)] string pszTemplateName, FileAttributes dwFileAttributes, int hrNew, IShellItem psiNewItem);

	void UpdateProgress(int iWorkTotal, int iWorkSoFar);

	void ResetTimer();

	void PauseTimer();

	void ResumeTimer();
}
