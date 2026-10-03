using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using CbrphLANyKZlutR0O9C;
using CodeCompletionServer.Entities;
using ICSharpCode.AvalonEdit.CodeCompletion;
using Quicker.Public.Extensions;

namespace lpE7rGAgh7wj22W4qWU;

internal class aSdmBLAU9LVrSYKhpt4 : INotifyPropertyChanged, IOverloadProvider
{
	private readonly SignatureHelpResult WY4l4Ir6pk;

	private readonly IList<SignatureHelpItem> ALPl5GChAp;

	private int RT7lDJYnVA;

	private SignatureHelpItem? ojIld9dxDc;

	private object? BPTloQA0hd;

	private object? pqelTQxVdU;

	private string? sZOlM74FT9;

	[CompilerGenerated]
	private PropertyChangedEventHandler? m_PropertyChanged;

	private static aSdmBLAU9LVrSYKhpt4? lGiALYQVoP1gTF4wZ3eS;

	public int SelectedIndex
	{
		get
		{
			return RT7lDJYnVA;
		}
		set
		{
			if (jRBlBJu6pt(ref RT7lDJYnVA, value, "SelectedIndex"))
			{
				Refresh();
			}
		}
	}

	public int Count => ALPl5GChAp.Count;

	public string? CurrentIndexText
	{
		get
		{
			return sZOlM74FT9;
		}
		private set
		{
			jRBlBJu6pt(ref sZOlM74FT9, value, "CurrentIndexText");
		}
	}

	public object? CurrentHeader
	{
		get
		{
			return BPTloQA0hd;
		}
		private set
		{
			jRBlBJu6pt(ref BPTloQA0hd, value, "CurrentHeader");
		}
	}

	public object? CurrentContent
	{
		get
		{
			return pqelTQxVdU;
		}
		private set
		{
			jRBlBJu6pt(ref pqelTQxVdU, value, "CurrentContent");
		}
	}

	public event PropertyChangedEventHandler? PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	public aSdmBLAU9LVrSYKhpt4(SignatureHelpResult signatureHelpResult_1)
	{
		WY4l4Ir6pk = signatureHelpResult_1;
		ALPl5GChAp = signatureHelpResult_1.Items;
		if (signatureHelpResult_1.SelectedItemIndex.HasValue)
		{
			RT7lDJYnVA = signatureHelpResult_1.SelectedItemIndex.Value;
		}
	}

	public void Refresh()
	{
		ojIld9dxDc = ALPl5GChAp[RT7lDJYnVA];
		WrapPanel wrapPanel = new WrapPanel
		{
			Orientation = Orientation.Horizontal,
			Children = { (UIElement)ojIld9dxDc.PrefixDisplayParts.YqJlF3u8fw() }
		};
		StackPanel stackPanel = new StackPanel();
		if (ojIld9dxDc.DocumentTexts.HasData())
		{
			TextBlock textBlock = ojIld9dxDc.DocumentTexts.YqJlF3u8fw();
			if (zK3lrikkNZ(textBlock))
			{
				stackPanel.Children.Add(textBlock);
			}
		}
		int num;
		if (ojIld9dxDc?.Parameters != null)
		{
			num = 0;
			if (VEYTiwQVf70lxxwVdDfQ())
			{
				goto IL_00aa;
			}
			goto IL_00b7;
		}
		goto IL_00f7;
		IL_00b7:
		for (int i = 0; i < ojIld9dxDc.Parameters.Length; i++)
		{
			SignatureHelpParameter signatureHelpParameter_ = ojIld9dxDc.Parameters[i];
			aiplpP5y13(ojIld9dxDc, i, signatureHelpParameter_, wrapPanel, stackPanel);
		}
		goto IL_00f7;
		IL_00aa:
		switch (num)
		{
		case 1:
			CurrentHeader = wrapPanel;
			CurrentContent = stackPanel;
			CurrentIndexText = $" {RT7lDJYnVA + 1} of {ALPl5GChAp.Count} ";
			return;
		}
		goto IL_00b7;
		IL_00f7:
		wrapPanel.Children.Add(ojIld9dxDc.SuffixDisplayParts.YqJlF3u8fw());
		num = 1;
		if (lGiALYQVoP1gTF4wZ3eS != null)
		{
			int num2 = default(int);
			num = num2;
		}
		goto IL_00aa;
	}

	private bool zK3lrikkNZ(TextBlock textBlock_0)
	{
		if (textBlock_0 == null)
		{
			return false;
		}
		return textBlock_0.Inlines.Count > 0;
	}

	private void aiplpP5y13(SignatureHelpItem signatureHelpItem_1, int int_1, SignatureHelpParameter signatureHelpParameter_0, Panel panel_0, Panel panel_1)
	{
		bool flag = WY4l4Ir6pk.ArgumentIndex == int_1;
		panel_0.Children.Add(signatureHelpParameter_0.DisplayParts.YqJlF3u8fw(flag));
		if (int_1 != signatureHelpItem_1.Parameters.Length - 1)
		{
			panel_0.Children.Add(signatureHelpItem_1.SeparatorDisplayParts.YqJlF3u8fw());
		}
		if (!flag || !signatureHelpParameter_0.DocumentTexts.HasData())
		{
			return;
		}
		TextBlock textBlock = signatureHelpParameter_0.DocumentTexts.YqJlF3u8fw();
		if (zK3lrikkNZ(textBlock))
		{
			panel_1.Children.Add(new WrapPanel
			{
				Orientation = Orientation.Horizontal,
				Children = 
				{
					(UIElement)new TextBlock
					{
						Text = signatureHelpParameter_0.Name + ": ",
						FontWeight = FontWeights.Bold
					},
					(UIElement)textBlock
				}
			});
			int num = 0;
			if (!VEYTiwQVf70lxxwVdDfQ())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
	}

	protected bool jRBlBJu6pt<xrwOUcAVwGl9XCKgafj>(ref xrwOUcAVwGl9XCKgafj gparam_0, xrwOUcAVwGl9XCKgafj KsEZeNAFBbqUALxLqFe, [CallerMemberName] string? propertyName = null)
	{
		if (!EqualityComparer<xrwOUcAVwGl9XCKgafj>.Default.Equals(gparam_0, KsEZeNAFBbqUALxLqFe))
		{
			gparam_0 = KsEZeNAFBbqUALxLqFe;
			OnPropertyChanged(propertyName);
			return true;
		}
		return false;
	}

	protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
	{
		this.m_PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	internal static bool VEYTiwQVf70lxxwVdDfQ()
	{
		return lGiALYQVoP1gTF4wZ3eS == null;
	}
}
