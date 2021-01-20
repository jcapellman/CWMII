namespace CWMII.lib.Enums {
	public enum Win32_PhysicalMemoryArray {
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
		Location,
		MaxCapacity,
		MaxCapacityEx,
		MemoryDevices,
		MemoryErrorCorrection,
		Use
	}

	public static class Win32_PhysicalMemoryArrayExtension {
		public static string GetWMIValue(this Win32_PhysicalMemoryArray enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PhysicalMemoryArray", enumOption.ToString());
	}
}