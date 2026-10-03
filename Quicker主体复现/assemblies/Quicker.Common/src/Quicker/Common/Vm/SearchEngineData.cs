using System.Collections.Generic;

namespace Quicker.Common.Vm;

public class SearchEngineData
{
	public List<SearchEngineDto> SearchEngines { get; set; }

	public List<SearchEngineCategoryDto> SearchEngineCategories { get; set; }
}
