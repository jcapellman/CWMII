namespace CWMII.lib.Enums {
	public enum CIM_PhysicalElement {
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
		DeviceType,
		Enabled
	}

	public static class CIM_PhysicalElementExtension {
		public static string GetWMIValue(this CIM_PhysicalElement enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_PhysicalElement", enumOption.ToString());
	}
}