namespace CWMII.lib.Enums {
	public enum CIM_Chip {
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

	public static class CIM_ChipExtension {
		public static string GetWMIValue(this CIM_Chip enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_Chip", enumOption.ToString());
	}
}