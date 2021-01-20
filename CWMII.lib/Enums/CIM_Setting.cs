namespace CWMII.lib.Enums {
	public enum CIM_Setting {
		Caption,
		Description,
		SettingID,
		MaximumScripts,
		Timeout
	}

	public static class CIM_SettingExtension {
		public static string GetWMIValue(this CIM_Setting enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_Setting", enumOption.ToString());
	}
}