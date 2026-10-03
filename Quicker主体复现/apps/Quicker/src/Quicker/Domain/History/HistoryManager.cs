using System;

namespace Quicker.Domain.History;

public class HistoryManager
{
	private readonly SizedStack<HistoryItem> GiYtcbCLXgt = new SizedStack<HistoryItem>(50);

	private readonly SizedStack<HistoryItem> Jxatc686Dmm = new SizedStack<HistoryItem>(50);

	private static HistoryManager MloNDjQ04w379bcBifpR;

	public bool Add(string data)
	{
		if (GiYtcbCLXgt.Count > 0 && string.Equals(GiYtcbCLXgt.Peek().Data, data, StringComparison.Ordinal))
		{
			return false;
		}
		GiYtcbCLXgt.Push(new HistoryItem
		{
			Data = data,
			SaveTime = DateTime.Now
		});
		Jxatc686Dmm.Clear();
		return true;
	}

	public void Reset()
	{
		GiYtcbCLXgt.Clear();
		Jxatc686Dmm.Clear();
	}

	public bool CanUndo()
	{
		return GiYtcbCLXgt.Count > 1;
	}

	public bool CanRedo()
	{
		return Jxatc686Dmm.Count > 0;
	}

	public string Undo()
	{
		HistoryItem item = GiYtcbCLXgt.Pop();
		Jxatc686Dmm.Push(item);
		item = GiYtcbCLXgt.Peek();
		return item.Data;
	}

	public string Redo()
	{
		HistoryItem historyItem = Jxatc686Dmm.Pop();
		GiYtcbCLXgt.Push(historyItem);
		return historyItem.Data;
	}

	public int GetUndoCount()
	{
		return GiYtcbCLXgt.Count;
	}

	internal static bool dpZwZAQ0hxftARRCNK1A()
	{
		return MloNDjQ04w379bcBifpR == null;
	}

	internal static void BIAUHAQ0zspb863Ge21P()
	{
	}
}
