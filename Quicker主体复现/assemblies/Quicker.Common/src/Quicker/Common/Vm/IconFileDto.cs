using System;

namespace Quicker.Common.Vm;

public class IconFileDto
{
	public string FileName { get; set; }

	public string Url { get; set; }

	public Guid FileId { get; set; }

	public IconFileDto(string url, string filename, Guid fileId)
	{
		Url = url;
		FileName = filename;
		FileId = fileId;
	}
}
