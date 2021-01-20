namespace CWMII.lib.Enums {
	public enum CIM_PhysicalFrame {
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

	public static class CIM_PhysicalFrameExtension {
		public static string GetWMIValue(this CIM_PhysicalFrame enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_PhysicalFrame", enumOption.ToString());
	}
}