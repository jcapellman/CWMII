namespace CWMII.lib.Enums {
	public enum Win32_PhysicalMedia {
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

	public static class Win32_PhysicalMediaExtension {
		public static string GetWMIValue(this Win32_PhysicalMedia enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PhysicalMedia", enumOption.ToString());
	}
}