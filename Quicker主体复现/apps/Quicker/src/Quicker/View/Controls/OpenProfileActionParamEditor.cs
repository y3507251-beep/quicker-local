using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;
using Quicker.Common;
using Quicker.Domain;

namespace Quicker.View.Controls;

public class OpenProfileActionParamEditor : BaseActionParamEditor, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec lWaS3elN8YK;

		public static Func<ActionProfile, ProfileConfigItem> GXXS3Y1bwSU;

		internal static _003C_003Ec i1nmPwyX93L25BrwsD9s;

		static _003C_003Ec()
		{
			lWaS3elN8YK = new _003C_003Ec();
		}

		internal ProfileConfigItem vI3S3he7pHR(ActionProfile x)
		{
			return new ProfileConfigItem(x);
		}

		internal static bool kRDHrVyXLBjwkishYs8s()
		{
			return i1nmPwyX93L25BrwsD9s == null;
		}
	}

	[CompilerGenerated]
	internal sealed class _003C_003Ec__DisplayClass5_0
	{
		public ActionItem anxS3Wf51hD;

		private static _003C_003Ec__DisplayClass5_0 tMCwkEyXo1mmMB9Wt7Mc;

		internal bool VfCS3IH15Zc(ProfileConfigItem f)
		{
			if (!(f.Id == anxS3Wf51hD.Data))
			{
				return f.Name == anxS3Wf51hD.Data;
			}
			return true;
		}

		internal static bool LcZfSQyXfQGD6hlo027Y()
		{
			return tMCwkEyXo1mmMB9Wt7Mc == null;
		}
	}

	private readonly ICollection<ProfileConfigItem> CWuLnFtT2qR;

	private ActionItem JwjLnUTVZcf;

	private bool XXxLnlsg4S2;

	internal ComboBox ComboBoxProfiles;

	private bool fCuLniJZhqi;

	internal static OpenProfileActionParamEditor SZowJiFidPHb75Objs0R;

	public OpenProfileActionParamEditor()
	{
		InitializeComponent();
		base.Loaded += vnALnAA4r1X;
		List<ProfileConfigItem> list = (List<ProfileConfigItem>)(CWuLnFtT2qR = AppState.B2BtasP38AU().GetProfiles(true).Select(_003C_003Ec.GXXS3Y1bwSU ?? (_003C_003Ec.GXXS3Y1bwSU = _003C_003Ec.lWaS3elN8YK.vI3S3he7pHR))
			.ToList());
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			foreach (ProfileConfigItem item2 in list)
			{
				if (!dictionary.ContainsKey(item2.ExeFile) && item2.ExeFile != "_global")
				{
					dictionary.Add(item2.ExeFile, item2.ExeDisplayName);
				}
			}
			foreach (KeyValuePair<string, string> item3 in dictionary)
			{
				ProfileConfigItem item = new ProfileConfigItem
				{
					Id = "exe:" + item3.Key,
					Name = "【全部】" + item3.Value,
					DisplayName = "【" + item3.Key + "】的所有动作页",
					ExeFile = item3.Key,
					ExeDisplayName = item3.Value,
					ListOrder = -100
				};
				CWuLnFtT2qR.Add(item);
			}
		}
		ICollectionView defaultView = CollectionViewSource.GetDefaultView(CWuLnFtT2qR);
		defaultView.GroupDescriptions.Add(new PropertyGroupDescription("ExeDisplayName"));
		defaultView.SortDescriptions.Add(new SortDescription("ExeFile", ListSortDirection.Ascending));
		defaultView.SortDescriptions.Add(new SortDescription("ListOrder", ListSortDirection.Ascending));
		ComboBoxProfiles.ItemsSource = defaultView;
	}

	private void vnALnAA4r1X(object sender, RoutedEventArgs e)
	{
	}

	public override void SetData(ActionItem actionItem)
	{
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
		_003C_003Ec__DisplayClass5_.anxS3Wf51hD = actionItem;
		int num = 0;
		if (!O0D4xEFiOb5iviimUh4A())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		XXxLnlsg4S2 = true;
		JwjLnUTVZcf = _003C_003Ec__DisplayClass5_.anxS3Wf51hD;
		if (_003C_003Ec__DisplayClass5_.anxS3Wf51hD != null && !string.IsNullOrEmpty(_003C_003Ec__DisplayClass5_.anxS3Wf51hD.Data))
		{
			ProfileConfigItem profileConfigItem = CWuLnFtT2qR.SingleOrDefault(_003C_003Ec__DisplayClass5_.VfCS3IH15Zc);
			if (profileConfigItem != null)
			{
				ComboBoxProfiles.SelectedItem = profileConfigItem;
			}
		}
		XXxLnlsg4S2 = false;
	}

	public override void SaveData(ActionItem actionItem)
	{
		if (ComboBoxProfiles.SelectedItem == null)
		{
			actionItem.Data = "";
			return;
		}
		ProfileConfigItem profileConfigItem = ComboBoxProfiles.SelectedItem as ProfileConfigItem;
		actionItem.Data = (string.IsNullOrEmpty(profileConfigItem.Id) ? profileConfigItem.Name : profileConfigItem.Id);
	}

	private void VkDLnOPKZPv(object sender, SelectionChangedEventArgs e)
	{
		if (!XXxLnlsg4S2 && ComboBoxProfiles.SelectedItem != null)
		{
			ProfileConfigItem profileConfigItem = ComboBoxProfiles.SelectedItem as ProfileConfigItem;
			JwjLnUTVZcf.Title = profileConfigItem.DisplayName;
			OnDataChanged();
		}
		XXxLnlsg4S2 = false;
	}

	public override (bool isSuccess, string message) Validate()
	{
		if (ComboBoxProfiles.SelectedItem == null)
		{
			return (isSuccess: false, message: "请选择要加载的动作页。");
		}
		return (isSuccess: true, message: "");
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!fCuLniJZhqi)
		{
			fCuLniJZhqi = true;
			Uri resourceLocator = new Uri("/Quicker;component/actions/basicactions/editcontrols/openprofileactionparameditor.xaml", UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 1)
		{
			ComboBoxProfiles = (ComboBox)target;
			ComboBoxProfiles.SelectionChanged += VkDLnOPKZPv;
		}
		else
		{
			fCuLniJZhqi = true;
		}
	}

	internal static bool O0D4xEFiOb5iviimUh4A()
	{
		return SZowJiFidPHb75Objs0R == null;
	}
}
