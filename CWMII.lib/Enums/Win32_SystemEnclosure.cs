namespace CWMII.lib.Enums {
	public enum Win32_SystemEnclosure {
		Caption,
		Description,
		InstallDate,
		Name,
		Status,
		CreationClassName,
		Manufacturer,
		Model,
		OtherIdentifyingInfo,
		PartNumber,
		PoweredOn,
		SerialNumber,
		SKU,
		Tag,
		Version,
		Depth,
		Height,
		HotSwappable,
		Removable,
		Replaceable,
		Weight,
		Width,
		AudibleAlarm,
		BreachDescription,
		CableManagementStrategy,
		LockPresent,
		SecurityBreach,
		ServiceDescriptions,
		ServicePhilosophy,
		VisibleAlarm,
		ChassisTypes,
		CurrentRequiredOrProduced,
		HeatGeneration,
		NumberOfPowerCords,
		TypeDescriptions,
		SecurityStatus,
		SMBIOSAssetTag
	}

	public static class Win32_SystemEnclosureExtension {
		public static string GetWMIValue(this Win32_SystemEnclosure enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_SystemEnclosure", enumOption.ToString());
	}
}