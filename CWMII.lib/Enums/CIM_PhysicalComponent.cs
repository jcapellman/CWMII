namespace CWMII.lib.Enums {
	public enum CIM_PhysicalComponent {
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

	public static class CIM_PhysicalComponentExtension {
		public static string GetWMIValue(this CIM_PhysicalComponent enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_PhysicalComponent", enumOption.ToString());
	}
}