namespace CWMII.lib.Enums {
	public enum Win32_SoftwareElementCheck {
		Check,
		Element,
		Phase
	}

	public static class Win32_SoftwareElementCheckExtension {
		public static string GetWMIValue(this Win32_SoftwareElementCheck enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_SoftwareElementCheck", enumOption.ToString());
	}
}