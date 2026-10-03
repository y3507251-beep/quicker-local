namespace FindReplace;

public interface IEditor
{
	string Text { get; }

	int SelectionStart { get; }

	int SelectionLength { get; }

	string SelectedText { get; }

	void Select(int start, int length);

	void Replace(int start, int length, string ReplaceWith);

	void BeginChange();

	void EndChange();
}
