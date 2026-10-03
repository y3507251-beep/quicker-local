using System.Runtime.InteropServices;

namespace CW.Win32;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("4e530b0a-e611-4c77-a3ac-9031d022281b")]
public interface IApplicationAssociationRegistration
{
	int QueryCurrentDefault(string pszQuery, AssociationType atQueryType, AssociationLevel alQueryLevel, out string ppszAssociation);

	int QueryAppIsDefault(string pszQuery, AssociationType atQueryType, AssociationLevel alQueryLevel, string pszAppRegistryName, out bool pfDefault);

	int QueryAppIsDefaultAll(AssociationLevel alQueryLevel, string pszAppRegistryName, out bool pfDefault);

	int SetAppAsDefault(string pszAppRegistryName, string pszSet, AssociationType atSetType);

	int SetAppAsDefaultAll(string pszAppRegistryName);

	int ClearUserAssociations();
}
