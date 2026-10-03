using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

namespace CW.Win32.Shell;

public class FileOperationProgressSink
{
	internal class lKX7RBd61ctGFeKBbut : IFileOperationProgressSink
	{
		private FileOperationProgressSink i15vyOMaQfN;

		internal static lKX7RBd61ctGFeKBbut PbV9tUcGXmsTQKP1nYh2;

		internal lKX7RBd61ctGFeKBbut(FileOperationProgressSink fileOperationProgressSink_1)
		{
			fileOperationProgressSink_1.ThrowIfNull("sink");
			i15vyOMaQfN = fileOperationProgressSink_1;
		}

		public void StartOperations()
		{
			i15vyOMaQfN.OnStarted(EventArgs.Empty);
		}

		public void FinishOperations(int hrResult)
		{
			i15vyOMaQfN.OnCompleted(new FileOperationResultEventArgs(hrResult));
		}

		public int PreRenameItem(TransferSourceFlags dwFlags, IShellItem psiItem, string pszNewName)
		{
			FileOperationItemEventArgs e = new FileOperationItemEventArgs(dwFlags, psiItem, pszNewName, null);
			i15vyOMaQfN.OnRenaming(e);
			return e.Cancel ? 1 : 0;
		}

		public int PostRenameItem(TransferSourceFlags dwFlags, IShellItem psiItem, string pszNewName, int hrRename, IShellItem psiNewlyCreated)
		{
			FileOperationResultItemEventArgs e = new FileOperationResultItemEventArgs(hrRename, dwFlags, psiItem, pszNewName, psiNewlyCreated, null);
			i15vyOMaQfN.OnRenamed(e);
			return e.Cancel ? 1 : 0;
		}

		public int PreMoveItem(TransferSourceFlags dwFlags, IShellItem psiItem, IShellItem psiDestinationFolder, string pszNewName)
		{
			FileOperationItemEventArgs e = new FileOperationItemEventArgs(dwFlags, psiItem, pszNewName, psiDestinationFolder);
			i15vyOMaQfN.OnMoving(e);
			return e.Cancel ? 1 : 0;
		}

		public int PostMoveItem(TransferSourceFlags dwFlags, IShellItem psiItem, IShellItem psiDestinationFolder, string pszNewName, int hrMove, IShellItem psiNewlyCreated)
		{
			FileOperationResultItemEventArgs e = new FileOperationResultItemEventArgs(hrMove, dwFlags, psiItem, pszNewName, psiNewlyCreated, psiDestinationFolder);
			i15vyOMaQfN.OnMoved(e);
			return e.Cancel ? 1 : 0;
		}

		public int PreCopyItem(TransferSourceFlags dwFlags, IShellItem psiItem, IShellItem psiDestinationFolder, string pszNewName)
		{
			FileOperationItemEventArgs e = new FileOperationItemEventArgs(dwFlags, psiItem, pszNewName, psiDestinationFolder);
			i15vyOMaQfN.OnCopying(e);
			return e.Cancel ? 1 : 0;
		}

		public int PostCopyItem(TransferSourceFlags dwFlags, IShellItem psiItem, IShellItem psiDestinationFolder, string pszNewName, int hrCopy, IShellItem psiNewlyCreated)
		{
			FileOperationResultItemEventArgs e = new FileOperationResultItemEventArgs(hrCopy, dwFlags, psiItem, pszNewName, psiNewlyCreated, psiDestinationFolder);
			i15vyOMaQfN.OnCopied(e);
			return e.Cancel ? 1 : 0;
		}

		public int PreDeleteItem(TransferSourceFlags dwFlags, IShellItem psiItem)
		{
			FileOperationItemEventArgs e = new FileOperationItemEventArgs(dwFlags, psiItem, null, null);
			i15vyOMaQfN.OnDeleting(e);
			return e.Cancel ? 1 : 0;
		}

		public int PostDeleteItem(TransferSourceFlags dwFlags, IShellItem psiItem, int hrDelete, IShellItem psiNewlyCreated)
		{
			FileOperationResultItemEventArgs e = new FileOperationResultItemEventArgs(hrDelete, dwFlags, psiItem, null, psiNewlyCreated, null);
			i15vyOMaQfN.OnDeleted(e);
			return e.Cancel ? 1 : 0;
		}

