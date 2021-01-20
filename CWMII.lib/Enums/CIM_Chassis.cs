namespace CWMII.lib.Enums {
	public enum CIM_Chassis {
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

	public static class CIM_ChassisExtension {
		public static string GetWMIValue(this CIM_Chassis enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_Chassis", enumOption.ToString());
	}
}