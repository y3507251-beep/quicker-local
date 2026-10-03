using System.Collections.Generic;

namespace Quicker.Modules.Searching;

public class ActionSearchHistory
{
	private IList<ActionSearchHistoryItem> QZBtu4CZt1b = new List<ActionSearchHistoryItem>();

	private int eK0tu5xRMeo = -1;

	internal static ActionSearchHistory mmF9B0QADKGZy3AD5kDj;

	public void AddHistory(string actionId, string query, int selectedIndex)
	{
		ActionSearchHistoryItem item = new ActionSearchHistoryItem
		{
			SelectedActionId = actionId,
			QueryString = query,
			SelectedIndex = selectedIndex
		};
		QZBtu4CZt1b.Insert(0, item);
		eK0tu5xRMeo = -1;
		for (int num = QZBtu4CZt1b.Count - 1; num > 0; num--)
		{
			if (QZBtu4CZt1b[num].QueryString == query && QZBtu4CZt1b[num].SelectedActionId == actionId)
			{
				QZBtu4CZt1b.RemoveAt(num);
			}
		}
		int num2 = 0;
		if (!UQc5JxQA3UTcBJj9qTcE())
		{
			int num3 = default(int);
			num2 = num3;
		}
		switch (num2)
		{
		}
		if (QZBtu4CZt1b.Count > 10)
		{
			QZBtu4CZt1b.RemoveAt(QZBtu4CZt1b.Count - 1);
		}
	}

	public ActionSearchHistoryItem GetPrevItem()
	{
		eK0tu5xRMeo++;
		if (eK0tu5xRMeo > QZBtu4CZt1b.Count - 1)
		{
			eK0tu5xRMeo = QZBtu4CZt1b.Count - 1;
			return null;
		}
		return QZBtu4CZt1b[eK0tu5xRMeo];
	}

	public ActionSearchHistoryItem GetNextItem()
	{
		eK0tu5xRMeo--;
		if (eK0tu5xRMeo < 0)
		{
			eK0tu5xRMeo = -1;
			return null;
		}
		if (eK0tu5xRMeo < QZBtu4CZt1b.Count)
		{
			return QZBtu4CZt1b[eK0tu5xRMeo];
		}
		return null;
	}

	public string GetPrevQueryText(string actionId, string prefix)
	{
		int num = 0;
		while (true)
		{
			if (num < QZBtu4CZt1b.Count)
			{
				if (QZBtu4CZt1b[num].SelectedActionId == actionId && QZBtu4CZt1b[num].QueryString.StartsWith(prefix))
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return QZBtu4CZt1b[num].QueryString;
	}

	internal static bool UQc5JxQA3UTcBJj9qTcE()
	{
		return mmF9B0QADKGZy3AD5kDj == null;
	}
}