		public int PreNewItem(TransferSourceFlags dwFlags, IShellItem psiDestinationFolder, string pszNewName)
		{
			FileOperationItemEventArgs e = new FileOperationItemEventArgs(dwFlags, null, pszNewName, psiDestinationFolder);
			i15vyOMaQfN.OnCreating(e);
			return e.Cancel ? 1 : 0;
		}

		public int PostNewItem(TransferSourceFlags dwFlags, IShellItem psiDestinationFolder, string pszNewName, string pszTemplateName, FileAttributes dwFileAttributes, int hrNew, IShellItem psiNewItem)
		{
			FileOperationResultItemEventArgs e = new FileOperationResultItemEventArgs(hrNew, dwFlags, null, pszNewName, psiNewItem, psiDestinationFolder);
			i15vyOMaQfN.OnCreated(e);
			return e.Cancel ? 1 : 0;
		}

		public void UpdateProgress(int iWorkTotal, int iWorkSoFar)
		{
			i15vyOMaQfN.OnProgressChanged(new FileOperationProgressEventArgs(iWorkTotal, iWorkSoFar));
		}

		public void ResetTimer()
		{
		}

		public void PauseTimer()
		{
		}

		public void ResumeTimer()
		{
		}

		internal static bool sWgSTDcG2DZZrpAEtbcW()
		{
			return PbV9tUcGXmsTQKP1nYh2 == null;
		}
	}

	[CompilerGenerated]
	private EventHandler OeHP0fyyLY;

	[CompilerGenerated]
	private EventHandler<FileOperationResultEventArgs> hIZPC0j7rF;

	[CompilerGenerated]
	private EventHandler<FileOperationItemEventArgs> Y2pPP7E67Y;

	[CompilerGenerated]
	private EventHandler<FileOperationResultItemEventArgs> mnwPEAOeJm;

	[CompilerGenerated]
	private EventHandler<FileOperationItemEventArgs> N9dPyfTINg;

	[CompilerGenerated]
	private EventHandler<FileOperationResultItemEventArgs> cVVP87LMtm;

	[CompilerGenerated]
	private EventHandler<FileOperationItemEventArgs> wTPPaqOG4V;

	[CompilerGenerated]
	private EventHandler<FileOperationResultItemEventArgs> TaNP7YKeFh;

	[CompilerGenerated]
	private EventHandler<FileOperationItemEventArgs> hFdPRAM1qe;

	[CompilerGenerated]
	private EventHandler<FileOperationResultItemEventArgs> G8IPqQK4PX;

	[CompilerGenerated]
	private EventHandler<FileOperationItemEventArgs> IadPc4u5lK;

	[CompilerGenerated]
	private EventHandler<FileOperationResultItemEventArgs> L9ZPV3Pqei;

	[CompilerGenerated]
	private EventHandler<FileOperationProgressEventArgs> NQ1PZUhJoF;

	[CompilerGenerated]
	private lKX7RBd61ctGFeKBbut ubiP9MNSaZ;

	internal static FileOperationProgressSink zPfeSHKXjRxEnCoFn0m;

	internal lKX7RBd61ctGFeKBbut Interface
	{
		[CompilerGenerated]
		get
		{
			return ubiP9MNSaZ;
		}
		[CompilerGenerated]
		private set
		{
			ubiP9MNSaZ = value;
		}
	}

