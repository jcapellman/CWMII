namespace CWMII.lib.Enums {
	public enum CIM_VideoSetting {
		Element,
		Setting
	}

	public static class CIM_VideoSettingExtension {
		public static string GetWMIValue(this CIM_VideoSetting enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_VideoSetting", enumOption.ToString());
	}
}