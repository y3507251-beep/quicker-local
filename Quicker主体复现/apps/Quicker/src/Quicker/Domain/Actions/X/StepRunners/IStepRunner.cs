using System.Collections.Generic;
using Quicker.Domain.Actions.X.Storage;

namespace Quicker.Domain.Actions.X.StepRunners;

public interface IStepRunner : IStepRunningInfo
{
	string Key { get; }

	string Name { get; }

	IEnumerable<string> KeyWords { get; }

	string Icon { get; }

	StepRunnerCategory Category { get; }

	IEnumerable<StepRunnerCategory> SecondaryCategories { get; }

	string Description { get; }

	StepType StepType { get; }

	string HelpLink { get; }

	bool IsRisky { get; }

	bool IsProOnly { get; }
}
