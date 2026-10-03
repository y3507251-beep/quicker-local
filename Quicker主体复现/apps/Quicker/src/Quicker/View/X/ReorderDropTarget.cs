using System;
using System.Windows;
using GongSolutions.Wpf.DragDrop;
using Quicker.Utilities;
using Quicker.Utilities.Ext;

namespace Quicker.View.X;

public class ReorderDropTarget : IDropTarget
{
	private readonly DefaultDropHandler oBwLkNF6U3F = new DefaultDropHandler();

	public static ReorderDropTarget Default;

	private static ReorderDropTarget TBeDpKFkjT8IaE3HGoKs;

	public void DragOver(IDropInfo dropInfo)
	{
		if (dropInfo.DragInfo != null && dropInfo.DragInfo.SourceCollection != null && dropInfo.TargetCollection != null && dropInfo.DragInfo.SourceCollection == dropInfo.TargetCollection)
		{
			oBwLkNF6U3F.DragOver(dropInfo);
		}
		else
		{
			dropInfo.Effects = DragDropEffects.None;
		}
	}

	public void Drop(IDropInfo dropInfo)
	{
		if (!dropInfo.IsSameDragDropContextAsSource)
		{
			AppHelper.ShowWarning("仅可以在列表中拖动排序。");
			return;
		}
		try
		{
			oBwLkNF6U3F.Drop(dropInfo);
		}
		catch (Exception exception)
		{
			AppHelper.ShowWarning("拖动处理出错，可能不支持此对象类型。" + exception.GetMessageWithInner(), true);
		}
	}

	public void DragEnter(IDropInfo dropInfo)
	{
	}

	public void DragLeave(IDropInfo dropInfo)
	{
	}

	static ReorderDropTarget()
	{
		Default = new ReorderDropTarget();
	}

	internal static bool e4kWjDFkDMydwRwcbdvm()
	{
		return TBeDpKFkjT8IaE3HGoKs == null;
	}
}
