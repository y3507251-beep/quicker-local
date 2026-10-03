using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Quicker.Public.Actions;
using Quicker.Utilities._3rd;
using Quicker.View.X;

namespace Quicker.View.Controls;

public class VarTypeSelector : ComboBox, IComponentConnector
{
	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass4_0
	{
		public VarType B29Si7sRZ8P;

		private static _003C_003Ec__DisplayClass4_0 vk8LAxyyyWb9FDPXmQYn;

		internal bool rvDSialE08l(VarTypeItem x)
		{
			return x.VarType == B29Si7sRZ8P;
		}

		static _003C_003Ec__DisplayClass4_0()
		{
		}

		internal static bool AMmMBByyp1scj7UYZkKv()
		{
			return vk8LAxyyyWb9FDPXmQYn == null;
		}

		internal static void vGT71Iyy2G0Bh6SnW7TS()
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass5_0
	{
		public VarType[] R2VSiqgEb4i;

		internal static _003C_003Ec__DisplayClass5_0 HSUZyMyyAmKcPOQC8Xwi;

		internal bool QFXSiR5VyIH(VarTypeItem x)
		{
			_003C_003Ec__DisplayClass5_1 _003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_1
			{
				x = x
			};
			return R2VSiqgEb4i.All(_003C_003Ec__DisplayClass5_.pO3SicIRqxC);
		}

		internal static bool I1eQK2yynNcoaaKnvKxv()
		{
			return HSUZyMyyAmKcPOQC8Xwi == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass5_1
	{
		public VarTypeItem x;

		private static _003C_003Ec__DisplayClass5_1 YgasRLyyjFvudLSZcI7A;

		internal bool pO3SicIRqxC(VarType tp)
		{
			return tp != x.VarType;
		}

		internal static bool RXqHFyyyDvMmia0KdbCS()
		{
			return YgasRLyyjFvudLSZcI7A == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass6_0
	{
		public VarType[] UYLSiZPp35c;

		internal static _003C_003Ec__DisplayClass6_0 ueCMt6yyEeCk6XocIouS;

		internal bool HdBSiVUxWS5(VarTypeItem x)
		{
			return UYLSiZPp35c.Contains(x.VarType);
		}

		internal static bool Md9cEvyyGHb4cwogPwwe()
		{
			return ueCMt6yyEeCk6XocIouS == null;
		}
	}

	private readonly SmartCollection<VarTypeItem> HGHLp2pqJR2 = new SmartCollection<VarTypeItem>();

	private bool jkSLpuQ4Km3;

	private static VarTypeSelector JZtgjAFoSLdVdtSOBkxO;

	public VarType SelectedVarType
	{
		get
		{
			if (base.SelectedItem != null)
			{
				return ((VarTypeItem)base.SelectedItem).VarType;
			}
			return VarType.Any;
		}
		set
		{
			_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
			_003C_003Ec__DisplayClass4_.B29Si7sRZ8P = value;
			base.SelectedItem = HGHLp2pqJR2.FirstOrDefault(_003C_003Ec__DisplayClass4_.rvDSialE08l);
		}
	}

	public VarTypeSelector()
	{
		F9PLpScluFw();
		InitializeComponent();
		base.ItemsSource = HGHLp2pqJR2;
	}

	public void RemoveVarTypes(params VarType[] types)
	{
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
		_003C_003Ec__DisplayClass5_.R2VSiqgEb4i = types;
		HGHLp2pqJR2.Reset(HGHLp2pqJR2.Where(_003C_003Ec__DisplayClass5_.QFXSiR5VyIH));
	}

	public void SetAllowedTypes(params VarType[] types)
	{
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
		_003C_003Ec__DisplayClass6_.UYLSiZPp35c = types;
		List<VarTypeItem> range = HGHLp2pqJR2.Where(_003C_003Ec__DisplayClass6_.HdBSiVUxWS5).ToList();
		HGHLp2pqJR2.Reset(range);
	}

	private void F9PLpScluFw()
	{
		HGHLp2pqJR2.Add(new VarTypeItem
		{
			VarType = VarType.Text,
			Name = "文本",
			Description = "文本字符串"
		});
		HGHLp2pqJR2.Add(new VarTypeItem
		{
			VarType = VarType.Image,
			Name = "图片",
			Description = "图片内容"
		});
		HGHLp2pqJR2.Add(new VarTypeItem
		{
			VarType = VarType.Boolean,
			Name = "布尔",
			Description = "布尔（True/False）类型"
		});
		HGHLp2pqJR2.Add(new VarTypeItem
		{
			VarType = VarType.Number,
			Name = "数字",
			Description = "数字类型(小数数字)"
		});
		HGHLp2pqJR2.Add(new VarTypeItem
		{
			VarType = VarType.Integer,
			Name = "数字(整数)",
			Description = "数字类型(整数数字)"
		});
		HGHLp2pqJR2.Add(new VarTypeItem
		{
			VarType = VarType.DateTime,
			Name = "日期时间",
			Description = "日期和时间类型"
		});
		HGHLp2pqJR2.Add(new VarTypeItem
		{
			VarType = VarType.List,
			Name = "列表",
			Description = "文本列表，如选中的多个文件等"
		});
		HGHLp2pqJR2.Add(new VarTypeItem
		{
			VarType = VarType.Dict,
			Name = "词典",
			Description = "键-值对类型"
		});
		int num = 0;
		if (!wl2tjpFow2i2C00Q3wcJ())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		HGHLp2pqJR2.Add(new VarTypeItem
		{
			VarType = VarType.Table,
			Name = "表格",
			Description = "二维数据表(DataTable)"
		});
		HGHLp2pqJR2.Add(new VarTypeItem
		{
			VarType = VarType.Any,
			Name = "动态对象",
			Description = "任意的C#对象"
		});
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!jkSLpuQ4Km3)
		{
			jkSLpuQ4Km3 = true;
			Uri resourceLocator = new Uri("/Quicker;component/view/controls/vartypeselector.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		jkSLpuQ4Km3 = true;
	}

	internal static bool wl2tjpFow2i2C00Q3wcJ()
	{
		return JZtgjAFoSLdVdtSOBkxO == null;
	}
}
