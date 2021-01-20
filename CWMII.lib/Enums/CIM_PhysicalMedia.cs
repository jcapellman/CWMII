namespace CWMII.lib.Enums {
	public enum CIM_PhysicalMedia {
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
		Capacity,
		CleanerMedia,
		MediaDescription,
		MediaType,
		WriteProtectOn
	}

	public static class CIM_PhysicalMediaExtension {
		public static string GetWMIValue(this CIM_PhysicalMedia enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_PhysicalMedia", enumOption.ToString());
	}
}