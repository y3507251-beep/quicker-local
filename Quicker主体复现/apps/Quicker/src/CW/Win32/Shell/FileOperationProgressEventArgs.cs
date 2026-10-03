using System;
using System.Runtime.CompilerServices;

namespace CW.Win32.Shell;

public class FileOperationProgressEventArgs : EventArgs
{
	[CompilerGenerated]
	private int j2UPYhCx8L;

	[CompilerGenerated]
	private int m1kPIUpt12;

	internal static FileOperationProgressEventArgs hvyfigKnuBfp9tjZUyY;

	public int WorkSoFar
	{
		[CompilerGenerated]
		get
		{
			return j2UPYhCx8L;
		}
		[CompilerGenerated]
		private set
		{
			j2UPYhCx8L = value;
		}
	}

	public int WorkTotal
	{
		[CompilerGenerated]
		get
		{
			return m1kPIUpt12;
		}
		[CompilerGenerated]
		private set
		{
			m1kPIUpt12 = value;
		}
	}

	public double Progress => (double)WorkSoFar / (double)WorkTotal;

	public FileOperationProgressEventArgs(int workTotal, int workSoFar)
	{
		WorkTotal = workTotal;
		WorkSoFar = workSoFar;
	}

	internal static bool auyJhPKek5TuekaXOmG()
	{
		return hvyfigKnuBfp9tjZUyY == null;
	}
}
