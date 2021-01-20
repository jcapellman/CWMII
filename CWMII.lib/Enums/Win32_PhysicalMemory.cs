namespace CWMII.lib.Enums {
	public enum Win32_PhysicalMemory {
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

	public static class Win32_PhysicalMemoryExtension {
		public static string GetWMIValue(this Win32_PhysicalMemory enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PhysicalMemory", enumOption.ToString());
	}
}