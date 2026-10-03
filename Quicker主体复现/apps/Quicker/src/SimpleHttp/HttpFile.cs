using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace SimpleHttp;

public class HttpFile : IDisposable
{
	[CompilerGenerated]
	private string p48RHyfy99;

	[CompilerGenerated]
	private string CDCR1GkWhp;

	[CompilerGenerated]
	private Stream tsiRbnkEBW;

	[CompilerGenerated]
	private string V0HR6sGQ7G;

	internal static HttpFile eh8YwuJKxfHD0sxbTqT;

	public string FieldName
	{
		[CompilerGenerated]
		get
		{
			return p48RHyfy99;
		}
		[CompilerGenerated]
		private set
		{
			p48RHyfy99 = value;
		}
	}

	public string FileName
	{
		[CompilerGenerated]
		get
		{
			return CDCR1GkWhp;
		}
		[CompilerGenerated]
		private set
		{
			CDCR1GkWhp = value;
		}
	}

	public Stream Value
	{
		[CompilerGenerated]
		get
		{
			return tsiRbnkEBW;
		}
		[CompilerGenerated]
		private set
		{
			tsiRbnkEBW = value;
		}
	}

	public string ContentType
	{
		[CompilerGenerated]
		get
		{
			return V0HR6sGQ7G;
		}
		[CompilerGenerated]
		private set
		{
			V0HR6sGQ7G = value;
		}
	}

	internal HttpFile(string fileName, Stream value, string contentType, string fieldName)
	{
		Value = value;
		FileName = fileName;
		ContentType = contentType;
		FieldName = fieldName;
	}

	public bool Save(string fileName, bool overwrite = false)
	{
		string fullPath = Path.GetFullPath(fileName);
		if (File.Exists(fullPath) && !overwrite)
		{
			return false;
		}
		string directoryName = Path.GetDirectoryName(fullPath);
		if (!Directory.Exists(directoryName))
		{
			Directory.CreateDirectory(directoryName);
		}
		Value.Position = 0L;
		FileStream fileStream = File.Create(fullPath);
		int num = 0;
		if (eh8YwuJKxfHD0sxbTqT != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
			try
			{
				Value.CopyTo(fileStream);
			}
			finally
			{
				((IDisposable)fileStream)?.Dispose();
			}
			return true;
		}
	}

	public void Dispose()
	{
		Dispose(true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing && Value != null)
		{
			Value.Dispose();
			Value = null;
		}
	}

	~HttpFile()
	{
		Dispose(false);
	}

	internal static bool ECHE5RJBAQx0nD7NYJX()
	{
		return eh8YwuJKxfHD0sxbTqT == null;
	}
}
