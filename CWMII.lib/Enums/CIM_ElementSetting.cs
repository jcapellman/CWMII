namespace CWMII.lib.Enums {
	public enum CIM_ElementSetting {
		Element,
		Setting
	}

	public static class CIM_ElementSettingExtension {
		public static string GetWMIValue(this CIM_ElementSetting enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM CIM_ElementSetting", enumOption.ToString());
	}
}