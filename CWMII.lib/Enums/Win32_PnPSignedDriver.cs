namespace CWMII.lib.Enums {
	public enum Win32_PnPSignedDriver {
		Caption,
		Description,
		InstallDate,
		Name,
		Status,
		CreationClassName,
		Started,
		StartMode,
		SystemCreationClassName,
		SystemName,
		ClassGuid,
		CompatID,
		DeviceClass,
		DeviceID,
		DeviceName,
		DevLoader,
		DriverDate,
		DriverName,
		DriverProviderName,
		DriverVersion,
		FriendlyName,
		HardWareID,
		InfName,
		IsSigned,
		Location,
		Manufacturer,
		PDO,
		Signer
	}

	public static class Win32_PnPSignedDriverExtension {
		public static string GetWMIValue(this Win32_PnPSignedDriver enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PnPSignedDriver", enumOption.ToString());
	}
}