using System.Collections.Generic;
using System.Runtime.CompilerServices;
using pqbejBAeefDNBsawE5C;
using Quicker.Public.Actions;

namespace Quicker.Modules.ExpressionTester;

internal class VariableOperation
{
	[CompilerGenerated]
	private VarType rD8UnbOfkr;

	[CompilerGenerated]
	private string JBIU4nxTpL;

	[CompilerGenerated]
	private string t59U5HvGIJ;

	[CompilerGenerated]
	private string nyrUD4g5iI;

	[CompilerGenerated]
	private IList<z1Zs1sAbPOMnx22hak7> jCrUdq7RBO;

	[CompilerGenerated]
	private int uHXUo5dWUy;

	[CompilerGenerated]
	private VarType Qg1UTqfpV1;

	public static readonly IList<VariableOperation> d6lUMXMwC2;

	internal static VariableOperation Mjsu1XQVc5DeQO4bhelJ;

	public string Title
	{
		[CompilerGenerated]
		get
		{
			return JBIU4nxTpL;
		}
		[CompilerGenerated]
		set
		{
			JBIU4nxTpL = value;
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return t59U5HvGIJ;
		}
		[CompilerGenerated]
		set
		{
			t59U5HvGIJ = value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public VarType DkfUYr612m()
	{
		return rD8UnbOfkr;
	}

	[SpecialName]
	[CompilerGenerated]
	public void nWLUImr91E(VarType varType_2)
	{
		rD8UnbOfkr = varType_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public string hFSU1udfpg()
	{
		return nyrUD4g5iI;
	}

	[SpecialName]
	[CompilerGenerated]
	public void AmOUbTYttm(string string_3)
	{
		nyrUD4g5iI = string_3;
	}

	[SpecialName]
	[CompilerGenerated]
	public IList<z1Zs1sAbPOMnx22hak7> E32UXMkvKi()
	{
		return jCrUdq7RBO;
	}

	[SpecialName]
	[CompilerGenerated]
	public void KIJUmlQSar(IList<z1Zs1sAbPOMnx22hak7> ilist_2)
	{
		jCrUdq7RBO = ilist_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public int gBsUxpECsN()
	{
		return uHXUo5dWUy;
	}

	[SpecialName]
	[CompilerGenerated]
	public void HV4UrpKIvO(int int_1)
	{
		uHXUo5dWUy = int_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public VarType agcUBy7d3P()
	{
		return Qg1UTqfpV1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void ULDUQTiZVu(VarType varType_2)
	{
		Qg1UTqfpV1 = varType_2;
	}

	static VariableOperation()
	{
		d6lUMXMwC2 = new List<VariableOperation>();
		pvIUZ4gSuj();
		VU7UVyrjBa();
		bx8UqqqtiO();
		ElcUcmUmIm();
		KB6UR4wJi8();
		rXXU7aGQ3k();
		VNuU9Qc70G();
	}

	private static void rXXU7aGQ3k()
	{
		QDsUevU67o(VarType.Image, VarType.Boolean, "为空", "图片变量是否为空", "%% == null");
		QDsUevU67o(VarType.Image, VarType.Boolean, "不为空", "图片变量是否不为空", "%% != null");
		QDsUevU67o(VarType.Image, VarType.Boolean, "宽度大于高度", "图片宽度大于高度", "%%.Width > %%.Height");
	}

	private static void KB6UR4wJi8()
	{
		QDsUevU67o(VarType.Boolean, VarType.Boolean, "为真", "布尔变量的值为真", "%% == true");
		QDsUevU67o(VarType.Boolean, VarType.Boolean, "为假", "布尔变量的值为假", "%% == false");
	}

	private static void bx8UqqqtiO()
	{
		CsTUhtkOPg(VarType.List, VarType.Boolean, "包含", "是否包含指定内容的项", "%%.Contains(%p1%)", "项", "aaa");
		QDsUevU67o(VarType.List, VarType.Boolean, "是否为空", "是否是空列表", "%%.Count == 0");
		CsTUhtkOPg(VarType.List, VarType.Boolean, "条目个数大于", "", "%%.Count > %p1%", "个数数字", "10", VarType.Integer);
		CsTUhtkOPg(VarType.List, VarType.Boolean, "条目个数小于", "", "%%.Count < %p1%", "个数数字", "10", VarType.Integer);
		CsTUhtkOPg(VarType.List, VarType.Boolean, "条目个数等于", "", "%%.Count == %p1%", "个数数字", "10", VarType.Integer);
	}

	private static void ElcUcmUmIm()
	{
		CsTUhtkOPg(VarType.Dict, VarType.Boolean, "包含键", "是否包含指定的Key", "%%.ContainsKey(%p1%)", "键", "aaa");
		CsTUhtkOPg(VarType.Dict, VarType.Boolean, "包含值", "是否包含指定的Value", "%%.ContainsValue(%p1%)", "值", "aaa");
		QDsUevU67o(VarType.Dict, VarType.Boolean, "为空", "是否是空列表", "%%.Count == 0");
	}

	private static void VU7UVyrjBa()
	{
		QDsUevU67o(VarType.Text, VarType.Boolean, "为空", "文本是否为空", "String.IsNullOrEmpty(%%)");
		QDsUevU67o(VarType.Text, VarType.Boolean, "为空或空白", "是否为空或空白", "String.IsNullOrWhiteSpace(%%)");
		CsTUhtkOPg(VarType.Text, VarType.Boolean, "包含（区分大小写）", "是否包含指定内容", "%%.Contains(%p1%)", "被包含的内容", "aaa");
		CsTUhtkOPg(VarType.Text, VarType.Boolean, "包含（不区分大小写）", "是否包含指定内容", "%%.IndexOf(%p1%, StringComparison.OrdinalIgnoreCase) >= 0", "被包含的内容", "aaa");
		CsTUhtkOPg(VarType.Text, VarType.Boolean, "等于（区分大小写）", "", "String.Equals(%%, %p1%)", "比较的内容", "aaa");
		CsTUhtkOPg(VarType.Text, VarType.Boolean, "等于（不区分大小写）", "", "String.Equals(%%, %p1%, StringComparison.OrdinalIgnoreCase)", "比较的内容", "aaa");
		CsTUhtkOPg(VarType.Text, VarType.Boolean, "以指定内容开始（区分大小写）", "", "%%.StartsWith(%p1%)", "比较的内容", "aaa");
		CsTUhtkOPg(VarType.Text, VarType.Boolean, "以指定内容开始（不区分大小写）", "", "%%.StartsWith(%p1%, StringComparison.OrdinalIgnoreCase)", "比较的内容", "aaa");
		CsTUhtkOPg(VarType.Text, VarType.Boolean, "以指定内容结尾（区分大小写）", "", "%%.EndsWith(%p1%)", "比较的内容", "aaa");
		int num = 0;
		if (Mjsu1XQVc5DeQO4bhelJ != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		CsTUhtkOPg(VarType.Text, VarType.Boolean, "以指定内容结尾（不区分大小写）", "", "%%.EndsWith(%p1%, StringComparison.OrdinalIgnoreCase)", "比较的内容", "aaa");
		CsTUhtkOPg(VarType.Text, VarType.Boolean, "长度大于", "", "%%.Length > %p1%", "长度数字", "10", VarType.Integer);
		CsTUhtkOPg(VarType.Text, VarType.Boolean, "长度小于", "", "%%.Length < %p1%", "长度数字", "10", VarType.Integer);
		CsTUhtkOPg(VarType.Text, VarType.Boolean, "长度等于", "", "%%.Length == %p1%", "长度等于", "10", VarType.Integer);
	}

	private static void pvIUZ4gSuj()
	{
		foreach (KeyValuePair<string, string> item in (IEnumerable<KeyValuePair<string, string>>)new Dictionary<string, string>
		{
			{ ">", "大于" },
			{ ">=", "大于等于" },
			{ "<", "小于" },
			{ "<=", "小于等于" },
			{ "==", "等于" },
			{ "!=", "不等于" }
		})
		{
			CsTUhtkOPg(VarType.Integer, VarType.Boolean, item.Key, item.Value, "%% " + item.Key + " %p1%", "被比较的数", "0", VarType.Number);
			CsTUhtkOPg(VarType.Number, VarType.Boolean, item.Key, item.Value, "%% " + item.Key + " %p1%", "被比较的数", "0", VarType.Number);
		}
	}

	private static void VNuU9Qc70G()
	{
		foreach (KeyValuePair<string, string> item in (IEnumerable<KeyValuePair<string, string>>)new Dictionary<string, string>
		{
			{ ">", "大于" },
			{ "<", "小于" }
		})
		{
			CsTUhtkOPg(VarType.DateTime, VarType.Boolean, item.Key, item.Value, "%% " + item.Key + " %p1%", "被比较的数", "DateTime.Now", VarType.DateTime);
		}
	}

	private static void CsTUhtkOPg(VarType varType_2, VarType varType_3, string string_3, string string_4, string string_5, string string_6, string string_7, VarType varType_4 = VarType.Text)
	{
		VariableOperation variableOperation = new VariableOperation();
		variableOperation.nWLUImr91E(varType_2);
		variableOperation.Title = string_3;
		variableOperation.Description = string_4;
		variableOperation.AmOUbTYttm(string_5);
		List<z1Zs1sAbPOMnx22hak7> list = new List<z1Zs1sAbPOMnx22hak7>();
		z1Zs1sAbPOMnx22hak7 z1Zs1sAbPOMnx22hak = new z1Zs1sAbPOMnx22hak7();
		z1Zs1sAbPOMnx22hak.Key = "p1";
		z1Zs1sAbPOMnx22hak.Title = string_6;
		z1Zs1sAbPOMnx22hak.ey9UfnHKFY(new List<VarType> { varType_4 });
		z1Zs1sAbPOMnx22hak.SampleValue = string_7;
		list.Add(z1Zs1sAbPOMnx22hak);
		variableOperation.KIJUmlQSar(list);
		variableOperation.HV4UrpKIvO(1);
		variableOperation.ULDUQTiZVu(varType_3);
		VariableOperation variableOperation2 = variableOperation;
		if (variableOperation2.E32UXMkvKi().Count > 0 && variableOperation2.E32UXMkvKi()[0].kiOU3S23fe()[0] == VarType.Number)
		{
			variableOperation2.E32UXMkvKi()[0].kiOU3S23fe().Add(VarType.Integer);
		}
		d6lUMXMwC2.Add(variableOperation2);
	}

	private static void QDsUevU67o(VarType varType_2, VarType varType_3, string string_3, string string_4, string string_5)
	{
		IList<VariableOperation> list = d6lUMXMwC2;
		VariableOperation variableOperation = new VariableOperation();
		variableOperation.nWLUImr91E(varType_2);
		variableOperation.Title = string_3;
		variableOperation.Description = string_4;
		variableOperation.AmOUbTYttm(string_5);
		variableOperation.KIJUmlQSar(null);
		variableOperation.HV4UrpKIvO(1);
		variableOperation.ULDUQTiZVu(varType_3);
		list.Add(variableOperation);
	}

	internal static bool GJejenQVWSSAvrnivhdR()
	{
		return Mjsu1XQVc5DeQO4bhelJ == null;
	}
}
