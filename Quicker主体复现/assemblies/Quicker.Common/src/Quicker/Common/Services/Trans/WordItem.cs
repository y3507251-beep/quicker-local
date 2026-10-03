namespace Quicker.Common.Services.Trans;

public class WordItem
{
	public int Id { get; set; }

	public string Word { get; set; }

	public string Phonetic { get; set; }

	public string Definition { get; set; }

	public string Translation { get; set; }

	public string Pos { get; set; }

	public string Tag { get; set; }

	public int? Bnc { get; set; }

	public int? Frq { get; set; }

	public string Exchange { get; set; }
}
