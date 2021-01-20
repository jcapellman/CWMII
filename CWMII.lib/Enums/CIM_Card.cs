namespace CWMII.lib.Enums {
	public enum CIM_Card {
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
		HostingBoard,
		RequirementsDescription,
		RequiresDaughterBoard,
		SlotLayout,
		SpecialRequirements,
		ConfigOptions,
		Product
	}

	public static class CIM_CardExtension {
		public static string GetWMIValue(this CIM_Card enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_Card", enumOption.ToString());
	}
}