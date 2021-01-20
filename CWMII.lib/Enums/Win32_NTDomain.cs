namespace CWMII.lib.Enums {
	public enum Win32_NTDomain {
		Caption,
		Description,
		InstallDate,
		Name,
		Status,
		CreationClassName,
		NameFormat,
		PrimaryOwnerContact,
		PrimaryOwnerName,
		Roles,
		ClientSiteName,
		DcSiteName,
		DnsForestName,
		DomainControllerAddress,
		DomainControllerAddressType,
		DomainControllerName,
		DomainGuid,
		DomainName,
		DSDirectoryServiceFlag,
		DSDnsControllerFlag,
		DSDnsDomainFlag,
		DSDnsForestFlag,
		DSGlobalCatalogFlag,
		DSKerberosDistributionCenterFlag,
		DSPrimaryDomainControllerFlag,
		DSTimeServiceFlag,
		DSWritableFlag
	}

	public static class Win32_NTDomainExtension {
		public static string GetWMIValue(this Win32_NTDomain enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_NTDomain", enumOption.ToString());
	}
}