namespace CWMII.lib.Enums {
	public enum CIM_PhysicalPackage {
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

	public static class CIM_PhysicalPackageExtension {
		public static string GetWMIValue(this CIM_PhysicalPackage enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_PhysicalPackage", enumOption.ToString());
	}
}