namespace CWMII.lib.Enums {
	public enum Win32_BaseBoard {
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

	public static class Win32_BaseBoardExtension {
		public static string GetWMIValue(this Win32_BaseBoard enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_BaseBoard", enumOption.ToString());
	}
}