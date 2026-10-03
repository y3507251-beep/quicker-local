using ICSharpCode.AvalonEdit.Document;
using ICSharpCode.AvalonEdit.Rendering;

namespace Quicker.Utilities.Ext;

public class TruncateLongLines : VisualLineElementGenerator
{
	internal static TruncateLongLines HKg5ufFIyCJrXey6NOJ8;

	public override int GetFirstInterestedOffset(int startOffset)
	{
		DocumentLine lastDocumentLine = base.CurrentContext.VisualLine.LastDocumentLine;
		if (lastDocumentLine.Length > 9000)
		{
			int num = lastDocumentLine.Offset + 9000 - 100 - "……………(行太长,已隐藏部分内容)……………".Length;
			if (startOffset <= num)
			{
				return num;
			}
		}
		return -1;
	}

	public override VisualLineElement ConstructElement(int offset)
	{
		return new FormattedTextElement("……………(行太长,已隐藏部分内容)……………", base.CurrentContext.VisualLine.LastDocumentLine.EndOffset - offset - 100);
	}

	internal static bool W4qatFFIp45guPmAgcy1()
	{
		return HKg5ufFIyCJrXey6NOJ8 == null;
	}
}
