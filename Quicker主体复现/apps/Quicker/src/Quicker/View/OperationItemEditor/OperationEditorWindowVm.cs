using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Quicker.Public.Entities;
using Quicker.Public.Extensions;
using Quicker.Utilities;
using Quicker.Utilities._3rd;

namespace Quicker.View.OperationItemEditor;

public class OperationEditorWindowVm : ObservableObject
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec BuQSDU99pMs;

		public static Func<ObservableOperationItem, CommonOperationItem> EAISDlfxwTp;

		internal static _003C_003Ec EFlKgvWmbyX01vdhHubN;

		static _003C_003Ec()
		{
			BuQSDU99pMs = new _003C_003Ec();
		}

		internal CommonOperationItem gMHSDFwBda2(ObservableOperationItem x)
		{
			return x.GetItem();
		}

		internal static void u0OOeeWmlOcTcybxF67r()
		{
		}

		internal static bool XSjTa0WmqP0f8V6SOqer()
		{
			return EFlKgvWmbyX01vdhHubN == null;
		}
	}

	private readonly bool FmRL7VGfJEL;

	private ObservableOperationItem fyML7ZGVvuc;

	[CompilerGenerated]
	private readonly SmartCollection<ObservableOperationItem> PhVL79F9t6i = new SmartCollection<ObservableOperationItem>();

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.3.0.0")]
	private RelayCommand? fTwL7h7MGw8;

	internal static OperationEditorWindowVm WnlOPyF05xj5uvH09ymk;

	public SmartCollection<ObservableOperationItem> Items
	{
		[CompilerGenerated]
		get
		{
			return PhVL79F9t6i;
		}
	}

	public ObservableOperationItem SelectedItem
	{
		get
		{
			return fyML7ZGVvuc;
		}
		set
		{
			SetProperty(ref fyML7ZGVvuc, value, "SelectedItem");
		}
	}

	[ExcludeFromCodeCoverage]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.3.0.0")]
	public IRelayCommand CreateItemCommand => fTwL7h7MGw8 ?? (fTwL7h7MGw8 = new RelayCommand(pqRL7qBu6V2));

	public OperationEditorWindowVm(bool onlyData)
	{
		FmRL7VGfJEL = onlyData;
	}

	[RelayCommand]
	private void pqRL7qBu6V2()
	{
		AppHelper.ShowInformation("创建子节点");
	}

	public ObservableOperationItem AddItem(CommonOperationItem item)
	{
		ObservableOperationItem observableOperationItem = new ObservableOperationItem(item);
		(IList<ObservableOperationItem>, int) tuple = mJsL7cbepEq(SelectedItem, Items);
		if (tuple.Item1 == null)
		{
			Items.Insert(0, observableOperationItem);
		}
		else
		{
			tuple.Item1.Insert(tuple.Item2 + 1, observableOperationItem);
		}
		return observableOperationItem;
	}

	public void AddChild(CommonOperationItem item)
	{
		ObservableOperationItem item2 = new ObservableOperationItem(item);
		if (SelectedItem == null)
		{
			Items.Add(item2);
		}
		else
		{
			SelectedItem.Children.Add(item2);
		}
	}

	private (IList<ObservableOperationItem> collection, int index) mJsL7cbepEq(ObservableOperationItem observableOperationItem_1, IList<ObservableOperationItem> ilist_0)
	{
		int num = ilist_0.IndexOf(observableOperationItem_1);
		if (num >= 0)
		{
			return (collection: ilist_0, index: num);
		}
		foreach (ObservableOperationItem item in ilist_0)
		{
			if (item.Children != null)
			{
				(IList<ObservableOperationItem>, int) result = mJsL7cbepEq(observableOperationItem_1, item.Children);
				if (result.Item2 >= 0)
				{
					return result;
				}
			}
		}
		return (collection: null, index: -1);
	}

	public void DeleteSelectedItem()
	{
		if (SelectedItem != null)
		{
			(IList<ObservableOperationItem>, int) tuple = mJsL7cbepEq(SelectedItem, Items);
			if (tuple.Item1 == null)
			{
				Items.Remove(SelectedItem);
			}
			else
			{
				tuple.Item1.RemoveAt(tuple.Item2);
			}
		}
	}

	public string GetIndentTextData()
	{
		return CommonOperationItem.ToIndentString(GetItems(), FmRL7VGfJEL);
	}

	public string GetJsonTextData()
	{
		return Items.ToJson(true);
	}

	public IList<CommonOperationItem> GetItems()
	{
		return Items.Select(_003C_003Ec.EAISDlfxwTp ?? (_003C_003Ec.EAISDlfxwTp = _003C_003Ec.BuQSDU99pMs.gMHSDFwBda2)).ToList();
	}

	internal static bool wDrnNoF0YN0vnvmU2ekA()
	{
		return WnlOPyF05xj5uvH09ymk == null;
	}
}