	public event EventHandler Started
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = OeHP0fyyLY;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref OeHP0fyyLY, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = OeHP0fyyLY;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref OeHP0fyyLY, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<FileOperationResultEventArgs> Completed
	{
		[CompilerGenerated]
		add
		{
			EventHandler<FileOperationResultEventArgs> eventHandler = hIZPC0j7rF;
			EventHandler<FileOperationResultEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<FileOperationResultEventArgs> value2 = (EventHandler<FileOperationResultEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref hIZPC0j7rF, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<FileOperationResultEventArgs> eventHandler = hIZPC0j7rF;
			EventHandler<FileOperationResultEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<FileOperationResultEventArgs> value2 = (EventHandler<FileOperationResultEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref hIZPC0j7rF, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<FileOperationItemEventArgs> Deleting
	{
		[CompilerGenerated]
		add
		{
			EventHandler<FileOperationItemEventArgs> eventHandler = Y2pPP7E67Y;
			EventHandler<FileOperationItemEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<FileOperationItemEventArgs> value2 = (EventHandler<FileOperationItemEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Y2pPP7E67Y, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<FileOperationItemEventArgs> eventHandler = Y2pPP7E67Y;
			EventHandler<FileOperationItemEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<FileOperationItemEventArgs> value2 = (EventHandler<FileOperationItemEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref Y2pPP7E67Y, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<FileOperationResultItemEventArgs> Deleted
	{
		[CompilerGenerated]
		add
		{
			EventHandler<FileOperationResultItemEventArgs> eventHandler = mnwPEAOeJm;
			EventHandler<FileOperationResultItemEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<FileOperationResultItemEventArgs> value2 = (EventHandler<FileOperationResultItemEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref mnwPEAOeJm, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<FileOperationResultItemEventArgs> eventHandler = mnwPEAOeJm;
			EventHandler<FileOperationResultItemEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<FileOperationResultItemEventArgs> value2 = (EventHandler<FileOperationResultItemEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref mnwPEAOeJm, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<FileOperationItemEventArgs> Renaming
	{
		[CompilerGenerated]
		add
		{
			EventHandler<FileOperationItemEventArgs> eventHandler = N9dPyfTINg;
			EventHandler<FileOperationItemEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<FileOperationItemEventArgs> value2 = (EventHandler<FileOperationItemEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref N9dPyfTINg, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<FileOperationItemEventArgs> eventHandler = N9dPyfTINg;
			EventHandler<FileOperationItemEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<FileOperationItemEventArgs> value2 = (EventHandler<FileOperationItemEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref N9dPyfTINg, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<FileOperationResultItemEventArgs> Renamed
	{
		[CompilerGenerated]
		add
		{
			EventHandler<FileOperationResultItemEventArgs> eventHandler = cVVP87LMtm;
			EventHandler<FileOperationResultItemEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<FileOperationResultItemEventArgs> value2 = (EventHandler<FileOperationResultItemEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref cVVP87LMtm, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<FileOperationResultItemEventArgs> eventHandler = cVVP87LMtm;
			EventHandler<FileOperationResultItemEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<FileOperationResultItemEventArgs> value2 = (EventHandler<FileOperationResultItemEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref cVVP87LMtm, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<FileOperationItemEventArgs> Copying
	{
		[CompilerGenerated]
		add
		{
			EventHandler<FileOperationItemEventArgs> eventHandler = wTPPaqOG4V;
			EventHandler<FileOperationItemEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<FileOperationItemEventArgs> value2 = (EventHandler<FileOperationItemEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref wTPPaqOG4V, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<FileOperationItemEventArgs> eventHandler = wTPPaqOG4V;
			EventHandler<FileOperationItemEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<FileOperationItemEventArgs> value2 = (EventHandler<FileOperationItemEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref wTPPaqOG4V, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<FileOperationResultItemEventArgs> Copied
	{
		[CompilerGenerated]
		add
		{
			EventHandler<FileOperationResultItemEventArgs> eventHandler = TaNP7YKeFh;
			EventHandler<FileOperationResultItemEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<FileOperationResultItemEventArgs> value2 = (EventHandler<FileOperationResultItemEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref TaNP7YKeFh, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<FileOperationResultItemEventArgs> eventHandler = TaNP7YKeFh;
			EventHandler<FileOperationResultItemEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<FileOperationResultItemEventArgs> value2 = (EventHandler<FileOperationResultItemEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref TaNP7YKeFh, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<FileOperationItemEventArgs> Moving
	{
		[CompilerGenerated]
		add
		{
			EventHandler<FileOperationItemEventArgs> eventHandler = hFdPRAM1qe;
			EventHandler<FileOperationItemEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<FileOperationItemEventArgs> value2 = (EventHandler<FileOperationItemEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref hFdPRAM1qe, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<FileOperationItemEventArgs> eventHandler = hFdPRAM1qe;
			EventHandler<FileOperationItemEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<FileOperationItemEventArgs> value2 = (EventHandler<FileOperationItemEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref hFdPRAM1qe, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<FileOperationResultItemEventArgs> Moved
	{
		[CompilerGenerated]
		add
		{
			EventHandler<FileOperationResultItemEventArgs> eventHandler = G8IPqQK4PX;
			EventHandler<FileOperationResultItemEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<FileOperationResultItemEventArgs> value2 = (EventHandler<FileOperationResultItemEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref G8IPqQK4PX, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<FileOperationResultItemEventArgs> eventHandler = G8IPqQK4PX;
			EventHandler<FileOperationResultItemEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<FileOperationResultItemEventArgs> value2 = (EventHandler<FileOperationResultItemEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref G8IPqQK4PX, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<FileOperationItemEventArgs> Creating
	{
		[CompilerGenerated]
		add
		{
			EventHandler<FileOperationItemEventArgs> eventHandler = IadPc4u5lK;
			EventHandler<FileOperationItemEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<FileOperationItemEventArgs> value2 = (EventHandler<FileOperationItemEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref IadPc4u5lK, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<FileOperationItemEventArgs> eventHandler = IadPc4u5lK;
			EventHandler<FileOperationItemEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<FileOperationItemEventArgs> value2 = (EventHandler<FileOperationItemEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref IadPc4u5lK, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<FileOperationResultItemEventArgs> Created
	{
		[CompilerGenerated]
		add
		{
			EventHandler<FileOperationResultItemEventArgs> eventHandler = L9ZPV3Pqei;
			EventHandler<FileOperationResultItemEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<FileOperationResultItemEventArgs> value2 = (EventHandler<FileOperationResultItemEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref L9ZPV3Pqei, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<FileOperationResultItemEventArgs> eventHandler = L9ZPV3Pqei;
			EventHandler<FileOperationResultItemEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<FileOperationResultItemEventArgs> value2 = (EventHandler<FileOperationResultItemEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref L9ZPV3Pqei, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<FileOperationProgressEventArgs> ProgressChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler<FileOperationProgressEventArgs> eventHandler = NQ1PZUhJoF;
			EventHandler<FileOperationProgressEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<FileOperationProgressEventArgs> value2 = (EventHandler<FileOperationProgressEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref NQ1PZUhJoF, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<FileOperationProgressEventArgs> eventHandler = NQ1PZUhJoF;
			EventHandler<FileOperationProgressEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<FileOperationProgressEventArgs> value2 = (EventHandler<FileOperationProgressEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref NQ1PZUhJoF, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public FileOperationProgressSink()
	{
		Interface = new lKX7RBd61ctGFeKBbut(this);
	}

	protected virtual void OnStarted(EventArgs e)
	{
		OeHP0fyyLY?.Invoke(this, e);
	}

	protected virtual void OnCompleted(FileOperationResultEventArgs e)
	{
		hIZPC0j7rF?.Invoke(this, e);
	}

	protected virtual void OnDeleting(FileOperationItemEventArgs e)
	{
		Y2pPP7E67Y?.Invoke(this, e);
	}

	protected virtual void OnDeleted(FileOperationResultItemEventArgs e)
	{
		mnwPEAOeJm?.Invoke(this, e);
	}

	protected virtual void OnRenaming(FileOperationItemEventArgs e)
	{
		N9dPyfTINg?.Invoke(this, e);
	}

	protected virtual void OnRenamed(FileOperationResultItemEventArgs e)
	{
		cVVP87LMtm?.Invoke(this, e);
	}

	protected virtual void OnCopying(FileOperationItemEventArgs e)
	{
		wTPPaqOG4V?.Invoke(this, e);
	}

	protected virtual void OnCopied(FileOperationResultItemEventArgs e)
	{
		TaNP7YKeFh?.Invoke(this, e);
	}

	protected virtual void OnMoving(FileOperationItemEventArgs e)
	{
		hFdPRAM1qe?.Invoke(this, e);
	}

	protected virtual void OnMoved(FileOperationResultItemEventArgs e)
	{
		G8IPqQK4PX?.Invoke(this, e);
	}

	protected virtual void OnCreating(FileOperationItemEventArgs e)
	{
		IadPc4u5lK?.Invoke(this, e);
	}

	protected virtual void OnCreated(FileOperationResultItemEventArgs e)
	{
		L9ZPV3Pqei?.Invoke(this, e);
	}

	public void OnProgressChanged(FileOperationProgressEventArgs e)
	{
		NQ1PZUhJoF?.Invoke(this, e);
	}

	internal static bool qrXJOAK2ufhLpgTg9ld()
	{
		return zPfeSHKXjRxEnCoFn0m == null;
	}
}
