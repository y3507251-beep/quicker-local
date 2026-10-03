using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Newtonsoft.Json;
using Quicker.Domain.Actions.X;
using Quicker.Domain.Actions.X.BuiltinRunners;
using Quicker.Domain.Actions.X.BuiltinRunners.Misc;
using Quicker.Domain.Actions.X.StepRunners;
using Quicker.Domain.Actions.X.Storage;
using Quicker.Properties;
using Quicker.Public.Extensions;
using Quicker.Utilities._3rd;

namespace Quicker.View.X.Nodes;

public class StepNode : INotifyPropertyChanged, ICloneable
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec V3XSUGtx0b7;

		public static Func<ActionStep, StepNode> ugjSUsH8h6o;

		public static Func<StepNode, ActionStep> GpWSUHHON9U;

		public static Func<StepNode, ActionStep> FAtSU11fx9j;

		public static Func<ActionStep, StepNode> eJkSUbH2Tst;

		public static Func<StepNode, ActionStep> WN1SU6TIeI7;

		public static Func<StepNode, ActionStep> KSDSUXvsd7c;

		public static Func<StepNode, ActionStep> tnISUmAf3xm;

		public static Func<StepNode, ActionStep> W20SUK0HdKs;

		private static _003C_003Ec hhlh0CyF1wj7FcPZbQRU;

		static _003C_003Ec()
		{
			V3XSUGtx0b7 = new _003C_003Ec();
		}

		internal StepNode We5SUZLIav0(ActionStep x)
		{
			return x.CreateNode();
		}

		internal ActionStep Hp0SU9dP6Y9(StepNode x)
		{
			return x.Step;
		}

		internal ActionStep IxbSUh1ly8u(StepNode x)
		{
			return x.Step;
		}

		internal StepNode hdqSUeTgmAZ(ActionStep x)
		{
			return x.CreateNode();
		}

		internal ActionStep wmqSUYhU5Ii(StepNode x)
		{
			return x.Step;
		}

		internal ActionStep QVQSUIkNSUt(StepNode x)
		{
			return x.Step;
		}

		internal ActionStep leLSUWRXUvx(StepNode x)
		{
			return x.Step;
		}

		internal ActionStep cMySUkfbis0(StepNode x)
		{
			return x.Step;
		}

		internal static bool BOdanLyFKIwtxUrbg82s()
		{
			return hhlh0CyF1wj7FcPZbQRU == null;
		}
	}

	private ActionStep gqiLbNFk83e;

	private bool HZDLbJoDvpX;

	private string vIjLb0R213K;

	private bool TRnLbCpAxnk;

	private string B80LbPAkWTr;

	[CompilerGenerated]
	private FullyObservableCollection<StepNode> n1fLbESlpTe;

	[CompilerGenerated]
	private FullyObservableCollection<StepNode> fdNLbyBKemY;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	private static StepNode C5gpWyFNoPr0KlINVlXE;

	public FullyObservableCollection<StepNode> IfSteps
	{
		[CompilerGenerated]
		get
		{
			return n1fLbESlpTe;
		}
		[CompilerGenerated]
		private set
		{
			n1fLbESlpTe = value;
		}
	}

	public FullyObservableCollection<StepNode> ElseSteps
	{
		[CompilerGenerated]
		get
		{
			return fdNLbyBKemY;
		}
		[CompilerGenerated]
		private set
		{
			fdNLbyBKemY = value;
		}
	}

	public ActionStep Step => gqiLbNFk83e;

	public string StepInfo
	{
		get
		{
			return vIjLb0R213K;
		}
		private set
		{
			vIjLb0R213K = value;
			OnPropertyChanged("StepInfo");
		}
	}

	public IStepRunner Runner => StepRunnerRegistry.GetRunner(gqiLbNFk83e.StepRunnerKey);

	public string RunnerKey => Runner.Key;

	public string RunnerName
	{
		get
		{
			return B80LbPAkWTr;
		}
		set
		{
			B80LbPAkWTr = value;
			OnPropertyChanged("RunnerName");
		}
	}

	public bool Disabled
	{
		get
		{
			return gqiLbNFk83e.Disabled;
		}
		set
		{
			if (gqiLbNFk83e.Disabled != value)
			{
				gqiLbNFk83e.Disabled = value;
				OnPropertyChanged("Disabled");
				WW0L1fJRnhu();
			}
		}
	}

	public int DelayMs
	{
		get
		{
			return gqiLbNFk83e.DelayMs;
		}
		set
		{
			if (gqiLbNFk83e.DelayMs != value)
			{
				gqiLbNFk83e.DelayMs = value;
				OnPropertyChanged("DelayMs");
				WW0L1fJRnhu();
			}
		}
	}

	public bool Collapsed
	{
		get
		{
			return gqiLbNFk83e.Collapsed;
		}
		set
		{
			if (gqiLbNFk83e.Collapsed != value)
			{
				gqiLbNFk83e.Collapsed = value;
				OnPropertyChanged("Collapsed");
				WW0L1fJRnhu();
			}
		}
	}

	public bool Highlighted
	{
		get
		{
			return HZDLbJoDvpX;
		}
		set
		{
			if (HZDLbJoDvpX != value)
			{
				HZDLbJoDvpX = value;
				OnPropertyChanged("Highlighted");
			}
		}
	}

	public bool HighlightedInChildren
	{
		get
		{
			return TRnLbCpAxnk;
		}
		set
		{
			if (TRnLbCpAxnk != value)
			{
				TRnLbCpAxnk = value;
				OnPropertyChanged("HighlightedInChildren");
			}
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
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

	public StepNode(ActionStep step)
	{
		gqiLbNFk83e = step;
		gB1L1zauxKJ();
		ppRLbwysyA7();
	}

	private void WW0L1fJRnhu()
	{
		OnPropertyChanged("Step");
	}

	private void gB1L1zauxKJ()
	{
		if (IfSteps != null || ElseSteps != null)
		{
			return;
		}
		if (Runner == null)
		{
			throw new InvalidOperationException("不支持的步骤类型：" + gqiLbNFk83e.StepRunnerKey + "，请升级Quicker版本。");
		}
		if (Runner.StepType.IsEither(StepType.If, StepType.Loop))
		{
			IfSteps = new FullyObservableCollection<StepNode>();
			if (gqiLbNFk83e.IfSteps != null)
			{
				IfSteps.Reset(gqiLbNFk83e.IfSteps.Select(_003C_003Ec.ugjSUsH8h6o ?? (_003C_003Ec.ugjSUsH8h6o = _003C_003Ec.V3XSUGtx0b7.We5SUZLIav0)));
			}
			IfSteps.CollectionChanged += XupLbtRtodP;
			IfSteps.ItemPropertyChanged += NIXLbg5q3pN;
		}
		if (Runner.StepType != StepType.If)
		{
			return;
		}
		ElseSteps = new FullyObservableCollection<StepNode>();
		if (gqiLbNFk83e.ElseSteps.HasData())
		{
			ElseSteps.Reset(gqiLbNFk83e.ElseSteps.Select(_003C_003Ec.eJkSUbH2Tst ?? (_003C_003Ec.eJkSUbH2Tst = _003C_003Ec.V3XSUGtx0b7.hdqSUeTgmAZ)));
			if (!fs6JEqFNfegKghGHvn3J())
			{
				switch (0)
				{
				}
			}
		}
		ElseSteps.CollectionChanged += j3ZLbLxLAna;
		ElseSteps.ItemPropertyChanged += JGaLbvHN41V;
	}

	public void UpdateNode(ActionStep step)
	{
		int num = 1;
		while (true)
		{
			ActionStep actionStep = gqiLbNFk83e;
			int num2 = 0;
			if (C5gpWyFNoPr0KlINVlXE != null)
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			gqiLbNFk83e = step;
			if (IfSteps.HasData())
			{
				gqiLbNFk83e.IfSteps = IfSteps.Select(_003C_003Ec.tnISUmAf3xm ?? (_003C_003Ec.tnISUmAf3xm = _003C_003Ec.V3XSUGtx0b7.leLSUWRXUvx)).ToList();
			}
			if (ElseSteps.HasData())
			{
				gqiLbNFk83e.ElseSteps = ElseSteps.Select(_003C_003Ec.W20SUK0HdKs ?? (_003C_003Ec.W20SUK0HdKs = _003C_003Ec.V3XSUGtx0b7.cMySUkfbis0)).ToList();
			}
			gqiLbNFk83e.Collapsed = actionStep.Collapsed;
			ppRLbwysyA7();
			OnPropertyChanged("Disabled");
			OnPropertyChanged("DelayMs");
			WW0L1fJRnhu();
			return;
		}
	}

	private void ppRLbwysyA7()
	{
		if (gqiLbNFk83e == null)
		{
			return;
		}
		RunnerName = Runner.Name;
		if (Runner is SubProgramStep)
		{
			(string, string) subProgramInfo = SubProgramStep.GetSubProgramInfo(Step);
			RunnerName = subProgramInfo.Item1 ?? "";
			StepInfo = subProgramInfo.Item2 ?? "";
		}
		if (!string.IsNullOrWhiteSpace(Step.Note))
		{
			StepInfo = Step.Note;
		}
		else if (Runner is CommentStep)
		{
			StepInfo = Runner.GetSummary(Step);
		}
		else
		{
			if (Runner is SubProgramStep)
			{
				return;
			}
			StepInfo = Runner.GetSummary(Step).ToShortString(100)?.Replace('\n', ' ').Replace('\r', ' ');
			if (C5gpWyFNoPr0KlINVlXE != null)
			{
				switch (0)
				{
				}
			}
		}
	}

	[NotifyPropertyChangedInvocator]
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		this.m_PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	public object Clone()
	{
		return new StepNode(JsonConvert.DeserializeObject<ActionStep>(JsonConvert.SerializeObject(gqiLbNFk83e)));
	}

	public void NotifyStepDataChange()
	{
		ppRLbwysyA7();
		OnPropertyChanged("Step");
	}

	public bool DoFilter(string keyWord, int stepIndex, string searchPath, string parentPath)
	{
        int num2 = default;
        bool flag2 = default;
		string text = null;
		bool flag = false;
		if (string.IsNullOrEmpty(keyWord) && string.IsNullOrEmpty(searchPath))
		{
			flag = false;
			goto IL_009e;
		}
		if (searchPath != null && parentPath != null)
		{
			text = ((!string.IsNullOrEmpty(parentPath)) ? $"{parentPath}.{stepIndex}" : $"{stepIndex}");
			if ((flag = string.Equals(text, searchPath, StringComparison.Ordinal)) || !searchPath.StartsWith(text + ".", StringComparison.Ordinal))
			{
				text = null;
			}
		}
		flag = flag || XActionHelper.IsMatchFilter(Step, keyWord);
		int num = 1;
		if (C5gpWyFNoPr0KlINVlXE != null)
		{
			goto IL_00b3;
		}
		goto IL_00d7;
		IL_012e:
		flag2 = default(bool);
		num2 = default(int);
		if (ElseSteps.HasData())
		{
			foreach (StepNode elseStep in ElseSteps)
			{
				flag2 = elseStep.DoFilter(keyWord, num2, searchPath, text) || flag2;
				num2++;
			}
		}
		HighlightedInChildren = flag2;
		if (!Highlighted)
		{
			return HighlightedInChildren;
		}
		return true;
		IL_00ea:
		foreach (StepNode ifStep in IfSteps)
		{
			flag2 = ifStep.DoFilter(keyWord, num2, searchPath, text) || flag2;
			num2++;
		}
		goto IL_012e;
		IL_009e:
		Highlighted = flag;
		num = 0;
		if (fs6JEqFNfegKghGHvn3J())
		{
			goto IL_00b3;
		}
		goto IL_00d7;
		IL_00d7:
		switch (num)
		{
		case 1:
			break;
		default:
			goto IL_00b3;
		case 2:
			goto IL_00ea;
		}
		goto IL_009e;
		IL_00b3:
		flag2 = false;
		num2 = 0;
		if (IfSteps.HasData())
		{
			num = 2;
			if (C5gpWyFNoPr0KlINVlXE != null)
			{
				int num3 = default(int);
				num = num3;
			}
			goto IL_00d7;
		}
		goto IL_012e;
	}

	public void ExpandOrCollapse(bool isCollapsed)
	{
		if (!Runner.StepType.IsEither(StepType.Loop, StepType.If))
		{
			return;
		}
		Collapsed = isCollapsed;
		if (IfSteps.HasData())
		{
			foreach (StepNode ifStep in IfSteps)
			{
				ifStep.ExpandOrCollapse(isCollapsed);
			}
		}
		if (!ElseSteps.HasData())
		{
			return;
		}
		foreach (StepNode elseStep in ElseSteps)
		{
			elseStep.ExpandOrCollapse(isCollapsed);
		}
	}

	public void ExpandOrCollapseByHighlight()
	{
		if (!Runner.StepType.IsEither(StepType.Loop, StepType.If))
		{
			return;
		}
		Collapsed = !Highlighted && !HighlightedInChildren;
		if (IfSteps.HasData())
		{
			foreach (StepNode ifStep in IfSteps)
			{
				ifStep.ExpandOrCollapseByHighlight();
			}
		}
		if (!ElseSteps.HasData())
		{
			return;
		}
		foreach (StepNode elseStep in ElseSteps)
		{
			elseStep.ExpandOrCollapseByHighlight();
		}
	}

	[CompilerGenerated]
	private void XupLbtRtodP(object sender, NotifyCollectionChangedEventArgs e)
	{
		gqiLbNFk83e.IfSteps = IfSteps.Select(_003C_003Ec.GpWSUHHON9U ?? (_003C_003Ec.GpWSUHHON9U = _003C_003Ec.V3XSUGtx0b7.Hp0SU9dP6Y9)).ToList();
		WW0L1fJRnhu();
	}

	[CompilerGenerated]
	private void NIXLbg5q3pN(object sender, ItemPropertyChangedEventArgs e)
	{
		if (e.PropertyName == "Step")
		{
			gqiLbNFk83e.IfSteps = IfSteps.Select(_003C_003Ec.FAtSU11fx9j ?? (_003C_003Ec.FAtSU11fx9j = _003C_003Ec.V3XSUGtx0b7.IxbSUh1ly8u)).ToList();
			WW0L1fJRnhu();
		}
	}

	[CompilerGenerated]
	private void j3ZLbLxLAna(object sender, NotifyCollectionChangedEventArgs e)
	{
		gqiLbNFk83e.ElseSteps = ElseSteps.Select(_003C_003Ec.WN1SU6TIeI7 ?? (_003C_003Ec.WN1SU6TIeI7 = _003C_003Ec.V3XSUGtx0b7.wmqSUYhU5Ii)).ToList();
		WW0L1fJRnhu();
	}

	[CompilerGenerated]
	private void JGaLbvHN41V(object sender, ItemPropertyChangedEventArgs e)
	{
		if (e.PropertyName == "Step")
		{
			gqiLbNFk83e.ElseSteps = ElseSteps.Select(_003C_003Ec.KSDSUXvsd7c ?? (_003C_003Ec.KSDSUXvsd7c = _003C_003Ec.V3XSUGtx0b7.QVQSUIkNSUt)).ToList();
			WW0L1fJRnhu();
		}
	}

	internal static bool fs6JEqFNfegKghGHvn3J()
	{
		return C5gpWyFNoPr0KlINVlXE == null;
	}
}
