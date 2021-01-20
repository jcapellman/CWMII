namespace CWMII.lib.Enums {
	public enum Win32_Product {
		Caption,
		Description,
		IdentifyingNumber,
		Name,
		SKUNumber,
		Vendor,
		Version,
		AssignmentType,
		HelpLink,
		HelpTelephone,
		InstallDate,
		InstallDate2,
		InstallLocation,
		InstallSource,
		InstallState,
		Language,
		LocalPackage,
		PackageCache,
		PackageCode,
		PackageName,
		ProductID,
		RegCompany,
		RegOwner,
		Transforms,
		URLInfoAbout,
		URLUpdateInfo,
		WordCount
	}

	public static class Win32_ProductExtension {
		public static string GetWMIValue(this Win32_Product enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_Product", enumOption.ToString());
	}
}