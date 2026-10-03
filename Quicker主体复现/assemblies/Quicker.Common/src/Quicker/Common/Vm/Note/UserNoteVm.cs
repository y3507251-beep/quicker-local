using Quicker.Common.Entities;

namespace Quicker.Common.Vm.Note;

public class UserNoteVm
{
	public UserObjectType ObjectType { get; set; }

	public string ObjectId { get; set; }

	public string DisplayName { get; set; }

	public string Note { get; set; }
}
