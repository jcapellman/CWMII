namespace CWMII.lib.Enums {
	public enum CIM_PhysicalMemory {
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
		HotSwappable,
		Removable,
		Replaceable,
		FormFactor,
		BankLabel,
		Capacity,
		DataWidth,
		InterleavePosition,
		MemoryType,
		PositionInRow,
		Speed,
		TotalWidth,
		Attributes,
		ConfiguredClockSpeed,
		ConfiguredVoltage,
		DeviceLocator,
		InterleaveDataDepth,
		MaxVoltage,
		MinVoltage,
		SMBIOSMemoryType,
		TypeDetail
	}

	public static class CIM_PhysicalMemoryExtension {
		public static string GetWMIValue(this CIM_PhysicalMemory enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_PhysicalMemory", enumOption.ToString());
	}
}