namespace CWMII.lib.Enums {
	public enum Win32_OnBoardDevice {
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

	public static class Win32_OnBoardDeviceExtension {
		public static string GetWMIValue(this Win32_OnBoardDevice enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_OnBoardDevice", enumOption.ToString());
	}
}